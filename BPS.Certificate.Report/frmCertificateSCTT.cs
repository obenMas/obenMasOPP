﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS.Certificate.Report
{
    public partial class frmCertificateSCTT : Form
    {
        int codsec = 0;
        string pass = "";

        public frmCertificateSCTT()
        {
            InitializeComponent();
        }

        public frmCertificateSCTT(int codsec, string pass)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.pass = pass;
        }

        private void frmCertificateSCTT_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptCertificateSCTT1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = pass;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCertificateSCTT1.ReportDefinition.Sections;
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

                crvCertificateSCTT.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkEntity = new ParameterDiscreteValue();
                prmfkEntity.Value = codsec;

                ParameterField pfldfkEntity = new ParameterField();
                pfldfkEntity.Name = "codsec";
                pfldfkEntity.CurrentValues.Add(prmfkEntity);
                pfldfkEntity.HasCurrentValue = true;

                for (int i = 0; i < rptCertificateSCTT1.ParameterFields.Count; i++)
                {
                    switch (rptCertificateSCTT1.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptCertificateSCTT1.ParameterFields[i].CurrentValues.Clear();
                            rptCertificateSCTT1.ParameterFields[i].CurrentValues.Add(prmfkEntity);
                            rptCertificateSCTT1.ParameterFields[i].HasCurrentValue = true;
                            rptCertificateSCTT1.ParameterFields[i].DefaultValues.Clear();
                            rptCertificateSCTT1.ParameterFields[i].DefaultValues.Add(prmfkEntity);
                            break;

                        default:
                            break;
                    }
                    crvCertificateSCTT.ParameterFieldInfo.Add(rptCertificateSCTT1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
