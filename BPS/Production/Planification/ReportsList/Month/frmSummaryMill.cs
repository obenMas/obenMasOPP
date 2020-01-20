using System;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reporting.Mill;

namespace BPS
{
    public partial class frmSummaryMill : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;
        String month = string.Empty;

        public frmSummaryMill()
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
                rptSummaryMill rptSummaryMill = new rptSummaryMill();
                Tables tables;

                tables = rptSummaryMill.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryMill.ReportDefinition.Sections;
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

                for (int i = 0; i < rptSummaryMill.ParameterFields.Count; i++)
                {
                    switch (rptSummaryMill.ParameterFields[i].Name)
                    {
                        case "month":
                            rptSummaryMill.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMill.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryMill.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMill.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMill.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "initdate":
                            rptSummaryMill.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMill.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryMill.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMill.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMill.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryMill.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMill.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryMill.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMill.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMill.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "operation":
                            rptSummaryMill.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMill.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptSummaryMill.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMill.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMill.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        default:
                            break;
                    }
                }

                rptSummaryMillDetail rptSummaryMillDetail = new rptSummaryMillDetail();

                tables = rptSummaryMillDetail.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                sections = rptSummaryMillDetail.ReportDefinition.Sections;
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

                for (int i = 0; i < rptSummaryMillDetail.ParameterFields.Count; i++)
                {
                    switch (rptSummaryMillDetail.ParameterFields[i].Name)
                    {
                        case "month":
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryMillDetail.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "initdate":
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryMillDetail.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryMillDetail.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "operation":
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].CurrentValues.Add(prmop);
                            rptSummaryMillDetail.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMillDetail.ParameterFields[i].DefaultValues.Add(prmop);
                            break;

                        default:
                            break;
                    }
                }

                crvSummaryExtruder.ReportSource = rptSummaryMill;
                crystalReportViewer1.ReportSource = rptSummaryMillDetail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos Mensuales Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
