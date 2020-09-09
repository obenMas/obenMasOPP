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
    public partial class frmNewShippings : Form
    {

        clsNewPreShipping PD = new clsNewPreShipping();
        DataSet DS = new DataSet();
        List<clsNewPreShippingDetail> PdDetail = new List<clsNewPreShippingDetail>();
        clsPallet pallet = new clsPallet();
        clsShippings despacho = new clsShippings();
        clsEntity cliente = new clsEntity();
        clsCoilMovements coilMovements = new clsCoilMovements();


        public frmNewShippings()
        {
            InitializeComponent();
        }

        #region Carga del Dgv

        private void txtPdCode_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPdCode.Text != string.Empty && laPistolaImprimeBien())
                {

                    PD = new clsNewPreShipping(txtPdCode.Text);

                    DS = clsNewPreShipping.getDetailForDispatchWithouClasses(txtPdCode.Text);

                    if (PD.codsec != 0)
                    {
                        if (PD.fkStatus == 3068)
                        {
                            dgvShippings.Rows.Clear();

                            PdDetail = PD.getDetail();

                            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
                            {
                                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                                {
                                    dgvShippings.Rows.Add();

                                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["fkstatus"]) == 40)
                                    {
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmCheck.Index].Value = false;
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmStatus.Index].Value = "Despachado";
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LawnGreen;
                                    }
                                    else if(Convert.ToInt32(DS.Tables[0].Rows[i]["fkstatus"]) == 3073)
                                    {
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmStatus.Index].Value = "Pre-Despachado";
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmCheck.Index].Value = true;
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                                    }
                                    else
                                    {
                                        dgvShippings.Rows[dgvShippings.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Salmon;
                                    }

                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmCliente.Index].Value = DS.Tables[0].Rows[i]["cliente"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmCodsec.Index].Value = DS.Tables[0].Rows[i]["codsec"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmCode.Index].Value = DS.Tables[0].Rows[i]["pallet"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmPD.Index].Value = DS.Tables[0].Rows[i]["pd"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmPEso.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["peso"]), 2).ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmPosition.Index].Value = DS.Tables[0].Rows[i]["posicion"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmProduct.Index].Value = DS.Tables[0].Rows[i]["producto"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmSaleOrder.Index].Value = DS.Tables[0].Rows[i]["Orden"].ToString();
                                    dgvShippings.Rows[dgvShippings.Rows.Count - 1].Cells[clmfkStatus.Index].Value = DS.Tables[0].Rows[i]["fkstatus"];
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Pre-Despacho Seleccionado se encuentra programado, pero no posee ningun pallet en él. Por favor, corrobore ésta info con los sectores correspondientes","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }

                            palletADespachar();

                        }
                        else if(PD.fkStatus == 3067)
                        {
                            MessageBox.Show("El Pre-Despacho que intenta despachar se encuentra en estado " + new clsStatus(PD.fkStatus).name + "\n Por favor solicite la programación del PD.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("El Pre-Despacho que intenta despachar se encuentra en estado " + new clsStatus(PD.fkStatus).name, "Despachado / Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pre-despacho que ingreso no existe, o el código es erroneo. Verifíquelo, por favor.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        txtPdCode.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor complete el código de Pre-Despacho");
                    txtPdCode.Focus();
                }
            }
        }

        #endregion 

        #region Pallet a Despachar y/o Despachados

        private void palletADespachar()
        {
            int pltDispatch = 0;

            foreach (DataGridViewRow row in dgvShippings.Rows)
            {
                if (Convert.ToBoolean(row.Cells[clmCheck.Index].Value))
                {
                    pltDispatch++;
                }
            }

            lblX.Text = pltDispatch.ToString();
            lblY.Text = palletRestantes().ToString();
        }

        private int palletRestantes()
        {
            int pltRest = 0;

            foreach (DataGridViewRow row in dgvShippings.Rows)
            {
                if (Convert.ToInt32(row.Cells[clmfkStatus.Index].Value) == 40)
                {
                    pltRest++;
                }
            }

            return dgvShippings.Rows.Count - pltRest;
        }

        #endregion

        #region Seleccionar Que pallet no se van a despachar

        private void dgvShippings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.ColumnIndex == clmCheck.Index)
            {
                if (Convert.ToBoolean(dgvShippings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) && (Convert.ToInt32(dgvShippings.Rows[e.RowIndex].Cells[clmfkStatus.Index].Value) == 3073))
                {
                    var rta = MessageBox.Show("Esta por quitar un pallet del despacho. ¿Esta seguro de realizar esta acción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (rta == DialogResult.Yes)
                    {
                        dgvShippings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                    }
                    else
                    {
                        dgvShippings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                    }
                }
                else if (!Convert.ToBoolean(dgvShippings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) && (Convert.ToInt32(dgvShippings.Rows[e.RowIndex].Cells[clmfkStatus.Index].Value) == 3073))
                {
                    dgvShippings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else if (!Convert.ToBoolean(dgvShippings.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) && (Convert.ToInt32(dgvShippings.Rows[e.RowIndex].Cells[clmfkStatus.Index].Value) == 40))
                {
                    MessageBox.Show("No puede seleccionar para despachar un pallet que ya se despacho.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                palletADespachar();
            }
        }

        #endregion

        #region Procesar Despacho

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            var rta = MessageBox.Show("Está por despachar " + lblX.Text + " de " + lblY.Text + " del Pre-Despacho N°: " + PD.number + ".\n ¿Esta seguro de realizar esta acción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            bool pdIncompleto = false;
            bool bobinaOK = false;
            bool nohagoNada = false;

            if (dgvShippings.Rows.Count > 0)
            {
                switch (rta)
                {
                    case DialogResult.No:
                        nohagoNada = true;
                        break;
                    case DialogResult.Yes:
                        for (int i = 0; i < dgvShippings.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dgvShippings.Rows[i].Cells[clmCheck.Index].Value))
                            {

                                pallet = new clsPallet(Convert.ToInt32(dgvShippings.Rows[i].Cells[clmCodsec.Index].Value));

                                // Se tiene que hacer el movimiento de despacho en la tabla shippings.
                                clsPallet.setPalletAsDelivered(pallet.codsec);
                                //Tengo que despachar por bobina
                                for (int j = 0; j < pallet.lstCoil.Count; j++)
                                {
                                    coilMovements.fkCoil = pallet.lstCoil[j].codsec;
                                    coilMovements.fkDestCellar = pallet.fkPalletCoilcellar;
                                    coilMovements.fkOrgCellar = pallet.fkPalletCoilcellar;
                                    coilMovements.fkUser = clsGlobal.LoggedUser.codsec;
                                    coilMovements.length = Convert.ToInt32(pallet.lstCoil[j].length);
                                    coilMovements.netWeigth = Math.Round(pallet.lstCoil[j].netWeight,2);
                                    coilMovements.type = "Se Despacho la Bobina";
                                    coilMovements.date = DateTime.Now;

                                    bobinaOK = coilMovements.save();
                                }
                                if (bobinaOK)
                                {
                                    dgvShippings.CurrentRow.DefaultCellStyle.BackColor = Color.LimeGreen;
                                }  
                            }
                            //Tengo que cerrar el PD
                        }
                        break;
                }

                if (!nohagoNada)
                {
                    if (lblX.Text != lblY.Text)
                    {
                        pdIncompleto = true;
                    }

                    if (!pdIncompleto)
                    {
                        MessageBox.Show("Se despacho el PD completo, correctamente.", "¡Exito!", MessageBoxButtons.OK);
                        PD.setAsDispatched();
                        dgvShippings.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Se despacho el PD incompleto. Recuerde informar de ésto al area comercial", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvShippings.Rows.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un pre-despacho", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region checkeoTxt

        private bool laPistolaImprimeBien()
        {
            if (txtPdCode.Text.IndexOf('-') == -1)
            {
                if (txtPdCode.Text.Length == 8)
                {
                    txtPdCode.Text = txtPdCode.Text.Substring(0, 2) + '-' + txtPdCode.Text.Substring(3, 5);

                    if (txtPdCode.Text.IndexOf('-') == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        #endregion


    }
}
