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
    public partial class frmPDSelect : Form
    {
        clsNewPreShipping PD = new clsNewPreShipping();
        frmNewPalletMovement npmf = new frmNewPalletMovement();

        public frmPDSelect(frmNewPalletMovement form)
        {
            InitializeComponent();
            npmf = form;
        }

        private void txtPD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Pistolea el codigo
            {
                if (txtPD.Text != string.Empty) // Chequea que no este vacio
                {
                    if (!txtPD.Text.ToLower().Contains("cancelar"))
                    {
                        
                        PD = new clsNewPreShipping(txtPD.Text); // Lo instancio

                        if(txtPD.Text.Length==8)
                        {
                            PD = new clsNewPreShipping(txtPD.Text.Substring(0, 2) + "-" + txtPD.Text.Substring(3, 5) +"");
                        }

                        if (PD.codsec != 0 && PD.fkStatus == 3068) // Tiene que existir y estar programado, si no, se tiene que programar. 
                        {
                            npmf.setPD(txtPD.Text.Substring(0, 2) + "-" + txtPD.Text.Substring(3, 5) + "");
                            //frmPalletForDispatch PdLince = new frmPalletForDispatch(txtPD.Text);
                            //PdLince.StartPosition = FormStartPosition.CenterParent;
                            //PdLince.MaximizeBox = true;
                            //PdLince.ShowDialog(); // Abro el formulario para que el chango vaya agregando los pallets a despachar
                            this.Close();
                        }
                        else
                        {
                            if (PD.codsec == 0) // No existe el PD
                            {
                                abrirForm("NoPD"); // No existe el PD, con el código que te mandaron.
                            }
                            else
                            {
                                abrirForm("ProbEstado"); // Pedi programacion lince de las praderas patagonicas, nose como llegaste con ese PD en mano. 
                            }
                        }
                    }
                    else //Quiere cerrar la seleccion de PD
                    {
                        this.Close();
                    }
                }
                else
                {
                    abrirForm("SelectPD"); // Llena el PD maquinola. 
                }
            }
        }

        private void abrirForm(string mensaje)
        {
            frmCustomizedMessageBox mensageBox = new frmCustomizedMessageBox(mensaje);
            //mensageBox.StartPosition = FormStartPosition.CenterScreen;
            mensageBox.ShowDialog();
        }
    }
}
