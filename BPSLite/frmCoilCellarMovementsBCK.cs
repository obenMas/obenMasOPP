using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmCoilCellarMovementsBCK : Form
    {
        clsPallet objPallet = new clsPallet();
        Thread thrdMovementType;
        clsCoilCellar objDestinationCellar = new clsCoilCellar();


        public frmCoilCellarMovementsBCK()
        {
            InitializeComponent();
        }

        public void setMovementType()
        {
            this.Invoke((MethodInvoker)delegate { txtMovement.Enabled = false; });
            this.Invoke((MethodInvoker)delegate { setMovement(); });
            this.Invoke((MethodInvoker)delegate { txtMovement.Enabled = true; });
        }
        public void setMovement()
        {
            clsCoilCellarMovement objCoilCellarMovement = clsCoilCellarMovement.getCoilCellarDetailByCode(txtMovement.Text);
            objDestinationCellar = new clsCoilCellar();

            if (objCoilCellarMovement.codsec > 0)
            {
                objDestinationCellar = new clsCoilCellar(objCoilCellarMovement.fkCoilCellar);

                if (objCoilCellarMovement.inputToCellar)
                {
                    tbpPallets.Text = "Ingreso de pallet a bodega";
                    tbpPallets.ImageIndex = 0;
                }
                else
                {
                    tbpPallets.Text = "Salida de pallet a bodega";
                    tbpPallets.ImageIndex = 1;
                }

                tbcMovements.SelectedIndex = 1;

                txtPalletCode.Text = "";
                lblDestination.Text = "";
                txtGrossWeigth.Text = "0.0";
                lblNetWeigth.Text = "0.0";
                lblDestinationCellar.Text = "";
                lblPalletType.Text = "";
                lblProduct.Text = "";
                lblCoilCount.Text = "Bobinas : -- / --";
                dgvCoils.Rows.Clear();


                ActiveControl = txtPalletCode;
            }
            else
            {
                MessageBox.Show("Código de movimiento a bodega no reconocido", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

        }
        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPalletCode.Text == "Cancel")
                {
                    tbpPallets.Text = "Pallets";
                    tbpPallets.ImageIndex = -1;
                    tbcMovements.SelectedIndex = 0;
                    txtMovement.Text = "";
                    ActiveControl = txtMovement;
                }
                else if (txtPalletCode.Text != "")
                {
                    objPallet = clsPallet.getDetailByCode(txtPalletCode.Text);

                    if (objPallet.codsec != 0)
                    {
                        clsSalesOrder objSalesOrder = new clsSalesOrder();

                        objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);


                        if (objSalesOrder.codsec > 0)
                        {
                            lblDestination.Text = objSalesOrder.EntityName;
                        }

                        else
                        {
                            lblDestination.Text = "Stock";
                        }


                        lblPalletType.Text = objPallet.palletType.ToString();
                        lblProduct.Text = objPallet.product.name;
                        lblCoilCount.Text = "Bobinas : 0 / " + objPallet.palletType.coilNumber.ToString();
                        dgvCoils.Rows.Clear();

                        for (int i = 0; i < objPallet.lstCoil.Count; i++)
                        {
                            dgvCoils.Rows.Add();
                            dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                            dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                            dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                            dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 2));
                            dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                        }
                        lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPallet.palletType.coilNumber.ToString();
                        lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 2));
                        txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 2));

                        //if (clsPallet.transferTo(objPallet.codsec, objDestinationCellar.codsec))
                        //{
                        //    lblDestinationCellar.ForeColor = Color.FromArgb(0, 192, 0);
                        //    lblDestinationCellar.Text = "Bodega de " + objDestinationCellar.name;

                        //    ActiveControl = btnReturn; 

                        //}
                        //else
                        //{
                        //    lblDestinationCellar.ForeColor = Color.Red;
                        //    lblDestinationCellar.Text = "Error al transferir pallet";

                        //    ActiveControl = btnReturn;                            
                        //}


                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no corresponde a ningun pallet registrado. Por favor intente de nuevo.", "Movimientos de bodega", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        txtPalletCode.Text = "";
                        txtPalletCode.Focus();

                    }
                }
            }
        }

        private void frmCoilCellarMovements_Load(object sender, EventArgs e)
        {
            ActiveControl = txtMovement;
        }

        private void txtMovement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                thrdMovementType = new Thread(delegate() { setMovementType(); });
                thrdMovementType.Start();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tbpPallets.Text = "Pallets";
            tbpPallets.ImageIndex = -1;
            tbcMovements.SelectedIndex = 0;
            txtMovement.Text = "";
            ActiveControl = txtMovement;
        }
    }
}
