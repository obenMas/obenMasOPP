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

        public frmSwapRawPallet()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                if ((cmbBodegaDestino.Text != string.Empty) && (cmbBodegaOrigen.Text != string.Empty))
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                        if (cmbBodegaOrigen.Text != cmbBodegaDestino.Text)
                        {
                            clsCoilCellar bodega = new clsCoilCellar(cmbBodegaOrigen.SelectedItem.ToString());
                            clsRawMaterialPallet palletRaw = new clsRawMaterialPallet(txtCodigo.Text);
                            int numeroBodega = bodegaRaw.getfkCoilCellarByfkRawPallet(palletRaw.codsec);

                            if (bodega.codsec == numeroBodega)
                            {
                                if (palletRaw.codsec != 0)
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
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = cmbBodegaOrigen.Text;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbBodegaDestino.Text;
                                            dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmDate.Index].Value = DateTime.Now;

                                            cmbBodegaDestino.ResetText();
                                            cmbBodegaOrigen.ResetText();
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
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaOrigen.Index].Value = cmbBodegaOrigen.Text;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmBodegaDestino.Index].Value = cmbBodegaDestino.Text;
                                        dgvSwapRawMat.Rows[dgvSwapRawMat.Rows.Count - 1].Cells[clmDate.Index].Value = DateTime.Now;

                                        cmbBodegaDestino.ResetText();
                                        cmbBodegaOrigen.ResetText();
                                        txtCodigo.Text = string.Empty;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                                    cmbBodegaOrigen.ResetText();
                                    cmbBodegaDestino.ResetText();
                                    txtCodigo.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta ingresar no se encuentra en la bodega de Origen que selecciono", "¡Error!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                                cmbBodegaDestino.ResetText();
                                cmbBodegaOrigen.ResetText();
                                txtCodigo.Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete el codigo de pallet", "¡Error!", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void frmSwapRawPallet_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        public void cargarCombos()
        {
            List<clsCoilCellar> bodegas = new List<clsCoilCellar>();

            bodegas = clsCoilCellar.lstRawCellar();

            if (cmbBodegaOrigen.Text == string.Empty)
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbBodegaOrigen.Items.Add(bodegas[i]);
                    cmbBodegaDestino.Items.Add(bodegas[i]);
                }

                cmbBodegaDestino.Enabled = false;
            }
            else
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    if (bodegas[i].ToString() != cmbBodegaOrigen.SelectedItem.ToString())
                    {
                       cmbBodegaDestino.Items.Add(bodegas[i]);
                    }
                }

                cmbBodegaDestino.Items.Remove(cmbBodegaOrigen.SelectedItem);
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvSwapRawMat.Rows.Count > 0)
            {
                for (int i = 0; i < dgvSwapRawMat.Rows.Count; i++)
                {
                    palletRaw = new clsRawMaterialPallet(Convert.ToString(dgvSwapRawMat.Rows[i].Cells[clmCodigo.Index].Value));
                    bodegaRaw = new clsRawPalletByCoilCellar(palletRaw.codsec);
                    clsCoilCellar bodegaNueva = new clsCoilCellar(Convert.ToString(dgvSwapRawMat.Rows[i].Cells[clmBodegaDestino.Index].Value));

                    movimientosRaw.fkOrigCellar = bodegaRaw.fkCoilCellar;
                    bodegaRaw.fkCoilCellar = bodegaNueva.codsec;
                    movimientosRaw.fkRaw = palletRaw.fkRaw;
                    movimientosRaw.type = "Swap de Materia Prima";
                    movimientosRaw.fkRawPallet = palletRaw.codsec;
                    movimientosRaw.fkDestCellar = bodegaNueva.codsec;
                    movimientosRaw.estrusionLote = "";
                    movimientosRaw.lote = palletRaw.lote;
                    movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientosRaw.date = DateTime.Now;
                    movimientosRaw.netWeigth = Convert.ToDouble(dgvSwapRawMat.Rows[i].Cells[clmPeso.Index].Value);

                    bodegaRaw.save();
                    movimientosRaw.save();

                }
            }
            else
            {
                MessageBox.Show("La tabla se encuentra vacia", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvSwapRawMat.Rows.Clear();
            MessageBox.Show("Datos Procesados Correctamente", "Confirmacion", MessageBoxButtons.OK);
            txtCodigo.Text = string.Empty;
            cmbBodegaDestino.ResetText();
            cmbBodegaOrigen.ResetText();
        }

        private void cmbBodegaOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodegaOrigen.ResetText();
                cmbBodegaDestino.ResetText();
                cmbBodegaDestino.SelectedIndex = -1;
                cmbBodegaOrigen.SelectedIndex = -1;
            }
        }

        private void cmbBodegaDestino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodegaDestino.ResetText();
                cmbBodegaOrigen.SelectedIndex = -1;
            }
        }

        private void cmbBodegaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBodegaOrigen.Text != string.Empty)
            {
                cmbBodegaDestino.Enabled = true;
                cmbBodegaDestino.Items.Clear();
                cargarCombos();

            }
            else
            {
                cmbBodegaDestino.Enabled = false;
            }
        }
    }
}
