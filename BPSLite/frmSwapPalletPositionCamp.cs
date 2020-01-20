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
    public partial class frmSwapPalletPositionCamp : Form
    {
        clsPallet pallet = new clsPallet();
        string mensaje = string.Empty;
        string mensajeError = string.Empty;

        public frmSwapPalletPositionCamp(string codigoPallet)
        {
            InitializeComponent();

            if (codigoPallet != string.Empty)
            {
                txtCodigo.Text = codigoPallet;
            }
            else
            {
                txtCodigo.Enabled = true;
            }
        }

        public frmSwapPalletPositionCamp()
        {
            InitializeComponent();

            txtCodigo.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool noanduvoTotalmente = false;
            
            if (dgvPositionChange.Rows.Count > 0)
            {
                for (int i = 0; i < dgvPositionChange.Rows.Count; i++)
                {
                    pallet =  new clsPallet(Convert.ToInt32(dgvPositionChange.Rows[i].Cells[clmCodsec.Index].Value));

                    pallet.position = dgvPositionChange.Rows[i].Cells[clmPosNew.Index].Value.ToString().ToUpper();

                    if (pallet.save())
                    {
                        mensaje = mensaje + "Se asignó correctamente el pallet " + pallet.code + " en la posicion " + dgvPositionChange.Rows[i].Cells[clmPosNew.Index].Value.ToString().ToUpper() + "\n";
                    }
                    else
                    {
                        mensajeError = mensajeError + "No se pudo cambiar de posicion al pallet " + pallet.code + "\n";
                        noanduvoTotalmente = true;
                    }
                }

                if (!noanduvoTotalmente)
                {
                    MessageBox.Show(mensaje, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPositionChange.Rows.Clear();
                    txtPosition.Text = string.Empty;
                    txtCodigo.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                
            }
            else
            {
                MessageBox.Show("No se ha cargado ningún cambio de posición","Advertencia",MessageBoxButtons.OK);
            }
        }

        private void txtPosition_KeyDown(object sender, KeyEventArgs e)
        {
            bool esta = false;

            if (e.KeyCode == Keys.Enter)
            {
                pallet = clsPallet.getDetailByCode(txtCodigo.Text);

                if (pallet.codsec != 0)
                {
                    if (dgvPositionChange.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow rows in dgvPositionChange.Rows)
                        {
                            if (rows.Cells[clmPallet.Index].Value == txtPosition.Text)
                                esta = true;
                        }

                        if (!esta)
	                    {
		                    dgvPositionChange.Rows.Add();
                            dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmCodsec.Index].Value = pallet.codsec;
                            dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPallet.Index].Value = txtCodigo.Text;
                            dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPosAnt.Index].Value = pallet.position;
                            if (txtPosition.Text != string.Empty)
                            {
                                dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPosNew.Index].Value = txtPosition.Text;
                            }
                            else
                            {

                                dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPosNew.Index].Value = "0";
                            }

                            txtCodigo.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("El código de pallet que intenta ingresar, ya se encuentra ingresado.\n Por favor, verifique el cuadro","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    else
                    {


                        dgvPositionChange.Rows.Add();
                        dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmCodsec.Index].Value = pallet.codsec;
                        dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPallet.Index].Value = txtCodigo.Text;
                        dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPosAnt.Index].Value = pallet.position;
                        if (txtPosition.Text != string.Empty)
                        {
                            dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPosNew.Index].Value = txtPosition.Text;
                        }
                        else
                        {

                            dgvPositionChange.Rows[dgvPositionChange.Rows.Count - 1].Cells[clmPosNew.Index].Value = "0";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El código de pallet ingresado es erroneo o el pallet no existe","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}
