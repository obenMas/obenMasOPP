using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BPS.Lite
{
    public partial class frmCustomizedMessageBox : Form
    {
        string explosion = "";

        public frmCustomizedMessageBox(string explo)
        {
            InitializeComponent();
            explosion = explo;
            picError.Visible = true;
            pctConfirm.Visible = false;
        }

        private void funcionExplotarMsjBox(string explosion)
        {
            switch (explosion)
            {
                case "NoEstaEnEsaBodega":
                    lblMensaje.Text = "El pallet Seleccionado no se encuentra en la bodega que seleccionó";
                    break;
                case "OrgDestIgual":
                    lblMensaje.Text = "La bodega orgen y destino, no pueden ser iguales";
                    break;
                case "PoneElCodigo":
                    lblMensaje.Text = "Por favor ingrese el código de Pallet";
                    break;
                case "poneBodOrg":
                    lblMensaje.Text = "Por favor complete la bodega de origen";
                    break;
                case "codPalletMal":
                    lblMensaje.Text = "El pallet ingresado no existe, o el codigo es erroneo.";
                    break;
                case "SelectPD":
                    lblMensaje.Text = "Por favor, ingrese numero PD";
                    break;
                case "Confirmar":
                    lblMensaje.Text = "La operación fue realizada con exito.";
                    pctConfirm.Visible = true;
                    picError.Visible = false;
                    break;
                case "NoPD":
                    lblMensaje.Text = "El Pre-Despacho que ingresó, no existe o el código es erroneo.";
                    break;
                case "ProbEstado":
                    lblMensaje.Text = "El Pre-Despacho que ingresó, no se encuentra en estado Programado. Por favor solicite que se programe dicho PD.";
                    break;
                case "errorIntPresea":
                    lblMensaje.Text = "No se pudo generar el archivo de interface con Presea";
                    break;
                case "estadoPallet":
                    lblMensaje.Text = "El pallet que intenta mover no se encuentra activo.";
                    break;
                case "ProbDeProcesamiento":
                    lblMensaje.Text = "No se pudo procesar correctamente el Guardado de pallet y/o Movimiento. Por favor contacte con el administrador del Sistema";
                    break;
                case "NoExisteBodega":
                    lblMensaje.Text = "La bodega de origen que seleccionó no existe. Por favor, verifique los datos";
                    break;
                case "soloSePermiteDespacho":
                    lblMensaje.Text = "No se pueden despachar pallets si no se selecciona primero un Pre-Despacho.";
                    break;
                case "yaSeDespacho":
                    lblMensaje.Text = "El pallet que intenta despachar ya se encuentra despachado.";
                    break;
                case "pltNoInPD":
                    lblMensaje.Text = "El pallet que intenta ingresa no corresponde al PD que selecciono. Por favor solicite su ingreso.";
                    break;
                default:
                    break;
            }
        }


        private void frmCustomizedMessageBox_Shown(object sender, EventArgs e)
        {
            funcionExplotarMsjBox(explosion);
            this.Refresh();
            Thread.Sleep(3800);
            this.Close();
        }
    }
}
