using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmVaporesComplete : Form
    {
        clsVapor ObjVapor = new clsVapor();
        int selectedcodsecvapor = 0;
        frmShipping prntShipping;
        List<clsVapor> lstVapor = new List<clsVapor>();
        List<clsShippingBuilding> lstShippingBuilding = new List<clsShippingBuilding>();

        public frmVaporesComplete()
        {
            InitializeComponent();
        }

        public frmVaporesComplete(frmShipping winShipping)
        {
            InitializeComponent();
            this.prntShipping = winShipping;
        }

        private void frmVaporesComplete_Load(object sender, EventArgs e)
        {
            FillDataShippingBuilding();
            FillDataShipping();
            chkEstimateDate.Enabled = true;
            grpbEstimateDate.Enabled = true;
            cmbShippingBuilding.Enabled = false;
            dtpEstimdateDate.Enabled = false;
            chkShippingBuilding.Enabled = true;
            grpbShippingBuilding.Enabled = true;
        }

        private void FillDataShipping()
        {
            lstVapor = clsVapor.getList();
            dgvVapor.Rows.Clear();
            for (int i = 0; i < lstVapor.Count; i++)
            {
                dgvVapor.Rows.Add();
                dgvVapor.Rows[i].Cells[clmcodsec.Index].Value = lstVapor[i].codsec;
                dgvVapor.Rows[i].Cells[clmname.Index].Value = lstVapor[i].shippingbuilding;
                dgvVapor.Rows[i].Cells[clmestimatedate.Index].Value = lstVapor[i].estimatedate.ToString("dd/MM/yyyy");
                dgvVapor.Rows[i].Cells[clmcutoff.Index].Value = lstVapor[i].cuttoff.ToString("dd/MM/yyyy");
            }
        }

        private void FillDataShippingBuilding()
        {
            lstShippingBuilding = clsShippingBuilding.getList();
            cmbShippingBuilding.Items.Clear();
            for (int i = 0; i < lstShippingBuilding.Count; i++)
                cmbShippingBuilding.Items.Add(lstShippingBuilding[i]);
        }

        private void chkShippingBuilding_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShippingBuilding.Checked)
            {
                grpbShippingBuilding.Enabled = true;
                cmbShippingBuilding.Enabled = true;
            }
            else
            {
                cmbShippingBuilding.Enabled = false;
                cmbShippingBuilding.SelectedIndex = -1;
            }
        }

        private void chkEstimateDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstimateDate.Checked)
            {
                grpbEstimateDate.Enabled = true;
                dtpEstimdateDate.Enabled = true;
            }
            else
            {
                dtpEstimdateDate.Enabled = false;
                dtpEstimdateDate.Value = DateTime.Now;
            }
        }

        private void btnVaporFilters_Click(object sender, EventArgs e)
        {
            if (chkShippingBuilding.Checked && !chkEstimateDate.Checked)
                FillDataByFilter(chkShippingBuilding.Checked, chkEstimateDate.Checked);
            else if (chkEstimateDate.Checked && !chkShippingBuilding.Checked)
                FillDataByFilter(chkShippingBuilding.Checked, chkEstimateDate.Checked);
            else if (chkShippingBuilding.Checked && chkEstimateDate.Checked)
                FillDataByFilter(chkShippingBuilding.Checked, chkEstimateDate.Checked);
            else
                FillDataShipping();
        }

        private void FillDataByFilter(bool shippingbuilding, bool estimdatedate)
        {
            if (shippingbuilding && !estimdatedate)
            {
                lstVapor = clsVapor.getListByShppingBuilding(((clsShippingBuilding)cmbShippingBuilding.SelectedItem).codsec);
                dgvVapor.Rows.Clear();
                for (int i = 0; i < lstVapor.Count; i++)
                {
                    dgvVapor.Rows.Add();
                    dgvVapor.Rows[i].Cells[clmcodsec.Index].Value = lstVapor[i].codsec;
                    dgvVapor.Rows[i].Cells[clmname.Index].Value = lstVapor[i].shippingbuilding;
                    dgvVapor.Rows[i].Cells[clmestimatedate.Index].Value = lstVapor[i].estimatedate.ToString("dd/MM/yyyy");
                    dgvVapor.Rows[i].Cells[clmcutoff.Index].Value = lstVapor[i].cuttoff.ToString("dd/MM/yyyy");
                }
            }
            else if (estimdatedate && !shippingbuilding)
            {
                lstVapor = clsVapor.getListByEstimdateDate(dtpEstimdateDate.Value);
                dgvVapor.Rows.Clear();
                for (int i = 0; i < lstVapor.Count; i++)
                {
                    dgvVapor.Rows.Add();
                    dgvVapor.Rows[i].Cells[clmcodsec.Index].Value = lstVapor[i].codsec;
                    dgvVapor.Rows[i].Cells[clmname.Index].Value = lstVapor[i].shippingbuilding;
                    dgvVapor.Rows[i].Cells[clmestimatedate.Index].Value = lstVapor[i].estimatedate.ToString("dd/MM/yyyy");
                    dgvVapor.Rows[i].Cells[clmcutoff.Index].Value = lstVapor[i].cuttoff.ToString("dd/MM/yyyy");
                }
            }
            else if (shippingbuilding && shippingbuilding)
            {
                lstVapor = clsVapor.getListByFilter((((clsShippingBuilding)cmbShippingBuilding.SelectedItem).codsec), dtpEstimdateDate.Value);
                dgvVapor.Rows.Clear();
                for (int i = 0; i < lstVapor.Count; i++)
                {
                    dgvVapor.Rows.Add();
                    dgvVapor.Rows[i].Cells[clmcodsec.Index].Value = lstVapor[i].codsec;
                    dgvVapor.Rows[i].Cells[clmname.Index].Value = lstVapor[i].shippingbuilding;
                    dgvVapor.Rows[i].Cells[clmestimatedate.Index].Value = lstVapor[i].estimatedate.ToString("dd/MM/yyyy");
                    dgvVapor.Rows[i].Cells[clmcutoff.Index].Value = lstVapor[i].cuttoff.ToString("dd/MM/yyyy");
                }
            }
        }

        private void btnVaporClearFilters_Click(object sender, EventArgs e)
        {
            chkEstimateDate.Checked = false;
            chkShippingBuilding.Checked = false;
            FillDataShipping();
        }

        private void dgvVapor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVapor.SelectedRows.Count > 0)
                returnProduct("Vapor");
        }

        private void returnProduct(string data)
        {
            if (data == "Vapor")
            {
                selectedcodsecvapor = Convert.ToInt32(dgvVapor.SelectedRows[0].Cells[clmcodsec.Index].Value);
                prntShipping.selectedcodsecvapor = selectedcodsecvapor;
                this.Close();
            }
        }
    }
}
