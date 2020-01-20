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
    public partial class frmMainCoilQualityReportPL : Form
    {
        clsMainCoil objMainCoil = new clsMainCoil();
        clsMainCoilQuality ObjMainQuantity = new clsMainCoilQuality();

        private void setReportParameters()
        {
            Tables tables;
            tables = rptMainCoilQuality4.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMainCoilQuality4.ReportDefinition.Sections;
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

            crvQualityReport.ParameterFieldInfo.Clear();

            ParameterDiscreteValue prmMainCoilCodsec = new ParameterDiscreteValue();
            prmMainCoilCodsec.Value = objMainCoil.codsec;

            ParameterField pfldMainCoilCodsec = new ParameterField();
            pfldMainCoilCodsec.Name = "FkMainCoil";
            pfldMainCoilCodsec.CurrentValues.Add(prmMainCoilCodsec);
            pfldMainCoilCodsec.HasCurrentValue = true;

            ParameterDiscreteValue prmMainQuantity = new ParameterDiscreteValue();
            prmMainQuantity.Value = ObjMainQuantity.codsec;

            ParameterField pfldMainQuantity = new ParameterField();
            pfldMainQuantity.Name = "fkMainQuantity";
            pfldMainQuantity.CurrentValues.Add(prmMainQuantity);
            pfldMainQuantity.HasCurrentValue = true;

            ParameterDiscreteValue prmCodsec = new ParameterDiscreteValue();
            prmCodsec.Value = ObjMainQuantity.codsec;

            ParameterField pfldCodsec = new ParameterField();
            pfldCodsec.Name = "Codsec";
            pfldCodsec.CurrentValues.Add(prmCodsec);
            pfldCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptMainCoilQuality4.ParameterFields.Count; i++)
            {
                switch (rptMainCoilQuality4.ParameterFields[i].Name)
                {
                    case "FkMainCoil":
                        rptMainCoilQuality4.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQuality4.ParameterFields[i].CurrentValues.Add(prmMainCoilCodsec);
                        rptMainCoilQuality4.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQuality4.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQuality4.ParameterFields[i].DefaultValues.Add(prmMainCoilCodsec);
                        break;

                    case "fkMainQuantity":
                        rptMainCoilQuality4.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQuality4.ParameterFields[i].CurrentValues.Add(prmMainQuantity);
                        rptMainCoilQuality4.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQuality4.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQuality4.ParameterFields[i].DefaultValues.Add(prmMainQuantity);
                        break;

                    case "Codsec":
                        rptMainCoilQuality4.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilQuality4.ParameterFields[i].CurrentValues.Add(prmCodsec);
                        rptMainCoilQuality4.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilQuality4.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilQuality4.ParameterFields[i].DefaultValues.Add(prmCodsec);
                        break;

                    default:
                        break;
                }
                crvQualityReport.ParameterFieldInfo.Add(rptMainCoilQuality4.ParameterFields[i]);
            }
        }
        public frmMainCoilQualityReportPL()
        {
            InitializeComponent();
        }
        public frmMainCoilQualityReportPL(int mainCoilCodsec)
        {
            InitializeComponent();
            objMainCoil.load(mainCoilCodsec);
            ObjMainQuantity.loadByQuantity(mainCoilCodsec);
        }

        private void frmMainCoilQualityReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
