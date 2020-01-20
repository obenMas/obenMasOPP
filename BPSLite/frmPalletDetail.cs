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
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;
using BPS.Bussiness;


namespace BPS.Lite
{
    public partial class frmPalletDetail : Form
    {
        clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
        clsMachine objMachine = new clsMachine();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
        clsPalletType objPalletType = new clsPalletType();
        clsPalletDimentions objPalletDimentions = new clsPalletDimentions();
        clsPallet objPallet = new clsPallet();
        clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
        clsProduct objProduct = new clsProduct();
        bool isStockPallet = false;
        CrystalReportViewer crvPalletLabel = new CrystalReportViewer();
        rptPalletLabel rptPalletLabel1 = new rptPalletLabel();
        static SerialPort sprtBalance = new SerialPort();
        bool enablePrintButon = false;
        bool flgChangeWeight = false;
        string flgName = "";
        clsBalance bal1 = new clsBalance();
     


        public frmPalletDetail()
        {
            InitializeComponent();
            txtGrossWeigth.Enabled = false;
            txtNewGrossWeight.Enabled = false;
            bal1.loadBalanceNameByUser(clsGlobal.LoggedUser.codsec);
        }

        private void limpiar()
        {
            clsCuttingOrder objCuttingOrder = new clsCuttingOrder();
            clsMachine objMachine = new clsMachine();
            clsSalesOrder objSalesOrder = new clsSalesOrder();
            clsSalesOrderDetail objSalesOrderDetail = new clsSalesOrderDetail();
            clsPalletType objPalletType = new clsPalletType();
            clsPalletDimentions objPalletDimentions = new clsPalletDimentions();
            clsPallet objPallet = new clsPallet();
            clsCuttingOrderDetail objCuttingOrderDetail = new clsCuttingOrderDetail();
            clsProduct objProduct = new clsProduct();
            txtPalletCode.ResetText();
            txtCoilCode.ResetText();
            txtCoilCodeToSearch.ResetText();
            lblPalletType.ResetText();
            LblDimentions.ResetText();
            lblDestination.ResetText();
            lblEstado.ResetText();
            lblPosicion.ResetText();
            lblProduct.ResetText();
            lblBodega.ResetText();
            lblNetWeigth.Text = "0.0";
            lblGrossWeigth.Text = "0.0";
            chkReOpen.Enabled = false;
        }

        private void calculatePalletNetWeigth()
        {
            double palletNetWeigth = 0;
            if (objPallet.codsec > 0)
            {
                for (int i = 0; i < dgvCoils.Rows.Count; i++)
                    palletNetWeigth += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value);

                objPallet.netWeight = palletNetWeigth;
                lblNetWeigth.Text = palletNetWeigth.ToString();
                objPallet.save();
            }
        }

        private void printPalletLabel(int palletCodsec, string palletLabelType)
        {
            if (palletLabelType == "local")
            
            {
                rptPalletLabel rptPalletLabel = new rptPalletLabel();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmHead = new ParameterDiscreteValue();
                prmHead.Value = GenerateHead(palletCodsec);

                ParameterField pfldHead = new ParameterField();
                pfldHead.Name = "film";
                pfldHead.CurrentValues.Add(prmHead);
                pfldHead.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;

                        case "film":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmHead);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmHead);
                            break;

                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();

                //rptPalletLabel.PrintOptions.PaperOrientation = PaperOrientation.Landscape;
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count;i++)
                    {
                        if(PrinterSettings.InstalledPrinters[i]=="\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }
                        
                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                
                
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else if (palletLabelType == "external")
            {
                rptOppPalletLabel rptPalletLabel = new rptOppPalletLabel();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else
            {
                rptMixedPalletLabel rptPalletLabel = new rptMixedPalletLabel();

                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);

            }
        }

        private void printPalletLabelPL(int palletCodsec, string palletLabelType)
        {
            if (palletLabelType == "local")
            {
                Reports.Pilar.rptPalletLabelPL rptPalletLabel = new Reports.Pilar.rptPalletLabelPL();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmHead = new ParameterDiscreteValue();
                prmHead.Value = GenerateHead(palletCodsec);

                ParameterField pfldHead = new ParameterField();
                pfldHead.Name = "film";
                pfldHead.CurrentValues.Add(prmHead);
                pfldHead.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;

                        case "film":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmHead);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmHead);
                            break;

                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                //rptPalletLabel.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else if (palletLabelType == "external")
            {
                rptOppPalletLabel rptPalletLabel = new rptOppPalletLabel();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else
            {
                rptMixedPalletLabel rptPalletLabel = new rptMixedPalletLabel();

                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);

            }
        }

        private static string GenerateHead(int palletCodsec)
        {
            string myProduct = "";
            clsPallet objPallet = new clsPallet(palletCodsec);
            if (objPallet.product.code.StartsWith("EM") || objPallet.product.code.StartsWith("ET"))
                myProduct = "PET Biorientado";
            else if (objPallet.product.code.StartsWith("RK") || objPallet.product.code.StartsWith("RP"))
                myProduct = "Película Recubierta";
            else if (objPallet.product.code.StartsWith("A"))
                myProduct = "Nylon";
            else if (objPallet.product.code.StartsWith("PA0"))
                myProduct = "Papel";
            else
                myProduct = "Película de polipropileno biorientado";

            return myProduct;
        }

        private void printPalletLabelSpecial(int palletCodsec, string palletLabelType)
        {
            if (palletLabelType == "local")
            {
                rptPalletLabelSpecial rptPalletLabel = new rptPalletLabelSpecial();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                //rptPalletLabel.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else if (palletLabelType == "external")
            {
                rptPalletLabelSpecial rptPalletLabel = new rptPalletLabelSpecial();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else
            {
                rptPalletLabelSpecial rptPalletLabel = new rptPalletLabelSpecial();

                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);

            }
        }

        private void printPalletLabelSpecialPL(int palletCodsec, string palletLabelType)
        {
            if (palletLabelType == "local")
            {
                BPS.Lite.Reports.Pilar.rptPalletLabelSpecialPL rptPalletLabel = new BPS.Lite.Reports.Pilar.rptPalletLabelSpecialPL();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                //rptPalletLabel.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else if (palletLabelType == "external")
            {
                BPS.Lite.Reports.Pilar.rptPalletLabelSpecialPL rptPalletLabel = new BPS.Lite.Reports.Pilar.rptPalletLabelSpecialPL();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else
            {
                BPS.Lite.Reports.Pilar.rptPalletLabelSpecialPL rptPalletLabel = new BPS.Lite.Reports.Pilar.rptPalletLabelSpecialPL();

                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);

            }
        }

        private void printPalletLabelSpecial2(int palletCodsec, string palletLabelType)
        {
            if (palletLabelType == "local")
            {
                rptPalletLabelSpecial3 rptPalletLabel = new rptPalletLabelSpecial3();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmHead = new ParameterDiscreteValue();
                prmHead.Value = GenerateHead(palletCodsec);

                ParameterField pfldHead = new ParameterField();
                pfldHead.Name = "film";
                pfldHead.CurrentValues.Add(prmHead);
                pfldHead.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;

                        case "film":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmHead);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmHead);
                            break;

                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                //rptPalletLabel.PrintOptions.PaperOrientation = PaperOrientation.Landscape;

                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else if (palletLabelType == "external")
            {
                rptOppPalletLabel rptPalletLabel = new rptOppPalletLabel();
                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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
                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);
            }
            else
            {
                rptMixedPalletLabel rptPalletLabel = new rptMixedPalletLabel();

                Tables tables;

                tables = rptPalletLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
                prmPalletCodsec.Value = palletCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "palletCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "palletCodsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
                {
                    for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                    {
                        if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                        {
                            rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                        }
                        else
                        {
                            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                        }
                    }

                }
                else
                {
                    rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                }
                rptPalletLabel.PrintToPrinter(4, false, 0, 0);

            }
        }

        private void printIncompletePalletLabel(int palletCodsec)
        {

            rptIncompletePalletLabel rptPalletLabel = new rptIncompletePalletLabel();

            Tables tables;

            tables = rptPalletLabel.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptPalletLabel.ReportDefinition.Sections;
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

            ParameterDiscreteValue prmPalletCodsec = new ParameterDiscreteValue();
            prmPalletCodsec.Value = palletCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "palletCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
            {
                switch (rptPalletLabel.ParameterFields[i].Name)
                {
                    case "palletCodsec":
                        rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                        rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                        rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                        rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                        rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            if (clsGlobal.LoggedUser.fkRole == 2026 || clsGlobal.LoggedUser.fkRole == 2027)
            {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    if (PrinterSettings.InstalledPrinters[i] == "\\\\Store2\\TSC PALLETS")
                    {
                        rptPalletLabel.PrintOptions.PrinterName = "\\\\Store2\\TSC PALLETS";
                    }
                    else
                    {
                        rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                    }
                }

            }
            else
            {
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            }
            rptPalletLabel.PrintToPrinter(4, false, 0, 0);

        }

        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilAction.Index)
            {
                if (objPallet.statusName == "Abierto")
                {
                    if (objPallet.fkPalletCoilcellar == 1011 || objPallet.fkPalletCoilcellar == 4011 || objPallet.fkPalletCoilcellar == 4012 || objPallet.fkPalletCoilcellar == 4013 || objPallet.fkPalletCoilcellar == 4016)
                    {
                        MessageBox.Show("No se puede modificar el pallet porque no se encuentra en la bodega de Corte, Conversión o Producto en proceso. Solicite el movimiento del pallet a logistica.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        //chkReOpen.Checked = false;
                    }
                    else
                    {
                        if (MessageBox.Show("Esta seguro que desea eliminar la bobina del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            if (objPallet.removeCoilToPallet(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value)))
                            {
                                dgvCoils.Rows.Remove(dgvCoils.Rows[e.RowIndex]);
                                lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                                calculatePalletNetWeigth();
                                if(objPallet.coilCount==0)
                                {
                                    MessageBox.Show("El palet quedó vacio. Genere un nuevo pallet.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    limpiar();
                                }
                            }
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        /*private void btnProcess_Click(object sender, EventArgs e)
        {
            string palletLabelType = "";

            objPallet.load(objPallet.codsec);

            int externalCoilCount = 0;
            for (int i = 0; i < dgvCoils.Rows.Count; i++)
            {
                if ((new clsCoil(Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value))).isExternalCoil)
                    externalCoilCount++;
            }

            if (externalCoilCount == 0)
                palletLabelType = "local";
            else if (externalCoilCount == objPallet.lstCoil.Count)
                palletLabelType = "external";
            else
                palletLabelType = "mixed";

            if (enablePrintButon == false)
            {
                objPallet.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                objPallet.save();

                if (dgvCoils.Rows.Count == objPallet.palletType.coilNumber)
                {
                    if (objPallet.close())
                    {
                        MessageBox.Show("El pallet ha sido cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                        objPallet.load(objPallet.codsec);
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                        btnClose.Enabled = false;
                        if (objPallet.customerName != "CONFITECA")
                            printPalletLabel(objPallet.codsec, palletLabelType);
                        else
                            printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                    }
                    else
                        MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else if (chkPrintIncomplePallet.Checked == true)
                {
                    MessageBox.Show("Se imprimirá una etiqueta de pallet incompleto para ser completado en el futuro.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    objPallet.load(objPallet.codsec);
                    printIncompletePalletLabel(objPallet.codsec);
                }
                else
                    MessageBox.Show("Debe completar el número de bobinas asignadas para este pallet, están registradas " + dgvCoils.Rows.Count.ToString() + " y el pallet seleccionado es de " + objPallet.palletType.coilNumber.ToString() + ".", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
            {
                if (objPallet.customerName != "CONFITECA")
                    printPalletLabel(objPallet.codsec, palletLabelType);
                else
                    printPalletLabelSpecial(objPallet.codsec, palletLabelType);
            }
        }*/

        /*private void chkPrintIncomplePallet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrintIncomplePallet.Checked == true)
            {
                btnClose.Image = global::BPS.Lite.Properties.Resources.printer;
                btnClose.Text = "Etiqueta";
            }
            else
            {
                btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
                btnClose.Text = "Cerrar";
            }
        }*/

        private void btnChangeWeight_Click(object sender, EventArgs e)
        {
            if (flgChangeWeight == true)
            {
                if (MessageBox.Show("Esta seguro que desea modificar el peso bruto del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objPallet.grossWeight = Convert.ToDouble(txtNewGrossWeight.Text);
                    objPallet.save();
                    txtGrossWeigth.Text = txtNewGrossWeight.Text;
                    txtNewGrossWeight.Visible = false;
                }

                btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.arrow_refresh;
                flgChangeWeight = false;
            }
            else
            {
                if (bal1.codsec != 0)
                {
                    timer1.Enabled = true;
                }
                btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.disk;
                flgChangeWeight = true;
                txtNewGrossWeight.Visible = true;
                txtNewGrossWeight.Text = txtGrossWeigth.Text;
                txtNewGrossWeight.Focus();
                ActiveControl = txtNewGrossWeight;
            }
        }

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                isStockPallet = false;
                objPallet = clsPallet.getCompleteDetailByCode(txtPalletCode.Text);

                if (objPallet.fkStatus == 40 || objPallet.fkStatus == 3073)
                    chkReOpen.Enabled = false;

                if (objPallet.codsec != 0)
                {
                    if(objPallet.lstCoil.Count>0)
                    {
                        objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);

                        if (objSalesOrder.fkEntity == 199 || objSalesOrder.fkEntity == 305 || objSalesOrder.fkEntity == 143)
                        {
                            clsProduct objProductParameter = new clsProduct();
                            objProductParameter.load(objPallet.fkProduct);
                            if (objProductParameter.fkBopp > 0)
                            {
                                clsParameterMontana objParameter = new clsParameterMontana();
                                objParameter = clsParameterMontana.getDescriptionByBopp(objProductParameter.fkBopp);
                                flgName = objParameter.notes;
                            }
                            else
                            {
                                clsParameterMontana objParameter = new clsParameterMontana();
                                objParameter = clsParameterMontana.getDescriptionByCast(objProductParameter.fkCast);
                                flgName = objParameter.notes;
                            }
                        }
                        else
                            flgName = "";

                        if (objSalesOrder.codsec > 0)
                        {
                            for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                            {
                                if (objSalesOrder.lstSalesOrderDetail[i].fkProduct == objPallet.fkProduct)
                                    objSalesOrderDetail = objSalesOrder.lstSalesOrderDetail[i];
                            }
                        }

                        objPalletType = objPallet.palletType;
                        objPalletDimentions = objPallet.palletDimention;
                        objProduct = objPallet.product;

                        if (objSalesOrder.codsec != 0)
                            lblDestination.Text = objPallet.fkSalesOrder + "  -  " + objSalesOrder.EntityName; //objSalesOrder.number
                        else
                            lblDestination.Text = "Stock";


                        //Doy de alta un objeto bodega para poder mostrar en pantalla la bodega
                        clsCoilCellar bodega = new clsCoilCellar(objPallet.fkPalletCoilcellar);
                        //Aca termino

                        lblPalletType.Text = objPalletType.name;
                        LblDimentions.Text = objPalletDimentions.ToString();
                        lblPosicion.Text = objPallet.position;
                        lblEstado.Text = objPallet.statusName;
                        lblBodega.Text = bodega.name;
                        lblProduct.Text = objProduct.code;
                        lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();

                        dgvCoils.Rows.Clear();

                        if (objPallet.statusName == "Activo")
                        {
                            btnClose.Enabled = true;
                            btnClose.Image = global::BPS.Lite.Properties.Resources.printer;
                            btnClose.Text = "Etiqueta";
                            chkReOpen.Visible = true;
                            //chkPrintIncomplePallet.Visible = false;
                            lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                            enablePrintButon = true;
                        }
                        else if (objPallet.statusName == "Abierto")
                        {
                            btnClose.Enabled = true;
                            lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                            enablePrintButon = false;
                            btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
                            btnClose.Text = "Cerrar";
                            //chkPrintIncomplePallet.Visible = true;
                            chkReOpen.Visible = false;
                        }
                        else if (objPallet.fkStatus == 40)
                        {
                            btnClose.Enabled = true;
                            lblStatusColor.BackColor = Color.FromArgb(0, 170, 228);
                            enablePrintButon = true;
                            btnClose.Image = global::BPS.Lite.Properties.Resources.printer;
                            btnClose.Text = "Etiqueta";
                            //chkPrintIncomplePallet.Visible = true;
                            chkReOpen.Visible = false;
                        }// Aca se  va a agregar para que tenga en cuenta el pre-despachado
                        else if (objPallet.fkStatus == 3073)
                        {
                            btnClose.Enabled = true;
                            enablePrintButon = true;
                            btnClose.Image = global::BPS.Lite.Properties.Resources.printer;
                            btnClose.Text = "Etiqueta";
                            chkReOpen.Enabled = false;
                        }
                        else
                        {
                            btnClose.Enabled = true;
                            lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                            enablePrintButon = false;
                            btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
                            btnClose.Text = "Cerrar";
                            //chkPrintIncomplePallet.Visible = true;
                            chkReOpen.Visible = true;
                        }

                        for (int i = 0; i < objPallet.lstCoil.Count; i++)
                        {
                            dgvCoils.Rows.Add();
                            dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                            dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                            dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                            dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 1, MidpointRounding.AwayFromZero));
                            dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                            dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                        }
                        lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                        lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 1));
                        txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 1));

                        if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú" || objPallet.fkCoilCellar1 == 3 || objPallet.fkCoilCellar1 == 4 || objPallet.fkCoilCellar1 == 8 || objPallet.coilCellarName1 == "Producto Terminado" || objPallet.coilCellarName1 == "Stock Local" || objPallet.coilCellarName1 == "Stock Perú")
                        {
                            btnChangeWeight.Enabled = false;
                            txtCoilCode.Enabled = false;
                            btnAddCoil.Enabled = false;
                        }
                        else
                        {
                            btnChangeWeight.Enabled = true;
                            txtCoilCode.Enabled = true;
                            btnAddCoil.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El pallet ingresado está vacio. Genere un nuevo pallet.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    
                }
                else
                {
                    MessageBox.Show("No existe un pallet registrado con ese código.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    lblPalletType.Text = "";
                    LblDimentions.Text = "";
                    lblDestination.Text = "";
                    lblProduct.Text = "";
                    lblNetWeigth.Text = "0.0";
                    txtNewGrossWeight.Text = "0.0";
                    txtGrossWeigth.Text = "0.0";
                    dgvCoils.Rows.Clear();
                }

            }
        }

        private void btnAddCoil_Click(object sender, EventArgs e)
        {
            if (objPallet.statusName == "Abierto")
            {
                clsCoil objCoil = new clsCoil();

                objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);

                if(objCoil.fkStatus==33)
                {
                    if (objCoil.codsec != 0)
                    {
                        if (objCoil.fkProduct == objProduct.codsec)
                        {
                            bool isEnabledToBeAdded = false;
                            if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec == objSalesOrderDetail.codsec)
                                isEnabledToBeAdded = true;
                            else if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec != objSalesOrderDetail.codsec)
                                isEnabledToBeAdded = false;
                            else if (isStockPallet == true)
                                isEnabledToBeAdded = true;


                            if (isEnabledToBeAdded)
                            {
                                if (clsCoil.IsInPallet(objCoil.codsec))
                                {
                                    if (objPallet.codsec == 0)
                                    {
                                        objPallet.save(objSalesOrderDetail.codsec, objCuttingOrderDetail.codsec);
                                        objPallet.load(objPallet.codsec);
                                    }

                                    if (objPallet.addCoilToPallet(objCoil.codsec))
                                    {
                                        dgvCoils.Rows.Add();
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1));
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                        lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                        calculatePalletNetWeigth();
                                        objPallet.validarCompletitud();
                                    }
                                    else
                                        MessageBox.Show("Se ha producido un error al momento de registrar la bobina en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                }
                                else
                                    MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            }
                            else
                                MessageBox.Show("La bobina seleccionada no esta asociada a la orden de venta a la que pertenece el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                            MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }

                    txtCoilCode.Text = "";
                    txtCoilCode.Focus();
                }
                else
                {
                    MessageBox.Show("La bobina seleccionada no se pudo ingresar al pallet porque no está activa. Esto pudo suceder porque ya fue reprocesada previamente y se declaro como cerrada.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            else
                MessageBox.Show("No se puede modificar el pallet. El pallet debe estar abierto.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnChangeWeight_Click_1(object sender, EventArgs e)
        {
            if (flgChangeWeight == true)
            {
                if (MessageBox.Show("Esta seguro que desea modificar el peso bruto del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objPallet.grossWeight = Convert.ToDouble(txtNewGrossWeight.Text);
                    objPallet.save();
                    txtGrossWeigth.Text = txtNewGrossWeight.Text;
                    txtGrossWeigth.Visible = true;
                    txtNewGrossWeight.Visible = false;
                }
                timer1.Enabled = false;
                btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.arrow_refresh;
                flgChangeWeight = false;
            }
            else
            {
                if (bal1.codsec != 0)
                {
                    timer1.Enabled = true;
                }
                btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.disk;
                flgChangeWeight = true;
                txtNewGrossWeight.Visible = true;
                txtNewGrossWeight.Text = txtGrossWeigth.Text;
                txtGrossWeigth.Visible = false;
                txtNewGrossWeight.Focus();

                ActiveControl = txtNewGrossWeight;
            }
        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (e.KeyCode == Keys.Enter)
            {
                if (objPallet.statusName == "Abierto")
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if(objCoil.fkStatus==33)
                    {
                        if (objCoil.codsec != 0)
                        {
                            if (objCoil.fkProduct == objProduct.codsec)
                            {
                                bool isEnabledToBeAdded = false;
                                if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec == objSalesOrderDetail.codsec)
                                    isEnabledToBeAdded = true;
                                else if (isStockPallet == false && (clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec != objSalesOrderDetail.codsec)
                                    isEnabledToBeAdded = false;
                                else if (isStockPallet == true)
                                    isEnabledToBeAdded = true;


                                if (isEnabledToBeAdded)
                                {
                                    if (!clsCoil.IsInPallet(objCoil.codsec))
                                    {
                                        if (objPallet.codsec == 0)
                                        {

                                            objPallet.save(objSalesOrderDetail.codsec, objCuttingOrderDetail.codsec);
                                            objPallet.load(objPallet.codsec);
                                        }

                                        //if (dgvCoils.Rows.Count < objPallet.palletType.coilNumber)
                                        //{
                                        if (objPallet.addCoilToPallet(objCoil.codsec))
                                        {
                                            dgvCoils.Rows.Add();
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1));
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                            calculatePalletNetWeigth();
                                            objPallet.validarCompletitud();

                                        }
                                        else
                                            MessageBox.Show("Se ha producido un error al momento de registrar la bobina en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        //}
                                        //else
                                        //{
                                        //    MessageBox.Show("Ya han sido ingresadas el número total de bobinas al pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        //}
                                    }
                                    else
                                        MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                }
                                else
                                    MessageBox.Show("La bobina seleccionada no esta asociada a la orden de venta a la que pertenece el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }
                            else
                                MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }

                        txtCoilCode.Text = "";
                        txtCoilCode.Focus();
                    }
                    else
                    {
                        MessageBox.Show("La bobina seleccionada no se pudo ingresar al pallet porque no está activa. Esto pudo suceder porque ya fue reprocesada previamente y se declaro como cerrada.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                    MessageBox.Show("No se puede modificar el pallet. El pallet debe estar abierto", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }      
        }

        private void btnPrintCoilsLabels_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string palletLabelType = "";

            
            objPallet.load(objPallet.codsec);
            clsCoilCellar cellar = new clsCoilCellar(objPallet.fkCoilCellar1);
            int externalCoilCount = 0;
            for (int i = 0; i < dgvCoils.Rows.Count; i++)
            {
                if ((new clsCoil(Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value))).externalLabelPrint)
                    externalCoilCount++;
            }

            if (externalCoilCount == 0)
                palletLabelType = "local";
            else if (externalCoilCount == objPallet.lstCoil.Count)
                palletLabelType = "external";
            else
                palletLabelType = "mixed";

            if (enablePrintButon == false)
            {
                objPallet.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                objPallet.save();


                    var inf = clsPallet.getStatusOpenPallet(objPallet);

                    if (inf == "OK")
                    {
                        if (objPallet.close())
                        {
                            //TODO: Aca esta la verificacion del pedido, en caso que no se de ir testeando los logfiles de corte.
                            if(objPallet.fkSalesOrderDetail!=0)
                                objPallet.validarCompletitud(); 
                          
                                MessageBox.Show("El pallet ha sido cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                objPallet.load(objPallet.codsec);
                                lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                                btnClose.Enabled = false;

                                if (objPallet.customerName.ToUpper() == "MONTANA GRAFICA, C.A." || objPallet.customerName.ToUpper() == "TIENDAS MONTANA C.A" ||
                                    objPallet.customerName.ToUpper().Trim().Replace(" ", "") == "MACROPORTINTERNACIONALLTDA.")
                                {
                                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecialCustomer(objPallet.codsec, flgName); });
                                    thrdPrint.Start();
                                    thrdPrint.Join();
                                    flgName = "";
                                }
                                else if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                                    switch (cellar.fkPlant)
                                    {
                                        case 3:
                                            Thread thrdPrint;
                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                            break;

                                        case 4:
                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecialPL(objPallet.codsec, palletLabelType); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                            break;

                                        default:
                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                            break;
                                    }
                                else if (objPallet.customerName == "ENVASANDO S.R.L.")
                                    printPalletLabelSpecial2(objPallet.codsec, palletLabelType);
                                else
                                {
                                    switch (cellar.fkPlant)
                                    {
                                        case 3:
                                            Thread thrdPrint;
                                            thrdPrint = new Thread(delegate() { printPalletLabel(objPallet.codsec, palletLabelType); ; });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                            break;

                                        case 4:
                                            thrdPrint = new Thread(delegate() { printPalletLabelPL(objPallet.codsec, palletLabelType); ; });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                            break;

                                        default:
                                            thrdPrint = new Thread(delegate() { printPalletLabel(objPallet.codsec, palletLabelType); ; });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                            break;
                                    }
                                }
                            
                        }
                        else
                            MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show(inf, "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);

                //else if (chkPrintIncomplePallet.Checked == true)
                //{
                //    MessageBox.Show("Se imprimirá una etiqueta de pallet incompleto para ser completado en el futuro.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                //    objPallet.load(objPallet.codsec);
                //    printIncompletePalletLabel(objPallet.codsec);
                //}
                //else
                //    MessageBox.Show("Debe completar el número de bobinas asignadas para este pallet, están registradas " + dgvCoils.Rows.Count.ToString() + " y el pallet seleccionado es de " + objPallet.palletType.coilNumber.ToString() + ".", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
            {
                if (objPallet.customerName.ToUpper() == "MONTANA GRAFICA, C.A." || objPallet.customerName.ToUpper() == "TIENDAS MONTANA C.A" ||
                    objPallet.customerName.ToUpper().Trim().Replace(" ", "") == "MACROPORTINTERNACIONALLTDA.")
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecialCustomer(objPallet.codsec, flgName); });
                    thrdPrint.Start();
                    thrdPrint.Join();
                    flgName = "";
                }
                else if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                {
                    switch(cellar.fkPlant)
                    {
                        case 3:
                            printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                            break;
                        case 4:
                            printPalletLabelSpecialPL(objPallet.codsec, palletLabelType);
                            break;
                        default:
                            printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                            break;
                    }
                }    
                else if (objPallet.customerName == "ENVASANDO S.R.L.")
                    printPalletLabelSpecial2(objPallet.codsec, palletLabelType);
                else
                {
                    switch(cellar.fkPlant)
                    {
                        case 3:
                            printPalletLabel(objPallet.codsec, palletLabelType);
                            break;
                        case 4:
                            printPalletLabelPL(objPallet.codsec, palletLabelType);
                            break;
                        default:
                            printPalletLabel(objPallet.codsec, palletLabelType);
                            break;
                    }
                }
            }

            if (enablePrintButon == false)
            {
             
            // Lo pongo acá por que en cada notificacion de pallet se creaba uno nuevo. 
            clsPalletMovements movPallet = new clsPalletMovements();


            movPallet.fkPallet = objPallet.codsec;
            movPallet.fkProduct = objPallet.fkProduct;
            movPallet.type = "Se cerró el pallet.";
            movPallet.fkUser = clsGlobal.LoggedUser.codsec;
            movPallet.fkOrigCellar = objPallet.fkCoilCellar;
            movPallet.fkDestCellar = objPallet.fkCoilCellar;
            movPallet.date = DateTime.Now;

            movPallet.save();

            }
            else
            {

                // Lo pongo acá por que en cada notificacion de pallet se creaba uno nuevo. 
                clsPalletMovements movPallet = new clsPalletMovements();


                movPallet.fkPallet = objPallet.codsec;
                movPallet.fkProduct = objPallet.fkProduct;
                movPallet.type = "Se imprimió etiqueta del pallet.";
                movPallet.fkUser = clsGlobal.LoggedUser.codsec;
                movPallet.fkOrigCellar = objPallet.fkCoilCellar;
                movPallet.fkDestCellar = objPallet.fkCoilCellar;
                movPallet.date = DateTime.Now;

                movPallet.save();

            }

        }

        private void chkReOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea reabrir el pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                if (objPallet.fkPalletCoilcellar == 1011 || objPallet.fkPalletCoilcellar == 4011 || objPallet.fkPalletCoilcellar == 4012 || objPallet.fkPalletCoilcellar == 4013 || objPallet.fkPalletCoilcellar == 4016) 
                {
                    MessageBox.Show("No se puede modificar el pallet porque no se encuentra en la bodega de Corte, Conversión o Producto en proceso. Solicite el movimiento del pallet a logistica.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    if (objPallet.fkStatus == 40 || objPallet.fkStatus == 3073)
                        MessageBox.Show("No puede reabrir un pallet despachado o Pre-Despachado", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    else
                    {
                        if (objPallet.open())
                        {
                            MessageBox.Show("El pallet se ha reabierto.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            objPallet.load(objPallet.codsec);
                            btnClose.Enabled = true;
                            lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                            enablePrintButon = false;
                            btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
                            btnClose.Text = "Cerrar";
                            //chkPrintIncomplePallet.Visible = true;
                        }
                    }
                }
            }
        }

        private void chkSearchByCoil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchByCoil.Checked == true)
            {
                grpbSearchByCoil.Enabled = true;
                txtCoilCodeToSearch.Text = "";
                txtCoilCodeToSearch.Focus();
            }
            else
            {
                grpbSearchByCoil.Enabled = false;
                txtCoilCodeToSearch.Text = "";
                txtPalletCode.Focus();
            }
        }

        private void txtCoilCodeToSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                isStockPallet = false;
                clsCoil objCoil = clsCoil.getDetailByCode(txtCoilCodeToSearch.Text);

                if (objCoil.codsec != 0)
                {
                    if (clsCoil.IsInPallet(objCoil.codsec))
                    {

                        objPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                        if (objPallet.codsec != 0)
                        {
                            objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);

                            if (objSalesOrder.fkEntity == 199 || objSalesOrder.fkEntity == 305 || objSalesOrder.fkEntity == 143)
                            {
                                clsProduct objProductParameter = new clsProduct();
                                objProductParameter.load(objPallet.fkProduct);
                                if (objProductParameter.fkBopp > 0)
                                {
                                    clsParameterMontana objParameter = new clsParameterMontana();
                                    objParameter = clsParameterMontana.getDescriptionByBopp(objProductParameter.fkBopp);
                                    flgName = objParameter.notes;
                                }
                                else
                                {
                                    clsParameterMontana objParameter = new clsParameterMontana();
                                    objParameter = clsParameterMontana.getDescriptionByCast(objProductParameter.fkCast);
                                    flgName = objParameter.notes;
                                }
                            }
                            else
                                flgName = "";

                            if (objSalesOrder.codsec > 0)
                            {
                                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                                {
                                    if (objSalesOrder.lstSalesOrderDetail[i].fkProduct == objPallet.fkProduct)
                                        objSalesOrderDetail = objSalesOrder.lstSalesOrderDetail[i];
                                }
                            }

                            objPalletType = objPallet.palletType;
                            objPalletDimentions = objPallet.palletDimention;
                            objProduct = objPallet.product;


                            if (objSalesOrder.codsec != 0)
                                lblDestination.Text = objPallet.fkSalesOrder +"  -  " + objSalesOrder.EntityName; //objSalesOrder.number 
                            else
                                lblDestination.Text = "Stock";

                            //Doy de alta un objeto bodega para poder mostrar en pantalla la bodega
                            clsCoilCellar bodega = new clsCoilCellar(objPallet.fkCoilCellar1);
                            //Aca termino

                            lblPalletType.Text = objPalletType.name;
                            LblDimentions.Text = objPalletDimentions.ToString();
                            lblEstado.Text = objPallet.statusName;
                            lblBodega.Text = bodega.name;
                            lblPosicion.Text = objPallet.position;
                            lblProduct.Text = objProduct.code;
                            lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();
                            txtPalletCode.Text = objPallet.code;

                            dgvCoils.Rows.Clear();

                            if (objPallet.statusName == "Activo")
                            {
                                btnClose.Enabled = true;
                                btnClose.Image = global::BPS.Lite.Properties.Resources.printer;
                                btnClose.Text = "Etiqueta";
                                chkReOpen.Visible = true;
                                //chkPrintIncomplePallet.Visible = false;
                                lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                                enablePrintButon = true;
                            }
                            else if (objPallet.statusName == "Abierto")
                            {
                                btnClose.Enabled = true;
                                lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                                enablePrintButon = false;
                                btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
                                btnClose.Text = "Cerrar";
                                //chkPrintIncomplePallet.Visible = true;
                                chkReOpen.Visible = false;
                            }
                            else
                            {
                                btnClose.Enabled = true;
                                lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                                enablePrintButon = false;
                                btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
                                btnClose.Text = "Cerrar";
                                //chkPrintIncomplePallet.Visible = true;
                                chkReOpen.Visible = true;
                            }

                            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                            {
                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                                dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                                dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                                dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 1, MidpointRounding.AwayFromZero));
                                dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                                dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                            }
                            lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                            lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 1));
                            txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 1));

                            if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú" || objPallet.fkCoilCellar1 == 3 || objPallet.fkCoilCellar1 == 4 || objPallet.fkCoilCellar1 == 8 || objPallet.coilCellarName1 == "Producto Terminado" || objPallet.coilCellarName1 == "Stock Local" || objPallet.coilCellarName1 == "Stock Perú")
                            {
                                btnChangeWeight.Enabled = false;
                                txtCoilCode.Enabled = false;
                                btnAddCoil.Enabled = false;
                            }
                            else
                            {
                                btnChangeWeight.Enabled = true;
                                txtCoilCode.Enabled = true;
                                btnAddCoil.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("No existe un pallet registrado con ese código.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            lblPalletType.Text = "";
                            LblDimentions.Text = "";
                            lblDestination.Text = "";
                            lblProduct.Text = "";
                            lblNetWeigth.Text = "0.0";
                            txtNewGrossWeight.Text = "0.0";
                            txtGrossWeigth.Text = "0.0";
                            dgvCoils.Rows.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("La bobina seleccionada no pertenece a ningún pallet.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        lblPalletType.Text = "";
                        LblDimentions.Text = "";
                        lblDestination.Text = "";
                        lblProduct.Text = "";
                        lblNetWeigth.Text = "0.0";
                        txtNewGrossWeight.Text = "0.0";
                        txtGrossWeigth.Text = "0.0";
                        dgvCoils.Rows.Clear();
                        txtCoilCodeToSearch.Text = "";
                        txtCoilCodeToSearch.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El código ingresado no pertenece a ninguna bobina registrada.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    lblPalletType.Text = "";
                    LblDimentions.Text = "";
                    lblDestination.Text = "";
                    lblProduct.Text = "";
                    lblNetWeigth.Text = "0.0";
                    txtNewGrossWeight.Text = "0.0";
                    txtGrossWeigth.Text = "0.0";
                    dgvCoils.Rows.Clear();
                    txtCoilCodeToSearch.Text = "";
                    txtCoilCodeToSearch.Focus();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (bal1.codsec != 0)
                {
                    string data = bal1.getWeigth(txtNewGrossWeight.Text);
                    if (data != string.Empty)
                    {
                        data = data.Replace(",", ".");
                    }
                    if (clsGlobal.isNumeric(data))
                    {
                        txtNewGrossWeight.Text = Convert.ToDouble(data).ToString();
                    }
                    else
                    {
                        txtNewGrossWeight.Text = "0";
                    }
                }

            }
            catch
            {

            }
        }

        private void chkManual_CheckedChanged(object sender, EventArgs e)
        {
            if(chkManual.Checked == true)
            {
                timer1.Enabled = false;
                txtGrossWeigth.Enabled = true;
                txtNewGrossWeight.Enabled = true;
            }  
            else
            {
                timer1.Enabled = true;
                txtGrossWeigth.Enabled = false;
                txtNewGrossWeight.Enabled = false;
                
            }
        }


    }
}