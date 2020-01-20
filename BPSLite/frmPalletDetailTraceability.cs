using System;
using System.Drawing;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using BPS.Lite.Reports;
using System.IO.Ports;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmPalletDetailTraceability : Form
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
        BPS.Lite.Reports.rptPalletLabel rptPalletLabel1 = new BPS.Lite.Reports.rptPalletLabel();
        static SerialPort sprtBalance = new SerialPort();
        bool isExternalCoil = false;
        bool flgChangeWeight = false;


        public frmPalletDetailTraceability()
        {
            InitializeComponent();
        }
        public frmPalletDetailTraceability(int palletCodsec)
        {
            InitializeComponent();
            objPallet.load(palletCodsec);

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
                    lblDestination.Text = objSalesOrder.number + "  -  " + objSalesOrder.EntityName;
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
                    lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                }
                else if (objPallet.statusName == "Abierto")
                {
                    lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                }
                else
                {
                    lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                }

                for (int i = 0; i < objPallet.lstCoil.Count; i++)
                {
                    dgvCoils.Rows.Add();
                    dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                    dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                    dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                    dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 2));
                    dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                    dgvCoils.Rows[i].Cells[clmCoilLotNumber.Index].Value = objPallet.lstCoil[i].lotNumber;
                    dgvCoils.Rows[i].Cells[clmCoilExtrusionDate.Index].Value = objPallet.lstCoil[i].extrusionDate.ToString("dd/MM/yyyy");
                    dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.eye;
                }
                lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 2));
                txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 2));
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

                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
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
                rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
                rptPalletLabel.PrintToPrinter(2, false, 0, 0);
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
            rptPalletLabel.PrintOptions.PrinterName = printerSettings.PrinterName;
            rptPalletLabel.PrintToPrinter(2, false, 0, 0);

        }
        private void printCoilLabel(int coilCodsec)
        {
            if (isExternalCoil == false)
            {
                BPS.Lite.Reports.rptCoilLabel rptCoilLabel = new BPS.Lite.Reports.rptCoilLabel();

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
                BPS.Lite.Reports.rptOppCoilLabel rptCoilLabel = new BPS.Lite.Reports.rptOppCoilLabel();

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
            BPS.Lite.Reports.rptCoilLabelObservation rptCoilLabel = new BPS.Lite.Reports.rptCoilLabelObservation();

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
                frmCoilTraceability winCoilEditor = new frmCoilTraceability(Convert.ToInt32(dgvCoils.Rows[e.RowIndex].Cells[clmCoilCodsec.Index].Value));
                winCoilEditor.ShowDialog(this);
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

                flgChangeWeight = false;
            }
            else
            {
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
                objPallet = clsPallet.getCompleteDetailByCode(txtPalletCode.Text);

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

                    dgvCoils.Rows.Clear();

                    if (objPallet.statusName == "Activo")
                    {
                        lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                    }
                    else if (objPallet.statusName == "Abierto")
                    {
                        lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                    }
                    else
                    {
                        lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                    }

                    for (int i = 0; i < objPallet.lstCoil.Count; i++)
                    {
                        dgvCoils.Rows.Add();
                        dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                        dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                        dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                        dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 1));
                        dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                        dgvCoils.Rows[i].Cells[clmCoilLotNumber.Index].Value = objPallet.lstCoil[i].lotNumber;
                        dgvCoils.Rows[i].Cells[clmCoilExtrusionDate.Index].Value = objPallet.lstCoil[i].extrusionDate.ToString("dd/MM/yyyy");
                        dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.eye;
                    }
                    lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                    lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 2));
                    txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 2));
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
                            txtPalletCode.Text = objPallet.code;
                            lblNumber.Text = objPallet.palletNumber.ToString();
                            dgvCoils.Rows.Clear();

                            if (objPallet.statusName == "Activo")
                            {
                                lblStatusColor.BackColor = Color.FromArgb(128, 255, 128);
                            }
                            else if (objPallet.statusName == "Abierto")
                            {
                                lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                            }
                            else
                            {
                                lblStatusColor.BackColor = Color.FromArgb(224, 224, 224);
                            }

                            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                            {
                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                                dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                                dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                                dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 2));
                                dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                                dgvCoils.Rows[i].Cells[clmCoilLotNumber.Index].Value = objPallet.lstCoil[i].lotNumber;
                                dgvCoils.Rows[i].Cells[clmCoilExtrusionDate.Index].Value = objPallet.lstCoil[i].extrusionDate.ToString("dd/MM/yyyy");
                                dgvCoils.Rows[i].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.eye;
                            }
                            lblCoilCount.Text = "Bobinas : " + objPallet.lstCoil.Count.ToString() + " / " + objPalletType.coilNumber.ToString();
                            lblNetWeigth.Text = Convert.ToString(Math.Round(objPallet.netWeight, 2));
                            txtGrossWeigth.Text = Convert.ToString(Math.Round(objPallet.grossWeight, 2));
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
                        MessageBox.Show("La bobina seleccionada no pertenece a ningun pallet.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
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


        private void frmPalletDetail_Load(object sender, EventArgs e)
        {
        }

        private void grpbPalletsRegister_Enter(object sender, EventArgs e)
        {

        }


    }
}