using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS.Certificate.Report
{
    public partial class frmCertificateFH : Form
    {
        int codsec = 0;
        string pass = "";
        public frmCertificateFH()
        {
            InitializeComponent();
        }

        public frmCertificateFH(int codsec, string pass)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.pass = pass;
        }

        private void frmCertificateFH_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptCertificateFH1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCertificateFH1.ReportDefinition.Sections;
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

                crvCertificateFH.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkEntity = new ParameterDiscreteValue();
                prmfkEntity.Value = codsec;

                ParameterField pfldfkEntity = new ParameterField();
                pfldfkEntity.Name = "codsec";
                pfldfkEntity.CurrentValues.Add(prmfkEntity);
                pfldfkEntity.HasCurrentValue = true;

                for (int i = 0; i < rptCertificateFH1.ParameterFields.Count; i++)
                {
                    switch (rptCertificateFH1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptCertificateFH1.ParameterFields[i].CurrentValues.Clear();
                            rptCertificateFH1.ParameterFields[i].CurrentValues.Add(prmfkEntity);
                            rptCertificateFH1.ParameterFields[i].HasCurrentValue = true;
                            rptCertificateFH1.ParameterFields[i].DefaultValues.Clear();
                            rptCertificateFH1.ParameterFields[i].DefaultValues.Add(prmfkEntity);
                            break;

                        default:
                            break;
                    }
                    crvCertificateFH.ParameterFieldInfo.Add(rptCertificateFH1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
