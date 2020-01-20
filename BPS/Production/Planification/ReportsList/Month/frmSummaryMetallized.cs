using System;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reporting.Metal.MetalizedSummary;

namespace BPS
{
    public partial class frmSummaryMetallized : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;
        String month = string.Empty;

        public frmSummaryMetallized()
        {
            InitializeComponent();
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
            try
            {
                rptSummaryMetallized rptSummaryMetallized = new rptSummaryMetallized();
                Tables tables;

                tables = rptSummaryMetallized.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryMetallized.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = endDate;

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = initDate;

                ParameterDiscreteValue prmmonth = new ParameterDiscreteValue();
                prmmonth.Value = GetFullNameMonth(dtpDate.Value);

                ParameterDiscreteValue prmoperation = new ParameterDiscreteValue();
                prmoperation.Value = "M1";

                for (int i = 0; i < rptSummaryMetallized.ParameterFields.Count; i++)
                {
                    switch (rptSummaryMetallized.ParameterFields[i].Name)
                    {
                        case "month":
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryMetallized.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "initdate":
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryMetallized.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryMetallized.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "operation":
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptSummaryMetallized.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallized.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        default:
                            break;
                    }
                }

                rptSummaryMetallizedOpp rptSummaryMetallizedOpp = new rptSummaryMetallizedOpp();

                tables = rptSummaryMetallizedOpp.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                sections = rptSummaryMetallizedOpp.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmop = new ParameterDiscreteValue();
                prmop.Value = "M2";

                for (int i = 0; i < rptSummaryMetallizedOpp.ParameterFields.Count; i++)
                {
                    switch (rptSummaryMetallizedOpp.ParameterFields[i].Name)
                    {
                        case "month":
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryMetallizedOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "initdate":
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryMetallizedOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryMetallizedOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "operation":
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].CurrentValues.Add(prmop);
                            rptSummaryMetallizedOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMetallizedOpp.ParameterFields[i].DefaultValues.Add(prmop);
                            break;

                        default:
                            break;
                    }
                }

                crvSummaryExtruder.ReportSource = rptSummaryMetallized;
                crystalReportViewer1.ReportSource = rptSummaryMetallizedOpp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos Mensuales Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
