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
    public partial class frmScrapPalletSwapReport : Form
    {
        public frmScrapPalletSwapReport()
        {
            InitializeComponent();
            fillPlantsCmb();
        }
        #region Cargo el DGV con el Boton Generar
        private void btnGenerateSwapRp_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            string texto;

            if (cmbPlant.SelectedIndex == -1)
            {
                texto = "CALL spScrapSwapPalletByDate ( '" + dateTPFromSwap.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToSwap.Value.ToString("dd/MM/yyyy") + "';";
            }
            else
            {
                texto = "CALL spScrapSwapPalletByDateByPlant ('" + dateTPFromSwap.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToSwap.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlant.Items[cmbPlant.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(texto);

            dgvScrapPalletReport.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvScrapPalletReport.Rows.Add();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmCodigoScrapPallet.Index].Value = DS.Tables[0].Rows[i]["CodScrapPallet"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmCodigoScrap.Index].Value = DS.Tables[0].Rows[i]["CodScrap"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmNombreScrap.Index].Value = DS.Tables[0].Rows[i]["NomScrap"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmPeso.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["netWeigth"]);
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmTipoMov.Index].Value = DS.Tables[0].Rows[i]["TipoMov"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmBodOrg.Index].Value = DS.Tables[0].Rows[i]["BodOrg"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmBodDest.Index].Value = DS.Tables[0].Rows[i]["BodDest"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy HH:mm");
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmUsuario.Index].Value = DS.Tables[0].Rows[i]["UserName"].ToString();
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvScrapPalletReport.Rows[dgvScrapPalletReport.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
        }

        #endregion

        #region Exportar a Excel
        private void btnExport_Click(object sender, EventArgs e)
        {

            string ext = string.Empty;
            dgvScrapPalletReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvScrapPalletReport.Columns["clmDay"].Visible = true;
            dgvScrapPalletReport.Columns["clmMonth"].Visible = true;
            dgvScrapPalletReport.Columns["clmYear"].Visible = true;
            dgvScrapPalletReport.Columns["clmDate"].Visible = false;

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
                dgvScrapPalletReport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvScrapPalletReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }
        private void copyAlltoClipboard()
        {
            dgvScrapPalletReport.SelectAll();
            DataObject dataObj = dgvScrapPalletReport.GetClipboardContent();
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

        public void fillPlantsCmb()
        {
            List<clsPlant> list = clsPlant.getList();

            for (int i = 0; i < list.Count; i++)
            {
                cmbPlant.Items.Add(list[i].name);
            }
        }
        #endregion
    }
}
