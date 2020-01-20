using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using Excel = Microsoft.Office.Interop.Excel;  //Supongo, que importa algo para exportar a excel.
using System.IO;

namespace BPS
{
    public partial class frmPalletRawMaterialStock : Form
    {
        List<clsRawMaterialPallet> listaStock = new List<clsRawMaterialPallet>();

        string codigo = string.Empty;
        string tipoMaterial = string.Empty;
        string bodega = string.Empty;
        string planta = string.Empty;
        string codigoMaterial = string.Empty;
    

        string lastChange = string.Empty;

        public frmPalletRawMaterialStock()
        {
            InitializeComponent();
        }
       
        private void frmPalletRawMaterialStock_Load(object sender, EventArgs e)
        {
            getList();
            populateDgv();
        }
    

        public void getList()
        { //Dudo que este formulario se siga usando. seguramente hay q hacerlo morir.
            listaStock = clsRawMaterialPallet.getStockInCoilCellarByPlantForRaw();
        }

        public void populateDgv()
        {
            List<string> codigos = new List<string>();
            List<string> tipoMaterials = new List<string>();
            List<string> bodegas = new List<string>();
            List<string> plantas = new List<string>();
            List<string> codigosMaterial = new List<string>();
          

            clsRawPalletByCoilCellar fkbodegaRaw = new clsRawPalletByCoilCellar();
            clsCoilCellar bodegaRaw = new clsCoilCellar();
            clsPlant plant = new clsPlant();

            double pesos = 0;

            if (lastChange != "codigo")
            {
                cmbCodigo.Items.Clear();
            }
            if (lastChange != "tipomaterial")
            {
                cmbTipoMaterial.Items.Clear();
            }
            if (lastChange != "bodega")
            {
                cmbBodegas.Items.Clear();
            }
            if (lastChange != "planta")
            {
                cmbPlanta.Items.Clear();
            }
            if (lastChange != "codigomaterial")
            {
                cmbCodigoMaterial.Items.Clear();
            }
         
            dgvStockRaw.Rows.Clear();

            if (listaStock.Count > 0)
            {
                for (int i = 0; i < listaStock.Count; i++)
                {
                    string concat = codigo + tipoMaterial + bodega + planta + codigoMaterial;
                    string concat2 = string.Empty;
                    fkbodegaRaw = new clsRawPalletByCoilCellar(listaStock[i].codsec);
                    bodegaRaw = new clsCoilCellar(fkbodegaRaw.fkCoilCellar);
                    plant = new clsPlant(bodegaRaw.fkPlant);

                    if (codigo != string.Empty)
                    {
                        concat2 = listaStock[i].code.ToString();
                    }
                    if (tipoMaterial != string.Empty)
                    {
                        concat2 += listaStock[i].rawMaterial.name.ToString();
                    }
                    if (bodega != string.Empty)
                    {
                        concat2 += bodegaRaw.name.ToString();
                    }
                    if (planta != string.Empty)
                    {
                        concat2 += plant.name.ToString();
                    }
                    if (codigoMaterial != string.Empty)
                    {
                        concat2 += listaStock[i].rawMaterial.code;
                    }
                  

                    if (concat == concat2)
                    {
                        dgvStockRaw.Rows.Add();
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmCodsec.Index].Value = listaStock[i].codsec;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmCodigo.Index].Value = listaStock[i].code;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmCodigoM.Index].Value = listaStock[i].rawMaterial.code;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmTipoMat.Index].Value = listaStock[i].rawMaterial.name;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmPeso.Index].Value = listaStock[i].netweigth;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmFecha.Index].Value = listaStock[i].date;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmBodega.Index].Value = bodegaRaw.name;
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmPlanta.Index].Value = plant.name;
                        

                        if (!codigos.Contains(listaStock[i].code))
                            codigos.Add(listaStock[i].code);

                        if (!tipoMaterials.Contains(listaStock[i].rawMaterial.name))
                            tipoMaterials.Add(listaStock[i].rawMaterial.name);

                        if (!bodegas.Contains(bodegaRaw.name))
                            bodegas.Add(bodegaRaw.name);

                        if (!plantas.Contains(plant.name))
                            plantas.Add(plant.name);

                        if (!codigosMaterial.Contains(listaStock[i].rawMaterial.code))
                            codigosMaterial.Add(listaStock[i].rawMaterial.code);
                    }
                }

                codigos.Sort();
                tipoMaterials.Sort();
                bodegas.Sort();
                plantas.Sort();
                codigosMaterial.Sort();
               
                
                if (lastChange != "codigo")
                {
                    for (int i = 0; i < codigos.Count; i++)
                    {
                        cmbCodigo.Items.Add(codigos[i]);
                    }
                }
                if (lastChange != "tipomaterial")
                {
                    for(int i=0;i < tipoMaterials.Count;i++)
                    {
                        if (tipoMaterials[i] != null)
                        {
                            cmbTipoMaterial.Items.Add(tipoMaterials[i]);
                        }
                        
                    }
                }
                if (lastChange != "bodega")
                {
                    for (int i = 0; i < bodegas.Count; i++)
                    {
                        if (bodegas[i] != null)
                        {
                            cmbBodegas.Items.Add(bodegas[i]);
                        }
                        
                    }      
                }
                if (lastChange != "planta")
                {
                    for (int i = 0; i < plantas.Count; i++)
                    {
                        cmbPlanta.Items.Add(plantas[i]);
                    }
                }
                if (lastChange != "codigomaterial")
                {
                    for (int i = 0; i < codigosMaterial.Count; i++)
                    {
                        if (codigosMaterial[i] != null)
                        {
                            cmbCodigoMaterial.Items.Add(codigosMaterial[i]);
                        }
                    }
                }
                
            }
            
            foreach (DataGridViewRow row in dgvStockRaw.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells["clmPeso"].Value);
                txtPesos.Text = Convert.ToString(pesos);
            }
            /*
            if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030)
            {
                //cmbBodegas.SelectedIndex = 0;
            }
            else
            {
                if (clsGlobal.LoggedUser.fkRole == 4 || clsGlobal.LoggedUser.fkRole == 5 || clsGlobal.LoggedUser.fkRole == 6)
                {
                    //cmbBodegas.SelectedIndex = 1;
                }
                else
                {
                    cmbPlanta.SelectedIndex = -1;
                }
            }*/ //No deberia de estar, este no es como los otros forms con DTP.
        }
    
        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigo.SelectedIndex != -1)
            {
                if (codigo != cmbCodigo.SelectedItem.ToString())
                {
                    codigo = cmbCodigo.SelectedItem.ToString();
                    lastChange = "codigo";
                    populateDgv();
                }
            }
            else
            {
                codigo = string.Empty;
            }
        }

        private void cmbTipoMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMaterial.SelectedIndex != -1)
            {
                if (tipoMaterial != cmbTipoMaterial.SelectedItem.ToString())
                {
                    tipoMaterial = cmbTipoMaterial.SelectedItem.ToString();
                    lastChange = "tipomaterial";
                    populateDgv();
                }
            }
            else
            {
                tipoMaterial = string.Empty;
            }
        }

        private void cmbBodegas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBodegas.SelectedIndex != -1)
            {
                if (bodega != cmbBodegas.SelectedItem.ToString())
                {
                    bodega = cmbBodegas.SelectedItem.ToString();
                    lastChange = "bodega";
                    populateDgv();
                }
            }
            else
            {
                bodega = string.Empty;
            }
        }

        private void cmbPlanta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlanta.SelectedIndex != -1)
            {
                if (planta != cmbPlanta.SelectedItem.ToString())
                {
                    planta = cmbPlanta.SelectedItem.ToString();
                    lastChange = "planta";
                    populateDgv();
                }
            }
            else
            {
                planta = string.Empty;
            }
        }

        private void cmbCodigoMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigoMaterial.SelectedIndex != -1)
            {
                if (codigoMaterial != cmbCodigoMaterial.SelectedItem.ToString())
                {
                    codigoMaterial = cmbCodigoMaterial.SelectedItem.ToString();
                    lastChange = "codigomaterial";
                    populateDgv();
                }
            }
            else
            {
                codigoMaterial = string.Empty;
            }
        }

        private void cmbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCodigo.ResetText();
                codigo = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbTipoMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbTipoMaterial.ResetText();
                tipoMaterial = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbBodegas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodegas.ResetText();
                bodega = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbPlanta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPlanta.ResetText();
                planta = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void cmbCodigoMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCodigoMaterial.ResetText();
                codigoMaterial = string.Empty;
                lastChange = string.Empty;
                populateDgv();
            }
        }

        private void btnLimpiarCmb_Click(object sender, EventArgs e)
        {
            codigo = string.Empty;
            tipoMaterial = string.Empty;
            bodega = string.Empty;
            planta = string.Empty;
            codigoMaterial = string.Empty;


            getList();
            populateDgv();

            cmbCodigo.ResetText();
            cmbCodigo.SelectedIndex = -1;
            cmbTipoMaterial.ResetText();
            cmbTipoMaterial.SelectedIndex = -1;
            cmbBodegas.ResetText();
            cmbBodegas.SelectedIndex = -1;
            cmbPlanta.ResetText();
            cmbPlanta.SelectedIndex = -1;
            cmbCodigoMaterial.ResetText();
            cmbCodigoMaterial.SelectedIndex = -1;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // supongo que aca pongo las columnas que voy a exportar al excel.
            string ext = string.Empty;
            dgvStockRaw.Columns["clmCodigo"].Visible = true;
            dgvStockRaw.Columns["clmTipoMat"].Visible = true;
            dgvStockRaw.Columns["clmPeso"].Visible = true;
            dgvStockRaw.Columns["clmFecha"].Visible = true;
            dgvStockRaw.Columns["clmPlanta"].Visible = true;
            dgvStockRaw.Columns["clmCodigoM"].Visible = true;
            dgvStockRaw.Columns["clmBodega"].Visible = true;
            dgvStockRaw.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            //Genero el save y en que formato se va a poder grabar (supongo)
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
                dgvStockRaw.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }

            // Esto lo que hace es, luego de exportarlo te oculta las columnas que se exportaron.
            // false = no visible ---- true = se ve la columna
            dgvStockRaw.Columns["clmCodigo"].Visible = true;
            dgvStockRaw.Columns["clmTipoMat"].Visible = true;
            dgvStockRaw.Columns["clmPeso"].Visible = true;
            dgvStockRaw.Columns["clmFecha"].Visible = true;
            dgvStockRaw.Columns["clmPlanta"].Visible = true;
            dgvStockRaw.Columns["clmCodigoM"].Visible = true;
            dgvStockRaw.Columns["clmBodega"].Visible = true;
            dgvStockRaw.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboard()
        {
            dgvStockRaw.SelectAll();
            DataObject dataObj = dgvStockRaw.GetClipboardContent();
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
