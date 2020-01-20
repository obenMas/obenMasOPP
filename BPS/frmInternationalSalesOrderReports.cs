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
    public partial class frmInternationalSalesOrderReports : Form
    {
        int InternationalSalesOrderExportCodSec = 0;

        public frmInternationalSalesOrderReports()
        {
            InitializeComponent();
        }

        public frmInternationalSalesOrderReports(int InternasionalSalesOrderExportCodsec)
        {
            InitializeComponent();
            this.InternationalSalesOrderExportCodSec = InternasionalSalesOrderExportCodsec;
        }

        private void frmInternationalSalesOrderReports_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptSalesOrderExportShort1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderExportShort1.ReportDefinition.Sections;
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

                crvInternationalSalesOrder.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmInternationalSalesOrderExportCodsec = new ParameterDiscreteValue();
                prmInternationalSalesOrderExportCodsec.Value = InternationalSalesOrderExportCodSec;

                ParameterField pfldInternationalExportCodsec = new ParameterField();
                pfldInternationalExportCodsec.Name = "sod_fkSalesOrder";
                pfldInternationalExportCodsec.CurrentValues.Add(prmInternationalSalesOrderExportCodsec);
                pfldInternationalExportCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptSalesOrderExportShort1.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderExportShort1.ParameterFields[i].Name)
                    {
                        case "sod_fkSalesOrder":
                            rptSalesOrderExportShort1.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderExportShort1.ParameterFields[i].CurrentValues.Add(prmInternationalSalesOrderExportCodsec);
                            rptSalesOrderExportShort1.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderExportShort1.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderExportShort1.ParameterFields[i].DefaultValues.Add(prmInternationalSalesOrderExportCodsec);
                            break;
                        default:
                            break;
                    }
                    crvInternationalSalesOrder.ParameterFieldInfo.Add(rptSalesOrderExportShort1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
