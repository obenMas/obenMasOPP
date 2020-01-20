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
    public partial class frmBoppFilmList : Form
    {
        public frmBoppFilmList()
        {
            InitializeComponent();
            //dgvBopp.he.Font = new Font("Microsoft Sans Serif", float.Parse("6.75"));
        }

        private void frmBoppFilmList_Load(object sender, EventArgs e)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            lstBopp = clsBopp.getSimplifiedList();
            for (int i = 0; i < lstBopp.Count; i++)
            {
                dgvBopp.Rows.Add();
                dgvBopp.Rows[i].Cells["clmCodsec"].Value = lstBopp[i].codsec.ToString();
                dgvBopp.Rows[i].Cells["clmCode"].Value = lstBopp[i].code;
                dgvBopp.Rows[i].Cells["clmName"].Value = lstBopp[i].name;
                dgvBopp.Rows[i].Cells["clmFamily"].Value = lstBopp[i].familyName;
                dgvBopp.Rows[i].Cells["clmSubFamily"].Value = lstBopp[i].subFamilyName;
                dgvBopp.Rows[i].Cells["clmInnerSeal"].Value = lstBopp[i].innerSealName;
                dgvBopp.Rows[i].Cells["clmOuterSeal"].Value = lstBopp[i].outerSealName;
                dgvBopp.Rows[i].Cells["clmCentralAdditivation"].Value = lstBopp[i].centralAdditivationName;
                dgvBopp.Rows[i].Cells["clmSurfaceAdditivation"].Value = lstBopp[i].surfaceAdditivationName;
                dgvBopp.Rows[i].Cells["clmThickness"].Value = lstBopp[i].thicknessValue;
                dgvBopp.Rows[i].Cells["clmTreatment"].Value = lstBopp[i].treatmentName;
            }
        }

        private void dgvBopp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmBoppFilmDetail winBoppFilmDetail = new frmBoppFilmDetail(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells["clmCodsec"].Value.ToString()));
            winBoppFilmDetail.MdiParent = this.MdiParent;
            winBoppFilmDetail.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmBoppFilmForm winBoppFilmForm = new frmBoppFilmForm();
            winBoppFilmForm.MdiParent = this.MdiParent;
            winBoppFilmForm.Show();
            this.Close();
        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvBopp.SelectedRows.Count > 0)
            {
                frmBoppFilmForm winBoppFilmForm = new frmBoppFilmForm(Convert.ToInt32 (dgvBopp.SelectedRows[0].Cells["clmCodsec"].Value));
                winBoppFilmForm.MdiParent = this.MdiParent;
                winBoppFilmForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Debe elegir una película para poder editarla.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult drslt = MessageBox.Show("Esta seguro que desea borrar la película seleccionada?.", "Borrar película Bopp?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true); 
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

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmBoppFilmDetail winBoppFilmDetail = new frmBoppFilmDetail(Convert.ToInt32(dgvBopp.SelectedRows[0].Cells["clmCodsec"].Value.ToString()));
            winBoppFilmDetail.MdiParent = this.MdiParent;
            winBoppFilmDetail.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            lstBopp = clsBopp.getSimplifiedList();
            dgvBopp.Rows.Clear();

            for (int i = 0; i < lstBopp.Count; i++)
            {
                dgvBopp.Rows.Add();
                dgvBopp.Rows[i].Cells["clmCodsec"].Value = lstBopp[i].codsec.ToString();
                dgvBopp.Rows[i].Cells["clmCode"].Value = lstBopp[i].code;
                dgvBopp.Rows[i].Cells["clmName"].Value = lstBopp[i].name;
                dgvBopp.Rows[i].Cells["clmFamily"].Value = lstBopp[i].familyName;
                dgvBopp.Rows[i].Cells["clmSubFamily"].Value = lstBopp[i].subFamilyName;
                dgvBopp.Rows[i].Cells["clmInnerSeal"].Value = lstBopp[i].innerSealName;
                dgvBopp.Rows[i].Cells["clmOuterSeal"].Value = lstBopp[i].outerSealName;
                dgvBopp.Rows[i].Cells["clmCentralAdditivation"].Value = lstBopp[i].centralAdditivationName;
                dgvBopp.Rows[i].Cells["clmSurfaceAdditivation"].Value = lstBopp[i].surfaceAdditivationName;
                dgvBopp.Rows[i].Cells["clmThickness"].Value = lstBopp[i].thicknessValue;
                dgvBopp.Rows[i].Cells["clmTreatment"].Value = lstBopp[i].treatmentName;
            }
        }
    }
}