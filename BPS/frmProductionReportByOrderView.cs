using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmProductionReportByOrderView : Form
    { 
        int KilogramsPerHoursText = 0, fkFilmProductionPlan = 0;
        DateTime EndDatePrm = DateTime.Now;
        DateTime InitDatePrm = DateTime.Now;

        public frmProductionReportByOrderView()
        {
            InitializeComponent();
        }
        public frmProductionReportByOrderView(int KilogramsPerHoursTextt, int fkFilmProductionPlann)
        {
            this.KilogramsPerHoursText = KilogramsPerHoursTextt;
            this.fkFilmProductionPlan = fkFilmProductionPlann;
            InitializeComponent();
        }

        private void frmProductionReportByOrderView_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptProductionByLotnumber1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProductionByLotnumber1.ReportDefinition.Sections;
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

                crvProductionByOrder.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmkilogramsperhour = new ParameterDiscreteValue();
                prmkilogramsperhour.Value = KilogramsPerHoursText;

                ParameterField pfldkilogramsperhour = new ParameterField();
                pfldkilogramsperhour.Name = "PKg";
                pfldkilogramsperhour.CurrentValues.Add(prmkilogramsperhour);
                pfldkilogramsperhour.HasCurrentValue = true;

                ParameterDiscreteValue prmfkFilm = new ParameterDiscreteValue();
                prmfkFilm.Value = fkFilmProductionPlan;

                ParameterField pfldfilm = new ParameterField();
                pfldfilm.Name = "fkfilmproductionplan";
                pfldfilm.CurrentValues.Add(prmfkFilm);
                pfldfilm.HasCurrentValue = true;

                ParameterDiscreteValue prmfkProduction = new ParameterDiscreteValue();
                prmfkProduction.Value = fkFilmProductionPlan;

                ParameterField pfldproduction = new ParameterField();
                pfldproduction.Name = "fkFilmProductionOrder";
                pfldproduction.CurrentValues.Add(prmfkProduction);
                pfldproduction.HasCurrentValue = true;

                
                for (int i = 0; i < rptProductionByLotnumber1.ParameterFields.Count; i++)
                {
                    switch (rptProductionByLotnumber1.ParameterFields[i].Name)
                    {
                        case "PKg":
                            rptProductionByLotnumber1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByLotnumber1.ParameterFields[i].CurrentValues.Add(prmkilogramsperhour);
                            rptProductionByLotnumber1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByLotnumber1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByLotnumber1.ParameterFields[i].DefaultValues.Add(prmkilogramsperhour);
                            break;

                        case "fkFilmProductionOrder":
                            rptProductionByLotnumber1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByLotnumber1.ParameterFields[i].CurrentValues.Add(prmfkProduction);
                            rptProductionByLotnumber1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByLotnumber1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByLotnumber1.ParameterFields[i].DefaultValues.Add(prmfkProduction);
                            break;

                        case "fkfilmproductionplan":
                            rptProductionByLotnumber1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByLotnumber1.ParameterFields[i].CurrentValues.Add(prmfkFilm);
                            rptProductionByLotnumber1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByLotnumber1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByLotnumber1.ParameterFields[i].DefaultValues.Add(prmfkFilm);
                            break;

                        default:
                            break;
                    }
                    crvProductionByOrder.ParameterFieldInfo.Add(rptProductionByLotnumber1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
