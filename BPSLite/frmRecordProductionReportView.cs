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

namespace BPS.Lite
{
    public partial class frmRecordProductionReportView : Form
    {
        int codsec;
        public frmRecordProductionReportView()
        {
            InitializeComponent();
        }

        public frmRecordProductionReportView(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
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

                tables = rptRecordProductionDMT1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptRecordProductionDMT1.ReportDefinition.Sections;
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

                crpRecordProductionDMT.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "codsec";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                for (int i = 0; i < rptRecordProductionDMT1.ParameterFields.Count; i++)
                {
                    switch (rptRecordProductionDMT1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            pfldcodsec.CurrentValues.Add(prmcodsec);
                            rptRecordProductionDMT1.ParameterFields[i].CurrentValues.Clear();
                            rptRecordProductionDMT1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptRecordProductionDMT1.ParameterFields[i].HasCurrentValue = true;
                            rptRecordProductionDMT1.ParameterFields[i].DefaultValues.Clear();
                            rptRecordProductionDMT1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        default:
                            break;
                    }
                    crpRecordProductionDMT.ParameterFieldInfo.Add(rptRecordProductionDMT1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
