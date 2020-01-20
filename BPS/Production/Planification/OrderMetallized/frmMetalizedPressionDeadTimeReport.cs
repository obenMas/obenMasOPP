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
using BPS.Reports;
using BPS.Bussiness;
using BPS.Reporting.Metal.MetalizedPressionDeadTime;

namespace BPS
{
    public partial class frmMetalizedPressionDeadTimeReport : Form
    {
        TimeSpan inithour = new TimeSpan(08, 00, 00);
        TimeSpan endhour = new TimeSpan(20, 00, 00);

        public frmMetalizedPressionDeadTimeReport()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbInning.SelectedIndex > -1)
                    loadReports();
                else
                    MessageBox.Show("Debe seleccionar un turno", "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Orden Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                throw;
            }
        }

        private void loadReports()
        {
            rptMetalizedPressionDeadTime rptMetalizedPressionDeadTime = new rptMetalizedPressionDeadTime();

            Tables tables;

            tables = rptMetalizedPressionDeadTime.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMetalizedPressionDeadTime.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
            prmInitdate.Value = GenerateDateValue("initdate", cmbInning.SelectedItem.ToString());

            ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
            prmEnddate.Value = GenerateDateValue("enddate", cmbInning.SelectedItem.ToString());

            ParameterDiscreteValue prmInning = new ParameterDiscreteValue();
            prmInning.Value = cmbInning.SelectedItem.ToString();

            ParameterDiscreteValue prmDate = new ParameterDiscreteValue();
            prmDate.Value = GenerateDateValue("date", cmbInning.SelectedItem.ToString());

            for (int i = 0; i < rptMetalizedPressionDeadTime.ParameterFields.Count; i++)
            {
                switch (rptMetalizedPressionDeadTime.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmInitdate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmInitdate);
                        break;
                    case "enddate":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmEnddate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmEnddate);
                        break;
                    case "inning":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmInning);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmInning);
                        break;
                    case "date":
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].CurrentValues.Add(prmDate);
                        rptMetalizedPressionDeadTime.ParameterFields[i].HasCurrentValue = true;
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Clear();
                        rptMetalizedPressionDeadTime.ParameterFields[i].DefaultValues.Add(prmDate);
                        break;
                    default:
                        break;
                }
            }

            crvEffience.ReportSource = rptMetalizedPressionDeadTime;
        }

        private string GenerateDateValue(string type, string inning)
        {
            if (type == "initdate" && inning == "Día")
            {
                return dtpDate.Value.Date.Add(inithour).ToString("dd/MM/yyyy HH:mm:ss");
                //return dtpDate.Value.Date.Add(inithour).ToString("dd/MM/yyyy HH:mm:ss");
            }
            else if (type == "enddate" && inning == "Día")
            {
                return dtpDate.Value.Date.Add(endhour).ToString("dd/MM/yyyy HH:mm:ss");
                //return dtpDate.Value.Date.Add(endhour).ToString("dd/MM/yyyy HH:mm:ss");
            }
            else if (type == "initdate" && inning == "Noche")
            {
                return dtpDate.Value.Date.Add(endhour).ToString("dd/MM/yyyy HH:mm:ss");
                //return dtpDate.Value.Date.Add(endhour).ToString("dd/MM/yyyy HH:mm:ss");
            }
            else if (type == "enddate" && inning == "Noche")
            {
                return dtpDate.Value.Date.AddDays(1).Add(inithour).ToString("dd/MM/yyyy HH:mm:ss");
                //return dtpDate.Value.Date.AddDays(1).Add(inithour).ToString("dd/MM/yyyy HH:mm:ss");
            }
            else if (type == "date" && inning == "Día")
            {
                return dtpDate.Value.Date.ToLongDateString();
            }
            else if (type == "date" && inning == "Noche")
            {
                return dtpDate.Value.Date.ToLongDateString();
            }
            else
                return "";
        }
    }
}
