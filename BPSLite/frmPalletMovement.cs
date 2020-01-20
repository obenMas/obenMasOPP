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
    public partial class frmPalletMovement : Form
    {
        DataSet coilCellar = new DataSet();
        clsPallet pallet = new clsPallet();
        List<clsCoil> listaBobinas = new List<clsCoil>();
        clsCoilByCoilCellar bodegaNew = new clsCoilByCoilCellar();
        clsPlant planta = new clsPlant();

        bool anduvomov = false;
        bool anduvoPal = false;
        bool anduvomovcoil = false;

       

        public frmPalletMovement()
        {
            InitializeComponent();

            if (clsGlobal.LoggedUser.fkRole == 14 || clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2032)
            {
                coilCellar = clsCoilCellar.lstStockCellarByPlant(4);
            }
            else
            {
                coilCellar = clsCoilCellar.lstStockCellarByPlant(3);
            }

            for (int i = 0; i < coilCellar.Tables[0].Rows.Count; i++)
            {
                cmbBodegaD.Items.Add(coilCellar.Tables[0].Rows[i]["cclr_name"]);
            }

            txtPosicion.Focus();
        }

        #region Carga
        private void txtCodPallet_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;
        
            if (e.KeyCode == Keys.Enter)
            {
                pallet = clsPallet.getDetailByCode(txtCodPallet.Text);
                clsCoilCellar bodegaOrg = new clsCoilCellar(pallet.fkPalletCoilcellar);
                clsProduct producto = new clsProduct(pallet.fkProduct);

                if (cmbBodegaD.SelectedIndex != -1)
                {
                    clsCoilCellar bodegaDestino = new clsCoilCellar(cmbBodegaD.SelectedItem.ToString());

                    if (pallet.fkPalletCoilcellar != bodegaDestino.codsec)
                    {
                        if (pallet.codsec != 0)
                        {
                            if (pallet.fkStatus == 38 || pallet.fkStatus == 42 || pallet.fkStatus == 3073) // Se fija si el pallet esta Activo o ABIERTO.
                            {
                                if (clsGlobal.LoggedUser.fkRole == 2032)
                                {
                                    planta = new clsPlant(4);
                                }
                                else
                                {
                                    planta = new clsPlant(3);
                                }

                                if (planta.codsec == bodegaOrg.fkPlant || bodegaOrg.codsec == 4013 || bodegaOrg.codsec == 4011)
                                {
                                    if (dgvPallet.Rows.Count > 0)
                                    {
                                        foreach (DataGridViewRow rows in dgvPallet.Rows)
                                        {
                                            if (pallet.code == Convert.ToString(rows.Cells[clmCodigoPallet.Index].Value))
                                            {
                                                MessageBox.Show("El código de pallet que intenta cargar ya existe", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                                bandera = true;
                                            }
                                        }
                                        if (bandera != true)
                                        {
                                            dgvPallet.Rows.Add();
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmCodigoPallet.Index].Value = txtCodPallet.Text;
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmProducto.Index].Value = producto.name;
                                            if (txtPosicion.Text != "")
                                            {
                                                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmPosicion.Index].Value = txtPosicion.Text.ToUpper();
                                            }
                                            else
                                            {
                                                dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmPosicion.Index].Value = "0";
                                            }

                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = Math.Round(pallet.netWeight, 2);
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(pallet.grossWeight, 2);
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmBodOrg.Index].Value = bodegaOrg.name;
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmBodDest.Index].Value = cmbBodegaD.SelectedItem.ToString();
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmFechaCreacion.Index].Value = pallet.createdDate;

                                            txtCodPallet.Text = string.Empty;
                                            cmbBodegaD.ResetText();
                                            txtPosicion.Text = string.Empty;

                                        }
                                    }
                                    else
                                    {
                                        dgvPallet.Rows.Add();
                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmCodigoPallet.Index].Value = txtCodPallet.Text;
                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmProducto.Index].Value = producto.name;
                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmNetWeigth.Index].Value = Math.Round(pallet.netWeight, 2);
                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmGrossWeigth.Index].Value = Math.Round(pallet.grossWeight, 2);

                                        if (txtPosicion.Text != "" && txtPosicion.Enabled == true)
                                        {
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmPosicion.Index].Value = txtPosicion.Text.ToUpper();
                                        }
                                        else
                                        {
                                            dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmPosicion.Index].Value = "0";
                                        }

                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmBodOrg.Index].Value = bodegaOrg.name;
                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmBodDest.Index].Value = cmbBodegaD.SelectedItem.ToString();
                                        dgvPallet.Rows[dgvPallet.Rows.Count - 1].Cells[clmFechaCreacion.Index].Value = pallet.createdDate;

                                        txtCodPallet.Text = string.Empty;
                                        txtPosicion.Text = "";
                                        txtPosicion.Focus();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Esta intentando realizar un movimiento de un pallet que se encuentra en otra planta(" + bodegaOrg.name + "). Por favor, solicite el SWAP correspondiente.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta mover no se encuentra dado de alta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pallet que intenta dar de alta no existe, o el código ingresado es erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La bodega de destino no puede ser igual que la de origen, por favor seleccione otra","¡Inconveniente!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una bodega de destino", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            calculoSubTotales();
        }
        #endregion Carga

        #region Procesar
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (dgvPallet.Rows.Count > 0)
            {
                for (int i = 0; i < dgvPallet.Rows.Count; i++)
                {
                    //Doy de alta cada movimiento que sea cargado.
                    clsPalletMovements movimientoPall = new clsPalletMovements();
                    
                    //Doy de alta, la bodega a la que va a ir.
                    clsCoilCellar bodegaDestino = new clsCoilCellar(Convert.ToString(dgvPallet.Rows[i].Cells[clmBodDest.Index].Value));

                    //Doy de alta el pallet, que se va a mover.
                    pallet = clsPallet.getDetailByCode(Convert.ToString(dgvPallet.Rows[i].Cells[clmCodigoPallet.Index].Value));

                    //Lleno de datos el movimiento

                    movimientoPall.type = "Movimiento interno de pallets";
                    movimientoPall.fkPallet = pallet.codsec;
                    movimientoPall.fkProduct = pallet.fkProduct;
                    movimientoPall.lote = pallet.lotNumber;
                    movimientoPall.fkOrigCellar = pallet.fkPalletCoilcellar;
                    movimientoPall.fkDestCellar = bodegaDestino.codsec;
                    movimientoPall.fkUser = clsGlobal.LoggedUser.codsec;
                    movimientoPall.date = DateTime.Now;

                    // Doy de alta el pallet y lo cambio de bodega, conjuntamente con sus respectivas bobinas.

                    if (bodegaDestino.codsec == 1011) //Este es el caso de bodega de destino producto terminado de campana
                    {
                        pallet.fkPalletCoilcellar = bodegaDestino.codsec;
                        pallet.position = dgvPallet.Rows[i].Cells[clmPosicion.Index].Value.ToString();

                        clsPallet.transferTo(pallet, Convert.ToInt32(bodegaDestino.codsec));

                        if (!clsPallet.savein(pallet))
                        {
                            MessageBox.Show("No se pudo generar el archivo de interface con Presea para el pallet " + pallet.code.ToString() + ".", "Error Oben-Presea", MessageBoxButtons.OK);
                        }
                    }
                    else if (bodegaDestino.codsec == 4016) //Caso bodega destino Producto Terminado Pilar.
                    {
                        pallet.fkPalletCoilcellar = bodegaDestino.codsec;
                        pallet.position = dgvPallet.Rows[i].Cells[clmPosicion.Index].Value.ToString();

                        //Pilar no tienen posiciones como campana. 

                        clsPallet.transferTo(pallet, Convert.ToInt32(bodegaDestino.codsec));

                        if (!clsPallet.saveinPL(pallet))
                        {
                            MessageBox.Show("No se pudo generar el archivo de interface con Presea para el pallet " + pallet.code.ToString() + ".", "Error Oben-Presea", MessageBoxButtons.OK);
                        }
                    }
                    else // Este seria cualquier otro caso donde no iria a ninguna bodega. Si le pone posicion por que quiere cae acá. Pero no simbolizaria posicion real. 
                    {
                      
                        pallet.position = dgvPallet.Rows[i].Cells[clmPosicion.Index].Value.ToString();
                      
                        clsPallet.transferTo(pallet, Convert.ToInt32(bodegaDestino.codsec));
                        
                    }

                    //Traigo la lista de bobinas que hay por pallet
                    listaBobinas = clsPallet.getListOfCoilsByPalletCodsec(pallet.codsec);

                    for (int y = 0; y < listaBobinas.Count; y++)
                    {
                        //Cargo con los datos de la tabla coilbycoilcellar el objeto bodegaNew
                        bodegaNew.load(listaBobinas[y].codsec);
                        bodegaNew.fkCoilCellar = bodegaDestino.codsec; //le asigno el codsec de la bodega destino.
                        //Aca quizas iria el hecho de que si es primera iria a Producto termiado si no a proceso pero, habria entrecruzamiento en un futuro en el caso de que
                        //envio a producto terminado, alguna bobina no es Primera y la mando a otro lado por este tema. 
                        // Pero tengo que hacerlo previa al movimiento de pallets. Estamos quitando varias restricciones. Tener mucho cuidado con esto en un futuro. 
                        anduvomovcoil = bodegaNew.save();   
                    }

                    anduvomov = movimientoPall.save();
                    anduvoPal = pallet.save();
                    //anduvocoilcellar = palletCoilCellar.save();

                }

                if (anduvomov && anduvoPal) // && anduvocoilcellar)
                {
                    MessageBox.Show("Los datos se guardaron con exito", "¡Exito!", MessageBoxButtons.OK);
                    dgvPallet.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Se genero algun inconveniente por favor contacte con el administrador del sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La tabla se encuentra vacia", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgvPallet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvPallet.Rows.RemoveAt(dgvPallet.CurrentRow.Index);
                calculoSubTotales();
            }
        }

        private void cmbBodegaD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodPallet.Focus();
                SendKeys.Send("{ENTER}");
            }
            else if (e.KeyCode == Keys.Back)
            {
                cmbBodegaD.ResetText();
            }
        }

        private void txtPosicion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodPallet.Focus();
            }
        }

        private void calculoSubTotales()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvPallet.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmNetWeigth.Index].Value);
            }

            txtCantPallet.Text = dgvPallet.Rows.Count.ToString();
            txtPesos.Text = Math.Round(pesos).ToString();
        }
    }
}

        #endregion