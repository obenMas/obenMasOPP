using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Reports;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPackingList : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsMachine objMachine = new clsMachine();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsPalletType objPalletType = new clsPalletType();
        clsPalletDimentions objPalletDimentions = new clsPalletDimentions();
        clsPallet objPallet = new clsPallet();
        clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
        clsProduct objProduct = new clsProduct();
        clsTransportBySalesOrder objTransportBySalesOrder = new clsTransportBySalesOrder();
        bool isStockPallet = false;


        public frmPackingList()
        {
            InitializeComponent();
        }

        public frmPackingList(int salesOrderCodsec)
        {
            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);

            for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
            {
                clsPalletTypeBySalesOrderDetail.correctPalletsBySalesOrderDetail(objSalesOrder.lstSalesOrderDetail[i]);
            }
        }

        private void calculatePalletNetWeigth()
        {
            double palletNetWeigth = 0;
            if (objPallet.codsec > 0)
            {
                for (int i = 0; i < dgvCoils.Rows.Count; i++)
                    palletNetWeigth += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value);

                objPallet.netWeight = palletNetWeigth;
                lblNetWeigth.Text = palletNetWeigth.ToString();
                objPallet.save();
            }
        }

        private void loadReports()
        {
            rptUnifiedPackingListReport rptUnifiedPackingList = new rptUnifiedPackingListReport();
            rptPackingListReport rptPackingList = new rptPackingListReport();

            Tables tables;

            ParameterDiscreteValue prmTransportCodsec = new ParameterDiscreteValue();
            prmTransportCodsec.Value = ((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec;

            ParameterDiscreteValue prmCoilNetWeigth = new ParameterDiscreteValue();
            prmCoilNetWeigth.Value = clsValidatePackingList.getTotalCoilNetWeigth(((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec, 1);

            for (int i = 0; i < rptUnifiedPackingList.ParameterFields.Count; i++)
            {
                switch (rptUnifiedPackingList.ParameterFields[i].Name)
                {
                    case "transportBySalesOrderCodsec":
                        rptUnifiedPackingList.ParameterFields[i].CurrentValues.Clear();
                        rptUnifiedPackingList.ParameterFields[i].CurrentValues.Add(prmTransportCodsec);
                        rptUnifiedPackingList.ParameterFields[i].HasCurrentValue = true;
                        rptUnifiedPackingList.ParameterFields[i].DefaultValues.Clear();
                        rptUnifiedPackingList.ParameterFields[i].DefaultValues.Add(prmTransportCodsec);
                        break;
                    default:
                        break;
                }
            }

            tables = rptUnifiedPackingList.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptUnifiedPackingList.ReportDefinition.Sections;
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

            tables = rptPackingList.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            sections = rptPackingList.ReportDefinition.Sections;
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

            for (int i = 0; i < rptPackingList.ParameterFields.Count; i++)
            {
                switch (rptPackingList.ParameterFields[i].Name)
                {
                    case "transportBySalesOrderCodsec":
                        rptPackingList.ParameterFields[i].CurrentValues.Clear();
                        rptPackingList.ParameterFields[i].CurrentValues.Add(prmTransportCodsec);
                        rptPackingList.ParameterFields[i].HasCurrentValue = true;
                        rptPackingList.ParameterFields[i].DefaultValues.Clear();
                        rptPackingList.ParameterFields[i].DefaultValues.Add(prmTransportCodsec);
                        break;
                    case "totalCoilNetWeigth":
                        rptPackingList.ParameterFields[i].CurrentValues.Clear();
                        rptPackingList.ParameterFields[i].CurrentValues.Add(prmCoilNetWeigth);
                        rptPackingList.ParameterFields[i].HasCurrentValue = true;
                        rptPackingList.ParameterFields[i].DefaultValues.Clear();
                        rptPackingList.ParameterFields[i].DefaultValues.Add(prmCoilNetWeigth);
                        break;
                    default:
                        break;
                }
            }

            crvUnifiedPackingList.ReportSource = rptUnifiedPackingList;
            crvDetailedPackingList.ReportSource = rptPackingList;
        }

        private void loadTree()
        {
            trvDestinations.Nodes.Clear();
            trvDestinations.Nodes.Add(clsSalesOrderPalletsTree.getTreeBySalesOrder(objSalesOrder.codsec));
        }

        private void frmPalletsByCuttingOrder_Load(object sender, EventArgs e)
        {
            loadTree();

            setContextMenu(trvDestinations.Nodes[0]);

            List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrder.codsec);

            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)    
                cmbTransport.Items.Add(lstTransportBySalesOrder[i]);

            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
                cmbTransportData.Items.Add(lstTransportBySalesOrder[i]);

            grpbDetails.Visible = false;
        }

        private void printPalletLabel(int palletCodsec)
        {
            rptPalletLabel rptPalletLabel = new rptPalletLabel();

            Tables tables;

            tables = rptPalletLabel.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
            prmPalletCodsec.Value = palletCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "palletCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
            {
                switch (rptPalletLabel.ParameterFields[i].Name)
                {
                    case "palletCodsec":
                        rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                        rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                        rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                        rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                        rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptPalletLabel.PrintToPrinter(2, false, 0, 0);
        }

        private void trvDestinations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (getTypeAndCodsec(e.Node.Tag.ToString(), 0))
            {
                case "pallet":
                    isStockPallet = false;
                    objPallet = new clsPallet(Convert.ToInt32(getTypeAndCodsec(e.Node.Tag.ToString(), 1)));

                    objSalesOrder = new clsSalesOrder();
                    objSalesOrderDetail = new clsSalesOrderDetail();
                    objCuttingOrderDetail = new clsCuttingOrderDetail();

                    if (Convert.ToString(getTypeAndCodsec(e.Node.Parent.Parent.Tag.ToString(), 0)) == "salesOrderDetail")
                    {
                        objSalesOrderDetail = new clsSalesOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Parent.Tag.ToString(), 1)));
                        objSalesOrder = new clsSalesOrder(objSalesOrderDetail.fkSalesOrder);
                        objPalletType = new clsPalletType(new clsPalletTypeBySalesOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Tag.ToString(), 1))).fkPalletType);
                        objPalletDimentions = new clsPalletDimentions(new clsPalletTypeBySalesOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Tag.ToString(), 1))).fkPalletDimention);
                        objProduct = objSalesOrderDetail.product;
                    }
                    else if (Convert.ToString(getTypeAndCodsec(e.Node.Parent.Parent.Tag.ToString(), 0)) == "cuttingOrderDetail")
                    {
                        objCuttingOrderDetail = new clsCuttingOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Parent.Tag.ToString(), 1)));
                        objPalletType = new clsPalletType(new clsPalletTypeByCuttingOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Tag.ToString(), 1))).fkPalletType);
                        objPalletDimentions = new clsPalletDimentions(new clsPalletTypeByCuttingOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Tag.ToString(), 1))).fkPalletDimention);
                        objProduct = objCuttingOrderDetail.product;
                        isStockPallet = true;
                    }

                    if (isStockPallet == false)
                        lblDestination.Text = objSalesOrder.EntityName + " [" + objSalesOrder.number + "]";
                    else
                        lblDestination.Text = "Stock";

                    lblPalletType.Text = objPalletType.name;
                    LblDimentions.Text = objPalletDimentions.ToString();
                    lblProduct.Text = objProduct.name;
                    lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();
                    objPallet.load(Convert.ToInt32(getTypeAndCodsec(e.Node.Tag.ToString(), 1)));
                    dgvCoils.Rows.Clear();

                    if (objPallet.statusName == "Activo")
                    {
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                        //createReport();
                        //setReportParameters();
                    }
                    else if (objPallet.statusName == "Abierto")
                        lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                    else
                        lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);

                    if (Convert.ToInt32(getTypeAndCodsec(e.Node.Tag.ToString(), 1)) != 0)
                    {
                        for (int i = 0; i < objPallet.lstCoil.Count; i++)
                        {
                            dgvCoils.Rows.Add();
                            dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                            dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                            dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                            dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 2));
                            dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                        }
                        lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                        lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 2));
                        txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 2));
                        lblCode.Text = objPallet.code;
                    }
                    else
                    {
                        objPallet.fkPalletDimention = objPalletDimentions.codsec;
                        objPallet.fkPalletType = objPalletType.codsec;
                        objPallet.fkProduct = objProduct.codsec;
                        objPallet.createdBy = clsGlobal.LoggedUser.codsec;
                        objPallet.modifiedBy = clsGlobal.LoggedUser.codsec;
                        objPallet.palletNumber = clsPallet.getCountBySalesOrderDetail(objSalesOrderDetail.codsec) + 1;
                        lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objPallet.palletNumber.ToString(), 2) + clsGlobal.FillWithZeros(objPalletType.coilNumber.ToString(), 2) + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
                        objPallet.code = lblCode.Text;
                    }

                    break;
                case "cuttingOrderDetail":

                    break;
                case "addPalletTypeByCuttingOrderDetail":
                    frmAddNewStockPallet winAddNewStockPallet = new frmAddNewStockPallet(Convert.ToInt32(getTypeAndCodsec(e.Node.Tag.ToString(), 1)));
                    winAddNewStockPallet.StartPosition = FormStartPosition.CenterScreen;
                    winAddNewStockPallet.ShowDialog(this);
                    loadTree();
                    break;
                case "palletStock":

                    break;
                default:
                    break;
            }
        }

        private string getTypeAndCodsec(string tagString, int codsecType)
        {
            return tagString.Split(new char[] { '-' })[codsecType];
        }

        private void setContextMenu(TreeNode node)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Tag.ToString().StartsWith("salesOrderDetail") || node.Tag.ToString().StartsWith("palletTypeBySalesOrderDetail") || node.Tag.ToString().StartsWith("cuttingOrderDetail") || node.Tag.ToString().StartsWith("palletTypeByCuttingOrderDetail"))
                {
                    node.Nodes[i].ContextMenuStrip = cmsPalletMenu;
                    setContextMenu(node.Nodes[i]);
                }
            }
        }

        private void cmbTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckStatusPackingList();
            loadReports();
        }

        private void CheckStatusPackingList()
        {
            List<clsValidatePackingList> lstValidate = new List<clsValidatePackingList>();
            lstValidate = clsValidatePackingList.getList(((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec, 0);
            if (lstValidate.Count > 0)
            {
                frmValidatePackingList winValidate = new frmValidatePackingList(((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec);
                winValidate.StartPosition = FormStartPosition.CenterScreen;
                winValidate.ShowDialog(this);
            }
        }

        private void cmbTransportData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransportData.SelectedIndex > -1)
                PopulateData(((clsTransportBySalesOrder)cmbTransportData.SelectedItem).codsec);
            else
                grpbDetails.Visible = false;
        }

        private void PopulateData(int codsec)
        {
            grpbDetails.Visible = true;
            objTransportBySalesOrder.load(codsec, true);
            if (objTransportBySalesOrder.codsec > 0)
            {
                txtCubicMeters.Text = Math.Round(objTransportBySalesOrder.cubicMeters, 2, MidpointRounding.AwayFromZero).ToString();
                txtSales.Text = objTransportBySalesOrder.sales;
                dtpDate.Value = objTransportBySalesOrder.date;
                txttitle.Text = objTransportBySalesOrder.head;
                txtdescription.Text = objTransportBySalesOrder.footer;
                txtverify.Text = objTransportBySalesOrder.verify;
            }
            else
            {
                txtCubicMeters.Text = "0";
                txtSales.Text = string.Empty;
                dtpDate.Value = DateTime.Now;
                txttitle.Text = string.Empty;
                txtdescription.Text = string.Empty;
                txtverify.Text = string.Empty;
            }
        }

        private void txtCubicMeters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    objTransportBySalesOrder.cubicMeters = Convert.ToDouble(txtCubicMeters.Text);
                    objTransportBySalesOrder.date = dtpDate.Value;
                    objTransportBySalesOrder.sales = txtSales.Text;
                    objTransportBySalesOrder.head = txttitle.Text;
                    objTransportBySalesOrder.footer = txtdescription.Text;
                    objTransportBySalesOrder.verify = txtverify.Text;
                    if (objTransportBySalesOrder.saveCube())
                    {
                        MessageBox.Show("Datos Guardados Correctamente!...", "PackingList", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        tbcPackingList.SelectedIndex = 1;
                        if (cmbTransport.SelectedIndex > -1)
                        {
                            CheckStatusPackingList();
                            loadReports();
                        }
                    }
                    else
                        MessageBox.Show("Error al Ingresar los Datos", "PackingList", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                {
                    txtCubicMeters.Focus();
                    MessageBox.Show("Debe llenar los datos pintados de rojo", "PackingList", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PackingList", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtCubicMeters, ref lblCubicMeters, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtSales, ref lblSales, "notEmpty")) isValid = false;

            return isValid;
        }
    }
}