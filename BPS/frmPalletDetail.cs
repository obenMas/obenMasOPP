using System;
using System.Collections.Generic;
using System.Drawing;
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
        bool isExternalCoil = false;
        bool enablePrintButon = false;
        bool flgChangeWeight = false;
        bool flgChangeNetWeight = false;
        bool flgChangeDimention = false;
        bool flgChangeNumber = false;


        public frmPalletDetail()
        {
            InitializeComponent();
        }

        public frmPalletDetail(int palletCodsec)
        {
            InitializeComponent();
            objPallet.load(palletCodsec);

            isStockPallet = false;
            txtPalletCode.Text = objPallet.code;

            if (objPallet.codsec != 0)
            {
                objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);
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
                {
                    lblDestination.Text = objSalesOrder.number + "  -  " + objSalesOrder.EntityName;
                }
                else
                {
                    lblDestination.Text = "Stock";

                }
                lblPalletType.Text = objPalletType.name;
                LblDimentions.Text = objPalletDimentions.ToString();
                lblProduct.Text = objProduct.code;
                lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();
                lblNumber.Text = objPallet.palletNumber.ToString();
                nudPalletNumber.Value = objPallet.palletNumber;

                dgvCoils.Rows.Clear();

                if (objPallet.statusName == "Activo")
                {
                    btnClose.Enabled = true;
                    btnClose.Image = global::BPS.Properties.Resources.printer;
                    btnClose.Text = "Etiqueta";
                    chkReOpen.Visible = true;
                    chkPrintIncomplePallet.Visible = false;
                    lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                    enablePrintButon = true;
                }
                else if (objPallet.statusName == "Abierto")
                {
                    btnClose.Enabled = true;
                    lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                    enablePrintButon = false;
                    btnClose.Image = global::BPS.Properties.Resources._lock;
                    btnClose.Text = "Cerrar";
                    chkPrintIncomplePallet.Visible = true;
                    chkReOpen.Visible = false;
                }
                else
                {
                    btnClose.Enabled = true;
                    lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                    enablePrintButon = false;
                    btnClose.Image = global::BPS.Properties.Resources._lock;
                    btnClose.Text = "Cerrar";
                    chkPrintIncomplePallet.Visible = true;
                    chkReOpen.Visible = true;
                }

                for (int i = 0; i < objPallet.lstCoil.Count; i++)
                {
                    dgvCoils.Rows.Add();
                    dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                    dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                    dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                    dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 1));
                    dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                    dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;
                }
                lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 1));
                txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 1));

                if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú" || objPallet.fkCoilCellar1 == 3 || objPallet.fkCoilCellar1 == 4 || objPallet.fkCoilCellar1 == 8 || objPallet.coilCellarName1 == "Producto Terminado" || objPallet.coilCellarName1 == "Stock Local" || objPallet.coilCellarName1 == "Stock Perú")
                {
                    btnChangeDimention.Enabled = false;
                    btnChangePalletType.Enabled = false;
                    btnChangeNumber.Enabled = false;
                    btnChangeNetWeight.Enabled = false;
                    btnChangeWeight.Enabled = false;
                    txtCoilCode.Enabled = false;
                    btnAddCoil.Enabled = false;
                }
                else
                {
                    btnChangeDimention.Enabled = true;
                    btnChangePalletType.Enabled = true;
                    btnChangeNumber.Enabled = true;
                    btnChangeNetWeight.Enabled = true;
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

                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
            }
            else
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

        }
        private void printCoilLabel(int coilCodsec)
        {
            if (isExternalCoil == false)
            {
                Reports.rptCoilLabel rptCoilLabel = new Reports.rptCoilLabel();

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
            else
            {
                Reports.rptOppCoilLabel rptCoilLabel = new Reports.rptOppCoilLabel();

                Tables tables;

                tables = rptCoilLabel.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
                {
                    TableLogOnInfo tableLogonInfo = table.LogOnInfo;
                    tableLogonInfo.ConnectionInfo.Password = clsGlobal.password;
                    table.ApplyLogOnInfo(tableLogonInfo);
                }

                Sections sections = rptCoilLabel.ReportDefinition.Sections;
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

                ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
                prmCoilCodsec.Value = coilCodsec;

                ParameterField pfldCoilCodsec = new ParameterField();
                pfldCoilCodsec.Name = "coilLabelCodsec";
                pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
                pfldCoilCodsec.HasCurrentValue = true;

                for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
                {
                    switch (rptCoilLabel.ParameterFields[i].Name)
                    {
                        case "coilLabelCodsec":
                            rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                            rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                            rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                            rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                            rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                            break;
                        default:
                            break;
                    }
                }

                PrinterSettings printerSettings = new PrinterSettings();
                rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptCoilLabel.PrintToPrinter(2, false, 0, 0);
            }
        }
        private void printObservationCoilLabel(int coilCodsec)
        {
            Reports.rptCoilLabelObservation rptCoilLabel = new Reports.rptCoilLabelObservation();

            ParameterDiscreteValue prmCoilCodsec = new ParameterDiscreteValue();
            prmCoilCodsec.Value = coilCodsec;

            ParameterField pfldCoilCodsec = new ParameterField();
            pfldCoilCodsec.Name = "coilLabelCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
            {
                switch (rptCoilLabel.ParameterFields[i].Name)
                {
                    case "coilLabelCodsec":
                        rptCoilLabel.ParameterFields[i].CurrentValues.Clear();
                        rptCoilLabel.ParameterFields[i].CurrentValues.Add(prmCoilCodsec);
                        rptCoilLabel.ParameterFields[i].HasCurrentValue = true;
                        rptCoilLabel.ParameterFields[i].DefaultValues.Clear();
                        rptCoilLabel.ParameterFields[i].DefaultValues.Add(prmCoilCodsec);
                        break;
                    default:
                        break;
                }
            }

            PrinterSettings printerSettings = new PrinterSettings();
            rptCoilLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptCoilLabel.PrintToPrinter(1, false, 0, 0);
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
                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                            calculatePalletNetWeigth();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
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
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType); });
                            thrdPrint.Start();
                        }
                        else
                        {
                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType); });
                            thrdPrint.Start();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else if (chkPrintIncomplePallet.Checked == true)
                {
                    MessageBox.Show("Se imprimirá una etiqueta de pallet incompleto para ser completado en el futuro.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    objPallet.load(objPallet.codsec);
                    printIncompletePalletLabel(objPallet.codsec);
                }
                else
                {
                    MessageBox.Show("Debe completar el número de bobinas asignadas para este pallet, estan registradas " + dgvCoils.Rows.Count.ToString() + " y el pallet seleccionado es de " + objPallet.palletType.coilNumber.ToString() + ".", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                if (objPallet.customerName != "CONFITECA")
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType); });
                    thrdPrint.Start();
                }
                else
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType); });
                    thrdPrint.Start();
                }
            }
        }

        private void chkPrintIncomplePallet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrintIncomplePallet.Checked == true)
            {
                btnClose.Image = global::BPS.Properties.Resources.printer;
                btnClose.Text = "Etiqueta";
            }
            else
            {
                btnClose.Image = global::BPS.Properties.Resources._lock;
                btnClose.Text = "Cerrar";
            }
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

                btnChangeWeight.Image = global::BPS.Properties.Resources.arrow_refresh;
                flgChangeWeight = false;
            }
            else
            {
                btnChangeWeight.Image = global::BPS.Properties.Resources.disk;
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

                if (objPallet.fkStatus == 40)
                    chkReOpen.Enabled = false;

                if (objPallet.codsec != 0)
                {
                    objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);
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
                        lblDestination.Text = objSalesOrderDetail.codsec + "  -  " + objSalesOrder.EntityName;
                        //lblDestination.Text = objSalesOrder.number + "  -  " + objSalesOrder.EntityName;
                    else
                        lblDestination.Text = "Stock";

                    lblPalletType.Text = objPalletType.name;
                    LblDimentions.Text = objPalletDimentions.ToString();
                    lblProduct.Text = objProduct.code;
                    lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();
                    lblNumber.Text = objPallet.palletNumber.ToString();

                    dgvCoils.Rows.Clear();

                    if (objPallet.statusName == "Activo")
                    {
                        btnClose.Enabled = true;
                        btnClose.Image = global::BPS.Properties.Resources.printer;
                        btnClose.Text = "Etiqueta";
                        chkReOpen.Visible = true;
                        chkPrintIncomplePallet.Visible = false;
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                        enablePrintButon = true;
                    }
                    else if (objPallet.statusName == "Abierto")
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                        enablePrintButon = false;
                        btnClose.Image = global::BPS.Properties.Resources._lock;
                        btnClose.Text = "Cerrar";
                        chkPrintIncomplePallet.Visible = true;
                        chkReOpen.Visible = false;
                    }
                    else if (objPallet.fkStatus == 40)
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(0, 170, 228);
                        enablePrintButon = true;
                        btnClose.Image = global::BPS.Properties.Resources.printer;
                        btnClose.Text = "Etiqueta";
                        chkPrintIncomplePallet.Visible = true;
                        chkReOpen.Visible = false;
                    }
                    else
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                        enablePrintButon = false;
                        btnClose.Image = global::BPS.Properties.Resources._lock;
                        btnClose.Text = "Cerrar";
                        chkPrintIncomplePallet.Visible = true;
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
                        dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;
                    }
                    lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                    lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 1));
                    txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 1));

                    if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú" || objPallet.fkCoilCellar1 == 3 || objPallet.fkCoilCellar1 == 4 || objPallet.fkCoilCellar1 == 8 || objPallet.coilCellarName1 == "Producto Terminado" || objPallet.coilCellarName1 == "Stock Local" || objPallet.coilCellarName1 == "Stock Perú")
                    {
                        btnChangeDimention.Enabled = false;
                        btnChangePalletType.Enabled = false;
                        btnChangeNumber.Enabled = false;
                        btnChangeNetWeight.Enabled = false;
                        btnChangeWeight.Enabled = false;
                        txtCoilCode.Enabled = false;
                        btnAddCoil.Enabled = false;
                    }
                    else
                    {
                        btnChangeDimention.Enabled = true;
                        btnChangePalletType.Enabled = true;
                        btnChangeNumber.Enabled = true;
                        btnChangeNetWeight.Enabled = true;
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
        }

        private void btnAddCoil_Click(object sender, EventArgs e)
        {
            if (objPallet.statusName != "Activo")
            {
                clsCoil objCoil = new clsCoil();

                objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
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
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;

                                    lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                    calculatePalletNetWeigth();
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
                MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
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
                    txtNewGrossWeight.Visible = false;
                }

                btnChangeWeight.Image = global::BPS.Properties.Resources.arrow_refresh;
                flgChangeWeight = false;
            }
            else
            {
                btnChangeWeight.Image = global::BPS.Properties.Resources.disk;
                flgChangeWeight = true;
                txtNewGrossWeight.Visible = true;
                txtNewGrossWeight.Text = txtGrossWeigth.Text;
                txtNewGrossWeight.Focus();
                ActiveControl = txtNewGrossWeight;
            }
        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            clsCoil objCoil = new clsCoil();

            if (e.KeyCode == Keys.Enter)
            {
                if (objPallet.statusName != "Activo")
                {
                    objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
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

                                    if (dgvCoils.Rows.Count < objPallet.palletType.coilNumber)
                                    {
                                        if (objPallet.addCoilToPallet(objCoil.codsec))
                                        {
                                            dgvCoils.Rows.Add();
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 1, MidpointRounding.AwayFromZero));
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;

                                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objPalletType.coilNumber.ToString();

                                            calculatePalletNetWeigth();
                                        }
                                        else
                                            MessageBox.Show("Se ha producido un error al momento de registrar la bobina en el pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    }
                                    else
                                        MessageBox.Show("Ya han sido ingresadas el número total de bobinas al pallet.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
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
                    MessageBox.Show("No se puede modificar el pallet al estar cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnChangePalletType_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea modificar el tipo de pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                frmChangePalletType winChangePalletType = new frmChangePalletType(objSalesOrderDetail.codsec, objPallet.codsec);
                winChangePalletType.StartPosition = FormStartPosition.CenterScreen;
                winChangePalletType.ShowDialog();

                if (txtPalletCode.Text != "")
                {
                    isStockPallet = false;
                    objPallet = clsPallet.getCompleteDetailByCode(txtPalletCode.Text);

                    objSalesOrder = new clsSalesOrder(objPallet.fkSalesOrder);
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
                        lblDestination.Text = objSalesOrder.number + "  -  " + objSalesOrder.EntityName;
                    else
                        lblDestination.Text = "Stock";

                    lblPalletType.Text = objPalletType.name;
                    LblDimentions.Text = objPalletDimentions.ToString();
                    lblProduct.Text = objProduct.code;
                    lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();

                    dgvCoils.Rows.Clear();

                    if (objPallet.statusName == "Activo")
                    {
                        btnClose.Enabled = true;
                        btnClose.Image = global::BPS.Properties.Resources.printer;
                        btnClose.Text = "Etiqueta";
                        chkPrintIncomplePallet.Visible = false;
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                        enablePrintButon = true;
                    }
                    else if (objPallet.statusName == "Abierto")
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                        enablePrintButon = false;
                        btnClose.Image = global::BPS.Properties.Resources._lock;
                        btnClose.Text = "Cerrar";
                        chkPrintIncomplePallet.Visible = true;
                    }
                    else
                    {
                        btnClose.Enabled = true;
                        lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                        enablePrintButon = false;
                        btnClose.Image = global::BPS.Properties.Resources._lock;
                        btnClose.Text = "Cerrar";
                        chkPrintIncomplePallet.Visible = true;
                    }

                    for (int i = 0; i < objPallet.lstCoil.Count; i++)
                    {
                        dgvCoils.Rows.Add();
                        dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                        dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                        dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                        dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 1, MidpointRounding.AwayFromZero));
                        dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                        dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;
                    }
                    lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                    lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 1));
                    txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 1));

                }
            }
        }

        private void btnPrintCoilsLabels_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < objPallet.lstCoil.Count; i++)
            {
                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].isExternalCoil); });
                thrdPrint.Start();
                thrdPrint.Join();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
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
                if (dgvCoils.Rows.Count == objPallet.palletType.coilNumber)
                {
                    calculatePalletNetWeigth();

                    var inf = clsPallet.getStatusOpenPallet(objPallet);

                    if (inf == "OK")
                    {

                        if (objPallet.close())
                        {
                            MessageBox.Show("El pallet ha sido cerrado.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            objPallet.load(objPallet.codsec);
                            lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                            btnClose.Enabled = false;
                            if (objPallet.customerName != "CONFITECA")
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                            else
                            {
                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType); });
                                thrdPrint.Start();
                                thrdPrint.Join();
                            }
                        }
                        else
                            MessageBox.Show("No se ha podido cerrar el pallet, por favor intente de nuevo.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show(inf, "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
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
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabel(objPallet.codsec, palletLabelType); });
                    thrdPrint.Start();
                    thrdPrint.Join();
                }
                else
                {
                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printPalletLabelSpecial(objPallet.codsec, palletLabelType); });
                    thrdPrint.Start();
                    thrdPrint.Join();
                }
            }
        }

        private void chkReOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea reabrir el pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú" || objPallet.fkCoilCellar1 == 3 || objPallet.fkCoilCellar1 == 4 || objPallet.fkCoilCellar1 == 8 || objPallet.coilCellarName1 == "Producto Terminado" || objPallet.coilCellarName1 == "Stock Local" || objPallet.coilCellarName1 == "Stock Perú")
                {
                    MessageBox.Show("El pallet no se encuentra en CORTE para realizar cambios\n\nPor favor solicite a bodega dicho pallet", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    //chkReOpen.Checked = false;
                }
                else
                {
                    if (objPallet.fkStatus == 40)
                        MessageBox.Show("No puede reabrir un pallet despachado", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    else
                    {
                        if (objPallet.open())
                        {
                            MessageBox.Show("El pallet se ha reabierto.", "Registro de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            btnClose.Enabled = true;
                            lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                            enablePrintButon = false;
                            btnClose.Image = global::BPS.Properties.Resources._lock;
                            btnClose.Text = "Cerrar";
                            chkPrintIncomplePallet.Visible = true;
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
                                lblDestination.Text = objSalesOrderDetail.codsec + "  -  " + objSalesOrder.EntityName;
                                //lblDestination.Text = objSalesOrder.number + "  -  " + objSalesOrder.EntityName;
                            else
                                lblDestination.Text = "Stock";

                            lblPalletType.Text = objPalletType.name;
                            LblDimentions.Text = objPalletDimentions.ToString();
                            lblProduct.Text = objProduct.code;
                            lblCoilCount.Text = "Bobinas : 0 / " + objPalletType.coilNumber.ToString();
                            txtPalletCode.Text = objPallet.code;
                            lblNumber.Text = objPallet.palletNumber.ToString();
                            dgvCoils.Rows.Clear();

                            if (objPallet.statusName == "Activo")
                            {
                                btnClose.Enabled = true;
                                btnClose.Image = global::BPS.Properties.Resources.printer;
                                btnClose.Text = "Etiqueta";
                                chkReOpen.Visible = true;
                                chkPrintIncomplePallet.Visible = false;
                                lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                                enablePrintButon = true;
                            }
                            else if (objPallet.statusName == "Abierto")
                            {
                                btnClose.Enabled = true;
                                lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                                enablePrintButon = false;
                                btnClose.Image = global::BPS.Properties.Resources._lock;
                                btnClose.Text = "Cerrar";
                                chkPrintIncomplePallet.Visible = true;
                                chkReOpen.Visible = false;
                            }
                            else
                            {
                                btnClose.Enabled = true;
                                lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                                enablePrintButon = false;
                                btnClose.Image = global::BPS.Properties.Resources._lock;
                                btnClose.Text = "Cerrar";
                                chkPrintIncomplePallet.Visible = true;
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
                                dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Properties.Resources.cross;
                            }
                            lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                            lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 1));
                            txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 1));

                            if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú" || objPallet.fkCoilCellar1 == 3 || objPallet.fkCoilCellar1 == 4 || objPallet.fkCoilCellar1 == 8 || objPallet.coilCellarName1 == "Producto Terminado" || objPallet.coilCellarName1 == "Stock Local" || objPallet.coilCellarName1 == "Stock Perú")
                            {
                                btnChangeDimention.Enabled = false;
                                btnChangePalletType.Enabled = false;
                                btnChangeNumber.Enabled = false;
                                btnChangeNetWeight.Enabled = false;
                                btnChangeWeight.Enabled = false;
                                txtCoilCode.Enabled = false;
                                btnAddCoil.Enabled = false;
                            }
                            else
                            {
                                btnChangeDimention.Enabled = true;
                                btnChangePalletType.Enabled = true;
                                btnChangeNumber.Enabled = true;
                                btnChangeNetWeight.Enabled = true;
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

        private void btnUpdateLotNumber_Click(object sender, EventArgs e)
        {
            if (flgChangeNetWeight == true)
            {
                if (MessageBox.Show("Esta seguro que desea recalcular el peso neto del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    double newNetWeight = 0;
                    for (int i = 0; i < dgvCoils.Rows.Count; i++)
                        newNetWeight += Convert.ToDouble(dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value);

                    lblNetWeigth.Text = Math.Round(newNetWeight, 1).ToString();

                    objPallet.netWeight = newNetWeight;
                    objPallet.save();
                }

                btnChangeNetWeight.Image = global::BPS.Properties.Resources.arrow_circle_double;
                flgChangeNetWeight = false;
            }
            else
            {
                btnChangeNetWeight.Image = global::BPS.Properties.Resources.disk;
                flgChangeNetWeight = true;
            }
        }

        private void frmPalletDetail_Load(object sender, EventArgs e)
        {
            List<clsPalletDimentions> lstPalletDimention = clsPalletDimentions.getList();
            for (int i = 0; i < lstPalletDimention.Count; i++)
                cmbDimentions.Items.Add(lstPalletDimention[i]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flgChangeDimention == true)
            {
                if (MessageBox.Show("Esta seguro que desea cambiar las dimensiones del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objPallet.fkPalletDimention = ((clsPalletDimentions)cmbDimentions.SelectedItem).codsec;
                    objPallet.save();
                    LblDimentions.Text = cmbDimentions.Text;
                }

                btnChangeDimention.Image = global::BPS.Properties.Resources.arrow_circle_double;
                flgChangeDimention = false;
                cmbDimentions.Visible = false;
            }
            else
            {
                btnChangeDimention.Image = global::BPS.Properties.Resources.disk;
                cmbDimentions.Visible = true;
                flgChangeDimention = true;
            }
        }

        private void btnChangeNumber_Click(object sender, EventArgs e)
        {
            if (flgChangeNumber == true)
            {
                if (MessageBox.Show("Esta seguro que desea cambiar el número del pallet?", "Registro de pallets", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objPallet.palletNumber = Convert.ToInt32(nudPalletNumber.Value);
                    objPallet.save();
                    lblNumber.Text = Convert.ToInt32(nudPalletNumber.Value).ToString();
                }

                btnChangeDimention.Image = global::BPS.Properties.Resources.arrow_circle_double;
                nudPalletNumber.Visible = false;
                flgChangeNumber = false;
            }
            else
            {
                btnChangeNumber.Image = global::BPS.Properties.Resources.disk;
                nudPalletNumber.Visible = true;
                nudPalletNumber.Focus();
                flgChangeNumber = true;
            }
        }
    }
}