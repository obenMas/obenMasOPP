using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS
{
    public partial class frmMainCoilStockReport : Form
    {
        clsMachine objMachine = new clsMachine();

        public frmMainCoilStockReport()
        {
            InitializeComponent();
        }
        public frmMainCoilStockReport(int machineCodsec)
        {
            objMachine.load(machineCodsec, "Extruder");
            InitializeComponent();
        }


        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptMainCoilStock1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptMainCoilStock1.ReportDefinition.Sections;
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

                crvMainCoilStock.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmMachineCodsec = new ParameterDiscreteValue();
                prmMachineCodsec.Value = objMachine.codsec;

                ParameterField pfldMachineCodsec = new ParameterField();
                pfldMachineCodsec.Name = "machineCodsec";
                pfldMachineCodsec.CurrentValues.Add(prmMachineCodsec);
                pfldMachineCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptMainCoilStock1.ParameterFields.Count; i++)
                {
                    switch (rptMainCoilStock1.ParameterFields[i].Name)
                    {
                        case "machineCodsec":
                            rptMainCoilStock1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilStock1.ParameterFields[i].CurrentValues.Add(prmMachineCodsec);
                            rptMainCoilStock1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilStock1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilStock1.ParameterFields[i].DefaultValues.Add(prmMachineCodsec);
                            break;
                        default:
                            break;
                    }
                    crvMainCoilStock.ParameterFieldInfo.Add(rptMainCoilStock1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmMainCoilStockReport_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
