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
using BPS.Reports;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPlanificationFull : Form
    {
        private TimeSpan initHour = new TimeSpan(0, 0, 0);
        private String initdate = string.Empty;

        public frmPlanificationFull()
        {
            InitializeComponent();
        }

        private void dtpPlanification_CloseUp(object sender, EventArgs e)
        {
            initdate = Convert.ToString(dtpPlanification.Value.Add(initHour));
            loadReports();
        }

        private void loadReports()
        {

            rptPlanificationShort rptPlanificationShortList = new rptPlanificationShort();

            Tables tables;

            ParameterDiscreteValue prminitDate = new ParameterDiscreteValue();
            prminitDate.Value = Convert.ToDateTime(initdate);

            for (int i = 0; i < rptPlanificationShortList.ParameterFields.Count; i++)
            {
                switch (rptPlanificationShortList.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptPlanificationShortList.ParameterFields[i].CurrentValues.Clear();
                        rptPlanificationShortList.ParameterFields[i].CurrentValues.Add(prminitDate);
                        rptPlanificationShortList.ParameterFields[i].HasCurrentValue = true;
                        rptPlanificationShortList.ParameterFields[i].DefaultValues.Clear();
                        rptPlanificationShortList.ParameterFields[i].DefaultValues.Add(prminitDate);
                        break;
                    default:
                        break;
                }
            }

            tables = rptPlanificationShortList.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptPlanificationShortList.ReportDefinition.Sections;
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

            rptPlanificationFull rptPlanificationList = new rptPlanificationFull();

            for (int i = 0; i < rptPlanificationList.ParameterFields.Count; i++)
            {
                switch (rptPlanificationList.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptPlanificationList.ParameterFields[i].CurrentValues.Clear();
                        rptPlanificationList.ParameterFields[i].CurrentValues.Add(prminitDate);
                        rptPlanificationList.ParameterFields[i].HasCurrentValue = true;
                        rptPlanificationList.ParameterFields[i].DefaultValues.Clear();
                        rptPlanificationList.ParameterFields[i].DefaultValues.Add(prminitDate);
                        break;
                    default:
                        break;
                }
            }
            tables = rptPlanificationList.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sectionss = rptPlanificationList.ReportDefinition.Sections;
            foreach (Section section in sectionss)
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
                        if (subReportDocument.Name == "rptPlanificationShort.rpt")
                        {
                            ParameterDiscreteValue prminitDateShort = new ParameterDiscreteValue();
                            prminitDateShort.Value = Convert.ToDateTime(initdate);

                            for (int i = 0; i < rptPlanificationList.ParameterFields.Count; i++)
                            {
                                switch (rptPlanificationList.ParameterFields[i].Name)
                                {
                                    case "initdate":
                                        rptPlanificationList.ParameterFields[i].CurrentValues.Clear();
                                        rptPlanificationList.ParameterFields[i].CurrentValues.Add(prminitDateShort);
                                        rptPlanificationList.ParameterFields[i].HasCurrentValue = true;
                                        rptPlanificationList.ParameterFields[i].DefaultValues.Clear();
                                        rptPlanificationList.ParameterFields[i].DefaultValues.Add(prminitDateShort);
                                        break;
                                    default:
                                        break;
                                }
                            }

                            //ParameterDiscreteValue prminitDate = new ParameterDiscreteValue();
                            //prminitDate.Value = Convert.ToDateTime(initdate);

                            //for (int i = 0; i < rptPlanificationShortList.ParameterFields.Count; i++)
                            //{
                            //    switch (rptPlanificationShortList.ParameterFields[i].Name)
                            //    {
                            //        case "initdate":
                            //            rptPlanificationShortList.ParameterFields[i].CurrentValues.Clear();
                            //            rptPlanificationShortList.ParameterFields[i].CurrentValues.Add(prminitDate);
                            //            rptPlanificationShortList.ParameterFields[i].HasCurrentValue = true;
                            //            rptPlanificationShortList.ParameterFields[i].DefaultValues.Clear();
                            //            rptPlanificationShortList.ParameterFields[i].DefaultValues.Add(prminitDate);
                            //            break;
                            //        default:
                            //            break;
                            //    }
                            //}
                        }
                    }
                }
            }

            crvPlanification.ReportSource = rptPlanificationList;
        }
    }
}
