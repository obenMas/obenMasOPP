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
    public partial class frmVapor : Form
    {
        clsVapor ObjVapor = new clsVapor();
        public frmVapor()
        {
            InitializeComponent();
        }

        private void frmVapor_Load(object sender, EventArgs e)
        {
            FillDataVapor();
            FillDataShippingBuilding();
        }

        private void FillDataShippingBuilding()
        {
            List<clsShippingBuilding> lstshippingbuiling = new List<clsShippingBuilding>();
            lstshippingbuiling = clsShippingBuilding.getList();
            cmbShippingName.Items.Clear();
            for (int i = 0; i < lstshippingbuiling.Count; i++)
                cmbShippingName.Items.Add(lstshippingbuiling[i]);
        }

        private void FillDataVapor()
        {
            List<clsVapor> lstVapor = new List<clsVapor>();
            lstVapor = clsVapor.getList();
            dgvVapor.Rows.Clear();
            if (lstVapor.Count > 0)
            {
                for (int i = 0; i < lstVapor.Count; i++)
                {
                    dgvVapor.Rows.Add();
                    dgvVapor.Rows[i].Cells[clmCodsec.Index].Value = lstVapor[i].codsec.ToString();
                    dgvVapor.Rows[i].Cells[clmShippingBuilding.Index].Value = lstVapor[i].shippingbuilding.ToString();
                    dgvVapor.Rows[i].Cells[clmestimateddate.Index].Value = lstVapor[i].estimatedate.ToString("dd/MM/yyyy");
                    dgvVapor.Rows[i].Cells[clmCutoff.Index].Value = lstVapor[i].cuttoff.ToString("dd/MM/yyyy");
                    dgvVapor.Rows[i].Cells[clmEdit.Index].Value = global::BPS.Properties.Resources.pencil;
                    dgvVapor.Rows[i].Cells[clmDelete.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void cmbShippingName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                FillDataShippingBuilding();
        }

        private void dgvVapor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index)
            {
                if (MessageBox.Show("Está realmente seguro que desea eliminar vapor?", "Vapor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsVapor.delete(Convert.ToInt32(dgvVapor.SelectedRows[0].Cells[clmCodsec.Index].Value)))
                    {
                        MessageBox.Show("Vapor eliminado correctamente!", "Vapor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillDataVapor();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Vapor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (e.ColumnIndex == clmEdit.Index)
            {
                ObjVapor = new clsVapor(Convert.ToInt32(dgvVapor.SelectedRows[0].Cells[clmCodsec.Index].Value));
                dtpEstimateDate.Value = Convert.ToDateTime(ObjVapor.estimatedate);
                dtpCuttoff.Value = Convert.ToDateTime(ObjVapor.cuttoff);
                //lblCutOffDate.Text = ObjVapor.cuttoff.ToLongDateString();
                for (int i = 0; i < cmbShippingName.Items.Count; i++)
                {
                    if (((clsShippingBuilding)cmbShippingName.Items[i]).codsec == ObjVapor.fkshippingbuilding)
                        cmbShippingName.SelectedIndex = i;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                ObjVapor.estimatedate = dtpEstimateDate.Value;
                ObjVapor.cuttoff = dtpCuttoff.Value;
                ObjVapor.fkshippingbuilding = (((clsShippingBuilding)cmbShippingName.SelectedItem).codsec);
                if (ObjVapor.save())
                {
                    MessageBox.Show("Vapor guardado correctamente!", "Vapor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (MessageBox.Show("Desea crear un nuevo vapor?", "Nuevo vapor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsGlobal.ClearForm(this);
                        ObjVapor = new clsVapor();
                        dtpEstimateDate.Focus();
                    }
                    FillDataVapor();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Vapor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool validateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref cmbShippingName, ref lblShippingName, "selected")) isValid = false;
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está realmente seguro que desea cancelar el ingreso de vapores?", "Vapores", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsGlobal.ClearForm(this);
                cmbShippingName.Focus();
                FillDataVapor();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpEstimateDate_ValueChanged(object sender, EventArgs e)
        {
            //lblCutOffDate.Text = dtpEstimateDate.Value.AddDays(3.0).ToLongDateString();
        }
    }
}
