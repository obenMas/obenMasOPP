using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPackingListReport : Form
    {
        public string number = string.Empty;

        public frmPackingListReport()
        {
            InitializeComponent();
        }

        public frmPackingListReport(string number)
        {
            InitializeComponent();
            this.number = number;
        }

        private void frmPalletPreShippingReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPalletPreShipping1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletPreShipping1.ReportDefinition.Sections;
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

                crvPalletPreShipping.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmNumber = new ParameterDiscreteValue();
                prmNumber.Value = number;

                ParameterField pfldNumber = new ParameterField();
                pfldNumber.Name = "number";
                pfldNumber.CurrentValues.Add(prmNumber);
                pfldNumber.HasCurrentValue = true;

                for (int i = 0; i < rptPalletPreShipping1.ParameterFields.Count; i++)
                {
                    switch (rptPalletPreShipping1.ParameterFields[i].Name)
                    {
                        case "@number":
                            rptPalletPreShipping1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletPreShipping1.ParameterFields[i].CurrentValues.Add(prmNumber);
                            rptPalletPreShipping1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletPreShipping1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletPreShipping1.ParameterFields[i].DefaultValues.Add(prmNumber);
                            break;

                        default:
                            break;
                    }
                    crvPalletPreShipping.ParameterFieldInfo.Add(rptPalletPreShipping1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

