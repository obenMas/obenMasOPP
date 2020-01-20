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
    public partial class frmFormulationsCastList : Form
    {
        public frmFormulationsCastList()
        {
            InitializeComponent();
        }

        private void btnFormulationAdd_Click(object sender, EventArgs e)
        {
            frmFormulationsCastForm winFormulationsCastForm = new frmFormulationsCastForm();
            winFormulationsCastForm.MdiParent = this.MdiParent;
            winFormulationsCastForm.Show();
            this.Close();
        }

        private void frmFormulationsList_Load(object sender, EventArgs e)
        {
            List<clsFormulation> lstFormulation = new List<clsFormulation>();
            lstFormulation = clsFormulation.getListCast();
            dgvFormulationsList.Rows.Clear();

            for (int i = 0; i < lstFormulation.Count; i++)
            {
                dgvFormulationsList.Rows.Add();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsCodsec"].Value = lstFormulation[i].codsec.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsName"].Value = lstFormulation[i].name.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsDescription"].Value = lstFormulation[i].description.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsFilm"].Value = lstFormulation[i].CastCode.ToString();
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {

            frmCastFormulationDetails winFormulationsCastDetail = new frmCastFormulationDetails(Convert.ToInt32(dgvFormulationsList.SelectedRows[0].Cells[clmFormulationsCodsec.Index].Value));
            winFormulationsCastDetail.MdiParent = this.MdiParent;
            winFormulationsCastDetail.Show();
            this.Close();
        }

        private void dgvFormulationsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmCastFormulationDetails winFormulationsCastDetail = new frmCastFormulationDetails(Convert.ToInt32(dgvFormulationsList.SelectedRows[0].Cells[clmFormulationsCodsec.Index].Value));
            winFormulationsCastDetail.MdiParent = this.MdiParent;
            winFormulationsCastDetail.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}