using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmProductionOrderEdit : Form
    {
        double totalSalesOrder = 0, totalInnerProduction = 0;
        clsBopp objBopp = new clsBopp();
        clsCast objCast = new clsCast();
        clsProductionOrder objProductionOrder = new clsProductionOrder();

        public frmProductionOrderEdit()
        {
            InitializeComponent();
        }
        public frmProductionOrderEdit(int productionOrderCodsec)
        {
            InitializeComponent();
            objProductionOrder.load(productionOrderCodsec);
        }
        private void calculateTotals()
        {
            totalSalesOrder = 0;
            totalInnerProduction = 0;

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                    totalSalesOrder += Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value);
            }

            totalInnerProduction = Convert.ToDouble(txtInnerProduction.Text);
            lblSalesOrderTotalSO.Text = totalSalesOrder.ToString();
            lblSalesOrderTotalValue.Text = totalSalesOrder.ToString();

            lblTotal.Text = Convert.ToString((totalSalesOrder + totalInnerProduction) * (1 + (Convert.ToDouble(nudExtraPercentage.Value) / 100)));
        }
        public void fillSalesOrderList()
        {
            List<clsSalesOrder> lstSalesOrder = new List<clsSalesOrder>();

            if (objProductionOrder.BoppOriginal.codsec > 0)
            {
                lstSalesOrder = clsSalesOrder.getListByBoppFilm(objProductionOrder.BoppOriginal.codsec);
            }
            else
            {
                lstSalesOrder = clsSalesOrder.getListByCastFilm(objProductionOrder.Cast.codsec);
            }
            
            dgvSalesOrder.Rows.Clear();
            lblSalesOrderTotalValue.Text = "0";
            lblSalesOrderTotalSO.Text = "0";

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                dgvSalesOrder.Rows.Add();
                dgvSalesOrder.Rows[i].Cells[clmCodsecSO.Index].Value = lstSalesOrder[i].codsec.ToString();
                dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value = lstSalesOrder[i].createdDate.ToString();
                dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value = lstSalesOrder[i].number.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                if (objProductionOrder.Bopp.codsec != 0)
                {
                    dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value = lstSalesOrder[i].totalByBoppFilm.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value = lstSalesOrder[i].totalByBoppFilm.ToString();
                }
                else
                {
                    dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value = lstSalesOrder[i].totalByCastFilm.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value = lstSalesOrder[i].totalByCastFilm.ToString();
                }

                for (int j = 0; j < objProductionOrder.lstSalesOrder.Count; j++)
                {
                    if (objProductionOrder.lstSalesOrder[j].codsec == lstSalesOrder[i].codsec)
                        dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value = objProductionOrder.lstSalesOrder[j].quantityByProductionOrder;
                }
                dgvSalesOrder.Rows[i].Cells[clmIsPlanned.Index].Value = lstSalesOrder[i].isPlannifiedByFilm.ToString();

                if (lstSalesOrder[i].isPlannifiedByFilm)
                    dgvSalesOrder.Rows[i].Cells[1].Style.BackColor = Color.PaleVioletRed;
            }

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                bool isSelected = false;

                for (int j = 0; j < objProductionOrder.lstSalesOrder.Count; j++)
                {
                    if (Convert.ToInt32(dgvSalesOrder.Rows[i].Cells[clmCodsecSO.Index].Value) == objProductionOrder.lstSalesOrder[j].codsec)
                        isSelected = true;
                }

                if (isSelected == true)
                    dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value = true;
            }

            calculateTotals();
            dgvSelectedSalesOrder.Rows.Clear();

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                {
                    dgvSelectedSalesOrder.Rows.Add();
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCodsecPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCodsecSO.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmDatePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmNumberPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCustomerNamePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalPlanifiedWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                }
            }
            dgvDetail.Rows.Clear();
        }

        
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref lblTotal, ref lblTotalToExtrude, "moreThan0")) isValid = false;

            return isValid;
        }

        private void frmProductionOrderEdit_Load(object sender, EventArgs e)
        {
            if (objProductionOrder.Bopp.codsec > 0)
            {
                objBopp.load(objProductionOrder.Bopp.codsec);

                lblFilmName.Text = "[" + objBopp.code + "] " + objBopp.name;
                lblFilmNamePO.Text = "[" + objBopp.code + "] " + objBopp.name;
                
                if (objProductionOrder.fkBoppOriginal == 0)
                    objProductionOrder.BoppOriginal = objProductionOrder.Bopp;
            }
            else
            {
                objCast.load(objProductionOrder.Cast.codsec);

                lblFilmName.Text = "[" + objCast.code + "] " + objCast.name;
                lblFilmNamePO.Text = "[" + objCast.code + "] " + objCast.name;
                
                //if (objProductionOrder.fkBoppOriginal == 0)
                //    objProductionOrder.BoppOriginal = objProductionOrder.Bopp;
            }
            fillSalesOrderList();
            lblTotal.Text = objProductionOrder.quantity.ToString();
            txtInnerProduction.Text = Convert.ToString(Math.Round(objProductionOrder.quantity - Convert.ToDouble(lblSalesOrderTotalSO.Text), 2));
        }

        private void dgvSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();

            if (e.ColumnIndex == 1)
            {if (Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmIsPlanned.Index].Value) == false)
                {
                    if (Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value) == true)
                        chkSelectAllSalesOrder.Checked = false;
                    dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value = !(Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value));
                    calculateTotals();
                }
            }

            lstSalesOrderDetail = clsSalesOrderDetail.getListByBoppFilm(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsecSO.Index].Value), Convert.ToInt32(objProductionOrder.BoppOriginal.codsec));
            dgvDetail.Rows.Clear();
            for (int i = 0; i < lstSalesOrderDetail.Count; i++)
            {
                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells[clmCodsecSOD.Index].Value = lstSalesOrderDetail[i].codsec.ToString();
                dgvDetail.Rows[i].Cells[clmProductCode.Index].Value = lstSalesOrderDetail[i].product.code;
                dgvDetail.Rows[i].Cells[clmProductName.Index].Value = lstSalesOrderDetail[i].product.name;
                dgvDetail.Rows[i].Cells[clmQuantity.Index].Value = lstSalesOrderDetail[i].quantity.ToString();
            }

            dgvSelectedSalesOrder.Rows.Clear();

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                {
                    dgvSelectedSalesOrder.Rows.Add();
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCodsecPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCodsecSO.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmDatePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmNumberPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCustomerNamePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalPlanifiedWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                }
            }
        }

        private void txtInnerProduction_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtInnerProduction.Text))
                calculateTotals();
            else
            {
                MessageBox.Show("El valor debe ser Numerico");
                txtInnerProduction.Text = "0";
                calculateTotals();
                txtInnerProduction.SelectAll();
            }
        }

        private void btnNextSalesOrderTab_Click(object sender, EventArgs e)
        {
            tbcWizard.SelectedTab = tbpFinalOrder;
        }

        private void btnBackProductionOrderTab_Click(object sender, EventArgs e)
        {
            tbcWizard.SelectedTab = tbpSalesOrder;
        }

        private void nudExtraPercentage_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void chkSelectAllSalesOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSelectAllSalesOrder.Checked)
            {
                for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                    dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value = true;
                calculateTotals();
            }

            dgvSelectedSalesOrder.Rows.Clear();

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                {
                    dgvSelectedSalesOrder.Rows.Add();
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCodsecPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCodsecSO.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmDatePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmNumberPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCustomerNamePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalPlanifiedWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                }
            }
        }

        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                objProductionOrder.quantity = Convert.ToDouble(lblTotal.Text);
                objProductionOrder.lstSalesOrder.Clear();

                for (int i = 0; i < dgvSelectedSalesOrder.Rows.Count; i++)
                {
                    objProductionOrder.lstSalesOrder.Add(new clsSalesOrder(Convert.ToInt32(dgvSelectedSalesOrder.Rows[i].Cells[clmCodsecPO.Index].Value)));
                    objProductionOrder.lstSalesOrder[i].quantityByProductionOrder = Convert.ToInt32(dgvSelectedSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeightPO.Index].Value);
                }

                if (objProductionOrder.save())
                {
                    clsFilmProductionPlan objFilmProductionPlan = new clsFilmProductionPlan();
                    objFilmProductionPlan.loadFilmProductionPlanByProductionOrder(objProductionOrder.codsec);
                    if (objFilmProductionPlan.codsec > 0)
                    {
                        objFilmProductionPlan.totalWeight = objProductionOrder.quantity;
                        objFilmProductionPlan.save();
                        clsFilmProductionPlan.recalculateActiveItemsByMachine(objFilmProductionPlan.fkMachine);
                    }
                    MessageBox.Show("Se ha actualizado la información con éxito.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        
            }
            else
                    MessageBox.Show("La información esta incompleta, por favor ingrese todos los campos solicitados.", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackSalesOrderTab_Click(object sender, EventArgs e)
        {

        }

        private void dgvSalesOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == clmTotalPlanifiedWeigthSalesOrder.Index)
            {
                if (clsGlobal.isNumeric(e.FormattedValue.ToString()))
                {
                    if (Convert.ToDouble(e.FormattedValue) <= Convert.ToDouble(dgvSalesOrder.Rows[e.RowIndex].Cells[clmTotalWeigthSalesOrder.Index].Value))
                        e.Cancel = false;
                    else
                    {
                        MessageBox.Show("El valor ingresado no puede ser mayor al valor total de la orden de venta, si desea ingresar un valor mayor debe ingresar la diferencia como programación interna", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        e.Cancel = true;
                    }
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es un valor numérico", "Orden de producción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    e.Cancel = true;
                }
            }
        }

        private void dgvSalesOrder_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmTotalPlanifiedWeigthSalesOrder.Index)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value) == true)
                    calculateTotals();

                dgvSelectedSalesOrder.Rows.Clear();

                for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                    {
                        dgvSelectedSalesOrder.Rows.Add();
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCodsecPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCodsecSO.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmDatePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmNumberPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmCustomerNamePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalPlanifiedWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmTotalPlanifiedWeigthSalesOrder.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                    }
                }
            }
        }
    }
}