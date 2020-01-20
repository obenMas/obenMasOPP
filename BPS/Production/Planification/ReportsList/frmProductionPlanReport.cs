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
    public partial class frmProductionPlanReport : Form
    {
        public TimeSpan initHour = new TimeSpan(0, 0, 0);
        public String Date = string.Empty;
        public string myOperation = "";

        public frmProductionPlanReport()
        {
            InitializeComponent();

        }

        private void frmProductionPlanReport_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbMachine.Items.Add(lstMachines[i]);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<clsFilmProductionPlan> lstFilmProductionPlan = new List<clsFilmProductionPlan>();

            if (cmbMachine.SelectedIndex >= 0 && cmbMachine.SelectedItem.ToString() != "Metalizadora")
            {
                myOperation = "Cmb";
                Date = Convert.ToString(dtpFrom.Value.Date.Add(initHour));

                lstFilmProductionPlan = clsFilmProductionPlan.getListByMachineAndFilter(((clsMachine)cmbMachine.SelectedItem).codsec, Convert.ToDateTime(Date), "Data");

                dgvCalendar.Rows.Clear();

                for (int i = 0; i < lstFilmProductionPlan.Count; i++)
                {
                    dgvCalendar.Rows.Add();
                    dgvCalendar.Rows[i].Cells[clmordenation.Index].Value = lstFilmProductionPlan[i].ordenation;
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value = lstFilmProductionPlan[i].codsec.ToString();
                    dgvCalendar.Rows[i].Cells[clmlotnumber.Index].Value = lstFilmProductionPlan[i].lotNumber.ToString();
                    dgvCalendar.Rows[i].Cells[clmfilm.Index].Value = lstFilmProductionPlan[i].boppcode.ToString();
                    dgvCalendar.Rows[i].Cells[clmwith.Index].Value = lstFilmProductionPlan[i].widths.ToString();
                    dgvCalendar.Rows[i].Cells[clmweigth.Index].Value = lstFilmProductionPlan[i].totalWeight.ToString();
                    dgvCalendar.Rows[i].Cells[clmkghr.Index].Value = lstFilmProductionPlan[i].estimatedKilogramsPerHour.ToString();
                    dgvCalendar.Rows[i].Cells[clmtimeproduction.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlan[i].totalWeight / lstFilmProductionPlan[i].estimatedKilogramsPerHour, 2));
                    dgvCalendar.Rows[i].Cells[clminitdate.Index].Value = lstFilmProductionPlan[i].estimatedInitDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmenddate.Index].Value = lstFilmProductionPlan[i].estimatedEndDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmcustomer.Index].Value = lstFilmProductionPlan[i].companyName.ToString();
                    if (dgvCalendar.Rows[i].Cells[clmlotnumber.Index].Value.ToString() == "---------------" && dgvCalendar.Rows[i].Cells[clmcustomer.Index].Value.ToString() == "STOCK#----")
                    {
                        for (int j = 0; j < dgvCalendar.ColumnCount; j++)
                            dgvCalendar.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                    }
                }
            }
            else if(cmbMachine.SelectedItem.ToString() == "Metalizadora")
            {
                myOperation = "Met";

                List<clsProductionOrderMetal> lstMetal = new List<clsProductionOrderMetal>();

                lstMetal = clsProductionOrderMetal.getActiveListByDate(dtpFrom.Value.Date);

                dgvCalendar.Rows.Clear();

                for (int i = 0; i < lstMetal.Count; i++)
                {
                    dgvCalendar.Rows.Add();
                    dgvCalendar.Rows[i].Cells[clmordenation.Index].Value = lstMetal[i].ordenation;
                    dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value = lstMetal[i].codsec.ToString();
                    dgvCalendar.Rows[i].Cells[clmlotnumber.Index].Value = lstMetal[i].lotNumber.ToString();
                    dgvCalendar.Rows[i].Cells[clmfilm.Index].Value = lstMetal[i].BoppFrom.ToString() + " - " + lstMetal[i].BoppTo.ToString();
                    dgvCalendar.Rows[i].Cells[clmwith.Index].Value = lstMetal[i].widthFrom.ToString() + " - " + lstMetal[i].widthTo.ToString();
                    dgvCalendar.Rows[i].Cells[clmweigth.Index].Value = lstMetal[i].quantity.ToString();
                    dgvCalendar.Rows[i].Cells[clmkghr.Index].Value = lstMetal[i].kilograms.ToString();
                    dgvCalendar.Rows[i].Cells[clmtimeproduction.Index].Value = Convert.ToString(Math.Round(lstMetal[i].quantity / lstMetal[i].kilograms, 2));
                    dgvCalendar.Rows[i].Cells[clminitdate.Index].Value = lstMetal[i].EstimateInitDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmenddate.Index].Value = lstMetal[i].EstimadteEndDate.ToString();
                    dgvCalendar.Rows[i].Cells[clmcustomer.Index].Value = lstMetal[i].Customer.ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMachine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsMachine> lstMachines = clsMachine.getExtruderMachineList();
                cmbMachine.Items.Clear();
                for (int i = 0; i < lstMachines.Count; i++)
                    cmbMachine.Items.Add(lstMachines[i]);
            } 
        }

        private void btnReportPlanification_Click(object sender, EventArgs e)
        {
            if (cmbMachine.SelectedIndex == -1)
                MessageBox.Show("Seleccione una máquina antes de generar el reporte","Reporte de Planificación",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            else
            {
                UpdatePos(myOperation);
                frmFilmProductionReportDate winFilmProdcutionReportDate = new frmFilmProductionReportDate(dtpFrom.Value.Date);
                winFilmProdcutionReportDate.StartPosition = FormStartPosition.Manual;
                winFilmProdcutionReportDate.MdiParent = this.MdiParent;
                winFilmProdcutionReportDate.Show();
            }
        }

        private void UpdatePos(string op)
        {
            try
            {
                if (op == "Cmb")
                {
                    for (int i = 0; i < dgvCalendar.Rows.Count; i++)
                    {
                        clsFilmProductionPlan ObjFilmProductionPlan = new clsFilmProductionPlan(Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value), true);
                        ObjFilmProductionPlan.ordenation = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmordenation.Index].Value);
                        if (!ObjFilmProductionPlan.save("pos"))
                            break;
                    }
                    myOperation = "";
                }
                else if (op == "Met")
                {
                    for (int i = 0; i < dgvCalendar.Rows.Count; i++)
                    {
                        clsProductionOrderMetal ObjMetal = new clsProductionOrderMetal(Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmMachineCalendarCodsec.Index].Value));
                        ObjMetal.ordenation = Convert.ToInt32(dgvCalendar.Rows[i].Cells[clmordenation.Index].Value);
                        if (!ObjMetal.updatePos())
                            break;
                    }
                    myOperation = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Planificación", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private void dgvCalendar_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numérico");
                        dgvCalendar.CancelEdit();
                    }
                    break;
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            myOperation = "";
            cmbMachine.SelectedIndex = -1;
            cmbMachine.Text = "";
            dtpFrom.Value = DateTime.Now;
        }
    }
}