using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reporting.Mill;

namespace BPS
{
    public partial class frmSummaryReProcessByMill : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;
        String month = string.Empty;

        public frmSummaryReProcessByMill()
        {
            InitializeComponent();
            PopulateMill();
        }

        private void PopulateMill()
        {
            List<clsMill> lstMill = new List<clsMill>();
            cmbMill.Items.Clear();
            lstMill = clsMill.getListMill();
            for (int i = 0; i < lstMill.Count; i++)
                cmbMill.Items.Add(lstMill[i]);
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
                rptSummaryReProcessByMill rptSummaryMill = new rptSummaryReProcessByMill();
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

                clsSummaryCellar ObjSummaryCellar = new clsSummaryCellar();

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = endDate;

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = initDate;

                ParameterDiscreteValue prmmonth = new ParameterDiscreteValue();
                prmmonth.Value = GetFullNameMonth(dtpDate.Value);

                ParameterDiscreteValue prmoperation = new ParameterDiscreteValue();
                prmoperation.Value = "CutterAcumulated";

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = ((clsMill)cmbMill.SelectedItem).codsec;

                for (int i = 0; i < rptSummaryMill.ParameterFields.Count; i++)
                {
                    switch (rptSummaryMill.ParameterFields[i].Name)
                    {
                        //case "mydata":
                        //    rptSummaryMill.ParameterFields[i].CurrentValues.Clear();
                        //    rptSummaryMill.ParameterFields[i].CurrentValues.Add(prmmonth);
                        //    rptSummaryMill.ParameterFields[i].HasCurrentValue = true;
                        //    rptSummaryMill.ParameterFields[i].DefaultValues.Clear();
                        //    rptSummaryMill.ParameterFields[i].DefaultValues.Add(prmmonth);
                        //    break;

                        case "codsec":
                            rptSummaryMill.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryMill.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptSummaryMill.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryMill.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryMill.ParameterFields[i].DefaultValues.Add(prmcodsec);
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

                        default:
                            break;
                    }
                }
                crvSummaryExtruder.ReportSource = rptSummaryMill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimientos Mensuales Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cmbMill.SelectedIndex > -1)
            {
                FormatDate(dtpDate.Value);
                loadReports();
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un molino", "Molinos", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                cmbMill.Focus();
            }
        }
    }
}
