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
    public partial class frmRawMaterialMovementsReport : Form
    {
        public frmRawMaterialMovementsReport()
        {
            InitializeComponent();

            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
            
        }

        #region Generar Reporte Movimiento

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            double pesosTot = 0;
            DataSet DS = new DataSet();
            string queryString;

            if (cmbPlanta.SelectedIndex == -1)
            {
                queryString = "CALL spRawMaterialMovementsByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "';";
            }
            else
            {
                queryString = "CALL spRawMaterialMovementsByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "'," + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(queryString);

            dgvRawMaterialMovements.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvRawMaterialMovements.Rows.Add();
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmTipoRawMat.Index].Value = DS.Tables[0].Rows[i]["nomRawMat"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmtype.Index].Value = DS.Tables[0].Rows[i]["tipoMov"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmCodMP.Index].Value = DS.Tables[0].Rows[i]["CodMP"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmCodigoRaw.Index].Value = DS.Tables[0].Rows[i]["codigoRaw"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["pesoRaw"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = DS.Tables[0].Rows[i]["bodegaOrigen"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = DS.Tables[0].Rows[i]["BodegaDestino"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmUser.Index].Value = DS.Tables[0].Rows[i]["usuario"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmFecha.Index].Value = DS.Tables[0].Rows[i]["Fecha"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvRawMaterialMovements.Rows[dgvRawMaterialMovements.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }

            foreach (DataGridViewRow row in dgvRawMaterialMovements.Rows)
            {
                pesosTot = pesosTot + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesosTot);
            }
        }

        #endregion

        #region Exportar a Excel

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

            dgvRawMaterialMovements.Columns["clmDay"].Visible = true;
            dgvRawMaterialMovements.Columns["clmMonth"].Visible = true;
            dgvRawMaterialMovements.Columns["clmYear"].Visible = true;
            dgvRawMaterialMovements.Columns["clmHour"].Visible = true;
            dgvRawMaterialMovements.Columns["clmFecha"].Visible = false;

            dgvRawMaterialMovements.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvRawMaterialMovements.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvRawMaterialMovements.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvRawMaterialMovements.Columns["clmDay"].Visible = false;
            dgvRawMaterialMovements.Columns["clmMonth"].Visible = false;
            dgvRawMaterialMovements.Columns["clmYear"].Visible = false;
            dgvRawMaterialMovements.Columns["clmHour"].Visible = false;
            dgvRawMaterialMovements.Columns["clmFecha"].Visible = true;
        }

        private void copyAlltoClipboard()
        {
            dgvRawMaterialMovements.SelectAll();
            DataObject dataObj = dgvRawMaterialMovements.GetClipboardContent();
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
