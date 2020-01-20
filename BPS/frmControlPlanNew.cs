using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Business;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmControlPlanNew : Form
    {
        clsQualityControlsByFilm objQCBF = new clsQualityControlsByFilm();

        public frmControlPlanNew(string bopp)
        {
            InitializeComponent();
            PopulateComboControl();
            PopulateComboFilms();
            cmbFilm.SelectedItem = bopp;
            cmbFilm.Enabled = false;
        }

        public frmControlPlanNew(int Codsec ,int fkQualityCtrl,string bopp,string control,int cantval,double min,double max)
        {
            InitializeComponent();
            PopulateComboFilms();
            PopulateComboControl();
            cmbFilm.SelectedItem = bopp.ToString();
            cmbFilm.Enabled = false;
            cmbControl.SelectedItem = control.ToString();
            txtQuantity.Text = cantval.ToString();
            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();
            objQCBF.codsec = Codsec;
        }

        public void PopulateComboFilms()
        {
            List<clsBopp> lstFilms = new List<clsBopp>();
            lstFilms = clsBopp.getListShort();

            for (int i = 0; i < lstFilms.Count; i++)
            {
                cmbFilm.Items.Add(lstFilms[i].code);
            }
        }

        public void PopulateComboControl()
        {
            List<clsQualityControls> lstControls = new List<clsQualityControls>();
            
            lstControls = clsQualityControls.getList();

            for (int i = 0; i < lstControls.Count; i++)
            {
                cmbControl.Items.Add(lstControls[i].name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            objQCBF.fkBopp = clsBopp.getFilmByCode(cmbFilm.SelectedItem.ToString());
            objQCBF.fkqualitycontrol = clsQualityControls.codsecByQualityControlName(cmbControl.SelectedItem.ToString());
            objQCBF.valuesquantity = Convert.ToInt32(txtQuantity.Text);
            objQCBF.minimum = Convert.ToDouble(txtMin.Text);
            objQCBF.maximum = Convert.ToDouble(txtMax.Text);

            if (objQCBF.save())
            {
                MessageBox.Show("Nuevo plan de Control guardado exitosamente", "Nuevo Plan de Control", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar", "Nuevo Plan de Control", MessageBoxButtons.OK);
            }

            cmbControl.SelectedIndex = -1;
            txtMin.ResetText();
            txtMax.ResetText();
            txtQuantity.ResetText();
        }
    }
}
