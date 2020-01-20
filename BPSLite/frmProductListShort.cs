using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmProductListShort : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        int selectedProductCodsec = 0;
        frmCuttingOrder prntCuttingOrder;
        frmSecundaryCuttingOrder prntSecundaryCuttingOrder;
        frmCuttingOrderDetail prntCuttingOrderDetail;
        frmCuttingOrderMultiple prnCuttingOrderMultiple;
        frmSecundaryCuttingOrderMultiple prnSecundaryCuttingOrderMultiple;
        string CALLerForm = "";
        int boppFilmSelected = 0;
        int castFilmSelected = 0;
        int productSelected = 0;
        bool validateCuttingOrder = false;

        public void loadLists()
        {
            List<clsProduct> lstBoppProducts = new List<clsProduct>();
            List<clsProduct> lstCastProducts = new List<clsProduct>();
            if (CALLerForm == "CuttingOrder")
            {
                if (boppFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    validateCuttingOrder = true;
                }
                else
                {
                    clsProduct objProduct = new clsProduct(productSelected);
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    lstFilter.Add(new clsFilter());
                    lstFilter[0].field = "prod_fkBopp";
                    lstFilter[0].operation = "equal";
                    lstFilter[0].value = objProduct.fkBopp.ToString();
                    lstFilter[0].dataType = "int";
                    lstFilter.Add(new clsFilter());
                    lstFilter[1].field = "prod_fkDiameter";
                    lstFilter[1].operation = "equal";
                    lstFilter[1].value = objProduct.fkDiameter.ToString();
                    lstFilter[1].dataType = "int";
                    lstFilter.Add(new clsFilter());
                    lstFilter[2].field = "prod_width";
                    lstFilter[2].operation = "equal";
                    lstFilter[2].value = objProduct.width.ToString();
                    lstFilter[2].dataType = "int";
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    validateCuttingOrder = true;
                }
            }
            else if (CALLerForm == "CuttingOrderMultiple")
            {
                if (boppFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    validateCuttingOrder = true;
                }
                else
                {
                    clsProduct objProduct = new clsProduct(productSelected);
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    lstFilter.Add(new clsFilter());
                    lstFilter[0].field = "prod_fkBopp";
                    lstFilter[0].operation = "equal";
                    lstFilter[0].value = objProduct.fkBopp.ToString();
                    lstFilter[0].dataType = "int";
                    lstFilter.Add(new clsFilter());
                    lstFilter[1].field = "prod_fkDiameter";
                    lstFilter[1].operation = "equal";
                    lstFilter[1].value = objProduct.fkDiameter.ToString();
                    lstFilter[1].dataType = "int";
                    lstFilter.Add(new clsFilter());
                    lstFilter[2].field = "prod_width";
                    lstFilter[2].operation = "equal";
                    lstFilter[2].value = objProduct.width.ToString();
                    lstFilter[2].dataType = "int";
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    validateCuttingOrder = true;
                }
            }
            else if (CALLerForm == "SecundaryCuttingOrder")
            {
                if (castFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkCast";
                    objFilter.operation = "equal";
                    objFilter.value = castFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstCastProducts = clsProduct.getBoppProductListByFilterCast(lstFilter);
                    validateCuttingOrder = false;
                }
                else if (boppFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    validateCuttingOrder = true;
                }
            }
            else if (CALLerForm == "SecundaryCuttingOrderMultiple")
            {
                if (castFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkCast";
                    objFilter.operation = "equal";
                    objFilter.value = castFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstCastProducts = clsProduct.getBoppProductListByFilterCast(lstFilter);
                    validateCuttingOrder = false;
                }
                else if (boppFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    validateCuttingOrder = true;
                }
            }
            else if (CALLerForm == "CuttingOrderDetail")
            {
                if (boppFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                }
                else
                {
                    clsProduct objProduct = new clsProduct(productSelected);
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    lstFilter.Add(new clsFilter());
                    lstFilter[0].field = "prod_fkBopp";
                    lstFilter[0].operation = "equal";
                    lstFilter[0].value = objProduct.fkBopp.ToString();
                    lstFilter[0].dataType = "int";
                    lstFilter.Add(new clsFilter());
                    lstFilter[1].field = "prod_fkDiameter";
                    lstFilter[1].operation = "equal";
                    lstFilter[1].value = objProduct.fkDiameter.ToString();
                    lstFilter[1].dataType = "int";
                    lstFilter.Add(new clsFilter());
                    lstFilter[2].field = "prod_width";
                    lstFilter[2].operation = "equal";
                    lstFilter[2].value = objProduct.width.ToString();
                    lstFilter[2].dataType = "int";
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                }
            }
            else
                lstBoppProducts = clsProduct.getBoppProductList();

            dgvBoppFilm.Rows.Clear();

            for (int i = 0; i < lstBoppProducts.Count; i++)
            {
                dgvBoppFilm.Rows.Add();
                dgvBoppFilm.Rows[i].Cells["clmBoppCodsec"].Value = lstBoppProducts[i].codsec.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppCode"].Value = lstBoppProducts[i].code.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppName"].Value = lstBoppProducts[i].name.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppFilm"].Value = lstBoppProducts[i].boppCode.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppWidth"].Value = lstBoppProducts[i].width.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppDiameter"].Value = lstBoppProducts[i].DiameterAbbreviation.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppCore"].Value = lstBoppProducts[i].CoreName.ToString();
            }

            if (!validateCuttingOrder)
            {
                dgvCastFilm.Rows.Clear();

                for (int i = 0; i < lstCastProducts.Count; i++)
                {
                    dgvCastFilm.Rows.Add();
                    dgvCastFilm.Rows[i].Cells["clmCastCodsec"].Value = lstCastProducts[i].codsec.ToString();
                    dgvCastFilm.Rows[i].Cells["clmCastCode"].Value = lstCastProducts[i].code.ToString();
                    dgvCastFilm.Rows[i].Cells["clmCastName"].Value = lstCastProducts[i].name.ToString();
                    dgvCastFilm.Rows[i].Cells["clmCastFilm"].Value = lstCastProducts[i].castCode.ToString();
                    dgvCastFilm.Rows[i].Cells["clmCastWidth"].Value = lstCastProducts[i].width.ToString();
                    dgvCastFilm.Rows[i].Cells["clmCastDiameter"].Value = lstCastProducts[i].DiameterAbbreviation.ToString();
                    dgvCastFilm.Rows[i].Cells["clmCastCore"].Value = lstCastProducts[i].CoreName.ToString();
                } 
            }

            List<clsProduct> lstCoatingProducts = clsProduct.getCoatProductList();
            dgvCoatingFilm.Rows.Clear();

            for (int i = 0; i < lstCoatingProducts.Count; i++)
            {
                dgvCoatingFilm.Rows.Add();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCodsec"].Value = lstCoatingProducts[i].codsec.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCode"].Value = lstCoatingProducts[i].code.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingName"].Value = lstCoatingProducts[i].name.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingFilm"].Value = lstCoatingProducts[i].coatingCode.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingWidth"].Value = lstCoatingProducts[i].width.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingDiameter"].Value = lstCoatingProducts[i].DiameterAbbreviation.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCore"].Value = lstCoatingProducts[i].CoreName.ToString();
            }

            List<clsProduct> lstThermoformingProducts = clsProduct.getThermoformedProductList();
            dgvThermoformedList.Rows.Clear();

            for (int i = 0; i < lstThermoformingProducts.Count; i++)
            {
                dgvThermoformedList.Rows.Add();
                dgvThermoformedList.Rows[i].Cells["clmThermProductCodsec"].Value = lstThermoformingProducts[i].codsec.ToString();
                dgvThermoformedList.Rows[i].Cells["clmThermProductCode"].Value = lstThermoformingProducts[i].code.ToString();
                dgvThermoformedList.Rows[i].Cells["clmThermProductName"].Value = lstThermoformingProducts[i].name.ToString();
                dgvThermoformedList.Rows[i].Cells["clmThermProductColor"].Value = lstThermoformingProducts[i].colorName.ToString();
                dgvThermoformedList.Rows[i].Cells["clmThermProductOunce"].Value = lstThermoformingProducts[i].ounceValue.ToString();
                dgvThermoformedList.Rows[i].Cells["clmThermProductGramsPerUnit"].Value = lstThermoformingProducts[i].gramsperunit.ToString();
                dgvThermoformedList.Rows[i].Cells["clmThermProductUnitsPerpackage"].Value = lstThermoformingProducts[i].value.ToString();
                
            }
        }
        public void returnProduct(string productType)
        {
            switch (CALLerForm)
            {
                case "CuttingOrder":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntCuttingOrder.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "SecundaryCuttingOrder":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntSecundaryCuttingOrder.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntSecundaryCuttingOrder.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "CuttingOrderMultiple":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prnCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "secundaryCuttingOrderMultiple":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prnSecundaryCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prnSecundaryCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "CuttingOrderDetail":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntCuttingOrderDetail.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntCuttingOrderDetail.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Coating":
                            selectedProductCodsec = Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value);
                            prntCuttingOrderDetail.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public frmProductListShort()
        {
            InitializeComponent();
            btnAcceptBopp.Hide();
            btnAcceptCast.Hide();
            btnAcceptCoating.Hide();
            txtBoppName.Focus();
        }
        public frmProductListShort(frmCuttingOrder winCuttingOrder, int boppFilmCodsec)
        {
            InitializeComponent();
            this.prntCuttingOrder = winCuttingOrder;
            this.boppFilmSelected = boppFilmCodsec;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "CuttingOrder";
            txtBoppName.Focus();

        }
        public frmProductListShort(frmCuttingOrder winCuttingOrder, int productSelected, bool forProduct)
        {
            InitializeComponent();
            this.prntCuttingOrder = winCuttingOrder;
            this.productSelected = productSelected;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "CuttingOrder";
            txtBoppName.Focus();

        }
        public frmProductListShort(frmCuttingOrderDetail winCuttingOrderDetail, int productSelected, bool forProduct)
        {
            InitializeComponent();
            this.prntCuttingOrderDetail = winCuttingOrderDetail;
            this.productSelected = productSelected;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "CuttingOrderDetail";
            txtBoppName.Focus();

        }
        public frmProductListShort(frmSecundaryCuttingOrder winSecundaryCuttingOrder, int boppFilmCodsec,bool type)
        {
            InitializeComponent();
            this.prntSecundaryCuttingOrder = winSecundaryCuttingOrder;
            if (type)
                this.boppFilmSelected = boppFilmCodsec;
            else
                this.castFilmSelected = boppFilmCodsec;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "SecundaryCuttingOrder";
            txtBoppName.Focus();

        }
        public frmProductListShort(frmCuttingOrderMultiple winCuttingOrderMultiple, int boppFilmCodsec, bool forProduct)
        {
            InitializeComponent();
            this.prnCuttingOrderMultiple = winCuttingOrderMultiple;
            this.boppFilmSelected = boppFilmCodsec;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "CuttingOrderMultiple";
            txtBoppCode.Focus();
        }
        public frmProductListShort(frmCuttingOrderMultiple winCuttingOrderMultiple, int productSelected)
        {
            InitializeComponent();
            this.prnCuttingOrderMultiple = winCuttingOrderMultiple;
            this.productSelected = productSelected;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "CuttingOrderMultiple";
            txtBoppCode.Focus();
        }
        public frmProductListShort(frmSecundaryCuttingOrderMultiple winSecundaryCuttingOrderMultiple, int filmCodsec, string filmType, bool isForStock)
        {
            InitializeComponent();
            this.prnSecundaryCuttingOrderMultiple = winSecundaryCuttingOrderMultiple;
            if (filmType == "Bopp")
                this.boppFilmSelected = filmCodsec;
            else
                this.castFilmSelected = filmCodsec;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "secundaryCuttingOrderMultiple";
            txtCastCode.Focus();
        }
        private void btnAddBopp_Click(object sender, EventArgs e)
        {
            if (this.Modal == false)
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.selectFilmType("Bopp");
                winProductForm.Show();
            }
            else
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.selectFilmType("Bopp");
                winProductForm.ShowDialog(this);
                loadLists();
            }
        }

        private void btnEditBopp_Click(object sender, EventArgs e)
        {
            if (dgvBoppFilm.SelectedRows.Count > 0)
            {
                frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value));
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.Show();
            }
        }

        private void btnCloseBopp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void brnAddCast_Click(object sender, EventArgs e)
        {
            if (this.Modal == false)
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.selectFilmType("Cast");
                winProductForm.Show();
            }
            else
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.selectFilmType("Cast");
                winProductForm.ShowDialog(this);
                loadLists();
            }
        }

        private void btmEditCast_Click(object sender, EventArgs e)
        {
            if (dgvCastFilm.SelectedRows.Count > 0)
            {
                frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value));
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.Show();
            }
        }

        private void btnCloseCast_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void brnAddCoating_Click(object sender, EventArgs e)
        {
            if (this.Modal == false)
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.selectFilmType("Coating");
                winProductForm.Show();
            }
            else
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.selectFilmType("Coating");
                winProductForm.ShowDialog(this);
                loadLists();
            }
        }

        private void btnEditCoating_Click(object sender, EventArgs e)
        {
            if (dgvCoatingFilm.SelectedRows.Count > 0)
            {
                frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value));
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.Show();
            }
        }

        private void btnCloseCoating_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoppCode_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstBoppProducts = new List<clsProduct>();

            if (CALLerForm == "CuttingOrder")
            {
                if (boppFilmSelected > 0)
                {
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);

                }
            }
            else if (CALLerForm == "SecundaryCuttingOrder")
            {
                clsFilter objFilter = new clsFilter();
                objFilter.field = "prod_fkBopp";
                objFilter.operation = "equal";
                objFilter.value = boppFilmSelected.ToString();
                objFilter.dataType = "int";
                lstFilter.Add(objFilter);
            }
            else if (CALLerForm == "CuttingOrderMultiple")
            {
                if (boppFilmSelected > 0)
                {
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);

                }
            }
            else if (CALLerForm == "SecundaryCuttingOrderMultiple")
            {
                clsFilter objFilter = new clsFilter();
                objFilter.field = "prod_fkBopp";
                objFilter.operation = "equal";
                objFilter.value = boppFilmSelected.ToString();
                objFilter.dataType = "int";
                lstFilter.Add(objFilter);
            }

            if (txtBoppCode.Text != "" || txtBoppName.Text != "")
            {

                if (txtBoppCode.Text != "")
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtBoppCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (txtBoppName.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_width";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtBoppName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
            }
            else
                if (lstFilter.Count > 0)
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                else
                    lstBoppProducts = clsProduct.getBoppProductList();

            dgvBoppFilm.Rows.Clear();
            for (int i = 0; i < lstBoppProducts.Count; i++)
            {
                dgvBoppFilm.Rows.Add();
                dgvBoppFilm.Rows[i].Cells["clmBoppCodsec"].Value = lstBoppProducts[i].codsec.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppCode"].Value = lstBoppProducts[i].code.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppName"].Value = lstBoppProducts[i].name.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppFilm"].Value = lstBoppProducts[i].boppCode;
                dgvBoppFilm.Rows[i].Cells["clmBoppWidth"].Value = lstBoppProducts[i].width.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppDiameter"].Value = lstBoppProducts[i].DiameterAbbreviation.ToString();
                dgvBoppFilm.Rows[i].Cells["clmBoppCore"].Value = lstBoppProducts[i].CoreName.ToString();
            }
        }

        private void txtBoppName_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstBoppProducts = new List<clsProduct>();

            if (txtBoppCode.Text == string.Empty)
            {
                if (txtBoppName.Text == string.Empty)
                {
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkBopp";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);
                    lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                    dgvBoppFilm.Rows.Clear();
                    for (int i = 0; i < lstBoppProducts.Count; i++)
                    {
                        dgvBoppFilm.Rows.Add();
                        dgvBoppFilm.Rows[i].Cells["clmBoppCodsec"].Value = lstBoppProducts[i].codsec.ToString();
                        dgvBoppFilm.Rows[i].Cells["clmBoppCode"].Value = lstBoppProducts[i].code.ToString();
                        dgvBoppFilm.Rows[i].Cells["clmBoppName"].Value = lstBoppProducts[i].name.ToString();
                        dgvBoppFilm.Rows[i].Cells["clmBoppFilm"].Value = lstBoppProducts[i].boppCode;
                        dgvBoppFilm.Rows[i].Cells["clmBoppWidth"].Value = lstBoppProducts[i].width.ToString();
                        dgvBoppFilm.Rows[i].Cells["clmBoppDiameter"].Value = lstBoppProducts[i].DiameterAbbreviation.ToString();
                        dgvBoppFilm.Rows[i].Cells["clmBoppCore"].Value = lstBoppProducts[i].CoreName.ToString();
                    }
                }
                else if (txtBoppCode.Text != string.Empty)
                {
                    if (txtBoppName.Text == string.Empty)
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count -1].field = "prod_code";
                        lstFilter[lstFilter.Count - 1].operation = "startsWith";
                        lstFilter[lstFilter.Count - 1].value = txtBoppCode.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";

                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_fkBopp";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = boppFilmSelected.ToString();
                        lstFilter[lstFilter.Count - 1].dataType = "int";

                        lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                        dgvBoppFilm.Rows.Clear();
                        for (int i = 0; i < lstBoppProducts.Count; i++)
                        {
                            dgvBoppFilm.Rows.Add();
                            dgvBoppFilm.Rows[i].Cells["clmBoppCodsec"].Value = lstBoppProducts[i].codsec.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppCode"].Value = lstBoppProducts[i].code.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppName"].Value = lstBoppProducts[i].name.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppFilm"].Value = lstBoppProducts[i].boppCode;
                            dgvBoppFilm.Rows[i].Cells["clmBoppWidth"].Value = lstBoppProducts[i].width.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppDiameter"].Value = lstBoppProducts[i].DiameterAbbreviation.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppCore"].Value = lstBoppProducts[i].CoreName.ToString();
                        }
                    }
                }
                else if (txtBoppCode.Text == string.Empty && txtBoppName.Text != string.Empty)
                {
                    if (clsGlobal.isNumeric(txtBoppName.Text))
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_width";
                        lstFilter[lstFilter.Count - 1].operation = "startsWith";
                        lstFilter[lstFilter.Count - 1].value = txtBoppName.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";

                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_fkBopp";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = boppFilmSelected.ToString();
                        lstFilter[lstFilter.Count - 1].dataType = "int";


                        lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
                        dgvBoppFilm.Rows.Clear();
                        for (int i = 0; i < lstBoppProducts.Count; i++)
                        {
                            dgvBoppFilm.Rows.Add();
                            dgvBoppFilm.Rows[i].Cells["clmBoppCodsec"].Value = lstBoppProducts[i].codsec.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppCode"].Value = lstBoppProducts[i].code.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppName"].Value = lstBoppProducts[i].name.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppFilm"].Value = lstBoppProducts[i].boppCode;
                            dgvBoppFilm.Rows[i].Cells["clmBoppWidth"].Value = lstBoppProducts[i].width.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppDiameter"].Value = lstBoppProducts[i].DiameterAbbreviation.ToString();
                            dgvBoppFilm.Rows[i].Cells["clmBoppCore"].Value = lstBoppProducts[i].CoreName.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor ingresado no es un número", "Listado de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBoppName.Text = string.Empty;
                        txtBoppName.Focus();
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstCastProducts = new List<clsProduct>();

            if (txtCastCode.Text != "" || txtCastName.Text != "")
            {
                if (txtCastCode.Text != "")
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCastCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (txtCastName.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_name";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCastName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstCastProducts = clsProduct.getCastProductListByFilter(lstFilter);
            }
            else
                lstCastProducts = clsProduct.getCastProductList();

            dgvCastFilm.Rows.Clear();
            for (int i = 0; i < lstCastProducts.Count; i++)
            {
                dgvCastFilm.Rows.Add();
                dgvCastFilm.Rows[i].Cells["clmCastCodsec"].Value = lstCastProducts[i].codsec.ToString();
                dgvCastFilm.Rows[i].Cells["clmCastCode"].Value = lstCastProducts[i].code.ToString();
                dgvCastFilm.Rows[i].Cells["clmCastName"].Value = lstCastProducts[i].name.ToString();
                dgvCastFilm.Rows[i].Cells["clmCastFilm"].Value = lstCastProducts[i].castCode.ToString();
                dgvCastFilm.Rows[i].Cells["clmCastWidth"].Value = lstCastProducts[i].width.ToString();
                dgvCastFilm.Rows[i].Cells["clmCastDiameter"].Value = lstCastProducts[i].DiameterAbbreviation.ToString();
                dgvCastFilm.Rows[i].Cells["clmCastCore"].Value = lstCastProducts[i].CoreName.ToString();
            }
        }

        private void txtCastName_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstCastProducts = new List<clsProduct>();

            if (txtCastCode.Text == string.Empty)
            {
                if (txtCastName.Text == string.Empty)
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_fkCast";
                    lstFilter[lstFilter.Count - 1].operation = "equal";
                    lstFilter[lstFilter.Count - 1].value = castFilmSelected.ToString();
                    lstFilter[lstFilter.Count - 1].dataType = "int";
                    lstCastProducts = clsProduct.getBoppProductListByFilterCast(lstFilter);
                    dgvCastFilm.Rows.Clear();
                    for (int i = 0; i < lstCastProducts.Count; i++)
                    {
                        dgvCastFilm.Rows.Add();
                        dgvCastFilm.Rows[i].Cells["clmCastCodsec"].Value = lstCastProducts[i].codsec.ToString();
                        dgvCastFilm.Rows[i].Cells["clmCastCode"].Value = lstCastProducts[i].code.ToString();
                        dgvCastFilm.Rows[i].Cells["clmCastName"].Value = lstCastProducts[i].name.ToString();
                        dgvCastFilm.Rows[i].Cells["clmCastFilm"].Value = lstCastProducts[i].castCode.ToString();
                        dgvCastFilm.Rows[i].Cells["clmCastWidth"].Value = lstCastProducts[i].width.ToString();
                        dgvCastFilm.Rows[i].Cells["clmCastDiameter"].Value = lstCastProducts[i].DiameterAbbreviation.ToString();
                        dgvCastFilm.Rows[i].Cells["clmCastCore"].Value = lstCastProducts[i].CoreName.ToString();
                    }
                }
                else if (txtCastCode.Text != string.Empty)
                {
                    if (txtCastName.Text == string.Empty)
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_code";
                        lstFilter[lstFilter.Count - 1].operation = "startsWith";
                        lstFilter[lstFilter.Count - 1].value = txtBoppCode.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";

                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_fkCast";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = castFilmSelected.ToString();
                        lstFilter[lstFilter.Count - 1].dataType = "int";

                        lstCastProducts = clsProduct.getBoppProductListByFilterCast(lstFilter);
                        dgvCastFilm.Rows.Clear();
                        for (int i = 0; i < lstCastProducts.Count; i++)
                        {
                            dgvCastFilm.Rows.Add();
                            dgvCastFilm.Rows[i].Cells["clmCastCodsec"].Value = lstCastProducts[i].codsec.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastCode"].Value = lstCastProducts[i].code.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastName"].Value = lstCastProducts[i].name.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastFilm"].Value = lstCastProducts[i].castCode.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastWidth"].Value = lstCastProducts[i].width.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastDiameter"].Value = lstCastProducts[i].DiameterAbbreviation.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastCore"].Value = lstCastProducts[i].CoreName.ToString();
                        }
                    }
                }
                else if (txtCastCode.Text == string.Empty && txtCastName.Text != string.Empty)
                {
                    if (clsGlobal.isNumeric(txtCastName.Text))
                    {
                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_width";
                        lstFilter[lstFilter.Count - 1].operation = "startsWith";
                        lstFilter[lstFilter.Count - 1].value = txtCastName.Text;
                        lstFilter[lstFilter.Count - 1].dataType = "varchar";

                        lstFilter.Add(new clsFilter());
                        lstFilter[lstFilter.Count - 1].field = "prod_fkCast";
                        lstFilter[lstFilter.Count - 1].operation = "equal";
                        lstFilter[lstFilter.Count - 1].value = castFilmSelected.ToString();
                        lstFilter[lstFilter.Count - 1].dataType = "int";


                        lstCastProducts = clsProduct.getBoppProductListByFilterCast(lstFilter);
                        dgvCastFilm.Rows.Clear();
                        for (int i = 0; i < lstCastProducts.Count; i++)
                        {
                            dgvCastFilm.Rows.Add();
                            dgvCastFilm.Rows[i].Cells["clmCastCodsec"].Value = lstCastProducts[i].codsec.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastCode"].Value = lstCastProducts[i].code.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastName"].Value = lstCastProducts[i].name.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastFilm"].Value = lstCastProducts[i].castCode.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastWidth"].Value = lstCastProducts[i].width.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastDiameter"].Value = lstCastProducts[i].DiameterAbbreviation.ToString();
                            dgvCastFilm.Rows[i].Cells["clmCastCore"].Value = lstCastProducts[i].CoreName.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor ingresado no es un número", "Listado de Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBoppName.Text = string.Empty;
                        txtBoppName.Focus();
                    }
                }
            }
        }

        private void txtCoatingCode_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstCoatingProducts = new List<clsProduct>();

            if (txtCoatingCode.Text != "" || txtCoatingName.Text != "")
            {
                if (txtCoatingCode.Text != "")
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCoatingCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (txtCoatingName.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_name";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCoatingName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstCoatingProducts = clsProduct.getCoatProductListByFilter(lstFilter);
            }
            else
                lstCoatingProducts = clsProduct.getCoatProductList();

            dgvCoatingFilm.Rows.Clear();
            for (int i = 0; i < lstCoatingProducts.Count; i++)
            {
                dgvCoatingFilm.Rows.Add();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCodsec"].Value = lstCoatingProducts[i].codsec.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCode"].Value = lstCoatingProducts[i].code.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingName"].Value = lstCoatingProducts[i].name.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingFilm"].Value = lstCoatingProducts[i].coatingCode.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingWidth"].Value = lstCoatingProducts[i].width.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingDiameter"].Value = lstCoatingProducts[i].DiameterAbbreviation.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCore"].Value = lstCoatingProducts[i].CoreName.ToString();
            }
        }

        private void txtCoatingName_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstCoatingProducts = new List<clsProduct>();

            if (txtCoatingCode.Text != "" || txtCoatingName.Text != "")
            {
                if (txtCoatingCode.Text != "")
                {

                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCoatingCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }
                if (txtCoatingName.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_name";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtCoatingName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstCoatingProducts = clsProduct.getCoatProductListByFilter(lstFilter);
            }
            else
                lstCoatingProducts = clsProduct.getCoatProductList();

            dgvCoatingFilm.Rows.Clear();
            for (int i = 0; i < lstCoatingProducts.Count; i++)
            {
                dgvCoatingFilm.Rows.Add();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCodsec"].Value = lstCoatingProducts[i].codsec.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCode"].Value = lstCoatingProducts[i].code.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingName"].Value = lstCoatingProducts[i].name.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingFilm"].Value = lstCoatingProducts[i].coatingCode.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingWidth"].Value = lstCoatingProducts[i].width.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingDiameter"].Value = lstCoatingProducts[i].DiameterAbbreviation.ToString();
                dgvCoatingFilm.Rows[i].Cells["clmCoatingCore"].Value = lstCoatingProducts[i].CoreName.ToString();
            }
        }

        private void btnAcceptBopp_Click(object sender, EventArgs e)
        {
            returnProduct("Bopp");
        }

        private void btnAcceptCast_Click(object sender, EventArgs e)
        {
            returnProduct("Cast");
        }

        private void btnAcceptCoating_Click(object sender, EventArgs e)
        {
            returnProduct("Coating");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoppCode.Text = "";
            txtBoppName.Text = "";
            loadLists();
        }

        private void dgvBoppFilm_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvBoppFilm.SelectedRows.Count > 0)
            {
                if (this.Modal == false)
                {
                    frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value));
                    winProductForm.MdiParent = this.MdiParent;
                    winProductForm.Show();
                }
                else
                    returnProduct("Bopp");
            }
        }

        private void dgvCastFilm_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCastFilm.SelectedRows.Count > 0)
            {
                if (this.Modal == false)
                {
                    frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value));
                    winProductForm.MdiParent = this.MdiParent;
                    winProductForm.Show();
                }
                else
                    returnProduct("Cast");
            }
        }

        private void dgvCoatingFilm_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCoatingFilm.SelectedRows.Count > 0)
            {
                if (this.Modal == false)
                {
                    frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value));
                    winProductForm.MdiParent = this.MdiParent;
                    winProductForm.Show();
                }
                else
                    returnProduct("Coating");
            }
        }

        private void btnThermExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvThermoformedList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvThermoformedList.SelectedRows.Count > 0)
            {
                if (this.Modal == false)
                {
                    frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvThermoformedList.SelectedRows[0].Cells["clmThermProductCodsec"].Value));
                    winProductForm.MdiParent = this.MdiParent;
                    winProductForm.Show();
                }
                else
                    returnProduct("Termoformado");
            }
        }

        private void btnViewDetailBopp_Click(object sender, EventArgs e)
        {

        }

        private void btnViewDetailCast_Click(object sender, EventArgs e)
        {

        }

        private void txtBoppCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter)
                dgvBoppFilm.Focus();
        }

        private void txtCastCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter)
                dgvCastFilm.Focus();
        }

        private void txtCoatingCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter)
                dgvCoatingFilm.Focus();
        }

        private void txtThermCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter)
                dgvThermoformedList.Focus();
        }

        private void tbcLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcLists.SelectedIndex == 0)
                txtBoppName.Focus();
            else if (tbcLists.SelectedIndex == 1)
                txtCastName.Focus();
            else if (tbcLists.SelectedIndex == 2)
                txtCoatingCode.Focus();
            else if (tbcLists.SelectedIndex == 3)
                txtThermCode.Focus();
        }

        private void dgvBoppFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (this.Modal == false)
                {
                    frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value));
                    winProductForm.MdiParent = this.MdiParent;
                    winProductForm.Show();
                }
                else
                    returnProduct("Bopp");
            }
        }

        private void frmProductListShort_Load(object sender, EventArgs e)
        {
            loadLists();
            if (castFilmSelected > 0)
            {
                tbcLists.SelectTab(1);
                txtCastName.Focus();
                txtCastName.Select();
            }
            else
            {
                txtBoppName.Focus();
                txtBoppName.Select();
            }
        }
    }
}