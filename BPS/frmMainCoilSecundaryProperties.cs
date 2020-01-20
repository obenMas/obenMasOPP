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
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilSecundaryProperties : Form
    {
        int codsec = 0;

        public frmMainCoilSecundaryProperties()
        {
            InitializeComponent();
        }

        public frmMainCoilSecundaryProperties(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
        }

        private void frmMainCoilSecundaryProperties_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
        private void setReportParameters()
        {
            Tables tables;
            tables = rptMainCoilQualitySecundaryProperties1.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMainCoilQualitySecundaryProperties1.ReportDefinition.Sections;
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

            crvSecundaryProperties.ParameterFieldInfo.Clear();

            ParameterDiscreteValue prmMainCoilCodsec = new ParameterDiscreteValue();
            prmMainCoilCodsec.Value = codsec;

            ParameterField pfldMainCoilCodsec = new ParameterField();
            pfldMainCoilCodsec.Name = "mainCoilCodsec";
            pfldMainCoilCodsec.CurrentValues.Add(prmMainCoilCodsec);
            pfldMainCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptMainCoilQualitySecundaryProperties1.ParameterFields.Count; i++)
            {
                switch (rptMainCoilQualitySecundaryProperties1.ParameterFields[i].Name)
                {
                    case "mainCoilCodsec":
                        rptMainCoilQualitySecundaryProperties1.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQualitySecundaryProperties1.ParameterFields[i].CurrentValues.Add(prmMainCoilCodsec);
                        rptMainCoilQualitySecundaryProperties1.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQualitySecundaryProperties1.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQualitySecundaryProperties1.ParameterFields[i].DefaultValues.Add(prmMainCoilCodsec);
                        break;

                    default:
                        break;
                }
                crvSecundaryProperties.ParameterFieldInfo.Add(rptMainCoilQualitySecundaryProperties1.ParameterFields[i]);
            }
        }
    }
}