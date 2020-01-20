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
    public partial class frmFilmProductionPlanEdit : Form
    {
        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
        Boolean flgEditInitDate = false;
        Boolean flgOnLoad = true;
        DateTime endDate;

        public frmFilmProductionPlanEdit()
        {
            InitializeComponent();
        }
        public frmFilmProductionPlanEdit(int filmProductionPlanCodsec, bool editInitDate)
        {
            InitializeComponent();
            objFilmProductionPlan.load(filmProductionPlanCodsec);
            flgEditInitDate = editInitDate;
        }

        public void calculateDates()
        {
            if (flgOnLoad != true)
            {
                if (objFilmProductionPlan.productionOrderStatusName == "En producción")
                {
                    clsProductionOrderDetail objProductionOrderDetail = new clsProductionOrderDetail();
                    List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListByFilmProductionPlan(objFilmProductionPlan.codsec);
                    
                    double totalTime = 0;
                    double totalIdleTime = 0;
                    
                    for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
                    {
                        totalTime += lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate).TotalHours;
                    }

                    objProductionOrderDetail.load(objFilmProductionPlan.fkProductionOrder);

                    TimeSpan ts = DateTime.Now.AddHours((Convert.ToDouble(txtTotalWeigth.Text) - objProductionOrderDetail.FulfilledQuantity) / Convert.ToDouble(txtKPH.Text)) - DateTime.Now;

                    totalIdleTime = totalTime + Math.Ceiling((ts.TotalHours / 24) * 2);

                    txtIdleTime.Text = Math.Ceiling(totalIdleTime).ToString();
                    endDate = dtpInitDate.Value.AddHours((Convert.ToDouble(txtTotalWeigth.Text) / Convert.ToDouble(txtKPH.Text)) + Convert.ToDouble(txtIdleTime.Text));
                    lblEndDateTime.Text = endDate.ToString("dd/MM/yyyy    HH:mm:ss");
                }
                else
                {
                    TimeSpan ts = dtpInitDate.Value.AddHours((Convert.ToDouble(txtTotalWeigth.Text) / Convert.ToDouble(txtKPH.Text))) - dtpInitDate.Value;
                    txtIdleTime.Text = Math.Ceiling((ts.TotalHours / 24) * 2).ToString();
                    endDate = dtpInitDate.Value.AddHours((Convert.ToDouble(txtTotalWeigth.Text) / Convert.ToDouble(txtKPH.Text)) + Convert.ToDouble(txtIdleTime.Text));
                    lblEndDateTime.Text = endDate.ToString("dd/MM/yyyy    HH:mm:ss");
                }
            }
        }

        private void frmFilmProductionPlanEdit_Load(object sender, EventArgs e)
        {
            flgOnLoad = true;
            dtpInitDate.CustomFormat = "dd/MM/yyyy    HH:mm:ss";
            lblProductionOrderNumber.Text = (objFilmProductionPlan.productionOrder.number > 0) ? objFilmProductionPlan.productionOrder.number.ToString() : "----";
            lblMachineName.Text = objFilmProductionPlan.MachineName;
            txtKPH.Text = objFilmProductionPlan.estimatedKilogramsPerHour.ToString();
            txtIdleTime.Text = objFilmProductionPlan.estimatedIdleTime.ToString();
            dtpInitDate.Enabled = flgEditInitDate;
            dtpInitDate.Value = objFilmProductionPlan.estimatedInitDate;
            txtTotalWeigth.Text = Math.Round(objFilmProductionPlan.totalWeight, 2).ToString();
            lblEndDateTime.Text = objFilmProductionPlan.estimatedEndDate.ToString("dd/MM/yyyy    HH:mm:ss");
            endDate = objFilmProductionPlan.estimatedEndDate;
            txtWidths.Text = objFilmProductionPlan.widths;
            txtLength.Text = objFilmProductionPlan.estimatedLength.ToString();
            txtNotes.Text = objFilmProductionPlan.notes;

            flgOnLoad = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = clsFilmProductionPlan.getActiveListByMachine(objFilmProductionPlan.fkMachine);
            int position = -1;

            clsFilmProductionPlan objOriginalFilmProductionPlan = new clsFilmProductionPlan();
            objOriginalFilmProductionPlan = new clsFilmProductionPlan(objFilmProductionPlan.codsec);

            objFilmProductionPlan.estimatedInitDate = dtpInitDate.Value;
            objFilmProductionPlan.estimatedEndDate = endDate;
            objFilmProductionPlan.estimatedKilogramsPerHour = Convert.ToInt32(txtKPH.Text);
            objFilmProductionPlan.estimatedIdleTime = Convert.ToInt32(txtIdleTime.Text);
            objFilmProductionPlan.totalWeight = Convert.ToInt32(txtTotalWeigth.Text);
            objFilmProductionPlan.notes = txtNotes.Text;
            objFilmProductionPlan.widths = txtWidths.Text;
            objFilmProductionPlan.estimatedLength = Convert.ToInt32(txtLength.Text);

            if (Convert.ToDouble(txtTotalWeigth.Text) != objOriginalFilmProductionPlan.productionOrder.quantity)
                objFilmProductionPlan.save(true);
            else
                objFilmProductionPlan.save();

            objFilmProductionPlan.productionOrder.quantity = Convert.ToInt32(txtTotalWeigth.Text);
            objFilmProductionPlan.productionOrder.save();



            for (int i = 0; i < lstFilmProductionPlan.Count; i++)
            {
                if (lstFilmProductionPlan[i].codsec == objFilmProductionPlan.codsec)
                    position = i + 1;
            }

            DateTime newInitDate = new DateTime();
            if (lstFilmProductionPlan.Count > 0)
                newInitDate = endDate;

            for (int i = position; i < lstFilmProductionPlan.Count; i++)
            {
                if (i == position)
                {
                    lstFilmProductionPlan[i].estimatedInitDate = newInitDate;
                    lstFilmProductionPlan[i].estimatedEndDate = newInitDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                else
                {
                    lstFilmProductionPlan[i].estimatedInitDate = lstFilmProductionPlan[i - 1].estimatedEndDate;
                    lstFilmProductionPlan[i].estimatedEndDate = lstFilmProductionPlan[i].estimatedInitDate.AddHours(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour);
                }
                lstFilmProductionPlan[i].save();
            }

            MessageBox.Show("Se ha actualizado la información con éxito.", "Programación de extrusión", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            this.Close();
        }

        private void txtKPH_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtKPH.Text))
                calculateDates();
            else
            {
                MessageBox.Show("El valor debe ser numérico");
                txtKPH.Text = objFilmProductionPlan.estimatedKilogramsPerHour.ToString();
            }
        }

        private void dtpInitDate_ValueChanged(object sender, EventArgs e)
        {
            calculateDates();
        }

        private void txtIdleTime_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtIdleTime.Text))
                calculateDates();
            else
            {
                MessageBox.Show("El valor debe ser numérico");
                txtKPH.Text = objFilmProductionPlan.estimatedKilogramsPerHour.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTotalWeigth_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtTotalWeigth.Text))
                calculateDates();
            else
            {
                MessageBox.Show("El valor debe ser numérico");
                txtTotalWeigth.Text = objFilmProductionPlan.totalWeight.ToString();
            }
        }
    }
}
