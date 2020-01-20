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
    public partial class frmCuttingOrderListReport : Form
    {
        clsMachine objCutter = new clsMachine();
        public frmCuttingOrderListReport()
        {
            InitializeComponent();
        }
        public frmCuttingOrderListReport(int machineCodsec)
        {
            InitializeComponent();
            objCutter.load(machineCodsec, "Cutter");            
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptCuttingOrderList1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCuttingOrderList1.ReportDefinition.Sections;
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

                crvCuttingOrderViewer.ParameterFieldInfo.Clear();
                ParameterDiscreteValue prmMachineCodsec = new ParameterDiscreteValue();
                prmMachineCodsec.Value = objCutter.codsec;

                ParameterField pfldSalesOrderCodsec = new ParameterField();
                pfldSalesOrderCodsec.Name = "machineCodsec";
                pfldSalesOrderCodsec.CurrentValues.Add(prmMachineCodsec);
                pfldSalesOrderCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCuttingOrderList1.ParameterFields.Count; i++)
                {
                    switch (rptCuttingOrderList1.ParameterFields[i].Name)
                    {
                        case "machineCodsec":
                            rptCuttingOrderList1.ParameterFields[i].CurrentValues.Clear();
                            rptCuttingOrderList1.ParameterFields[i].CurrentValues.Add(prmMachineCodsec);
                            rptCuttingOrderList1.ParameterFields[i].HasCurrentValue = true;
                            rptCuttingOrderList1.ParameterFields[i].DefaultValues.Clear();
                            rptCuttingOrderList1.ParameterFields[i].DefaultValues.Add(prmMachineCodsec);

                            break;

                        default:
                            break;
                    }
                    crvCuttingOrderViewer.ParameterFieldInfo.Add(rptCuttingOrderList1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmCuttingListReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
