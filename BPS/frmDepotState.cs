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
    public partial class frmDepotState : Form
    {
        DataSet DS = new DataSet();
        string plant = string.Empty;
        string pallet = string.Empty;
        string film = string.Empty;
        string width = string.Empty;
        string diameter = string.Empty;
        string core = string.Empty;
        string cellar = string.Empty;
        string origin = string.Empty;
        string saleorder = string.Empty;
        string custommer = string.Empty;
        string lotnumber = string.Empty;
        string quality = string.Empty;
        string lastChange = string.Empty;

        public frmDepotState()
        {
            InitializeComponent();
            getDataSet();
            populateDataGrid();

        }
        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("CALL spDepotState");
        }

        #region PopulateDGV
        public void populateDataGrid()
        {
            List<string> plants = new List<string>();
            List<string> pallets = new List<string>();
            List<string> films = new List<string>();
            List<double> widths = new List<double>();
            List<string> diameters = new List<string>();
            List<int> cores = new List<int>();
            List<string> cellars = new List<string>();
            List<int> salesorder = new List<int>();
            List<string> origins = new List<string>();
            List<string> customers = new List<string>();
            List<string> lotsnumber = new List<string>();
            List<string> qualitys = new List<string>();
            double PalletsQuantity = 0;
            double TotalWeight = 0;

            dgvDepotState.Rows.Clear();
            if (lastChange != "plant")
            {
                cmbPlant.Items.Clear();
            }
            if (lastChange != "pallet")
            {
                cmbPalletCode.Items.Clear();
            }
            if (lastChange != "film")
            {
                cmbFilm.Items.Clear();
            }
            if (lastChange != "width")
            {
                cmbWidth.Items.Clear();
            }
            if (lastChange != "diameter")
            {
                cmbDiameter.Items.Clear();
            }
            if (lastChange != "core")
            {
                cmbCore.Items.Clear();
            }
            if (lastChange != "cellar")
            {
                cmbCellar.Items.Clear();
            }
            if (lastChange != "origin")
            {
                cmbOrigin.Items.Clear();
            }
            if (lastChange != "saleorder")
            {
                cmbOrder.Items.Clear();
            }
            if (lastChange != "custommer")
            {
                cmbCustommer.Items.Clear();
            }
            if (lastChange != "lotnumber")
            {
                cmbLotNumber.Items.Clear();
            }
            if (lastChange != "quality")
            {
                cmbQuality.Items.Clear();
            }

            dgvDepotState.Rows.Clear();
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = plant + pallet + film + width + diameter + core + cellar + origin + saleorder + custommer + lotnumber + quality;
                    string concat2 = string.Empty;

                    if (plant != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_plant"].ToString();
                    }
                    if (pallet != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_code"].ToString();
                    }
                    if (film != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_productCode"].ToString();
                    }
                    if (width != string.Empty)
                    {
                        concat2 += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_productWidth"]), 2).ToString();
                    }
                    if (diameter != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_productAbbreviation"].ToString();
                    }
                    if (core != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_productCore"].ToString();
                    }
                    if (cellar != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                    }
                    if (origin != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_origin"].ToString();
                    }
                    if (saleorder != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString();
                    }
                    if (custommer != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                    }
                    if (lotnumber != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                    }
                    if (quality != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["plt_Quality"].ToString();
                    }

                    if (concat == concat2)
                    {
                        dgvDepotState.Rows.Add();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmPalletCodsec"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_codsec"]);
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmPlant"].Value = DS.Tables[0].Rows[i]["plt_Plant"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmCode"].Value = DS.Tables[0].Rows[i]["plt_code"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmFilm"].Value = DS.Tables[0].Rows[i]["plt_productCode"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmWidth"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_productWidth"]);
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmDiameter"].Value = DS.Tables[0].Rows[i]["plt_productAbbreviation"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmCore"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_productCore"]);
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmNetWeight"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]), 2);
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmOrigin"].Value = DS.Tables[0].Rows[i]["plt_origin"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmSalesOrder"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_salesOrderNumber"]);
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmCustomer"].Value = DS.Tables[0].Rows[i]["plt_customerName"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmLotNumber"].Value = DS.Tables[0].Rows[i]["plt_lotNumber"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmCellar"].Value = DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmCoilsNumber"].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["plt_coilCount"]);
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmCuttingDate"].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["plt_CuttigDate"]).ToString("dd/MM/yyyy");
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmPosition"].Value = DS.Tables[0].Rows[i]["plt_position"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmQuality"].Value = DS.Tables[0].Rows[i]["plt_Quality"].ToString();
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmGrossWeight"].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_grossWeight"]), 2);
                        //Agregado para los excels
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmDay"].Value = DS.Tables[0].Rows[i]["dayCorte"];
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmMonth"].Value = DS.Tables[0].Rows[i]["monthCorte"];
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmYear"].Value = DS.Tables[0].Rows[i]["yearCorte"];
                        dgvDepotState.Rows[dgvDepotState.Rows.Count - 1].Cells["clmHour"].Value = DS.Tables[0].Rows[i]["Hora"];

                        PalletsQuantity += 1;
                        TotalWeight += Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_netWeight"]), 2);

                        if (!plants.Contains(DS.Tables[0].Rows[i]["plt_plant"].ToString()))
                            plants.Add(DS.Tables[0].Rows[i]["plt_plant"].ToString());

                        if (!pallets.Contains(DS.Tables[0].Rows[i]["plt_code"].ToString()))
                            pallets.Add(DS.Tables[0].Rows[i]["plt_code"].ToString());

                        if (!films.Contains(DS.Tables[0].Rows[i]["plt_productCode"].ToString()))
                            films.Add(DS.Tables[0].Rows[i]["plt_productCode"].ToString());

                        if (!widths.Contains(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_productWidth"])))
                            widths.Add(Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["plt_productWidth"].ToString()), 2));

                        if (!diameters.Contains(DS.Tables[0].Rows[i]["plt_productAbbreviation"].ToString()))
                            diameters.Add(DS.Tables[0].Rows[i]["plt_productAbbreviation"].ToString());

                        if (!cores.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_productCore"])))
                            cores.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_productCore"].ToString()));

                        if (!cellars.Contains(DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString()))
                            cellars.Add(DS.Tables[0].Rows[i]["plt_coilCellarName"].ToString());

                        if (!origins.Contains(DS.Tables[0].Rows[i]["plt_origin"].ToString()))
                            origins.Add(DS.Tables[0].Rows[i]["plt_origin"].ToString());

                        if (!salesorder.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_salesOrderNumber"])))
                            salesorder.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["plt_salesOrderNumber"].ToString()));

                        if (!customers.Contains(DS.Tables[0].Rows[i]["plt_customerName"].ToString()))
                            customers.Add(DS.Tables[0].Rows[i]["plt_customerName"].ToString());

                        if (!lotsnumber.Contains(DS.Tables[0].Rows[i]["plt_lotNumber"].ToString()))
                            lotsnumber.Add(DS.Tables[0].Rows[i]["plt_lotNumber"].ToString());

                        if (!qualitys.Contains(DS.Tables[0].Rows[i]["plt_Quality"].ToString()))
                            qualitys.Add(DS.Tables[0].Rows[i]["plt_Quality"].ToString());
                    }

                }

                //Orden de listas de combobox

                plants.Sort();
                pallets.Sort();
                films.Sort();
                widths.Sort();
                diameters.Sort();
                cores.Sort();
                cellars.Sort();
                salesorder.Sort();
                origins.Sort();
                customers.Sort();
                lotsnumber.Sort();
                qualitys.Sort();

                //Completar los items de los combobox

                if (lastChange != "plant")
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        cmbPlant.Items.Add(plants[i]);
                    }
                }

                if (lastChange != "pallet")
                {
                    for (int i = 0; i < pallets.Count; i++)
                    {
                        cmbPalletCode.Items.Add(pallets[i]);
                    }
                }

                if (lastChange != "film")
                {
                    for (int i = 0; i < films.Count; i++)
                    {
                        cmbFilm.Items.Add(films[i]);
                    }
                }

                if (lastChange != "width")
                {
                    for (int i = 0; i < widths.Count; i++)
                    {
                        cmbWidth.Items.Add(widths[i]);
                    }
                }

                if (lastChange != "diameter")
                {
                    for (int i = 0; i < diameters.Count; i++)
                    {
                        cmbDiameter.Items.Add(diameters[i]);
                    }
                }

                if (lastChange != "core")
                {
                    for (int i = 0; i < cores.Count; i++)
                    {
                        cmbCore.Items.Add(cores[i]);
                    }
                }

                if (lastChange != "cellar")
                {
                    for (int i = 0; i < cellars.Count; i++)
                    {
                        cmbCellar.Items.Add(cellars[i]);
                    }
                }
                if (lastChange != "saleorder")
                {
                    for (int i = 0; i < salesorder.Count; i++)
                    {
                        cmbOrder.Items.Add(salesorder[i]);
                    }
                }

                if (lastChange != "origin")
                {
                    for (int i = 0; i < origins.Count; i++)
                    {
                        cmbOrigin.Items.Add(origins[i]);
                    }
                }

                if (lastChange != "custommer")
                {
                    for (int i = 0; i < customers.Count; i++)
                    {
                        cmbCustommer.Items.Add(customers[i]);
                    }
                }

                if (lastChange != "lotnumber")
                {
                    for (int i = 0; i < lotsnumber.Count; i++)
                    {
                        cmbLotNumber.Items.Add(lotsnumber[i]);
                    }
                }

                if (lastChange != "quality")
                {
                    for (int i = 0; i < qualitys.Count; i++)
                    {
                        cmbQuality.Items.Add(qualitys[i]);
                    }
                }
            }
            txtPalletQuantity.Text = PalletsQuantity.ToString();
            txtWeight.Text = Math.Round(Convert.ToDouble(TotalWeight),2).ToString();
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

        private void cmbPalletCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPalletCode.SelectedIndex != -1)
            {
                if (pallet != cmbPalletCode.SelectedItem.ToString())
                {
                    pallet = cmbPalletCode.SelectedItem.ToString();
                    lastChange = "pallet";
                    populateDataGrid();
                }
            }
            else
            {
                pallet = string.Empty;
            }
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedIndex != -1)
            {
                if (film != cmbFilm.SelectedItem.ToString())
                {
                    film = cmbFilm.SelectedItem.ToString();
                    lastChange = "film";
                    populateDataGrid();
                }
            }
            else
            {
                film = string.Empty;
            }
        }

        private void cmbWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWidth.SelectedIndex != -1)
            {
                if (width != cmbWidth.SelectedItem.ToString())
                {
                    width = cmbWidth.SelectedItem.ToString();
                    lastChange = "width";
                    populateDataGrid();
                }
            }
            else
            {
                width = string.Empty;
            }
        }

        private void cmbDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDiameter.SelectedIndex != -1)
            {
                if (diameter != cmbDiameter.SelectedItem.ToString())
                {
                    diameter = cmbDiameter.SelectedItem.ToString();
                    lastChange = "diameter";
                    populateDataGrid();
                }
            }
            else
            {
                diameter = string.Empty;
            }
        }

        private void cmbCore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCore.SelectedIndex != -1)
            {
                if (core != cmbCore.SelectedItem.ToString())
                {
                    core = cmbCore.SelectedItem.ToString();
                    lastChange = "core";
                    populateDataGrid();
                }
            }
            else
            {
                core = string.Empty;
            }
        }

        private void cmbCellar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCellar.SelectedIndex != -1)
            {
                if (cellar != cmbCellar.SelectedItem.ToString())
                {
                    cellar = cmbCellar.SelectedItem.ToString();
                    lastChange = "cellar";
                    populateDataGrid();
                }
            }
            else
            {
                cellar = string.Empty;
            }
        }

        private void cmbOrigin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigin.SelectedIndex != -1)
            {
                if (origin != cmbOrigin.SelectedItem.ToString())
                {
                    origin = cmbOrigin.SelectedItem.ToString();
                    lastChange = "origin";
                    populateDataGrid();
                }
            }
            else
            {
                origin = string.Empty;
            }
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedIndex != -1)
            {
                if (saleorder != cmbOrder.SelectedItem.ToString())
                {
                    saleorder = cmbOrder.SelectedItem.ToString();
                    lastChange = "saleorder";
                    populateDataGrid();
                }
            }
            else
            {
                saleorder = string.Empty;
            }
        }

        private void cmbCustommer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustommer.SelectedIndex != -1)
            {
                if (custommer != cmbCustommer.SelectedItem.ToString())
                {
                    custommer = cmbCustommer.SelectedItem.ToString();
                    lastChange = "custommer";
                    populateDataGrid();
                }
            }
            else
            {
                custommer = string.Empty;
            }
        }

        private void cmbLotNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLotNumber.SelectedIndex != -1)
            {
                if (lotnumber != cmbLotNumber.SelectedItem.ToString())
                {
                    lotnumber = cmbLotNumber.SelectedItem.ToString();
                    lastChange = "lotnumber";
                    populateDataGrid();
                }
            }
            else
            {
                lotnumber = string.Empty;
            }
        }

        private void cmbQuality_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuality.SelectedIndex != -1)
            {
                if (quality != cmbQuality.SelectedItem.ToString())
                {
                    quality = cmbQuality.SelectedItem.ToString();
                    lastChange = "quality";
                    populateDataGrid();
                }
            }
            else
            {
                quality = string.Empty;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            plant = string.Empty;
            pallet = string.Empty;
            film = string.Empty;
            width = string.Empty;
            diameter = string.Empty;
            core = string.Empty;
            cellar = string.Empty;
            origin = string.Empty;
            saleorder = string.Empty;
            custommer = string.Empty;
            lotnumber = string.Empty;
            quality = string.Empty;

            getDataSet();
            populateDataGrid();

            cmbPlant.ResetText();
            cmbPalletCode.ResetText();
            cmbFilm.ResetText();
            cmbWidth.ResetText();
            cmbDiameter.ResetText();
            cmbCore.ResetText();
            cmbCellar.ResetText();
            cmbOrigin.ResetText();
            cmbOrder.ResetText();
            cmbCustommer.ResetText();
            cmbLotNumber.ResetText();
            cmbQuality.ResetText();

            cmbPlant.SelectedIndex = -1;
            cmbPalletCode.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            cmbWidth.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            cmbCore.SelectedIndex = -1;
            cmbCellar.SelectedIndex = -1;
            cmbOrigin.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbCustommer.SelectedIndex = -1;
            cmbLotNumber.SelectedIndex = -1;
            cmbQuality.SelectedIndex = -1;
        }
        #endregion

        #region Exportar a Excel

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvDepotState.Columns["clmLotNumber"].Visible = true;
            dgvDepotState.Columns["clmGrossWeight"].Visible = true;
            dgvDepotState.Columns["clmDay"].Visible = true;
            dgvDepotState.Columns["clmMonth"].Visible = true;
            dgvDepotState.Columns["clmYear"].Visible = true;
            dgvDepotState.Columns["clmHour"].Visible = true;
            dgvDepotState.Columns["clmCuttingDate"].Visible = false;

            dgvDepotState.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
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
                dgvDepotState.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            dgvDepotState.Columns["clmLotNumber"].Visible = false;
            dgvDepotState.Columns["clmGrossWeight"].Visible = false;
            dgvDepotState.Columns["clmDay"].Visible = false;
            dgvDepotState.Columns["clmMonth"].Visible = false;
            dgvDepotState.Columns["clmYear"].Visible = false;
            dgvDepotState.Columns["clmHour"].Visible = false;
            dgvDepotState.Columns["clmCuttingDate"].Visible = true;

            dgvDepotState.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvDepotState.SelectAll();
            DataObject dataObj = dgvDepotState.GetClipboardContent();
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

        #region Eventos del Formulario
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

        private void cmbPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPalletCode.ResetText();
                pallet = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbFilm.ResetText();
                film = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbWidth.ResetText();
                width = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbDiameter.ResetText();
                diameter = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbCore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCore.ResetText();
                core = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCellar.ResetText();
                cellar = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbOrigin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrigin.ResetText();
                origin = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrder.ResetText();
                saleorder = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbCustommer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCustommer.ResetText();
                custommer = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbLotNumber.ResetText();
                lotnumber = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbQuality_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbQuality.ResetText();
                quality = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void btnCoilsDetail_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet DS = new DataSet();
                if (chkExportNotes.Checked)
                {
                    DS = clsConnection.getDataSetResult("SELECT * from vwdepownote;");
                    DataTable DT = new DataTable();
                }
                else
                {
                    DS = clsConnection.getDataSetResult("SELECT * from vwdepo;");
                }               
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Estado de Deposito - Bobinas";

                for (int i = 1; i < DS.Tables[0].Columns.Count + 1; i++)
                    worksheet.Cells[1, i] = DS.Tables[0].Columns[i - 1].ToString();

                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    for (int j = 0; j < DS.Tables[0].Columns.Count; j++)
                    {
                        if (DS.Tables[0].Rows[i][j].ToString() != null)
                            worksheet.Cells[i + 2, j + 1] = DS.Tables[0].Rows[i][j].ToString();
                    }
                }
                MessageBox.Show("Exportación Generada correctamente", "Estado de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Estado de Deposito - Bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
