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
    public partial class frmMaterialStatusReport : Form
    {
        public frmMaterialStatusReport(string name)
        {
            InitializeComponent();
            populateDataGrid(name);
            label2.Text = name;
        }

        private void populateDataGrid(string name)
        {
            DataSet DS = clsConnection.getDataSetResult("CALL spSalesOrderControlCompanyName ('"+name+"')");

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPedido.Index].Value = DS.Tables[0].Rows[i]["Pedido"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmOC.Index].Value = DS.Tables[0].Rows[i]["OCCliente"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmDiametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCore.Index].Value = DS.Tables[0].Rows[i]["Core"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantSol.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSolicitada"]),2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantProg.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadProgramada"]),2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantSinPal.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadSinPaletizar"])+ Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaNoDisponible"]),2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantDep.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPaletizadaDisponible"]),2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantPredesp.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadPredespachada"]),2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantDesp.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["CantidadEntregada"]), 2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmCantPend.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PendienteEntrega"]), 2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmPrecio.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Precio"]),2).ToString("0.00");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmFechaIng.Index].Value = DS.Tables[0].Rows[i]["FechaIngreso"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmFechaSol.Index].Value = DS.Tables[0].Rows[i]["FechaSolicitada"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmFechaEnt.Index].Value = DS.Tables[0].Rows[i]["FechaEntrega"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmObservaciones.Index].Value = DS.Tables[0].Rows[i]["Observaciones"];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
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
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
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
