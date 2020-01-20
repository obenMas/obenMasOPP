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
    public partial class frmRawMaterialStockByDate : Form
    {
        clsPlant planta = new clsPlant();

        public frmRawMaterialStockByDate()
        {
            InitializeComponent();

            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbPlanta.Items.Add(lstPlant[i].name);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            populateDGV();
        }

        private void populateDGV()
        {
            DataSet DS = new DataSet();
            string query = string.Empty;
            dgvMpStock.Rows.Clear();
      
            if (cmbPlanta.SelectedIndex == 0)
            {
                 planta = new clsPlant(3);
                 query = "SELECT * FROM bps_prod_rawdepothistory WHERE rdh_day =" + dtpDate.Value.Day.ToString() + " AND" + " rdh_month = " + dtpDate.Value.Month.ToString() + " AND rdh_year = " + dtpDate.Value.Year.ToString() + " AND rdh_fkplant = " + planta.codsec.ToString();
            }
            else if (cmbPlanta.SelectedIndex == 1)
            {
                planta = new clsPlant(4);

                query = "SELECT * FROM bps_prod_rawdepothistory WHERE rdh_day =" + dtpDate.Value.Day.ToString() + " AND" + " rdh_month = " + dtpDate.Value.Month.ToString() + " AND rdh_year = " + dtpDate.Value.Year.ToString() + " AND rdh_fkplant = " + planta.codsec.ToString();
            }
            else 
            {
                 query = "SELECT * FROM bps_prod_rawdepothistory WHERE rdh_day =" + dtpDate.Value.Day.ToString() + " AND" + " rdh_month = " + dtpDate.Value.Month.ToString() + " AND rdh_year = " + dtpDate.Value.Year.ToString();
            }

            DS = clsConnection.getDataSetResult(query);

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0 )
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvMpStock.Rows.Add();
                    dgvMpStock.Rows[dgvMpStock.Rows.Count - 1].Cells[clmMP.Index].Value = DS.Tables[0].Rows[i]["rdh_raw"];
                    dgvMpStock.Rows[dgvMpStock.Rows.Count - 1].Cells[ActualWeight.Index].Value = DS.Tables[0].Rows[i]["rdh_NetWeight"];
                    dgvMpStock.Rows[dgvMpStock.Rows.Count - 1].Cells[clmFecha.Index].Value = DS.Tables[0].Rows[i]["rdh_day"].ToString() + "/" +  DS.Tables[0].Rows[i]["rdh_month"].ToString() + "/" + DS.Tables[0].Rows[i]["rdh_year"].ToString();
                    dgvMpStock.Rows[dgvMpStock.Rows.Count - 1].Cells[clmBodega.Index].Value = DS.Tables[0].Rows[i]["rdh_coilcellar"];
                    dgvMpStock.Rows[dgvMpStock.Rows.Count - 1].Cells[clmPlanta.Index].Value = planta.name;
                    
                }   
            }
        }

        private void cmbPlanta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPlanta.SelectedIndex = -1;
                cmbPlanta.Text = string.Empty;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvMpStock.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgvMpStock.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvMpStock.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvMpStock.SelectAll();
            DataObject dataObj = dgvMpStock.GetClipboardContent();
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
