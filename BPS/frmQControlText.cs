using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reports.Certificates;

namespace BPS
{
    public partial class frmQControlText : Form
    {
        int fkMainCoil = 0;
        int fkQualityControlsByFilm = 0;
        string MainCoilCode = string.Empty;
        

        public frmQControlText()
        {
            InitializeComponent();
        }

        public frmQControlText(int mainCoilCodsec,int fkQCByFilm ,string mainCCode)
        {
            InitializeComponent();
            this.fkMainCoil = mainCoilCodsec;
            this.fkQualityControlsByFilm = fkQCByFilm;
            this.MainCoilCode = mainCCode;
        }

        private void frmQControlText_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            Reports.Certificates.rptQControlText rptCtrlText = new Reports.Certificates.rptQControlText();
             try
              {
                  Tables tables;
                  tables = rptCtrlText.Database.Tables;
                  foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                  {
                      TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                      table.ApplyLogOnInfo(tableLogonInfo);
                  }

                  Sections sections = rptCtrlText.ReportDefinition.Sections;
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

                  for (int i = 0; i < rptCtrlText.ParameterFields.Count; i++)
                  {
                      switch (rptCtrlText.ParameterFields[i].Name)
                      {
                          case "fkMainCoil":
                              rptCtrlText.ParameterFields[i].CurrentValues.Clear();
                              rptCtrlText.ParameterFields[i].CurrentValues.Add(prmfkMainCoil);
                              rptCtrlText.ParameterFields[i].HasCurrentValue = true;
                              rptCtrlText.ParameterFields[i].DefaultValues.Clear();
                              rptCtrlText.ParameterFields[i].DefaultValues.Add(prmfkMainCoil);
                              break;

                          case "fkQualityControlsByFilm":
                              rptCtrlText.ParameterFields[i].CurrentValues.Clear();
                              rptCtrlText.ParameterFields[i].CurrentValues.Add(prmfkQualityControlsByFilm);
                              rptCtrlText.ParameterFields[i].HasCurrentValue = true;
                              rptCtrlText.ParameterFields[i].DefaultValues.Clear();
                              rptCtrlText.ParameterFields[i].DefaultValues.Add(prmfkQualityControlsByFilm);
                              break;

                          case "MainCoilCode":
                              rptCtrlText.ParameterFields[i].CurrentValues.Clear();
                              rptCtrlText.ParameterFields[i].CurrentValues.Add(prmMainCoilCode);
                              rptCtrlText.ParameterFields[i].HasCurrentValue = true;
                              rptCtrlText.ParameterFields[i].DefaultValues.Clear();
                              rptCtrlText.ParameterFields[i].DefaultValues.Add(prmMainCoilCode);
                              break;

                          default:
                              break;
                      }
                      crystalReportViewer1.ParameterFieldInfo.Add(rptCtrlText.ParameterFields[i]);
                  }
              }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

        }

    }
}
