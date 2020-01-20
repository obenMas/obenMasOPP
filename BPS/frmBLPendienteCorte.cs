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
    public partial class frmBLPendienteCorte : Form
    {
        public frmBLPendienteCorte()
        {
            InitializeComponent();
            llenardgv();
        }

        private void llenardgv()
        {
            DataSet DS = clsConnection.getDataSetResult("SELECT * FROM vwPendienteDeCorte");

            dgv.Rows.Clear();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count;i++)
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Cliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Pelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Diametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[Core.Index].Value = DS.Tables[0].Rows[i]["Core"];
                    dgv.Rows[dgv.Rows.Count - 1].Cells[PendienteDeCorte.Index].Value = DS.Tables[0].Rows[i]["PendienteDeCorte"];
                }
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // supongo que aca pongo las columnas que voy a exportar al excel.
            string ext = string.Empty;
            
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgv.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            // Esto lo que hace es, luego de exportarlo te oculta las columnas que se exportaron.
            // false = no visible ---- true = se ve la columna
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

        }

        private void copyAlltoClipboard()
        {
            dgv.SelectAll();
            DataObject dataObj = dgv.GetClipboardContent();
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
