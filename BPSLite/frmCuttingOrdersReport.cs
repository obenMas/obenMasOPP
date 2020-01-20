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

namespace BPS.Lite
{
    public partial class frmCuttingOrdersReport : Form
    {
        private int fkCuttingOrder = 0;
        public frmCuttingOrdersReport()
        {
            InitializeComponent();
        }
        public frmCuttingOrdersReport(int fkCuttingOrder)
        {
            InitializeComponent();
            this.fkCuttingOrder = fkCuttingOrder;
        }

        private void frmCuttingOrdersReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                crvCuttingIOrder.ParameterFieldInfo.Clear();

                Tables tables;

                tables = rptCuttingOrderByMainCoil1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCuttingOrderByMainCoil1.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmfkCuttingOrder = new ParameterDiscreteValue();
                prmfkCuttingOrder.Value = fkCuttingOrder;

                ParameterField pfldfkCuttingOrder = new ParameterField();
                pfldfkCuttingOrder.Name = "fkCuttingOrder";
                pfldfkCuttingOrder.CurrentValues.Add(prmfkCuttingOrder);
                pfldfkCuttingOrder.HasCurrentValue = true;

                for (int i = 0; i < rptCuttingOrderByMainCoil1.ParameterFields.Count; i++)
                {
                    switch (rptCuttingOrderByMainCoil1.ParameterFields[i].Name)
                    {
                        case "fkCuttingOrder":
                            pfldfkCuttingOrder.CurrentValues.Add(prmfkCuttingOrder);
                            rptCuttingOrderByMainCoil1.ParameterFields[i].CurrentValues.Clear();
                            rptCuttingOrderByMainCoil1.ParameterFields[i].CurrentValues.Add(prmfkCuttingOrder);
                            rptCuttingOrderByMainCoil1.ParameterFields[i].HasCurrentValue = true;
                            rptCuttingOrderByMainCoil1.ParameterFields[i].DefaultValues.Clear();
                            rptCuttingOrderByMainCoil1.ParameterFields[i].DefaultValues.Add(prmfkCuttingOrder);
                            break;
                        default:
                            break;
                    }
                    crvCuttingIOrder.ParameterFieldInfo.Add(rptCuttingOrderByMainCoil1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
