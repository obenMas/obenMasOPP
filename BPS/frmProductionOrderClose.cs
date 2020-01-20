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

    public partial class frmProductionOrderClose : Form
    {
        private int machine;
        clsProductionOrder objProductionOrder = new clsProductionOrder();
        clsProductionOrderDetail objProductionOrderDetail = new clsProductionOrderDetail();
        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();

        public frmProductionOrderClose()
        {
            InitializeComponent();
        }
        public frmProductionOrderClose(int productionOrderCodsec, int machine)
        {
            InitializeComponent();
            objProductionOrder.load(productionOrderCodsec);
            objProductionOrderDetail.load(objProductionOrder.codsec);
            objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(objProductionOrder.codsec);
            this.machine = machine;
        }

        private void frmProductionOrderClose_Load(object sender, EventArgs e)
        {
            lblProductionOrder.Text = "Orden Nro: " + objProductionOrder.number.ToString();
            lblLot.Text = "Lote " + objFilmProductionPlan.lotNumber;
        }

        private void rdoClose_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoClose.Checked == true)
                lblNote.Text = "Cierre definitivo de la orden de extrusión, una vez cerrada no se volvera a abrir.";
        }

        private void r_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreateNewNoPlan.Checked == true)
                lblNote.Text = "Cierra la orden de extrusión y crea una nueva orden de extrusión con el peso programado pendiente sin planificarla.";
        }

        private void rdoCloseAndCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreateNewWithPlan.Checked == true)
                lblNote.Text = "Cierra la orden de extrusión y crea una nueva orden de extrusión con el peso programado pendiente planificandola a continuación de la siguiente orden.";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (rdoClose.Checked == true)
            {
                
                objProductionOrder.close();
                MessageBox.Show("La orden de producción ha sido cerrada.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
                    
                
            }
            else if (rdoCreateNewNoPlan.Checked == true)
            {
                clsProductionOrder objNewProductionOrder = new clsProductionOrder();

                objProductionOrder.close();
                objNewProductionOrder = new clsProductionOrder(objProductionOrder.codsec);

                objNewProductionOrder.codsec = 0;
                objNewProductionOrder.number = 0;
                objNewProductionOrder.quantity = Convert.ToInt32(clsGlobal.Round(objProductionOrderDetail.Quantity - objProductionOrderDetail.FulfilledQuantity, -3));
                objNewProductionOrder.createdFromOtherOrder = true;
                objNewProductionOrder.createdBy = clsGlobal.LoggedUser.codsec;
                objNewProductionOrder.modifiedBy = clsGlobal.LoggedUser.codsec;
                objNewProductionOrder.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de producción", "Sin Planificar").codsec;
                objNewProductionOrder.createdDate = DateTime.Now;
                objNewProductionOrder.modifiedDate = DateTime.Now;

                objNewProductionOrder.save();

                MessageBox.Show("La orden de producción ha sido cerrada.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
            }
            else if (rdoCreateNewWithPlan.Checked == true)
            {
                clsProductionOrder objNewProductionOrder = new clsProductionOrder();

                objProductionOrder.close();
                objNewProductionOrder = new clsProductionOrder(objProductionOrder.codsec);

                objNewProductionOrder.codsec = 0;
                objNewProductionOrder.number = 0;
                objNewProductionOrder.quantity = Convert.ToInt32(clsGlobal.Round(objProductionOrderDetail.Quantity - objProductionOrderDetail.FulfilledQuantity, -3));
                objNewProductionOrder.createdFromOtherOrder = true;
                objNewProductionOrder.createdBy = clsGlobal.LoggedUser.codsec;
                objNewProductionOrder.modifiedBy = clsGlobal.LoggedUser.codsec;
                objNewProductionOrder.fkStatus = clsStatus.getStatusByStatusGroupNameAndStatusName("Ordenes de producción", "Planificada").codsec;
                objNewProductionOrder.StatusName = "Planificada";
                objNewProductionOrder.createdDate = DateTime.Now;
                objNewProductionOrder.modifiedDate = DateTime.Now;

                objNewProductionOrder.save();

                clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();

                objFilmProductionPlan = clsFilmProductionPlan.getFilmProductionPlanByProductionOrder(objProductionOrder.codsec);

                List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(objFilmProductionPlan.fkMachine);

                objFilmProductionPlan.codsec = 0;
                objFilmProductionPlan.fkProductionOrder = objNewProductionOrder.codsec;
                objFilmProductionPlan.totalWeight = clsGlobal.Round(objProductionOrderDetail.Quantity - objProductionOrderDetail.FulfilledQuantity, -3);
                objFilmProductionPlan.estimatedInitDate = lstFilmProductionPlan[0].estimatedInitDate.AddMinutes(1);
                objFilmProductionPlan.estimatedIdleTime = 0;
                objFilmProductionPlan.estimatedEndDate = objFilmProductionPlan.estimatedInitDate.AddHours((objFilmProductionPlan.totalWeight / objFilmProductionPlan.estimatedKilogramsPerHour));

                objFilmProductionPlan.save();
                                
                clsFilmProductionPlan.recalculateActiveItemsByMachine(objFilmProductionPlan.fkMachine);
                
                MessageBox.Show("La orden de producción ha sido cerrada.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                this.Close();
            }
        }

    }
}
