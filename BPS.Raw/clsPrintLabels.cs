using BPS.Raw.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Runtime.InteropServices;

namespace BPS.Raw
{
    public static class myPrinters
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
    }

    public class clsPrintLabels
    {
        public static void printRawLabel(string rawMaterialCode, bool ingress, bool output, bool devolution, string pass)
        {
            rptRaw rptRawMaterial = new rptRaw();
            Tables tables;

            tables = rptRawMaterial.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = pass;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptRawMaterial.ReportDefinition.Sections;
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
                            tableLogonInfo.ConnectionInfo.Password = pass;
                            table.ApplyLogOnInfo(tableLogonInfo);
                        }
                    }
                }
            }

            ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
            prmCode.Value = rawMaterialCode.ToUpper();

            ParameterField pfldCode = new ParameterField();
            pfldCode.Name = "code";
            pfldCode.CurrentValues.Add(prmCode);
            pfldCode.HasCurrentValue = true;

            ParameterDiscreteValue prmIn = new ParameterDiscreteValue();
            prmIn.Value = ingress;

            ParameterField pfldIn = new ParameterField();
            pfldIn.Name = "in";
            pfldIn.CurrentValues.Add(prmIn);
            pfldIn.HasCurrentValue = true;

            ParameterDiscreteValue prmOut = new ParameterDiscreteValue();
            prmOut.Value = output;

            ParameterField pfldOut = new ParameterField();
            pfldOut.Name = "out";
            pfldOut.CurrentValues.Add(prmOut);
            pfldOut.HasCurrentValue = true;

            ParameterDiscreteValue prmDevolution = new ParameterDiscreteValue();
            prmDevolution.Value = devolution;

            ParameterField pfldDevolution = new ParameterField();
            pfldDevolution.Name = "rein";
            pfldDevolution.CurrentValues.Add(prmDevolution);
            pfldDevolution.HasCurrentValue = true;

            for (int i = 0; i < rptRawMaterial.ParameterFields.Count; i++)
            {
                switch (rptRawMaterial.ParameterFields[i].Name)
                {
                    case "code":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmCode);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmCode);
                        break;

                    case "in":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmIn);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmIn);
                        break;

                    case "out":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmOut);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmOut);
                        break;

                    case "rein":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmDevolution);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmDevolution);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptRawMaterial.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptRawMaterial.PrintToPrinter(2, false, 0, 0);
        }

        internal static void printReRawLabel(string codsec)
        {
            rptRawRePro rptRawMaterial = new rptRawRePro();
            Tables tables;

            tables = rptRawMaterial.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptRawMaterial.ReportDefinition.Sections;
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
                            tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                            table.ApplyLogOnInfo(tableLogonInfo);
                        }
                    }
                }
            }

            ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
            prmCode.Value = codsec;

            ParameterField pfldCode = new ParameterField();
            pfldCode.Name = "code";
            pfldCode.CurrentValues.Add(prmCode);
            pfldCode.HasCurrentValue = true;

            ParameterDiscreteValue prmOp = new ParameterDiscreteValue();
            prmOp.Value = "RptRR";

            ParameterField pfldIn = new ParameterField();
            pfldIn.Name = "operation";
            pfldIn.CurrentValues.Add(prmOp);
            pfldIn.HasCurrentValue = true;


            for (int i = 0; i < rptRawMaterial.ParameterFields.Count; i++)
            {
                switch (rptRawMaterial.ParameterFields[i].Name)
                {
                    case "code":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmCode);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmCode);
                        break;

                    case "operation":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmOp);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmOp);
                        break;

                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptRawMaterial.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptRawMaterial.PrintToPrinter(1, false, 0, 0);
        }

        internal static void printReAdtLabel(string code, string pass)
        {
            rptRawReProAdt rptRawMaterial = new rptRawReProAdt();
            Tables tables;

            tables = rptRawMaterial.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptRawMaterial.ReportDefinition.Sections;
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
                            tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                            table.ApplyLogOnInfo(tableLogonInfo);
                        }
                    }
                }
            }

            ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
            prmCode.Value = code;

            ParameterField pfldCode = new ParameterField();
            pfldCode.Name = "code";
            pfldCode.CurrentValues.Add(prmCode);
            pfldCode.HasCurrentValue = true;

            ParameterDiscreteValue prmOp = new ParameterDiscreteValue();
            prmOp.Value = "RptAdt";

            ParameterField pfldIn = new ParameterField();
            pfldIn.Name = "operation";
            pfldIn.CurrentValues.Add(prmOp);
            pfldIn.HasCurrentValue = true;


            for (int i = 0; i < rptRawMaterial.ParameterFields.Count; i++)
            {
                switch (rptRawMaterial.ParameterFields[i].Name)
                {
                    case "code":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmCode);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmCode);
                        break;

                    case "operation":
                        rptRawMaterial.ParameterFields[i].CurrentValues.Clear();
                        rptRawMaterial.ParameterFields[i].CurrentValues.Add(prmOp);
                        rptRawMaterial.ParameterFields[i].HasCurrentValue = true;
                        rptRawMaterial.ParameterFields[i].DefaultValues.Clear();
                        rptRawMaterial.ParameterFields[i].DefaultValues.Add(prmOp);
                        break;

                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptRawMaterial.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptRawMaterial.PrintToPrinter(1, false, 0, 0);
        }

        public static void printRawLabel(int rawCodsec)
        {
            rptRawLabel rptRawLabel = new rptRawLabel();

            Tables tables;

            tables = rptRawLabel.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptRawLabel.ReportDefinition.Sections;
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
                            tableLogonInfo.ConnectionInfo.Password = "Bopp2010";
                            table.ApplyLogOnInfo(tableLogonInfo);
                        }
                    }
                }
            }

            ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
            prmCoilCodsec.Value = rawCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "code";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            ParameterDiscreteValue prmop = new ParameterDiscreteValue();
            prmop.Value = "Report";

            ParameterField pfldop = new ParameterField();
            pfldop.Name = "operation";
            pfldop.CurrentValues.Add(prmop);
            pfldop.HasCurrentValue = true;

            for (int i = 0; i < rptRawLabel.ParameterFields.Count; i++)
            {
                switch (rptRawLabel.ParameterFields[i].Name)
                {
                    case "code":
                        rptRawLabel.ParameterFields[i].CurrentValues.Clear();
                        rptRawLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                        rptRawLabel.ParameterFields[i].HasCurrentValue = true;
                        rptRawLabel.ParameterFields[i].DefaultValues.Clear();
                        rptRawLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                        break;

                    case "operation":
                        rptRawLabel.ParameterFields[i].CurrentValues.Clear();
                        rptRawLabel.ParameterFields[i].CurrentValues.Add(prmop);
                        rptRawLabel.ParameterFields[i].HasCurrentValue = true;
                        rptRawLabel.ParameterFields[i].DefaultValues.Clear();
                        rptRawLabel.ParameterFields[i].DefaultValues.Add(prmop);
                        break;

                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptRawLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptRawLabel.PrintToPrinter(2, false, 0, 0);
        }
    }
}

