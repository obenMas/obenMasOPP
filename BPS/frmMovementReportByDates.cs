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
    public partial class frmMovementReportByDates : Form
    {
        int codsec = 0;
        DateTime initDate = DateTime.Now, endDate = DateTime.Now;

        public frmMovementReportByDates()
        {
            InitializeComponent();
        }

        public frmMovementReportByDates(DateTime initDate, DateTime endDate, int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.initDate = initDate;
            this.endDate = endDate;
        }

        private void frmMovementReportByDates_Load(object sender, EventArgs e)
        {
            setReportParameters();
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

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = initDate;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initDate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = endDate;

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "endDate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmCodsec = new ParameterDiscreteValue();
                prmCodsec.Value = codsec;

                ParameterField pfldCodsec = new ParameterField();
                pfldCodsec.Name = "coilcellar";
                pfldCodsec.CurrentValues.Add(prmCodsec);
                pfldCodsec.HasCurrentValue = true;


                for (int i = 0; i < rptPalletMovementByDate1.ParameterFields.Count; i++)
                {
                    switch (rptPalletMovementByDate1.ParameterFields[i].Name)
                    {

                        case "initDate":
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptPalletMovementByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "endDate":
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptPalletMovementByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "coilcellar":
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].CurrentValues.Add(prmCodsec);
                            rptPalletMovementByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletMovementByDate1.ParameterFields[i].DefaultValues.Add(prmCodsec);
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
    }
}
