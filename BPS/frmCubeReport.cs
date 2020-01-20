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


namespace BPS
{
    public partial class frmCubeReport : Form
    {
        private int codsec = 0;
        public frmCubeReport()
        {
            InitializeComponent();
        }

        public frmCubeReport(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptCubeReport1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCubeReport1.ReportDefinition.Sections;
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

                crvCube.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkEntity = new ParameterDiscreteValue();
                prmfkEntity.Value = codsec;

                ParameterField pfldfkEntity = new ParameterField();
                pfldfkEntity.Name = "codsec";
                pfldfkEntity.CurrentValues.Add(prmfkEntity);
                pfldfkEntity.HasCurrentValue = true;

                ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
                prmOperation.Value = "CubeReport";

                ParameterField pfldOperation= new ParameterField();
                pfldOperation.Name = "operation";
                pfldOperation.CurrentValues.Add(prmOperation);
                pfldOperation.HasCurrentValue = true;

                ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
                prmCode.Value = "CubeReport";

                ParameterField pfldCode = new ParameterField();
                pfldCode.Name = "code";
                pfldCode.CurrentValues.Add(prmCode);
                pfldCode.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = "01/01/2013 00:00:00";

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initdate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = "01/01/2013 00:00:00";

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "enddate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                for (int i = 0; i < rptCubeReport1.ParameterFields.Count; i++)
                {
                    switch (rptCubeReport1.ParameterFields[i].Name)
                    {
                        case "operation":
                            rptCubeReport1.ParameterFields[i].CurrentValues.Clear();
                            rptCubeReport1.ParameterFields[i].CurrentValues.Add(prmOperation);
                            rptCubeReport1.ParameterFields[i].HasCurrentValue = true;
                            rptCubeReport1.ParameterFields[i].DefaultValues.Clear();
                            rptCubeReport1.ParameterFields[i].DefaultValues.Add(prmOperation);
                            break;

                        case "codsec":
                            rptCubeReport1.ParameterFields[i].CurrentValues.Clear();
                            rptCubeReport1.ParameterFields[i].CurrentValues.Add(prmfkEntity);
                            rptCubeReport1.ParameterFields[i].HasCurrentValue = true;
                            rptCubeReport1.ParameterFields[i].DefaultValues.Clear();
                            rptCubeReport1.ParameterFields[i].DefaultValues.Add(prmfkEntity);
                            break;

                        case "code":
                            rptCubeReport1.ParameterFields[i].CurrentValues.Clear();
                            rptCubeReport1.ParameterFields[i].CurrentValues.Add(prmCode);
                            rptCubeReport1.ParameterFields[i].HasCurrentValue = true;
                            rptCubeReport1.ParameterFields[i].DefaultValues.Clear();
                            rptCubeReport1.ParameterFields[i].DefaultValues.Add(prmCode);
                            break;

                        case "initdate":
                            rptCubeReport1.ParameterFields[i].CurrentValues.Clear();
                            rptCubeReport1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptCubeReport1.ParameterFields[i].HasCurrentValue = true;
                            rptCubeReport1.ParameterFields[i].DefaultValues.Clear();
                            rptCubeReport1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "enddate":
                            rptCubeReport1.ParameterFields[i].CurrentValues.Clear();
                            rptCubeReport1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptCubeReport1.ParameterFields[i].HasCurrentValue = true;
                            rptCubeReport1.ParameterFields[i].DefaultValues.Clear();
                            rptCubeReport1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        default:
                            break;
                    }
                    crvCube.ParameterFieldInfo.Add(rptCubeReport1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
