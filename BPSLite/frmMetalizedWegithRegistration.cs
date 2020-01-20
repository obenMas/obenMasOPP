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
    public partial class frmMetalizedWegithRegistration : Form
    {
        int codsec = 0;
        bool isMaquile = false;

        clsMetallizedOrderDetail objOrderDetail = new clsMetallizedOrderDetail();
        clsProduct objProduct = new clsProduct();
        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        volatile bool continueReading = true;

        public frmMetalizedWegithRegistration()
        {
            InitializeComponent();
        }

        public frmMetalizedWegithRegistration(int codsec, int fkproductTo, bool isMaquile)
        {
            InitializeComponent();
            this.codsec = codsec;
            this.isMaquile = isMaquile;
            objProduct.load(fkproductTo);
            objOrderDetail = clsMetallizedOrderDetail.getListByOrder(codsec, true);
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

        private void frmMetalizedWegithRegistration_Load(object sender, EventArgs e)
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

        private void printMetalizedLabel(int metalizedOrder)
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
            prmPalletCodsec.Value = metalizedOrder;

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
            rptPalletLabel.PrintToPrinter(2, false, 0, 0);
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
            rptMaquileLabel.PrintToPrinter(2, false, 0, 0);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                if (objOrderDetail.codsec > 0)
                {
                    if (!isMaquile)
                    {
                        clsCoil objCoil = new clsCoil(objOrderDetail.fkproductFrom);
                        objOrderDetail.grossweigth = Convert.ToDouble(txtGrossWeigth.Text);
                        objOrderDetail.netweigth = Convert.ToDouble(lblNetWeigth.Text);
                        objOrderDetail.decrease = CalculeDecrease(objCoil.netWeight, lblNetWeigth.Text);
                        if (objOrderDetail.code == "")
                            objOrderDetail.code = GenerateCode(objOrderDetail, isMaquile);

                        if (objOrderDetail.save())
                        {
                            if (MessageBox.Show("Peso generado correctamente!!\r\nDesea imprimir la etiqueta de la bobina metalizada", "Peso - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                printMetalizedLabel(codsec);
                                this.Close();
                            }
                            else
                                this.Close();
                        }
                        else
                            MessageBox.Show("La información no ha podido ser procesada!!", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                    {
                        clsMaquile objMaquile = new clsMaquile(objOrderDetail.fkproductFrom);
                        objOrderDetail.grossweigth = Convert.ToDouble(txtGrossWeigth.Text);
                        objOrderDetail.netweigth = Convert.ToDouble(lblNetWeigth.Text);
                        objOrderDetail.decrease = CalculeDecrease(objMaquile.weigth, lblNetWeigth.Text);
                        if (objOrderDetail.code == "")
                            objOrderDetail.code = GenerateCode(objOrderDetail, isMaquile);

                        if (objOrderDetail.save())
                        {
                            if (MessageBox.Show("Peso generado correctamente!!\r\nDesea imprimir la etiqueta de la bobina metalizada", "Peso - Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                            {
                                printMaquileLabel(codsec);
                                this.Close();
                            }
                            else
                                this.Close();
                        }
                        else
                            MessageBox.Show("La información no ha podido ser procesada!!", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
                else
                    MessageBox.Show("No se ha encontrado la Orden de Metalizado", "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GenerateCode(clsMetallizedOrderDetail objOrderDetail, bool isMaquile)
        {
            Random rdn = new Random();
            clsCoil objCoil = new clsCoil(objOrderDetail.fkproductFrom);
            if (!isMaquile)
            {
                string code = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objCoil.cuttingPosition.ToString(), 2) + clsGlobal.FillWithZeros(((new clsSequential().coil).ToString()), 4);
                if (objOrderDetail.code == code)
                {
                    clsSequential.addSequential("coil");
                    return code + rdn.Next(111, 888).ToString();
                }
                else
                    return code;
            }
            else
            {
                string code = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros("0", 2) + clsGlobal.FillWithZeros(((new clsSequential().maquile).ToString()), 4);
                if (clsMetallizedOrderDetail.isUnique(code))
                {
                    clsSequential.addSequential("maquile");
                    return code + rdn.Next(111, 888).ToString();
                }
                else
                    return code;
            }
        }

        private double CalculeDecrease(double netWeigthCoil, string netWeigthMetal)
        {
            return netWeigthCoil - Convert.ToDouble(netWeigthMetal);
        }
        
        private void txtManualGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            txtGrossWeigth.Text = txtManualGrossWeigth.Text;
            double netWeigth = Convert.ToDouble(txtGrossWeigth.Text) - (objProduct.width * (new clsCore(objProduct.fkCore)).weigthPerMilimeter);
            lblNetWeigth.Text = Convert.ToString(Math.Round(netWeigth, 2).ToString());
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
    }
}