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
    public partial class frmImportReport : Form
    {
        DataSet DS = new DataSet();
        List<clsPlant> listPlant = new List<clsPlant>();

        public frmImportReport()
        {
            InitializeComponent();

            listPlant = clsPlant.getList();

            for (int i = 0; i < listPlant.Count; i++)
            {
                cmbPlant.Items.Add(listPlant[i].name);
            }
        }

        private void btnGenerateSwapRp_Click(object sender, EventArgs e)
        {
            if (chkPallet.Checked) // Que traiga por pallet
            {
                if (cmbPlant.SelectedIndex == -1)
                {
                    DS = clsConnection.getDataSetResult("CALL spImportacionesByPlantByDateAndDetail('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','" + dtpTo.Value.ToString("dd/MM/yyyy") + "'," + 0 + "," + true);
                }
                else
                {
                    DS = clsConnection.getDataSetResult("CALL spImportacionesByPlantByDateAndDetail('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','" + dtpTo.Value.ToString("dd/MM/yyyy") + "'," + new clsPlant(cmbPlant.SelectedItem.ToString()).codsec + "," + true);
                }
            }
            else // Trae por bobinas
            {
                if (cmbPlant.SelectedIndex == -1)
                {
                    DS = clsConnection.getDataSetResult("CALL spImportacionesByPlantByDateAndDetail('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','" + dtpTo.Value.ToString("dd/MM/yyyy") + "'," + 0 + "," + false);
                }
                else
                {
                    DS = clsConnection.getDataSetResult("CALL spImportacionesByPlantByDateAndDetail('" + dtpFrom.Value.ToString("dd/MM/yyyy") + "','" + dtpTo.Value.ToString("dd/MM/yyyy") + "'," + new clsPlant(cmbPlant.SelectedItem.ToString()).codsec + "," + false);
                }
            }
            dgvImport.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
			    {
			        dgvImport.Rows.Add();
                    if (DS.Tables[0].Rows[i]["codigo"].ToString().Length > 10 && !chkPallet.Checked)
                    {
                        dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmCode.Index].Value = "B-" + DS.Tables[0].Rows[i]["codigo"].ToString();
                    }
                    else
                    {
                        dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmCode.Index].Value = DS.Tables[0].Rows[i]["codigo"].ToString();
                    }
                    
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["peso"].ToString();
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["producto"].ToString();
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["Ancho"].ToString();
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmDiametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"].ToString();
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmCore.Index].Value = DS.Tables[0].Rows[i]["Core"].ToString();
                    dgvImport.Rows[dgvImport.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["ingreso"]).ToString("dd/MM/yyyy");
			    }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            dgvImport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                xlWorkSheet.PasteSpecial(CR,Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
                

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
                dgvImport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvImport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvImport.SelectAll();
            DataObject dataObj = dgvImport.GetClipboardContent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            clsExports.createExcel(dgvImport);
        }
    }
}
