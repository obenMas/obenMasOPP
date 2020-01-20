using System;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reports;
using BPS.Reporting.SalesOrder.International;

namespace BPS
{
    public partial class frmSalesOrderCountry : Form
    {
        string initdate, enddate = string.Empty;
        //rptSalesOrderCountry
        public frmSalesOrderCountry()
        {
            InitializeComponent();
        }

        private void frmSalesOrderCountry_Load(object sender, EventArgs e)
        {

        }

        private void setReportParameters(String initdate, String enddate)
        {
            try
            {
                rptSalesOrderCountry rptSalesOrderCountry = new rptSalesOrderCountry();

                Tables tables;

                ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
                prmInitdate.Value = initdate;

                ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
                prmEnddate.Value = enddate;


                for (int i = 0; i < rptSalesOrderCountry.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderCountry.ParameterFields[i].Name)
                    {
                        case "initdate":
                            rptSalesOrderCountry.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderCountry.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptSalesOrderCountry.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderCountry.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderCountry.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;
                        case "enddate":
                            rptSalesOrderCountry.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderCountry.ParameterFields[i].CurrentValues.Add(prmEnddate);
                            rptSalesOrderCountry.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderCountry.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderCountry.ParameterFields[i].DefaultValues.Add(prmEnddate);
                            break;

                        default:
                            break;
                    }
                }

                tables = rptSalesOrderCountry.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderCountry.ReportDefinition.Sections;
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

                crystalReportViewer1.ReportSource = rptSalesOrderCountry;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) < 0)
            {
                TimeSpan InitHour = new TimeSpan(00, 00, 00);
                TimeSpan EndHour = new TimeSpan(23, 59, 59);
                initdate = dtpInitDate.Value.Date.Add(InitHour).ToString("dd/MM/yyyy HH:mm:ss");
                enddate = dtpEndDate.Value.Date.Add(EndHour).ToString("dd/MM/yyyy HH:mm:ss");
                setReportParameters(initdate, enddate);
            }
            else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) == 0)
                MessageBox.Show("Las fechas no pueden ser iguales por favor cambie las fechas", "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            else if (dtpInitDate.Value.CompareTo(dtpEndDate.Value) > 0)
                MessageBox.Show("La fecha inicio no pueden ser mayor que la fecha fin", "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }
    }
}
