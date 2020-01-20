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
    public partial class frmFilmProductionReportNow : Form
    {
        public int codsec = 0;
        public frmFilmProductionReportNow()
        {
            InitializeComponent();
        }

        public frmFilmProductionReportNow(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
        }

        private void frmFilmProductionReportNow_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPlanificationReportNow1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPlanificationReportNow1.ReportDefinition.Sections;
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

                crvFilmProductionSaleOrdersNow.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "fpo_fkMachine";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPlanificationReportNow1.ParameterFields.Count; i++)
                {
                    switch (rptPlanificationReportNow1.ParameterFields[i].Name)
                    {
                        case "fpo_fkMachine":
                            rptPlanificationReportNow1.ParameterFields[i].CurrentValues.Clear();
                            rptPlanificationReportNow1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptPlanificationReportNow1.ParameterFields[i].HasCurrentValue = true;
                            rptPlanificationReportNow1.ParameterFields[i].DefaultValues.Clear();
                            rptPlanificationReportNow1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;
                        default:
                            break;
                    }
                    crvFilmProductionSaleOrdersNow.ParameterFieldInfo.Add(rptPlanificationReportNow1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
