using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Drawing.Printing;
using System.Threading;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmExecuteChangeSalesOrder : Form
    {
        private clsChangeSalesOrder objChangeSalesOrder = new clsChangeSalesOrder();


        public frmExecuteChangeSalesOrder()
        {
            InitializeComponent();
        }
        public void fillSummary()
        {
            dgvChangeOrderSummary.Rows.Clear();
            List<clsChangeSalesOrder> lstChangeSalesOrder = clsChangeSalesOrder.getList();

            for (int i = 0; i < lstChangeSalesOrder.Count; i++)
            {
                dgvChangeOrderSummary.Rows.Add();
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderCodsec.Index].Value = lstChangeSalesOrder[i].codsec;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderProduct.Index].Value = lstChangeSalesOrder[i].objProduct.code.Replace("-", "");
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderFrom.Index].Value = (lstChangeSalesOrder[i].originalSalesOrder.codsec > 0) ? lstChangeSalesOrder[i].originalSalesOrder.EntityName + " [" + lstChangeSalesOrder[i].originalSalesOrder.number + "]" : "STOCK";
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderCoils.Index].Value = lstChangeSalesOrder[i].coilsToChange;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderTo.Index].Value = (lstChangeSalesOrder[i].destinationSalesOrder.codsec > 0) ? lstChangeSalesOrder[i].destinationSalesOrder.EntityName + " [" + lstChangeSalesOrder[i].destinationSalesOrder.number + "]" : "STOCK";
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderDate.Index].Value = lstChangeSalesOrder[i].createdDate.ToString("dd/MM/yyyy");
                dgvChangeOrderSummary.Rows[i].Cells[clmnotes.Index].Value = (lstChangeSalesOrder[i].notes == string.Empty) ? "S/N" : lstChangeSalesOrder[i].notes;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderStatus.Index].Value = (lstChangeSalesOrder[i].statusName == "Activa") ? global::BPS.Lite.Properties.Resources.calendar_2 : global::BPS.Lite.Properties.Resources.play_sharp;
                dgvChangeOrderSummary.Rows[i].Cells[clmChangeOrderClose.Index].Value = global::BPS.Lite.Properties.Resources.lock1;
            }
        }
        private void printCoilLabel(int coilCodsec, bool isExternalCoil)
        {
            if (isExternalCoil == false)
            {
                Reports.rptCoilLabel rptCoilLabel = new Reports.rptCoilLabel();

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
            pfldCoilCodsec.Name = "mainCoilCodsec";
            pfldCoilCodsec.CurrentValues.Add(prmCoilCodsec);
            pfldCoilCodsec.HasCurrentValue = true;

            for (int i = 0; i < rptCoilLabel.ParameterFields.Count; i++)
            {
                switch (rptCoilLabel.ParameterFields[i].Name)
                {
                    case "coilCodsec":
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

        private void printPalletLabel(int palletCodsec, bool isExternalCoil)
        {
            if (isExternalCoil == false)
            {
                Reports.rptPalletLabel rptPalletLabel = new Reports.rptPalletLabel();

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
                Reports.rptOppPalletLabel rptPalletLabel = new Reports.rptOppPalletLabel();

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

            Reports.rptIncompletePalletLabel rptPalletLabel = new Reports.rptIncompletePalletLabel();

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

        private void frmExecuteChangeSalesOrder_Load(object sender, EventArgs e)
        {
            fillSummary();
        }

        private void dgvChangeOrderSummary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmChangeOrderStatus.Index)
            {
                tbcChangeSalesOrder.SelectedIndex = 1;

                objChangeSalesOrder = new clsChangeSalesOrder(Convert.ToInt32(dgvChangeOrderSummary.Rows[e.RowIndex].Cells[clmChangeOrderCodsec.Index].Value));

                if (objChangeSalesOrder.originalSalesOrder.codsec > 0)
                {
                    lblCustomerName.Text = objChangeSalesOrder.originalSalesOrder.EntityName;
                    lblNumber.Text = objChangeSalesOrder.originalSalesOrder.number;
                    lblDate.Text = objChangeSalesOrder.originalSalesOrder.createdDate.ToString("dd/MM/yyyy HH:mm");
                }
                else
                {
                    lblCustomerName.Text = "STOCK";
                    lblNumber.Text = "-----";
                    lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                }

                lblDestinationCustomerName.Text = objChangeSalesOrder.destinationSalesOrder.EntityName;
                lblDestinationNumber.Text = objChangeSalesOrder.destinationSalesOrder.number;
                lblDestinationDate.Text = objChangeSalesOrder.destinationSalesOrder.createdDate.ToString("dd/MM/yyyy HH:mm");

                List<clsCoil> lstCoils = clsCoil.getCoilListByChangeOrder(objChangeSalesOrder.codsec);

                dgvCoils.Rows.Clear();

                for (int i = 0; i < lstCoils.Count; i++)
                {
                    dgvCoils.Rows.Add();
                    dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = lstCoils[i].codsec;
                    dgvCoils.Rows[i].Cells[clmCoilCode.Index].Value = lstCoils[i].code;
                    dgvCoils.Rows[i].Cells[clmCoilLength.Index].Value = lstCoils[i].length;
                    dgvCoils.Rows[i].Cells[clmCoilWidth.Index].Value = lstCoils[i].width;
                    dgvCoils.Rows[i].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(lstCoils[i].netWeight, 2));
                    dgvCoils.Rows[i].Cells[clmCoilCodsec.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }


            }
            if (e.ColumnIndex == clmChangeOrderClose.Index)
            {
                if (e.ColumnIndex == clmChangeOrderClose.Index)
                {
                    if (MessageBox.Show("Desea cerrar esta orden de cambio?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                    {
                        clsChangeSalesOrder.close(Convert.ToInt32(dgvChangeOrderSummary.Rows[e.RowIndex].Cells[clmChangeOrderCodsec.Index].Value));
                        MessageBox.Show("Se ha realizado el cierre de la orden de cambio.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        fillSummary();
                    }
                }
            }
        }

        private void btnAddCoil_Click(object sender, EventArgs e)
        {
            clsCoil objCoil = new clsCoil();
            objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
            if (objCoil.codsec != 0)
            {
                if (objCoil.coilCellarContainer.codsec == 3 || objCoil.coilCellarContainer.codsec == 4 || objCoil.coilCellarContainer.codsec == 8 || objCoil.coilCellarContainer.name == "Stock Local" || objCoil.coilCellarContainer.name == "Stock Perú")
                    MessageBox.Show("No puede modificar una bobina que se encuentre en bodega de " + objCoil.coilCellarContainer.name + " por favor solicite a bodega que extraigan el pallet a BODEGA DE PROCESO para que pueda realizar el cambio de orden", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                else
                {
                    if (objCoil.fkBopp == objChangeSalesOrder.objProduct.fkBopp && objCoil.fkCast == objChangeSalesOrder.objProduct.fkCast && objCoil.width == objChangeSalesOrder.objProduct.width)
                    {
                        bool isEnabledToBeAdded = false;
                        if ((clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec == objChangeSalesOrder.originalSalesOrderDetail.codsec)
                            isEnabledToBeAdded = true;
                        else if ((clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec != objChangeSalesOrder.originalSalesOrderDetail.codsec)
                            isEnabledToBeAdded = false;

                        if (isEnabledToBeAdded)
                        {
                            if (clsCoil.IsInPallet(objCoil.codsec))
                            {
                                if (MessageBox.Show("Esta bobina esta registrada dentro de un pallet, desea realizar el cambio de orden de solamente esta bobina?\n\nEl pallet contenedor de esta bobina quedará incompleto.", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));
                                    if (objOriginPallet.fkStatus == 40)
                                        MessageBox.Show("No puede reabrir un pallet despachado", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    else
                                    {
                                        if (objOriginPallet.open())
                                        {
                                            objOriginPallet.removeCoilToPallet(objCoil.codsec);
                                            clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                            objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                            objChangeSalesOrderDetail.fkCoil = objCoil.codsec;
                                            objChangeSalesOrderDetail.changed = true;

                                            objChangeSalesOrderDetail.save();

                                            clsCoil.assignToSalesOrder(objCoil.codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                            dgvCoils.Rows.Add();
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                            MessageBox.Show("Se ha realizado el cambio de orden para la bobina seleccionada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                            if (MessageBox.Show("Desea imprimir la nueva etiqueta de la bobina?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                            {
                                                if (objCoil.customerName != "CONFITECA")
                                                {
                                                    if (objCoil.ProductCode.StartsWith("M"))
                                                    {
                                                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objCoil.codsec, objCoil.externalLabelPrint); });
                                                        thrdPrint.Start();
                                                        thrdPrint.Join();
                                                    }
                                                    else
                                                    {
                                                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                                                        thrdPrint.Start();
                                                        thrdPrint.Join();
                                                    }
                                                }
                                                else
                                                {
                                                    Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
                                                    thrdPrint.Start();
                                                    thrdPrint.Join();
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (MessageBox.Show("Desea realizar el cambio de orden de todas las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                    {
                                        clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                        for (int i = 0; i < objOriginPallet.lstCoil.Count; i++)
                                        {
                                            clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                            objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                            objChangeSalesOrderDetail.fkCoil = objOriginPallet.lstCoil[i].codsec;
                                            objChangeSalesOrderDetail.changed = true;

                                            objChangeSalesOrderDetail.save();

                                            clsCoil.assignToSalesOrder(objOriginPallet.lstCoil[i].codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                            dgvCoils.Rows.Add();
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objOriginPallet.lstCoil[i].codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objOriginPallet.lstCoil[i].code;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objOriginPallet.lstCoil[i].length;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objOriginPallet.lstCoil[i].netWeight, 2));
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objOriginPallet.lstCoil[i].width;
                                            dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                            lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                        }
                                        clsPallet.assignPalletToSalesOrderDetail(objOriginPallet.codsec, objChangeSalesOrder.fkDestinationSalesOrderDetail);

                                        MessageBox.Show("Se ha realizado el cambio del pallet para el pallet seleccionad0.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                        if (MessageBox.Show("Desea imprimir la nueva etiqueta del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                        {
                                            bool isExternalPallet = false;
                                            int numOfExternalCoils = 0;

                                            for (int i = 0; i < objOriginPallet.lstCoil.Count; i++)
                                            {
                                                if (objOriginPallet.lstCoil[i].isExternalCoil)
                                                    numOfExternalCoils++;
                                            }

                                            if (numOfExternalCoils > objOriginPallet.lstCoil.Count / 2)
                                                isExternalPallet = true;
                                            else
                                                isExternalPallet = false;

                                            Thread thrdPrint = new Thread(delegate() { printPalletLabel(objOriginPallet.codsec, isExternalPallet); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();

                                            if (MessageBox.Show("Desea imprimir las nuevas etiquetas de las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                            {
                                                for (int i = 0; i < objOriginPallet.lstCoil.Count; i++)
                                                {
                                                    if (objOriginPallet.lstCoil[i].customerName != "CONFITECA")
                                                    {
                                                        if (objOriginPallet.lstCoil[i].ProductCode.StartsWith("M"))
                                                        {
                                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objOriginPallet.lstCoil[i].codsec, objOriginPallet.lstCoil[i].externalLabelPrint); });
                                                            thrdPrint.Start();
                                                            thrdPrint.Join();
                                                        }
                                                        else
                                                        {
                                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objOriginPallet.lstCoil[i].codsec, objOriginPallet.lstCoil[i].externalLabelPrint); });
                                                            thrdPrint.Start();
                                                            thrdPrint.Join();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objOriginPallet.lstCoil[i].codsec, objOriginPallet.lstCoil[i].externalLabelPrint); });
                                                        thrdPrint.Start();
                                                        thrdPrint.Join();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                objChangeSalesOrderDetail.fkCoil = objCoil.codsec;
                                objChangeSalesOrderDetail.changed = true;

                                objChangeSalesOrderDetail.save();

                                clsCoil.assignToSalesOrder(objCoil.codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                MessageBox.Show("Se ha realizado el cambio de orden para la bobina seleccionada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                if (MessageBox.Show("Desea imprimir la nueva etiqueta de la bobina?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    if (objCoil.customerName != "CONFITECA")
                                    {
                                        if (objCoil.ProductCode.StartsWith("M"))
                                        {
                                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objCoil.codsec, objCoil.externalLabelPrint); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                        }
                                        else
                                        {
                                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                        }
                                    }
                                    else
                                    {
                                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
                                        thrdPrint.Start();
                                        thrdPrint.Join();
                                    }
                                }
                            }

                        }
                        else
                            MessageBox.Show("La bobina seleccionada no esta asociada a la orden de venta de origen.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            else
            {
                clsPallet objPallet = new clsPallet();
                objPallet = clsPallet.getDetailByCode(txtCoilCode.Text);

                if (objPallet.codsec > 0)
                {
                    if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú")
                        MessageBox.Show("No puede modificar un pallet que se encuentre en bodega de " + objPallet.coilCellarName + " por favor solicite a bodega que extraigan el pallet a BODEGA DE PROCESO para que pueda realizar el cambio de orden", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    else
                    {
                        if (MessageBox.Show("El código ingresado corresponde a un pallet, desea realizar el cambio de orden de todas las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                            {
                                clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                objChangeSalesOrderDetail.fkCoil = objPallet.lstCoil[i].codsec;
                                objChangeSalesOrderDetail.changed = true;

                                objChangeSalesOrderDetail.save();

                                clsCoil.assignToSalesOrder(objPallet.lstCoil[i].codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                dgvCoils.Rows.Add();
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 2));
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                clsPallet.assignPalletToSalesOrderDetail(objPallet.codsec, objChangeSalesOrder.fkDestinationSalesOrderDetail);
                            }


                            MessageBox.Show("Se ha realizado el cambio del pallet para la bobina seleccionada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                            if (MessageBox.Show("Desea imprimir la nueva etiqueta del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                bool isExternalPallet = false;
                                int numOfExternalCoils = 0;

                                for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                {
                                    if (objPallet.lstCoil[i].isExternalCoil)
                                        numOfExternalCoils++;
                                }

                                if (numOfExternalCoils > Math.Ceiling(Convert.ToDouble(objPallet.lstCoil.Count) / 2))
                                    isExternalPallet = true;
                                else
                                    isExternalPallet = false;

                                Thread thrdPrint = new Thread(delegate() { printPalletLabel(objPallet.codsec, isExternalPallet); });
                                thrdPrint.Start();
                                thrdPrint.Join();

                                if (MessageBox.Show("Desea imprimir las nuevas etiquetas de las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                    {
                                        if (objPallet.lstCoil[i].customerName != "CONFITECA")
                                        {
                                            if (objPallet.lstCoil[i].ProductCode.StartsWith("M"))
                                            {
                                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].externalLabelPrint); });
                                                thrdPrint.Start();
                                                thrdPrint.Join();
                                            }
                                            else
                                            {
                                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].externalLabelPrint); });
                                                thrdPrint.Start();
                                                thrdPrint.Join();
                                            }
                                        }
                                        else
                                        {
                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].externalLabelPrint); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("El código ingresado no corresponde a ninguna bobina o pallet registrados en el sistema.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            txtCoilCode.Text = "";
            txtCoilCode.Focus();
        }

        private void txtCoilCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clsCoil objCoil = new clsCoil();

                objCoil = clsCoil.getDetailByCode(txtCoilCode.Text);
                if (objCoil.codsec != 0)
                {
                    if (objCoil.coilCellarContainer.codsec == 3 || objCoil.coilCellarContainer.codsec == 4 || objCoil.coilCellarContainer.codsec == 8 || objCoil.coilCellarContainer.name == "Stock Local" || objCoil.coilCellarContainer.name == "Stock Perú")
                        MessageBox.Show("No puede modificar una bobina que se encuentre en bodega de " + objCoil.coilCellarContainer.name + " por favor solicite a bodega que extraigan el pallet a BODEGA DE PROCESO para que pueda realizar el cambio de orden", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    else
                    {
                        if (objCoil.fkBopp == objChangeSalesOrder.objProduct.fkBopp && objCoil.fkCast == objChangeSalesOrder.objProduct.fkCast && objCoil.width == objChangeSalesOrder.objProduct.width)
                        {
                            bool isEnabledToBeAdded = false;
                            if ((clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec == objChangeSalesOrder.originalSalesOrderDetail.codsec)
                                isEnabledToBeAdded = true;
                            else if ((clsCoil.getSalesOrderDetailByCoil(objCoil.codsec)).codsec != objChangeSalesOrder.originalSalesOrderDetail.codsec)
                                isEnabledToBeAdded = false;

                            if (isEnabledToBeAdded)
                            {
                                if (clsCoil.IsInPallet(objCoil.codsec))
                                {
                                    if (MessageBox.Show("Esta bobina esta registrada dentro de un pallet, desea realizar el cambio de orden de solamente esta bobina?\n\nEl pallet contenedor de esta bobina se eliminará y las bobinas quedarán sueltas.\n\n Para retornar las bobinas sueltas debe volver a empaletar las mismas\n\nYa no se podrá cambiar todo el pallet se deberá ingresar bobina por bobina", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                    {
                                        clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));
                                        if (objOriginPallet.fkStatus == 40)
                                            MessageBox.Show("No puede reabrir un pallet despachado", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                        else
                                        {
                                            if (objOriginPallet.open())
                                            {
                                                objOriginPallet.removeCoilToPallet(objCoil.codsec);
                                                clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                                objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                                objChangeSalesOrderDetail.fkCoil = objCoil.codsec;
                                                objChangeSalesOrderDetail.changed = true;

                                                objChangeSalesOrderDetail.save();

                                                clsCoil.assignToSalesOrder(objCoil.codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                                dgvCoils.Rows.Add();
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                                lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                                //Eliminar todas la bobinas del pallet original
                                                if (objOriginPallet.lstCoil.Count > 1)
                                                {
                                                    if (objOriginPallet.removeAllCoilToPallet())
                                                        objOriginPallet.deletePalletforChangeOrder();
                                                    else
                                                    {
                                                        objOriginPallet.removeAllCoilToPallet();
                                                        objOriginPallet.deletePalletforChangeOrder();
                                                    }
                                                }

                                                //Eliminar pallet contenedor para no tener pallet incompletos

                                                MessageBox.Show("Se ha realizado el cambio de orden para la bobina seleccionada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                                if (MessageBox.Show("Desea imprimir la nueva etiqueta de la bobina?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                                {
                                                    if (objCoil.customerName != "CONFITECA")
                                                    {
                                                        if (objCoil.ProductCode.StartsWith("M"))
                                                        {
                                                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objCoil.codsec, objCoil.externalLabelPrint); });
                                                            thrdPrint.Start();
                                                            thrdPrint.Join();
                                                        }
                                                        else
                                                        {
                                                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                                                            thrdPrint.Start();
                                                            thrdPrint.Join();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
                                                        thrdPrint.Start();
                                                        thrdPrint.Join();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (MessageBox.Show("Desea realizar el cambio de orden de todas las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                        {
                                            clsPallet objOriginPallet = new clsPallet(clsCoil.getContainerPalletCodsecByCoil(objCoil.codsec));

                                            for (int i = 0; i < objOriginPallet.lstCoil.Count; i++)
                                            {
                                                clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                                objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                                objChangeSalesOrderDetail.fkCoil = objOriginPallet.lstCoil[i].codsec;
                                                objChangeSalesOrderDetail.changed = true;

                                                objChangeSalesOrderDetail.save();

                                                clsCoil.assignToSalesOrder(objOriginPallet.lstCoil[i].codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                                dgvCoils.Rows.Add();
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objOriginPallet.lstCoil[i].codsec;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objOriginPallet.lstCoil[i].code;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objOriginPallet.lstCoil[i].length;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objOriginPallet.lstCoil[i].netWeight, 2));
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objOriginPallet.lstCoil[i].width;
                                                dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                                lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                            }
                                            clsPallet.assignPalletToSalesOrderDetail(objOriginPallet.codsec, objChangeSalesOrder.fkDestinationSalesOrderDetail);

                                            MessageBox.Show("Se ha realizado el cambio del pallet para el pallet seleccionad0.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                            if (MessageBox.Show("Desea imprimir la nueva etiqueta del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                            {
                                                bool isExternalPallet = false;
                                                int numOfExternalCoils = 0;

                                                for (int i = 0; i < objOriginPallet.lstCoil.Count; i++)
                                                {
                                                    if (objOriginPallet.lstCoil[i].isExternalCoil)
                                                        numOfExternalCoils++;
                                                }

                                                if (numOfExternalCoils > objOriginPallet.lstCoil.Count / 2)
                                                    isExternalPallet = true;
                                                else
                                                    isExternalPallet = false;

                                                Thread thrdPrint = new Thread(delegate() { printPalletLabel(objOriginPallet.codsec, isExternalPallet); });
                                                thrdPrint.Start();
                                                thrdPrint.Join();

                                                if (MessageBox.Show("Desea imprimir las nuevas etiquetas de las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                                {
                                                    for (int i = 0; i < objOriginPallet.lstCoil.Count; i++)
                                                    {
                                                        if (objOriginPallet.lstCoil[i].customerName != "CONFITECA")
                                                        {
                                                            if (objOriginPallet.lstCoil[i].ProductCode.StartsWith("M"))
                                                            {
                                                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objOriginPallet.lstCoil[i].codsec, objOriginPallet.lstCoil[i].externalLabelPrint); });
                                                                thrdPrint.Start();
                                                                thrdPrint.Join();
                                                            }
                                                            else
                                                            {
                                                                thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objOriginPallet.lstCoil[i].codsec, objOriginPallet.lstCoil[i].externalLabelPrint); });
                                                                thrdPrint.Start();
                                                                thrdPrint.Join();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objOriginPallet.lstCoil[i].codsec, objOriginPallet.lstCoil[i].externalLabelPrint); });
                                                            thrdPrint.Start();
                                                            thrdPrint.Join();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                    objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                    objChangeSalesOrderDetail.fkCoil = objCoil.codsec;
                                    objChangeSalesOrderDetail.changed = true;

                                    objChangeSalesOrderDetail.save();

                                    clsCoil.assignToSalesOrder(objCoil.codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                    dgvCoils.Rows.Add();
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objCoil.codsec;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objCoil.code;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objCoil.length;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objCoil.netWeight, 2));
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objCoil.width;
                                    dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                    lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                    MessageBox.Show("Se ha realizado el cambio de orden para la bobina seleccionada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    if (MessageBox.Show("Desea imprimir la nueva etiqueta de la bobina?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                    {
                                        if (objCoil.customerName != "CONFITECA")
                                        {
                                            if (objCoil.ProductCode.StartsWith("M"))
                                            {
                                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objCoil.codsec, objCoil.externalLabelPrint); });
                                                thrdPrint.Start();
                                                thrdPrint.Join();
                                            }
                                            else
                                            {
                                                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objCoil.codsec, objCoil.externalLabelPrint); });
                                                thrdPrint.Start();
                                                thrdPrint.Join();
                                            }
                                        }
                                        else
                                        {
                                            Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objCoil.codsec, objCoil.externalLabelPrint); });
                                            thrdPrint.Start();
                                            thrdPrint.Join();
                                        }
                                    }
                                }

                            }
                            else
                                MessageBox.Show("La bobina seleccionada no esta asociada a la orden de venta de origen.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }
                        else
                            MessageBox.Show("La bobina seleccionada no coincide con el producto a ser ingresado en el pallet.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                }
                else
                {
                    clsPallet objPallet = new clsPallet();
                    objPallet = clsPallet.getDetailByCode(txtCoilCode.Text);
                    clsProduct objProduct = new clsProduct();
                    objProduct.load(objPallet.fkProduct);

                    if (objPallet.codsec > 0)
                    {
                        if (objPallet.fkCoilCellar == 3 || objPallet.fkCoilCellar == 4 || objPallet.fkCoilCellar == 8 || objPallet.coilCellarName == "Producto Terminado" || objPallet.coilCellarName == "Stock Local" || objPallet.coilCellarName == "Stock Perú")
                            MessageBox.Show("No puede modificar un pallet que se encuentre en bodega de " + objPallet.coilCellarName + " por favor solicite a bodega que extraigan el pallet a BODEGA DE PROCESO para que pueda realizar el cambio de orden", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        else
                        {
                            if (objProduct.codsec == objChangeSalesOrder.objProduct.codsec && objProduct.width == objChangeSalesOrder.objProduct.width)
                            {
                                if (MessageBox.Show("El código ingresado corresponde a un pallet, desea realizar el cambio de orden de todas las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                {
                                    for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                    {
                                        clsChangeSalesOrderDetail objChangeSalesOrderDetail = new clsChangeSalesOrderDetail();
                                        objChangeSalesOrderDetail.fkChangeSalesOrder = objChangeSalesOrder.codsec;
                                        objChangeSalesOrderDetail.fkCoil = objPallet.lstCoil[i].codsec;
                                        objChangeSalesOrderDetail.changed = true;

                                        objChangeSalesOrderDetail.save();

                                        clsCoil.assignToSalesOrder(objPallet.lstCoil[i].codsec, objChangeSalesOrder.destinationSalesOrderDetail.codsec);

                                        dgvCoils.Rows.Add();
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCodsec.Index].Value = objPallet.lstCoil[i].codsec;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmChangeOrderCodsec.Index].Value = objChangeSalesOrderDetail.codsec;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilCode.Index].Value = objPallet.lstCoil[i].code;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilLength.Index].Value = objPallet.lstCoil[i].length;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWeigth.Index].Value = Convert.ToString(Math.Round(objPallet.lstCoil[i].netWeight, 2));
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilWidth.Index].Value = objPallet.lstCoil[i].width;
                                        dgvCoils.Rows[dgvCoils.Rows.Count - 1].Cells[clmCoilAction.Index].Value = global::BPS.Lite.Properties.Resources.cross;

                                        lblCoilCount.Text = "Bobinas : " + dgvCoils.Rows.Count.ToString() + " / " + objChangeSalesOrder.coilsToChange.ToString();

                                        clsPallet.assignPalletToSalesOrderDetail(objPallet.codsec, objChangeSalesOrder.fkDestinationSalesOrderDetail);

                                    }
                                    clsPallet.changeCreatedDateByChangeOrder(objPallet.codsec);


                                    MessageBox.Show("Se ha realizado el cambio del pallet para la bobina seleccionada.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                                    if (MessageBox.Show("Desea imprimir la nueva etiqueta del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                    {
                                        bool isExternalPallet = false;
                                        int numOfExternalCoils = 0;

                                        for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                        {
                                            if (objPallet.lstCoil[i].isExternalCoil)
                                                numOfExternalCoils++;
                                        }

                                        if (numOfExternalCoils > Math.Ceiling(Convert.ToDouble(objPallet.lstCoil.Count) / 2))
                                            isExternalPallet = true;
                                        else
                                            isExternalPallet = false;

                                        Thread thrdPrint = new Thread(delegate() { printPalletLabel(objPallet.codsec, isExternalPallet); });
                                        thrdPrint.Start();
                                        thrdPrint.Join();

                                        if (MessageBox.Show("Desea imprimir las nuevas etiquetas de las bobinas del pallet?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                                        {
                                            for (int i = 0; i < objPallet.lstCoil.Count; i++)
                                            {
                                                if (objPallet.lstCoil[i].customerName != "CONFITECA")
                                                {
                                                    if (objPallet.lstCoil[i].ProductCode.StartsWith("M"))
                                                    {
                                                        thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelM(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].externalLabelPrint); });
                                                        thrdPrint.Start();
                                                        thrdPrint.Join();
                                                    }
                                                    else
                                                    {
                                                        thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabel(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].externalLabelPrint); });
                                                        thrdPrint.Start();
                                                        thrdPrint.Join();
                                                    }
                                                }
                                                else
                                                {
                                                    thrdPrint = new Thread(delegate() { clsPrintLabels.printCoilLabelSpecial(objPallet.lstCoil[i].codsec, objPallet.lstCoil[i].externalLabelPrint); });
                                                    thrdPrint.Start();
                                                    thrdPrint.Join();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("El pallet que usted selecciono es un " + objProduct.code + " y el cambio de orden pide un material de " + objChangeSalesOrder.objProduct.code + " por favor ingrese un pallet correcto", "Cambios de Orden", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                txtCoilCode.Text = "";
                                txtCoilCode.Focus();
                            }
                        }
                    }
                    else
                        MessageBox.Show("El código ingresado no corresponde a ninguna bobina o pallet registrados en el sistema.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                txtCoilCode.Text = "";
                txtCoilCode.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar esta orden de cambio?", "Cambio de orden de venta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                clsChangeSalesOrder.close(objChangeSalesOrder.codsec);
                MessageBox.Show("Se ha realizado el cierre de la orden de cambio.", "Cambio de orden de venta", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                fillSummary();
                tbcChangeSalesOrder.SelectedIndex = 0;
            }
        }

        private void dgvChangeOrderSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
