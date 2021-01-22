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
    public partial class frmRawMaterialDispatch : Form
    {
        clsRawPalletByCoilCellar rawpbcc = new clsRawPalletByCoilCellar();
        clsRawMaterialPallet rawMatPallet = new clsRawMaterialPallet();
        clsRawMaterialMovements movimientoRaw = new clsRawMaterialMovements();

        public frmRawMaterialDispatch()
        {
            InitializeComponent();
        }

        #region Carga de Despacho
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;   

            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodigo.Text != string.Empty)
                {
                    clsRawMaterialPallet rawPallet = new clsRawMaterialPallet(txtCodigo.Text);
                    rawpbcc = new clsRawPalletByCoilCellar(rawPallet.codsec);

                    if (rawPallet.codsec != 0)
                    {
                        if (rawPallet.fkStatus == 38)
                        {
                            if (rawPallet.fkRaw == 256 || rawPallet.fkRaw == 255 || rawPallet.fkRaw == 276 || rawPallet.fkRaw == 277 || rawPallet.fkRaw == 278 || rawPallet.fkRaw == 279 || rawPallet.fkRaw == 292 || rawPallet.fkRaw == 293 || rawPallet.fkRaw == 294 || rawPallet.fkRaw == 295 || rawPallet.fkRaw == 303 || rawPallet.fkRaw == 332 || rawPallet.fkRaw == 333 || rawPallet.fkRaw == 282 || rawPallet.fkRaw == 302 || rawPallet.fkRaw == 332 || rawPallet.fkRaw == 336)
                            {
                                if (dgvDispatchRawMat.Rows.Count > 0)
                                {
                                    foreach (DataGridViewRow row in dgvDispatchRawMat.Rows)
                                    {
                                        if (rawPallet.code == Convert.ToString(row.Cells[clmCodigo.Index].Value))
                                        {
                                            MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                            bandera = true;
                                        }
                                    }

                                    if (bandera != true)
                                    {
                                        dgvDispatchRawMat.Rows.Add();
                                        dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmCodsec.Index].Value = rawPallet.codsec;
                                        dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmCodigo.Index].Value = rawPallet.code;
                                        dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmDescr.Index].Value = rawPallet.rawMaterial.name;
                                        dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmLote.Index].Value = rawPallet.lote;
                                        dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmPeso.Index].Value = rawPallet.netweigth;
                                        dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmFecha.Index].Value = rawPallet.date;

                                        txtCodigo.ResetText();

                                    }
                                }
                                else
                                {
                                    dgvDispatchRawMat.Rows.Add();
                                    dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmCodsec.Index].Value = rawPallet.codsec;
                                    dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmCodigo.Index].Value = rawPallet.code;
                                    dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmDescr.Index].Value = rawPallet.rawMaterial.name;
                                    dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmLote.Index].Value = rawPallet.lote;
                                    dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmPeso.Index].Value = rawPallet.netweigth;
                                    dgvDispatchRawMat.Rows[dgvDispatchRawMat.Rows.Count - 1].Cells[clmFecha.Index].Value = rawPallet.date;

                                    txtCodigo.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El material que intenta cargar no es para la venta, caso contrario por favor contacte con el administrador del sistema", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pallet que intenta despachar se encuentra cerrado o en otro estado, por favor consulte con el adminsitrador del sistema", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        //aca iria
                    }
                    else
                    {
                        MessageBox.Show("El material que intenta cargar no existe, o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor Complete el código de pallet", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                calculoDeSubtotales();
            }
        }

        private void dgvDispatchRawMat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvDispatchRawMat.Rows.RemoveAt(dgvDispatchRawMat.CurrentRow.Index);
                calculoDeSubtotales();
            }
        }

#endregion

        #region Procesamiento de Despacho

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool pmov = false;
            bool prawpallsv = false;

            if (dgvDispatchRawMat.Rows.Count > 0)
            {
                for (int i = 0; i < dgvDispatchRawMat.Rows.Count; i++)
                {
                    rawMatPallet = new clsRawMaterialPallet(Convert.ToString(dgvDispatchRawMat.Rows[i].Cells[clmCodigo.Index].Value));
                    rawpbcc = new clsRawPalletByCoilCellar(Convert.ToInt32(rawMatPallet.codsec));

                    movimientoRaw.fkRaw = rawMatPallet.fkRaw;
                    movimientoRaw.type = "Despacho de Materia Prima por Venta";
                    movimientoRaw.fkRawPallet = rawMatPallet.codsec;
                    movimientoRaw.lote = rawMatPallet.lote;
                    movimientoRaw.netWeigth = rawMatPallet.netweigth;
                    movimientoRaw.estrusionLote = "";
                    movimientoRaw.fkDestCellar = rawpbcc.fkCoilCellar;
                    movimientoRaw.fkOrigCellar = rawpbcc.fkCoilCellar;
                    movimientoRaw.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientoRaw.date = DateTime.Now;

                    rawMatPallet.fkStatus = 40;

                    pmov = movimientoRaw.save();
                    prawpallsv = rawMatPallet.save();
                }

                if (pmov == true || prawpallsv == true)
                {
                    MessageBox.Show("Los datos se procesaron con Exito", "¡Exito!", MessageBoxButtons.OK);
                    dgvDispatchRawMat.Rows.Clear();
                    txtCodigo.ResetText();
                }
            }
            else
            {
                MessageBox.Show("La tabla se encuentra vacia", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region CalculoDeSubtotales
        private void calculoDeSubtotales()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvDispatchRawMat.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPeso.Index].Value);
          
            }
            txtTotPallet.Text = dgvDispatchRawMat.Rows.Count.ToString();
            txtTotKilos.Text = Math.Round(pesos, 2).ToString();
        }
        #endregion
    }
}
