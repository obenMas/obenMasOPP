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

namespace BPS.Reporting.Metal.MainCoilQualityReportMetalCut
{
    public partial class frmMainCoilQualityReportMetal : Form
    {
        int codsec = 0;
        string pass = string.Empty;

        private void setReportParameters()
        {
            Tables tables;
            tables = rptMainCoilQualityMetal1.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = pass;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMainCoilQualityMetal1.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmMainCoilCodsec = new ParameterDiscreteValue();
            prmMainCoilCodsec.Value = codsec;

            ParameterField pfldMainCoilCodsec = new ParameterField();
            pfldMainCoilCodsec.Name = "Codsec";
            pfldMainCoilCodsec.CurrentValues.Add(prmMainCoilCodsec);
            pfldMainCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptMainCoilQualityMetal1.ParameterFields.Count; i++)
            {
                switch (rptMainCoilQualityMetal1.ParameterFields[i].Name)
                {
                    case "Codsec":
                        rptMainCoilQualityMetal1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualityMetal1.ParameterFields[i].CurrentValues.Add(prmMainCoilCodsec);
                        rptMainCoilQualityMetal1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualityMetal1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualityMetal1.ParameterFields[i].DefaultValues.Add(prmMainCoilCodsec);
                        break;

                    default:
                        break;
                }
                crvQualityReport.ParameterFieldInfo.Add(rptMainCoilQualityMetal1.ParameterFields[i]);
            }
        }

        public frmMainCoilQualityReportMetal()
        {
            InitializeComponent();
        }
        public frmMainCoilQualityReportMetal(int mainCoilCodsec, string pass)
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
