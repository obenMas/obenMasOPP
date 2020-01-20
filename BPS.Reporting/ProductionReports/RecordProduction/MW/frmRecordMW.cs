using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared; 


namespace BPS.Reporting.ProductionReports.RecordProduction.MW
{
    public partial class frmRecordMW : Form
    {
        int codsec;
        string pass = string.Empty;
        public frmRecordMW()
        {
            InitializeComponent();
        }

        public frmRecordMW(int codsec, string password)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.pass = password;
        }

        private void frmRecordProductionReportView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptRecordMW1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptRecordMW1.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = pass;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                crystalReportViewer1.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "codsec";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                for (int i = 0; i < rptRecordMW1.ParameterFields.Count; i++)
                {
                    switch (rptRecordMW1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            pfldcodsec.CurrentValues.Add(prmcodsec);
                            rptRecordMW1.ParameterFields[i].CurrentValues.Clear();
                            rptRecordMW1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptRecordMW1.ParameterFields[i].HasCurrentValue = true;
                            rptRecordMW1.ParameterFields[i].DefaultValues.Clear();
                            rptRecordMW1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptRecordMW1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
