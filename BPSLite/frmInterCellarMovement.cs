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
    public partial class frmInterCellarMovement : Form
    {
        clsCoilCellar bodegas = new clsCoilCellar();
        clsRawPalletByCoilCellar rawPalletBCC = new clsRawPalletByCoilCellar();
        clsRawMaterialPallet rawPallet = new clsRawMaterialPallet();
        clsRawMaterialMovements movimientosRaw = new clsRawMaterialMovements();
        clsPlant plantaOrg = new clsPlant();
        clsPlant plantaDest = new clsPlant();


        public frmInterCellarMovement()
        {
            InitializeComponent();
        }

        private void frmInterCellarMovement_Load(object sender, EventArgs e)
        {
            cargarCombos();
            pnlKgaMover.Enabled = false;
            dgvSwapMP.Columns[clmDestino.Index].Visible = false;
        }

        #region Cargar de Movimiento

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;
            double pesoPallet = 0;

            if (e.KeyCode == Keys.Enter)
            {
                    if (txtCodigo.Text != string.Empty) // No dejo el input en blanco
                    {
                        clsRawMaterialPallet rawPallet = new clsRawMaterialPallet(txtCodigo.Text);
                        rawPalletBCC = new clsRawPalletByCoilCellar(rawPallet.codsec);
                        clsCoilCellar bodegaOrg = new clsCoilCellar(rawPalletBCC.fkCoilCellar);
                        if (clsGlobal.LoggedUser.fkRole == 1024 || clsGlobal.LoggedUser.fkRole == 1019)
                        {
                            plantaOrg = new clsPlant(3);
                        }
                        else
                        {
                            plantaOrg = new clsPlant(4);
                        }

                        if (bodegaOrg.fkPlant == plantaOrg.codsec)
                        {
                            if (rawPallet.codsec != 0 && rawPallet.fkStatus==38) // Existe el pallet
                            {
                                pesoPallet = rawPallet.netweigth;

                                if (pesoPallet > 0) //El pallet tiene algo que mover.
                                {
                                    if (dgvSwapMP.Rows.Count > 0) // El Datagrid no esta vacío
                                    {
                                        foreach (DataGridViewRow row in dgvSwapMP.Rows)
                                        {
                                            if (rawPallet.code == Convert.ToString(row.Cells[clmCodigo.Index].Value))
                                            {
                                                MessageBox.Show("El codigo ya se encuentra ingresado, por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                                bandera = true;
                                            }
                                        }

                                        if (bandera != true) //No encontro el codigo como duplicado. 
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
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmOrigen.Index].Value = bodegaOrg.name;
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                            cmbDestino.ResetText();
                                            txtCodigo.Text = string.Empty;
                                            txtKgaMover.Text = string.Empty;
                                        }
                                    } //El dgv estaba vacio
                                    else
                                    {
                                        dgvSwapMP.Rows.Add();
                                        dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmCodigo.Index].Value = rawPallet.code;
                                        dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmTipo.Index].Value = rawPallet.rawMaterial.name;
                                        dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmLote.Index].Value = rawPallet.lote;
                                        dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmOrigen.Index].Value = bodegaOrg.name;
                                        dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now;

                                        if ((chkMovParcial.Checked == true) && (txtKgaMover.Text != string.Empty)) //Comentario: si no carga el txt se va a mover todo el pallet.
                                        {
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmPeso.Index].Value = txtKgaMover.Text;
                                        }
                                        else if (chkMovParcial.Checked != true)
                                        {
                                            dgvSwapMP.Rows[dgvSwapMP.Rows.Count - 1].Cells[clmPeso.Index].Value = rawPallet.netweigth;
                                        }

                                        else
                                        {
                                            MessageBox.Show("Por favor complete la cantidad de Kilos que desea mover", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            dgvSwapMP.Rows.Clear();
                                        }

                                        cmbDestino.ResetText();
                                        txtCodigo.Text = string.Empty;
                                        txtKgaMover.Text = string.Empty;
                                        chkMovParcial.Checked = false;

                                    }
                                    calculoSubtotales();
                                }
                                else
                                {
                                    MessageBox.Show("No puede consumir mas de lo que el pallet posee.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    cmbDestino.ResetText();
                                    txtCodigo.ResetText();
                                    txtKgaMover.Text = string.Empty;

                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                cmbDestino.ResetText();
                                txtCodigo.ResetText();


                                chkMovParcial.Checked = false;
                                txtKgaMover.Text = string.Empty;
                            }
                            }
                            else
                            {
                                MessageBox.Show("Esta intentando realizar un movimiento de un pallet que se encuentra en otra planta(" + bodegaOrg.name + "). Por favor, solicite el SWAP correspondiente.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                txtCodigo.Text = string.Empty;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor complete el código de pallet", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
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

            if (cmbDestino.SelectedItem.ToString() != "")
            {
                if (dgvSwapMP.Rows.Count > 0)
                {
                    if (dgvSwapMP.Rows[0].Cells[clmDestino.Index].Value.ToString() != dgvSwapMP.Rows[0].Cells[clmOrigen.Index].Value.ToString())
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

                            clsTransactions.addIntercellarMovement(rawPallet.rawMaterial.code,rawPallet.code,rawPallet.lote, rawPalletBCC.fkCoilCellar, bodegaNueva.codsec, Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value));

                            if(bodegaNueva.byLot)
                            {
                                clsCellarStocks cellarstock = new clsCellarStocks(bodegaNueva.codsec, rawPallet.fkRaw, rawPallet.lote);
                                cellarstock.alterQuantity(movimientosRaw.netWeigth);
                            }

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
                                    anduvomov = movimientosRaw.save();
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
                                            anduvomov = movimientosRaw.save();
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

                                                ppalletinSilo = silo.newLoteGiveitByPallet(silo.fkSiloCellar, rawPallet.fkRaw, rawPallet.rawMaterial.fkRawMaterialtype, rawPallet.lote, pesoPpSilo);
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
                                            anduvomov = movimientosRaw.save();
                                        }
                                    }
                                    else
                                    {
                                        if ((silo.fkSiloCellar == 4028 || silo.fkSiloCellar == 4029) && silo.weigth <= 500) // Tolerancia de 500kg para el silo 4 y 5.
                                        {
                                            pesoPpSilo = Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);
                                            rawPallet.netweigth = rawPallet.netweigth - Convert.ToDouble(dgvSwapMP.Rows[i].Cells[clmPeso.Index].Value);

                                            if (rawPallet.netweigth == 0)
                                            {
                                                rawPallet.fkStatus = 41;
                                                rawPalletBCC.save();

                                                //Nose para que lo asigno a una variable ahora, pero me imagino en un futuro para que elimine los registros por que si no se va a hacer una BD
                                                // Mucho muy grande por no utilizar otros terminos.

                                                ppalletinSilo = silo.newLoteGiveitByPallet(silo.fkSiloCellar, rawPallet.fkRaw, rawPallet.rawMaterial.fkRawMaterialtype, rawPallet.lote, pesoPpSilo);
                                                prawPallet = rawPallet.save();
                                            }
                                            else
                                            {
                                                ppalletinSilo = silo.newLoteGiveitByPallet(silo.fkSiloCellar, rawPallet.fkRaw, rawPallet.rawMaterial.fkRawMaterialtype, rawPallet.lote, pesoPpSilo);
                                                prawPallet = rawPallet.save(); // recordar sacar cuando vaya a produccion full.
                                                rawPalletBCC.save();
                                                impetique = true;
                                            }
                                            anduvomov = movimientosRaw.save();
                                        }
                                        else // Ya si no se cumple no se puede mezclar para nada.
                                        {
                                            MessageBox.Show("No puede mezclar ese pallet con el contenido del silo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            { 
                                // Si salio por aca significa que el pallet se cambio de bodega simplemente. Y a su vez, en el caso de que haya seleccionado un movimiento parcial
                                // le suckea un egg, y pasa todo el pallet. No está ni bien, ni mal. The limbo

                                if(rawPallet.rawMaterial.fkRawMaterialtype==35 && bodegaNueva.codsec==4014)//Si es insumo para metalizadora, se elimina el pallet para no acumular en corte
                                {
                                    rawPallet.fkStatus = 41;//ELIMINAR cuando se pueda consumir insumos de metalizadora
                                }
                                prawPallet = rawPallet.save();
                                anduvoPal = rawPalletBCC.save();
                                anduvomov = movimientosRaw.save();
                            } 
                        }

                        if (anduvomov == true)
                        {
                            if (anduvoPal == true || psilo == true || prawPallet == true || ppalletinSilo == true)
                            {

                                dgvSwapMP.Rows.Clear();
                                MessageBox.Show("Datos procesados con exito", "¡Exito!", MessageBoxButtons.OK);
                                txtCodigo.Text = string.Empty;
                                cmbDestino.ResetText();
                                if (impetique == true)
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
                            else
                            {
                                MessageBox.Show("Se produjo un error en el guardado de datos, por favor contacte a sistemas.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error en  la generacion de movimiento, por favor contacte con sistema.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Advertencia: La bodega de origen y destino no pueden ser la misma", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("La tabla se encuentra vacía", "¡Error!", MessageBoxButtons.OK);
                }
            }
        }

        #endregion

        #region Eventos de los Formularios

        private void dgvSwapMP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmEliminar.Index)
            {
                dgvSwapMP.Rows.RemoveAt(dgvSwapMP.CurrentRow.Index);
                calculoSubtotales();
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

        private void cargarCombos()
        {
            List<clsCoilCellar> bodegas = new List<clsCoilCellar>();

            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2032)
            {
                bodegas = clsCoilCellar.lstSiloAndRawCellar(4);
            }
            else
            {
                bodegas = clsCoilCellar.lstSiloAndRawCellar(3);
            }
                
            for (int i = 0; i < bodegas.Count; i++)
            {
                cmbDestino.Items.Add(bodegas[i]);
            }
            cmbDestino.Enabled = true;
        }

        private void chkMovParcial_CheckedChanged(object sender, EventArgs e)
        {
            pnlKgaMover.Enabled = chkMovParcial.Checked;
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDestino.SelectedIndex != -1)
            {
                clsCoilCellar bodega = new clsCoilCellar(cmbDestino.SelectedItem.ToString());
            }
       
            dgvSwapMP.Columns[clmDestino.Index].Visible = true;
           

            for (int i = 0; i < dgvSwapMP.Rows.Count; i++)
            {
                dgvSwapMP.Rows[i].Cells[clmDestino.Index].Value = cmbDestino.SelectedItem.ToString();
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
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
       

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            double peso = 0;

            if (txtCodigo.Text != "" && txtKgaMover.Text == "")
            {
                clsRawMaterialPallet rawPallet = new clsRawMaterialPallet(txtCodigo.Text);
                txtKgaMover.Text = Convert.ToString(rawPallet.netweigth);
                peso = Convert.ToDouble(rawPallet.netweigth);
            }
            else if (txtCodigo.Text != "" && txtKgaMover.Text != "" && (Convert.ToDouble(txtKgaMover.Text) != peso) && peso != 0 )
            {
                clsRawMaterialPallet rawPallet = new clsRawMaterialPallet(txtCodigo.Text);
                txtKgaMover.Text = Convert.ToString(rawPallet.netweigth);
            }


        }
        #endregion

        #region Calculo Subtotales
        private void calculoSubtotales()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvSwapMP.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPeso.Index].Value);
                
            }
            txtTotPeso.Text = Math.Round(pesos, 2).ToString();
            txtTotPallet.Text = dgvSwapMP.Rows.Count.ToString();
        }
        #endregion

    }
}
