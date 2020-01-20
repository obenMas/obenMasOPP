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
using BPS.Reports;

namespace BPS
{
    public partial class frmMovementReprocess : Form
    {
        string initdate, enddate = string.Empty;

        public frmMovementReprocess()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cmbMovementType.SelectedIndex > -1)
            {
                TimeSpan InitHour = new TimeSpan(00, 00, 00);
                TimeSpan EndHour = new TimeSpan(23, 59, 59);
                initdate = dtpDate.Value.Date.Add(InitHour).ToString("dd/MM/yyyy HH:mm:ss");
                enddate = dtpDate.Value.Date.Add(EndHour).ToString("dd/MM/yyyy HH:mm:ss");
                setReportParameters(initdate, enddate);
            }
            else
                MessageBox.Show("Debe seleccionar un tipo de movimiento", "Reporte movimientos bodega", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
        }

        private void setReportParameters(String initdate, String enddate)
        {
            try
            {
                rptReprocessDay rptReprocess = new rptReprocessDay();

                Tables tables;

                ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
                prmOperation.Value = "ReportDay";

                ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
                prmCode.Value = cmbMovementType.SelectedItem.ToString().ToUpper();

                ParameterDiscreteValue prmIn = new ParameterDiscreteValue();
                prmIn.Value = GetCodeIn(cmbMovementType.SelectedItem.ToString());

                ParameterDiscreteValue prmOut = new ParameterDiscreteValue();
                prmOut.Value = GetCodeOut(cmbMovementType.SelectedItem.ToString());

                ParameterDiscreteValue prmDevolution = new ParameterDiscreteValue();
                prmDevolution.Value = GetCodeDevolution(cmbMovementType.SelectedItem.ToString());

                ParameterDiscreteValue prmInitdate = new ParameterDiscreteValue();
                prmInitdate.Value = initdate;

                ParameterDiscreteValue prmEnddate = new ParameterDiscreteValue();
                prmEnddate.Value = enddate;

                ParameterDiscreteValue prmCodsec = new ParameterDiscreteValue();
                prmCodsec.Value = 1;

                for (int i = 0; i < rptReprocess.ParameterFields.Count; i++)
                {
                    switch (rptReprocess.ParameterFields[i].Name)
                    {
                        case "operation":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmOperation);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmOperation);
                            break;
                        case "code":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmCode);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmCode);
                            break;
                        case "initdate":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmInitdate);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmInitdate);
                            break;
                        case "enddate":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmEnddate);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmEnddate);
                            break;
                        case "codsec":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmCodsec);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmCodsec);
                            break;
                        case "in":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmIn);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmIn);
                            break;
                        case "out":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmOut);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmOut);
                            break;
                        case "devolution":
                            rptReprocess.ParameterFields[i].CurrentValues.Clear();
                            rptReprocess.ParameterFields[i].CurrentValues.Add(prmDevolution);
                            rptReprocess.ParameterFields[i].HasCurrentValue = true;
                            rptReprocess.ParameterFields[i].DefaultValues.Clear();
                            rptReprocess.ParameterFields[i].DefaultValues.Add(prmDevolution);
                            break;
                        default:
                            break;
                    }
                }

                tables = rptReprocess.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptReprocess.ReportDefinition.Sections;
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

                crvReProcess.ReportSource = rptReprocess;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool GetCodeIn(string movement)
        {
            if (movement == "Ingreso de Planta")
                return true;
            else
                return false;
        }

        private bool GetCodeOut(string movement)
        {
            if (movement == "Salida a Planta")
                return true;
            else
                return false;
        }

        private bool GetCodeDevolution(string movement)
        {
            if (movement == "Devolución Líneas")
                return true;
            else
                return false;
        }
    }
}
