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
    public partial class frmNewProductionOrderMetal : Form
    {

        clsNewProductionOrderMetal pom = new clsNewProductionOrderMetal();
        DataSet filmEquiv = new DataSet();

        public frmNewProductionOrderMetal()
        {
            InitializeComponent();
            dgvOrdenesDeMetal();
            ocultarAlta();
            loadComboMachine();
            cargarCombos();
        }

        #region Eventos Formulario

        private void chkAlta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlta.Checked)
            {
                grpAlta.Enabled = true;
                loadComboMachine();
                txtLote.Text = DateTime.Now.Year.ToString().Substring(2,2);
                filmEquiv = clsConnection.getDataSetResult("SELECT * FROM vwBaseEquivalenceToMetal");

                for (int i = 0; i < filmEquiv.Tables[0].Rows.Count; i++)
                {
                    cmbOrg.Items.Add(filmEquiv.Tables[0].Rows[i]["filmInit"]);
                }
            }
            else
            {
                grpAlta.Enabled = false;
            }
        }
        
        private void ocultarAlta()
        {
            grpAlta.Enabled = false;
        }

        private void cmbOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrg.SelectedIndex != -1 || cmbOrg.SelectedItem.ToString() != string.Empty)
            {
                cmbDest.Enabled = true;
                filmEquiv = clsConnection.getDataSetResult("SELECT * FROM vwBaseEquivalenceToMetal WHERE filmInit = '" + cmbOrg.SelectedItem.ToString() + "'");
                txtLote.Text += cmbOrg.SelectedItem.ToString().Substring(0, 2);

                for (int i = 0; i < filmEquiv.Tables[0].Rows.Count; i++)
                {
                    cmbDest.Items.Add(filmEquiv.Tables[0].Rows[i]["filmFin"]);
                }
            }
            else
            {
                cmbDest.Enabled = false;
            }
        }

        private void cmbDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLote.Text += cmbDest.SelectedItem.ToString().Substring(0, 2) + clsSequential.SequentialList("metallizedOrder");
            
        }

        private void dgvProdOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != clmEditar.Index || e.ColumnIndex != clmEditar.Index)
            {
                    pom = new clsNewProductionOrderMetal(dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString());
                    txtLote.Text = dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString();
                    nudCantidad.Text = dgvProdOrders.CurrentRow.Cells[clmQuantity.Index].Value.ToString();
                    cmbOrg.SelectedIndex = cmbOrg.FindString(dgvProdOrders.CurrentRow.Cells[clmFilmOrg.Index].Value.ToString());
                    txtAncho.Text = dgvProdOrders.CurrentRow.Cells[clmAncho.Index].Value.ToString();
                    cmbDest.SelectedIndex = cmbDest.FindString(dgvProdOrders.CurrentRow.Cells[clmFilmDest.Index].Value.ToString());
                    txtObservation.Text = pom.observation.ToString();

                    if (Convert.ToInt32(dgvProdOrders.CurrentRow.Cells[clmMachineCodsec.Index].Value) == 2011)
                    {
                        cmbMachine.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbMachine.SelectedIndex = 1;
                    }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            chkAlta.Checked = false;
            deshabilitar();
            limpiarControles();
        }

        #endregion

        #region Guardar POM

        private void dgvProdOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!chkAlta.Checked)
            {
                if (e.ColumnIndex == clmEditar.Index) // Puede editar la orden.
                {
                    pom = new clsNewProductionOrderMetal(dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString());
                    txtLote.Text = dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString();
                    nudCantidad.Text = dgvProdOrders.CurrentRow.Cells[clmQuantity.Index].Value.ToString();
                    cmbOrg.SelectedIndex = cmbOrg.FindString(dgvProdOrders.CurrentRow.Cells[clmFilmOrg.Index].Value.ToString());
                    txtAncho.Text = dgvProdOrders.CurrentRow.Cells[clmAncho.Index].Value.ToString();
                    cmbDest.SelectedIndex = cmbDest.FindString(dgvProdOrders.CurrentRow.Cells[clmFilmDest.Index].Value.ToString());

                    if (Convert.ToInt32(dgvProdOrders.CurrentRow.Cells[clmMachineCodsec.Index].Value) == 2011)
                    {
                        cmbMachine.SelectedIndex = 0;
                    }
                    else
                    {
                        cmbMachine.SelectedIndex = 1;
                    }

                    deshabilitar();
                    grpAlta.Enabled = true;
                    nudCantidad.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnGuardar.Enabled = true;

                }
                else if (e.ColumnIndex == clmEliminar.Index) // Eliminaria la orden
                {
                    var rta = MessageBox.Show("Esta a punto de eliminar una orden. \n ¿Esta seguro de realizar esta acción?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    switch (rta)
                    {
                        case DialogResult.No:
                            break;
                        case DialogResult.Yes:
                            
                            pom = new clsNewProductionOrderMetal(dgvProdOrders.CurrentRow.Cells[clmLote.Index].Value.ToString());

                            if (clsNewProductionOrderMetalDetail.CanCancel(pom.lote))
                            {
                                if (pom.cancel())
                                {
                                    MessageBox.Show("Se cancelo la orden correctamente.","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
                                    dgvOrdenesDeMetal();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo cancelar la orden de metal. \n Por favor, contacte con el administrador del sistema","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                rta = MessageBox.Show("Esta por cerrar una orden que se encuentra incompleta. \n ¿Esta seguro de cerrarla?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                                switch (rta)
                                {
                                   
                                    case DialogResult.No:
                                        break;
                                    case DialogResult.Yes:
                                        if (pom.cancel())
                                        {
                                            dgvOrdenesDeMetal();
                                            MessageBox.Show("Se Anulo la orden con exito.","Confirmacion",MessageBoxButtons.OK);
                                        }
                                        else
                                        {
                                            MessageBox.Show("No se anulo la orden. \n Por favor, contacte con el administrador del sistema","Advertencia",MessageBoxButtons.OK);
                                        }
                                        break;
                                }
                            }
                       break;
                    }
                }
            }
            else
            {
                limpiarControles();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (chkAlta.Checked)
                {
                    int fkfilm=0;

                    pom.createdBy = clsGlobal.LoggedUser.codsec;
                    pom.fkFilmInit = ((fkfilm = clsBopp.getFilmByCode(cmbOrg.SelectedItem.ToString())) != 0) ? fkfilm : clsCast.getFilmByCode(cmbOrg.SelectedItem.ToString());
                    pom.fkFilmFin = ((fkfilm = clsBopp.getFilmByCode(cmbDest.SelectedItem.ToString())) != 0) ? fkfilm : clsCast.getFilmByCode(cmbDest.SelectedItem.ToString());
                    pom.fkStatus = 46;
                    pom.initEstimatedDate = dtpInicioEst.Value;
                    pom.lote = txtLote.Text;
                    pom.modifiedDate = DateTime.Now;
                    pom.observation = txtObservation.Text;
                    pom.quantity = Convert.ToDouble(nudCantidad.Text);
                    pom.width = Convert.ToInt32(txtAncho.Text);
                    pom.CreatedDate = DateTime.Now;
                    pom.modifiedBy = clsGlobal.LoggedUser.codsec;


                    if (pom.save())
                    {
                        MessageBox.Show("Se ha creado la orden de metalizado con exito","Exito",MessageBoxButtons.OK);
                        limpiarControles();
                        dgvOrdenesDeMetal();
                        clsSequential.addSequential("metallizedOrder");
                    }
                    else
                    {
                        MessageBox.Show("La orden no se creo debido a un error.\n Por favor, contacte con el administrador del sistema.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    pom.quantity = Convert.ToDouble(nudCantidad.Text);
                    pom.observation = txtObservation.Text;
                    if (pom.save())
                    {
                        MessageBox.Show("Se ha Actualizado la orden de metalizado con exito", "Exito", MessageBoxButtons.OK);
                        limpiarControles();
                        dgvOrdenesDeMetal();
                        deshabilitar();
                    }
                    else
                    {
                        MessageBox.Show("La orden no se actualizó debido a un error.\n Por favor, contacte con el administrador del sistema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Para continuar complete los campos indicados en Rojo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Funciones

        private void limpiarControles()
        {
            foreach (Control c in this.grpAlta.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.ResetText();
                }
            }
            chkAlta.Checked = false;
        }

        private void deshabilitar()
        {
            txtLote.Enabled = false;
            cmbDest.Enabled = false;
            cmbOrg.Enabled = false;
            txtAncho.Enabled = false;
            dtpInicioEst.Enabled = false;
            cmbMachine.Enabled = false;
            chkAlta.Enabled = false;
            grpAlta.Enabled = false;
        }

        private void habilitar()
        {
            txtLote.Enabled = true;
            cmbDest.Enabled = true;
            cmbOrg.Enabled = true;
            txtAncho.Enabled = true;
            dtpInicioEst.Enabled = true;
            cmbMachine.Enabled = true;
            chkAlta.Enabled = true;
            grpAlta.Enabled = true;
        }


        private bool Validar()
        {
            bool bandera = true;

            foreach (Control c in this.grpAlta.Controls)
            {
                if (c is TextBox && c != txtObservation)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {

                        c.BackColor = Color.LightCoral;
                        bandera = false;
                    }
                    else
                    {
                        c.BackColor = Color.White;
                    }
                }
                else if (c is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(((ComboBox)c).SelectedItem.ToString()))
	                {
                        c.BackColor = Color.LightCoral;
                        bandera = false;
                    }
                    else
                    {
                        c.BackColor = Color.White;
                    }
                }
                else if (c is NumericUpDown)
                {
                    if (Convert.ToDouble(c.Text) <= 0)
                    {
                        c.BackColor = Color.LightCoral;
                        bandera = false;
                    }
                    else
                    {
                        c.BackColor = Color.White;
                    }
                }
            }
            return bandera;
        }

        private void cargarCombos()
        {
            filmEquiv = clsConnection.getDataSetResult("SELECT * FROM vwBaseEquivalenceToMetal");

            for (int i = 0; i < filmEquiv.Tables[0].Rows.Count; i++)
            {
                cmbOrg.Items.Add(filmEquiv.Tables[0].Rows[i]["filmInit"]);
            }

            for (int i = 0; i < filmEquiv.Tables[0].Rows.Count; i++)
            {
                cmbDest.Items.Add(filmEquiv.Tables[0].Rows[i]["filmFin"]);
            }
        }

        private void loadComboMachine()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            cmbMachine.Items.Clear();
            if (cmbMachine.SelectedIndex + 1 >= 0)
            {
                lstMachine = clsMachine.getMetallizerMachineList();
                for (int i = 0; i < lstMachine.Count; i++)
                    cmbMachine.Items.Add(lstMachine[i]);
            }
        }

        #endregion

        #region Cargar el DGV

        private void dgvOrdenesDeMetal()
        {
            DataSet DS = new DataSet();

            DS = clsConnection.getDataSetResult("SELECT * FROM vwNewProductionOrderMetal");

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
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmCantMKilos.Index].Value = Math.Round(Convert.ToDouble(DS.Tables[0].Rows[i]["pesoTot"]),2);
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmObservation.Index].Value = DS.Tables[0].Rows[i]["Observacion"].ToString();
                    dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].Cells[clmActiveOrder.Index].Value = (DS.Tables[0].Rows[i]["estado"].ToString() == "Proceso") ? global::BPS.Properties.Resources.Pause_Hot : global::BPS.Properties.Resources.Play_Hot;
                    
                    if (DS.Tables[0].Rows[i]["estado"].ToString() == "Proceso")
                        dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Orange;
                    else
                        dgvProdOrders.Rows[dgvProdOrders.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        #endregion


    }
}
