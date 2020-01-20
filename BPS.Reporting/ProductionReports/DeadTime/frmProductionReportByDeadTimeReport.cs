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


namespace BPS.Reporting.ProductionReports.DeadTime
{
    public partial class frmProductionReportByDeadTimeReport : Form
    {
        private int CodSecMachine;
        private string initDate;
        private string endDate;
        private string month;
        private string password;

        public frmProductionReportByDeadTimeReport()
        {
            InitializeComponent();
        }

        public frmProductionReportByDeadTimeReport(int CodSecMachine, string initDate, string endDate, string month, string password)
        {
            InitializeComponent();
            this.CodSecMachine = CodSecMachine;
            this.initDate = initDate;
            this.endDate = endDate;
            this.month = month;
            this.password = password;
        }

        private void frmProductionReportByDeadTimeReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
            setReportParametersDetails();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptProductionDeadTimeByDate1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProductionDeadTimeByDate1.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmMachineCodsec = new ParameterDiscreteValue();
                prmMachineCodsec.Value = CodSecMachine;

                ParameterField pfldMachineCodSec = new ParameterField();
                pfldMachineCodSec.Name = "fkMachine";
                pfldMachineCodSec.CurrentValues.Add(prmMachineCodsec);
                pfldMachineCodSec.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = initDate;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initDate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = endDate;

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "endDate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmMachineName = new ParameterDiscreteValue();
                prmMachineName.Value = month;

                ParameterField pfldMachineName = new ParameterField();
                pfldMachineName.Name = "Month";
                pfldMachineName.CurrentValues.Add(prmMachineName);
                pfldMachineName.HasCurrentValue = true;

                for (int i = 0; i < rptProductionDeadTimeByDate1.ParameterFields.Count; i++)
                {
                    switch (rptProductionDeadTimeByDate1.ParameterFields[i].Name)
                    {
                        case "fkMachine":
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Add(prmMachineCodsec);
                            rptProductionDeadTimeByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Add(prmMachineCodsec);
                            break;

                        case "InitDate":
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptProductionDeadTimeByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "EndDate":
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptProductionDeadTimeByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "Month":
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].CurrentValues.Add(prmMachineName);
                            rptProductionDeadTimeByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDate1.ParameterFields[i].DefaultValues.Add(prmMachineName);
                            break;

                        default:
                            break;
                    }
                    crvProductionReportByDeadTime.ParameterFieldInfo.Add(rptProductionDeadTimeByDate1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void setReportParametersDetails()
        {
            try
            {
                Tables tables;

                tables = rptProductionDeadTimeByDateDetails1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProductionDeadTimeByDateDetails1.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmMachineCodsec = new ParameterDiscreteValue();
                prmMachineCodsec.Value = CodSecMachine;

                ParameterField pfldMachineCodSec = new ParameterField();
                pfldMachineCodSec.Name = "fkMachine";
                pfldMachineCodSec.CurrentValues.Add(prmMachineCodsec);
                pfldMachineCodSec.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = initDate;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initDate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = endDate;

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "endDate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmMachineName = new ParameterDiscreteValue();
                prmMachineName.Value = month;

                ParameterField pfldMachineName = new ParameterField();
                pfldMachineName.Name = "Month";
                pfldMachineName.CurrentValues.Add(prmMachineName);
                pfldMachineName.HasCurrentValue = true;

                for (int i = 0; i < rptProductionDeadTimeByDateDetails1.ParameterFields.Count; i++)
                {
                    switch (rptProductionDeadTimeByDateDetails1.ParameterFields[i].Name)
                    {
                        case "fkMachine":
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Add(prmMachineCodsec);
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Add(prmMachineCodsec);
                            break;

                        case "InitDate":
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "EndDate":
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "Month":
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].CurrentValues.Add(prmMachineName);
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDeadTimeByDateDetails1.ParameterFields[i].DefaultValues.Add(prmMachineName);
                            break;

                        default:
                            break;
                    }
                    crvDeadTimeDetail.ParameterFieldInfo.Add(rptProductionDeadTimeByDateDetails1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
