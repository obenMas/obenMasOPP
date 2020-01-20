using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPalletListReportView : Form
    {
        private DateTime InitDate = DateTime.Now;
        private DateTime EndDate = DateTime.Now;
        private string Inning = string.Empty;
        private string Notes = string.Empty;

        public frmPalletListReportView()
        {
            InitializeComponent();
        }

        public frmPalletListReportView(DateTime InitDate, DateTime EndDate, string Notes)
        {
            InitializeComponent();
            this.InitDate = InitDate;
            this.EndDate = EndDate;
            this.Notes = Notes;
        }

        private void frmProductionReportView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPalletListByDate1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletListByDate1.ReportDefinition.Sections;
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

                crvPalletReport.ParameterFieldInfo.Clear();
                
                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = InitDate;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "InitDate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = EndDate;

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "endDate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmInning = new ParameterDiscreteValue();
                prmInning.Value = Inning;

                ParameterField pfldInnig = new ParameterField();
                pfldInnig.Name = "Inning";
                pfldInnig.CurrentValues.Add(prmInning);
                pfldInnig.HasCurrentValue = true;

                ParameterDiscreteValue prmNotes = new ParameterDiscreteValue();
                prmNotes.Value = Notes;

                ParameterField pfldNotes = new ParameterField();
                pfldNotes.Name = "notes";
                pfldNotes.CurrentValues.Add(prmNotes);
                pfldNotes.HasCurrentValue = true;

                ParameterDiscreteValue prmUser = new ParameterDiscreteValue();
                prmUser.Value = 88;

                ParameterField pflduser = new ParameterField();
                pflduser.Name = "user";
                pflduser.CurrentValues.Add(prmUser);
                pflduser.HasCurrentValue = true;

                ParameterDiscreteValue prmUsername = new ParameterDiscreteValue();
                prmUsername.Value = "erwin.leiva";

                ParameterField pfldusername = new ParameterField();
                pfldusername.Name = "username";
                pfldusername.CurrentValues.Add(prmUsername);
                pfldusername.HasCurrentValue = true;

                ParameterDiscreteValue prmPlace = new ParameterDiscreteValue();
                prmPlace.Value = "Report Viewer";

                ParameterField pfldplace = new ParameterField();
                pfldplace.Name = "place";
                pfldplace.CurrentValues.Add(prmPlace);
                pfldplace.HasCurrentValue = true;
                               

                for (int i = 0; i < rptPalletListByDate1.ParameterFields.Count; i++)
                {
                    switch (rptPalletListByDate1.ParameterFields[i].Name)
                    {
                       
                        case "InitDate":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "endDate":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "Inning":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmInning);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmInning);
                            break;

                        case "notes":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmNotes);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmNotes);
                            break;

                        case "user":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmUser);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmUser);
                            break;

                        case "username":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmUsername);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmUsername);
                            break;

                        case "place":
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].CurrentValues.Add(prmPlace);
                            rptPalletListByDate1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletListByDate1.ParameterFields[i].DefaultValues.Add(prmPlace);
                            break;
                        default:
                            break;
                    }
                    crvPalletReport.ParameterFieldInfo.Add(rptPalletListByDate1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
