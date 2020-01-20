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
    public partial class frmCustomerListReport : Form
    {
        clsEntity ObjEntity = new clsEntity();
        public frmCustomerListReport()
        {
            InitializeComponent();
            ObjEntity.load();
        }

        private void frmCustomerListReport_Load(object sender, EventArgs e)
        {
            FillDataCustomer();
        }

        private void FillDataCustomer()
        {
            List<clsEntity> lstCustomer = new List<clsEntity>();
            lstCustomer = clsEntity.getList();
            cmbCustomer.Items.Clear();
            for (int i = 0; i < lstCustomer.Count; i++)
            {
                cmbCustomer.Items.Add(lstCustomer[i]);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<clsSalesOrderDetail> lstSalesOrderDetails = new List<clsSalesOrderDetail>();
            lstSalesOrderDetails = clsSalesOrderDetail.getListByOrderDetailByCustomer(Convert.ToInt32(((clsEntity)cmbCustomer.SelectedItem).codsec));

            dgvCustomer.Rows.Clear();

            if (lstSalesOrderDetails.Count > 0)
            {
                for (int i = 0; i < lstSalesOrderDetails.Count; i++)
                {
                    dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[i].Cells[clmCodSecSalesOrderDetails.Index].Value = lstSalesOrderDetails[i].sordcodsec.ToString();
                    dgvCustomer.Rows[i].Cells[clmSalesOrder.Index].Value = lstSalesOrderDetails[i].sordnumber.ToString();
                    dgvCustomer.Rows[i].Cells[clmProductName.Index].Value = lstSalesOrderDetails[i].sodProductName.ToString();
                    dgvCustomer.Rows[i].Cells[clmQuantity.Index].Value = lstSalesOrderDetails[i].quantity.ToString();
                    dgvCustomer.Rows[i].Cells[clmPrice.Index].Value = lstSalesOrderDetails[i].price.ToString();
                } 
            }
            else
            {
                MessageBox.Show("No hay ordenes de compra con ese cliente", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.Rows.Count != 0)
            {
                frmCustomerListReportView winEnity = new frmCustomerListReportView(Convert.ToInt32(((clsEntity)cmbCustomer.SelectedItem).codsec));
                winEnity.StartPosition = FormStartPosition.Manual;
                winEnity.Show();
            }
            else
            {
                MessageBox.Show("No hay datos en el reporte", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFilterAllEntity_Click(object sender, EventArgs e)
        {
            if (chbAllEntity.Checked == true)
            {
                List<clsSalesOrderDetail> lstSalesOrderDetails = new List<clsSalesOrderDetail>();
                lstSalesOrderDetails = clsSalesOrderDetail.getListByAllCustomer();

                dgvCustomer.Rows.Clear();

                if (lstSalesOrderDetails.Count > 0)
                {
                    for (int i = 0; i < lstSalesOrderDetails.Count; i++)
                    {
                        dgvCustomer.Rows.Add();
                        dgvCustomer.Rows[i].Cells[clmCodSecSalesOrderDetails.Index].Value = lstSalesOrderDetails[i].sordcodsec.ToString();
                        dgvCustomer.Rows[i].Cells[clmSalesOrder.Index].Value = lstSalesOrderDetails[i].sordnumber.ToString();
                        dgvCustomer.Rows[i].Cells[clmProductName.Index].Value = lstSalesOrderDetails[i].sodProductName.ToString();
                        dgvCustomer.Rows[i].Cells[clmQuantity.Index].Value = lstSalesOrderDetails[i].quantity.ToString();
                        dgvCustomer.Rows[i].Cells[clmPrice.Index].Value = lstSalesOrderDetails[i].price.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe selecionar todos los clientes", "Ventas Nacionales", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
    }
}
