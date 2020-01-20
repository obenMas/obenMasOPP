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
using BPS.Bussiness;

namespace BPS
{
    public partial class frmFormulationReport : Form
    {
        int codsec = 0, width = 0, codsecCL = 0, codsecC1 = 0, codsecC2 = 0, codsecC3 = 0, codsecC4 = 0;
        double weigthCL = 0, weigthC1 = 0, weigthC2 = 0, weigthC3 = 0, weigthC4 = 0, produced = 0, decrease = 0, gramaje = 0;
        string initdate = string.Empty, endddate = string.Empty;

        public frmFormulationReport()
        {
            InitializeComponent();
        }

        public frmFormulationReport(int codsec, double weigthCL, double weigthC1, double weigthC2, double weigthC3, double weigthC4, double produced, double decrease, string initdate, string endddate, int width, int codsecCL, int codsecC1, int codsecC2, int codsecC3, int codsecC4, double gramaje)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.weigthCL = weigthCL;
            this.weigthC1 = weigthC1;
            this.weigthC2 = weigthC2;
            this.weigthC3 = weigthC3;
            this.weigthC4 = weigthC4;
            this.produced = produced;
            this.decrease = decrease;
            this.initdate = initdate;
            this.endddate = endddate;
            this.width = width;
            this.codsecCL = codsecCL;
            this.codsecC1 = codsecC1;
            this.codsecC2 = codsecC2;
            this.codsecC3 = codsecC3;
            this.codsecC4 = codsecC4;
            this.gramaje = gramaje;
        }

        private void frmFormulationReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptFormulationReport1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptFormulationReport1.ReportDefinition.Sections;
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

                crvFormulationReport.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;
                ParameterDiscreteValue prmweigthCL = new ParameterDiscreteValue();
                prmweigthCL.Value = weigthCL;
                ParameterDiscreteValue prmweigthC1 = new ParameterDiscreteValue();
                prmweigthC1.Value = weigthC1;
                ParameterDiscreteValue prmweigthC2 = new ParameterDiscreteValue();
                prmweigthC2.Value = weigthC2;
                ParameterDiscreteValue prmweigthC3 = new ParameterDiscreteValue();
                prmweigthC3.Value = weigthC3;
                ParameterDiscreteValue prmweigthC4 = new ParameterDiscreteValue();
                prmweigthC4.Value = weigthC4;
                ParameterDiscreteValue prmproduced = new ParameterDiscreteValue();
                prmproduced.Value = produced;
                ParameterDiscreteValue prmdecrease = new ParameterDiscreteValue();
                prmdecrease.Value = decrease;
                ParameterDiscreteValue prminitdate = new ParameterDiscreteValue();
                prminitdate.Value = initdate;
                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = endddate;
                ParameterDiscreteValue prmwidth = new ParameterDiscreteValue();
                prmwidth.Value = width;
                ParameterDiscreteValue prmcodsecCL = new ParameterDiscreteValue();
                prmcodsecCL.Value = codsecCL;
                ParameterDiscreteValue prmcodsecC1 = new ParameterDiscreteValue();
                prmcodsecC1.Value = codsecC1;
                ParameterDiscreteValue prmcodsecC2 = new ParameterDiscreteValue();
                prmcodsecC2.Value = codsecC2;
                ParameterDiscreteValue prmcodsecC3 = new ParameterDiscreteValue();
                prmcodsecC3.Value = codsecC3;
                ParameterDiscreteValue prmcodsecC4 = new ParameterDiscreteValue();
                prmcodsecC4.Value = codsecC4;
                ParameterDiscreteValue prmgramaje = new ParameterDiscreteValue();
                prmgramaje.Value = gramaje;
                ParameterDiscreteValue prmgramajeCL = new ParameterDiscreteValue();
                prmgramajeCL.Value = gramaje;
                ParameterDiscreteValue prmgramajeC1 = new ParameterDiscreteValue();
                prmgramajeC1.Value = gramaje;
                ParameterDiscreteValue prmgramajeC2 = new ParameterDiscreteValue();
                prmgramajeC2.Value = gramaje;
                ParameterDiscreteValue prmgramajeC3 = new ParameterDiscreteValue();
                prmgramajeC3.Value = gramaje;
                ParameterDiscreteValue prmgramajeC4 = new ParameterDiscreteValue();
                prmgramajeC4.Value = gramaje;
                ParameterDiscreteValue prmcodsecRaw = new ParameterDiscreteValue();
                prmcodsecRaw.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "codsec";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                ParameterField pfldweigthCL = new ParameterField();
                pfldweigthCL.Name = "weigthCL";
                pfldweigthCL.CurrentValues.Add(prmweigthCL);
                pfldweigthCL.HasCurrentValue = true;

                ParameterField pfldweigthC1 = new ParameterField();
                pfldweigthC1.Name = "weigthC1";
                pfldweigthC1.CurrentValues.Add(prmweigthC1);
                pfldweigthC1.HasCurrentValue = true;

                ParameterField pfldweigthC2 = new ParameterField();
                pfldweigthC2.Name = "weigthC2";
                pfldweigthC2.CurrentValues.Add(prmweigthC2);
                pfldweigthC2.HasCurrentValue = true;

                ParameterField pfldweigthC3 = new ParameterField();
                pfldweigthC3.Name = "weigthC3";
                pfldweigthC3.CurrentValues.Add(prmweigthC3);
                pfldweigthC3.HasCurrentValue = true;

                ParameterField pfldweigthC4 = new ParameterField();
                pfldweigthC4.Name = "weigthC4";
                pfldweigthC4.CurrentValues.Add(prmweigthC4);
                pfldweigthC4.HasCurrentValue = true;

                ParameterField pfldproduced = new ParameterField();
                pfldproduced.Name = "produced";
                pfldproduced.CurrentValues.Add(prmproduced);
                pfldproduced.HasCurrentValue = true;

                ParameterField pflddecrease = new ParameterField();
                pflddecrease.Name = "decrease";
                pflddecrease.CurrentValues.Add(prmdecrease);
                pflddecrease.HasCurrentValue = true;

                ParameterField pfldinitdate = new ParameterField();
                pfldinitdate.Name = "initdate";
                pfldinitdate.CurrentValues.Add(prminitdate);
                pfldinitdate.HasCurrentValue = true;

                ParameterField pfldenddate = new ParameterField();
                pfldenddate.Name = "enddate";
                pfldenddate.CurrentValues.Add(prmenddate);
                pfldenddate.HasCurrentValue = true;

                ParameterField pfldwidth = new ParameterField();
                pfldwidth.Name = "width";
                pfldwidth.CurrentValues.Add(prmwidth);
                pfldwidth.HasCurrentValue = true;

                ParameterField pfldcodsecCL = new ParameterField();
                pfldcodsecCL.Name = "codsecCL";
                pfldcodsecCL.CurrentValues.Add(prmcodsecCL);
                pfldcodsecCL.HasCurrentValue = true;

                ParameterField pfldcodsecC1 = new ParameterField();
                pfldcodsecC1.Name = "codsecC1";
                pfldcodsecC1.CurrentValues.Add(prmcodsecC1);
                pfldcodsecC1.HasCurrentValue = true;

                ParameterField pfldcodsecC2 = new ParameterField();
                pfldcodsecC2.Name = "codsecC2";
                pfldcodsecC2.CurrentValues.Add(prmcodsecC2);
                pfldcodsecC2.HasCurrentValue = true;

                ParameterField pfldcodsecC3 = new ParameterField();
                pfldcodsecC3.Name = "codsecC3";
                pfldcodsecC3.CurrentValues.Add(prmcodsecC3);
                pfldcodsecC3.HasCurrentValue = true;

                ParameterField pfldcodsecC4 = new ParameterField();
                pfldcodsecC4.Name = "codsecC4";
                pfldcodsecC4.CurrentValues.Add(prmcodsecC4);
                pfldcodsecC4.HasCurrentValue = true;

                ParameterField pfldgramaje = new ParameterField();
                pfldgramaje.Name = "gramaje";
                pfldgramaje.CurrentValues.Add(prmgramaje);
                pfldgramaje.HasCurrentValue = true;

                ParameterField pfldgramajeCL = new ParameterField();
                pfldgramajeCL.Name = "gramajeCL";
                pfldgramajeCL.CurrentValues.Add(prmgramajeCL);
                pfldgramajeCL.HasCurrentValue = true;

                ParameterField pfldgramajeC1 = new ParameterField();
                pfldgramajeC1.Name = "gramajeC1";
                pfldgramajeC1.CurrentValues.Add(prmgramajeC1);
                pfldgramajeC1.HasCurrentValue = true;

                ParameterField pfldgramajeC2 = new ParameterField();
                pfldgramajeC2.Name = "gramajeC2";
                pfldgramajeC2.CurrentValues.Add(prmgramajeC2);
                pfldgramajeC2.HasCurrentValue = true;

                ParameterField pfldgramajeC3 = new ParameterField();
                pfldgramajeC3.Name = "gramajeC3";
                pfldgramajeC3.CurrentValues.Add(prmgramajeC3);
                pfldgramajeC3.HasCurrentValue = true;

                ParameterField pfldgramajeC4 = new ParameterField();
                pfldgramajeC4.Name = "gramajeC4";
                pfldgramajeC4.CurrentValues.Add(prmgramajeC4);
                pfldgramajeC4.HasCurrentValue = true;

                ParameterField pfldcodsecRaw = new ParameterField();
                pfldcodsecRaw.Name = "codsecRaw";
                pfldcodsecRaw.CurrentValues.Add(prmcodsecRaw);
                pfldcodsecRaw.HasCurrentValue = true;

                for (int i = 0; i < rptFormulationReport1.ParameterFields.Count; i++)
                {
                    switch (rptFormulationReport1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;
                        case "gramaje":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmgramaje);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmgramaje);
                            break;
                        case "weigthCL":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmweigthCL);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmweigthCL);
                            break;
                        case "weigthC1":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmweigthC1);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmweigthC1);
                            break;
                        case "weigthC2":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmweigthC2);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmweigthC2);
                            break;
                        case "weigthC3":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmweigthC3);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmweigthC3);
                            break;
                        case "weigthC4":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmweigthC4);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmweigthC4);
                            break;
                        case "produced":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmproduced);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmproduced);
                            break;
                        case "decrease":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmdecrease);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmdecrease);
                            break;
                        case "initdate":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prminitdate);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prminitdate);
                            break;
                        case "enddate":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;
                        case "width":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmwidth);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmwidth);
                            break;
                        case "codsecCL":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsecCL);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsecCL);
                            break;
                        case "codsecC1":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsecC1);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsecC1);
                            break;
                        case "codsecC2":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsecC2);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsecC2);
                            break;
                        case "codsecC3":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsecC3);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsecC3);
                            break;
                        case "codsecC4":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsecC4);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsecC4);
                            break;
                        case "gramajeCL":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmgramajeCL);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmgramajeCL);
                            break;
                        case "gramajeC1":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmgramajeC1);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmgramajeC1);
                            break;
                        case "gramajeC2":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmgramajeC2);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmgramajeC2);
                            break;
                        case "gramajeC3":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmgramajeC3);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmgramajeC3);
                            break;
                        case "gramajeC4":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmgramajeC4);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmgramajeC4);
                            break;
                        case "codsecRaw":
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Clear();
                            rptFormulationReport1.ParameterFields[i].CurrentValues.Add(prmcodsecRaw);
                            rptFormulationReport1.ParameterFields[i].HasCurrentValue = true;
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Clear();
                            rptFormulationReport1.ParameterFields[i].DefaultValues.Add(prmcodsecRaw);
                            break;
                        default:
                            break;
                    }
                    crvFormulationReport.ParameterFieldInfo.Add(rptFormulationReport1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
