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
    public partial class frmPalletMovementReport : Form
    {
        public frmPalletMovementReport()
        {
            InitializeComponent();
            cargarPlantas();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DataSet DS = new DataSet();
            string query;

            if (cmbPlanta.SelectedIndex == -1)
            {
                query = "CALL spPalletMovementReportByDate ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "');";
            }
            else
            {
                query = "CALL spPalletMovementReportByDateByPlant ('" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "', " + new clsPlant(cmbPlanta.Items[cmbPlanta.SelectedIndex].ToString()).codsec.ToString() + ");";
            }

            DS = clsConnection.getDataSetResult(query);

            dgvPalletMovements.Rows.Clear();

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)   
                {
                    dgvPalletMovements.Rows.Add();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["CodPallet"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmCodigoMaterial.Index].Value = DS.Tables[0].Rows[i]["CodProduct"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmNomMaterial.Index].Value = DS.Tables[0].Rows[i]["NombreProd"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmTipeMov.Index].Value = DS.Tables[0].Rows[i]["Movimiento"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["LotePallet"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = DS.Tables[0].Rows[i]["BodOrg"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = DS.Tables[0].Rows[i]["BodDest"].ToString();
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmUser.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["UserName"]);
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaMov"]);
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmDia.Index].Value = DS.Tables[0].Rows[i]["diaFechaMov"];
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmMes.Index].Value = DS.Tables[0].Rows[i]["mesFechaMov"];
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmAño.Index].Value = DS.Tables[0].Rows[i]["yearFechaMov"];
                    dgvPalletMovements.Rows[dgvPalletMovements.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];
                }
            }
        }

        private void cargarPlantas()
        {
            List<clsPlant> list = clsPlant.getList();
            for (int i = 0; i < list.Count; i++)
            {
                cmbPlanta.Items.Add(list[i].name);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvPalletMovements.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dgvPalletMovements.Columns["clmDia"].Visible = true;
            dgvPalletMovements.Columns["clmMes"].Visible = true;
            dgvPalletMovements.Columns["clmAño"].Visible = true;
            dgvPalletMovements.Columns["clmHour"].Visible = true;
            dgvPalletMovements.Columns["clmFecha"].Visible = false;


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
                dgvPalletMovements.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvPalletMovements.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;

            dgvPalletMovements.Columns["clmDia"].Visible = false;
            dgvPalletMovements.Columns["clmMes"].Visible = false;
            dgvPalletMovements.Columns["clmAño"].Visible = false;
            dgvPalletMovements.Columns["clmHour"].Visible = false;
            dgvPalletMovements.Columns["clmFecha"].Visible = true;
        }

        private void copyAlltoClipboard()
        {
            dgvPalletMovements.SelectAll();
            DataObject dataObj = dgvPalletMovements.GetClipboardContent();
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
