using System;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmCoilDetailManager : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        bool flgIsChangingNewWeigth = false, isMetal = false;
        clsProduct objProduct = new clsProduct();

        public frmCoilDetailManager()
        {
            InitializeComponent();
        }

        public frmCoilDetailManager(string code)
        {
            InitializeComponent();
            getCoilInformation(code);
            objProduct = new clsProduct(objCoil.fkProduct);
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
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
        }
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

            objCoil = clsCoil.getDetailByCode(Code);
            objCoilCellar = clsCoil.getContainerCellarByCoil(objCoil.codsec);
            objCuttingStop = clsCoil.getCuttingStopByCoil(objCoil.codsec);

            if (objCoil.ProductCode.StartsWith("M"))
                isMetal = true;

            if (objCoil.codsec != 0)
            {
                if (txtCode.Text.Length == 0)
                    txtCode.Text = Code;
                lblDiameter.Text = Convert.ToString(Math.Round(objCoil.diameter, 2));
                lblDensity.Text = Convert.ToString(Math.Round(objCoil.density, 5));
                flgIsChangingNewWeigth = false;
                lblNetWeigth.Text = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                flgIsChangingNewWeigth = true;
                txtGrossWeigth.Text = Convert.ToString(Math.Round(objCoil.grossWeight, 2));
                flgIsChangingNewWeigth = false;
                lblLength.Text = Convert.ToString(Math.Round(objCoil.length, 2));
                lblBalance.Text = objCoil.BalanceName;
                lblNotes.Text = objCoil.notes;
                lblWidth.Text = objCoil.width.ToString();

                lblQuality.Text = objCoil.CuttingQualityName;

                if (lblQuality.Text == "Observación" && (clsGlobal.LoggedUser.fkRole == 8 || clsGlobal.LoggedUser.fkRole == 1))
                    btnAuthorize.Visible = true;
                else
                    btnAuthorize.Visible = false;

                switch (objCoil.statusName)
                {
                    case "Activa":
                        pnlStatus.BackColor = Color.Green;
                        if (lblQuality.Text == "Observación")
                        {
                            lblStatusMyCoil.Text = "Bobina Activa / Observación";
                            lblStatusMyCoil.Visible = true;
                        }
                        else
                        {
                            lblStatusMyCoil.Text = "Bobina Activa / Primera";
                            lblStatusMyCoil.Visible = true;
                        }
                        break;

                    case "Reprocesada":
                        pnlStatus.BackColor = Color.Yellow;
                        if (lblQuality.Text == "Observación")
                        {
                            lblStatusMyCoil.Text = "Bobina Reprocesada / Observación";
                            lblStatusMyCoil.Visible = true;
                        }
                        else
                        {
                            lblStatusMyCoil.Text = "Bobina Reprocesada / Primera";
                            lblStatusMyCoil.Visible = true;
                        }
                        break;

                    case "Destruida":
                        pnlStatus.BackColor = Color.Black;
                        if (lblQuality.Text == "Observación")
                        {
                            lblStatusMyCoil.Text = "Bobina Destruida / Observación";
                            lblStatusMyCoil.Visible = true;
                        }
                        else
                        {
                            lblStatusMyCoil.Text = "Bobina Destruida / Primera";
                            lblStatusMyCoil.Visible = true;
                        }
                        break;

                    case "Despachada":
                        pnlStatus.BackColor = Color.Blue;
                        if (lblQuality.Text == "Observación")
                        {
                            lblStatusMyCoil.Text = "Bobina Despachada / Observación";
                            lblStatusMyCoil.Visible = true;
                        }
                        else
                        {
                            lblStatusMyCoil.Text = "Bobina Despachada / Primera";
                            lblStatusMyCoil.Visible = true;
                        }
                        break;

                    case "Reservada":
                        pnlStatus.BackColor = Color.Orange;
                        if (lblQuality.Text == "Observación")
                        {
                            lblStatusMyCoil.Text = "Bobina Reservada / Observación";
                            lblStatusMyCoil.Visible = true;
                        }
                        else
                        {
                            lblStatusMyCoil.Text = "Bobina Reservada / Primera";
                            lblStatusMyCoil.Visible = true;
                        }
                        break;

                    default:
                        pnlStatus.BackColor = Color.White;
                        if (lblQuality.Text == "Observación")
                        {
                            lblStatusMyCoil.Text = "Bobina Default / Observación";
                            lblStatusMyCoil.Visible = true;
                        }
                        else
                        {
                            lblStatusMyCoil.Text = "Bobina Default / Primera";
                            lblStatusMyCoil.Visible = true;
                        }
                        break;
                }

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
                else if (objCoil.treatmentSide == "TT")
                    rdoTT.Checked = true;
                else if (objCoil.treatmentSide == "Sin tratamiento")
                    rdoTreatmentWithout.Checked = true;

                if (objSalesOrder.codsec != 0)
                {
                    lblCustomer.Text = objSalesOrder.EntityName;
                    lblSalesOrderNumber.Text = objSalesOrder.number;
                }
                else
                {
                    lblCustomer.Text = "STOCK";
                    lblSalesOrderNumber.Text = "---";
                }
                lblCoilCellar.Text = objCoilCellar.name;

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
                txtGrossWeigth.Text = "0";
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
                lblStatusMyCoil.Visible = false;
            }
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea aprobar el cambio de calidad de la bobina?\n\nAl aprobar el cambio de calidad se enviará automáticamente la bobina a la bodega de empaque.", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                objCoil.fkCuttingQuality = clsCuttingQuality.getQualityByName("Primera").codsec;
                objCoil.save();

                if (clsCoil.ChangeQuality(objCoil.codsec))
                    clsCoil.transferCoilTo(objCoil.codsec, clsCoilCellar.getCellarByName("Empaque").codsec);

                if (MessageBox.Show("Desea imprimir la etiqueta?", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    Thread thrdPrint = new Thread(delegate() { printCoilLabel(objCoil.codsec, objCoil.isExternalCoil); });
                    thrdPrint.Start();
                    thrdPrint.Join();
                }

                getCoilInformation(objCoil.code);

                MessageBox.Show("La bobina ha sido autorizada para empaque", "Detalle de bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void frmCoilDetailManager_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCode;
            lblStatusMyCoil.Visible = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea imprimir la etiqueta?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                if (objCoil.CuttingQualityName != "Observación")
                {
                    if (objCoil.customerName != "CONFITECA")
                    {
                        if (isMetal)
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objCoil.codsec, objCoil.externalLabelPrint); });
                            thrdPrint.Start();
                            thrdPrint.Join();
                        }
                        else
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                            thrdPrint.Start();
                            thrdPrint.Join();
                        }
                    }
                    else
                    {
                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                    }
                }
                else
                {
                    if (isMetal)
                    {
                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printObservationCoilLabelM(objCoil.codsec); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                    }
                    else
                    {
                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printObservationCoilLabel(objCoil.codsec); });
                        thrdPrint.Start();
                        thrdPrint.Join();
                    }
                }
            }
        }

        private void lblNetWeigth_TextChanged(object sender, EventArgs e)
        {
            if (flgIsChangingNewWeigth == true)
            {
                if (clsGlobal.isNumeric(lblNetWeigth.Text))
                {
                    double grossWeigth = Convert.ToDouble(lblNetWeigth.Text) + (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                    txtGrossWeigth.Text = Convert.ToString(Math.Round(grossWeigth, 2));

                    lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth.Text), Convert.ToDouble(lblDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
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

                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());

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

        private void txtGrossWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            flgIsChangingNewWeigth = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objCoil.netWeight = Convert.ToDouble(lblNetWeigth.Text);
            objCoil.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
            objCoil.density = Convert.ToDouble(lblDensity.Text);
            objCoil.code = txtCode.Text;

            if (rdoTreatmentExternal.Checked == true)
                objCoil.treatmentSide = "Externo";
            else if (rdoTreatmentInner.Checked == true)
                objCoil.treatmentSide = "Interno";
            else if (rdoTreatmentDouble.Checked == true)
                objCoil.treatmentSide = "Doble";
            else if (rdoTT.Checked == true)
                objCoil.treatmentSide = "TT";
            else
                objCoil.treatmentSide = "Sin tratamiento";

            if (!clsCoil.IsInPallet(objCoil.codsec))
            {
                objCoil.save();
                MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else
            {
                objCoil.save();
                MessageBox.Show("Esta en un pallet no se puede actualizar", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void tbpCoilInfo_Click(object sender, EventArgs e)
        {

        }

        private void lblNetWeigth2_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(lblNetWeigth2.Text))
            {
                double grossWeigth = Convert.ToDouble(lblNetWeigth2.Text) + (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);

                txtGrossWeigth.Text = Convert.ToString(Math.Round(grossWeigth, 2));

                lblDensity.Text = Convert.ToString(clsCoil.getCoilDensity(Convert.ToDouble(lblNetWeigth2.Text), Convert.ToDouble(lblDiameter.Text), new clsCore(objProduct.fkCore), objProduct.width));
            }
            else
            {
                MessageBox.Show("El valor debe ser Numérico", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}