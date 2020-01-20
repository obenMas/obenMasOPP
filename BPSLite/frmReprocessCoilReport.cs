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
    public partial class frmReprocessCoilReport : Form
    {
        DataSet DS = new DataSet();

        public frmReprocessCoilReport()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string codigoBob = string.Empty;
            dgvReprocessCoil.Rows.Clear();

            DS = clsConnection.getDataSetResult("CALL spBobinasReprocesadas('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','" + dtpTo.Value.ToString("dd/MM/yyyy") + "')");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvReprocessCoil.Rows.Add();
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"];
                    if (DS.Tables[0].Rows[i]["codigoBobina"].ToString().StartsWith("7752"))
                    {
                        codigoBob = "B-" + Convert.ToString(DS.Tables[0].Rows[i]["codigoBobina"]);
                        dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmCodBobina.Index].Value = codigoBob;
                    }
                    else
                    {
                        dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmCodBobina.Index].Value = DS.Tables[0].Rows[i]["codigoBobina"];
                    }
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["ancho"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmDiametro.Index].Value = DS.Tables[0].Rows[i]["diametro"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmCore.Index].Value = DS.Tables[0].Rows[i]["core"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmMetrOrg.Index].Value = DS.Tables[0].Rows[i]["metrajeOriginal"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmMetrCons.Index].Value = DS.Tables[0].Rows[i]["metrajeConsumido"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmPesoOrg.Index].Value = DS.Tables[0].Rows[i]["pesoOriginal"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmPesoCons.Index].Value = DS.Tables[0].Rows[i]["pesoConsumido"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmOrden.Index].Value = DS.Tables[0].Rows[i]["ordenDeCorte"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmParada.Index].Value = DS.Tables[0].Rows[i]["parada"];
                    dgvReprocessCoil.Rows[dgvReprocessCoil.Rows.Count - 1].Cells[clmFecha.Index].Value = DS.Tables[0].Rows[i]["fecha"];
                }
            }
        }

        #region Exportar a Excel.

        private void btnExport_Click(object sender, EventArgs e)
        {
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
                dgvReprocessCoil.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            dgvReprocessCoil.SelectAll();
            DataObject dataObj = dgvReprocessCoil.GetClipboardContent();
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
