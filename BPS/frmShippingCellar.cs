using System;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using BPS.Reporting.Cellar;

namespace BPS
{
    public partial class frmShippingCellar : Form
    {
        string initDate, endDate = string.Empty;

        public frmShippingCellar()
        {
            InitializeComponent();
        }

        private void dtpDate_CloseUp(object sender, EventArgs e)
        {
            loadReports();
        }

        private void loadReports()
        {
            rptCellarShippingUnified rptUnifiedCellar = new rptCellarShippingUnified();
            rptCellarShippingFull rptFullCellar = new rptCellarShippingFull();
            TimeSpan initHour = new TimeSpan (00,00,00);
            TimeSpan endHour = new TimeSpan (23,59,59);
            initDate = dtpDate.Value.Date.Add(initHour).ToString("dd/MM/yyyy HH:mm:ss");
            endDate = dtpDate.Value.Date.Add(endHour).ToString("dd/MM/yyyy HH:mm:ss");


            ParameterDiscreteValue prminitDate = new ParameterDiscreteValue();
            prminitDate.Value = Convert.ToDateTime(initDate);

            ParameterDiscreteValue prmendDate = new ParameterDiscreteValue();
            prmendDate.Value = Convert.ToDateTime(endDate);

            for (int i = 0; i < rptUnifiedCellar.ParameterFields.Count; i++)
            {
                switch (rptUnifiedCellar.ParameterFields[i].Name)
                {
                    case "initDate":
                        rptUnifiedCellar.ParameterFields[i].CurrentValues.Clear();
                        rptUnifiedCellar.ParameterFields[i].CurrentValues.Add(prminitDate);
                        rptUnifiedCellar.ParameterFields[i].HasCurrentValue = true;
                        rptUnifiedCellar.ParameterFields[i].DefaultValues.Clear();
                        rptUnifiedCellar.ParameterFields[i].DefaultValues.Add(prminitDate);
                        break;

                    case "endDate":
                        rptUnifiedCellar.ParameterFields[i].CurrentValues.Clear();
                        rptUnifiedCellar.ParameterFields[i].CurrentValues.Add(prmendDate);
                        rptUnifiedCellar.ParameterFields[i].HasCurrentValue = true;
                        rptUnifiedCellar.ParameterFields[i].DefaultValues.Clear();
                        rptUnifiedCellar.ParameterFields[i].DefaultValues.Add(prmendDate);
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < rptFullCellar.ParameterFields.Count; i++)
            {
                switch (rptFullCellar.ParameterFields[i].Name)
                {
                    case "initDate":
                        rptFullCellar.ParameterFields[i].CurrentValues.Clear();
                        rptFullCellar.ParameterFields[i].CurrentValues.Add(prminitDate);
                        rptFullCellar.ParameterFields[i].HasCurrentValue = true;
                        rptFullCellar.ParameterFields[i].DefaultValues.Clear();
                        rptFullCellar.ParameterFields[i].DefaultValues.Add(prminitDate);
                        break;

                    case "endDate":
                        rptFullCellar.ParameterFields[i].CurrentValues.Clear();
                        rptFullCellar.ParameterFields[i].CurrentValues.Add(prmendDate);
                        rptFullCellar.ParameterFields[i].HasCurrentValue = true;
                        rptFullCellar.ParameterFields[i].DefaultValues.Clear();
                        rptFullCellar.ParameterFields[i].DefaultValues.Add(prmendDate);
                        break;
                    default:
                        break;
                }
            }

            crvSalesOrderUnified.ReportSource = rptUnifiedCellar;
            crvSalesOrderFull.ReportSource = rptFullCellar;
        }

        private void dtpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                loadReports();
        }
    }
}
