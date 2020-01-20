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
    public partial class frmPalletsRegistration : Form
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
        bool isStockPallet = false;
        CrystalReportViewer crvPalletLabel = new CrystalReportViewer();
        rptPalletLabel rptPalletLabel1 = new rptPalletLabel();
        string LoadedAs = "";
        bool isExternalCoil = false;

        public frmPalletsRegistration()
        {
            InitializeComponent();
        }
        public frmPalletsRegistration(int cuttingOrderCodsec, string loadBy)
        {
            LoadedAs = loadBy;
            InitializeComponent();
            switch (loadBy)
            {
                case "cuttingOrder":
                    objCuttingOrder.load(cuttingOrderCodsec);
                    objMachine.load(objCuttingOrder.fkMachine, "Cutter");

                    break;
                case "salesOrder":

                    break;
                case "stock":

                    break;
                default:
                    break;
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


        private void loadTree()
        {
            trvDestinations.Nodes.Clear();
            switch (LoadedAs)
            {
                case "cuttingOrder":
                    trvDestinations.Nodes.Add(clsSalesOrderPalletsTree.getTreeByCuttingOrder(objCuttingOrder.codsec));
                    trvDestinations.ExpandAll();
                    break;
                case "salesOrder":
                    trvDestinations.Nodes.Add(clsSalesOrderPalletsTree.getTreeByActiveSalesOrder());
                    break;
                case "stock":

                    break;
                default:
                    break;
            }
        }
        private void frmPalletsByCuttingOrder_Load(object sender, EventArgs e)
        {
            loadTree();

            setContextMenu(trvDestinations.Nodes[0]);

        }
        private void printPalletLabel(int palletCodsec)
        {
            if (isExternalCoil == false)
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
            else
            {
                rptOppPalletLabel rptPalletLabel = new rptOppPalletLabel();

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
        }
        private void trvDestinations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (getTypeAndCodsec(e.Node.Tag.ToString(),0))
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
                        objPalletType = new clsPalletType( new clsPalletTypeBySalesOrderDetail(Convert.ToInt32(getTypeAndCodsec(e.Node.Parent.Tag.ToString(), 1))).fkPalletType);
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
                    {
                        lblDestination.Text = objSalesOrder.EntityName + " [" + objSalesOrder.number + "]";
                    }
                    else
                    {
                        lblDestination.Text = "Stock";

                    }
                    lblPalletType.Text = objPalletType.name;
                    LblDimentions.Text = objPalletDimentions.ToString();
                    lblProduct.Text = objProduct.name;
                    lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();
                    objPallet.load(Convert.ToInt32(getTypeAndCodsec(e.Node.Tag.ToString(), 1)));
                    dgvCoils.Rows.Clear();

                    if (objPallet.statusName == "Activo")
                    {
                        btnClose.Enabled = false;
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                        btnChangeWeight.Visible = true;
                    }
                    else if (objPallet.statusName == "Abierto")
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                        btnChangeWeight.Visible = false;
                    }
                    else
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                    }

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
                            dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;
                        }
                        lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                        lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight,2));
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
                        lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objPallet.palletNumber.ToString(), 2) + clsGlobal.FillWithZeros(objPalletType.coilNumber.ToString(),2) + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
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

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (e.KeyCode == Keys.Enter)
            {
                if (objPallet.statusName != "Activo")
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if (objCoil.codsec != 0)
                    {
                        if (objCoil.fkProduct == objProduct.codsec)
                        {
                            bool isEnabledToBeAdded = false;
                            if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec == objSalesOrderDetail.codsec)
                                isEnabledToBeAdded = true;
                            else if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec != objSalesOrderDetail.codsec)
                                isEnabledToBeAdded = false;
                            else if (isStockPallet == true)
                                isEnabledToBeAdded = true;


                            if (isEnabledToBeAdded)
                            {
                                if (!clsCoil.IsInPallet(objCoil.codsec))
                                {
                                    if (objPallet.codsec == 0)
                                    {

                                        objPallet.save(objSalesOrderDetail.codsec, objCuttingOrderDetail.codsec);
                                        objPallet.load(objPallet.codsec);
                                        trvDestinations.SelectedNode.ImageIndex = 5;
                                        trvDestinations.SelectedNode.SelectedImageIndex = 5;
                                        trvDestinations.SelectedNode.Text = objPallet.palletType.name + " [" + objPallet.code + "]";
                                        trvDestinations.SelectedNode.Tag = "pallet-" + objPallet.codsec.ToString();
                                    }

                                    if (dgvCoils.Rows.Count < objPallet.palletType.coilNumber)
                                    {
                                        if (objPallet.addCoilToPallet(objCoil.codsec))
                                        {
                                            dgvCoils.Rows.Add();
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;

                                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                            calculatePalletNetWeigth();
                                        }
                                        else
                                            MessageBox.Show("Se ha producido un error al momento de registrar la bobina en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ya han sido ingresadas el número total de bobinas al pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    }
                                }
                                else
                                    MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            }
                            else
                                MessageBox.Show("La bobina seleccionada no esta asociada a la orden de venta a la que pertenece el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                            MessageBox.Show("La bobina seleccionada no coinside con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }

                    txtCoilCode.Text = "";
                    txtCoilCode.Focus();
                }
                else
                {
                    MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }


        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilAction.Index)
            {
                if (objPallet.statusName != "Activo")
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar la bobina del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        if (objPallet.removeCoilToPallet(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value)))
                        {
                            dgvCoils.Rows.Remove(dgvCoils.Rows[e.RowIndex]);
                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                            calculatePalletNetWeigth();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            isExternalCoil = false;
            objPallet.load(objPallet.codsec);

            int externalCoilCount = 0;
            for (int i = 0; i < dgvCoils.Rows.Count; i++)
            {
                if ((new clsCoil(Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value))).isExternalCoil)
                    externalCoilCount++;
            }
            if (externalCoilCount >= Math.Ceiling(Convert.ToDouble(objPallet.lstCoil.Count) / 2))
                isExternalCoil = true;

            objPallet.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
            objPallet.save();

            if (dgvCoils.Rows.Count == objPallet.palletType.coilNumber)
            {
                if (objPallet.close())
                {
                    MessageBox.Show("El pallet ha sido cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    trvDestinations.SelectedNode.ImageIndex = 6;
                    trvDestinations.SelectedNode.SelectedImageIndex = 6;
                    objPallet.load(objPallet.codsec);
                    lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                    btnClose.Enabled = false;
                    printPalletLabel(objPallet.codsec);
                }
                else
                {
                    MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                MessageBox.Show("Debe completar el número de bobinas asignadas para este pallet, estan registradas " + dgvCoils.Rows.Count.ToString() + " y el pallet seleccionado es de " + objPallet.palletType.coilNumber.ToString() + ".", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void txtCoilCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddCoil_Click(object sender, EventArgs e)
        {
            if (objPallet.statusName != "Activo")
            {
                clsCoil objCoil = new clsCoil();

                objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                if (objCoil.codsec != 0)
                {
                    if (objCoil.fkProduct == objProduct.codsec)
                    {
                        bool isEnabledToBeAdded = false;
                        if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec == objSalesOrderDetail.codsec)
                            isEnabledToBeAdded = true;
                        else if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec != objSalesOrderDetail.codsec)
                            isEnabledToBeAdded = false;
                        else if (isStockPallet == true)
                            isEnabledToBeAdded = true;


                        if (isEnabledToBeAdded)
                        {
                            if (!clsCoil.IsInPallet(objCoil.codsec))
                            {
                                if (objPallet.codsec == 0)
                                {
                                    objPallet.save(objSalesOrderDetail.codsec, objCuttingOrderDetail.codsec);
                                    objPallet.load(objPallet.codsec);
                                    trvDestinations.SelectedNode.ImageIndex = 5;
                                    trvDestinations.SelectedNode.SelectedImageIndex = 5;
                                    trvDestinations.SelectedNode.Text = objPallet.palletType.name + " [" + objPallet.code + "]";
                                }

                                if (objPallet.addCoilToPallet(objCoil.codsec))
                                {
                                    dgvCoils.Rows.Add();
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;

                                    lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                    calculatePalletNetWeigth();
                                }
                                else
                                    MessageBox.Show("Se ha producido un error al momento de registrar la bobina en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }
                            else
                                MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                        }
                        else
                            MessageBox.Show("La bobina seleccionada no esta asociada a la orden de venta a la que pertenece el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show("La bobina seleccionada no coinside con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

                txtCoilCode.Text = "";
                txtCoilCode.Focus();

            }
            else
            {
                MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void cmsPalletMenu_Opening(object sender, CancelEventArgs e)
        {
            if (trvDestinations.SelectedNode != null)
            {
                if (trvDestinations.SelectedNode.Tag.ToString().StartsWith("pallet-"))
                {
                    if (trvDestinations.SelectedNode.Tag.ToString().EndsWith("-0"))
                    {
                        cmsPalletMenu.Visible = true;
                        tsmAdd.Visible = false;
                        tsmDelete.Visible = true;
                    }
                    else
                    {
                        cmsPalletMenu.Visible = false;
                        tsmAdd.Visible = false;
                        tsmDelete.Visible = false;
                    }
                }
                else if (trvDestinations.SelectedNode.Tag.ToString().StartsWith("palletTypeBySalesOrderDetail-"))
                {
                    cmsPalletMenu.Visible = true;
                    tsmAdd.Visible = true;
                    tsmDelete.Visible = false;
                }
                else if (trvDestinations.SelectedNode.Tag.ToString().StartsWith("salesOrderDetail-"))
                {
                    cmsPalletMenu.Visible = true;
                    tsmAdd.Visible = true;
                    tsmDelete.Visible = false;
                }
                else
                {
                    cmsPalletMenu.Visible = false;
                    tsmAdd.Visible = false;
                    tsmDelete.Visible = false;
                }
            }
        }

        private void cmsPalletMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == tsmAdd.Name)
            {
                if (trvDestinations.SelectedNode.Tag.ToString().StartsWith("palletTypeBySalesOrderDetail-"))
                {
                    clsPalletTypeBySalesOrderDetail objSalesTypeBySalesOrderDetail = new clsPalletTypeBySalesOrderDetail(Convert.ToInt32(getTypeAndCodsec(trvDestinations.SelectedNode.Tag.ToString(), 1)));
                    objSalesTypeBySalesOrderDetail.quantity++;
                    objSalesTypeBySalesOrderDetail.save();
                    loadTree();
                }
                else if (trvDestinations.SelectedNode.Tag.ToString().StartsWith("salesOrderDetail-"))
                {
                    frmAddNewPalletType winAddNewPalletType = new frmAddNewPalletType(Convert.ToInt32(getTypeAndCodsec(trvDestinations.SelectedNode.Tag.ToString(), 1)));
                    winAddNewPalletType.StartPosition = FormStartPosition.CenterScreen;
                    winAddNewPalletType.ShowDialog(this);
                    loadTree();
                }
            }
            else
            {
                clsPalletTypeBySalesOrderDetail objSalesTypeBySalesOrderDetail = new clsPalletTypeBySalesOrderDetail(Convert.ToInt32(getTypeAndCodsec(trvDestinations.SelectedNode.Parent.Tag.ToString(), 1)));
                objSalesTypeBySalesOrderDetail.quantity--;
                objSalesTypeBySalesOrderDetail.save();
                loadTree();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea modificar el peso bruto del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                objPallet.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                objPallet.save();
            }
        }

    }
}