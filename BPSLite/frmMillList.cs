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
using BPS.Lite.Reports;
using System.Threading;
using System.IO.Ports;

namespace BPS.Lite
{
    public partial class frmMillList : Form
    {
        public int codsec = 0;
        public bool isAutoricet = false;

        public frmMillList()
        {
            if (CheckOrder())
            {
                isAutoricet = true;
                InitializeComponent();
            }
            else
            {
                isAutoricet = false;
                MessageBox.Show("No existen material en Re-Proceso", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                this.Close();
            }
        }

        private bool CheckOrder()
        {
            List<clsMillPallet> lstMetal = new List<clsMillPallet>();
            lstMetal = clsMillPallet.getList();
            if (lstMetal.Count > 0)
                return true;
            else
                return false;
        }

        private void frmMetalizeOrderList_Load(object sender, EventArgs e)
        {
            PopulateOrder();
        }

        private void PopulateOrder()
        {
            try
            {
                List<clsMillPallet> lstMetal = new List<clsMillPallet>();
                lstMetal = clsMillPallet.getList();
                dgvMetalizeOrder.Rows.Clear();
                if (lstMetal.Count > 0)
                {
                    for (int i = 0; i < lstMetal.Count; i++)
                    {
                        dgvMetalizeOrder.Rows.Add();
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecodsec.Index].Value = lstMetal[i].codsec;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedensity.Index].Value = lstMetal[i].density;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizemill.Index].Value = lstMetal[i].MillName;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeproduct.Index].Value = lstMetal[i].ProductName + " - " + lstMetal[i].ProductCode;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecode.Index].Value = lstMetal[i].code;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeorder.Index].Value = lstMetal[i].order;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizednetweigth.Index].Value = lstMetal[i].netWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedgrossweigth.Index].Value = lstMetal[i].grossWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedpalletweigth.Index].Value = lstMetal[i].palletWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizenotes.Index].Value = lstMetal[i].notes;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedate.Index].Value = lstMetal[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedmystated.Index].Value = lstMetal[i].fkStatus;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizefkstatus.Index].Value = (lstMetal[i].fkStatus == 1075) ? global::BPS.Lite.Properties.Resources.lock_open : global::BPS.Lite.Properties.Resources.locktoclose;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizededit.Index].Value = (lstMetal[i].fkStatus == 1075) ? global::BPS.Lite.Properties.Resources.pencil : global::BPS.Lite.Properties.Resources.clear;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedprint.Index].Value = global::BPS.Lite.Properties.Resources.printer;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeddelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void PopulateOrderByFilter(string code)
        {
            try
            {
                List<clsMillPallet> lstMetal = new List<clsMillPallet>();
                lstMetal = clsMillPallet.getListByCode(code);
                dgvMetalizeOrder.Rows.Clear();
                if (lstMetal.Count > 0)
                {
                    for (int i = 0; i < lstMetal.Count; i++)
                    {
                        dgvMetalizeOrder.Rows.Add();
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecodsec.Index].Value = lstMetal[i].codsec;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedensity.Index].Value = lstMetal[i].density;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizemill.Index].Value = lstMetal[i].MillName;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeproduct.Index].Value = lstMetal[i].ProductName + " - " + lstMetal[i].ProductCode;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizecode.Index].Value = lstMetal[i].code;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeorder.Index].Value = lstMetal[i].order;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizednetweigth.Index].Value = lstMetal[i].netWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedgrossweigth.Index].Value = lstMetal[i].grossWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedpalletweigth.Index].Value = lstMetal[i].palletWeigth;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizenotes.Index].Value = lstMetal[i].notes;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedate.Index].Value = lstMetal[i].createdDate.ToString("dd/MM/yyyy HH:mm:ss");
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedmystated.Index].Value = lstMetal[i].fkStatus;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizefkstatus.Index].Value = (lstMetal[i].fkStatus == 1075) ? global::BPS.Lite.Properties.Resources.lock_open : global::BPS.Lite.Properties.Resources.locktoclose;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizededit.Index].Value = (lstMetal[i].fkStatus == 1075) ? global::BPS.Lite.Properties.Resources.pencil : global::BPS.Lite.Properties.Resources.clear;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizedprint.Index].Value = global::BPS.Lite.Properties.Resources.printer;
                        dgvMetalizeOrder.Rows[i].Cells[clmmetalizeddelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                    }
                }
                else
                {
                    MessageBox.Show("No existen registro con dicho código en Re-Proceso", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    PopulateOrder();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void dgvMetalizeOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == clmmetalizefkstatus.Index)
                {
                    if (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedmystated.Index].Value.ToString() == "1075")
                    {
                        if (MessageBox.Show("Está realmente seguro que desea cerrar la orden?\r\nRecuerde que no podrá adicionar ningún dato más!", "Re-Proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                        {
                            if (clsMillPallet.toClose(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value.ToString())))
                            {
                                MessageBox.Show("La orden cerrada correctamente", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateOrder();
                            }
                            else
                                MessageBox.Show("La orden no ha podido completar su proceso de Cerrar Orden", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        }
                    }
                }
                else if (e.ColumnIndex == clmmetalizededit.Index)
                {
                    if (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedmystated.Index].Value.ToString() == "1075")
                    {
                        frmMillOrder winMetal = new frmMillOrder(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value));
                        winMetal.MdiParent = this.MdiParent;
                        winMetal.StartPosition = FormStartPosition.CenterScreen;
                        winMetal.Show();
                        this.Close();
                    }
                    else
                        MessageBox.Show("No puede editar una orden que se encuentre cerrada por favor comuníquese con el departamento de sistemas", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else if (e.ColumnIndex == clmmetalizedprint.Index)
                {
                    if (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizemill.Index].Value.ToString() == "Molino 2" || dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizemill.Index].Value.ToString() == "Molino 3" || dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizemill.Index].Value.ToString() == "EREMA" || dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizemill.Index].Value.ToString() == "Extrusoras" || dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizemill.Index].Value.ToString() == "Tortas" || dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizemill.Index].Value.ToString() == "Celdas")
                        printMetalizedLabel(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value));
                    else if (dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizedensity.Index].Value.ToString() != "0")
                        printMetalizedLabel(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value));
                    else
                        MessageBox.Show("La etiqueta no puede ser impresa ya que no tiene DENSIDAD!!", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else if (e.ColumnIndex == clmmetalizeddelete.Index)
                {
                    if (MessageBox.Show("Está realmente seguro que desea eliminar la orden?", "Re-Proceso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                    {
                        if (clsMillPallet.toDelete(Convert.ToInt32(dgvMetalizeOrder.Rows[e.RowIndex].Cells[clmmetalizecodsec.Index].Value.ToString())))
                        {
                            MessageBox.Show("La orden eliminada correctamente", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                            PopulateOrder();
                        }
                        else
                            MessageBox.Show("La orden no ha podido completar su proceso de Cerrar Orden", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PopulateOrderByFilter(txtCode.Text);
            }
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

        private void dgvMetalizeOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                if (MessageBox.Show("Esta realmente seguro que desea Abrir la orden seleccionada??\r\n ORDEN # " + clsMillPallet.getMillPalletByCodsec(Convert.ToInt32(dgvMetalizeOrder.CurrentRow.Cells[clmmetalizecodsec.Index].Value)).code, "Listado Molinos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (clsMillPallet.toReOpen(Convert.ToInt32(dgvMetalizeOrder.CurrentRow.Cells[clmmetalizecodsec.Index].Value)))
                    {
                        MessageBox.Show("Orden re-abierta correctamente!!", "Listado Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        PopulateOrder();
                    }
                }
            }
        }
    }
}
