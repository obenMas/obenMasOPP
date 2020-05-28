using BPS.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS
{
    public partial class frmNewExtrusionPlan : Form
    {
        private clsNewExtrusionPlan plan = new clsNewExtrusionPlan();
        private int machine = 0;
        private string stMachine = "";
        private bool changeAllowed = false;
        public frmNewExtrusionPlan(int mach, string stMach)
        {
            InitializeComponent();
            fillMachineCombo();
            machine = mach;
            stMachine = stMach;
            for(int i=0;i<cmbMachine.Items.Count;i++)
            {
                if(cmbMachine.Items[i].ToString()==stMach)
                {
                    cmbMachine.SelectedIndex = i;
                }
            }
            fillPlanDetails(clsNewExtrusionPlan.getActivePlan(mach));
            changeAllowed = true;
            fillOrdersToAdd();
        }

        private void fillMachineCombo()
        {
            List<clsMachine> lista = clsMachine.getExtruderMachineList();

            for(int i=0; i<lista.Count;i++)
            {
                cmbMachine.Items.Add(lista[i].Extruder.name);
            }
        }

        public void fillPlanDetails(clsNewExtrusionPlan planext)
        {
            plan = planext;
            PlanNumber.Text = planext.codsec.ToString();
            chkActive.Checked = planext.active;
            dtpInitTime.Value = planext.initDate;
            txtObservations.Text = planext.observations;
            numVelocity.Value = planext.velocity;
            numEfficiency.Value = Convert.ToDecimal(planext.efficiency);
            numAvailability.Value = Convert.ToDecimal(planext.availability);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewExtrusionPlanCreation nplanform = new frmNewExtrusionPlanCreation(this);
            nplanform.ShowDialog();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            clsNewExtrusionPlan extplan = new clsNewExtrusionPlan();
            bool continuar = true;
            int indice = 0;
            if(Convert.ToInt32(PlanNumber.Text)>0)
            {
                indice = Convert.ToInt32(PlanNumber.Text);

                while(continuar)
                {
                    indice--;
                    extplan = new clsNewExtrusionPlan(indice);
                    if (extplan.codsec != 0)
                    {
                        if (extplan.fkMachine == machine)
                        {
                            fillPlanDetails(extplan);
                            continuar = false;
                        }

                    }
                    else
                    {
                        continuar = false;
                    }
                }
                
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            clsNewExtrusionPlan extplan = new clsNewExtrusionPlan();
            bool continuar = true;
            int indice = 0;

            indice = Convert.ToInt32(PlanNumber.Text);

            while (continuar)
            {
                indice++;
                extplan = new clsNewExtrusionPlan(indice);
                if (extplan.codsec != 0)
                {
                    if(extplan.fkMachine==machine)
                    {
                        fillPlanDetails(extplan);
                        continuar = false;
                    }
                }
                else
                {
                    continuar = false;
                }
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if(changeAllowed)
            {
                if(chkActive.Checked)
                {
                    plan.setAsActive();
                }
                else
                {
                    plan.setAsNonActive();
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            plan.velocity = Convert.ToInt32(numVelocity.Value);
            plan.efficiency = Convert.ToDouble(numEfficiency.Value);
            plan.availability = Convert.ToDouble(numAvailability.Value);

            if(plan.save())
            {
                MessageBox.Show("Cambios aplicados correctamente.","Modificación de parametros",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ocurrió un error y no se pudieron aplicar los cambios", "Modificación de parametros", MessageBoxButtons.OK);
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            frmNewExtrusionOrderCreator norderform = new frmNewExtrusionOrderCreator();
            norderform.ShowDialog();
            fillOrdersToAdd();
        }

        private void fillOrdersToAdd()
        {
            dgvSinPlanificar.Rows.Clear();

            List<clsNewExtrusionOrder> lista = clsNewExtrusionOrder.getWithoutPlanningList();

            for(int i = 0;i<lista.Count;i++)
            {
                dgvSinPlanificar.Rows.Add();
                dgvSinPlanificar.Rows[dgvSinPlanificar.Rows.Count - 1].Cells[clmOrdenSP.Index].Value = lista[i].codsec;
                dgvSinPlanificar.Rows[dgvSinPlanificar.Rows.Count - 1].Cells[clmPeliculaSP.Index].Value = lista[i].fkBopp;
                dgvSinPlanificar.Rows[dgvSinPlanificar.Rows.Count - 1].Cells[clmCantidadSP.Index].Value = lista[i].quantity;
            }
        }

        private void dgvSinPlanificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmAgregar.Index)
            {
                agregar(e.RowIndex);
            }
        }

        private void agregar(int ind)
        {
            clsNewExtrusionPlanDetail detail = new clsNewExtrusionPlanDetail();

            if(dgvPlanificado.Rows.Count==0)
            {
                detail.sequential = 1;
                detail.fkNewExtrusionPlan = plan.codsec;
                detail.fkNewExtrusionOrder = Convert.ToInt32(dgvSinPlanificar.Rows[ind].Cells[clmOrdenSP.Index].Value);
                detail.hours = Convert.ToInt32(Convert.ToInt32(dgvSinPlanificar.Rows[ind].Cells[clmCantidadSP.Index].Value) / plan.velocity);
                detail.deadTime = detail.hours * Convert.ToInt32(plan.availability);
                if(detail.save())
                {
                    dgvPlanificado.Rows.Add();
                    //dgvPlanificado.Rows[dgvPlanificado.Rows.Count-1].Cells[]
                }
            }
        }
    }
}
