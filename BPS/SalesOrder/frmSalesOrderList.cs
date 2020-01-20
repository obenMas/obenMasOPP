using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;
using BPS.Reporting.SalesOrder.National;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS
{
    public partial class frmSalesOrderList : Form
    {
        public frmSalesOrderList()
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
                    if (txtNumberFrom.Text != "")
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "sord_number";
                        lstFilter[lstFilter.Count - 1].operation = "contains";
                        lstFilter[lstFilter.Count - 1].value = txtNumberFrom.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "int";
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
                dgvSalesOrder.Rows[i].Cells[clmEditSalesOrder.Index].Value = global::BPS.Properties.Resources.pencil;
                dgvSalesOrder.Rows[i].Cells[clmReportPrice.Index].Value = global::BPS.Properties.Resources.reportOff;
                dgvSalesOrder.Rows[i].Cells[clmReport.Index].Value = global::BPS.Properties.Resources.reportOff;
                dgvSalesOrder.Rows[i].Cells[clmreportmedium.Index].Value = global::BPS.Properties.Resources.report;
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
            frmSalesOrderForm winSalesOrderForm = new frmSalesOrderForm();
            winSalesOrderForm.MdiParent = this.MdiParent;
            winSalesOrderForm.Show();
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
            if (e.ColumnIndex == clmEditSalesOrder.Index)
            {
                frmSalesOrderForm winSalesOrderForm = new frmSalesOrderForm(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
                winSalesOrderForm.StartPosition = FormStartPosition.CenterScreen;
                winSalesOrderForm.MdiParent = this.MdiParent;
                winSalesOrderForm.Show();
                populateDataGrid();
            }
            //if (e.ColumnIndex == clmReportPrice.Index)
            //{
            //    frmSalesOrderReports winSalesOrder = new frmSalesOrderReports(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));
            //    winSalesOrder.StartPosition = FormStartPosition.Manual;
            //    winSalesOrder.MdiParent = this.MdiParent;
            //    winSalesOrder.Show();
            //}
            if (e.ColumnIndex == clmReport.Index)
            {
                frmSalesOrderReport winSalesOrderReport = new frmSalesOrderReport(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), clsGlobal.password);
                winSalesOrderReport.StartPosition = FormStartPosition.Manual;
                winSalesOrderReport.MdiParent = this.MdiParent;
                winSalesOrderReport.Show();
            }

            if (e.ColumnIndex == clmreportmedium.Index)
            {
                frmSalesorderreportII winsalesorder = new frmSalesorderreportII(Convert.ToInt32(dgvSalesOrder.Rows[e.RowIndex].Cells[clmCodsec.Index].Value), clsGlobal.password);
                winsalesorder.StartPosition = FormStartPosition.Manual;
                winsalesorder.MdiParent = this.MdiParent;
                winsalesorder.Show();
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrder.SelectedRows.Count > 0)
            {
                frmSalesOrderDetail winSalesOrderDetail = new frmSalesOrderDetail(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsec.Index].Value));
                winSalesOrderDetail.MdiParent = this.MdiParent;
                winSalesOrderDetail.Show();
                this.Close();
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

        private void txtNumberFrom_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberFrom.Focus())
                populateDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ext = string.Empty;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboard();

                object misValue = System.Reflection.Missing.Value;
                Excel.Application xlexcel = new Excel.Application();

                xlexcel.DisplayAlerts = false; // Without this you will get two confirm overwrite prompts
                Excel.Workbook xlWorkBook = xlexcel.Workbooks.Add(misValue);
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                // Paste clipboard results to worksheet range
                Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                CR.Select();
                xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                // For some reason column A is always blank in the worksheet.
                // Delete blank column A and select cell A1
                Excel.Range delRng = xlWorkSheet.get_Range("A:A").Cells;
                delRng.Delete(Type.Missing);
                xlWorkSheet.get_Range("A1").Select();

                // Save the excel file under the captured location from the SaveFileDialog
                xlWorkBook.SaveAs(sfd.FileName, Excel.XlFileFormat.xlWorkbookDefault, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
                xlexcel.DisplayAlerts = true;
                xlWorkBook.Close(true, misValue, misValue);
                xlexcel.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgvSalesOrder.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            
            
            /* try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Listado de OV";

                for (int i = 2; i < dgvSalesOrder.Columns.Count + 1; i++)
                    worksheet.Cells[1, i-1] = dgvSalesOrder.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvSalesOrder.Columns.Count-4; j++)
                    {
                        if (dgvSalesOrder.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j] = dgvSalesOrder.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente... Por favor revisar el EXCEL", "MP en deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pallets MP deposito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/



        }



        private void copyAlltoClipboard()
        {
            dgvSalesOrder.SelectAll();
            DataObject dataObj = dgvSalesOrder.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occurred while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}