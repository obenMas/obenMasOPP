using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS.Certificate.Report
{
    public partial class frmCertificateMC : Form
    {
        int codsec = 0;
        string pass = "";
        public frmCertificateMC()
        {
            InitializeComponent();
        }

        public frmCertificateMC(int codsec, string pass)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.pass = pass;
        }

        private void frmCertificateQC_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptCertificateMCD1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCertificateMCD1.ReportDefinition.Sections;
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

                crvCertificateSC.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkEntity = new ParameterDiscreteValue();
                prmfkEntity.Value = codsec;

                ParameterField pfldfkEntity = new ParameterField();
                pfldfkEntity.Name = "codsec";
                pfldfkEntity.CurrentValues.Add(prmfkEntity);
                pfldfkEntity.HasCurrentValue = true;

                for (int i = 0; i < rptCertificateMCD1.ParameterFields.Count; i++)
                {
                    switch (rptCertificateMCD1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptCertificateMCD1.ParameterFields[i].CurrentValues.Clear();
                            rptCertificateMCD1.ParameterFields[i].CurrentValues.Add(prmfkEntity);
                            rptCertificateMCD1.ParameterFields[i].HasCurrentValue = true;
                            rptCertificateMCD1.ParameterFields[i].DefaultValues.Clear();
                            rptCertificateMCD1.ParameterFields[i].DefaultValues.Add(prmfkEntity);
                            break;

                        default:
                            break;
                    }
                    crvCertificateSC.ParameterFieldInfo.Add(rptCertificateMCD1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
