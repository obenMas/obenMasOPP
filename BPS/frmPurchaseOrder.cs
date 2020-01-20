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
    public partial class frmPurchaseOrder : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedProviderCodsec = 0;
        clsEntity objProvider = new clsEntity();
        public int selectedRawMaterial = 0;
        public double total = 0;
        public string LastNumber = "";
        clsPurchaseOrder objPurchaseOrder = new clsPurchaseOrder();
        List<clsPurchaseOrderDetail> lstPurchaseOrderDetail = new List<clsPurchaseOrderDetail>();

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbCommercialCondition, ref lblCommercialCondition, "selected")) isValid = false;
            //if (!clsValidation.validateField(ref cmbCurrency, ref lblCurrency, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
          //  if (!clsValidation.validateField(ref dgvDetail, ref grpbDetail, "isValid")) isValid = false;
            if (!clsValidation.validateField(ref txtProviderId, ref lblProviderId, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtProviderName, ref lblProviderName, "notEmpty")) isValid = false;
            //if (!clsValidation.validateField(ref txtQuote, ref lblQuote, "notEmpty")) isValid = false;

            return isValid;
        }
        public void calculateTotals()
        {
            double quantity = 0;
            double subTotal = 0;
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                subTotal += Convert.ToDouble((dgvDetail.Rows[i].Cells["clmSubtotal"].Value != null && dgvDetail.Rows[i].Cells["clmSubTotal"].Value.ToString() != "") ? dgvDetail.Rows[i].Cells["clmSubTotal"].Value.ToString() : "0");
                quantity += Convert.ToDouble((dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.RowIndex == i && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index) ? dgvDetail.CurrentCell.EditedFormattedValue.ToString() : (dgvDetail.Rows[i].Cells["clmQuantity"].Value != null && dgvDetail.Rows[i].Cells["clmQuantity"].Value.ToString() != "") ? dgvDetail.Rows[i].Cells["clmQuantity"].Value.ToString() : "0");

            }
            txtTotal.Text = subTotal.ToString();
            txtTotalWeigth.Text = quantity.ToString();
        }
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
        public frmPurchaseOrder(int PurchaseOrderCodsec)
        {
            InitializeComponent();
            objPurchaseOrder.load(PurchaseOrderCodsec);
        }
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            List<clsCommercialCondition> lstCommercialCondition = new List<clsCommercialCondition>();
            lstCommercialCondition = clsCommercialCondition.getList();
            cmbCommercialCondition.Items.Clear();
            for (int i = 0; i < lstCommercialCondition.Count; i++)
                cmbCommercialCondition.Items.Add(lstCommercialCondition[i]);

            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Compra");
            cmbStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            //List<clsCurrency> lstCurrency = clsCurrency.getList();
            //cmbCurrency.Items.Clear();
            //for (int i = 0; i < lstCurrency.Count; i++)
            //{
            //    cmbCurrency.Items.Add(lstCurrency[i]);
            //    if (lstCurrency[i].codsec == clsGlobal.Company.fkCurrency)
            //        cmbCurrency.SelectedIndex = i;
            //}

            lstPurchaseOrderDetail.Add(new clsPurchaseOrderDetail());
            if (objPurchaseOrder.codsec > 0)
            {
                txtNumber.Text = objPurchaseOrder.number;
                dtpDate.Value = objPurchaseOrder.createdDate;

                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objPurchaseOrder.fkStatus)
                        cmbStatus.SelectedIndex = i;
                }

                for (int i = 0; i < cmbCommercialCondition.Items.Count; i++)
                {
                    if (((clsCommercialCondition)cmbCommercialCondition.Items[i]).codsec == objPurchaseOrder.fkCommercialCondition)
                        cmbCommercialCondition.SelectedIndex = i;
                }

                //for (int i = 0; i < cmbCurrency.Items.Count; i++)
                //{
                //    if (((clsCurrency)cmbCurrency.Items[i]).codsec == objPurchaseOrder.fkCurrency)
                //        cmbCurrency.SelectedIndex = i;
                //}

                objProvider.load(objPurchaseOrder.fkEntity);
                txtNumber.Text = objPurchaseOrder.purchaseOrder;
                txtNumberPurchaseOrder.Text = objPurchaseOrder.number;
                //txtQuote.Text = Convert.ToString(Math.Round(objPurchaseOrder.quote,2));
                txtNotes.Text = objPurchaseOrder.notes;
                txtProviderName.Text = objProvider.companyName;
                txtProviderCountry.Text = objProvider.countryName;
                txtProviderId.Text = objProvider.id;
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objProvider.codsec);
                if (lstAddress.Count > 0)
                    txtProviderAddress.Text = lstAddress[0].address;
                else
                    txtProviderAddress.Text = "";
                
                txtNotes.Text = objPurchaseOrder.notes;
                lstPurchaseOrderDetail = objPurchaseOrder.lstPurchaseOrderDetail;
                for (int i = 0; i < objPurchaseOrder.lstPurchaseOrderDetail.Count; i++)
                {
                    dgvDetail.Rows.Add();
                    dgvDetail.Rows[i].Cells[clmCodsec.Index].Value = objPurchaseOrder.lstPurchaseOrderDetail[i].codsec.ToString();
                    dgvDetail.Rows[i].Cells[clmRawMaterialCodsec.Index].Value = objPurchaseOrder.lstPurchaseOrderDetail[i].fkRawMaterial.ToString();
                    dgvDetail.Rows[i].Cells[clmQuantity.Index].Value = objPurchaseOrder.lstPurchaseOrderDetail[i].quantity.ToString();
                    dgvDetail.Rows[i].Cells[clmRawMaterialType.Index].Value = objPurchaseOrder.lstPurchaseOrderDetail[i].TypeRawMaterialName.ToString();
                    dgvDetail.Rows[i].Cells[clmRawMaterialCode.Index].Value = objPurchaseOrder.lstPurchaseOrderDetail[i].RawMaterialCode.ToString();
                    dgvDetail.Rows[i].Cells[clmRawMaterialName.Index].Value = objPurchaseOrder.lstPurchaseOrderDetail[i].RawMaterialName.ToString();
                    dgvDetail.Rows[i].Cells[clmPrice.Index].Value = Math.Round(objPurchaseOrder.lstPurchaseOrderDetail[i].price,2).ToString();
                    calculateTotals();
                    dgvDetail.Rows[i].Cells[clmSubTotal.Index].Value = Math.Round((Convert.ToDouble(objPurchaseOrder.lstPurchaseOrderDetail[i].price) * Convert.ToDouble(objPurchaseOrder.lstPurchaseOrderDetail[i].quantity)),2);   
                }
                calculateTotals();
            }
            else
            {
                LastNumber = clsPurchaseOrder.getLastNumberOrder();
                txtNumberPurchaseOrder.Text = LastNumber;
            }
        }

        private void btnSearchProvider_Click(object sender, EventArgs e)
        {
            objProvider = new clsEntity();
            frmProviderList winProviderList = new frmProviderList(this);
            winProviderList.ShowDialog(this);
            objProvider.load(selectedProviderCodsec);

            if (objProvider.codsec > 0)
            {
                txtProviderName.Text = objProvider.companyName;
                txtProviderCountry.Text = objProvider.countryName;
                txtProviderId.Text = objProvider.id;
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objProvider.codsec);
                if (lstAddress.Count > 0)
                    txtProviderAddress.Text = lstAddress[0].address;
                else
                    txtProviderAddress.Text = "";
            }
            else
            {
                MessageBox.Show("La identificación ingresada no coinside con ningun proveedor reguistrado.", "Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtProviderName.Text = "";
                txtProviderCountry.Text = "";
                txtProviderId.Text = "";
                txtProviderAddress.Text = "";
            }
        }
        private double TotalCalculator()
        {
            total = (Convert.ToDouble(dgvDetail.CurrentRow.Cells[clmQuantity.Index].Value) * Convert.ToDouble(dgvDetail.CurrentRow.Cells[clmPrice.Index].Value));
            return total;
        }
        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();

            frmRawMaterialSelector winPurchaseOrder = new frmRawMaterialSelector(this);
            winPurchaseOrder.ShowDialog(this);
            objRawMaterial.load(selectedRawMaterial);

            if (objRawMaterial.codsec > 0)
            {
                dgvDetail.CurrentRow.Cells[clmRawMaterialCodsec.Index].Value = objRawMaterial.codsec;
                dgvDetail.CurrentRow.Cells[clmRawMaterialType.Index].Value = objRawMaterial.RawMaterialtypeName;
                dgvDetail.CurrentRow.Cells[clmRawMaterialCode.Index].Value = objRawMaterial.code;
                dgvDetail.CurrentRow.Cells[clmRawMaterialName.Index].Value = objRawMaterial.name;

                //aqui hay que agregarle a la lista
                lstPurchaseOrderDetail[e.RowIndex].fkRawMaterial = objRawMaterial.codsec;
                lstPurchaseOrderDetail[e.RowIndex].fkTypeRawMaterial = objRawMaterial.fkRawMaterialtype;
            } 
            
        }

        private void dgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double quantity = 0;
            double price = 0;
            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
            {
                switch (dgvDetail.CurrentCell.ColumnIndex)
                {
                    case 2:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numerico");
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

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Convert.ToString(quantity * price);

                        }
                        calculateTotals();
                        lstPurchaseOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                        lstPurchaseOrderDetail[dgvDetail.CurrentRow.Index].price = price;

                        break;
                    case 6:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numerico");
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

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Convert.ToString(quantity * price);
                        }
                        calculateTotals();
                        lstPurchaseOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                        lstPurchaseOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        break;

                    default:
                        break;
                }
            }
        }

        private void dgvDetail_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            lstPurchaseOrderDetail.Add(new clsPurchaseOrderDetail());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                objPurchaseOrder.fkEntity = objProvider.codsec;
                objPurchaseOrder.fkCommercialCondition = ((clsCommercialCondition)cmbCommercialCondition.SelectedItem).codsec;
                objPurchaseOrder.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                objPurchaseOrder.fkCurrency = 125; 
                //objPurchaseOrder.quote = Convert.ToDouble(txtQuote.Text);
                objPurchaseOrder.purchaseOrder = txtNumber.Text;
                objPurchaseOrder.number =  txtNumberPurchaseOrder.Text;
                objPurchaseOrder.notes = txtNotes.Text;
                objPurchaseOrder.createdDate = dtpDate.Value;
                objPurchaseOrder.lstPurchaseOrderDetail = lstPurchaseOrderDetail;

                if (objPurchaseOrder.save())
                {
                    MessageBox.Show("La orden de compra se ha guardado con éxito.", "Orden de Compra", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    if (MessageBox.Show("Desea crear una nueva orden?", "Nueva Orden de Compra", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsGlobal.ClearForm(this);
                        objProvider = new clsEntity();
                        objPurchaseOrder = new clsPurchaseOrder();
                        dtpDate.Focus();
                    }
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Productos de Materias Primas y Suministros", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Compra");
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

        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //List<clsCurrency> lstCurrency = clsCurrency.getList();
                //cmbCurrency.Items.Clear();
                //for (int i = 0; i < lstCurrency.Count; i++)
                //    cmbCurrency.Items.Add(lstCurrency[i]);
            }
        }
    }
}

