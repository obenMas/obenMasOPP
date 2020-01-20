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
    public partial class frmCoatingFilmList : Form
    {
        public frmCoatingFilmList()
        {
            InitializeComponent();
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmCoatingFilmList_Load(object sender, EventArgs e)
        {
            List<clsCoating> lstCoating = new List<clsCoating>();
            lstCoating = clsCoating.getSimplifiedList();
            for (int i = 0; i < lstCoating.Count; i++)
            {
                dgvCoating.Rows.Add();
                dgvCoating.Rows[i].Cells["clmCodsec"].Value = lstCoating[i].codsec.ToString();
                dgvCoating.Rows[i].Cells["clmCode"].Value = lstCoating[i].code;
                dgvCoating.Rows[i].Cells["clmName"].Value = lstCoating[i].name;
                dgvCoating.Rows[i].Cells["clmProcess"].Value = lstCoating[i].ProcessName;
                dgvCoating.Rows[i].Cells["clmSubProcess"].Value = lstCoating[i].SubProcessName;
                dgvCoating.Rows[i].Cells["clmTerminationStructure"].Value = lstCoating[i].TerminationStructureName;
                dgvCoating.Rows[i].Cells["clmCoatingStructure"].Value = lstCoating[i].CoatingStructureName;
                dgvCoating.Rows[i].Cells["clmSubstrateThickness"].Value = lstCoating[i].SubstrateThicknessValue;
                dgvCoating.Rows[i].Cells["clmCoatingThickness"].Value = lstCoating[i].CoatThicknessValue;
                dgvCoating.Rows[i].Cells["clmTreatment"].Value = lstCoating[i].TreatmentName;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            List<clsCoating> lstCoating = new List<clsCoating>();
            lstCoating = clsCoating.getSimplifiedList();
            dgvCoating.Rows.Clear();

            for (int i = 0; i < lstCoating.Count; i++)
            {
                dgvCoating.Rows.Add();
                dgvCoating.Rows[i].Cells["clmCodsec"].Value = lstCoating[i].codsec.ToString();
                dgvCoating.Rows[i].Cells["clmCode"].Value = lstCoating[i].code;
                dgvCoating.Rows[i].Cells["clmName"].Value = lstCoating[i].name;
                dgvCoating.Rows[i].Cells["clmProcess"].Value = lstCoating[i].ProcessName;
                dgvCoating.Rows[i].Cells["clmSubProcess"].Value = lstCoating[i].SubProcessName;
                dgvCoating.Rows[i].Cells["clmTerminationStructure"].Value = lstCoating[i].TerminationStructureName;
                dgvCoating.Rows[i].Cells["clmCoatingStructure"].Value = lstCoating[i].CoatingStructureName;
                dgvCoating.Rows[i].Cells["clmSubstrateThickness"].Value = lstCoating[i].SubstrateThicknessValue;
                dgvCoating.Rows[i].Cells["clmCoatingThickness"].Value = lstCoating[i].CoatThicknessValue;
                dgvCoating.Rows[i].Cells["clmTreatment"].Value = lstCoating[i].TreatmentName;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCoatingFilmForm winCoatingFilmForm = new frmCoatingFilmForm();
            winCoatingFilmForm.MdiParent = this.MdiParent;
            winCoatingFilmForm.Show();
            this.Close();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            if (dgvCoating.SelectedRows.Count > 0)
            {
                frmCoatingFilmForm winCoatingFilmForm = new frmCoatingFilmForm(Convert.ToInt32(dgvCoating.SelectedRows[0].Cells["clmCodsec"].Value));
                winCoatingFilmForm.MdiParent = this.MdiParent;
                winCoatingFilmForm.Show();
                this.Close();
            }
            else
                MessageBox.Show("Debe elegir una película para poder editarla.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea cancelar Película?..", "Películas Coating", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
 
            }
        }
    }
}