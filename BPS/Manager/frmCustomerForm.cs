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
    public partial class frmCustomerForm : Form
    {
        clsEntity objCustomer = new clsEntity();
        List<clsEntityAddress> lstAddress = new List<clsEntityAddress>();
        clsEntityAddress objAddress = new clsEntityAddress();

        public bool validateCustomerForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtCompanyName, ref lblCompany, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtContactName, ref lblContactName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtId, ref lblId, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbIdType, ref lblIdType, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCustomerCountry, ref lblCustomerCountry, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbSegmentation, ref lblSegmentation, "slected")) isValid = false;
            return isValid;
        }

        public bool validateAddressForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtAddressName, ref lblAddressName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtAddressContact, ref lblAddressContact, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbCity, ref lblCity, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtAddress, ref lblAddress, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtPhone1, ref lblPhones, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtEmail, ref lblEmail, "notEmpty")) isValid = false;
            return isValid;
        }

        public void clearAddressFields()
        {
            txtAddressName.Text = "";
            txtAddressName.BackColor = Color.White;
            lblAddressName.ForeColor = Color.Black;

            txtAddressContact.Text = "";
            txtAddressContact.BackColor = Color.White;
            lblAddressContact.ForeColor = Color.Black;

            cmbCounty.SelectedIndex = -1;
            cmbCounty.BackColor = Color.White;
            lblCountry.ForeColor = Color.Black;

            cmbState.Items.Clear();
            cmbState.BackColor = Color.White;
            lblState.ForeColor = Color.Black;

            cmbCity.Items.Clear();
            cmbCity.BackColor = Color.White;
            cmbCity.ForeColor = Color.Black;

            txtAddress.Text = "";
            txtAddress.BackColor = Color.White;
            lblAddress.ForeColor = Color.Black;

            txtPhone1.Text = "";
            txtPhone1.BackColor = Color.White;
            lblPhones.ForeColor = Color.Black;
            txtPhone2.Text = "";

            txtFax.Text = "";

            txtEmail.Text = "";
            txtEmail.BackColor = Color.White;
            lblEmail.ForeColor = Color.Black;

            txtZip.Text = "";
        }

        public frmCustomerForm()
        {
            InitializeComponent();
        }

        public frmCustomerForm(int codsec)
        {
            InitializeComponent();
            objCustomer.load(codsec);            
            lstAddress = clsEntityAddress.getListByEntity(codsec);
        }

        public void loadCountriesList()
        {
            List<clsCountry> lstCountry = new List<clsCountry>();
            lstCountry = clsCountry.getList();
            cmbCustomerCountry.Items.Clear();
            cmbCounty.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
            {
                cmbCounty.Items.Add(lstCountry[i]);
                cmbCustomerCountry.Items.Add(lstCountry[i]);
            }
        }
        public void loadStateList(int countryCodsec)
        {
            List<clsState> lstState = new List<clsState>();
            lstState = clsState.getListByCountry(countryCodsec);
            cmbState.Items.Clear();
            for (int i = 0; i < lstState.Count; i++)
                cmbState.Items.Add(lstState[i]);
        }
        public void loadCitiesList(int stateCodsec)
        {
            List<clsCity> lstCity = new List<clsCity>();
            lstCity = clsCity.getListByState(stateCodsec);
            cmbCity.Items.Clear();
            for (int i = 0; i < lstCity.Count; i++)
                cmbCity.Items.Add(lstCity[i]);
        }
        public void loadAddressList()
        {
            List<clsEntityAddress> lstAddress = new List<clsEntityAddress>();
            lstAddress = clsEntityAddress.getListByEntity(objCustomer.codsec);
            dgvCustomerAddress.Rows.Clear();
            for (int i = 0; i < lstAddress.Count; i++)
            {
                dgvCustomerAddress.Rows.Add();
                dgvCustomerAddress.Rows[i].Cells["clmCodsec"].Value = lstAddress[i].codsec.ToString();
                dgvCustomerAddress.Rows[i].Cells["clmName"].Value = lstAddress[i].name.ToString();
                dgvCustomerAddress.Rows[i].Cells["clmCity"].Value = lstAddress[i].CityName.ToString();
                dgvCustomerAddress.Rows[i].Cells["clmAddress"].Value = lstAddress[i].address.ToString();
                dgvCustomerAddress.Rows[i].Cells["clmTelephone"].Value = lstAddress[i].phone.ToString();
                dgvCustomerAddress.Rows[i].Cells["clmEmail"].Value = lstAddress[i].email.ToString();
            }
        }
        public void loadAddress(int addressCodsec)
        {
            objAddress = new clsEntityAddress();
            objAddress.load(addressCodsec);
            txtAddressName.Text = objAddress.name;
            txtAddressContact.Text = objAddress.contact;
            txtAddress.Text = objAddress.address;
            clsCity objCity = new clsCity(objAddress.fkCity);
            clsState objState = new clsState(objCity.fkState);
            clsCountry objCountry = new clsCountry(objState.fkCountry);

            for (int i = 0; i < cmbCounty.Items.Count; i++)
            {
                if (((clsCountry)cmbCounty.Items[i]).codsec == objCountry.codsec)
                    cmbCounty.SelectedIndex = i;
            }

            for (int i = 0; i < cmbState.Items.Count; i++)
            {
                if (((clsState)cmbState.Items[i]).codsec == objState.codsec)
                    cmbState.SelectedIndex = i;
            }

            for (int i = 0; i < cmbCounty.Items.Count; i++)
            {
                if (((clsCountry)cmbCounty.Items[i]).codsec == objCountry.codsec)
                    cmbCounty.SelectedIndex = i;
            }
            txtPhone1.Text = objAddress.phone;
            txtPhone2.Text = objAddress.phone2;
            txtFax.Text = objAddress.fax;
            txtEmail.Text = objAddress.email;
            txtZip.Text = objAddress.zip;
        }
        private void frmCustomerForm_Load(object sender, EventArgs e)
        {
            String name = String.Empty;
            List<clsStatus> lstStatus = new List<clsStatus>();
            List<clsIdType> lstIdType = new List<clsIdType>();
            List<clsSegmentation> lstSegmentation = new List<clsSegmentation>();
            
            loadCountriesList();
            lstStatus = clsStatus.getListByStatusGroupName("Entidades");
            lstIdType = clsIdType.getList();
            lstSegmentation = clsSegmentation.getList();
            loadAddressList();

            cmbStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            cmbIdType.Items.Clear();
            for (int i = 0; i < lstIdType.Count; i++)
                cmbIdType.Items.Add(lstIdType[i]);

            cmbSegmentation.Items.Clear();
                for(int i=0; i<lstSegmentation.Count; i++)
                {
                    cmbSegmentation.Items.Add(lstSegmentation[i].SegmentationName);
                }

            if (objCustomer.codsec > 0)
                {
                    grp_customerAddresInfo.Enabled = true;
                    txtCompanyName.Text = objCustomer.companyName;
                    txtContactName.Text = objCustomer.contactName;
                    txtId.Text = objCustomer.id;
                    for (int i = 0; i < cmbCustomerCountry.Items.Count; i++)
                    {
                        if (((clsCountry)cmbCustomerCountry.Items[i]).codsec == objCustomer.fkCountry)
                            cmbCustomerCountry.SelectedIndex = i;
                    }
                    for (int i = 0; i < cmbStatus.Items.Count; i++)
                    {
                        if (((clsStatus)cmbStatus.Items[i]).codsec == objCustomer.fkStatus)
                            cmbStatus.SelectedIndex = i;
                    }
                    for (int i = 0; i < cmbIdType.Items.Count; i++)
                    {
                        if (((clsIdType)cmbIdType.Items[i]).codsec == objCustomer.fkIdType)
                            cmbIdType.SelectedIndex = i;
                    }

                }
                else
                    grp_customerAddresInfo.Enabled = false;
        }

        private void cmbCounty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCounty.SelectedItem != null)
                loadStateList(((clsCountry)cmbCounty.SelectedItem).codsec);
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbState.SelectedItem != null)
                loadCitiesList(((clsState)cmbState.SelectedItem).codsec);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateCustomerForm())
            {
                objCustomer.companyName = txtCompanyName.Text;
                objCustomer.contactName = txtContactName.Text;
                objCustomer.id = txtId.Text;
                objCustomer.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                objCustomer.fkIdType = ((clsIdType)cmbIdType.SelectedItem).codsec;
                objCustomer.fkCountry = ((clsCountry)cmbCustomerCountry.SelectedItem).codsec;
                objCustomer.fkSegmentation = new clsSegmentation(cmbSegmentation.SelectedItem.ToString()).codsec;
                objCustomer.isCustomer = true;
                objCustomer.isProvider = false;

                if (objCustomer.save())
                {
                    MessageBox.Show("El Cliente se ha guardado con éxito.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    if (objCustomer.codsec == 0)
                    {
                        objCustomer.codsec = clsEntity.getLastSavedCustomerCodsec();
                        grp_customerAddresInfo.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            grpbAddressForm.Enabled = true;
            tctrlCustomerAddress.SelectTab(1);
            txtAddressName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (objCustomer.codsec == 0)
                clsGlobal.ClearForm(grpobCustomerInfo);
            else
            {
                txtCompanyName.Text = objCustomer.companyName;
                txtContactName.Text = objCustomer.contactName;
                txtId.Text = objCustomer.id;

                for (int i = 0; i < cmbCustomerCountry.Items.Count; i++)
                {
                    if (((clsCountry)cmbCustomerCountry.Items[i]).codsec == objCustomer.fkCountry)
                        cmbCustomerCountry.SelectedIndex = i;
                }
                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objCustomer.fkStatus)
                        cmbStatus.SelectedIndex = i;
                }
                for (int i = 0; i < cmbIdType.Items.Count; i++)
                {
                    if (((clsIdType)cmbIdType.Items[i]).codsec == objCustomer.fkIdType)
                        cmbIdType.SelectedIndex = i;
                }
            }
        }

        private void btnCancelAddress_Click(object sender, EventArgs e)
        {
            grpbAddressForm.Enabled = false;
            tctrlCustomerAddress.SelectTab(0);
        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            if (validateAddressForm())
            {
                if (objCustomer.codsec != 0)
                {
                    objAddress.name = txtAddressName.Text;
                    objAddress.contact = txtContactName.Text;
                    objAddress.fkCity = ((clsCity)cmbCity.SelectedItem).codsec;
                    objAddress.fkEntity = objCustomer.codsec;
                    objAddress.address = txtAddress.Text;
                    objAddress.phone = txtPhone1.Text;
                    objAddress.phone2 = txtPhone2.Text;
                    objAddress.email = txtEmail.Text;
                    objAddress.fax = txtFax.Text;
                    objAddress.zip = txtZip.Text;

                    if (objAddress.save())
                    {
                        MessageBox.Show("La dirección se ha guardado con éxito.", "Direcciones de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        clearAddressFields();
                        loadAddressList();
                        grpbAddressForm.Enabled = false;
                        tctrlCustomerAddress.SelectTab(0);
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Direcciones de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                    MessageBox.Show("No existe ningun cliente a quien asociar la dirección", "Direcciones de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmCustomerList winCustomerList = new frmCustomerList();
            winCustomerList.MdiParent = this.MdiParent;
            winCustomerList.StartPosition = FormStartPosition.Manual;
            winCustomerList.Show();
            this.Close();
        }

        private void dgvCustomerAddress_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomerAddress.SelectedRows.Count > 0)
            {
                loadAddress(Convert.ToInt32(dgvCustomerAddress.SelectedRows[0].Cells["clmCodsec"].Value));
                grpbAddressForm.Enabled = true;
                tctrlCustomerAddress.SelectTab(1);
                txtAddressName.Focus();
            }
            else
                MessageBox.Show("Debe elegir una dirección para poder editarla.", "Direcciones de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (dgvCustomerAddress.SelectedRows.Count > 0)
            {
                loadAddress(Convert.ToInt32(dgvCustomerAddress.SelectedRows[0].Cells["clmCodsec"].Value));
                grpbAddressForm.Enabled = true;
                tctrlCustomerAddress.SelectTab(1);
                txtAddressName.Focus();
            }
            else
                MessageBox.Show("Debe elegir una dirección para poder editarla.", "Direcciones de clientes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStatus> lstStatus = clsStatus.getList();
                cmbStatus.Items.Clear();
                for (int i = 0; i < lstStatus.Count; i++)
                    cmbStatus.Items.Add(lstStatus[i]);
            }
        }

        private void cmbIdType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsIdType> lstIdType = clsIdType.getList();
                cmbIdType.Items.Clear();
                for (int i = 0; i < lstIdType.Count; i++)
                    cmbIdType.Items.Add(lstIdType[i]);
            }
        }



        private void cmbCustomerCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCountry> lstCountry = clsCountry.getList();
                cmbCustomerCountry.Items.Clear();
                for (int i = 0; i < lstCountry.Count; i++)
                    cmbCustomerCountry.Items.Add(lstCountry[i]);
            }
        }

        private void cmbCounty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCountry> lstCountry = clsCountry.getList();
                cmbCustomerCountry.Items.Clear();
                for (int i = 0; i < lstCountry.Count; i++)
                    cmbCustomerCountry.Items.Add(lstCountry[i]);
            }
        }

        private void cmbState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsState> lstState = clsState.getList();
                cmbState.Items.Clear();
                for (int i = 0; i < lstState.Count; i++)
                    cmbState.Items.Add(lstState[i]); 
            }
        }

        private void cmbCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCity> lstCity = clsCity.getList();
                cmbCity.Items.Clear();
                for (int i = 0; i < lstCity.Count; i++)
                    cmbCity.Items.Add(lstCity[i]); 
            }
        }

        private void cmbSegmentation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsSegmentation> lstSegmentation= clsSegmentation.getList();
                cmbSegmentation.Items.Clear();
                for (int i = 0; i < lstSegmentation.Count; i++)
                    cmbSegmentation.Items.Add(lstSegmentation[i]);
            }
        }
        

    }
}