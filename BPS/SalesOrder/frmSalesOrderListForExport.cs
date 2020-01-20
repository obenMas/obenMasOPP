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
    public partial class frmSalesOrderListForExport : Form
    {
        public frmSalesOrderListForExport()
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
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    }
                    else
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "sord_number";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";
                    }
                }

                lstSalesOrder = clsSalesOrder.getListByFilter(lstFilter, false);
            }
            else
                lstSalesOrder = clsSalesOrder.getList(false);

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                dgvSalesOrder.Rows.Add();
                dgvSalesOrder.Rows[i].Cells["clmCodsec"].Value = lstSalesOrder[i].codsec.ToString();
                dgvSalesOrder.Rows[i].Cells["clmDate"].Value = lstSalesOrder[i].createdDate.ToString();
                dgvSalesOrder.Rows[i].Cells["clmNumber"].Value = lstSalesOrder[i].number.ToString();
                dgvSalesOrder.Rows[i].Cells["clmCustomerId"].Value = lstSalesOrder[i].EntityID.ToString();
                dgvSalesOrder.Rows[i].Cells["clmCustomer"].Value = lstSalesOrder[i].EntityName.ToString();
                dgvSalesOrder.Rows[i].Cells["clmStatus"].Value = lstSalesOrder[i].StatusName.ToString();
                if(lstSalesOrder[i].exportedToERP == 1)
                    dgvSalesOrder.Rows[i].Cells[clmExportedToERPSalesOrder.Index].Value = global::BPS.Properties.Resources.bullet_green;
                else if (lstSalesOrder[i].exportedToERP == 2)
                    dgvSalesOrder.Rows[i].Cells[clmExportedToERPSalesOrder.Index].Value = global::BPS.Properties.Resources.bullet_orange;
                else
                    dgvSalesOrder.Rows[i].Cells[clmExportedToERPSalesOrder.Index].Value = global::BPS.Properties.Resources.bullet_red;

                dgvSalesOrder.Rows[i].Cells[clmCheckToExport.Index].Value = global::BPS.Properties.Resources.clear;
                dgvSalesOrder.Rows[i].Cells[clmFlgToExport.Index].Value = 0;
            }
            
        }
        private void frmSalesOrderList_Load(object sender, EventArgs e)
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
        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrder.SelectedRows.Count > 0)
            {
                frmSalesOrderForm winSalesOrderForm = new frmSalesOrderForm(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
                winSalesOrderForm.MdiParent = this.MdiParent;
                winSalesOrderForm.Show();
            }
        }

        private void dgvSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCheckToExport.Index)
            {
                if (dgvSalesOrder.Rows[e.RowIndex].Cells[clmFlgToExport.Index].Value.ToString() != "0")
                {
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmCheckToExport.Index].Value = global::BPS.Properties.Resources.clear;
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmFlgToExport.Index].Value = 0;
                }
                else
                {
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmCheckToExport.Index].Value = global::BPS.Properties.Resources.accept;
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmFlgToExport.Index].Value = 1;
                }
            }
        }
        

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsEntity> lstCustomer = clsEntity.getCustomerList();
                cmbCustomer.Items.Clear();
                for (int i = 0; i < lstCustomer.Count; i++)
                    cmbCustomer.Items.Add(lstCustomer[i]);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            bool hasSelectedRows = false;
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (dgvSalesOrder.Rows[i].Cells[clmFlgToExport.Index].Value.ToString() == "1")
                    hasSelectedRows = true;
            }
            if (hasSelectedRows == true)
            {

                if (MessageBox.Show("Se realizará el proceso de creación de los archivos de exportación a SIIGO de las ordenes de venta seleccionadas.\n\n Desea continuar?", "Exportación de ordenes a SIIGO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    string folderPath = "";
                    fbdFilePath.Description = "Por favor, seleccione la ubicación donde se guardarán los archivos de exportación.";
                    fbdFilePath.ShowDialog();

                    folderPath = fbdFilePath.SelectedPath;
                    lstSalesOrder = new List<clsSalesOrder>();

                    for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                    {
                        if (dgvSalesOrder.Rows[i].Cells[clmFlgToExport.Index].Value.ToString() == "1")
                            lstSalesOrder.Add(new clsSalesOrder(Convert.ToInt32(dgvSalesOrder.Rows[i].Cells[clmCodsec.Index].Value)));
                    }

                    if (clsXportSalesOrderToSIIGO.exportSalesOrderToSiigo(lstSalesOrder, folderPath, false))
                    {
                        MessageBox.Show("Se han generado los archivos para la exportación de las ordenes de venta al SIIGO con éxito.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        populateDataGrid();
                    }
                    else
                        MessageBox.Show("Ha habido un problema al generar los archivos de exportación, por favor comuníquese con el administrador.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna orden de venta para ser exportada.", "Exportación de ordenes a SIIGO", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
    }
}