using BPS.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Extruder
{
    public partial class frmFormulationReport : Form
    {
        private int codsec { get; set; }

        public frmFormulationReport(int fkFormulation)
        {
            InitializeComponent();
            codsec = fkFormulation;
        }

        private void frmFormulationReport_Load(object sender, EventArgs e)
        {
            loadReports();
        }

        private void loadReports()
        {
            try
            {
                rptFormulation rptFormulation = new rptFormulation();
                Tables tables;

                tables = rptFormulation.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptFormulation.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmoperation = new ParameterDiscreteValue();
                prmoperation.Value = "RW";

                ParameterDiscreteValue prmcode = new ParameterDiscreteValue();
                prmcode.Value = "Report";

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = "01/01/2014 00:00:00";

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = "01/01/2014 00:00:00";

                for (int i = 0; i < rptFormulation.ParameterFields.Count; i++)
                {
                    switch (rptFormulation.ParameterFields[i].Name)
                    {
                        case "code":
                            rptFormulation.ParameterFields[i].CurrentValues.Clear();
                            rptFormulation.ParameterFields[i].CurrentValues.Add(prmcode);
                            rptFormulation.ParameterFields[i].HasCurrentValue = true;
                            rptFormulation.ParameterFields[i].DefaultValues.Clear();
                            rptFormulation.ParameterFields[i].DefaultValues.Add(prmcode);
                            break;

                        case "operation":
                            rptFormulation.ParameterFields[i].CurrentValues.Clear();
                            rptFormulation.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptFormulation.ParameterFields[i].HasCurrentValue = true;
                            rptFormulation.ParameterFields[i].DefaultValues.Clear();
                            rptFormulation.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        case "codsec":
                            rptFormulation.ParameterFields[i].CurrentValues.Clear();
                            rptFormulation.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptFormulation.ParameterFields[i].HasCurrentValue = true;
                            rptFormulation.ParameterFields[i].DefaultValues.Clear();
                            rptFormulation.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        case "initdate":
                            rptFormulation.ParameterFields[i].CurrentValues.Clear();
                            rptFormulation.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptFormulation.ParameterFields[i].HasCurrentValue = true;
                            rptFormulation.ParameterFields[i].DefaultValues.Clear();
                            rptFormulation.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptFormulation.ParameterFields[i].CurrentValues.Clear();
                            rptFormulation.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptFormulation.ParameterFields[i].HasCurrentValue = true;
                            rptFormulation.ParameterFields[i].DefaultValues.Clear();
                            rptFormulation.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        default:
                            break;
                    }
                }
                crystalReportViewer1.ReportSource = rptFormulation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
