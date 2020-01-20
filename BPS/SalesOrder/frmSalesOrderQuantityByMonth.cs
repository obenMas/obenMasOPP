using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reports;
using BPS.Reporting.SalesOrder.International;

namespace BPS
{
    public partial class frmSalesOrderQuantityByMonth : Form
    {
        string initdate, enddate = string.Empty;

        public frmSalesOrderQuantityByMonth()
        {
            InitializeComponent();
        }

        private void frmSalesOrderQuantityByMonth_Load(object sender, EventArgs e)
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
                rptSalesOrderQuantityByMonth rptSalesOrderQuantityByMonth = new rptSalesOrderQuantityByMonth();

                Tables tables;

                ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
                prmInitdate.Value = initdate;

                ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
                prmEnddate.Value = enddate;


                for (int i = 0; i < rptSalesOrderQuantityByMonth.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderQuantityByMonth.ParameterFields[i].Name)
                    {
                        case "initdate":
                            rptSalesOrderQuantityByMonth.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderQuantityByMonth.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptSalesOrderQuantityByMonth.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderQuantityByMonth.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderQuantityByMonth.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;
                        case "enddate":
                            rptSalesOrderQuantityByMonth.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderQuantityByMonth.ParameterFields[i].CurrentValues.Add(prmEnddate);
                            rptSalesOrderQuantityByMonth.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderQuantityByMonth.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderQuantityByMonth.ParameterFields[i].DefaultValues.Add(prmEnddate);
                            break;

                        default:
                            break;
                    }
                }

                tables = rptSalesOrderQuantityByMonth.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderQuantityByMonth.ReportDefinition.Sections;
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

                crvSalesOrderQuantityByMonth.ReportSource = rptSalesOrderQuantityByMonth;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
