using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;

namespace BPS
{
    public partial class frmCoilEditor : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        clsProduct objProduct = new clsProduct();
        bool flgIsChangingNewWeigth = false;
        int isActualQuality = 0;
        frmInProcessCoils form = new frmInProcessCoils();
        bool returnwanted = false;

        public frmCoilEditor()
        {
            InitializeComponent();
        }
        public frmCoilEditor(int coilCodsec)
        {
            objCoil = new clsCoil(coilCodsec);
            isActualQuality = objCoil.fkCuttingQuality;
            objProduct = new clsProduct(objCoil.fkProduct);

            InitializeComponent();
        }
        public frmCoilEditor(int coilCodsec, frmInProcessCoils form)
        {
            objCoil = new clsCoil(coilCodsec);
            isActualQuality = objCoil.fkCuttingQuality;
            objProduct = new clsProduct(objCoil.fkProduct);
            this.form = form;
            returnwanted = true;
            InitializeComponent();
        }
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameter, ref lblDiameterLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtLength, ref lblLengthLabel, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbQuality, ref lblQualityLabel, "selected")) isValid = false;
            //if (!clsValidation.validateField(ref cmbCoilCellar, ref lblCoilCellarLabel, "selected")) isValid = false;

            return isValid;
        }
        private void printCoilLabel(int coilCodsec, bool isExternalCoil)
        {
            if (isExternalCoil == false)
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
        private void getCoilInformation()
        {
            objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
            objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);


            if (objCoil.codsec != 0)
            {
                lblCode.Text = objCoil.code;
                txtDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
                lblDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                lblNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 1));
                txtGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 1));
                txtLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                lblBalance.Text = objCoil.BalanceName;
                txtNotes.Text = objCoil.notes;
                lblWidth.Text = objCoil.width.ToString();

                //cmbCoilCellar.SelectedIndex = -1;
                //for (int i = 0; i < cmbCoilCellar.Items.Count; i++)
                //{
                //    if (((clsCoilCellar)cmbCoilCellar.Items[i]).codsec == objCoilCellar.codsec)
                //        cmbCoilCellar.SelectedIndex = i;
                //}

                lblCoilCellar.Text = objCoil.coilCellarContainer.name;

                cmbQuality.SelectedIndex = -1;
                for (int i = 0; i < cmbQuality.Items.Count; i++)
                {
                    if (((clsCuttingQuality)cmbQuality.Items[i]).codsec == objCoil.fkCuttingQuality)
                        cmbQuality.SelectedIndex = i;
                }

                for (int i = 0; i < grpbDefects.Controls.Count; i++)
                    ((CheckBox)grpbDefects.Controls[i]).Checked = objCoil.lstDefects[i];

                objProduct = new clsProduct(objCoil.fkProduct);

                lblFilmName.Text = objProduct.code.Replace("-", "");
                lblPosition.Text = objCoil.cuttingPosition.ToString();
                lblStop.Text = objCoil.cuttingStop.ToString();

                objSalesOrderDetail = clsCoil.getSalesOrderDetailByCoil(objCoil.codsec);
                objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);

                if (objCoil.treatmentSide == "Externo")
                    rdoTreatmentExternal.Checked = true;
                else if (objCoil.treatmentSide == "Interno")
                    rdoTreatmentInner.Checked = true;
                else if (objCoil.treatmentSide == "Doble")
                    rdoTreatmentDouble.Checked = true;
                else if (objCoil.treatmentSide == "Sin tratamiento")
                    rdoTreatmentWithout.Checked = true;
                else if (objCoil.treatmentSide == "TT")
                    rdbTT.Checked = true;
                else if (objCoil.treatmentSide == "")
                    rdoQ.Checked = true;

                if (objSalesOrder.codsec != 0)
                {
                    lblCustomer.Text = objSalesOrder.EntityName;
                    lblSalesOrderNumber.Text = objSalesOrderDetail.codsec.ToString();
                   //lblSalesOrderNumber.Text = objSalesOrder.number;
                }
                else
                {
                    lblCustomer.Text = "STOCK";
                    lblSalesOrderNumber.Text = "---";
                }

                dgvMainCoilList.Rows.Clear();

                for (int i = 0; i < objCuttingStop.lstMainCoilByCuttingStop.Count; i++)
                {
                    dgvMainCoilList.Rows.Add();
                    dgvMainCoilList.Rows[i].Cells[0].Value = objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.codsec;
                    dgvMainCoilList.Rows[i].Cells[1].Value = (new clsBopp(objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.fkBopp)).name;
                    dgvMainCoilList.Rows[i].Cells[2].Value = objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.code;
                    dgvMainCoilList.Rows[i].Cells[3].Value = objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.lotNumber;
                    dgvMainCoilList.Rows[i].Cells[4].Value = Convert.ToString(Math.Round(objCuttingStop.lstMainCoilByCuttingStop[i].length, 2));
                }
            }
        }


        private void frmCoilEditor_Load(object sender, EventArgs e)
        {
            List<clsCuttingQuality> lstCuttingQuality = clsCuttingQuality.getList();
            List<clsMachine> lstMachine = clsMachine.getBalanceMachineList();
            List<clsCoilCellar> lstCoilCellar = clsCoilCellar.getInitialCellarList();

            for (int i = 0; i < lstCuttingQuality.Count; i++)
                cmbQuality.Items.Add(lstCuttingQuality[i]);

            //for (int i = 0; i < lstCoilCellar.Count; i++)
            //    cmbCoilCellar.Items.Add(lstCoilCellar[i]);

            getCoilInformation();
        }

        private void saveInProcessInfo()
        {
            if (!validateInProcessCoilsInfo())
            {
                if (!clsCoil.IsInPallet(objCoil.codsec))
                {
                    clsInProcessCoils obj = new clsInProcessCoils();
                    obj.load(objCoil.codsec);
                    obj.coil = objCoil.codsec;
                    obj.destination = cmbInProcessDestination.SelectedItem.ToString();
                    obj.detail = txtInProcessReworkDetail.Text;
                    obj.process = cmbInProcessRework.SelectedItem.ToString();
                    obj.fkuser = clsGlobal.LoggedUser.codsec;
                    obj.usefulwidth = Convert.ToInt32(txtInProcessUsefulWidth.Text);
                    if (obj.save())
                    {
                            if (clsCoil.ChangeQuality(objCoil.codsec, cmbInProcessDestination.SelectedItem.ToString()))
                            {
                                objCoil.fkCuttingQuality = clsCuttingQuality.getQualityByName(cmbInProcessDestination.SelectedItem.ToString()).codsec;
                                
                                MessageBox.Show("Se guardaron los datos correctamente.", "Bobinas en proceso", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Ocurrió un error, no se guardaron los datos.", "Bobinas en proceso", MessageBoxButtons.OK);

                            }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error, no se guardaron los datos.", "Bobinas en proceso", MessageBoxButtons.OK);

                    }
                }
            }
            else
            {
                MessageBox.Show("Los campos Destino, Ancho útil y Retrabajo  no pueden estar vacios.\nSi el destino es En Proceso el ancho útil no puede ser igual a 0.", "Bobinas en proceso", MessageBoxButtons.OK);
            }
        }

        private void btnCoilSave_Click(object sender, EventArgs e)
        {
            if (!clsCoil.IsInPallet(objCoil.codsec))
            {
                if (validateForm())
                {
                    if (isActualQuality == ((clsCuttingQuality)cmbQuality.SelectedItem).codsec)
                    {
                        //no change Quality
                        objCoil.fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                        objCoil.length = Convert.ToDouble(txtLength.Text);
                        objCoil.diameter = Convert.ToDouble(txtDiameter.Text);
                        objCoil.density = Convert.ToDouble(lblDensity.Text);
                        objCoil.netWeight = Convert.ToDouble(lblNetWeigth.Text);
                        objCoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                        objCoil.density = Convert.ToDouble(lblDensity.Text);
                        objCoil.code = lblCode.Text;

                        if (rdoTreatmentExternal.Checked == true)
                            objCoil.treatmentSide = "Externo";
                        else if (rdoTreatmentInner.Checked == true)
                            objCoil.treatmentSide = "Interno";
                        else if (rdoTreatmentDouble.Checked == true)
                            objCoil.treatmentSide = "Doble";
                        else if (rdbTT.Checked == true)
                            objCoil.treatmentSide = "TT";
                        else if (rdoQ.Checked == true)
                            objCoil.treatmentSide = "";
                        else
                            objCoil.treatmentSide = "Sin tratamiento";

                        //if (cmbQuality.Text == "Primera")
                        //{
                        //    objCoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                        //}
                        //else
                        //{
                            objCoil.defects = "";
                            for (int i = 0; i < grpbDefects.Controls.Count; i++)
                            {
                                objCoil.defects += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                                objCoil.defects += (i < grpbDefects.Controls.Count - 1) ? ";" : "";
                            }
                            
                        //}
                        saveInProcessInfo();
                        objCoil.notes = txtNotes.Text;
                        objCoil.modifiedDate = DateTime.Now;
                        objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;

                        if (objCoil.save())
                        {
                            //if (clsCoil.getContainerCellarByCoil(objCoil.codsec).codsec != ((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec)
                            //    clsCoil.transferCoilTo(objCoil.codsec, ((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec);
                            if (objCoil.fkSalesOrderDetail != 0)
                            {
                                if (MessageBox.Show("¿Desea desasignar el material del pedido al que está asignado? Si confirma, el material quedará como stock libre.", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    if(objCoil.deleteCoilPerSalesOrderDetail(objCoil.codsec))
                                    {
                                        MessageBox.Show("La bobina se ha enviado a stock con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ocurrió un error y no se pudo enviar a stock la bobina", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    }
                                }
                            }
                            if (MessageBox.Show("¿Desea imprimir la etiqueta? Recuerde que si realizó control de producto en proceso, el código de la bobina pudo haber cambiado y será necesario re-etiquetar.", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                if (cmbQuality.Text == "Primera")
                                {
                                    Thread thrdPrint = new Thread(delegate() { printCoilLabel(objCoil.codsec, objCoil.isExternalCoil); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                }
                                else
                                {

                                    printObservationCoilLabel(objCoil.codsec);
                                }
                            }

                            if (clsCoil.IsInPallet(objCoil.codsec))
                            {

                                clsPallet objPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                if (objPallet.codsec != 0)
                                {
                                    double newNetWeight = 0;
                                    for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                        newNetWeight += objPallet.lstCoil[i].netWeight;

                                    objPallet.netWeight = newNetWeight;
                                    objPallet.save();
                                }

                                //MessageBox.Show("Por favor, tomar en cuenta que si se modificó el peso de la bobina el pallet que la contiene también habrá cambiado su peso neto y deberá imprimirse una nueva etiqueta del pallet.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }

                            MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            if (returnwanted)
                                this.form.populateDataGrid();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                    }
                    else
                    {
                        if (clsCoil.ChangeQuality(objCoil.codsec))
                        {
                            objCoil.fkCuttingQuality = ((clsCuttingQuality)cmbQuality.SelectedItem).codsec;
                            objCoil.length = Convert.ToDouble(txtLength.Text);
                            objCoil.diameter = Convert.ToDouble(txtDiameter.Text);
                            objCoil.density = Convert.ToDouble(lblDensity.Text);
                            objCoil.netWeight = Convert.ToDouble(lblNetWeigth.Text);
                            objCoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                            objCoil.density = Convert.ToDouble(lblDensity.Text);
                            objCoil.code = lblCode.Text;

                            if (rdoTreatmentExternal.Checked == true)
                                objCoil.treatmentSide = "Externo";
                            else if (rdoTreatmentInner.Checked == true)
                                objCoil.treatmentSide = "Interno";
                            else if (rdoTreatmentDouble.Checked == true)
                                objCoil.treatmentSide = "Doble";
                            else if (rdbTT.Checked == true)
                                objCoil.treatmentSide = "TT";
                            else if (rdoQ.Checked == true)
                                objCoil.treatmentSide = "";
                            else
                                objCoil.treatmentSide = "Sin tratamiento";

                            if (cmbQuality.Text == "Primera")
                            {
                                objCoil.defects = "False;False;False;False;False;False;False;False;False;False;False;False;False;False;False;False";
                            }
                            else
                            {
                                objCoil.defects = "";
                                for (int i = 0; i < grpbDefects.Controls.Count; i++)
                                {
                                    objCoil.defects += (((CheckBox)grpbDefects.Controls[i]).Checked) ? "True" : "False";
                                    objCoil.defects += (i < grpbDefects.Controls.Count - 1) ? ";" : "";
                                }
                                
                            }
                            saveInProcessInfo();
                            objCoil.notes = txtNotes.Text;
                            objCoil.modifiedDate = DateTime.Now;
                            objCoil.modifiedBy = clsGlobal.LoggedUser.codsec;

                            if (objCoil.save())
                            {
                                //if (clsCoil.getContainerCellarByCoil(objCoil.codsec).codsec != ((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec)
                                //    clsCoil.transferCoilTo(objCoil.codsec, ((clsCoilCellar)cmbCoilCellar.SelectedItem).codsec);
                                if (objCoil.fkSalesOrderDetail != 0)
                                {
                                    if (MessageBox.Show("¿Desea desasignar el material del pedido al que está asignado? Si confirma, el material quedará como stock libre.", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                    {
                                        if (objCoil.deleteCoilPerSalesOrderDetail(objCoil.codsec))
                                        {
                                            MessageBox.Show("La bobina se ha enviado a stock con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ocurrió un error y no se pudo enviar a stock la bobina", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        }
                                    }
                                }
                                if (MessageBox.Show("Desea imprimir la etiqueta?", "Registro de Bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    if (cmbQuality.Text == "Primera")
                                    {
                                        Thread thrdPrint = new Thread(delegate() { printCoilLabel(objCoil.codsec, objCoil.isExternalCoil); });
                                        thrdPrint.Start();
                                        thrdPrint.Join();
                                    }
                                    else
                                        printObservationCoilLabel(objCoil.codsec);

                                }

                                if (clsCoil.IsInPallet(objCoil.codsec))
                                {

                                    clsPallet objPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                    if (objPallet.codsec != 0)
                                    {
                                        double newNetWeight = 0;
                                        for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                            newNetWeight += objPallet.lstCoil[i].netWeight;

                                        objPallet.netWeight = newNetWeight;
                                        objPallet.save();
                                    }

                                    MessageBox.Show("Por favor, tomar en cuenta que si se modificó el peso de la bobina el pallet que la contiene también habrá cambiado su peso neto y deberá imprimirse una nueva etiqueta del pallet.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                }

                                MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                if (returnwanted)
                                    this.form.populateDataGrid();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se puede editar una bobina si se encuetra dentro de un pallet. Retire la bobina del pallet y reintente la operación.", "Bobinas en proceso", MessageBoxButtons.OK);
            }
        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDiameter_TextChanged(object sender, EventArgs e)
        {
            if (txtDiameter.Text != "")
            {
                if (clsGlobal.isNumeric(txtGrossWeigth.Text))
                {
                    clsProduct objProduct = new clsProduct(objCoil.fkProduct);

                    double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore).weigthPerMilimeter));

                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
                else
                {
                    MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtDiameter.Text = "0";
                    txtDiameter.SelectAll();
                }
            }
            else
            {
                txtDiameter.Text = "0";
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuality.Text == "Observación")
                grpbDefects.Enabled = true;
            else
                grpbDefects.Enabled = false;
        }

        private void lblNetWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == true)
            {
                if (clsGlobal.isNumeric(lblNetWeigth.Text))
                {
                    double grossWeigth = Convert.ToDouble(lblNetWeigth.Text) + (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    txtGrossWeigth.Text = Convert.ToString(Math.Round(grossWeigth, 1));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
                else
                {
                    MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void txtGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == false)
            {
                if (clsGlobal.isNumeric(txtGrossWeigth.Text))
                {
                    double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 1));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(txtDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
                else
                {
                    MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void lblNetWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            flgIsChangingNewWeigth = true;
        }

        private void txtGrossWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            flgIsChangingNewWeigth = false;
        }

        private bool validateInProcessCoilsInfo()
        {
            bool flag = false;
            if (cmbInProcessDestination.SelectedIndex == -1)
            {
                flag = true;
            }
            if (cmbInProcessRework.SelectedIndex == -1)
            {
                flag = true;
            }
            if (txtInProcessUsefulWidth.Text == string.Empty)
            {
                flag = true;
            }
            if (cmbInProcessDestination.SelectedIndex == 1 && txtInProcessUsefulWidth.Text == "0")
            {
                flag = true;
            }

            return flag;
        }

        private void cmbInProcessDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInProcessDestination.SelectedIndex)
            {
                case 0:
                    cmbInProcessRework.SelectedIndex = 0;
                    txtInProcessUsefulWidth.Text = lblWidth.Text;
                    break;

                case 1:
                    cmbInProcessRework.Focus();
                    break;

                case 2:
                    //cmbInProcessRework.SelectedIndex = 4;
                    cmbInProcessRework.SelectedIndex = 0;
                    txtInProcessUsefulWidth.Text = "0";
                    break;
            }

        }

        private void cmbInProcessRework_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) == "A" || lblCode.Text.Substring(lblCode.Text.Length - 3, 1) == "B" || lblCode.Text.Substring(lblCode.Text.Length - 3, 1) == "C" || lblCode.Text.Substring(lblCode.Text.Length - 3, 1) == "D")
            {
                switch (cmbInProcessRework.SelectedIndex)
                {
                    case 0:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "A")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + "A" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    case 1:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "B")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + "B" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    case 2:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "C")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + "C" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    case 3:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "D")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + "D" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    /*case 4:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "E")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 3) + "E" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;*/
                }
            }
            else
            {
                switch (cmbInProcessRework.SelectedIndex)
                {
                    case 0:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "A")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 2) + "A" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    case 1:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "B")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 2) + "B" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    case 2:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "C")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 2) + "C" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                    case 3:
                        if (lblCode.Text.Substring(lblCode.Text.Length - 3, 1) != "D")
                        {
                            lblCode.Text = lblCode.Text.Substring(0, lblCode.Text.Length - 2) + "D" + lblCode.Text.Substring(lblCode.Text.Length - 2, 2);
                        }
                        break;
                }
            }
        }
    }
}
