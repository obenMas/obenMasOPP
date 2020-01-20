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
    public partial class frmSalesOrderReportByNumber : Form
    {
        string number = string.Empty;

        public frmSalesOrderReportByNumber()
        {
            InitializeComponent();
        }

        public frmSalesOrderReportByNumber(string number)
        {
            InitializeComponent();
            this.number = number;
        }

        private void frmSalesOrderReportByNumber_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptSalesOrderReportByNumber1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderReportByNumber1.ReportDefinition.Sections;
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

                crvSalesOrderReportByNumber.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmMachineCodsec = new ParameterDiscreteValue();
                prmMachineCodsec.Value = number;

                ParameterField pfldMachineCodsec = new ParameterField();
                pfldMachineCodsec.Name = "machineCodsec";
                pfldMachineCodsec.CurrentValues.Add(prmMachineCodsec);
                pfldMachineCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptSalesOrderReportByNumber1.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderReportByNumber1.ParameterFields[i].Name)
                    {
                        case "number":
                            rptSalesOrderReportByNumber1.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderReportByNumber1.ParameterFields[i].CurrentValues.Add(prmMachineCodsec);
                            rptSalesOrderReportByNumber1.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderReportByNumber1.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderReportByNumber1.ParameterFields[i].DefaultValues.Add(prmMachineCodsec);
                            break;
                        default:
                            break;
                    }
                    crvSalesOrderReportByNumber.ParameterFieldInfo.Add(rptSalesOrderReportByNumber1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
