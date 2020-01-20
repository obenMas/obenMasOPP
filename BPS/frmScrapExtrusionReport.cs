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
    public partial class frmScrapExtrusionReport : Form
    {
        public frmScrapExtrusionReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        private void btnGenerateCuttingRp_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            double pesosTot = 0;
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spExtrusionReportByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spExtrusionReportByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvScrapExtrusion.Rows.Clear();

            if ((DS.Tables[0].Rows.Count > 0) && (DS.Tables.Count > 0))
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvScrapExtrusion.Rows.Add();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmTipo.Index].Value = DS.Tables[0].Rows[i]["tipoMerma"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["Peso"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = DS.Tables[0].Rows[i]["BodegaOrigen"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = DS.Tables[0].Rows[i]["BodegaDestino"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"].ToString());
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmUsuario.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFeha"];
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvScrapExtrusion.Rows[dgvScrapExtrusion.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
            foreach (DataGridViewRow row in dgvScrapExtrusion.Rows)
            {
                pesosTot = pesosTot + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesosTot);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

            dgvScrapExtrusion.Columns["clmDay"].Visible = true;
            dgvScrapExtrusion.Columns["clmMonth"].Visible = true;
            dgvScrapExtrusion.Columns["clmYear"].Visible = true;
            dgvScrapExtrusion.Columns["clmHour"].Visible = true;
            dgvScrapExtrusion.Columns["clmFecha"].Visible = false;

            dgvScrapExtrusion.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvScrapExtrusion.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvScrapExtrusion.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvScrapExtrusion.Columns["clmDay"].Visible = false;
            dgvScrapExtrusion.Columns["clmMonth"].Visible = false;
            dgvScrapExtrusion.Columns["clmYear"].Visible = false;
            dgvScrapExtrusion.Columns["clmHour"].Visible = false;
            dgvScrapExtrusion.Columns["clmFecha"].Visible = true;

        }

        private void copyAlltoClipboard()
        {
            dgvScrapExtrusion.SelectAll();
            DataObject dataObj = dgvScrapExtrusion.GetClipboardContent();
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
