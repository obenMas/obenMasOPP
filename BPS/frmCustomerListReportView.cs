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
    public partial class frmCustomerListReportView : Form
    {
        private int fkEntity = 0;
        public frmCustomerListReportView()
        {
            InitializeComponent();
        }

        public frmCustomerListReportView(int fkEntity)
        {
            InitializeComponent();
            this.fkEntity = fkEntity;
        }

        private void frmCustomerListReportView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptSalesOrderBySalesOrderDetailsReport1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSalesOrderBySalesOrderDetailsReport1.ReportDefinition.Sections;
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

                crvSalesOrderByDetailReport.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmfkEntity = new ParameterDiscreteValue();
                prmfkEntity.Value = fkEntity;

                ParameterField pfldfkEntity = new ParameterField();
                pfldfkEntity.Name = "fkEntity";
                pfldfkEntity.CurrentValues.Add(prmfkEntity);
                pfldfkEntity.HasCurrentValue = true;

                for (int i = 0; i < rptSalesOrderBySalesOrderDetailsReport1.ParameterFields.Count; i++)
                {
                    switch (rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i].Name)
                    {
                        case "fkEntity":
                            rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i].CurrentValues.Clear();
                            rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i].CurrentValues.Add(prmfkEntity);
                            rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i].HasCurrentValue = true;
                            rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i].DefaultValues.Clear();
                            rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i].DefaultValues.Add(prmfkEntity);
                            break;

                        default:
                            break;
                    }
                    crvSalesOrderByDetailReport.ParameterFieldInfo.Add(rptSalesOrderBySalesOrderDetailsReport1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
