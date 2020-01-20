using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reports.Certificates;

namespace BPS
{
    public partial class frmQControlNumber : Form
    {
        int fkMainCoil = 0;
        int fkQualityControlsByFilm = 0;
        string MainCoilCode = string.Empty;


        public frmQControlNumber()
        {
            InitializeComponent();
        }

        public frmQControlNumber(int mainCoilCodsec, int fkQCByFilm, string mainCCode)
        {
            InitializeComponent();
            this.fkMainCoil = mainCoilCodsec;
            this.fkQualityControlsByFilm = fkQCByFilm;
            this.MainCoilCode = mainCCode;
        }

        private void frmQControlNumber_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            Reports.Certificates.rptQControlNumber rptCtrlNumber = new Reports.Certificates.rptQControlNumber();
            try
            {
                Tables tables;
                tables = rptCtrlNumber.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCtrlNumber.ReportDefinition.Sections;
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
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                crystalReportViewer1.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkMainCoil = new ParameterDiscreteValue();
                prmfkMainCoil.Value = fkMainCoil;

                ParameterField pfldfkMainCoil = new ParameterField();
                pfldfkMainCoil.Name = "fkMainCoil";
                pfldfkMainCoil.CurrentValues.Add(prmfkMainCoil);
                pfldfkMainCoil.HasCurrentValue = true;

                //
                //
                //
                //

                ParameterDiscreteValue prmfkQualityControlsByFilm = new ParameterDiscreteValue();
                prmfkQualityControlsByFilm.Value = "fkQualityControlsByFilm";

                ParameterField pfldfkQualityControlsByFilm = new ParameterField();
                pfldfkQualityControlsByFilm.Name = "fkQualityControlsByFilm";
                pfldfkQualityControlsByFilm.CurrentValues.Add(prmfkQualityControlsByFilm);
                pfldfkQualityControlsByFilm.HasCurrentValue = true;

                //
                //
                //
                //

                ParameterDiscreteValue prmMainCoilCode = new ParameterDiscreteValue();
                prmMainCoilCode.Value = "MainCoilCode";

                ParameterField pfldMainCoilCode = new ParameterField();
                pfldMainCoilCode.Name = "MainCoilCode";
                pfldMainCoilCode.CurrentValues.Add(prmMainCoilCode);
                pfldMainCoilCode.HasCurrentValue = true;

                //
                //
                //
                //

                for (int i = 0; i < rptCtrlNumber.ParameterFields.Count; i++)
                {
                    switch (rptCtrlNumber.ParameterFields[i].Name)
                    {
                        case "fkMainCoil":
                            rptCtrlNumber.ParameterFields[i].CurrentValues.Clear();
                            rptCtrlNumber.ParameterFields[i].CurrentValues.Add(prmfkMainCoil);
                            rptCtrlNumber.ParameterFields[i].HasCurrentValue = true;
                            rptCtrlNumber.ParameterFields[i].DefaultValues.Clear();
                            rptCtrlNumber.ParameterFields[i].DefaultValues.Add(prmfkMainCoil);
                            break;

                        case "fkQualityControlsByFilm":
                            rptCtrlNumber.ParameterFields[i].CurrentValues.Clear();
                            rptCtrlNumber.ParameterFields[i].CurrentValues.Add(prmfkQualityControlsByFilm);
                            rptCtrlNumber.ParameterFields[i].HasCurrentValue = true;
                            rptCtrlNumber.ParameterFields[i].DefaultValues.Clear();
                            rptCtrlNumber.ParameterFields[i].DefaultValues.Add(prmfkQualityControlsByFilm);
                            break;

                        case "MainCoilCode":
                            rptCtrlNumber.ParameterFields[i].CurrentValues.Clear();
                            rptCtrlNumber.ParameterFields[i].CurrentValues.Add(prmMainCoilCode);
                            rptCtrlNumber.ParameterFields[i].HasCurrentValue = true;
                            rptCtrlNumber.ParameterFields[i].DefaultValues.Clear();
                            rptCtrlNumber.ParameterFields[i].DefaultValues.Add(prmMainCoilCode);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptCtrlNumber.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
