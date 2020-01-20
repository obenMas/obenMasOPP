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
    public partial class frmOTIFReport : Form
    {
        public frmOTIFReport()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spSoDOtifByDates('" + dateTPFromCutting.Value.ToString("dd/MM/yyyy")  + "','" + dateTPToCutting.Value.ToString("dd/MM/yyyy")+"'"); 

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvOTIFReport.Rows.Add();
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmSoD.Index].Value = DS.Tables[0].Rows[i]["SoD"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmCantidad.Index].Value = DS.Tables[0].Rows[i]["cantidad"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmCantidadFabricada.Index].Value = DS.Tables[0].Rows[i]["cantidadFabricada"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmCantidadDespachada.Index].Value = DS.Tables[0].Rows[i]["cantidadDespachada"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["Cliente"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmFechaCreacion.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaCreacion"]).ToShortDateString();
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmFechaOTIF.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["OTIFDate"]).ToShortDateString();
                    //dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmCantidadDespachada.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaDespacho"]).ToShortDateString();
                    if (Convert.ToBoolean(DS.Tables[0].Rows[i]["estacompleto"]))
                    {
                        dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmCompDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaComp"]).ToShortDateString();
                    }
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["pelicula"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                    dgvOTIFReport.Rows[dgvOTIFReport.Rows.Count - 1].Cells[clmPlanta.Index].Value = DS.Tables[0].Rows[i]["Planta"];
                }
            }

            DS = clsConnection.getDataSetResult("SELECT * FROM vwLastShipBySOD");

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dgvOTIFReport.Rows.Count; i++)
                { 
                    for(int j=0; j<DS.Tables[0].Rows.Count;j++)
                    {
                        string uno = DS.Tables[0].Rows[j]["pbsod_fkSalesOrderDetail"].ToString();
                        string dos = dgvOTIFReport.Rows[i].Cells[clmSoD.Index].Value.ToString();
                        if(uno!="" && Convert.ToInt32(dgvOTIFReport.Rows[i].Cells[clmSoD.Index].Value)==Convert.ToInt32(DS.Tables[0].Rows[j]["pbsod_fkSalesOrderDetail"]))
                        {
                            dgvOTIFReport.Rows[i].Cells[clmFechaDespacho.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[j]["FechaDespacho"]).ToShortDateString();
                        }
                    }
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dgvOTIFReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvOTIFReport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvOTIFReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvOTIFReport.SelectAll();
            DataObject dataObj = dgvOTIFReport.GetClipboardContent();
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
