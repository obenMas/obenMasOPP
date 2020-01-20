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
    public partial class frmProductionReportByOrderViewBCK : Form
    { 
        double TMM = 0, TMP = 0, TMOtros = 0, TotalHours = 0, ProductionHours, Nethours = 0, Efficiency = 0, TotalWeigth = 0, TotalQuantity = 0, MatEfficiency = 0, Decrease = 0, DecreasePorcent = 0, Consuption = 0, Performance = 0;
        int KilogramPerHour = 0, KilogramsPerHoursText = 0, fkFilmProductionPlan = 0;
        string FilmProductionPlanName = "";
        DateTime EndDatePrm = DateTime.Now;
        DateTime InitDatePrm = DateTime.Now;

        public frmProductionReportByOrderViewBCK()
        {
            InitializeComponent();
        }
        public frmProductionReportByOrderViewBCK(double TMMM, double TMMP, double TMOOtros, double TotalHourss, double ProductionHourss, double Nethourss, double Efficiencyy, double TotalWeigthh, double TotalQuantityy, double MatEfficiencyy, double Decreasee, double DecreasePorcentt, double Consuptionn, double Performancee, int KilogramPerHourr, int KilogramsPerHoursTextt, DateTime InitDatePrmm, DateTime EndDatePrmm, string FilmProductionPlanNamee, int fkFilmProductionPlann)
        {
            this.TMM = TMMM;
            this.TMP = TMMP;
            this.TMOtros= TMOOtros;
            this.TotalHours= TotalHourss;
            this.ProductionHours = ProductionHourss;
            this.Nethours = Nethourss;
            this.Efficiency = Efficiencyy;
            this.TotalWeigth=TotalWeigthh;
            this.TotalQuantity = TotalQuantityy;
            this.MatEfficiency = MatEfficiencyy;
            this.Decrease = Decreasee;
            this.DecreasePorcent = DecreasePorcentt;
            this.Consuption = Consuptionn;
            this.Performance = Performancee;
            this.KilogramPerHour = KilogramPerHourr;
            this.KilogramsPerHoursText = KilogramsPerHoursTextt;
            this.InitDatePrm = InitDatePrmm;
            this.EndDatePrm = EndDatePrmm;
            this.FilmProductionPlanName = FilmProductionPlanNamee;
            this.fkFilmProductionPlan = fkFilmProductionPlann;
            InitializeComponent();
        }

        private void frmProductionReportByOrderViewBCK_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptProductionByOrder1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptProductionByOrder1.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmtmm = new ParameterDiscreteValue();
                prmtmm.Value = TMM;

                ParameterField pfldtmm = new ParameterField();
                pfldtmm.Name = "TMM";
                pfldtmm.CurrentValues.Add(prmtmm);
                pfldtmm.HasCurrentValue = true;

                 ParameterDiscreteValue prmtmp = new ParameterDiscreteValue();
                prmtmp.Value = TMP;

                ParameterField pfldtmp = new ParameterField();
                pfldtmp.Name = "TMP";
                pfldtmp.CurrentValues.Add(prmtmp);
                pfldtmp.HasCurrentValue = true;

                 ParameterDiscreteValue prmtmotros = new ParameterDiscreteValue();
                prmtmotros.Value = TMOtros;

                ParameterField pfldtmotros = new ParameterField();
                pfldtmotros.Name = "TMOtros";
                pfldtmotros.CurrentValues.Add(prmtmotros);
                pfldtmotros.HasCurrentValue = true;

                 ParameterDiscreteValue prmtotalhours = new ParameterDiscreteValue();
                prmtotalhours.Value = TotalHours;

                ParameterField pfldtotalhours = new ParameterField();
                pfldtotalhours.Name = "TotalHours";
                pfldtotalhours.CurrentValues.Add(prmtotalhours);
                pfldtotalhours.HasCurrentValue = true;

                 ParameterDiscreteValue prmproductionhours = new ParameterDiscreteValue();
                prmproductionhours.Value = ProductionHours;

                ParameterField pfldproductionhours = new ParameterField();
                pfldproductionhours.Name = "ProductionHours";
                pfldproductionhours.CurrentValues.Add(prmproductionhours);
                pfldproductionhours.HasCurrentValue = true;

                 ParameterDiscreteValue prmnethours = new ParameterDiscreteValue();
                prmnethours.Value = Nethours;

                ParameterField pfldnethours = new ParameterField();
                pfldnethours.Name = "NetHours";
                pfldnethours.CurrentValues.Add(prmnethours);
                pfldnethours.HasCurrentValue = true;

                ParameterDiscreteValue prmefficiency = new ParameterDiscreteValue();
                prmefficiency.Value = Efficiency;

                ParameterField pfldefficiency = new ParameterField();
                pfldefficiency.Name = "Efficiency";
                pfldefficiency.CurrentValues.Add(prmefficiency);
                pfldefficiency.HasCurrentValue = true;

                ParameterDiscreteValue prmtotalweigth = new ParameterDiscreteValue();
                prmtotalweigth.Value = TotalWeigth;

                ParameterField pfldtotalweigth = new ParameterField();
                pfldtotalweigth.Name = "TotalWeigth";
                pfldtotalweigth.CurrentValues.Add(prmtotalweigth);
                pfldtotalweigth.HasCurrentValue = true;
                
                ParameterDiscreteValue prmquantity = new ParameterDiscreteValue();
                prmquantity.Value = TotalQuantity;

                ParameterField pflquantity = new ParameterField();
                pflquantity.Name = "Quantity";
                pflquantity.CurrentValues.Add(prmquantity);
                pflquantity.HasCurrentValue = true;
                
                ParameterDiscreteValue prmconsuption = new ParameterDiscreteValue();
                prmconsuption.Value = Consuption;

                ParameterField pfldconsuption = new ParameterField();
                pfldconsuption.Name = "Consuption";
                pfldconsuption.CurrentValues.Add(prmconsuption);
                pfldconsuption.HasCurrentValue = true;

                ParameterDiscreteValue prmmatefficiency = new ParameterDiscreteValue();
                prmmatefficiency.Value = MatEfficiency;

                ParameterField pfldmatefficiency = new ParameterField();
                pfldmatefficiency.Name = "MatEfficiency";
                pfldmatefficiency.CurrentValues.Add(prmmatefficiency);
                pfldmatefficiency.HasCurrentValue = true;
                
                ParameterDiscreteValue prmdecrease = new ParameterDiscreteValue();
                prmdecrease.Value = Decrease;

                ParameterField pflddecrease = new ParameterField();
                pflddecrease.Name = "Decrease";
                pflddecrease.CurrentValues.Add(prmdecrease);
                pflddecrease.HasCurrentValue = true;
                
                ParameterDiscreteValue prmdecreaseporcent = new ParameterDiscreteValue();
                prmdecreaseporcent.Value = DecreasePorcent;

                ParameterField pflddecreaseporcent = new ParameterField();
                pflddecreaseporcent.Name = "DecreasePorcent";
                pflddecreaseporcent.CurrentValues.Add(prmdecreaseporcent);
                pflddecreaseporcent.HasCurrentValue = true;

                ParameterDiscreteValue prmkilogramsperhour = new ParameterDiscreteValue();
                prmkilogramsperhour.Value = KilogramsPerHoursText;

                ParameterField pfldkilogramsperhour = new ParameterField();
                pfldkilogramsperhour.Name = "ProductionAveragen";
                pfldkilogramsperhour.CurrentValues.Add(prmkilogramsperhour);
                pfldkilogramsperhour.HasCurrentValue = true;

                ParameterDiscreteValue prmkilogramsperhours = new ParameterDiscreteValue();
                prmkilogramsperhours.Value = KilogramPerHour;

                ParameterField pfldkilogramsperhours = new ParameterField();
                pfldkilogramsperhours.Name = "ProductionPerHour";
                pfldkilogramsperhours.CurrentValues.Add(prmkilogramsperhours);
                pfldkilogramsperhours.HasCurrentValue = true;

                ParameterDiscreteValue prmperformance = new ParameterDiscreteValue();
                prmperformance.Value = Performance;

                ParameterField pfldperformance = new ParameterField();
                pfldperformance.Name = "Performance";
                pfldperformance.CurrentValues.Add(prmperformance);
                pfldperformance.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = InitDatePrm;

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "InitDate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = EndDatePrm;

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "EndDate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                ParameterDiscreteValue prmFilmProductionPlanName = new ParameterDiscreteValue();
                prmFilmProductionPlanName.Value = FilmProductionPlanName;

                ParameterField pfldFilmProductionPlanName = new ParameterField();
                pfldFilmProductionPlanName.Name = "FilmProductionPlanName";
                pfldFilmProductionPlanName.CurrentValues.Add(prmFilmProductionPlanName);
                pfldFilmProductionPlanName.HasCurrentValue = true;

                ParameterDiscreteValue prmfkFilmProductionPlan = new ParameterDiscreteValue();
                prmfkFilmProductionPlan.Value = fkFilmProductionPlan;

                ParameterField pfldfkFilmProductionPlan = new ParameterField();
                pfldfkFilmProductionPlan.Name = "fkFilmProductionPlan";
                pfldfkFilmProductionPlan.CurrentValues.Add(prmfkFilmProductionPlan);
                pfldfkFilmProductionPlan.HasCurrentValue = true;

                for (int i = 0; i < rptProductionByOrder1.ParameterFields.Count; i++)
                {
                    switch (rptProductionByOrder1.ParameterFields[i].Name)
                    {
                        case "TMM":
                            pfldtmm.CurrentValues.Add(prmtmm);
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmtmm);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmtmm);
                            break;

                        case "TMP":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmtmp);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmtmp);
                            break;

                        case "TMOtros":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmtmotros);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmtmotros);
                            break;

                        case "TotalHours":                      
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmtotalhours);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmtotalhours);
                            break;

                        case "ProductionHours":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmproductionhours);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmproductionhours);
                            break;

                        case "NetHours":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmnethours);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmnethours);
                            break;

                        case "Efficiency":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmefficiency);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmefficiency);
                            break;

                        case "TotalWeigth":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmtotalweigth);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmtotalweigth);
                            break;

                        case "Quantity":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmquantity);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmquantity);
                            break;

                        case "Consuption":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmconsuption);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmconsuption);
                            break;

                        case "MatEfficiency":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmmatefficiency);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmmatefficiency);
                            break;

                        case "Decrease":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmdecrease);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmdecrease);
                            break;

                        case "DecreasePorcent":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmdecreaseporcent);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmdecreaseporcent);
                            break;

                        case "ProductionAveragen":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmkilogramsperhour);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmkilogramsperhour);
                            break;

                        case "ProductionPerHour":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmkilogramsperhours);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmkilogramsperhours);
                            break;

                        case "Performance":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmperformance);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmperformance);
                            break;

                        case "InitDate":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "EndDate":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        case "FilmProductionPlanName":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmFilmProductionPlanName);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmFilmProductionPlanName);
                            break;

                        case "fkFilmProductionPlan":
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].CurrentValues.Add(prmfkFilmProductionPlan);
                            rptProductionByOrder1.ParameterFields[i].HasCurrentValue = true;
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Clear();
                            rptProductionByOrder1.ParameterFields[i].DefaultValues.Add(prmfkFilmProductionPlan);
                            break;

                        default:
                            break;
                    }
                    crvProductionByOrder.ParameterFieldInfo.Add(rptProductionByOrder1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void crvProductionByOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
