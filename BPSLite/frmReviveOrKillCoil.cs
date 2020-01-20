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
    public partial class frmReviveOrKillCoil : Form
    {
        clsCoil coil = new clsCoil();
        clsProduct product = new clsProduct();
        clsCoilCellar bodega = new clsCoilCellar();
        clsCoilChanges cambiosEnLaBobina = new clsCoilChanges();
        clsMainCoil mainCoil = new clsMainCoil();

        public frmReviveOrKillCoil()
        {
            InitializeComponent();
            cargarCombos();
        }

        private void txtCodCoil_KeyDown(object sender, KeyEventArgs e)
        {
            DataSet DS = new DataSet();

            if (e.KeyCode == Keys.Enter)
            {
                if (txtCodCoil.Text != string.Empty)
                    {
                        
                        coil = clsCoil.getDetailByCode(txtCodCoil.Text);
                        if (coil.codsec != 0)
                        {
                            
                            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilbypallet WHERE bps_prod_coilbypallet.cbp_fkCoil =" + coil.codsec.ToString());
                            if (DS.Tables[0].Rows.Count == 0)
                            {

                                txtCodCoil.BackColor = Color.LightGreen;
                                clsCoilCellar bodega = new clsCoilCellar(coil.cellar);

                                if (coil.fkCuttingQuality == 3) // Primera
                                {
                                    txtCalidad.Text = "Primera";
                                }
                                else if (coil.fkCuttingQuality == 4) // Segunda
                                {
                                    txtCalidad.Text = "Segunda";
                                }
                                else
                                {
                                    txtCalidad.Text = "Observación";
                                }

                                product = new clsProduct(coil.fkProduct);
                                txtProducto.Text = product.code;
                                txtBodegaB.Text = bodega.name;
                                txtMetraje.Text = coil.length.ToString();
                                txtLote.Text = coil.lotNumber;
                                txtBMadre.Text = coil.mainCoilCode;
                                txtfCorte.Text = coil.cuttingDate.ToString();
                                txtAncho.Text = coil.width.ToString();
                                txtPesoB.Text = Math.Round(clsCoil.pesoNeto(coil), 2).ToString();
                                txtEstado.Text = coil.statusName;
                                cargarDgv(coil);
                            }
                            else
                            {
                                MessageBox.Show("La bobina que intenta modificar esta palletizada por favor despaletice la bobina para continuar.", "Advertencia", MessageBoxButtons.OK);
                                txtCodCoil.Text = string.Empty;
                                txtCodCoil.BackColor = Color.White;
                                coil = new clsCoil();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La bobina es inexistente o el código es erroneo. Por favor verifiquelo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodCoil.BackColor = Color.Salmon;
                            coil = new clsCoil();
                        }
                }
                else
                {
                    txtCodCoil.BackColor = Color.Salmon;
                    MessageBox.Show("El código ingresado no pertenece a una bobina hija o el código es erroneo.","¡Error!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    coil = new clsCoil();
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbEstado.SelectedIndex != -1 && cmbBodega.SelectedIndex != -1 && txtCodCoil.Text != string.Empty)
            {
                if (coil.codsec != 0)
                {
                    cambiosEnLaBobina.lastCellar = coil.cellar;
                    cambiosEnLaBobina.oldState = coil.fkStatus;

                    bodega = new clsCoilCellar(cmbBodega.SelectedItem.ToString());

                    coil.cellar = bodega.codsec;
                    coil.netWeight = Convert.ToDouble(txtPesoB.Text);
                    cambiosEnLaBobina.fkCoil = coil.codsec;
                    cambiosEnLaBobina.newCellar = bodega.codsec;
                   
                    cambiosEnLaBobina.fkUser = clsGlobal.LoggedUser.codsec;
                    cambiosEnLaBobina.date = DateTime.Now;
                    cambiosEnLaBobina.lastWeight = coil.netWeight;
                    cambiosEnLaBobina.newWeight = Convert.ToDouble(txtPesoB.Text);

                    clsCoil.transferCoilTo(coil.codsec, bodega.codsec);

                    
                    bool coilsv = coil.save();

                    if (cmbEstado.SelectedIndex == 0)
                    {
                        coil.toChangeStatus(33);

                    }
                    else
                    {
                        coil.toChangeStatus(34);
                    }

                    cambiosEnLaBobina.newState = coil.fkStatus;
                    bool chng = cambiosEnLaBobina.save();

                    if (chng == true && coilsv == true)
                    {
                        MessageBox.Show("Se cambiaron los datos con Exito.","Exito",MessageBoxButtons.OK);
                        limpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("Problema en el guardado de datos, por favor contacte al Administrador del Sistema", "¡Error!", MessageBoxButtons.OK);
                        limpiarForm();
                    }
                }
                else
                {
                    MessageBox.Show("La bobina que intenta modificar no existe o el código es erroneo", "Advertencia",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodCoil.BackColor = Color.Salmon;
                }
                
            }
            else
            {
                if (cmbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor Seleccione un Estado","¡Advertencia!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    cmbEstado.BackColor = Color.Salmon;
                }
                else
                {
                    MessageBox.Show("Por favor Seleccione una Bodega", "¡Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbBodega.BackColor = Color.Salmon;
                }
            }
        }

        #region Cargar Combos
        

        private void cargarCombos()
        {
            DataSet DS = new DataSet();

            if (clsGlobal.LoggedUser.fkRole == 2026) // Supervisor Pilar
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE (bps_prod_coilcellar.cclr_isRewindCellar = 1 OR bps_prod_coilcellar.cclr_isMetallizedCellar = 1) AND bps_prod_coilcellar.cclr_fkPlant = 4");
            }
            else
            {
                DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilcellar WHERE (bps_prod_coilcellar.cclr_isRewindCellar = 1 OR bps_prod_coilcellar.cclr_isMetallizedCellar = 1) AND bps_prod_coilcellar.cclr_fkPlant = 3");

            }
             
            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                cmbBodega.Items.Add(DS.Tables[0].Rows[i]["cclr_name"]);
            }

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_status WHERE bps_admin_status.stt_codsec = 33 OR bps_admin_status.stt_codsec = 34");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                cmbEstado.Items.Add(DS.Tables[0].Rows[i]["stt_name"]);
            }

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_admin_status WHERE bps_admin_status.stt_codsec = 49 OR bps_admin_status.stt_codsec = 51");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                cmbEstadoMC.Items.Add(DS.Tables[0].Rows[i]["stt_name"]);                
            }

        }
        #endregion

        private void cmbBodega_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbBodega.ResetText();
            }
        }

        private void cmbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                cmbEstado.ResetText();
            }
        }

        private void txtMainCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMainCoil.Text != string.Empty)
                {
                    mainCoil = new clsMainCoil(txtMainCoil.Text);
                    if (mainCoil.codsec != 0)
                    {
                        if (mainCoil.fkBopp != 0)
                        {
                            clsBopp boppCode = new clsBopp(mainCoil.fkBopp);
                            txtMainCoilPel.Text = boppCode.code;
                        }
                        else if (mainCoil.fkCast != 0)
                        {
                            clsCast castCode = new clsCast(mainCoil.fkCast);
                            txtMainCoilPel.Text = castCode.code;
                        }
                        else
                        {
                            clsCoating coatCode = new clsCoating(mainCoil.fkCoating);
                            txtMainCoilPel.Text = coatCode.code;
                        }

                        if (mainCoil.fkStatus == 49)
                        {
                            txtStatusMC.Text = "Nueva";
                        }
                        else
                        {
                            txtStatusMC.Text = "Cerrada";
                        }

                        txtMainCoil.BackColor = Color.LightGreen;
                        txtMainCoilLength.Text = mainCoil.netlength.ToString();
                        txtMainCoilLote.Text = mainCoil.lotNumber.ToString();
                        txtMainCoilInic.Text = mainCoil.initDate.ToString();
                        txtMainCoilEnd.Text = mainCoil.endDate.ToString();
                        txtMainCoilNotes.Text = mainCoil.notes;
                        txtMainCoilWidth.Text = mainCoil.width.ToString();
                        txtNetWeigth.Text = mainCoil.netWeigth.ToString();
                        txtMainCoilLength.Text = mainCoil.netlength.ToString();
                        txtMainCoilNotes.Text = mainCoil.notes;
                        txtPesoMC.Text = Math.Round(mainCoil.netWeigth,2).ToString();


                    }
                    else
                    {
                        MessageBox.Show("El código ingresado no pertenece a una bobina Madre o el código es erroneo.", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtMainCoil.BackColor = Color.Salmon;
                        mainCoil = new clsMainCoil();
                    }
                }
            }
            else if(e.KeyCode == Keys.Back)
            {
                limpiarForm();
            }
        }

        private void btnGuardarMC_Click(object sender, EventArgs e)
        {
            if (cmbEstadoMC.SelectedIndex != -1 && txtMainCoil.Text != string.Empty)
            {
                
                if (mainCoil.codsec != 0)
                {
                   
                    if (cmbEstadoMC.SelectedIndex == 0)
                    {
                        cambiosEnLaBobina.oldState = mainCoil.fkStatus;
                        cambiosEnLaBobina.newState = 49;
                        mainCoil.fkStatus = 49;
                    }
                    else
                    {
                        cambiosEnLaBobina.oldState = mainCoil.fkStatus;
                        cambiosEnLaBobina.newState = 51;
                        mainCoil.fkStatus = 51;
                    }

                    cambiosEnLaBobina.lastWeight = mainCoil.netWeigth;
                    mainCoil.netWeigth = Convert.ToDouble(txtPesoMC.Text);
                    cambiosEnLaBobina.newWeight = mainCoil.netWeigth;
                    cambiosEnLaBobina.fkUser = clsGlobal.LoggedUser.codsec;

                    bool chng = cambiosEnLaBobina.save();
                    bool maincoilsv = mainCoil.save();

                    if (chng == true && maincoilsv == true)
                    {
                        MessageBox.Show("Se cambiaron los datos con Exito.", "Exito", MessageBoxButtons.OK);
               
                    }
                    else
                    {
                        MessageBox.Show("Problema en el guardado de datos, por favor contacte al Administrador del Sistema", "¡Error!", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("La bobina que ingreso no existe o el código es erroneo.", "Advertencia", MessageBoxButtons.OK);
                    txtMainCoil.Text = string.Empty;
                    mainCoil = new clsMainCoil();
                }
            }
            else
            {
                if (cmbEstadoMC.SelectedIndex == -1)
                {
                    cmbEstadoMC.BackColor = Color.Salmon;
                    MessageBox.Show("Por favor seleccione un estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtPesoB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != 46))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPesoB.Focus();
            }
        }

        private void txtPesoMC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter) && (e.KeyChar != 46)) //En teoria el keychar 46 es el punto. 
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPesoMC.Focus();
            }
        }

        private void limpiarForm()
        {
            txtMainCoil.BackColor = Color.White;
            txtMainCoilLength.Text = string.Empty;
            txtMainCoilLote.Text = string.Empty;
            txtMainCoilInic.Text = string.Empty;
            txtMainCoilEnd.Text = string.Empty;
            txtMainCoilNotes.Text = string.Empty;
            txtMainCoilWidth.Text = string.Empty;
            txtNetWeigth.Text = string.Empty;
            txtMainCoilLength.Text = string.Empty;
            txtMainCoilNotes.Text = string.Empty;
            txtPesoMC.Text = string.Empty;
            mainCoil = new clsMainCoil();

            txtProducto.Text = string.Empty;
            txtBodegaB.Text = string.Empty;
            txtMetraje.Text = string.Empty;
            txtLote.Text = string.Empty;
            txtBMadre.Text = string.Empty;
            txtfCorte.Text = string.Empty;
            txtAncho.Text = string.Empty;
            txtPesoB.Text = string.Empty;
            txtCalidad.Text = string.Empty;
            cmbBodega.ResetText();
            cmbEstado.ResetText();
            txtPesoB.Text = string.Empty;
            txtCodCoil.Text = string.Empty;
            txtCodCoil.BackColor = Color.White;
            coil = new clsCoil();
        }

        private void cargarDgv(clsCoil coil)
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("CALL vwConsuptionByCoilCode WHERE coil_code = '" + coil.code + "'");
            if (DS.Tables.Count > 0 && DS.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
                {
                    dgvConsumo.Rows.Add();
                    dgvConsumo.Rows[dgvConsumo.Rows.Count - 1].Cells[clmCodigo.Index].Value = DS.Tables[0].Rows[i]["coil_code"].ToString();
                    dgvConsumo.Rows[dgvConsumo.Rows.Count - 1].Cells[clmConsumo.Index].Value = DS.Tables[0].Rows[i]["cbscs_length"].ToString();
                    dgvConsumo.Rows[dgvConsumo.Rows.Count - 1].Cells[clmCutOrder.Index].Value = DS.Tables[0].Rows[i]["cord_codsec"].ToString();
                }
            }
        }

    }
}
