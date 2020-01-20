using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmAddNewPalletType : Form
    {
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsPalletTypeBySalesOrderDetail> lstPalletList = new List<clsPalletTypeBySalesOrderDetail>();

        public frmAddNewPalletType()
        {
            InitializeComponent();
        }
        public frmAddNewPalletType(int salesOrderDetailCodsec)
        {
            InitializeComponent();
            objSalesOrderDetail.load(salesOrderDetailCodsec);
            objSalesOrder.load(objSalesOrderDetail.fkSalesOrder);

        }

        private void frmAddNewStockPallet_Load(object sender, EventArgs e)
        {
            lblNumber.Text = objSalesOrder.number.ToString();
            lblProductName.Text = "[" + objSalesOrderDetail.product.code + "] " + objSalesOrderDetail.product.name;
            List<clsPalletType> lstPalletType = clsPalletType.getList();
            List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
            for (int i = 0; i < lstPalletType.Count; i++)
                cmbPalletType.Items.Add(lstPalletType[i]);

            for (int i = 0; i < lstPalletDimention.Count; i++)
                cmbDimentions.Items.Add(lstPalletDimention[i]);
            List<clsTransportBySalesOrder> lstTransportBySalesOrder = clsTransportBySalesOrder.getListBySalesOrder(objSalesOrder.codsec);
            lstPalletList = clsPalletTypeBySalesOrderDetail.getListBySalesOrderDetail(objSalesOrderDetail.codsec);

            for (int i = 0; i < lstTransportBySalesOrder.Count; i++)
                cmbTransport.Items.Add(lstTransportBySalesOrder[i]);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPallet_Click(object sender, EventArgs e)
        {
            bool flgIsNew = true;
            int pos = -1;
            
            clsPalletTypeBySalesOrderDetail objPalletTypeBySalesOrderDetail = new clsPalletTypeBySalesOrderDetail();

            if (cmbDimentions.SelectedIndex > -1 && cmbPalletType.SelectedIndex > -1 && cmbTransport.SelectedIndex > -1 && (txtQuantity.Text != "" || txtQuantity.Text != "0"))
            {

                for (int i = 0; i < lstPalletList.Count; i++)
                {
                    if (lstPalletList[i].fkPalletType == ((clsPalletType)cmbPalletType.SelectedItem).codsec && lstPalletList[i].fkPalletDimention == ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec && lstPalletList[i].fkTransport == ((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec)
                    {
                        pos = i;
                        flgIsNew = false;
                    }
                }
                if (flgIsNew)
                {
                    objPalletTypeBySalesOrderDetail.fkSalesOrderDetail = objSalesOrderDetail.codsec;
                    objPalletTypeBySalesOrderDetail.fkPalletType = ((clsPalletType)cmbPalletType.SelectedItem).codsec;
                    objPalletTypeBySalesOrderDetail.fkPalletDimention = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                    objPalletTypeBySalesOrderDetail.fkTransport = ((clsTransportBySalesOrder)cmbTransport.SelectedItem).codsec;
                    objPalletTypeBySalesOrderDetail.quantity = Convert.ToInt32(txtQuantity.Text);
                    objPalletTypeBySalesOrderDetail.useSingleFace = chkSingleFace.Checked;
                }
                else
                {
                    objPalletTypeBySalesOrderDetail.load(lstPalletList[pos].codsec);
                    objPalletTypeBySalesOrderDetail.quantity = objPalletTypeBySalesOrderDetail.quantity + Convert.ToInt32(txtQuantity.Text);
                    objPalletTypeBySalesOrderDetail.useSingleFace = chkSingleFace.Checked;
                }

                objPalletTypeBySalesOrderDetail.save();

                MessageBox.Show("Se ha registrado el tipo de pallet correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha podido registrar el nuevo pallet, debe ingresar todos los campos.");
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

        private void cmbPalletType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F5)
            {
                List<clsPalletType> lstPalletType = clsPalletType.getList();
                cmbPalletType.Items.Clear();
                for (int i = 0; i < lstPalletType.Count; i++)
                    cmbPalletType.Items.Add(lstPalletType[i]);
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
