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
    public partial class frmExtrusionReport : Form
    {
        public frmExtrusionReport()
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

                if(cmbPlant.SelectedIndex==-1)
                {
                    texto = "CALL spMainCoilReportByDate '" + dateTPFromCutting.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToCutting.Value.ToString("dd/MM/yyyy") + "';";
                }
                else
                {
                    texto = "CALL spMainCoilReportByDateAndPlant ('" + dateTPFromCutting.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToCutting.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlant.Items[cmbPlant.SelectedIndex].ToString()).codsec.ToString() + ");";
                }
                
                DS = clsConnection.getDataSetResult(texto);

                dataGridView1.Rows.Clear();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Maquina.Index].Value = DS.Tables[0].Rows[i]["Extrusora"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[BobinaMadre.Index].Value = DS.Tables[0].Rows[i]["BobinaMadre"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Familia.Index].Value = DS.Tables[0].Rows[i]["Familia"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[PesoNeto.Index].Value = DS.Tables[0].Rows[i]["PesoNeto"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Metraje.Index].Value = DS.Tables[0].Rows[i]["Metraje"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Lote.Index].Value = DS.Tables[0].Rows[i]["Lote"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Calificacion.Index].Value = DS.Tables[0].Rows[i]["Calificación"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Usuario.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy HH:mm");
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dataGridView1.Columns["clmDay"].Visible = true;
            dataGridView1.Columns["clmMonth"].Visible = true;
            dataGridView1.Columns["clmYear"].Visible = true;
            dataGridView1.Columns["clmHour"].Visible = true;
            dataGridView1.Columns["Fecha"].Visible = false;
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

            dataGridView1.Columns["clmDay"].Visible = false;
            dataGridView1.Columns["clmMonth"].Visible = false;
            dataGridView1.Columns["clmYear"].Visible = false;
            dataGridView1.Columns["clmHour"].Visible = false;
            dataGridView1.Columns["Fecha"].Visible = true;

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
