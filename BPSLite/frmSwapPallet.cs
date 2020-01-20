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
    public partial class frmSwapPallet : Form
    {
        clsPallet objPallet = new clsPallet();
        List<clsCoil> lstCoilByPallet = new List<clsCoil>();
        clsCoilMovements movCoil = new clsCoilMovements();
        clsPalletMovements movPal = new clsPalletMovements();

        public frmSwapPallet()
        {
            InitializeComponent();
            cargarDgvIngreso();
        }

        #region Carga de Pallet.
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            bool bandera = false;
            objPallet = clsPallet.getDetailByCode(txtPalletCode.Text);

            if (e.KeyCode == Keys.Enter)
            {
                if ((cmbDestino.Text != string.Empty) && (cmbOrigen.Text != string.Empty))
                {
                    if (txtPalletCode.Text != string.Empty)
                    {
                        if (cmbOrigen.Text != cmbDestino.Text)
                        {
                            clsCoilCellar bodega = new clsCoilCellar(cmbOrigen.SelectedItem.ToString()); // el fk de la bodega del cmbOrigen

                            if (bodega.codsec == objPallet.fkPalletCoilcellar) //si coinciden el cmbOrigen y el objPallet.fkCoilCellar, el pallet ingresado se encuentra en la bodega de origen seleccionada del cmb
                            {
                                if (objPallet.codsec != 0)
                                {
                                    if (objPallet.fkStatus == 38 || objPallet.fkStatus == 42) 
                                    {
                                        if (dgvPalletSwap.Rows.Count > 0)
                                        {
                                            foreach (DataGridViewRow row in dgvPalletSwap.Rows)
                                            {
                                                if (objPallet.codsec == Convert.ToInt32(row.Cells[clmCodsec.Index].Value))
                                                {
                                                    MessageBox.Show("Codigo ya ingresado. Por favor verifique la tabla", "¡Error!", MessageBoxButtons.OK);
                                                    bandera = true;
                                                }
                                            }

                                            if (bandera != true)
                                            {
                                                dgvPalletSwap.Rows.Add();
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmCodsec.Index].Value = objPallet.codsec;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmPalletCode.Index].Value = objPallet.code;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmStatus.Index].Value = objPallet.statusName;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(Convert.ToDouble(objPallet.netWeight), 2);
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmGrosWeight.Index].Value = Math.Round(Convert.ToDouble(objPallet.grossWeight), 2);
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmPosition.Index].Value = objPallet.position;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmOriginCellar.Index].Value = cmbOrigen.Text;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmDestinyCellar.Index].Value = cmbDestino.Text;
                                                dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now.ToString("dd/MM/yyyy");

                                                cmbDestino.ResetText();
                                                cmbOrigen.ResetText();
                                                txtPalletCode.ResetText();
                                            }
                                        }
                                        else
                                        {
                                            dgvPalletSwap.Rows.Add();
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmCodsec.Index].Value = objPallet.codsec;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmPalletCode.Index].Value = objPallet.code;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmStatus.Index].Value = objPallet.statusName;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmNetWeight.Index].Value = Math.Round(Convert.ToDouble(objPallet.netWeight), 2);
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmGrosWeight.Index].Value = Math.Round(Convert.ToDouble(objPallet.grossWeight), 2);
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmPosition.Index].Value = objPallet.position;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmOriginCellar.Index].Value = cmbOrigen.Text;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmDestinyCellar.Index].Value = cmbDestino.Text;
                                            dgvPalletSwap.Rows[dgvPalletSwap.Rows.Count - 1].Cells[clmFecha.Index].Value = DateTime.Now.ToString("dd/MM/yyyy");

                                            cmbDestino.ResetText();
                                            cmbOrigen.ResetText();
                                            txtPalletCode.ResetText();
                                        }
                                    }
                                    else
                                    {
                                        
                                        MessageBox.Show("El pallet que intenta mover no se encuentra dado de alta(" + new clsStatus(objPallet.fkStatus).name.ToString() + ").", "¡Error!", MessageBoxButtons.OK);
                                        cmbDestino.ResetText();
                                        cmbOrigen.ResetText();
                                    }
                                    calculoDeSubtotalesOut();
                                }
                                else
                                {
                                    MessageBox.Show("El pallet que intenta cargar no existe o el codigo es erroneo", "¡Error!", MessageBoxButtons.OK);
                                    cmbDestino.ResetText();
                                    cmbOrigen.ResetText();
                                    txtPalletCode.ResetText();
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que intenta ingresar no se encuentra en la bodega de Origen que selecciono", "¡Error!", MessageBoxButtons.OK);
                                cmbDestino.ResetText();
                                cmbOrigen.ResetText();
                                txtPalletCode.ResetText();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, complete el codigo de pallet", "¡Error!", MessageBoxButtons.OK);

                    }
                }
                else
                {
                    MessageBox.Show("Complete primero Bodega Origen y Bodega Destino", "¡Error!", MessageBoxButtons.OK);
                }
            }
        }

        private void dgvPalletSwap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDeleteRow.Index)
            {
                {
                    dgvPalletSwap.Rows.RemoveAt(dgvPalletSwap.CurrentRow.Index);
                    calculoDeSubtotalesOut();
                }
            }
        }

        #endregion

        #region Procesamiento de Pallets.

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            bool flag = false;
            clsSwap objSwap = new clsSwap();
            clsCoilCellar objCoilCellar = new clsCoilCellar();
            clsCoilCellar objCCLOrigin = new clsCoilCellar();

                if (dgvPalletSwap.Rows.Count > 0)
                {
                    for (int i = 0; i < dgvPalletSwap.Rows.Count; i++)
                    {    // Tener cuidado con esto, por que pueden mandar pallet que no tienen nada en SWAP
                        if (dgvPalletSwap.Rows[i].Cells[clmStatus.Index].Value.ToString() == "Activo" || dgvPalletSwap.Rows[i].Cells[clmStatus.Index].Value.ToString() == "Abierto") 
                        {
                            objCCLOrigin = clsCoilCellar.getCellarByName(dgvPalletSwap.Rows[i].Cells[clmOriginCellar.Index].Value.ToString()); //bodega de origen
                            objCoilCellar = clsCoilCellar.getCellarByName(dgvPalletSwap.Rows[i].Cells[clmDestinyCellar.Index].Value.ToString()); //bodega de destino
                            objPallet = clsPallet.getCompleteDetailByCode(dgvPalletSwap.Rows[i].Cells[clmPalletCode.Index].Value.ToString()); //objPallet

                            //clsPallet.setCoilCellar(objPallet.code, objCoilCellar.codsec); //actualizo la bodega del pallet a Producto Terminado de Pilar o Campana segun corresponda

                            lstCoilByPallet = clsCoil.getCoilListByPallet(objPallet.codsec); //lista de bobinas por pallet

                            //recorro la lista de bobinas por pallet y muevo las bobinas a la bodega correspondiente
                            for (int j = 0; j < lstCoilByPallet.Count; j++)
                            {
                                // Agregado guardar el registro de la bobina que se le hizo SWAP. Pasaba que si hacian Swap, pero del otro lado lo abren al pallet y lo borran
                                // perdemos totalmente la trazabilidad de las bobinas que tenia el pallet en su interior. Y contabilidad nos apreto los eggs. Por eso, se creo ésto.

                                movCoil.fkCoil = lstCoilByPallet[j].codsec;
                                movCoil.fkOrgCellar = objCCLOrigin.codsec;
                                movCoil.fkDestCellar = objCoilCellar.codsec;
                                movCoil.fkUser = clsGlobal.LoggedUser.codsec;
                                movCoil.length = Convert.ToInt32(lstCoilByPallet[j].length);
                                movCoil.netWeigth = lstCoilByPallet[j].netWeight;
                                movCoil.type = "Swap de Bobina";
                                movCoil.date = DateTime.Now;

                                movCoil.save(); 

                                clsCoil.transferCoilTo(lstCoilByPallet[j].codsec, objCoilCellar.codsec);
                                lstCoilByPallet[j].fkStatus = 36;
                                lstCoilByPallet[j].save();

                                //Gravo el movimiento por bobina en la tabla coilMovements.
                            }

                            //Guardo en cada recorrida los elementos de la tabla bps_prod_swap para luego guardar el movimiento

                            objSwap.fkPallet = objPallet.codsec;
                            objSwap.fkUser = clsGlobal.LoggedUser.codsec;
                            objSwap.fkOriginalCellar = objCCLOrigin.codsec;
                            objSwap.fkDestinationCellar = objCoilCellar.codsec;
                            objSwap.date = DateTime.Now;
                            objSwap.netWeigth = Math.Round(objPallet.netWeight,1);
                            objSwap.type = "Swap Entre Plantas";
                            objPallet.fkStatus = 3066;
                            objPallet.fkPalletCoilcellar = objCoilCellar.codsec;

                            movPal.fkPallet = objPallet.codsec;
                            movPal.fkOrigCellar = objCCLOrigin.codsec;
                            movPal.fkDestCellar = objCoilCellar.codsec;
                            movPal.fkUser = clsGlobal.LoggedUser.codsec;
                            movPal.fkProduct = objPallet.fkProduct;
                            movPal.lote = objPallet.lotNumber;
                            movPal.type = "Swap de Pallet";
                            movPal.date = DateTime.Now;

                            movPal.save(); 
                            

                            try
                            {
                                if (objSwap.save(objSwap) && objPallet.save())
                                {
                                    flag = true;
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                            catch
                            {
                                flag = false;
                            }

                        }
                        else
                        {
                            MessageBox.Show("El/Los pallet deben tener estado activo para poder realizar el movimiento. \nSolo se moverán los pallets con dicho estado.\nVerifique en el listado los pallets ingresados.", "Swap Interplanta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                 }
                if (flag == true)
                {
                    MessageBox.Show("Movimiento realizado exitosamente.", "Swap Interplanta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    MessageBox.Show("No se ha podido realizar el movimiento.", "Swap Interplanta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                exportToExcel();
                dgvPalletSwap.Rows.Clear();
                txtPalletCode.Text = string.Empty;
                cmbDestino.ResetText();
                cmbOrigen.ResetText();
            }
            else
            {
              MessageBox.Show("Debe ingresar al menos un Pallet al listado.", "Swap Interplanta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }
        #endregion

        #region Cargar combos
        private void frmSwapPallet_Load(object sender, EventArgs e)
        {
            cargarCombos();
        }

        
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

        private void cmbOrigen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbOrigen.ResetText();
                cmbDestino.ResetText();
                cmbDestino.SelectedIndex = -1;
                cmbOrigen.SelectedIndex = -1;
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

        public void cargarCombos()
        {
            List<clsCoilCellar> bodegasNew = new List<clsCoilCellar>();
            List<clsCoilCellar> bodegasDest = new List<clsCoilCellar>();

            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
            {
                bodegasNew = clsCoilCellar.lstStockCellar(3);
                bodegasDest = clsCoilCellar.lstStockCellar(4);
            }
            else
            {
                bodegasNew = clsCoilCellar.lstStockCellar(4);
                bodegasDest = clsCoilCellar.lstStockCellar(3);
            }    

            if (cmbOrigen.Text == string.Empty)
            {
                for (int i = 0; i < bodegasNew.Count; i++)
                {
                    cmbOrigen.Items.Add(bodegasNew[i]);
                }

                for (int j = 0; j < bodegasDest.Count; j++)
                {
                    cmbDestino.Items.Add(bodegasDest[j]);
                }

                    cmbDestino.Enabled = false;
            }
            else
            {
                for (int i = 0; i < bodegasDest.Count; i++)
                {
                        cmbDestino.Items.Add(bodegasDest[i]);
                }
                //cmbDestino.Items.Remove(cmbOrigen.SelectedItem);
            }
        }
        
        #endregion

        #region Autocarga DgvIngreso. 
            // Aca tiene que ir los storeprocedure que carga el dgv.
        private void cargarDgvIngreso()
        {
            DataSet DS = new DataSet();

            if (clsGlobal.LoggedUser.fkRole == 1019 || clsGlobal.LoggedUser.fkRole == 1024)
            {
                DS = clsConnection.getDataSetResult("CALL spPalletInTransit(" + 3 + ")");
            }
            else
            {
                DS = clsConnection.getDataSetResult("CALL spPalletInTransit(" + 4 + ")");
            }

            if (DS.Tables.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvIngresoSwap.Rows.Add();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmCodPallet.Index].Value = DS.Tables[0].Rows[i]["CodPallet"].ToString();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmCodMaterial.Index].Value = DS.Tables[0].Rows[i]["CodProd"].ToString();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmNomMaterial.Index].Value = DS.Tables[0].Rows[i]["NomProd"].ToString();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmPeso.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["PesoPallet"]));
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmBdOrigen.Index].Value = DS.Tables[0].Rows[i]["BodOrg"].ToString();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmDestino.Index].Value = DS.Tables[0].Rows[i]["BodDest"].ToString();
                    dgvIngresoSwap.Rows[dgvIngresoSwap.Rows.Count - 1].Cells[clmFechaPend.Index].Value = Convert.ToDateTime(DS.Tables[0].Rows[i]["Fecha"]);
                }
            }
            calculoDeSubTotalesIn();
        }
        #endregion

        #region Aceptacion o no de pallet.

        private void dgvIngresoSwap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmAceptar.Index)
            {
                objPallet = clsPallet.getCompleteDetailByCode(dgvIngresoSwap.CurrentRow.Cells[clmCodPallet.Index].Value.ToString());

                if (objPallet.fkStatus == 3066) // Quiere decir que esta en transito. 
                {
                    
                    clsCoilCellar bodega = new clsCoilCellar(dgvIngresoSwap.CurrentRow.Cells[clmDestino.Index].Value.ToString());

                    clsPallet.transferTo(objPallet, Convert.ToInt32(bodega.codsec));

                    objPallet.fkStatus = 38;

                    objPallet.save();

                    if (bodega.codsec == 1011) //Solo se hace si es bodega de producto terminado de campana, ya que, ésta bodega usa Posiciones.
                    {
                        var dialogResult2 = MessageBox.Show("¿Desea asignarle una posición al pallet ingresado?", "Posicionamiento", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (dialogResult2 == DialogResult.Yes)
                        {

                            frmSwapPalletPositionCamp aceptCampana = new frmSwapPalletPositionCamp(dgvIngresoSwap.CurrentRow.Cells[clmCodPallet.Index].Value.ToString());
                            aceptCampana.ShowDialog(this);

                            if (!clsPallet.savein(objPallet))
                            {
                                MessageBox.Show("No se pudo generar el archivo de interface con Presea para el pallet " + objPallet.code.ToString() + ".", "Error Oben-Presea", MessageBoxButtons.OK);
                            }

                            dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                        }
                        else
                        {
                            if (!clsPallet.savein(objPallet))
                            {
                                MessageBox.Show("No se pudo generar el archivo de interface con Presea para el pallet " + objPallet.code.ToString() + ".", "Error Oben-Presea", MessageBoxButtons.OK);
                            }

                            MessageBox.Show("Los datos se procesaron correctamente.\nNOTA: Recuerde que el pallet no poseera Posión.", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (bodega.codsec == 4016) // Este es el caso de la bodega de producto terminado de Pilar. 
                    {
                        if (!clsPallet.saveinPL(objPallet))
                        {
                            MessageBox.Show("No se pudo generar el archivo de interface con Presea para el pallet " + objPallet.code.ToString() + ".", "Error Oben-Presea", MessageBoxButtons.OK);
                        }
                        dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                    }
                    else
                    {
                        dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                    }
                } // Por algun otro lado le forzaron otro estado y ya eliminamos una variable
                else
                {
                    MessageBox.Show("El pallet no se puede aceptar debido a que su estado es: " + new clsStatus(objPallet.fkStatus).name + ".\n Por favor, contacte con el Administrador del Sistema por este inconveniente", "Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == clmDeny.Index)
            {
                clsCoilCellar bodega = new clsCoilCellar(dgvIngresoSwap.CurrentRow.Cells[clmBdOrigen.Index].Value.ToString());
                objPallet = clsPallet.getCompleteDetailByCode(dgvIngresoSwap.CurrentRow.Cells[clmCodPallet.Index].Value.ToString());
                clsCoilCellar bodegaDestino = new clsCoilCellar(dgvIngresoSwap.CurrentRow.Cells[clmDestino.Index].Value.ToString());
                clsSwap objSwap = new clsSwap();

                var dialogResult = MessageBox.Show("a.BOTON SI: Seleccione este boton si, el pallet no llego.\nb.BOTON NO: Seleccione este boton si, el pallet no llego en condiciones.\nc.Si no es ninguna de las opciones anteriores, presione CANCEL.", "¡Advertencia!", MessageBoxButtons.YesNoCancel);

                lstCoilByPallet = clsCoil.getCoilListByPallet(objPallet.codsec);

                switch (dialogResult)
                {
                    case DialogResult.Yes:

                        objSwap.fkPallet = objPallet.codsec;
                        objSwap.fkUser = clsGlobal.LoggedUser.codsec;
                        objSwap.fkOriginalCellar = bodega.codsec;
                        objSwap.fkDestinationCellar = bodegaDestino.codsec;
                        objSwap.date = DateTime.Now;
                        objSwap.netWeigth = -1 * Math.Round(objPallet.netWeight,1);
                        objSwap.type = "El Pallet no llegó";

                        objPallet.notes += " El pallet no llegó.";
                        objPallet.fkStatus = 38;
                        objPallet.fkPalletCoilcellar = bodega.codsec;
                        objPallet.save();
                        objSwap.save(objSwap);

                        movPal.fkPallet = objPallet.codsec;
                        movPal.fkOrigCellar = bodega.codsec;
                        movPal.fkDestCellar = bodegaDestino.codsec;
                        movPal.fkUser = clsGlobal.LoggedUser.codsec;
                        movPal.fkProduct = objPallet.fkProduct;
                        movPal.lote = objPallet.lotNumber;
                        movPal.type = "Swap de Pallet no aceptado";
                        movPal.date = DateTime.Now;

                        movPal.save(); 
                        
                        for (int j = 0; j < lstCoilByPallet.Count; j++)
                        {
                            lstCoilByPallet[j].fkStatus = 33;
                            clsCoil.transferCoilTo(lstCoilByPallet[j].codsec, bodega.codsec);
                            lstCoilByPallet[j].save();

                            // Se crea el movimiento de devolucion por bobina.
                            movCoil.fkCoil = lstCoilByPallet[j].codsec;
                            movCoil.date = DateTime.Now;
                            movCoil.fkUser = clsGlobal.LoggedUser.codsec;
                            movCoil.netWeigth = -1 * Math.Round(lstCoilByPallet[j].netWeight, 2);
                            movCoil.fkOrgCellar = bodega.codsec;
                            movCoil.fkDestCellar = bodegaDestino.codsec;
                            movCoil.type = "La bobina no llegó";
                            movCoil.save();
                        }

                        dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                        break;
                    case DialogResult.No:
                        objSwap.fkPallet = objPallet.codsec;
                        objSwap.fkUser = clsGlobal.LoggedUser.codsec;
                        objSwap.fkOriginalCellar = bodega.codsec;
                        objSwap.fkDestinationCellar = bodegaDestino.codsec;
                        objSwap.date = DateTime.Now;
                        objSwap.netWeigth = -1 * Math.Round(objPallet.netWeight,1);
                        objSwap.type = "El pallet no se acepto, por que llegó con desperfectos.";

                        objPallet.notes += " El pallet no se acepto, por que llegó con desperfectos.";
                        objPallet.fkStatus = 3066;
                        objPallet.fkPalletCoilcellar = bodega.codsec;

                        movPal.fkPallet = objPallet.codsec;
                        movPal.fkOrigCellar = bodega.codsec;
                        movPal.fkDestCellar = bodegaDestino.codsec;
                        movPal.fkUser = clsGlobal.LoggedUser.codsec;
                        movPal.fkProduct = objPallet.fkProduct;
                        movPal.lote = objPallet.lotNumber;
                        movPal.type = "Swap de Pallet no aceptado";
                        movPal.date = DateTime.Now;

                        movPal.save(); 

                        for (int j = 0; j < lstCoilByPallet.Count; j++)
                        {
                            lstCoilByPallet[j].fkStatus = 3066;
                            clsCoil.transferCoilTo(lstCoilByPallet[j].codsec, bodega.codsec);
                            lstCoilByPallet[j].save();
                            movCoil.fkCoil = lstCoilByPallet[j].codsec;
                            movCoil.date = DateTime.Now;
                            movCoil.fkUser = clsGlobal.LoggedUser.codsec;
                            movCoil.netWeigth = -1*Math.Round(lstCoilByPallet[j].netWeight,2);
                            movCoil.fkOrgCellar = bodega.codsec;
                            movCoil.fkDestCellar = bodegaDestino.codsec;
                            movCoil.type = "La bobina no se acepto, por que llegó con desperfectos.";
                            movCoil.save();
                        }

                        dgvIngresoSwap.Rows.RemoveAt(dgvIngresoSwap.CurrentRow.Index);
                        objPallet.save();
                        objSwap.save(objSwap);
                        break;
                    case DialogResult.Cancel:
                        objPallet.notes += " CANCEL.";
                        objPallet.save();
                        break;
                }

            }
            calculoDeSubTotalesIn();
        }
        #endregion

        #region Exportar a Excel
        private void exportToExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Name = "Swap de Pallet de Scrap";

                for (int i = 2; i < dgvPalletSwap.Columns.Count + 1; i++)
                    worksheet.Cells[1, i - 1] = dgvPalletSwap.Columns[i - 1].HeaderText;

                for (int i = 0; i < dgvPalletSwap.Rows.Count; i++)
                {
                    for (int j = 1; j < dgvPalletSwap.Columns.Count - 1; j++)
                    {
                        if (dgvPalletSwap.Rows[i].Cells[j].Value != null)
                            worksheet.Cells[i + 2, j] = dgvPalletSwap.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Swap de Pallet de Scrap", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Calculo de Subtotales
        private void calculoDeSubtotalesOut()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvIngresoSwap.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmNetWeight.Index].Value);
            }
            txtPalletTo.Text = dgvPalletSwap.Rows.Count.ToString();
            txtPesoTo.Text = Math.Round(pesos, 2).ToString();
        }

        private void calculoDeSubTotalesIn()
        {
            double pesos = 0;

            foreach (DataGridViewRow row in dgvIngresoSwap.Rows)
            {
                pesos = pesos + Convert.ToDouble(row.Cells[clmPeso.Index].Value);
            }
            txtPalletIn.Text = dgvIngresoSwap.Rows.Count.ToString();
            txtPesoIn.Text = Math.Round(pesos, 2).ToString();
        }
        #endregion

    }
}
