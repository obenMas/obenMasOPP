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
    public partial class frmMovementReportbyDateView : Form
    {
        int codsec = 0;
        DateTime initDate, endDate = DateTime.Now;
        
        public frmMovementReportbyDateView()
        {
            InitializeComponent();
        }

        public frmMovementReportbyDateView(DateTime initDate, DateTime endDate, int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.initDate = initDate;
            this.endDate = endDate;
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPalletMovementByDate1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletMovementByDate1.ReportDefinition.Sections;
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

                crvMovement.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prminidate = new ParameterDiscreteValue();
                prminidate.Value = initDate;

                ParameterField pfldinitdate = new ParameterField();
                pfldinitdate.Name = "initDate";
                pfldinitdate.CurrentValues.Add(prminidate);
                pfldinitdate.HasCurrentValue = true;

                ParameterDiscreteValue prmenddate = new ParameterDiscreteValue();
                prmenddate.Value = endDate;

                ParameterField pfldenddate = new ParameterField();
                pfldenddate.Name = "endDate";
                pfldenddate.CurrentValues.Add(prmenddate);
                pfldenddate.HasCurrentValue = true;

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "coilcellar";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletMovementByDate1.ParameterFields.Count; i++)
                {
                    switch (rptPalletMovementByDate1.ParameterFields[i].Name)
                    {
                        case "initDate":
                            pfldinitdate.CurrentValues.Add(prminidate);
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Add(prminidate);
                            rptPalletMovementByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Add(prminidate);
                            break;
                        
                        case "endDate":
                            pfldenddate.CurrentValues.Add(prmenddate);
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Add(prmenddate);
                            rptPalletMovementByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Add(prmenddate);
                            break;

                        case "coilcellar":
                            pfldcodsec.CurrentValues.Add(prmcodsec);
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptPalletMovementByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        default:
                            break;
                    }
                    crvMovement.ParameterFieldInfo.Add(rptPalletMovementByDate1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMovementReportbyDateView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
