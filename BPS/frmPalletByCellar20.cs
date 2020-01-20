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
    public partial class frmPalletByCellar20 : Form
    {
        public frmPalletByCellar20()
        {
            InitializeComponent();
        }

        private void frmPalletByCellar20_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPalletByCellar201.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletByCellar201.ReportDefinition.Sections;
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

                crvCellar18.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkOperation = new ParameterDiscreteValue();
                prmfkOperation.Value = "ReprocessListForBackloadReport";

                ParameterField pfldfkEntity = new ParameterField();
                pfldfkEntity.Name = "operation";
                pfldfkEntity.CurrentValues.Add(prmfkOperation);
                pfldfkEntity.HasCurrentValue = true;

                ParameterDiscreteValue prmfkCode = new ParameterDiscreteValue();
                prmfkCode.Value = "ReprocessListForBackloadReport";

                ParameterField pfldCode = new ParameterField();
                pfldCode.Name = "code";
                pfldCode.CurrentValues.Add(prmfkCode);
                pfldCode.HasCurrentValue = true;

                ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
                prmInitdate.Value = "01/01/2013 00:00:00";

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initdate";
                pfldInitDate.CurrentValues.Add(prmInitdate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = "01/01/2013 00:00:00";

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "enddate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmfkCodsec = new ParameterDiscreteValue();
                prmfkCodsec.Value = 1;

                ParameterField pfldCodsec = new ParameterField();
                pfldCodsec.Name = "codsec";
                pfldCodsec.CurrentValues.Add(prmfkCodsec);
                pfldCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmIn = new ParameterDiscreteValue();
                prmIn.Value = true;

                ParameterField pfldIn = new ParameterField();
                pfldIn.Name = "in";
                pfldIn.CurrentValues.Add(prmIn);
                pfldIn.HasCurrentValue = true;

                ParameterDiscreteValue prmOut = new ParameterDiscreteValue();
                prmOut.Value = true;

                ParameterField pfldOut = new ParameterField();
                pfldOut.Name = "out";
                pfldOut.CurrentValues.Add(prmOut);
                pfldOut.HasCurrentValue = true;

                ParameterDiscreteValue prmDevolution = new ParameterDiscreteValue();
                prmDevolution.Value = true;

                ParameterField pfldDevolution = new ParameterField();
                pfldDevolution.Name = "devolution";
                pfldDevolution.CurrentValues.Add(prmDevolution);
                pfldDevolution.HasCurrentValue = true;

                for (int i = 0; i < rptPalletByCellar201.ParameterFields.Count; i++)
                {
                    switch (rptPalletByCellar201.ParameterFields[i].Name)
                    {
                        case "operation":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmfkOperation);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmfkOperation);
                            break;

                        case "code":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmfkCode);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmfkCode);
                            break;

                        case "codsec":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmfkCodsec);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmfkCodsec);
                            break;

                        case "initdate":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;

                        case "enddate":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "in":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmIn);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmIn);
                            break;

                        case "out":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmOut);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmOut);
                            break;

                        case "devolution":
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].CurrentValues.Add(prmDevolution);
                            rptPalletByCellar201.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCellar201.ParameterFields[i].DefaultValues.Add(prmDevolution);
                            break;

                        default:
                            break;
                    }
                    crvCellar18.ParameterFieldInfo.Add(rptPalletByCellar201.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
