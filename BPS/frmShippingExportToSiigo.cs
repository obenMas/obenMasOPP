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
using System.Drawing.Printing;
using BPS.Reports;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmShippingExportToSiigo : Form
    {
        string initDate, endDate = string.Empty;

        public frmShippingExportToSiigo()
        {
            InitializeComponent();
        }

        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            loadReports();
        }

        private void loadReports()
        {
            rptShippingExportToSiigo rptShippingExportToSiigo = new rptShippingExportToSiigo();
            TimeSpan initHour = new TimeSpan (00,00,00);
            TimeSpan endHour = new TimeSpan (23,59,59);
            initDate = dtpDate.Value.Date.Add(initHour).ToString("dd/MM/yyyy HH:mm:ss");
            endDate = dtpDate.Value.Date.Add(endHour).ToString("dd/MM/yyyy HH:mm:ss");

            Tables tables;

            tables = rptShippingExportToSiigo.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptShippingExportToSiigo.ReportDefinition.Sections;
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

            ParameterDiscreteValue prminitDate = new ParameterDiscreteValue();
            prminitDate.Value = Convert.ToDateTime(initDate);

            ParameterDiscreteValue prmendDate = new ParameterDiscreteValue();
            prmendDate.Value = Convert.ToDateTime(endDate);

            for (int i = 0; i < rptShippingExportToSiigo.ParameterFields.Count; i++)
            {
                switch (rptShippingExportToSiigo.ParameterFields[i].Name)
                {
                    case "inidate":
                        rptShippingExportToSiigo.ParameterFields[i].CurrentValues.Clear();
                        rptShippingExportToSiigo.ParameterFields[i].CurrentValues.Add(prminitDate);
                        rptShippingExportToSiigo.ParameterFields[i].HasCurrentValue = true;
                        rptShippingExportToSiigo.ParameterFields[i].DefaultValues.Clear();
                        rptShippingExportToSiigo.ParameterFields[i].DefaultValues.Add(prminitDate);
                        break;

                    case "enddate":
                        rptShippingExportToSiigo.ParameterFields[i].CurrentValues.Clear();
                        rptShippingExportToSiigo.ParameterFields[i].CurrentValues.Add(prmendDate);
                        rptShippingExportToSiigo.ParameterFields[i].HasCurrentValue = true;
                        rptShippingExportToSiigo.ParameterFields[i].DefaultValues.Clear();
                        rptShippingExportToSiigo.ParameterFields[i].DefaultValues.Add(prmendDate);
                        break;
                    default:
                        break;
                }
            }
            crvSalesOrderUnified.ReportSource = rptShippingExportToSiigo;
        }

        private void dtpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadReports();
        }
    }
}
