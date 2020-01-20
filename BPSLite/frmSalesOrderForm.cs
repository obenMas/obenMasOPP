using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmSalesOrderForm : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedCustomerCodsec = 0;
        clsEntity objCustomer = new clsEntity();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();


        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbCommercialCondition, ref lblCommercialCondition, "selected")) isValid = false;
            if (!clsValidation.validateField(ref dgvDetail, ref grpbDetail, "isValid")) isValid = false;
            //if (!clsValidation.validateField(ref txtCustomerId, ref lblCustomerId, "notEmpty")) isValid = false;
            if (objCustomer.codsec == 0) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtNumber, ref lblNumber, "notEmpty")) isValid = false;


            return isValid;
        }

        public void calculateTotals()
        {
            double quantity = 0;
            double subTotal = 0;

            if (dgvDetail.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                {
                    subTotal += Convert.ToDouble((dgvDetail.Rows[i].Cells["clmSubtotal"].Value != null && dgvDetail.Rows[i].Cells["clmSubTotal"].Value.ToString() != "") ? dgvDetail.Rows[i].Cells["clmSubTotal"].Value.ToString() : "0");
                    quantity += Convert.ToDouble((dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.RowIndex == i && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index) ? dgvDetail.CurrentCell.EditedFormattedValue.ToString() : (dgvDetail.Rows[i].Cells["clmQuantity"].Value != null && dgvDetail.Rows[i].Cells["clmQuantity"].Value.ToString() != "") ? dgvDetail.Rows[i].Cells["clmQuantity"].Value.ToString() : "0");
                }
            }


            txtTotal.Text = Math.Round(subTotal, 2).ToString();
            txtTotalWeigth.Text = Math.Round(quantity, 2).ToString();
        }

        private bool canBeEdited(int salesOrderDetail)
        {
            bool flgCanBeEdited = true;

            DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilpersalesorderdetail WHERE cpsod_fkOrderDetail = " + salesOrderDetail.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                flgCanBeEdited = false;

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingorderdetail WHERE cod_fkSalesOrderDetail = " + salesOrderDetail.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                flgCanBeEdited = false;

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletbysalesorderdetail WHERE pbsod_fkSalesOrderDetail = " + salesOrderDetail.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                flgCanBeEdited = false;


            return flgCanBeEdited;
        }

        public frmSalesOrderForm()
        {
            InitializeComponent();
            this.dtpCompromiseDate.Enabled = true;
        }

        public frmSalesOrderForm(int salesOrderCodsec)
        {
            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);
            this.dtpCompromiseDate.Enabled = false;
        }

        private void dgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double quantity = 0;
            double price = 0;

            if (dgvDetail.CurrentRow.Index < lstSalesOrderDetail.Count)
            {
                switch (dgvDetail.CurrentCell.ColumnIndex)
                {
                    case 2:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
                                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
                                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
                            else
                                quantity += 0;

                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
                                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
                                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
                            else
                                price += 0;

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
                            calculateTotals();
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        }
                        break;
                    case 5:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
                                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
                                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
                            else
                                quantity += 0;

                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
                                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
                                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
                            else
                                price += 0;

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
                            calculateTotals();
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        }

                        break;
                    case 6:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].stock = Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                        }
                        break;
                    case 3:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == true && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("Código de Producto no ingresado");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
                                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
                                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
                            else
                                quantity += 0;

                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
                                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
                                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
                            else
                                price += 0;

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
                            calculateTotals();
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((dgvDetail.CurrentCell.ColumnIndex == clmProductCode.Index || dgvDetail.CurrentCell.ColumnIndex == clmProductName.Index) && e.KeyCode == Keys.F4)
            {
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this);
                winProductList.ShowDialog(this);
                objSelectedProduct.load(selectedProductCodsec);
                dgvDetail.CurrentRow.Cells["clmProductCodsec"].Value = objSelectedProduct.codsec.ToString();
                dgvDetail.CurrentRow.Cells["clmProductCode"].Value = objSelectedProduct.code;
                dgvDetail.CurrentRow.Cells["clmProductName"].Value = objSelectedProduct.name;

                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkProduct = objSelectedProduct.codsec;
                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].product = objSelectedProduct;
                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkStatus = Convert.ToInt32(dgvDetail.CurrentRow.Cells["clmStatus"].Value);
            }
        }


        private void frmSalesOrderForm_Load(object sender, EventArgs e)
        {
            List<clsCommercialCondition> lstCommercialCondition = new List<clsCommercialCondition>();
            lstCommercialCondition = clsCommercialCondition.getList();
            cmbCommercialCondition.Items.Clear();
            for (int i = 0; i < lstCommercialCondition.Count; i++)
                cmbCommercialCondition.Items.Add(lstCommercialCondition[i]);

            List<clsStatus> lstStatus = new List<clsStatus>();
            lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Venta");
            cmbStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            lstSalesOrderDetail.Add(new clsSalesOrderDetail());

            if (objSalesOrder.codsec > 0)
            {
                txtNumber.Text = objSalesOrder.number;
                dtpDate.Value = objSalesOrder.createdDate;

                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objSalesOrder.fkStatus)
                        cmbStatus.SelectedIndex = i;
                }

                for (int i = 0; i < cmbCommercialCondition.Items.Count; i++)
                {
                    if (((clsCommercialCondition)cmbCommercialCondition.Items[i]).codsec == objSalesOrder.fkCommercialCondition)
                        cmbCommercialCondition.SelectedIndex = i;
                }

                objCustomer.load(objSalesOrder.fkEntity);

                txtCustomerName.Text = objCustomer.companyName;
                txtCustomerCountry.Text = objCustomer.countryName;
                txtCustomerId.Text = objCustomer.id;
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                if (lstAddress.Count > 0)
                    txtCustomerAddress.Text = lstAddress[0].address;
                else
                    txtCustomerAddress.Text = "";

                txtNotes.Text = objSalesOrder.notes;
                lstSalesOrderDetail = objSalesOrder.lstSalesOrderDetail;
                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    dgvDetail.Rows.Add();
                    dgvDetail.Rows[i].Cells[clmCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].codsec.ToString();
                    dgvDetail.Rows[i].Cells[clmProductCode.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.code;
                    dgvDetail.Rows[i].Cells[clmProductName.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.name;
                    dgvDetail.Rows[i].Cells[clmProductCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkProduct.ToString();
                    dgvDetail.Rows[i].Cells[clmQuantity.Index].Value = objSalesOrder.lstSalesOrderDetail[i].quantity.ToString();
                    dgvDetail.Rows[i].Cells[clmStock.Index].Value = objSalesOrder.lstSalesOrderDetail[i].stock.ToString();
                    dgvDetail.Rows[i].Cells[clmPrice.Index].Value = objSalesOrder.lstSalesOrderDetail[i].price.ToString();
                    dgvDetail.Rows[i].Cells[clmStatus.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkStatus.ToString();

                    dgvDetail.Rows[i].Cells["clmSubTotal"].Value = Math.Round((Convert.ToDouble(dgvDetail.Rows[i].Cells["clmQuantity"].Value) * Convert.ToDouble(dgvDetail.Rows[i].Cells["clmPrice"].Value)), 2).ToString();
                }
                calculateTotals();
            }
        }

        private void txtCustomerCode_Leave(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "")
            {
                objCustomer = clsEntity.getCustomerById(txtCustomerId.Text);

                if (objCustomer.codsec > 0)
                {
                    txtCustomerName.Text = objCustomer.companyName;
                    txtCustomerCountry.Text = objCustomer.countryName;
                    List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                    if (lstAddress.Count > 0)
                        txtCustomerAddress.Text = lstAddress[0].address;
                    else
                        txtCustomerAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("La identificación ingresada no coincide con ningún cliente registrado.", "Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtCustomerName.Text = "";
                    txtCustomerCountry.Text = "";
                    txtCustomerAddress.Text = "";
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            objCustomer = new clsEntity();
            frmCustomerList winCustomerList = new frmCustomerList(this);
            winCustomerList.ShowDialog(this);
            objCustomer.load(selectedCustomerCodsec);

            if (objCustomer.codsec > 0)
            {
                txtCustomerName.Text = objCustomer.companyName;
                txtCustomerCountry.Text = objCustomer.countryName;
                txtCustomerId.Text = objCustomer.id;
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                if (lstAddress.Count > 0)
                    txtCustomerAddress.Text = lstAddress[0].address;
                else
                    txtCustomerAddress.Text = "";
            }
            else
            {
                MessageBox.Show("La identificación ingresada no coincide con ningún cliente registrado.", "Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtCustomerName.Text = "";
                txtCustomerCountry.Text = "";
                txtCustomerId.Text = "";
                txtCustomerAddress.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (clsSalesOrder.IsUniqueSalesOrderNumber(txtNumber.Text, objSalesOrder.codsec))
                {
                    objSalesOrder.fkEntity = objCustomer.codsec;
                    objSalesOrder.fkCommercialCondition = ((clsCommercialCondition)cmbCommercialCondition.SelectedItem).codsec;
                    objSalesOrder.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                    objSalesOrder.number = txtNumber.Text;
                    objSalesOrder.notes = txtNotes.Text;
                    objSalesOrder.createdDate = dtpDate.Value;
                    objSalesOrder.compromisedate = dtpCompromiseDate.Value;
                    for (int i = 0; i < lstSalesOrderDetail.Count; i++)
                    {
                        if (lstSalesOrderDetail[i].fkProduct != 0 && lstSalesOrderDetail[i].coilsToCut == 0)
                        {
                            clsProduct objProduct = new clsProduct(lstSalesOrderDetail[i].fkProduct);
                            clsParameters ObjParameters = new clsParameters();
                            ObjParameters = clsParameters.getParameterByProduct(lstSalesOrderDetail[i].fkProduct);
                            if (ObjParameters.codsec > 0)
                                lstSalesOrderDetail[i].coilsToCut = Convert.ToInt32(clsParameters.getCoilsNumberByWidthAndWeigth(objProduct.fkBopp, objProduct.fkCast, objProduct.fkDiameter, objProduct.fkCore, objProduct.width, Convert.ToDouble((lstSalesOrderDetail[i].quantity))));
                            else
                            {
                                ObjParameters.fkBopp = objProduct.fkBopp;
                                ObjParameters.fkCast = objProduct.fkCast;
                                ObjParameters.fkDiameter = objProduct.fkDiameter;
                                ObjParameters.fkCore = objProduct.fkCore;
                                ObjParameters.weightFactor = 1.92;
                                ObjParameters.aproxLength = 1024;
                                if (ObjParameters.save())
                                    lstSalesOrderDetail[i].coilsToCut = Convert.ToInt32(clsParameters.getCoilsNumberByWidthAndWeigth(objProduct.fkBopp, objProduct.fkCast, objProduct.fkDiameter, objProduct.fkCore, objProduct.width, Convert.ToDouble((lstSalesOrderDetail[i].quantity))));
                            }
                        }
                    }
                    objSalesOrder.lstSalesOrderDetail = lstSalesOrderDetail;
                    objSalesOrder.isInternationalSale = false;
                    if (MessageBox.Show("Recuerde que la fecha de compromiso no se podrá cambiar. \r Fecha de Compromiso :" + dtpCompromiseDate.Value.Date.ToShortDateString() + "\r Desea continuar o cambiar la fecha de compromiso?", "Orden de venta nacional", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true) == DialogResult.Yes)
                    {
                        if (objSalesOrder.save())
                        {
                            MessageBox.Show("La orden de venta se ha guardado con éxito. ", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            if (MessageBox.Show("Desea crear una nueva orden?", "Nueva Orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                clsGlobal.ClearForm(this);
                                objCustomer = new clsEntity();
                                objSelectedProduct = new clsProduct();
                                objSalesOrder = new clsSalesOrder();
                                lstSalesOrderDetail.Clear();
                                dtpDate.Focus();
                            }
                            else
                                this.Close();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show("La orden no se ha guardado ya que se canceló por que no se acepto la fecha de compromiso", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                    MessageBox.Show("El número de orden ya ha sido utilizado por favor revise que el número de orden sea el correcto.", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

        }

        private void dgvDetail_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            lstSalesOrderDetail.Add(new clsSalesOrderDetail());
        }

        private void dgvDetail_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (canBeEdited(Convert.ToInt32(dgvDetail.Rows[dgvDetail.CurrentRow.Index].Cells[clmCodsec.Index].Value)))
            {
                lstSalesOrderDetail.RemoveAt(dgvDetail.CurrentRow.Index);
                lstSalesOrderDetail[lstSalesOrderDetail.Count - 1].fkStatus = 1;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("El detalle de la orden seleccionada no puede ser borrado ya que esta asociado a bobinas, pallets u ordenes de corte existentes. Por favor pongase en contacto con el departamento de planificación para resolver este conflicto.", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void dgvDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["clmStatus"].Value = clsStatus.getStatusByStatusGroupNameAndStatusName("Detalle de ordenes de venta", "Activo").codsec;
            e.Row.Cells["clmCodsec"].Value = "0";
            e.Row.Cells[clmPrice.Index].Value = "0";
            e.Row.Cells[clmQuantity.Index].Value = "0";
            e.Row.Cells[clmStock.Index].Value = "0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmProductCode.Index)
            {
                if ((Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) == 0) || canBeEdited(Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                {
                    objSelectedProduct = new clsProduct();
                    frmProductList winProductList = new frmProductList(this);
                    winProductList.ShowDialog(this);
                    if (selectedProductCodsec > 0)
                    {

                        objSelectedProduct.load(selectedProductCodsec);
                        dgvDetail.CurrentRow.Cells["clmProductCodsec"].Value = objSelectedProduct.codsec.ToString();
                        dgvDetail.CurrentRow.Cells["clmProductCode"].Value = objSelectedProduct.code;
                        dgvDetail.CurrentRow.Cells["clmProductName"].Value = objSelectedProduct.name;
                        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkProduct = objSelectedProduct.codsec;
                        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].product = objSelectedProduct;
                        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkStatus = Convert.ToInt32(dgvDetail.CurrentRow.Cells["clmStatus"].Value);
                    }
                }
                else
                    MessageBox.Show("El detalle de la orden seleccionada no puede ser editado ya que esta asociado a bobinas, pallets u ordenes de corte existentes. Por favor pongase en contacto con el departamento de planificación para resolver este conflicto.", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro de cancelar la orden de venta..?", "Ordenes de Venta Nacional", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsGlobal.ClearForm(this);
                frmSalesOrderList winfrmSalesOrderList = new frmSalesOrderList();
                winfrmSalesOrderList.StartPosition = FormStartPosition.Manual;
                winfrmSalesOrderList.MdiParent = this.MdiParent;
                winfrmSalesOrderList.Show();
            }
        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Venta");
                cmbStatus.Items.Clear();
                for (int i = 0; i < lstStatus.Count; i++)
                    cmbStatus.Items.Add(lstStatus[i]);
            }
        }

        private void cmbCommercialCondition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCommercialCondition> lstComercialCondition = clsCommercialCondition.getList();
                cmbCommercialCondition.Items.Clear();
                for (int i = 0; i < lstComercialCondition.Count; i++)
                    cmbCommercialCondition.Items.Add(lstComercialCondition[i]);
            }
        }
    }
}