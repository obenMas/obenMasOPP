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
    public partial class frmMaterialStatus : Form
    {
        private string name = string.Empty;
        
        
        public frmMaterialStatus()
        {
            InitializeComponent();
        }

        public frmMaterialStatus(string name)
        {
            InitializeComponent();
            this.name = name;
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

                tables = rptMaterialStatus1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptMaterialStatus1.ReportDefinition.Sections;
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
                
                ParameterDiscreteValue prmName = new ParameterDiscreteValue();
                prmName.Value = name;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "name";
                pfldInitDate.CurrentValues.Add(prmName);
                pfldInitDate.HasCurrentValue = true;                               

                for (int i = 0; i < rptMaterialStatus1.ParameterFields.Count; i++)
                {
                    switch (rptMaterialStatus1.ParameterFields[i].Name)
                    {
                       
                        case "@name":
                            rptMaterialStatus1.ParameterFields[i].CurrentValues.Clear();
                            rptMaterialStatus1.ParameterFields[i].CurrentValues.Add(prmName);
                            rptMaterialStatus1.ParameterFields[i].HasCurrentValue = true;
                            rptMaterialStatus1.ParameterFields[i].DefaultValues.Clear();
                            rptMaterialStatus1.ParameterFields[i].DefaultValues.Add(prmName);
                            break;

                        default:
                            break;
                    }
                    crystalReportViewer1.ParameterFieldInfo.Add(rptMaterialStatus1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

         private void rptMaterialStatus1_InitReport(object sender, EventArgs e)
         {

         }
    }
    
}
