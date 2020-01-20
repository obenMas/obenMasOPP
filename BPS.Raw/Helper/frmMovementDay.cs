using BPS.Bussiness;
using BPS.Raw.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Raw.Helper
{
    public partial class frmMovementDay : Form
    {
        TimeSpan inithour = new TimeSpan(08, 00, 00);
        TimeSpan endhour = new TimeSpan(20, 00, 00);

        public frmMovementDay()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (cmbIn.SelectedIndex > -1)
                loadReport(dptTime, cmbIn);
            else
            {
                MessageBox.Show("Debe ingresar al menos un turno");
                cmbIn.Focus();
            }
        }

        private void loadReport(DateTimePicker dptTime, ComboBox cmbIn)
        {
            try
            {
                rptExtruderDay rptExtruderDayList = new rptExtruderDay();
                rptExtruderDayDetail rptExtruderDayDetailList = new rptExtruderDayDetail();

                Tables tables;

                ParameterDiscreteValue prmOp = new ParameterDiscreteValue();
                prmOp.Value = "ListDayExtuder";

                ParameterDiscreteValue prmCodsec = new ParameterDiscreteValue();
                prmCodsec.Value = 0;

                ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
                prmCode.Value = "";

                ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
                prmInitdate.Value = getTimeValue("initdate", cmbIn.SelectedItem.ToString());

                ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
                prmEnddate.Value = getTimeValue("enddate", cmbIn.SelectedItem.ToString());

                ParameterDiscreteValue prmTur = new ParameterDiscreteValue();
                prmTur.Value = getTimeValue("turno", cmbIn.SelectedItem.ToString());

                for (int i = 0; i < rptExtruderDayList.ParameterFields.Count; i++)
                {
                    switch (rptExtruderDayList.ParameterFields[i].Name)
                    {
                        case "operation":
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Add(prmOp);
                            rptExtruderDayList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Add(prmOp);
                            break;

                        case "codsec":
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Add(prmCodsec);
                            rptExtruderDayList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Add(prmCodsec);
                            break;

                        case "code":
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Add(prmCode);
                            rptExtruderDayList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Add(prmCode);
                            break;

                        case "initdate":
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptExtruderDayList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;

                        case "enddate":
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Add(prmEnddate);
                            rptExtruderDayList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Add(prmEnddate);
                            break;

                        case "tur":
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayList.ParameterFields[i].CurrentValues.Add(prmTur);
                            rptExtruderDayList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayList.ParameterFields[i].DefaultValues.Add(prmTur);
                            break;

                        default:
                            break;
                    }
                }

                tables = rptExtruderDayList.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptExtruderDayList.ReportDefinition.Sections;
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

                tables = rptExtruderDayDetailList.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                sections = rptExtruderDayDetailList.ReportDefinition.Sections;
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

                for (int i = 0; i < rptExtruderDayDetailList.ParameterFields.Count; i++)
                {
                    switch (rptExtruderDayDetailList.ParameterFields[i].Name)
                    {
                        case "operation":
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Add(prmOp);
                            rptExtruderDayDetailList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Add(prmOp);
                            break;

                        case "codsec":
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Add(prmCodsec);
                            rptExtruderDayDetailList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Add(prmCodsec);
                            break;

                        case "code":
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Add(prmCode);
                            rptExtruderDayDetailList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Add(prmCode);
                            break;

                        case "initdate":
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptExtruderDayDetailList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;

                        case "enddate":
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Add(prmEnddate);
                            rptExtruderDayDetailList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Add(prmEnddate);
                            break;

                        case "tur":
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].CurrentValues.Add(prmTur);
                            rptExtruderDayDetailList.ParameterFields[i].HasCurrentValue = true;
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Clear();
                            rptExtruderDayDetailList.ParameterFields[i].DefaultValues.Add(prmTur);
                            break;

                        default:
                            break;
                    }
                }

                crvUnifiedPackingList.ReportSource = rptExtruderDayList;
                crvDetailedPackingList.ReportSource = rptExtruderDayDetailList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getTimeValue(string type, string inning)
        {
            if (type == "initdate" && inning == "Día")
                return dptTime.Value.Date.Add(inithour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (type == "enddate" && inning == "Día")
                return dptTime.Value.Date.Add(endhour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (type == "initdate" && inning == "Noche")
                return dptTime.Value.Date.Add(endhour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (type == "enddate" && inning == "Noche")
                return dptTime.Value.Date.AddDays(1).Add(inithour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (type == "turno" && inning == "Día")
                return inning;
            else if (type == "turno" && inning == "Noche")
                return inning;
            else
                return "";
        }
    }
}
