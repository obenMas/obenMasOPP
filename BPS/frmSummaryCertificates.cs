using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Reports;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmSummaryCertificates : Form
    {
        private int isMetalFilm = 0;
        private string lotnumber = string.Empty;

        public frmSummaryCertificates()
        {
            InitializeComponent();
        }

        private void loadReports(int isMetalFilm)
        {
            if (isMetalFilm == 0)
            {
                rptSummaryProductionOrderByLotNumber rptSummaryProductionOrderByLotNumber = new rptSummaryProductionOrderByLotNumber();

                Tables tables;

                tables = rptSummaryProductionOrderByLotNumber.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryProductionOrderByLotNumber.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmisMetalFilm = new ParameterDiscreteValue();
                prmisMetalFilm.Value = isMetalFilm;

                ParameterDiscreteValue prmlotNumber = new ParameterDiscreteValue();
                prmlotNumber.Value = lotnumber;

                for (int i = 0; i < rptSummaryProductionOrderByLotNumber.ParameterFields.Count; i++)
                {
                    switch (rptSummaryProductionOrderByLotNumber.ParameterFields[i].Name)
                    {
                        case "isMetalFilm":
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Add(prmisMetalFilm);
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Add(prmisMetalFilm);
                            break;

                        case "lotNumber":
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Add(prmlotNumber);
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Add(prmlotNumber);
                            break;
                        default:
                            break;
                    }
                }

                crvSalesOrderUnified.ReportSource = rptSummaryProductionOrderByLotNumber;
            }
            else
            {
                rptSummaryProductionOrderMetalByLotNumber rptSummaryProductionOrderByLotNumber = new rptSummaryProductionOrderMetalByLotNumber();

                Tables tables;

                tables = rptSummaryProductionOrderByLotNumber.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptSummaryProductionOrderByLotNumber.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmisMetalFilm = new ParameterDiscreteValue();
                prmisMetalFilm.Value = isMetalFilm;

                ParameterDiscreteValue prmlotNumber = new ParameterDiscreteValue();
                prmlotNumber.Value = lotnumber;

                for (int i = 0; i < rptSummaryProductionOrderByLotNumber.ParameterFields.Count; i++)
                {
                    switch (rptSummaryProductionOrderByLotNumber.ParameterFields[i].Name)
                    {
                        case "isMetalFilm":
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Add(prmisMetalFilm);
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Add(prmisMetalFilm);
                            break;

                        case "lotNumber":
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].CurrentValues.Add(prmlotNumber);
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].HasCurrentValue = true;
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Clear();
                            rptSummaryProductionOrderByLotNumber.ParameterFields[i].DefaultValues.Add(prmlotNumber);
                            break;
                        default:
                            break;
                    }
                }

                crvSalesOrderUnified.ReportSource = rptSummaryProductionOrderByLotNumber;
            }
        }

        private bool GetTypeFilm(string lotNumber)
        {
            if (clsMainCoil.getExistMainCoilByLotNumber(lotNumber))
            {
                isMetalFilm = 0;
                lotnumber = lotNumber + "0";
                return true;
            }
            else
            {
                if (clsMainCoilMetal.getExistMainCoilByLotNumber(lotNumber))
                {
                    isMetalFilm = 1;
                    lotnumber = lotNumber;
                    return true;
                }
                else
                    return false;
            }
        }

        private void txtLotNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtLotNumber.Text.Length > 0)
                {
                    if (GetTypeFilm(txtLotNumber.Text))
                        loadReports(isMetalFilm);
                    else
                    {
                        MessageBox.Show("El lote ingresado no existe por favor ingrese un nuevo lote para poder realizar las consultas requeridas", "Certificados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtLotNumber.Focus();
                        txtLotNumber.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos un datos para consultar!", "Certificados", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtLotNumber.Focus();
                    txtLotNumber.Clear();
                }
            }
        }
    }
}
