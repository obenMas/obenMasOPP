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
    public partial class frmNewExtrusionPlanCreation : Form
    {
        public frmNewExtrusionPlan form;
        public clsNewExtrusionPlan plan = new clsNewExtrusionPlan();

        public frmNewExtrusionPlanCreation(frmNewExtrusionPlan frm)
        {
            InitializeComponent();
            form = frm;
            fillMachineCombo();
            numVelocity.Value = 3200;
            numEfficiency.Value = 0.97M;
            numAvailability.Value = 0.9M;
        }

        private void fillMachineCombo()
        {
            List<clsMachine> lista = clsMachine.getExtruderMachineList();

            for (int i = 0; i < lista.Count; i++)
            {
                cmbMachine.Items.Add(lista[i].Extruder.name);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(cmbMachine.SelectedIndex!=-1)
            {
                List<clsMachine> lista = clsMachine.getExtruderMachineList();

                for (int i = 0; i < lista.Count; i++)
                {
                    if(cmbMachine.Items[cmbMachine.SelectedIndex].ToString()==lista[i].Extruder.name)
                    {
                        plan.fkMachine = lista[i].codsec;
                    }
                }

                plan.initDate = dtpInit.Value;
                if(txtObservations.Text!=null)
                {
                    plan.observations = txtObservations.Text;
                }
                plan.velocity = Convert.ToInt32(numVelocity.Value);
                plan.efficiency = Convert.ToDouble(numEfficiency.Value);
                plan.availability = Convert.ToDouble(numAvailability.Value);

                plan.save();
                form.fillPlanDetails(plan);
                this.Close();
            }
        }
    }
}
