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
    public partial class frmPurchaseOrderList : Form
    {
        public frmPurchaseOrderList()
        {
            InitializeComponent();
        }
        public void populateDataGrid()
        {
            List<clsPurchaseOrder> lstPurchaseOrder = new List<clsPurchaseOrder>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvPurchaseOrder.Rows.Clear();
            if (chkCustomerFilter.Checked || chkDateFilter.Checked || chkNumberFilter.Checked || chkStatusFilter.Checked)
            {
                if (chkCustomerFilter.Checked && cmbProvider.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "purord_fkEntity";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbProvider.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkStatusFilter.Checked && cmbStatus.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "purord_fkStatus";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsStatus)cmbStatus.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkCustomerFilter.Checked && txtProviderId.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "purord_entityId";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtProviderId.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkDateFilter.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "purord_createdDate";
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
                        lstFilter[lstFilter.Count - 1].field = "purord_number";
                        lstFilter[lstFilter.Count - 1].operation = "between";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].value2 = txtNumberTo.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
                    }
                    else
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "purord_number";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
                    }
                }

                lstPurchaseOrder = clsPurchaseOrder.getListByFilter(lstFilter);
            }
            else
                lstPurchaseOrder = clsPurchaseOrder.getList();

            for (int i = 0; i < lstPurchaseOrder.Count; i++)
            {
                dgvPurchaseOrder.Rows.Add();
                dgvPurchaseOrder.Rows[i].Cells["clmCodsec"].Value = lstPurchaseOrder[i].codsec.ToString();
                dgvPurchaseOrder.Rows[i].Cells["clmDate"].Value = lstPurchaseOrder[i].createdDate.ToString();
                dgvPurchaseOrder.Rows[i].Cells["clmNumber"].Value = lstPurchaseOrder[i].number.ToString();
                dgvPurchaseOrder.Rows[i].Cells["clmProviderId"].Value = lstPurchaseOrder[i].entityId.ToString();
                dgvPurchaseOrder.Rows[i].Cells["clmProveedor"].Value = lstPurchaseOrder[i].entityName.ToString();
                dgvPurchaseOrder.Rows[i].Cells["clmStatus"].Value = lstPurchaseOrder[i].statusName.ToString();
            }
        }

        private void frmPurchaseOrderList_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            List<clsEntity> lstEntity = clsEntity.getProviderList();
            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Compra");

            for (int i = 0; i < lstEntity.Count; i++)
                cmbProvider.Items.Add(lstEntity[i]); 

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
            cmbProvider.SelectedIndex = -1;
            txtProviderId.Text = "";
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
                grpbProviders.Enabled = true; 
            else
                grpbProviders.Enabled = false;
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
            frmPurchaseOrder winPurchaseOrder = new frmPurchaseOrder();
            winPurchaseOrder.MdiParent = this.MdiParent;
            winPurchaseOrder.Show();
            this.Close();
        }

        private void dgvPurchaseOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPurchaseOrder winPurchaseOrder = new frmPurchaseOrder(Convert.ToInt32(dgvPurchaseOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
            winPurchaseOrder.MdiParent = this.MdiParent;
            winPurchaseOrder.Show();
            this.Close();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvPurchaseOrder.SelectedRows.Count > 0)
            {
                frmPurchaseOrder winPurchaseOrder = new frmPurchaseOrder(Convert.ToInt32(dgvPurchaseOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
                winPurchaseOrder.MdiParent = this.MdiParent;
                winPurchaseOrder.Show();
                this.Close();
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {

        }

        private void cmbProvider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsEntity> lstProvider = clsEntity.getProviderList();
                cmbProvider.Items.Clear();
                for (int i = 0; i < lstProvider.Count; i++)
                    cmbProvider.Items.Add(lstProvider[i]);
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
    }
}