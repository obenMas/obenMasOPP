using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;
using BPS.Reporting.Cellar.SummaryMonth.External;

namespace BPS
{
    public partial class frmSummaryCellarOpp : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;
        String month = string.Empty;

        public frmSummaryCellarOpp()
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
                rptSummaryCellarOpp rptSummaryCellarOpp = new rptSummaryCellarOpp();
                Tables tables;

                tables = rptSummaryCellarOpp.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryCellarOpp.ReportDefinition.Sections;
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

                clsSummaryCellar ObjSummaryCellar = new clsSummaryCellar();

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = endDate;

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = initDate;

                ParameterDiscreteValue prmmonth = new ParameterDiscreteValue();
                prmmonth.Value = GetFullNameMonth(dtpDate.Value);

                ParameterDiscreteValue prmsalesorder = new ParameterDiscreteValue();
                prmsalesorder.Value = ObjSummaryCellar.getSalesOrderOpp(initDate, endDate);

                ParameterDiscreteValue prmoutsalesorder = new ParameterDiscreteValue();
                prmoutsalesorder.Value = ObjSummaryCellar.getOutSalesOrderOpp(initDate, endDate);

                ParameterDiscreteValue prmstock = new ParameterDiscreteValue();
                prmstock.Value = ObjSummaryCellar.getStockOpp(initDate, endDate);

                ParameterDiscreteValue prmdelivery = new ParameterDiscreteValue();
                prmdelivery.Value = ObjSummaryCellar.getDeliveryOpp(initDate, endDate);


                for (int i = 0; i < rptSummaryCellarOpp.ParameterFields.Count; i++)
                {
                    switch (rptSummaryCellarOpp.ParameterFields[i].Name)
                    {
                        case "mounth":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "initdate":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "SalesOrder":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prmsalesorder);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prmsalesorder);
                            break;

                        case "OutSalesOrder":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prmoutsalesorder);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prmoutsalesorder);
                            break;

                        case "Stock":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prmstock);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prmstock);
                            break;

                        case "Delivery":
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].CurrentValues.Add(prmdelivery);
                            rptSummaryCellarOpp.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellarOpp.ParameterFields[i].DefaultValues.Add(prmdelivery);
                            break;
                        default:
                            break;
                    }
                }
                crvSummaryCellar.ReportSource = rptSummaryCellarOpp;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos Mensuales Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
