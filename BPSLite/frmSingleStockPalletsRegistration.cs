using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms; 
using BPS.Bussiness;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;

namespace BPS.Lite
{
    public partial class frmSingleStockPalletsRegistration : Form
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
        CrystalReportViewer crvPalletLabel = new CrystalReportViewer();
        rptPalletLabel rptPalletLabel1 = new rptPalletLabel();
        Thread thrdWeigth;
        static SerialPort sprtBalance = new SerialPort();
        volatile bool continueReading = true;

        public frmSingleStockPalletsRegistration()
        {
            InitializeComponent();
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
                            }
                        }
                        else
                        {
                            if (clsGlobal.isNumeric(strReceivedData.Substring(0, strReceivedData.Length - 1)))
                            {
                                this.Invoke((MethodInvoker)delegate { txtGrossWeigth.Text = Math.Round(Convert.ToDouble(strReceivedData.Substring(0, strReceivedData.Length - 1)), 1,MidpointRounding.AwayFromZero).ToString("N2").Trim(); });
                                this.Invoke((MethodInvoker)delegate { txtGrossWeigth.ForeColor = Color.Black; });
                            }
                        }
                    }
                }

                if (continueReading == false)
                {
                    sprtBalance.Close();
                }
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

        private void calculatePalletNetWeigth()
        {
            double palletNetWeigth = 0;

            for (int i = 0; i < dgvCoils.Rows.Count; i++)
                palletNetWeigth += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value);

            lblNetWeigth.Text = palletNetWeigth.ToString();
        }

        private void frmSingleStockPalletsRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
                for (int i = 0; i < lstPalletDimention.Count; i++)
                    cmbDimentions.Items.Add(lstPalletDimention[i]);

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

                lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objPallet.palletNumber.ToString(), 2) + clsGlobal.FillWithZeros(objPalletType.coilNumber.ToString(), 2) + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);

                ActiveControl = txtCoilCode;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                chkManualWeight.Checked = true;
                chkManualWeight.Enabled = false;
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

                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
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
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
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
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);

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
            else if (objPallet.product.code.StartsWith("PA0"))
                myProduct = "Papel";
            else
                myProduct = "Película de polipropileno biorientado";

            return myProduct;
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
            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptPalletLabel.PrintToPrinter(2, false, 0, 0);

            this.Close();

        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (e.KeyCode == Keys.Enter)
            {
                if (dgvCoils.Rows.Count == 0)
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if (objCoil.fkSalesOrder == 0)
                    {
                        if (objCoil.codsec != 0)
                        {
                            if (clsCoil.IsInPallet(objCoil.codsec) == false)
                            {
                                objProduct = new clsProduct(objCoil.fkProduct);
                                lblProduct.Text = objProduct.code;

                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();

                                calculatePalletNetWeigth();

                                txtCoilCode.Text = "";
                                txtCoilCode.Focus();
                            }
                            else
                            {
                                MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada no existe ya que el código ingresado no es correcto", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCoilCode.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no puede agregar una bobina que se encuentra asignada a una orden!!", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoilCode.Focus();
                    }
                }
                else
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                    if (objCoil.fkSalesOrder == 0)
                    {
                        if (objCoil.codsec != 0)
                        {
                            if (objCoil.fkProduct == objProduct.codsec)
                            {
                                bool FlgInPallet = false;

                                for (int i = 0; i < dgvCoils.Rows.Count; i++)
                                {
                                    if (objCoil.code == dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value.ToString())
                                        FlgInPallet = true;
                                }

                                if (clsCoil.IsInPallet(objCoil.codsec) == false && FlgInPallet == false)
                                {
                                    dgvCoils.Rows.Add();
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                    lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();

                                    calculatePalletNetWeigth();

                                    txtCoilCode.Text = "";
                                    txtCoilCode.Focus();
                                }
                                else
                                {
                                    if (FlgInPallet == false)
                                        MessageBox.Show("La bobina seleccionada ya ha sido tomada en cuenta para este pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    else
                                        MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                }
                            }
                            else
                                MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada no existe ya que el código ingresado no es correcto", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            txtCoilCode.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usted no puede agregar una bobina que se encuentra asignada a una orden!!", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        txtCoilCode.Focus();
                    }
                }
            }
        }

        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilAction.Index)
            {
                if (MessageBox.Show("Esta seguro que desea eliminar la bobina del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    dgvCoils.Rows.Remove(dgvCoils.Rows[e.RowIndex]);
                    lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();
                    calculatePalletNetWeigth();
                }

            }
        }

        private void btnAddCoil_Click_1(object sender, EventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (dgvCoils.Rows.Count == 0)
            {
                objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                if (objCoil.codsec != 0)
                {
                    bool flgInList = false;

                    for (int i = 0; i < dgvCoils.Rows.Count; i++)
                    {
                        if (objCoil.codsec == Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value))
                            flgInList = true;
                    }
                    if (flgInList == false)
                    {
                        if (clsCoil.IsInPallet(objCoil.codsec) == false)
                        {
                            objProduct = new clsProduct(objCoil.fkProduct);
                            lblProduct.Text = objProduct.code;

                            dgvCoils.Rows.Add();
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1,MidpointRounding.AwayFromZero));
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();

                            calculatePalletNetWeigth();

                            txtCoilCode.Text = "";
                            txtCoilCode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La bobina seleccionada ya ha sido ingresada.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
            }
            else
            {
                objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                if (objCoil.codsec != 0)
                {
                    if (objCoil.fkProduct == objProduct.codsec)
                    {
                        if (clsCoil.IsInPallet(objCoil.codsec) == false)
                        {
                            dgvCoils.Rows.Add();
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();

                            calculatePalletNetWeigth();

                            txtCoilCode.Text = "";
                            txtCoilCode.Focus();
                        }
                        else
                        {
                            MessageBox.Show("La bobina seleccionada ya pertenece a un pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                    }
                    else
                        MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    int externalCoilCount = 0;
                    string palletLabelType = "";

                    for (int i = 0; i < dgvCoils.Rows.Count; i++)
                    {
                        if ((new clsCoil(Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value))).externalLabelPrint)
                            externalCoilCount++;
                    }

                    if (externalCoilCount == 0)
                        palletLabelType = "local";
                    else if (externalCoilCount == dgvCoils.Rows.Count)
                        palletLabelType = "external";
                    else
                        palletLabelType = "mixed";

                    objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(dgvCoils.Rows.Count, Convert.ToInt32(txtFloors.Text), ((rdoHorizontal.Checked) ? "Horizontal" : "Vertical"));
                    if (objPalletType.codsec == 0)
                    {
                        objPalletType.coilNumber = dgvCoils.Rows.Count;
                        objPalletType.floors = Convert.ToInt32(txtFloors.Text);
                        objPalletType.coilOrientation = ((rdoHorizontal.Checked) ? "Horizontal" : "Vertical");
                        objPalletType.name = "Pallet " + dgvCoils.Rows.Count.ToString() + " bobinas " + ((rdoHorizontal.Checked) ? "horizontal" : "vertical") + " en " + txtFloors.Text + " pisos";

                        objPalletType.save();

                        objPalletType = clsPalletType.getPalletTypeByCoilNumberFloorsOrientation(dgvCoils.Rows.Count, Convert.ToInt32(txtFloors.Text), ((rdoHorizontal.Checked) ? "Horizontal" : "Vertical"));
                    }

                    objPallet = new clsPallet();
                    objPallet.fkPalletDimention = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                    objPallet.fkPalletType = objPalletType.codsec;
                    objPallet.fkProduct = objProduct.codsec;
                    objPallet.fkStatus = 38;
                    objPallet.code = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + clsGlobal.FillWithZeros(objPallet.palletNumber.ToString(), 2) + clsGlobal.FillWithZeros(objPalletType.coilNumber.ToString(), 2) + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 4);
                    objPallet.palletNumber = clsPallet.getCountByStockAndProduct(objProduct.codsec) + 1;
                    objPallet.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                    calculatePalletNetWeigth();
                    objPallet.netWeight = Convert.ToDouble(lblNetWeigth.Text);


                    objPallet.save();


                    objPallet.load(objPallet.codsec);

                    objPallet.grossWeight = Convert.ToDouble(txtGrossWeigth.Text);
                    objPallet.save();

                    for (int i = 0; i < dgvCoils.Rows.Count; i++)
                        objPallet.addCoilToPallet(Convert.ToInt32(dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value));

                    objPallet.load(objPallet.codsec);

                    if (objPallet.close())
                    {
                        MessageBox.Show("El pallet ha sido cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        objPallet.load(objPallet.codsec);
                        btnClose.Enabled = false;
                        printPalletLabel(objPallet.codsec, palletLabelType);
                    }
                    else
                        MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                {
                    MessageBox.Show("Por favor complete todos los campos que se encuentran pintados de ROJO para poder Cerrar el pallet y obtener la etiqueta", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    txtCoilCode.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbDimentions, ref lblDimentionsLabel, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtFloors, ref lblFloors, "notEmpty")) isValid = false;

            return isValid;
        }

        private void txtManualGrossWeigth_TextChanged(object sender, EventArgs e)
        {
            txtGrossWeigth.Text = txtManualGrossWeigth.Text;
        }

        private void chkManualWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManualWeight.Checked == true)
            {
                stopGettingWeigth();
                txtManualGrossWeigth.Visible = true;
                txtManualGrossWeigth.Focus();
            }
            else
            {
                try
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
                catch (Exception)
                {
                    MessageBox.Show("No se ha detectado la conexión con la balanza, se realizará la toma manual del peso bruto del pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    chkManualWeight.Checked = true;
                    chkManualWeight.Enabled = false;
                }
            }
        }
    }
}