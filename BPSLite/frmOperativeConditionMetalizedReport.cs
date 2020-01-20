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
    public partial class frmOperativeConditionMetalizedReport : Form
    {
        public frmOperativeConditionMetalizedReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string texto = "CALL spOperativeConditionsMetalizedReport '" + dtpDesde.Value.ToString("dd/MM/yyyy") + "', '" + dtpHasta.Value.ToString("dd/MM/yyyy") + "';";
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult(texto);

            dgvReport.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvReport.Rows.Add();
                    int fila = dgvReport.Rows.Count - 1;
                    dgvReport.Rows[fila].Cells[codsec.Index].Value = DS.Tables[0].Rows[i]["codsec"].ToString();
                    dgvReport.Rows[fila].Cells[clmbasefkcode.Index].Value = DS.Tables[0].Rows[i]["codsecBobinaBase"].ToString();
                    dgvReport.Rows[fila].Cells[clmbasemetalcode.Index].Value = DS.Tables[0].Rows[i]["CodigoBaseMetalizada"].ToString();
                    dgvReport.Rows[fila].Cells[clmBobinaBase.Index].Value = DS.Tables[0].Rows[i]["Base"].ToString();
                    dgvReport.Rows[fila].Cells[clmBaseMetraje.Index].Value = DS.Tables[0].Rows[i]["BaseMetraje"].ToString();
                    dgvReport.Rows[fila].Cells[clmBaseDiametro.Index].Value = DS.Tables[0].Rows[i]["BaseDiametro"].ToString();
                    dgvReport.Rows[fila].Cells[clmBaseAncho.Index].Value = DS.Tables[0].Rows[i]["BaseAncho"].ToString();
                    dgvReport.Rows[fila].Cells[clmBasePeso.Index].Value = DS.Tables[0].Rows[i]["BasePeso"].ToString();
                    dgvReport.Rows[fila].Cells[clmBaseLote.Index].Value = DS.Tables[0].Rows[i]["BaseLote"].ToString();
                    dgvReport.Rows[fila].Cells[clmMainCoilMetal.Index].Value = DS.Tables[0].Rows[i]["CodigoBaseMetalizada"].ToString();
                    dgvReport.Rows[fila].Cells[clmMetPeso.Index].Value = DS.Tables[0].Rows[i]["MetPeso"].ToString();
                    dgvReport.Rows[fila].Cells[clmMetDiametro.Index].Value = DS.Tables[0].Rows[i]["MetDiametro"].ToString();
                    dgvReport.Rows[fila].Cells[clmMetMetraje.Index].Value = DS.Tables[0].Rows[i]["MetMetraje"].ToString();
                    dgvReport.Rows[fila].Cells[clmMetLote.Index].Value = DS.Tables[0].Rows[i]["MetLote"].ToString();
                    dgvReport.Rows[fila].Cells[clmMetAncho.Index].Value = DS.Tables[0].Rows[i]["MetAncho"].ToString();
                    dgvReport.Rows[fila].Cells[clmUnT010.Index].Value = DS.Tables[0].Rows[i]["UnT010"].ToString();
                    dgvReport.Rows[fila].Cells[clmUnT1020.Index].Value = DS.Tables[0].Rows[i]["UnT1020"].ToString();
                    dgvReport.Rows[fila].Cells[clmUnT2030.Index].Value = DS.Tables[0].Rows[i]["UnT2030"].ToString();
                    dgvReport.Rows[fila].Cells[clmUnT3040.Index].Value = DS.Tables[0].Rows[i]["UnT3040"].ToString();
                    dgvReport.Rows[fila].Cells[clmUnT4050.Index].Value = DS.Tables[0].Rows[i]["UnT4050"].ToString();
                    dgvReport.Rows[fila].Cells[clmUnT5060.Index].Value = DS.Tables[0].Rows[i]["UnT5060"].ToString();
                    dgvReport.Rows[fila].Cells[clmReT010.Index].Value = DS.Tables[0].Rows[i]["ReT010"].ToString();
                    dgvReport.Rows[fila].Cells[clmReT1020.Index].Value = DS.Tables[0].Rows[i]["ReT1020"].ToString();
                    dgvReport.Rows[fila].Cells[clmReT2030.Index].Value = DS.Tables[0].Rows[i]["ReT2030"].ToString();
                    dgvReport.Rows[fila].Cells[clmReT3040.Index].Value = DS.Tables[0].Rows[i]["ReT3040"].ToString();
                    dgvReport.Rows[fila].Cells[clmReT4050.Index].Value = DS.Tables[0].Rows[i]["ReT4050"].ToString();
                    dgvReport.Rows[fila].Cells[clmReT5060.Index].Value = DS.Tables[0].Rows[i]["ReT5060"].ToString();
                    dgvReport.Rows[fila].Cells[clmgapUnwind.Index].Value = DS.Tables[0].Rows[i]["gapUnwind"].ToString();
                    dgvReport.Rows[fila].Cells[clmgapRewind.Index].Value = DS.Tables[0].Rows[i]["gapRewind"].ToString();
                    dgvReport.Rows[fila].Cells[clmTaperPercentage.Index].Value = DS.Tables[0].Rows[i]["TaperPercentage"].ToString();
                    dgvReport.Rows[fila].Cells[clmDrumTemperature.Index].Value = DS.Tables[0].Rows[i]["DrumTemp"].ToString();
                    dgvReport.Rows[fila].Cells[clmDtr1Torque.Index].Value = DS.Tables[0].Rows[i]["Torque"].ToString();
                    dgvReport.Rows[fila].Cells[clmRollerPosition.Index].Value = DS.Tables[0].Rows[i]["RollerPosition"].ToString();
                    dgvReport.Rows[fila].Cells[clmOpticDensityMode.Index].Value = DS.Tables[0].Rows[i]["ModoTrabajado"].ToString();
                    dgvReport.Rows[fila].Cells[clmInicioAluminio.Index].Value = DS.Tables[0].Rows[i]["InicioAluminio"].ToString();
                    dgvReport.Rows[fila].Cells[clmInitSpeed.Index].Value = DS.Tables[0].Rows[i]["InicioMaq"].ToString();
                    dgvReport.Rows[fila].Cells[clmProcessSpeed.Index].Value = DS.Tables[0].Rows[i]["Proceso"].ToString();
                    dgvReport.Rows[fila].Cells[clmEndSpeed.Index].Value = DS.Tables[0].Rows[i]["Final"].ToString();
                    dgvReport.Rows[fila].Cells[clmNotes.Index].Value = DS.Tables[0].Rows[i]["Obs"].ToString();
                    dgvReport.Rows[fila].Cells[clmC1.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C1"]);
                    dgvReport.Rows[fila].Cells[clmC2.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C2"]);
                    dgvReport.Rows[fila].Cells[clmC3.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C3"]);
                    dgvReport.Rows[fila].Cells[clmC4.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C4"]);
                    dgvReport.Rows[fila].Cells[clmC5.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C5"]);
                    dgvReport.Rows[fila].Cells[clmC6.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C6"]);
                    dgvReport.Rows[fila].Cells[clmC7.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C7"]);
                    dgvReport.Rows[fila].Cells[clmC8.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C8"]);
                    dgvReport.Rows[fila].Cells[clmC9.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C9"]);
                    dgvReport.Rows[fila].Cells[clmC10.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C10"]);
                    dgvReport.Rows[fila].Cells[clmC11.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C11"]);
                    dgvReport.Rows[fila].Cells[clmC12.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C12"]);
                    dgvReport.Rows[fila].Cells[clmC13.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C13"]);
                    dgvReport.Rows[fila].Cells[clmC14.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C14"]);
                    dgvReport.Rows[fila].Cells[clmC15.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C15"]);
                    dgvReport.Rows[fila].Cells[clmC16.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C16"]);
                    dgvReport.Rows[fila].Cells[clmC17.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C17"]);
                    dgvReport.Rows[fila].Cells[clmC18.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C18"]);
                    dgvReport.Rows[fila].Cells[clmC19.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C19"]);
                    dgvReport.Rows[fila].Cells[clmC20.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C20"]);
                    dgvReport.Rows[fila].Cells[clmC21.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C21"]);
                    dgvReport.Rows[fila].Cells[clmC22.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C22"]);
                    dgvReport.Rows[fila].Cells[clmC23.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C23"]);
                    dgvReport.Rows[fila].Cells[clmC24.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C24"]);
                    dgvReport.Rows[fila].Cells[clmC25.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C25"]);
                    dgvReport.Rows[fila].Cells[clmC26.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C26"]);
                    dgvReport.Rows[fila].Cells[clmC27.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C27"]);
                    dgvReport.Rows[fila].Cells[clmC28.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C28"]);
                    dgvReport.Rows[fila].Cells[clmC29.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C29"]);
                    dgvReport.Rows[fila].Cells[clmC30.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["C30"]);
                    dgvReport.Rows[fila].Cells[clmA1.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A1"]);
                    dgvReport.Rows[fila].Cells[clmA2.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A2"]);
                    dgvReport.Rows[fila].Cells[clmA3.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A3"]);
                    dgvReport.Rows[fila].Cells[clmA4.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A4"]);
                    dgvReport.Rows[fila].Cells[clmA5.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A5"]);
                    dgvReport.Rows[fila].Cells[clmA6.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A6"]);
                    dgvReport.Rows[fila].Cells[clmA7.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A7"]);
                    dgvReport.Rows[fila].Cells[clmA8.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A8"]);
                    dgvReport.Rows[fila].Cells[clmA9.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A9"]);
                    dgvReport.Rows[fila].Cells[clmA10.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A10"]);
                    dgvReport.Rows[fila].Cells[clmA11.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A11"]);
                    dgvReport.Rows[fila].Cells[clmA12.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A12"]);
                    dgvReport.Rows[fila].Cells[clmA13.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A13"]);
                    dgvReport.Rows[fila].Cells[clmA14.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A14"]);
                    dgvReport.Rows[fila].Cells[clmA15.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A15"]);
                    dgvReport.Rows[fila].Cells[clmA16.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A16"]);
                    dgvReport.Rows[fila].Cells[clmA17.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A17"]);
                    dgvReport.Rows[fila].Cells[clmA18.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A18"]);
                    dgvReport.Rows[fila].Cells[clmA19.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A19"]);
                    dgvReport.Rows[fila].Cells[clmA20.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A20"]);
                    dgvReport.Rows[fila].Cells[clmA21.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A21"]);
                    dgvReport.Rows[fila].Cells[clmA22.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A22"]);
                    dgvReport.Rows[fila].Cells[clmA23.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A23"]);
                    dgvReport.Rows[fila].Cells[clmA24.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A24"]);
                    dgvReport.Rows[fila].Cells[clmA25.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A25"]);
                    dgvReport.Rows[fila].Cells[clmA26.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A26"]);
                    dgvReport.Rows[fila].Cells[clmA27.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A27"]);
                    dgvReport.Rows[fila].Cells[clmA28.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A28"]);
                    dgvReport.Rows[fila].Cells[clmA29.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A29"]);
                    dgvReport.Rows[fila].Cells[clmA30.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["A30"]);
               }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvReport.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvReport.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }
        private void copyAlltoClipboard()
        {
            dgvReport.SelectAll();
            DataObject dataObj = dgvReport.GetClipboardContent();
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
