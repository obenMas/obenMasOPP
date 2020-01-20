using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmProductionOrdenList : Form
    {
        clsMachine objMachine = new clsMachine();
        public frmProductionOrdenList()
        {
            InitializeComponent();
        }
        public frmProductionOrdenList(int machineCodsec)
        {
            InitializeComponent();
            objMachine.load(machineCodsec, "Extruder");
            this.Text = "Listado Ordenes de Producción de " + objMachine.Extruder.name;
        }
        private void frmProductionOrdenList_Load(object sender, EventArgs e)
        {
            List<clsFilmProductionPlanByProductionOrder> lstFilmProductionPlanByProductionOrder = new List<clsFilmProductionPlanByProductionOrder>();
            lstFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getListActiveOrderByMachine(objMachine.codsec);
            dgvProductionOrderList.Rows.Clear();

            for (int i = 0; i < lstFilmProductionPlanByProductionOrder.Count; i++)
            {
                dgvProductionOrderList.Rows.Add();
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListCodsec.Index].Value = lstFilmProductionPlanByProductionOrder[i].fkProductionOrder.ToString();
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderNumber.Index].Value = lstFilmProductionPlanByProductionOrder[i].lotNumber;
                if (lstFilmProductionPlanByProductionOrder[i].fkBopp > 0)
                {
                    dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "BOPP";
                    dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = lstFilmProductionPlanByProductionOrder[i].BoppCode;
                }
                else
                {
                    dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "CAST";
                    dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = lstFilmProductionPlanByProductionOrder[i].castCode;
                }
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderWidths.Index].Value = lstFilmProductionPlanByProductionOrder[i].widths;
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderLength.Index].Value = lstFilmProductionPlanByProductionOrder[i].estimatedLength.ToString();
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderQuantity.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlanByProductionOrder[i].Quantity, 2));
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFulfilledQuantity.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlanByProductionOrder[i].FulfilledQuantity, 2));
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderPendingQuantity.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlanByProductionOrder[i].Quantity - lstFilmProductionPlanByProductionOrder[i].FulfilledQuantity, 2));
                dgvProductionOrderList.Rows[i].Cells[clmProductionOrderStatus.Index].Value = lstFilmProductionPlanByProductionOrder[i].StatusName;

                clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan(lstFilmProductionPlanByProductionOrder[i].fkFilmProductionPlan, true);

                if (objFilmProductionPlan.variation)
                    dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = objFilmProductionPlan.variationDate.ToString("dd/MM/yyyy");
                else
                    dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = "";

                if (lstFilmProductionPlanByProductionOrder[i].StatusName == "En producción")
                {
                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                }
                else
                {
                    if (lstFilmProductionPlanByProductionOrder[i].StatusName == "Cerrada")
                    {
                        if (objFilmProductionPlan.variation)
                        {
                            for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }
                    else
                    {
                        if (lstFilmProductionPlanByProductionOrder[i].StatusName == "Anulada")
                        {
                            for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                        }
                    }
                }
            }

            fillBoppFilm();
        }

        private void fillBoppFilm()
        {
            var boppList = from boppSortList in clsBopp.getListShort()
                           orderby boppSortList.code
                           select boppSortList;

            cmbBopp.Items.Clear();

            foreach (var item in boppList)
            {
                cmbBopp.Items.Add(item);
            }
        }

        private void btnProductionOrderClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductionOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductionOrderList.SelectedRows[0].Cells[clmProductionOrderListFilmType.Index].Value.ToString().ToUpper() == "BOPP")
            {
                frmProductionOrderDetails winProductionOrderDetails = new frmProductionOrderDetails(Convert.ToInt32(dgvProductionOrderList.SelectedRows[0].Cells[clmProductionOrderListCodsec.Index].Value));
                winProductionOrderDetails.MdiParent = this.MdiParent;
                winProductionOrderDetails.StartPosition = FormStartPosition.Manual;
                winProductionOrderDetails.Show();
                //this.Close();
            }
            else
            {
                frmProductionOrderCastDetails winProductionOrderCastDetails = new frmProductionOrderCastDetails(Convert.ToInt32(dgvProductionOrderList.SelectedRows[0].Cells[clmProductionOrderListCodsec.Index].Value));
                winProductionOrderCastDetails.MdiParent = this.MdiParent;
                winProductionOrderCastDetails.StartPosition = FormStartPosition.Manual;
                winProductionOrderCastDetails.Show();
                //this.Close();
            }
        }

        private void btnProductionOrderAccept_Click(object sender, EventArgs e)
        {
            frmProductionOrderDetails winProductionOrderDetails = new frmProductionOrderDetails(Convert.ToInt32(dgvProductionOrderList.SelectedRows[0].Cells[clmProductionOrderListCodsec.Index].Value));
            winProductionOrderDetails.MdiParent = this.MdiParent;
            winProductionOrderDetails.Show();
            this.Close();
        }

        private void cmbBopp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLot_KeyDown(object sender, KeyEventArgs e)
        {
            List<clsFilmProductionPlanByProductionOrder> productionList = new List<clsFilmProductionPlanByProductionOrder>();

            if (e.KeyCode == Keys.Enter)
            {
                if (txtLot.Text.Length > 0)
                {
                    productionList = clsFilmProductionPlanByProductionOrder.getListActiveOrderByMachineByFilter(objMachine.codsec, txtLot.Text);
                    dgvProductionOrderList.Rows.Clear();

                    for (int i = 0; i < productionList.Count; i++)
                    {
                        dgvProductionOrderList.Rows.Add();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListCodsec.Index].Value = productionList[i].fkProductionOrder.ToString();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderNumber.Index].Value = productionList[i].lotNumber;
                        if (productionList[i].fkBopp > 0)
                        {
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "BOPP";
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = productionList[i].BoppCode;
                        }
                        else
                        {
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "CAST";
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = productionList[i].castCode;
                        }
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderWidths.Index].Value = productionList[i].widths;
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderLength.Index].Value = productionList[i].estimatedLength.ToString();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderQuantity.Index].Value = Convert.ToString(Math.Round(productionList[i].Quantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFulfilledQuantity.Index].Value = Convert.ToString(Math.Round(productionList[i].FulfilledQuantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderPendingQuantity.Index].Value = Convert.ToString(Math.Round(productionList[i].Quantity - productionList[i].FulfilledQuantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderStatus.Index].Value = productionList[i].StatusName;

                        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan(productionList[i].fkFilmProductionPlan, true);

                        if (objFilmProductionPlan.variation)
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = objFilmProductionPlan.variationDate.ToString("dd/MM/yyyy");
                        else
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = "";

                        if (productionList[i].StatusName == "En producción")
                        {
                            for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        }
                        else
                        {
                            if (productionList[i].StatusName == "Cerrada")
                            {
                                if (objFilmProductionPlan.variation)
                                {
                                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                }
                            }
                            else
                            {
                                if (productionList[i].StatusName == "Anulada")
                                {
                                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                                }
                            }
                        }
                    }
                }
                else
                {
                    productionList = clsFilmProductionPlanByProductionOrder.getListActiveOrderByMachine(objMachine.codsec);
                    dgvProductionOrderList.Rows.Clear();

                    for (int i = 0; i < productionList.Count; i++)
                    {
                        dgvProductionOrderList.Rows.Add();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListCodsec.Index].Value = productionList[i].fkProductionOrder.ToString();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderNumber.Index].Value = productionList[i].lotNumber;
                        if (productionList[i].fkBopp > 0)
                        {
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "BOPP";
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = productionList[i].BoppCode;
                        }
                        else
                        {
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "CAST";
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = productionList[i].castCode;
                        }
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderWidths.Index].Value = productionList[i].widths;
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderLength.Index].Value = productionList[i].estimatedLength.ToString();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderQuantity.Index].Value = Convert.ToString(Math.Round(productionList[i].Quantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFulfilledQuantity.Index].Value = Convert.ToString(Math.Round(productionList[i].FulfilledQuantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderPendingQuantity.Index].Value = Convert.ToString(Math.Round(productionList[i].Quantity - productionList[i].FulfilledQuantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderStatus.Index].Value = productionList[i].StatusName;

                        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan(productionList[i].fkFilmProductionPlan, true);

                        if (objFilmProductionPlan.variation)
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = objFilmProductionPlan.variationDate.ToString("dd/MM/yyyy");
                        else
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = "";

                        if (productionList[i].StatusName == "En producción")
                        {
                            for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        }
                        else
                        {
                            if (productionList[i].StatusName == "Cerrada")
                            {
                                if (objFilmProductionPlan.variation)
                                {
                                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                }
                            }
                            else
                            {
                                if (productionList[i].StatusName == "Anulada")
                                {
                                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void cmbBopp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbBopp.SelectedIndex > -1)
                {
                    List<clsFilmProductionPlanByProductionOrder> lstFilmProductionPlanByProductionOrder = new List<clsFilmProductionPlanByProductionOrder>();
                    lstFilmProductionPlanByProductionOrder = clsFilmProductionPlanByProductionOrder.getListActiveOrderByMachineByFilter(objMachine.codsec, ((clsBopp)cmbBopp.SelectedItem).codsec);
                    dgvProductionOrderList.Rows.Clear();

                    for (int i = 0; i < lstFilmProductionPlanByProductionOrder.Count; i++)
                    {
                        dgvProductionOrderList.Rows.Add();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListCodsec.Index].Value = lstFilmProductionPlanByProductionOrder[i].fkProductionOrder.ToString();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderNumber.Index].Value = lstFilmProductionPlanByProductionOrder[i].lotNumber;
                        if (lstFilmProductionPlanByProductionOrder[i].fkBopp > 0)
                        {
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "BOPP";
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = lstFilmProductionPlanByProductionOrder[i].BoppCode;
                        }
                        else
                        {
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderListFilmType.Index].Value = "CAST";
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFilm.Index].Value = lstFilmProductionPlanByProductionOrder[i].castCode;
                        }
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderWidths.Index].Value = lstFilmProductionPlanByProductionOrder[i].widths;
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderLength.Index].Value = lstFilmProductionPlanByProductionOrder[i].estimatedLength.ToString();
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderQuantity.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlanByProductionOrder[i].Quantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderFulfilledQuantity.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlanByProductionOrder[i].FulfilledQuantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderPendingQuantity.Index].Value = Convert.ToString(Math.Round(lstFilmProductionPlanByProductionOrder[i].Quantity - lstFilmProductionPlanByProductionOrder[i].FulfilledQuantity, 2));
                        dgvProductionOrderList.Rows[i].Cells[clmProductionOrderStatus.Index].Value = lstFilmProductionPlanByProductionOrder[i].StatusName;

                        clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan(lstFilmProductionPlanByProductionOrder[i].fkFilmProductionPlan, true);

                        if (objFilmProductionPlan.variation)
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = objFilmProductionPlan.variationDate.ToString("dd/MM/yyyy");
                        else
                            dgvProductionOrderList.Rows[i].Cells[clmProductionOrderVariation.Index].Value = "";

                        if (lstFilmProductionPlanByProductionOrder[i].StatusName == "En producción")
                        {
                            for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                        }
                        else
                        {
                            if (lstFilmProductionPlanByProductionOrder[i].StatusName == "Cerrada")
                            {
                                if (objFilmProductionPlan.variation)
                                {
                                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                }
                            }
                            else
                            {
                                if (lstFilmProductionPlanByProductionOrder[i].StatusName == "Anulada")
                                {
                                    for (int j = 0; j < dgvProductionOrderList.ColumnCount; j++)
                                        dgvProductionOrderList.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}