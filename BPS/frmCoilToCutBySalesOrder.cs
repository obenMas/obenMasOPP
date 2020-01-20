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
    public partial class frmCoilToCutBySalesOrder : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedCustomerCodsec = 0;
        clsEntity objCustomer = new clsEntity();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();

        public void loadSalesOrderInformation()
        {
            objSalesOrder = clsSalesOrder.getDetailByNumber(txtNumber.Text);

            if (objSalesOrder.codsec > 0)
            {

                lblStatus.Text = objSalesOrder.StatusName;
                int totalCoilToCut = 0;
                txtCustomerName.Text = objSalesOrder.EntityName;
                lblStatus.Text = objSalesOrder.StatusName;
                
                lstSalesOrderDetail = objSalesOrder.lstSalesOrderDetail;

                dgvDetail.Rows.Clear();

                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    dgvDetail.Rows.Add();
                    dgvDetail.Rows[i].Cells[clmCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].codsec.ToString();
                    dgvDetail.Rows[i].Cells[clmQuantity.Index].Value = objSalesOrder.lstSalesOrderDetail[i].quantity.ToString();
                    dgvDetail.Rows[i].Cells[clmProductCode.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.code;
                    dgvDetail.Rows[i].Cells[clmProductName.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.name;
                    dgvDetail.Rows[i].Cells[clmProductCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkProduct.ToString();
                    dgvDetail.Rows[i].Cells[clmCoilsToCut.Index].Value = objSalesOrder.lstSalesOrderDetail[i].coilsToCut.ToString();
                    totalCoilToCut += objSalesOrder.lstSalesOrderDetail[i].coilsToCut;
                }

                txtTotal.Text = totalCoilToCut.ToString();
            }
        }                
        public void calculateTotals()
        {
            
        }
        public frmCoilToCutBySalesOrder()
        {
            InitializeComponent();
        }
        private void frmSalesOrderForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                objSalesOrder.lstSalesOrderDetail[i].coilsToCut = Convert.ToInt32(dgvDetail.Rows[i].Cells[clmCoilsToCut.Index].Value);
                objSalesOrder.lstSalesOrderDetail[i].save();
            }
            MessageBox.Show("La información de bobinas a cortar por orden de venta ha sido guardada con éxito.", "Bobinas a cortar por orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

        }
        private void dgvDetail_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            lstSalesOrderDetail.Add(new clsSalesOrderDetail());
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadSalesOrderInformation();
            }
        }

        private void dgvDetail_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            int totalCoilToCut = 0;

            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                totalCoilToCut += Convert.ToInt32(dgvDetail.Rows[i].Cells[clmCoilsToCut.Index].Value);
            }

            txtTotal.Text = totalCoilToCut.ToString();
        }
    }
}