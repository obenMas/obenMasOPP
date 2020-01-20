using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;  //Supongo, que importa algo para exportar a excel.
using System.IO;

namespace BPS.Lite
{
    public partial class frmRawMaterialDispatchReport : Form
    {
        public frmRawMaterialDispatchReport()
        {
            InitializeComponent();
            cargarCombos();
        }


        #region Cargar Combos
        private void cargarCombos()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbPlant.Items.Add(lstPlant[i].name);
            }
        }
        #endregion

        #region Cargar DGV
        private void btnGenerateSwapRp_Click(object sender, EventArgs e)
        {

            dgvDispatch.Rows.Clear();

            DataSet DS = new DataSet();

            if (cmbPlant.SelectedIndex == -1)
            {
                DS = clsConnection.getDataSetResult("CALL spRawDispatchForSale('" + dateTPFromSwap.Value.ToString("dd/MM/yyyy") + "','" + dateTPToSwap.Value.ToString("dd/MM/yyyy") + "')");
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spRawDispatchForSaleByPlant('" + dateTPFromSwap.Value.ToString("dd/MM/yyyy") + "','" + dateTPToSwap.Value.ToString("dd/MM/yyyy") + "'," + (new clsPlant(cmbPlant.SelectedItem.ToString())).codsec + ")");
            }

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvDispatch.Rows.Add();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["CodPallet"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmNomMat.Index].Value = DS.Tables[0].Rows[i]["nomMat"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = DS.Tables[0].Rows[i]["peso"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["lote"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmUser.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmBodOrg.Index].Value = DS.Tables[0].Rows[i]["bodegaOrigen"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmDate.Index].Value = DS.Tables[0].Rows[i]["Fecha"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmdayFecha.Index].Value = DS.Tables[0].Rows[i]["dayFecha"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmmonthFecha.Index].Value = DS.Tables[0].Rows[i]["monthFecha"].ToString();
                    dgvDispatch.Rows[dgvDispatch.Rows.Count - 1].Cells[clmyearFecha.Index].Value = DS.Tables[0].Rows[i]["yearFecha"].ToString();
                }
            }
            dgvDispatch.Sort(dgvDispatch.Columns[clmDate.Index], ListSortDirection.Descending);
        }
        #endregion

        #region Exportar a Excel.
        private void btnExport_Click(object sender, EventArgs e)
        {
           
            // supongo que aca pongo las columnas que voy a exportar al excel.
            string ext = string.Empty;
            dgvDispatch.Columns[clmDate.Index].Visible = false;
            dgvDispatch.Columns[clmdayFecha.Index].Visible = true;
            dgvDispatch.Columns[clmmonthFecha.Index].Visible = true;
            dgvDispatch.Columns[clmyearFecha.Index].Visible = true;
            dgvDispatch.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            //Genero el save y en que formato se va a poder grabar (supongo)
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
                dgvDispatch.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            dgvDispatch.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvDispatch.Columns[clmDate.Index].Visible = true;
            dgvDispatch.Columns[clmdayFecha.Index].Visible = false;
            dgvDispatch.Columns[clmmonthFecha.Index].Visible = false;
            dgvDispatch.Columns[clmyearFecha.Index].Visible = false;
        }

        private void copyAlltoClipboard()
        {
            dgvDispatch.SelectAll();
            DataObject dataObj = dgvDispatch.GetClipboardContent();
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
