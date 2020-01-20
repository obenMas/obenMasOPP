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
    public partial class frmProductList : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        int selectedProductCodsec = 0;
        frmSalesOrderForm prntSalesOrderForm;
        frmInternationalSalesOrderForm prntInternationalSalesOrderForm;
        frmCuttingOrder prntCuttingOrder;
        frmSecundaryCuttingOrder prntSecundaryCuttingOrder;
        frmNewCoil prntNewCoil;
        frmCuttingOrderDetail prntCuttingOrderDetail;
        frmCuttingOrderMultiple prntCuttingOrderMultiple;
        frmCuttingOrderMultipleCast prntCuttingOrderMultipleCast;
        frmSecundaryCuttingOrderMultiple prntSecundaryCuttingOrderMultiple;
        //frmInternationalSalesOrderExportToSiigo prtInternationalSalesOrderExpot;

        frmMetallizedOrderReaload prntMetallizedOrderReload;

        string CALLerForm = "";
        int boppFilmSelected = 0;
        int castFilmSelected = 0;
        int productSelected = 0;

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
            else if (CALLerForm == "CuttingOrderMultipleCast")
            {
                if (castFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkCast";
                    objFilter.operation = "equal";
                    objFilter.value = boppFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);



                    lstCastProducts = clsProduct.getCastProductListByFilter(lstFilter);
                }
                else
                {
                    clsProduct objProduct = new clsProduct(productSelected);

                    List<clsFilter> lstFilter = new List<clsFilter>();

                    lstFilter.Add(new clsFilter());
                    lstFilter[0].field = "prod_fkCast";
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

                    lstCastProducts = clsProduct.getCastProductListByFilter(lstFilter);
                }


            }
            else if (CALLerForm == "secundaryCuttingOrderMultiple")
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
                else if (castFilmSelected > 0)
                {
                    List<clsFilter> lstFilter = new List<clsFilter>();
                    clsFilter objFilter = new clsFilter();
                    objFilter.field = "prod_fkCast";
                    objFilter.operation = "equal";
                    objFilter.value = castFilmSelected.ToString();
                    objFilter.dataType = "int";
                    lstFilter.Add(objFilter);



                    lstCastProducts = clsProduct.getCastProductListByFilter(lstFilter);
                }
                else
                {
                    clsProduct objProduct = new clsProduct(productSelected);

                    if (objProduct.fkBopp > 0)
                    {
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
                    else
                    {
                        List<clsFilter> lstFilter = new List<clsFilter>();

                        lstFilter.Add(new clsFilter());
                        lstFilter[0].field = "prod_fkCast";
                        lstFilter[0].operation = "equal";
                        lstFilter[0].value = objProduct.fkCast.ToString();
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

                        lstCastProducts = clsProduct.getCastProductListByFilter(lstFilter);
                    }
                }
            }
            else if (CALLerForm == "SecundaryCuttingOrder")
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
                case "SalesOrderForm":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Coating":
                            selectedProductCodsec = Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value);
                            prntSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Termoformado":
                            selectedProductCodsec = Convert.ToInt32(dgvThermoformedList.SelectedRows[0].Cells["clmThermProductCodsec"].Value);
                            prntSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "InternationalSalesOrderForm":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntInternationalSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntInternationalSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Coating":
                            selectedProductCodsec = Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value);
                            prntInternationalSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntInternationalSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "CuttingOrder":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntCuttingOrder.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntInternationalSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Coating":
                            selectedProductCodsec = Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value);
                            prntInternationalSalesOrderForm.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntCuttingOrder.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "CuttingOrderMultiple":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "CuttingOrderMultipleCast":
                    switch (productType)
                    {
                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntCuttingOrderMultipleCast.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntCuttingOrderMultipleCast.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "secundaryCuttingOrderMultiple":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntSecundaryCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntSecundaryCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntSecundaryCuttingOrderMultiple.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;

                case "internationalSalesOrderExportToSiigo":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            //prtInternationalSalesOrderExpot.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            //prtInternationalSalesOrderExpot.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            //prtInternationalSalesOrderExpot.selectedProductCodsec = selectedProductCodsec;
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

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntSecundaryCuttingOrder.selectedProductCodsec = selectedProductCodsec;
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

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntCuttingOrderDetail.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "NewCoil":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntNewCoil.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntNewCoil.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Coating":
                            selectedProductCodsec = Convert.ToInt32(dgvCoatingFilm.SelectedRows[0].Cells["clmCoatingCodsec"].Value);
                            prntNewCoil.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntNewCoil.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                case "MetallizedOrderReaload":
                    switch (productType)
                    {
                        case "Bopp":
                            selectedProductCodsec = Convert.ToInt32(dgvBoppFilm.SelectedRows[0].Cells["clmBoppCodsec"].Value);
                            prntMetallizedOrderReload.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                        case "Cast":
                            selectedProductCodsec = Convert.ToInt32(dgvCastFilm.SelectedRows[0].Cells["clmCastCodsec"].Value);
                            prntMetallizedOrderReload.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;

                        case "Nylon":
                            selectedProductCodsec = Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value);
                            prntMetallizedOrderReload.selectedProductCodsec = selectedProductCodsec;
                            this.Close();
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        public frmProductList()
        {
            InitializeComponent();
            btnAcceptBopp.Hide();
            btnAcceptCast.Hide();
            btnAcceptCoating.Hide();
            txtBoppCode.Focus();
        }

        public frmProductList(frmMetallizedOrderReaload winMetallizedOrderReload)
        {
            InitializeComponent();
            this.prntMetallizedOrderReload = winMetallizedOrderReload;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "MetallizedOrderReaload";
            txtBoppCode.Focus();

        }

        public frmProductList(frmSalesOrderForm winSalesOrderForm)
        {
            InitializeComponent();
            this.prntSalesOrderForm = winSalesOrderForm;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "SalesOrderForm";
            txtBoppCode.Focus();

        }

        public frmProductList(frmInternationalSalesOrderForm winInternationalSalesOrderForm)
        {
            InitializeComponent();
            this.prntInternationalSalesOrderForm = winInternationalSalesOrderForm;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "InternationalSalesOrderForm";
            txtBoppCode.Focus();
        }

        public frmProductList(frmCuttingOrder winCuttingOrder, int boppFilmCodsec)
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
            txtBoppCode.Focus();

        }
        public frmProductList(frmCuttingOrder winCuttingOrder, int productSelected, bool forProduct)
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
            txtBoppCode.Focus();

        }
        public frmProductList(BPS.Lite.frmCuttingOrderDetail winCuttingOrderDetail, int productSelected, bool forProduct)
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
            txtBoppCode.Focus();

        }
        public frmProductList(frmSecundaryCuttingOrder winSecundaryCuttingOrder, int boppFilmCodsec)
        {
            InitializeComponent();
            this.prntSecundaryCuttingOrder = winSecundaryCuttingOrder;
            this.boppFilmSelected = boppFilmCodsec;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "SecundaryCuttingOrder";
            txtBoppCode.Focus();

        }
        public frmProductList(frmNewCoil winNewCoil)
        {
            InitializeComponent();
            this.prntNewCoil = winNewCoil;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "NewCoil";
            txtBoppCode.Focus();

        }
        public frmProductList(frmCuttingOrderMultiple winCuttingOrderMultiple, int boppFilmCodsec, bool forProduct)
        {
            InitializeComponent();
            this.prntCuttingOrderMultiple = winCuttingOrderMultiple;
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
        public frmProductList(frmCuttingOrderMultiple winCuttingOrderMultiple, int productSelected)
        {
            InitializeComponent();
            this.prntCuttingOrderMultiple = winCuttingOrderMultiple;
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
        public frmProductList(frmCuttingOrderMultipleCast winCuttingOrderMultipleCast, int productSelected)
        {
            InitializeComponent();
            this.prntCuttingOrderMultipleCast = winCuttingOrderMultipleCast;
            this.productSelected = productSelected;

            btnViewDetailBopp.Hide();
            btnEditBopp.Hide();

            btnEditCast.Hide();
            btnViewDetailCast.Hide();

            btnViewDetailCoating.Hide();
            btnEditCoating.Hide();

            CALLerForm = "CuttingOrderMultipleCast";
            txtCastCode.Focus();
        }

        public frmProductList(frmSecundaryCuttingOrderMultiple winSecundaryCuttingOrderMultiple, int filmCodsec, string filmType, bool isForStock)
        {
            InitializeComponent();
            this.prntSecundaryCuttingOrderMultiple = winSecundaryCuttingOrderMultiple;
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

        //public frmProductList(frmInternationalSalesOrderExportToSiigo winInternationalSalesOrderExportSiigo)
        //{
        //    InitializeComponent();
        //    this.prtInternationalSalesOrderExpot = winInternationalSalesOrderExportSiigo;

        //    btnViewDetailBopp.Hide();
        //    btnEditBopp.Hide();
        //    btnEditCast.Hide();
        //    btnViewDetailCast.Hide();
        //    btnViewDetailCoating.Hide();
        //    btnEditCoating.Hide();
        //    CALLerForm = "internationalSalesOrderExportToSiigo";
        //    txtBoppCode.Focus();
        //}
        private void frmProductList_Load(object sender, EventArgs e)
        {
            loadLists();
            txtBoppCode.Focus();
            txtBoppCode.Select();
            tbcLists.TabPages.Remove(tbpCoatingList);
            tbcLists.TabPages.Remove(tabPage1);
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
            else if (CALLerForm == "SecundaryCuttingOrder")
            {
                clsFilter objFilter = new clsFilter();
                objFilter.field = "prod_fkBopp";
                objFilter.operation = "equal";
                objFilter.value = boppFilmSelected.ToString();
                objFilter.dataType = "int";
                lstFilter.Add(objFilter);
            }
            else if (CALLerForm == "secundaryCuttingOrderMultiple")
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
            else if (CALLerForm == "CuttingOrderDetail")
            {
                if (boppFilmSelected > 0)
                {
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
                    lstFilter[lstFilter.Count - 1].field = "prod_name";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtBoppName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

            }
            lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
            //else
            //    lstBoppProducts = clsProduct.getBoppProductList();

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
                    lstFilter[lstFilter.Count - 1].field = "prod_name";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtBoppName.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstBoppProducts = clsProduct.getBoppProductListByFilter(lstFilter);
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstCastProducts = new List<clsProduct>();

            if (txtCastCode.Text != "" || txtCastName.Text != "")
            {
                if (CALLerForm == "secundaryCuttingOrderMultiple")
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
                    else
                    {
                        clsFilter objFilter = new clsFilter();
                        objFilter.field = "prod_fkCast";
                        objFilter.operation = "equal";
                        objFilter.value = castFilmSelected.ToString();
                        objFilter.dataType = "int";
                        lstFilter.Add(objFilter);
                    }
                }
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
                txtBoppCode.Focus();
            else if (tbcLists.SelectedIndex == 1)
                txtCastCode.Focus();
            else if (tbcLists.SelectedIndex == 3)
                txtCoatingCode.Focus();
            else if (tbcLists.SelectedIndex == 2)
                txtNylonCode.Focus();
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

        private void grpbFiltersCoating_Enter(object sender, EventArgs e)
        {

        }

        private void txtNylonCode_TextChanged(object sender, EventArgs e)
        {
            List<clsFilter> lstFilter = new List<clsFilter>();
            List<clsProduct> lstCastProducts = new List<clsProduct>();

            if (txtNylonCode.Text != "")
            {
                if (CALLerForm == "secundaryCuttingOrderMultiple")
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
                    else
                    {
                        clsFilter objFilter = new clsFilter();
                        objFilter.field = "prod_fkCast";
                        objFilter.operation = "equal";
                        objFilter.value = castFilmSelected.ToString();
                        objFilter.dataType = "int";
                        lstFilter.Add(objFilter);
                    }
                }
                if (txtNylonCode.Text != "")
                {
                    lstFilter.Add(new clsFilter());
                    lstFilter[lstFilter.Count - 1].field = "prod_code";
                    lstFilter[lstFilter.Count - 1].operation = "startsWith";
                    lstFilter[lstFilter.Count - 1].value = txtNylonCode.Text;
                    lstFilter[lstFilter.Count - 1].dataType = "varchar";
                }

                lstCastProducts = clsProduct.getCastProductListByFilter(lstFilter);
            }
            else
                lstCastProducts = clsProduct.getCastProductList();

            dgvNylonFilm.Rows.Clear();
            for (int i = 0; i < lstCastProducts.Count; i++)
            {
                if (lstCastProducts[i].castisNylon)
                {
                    dgvNylonFilm.Rows.Add();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonCodsec"].Value = lstCastProducts[i].codsec.ToString();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonCode"].Value = lstCastProducts[i].code.ToString();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonName"].Value = lstCastProducts[i].name.ToString();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonFilm"].Value = lstCastProducts[i].castCode.ToString();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonWidth"].Value = lstCastProducts[i].width.ToString();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonDiameter"].Value = lstCastProducts[i].DiameterAbbreviation.ToString();
                    dgvNylonFilm.Rows[dgvNylonFilm.Rows.Count - 1].Cells["clmNylonCore"].Value = lstCastProducts[i].CoreName.ToString();
                }
            }
        }

        private void dgvNylonFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNylonFilm.SelectedRows.Count > 0)
            {
                if (this.Modal == false)
                {
                    frmProductsForm winProductForm = new frmProductsForm(Convert.ToInt32(dgvNylonFilm.SelectedRows[0].Cells["clmNylonCodsec"].Value));
                    winProductForm.MdiParent = this.MdiParent;
                    winProductForm.Show();
                }
                else
                    returnProduct("Nylon");
            }
        }

        private void btnAddNylon_Click(object sender, EventArgs e)
        {
            if (this.Modal == false)
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.MdiParent = this.MdiParent;
                winProductForm.selectFilmType("Nylon");
                winProductForm.Show();
            }
            else
            {
                frmProductsForm winProductForm = new frmProductsForm();
                winProductForm.selectFilmType("Nylon");
                winProductForm.ShowDialog(this);
                loadLists();
            }
        }

        private void btnOkNylon_Click(object sender, EventArgs e)
        {
            returnProduct("Nylon");
        }
    }
}