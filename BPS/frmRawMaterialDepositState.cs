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
    public partial class frmRawMaterialDepositState : Form
    {
        List<clsRawMaterialPallet> listaStock = new List<clsRawMaterialPallet>();
        
        string codigo = string.Empty;
        string tipoMaterial = string.Empty;
        string bodega = string.Empty;
        string planta = string.Empty;
        string codigoMaterial = string.Empty;


        string codigoSilo = string.Empty;
        string tipoMaterialSilo = string.Empty;
        string Silo = string.Empty;
        string plantaSilo = string.Empty;
        string codigoMaterialSilo = string.Empty;


        string codigoMatTotal = string.Empty;
        string tipoMaterialTotal = string.Empty;
        string bodegaTotal = string.Empty;

        string lastChange = string.Empty;

        public frmRawMaterialDepositState()
        {
            InitializeComponent();
        }

        private void frmPalletRawMaterialStock_Load(object sender, EventArgs e)
        {
           
            populateDgv();
            populateDgvSilo();
            populateDgvPalletTotales();

        }

        #region Solapa Pallets
        private void populateDgv()
        {

            List<string> codigos = new List<string>();
            List<string> tipoMaterials = new List<string>();
            List<string> bodegas = new List<string>();
            List<string> plantas = new List<string>();
            List<string> codigosMaterial = new List<string>();

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spRawPalletInCoilCellarStock()");

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

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = codigo + tipoMaterial + bodega + planta + codigoMaterial;
                    string concat2 = string.Empty;

                    if (codigo != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["CodigoPallet"]);
                    }
                    if (tipoMaterial != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"]);
                    }
                    if (bodega != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Bodega"]);
                    }
                    if (planta != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["Plant"]);
                    }
                    if (codigoMaterial != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["codigoMP"]);
                    }

                    if (concat == concat2)
                    {
                        dgvStockRaw.Rows.Add();
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["codsec"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmCodigo.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["CodigoPallet"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmCodigoM.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["codigoMP"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmTipoMat.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmPeso.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["Peso"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmFecha.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmLote.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["Lote"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmBodega.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["Bodega"]);
                        dgvStockRaw.Rows[dgvStockRaw.Rows.Count - 1].Cells[clmPlanta.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["Plant"]);


                        if (!codigos.Contains(Convert.ToString(DS.Tables[0].Rows[i]["CodigoPallet"])))
                            codigos.Add(Convert.ToString(DS.Tables[0].Rows[i]["CodigoPallet"]));

                        if (!tipoMaterials.Contains(Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"])))
                            tipoMaterials.Add(Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"]));

                        if (!bodegas.Contains(Convert.ToString(DS.Tables[0].Rows[i]["Bodega"])))
                            bodegas.Add(Convert.ToString(DS.Tables[0].Rows[i]["Bodega"]));

                        if (!plantas.Contains(Convert.ToString(DS.Tables[0].Rows[i]["Plant"])))
                            plantas.Add(Convert.ToString(DS.Tables[0].Rows[i]["Plant"]));

                        if (!codigosMaterial.Contains(Convert.ToString(DS.Tables[0].Rows[i]["codigoMP"])))
                            codigosMaterial.Add(Convert.ToString(DS.Tables[0].Rows[i]["codigoMP"]));
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
                    for (int i = 0; i < tipoMaterials.Count; i++)
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
                        cmbCodigoMaterial.Items.Add(codigosMaterial[i]);
                    }
                }

            }

            foreach (DataGridViewRow row in dgvStockRaw.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells["clmPeso"].Value);
               
            }
            txtPesos.Text = Math.Round(pesos,2).ToString();
            txtCantPallet.Text = dgvStockRaw.Rows.Count.ToString();
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

            List<String> listaFechaRawPallet = new List<string>();


            for (int i = 0; i < dgvStockRaw.Rows.Count; i++)
            {
                listaFechaRawPallet.Add(dgvStockRaw.Rows[i].Cells[clmFecha.Index].Value.ToString());
                dgvStockRaw.Rows[i].Cells[clmFecha.Index].Value = Convert.ToDateTime(dgvStockRaw.Rows[i].Cells[clmFecha.Index].Value).ToString("MM/dd/yyyy HH:mm");
            }
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


            for (int i = 0; i < dgvStockRaw.Rows.Count; i++)
            {
                dgvStockRaw.Rows[i].Cells[clmFecha.Index].Value = Convert.ToDateTime(listaFechaRawPallet[i].ToString());
            }
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
        #endregion

        #region Solapa Silo
        public void populateDgvSilo()
        {
            double pesos = 0;
            List<string> codigosSilo= new List<string>();
            List<string> tipoMaterialesSilo = new List<string>();
            List<string> silos = new List<string>();
            List<string> plantasSilo = new List<string>();
            List<string> codigosMaterialesSilo = new List<string>();
            
            DataSet DS = new DataSet();

            clsRawMaterialBySiloCellar fkSilo = new clsRawMaterialBySiloCellar();
            clsCoilCellar bodegaRaw = new clsCoilCellar();
            clsPlant plant = new clsPlant();
            
            DS = clsConnection.getDataSetResult("CALL spRawMaterialStockBySiloCellar()");

            if (lastChange != "tipomaterialsilo")
            {
                cmbTipoMatSilo.Items.Clear();
            }
            if (lastChange != "plantasilo")
            {
                cmbPlantaSilo.Items.Clear();
            }
            if (lastChange != "silo")
            {
                cmbSilo.Items.Clear();
            }

            dgvSilo.Rows.Clear();

             if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = codigoSilo + tipoMaterialSilo + Silo + plantaSilo;
                    string concat2 = string.Empty;
                

                    if (codigoSilo != string.Empty)
                    {
                        concat2 = Convert.ToString(DS.Tables[0].Rows[i]["codRawMat"]);
                    }
                    if (tipoMaterialSilo != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["nombreMP"]);
                    }
                    if (Silo != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["nomSilo"]);
                    }
                    if (plantaSilo != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["planta"]);
                    }
                   
                     if (concat == concat2)
                    {
                        dgvSilo.Rows.Add();
                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloNom.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["nomSilo"]);
                       // dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloRawMatCod.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["codRawMat"]);
                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloTipRawMat.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["nombreMP"]);
                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloPeso.Index].Value = Convert.ToString(Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["pesoTotal"])));

                        dgvSilo.Rows[dgvSilo.Rows.Count - 1].Cells[clmSiloPlanta.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["planta"]);
                     

                        if (!tipoMaterialesSilo.Contains(Convert.ToString(DS.Tables[0].Rows[i]["nombreMP"])))
                            tipoMaterialesSilo.Add(Convert.ToString(DS.Tables[0].Rows[i]["nombreMP"]));

                        if (!silos.Contains(Convert.ToString(DS.Tables[0].Rows[i]["nomSilo"])))
                            silos.Add(Convert.ToString(DS.Tables[0].Rows[i]["nomSilo"]));

                        if (!plantasSilo.Contains(Convert.ToString(DS.Tables[0].Rows[i]["planta"])))
                            plantasSilo.Add(Convert.ToString(DS.Tables[0].Rows[i]["planta"]));

                    }
                }
                codigosSilo.Sort();
                tipoMaterialesSilo.Sort();
                silos.Sort();
                plantasSilo.Sort();


                if (lastChange != "tipomaterialsilo")
                {
                    for (int i = 0; i < tipoMaterialesSilo.Count; i++)
                    {
                        if (tipoMaterialesSilo[i] != null)
                        {
                            cmbTipoMatSilo.Items.Add(tipoMaterialesSilo[i]);
                        }

                    }
                }
                if (lastChange != "silo")
                {
                    for (int i = 0; i < silos.Count; i++)
                    {
                        if (silos[i] != null)
                        {
                            cmbSilo.Items.Add(silos[i]);
                        }

                    }
                }
                if (lastChange != "plantasilo")
                {
                    for (int i = 0; i < plantasSilo.Count; i++)
                    {
                        cmbPlantaSilo.Items.Add(plantasSilo[i]);
                    }
                }
         

            }
             foreach (DataGridViewRow row in dgvSilo.Rows)
             {
                 pesos = pesos + Convert.ToDouble(row.Cells[clmSiloPeso.Index].Value);
             }
             txtTotalSilo.Text = Math.Round(pesos, 2).ToString();
        }
        
        private void cmbTipoMatSilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMatSilo.SelectedIndex != -1)
            {
                if (tipoMaterialSilo != cmbTipoMatSilo.SelectedItem.ToString())
                {
                    tipoMaterialSilo = cmbTipoMatSilo.SelectedItem.ToString();
                    lastChange = "tipomaterialsilo";
                    populateDgvSilo();
                }
            }
            else
            {
                tipoMaterialSilo = string.Empty;
            }
        }

        private void cmbSilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSilo.SelectedIndex != -1)
            {
                if (Silo != cmbSilo.SelectedItem.ToString())
                {
                    Silo = cmbSilo.SelectedItem.ToString();
                    lastChange = "silo";
                    populateDgvSilo();
                }
            }
            else
            {
                Silo = string.Empty;
            }
        }

        private void cmbPlantaSilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPlantaSilo.SelectedIndex != -1)
            {
                if (plantaSilo != cmbPlantaSilo.SelectedItem.ToString())
                {
                    plantaSilo = cmbPlantaSilo.SelectedItem.ToString();
                    lastChange = "plantasilo";
                    populateDgvSilo();
                }
            }
            else
            {
                plantaSilo = string.Empty;
            }
        }

        private void cmbCodMatSilo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                codigoSilo = string.Empty;
                lastChange = string.Empty;
                populateDgvSilo();
            }
        }

        private void cmbTipoMatSilo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbTipoMatSilo.ResetText();
                tipoMaterialSilo = string.Empty;
                lastChange = string.Empty;
                populateDgvSilo();
            }
        }

        private void cmbSilo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbSilo.ResetText();
                Silo = string.Empty;
                lastChange = string.Empty;
                populateDgvSilo();
            }
        }

        private void cmbPlantaSilo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbPlantaSilo.ResetText();
                plantaSilo = string.Empty;
                lastChange = string.Empty;
                populateDgvSilo();
            }
        }

        private void btnLimpCmbSilo_Click(object sender, EventArgs e)
        {

            codigoSilo = string.Empty;
            tipoMaterialSilo = string.Empty;
            Silo = string.Empty;
            plantaSilo = string.Empty;
            codigoMaterialSilo = string.Empty;


            //getList();
            populateDgvSilo();

            cmbTipoMatSilo.ResetText();
            cmbTipoMatSilo.SelectedIndex = -1;
            cmbSilo.ResetText();
            cmbSilo.SelectedIndex = -1;
            cmbPlantaSilo.ResetText();
            cmbPlantaSilo.SelectedIndex = -1;

        }

        private void btnExcelSilo_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvSilo.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboardSilo();

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

                releaseObjectSilo(xlWorkSheet);
                releaseObjectSilo(xlWorkBook);
                releaseObjectSilo(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgvSilo.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvSilo.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboardSilo()
        {
            dgvSilo.SelectAll();
            DataObject dataObj = dgvSilo.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObjectSilo(object obj)
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

        #region Solapa Total Pallets

        private void populateDgvPalletTotales()
        {
            List<string> codigosTot = new List<string>();
            List<string> tipoMaterialsTot = new List<string>();
            List<string> bodegasTot = new List<string>();
            double pesos = 0;

            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL spRawPalletInCoilCellarStockTotalized()");

            if (lastChange != "tipomaterial")
            {
                cmbTipoMatT.Items.Clear();
            }
            if (lastChange != "codigomaterial")
            {
                cmbCodigoMaterial.Items.Clear();
            }
            if (lastChange != "bodega")
            {
                cmbBodegaTot.Items.Clear();
            }

            dgvPalletTotal.Rows.Clear();

            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    string concat = codigoMatTotal + tipoMaterialTotal + bodegaTotal;
                    string concat2 = string.Empty;

                    if (codigoMatTotal != string.Empty)
                    {
                        concat2 = Convert.ToString(DS.Tables[0].Rows[i]["CodigoMateriaPrima"]);
                    }
                    if (tipoMaterialTotal != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"]);
                    }
                    if (bodegaTotal != string.Empty)
                    {
                        concat2 += Convert.ToString(DS.Tables[0].Rows[i]["nombreBodega"]);
                    }

                    if (concat == concat2)
                    {
                        dgvPalletTotal.Rows.Add();
                        dgvPalletTotal.Rows[dgvPalletTotal.Rows.Count - 1].Cells[clmCodeMatTotal.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["CodigoMateriaPrima"]);
                        dgvPalletTotal.Rows[dgvPalletTotal.Rows.Count - 1].Cells[clmTipoMatTotal.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"]);
                        dgvPalletTotal.Rows[dgvPalletTotal.Rows.Count - 1].Cells[clmPesoTotal.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["Peso"]);
                        dgvPalletTotal.Rows[dgvPalletTotal.Rows.Count - 1].Cells[clmBodegaTot.Index].Value = DS.Tables[0].Rows[i]["nombreBodega"];

                        if (!codigosTot.Contains(Convert.ToString(DS.Tables[0].Rows[i]["CodigoMateriaPrima"])))
                            codigosTot.Add(Convert.ToString(DS.Tables[0].Rows[i]["CodigoMateriaPrima"]));

                        if (!tipoMaterialsTot.Contains(Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"])))
                            tipoMaterialsTot.Add(Convert.ToString(DS.Tables[0].Rows[i]["MateriaPrima"]));

                        if (!bodegasTot.Contains(Convert.ToString(DS.Tables[0].Rows[i]["nombreBodega"])))
                            bodegasTot.Add(Convert.ToString(DS.Tables[0].Rows[i]["nombreBodega"]));

                    }
                }

                codigosTot.Sort();
                tipoMaterialsTot.Sort();
                bodegasTot.Sort();

                if (lastChange != "codigomaterial")
                {
                    for (int i = 0; i < codigosTot.Count; i++)
                    {
                        cmbCodigoMatT.Items.Add(codigosTot[i]);
                    }
                }
                if (lastChange != "tipomaterial")
                {
                    for (int i = 0; i < tipoMaterialsTot.Count; i++)
                    {
                        if (tipoMaterialsTot[i] != null)
                        {
                            cmbTipoMatT.Items.Add(tipoMaterialsTot[i]);
                        }

                    }
                }
                if (lastChange != "bodega")
                {
                    for (int i = 0; i < bodegasTot.Count; i++)
                    {
                        cmbBodegaTot.Items.Add(bodegasTot[i]);
                    }
                }
            }

            foreach (DataGridViewRow row in dgvPalletTotal.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPesoTotal.Index].Value);
            }
            txtTotalKilosTotalizador.Text = Math.Round(pesos, 2).ToString();

        }



        private void cmbCodigoMatT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCodigoMatT.SelectedIndex != -1)
            {
                if (codigoMatTotal != cmbCodigoMatT.SelectedItem.ToString())
                {
                    codigoMatTotal = cmbCodigoMatT.SelectedItem.ToString();
                    lastChange = "codigomaterial";
                    populateDgvPalletTotales();
                }
            }
        }

        private void cmbBodegaTot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBodegaTot.SelectedIndex != -1)
            {
                if (bodegaTotal != cmbBodegaTot.SelectedItem.ToString())
                {
                    bodegaTotal = cmbBodegaTot.SelectedItem.ToString();
                    lastChange = "bodega";
                    populateDgvPalletTotales();
                }
            }
        }

        private void cmbTipoMatT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoMatT.SelectedIndex != -1)
            {
                if (tipoMaterialTotal != cmbTipoMatT.SelectedItem.ToString())
                {
                    tipoMaterialTotal = cmbTipoMatT.SelectedItem.ToString();
                    lastChange = "tipomaterial";
                    populateDgvPalletTotales();
                }
            }
        }

        private void cmbCodigoMatT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbCodigoMatT.ResetText();
                codigoMatTotal = string.Empty;
                lastChange = string.Empty;
                populateDgvPalletTotales();
            }
        }

        private void cmbTipoMatT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbTipoMatT.ResetText();
                tipoMaterialTotal = string.Empty;
                lastChange = string.Empty;
                populateDgvPalletTotales();
            }
        }


        private void cmbBodegaTot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodegaTot.ResetText();
                bodegaTotal = string.Empty;
                lastChange = string.Empty;
                populateDgvPalletTotales();
            }
        }

        private void btnLimpiarCmbs_Click(object sender, EventArgs e)
        {
            tipoMaterialTotal = string.Empty;
            codigoMatTotal = string.Empty;
            lastChange = string.Empty;
            bodegaTotal = string.Empty;

            populateDgvPalletTotales();

            cmbTipoMatT.ResetText();
            cmbCodigoMatT.ResetText();
            cmbBodegaTot.ResetText();
            cmbCodigoMatT.SelectedIndex = -1;
            cmbTipoMatT.SelectedIndex = -1;
            cmbBodegaTot.SelectedIndex = -1;
        }


        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string ext = string.Empty;
            dgvPalletTotal.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel 97-2003 WorkBook|*.xls|Excel WorkBook|*.xlsx|All Excel Files|*.xls;*.xlsx";
            string filename = System.IO.Path.GetFileName(sfd.FileName);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Copy DataGridView results to clipboard
                copyAlltoClipboarTotal();

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

                releaseObjectTotals(xlWorkSheet);
                releaseObjectTotals(xlWorkBook);
                releaseObjectTotals(xlexcel);

                // Clear Clipboard and DataGridView selection
                Clipboard.Clear();
                dgvPalletTotal.ClearSelection();

                // Open the newly saved excel file
                if (File.Exists(sfd.FileName))
                    System.Diagnostics.Process.Start(sfd.FileName);
            }
            dgvPalletTotal.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithAutoHeaderText;
        }

        private void copyAlltoClipboarTotal()
        {
            dgvPalletTotal.SelectAll();
            DataObject dataObj = dgvPalletTotal.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void releaseObjectTotals(object obj)
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

    }
}
