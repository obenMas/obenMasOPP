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
    public partial class frmRawMaterialSwapReport : Form
    {
        public frmRawMaterialSwapReport()
        {
            InitializeComponent();
            cargarCombo();
        }

        private void cargarCombo()
        {
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        private void btnGenerateSwapRp_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spRawMaterialSwapByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spRawMaterialSwapByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvSwapInterplantMatPrima.Rows.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvSwapInterplantMatPrima.Rows.Add();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmCodigoPallet.Index].Value = DS.Tables[0].Rows[i]["CodPallet"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmCodigoMP.Index].Value = DS.Tables[0].Rows[i]["CodMatPrima"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmNomMateriaPrima.Index].Value = DS.Tables[0].Rows[i]["NomMatPrima"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["LotPallet"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmTipoMov.Index].Value = DS.Tables[0].Rows[i]["TipoMov"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmPesoNeto.Index].Value = DS.Tables[0].Rows[i]["PesoPallet"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmExtrusionLote.Index].Value = DS.Tables[0].Rows[i]["LotExtrusion"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = DS.Tables[0].Rows[i]["BodOrg"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = DS.Tables[0].Rows[i]["BodDest"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmPalletNotes.Index].Value = DS.Tables[0].Rows[i]["NotaPallet"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmUser.Index].Value = DS.Tables[0].Rows[i]["UserName"].ToString();
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaMov"].ToString());
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFechaMov"];
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFechaMov"];
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFechaMov"];
                    dgvSwapInterplantMatPrima.Rows[dgvSwapInterplantMatPrima.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvSwapInterplantMatPrima.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvSwapInterplantMatPrima.Columns["clmDay"].Visible = true;
            dgvSwapInterplantMatPrima.Columns["clmMonth"].Visible = true;
            dgvSwapInterplantMatPrima.Columns["clmYear"].Visible = true;
            dgvSwapInterplantMatPrima.Columns["clmFecha"].Visible = false;

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
                dgvSwapInterplantMatPrima.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvSwapInterplantMatPrima.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
            dgvSwapInterplantMatPrima.Columns["clmDay"].Visible = false;
            dgvSwapInterplantMatPrima.Columns["clmMonth"].Visible = false;
            dgvSwapInterplantMatPrima.Columns["clmYear"].Visible = false;
            dgvSwapInterplantMatPrima.Columns["clmFecha"].Visible = true;
        }
        private void copyAlltoClipboard()
        {
            dgvSwapInterplantMatPrima.SelectAll();
            DataObject dataObj = dgvSwapInterplantMatPrima.GetClipboardContent();
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
