using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmProviderList : Form
    {
        frmPurchaseOrder prntPurchaseOrder;
        int selectedProviderCodsec = 0;
        string CALLerForm = "";

        public void populateDataGrid()
        {
            List<clsEntity> lstProviders = new List<clsEntity>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (txtProviderId.Text != "" || txtProviderName.Text != "")
            {
                if (txtProviderId.Text != "")
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "entt_id";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtProviderId.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (txtProviderName.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "entt_companyName";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtProviderName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstProviders = clsEntity.getProviderListByFilter(lstFilter);
            }
            else
                lstProviders = clsEntity.getProviderList();

            dgvProviders.Rows.Clear();

            for (int i = 0; i < lstProviders.Count; i++)
            {
                dgvProviders.Rows.Add();
                dgvProviders.Rows[i].Cells["clmCodsec"].Value = lstProviders[i].codsec.ToString();
                dgvProviders.Rows[i].Cells["clmCompany"].Value = lstProviders[i].companyName.ToString();
                dgvProviders.Rows[i].Cells["clmName"].Value = lstProviders[i].contactName.ToString();
                dgvProviders.Rows[i].Cells["clmCountry"].Value = lstProviders[i].countryName.ToString();
                dgvProviders.Rows[i].Cells["clmStatus"].Value = lstProviders[i].statusName.ToString();
            }
        }

        public void returnCustomer()
        {
            switch (CALLerForm)
            {
                case "ProviderOrder":
                    selectedProviderCodsec = Convert.ToInt32(dgvProviders.SelectedRows[0].Cells["clmCodsec"].Value);
                    prntPurchaseOrder.selectedProviderCodsec = selectedProviderCodsec;
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        public frmProviderList()
        {
            InitializeComponent();
        }

        public frmProviderList(frmPurchaseOrder winProviderOrder)
        {
            InitializeComponent();
            prntPurchaseOrder = winProviderOrder;
            btnAdd.Hide();
            btnEditCompany.Hide();
            CALLerForm = "ProviderOrder";
        }

        private void frmProviderList_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            if (this.Modal == true)
                txtProviderName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProviderForm winProviderForm = new frmProviderForm();
            winProviderForm.MdiParent = this.MdiParent;
            winProviderForm.Show();
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvProviders.SelectedRows.Count > 0)
            {
                frmProviderForm winProviderForm = new frmProviderForm(Convert.ToInt32(dgvProviders.SelectedRows[0].Cells["clmCodsec"].Value));
                winProviderForm.MdiParent = this.MdiParent;
                winProviderForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Debe elegir un cliente para poder editarlo.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtProviderName_TextChanged(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void txtProviderId_TextChanged(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            returnCustomer();
        }

        private void dgvProviders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CALLerForm == "ProviderOrder")
            {
                returnCustomer();
            }
            else
            {
                if (dgvProviders.SelectedRows.Count > 0)
                {
                    frmProviderForm winProviderForm = new frmProviderForm(Convert.ToInt32(dgvProviders.SelectedRows[0].Cells["clmCodsec"].Value));
                    winProviderForm.MdiParent = this.MdiParent;
                    winProviderForm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Debe elegir un cliente para poder editarlo.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

    }
}