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

namespace BPS
{
    public partial class frmReportGenerator : Form
    {
        public frmReportGenerator()
        {
            InitializeComponent();
        }

        #region Populate Dgv

        private void btnGenerateCuttingRp_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spSalesOrderInByDate('" + dateTPFromCutting.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToCutting.Value.ToString("dd/MM/yyyy")+"')");

            dgvReportGenerator.Rows.Clear();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dgvReportGenerator.Rows.Add();
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaIngreso"]).ToString ("dd/MM/yyyy");
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[Cliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[Familia.Index].Value = DS.Tables[0].Rows[i]["Familia"].ToString();
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[UDN.Index].Value = DS.Tables[0].Rows[i]["UnidadDeNegocio"].ToString();
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[Cantidad.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Cantidad"]),1);
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFechaIngreso"];
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFechaIngreso"];
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFechaIngreso"];
                    dgvReportGenerator.Rows[dgvReportGenerator.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
        }

        #endregion

        #region Exportar a Excel

        private void button1_Click(object sender, EventArgs e)
        {
                
            string ext = string.Empty;
            dgvReportGenerator.Columns["clmDay"].Visible = true;
            dgvReportGenerator.Columns["clmMonth"].Visible = true;
            dgvReportGenerator.Columns["clmYear"].Visible = true;
            dgvReportGenerator.Columns["Fecha"].Visible = false;
            dgvReportGenerator.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvReportGenerator.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvReportGenerator.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvReportGenerator.Columns["clmDay"].Visible = false;
            dgvReportGenerator.Columns["clmMonth"].Visible = false;
            dgvReportGenerator.Columns["clmYear"].Visible = false;
            dgvReportGenerator.Columns["Fecha"].Visible = true;
        }

        private void copyAlltoClipboard()
        {
            dgvReportGenerator.SelectAll();
            DataObject dataObj = dgvReportGenerator.GetClipboardContent();
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
        #endregion

    }
}
