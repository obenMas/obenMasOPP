using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmShippingReportByCoil : Form
    {
        DataSet DS = new DataSet();
        List<clsPlant> planta = new List<clsPlant>();

        public frmShippingReportByCoil()
        {
            InitializeComponent();

            planta = clsPlant.getList();

            for (int i = 0; i < planta.Count; i++)
            {
                cmbPlants.Items.Add(planta[i].name);
            }

        }

        #region Exportar a Excel

        private void btnExport_Click(object sender, EventArgs e)
        {
            dgvShippingReport.Columns[clmDate.Index].Visible = false;
            dgvShippingReport.Columns[clmDay.Index].Visible = true;
            dgvShippingReport.Columns[clmMonth.Index].Visible = true;
            dgvShippingReport.Columns[clmYear.Index].Visible = true;
            dgvShippingReport.Columns[clmHour.Index].Visible = true;

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
                dgvShippingReport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
          

            dgvShippingReport.Columns[clmDate.Index].Visible = true;
            dgvShippingReport.Columns[clmDay.Index].Visible = false;
            dgvShippingReport.Columns[clmMonth.Index].Visible = false;
            dgvShippingReport.Columns[clmYear.Index].Visible = false;
            dgvShippingReport.Columns[clmHour.Index].Visible = false;
        }

        private void copyAlltoClipboard()
        {
            dgvShippingReport.SelectAll();
            DataObject dataObj = dgvShippingReport.GetClipboardContent();
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

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbPlants.SelectedIndex != -1)
            {
                DS = clsConnection.getDataSetResult("CALL spShippingReportPreShippeds('" + dtpFrom.Value.ToString() + "','" + dtpTo.Value.ToString() + "'," + new clsPlant(cmbPlants.SelectedItem.ToString()).codsec);
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spShippingReportPreShippeds('" + dtpFrom.Value.ToString() + "','" + dtpTo.Value.ToString() + "'," + 0);
            }

            dgvShippingReport.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvShippingReport.Rows.Add();
                    if (DS.Tables[0].Rows[i].ToString().Length > 14)
                    {
                        dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmCoil.Index].Value = "B-" + DS.Tables[0].Rows[i]["codigoBob"].ToString();
                    }
                    else
                    {
                        dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmCoil.Index].Value = DS.Tables[0].Rows[i]["codigoBob"].ToString();
                    }
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["cliente"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmDate.Index].Value = DS.Tables[0].Rows[i]["fecha"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmPeso.Index].Value = DS.Tables[0].Rows[i]["peso"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmRemito.Index].Value = DS.Tables[0].Rows[i]["Remito"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["producto"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmOrigen.Index].Value = DS.Tables[0].Rows[i]["Origen"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmPedido.Index].Value = DS.Tables[0].Rows[i]["pedido"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["planta"].ToString();
                    dgvShippingReport.Rows[dgvShippingReport.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"].ToString();
                    
                }
            }
            dgvShippingReport.Sort(dgvShippingReport.Columns[clmCoil.Index], ListSortDirection.Descending);
        }
    }
}
