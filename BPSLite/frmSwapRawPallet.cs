using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSwapRawPallet : Form
    {
        clsRawMaterialPallet palletRaw = new clsRawMaterialPallet();
        clsRawPalletByCoilCellar bodegaRaw = new clsRawPalletByCoilCellar();
        clsRawMaterialMovements movimientosRaw = new clsRawMaterialMovements();
        clsPlant planta = new clsPlant();

        public frmSwapRawPallet()
        {
            InitializeComponent();
            PopulateDgvIngreso();
        }

        #region Carga de pallet de MP

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if (cmbBodegaDestino.Text != string.Empty)
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        clsRawMaterialPallet palletRaw = new clsRawMaterialPallet(txtCodigo.Text);
                        clsRawPalletByCoilCellar bodegafkOrg = new clsRawPalletByCoilCellar(palletRaw.codsec);
                        clsCoilCellar bodegaOrg = new clsCoilCellar(bodegafkOrg.fkCoilCellar);

                        if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
                        {
                            planta = new clsPlant(3);
                        }
                        else
                        {
                            planta = new clsPlant(4);
                        }
                       
                        int numeroBodega = bodegaRaw.getfkCoilCellarByfkRawPallet(palletRaw.codsec);
                        
                        if (palletRaw.codsec != 0)
                        {
                            if (palletRaw.fkStatus == 38)
                            {
                                if (bodegaOrg.fkPlant == planta.codsec)
                                {
                                    if (dgvSwapRawMat.Rows.Count > 0)
                                    {
                                        foreach (DataGridViewRow row in dgvSwapRawMat.Rows)
                                        {
                                            if (palletRaw.codsec == Convert.ToInt32(row.Cells[clmCodsec.Index].Value))
                                            {
                                                MessageBox.Show("Codigo ya ingresado. Por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                bandera = true;
                                                break;
                                            }
                                        }

                                        if (bandera != true)
                                        {
                                            dgvSwapRawMat.Rows.Add();
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmCodsec.Index].Value = palletRaw.codsec;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmCodigo.Index].Value = palletRaw.code;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmLote.Index].Value = palletRaw.lote;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmTipo.Index].Value = palletRaw.rawMaterial.name;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmPeso.Index].Value = palletRaw.netweigth;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = bodegaOrg.name;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbBodegaDestino.Text;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmDate.Index].Value = DateTime.Now;

                                            txtCodigo.Text = string.Empty;

                                        }
                                    }
                                    else
                                    {
                                        dgvSwapRawMat.Rows.Add();
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmCodsec.Index].Value = palletRaw.codsec;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmCodigo.Index].Value = palletRaw.code;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmLote.Index].Value = palletRaw.lote;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmTipo.Index].Value = palletRaw.rawMaterial.name;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmPeso.Index].Value = palletRaw.netweigth;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = bodegaOrg.name;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbBodegaDestino.Text;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmDate.Index].Value = DateTime.Now;

                                        txtCodigo.Text = string.Empty;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Esta intentando realizar un movimiento de un pallet que se encuentra en otra planta(" + bodegaOrg.name + "). Por favor, solicite el SWAP correspondiente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }// Aca va
                            else
                            {
                                MessageBox.Show("El pallet debe estar dado de alta para poder realizar el movimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtCodigo.ResetText();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete el codigo de pallet", "¡Error!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete la bodega de origen y destino a donde desea enviar el pallet", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                calculoSubtotalesOut();
            }
        }

        #endregion

        #region Cargar Combos
        private void frmSwapRawPallet_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        public void cargarCombos()
        {
            List<clsCoilCellar> bodegas = new List<clsCoilCellar>();

            bodegas = clsCoilCellar.lstRawCellar();
           
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbBodegaDestino.Items.Add(bodegas[i]);
                }

                if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
                {
                    cmbBodegaDestino.Items.Remove(cmbBodegaDestino.Items[2]);
                    cmbBodegaDestino.Items.Remove(cmbBodegaDestino.Items[3]);
                }
                else
                {
                    cmbBodegaDestino.Items.Remove(cmbBodegaDestino.Items[0]);
                    cmbBodegaDestino.Items.Remove(cmbBodegaDestino.Items[0]);
                    cmbBodegaDestino.Items.Remove(cmbBodegaDestino.Items[1]);
                }
                
        }

        #endregion

        #region Procesar Swap MP

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvSwapRawMat.Rows.Count > 0)
            {
                for (int i = 0; i < dgvSwapRawMat.Rows.Count; i++)
                {
                    palletRaw = new clsRawMaterialPallet(Convert.ToString(dgvSwapRawMat.Rows[i].Cells[clmCodigo.Index].Value.ToString()));
                    bodegaRaw = new clsRawPalletByCoilCellar(palletRaw.codsec);
                    clsCoilCellar bodegaNueva = new clsCoilCellar(Convert.ToString(dgvSwapRawMat.Rows[i].Cells[clmBodegaDestino.Index].Value.ToString()));

                    palletRaw.fkStatus = 3066; // Esto es agregado nuevo. Estado "En transito" para realizar el swap.
                    movimientosRaw.fkOrigCellar = bodegaRaw.fkCoilCellar;
                    bodegaRaw.fkCoilCellar = bodegaNueva.codsec;
                    movimientosRaw.fkRaw = palletRaw.fkRaw;
                    movimientosRaw.type = "Swap de Materia Prima";
                    movimientosRaw.lote = palletRaw.lote;
                    movimientosRaw.fkRawPallet = palletRaw.codsec;
                    movimientosRaw.fkDestCellar = bodegaNueva.codsec;
                    movimientosRaw.estrusionLote = "";
                    movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientosRaw.date = DateTime.Now;
                    movimientosRaw.netWeigth = Convert.ToDouble(dgvSwapRawMat.Rows[i].Cells[clmPeso.Index].Value);

                    bodegaRaw.save();
                    movimientosRaw.save();
                    palletRaw.save();

                }
            }
            else
            {
                MessageBox.Show("La tabla se encuentra vacia", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            exportToExcel();
            dgvSwapRawMat.Rows.Clear();
            MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtCodigo.Text = string.Empty;
            cmbBodegaDestino.ResetText();

        }

        private void exportToExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Swap de Pallet de Materia Prima";

                for (int i = 2; i < dgvSwapRawMat.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvSwapRawMat.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvSwapRawMat.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvSwapRawMat.Columns.Count - 1; j++)
                        {
                            if (dgvSwapRawMat.Rows[i].Cells[j].Value != null)
                                worksheet.Cells[i + 2 , j] = dgvSwapRawMat.Rows[i].Cells[j].Value.ToString();
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Swap de Pallet de Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBodegaOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodegaDestino.ResetText();
                cmbBodegaDestino.SelectedIndex = -1;
            }
        }

        private void cmbBodegaDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodegaDestino.ResetText();
            }
        }



        private void dgvSwapRawMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvSwapRawMat.Rows.RemoveAt(dgvSwapRawMat.CurrentRow.Index);
                calculoSubtotalesOut();
            }
        }
        #endregion  

        #region Autocarga DgvIngreso
        private void PopulateDgvIngreso()
        {
            DataSet DS = new DataSet();

            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
            {
                DS = clsConnection.getDataSetResult("CALL spRawPalletsInTransit(" + 3 + ")" );
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spRawPalletsInTransit(" + 4 + ")");
            }
            if (DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvIngresoSwap.Rows.Add();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRPCod.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["CodPallet"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRMCodM.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["CodRawM"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRMTipoMat.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["nomRawMat"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRMPeso.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["pesoPallet"]),2);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmOrigenRMPallet.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["nomBodegaOrg"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRPDestino.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["nomBodegaDest"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRMLote.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["lotePallet"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRMFecha.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["fechaPallet"]);
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmRMNotas.Index].Value = Convert.ToString(DS.Tables[0].Rows[i]["Notas"]);
                }
                calculoSubtotalesIn();
            }
            
        }
        #endregion

        #region Aceptacion de Pallet

        private void dgvIngresoSwap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool anduvoSetBodega = false;

            if (e.ColumnIndex == clmConfirm.Index) // Confirma que el pallet llego y que esta todo en orden.
            {
                clsCoilCellar bodega = new clsCoilCellar(dgvIngresoSwap.CurrentRow.Cells[clmRPDestino.Index].Value.ToString());
                palletRaw = new clsRawMaterialPallet(Convert.ToString(dgvIngresoSwap.CurrentRow.Cells[clmRPCod.Index].Value));

                anduvoSetBodega = clsRawPalletByCoilCellar.setFkCoilCellarNew(palletRaw.codsec, bodega.codsec);
                palletRaw.fkStatus = 38;

                palletRaw.save();
                dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
            }
            else if (e.ColumnIndex == clmDeny.Index) // Si cancela la llegada del pallet por que, no vino directamente o alguna otra movida
            {
                clsCoilCellar bodega = new clsCoilCellar(dgvIngresoSwap.CurrentRow.Cells[clmOrigenRMPallet.Index].Value.ToString());
                palletRaw = new clsRawMaterialPallet(Convert.ToString(dgvIngresoSwap.CurrentRow.Cells[clmRPCod.Index].Value));
                clsCoilCellar bodegaNew = new clsCoilCellar(dgvIngresoSwap.CurrentRow.Cells[clmRPDestino.Index].Value.ToString());

                anduvoSetBodega = clsRawPalletByCoilCellar.setFkCoilCellarNew(palletRaw.codsec, bodega.codsec);               

                var dialogResult = MessageBox.Show("a.BOTON SI: Seleccione este boton si, el pallet no llego.\nb.BOTON NO: Seleccione este boton si, el pallet no llego en condiciones.\nc.Si no es ninguna de las opciones anteriores, presione CANCEL.", "¡Advertencia!", MessageBoxButtons.YesNoCancel);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        movimientosRaw.fkOrigCellar = bodega.codsec;
                        movimientosRaw.fkRaw = palletRaw.fkRaw;
                        movimientosRaw.type = "El pallet no llegó";
                        movimientosRaw.lote = palletRaw.lote;
                        movimientosRaw.fkRawPallet = palletRaw.codsec;
                        movimientosRaw.fkDestCellar = bodegaNew.codsec;
                        movimientosRaw.estrusionLote = "";
                        movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;
                        movimientosRaw.date = DateTime.Now;
                        movimientosRaw.netWeigth = -1 * palletRaw.netweigth;
                        palletRaw.fkStatus = 38;
                        palletRaw.save();
                        movimientosRaw.save();
                        dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                        break;

                    case DialogResult.No:
                        movimientosRaw.fkOrigCellar = bodegaNew.codsec;
                        movimientosRaw.fkRaw = palletRaw.fkRaw;
                        movimientosRaw.type = "El pallet no se acepto, por que llegó con desperfectos";
                        movimientosRaw.lote = palletRaw.lote;
                        movimientosRaw.fkRawPallet = palletRaw.codsec;
                        movimientosRaw.fkDestCellar = bodega.codsec;
                        movimientosRaw.estrusionLote = "";
                        movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;
                        movimientosRaw.date = DateTime.Now;
                        movimientosRaw.netWeigth = -1 * palletRaw.netweigth;
                        palletRaw.fkStatus = 3066;
                        dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                        palletRaw.save();
                        movimientosRaw.save();
                        break;

                    case DialogResult.Cancel:
                        palletRaw.save();
                        break;
                }
            }
            calculoSubtotalesIn();
        }

        #endregion

        #region Calculo Subtotales
        private void calculoSubtotalesOut()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvSwapRawMat.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPeso.Index].Value);
            }
            txtTotPalletOut.Text = dgvSwapRawMat.Rows.Count.ToString();
            txtTotKilosOut.Text = Math.Round(pesos, 2).ToString();
        }

        private void calculoSubtotalesIn()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvIngresoSwap.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmRMPeso.Index].Value);
               
            }
            txtPalletIn.Text = dgvIngresoSwap.Rows.Count.ToString();
            txtTotKilosIn.Text = Math.Round(pesos, 2).ToString();
        }
        #endregion

    }
}
