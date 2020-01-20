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
    public partial class frmScrapPalletReport : Form
    {
        public frmScrapPalletReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            double pesosTot = 0;
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spScrapPalletByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spScrapPalletByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvPalletScrap.Rows.Clear();

            if ((DS.Tables[0].Rows.Count > 0) && (DS.Tables.Count > 0))
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvPalletScrap.Rows.Add();
                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmTipo.Index].Value = DS.Tables[0].Rows[i]["nomScrap"].ToString();
                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["Peso"].ToString();
                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmTurno.Index].Value = DS.Tables[0].Rows[i]["Turno"].ToString();
                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvPalletScrap.Rows[dgvPalletScrap.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"].ToString());
                }
            }
            foreach (DataGridViewRow row in dgvPalletScrap.Rows)
            {
                pesosTot = pesosTot + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesosTot);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvPalletScrap.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvPalletScrap.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvPalletScrap.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvPalletScrap.SelectAll();
            DataObject dataObj = dgvPalletScrap.GetClipboardContent();
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
