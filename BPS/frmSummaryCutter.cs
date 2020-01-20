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
    public partial class frmSummaryCutter : Form
    {
        public frmSummaryCutter()
        {
            InitializeComponent();
        }

        private void frmSummaryCutter_Load(object sender, EventArgs e)
        {
            FillDataCuuter();
        }

        private void FillDataCuuter()
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            lstMachines = clsMachine.getCutterMachineList();
            cmbCutter.Items.Clear();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbCutter.Items.Add(lstMachines[i]);
        }

        private void cmbCutter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadReports();
        }

        private void loadReports()
        {
            rptCuttingOrderList rptCuttingOrderList = new Reports.rptCuttingOrderList();
            Tables tables;

            tables = rptCuttingOrderList.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptCuttingOrderList.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmTransportCodsec = new ParameterDiscreteValue();
            prmTransportCodsec.Value = ((clsMachine)cmbCutter.SelectedItem).codsec;

            for (int i = 0; i < rptCuttingOrderList.ParameterFields.Count; i++)
            {
                switch (rptCuttingOrderList.ParameterFields[i].Name)
                {
                    case "machineCodsec":
                        rptCuttingOrderList.ParameterFields[i].CurrentValues.Clear();
                        rptCuttingOrderList.ParameterFields[i].CurrentValues.Add(prmTransportCodsec);
                        rptCuttingOrderList.ParameterFields[i].HasCurrentValue = true;
                        rptCuttingOrderList.ParameterFields[i].DefaultValues.Clear();
                        rptCuttingOrderList.ParameterFields[i].DefaultValues.Add(prmTransportCodsec);
                        break;
                    default:
                        break;
                }
            }
            crvSummaryCutter.ReportSource = rptCuttingOrderList;
        }
    }
}
