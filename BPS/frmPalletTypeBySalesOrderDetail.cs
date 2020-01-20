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
    public partial class frmPalletTypeBySalesOrderDetail : Form
    {
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsEntity objCustomer = new clsEntity();

        public frmPalletTypeBySalesOrderDetail()
        {
            InitializeComponent();
        }
        public frmPalletTypeBySalesOrderDetail(int salesOrderCodsec)
        {

            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);
        }
        private void loadPalletList(int salesOrderDetailCodsec)
        {
            List<clsPalletTypeBySalesOrderDetail> lstPalletList = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(salesOrderDetailCodsec);

            dgvPalletType.Rows.Clear();
            for (int i = 0; i < lstPalletList.Count; i++)
            {
                dgvPalletType.Rows.Add();
                dgvPalletType.Rows[i].Cells[clmPalletTypeCodsec.Index].Value = lstPalletList[i].codsec;
                dgvPalletType.Rows[i].Cells[clmPalletTypePTCodsec.Index].Value = lstPalletList[i].fkPalletType;
                dgvPalletType.Rows[i].Cells[clmPalletTypeDimentionCodsec.Index].Value = lstPalletList[i].fkPalletDimention;
                dgvPalletType.Rows[i].Cells[clmPalletTypeTransportCodsec.Index].Value = lstPalletList[i].fkTransport;
                dgvPalletType.Rows[i].Cells[clmPalletTypeTransport.Index].Value = (new clsTransportBySalesOrder(lstPalletList[i].fkTransport)).ToString();
                dgvPalletType.Rows[i].Cells[clmPalletTypeName.Index].Value = lstPalletList[i].palletType.name;
                dgvPalletType.Rows[i].Cells[clmPalletTypeCoilsByPallet.Index].Value = lstPalletList[i].palletType.coilNumber;
                dgvPalletType.Rows[i].Cells[clmPalletTypeDimention.Index].Value = lstPalletList[i].palletDimention.ToString();
                dgvPalletType.Rows[i].Cells[clmPalletTypeQuantity.Index].Value = lstPalletList[i].quantity;
                dgvPalletType.Rows[i].Cells[clmPalletTypeTotalCoils.Index].Value = lstPalletList[i].quantity * lstPalletList[i].palletType.coilNumber;
                dgvPalletType.Rows[i].Cells[clmPalletTypeDelete.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }
        private void frmPalletTypeBySalesOrderDetail_Load(object sender, EventArgs e)
        {
            List<clsPalletType> lstPalletType = clsPalletType.getList();
            List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
            List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrder.codsec);

            if (lstTransportBySalesOrder.Count == 0)
            {
                MessageBox.Show("Antes de definir los tipos de pallet debe determinar el transporte a ser usado", "Definición de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                frmTransportBySalesOrder winTrasnportBySalesOrder = new frmTransportBySalesOrder();
                winTrasnportBySalesOrder.StartPosition = FormStartPosition.Manual;
                winTrasnportBySalesOrder.MdiParent = this.MdiParent;
                winTrasnportBySalesOrder.Show();
                this.Close();
            }

            for (int i = 0; i < lstPalletType.Count; i++)
                cmbPalletType.Items.Add(lstPalletType[i]);

            for (int i = 0; i < lstPalletDimention.Count; i++)
                cmbDimentions.Items.Add(lstPalletDimention[i]);

            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
                cmbTransport.Items.Add(lstTransportBySalesOrder[i]);

            if (objSalesOrder.codsec > 0)
            {
                lblNumber.Text = objSalesOrder.number;

                objCustomer.load(objSalesOrder.fkEntity);

                lblCustomerName.Text = objCustomer.companyName;
                lblCustomerId.Text = objCustomer.id;

                List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();

                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    dgvDetail.Rows.Add();
                    dgvDetail.Rows[i].Cells[clmCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].codsec.ToString();
                    dgvDetail.Rows[i].Cells[clmProductCode.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.code;
                    dgvDetail.Rows[i].Cells[clmProductWidth.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.width;
                    dgvDetail.Rows[i].Cells[clmProductDiameter.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.diameterName;
                    dgvDetail.Rows[i].Cells[clmProductCore.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.CoreValue.ToString() + "\"";
                    dgvDetail.Rows[i].Cells[clmProductCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkProduct.ToString();
                    dgvDetail.Rows[i].Cells[clmQuantity.Index].Value = objSalesOrder.lstSalesOrderDetail[i].quantity.ToString();
                    dgvDetail.Rows[i].Cells[clmStock.Index].Value = objSalesOrder.lstSalesOrderDetail[i].stock.ToString();
                    dgvDetail.Rows[i].Cells[clmCoils.Index].Value = objSalesOrder.lstSalesOrderDetail[i].coilsToCut;
                    //dgvDetail.Rows[i].Cells[clmCoils.Index].Value = Math.Round(Convert.ToDecimal(clsParameters.getCoilsNumberByWidthAndWeigth(objSalesOrder.lstSalesOrderDetail[i].product.codsec, objSalesOrder.lstSalesOrderDetail[i].quantity)), 0);
                    dgvDetail.Rows[i].Cells[clmInPallet.Index].Value = clsPalletTypeBySalesOrderDetail.getCoilsNumberBySalesOrderDetail(objSalesOrder.lstSalesOrderDetail[i].codsec);
                }
            }
        }

        private void btnAddPallet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidatePallet())
                {
                    bool flgIsNew = true;
                    int pos = -1;
                    clsPalletTypeBySalesOrderDetail objPalletTypeBySalesOrderDetail = new clsPalletTypeBySalesOrderDetail();

                    for (int i = 0; i < dgvPalletType.Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dgvPalletType.Rows[i].Cells[clmPalletTypePTCodsec.Index].Value) == ((clsPalletType)cmbPalletType.SelectedItem).codsec && Convert.ToInt32(dgvPalletType.Rows[i].Cells[clmPalletTypeDimentionCodsec.Index].Value) == ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec && Convert.ToUInt32(dgvPalletType.Rows[i].Cells[clmPalletTypeTransportCodsec.Index].Value) == ((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec)
                        {
                            pos = i;
                            flgIsNew = false;
                        }
                    }
                    if (flgIsNew)
                    {
                        objPalletTypeBySalesOrderDetail.fkSalesOrderDetail = Convert.ToInt32(dgvDetail.Rows[dgvDetail.SelectedRows[0].Index].Cells[clmCodsec.Index].Value);
                        objPalletTypeBySalesOrderDetail.fkPalletType = ((clsPalletType)cmbPalletType.SelectedItem).codsec;
                        objPalletTypeBySalesOrderDetail.fkPalletDimention = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                        objPalletTypeBySalesOrderDetail.fkTransport = ((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec;
                        objPalletTypeBySalesOrderDetail.quantity = Convert.ToInt32(txtQuantity.Text);
                        objPalletTypeBySalesOrderDetail.useSingleFace = chkSingleFace.Checked;
                    }
                    else
                    {
                        objPalletTypeBySalesOrderDetail.load(Convert.ToInt32(dgvPalletType.Rows[pos].Cells[clmPalletTypeCodsec.Index].Value));
                        objPalletTypeBySalesOrderDetail.quantity = objPalletTypeBySalesOrderDetail.quantity + Convert.ToInt32(txtQuantity.Text);
                        objPalletTypeBySalesOrderDetail.useSingleFace = chkSingleFace.Checked;
                    }

                    objPalletTypeBySalesOrderDetail.save();
                    loadPalletList(Convert.ToInt32(dgvDetail.Rows[dgvDetail.SelectedRows[0].Index].Cells[clmCodsec.Index].Value));
                    dgvDetail.Rows[dgvDetail.SelectedRows[0].Index].Cells[clmInPallet.Index].Value = clsPalletTypeBySalesOrderDetail.getCoilsNumberBySalesOrderDetail(objSalesOrder.lstSalesOrderDetail[dgvDetail.SelectedRows[0].Index].codsec);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar ingresar los datos que se encuentran pintados de color ROJO!!", "Tipo de Pallet", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tipo de Pallet", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        public bool ValidatePallet()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbPalletType, ref lblPalletType, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbDimentions, ref lblDimention, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtQuantity, ref lblQuantity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbTransport, ref lblTransport, "selected")) isValid = false;

            return isValid;
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadPalletList(Convert.ToInt32(dgvDetail.Rows[dgvDetail.SelectedRows[0].Index].Cells[clmCodsec.Index].Value));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPalletType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmPalletTypeDelete.Index)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el presente registro de pallets?", "Definición de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsPalletTypeBySalesOrderDetail.delete(Convert.ToInt32(dgvPalletType.Rows[e.RowIndex].Cells[clmPalletTypeCodsec.Index].Value));
                    loadPalletList(Convert.ToInt32(dgvDetail.Rows[dgvDetail.SelectedRows[0].Index].Cells[clmCodsec.Index].Value));
                    dgvDetail.Rows[dgvDetail.SelectedRows[0].Index].Cells[clmInPallet.Index].Value = clsPalletTypeBySalesOrderDetail.getCoilsNumberBySalesOrderDetail(objSalesOrder.lstSalesOrderDetail[dgvDetail.SelectedRows[0].Index].codsec);
                }
            }
        }

        private void cmbDimentions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
                cmbDimentions.Items.Clear();
                for (int i = 0; i < lstPalletDimention.Count; i++)
                    cmbDimentions.Items.Add(lstPalletDimention[i]);
            }
        }

        private void cmbPalletType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsPalletType> lstPalletType = clsPalletType.getList();
                cmbPalletType.Items.Clear();
                for (int i = 0; i < lstPalletType.Count; i++)
                    cmbPalletType.Items.Add(lstPalletType[i]);
            }
        }

        private void btnNewPallet_Click(object sender, EventArgs e)
        {
            frmPalletType winpallettype = new frmPalletType();
            winpallettype.StartPosition = FormStartPosition.CenterScreen;
            winpallettype.ShowDialog(this);
            List<clsPalletType> lstPalletType = clsPalletType.getList();
            cmbPalletType.Items.Clear();
            for (int i = 0; i < lstPalletType.Count; i++)
                cmbPalletType.Items.Add(lstPalletType[i]);
        }

        private void btnNewDimension_Click(object sender, EventArgs e)
        {
            frmPalletDimentions winpalletdimentions = new frmPalletDimentions();
            winpalletdimentions.StartPosition = FormStartPosition.CenterScreen;
            winpalletdimentions.ShowDialog(this);
            List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
            cmbDimentions.Items.Clear();
            for (int i = 0; i < lstPalletDimention.Count; i++)
                cmbDimentions.Items.Add(lstPalletDimention[i]);
        }

        private void cmbTransport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrder.codsec);
                cmbTransport.Items.Clear();
                for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
                    cmbTransport.Items.Add(lstTransportBySalesOrder[i]);
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCode.Text != "")
                {
                    clsPalletType objPalletTypeSelected = clsPalletType.getPalletTypeByCode(txtCode.Text);

                    if (objPalletTypeSelected.codsec > 0)
                    {
                        int selectedIndex = -1;

                        for (int i = 0; i < cmbDimentions.Items.Count; i++)
                        {
                            if (((clsPalletType)cmbPalletType.Items[i]).codsec == objPalletTypeSelected.codsec)
                            {
                                selectedIndex = i;
                                break;
                            }
                        }

                        cmbPalletType.SelectedIndex = selectedIndex;

                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a ningun tipo de pallet registrado.", "Definición de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        txtCode.Text = "";
                        cmbPalletType.SelectedIndex = -1;
                        txtCode.Focus();

                    }
                }
            }
        }

    }
}