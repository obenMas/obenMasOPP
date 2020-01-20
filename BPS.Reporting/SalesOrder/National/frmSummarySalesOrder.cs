using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Reporting.SummaryCutterMothReport.Report;

namespace BPS.Reporting.SummaryCutterMothReport
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
            try
            {
                rptCutter rptCutter = new rptCutter();
                Tables tables;

                tables = rptCutter.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCutter.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = password;
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
                prmoperation.Value = "CutterAcumulated";

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = 0;

                for (int i = 0; i < rptCutter.ParameterFields.Count; i++)
                {
                    switch (rptCutter.ParameterFields[i].Name)
                    {
                        case "mydata":
                            rptCutter.ParameterFields[i].CurrentValues.Clear();
                            rptCutter.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptCutter.ParameterFields[i].HasCurrentValue = true;
                            rptCutter.ParameterFields[i].DefaultValues.Clear();
                            rptCutter.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "operation":
                            rptCutter.ParameterFields[i].CurrentValues.Clear();
                            rptCutter.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptCutter.ParameterFields[i].HasCurrentValue = true;
                            rptCutter.ParameterFields[i].DefaultValues.Clear();
                            rptCutter.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        case "codsec":
                            rptCutter.ParameterFields[i].CurrentValues.Clear();
                            rptCutter.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptCutter.ParameterFields[i].HasCurrentValue = true;
                            rptCutter.ParameterFields[i].DefaultValues.Clear();
                            rptCutter.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        case "initdate":
                            rptCutter.ParameterFields[i].CurrentValues.Clear();
                            rptCutter.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptCutter.ParameterFields[i].HasCurrentValue = true;
                            rptCutter.ParameterFields[i].DefaultValues.Clear();
                            rptCutter.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptCutter.ParameterFields[i].CurrentValues.Clear();
                            rptCutter.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptCutter.ParameterFields[i].HasCurrentValue = true;
                            rptCutter.ParameterFields[i].DefaultValues.Clear();
                            rptCutter.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        default:
                            break;
                    }
                }
                crvSummarySalesOrder.ReportSource = rptCutter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos Mensuales Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
