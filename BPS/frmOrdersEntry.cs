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

namespace BPS.Reports.SalesOrder
{
    public partial class frmOrdersEntry : Form
    {
        private string date;
        
        
        public frmOrdersEntry()
        {
            InitializeComponent();
        }

        public frmOrdersEntry(string dateparam)
        {
            InitializeComponent();
            this.date = dateparam;
        }


        private void frmMaterialStatus_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

         private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptOrdersEntry1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptOrdersEntry1.ReportDefinition.Sections;
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

                for (int i = 0; i < rptOrdersEntry1.ParameterFields.Count; i++)
                {
                    switch (rptOrdersEntry1.ParameterFields[i].Name)
                    {
                       
                        case "@date2":
                            rptOrdersEntry1.ParameterFields[i].CurrentValues.Clear();
                            rptOrdersEntry1.ParameterFields[i].CurrentValues.Add(prmDate);
                            rptOrdersEntry1.ParameterFields[i].HasCurrentValue = true;
                            rptOrdersEntry1.ParameterFields[i].DefaultValues.Clear();
                            rptOrdersEntry1.ParameterFields[i].DefaultValues.Add(prmDate);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptOrdersEntry1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    
}
