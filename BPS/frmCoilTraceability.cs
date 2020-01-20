using System;
using System.Windows.Forms;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmCoilTraceability : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        bool flgIsChangingNewWeigth = false;
        clsProduct objProduct = new clsProduct();

        public frmCoilTraceability()
        {
            InitializeComponent();
        }

        public frmCoilTraceability(int coilCodsec)
        {
            InitializeComponent();

            objCoil.load(coilCodsec);
            txtCode.Text = objCoil.code;
            getCoilInformation(txtCode.Text);
            objProduct = new clsProduct(objCoil.fkProduct);

        }
        //private void printCoilLabel(int coilCodsec, bool isExternalCoil)
        //{
        //    if (isExternalCoil == false)
        //    {
        //        Reports.rptSqlCoilLabel rptCoilLabel = new Reports.rptSqlCoilLabel();

        //        Tables tables;

        //        tables = rptCoilLabel.Database.Tables;
        //        foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
        //        {
        //            TableLogOnInfo tableLogonInfo = table.LogOnInfo;
        //            tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
        //            table.ApplyLogOnInfo(tableLogonInfo);
        //        }

        //        Sections sections = rptCoilLabel.ReportDefinition.Sections;
        //        foreach (Section section in sections)
        //        {
        //            ReportObjects reportObjects = section.ReportObjects;
        //            foreach (ReportObject reportObject in reportObjects)
        //            {
        //                if (reportObject.Kind == ReportObjectKind.SubreportObject)
        //                {
        //                    SubreportObject subreportObject = (SubreportObject)reportObject;
        //                    ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
        //                    tables = subReportDocument.Database.Tables;
        //                    foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
        //                    {
        //                        TableLogOnInfo tableLogonInfo = table.LogOnInfo;
        //                        tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
        //                        table.ApplyLogOnInfo(tableLogonInfo);
        //                    }
        //                }
        //            }
        //        }

        //        ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
        //        prmCoilCodsec.Value = coilCodsec;

        //        ParameterField pfldCoilCodsec = new ParameterField();
        //        pfldCoilCodsec.Name = "coilLabelCodsec";
        //        pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
        //        pfldCoilCodsec.HasCurrentValue = true;

        //        for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
        //        {
        //            switch (rptCoilLabel.ParameterFields[i].Name)
        //            {
        //                case "coilLabelCodsec":
        //                    rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
        //                    rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
        //                    rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
        //                    rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
        //                    rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }
        //        PrinterSettings printerSettings = new PrinterSettings();
        //        rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
        //        rptCoilLabel.PrintToPrinter(2, false, 0, 0);
        //    }
        //    else
        //    {
        //        Reports.rptOppCoilLabel rptCoilLabel = new Reports.rptOppCoilLabel();

        //        Tables tables;

        //        tables = rptCoilLabel.Database.Tables;
        //        foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
        //        {
        //            TableLogOnInfo tableLogonInfo = table.LogOnInfo;
        //            tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
        //            table.ApplyLogOnInfo(tableLogonInfo);
        //        }

        //        Sections sections = rptCoilLabel.ReportDefinition.Sections;
        //        foreach (Section section in sections)
        //        {
        //            ReportObjects reportObjects = section.ReportObjects;
        //            foreach (ReportObject reportObject in reportObjects)
        //            {
        //                if (reportObject.Kind == ReportObjectKind.SubreportObject)
        //                {
        //                    SubreportObject subreportObject = (SubreportObject)reportObject;
        //                    ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
        //                    tables = subReportDocument.Database.Tables;
        //                    foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
        //                    {
        //                        TableLogOnInfo tableLogonInfo = table.LogOnInfo;
        //                        tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
        //                        table.ApplyLogOnInfo(tableLogonInfo);
        //                    }
        //                }
        //            }
        //        }

        //        ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
        //        prmCoilCodsec.Value = coilCodsec;

        //        ParameterField pfldCoilCodsec = new ParameterField();
        //        pfldCoilCodsec.Name = "coilLabelCodsec";
        //        pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
        //        pfldCoilCodsec.HasCurrentValue = true;

        //        for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
        //        {
        //            switch (rptCoilLabel.ParameterFields[i].Name)
        //            {
        //                case "coilLabelCodsec":
        //                    rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
        //                    rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
        //                    rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
        //                    rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
        //                    rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }

        //        PrinterSettings printerSettings = new PrinterSettings();
        //        rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
        //        rptCoilLabel.PrintToPrinter(2, false, 0, 0);
        //    }
        //}
        //private void printObservationCoilLabel(int coilCodsec)
        //{
        //    Reports.rptCoilLabelObservation rptCoilLabel = new Reports.rptCoilLabelObservation();

        //    ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
        //    prmCoilCodsec.Value = coilCodsec;

        //    ParameterField pfldCoilCodsec = new ParameterField();
        //    pfldCoilCodsec.Name = "coilLabelCodsec";
        //    pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
        //    pfldCoilCodsec.HasCurrentValue = true;

        //    for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
        //    {
        //        switch (rptCoilLabel.ParameterFields[i].Name)
        //        {
        //            case "coilLabelCodsec":
        //                rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
        //                rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
        //                rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
        //                rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
        //                rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
        //                break;
        //            default:
        //                break;
        //        }
        //    }

        //    PrinterSettings printerSettings = new PrinterSettings();
        //    rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
        //    rptCoilLabel.PrintToPrinter(1, false, 0, 0);
        //}
        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                getCoilInformation(txtCode.Text);
                objProduct = new clsProduct(objCoil.fkProduct);
            }
        }

        private void getCoilInformation(string Code)
        {
            clsProduct objProduct = new clsProduct();
            clsPallet objPallet = new clsPallet();
            clsInProcessCoils objInProcessCoils = new clsInProcessCoils();
            clsUser objUser = new clsUser();
            objCoil = clsCoil.getDetailByCode(Code);
            objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
            objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);
            objInProcessCoils.loadDetailsbyCodsec(objCoil.codsec);
            objUser.load(clsGlobal.LoggedUser.codsec);

            if (objCoil.codsec != 0)
            {
                objPallet = new clsPallet(objCoil.fkPallet);
                objPallet = clsPallet.getDetailByCode(objPallet.code);
                txtPallet.Text = objPallet.code;
                lblSDate.Text = objPallet.delivery.ToString();
                lblDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
                lblDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                flgIsChangingNewWeigth = false;
                lblNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                flgIsChangingNewWeigth = true;
                lblGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                flgIsChangingNewWeigth = false;
                lblLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                lblBalance.Text = objCoil.BalanceName;
                lblNotes.Text = objCoil.notes;
                lblWidth.Text = objCoil.width.ToString();
                txtDestiny.Text = objInProcessCoils.destination;
                txtRework.Text = objInProcessCoils.process;
                txtObservations.Text = objInProcessCoils.detail;
                txtUser.Text = objUser.userName;
                txtDate.Text = Convert.ToDateTime(objInProcessCoils.revisiondate).ToString("dd/MM/yyyy");

                lblQuality.Text = objCoil.CuttingQualityName;

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

                if (objSalesOrder.codsec != 0)
                {
                    lblCustomer.Text = objSalesOrder.EntityName;
                    //lblSalesOrderNumber.Text = objSalesOrder.number;
                    lblSalesOrderNumber.Text = objSalesOrderDetail.codsec.ToString();
                }
                else
                {
                    lblCustomer.Text = "STOCK";
                    lblSalesOrderNumber.Text = "---";
                }
                lblCoilCellar.Text = objCoilCellar.name;

                dgvMainCoilList.Rows.Clear();
                dgvCoilsCutted.Rows.Clear();

                if (objCuttingStop.lstMainCoilByCuttingStop.Count > 0)
                {
                    grpbMainCoil.Text = "Rollos madre";

                    dgvCoilsCutted.Visible = false;
                    dgvMainCoilList.Visible = true;

                    for (int i = 0; i < objCuttingStop.lstMainCoilByCuttingStop.Count; i++)
                    {
                        dgvMainCoilList.Rows.Add();
                        dgvMainCoilList.Rows[i].Cells[0].Value = objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.codsec;
                        dgvMainCoilList.Rows[i].Cells[1].Value = (new clsBopp(objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.fkBopp)).code;
                        dgvMainCoilList.Rows[i].Cells[2].Value = objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.code;
                        dgvMainCoilList.Rows[i].Cells[3].Value = objCuttingStop.lstMainCoilByCuttingStop[i].mainCoil.lotNumber;
                        dgvMainCoilList.Rows[i].Cells[4].Value = Convert.ToString(Math.Round(objCuttingStop.lstMainCoilByCuttingStop[i].length, 2));
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilOutline.Index].Value = global::BPS.Properties.Resources.chart_line;
                        dgvMainCoilList.Rows[i].Cells[clmMainCoilQuality.Index].Value = global::BPS.Properties.Resources.report;
                    }
                }
                else if (objCuttingStop.lstSecundaryCutCoil.Count > 0)
                {
                    grpbMainCoil.Text = "Bobinas reprocesadas";

                    dgvCoilsCutted.Visible = true;
                    dgvMainCoilList.Visible = false;

                    for (int i = 0; i < objCuttingStop.lstSecundaryCutCoil.Count; i++)
                    {
                        dgvCoilsCutted.Rows.Add();
                        dgvCoilsCutted.Rows[i].Cells[clmCoilCodsec.Index].Value = objCuttingStop.lstSecundaryCutCoil[i].objCoil.codsec;
                        dgvCoilsCutted.Rows[i].Cells[clmCoilProduct.Index].Value = (new clsProduct(objCuttingStop.lstSecundaryCutCoil[i].objCoil.fkProduct)).code;
                        dgvCoilsCutted.Rows[i].Cells[clmCoilCode.Index].Value = objCuttingStop.lstSecundaryCutCoil[i].objCoil.code;
                        dgvCoilsCutted.Rows[i].Cells[clmCoilLot.Index].Value = objCuttingStop.lstSecundaryCutCoil[i].objCoil.lotNumber;
                        dgvCoilsCutted.Rows[i].Cells[clmCoilLength.Index].Value = Convert.ToString(Math.Round(objCuttingStop.lstSecundaryCutCoil[i].length, 2));
                        dgvCoilsCutted.Rows[i].Cells[clmMainCoilOutline.Index].Value = global::BPS.Properties.Resources.coils;
                    }
                }
                else
                {
                    grpbMainCoil.Text = "Rollos madre";
                    dgvCoilsCutted.Visible = false;
                    dgvMainCoilList.Visible = true;
                }

                lblCuttingDate.Text = objCoil.cuttingDate.ToString("dd/MM/yyyy HH:mm");
                lblMainCoil.Text = objCoil.mainCoilCode;
                lblLotNumber.Text = objCoil.lotNumber;

                lblSupervisor.Text = objCoil.supervisorName;
                lblDigitizer.Text = objCoil.digitizerName;
                lblOperator.Text = objCoil.operatorName;
            }
            else
            {
                MessageBox.Show("No existe una bobina registrada con ese código.", "Detalle de bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                objProduct = new clsProduct();
                lblFilmName.Text = "";
                txtCode.Text = "";
                lblDiameter.Text = "0";
                lblGrossWeigth.Text = "0";
                lblDensity.Text = "0";
                lblLength.Text = "0";
                lblWidth.Text = "0";
                lblCoilCellar.Text = "";
                lblQuality.Text = "";
                rdoTreatmentExternal.Checked = true;
                grpbDefects.Enabled = false;
                lblNotes.Text = "";
                chkDefect1.Checked = false;
                chkDefect2.Checked = false;
                chkDefect3.Checked = false;
                chkDefect4.Checked = false;
                chkDefect5.Checked = false;
                chkDefect6.Checked = false;
                chkDefect7.Checked = false;
                chkDefect8.Checked = false;
                chkDefect9.Checked = false;
                chkDefect10.Checked = false;
                chkDefect11.Checked = false;
                chkDefect12.Checked = false;
                chkDefect13.Checked = false;
                chkDefect14.Checked = false;
                chkDefect15.Checked = false;
                chkDefect16.Checked = false;
                lblCustomer.Text = "";
                lblSalesOrderNumber.Text = "";
                dgvMainCoilList.Rows.Clear();
                dgvCoilsCutted.Rows.Clear();
                grpbMainCoil.Text = "Rollos Madre";
                dgvCoilsCutted.Visible = false;
                dgvMainCoilList.Visible = true;

            }
        }
        private void frmCoilDetail_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCode;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Desea imprimir la etiqueta?", "Detalle de bobinas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                Thread thrdPrint = new Thread(delegate() { BPS.clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                thrdPrint.Start();
                thrdPrint.Join();
                
                if (objCoil.CuttingQualityName != "Observación")
                {
                    if (objCoil.customerName != "CONFITECA")
                    {
                        if (objCoil.ProductCode.StartsWith("M"))
                        {
                            Thread thrdPrint = new Thread(delegate() { BPS.clsPrintLabels.printCoilLabelM(objCoil.codsec, objCoil.externalLabelPrint); });
                            thrdPrint.Start();
                            thrdPrint.Join();
                        }
                        else
                        {
                            Thread thrdPrint = new Thread(delegate() { BPS.clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                            thrdPrint.Start();
                            thrdPrint.Join();
                        }
                    }
                    else
                    {
                        Thread thrdPrint = new Thread(delegate() { BPS.clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                    }
                }
                else
                {
                    if (objCoil.ProductCode.StartsWith("M"))
                    {
                        Thread thrdPrint = new Thread(delegate() { BPS.clsPrintLabels.printObservationCoilLabelM(objCoil.codsec); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                    }
                    else
                    {
                        Thread thrdPrint = new Thread(delegate() { BPS.clsPrintLabels.printObservationCoilLabel(objCoil.codsec); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                    }
                }
            }*/
        }

        private void lblNetWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == true)
            {
                if (clsGlobal.isNumeric(lblNetWeigth.Text))
                {
                    double grossWeigth = Convert.ToDouble(lblNetWeigth.Text) + (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    lblGrossWeigth.Text = Convert.ToString(Math.Round(grossWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(lblDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
                }
                else
                {
                    MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void lblGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == false)
            {
                if (clsGlobal.isNumeric(lblGrossWeigth.Text))
                {
                    double netWeigth = Convert.ToDouble(lblGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(lblDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
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

        private void lblGrossWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            flgIsChangingNewWeigth = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objCoil.netWeight = Convert.ToDouble(lblNetWeigth.Text);
            objCoil.grossWeight = Convert.ToDouble(lblGrossWeigth.Text);
            objCoil.density = Convert.ToDouble(lblDensity.Text);

            if (rdoTreatmentExternal.Checked == true)
                objCoil.treatmentSide = "Externo";
            else if (rdoTreatmentInner.Checked == true)
                objCoil.treatmentSide = "Interno";
            else if (rdoTreatmentDouble.Checked == true)
                objCoil.treatmentSide = "Doble";
            else
                objCoil.treatmentSide = "Sin tratamiento";

            objCoil.save();
            MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void tbpCoilInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnMainCoilExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMainCoilOutline.Index)
            {
                frmMainCoilOutline winMainCoilOutline = new frmMainCoilOutline(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                winMainCoilOutline.MdiParent = this.MdiParent;
                winMainCoilOutline.StartPosition = FormStartPosition.Manual;
                winMainCoilOutline.Show();
            }

            if (e.ColumnIndex == clmMainCoilQuality.Index)
            {
                frmMainCoilQualityReport winMainCoilQualityReport = new frmMainCoilQualityReport(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                winMainCoilQualityReport.MdiParent = this.MdiParent;
                winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
                winMainCoilQualityReport.Show();
            }
        }

        private void dgvCoilsCutted_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilDetail.Index)
            {
                frmCoilTraceability winCoilTraceability = new frmCoilTraceability(Convert.ToInt32(dgvCoilsCutted.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));
                winCoilTraceability.StartPosition = FormStartPosition.CenterScreen;
                winCoilTraceability.ShowDialog(this);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmCoilEditor winCoilEdit = new frmCoilEditor(objCoil.codsec);
            winCoilEdit.StartPosition = FormStartPosition.CenterScreen;
            winCoilEdit.ShowDialog(this);
            this.Close();
        }
    }
}