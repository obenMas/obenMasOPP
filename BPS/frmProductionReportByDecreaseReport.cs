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
    public partial class frmProductionReportByDecreaseReport : Form
    {
        private int CodSecMachine;
        private string initDate;
        private string endDate;
        private string month;
        public frmProductionReportByDecreaseReport()
        {
            InitializeComponent();
        }

        public frmProductionReportByDecreaseReport(int CodSecMachine, string initDate, string endDate, string month)
        {
            InitializeComponent();
            this.CodSecMachine = CodSecMachine;
            this.initDate = initDate;
            this.endDate = endDate;
            this.month = month;
        }

        private void frmProductionReportByDecreaseReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptProductionDecreaseByDate1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProductionDecreaseByDate1.ReportDefinition.Sections;
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

                crvProductionDecreaseReport.ParameterFieldInfo.Clear();

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

                for (int i = 0; i < rptProductionDecreaseByDate1.ParameterFields.Count; i++)
                {
                    switch (rptProductionDecreaseByDate1.ParameterFields[i].Name)
                    {
                        case "fkMachine":
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Add(prmMachineCodsec);
                            rptProductionDecreaseByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Add(prmMachineCodsec);
                            break;

                        case "InitDate":
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptProductionDecreaseByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "EndDate":
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptProductionDecreaseByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "Month":
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].CurrentValues.Add(prmMachineName);
                            rptProductionDecreaseByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionDecreaseByDate1.ParameterFields[i].DefaultValues.Add(prmMachineName);
                            break;

                        default:
                            break;
                    }
                    crvProductionDecreaseReport.ParameterFieldInfo.Add(rptProductionDecreaseByDate1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
