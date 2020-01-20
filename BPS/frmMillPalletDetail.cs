using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Reports;
using System.Threading;
using System.IO.Ports;

namespace BPS
{
    public partial class frmMillPalletDetail : Form
    {
        private int codsec = 0, fkmill = 0;

        public frmMillPalletDetail()
        {
            InitializeComponent();
        }

        public frmMillPalletDetail(int codsec, int fkmill)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.fkmill = fkmill;
            PopulateMill(codsec);
        }

        private void PopulateMill(int codsec)
        {
            clsMillPalletbyCoilCellar objMillPallet = new clsMillPalletbyCoilCellar(codsec, true);
            txtCode.Text = objMillPallet.code;
            lblType.Text = objMillPallet.product;
            lblMill.Text = objMillPallet.millName;
            lblBag.Text = objMillPallet.bag.ToString();
            lblWeigthPallet.Text = Math.Round(objMillPallet.palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
            lblWeigthGross.Text = Math.Round(objMillPallet.grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
            lblWeigthNet.Text = Math.Round(objMillPallet.netweigth, 1, MidpointRounding.AwayFromZero).ToString();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsMillPalletbyCoilCellar objMillPallet = new clsMillPalletbyCoilCellar(codsec);
                if (objMillPallet.codsec > 0)
                {
                    txtCode.Text = objMillPallet.code;
                    lblType.Text = objMillPallet.product;
                    lblMill.Text = objMillPallet.millName;
                    lblBag.Text = objMillPallet.bag.ToString();
                    lblWeigthPallet.Text = Math.Round(objMillPallet.palletweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    lblWeigthGross.Text = Math.Round(objMillPallet.grossweigth, 1, MidpointRounding.AwayFromZero).ToString();
                    lblWeigthNet.Text = Math.Round(objMillPallet.netweigth, 1, MidpointRounding.AwayFromZero).ToString();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printMetalizedLabel(fkmill);
        }

        private void printMetalizedLabel(int mainCoilMetal)
        {
            try
            {
                rptMillPallet rptPalletLabel = new rptMillPallet();
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
                prmPalletCodsec.Value = mainCoilMetal;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "codsec";
                pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                ParameterDiscreteValue prmOperation = new ParameterDiscreteValue();
                prmOperation.Value = "MillPalletReportByCodsec";

                ParameterField pfldOperation = new ParameterField();
                pfldOperation.Name = "operation";
                pfldOperation.CurrentValues.Add(prmOperation);
                pfldOperation.HasCurrentValue = true;

                ParameterDiscreteValue prmCode = new ParameterDiscreteValue();
                prmCode.Value = "Erwin";

                ParameterField pfldCode = new ParameterField();
                pfldCode.Name = "code";
                pfldCode.CurrentValues.Add(prmCode);
                pfldCode.HasCurrentValue = true;

                ParameterDiscreteValue prmInitDate = new ParameterDiscreteValue();
                prmInitDate.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ParameterField pfldInitDate = new ParameterField();
                pfldInitDate.Name = "initdate";
                pfldInitDate.CurrentValues.Add(prmInitDate);
                pfldInitDate.HasCurrentValue = true;

                ParameterDiscreteValue prmEndDate = new ParameterDiscreteValue();
                prmEndDate.Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                ParameterField pfldEndDate = new ParameterField();
                pfldEndDate.Name = "enddate";
                pfldEndDate.CurrentValues.Add(prmEndDate);
                pfldEndDate.HasCurrentValue = true;

                for (int i = 0; i < rptPalletLabel.ParameterFields.Count; i++)
                {
                    switch (rptPalletLabel.ParameterFields[i].Name)
                    {
                        case "codsec":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                            break;

                        case "operation":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmOperation);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmOperation);
                            break;

                        case "code":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmCode);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmCode);
                            break;

                        case "initdate":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmInitDate);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmInitDate);
                            break;

                        case "enddate":
                            rptPalletLabel.ParameterFields[i].CurrentValues.Clear();
                            rptPalletLabel.ParameterFields[i].CurrentValues.Add(prmEndDate);
                            rptPalletLabel.ParameterFields[i].HasCurrentValue = true;
                            rptPalletLabel.ParameterFields[i].DefaultValues.Clear();
                            rptPalletLabel.ParameterFields[i].DefaultValues.Add(prmEndDate);
                            break;

                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
