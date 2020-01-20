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
    public partial class frmPreShippingDetail : Form
    {
        clsNewPreShipping pd = new clsNewPreShipping();
        DataSet DS = new DataSet();

        public frmPreShippingDetail()
        {
            InitializeComponent();
        }

        #region Cargar Dgv

        private void txtPDInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPDInput.Text != string.Empty)
                {

                    pd = new clsNewPreShipping(txtPDInput.Text);
                    string query = "CALL spPreshippingDetailByCode(" + pd.codsec + ")";
                    DS = clsConnection.getDataSetResult(query);

                    dgvPDetail.Rows.Clear();

                    if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
	                {
                        for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
			            {       
                            dgvPDetail.Rows.Add();
                            dgvPDetail.Rows[dgvPDetail.Rows.Count - 1].Cells[clmPallet.Index].Value = DS.Tables[0].Rows[i]["pltCode"].ToString();
                            dgvPDetail.Rows[dgvPDetail.Rows.Count - 1].Cells[clmCoil.Index].Value = DS.Tables[0].Rows[i]["codBob"].ToString();
                            dgvPDetail.Rows[dgvPDetail.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["lote"].ToString();
                            dgvPDetail.Rows[dgvPDetail.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["Prod"].ToString();
                            dgvPDetail.Rows[dgvPDetail.Rows.Count - 1].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["planta"].ToString();
                            dgvPDetail.Rows[dgvPDetail.Rows.Count - 1].Cells[clmRemito.Index].Value = pd.Rnumber;
                        }
                    }                   
                }
                else
                {
                    MessageBox.Show("Por favor complete el codigo de Pre-Despacho","Advertencia", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }   
            }
        }

        #endregion

        #region Exportar a Excel

        private void btnExcel_Click(object sender, EventArgs e)
        {
           
            dgvPDetail.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgvPDetail.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

        }

        private void copyAlltoClipboard()
        {
            dgvPDetail.SelectAll();
            DataObject dataObj = dgvPDetail.GetClipboardContent();
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
