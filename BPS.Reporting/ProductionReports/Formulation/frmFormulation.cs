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
using System.Drawing.Printing;

namespace BPS.Reporting.ProductionReports.Formulation
{
    public partial class frmFormulation : Form
    {
        protected string password = string.Empty, data = string.Empty;
        protected int codsec = 0;

        public frmFormulation()
        {
            InitializeComponent();
        }

        public frmFormulation(string data, string password, int codsec)
        {
            InitializeComponent();
            this.data = data;
            this.password = password;
            this.codsec = codsec;
        }

        private void frmFormulation_Load(object sender, EventArgs e)
        {
            loadReports();
        }

        private void loadReports()
        {
            try
            {
                rptFormulationH rptFormulationH = new rptFormulationH();
                Tables tables;

                tables = rptFormulationH.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptFormulationH.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = password;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmoperation = new ParameterDiscreteValue();
                prmoperation.Value = "Report";

                ParameterDiscreteValue prmcode = new ParameterDiscreteValue();
                prmcode.Value = "Report";

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = "01/01/2014 00:00:00";

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = "01/01/2014 00:00:00";

                ParameterDiscreteValue prmdata = new ParameterDiscreteValue();
                prmdata.Value = data;

                for (int i = 0; i < rptFormulationH.ParameterFields.Count; i++)
                {
                    switch (rptFormulationH.ParameterFields[i].Name)
                    {
                        case "mydata":
                            rptFormulationH.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationH.ParameterFields[i].CurrentValues.Add(prmdata);
                            rptFormulationH.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationH.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationH.ParameterFields[i].DefaultValues.Add(prmdata);
                            break;

                        case "code":
                            rptFormulationH.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationH.ParameterFields[i].CurrentValues.Add(prmcode);
                            rptFormulationH.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationH.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationH.ParameterFields[i].DefaultValues.Add(prmcode);
                            break;

                        case "operation":
                            rptFormulationH.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationH.ParameterFields[i].CurrentValues.Add(prmoperation);
                            rptFormulationH.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationH.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationH.ParameterFields[i].DefaultValues.Add(prmoperation);
                            break;

                        case "codsec":
                            rptFormulationH.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationH.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptFormulationH.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationH.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationH.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        case "initdate":
                            rptFormulationH.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationH.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptFormulationH.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationH.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationH.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;

                        case "enddate":
                            rptFormulationH.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationH.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptFormulationH.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationH.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationH.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        default:
                            break;
                    }
                }
                crvFormulation.ReportSource = rptFormulationH;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
