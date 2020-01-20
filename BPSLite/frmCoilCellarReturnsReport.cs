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
    public partial class frmCoilCellarReturnsReport : Form
    {
        DataSet DS = new DataSet();

        public frmCoilCellarReturnsReport()
        {
            InitializeComponent();
            fillPlants();
        }

        public void getDataSet()
        {
            string queryString;

            if (cmbPlants.SelectedIndex == -1)
            {
                queryString = "CALL spReturnByDate ('" + dateTPFromReturn.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToReturn.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                queryString = "CALL spReturnByDateAndPlant ('" + dateTPFromReturn.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToReturn.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlants.Items[cmbPlants.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(queryString);
        }

        private void btnGenerateReturnByDateRp_Click(object sender, EventArgs e)
        {
            getDataSet();

            if (DS.Tables[0].Rows.Count > 0)
            {
                dgvCoilCellarReturns.Rows.Clear();
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvCoilCellarReturns.Rows.Add();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmPallet.Index].Value = DS.Tables[0].Rows[i]["Pallet"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmCoil.Index].Value = DS.Tables[0].Rows[i]["Bobina"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmSaleOrderDetail.Index].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmWeight.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmMovementType.Index].Value = DS.Tables[0].Rows[i]["TipodeMovimiento"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy");
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"].ToString();
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvCoilCellarReturns.Rows[dgvCoilCellarReturns.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

            dgvCoilCellarReturns.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvCoilCellarReturns.Columns["clmDate"].Visible = false;
            dgvCoilCellarReturns.Columns["clmDay"].Visible = true;
            dgvCoilCellarReturns.Columns["clmMonth"].Visible = true;
            dgvCoilCellarReturns.Columns["clmYear"].Visible = true;

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
                dgvCoilCellarReturns.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            dgvCoilCellarReturns.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvCoilCellarReturns.Columns["clmDate"].Visible = true;
            dgvCoilCellarReturns.Columns["clmDay"].Visible = false;
            dgvCoilCellarReturns.Columns["clmMonth"].Visible = false;
            dgvCoilCellarReturns.Columns["clmYear"].Visible = false;
        }

        private void copyAlltoClipboard()
        {
            dgvCoilCellarReturns.SelectAll();
            
            DataObject dataObj = dgvCoilCellarReturns.GetClipboardContent();
            
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
                
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

        private void fillPlants()
        {
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlants.Items.Add(list[i].name);
            }
        }


    }
}
