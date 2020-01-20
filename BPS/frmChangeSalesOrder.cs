using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmChangeSalesOrder : Form
    {
        clsBopp objBopp = new clsBopp();
        List<clsMachine> lstMachine = clsMachine.getCutterMachineList();
        List<clsCore> lstCore = clsCore.getList();
        List<clsDiameter> lstDiameter = clsDiameter.getList();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();
        public int selectedProductCodsec = 0;
        clsProduct objSelectedProduct = new clsProduct();
        List<clsCuttingOrder> lstCuttingOrders = new List<clsCuttingOrder>(); 
        List<GroupBox> lstGroupBoxResume = new List<GroupBox>();
        clsProduct objProduct = new clsProduct();
        clsSalesOrderDetail objSalesOrderDetailFrom = new clsSalesOrderDetail();
        clsSalesOrderDetail objSalesOrderDetailTo = new clsSalesOrderDetail();
        clsChangeSalesOrder objChangeSalesOrder = new clsChangeSalesOrder();

        public frmChangeSalesOrder()
        {
            InitializeComponent();
        }
        public void fillFilmList()
        {
            if (tbcFilmLists.SelectedTab == tbpBopp)
            {
                dgvProducts.Rows.Clear();
                List<clsFilter> lstFilter = new List<clsFilter>();

                List<clsProduct> lstProducts = new List<clsProduct>();
                clsCoilCellar objCoilCellar = clsCoilCellar.getCellarByName("Proceso");

                if (txtBoppCode.Text != "")
                    lstProducts = clsProduct.getBoppProductListByCode(txtBoppCode.Text);
                else
                {
                    lstProducts = clsProduct.getCastProductList();

                    dgvProductCast.Rows.Clear();

                    for (int i = 0; i < lstProducts.Count; i++)
                    {
                        dgvProductCast.Rows.Add();
                        dgvProductCast.Rows[i].Cells[clmCastCodsec.Index].Value = lstProducts[i].codsec.ToString();
                        dgvProductCast.Rows[i].Cells[clmCastCode.Index].Value = lstProducts[i].code;
                        dgvProductCast.Rows[i].Cells[clmCastName.Index].Value = lstProducts[i].name;
                        dgvProductCast.Rows[i].Cells[clmCastWidth.Index].Value = lstProducts[i].width;
                        dgvProductCast.Rows[i].Cells[clmCastCore.Index].Value = lstProducts[i].CoreValue.ToString() + "\"";
                        dgvProductCast.Rows[i].Cells[clmCastDiameter.Index].Value = lstProducts[i].DiameterAbbreviation;
                        dgvProductCast.Rows[i].Cells[clmCastweigth.Index].Value = lstProducts[i].weigthInCoilCellar;
                    }
                    lstProducts = new List<clsProduct>();
                    lstProducts = clsProduct.getBoppProductList();
                }

                for (int i = 0; i < lstProducts.Count; i++)
                {
                    dgvProducts.Rows.Add();
                    dgvProducts.Rows[i].Cells[clmCodsec.Index].Value = lstProducts[i].codsec.ToString();
                    dgvProducts.Rows[i].Cells[clmCode.Index].Value = lstProducts[i].code;
                    dgvProducts.Rows[i].Cells[clmProduct.Index].Value = lstProducts[i].name;
                    dgvProducts.Rows[i].Cells[clmWidth.Index].Value = lstProducts[i].width;
                    dgvProducts.Rows[i].Cells[clmCore.Index].Value = lstProducts[i].CoreValue.ToString() + "\"";
                    dgvProducts.Rows[i].Cells[clmDiameter.Index].Value = lstProducts[i].DiameterAbbreviation;
                    dgvProducts.Rows[i].Cells[clmWeigth.Index].Value = lstProducts[i].weigthInCoilCellar;
                }
            }
            else if (tbcFilmLists.SelectedTab == tbpCast)
            {
                //CAST
                List<clsFilter> lstFilter = new List<clsFilter>();
                List<clsProduct> lstProducts = new List<clsProduct>();

                if (txtCastCode.Text != "")
                    lstProducts = clsProduct.getCastProductListInActiveSalesOrderByCode(txtCastCode.Text);
                else
                    lstProducts = clsProduct.getCastProductList();

                dgvProductCast.Rows.Clear();

                for (int i = 0; i < lstProducts.Count; i++)
                {
                    dgvProductCast.Rows.Add();
                    dgvProductCast.Rows[i].Cells[clmCastCodsec.Index].Value = lstProducts[i].codsec.ToString();
                    dgvProductCast.Rows[i].Cells[clmCastCode.Index].Value = lstProducts[i].code;
                    dgvProductCast.Rows[i].Cells[clmCastName.Index].Value = lstProducts[i].name;
                    dgvProductCast.Rows[i].Cells[clmCastWidth.Index].Value = lstProducts[i].width;
                    dgvProductCast.Rows[i].Cells[clmCastCore.Index].Value = lstProducts[i].CoreValue.ToString() + "\"";
                    dgvProductCast.Rows[i].Cells[clmCastDiameter.Index].Value = lstProducts[i].DiameterAbbreviation;
                    dgvProductCast.Rows[i].Cells[clmCastweigth.Index].Value = lstProducts[i].weigthInCoilCellar;
                }
            }
        }

        public void fillSummary()
        {
            dgvChangeOrderSummary.Rows.Clear();
            List<clsChangeSalesOrder> lstChangeSalesOrder = clsChangeSalesOrder.getList();

            for (int i = 0; i < lstChangeSalesOrder.Count; i++)
            {
                dgvChangeOrderSummary.Rows.Add();
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderCodsec.Index].Value = lstChangeSalesOrder[i].codsec;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderProduct.Index].Value = lstChangeSalesOrder[i].objProduct.code.Replace("-", "");
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderFrom.Index].Value = (lstChangeSalesOrder[i].originalSalesOrder.codsec > 0) ? lstChangeSalesOrder[i].originalSalesOrder.EntityName + " [" + lstChangeSalesOrder[i].originalSalesOrder.number + "]" : "STOCK";
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderCoils.Index].Value = lstChangeSalesOrder[i].coilsToChange;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderTo.Index].Value = (lstChangeSalesOrder[i].destinationSalesOrder.codsec > 0) ? lstChangeSalesOrder[i].destinationSalesOrder.EntityName + " [" +  lstChangeSalesOrder[i].destinationSalesOrder.number + "]" : "STOCK";
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderDate.Index].Value = lstChangeSalesOrder[i].createdDate.ToString("dd/MM/yyyy");
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderStatus.Index].Value = (lstChangeSalesOrder[i].statusName == "Activa") ? global::BPS.Properties.Resources.calendar_2 : global::BPS.Properties.Resources.accept;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderCancel.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }
        
        private void fillSalesOrderList()
        {
            
            lstSalesOrderDetail = clsSalesOrderDetail.getCompleteListBySpecificProduct(objProduct.codsec);

            dgvSalesOrderDetail.Rows.Clear();
            dgvDestinationSalesOrderDetail.Rows.Clear();

            for (int i = 0; i < lstSalesOrderDetail.Count; i++)
            {
                //if (clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, (lstSalesOrderDetail[i].quantity - lstSalesOrderDetail[i].programmedWeigth)) >= 0)
                if ((lstSalesOrderDetail[i].coilsToCut - clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkCast, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, lstSalesOrderDetail[i].programmedWeigth)) >= -1)
                {
                    //ORIGEN

                    clsSalesOrder objSalesOrder = new clsSalesOrder();
                    objSalesOrder.loadWithoutDetail(lstSalesOrderDetail[i].fkSalesOrder);
                    dgvSalesOrderDetail.Rows.Add();

                    int j = dgvSalesOrderDetail.Rows.Count - 1;

                    dgvSalesOrderDetail.Rows[dgvSalesOrderDetail.Rows.Count - 1].Cells[clmSalesOrderCodsec.Index].Value = lstSalesOrderDetail[i].codsec;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCustomer.Index].Value = objSalesOrder.EntityName;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderNumber.Index].Value = objSalesOrder.number;
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderProduct.Index].Value = lstSalesOrderDetail[i].product.code.Replace("-", "");
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWeigth.Index].Value = Convert.ToString(Math.Round(lstSalesOrderDetail[i].quantity, 2));

                    if (lstSalesOrderDetail[i].product.fkBopp != 0)
                    {
                        //dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalOrderCoils.Index].Value = clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, (lstSalesOrderDetail[i].quantity));
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalOrderCoils.Index].Value = lstSalesOrderDetail[i].coilsToCut;
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = lstSalesOrderDetail[i].coilsToCut - clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkCast, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, lstSalesOrderDetail[i].programmedWeigth);
                    }
                    else
                    { 
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderTotalOrderCoils.Index].Value = Math.Round((lstSalesOrderDetail[i].quantity / ((lstSalesOrderDetail[i].product.width / 10) * 1.92)), 0);
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = Math.Round(((lstSalesOrderDetail[i].quantity - lstSalesOrderDetail[i].programmedWeigth) / ((lstSalesOrderDetail[i].product.width / 10) * 1.92)), 0);
                    
                    }

                    if (Convert.ToDouble(dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value) < 0)
                        dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderWidth.Index].Value = Convert.ToString(Math.Round(lstSalesOrderDetail[i].product.width));
                    dgvSalesOrderDetail.Rows[j].Cells[clmSalesOrderCoreDiameter.Index].Value = lstSalesOrderDetail[i].product.DiameterAbbreviation + lstSalesOrderDetail[i].product.CoreValue.ToString();
                    
                    //DESTINATION

                    dgvDestinationSalesOrderDetail.Rows.Add();
                    
                    dgvDestinationSalesOrderDetail.Rows[dgvDestinationSalesOrderDetail.Rows.Count - 1].Cells[clmDestinationSalesOrderCodsec.Index].Value = lstSalesOrderDetail[i].codsec;
                    dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderCustomer.Index].Value = objSalesOrder.EntityName;
                    dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderNumber.Index].Value = objSalesOrder.number;
                    dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderProduct.Index].Value = lstSalesOrderDetail[i].product.code.Replace("-", "");
                    dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderWeigth.Index].Value = Convert.ToString(Math.Round(lstSalesOrderDetail[i].quantity, 2));

                    if (lstSalesOrderDetail[i].product.fkBopp != 0)
                    {
                        //dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderTotalOrderCoils.Index].Value = clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, (lstSalesOrderDetail[i].quantity));
                        dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderTotalOrderCoils.Index].Value = lstSalesOrderDetail[i].coilsToCut;
                        dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderCoilsQuantity.Index].Value = lstSalesOrderDetail[i].coilsToCut - clsParameters.getCoilsNumberByWidthAndWeigth(lstSalesOrderDetail[i].product.fkBopp, lstSalesOrderDetail[i].product.fkCast, lstSalesOrderDetail[i].product.fkDiameter, lstSalesOrderDetail[i].product.fkCore, lstSalesOrderDetail[i].product.width, lstSalesOrderDetail[i].programmedWeigth);
                    }
                    else
                    {
                        dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderTotalOrderCoils.Index].Value = Math.Round((lstSalesOrderDetail[i].quantity / ((lstSalesOrderDetail[i].product.width / 10) * 1.92)), 0);
                        dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderCoilsQuantity.Index].Value = Math.Round(((lstSalesOrderDetail[i].quantity - lstSalesOrderDetail[i].programmedWeigth) / ((lstSalesOrderDetail[i].product.width / 10) * 1.92)), 0);

                    }

                    if (Convert.ToDouble(dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderCoilsQuantity.Index].Value) < 0)
                        dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderCoilsQuantity.Index].Value = 0;

                    dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderWidth.Index].Value = Convert.ToString(Math.Round(lstSalesOrderDetail[i].product.width));
                    dgvDestinationSalesOrderDetail.Rows[j].Cells[clmDestinationSalesOrderCoreDiameter.Index].Value = lstSalesOrderDetail[i].product.DiameterAbbreviation + lstSalesOrderDetail[i].product.CoreValue.ToString();
                    
                }
            }

        }
        private void changeSingleFaceStatus(object sender, EventArgs e)
        {
            CheckBox chkSingleFace = (CheckBox)sender;
            clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
            objCuttingOrderDetail.load(Convert.ToInt32(chkSingleFace.Tag));
            objCuttingOrderDetail.useSingleFace = !objCuttingOrderDetail.useSingleFace;
            objCuttingOrderDetail.save();            
        }
        private void frmCuttingOrder_Load(object sender, EventArgs e)
        {
            fillFilmList();
            fillSummary();
        }
        private void dgvBopp_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objProduct.load(Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                lblFilmName.Text = "[" + objProduct.code + "] " + objProduct.name;

                
                fillSalesOrderList();


                tbcChangeSalesOrder.SelectedIndex = 1;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((chkDestinationStock.Checked) ? true : (objSalesOrderDetailTo.codsec > 0) && ((chkStockCoils.Checked) ? true : (objSalesOrderDetailFrom.codsec > 0)) && nudCoilsToChange.Value > 0)
            {
                objChangeSalesOrder.fkOriginalSalesOrderDetail = objSalesOrderDetailFrom.codsec;
                objChangeSalesOrder.fkDestinationSalesOrderDetail = objSalesOrderDetailTo.codsec;
                objChangeSalesOrder.fkProduct = objProduct.codsec;
                objChangeSalesOrder.coilsToChange = Convert.ToInt32(nudCoilsToChange.Value);
                objChangeSalesOrder.notes = txtNotes.Text;

                if (objChangeSalesOrder.save())
                {
                    MessageBox.Show("Se ha guardado la orden de cambio de orden de venta con éxito.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    objSalesOrderDetailFrom = new clsSalesOrderDetail();
                    objSalesOrderDetailTo = new clsSalesOrderDetail();
                    objProduct = new clsProduct();
                    chkStockCoils.Checked = false;
                    dgvSalesOrderDetail.Rows.Clear();
                    dgvDestinationSalesOrderDetail.Rows.Clear();
                    txtNotes.Text = string.Empty;

                    fillSummary();

                    lblFrom.Text = "";
                    lblTo.Text = "";
                    nudCoilsToChange.Value = 0;
                    dgvDestinationSalesOrderDetail.Rows.Clear();
                    dgvSalesOrderDetail.Rows.Clear();
                    chkStockCoils.Checked = false;
                    lblFilmName.Text = "";
                    txtBoppCode.Text = "";
                    txtCastCode.Text = "";
                    

                    tbcChangeSalesOrder.SelectedIndex = 2;
                }
                else
                {
                    MessageBox.Show("La orden de cambio de orden de venta no pudo ser guardada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnMainCoilCancel_Click(object sender, EventArgs e)
        {

        }

        private void dgvProductCast_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objProduct.load(Convert.ToInt32(dgvProductCast.Rows[e.RowIndex].Cells[clmCastCodsec.Index].Value));
                lblFilmName.Text = "[" + objProduct.code + "] " + objProduct.name;

                fillSalesOrderList();

                tbcChangeSalesOrder.SelectedIndex = 1;
            }
        }

        private void txtBoppCode_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void txtBoppName_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void txtCastCode_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void txtCastName_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void btnRefreshBopp_Click(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void btnRefreshCast_Click(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void btnRefreshSalesOrder_Click(object sender, EventArgs e)
        {
            fillSalesOrderList();
        }

        private void btnAddNewBopp_Click(object sender, EventArgs e)
        {
            frmProductsForm winProductForm = new frmProductsForm();
            winProductForm.selectFilmType("Bopp");
            winProductForm.ShowDialog(this);
            fillFilmList();
        }

        private void brnAddNewCast_Click(object sender, EventArgs e)
        {
            frmProductsForm winProductForm = new frmProductsForm();
            winProductForm.selectFilmType("Cast");
            winProductForm.ShowDialog(this);
            fillFilmList();
        }

        private void chkStockCoils_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockCoils.Checked == true)
            {
                objSalesOrderDetailFrom = new clsSalesOrderDetail() ;
                grpbSalesOrders.Enabled = false;
                lblFrom.Text = "STOCK";
                chkDestinationStock.Checked = false;
            }
            else
            {
                objSalesOrderDetailFrom.load(Convert.ToInt32(dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderCodsec.Index].Value));
                grpbSalesOrders.Enabled = true;
                lblFrom.Text = dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderCustomer.Index].Value.ToString() + "[" + dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderNumber.Index].Value.ToString() + "]";
            }
        }

        private void dgvSalesOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objSalesOrderDetailFrom.load(Convert.ToInt32(dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderCodsec.Index].Value));
            lblFrom.Text = dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderCustomer.Index].Value.ToString() + "[" + dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderNumber.Index].Value.ToString() + "]";
        }

        private void dgvDestinationSalesOrderDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objSalesOrderDetailTo.load(Convert.ToInt32(dgvDestinationSalesOrderDetail.SelectedRows[0].Cells[clmDestinationSalesOrderCodsec.Index].Value));
            lblTo.Text = dgvDestinationSalesOrderDetail.SelectedRows[0].Cells[clmDestinationSalesOrderCustomer.Index].Value.ToString() + "[" + dgvDestinationSalesOrderDetail.SelectedRows[0].Cells[clmDestinationSalesOrderNumber.Index].Value.ToString() + "]";
        }

        private void dgvChangeOrderSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmChangeOrderCancel.Index)
            {
                if (MessageBox.Show("Desea eliminar esta orden de cambio?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsChangeSalesOrder.delete(Convert.ToInt32(dgvChangeOrderSummary.Rows[e.RowIndex].Cells[clmChangeOrderCodsec.Index].Value));
                    fillSummary();
                }
            }
        }

        private void chkDestinationStock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDestinationStock.Checked == true)
            {
                objSalesOrderDetailTo = new clsSalesOrderDetail();
                grpbDestinationSalesOrders.Enabled = false;
                lblTo.Text = "STOCK";
                chkStockCoils.Checked = false;
            }
            else
            {
                objSalesOrderDetailTo.load(Convert.ToInt32(dgvDestinationSalesOrderDetail.SelectedRows[0].Cells[clmDestinationSalesOrderCodsec.Index].Value));
                grpbDestinationSalesOrders.Enabled = true;
                lblTo.Text = dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderCustomer.Index].Value.ToString() + "[" + dgvSalesOrderDetail.SelectedRows[0].Cells[clmSalesOrderNumber.Index].Value.ToString() + "]";
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmChangeSalesOrderListReport winChangeSalesOrderListReport = new frmChangeSalesOrderListReport();
            winChangeSalesOrderListReport.StartPosition = FormStartPosition.Manual;
            winChangeSalesOrderListReport.MdiParent = this.MdiParent;
            winChangeSalesOrderListReport.Show();
        }
    }
}