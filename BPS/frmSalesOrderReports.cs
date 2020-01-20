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
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSalesOrderReports : Form
    {
        public int salesOrderCodsec = 0;

        public frmSalesOrderReports()
        {
            InitializeComponent();
        }

        public frmSalesOrderReports(int codsec)
        {
            InitializeComponent();
            this.salesOrderCodsec = codsec;
        }

        private void frmSalesOrderReports_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptSalesOrderReports1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderReports1.ReportDefinition.Sections;
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

                crvSalesOrderReport.ParameterFieldInfo.Clear();
                ParameterDiscreteValue prmSalesOrderCodsec = new ParameterDiscreteValue();
                prmSalesOrderCodsec.Value = salesOrderCodsec;

                ParameterField pfldSalesOrderCodsec = new ParameterField();
                pfldSalesOrderCodsec.Name = "salesOrderCodsec";
                pfldSalesOrderCodsec.CurrentValues.Add(prmSalesOrderCodsec);
                pfldSalesOrderCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptSalesOrderReports1.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderReports1.ParameterFields[i].Name)
                    {
                        case "salesOrderCodsec":
                            rptSalesOrderReports1.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderReports1.ParameterFields[i].CurrentValues.Add(prmSalesOrderCodsec);
                            rptSalesOrderReports1.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderReports1.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderReports1.ParameterFields[i].DefaultValues.Add(prmSalesOrderCodsec);
                            break;
                        
                        default:
                            break;
                    }
                    crvSalesOrderReport.ParameterFieldInfo.Add(rptSalesOrderReports1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
