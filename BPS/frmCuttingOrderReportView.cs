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
    public partial class frmCuttingOrderReportView : Form
    {
        private int codsec = 0, fkmachine = 0;
        public frmCuttingOrderReportView()
        {
            InitializeComponent();
        }
        public frmCuttingOrderReportView(int codsec, int fkmachine)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.fkmachine = fkmachine;
        }

        private void frmCuttingOrderReportView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptCuttingOrders1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCuttingOrders1.ReportDefinition.Sections;
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

                crvCuttingOrder.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "codSec";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmfkmachine = new ParameterDiscreteValue();
                prmfkmachine.Value = fkmachine;

                ParameterField pfldfkmachine = new ParameterField();
                pfldfkmachine.Name = "fkMachine";
                pfldfkmachine.CurrentValues.Add(prmfkmachine);
                pfldfkmachine.HasCurrentValue = true;

                for (int i = 0; i < rptCuttingOrders1.ParameterFields.Count; i++)
                {
                    switch (rptCuttingOrders1.ParameterFields[i].Name)
                    {
                        case "codSec":
                            pfldcodsec.CurrentValues.Add(prmcodsec);
                            rptCuttingOrders1.ParameterFields[i].CurrentValues.Clear();
                            rptCuttingOrders1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptCuttingOrders1.ParameterFields[i].HasCurrentValue = true;
                            rptCuttingOrders1.ParameterFields[i].DefaultValues.Clear();
                            rptCuttingOrders1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;

                        case "fkMachine":
                            rptCuttingOrders1.ParameterFields[i].CurrentValues.Clear();
                            rptCuttingOrders1.ParameterFields[i].CurrentValues.Add(prmfkmachine);
                            rptCuttingOrders1.ParameterFields[i].HasCurrentValue = true;
                            rptCuttingOrders1.ParameterFields[i].DefaultValues.Clear();
                            rptCuttingOrders1.ParameterFields[i].DefaultValues.Add(prmfkmachine);
                            break;
                        default:
                            break;
                    }
                    crvCuttingOrder.ParameterFieldInfo.Add(rptCuttingOrders1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
