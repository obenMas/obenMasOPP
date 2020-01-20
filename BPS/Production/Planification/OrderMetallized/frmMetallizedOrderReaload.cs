using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Threading;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmMetallizedOrderReaload : Form
    {
        List<clsBopp> lstBopp = new List<clsBopp>();
        List<int> lstDetails = new List<int>();
        List<int> lstWidthTo = new List<int>();

        public string widthFrom = "", widthTo = "";
        public int selectedProductCodsec = 0, fkBoppTo = 0, fkBoppFrom = 0;

        clsProduct objSelectedProduct = new clsProduct();
        
        //List<clsPallet> lstBopp = new List<clsPallet>();
        //List<clsMaquile> lstMaquile = new List<clsMaquile>();
        
        //clsProduct objProduct = new clsProduct();
        //string source = "";
        //int sorucecodsec = 0;
        //int sourcesfrom = 0;
        //int sourceto = 0;
        //int sourcetomaquile = 0;
        //int sourcetoo = 0;
        //int mydetail = 0;
        //int place = 0;

        bool executeFilter = true;

        delegate void showLoading();
        delegate void HideLoading();

        showLoading showLoadImage;
        HideLoading hideLoadImage;

        private void loadMovements()
        {
            this.Invoke(showLoadImage);
            lstBopp = clsBopp.getListBaseFilm(0);
            this.Invoke(hideLoadImage);
        }

        private void showLoadingDelegate()
        {
            pbxLoading.Visible = true;
            grpbFilters.Enabled = false;
            lblLoading.Visible = true;
        }

        private void hideLoadingDelegate()
        {
            fillPalletInfo();

            List<string> lstFilm = new List<string>();

            for (int i = 0; i < lstBopp.Count; i++)
            {
                //Film
                bool flgIsProductInList = false;
                for (int j = 0; j < lstFilm.Count; j++)
                {
                    if (lstFilm[j] == lstBopp[i].code)
                    {
                        flgIsProductInList = true;
                        break;
                    }
                }
                if (flgIsProductInList == false)
                    lstFilm.Add(lstBopp[i].code);
            }
            lstFilm.Sort();

            cmbFilm.Items.Clear();

            for (int i = 0; i < lstFilm.Count; i++)
                cmbFilm.Items.Add(lstFilm[i]);

            grpbFilters.Enabled = true;
            pbxLoading.Visible = false;
            lblLoading.Visible = false;
        }

        public frmMetallizedOrderReaload()
        {
            InitializeComponent();
            tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
            getBoppList();
        }

        private void getBoppList()
        {
            showLoadImage = new showLoading(showLoadingDelegate);
            hideLoadImage = new HideLoading(hideLoadingDelegate);
        }

        private void fillPalletInfo()
        {
            if (executeFilter == true)
            {
                dgvStockBackload.Rows.Clear();

                for (int i = 0; i < lstBopp.Count; i++)
                {
                    bool flgInclude = false;
                    bool flgOKFilm = false;

                    if (cmbFilm.Text != "" || cmbFilm.SelectedIndex > -1)
                    {
                        //Film
                        if (cmbFilm.SelectedIndex > -1 || cmbFilm.Text != "")
                        {
                            if (lstBopp[i].code.ToUpper().StartsWith(cmbFilm.Text.ToString().ToUpper()))
                                flgOKFilm = true;
                        }
                        if (cmbFilm.Text == "" && cmbFilm.SelectedIndex == -1)
                            flgOKFilm = true;

                        if (flgOKFilm)
                            flgInclude = true;
                    }
                    else
                        flgInclude = true;

                    if (flgInclude == true)
                    {
                        dgvStockBackload.Rows.Add();
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcodsec.Index].Value = lstBopp[i].codsec;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadfilm.Index].Value = lstBopp[i].code;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadthickness.Index].Value = lstBopp[i].thicknessValue;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadweigth.Index].Value = (lstBopp[i].ismaquile == false) ? lstBopp[i].weigth : lstBopp[i].maqweigth;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadcellar.Index].Value = "Bodega Materiales a Metalizar";
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadmetalcodsec.Index].Value = lstBopp[i].metalcodsec;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadmetalname.Index].Value = lstBopp[i].metalName;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadwidth.Index].Value = (lstBopp[i].ismaquile == false) ? lstBopp[i].width : lstBopp[i].maqwidth;
                        dgvStockBackload.Rows[dgvStockBackload.Rows.Count - 1].Cells[clmbackloadismaquile.Index].Value = lstBopp[i].ismaquile;
                    }       
                }
            }
        }

        private void loadComboMachine()
        {
            List<clsMachine> lstMachine = new List<clsMachine>();
            cmbMachine.Items.Clear();
            if (cmbMachine.SelectedIndex + 1 >= 0)
            {
                lstMachine = clsMachine.getMetallizerMachineList();
                for (int i = 0; i < lstMachine.Count; i++)
                    cmbMachine.Items.Add(lstMachine[i]);
            }
        }

        private void frmMetallizedOrderReaload_Load(object sender, EventArgs e)
        {
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();

            PopulateSumary();
        }

        private void btnRefreshBopp_Click(object sender, EventArgs e)
        {
            dgvStockBackload.Rows.Clear();
            Thread td = new Thread(new ThreadStart(this.loadMovements));
            td.Start();
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                fillPalletInfo();
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilm.SelectedIndex > -1)
                fillPalletInfo();
        }

        private void dgvStockBackload_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadcodsec.Index].Value) > 0)
                {
                    lblBaseFilm.Text = "[" + dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadfilm.Index].Value.ToString() + "] ";
                    lblMetalFilm.Text = "[" + dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadmetalname.Index].Value.ToString() + "] ";
                    lblFrom.Text = lblBaseFilm.Text.Replace("[","").Replace("]","");
                    lblProductoTo.Text = lblMetalFilm.Text.Replace("[", "").Replace("]", "");
                    FillSalesOrderByFilm(Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadmetalcodsec.Index].Value));
                    fkBoppFrom = Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadcodsec.Index].Value);
                    fkBoppTo = Convert.ToInt32(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadmetalcodsec.Index].Value);
                    widthFrom = dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadwidth.Index].Value.ToString();
                    txtInnerProduction.Text = Math.Round(Convert.ToDouble(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadweigth.Index].Value), 2).ToString();
                    calculateTotals();
                    tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
                    tbcChangeSalesOrder.TabPages.Insert(1, tbpCuttingPlan);
                    tbpCuttingPlan.Text = (Convert.ToBoolean(dgvStockBackload.Rows[e.RowIndex].Cells[clmbackloadismaquile.Index].Value) == false) ? "Ordenes de Metalizado" : "Ordenes de Maquilas a Metalizar";
                    tbcChangeSalesOrder.SelectedIndex = 1;
                    loadComboMachine();
                }
                else
                    MessageBox.Show("Por favor seleccione un producto válido", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void calculateTotals()
        {
            double totalSalesOrder = 0;
            double totalInnerProduction = 0;

            for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value) == true)
                    totalSalesOrder += Convert.ToDouble(dgvSalesOrder.Rows[i].Cells[clmsalesweigth.Index].Value);
            }

            totalInnerProduction = Convert.ToDouble(txtInnerProduction.Text);
            lblSalesOrderTotalValue.Text = totalSalesOrder.ToString();

            lblTotal.Text = Math.Round(((totalSalesOrder + totalInnerProduction) * (1 + (Convert.ToDouble(nudExtraPercentage.Value) / 100))), 2).ToString();
        }

        private void FillSalesOrderByFilm(int codsec)
        {
            List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getListByMetalizedProduct(codsec);
            dgvSalesOrder.Rows.Clear();

            if (lstSalesOrder.Count > 0)
            {
                for (int i = 0; i < lstSalesOrder.Count; i++)
                {
                    dgvSalesOrder.Rows.Add();
                    dgvSalesOrder.Rows[i].Cells[clmsalescodsec.Index].Value = lstSalesOrder[i].codsec.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesfkproduct.Index].Value = lstSalesOrder[i].fkProduct.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalescodsecdetail.Index].Value = lstSalesOrder[i].codsecDetail.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesproduct.Index].Value = lstSalesOrder[i].product.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalescustomer.Index].Value = lstSalesOrder[i].EntityName.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesorder.Index].Value = lstSalesOrder[i].number.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesweigth.Index].Value = lstSalesOrder[i].quantity.ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesdate.Index].Value = lstSalesOrder[i].createdDate.ToShortDateString();
                    dgvSalesOrder.Rows[i].Cells[clmsalescuttingweigth.Index].Value = Math.Round(lstSalesOrder[i].totalByBoppFilm, 2, MidpointRounding.AwayFromZero).ToString();
                    dgvSalesOrder.Rows[i].Cells[clmsalesisinternational.Index].Value = (lstSalesOrder[i].isInternationalSale == true) ? global::BPS.Properties.Resources.world : global::BPS.Properties.Resources.table;
                    dgvSalesOrder.Rows[i].Cells[clmsaleswidth.Index].Value = lstSalesOrder[i].width.ToString();
                }
            }
            else
                dgvSalesOrder.Rows.Clear();
        }

        private void dgvSalesOrder_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmsalesisinternational.Index].Value = global::BPS.Properties.Resources.table;
            e.Row.Cells[clmsalesin.Index].Value = true;
            e.Row.Cells[clmsalescodsecdetail.Index].Value = 0;
            e.Row.Cells[clmsalesproduct.Index].Value = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateFrom())
                {
                    if (Convert.ToDouble(nudCoilsToChange.Value) > 0)
                    {
                        clsProductionOrderMetal objProductionOrderMetal = new clsProductionOrderMetal();
                        objProductionOrderMetal.fkBopp = fkBoppFrom;
                        objProductionOrderMetal.fkBoppTo = fkBoppTo;
                        objProductionOrderMetal.number = clsSequential.SequentialList("metallizedOrder");
                        objProductionOrderMetal.quantity = Convert.ToDouble(lblTotal.Text);
                        if (lstDetails.Count > 0)
                        {
                            for (int i = 0; i < lstDetails.Count; i++)
                                objProductionOrderMetal.lstdetail.Add(lstDetails[i]);
                        }
                        if (objProductionOrderMetal.save())
                        {
                            clsFilmProductionPlanMetal objFilmProductionPlanMetal = new clsFilmProductionPlanMetal();
                            objFilmProductionPlanMetal.fkProductionOrder = objProductionOrderMetal.getLastSavedCodsec();
                            objFilmProductionPlanMetal.fkMachine = ((clsMachine)cmbMachine.SelectedItem).codsec;
                            objFilmProductionPlanMetal.lotNumber = "----------";
                            objFilmProductionPlanMetal.widthFrom = widthFrom.Replace(" ","-");
                            objFilmProductionPlanMetal.widthTo = GetWidthTo().Substring(0, widthTo.Length - 1).Replace(" ","-");
                            objFilmProductionPlanMetal.estimatedInitDate = Convert.ToDateTime(dtpInitDate.Value);
                            objFilmProductionPlanMetal.estimatedKilogramsPerHour = Convert.ToInt32(txtkg.Text);
                            objFilmProductionPlanMetal.estimatedEndDate = objFilmProductionPlanMetal.estimatedInitDate.AddHours((objProductionOrderMetal.quantity / Convert.ToInt32(txtkg.Text)));
                            objFilmProductionPlanMetal.coilsnumber = Convert.ToInt32(nudCoilsToChange.Value);
                            objFilmProductionPlanMetal.density = Convert.ToDouble(txtopticDensity.Text);
                            objFilmProductionPlanMetal.notes = txtNotes.Text;
                            if (objFilmProductionPlanMetal.save())
                            {
                                MessageBox.Show("Orden  de Metalizado Generada Correctamente", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                                PopulateSumary();
                                tbcChangeSalesOrder.SelectedIndex = 2;
                                ClearMyData();
                            }
                        }
                    }
                    else
                        MessageBox.Show("Debe asignar por lo menos una bobina para metalizar", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private string GetWidthTo()
        {
            widthTo = "";
            lstWidthTo = lstWidthTo.Distinct().ToList();
            lstWidthTo.Sort();
            for (int i = 0; i < lstWidthTo.Count; i++)
                widthTo += lstWidthTo[i].ToString() + " ";

            return widthTo;
        }

        private void ClearMyData()
        {
            dgvSalesOrder.Rows.Clear();
            lblSalesOrderTotalValue.Text = "0";
            txtInnerProduction.Text = "0";
            nudExtraPercentage.Value = 0;
            lblTotal.Text = "0";
            lblFrom.Text = "";
            lblProductoTo.Text = "";
            nudCoilsToChange.Value = 1;
            lblBaseFilm.Text = "";
            lblMetalFilm.Text = "";
            txtNotes.Clear();
            cmbMachine.Text = "";
            cmbMachine.SelectedText = "";
            cmbMachine.SelectedItem = -1;
            cmbMachine.SelectedIndex = -1;
            txtopticDensity.Clear();
            tbcChangeSalesOrder.TabPages.Remove(tbpCuttingPlan);
            lstDetails.Clear();
        }

        private void PopulateSumary()
        {
            List<clsProductionOrderMetal> lstMetalizeOrder = new List<clsProductionOrderMetal>();
            lstMetalizeOrder = clsProductionOrderMetal.getActiveList();
            dgvSummary.Rows.Clear();
            for (int i = 0; i < lstMetalizeOrder.Count; i++)
            {
                dgvSummary.Rows.Add();
                dgvSummary.Rows[i].Cells[clmsummarycodsec.Index].Value = lstMetalizeOrder[i].codsec;
                dgvSummary.Rows[i].Cells[clmfkFilmProductionPlan.Index].Value = lstMetalizeOrder[i].fkFilmProductionOrderMetal;
                dgvSummary.Rows[i].Cells[cclmsummarystatus.Index].Value = (lstMetalizeOrder[i].fkStatus == 46) ? global::BPS.Properties.Resources.control_stop : (lstMetalizeOrder[i].fkStatus == 1066) ? global::BPS.Properties.Resources.control_play : global::BPS.Properties.Resources.control_pause;
                dgvSummary.Rows[i].Cells[clmsummarylotnumber.Index].Value = lstMetalizeOrder[i].lotNumber;
                dgvSummary.Rows[i].Cells[clmsummaryproductfrom.Index].Value = lstMetalizeOrder[i].BoppFrom;
                dgvSummary.Rows[i].Cells[clmsummaryproductto.Index].Value = lstMetalizeOrder[i].BoppTo;
                dgvSummary.Rows[i].Cells[clmsummarycustomer.Index].Value = lstMetalizeOrder[i].Customer;
                dgvSummary.Rows[i].Cells[clmsummarycoil.Index].Value = lstMetalizeOrder[i].Coil;
                dgvSummary.Rows[i].Cells[clmsummaryquality.Index].Value = lstMetalizeOrder[i].quantity;
                dgvSummary.Rows[i].Cells[clmsummaryinitdate.Index].Value = lstMetalizeOrder[i].EstimateInitDate.ToShortDateString();
                dgvSummary.Rows[i].Cells[clmsummarycancel.Index].Value = global::BPS.Properties.Resources.cross;
                dgvSummary.Rows[i].Cells[clmsummaryedit.Index].Value = global::BPS.Properties.Resources.pencil;
            }
        }

        private bool validateFrom()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtopticDensity, ref lblopticDensity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbMachine, ref lblMachine, "selected")) isValid = false;
            if (lstDetails.Count == 0) isValid = false;
            return isValid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está realmente seguro que desea cancelar la orden de metalizado?", "Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                this.Close();
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudExtraPercentage_ValueChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void txtInnerProduction_TextChanged(object sender, EventArgs e)
        {
            calculateTotals();
        }

        private void lblTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtInnerProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvSummary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsummarycancel.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea anular la orden de metalizado?", "Ordenes Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (clsProductionOrderMetal.toCheckMainCoilMetal(Convert.ToInt32(dgvSummary.Rows[e.RowIndex].Cells[clmfkFilmProductionPlan.Index].Value)) > 0)
                        MessageBox.Show("No se puede anular la orden de metalizado ya que existen bobinas madres asociadas a esta orden", "Ordenes Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    else
                    {
                        clsProductionOrderMetal.toCrossOrder(Convert.ToInt32(dgvSummary.Rows[e.RowIndex].Cells[clmsummarycodsec.Index].Value));
                        PopulateSumary();
                    }
                }
            }
            else if (e.ColumnIndex == clmsummaryedit.Index)
            {
                if (MessageBox.Show("Esta realmente seguro que desea editar la orden seleccionada?", "Ordenes Metalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    frmChangeMetalLotNumber winLot = new frmChangeMetalLotNumber(Convert.ToInt32(dgvSummary.Rows[e.RowIndex].Cells[clmsummarycodsec.Index].Value));
                    winLot.StartPosition = FormStartPosition.CenterScreen;
                    winLot.ShowDialog(this.MdiParent);
                    PopulateSumary();
                }
            }
        }

        private void dgvSalesOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsalesin.Index)
            {
                lstDetails.Clear();
                lstWidthTo.Clear();
                widthTo = "";

                for (int i = 0; i < dgvSalesOrder.Rows.Count; i++)
                {
                    if (dgvSalesOrder.Rows[i].Cells[clmsalesin.Index].Value != null)
                    {
                        lstDetails.Add(Convert.ToInt32(dgvSalesOrder.Rows[i].Cells[clmsalescodsecdetail.Index].Value));
                        lstWidthTo.Add(Convert.ToInt32(dgvSalesOrder.Rows[i].Cells[clmsaleswidth.Index].Value));
                        calculateTotals();
                    }
                }
            }
        }

        private void dgvSalesOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmsalesproduct.Index)
            {
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this);
                winProductList.ShowDialog(this);
                if (selectedProductCodsec > 0)
                {
                    objSelectedProduct.load(selectedProductCodsec);
                    dgvSalesOrder.CurrentRow.Cells[clmsalescodsec.Index].Value = 0;
                    dgvSalesOrder.CurrentRow.Cells[clmsalesfkproduct.Index].Value = objSelectedProduct.codsec;
                    dgvSalesOrder.CurrentRow.Cells[clmsalescodsecdetail.Index].Value = 0;
                    dgvSalesOrder.CurrentRow.Cells[clmsalesproduct.Index].Value = objSelectedProduct.code.ToString();
                    dgvSalesOrder.CurrentRow.Cells[clmsalescustomer.Index].Value = "STOCK";
                    dgvSalesOrder.CurrentRow.Cells[clmsalesorder.Index].Value = "-------";
                    dgvSalesOrder.CurrentRow.Cells[clmsalesweigth.Index].Value = 100;
                    dgvSalesOrder.CurrentRow.Cells[clmsalesdate.Index].Value = DateTime.Now.ToShortDateString();
                    dgvSalesOrder.CurrentRow.Cells[clmsalescuttingweigth.Index].Value = 0;
                    dgvSalesOrder.CurrentRow.Cells[clmsalesisinternational.Index].Value = global::BPS.Properties.Resources.table;
                    dgvSalesOrder.CurrentRow.Cells[clmsalesin.Index].Value = null;
                    dgvSalesOrder.CurrentRow.Cells[clmsaleswidth.Index].Value = objSelectedProduct.width;
                    dgvSalesOrder.CurrentRow.Cells[clmsalesin.Index].Value = true;
                }
                calculateTotals();
            }
        }

        private void btnSaveMaquile_Click(object sender, EventArgs e)
        {

        }
    }
}
