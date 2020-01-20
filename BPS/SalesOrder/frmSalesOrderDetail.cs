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
    public partial class frmSalesOrderDetail : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedCustomerCodsec = 0;
        clsEntity objCustomer = new clsEntity();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();

        public frmSalesOrderDetail()
        {
            InitializeComponent();
        }
        public frmSalesOrderDetail(int salesOrderCodsec)
        {
            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);
        }
        private void frmSalesOrderDetail_Load(object sender, EventArgs e)
        {
            lstSalesOrderDetail.Add(new clsSalesOrderDetail());

            if (objSalesOrder.codsec > 0)
            {
                lblNumber.Text = objSalesOrder.number;
                lblDate.Text = objSalesOrder.createdDate.ToString("dd/MM/yyyy HH:mm");
                lblStatus.Text = objSalesOrder.StatusName ;
                lblCommercialCondition.Text = objSalesOrder.CommercialConditionName;
                objCustomer.load(objSalesOrder.fkEntity);
                lblCustomerName.Text = objCustomer.companyName;
                lblCountry.Text = objCustomer.countryName;
                lblCustomerId.Text = objCustomer.id;
                
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                if (lstAddress.Count > 0)
                    lblAddress.Text = lstAddress[0].address;
                else
                    lblAddress.Text = "";
                
                lblNotes.Text = objSalesOrder.notes;
                
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
                    dgvDetail.Rows[i].Cells[clmStatus.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkStatus.ToString();
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}