using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Reports.Certificates;

namespace BPS
{
    public partial class frmNewQCertificate : Form
    {
        string lotnumber = string.Empty;
        string pass = "";

        public frmNewQCertificate()
        {
            InitializeComponent();
        }

         public frmNewQCertificate(string number, string passw)
        {
            this.lotnumber = number;
            this.pass = passw;
            InitializeComponent();
            
        }
         
         private void frmNewQCertificate_Load_1(object sender, EventArgs e)
         {
             setReportParameters();
         }

        private void setReportParameters()
        {
            Reports.Certificates.rptNewQualityCertificate rptCtrlNewCertificate = new Reports.Certificates.rptNewQualityCertificate();
            try
            {
                Tables tables;

                tables = rptCtrlNewCertificate.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCtrlNewCertificate.ReportDefinition.Sections;
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
                                tableLogonInfo.ConnectionInfo.Password = pass;
                                table.ApplyLogOnInfo(tableLogonInfo);
                            }
                        }
                    }
                }

                ParameterDiscreteValue prmLotNmbr = new ParameterDiscreteValue();
                prmLotNmbr.Value = lotnumber;

                ParameterField pfldfkNumber = new ParameterField();
                pfldfkNumber.Name = "@lot";
                pfldfkNumber.CurrentValues.Add(prmLotNmbr);
                pfldfkNumber.HasCurrentValue = true;

                crystalReportViewer1.ParameterFieldInfo.Clear();

                for (int i = 0; i < rptCtrlNewCertificate.ParameterFields.Count; i++)
                {
                    switch (rptCtrlNewCertificate.ParameterFields[i].Name)
                    {
                        case "@lot":
                            rptCtrlNewCertificate.ParameterFields[i].CurrentValues.Clear();
                            rptCtrlNewCertificate.ParameterFields[i].CurrentValues.Add(prmLotNmbr);
                            rptCtrlNewCertificate.ParameterFields[i].HasCurrentValue = true;
                            rptCtrlNewCertificate.ParameterFields[i].DefaultValues.Clear();
                            rptCtrlNewCertificate.ParameterFields[i].DefaultValues.Add(prmLotNmbr);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptCtrlNewCertificate.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

 }

