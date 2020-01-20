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
    public partial class frmInterCellarMovement : Form
    {
        clsCoilCellar bodegas = new clsCoilCellar();
        clsRawPalletByCoilCellar rawPalletBCC = new clsRawPalletByCoilCellar();
        clsRawMaterialPallet rawPallet = new clsRawMaterialPallet();
        clsRawMaterialMovements movimientosRaw = new clsRawMaterialMovements();

        public frmInterCellarMovement()
        {
            InitializeComponent();
        }

        private void frmInterCellarMovement_Load(object sender, EventArgs e)
        {
            cargarCombos();
            pnlKgaMover.Enabled = false;
            chkMovParcial.Enabled = false;
        }

        #region Carga de Movimiento.
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;
            double pesoPallet = 0;

            if (e.KeyCode == Keys.Enter)
            {
                if ((cmbOrigen.Text != string.Empty) && (cmbDestino.Text != string.Empty))
                {
                    if (txtCodigo.Text != string.Empty)
                    {
                            clsCoilCellar bodega = new clsCoilCellar(cmbOrigen.SelectedItem.ToString());
                            clsRawMaterialPallet rawPallet = new clsRawMaterialPallet(txtCodigo.Text);
                            rawPalletBCC = new clsRawPalletByCoilCellar(rawPallet.codsec);
                           
                            if (bodega.codsec == rawPalletBCC.fkCoilCellar)
                            {
                                if (rawPallet.codsec != 0)
                                {
                                    pesoPallet = rawPallet.netweigth;
                                 
                                    if (pesoPallet >= 0)
                                    {
                                        if (dgvSwapMP.Rows.Count > 0)
                                        {
                                            foreach (DataGridViewRow row in dgvSwapMP.Rows)
                                            {
                                                if (rawPallet.code == Convert.ToString(row.Cells[clmCodigo.Index].Value))
                                                {
                                                    MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                    bandera = true;
                                                }
                                            }

                                            if (bandera != true)
                                            {
                                                dgvSwapMP.Rows.Add();
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmCodigo.Index].Value = rawPallet.code;
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmTipo.Index].Value = rawPallet.rawMaterial.name;
                                                if ((chkMovParcial.Checked == true) && (txtKgaMover.Text != string.Empty)) //Comentario: si no carga el txt se va a mover todo el pallet.
                                                {
                                                    pesoPallet = pesoPallet - Convert.ToDouble(txtKgaMover.Text);
                                                    dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmPeso.Index].Value = txtKgaMover.Text;
                                                }
                                                else
                                                {
                                                    dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmPeso.Index].Value = rawPallet.netweigth;
                                                }
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmLote.Index].Value = rawPallet.lote;
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmOrigen.Index].Value = cmbOrigen.SelectedItem.ToString();
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmDestino.Index].Value = cmbDestino.SelectedItem.ToString();
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                                cmbDestino.ResetText();
                                                cmbOrigen.ResetText();
                                                txtCodigo.Text = string.Empty;
                                            }
                                        }
                                        else
                                        {
                                            dgvSwapMP.Rows.Add();
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmCodigo.Index].Value = rawPallet.code;
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmTipo.Index].Value = rawPallet.rawMaterial.name;
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmLote.Index].Value = rawPallet.lote;
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmOrigen.Index].Value = cmbOrigen.SelectedItem.ToString();
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmDestino.Index].Value = cmbDestino.SelectedItem.ToString();
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                            if ((chkMovParcial.Checked == true) && (txtKgaMover.Text != string.Empty)) //Comentario: si no carga el txt se va a mover todo el pallet.
                                            {
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmPeso.Index].Value = txtKgaMover.Text;
                                            }
                                            else if(chkMovParcial.Checked != true)
                                            {
                                                dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmPeso.Index].Value = rawPallet.netweigth;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Por favor complete la cantidad de Kilos que desea mover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                dgvSwapMP.Rows.Clear();
                                            }

                                            cmbDestino.ResetText();
                                            cmbOrigen.ResetText();
                                            txtCodigo.Text = string.Empty;
                                            txtKgaMover.Text = string.Empty;
                                            chkMovParcial.Checked = false;

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("No puede consumir mas de lo que el pallet posee.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                        cmbDestino.ResetText();
                                        cmbOrigen.ResetText();
                                        txtCodigo.ResetText();
                                        txtKgaMover.Text = string.Empty;

                                        cmbDestino.Enabled = false;
                                        cmbDestino.SelectedIndex = -1;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    cmbDestino.ResetText();
                                    cmbOrigen.ResetText();
                                    txtCodigo.ResetText();

                                    cmbDestino.Enabled = false;
                                    chkMovParcial.Checked = false;
                                    txtKgaMover.Text = string.Empty;
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta ingresar no se encuentra en la bodega de Origen que selecciono", "¡Error!", MessageBoxButtons.OK);
                                cmbDestino.ResetText();
                                cmbOrigen.ResetText();
                                txtCodigo.ResetText();


                                cmbDestino.Enabled = false;
                                chkMovParcial.Checked = false;
                                txtKgaMover.Text = string.Empty;
                            }
                    }
                    else
                    {
                        MessageBox.Show("Por favor complete el código de pallet", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("Complete primero Bodega Origen y Bodega Destino", "¡Error!", MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }
        #endregion

        #region Eventos del formulario
        private void dgvSwapMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvSwapMP.Rows.RemoveAt(dgvSwapMP.CurrentRow.Index);
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

        private void cmbOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrigen.ResetText();
                cmbOrigen.SelectedIndex = -1;
            }
        }

        #endregion

        #region Procesar Movimiento
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool anduvomov = false;
            bool anduvoPal = false;
            bool psilo = false;
            bool impetique = false;
            bool prawPallet = false; // temporal para el testeo, recordar que cuando salga a produccion esto debe cambiar.
            bool ppalletinSilo = false;
            double pesoPpSilo = 0;


            if (dgvSwapMP.Rows.Count > 0)
            {
                for (int i = 0; i < dgvSwapMP.Rows.Count; i++)
                {
                    rawPallet = new clsRawMaterialPallet(Convert.ToString(dgvSwapMP.Rows[i].Cells[clmCodigo.Index].Value));
                    rawPalletBCC = new clsRawPalletByCoilCellar(rawPallet.codsec);
                    clsCoilCellar bodegaNueva = new clsCoilCellar(Convert.ToString(dgvSwapMP.Rows[i].Cells[clmDestino.Index].Value));

                    movimientosRaw.fkOrigCellar = rawPalletBCC.fkCoilCellar;
                    rawPalletBCC.fkCoilCellar = bodegaNueva.codsec;
                    movimientosRaw.fkRaw = rawPallet.fkRaw;
                    movimientosRaw.type = "Movimiento de Materia prima";
                    movimientosRaw.fkRawPallet = rawPallet.codsec;
                    movimientosRaw.lote = rawPallet.lote.ToUpper();
                    movimientosRaw.netWeigth = Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                    movimientosRaw.estrusionLote = "";
                    movimientosRaw.fkDestCellar = bodegaNueva.codsec;
                    movimientosRaw.date = DateTime.Now;
                    movimientosRaw.fkUser = clsGlobal.LoggedUser.codsec;

                    if (bodegaNueva.isSiloCellar == 1)
                    { //Si sale por esta rama significa que el pallet se esta mandando a un silo.
                        clsRawMaterialBySiloCellar silo = new clsRawMaterialBySiloCellar();

                        silo = clsRawMaterialBySiloCellar.getLastRegByFkSilo(bodegaNueva.codsec);

                        if (silo.codsec == 0) // Esto se hace en el caso hipotetico en el que el silo no tiene nada y se mande un pallet al silo(COMPLETO,no contempla kilos del pallet)
                        {
                            
                            rawPallet.netweigth = rawPallet.netweigth - Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                                
                            silo.fkRawMaterial = rawPallet.fkRaw;
                            silo.fkRawType = rawPallet.rawMaterial.fkRawMaterialtype;
                            silo.lote = rawPallet.lote.ToUpper();
                            silo.weigth = Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                            silo.fkSiloCellar = bodegaNueva.codsec;

                            if (rawPallet.netweigth == 0)
                            {
                                rawPallet.fkStatus = 41;
                                rawPalletBCC.save(); 
                            }
                            prawPallet = rawPallet.save();
                            psilo = silo.save();
                        }
                        else
                        { // por este lado sale, si el silo tiene algo.
                            if (silo.fkRawType == rawPallet.rawMaterial.fkRawMaterialtype) // chequea que el material que quiere se pueda mezclar.
                            {
                                if (silo.lote == rawPallet.lote) //Si el lote es igual, metele que son pasteles
                                {
                                    rawPallet.netweigth = rawPallet.netweigth - Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);

                                    if (rawPallet.netweigth == 0)
                                    {
                                        rawPallet.fkStatus = 41;
                                        rawPalletBCC.save();

                                        silo.weigth = silo.weigth + Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                                        psilo = silo.save();
                                        prawPallet = rawPallet.save();
                                    }
                                    else
                                    {
                                        silo.weigth = silo.weigth + Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                                        psilo = silo.save();
                                        prawPallet = rawPallet.save(); // recordar sacar cuando vaya a produccion full.
                                        impetique = true;
                                        //Impresion de etiquetas para repaletizado 
                                    }
                                }
                                else
                                {
                                    //Aca insertariamos un nuevo registro en el silo, ya que los lotes no son iguales lince.

                                    pesoPpSilo = Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                                    rawPallet.netweigth = rawPallet.netweigth - Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);

                                    if (rawPallet.netweigth == 0)
                                    {
                                        rawPallet.fkStatus = 41;
                                        rawPalletBCC.save();

                                        //Nose para que lo asigno a una variable ahora, pero me imagino en un futuro para que elimine los registros por que si no se va a hacer una BD
                                        // Mucho muy grande por no utilizar otros terminos.

                                        ppalletinSilo = silo.newLoteGiveitByPallet(silo.fkSiloCellar,rawPallet.fkRaw,rawPallet.rawMaterial.fkRawMaterialtype,rawPallet.lote,pesoPpSilo);                                        
                                        prawPallet = rawPallet.save();

                                    }
                                    else
                                    {
                                        ppalletinSilo = silo.newLoteGiveitByPallet(silo.fkSiloCellar, rawPallet.fkRaw, rawPallet.rawMaterial.fkRawMaterialtype, rawPallet.lote, pesoPpSilo);
                                        prawPallet = rawPallet.save(); // recordar sacar cuando vaya a produccion full.
                                        rawPalletBCC.save(); 
                                        impetique = true;
                                        //Impresion de etiquetas para repaletizado 
                                    }
                                }
                            }
                            else
                            {
                                if((bodegaNueva.codsec == 4028 || bodegaNueva.codsec == 4029) )
                                {
                                    if (silo.weigth <= 500) // Tolerancia de 500kg, pero si entre 2 lotes no suma 500kg me ggea la logica. 
                                    {
                                        silo.weigth = silo.weigth + Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                                        psilo = silo.save();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El silo posee más de 500kg y esta fuera del limite de tolerancia. Por favor consuma de dicho silo para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No puede mezclar ese pallet con el contenido del silo", "Error", MessageBoxButtons.OK);
                                }    
                            }
                        }
                    }
                    else
                    { // Si salio por aca significa que el pallet se cambio de bodega simplemente.
                        prawPallet = rawPallet.save();
                        anduvoPal = rawPalletBCC.save();
                    }
                   anduvomov = movimientosRaw.save();

                   if (impetique == true) // Esto va aca por que cargue un dgv, si lo ponia abajo solo me imprimia la ultima etiqueta del pallet si todo habia salido bien. 
                   {
                       if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
                       {
                           clsPrintLabels.printRawLabelPL(rawPallet.codsec);
                       }
                       else
                       {
                           clsPrintLabels.printRawLabel(rawPallet.codsec);
                       }
                   }
                }

                if (anduvomov == true && (anduvoPal == true || psilo == true || prawPallet == true ))
                {
                    dgvSwapMP.Rows.Clear();
                    MessageBox.Show("Datos procesados con exito", "¡Exito!", MessageBoxButtons.OK);
                    txtCodigo.Text = string.Empty;
                    cmbDestino.ResetText();
                    cmbOrigen.ResetText();
                }
                else
                {
                    MessageBox.Show("Se produjo un error en el guardado de datos, por favor contacte a sistemas.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("La tabla se encuentra vacía", "¡Error!", MessageBoxButtons.OK);
            }
        }

        #endregion 

        #region Eventos Formulario 2

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

        private void cargarCombos()
        {
            List<clsCoilCellar> bodegas = new List<clsCoilCellar>();

            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                bodegas = clsCoilCellar.lstSiloAndRawCellar(4);
            }
            else
            {
                bodegas = clsCoilCellar.lstSiloAndRawCellar(3);
            }
            if (cmbOrigen.Text == string.Empty)
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    cmbOrigen.Items.Add(bodegas[i]);
                    cmbDestino.Items.Add(bodegas[i]);
                }
                cmbDestino.Enabled = false;
            }
            else
            {
                for (int i = 0; i < bodegas.Count; i++)
                {
                    if (bodegas[i].ToString() != cmbOrigen.SelectedItem.ToString())
                    {
                        cmbDestino.Items.Add(bodegas[i]);
                    }
                }
                cmbDestino.Items.Remove(cmbOrigen.SelectedItem);
            }
        }

        private void chkMovParcial_CheckedChanged(object sender, EventArgs e)
        {
            pnlKgaMover.Enabled = chkMovParcial.Checked;
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCoilCellar bodega = new clsCoilCellar(cmbDestino.SelectedItem.ToString());

            if (bodega.isSiloCellar == 1)
            {
                chkMovParcial.Enabled = true;
            }
            else
            {
                chkMovParcial.Enabled = false;
            }
        }

        private void txtKgaMover_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigo.Focus();
                SendKeys.Send("{ENTER}");
            }
        }

        private void txtKgaMover_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
