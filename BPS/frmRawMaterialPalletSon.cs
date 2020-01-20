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
    public partial class frmRawMaterialPalletSon : Form
    {

        clsRawMaterialPallet rawPallet = new clsRawMaterialPallet();
        clsRawPalletByCoilCellar bodega = new clsRawPalletByCoilCellar();
        clsRawMaterialMovements movimiento = new clsRawMaterialMovements();

        public frmRawMaterialPalletSon()
        {
            InitializeComponent();
        }

        #region Carga del pallet hijo.

        private void txtKgSeparar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rawPallet = new clsRawMaterialPallet(txtCodPallet.Text);

                if (rawPallet.codsec != 0)
                {
                    if (rawPallet.fkStatus == 38)
                    {
                        double pesoPallet = rawPallet.netweigth - Convert.ToDouble(txtKgSeparar.Text);

                        if (pesoPallet >= 0)
                        {
                            txtPesoPadre.Text = pesoPallet.ToString();
                            txtPesoHijo.Text = txtKgSeparar.Text;
                            txtCodPadre.Text = txtCodPallet.Text;
                            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
                            {
                                clsPlant planta = new clsPlant(3);
                                txtHijo.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + planta.abr + "H" + clsGlobal.FillWithZeros(((new clsSequential().rawPallet).ToString()), 5);
                                clsSequential.addSequential("rawPallet");
                            }
                            else
                            {
                                clsPlant planta = new clsPlant(4);
                                txtHijo.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + planta.abr + "H" + clsGlobal.FillWithZeros(((new clsSequential().rawPallet).ToString()), 5);
                                clsSequential.addSequential("rawPallet");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Esta intentando consumir más cantidad de lo que tiene el pallet, por favor vea el peso del pallet.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pallet que esta intentando modificar, se encuentra cerrado o en otro estado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("El pallet que ingresó no existe o el código es erroneo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCodPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rawPallet = new clsRawMaterialPallet(txtCodPallet.Text);

                if (rawPallet.codsec != 0)
                {
                    txtPeso.Text = rawPallet.netweigth.ToString();
                }
                else
                {
                    MessageBox.Show("El pallet que ingresó no existe o el código es erroneo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
        #endregion  

        #region Boton Generar Pallet Hijo. 

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (txtCodPallet.Text != string.Empty && txtKgSeparar.Text != string.Empty)
            {
                rawPallet = new clsRawMaterialPallet(txtCodPallet.Text);

                if (rawPallet.codsec != 0)
                {
                    if (rawPallet.fkStatus == 38)
                    {
                        rawPallet.netweigth = Convert.ToDouble(txtPesoPadre.Text);
                        bool srawpallet = rawPallet.save();

                        clsRawMaterialPallet palletNuevo = new clsRawMaterialPallet();

                        palletNuevo.code = txtHijo.Text;
                        palletNuevo.date = DateTime.Now;
                        palletNuevo.fkRaw = rawPallet.fkRaw;
                        palletNuevo.fkUser = clsGlobal.LoggedUser.codsec;
                        palletNuevo.netweigth = Convert.ToDouble(txtPesoHijo.Text);
                        palletNuevo.fkStatus = 38;
                        palletNuevo.lote = rawPallet.lote;
                        palletNuevo.notes = "Pallet hijo de " + rawPallet.code;

                        bool spalletnuevo = palletNuevo.save();

                        clsRawMaterialPallet palletnuevo2 = new clsRawMaterialPallet(txtHijo.Text);

                        if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
	                    {
                            bodega.fkCoilCellar = 4020;
                            bodega.fkRawPallet = palletnuevo2.codsec;
	                    }
                        else
                        {
                            bodega.fkCoilCellar = 4019;
                            bodega.fkRawPallet = palletnuevo2.codsec;                           
                        }

                        bool sbodegea = bodega.save();

                        movimiento.date = DateTime.Now;
                        movimiento.estrusionLote = "";
                        movimiento.fkDestCellar = bodega.fkCoilCellar;
                        movimiento.fkOrigCellar = bodega.fkCoilCellar;
                        movimiento.fkRaw = palletNuevo.fkRaw;
                        movimiento.fkRawPallet = palletnuevo2.codsec;
                        movimiento.fkUser = clsGlobal.LoggedUser.codsec;
                        movimiento.lote = palletNuevo.lote;
                        movimiento.netWeigth = palletNuevo.netweigth;
                        movimiento.type = "Se Generó un pallet hijo a partir de " + rawPallet.code;

                        bool movimientos = movimiento.save();

                        if (srawpallet && spalletnuevo && sbodegea && movimientos)
                        {
                            MessageBox.Show("Los datos se guardaron con Exito. Imprimiendo etiqueta","¡Exito!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
                            {
                                clsPrintLabels.printRawLabel(palletnuevo2.codsec);
                                clsPrintLabels.printRawLabel(rawPallet.codsec);
                            }
                            else
                            {
                                clsPrintLabels.printRawLabelPL(palletnuevo2.codsec);
                                clsPrintLabels.printRawLabelPL(rawPallet.codsec);
                            }

                            txtCodPallet.Text = string.Empty;
                            txtCodPadre.Text = string.Empty;
                            txtHijo.Text = string.Empty;
                            txtKgSeparar.Text = string.Empty;
                            txtPeso.Text = string.Empty;
                            txtPesoHijo.Text = string.Empty;
                            txtPesoPadre.Text = string.Empty;
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error en el guardado de los datos por favor comuniquese con el Administrador del Sistema.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pallet que se ingreso, no se encuentrada dado de alta");
                    }
                }
                else
                {
                    MessageBox.Show("El pallet que ingreso no existe o el código es erroneo","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtCodPallet.BackColor = Color.Salmon;
                }
            }
            else
            {
                if (txtCodPallet.Text == string.Empty)
                {
                    txtCodPallet.BackColor = Color.Salmon;
                    MessageBox.Show("Por favor, complete el código del pallet","Advertencia",MessageBoxButtons.OK);
                }
                else
                {
                    txtKgSeparar.BackColor = Color.Salmon;
                    MessageBox.Show("Por favor, complete los kilos a consumir antes de continuar");
                }
            }
        }
        #endregion

    }
}
