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
    public partial class frmRelabelFilmEquivalences : Form
    {
        clsPallet pallet = new clsPallet();
        List<clsBopp> listBopp = new List<clsBopp>();
        List<clsCast> listCast = new List<clsCast>();
        List<clsCoating> listCoating = new List<clsCoating>();
        clsProduct producto = new clsProduct();
        List<clsCoil> listaBobinas = new List<clsCoil>();
        clsCoil bobina = new clsCoil();
        

        public frmRelabelFilmEquivalences()
        {
            InitializeComponent();
        }

        #region Carga de pelicula equivalentes.

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.pallet = clsPallet.getDetailByCode(txtCode.Text);

                if (rbBOPP.Checked)
                {

                    cmbEquiv.Items.Clear();
                    cmbEquiv.ResetText();
                    txtCode.Text.Trim();

                    this.producto = new clsProduct(pallet.fkProduct);
                    listBopp = clsBopp.getEquivalentFilmsByBoppFilm(producto.fkBopp);

                    if (listBopp.Count > 0)
                    {
                        for (int i = 0; i < listBopp.Count; i++)
                        {
                            cmbEquiv.Items.Add(listBopp[i].code);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existen equivalencias para la Pelicula seleccionada. Por favor creelas o solicite su creación para poder realizar esta operacion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else if (rbCast.Checked)
                {

                    cmbEquiv.Items.Clear();
                    cmbEquiv.ResetText();
                    txtCode.Text.Trim();

                    this.producto = new clsProduct(pallet.fkProduct);
                    listCast = clsCast.getCastEquivalensceByCastCodsec(producto.fkCast);
                    if (listCast.Count > 0)
                    {
                        for (int i = 0; i < listCast.Count; i++)
                        {
                            cmbEquiv.Items.Add(listCast[i].code);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existen equivalencias para la Pelicula seleccionada. Por favor creelas o solicite su creación para poder realizar esta operacion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
                else if (rbCoating.Checked)
                {
                    //Bueno, emmm funciona hasta el cast. Y hasta ahi el cast. Por que cuasi no existen cargados las
                    //equivalencias de los cast. 
                    MessageBox.Show("Falta desarrollar esto por que no hay cuasi equivalencias de nada viteh", "Hola Chamigo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una pelicula de la cual va a realizar el re-etiquetado equivalente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
        #endregion

        #region Procesado de Pallets.

        private void btnGuardarPallet_Click(object sender, EventArgs e)
        {
            string newCode = "";
            bool bobinasave = false;
            bool palletsave = false;

            clsRelabelEquivalencesMov movRelab = new clsRelabelEquivalencesMov();
            listaBobinas = clsPallet.getListOfCoilsByPalletCodsec(pallet.codsec);

            int posX = producto.code.IndexOf('x');
            producto.code = producto.code.Remove(0, posX);
            newCode = cmbEquiv.Text + producto.code;

            clsProduct productoNew = new clsProduct(newCode);

            pallet.fkProduct = productoNew.codsec;

            if (productoNew.codsec != 0)
            {
                for (int i = 0; i < listaBobinas.Count; i++)
                {
                    listaBobinas[i].fkProduct = productoNew.codsec;
                    
                    movRelab.type = "Re-etiquetado de Pallet y Bobina";
                    movRelab.code = listaBobinas[i].code;
                    movRelab.fkLastProduct = producto.codsec;
                    movRelab.fkNewProduct = productoNew.codsec;
                    movRelab.fkPallet = pallet.codsec;
                    movRelab.fkCoil = listaBobinas[i].codsec;
                    movRelab.date = DateTime.Now;                

                    bobinasave = listaBobinas[i].save();
                    movRelab.save();

                    if (bobinasave == true && (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032))
                    {
                        clsPrintLabels.printCoilLabelPL(listaBobinas[i].codsec, listaBobinas[i].isExternalCoil);   
                    }
                    else
                    {
                        clsPrintLabels.printCoilLabel(listaBobinas[i].codsec, listaBobinas[i].isExternalCoil);
                    }
                }
                palletsave = pallet.save();

                if (palletsave == true && (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032))
                {
                    clsPrintLabels.printPalletLabelPL(pallet.codsec,"local");
                    MessageBox.Show("Datos procesados con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    clsPrintLabels.printPalletLabel(pallet.codsec, "local");
                    MessageBox.Show("Datos procesados con exito", "Exito", MessageBoxButtons.OK);
                }

            }
            else
            {
                MessageBox.Show("No existe el producto equivalente con dichos anchos, por favor créelo y vuelva a intentarlo","¡Error!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
        #endregion

        #region Carga de bobina.

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
                
            if (e.KeyCode == Keys.Enter)
            {
                txtCoilCode.Text.Trim();
                cmbCoilEquivalence.ResetText();
                cmbCoilEquivalence.Items.Clear();

                bobina = clsCoil.getDetailByCode(txtCoilCode.Text);
                if (rbBOPPCoil.Checked)
                {
                    this.producto = new clsProduct(bobina.fkProduct);

                    listBopp = clsBopp.getEquivalentFilmsByBoppFilm(producto.fkBopp);

                    if (listBopp.Count > 0)
                    {
                        for (int i = 0; i < listBopp.Count; i++)
                        {
                            cmbCoilEquivalence.Items.Add(listBopp[i].code);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existen equivalencias para la Pelicula seleccionada. Por favor creelas o solicite su creación para poder realizar esta operacion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (rbCastCoil.Checked)
                {
                    this.producto = new clsProduct(bobina.fkProduct);

                    listCast = clsCast.getCastEquivalensceByCastCodsec(producto.fkCast);

                    if (listCast.Count > 0)
                    {
                        for (int i = 0; i < listCast.Count; i++)
                        {
                            cmbCoilEquivalence.Items.Add(listCast[i].code);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No existen equivalencias para la Pelicula seleccionada. Por favor creelas o solicite su creación para poder realizar esta operacion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una pelicula de la cual va a realizar el re-etiquetado equivalente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                              
            }
        }
        #endregion

        #region Procesado de Bobina
        private void btnProcesarBobina_Click(object sender, EventArgs e)
        {
            string newCode = "";
            bool bobinasave = false;
            bool movsave = false;

            clsRelabelEquivalencesMov movRelab = new clsRelabelEquivalencesMov();
            bobina = clsCoil.getDetailByCode(txtCoilCode.Text);

            int posX = producto.code.IndexOf('x');
            producto.code = producto.code.Remove(0, posX);
            newCode = cmbCoilEquivalence.Text + producto.code;

            clsProduct productoNew = new clsProduct(newCode);

            if (productoNew.codsec != 0)
            {
                bobina.fkProduct = productoNew.codsec;

                movRelab.type = "Re-etiquetado de bobina";
                movRelab.code = bobina.code;
                movRelab.fkLastProduct = producto.codsec;
                movRelab.fkNewProduct = productoNew.codsec;
                movRelab.fkPallet = 0;
                movRelab.fkCoil = bobina.codsec;
                movRelab.date = DateTime.Now;

                bobinasave = bobina.save();
                movsave = movRelab.save();

                if ((bobinasave = true) && (movsave == true) && (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032))
                {
                    clsPrintLabels.printCoilLabelPL(bobina.codsec, bobina.isExternalCoil);
                    MessageBox.Show("Datos procesados con exito", "Exito", MessageBoxButtons.OK);
                }
                else
                {
                    clsPrintLabels.printCoilLabel(bobina.codsec, bobina.isExternalCoil);
                    MessageBox.Show("Datos procesados con exito", "Exito", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No existe el producto equivalente con dichos anchos, por favor créelo y vuelva a intentarlo", "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        #endregion

    }
}
