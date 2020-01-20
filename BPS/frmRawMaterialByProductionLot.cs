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
    public partial class frmRawMaterialByProductionLot : Form
    {
        public frmRawMaterialByProductionLot()
        {
            InitializeComponent();
        }

        private void frmSummaryCutter_Load(object sender, EventArgs e)
        {
            
        }


        private void loadReports()
        {
            rptRawMaterialByLotNumberAndDate rptRawMaterialByLotNumberAndDate = new Reports.rptRawMaterialByLotNumberAndDate();
            Tables tables;

            tables = rptRawMaterialByLotNumberAndDate.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptRawMaterialByLotNumberAndDate.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
            prmInitDate.Value = dtpInitDate.Value.ToString("dd/MM/yyyy HH:mm:ss");
                        

            ParameterField pfldInitDate = new ParameterField();
            pfldInitDate.Name = "@initdate";
            pfldInitDate.CurrentValues.Add(prmInitDate);
            pfldInitDate.HasCurrentValue = true;
            pfldInitDate.ParameterValueType = ParameterValueKind.DateTimeParameter;
            pfldInitDate.ReportParameterType = ParameterType.StoreProcedureParameter;
            

            ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
            prmEndDate.Value = dtpEndDate.Value;

            ParameterField pfldEndDate = new ParameterField();
            pfldEndDate.Name = "@enddate";
            pfldEndDate.CurrentValues.Add(prmEndDate);
            pfldEndDate.HasCurrentValue = true;
            pfldEndDate.ParameterValueType = ParameterValueKind.DateTimeParameter;

            for (int i = 0; i < rptRawMaterialByLotNumberAndDate.ParameterFields.Count; i++)
            {
                switch (rptRawMaterialByLotNumberAndDate.ParameterFields[i].Name)
                {
                    case "@initdate":
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].CurrentValues.Add(prmInitDate);
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].DefaultValues.Add(prmInitDate);
                        break;
                    case "@enddate":
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].CurrentValues.Add(prmEndDate);
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterialByLotNumberAndDate.ParameterFields[i].DefaultValues.Add(prmEndDate);
                        break;
                    default:
                        break;
                }
            }
            crvSummaryCutter.ReportSource = rptRawMaterialByLotNumberAndDate;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            loadReports();
        }
    }
}
