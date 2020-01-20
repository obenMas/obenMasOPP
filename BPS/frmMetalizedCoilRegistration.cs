using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmMetalizedCoilRegistration : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        clsProduct objProduct = new clsProduct();
        clsMetallizedOrder objMetallizedOrder = new clsMetallizedOrder();

        int originalCoil = 0;
        int originalfkBopp = 0;
        string metalizedCode = "";
        int metalizedCellarCodsec = 0;
        string year = "";
        string month = "";
        int isExternal = 0;
        string lotNumber = "";
        int metalizedMachineNumber = 0;

        public frmMetalizedCoilRegistration()
        {
            InitializeComponent();
        }
        public frmMetalizedCoilRegistration(int metallizedOrderCodsec)
        {
            InitializeComponent();
            objMetallizedOrder.load(metallizedOrderCodsec);
        }

        public string getMetalizedCode(int coilCodsec)
        {
            objCoil.load(coilCodsec);
            List<clsCoil> lstCoilCode = new List<clsCoil>();
            int nextSequential = 0;
            string line = "";

            DataSet DS = clsConnection.getDataSetResult("spGetNextMetalizedCoilSequential");

            if (DS.Tables.Count > 0)
            {
                if (DS.Tables[0].Rows.Count > 0)
                {
                    nextSequential = Convert.ToInt32(DS.Tables[0].Rows[0]["nextSequential"]);
                }
            }

            if (objCoil.isExternalCoil == true)
                line = "5";
            else
                line = "4";

            metalizedCode = DateTime.Now.ToString("yy").Substring(1) + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + line + clsGlobal.FillWithZeros(nextSequential.ToString(), 3);


            return metalizedCode;
        }
        private string getLotNumber()
        {
            metalizedMachineNumber = 1;//Convert.ToInt32(objMetallizedOrder.MachineNumber);

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
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
        }
        private void frmRewindCoil_Load(object sender, EventArgs e)
        {
            //objCoil = clsCoil.getDetailByCode(objCoil.code);
            //originalCoil = objCoil.codsec;
            //originalfkBopp = objCoil.fkBopp;
            //originalfkCast = objCoil.fkCast;

            //originalMainCoilCode = objCoil.mainCoilCode;
            //originalLotNumber = objCoil.lotNumber;
            //objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
            //objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);
            //objProduct.load(objCoil.fkProduct);

            tbpRewinedCoil.Enabled = false;
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();

            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);

            //if (objCoil.codsec != 0)
            //{
            //    //if (objCoilCellar.isRewindCellar)
            //    //{
            //    txtOriginalCode.Text = objCoil.code;
            //    lblOriginalQuality.Text = objCoil.CuttingQualityName;
            //    lblOriginalDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
            //    lblOriginalDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
            //    lblOriginalNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
            //    lblOriginalGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
            //    lblOriginalLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
            //    lblOriginalCellar.Text = objCoil.Coil_CoilCellarContainer.name;
            //    lblOriginalWidth.Text = objCoil.width.ToString();
            //    lblOriginalFilmName.Text = objProduct.name;

            //    if (objCoil.treatmentSide == "Externo")
            //        rdoTreatmentExternal.Checked = true;
            //    else if (objCoil.treatmentSide == "Interno")
            //        rdoTreatmentInner.Checked = true;
            //    else if (objCoil.treatmentSide == "Doble")
            //        rdoTreatmentDouble.Checked = true;
            //    else if (objCoil.treatmentSide == "Sin tratamiento")
            //        rdoTreatmentWithout.Checked = true;

            //    txtOriginalNotes.Text = objCoil.notes;

            //    //}
            //    //else
            //    //{
            //    //    MessageBox.Show("La bobina seleccionada no se encuentra en la bodega correspondiente para realizar el rebobinado.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            //    //    lblOriginalQualityLabel.Text = "";
            //    //    lblOriginalDiameterLabel.Text = "0";
            //    //    lblOriginalDensity.Text = "0";
            //    //    lblOriginalNetWeigth.Text = "0";
            //    //    lblOriginalGrossWeigthLabel.Text = "0";
            //    //    lblOriginalLength.Text = "0";
            //    //    lblOriginalCellar.Text = "";
            //    //    lblOriginalWidth.Text = "0";
            //    //    lblOriginalQuality.Text = "";
            //    //    txtOriginalCode.Text = "";
            //    //    objCoil = new clsCoil();
            //    //}
            //}
        }
        private void txtOriginalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objCoil = clsCoil.getDetailByCode(txtOriginalCode.Text);
                objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
                objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);
                objProduct.load(objCoil.fkProduct);

                if (objCoil.codsec != 0)
                {
                    if (objCoilCellar.isRewindCellar)
                    {
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

                        txtNotes.Text = objCoil.notes;
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
                        txtOriginalCode.Text = "";
                        txtOriginalCode.Focus();
                        objCoil = new clsCoil();
                    }
                }
            }
        }

        private void btnRewind_Click(object sender, EventArgs e)
        {
            int lastDigit = 0;

            tbpRewinedCoil.Enabled = true;
            tbcRewind.SelectedIndex = 1;
            lastDigit = Convert.ToInt32(txtOriginalCode.Text.Substring(txtOriginalCode.Text.Length - 1));
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
/*
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
                    objCoilByCoil.length = Convert.ToDouble(txtLength.Text);
                    objCoilByCoil.save();

                    clsCoil.setCoilAsReprocesed(originalCoil);

                    List<clsCoilCellar> lstCoilMetalizedCellar = new List<clsCoilCellar>();
                    lstCoilMetalizedCellar = clsCoilCellar.getMetallizedCellarList();

                    for (int i = 0; i < lstCoilMetalizedCellar.Count; i++)
                    {
                        metalizedCellarCodsec = lstCoilMetalizedCellar[i].codsec;
                    }

                    clsCoilByCoilCellar objCoilInByCoilCellar = new clsCoilByCoilCellar();
                    objCoilInByCoilCellar.fkCoil = objCoilByCoil.fkDestinationCoil;
                    objCoilInByCoilCellar.fkCoilCellar = metalizedCellarCodsec;
                    objCoilInByCoilCellar.In = true;
                    objCoilInByCoilCellar.Out = false;
                    objCoilInByCoilCellar.save();

                    if (MessageBox.Show("Desea imprimir la etiqueta?", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        if (cmbQuality.Text != "Observación")
                        {
                            if (objCoil.customerName != "CONFITECA")
                            {
                                if (objCoil.ProductCode.StartsWith("M"))
                                {
                                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objCoil.codsec, false); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                }
                                else
                                {
                                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, false); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                }
                            }
                            else
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, false); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                        }
                        else
                            clsPrintLabels.printObservationCoilLabel(objCoil.codsec);

                    }
                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Rebobinado de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
*/
        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
