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
    public partial class frmNewMetallizedCoils : Form
    {
        clsNewProductionOrderMetal ordenMet = new clsNewProductionOrderMetal();
        int planta;


        public frmNewMetallizedCoils(int fkPlant)
        {
            InitializeComponent();
            planta = fkPlant;
            dgvOrdenesDeMetal(planta);
            grpDetail.Enabled = false;
            limpiarLabels();

        }

        #region Cargar DGV

        private void dgvOrdenesDeMetal(int fkPlant)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwNewProductionOrderMetal WHERE planta = " + fkPlant.ToString());

            dgvProdOrders.Rows.Clear();

            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvProdOrders.Rows.Add();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmLote.Index].Value = DS.Tables[0].Rows[i]["lote"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmFechaCreacion.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["fechaCreacion"]);
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmQuantity.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["cantidad"]);
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmFilmOrg.Index].Value = DS.Tables[0].Rows[i]["FilmInicial"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmMachine.Index].Value = DS.Tables[0].Rows[i]["maquina"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmMachineCodsec.Index].Value = DS.Tables[0].Rows[i]["fkMachine"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmFilmDest.Index].Value = DS.Tables[0].Rows[i]["FilmFinal"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmAncho.Index].Value = DS.Tables[0].Rows[i]["Ancho"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmStatus.Index].Value = DS.Tables[0].Rows[i]["estado"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmCantMBob.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["cantBobinas"]);
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmCantMKilos.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["pesoTot"]), 2);
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmObservation.Index].Value = DS.Tables[0].Rows[i]["Observacion"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmActiveOrder.Index].Value = (DS.Tables[0].Rows[i]["estado"].ToString() == "Proceso") ? global::BPS.Lite.Properties.Resources.Pause_Hot : global::BPS.Lite.Properties.Resources.Play_Hot;

                    if (DS.Tables[0].Rows[i]["estado"].ToString() == "Proceso")
                        dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Orange;
                    else if (DS.Tables[0].Rows[i]["estado"].ToString() == "Pause")
                        dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                    else
                        dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        #endregion

        private void btnMetalizar_Click(object sender, EventArgs e)
        {
            if (!validarOrden() && ordenMet.fkStatus == 1066)
            {
                frmNewMetalCoil metForm = new frmNewMetalCoil(lblLote.Text);
                metForm.MdiParent = this.MdiParent;
                metForm.Show();
            }
            else
            {
                if (ordenMet.fkStatus != 1066 && validarOrden())
                {
                    // Ejecutar la orden.

                    frmNewMetalCoil metForm = new frmNewMetalCoil(lblLote.Text);
                    metForm.MdiParent = this.MdiParent;
                    metForm.Show();
                }
                else
                {
                    MessageBox.Show("Ya hay una orden en ejecucion actualmente. Por favor, detenga la otra orden antes de seguir con la que esta intentando ejecutar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validarOrden()
        {
            bool bandera = true;

            foreach (DataGridViewRow row in dgvProdOrders.Rows)
            {
                if (row.Cells[clmStatus.Index].Value.ToString() == "Proceso")
                {
                    bandera = false;
                    break;
                }
            }
            return bandera;
        }

        private void dgvProdOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grpDetail.Enabled = true;
            ordenMet = new clsNewProductionOrderMetal(dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString());
            lblLote.Text = dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString();
            lblFOrg.Text = dgvProdOrders.CurrentRow.Cells[clmFilmOrg.Index].Value.ToString();
            lblFDest.Text = dgvProdOrders.CurrentRow.Cells[clmFilmDest.Index].Value.ToString();
            lblMaquina.Text = dgvProdOrders.CurrentRow.Cells[clmMachine.Index].Value.ToString();
            lblAncho.Text = dgvProdOrders.CurrentRow.Cells[clmAncho.Index].Value.ToString();
            lblCantKilos.Text = dgvProdOrders.CurrentRow.Cells[clmCantMKilos.Index].Value.ToString();
            lblCantBob.Text = dgvProdOrders.CurrentRow.Cells[clmCantMBob.Index].Value.ToString();
            lblEstado.Text = dgvProdOrders.CurrentRow.Cells[clmStatus.Index].Value.ToString();
            lblMetalizadoKg.Text = dgvProdOrders.CurrentRow.Cells[clmCantMKilos.Index].Value.ToString();
            txtObservaciones.Text = ordenMet.observation;

            if (ordenMet.fkStatus == 1066)
            {
                btnMetalizar.Image = Properties.Resources.eye;
                btnMetalizar.Text = "Ver";
            }
            else
            {
                btnMetalizar.Image = Properties.Resources.gear_32;
                btnMetalizar.Text = "Ejecutar";
            }

        }

        private void dgvProdOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmAdd.Index)
            {
                if (dgvProdOrders.CurrentRow.Cells[clmStatus.Index].Value.ToString() == "Proceso")
                {
                    // Aca abriria el formulario del agregado de bobinas.

                }
            }
        }

        private void limpiarLabels()
        {
            lblAncho.Text = string.Empty;
            lblCantBob.Text = string.Empty;
            lblCantBobinas.Text = string.Empty;
            lblCantKilos.Text = string.Empty;
            lblEstado.Text = string.Empty;
            lblFDest.Text = string.Empty;
            lblFOrg.Text = string.Empty;
            lblLote.Text = string.Empty;
            lblMaquina.Text = string.Empty;
            lblMetalizado.Text = string.Empty;
            lblMetalizadoKg.Text = string.Empty;
        }

        private void frmNewMetallizedCoils_Enter(object sender, EventArgs e)
        {
            dgvOrdenesDeMetal(planta);
        }
    }
}
