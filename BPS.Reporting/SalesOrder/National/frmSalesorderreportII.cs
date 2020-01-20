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

namespace BPS.Reporting.SalesOrder.National
{
    public partial class frmSalesorderreportII : Form
    {
        int codsec = 0;
        string pass = string.Empty;

        public frmSalesorderreportII()
        {
            InitializeComponent();
        }

        public frmSalesorderreportII(int codsec, string pass)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.pass = pass;
        }

        private void frmSalesorderreportII_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptSalesOrderReportShortSales1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderReportShortSales1.ReportDefinition.Sections;
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

                crvSalesOrder.ParameterFieldInfo.Clear();
                ParameterDiscreteValue prmSalesOrderCodsec = new ParameterDiscreteValue();
                prmSalesOrderCodsec.Value = codsec;

                ParameterField pfldSalesOrderCodsec = new ParameterField();
                pfldSalesOrderCodsec.Name = "codsec";
                pfldSalesOrderCodsec.CurrentValues.Add(prmSalesOrderCodsec);
                pfldSalesOrderCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptSalesOrderReportShortSales1.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderReportShortSales1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptSalesOrderReportShortSales1.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderReportShortSales1.ParameterFields[i].CurrentValues.Add(prmSalesOrderCodsec);
                            rptSalesOrderReportShortSales1.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderReportShortSales1.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderReportShortSales1.ParameterFields[i].DefaultValues.Add(prmSalesOrderCodsec);
                            break;

                        default:
                            break;
                    }
                    crvSalesOrder.ParameterFieldInfo.Add(rptSalesOrderReportShortSales1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
