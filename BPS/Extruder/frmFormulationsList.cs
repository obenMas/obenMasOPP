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
    public partial class frmFormulationsList : Form
    {
        public frmFormulationsList()
        {
            InitializeComponent();
        }

        private void btnFormulationAdd_Click(object sender, EventArgs e)
        {
            frmFormulationsBoppForm winFormulationsCastForm = new frmFormulationsBoppForm();
            winFormulationsCastForm.MdiParent = this.MdiParent;
            winFormulationsCastForm.Show();
            this.Close();
        }

        private void frmFormulationsList_Load(object sender, EventArgs e)
        {
            List<clsFormulation> lstFormulation = new List<clsFormulation>();
            lstFormulation = clsFormulation.getListBopp();
            dgvFormulationsList.Rows.Clear();

            for (int i = 0; i < lstFormulation.Count; i++)
            {
                dgvFormulationsList.Rows.Add();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsCodsec"].Value = lstFormulation[i].codsec.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsName"].Value = lstFormulation[i].name.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsDescription"].Value = lstFormulation[i].description.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsFilm"].Value = lstFormulation[i].BoppCode.ToString();
                dgvFormulationsList.Rows[i].Cells[clmedit.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frmBoppFormulationDetails winFormulationsCastDetail = new frmBoppFormulationDetails(Convert.ToInt32(dgvFormulationsList.SelectedRows[0].Cells[clmFormulationsCodsec.Index].Value));
            winFormulationsCastDetail.MdiParent = this.MdiParent;
            winFormulationsCastDetail.Show();
            this.Close();
        }

        private void dgvFormulationsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frmBoppFormulationDetails winFormulationsCastDetail = new frmBoppFormulationDetails(Convert.ToInt32(dgvFormulationsList.SelectedRows[0].Cells[clmFormulationsCodsec.Index].Value));
            winFormulationsCastDetail.MdiParent = this.MdiParent;
            winFormulationsCastDetail.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvFormulationsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmedit.Index)
            {
                if (MessageBox.Show("Está seguro que desea eliminar la fórmula seleccionada recuerde que está formula se eliminará del sistema?", "Formulaciones", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign,false) == DialogResult.Yes)
                {
                    if (clsFormulation.delete(Convert.ToInt32(dgvFormulationsList.Rows[e.RowIndex].Cells[clmFormulationsCodsec.Index].Value)))
                    {
                        MessageBox.Show("Fórmula eliminada correctamente!!", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateFormulation();
                    }
                    else
                    {
                        MessageBox.Show("Error al procesar borrado de fórmula", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateFormulation();
                    }
                }
            }
        }

        private void PopulateFormulation()
        {
            List<clsFormulation> lstFormulation = new List<clsFormulation>();
            lstFormulation = clsFormulation.getListBopp();
            dgvFormulationsList.Rows.Clear();

            for (int i = 0; i < lstFormulation.Count; i++)
            {
                dgvFormulationsList.Rows.Add();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsCodsec"].Value = lstFormulation[i].codsec.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsName"].Value = lstFormulation[i].name.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsDescription"].Value = lstFormulation[i].description.ToString();
                dgvFormulationsList.Rows[i].Cells["clmFormulationsFilm"].Value = lstFormulation[i].BoppCode.ToString();
                dgvFormulationsList.Rows[i].Cells[clmedit.Index].Value = global::BPS.Properties.Resources.cross;
            }
        }
    }
}