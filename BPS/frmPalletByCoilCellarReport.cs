using System;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace BPS
{
    public partial class frmPalletByCoilCellarReport : Form
    {
        private string fulldata = "", movement = "";
        private DateTime date;

        public frmPalletByCoilCellarReport()
        {
            InitializeComponent();
        }

        public frmPalletByCoilCellarReport(string fulldata, DateTime date, string movement)
        {
            InitializeComponent();
            this.date = date;
            this.fulldata = fulldata;
            this.movement = movement;
            setReportParameters();
        }

        private void setReportParameters()
        {
            try
            {
                Tables tables;

                tables = rptPalletByCoilCellarReport1.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletByCoilCellarReport1.ReportDefinition.Sections;
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

                crvPalletCoilCellar.ParameterFieldInfo.Clear();

                ParameterDiscreteValue prmmystring = new ParameterDiscreteValue();
                prmmystring.Value = fulldata;

                ParameterField pfldmystring = new ParameterField();
                pfldmystring.Name = "mystring";
                pfldmystring.CurrentValues.Add(prmmystring);
                pfldmystring.HasCurrentValue = true;

                ParameterDiscreteValue prmhead = new ParameterDiscreteValue();
                prmhead.Value = GenerateHead(movement);

                ParameterField pfldhead = new ParameterField();
                pfldhead.Name = "head";
                pfldhead.CurrentValues.Add(prmhead);
                pfldhead.HasCurrentValue = true;

                ParameterDiscreteValue prmdate = new ParameterDiscreteValue();
                prmdate.Value = date.Date;

                ParameterField pflddate = new ParameterField();
                pflddate.Name = "date";
                pflddate.CurrentValues.Add(prmdate);
                pflddate.HasCurrentValue = true;

                ParameterDiscreteValue prmday = new ParameterDiscreteValue();
                prmday.Value = date.DayOfWeek.ToString();

                ParameterField pfldday = new ParameterField();
                pfldday.Name = "day";
                pfldday.CurrentValues.Add(prmday);
                pfldday.HasCurrentValue = true;

                ParameterDiscreteValue prmtype = new ParameterDiscreteValue();
                prmtype.Value = GenerateMovementType(movement);

                ParameterField pfldtype = new ParameterField();
                pfldtype.Name = "type";
                pfldtype.CurrentValues.Add(prmtype);
                pfldtype.HasCurrentValue = true;

                for (int i = 0; i < rptPalletByCoilCellarReport1.ParameterFields.Count; i++)
                {
                    switch (rptPalletByCoilCellarReport1.ParameterFields[i].Name)
                    {
                        case "mystring":
                            pfldmystring.CurrentValues.Add(prmmystring);
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Add(prmmystring);
                            rptPalletByCoilCellarReport1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Add(prmmystring);
                            break;

                        case "head":
                            pfldhead.CurrentValues.Add(prmhead);
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Add(prmhead);
                            rptPalletByCoilCellarReport1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Add(prmhead);
                            break;

                        case "date":
                            pfldhead.CurrentValues.Add(prmdate);
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Add(prmdate);
                            rptPalletByCoilCellarReport1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Add(prmdate);
                            break;

                        case "day":
                            pfldhead.CurrentValues.Add(prmday);
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Add(prmday);
                            rptPalletByCoilCellarReport1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Add(prmday);
                            break;

                        case "type":
                            pfldtype.CurrentValues.Add(prmtype);
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].CurrentValues.Add(prmtype);
                            rptPalletByCoilCellarReport1.ParameterFields[i].HasCurrentValue = true;
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Clear();
                            rptPalletByCoilCellarReport1.ParameterFields[i].DefaultValues.Add(prmtype);
                            break;

                        default:
                            break;
                    }
                    crvPalletCoilCellar.ParameterFieldInfo.Add(rptPalletByCoilCellarReport1.ParameterFields[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GenerateMovementType(string movement)
        {
            string result = "";

            if (movement == "E022" || movement == "E023" || movement == "E043" || movement == "E010" || movement == "E021")
            {
                result = "INGRESO No " + movement.Replace("0", "");
            }
            else if (movement == "H014" || movement == "H023" || movement == "H022" || movement == "S006")
            {
                result = "EGRESO No " + movement.Replace("0", "");
            }
            else
                result = "NO FOUND";

            return result;
        }

        private string GenerateHead(string movement)
        {
            string result = "";

            if (movement == "E022" || movement == "E023")
            {
                result = "ENTREGA DE MATERIALES (MAQUILAS)";
            }
            else if (movement == "H014" || movement == "H023")
            {
                result = "EGRESO DE PRODUCTO TERMINADO";
            }
            else if (movement == "E043")
            {
                result = "INGRESO DE PRODUCTO TERMINADO EN PROCESO";
            }
            else if (movement == "H022" || movement == "S006")
            {
                result = "REQUISICIÓN DE MATERIALES (MAQUILAS)";
            }
            else
                result = "NO FOUND";

            return result;
        }
    }
}
