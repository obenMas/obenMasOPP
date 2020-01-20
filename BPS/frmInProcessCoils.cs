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
    public partial class frmInProcessCoils : Form
    {
        DataSet DS = new DataSet();
        string film = string.Empty;
        string plant = string.Empty;
        string code = string.Empty;
        string lastChange = string.Empty;
        clsCoil coil = new clsCoil();


        public frmInProcessCoils()
        {
            InitializeComponent();
            getDataSet();
            populateDataGrid();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM  vwInProcessCoils");
        }

        public void populateDataGrid()
        {
            List<string> films = new List<string>();
            List<string> plants = new List<string>();
            List<string> codes = new List<string>();

            dgvInProcessCoils.Rows.Clear();
            
            if(lastChange != "code")
            {
                cmbCoilCodes.Items.Clear();
            }

            if (lastChange != "film")
            {
                cmbInProcessCoilsFilm.Items.Clear();
            }

            if (lastChange != "plant")
            {
               cmbPlant.Items.Clear();
            }

         
            dgvInProcessCoils.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {

                    string concat = code + plant + film;
                    string concat2 = string.Empty;

                    if (code != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Codigo"].ToString();
                    }

                    if (plant != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Planta"].ToString();
                    }

                    if (film != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Pelicula"].ToString();
                    }

                    if (concat == concat2)
                    {
                        dgvInProcessCoils.Rows.Add();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count -1].Cells[clmInProcessCoilCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["coil_codsec"]);
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessCode.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessProduct.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessFilm.Index].Value = DS.Tables[0].Rows[i]["Pelicula"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessCustomer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessLength.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Metraje"]);
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessWitdth.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Ancho"]), 2);
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessWeight.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]), 2);
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessObservations.Index].Value = DS.Tables[0].Rows[i]["Observaciones"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessDestination.Index].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessRework.Index].Value = DS.Tables[0].Rows[i]["Retrabajo"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessReworkDetail.Index].Value = DS.Tables[0].Rows[i]["DetalleRetrabajo"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count -1].Cells[clmInProcessUsefulWidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessFkuser.Index].Value = DS.Tables[0].Rows[i]["Usuario"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmInProcessRevisiondate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaRevisión"]);
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmDay.Index].Value = DS.Tables[0].Rows[i]["dayFechaRevision"];
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmMonth.Index].Value = DS.Tables[0].Rows[i]["monthFechaRevision"];
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmYear.Index].Value = DS.Tables[0].Rows[i]["yearFechaRevision"];
                        dgvInProcessCoils.Rows[dgvInProcessCoils.Rows.Count - 1].Cells[clmHour.Index].Value = DS.Tables[0].Rows[i]["Hora"];

                        if (!codes.Contains(DS.Tables[0].Rows[i]["Codigo"].ToString()))
                            codes.Add(DS.Tables[0].Rows[i]["Codigo"].ToString());
                        
                        if (!films.Contains(DS.Tables[0].Rows[i]["Pelicula"].ToString()))
                            films.Add(DS.Tables[0].Rows[i]["Pelicula"].ToString());

                        if (!plants.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                            plants.Add(DS.Tables[0].Rows[i]["Planta"].ToString());

                    }
                }
                codes.Sort();
                plants.Sort();
                films.Sort();

                if (lastChange != "code")
                {
                    for (int i = 0; i < codes.Count; i++)
                    {
                        cmbCoilCodes.Items.Add(codes[i]);
                    }
                }

                if (lastChange != "film")
                {
                    for (int i = 0; i < films.Count; i++)
                    {
                        cmbInProcessCoilsFilm.Items.Add(films[i]);
                    }
                }

                if (lastChange != "plant")
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        cmbPlant.Items.Add(plants[i]);
                    }
                }
            }
        }

        private void dgvInProcessCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                txtInProcessCode.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessCode.Index].Value.ToString();
                txtInProcessProduct.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessProduct.Index].Value.ToString();
                txtInProcessCustomer.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessCustomer.Index].Value.ToString();
                txtInProcessLength.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessLength.Index].Value.ToString();
                txtInProcessWitdth.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessWitdth.Index].Value.ToString();
                txtInProcessWeight.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessWeight.Index].Value.ToString();
                txtInProcessObservations.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessObservations.Index].Value.ToString();
                txtInProcessReworkDetail.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessReworkDetail.Index].Value.ToString();
                txtInProcessUsefulWidth.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessUsefulWidth.Index].Value.ToString();
                txtPlant.Text = dgvInProcessCoils.Rows[e.RowIndex].Cells[clmPlant.Index].Value.ToString();
                cmbInProcessDestination.SelectedIndex = -1;
                cmbInProcessRework.SelectedIndex = -1;

                for (int i = 0; i < cmbInProcessDestination.Items.Count; i++)
                {
                    if (cmbInProcessDestination.Items[i].ToString() == dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessDestination.Index].Value.ToString())
                    {
                        cmbInProcessDestination.SelectedIndex = i;
                    }
                }
                for (int i = 0; i < cmbInProcessRework.Items.Count; i++)
                {
                    if (cmbInProcessRework.Items[i].ToString() == dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessRework.Index].Value.ToString())
                    {
                        cmbInProcessRework.SelectedIndex = i;
                    }
                }
                coil = new clsCoil(Convert.ToInt32(dgvInProcessCoils.Rows[e.RowIndex].Cells[clmInProcessCoilCodsec.Index].Value));
            }
        }

        public void clearInProcessCoilsDetail()
        {
            txtInProcessCode.Text = string.Empty;
            txtInProcessProduct.Text = string.Empty;
            txtInProcessCustomer.Text = string.Empty;
            txtInProcessLength.Text = string.Empty;
            txtInProcessWitdth.Text = string.Empty;
            txtInProcessWeight.Text = string.Empty;
            txtInProcessObservations.Text = string.Empty;
            txtInProcessReworkDetail.Text = string.Empty;
            txtInProcessUsefulWidth.Text = string.Empty;
            cmbInProcessDestination.SelectedIndex = -1;
            cmbInProcessRework.SelectedIndex = -1;

        }

        public bool validateInProcessCoilsInfo()
        {
            bool flag = false;
            if (cmbInProcessDestination.SelectedIndex == -1)
            {
                flag = true;
            }
            if (cmbInProcessRework.SelectedIndex == -1)
            {
                flag = true;
            }
            if (txtInProcessUsefulWidth.Text == string.Empty)
            {
                flag = true;
            }
            if (cmbInProcessDestination.SelectedIndex == 1 && txtInProcessUsefulWidth.Text == "0")
            {
                flag = true;
            }

            return flag;
        }

        private void cmbInProcessDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbInProcessDestination.SelectedIndex)
            {
                case 0:
                    cmbInProcessRework.SelectedIndex = 0;
                    txtInProcessUsefulWidth.Text = txtInProcessWitdth.Text;
                    break;

                case 1:
                    txtInProcessUsefulWidth.Focus();
                    break;

                case 2:
                    cmbInProcessRework.SelectedIndex = 0;
                    txtInProcessUsefulWidth.Text = "0";
                    break;

            }
        }


        private void cmbInProcessCoilsFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInProcessCoilsFilm.SelectedIndex != -1)
            {
                if (film != cmbInProcessCoilsFilm.SelectedItem.ToString())
                {
                    film = cmbInProcessCoilsFilm.SelectedItem.ToString();
                    lastChange = "film";
                    populateDataGrid();
                }
            }
            else
            {
                film = string.Empty;
            }

        }

        private void cmbPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlant.SelectedIndex != -1)
            {
                if (plant != cmbPlant.SelectedItem.ToString())
                {
                    plant = cmbPlant.SelectedItem.ToString();
                    lastChange = "plant";
                    populateDataGrid();
                }
            }
            else
            {
                plant = string.Empty;
            }
        }


        private void cmbCoilCodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoilCodes.SelectedIndex != -1)
            {
                if (code != cmbCoilCodes.SelectedItem.ToString())
                {
                    code = cmbCoilCodes.SelectedItem.ToString();
                    lastChange = "code";
                    populateDataGrid();
                }
            }
            else
            {
                code = string.Empty;
            }

        }

        private void btnInProcessNoFilter_Click(object sender, EventArgs e)
        {
            code = string.Empty;
            plant = string.Empty;
            film = string.Empty;

           
            cmbCoilCodes.ResetText();
            cmbInProcessCoilsFilm.ResetText();
            cmbPlant.ResetText();

            cmbCoilCodes.SelectedIndex = -1;
            cmbInProcessCoilsFilm.SelectedIndex = -1;
            cmbPlant.SelectedIndex = -1;

            getDataSet();
            populateDataGrid();
        }

        #region Exportar a Excel

        private void btnInProcessCoilsExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvInProcessCoils.Columns["clmInProcessRevisiondate"].Visible = false;
            dgvInProcessCoils.Columns["clmDay"].Visible = true;
            dgvInProcessCoils.Columns["clmMonth"].Visible = true;
            dgvInProcessCoils.Columns["clmYear"].Visible = true;
            dgvInProcessCoils.Columns["clmHour"].Visible = true;
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

                // Format column D as text before pasting results, this was required for my data
                Excel.Range rng = xlWorkSheet.get_Range("M:M").Cells;
                rng.NumberFormat = "dd/MM/yyyy";

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
                dgvInProcessCoils.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);

                dgvInProcessCoils.Columns["clmInProcessRevisiondate"].Visible = true;
                dgvInProcessCoils.Columns["clmDay"].Visible = false;
                dgvInProcessCoils.Columns["clmMonth"].Visible = false;
                dgvInProcessCoils.Columns["clmYear"].Visible = false;
                dgvInProcessCoils.Columns["clmHour"].Visible = false;
            }
        }

        private void copyAlltoClipboard()
        {
            dgvInProcessCoils.SelectAll();
            DataObject dataObj = dgvInProcessCoils.GetClipboardContent();
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

        private void dgvInProcessCoils_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCoilEditor winCoil = new frmCoilEditor(Convert.ToInt32(dgvInProcessCoils.Rows[e.RowIndex].Cells["clmInProcessCoilCodsec"].Value), this);
            winCoil.StartPosition = FormStartPosition.CenterScreen;
            winCoil.Show();
        }

        private void cmbInProcessCoilsFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbInProcessCoilsFilm.ResetText();
                film = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbPlant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPlant.ResetText();
                plant = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbCoilCodes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCoilCodes.ResetText();
                code = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }
    }
}
