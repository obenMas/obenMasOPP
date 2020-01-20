using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMainCoilOutline : Form
    {
        clsMainCoil objMainCoil = new clsMainCoil();
        clsMainCoilQuality objMainCoilQuality = new clsMainCoilQuality();

        private void setReportParameters()
        {
            try
            {
                Tables tables = rptMainCoilOutline1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                crvMainCoilOutline.ParameterFieldInfo.Clear();

                string strThikness = objMainCoilQuality.thikness;

                ParameterDiscreteValue prmMainCoilCodsec = new ParameterDiscreteValue();
                prmMainCoilCodsec.Value = objMainCoil.codsec;

                ParameterField pfldMainCoilCodsec = new ParameterField();
                pfldMainCoilCodsec.Name = "mainCoilCodsec";
                pfldMainCoilCodsec.CurrentValues.Add(prmMainCoilCodsec);
                pfldMainCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmDelimeter = new ParameterDiscreteValue();
                prmDelimeter.Value = "';'";

                ParameterField pfldDelimeter = new ParameterField();
                pfldDelimeter.Name = "Delimeter";
                pfldDelimeter.CurrentValues.Add(prmDelimeter);
                pfldDelimeter.HasCurrentValue = true;

                ParameterDiscreteValue prmThikness = new ParameterDiscreteValue();
                prmThikness.Value = "'" + strThikness + "'";

                ParameterField pfldThikness = new ParameterField();
                pfldThikness.Name = "thiknessList";
                pfldThikness.CurrentValues.Add(prmThikness);
                pfldThikness.HasCurrentValue = true;

                ParameterDiscreteValue prmcodsec = new ParameterDiscreteValue();
                prmcodsec.Value = objMainCoil.codsec;

                ParameterField pfldcodsec = new ParameterField();
                pfldcodsec.Name = "codsec";
                pfldcodsec.CurrentValues.Add(prmcodsec);
                pfldcodsec.HasCurrentValue = true;


                for (int i = 0; i < rptMainCoilOutline1.ParameterFields.Count; i++)
                {
                    switch (rptMainCoilOutline1.ParameterFields[i].Name)
                    {
                        case "mainCoilCodsec":
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Add(prmMainCoilCodsec);
                            rptMainCoilOutline1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Add(prmMainCoilCodsec);

                            break;
                        case "Delimeter":
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Add(prmDelimeter);
                            rptMainCoilOutline1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Add(prmDelimeter);
                            break;
                        case "thiknessList":
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Add(prmThikness);
                            rptMainCoilOutline1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Add(prmThikness);
                            break;
                        case "codsec":
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].CurrentValues.Add(prmcodsec);
                            rptMainCoilOutline1.ParameterFields[i].HasCurrentValue = true;
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Clear();
                            rptMainCoilOutline1.ParameterFields[i].DefaultValues.Add(prmcodsec);
                            break;
                        default:
                            break;
                    }
                    crvMainCoilOutline.ParameterFieldInfo.Add(rptMainCoilOutline1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public frmMainCoilOutline()
        {
            InitializeComponent();
        }

        public frmMainCoilOutline(int mainCoilCodsec)
        {
            InitializeComponent();
            objMainCoil.load(mainCoilCodsec);
            objMainCoilQuality = clsMainCoilQuality.getQualityByMainCoil(mainCoilCodsec);
        }

        private void frmMainCoilOutline_Load(object sender, EventArgs e)
        {
            setReportParameters();
        }
    }
}
