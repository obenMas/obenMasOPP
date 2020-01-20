using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMetalizedCoil : Form
    {
        clsCoil objCoil = new clsCoil();

        clsCoilCellar objCoilCellar = new clsCoilCellar();

        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsProduct objProduct = new clsProduct();
        clsMetallizedOrder objMetallizedOrder = new clsMetallizedOrder();

        int originalCoil = 0;
        int originalfkBopp = 0;
        int originalfkCast = 0;
        string metalizedCode = "";
        string originalMainCoilCode = "";
        string originalLotNumber = "";
        int metalizedCellarCodsec = 0;
        string year = "";
        string month = "";
        string secuencial = null;
        int source = 0;
        int newSecuencial = 0;
        int a = 0;
        int isExternal = 0;
        string lotNumber = "";
        int metalizedMachineNumber = 0;




        public frmMetalizedCoil()
        {
            InitializeComponent();
        }


        public frmMetalizedCoil(int coilCodsec, int metallizedOrderCodsec)
        {
            InitializeComponent();
            objCoil.load(coilCodsec);
            objMetallizedOrder.load(metallizedOrderCodsec);
        }

        // FUNCION  getMetalizedCode  PARA FORMAR LOS CODIGOS DE METALIZADO PARA LA PLANTA DE ECUADOR

        public string getMetalizedCode(int coilCodsec)
        {
            objCoil.load(coilCodsec);
            List<clsCoil> lstCoilCode = new List<clsCoil>();

            if (objCoil.isExternalCoil == true & objCoil.fkBopp > 0)
            {

                lstCoilCode = clsCoil.getLastBoppExternalMetalizedCoilCode();
                isExternal = 1;

                for (int i = 0; i < lstCoilCode.Count; i++)
                {
                    metalizedCode = lstCoilCode[i].code.ToString();
                }

                if (metalizedCode == "")
                {
                    secuencial = "0001";
                    year = DateTime.Now.ToString("yy");
                    month = DateTime.Now.ToString("MM");
                    source = 5;
                    switch (month)
                    {
                        case "10":
                            month = "A";
                            break;

                        case "11":
                            month = "B";
                            break;

                        case "12":
                            month = "C";
                            break;
                        default:
                            month = month.Substring(1, 1);
                            break;

                    }
                    metalizedCode = year + month + source + secuencial;
                }
                else
                {
                    year = DateTime.Now.ToString("yy");
                    month = DateTime.Now.ToString("MM");
                    source = 5;
                    switch (month)
                    {
                        case "10":
                            month = "A";
                            break;

                        case "11":
                            month = "B";
                            break;

                        case "12":
                            month = "C";
                            break;
                        default:
                            month = month.Substring(1, 1);
                            break;
                    }

                    secuencial = metalizedCode.Substring(4, 4);
                    newSecuencial = int.Parse(secuencial);
                    newSecuencial = newSecuencial + 1;
                    secuencial = newSecuencial.ToString();

                    a = secuencial.Length;

                    switch (a)
                    {
                        case 1:
                            secuencial = "000" + secuencial;
                            break;

                        case 2:
                            secuencial = "00" + secuencial;

                            break;

                        case 3:
                            secuencial = "0" + secuencial;
                            break;

                        default:
                            break;
                    }

                    metalizedCode = year + month + source + secuencial;

                }
            }

            else
            {
                if (objCoil.isExternalCoil == true & objCoil.fkCast > 0)
                {
                    lstCoilCode = clsCoil.getLastCastExternalMetalizedCoilCode();
                    isExternal = 1;

                    for (int i = 0; i < lstCoilCode.Count; i++)
                    {
                        metalizedCode = lstCoilCode[i].code.ToString();
                    }
                    if (metalizedCode == "")
                    {
                        secuencial = "0001";
                        year = DateTime.Now.ToString("yy");
                        month = DateTime.Now.ToString("MM");
                        source = 5;
                        switch (month)
                        {
                            case "10":
                                month = "A";
                                break;

                            case "11":
                                month = "B";
                                break;

                            case "12":
                                month = "C";
                                break;
                            default:
                                month = month.Substring(1, 1);
                                break;

                        }
                        metalizedCode = year + month + source + secuencial;
                    }
                    else
                    {
                        year = DateTime.Now.ToString("yy");
                        month = DateTime.Now.ToString("MM");
                        source = 5;
                        switch (month)
                        {
                            case "10":
                                month = "A";
                                break;

                            case "11":
                                month = "B";
                                break;

                            case "12":
                                month = "C";
                                break;
                            default:
                                month = month.Substring(1, 1);
                                break;
                        }

                        secuencial = metalizedCode.Substring(5, 4);
                        newSecuencial = int.Parse(secuencial);
                        newSecuencial = newSecuencial + 1;
                        secuencial = newSecuencial.ToString();

                        a = secuencial.Length;

                        switch (a)
                        {
                            case 1:
                                secuencial = "000" + secuencial;
                                break;

                            case 2:
                                secuencial = "00" + secuencial;

                                break;

                            case 3:
                                secuencial = "0" + secuencial;
                                break;



                            default:
                                break;
                        }

                        metalizedCode = year + month + source + secuencial;

                    }
                }
                else
                {
                    if (objCoil.isExternalCoil == false & objCoil.fkBopp > 0)
                    {
                        lstCoilCode = clsCoil.getLastBoppInternalMetalizedCoilCode();

                        for (int i = 0; i < lstCoilCode.Count; i++)
                        {
                            metalizedCode = lstCoilCode[i].code.ToString();
                        }
                        if (metalizedCode == "")
                        {
                            secuencial = "0001";
                            year = DateTime.Now.ToString("yy");
                            month = DateTime.Now.ToString("MM");
                            source = 5;
                            switch (month)
                            {
                                case "10":
                                    month = "A";
                                    break;

                                case "11":
                                    month = "B";
                                    break;

                                case "12":
                                    month = "C";
                                    break;
                                default:
                                    month = month.Substring(1, 1);
                                    break;

                            }
                            metalizedCode = year + month + source + secuencial;
                        }
                        else
                        {
                            year = DateTime.Now.ToString("yy");
                            month = DateTime.Now.ToString("MM");
                            source = 5;
                            switch (month)
                            {
                                case "10":
                                    month = "A";
                                    break;

                                case "11":
                                    month = "B";
                                    break;

                                case "12":
                                    month = "C";
                                    break;
                                default:
                                    month = month.Substring(1, 1);
                                    break;
                            }

                            secuencial = metalizedCode.Substring(5, 4);
                            newSecuencial = int.Parse(secuencial);
                            newSecuencial = newSecuencial + 1;
                            secuencial = newSecuencial.ToString();

                            a = secuencial.Length;

                            switch (a)
                            {
                                case 1:
                                    secuencial = "000" + secuencial;
                                    break;

                                case 2:
                                    secuencial = "00" + secuencial;

                                    break;

                                case 3:
                                    secuencial = "0" + secuencial;
                                    break;



                                default:
                                    break;
                            }

                            metalizedCode = year + month + source + secuencial;

                        }

                    }
                    else
                    {
                        if (objCoil.isExternalCoil == false & objCoil.fkBopp > 0)
                        {
                            lstCoilCode = clsCoil.getLastCastInternalMetalizedCoilCode();

                            for (int i = 0; i < lstCoilCode.Count; i++)
                            {
                                metalizedCode = lstCoilCode[i].code.ToString();
                            }
                            if (metalizedCode == "")
                            {
                                secuencial = "0001";
                                year = DateTime.Now.ToString("yy");
                                month = DateTime.Now.ToString("MM");
                                source = 5;
                                switch (month)
                                {
                                    case "10":
                                        month = "A";
                                        break;

                                    case "11":
                                        month = "B";
                                        break;

                                    case "12":
                                        month = "C";
                                        break;
                                    default:
                                        month = month.Substring(1, 1);
                                        break;

                                }
                                metalizedCode = year + month + source + secuencial;
                            }
                            else
                            {
                                year = DateTime.Now.ToString("yy");
                                month = DateTime.Now.ToString("MM");
                                source = 5;
                                switch (month)
                                {
                                    case "10":
                                        month = "A";
                                        break;

                                    case "11":
                                        month = "B";
                                        break;

                                    case "12":
                                        month = "C";
                                        break;
                                    default:
                                        month = month.Substring(1, 1);
                                        break;
                                }

                                secuencial = metalizedCode.Substring(5, 4);
                                newSecuencial = int.Parse(secuencial);
                                newSecuencial = newSecuencial + 1;
                                secuencial = newSecuencial.ToString();

                                a = secuencial.Length;

                                switch (a)
                                {
                                    case 1:
                                        secuencial = "000" + secuencial;
                                        break;

                                    case 2:
                                        secuencial = "00" + secuencial;

                                        break;

                                    case 3:
                                        secuencial = "0" + secuencial;
                                        break;


                                    default:
                                        break;
                                }

                                metalizedCode = year + month + source + secuencial;

                            }

                        }
                    }

                }
            }

            return metalizedCode;
        }

        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref lblDensity, ref lblDensityLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtGrossWeigth, ref lblGrossWeigth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQuality, "selected")) isValid = false;

            return isValid;
        }
        private void printCoilLabel(int coilCodsec)
        {
            if (objCoil.isExternalCoil == false)
            {
                Reports.rptCoilLabel rptCoilLabel = new Reports.rptCoilLabel();

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
            else
            {
                Reports.rptOppCoilLabel rptCoilLabel = new Reports.rptOppCoilLabel();

                Tables tables;

                tables = rptCoilLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCoilLabel.ReportDefinition.Sections;
                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;
                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;
                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                            tables = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                            {
                                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
        }
        private void printObservationCoilLabel(int coilCodsec)
        {
            Reports.rptCoilLabelObservation rptCoilLabel = new Reports.rptCoilLabelObservation();

            ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
            prmCoilCodsec.Value = coilCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "mainCoilCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
            {
                switch (rptCoilLabel.ParameterFields[i].Name)
                {
                    case "coilCodsec":
                        rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                        rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
        }




        private void frmMetalizedCoil_Load(object sender, EventArgs e)
        {
            objCoil = clsCoil.getDetailByCode(objCoil.code);
            originalCoil = objCoil.codsec;
            originalfkBopp = objCoil.fkBopp;
            originalfkCast = objCoil.fkCast;

            originalMainCoilCode = objCoil.mainCoilCode;
            originalLotNumber = objCoil.lotNumber;
            objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
            objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);
            objProduct.load(objCoil.fkProduct);

            tbpRewinedCoil.Enabled = false;
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();

            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);

            if (objCoil.codsec != 0)
            {
                if (objCoilCellar.isRewindCellar)
                {
                    lblOriginalCode.Text = objCoil.code;
                    lblOriginalQuality.Text = objCoil.CuttingQualityName;
                    lblOriginalDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
                    lblOriginalDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                    lblOriginalNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                    lblOriginalGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                    lblOriginalLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                    lblOriginalCellar.Text = objCoil.Coil_CoilCellarContainer.name;
                    lblOriginalWidth.Text = objCoil.width.ToString();
                    lblOriginalFilmName.Text = objProduct.name;

                    if (objCoil.treatmentSide == "Externo")
                        rdoTreatmentExternal.Checked = true;
                    else if (objCoil.treatmentSide == "Interno")
                        rdoTreatmentInner.Checked = true;
                    else if (objCoil.treatmentSide == "Doble")
                        rdoTreatmentDouble.Checked = true;
                    else if (objCoil.treatmentSide == "Sin tratamiento")
                        rdoTreatmentWithout.Checked = true;

                    txtOriginalNotes.Text = objCoil.notes;

                }
                else
                {
                    MessageBox.Show("La bobina seleccionada no se encuentra en la bodega correspondiente para realizar el rebobinado.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    lblOriginalQualityLabel.Text = "";
                    lblOriginalDiameterLabel.Text = "0";
                    lblOriginalDensity.Text = "0";
                    lblOriginalNetWeigth.Text = "0";
                    lblOriginalGrossWeigthLabel.Text = "0";
                    lblOriginalLength.Text = "0";
                    lblOriginalCellar.Text = "";
                    lblOriginalWidth.Text = "0";
                    lblOriginalQuality.Text = "";
                    lblOriginalCode.Text = "";
                    objCoil = new clsCoil();
                }
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            int lastDigit = 0;

            tbpRewinedCoil.Enabled = true;
            tbcRewind.SelectedIndex = 1;
            lastDigit = Convert.ToInt32(lblOriginalCode.Text.Substring(lblOriginalCode.Text.Length - 1));
            /*
             CODIGO DE BOBINA METALIZADA 
             * 
             lastDigit++;
             lblCode.Text = lblOriginalCode.Text.Substring(0, lblOriginalCode.Text.Length - 1) + lastDigit.ToString();
              */

            //NUEVA CODIFICACION PARA BOBINAS METALIZADAS DE ECUADOR

            lblFilmName.Text = lblOriginalFilmName.Text;

            lblCode.Text = getMetalizedCode(originalCoil);

            lblWidth.Text = lblOriginalWidth.Text;
        }

        private string getLotNumber()
        {
            metalizedMachineNumber = Convert.ToInt32(objMetallizedOrder.MachineNumber);

            year = DateTime.Now.ToString("yy");
            month = DateTime.Now.ToString("MM");

            switch (month)
            {
                case "10":
                    month = "A";
                    break;

                case "11":
                    month = "B";
                    break;

                case "12":
                    month = "C";
                    break;
                default:
                    month = month.Substring(1, 1);
                    break;
            }

            lotNumber = year + month + metalizedMachineNumber + objMetallizedOrder.number.ToString();

            return lotNumber;
        }

        private void txtGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtGrossWeigth.Text))
            {
                if (txtGrossWeigth.Text != "0")
                {
                    double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);
                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2));
                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
            }
            else
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsCoilCellar objMetalizedCoilCellar = new clsCoilCellar();
            objMetalizedCoilCellar = clsCoilCellar.getCellarByName("Metalizado");
            clsCoil objCoil = new clsCoil();

            lotNumber = getLotNumber();

            if (validateForm())
            {
                objCoil.fkBalance = 1;
                objCoil.fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                objCoil.code = lblCode.Text;
                objCoil.mainCoilCode = lblCode.Text;
                objCoil.lotNumber = lotNumber;
                objCoil.fkProduct = objMetallizedOrder.fkproductTo;
                objCoil.length = Convert.ToDouble(txtLength.Text);
                objCoil.width = objProduct.width;
                objCoil.diameter = Convert.ToDouble(txtDiameter.Text);
                objCoil.density = Convert.ToDouble(lblDensity.Text);
                objCoil.netWeight = Convert.ToDouble(lblNetWeigth.Text);
                objCoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                objCoil.createdDate = DateTime.Now;
                objCoil.modifiedDate = DateTime.Now;
                objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;
                objCoil.createdBy = clsGlobal.LoggedUser.codsec;
                objCoil.isExternalCoil = Convert.ToBoolean(isExternal);
                objCoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                objCoil.notes = txtNotes.Text;
                objCoil.wasRewined = true;

                if (objCoil.save(0, 0, objMetalizedCoilCellar.codsec, 0))
                {
                    MessageBox.Show("El proceso de metalizado se ha registrado con éxito, por favor imprima las nuevas etiquetas de la bobina.", "Metalizado de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    
                    /* SE COMENTO POR QUE SE REUTILIZO LA CLASE CLSCOILBYCOIL
                    clsCoilByCoil objCoilByCoil = new clsCoilByCoil();
                    objCoilByCoil.fkOriginCoil = originalCoil;
                    if (originalfkBopp != 0)
                    {
                        objCoilByCoil.fkDestinationCoil = clsCoil.getLastMetalizedCoilSavedCodsec();
                    }
                    else
                    {
                        objCoilByCoil.fkDestinationCoil = clsCoil.getLastCastMetalizedCoilSavedCodsec();
                    }

                    objCoilByCoil.fkMetallizedOrder = objMetallizedOrder.codsec;
                    objCoilByCoil.save();
                    */



                    //ACA LA BOBINA ORIGINAL PASA A ESTADO 34 (BOBINA REPROCESADA) Y EN COILCELLAR GRABAR LA SALIDA  E INGRESO DE LA NUEVA BOBINA A LA BODEGA DE METALIZADO

                    clsCoil.setCoilAsReprocesed(originalCoil);



                    List<clsCoilCellar> lstCoilMetalizedCellar = new List<clsCoilCellar>();
                    lstCoilMetalizedCellar = clsCoilCellar.getMetallizedCellarList();

                    for (int i = 0; i < lstCoilMetalizedCellar.Count; i++)
                    {
                        metalizedCellarCodsec = lstCoilMetalizedCellar[i].codsec;

                    }


                    clsCoilByCoilCellar objCoilInByCoilCellar = new clsCoilByCoilCellar();
                    //objCoilInByCoilCellar.fkCoil = objCoilByCoil.fkDestinationCoil; SE COMENTO POR QUE SE REUTILIZO LA CLASE CLSCOILBYCOIL
                    objCoilInByCoilCellar.fkCoilCellar = metalizedCellarCodsec;
                    objCoilInByCoilCellar.In = true;
                    objCoilInByCoilCellar.Out = false;
                    objCoilInByCoilCellar.save();
                    //FIN
                    if (MessageBox.Show("Desea imprimir la etiqueta?", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        if (cmbQuality.Text != "Observación")
                        {
                            Thread thrdPrint = new Thread(delegate() { printCoilLabel(objCoil.codsec); });
                            thrdPrint.Start();
                        }
                        else
                            printObservationCoilLabel(objCoil.codsec);

                    }
                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Rebobinado de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}

















