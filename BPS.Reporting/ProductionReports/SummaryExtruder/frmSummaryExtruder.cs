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

namespace BPS.Reporting.ProductionReports.SummaryExtruder
{
    public partial class frmSummaryExtruder : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty, endDate = string.Empty, month = string.Empty, password = string.Empty, machine = string.Empty;
        int machineCodsec = 0;

        public frmSummaryExtruder()
        {
            InitializeComponent();
        }

        public frmSummaryExtruder(string machine, string password, int machineCodsec)
        {
            InitializeComponent();
            this.machine = machine;
            this.password = password;
            this.machineCodsec = machineCodsec;
            this.Text = "Reporte de Producción Mensual de " + machine;
            tbcMain.TabPages.Clear();
            tbcMain.TabPages.Insert(0, tbpUnit);
            tbcMain.TabPages.Insert(1, tbpDetail);
            tbpUnit.Text = "Producción Unificada de "+machine;
            tbpDetail.Text = "Producción Detallada de "+machine;
        }

        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            FormatDate(dtpDate.Value);
            loadReports();
            loadReportsDetails();
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

        private void loadReports()
        {
            try
            {
                rptSummaryExtruderUnit rptSummaryExtruderUnit = new rptSummaryExtruderUnit();
                Tables tables;

                tables = rptSummaryExtruderUnit.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryExtruderUnit.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmmachine = new ParameterDiscreteValue();
                prmmachine.Value = machine;

                ParameterDiscreteValue prmfkmachine = new ParameterDiscreteValue();
                prmfkmachine.Value = machineCodsec;

                ParameterDiscreteValue prmoperation = new ParameterDiscreteValue();
                prmoperation.Value = "ExtruderMoth";

                for (int i = 0; i < rptSummaryExtruderUnit.ParameterFields.Count; i++)
                {
                    switch (rptSummaryExtruderUnit.ParameterFields[i].Name)
                    {
                        case "month":
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryExtruderUnit.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "fkMachine":
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Add(prmfkmachine);
                            rptSummaryExtruderUnit.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Add(prmfkmachine);
                            break;

                        case "operation":
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptSummaryExtruderUnit.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        case "machine":
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Add(prmmachine);
                            rptSummaryExtruderUnit.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Add(prmmachine);
                            break;

                        case "initdate":
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryExtruderUnit.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryExtruderUnit.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderUnit.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        default:
                            break;
                    }
                }
                crvSummaryExtruderUnit.ReportSource = rptSummaryExtruderUnit;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void loadReportsDetails()
        {
            try
            {
                rptSummaryExtruderDetails rptSummaryExtruderDetails = new rptSummaryExtruderDetails();
                Tables tables;

                tables = rptSummaryExtruderDetails.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryExtruderDetails.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmmachine = new ParameterDiscreteValue();
                prmmachine.Value = machine;

                ParameterDiscreteValue prmfkmachine = new ParameterDiscreteValue();
                prmfkmachine.Value = machineCodsec;

                ParameterDiscreteValue prmoperation = new ParameterDiscreteValue();
                prmoperation.Value = "ExtuderProduct";

                for (int i = 0; i < rptSummaryExtruderDetails.ParameterFields.Count; i++)
                {
                    switch (rptSummaryExtruderDetails.ParameterFields[i].Name)
                    {
                        case "month":
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Add(prmmonth);
                            rptSummaryExtruderDetails.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Add(prmmonth);
                            break;

                        case "fkMachine":
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Add(prmfkmachine);
                            rptSummaryExtruderDetails.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Add(prmfkmachine);
                            break;

                        case "operation":
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptSummaryExtruderDetails.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        case "machine":
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Add(prmmachine);
                            rptSummaryExtruderDetails.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Add(prmmachine);
                            break;

                        case "initdate":
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptSummaryExtruderDetails.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptSummaryExtruderDetails.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryExtruderDetails.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        default:
                            break;
                    }
                }
                crvSummaryExtruderDetails.ReportSource = rptSummaryExtruderDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
