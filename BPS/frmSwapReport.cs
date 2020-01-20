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
    public partial class frmSwapReport : Form
    {
        public frmSwapReport()
        {
            InitializeComponent();
            fillPlantsCmb();
        }

        #region Generar y Cargar el DGV

        private void btnGenerateCuttingRp_Click(object sender, EventArgs e)
        {
                DataSet DS = new DataSet();
                string texto;

                if(cmbPlant.SelectedIndex==-1)
                {
                    texto = "CALL spSwapReportByDate '" + dateTPFromSwap.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToSwap.Value.ToString("dd/MM/yyyy") + "' ," + 0 + "," + Convert.ToInt32(chkBobina.Checked) + ");";
                }
                else
                {
                    texto = "CALL spSwapReportByDate '" + dateTPFromSwap.Value.ToString("dd/MM/yyyy") + "', '" + dateTPToSwap.Value.ToString("dd/MM/yyyy") + "' ," +  new clsPlant(cmbPlant.Items[cmbPlant.SelectedIndex].ToString()).codsec + "," + Convert.ToInt32(chkBobina.Checked) + ");";
                }
                
                DS = clsConnection.getDataSetResult(texto);

                dgvSwapInterplant.Rows.Clear();

            if(DS.Tables.Count>0 && DS.Tables[0].Rows.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    dgvSwapInterplant.Rows.Add();
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmSwapCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["SwapCodsec"]);
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[Pelicula.Index].Value = DS.Tables[0].Rows[i]["Pelicula"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[Ancho.Index].Value = DS.Tables[0].Rows[i]["Ancho"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[Diametro.Index].Value = DS.Tables[0].Rows[i]["Diametro"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[Core.Index].Value = DS.Tables[0].Rows[i]["Core"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmTipoMov.Index].Value = DS.Tables[0].Rows[i]["TipoMov"].ToString();
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmPeso.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]),1);
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmUser.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmOrigen.Index].Value = DS.Tables[0].Rows[i]["Origen"].ToString();
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmDestino.Index].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]).ToString("dd/MM/yyyy HH:mm");
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFecha"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFecha"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFecha"];
                    dgvSwapInterplant.Rows[dgvSwapInterplant.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
            dgvSwapInterplant.Sort(dgvSwapInterplant.Columns[clmDate.Index], ListSortDirection.Descending);
        }

        #endregion

        #region Exportar a Excel

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvSwapInterplant.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvSwapInterplant.Columns["clmDay"].Visible = true;
            dgvSwapInterplant.Columns["clmMonth"].Visible = true;
            dgvSwapInterplant.Columns["clmYear"].Visible = true;
            dgvSwapInterplant.Columns["clmHour"].Visible = true;
            dgvSwapInterplant.Columns["clmDate"].Visible = false;

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
                dgvSwapInterplant.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvSwapInterplant.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvSwapInterplant.Columns["clmDay"].Visible = false;
            dgvSwapInterplant.Columns["clmMonth"].Visible = false;
            dgvSwapInterplant.Columns["clmYear"].Visible = false;
            dgvSwapInterplant.Columns["clmDate"].Visible = true;
            dgvSwapInterplant.Columns["clmHour"].Visible = false;
        }

        private void copyAlltoClipboard()
        {
            dgvSwapInterplant.SelectAll();
            DataObject dataObj = dgvSwapInterplant.GetClipboardContent();
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


        public void fillPlantsCmb()
        {
            List<clsPlant> list = clsPlant.getList();
            
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlant.Items.Add(list[i].name);
            }
        }


    }
}
