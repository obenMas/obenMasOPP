using System;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmMainCoilWegith : Form
    {
        clsMainCoilMetal objMainCoilMetal = new clsMainCoilMetal();

        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        volatile bool continueReading = true;

        public frmMainCoilWegith()
        {
            InitializeComponent();
        }

        public frmMainCoilWegith(int codsec)
        {
            InitializeComponent();
            objMainCoilMetal = new clsMainCoilMetal(codsec);
        }

        private void getWeigth()
        {
            try
            {
                while (continueReading)
                {
                    if (sprtBalance.IsOpen == false)
                    {
                        sprtBalance.PortName = "COM5";
                        sprtBalance.Open();
                    }

                    string strReceivedData = sprtBalance.ReadLine();

                    if (strReceivedData != "\r")
                    {
                        if (strReceivedData.EndsWith("?\r"))
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 2)))
                            {
                                this.Invoke((MethodInvoker)delegate { txtGrossWeigth.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 2)), 1, MidpointRounding.AwayFromZero).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { txtGrossWeigth.ForeColor = Color.Red; });
                                this.Invoke((MethodInvoker)delegate { lblStatusColor.BackColor = Color.Red; });
                            }
                        }
                        else
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 1)))
                            {
                                this.Invoke((MethodInvoker)delegate { txtGrossWeigth.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 1)), 1, MidpointRounding.AwayFromZero).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { txtGrossWeigth.ForeColor = Color.Black; });
                                this.Invoke((MethodInvoker)delegate{lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);});
                            }
                        }
                    }
                }

                if (continueReading == false)
                    sprtBalance.Close();
            }
            catch (Exception)
            {
                continueReading = false;
                sprtBalance.Close();
            }
        }

        public void stopGettingWeigth()
        {
            continueReading = false;
        }

        private void frmMainCoilWegith_Load(object sender, EventArgs e)
        {
            try
            {
                thrdWeigth = new Thread(delegate() { getWeigth(); });

                if (sprtBalance.IsOpen)
                {
                    stopGettingWeigth();
                    sprtBalance.Close();
                }

                sprtBalance.PortName = "COM5";
                sprtBalance.ReadTimeout = 5000;
                sprtBalance.Open();
                continueReading = true;

                thrdWeigth.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.\n Por favor revise si el puerto COM esta en 5 COM5", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                chkManualWeight.Checked = true;
                chkManualWeight.Enabled = false;
            }                

        }

        private void printMaquileLabel(int codsec)
        {
            rptMaquileLabel rptMaquileLabel = new rptMaquileLabel();
            Tables tables;

            tables = rptMaquileLabel.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                table.ApplyLogOnInfo(tableLogonInfo);
            }

            Sections sections = rptMaquileLabel.ReportDefinition.Sections;
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
            prmPalletCodsec.Value = codsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "codsec";
            pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptMaquileLabel.ParameterFields.Count; i++)
            {
                switch (rptMaquileLabel.ParameterFields[i].Name)
                {
                    case "codsec":
                        rptMaquileLabel.ParameterFields[i].CurrentValues.Clear();
                        rptMaquileLabel.ParameterFields[i].CurrentValues.Add(prmPalletCodsec);
                        rptMaquileLabel.ParameterFields[i].HasCurrentValue = true;
                        rptMaquileLabel.ParameterFields[i].DefaultValues.Clear();
                        rptMaquileLabel.ParameterFields[i].DefaultValues.Add(prmPalletCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptMaquileLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptMaquileLabel.PrintToPrinter(1, false, 0, 0);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMainCoilMetal.codsec > 0)
                {
                    txtGrossWeigth.Text = txtManualGrossWeigth.Text;
                    objMainCoilMetal.grossWeigth = Convert.ToDouble(txtGrossWeigth.Text);
                    objMainCoilMetal.netWeigth = Convert.ToDouble(lblNetWeigth.Text);
                    objMainCoilMetal.decrease = (objMainCoilMetal.OriginWeigth - Convert.ToDouble(lblNetWeigth.Text));
                    if (objMainCoilMetal.bcode == "")
                        objMainCoilMetal.bcode = GenerateCode(objMainCoilMetal);
                    if (objMainCoilMetal.toUpdateWeigth())
                    {
                        if (MessageBox.Show("Peso generado correctamente!!\r\nDesea imprimir la etiqueta de la bobina metalizada", "Peso - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            printMetalizedLabel(objMainCoilMetal);
                            this.Close();
                        }
                        else
                            this.Close();
                    }
                    else
                        MessageBox.Show("La información no ha podido ser procesada!!", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                    MessageBox.Show("No se ha encontrado la bobina a pesar", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GenerateCode(clsMainCoilMetal objMainCoilMetal)
        {
            if (!objMainCoilMetal.isMaquile)
            {
                Random rdn = new Random();
                string code = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objMainCoilMetal.cuttingPosition.ToString(), 1) + clsGlobal.FillWithZeros(((new clsSequential().coil).ToString()), 4);
                if (clsMainCoilMetal.isUnique(code))
                {
                    clsSequential.addSequential("coil");
                    return code;
                }
                else
                {
                    code += rdn.Next(111, 888).ToString();
                    if (clsMainCoilMetal.isUnique(code))
                    {
                        clsSequential.addSequential("coil");
                        return code;
                    }
                    return "";
                }
            }
            else
            {
                Random rdn = new Random();
                string code = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objMainCoilMetal.cuttingPosition.ToString(), 1) + clsGlobal.FillWithZeros(((new clsSequential().maquile).ToString()), 4);
                if (clsMainCoilMetal.isUnique(code))
                {
                    clsSequential.addSequential("maquile");
                    return code;
                }
                else
                {
                    code += rdn.Next(111, 888).ToString();
                    if (clsMainCoilMetal.isUnique(code))
                    {
                        clsSequential.addSequential("maquile");
                        return code;
                    }
                    return "";
                }
            }
        }

        private void printMetalizedLabel(clsMainCoilMetal objMainCoilMetal)
        {
            rptMetalizedCoil rptPalletLabel = new rptMetalizedCoil();
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
            prmPalletCodsec.Value = objMainCoilMetal.codsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "codsec";
            pfldCoilCodsec.CurrentValues.Add(prmPalletCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

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
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptPalletLabel.PrintToPrinter(1, false, 0, 0);
        }

        private void txtManualGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            if (!objMainCoilMetal.isMaquile)
            {
                if (txtCore.Text.Length > 0)
                {
                    if (txtManualGrossWeigth.Text.Length > 0)
                    {
                        double netWeigth = Convert.ToDouble(txtManualGrossWeigth.Text) - Convert.ToDouble(txtCore.Text);
                        lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());
                    }
                }


                //clsCoil objCoil = new clsCoil(objMainCoilMetal.fkorigin);
                //clsProduct objProduct = new clsProduct(objCoil.fkProduct);
                //txtGrossWeigth.Text = txtManualGrossWeigth.Text;
                //double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);
                //lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());

                
            }
            else
            {
                if (txtCore.Text.Length > 0)
                {
                    if (txtManualGrossWeigth.Text.Length > 0)
                    {
                        double netWeigth = Convert.ToDouble(txtManualGrossWeigth.Text) - Convert.ToDouble(txtCore.Text);
                        lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());
                    }
                }

                //double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - Convert.ToDouble(txtCore.Text);
                //lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());

                //txtGrossWeigth.Text = txtManualGrossWeigth.Text;
                //double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - 0.30;
                //lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());
            }
        }

        private void chkManualWeight_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkManualWeight.Checked == true)
                {
                    stopGettingWeigth();
                    txtManualGrossWeigth.Visible = true;
                    txtManualGrossWeigth.Focus();
                    MessageBox.Show("Recuerde que el Peso Neto de la Bobina se calculará de la siguiente manera: PESO BRUTO - PESO CORE", "Peso - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                {
                    txtManualGrossWeigth.Visible = false;
                    thrdWeigth = new Thread(delegate() { getWeigth(); });
                    if (sprtBalance.IsOpen)
                    {
                        stopGettingWeigth();
                        sprtBalance.Close();
                    }
                    sprtBalance.PortName = "COM5";
                    sprtBalance.ReadTimeout = 5000;
                    sprtBalance.Open();
                    continueReading = true;

                    thrdWeigth.Start();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                chkManualWeight.Checked = true;
                chkManualWeight.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtCore.Text.Length > 0)
            {
                if (txtManualGrossWeigth.Text.Length > 0)
                {
                    double netWeigth = Convert.ToDouble(txtManualGrossWeigth.Text) - Convert.ToDouble(txtCore.Text);
                    lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());
                }
            }
        }
    }
}