using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS.Lite
{
    public partial class frmMainCoilStock : Form
    {
        clsMachine objMachine = new clsMachine();

        public frmMainCoilStock()
        {
            InitializeComponent();
        }
        
        public frmMainCoilStock(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
        }

        private void loadMainCoilList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            List<clsFilter> lstFilter = new List<clsFilter>();
            lstMainCoil = clsMainCoil.getActiveBoppMainCoilListByMachine(objMachine.codsec);

            dgvMainCoilList.Rows.Clear();

            for (int i = 0; i < lstMainCoil.Count; i++)
            {
                dgvMainCoilList.Rows.Add();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListCodsec.Index].Value = lstMainCoil[i].codsec.ToString();
                if (lstMainCoil[i].fkBopp > 0)
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilm.Index].Value = lstMainCoil[i].BoppCode.ToString();
                else
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilm.Index].Value = lstMainCoil[i].CastCode.ToString();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListCode.Index].Value = lstMainCoil[i].code.ToString();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListBatch.Index].Value = lstMainCoil[i].lotNumber.ToString();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListProductionOrder.Index].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListLabRating.Index].Value = lstMainCoil[i].labRating.ToString();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListEndDate.Index].Value = lstMainCoil[i].endDate.ToString();
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListRepose.Index].Value = clsGlobal.FillWithZeros(Convert.ToInt32(DateTime.Now.Subtract(lstMainCoil[i].endDate).TotalHours).ToString(), 2) + ":" + clsGlobal.FillWithZeros(DateTime.Now.Subtract(lstMainCoil[i].endDate).Minutes.ToString(), 2);
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListOutline.Index].Value = global::BPS.Lite.Properties.Resources.chart_line;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListQuality.Index].Value = global::BPS.Lite.Properties.Resources.report;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListClose.Index].Value = global::BPS.Lite.Properties.Resources.lock1;
                dgvMainCoilList.Rows[i].Cells[clmMainCoilListCore.Index].Value = lstMainCoil[i].core.ToString();
                dgvMainCoilList.Rows[i].Cells[clmNetWeigth.Index].Value = lstMainCoil[i].netWeigth.ToString();
                dgvMainCoilList.Rows[i].Cells[clmNetLength.Index].Value = lstMainCoil[i].netlength.ToString();
                dgvMainCoilList.Rows[i].Cells[clmCurrentWeigth.Index].Value = ((lstMainCoil[i].netWeigth * (lstMainCoil[i].netlength - lstMainCoil[i].usedLength)) / lstMainCoil[i].netlength).ToString();
                dgvMainCoilList.Rows[i].Cells[clmCurrentLength.Index].Value = (lstMainCoil[i].netlength - lstMainCoil[i].usedLength).ToString();
                dgvMainCoilList.Rows[i].Cells[clmWidth.Index].Value = lstMainCoil[i].width.ToString();
                dgvMainCoilList.Rows[i].Cells[clmInitdate.Index].Value = lstMainCoil[i].initDate.ToString();
                dgvMainCoilList.Rows[i].Cells[clmGrammage.Index].Value = lstMainCoil[i].gramaje.ToString();
                dgvMainCoilList.Rows[i].Cells[clmNotes.Index].Value = lstMainCoil[i].notes.ToString();
                dgvMainCoilList.Rows[i].Cells[clmLabNotes.Index].Value = clsMainCoilQuality.getQualityByMainCoil(lstMainCoil[i].codsec).fisicStatus.ToString();
            }
        }
        private void frmMainCoilStock_Load(object sender, EventArgs e)
        {
            loadMainCoilList();
        }

        private void dgvMainCoilList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*clsMainCoil objMainCoil = new clsMainCoil(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                List<clsFormulationByFilmProductionPlan> lstFormulations = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objMainCoil.fkFilmProductionPlan);
                clsMainCoilQuality objMainCoilQuality = new clsMainCoilQuality();

                lblOrderNumber.Text = objMainCoil.ProductionOrderNumber.ToString();
                lblFilmType.Text = objMainCoil.BoppCode;
                lblCode.Text = objMainCoil.code;
                lblInitDate.Text = objMainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
                lblEndDate.Text = objMainCoil.endDate.ToString("dd/MM/yyyy HH:mm:ss");
                lblGramaje.Text = Math.Round(objMainCoil.gramaje, 2).ToString();
                lblWidht.Text = objMainCoil.width.ToString();
                lblNetLength.Text = Math.Round(objMainCoil.netlength, 2).ToString();
                lblCurrentWeigth.Text = Math.Round(objMainCoil.usedLength, 2).ToString();
                lblLength.Text = Math.Round(objMainCoil.netlength - objMainCoil.usedLength, 2).ToString();
                lblNetWeigth.Text = Math.Round(objMainCoil.netWeigth, 2).ToString();
                lblNotes.Text = objMainCoil.notes;
                lblLabRanking.Text = objMainCoil.labRating;
                lblCore.Text = objMainCoil.core.ToString();
                objMainCoilQuality = clsMainCoilQuality.getQualityByMainCoil(objMainCoil.codsec);

                txtQualityNotes.Text = objMainCoilQuality.fisicStatus;*/

                lblOrderNumber.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListProductionOrder.Index].Value.ToString();
                lblFilmType.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListFilm.Index].Value.ToString();
                lblCode.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCode.Index].Value.ToString();
                lblInitDate.Text = Convert.ToDateTime(dgvMainCoilList.Rows[e.RowIndex].Cells[clmInitdate.Index].Value).ToString("dd/MM/yyyy HH:mm:ss");
                lblEndDate.Text = Convert.ToDateTime(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListEndDate.Index].Value).ToString("dd/MM/yyyy HH:mm:ss");
                lblGramaje.Text = Math.Round(Convert.ToDouble(dgvMainCoilList.Rows[e.RowIndex].Cells[clmGrammage.Index].Value), 2).ToString();
                lblWidht.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmWidth.Index].Value.ToString();
                lblNetLength.Text = Math.Round(Convert.ToDouble(dgvMainCoilList.Rows[e.RowIndex].Cells[clmNetLength.Index].Value), 2).ToString();
                lblCurrentWeigth.Text = Math.Round(Convert.ToDouble(dgvMainCoilList.Rows[e.RowIndex].Cells[clmCurrentWeigth.Index].Value), 2).ToString();
                lblLength.Text = Math.Round(Convert.ToDouble(dgvMainCoilList.Rows[e.RowIndex].Cells[clmCurrentLength.Index].Value), 2).ToString();
                lblNetWeigth.Text = Math.Round(Convert.ToDouble(dgvMainCoilList.Rows[e.RowIndex].Cells[clmNetWeigth.Index].Value), 2).ToString();
                lblNotes.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmNotes.Index].Value.ToString();
                lblLabRanking.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListLabRating.Index].Value.ToString();
                lblCore.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCore.Index].Value.ToString();
                txtQualityNotes.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmLabNotes.Index].Value.ToString();
            }
        }

        private void btnMainCoilClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmMainCoilStockReport winMainCoilStockReport = new frmMainCoilStockReport(objMachine.codsec);
            winMainCoilStockReport.StartPosition = FormStartPosition.Manual;
            winMainCoilStockReport.MdiParent = this.MdiParent;
            winMainCoilStockReport.Show();
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmMainCoilListOutline.Index)
            {
                frmMainCoilOutline winMainCoilOutline = new frmMainCoilOutline(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                winMainCoilOutline.MdiParent = this.MdiParent;
                winMainCoilOutline.StartPosition = FormStartPosition.Manual;
                winMainCoilOutline.Show();
            }
            if (e.ColumnIndex == clmMainCoilListQuality.Index)
            {
                frmMainCoilQualityReport winMainCoilQualityReport = new frmMainCoilQualityReport(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                winMainCoilQualityReport.MdiParent = this.MdiParent;
                winMainCoilQualityReport.StartPosition = FormStartPosition.Manual;
                winMainCoilQualityReport.Show();
            }
            if (e.ColumnIndex == clmMainCoilListClose.Index)
            {
                if (MessageBox.Show("Desea cerrar el rollo madre seleccionado?", "Stock de rollos madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsMainCoil objMainCoil = new clsMainCoil(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                    objMainCoil.changeStatus("Cerrada");
                    MessageBox.Show("El rollo madre ha sido cerrado.", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadMainCoilList();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;

            dgvMainCoilList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvMainCoilList.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvMainCoilList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvMainCoilList.Columns[clmNetWeigth.Index].Visible = true;
            dgvMainCoilList.Columns[clmNetLength.Index].Visible = true;
            dgvMainCoilList.Columns[clmCurrentWeigth.Index].Visible = true;
            dgvMainCoilList.Columns[clmCurrentLength.Index].Visible = true;
            dgvMainCoilList.Columns[clmWidth.Index].Visible = true;
            dgvMainCoilList.Columns[clmInitdate.Index].Visible = true;
            dgvMainCoilList.Columns[clmGrammage.Index].Visible = true;
            dgvMainCoilList.Columns[clmNotes.Index].Visible = true;
            dgvMainCoilList.Columns[clmLabNotes.Index].Visible = true;

            dgvMainCoilList.SelectAll();
            DataObject dataObj = dgvMainCoilList.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

            dgvMainCoilList.Columns[clmNetWeigth.Index].Visible = false;
            dgvMainCoilList.Columns[clmNetLength.Index].Visible = false;
            dgvMainCoilList.Columns[clmCurrentWeigth.Index].Visible = false;
            dgvMainCoilList.Columns[clmCurrentLength.Index].Visible = false;
            dgvMainCoilList.Columns[clmWidth.Index].Visible = false;
            dgvMainCoilList.Columns[clmInitdate.Index].Visible = false;
            dgvMainCoilList.Columns[clmGrammage.Index].Visible = false;
            dgvMainCoilList.Columns[clmNotes.Index].Visible = false;
            dgvMainCoilList.Columns[clmLabNotes.Index].Visible = false;
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
