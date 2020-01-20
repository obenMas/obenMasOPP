using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmInternationalSalesOrderDetail : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedCustomerCodsec = 0;
        clsEntity objCustomer = new clsEntity();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();


        public frmInternationalSalesOrderDetail()
        {
            InitializeComponent();
        }
        public frmInternationalSalesOrderDetail(int salesOrderCodsec)
        {
            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);
        }
        
        private void frmInternationalSalesOrderDetail_Load(object sender, EventArgs e)
        {
            lstSalesOrderDetail.Add(new clsSalesOrderDetail());

            if (objSalesOrder.codsec > 0)
            {
                lblNumber.Text = objSalesOrder.number;
                lblDate.Text = objSalesOrder.createdDate.ToString("dd/MM/yyyy HH:mm");
                lblStatus.Text = objSalesOrder.StatusName;
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
                    dgvDetail.Rows[i].Cells[clmStatus.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkStatus.ToString();
                }

                lblCountryFrom.Text = new clsCountry (clsCity.getCountry(objSalesOrder.ExportData.fkCityFrom)).name;
                lblCityFrom.Text = new clsCity(objSalesOrder.ExportData.fkCityFrom).name;
                lblCountryTo.Text = new clsCountry (clsCity.getCountry(objSalesOrder.ExportData.fkCityTo)).name;
                lblCityTo.Text = new clsCity(objSalesOrder.ExportData.fkCityTo).name;
                
                lblPackaging.Text = objSalesOrder.ExportData.packagingTypeName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}