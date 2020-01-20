using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using System.Management;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmCoilReportBySalesOrder : Form
    {
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        double weightTotal = 0;
        int detailS = 0;
        string productSelected = string.Empty;

        public frmCoilReportBySalesOrder()
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

        public void populateInternationalDataGrid()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvSalesOrder.Rows.Clear();
            if (chkCustomerFilter.Checked || chkDateFilter.Checked || chkNumberFilter.Checked || chkStatusFilter.Checked)
            {
                if (chkCustomerFilter.Checked && cmbCustomer.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbCustomer.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkStatusFilter.Checked && cmbStatus.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_fkStatus";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsStatus)cmbStatus.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkCustomerFilter.Checked && txtCustomerId.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_EntityId";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCustomerId.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_createdDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpFrom.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].value2 = dtpTo.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }
                if (chkNumberFilter.Checked && txtNumberFrom.Text != "")
                {
                    //if (txtNumberTo.Text != "")
                    //{
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_number";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                    lstFilter[lstFilter.Count - 1].value2 = txtNumberTo.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    //}
                    //else
                    //{
                    //    lstFilter.Add(new clsFilter());
                    //    lstFilter[lstFilter.Count - 1].field = "sord_number";
                    //    lstFilter[lstFilter.Count - 1].operation = "equal";
                    //    lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                    //    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    //}
                }

                lstSalesOrder = clsSalesOrder.getListByFilter(lstFilter, true);
            }
            else
                lstSalesOrder = clsSalesOrder.getListByCoilReportSalesOrder(1);

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                dgvSalesOrder.Rows.Add();
                dgvSalesOrder.Rows[i].Cells[clmCodsec.Index].Value = lstSalesOrder[i].codsec.ToString();
                dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value = lstSalesOrder[i].createdDate.ToString();
                dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value = lstSalesOrder[i].number.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCustomerId.Index].Value = lstSalesOrder[i].EntityID.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                dgvSalesOrder.Rows[i].Cells[clmStatus.Index].Value = lstSalesOrder[i].StatusName.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCoils.Index].Value = global::BPS.Properties.Resources.coils;
            }
        }

        public void populateNationalDataGrid()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvNationalSalesOrder.Rows.Clear();
            if (chkNationalCustomerFilter.Checked || chkNationalDateFilter.Checked || chkNationalNumberFilter.Checked || chkNationalStatusFilter.Checked)
            {
                if (chkNationalCustomerFilter.Checked && cmbNationalCustomer.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbNationalCustomer.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkNationalStatusFilter.Checked && cmbNationalStatus.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_fkStatus";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsStatus)cmbNationalStatus.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkNationalCustomerFilter.Checked && txtNationalCustomerId.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_EntityId";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtNationalCustomerId.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkNationalDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_createdDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpNationalFrom.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].value2 = dtpNationalTo.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }
                if (chkNationalNumberFilter.Checked && txtNationalNumberFrom.Text != "")
                {
                    if (txtNationalNumberTo.Text != "")
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "sord_number";
                        lstFilter[lstFilter.Count - 1].operation = "between";
                        lstFilter[lstFilter.Count - 1].value = txtNationalNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].value2 = txtNationalNumberTo.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    }
                    else
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "sord_number";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = txtNationalNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    }
                }

                lstSalesOrder = clsSalesOrder.getListByFilter(lstFilter, false);
            }
            else
                lstSalesOrder = clsSalesOrder.getListByCoilReportSalesOrder(0);

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                dgvNationalSalesOrder.Rows.Add();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalCodsec.Index].Value = lstSalesOrder[i].codsec.ToString();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalDate.Index].Value = lstSalesOrder[i].createdDate.ToString();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalNumber.Index].Value = lstSalesOrder[i].number.ToString();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalCustomerId.Index].Value = lstSalesOrder[i].EntityID.ToString();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalCustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalStatus.Index].Value = lstSalesOrder[i].StatusName.ToString();
                dgvNationalSalesOrder.Rows[i].Cells[clmNationalCoils.Index].Value = global::BPS.Properties.Resources.coils;

            }
        }

        private void setSalesOrderLayout(int salesOrderCodsec)
        {
            dgvCoils.Rows.Clear();

            objSalesOrder.load(salesOrderCodsec);

            if (objSalesOrder.codsec != 0)
            {
                lblNumber.Text = objSalesOrder.number;
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

                if (clsGlobal.LoggedUser.fkRole == 1 || clsGlobal.LoggedUser.fkRole == 3)
                {
                    btnComplete.Visible = true;
                    if (objSalesOrder.fkStatus != 11 && objSalesOrder.fkStatus != 12 && objSalesOrder.fkStatus != 13)
                        btnComplete.Enabled = true;
                    else
                        btnComplete.Enabled = false;
                }
            }

        }

        //public void populateStockList()
        //{
        //    List<clsProduct> lstStockProduct = clsProduct.getProductListInStock();

        //    trvStockProducts.Nodes.Clear();

        //    TreeNode trnMainNode = new TreeNode();

        //    trnMainNode = new TreeNode("Productos en Stock");

        //    trnMainNode.ImageIndex = 3;
        //    trnMainNode.SelectedImageIndex = 3;            

        //    trnMainNode.Tag = "0";

        //    for (int i = 0; i < lstStockProduct.Count; i++)
        //    {
        //        TreeNode trnProductNode = new TreeNode(lstStockProduct[i].code);

        //        trnProductNode.ImageIndex = 2;
        //        trnProductNode.SelectedImageIndex = 2;

        //        trnProductNode.Tag = lstStockProduct[i].codsec;

        //        trnMainNode.Nodes.Add(trnProductNode);
        //    }

        //    trvStockProducts.Nodes.Add(trnMainNode);

        //}

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
                weightTotal = 0;

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
                                dgvCoils.Rows[row].Cells[clmCoilCodsec.Index].Value = objPallet.codsec;
                                dgvCoils.Rows[row].Cells[clmCoilCode.Index].Value = objPallet.code;
                                dgvCoils.Rows[row].Cells[clmCoilProduct.Index].Value = objPallet.product.code.Replace("-", "");
                                dgvCoils.Rows[row].Cells[clmCoilLength.Index].Value = objPallet.palletNumber.ToString() + " - " + objPallet.palletType.coilNumber.ToString();
                                dgvCoils.Rows[row].Cells[clmCoilDiameter.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilwidth.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilNetWeight.Index].Value = Math.Round(objPallet.netWeight, 1);
                                dgvCoils.Rows[row].Cells[clmCoilGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 1);
                                dgvCoils.Rows[row].Cells[clmCoilCellar.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                                dgvCoils.Rows[row].Cells[clmTraceability.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Tag = "pallet";
                                palletCount++;

                                for (int j = 0; j < dgvCoils.Rows[row].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvCoils.Font, FontStyle.Bold);
                                    dgvCoils.Rows[row].Cells[j].Style.Font = fntBold;
                                }
                                weightTotal += Math.Round(objPallet.grossWeight, 2);
                            }
                            else
                            {
                                dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmTraceability.Index].Value = global::BPS.Properties.Resources.clear;
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
                        dgvCoils.Rows[row].Cells[clmCoilwidth.Index].Value = Math.Round(lstCoil[i].width, 1);
                        dgvCoils.Rows[row].Cells[clmCoilNetWeight.Index].Value = Math.Round(lstCoil[i].netWeight, 1);
                        dgvCoils.Rows[row].Cells[clmCoilGrossWeight.Index].Value = Math.Round(lstCoil[i].grossWeight, 1);
                        dgvCoils.Rows[row].Cells[clmCoilCellar.Index].Value = clsCoil.getContainerCellarByCoil(lstCoil[i].codsec).name;
                        dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
                        dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                        dgvCoils.Rows[row].Cells[clmTraceability.Index].Value = global::BPS.Properties.Resources.traceability;
                        dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Tag = "coil";

                        if (lstCoil[i].CuttingQualityName == "Primera")
                            dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.bullet_green;
                        else
                            dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.bullet_orange;
                    }
                    if (lstCoil[i].CuttingQualityName == "Primera")
                    {
                        cuttedWeight += Math.Round(lstCoil[i].netWeight, 1);
                        cuttedCoils++;
                    }
                    else
                    {
                        observationWeight += lstCoil[i].netWeight;
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
                                dgvCoils.Rows[row].Cells[clmCoilCodsec.Index].Value = objPallet.codsec;
                                dgvCoils.Rows[row].Cells[clmCoilCode.Index].Value = objPallet.code;
                                dgvCoils.Rows[row].Cells[clmCoilProduct.Index].Value = objPallet.product.code.Replace("-", "");
                                dgvCoils.Rows[row].Cells[clmCoilLength.Index].Value = objPallet.palletNumber.ToString() + " - " + objPallet.palletType.coilNumber.ToString();
                                dgvCoils.Rows[row].Cells[clmCoilDiameter.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilwidth.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilNetWeight.Index].Value = Math.Round(objPallet.netWeight, 1);
                                dgvCoils.Rows[row].Cells[clmCoilGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 1);
                                dgvCoils.Rows[row].Cells[clmCoilCellar.Index].Value = "";
                                dgvCoils.Rows[row].Cells[clmCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                                dgvCoils.Rows[row].Cells[clmTraceability.Index].Value = global::BPS.Properties.Resources.traceability;
                                dgvCoils.Rows[row].Cells[clmCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;
                                dgvCoils.Rows[row].Cells[clmCoilEdit.Index].Tag = "pallet";
                                palletCount++;

                                for (int j = 0; j < dgvCoils.Rows[row].Cells.Count; j++)
                                {
                                    Font fntBold = new Font(dgvCoils.Font, FontStyle.Bold);
                                    dgvCoils.Rows[row].Cells[j].Style.Font = fntBold;
                                }
                                weightTotal += Math.Round(objPallet.grossWeight, 1);
                            }
                        }
                        actualPallet = lstCoil[i].palletCode;
                    }
                }

                #region Validacion botones Open - Close

                if (objSalesOrderDetail.fkStatus == 1116)
                {
                    btnOpenDetail.Visible = true;
                    btnCloseDetail.Visible = false;
                    lblStatusInfo.ForeColor = Color.Red;
                    lblStatusInfo.Text = "Estado : Cerrado";
                }
                else
                {
                    if (lstCoil.Count > 0)
                    {
                        btnOpenDetail.Visible = false;
                        btnCloseDetail.Visible = true;
                        lblStatusInfo.ForeColor = Color.Blue;
                        lblStatusInfo.Text = "Estado : Abierto";
                    }
                    else
                    {
                        btnOpenDetail.Visible = false;
                        btnCloseDetail.Visible = false;
                        lblStatusInfo.Text = "";
                    }
                }

                #endregion

                lblTotalWeight.Text = objSalesOrderDetail.quantity.ToString();
                lblCuttedWeight.Text = Math.Round(cuttedWeight, 1).ToString();
                lblObservationWeight.Text = Math.Round(observationWeight, 1).ToString();
                lblUncuttedWeight.Text = Math.Round(Convert.ToDouble(lblTotalWeight.Text) - Convert.ToDouble(lblCuttedWeight.Text), 1).ToString();

                //lblTotalCoils.Text = Math.Round(Convert.ToDecimal(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrderDetail.product.codsec, objSalesOrderDetail.quantity)), 0).ToString();
                lblTotalCoils.Text = objSalesOrderDetail.coilsToCut.ToString();
                lblCuttedCoils.Text = cuttedCoils.ToString();
                lblObservationCoils.Text = observationCoils.ToString();
                lblMissingCoils.Text = (Convert.ToInt32(lblTotalCoils.Text) - cuttedCoils).ToString();
                lblPallets.Text = palletCount.ToString();
                lblgross.Text = (Math.Round(weightTotal, 1)).ToString();
            }
            else
            {

            }
        }

        public void loadStockCoilList()
        {
            //double cuttedWeight = 0;
            //double observationWeight = 0;
            //int cuttedCoils = 0;
            //int observationCoils = 0;
            //int palletCount = 0;

            //List<clsCoil> lstCoil = new List<clsCoil>();

            //lstCoil = clsCoil.getStockCoilsByProduct(Convert.ToInt32(trvStockProducts.SelectedNode.Tag));

            //lblStockProduct.Text = (new clsProduct(Convert.ToInt32(trvStockProducts.SelectedNode.Tag))).code;

            //dgvStockCoils.Rows.Clear();

            //string actualPallet = "";

            //for (int i = 0; i < lstCoil.Count; i++)
            //{
            //    int row = 0;

            //    if (actualPallet != lstCoil[i].palletCode)
            //    {
            //        clsPallet objPallet = clsPallet.getSimpleDetailByCode(actualPallet);

            //        row = dgvStockCoils.Rows.Count;
            //        if ((lstCoil[i].CuttingQualityName == "Primera" && (rdoStockOnlyFirst.Checked || rdoStockAll.Checked)))
            //        {
            //            dgvStockCoils.Rows.Add();
            //            if (actualPallet != "")
            //            {
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilCodsec.Index].Value = 0;
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilCode.Index].Value = objPallet.code;
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilProduct.Index].Value = (i >= 0) ? lstCoil[i - 1].ProductCode : "";
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilLength.Index].Value = "";
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilDiameter.Index].Value = "";
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilwidth.Index].Value = "";
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilNetWeight.Index].Value = Math.Round(objPallet.netWeight, 2);
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 2);
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilCellar.Index].Value = "";
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilPrint.Index].Value = global::BPS.Properties.Resources.clear;
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilEdit.Index].Value = global::BPS.Properties.Resources.clear;
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;

            //                for (int j = 0; j < dgvStockCoils.Rows[row].Cells.Count; j++)
            //                {
            //                    Font fntBold = new Font(dgvStockCoils.Font, FontStyle.Bold);
            //                    dgvStockCoils.Rows[row].Cells[j].Style.Font = fntBold;
            //                }
            //            }
            //            else
            //            {
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilPrint.Index].Value = global::BPS.Properties.Resources.clear;
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilEdit.Index].Value = global::BPS.Properties.Resources.clear;
            //                dgvStockCoils.Rows[row].Cells[clmStockCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;
            //            }
            //        }
            //        actualPallet = lstCoil[i].palletCode;

            //    }

            //    row = dgvStockCoils.Rows.Count;

            //    if ((lstCoil[i].CuttingQualityName == "Primera" && (rdoStockOnlyFirst.Checked || rdoStockAll.Checked)) || (lstCoil[i].CuttingQualityName != "Primera" && (rdoStockOnlyObservation.Checked || rdoStockAll.Checked)))
            //    {
            //        dgvStockCoils.Rows.Add();
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilCodsec.Index].Value = lstCoil[i].codsec;
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilCode.Index].Value = lstCoil[i].code;
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilProduct.Index].Value = lstCoil[i].ProductCode.Replace("-", "");
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilLength.Index].Value = lstCoil[i].length;
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilDiameter.Index].Value = lstCoil[i].diameter;
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilwidth.Index].Value = Math.Round(lstCoil[i].width, 2);
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilNetWeight.Index].Value = Math.Round(lstCoil[i].netWeight, 2);
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilGrossWeight.Index].Value = Math.Round(lstCoil[i].grossWeight, 2);
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilCellar.Index].Value = clsCoil.getContainerCellarByCoil(lstCoil[i].codsec).name;
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
            //        dgvStockCoils.Rows[row].Cells[clmStockCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;

            //        if (lstCoil[i].CuttingQualityName == "Primera")
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilQuality.Index].Value = global::BPS.Properties.Resources.bullet_green;
            //        else
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilQuality.Index].Value = global::BPS.Properties.Resources.bullet_orange;
            //    }
            //    if (lstCoil[i].CuttingQualityName == "Primera")
            //    {
            //        cuttedWeight += lstCoil[i].netWeight;
            //        cuttedCoils++;
            //    }
            //    else
            //    {
            //        observationWeight += lstCoil[i].netWeight;
            //        observationCoils++;
            //    }

            //    if (i == lstCoil.Count - 1)
            //    {
            //        clsPallet objPallet = clsPallet.getSimpleDetailByCode(actualPallet);

            //        row = dgvStockCoils.Rows.Count;

            //        dgvStockCoils.Rows.Add();
            //        if (actualPallet != "")
            //        {
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilCodsec.Index].Value = 0;
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilCode.Index].Value = objPallet.code;
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilProduct.Index].Value = lstCoil[i].ProductCode;
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilLength.Index].Value = "";
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilDiameter.Index].Value = "";
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilwidth.Index].Value = "";
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilNetWeight.Index].Value = Math.Round(objPallet.netWeight, 2);
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilGrossWeight.Index].Value = Math.Round(objPallet.grossWeight, 2);
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilCellar.Index].Value = "";
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilPrint.Index].Value = global::BPS.Properties.Resources.printer;
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilEdit.Index].Value = global::BPS.Properties.Resources.pencil;
            //            dgvStockCoils.Rows[row].Cells[clmStockCoilQuality.Index].Value = global::BPS.Properties.Resources.clear;

            //            for (int j = 0; j < dgvStockCoils.Rows[row].Cells.Count; j++)
            //            {
            //                Font fntBold = new Font(dgvStockCoils.Font, FontStyle.Bold);
            //                dgvStockCoils.Rows[row].Cells[j].Style.Font = fntBold;
            //            }
            //        }
            //        actualPallet = lstCoil[i].palletCode;

            //    }
            //}

            //lblStockCuttedWeight.Text = Math.Round(cuttedWeight, 2).ToString();
            //lblStockObservationWeight.Text = Math.Round(observationWeight, 2).ToString();
            //lblStockTotalWeight.Text = Math.Round(cuttedWeight + observationWeight, 2).ToString();

            //lblStockTotalCoils.Text = Math.Round(Convert.ToDecimal(clsParameters.getCoilsNumberByWidthAndWeigth(Convert.ToInt32(trvStockProducts.SelectedNode.Tag), (cuttedWeight + observationWeight))), 0).ToString();
            //lblStockCuttedCoils.Text = cuttedCoils.ToString();
            //lblStockObservationCoils.Text = observationCoils.ToString();
            //lblStockPallets.Text = palletCount.ToString();
            //lblStockGross.Text = (Math.Round(weightTotal, 2)).ToString();
        }

        private void frmCoilReportBySalesOrder_Load(object sender, EventArgs e)
        {
            populateNationalDataGrid();
            populateInternationalDataGrid();
            //populateStockList();

            List<clsEntity> lstEntity = clsEntity.getCustomerList();
            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Venta");

            for (int i = 0; i < lstEntity.Count; i++)
            {
                cmbNationalCustomer.Items.Add(lstEntity[i]);
                cmbCustomer.Items.Add(lstEntity[i]);
            }

            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbNationalCustomer.Items.Add(lstStatus[i]);
                cmbStatus.Items.Add(lstStatus[i]);
            }

            btnCloseDetail.Visible = false;
            btnOpenDetail.Visible = false;
        }

        private void chkNationalDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNationalDateFilter.Checked)
                grpbNationalDates.Enabled = true;
            else
                grpbNationalDates.Enabled = false;
        }

        private void chkNationalNumberFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNationalNumberFilter.Checked)
                grpbNationalNumber.Enabled = true;
            else
                grpbNationalNumber.Enabled = false;
        }

        private void chkNationalCustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNationalCustomerFilter.Checked)
                grpbNationalCustomer.Enabled = true;
            else
                grpbNationalCustomer.Enabled = false;
        }

        private void chkNationalStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNationalStatusFilter.Checked)
                grpbNationalStatus.Enabled = true;
            else
                grpbNationalStatus.Enabled = false;
        }

        private void btnNationalFilter_Click(object sender, EventArgs e)
        {
            populateNationalDataGrid();
        }

        private void btnNationalClearFilters_Click(object sender, EventArgs e)
        {
            chkNationalDateFilter.Checked = false;
            chkNationalNumberFilter.Checked = false;
            chkNationalStatusFilter.Checked = false;
            chkNationalCustomerFilter.Checked = false;

            dtpNationalFrom.Value = DateTime.Now;
            dtpNationalTo.Value = DateTime.Now;
            txtNationalNumberFrom.Text = "";
            txtNationalNumberTo.Text = "";
            cmbNationalCustomer.SelectedIndex = -1;
            txtNationalCustomerId.Text = "";
            cmbNationalStatus.SelectedIndex = -1;

            populateNationalDataGrid();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateFilter.Checked)
                grpbDates.Enabled = true;
            else
                grpbDates.Enabled = false;
        }

        private void chkNumberFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumberFilter.Checked)
                grpbNumber.Enabled = true;
            else
                grpbNumber.Enabled = false;
        }

        private void chkCustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomerFilter.Checked)
                grpbCustomer.Enabled = true;
            else
                grpbCustomer.Enabled = false;
        }

        private void chkStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatusFilter.Checked)
                grpbStatus.Enabled = true;
            else
                grpbStatus.Enabled = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            populateInternationalDataGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkDateFilter.Checked = false;
            chkNumberFilter.Checked = false;
            chkStatusFilter.Checked = false;
            chkCustomerFilter.Checked = false;

            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            txtNumberFrom.Text = "";
            txtNumberTo.Text = "";
            cmbCustomer.SelectedIndex = -1;
            txtCustomerId.Text = "";
            cmbStatus.SelectedIndex = -1;

            populateInternationalDataGrid();
        }

        private void dgvSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoils.Index)
                setSalesOrderLayout(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
        }

        private void dgvNationalSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmNationalCoils.Index)
                setSalesOrderLayout(Convert.ToInt32(dgvNationalSalesOrder.Rows[e.RowIndex].Cells[clmNationalCodsec.Index].Value));
        }

        private void trvSalesOrderDetail_AfterSelect(object sender, TreeViewEventArgs e)
        {
            rdoOnlyFirst.Checked = true;
            weightTotal = 0;
            loadCoilList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populateNationalDataGrid();
        }

        private void btnRefreshInt_Click(object sender, EventArgs e)
        {
            populateInternationalDataGrid();
        }

        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilPrint.Index)
            {
                if (dgvCoils.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Tag.ToString() == "coil")
                {
                    if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                    {
                        clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));

                        if (MessageBox.Show("Desea imprimir la etiqueta?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            if (objCoil.CuttingQualityName != "Observación")
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
                else
                {
                    if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                    {
                        clsPallet objPallet = new clsPallet();
                        objPallet = clsPallet.getCompleteDetailByCodePalletForPrint((dgvCoils.Rows[e.RowIndex].Cells[clmCoilCode.Index].Value).ToString());

                        if (MessageBox.Show("Desea imprimir la etiqueta del Pallet?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            int opp = 0, bopp = 0;
                            string palletLabel = string.Empty;
                            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                            {
                                if (objPallet.lstCoil[i].isExternalCoil == true)
                                    opp++;
                                else
                                    bopp++;
                            }
                            if (opp != 0 && bopp != 0)
                                palletLabel = "mixed";
                            else if (opp != 0 && bopp == 0)
                                palletLabel = "external";
                            else
                                palletLabel = "local";

                            if (objPallet.customerName != "CONFITECA")
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabel); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                            else
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabel); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                            //printCoilLabel(lstCoil[selectedCoilIndex / 2].codsec);
                        }
                    }
                }
            }
            if (e.ColumnIndex == clmCoilEdit.Index)
            {
                if (dgvCoils.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Tag.ToString() == "coil")
                {
                    if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                    {
                        frmCoilEditor winCoilEditor = new frmCoilEditor(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));
                        winCoilEditor.ShowDialog(this);
                        loadCoilList();
                    }
                }
                else
                {
                    if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                    {
                        frmPalletDetail winPalletEditor = new frmPalletDetail(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));
                        winPalletEditor.ShowDialog(this);
                        loadCoilList();
                    }
                }
            }
            if (e.ColumnIndex == clmTraceability.Index)
            {
                if (dgvCoils.Rows[e.RowIndex].Cells[clmCoilEdit.Index].Tag.ToString() == "coil")
                {
                    if (Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value) != 0)
                    {
                        frmCoilTraceability winCoilTraceability = new frmCoilTraceability(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));
                        winCoilTraceability.ShowDialog(this);
                        loadCoilList();
                    }
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
            //if (e.ColumnIndex == clmStockCoilPrint.Index)
            //{
            //    if (Convert.ToInt32(dgvStockCoils.Rows[e.RowIndex].Cells[clmStockCoilCodsec.Index].Value) != 0)
            //    {
            //        clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvStockCoils.Rows[e.RowIndex].Cells[clmStockCoilCodsec.Index].Value));

            //        if (MessageBox.Show("Desea imprimir la etiqueta?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            //        {
            //            if (objCoil.statusName != "Observación")
            //            {
            //                if (objCoil.customerName != "CONFITECA")
            //                {
            //                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
            //                    thrdPrint.Start();
            //                }
            //                else
            //                {
            //                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
            //                    thrdPrint.Start();
            //                }
            //            }
            //            else
            //                printObservationCoilLabel(objCoil.codsec);
            //        }
            //    }
            //}
            //if (e.ColumnIndex == clmStockCoilEdit.Index)
            //{
            //    if (Convert.ToInt32(dgvStockCoils.Rows[e.RowIndex].Cells[clmStockCoilCodsec.Index].Value) != 0)
            //    {
            //        clsCoil objCoil = new clsCoil(Convert.ToInt32(dgvStockCoils.Rows[e.RowIndex].Cells[clmStockCoilCodsec.Index].Value));

            //        frmCoilEditor winCoilEditor = new frmCoilEditor(objCoil.codsec);
            //        winCoilEditor.ShowDialog(this);
            //        //populateStockList();

            //    }
            //}
        }

        private void frmCoilReportBySalesOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void trvStockProducts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //rdoStockOnlyFirst.Checked = true;
            weightTotal = 0;
            loadStockCoilList();
        }

        private void btnSortPallets_Click(object sender, EventArgs e)
        {

        }

        private void rdoStockOnlyFirst_CheckedChanged(object sender, EventArgs e)
        {
            loadStockCoilList();
        }

        private void rdoStockOnlyObservation_CheckedChanged(object sender, EventArgs e)
        {
            loadStockCoilList();
        }

        private void rdoStockAll_CheckedChanged(object sender, EventArgs e)
        {
            loadStockCoilList();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Previo a cambiar de estado a orden de venta completa, verifique que se ha cumplido con todos los productos de la orden.\n\nEsta seguro que desea cambiar el estado de la orden a completa?", "Listado de Bobinas por orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                try
                {
                    clsSalesOrder.setAsCompleted(objSalesOrder.codsec);
                    MessageBox.Show("Orden Completada satisfactoriamente", "Ordenes de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objSalesOrder = clsSalesOrder.getDetailByNumber(lblNumber.Text);
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

        #region Gestion Detalle

        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (detailS > 0)
                {
                    if (clsSalesOrderDetail.complete(detailS))
                    {
                        MessageBox.Show("Producto " + productSelected + " completo");
                        btnOpenDetail.Visible = true;
                        btnCloseDetail.Visible = false;

                        lblStatusInfo.ForeColor = Color.Red;
                        lblStatusInfo.Text = "Estado : Cerrado";
                    }
                    else
                        MessageBox.Show("Upps, no se pudo procesar la solicitud, por favor vuelva a intentarlo");
                }
                else
                    MessageBox.Show("No se selecciono ningún material por favor vuelva a seleccionar el materia para poder procesar el detalle");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenDetail_Click(object sender, EventArgs e)
        {
            try
            {
                if (detailS > 0)
                {
                    if (clsSalesOrderDetail.completeOpen(detailS))
                    {
                        MessageBox.Show("Producto " + productSelected + " re abierto");
                        btnOpenDetail.Visible = false;
                        btnCloseDetail.Visible = true;

                        lblStatusInfo.ForeColor = Color.Blue;
                        lblStatusInfo.Text = "Estado : Abierto";
                    }
                    else
                        MessageBox.Show("Upps, no se pudo procesar la solicitud, por favor vuelva a intentarlo");
                }
                else
                    MessageBox.Show("No se selecciono ningún material por favor vuelva a seleccionar el materia para poder procesar el detalle");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion
    }
}
