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
    public partial class frmRawMaterialnyectorConsume : Form
    {
        clsRawMaterialMovements movimientoMP = new clsRawMaterialMovements();
        clsRawMaterialPallet palletMP = new clsRawMaterialPallet();
        clsRawPalletByCoilCellar bodega = new clsRawPalletByCoilCellar();

        public frmRawMaterialnyectorConsume()
        {
            InitializeComponent();
        }

        #region Código de Pallet

        private void txtCodPallet_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;

            if (e.KeyCode == Keys.Enter)
            {
                palletMP = new clsRawMaterialPallet(txtCodPallet.Text);
                bodega = new clsRawPalletByCoilCellar(palletMP.codsec);

                if (palletMP.codsec != 0)
                {
                    if (palletMP.fkStatus == 38)
                    {
                        if (bodega.fkCoilCellar == 4022 || bodega.fkCoilCellar == 4023)
                        {
                            foreach (DataGridViewRow row in dgvConsIny.Rows)
                            {
                                if (palletMP.code == Convert.ToString(row.Cells[clmCodigo.Index].Value))
                                {
                                    MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    bandera = true;
                                }
                            }

                            if (!bandera)
                            {
                                txtKilosCons.Text = palletMP.netweigth.ToString();
                                txtKilosCons.Focus();
                            }
                            else
                            {
                                txtKilosCons.Text = string.Empty;
                                txtCodPallet.Text = string.Empty;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No se puede consumir material que no se encuentra en bodega de extrusión","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txtKilosCons.Text = string.Empty;
                            txtCodPallet.Text = string.Empty;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pallet tiene que encontrarse activo para poder consumirse.");
                        txtKilosCons.Text = string.Empty;
                        txtCodPallet.Text = string.Empty;
                    }
                    
                }
                else
                {
                    MessageBox.Show("El código de pallet es erroneo o el pallet no existe","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtKilosCons.Text = string.Empty;
                    txtCodPallet.Text = string.Empty;
                }
            }
        }

        #endregion

        #region Carga del Datagrid

        private void txtKilosCons_KeyDown(object sender, KeyEventArgs e)
        {
            double pesoFinal = 0;
            bool bandera = false;
           
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodPallet.Text != string.Empty)
                {
                    foreach (DataGridViewRow row in dgvConsIny.Rows)
                    {
                        if (txtCodPallet.Text == Convert.ToString(row.Cells[clmCodigo.Index].Value))
                        {
                            MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            bandera = true;
                        }
                    }

                    if (!bandera)
                    {

                        if (txtKilosCons.Text != string.Empty)
                        {
                            if (Convert.ToDouble(txtKilosCons.Text) > 0)
                            {
                                pesoFinal = Math.Round(palletMP.netweigth - Convert.ToDouble(txtKilosCons.Text), 2);

                                if (pesoFinal > 0)
                                {
                                    dgvConsIny.Rows.Add();
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmCodigo.Index].Value = palletMP.code;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmCodsec.Index].Value = palletMP.codsec;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmConsWeigth.Index].Value = Math.Round(Convert.ToDouble(txtKilosCons.Text), 2);
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmLote.Index].Value = palletMP.lote;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmPesoFinal.Index].Value = pesoFinal;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = palletMP.rawMaterial.name;

                                    txtKilosCons.Text = string.Empty;
                                    txtCodPallet.Text = string.Empty;
                                    calcularConsumo();
                                }
                                else if (pesoFinal == 0)
                                {
                                    dgvConsIny.Rows.Add();
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmCodigo.Index].Value = palletMP.code;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmCodsec.Index].Value = palletMP.codsec;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmConsWeigth.Index].Value = Math.Round(Convert.ToDouble(txtKilosCons.Text), 2);
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmLote.Index].Value = palletMP.lote;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmPesoFinal.Index].Value = pesoFinal;
                                    dgvConsIny.Rows[dgvConsIny.Rows.Count - 1].Cells[clmRawMaterial.Index].Value = palletMP.rawMaterial.name;

                                    txtKilosCons.Text = string.Empty;
                                    txtCodPallet.Text = string.Empty;
                                    calcularConsumo();
                                }
                                else
                                {
                                    MessageBox.Show("No se puede consumir mas cantidad de la que posee el pallet.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtKilosCons.Text = string.Empty;
                                    txtCodPallet.Text = string.Empty;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se puede consumir cantidades negativas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txtKilosCons.Text = string.Empty;
                                txtCodPallet.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, complete los kilos a Consumir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtKilosCons.Text = string.Empty;
                            txtCodPallet.Text = string.Empty;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete el código de pallet por favor.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtKilosCons.Text = string.Empty;
                    txtCodPallet.Text = string.Empty;
                }
            }
        }

        #endregion

        #region Procesar Consumo

        private void btnConsumir_Click(object sender, EventArgs e)
        {
            bool impeeti = false;
            bool anduvo = false;
            bool anduvoMov = false;

            for (int i = 0; i < dgvConsIny.Rows.Count; i++)
			{
                palletMP = new clsRawMaterialPallet(Convert.ToInt32(dgvConsIny.Rows[i].Cells[clmCodsec.Index].Value));

                if (Convert.ToDouble(dgvConsIny.Rows[i].Cells[clmPesoFinal.Index].Value) > 0)
                {
                    movimientoMP.fkDestCellar = 4022;
                    movimientoMP.fkOrigCellar = 4022;
                    movimientoMP.fkRaw = palletMP.fkRaw;
                    movimientoMP.fkRawPallet = Convert.ToInt32(dgvConsIny.Rows[i].Cells[clmCodsec.Index].Value);
                    movimientoMP.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientoMP.date = DateTime.Now;
                    movimientoMP.estrusionLote = palletMP.lote;
                    movimientoMP.netWeigth = Convert.ToDouble(dgvConsIny.Rows[i].Cells[clmConsWeigth.Index].Value); 
                    movimientoMP.type = "Consumo MP para Inyectora";
                    anduvoMov = movimientoMP.save();

                    palletMP.netweigth = Convert.ToDouble(dgvConsIny.Rows[i].Cells[clmPesoFinal.Index].Value);
                    anduvo = palletMP.save();
                    impeeti = true;
                }
                else if (Convert.ToDouble(dgvConsIny.Rows[i].Cells[clmPesoFinal.Index].Value) == 0)
                {
                    movimientoMP.fkDestCellar = 4022;
                    movimientoMP.fkOrigCellar = 4022;
                    movimientoMP.fkRaw = palletMP.fkRaw;
                    movimientoMP.fkRawPallet = Convert.ToInt32(dgvConsIny.Rows[i].Cells[clmCodsec.Index].Value);
                    movimientoMP.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientoMP.date = DateTime.Now;
                    movimientoMP.estrusionLote = palletMP.lote;
                    movimientoMP.netWeigth = Convert.ToDouble(dgvConsIny.Rows[i].Cells[clmConsWeigth.Index].Value);
                    movimientoMP.type = "Consumo MP para Inyectora";
                    anduvoMov = movimientoMP.save();

                    palletMP.netweigth = Convert.ToDouble(dgvConsIny.Rows[i].Cells[clmPesoFinal.Index].Value);
                    palletMP.fkStatus = 41;
                    anduvo = palletMP.save();
                }
                else
                {
                    MessageBox.Show("No se puede consumir mas cantidad de la que tiene el pallet.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (impeeti)
                {
                    if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
                    {
                        clsPrintLabels.printRawLabelPL(Convert.ToInt32(dgvConsIny.Rows[i].Cells[clmCodsec.Index].Value));
                        impeeti = false;
                    }
                    else
                    {
                        clsPrintLabels.printRawLabel(Convert.ToInt32(dgvConsIny.Rows[i].Cells[clmCodsec.Index].Value));
                        impeeti = false;
                    }
                }
            }

            if (anduvo && anduvoMov)
            {
                MessageBox.Show("Se procesaron los datos con Exito","Exito",MessageBoxButtons.OK);
                dgvConsIny.Rows.Clear();
                txtKilosCons.Text = string.Empty;
                txtCodPallet.Text = string.Empty;
                calcularConsumo();
            }
        }

        #endregion

        #region Eventos Formulario

        private void dgvConsIny_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvConsIny.Rows.RemoveAt(dgvConsIny.CurrentRow.Index);
            }
        }

        private void calcularConsumo()
        {
            double kilos = 0;

            foreach (DataGridViewRow rows in dgvConsIny.Rows)
            {
                kilos = kilos + Convert.ToDouble(rows.Cells[clmConsWeigth.Index].Value);
            }

            txtKilos.Text = Math.Round(kilos, 2).ToString();
            txtCantPallet.Text = dgvConsIny.Rows.Count.ToString();
        }
        #endregion

    }
}
