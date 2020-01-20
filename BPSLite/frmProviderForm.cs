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
    public partial class frmProviderForm : Form
    {
        clsEntity objProvider = new clsEntity();
        List<clsEntityAddress> lstAddress = new List<clsEntityAddress>();
        clsEntityAddress objAddress = new clsEntityAddress();

        public frmProviderForm()
        {
            InitializeComponent();
        }

        public frmProviderForm(int codsec)
        {
            InitializeComponent();
            objProvider.load(codsec);
        }

        public bool validateProviderForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtCompanyName, ref lblCompany, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtContactName, ref lblContactName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtId, ref lblId, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbIdType, ref lblIdType, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbProviderCountry, ref lblProviderCountry, "selected")) isValid = false;

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

        public void loadCountriesList()
        {
            List<clsCountry> lstCountry = clsCountry.getList();
            cmbProviderCountry.Items.Clear();
            cmbCounty.Items.Clear();
            for (int i = 0; i < lstCountry.Count; i++)
            {
                cmbCounty.Items.Add(lstCountry[i]);
                cmbProviderCountry.Items.Add(lstCountry[i]);
            }
        }

        public void loadStateList(int countryCodsec)
        {
            List<clsState> lstState = clsState.getListByCountry(countryCodsec);
            cmbState.Items.Clear();
            for (int i = 0; i < lstState.Count; i++)
                cmbState.Items.Add(lstState[i]);
        }

        public void loadCitiesList(int stateCodsec)
        {
            List<clsCity> lstCity = clsCity.getListByState(stateCodsec);
            cmbCity.Items.Clear();
            for (int i = 0; i < lstCity.Count; i++)
                cmbCity.Items.Add(lstCity[i]);
        }

        public void loadAddressList()
        {
            List<clsEntityAddress> lstAddress = clsEntityAddress.getListByEntity(objProvider.codsec);
            dgvProviderAddress.Rows.Clear();

            for (int i = 0; i < lstAddress.Count; i++)
            {
                dgvProviderAddress.Rows.Add();
                dgvProviderAddress.Rows[i].Cells["clmCodsec"].Value = lstAddress[i].codsec.ToString();
                dgvProviderAddress.Rows[i].Cells["clmName"].Value = lstAddress[i].name.ToString();
                dgvProviderAddress.Rows[i].Cells["clmCity"].Value = lstAddress[i].CityName.ToString();
                dgvProviderAddress.Rows[i].Cells["clmAddress"].Value = lstAddress[i].address.ToString();
                dgvProviderAddress.Rows[i].Cells["clmTelephone"].Value = lstAddress[i].phone.ToString();
                dgvProviderAddress.Rows[i].Cells["clmEmail"].Value = lstAddress[i].email.ToString();
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

        private void frmProviderForm_Load(object sender, EventArgs e)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();
            List<clsIdType> lstIdType = new List<clsIdType>();

            loadCountriesList();
            lstStatus = clsStatus.getListByStatusGroupName("Entidades");
            lstIdType = clsIdType.getList();

            loadAddressList();

            cmbStatus.Items.Clear();

            for (int i = 0; i < lstStatus.Count; i++)
            {
                cmbStatus.Items.Add(lstStatus[i]);
            }

            cmbIdType.Items.Clear();

            for (int i = 0; i < lstIdType.Count; i++)
            {
                cmbIdType.Items.Add(lstIdType[i]);
            }

            if (objProvider.codsec > 0)
            {
                grp_ProviderAddresInfo.Enabled = true;

                txtCompanyName.Text = objProvider.companyName;
                txtContactName.Text = objProvider.contactName;
                txtId.Text = objProvider.id;

                for (int i = 0; i < cmbProviderCountry.Items.Count; i++)
                {
                    if (((clsCountry)cmbProviderCountry.Items[i]).codsec == objProvider.fkCountry)
                        cmbProviderCountry.SelectedIndex = i;
                }
                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objProvider.fkStatus)
                        cmbStatus.SelectedIndex = i;
                }
                for (int i = 0; i < cmbIdType.Items.Count; i++)
                {
                    if (((clsIdType)cmbIdType.Items[i]).codsec == objProvider.fkIdType)
                        cmbIdType.SelectedIndex = i;
                }

            }
            else
            {
                grp_ProviderAddresInfo.Enabled = false;
            }
        }

        private void brnSave_Click(object sender, EventArgs e)
        {
            if (validateProviderForm())
            {
                objProvider.companyName = txtCompanyName.Text;
                objProvider.contactName = txtContactName.Text;
                objProvider.id = txtId.Text;
                objProvider.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                objProvider.fkIdType = ((clsIdType)cmbIdType.SelectedItem).codsec;
                objProvider.fkCountry = ((clsCountry)cmbProviderCountry.SelectedItem).codsec;
                objProvider.isProvider = false;
                objProvider.isProvider = true;

                if (objProvider.save())
                {
                    MessageBox.Show("El Proveedor se ha guardado con éxito.", "Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    if (objProvider.codsec == 0)
                    {
                        objProvider.codsec = clsEntity.getLastSavedProviderCodsec();
                        grp_ProviderAddresInfo.Enabled = true;
                    }
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            if (objProvider.codsec == 0)
                clsGlobal.ClearForm(grpobCustomerInfo);
            else
            {
                txtCompanyName.Text = objProvider.companyName;
                txtContactName.Text = objProvider.contactName;
                txtId.Text = objProvider.id;

                for (int i = 0; i < cmbProviderCountry.Items.Count; i++)
                {
                    if (((clsCountry)cmbProviderCountry.Items[i]).codsec == objProvider.fkCountry)
                        cmbProviderCountry.SelectedIndex = i;
                }
                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objProvider.fkStatus)
                        cmbStatus.SelectedIndex = i;
                }
                for (int i = 0; i < cmbIdType.Items.Count; i++)
                {
                    if (((clsIdType)cmbIdType.Items[i]).codsec == objProvider.fkIdType)
                        cmbIdType.SelectedIndex = i;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmProviderList winProviderList = new frmProviderList();
            winProviderList.MdiParent = this.MdiParent;
            winProviderList.StartPosition = FormStartPosition.Manual;
            winProviderList.Show();
            this.Close();
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            grpbAddressForm.Enabled = true;
            tctrlProviderAddress.SelectTab(1);
            txtAddressName.Focus();
        }

        private void btnEditAddress_Click(object sender, EventArgs e)
        {
            if (dgvProviderAddress.SelectedRows.Count > 0)
            {
                loadAddress(Convert.ToInt32(dgvProviderAddress.SelectedRows[0].Cells["clmCodsec"].Value));
                grpbAddressForm.Enabled = true;
                tctrlProviderAddress.SelectTab(1);
                txtAddressName.Focus();
            }
            else
                MessageBox.Show("Debe elegir una dirección para poder editarla.", "Direcciones de Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void grvProviderAddress_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProviderAddress.SelectedRows.Count > 0)
            {
                loadAddress(Convert.ToInt32(dgvProviderAddress.SelectedRows[0].Cells["clmCodsec"].Value));
                grpbAddressForm.Enabled = true;
                tctrlProviderAddress.SelectTab(1);
                txtAddressName.Focus();
            }
            else
                MessageBox.Show("Debe elegir una dirección para poder editarla.", "Direcciones de Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAddress_Click(object sender, EventArgs e)
        {
            if (objProvider.codsec != 0)
            {
                objAddress.name = txtAddressName.Text;
                objAddress.contact = txtContactName.Text;
                objAddress.fkCity = ((clsCity)cmbCity.SelectedItem).codsec;
                objAddress.fkEntity = objProvider.codsec;
                objAddress.address = txtAddress.Text;
                objAddress.phone = txtPhone1.Text;
                objAddress.phone2 = txtPhone2.Text;
                objAddress.email = txtEmail.Text;
                objAddress.fax = txtFax.Text;
                objAddress.zip = txtZip.Text;

                if (objAddress.save())
                {
                    MessageBox.Show("La dirección se ha guardado con éxito.", "Direcciones de Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    clearAddressFields();
                    loadAddressList();
                    grpbAddressForm.Enabled = false;
                    tctrlProviderAddress.SelectTab(0);

                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Direcciones de Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            else
                MessageBox.Show("No existe ningun Proveedor a quien asociar la dirección", "Direcciones de Proveedored", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void btnCancelAddress_Click(object sender, EventArgs e)
        {
            clearAddressFields();
            grpbAddressForm.Enabled = false;
            tctrlProviderAddress.SelectTab(0);
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

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Entidades");
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

        private void cmbProviderCountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCountry> lstCountry = clsCountry.getList();
                cmbCounty.Items.Clear();
                for (int i = 0; i < lstCountry.Count; i++)
                    cmbCounty.Items.Add(lstCountry[i]);
            }
        }

        private void cmbCounty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCountry> lstCountry = clsCountry.getList();
                cmbCounty.Items.Clear();
                for (int i = 0; i < lstCountry.Count; i++)
                    cmbCounty.Items.Add(lstCountry[i]);
            }
        }
    }
}