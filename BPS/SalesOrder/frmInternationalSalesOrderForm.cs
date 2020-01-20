using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmInternationalSalesOrderForm : Form
    {
        clsProduct objSelectedProduct = new clsProduct();
        public int selectedProductCodsec = 0;
        public int selectedCustomerCodsec = 0;
        public bool isUpdate = false;
        clsEntity objCustomer = new clsEntity();
        clsSalesOrder objSalesOrder = new clsSalesOrder();
        List<clsSalesOrderDetail> lstSalesOrderDetail = new List<clsSalesOrderDetail>();


        public bool validateForm()
        {
            bool isValid = true;
                        
            if (!clsValidation.validateField(ref cmbCommercialCondition, ref lblCommercialCondition, "selected")) isValid = false;
            if (!clsValidation.validateField(ref dgvDetail, ref grpbDetail, "isValid")) isValid = false;
            if (!clsValidation.validateField(ref txtCustomerId, ref lblCustomerId, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtNumber, ref lblNumber, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbIncoterms, ref lblIncoterms, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCurrency, ref lblCurrency, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtExchangeRate, ref lblExchangeRate, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbCityFrom, ref lblCityFrom, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCityTo, ref lblCityTo, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbPackaging, ref lblPackaging, "selected")) isValid = false;
            return isValid;
        }
        public void calculateTotals()
        {
            double quantity = 0;
            double subTotal = 0;

            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                subTotal += Convert.ToDouble((dgvDetail.Rows[i].Cells["clmSubtotal"].Value != null && dgvDetail.Rows[i].Cells["clmSubTotal"].Value.ToString() != "") ? dgvDetail.Rows[i].Cells["clmSubTotal"].Value.ToString() : "0");
                quantity += Convert.ToDouble((dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.RowIndex == i && dgvDetail.CurrentCell.ColumnIndex == 2) ? dgvDetail.CurrentCell.EditedFormattedValue.ToString() : (dgvDetail.Rows[i].Cells["clmQuantity"].Value != null && dgvDetail.Rows[i].Cells["clmQuantity"].Value.ToString() != "") ? dgvDetail.Rows[i].Cells["clmQuantity"].Value.ToString() : "0");
            }
            txtTotal.Text = Math.Round(subTotal, 2).ToString();
            txtTotalWeigth.Text = Math.Round(quantity, 2).ToString();
        }
        private bool canBeEdited(int salesOrderDetail)
        {
            bool flgCanBeEdited = true;

            DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_coilpersalesorderdetail WHERE cpsod_fkOrderDetail = " + salesOrderDetail.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                flgCanBeEdited = false;

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_cuttingorderdetail WHERE cod_fkSalesOrderDetail = " + salesOrderDetail.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                flgCanBeEdited = false;

            DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_palletbysalesorderdetail WHERE pbsod_fkSalesOrderDetail = " + salesOrderDetail.ToString());

            if (DS.Tables[0].Rows.Count > 0)
                flgCanBeEdited = false;


            return flgCanBeEdited;
        }
        public void calculateGreatTotal()
        {
            double greatTotal = 0;
            // TODO : error al poner nueva orden de venta
            greatTotal = Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtFreight.Text) + Convert.ToDouble(txtInsurance.Text) + Convert.ToDouble(txtOtherCharges.Text);
            txtGreatTotal.Text = Math.Round(greatTotal, 2).ToString();
        }
        public void loadCityList(int countryCodsec, ref System.Windows.Forms.ComboBox cmbCity)
        {
            List<clsCity> lstCities = new List<clsCity>();
            cmbCity.Items.Clear();
            lstCities = clsCity.getListByCountry(countryCodsec);
            for (int i = 0; i < lstCities.Count; i++)
                cmbCity.Items.Add(lstCities[i]);

        }
        public frmInternationalSalesOrderForm()
        {
            InitializeComponent();
            isUpdate = false;
        }
        public frmInternationalSalesOrderForm(int salesOrderCodsec)
        {
            InitializeComponent();
            objSalesOrder.load(salesOrderCodsec);
            isUpdate = true;
        }
        private void dgvDetail_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double quantity = 0;
            double price = 0;

            if (dgvDetail.CurrentRow.Index < lstSalesOrderDetail.Count)
            {
                switch (dgvDetail.CurrentCell.ColumnIndex)
                {
                    case 2:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
                                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
                                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
                            else
                                quantity += 0;

                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
                                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
                                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
                            else
                                price += 0;

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
                            calculateTotals();
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        }
                        break;
                    case 5:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
                                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
                                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
                            else
                                quantity += 0;

                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
                                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
                                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
                            else
                                price += 0;

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
                            calculateTotals();
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        }

                        break;
                    case 6:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("El valor debe ser Numérico");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].stock = Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                        }
                        break;
                    case 3:
                        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == true && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
                        {
                            MessageBox.Show("Código de Producto no ingresado");
                            dgvDetail.CancelEdit();
                        }
                        else
                        {
                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
                                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
                                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
                            else
                                quantity += 0;

                            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
                                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
                            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
                                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
                            else
                                price += 0;

                            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
                            calculateTotals();
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
                        }
                        break;
                    default:
                        break;
                }
            }



            //switch (dgvDetail.CurrentCell.ColumnIndex)
            //{
            //    case 2:
            //        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
            //        {
            //            MessageBox.Show("El valor debe ser Numerico");
            //            dgvDetail.CancelEdit();
            //        }
            //        else
            //        {
            //            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmQuantity.Index)
            //                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
            //                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
            //            else
            //                quantity += 0;

            //            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == clmPrice.Index)
            //                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
            //                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
            //            else
            //                price += 0;

            //            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();

            //        }
            //        calculateTotals();
            //        if (dgvDetail.Rows[e.RowIndex].Cells[clmProductCode.Index].Value.ToString() != null || dgvDetail.Rows[e.RowIndex].Cells[clmProductCode.Index].Value.ToString() != "")
            //        {
            //            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
            //            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
            //        }

            //        break;
            //    case 5:
            //        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
            //        {
            //            MessageBox.Show("El valor debe ser Numerico");
            //            dgvDetail.CancelEdit();
            //        }
            //        else
            //        {
            //            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == 2)
            //                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
            //                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
            //            else
            //                quantity += 0;

            //            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == 6)
            //                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
            //                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
            //            else
            //                price += 0;

            //            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
            //        }
            //        calculateTotals();
            //        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
            //        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
            //        break;

            //    case 6:
            //        if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
            //        {
            //            MessageBox.Show("El valor debe ser Numerico");
            //            dgvDetail.CancelEdit();
            //        }
            //        else
            //        {
            //            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == 2)
            //                quantity += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //            else if (dgvDetail.CurrentRow.Cells["clmQuantity"].Value != null && dgvDetail.CurrentRow.Cells["clmQuantity"].Value.ToString() != "")
            //                quantity += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmQuantity"].Value);
            //            else
            //                quantity += 0;

            //            if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == 6)
            //                price += Convert.ToDouble(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //            else if (dgvDetail.CurrentRow.Cells["clmPrice"].Value != null && dgvDetail.CurrentRow.Cells["clmPrice"].Value.ToString() != "")
            //                price += Convert.ToDouble(dgvDetail.CurrentRow.Cells["clmPrice"].Value);
            //            else
            //                price += 0;

            //            dgvDetail.CurrentRow.Cells["clmSubTotal"].Value = Math.Round((quantity * price), 2).ToString();
            //        }
            //        calculateTotals();
            //        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
            //        lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
            //        break;
            //    //case 3:
            //    //    if (clsGlobal.isNumeric(dgvDetail.CurrentCell.EditedFormattedValue.ToString()) == false && dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "")
            //    //    {
            //    //        MessageBox.Show("El valor debe ser Numerico");
            //    //        dgvDetail.CancelEdit();
            //    //    }
            //    //    else
            //    //    {
            //    //         if (dgvDetail.CurrentCell.EditedFormattedValue.ToString() != "" && dgvDetail.CurrentCell.ColumnIndex == 3)
            //    //            pallet = Convert.ToInt32(dgvDetail.CurrentCell.EditedFormattedValue.ToString());
            //    //        else if (dgvDetail.CurrentRow.Cells[clmpalletnumber.Index].Value != null && dgvDetail.CurrentRow.Cells[clmpalletnumber.Index].Value.ToString() != "")
            //    //            pallet = Convert.ToInt32(dgvDetail.CurrentRow.Cells[clmpalletnumber.Index].Value);
            //    //        else
            //    //            pallet = 0;
            //    //    }
            //    //    calculateTotals();
            //    //    lstSalesOrderDetail[dgvDetail.CurrentRow.Index].quantity = quantity;
            //    //    lstSalesOrderDetail[dgvDetail.CurrentRow.Index].price = price;
            //    //    lstSalesOrderDetail[dgvDetail.CurrentRow.Index].palletnumber = pallet;
            //    //    break;
            //    default:
            //        break;
            //}
        }

        private void dgvDetail_KeyDown(object sender, KeyEventArgs e)
        {
            if ((dgvDetail.CurrentCell.ColumnIndex == 3 || dgvDetail.CurrentCell.ColumnIndex == 4) && e.KeyCode == Keys.F4)
            {
                objSelectedProduct = new clsProduct();
                frmProductList winProductList = new frmProductList(this);
                winProductList.ShowDialog(this);
                objSelectedProduct.load(selectedProductCodsec);
                dgvDetail.CurrentRow.Cells["clmProductCodsec"].Value = objSelectedProduct.codsec.ToString();
                dgvDetail.CurrentRow.Cells["clmProductCode"].Value = objSelectedProduct.code;
                dgvDetail.CurrentRow.Cells["clmProductName"].Value = objSelectedProduct.name;

                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkProduct = objSelectedProduct.codsec;
                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].product = objSelectedProduct;
                lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkStatus = Convert.ToInt32(dgvDetail.CurrentRow.Cells["clmStatus"].Value);
            }
        }

        private void frmInternationalSalesOrderForm_Load(object sender, EventArgs e)
        {
            List<clsCommercialCondition> lstCommercialCondition = clsCommercialCondition.getList();
            List<clsIncoterms> lstIncoterms = clsIncoterms.getList();
            List<clsCurrency> lstCurrency = clsCurrency.getList();
            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Venta");
            List<clsCountry> lstCountry = clsCountry.getList();
            List<clsPackagingType> lstPackagingType = clsPackagingType.getList();

            cmbCommercialCondition.Items.Clear();
            for (int i = 0; i < lstCommercialCondition.Count; i++)
                cmbCommercialCondition.Items.Add(lstCommercialCondition[i]);

            cmbStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            for (int i = 0; i < cmbStatus.Items.Count; i++)
            {
                if (lstStatus[i].codsec == 9)
                {
                    cmbStatus.SelectedIndex = i;
                    break;
                }
            }


            cmbIncoterms.Items.Clear();
            for (int i = 0; i < lstIncoterms.Count; i++)
                cmbIncoterms.Items.Add(lstIncoterms[i]);

            cmbCurrency.Items.Clear();
            for (int i = 0; i < lstCurrency.Count; i++)
            {
                cmbCurrency.Items.Add(lstCurrency[i]);
                if (lstCurrency[i].codsec == clsGlobal.Company.fkCurrency)
                {
                    cmbCurrency.SelectedIndex = i;
                    break;
                }
            }

            cmbCountryFrom.Items.Clear();
            cmbCountryTo.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
            {
                cmbCountryFrom.Items.Add(lstCountry[i]);
                cmbCountryTo.Items.Add(lstCountry[i]);
            }

            for (int i = 0; i < cmbCountryFrom.Items.Count; i++)
            {
                if (lstCountry[i].codsec == 65)
                {
                    cmbCountryFrom.SelectedIndex = i;
                    break;
                }
            }

            List<clsCity> lstCity = new List<clsCity>();
            lstCity = clsCity.getListByCountry(((clsCountry)cmbCountryFrom.SelectedItem).codsec);

            for (int i = 0; i < lstCity.Count; i++)
            {
                if (lstCity[i].codsec == 19)
                {
                    cmbCityFrom.SelectedIndex = i;
                    break;
                }
            }


            cmbPackaging.Items.Clear();
            for (int i = 0; i < lstPackagingType.Count; i++)
                cmbPackaging.Items.Add(lstPackagingType[i]);

            for (int i = 0; i < cmbPackaging.Items.Count; i++)
            {
                if (lstPackagingType[i].codsec == 2)
                {
                    cmbPackaging.SelectedIndex = i;
                    break;
                }
            }

            lstSalesOrderDetail.Add(new clsSalesOrderDetail());

            if (objSalesOrder.codsec > 0)
            {
                int countryFrom, countryTo;

                
                txtNumber.Text = objSalesOrder.number;
                dtpDate.Value = objSalesOrder.createdDate;

                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objSalesOrder.fkStatus)
                    {
                        cmbStatus.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cmbCommercialCondition.Items.Count; i++)
                {
                    if (((clsCommercialCondition)cmbCommercialCondition.Items[i]).codsec == objSalesOrder.fkCommercialCondition)
                    {
                        cmbCommercialCondition.SelectedIndex = i;
                        break;
                    }
                }

                objCustomer.load(objSalesOrder.fkEntity);

                txtCustomerName.Text = objCustomer.companyName;
                txtCustomerCountry.Text = objCustomer.countryName;
                txtCustomerId.Text = objCustomer.id;
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                if (lstAddress.Count > 0)
                    txtCustomerAddress.Text = lstAddress[0].address;
                else
                    txtCustomerAddress.Text = "";

                txtNotes.Text = objSalesOrder.notes;
                lstSalesOrderDetail = objSalesOrder.lstSalesOrderDetail;
                for (int i = 0; i < objSalesOrder.lstSalesOrderDetail.Count; i++)
                {
                    dgvDetail.Rows.Add();
                    dgvDetail.Rows[i].Cells[clmCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].codsec.ToString();
                    dgvDetail.Rows[i].Cells[clmProductCode.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.code;
                    dgvDetail.Rows[i].Cells[clmProductName.Index].Value = objSalesOrder.lstSalesOrderDetail[i].product.name;
                    dgvDetail.Rows[i].Cells[clmProductCodsec.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkProduct.ToString();
                    dgvDetail.Rows[i].Cells[clmQuantity.Index].Value = objSalesOrder.lstSalesOrderDetail[i].quantity.ToString();
                    dgvDetail.Rows[i].Cells[clmPrice.Index].Value = objSalesOrder.lstSalesOrderDetail[i].price.ToString();
                    dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value = objSalesOrder.lstSalesOrderDetail[i].palletnumber.ToString();
                    dgvDetail.Rows[i].Cells[clmStatus.Index].Value = objSalesOrder.lstSalesOrderDetail[i].fkStatus.ToString();

                    dgvDetail.Rows[i].Cells["clmSubTotal"].Value = Math.Round((Convert.ToDouble(dgvDetail.Rows[i].Cells["clmQuantity"].Value) * Convert.ToDouble(dgvDetail.Rows[i].Cells["clmPrice"].Value)), 2).ToString();
                }

                for (int i = 0; i < cmbIncoterms.Items.Count; i++)
                {
                    if (((clsIncoterms)cmbIncoterms.Items[i]).codsec == objSalesOrder.ExportData.fkIncoterms)
                    {
                        cmbIncoterms.SelectedIndex = i;
                        break;
                    }
                }

                for (int i = 0; i < cmbCurrency.Items.Count; i++)
                {
                    if (((clsCurrency)cmbCurrency.Items[i]).codsec == objSalesOrder.ExportData.fkCurrency)
                        cmbCurrency.SelectedIndex = i;
                }

                countryFrom = clsCity.getCountry(objSalesOrder.ExportData.fkCityFrom);
                countryTo = clsCity.getCountry(objSalesOrder.ExportData.fkCityTo);

                for (int i = 0; i < cmbCountryFrom.Items.Count; i++)
                {
                    if (((clsCountry)cmbCountryFrom.Items[i]).codsec == countryFrom)
                        cmbCountryFrom.SelectedIndex = i;
                }

                for (int i = 0; i < cmbCountryTo.Items.Count; i++)
                {
                    if (((clsCountry)cmbCountryTo.Items[i]).codsec == countryTo)
                        cmbCountryTo.SelectedIndex = i;
                }

                for (int i = 0; i < cmbCityFrom.Items.Count; i++)
                {
                    if (((clsCity)cmbCityFrom.Items[i]).codsec == objSalesOrder.ExportData.fkCityFrom)
                        cmbCityFrom.SelectedIndex = i;
                }

                for (int i = 0; i < cmbCityTo.Items.Count; i++)
                {
                    if (((clsCity)cmbCityTo.Items[i]).codsec == objSalesOrder.ExportData.fkCityTo)
                        cmbCityTo.SelectedIndex = i;
                }

               // txtTrafficClassification.Text =
                cmbTrafficClassification.SelectedItem = objSalesOrder.ExportData.trafficification.ToString();
                txtExchangeRate.Text = Math.Round(objSalesOrder.ExportData.exchangeRate, 2).ToString();

                for (int i = 0; i < cmbPackaging.Items.Count; i++)
                {
                    if (((clsPackagingType)cmbPackaging.Items[i]).codsec == objSalesOrder.ExportData.fkPackagingType)
                        cmbPackaging.SelectedIndex = i;
                }

                txtInsurance.Text = Math.Round(objSalesOrder.ExportData.insurance, 2).ToString();
                txtFreight.Text = Math.Round(objSalesOrder.ExportData.freight, 2).ToString();

                calculateTotals();
                calculateGreatTotal();
            }

        }

        private void txtCustomerCode_Leave(object sender, EventArgs e)
        {
            if (txtCustomerId.Text != "")
            {
                objCustomer = clsEntity.getCustomerById(txtCustomerId.Text);

                if (objCustomer.codsec > 0)
                {
                    txtCustomerName.Text = objCustomer.companyName;
                    txtCustomerCountry.Text = objCustomer.countryName;
                    List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                    if (lstAddress.Count > 0)
                        txtCustomerAddress.Text = lstAddress[0].address;
                    else
                        txtCustomerAddress.Text = "";
                }
                else
                {
                    MessageBox.Show("La identificación ingresada no coinside con ningun cliente reguistrado.", "Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    txtCustomerName.Text = "";
                    txtCustomerCountry.Text = "";
                    txtCustomerAddress.Text = "";
                }
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            objCustomer = new clsEntity();
            frmCustomerList winCustomerList = new frmCustomerList(this);
            winCustomerList.ShowDialog(this);
            objCustomer.load(selectedCustomerCodsec);

            if (objCustomer.codsec > 0)
            {
                txtCustomerName.Text = objCustomer.companyName;
                txtCustomerCountry.Text = objCustomer.countryName;
                txtCustomerId.Text = objCustomer.id;
                List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
                if (lstAddress.Count > 0)
                    txtCustomerAddress.Text = lstAddress[0].address;
                else
                    txtCustomerAddress.Text = "";
            }
            else
            {
                MessageBox.Show("La identificación ingresada no coinside con ningun cliente registrado.", "Orden de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                txtCustomerName.Text = "";
                txtCustomerCountry.Text = "";
                txtCustomerId.Text = "";
                txtCustomerAddress.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (clsSalesOrder.IsUniqueSalesOrderNumber(txtNumber.Text, objSalesOrder.codsec))
                {
                    objSalesOrder.fkEntity = objCustomer.codsec;
                    objSalesOrder.fkCommercialCondition = ((clsCommercialCondition)cmbCommercialCondition.SelectedItem).codsec;
                    objSalesOrder.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                    //objSalesOrder.number = clsSalesOrder.getNextNumber();
                    objSalesOrder.number = txtNumber.Text;
                    objSalesOrder.notes = txtNotes.Text;
                    objSalesOrder.createdDate = dtpDate.Value;

                    for (int i = 0; i < lstSalesOrderDetail.Count; i++)
                    {
                        if (lstSalesOrderDetail[i].fkProduct != 0 && lstSalesOrderDetail[i].coilsToCut == 0)
                        {
                            clsProduct objProduct = new clsProduct(lstSalesOrderDetail[i].fkProduct);
                            if (dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value == null)
                                dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value = 0;
                            lstSalesOrderDetail[i].palletnumber = Convert.ToInt32(dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value);
                            clsParameters ObjParameters = new clsParameters();
                            ObjParameters = clsParameters.getParameterByProduct(lstSalesOrderDetail[i].fkProduct);
                            if (ObjParameters.codsec > 0)
                            {
                                lstSalesOrderDetail[i].coilsToCut = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objProduct.fkBopp, objProduct.fkCast, objProduct.fkDiameter, objProduct.fkCore, objProduct.width, (lstSalesOrderDetail[i].quantity))));
                                lstSalesOrderDetail[i].palletnumber = Convert.ToInt32(dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value);
                            }
                            else
                            {
                                ObjParameters.fkBopp = objProduct.fkBopp;
                                ObjParameters.fkCast = objProduct.fkCast;
                                ObjParameters.fkDiameter = objProduct.fkDiameter;
                                ObjParameters.fkCore = objProduct.fkCore;
                                ObjParameters.weightFactor = 1.92;
                                ObjParameters.aproxLength = 1024;
                                if (ObjParameters.save())
                                {
                                    lstSalesOrderDetail[i].coilsToCut = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objProduct.fkBopp, objProduct.fkCast, objProduct.fkDiameter, objProduct.fkCore, objProduct.width, (lstSalesOrderDetail[i].quantity))));
                                    lstSalesOrderDetail[i].palletnumber = Convert.ToInt32(dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value);
                                }
                                else
                                {
                                    lstSalesOrderDetail[i].coilsToCut = Convert.ToInt32(Math.Ceiling(clsParameters.getCoilsNumberByWidthAndWeigth(objProduct.fkBopp, objProduct.fkCast, objProduct.fkDiameter, objProduct.fkCore, objProduct.width, (lstSalesOrderDetail[i].quantity))));
                                    lstSalesOrderDetail[i].palletnumber = Convert.ToInt32(dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value);
                                }
                            }   
                        }
                        else if (lstSalesOrderDetail[i].coilsToCut != 0)
                            lstSalesOrderDetail[i].palletnumber = Convert.ToInt32(dgvDetail.Rows[i].Cells[clmpalletnumber.Index].Value);
                    }

                    objSalesOrder.lstSalesOrderDetail = lstSalesOrderDetail;
                    objSalesOrder.isInternationalSale = true;

                    objSalesOrder.ExportData.fkSalesOrder = objSalesOrder.codsec;
                    objSalesOrder.ExportData.fkIncoterms = ((clsIncoterms)cmbIncoterms.SelectedItem).codsec;
                    objSalesOrder.ExportData.fkCityFrom = ((clsCity)cmbCityFrom.SelectedItem).codsec;
                    objSalesOrder.ExportData.fkCityTo = ((clsCity)cmbCityTo.SelectedItem).codsec;
                    objSalesOrder.ExportData.fkPackagingType = ((clsPackagingType)cmbPackaging.SelectedItem).codsec;
                    objSalesOrder.ExportData.fkCurrency = ((clsCurrency)cmbCurrency.SelectedItem).codsec;
                    objSalesOrder.ExportData.exchangeRate = Convert.ToDouble(txtExchangeRate.Text);
                    objSalesOrder.ExportData.trafficification = cmbTrafficClassification.SelectedItem.ToString();
                    objSalesOrder.ExportData.freight = Convert.ToDouble(txtFreight.Text);
                    objSalesOrder.ExportData.insurance = Convert.ToDouble(txtInsurance.Text);
                    objSalesOrder.ExportData.otherCharges = Convert.ToDouble(txtOtherCharges.Text);
                    objSalesOrder.compromisedate = dtpDate.Value;

                    if (objSalesOrder.save())
                    {
                        MessageBox.Show("La orden de venta se ha guardado con éxito.", "Orden de venta Internacional", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        if (MessageBox.Show("Desea crear una nueva orden?", "Orden de venta Internacional", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            clsGlobal.ClearForm(this);
                            objCustomer = new clsEntity();
                            objSelectedProduct = new clsProduct();
                            objSalesOrder = new clsSalesOrder();
                            lstSalesOrderDetail.Clear();
                            dtpDate.Focus();
                            isUpdate = false;
                        }
                        else
                            this.Close();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Orden de venta Internacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                    MessageBox.Show("El número de orden ya ha sido utilizado por favor revise que el número de orden sea el correcto.", "Orden de venta Internacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("Hay datos no registrados y que son obligatorios, por favor registre todos los datos.", "Orden de venta Internacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void dgvDetail_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (!isUpdate)
                lstSalesOrderDetail.Add(new clsSalesOrderDetail());
        }

        private void dgvDetail_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (canBeEdited(Convert.ToInt32(dgvDetail.Rows[dgvDetail.CurrentRow.Index].Cells[clmCodsec.Index].Value)))
            {
                lstSalesOrderDetail.RemoveAt(dgvDetail.CurrentRow.Index);
                lstSalesOrderDetail[lstSalesOrderDetail.Count - 1].fkStatus = 1;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("El detalle de la orden seleccionada no puede ser borrado ya que esta asociado a bobinas, pallets u ordenes de corte existentes. Por favor póngase en contacto con el departamento de planificación para resolver este conflicto.", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void dgvDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["clmStatus"].Value = clsStatus.getStatusByStatusGroupNameAndStatusName("Detalle de ordenes de venta", "Activo").codsec;
            e.Row.Cells["clmCodsec"].Value = "0";
            e.Row.Cells[clmPrice.Index].Value = "0";
            e.Row.Cells[clmProductCode.Index].Value = "";
            e.Row.Cells[clmQuantity.Index].Value = "0";
            e.Row.Cells[clmpalletnumber.Index].Value = "0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbCountryFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCountryFrom.SelectedItem != null)
                loadCityList(((clsCountry)cmbCountryFrom.SelectedItem).codsec, ref cmbCityFrom);
        }

        private void cmbCountryTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCountryTo.SelectedItem != null)
                loadCityList(((clsCountry)cmbCountryTo.SelectedItem).codsec, ref cmbCityTo);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            calculateGreatTotal();
        }

        private void txtFreight_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtFreight.Text) == false && txtFreight.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtFreight.Text = "0";
            }
            else
                calculateGreatTotal();
        }

        private void txtInsurance_TextChanged(object sender, EventArgs e)
        {
            if (clsGlobal.isNumeric(txtInsurance.Text) == false && txtInsurance.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtInsurance.Text = "0";
            }
            else
                calculateGreatTotal();
        }

        private void txtOtherCharges_TextChanged(object sender, EventArgs e)
        {
            if (txtOtherCharges.Text != "0" && txtOtherCharges.Text != "")
                lblMessage.Visible = true;
            else
                lblMessage.Visible = false;

            if (clsGlobal.isNumeric(txtOtherCharges.Text) == false && txtOtherCharges.Text != "")
            {
                MessageBox.Show("El valor debe ser Numérico");
                txtOtherCharges.Text = "0";
            }
            else
                calculateGreatTotal();
        }

        private void dgvDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmProductCode.Index)
            {
                if ((Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells[clmCodsec.Index].Value) == 0) || canBeEdited(Convert.ToInt32(dgvDetail.Rows[e.RowIndex].Cells[clmCodsec.Index].Value)))
                {
                    objSelectedProduct = new clsProduct();
                    frmProductList winProductList = new frmProductList(this);
                    winProductList.ShowDialog(this);
                    if (selectedProductCodsec > 0)
                    {
                        objSelectedProduct.load(selectedProductCodsec);
                        dgvDetail.CurrentRow.Cells[clmProductCodsec.Index].Value = objSelectedProduct.codsec.ToString();
                        dgvDetail.CurrentRow.Cells[clmProductCode.Index].Value = objSelectedProduct.code;
                        dgvDetail.CurrentRow.Cells[clmProductName.Index].Value = objSelectedProduct.name;
                        var mydetail = dgvDetail.CurrentRow.Index;
                        if (!isUpdate)
                        {
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkProduct = objSelectedProduct.codsec;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].product = objSelectedProduct;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkStatus = Convert.ToInt32(dgvDetail.CurrentRow.Cells[clmStatus.Index].Value);
                        }
                        else
                        {
                            lstSalesOrderDetail.Add(new clsSalesOrderDetail());
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkProduct = objSelectedProduct.codsec;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].product = objSelectedProduct;
                            lstSalesOrderDetail[dgvDetail.CurrentRow.Index].fkStatus = Convert.ToInt32(dgvDetail.CurrentRow.Cells[clmStatus.Index].Value);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El detalle de la orden seleccionada no puede ser editado ya que esta asociado a bobinas, pallets u ordenes de corte existentes. Por favor póngase en contacto con el departamento de planificación para resolver este conflicto.", "Orden de venta nacional", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro de cancelar de Orden de Venta..?", "Ordenes de Venta Internacionales", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
                frmInternationalSalesOrderList winInternationalSalesOrderList = new frmInternationalSalesOrderList();
                winInternationalSalesOrderList.Show();
            }
        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Ordenes de Venta");          
                cmbStatus.Items.Clear();
                for (int i = 0; i < lstStatus.Count; i++)
                    cmbStatus.Items.Add(lstStatus[i]);
            }
        }

        private void cmbCommercialCondition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCommercialCondition> lstCommercialCondition = clsCommercialCondition.getList();
                cmbCommercialCondition.Items.Clear();
                for (int i = 0; i < lstCommercialCondition.Count; i++)
                    cmbCommercialCondition.Items.Add(lstCommercialCondition[i]);
            }
        }

        private void cmbIncoterms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsIncoterms> lstIncoterms = clsIncoterms.getList();
                cmbIncoterms.Items.Clear();
                for (int i = 0; i < lstIncoterms.Count; i++)
                    cmbIncoterms.Items.Add(lstIncoterms[i]);
            }
        }

        private void cmbCurrency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCurrency> lstCurrency = clsCurrency.getList();
                cmbCurrency.Items.Clear();
                for (int i = 0; i < lstCurrency.Count; i++)
                {
                    cmbCurrency.Items.Add(lstCurrency[i]);
                    if (lstCurrency[i].codsec == clsGlobal.Company.fkCurrency)
                        cmbCurrency.SelectedIndex = i;
                }
            }
        }

        private void cmbCountryFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCountry> lstCountry = clsCountry.getList();
                cmbCountryFrom.Items.Clear();
                for (int i = 0; i < lstCountry.Count; i++)
                    cmbCountryFrom.Items.Add(lstCountry[i]);
            }
        }

        private void cmbPackaging_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsPackagingType> lstPackagingType = clsPackagingType.getList();
                cmbPackaging.Items.Clear();
                for (int i = 0; i < lstPackagingType.Count; i++)
                    cmbPackaging.Items.Add(lstPackagingType[i]);
            }
        }

        private void cmbContainer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cmbIncoterms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncoterms.SelectedIndex != -1)
            {
                if (((clsIncoterms)cmbIncoterms.SelectedItem).abbreviation == "CIP")
                    lblTotal.Text = "Fca";
                else if (((clsIncoterms)cmbIncoterms.SelectedItem).abbreviation == "CFR" || ((clsIncoterms)cmbIncoterms.SelectedItem).abbreviation == "CIF")
                    lblTotal.Text = "Fob";
                else
                    lblTotal.Text = "Total";
            }
        }
    }
}