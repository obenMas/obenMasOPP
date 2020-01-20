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
using BPS.Lite.Reports;

namespace BPS.Lite
{
    public partial class frmMetalizedProdutionReport : Form
    {
        TimeSpan inithour = new TimeSpan(08, 00, 00);
        TimeSpan endhour = new TimeSpan(20, 00, 00);

        public frmMetalizedProdutionReport()
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
            rptMetalizedProduction rptMetlizedProduction = new rptMetalizedProduction();

            Tables tables;

            tables = rptMetlizedProduction.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMetlizedProduction.ReportDefinition.Sections;
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

            ParameterField pfldinitdate = new ParameterField();
            pfldinitdate.Name = "initdate";
            pfldinitdate.CurrentValues.Add(prmInitdate);
            pfldinitdate.HasCurrentValue = true;

            ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
            prmEnddate.Value = GenerateDateValue("enddate", cmbInning.SelectedItem.ToString());

            ParameterField pfldenddate = new ParameterField();
            pfldenddate.Name = "enddate";
            pfldenddate.CurrentValues.Add(prmEnddate);
            pfldenddate.HasCurrentValue = true;

            ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
            prmOperation.Value = "ProductionReport";

            ParameterField pfldoperation = new ParameterField();
            pfldoperation.Name = "operation";
            pfldoperation.CurrentValues.Add(prmOperation);
            pfldoperation.HasCurrentValue = true;

            ParameterDiscreteValue prmInning = new ParameterDiscreteValue();
            prmInning.Value = cmbInning.SelectedItem.ToString();

            ParameterField pfldinning = new ParameterField();
            pfldinning.Name = "inning";
            pfldinning.CurrentValues.Add(prmInning);
            pfldinning.HasCurrentValue = true;

            ParameterDiscreteValue prmDate = new ParameterDiscreteValue();
            prmDate.Value = GenerateDateValue("date", cmbInning.SelectedItem.ToString());

            ParameterField pflddate = new ParameterField();
            pflddate.Name = "date";
            pflddate.CurrentValues.Add(prmDate);
            pflddate.HasCurrentValue = true;

            for (int i = 0; i < rptMetlizedProduction.ParameterFields.Count; i++)
            {
                switch (rptMetlizedProduction.ParameterFields[i].Name)
                {
                    case "initdate":
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Add(prmInitdate);
                        rptMetlizedProduction.ParameterFields[i].HasCurrentValue = true;
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Add(prmInitdate);
                        break;
                    case "enddate":
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Add(prmEnddate);
                        rptMetlizedProduction.ParameterFields[i].HasCurrentValue = true;
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Add(prmEnddate);
                        break;
                    case "operation":
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Add(prmOperation);
                        rptMetlizedProduction.ParameterFields[i].HasCurrentValue = true;
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Add(prmOperation);
                        break;
                    case "inning":
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Add(prmInning);
                        rptMetlizedProduction.ParameterFields[i].HasCurrentValue = true;
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Add(prmInning);
                        break;
                    case "date":
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].CurrentValues.Add(prmDate);
                        rptMetlizedProduction.ParameterFields[i].HasCurrentValue = true;
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Clear();
                        rptMetlizedProduction.ParameterFields[i].DefaultValues.Add(prmDate);
                        break;
                    default:
                        break;
                }
            }

            crvEffience.ReportSource = rptMetlizedProduction;
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
