using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS.Reporting.Metal.MainCoilQualityReportMetal
{
    public partial class frmMainCoilQualityReportMetalCut : Form
    {
        int codsec = 0;
        string pass = string.Empty;

        private void setReportParameters()
        {
            Tables tables;
            tables = rptMainCoilQualityMetalCut1.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = pass;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMainCoilQualityMetalCut1.ReportDefinition.Sections;
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
                            tableLogonInfo.ConnectionInfo.Password = pass;
                            table.ApplyLogOnInfo(tableLogonInfo);
                        }
                    }
                }
            }

            crvQualityReport.ParameterFieldInfo.Clear();

            ParameterDiscreteValue prmProductionReportCodsec = new ParameterDiscreteValue();
            prmProductionReportCodsec.Value = codsec;

            ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
            prmInitDate.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
            prmEndDate.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            ParameterDiscreteValue prmTotalConsumption = new ParameterDiscreteValue();
            prmTotalConsumption.Value = "Alfa";

            ParameterDiscreteValue prmDeadTimeTMP = new ParameterDiscreteValue();
            prmDeadTimeTMP.Value = "MainCoilMetalReport";

            for (int i = 0; i < rptMainCoilQualityMetalCut1.ParameterFields.Count; i++)
            {
                switch (rptMainCoilQualityMetalCut1.ParameterFields[i].Name)
                {
                    case "codsec":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmProductionReportCodsec);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmProductionReportCodsec);
                        break;

                    case "initDate":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                        break;

                    case "endDate":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                        break;

                    case "code":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmTotalConsumption);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmTotalConsumption);
                        break;

                    case "operation":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmDeadTimeTMP);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmDeadTimeTMP);
                        break;

                    case "Pm-?codsec":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmProductionReportCodsec);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmProductionReportCodsec);
                        break;

                    case "Pm-?endDate":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                        break;

                    case "Pm-?initDate":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                        break;

                    case "Pm-?code":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmTotalConsumption);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmTotalConsumption);
                        break;

                    case "Pm-?operation":
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].CurrentValues.Add(prmDeadTimeTMP);
                        rptMainCoilQualityMetalCut1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetalCut1.ParameterFields[i].DefaultValues.Add(prmDeadTimeTMP);
                        break;

                    default:
                        break;
                }
                crvQualityReport.ParameterFieldInfo.Add(rptMainCoilQualityMetalCut1.ParameterFields[i]);
            }
        }

        public frmMainCoilQualityReportMetalCut()
        {
            InitializeComponent();
        }
        public frmMainCoilQualityReportMetalCut(int mainCoilCodsec, string pass)
        {
            InitializeComponent();
            this.codsec = mainCoilCodsec;
            this.pass = pass;
        }

        private void frmMainCoilQualityReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
