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
            fillPlanified();
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
                if(reordenar())
                {
                    MessageBox.Show("Cambios aplicados correctamente.", "Modificación de parametros", MessageBoxButtons.OK);
                }
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
                dgvSinPlanificar.Rows[dgvSinPlanificar.Rows.Count - 1].Cells[clmPeliculaSP.Index].Value =  new clsBopp(lista[i].fkBopp).code;
                dgvSinPlanificar.Rows[dgvSinPlanificar.Rows.Count - 1].Cells[clmCantidadSP.Index].Value = lista[i].quantity;
                dgvSinPlanificar.Rows[dgvSinPlanificar.Rows.Count - 1].Cells[clmObservationsSP.Index].Value = lista[i].observations;
            }
        }

        private void dgvSinPlanificar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmAgregar.Index)
            {
                agregar(e.RowIndex);
            }

            if(e.ColumnIndex==clmEliminarSP.Index)
            {
                if(eliminarOrden(e.RowIndex))
                {
                    dgvSinPlanificar.Rows.RemoveAt(e.RowIndex);
                    //if(reordenar())
                    //{
                        MessageBox.Show("Orden eliminada correctamente", "Ordenes de extrusión", MessageBoxButtons.OK);
                    //}
                }
                else
                {
                    MessageBox.Show("Ocurrió un error y no se pudo eliminar la orden. Consulte con sistemas", "Ordenes de extrusión", MessageBoxButtons.OK);
                }
            }
        }

        private bool eliminarOrden(int ind)
        {
            return clsNewExtrusionOrder.delete(Convert.ToInt32(dgvSinPlanificar.Rows[ind].Cells[clmOrdenSP.Index].Value));
        }

        private void agregar(int ind)
        {
            clsNewExtrusionPlanDetail detail = new clsNewExtrusionPlanDetail();

            detail.sequential = plan.getNextSequential();
            detail.fkNewExtrusionPlan = plan.codsec;
            detail.fkNewExtrusionOrder = Convert.ToInt32(dgvSinPlanificar.Rows[ind].Cells[clmOrdenSP.Index].Value);
            detail.hours = Convert.ToDouble(Convert.ToDouble(dgvSinPlanificar.Rows[ind].Cells[clmCantidadSP.Index].Value) / plan.velocity);
            detail.deadTime = detail.hours * (1-Convert.ToDouble(plan.availability));

            if(detail.save())
            {
                if (clsNewExtrusionOrder.setAsProgrammed(detail.fkNewExtrusionOrder))
                {
                    dgvSinPlanificar.Rows.RemoveAt(ind);
                    fillPlanified();
                }
            }
        }

        private void fillPlanified()
        {
            dgvPlanificado.Rows.Clear();
            DataSet DS = plan.getDSdetail();

            if(DS.Tables.Count>0)
            {
                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    int seq = Convert.ToInt32(DS.Tables[0].Rows[i]["nepd_sequential"]);
                    dgvPlanificado.Rows.Add();
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmCodsec.Index].Value = Convert.ToInt32(DS.Tables[0].Rows[i]["nepd_codsec"]);
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmSecuencia.Index].Value = seq;
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmOrdenExtrusion.Index].Value = DS.Tables[0].Rows[i]["nepd_fkNewExtrusionOrder"];
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmOrderStatus.Index].Value = DS.Tables[0].Rows[i]["neo_fkStatus"];
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmPelicula.Index].Value = DS.Tables[0].Rows[i]["bopp_code"];
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmCantidad.Index].Value = DS.Tables[0].Rows[i]["neo_quantity"];
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmExtruido.Index].Value = 0;
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmTiempo.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["nepd_hours"]).ToString("0.0");
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmTiempoMuerto.Index].Value = Convert.ToDouble(DS.Tables[0].Rows[i]["nepd_deadTime"]).ToString("0.0");
                    if (seq == 1)
                    {
                        dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmInicio.Index].Value = plan.initDate.ToString("dd/MM/yyyy HH:mm");
                        dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmFin.Index].Value = plan.initDate.AddHours(Convert.ToDouble(DS.Tables[0].Rows[i]["nepd_hours"]) + Convert.ToDouble(DS.Tables[0].Rows[i]["nepd_deadTime"])).ToString("dd/MM/yyyy HH:mm");
                    }
                    else
                    {
                        dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmInicio.Index].Value = Convert.ToDateTime(dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 2].Cells[clmFin.Index].Value).ToString("dd/MM/yyyy HH:mm");
                        dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmFin.Index].Value = Convert.ToDateTime(dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmInicio.Index].Value).AddHours(Convert.ToDouble(DS.Tables[0].Rows[i]["nepd_hours"]) + Convert.ToDouble(DS.Tables[0].Rows[i]["nepd_deadTime"])).ToString("dd/MM/yyyy HH:mm");
                    }
                    dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].Cells[clmObservaciones.Index].Value = DS.Tables[0].Rows[i]["neo_observations"];
                    if(Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkStatus"])==3078)
                    {
                        dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Gray;
                    }
                    if (Convert.ToInt32(DS.Tables[0].Rows[i]["neo_fkStatus"]) == 3077)
                    {
                        dgvPlanificado.Rows[dgvPlanificado.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Orange;
                    }
                }
            }
        }

        private void dgvPlanificado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==clmQuitar.Index)
            {
                quitar(e.RowIndex);
            }
        }

        private void quitar(int ind)
        {
            if(Convert.ToInt32(dgvPlanificado.Rows[ind].Cells[clmOrderStatus.Index].Value)==3075)
            {
                if (clsNewExtrusionPlanDetail.delete(Convert.ToInt32(dgvPlanificado.Rows[ind].Cells[clmCodsec.Index].Value)))
                {
                    if (clsNewExtrusionOrder.setAsNonProgrammed(Convert.ToInt32(dgvPlanificado.Rows[ind].Cells[clmOrdenExtrusion.Index].Value)))
                    {
                        dgvPlanificado.Rows.RemoveAt(ind);
                        //fillPlanified();
                        reordenar();
                        fillOrdersToAdd();
                    }
                }
            }
            else
            {
                MessageBox.Show("Solo se pueden quitar ordenes de extrusión que no esten en ejecución o cerradas","Plan de extrusión",MessageBoxButtons.OK);
            }            
        }

        private bool reordenar()
        {
            DataSet DS = new DataSet();
            DS.Tables.Add();
            DS.Tables[0].Columns.Add("codsec");
            DS.Tables[0].Columns.Add("seq");
            DS.Tables[0].Columns.Add("order");
            DS.Tables[0].Columns.Add("orderStatus");
            DS.Tables[0].Columns.Add("film");
            DS.Tables[0].Columns.Add("solicit");
            DS.Tables[0].Columns.Add("extrud");
            DS.Tables[0].Columns.Add("time");
            DS.Tables[0].Columns.Add("deadtime");
            DS.Tables[0].Columns.Add("init");
            DS.Tables[0].Columns.Add("end");
            DS.Tables[0].Columns.Add("obs");

            for (int i=0;i<dgvPlanificado.Rows.Count;i++)
            {
                DS.Tables[0].Rows.Add();
                DS.Tables[0].Rows[i]["codsec"] = dgvPlanificado.Rows[i].Cells[clmCodsec.Index].Value;
                DS.Tables[0].Rows[i]["seq"] = i+1;
                DS.Tables[0].Rows[i]["order"] = dgvPlanificado.Rows[i].Cells[clmOrdenExtrusion.Index].Value;
                DS.Tables[0].Rows[i]["orderStatus"] = dgvPlanificado.Rows[i].Cells[clmOrderStatus.Index].Value;
                DS.Tables[0].Rows[i]["film"] = dgvPlanificado.Rows[i].Cells[clmPelicula.Index].Value;
                DS.Tables[0].Rows[i]["solicit"] = dgvPlanificado.Rows[i].Cells[clmCantidad.Index].Value;
                DS.Tables[0].Rows[i]["extrud"] = dgvPlanificado.Rows[i].Cells[clmExtruido.Index].Value;
                DS.Tables[0].Rows[i]["time"] = dgvPlanificado.Rows[i].Cells[clmTiempo.Index].Value;
                DS.Tables[0].Rows[i]["deadtime"] = dgvPlanificado.Rows[i].Cells[clmTiempoMuerto.Index].Value;
                DS.Tables[0].Rows[i]["init"] = dgvPlanificado.Rows[i].Cells[clmInicio.Index].Value;
                DS.Tables[0].Rows[i]["end"] = dgvPlanificado.Rows[i].Cells[clmFin.Index].Value;
                DS.Tables[0].Rows[i]["obs"] = dgvPlanificado.Rows[i].Cells[clmObservaciones.Index].Value;
            }

            if(clsNewExtrusionPlanDetail.deletePlanDetail(plan.codsec))
            {
                bool bandera = true;
                dgvPlanificado.Rows.Clear();

                for(int i=0;i<DS.Tables[0].Rows.Count;i++)
                {
                    clsNewExtrusionPlanDetail detail = new clsNewExtrusionPlanDetail();

                    detail.sequential = plan.getNextSequential();
                    detail.fkNewExtrusionPlan = plan.codsec;
                    detail.fkNewExtrusionOrder = Convert.ToInt32(DS.Tables[0].Rows[i]["order"]);
                    if(Convert.ToInt32(DS.Tables[0].Rows[i]["orderStatus"])!=3078)
                    {
                        detail.hours = Convert.ToDouble(Convert.ToDouble(DS.Tables[0].Rows[i]["solicit"]) / plan.velocity);
                        detail.deadTime = detail.hours * (1 - Convert.ToDouble(plan.availability));
                    }
                    else 
                    {
                        detail.hours = Convert.ToDouble(DS.Tables[0].Rows[i]["time"]);
                        detail.deadTime = Convert.ToDouble(DS.Tables[0].Rows[i]["deadtime"]);
                    }

                    bandera = detail.save() && bandera;
                }

                if(bandera)
                {
                    fillPlanified();
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrio un error y no se pudieron aplicar los cambios, consulte con sistemas","Plan de extrusión",MessageBoxButtons.OK);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
