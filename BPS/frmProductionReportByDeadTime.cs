using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using BPS.Reporting.ProductionReports.DeadTime;

namespace BPS
{
    public partial class frmProductionReportByDeadTime : Form
    {
        clsMachine objMachine = new clsMachine();

        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;

        public frmProductionReportByDeadTime()
        {
            InitializeComponent();
        }

        public frmProductionReportByDeadTime(int MachineCodSec)
        {
            InitializeComponent();
            objMachine.load(MachineCodSec, "Extruder");
            GetMachineName(MachineCodSec);
        }

        private void GetMachineName(int MachineCodSec)
        {
            List<clsMachine> lstMachine = clsMachine.getExtruderMachineList();
            for (int i = 0; i < lstMachine.Count; i++)
            {
                if (lstMachine[i].codsec == MachineCodSec)
                {
                    lblMachineName.Text = lstMachine[i].Extruder.name;
                    break;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            TimeSpan dttmptime = new TimeSpan(0, 0, 0);
            TimeSpan dttmmtime = new TimeSpan(0, 0, 0);
            TimeSpan dttmotime = new TimeSpan(0, 0, 0);
            TimeSpan dttttime = new TimeSpan(0, 0, 0);
            TimeSpan dtoperationtime = new TimeSpan(0, 0, 0);

            List<clsDeadTimeByFilmProductionPlan> lstDeadTimeByFilmProductionPlan = new List<clsDeadTimeByFilmProductionPlan>();
            ClearLabelsAndGrid();
            FormatDate(dtpInitDate.Value);
            lstDeadTimeByFilmProductionPlan = clsDeadTimeByFilmProductionPlan.getListFilmProductionPlanByMothByMachine(objMachine.codsec, endDate, initDate);

            if (lstDeadTimeByFilmProductionPlan.Count > 0)
            {
                for (int i = 0; i < lstDeadTimeByFilmProductionPlan.Count; i++)
                {
                    dgvDeadTime.Rows.Add();
                    dgvDeadTime.Rows[i].Cells[clm_NameDeadTime.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeGroup.ToString();
                    dgvDeadTime.Rows[i].Cells[clmDe.Index].Value = lstDeadTimeByFilmProductionPlan[i].deadTimeTypeName.ToString();
                    dtoperationtime = lstDeadTimeByFilmProductionPlan[i].endDate.Subtract(lstDeadTimeByFilmProductionPlan[i].initDate);
                    dgvDeadTime.Rows[i].Cells[clm_DeadTime.Index].Value = dtoperationtime.ToString();

                    if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup == "TMP")
                        dttmptime += new TimeSpan(dtoperationtime.Hours, dtoperationtime.Minutes, 0);
                    else if (lstDeadTimeByFilmProductionPlan[i].deadTimeGroup == "TMM")
                        dttmmtime += new TimeSpan(dtoperationtime.Hours, dtoperationtime.Minutes, 0);
                    else
                        dttmotime += new TimeSpan(dtoperationtime.Hours, dtoperationtime.Minutes, 0);

                    dttttime += new TimeSpan(dtoperationtime.Hours, dtoperationtime.Minutes, 0);

                    dtoperationtime = new TimeSpan(0, 0, 0);
                }

                lblTotalTimeDead.Text = dttttime.ToString();
                label2.Text = dttmmtime.ToString();
                label5.Text = dttmptime.ToString();
                label8.Text = dttmotime.ToString();
                label5.BackColor = Color.FromArgb(207, 234, 254);
                label8.BackColor = Color.FromArgb(232, 202, 244);
                label2.BackColor = Color.FromArgb(249, 196, 183);
                ColorByDeadTime();

                //Order By Dead Time
                dgvDeadTime.Sort(clm_NameDeadTime, ListSortDirection.Ascending);
            }
            else
                MessageBox.Show("No hay existen datos regitrados con esa fecha", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

        private void ColorByDeadTime()
        {
            for (int i = 0; i < dgvDeadTime.Rows.Count; i++)
            {
                if (dgvDeadTime.Rows[i].Cells[clm_NameDeadTime.Index].Value != null)
                {
                    switch (dgvDeadTime.Rows[i].Cells[clm_NameDeadTime.Index].Value.ToString())
                    {
                        case "TMP":
                            for (int j = 0; j < dgvDeadTime.Columns.Count; j++)
                                dgvDeadTime.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(207, 234, 254);
                            break;
                        case "TMOtros":
                            for (int j = 0; j < dgvDeadTime.Columns.Count; j++)
                                dgvDeadTime.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(232, 202, 244);
                            break;
                        case "TMM":
                            for (int j = 0; j < dgvDeadTime.Columns.Count; j++)
                                dgvDeadTime.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(249, 196, 183);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void ClearLabelsAndGrid()
        {
            dgvDeadTime.Rows.Clear();
            lblTotalTimeDead.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvDeadTime.Rows.Count > 0)
            {
                BPS.Reporting.ProductionReports.DeadTime.frmProductionReportByDeadTimeReport winProductionDeadTimeReport = new BPS.Reporting.ProductionReports.DeadTime.frmProductionReportByDeadTimeReport(objMachine.codsec, initDate, endDate, GetFullNameMonth(dtpInitDate.Value),clsGlobal.password);
                winProductionDeadTimeReport.StartPosition = FormStartPosition.Manual;
                winProductionDeadTimeReport.MdiParent = this.MdiParent;
                winProductionDeadTimeReport.Show();
            }
            else
                MessageBox.Show("No hay datos para el reporte", "Tiempos Muertos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void frmProductionReportByDeadTime_Load(object sender, EventArgs e)
        {

        }
    }
}
