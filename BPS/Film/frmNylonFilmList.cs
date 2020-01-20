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
    public partial class frmNylonFilmList : Form
    {
        public frmNylonFilmList()
        {
            InitializeComponent();
            
        }

        private void PopulateNylonList()
        {
            List<clsCast> lstCast = new List<clsCast>();
            lstCast = clsCast.getSimplifiedListNylon();
            dgvCast.Rows.Clear();
            for (int i = 0; i < lstCast.Count; i++)
            {
                dgvCast.Rows.Add();
                dgvCast.Rows[i].Cells["clmCodsec"].Value = lstCast[i].codsec.ToString();
                dgvCast.Rows[i].Cells["clmCode"].Value = lstCast[i].code;
                dgvCast.Rows[i].Cells["clmName"].Value = lstCast[i].name;
                dgvCast.Rows[i].Cells["clmProcess"].Value = lstCast[i].ProcessName;
                dgvCast.Rows[i].Cells["clmSubProcess"].Value = lstCast[i].SubProcessName;
                dgvCast.Rows[i].Cells["clmCentralStructure"].Value = lstCast[i].CentralStructureName;
                dgvCast.Rows[i].Cells["clmSurfaceStructure"].Value = lstCast[i].SurfaceStructureName;
                dgvCast.Rows[i].Cells["clmCentralAdditivation"].Value = lstCast[i].CentralAdditivationName;
                dgvCast.Rows[i].Cells["clmSurfaceAdditivation"].Value = lstCast[i].SurfaceAdditivationName;
                dgvCast.Rows[i].Cells["clmThickness"].Value = lstCast[i].ThicknessValue;
                dgvCast.Rows[i].Cells["clmTreatment"].Value = lstCast[i].TreatmentName;
            }
        }

        

        private void frmNylonFilmList_Load(object sender, EventArgs e)
        {
            PopulateNylonList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNylonFilmForm winCastFilmForm = new frmNylonFilmForm();
            winCastFilmForm.MdiParent = this.MdiParent;
            winCastFilmForm.Show();
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            //frmCastFilmDetail winCastFilmDetail = new frmCastFilmDetail(Convert.ToInt32(dgvCast.SelectedRows[0].Cells["clmCodsec"].Value.ToString()));
            //winCastFilmDetail.MdiParent = this.MdiParent;
            //winCastFilmDetail.Show();
        }

        private void dgvCast_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //frmCastFilmDetail winCastFilmDetail = new frmCastFilmDetail(Convert.ToInt32(dgvCast.SelectedRows[0].Cells["clmCodsec"].Value.ToString()));
            //winCastFilmDetail.MdiParent = this.MdiParent;
            //winCastFilmDetail.Show();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            //if (dgvCast.SelectedRows.Count > 0)
            //{
            //    frmCastFilmForm winCastFilmForm = new frmCastFilmForm(Convert.ToInt32(dgvCast.SelectedRows[0].Cells["clmCodsec"].Value));
            //    winCastFilmForm.MdiParent = this.MdiParent;
            //    winCastFilmForm.Show();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Debe elegir una película para poder editarla.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drslt = MessageBox.Show("Esta seguro que desea borrar la película seleccionada?.", "Borrar película Cast?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

            switch (drslt)
            {
                case DialogResult.Yes:
                    MessageBox.Show("delete");
                    break;
                case DialogResult.No:
                    break;
            } 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateNylonList();
        }
    }
}