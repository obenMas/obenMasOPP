using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmNewExtrusionOrderCreator : Form
    {
        private clsNewExtrusionOrder orden = new clsNewExtrusionOrder();

        public frmNewExtrusionOrderCreator()
        {
            InitializeComponent();
            fillFilmCombo();
        }

        private void fillFilmCombo()
        {
            List<clsBopp> lista = clsBopp.getListShort();

            for(int i=0;i<lista.Count;i++)
            {
                cmbFilm.Items.Add(lista[i].code);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(cmbFilm.SelectedIndex!=-1)
            {
                orden.fkBopp = clsBopp.getFilmByCode(cmbFilm.Items[cmbFilm.SelectedIndex].ToString());
                orden.quantity = Convert.ToInt32(numQuantity.Value);
                if(txtObservations.Text!=null)
                {
                    orden.observations = txtObservations.Text;
                }
                orden.date = DateTime.Now;
                orden.fkUser = clsGlobal.LoggedUser.codsec;
                orden.fkStatus = 3074;

                if(orden.save())
                {
                    MessageBox.Show("Orden creada correctamente","Creación de ordenes de extrusión", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }
    }
}
