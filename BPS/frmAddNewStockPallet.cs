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
    public partial class frmAddNewStockPallet : Form
    {
        clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();

        public frmAddNewStockPallet()
        {
            InitializeComponent();
        }
        public frmAddNewStockPallet(int cuttingOrderDetailCodsec)
        {
            InitializeComponent();
            objCuttingOrderDetail.load(cuttingOrderDetailCodsec);
            objCuttingOrder.load(objCuttingOrderDetail.fkCuttingOrder);
        }

        private void frmAddNewStockPallet_Load(object sender, EventArgs e)
        {
            lblNumber.Text = objCuttingOrder.number.ToString();
            lblProductName.Text = "[" + objCuttingOrderDetail.product.code + "] " + objCuttingOrderDetail.product.name;
            List<clsPalletType> lstPalletType = clsPalletType.getList();
            List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
            for (int i = 0; i < lstPalletType.Count; i++)
                cmbPalletType.Items.Add(lstPalletType[i]);

            for (int i = 0; i < lstPalletDimention.Count; i++)
                cmbDimentions.Items.Add(lstPalletDimention[i]);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPallet_Click(object sender, EventArgs e)
        {
            clsPalletTypeByCuttingOrderDetail objPalletTypeByCuttingOrderDetail = new clsPalletTypeByCuttingOrderDetail();
            objPalletTypeByCuttingOrderDetail.loadByPalletTypeAndCuttingOrderDetail(objCuttingOrderDetail.codsec, ((clsPalletType)cmbPalletType.SelectedItem).codsec);
            objPalletTypeByCuttingOrderDetail.quantity += Convert.ToInt32(txtQuantity.Text);
            objPalletTypeByCuttingOrderDetail.fkCuttingOrderDetail = objCuttingOrderDetail.codsec;
            objPalletTypeByCuttingOrderDetail.fkPalletDimention = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
            objPalletTypeByCuttingOrderDetail.fkPalletType = ((clsPalletType)cmbPalletType.SelectedItem).codsec;
            objPalletTypeByCuttingOrderDetail.save();
            MessageBox.Show("Se ha registrado el tipo de pallet para stock.");
            this.Close();
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
    }
}
