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
    public partial class frmCuttingOrderPositionSummaryDateReport : Form
    {
        TimeSpan initHour = new TimeSpan(0, 0, 0);
        TimeSpan endHour = new TimeSpan(23, 59, 59);
        String initDate = string.Empty;
        String endDate = string.Empty;

        public frmCuttingOrderPositionSummaryDateReport()
        {
            InitializeComponent();
            FillCutter();
        }

        private void FillCutter()
        {
            List<clsCutter> lstCutter = new List<clsCutter>();
            lstCutter = clsCutter.getList();
            cmbCutter.Items.Clear();
            for (int i = 0; i < lstCutter.Count; i++)
                cmbCutter.Items.Add(lstCutter[i]);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cmbCutter.SelectedIndex > -1)
                loadReports((((clsCutter)cmbCutter.SelectedItem).codsec), dtpInitDate.Value, dtpEndDate.Value);
            else
            {
                MessageBox.Show("Debe seleccionar una por lo menos una cortadora", "Ordenes de Corte", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCutter.Focus();
            }
        }

        private void loadReports(int codsec, DateTime InitDate, DateTime EndDate)
        {
            int machine = 0;
            initDate = Convert.ToString(InitDate.Date.Add(initHour));
            endDate = Convert.ToString(EndDate.Date.Add(endHour));
            rptCuttingOrderSumaryDate rptCuttingOrder = new rptCuttingOrderSumaryDate();
            machine = clsMachine.getCutterCodsec(codsec);
            Tables tables;

            tables = rptCuttingOrder.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptCuttingOrder.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
            prmenddate.Value = endDate;
            ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
            prminitdate.Value = initDate;
            ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
            prmcodsec.Value = machine;

            for (int i = 0; i < rptCuttingOrder.ParameterFields.Count; i++)
            {
                switch (rptCuttingOrder.ParameterFields[i].Name)
                {
                    case "fkmachine":
                        rptCuttingOrder.ParameterFields[i].CurrentValues.Clear();
                        rptCuttingOrder.ParameterFields[i].CurrentValues.Add(prmcodsec);
                        rptCuttingOrder.ParameterFields[i].HasCurrentValue = true;
                        rptCuttingOrder.ParameterFields[i].DefaultValues.Clear();
                        rptCuttingOrder.ParameterFields[i].DefaultValues.Add(prmcodsec);
                        break;

                    case "dateinit":
                        rptCuttingOrder.ParameterFields[i].CurrentValues.Clear();
                        rptCuttingOrder.ParameterFields[i].CurrentValues.Add(prminitdate);
                        rptCuttingOrder.ParameterFields[i].HasCurrentValue = true;
                        rptCuttingOrder.ParameterFields[i].DefaultValues.Clear();
                        rptCuttingOrder.ParameterFields[i].DefaultValues.Add(prminitdate);
                        break;

                    case "dateend":
                        rptCuttingOrder.ParameterFields[i].CurrentValues.Clear();
                        rptCuttingOrder.ParameterFields[i].CurrentValues.Add(prmenddate);
                        rptCuttingOrder.ParameterFields[i].HasCurrentValue = true;
                        rptCuttingOrder.ParameterFields[i].DefaultValues.Clear();
                        rptCuttingOrder.ParameterFields[i].DefaultValues.Add(prmenddate);
                        break;
                    default:
                        break;
                }
            }
            crvCuttingOrder.ReportSource = rptCuttingOrder;
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbCutter.SelectedItem = -1;
            dtpInitDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cmbCutter.Focus();
        }
    }
}
