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
    public partial class frmRawMaterialDecreaseByOrderProduction : Form
    {
        clsMachine objMachine = new clsMachine();
        clsFilmProductionPlanByProductionOrder objFilmProductionPlanByProductionOrder = new clsFilmProductionPlanByProductionOrder();

        public frmRawMaterialDecreaseByOrderProduction()
        {
            InitializeComponent();
        }
        public frmRawMaterialDecreaseByOrderProduction(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            objFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getActiveOrderByMachine(machineCodsec);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
       

            

       
    }
}