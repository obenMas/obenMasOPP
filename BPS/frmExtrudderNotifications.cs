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
    public partial class frmExtrudderNotifications : Form
    {
        clsScrap scrap = new clsScrap();

        public frmExtrudderNotifications()
        {
            InitializeComponent();
        }

        private void frmExtrudderNotifications_Load(object sender, EventArgs e)
        {

            List<clsScrap> scrapList = new List<clsScrap>();
            scrapList = clsScrap.getList();

            for (int i = 0; i < scrapList.Count; i++)
            {
                cmbTipo.Items.Add(scrapList[i].name);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsScrapByExtruderCellar scrapExtruder = new clsScrapByExtruderCellar();
            clsScrapMovements scrapMovements = new clsScrapMovements();
           

            if ((cmbTipo != null) && (txtPeso.Text != string.Empty))
            {

                scrap = new clsScrap(cmbTipo.Text); //Instancio de esta manera para sacar el fkScrap.

                //Aca guardo todo lo de movimientoss
                
                scrapMovements.type = "Merma Extrusión";
                scrapMovements.fkScrap = scrap.codsec;
                scrapMovements.date = DateTime.Now;
                scrapMovements.fkUser = clsGlobal.LoggedUser.codsec;
                scrapMovements.netWeigth = Convert.ToDouble(txtPeso.Text);

                if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030)
                {
                    scrapMovements.fkOriginalCellar = 4022;
                    scrapMovements.fkDestinationCellar = 4022;
                    scrapExtruder.fkCoilCellar = 4022;
                }
                else
                {
                    scrapMovements.fkOriginalCellar = 4023;
                    scrapMovements.fkDestinationCellar = 4023;
                    scrapExtruder.fkCoilCellar = 4023;
                }
                //Aca guardo todo lo del extruderCellar.
                scrapExtruder.fkScrap = scrap.codsec;
                scrapExtruder.acuWeigth(Convert.ToDouble(txtPeso.Text));


                bool resultMov = scrapMovements.save();
               
                if (resultMov == true)
                {
                    cmbTipo.ResetText();
                    txtPeso.Text = string.Empty;
                    cmbTipo.SelectedIndex = -1;
                    MessageBox.Show("Los datos se guardaron correctamente","Confirmacion",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Se Produjo algun error, los datos no se guardaron correctamente. Por favor vuelva a intentarlo", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Faltan campos que completar, Por favor completelos.", "¡Error!", MessageBoxButtons.OK);
            }
        }

        private void cmbTipo_KeyUp(object sender, KeyEventArgs e)
        {
            cmbTipo.ResetText();
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
