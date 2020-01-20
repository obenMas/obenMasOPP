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
    public partial class frmProductionOrderForm : Form
    {
        double totalSalesOrder = 0, totalInnerProduction = 0, totalTotal = 0;
        clsBopp objBopp = new clsBopp();
        clsBopp objBaseBopp = new clsBopp();
        bool enableCalculate = true;

        clsProductionOrder objProductionOrder = new clsProductionOrder();

        public frmProductionOrderForm()
        {
            InitializeComponent();
        }
        private void calculateTotals()
        {
            totalSalesOrder = 0;
            totalInnerProduction = 0;

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                    totalSalesOrder += Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[clmPlannifiedWeigth.Index].Value);
            }

            totalInnerProduction = Convert.ToDouble(txtInnerProduction.Text);
            lblSalesOrderTotalSO.Text = totalSalesOrder.ToString();
            lblSalesOrderTotalValue.Text = totalSalesOrder.ToString();

            lblTotal.Text = Convert.ToString((totalSalesOrder + totalInnerProduction) * (1 + (Convert.ToDouble(nudExtraPercentage.Value) / 100)));
        }

        public void calculateTotalsRetro()
        {
            totalSalesOrder = 0;
            totalInnerProduction = 0;
            totalTotal = 0;

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmSelectSalesOrder.Index].Value) == true)
                    totalSalesOrder += Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[clmPlannifiedWeigth.Index].Value);
            }

            totalTotal = Convert.ToDouble(lblTotal.Text);
            lblSalesOrderTotalSO.Text = totalSalesOrder.ToString();
            lblSalesOrderTotalValue.Text = totalSalesOrder.ToString();

            txtInnerProduction.Text = Convert.ToString((totalTotal - totalSalesOrder));

            nudExtraPercentage.Value = 0;
        }
        public void fillFilmList()
        {
            dgvBopp.Rows.Clear();

            List<clsBopp> lstBopp = new List<clsBopp>();
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (txtBoppCode.Text == "")
                lstBopp = clsBopp.getSimplifiedListWithSalesOrderQuantities();
            else
            {                
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "bopp_code";
                lstFilter[lstFilter.Count - 1].operation = "startsWith";
                lstFilter[lstFilter.Count - 1].value = txtBoppCode.Text;
                lstFilter[lstFilter.Count - 1].dataType = "varchar";
                
                lstBopp = clsBopp.getSimplifiedListWithSalesOrderQuantitiesByFilter(lstFilter);
            }

            for (int i = 0; i < lstBopp.Count; i++)
            {
                dgvBopp.Rows.Add();
                dgvBopp.Rows[i].Cells[clmCodsec.Index].Value = lstBopp[i].codsec.ToString();
                dgvBopp.Rows[i].Cells[clmCode.Index].Value = lstBopp[i].code;
                dgvBopp.Rows[i].Cells[clmName.Index].Value = lstBopp[i].name;
                dgvBopp.Rows[i].Cells[clmBaseFilm.Index].Value = lstBopp[i].baseFilmCode;
                dgvBopp.Rows[i].Cells[clmTotalWeightFilms.Index].Value = lstBopp[i].salesOrderQuantity.ToString();
            }
        }

        public void fillSalesOrderList()
        {
            List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getListByBoppFilm(objBopp.codsec);

            dgvSalesOrder.Rows.Clear();

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                dgvSalesOrder.Rows.Add();
                dgvSalesOrder.Rows[i].Cells[clmCodsec.Index].Value = lstSalesOrder[i].codsec.ToString();
                dgvSalesOrder.Rows[i].Cells[clmDate.Index].Value = lstSalesOrder[i].createdDate.ToString();
                dgvSalesOrder.Rows[i].Cells[clmNumber.Index].Value = lstSalesOrder[i].number.ToString();
                dgvSalesOrder.Rows[i].Cells[clmCustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                dgvSalesOrder.Rows[i].Cells[clmTotalWeigthSalesOrder.Index].Value = lstSalesOrder[i].totalByBoppFilm.ToString();
                dgvSalesOrder.Rows[i].Cells[clmPlannifiedWeigth.Index].Value = lstSalesOrder[i].totalByBoppFilm.ToString();
                dgvSalesOrder.Rows[i].Cells[clmIsPlanned.Index].Value = lstSalesOrder[i].isPlannifiedByFilm.ToString();

                if (lstSalesOrder[i].isPlannifiedByFilm)
                    dgvSalesOrder.Rows[i].Cells[1].Style.BackColor = Color.PaleVioletRed;
            }
            dgvDetail.Rows.Clear();
            lblSalesOrderTotalValue.Text = "0";
            lblSalesOrderTotalSO.Text = "0";
        }
        
        private bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref lblTotal, ref lblTotalToExtrude, "moreThan0")) isValid = false;

            return isValid;
        }

        private void frmProductionOrderForm_Load(object sender, EventArgs e)
        {
            fillFilmList();
        }

        private void btnNextFilmTab_Click(object sender, EventArgs e)
        {
            fillSalesOrderList();
            tbcWizard.SelectedTab = tbpSalesOrder;
        }

        private void dgvSalesOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtInnerProduction_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtInnerProduction.Text))
                calculateTotals();
            else
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtInnerProduction.Text = "0";
                calculateTotals();
                txtInnerProduction.SelectAll();
            }
        }

        private void btnBackSalesOrderTab_Click(object sender, EventArgs e)
        {
            tbcWizard.SelectedTab = tbpFilm;
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
            enableCalculate = false;
            calculateTotals();
            enableCalculate = true;
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
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmPlannifiedWeigth.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                objProductionOrder.fkBopp = objBaseBopp.codsec;
                objProductionOrder.fkBoppOriginal = objBopp.codsec;
                objProductionOrder.quantity = Convert.ToDouble(lblTotal.Text);
                for (int i = 0; i < dgvSelectedSalesOrder.Rows.Count; i++)
                {
                    objProductionOrder.lstSalesOrder.Add(new clsSalesOrder(Convert.ToInt32(dgvSelectedSalesOrder.Rows[i].Cells[clmCodsecPO.Index].Value)));
                    objProductionOrder.lstSalesOrder[i].quantityByProductionOrder = Convert.ToInt32(Math.Round(Convert.ToDouble(dgvSelectedSalesOrder.Rows[i].Cells[clmTotalWeightPO.Index].Value),0));
                }

                if (objProductionOrder.save())
                {
                    DialogResult DlrNueva = new DialogResult();

                    DlrNueva = MessageBox.Show("Desea crear una nueva orden?", "Nueva Orden de producción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                    if (DlrNueva == DialogResult.Yes)
                    {
                        clsGlobal.ClearForm(this);
                        fillFilmList();
                        objProductionOrder = new clsProductionOrder();
                        dgvBopp.Focus();
                        tbcWizard.SelectedIndex = 0;
                    }
                    else if (DlrNueva == DialogResult.No)
                    {
                        DialogResult DlrPlanificar = new DialogResult();
                        DlrPlanificar = MessageBox.Show("Desea realizar la planificación de esta orden", "Nueva Orden de producción", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                        if (DlrPlanificar == DialogResult.Yes)
                        {
                            frmFilmProductionPlan winFilmProductionPlan = new frmFilmProductionPlan();
                            winFilmProductionPlan.MdiParent = this.MdiParent;
                            winFilmProductionPlan.Show();
                            this.Close();
                        }
                        else
                            this.Close();
                    }
                    else if (DlrNueva == DialogResult.Cancel)
                        this.Close();
                }
            }
            else
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clsGlobal.ClearForm(this);
            fillFilmList();
            dgvBopp.Focus();
            tbcWizard.SelectedIndex = 0;
        }

        private void dgvSalesOrder_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == clmPlannifiedWeigth.Index)
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
            if (e.ColumnIndex == clmPlannifiedWeigth.Index)
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
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmPlannifiedWeigth.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                        dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                    }
                }
            }
        }
        private void dgvBopp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                objBopp.load(Convert.ToInt32(dgvBopp.Rows[e.RowIndex].Cells[clmCodsec.Index].Value));

                if (objBopp.fkBaseFilm != 0)
                {
                    objBaseBopp = new clsBopp(objBopp.fkBaseFilm);
                    lblFilmName.Text = "[" + objBaseBopp.code + "] " + objBaseBopp.name;
                    lblFilmNamePO.Text = "[" + objBaseBopp.code + "] " + objBaseBopp.name;
                    lblFamilyName.Text = objBaseBopp.familyName;
                    lblSubFamilyName.Text = objBaseBopp.subFamilyName;
                    lblInnerSealName.Text = objBaseBopp.innerSealName;
                    lblOuterSealName.Text = objBaseBopp.outerSealName;
                    lblCentralAdditivationName.Text = objBaseBopp.centralAdditivationName;
                    lblSurfaceAdditivationName.Text = objBaseBopp.surfaceAdditivationName;
                    lblThiknessName.Text = objBaseBopp.thicknessValue;
                    lblTreatmentName.Text = objBaseBopp.treatmentName;
                }
                else
                {
                    objBaseBopp = objBopp;

                    lblFilmName.Text = "[" + objBopp.code + "] " + objBopp.name;
                    lblFilmNamePO.Text = "[" + objBopp.code + "] " + objBopp.name;

                    lblFamilyName.Text = objBopp.familyName;
                    lblSubFamilyName.Text = objBopp.subFamilyName;
                    lblInnerSealName.Text = objBopp.innerSealName;
                    lblOuterSealName.Text = objBopp.outerSealName;
                    lblCentralAdditivationName.Text = objBopp.centralAdditivationName;
                    lblSurfaceAdditivationName.Text = objBopp.surfaceAdditivationName;
                    lblThiknessName.Text = objBopp.thicknessValue;
                    lblTreatmentName.Text = objBopp.treatmentName;
                }
                fillSalesOrderList();
                tbcWizard.SelectedIndex = 1;
            }

        }

        private void dgvSalesOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();

            if (e.ColumnIndex == 1)
            {
                //if (Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmIsPlanned.Index].Value) == false)
                //{
                if (Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value) == true)
                    chkSelectAllSalesOrder.Checked = false;

                dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value = !(Convert.ToBoolean(dgvSalesOrder.Rows[e.RowIndex].Cells[clmSelectSalesOrder.Index].Value));
                calculateTotals();
                //}
            }

            lstSalesOrderDetail = clsSalesOrderDetail.getListByBoppFilm(Convert.ToInt32(dgvSalesOrder.SelectedRows[0].Cells[clmCodsecSO.Index].Value), Convert.ToInt32(dgvBopp.SelectedRows[0].Cells[clmCodsec.Index].Value));
            dgvDetail.Rows.Clear();
            for (int i = 0; i < lstSalesOrderDetail.Count; i++)
            {
                dgvDetail.Rows.Add();
                dgvDetail.Rows[i].Cells[clmCodsec.Index].Value = lstSalesOrderDetail[i].codsec.ToString();
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
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmTotalWeightPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmPlannifiedWeigth.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightFullfilledPO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightFulfilledSalesOrder.Index].Value;
                    dgvSelectedSalesOrder.Rows[dgvSelectedSalesOrder.Rows.Count - 1].Cells[clmWeightSlopePO.Index].Value = dgvSalesOrder.Rows[i].Cells[clmWeightSlopeSalesOrder.Index].Value;
                }
            }
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            if (enableCalculate)
            {
                if (clsGlobal.isNumeric(txtInnerProduction.Text))
                    calculateTotalsRetro();
                else
                {
                    MessageBox.Show("El valor debe ser Numérico");
                    txtInnerProduction.Text = "0";
                    calculateTotalsRetro();
                    txtInnerProduction.SelectAll();
                }
            }
        }

        private void txtBoppCode_TextChanged(object sender, EventArgs e)
        {
            fillFilmList();
        }
    }
}