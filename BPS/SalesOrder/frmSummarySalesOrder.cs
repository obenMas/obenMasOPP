using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reporting.SummaryCutterMothReport.Report;
using BPS.Bussiness;
using System.Collections.Generic;
using BPS.Reporting.SalesOrder.Summary;

namespace BPS.SalesOrder
{
    public partial class frmSummarySalesOrder : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;
        String month = string.Empty;

        protected string password = string.Empty;

        public frmSummarySalesOrder()
        {
            InitializeComponent();
            PopulateCustomer();
        }

        private void PopulateCustomer()
        {
            List<clsEntity> lstCustomer = new List<clsEntity>();
            lstCustomer = clsEntity.getList();
            cmbCustomer.Items.Clear();
            for (int i = 0; i < lstCustomer.Count; i++)
                cmbCustomer.Items.Add(lstCustomer[i]);
        }

        public frmSummarySalesOrder(string password)
        {
            InitializeComponent();
            this.password = password;
        }

        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            FormatDate(dtpDate.Value);
            loadReports();
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

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //FormatDate(dtpDate.Value);
            //loadReports();
        }

        private void loadReports()
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (dtpDate.Value.CompareTo(dtpEnd.Value) < 0)
            {
                if (cmbCustomer.SelectedIndex > -1)
                    loadReports(cmbCustomer, dtpDate, dtpEnd);
                else
                    MessageBox.Show("Debe seleccionar al menos un cliente", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            else if (dtpDate.Value.CompareTo(dtpEnd.Value) == 0)
                MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            else if (dtpDate.Value.CompareTo(dtpEnd.Value) > 0)
                MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

        private void loadReports(ComboBox cmbCustomer, DateTimePicker dtpDate, DateTimePicker dtpEnd)
        {
            try
            {
                rptSummaryOrderD rptSummaryOrderD = new rptSummaryOrderD();
                Tables tables;

                tables = rptSummaryOrderD.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryOrderD.ReportDefinition.Sections;
                foreach (Section section in sections)
                {
                    ReportObjects reportObjects = section.ReportObjects;
                    foreach (ReportObject reportObject in reportObjects)
                    {
                        if (reportObject.Kind == ReportObjectKind.SubreportObject)
                        {
                            SubreportObject subreportObject = (SubreportObject)reportObject;
                            ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                            tables = subReportDocument.Database.Tables;
                            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                            {
                                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                                tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                initDate = dtpDate.Value.Date.Year.ToString() + "/" + dtpDate.Value.Date.Month.ToString() + "/" + dtpDate.Value.Date.Day.ToString() + " " + initHour.ToString();
                prminitdate.Value = initDate;

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                endDate = dtpEnd.Value.Date.Year.ToString() + "/" + dtpEnd.Value.Date.Month.ToString() + "/" + dtpEnd.Value.Date.Day.ToString() + " " + endHour.ToString();
                prmenddate.Value = endDate;


                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = ((clsEntity)cmbCustomer.SelectedItem).codsec;

                for (int i = 0; i < rptSummaryOrderD.ParameterFields.Count; i++)
                {
                    switch (rptSummaryOrderD.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptSummaryOrderD.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryOrderD.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptSummaryOrderD.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryOrderD.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryOrderD.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        case "initdate":
                            rptSummaryOrderD.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryOrderD.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryOrderD.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryOrderD.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryOrderD.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryOrderD.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryOrderD.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryOrderD.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryOrderD.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryOrderD.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        default:
                            break;
                    }
                }
                crvSummarySalesOrder.ReportSource = rptSummaryOrderD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
