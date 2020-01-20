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
    public partial class frmProductionReportView : Form
    {
        private int CodMachine = 0;
        private DateTime InitDate = DateTime.Now;
        private DateTime EndDate = DateTime.Now;
        private string Inning = "";
        private double TotalConsumption = 0, DeadTimeTMP = 0, DeadTimeTMM = 0, DeadTimeTMOthers = 0, Efficiency = 0, Decrease = 0;

        public frmProductionReportView()
        {
            InitializeComponent();
        }

        public frmProductionReportView(int CodMachine, DateTime InitDate, DateTime EndDate, double TotalConsumption , double DeadTimeTMP, double DeadTimeTMM, double DeadTimeTMOthers, string Inning, double Efficiency, double Decrease)
        {
            InitializeComponent();
            this.CodMachine = CodMachine;
            this.InitDate = InitDate;
            this.EndDate = EndDate;
            this.TotalConsumption = TotalConsumption;
            this.DeadTimeTMP = DeadTimeTMP;
            this.DeadTimeTMM = DeadTimeTMM;
            this.DeadTimeTMOthers = DeadTimeTMOthers;
            this.Inning = Inning;
            this.Efficiency = Efficiency;
            this.Decrease = Decrease;
        }

        private void frmProductionReportView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptProductionReportSem1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProductionReportSem1.ReportDefinition.Sections;
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

                crvProductionReport.ParameterFieldInfo.Clear();
                
                ParameterDiscreteValue prmProductionReportCodsec = new ParameterDiscreteValue();
                prmProductionReportCodsec.Value = CodMachine;

                ParameterField pfldSalesOrderCodsec = new ParameterField();
                pfldSalesOrderCodsec.Name = "fkMachine";
                pfldSalesOrderCodsec.CurrentValues.Add(prmProductionReportCodsec);
                pfldSalesOrderCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = InitDate;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "InitDate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = EndDate;

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "EndDate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmTotalConsumption = new ParameterDiscreteValue();
                prmTotalConsumption.Value = TotalConsumption;

                ParameterField pfldTotalConsumption = new ParameterField();
                pfldTotalConsumption.Name = "Comsuption";
                pfldTotalConsumption.CurrentValues.Add(prmTotalConsumption);
                pfldTotalConsumption.HasCurrentValue = true;

                ParameterDiscreteValue prmDeadTimeTMP = new ParameterDiscreteValue();
                prmDeadTimeTMP.Value = DeadTimeTMP;

                ParameterField pfldDeadTimeTMP = new ParameterField();
                pfldDeadTimeTMP.Name = "TMP";
                pfldDeadTimeTMP.CurrentValues.Add(prmDeadTimeTMP);
                pfldDeadTimeTMP.HasCurrentValue = true;

                ParameterDiscreteValue prmDeadTimeTMM = new ParameterDiscreteValue();
                prmDeadTimeTMM.Value = DeadTimeTMM;

                ParameterField pfldDeadTimeTMM = new ParameterField();
                pfldDeadTimeTMM.Name = "TMM";
                pfldDeadTimeTMM.CurrentValues.Add(prmDeadTimeTMM);
                pfldDeadTimeTMM.HasCurrentValue = true;

                ParameterDiscreteValue prmDeadTimeTMOthers = new ParameterDiscreteValue();
                prmDeadTimeTMOthers.Value = DeadTimeTMOthers;

                ParameterField pfldDeadTimeTMOthers = new ParameterField();
                pfldDeadTimeTMOthers.Name = "TMOther";
                pfldDeadTimeTMOthers.CurrentValues.Add(prmDeadTimeTMOthers);
                pfldDeadTimeTMOthers.HasCurrentValue = true;

                ParameterDiscreteValue prmDecrease = new ParameterDiscreteValue();
                prmDecrease.Value = Decrease;

                ParameterField pfldDecrease = new ParameterField();
                pfldDecrease.Name = "Decrease";
                pfldDecrease.CurrentValues.Add(prmDecrease);
                pfldDecrease.HasCurrentValue = true;

                ParameterDiscreteValue prmEfficiency = new ParameterDiscreteValue();
                prmEfficiency.Value = Efficiency;

                ParameterField pfldEfficiency = new ParameterField();
                pfldEfficiency.Name = "Efficiency";
                pfldEfficiency.CurrentValues.Add(prmEfficiency);
                pfldEfficiency.HasCurrentValue = true;

                ParameterDiscreteValue prmInning = new ParameterDiscreteValue();
                prmInning.Value = Inning;

                ParameterField pfldInning = new ParameterField();
                pfldInning.Name = "Inning";
                pfldInning.CurrentValues.Add(prmInning);
                pfldInning.HasCurrentValue = true;

                for (int i = 0; i < rptProductionReportSem1.ParameterFields.Count; i++)
                {
                    switch (rptProductionReportSem1.ParameterFields[i].Name)
                    {
                        case "fkMachine":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmProductionReportCodsec);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmProductionReportCodsec);
                            break;

                        case "InitDate":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "EndDate":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "Comsuption":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmTotalConsumption);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmTotalConsumption);
                            break;

                        case "TMP":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmDeadTimeTMP);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmDeadTimeTMP);
                            break;

                        case "TMM":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmDeadTimeTMM);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmDeadTimeTMM);
                            break;

                        case "TMOther":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmDeadTimeTMOthers);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmDeadTimeTMOthers);
                            break;

                        case "Decrease":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmDecrease);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmDecrease);
                            break;

                        case "Efficiency":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmEfficiency);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmEfficiency);
                            break;

                        case "Inning":
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].CurrentValues.Add(prmInning);
                            rptProductionReportSem1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionReportSem1.ParameterFields[i].DefaultValues.Add(prmInning);
                            break;

                        default:
                            break;
                    }
                    crvProductionReport.ParameterFieldInfo.Add(rptProductionReportSem1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
