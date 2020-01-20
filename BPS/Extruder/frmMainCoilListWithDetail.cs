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


namespace BPS
{
    public partial class frmMainCoilListWithDetail : Form
    {
        public frmMainCoilListWithDetail()
        {
            InitializeComponent();
        }

        private void btnMainCoilClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loadMainCoilList()
        {
            List<clsMainCoil> lstMainCoil = new List<clsMainCoil>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (chkFilm.Checked || chkLotNumber.Checked || chkDateRange.Checked)
            {

                if (cmbMainCoilListFilm.SelectedIndex >= 0)
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mcl_fkBopp";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = ((clsBopp)cmbMainCoilListFilm.SelectedItem).codsec.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                }
                if (cmbMainCoilListBatch.SelectedIndex >= 0)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mcl_lotNumber";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = cmbMainCoilListBatch.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (chkDateRange.Checked)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mcl_initDate";
                    lstFilter[lstFilter.Count - 1].operation = "between";
                    lstFilter[lstFilter.Count - 1].value = dtpMainCoilInitDate.Value.ToString("dd/MM/yyyy HH:mm");
                    lstFilter[lstFilter.Count - 1].value2 = dtpMainCoilFinishedDate.Value.ToString("dd/MM/yyyy HH:mm");
                    lstFilter[lstFilter.Count - 1].dataType = "dateTime";
                }

                lstMainCoil = clsMainCoil.getBoppMainCoilListByFilter(lstFilter);
            }
            else if (txtMainCoilCode.Text != "")
            {

                if (txtMainCoilCode.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "mcl_code";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = txtMainCoilCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstMainCoil = clsMainCoil.getBoppMainCoilListByFilter(lstFilter);
            }
            else
            {
                lstMainCoil = clsMainCoil.getActiveBoppMainCoilList();
            }

            dgvMainCoilList.Rows.Clear();

            for (int i = 0; i < lstMainCoil.Count; i++)
            {
                dgvMainCoilList.Rows.Add();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListCodsec"].Value = lstMainCoil[i].codsec.ToString();
                if (lstMainCoil[i].fkBopp != 0)
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListFilm"].Value = lstMainCoil[i].BoppCode.ToString();
                else
                    dgvMainCoilList.Rows[i].Cells["clmMainCoilListFilm"].Value = lstMainCoil[i].CastCode.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListCode"].Value = lstMainCoil[i].code.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListBatch"].Value = lstMainCoil[i].lotNumber.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListWe"].Value = lstMainCoil[i].netWeigth.ToString();
                //dgvMainCoilList.Rows[i].Cells["clmMainCoilListProductionOrder"].Value = lstMainCoil[i].ProductionOrderNumber.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListLabRating"].Value = lstMainCoil[i].labRating.ToString();
                //dgvMainCoilList.Rows[i].Cells["clmMainCoilListAnalistRating"].Value = lstMainCoil[i].analistRating.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListInitDate"].Value = lstMainCoil[i].initDate.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListEndDate"].Value = lstMainCoil[i].endDate.ToString();
                dgvMainCoilList.Rows[i].Cells["clmMainCoilListCore"].Value = lstMainCoil[i].core.ToString();

            }
        }
        private void frmMainCoilListWithDetail_Load(object sender, EventArgs e)
        {
            List<clsBopp> lstBoppFilm = new List<clsBopp>();
            lstBoppFilm = clsBopp.getSimplifiedList();
            cmbMainCoilListFilm.Items.Clear();
            for (int i = 0; i < lstBoppFilm.Count; i++)
                cmbMainCoilListFilm.Items.Add(lstBoppFilm[i]);

            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();
            lstFilmProductionPlan = clsFilmProductionPlan.getListByLotNumeber();
            cmbMainCoilListBatch.Items.Clear();
            for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                cmbMainCoilListBatch.Items.Add(lstFilmProductionPlan[i]);

            loadMainCoilList();
        }

        private void dgvMainCoilList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsMainCoil objMainCoil = new clsMainCoil(Convert.ToInt32(dgvMainCoilList.Rows[e.RowIndex].Cells[clmMainCoilListCodsec.Index].Value));
            List<clsFormulationByFilmProductionPlan> lstFormulations = clsFormulationByFilmProductionPlan.getListByFilmProductionPlan(objMainCoil.fkFilmProductionPlan);

            lblOrderNumber.Text = objMainCoil.ProductionOrderNumber.ToString();
            lblFilmType.Text = objMainCoil.BoppCode;
            lblCode.Text = objMainCoil.code;
            lblInitDate.Text = objMainCoil.initDate.ToString("dd/MM/yyyy HH:mm:ss");
            lblEndDate.Text = objMainCoil.endDate.ToString("dd/MM/yyyy HH:mm:ss");
            lblFormulation.Text = lstFormulations[objMainCoil.variation].formulationName;
            lblKgPerHour.Text = Math.Round(objMainCoil.productionKgHr, 2).ToString();
            lblVelocity.Text = Math.Round(objMainCoil.velocity, 2).ToString();
            lblGramaje.Text = Math.Round(objMainCoil.gramaje, 2).ToString();
            lblLength.Text = Math.Round(objMainCoil.grosslength, 2).ToString();
            lblWidht.Text = objMainCoil.width.ToString();
            lblWeight.Text = Math.Round(objMainCoil.grossWeigth, 2).ToString();
            lblNetLength.Text = Math.Round(objMainCoil.netlength, 2).ToString();
            lblNetWeigth.Text = Math.Round(objMainCoil.netWeigth, 2).ToString();
            lblNotes.Text = objMainCoil.notes;
            lblLabRanking.Text = objMainCoil.labRating;

        }

        private void chkFilm_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFilm.Checked)
                grpbMainCoilFilm.Enabled = true;
            else
            {
                grpbMainCoilFilm.Enabled = false;
                cmbMainCoilListFilm.SelectedIndex = -1;
            }
        }

        private void chkLotNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLotNumber.Enabled)
                grpbMainCoilBatch.Enabled = true;
            else
            {
                grpbMainCoilBatch.Enabled = false;
                cmbMainCoilListBatch.SelectedIndex = -1;
            }
        }

        private void chkDateRange_CheckedChanged(object sender, EventArgs e)
        {
            grpbMainCoilDate.Enabled = chkDateRange.Enabled;
        }

        private void btnMainCoilFilters_Click(object sender, EventArgs e)
        {
            loadMainCoilList();
        }

        private void btnMainCoilClearFilters_Click(object sender, EventArgs e)
        {
            chkLotNumber.Checked = false;
            chkFilm.Checked = false;
            chkDateRange.Checked = false;

            txtMainCoilCode.Text = "";

            loadMainCoilList();
        }

        private void txtMainCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadMainCoilList();
            }
        }

        private void btnMainCoilAccept_Click(object sender, EventArgs e)
        {

        }

        private void cmbMainCoilListFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsBopp> lstBoppFilm = clsBopp.getSimplifiedList();
                cmbMainCoilListFilm.Items.Clear();
                for (int i = 0; i < lstBoppFilm.Count; i++)
                    cmbMainCoilListFilm.Items.Add(lstBoppFilm[i]); 
            }
        }

        private void cmbMainCoilListBatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getListByLotNumeber();
                cmbMainCoilListBatch.Items.Clear();
                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                    cmbMainCoilListBatch.Items.Add(lstFilmProductionPlan[i]); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string ext = string.Empty;
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
            
            
            /*try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Stock de bobinas madre";

                for (int i = 2; i < dgvMainCoilList.Columns.Count + 1; i++)
                    worksheet.Cells[1, i-1] = dgvMainCoilList.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvMainCoilList.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvMainCoilList.Columns.Count; j++)
                    {
                        if (dgvMainCoilList.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j] = dgvMainCoilList.Rows[i].Cells[j].Value.ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Stock de bobinas madre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Stock de bobinas madre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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


