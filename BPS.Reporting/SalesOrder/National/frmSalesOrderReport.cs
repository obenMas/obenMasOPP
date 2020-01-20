using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS.Reporting.SalesOrder.National
{
    public partial class frmSalesOrderReport : Form
    {
        int salesOrderCodsec = 0;
        string pass = string.Empty;

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptSalesOrderReportShort2.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderReportShort2.ReportDefinition.Sections;
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

                crvSalesOrderReport.ParameterFieldInfo.Clear();
                ParameterDiscreteValue prmSalesOrderCodsec = new ParameterDiscreteValue();
                prmSalesOrderCodsec.Value = salesOrderCodsec;

                ParameterField pfldSalesOrderCodsec = new ParameterField();
                pfldSalesOrderCodsec.Name = "codsec";
                pfldSalesOrderCodsec.CurrentValues.Add(prmSalesOrderCodsec);
                pfldSalesOrderCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptSalesOrderReportShort2.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderReportShort2.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptSalesOrderReportShort2.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderReportShort2.ParameterFields[i].CurrentValues.Add(prmSalesOrderCodsec);
                            rptSalesOrderReportShort2.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderReportShort2.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderReportShort2.ParameterFields[i].DefaultValues.Add(prmSalesOrderCodsec);

                            break;

                        default:
                            break;
                    }
                    crvSalesOrderReport.ParameterFieldInfo.Add(rptSalesOrderReportShort2.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public frmSalesOrderReport()
        {
            InitializeComponent();
        }
        public frmSalesOrderReport(int salesOrderCodsec, string pass)
        {
            InitializeComponent();
            this.salesOrderCodsec = salesOrderCodsec;
            this.pass = pass;
        }
        private void frmSalesOrderReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
