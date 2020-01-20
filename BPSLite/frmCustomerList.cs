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
    public partial class frmCustomerList : Form
    {
        frmSalesOrderForm prntSalesOrderForm;
        frmInternationalSalesOrderForm prntInternationalSalesOrderForm;
        //frmInternationalSalesOrderExportToSiigo prntInternationalSalesOrderExport;
        int selectedCustomerCodsec = 0;
        string CALLerForm = "";

        public void populateDataGrid()
        {
            List<clsEntity> lstCustomers = new List<clsEntity>();
            List<clsFilter> lstFilter = new List<clsFilter>();
            if (txtCustomerId.Text != "" || txtCustomerName.Text != "")
            {
                if (txtCustomerId.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "entt_id";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCustomerId.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (txtCustomerName.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "entt_companyName";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCustomerName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstCustomers = clsEntity.getCustomerListByFilter(lstFilter);
            }
            else
                lstCustomers = clsEntity.getCustomerList();

            dgvCustomers.Rows.Clear();

            for (int i = 0; i < lstCustomers.Count; i++)
            {
                dgvCustomers.Rows.Add();
                dgvCustomers.Rows[i].Cells["clmCodsec"].Value = lstCustomers[i].codsec.ToString();
                dgvCustomers.Rows[i].Cells["clmCompany"].Value = lstCustomers[i].companyName.ToString();
                dgvCustomers.Rows[i].Cells["clmName"].Value = lstCustomers[i].contactName.ToString();
                dgvCustomers.Rows[i].Cells["clmCountry"].Value = lstCustomers[i].countryName.ToString();
                dgvCustomers.Rows[i].Cells["clmStatus"].Value = lstCustomers[i].statusName.ToString();
            }
            txtCustomerName.Focus();
        }
        public void returnCustomer()
        {
            switch (CALLerForm)
            {
                case "SalesOrderForm":
                    selectedCustomerCodsec = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value);
                    prntSalesOrderForm.selectedCustomerCodsec = selectedCustomerCodsec;
                    this.Close();
                    break;
                case "InternationalSalesOrderForm":
                    selectedCustomerCodsec = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value);
                    prntInternationalSalesOrderForm.selectedCustomerCodsec = selectedCustomerCodsec;
                    this.Close();
                    break;
                case "InternationalSalesOrderExport":
                    selectedCustomerCodsec = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value);
                    //prntInternationalSalesOrderExport.selectedCustomerCodsec = selectedCustomerCodsec;
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        public frmCustomerList()
        {
            InitializeComponent();
        }
        public frmCustomerList(frmSalesOrderForm winSalesOrderForm)
        {
            InitializeComponent();
            prntSalesOrderForm = winSalesOrderForm;
            btnAdd.Hide();
            txtCustomerName.Focus();
            btnEdit.Hide();
            CALLerForm = "SalesOrderForm";
        }
        public frmCustomerList(frmInternationalSalesOrderForm winInternationalSalesOrderForm)
        {
            InitializeComponent();
            prntInternationalSalesOrderForm = winInternationalSalesOrderForm;
            txtCustomerName.Focus();
            btnAdd.Hide();
            btnEdit.Hide();
            txtCustomerName.Select();
            CALLerForm = "InternationalSalesOrderForm";
        }

        //public frmCustomerList(frmInternationalSalesOrderExportToSiigo winInternationalSalesOrderExport)
        //{
        //    InitializeComponent();
        //    prntInternationalSalesOrderExport = winInternationalSalesOrderExport;
        //    txtCustomerName.Focus();
        //    btnAdd.Hide();
        //    btnEdit.Hide();
        //    txtCustomerName.Select();
        //    CALLerForm = "InternationalSalesOrderExport";
        //}
        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            txtCustomerName.Focus();
            if (this.Modal == true)
                txtCustomerName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCustomerForm winCustomerForm = new frmCustomerForm();
            winCustomerForm.MdiParent = this.MdiParent;
            winCustomerForm.Show();
            this.Close();
        }

        private void dgvCustomers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.Modal == false)
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    frmCustomerForm winCustomerForm = new frmCustomerForm(Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value));
                    winCustomerForm.MdiParent = this.MdiParent;
                    winCustomerForm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Debe elegir un cliente para poder editarlo.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                returnCustomer();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                frmCustomerForm winCustomerForm = new frmCustomerForm(Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value));
                winCustomerForm.MdiParent = this.MdiParent;
                winCustomerForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Debe elegir un cliente para poder editarlo.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceptBopp_Click(object sender, EventArgs e)
        {
            returnCustomer();
        }

        private void txtBoppCode_TextChanged(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void dgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Modal == false)
            {
                if (dgvCustomers.SelectedRows.Count > 0)
                {
                    frmCustomerForm winCustomerForm = new frmCustomerForm(Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value));
                    winCustomerForm.MdiParent = this.MdiParent;
                    winCustomerForm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Debe elegir un cliente para poder editarlo.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                returnCustomer();
        }

        private void txtCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter)
                dgvCustomers.Focus();
        }

        private void dgvCustomers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.Modal == false)
                {
                    if (dgvCustomers.SelectedRows.Count > 0)
                    {
                        frmCustomerForm winCustomerForm = new frmCustomerForm(Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["clmCodsec"].Value));
                        winCustomerForm.MdiParent = this.MdiParent;
                        winCustomerForm.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Debe elegir un cliente para poder editarlo.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                    returnCustomer();
            }
        }
    }
}