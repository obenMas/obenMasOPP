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
    public partial class frmProgrammedDelivery : Form
    {
        private string date;
        public frmProgrammedDelivery()
        {
            InitializeComponent();
        }

        public frmProgrammedDelivery(string dateparam)
        {
            InitializeComponent();
            this.date = dateparam;
        }

        private void frmProgrammedDelivery_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptProgrammedDeliveries1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProgrammedDeliveries1.ReportDefinition.Sections;
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

                crystalReportViewer1.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmDate = new ParameterDiscreteValue();
                prmDate.Value = date;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "date2";
                pfldInitDate.CurrentValues.Add(prmDate);
                pfldInitDate.HasCurrentValue = true;

                for (int i = 0; i < rptProgrammedDeliveries1.ParameterFields.Count; i++)
                {
                    switch (rptProgrammedDeliveries1.ParameterFields[i].Name)
                    {

                        case "@date2":
                            rptProgrammedDeliveries1.ParameterFields[i].CurrentValues.Clear();
                            rptProgrammedDeliveries1.ParameterFields[i].CurrentValues.Add(prmDate);
                            rptProgrammedDeliveries1.ParameterFields[i].HasCurrentValue = true;
                            rptProgrammedDeliveries1.ParameterFields[i].DefaultValues.Clear();
                            rptProgrammedDeliveries1.ParameterFields[i].DefaultValues.Add(prmDate);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptProgrammedDeliveries1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




    }
}
