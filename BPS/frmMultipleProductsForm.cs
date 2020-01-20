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
    public partial class frmMultipleProductsForm : Form
    {
        clsProduct objProduct = new clsProduct();

        public frmMultipleProductsForm()
        {
            InitializeComponent();
        }

        public frmMultipleProductsForm(int codsec)
        {
            InitializeComponent();
            objProduct.load(codsec);
        }
        public void selectFilmType(string filmType)
        {
            switch (filmType)
            {
                case "Bopp":
                    rdoBopp.Checked = true;
                    break;
                case "Cast":
                    rdoCast.Checked = true;
                    break;
                case "Coating":
                    rdoCoating.Checked = true;
                    break;
                default:
                    break;
            }
        }
        public void generateCode()
        {
            generateCode("", "", "");
        }
        public void generateCode(string strWidth, string coreValue, string diameterValue)
        {
            string code = "";
            if (rdoBopp.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsBopp)cmbFilm.SelectedItem).code != "") ? ((clsBopp)cmbFilm.SelectedItem).code : "-") : "-";
            else if (rdoCast.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCast)cmbFilm.SelectedItem).code != "") ? ((clsCast)cmbFilm.SelectedItem).code : "-") : "-";
            else if (rdoCoating.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCoating)cmbFilm.SelectedItem).code != "") ? ((clsCoating)cmbFilm.SelectedItem).code : "-") : "-";
            if (coreValue == "" && diameterValue == "")
            {
                code += "x---";
                code += "-";
                code += "-";
            }
            else
            {
                code += "x" + strWidth;
                code += diameterValue;
                code += coreValue;
            }
            //if (txtSystemCode.Text == txtCode.Text || txtCode.Text == "")
            //    txtCode.Text = code;
            txtSystemCode.Text = code;

            code = "";
            if (rdoBopp.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsBopp)cmbFilm.SelectedItem).code != "") ? ((clsBopp)cmbFilm.SelectedItem).code.Replace("-", "") : "-") : "-";
            else if (rdoCast.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCast)cmbFilm.SelectedItem).code != "") ? ((clsCast)cmbFilm.SelectedItem).code : "-") : "-";
            else if (rdoCoating.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCoating)cmbFilm.SelectedItem).code != "") ? ((clsCoating)cmbFilm.SelectedItem).code : "-") : "-";
            if (coreValue == "" && diameterValue == "")
            {
                code += "x---"; 
                code += "-";
                code += "-";
            }
            else
            {
                code += "x" + strWidth;
                code += diameterValue;
                code += coreValue;
            }
            txtCode.Text = code;
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbUnits, ref lblUnits, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbFilm, ref lblBoppFilm, "selected")) isValid = false;
            //if (!clsValidation.validateField(ref cmbCore, ref lblCore, "selected")) isValid = false;
            //if (!clsValidation.validateField(ref cmbDiameter, ref lblDiameter, "selected")) isValid = false;
            //if (!clsValidation.validateField(ref txtWidth, ref lblWidth, "notEmpty")) isValid = false;

            return isValid;
        }
        private void clearForm()
        {
            objProduct = new clsProduct();
            txtName.Text = "";
            txtCode.Text = "";
            txtSystemCode.Text = "";
            txtDescription.Text = "";
            lstbCore.SelectedIndex = -1;
            lstbDiameter.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            lstbWidth.Items.Clear();
            rdoBopp.Select();
            txtName.Focus();
        }
        private void frmProductForm_Load(object sender, EventArgs e)
        {
            List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Productos");
            List<clsUnit> lstUnits = clsUnit.getList();
            List<clsCore> lstCores = clsCore.getList();
            List<clsDiameter> lstDiameters = clsDiameter.getList();

            cmbStatus.Items.Clear();
            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            cmbUnits.Items.Clear();
            for (int i = 0; i < lstUnits.Count; i++)
                cmbUnits.Items.Add(lstUnits[i]);

            lstbCore.Items.Clear();
            for (int i = 0; i < lstCores.Count; i++)
                lstbCore.Items.Add(lstCores[i]);

            lstbDiameter.Items.Clear();
            for (int i = 0; i < lstDiameters.Count; i++)
                lstbDiameter.Items.Add(lstDiameters[i]);
        }

        private void rdoBopp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBopp.Checked)
            {
                List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
                cmbFilm.Items.Clear();
                for (int i = 0; i < lstBopp.Count; i++)
                    cmbFilm.Items.Add(lstBopp[i]);
            }
        }

        private void rdoCast_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCast.Checked)
            {
                List<clsCast> lstCast = clsCast.getList();
                cmbFilm.Items.Clear();
                for (int i = 0; i < lstCast.Count; i++)
                    cmbFilm.Items.Add(lstCast[i]);
            }
        }

        private void rdoCoating_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCoating.Checked)
            {
                List<clsCoating> lstCoating = clsCoating.getList();
                cmbFilm.Items.Clear();
                for (int i = 0; i < lstCoating.Count; i++)
                    cmbFilm.Items.Add(lstCoating[i]);
            }
        }

        private void cmbFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productType = "";

            if (validateForm())
            {
                for (int i = 0; i < lstbDiameter.SelectedItems.Count; i++)
                {
                    for (int j = 0; j < lstbCore.SelectedItems.Count; j++)
                    {
                        for (int k = 0; k < lstbWidth.Items.Count; k++)
                        {
                            objProduct = new clsProduct();

                            if (rdoBopp.Checked)
                            {
                                objProduct.fkBopp = ((clsBopp)cmbFilm.SelectedItem).codsec;
                                productType = "Bopp";
                                objProduct.name = ((clsBopp)cmbFilm.SelectedItem).name;
                            }
                            else if (rdoCast.Checked)
                            {
                                objProduct.fkCast = ((clsCast)cmbFilm.SelectedItem).codsec;
                                productType = "Cast";
                                objProduct.name = ((clsCast)cmbFilm.SelectedItem).name;
                            }
                            else if (rdoCoating.Checked)
                            {
                                objProduct.fkCoating = ((clsCoating)cmbFilm.SelectedItem).codsec;
                                productType = "Coating";
                                objProduct.name = ((clsCoating)cmbFilm.SelectedItem).name;
                            }

                            objProduct.name += " X " + lstbWidth.Items[k].ToString() + "mm " + ((clsDiameter)lstbDiameter.SelectedItems[i]).abbreviation + ((clsCore)lstbCore.SelectedItems[j]).value.ToString();
                            generateCode(lstbWidth.Items[k].ToString(), ((clsCore)lstbCore.SelectedItems[j]).value.ToString(), ((clsDiameter)lstbDiameter.SelectedItems[i]).abbreviation);
                            objProduct.code = txtCode.Text;
                            objProduct.systemCode = txtSystemCode.Text;
                            objProduct.description = txtDescription.Text;
                            objProduct.width = Convert.ToDouble(lstbWidth.Items[k].ToString());
                            objProduct.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                            objProduct.fkUnit = ((clsUnit)cmbUnits.SelectedItem).codsec;
                            objProduct.fkCore = ((clsCore)lstbCore.SelectedItems[j]).codsec;
                            objProduct.fkDiameter = ((clsDiameter)lstbDiameter.SelectedItems[i]).codsec;

                            objProduct.save(productType);
                        }
                    }
                }
                clearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWidth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstbWidth.Items.Add(txtWidth.Text);
                txtWidth.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void cmbUnits_KeyDown(object sender, KeyEventArgs e)
        {
            List<clsUnit> lstUnits =  clsUnit.getList();
            cmbUnits.Items.Clear();
            for (int i = 0; i < lstUnits.Count; i++)
                cmbUnits.Items.Add(lstUnits[i]);
        }

        private void cmbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsStatus> lstStatus = clsStatus.getListByStatusGroupName("Productos");
                cmbStatus.Items.Clear();
                for (int i = 0; i < lstStatus.Count; i++)
                    cmbStatus.Items.Add(lstStatus[i]); 
            }
        }

        private void cmbFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
                cmbFilm.Items.Clear();
                for (int i = 0; i < lstBopp.Count; i++)
                    cmbFilm.Items.Add(lstBopp[i]); 
            }
        }

    }
}