using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;

namespace BPS
{
    public partial class frmCoilDetailTemporaly : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsCoil objCoil = new clsCoil();
        clsCuttingStop objCuttingStop = new clsCuttingStop();
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        bool flgIsChangingNewWeigth = false, isMetal = false;
        clsProduct objProduct = new clsProduct();

        public frmCoilDetailTemporaly()
        {
            InitializeComponent();
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

                //for (int i = 0; i < grpbDefects.Controls.Count; i++)
                //    ((CheckBox)grpbDefects.Controls[i]).Checked = objCoil.lstDefects[i];

                switch (objCoil.statusName)
                {
                    case "Activa":
                        pnlStatus.BackColor = Color.Green;
                        break;

                    case "Reprocesada":
                        pnlStatus.BackColor = Color.Yellow;
                        break;

                    case "Destruida":
                        pnlStatus.BackColor = Color.Black;
                        break;

                    case "Despachada":
                        pnlStatus.BackColor = Color.Blue;
                        break;

                    case "Reservada":
                        pnlStatus.BackColor = Color.Orange;
                        break;

                    default:
                        pnlStatus.BackColor = Color.White;
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
            }
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea aprobar el cambio de calidad de la bobina?\n\nAl aprobar el cambio de calidad se enviará automáticamente la bobina a la bodega de empaque.", "Detalle de bobina", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                objCoil.fkCuttingQuality = clsCuttingQuality.getQualityByName("Primera").codsec;
                objCoil.save();

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

        private void frmCoilDetail_Load(object sender, EventArgs e)
        {
            ActiveControl = txtCode;
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
            if (objCoil.salesOrderNumber == "2052-1")
            {
                if (objCoil.fkProduct == 44818)
                {
                    //PCx030x1110J6 - PLx030x1110J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44806;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-1");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44806)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            else if (objCoil.salesOrderNumber == "2117")
            {
                if (objCoil.fkProduct == 44856)
                {
                    //PCx030x1600N6 - PC030x1600N6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 223;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2117");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 223)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else if (objCoil.fkProduct == 28397)
                {
                    //PCx030x1560N6 - PC030x1560N6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 253;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2117");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 253)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            else if (objCoil.salesOrderNumber == "2052-2")
            {
                if (objCoil.fkProduct == 44818)
                {
                    //PCx030x1110J6 - PLx030x1110J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44806;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-2");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44806)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else if (objCoil.fkProduct == 44814)
                {
                    //PCx030x780J6 - PLx030x780J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44807;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-2");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44807)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            else if (objCoil.salesOrderNumber == "2052-3")
            {
                if (objCoil.fkProduct == 44816)
                {
                    //PCx030x1130J6 - PLx030x1130J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44808;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-3");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44808)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else if (objCoil.fkProduct == 44817)
                {
                    //PCx030x630J6 - PLx030x630J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44809;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-3");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44809)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            else if (objCoil.salesOrderNumber == "2052-4")
            {
                if (objCoil.fkProduct == 44814)
                {
                    //PCx030x780J6 - PLx030x780J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44807;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-4");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44807)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else if (objCoil.fkProduct == 44815)
                {
                    //PCx030x1040J6 - PLx030x1040J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44810;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-4");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44810)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

                else if (objCoil.fkProduct == 44816)
                {
                    //PCx030x1130J6 - PLx030x1130J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44808;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-4");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44808)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

                else if (objCoil.fkProduct == 44817)
                {
                    //PCx030x630J6 - PLx030x630J6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 44809;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2052-4");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 44809)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            else if (objCoil.salesOrderNumber == "2115")
            {
                if (objCoil.fkProduct == 44832)
                {
                    //PCx030x720N6 - PCx030x720N6
                    var codsecDetail = 0;
                    objCoil.fkProduct = 104;
                    objCoil.save();

                    clsSalesOrder objSales = clsSalesOrder.getDetailByNumber("2115");

                    for (int i = 0; i < objSales.lstSalesOrderDetail.Count; i++)
                    {
                        if (objSales.lstSalesOrderDetail[i].fkProduct == 104)
                        {
                            codsecDetail = objSales.lstSalesOrderDetail[i].codsec;
                            break;
                        }
                    }

                    clsCoil.assignToSalesOrder(objCoil.codsec, codsecDetail);

                    MessageBox.Show("La bobina se ha guardado con éxito.", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }

            else
                MessageBox.Show("No se puede generar el cambio debido a que la bobina pertenece a una\nOrden no activa para el cambio\nPor favor solicite incluir la orden de la bobina", "Registro de Bobina", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void tbpCoilInfo_Click(object sender, EventArgs e)
        {

        }
    }
}