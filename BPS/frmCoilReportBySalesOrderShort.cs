using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmCoilReportBySalesOrderShort : Form
    {
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        double widthTotal = 0;
        int detailS = 0;
        string productSelected = string.Empty;

        public frmCoilReportBySalesOrderShort()
        {
            InitializeComponent();
        }

        private void printCoilLabel(int coilCodsec, bool isExternalCoil)
        {

            if (isExternalCoil == false)
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

        private void setSalesOrderLayout(int salesOrderCodsec)
        {
            dgvCoils.Rows.Clear();

            objSalesOrder.load(salesOrderCodsec);

            if (objSalesOrder.codsec != 0)
            {
                txtNumber.Text = objSalesOrder.number;
                lblCustomerName.Text = objSalesOrder.EntityName;
                lblDate.Text = objSalesOrder.createdDate.ToString("dd/MM/yyyy");
                lblSalesOrderStatus.Text = objSalesOrder.StatusName;

                trvSalesOrderDetail.Nodes.Clear();

                TreeNode trnMainNode = new TreeNode();

                trnMainNode = new TreeNode("Orden de venta #" + objSalesOrder.number);

                if (objSalesOrder.isInternationalSale)
                {
                    trnMainNode.ImageIndex = 0;
                    trnMainNode.SelectedImageIndex = 0;
                }
                else
                {
                    trnMainNode.ImageIndex = 1;
                    trnMainNode.SelectedImageIndex = 1;
                }

                trnMainNode.Tag = "cuttingOrder-" + objSalesOrder.codsec.ToString();

                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    TreeNode trnDetailNode = new TreeNode();
                    trnDetailNode = new TreeNode(objSalesOrder.lstSalesOrderDetail[i].product.code.Replace("-", "") + " [" + objSalesOrder.lstSalesOrderDetail[i].quantity.ToString() + " Kg.]");
                    trnDetailNode.ImageIndex = 2;
                    trnDetailNode.SelectedImageIndex = 2;
                    trnDetailNode.Tag = objSalesOrder.lstSalesOrderDetail[i].codsec;

                    trnMainNode.Nodes.Add(trnDetailNode);
                }

                trvSalesOrderDetail.Nodes.Add(trnMainNode);
                trvSalesOrderDetail.ExpandAll();

                tbcCoilListBySalesOrder.SelectedIndex = 2;
            }

        }

        public void loadCoilList()
        {
            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
            List<clsCoil> lstCoil = new List<clsCoil>();

            if (clsGlobal.isNumeric(trvSalesOrderDetail.SelectedNode.Tag.ToString()))
            {
                double cuttedWeight = 0;
                double observationWeight = 0;
                int cuttedCoils = 0;
                int observationCoils = 0;
                int palletCount = 0;

                objSalesOrderDetail = new clsSalesOrderDetail(Convert.ToInt32(trvSalesOrderDetail.SelectedNode.Tag));
                detailS = objSalesOrderDetail.codsec;
                productSelected = objSalesOrderDetail.product.code;

                lblProduct.Text = objSalesOrderDetail.product.code.Replace("-", "") + "  -  " + objSalesOrderDetail.product.name;
                lstCoil = clsCoil.getCoilListBySalesOrderDetail(objSalesOrderDetail.codsec);

                dgvCoils.Rows.Clear();

                string actualPallet = "";

                for (int i = 0; i < lstCoil.Count; i++)
                {
                    int row = 0;

                    if (actualPallet != lstCoil[i].palletCode)
                    {
                        clsPallet objPallet = clsPallet.getSimpleDetailByCode(actualPallet);

                        row = dgvCoils.Rows.Count;
                        if ((lstCoil[i].CuttingQualityName == "Primera" && (rdoOnlyFirst.Checked || rdoAll.Checked)))
                        {
                            dgvCoils.Rows.Add();
                            if (actualPallet != "")
                            {
                                dgvCoils.Rows[row].Cells[clmCoilCodsec.Index].Value = 0;
                                dgvCoils.Rows[row].Cells[clmCoilCode.Index].Value = objPallet.code;
                                dgvCoils.Rows[row].Cells[clmCoilProduct.Index].Value = objPallet.product.code.Replace("-", "");
                                dgvCoils.Rows[row].Cells[clmCoilLength.Index].Value = objPallet.palletNumber.ToString() + " - " + objPallet.palletType.coilNumber.ToString();
                                dgvCoils.Rows[row].Cells[clmCoilDiameter.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilwidth.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilNetWeight.Index].Value = Math.Round(objPallet.netWeight, 2);
                                dgvCoils.Rows[row].Cells[clmCoilGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 2);
                                dgvCoils.Rows[row].Cells[clmCoilCellar.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;
                                palletCount++;

                                for (int j = 0; j < dgvCoils.Rows[row].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvCoils.Font, FontStyle.Bold);
                                    dgvCoils.Rows[row].Cells[j].Style.Font = fntBold;
                                }
                                widthTotal += Math.Round(objPallet.grossWeight, 2);
                            }
                            else
                            {
                                dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;
                            }
                        }
                        actualPallet = lstCoil[i].palletCode;
                    }



                    row = dgvCoils.Rows.Count;

                    if ((lstCoil[i].CuttingQualityName == "Primera" && (rdoOnlyFirst.Checked || rdoAll.Checked)) || (lstCoil[i].CuttingQualityName != "Primera" && (rdoOnlyObservation.Checked || rdoAll.Checked)))
                    {
                        dgvCoils.Rows.Add();
                        dgvCoils.Rows[row].Cells[clmCoilCodsec.Index].Value = lstCoil[i].codsec;
                        dgvCoils.Rows[row].Cells[clmCoilCode.Index].Value = lstCoil[i].code;
                        dgvCoils.Rows[row].Cells[clmCoilProduct.Index].Value = lstCoil[i].ProductCode.Replace("-", "");
                        dgvCoils.Rows[row].Cells[clmCoilLength.Index].Value = lstCoil[i].length;
                        dgvCoils.Rows[row].Cells[clmCoilDiameter.Index].Value = lstCoil[i].diameter;
                        dgvCoils.Rows[row].Cells[clmCoilwidth.Index].Value = Math.Round(lstCoil[i].width, 2);
                        dgvCoils.Rows[row].Cells[clmCoilNetWeight.Index].Value = Math.Round(lstCoil[i].netWeight, 2);
                        dgvCoils.Rows[row].Cells[clmCoilGrossWeight.Index].Value = Math.Round(lstCoil[i].grossWeight, 2);
                        dgvCoils.Rows[row].Cells[clmCoilCellar.Index].Value = clsCoil.getContainerCellarByCoil(lstCoil[i].codsec).name;
                        dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
                        dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;

                        if (lstCoil[i].CuttingQualityName == "Primera")
                            dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.bullet_green;
                        else
                            dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.bullet_orange;
                    }
                    if (lstCoil[i].CuttingQualityName == "Primera")
                    {
                        cuttedWeight += lstCoil[i].netWeight;
                        cuttedCoils++;
                    }
                    else
                    {
                        observationWeight = lstCoil[i].netWeight;
                        observationCoils++;
                    }

                    if (i == lstCoil.Count - 1)
                    {
                        clsPallet objPallet = clsPallet.getSimpleDetailByCode(actualPallet);

                        row = dgvCoils.Rows.Count;
                        if ((lstCoil[i].CuttingQualityName == "Primera" && (rdoOnlyFirst.Checked || rdoAll.Checked)))
                        {
                            dgvCoils.Rows.Add();
                            if (actualPallet != "")
                            {
                                dgvCoils.Rows[row].Cells[clmCoilCodsec.Index].Value = 0;
                                dgvCoils.Rows[row].Cells[clmCoilCode.Index].Value = objPallet.code;
                                dgvCoils.Rows[row].Cells[clmCoilProduct.Index].Value = objPallet.product.code.Replace("-", "");
                                dgvCoils.Rows[row].Cells[clmCoilLength.Index].Value = objPallet.palletNumber.ToString() + " - " + objPallet.palletType.coilNumber.ToString();
                                dgvCoils.Rows[row].Cells[clmCoilDiameter.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilwidth.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilNetWeight.Index].Value = Math.Round(objPallet.netWeight, 2);
                                dgvCoils.Rows[row].Cells[clmCoilGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 2);
                                dgvCoils.Rows[row].Cells[clmCoilCellar.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                                dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;
                                palletCount++;

                                for (int j = 0; j < dgvCoils.Rows[row].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvCoils.Font, FontStyle.Bold);
                                    dgvCoils.Rows[row].Cells[j].Style.Font = fntBold;
                                }
                                widthTotal += Math.Round(objPallet.grossWeight, 2);
                            }
                        }
                        actualPallet = lstCoil[i].palletCode;
                    }
                }

                lblTotalWeight.Text = objSalesOrderDetail.quantity.ToString();
                lblCuttedWeight.Text = Math.Round(cuttedWeight, 2).ToString();
                lblObservationWeight.Text = Math.Round(observationWeight, 2).ToString();
                lblUncuttedWeight.Text = Math.Round(Convert.ToDouble(lblTotalWeight.Text) - Convert.ToDouble(lblCuttedWeight.Text), 2).ToString();

                //lblTotalCoils.Text = Math.Round(Convert.ToDecimal(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.codsec, objSalesOrderDetail.quantity)), 0).ToString();
                lblTotalCoils.Text = objSalesOrderDetail.coilsToCut.ToString();
                lblCuttedCoils.Text = cuttedCoils.ToString();
                lblObservationCoils.Text = observationCoils.ToString();
                lblMissingCoils.Text = (Convert.ToInt32(lblTotalCoils.Text) - cuttedCoils).ToString();
                lblPallets.Text = palletCount.ToString();
                lblgross.Text = (Math.Round(widthTotal, 2)).ToString();
            }
            else
            {

            }
        }

        private void frmCoilReportBySalesOrder_Load(object sender, EventArgs e)
        {
        }

        private void chkNationalDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkNationalDateFilter.Checked)
            //    grpbNationalDates.Enabled = true;
            //else
            //    grpbNationalDates.Enabled = false;
        }

        private void chkNationalNumberFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkNationalNumberFilter.Checked)
            //    grpbNationalNumber.Enabled = true;
            //else
            //    grpbNationalNumber.Enabled = false;
        }

        private void chkNationalCustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkNationalCustomerFilter.Checked)
            //    grpbNationalCustomer.Enabled = true;
            //else
            //    grpbNationalCustomer.Enabled = false;
        }

        private void chkNationalStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkNationalStatusFilter.Checked)
            //    grpbNationalStatus.Enabled = true;
            //else
            //    grpbNationalStatus.Enabled = false;
        }

        private void btnNationalFilter_Click(object sender, EventArgs e)
        {
            //populateNationalDataGrid();
        }

        private void btnNationalClearFilters_Click(object sender, EventArgs e)
        {
            //chkNationalDateFilter.Checked = false;
            //chkNationalNumberFilter.Checked = false;
            //chkNationalStatusFilter.Checked = false;
            //chkNationalCustomerFilter.Checked = false;

            //dtpNationalFrom.Value = DateTime.Now;
            //dtpNationalTo.Value = DateTime.Now;
            //txtNationalNumberFrom.Text = "";
            //txtNationalNumberTo.Text = "";
            //cmbNationalCustomer.SelectedIndex = -1;
            //txtNationalCustomerId.Text = "";
            //cmbNationalStatus.SelectedIndex = -1;

            //populateNationalDataGrid();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkDateFilter.Checked)
            //    grpbDates.Enabled = true;
            //else
            //    grpbDates.Enabled = false;
        }

        private void chkNumberFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkNumberFilter.Checked)
            //    grpbNumber.Enabled = true;
            //else
            //    grpbNumber.Enabled = false;
        }

        private void chkCustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkCustomerFilter.Checked)
            //    grpbCustomer.Enabled = true;
            //else
            //    grpbCustomer.Enabled = false;
        }

        private void chkStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkStatusFilter.Checked)
            //    grpbStatus.Enabled = true;
            //else
            //    grpbStatus.Enabled = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //populateInternationalDataGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            //chkDateFilter.Checked = false;
            //chkNumberFilter.Checked = false;
            //chkStatusFilter.Checked = false;
            //chkCustomerFilter.Checked = false;

            //dtpFrom.Value = DateTime.Now;
            //dtpTo.Value = DateTime.Now;
            //txtNumberFrom.Text = "";
            //txtNumberTo.Text = "";
            //cmbCustomer.SelectedIndex = -1;
            //txtCustomerId.Text = "";
            //cmbStatus.SelectedIndex = -1;

            //populateInternationalDataGrid();
        }

        private void dgvSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == clmCoils.Index)
            //    setSalesOrderLayout(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
        }

        private void dgvNationalSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == clmNationalCoils.Index)
            //    setSalesOrderLayout(Convert.ToInt32(dgvNationalSalesOrder.Rows[e.RowIndex].Cells[clmNationalCodsec.Index].Value));
        }

        private void trvSalesOrderDetail_AfterSelect(object sender, TreeViewEventArgs e)
        {
            rdoOnlyFirst.Checked = true;
            widthTotal = 0;
            loadCoilList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //populateNationalDataGrid();
        }

        private void btnRefreshInt_Click(object sender, EventArgs e)
        {
            //populateInternationalDataGrid();
        }

        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilPrint.Index)
            {
                if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                {
                    clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));

                    if (MessageBox.Show("Desea imprimir la etiqueta?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        if (objCoil.statusName != "Observación")
                        {
                            if (objCoil.customerName != "CONFITECA")
                            {
                                if (objCoil.ProductCode.StartsWith("M"))
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
                            if (objCoil.ProductCode.StartsWith("M"))
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
            }
            if (e.ColumnIndex == clmCoilEdit.Index)
            {
                if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                {
                    clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));

                    frmCoilEditor winCoilEditor = new frmCoilEditor(objCoil.codsec);
                    winCoilEditor.ShowDialog(this);
                    loadCoilList();

                }
            }
        }

        private void grpbSalesOrderDetailInfo_Enter(object sender, EventArgs e)
        {

        }

        private void rdoOnlyFirst_CheckedChanged(object sender, EventArgs e)
        {
            loadCoilList();
        }

        private void rdoOnlyObservation_CheckedChanged(object sender, EventArgs e)
        {
            loadCoilList();
        }

        private void rdoAll_CheckedChanged(object sender, EventArgs e)
        {
            loadCoilList();
        }

        private void dgvStockCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCoilReportBySalesOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void trvStockProducts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            widthTotal = 0;
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                objSalesOrder = clsSalesOrder.getDetailByNumber(txtNumber.Text);
                if (objSalesOrder.codsec > 0)
                    setSalesOrderLayout(objSalesOrder.codsec);
                else
                    MessageBox.Show("No existe ese número de orden", "Ordenes de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Previo a cambiar de estado a orden de venta completa, verifique que se ha cumplido con todos los productos de la orden.\n\nEsta seguro que desea cambiar el estado de la orden a completa?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                try
                {
                    clsSalesOrder.setAsCompleted(objSalesOrder.codsec);
                    MessageBox.Show("Orden Completada satisfactoriamente", "Ordenes de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objSalesOrder = clsSalesOrder.getDetailByNumber(txtNumber.Text);
                    if (objSalesOrder.codsec > 0)
                        setSalesOrderLayout(objSalesOrder.codsec);
                    else
                        MessageBox.Show("No existe ese número de orden", "Ordenes de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ordenes de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
