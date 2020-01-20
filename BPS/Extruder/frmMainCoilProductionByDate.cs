using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;
using BPS.Reporting.Extruder;

namespace BPS
{
    public partial class frmMainCoilProductionByDate : Form
    {
        public frmMainCoilProductionByDate()
        {
            InitializeComponent();
        }

        private void frmSummaryCutter_Load(object sender, EventArgs e)
        {
            List<clsMachine> lstMachines = new List<clsMachine>();
            lstMachines = clsMachine.getExtruderMachineList();
            for (int i = 0; i < lstMachines.Count; i++)
                cmbMachine.Items.Add(lstMachines[i]);
        }


        private void loadReports()
        {
            rptMainCoilByDate rptMainCoilByDate = new rptMainCoilByDate();
            Tables tables;

            tables = rptMainCoilByDate.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMainCoilByDate.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmProductionReportCodsec = new ParameterDiscreteValue();
            prmProductionReportCodsec.Value = ((clsMachine)cmbMachine.SelectedItem).codsec;

            ParameterField pfldSalesOrderCodsec = new ParameterField();
            pfldSalesOrderCodsec.Name = "fkMachine";
            pfldSalesOrderCodsec.CurrentValues.Add(prmProductionReportCodsec);
            pfldSalesOrderCodsec.HasCurrentValue = true;

            ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
            prmInitDate.Value = dtpInitDate.Value.ToString("dd/MM/yyyy HH:mm:ss");

            ParameterField pfldInitDate = new ParameterField();
            pfldInitDate.Name = "InitDate";
            pfldInitDate.CurrentValues.Add(prmInitDate);
            pfldInitDate.HasCurrentValue = true;

            ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
            prmEndDate.Value = dtpEndDate.Value.ToString("dd/MM/yyyy HH:mm:ss");

            ParameterField pfldEndDate = new ParameterField();
            pfldEndDate.Name = "EndDate";
            pfldEndDate.CurrentValues.Add(prmEndDate);
            pfldEndDate.HasCurrentValue = true;

            for (int i = 0; i < rptMainCoilByDate.ParameterFields.Count; i++)
            {
                switch (rptMainCoilByDate.ParameterFields[i].Name)
                {
                    case "fkMachine":
                        rptMainCoilByDate.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilByDate.ParameterFields[i].CurrentValues.Add(prmProductionReportCodsec);
                        rptMainCoilByDate.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilByDate.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilByDate.ParameterFields[i].DefaultValues.Add(prmProductionReportCodsec);
                        break;

                    case "InitDate":
                        rptMainCoilByDate.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilByDate.ParameterFields[i].CurrentValues.Add(prmInitDate);
                        rptMainCoilByDate.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilByDate.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilByDate.ParameterFields[i].DefaultValues.Add(prmInitDate);
                        break;

                    case "EndDate":
                        rptMainCoilByDate.ParameterFields[i].CurrentValues.Clear();
                        rptMainCoilByDate.ParameterFields[i].CurrentValues.Add(prmEndDate);
                        rptMainCoilByDate.ParameterFields[i].HasCurrentValue = true;
                        rptMainCoilByDate.ParameterFields[i].DefaultValues.Clear();
                        rptMainCoilByDate.ParameterFields[i].DefaultValues.Add(prmEndDate);
                        break;
                    default:
                        break;
                }
            }
            crvSummaryCutter.ReportSource = rptMainCoilByDate;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            loadReports();
        }
    }
}
