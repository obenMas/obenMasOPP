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
    public partial class frmFilmProductionReportDate : Form
    {
        public DateTime InitDate;
        public TimeSpan initHour = new TimeSpan(0, 0, 0);
        public String Date;

        public frmFilmProductionReportDate()
        {
            InitializeComponent();
        }

        public frmFilmProductionReportDate(DateTime InitDate)
        {
            InitializeComponent();
            Date = Convert.ToString(InitDate.Add(initHour));
            this.InitDate = Convert.ToDateTime(Date);
        }

        private void frmFilmProductionReportDate_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {

            try
            {
                Tables tables;

                tables = rptPlanificationReportDate1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPlanificationReportDate1.ReportDefinition.Sections;
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

                crvFilmProductionReportDate.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = InitDate.ToString("dd/MM/yyyy HH:mm:ss");

                ParameterField pfldinitdate = new ParameterField();
                pfldinitdate.Name = "initdate";
                pfldinitdate.CurrentValues.Add(prminitdate);
                pfldinitdate.HasCurrentValue = true;

                for (int i = 0; i < rptPlanificationReportDate1.ParameterFields.Count; i++)
                {
                    switch (rptPlanificationReportDate1.ParameterFields[i].Name)
                    {
                        case "initdate":
                            rptPlanificationReportDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPlanificationReportDate1.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptPlanificationReportDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPlanificationReportDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPlanificationReportDate1.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;
                        default:
                            break;
                    }
                    crvFilmProductionReportDate.ParameterFieldInfo.Add(rptPlanificationReportDate1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
