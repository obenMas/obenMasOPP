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
    public partial class frmPalletForDispatch : Form
    {
        string PD = "";
        clsNewPreShipping nPD = new clsNewPreShipping();
        clsCoilCellar bodOrg = new clsCoilCellar();
        clsPallet pallet = new clsPallet();
        clsPalletMovements palletMovement = new clsPalletMovements();

        public frmPalletForDispatch(string PdNumber) // Paso como parametro el PD, para despues poder llamar el sp que va a cargar el dgv.
        {
            InitializeComponent();
            PD = PdNumber;
            nPD = new clsNewPreShipping(PdNumber);
            lblnroPD.Text = PD;
            calcularPalletsDespachados(); 
        }

        #region txtInicio

        private void txtInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInicio.Text != string.Empty)
                {
                    switch (txtInicio.Text.ToLower())
                    {
                        case "cancelar": //quiere cerrar el formulario. Por que no hay otra manera. 
                            this.Close();
                            break;
                        case "palletizado":
                            bodOrg = new clsCoilCellar(4014);
                            break;
                        case "prod. proceso": // Pilar
                            bodOrg = new clsCoilCellar(4015);
                            break;
                        default:
                            if (txtInicio.Text.ToLower().Contains("posicion") || txtInicio.Text.ToLower().Contains("picking"))
                            {
                                bodOrg = new clsCoilCellar(4016);
                                txtCodigo.Focus();
                            }
                            else
                            {
                                abrirForm("NoExisteBodega");
                                txtInicio.Clear();
                                txtInicio.Focus();
                            }
                            break;
                    }
                    if (txtInicio.Text.Contains("Cancelar"))
                    {   
                        txtInicio.Clear();
                    }
                }
            }
        }

        #endregion

        #region TxtCodigo

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtInicio.Text != string.Empty)
                {
                    if (!txtCodigo.Text.ToLower().Contains("cancelar")) // el textbox de codigo no lo dejaron en blanco.
                    {
                        pallet = clsPallet.getDetailByCode(txtCodigo.Text);
                        //bodOrg = new clsCoilCellar(txtInicio.Text);

                        if (pallet.codsec != 0) // no existe el pallet. 
                        {
                            if (pallet.fkPalletCoilcellar == bodOrg.codsec)
                            {
                                // Aca va la comprobacionde si pertenece. 

                                if (pallet.fkStatus == 38 || pallet.fkStatus == 42 || pallet.fkStatus == 3073)
                                {
                                    txtInicio.BackColor = Color.LightGreen;
                                    txtCodigo.BackColor = Color.LightGreen;
                                    txtFin.Focus();
                                }
                                else if (pallet.fkStatus == 40) 
                                {
                                    abrirForm("yaSeDespacho");
                                    txtFin.Clear();
                                    txtCodigo.Clear();
                                    txtInicio.Clear();
                                    txtInicio.Focus();
                                }
                                else// El pallet no esta activo.
                                {
                                    abrirForm("estadoPallet"); // algun otro estado del pallet que no sea abierto o Activo
                                    txtCodigo.Text = string.Empty;
                                }
                            }
                            else // No esta en esa bodega de origen
                            {
                                txtCodigo.Text = string.Empty;
                                txtInicio.Text = string.Empty;
                                txtInicio.Focus();
                                abrirForm("NoEstaEnEsaBodega");
                            }
                        }
                        else // El pallet no existe lince.
                        {
                            txtCodigo.Text = string.Empty;
                            abrirForm("codPalletMal"); // El codigo de pallet esta mal o no esta en sistema.
                        }
                    }
                    else
                    {
                        txtCodigo.Clear();
                        txtInicio.Focus();
                    }
                }
                else
                {
                    abrirForm("poneBodOrg"); // Otro control de que por alguna extraña razón el chango no puso la bodega de origen
                    txtInicio.Focus();
                }
            }
        }
        #endregion

        #region txtFin

        private void txtFin_KeyDown(object sender, KeyEventArgs e)
        {
            //bool anduvo = false;
            bool anduvoMov = false;

            if (e.KeyCode == Keys.Enter)
            {
                if (txtFin.Text != string.Empty)
                {
                    if (txtInicio.Text != txtFin.Text)
                    {
                        if (txtCodigo.Text != string.Empty)
                        { 
                            if (nPD.palletInPD(pallet.codsec))
                            {
                                switch (txtFin.Text.ToLower())
                                {
                                    case "despacho":

                                        // Genero el movimiento para darle trazabilidad

                                        palletMovement.date = DateTime.Now;
                                        palletMovement.fkOrigCellar = pallet.fkCoilCellar;
                                        palletMovement.fkDestCellar = pallet.fkCoilCellar;
                                        palletMovement.fkPallet = pallet.codsec;
                                        palletMovement.fkProduct = pallet.fkProduct;
                                        palletMovement.fkUser = clsGlobal.LoggedUser.codsec;
                                        palletMovement.type = "Despacho de pallet";

                                        anduvoMov = palletMovement.save();

                                        clsPallet.setPalletAsDelivered(pallet.codsec);
                                        //pallet.position = "Despachado";
                                        //anduvo = pallet.save();

                                        break;

                                    case "cancelar":
                                        txtFin.Clear();
                                        txtCodigo.Clear();
                                        txtCodigo.Focus();
                                        break;

                                    default:
                                        abrirForm("soloSePermiteDespacho");
                                        txtFin.Clear();
                                        break;
                                }
                            }
                            else
                            {
                                clsLog.addLog("PD: "+nPD.number+" Pallet: "+pallet.codsec,1,"frmPalletForDispatch");
                                txtCodigo.Clear();
                                txtCodigo.Focus();
                                abrirForm("pltNoInPD");
                            }

                            if (txtFin.Text.Contains("Cancelar")) // Aca se fija que el chango no quiera cancelar.
                            {
                                txtFin.Clear();
                                txtCodigo.Clear();
                                txtCodigo.Focus();
                            }

                            if (/*anduvo &&*/ anduvoMov) // Si guardo todo, ya esta la tiene adentro y el pallet se tomo el lopa. 
                            {
                                abrirForm("Confirmar");
                                txtFin.Clear();
                                txtCodigo.Clear();
                                txtInicio.Clear();
                                txtInicio.Focus();
                                calcularPalletsDespachados();

                                if (lblX.Text == lblY.Text)
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                abrirForm("ProbDeProcesamiento");
                            }
                        }
                        else //Pone el codigo lince
                        {
                            abrirForm("PoneElCodigo");
                        }
                    }
                    else // Bodega de origen y destino distinto
                    {
                        abrirForm("OrgDestIgual");
                    }
                }
                else // El textbox eta vacio papu
                {
                    abrirForm("soloSePermiteDespacho");
                }
            }
        }

        #endregion  

        private void abrirForm(string mensaje)
        {
            frmCustomizedMessageBox mensageBox = new frmCustomizedMessageBox(mensaje);
            mensageBox.StartPosition = FormStartPosition.CenterScreen;
            mensageBox.ShowDialog();
            //this.Close();
            
        }

        private void calcularPalletsDespachados() // Aca va a tener la consulta para que le muestre los pallet que va despachando. 
        {
            DataSet DS = new DataSet();
            clsNewPreShipping pd = new clsNewPreShipping(PD);
            int cantpltDespachados = 0;

            DS = clsConnection.getDataSetResult("CALL spPalletInPD(" + pd.codsec + ")");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (DS.Tables[0].Rows[i]["estadoPlt"].ToString() == "40")
                {
                    cantpltDespachados++;
                }   
            }

            lblY.Text = DS.Tables[0].Rows.Count.ToString();
            lblX.Text = cantpltDespachados.ToString();

            if(lblX.Text==lblY.Text)
            {
                pd.setAsDispatched();
            }

        }
    }
}
