using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;
using BPS.Reporting.Cellar;

namespace BPS
{
    public partial class frmCellarShipping : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate, endDate = string.Empty;

        public frmCellarShipping()
        {
            InitializeComponent();
        }

        private void loadReports()
        {

            rptCellarShippingUnified rptUnifiedCellarShipping = new rptCellarShippingUnified();
            rptCellarShippingFull rptCellarShippingFull = new rptCellarShippingFull();
            Tables tables;

            initDate = Convert.ToString(dtpDate.Value.Date.Add(initHour));
            endDate = Convert.ToString(dtpDate.Value.Date.Add(endHour));
            ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
            prmenddate.Value = endDate;
            ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
            prminitdate.Value = initDate;

            for (int i = 0; i < rptUnifiedCellarShipping.ParameterFields.Count; i++)
            {
                switch (rptUnifiedCellarShipping.ParameterFields[i].Name)
                {
                    case "initDate":
                        rptUnifiedCellarShipping.ParameterFields[i].CurrentValues.Clear();
                        rptUnifiedCellarShipping.ParameterFields[i].CurrentValues.Add(prminitdate);
                        rptUnifiedCellarShipping.ParameterFields[i].HasCurrentValue = true;
                        rptUnifiedCellarShipping.ParameterFields[i].DefaultValues.Clear();
                        rptUnifiedCellarShipping.ParameterFields[i].DefaultValues.Add(prminitdate);
                        break;

                    case "endDate":
                        rptUnifiedCellarShipping.ParameterFields[i].CurrentValues.Clear();
                        rptUnifiedCellarShipping.ParameterFields[i].CurrentValues.Add(prmenddate);
                        rptUnifiedCellarShipping.ParameterFields[i].HasCurrentValue = true;
                        rptUnifiedCellarShipping.ParameterFields[i].DefaultValues.Clear();
                        rptUnifiedCellarShipping.ParameterFields[i].DefaultValues.Add(prmenddate);
                        break;
                    default:
                        break;
                }
            }
            tables = rptUnifiedCellarShipping.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptUnifiedCellarShipping.ReportDefinition.Sections;
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

            tables = rptCellarShippingFull.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            sections = rptCellarShippingFull.ReportDefinition.Sections;
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

            for (int i = 0; i < rptCellarShippingFull.ParameterFields.Count; i++)
            {
                if (i <= 1)
                {
                    switch (rptCellarShippingFull.ParameterFields[i].Name)
                    {
                        case "initDate":
                            rptCellarShippingFull.ParameterFields[i].CurrentValues.Clear();
                            rptCellarShippingFull.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptCellarShippingFull.ParameterFields[i].HasCurrentValue = true;
                            rptCellarShippingFull.ParameterFields[i].DefaultValues.Clear();
                            rptCellarShippingFull.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "endDate":
                            rptCellarShippingFull.ParameterFields[i].CurrentValues.Clear();
                            rptCellarShippingFull.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptCellarShippingFull.ParameterFields[i].HasCurrentValue = true;
                            rptCellarShippingFull.ParameterFields[i].DefaultValues.Clear();
                            rptCellarShippingFull.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;
                        default:
                            break;
                    }
                }
                else
                    break;
            }

            crvUnified.ReportSource = rptUnifiedCellarShipping;
            crvFull.ReportSource = rptCellarShippingFull;
        }

        private void btnReportProduct_Click(object sender, EventArgs e)
        {
            loadReports();
        }

        private void btnMaquile_Click(object sender, EventArgs e)
        {
            loadReportsMaquile();
        }

        private void loadReportsMaquile()
        {
            rptMaquileShipping rptMetalizedPressionDeadTime = new rptMaquileShipping();

            Tables tables;

            tables = rptMetalizedPressionDeadTime.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMetalizedPressionDeadTime.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
            prmInitdate.Value = GenerateDateValue("Maquile", "initdate");

            ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
            prmEnddate.Value = GenerateDateValue("Maquile", "enddate");

            ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
            prmOperation.Value = "MaquileShipping";

            ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
            prmCode.Value = "MaquileShipping";

            ParameterDiscreteValue prmCodsec = new ParameterDiscreteValue();
            prmCodsec.Value = 1;

            for (int i = 0; i < rptMetalizedPressionDeadTime.ParameterFields.Count; i++)
            {
                switch (rptMetalizedPressionDeadTime.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmInitdate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmInitdate);
                        break;
                    case "enddate":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmEnddate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmEnddate);
                        break;
                    case "operation":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmOperation);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmOperation);
                        break;
                    case "code":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmCode);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmCode);
                        break;
                    case "codsec":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmCodsec);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmCodsec);
                        break;
                    default:
                        break;
                }
            }

            crvMaquile.ReportSource = rptMetalizedPressionDeadTime;
        }

        private string GenerateDateValue(string source, string type)
        {
            if (source == "Maquile" && type == "initdate")
                return dtpTime.Value.Date.Add(initHour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (source == "Maquile" && type == "enddate")
                return dtpTime.Value.Date.Add(endHour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (source == "Mill" && type == "initdate")
                return dtpTimeMill.Value.Date.Add(initHour).ToString("dd/MM/yyyy HH:mm:ss");
            else if (source == "Mill" && type == "enddate")
                return dtpTimeMill.Value.Date.Add(endHour).ToString("dd/MM/yyyy HH:mm:ss");
            else
                return "";
        }

        private void btnMill_Click(object sender, EventArgs e)
        {
            loadReportsMill();
        }

        private void loadReportsMill()
        {
            rptMillShipping rptMetalizedPressionDeadTime = new rptMillShipping();

            Tables tables;

            tables = rptMetalizedPressionDeadTime.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMetalizedPressionDeadTime.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
            prmInitdate.Value = GenerateDateValue("Mill", "initdate");

            ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
            prmEnddate.Value = GenerateDateValue("Mill", "enddate");

            ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
            prmOperation.Value = "MillReport";

            ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
            prmCode.Value = "Erwin";

            ParameterDiscreteValue prmCodsec = new ParameterDiscreteValue();
            prmCodsec.Value = 1;

            ParameterDiscreteValue prmIn = new ParameterDiscreteValue();
            prmIn.Value = 0;

            ParameterDiscreteValue prmOut = new ParameterDiscreteValue();
            prmOut.Value = 0;

            ParameterDiscreteValue prmDevolution = new ParameterDiscreteValue();
            prmDevolution.Value = 0;

            for (int i = 0; i < rptMetalizedPressionDeadTime.ParameterFields.Count; i++)
            {
                switch (rptMetalizedPressionDeadTime.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmInitdate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmInitdate);
                        break;
                    case "enddate":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmEnddate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmEnddate);
                        break;
                    case "operation":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmOperation);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmOperation);
                        break;
                    case "code":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmCode);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmCode);
                        break;
                    case "codsec":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmCodsec);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmCodsec);
                        break;

                    case "in":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmIn);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmIn);
                        break;
                    case "out":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmOut);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmOut);
                        break;
                    case "devolution":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmDevolution);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmDevolution);
                        break;
                    default:
                        break;
                }
            }

            crvMill.ReportSource = rptMetalizedPressionDeadTime;
        }
    }
}
