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
    public partial class frmMetallizedReport : Form
    {
        public frmMetallizedReport()
        {
            InitializeComponent();
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlant.Items.Add(list[i].name);
            }
        }

        #region Cargar el DGV
        private void btnGenerateMetallizedRp_Click(object sender, EventArgs e)
        {
            
                string texto;
                if (cmbPlant.SelectedIndex == -1)
                {
                    texto = "CALL spMetalizedReport '" + dateTPFromMetallized.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToMetallized.Value.ToString("dd/MM/yyyy") + "';";
                }
                else
                {
                    texto = "CALL spMetalizedReportByPlant '" + dateTPFromMetallized.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToMetallized.Value.ToString("dd/MM/yyyy") + "',"+ new clsPlant(cmbPlant.Items[cmbPlant.SelectedIndex].ToString()).codsec.ToString() + ";";
                }
                DataSet DS = new DataSet();

                DS = clsConnection.getDataSetResult(texto);

                dataGridView1.Rows.Clear();

                if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                    {
                        dataGridView1.Rows.Add();
                        int fila = dataGridView1.Rows.Count - 1;
                        dataGridView1.Rows[fila].Cells[Metalizadora.Index].Value = DS.Tables[0].Rows[i]["Metalizadora"].ToString();
                        dataGridView1.Rows[fila].Cells[Base.Index].Value = DS.Tables[0].Rows[i]["Base"].ToString();
                        dataGridView1.Rows[fila].Cells[Lote.Index].Value = DS.Tables[0].Rows[i]["lotNumber"].ToString();
                        dataGridView1.Rows[fila].Cells[Codigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                        dataGridView1.Rows[fila].Cells[Material.Index].Value = DS.Tables[0].Rows[i]["Material"].ToString();
                        dataGridView1.Rows[fila].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"].ToString();
                        dataGridView1.Rows[fila].Cells[Diametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                        dataGridView1.Rows[fila].Cells[Largo.Index].Value = DS.Tables[0].Rows[i]["Largo"].ToString();
                        dataGridView1.Rows[fila].Cells[Peso.Index].Value = DS.Tables[0].Rows[i]["Peso"].ToString();
                        dataGridView1.Rows[fila].Cells[Fecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy HH:mm");
                        dataGridView1.Rows[fila].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayCorte"].ToString();
                        dataGridView1.Rows[fila].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthCorte"].ToString();
                        dataGridView1.Rows[fila].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearCorte"].ToString();
                        dataGridView1.Rows[fila].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                    }
                }
        }

        #endregion

        #region Exportar a Excel
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
        #endregion

    }
}
