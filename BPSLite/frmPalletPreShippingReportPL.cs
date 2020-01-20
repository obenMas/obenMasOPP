using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmPalletPreShippingReportPL : Form
    {
        public string number = string.Empty;

        public frmPalletPreShippingReportPL()
        {
            InitializeComponent();
        }

        public frmPalletPreShippingReportPL(string number)
        {
            InitializeComponent();
            this.number = number;
        }

        private void frmPalletPreShippingReportPL_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPalletPreShippingPL1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletPreShippingPL1.ReportDefinition.Sections;
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

                crystalReportViewer1.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmNumber = new ParameterDiscreteValue();
                prmNumber.Value = number;

                ParameterField pfldNumber = new ParameterField();
                pfldNumber.Name = "number";
                pfldNumber.CurrentValues.Add(prmNumber);
                pfldNumber.HasCurrentValue = true;

                for (int i = 0; i < rptPalletPreShippingPL1.ParameterFields.Count; i++)
                {
                    switch (rptPalletPreShippingPL1.ParameterFields[i].Name)
                    {
                        case "number":
                            rptPalletPreShippingPL1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletPreShippingPL1.ParameterFields[i].CurrentValues.Add(prmNumber);
                            rptPalletPreShippingPL1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletPreShippingPL1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletPreShippingPL1.ParameterFields[i].DefaultValues.Add(prmNumber);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptPalletPreShippingPL1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
