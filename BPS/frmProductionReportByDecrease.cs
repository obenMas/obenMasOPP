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
    public partial class frmProductionReportByDecrease : Form
    {
        clsMachine objMachine = new clsMachine();
        double TotalDecrease = 0;
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;

        public frmProductionReportByDecrease()
        {
            InitializeComponent();
        }

        private void GetMachineName(int machineCodSec)
        {
            List<clsMachine> lstMachine = clsMachine.getExtruderMachineList();
            for (int i = 0; i < lstMachine.Count; i++)
            {
                if (lstMachine[i].codsec == machineCodSec)
                    lblMachineName.Text = lstMachine[i].Extruder.name;
            }
        }

        public frmProductionReportByDecrease(int machineCodSec)
        {
            InitializeComponent();
            objMachine.load(machineCodSec, "Extruder");
            GetMachineName(machineCodSec);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ClearRowsAndCount();
            List<clsDecreaseByFilmProductionPlan> lstDrecreaseByFilmProductionPlan = new List<clsDecreaseByFilmProductionPlan>();
            FormatDate(dtpInitDate.Value);
            lstDrecreaseByFilmProductionPlan = clsDecreaseByFilmProductionPlan.getListDecrease(objMachine.codsec, initDate, endDate);
            if (lstDrecreaseByFilmProductionPlan.Count > 0)
            {
                for (int i = 0; i < lstDrecreaseByFilmProductionPlan.Count; i++)
                {
                    dgvDecrease.Rows.Add(new clsDecreaseByFilmProductionPlan());
                    dgvDecrease.Rows[i].Cells[clm_Decrease.Index].Value = Math.Round(lstDrecreaseByFilmProductionPlan[i].weight, 2);
                    dgvDecrease.Rows[i].Cells[clm_NameDecrease.Index].Value = lstDrecreaseByFilmProductionPlan[i].decreaseName;
                    dgvDecrease.Rows[i].Cells[clmDate.Index].Value = lstDrecreaseByFilmProductionPlan[i].createdDate.ToShortDateString();
                    TotalDecrease += Convert.ToDouble(lstDrecreaseByFilmProductionPlan[i].weight);
                }
                lblTotalWaste.Text = Math.Round(TotalDecrease, 2).ToString();
            }
            else
                MessageBox.Show("No Hay datos con ese mes", "Reporte Desperdicios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ClearRowsAndCount()
        {
            dgvDecrease.Rows.Clear();
            TotalDecrease = 0;
            lblTotalWaste.Text = "0";
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvDecrease.Rows.Count == 0)
                MessageBox.Show("No hay datos en el reporte", "Reporte de Producción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                frmProductionReportByDecreaseReport winProductionDecreaseReport = new frmProductionReportByDecreaseReport(objMachine.codsec, initDate, endDate, GetFullNameMonth(dtpInitDate.Value));
                winProductionDecreaseReport.StartPosition = FormStartPosition.Manual;
                winProductionDecreaseReport.MdiParent = this.MdiParent;
                winProductionDecreaseReport.Show();
            }
        }

        private void FormatDate(DateTime date)
        {
            if (DateTime.IsLeapYear(date.Date.Year))
            {
                if (date.Date.Month == 1 || date.Date.Month == 3 || date.Date.Month == 5 || date.Date.Month == 7 || date.Date.Month == 8 || date.Date.Month == 10 || date.Date.Month == 12)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "31 " + endHour.ToString();
                }
                else if (date.Date.Month == 2)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "29 " + endHour.ToString();
                }
                else if (date.Date.Month == 4 || date.Date.Month == 6 || date.Date.Month == 9 || date.Date.Month == 11)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "30 " + endHour.ToString();
                }
            }
            else
            {
                if (date.Date.Month == 1 || date.Date.Month == 3 || date.Date.Month == 5 || date.Date.Month == 7 || date.Date.Month == 8 || date.Date.Month == 10 || date.Date.Month == 12)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "31 " + endHour.ToString();
                }
                else if (date.Date.Month == 2)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "28 " + endHour.ToString();
                }
                else if (date.Date.Month == 4 || date.Date.Month == 6 || date.Date.Month == 9 || date.Date.Month == 11)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "30 " + endHour.ToString();
                }
            }
        }

        private string GetFullNameMonth(DateTime date)
        {
            if (date.Date.Month == 1)
                return "ENERO";
            else if (date.Date.Month == 2)
                return "FEBRERO";
            else if (date.Date.Month == 3)
                return "MARZO";
            else if (date.Date.Month == 4)
                return "ABRIL";
            else if (date.Date.Month == 5)
                return "MAYO";
            else if (date.Date.Month == 6)
                return "JUNIO";
            else if (date.Date.Month == 7)
                return "JULIO";
            else if (date.Date.Month == 8)
                return "AGOSTO";
            else if (date.Date.Month == 9)
                return "SEPTIEMBRE";
            else if (date.Date.Month == 10)
                return "OCTUBRE";
            else if (date.Date.Month == 11)
                return "NOVIEMBRE";
            else if (date.Date.Month == 12)
                return "DICIEMBRE";
            else
                return string.Empty;
        }
    }
}
