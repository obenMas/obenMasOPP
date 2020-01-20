using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmBoppFilmDetail : Form
    {
        clsBopp objBoppFilm = new clsBopp();

        public frmBoppFilmDetail()
        {
            InitializeComponent();
        }
        public frmBoppFilmDetail(int codsec)
        {
            objBoppFilm.load(codsec);
            InitializeComponent();
            
            lblName.Text = objBoppFilm.name;
            lblFamilyCode.Text = objBoppFilm.Family.abbreviation;
            lblFamilyName.Text = objBoppFilm.Family.name;
            lblSubFamilyCode.Text = objBoppFilm.SubFamily.abbreviation;
            lblSubFamilyName.Text = objBoppFilm.SubFamily.name;
            lblInnerSealCode.Text = objBoppFilm.InnerSeal.abbreviation;
            lblInnerSealName.Text = objBoppFilm.InnerSeal.name;
            lblOuterSealCode.Text = objBoppFilm.OuterSeal.abbreviation;
            lblOuterSealName.Text = objBoppFilm.OuterSeal.name;
            lblCentralAdditivationCode.Text = objBoppFilm.CentralAdditivation.abbreviation;
            lblCentralAdditivationName.Text = objBoppFilm.CentralAdditivation.name;            
            lblSurfaceAdditivationCode.Text = objBoppFilm.SurfaceAdditivation.abbreviation;
            lblSurfaceAdditivationName.Text = objBoppFilm.SurfaceAdditivation.name;
            lblThicknessCode.Text = objBoppFilm.Thickness.value.ToString();
            lblThiknessName.Text = objBoppFilm.Thickness.value.ToString();
            lblTreatmentCode.Text = objBoppFilm.Treatment.abbreviation;
            lblTreatmentName.Text = objBoppFilm.Treatment.name;
            chkIsBaseFilm.Checked = objBoppFilm.isBaseFilm;
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            frmBoppFilmForm winBoppFilmForm = new frmBoppFilmForm(objBoppFilm.codsec);
            winBoppFilmForm.MdiParent = this.MdiParent;
            winBoppFilmForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBoppFilmDetail_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}