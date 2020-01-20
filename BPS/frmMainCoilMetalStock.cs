using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace BPS
{
    public partial class frmMainCoilMetalStock : Form
    {
        clsPlant planta = new clsPlant();

        public frmMainCoilMetalStock()
        {
            InitializeComponent();
        }

        public frmMainCoilMetalStock(int fkPlant)
        {
            InitializeComponent();
            planta = new clsPlant(fkPlant);
        }

        private void loadMainCoilList()
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            DataSet lstMainCoil = clsMainCoilMetal.getMainCoilMetalStock(planta.codsec);

            dgvMainCoilList.Rows.Clear();

            if (lstMainCoil.Tables.Count > 0 && lstMainCoil.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < lstMainCoil.Tables[0].Rows.Count; i++)
                {
                    dgvMainCoilList.Rows.Add();
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListCodsec.Index].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["Codsec"]);
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListFilm.Index].Value = lstMainCoil.Tables[0].Rows[i]["Pelicula"].ToString();
                    dgvMainCoilList.Rows[i].Cells[pallet.Index].Value = lstMainCoil.Tables[0].Rows[i]["Pallet"].ToString();
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListCode.Index].Value = lstMainCoil.Tables[0].Rows[i]["Codigo"].ToString();
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListBatch.Index].Value = lstMainCoil.Tables[0].Rows[i]["Lote"].ToString();
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListwe.Index].Value = Math.Round(Convert.ToDouble(lstMainCoil.Tables[0].Rows[i]["PesoOriginal"]), 2);
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListmet.Index].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["MetrajeOriginal"]);
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListmetUsed.Index].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["MetrajeActual"]);
                    dgvMainCoilList.Rows[i].Cells[clmWidth.Index].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["Ancho"]);
                    dgvMainCoilList.Rows[i].Cells[clmWe.Index].Value = Convert.ToInt32(lstMainCoil.Tables[0].Rows[i]["PesoActual"]);
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListLabRating.Index].Value = lstMainCoil.Tables[0].Rows[i]["Calificacion"].ToString();
                    dgvMainCoilList.Rows[i].Cells[calidad.Index].Value = lstMainCoil.Tables[0].Rows[i]["Calidad"].ToString();
                    dgvMainCoilList.Rows[i].Cells[clmNotes.Index].Value = lstMainCoil.Tables[0].Rows[i]["Observaciones"].ToString();
                    dgvMainCoilList.Rows[i].Cells[Ubicacion.Index].Value = lstMainCoil.Tables[0].Rows[i]["Ubicacion"].ToString();
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListEndDate.Index].Value = lstMainCoil.Tables[0].Rows[i]["Fecha"].ToString();
                    dgvMainCoilList.Rows[i].Cells[clmMainCoilListClose.Index].Value = global::BPS.Properties.Resources.lock1;

                }
            }

        }
        private void frmMainCoilStock_Load(object sender, EventArgs e)
        {
            loadMainCoilList();
        }

        private void dgvMainCoilList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //List<clsFilter> lstFilter = new List<clsFilter>();
            //DataSet lstMainCoil = clsMainCoilMetal.getMainCoilMetalStock(planta.codsec);

            if (e.RowIndex >= 0)
            {

                //if (lstMainCoil.Tables.Count > 0 && lstMainCoil.Tables[0].Rows.Count > 0)
                //{
                    //for (int i = 0; i < lstMainCoil.Tables[0].Rows.Count; i++)
                    //{
                lblCode.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCode.Index].Value.ToString();
                lblFilmType.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListFilm.Index].Value.ToString();
                lblLotNumber.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListBatch.Index].Value.ToString();
                lblOriginalWeight.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListwe.Index].Value.ToString();
                lblOriginalMeters.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListmet.Index].Value.ToString();
                lblActualMeters.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListmetUsed.Index].Value.ToString();
                lblWidht.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmWidth.Index].Value.ToString();
                lblActualWeigth.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmWe.Index].Value.ToString();
                lblLabRanking.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListLabRating.Index].Value.ToString();
                lblNotes.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmNotes.Index].Value.ToString();
                lblDate.Text = dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListEndDate.Index].Value.ToString();
                    //}
                //}
            }
        }

        private void btnMainCoilClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            /*frmMainCoilStockReport winMainCoilStockReport = new frmMainCoilStockReport(objMachine.codsec);
            winMainCoilStockReport.StartPosition = FormStartPosition.Manual;
            winMainCoilStockReport.MdiParent = this.MdiParent;
            winMainCoilStockReport.Show();*/
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == clmMainCoilListClose.Index)
            {
                if (MessageBox.Show("Desea cerrar el rollo madre seleccionado?", "Stock de rollos madre", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    clsCoil objMainCoil = new clsCoil(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
                    objMainCoil.toChangeStatus(34);
                    MessageBox.Show("El rollo madre ha sido cerrado.", "Record de Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadMainCoilList();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
            dgvMainCoilList.SelectAll();
            DataObject dataObj = dgvMainCoilList.GetClipboardContent();
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
