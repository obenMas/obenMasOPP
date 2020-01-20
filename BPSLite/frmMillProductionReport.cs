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
    public partial class frmMillProductionReport : Form
    {
        public frmMillProductionReport()
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
            double pesosTot = 0;
            DataSet DS = new DataSet();
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spMillProductionByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spMillProductionByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvMillProduction.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0 && DS.Tables.Count > 0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dgvMillProduction.Rows.Add();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmTipo.Index].Value = DS.Tables[0].Rows[i]["TipoRawMat"].ToString();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["pesoRaw"].ToString();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmTorta.Index].Value = DS.Tables[0].Rows[i]["pesoTorta"].ToString();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmUsuario.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvMillProduction.Rows[dgvMillProduction.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"].ToString());
                }
            }

            dgvMillProduction.Sort(dgvMillProduction.Columns[clmFecha.Index], ListSortDirection.Descending);

            foreach (DataGridViewRow row in dgvMillProduction.Rows)
            {
                pesosTot = pesosTot + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesosTot);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvMillProduction.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvMillProduction.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvMillProduction.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }
        private void copyAlltoClipboard()
        {
            dgvMillProduction.SelectAll();
            DataObject dataObj = dgvMillProduction.GetClipboardContent();
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
