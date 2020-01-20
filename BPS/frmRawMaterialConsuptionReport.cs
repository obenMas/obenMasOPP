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
    public partial class frmRawMaterialConsuptionReport : Form
    {
        public frmRawMaterialConsuptionReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        #region Cargar el DGV

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            double pesosTot = 0;
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spRawMaterialConsuptionByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spRawMaterialConsuptionByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvRawMaterialConsuption.Rows.Clear();

            if ((DS.Tables[0].Rows.Count > 0) && (DS.Tables.Count > 0))
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvRawMaterialConsuption.Rows.Add();
                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["EsSilo"]) == 1)
                    {
                        dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmCodigoRaw.Index].Value = DS.Tables[0].Rows[i]["NomBodega"].ToString();
                    }
                    else
                    {
                         dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmCodigoRaw.Index].Value = DS.Tables[0].Rows[i]["codigoRawPallet"].ToString();
                    }
                   
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmCodigoRawMat.Index].Value = DS.Tables[0].Rows[i]["codigoRaw"].ToString();
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmTipoRawMat.Index].Value = DS.Tables[0].Rows[i]["nomRawMat"].ToString();
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["consumoRaw"].ToString();
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmUser.Index].Value = DS.Tables[0].Rows[i]["usuario"].ToString();
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["Lote"].ToString();
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"].ToString());
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Fecha"];
                    dgvRawMaterialConsuption.Rows[dgvRawMaterialConsuption.Rows.Count - 1].Cells[clmLoteExtrusion.Index].Value = DS.Tables[0].Rows[i]["loteExtrusion"];
                }
            }
            foreach (DataGridViewRow row in dgvRawMaterialConsuption.Rows)
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

            dgvRawMaterialConsuption.Columns["clmFecha"].Visible = false;
            dgvRawMaterialConsuption.Columns["clmDay"].Visible = true;
            dgvRawMaterialConsuption.Columns["clmMonth"].Visible = true;
            dgvRawMaterialConsuption.Columns["clmYear"].Visible = true;
            dgvRawMaterialConsuption.Columns["clmHour"].Visible = true;

            dgvRawMaterialConsuption.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvRawMaterialConsuption.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvRawMaterialConsuption.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvRawMaterialConsuption.Columns["clmFecha"].Visible = true;
            dgvRawMaterialConsuption.Columns["clmDay"].Visible = false;
            dgvRawMaterialConsuption.Columns["clmMonth"].Visible = false;
            dgvRawMaterialConsuption.Columns["clmYear"].Visible = false;
            dgvRawMaterialConsuption.Columns["clmHour"].Visible = false;

        }

        private void copyAlltoClipboard()
        {
            dgvRawMaterialConsuption.SelectAll();
            DataObject dataObj = dgvRawMaterialConsuption.GetClipboardContent();
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
