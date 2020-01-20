using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmScrapIntercellarMovement : Form
    {
        clsScrapMovements movimientos = new clsScrapMovements();
        clsScrapPalletByCoilCellar scrapPBCC = new clsScrapPalletByCoilCellar();
        clsScrapPallet palletScrap = new clsScrapPallet();

        public frmScrapIntercellarMovement()
        {
            InitializeComponent();
        }

        #region Eventos de los elementos del formulario

        private void frmScrapIntercellarMovement_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrigen.Text != string.Empty)
            {
                cmbDestino.Enabled = true;
                cmbDestino.Items.Clear();
                cargarCombos();

            }
            else
            {
                cmbDestino.Enabled = false;
            }
        }

        private void cmbOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrigen.ResetText();
                cmbDestino.ResetText();
                cmbDestino.SelectedIndex = -1;
                cmbOrigen.SelectedIndex = -1;

            }
        }

        private void cmbDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbDestino.ResetText();
                cmbDestino.SelectedIndex = -1;

            }
        }

        private void cargarCombos()
        {
            List<clsCoilCellar> bodegas = new List<clsCoilCellar>();
            List<clsCoilCellar> bodegasNew = new List<clsCoilCellar>();

            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
            {
                bodegas = clsCoilCellar.lstCellarScrap(3);
                bodegasNew = clsCoilCellar.lstCellarScrap(4);
            }
            else
            {
                bodegas = clsCoilCellar.lstCellarScrap(4);
                bodegasNew = clsCoilCellar.lstCellarScrap(3);
            }

            if (cmbOrigen.Text == string.Empty)
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbOrigen.Items.Add(bodegas[i]);
                }

                for (int j = 0; j < bodegasNew.Count; j++)
                {
                    cmbDestino.Items.Add(bodegasNew[j]);
                }

                    cmbDestino.Enabled = false;
            }
            else
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbDestino.Items.Add(bodegas[i]);
                }
            }
            
        }
#endregion

        #region Carga de Scrap pallet

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if ((cmbDestino.Text != string.Empty) && (cmbOrigen.Text != string.Empty))
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        if (cmbOrigen.Text != cmbDestino.Text)
                        {
                            clsCoilCellar bodega = new clsCoilCellar(cmbOrigen.SelectedItem.ToString()); // el fk de la bodega
                            clsScrapPallet scrapPallet = new clsScrapPallet(txtCodigo.Text);
                            scrapPBCC = new clsScrapPalletByCoilCellar(scrapPallet.codsec); // Tiene el fkCoilCellar donde esta el pallet

                            if (bodega.codsec == scrapPBCC.fkCoilCellar) // Si coinciden es por que las se encuentra en esa bodega
                            {
                                if (scrapPallet.codsec != 0)
                                {
                                    if (scrapPallet.fkStatus == 38)
                                    {
                                        if (dgvIntercellarMovement.Rows.Count > 0)
                                        {
                                            foreach (DataGridViewRow row in dgvIntercellarMovement.Rows)
                                            {
                                                if (scrapPallet.codsec == Convert.ToInt32(row.Cells[clmCodsec.Index].Value))
                                                {
                                                    MessageBox.Show("Codigo ya ingresado. Por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK);
                                                    bandera = true;
                                                }
                                            }

                                            if (bandera != true)
                                            {
                                                dgvIntercellarMovement.Rows.Add();
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmCodsec.Index].Value = scrapPallet.codsec;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmCodigo.Index].Value = scrapPallet.code;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmTipo.Index].Value = scrapPallet.Scrap.name;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmMachine.Index].Value = scrapPallet.Machine.Cutter;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmPeso.Index].Value = scrapPallet.netWeigth;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmTurno.Index].Value = scrapPallet.turn;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = cmbOrigen.Text;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbDestino.Text;
                                                dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                                cmbDestino.ResetText();
                                                cmbOrigen.ResetText();
                                                txtCodigo.ResetText();
                                            }
                                        }
                                        else
                                        {
                                            dgvIntercellarMovement.Rows.Add();
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmCodsec.Index].Value = scrapPallet.codsec;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmCodigo.Index].Value = scrapPallet.code;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmTipo.Index].Value = scrapPallet.Scrap.name;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmMachine.Index].Value = scrapPallet.Machine.Cutter;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmPeso.Index].Value = scrapPallet.netWeigth;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmTurno.Index].Value = scrapPallet.turn;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = cmbOrigen.Text;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbDestino.Text;
                                            dgvIntercellarMovement.Rows[dgvIntercellarMovement.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                            cmbDestino.ResetText();
                                            cmbOrigen.ResetText();
                                            txtCodigo.ResetText();

                                        }
                                        calculoSubtotales();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El pallet que intenta cargar debe de estar Activo para ingresarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        cmbDestino.ResetText();
                                        cmbOrigen.ResetText();
                                        txtCodigo.ResetText();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK);
                                    cmbDestino.ResetText();
                                    cmbOrigen.ResetText();
                                    txtCodigo.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta ingresar no se encuentra en la bodega de Origen que selecciono", "¡Error!", MessageBoxButtons.OK);
                                cmbDestino.ResetText();
                                cmbOrigen.ResetText();
                                txtCodigo.ResetText();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Esta intentando hacer un swap a la misma bodega, por favor seleccione otra bodega de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete el codigo de pallet", "¡Error!", MessageBoxButtons.OK);

                    }
                }
                else
                {
                    MessageBox.Show("Complete primero Bodega Origen y Bodega Destino", "¡Error!", MessageBoxButtons.OK);

                }
            }
        }

        private void dgvIntercellarMovement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvIntercellarMovement.Rows.RemoveAt(dgvIntercellarMovement.CurrentRow.Index);
                calculoSubtotales();
            }
        }

        #endregion

        #region Boton Procesar

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvIntercellarMovement.Rows.Count > 0)
            {
                for (int i = 0; i < dgvIntercellarMovement.Rows.Count; i++)
                {
                    palletScrap = new clsScrapPallet(Convert.ToString(dgvIntercellarMovement.Rows[i].Cells[clmCodigo.Index].Value));
                    scrapPBCC = new clsScrapPalletByCoilCellar(palletScrap.codsec);
                    clsCoilCellar bodegaNueva = new clsCoilCellar(Convert.ToString(dgvIntercellarMovement.Rows[i].Cells[clmBodegaDestino.Index].Value));

                    //Antes de cambiar la bodega nueva la guardo
                    movimientos.fkOriginalCellar = scrapPBCC.fkCoilCellar;
                    scrapPBCC.fkCoilCellar = bodegaNueva.codsec;
                    movimientos.fkScrap = palletScrap.fkScrap;
                    movimientos.type = "Movimiento de Pallet de Scrap a bodega " + bodegaNueva.name;
                    movimientos.fkScrapPallet = palletScrap.codsec;
                    movimientos.fkDestinationCellar = bodegaNueva.codsec;
                    movimientos.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientos.date = DateTime.Now;
                    movimientos.netWeigth = Convert.ToDouble(dgvIntercellarMovement.Rows[i].Cells[clmPeso.Index].Value);

                    scrapPBCC.save();
                    movimientos.save();
                    palletScrap.save();

                }
            }
            else
            {
                MessageBox.Show("La tabla esta vacia", "Llenar Tabla", MessageBoxButtons.OK);
            }

            dgvIntercellarMovement.Rows.Clear();
            MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            txtCodigo.Text = string.Empty;
            cmbDestino.ResetText();
            cmbOrigen.ResetText();
        }

        #endregion

        #region Calculo Subtotales
        private void calculoSubtotales()
        {
            double pesos = 0;
            foreach (DataGridViewRow row in dgvIntercellarMovement.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPeso.Index].Value);
            }
            txtPalletCant.Text = dgvIntercellarMovement.Rows.Count.ToString();
            txtKgTot.Text = Math.Round(pesos, 2).ToString();
        }
        #endregion

    }
}
