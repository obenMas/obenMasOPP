using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Lite
{
    public partial class frmNewPalletMovement : Form
    {
        clsNewPreShipping nPD = new clsNewPreShipping();
        clsPallet pallet = new clsPallet();
        clsCoilCellar bodOrg = new clsCoilCellar();
        clsPalletMovements movimientoPallet = new clsPalletMovements();
        clsCoilCellar bodDest = new clsCoilCellar();
        private bool pdsel = false;
        private bool cons = false;

        public frmNewPalletMovement()
        {
            InitializeComponent();
            this.MaximizeBox = true;
            txtOrg.Enabled = true;
            txtOrg.Focus();
        }

        public void setPD(string nupd)
        {
            nPD = new clsNewPreShipping(nupd);
        }

        #region Funcion txtOrg

        private void txtOrg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)  // Apretó enter. 
            {
                if (txtOrg.Text != string.Empty) // Se fija que no este vacío. 
                {
                    switch (txtOrg.Text.ToLower()) // Por ahora en el origen no pasa nada si no pone SELECCIONAR PD
                    {
                        case "selectpd":  // Abre la pantalla para hacer la selección de PD. 
                            //frmPDSelect SPD = new frmPDSelect(this);
                            //SPD.ShowDialog();
                            pdsel = true;
                            txtOrg.Enabled = false;
                            txtCodPallet.Enabled = true;
                            txtCodPallet.Focus();
                            //txtOrg.Clear();
                            //txtOrg.Focus();
                            //if(nPD.codsec!=0)
                            //{
                            //    frmPalletForDispatch PdLince = new frmPalletForDispatch(pdsel);
                                //PdLince.StartPosition = FormStartPosition.CenterParent;
                            //    PdLince.MaximizeBox = true;
                            //    PdLince.ShowDialog();
                            //    pdsel = "no";
                            //}
                        break;
                        case "consulta":
                            cons = true;
                            txtOrg.Enabled = false;
                            txtCodPallet.Enabled = true;
                            txtCodPallet.Focus();
                            break;

                        case "palletizado":
                            bodOrg = new clsCoilCellar(4014);
                            txtOrg.Enabled = false;
                            txtCodPallet.Enabled = true;
                            txtCodPallet.Focus();
                        break;
                        case "prod. proceso": // Pilar
                            bodOrg = new clsCoilCellar(4015);
                            txtOrg.Enabled = false;
                            txtCodPallet.Enabled = true;
                            txtCodPallet.Focus();
                        break;
                        case "mov viejo":
                        frmPalletMovement pltViejo = new frmPalletMovement();
                        pltViejo.Show();
                        break;
                        default:
                        if (txtOrg.Text.ToLower().Contains("cancelar")) 
                        {
                            txtOrg.Clear();
                            nPD = new clsNewPreShipping();
                            txtOrg.Focus();
                            lblPreDesp.Text = "Sin Pre-Despacho Seleccionado";
                            groupBox4.Visible = false;
                        }
                        else if (txtOrg.Text.ToLower().Contains("posicion ") || txtOrg.Text.ToLower().Contains("picking"))
                        {
                            bodOrg = new clsCoilCellar(4016);
                            txtOrg.Enabled = false;
                            txtCodPallet.Enabled = true;
                            txtCodPallet.Focus();
                        }
                        else
                        {
                            abrirForm("NoExisteBodega");
                            txtOrg.Clear();
                            txtOrg.Focus();
                        }
                        
                        break;
                    }
                }
                else
                {
                    abrirForm("poneBodOrg"); // Error de que el txtbodorg esta vacio 
                    txtOrg.Clear();
                    txtOrg.Focus();
                }   
            }
        }

        #endregion 

        #region Funciones txtPallet

        private void txtCodPallet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Apretó enter. 
            {
                if(cons)
                {
                    if (txtCodPallet.Text != string.Empty)
                    {
                        pallet = clsPallet.getDetailByCode(txtCodPallet.Text);

                        if (!txtCodPallet.Text.ToLower().Contains("cancelar"))
                        {
                            if(pallet.codsec!=0)
                            {
                                frmPalletQuery consulta = new frmPalletQuery(pallet);
                                consulta.ShowDialog();
                                txtCodPallet.Clear(); 
                                txtCodPallet.Focus();
                            }
                            else
                            {
                                txtCodPallet.Clear();
                                txtCodPallet.Focus();
                            }
                        }
                        else
                        {
                            cons = false;
                            txtOrg.Clear();
                            txtCodPallet.Clear();
                            txtOrg.Enabled = true;
                            txtCodPallet.Enabled = false;
                            txtOrg.Focus();
                        }
                    }
                }
                else
                {
                    if (pdsel)
                    {
                        if (txtCodPallet.Text != string.Empty)
                        {
                            if (!txtCodPallet.Text.ToLower().Contains("cancelar"))
                            {
                                if (txtCodPallet.Text.Length == 8)
                                {
                                    nPD = new clsNewPreShipping(txtCodPallet.Text.Substring(0, 2) + "-" + txtCodPallet.Text.Substring(3, 5));

                                    if (nPD.codsec != 0)
                                    {
                                        if (nPD.fkStatus == 3068)
                                        {
                                            lblPreDesp.Text = "Pre-Despacho N° " + nPD.number;
                                            groupBox4.Visible = true;
                                            calcularPalletsDespachados();
                                            txtOrg.Clear();
                                            txtCodPallet.Clear();
                                            txtOrg.Enabled = true;
                                            txtCodPallet.Enabled = false;
                                            txtOrg.Focus();
                                        }
                                        else
                                        {
                                            abrirForm("ProbEstado");
                                        }
                                    }
                                    else
                                    {
                                        abrirForm("NoPD");
                                    }
                                }
                                else
                                {
                                    abrirForm("NoPD");
                                }
                            }
                            else
                            {
                                pdsel = false;
                                txtOrg.Clear();
                                txtCodPallet.Clear();
                                txtOrg.Enabled = true;
                                txtCodPallet.Enabled = false;
                                txtOrg.Focus();
                                lblPreDesp.Text = "Sin Pre-Despacho Seleccionado";
                                groupBox4.Visible = false;
                            }
                        }
                        pdsel = false;
                    }
                    else
                    {
                        pallet = clsPallet.getDetailByCode(txtCodPallet.Text);

                        if (txtOrg.Text != string.Empty)// Se fija que el anterior no haya quedado vacío. 
                        {
                            // Chequea que el chango que maneja la maquina no quiera cancelar ese codigo de pallet. Si lo quiere hacer pasa por el else y limpia todo. 
                            if (!txtCodPallet.Text.ToLower().Contains("cancelar"))
                            {
                                if (pallet.codsec != 0) // Se fija que el pallet exista.
                                {
                                    if (bodOrg.codsec == pallet.fkPalletCoilcellar)
                                    {
                                        if (bodOrg.codsec != 4016)
                                        {
                                            if (pallet.fkStatus == 38 || pallet.fkStatus == 42 || pallet.fkStatus == 3073)
                                            {
                                                if (nPD.codsec == 0 || nPD.palletInPD(pallet.codsec))
                                                {
                                                    //txtOrg.BackColor = Color.LightGreen;
                                                    //txtCodPallet.BackColor = Color.LightGreen;
                                                    txtCodPallet.Enabled = false;
                                                    txtFinal.Enabled = true;
                                                    txtFinal.Focus();
                                                }
                                                else
                                                {
                                                    txtCodPallet.Clear();
                                                    txtCodPallet.Focus();
                                                    abrirForm("pltNoInPD");
                                                }
                                            }
                                            else
                                            {
                                                abrirForm("estadoPallet"); // algun otro estado del pallet que no sea abierto o Activo
                                                txtCodPallet.Clear();
                                                txtCodPallet.Focus();
                                            }
                                        }
                                        else
                                        {
                                            if (txtOrg.Text.ToLower() == pallet.position.ToLower())
                                            {
                                                if (pallet.fkStatus == 38 || pallet.fkStatus == 42 || pallet.fkStatus == 3073)
                                                {
                                                    if (nPD.codsec == 0 || nPD.palletInPD(pallet.codsec))
                                                    {
                                                        //txtOrg.BackColor = Color.LightGreen;
                                                        //txtCodPallet.BackColor = Color.LightGreen;
                                                        txtCodPallet.Enabled = false;
                                                        txtFinal.Enabled = true;
                                                        txtFinal.Focus();
                                                    }
                                                    else
                                                    {
                                                        txtCodPallet.Clear();
                                                        txtCodPallet.Focus();
                                                        abrirForm("pltNoInPD");
                                                    }
                                                }
                                                else
                                                {
                                                    abrirForm("estadoPallet"); // algun otro estado del pallet que no sea abierto o Activo
                                                    txtCodPallet.Clear();
                                                    txtCodPallet.Focus();
                                                }
                                            }
                                            else
                                            {
                                                if (txtOrg.Text.ToLower() == "posicion " + pallet.position.ToLower())
                                                {
                                                    if (pallet.fkStatus == 38 || pallet.fkStatus == 42 || pallet.fkStatus == 3073)
                                                    {
                                                        if (nPD.codsec == 0 || nPD.palletInPD(pallet.codsec))
                                                        {
                                                            //txtOrg.BackColor = Color.LightGreen;
                                                            //txtCodPallet.BackColor = Color.LightGreen;
                                                            txtCodPallet.Enabled = false;
                                                            txtFinal.Enabled = true;
                                                            txtFinal.Focus();
                                                        }
                                                        else
                                                        {
                                                            txtCodPallet.Clear();
                                                            txtCodPallet.Focus();
                                                            abrirForm("pltNoInPD");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        abrirForm("estadoPallet"); // algun otro estado del pallet que no sea abierto o Activo
                                                        txtCodPallet.Clear();
                                                        txtCodPallet.Focus();
                                                    }
                                                }
                                                else // El pallet no se encuentra en la bodega de origen que selecciono. 
                                                {
                                                    abrirForm("NoEstaEnEsaBodega");
                                                    txtCodPallet.Clear();
                                                    txtCodPallet.Enabled = false;
                                                    txtOrg.Enabled = true;
                                                    txtOrg.Clear();
                                                    txtOrg.Focus();
                                                }
                                            }

                                        }
                                    }
                                    else // El pallet no se encuentra en la bodega de origen que selecciono. 
                                    {
                                        abrirForm("NoEstaEnEsaBodega");
                                        txtCodPallet.Clear();
                                        txtCodPallet.Enabled = false;
                                        txtOrg.Enabled = true;
                                        txtOrg.Clear();
                                        txtOrg.Focus();
                                    }
                                }
                                else
                                {
                                    txtCodPallet.Clear();
                                    txtCodPallet.Focus();
                                    abrirForm("codPalletMal"); // El codigo de pallet esta mal o no esta en sistema.
                                }
                            }
                            else
                            {
                                txtOrg.Clear();
                                txtCodPallet.Clear();
                                txtOrg.Enabled = true;
                                txtCodPallet.Enabled = false;

                                txtOrg.Focus();
                            }
                        }
                        else
                        {
                            abrirForm("poneBodOrg"); // Otro control de que por alguna extraña razón el chango no puso la bodega de origen
                            txtOrg.Clear();
                            txtCodPallet.Clear();
                            txtOrg.Enabled = true;
                            txtCodPallet.Enabled = false;
                            txtOrg.Focus();
                        }
                    }
                }
                
            }
        }

#endregion

        #region Funciones txtFinal

        private void txtFinal_KeyDown(object sender, KeyEventArgs e)
        {
            bool anduvoPallet = false;
            bool anduvoMov = false;
            bool cancelar = false;

            if (e.KeyCode == Keys.Enter) // Apreto enter. 
            {
                if (txtOrg.Text != txtFinal.Text) // Bodega origen y destino tienen el mismo texto, por ende, son iguales. 
                {
                    if (txtCodPallet.Text != string.Empty) // Por alguna extraña razón(imposible) dejo el codigo de pallet vacío. 
                    {
                        //pallet = clsPallet.getDetailByCode(txtCodPallet.Text);
                        bodDest = new clsCoilCellar();

                        switch (txtFinal.Text.ToLower())
                        {
                            case "palletizado":

                                bodDest = new clsCoilCellar(4014);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se movio a Palletizado";
                                

                                clsPallet.transferTo(pallet, 4014);

                                pallet.position = "0";
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "prod. proceso": // Pilar

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4015);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se movio a la bodega Prod. Proceso";
    
                                clsPallet.transferTo(pallet, 4015); // Se pasael pallet a Prod en Proceso Pilar.

                                pallet.position = "0";
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 1":
                                
                            // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 1";                            

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "1";

                                anduvoMov = movimientoPallet.save();
                                anduvoPallet = pallet.save();

                                break;
                            case "posicion 2":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 2";  
                                
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "2";
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 3":
                                
                                // Registro el movimiento, asi le damos trazabilidad al pallet.
                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 3";  

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "3";
                                anduvoPallet = pallet.save();

                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 4":
                                
                                // Registro el movimiento, asi le damos trazabilidad al pallet.
                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 4";  

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "4";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 5":
                                
                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 5";  


                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "5";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 6":
                                
                                // Registro el movimiento, asi le damos trazabilidad al pallet.
                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.fkOrigCellar = pallet.fkCoilCellar;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 6";  

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "6";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 7":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.
                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 7";  
                               
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "7";
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 8":
                                
                                // Registro el movimiento, asi le damos trazabilidad al pallet.
                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 8";  
                               
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "8";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 9":
                               
                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 9";  
                               
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "9";
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 10":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 10"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "10";

                                anduvoPallet = pallet.save();

                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 11":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 11"; 
                                
                                clsPallet.transferTo(pallet, 4016);
                                
                                pallet.position = "11";
                                anduvoPallet = pallet.save();
                                

                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 12":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 12"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "12";
                                anduvoPallet = pallet.save();

                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 13":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 13"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "13";
                                anduvoPallet = pallet.save();

                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 14":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.
                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 14"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "14";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 15":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 15"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "15";
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 16":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 16"; 
                                
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "16";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 17":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 17"; 
                                
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "17";

                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 18":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 18"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "18";
                          
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();
    
                                break;
                            case "posicion 19":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 19"; 
                                
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "19";
                          
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();

                                break;
                            case "posicion 20":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 20"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "20";
                                anduvoMov = movimientoPallet.save();

                                anduvoPallet = pallet.save();

                                break;
                            case "posicion 21":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 21"; 
                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "21";
                                
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 22":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 22"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "22";
                                
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();
                                break;
                            case "posicion 23":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se cambio a Posición 23"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "23";
                               
                                anduvoPallet = pallet.save();
                                anduvoMov = movimientoPallet.save();
                                break;
                            case "picking":

                                // Registro el movimiento, asi le damos trazabilidad al pallet.

                                bodDest = new clsCoilCellar(4016);  
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Se movió a area de Picking"; 

                                clsPallet.transferTo(pallet, 4016);
                                pallet.position = "Picking";

                                anduvoMov = movimientoPallet.save();
                                anduvoPallet = pallet.save();

                                break;

                            case "despacho":

                                // Genero el movimiento para darle trazabilidad
                                if(nPD.codsec!=0)
                                {
                                    movimientoPallet.date = DateTime.Now;
                                    movimientoPallet.fkOrigCellar = pallet.fkCoilCellar;
                                    movimientoPallet.fkDestCellar = pallet.fkCoilCellar;
                                    movimientoPallet.fkPallet = pallet.codsec;
                                    movimientoPallet.fkProduct = pallet.fkProduct;
                                    movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                    movimientoPallet.type = "Despacho de pallet";

                                    anduvoMov = movimientoPallet.save();

                                    clsPallet.setPalletAsDelivered(pallet.codsec);
                                }
                                else
                                {
                                    abrirForm("soloSePermiteDespacho");
                                    txtFinal.Clear();
                                    txtFinal.Enabled=false;
                                    txtFinal.Focus();
                                }

                                break;
                            /*case "Despacho": // Aca ya el pallet volaria al pingo. 
                                
                                clsPallet.setPalletAsDelivered(pallet.codsec); // Se setea en 40 el estado del pallet y 36 las bobinas
                                movimientoPallet.date = DateTime.Now;
                                movimientoPallet.fkOrigCellar = bodOrg.codsec;
                                movimientoPallet.fkDestCellar = bodDest.codsec;
                                movimientoPallet.fkPallet = pallet.codsec;
                                movimientoPallet.fkProduct = pallet.fkProduct;
                                movimientoPallet.fkUser = clsGlobal.LoggedUser.codsec;
                                movimientoPallet.type = "Despacho de Pallet";

                                anduvoMov = movimientoPallet.save();
                                anduvoPallet = pallet.save();
                                break;*/
                           /* case "DESELECTPD":  // Esto creo que lo voy a tener que sacar y se lo voy a delegar al frmPalletForPD
                                
                                // Se quitaria el predespacho que tiene seleccionado. Y se limpia todo el form
                                txtCodPallet.Text = string.Empty;
                                txtFinal.Text = string.Empty;
                                txtOrg.Text = string.Empty;
                                txtOrg.Focus();

                                break;*/
                            case "cancelar":  // Quiere volver para atras. 

                                txtFinal.Clear();
                                txtCodPallet.Clear();
                                //txtCodPallet.BackColor = Color.White;
                                //txtOrg.BackColor = Color.White;
                                txtOrg.Enabled = false;
                                txtFinal.Enabled = false;
                                txtCodPallet.Enabled = true;
                                txtCodPallet.Focus();
                                cancelar = true;
                                break;
                            default:  // Aca caeria el cambio de posición en campana, que eso se va a ver.  
                                break;

                        } // Aca termina el switch lince

                        if (txtFinal.Text.ToLower().Contains("cancelar"))
                        {
                            txtFinal.Clear();
                            txtCodPallet.Clear();
                            txtFinal.Enabled = false;
                            txtCodPallet.Enabled = true;
                            txtCodPallet.Focus();
                        }

                        if (bodDest.codsec != bodOrg.codsec && bodDest.codsec == 4016)  
                        {
                            if (!clsPallet.saveinPL(pallet))
                            {
                                abrirForm("errorIntPresea");
                            }
                        }

                    } // Completa el código papu. 
                    else
                    {
                        abrirForm("PoneElCodigo");
                        txtFinal.Clear();
                        txtCodPallet.Clear();
                        txtFinal.Enabled = false;
                        txtCodPallet.Enabled = true;
                        txtCodPallet.Focus();
                    }
                }
                else // Bodega de org y destino iguales 
                {
                    abrirForm("OrgDestIgual");
                    txtFinal.Clear();
                    txtFinal.Focus();
                }
 
                if (anduvoPallet && anduvoMov)
                {
                    abrirForm("Confirmar");
                    if (nPD.codsec != 0)
                    {
                        calcularPalletsDespachados();

                        if (lblX.Text == lblY.Text)
                        {
                            nPD = new clsNewPreShipping();
                            lblPreDesp.Text = "Sin Pre-Despacho Seleccionado";
                            groupBox4.Visible = false;
                        }
                    }
                    txtCodPallet.Clear();
                    txtOrg.Clear();
                    txtFinal.Clear();
                    txtFinal.Enabled = false;
                    txtCodPallet.Enabled = false;
                    txtOrg.Enabled = true;
                    txtCodPallet.BackColor = Color.White;
                    txtOrg.BackColor = Color.White;
                    txtOrg.Focus();
                }
                else
                {
                    if(!cancelar)
                    {
                        abrirForm("ProbDeProcesamiento");
                        txtCodPallet.Clear();
                        txtOrg.Clear();
                        txtFinal.Clear();
                        //txtCodPallet.BackColor = Color.White;
                        //txtOrg.BackColor = Color.White;
                        txtFinal.Enabled = false;
                        txtCodPallet.Enabled = false;
                        txtOrg.Enabled = true; 
                        txtOrg.Focus();
                    }
                }
            }
        }

        #endregion

        private void abrirForm(string mensaje) // Abre el formulario de errores customizado
        {
            frmCustomizedMessageBox mensageBox = new frmCustomizedMessageBox(mensaje);
            mensageBox.ShowDialog();
        }

        private void frmNewPalletMovement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void calcularPalletsDespachados() // Aca va a tener la consulta para que le muestre los pallet que va despachando. 
        {
            DataSet DS = new DataSet();
            int cantpltDespachados = 0;

            DS = clsConnection.getDataSetResult("CALL spPalletInPD(" + nPD.codsec + ")");

            for (int i = 0; i < DS.Tables[0].Rows.Count; i++)
            {
                if (DS.Tables[0].Rows[i]["estadoPlt"].ToString() == "40")
                {
                    cantpltDespachados++;
                }
            }

            lblY.Text = DS.Tables[0].Rows.Count.ToString();
            lblX.Text = cantpltDespachados.ToString();

            if (lblX.Text == lblY.Text)
            {
                nPD.setAsDispatched();
            }

        }
    }
}
