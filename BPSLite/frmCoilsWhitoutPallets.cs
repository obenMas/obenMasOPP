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
    public partial class frmCoilsWhitoutPallets : Form
    {
        DataSet DS = new DataSet();
        string lastChange = string.Empty;
        string code = string.Empty;
        string product = string.Empty;
        string custommer = string.Empty;
        string order = string.Empty;
        string quality = string.Empty;
        string cellar = string.Empty;
        string plant = string.Empty;

        public frmCoilsWhitoutPallets()
        {
            InitializeComponent();
            getDataSet();
            populateDataGrid();
        }

        public void getDataSet()
        {
            DS = clsConnection.getDataSetResult("SELECT * FROM vwCoilsWhitoutPallets WHERE Bodega='Conversión' OR Bodega='Corte, metalizado y empaque'");
        }

        public void populateDataGrid()
        {
            List<string> codes = new List<string>();
            List<string> products = new List<string>();
            List<string> custommers = new List<String>();
            List<int> orders = new List<int>();
            List<string> qualitys = new List<string>();
            List<string> cellars = new List<string>();
            List<string> plants = new List<string>();

            dgvCoilsWithoutPallets.Rows.Clear();

            if (lastChange != "code")
            {
                cmbCode.Items.Clear();
            }
            if (lastChange != "product")
            {
                cmbProduct.Items.Clear();
            }
            if (lastChange != "custommer")
            {
                cmbCustommer.Items.Clear();
            }
            if (lastChange != "order")
            {
                cmbOrder.Items.Clear();
            }
            if (lastChange != "quality")
            {
                cmbQuality.Items.Clear();
            }
            if (lastChange != "cellar")
            {
                cmbCellar.Items.Clear();
            }
            if (lastChange != "plant")
            {
                cmbPlant.Items.Clear();
            }

            dgvCoilsWithoutPallets.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = code + product + custommer + order + quality + cellar + plant;
                    string concat2 = string.Empty;
                    if (code != string.Empty)
                    {
                        concat2 = DS.Tables[0].Rows[i]["Codigo"].ToString();
                    }
                    if (product != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Producto"].ToString();
                    }
                    if (custommer != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Cliente"].ToString();
                    }
                    if (order != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Pedido"].ToString();
                    }
                    if (quality != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Calidad"].ToString();
                    }
                    if (cellar != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Bodega"].ToString();
                    }
                    if (plant != string.Empty)
                    {
                        concat2 += DS.Tables[0].Rows[i]["Planta"].ToString();
                    }

                    if (concat == concat2)
                    {
                        if (clsGlobal.LoggedUser.RoleName == "Supervisor Pilar" || clsGlobal.LoggedUser.RoleName == "Digitador Pilar")
                        {
                            if (DS.Tables[0].Rows[i]["Planta"].ToString() == "Pilar" && (DS.Tables[0].Rows[i]["Bodega"].ToString() != "Rack Metalizado"))
                            {
                                dgvCoilsWithoutPallets.Rows.Add();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCode.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmOrder.Index].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmNetWeight.Index].Value = DS.Tables[0].Rows[i]["PesoNeto"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmQuality.Index].Value = DS.Tables[0].Rows[i]["Calidad"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCutDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaCorte"]).ToString("dd/MM/yyyy");
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCellar.Index].Value = DS.Tables[0].Rows[i]["Bodega"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmDestination.Index].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmProcess.Index].Value = DS.Tables[0].Rows[i]["Reproceso"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmUsefulwidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmDetail.Index].Value = DS.Tables[0].Rows[i]["Observación"].ToString();

                                if (!codes.Contains(DS.Tables[0].Rows[i]["Codigo"].ToString()))
                                    codes.Add(DS.Tables[0].Rows[i]["Codigo"].ToString());

                                if (!products.Contains(DS.Tables[0].Rows[i]["Producto"].ToString()))
                                    products.Add((DS.Tables[0].Rows[i]["Producto"].ToString()));

                                if (!custommers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                                    custommers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());

                                if (!orders.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"])))
                                    orders.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]));

                                if (!qualitys.Contains(DS.Tables[0].Rows[i]["Calidad"].ToString()))
                                    qualitys.Add((DS.Tables[0].Rows[i]["Calidad"].ToString()));


                                if (!cellars.Contains(DS.Tables[0].Rows[i]["Bodega"].ToString()))
                                    cellars.Add(DS.Tables[0].Rows[i]["Bodega"].ToString());

                                if (!plants.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                                    plants.Add(DS.Tables[0].Rows[i]["Planta"].ToString());

                            }
                        }
                        else
                        {
                            if (clsGlobal.LoggedUser.RoleName == "Supervisor de corte" || clsGlobal.LoggedUser.RoleName == "Digitador de corte" || clsGlobal.LoggedUser.RoleName == "Operadores de corte" || clsGlobal.LoggedUser.RoleName == "Operadores de corte C230" || clsGlobal.LoggedUser.RoleName == "Operadores de corte C231" || clsGlobal.LoggedUser.RoleName == "Operadores de corte C232")
                            {
                                if (DS.Tables[0].Rows[i]["Planta"].ToString() == "Campana" && (DS.Tables[0].Rows[i]["Bodega"].ToString() != "Bobinas Base y Metalizado"))
                                {
                                    dgvCoilsWithoutPallets.Rows.Add();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCode.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmOrder.Index].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmNetWeight.Index].Value = DS.Tables[0].Rows[i]["PesoNeto"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmQuality.Index].Value = DS.Tables[0].Rows[i]["Calidad"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCutDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaCorte"]).ToString("dd/MM/yyyy");
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCellar.Index].Value = DS.Tables[0].Rows[i]["Bodega"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmDestination.Index].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmProcess.Index].Value = DS.Tables[0].Rows[i]["Reproceso"].ToString();
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmUsefulwidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                                    dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmDetail.Index].Value = DS.Tables[0].Rows[i]["Observación"].ToString();

                                    if (!codes.Contains(DS.Tables[0].Rows[i]["Codigo"].ToString()))
                                        codes.Add(DS.Tables[0].Rows[i]["Codigo"].ToString());

                                    if (!products.Contains(DS.Tables[0].Rows[i]["Producto"].ToString()))
                                        products.Add((DS.Tables[0].Rows[i]["Producto"].ToString()));

                                    if (!custommers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                                        custommers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());

                                    if (!orders.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"])))
                                        orders.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]));

                                    if (!qualitys.Contains(DS.Tables[0].Rows[i]["Calidad"].ToString()))
                                        qualitys.Add((DS.Tables[0].Rows[i]["Calidad"].ToString()));


                                    if (!cellars.Contains(DS.Tables[0].Rows[i]["Bodega"].ToString()))
                                        cellars.Add(DS.Tables[0].Rows[i]["Bodega"].ToString());

                                    if (!plants.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                                        plants.Add(DS.Tables[0].Rows[i]["Planta"].ToString());
                                }
                                
                            }
                            else
                            {
                                dgvCoilsWithoutPallets.Rows.Add();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCode.Index].Value = DS.Tables[0].Rows[i]["Codigo"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["Producto"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCustommer.Index].Value = DS.Tables[0].Rows[i]["Cliente"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmOrder.Index].Value = DS.Tables[0].Rows[i]["Pedido"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmNetWeight.Index].Value = DS.Tables[0].Rows[i]["PesoNeto"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmQuality.Index].Value = DS.Tables[0].Rows[i]["Calidad"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCutDate.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["FechaCorte"]).ToString("dd/MM/yyyy");
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmCellar.Index].Value = DS.Tables[0].Rows[i]["Bodega"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmPlant.Index].Value = DS.Tables[0].Rows[i]["Planta"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmDestination.Index].Value = DS.Tables[0].Rows[i]["Destino"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmProcess.Index].Value = DS.Tables[0].Rows[i]["Reproceso"].ToString();
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmUsefulwidth.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["AnchoUtil"]);
                                dgvCoilsWithoutPallets.Rows[dgvCoilsWithoutPallets.Rows.Count - 1].Cells[clmDetail.Index].Value = DS.Tables[0].Rows[i]["Observación"].ToString();

                                if (!codes.Contains(DS.Tables[0].Rows[i]["Codigo"].ToString()))
                                    codes.Add(DS.Tables[0].Rows[i]["Codigo"].ToString());

                                if (!products.Contains(DS.Tables[0].Rows[i]["Producto"].ToString()))
                                    products.Add((DS.Tables[0].Rows[i]["Producto"].ToString()));

                                if (!custommers.Contains(DS.Tables[0].Rows[i]["Cliente"].ToString()))
                                    custommers.Add(DS.Tables[0].Rows[i]["Cliente"].ToString());

                                if (!orders.Contains(Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"])))
                                    orders.Add(Convert.ToInt32(DS.Tables[0].Rows[i]["Pedido"]));

                                if (!qualitys.Contains(DS.Tables[0].Rows[i]["Calidad"].ToString()))
                                    qualitys.Add((DS.Tables[0].Rows[i]["Calidad"].ToString()));


                                if (!cellars.Contains(DS.Tables[0].Rows[i]["Bodega"].ToString()))
                                    cellars.Add(DS.Tables[0].Rows[i]["Bodega"].ToString());

                                if (!plants.Contains(DS.Tables[0].Rows[i]["Planta"].ToString()))
                                    plants.Add(DS.Tables[0].Rows[i]["Planta"].ToString());
                            }
                        }
                    }
                }

                codes.Sort();
                products.Sort();
                custommers.Sort();
                orders.Sort();
                qualitys.Sort();
                cellars.Sort();
                plants.Sort();

                if (lastChange != "code")
                {
                    for (int i = 0; i < codes.Count; i++)
                    {
                        cmbCode.Items.Add(codes[i]);
                    }
                }

                if (lastChange != "product")
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                       cmbProduct.Items.Add(products[i]);
                    }
                }

                if (lastChange != "custommer")
                {
                    for (int i = 0; i < custommers.Count; i++)
                    {
                        cmbCustommer.Items.Add(custommers[i]);
                    }
                }

                if (lastChange != "order")
                {
                    for (int i = 0; i < orders.Count; i++)
                    {
                        cmbOrder.Items.Add(orders[i]);
                    }
                }

                if (lastChange != "quality")
                {
                    for (int i = 0; i < qualitys.Count; i++)
                    {
                        cmbQuality.Items.Add(qualitys[i]);
                    }
                }

                if (lastChange != "cellar")
                {
                    for (int i = 0; i < cellars.Count; i++)
                    {
                        cmbCellar.Items.Add(cellars[i]);
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

        private void cmbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCode.SelectedIndex != -1)
            {
                if (code != cmbCode.SelectedItem.ToString())
                {
                    code = cmbCode.SelectedItem.ToString();
                    lastChange = "code";
                    populateDataGrid();
                }
            }
            else
            {
                code = string.Empty;
            }
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex != -1)
            {
                if (product != cmbProduct.SelectedItem.ToString())
                {
                    product = cmbProduct.SelectedItem.ToString();
                    lastChange = "product";
                    populateDataGrid();
                }
            }
            else
            {
                product = string.Empty;
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

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedIndex != -1)
            {
                if (order != cmbOrder.SelectedItem.ToString())
                {
                    order = cmbOrder.SelectedItem.ToString();
                    lastChange = "order";
                    populateDataGrid();
                }
            }
            else
            {
                order = string.Empty;
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

        private void cmbCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCode.ResetText();
                code = string.Empty;
                lastChange = string.Empty;
                populateDataGrid();
            }
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbProduct.ResetText();
                product = string.Empty;
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

        private void cmbOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrder.ResetText();
                order = string.Empty;
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

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            code = string.Empty;
            product = string.Empty;
            custommer = string.Empty;
            order = string.Empty;
            quality = string.Empty;
            cellar = string.Empty;
            plant = string.Empty;

            getDataSet();
            populateDataGrid();

            cmbCode.ResetText();
            cmbProduct.ResetText();
            cmbCustommer.ResetText();
            cmbOrder.ResetText();
            cmbQuality.ResetText();
            cmbCellar.ResetText();
            cmbPlant.ResetText();

            cmbCode.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            cmbCustommer.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            cmbQuality.SelectedIndex = -1;
            cmbCellar.SelectedIndex = -1;
            cmbPlant.SelectedIndex = -1;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvCoilsWithoutPallets.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

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
                dgvCoilsWithoutPallets.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvCoilsWithoutPallets.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvCoilsWithoutPallets.SelectAll();
            DataObject dataObj = dgvCoilsWithoutPallets.GetClipboardContent();
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

