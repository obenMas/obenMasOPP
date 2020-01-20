using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Threading;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPaperList : Form
    {
        public frmPaperList()
        {
            InitializeComponent();
        }

        public void populateDataGrid()
        {
            List<clsPaper> lstPaper = new List<clsPaper>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvPaper.Rows.Clear();
            if (chkCustomerFilter.Checked || chkNumberFilter.Checked || chkStatusFilter.Checked)
            {
                if (chkCustomerFilter.Checked && cmbCustomer.SelectedIndex > -1)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "pap_fkCustomer";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbCustomer.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (chkStatusFilter.Checked && txtCoil.Text != string.Empty)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "pap_code";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = txtCoil.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkNumberFilter.Checked && txtNumberFrom.Text != "")
                {
                    if (txtNumberFrom.Text != "")
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "pap_memo";
                        lstFilter[lstFilter.Count - 1].operation = "contains";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
                    }
                }

                lstPaper = clsPaper.getListByFilter(lstFilter);
            }
            else
                lstPaper = clsPaper.getList();

            for (int i = 0; i < lstPaper.Count; i++)
            {
                dgvPaper.Rows.Add();
                dgvPaper.Rows[i].Cells["clmCodsec"].Value = lstPaper[i].codsec.ToString();
                dgvPaper.Rows[i].Cells["clmDate"].Value = lstPaper[i].createdDate.ToString();
                dgvPaper.Rows[i].Cells["clmNumber"].Value = lstPaper[i].memo.ToString();
                dgvPaper.Rows[i].Cells["clmCustomer"].Value = lstPaper[i].Customer.companyName.ToString();
                dgvPaper.Rows[i].Cells["clmCoil"].Value = lstPaper[i].code.ToString();
                dgvPaper.Rows[i].Cells[clmPrint.Index].Value = global::BPS.Properties.Resources.printer;
                dgvPaper.Rows[i].Cells[clmEdit.Index].Value = global::BPS.Properties.Resources.pencil;
            }
        }

        private void frmPaperList_Load(object sender, EventArgs e)
        {
            populateDataGrid();
            populateEntities();
        }

        private void populateEntities()
        {
            List<clsEntity> lstEntity = clsEntity.getCustomerList();
            cmbCustomer.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
                cmbCustomer.Items.Add(lstEntity[i]);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            populateDataGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            chkNumberFilter.Checked = false;
            chkStatusFilter.Checked = false;
            chkCustomerFilter.Checked = false;
            txtNumberFrom.Text = "";
            cmbCustomer.SelectedIndex = -1;
            populateDataGrid();
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
            frmPaperCoil winSalesOrderForm = new frmPaperCoil();
            winSalesOrderForm.MdiParent = this.MdiParent;
            winSalesOrderForm.Show();
            this.Close();
        }

        private void dgvPaper_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmPrint.Index)
            {
                if (MessageBox.Show("Desea imprimir la etiqueta de la Bobina seleccionada?", "Etiqueta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPaperLabel(Convert.ToInt32(dgvPaper.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)); });
                    thrdPrint.Start();
                }
            }
            else if (e.ColumnIndex == clmEdit.Index)
            {
                frmPaperCoil winSalesOrder = new frmPaperCoil(Convert.ToInt32(dgvPaper.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                winSalesOrder.StartPosition = FormStartPosition.Manual;
                winSalesOrder.MdiParent = this.MdiParent;
                winSalesOrder.Show();
            }
        }

        private void txtCoil_TextChanged(object sender, EventArgs e)
        {
            if (txtCoil.Text != string.Empty)
                populateDataGrid();
        }

        private void txtCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCoil.Text != string.Empty)
                populateDataGrid();
        }
    }
}
