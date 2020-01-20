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
    public partial class frmNewPalletRegistration : Form
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
        BPS.Lite.Reports.rptPalletLabel rptPalletLabel1 = new BPS.Lite.Reports.rptPalletLabel();
        string LoadedAs = "";
        static SerialPort sprtBalance = new SerialPort();
        bool isExternalCoil = false;
        bool enablePrintButon = false;
        bool flgChangeWeight = false;
        bool palletDetailSet = false;
        string califpp = "A";

        public frmNewPalletRegistration()
        {
            InitializeComponent();
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

        private void printPalletLabel(int palletCodsec)
        {
            if (isExternalCoil == false)
            {
                BPS.Lite.Reports.rptPalletLabel rptPalletLabel = new BPS.Lite.Reports.rptPalletLabel();

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
                rptPalletLabel.Close();
                rptPalletLabel.Dispose();
            }
            else
            {
                BPS.Lite.Reports.rptOppPalletLabel rptPalletLabel = new BPS.Lite.Reports.rptOppPalletLabel();

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
                rptPalletLabel.Close();
                rptPalletLabel.Dispose();
            }
        }

        private void printIncompletePalletLabel(int palletCodsec)
        {

            BPS.Lite.Reports.rptIncompletePalletLabel rptPalletLabel = new BPS.Lite.Reports.rptIncompletePalletLabel();

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
            rptPalletLabel.Close();
            rptPalletLabel.Dispose();

        }

        private void resetPalletDetails()
        {
            objProduct = new clsProduct();
            objPallet.product = new clsProduct();
            objSalesOrder = new clsSalesOrder();
            objSalesOrderDetail = new clsSalesOrderDetail();
            palletDetailSet = false;
            lblCode.Text = "";
            lblDestination.Text = "";
            lblProduct.Text = "";
        }


        private void setPalletDetails(clsCoil coil)
        {
            objProduct = new clsProduct(coil.fkProduct);
            objSalesOrder.loadWithoutDetail(coil.fkSalesOrder);//new clsSalesOrder(coil.fkSalesOrder);
            objSalesOrderDetail = clsCoil.getSalesOrderDetailByCoil(coil.codsec);
            clsPlant planta = new clsPlant(coil.coilCellarContainer.fkPlant);
            if (coil.code.Substring(coil.code.Length - 3, 1) == "A" || coil.code.Substring(coil.code.Length - 3, 1) == "B" || coil.code.Substring(coil.code.Length - 3, 1) == "C" || coil.code.Substring(coil.code.Length - 3, 1) == "D")
            {
                califpp = coil.code.Substring(coil.code.Length - 3, 1);
            }
            palletDetailSet = true;
            lblCode.Text = DateTime.Now.ToString("yy") + clsGlobal.ToHexadecimal(Convert.ToInt32(DateTime.Now.ToString("MM"))) + DateTime.Now.ToString("dd") + planta.abr + clsGlobal.FillWithZeros(((new clsSequential().pallet).ToString()), 5)+califpp;
            objPallet.code = lblCode.Text;
            clsSequential.addSequential("pallet");
            objPallet.product = new clsProduct(coil.fkProduct);
            objPallet.fkProduct = coil.fkProduct;
            if(planta.codsec==4)
            {
                objPallet.fkPalletCoilcellar = 4014;
            }
            lblDestination.Text = objSalesOrder.EntityName;
            lblProduct.Text = objProduct.code;
        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (e.KeyCode == Keys.Enter)
            {

                //if (objPallet.statusName == "Abierto")
                //{
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);

                    if (objCoil.fkStatus == 33)
                    {
                        if (!palletDetailSet)
                        {
                            setPalletDetails(objCoil);
                        }
                        else
                        {
                            DataSet DS = new DataSet();

                            DS = clsConnection.getDataSetResult("CALL spCuttingQualityByPallet(" + objPallet.codsec.ToString() + ")");

                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                if (objCoil.fkCuttingQuality != Convert.ToInt32(DS.Tables[0].Rows[0]["fkCQ"]))
                                {
                                    MessageBox.Show("No se puede realizar el ingreso, la bobina seleccionada tiene una calificación de calidad diferente a las ingresadas previamente.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    objCoil.codsec = 0;
                                }
                            }
                        }
                   
                        if (objCoil.codsec != 0)
                        {
                            clsProduct objProductCoil = new clsProduct(objCoil.fkProduct);
                            if (objProductCoil.fkBopp == objProduct.fkBopp && objProduct.width == objProductCoil.width)
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
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                            calculatePalletNetWeigth();
                                            if(objPallet.fkSalesOrderDetail!=0)
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
                    
                //}
                //else
                //    MessageBox.Show("No se puede modificar el pallet. El pallet debe estar abierto.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }


        private void dgvCoils_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmCoilAction.Index)
            {
                if (objPallet.statusName != "Activo")
                {
                    if (MessageBox.Show("Esta seguro que desea eliminar la bobina del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        if (objPallet.removeCoilToPallet(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value)))
                        {
                            dgvCoils.Rows.Remove(dgvCoils.Rows[e.RowIndex]);
                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString();
                            calculatePalletNetWeigth();
                            if (dgvCoils.Rows.Count == 0)
                            {
                                resetPalletDetails();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            isExternalCoil = false;
            string palletLabelType = "";

            objPallet.load(objPallet.codsec);

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
                calculatePalletNetWeigth();
                //objPallet.save();

                //if (dgvCoils.Rows.Count == dgvCoils.Rows.Count)
                //{
                    if (objPallet.close())
                    {
                        clsSalesOrderDetail objsod = new clsSalesOrderDetail(objPallet.fkSalesOrderDetail);
                        if(objPallet.fkSalesOrderDetail!=0)
                            objPallet.validarCompletitud(); 
                        MessageBox.Show("El pallet ha sido cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        objPallet.load(objPallet.codsec);
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                        btnClose.Enabled = false;
                        switch(new clsCoilCellar(objPallet.fkPalletCoilcellar).fkPlant)
                        {
                            case 3:
                                if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                                {
                                    //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                                    //thrdPrint.Start();
                                    clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                                }
                                else
                                {
                                    //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                                    //thrdPrint.Start();
                                    clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType);
                                }
                                break;
                            case 4:
                                if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                                {
                                    //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                                    //thrdPrint.Start();
                                    clsPrintLabels.printPalletLabelSpecialPL(objPallet.codsec, palletLabelType);
                                }
                                else
                                {
                                    //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                                    //thrdPrint.Start();
                                    clsPrintLabels.printPalletLabelPL(objPallet.codsec, palletLabelType);
                                    

                                }
                                break;
                            default:
                                if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                                {
                                    //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                                    //thrdPrint.Start();
                                    clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                                }
                                else
                                {
                                    //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                                    //thrdPrint.Start();
                                    clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType);
                                    

                                }
                                break;
                        }
                        
                    }
                    else
                        MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                //}
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
                switch (new clsCoilCellar(objPallet.fkPalletCoilcellar).fkPlant)
                {
                    case 3:
                        if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                        {
                            //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                            //thrdPrint.Start();
                            clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                        }
                        else
                        {
                            //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                            //thrdPrint.Start();
                            clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType);
                            

                        }
                        break;
                    case 4:
                        if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                        {
                            //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                            //thrdPrint.Start();
                            clsPrintLabels.printPalletLabelSpecialPL(objPallet.codsec, palletLabelType);
                        }
                        else
                        {
                            //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                            //thrdPrint.Start();
                            clsPrintLabels.printPalletLabelPL(objPallet.codsec, palletLabelType);
                            

                        }
                        break;
                    default:
                        if (objPallet.customerName == "BAGLEY ARGENTINA S.A.")
                        {
                            //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                            //thrdPrint.Start();
                            clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType);
                        }
                        else
                        {
                            //Thread thrdPrint = new Thread(delegate() { this.printPalletLabel(objPallet.codsec, palletLabelType); });
                            //thrdPrint.Start();
                            clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType);
                            

                        }
                        break;
                }
                
            }
        }


        private void btnAddCoil_Click(object sender, EventArgs e)
        {
            clsCoil objCoil = new clsCoil();


            if (objPallet.statusName == "Abierto")
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);

                    if (objCoil.fkStatus == 33)
                    {
                        if (!palletDetailSet)
                        {
                            setPalletDetails(objCoil);
                        }
                        else
                        {
                            DataSet DS = new DataSet();

                            DS = clsConnection.getDataSetResult("CALL spCuttingQualityByPallet(" + objPallet.codsec.ToString() + ")");

                            if (DS.Tables[0].Rows.Count > 0)
                            {
                                if (objCoil.fkCuttingQuality != Convert.ToInt32(DS.Tables[0].Rows[0]["fkCQ"]))
                                {
                                    MessageBox.Show("No se puede realizar el ingreso, la bobina seleccionada tiene una calificación de calidad diferente a las ingresadas previamente.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    objCoil.codsec = 0;
                                }
                            }
                        }
                    
                        if (objCoil.codsec != 0)
                        {
                            clsProduct objProductCoil = new clsProduct(objCoil.fkProduct);
                            if (califpp == objCoil.code.Substring(objCoil.code.Length - 3, 1) || califpp == "")
                            {
                                if (objProductCoil.fkBopp == objProduct.fkBopp && objProduct.width == objProductCoil.width)
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
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
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
                            else
                                MessageBox.Show("La bobina seleccionada no tiene la calificación de PP necesaria. Todas las bobinas del pallet deben tener la misma calificación de PP.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            
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
                btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.disk;
                flgChangeWeight = true;
                txtNewGrossWeight.Visible = true;
                txtNewGrossWeight.Text = txtGrossWeigth.Text;
                txtNewGrossWeight.Focus();
                ActiveControl = txtNewGrossWeight;
            }
        }

    
    }
}
