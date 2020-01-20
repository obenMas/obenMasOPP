using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilLabel : Form
    {
        private double density;
        clsMainCoil objMainCoil = new clsMainCoil();
        clsMainCoilQuality objMainCoilQuality = new clsMainCoilQuality();

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptMainCoilLabel1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptMainCoilLabel1.ReportDefinition.Sections;
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

                crvLabel.ParameterFieldInfo.Clear();

                string strThikness = objMainCoilQuality.thikness;

                ParameterDiscreteValue prmMainCoilCodsec = new ParameterDiscreteValue();
                prmMainCoilCodsec.Value = objMainCoil.codsec;

                ParameterField pfldMainCoilCodsec = new ParameterField();
                pfldMainCoilCodsec.Name = "Codsec";
                pfldMainCoilCodsec.CurrentValues.Add(prmMainCoilCodsec);
                pfldMainCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmDelimeter = new ParameterDiscreteValue();
                prmDelimeter.Value = "';'";

                ParameterField pfldDelimeter = new ParameterField();
                pfldDelimeter.Name = "Delimeter";
                pfldDelimeter.CurrentValues.Add(prmDelimeter);
                pfldDelimeter.HasCurrentValue = true;

                ParameterDiscreteValue prmThikness = new ParameterDiscreteValue();
                prmThikness.Value = "'" + strThikness + "'";

                ParameterField pfldThikness = new ParameterField();
                pfldThikness.Name = "thiknessList";
                pfldThikness.CurrentValues.Add(prmThikness);
                pfldThikness.HasCurrentValue = true;

                ParameterDiscreteValue prmDensity = new ParameterDiscreteValue();
                prmDensity.Value = density;

                ParameterField pfldDensity = new ParameterField();
                pfldDensity.Name = "Density";
                pfldDensity.CurrentValues.Add(prmDensity);
                pfldDensity.HasCurrentValue = true;


                for (int i = 0; i < rptMainCoilLabel1.ParameterFields.Count; i++)
                {
                    switch (rptMainCoilLabel1.ParameterFields[i].Name)
                    {
                        case "Codsec":
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Add(prmMainCoilCodsec);
                            rptMainCoilLabel1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Add(prmMainCoilCodsec);

                            break;
                        case "Delimeter":
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Add(prmDelimeter);
                            rptMainCoilLabel1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Add(prmDelimeter);
                            break;
                        case "thiknessList":
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Add(prmThikness);
                            rptMainCoilLabel1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Add(prmThikness);
                            break;
                        case "Density":
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].CurrentValues.Add(prmDensity);
                            rptMainCoilLabel1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilLabel1.ParameterFields[i].DefaultValues.Add(prmDensity);
                            break;
                        default:
                            break;
                    }
                    crvLabel.ParameterFieldInfo.Add(rptMainCoilLabel1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public frmMainCoilLabel()
        {
            InitializeComponent();
        }
        public frmMainCoilLabel(int mainCoilCodsec, double density)
        {
            InitializeComponent();
            this.density = density;
            objMainCoil.load(mainCoilCodsec);
            objMainCoilQuality = clsMainCoilQuality.getQualityByMainCoil(mainCoilCodsec);
        }
        private void frmMainCoilLabel_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
