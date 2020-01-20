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
    public partial class frmInternationalSalesOrderList : Form
    {
        public frmInternationalSalesOrderList()
        {
            InitializeComponent();
        }
        public void populateDataGrid()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvSalesOrder.Rows.Clear();
            if (chkCustomerFilter.Checked || chkDateFilter.Checked || chkNumberFilter.Checked || chkStatusFilter.Checked)
            {
                if (chkCustomerFilter.Checked && cmbCustomer.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbCustomer.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkStatusFilter.Checked && cmbStatus.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_fkStatus";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsStatus)cmbStatus.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkCustomerFilter.Checked && txtCustomerId.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_EntityId";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCustomerId.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "sord_createdDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpFrom.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].value2 = dtpTo.Value.ToString("dd/MM/yyyy");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }
                if (chkNumberFilter.Checked && txtNumberFrom.Text != "")
                {
                    if (txtNumberTo.Text != "")
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "sord_number";
                        lstFilter[lstFilter.Count - 1].operation = "between";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].value2 = txtNumberTo.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
                    }
                    else
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "sord_number";
                        lstFilter[lstFilter.Count - 1].operation = "contains";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    }
                }

                lstSalesOrder = clsSalesOrder.getListByFilter(lstFilter, true);
            }
            else
                lstSalesOrder = clsSalesOrder.getList(true);

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                dgvSalesOrder.Rows.Add();
                dgvSalesOrder.Rows[i].Cells[clmCodsec.Index].Value = lstSalesOrder[i].codsec.ToString();
                dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value = lstSalesOrder[i].createdDate.ToString();
                dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value = lstSalesOrder[i].number.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCustomerId.Index].Value = lstSalesOrder[i].EntityID.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                dgvSalesOrder.Rows[i].Cells[clmStatus.Index].Value = lstSalesOrder[i].StatusName.ToString();
                dgvSalesOrder.Rows[i].Cells[clmEditSalesOrder.Index].Value = global::BPS.Properties.Resources.pencil;
                dgvSalesOrder.Rows[i].Cells[clmReportUnPrice.Index].Value = global::BPS.Properties.Resources.reportOff;
                dgvSalesOrder.Rows[i].Cells[clmReport.Index].Value = global::BPS.Properties.Resources.report;
            }
        }

        private void frmInternationalSalesOrderList_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            List<clsEntity> lstEntity = clsEntity.getCustomerList();
            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Venta");

            for (int i = 0; i < lstEntity.Count; i++)
                cmbCustomer.Items.Add(lstEntity[i]);

            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkDateFilter.Checked = false;
            chkNumberFilter.Checked = false;
            chkStatusFilter.Checked = false;
            chkCustomerFilter.Checked = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            txtNumberFrom.Text = "";
            txtNumberTo.Text = "";
            cmbCustomer.SelectedIndex = -1;
            txtCustomerId.Text = "";
            cmbStatus.SelectedIndex = -1;
            populateDataGrid();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDateFilter.Checked)
                grpbDates.Enabled = true;
            else
                grpbDates.Enabled = false;
        }

        private void chkNumberFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNumberFilter.Checked)
                grpbNumber.Enabled = true;
            else
                grpbNumber.Enabled = false;
        }

        private void chkCustomerFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomerFilter.Checked)
                grpbCustomer.Enabled = true;
            else
                grpbCustomer.Enabled = false;
        }

        private void chkStatusFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStatusFilter.Checked)
                grpbStatus.Enabled = true;
            else
                grpbStatus.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInternationalSalesOrderForm winInternationalSalesOrderForm = new frmInternationalSalesOrderForm();
            winInternationalSalesOrderForm.MdiParent = this.MdiParent;
            winInternationalSalesOrderForm.Show();
            this.Close();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrder.SelectedRows.Count > 0)
            {
                frmInternationalSalesOrderForm winInternationalSalesOrderForm = new frmInternationalSalesOrderForm(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
                winInternationalSalesOrderForm.MdiParent = this.MdiParent;
                winInternationalSalesOrderForm.Show();
            }
        }

        private void dgvSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEditSalesOrder.Index)
            {
                frmInternationalSalesOrderForm winInternationalSalesOrderForm = new frmInternationalSalesOrderForm(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
                winInternationalSalesOrderForm.MdiParent = this.MdiParent;
                winInternationalSalesOrderForm.Show();
            }
            //if (e.ColumnIndex == clmReportUnPrice.Index)
            //{
            //    frmInternationalSalesOrderReports winInternationalSalesOrder = new frmInternationalSalesOrderReports(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
            //    winInternationalSalesOrder.MdiParent = this.MdiParent;
            //    winInternationalSalesOrder.StartPosition = FormStartPosition.Manual;
            //    winInternationalSalesOrder.Show();
            //    frmPalletTypeBySalesOrderDetail winPalletBySalesOrderDetail = new frmPalletTypeBySalesOrderDetail(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
            //    winPalletBySalesOrderDetail.MdiParent = this.MdiParent;
            //    winPalletBySalesOrderDetail.StartPosition = FormStartPosition.Manual;
            //    winPalletBySalesOrderDetail.Show();
            //    this.Close();
            //}
            //if (e.ColumnIndex == clmReport.Index)
            //{
            //    frmInternationalSalesOrderReport winInternationalSalesOrderReport = new frmInternationalSalesOrderReport(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
            //    winInternationalSalesOrderReport.MdiParent = this.MdiParent;
            //    winInternationalSalesOrderReport.StartPosition = FormStartPosition.Manual;
            //    winInternationalSalesOrderReport.Show();
            //}
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrder.SelectedRows.Count > 0)
            {
                frmInternationalSalesOrderDetail winInternationalSalesOrderDetail = new frmInternationalSalesOrderDetail(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
                winInternationalSalesOrderDetail.MdiParent = this.MdiParent;
                winInternationalSalesOrderDetail.Show();
                this.Close();
            }
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsEntity> lstEntity = clsEntity.getCustomerList();
                cmbCustomer.Items.Clear();
                for (int i = 0; i < lstEntity.Count; i++)
                    cmbCustomer.Items.Add(lstEntity[i]);
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

        private void txtNumberFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberFrom.Text.Length > 0 || txtNumberFrom.Text != string.Empty)
                populateDataGrid();
        }

    }
}