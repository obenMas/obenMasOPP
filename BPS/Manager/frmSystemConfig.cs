using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using BPS.Bussiness;


namespace BPS
{
    public partial class frmSystemConfig : Form
    {
        string tempCountryName, tempCountryAbb, tempStateName, tempCityName;
        string countryActionSelected, stateActionSelected, cityActionSelected;
        public bool isAutoricet = false;

        #region Geographic Data

        public void loadCountriesList()
        {
            List<clsCountry> lstCountry = new List<clsCountry>();      
            lstCountry = clsCountry.getList();
            lstbCountry.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
            {
                lstbCountry.Items.Add(lstCountry[i]);
            }
        }
       
        
        private void lstbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCountry selCountry = new clsCountry();
            selCountry = (clsCountry)lstbCountry.SelectedItem;
            txtCountryName.Text = selCountry.name;
            txtcountryAbbreviation.Text = selCountry.abbreviation;
            loadStateList(selCountry.codsec);
            gpbInfoCountry.Enabled = false;
            lstbCity.Items.Clear();
            txtStateName.Text = "";
            txtCityName.Text = "";

        }

        
        private void lstbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsState selState = new clsState();
            selState = (clsState)lstbState.SelectedItem;
            txtStateName.Text = selState.name;
            loadCitiesList(selState.codsec);
            gpbInfoState.Enabled = false;
            txtCityName.Text = "";
        }

        private void lstbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsCity selCity = new clsCity();
            selCity = (clsCity)lstbCity.SelectedItem;
            txtCityName.Text = selCity.name;
            gpbInfoState.Enabled = false;

        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            countryActionSelected = "Add";
            tempCountryName = txtCountryName.Text;
            tempCountryAbb = txtcountryAbbreviation.Text;

            txtCountryName.Text = "";
            txtcountryAbbreviation.Text = "";
            gpbInfoCountry.Enabled = true;
            txtCountryName.Focus();

            gpbActionsCountry.Enabled = false;
            gpbActionsState.Enabled = false;
            gpbActionsCity.Enabled = false;
            lstbCountry.Enabled = false;
            lstbState.Enabled = false;
            lstbCity.Enabled = false;
        }

        private void btnEditCountry_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text != "")
            {
                countryActionSelected = "Edit";
                tempCountryName = txtCountryName.Text;
                tempCountryAbb = txtcountryAbbreviation.Text;

                gpbInfoCountry.Enabled = true;
                txtCountryName.Focus();

                gpbActionsCountry.Enabled = false;
                gpbActionsState.Enabled = false;
                gpbActionsCity.Enabled = false;
                lstbCountry.Enabled = false;
                lstbState.Enabled = false;
                lstbCity.Enabled = false;
            }
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            stateActionSelected = "Add";
            tempStateName = txtStateName.Text;
            txtStateName.Text = "";
            gpbInfoState.Enabled = true;
            txtStateName.Focus();

            gpbActionsCountry.Enabled = false;
            gpbActionsState.Enabled = false;
            gpbActionsCity.Enabled = false;
            lstbCountry.Enabled = false;
            lstbState.Enabled = false;
            lstbCity.Enabled = false;
        }

        private void btnEditState_Click(object sender, EventArgs e)
        {
            if (txtStateName.Text != "")
            {
                stateActionSelected = "Edit";
                tempStateName = txtStateName.Text;
                gpbInfoState.Enabled = true;
                txtStateName.Focus();

                gpbActionsCountry.Enabled = false;
                gpbActionsState.Enabled = false;
                gpbActionsCity.Enabled = false;
                lstbCountry.Enabled = false;
                lstbState.Enabled = false;
                lstbCity.Enabled = false;
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            cityActionSelected = "Add";
            tempCityName = txtCityName.Text;
            txtCityName.Text = "";
            gpbInfoCity.Enabled = true;
            txtCityName.Focus();

            gpbActionsCountry.Enabled = false;
            gpbActionsState.Enabled = false;
            gpbActionsCity.Enabled = false;
            lstbCountry.Enabled = false;
            lstbState.Enabled = false;
            lstbCity.Enabled = false;
        }

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            if (txtCityName.Text != "")
            {
                cityActionSelected = "Edit";
                tempCityName = txtCityName.Text;
                gpbInfoCity.Enabled = true;
                txtCityName.Focus();

                gpbActionsCountry.Enabled = false;
                gpbActionsState.Enabled = false;
                gpbActionsCity.Enabled = false;
                lstbCountry.Enabled = false;
                lstbState.Enabled = false;
                lstbCity.Enabled = false;
            }
        }

        private void btnCancelCountry_Click(object sender, EventArgs e)
        {
            countryActionSelected = "";
            txtCountryName.Text = tempCountryName;
            txtcountryAbbreviation.Text = tempCountryAbb;
            gpbInfoCountry.Enabled = false;

            gpbActionsCountry.Enabled = true;
            gpbActionsState.Enabled = true;
            gpbActionsCity.Enabled = true;
            lstbCountry.Enabled = true;
            lstbState.Enabled = true;
            lstbCity.Enabled = true;
        }

        private void btnCancelState_Click(object sender, EventArgs e)
        {
            stateActionSelected = "";
            txtStateName.Text = tempStateName;
            gpbInfoState.Enabled = false;

            gpbActionsCountry.Enabled = true;
            gpbActionsState.Enabled = true;
            gpbActionsCity.Enabled = true;
            lstbCountry.Enabled = true;
            lstbState.Enabled = true;
            lstbCity.Enabled = true;
        }

        private void btnCancelCity_Click(object sender, EventArgs e)
        {
            countryActionSelected = "";
            txtCityName.Text = tempCityName;
            gpbInfoCity.Enabled = false;

            gpbActionsCountry.Enabled = true;
            gpbActionsState.Enabled = true;
            gpbActionsCity.Enabled = true;
            lstbCountry.Enabled = true;
            lstbState.Enabled = true;
            lstbCity.Enabled = true;
        }

        private void btnSaveCountry_Click(object sender, EventArgs e)
        {
            clsCountry objCountry = new clsCountry();

            if (countryActionSelected == "Add")
            {
                objCountry.name = txtCountryName.Text;
                objCountry.abbreviation = txtcountryAbbreviation.Text;
            }
            else if (countryActionSelected == "Edit")
            {
                objCountry = (clsCountry)lstbCountry.SelectedItem;
                objCountry.name = txtCountryName.Text;
                objCountry.abbreviation = txtcountryAbbreviation.Text;
            }

            objCountry.save();

            loadCountriesList();

            gpbInfoCountry.Enabled = false;

            gpbActionsCountry.Enabled = true;
            gpbActionsState.Enabled = true;
            gpbActionsCity.Enabled = true;
            lstbCountry.Enabled = true;
            lstbState.Enabled = true;
            lstbCity.Enabled = true;

            txtStateName.Text = "";
            txtCityName.Text = "";
            countryActionSelected = "";
            txtCountryName.Text = "";
        }

        private void btnSaveState_Click(object sender, EventArgs e)
        {
            clsState objState = new clsState();


            clsCountry selCountry = new clsCountry();
            selCountry = (clsCountry)lstbCountry.SelectedItem;

            if (stateActionSelected == "Add")
            {
                objState.name = txtStateName.Text;
                objState.fkCountry = selCountry.codsec;
            }
            else if (stateActionSelected == "Edit")
            {
                objState = (clsState)lstbState.SelectedItem;
                objState.name = txtStateName.Text;
            }

            objState.save();

            gpbInfoState.Enabled = false;

            gpbActionsCountry.Enabled = true;
            gpbActionsState.Enabled = true;
            gpbActionsCity.Enabled = true;
            lstbCountry.Enabled = true;
            lstbState.Enabled = true;
            lstbCity.Enabled = true;

            loadStateList(selCountry.codsec);

            stateActionSelected = "";
            txtStateName.Text = "";
            txtCityName.Text = "";
        }

        private void btnSaveCity_Click(object sender, EventArgs e)
        {
            clsCity objCity = new clsCity();


            clsState selState = new clsState();
            selState = (clsState)lstbState.SelectedItem;

            if (cityActionSelected == "Add")
            {

                objCity.name = txtCityName.Text;
                objCity.fkState = selState.codsec;
            }
            else if (cityActionSelected == "Edit")
            {
                objCity = (clsCity)lstbCity.SelectedItem;
                objCity.name = txtCityName.Text;
            }

            objCity.save();

            gpbInfoCity.Enabled = false;

            gpbActionsCountry.Enabled = true;
            gpbActionsState.Enabled = true;
            gpbActionsCity.Enabled = true;
            lstbCountry.Enabled = true;
            lstbState.Enabled = true;
            lstbCity.Enabled = true;

            loadCitiesList(selState.codsec);

            cityActionSelected = "";
            txtCityName.Text = "";
        }

        private void btnDeleteCountry_Click(object sender, EventArgs e)
        {
            countryActionSelected = "Delete";
        }

        #endregion

        #region "Company info"

        public void loadCompanyInfo()
        {
            List<clsCountry> lstCountryCompany = clsCountry.getList();
            List<clsCurrency> lstCurrencyCompany = clsCurrency.getList();
            List<clsCompanyAddress> lstCompanyAddress = new List<clsCompanyAddress>();
            List<clsCountry> lstCountry = new List<clsCountry>();
            
            
            cmbCountryCompany.Items.Clear();
            cmbCurrencyMoney.Items.Clear();
            cmbCompanyCountry.Items.Clear();

            for (int i = 0; i < lstCountryCompany.Count ; i++)
            {
                cmbCountryCompany.Items.Add(lstCountryCompany[i]);
                if (clsGlobal.Company.fkCountry == lstCountryCompany[i].codsec)
                    cmbCountryCompany.SelectedIndex = i;
            }

            for (int i = 0; i < lstCurrencyCompany.Count; i++)
            {
                cmbCurrencyMoney.Items.Add(lstCurrencyCompany[i]);
                if (clsGlobal.Company.fkCurrency == lstCurrencyCompany[i].codsec)
                    cmbCurrencyMoney.SelectedIndex = i;
            }


            for (int i = 0; i < lstCountryCompany.Count; i++)
            {
                cmbCompanyCountry.Items.Add(lstCountryCompany[i]);
            }

            this.txtNameCompany.Text = clsGlobal.Company.name;
            this.txtDescriptionCompany.Text = clsGlobal.Company.description;

            if (clsGlobal.Company.type.ToUpper() == "PLANTA")
                rdoPlant.Select();
            else
                rdoDistrib.Select();

            grpbCompanyInfo.Enabled = false;

            lstCompanyAddress = clsCompanyAddress.getListByCompany(clsGlobal.Company.codsec);

            dgvCompanyAddress.Rows.Clear();
                   

        }

       

        private void cmbCompanyCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyCountry.SelectedItem != null)
            {
                loadStateList(((clsCountry)cmbCompanyCountry.SelectedItem).codsec);
            
            }
                  
        }

        public void loadStateList(int countryCodsec) 
        {
            List<clsState> lstState = new List<clsState>();
            lstState = clsState.getListByCountry(countryCodsec);
            cmbCompanyState.Items.Clear();
            for (int i = 0; i < lstState.Count; i++)
            {
                cmbCompanyState.Items.Add(lstState[i]);
            }
        }

        public void loadCitiesList(int stateCodsec)
        {
            List<clsCity> lstCity = new List<clsCity>();
            lstCity = clsCity.getListByState(stateCodsec);
            cmbCompanyCity.Items.Clear();
            for (int i = 0; i < lstCity.Count; i++)
            {
                cmbCompanyCity.Items.Add(lstCity[i]);
            }
        }


        private void cmbCompanyState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCompanyState.SelectedItem != null)
            {
                loadCitiesList(((clsState)cmbCompanyState.SelectedItem).codsec);

            }
        }



        private void btnEditCompany_Click(object sender, EventArgs e)
        {
            grpbCompanyInfo.Enabled = true;
            txtNameCompany.Focus();
            btnEditCompany.Enabled = false;
            btnSaveCompany.Enabled = true;
            btnCancelCompany.Enabled = true;
        }




        


        private void btnSaveCompany_Click(object sender, EventArgs e)
        {
            clsCompany objCompany = new clsCompany();
            objCompany = clsGlobal.Company;

            objCompany.name = txtNameCompany.Text;
            objCompany.fkCountry = ((clsCountry)cmbCountryCompany.SelectedItem).codsec;
            objCompany.fkCurrency = ((clsCurrency)cmbCurrencyMoney.SelectedItem).codsec;
            objCompany.description = txtDescriptionCompany.Text;
            objCompany.type = (this.rdoPlant.Checked == true) ? "Planta" : "Distribuidora";

            objCompany.save();


            grpbCompanyInfo.Enabled = false;
            txtNameCompany.Focus();
            btnEditCompany.Enabled = true;
            btnSaveCompany.Enabled = false;
            btnCancelCompany.Enabled = false;
        }


        private void btnCompanyAddressSave_Click(object sender, EventArgs e)
        {
            clsCompanyAddress objCompanyAddress = new clsCompanyAddress();
            clsCompany objCompany = new clsCompany();
            objCompany = clsGlobal.Company;

            objCompanyAddress.fkCompany = objCompany.codsec;
            objCompanyAddress.fkCity = ((clsCity)cmbCompanyCity.SelectedItem).codsec;
            objCompanyAddress.contactName = txtCompanyContact.Text;
            objCompanyAddress.address = txtCompanyAddress.Text;
            objCompanyAddress.email = txtCompanyEmail.Text;
            objCompanyAddress.fax = txtCompanyFax.Text;
            objCompanyAddress.phone = txtCompanyPhone.Text;
            objCompanyAddress.phone2 = txtCompanyPhone2.Text;
            objCompanyAddress.zip = txtCompanyZip.Text;
            objCompanyAddress.save();

            
        }



        private void btnCancelCompany_Click(object sender, EventArgs e)
        {
            loadCompanyInfo();

            grpbCompanyInfo.Enabled = false;
            txtNameCompany.Focus();
            btnEditCompany.Enabled = true;
            btnSaveCompany.Enabled = false;
            btnCancelCompany.Enabled = false;
        }
        #endregion

        #region "Currency Info"

        public void loadCurrencyInfo()
        {
            List<clsCurrency> lstCurrency = new List<clsCurrency>();

            grpbCurrencyList.Enabled = true;
            grpbCurrencyForm.Enabled = false;

            lstCurrency.Clear();           
            lstCurrency = clsCurrency.getList();

            dgvCurrency.Rows.Clear();


            for (int i = 0; i < lstCurrency.Count; i++)
            {
                dgvCurrency.Rows.Add();
                dgvCurrency.Rows[i].Cells["clmCodsec"].Value = lstCurrency[i].codsec.ToString();
                dgvCurrency.Rows[i].Cells["clmCurrencyName"].Value = lstCurrency[i].name;
                dgvCurrency.Rows[i].Cells["clmCurrencySymbol"].Value = lstCurrency[i].symbol;
                dgvCurrency.Rows[i].Cells["clmCurrencyDecimal"].Value = lstCurrency[i].decimalNumber;
            }
        }
            

            #endregion

        #region "Currency Function"

        clsCurrency objCurrency = new clsCurrency();


        public void clearCurrencyFields()
        {

            txtCurrencyName.BackColor = Color.White;
            txtCurrencySymbol.BackColor = Color.White;
            txtCurrencyDecimal.BackColor = Color.White;
            lblCurrencyName.ForeColor = Color.Black;
            lblCurrencySymbol.ForeColor = Color.Black;
            lblCurrencyDecimal.ForeColor = Color.Black;
            txtCurrencyName.Clear();
            txtCurrencySymbol.Clear();
            txtCurrencyDecimal.Clear();
            grpbCurrencyForm.Enabled = false;
        }

        public bool validateFormCurrency()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCurrencyName, ref lblCurrencyName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCurrencySymbol, ref lblCurrencySymbol, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCurrencyDecimal, ref lblCurrencyDecimal, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnCurrencyAdd_Click(object sender, EventArgs e)
        {
            grpbCurrencyForm.Enabled = true;
        }

       
        private void btnCurrencySave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormCurrency())
                {
                    objCurrency.name = txtCurrencyName.Text;
                    objCurrency.symbol = txtCurrencySymbol.Text;
                    objCurrency.decimalNumber = Convert.ToDecimal(txtCurrencyDecimal.Text);
                    
                    if (objCurrency.save())
                    {
                        grpbCurrencyForm.Enabled = false;
                        MessageBox.Show("La moneda se ha guardado con éxito.", "Moneda", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadCurrencyInfo();
                        clearCurrencyFields();
                        objCurrency = new clsCurrency();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Moneda", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Moneda", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCurrencyEdit_Click(object sender, EventArgs e)
        {
            grpbCurrencyForm.Enabled = true;
            objCurrency.load(Convert.ToInt32(dgvCurrency.SelectedRows[0].Cells["clmCodsec"].Value.ToString()));
            txtCurrencyName.Text = objCurrency.name;
            txtCurrencySymbol.Text = objCurrency.symbol;
            txtCurrencyDecimal.Text = objCurrency.decimalNumber.ToString();
            
        }

        private void btnCurrencyCancel_Click(object sender, EventArgs e)
        {
            clearCurrencyFields();
        }



        #endregion

        #region "Commercial Condition Info"

        public void loadCommercialConditionInfo()
        {
            List<clsCommercialCondition> lstCommercialCondition = new List<clsCommercialCondition>();

            grpbCommercialConditionList.Enabled = true;
            grpbCommercialConditionForm.Enabled = false;

            lstCommercialCondition.Clear();
            lstCommercialCondition = clsCommercialCondition.getList();

            dgvCommercialCondition.Rows.Clear();


            for (int i = 0; i < lstCommercialCondition.Count; i++)
            {
                dgvCommercialCondition.Rows.Add();
                dgvCommercialCondition.Rows[i].Cells["clmCommercialConditionCodsec"].Value = lstCommercialCondition[i].codsec.ToString();
                dgvCommercialCondition.Rows[i].Cells["clmCommercialConditionName"].Value = lstCommercialCondition[i].name;
                dgvCommercialCondition.Rows[i].Cells["clmCommercialConditionDescription"].Value = lstCommercialCondition[i].description;
               
            }
        }


        #endregion

        #region "Commercial Condition Function"
        
         clsCommercialCondition objCommercialCondition = new clsCommercialCondition();

         public void clearCommercialConditionFields()
        {

            txtCommercialConditionName.BackColor = Color.White;
            txtCommercialConditionDescription.BackColor = Color.White;
            lblCommercialConditionName.ForeColor = Color.Black;
            lblCommercialConditionDescription.ForeColor = Color.Black;
            txtCommercialConditionName.Clear();
            txtCommercialConditionDescription.Clear();
            grpbCommercialConditionForm.Enabled = false;
        }
        public bool validateFormCommercialCondition()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCommercialConditionName, ref lblCommercialConditionName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCommercialConditionDescription, ref lblCommercialConditionDescription, "notEmpty")) isValid = false;
            
            return isValid;
        }

        private void btnCommercialConditionAdd_Click(object sender, EventArgs e)
        {
            grpbCommercialConditionForm.Enabled = true;
        }

        private void btnCommercialConditionSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormCommercialCondition())
                {
                    objCommercialCondition.name = txtCommercialConditionName.Text;
                    objCommercialCondition.description = txtCommercialConditionDescription.Text;

                    if (objCommercialCondition.save())
                    {
                        grpbCommercialConditionForm.Enabled = false;
                        MessageBox.Show("La condicion se ha guardado con éxito.", "Condicion Comercial", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadCommercialConditionInfo();
                        clearCommercialConditionFields();
                        objCommercialCondition = new clsCommercialCondition();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Condicion Comercial", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Condicion Comercial", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCommercialConditionEdit_Click(object sender, EventArgs e)
        {
            grpbCommercialConditionForm.Enabled = true;
            objCommercialCondition.load(Convert.ToInt32(dgvCommercialCondition.SelectedRows[0].Cells["clmCommercialConditionCodsec"].Value.ToString()));
            txtCommercialConditionName.Text = objCommercialCondition.name;
            txtCommercialConditionDescription.Text = objCommercialCondition.description;
            
        }

        private void btnCommercialConditionCancel_Click(object sender, EventArgs e)
        {
            clearCommercialConditionFields();
        }
        #endregion

        #region "Incoterms Info"

        public void loadIncotermsInfo()
        {
            List<clsIncoterms> lstIncoterms = new List<clsIncoterms>();


            grpbIncotermsList.Enabled = true;
            grpbIncotermsForm.Enabled = false;

            lstIncoterms.Clear();
            lstIncoterms = clsIncoterms.getList();


            dgvIncoterms.Rows.Clear();


            for (int i = 0; i < lstIncoterms.Count; i++)
            {
                dgvIncoterms.Rows.Add(); 
                dgvIncoterms.Rows[i].Cells["clmIncotermsCodsec"].Value = lstIncoterms[i].codsec.ToString();
                dgvIncoterms.Rows[i].Cells["clmIncotermsName"].Value = lstIncoterms[i].name;
                dgvIncoterms.Rows[i].Cells["clmIncotermsAbbreviation"].Value = lstIncoterms[i].abbreviation;
                dgvIncoterms.Rows[i].Cells["clmIncotermsDescription"].Value = lstIncoterms[i].description;

            }
        }

        #endregion

        #region "Incoterms Function"

        clsIncoterms objIncoterms = new clsIncoterms();

        public void clearIncotermsFields()
        {

            txtIncotermsName.BackColor = Color.White;
            txtIncotermsDescription.BackColor = Color.White;
            txtIncotermsAbbreviation.BackColor = Color.White;
            lblIncotermsName.ForeColor = Color.Black;
            lblIncotermsDescription.ForeColor = Color.Black;
            lblIncotermsAbbreviation.ForeColor = Color.Black;
            txtIncotermsName.Clear();
            txtIncotermsDescription.Clear();
            txtIncotermsAbbreviation.Clear();
            grpbIncotermsForm.Enabled = false;
        }


        public bool validateFormIncoterms()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtIncotermsName, ref lblIncotermsName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtIncotermsAbbreviation, ref lblIncotermsAbbreviation, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtIncotermsDescription, ref lblIncotermsDescription, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnIncotermsAdd_Click(object sender, EventArgs e)
        {
            grpbIncotermsForm.Enabled = true;
        }

        private void btnIncotermsSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormIncoterms())
                {
                    objIncoterms.name = txtIncotermsName.Text;
                    objIncoterms.abbreviation = txtIncotermsAbbreviation.Text;
                    objIncoterms.description = txtIncotermsDescription.Text;

                    if (objIncoterms.save())
                    {
                        grpbIncotermsForm.Enabled = false;
                        MessageBox.Show("El Incoterm se ha guardado con éxito.", "Incoterms", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadIncotermsInfo();
                        clearIncotermsFields();
                        objIncoterms = new clsIncoterms();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Incoterms", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Incoterms", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnIncotermsEdit_Click(object sender, EventArgs e)
        {
            grpbIncotermsForm.Enabled = true;
            objIncoterms.load(Convert.ToInt32(dgvIncoterms.SelectedRows[0].Cells["clmIncotermsCodsec"].Value.ToString()));
            txtIncotermsName.Text = objIncoterms.name;
            txtIncotermsAbbreviation.Text = objIncoterms.abbreviation;
            txtIncotermsDescription.Text = objIncoterms.description;
        }

        private void btnIncotermsCancel_Click(object sender, EventArgs e)
        {
            clearIncotermsFields();
        }


        #endregion

        #region "Transport Info"

        public void loadTransportInfo()
        {
            List<clsTransport> lstTransport = new List<clsTransport>();

            grpbTransportList.Enabled = true;
            grpbTransportForm.Enabled = false;

            lstTransport.Clear();
            lstTransport = clsTransport.getList();


            dgvTransport.Rows.Clear();


            for (int i = 0; i < lstTransport.Count; i++)
            {
                dgvTransport.Rows.Add();    
                dgvTransport.Rows[i].Cells["clmTransportCodsec"].Value = lstTransport[i].codsec.ToString();
                dgvTransport.Rows[i].Cells["clmTransportName"].Value = lstTransport[i].name;
                dgvTransport.Rows[i].Cells["clmTransportusefulWidth"].Value = lstTransport[i].usefulWidth;
                dgvTransport.Rows[i].Cells["clmTransportusefulHigh"].Value = lstTransport[i].usefulHigh;
                dgvTransport.Rows[i].Cells["clmTransportusefulLong"].Value = lstTransport[i].usefulLong;
                dgvTransport.Rows[i].Cells["clmTransportGrossCapacity"].Value = lstTransport[i].GrossCapacity;

            }
        }

        #endregion

        #region "Transport Function"

        clsTransport objTransport = new clsTransport();

        public void clearTransportFields()
        {
            
            txtTransportName.BackColor = Color.White;
            txtTransportusefulWidth.BackColor = Color.White;
            txtTransportusefulHigh.BackColor = Color.White;
            txtTransportGrossCapacity.BackColor = Color.White;
            txtTransportusefulLong.BackColor = Color.White;
            lblTransportGrossCapacity.ForeColor = Color.Black;
            lblTransportName.ForeColor = Color.Black;
            lblTransportusefulHigh.ForeColor = Color.Black;
            lblTransportusefulLong.ForeColor = Color.Black;
            lblTransportusefulWidth.ForeColor = Color.Black;
            txtTransportName.Clear();
            txtTransportusefulWidth.Clear();
            txtTransportusefulHigh.Clear();
            txtTransportGrossCapacity.Clear();
            txtTransportusefulLong.Clear();
            grpbTransportForm.Enabled = false;
        }
        public bool validateFormTransport()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtTransportName, ref lblTransportName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtTransportusefulWidth, ref lblTransportusefulWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtTransportusefulHigh, ref lblTransportusefulHigh, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtTransportusefulLong, ref lblTransportusefulLong, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtTransportGrossCapacity, ref lblTransportGrossCapacity, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnTransportAdd_Click(object sender, EventArgs e)
        {
            grpbTransportForm.Enabled = true;
        }

        private void btnTransportSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormTransport())
                {
                    objTransport.name = txtTransportName.Text;
                    objTransport.usefulWidth = Convert.ToInt32(txtTransportusefulWidth.Text);
                    objTransport.usefulHigh = Convert.ToInt32(txtTransportusefulHigh.Text);
                    objTransport.usefulLong = Convert.ToInt32(txtTransportusefulLong.Text);
                    objTransport.GrossCapacity = Convert.ToDouble(txtTransportGrossCapacity.Text);

                    if (objTransport.save())
                    {
                        grpbTransportForm.Enabled = false;
                        MessageBox.Show("El transporte se ha guardado con éxito.", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadTransportInfo();
                        clearTransportFields();
                        objTransport = new clsTransport();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnTransportEdit_Click(object sender, EventArgs e)
        {
            grpbTransportForm.Enabled = true;
            objTransport.load(Convert.ToInt32(dgvTransport.SelectedRows[0].Cells["clmTransportCodsec"].Value.ToString()));
            txtTransportName.Text = objTransport.name;
            txtTransportusefulWidth.Text = objTransport.usefulWidth.ToString();
            txtTransportusefulHigh.Text = objTransport.usefulHigh.ToString();
            txtTransportusefulLong.Text = objTransport.usefulLong.ToString();
            txtTransportGrossCapacity.Text = objTransport.GrossCapacity.ToString();
            
        }

        private void btnTransportCancel_Click(object sender, EventArgs e)
        {
            clearTransportFields();
        }
        #endregion


        #region "Id Type Info"

        public void loadIdTypeInfo()
        {
            List<clsIdType> lstIdType = new List<clsIdType>();

            grpbidtypeList.Enabled = true;
            grpbidtypeForm.Enabled = false;

            lstIdType.Clear();
            lstIdType = clsIdType.getList();

            dgvIdType.Rows.Clear();


            for (int i = 0; i < lstIdType.Count; i++)
            {
                dgvIdType.Rows.Add();
                dgvIdType.Rows[i].Cells["clmIdTypeCodsec"].Value = lstIdType[i].codsec.ToString();
                dgvIdType.Rows[i].Cells["clmIdTypeName"].Value = lstIdType[i].name;
               
            }
        }


        #endregion

        #region "Id Type Function"


        clsIdType objIdType = new clsIdType();

        public void clearIdTypeFields()
        {

            txtIdtypeName.BackColor = Color.White;
            lblIdtypeName.ForeColor = Color.Black;
            txtIdtypeName.Clear();
            grpbidtypeForm.Enabled = false;
        }
        public bool validateFormIdType()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtIdtypeName, ref lblIdtypeName, "notEmpty")) isValid = false;
            
            return isValid;
        }


        private void btnIdTypeAdd_Click(object sender, EventArgs e)
        {
            grpbidtypeForm.Enabled = true;
        }

        private void btnIdTypeSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormIdType())
                {
                    objIdType.name = txtIdtypeName.Text;


                    if (objIdType.save())
                    {
                        grpbidtypeForm.Enabled = false;
                        MessageBox.Show("El tipo de documento se ha guardado con éxito.", "Tipo Documento", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadIdTypeInfo();
                        clearIdTypeFields();
                        objIdType = new clsIdType();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipo Documento", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipo Documento", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnIdTypeEdit_Click(object sender, EventArgs e)
        {
            grpbidtypeForm.Enabled = true;
            objIdType.load(Convert.ToInt32(dgvIdType.SelectedRows[0].Cells["clmIdTypeCodsec"].Value.ToString()));
            txtIdtypeName.Text = objIdType.name;
            
        }

        private void btnIdTypeCancel_Click(object sender, EventArgs e)
        {
            clearIdTypeFields();
        }

        #endregion

        #region "Plant Info"

        public void loadPlantInfo()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            grpbPlantList.Enabled = true;
            grpbPlantForm.Enabled = false;

            lstPlant.Clear();
            lstPlant = clsPlant.getList();

            dgvPlant.Rows.Clear();


            for (int i = 0; i < lstPlant.Count; i++)
            {
                dgvPlant.Rows.Add();
                dgvPlant.Rows[i].Cells["clmPlantCodsec"].Value = lstPlant[i].codsec.ToString();
                dgvPlant.Rows[i].Cells["clmPlantName"].Value = lstPlant[i].name;

            }
        }
     

        #endregion

        #region "Plant Function"

        clsPlant objPlant = new clsPlant();

        public void clearPlantFields()
        {

            txtPlantName.BackColor = Color.White;
            lblPlantName.ForeColor = Color.Black;
            txtPlantName.Clear();
            grpbPlantForm.Enabled = false;
        }
        public bool validateFormPlant()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtPlantName, ref lblPlantName, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnPlantAdd_Click(object sender, EventArgs e)
        {
            grpbPlantForm.Enabled = true;
        }

        private void btnPlantSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormPlant())
                {
                    objPlant.name = txtPlantName.Text;


                    if (objPlant.save())
                    {
                        grpbPlantForm.Enabled = false;
                        MessageBox.Show("La planta se ha guardado con éxito.", "Plantas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadPlantInfo();
                        clearPlantFields();
                        objPlant = new clsPlant();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Plantas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Plantas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnPlantEdit_Click(object sender, EventArgs e)
        {
            grpbPlantForm.Enabled = true;
            objPlant.load(Convert.ToInt32(dgvPlant.SelectedRows[0].Cells["clmPlantCodsec"].Value.ToString()));
            txtPlantName.Text = objPlant.name;
        }

        private void btnPlantCancel_Click(object sender, EventArgs e)
        {
            clearPlantFields();
        }

        #endregion

        #region "Layer Info"

        public void loadLayerInfo()
        {
            List<clsLayer> lstLayer = new List<clsLayer>();

            grpbLayerList.Enabled = true;
            grpbLayerForm.Enabled = false;

            lstLayer.Clear();
            lstLayer = clsLayer.getList();

            dgvLayer.Rows.Clear();


            for (int i = 0; i < lstLayer.Count; i++)
            {
                dgvLayer.Rows.Add();  
                dgvLayer.Rows[i].Cells["clmLayerCodsec"].Value = lstLayer[i].codsec.ToString();
                dgvLayer.Rows[i].Cells["clmLayerName"].Value = lstLayer[i].name;
                //dgvLayer.Rows[i].Cells["clmLayerDescription"].Value = lstLayer[i].description;
                
            }
        }
            

        #endregion

        #region "Layer Function"

        clsLayer objLayer = new clsLayer();


        public void clearLayerFields()
        {
            
            txtLayerName.BackColor = Color.White;
            txtLayerDescription.BackColor = Color.White;
            lblLayerName.ForeColor = Color.Black;
            lblLayerDescription.ForeColor = Color.Black;
            txtLayerName.Clear();
            txtLayerDescription.Clear();
            grpbLayerForm.Enabled = false;
        }

        public bool validateFormLayer()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtLayerName, ref lblLayerName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtLayerDescription, ref lblLayerDescription, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnLayerAdd_Click(object sender, EventArgs e)
        {
            grpbLayerForm.Enabled = true;
        }

        private void btnLayerSave_Click(object sender, EventArgs e)
        {
            try
            {  


                if (validateFormLayer())
                {
                    objLayer.name = txtLayerName.Text;
                    //objLayer.description = txtLayerDescription.Text;

                    if (objLayer.save())
                    {
                        grpbLayerForm.Enabled = false;
                        MessageBox.Show("La capa se ha guardado con éxito.", "Capas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadLayerInfo();
                        clearLayerFields();
                        objLayer = new clsLayer();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Capas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Capas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }
        private void btnLayerEdit_Click(object sender, EventArgs e)
        {
            grpbLayerForm.Enabled = true;
            objLayer.load(Convert.ToInt32(dgvLayer.SelectedRows[0].Cells["clmLayerCodsec"].Value.ToString()));
            txtLayerName.Text = objLayer.name;
            //txtLayerDescription.Text = objLayer.description;
        }
        private void btnLayerCancel_Click(object sender, EventArgs e)
        {
            clearLayerFields();
        }

        private void btnLayerDelete_Click(object sender, EventArgs e)
        {

        }

        


        
        
        #endregion


        #region "Cellar Info"

        public void loadCellarInfo()
        {
            List<clsCellar> lstCellar = new List<clsCellar>();

            grpbCellarList.Enabled = true;
            grpbCellarForm.Enabled = false;

            lstCellar.Clear();
            lstCellar = clsCellar.getList();

            dgvCellar.Rows.Clear();


            for (int i = 0; i < lstCellar.Count; i++)
            {
                dgvCellar.Rows.Add();  
                dgvCellar.Rows[i].Cells["clmCellarCodsec"].Value = lstCellar[i].codsec.ToString();
                dgvCellar.Rows[i].Cells["clmCellarNombre"].Value = lstCellar[i].name;
                dgvCellar.Rows[i].Cells["clmCellarDescription"].Value = lstCellar[i].description;

            }
        
        }

        #endregion

        #region "Cellar Function"


        clsCellar objCellar = new clsCellar();


        public void clearCellarFields()
        {
            
            txtCellarName.BackColor = Color.White;
            lblCellarName.ForeColor = Color.Black;
            txtCellarName.Clear();
            txtCellarDescription.BackColor = Color.White;
            lblCellarDescription.ForeColor = Color.Black;
            txtCellarDescription.Clear();
            grpbCellarForm.Enabled = false;
        }
        public bool validateFormCellar()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCellarName, ref lblCellarName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCellarDescription, ref lblCellarDescription, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnAddCellar_Click(object sender, EventArgs e)
        {
            grpbCellarForm.Enabled = true;
            
        }

        private void btnSaveCellar_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormCellar())
                {
                    objCellar.name = txtCellarName.Text;
                    objCellar.description = txtCellarDescription.Text;

                    if (objCellar.save())
                    {
                        grpbCellarForm.Enabled = false;
                        MessageBox.Show("El depósito se ha guardado con éxito.", "Depósitos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadCellarInfo();
                        clearCellarFields();
                        objCellar = new clsCellar();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Depósitos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Depósitos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnEditCellar_Click(object sender, EventArgs e)
        {
            grpbCellarForm.Enabled = true;
            objCellar.load(Convert.ToInt32(dgvCellar.SelectedRows[0].Cells["clmCellarCodsec"].Value.ToString()));
            txtCellarName.Text = objCellar.name;
            txtCellarDescription.Text = objCellar.description;
        }

        private void btnCancelCellar_Click(object sender, EventArgs e)
        {
            clearCellarFields();
        }


        #endregion


        #region "Sector Info"

        public void loadSectorInfo()
        {
            List<clsSector> lstSector = new List<clsSector>();

            grpbSectorList.Enabled = true;
            grpbSectorForm.Enabled = false;

            lstSector.Clear();
            lstSector = clsSector.getList();

            dgvSector.Rows.Clear();


            for (int i = 0; i < lstSector.Count; i++)
            {
                dgvSector.Rows.Add();
                dgvSector.Rows[i].Cells["clmSectorCodsec"].Value = lstSector[i].codsec.ToString();
                dgvSector.Rows[i].Cells["clmSectorName"].Value = lstSector[i].name;
                dgvSector.Rows[i].Cells["clmSectorPlantName"].Value = lstSector[i].plantName;

            }
        }
        #endregion

        #region "Sector Function"

        clsSector objSector = new clsSector();
        

        public void clearSectorFields()
        {

            txtSectorName.BackColor = Color.White;
            lblSectorName.ForeColor = Color.Black;
            txtSectorName.Clear();
            grpbSectorForm.Enabled = false;
        }
        public bool validateFormSector()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtSectorName, ref lblSectorName, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnSectorAdd_Click(object sender, EventArgs e)
        {
            grpbSectorForm.Enabled = true;
            rdoOnePlant.Checked = true;
            List<clsPlant> lstPlant = new List<clsPlant>();
            lstPlant = clsPlant.getList();

            lstbPlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                lstbPlant.Items.Add(lstPlant[i]);
            }
        }

        private void rdoOnePlant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOnePlant.Checked == false)
            {
                lstbPlant.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
             
            }
            else
            {
                lstbPlant.SelectedIndex = -1;
                lstbPlant.SelectionMode = System.Windows.Forms.SelectionMode.One;
               
            }
        }
       
        private void btnSectorSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormSector())
                {
                    if (rdoOnePlant.Checked == true)
                    {

                        objSector.name = txtSectorName.Text;

                        if (objSector.save())
                        {
                            if (objSector.codsec == 0)
                                objSector.codsec = objSector.getLastSavedCodsec();

                            clsSectorPlant.clearSectorByPlant(objSector.codsec);

                            clsSectorPlant.save(objSector.codsec, ((clsPlant)lstbPlant.SelectedItem).codsec);


                            grpbSectorForm.Enabled = false;
                            MessageBox.Show("El sector se ha guardado con éxito.", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            loadSectorInfo();
                            clearSectorFields();
                            objSector = new clsSector();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    }
                    else
                    {
                        objSector.name = txtSectorName.Text;
                        if (objSector.save())
                        {
                            if (objSector.codsec == 0)
                                objSector.codsec = objSector.getLastSavedCodsec();

                            clsSectorPlant.clearSectorByPlant(objSector.codsec);
                            for (int i = 0; i < lstbPlant.SelectedItems.Count; i++)
                            {
                                clsSectorPlant.save(objSector.codsec, Convert.ToInt32(((clsPlant)lstbPlant.SelectedItems[i]).codsec));
                            }

                            grpbSectorForm.Enabled = false;
                            MessageBox.Show("El sector se ha guardado con éxito.", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            loadSectorInfo();
                            clearSectorFields();
                            objSector = new clsSector();
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Sectores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    }
            }
        }
            catch (Exception ex)
             {
                 clsLog.addLog(ex, 3, this.Name);
                 MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                 throw;
             }
                       
        }

        private void btnSectorEdit_Click(object sender, EventArgs e)
        {
            

            grpbSectorForm.Enabled = true;
            objSector.load(Convert.ToInt32(dgvSector.SelectedRows[0].Cells["clmSectorCodsec"].Value.ToString()));
            List<clsPlant> lstSectorPlant = new List<clsPlant>();
            lstSectorPlant = clsPlant.getListPlantBySector(objSector.codsec);
            txtSectorName.Text = objSector.name;
            
            List<clsPlant> lstPlant = new List<clsPlant>();
            lstPlant = clsPlant.getList();

            lstbPlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                lstbPlant.Items.Add(lstPlant[i]);
            }
            
            for (int i = 0; i < lstbPlant.Items.Count; i++)
            {
                  for (int j = 0; j < lstSectorPlant.Count; j++)
                   {
                    if (((clsPlant)lstbPlant.Items[i]).codsec == Convert.ToInt32(((clsPlant)lstSectorPlant[j]).codsec))
                    {
                        lstbPlant.SelectedIndex = j;    
                       
                    } 
                }
                
            }


           
        }

        private void btnSectorCancel_Click(object sender, EventArgs e)
        {
            clearSectorFields();
        }

        #endregion

        #region "Machines"

       

        #region "Mill Info"

        public void loadMillInfo()
        {

            List<clsMill> lstMill = new List<clsMill>();

            grpbMillForm.Enabled = false;
            grpbMillList.Enabled = true;

            lstMill.Clear();
            lstMill = clsMill.getList();

            dgvMill.Rows.Clear();

            for (int i = 0; i < lstMill.Count; i++)
            {
                dgvMill.Rows.Add();
                dgvMill.Rows[i].Cells["clmMillCodsec"].Value = lstMill[i].codsec.ToString();
                dgvMill.Rows[i].Cells["clmMillName"].Value = lstMill[i].name;
                dgvMill.Rows[i].Cells["clmMillKilogramsPerHour"].Value = lstMill[i].kilogramsPerHour.ToString();
                dgvMill.Rows[i].Cells["clmMillSector"].Value = lstMill[i].SectorName;
                dgvMill.Rows[i].Cells["clmMillPlant"].Value = lstMill[i].PlantName;
                dgvMill.Rows[i].Cells["clmMillStatus"].Value = lstMill[i].StatusName;
            }
        
        }

        #endregion
        

        #region "Mill Function"

        clsMill objMill = new clsMill();
        clsMachine objMachine = new clsMachine();
        clsSectorPlant objSectorPlant = new clsSectorPlant();

        private void cmbxMillPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSectorList();
        }

        public void loadSectorList()
        {
            List<clsSector> lstSector = new List<clsSector>();
            cmbxMillSector.Items.Clear();
            if (cmbxMillPlant.SelectedIndex+1 > 0)
            {
                lstSector = clsSector.getListByPlant(((clsPlant)cmbxMillPlant.SelectedItem).codsec);


                for (int i = 0; i < lstSector.Count; i++)
                {
                    cmbxMillSector.Items.Add(lstSector[i]);
                }
            }
        }


        public void loadPlantList()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            cmbxMillPlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbxMillPlant.Items.Add(lstPlant[i]);

            }
        }

        public void loadStatusMillList(string statusGroupName)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();

            lstStatus = clsStatus.getListByStatusGroupName(statusGroupName);

            cmbxMillStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbxMillStatus.Items.Add(lstStatus[i]);
            }
        }

        

        public void clearMillFields()
        {

            txtMillName.BackColor = Color.White;
            lblMillName.ForeColor = Color.Black;
            txtMillKilogramsPerHour.BackColor = Color.White;
            lblMillKilogramsPerHour.ForeColor = Color.Black;
            lblMillSector.ForeColor = Color.Black;
            lblMillStatus.ForeColor = Color.Black;
            lblMillPlant.ForeColor = Color.Black;
            txtMillName.Clear();
            txtMillKilogramsPerHour.Clear();
            grpbMillForm.Enabled = false;
            cmbxMillStatus.SelectedIndex = -1;
            cmbxMillPlant.SelectedIndex = -1;
            cmbxMillSector.SelectedIndex = -1;
        }
        public bool validateFormMill()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtMillName, ref lblMillName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMillKilogramsPerHour, ref lblMillKilogramsPerHour, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbxMillSector, ref lblMillSector, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxMillStatus, ref lblMillStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxMillPlant, ref lblMillPlant, "selected")) isValid = false;

            return isValid;
        }


        private void btnMillAdd_Click(object sender, EventArgs e)
        {
            grpbMillForm.Enabled = true;
            objMill = new clsMill();
            loadPlantList();
            loadStatusMillList("Maquinas");
         }


        private void btnMillSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormMill())
                {
                    objMill.name = txtMillName.Text;
                    objMill.kilogramsPerHour = Convert.ToInt32(txtMillKilogramsPerHour.Text);

                    if (objMill.save())
                    {
                        if (objMill.codsec == 0)
                            objMill.codsec = objMill.getLastSavedCodsec();
                        else
                        objMachine.getMillDetail(objMill.codsec);

                        objMachine.save("Mill", Convert.ToInt32(objMill.codsec), (((clsSector)cmbxMillSector.SelectedItem).codsec),(((clsStatus)cmbxMillStatus.SelectedItem).codsec));
                        
                        grpbMillForm.Enabled = false;
                        MessageBox.Show("El molino se ha guardado con éxito.", "Molinos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadMillInfo();
                        clearMillFields();
                        objMill = new clsMill();
                        objMachine = new clsMachine();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Molinos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Molinos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }

                    
        }

        private void btnMillEdit_Click(object sender, EventArgs e)
        {
            grpbMillForm.Enabled = true;
            objMill.load(Convert.ToInt32(dgvMill.SelectedRows[0].Cells["clmMillCodsec"].Value.ToString()));
            txtMillName.Text = objMill.name;
            txtMillKilogramsPerHour.Text = objMill.kilogramsPerHour.ToString();
            loadPlantList();
            loadStatusMillList("Maquinas");

            for (int i = 0; i < cmbxMillPlant.Items.Count; i++)
            {
                if (((clsPlant)cmbxMillPlant.Items[i]).codsec == objMill.fkPlant)
                {
                    cmbxMillPlant.SelectedIndex = i;
                }
            }
           

            for (int i = 0; i < cmbxMillSector.Items.Count; i++)
            {
                if (((clsSector)cmbxMillSector.Items[i]).codsec == objMill.fkSector)
                {
                    cmbxMillSector.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbxMillStatus.Items.Count; i++)
            {
                if (((clsStatus)cmbxMillStatus.Items[i]).codsec == objMill.fkStatus)
                {
                    cmbxMillStatus.SelectedIndex = i;
                }
            }

        }

        private void btnMillCancel_Click(object sender, EventArgs e)
        {
            clearMillFields();
        }
        #endregion

        #region "Cutter Info"

        public void loadCutterInfo()
        {

            List<clsCutter> lstCutter = new List<clsCutter>();

            grpbCutterForm.Enabled = false;
            grpbCutterList.Enabled = true;

            lstCutter.Clear();
            lstCutter = clsCutter.getList();

            dgvCutter.Rows.Clear();

            for (int i = 0; i < lstCutter.Count; i++)
            {
                dgvCutter.Rows.Add(); 
                dgvCutter.Rows[i].Cells["clmCutterCodsec"].Value = lstCutter[i].codsec.ToString();
                dgvCutter.Rows[i].Cells["clmCutterName"].Value = lstCutter[i].name;
                dgvCutter.Rows[i].Cells["clmCutterArms"].Value = lstCutter[i].arms.ToString();
                dgvCutter.Rows[i].Cells["clmCutterUtilWidth"].Value = lstCutter[i].utilWidth.ToString();
                dgvCutter.Rows[i].Cells["clmCutterMaxVelocity"].Value = lstCutter[i].maxVelocity.ToString();
                dgvCutter.Rows[i].Cells["clmCutterProductionLine"].Value = lstCutter[i].ProductionLineName;
                dgvCutter.Rows[i].Cells["clmCutterSector"].Value = lstCutter[i].SectorName;
                dgvCutter.Rows[i].Cells["clmCutterPlant"].Value = lstCutter[i].PlantName;
                dgvCutter.Rows[i].Cells["clmCutterStatus"].Value = lstCutter[i].StatusName;
            } 

        }

        #endregion

        #region "Cutter Function"

        clsCutter objCutter = new clsCutter();
  
        private void cmbxCutterPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSectorCutterList();
            loadCutterProductionLineList();
        }

        public void loadCutterProductionLineList()
        {
            List<clsProductionLine> lstProductionLine = new List<clsProductionLine>();
            cmbCutterLine.Items.Clear();
            if (cmbxCutterPlant.SelectedIndex + 1 > 0)
            {
                lstProductionLine = clsProductionLine.getListProductionLineByPlant(((clsPlant)cmbxCutterPlant.SelectedItem).codsec);

                for (int i = 0; i < lstProductionLine.Count; i++)
                {
                    cmbCutterLine.Items.Add(lstProductionLine[i]);
                }
            }
        }




        public void loadSectorCutterList()
        {
            List<clsSector> lstSector = new List<clsSector>();
            cmbxCutterSector.Items.Clear();
            if (cmbxCutterPlant.SelectedIndex + 1 > 0)
            {
                lstSector = clsSector.getListByPlant(((clsPlant)cmbxCutterPlant.SelectedItem).codsec);


                for (int i = 0; i < lstSector.Count; i++)
                {
                    cmbxCutterSector.Items.Add(lstSector[i]);
                }
            }
        }
        


        public void loadPlantCutterList()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            cmbxCutterPlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbxCutterPlant.Items.Add(lstPlant[i]);

            }
        }

        public void loadStatusCutterList(string statusGroupName)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();

            lstStatus = clsStatus.getListByStatusGroupName(statusGroupName);

            cmbxCutterStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbxCutterStatus.Items.Add(lstStatus[i]);
            }
        }



        public void clearCutterFields()
        {

            txtCutterName.BackColor = Color.White;
            lblCutterName.ForeColor = Color.Black;
            txtCutterFilmWidth.BackColor = Color.White;
            lblCutterFilmWidth.ForeColor = Color.Black;
            txtCutterArms.BackColor = Color.White;
            lblCutterArms.ForeColor = Color.Black;
            txtCutterMaxVelocity.BackColor = Color.White;
            lblCutterMaxVelocity.ForeColor = Color.Black;
            lblCutterSector.ForeColor = Color.Black;
            lblCutterStatus.ForeColor = Color.Black;
            lblCutterPlant.ForeColor = Color.Black;
            txtCutterName.Clear();
            txtCutterFilmWidth.Clear();
            txtCutterArms.Clear();
            txtCutterMaxVelocity.Clear();
            grpbCutterForm.Enabled = false;
            cmbxCutterStatus.SelectedIndex = -1;
            cmbxCutterPlant.SelectedIndex = -1;
            cmbxCutterSector.SelectedIndex = -1;
            cmbCutterLine.SelectedIndex = -1;
            lblCutterLine.ForeColor = Color.Black;
        }
        public bool validateFormCutter()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCutterName, ref lblCutterName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCutterFilmWidth, ref lblCutterFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCutterArms, ref lblCutterArms, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCutterMaxVelocity, ref lblCutterMaxVelocity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbxCutterSector, ref lblCutterSector, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxCutterStatus, ref lblCutterStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxCutterPlant, ref lblCutterPlant, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCutterLine, ref lblCutterLine, "selected")) isValid = false;

            return isValid;
        }


        private void btnCutterAdd_Click(object sender, EventArgs e)
        {
            grpbCutterForm.Enabled = true;
            objCutter = new clsCutter();
            loadPlantCutterList();
            loadStatusCutterList("Maquinas");
        }

        private void btnCutterSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormCutter())
                {
                    objCutter.name = txtCutterName.Text;
                    objCutter.arms = Convert.ToInt32(txtCutterArms.Text);
                    objCutter.utilWidth = Convert.ToInt32(txtCutterFilmWidth.Text);
                    objCutter.maxVelocity = Convert.ToInt32(txtCutterMaxVelocity.Text);
                    objCutter.fkProductionLine = ((clsProductionLine)cmbCutterLine.SelectedItem).codsec;

                    if (objCutter.save())
                    {
                        if (objCutter.codsec == 0)
                            objCutter.codsec = objCutter.getLastSavedCodsec();
                        else
                            objMachine.getCutterDetail(objCutter.codsec);

                        objMachine.save("Cutter", Convert.ToInt32(objCutter.codsec), (((clsSector)cmbxCutterSector.SelectedItem).codsec), (((clsStatus)cmbxCutterStatus.SelectedItem).codsec));

                        grpbCutterForm.Enabled = false;
                        MessageBox.Show("La cortadora se ha guardado con éxito.", "Cortadoras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadCutterInfo();
                        clearCutterFields();
                        objCutter = new clsCutter();
                        objMachine = new clsMachine();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cortadoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cortadoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCutterEdit_Click(object sender, EventArgs e)
        {
            grpbCutterForm.Enabled = true;
            objCutter.load(Convert.ToInt32(dgvCutter.SelectedRows[0].Cells["clmCutterCodsec"].Value.ToString()));
            txtCutterName.Text = objCutter.name;
            txtCutterArms.Text = objCutter.arms.ToString();
            txtCutterFilmWidth.Text = objCutter.utilWidth.ToString();
            txtCutterMaxVelocity.Text = objCutter.maxVelocity.ToString();
            loadPlantCutterList();
            loadStatusCutterList("Maquinas");


            for (int i = 0; i < cmbCutterLine.Items.Count; i++)
            {
                if (((clsProductionLine)cmbCutterLine.Items[i]).codsec == objCutter.fkProductionLine)
                {
                    cmbCutterLine.SelectedIndex = i;
                }
            }
            cmbCutterLine.Text = objCutter.ProductionLineName;

            for (int i = 0; i < cmbxCutterPlant.Items.Count; i++)
            {
                if (((clsPlant)cmbxCutterPlant.Items[i]).codsec == objCutter.fkPlant)
                {
                    cmbxCutterPlant.SelectedIndex = i;
                }
            }


            for (int i = 0; i < cmbxCutterSector.Items.Count; i++)
            {
                if (((clsSector)cmbxCutterSector.Items[i]).codsec == objCutter.fkSector)
                {
                    cmbxCutterSector.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbxCutterStatus.Items.Count; i++)
            {
                if (((clsStatus)cmbxCutterStatus.Items[i]).codsec == objCutter.fkStatus)
                {
                    cmbxCutterStatus.SelectedIndex = i;
                }
            }
        }

        private void btnCutterCancel_Click(object sender, EventArgs e)
        {
            clearCutterFields();
        }


        #endregion

        

        #region "CoilerInfo"
        
        private void loadCoilerInfo()
        {
            List<clsExtruder> lstExtruder = new List<clsExtruder>();

            lstExtruder.Clear();
            lstExtruder = clsExtruder.getList();

            dgvCoilers.Rows.Clear();

            for (int i = 0; i < lstExtruder.Count; i++)
            {
                if (lstExtruder[i].coilersNumbers.Count > 0 && lstExtruder[i].coilersNumbers.Count == lstExtruder[i].coilNumber)
                {
                    for (int j = 0; j < lstExtruder[i].coilersNumbers.Count; j++)
                    {
                        dgvCoilers.Rows.Add();
                        dgvCoilers.Rows[dgvCoilers.Rows.Count - 1].Cells[clmCoilerExtruderCodsec.Index].Value = lstExtruder[i].codsec.ToString();
                        dgvCoilers.Rows[dgvCoilers.Rows.Count - 1].Cells[clmCoilerMachineName.Index].Value = lstExtruder[i].name;
                        dgvCoilers.Rows[dgvCoilers.Rows.Count - 1].Cells[clmCoilerNumber.Index].Value = lstExtruder[i].coilersNumbers[j].ToString();

                    }
                }
                else
                {
                    for (int j = 0; j < lstExtruder[i].coilNumber; j++)
                    {
                        dgvCoilers.Rows.Add();
                        dgvCoilers.Rows[dgvCoilers.Rows.Count - 1].Cells[clmCoilerExtruderCodsec.Index].Value = lstExtruder[i].codsec.ToString();
                        dgvCoilers.Rows[dgvCoilers.Rows.Count - 1].Cells[clmCoilerMachineName.Index].Value = lstExtruder[i].name;
                        dgvCoilers.Rows[dgvCoilers.Rows.Count - 1].Cells[clmCoilerNumber.Index].Value = "";
                    }
                }
            }
        }

        #endregion

        #region "Coiler Function"
        
        private void btnSaveCoiler_Click(object sender, EventArgs e)
        {
            int extruderCodsec = 0;
            List<int> lstCoilNumbers = new List<int>();

            for (int i = 0; i < dgvCoilers.Rows.Count; i++)
            {
                if (extruderCodsec != 0 && extruderCodsec != Convert.ToInt32(dgvCoilers.Rows[i].Cells[clmCoilerExtruderCodsec.Index].Value))
                {
                    clsExtruder.saveExtruderCoilersNumbers(extruderCodsec, lstCoilNumbers);
                    lstCoilNumbers.Clear();
                    extruderCodsec = Convert.ToInt32(dgvCoilers.Rows[i].Cells[clmCoilerExtruderCodsec.Index].Value);
                    lstCoilNumbers.Add(Convert.ToInt32(dgvCoilers.Rows[i].Cells[clmCoilerNumber.Index].Value));
                }
                else
                {
                    extruderCodsec = Convert.ToInt32(dgvCoilers.Rows[i].Cells[clmCoilerExtruderCodsec.Index].Value);
                    lstCoilNumbers.Add(Convert.ToInt32(dgvCoilers.Rows[i].Cells[clmCoilerNumber.Index].Value));
                }
            }
            clsExtruder.saveExtruderCoilersNumbers(extruderCodsec, lstCoilNumbers);
        }

        #endregion
        #region "Extruder Info"


        public void loadExtruderInfo()
            {

                List<clsExtruder> lstExtruder = new List<clsExtruder>();

                
                grpbExtruderForm.Enabled = false;
                grpbExtruderList.Enabled = true;

                lstExtruder.Clear();
                lstExtruder = clsExtruder.getList();

                dgvExtruder.Rows.Clear();

                for (int i = 0; i < lstExtruder.Count; i++)
                {
                    dgvExtruder.Rows.Add();
                    dgvExtruder.Rows[i].Cells["clmExtruderCodsec"].Value = lstExtruder[i].codsec.ToString();
                    dgvExtruder.Rows[i].Cells["clmExtruderName"].Value = lstExtruder[i].name;
                    dgvExtruder.Rows[i].Cells["clmExtruderminFilmWidth"].Value = lstExtruder[i].minFilmWidth.ToString();
                    dgvExtruder.Rows[i].Cells["clmExtrudermaxFilmWidth"].Value = lstExtruder[i].maxFilmWidth.ToString();
                    dgvExtruder.Rows[i].Cells["clmExtrudermaxVelocity"].Value = lstExtruder[i].maxVelocity.ToString();
                    dgvExtruder.Rows[i].Cells["clmExtruderCoilNumber"].Value = lstExtruder[i].coilNumber.ToString();
                    dgvExtruder.Rows[i].Cells["clmExtruderKilogramsPerHour"].Value = lstExtruder[i].kilogramsPerHour.ToString();
                    dgvExtruder.Rows[i].Cells["clmExtruderSector"].Value = lstExtruder[i].SectorName;
                    dgvExtruder.Rows[i].Cells["clmExtruderPlant"].Value = lstExtruder[i].PlantName;
                    dgvExtruder.Rows[i].Cells["clmExtruderProductionLine"].Value = lstExtruder[i].ProductionLineName;
                    dgvExtruder.Rows[i].Cells["clmExtruderStatus"].Value = lstExtruder[i].StatusName;
                }
                
            }
        #endregion
        #region "Extruder Function"

        clsExtruder objExtruder = new clsExtruder();


        private void cmbxExtruderPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSectorExtruderList();
            loadExtruderProductionLineList();
        }


        public void loadSectorExtruderList()
        {
            
            List<clsSector> lstSector = new List<clsSector>();
            cmbxExtruderSector.Items.Clear();
            if (cmbxExtruderPlant.SelectedIndex + 1 > 0)
            {
                lstSector = clsSector.getListByPlant(((clsPlant)cmbxExtruderPlant.SelectedItem).codsec);


                for (int i = 0; i < lstSector.Count; i++)
                {
                    cmbxExtruderSector.Items.Add(lstSector[i]);
                }
            }

        
        }

        public void loadExtruderProductionLineList()
        {
            List<clsProductionLine> lstProductionLine = new List<clsProductionLine>();
            cmbExtruderLine.Items.Clear();
            if (cmbxExtruderPlant.SelectedIndex + 1 > 0)
            {
                lstProductionLine = clsProductionLine.getListProductionLineByPlant(((clsPlant)cmbxExtruderPlant.SelectedItem).codsec);

                for (int i = 0; i < lstProductionLine.Count; i++)
                {
                    cmbExtruderLine.Items.Add(lstProductionLine[i]);
                }
            }
        }


        public void loadPlantExtruderList()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            cmbxExtruderPlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbxExtruderPlant.Items.Add(lstPlant[i]);

            }
        }

        public void loadStatusExtruderList(string statusGroupName)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();

            lstStatus = clsStatus.getListByStatusGroupName(statusGroupName);

            cmbxExtruderStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbxExtruderStatus.Items.Add(lstStatus[i]);
            }
        }



        public void clearExtruderFields()
        {

            txtExtruderName.BackColor = Color.White;
            lblExtruderName.ForeColor = Color.Black;
            txtExtruderMinFilmWidth.BackColor = Color.White;
            lblExtruderMinFilmWidth.ForeColor = Color.Black;
            txtExtruderMaxFilmWidth.BackColor = Color.White;
            lblExtruderMaxFilmWidth.ForeColor = Color.Black;
            txtExtruderMaxVelocity.BackColor = Color.White;
            lblExtruderMaxVelocity.ForeColor = Color.Black;
            txtExtruderCoilNumber.BackColor = Color.White;
            lblExtruderCoilNumber.ForeColor = Color.Black;
            txtExtruderKilogramsPerHour.BackColor = Color.White;
            lblExtruderKilogramsPerHour.ForeColor = Color.Black;
            lblExtruderSector.ForeColor = Color.Black;
            lblExtruderStatus.ForeColor = Color.Black;
            lblExtruderPlant.ForeColor = Color.Black;
            lblExtruderLine.ForeColor = Color.Black;
            txtExtruderName.Clear();
            txtExtruderMinFilmWidth.Clear();
            txtExtruderMaxFilmWidth.Clear();
            txtExtruderMaxVelocity.Clear();
            txtExtruderCoilNumber.Clear();
            txtExtruderKilogramsPerHour.Clear();
            grpbExtruderForm.Enabled = false; 
            cmbxExtruderStatus.SelectedIndex = -1;
            cmbxExtruderPlant.SelectedIndex = -1;
            cmbxExtruderSector.SelectedIndex = -1;
            cmbProductionLinePlant.SelectedIndex = -1;
            
        }
        public bool validateFormExtruder()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtExtruderName, ref lblExtruderName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtExtruderMinFilmWidth, ref lblExtruderMinFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtExtruderMaxFilmWidth, ref lblExtruderMaxFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtExtruderMaxVelocity, ref lblExtruderMaxVelocity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtExtruderCoilNumber, ref lblExtruderCoilNumber, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtExtruderKilogramsPerHour, ref lblExtruderKilogramsPerHour, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbxExtruderSector, ref lblExtruderSector, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxExtruderStatus, ref lblExtruderStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxExtruderPlant, ref lblExtruderPlant, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbExtruderLine, ref lblExtruderLine, "selected")) isValid = false;

            return isValid;
        }

        private void btnExtruderAdd_Click(object sender, EventArgs e)
        {
            grpbExtruderForm.Enabled = true; 
            objExtruder = new clsExtruder();
            loadPlantExtruderList();
            loadStatusExtruderList("Maquinas");
        }

        private void btnExtruderSave_Click(object sender, EventArgs e)
        {
            try
            {
                 
                if (validateFormExtruder())
                {
                    objExtruder.name = txtExtruderName.Text;
                    objExtruder.minFilmWidth = Convert.ToInt32(txtExtruderMinFilmWidth.Text);
                    objExtruder.maxFilmWidth = Convert.ToInt32(txtExtruderMaxFilmWidth.Text);
                    objExtruder.maxVelocity = Convert.ToInt32(txtExtruderMaxVelocity.Text);
                    objExtruder.coilNumber = Convert.ToInt32(txtExtruderCoilNumber.Text);
                    objExtruder.kilogramsPerHour = Convert.ToInt32(txtExtruderKilogramsPerHour.Text);
                    objExtruder.fkProductionLine = ((clsProductionLine)cmbExtruderLine.SelectedItem).codsec;
                    

                    if (objExtruder.save())
                    {
                        if (objExtruder.codsec == 0)
                            objExtruder.codsec = objExtruder.getLastSavedCodsec();
                        else
                            objMachine.getExtruderDetail(objExtruder.codsec);

                        objMachine.save("Extruder", Convert.ToInt32(objExtruder.codsec), (((clsSector)cmbxExtruderSector.SelectedItem).codsec), (((clsStatus)cmbxExtruderStatus.SelectedItem).codsec));

                        grpbExtruderForm.Enabled = false;
                        MessageBox.Show("La extrusora se ha guardado con éxito.", "Extrusoras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadExtruderInfo();
                        clearExtruderFields(); 
                        objExtruder = new clsExtruder();
                        objMachine = new clsMachine();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Extrusoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Extrusoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnExtruderEdit_Click(object sender, EventArgs e)
        {
            grpbExtruderForm.Enabled = true;
            objExtruder.load(Convert.ToInt32(dgvExtruder.SelectedRows[0].Cells["clmExtruderCodsec"].Value.ToString()));
            txtExtruderName.Text = objExtruder.name;
            txtExtruderMinFilmWidth.Text = objExtruder.minFilmWidth.ToString();
            txtExtruderMaxFilmWidth.Text = objExtruder.maxFilmWidth.ToString();
            txtExtruderMaxVelocity.Text = objExtruder.maxVelocity.ToString();
            txtExtruderCoilNumber.Text = objExtruder.coilNumber.ToString();
            txtExtruderKilogramsPerHour.Text = objExtruder.kilogramsPerHour.ToString();
            loadPlantExtruderList();
            loadStatusExtruderList("Maquinas");


            for (int i = 0; i < cmbExtruderLine.Items.Count; i++)
            {
                if (((clsProductionLine)cmbExtruderLine.Items[i]).codsec == objExtruder.fkProductionLine)
                {
                    cmbExtruderLine.SelectedIndex = i;
                }
            }
            cmbExtruderLine.Text = objExtruder.ProductionLineName;
             

            for (int i = 0; i < cmbxExtruderPlant.Items.Count; i++)
            {
                if (((clsPlant)cmbxExtruderPlant.Items[i]).codsec == objExtruder.fkPlant)
                {
                    cmbxExtruderPlant.SelectedIndex = i;
                }
            }


            for (int i = 0; i < cmbxExtruderSector.Items.Count; i++)
            {
                if (((clsSector)cmbxExtruderSector.Items[i]).codsec == objExtruder.fkSector)
                {
                    cmbxExtruderSector.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbxExtruderStatus.Items.Count; i++)
            {
                if (((clsStatus)cmbxExtruderStatus.Items[i]).codsec == objExtruder.fkStatus)
                {
                    cmbxExtruderStatus.SelectedIndex = i;
                }
            }
        }

        private void btnExtruderCancel_Click(object sender, EventArgs e)
        {
            clearExtruderFields();
        }

        #endregion


        #region "Cellar By Extruder Info"


        public void loadCellarByExtruderInfo()
        {

            List<clsCellarByExtruder> lstCellarByExtruder = new List<clsCellarByExtruder>();


            grpbCellarByExtruderForm.Enabled = false;
            grpbCellarByExtruderList.Enabled = true;

            lstCellarByExtruder.Clear();
            lstCellarByExtruder = clsCellarByExtruder.getList();


            dgvCellarbyMachine.Rows.Clear();

            for (int i = 0; i < lstCellarByExtruder.Count; i++)
            {
                dgvCellarbyMachine.Rows.Add();
                dgvCellarbyMachine.Rows[i].Cells["clmCellarByExtruderCodsec"].Value = lstCellarByExtruder[i].codsec.ToString();
                dgvCellarbyMachine.Rows[i].Cells["clmCellarByExtruderCellarName"].Value = lstCellarByExtruder[i].cellarName;
                dgvCellarbyMachine.Rows[i].Cells["clmCellarByExtruderExtName"].Value = lstCellarByExtruder[i].extruderName;
                
            }

        }
        #endregion

        #region "Extruder Function"

        clsCellarByExtruder objCellarByExtruder = new clsCellarByExtruder();

        public void loadExtruderList()
        {
            List<clsExtruder> lstExtruder = new List<clsExtruder>();

            lstExtruder = clsExtruder.getList();

            cmbCellarByExtLineName.Items.Clear();
            for (int i = 0; i < lstExtruder.Count; i++)
            {
                cmbCellarByExtLineName.Items.Add(lstExtruder[i]);
            }
        }


        public void loadCellarList()
        {
            List<clsCellar> lstCellar = new List<clsCellar>();

            lstCellar = clsCellar.getList();

            cmbCellarByExtCellarName.Items.Clear();
            for (int i = 0; i < lstCellar.Count; i++)
            {
                cmbCellarByExtCellarName.Items.Add(lstCellar[i]);
            }
        }



        public void clearCellatByExtruderFields()
        {

            lblCellarByExtCellarName.ForeColor = Color.Black;
            lblCellarByExtLineName.ForeColor = Color.Black;
            grpbCellarByExtruderForm.Enabled = false;
            cmbCellarByExtCellarName.SelectedIndex = -1;
            cmbCellarByExtLineName.SelectedIndex = -1;

        }
        public bool validateFormCellarByExtruder()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbCellarByExtCellarName, ref lblCellarByExtCellarName, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCellarByExtLineName, ref lblCellarByExtLineName, "selected")) isValid = false;

            return isValid;
        }


        private void btnCellarByExtAdd_Click(object sender, EventArgs e)
        {
            grpbCellarByExtruderForm.Enabled = true;
            loadExtruderList();
            loadCellarList();

        }


        private void btnCellarByExtSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormCellarByExtruder())
                {

                    objCellarByExtruder.fkCellar = ((clsCellar)cmbCellarByExtCellarName.SelectedItem).codsec;
                    objCellarByExtruder.fkExtruder = ((clsExtruder)cmbCellarByExtLineName.SelectedItem).codsec;

                    if (objCellarByExtruder.save())
                    {
                        grpbCellarByExtruderForm.Enabled = false;
                        MessageBox.Show("La bodega ha sido vinculada con exito.", "Bodegas de Produccion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadCellarByExtruderInfo();
                        clearCellatByExtruderFields();
                        objCellarByExtruder = new clsCellarByExtruder();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bodegas de Produccion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bodegas de Produccion", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCellarByExtEdit_Click(object sender, EventArgs e)
        {
            grpbCellarByExtruderForm.Enabled = true;
            objCellarByExtruder.load(Convert.ToInt32(dgvCellarbyMachine.SelectedRows[0].Cells["clmCellarByExtruderCodsec"].Value.ToString()));
            loadExtruderList();
            loadCellarList();
            

            for (int i = 0; i < cmbCellarByExtLineName.Items.Count; i++)
            {
                if (((clsExtruder)cmbCellarByExtLineName.Items[i]).codsec == objCellarByExtruder.fkExtruder)
                {
                    cmbCellarByExtLineName.SelectedIndex = i;
                }
            }
            cmbCellarByExtLineName.Text = objCellarByExtruder.extruderName;


            for (int i = 0; i < cmbCellarByExtCellarName.Items.Count; i++)
            {
                if (((clsCellar)cmbCellarByExtCellarName.Items[i]).codsec == objCellarByExtruder.fkCellar)
                {
                    cmbCellarByExtCellarName.SelectedIndex = i;
                }
            }
            cmbCellarByExtCellarName.Text = objCellarByExtruder.cellarName;
        }

        private void btnCellarByExtCancel_Click(object sender, EventArgs e)
        {
            clearCellatByExtruderFields();
        }

        #endregion




        #region "Metallizer Info"

        public void loadMetallizerInfo()
        {

            List<clsMetallizer> lstMetallizer = new List<clsMetallizer>();

            
            grpbMetallizerForm.Enabled = false;
            grpbMetallizerList.Enabled = true;

            lstMetallizer.Clear();
            lstMetallizer = clsMetallizer.getList();

            dgvMetallizer.Rows.Clear();

            for (int i = 0; i < lstMetallizer.Count; i++)
            {
                dgvMetallizer.Rows.Add();
                dgvMetallizer.Rows[i].Cells["clmMetallizerCodsec"].Value = lstMetallizer[i].codsec.ToString();
                dgvMetallizer.Rows[i].Cells["clmMetallizerName"].Value = lstMetallizer[i].name;
                dgvMetallizer.Rows[i].Cells["clmMetallizerNumber"].Value = lstMetallizer[i].number; 
                dgvMetallizer.Rows[i].Cells["clmMetallizerMinFilmWidth"].Value = lstMetallizer[i].minFilmWidth.ToString();
                dgvMetallizer.Rows[i].Cells["clmMetallizerMaxFilmWidth"].Value = lstMetallizer[i].maxFilmWidth.ToString();
                dgvMetallizer.Rows[i].Cells["clmMetallizerMaxVelocity"].Value = lstMetallizer[i].maxVelocity.ToString();
                dgvMetallizer.Rows[i].Cells["clmMetallizerMaxDiameter"].Value = lstMetallizer[i].maxDiameter.ToString();
                dgvMetallizer.Rows[i].Cells["clmMetallizerLine"].Value = lstMetallizer[i].ProductionLineName; 
                dgvMetallizer.Rows[i].Cells["clmMetallizerSector"].Value = lstMetallizer[i].SectorName;
                dgvMetallizer.Rows[i].Cells["clmMetallizerPlant"].Value = lstMetallizer[i].PlantName;
                dgvMetallizer.Rows[i].Cells["clmMetallizerStatus"].Value = lstMetallizer[i].StatusName;
            }

        }

        #endregion

        #region "Metallizer Function"

        clsMetallizer objMetallizer = new clsMetallizer();


        private void cmbxMetallizerPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSectorMetallizerList();
            loadMetallizerProductionLineList();
        }


        public void loadMetallizerProductionLineList()
        {
            List<clsProductionLine> lstProductionLine = new List<clsProductionLine>();
            cmbMetallizerLine.Items.Clear();
            if (cmbxMetallizerPlant.SelectedIndex + 1 > 0)
            {
                lstProductionLine = clsProductionLine.getListProductionLineByPlant(((clsPlant)cmbxMetallizerPlant.SelectedItem).codsec);

                for (int i = 0; i < lstProductionLine.Count; i++)
                {
                    cmbMetallizerLine.Items.Add(lstProductionLine[i]);
                }
            }
        }

        public void loadSectorMetallizerList()
        {
            
            List<clsSector> lstSector = new List<clsSector>();
            cmbxMetallizerSector.Items.Clear();
            if (cmbxMetallizerPlant.SelectedIndex + 1 > 0)
            {
                lstSector = clsSector.getListByPlant(((clsPlant)cmbxMetallizerPlant.SelectedItem).codsec);

                
                for (int i = 0; i < lstSector.Count; i++)
                {
                    cmbxMetallizerSector.Items.Add(lstSector[i]);
                }
            }
        }



        public void loadPlantMetallizerList()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            cmbxMetallizerPlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbxMetallizerPlant.Items.Add(lstPlant[i]);

            }
        }

        public void loadStatusMetallizerList(string statusGroupName)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();

            lstStatus = clsStatus.getListByStatusGroupName(statusGroupName);

            cmbxMetallizerStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbxMetallizerStatus.Items.Add(lstStatus[i]);
            }
        }



        public void clearMetallizerFields()
        {

            txtMetallizerName.BackColor = Color.White;
            lblMetallizerName.ForeColor = Color.Black;
            txtMetalizedNumber.BackColor = Color.White;
            lblMetalizedNumber.ForeColor = Color.Black;
            txtMetallizerMinFilmWidth.BackColor = Color.White;
            lblMetallizerMinFilmWidth.ForeColor = Color.Black;
            txtMetallizerMaxFilmWidth.BackColor = Color.White;
            lblMetallizerMaxFilmWidth.ForeColor = Color.Black;
            txtMetallizerMaxVelocity.BackColor = Color.White;
            lblMetallizerMaxDiameter.ForeColor = Color.Black;
            txtMetallizerMaxDiameter.BackColor = Color.White;
            lblMetallizerMaxVelocity.ForeColor = Color.Black;
            lblMetallizerSector.ForeColor = Color.Black;
            lblMetallizerStatus.ForeColor = Color.Black;
            lblMetallizerPlant.ForeColor = Color.Black;
            txtMetallizerName.Clear();
            txtMetallizerMinFilmWidth.Clear();
            txtMetallizerMaxFilmWidth.Clear();
            txtMetallizerMaxVelocity.Clear();
            txtMetallizerMaxDiameter.Clear();
            grpbMetallizerForm.Enabled = false;
            cmbxMetallizerStatus.SelectedIndex = -1;
            cmbxMetallizerPlant.SelectedIndex = -1;
            cmbxMetallizerSector.SelectedIndex = -1;
            cmbMetallizerLine.SelectedIndex = -1;
        }
        public bool validateFormMetallizer()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtMetallizerName, ref lblMetallizerName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMetalizedNumber, ref lblMetalizedNumber, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMetallizerMinFilmWidth, ref lblMetallizerMinFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMetallizerMaxFilmWidth, ref lblMetallizerMaxFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMetallizerMaxVelocity, ref lblMetallizerMaxVelocity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMetallizerMaxDiameter, ref lblMetallizerMaxDiameter, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbxMetallizerSector, ref lblMetallizerSector, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxMetallizerStatus, ref lblMetallizerStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbxMetallizerPlant, ref lblMetallizerPlant, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbMetallizerLine, ref lblMetallizerLine, "selected")) isValid = false;

            return isValid;
        }

        

        private void btnMetallizerAdd_Click(object sender, EventArgs e)
        {
            grpbMetallizerForm.Enabled = true;
            objMetallizer = new clsMetallizer();
            loadPlantMetallizerList();
            loadStatusMetallizerList("Maquinas"); 
        }

        private void btnMetallizerSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormMetallizer())
                {
                    objMetallizer.name = txtMetallizerName.Text;
                    objMetallizer.number = txtMetalizedNumber.Text;
                    objMetallizer.minFilmWidth = Convert.ToInt32(txtMetallizerMinFilmWidth.Text);
                    objMetallizer.maxFilmWidth = Convert.ToInt32(txtMetallizerMaxFilmWidth.Text);
                    objMetallizer.maxVelocity = Convert.ToInt32(txtMetallizerMaxVelocity.Text);
                    objMetallizer.maxDiameter = Convert.ToInt32(txtMetallizerMaxDiameter.Text);
                    objMetallizer.fkProductionLine = ((clsProductionLine)cmbMetallizerLine.SelectedItem).codsec;

                    
                    if (objMetallizer.save())
                    {
                        if (objMetallizer.codsec == 0)
                            objMetallizer.codsec = objMetallizer.getLastSavedCodsec();
                        else
                            objMachine.getMetallizerDetail(objMetallizer.codsec);

                        objMachine.save("Metallizer", Convert.ToInt32(objMetallizer.codsec), (((clsSector)cmbxMetallizerSector.SelectedItem).codsec), (((clsStatus)cmbxMetallizerStatus.SelectedItem).codsec));

                        grpbMetallizerForm.Enabled = false;
                        MessageBox.Show("La metalizadora se ha guardado con éxito.", "Metalizadoras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadMetallizerInfo();
                        clearMetallizerFields(); 
                        objMetallizer = new clsMetallizer();
                        objMachine = new clsMachine();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Metalizadoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Metalizadoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnMetallizerEdit_Click(object sender, EventArgs e)
        {
            grpbMetallizerForm.Enabled = true;
            objMetallizer.load(Convert.ToInt32(dgvMetallizer.SelectedRows[0].Cells["clmMetallizerCodsec"].Value.ToString()));
            txtMetallizerName.Text = objMetallizer.name;
            txtMetalizedNumber.Text = objMetallizer.number;
            txtMetallizerMinFilmWidth.Text = objMetallizer.minFilmWidth.ToString();
            txtMetallizerMaxFilmWidth.Text = objMetallizer.maxFilmWidth.ToString();
            txtMetallizerMaxVelocity.Text = objMetallizer.maxVelocity.ToString();
            txtMetallizerMaxDiameter.Text = objMetallizer.maxDiameter.ToString();
            loadPlantMetallizerList();
            loadStatusMetallizerList("Maquinas");

            for (int i = 0; i < cmbxMetallizerPlant.Items.Count; i++)
            {
                if (((clsPlant)cmbxMetallizerPlant.Items[i]).codsec == objMetallizer.fkPlant)
                {
                    cmbxMetallizerPlant.SelectedIndex = i;
                }
            }

            
            for (int i = 0; i < cmbxMetallizerSector.Items.Count; i++)
            {
                if (((clsSector)cmbxMetallizerSector.Items[i]).codsec == objMetallizer.fkSector)
                {
                    cmbxMetallizerSector.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cmbxMetallizerStatus.Items.Count; i++)
            {
                if (((clsStatus)cmbxMetallizerStatus.Items[i]).codsec == objMetallizer.fkStatus)
                {
                    cmbxMetallizerStatus.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cmbMetallizerLine.Items.Count; i++)
            {
                if (((clsProductionLine)cmbMetallizerLine.Items[i]).codsec == objMetallizer.fkProductionLine)
                {
                    cmbMetallizerLine.SelectedIndex = i;
                }
            }
            cmbMetallizerLine.Text = objMetallizer.ProductionLineName;


        }

        private void btnMetallizerCancel_Click(object sender, EventArgs e)
        {
            clearMetallizerFields();
        }
        #endregion


        #endregion

        #region "Language Info"

        public void loadLanguageInfo()
        {
            List<clsLanguage> lstLanguage = new List<clsLanguage>();

            grpbLanguageList.Enabled = true;
            grpbLanguageForm.Enabled = false;

            lstLanguage.Clear();
            lstLanguage = clsLanguage.getList();

            dgvLanguage.Rows.Clear();


            for (int i = 0; i < lstLanguage.Count; i++)
            {
                dgvLanguage.Rows.Add();
                dgvLanguage.Rows[i].Cells["clmLanguageCodsec"].Value = lstLanguage[i].codsec.ToString();
                dgvLanguage.Rows[i].Cells["clmLanguageName"].Value = lstLanguage[i].name;
                dgvLanguage.Rows[i].Cells["clmLanguageAbbreviation"].Value = lstLanguage[i].abbreviation;
                
            }
        }




        #endregion

        #region "Language Function"

        clsLanguage objLanguage = new clsLanguage();


        public void clearLanguageFields()
        {

            txtLanguageName.BackColor = Color.White;
            txtLanguageAbbreviation.BackColor = Color.White;
            lblLanguageName.ForeColor = Color.Black;
            lblLanguageAbbreviation.ForeColor = Color.Black;
            txtLanguageName.Clear();
            txtLanguageAbbreviation.Clear();
            grpbLanguageForm.Enabled = false;
        }

        public bool validateFormLanguage()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtLanguageName, ref lblLanguageName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtLanguageAbbreviation, ref lblLanguageAbbreviation, "notEmpty")) isValid = false;
            
            return isValid;
        }


        private void btnLanguageAdd_Click(object sender, EventArgs e)
        {
            grpbLanguageForm.Enabled = true;
        }

        private void btnLanguageSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormLanguage())
                {
                    objLanguage.name = txtLanguageName.Text;
                    objLanguage.abbreviation = txtLanguageAbbreviation.Text;


                    if (objLanguage.save())
                    {
                        grpbLanguageForm.Enabled = false;
                        MessageBox.Show("El Idioma se ha guardado con éxito.", "Idiomas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadLanguageInfo();
                        clearLanguageFields();
                        objLanguage = new clsLanguage();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Idiomas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Moneda", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnLanguageEdit_Click(object sender, EventArgs e)
        {
            grpbLanguageForm.Enabled = true;
            objLanguage.load(Convert.ToInt32(dgvLanguage.SelectedRows[0].Cells["clmLanguageCodsec"].Value.ToString()));
            txtLanguageName.Text = objLanguage.name;
            txtLanguageAbbreviation.Text = objLanguage.abbreviation;           
        }

        private void btnLanguageCancel_Click(object sender, EventArgs e)
        {
            clearLanguageFields();
        }
        #endregion

        #region "Bopp Film Info"

        public void initBoppForm()
        {
            List<clsFamily> lstFamily = new List<clsFamily>();

            grpbFamilyList.Enabled = true;
            grpbFamilyForm.Enabled = false;

            lstFamily.Clear();           
            lstFamily = clsFamily.getList();

            dgvFamily.Rows.Clear();


            for (int i = 0; i < lstFamily.Count; i++)
            {
                dgvFamily.Rows.Add();
                dgvFamily.Rows[i].Cells["clmFamilyCodsec"].Value = lstFamily[i].codsec.ToString();
                dgvFamily.Rows[i].Cells["clmFamilyName"].Value = lstFamily[i].name;
                dgvFamily.Rows[i].Cells["clmFamilyAbbreviation"].Value = lstFamily[i].abbreviation;
            }

            List<clsSeal> lstSeal = new List<clsSeal>();

            grpbSealList.Enabled = true;
            grpbSealForm.Enabled = false;

            lstSeal.Clear();
            lstSeal = clsSeal.getList();
            dgvSeal.Rows.Clear();
            for (int i = 0; i < lstSeal.Count; i++)
            {
                dgvSeal.Rows.Add();
                dgvSeal.Rows[i].Cells["clmSealCodsec"].Value = lstSeal[i].codsec.ToString();
                dgvSeal.Rows[i].Cells["clmSealAbbreviation"].Value = lstSeal[i].abbreviation;
                dgvSeal.Rows[i].Cells["clmSealName"].Value = lstSeal[i].name;
                
            }

            List<clsAdditivation> lstAdditivation = new List<clsAdditivation>();

            grpbAdditivationList.Enabled = true;
            grpbAdditivationForm.Enabled = false;
            

            lstAdditivation.Clear();
            lstAdditivation = clsAdditivation.getList();
            dgvAdditivation.Rows.Clear();
            for (int i = 0; i < lstAdditivation.Count; i++)
            {
                dgvAdditivation.Rows.Add();
                dgvAdditivation.Rows[i].Cells["clmAdditivationCodsec"].Value = lstAdditivation[i].codsec.ToString();
                dgvAdditivation.Rows[i].Cells["clmAdditivationAbbreviation"].Value = lstAdditivation[i].abbreviation;
                dgvAdditivation.Rows[i].Cells["clmAdditivationName"].Value = lstAdditivation[i].name;
                if (lstAdditivation[i].isForBopp.ToString().Equals("True"))
                {
                    dgvAdditivation.Rows[i].Cells["clmAdditivationForBopp"].Value = "Si";
                }
                else
                {
                    dgvAdditivation.Rows[i].Cells["clmAdditivationForBopp"].Value = "No";
                }
                if (lstAdditivation[i].isForCpp.ToString().Equals("True"))
                {
                    dgvAdditivation.Rows[i].Cells["clmAdditivationForCast"].Value = "Si";
                }
                else
                {
                    dgvAdditivation.Rows[i].Cells["clmAdditivationForCast"].Value = "No";
                }
       
            }


            List<clsThickness> lstThickness = new List<clsThickness>();

            grpbThicknessList.Enabled = true;
            grpbThicknessForm.Enabled = false;


            lstThickness.Clear();
            lstThickness = clsThickness.getList();
            dgvThickness.Rows.Clear();
            for (int i = 0; i < lstThickness.Count; i++)
            {
                dgvThickness.Rows.Add();
                dgvThickness.Rows[i].Cells["clmThicknessCodsec"].Value = lstThickness[i].codsec.ToString();
                dgvThickness.Rows[i].Cells["clmThicknessValue"].Value = lstThickness[i].value.ToString();               
                
            }

            List<clsTreatment> lstTreatment = new List<clsTreatment>();

            grpbTreatmentList.Enabled = true;
            grpbTreatmentForm.Enabled = false;


            lstTreatment.Clear();
            lstTreatment = clsTreatment.getList();
            dgvTreatment.Rows.Clear();
            for (int j = 0; j < lstTreatment.Count; j++)
            {
                dgvTreatment.Rows.Add();
                dgvTreatment.Rows[j].Cells["clmTreatmentCodsec"].Value = lstTreatment[j].codsec.ToString();
                dgvTreatment.Rows[j].Cells["clmTreatmentAbbreviation"].Value = lstTreatment[j].abbreviation;
                dgvTreatment.Rows[j].Cells["clmTreatmentName"].Value = lstTreatment[j].name;
                if (lstTreatment[j].isForBopp.ToString().Equals("True"))
                {
                    dgvTreatment.Rows[j].Cells["clmTreatmentBopp"].Value = "Si";
                }
                else
                {
                    dgvTreatment.Rows[j].Cells["clmTreatmentBopp"].Value = "No";
                }
                if (lstTreatment[j].isForCpp.ToString().Equals("True"))
                {
                    dgvTreatment.Rows[j].Cells["clmTreatmentCast"].Value = "Si";
                }
                else
                {
                    dgvTreatment.Rows[j].Cells["clmTreatmentCast"].Value = "No";
                }
                if (lstTreatment[j].isForCoat.ToString().Equals("True"))
                {
                    dgvTreatment.Rows[j].Cells["clmTreatmentCoating"].Value = "Si";
                }
                else
                {
                    dgvTreatment.Rows[j].Cells["clmTreatmentCoating"].Value = "No";
                }

            }

        }
        #endregion

        #region "Bopp Function"


                #region "BoppFamily"

                clsFamily objFamily = new clsFamily();
                
                
                public void clearFamilyFields()
                {
                    txtBoppFamilyAbbreviation.BackColor = Color.White;
                    txtBoppFamilyName.BackColor = Color.White;
                    lblBoppFamilyName.ForeColor = Color.Black;
                    lblBoppFamilyAvbreviation.ForeColor = Color.Black;
                    txtBoppFamilyName.Clear();
                    txtBoppFamilyAbbreviation.Clear();
                    grpbFamilyForm.Enabled = false;
                }

                public bool validateFormFamilyBopp()
                {
                    bool isValid = true;

                    if (!clsValidation.validateField(ref txtBoppFamilyName, ref lblBoppFamilyName, "notEmpty")) isValid = false;
                    
                    
                    return isValid;
                }

                private void btnBoppFamilyAdd_Click(object sender, EventArgs e)
                {
                    grpbFamilyForm.Enabled = true;
                    
                }

                private void btnFamilySave_Click(object sender, EventArgs e)
                {
                    try
                        {

                            if (validateFormFamilyBopp())
                            {
                                objFamily.name = txtBoppFamilyName.Text;
                                objFamily.abbreviation = txtBoppFamilyAbbreviation.Text;

                                if (objFamily.save())
                                {
                                    grpbFamilyForm.Enabled = false;
                                    MessageBox.Show("La familia se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                    initBoppForm();
                                    clearFamilyFields();
                                    objFamily = new clsFamily();
                                }
                                else
                                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            clsLog.addLog(ex, 3, this.Name);
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            throw;
                        }
                }

                private void btnBoppFamilyEdit_Click(object sender, EventArgs e)
                {
                    grpbFamilyForm.Enabled = true; 
                    objFamily.load(Convert.ToInt32(dgvFamily.SelectedRows[0].Cells["clmFamilyCodsec"].Value.ToString()));
                    txtBoppFamilyName.Text = objFamily.name;
                    txtBoppFamilyAbbreviation.Text = objFamily.abbreviation;

                }

                private void btnBoppFamilyCancel_Click(object sender, EventArgs e)
                {
                    clearFamilyFields();
                }

                #endregion


                #region "BoppSeal"

                clsSeal objSeal = new clsSeal();


                public void clearSealFields()
                {
                    txtSealAbbreviation.BackColor = Color.White;
                    txtSealName.BackColor = Color.White;
                    lblSealName.ForeColor = Color.Black;
                    lblSealAbbreviation.ForeColor = Color.Black;
                    txtSealAbbreviation.Clear();
                    txtSealAbbreviation.Clear();
                    grpbSealForm.Enabled = false;
                }



                public bool validateFormSealBopp()
                {
                    bool isValid = true;

                    if (!clsValidation.validateField(ref txtSealName, ref lblSealName, "notEmpty")) isValid = false;
                   

                    return isValid;
                }

                       

                private void btnBoppSealAdd_Click(object sender, EventArgs e)
                {
                    grpbSealForm.Enabled = true;
                }

                private void btnBoppSealEdit_Click(object sender, EventArgs e)
                {
                    grpbSealForm.Enabled = true;
                    objSeal.load(Convert.ToInt32(dgvSeal.SelectedRows[0].Cells["clmSealCodsec"].Value.ToString()));
                    txtSealName.Text = objSeal.name;
                    txtSealAbbreviation.Text = objSeal.abbreviation;
                }

                private void btnBoppSealSave_Click(object sender, EventArgs e)
                {
                    try
                    {

                        if (validateFormSealBopp())
                        {
                            objSeal.name = txtSealName.Text;
                            objSeal.abbreviation = txtSealAbbreviation.Text;

                            if (objSeal.save())
                            {
                                grpbSealForm.Enabled = false;
                                MessageBox.Show("El sello se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                initBoppForm();
                                clearSealFields();
                                objSeal = new clsSeal();
                            }
                            else
                                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLog.addLog(ex, 3, this.Name);
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        throw;
                    }

                }

                private void btnBoppSealCancel_Click(object sender, EventArgs e)
                {
                    clearSealFields(); 
                }

                #endregion


                #region "BoppAdditivation"

                public void clearAdditivationFields()
                {
                    chbxAdditivationBopp.Checked = false;
                    chbxAdditivationCast.Checked = false;
                    txtAdditivationAbbreviation.BackColor = Color.White;
                    txtAdditivationName.BackColor = Color.White;
                    lblAdditivationAbbreviation.ForeColor = Color.Black;
                    lblAdditivationName.ForeColor = Color.Black;
                    txtAdditivationName.Clear();
                    txtAdditivationAbbreviation.Clear();
                    grpbAdditivationForm.Enabled = false;
                }


                clsAdditivation objAdditivation = new clsAdditivation();

                public bool validateFormAdditivationBopp()
                {
                    bool isValid = true;

                    if (!clsValidation.validateField(ref txtAdditivationName, ref lblAdditivationName, "notEmpty")) isValid = false;
                    
                    
                    return isValid;
                }



                private void btnBoppAdditivationAdd_Click(object sender, EventArgs e)
                {
                    grpbAdditivationForm.Enabled = true;
                }

                private void btnBoppAdditivationSave_Click(object sender, EventArgs e)
                {
                    try
                    {

                        if (validateFormAdditivationBopp())
                        {
                            objAdditivation.name = txtAdditivationName.Text;
                            objAdditivation.abbreviation = txtAdditivationAbbreviation.Text;
                            objAdditivation.isForBopp = chbxBoppAdditivation.Checked;
                            objAdditivation.isForCpp = chbxCastAdditivation.Checked;

                            if (objAdditivation.save())
                            {
                                grpbAdditivationForm.Enabled = false;
                                MessageBox.Show("La aditivacion se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                initBoppForm();
                                grpbAdditivationForm.Enabled = false;
                                clearAdditivationFields();
                                objAdditivation = new clsAdditivation();
                                
                            }
                            else
                                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLog.addLog(ex, 3, this.Name);
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        throw;
                    }

                }

                private void btnBoppAdditivationEdit_Click(object sender, EventArgs e)
                {
                    grpbAdditivationForm.Enabled = true;
                    objAdditivation.load(Convert.ToInt32(dgvAdditivation.SelectedRows[0].Cells["clmAdditivationCodsec"].Value.ToString()));
                    txtAdditivationName.Text = objAdditivation.name;
                    txtAdditivationAbbreviation.Text = objAdditivation.abbreviation;
                    chbxBoppAdditivation.Checked = objAdditivation.isForBopp;
                    chbxCastAdditivation.Checked = objAdditivation.isForCpp;

                } 


                private void btnBoppAdditivationCancel_Click(object sender, EventArgs e)
                {
                    clearAdditivationFields();
                }

                #endregion


                #region "BoppThickness"

                clsThickness objThickness = new clsThickness();


                public void clearThicknessFields()
                {

                txtThicknessValue.BackColor = Color.White;
                lblThicknessValue.ForeColor = Color.Black;
                txtThicknessValue.Clear();
                grpbThicknessForm.Enabled = false;
                }

                public bool validateFormThicknessBopp()
                {
                bool isValid = true;

                if (!clsValidation.validateField(ref txtThicknessValue, ref lblThicknessValue, "notEmpty")) isValid = false;
                
                return isValid;
                }


                private void btnBoppThicknessAdd_Click(object sender, EventArgs e)
                {
                    grpbThicknessForm.Enabled = true;
                }

                private void btnBoppThicknessSave_Click(object sender, EventArgs e)
                {
                    try
                    {

                        if (validateFormThicknessBopp())
                        {
                            objThickness.value = Convert.ToInt32(txtThicknessValue.Text);

                            if (objThickness.save())
                            {
                                grpbThicknessForm.Enabled = false;
                                MessageBox.Show("El espesor se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                initBoppForm();
                                clearThicknessFields();
                                objThickness = new clsThickness();
                               
                            }
                            else
                                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLog.addLog(ex, 3, this.Name);
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        throw;
                    }
                }

                private void btnBoppThicknessEdit_Click(object sender, EventArgs e)
                {
                    grpbThicknessForm.Enabled = true;
                    objThickness.load(Convert.ToInt32(dgvThickness.SelectedRows[0].Cells["clmThicknessCodsec"].Value.ToString()));
                    txtThicknessValue.Text = objThickness.value.ToString();

                }
                private void btnBoppThicknessCancel_Click(object sender, EventArgs e)
                {
                    clearThicknessFields();
                }
        

                #endregion

                #region "BoppTreatment"

                public void clearTreatmentFields()
                {
                    chbxBoppTreatment.Checked = false;
                    chbxCastTreatment.Checked = false;
                    chbxCoatingTreatment.Checked = false;
                    txtTreatmentAbbreviation.BackColor = Color.White;
                    txtTreatmentName.BackColor = Color.White;
                    lblTreatmentAbbreviation.ForeColor = Color.Black;
                    lblTreatmentName.ForeColor = Color.Black;
                    txtTreatmentName.Clear();
                    txtTreatmentAbbreviation.Clear();
                    grpbTreatmentForm.Enabled = false;
                }


                clsTreatment objTreatment = new clsTreatment();

                public bool validateFormTreatmentBopp()
                {
                    bool isValid = true;

                    if (!clsValidation.validateField(ref txtTreatmentName, ref lblTreatmentName, "notEmpty")) isValid = false;
                   

                    return isValid;
                }

                private void btnBoppTreatmentAdd_Click_1(object sender, EventArgs e)
                {
                    grpbTreatmentForm.Enabled = true;
                }

                private void btnBoppTreatmentSave_Click_1(object sender, EventArgs e)
                {
                    try
                    {

                        if (validateFormTreatmentBopp())
                        {
                            objTreatment.name = txtTreatmentName.Text;
                            objTreatment.abbreviation = txtTreatmentAbbreviation.Text;
                            objTreatment.isForBopp = chbxBoppTreatment.Checked;
                            objTreatment.isForCpp = chbxCastTreatment.Checked;
                            objTreatment.isForCoat = chbxCoatingTreatment.Checked;

                            if (objTreatment.save())
                            {
                                grpbTreatmentForm.Enabled = false;
                                MessageBox.Show("El tratamiento se ha guardado con éxito.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                                initBoppForm();
                                clearTreatmentFields();
                                objTreatment = new clsTreatment();

                            }
                            else
                                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        }

                    }
                    catch (Exception ex)
                    {
                        clsLog.addLog(ex, 3, this.Name);
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Bopp Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        throw;
                    }

                }
                

                private void btnBoppTreatmentEdit_Click_1(object sender, EventArgs e)
                {
                    grpbTreatmentForm.Enabled = true;
                    objTreatment.load(Convert.ToInt32(dgvTreatment.SelectedRows[0].Cells["clmTreatmentCodsec"].Value.ToString()));
                    txtTreatmentName.Text = objTreatment.name;
                    txtTreatmentAbbreviation.Text = objTreatment.abbreviation;
                    chbxBoppTreatment.Checked = objTreatment.isForBopp;
                    chbxCastTreatment.Checked = objTreatment.isForCpp;
                    chbxCoatingTreatment.Checked = objTreatment.isForCoat;

                }

                private void btnBoppTreatmentCancel_Click_1(object sender, EventArgs e)
                {
                    clearTreatmentFields();
                }

                #endregion


        #endregion


                #region "Cast Film Info"

                public void initCastForm()
                 {

            List<clsProcess> lstProcess = new List<clsProcess>();

            
            grpbProcessList.Enabled = true;
            grpbProcessForm.Enabled = false;

            lstProcess.Clear();
            lstProcess = clsProcess.getList();
            dgvProcess.Rows.Clear();

            for (int i = 0; i < lstProcess.Count; i++)
            {
                dgvProcess.Rows.Add();
                dgvProcess.Rows[i].Cells["clmProcessCodsec"].Value = lstProcess[i].codsec.ToString();
                dgvProcess.Rows[i].Cells["clmProcessName"].Value = lstProcess[i].name;
                dgvProcess.Rows[i].Cells["clmProcessAbbreviation"].Value = lstProcess[i].abbreviation;
                if (lstProcess[i].isForCast.ToString().Equals("True"))
                {
                    dgvProcess.Rows[i].Cells["clmProcessCast"].Value = "Si";
                }
                else
                {
                    dgvProcess.Rows[i].Cells["clmProcessCast"].Value = "No";
                }
                if (lstProcess[i].isForCoat.ToString().Equals("True"))
                {
                    dgvProcess.Rows[i].Cells["clmProcessCoating"].Value = "Si";
                }
                else
                {
                    dgvProcess.Rows[i].Cells["clmProcessCoating"].Value = "No";
                }
            }

            List<clsStructure> lstStructure = new List<clsStructure>();


            grpbStructureList.Enabled = true;
            grpbStructureForm.Enabled = false;

            lstStructure.Clear();
            lstStructure = clsStructure.getList();
            dgvStructure.Rows.Clear();

            for (int i = 0; i < lstStructure.Count; i++)
            {

                dgvStructure.Rows.Add();
                dgvStructure.Rows[i].Cells["clmStructureCodsec"].Value = lstStructure[i].codsec.ToString();
                dgvStructure.Rows[i].Cells["clmStructureAbbreviation"].Value = lstStructure[i].abbreviation;
                dgvStructure.Rows[i].Cells["clmStructureName"].Value = lstStructure[i].name;
                if (lstStructure[i].isForCast.ToString().Equals("True"))
                {
                    dgvStructure.Rows[i].Cells["clmStructureCast"].Value = "Si";
                }
                else
                {
                    dgvStructure.Rows[i].Cells["clmStructureCast"].Value = "No";
                }
                if (lstStructure[i].isForCoat.ToString().Equals("True"))
                {
                    dgvStructure.Rows[i].Cells["clmStructureCoating"].Value = "Si";
                }
                else
                {
                    dgvStructure.Rows[i].Cells["clmStructureCoating"].Value = "No";
                }
            }

            List<clsAdditivation> lstAdditivation = new List<clsAdditivation>();

            grpbCastAdditivationList.Enabled = true;
            grpbCastAdditivationForm.Enabled = false;


            lstAdditivation.Clear();
            lstAdditivation = clsAdditivation.getList();
            dgvCastAdditivation.Rows.Clear();
            for (int i = 0; i < lstAdditivation.Count; i++)
            {

                dgvCastAdditivation.Rows.Add();
                dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationCodsec"].Value = lstAdditivation[i].codsec.ToString();
                dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationAbreviattion"].Value = lstAdditivation[i].abbreviation;
                dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationName"].Value = lstAdditivation[i].name;
                if (lstAdditivation[i].isForBopp.ToString().Equals("True"))
                {
                    dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationBopp"].Value = "Si";
                }
                else
                {
                    dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationBopp"].Value = "No";
                }
                if (lstAdditivation[i].isForCpp.ToString().Equals("True"))
                {
                    dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationCast"].Value = "Si";
                }
                else
                {
                    dgvCastAdditivation.Rows[i].Cells["clmCastAdditivationCast"].Value = "No";
                }

            }


            List<clsThickness> lstThickness = new List<clsThickness>();
            
            grpbThicknessCastList.Enabled = true;
            grpbThicknessCastForm.Enabled = false;


            lstThickness.Clear();
            lstThickness = clsThickness.getList();
            dgvThicknessCast.Rows.Clear();

            for (int i = 0; i < lstThickness.Count; i++)
            {
                
                dgvThicknessCast.Rows.Add();  
                dgvThicknessCast.Rows[i].Cells["clmThicknessCastCodsec"].Value = lstThickness[i].codsec.ToString();
                dgvThicknessCast.Rows[i].Cells["clmThicknessCastValue"].Value = lstThickness[i].value.ToString();

            }

            List<clsTreatment> lstTreatment = new List<clsTreatment>();
            
            grpbTreatmentCastList.Enabled = true;
            grpbTreatmentCastForm.Enabled = false;


            lstTreatment.Clear();
            lstTreatment = clsTreatment.getList();
            dgvTreatmentCast.Rows.Clear();

            for (int j = 0; j < lstTreatment.Count; j++)
            {
                
                dgvTreatmentCast.Rows.Add();    
                dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastCodsec"].Value = lstTreatment[j].codsec.ToString();
                dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastAbbreviation"].Value = lstTreatment[j].abbreviation;
                dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastName"].Value = lstTreatment[j].name;
                if (lstTreatment[j].isForBopp.ToString().Equals("True"))
                {   
                    dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastBopp"].Value = "Si";
                }
                else
                {
                    dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastBopp"].Value = "No";
                }
                if (lstTreatment[j].isForCpp.ToString().Equals("True"))
                {
                    dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastCast"].Value = "Si";
                }
                else
                {
                    dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastCast"].Value = "No";
                }
                if (lstTreatment[j].isForCoat.ToString().Equals("True"))
                { 
                    dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastCoating"].Value = "Si";
                }
                else
                {
                    dgvTreatmentCast.Rows[j].Cells["clmTreatmenCastCoating"].Value = "No";
                }

            }
        }
        #endregion

        #region "Cast Function"

        #region "CastProcess"

        clsProcess objProcess = new clsProcess();

        public void clearProcessFields()
        {
            chbxProcessCast.Checked = false;
            chbxProcessCoating.Checked = false;
            txtProcessAbbreviation.BackColor = Color.White;
            txtProcessName.BackColor = Color.White;
            lblProcessAbbreviation.ForeColor = Color.Black;
            lblProcessName.ForeColor = Color.Black;
            txtProcessName.Clear();
            txtProcessAbbreviation.Clear();
            grpbProcessForm.Enabled = false;
        }

        public bool validateFormProcessCast()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtProcessName, ref lblProcessName, "notEmpty")) isValid = false;
          

            return isValid;
        }

        private void btnCastProcessAdd_Click(object sender, EventArgs e)
        {
            grpbProcessForm.Enabled = true;
        }

        private void btnCastProcessSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormProcessCast())
                {
                    objProcess.name = txtProcessName.Text;
                    objProcess.abbreviation = txtProcessAbbreviation.Text;
                    objProcess.isForCast = chbxProcessCast.Checked;
                    objProcess.isForCoat = chbxProcessCoating.Checked;

                    if (objProcess.save())
                    {
                        grpbProcessForm.Enabled = false;
                        MessageBox.Show("El proceso se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCastForm();
                        grpbProcessForm.Enabled = false;
                        clearProcessFields();
                        objProcess = new clsProcess();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCastProcessEdit_Click(object sender, EventArgs e)
        {
            grpbProcessForm.Enabled = true;
            objProcess.load(Convert.ToInt32(dgvProcess.SelectedRows[0].Cells["clmProcessCodsec"].Value.ToString()));
            txtProcessName.Text = objProcess.name;
            txtProcessAbbreviation.Text = objProcess.abbreviation;
            chbxProcessCast.Checked = objProcess.isForCast;
            chbxProcessCoating.Checked = objProcess.isForCoat;

        }

        private void btnCastProcessCancel_Click(object sender, EventArgs e)
        {
            clearProcessFields();
        }
        #endregion

        #region "CastStructure"

        clsStructure objStructure = new clsStructure();

        public void clearStructureFields()
        {
            chbxStructureCast.Checked = false;
            chbxStructureCoating.Checked = false;
            txtStructureAbbreviation.BackColor = Color.White;
            txtStructureName.BackColor = Color.White;
            lblStructureAbbreviation.ForeColor = Color.Black;
            lblStructureName.ForeColor = Color.Black;
            txtStructureName.Clear();
            txtStructureAbbreviation.Clear();
            grpbStructureForm.Enabled = false;
        }

        public bool validateFormStructureCast()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtStructureName, ref lblStructureName, "notEmpty")) isValid = false;
            

            return isValid;
        }

        private void btnCastStructureAdd_Click(object sender, EventArgs e)
        {
            grpbStructureForm.Enabled = true;
        }
        private void btnCastStructureSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormStructureCast())
                {
                    objStructure.name = txtStructureName.Text;
                    objStructure.abbreviation = txtStructureAbbreviation.Text;
                    objStructure.isForCast = chbxStructureCast.Checked;
                    objStructure.isForCoat = chbxStructureCoating.Checked;

                    if (objStructure.save())
                    {
                        grpbStructureForm.Enabled = false;
                        MessageBox.Show("La estructura se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCastForm();
                        grpbStructureForm.Enabled = false;
                        clearStructureFields();
                        objStructure = new clsStructure();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }
        private void btnCastStructureEdit_Click(object sender, EventArgs e)
        {
            grpbStructureForm.Enabled = true;
            objStructure.load(Convert.ToInt32(dgvStructure.SelectedRows[0].Cells["clmStructureCodsec"].Value.ToString()));
            txtStructureName.Text = objStructure.name;
            txtStructureAbbreviation.Text = objStructure.abbreviation;
            chbxStructureCast.Checked = objStructure.isForCast;
            chbxStructureCoating.Checked = objStructure.isForCoat;
        }

        private void btnCastStructureCancel_Click(object sender, EventArgs e)
        {
            clearStructureFields();
        }



        #endregion

        #region "CastAdditivation"

        clsAdditivation objCastAdditivation = new clsAdditivation();

        public void clearCastAdditivationFields()
        {
            chbxAdditivationBopp.Checked = false;
            chbxAdditivationCast.Checked = false;
            txtCastAdditivationAbbreviation.BackColor = Color.White;
            txtCastAdditivationName.BackColor = Color.White;
            lblCastAdditivationName.ForeColor = Color.Black;
            lblCastAdditivationAbbreviation.ForeColor = Color.Black;
            txtCastAdditivationName.Clear();
            txtCastAdditivationAbbreviation.Clear();
            grpbCastAdditivationForm.Enabled = false;
        }

        public bool validateFormAdditivationCast()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCastAdditivationName, ref lblCastAdditivationName, "notEmpty")) isValid = false;
            

            return isValid;
        }


        private void btnCastAdditivationAdd_Click(object sender, EventArgs e)
        {
            grpbCastAdditivationForm.Enabled = true;
        }

        private void btnCastAdditivationSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormAdditivationCast())
                {
                    objCastAdditivation.name = txtCastAdditivationName.Text;
                    objCastAdditivation.abbreviation = txtCastAdditivationAbbreviation.Text;
                    objCastAdditivation.isForBopp = chbxAdditivationBopp.Checked;
                    objCastAdditivation.isForCpp = chbxAdditivationCast.Checked;

                    if (objCastAdditivation.save())
                    {
                        grpbCastAdditivationForm.Enabled = false;
                        MessageBox.Show("La aditivacion se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCastForm();
                        grpbCastAdditivationForm.Enabled = false;
                        clearCastAdditivationFields();
                        objCastAdditivation = new clsAdditivation();


                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCastAdditivationEdit_Click(object sender, EventArgs e)
        {
            grpbCastAdditivationForm.Enabled = true;
            objCastAdditivation.load(Convert.ToInt32(dgvCastAdditivation.SelectedRows[0].Cells["clmCastAdditivationCodsec"].Value.ToString()));
            txtCastAdditivationName.Text = objCastAdditivation.name;
            txtCastAdditivationAbbreviation.Text = objCastAdditivation.abbreviation;
            chbxAdditivationBopp.Checked = objCastAdditivation.isForBopp;
            chbxAdditivationCast.Checked = objCastAdditivation.isForCpp;
        }

        private void btnCastAdditivationCancel_Click(object sender, EventArgs e)
        {
            clearCastAdditivationFields();
        }
        #endregion

        #region "CastThickness"

        clsThickness objCastThickness = new clsThickness();


        public void clearCastThicknessFields()
        {

            txtThicknessCastValue.BackColor = Color.White;
            lblThicknessCastValue.ForeColor = Color.Black;
            txtThicknessCastValue.Clear();
            grpbThicknessCastForm.Enabled = false;
        }

        public bool validateFormThicknessCast()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtThicknessCastValue, ref lblThicknessCastValue, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnCastThicknessAdd_Click(object sender, EventArgs e)
        {
            grpbThicknessCastForm.Enabled = true;
        }

        private void btnCastThicknessSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormThicknessCast())
                {
                    objCastThickness.value = Convert.ToInt32(txtThicknessCastValue.Text);

                    if (objCastThickness.save())
                    {
                        grpbThicknessCastForm.Enabled = false;
                        MessageBox.Show("El espesor se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCastForm();
                        clearCastThicknessFields();
                        objCastThickness = new clsThickness();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCastThicknessEdit_Click(object sender, EventArgs e)
        {
            grpbThicknessCastForm.Enabled = true;
            objCastThickness.load(Convert.ToInt32(dgvThicknessCast.SelectedRows[0].Cells["clmThicknessCastCodsec"].Value.ToString()));
            txtThicknessCastValue.Text = objCastThickness.value.ToString();
        }

        private void btnCastThicknessCancel_Click(object sender, EventArgs e)
        {
            clearCastThicknessFields();
        }



        #endregion

        #region "CastTreatment"

        public void clearTreatmentCastFields()
        {
            chbxTreatmentCastBopp.Checked = false;
            chbxTreatmentCastCast.Checked = false;
            chbxTreatmentCastCoating.Checked = false;
            txtTreatmentCastAbbreviation.BackColor = Color.White;
            txtTreatmentCastName.BackColor = Color.White;
            lblTreatmentCastAbbreviation.ForeColor = Color.Black;
            lblTreatmentCastName.ForeColor = Color.Black;
            txtTreatmentCastName.Clear();
            txtTreatmentCastAbbreviation.Clear();
            grpbTreatmentCastForm.Enabled = false;
        }


        clsTreatment objCastTreatment = new clsTreatment();

        public bool validateFormTreatmentCast()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtTreatmentCastName, ref lblTreatmentCastName, "notEmpty")) isValid = false;
           

            return isValid;
        }

        private void btnCastTreatmentAdd_Click(object sender, EventArgs e)
        {
            grpbTreatmentCastForm.Enabled = true;
        }

        private void btnCastTreatmentSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormTreatmentCast())
                {
                    objCastTreatment.name = txtTreatmentCastName.Text;
                    objCastTreatment.abbreviation = txtTreatmentCastAbbreviation.Text;
                    objCastTreatment.isForBopp = chbxTreatmentCastBopp.Checked;
                    objCastTreatment.isForCpp = chbxTreatmentCastCast.Checked;
                    objCastTreatment.isForCoat = chbxTreatmentCastCoating.Checked;

                    if (objCastTreatment.save())
                    {
                        grpbTreatmentCastForm.Enabled = false;
                        MessageBox.Show("El tratamiento se ha guardado con éxito.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCastForm();
                        clearTreatmentCastFields();
                        objCastTreatment = new clsTreatment();


                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cast Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }


        private void btnCastTreatmentEdit_Click(object sender, EventArgs e)
        {
            grpbTreatmentCastForm.Enabled = true;
            objCastTreatment.load(Convert.ToInt32(dgvTreatmentCast.SelectedRows[0].Cells["clmTreatmenCastCodsec"].Value.ToString()));
            txtTreatmentCastName.Text = objCastTreatment.name;
            txtTreatmentCastAbbreviation.Text = objCastTreatment.abbreviation;
            chbxTreatmentCastBopp.Checked = objCastTreatment.isForBopp;
            chbxTreatmentCastCast.Checked = objCastTreatment.isForCpp;
            chbxTreatmentCastCoating.Checked = objCastTreatment.isForCoat;
        }


        private void btnCastTreatmentCancel_Click(object sender, EventArgs e)
        {
            clearTreatmentCastFields();
        }



        #endregion



        #endregion

        #region "Coating Film Info"

        public void initCoatingForm()
        {
            List<clsProcess> lstProcess = new List<clsProcess>();
            
                
            grpbProcessCoatingList.Enabled = true;
            grpbProcessCoatingForm.Enabled = false;

            lstProcess.Clear();
            lstProcess = clsProcess.getList();
            dgvCoatingProcess.Rows.Clear();


            for (int i = 0; i < lstProcess.Count; i++)
            {

                dgvCoatingProcess.Rows.Add();
                dgvCoatingProcess.Rows[i].Cells["clmCoatingCodsec"].Value = lstProcess[i].codsec.ToString();
                dgvCoatingProcess.Rows[i].Cells["clmCoatingProcessName"].Value = lstProcess[i].name;
                dgvCoatingProcess.Rows[i].Cells["clmCoatingProcessAbbreviation"].Value = lstProcess[i].abbreviation;
                if (lstProcess[i].isForCast.ToString().Equals("True"))
                {
                    dgvCoatingProcess.Rows[i].Cells["clmCoatingProcessCast"].Value = "Si";
                }
                else
                {
                    dgvCoatingProcess.Rows[i].Cells["clmCoatingProcessCast"].Value = "No";
                }
                if (lstProcess[i].isForCoat.ToString().Equals("True"))
                {
                    dgvCoatingProcess.Rows[i].Cells["clmCoatingProcessCoating"].Value = "Si";
                }
                else
                {
                    dgvCoatingProcess.Rows[i].Cells["clmCoatingProcessCoating"].Value = "No";
                }
            }

            List<clsStructure> lstStructure = new List<clsStructure>();


            grpbStructureCoatingList.Enabled = true;
            grpbStructureCoatingForm.Enabled = false;

            lstStructure.Clear();
            lstStructure = clsStructure.getList();
            dgvCoatingStructure.Rows.Clear();

            for (int i = 0; i < lstStructure.Count; i++)
            {

                dgvCoatingStructure.Rows.Add();
                dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingCodsec"].Value = lstStructure[i].codsec.ToString();
                dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingAbbreviation"].Value = lstStructure[i].abbreviation;
                dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingName"].Value = lstStructure[i].name;
                if (lstStructure[i].isForCast.ToString().Equals("True"))
                {
                    dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingCast"].Value = "Si";
                }
                else
                {
                    dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingCast"].Value = "No";
                }
                if (lstStructure[i].isForCoat.ToString().Equals("True"))
                {
                    dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingCoating"].Value = "Si";
                }
                else
                {
                    dgvCoatingStructure.Rows[i].Cells["clmStructureCoatingCoating"].Value = "No";
                }
            }

            
            List<clsThickness> lstThickness = new List<clsThickness>();

            grpbThicknessCoatingList.Enabled = true;
            grpbThicknessCoatingForm.Enabled = false;


            lstThickness.Clear();
            lstThickness = clsThickness.getList();
            dgvCoatingThickness.Rows.Clear();

            for (int i = 0; i < lstThickness.Count; i++)
            {

                dgvCoatingThickness.Rows.Add();
                dgvCoatingThickness.Rows[i].Cells["clmThicknessCoatingCodsec"].Value = lstThickness[i].codsec.ToString();
                dgvCoatingThickness.Rows[i].Cells["clmThicknessCoatingValue"].Value = lstThickness[i].value.ToString();

            }

            List<clsTreatment> lstTreatment = new List<clsTreatment>();

            grpbTreatmentCoatingList.Enabled = true;
            grpbTreatmentCoatingForm.Enabled = false;


            lstTreatment.Clear();
            lstTreatment = clsTreatment.getList();
            dgvCoatingTreatment.Rows.Clear();

            for (int j = 0; j < lstTreatment.Count; j++)
            {

                dgvCoatingTreatment.Rows.Add();
                dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentCodsec"].Value = lstTreatment[j].codsec.ToString();
                dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentAbbreviation"].Value = lstTreatment[j].abbreviation;
                dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentName"].Value = lstTreatment[j].name;
                if (lstTreatment[j].isForBopp.ToString().Equals("True"))
                {
                    dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentBopp"].Value = "Si";
                }
                else
                {
                    dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentBopp"].Value = "No";
                }
                if (lstTreatment[j].isForCpp.ToString().Equals("True"))
                {
                    dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentCast"].Value = "Si";
                }
                else
                {
                    dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentCast"].Value = "No";
                }
                if (lstTreatment[j].isForCoat.ToString().Equals("True"))
                {
                    dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentCoating"].Value = "Si";
                }
                else
                {
                    dgvCoatingTreatment.Rows[j].Cells["clmCoatingTreatmentCoating"].Value = "No";
                }

            }
        }

        #endregion

        #region "Coating Function"

       clsProcess objCoatingProcess = new clsProcess();

        public void clearCoatingProcessFields()
        {
            chbxProcessCoatingCast.Checked = false;
            chbxProcessCoatingCoating.Checked = false;
            txtProcessCoatingAbbreviation.BackColor = Color.White;
            txtProcessCoatingName.BackColor = Color.White;
            lblProcessCoatingAbbreviation.ForeColor = Color.Black;
            lblProcessCoatingName.ForeColor = Color.Black;
            txtProcessCoatingName.Clear();
            txtProcessCoatingAbbreviation.Clear();
            grpbProcessCoatingForm.Enabled = false;
        }

        public bool validateFormProcessCoating()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtProcessCoatingName, ref lblProcessCoatingName, "notEmpty")) isValid = false;
            

            return isValid;
        }

        private void btnCoatingProcessAdd_Click(object sender, EventArgs e)
        {
            grpbProcessCoatingForm.Enabled = true;
        }

        private void btnCoatingProcessSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormProcessCoating())
                {
                    objCoatingProcess.name = txtProcessCoatingName.Text;
                    objCoatingProcess.abbreviation = txtProcessCoatingAbbreviation.Text;
                    objCoatingProcess.isForCast = chbxProcessCoatingCast.Checked;
                    objCoatingProcess.isForCoat = chbxProcessCoatingCoating.Checked;

                    if (objCoatingProcess.save())
                    {
                        grpbProcessCoatingForm.Enabled = false;
                        MessageBox.Show("El proceso se ha guardado con éxito.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCoatingForm();
                        clearCoatingProcessFields();
                        objCoatingProcess = new clsProcess();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCoatingProcessEdit_Click(object sender, EventArgs e)
        {
            grpbProcessCoatingForm.Enabled = true;
            objCoatingProcess.load(Convert.ToInt32(dgvCoatingProcess.SelectedRows[0].Cells["clmCoatingCodsec"].Value.ToString()));
            txtProcessCoatingName.Text = objCoatingProcess.name;
            txtProcessCoatingAbbreviation.Text = objCoatingProcess.abbreviation;
            chbxProcessCoatingCast.Checked = objCoatingProcess.isForCast;
            chbxProcessCoatingCoating.Checked = objCoatingProcess.isForCoat;
        }

        private void btnCoatingProcessCancel_Click(object sender, EventArgs e)
        {
            clearCoatingProcessFields();
        }

        #endregion

        #region "Coating Structure"

        clsStructure objCoatingStructure = new clsStructure();

        public void clearCoatingStructureFields()
        {
            chbxCoatingStructureCast.Checked = false;
            chbxCoatingStructureCoating.Checked = false;
            txtCoatingStructureAbbreviation.BackColor = Color.White;
            txtCoatingStructureName.BackColor = Color.White;
            lblCoatingStructureAbbreviation.ForeColor = Color.Black;
            lblCoatingStructureName.ForeColor = Color.Black;
            txtCoatingStructureName.Clear();
            txtCoatingStructureAbbreviation.Clear();
            grpbStructureCoatingForm.Enabled = false;
        }

        public bool validateFormStructureCoating()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCoatingStructureName, ref lblCoatingStructureName, "notEmpty")) isValid = false;
            

            return isValid;
        }

        private void btnCoatingStructureAdd_Click(object sender, EventArgs e)
        {
            grpbStructureCoatingForm.Enabled = true;
        }

        private void btnCoatingStructureSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormStructureCoating())
                {
                    objCoatingStructure.name = txtCoatingStructureName.Text;
                    objCoatingStructure.abbreviation = txtCoatingStructureAbbreviation.Text;
                    objCoatingStructure.isForCast = chbxCoatingStructureCast.Checked;
                    objCoatingStructure.isForCoat = chbxCoatingStructureCoating.Checked;

                    if (objCoatingStructure.save())
                    {
                        grpbStructureCoatingForm.Enabled = false;
                        MessageBox.Show("La estructura se ha guardado con éxito.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCoatingForm();
                        grpbStructureCoatingForm.Enabled = false;
                        clearCoatingStructureFields();
                        objCoatingStructure = new clsStructure();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCoatingStructureEdit_Click(object sender, EventArgs e)
        {
            grpbStructureCoatingForm.Enabled = true;
            objCoatingStructure.load(Convert.ToInt32(dgvCoatingStructure.SelectedRows[0].Cells["clmStructureCoatingCodsec"].Value.ToString()));
            txtCoatingStructureName.Text = objCoatingStructure.name;
            txtCoatingStructureAbbreviation.Text = objCoatingStructure.abbreviation;
            chbxCoatingStructureCast.Checked = objCoatingStructure.isForCast;
            chbxCoatingStructureCoating.Checked = objCoatingStructure.isForCoat;
        }

        private void btnCoatingStructureCancel_Click(object sender, EventArgs e)
        {
            clearCoatingStructureFields();
        }

        #endregion

        #region "Coating Thickness"

        clsThickness objCoatingThickness = new clsThickness();


        public void clearCoatingThicknessFields()
        {

            txtThicknessCoating.BackColor = Color.White;
            lblThicknessCoating.ForeColor = Color.Black;
            txtThicknessCoating.Clear();
            grpbThicknessCoatingForm.Enabled = false;
        }

        public bool validateFormThicknessCoating()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtThicknessCoating, ref lblThicknessCoating, "notEmpty")) isValid = false;

            return isValid;
        }


        private void btnCoatingThicknessAdd_Click(object sender, EventArgs e)
        {
            grpbThicknessCoatingForm.Enabled = true;
        }

        private void btnCoatingThicknessSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormThicknessCoating())
                {
                    objCoatingThickness.value = Convert.ToInt32(txtThicknessCoating.Text);

                    if (objCoatingThickness.save())
                    {
                        grpbThicknessCoatingForm.Enabled = false;
                        MessageBox.Show("El espesor se ha guardado con éxito.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCoatingForm();
                        clearCoatingThicknessFields();
                        objCoatingThickness = new clsThickness();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCoatingThicknessEdit_Click(object sender, EventArgs e)
        {
            grpbThicknessCoatingForm.Enabled = true;
            objCoatingThickness.load(Convert.ToInt32(dgvCoatingThickness.SelectedRows[0].Cells["clmThicknessCoatingCodsec"].Value.ToString()));
            txtThicknessCoating.Text = objCoatingThickness.value.ToString();
        }


        private void btnCoatingThicknessCancel_Click(object sender, EventArgs e)
        {
            clearCoatingThicknessFields();
        }

        #endregion

        #region "Coating Treatment"


        clsTreatment objCoatingTreatment = new clsTreatment();
        
        public void clearTreatmentCoatingFields()
        {
            chbxCoatingTreatmentBopp.Checked = false;
            chbxCoatingTreatmentCast.Checked = false;
            chbxCoatingTreatmentCoating.Checked = false;
            txtCoatingTreatmentAbbreviation.BackColor = Color.White;
            txtCoatingTreatmentName.BackColor = Color.White;
            lblCoatingTreatmentAbbreviation.ForeColor = Color.Black;
            lblCoatingTreatmentName.ForeColor = Color.Black;
            txtCoatingTreatmentName.Clear();
            txtCoatingTreatmentAbbreviation.Clear();
            grpbTreatmentCoatingForm.Enabled = false;
        }
                

        public bool validateFormTreatmentCoating()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCoatingTreatmentName, ref lblCoatingTreatmentName, "notEmpty")) isValid = false;
           

            return isValid;
        }

        private void btnCoatingTreatmentAdd_Click(object sender, EventArgs e)
        {
            grpbTreatmentCoatingForm.Enabled = true;
        }


        private void btnCoatingTreatmentSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormTreatmentCoating())
                {
                    objCoatingTreatment.name = txtCoatingTreatmentName.Text;
                    objCoatingTreatment.abbreviation = txtCoatingTreatmentAbbreviation.Text;
                    objCoatingTreatment.isForBopp = chbxCoatingTreatmentBopp.Checked;
                    objCoatingTreatment.isForCpp = chbxCoatingTreatmentCast.Checked;
                    objCoatingTreatment.isForCoat = chbxCoatingTreatmentCoating.Checked;

                    if (objCoatingTreatment.save())
                    {
                        grpbTreatmentCoatingForm.Enabled = false;
                        MessageBox.Show("El tratamiento se ha guardado con éxito.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        initCoatingForm();
                        clearTreatmentCoatingFields();
                        objCoatingTreatment = new clsTreatment();

                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Coating Film", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }

        }

        private void btnCoatingTreatmentEdit_Click(object sender, EventArgs e)
        {
            grpbTreatmentCoatingForm.Enabled = true;
            objCoatingTreatment.load(Convert.ToInt32(dgvCoatingTreatment.SelectedRows[0].Cells["clmCoatingTreatmentCodsec"].Value.ToString()));
            txtCoatingTreatmentName.Text = objCoatingTreatment.name;
            txtCoatingTreatmentAbbreviation.Text = objCoatingTreatment.abbreviation;
            chbxCoatingTreatmentBopp.Checked = objCoatingTreatment.isForBopp;
            chbxCoatingTreatmentCast.Checked = objCoatingTreatment.isForCpp;
            chbxCoatingTreatmentCoating.Checked = objCoatingTreatment.isForCoat;
        }

        private void btnCoatingTreatmentCancel_Click(object sender, EventArgs e)
        {
            clearTreatmentCoatingFields();
        }


        #endregion

        #region "Role Info"

        public void loadRoleInfo()
        {
            List<clsRole> lstRole = new List<clsRole>();

            grpbRoleList.Enabled = true;
            grpbRoleForm.Enabled = false;

            lstRole.Clear();
            lstRole = clsRole.getList();

            dgvRole.Rows.Clear();


            for (int i = 0; i < lstRole.Count; i++)
            {
                dgvRole.Rows.Add();
                dgvRole.Rows[i].Cells["clmRoleCodsec"].Value = lstRole[i].codsec.ToString();
                dgvRole.Rows[i].Cells["clmRoleName"].Value = lstRole[i].name;
                dgvRole.Rows[i].Cells["clmRoleDescription"].Value = lstRole[i].description;

            }
        }

        #endregion

        #region "Role Function"

        clsRole objRole = new clsRole();

        public void clearRoleFields()
        {

            txtRoleName.BackColor = Color.White;
            txtRoleDescription.BackColor = Color.White;
            lblRoleName.ForeColor = Color.Black;
            lblRoleDescription.ForeColor = Color.Black;
            txtRoleName.Clear();
            txtRoleDescription.Clear();
            grpbRoleForm.Enabled = false;
        }
        public bool validateFormRole()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtRoleName, ref lblRoleName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtRoleDescription, ref lblRoleDescription, "notEmpty")) isValid = false;

            return isValid;
        }


        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            grpbRoleForm.Enabled = true;
        }

        private void btnRoleSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormRole())
                {
                    objRole.name = txtRoleName.Text;
                    objRole.description = txtRoleDescription.Text;

                    if (objRole.save())
                    {
                        grpbRoleForm.Enabled = false;
                        MessageBox.Show("El rol se ha guardado con éxito.", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadRoleInfo();
                        clearRoleFields();
                        objRole = new clsRole();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnRoleEdit_Click(object sender, EventArgs e)
        {
            grpbRoleForm.Enabled = true;
            objRole.load(Convert.ToInt32(dgvRole.SelectedRows[0].Cells["clmRoleCodsec"].Value.ToString()));
            txtRoleName.Text = objRole.name;
            txtRoleDescription.Text = objRole.description;
        }

        private void btnRoleCancel_Click(object sender, EventArgs e)
        {
            clearRoleFields();
        }


#endregion

        #region "Unit Info"

        public void loadUnitInfo()
        {
            List<clsUnit> lstUnit = new List<clsUnit>();


            grpbUnitList.Enabled = true;
            grpbUnitForm.Enabled = false;

            lstUnit.Clear();
            lstUnit = clsUnit.getList();


            dgvUnit.Rows.Clear();


            for (int i = 0; i < lstUnit.Count; i++)
            {
                dgvUnit.Rows.Add();
                dgvUnit.Rows[i].Cells["clmUnitCodsec"].Value = lstUnit[i].codsec.ToString();
                dgvUnit.Rows[i].Cells["clmUnitName"].Value = lstUnit[i].name;
                dgvUnit.Rows[i].Cells["clmUnitSymbol"].Value = lstUnit[i].symbol;

            }
        }
        #endregion

        #region "Unit Function"

        clsUnit objUnit = new clsUnit();

        public void clearUnitFields()
        {
             
            txtUnitName.BackColor = Color.White;
            txtUnitSymbol.BackColor = Color.White;
            lblUnitName.ForeColor = Color.Black;
            lblUnitSymbol.ForeColor = Color.Black;
            txtUnitName.Clear();
            txtUnitSymbol.Clear();
            grpbUnitForm.Enabled = false;
        }
        public bool validateFormUnit()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtUnitName, ref lblUnitName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtUnitSymbol, ref lblUnitSymbol, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnUnitAdd_Click(object sender, EventArgs e)
        {
            grpbUnitForm.Enabled = true;
        }

        private void btnUnitSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormUnit())
                {
                    objUnit.name = txtUnitName.Text;
                    objUnit.symbol = txtUnitSymbol.Text;

                    if (objUnit.save())
                    {
                        grpbUnitForm.Enabled = false;
                        MessageBox.Show("La Unidad se ha guardado con éxito.", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadUnitInfo();
                        clearUnitFields();
                        objUnit = new clsUnit(); 
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Unidades", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnUnitEdit_Click(object sender, EventArgs e)
        {
            grpbUnitForm.Enabled = true;
            objUnit.load(Convert.ToInt32(dgvUnit.SelectedRows[0].Cells["clmUnitCodsec"].Value.ToString()));
            txtUnitName.Text = objUnit.name;
            txtUnitSymbol.Text = objUnit.symbol;
        }

        private void btnUnitCancel_Click(object sender, EventArgs e)
        {
            clearUnitFields();
        }



        #endregion

        #region "Packaging Type Info"

        public void loadPackagingTypeInfo()
        {
            List<clsPackagingType> lstPackagingType = new List<clsPackagingType>();


            grpbPackagingList.Enabled = true;
            grpbPackagingForm.Enabled = false;

            lstPackagingType.Clear();
            lstPackagingType = clsPackagingType.getList();


            dgvPackagingType.Rows.Clear();


            for (int i = 0; i < lstPackagingType.Count; i++)
            {
                dgvPackagingType.Rows.Add();  
                dgvPackagingType.Rows[i].Cells["clmPackagingTypeCodsec"].Value = lstPackagingType[i].codsec.ToString();
                dgvPackagingType.Rows[i].Cells["clmPackagingTypeName"].Value = lstPackagingType[i].name;
                dgvPackagingType.Rows[i].Cells["clmPackagingTypeUnit"].Value = lstPackagingType[i].UnitName; 
                dgvPackagingType.Rows[i].Cells["clmPackagingTypeInitial"].Value = lstPackagingType[i].initial;

            }
        }
        #endregion

        #region "Packaging Type Function"

        clsPackagingType objPackagingType = new clsPackagingType();

        public void clearPackagingTypeFields()
        {
            
            txtPackagingTypeName.BackColor = Color.White;
            txtPackagingTypeInitial.BackColor = Color.White;
            lblPackagingTypeName.ForeColor = Color.Black;
            lblPackagingTypeInitial.ForeColor = Color.Black;
            txtPackagingTypeName.Clear();
            txtPackagingTypeInitial.Clear();
            grpbPackagingForm.Enabled = false;
            cmbPackagingTypeUnit.SelectedIndex = -1;
            
        }
        public bool validateFormPackagingType()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtPackagingTypeName, ref lblPackagingTypeName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtPackagingTypeInitial, ref lblPackagingTypeInitial, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbPackagingTypeUnit, ref lblPackagingTypeUnit, "selected")) isValid = false; 

            return isValid;
        }

        public void loadUnits()
        {
            List<clsUnit> lstUnit = new List<clsUnit>();

            lstUnit = clsUnit.getList();

            cmbPackagingTypeUnit.Items.Clear();
            for (int i = 0; i < lstUnit.Count; i++)
            {
                cmbPackagingTypeUnit.Items.Add(lstUnit[i]);
            }
        }


        private void btnPackagingTypeAdd_Click(object sender, EventArgs e)
        {
            grpbPackagingForm.Enabled = true;
            objUnit = new clsUnit();
            loadUnits();
        }

        private void btnPackagingTypeSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormPackagingType())
                {
                    objPackagingType.name = txtPackagingTypeName.Text;
                    objPackagingType.initial = txtPackagingTypeInitial.Text;
                    objPackagingType.fkUnit = ((clsUnit)cmbPackagingTypeUnit.SelectedItem).codsec;

                    if (objPackagingType.save())
                    {
                        grpbPackagingForm.Enabled = false;
                        MessageBox.Show("El tipo de empaque se ha guardado con éxito.", "Tipos de Empaque", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadPackagingTypeInfo();
                        clearPackagingTypeFields();
                        objPackagingType = new clsPackagingType();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipos de Empaque", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipos de Empaque", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnPackagingTypeEdit_Click(object sender, EventArgs e)
        {
            grpbPackagingForm.Enabled = true;
            objPackagingType.load(Convert.ToInt32(dgvPackagingType.SelectedRows[0].Cells["clmPackagingTypeCodsec"].Value.ToString()));
            txtPackagingTypeName.Text = objPackagingType.name;
            txtPackagingTypeInitial.Text = objPackagingType.initial;
        }

        private void btnPackagingTypeCancel_Click(object sender, EventArgs e)
        {
            clearPackagingTypeFields();
        }
        #endregion


        #region "Core Info"

        public void loadCoreInfo()
        {
            List<clsCore> lstCore = new List<clsCore>();

            grpbCoreList.Enabled = true;
            grpbCoreForm.Enabled = false;

            lstCore.Clear();
            lstCore = clsCore.getList();


            dgvCore.Rows.Clear();


            for (int i = 0; i < lstCore.Count; i++)
            {
                dgvCore.Rows.Add();  
                dgvCore.Rows[i].Cells["clmCoreCodsec"].Value = lstCore[i].codsec.ToString();
                dgvCore.Rows[i].Cells["clmCoreName"].Value = lstCore[i].name;
                dgvCore.Rows[i].Cells["clmCoreValue"].Value = lstCore[i].value;

            }
        }

        #endregion
        
        #region "Core Function"

        clsCore objCore = new clsCore();

        public void clearCoreFields()
        {

            txtCoreName.BackColor = Color.White;
            txtCoreValue.BackColor = Color.White;
            lblCoreName.ForeColor = Color.Black;
            lblCoreValue.ForeColor = Color.Black;
            txtCoreName.Clear();
            txtCoreValue.Clear();
            grpbCoreForm.Enabled = false;
        }
        public bool validateFormCore()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCoreName, ref lblCoreName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCoreValue, ref lblCoreValue, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnCoreAdd_Click(object sender, EventArgs e)
        {
            grpbCoreForm.Enabled = true;
        }

        private void btnCoreSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormCore())
                {
                    objCore.name = txtCoreName.Text;
                    objCore.value = Convert.ToInt32(txtCoreValue.Text);
                    
                    if (objCore.save())
                    {
                        grpbCoreForm.Enabled = false;
                        MessageBox.Show("El core se ha guardado con éxito.", "Cores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadCoreInfo(); 
                        clearCoreFields();
                        objCore = new clsCore();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Cores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnCoreEdit_Click(object sender, EventArgs e)
        {
            grpbCoreForm.Enabled = true;
            objCore.load(Convert.ToInt32(dgvCore.SelectedRows[0].Cells["clmCoreCodsec"].Value.ToString()));
            txtCoreName.Text = objCore.name;
            txtCoreValue.Text = objCore.value.ToString();
        }

        private void btnCoreCancel_Click(object sender, EventArgs e)
        {
            clearCoreFields();
        }




        #endregion

        #region "Color Info"

        public void loadColorInfo()
        {
            List<clsColor> lstColor = new List<clsColor>();

            grpbColorView.Enabled = true;
            grpbColorForm.Enabled = false;

            lstColor.Clear();
            lstColor = clsColor.getList();

             
            dgvColorDetail.Rows.Clear();


            for (int i = 0; i < lstColor.Count; i++)
            {
                dgvColorDetail.Rows.Add();    
                dgvColorDetail.Rows[i].Cells["clmColorCodsec"].Value = lstColor[i].codsec.ToString();
                dgvColorDetail.Rows[i].Cells["clmColorName"].Value = lstColor[i].name;
                dgvColorDetail.Rows[i].Cells["clmColorCode"].Value = lstColor[i].code;

            }
        }

        #endregion

        #region "Color Function"

        clsColor objColor = new clsColor();

        public void clearColorFields()
        {
            
            txtColorName.BackColor = Color.White;
            txtColorCode.BackColor = Color.White;
            lblColorName.ForeColor = Color.Black;
            lblColorCode.ForeColor = Color.Black;
            txtColorName.Clear();
            txtColorCode.Clear();
            grpbColorForm.Enabled = false;
        }
        public bool validateFormColor()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtColorName, ref lblColorName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtColorCode, ref lblColorCode, "notEmpty")) isValid = false;

            return isValid;
        }


        private void btnColorAdd_Click(object sender, EventArgs e)
        {
            grpbColorForm.Enabled = true;
        }

        private void btnColorSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormColor())
                {
                    objColor.name = txtColorName.Text;
                    objColor.code = txtColorCode.Text;

                    if (objColor.save())
                    {
                        grpbColorForm.Enabled = false;
                        MessageBox.Show("El color se ha guardado con éxito.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadColorInfo();
                        clearColorFields();
                        objColor = new clsColor();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnColorEdit_Click(object sender, EventArgs e)
        {
            grpbColorForm.Enabled = true;
            objColor.load(Convert.ToInt32(dgvColorDetail.SelectedRows[0].Cells["clmColorCodsec"].Value.ToString()));
            txtColorName.Text = objColor.name;
            txtColorCode.Text = objColor.code;
        }

        private void btnColorCancel_Click(object sender, EventArgs e)
        {
            clearColorFields();
        }

        


        #endregion

        #region "Ounce Info"

        public void loadOunceInfo()
        {
            List<clsOunce> lstOunce = new List<clsOunce>();


            grpbOunceView.Enabled = true;
            grpbOunceForm.Enabled = false;

            lstOunce.Clear();
            lstOunce = clsOunce.getList();


            dgvOunce.Rows.Clear();


            for (int i = 0; i < lstOunce.Count; i++)
            {
                dgvOunce.Rows.Add(); 
                dgvOunce.Rows[i].Cells["clmOunceCodsec"].Value = lstOunce[i].codsec.ToString();
                dgvOunce.Rows[i].Cells["clmOunceValue"].Value = lstOunce[i].value.ToString();
                

            }
        }

        #endregion

        #region "Ounce Function"

        clsOunce objOunce = new clsOunce();

        public void clearOunceFields()
        {

            txtValue.BackColor = Color.White;
            lblValue.ForeColor = Color.Black;
            txtValue.Clear();
            grpbOunceForm.Enabled = false;
        }
        public bool validateFormOunce()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtValue, ref lblValue, "notEmpty")) isValid = false;
            

            return isValid;
        }


        private void btnOunceAdd_Click(object sender, EventArgs e)
        {
            grpbOunceForm.Enabled = true;
        }

        private void btnOunceSave_Click(object sender, EventArgs e)
        {

            try
            {

                if (validateFormOunce())
                {
                    objOunce.value = Convert.ToDouble(txtValue.Text);

                    if (objOunce.save())
                    {
                        grpbOunceForm.Enabled = false;
                        MessageBox.Show("El valor de onza se ha guardado con éxito.", "Onzas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadOunceInfo();
                        clearOunceFields();
                        objOunce = new clsOunce();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Onzas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Colores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnOunceEdit_Click(object sender, EventArgs e)
        {
            grpbOunceForm.Enabled = true;
            objOunce.load(Convert.ToInt32(dgvOunce.SelectedRows[0].Cells["clmOunceCodsec"].Value.ToString()));
            txtValue.Text = objOunce.value.ToString();
            
        }

        private void btnOunceCancel_Click(object sender, EventArgs e)
        {
            clearOunceFields();
        }


        #endregion

        #region "Diameter Info"

        public void loadDiameterInfo()
        {
            List<clsDiameter> lstDiameter = new List<clsDiameter>();

            grpbDiameterList.Enabled = true;
            grpbDiameterForm.Enabled = false;

            lstDiameter.Clear();
            lstDiameter = clsDiameter.getList();


            dgvDiameter.Rows.Clear();


            for (int i = 0; i < lstDiameter.Count; i++)
            {
                dgvDiameter.Rows.Add();
                dgvDiameter.Rows[i].Cells["clmDiameterCodsec"].Value = lstDiameter[i].codsec.ToString();
                dgvDiameter.Rows[i].Cells["clmDiameterName"].Value = lstDiameter[i].name;
                dgvDiameter.Rows[i].Cells["clmDiameterInitial"].Value = lstDiameter[i].abbreviation;
                dgvDiameter.Rows[i].Cells["clmDiameterValue"].Value = lstDiameter[i].value;

            }
        }

        #endregion

        #region "Diameter Function"

        clsDiameter objDiameter = new clsDiameter();

        public void clearDiameterFields()
        {

            txtDiameterName.BackColor = Color.White;
            txtDiameterInitial.BackColor = Color.White;
            txtDiameterValue.BackColor = Color.White;
            lblDiameterName.ForeColor = Color.Black;
            lblDiameterInitial.ForeColor = Color.Black;
            lblDiameterValue.ForeColor = Color.Black;
            txtDiameterName.Clear();
            txtDiameterInitial.Clear();
            txtDiameterValue.Clear();
            grpbDiameterForm.Enabled = false;
        }
        public bool validateFormDiameter()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDiameterName, ref lblDiameterName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtDiameterInitial, ref lblDiameterInitial, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtDiameterValue, ref lblDiameterValue, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnDiameterAdd_Click(object sender, EventArgs e)
        {
            grpbDiameterForm.Enabled = true;
        }

        private void btnDiameterSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormDiameter())
                {
                    objDiameter.name = txtDiameterName.Text;
                    objDiameter.abbreviation = txtDiameterInitial.Text;
                    objDiameter.value = Convert.ToInt32(txtDiameterValue.Text);

                    if (objDiameter.save())
                    {
                        grpbDiameterForm.Enabled = false;
                        MessageBox.Show("El diametro se ha guardado con éxito.", "Diametros", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadDiameterInfo();
                        clearDiameterFields();
                        objDiameter = new clsDiameter();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Diametros", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Diametros", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnDiameterEdit_Click(object sender, EventArgs e)
        {
            grpbDiameterForm.Enabled = true;
            objDiameter.load(Convert.ToInt32(dgvDiameter.SelectedRows[0].Cells["clmDiameterCodsec"].Value.ToString()));
            txtDiameterName.Text = objDiameter.name;
            txtDiameterInitial.Text = objDiameter.abbreviation;
            txtDiameterValue.Text = objDiameter.value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearDiameterFields();
        }
        #endregion

        #region "Inning Info"

        public void loadInningInfo()
        {
            List<clsInning> lstInning = new List<clsInning>();

            grpbInningList.Enabled = true;
            grpbInningForm.Enabled = false;

            lstInning.Clear();
            lstInning = clsInning.getList();

            dgvInning.Rows.Clear();


            for (int i = 0; i < lstInning.Count; i++)
            {
                dgvInning.Rows.Add();
                dgvInning.Rows[i].Cells["clmInningCodsec"].Value = lstInning[i].codsec.ToString();
                dgvInning.Rows[i].Cells["clmInningName"].Value = lstInning[i].name;
                dgvInning.Rows[i].Cells["clmInningDescription"].Value = lstInning[i].description;

            }
        }

         
        #endregion

        #region "Inning Function"

        clsInning objInning = new clsInning();

        public void clearInningFields()
        {

            txtInningName.BackColor = Color.White;
            txtInningDescription.BackColor = Color.White;
            lblInningName.ForeColor = Color.Black;
            lblInningDescription.ForeColor = Color.Black;
            txtInningName.Clear();
            txtInningDescription.Clear();
            grpbInningForm.Enabled = false;
        }
        public bool validateFormInning()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtInningName, ref lblInningName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtInningDescription, ref lblInningDescription, "notEmpty")) isValid = false;

            return isValid;
        }
        private void btnInningAdd_Click(object sender, EventArgs e)
        {
            grpbInningForm.Enabled = true;
        }

        private void btnInningSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormInning())
                {
                    objInning.name = txtInningName.Text;
                    objInning.description = txtInningDescription.Text;

                    if (objInning.save())
                    {
                        grpbInningForm.Enabled = false;
                        MessageBox.Show("El turno se ha guardado con éxito.", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadInningInfo();
                        clearInningFields();
                        objInning = new clsInning();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnInningEdit_Click(object sender, EventArgs e)
        {
            grpbInningForm.Enabled = true;
            objInning.load(Convert.ToInt32(dgvInning.SelectedRows[0].Cells["clmInningCodsec"].Value.ToString()));
            txtInningName.Text = objInning.name;
            txtInningDescription.Text = objInning.description;
        }

        private void btnInningCancel_Click(object sender, EventArgs e)
        {
            clearInningFields();
        }


        #endregion

        #region "MainCoilType Info"

        public void loadMainCoilTypeInfo()
        {
            List<clsTypeMainCoil> lstMainCoilType = new List<clsTypeMainCoil>();


            grpbMainCoilTypeList.Enabled = true;
            grpbMainCoilTypeForm.Enabled = false;

            lstMainCoilType.Clear();
            lstMainCoilType = clsTypeMainCoil.getList();

            dgvMainCoilType.Rows.Clear();


            for (int i = 0; i < lstMainCoilType.Count; i++)
            {
                dgvMainCoilType.Rows.Add();
                dgvMainCoilType.Rows[i].Cells["clmMainCoilTypeCodsec"].Value = lstMainCoilType[i].codsec.ToString();
                dgvMainCoilType.Rows[i].Cells["clmMainCoilTypeName"].Value = lstMainCoilType[i].name;
                dgvMainCoilType.Rows[i].Cells["clmMainCoilTypeDescription"].Value = lstMainCoilType[i].description;

            }
        }
        #endregion

        #region "MainCoilType Function"

        clsTypeMainCoil objMainCoilType = new clsTypeMainCoil();

        public void clearMainCoilTypeFields()
        {

            txtMainCoilTypeName.BackColor = Color.White;
            txtMainCoilTypeDescription.BackColor = Color.White;
            lblMainCoilTypeName.ForeColor = Color.Black;
            lblMainCoilTypeDescription.ForeColor = Color.Black;
            txtMainCoilTypeName.Clear();
            txtMainCoilTypeDescription.Clear();
            grpbMainCoilTypeForm.Enabled = false;
        }
        public bool validateFormMainCoilTypeForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtMainCoilTypeName, ref lblMainCoilTypeName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtMainCoilTypeDescription, ref lblMainCoilTypeDescription, "notEmpty")) isValid = false;

            return isValid;
        }


        private void btnMainCoilTypeAdd_Click(object sender, EventArgs e)
        {
            grpbMainCoilTypeForm.Enabled = true;
        }

        private void btnMainCoilTypeSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormMainCoilTypeForm())
                {
                    objMainCoilType.name = txtMainCoilTypeName.Text;
                    objMainCoilType.description = txtMainCoilTypeDescription.Text;

                    if (objMainCoilType.save())
                    {
                        grpbMainCoilTypeForm.Enabled = false;
                        MessageBox.Show("El tipo de rollo madre se ha guardado con éxito.", "Tipos Rollos Madres", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadMainCoilTypeInfo();
                        clearMainCoilTypeFields();
                        objMainCoilType = new clsTypeMainCoil();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipos Rollos Madres", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipos Rollos Madres", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnMainCoilTypeEdit_Click(object sender, EventArgs e)
        {
            grpbMainCoilTypeForm.Enabled = true;
            objMainCoilType.load(Convert.ToInt32(dgvMainCoilType.SelectedRows[0].Cells["clmMainCoilTypeCodsec"].Value.ToString()));
            txtMainCoilTypeName.Text = objMainCoilType.name;
            txtMainCoilTypeDescription.Text = objMainCoilType.description;
        }

        private void btnMainCoilTypeCancel_Click(object sender, EventArgs e)
        {
            clearMainCoilTypeFields();
        }

        #endregion

        #region "Decrease Info"

        public void loadDecreaseInfo()
        {
            List<clsDecrease> lstDecrease = new List<clsDecrease>();


            grpbDecreasList.Enabled = true;
            grpbDecreasForm.Enabled = false;

            lstDecrease.Clear();
            lstDecrease = clsDecrease.getList();

            dgvDecrease.Rows.Clear();


            for (int i = 0; i < lstDecrease.Count; i++)
            {
                dgvDecrease.Rows.Add();
                dgvDecrease.Rows[i].Cells["clmDecreaseCodsec"].Value = lstDecrease[i].codsec;
                dgvDecrease.Rows[i].Cells["clmDecreaseName"].Value = lstDecrease[i].name;
                dgvDecrease.Rows[i].Cells["clmDecreaseDescription"].Value = lstDecrease[i].description;

            }
        }

        #endregion

        #region "Decrease Function"

        clsDecrease objDecrease = new clsDecrease();

        public void clearDecreaseFields()
        {

            txtDecreaseName.BackColor = Color.White;
            txtDecreaseDescription.BackColor = Color.White;
            lblDecreaseName.ForeColor = Color.Black;
            lblDecreaseDescription.ForeColor = Color.Black;
            txtDecreaseName.Clear();
            txtDecreaseDescription.Clear();
            grpbDecreasForm.Enabled = false;
        }

        public bool validateDecreaseForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtDecreaseName, ref lblDecreaseName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtDecreaseDescription, ref lblDecreaseDescription, "notEmpty")) isValid = false;

            return isValid;
        }


        private void btnDecreaseAdd_Click(object sender, EventArgs e)
        {
            grpbDecreasForm.Enabled = true; 
        }

        private void btnDecreaseSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateDecreaseForm())
                {
                    objDecrease.name = txtDecreaseName.Text;
                    objDecrease.description = txtDecreaseDescription.Text;

                    if (objDecrease.save())
                    {
                        grpbDecreasForm.Enabled = false;
                        MessageBox.Show("El tipo de merma se ha guardado con éxito.", "Mermas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadDecreaseInfo();
                        clearDecreaseFields();
                        objDecrease = new clsDecrease();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Mermas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Mermas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnDecreaseEdit_Click(object sender, EventArgs e)
        {
            grpbDecreasForm.Enabled = true;
            objDecrease.load(Convert.ToInt32(dgvDecrease.SelectedRows[0].Cells["clmDecreaseCodsec"].Value.ToString()));
            txtDecreaseName.Text = objDecrease.name;
            txtDecreaseDescription.Text = objDecrease.description;
        }

        private void btnDecreaseCancel_Click(object sender, EventArgs e)
        {
            clearDecreaseFields();
        }
        #endregion


        #region "User Info"

        public void loadUserInfo()
        {
            

            grpbUserList.Enabled = true;
            grpbUserForm.Enabled = false;

            
            List<clsUser> lstUser = new List<clsUser>();
            lstUser.Clear();
            lstUser = clsUser.getList();

            dgvUser.Rows.Clear();


            for (int i = 0; i < lstUser.Count; i++)
            {
                dgvUser.Rows.Add();
                dgvUser.Rows[i].Cells["clmUserCodsec"].Value = lstUser[i].codsec.ToString();
                dgvUser.Rows[i].Cells["clmUserName"].Value = lstUser[i].firstName;
                dgvUser.Rows[i].Cells["clmUserLastName"].Value = lstUser[i].lastName;
                dgvUser.Rows[i].Cells["clmUserUserName"].Value = lstUser[i].userName;
                dgvUser.Rows[i].Cells["clmUserRole"].Value = lstUser[i].RoleName;
                dgvUser.Rows[i].Cells["clmUserStatus"].Value = lstUser[i].StatusName;
                dgvUser.Rows[i].Cells["clmUserInningName"].Value = lstUser[i].InningName;
                dgvUser.Rows[i].Cells["clmUserCreatedDate"].Value = lstUser[i].createdDate;
                dgvUser.Rows[i].Cells["clmUserCreatorUser"].Value = lstUser[i].creatorUser;
                dgvUser.Rows[i].Cells["clmUserModificatorDate"].Value = lstUser[i].modifiedDate;
                dgvUser.Rows[i].Cells["clmUserModificatorUser"].Value = lstUser[i].modificatorUser;
                
            }
        }



        #endregion

        #region "User Function"

        clsUser objUser = new clsUser();

        public void clearUserFields()
        {

            txtUserName.BackColor = Color.White;
            txtUserLastName.BackColor = Color.White;
            txtUserUserName.BackColor = Color.White;
            txtUserPassword.BackColor = Color.White;
            txtUserName.Clear();
            txtUserLastName.Clear();
            txtUserUserName.Clear();
            txtUserPassword.Clear();
            lblUserName.ForeColor = Color.Black;
            lblUserLastName.ForeColor = Color.Black;
            lblUserUserName.ForeColor = Color.Black;
            lblUserPassword.ForeColor = Color.Black;
            grpbUserForm.Enabled = false;
        }
        public bool validateFormUser()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtUserName, ref lblUserName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtUserLastName, ref lblUserLastName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtUserUserName, ref lblUserUserName, "notEmpty")) isValid = false;
            if ((objUser.codsec != 0 && chbxPasswordChange.Checked) || objUser.codsec == 0)
                if (!clsValidation.validateField(ref txtUserPassword, ref lblUserPassword, "notEmpty")) isValid = false;
            
            if (!clsValidation.validateField(ref cmbUserInning, ref lblUserInning, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbUserRole, ref lblUserRole, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbUserStatus, ref lblUserStatus, "selected")) isValid = false;

            return isValid;
        }


        public void loadInningList()
        {
            List<clsInning> lstInning = new List<clsInning>();

            lstInning = clsInning.getList();

            cmbUserInning.Items.Clear();
            for (int i = 0; i < lstInning.Count; i++)
            {
                cmbUserInning.Items.Add(lstInning[i]);                
            }
        }

        public void loadRoleList()
        {
            List<clsRole> lstRole = new List<clsRole>();

            lstRole = clsRole.getList();

            cmbUserRole.Items.Clear();
            for (int i = 0; i < lstRole.Count; i++)
            {
                cmbUserRole.Items.Add(lstRole[i]);
                
            }
        }

        public void loadStatusList(string statusGroupName)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();

            lstStatus = clsStatus.getListByStatusGroupName(statusGroupName);

            cmbUserStatus.Items.Clear(); 
            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbUserStatus.Items.Add(lstStatus[i]);
            }
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            grpbUserForm.Enabled = true;
            objUser = new clsUser();
            loadInningList();
            loadRoleList();
            loadStatusList("Usuarios");
        }


        private void btnUserEdit_Click(object sender, EventArgs e)
        {
            grpbUserForm.Enabled = true;
            objUser.load(Convert.ToInt32(dgvUser.SelectedRows[0].Cells["clmUserCodsec"].Value.ToString()));
            txtUserName.Text = objUser.firstName;
            txtUserLastName.Text = objUser.lastName;
            txtUserUserName.Text = objUser.userName;
            txtUserPassword.Enabled = false;
            loadInningList();
            loadRoleList();
            loadStatusList("Usuarios");
           
            for (int i = 0; i < cmbUserInning.Items.Count; i++)
            {
                if (((clsInning)cmbUserInning.Items[i]).codsec == objUser.fkInning)
                {
                    cmbUserInning.SelectedIndex = i;                    
                }
            }
            cmbUserInning.Text = objUser.InningName;

            
            for (int i = 0; i < cmbUserRole.Items.Count; i++)
            {
                if (((clsRole)cmbUserRole.Items[i]).codsec == objUser.fkRole)
                {
                    cmbUserRole.SelectedIndex = i;                    
                }
            }
            cmbUserRole.Text = objUser.RoleName;

            for (int i = 0; i < cmbUserStatus.Items.Count; i++)
            {
                if (((clsStatus)cmbUserStatus.Items[i]).codsec == objUser.fkStatus)
                {
                    cmbUserStatus.SelectedIndex = i;
                }
            }

        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormUser())
                {
                    objUser.firstName = txtUserName.Text;
                    objUser.lastName = txtUserLastName.Text;
                    objUser.userName = txtUserUserName.Text;
                    objUser.password = txtUserPassword.Text;
                    objUser.fkInning = ((clsInning)cmbUserInning.SelectedItem).codsec;
                    objUser.fkRole = ((clsRole)cmbUserRole.SelectedItem).codsec;
                    objUser.fkStatus = ((clsStatus)cmbUserStatus.SelectedItem).codsec;
                    
                    if (objUser.save())
                    {
                        if (objUser.codsec == 0)
                            objUser.codsec = objUser.getLastSavedCodsec();

                        clsUserRole.clearRolesByUser(objUser.codsec);

                        clsUserRole.save(objUser.codsec, ((clsRole)cmbUserRole.SelectedItem).codsec);


                        grpbUserForm.Enabled = false;
                        MessageBox.Show("El usuario se ha guardado con éxito.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadUserInfo();
                        clearUserFields();
                        objUser = new clsUser();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
             }
             catch (Exception ex)
             {
                 clsLog.addLog(ex, 3, this.Name);
                 MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Turnos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                 throw;
             }
        }

        private void chbxPasswordChange_CheckedChanged(object sender, EventArgs e)
        {
            txtUserPassword.Enabled = true;
        }
    

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            clearUserFields();
        }

        #endregion

        #region "Status Group Info"

        public void loadStatusGroupInfo()
        {
            List<clsStatusGroup> lstStatusGroup = new List<clsStatusGroup>();

            grpbStatusGroupList.Enabled = true;
            grpbStatusGroupForm.Enabled = false;

            lstStatusGroup.Clear();
            lstStatusGroup = clsStatusGroup.getList();

            dgvStatusGroup.Rows.Clear();


            for (int i = 0; i < lstStatusGroup.Count; i++)
            {
                dgvStatusGroup.Rows.Add();
                dgvStatusGroup.Rows[i].Cells["clmStatusGroupCodsec"].Value = lstStatusGroup[i].codsec.ToString();
                dgvStatusGroup.Rows[i].Cells["clmStatusGroupName"].Value = lstStatusGroup[i].name;

            }
        }


        #endregion

        #region "Status Group Function"


        clsStatusGroup objStatusGroup = new clsStatusGroup();

        public void clearStatusGroupFields()
        {

            txtStatusGroupName.BackColor = Color.White;
            lblStatusGroupName.ForeColor = Color.Black;
            txtStatusGroupName.Clear();
            grpbStatusGroupForm.Enabled = false;
        }
        public bool validateFormStatusGroup()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtStatusGroupName, ref lblStatusGroupName, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnStatusGroupAdd_Click(object sender, EventArgs e)
        {
            grpbStatusGroupForm.Enabled = true;
        }

        private void btnStatusGroupSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormStatusGroup())
                {
                    objStatusGroup.name = txtStatusGroupName.Text;


                    if (objStatusGroup.save())
                    {
                        grpbStatusGroupForm.Enabled = false;
                        MessageBox.Show("El grupo de estado se ha guardado con éxito.", "Grupo de Estados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadStatusGroupInfo();
                        clearStatusGroupFields();
                        objStatusGroup = new clsStatusGroup();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Grupo de Estados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Grupo de Estados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnStatusGroupEdit_Click(object sender, EventArgs e)
        {
            grpbStatusGroupForm.Enabled = true;
            objStatusGroup.load(Convert.ToInt32(dgvStatusGroup.SelectedRows[0].Cells["clmStatusGroupCodsec"].Value.ToString()));
            txtStatusGroupName.Text = objStatusGroup.name;
        }

        private void btnStatusGroupCancel_Click(object sender, EventArgs e)
        {
            clearStatusGroupFields();
        }
              


        #endregion

        #region "Production Line Info"

        public void loadProductionLineInfo()
        {
            List<clsProductionLine> lstProductionLine = new List<clsProductionLine>();

            grpbProductionLineList.Enabled = true;
            grpbProductionLineForm.Enabled = false;

            lstProductionLine.Clear();
            lstProductionLine = clsProductionLine.getList();

            dgvProductionLine.Rows.Clear();


            for (int i = 0; i < lstProductionLine.Count; i++)
            {
                dgvProductionLine.Rows.Add();
                dgvProductionLine.Rows[i].Cells["clmProductionLineCodsec"].Value = lstProductionLine[i].codsec.ToString();
                dgvProductionLine.Rows[i].Cells["clmProductionLinePlant"].Value = lstProductionLine[i].PlantName;
                dgvProductionLine.Rows[i].Cells["clmProductionLineNumberLine"].Value = lstProductionLine[i].numberLine.ToString();
                dgvProductionLine.Rows[i].Cells["clmProductionLineName"].Value = lstProductionLine[i].name;
                dgvProductionLine.Rows[i].Cells["clmProductionLineDescription"].Value = lstProductionLine[i].description;
                
            }
        }    


        #endregion

        #region "Production Line Function"

        clsProductionLine objProductionLine = new clsProductionLine();

        public void clearProductionLineFields()
        {

            lblProductionLinePlant.BackColor = Color.White;
            lblProductionLineLine.BackColor = Color.White;
            lblProductionLineName.BackColor = Color.White;
            lblProductionLineDescription.BackColor = Color.White;
            txtProductionLineLine.Clear();
            txtProductionLineName.Clear();
            txtProductionLineDescription.Clear();
            grpbProductionLineForm.Enabled = false;
        }

        public bool validateFormProductionLine()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtProductionLineLine, ref lblProductionLineLine, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtProductionLineName, ref lblProductionLineName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtProductionLineDescription, ref lblProductionLineDescription, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbProductionLinePlant, ref lblProductionLinePlant, "selected")) isValid = false;

            return isValid;
        }

        public void loadPlantForProductionLineList()
        {
            List<clsPlant> lstPlant = new List<clsPlant>();

            lstPlant = clsPlant.getList();

            cmbProductionLinePlant.Items.Clear();
            for (int i = 0; i < lstPlant.Count; i++)
            {
                cmbProductionLinePlant.Items.Add(lstPlant[i]);
            }
        }


        private void btnProductionLineAdd_Click(object sender, EventArgs e)
        {
            grpbProductionLineForm.Enabled = true;
            objProductionLine = new clsProductionLine();
            loadPlantForProductionLineList(); 
        }

        private void btnProductionLineSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormProductionLine())
                {
                    objProductionLine.name = txtProductionLineName.Text;
                    objProductionLine.description = txtProductionLineDescription.Text;
                    objProductionLine.numberLine = Convert.ToInt32(txtProductionLineLine.Text);
                    objProductionLine.fkPlant = ((clsPlant)cmbProductionLinePlant.SelectedItem).codsec;


                    if (objProductionLine.save())
                    {

                        grpbProductionLineForm.Enabled = false;
                        MessageBox.Show("La linea se ha guardado con éxito.", "Lineas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadProductionLineInfo();
                        clearProductionLineFields(); 
                        objProductionLine = new clsProductionLine();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Lineas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Lineas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnProductionLineEdit_Click(object sender, EventArgs e)
        {
            grpbProductionLineForm.Enabled = true;
            objProductionLine.load(Convert.ToInt32(dgvProductionLine.SelectedRows[0].Cells["clmProductionLineCodsec"].Value.ToString()));
            txtProductionLineName.Text = objProductionLine.name;
            txtProductionLineDescription.Text = objProductionLine.description;
            txtProductionLineLine.Text = objProductionLine.numberLine.ToString();
            loadPlantForProductionLineList();

            for (int i = 0; i < cmbProductionLinePlant.Items.Count; i++)
            {
                if (((clsPlant)cmbProductionLinePlant.Items[i]).codsec == objProductionLine.fkPlant)
                {
                    cmbProductionLinePlant.SelectedIndex = i;
                }
            }
            cmbProductionLinePlant.Text = objProductionLine.PlantName;
        }

        private void btnProductionLineCancel_Click(object sender, EventArgs e)
        {
            clearProductionLineFields();
        }

        #endregion

        #region "Mold Info"

      

        #endregion

        #region "Status Info"


        public void loadStatusInfo()
        {
            List<clsStatus> lstStatus = new List<clsStatus>();

            grpbStatusList.Enabled = true;
            grpbStatusForm.Enabled = false;

            lstStatus.Clear();
            lstStatus = clsStatus.getList();

            dgvStatus.Rows.Clear();


            for (int i = 0; i < lstStatus.Count; i++)
            {
                dgvStatus.Rows.Add();
                dgvStatus.Rows[i].Cells["clmStatusCodsec"].Value = lstStatus[i].codsec.ToString();
                dgvStatus.Rows[i].Cells["clmStatusName"].Value = lstStatus[i].name;
                dgvStatus.Rows[i].Cells["clmStatusStatusGroup"].Value = lstStatus[i].StatusGroupName;
                dgvStatus.Rows[i].Cells["clmStatusDescription"].Value = lstStatus[i].description;
                dgvStatus.Rows[i].Cells["clmStatusCreatedDate"].Value = lstStatus[i].createdDate;
                dgvStatus.Rows[i].Cells["clmStatusUserCreator"].Value = lstStatus[i].creatorUser;
                dgvStatus.Rows[i].Cells["clmStatusModifiedDate"].Value = lstStatus[i].modifiedDate;
                dgvStatus.Rows[i].Cells["clmStatusModificatorUser"].Value = lstStatus[i].modificatorUser;
                

            }
        }    

        #endregion

        #region "Status Function"

        clsStatus objStatus = new clsStatus();

        public void clearStatusFields()
        {

            
            lblStatusName.BackColor = Color.White;
            lblStatusDescription.BackColor = Color.White;
            txtStatusName.Clear();
            txtStatusDescription.Clear();
            lblStatusName.ForeColor = Color.Black;
            lblStatusDescription.ForeColor = Color.Black;
            grpbStatusForm.Enabled = false;
            cmbStatusGroup.SelectedIndex = -1;
        }
        public bool validateFormStatus()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtStatusName, ref lblStatusName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtStatusDescription, ref lblStatusDescription, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatusGroup, ref lblStatusGroup, "selected")) isValid = false;

            return isValid;
        }

        public void loadStatusGroupList()
        {
            List<clsStatusGroup> lstStatusGroup = new List<clsStatusGroup>();

            lstStatusGroup = clsStatusGroup.getList();

            cmbStatusGroup.Items.Clear();
            for (int i = 0; i < lstStatusGroup.Count; i++)
            {
                cmbStatusGroup.Items.Add(lstStatusGroup[i]);
            }
        }

 
        private void btnStatusAdd_Click(object sender, EventArgs e)
        {
            grpbStatusForm.Enabled = true;
            objStatus = new clsStatus();
            loadStatusGroupList();
        }


        private void btnStatusSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormStatus())
                {
                    objStatus.name = txtStatusName.Text;
                    objStatus.description = txtStatusDescription.Text;
                    objStatus.fkStatusGroup = ((clsStatusGroup)cmbStatusGroup.SelectedItem).codsec;


                    if (objStatus.save())
                    {

                        grpbStatusForm.Enabled = false;
                        MessageBox.Show("El estado se ha guardado con éxito.", "Estados", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadStatusInfo();
                        clearStatusFields();
                        objStatus = new clsStatus();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Estados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Estados", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnStatusEdit_Click(object sender, EventArgs e)
        {
           
            grpbStatusForm.Enabled = true;
            objStatus.load(Convert.ToInt32(dgvStatus.SelectedRows[0].Cells["clmStatusCodsec"].Value.ToString()));             
            txtStatusName.Text = objStatus.name;
            txtStatusDescription.Text = objStatus.description;
            loadStatusGroupList();

            for (int i = 0; i < cmbStatusGroup.Items.Count; i++)
            {
                if (((clsStatusGroup)cmbStatusGroup.Items[i]).codsec == objStatus.fkStatusGroup)
                {
                    cmbStatusGroup.SelectedIndex = i;
                }
            }
            cmbStatusGroup.Text = objStatus.StatusGroupName;
        }

        private void btnStatusCancel_Click(object sender, EventArgs e)
        {
            clearStatusFields();
        }

        #endregion

        #region "Raw Material Type Info"

        public void loadRawMaterialTypeInfo()
        {
            List<clsRawMaterialtype> lstRawMaterialtype = new List<clsRawMaterialtype>();

            grpbRawMaterialTypeForm.Enabled = false;
            grpbRawMaterialTypeList.Enabled = true;

            lstRawMaterialtype.Clear();
            lstRawMaterialtype = clsRawMaterialtype.getList();

            dgvRawMaterialType.Rows.Clear();


            for (int i = 0; i < lstRawMaterialtype.Count; i++)
            {
                dgvRawMaterialType.Rows.Add();
                dgvRawMaterialType.Rows[i].Cells["clmRawMaterilaTypeCodsec"].Value = lstRawMaterialtype[i].codsec.ToString();
                dgvRawMaterialType.Rows[i].Cells["clmRawMaterilaTypeName"].Value = lstRawMaterialtype[i].name;
                dgvRawMaterialType.Rows[i].Cells["clmRawMaterilaTypeCreatedDate"].Value = lstRawMaterialtype[i].createdDate;
                dgvRawMaterialType.Rows[i].Cells["clmRawMaterialTypeCreatorUser"].Value = lstRawMaterialtype[i].creatorUser;
                dgvRawMaterialType.Rows[i].Cells["clmRawMaterialTypeModifiedDate"].Value = lstRawMaterialtype[i].modifiedDate;
                dgvRawMaterialType.Rows[i].Cells["clmRawMaterialTypeModificatorUser"].Value = lstRawMaterialtype[i].modificatorUser;
                

            }
        }
        #endregion

        #region "Raw Material Type Function"

        clsRawMaterialtype objRawMaterialtype = new clsRawMaterialtype();

        public void clearRawMaterialtypeFields()
        {

            txtRawMaterialTypeName.BackColor = Color.White;
            lblRawMaterialTypeName.ForeColor = Color.Black;
            txtRawMaterialTypeName.Clear();
            grpbRawMaterialTypeForm.Enabled = false;
        }

        public bool validateFormRawMaterialtype()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtRawMaterialTypeName, ref lblRawMaterialTypeName, "notEmpty")) isValid = false;
            return isValid;
        }

        private void btnRawMaterialTypeAdd_Click(object sender, EventArgs e)
        {
            grpbRawMaterialTypeForm.Enabled = true;
        }

        private void btnRawMaterialTypeSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormRawMaterialtype())
                {
                    objRawMaterialtype.name = txtRawMaterialTypeName.Text;


                    if (objRawMaterialtype.save())
                    {
                        grpbRawMaterialTypeForm.Enabled = false;
                        MessageBox.Show("El tipo de materia prima se ha guardado con éxito.", "Tipos Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadRawMaterialTypeInfo();
                        clearRawMaterialtypeFields();
                        objRawMaterialtype = new clsRawMaterialtype();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipos Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipos Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnRawMaterialTypeEdit_Click(object sender, EventArgs e)
        {
            grpbRawMaterialTypeForm.Enabled = true;
            objRawMaterialtype.load(Convert.ToInt32(dgvRawMaterialType.SelectedRows[0].Cells["clmRawMaterilaTypeCodsec"].Value.ToString()));
            txtRawMaterialTypeName.Text = objRawMaterialtype.name;
        }

        private void btnRawMaterialTypeCancel_Click(object sender, EventArgs e)
        {
            clearRawMaterialtypeFields();
        }

        #endregion

        #region "Raw Material Type By Entity Info"

        public void loadRawMaterialTypeByEntityInfo()
        {
            List<clsRawMaterialTypeByEntity> lstRawMaterialtypeByEntity = new List<clsRawMaterialTypeByEntity>();
            
            grpbRawMaterialTypeByEntityForm.Enabled = false;
            grpbRawMaterialTypeByEntityList.Enabled = true;

            lstRawMaterialtypeByEntity.Clear();
            lstRawMaterialtypeByEntity = clsRawMaterialTypeByEntity.getList();

            dgvRawMaterialTypeByEntity.Rows.Clear();


            for (int i = 0; i < lstRawMaterialtypeByEntity.Count; i++)
            {
                dgvRawMaterialTypeByEntity.Rows.Add();    
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityCodsec"].Value = lstRawMaterialtypeByEntity[i].codsec.ToString();
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityEntityName"].Value = lstRawMaterialtypeByEntity[i].entityName;
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityName"].Value = lstRawMaterialtypeByEntity[i].name;
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityCreatedDate"].Value = lstRawMaterialtypeByEntity[i].createdDate;
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityCreatedBy"].Value = lstRawMaterialtypeByEntity[i].creatorUser;
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityModifiedDate"].Value = lstRawMaterialtypeByEntity[i].modifiedDate;
                dgvRawMaterialTypeByEntity.Rows[i].Cells["clmRawMaterialTypeByEntityModifiedBy"].Value = lstRawMaterialtypeByEntity[i].modificatorUser;

            }
        }




        #endregion

        #region "Raw Material Type By Entity Function"

        clsRawMaterialTypeByEntity objRawMaterialtypeByEntity = new clsRawMaterialTypeByEntity();
        clsEntity objEntity = new clsEntity();

        public void clearRMEntityFields()
        {
            lblMillName.ForeColor = Color.Black;
            lblMillStatus.ForeColor = Color.Black;
            cmbRawMaterialTypeByEntityEntityName.SelectedItem = -1;
        }

        
        public bool validateFormRawMaterialTypeByEntity()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbRawMaterialTypeByEntityEntityName, ref lblRawMaterialTypeByEntityEntityName, "selected")) isValid = false;

            return isValid;
        }

        public void loadEntityList()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();

            lstEntity = clsEntity.getProviderList();

            cmbRawMaterialTypeByEntityEntityName.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
            {
                cmbRawMaterialTypeByEntityEntityName.Items.Add(lstEntity[i]);

            }
        }

        private void btnRMTypeByEntityAdd_Click(object sender, EventArgs e)
        {
            
            grpbRawMaterialTypeByEntityForm.Enabled = true;
            rdoOneType.Checked = true;
            loadEntityList();
            List<clsRawMaterialtype> lstRawMaterialtype = new List<clsRawMaterialtype>();
            lstRawMaterialtype = clsRawMaterialtype.getList();

            lstbTypes.Items.Clear();
            for (int i = 0; i < lstRawMaterialtype.Count; i++)
            {
                lstbTypes.Items.Add(lstRawMaterialtype[i]);
            }
        }

        private void rdoManyTypes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneType.Checked == false)
            {
                lstbTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;

            }
            else
            {
                lstbTypes.SelectedIndex = -1;
                lstbTypes.SelectionMode = System.Windows.Forms.SelectionMode.One;

            }
        }

        private void btnRMTypeByEntitySave_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (validateFormRawMaterialTypeByEntity())
                {
                   if (rdoOneType.Checked == true)
                    {
                        if ((clsRawMaterialTypeByEntity.save(Convert.ToInt32((((clsRawMaterialtype)lstbTypes.SelectedItem).codsec)), Convert.ToInt32(((clsEntity)cmbRawMaterialTypeByEntityEntityName.SelectedItem).codsec))))
                    {
                        
                        grpbRawMaterialTypeByEntityForm.Enabled = false;
                        MessageBox.Show("Los Tipos de Materia Prima por proveedor se ha guardado con éxito.", "Tipo Mp por Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadRawMaterialTypeByEntityInfo(); 
                        clearRawMaterialtypeFields();
                        objRawMaterialtypeByEntity = new clsRawMaterialTypeByEntity();
                        objEntity = new clsEntity();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "v", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                    
                   else 
                   {
                      if (rdoManyTypes.Checked == true)
                    {
                           for (int i = 0; i < lstbTypes.SelectedItems.Count; i++)
                           {
                        //       clsRawMaterialTypeByEntity.save(Convert.ToInt32((((clsRawMaterialtype)lstbTypes.SelectedItem[i]).codsec)), Convert.ToInt32(((clsEntity)cmbRawMaterialTypeByEntityEntityName.SelectedItem).codsec));
                           }

                           grpbRawMaterialTypeByEntityForm.Enabled = false;
                            MessageBox.Show("Los Tipos de Materia Prima por proveedor se ha guardado con éxito.", "Tipo Mp por Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            loadRawMaterialTypeByEntityInfo(); 
                            clearRawMaterialtypeFields();
                       
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "v", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                   }

            }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipo Mp por Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }



           
        }
        
        private void btnRMTypeByEntityEdit_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region "Supply By Entity Info"

        public void loadSupplyByEntityInfo()
        {
            List<clsSupplyByEntity> lstSupplyByEntity = new List<clsSupplyByEntity>();

            grpbSubbplyByEntityForm.Enabled = false;
            grpbSubbplyByEntityDetail.Enabled = true;

            lstSupplyByEntity.Clear();
            lstSupplyByEntity = clsSupplyByEntity.getList();

            dgvSupplyByEntity.Rows.Clear();


            for (int i = 0; i < lstSupplyByEntity.Count; i++)
            {
                dgvSupplyByEntity.Rows.Add();
                dgvSupplyByEntity.Rows[i].Cells["clmSupplyByEntityCodsec"].Value = lstSupplyByEntity[i].codsec.ToString();
                dgvSupplyByEntity.Rows[i].Cells["clmSupplyByEntityfkEntity"].Value = lstSupplyByEntity[i].fkEntity.ToString();
                dgvSupplyByEntity.Rows[i].Cells["clmSupplyByEntityEntityName"].Value = lstSupplyByEntity[i].entityName;
                dgvSupplyByEntity.Rows[i].Cells["clmSupplyByEntityfkSupply"].Value = lstSupplyByEntity[i].fkSupply.ToString();
                dgvSupplyByEntity.Rows[i].Cells["clmSupplyByEntitySupplyName"].Value = lstSupplyByEntity[i].SupplyName;
            }
        }




        #endregion


        #region "Supply By Entity Function"

        clsSupplyByEntity objSupplyByEntity = new clsSupplyByEntity();
      //  clsEntity objEntity = new clsEntity();
        clsSupply objSupply = new clsSupply();

        public void clearSupplyEntityFields()
        {
            lblSupplyByentityEntity.ForeColor = Color.Black;
            lblSupplyByentitySupply.ForeColor = Color.Black;
            cmbSupplyByentityEntity.SelectedItem = -1;
            cmbSupplyByentitySupply.SelectedItem = -1;
        }


        public bool validateFormSupplyEntity()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbSupplyByentityEntity, ref lblSupplyByentityEntity, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSupplyByentitySupply, ref lblSupplyByentitySupply, "selected")) isValid = false;

            return isValid;
        }

        public void loadEntityListSubbplyByEntity()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();

            lstEntity = clsEntity.getProviderList();

            cmbSupplyByentityEntity.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
            {
                cmbSupplyByentityEntity.Items.Add(lstEntity[i]);

            }
        }

        public void loadSupplyList()
        {
            List<clsSupply> lstSupply = new List<clsSupply>();

            lstSupply = clsSupply.getList();

            cmbSupplyByentitySupply.Items.Clear();
            for (int i = 0; i < lstSupply.Count; i++)
            {
                cmbSupplyByentitySupply.Items.Add(lstSupply[i]);

            }
        }
        private void btnSupplyByEntityAdd_Click(object sender, EventArgs e)
        {
            grpbSubbplyByEntityForm.Enabled = true;
            loadEntityListSubbplyByEntity();
            loadSupplyList();
        }

        private void btnSupplyByEntitySave_Click(object sender, EventArgs e)
        {
            clsSupplyByEntity objSupplyByEntity = new clsSupplyByEntity();

            try
            {

                if (validateFormSupplyEntity())
                {
                    
                        objSupplyByEntity.fkEntity = Convert.ToInt32(((clsEntity)cmbSupplyByentityEntity.SelectedItem).codsec);
                        objSupplyByEntity.fkSupply = Convert.ToInt32(((clsSupply)cmbSupplyByentitySupply.SelectedItem).codsec);

                        objSupplyByEntity.save();


                            grpbSubbplyByEntityForm.Enabled = false;
                            MessageBox.Show("Los Suministros por proveedor se ha guardado con éxito.", "Tipo Suministros por Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            loadSupplyByEntityInfo();
                            clearSupplyEntityFields();
                            objSupplyByEntity = new clsSupplyByEntity();
                            objEntity = new clsEntity();
                            objSupply = new clsSupply();
                       
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "v", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    catch (Exception ex)
                    {
                        clsLog.addLog(ex, 3, this.Name);
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Tipo Suministros por Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        throw;
                    }            

        }

        private void btnSupplyByEntityEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnSupplyByEntityCancel_Click(object sender, EventArgs e)
        {
            clearSupplyEntityFields();
        }

        


    

        #endregion
       

        #region "Raw Material Info"

        public void loadRawMaterialInfo()
        {

            List<clsRawMaterial> lstRawMaterial = new List<clsRawMaterial>();


            grpbRawMaterialForm.Enabled = false;
            grpbRawMaterialList.Enabled = true;

            lstRawMaterial.Clear();
            lstRawMaterial = clsRawMaterial.getList();

            dgvRawMaterial.Rows.Clear();


            for (int i = 0; i < lstRawMaterial.Count; i++)
            {
                dgvRawMaterial.Rows.Add();
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialCodsec"].Value = lstRawMaterial[i].codsec.ToString();
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialType"].Value = lstRawMaterial[i].RawMaterialtypeName;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialEntity"].Value = lstRawMaterial[i].EntityName;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialName"].Value = lstRawMaterial[i].name;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialCode"].Value = lstRawMaterial[i].code;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialUnit"].Value = lstRawMaterial[i].UnitName;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialPackagingType"].Value = lstRawMaterial[i].PackagingTypeName;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialCreatedDate"].Value = lstRawMaterial[i].createdDate;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialCreatorUser"].Value = lstRawMaterial[i].creatorUser;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialModifiedDate"].Value = lstRawMaterial[i].modifiedDate;
                dgvRawMaterial.Rows[i].Cells["clmRawMaterialModificatorUser"].Value = lstRawMaterial[i].modificatorUser;

            }
        
        }

        #endregion

        #region "Raw Material Function"

        clsRawMaterial objRawMaterial = new clsRawMaterial();

        private void cmbRawMaterialEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //loadRawMaterialTypeByEntityList();
        }

        public void loadRawMaterialTypeByEntityList()
        {
            List<clsRawMaterialTypeByEntity> lstRawMaterialTypeByEntity = new List<clsRawMaterialTypeByEntity>();

            cmbRawMaterialType.Items.Clear();
            if (cmbRawMaterialEntity.SelectedIndex + 1 > 0)
            {
                lstRawMaterialTypeByEntity = clsRawMaterialTypeByEntity.getListByEntity(((clsEntity)cmbRawMaterialEntity.SelectedItem).codsec);


                for (int i = 0; i < lstRawMaterialTypeByEntity.Count; i++)
                {
                    cmbRawMaterialType.Items.Add(lstRawMaterialTypeByEntity[i]);
                }
            }
        }

        public void loadProviderList()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();

            lstEntity = clsEntity.getProviderList();


            cmbRawMaterialEntity.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
            {
                cmbRawMaterialEntity.Items.Add(lstEntity[i]);

            }
        }

        public void loadRawMaterialUnitList()
        {
            List<clsUnit> lstUnit = new List<clsUnit>();

            lstUnit = clsUnit.getList();
            
            cmbRawMaterialUnit.Items.Clear();
            for (int i = 0; i < lstUnit.Count; i++)
            {
                cmbRawMaterialUnit.Items.Add(lstUnit[i]);

            }
        }

        public void loadRawMaterialPackaginList()
        {
            List<clsPackagingType> lstPackaging = new List<clsPackagingType>();

            lstPackaging = clsPackagingType.getList();

            cmbPackagingType.Items.Clear();
            for (int i = 0; i < lstPackaging.Count; i++)
            {
                cmbPackagingType.Items.Add(lstPackaging[i]);
                
            }
        }

        public void loadRawMaterialtypeList()
        {
            List<clsRawMaterialtype> lstRawMaterialType = new List<clsRawMaterialtype>();

            lstRawMaterialType = clsRawMaterialtype.getList();

            cmbRawMaterialType.Items.Clear();
            for (int i = 0; i < lstRawMaterialType.Count; i++)
            {
                cmbRawMaterialType.Items.Add(lstRawMaterialType[i]);
                
            }
        }
        public void clearRawMaterialFields()
        {
            

            txtRawMaterialCode.BackColor = Color.White;
            lblRawMaterialCode.ForeColor = Color.Black;
            txtRawMaterialName.BackColor = Color.White;
            lblRawMaterialName.ForeColor = Color.Black;
            txtRawMaterialNote.BackColor = Color.White;
            lblRawMaterialNote.ForeColor = Color.Black;
            lblRawMaterialEntity.ForeColor = Color.Black;
            lblRawMaterialType.ForeColor = Color.Black;
            lblRawMaterialUnit.ForeColor = Color.Black;
            lblPackagingType.ForeColor = Color.Black;
            txtRawMaterialCode.Clear();
            txtRawMaterialName.Clear();
            txtRawMaterialNote.Clear();
            grpbRawMaterialForm.Enabled = false;
            cmbRawMaterialEntity.SelectedIndex = -1;
            cmbRawMaterialType.SelectedIndex = -1;
            cmbRawMaterialUnit.SelectedIndex = -1;
            cmbPackagingType.SelectedIndex = -1;
        }
        public bool validateFormRawMaterial()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtRawMaterialCode, ref lblRawMaterialCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtRawMaterialName, ref lblRawMaterialName, "notEmpty")) isValid = false;
            //if (!clsValidation.validateField(ref txtRawMaterialNote, ref lblRawMaterialNote, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbRawMaterialEntity, ref lblRawMaterialEntity, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbRawMaterialType, ref lblRawMaterialType, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbRawMaterialUnit, ref lblRawMaterialUnit, "selected")) isValid = false;

            return isValid;
        }


        private void btnRawMaterialAdd_Click(object sender, EventArgs e)
        {
            grpbRawMaterialForm.Enabled = true;
            loadProviderList();
            loadRawMaterialUnitList();
            loadRawMaterialPackaginList();
            loadRawMaterialtypeList();
            
        }

        private void btnRawMaterialSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormRawMaterial())
                {
                    objRawMaterial.code = txtRawMaterialCode.Text;
                    objRawMaterial.name = txtRawMaterialName.Text;
                    objRawMaterial.note = txtRawMaterialNote.Text;
                    objRawMaterial.fkEntity = ((clsEntity)cmbRawMaterialEntity.SelectedItem).codsec;                     
                    objRawMaterial.fkUnit = ((clsUnit)cmbRawMaterialUnit.SelectedItem).codsec; 
                    objRawMaterial.fkPackagingType = ((clsPackagingType)cmbPackagingType.SelectedItem).codsec;
                    objRawMaterial.fkRawMaterialtype = ((clsRawMaterialtype)cmbRawMaterialType.SelectedItem).codsec;
                    if (objRawMaterial.save())
                    {

                        grpbRawMaterialForm.Enabled = false;
                        MessageBox.Show("La materia Prima se ha guardado con éxito.", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadRawMaterialInfo();
                        clearRawMaterialFields();
                        objRawMaterial = new clsRawMaterial();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Materias Primas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                
            }
        }

        private void btnRawMaterialEdit_Click(object sender, EventArgs e)
        {
            grpbRawMaterialForm.Enabled = true;
            objRawMaterial.load(Convert.ToInt32(dgvRawMaterial.SelectedRows[0].Cells["clmRawMaterialCodsec"].Value.ToString()));
            txtRawMaterialCode.Text = objRawMaterial.code;
            txtRawMaterialName.Text = objRawMaterial.name;
            txtRawMaterialNote.Text = objRawMaterial.note;
            loadProviderList();
            loadRawMaterialUnitList();
            loadRawMaterialPackaginList();

            for (int i = 0; i < cmbRawMaterialEntity.Items.Count; i++)
            {
                if (((clsEntity)cmbRawMaterialEntity.Items[i]).codsec == objRawMaterial.fkEntity)
                {
                    cmbRawMaterialEntity.SelectedIndex = i;
                }
            }


            for (int i = 0; i < cmbRawMaterialType.Items.Count; i++)
            {
                if (((clsRawMaterialTypeByEntity)cmbRawMaterialType.Items[i]).codsec == objRawMaterial.fkRawMaterialtype)
                {
                    cmbRawMaterialType.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbRawMaterialUnit.Items.Count; i++)
            {
                if (((clsUnit)cmbRawMaterialUnit.Items[i]).codsec == objRawMaterial.fkUnit)
                {
                    cmbRawMaterialUnit.SelectedIndex = i;
                }
            }
            for (int i = 0; i < cmbPackagingType.Items.Count; i++)
            {
                if (((clsPackagingType)cmbPackagingType.Items[i]).codsec == objRawMaterial.fkPackagingType)
                {
                    cmbPackagingType.SelectedIndex = i;
                }
            }
        }

        private void btnRawMaterialCancel_Click(object sender, EventArgs e)
        {
            clearRawMaterialFields();
        }

        #endregion


        #region "Supply Info"

        public void loadSupplyInfo()
        {

            List<clsSupply> lstSupply = new List<clsSupply>();


            grpbSupplyForm.Enabled = false;
            grpbSupply.Enabled = true;

            lstSupply.Clear();
            lstSupply = clsSupply.getList();

            dgvSupply.Rows.Clear();


            for (int i = 0; i < lstSupply.Count; i++)
            {
                dgvSupply.Rows.Add();
                dgvSupply.Rows[i].Cells["clmSupplyCodsec"].Value = lstSupply[i].codsec.ToString();
                dgvSupply.Rows[i].Cells["clmSupplyEntity"].Value = lstSupply[i].EntityName;
                dgvSupply.Rows[i].Cells["clmSupplyName"].Value = lstSupply[i].name;
                dgvSupply.Rows[i].Cells["clmSupplyCode"].Value = lstSupply[i].code;
                dgvSupply.Rows[i].Cells["clmSupplyUnit"].Value = lstSupply[i].UnitName;
                dgvSupply.Rows[i].Cells["clmSupplyCreatedDate"].Value = lstSupply[i].createdDate;
                dgvSupply.Rows[i].Cells["clmSupplyCreatedBy"].Value = lstSupply[i].creatorUser;
                dgvSupply.Rows[i].Cells["clmSupplyModifiedDate"].Value = lstSupply[i].modifiedDate;
                dgvSupply.Rows[i].Cells["clmSupplyModifiedBy"].Value = lstSupply[i].modificatorUser;
                
            }

        }

        #endregion


        #region "Supply Function"

        //clsSupply objSupply = new clsSupply();

       
        public void loadSupplyProviderList()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();

            lstEntity = clsEntity.getProviderList();


            cmbSupplyEntity.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
            {
                cmbSupplyEntity.Items.Add(lstEntity[i]);

            }
        }

        public void loadUnitList()
        {
            List<clsUnit> lstUnit = new List<clsUnit>();

            lstUnit = clsUnit.getList();

            cmbUnit.Items.Clear();
            for (int i = 0; i < lstUnit.Count; i++)
            {
                cmbUnit.Items.Add(lstUnit[i]);

            }
        }

       
        public void clearSupplyFields()
        {

            txtSupplyCode.BackColor = Color.White;
            lblSupplyCode.ForeColor = Color.Black;
            txtSupplyName.BackColor = Color.White;
            lblSupplyName.ForeColor = Color.Black;
            txtSupplyNotes.BackColor = Color.White;
            lblSupplyNotes.ForeColor = Color.Black;
            txtSupplyCode.Clear();
            txtSupplyName.Clear();
            txtSupplyNotes.Clear();
            grpbSupplyForm.Enabled = false;
            cmbSupplyEntity.SelectedIndex = -1;
            cmbUnit.SelectedIndex = -1;

        }


        public bool validateFormSupply()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtSupplyCode, ref lblSupplyCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtSupplyName, ref lblSupplyName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtSupplyNotes, ref lblSupplyNotes, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbSupplyEntity, ref lblSupplyEntity, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbUnit, ref lblUnit, "selected")) isValid = false;
            
            return isValid;
        }

        private void btnSupplyAdd_Click(object sender, EventArgs e)
        {
            grpbSupplyForm.Enabled = true;
            loadSupplyProviderList();
            loadUnitList();            
        }

        private void btnSupplySave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormSupply())
                {

                    objSupply.code = txtSupplyCode.Text;
                    objSupply.name = txtSupplyName.Text;
                    objSupply.note = txtSupplyNotes.Text;
                    objSupply.fkEntity = ((clsEntity)cmbSupplyEntity.SelectedItem).codsec;
                    objSupply.fkUnit = ((clsUnit)cmbUnit.SelectedItem).codsec;

                    if (objSupply.save())
                    {

                        grpbSupplyForm.Enabled = false;
                        MessageBox.Show("El suministro se ha guardado con éxito.", "Suministros", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadSupplyInfo();
                        clearSupplyFields();
                        objSupply = new clsSupply();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Suministros", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Suministros", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

            }
        }

        private void btnSupplyEdit_Click(object sender, EventArgs e)
        {
            grpbSupplyForm.Enabled = true;
            objSupply.load(Convert.ToInt32(dgvSupply.SelectedRows[0].Cells["clmSupplyCodsec"].Value.ToString()));
            txtSupplyCode.Text = objSupply.code;
            txtSupplyName.Text = objSupply.name;
            txtSupplyName.Text = objSupply.note;
            loadSupplyProviderList();
            loadUnitList();

            for (int i = 0; i < cmbSupplyEntity.Items.Count; i++)
            {
                if (((clsEntity)cmbSupplyEntity.Items[i]).codsec == objSupply.fkEntity)
                {
                    cmbSupplyEntity.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cmbUnit.Items.Count; i++)
            {
                if (((clsUnit)cmbUnit.Items[i]).codsec == objSupply.fkUnit)
                {
                    cmbUnit.SelectedIndex = i;
                }
            }
        }

        private void btnSupplyCancel_Click(object sender, EventArgs e)
        {
            clearSupplyFields();
        }


        #endregion


        #region "Thermoformed Info"


        public void loadThermoformedInfo()
        {
            List<clsThermoformer> lstThermoformed = new List<clsThermoformer>();

            grpbThermoformedDetail.Enabled = true;
            grpbThermoformedForm.Enabled = false;

            lstThermoformed.Clear();
            lstThermoformed = clsThermoformer.getList();


            dgvThermoformed.Rows.Clear();


            for (int i = 0; i < lstThermoformed.Count; i++)
            {
                dgvThermoformed.Rows.Add();
                dgvThermoformed.Rows[i].Cells["clmThermoformedCodsec"].Value = lstThermoformed[i].codsec.ToString();
                dgvThermoformed.Rows[i].Cells["clmThermoformedName"].Value = lstThermoformed[i].name;
                dgvThermoformed.Rows[i].Cells["clmThermoformedFilmWidth"].Value = lstThermoformed[i].filmWidth.ToString();
                dgvThermoformed.Rows[i].Cells["clmThermoformedMinHitsPerMinute"].Value = lstThermoformed[i].minhitsperminute.ToString();
                dgvThermoformed.Rows[i].Cells["clmThermoformedMaxHitsPerMinute"].Value = lstThermoformed[i].maxhitsperminute.ToString();
                if (lstThermoformed[i].includeextruder.ToString().Equals("True"))
                {
                    dgvThermoformed.Rows[i].Cells["clmThermoformedIncludeExtruder"].Value = "Si";
                }
                else
                {
                    dgvThermoformed.Rows[i].Cells["clmThermoformedIncludeExtruder"].Value = "No";
                }

            }
        }


        #endregion


        #region "Thermoformed Funtion"

        clsThermoformer objThermoformer = new clsThermoformer();

        public void clearThermoformerFields()
        {

            chbxThermoformedIncludeExtruder.Checked = false;
            txtThermoformedName.BackColor = Color.White;
            txtThermoformedFilmWidth.BackColor = Color.White;
            txtThermoformedMinHitsPerMinute.BackColor = Color.White;
            txtThermoformedMaxHitsPerMinute.BackColor = Color.White;
            lblThermoformedName.ForeColor = Color.Black;
            lblThermoformedFilmWidth.ForeColor = Color.Black;
            lblThermoformedMinHitsPerMinute.ForeColor = Color.Black;
            lblThermoformedMaxHitsPerMinute.ForeColor = Color.Black;
            txtThermoformedName.Clear();
            txtThermoformedFilmWidth.Clear();
            txtThermoformedMinHitsPerMinute.Clear();
            txtThermoformedMaxHitsPerMinute.Clear();
            grpbThermoformedForm.Enabled = false;
        }

        public bool validateFormThermoformed()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtThermoformedName, ref lblThermoformedName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermoformedFilmWidth, ref lblThermoformedFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermoformedMinHitsPerMinute, ref lblThermoformedMinHitsPerMinute, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermoformedMaxHitsPerMinute, ref lblThermoformedMaxHitsPerMinute, "notEmpty")) isValid = false;


            return isValid;
        }

        private void btnThermoformedAdd_Click(object sender, EventArgs e)
        {
            grpbThermoformedForm.Enabled = true;
        }

        private void btnThermoformedSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormThermoformed())
                {
                    objThermoformer.name = txtThermoformedName.Text;
                    objThermoformer.filmWidth = Convert.ToInt32(txtThermoformedFilmWidth.Text);
                    objThermoformer.minhitsperminute = Convert.ToInt32(txtThermoformedMinHitsPerMinute.Text);
                    objThermoformer.maxhitsperminute = Convert.ToInt32(txtThermoformedMaxHitsPerMinute.Text);
                    objThermoformer.includeextruder = chbxThermoformedIncludeExtruder.Checked;

                    if (objThermoformer.save())
                    {
                        grpbThermoformedForm.Enabled = false;
                        MessageBox.Show("La termoformadora se ha guardado con éxito.", "Termoformadoras", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadThermoformedInfo();
                        grpbThermoformedForm.Enabled = false;
                        clearThermoformerFields();
                        objThermoformer = new clsThermoformer();


                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Termoformadoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Termoformadoras", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnThermoformedEdit_Click(object sender, EventArgs e)
        {
            grpbThermoformedForm.Enabled = true;
            objThermoformer.load(Convert.ToInt32(dgvThermoformed.SelectedRows[0].Cells["clmThermoformedCodsec"].Value.ToString()));

            txtThermoformedName.Text = objThermoformer.name;
            txtThermoformedFilmWidth.Text = objThermoformer.filmWidth.ToString();
            txtThermoformedMinHitsPerMinute.Text = objThermoformer.minhitsperminute.ToString();
            txtThermoformedMaxHitsPerMinute.Text = objThermoformer.maxhitsperminute.ToString();
            chbxThermoformedIncludeExtruder.Checked = objThermoformer.includeextruder;
        }

        private void btnThermoformedCancel_Click(object sender, EventArgs e)
        {
            clearThermoformerFields();
        }

        
       
        #endregion

        #region "Mold Info"

         public void loadMoldInfo()
         {
            List<clsThermMold> lstThermMold = new List<clsThermMold>();

            grpbMoldView.Enabled = true;
            grpbMoldForm.Enabled = false;

            lstThermMold.Clear();
            lstThermMold = clsThermMold.getList();


            dgvMold.Rows.Clear();


            for (int i = 0; i < lstThermMold.Count; i++)
            {
                dgvMold.Rows.Add();
                dgvMold.Rows[i].Cells["clmMoldCodsec"].Value = lstThermMold[i].codsec.ToString();
                dgvMold.Rows[i].Cells["clmMoldName"].Value = lstThermMold[i].name;
                dgvMold.Rows[i].Cells["clmMoldDescription"].Value = lstThermMold[i].description.ToString();
                dgvMold.Rows[i].Cells["clmMoldProduct"].Value = lstThermMold[i].productName.ToString();
                dgvMold.Rows[i].Cells["clmMoldCavityNumber"].Value = lstThermMold[i].cavitiesNumber.ToString();
                
            }
         }



       


        #endregion

         #region "Thermoformed Mold Funtion"

         clsThermMold objThermMold = new clsThermMold();

         public void clearMoldFields()
         {
             
             cmbMoldProduct.SelectedIndex = -1;             
             txtMoldName.BackColor = Color.White;
             txtMoldDescription.BackColor = Color.White;
             txtMoldCavityNumber.BackColor = Color.White;
             lblMoldName.ForeColor = Color.Black;
             lblMoldDescription.ForeColor = Color.Black;
             lblMoldCavityNumber.ForeColor = Color.Black;
             txtMoldName.Clear();
             txtMoldDescription.Clear();
             txtMoldCavityNumber.Clear();
         }

         public bool validateFormMold()
         {
             bool isValid = true;

             if (!clsValidation.validateField(ref txtMoldName, ref lblMoldName, "notEmpty")) isValid = false;
             if (!clsValidation.validateField(ref txtMoldDescription, ref lblMoldDescription, "notEmpty")) isValid = false;
             if (!clsValidation.validateField(ref txtMoldCavityNumber, ref lblMoldCavityNumber, "notEmpty")) isValid = false;
          
             return isValid;
         }

         public void loadProductList()
         {
             List<clsProduct> lstProduct = new List<clsProduct>();

             lstProduct = clsProduct.getThermoformedProductList();

             cmbMoldProduct.Items.Clear();
             for (int i = 0; i < lstProduct.Count; i++)
             {
                 cmbMoldProduct.Items.Add(lstProduct[i]);

             }
         }

         private void btnMoldAdd_Click(object sender, EventArgs e)
         {
             grpbMoldForm.Enabled = true;
             loadProductList();
         }

         private void btnMoldSave_Click(object sender, EventArgs e)
         {
             try
             {

                 if (validateFormMold())
                 {
                     objThermMold.name = txtMoldName.Text;
                     objThermMold.description = txtMoldDescription.Text;
                     objThermMold.cavitiesNumber = Convert.ToInt32(txtMoldCavityNumber.Text);
                     objThermMold.fkProduct = ((clsProduct)cmbMoldProduct.SelectedItem).codsec;

                     if (objThermMold.save())
                     {
                         grpbMoldForm.Enabled = false;
                         MessageBox.Show("El molde se ha guardado con éxito.", "Molde Termoformadora", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                         loadMoldInfo();
                         grpbMoldForm.Enabled = false;
                         clearMoldFields();
                         objThermMold = new clsThermMold();
                     }
                     else
                         MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Molde Termoformadora", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                 }

             }
             catch (Exception ex)
             {
                 clsLog.addLog(ex, 3, this.Name);
                 MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Molde Termoformadora", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                 throw;
             }
         }

         private void btnMoldEdit_Click(object sender, EventArgs e)
         {
             grpbMoldForm.Enabled = true;
             objThermMold.load(Convert.ToInt32(dgvMold.SelectedRows[0].Cells["clmMoldCodsec"].Value.ToString()));
             txtMoldName.Text = objThermMold.name;
             txtMoldDescription.Text = objThermMold.description;
             txtMoldCavityNumber.Text = objThermMold.cavitiesNumber.ToString();
             loadProductList();

             cmbMoldProduct.SelectedItem = objThermMold;
             cmbMoldProduct.Text = objThermMold.productCode;
             
            
         }

         private void btnMoldCancel_Click(object sender, EventArgs e)
         {
             clearMoldFields();
             grpbMoldForm.Enabled = false;
         }

#endregion

         #region "Thermoformed Extruder Info"


         public void loadThermoformedExtruderInfo()
        {
            List<clsThermExtruder> lstThermExtruder = new List<clsThermExtruder>();

            grpbThermExtruderView.Enabled = true;
            grpbThermExtruderForm.Enabled = false;

            lstThermExtruder.Clear();
            lstThermExtruder = clsThermExtruder.getList();


            dgvThermExtruder.Rows.Clear();


            for (int i = 0; i < lstThermExtruder.Count; i++)
            {
                dgvThermExtruder.Rows.Add();
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderCodesc"].Value = lstThermExtruder[i].codsec.ToString();
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderName"].Value = lstThermExtruder[i].name;
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderMinFilmWidth"].Value = lstThermExtruder[i].minFilmWidth.ToString();
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderMaxFilmWidth"].Value = lstThermExtruder[i].maxFilmWidth.ToString();
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderMaxVelocity"].Value = lstThermExtruder[i].maxVelocity.ToString();
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderCoilNumber"].Value = lstThermExtruder[i].coilNumber.ToString();
                dgvThermExtruder.Rows[i].Cells["clmThermExtruderKgPerHour"].Value = lstThermExtruder[i].kilogramsPerHour.ToString();
                
            }
        }


        #endregion

        #region "Thermoformed Extruder Funtion"

        clsThermExtruder objThermExtruder = new clsThermExtruder();

        public void clearThermoformerExtruderFields()
        {


            txtThermExtruderName.BackColor = Color.White;
            txtThermExtruderMinFilmWidth.BackColor = Color.White;
            txtThermExtruderMaxFilmWidth.BackColor = Color.White;
            txtThermExtruderMaxVelocity.BackColor = Color.White;
            txtThermExtruderCoilNumbers.BackColor = Color.White;
            txtThermExtruderKgPerHour.BackColor = Color.White;
            lblThermExtruderName.ForeColor = Color.Black;
            lblThermExtruderMinFilmWidth.ForeColor = Color.Black;
            lblThermExtruderMaxFilmWidth.ForeColor = Color.Black;
            lblThermExtruderMaxVelocity.ForeColor = Color.Black;
            lblThermExtruderCoilNumbers.ForeColor = Color.Black;
            lblThermExtruderKgPerHour.ForeColor = Color.Black;
            txtThermExtruderName.Clear();
            txtThermExtruderMinFilmWidth.Clear();
            txtThermExtruderMaxFilmWidth.Clear();
            txtThermExtruderMaxVelocity.Clear();
            txtThermExtruderCoilNumbers.Clear();
            txtThermExtruderKgPerHour.Clear();

            grpbThermExtruderForm.Enabled = false;

        }

        public bool validateFormThermExtruder()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtThermExtruderName, ref lblThermExtruderName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermExtruderMinFilmWidth, ref lblThermExtruderMinFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermExtruderMaxFilmWidth, ref lblThermExtruderMaxFilmWidth, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermExtruderMaxVelocity, ref lblThermExtruderMaxVelocity, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermExtruderCoilNumbers, ref lblThermExtruderCoilNumbers, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermExtruderKgPerHour, ref lblThermExtruderKgPerHour, "notEmpty")) isValid = false;


            return isValid;
        }


        private void btnThermExtruderAdd_Click(object sender, EventArgs e)
        {
            grpbThermExtruderForm.Enabled = true;
        }

        private void btnThermExtruderSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormThermExtruder())
                {
                    objThermExtruder.name = txtThermExtruderName.Text;
                    objThermExtruder.minFilmWidth = Convert.ToInt32(txtThermExtruderMinFilmWidth.Text);
                    objThermExtruder.maxFilmWidth = Convert.ToInt32(txtThermExtruderMaxFilmWidth.Text);
                    objThermExtruder.maxVelocity = Convert.ToDouble(txtThermExtruderMaxVelocity.Text);
                    objThermExtruder.coilNumber = Convert.ToInt32(txtThermExtruderCoilNumbers.Text);
                    objThermExtruder.kilogramsPerHour = Convert.ToInt32(txtThermExtruderKgPerHour.Text);

                    if (objThermExtruder.save())
                    {
                        grpbThermExtruderForm.Enabled = false;
                        MessageBox.Show("La extrusora se ha guardado con éxito.", "Extrusora de Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadThermoformedExtruderInfo();
                        grpbThermExtruderForm.Enabled = false;
                        clearThermoformerExtruderFields();
                        objThermExtruder = new clsThermExtruder();


                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Extrusora de Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Extrusora de Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnThermExtruderEdit_Click(object sender, EventArgs e)
        {
            grpbThermExtruderForm.Enabled = true;
            objThermExtruder.load(Convert.ToInt32(dgvThermExtruder.SelectedRows[0].Cells["clmThermExtruderCodesc"].Value.ToString()));
            txtThermExtruderName.Text = objThermExtruder.name;
            txtThermExtruderMinFilmWidth.Text = objThermExtruder.minFilmWidth.ToString();
            txtThermExtruderMaxFilmWidth.Text = objThermExtruder.maxFilmWidth.ToString();
            txtThermExtruderMaxVelocity.Text = objThermExtruder.maxVelocity.ToString();
            txtThermExtruderCoilNumbers.Text = objThermExtruder.coilNumber.ToString();
            txtThermExtruderKgPerHour.Text = objThermExtruder.kilogramsPerHour.ToString();
            
        }

        private void btnThermExtruderCancel_Click(object sender, EventArgs e)
        {
            clearThermoformerExtruderFields();
        }



        #endregion


        #region "Thermoformed Defects Info"


        public void loadThermoformedDefectsInfo()
        {
            List<clsThermDefects> lstThermDefects = new List<clsThermDefects>();

            grpbThermDefectsView.Enabled = true;
            grpbThermDefectsForm.Enabled = false;

            lstThermDefects.Clear();
            lstThermDefects = clsThermDefects.getList();


            dgvThermDefect.Rows.Clear();


            for (int i = 0; i < lstThermDefects.Count; i++)
            {
                dgvThermDefect.Rows.Add();
                dgvThermDefect.Rows[i].Cells["clmThermDefectsCodsec"].Value = lstThermDefects[i].codsec.ToString();
                dgvThermDefect.Rows[i].Cells["clmThermDefectsName"].Value = lstThermDefects[i].name;
                dgvThermDefect.Rows[i].Cells["clmThermDefectsDescription"].Value = lstThermDefects[i].description;
            }
        }


        #endregion


        #region "Thermoformed Defects Function"

        clsThermDefects objThermDefects = new clsThermDefects();

        public void clearThermoformerDefectsFields()
        {


            txtThermDefectName.BackColor = Color.White;
            txtThermDefectDescription.BackColor = Color.White;
            lblThermDefectName.ForeColor = Color.Black;
            lblThermDefectDescription.ForeColor = Color.Black;
            txtThermDefectName.Clear();
            txtThermDefectDescription.Clear();

            grpbThermDefectsForm.Enabled = false;

        }

        public bool validateFormThermDefects()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtThermDefectName, ref lblThermDefectName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtThermDefectDescription, ref lblThermDefectDescription, "notEmpty")) isValid = false;
            
            return isValid;
        }

        private void btnThermDefectsAdd_Click(object sender, EventArgs e)
        {
            grpbThermDefectsForm.Enabled = true;
        }

        private void btnThermDefectsSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (validateFormThermDefects())
                {
                    objThermDefects.name = txtThermDefectName.Text;
                    objThermDefects.description = txtThermDefectDescription.Text;

                    if (objThermDefects.save())
                    {
                        grpbThermDefectsForm.Enabled = false;
                        MessageBox.Show("El defecto se ha guardado con éxito.", "Defectos Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        loadThermoformedDefectsInfo();
                        grpbThermDefectsForm.Enabled = false;
                        clearThermoformerDefectsFields();
                        objThermDefects = new clsThermDefects();


                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Defectos Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }

            }
            catch (Exception ex)
            {
                clsLog.addLog(ex, 3, this.Name);
                MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Defectos Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                throw;
            }
        }

        private void btnThermDefectsEdit_Click(object sender, EventArgs e)
        {
            grpbThermDefectsForm.Enabled = true;
            objThermDefects.load(Convert.ToInt32(dgvThermDefect.SelectedRows[0].Cells["clmThermDefectsCodsec"].Value.ToString()));

            txtThermDefectName.Text = objThermDefects.name;
            txtThermDefectDescription.Text = objThermDefects.description;
            
        }

        private void btnThermDefectsCancel_Click(object sender, EventArgs e)
        {
            clearThermoformerDefectsFields();
        }


        #endregion


        public frmSystemConfig()
        {
            frmCellarLogin winLogin = new frmCellarLogin(this);
            winLogin.ShowDialog(this);

            if (isAutoricet)
                InitializeComponent();
            else
                this.Close();
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Attributes["title"].Value));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.Attributes["title"].Value).Trim();
                inTreeNode.Name = inXmlNode.Attributes["action"].Value;
            }
        }    

        private void frmSystemConfig_Load(object sender, EventArgs e)
        {
            try
            {
                XmlDocument dom = new XmlDocument();
                dom.Load("../xmlSystemConfigTree.xml");

                trvConfigs.Nodes.Clear();
                trvConfigs.Nodes.Add(new TreeNode(dom.DocumentElement.Name));
                TreeNode tNode = new TreeNode();

                tNode = trvConfigs.Nodes[0];

                AddNode(dom.DocumentElement, tNode);
               
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void trvConfigs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            changeFormContent(trvConfigs.SelectedNode.Name);
        }

        public void changeFormContent(string contentString)
        {
            switch (trvConfigs.SelectedNode.Name)
            {
                case "geographic":
                    loadCountriesList();

                    pnlGeographic.BringToFront();
                    break;
                case "companyInfo":
                    loadCompanyInfo();
                    pnlCompany.BringToFront();  
                    break;
                case "currency":
                    loadCurrencyInfo();
                    pnlCurrency.BringToFront();
                    break;
                case "commercialCondition":
                    loadCommercialConditionInfo();
                    pnlCommercialCondition.BringToFront();
                    break;
                case "incoterm": 
                    loadIncotermsInfo();
                    pnlIncoterms.BringToFront();
                    break;
                case "transports": 
                    loadTransportInfo();
                    pnlTransport.BringToFront();
                    break;
                case "idtypes":
                    loadIdTypeInfo();
                    pnlIdType.BringToFront();
                    break;
                case "sectors":
                    loadSectorInfo();
                    pnlSector.BringToFront();
                    break;
                case "cellars":                    
                    loadCellarInfo();
                    pnlCellar.BringToFront();
                    break;
                case "lines":   
                    loadProductionLineInfo(); 
                    pnlProductionLine.BringToFront();
                    break;
                case "mainCoilsType":
                    loadMainCoilTypeInfo();
                    pnlTypeMainCoil.BringToFront();
                    break;
                case "decrease":
                    loadDecreaseInfo();
                    pnlDecrease.BringToFront();
                    break;
                case "plants":
                    loadPlantInfo();
                    pnlPlant.BringToFront();
                    break;
                case "languages":
                    loadLanguageInfo();
                    pnlLanguage.BringToFront();
                    break;
                case "boppFilm":
                    pnlBopp.BringToFront();
                    initBoppForm();
                    break;
                case "castFilm":
                    pnlCast.BringToFront();
                    initCastForm();
                    break;
                case "coatingFilm":
                    pnlCoating.BringToFront();
                    initCoatingForm();
                    break;
                case "layers":
                    loadLayerInfo();
                    pnlLayer.BringToFront();
                    break;
                case "role":
                    pnlRole.BringToFront();
                    loadRoleInfo();
                    break;
                case "statusgroup":
                    pnlStatusGroup.BringToFront();
                    loadStatusGroupInfo();
                    break;
                case "cores": 
                    pnlCore.BringToFront();
                    loadCoreInfo();
                    break;
                case "color":
                    pnlColor.BringToFront();
                    loadColorInfo();
                    break;
                case "ounce":
                    pnlOunce.BringToFront();
                    loadOunceInfo();
                    break;
                case "defect":
                    pnlThermDefects.BringToFront();
                    loadThermoformedDefectsInfo();
                    break;
                case "diameters":
                    pnlDiameter.BringToFront();
                    loadDiameterInfo();
                    break;
                case "units": 
                    pnlUnit.BringToFront();
                    loadUnitInfo();
                    break;
                case "packaging": 
                    pnlPackagingType.BringToFront();
                    loadPackagingTypeInfo();
                    break;
                case "cutters":
                    pnlCutter.BringToFront();
                    loadCutterInfo();
                    break;
                case "metallizer":
                    pnlMetallizer.BringToFront();
                    loadMetallizerInfo();
                    break;
                case "extruders": 
                    pnlExtruders.BringToFront();
                    loadExtruderInfo();
                    break;
                case "cellarbyextruder":
                    pnlCellarByExtruder.BringToFront();
                    loadCellarByExtruderInfo();
                    break;
                case "thermoformers": 
                    pnlThermoformed.BringToFront();
                    loadThermoformedInfo();
                    break;
                case "thermoformerextruders":
                    pnlThermExtruder.BringToFront();
                    loadThermoformedExtruderInfo();
                    break;    
               case "coiler": 
                    pnlCoiler.BringToFront();
                    loadCoilerInfo();
                    break;
               case "mold":
                    pnlMold.BringToFront();
                    loadMoldInfo();
                    break;
                case "mills":
                    pnlMill.BringToFront();
                    loadMillInfo();
                    break;
                case "tipomp":
                    pnlRawMaterialType.BringToFront();
                    loadRawMaterialTypeInfo();
                    break;
                case "tipoxprov": 
                    pnlRawMaterialTypeByEntity.BringToFront();
                    loadRawMaterialTypeByEntityInfo();
                    break;
                case "matprima":
                    pnlRawMaterial.BringToFront();
                    loadRawMaterialInfo();
                    break;
                case "supply":
                    pnlSupply.BringToFront();
                    loadSupplyInfo();
                    break;
                case "supplybyentity":
                    pnlSupplyByentity.BringToFront();
                    loadSupplyByEntityInfo();
                    break;
                case "status":
                    pnlStatus.BringToFront();
                    loadStatusInfo();
                    break;
                case "inning":
                    pnlInning.BringToFront();
                    loadInningInfo();
                    break;
                case "user":
                    pnlUser.BringToFront();
                    loadUserInfo();
                    break;
                default:
                    break;
            }
        }

      
        
    }
}