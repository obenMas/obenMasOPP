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
    public partial class frmDensityByFilm : Form
    {
        public frmDensityByFilm()
        {
            InitializeComponent();
        }

        private void txtFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopulateFilm(txtFilm.Text);
            }
        }

        private void PopulateFilm(string film)
        {
            List<clsBopp> lstBopp = new List<clsBopp>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            dgvFilm.Rows.Clear();

            if (txtFilm.Text.Length > 0 && txtFilm.Text != string.Empty)
            {
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "bopp_code";
                lstFilter[lstFilter.Count - 1].operation = "contains";
                lstFilter[lstFilter.Count - 1].value = film;
                lstFilter[lstFilter.Count - 1].dataType = "varchar";
            }

            lstBopp = clsBopp.getListByFilter(lstFilter);

            for (int i = 0; i < lstBopp.Count; i++)
            {
                dgvFilm.Rows.Add();
                dgvFilm.Rows[i].Cells[clmcodsec.Index].Value = lstBopp[i].codsec.ToString();
                dgvFilm.Rows[i].Cells[clmdescription.Index].Value = lstBopp[i].name.ToString();
                dgvFilm.Rows[i].Cells[clmfilm.Index].Value = lstBopp[i].code.ToString();
                dgvFilm.Rows[i].Cells[clmdensity.Index].Value = lstBopp[i].density.ToString();
                dgvFilm.Rows[i].Cells[clmview.Index].Value = global::BPS.Properties.Resources.cross;
            }

            if (lstBopp.Count > 0)
            {
                lblDensity.Visible = true;
                txtDensity.Visible = true;
            }
            else
            {
                lblDensity.Visible = false;
                txtDensity.Visible = false;
            }
                
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flgValidate = true;
            if (txtDensity.Text.Length > 0 || txtDensity.Text != string.Empty)
            {
                for (int i = 0; i < dgvFilm.Rows.Count; i++)
                {
                    clsBopp ObjBopp = new clsBopp(Convert.ToInt32(dgvFilm.Rows[i].Cells[clmcodsec.Index].Value));
                    ObjBopp.density = Convert.ToDouble(txtDensity.Text);
                    if (!ObjBopp.save())
                    {
                        flgValidate = false;
                        break;
                    }
                }
                if (flgValidate)
                {
                    MessageBox.Show("Datos Guardados Correctamente!...", "Densidad por Películas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateFilm(txtFilm.Text);
                }
                else
                    MessageBox.Show("Ha sucedido un error por favor comunicarse con el administrador del sistema", "Densidad por Películas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Debe ingresar un valor para la densidad", "Densidad por Películas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmview.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar la película seleccionada", "Densidad por Películas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    dgvFilm.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
