using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;
using BPS.Reporting.Cellar.SummaryMonth.Bopp;

namespace BPS
{
    public partial class frmSummaryCellar : Form
    {
        TimeSpan initHour = new TimeSpan(07, 30, 00);
        TimeSpan endHour = new TimeSpan(07, 30, 00);
        String initDate = string.Empty;
        String endDate = string.Empty;
        String month = string.Empty;

        public frmSummaryCellar()
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
                    if (date.Date.Month == 12)
                    {
                        initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                        endDate = (date.Date.Year + 1).ToString() + "/" + (date.Date.Month - 11).ToString() + "/" + "1 " + initHour.ToString();
                    }
                    else
                    {
                        initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                        endDate = date.Date.Year.ToString() + "/" + (date.Date.Month + 1).ToString() + "/" + "1 " + initHour.ToString();
                    }
                }
                else if (date.Date.Month == 2)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + (date.Date.Month + 1).ToString() + "/" + "1 " + initHour.ToString();
                }
                else if (date.Date.Month == 4 || date.Date.Month == 6 || date.Date.Month == 9 || date.Date.Month == 11)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + (date.Date.Month + 1).ToString() + "/" + "1 " + initHour.ToString();
                }
            }
            else
            {
                if (date.Date.Month == 1 || date.Date.Month == 3 || date.Date.Month == 5 || date.Date.Month == 7 || date.Date.Month == 8 || date.Date.Month == 10 || date.Date.Month == 12)
                {
                    if (date.Date.Month == 12)
                    {
                        initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                        endDate = (date.Date.Year + 1).ToString() + "/" + (date.Date.Month - 11).ToString() + "/" + "1 " + initHour.ToString();
                    }
                    else
                    {
                        initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                        endDate = date.Date.Year.ToString() + "/" + (date.Date.Month + 1).ToString() + "/" + "1 " + initHour.ToString();
                    }
                }
                else if (date.Date.Month == 2)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + (date.Date.Month + 1).ToString() + "/" + "1 " + initHour.ToString();
                }
                else if (date.Date.Month == 4 || date.Date.Month == 6 || date.Date.Month == 9 || date.Date.Month == 11)
                {
                    initDate = date.Date.Year.ToString() + "/" + date.Date.Month.ToString() + "/" + "1 " + initHour.ToString();
                    endDate = date.Date.Year.ToString() + "/" + (date.Date.Month + 1).ToString() + "/" + "1 " + initHour.ToString();
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
                rptSummaryCellar rptSummaryCellar = new rptSummaryCellar();
                Tables tables;

                tables = rptSummaryCellar.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryCellar.ReportDefinition.Sections;
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
                prmsalesorder.Value = ObjSummaryCellar.getSalesOrder(initDate, endDate);

                ParameterDiscreteValue prmoutsalesorder = new ParameterDiscreteValue();
                prmoutsalesorder.Value = ObjSummaryCellar.getOutSalesOrder(initDate, endDate);

                ParameterDiscreteValue prmoutstock = new ParameterDiscreteValue();
                prmoutstock.Value = ObjSummaryCellar.getOutStock(initDate, endDate);

                ParameterDiscreteValue prmstock = new ParameterDiscreteValue();
                prmstock.Value = ObjSummaryCellar.getStock(initDate, endDate);

                ParameterDiscreteValue prmdelivery = new ParameterDiscreteValue();
                prmdelivery.Value = ObjSummaryCellar.getDelivery(initDate, endDate);


                for (int i = 0; i < rptSummaryCellar.ParameterFields.Count; i++)
                {
                    switch (rptSummaryCellar.ParameterFields[i].Name)
                    {
                        case "mounth":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "initdate":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "SalesOrder":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmsalesorder);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmsalesorder);
                            break;

                        case "OutSalesOrder":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmoutsalesorder);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmoutsalesorder);
                            break;

                        case "OutStock":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmoutstock);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmoutstock);
                            break;

                        case "Stock":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmstock);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmstock);
                            break;

                        case "Delivery":
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryCellar.ParameterFields[i].CurrentValues.Add(prmdelivery);
                            rptSummaryCellar.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryCellar.ParameterFields[i].DefaultValues.Add(prmdelivery);
                            break;
                        default:
                            break;
                    }
                }
                crvSummaryCellar.ReportSource = rptSummaryCellar;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos Mensuales Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
