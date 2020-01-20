using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmDeadTimeMill : Form
    {
        int editcodsec = 0;

        public frmDeadTimeMill()
        {
            InitializeComponent();
            grpbActions.Enabled = false;
        }

        private void frmDeadTimeMill_Load(object sender, EventArgs e)
        {
            PopulateDeadTime();
        }

        private void PopulateDeadTime()
        {
            try
            {
                List<clsMetalizedDeadTime> lstDeadTimeGroup = new List<clsMetalizedDeadTime>();
                lstDeadTimeGroup = clsMetalizedDeadTime.getListMill();
                dgvDeadTime.Rows.Clear();
                if (lstDeadTimeGroup.Count > 0)
                {
                    for (int i = 0; i < lstDeadTimeGroup.Count; i++)
                    {
                        dgvDeadTime.Rows.Add();
                        dgvDeadTime.Rows[i].Cells[clmdeadtimecodsec.Index].Value = lstDeadTimeGroup[i].codsec;
                        dgvDeadTime.Rows[i].Cells[clmdeadtimegroup.Index].Value = lstDeadTimeGroup[i].deadTimeGroupName;
                        dgvDeadTime.Rows[i].Cells[clmdeadtimename.Index].Value = lstDeadTimeGroup[i].deadTimeName;
                        dgvDeadTime.Rows[i].Cells[clmdeadtimeadd.Index].Value = global::BPS.Lite.Properties.Resources.add1;
                        dgvDeadTime.Rows[i].Cells[clmdeadtimeedit.Index].Value = global::BPS.Lite.Properties.Resources.clear;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tiempos Muertos Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private void dgvDeadTime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmdeadtimeadd.Index)
            {
                grpbActions.Enabled = true;
                PopulateGroupDeadTime();
                txtName.Clear();
            }
            //else if (e.ColumnIndex == clmdeadtimeedit.Index)
            //{
            //    grpbActions.Enabled = true;
            //    PopulateGroupDeadTimeByEdit(Convert.ToInt32(dgvDeadTime.Rows[e.RowIndex].Cells[clmdeadtimecodsec.Index].Value));
            //}
        }

        private void PopulateGroupDeadTimeByEdit(int codsec)
        {
            editcodsec = codsec;
            clsMetalizedDeadTime ObjDeadTime = new clsMetalizedDeadTime();
            ObjDeadTime.load(codsec);
            PopulateDeadTimeByEdit(ObjDeadTime.fkDeadTimeGroup);
            txtName.Text = ObjDeadTime.deadTimeName;
        }

        private void PopulateDeadTimeByEdit(int codsec)
        {
            PopulateGroupDeadTime();
            for (int i = 0; i < cmbTypeDeadTime.Items.Count; i++)
            {
                if (((clsMetalizaedDeadTimeGroup)cmbTypeDeadTime.Items[i]).codsec == codsec)
                {
                    cmbTypeDeadTime.SelectedIndex = i;
                    break;
                }
            }
        }

        private void PopulateGroupDeadTime()
        {
            List<clsMetalizaedDeadTimeGroup> lstDeadTime = new List<clsMetalizaedDeadTimeGroup>();
            lstDeadTime = clsMetalizaedDeadTimeGroup.getListMill();
            cmbTypeDeadTime.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbTypeDeadTime.Items.Add(lstDeadTime[i]);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateForm())
                {
                    if (editcodsec == 0)
                    {
                        clsMetalizedDeadTime ObjMetalizedDeadTime = new clsMetalizedDeadTime();
                        ObjMetalizedDeadTime.fkDeadTimeGroup = ((clsMetalizaedDeadTimeGroup)cmbTypeDeadTime.SelectedItem).codsec;
                        ObjMetalizedDeadTime.deadTimeName = txtName.Text;
                        if (ObjMetalizedDeadTime.save())
                        {
                            if (MessageBox.Show("Tiempo Muerto Guardado con Éxito...\r\nDesea Generar otro Tiempo Muerto", "Tiempos Muertos Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                cmbTypeDeadTime.Text = "";
                                cmbTypeDeadTime.SelectedIndex = -1;
                                cmbTypeDeadTime.SelectedItem = -1;
                                txtName.Clear();
                                cmbTypeDeadTime.Focus();
                                PopulateDeadTime();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada por favor intente nuevamente", "Tiempos Muertos Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbTypeDeadTime.Focus();
                        }
                    }
                    else
                    {
                        clsMetalizedDeadTime ObjMetalizedDeadTime = new clsMetalizedDeadTime(editcodsec);
                        ObjMetalizedDeadTime.fkDeadTimeGroup = ((clsMetalizaedDeadTimeGroup)cmbTypeDeadTime.SelectedItem).codsec;
                        ObjMetalizedDeadTime.deadTimeName = txtName.Text;
                        if (ObjMetalizedDeadTime.save())
                        {
                            if (MessageBox.Show("Tiempo Muerto Guardado con Éxito...\r\nDesea Generar otro Tiempo Muerto", "Tiempos Muertos Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                cmbTypeDeadTime.Text = "";
                                cmbTypeDeadTime.SelectedIndex = -1;
                                cmbTypeDeadTime.SelectedItem = -1;
                                txtName.Clear();
                                cmbTypeDeadTime.Focus();
                                PopulateDeadTime();
                                editcodsec = 0;
                            }
                        }
                        else
                        {
                            MessageBox.Show("La información no ha podido ser guardada por favor intente nuevamente", "Tiempos Muertos Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            cmbTypeDeadTime.Focus();
                        }
                    }
                }
                else
                    MessageBox.Show("Debe llenar todos los campos pintado de color ROJO", "Tiempos Muertos Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tiempos Muertos Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbTypeDeadTime, ref lblTypeDeadTime, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro que desea cancelar el tiempo muerto seleccionado?", "Tiempos Muertos Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                this.Close();
        }
    }
}
