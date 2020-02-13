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
    public partial class frmRawMaterialEntryReport : Form
    {
        public frmRawMaterialEntryReport()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void btnGenerateEntryReport_Click(object sender, EventArgs e)
        {
            populateDGV();
        }

        #region Generar el DGV
        private void populateDGV()
        {
            DataSet DS = new DataSet();
            clsPlant planta = new clsPlant();

            dgvEntryReport.Rows.Clear();

            if (cmbPlant.SelectedIndex == -1)
            {
                DS = clsConnection.getDataSetResult("CALL spRawMatEntryByDate('" + dateTPFromEntry.Value.ToString("dd/MM/yyyy") + "','" + dateTPToEntry.Value.ToString("dd/MM/yyyy") + "')");
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spRawMatEntryByDateByPlant('" + dateTPFromEntry.Value.ToString("dd/MM/yyyy") + "','" + dateTPToEntry.Value.ToString("dd/MM/yyyy") + "'," + (new clsPlant(cmbPlant.SelectedItem.ToString())).codsec + ")");
            }

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvEntryReport.Rows.Add();
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmCodigoMP.Index].Value = DS.Tables[0].Rows[i]["codigo"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmNomMP.Index].Value = DS.Tables[0].Rows[i]["nomMP"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["Lote"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmPesoMP.Index].Value = DS.Tables[0].Rows[i]["peso"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["planta"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmUsuario.Index].Value = DS.Tables[0].Rows[i]["usuario"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmFecha.Index].Value = DS.Tables[0].Rows[i]["Fecha"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvEntryReport.Rows[dgvEntryReport.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["hora"];
                }
            }
            dgvEntryReport.Sort(dgvEntryReport.Columns[clmFecha.Index], ListSortDirection.Descending);
        }
        #endregion

        #region Cargar Combos
        private void cargarCombos()
        {
            List<clsPlant> plant = new List<clsPlant>();

            plant = clsPlant.getList();

            for (int i = 0; i < plant.Count; i++)
            {
                cmbPlant.Items.Add(plant[i].name);
            }
        }
        #endregion

        #region Exportar a Excel

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvEntryReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvEntryReport.Columns[clmFecha.Index].Visible = false;
            dgvEntryReport.Columns[clmDay.Index].Visible = true;
            dgvEntryReport.Columns[clmMonth.Index].Visible = true;
            dgvEntryReport.Columns[clmYear.Index].Visible = true;
            dgvEntryReport.Columns[clmHour.Index].Visible = true;

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
                dgvEntryReport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvEntryReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dgvEntryReport.Columns[clmFecha.Index].Visible = true;
            dgvEntryReport.Columns[clmDay.Index].Visible = false;
            dgvEntryReport.Columns[clmMonth.Index].Visible = false;
            dgvEntryReport.Columns[clmYear.Index].Visible = false;
            dgvEntryReport.Columns[clmHour.Index].Visible = false;
          
        }
        private void copyAlltoClipboard()
        {
            dgvEntryReport.SelectAll();
            DataObject dataObj = dgvEntryReport.GetClipboardContent();
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
