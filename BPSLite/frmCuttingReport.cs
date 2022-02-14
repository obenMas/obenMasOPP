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
    public partial class frmCuttingReport : Form
    {
        public frmCuttingReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for(int i=0;i<list.Count;i++)
            {
                cmbPlant.Items.Add(list[i].name);
            }
        }

        private void btnGenerateCuttingRp_Click(object sender, EventArgs e)
        {
            
                DataSet DS = new DataSet();
                string texto;

            
            if (cmbPlant.SelectedIndex==-1)
                {
                    texto = "CALL spCuttingReport '" + dateTPFromCutting.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToCutting.Value.ToString("dd/MM/yyyy") + "';";
                
            }
                else
                {
                    texto = "CALL spCuttingReportByPlant ('" + dateTPFromCutting.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToCutting.Value.ToString("dd/MM/yyyy") + "' , " + new clsPlant(cmbPlant.Items[cmbPlant.SelectedIndex].ToString()).codsec.ToString() + ");";
                    
               

            }
           
            DS = clsConnection.getDataSetResult(texto);
            
            dataGridView1.Rows.Clear();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dataGridView1.Rows.Add();
                    int fila = dataGridView1.Rows.Count - 1;
                    dataGridView1.Rows[fila].Cells[Maquina.Index].Value = DS.Tables[0].Rows[i]["Maquina"].ToString();
                    dataGridView1.Rows[fila].Cells[Bobina.Index].Value = DS.Tables[0].Rows[i]["Bobina"].ToString();
                    dataGridView1.Rows[fila].Cells[Producto.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                    dataGridView1.Rows[fila].Cells[PesoNeto.Index].Value = DS.Tables[0].Rows[i]["PesoNeto"].ToString();
                    dataGridView1.Rows[fila].Cells[Calificacion.Index].Value = DS.Tables[0].Rows[i]["Calificación"].ToString();
                    dataGridView1.Rows[fila].Cells[Tipo.Index].Value = DS.Tables[0].Rows[i]["Tipo"].ToString();
                    dataGridView1.Rows[fila].Cells[Estado.Index].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                    dataGridView1.Rows[fila].Cells[Metraje.Index].Value = DS.Tables[0].Rows[i]["Metraje"].ToString();
                    dataGridView1.Rows[fila].Cells[BobinaMadre.Index].Value = DS.Tables[0].Rows[i]["BobinaMadre"].ToString();
                    dataGridView1.Rows[fila].Cells[Lote.Index].Value = DS.Tables[0].Rows[i]["Lote"].ToString();
                    dataGridView1.Rows[fila].Cells[OrdenCorte.Index].Value = DS.Tables[0].Rows[i]["OrdenCorte"].ToString();
                    dataGridView1.Rows[fila].Cells[Parada.Index].Value = DS.Tables[0].Rows[i]["Parada"].ToString();
                    dataGridView1.Rows[fila].Cells[Cliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dataGridView1.Rows[fila].Cells[OrdenVenta.Index].Value = DS.Tables[0].Rows[i]["OrdenVenta"].ToString();
                    dataGridView1.Rows[fila].Cells[FechaCorte.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaCorte"]).ToString("dd/MM/yyyy HH:mm");
                    dataGridView1.Rows[fila].Cells[Familia.Index].Value = DS.Tables[0].Rows[i]["Familia"].ToString();
                    dataGridView1.Rows[fila].Cells[Observaciones.Index].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                    if (DS.Tables[0].Rows[i]["esimpo"].ToString() == "1")
                    {
                        dataGridView1.Rows[fila].Cells[clmOrg.Index].Value = "IMPORTADO";
                    }
                    else
                    {
                        dataGridView1.Rows[fila].Cells[clmOrg.Index].Value = "LOCAL";
                    }
                    dataGridView1.Rows[fila].Cells[clmDestination.Index].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                    dataGridView1.Rows[fila].Cells[clmProcess.Index].Value = DS.Tables[0].Rows[i]["Reproceso"].ToString();
                    dataGridView1.Rows[fila].Cells[clmUsefulwidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                    dataGridView1.Rows[fila].Cells[clmDetail.Index].Value = DS.Tables[0].Rows[i]["Observación"].ToString();
                }
            }

           
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            List<String> listaFechas = new List<string>();

            for (int i = 0; i < dataGridView1.Rows.Count;i++ )
            {
                listaFechas.Add(dataGridView1.Rows[i].Cells[FechaCorte.Index].Value.ToString());
                dataGridView1.Rows[i].Cells[FechaCorte.Index].Value = Convert.ToDateTime(dataGridView1.Rows[i].Cells[FechaCorte.Index].Value).ToString("dd/MM/yyyy HH:mm");
            }

            string ext = string.Empty;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dataGridView1.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[FechaCorte.Index].Value = Convert.ToDateTime(listaFechas[i].ToString());
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
