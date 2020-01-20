using System;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reporting.SalesOrder.International;

namespace BPS
{
    public partial class frmSalesOrderQuantityByCustomer : Form
    {
        string initdate, enddate = string.Empty;

        public frmSalesOrderQuantityByCustomer()
        {
            InitializeComponent();
        }

        private void frmSalesOrderQuantityByCustomer_Load(object sender, EventArgs e)
        {

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

        private void setReportParameters(String initdate, String enddate)
        {
            try
            {
                rptSalesOrderQuantityByCustomer rptSalesOrderQuantityByCustomer = new rptSalesOrderQuantityByCustomer();

                Tables tables;

                ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
                prmInitdate.Value = initdate;

                ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
                prmEnddate.Value = enddate;


                for (int i = 0; i < rptSalesOrderQuantityByCustomer.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderQuantityByCustomer.ParameterFields[i].Name)
                    {
                        case "initdate":
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;
                        case "enddate":
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].CurrentValues.Add(prmEnddate);
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderQuantityByCustomer.ParameterFields[i].DefaultValues.Add(prmEnddate);
                            break;

                        default:
                            break;
                    }
                }

                tables = rptSalesOrderQuantityByCustomer.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderQuantityByCustomer.ReportDefinition.Sections;
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

                crvSalesOrderByCustomer.ReportSource = rptSalesOrderQuantityByCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
