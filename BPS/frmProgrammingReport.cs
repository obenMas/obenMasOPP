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
    public partial class frmProgrammingReport : Form
    {
        DataSet DS = new DataSet();

        public frmProgrammingReport()
        {
            InitializeComponent();
            getDataSet();
            populateDgvProgrammingReport();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("CALL spCuttingOrderReport();");
        }


        public void populateDgvProgrammingReport()
        {
            if (DS.Tables[0].Rows.Count > 0)
            {
                dgvProgrammingReport.Rows.Clear();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvProgrammingReport.Rows.Add();
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmCombination"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Combinacion"]);
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmCutter"].Value = DS.Tables[0].Rows[i]["Cortadora"].ToString();
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["Pelicula"].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmProgrammedWeight"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["AnchoProgramado"]), 2);
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["AnchoBobinaMadre"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["AnchoBobinaMadre"]), 2);
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmReps"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["Repeticiones"]);
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmKg"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["KilosProgramados"]), 2);
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["CalidadBobinaMadre"].Value = DS.Tables[0].Rows[i]["CalidadBobinaMadre"].ToString();
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmStatus"].Value = DS.Tables[0].Rows[i]["Estado"].ToString();
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmProgrammedDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaProgramación"]).ToString("dd/MM/yyyy");
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmDay"].Value = DS.Tables[0].Rows[i]["dayFechaProgramacion"];
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmMonth"].Value = DS.Tables[0].Rows[i]["monthFechaProgramacion"];
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmYear"].Value = DS.Tables[0].Rows[i]["yearFechaProgramacion"];
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmHour"].Value = DS.Tables[0].Rows[i]["Hora"];
                    dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells[clmDiameter.Index].Value = DS.Tables[0].Rows[i]["diametro"];
                }
            }


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvProgrammingReport.Columns["clmDay"].Visible = true;
            dgvProgrammingReport.Columns["clmMonth"].Visible = true;
            dgvProgrammingReport.Columns["clmYear"].Visible = true;
            dgvProgrammingReport.Columns["clmHour"].Visible = true;
            dgvProgrammingReport.Columns["clmProgrammedDate"].Visible = false;
            dgvProgrammingReport.Columns[clmDiameter.Index].Visible = true;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);
            dgvProgrammingReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvProgrammingReport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);

            }

            dgvProgrammingReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvProgrammingReport.Columns["clmDay"].Visible = false;
            dgvProgrammingReport.Columns["clmMonth"].Visible = false;
            dgvProgrammingReport.Columns["clmYear"].Visible = false;
            dgvProgrammingReport.Columns["clmHour"].Visible = false;
            dgvProgrammingReport.Columns["clmProgrammedDate"].Visible = true;
            dgvProgrammingReport.Columns[clmDiameter.Index].Visible = false;
        }

        private void copyAlltoClipboard()
        {
            dgvProgrammingReport.SelectAll();
            DataObject dataObj = dgvProgrammingReport.GetClipboardContent();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS2 = new DataSet();
                string texto = "CALL spCuttingOrderReportbyDate('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "', '" + dtpTo.Value.ToString("dd/MM/yyyy") + "');";
                DS2 = clsConnection.getDataSetResult(texto);

                dgvProgrammingReport.Rows.Clear();

                if (DS2.Tables[0].Rows.Count > 0)
                {
                    dgvProgrammingReport.Rows.Clear();

                    for (int i = 0; i < DS2.Tables[0].Rows.Count; i++)
                    {
                        dgvProgrammingReport.Rows.Add();
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmCombination"].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Combinacion"]);
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmCutter"].Value = DS2.Tables[0].Rows[i]["Cortadora"].ToString();
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells[Pelicula.Index].Value = DS2.Tables[0].Rows[i]["Pelicula"].ToString();
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmProgrammedWeight"].Value = Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["AnchoProgramado"]), 2);
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells[AnchoBobinaMadre.Index].Value = Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["AnchoBobinaMadre"]), 2);
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmReps"].Value = Convert.ToInt32(DS2.Tables[0].Rows[i]["Repeticiones"]);
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmKg"].Value = Math.Round(Convert.ToDouble(DS2.Tables[0].Rows[i]["KilosProgramados"]), 2);
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells[CalidadBobinaMadre.Index].Value = DS2.Tables[0].Rows[i]["CalidadBobinaMadre"].ToString();
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmStatus"].Value = DS2.Tables[0].Rows[i]["Estado"].ToString();
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmProgrammedDate"].Value = Convert.ToDateTime(DS2.Tables[0].Rows[i]["FechaProgramación"]).ToString("dd/MM/yyyy");
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells[clmDay.Index].Value = DS2.Tables[0].Rows[i]["dayFechaProgramacion"];
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmMonth"].Value = DS2.Tables[0].Rows[i]["monthFechaProgramacion"];
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmYear"].Value = DS2.Tables[0].Rows[i]["yearFechaProgramacion"];
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells["clmHour"].Value = DS2.Tables[0].Rows[i]["Hora"];
                        dgvProgrammingReport.Rows[dgvProgrammingReport.Rows.Count - 1].Cells[clmDiameter.Index].Value = DS2.Tables[0].Rows[i]["diametro"];
                        
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reporte de Programación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSuprFilter_Click(object sender, EventArgs e)
        {
            dgvProgrammingReport.Rows.Clear();

            getDataSet();

            populateDgvProgrammingReport();
        }

        
    }
}
