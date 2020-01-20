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
    public partial class frmRecordProductionMwView : Form
    {
        int codsec;
        
        public frmRecordProductionMwView()
        {
            InitializeComponent();
        }
        
        public frmRecordProductionMwView(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
        }

        private void frmRecordProductionMwView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
        
        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptRecordProductionMW1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptRecordProductionMW1.ReportDefinition.Sections;
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

                crvRecordProductionMw.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "codsec";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                for (int i = 0; i < rptRecordProductionMW1.ParameterFields.Count; i++)
                {
                    switch (rptRecordProductionMW1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            pfldcodsec.CurrentValues.Add(prmcodsec);
                            rptRecordProductionMW1.ParameterFields[i].CurrentValues.Clear();
                            rptRecordProductionMW1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptRecordProductionMW1.ParameterFields[i].HasCurrentValue = true;
                            rptRecordProductionMW1.ParameterFields[i].DefaultValues.Clear();
                            rptRecordProductionMW1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        default:
                            break;
                    }
                    crvRecordProductionMw.ParameterFieldInfo.Add(rptRecordProductionMW1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
