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
    public partial class frmCastFilmDetail : Form
    {
        clsCast objCastFilm = new clsCast();

        public frmCastFilmDetail()
        {
            InitializeComponent();
        }
        public frmCastFilmDetail(int codsec)
        {
            objCastFilm.load(codsec);
            InitializeComponent();

            lblName.Text = objCastFilm.name;
            lblProcessCode.Text = objCastFilm.Process.abbreviation;
            lblProcessName.Text = objCastFilm.Process.name;
            lblSubProcessCode.Text = objCastFilm.SubProcess.abbreviation;
            lblSubProcessName.Text = objCastFilm.SubProcess.name;
            lblCentralStructureCode.Text = objCastFilm.CentralStructure.abbreviation;
            lblCentralStructureName.Text = objCastFilm.CentralStructure.name;
            lblSurfaceStructureCode.Text = objCastFilm.SurfaceStructure.abbreviation;
            lblSurfaceStructureName.Text = objCastFilm.SurfaceStructure.name;
            lblCentralAdditivationCode.Text = objCastFilm.CentralAdditivation.abbreviation;
            lblCentralAdditivationName.Text = objCastFilm.CentralAdditivation.name;
            lblSurfaceAdditivationCode.Text = objCastFilm.SurfaceAdditivation.abbreviation;
            lblSurfaceAdditivationName.Text = objCastFilm.SurfaceAdditivation.name;
            lblThicknessCode.Text = objCastFilm.Thickness.value.ToString();
            lblThiknessName.Text = objCastFilm.Thickness.value.ToString();
            lblTreatmentCode.Text = objCastFilm.Treatment.abbreviation;
            lblTreatmentName.Text = objCastFilm.Treatment.name;
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            frmCastFilmForm winCastFilmForm = new frmCastFilmForm(objCastFilm.codsec);
            winCastFilmForm.MdiParent = this.MdiParent;
            winCastFilmForm.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}