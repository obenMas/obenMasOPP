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
    public partial class frmShippingBuilding : Form
    {
        clsShippingBuilding ObjShippingBuilding = new clsShippingBuilding();

        public frmShippingBuilding()
        {
            InitializeComponent();
        }

        private void frmShippingBuilding_Load(object sender, EventArgs e)
        {
            FillDataShippingBuilding();
            FillDataCountry();
        }

        private void FillDataCountry()
        {
            List<clsCountry> lstCountry = new List<clsCountry>();
            lstCountry = clsCountry.getList();
            cmbCountry.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
                cmbCountry.Items.Add(lstCountry[i]);
        }

        private void FillDataShippingBuilding()
        {
            List<clsShippingBuilding> lstshippbuilding = new List<clsShippingBuilding>();
            lstshippbuilding = clsShippingBuilding.getList();
            dgvShippingBuilding.Rows.Clear();
            if (lstshippbuilding.Count > 0)
            {
                for (int i = 0; i < lstshippbuilding.Count; i++)
                {
                    dgvShippingBuilding.Rows.Add();
                    dgvShippingBuilding.Rows[i].Cells[clmCodsec.Index].Value = lstshippbuilding[i].codsec.ToString();
                    dgvShippingBuilding.Rows[i].Cells[clmname.Index].Value = lstshippbuilding[i].name.ToString();
                    dgvShippingBuilding.Rows[i].Cells[clmCountry.Index].Value = lstshippbuilding[i].country.ToString();
                    dgvShippingBuilding.Rows[i].Cells[clmEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvShippingBuilding.Rows[i].Cells[clmDelete.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void cmbCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                FillDataCountry();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                ObjShippingBuilding.name = txtname.Text;
                ObjShippingBuilding.description = txtname.Text;
                ObjShippingBuilding.fkcountry = (((clsCountry)cmbCountry.SelectedItem).codsec);
                if (ObjShippingBuilding.save())
                {
                    MessageBox.Show("Naviera guardada correctamente!", "Naviera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea crear una nueva naviera?", "Nueva naviera", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsGlobal.ClearForm(this);
                        ObjShippingBuilding = new clsShippingBuilding();
                        txtname.Focus();
                    }
                    FillDataShippingBuilding();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Naviera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref cmbCountry, ref lblCountry, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtname, ref lblnameLabel, "notEmpty")) isValid = false;
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está realmente seguro que desea cancelar el ingreso de la naviera?", "Naviera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGlobal.ClearForm(this);
                txtname.Focus();
                FillDataShippingBuilding();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvShippingBuilding_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar la naviera?", "Naviera", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsShippingBuilding.delete(Convert.ToInt32(dgvShippingBuilding.SelectedRows[0].Cells[clmCodsec.Index].Value)))
                    {
                        MessageBox.Show("Naviera eliminada correctamente!", "Naviera", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataShippingBuilding();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Naviera", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == clmEdit.Index)
            {
                ObjShippingBuilding = new clsShippingBuilding(Convert.ToInt32(dgvShippingBuilding.SelectedRows[0].Cells[clmCodsec.Index].Value));
                txtname.Text = ObjShippingBuilding.name;
                for (int i = 0; i < cmbCountry.Items.Count; i++)
                {
                    if (((clsCountry)cmbCountry.Items[i]).codsec == ObjShippingBuilding.fkcountry)
                        cmbCountry.SelectedIndex = i;
                }
            }
        }
    }
}
