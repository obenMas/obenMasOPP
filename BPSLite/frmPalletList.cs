using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS.Lite
{
    public partial class frmPalletList : Form
    {
        List<clsPallet> lstPallets = new List<clsPallet>();
        public int pltok = 0;
        public int pltnotok = 0;
        public string notes = string.Empty;


        public frmPalletList()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            pltok = 0;
            pltnotok = 0;

            TimeSpan tsInit = new TimeSpan(0, 00, 00);
            TimeSpan tsEnd = new TimeSpan(23, 59, 59);

            DateTime initDate = dtpDateFrom.Value.Date + tsInit;
            DateTime endDate = dtpDateTo.Value.Date + tsEnd;

            lstPallets = clsPallet.getListByDate(initDate, endDate);


            dgvPalletList.Rows.Clear();

            for (int i = 0; i < lstPallets.Count; i++)
            {
                dgvPalletList.Rows.Add();

                dgvPalletList.Rows[i].Cells[clmCodsec.Index].Value = lstPallets[i].codsec;
                dgvPalletList.Rows[i].Cells[clmNumber.Index].Value = (i + 1).ToString();
                dgvPalletList.Rows[i].Cells[clmProductCode.Index].Value = lstPallets[i].product.code;
                dgvPalletList.Rows[i].Cells[clmID.Index].Value = lstPallets[i].palletNumber.ToString() + " - " + lstPallets[i].lstCoil.Count.ToString();
                dgvPalletList.Rows[i].Cells[clmSalesOrderNumber.Index].Value = lstPallets[i].salesOrderNumber;// .salesOrderNumber;
                dgvPalletList.Rows[i].Cells[clmWidth.Index].Value = Math.Round(lstPallets[i].product.width, 0);
                dgvPalletList.Rows[i].Cells[clmNetWeight.Index].Value = Math.Round(lstPallets[i].netWeight, 1);
                dgvPalletList.Rows[i].Cells[clmGrossWeight.Index].Value = Math.Round(lstPallets[i].grossWeight, 1);
                dgvPalletList.Rows[i].Cells[clmCustomer.Index].Value = lstPallets[i].customerName;
                dgvPalletList.Rows[i].Cells[clmLot.Index].Value = (lstPallets[i].lstCoil.Count > 0) ? lstPallets[i].lstCoil[0].lotNumber : "";
                dgvPalletList.Rows[i].Cells[clmdiference.Index].Value = lstPallets[i].diference;
                dgvPalletList.Rows[i].Cells[clmPltCreatedDate.Index].Value = Convert.ToDateTime(lstPallets[i].createdDate).ToShortDateString();
                if (lstPallets[i].diference == "HP")
                {
                    pltnotok++;
                    for (int j = 0; j < dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells.Count; j++)
                    {
                        Font fntBold = new Font(dgvPalletList.Font, FontStyle.Bold);
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.Font = fntBold;
                        dgvPalletList.Rows[dgvPalletList.Rows.Count - 1].Cells[j].Style.BackColor = Color.Red;
                    }
                }
            }
            pltok = (lstPallets.Count - pltnotok);
            if (lstPallets.Count > 0)
                SummaryPalletList();
        }

        private void SummaryPalletList()
        {
            lblok.Text = pltok.ToString();
            lblnotok.Text = pltnotok.ToString();
            lblpercentaje.Text = (Math.Abs(((pltnotok * 100) / pltok) - 100)).ToString() + " %";
            if (pltnotok == 0)
                notes = string.Empty;
            else
                notes = "El reporte de pallet no está correctamente generado ya que se encuentran diferencias de peso CORREGIR LOS PESOS";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            lblpercentaje.Visible = true;
            lblok.Visible = true;
            lblnotok.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvPalletList.Rows.Count > 0)
            {
                DateTime initDate;
                DateTime endDate;

                TimeSpan tsInit = new TimeSpan(00, 00, 00);
                TimeSpan tsEnd = new TimeSpan(23, 59, 59);

                initDate = dtpDateFrom.Value.Date + tsInit;
                endDate = dtpDateTo.Value.Date + tsEnd;


                frmPalletListReportView winPalletListReportView = new frmPalletListReportView(initDate, endDate, notes);
                winPalletListReportView.StartPosition = FormStartPosition.Manual;
                winPalletListReportView.MdiParent = this.MdiParent;
                winPalletListReportView.Show();
            }
            else
                MessageBox.Show("No existen Datos para generar el reporte", "Pallet Completos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmPalletList_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            lblpercentaje.Visible = false;
            lblok.Visible = false;
            lblnotok.Visible = false;
        }

        private void dgvPalletList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
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
                dgvPalletList.ClearSelection();

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
                worksheet.Name = "Listado de Pallets Completos";

                for (int i = 1; i < dgvPalletList.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dgvPalletList.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvPalletList.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvPalletList.Columns.Count; j++)
                    {
                        if (dgvPalletList.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j + 1] = dgvPalletList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente... Por favor revisar el EXCEL", "Listado de Pallets Completos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listado de Pallets Completos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }

        private void copyAlltoClipboard()
        {
            dgvPalletList.SelectAll();
            DataObject dataObj = dgvPalletList.GetClipboardContent();
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

