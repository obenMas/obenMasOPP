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
    public partial class frmProductsForm : Form
    {
        clsProduct objProduct = new clsProduct();

        public frmProductsForm()
        {
            InitializeComponent();
        }

        public frmProductsForm(int codsec)  
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
            string code = "";
            string name = "";

            if (rdoBopp.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsBopp)cmbFilm.SelectedItem).code != "") ? ((clsBopp)cmbFilm.SelectedItem).code : "-") : "-";
            else if (rdoCast.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCast)cmbFilm.SelectedItem).code != "") ? ((clsCast)cmbFilm.SelectedItem).code : "-") : "-";
            else if (rdoCoating.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCoating)cmbFilm.SelectedItem).code != "") ? ((clsCoating)cmbFilm.SelectedItem).code : "-") : "-";

            code += clsGlobal.FillWithZeros(txtWidth.Text, 4);
            code += (cmbDiameter.SelectedIndex >= 0) ? ((((clsDiameter)cmbDiameter.SelectedItem).abbreviation != "") ? ((clsDiameter)cmbDiameter.SelectedItem).abbreviation : "-") : "-";
            code += (cmbCore.SelectedIndex >= 0) ? ((((clsCore)cmbCore.SelectedItem).value.ToString() != "") ? ((clsCore)cmbCore.SelectedItem).value.ToString() : "-") : "-";

            //if (txtSystemCode.Text == txtCode.Text || txtCode.Text == "")
            //    txtCode.Text = code;
            txtSystemCode.Text = code;

            code = "";
            if (rdoBopp.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsBopp)cmbFilm.SelectedItem).code != "") ? ((clsBopp)cmbFilm.SelectedItem).code.Replace("-", "") : "-") : "-";
            else if (rdoCast.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCast)cmbFilm.SelectedItem).code != "") ? ((clsCast)cmbFilm.SelectedItem).code.Replace("-", "") : "-") : "-";
            else if (rdoCoating.Checked)
                code += (cmbFilm.SelectedIndex >= 0) ? ((((clsCoating)cmbFilm.SelectedItem).code != "") ? ((clsCoating)cmbFilm.SelectedItem).code.Replace("-", "") : "-") : "-";

            code += "x" + txtWidth.Text;
            code += (cmbDiameter.SelectedIndex >= 0) ? ((((clsDiameter)cmbDiameter.SelectedItem).abbreviation != "") ? ((clsDiameter)cmbDiameter.SelectedItem).abbreviation : "-") : "-";
            code += (cmbCore.SelectedIndex >= 0) ? ((((clsCore)cmbCore.SelectedItem).value.ToString() != "") ? ((clsCore)cmbCore.SelectedItem).value.ToString() : "-") : "-";

            txtCode.Text = code;

            name = "";

            if (rdoBopp.Checked)
                name += (cmbFilm.SelectedIndex >= 0) ? ((((clsBopp)cmbFilm.SelectedItem).name != "") ? ((clsBopp)cmbFilm.SelectedItem).name : "-") : "-";
            else if (rdoCast.Checked)
                name += (cmbFilm.SelectedIndex >= 0) ? ((((clsCast)cmbFilm.SelectedItem).name != "") ? ((clsCast)cmbFilm.SelectedItem).name : "-") : "-";
            else if (rdoCoating.Checked)
                name += (cmbFilm.SelectedIndex >= 0) ? ((((clsCoating)cmbFilm.SelectedItem).name != "") ? ((clsCoating)cmbFilm.SelectedItem).name : "-") : "-";

            name += " x" + txtWidth.Text + "mm ";
            name += (cmbDiameter.SelectedIndex >= 0) ? ((((clsDiameter)cmbDiameter.SelectedItem).abbreviation != "") ? ((clsDiameter)cmbDiameter.SelectedItem).abbreviation : "-") : "-";
            name += (cmbCore.SelectedIndex >= 0) ? ((((clsCore)cmbCore.SelectedItem).value.ToString() != "") ? ((clsCore)cmbCore.SelectedItem).value.ToString() : "-") : "-";

            txtName.Text = name;
        }
        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbUnits, ref lblUnits, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbFilm, ref lblBoppFilm, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbCore, ref lblCore, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbDiameter, ref lblDiameter, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtWidth, ref lblWidth, "notEmpty")) isValid = false;

            return isValid;
        }
        private void clearForm()
        {
            objProduct = new clsProduct();
            txtName.Text = "";
            txtCode.Text = "";
            txtSystemCode.Text = "";
            txtWidth.Text = "";
            txtDescription.Text = "";
            cmbCore.SelectedIndex = -1;
            cmbDiameter.SelectedIndex = -1;
            cmbFilm.SelectedIndex = -1;
            rdoBopp.Select();
            txtName.Focus();
        }
        private void frmProductForm_Load(object sender, EventArgs e)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();
            List<clsUnit> lstUnits = new List<clsUnit>();
            List<clsCore> lstCores = new List<clsCore>();
            List<clsDiameter> lstDiameters = new List<clsDiameter>();

            lstStatus = clsStatus.getListByStatusGroupName("Productos");
            lstUnits = clsUnit.getList();
            lstCores = clsCore.getList();
            lstDiameters = clsDiameter.getList();

            cmbStatus.Items.Clear();

            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            cmbUnits.Items.Clear();
            for (int i = 0; i < lstUnits.Count; i++)
                cmbUnits.Items.Add(lstUnits[i]);

            cmbCore.Items.Clear();
            for (int i = 0; i < lstCores.Count; i++)
                cmbCore.Items.Add(lstCores[i]);

            cmbDiameter.Items.Clear();
            for (int i = 0; i < lstDiameters.Count; i++)
                cmbDiameter.Items.Add(lstDiameters[i]);

            if (objProduct.codsec != 0)
            {

                if (objProduct.fkBopp != 0)
                {
                    rdoBopp.Checked = true;
                    for (int i = 0; i < cmbFilm.Items.Count; i++)
                    {
                        if (((clsBopp)cmbFilm.Items[i]).codsec == objProduct.fkBopp)
                            cmbFilm.SelectedIndex = i;
                    }
                    cmbFilm.Enabled = false;
                }
                else if (objProduct.fkBopp != 0)
                {
                    rdoCast.Checked = true;
                    for (int i = 0; i < cmbFilm.Items.Count; i++)
                    {
                        if (((clsCast)cmbFilm.Items[i]).codsec == objProduct.fkCast)
                            cmbFilm.SelectedIndex = i;
                    }
                    cmbFilm.Enabled = false;
                }
                else if (objProduct.fkBopp != 0)
                {
                    rdoCoating.Checked = true;
                    for (int i = 0; i < cmbFilm.Items.Count; i++)
                    {
                        if (((clsCoating)cmbFilm.Items[i]).codsec == objProduct.fkCoating)
                            cmbFilm.SelectedIndex = i;
                    }
                    cmbFilm.Enabled = false;
                }
                grpbProductType.Enabled = false;

                for (int i = 0; i < cmbStatus.Items.Count; i++)
                {
                    if (((clsStatus)cmbStatus.Items[i]).codsec == objProduct.fkStatus)
                        cmbStatus.SelectedIndex = i;
                }
                for (int i = 0; i < cmbUnits.Items.Count; i++)
                {
                    if (((clsUnit)cmbUnits.Items[i]).codsec == objProduct.fkUnit)
                        cmbUnits.SelectedIndex = i;
                }
                for (int i = 0; i < cmbCore.Items.Count; i++)
                {
                    if (((clsCore)cmbCore.Items[i]).codsec == objProduct.fkCore)
                        cmbCore.SelectedIndex = i;
                }
                for (int i = 0; i < cmbDiameter.Items.Count; i++)
                {
                    if (((clsDiameter)cmbDiameter.Items[i]).codsec == objProduct.fkDiameter)
                        cmbDiameter.SelectedIndex = i;
                }                

                txtName.Text = objProduct.name;
                txtCode.Text = objProduct.code;
                txtSystemCode.Text = objProduct.systemCode;
                txtDescription.Text = objProduct.description;
                txtWidth.Text = objProduct.width.ToString();
                txtWidth.Enabled = false;

            }
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

        private void cmbCore_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateCode();
        }

        private void cmbDiameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateCode();
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            generateCode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string productType = "";

            if (validateForm())
            {
                if (objProduct.codsec == 0)
                {
                    DataSet DS = clsConnection.getDataSetResult("SELECT * FROM bps_prod_product WHERE prod_code = '" + txtCode.Text + "'");

                    if (DS.Tables[0].Rows.Count == 0)
                    {
                        objProduct = new clsProduct();

                        objProduct.name = txtName.Text;
                        objProduct.code = txtCode.Text;
                        objProduct.systemCode = txtSystemCode.Text;
                        objProduct.description = txtDescription.Text;
                        objProduct.width = Convert.ToDouble(txtWidth.Text);
                        objProduct.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                        objProduct.fkUnit = ((clsUnit)cmbUnits.SelectedItem).codsec;
                        objProduct.fkCore = ((clsCore)cmbCore.SelectedItem).codsec;
                        objProduct.fkDiameter = ((clsDiameter)cmbDiameter.SelectedItem).codsec;

                        if (rdoBopp.Checked)
                        {
                            objProduct.fkBopp = ((clsBopp)cmbFilm.SelectedItem).codsec;
                            productType = "Bopp";
                        }
                        else if (rdoCast.Checked)
                        {
                            objProduct.fkCast = ((clsCast)cmbFilm.SelectedItem).codsec;
                            productType = "Cast";
                        }
                        else if (rdoCoating.Checked)
                        {
                            objProduct.fkCoating = ((clsCoating)cmbFilm.SelectedItem).codsec;
                            productType = "Coating";
                        }

                        if (objProduct.save(productType))
                        {
                            MessageBox.Show("El producto se ha guardado con éxito.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                            if (MessageBox.Show("Desea crear un nuevo producto?", "Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            {
                                clearForm();
                            }
                            else
                            {
                                //objProduct.codsec = clsProduct.getLastSavedCodsec();
                                this.Close();
                            }
                        }
                        else
                            MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    }
                    else
                        MessageBox.Show("El producto ya existe en el sistema, por favor verifique su existencia.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    objProduct.name = txtName.Text;
                    objProduct.code = txtCode.Text;
                    objProduct.systemCode = txtSystemCode.Text;
                    objProduct.description = txtDescription.Text;
                    objProduct.width = Convert.ToDouble(txtWidth.Text);
                    objProduct.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                    objProduct.fkUnit = ((clsUnit)cmbUnits.SelectedItem).codsec;
                    objProduct.fkCore = ((clsCore)cmbCore.SelectedItem).codsec;
                    objProduct.fkDiameter = ((clsDiameter)cmbDiameter.SelectedItem).codsec;

                    if (rdoBopp.Checked)
                    {
                        objProduct.fkBopp = ((clsBopp)cmbFilm.SelectedItem).codsec;
                        productType = "Bopp";
                    }
                    else if (rdoCast.Checked)
                    {
                        objProduct.fkCast = ((clsCast)cmbFilm.SelectedItem).codsec;
                        productType = "Cast";
                    }
                    else if (rdoCoating.Checked)
                    {
                        objProduct.fkCoating = ((clsCoating)cmbFilm.SelectedItem).codsec;
                        productType = "Coating";
                    }


                    if (objProduct.save(productType))
                    {
                        MessageBox.Show("El producto se ha guardado con éxito.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        if (MessageBox.Show("Desea crear un nuevo producto?", "Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            clearForm();
                        }
                        else
                            this.Close();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro que desea cancelar el producto ingresado", "Nuevo Producto", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsGlobal.ClearForm(this);
                this.Close();
            }
        }

        private void cmbUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsUnit> lstUnit = clsUnit.getList();
                cmbUnits.Items.Clear();
                for (int i = 0; i < lstUnit.Count; i++)
                    cmbUnits.Items.Add(lstUnit[i]);
            }
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
                if (rdoBopp.Checked == true)
                {
                    List<clsBopp> lstBopp = clsBopp.getSimplifiedList();
                    cmbFilm.Items.Clear();
                    for (int i = 0; i < lstBopp.Count; i++)
                        cmbFilm.Items.Add(lstBopp[i]);
                }
                else
                {
                    if (rdoCast.Checked == true)
                    {
                        List<clsCast> lstCast = clsCast.getList();
                        cmbFilm.Items.Clear();
                        for (int i = 0; i < lstCast.Count; i++)
                            cmbFilm.Items.Add(lstCast[i]);
                    }
                    else
                    {
                        if (rdoCoating.Checked == true)
                        {
                            List<clsCoating> lstCoating = clsCoating.getList();
                            cmbFilm.Items.Clear();
                            for (int i = 0; i < lstCoating.Count; i++)
                                cmbFilm.Items.Add(lstCoating[i]);
                        }
                    }
                }
            }
        }

        private void cmbCore_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCore> lstCore = clsCore.getList();
                cmbCore.Items.Clear();
                for (int i = 0; i < lstCore.Count; i++)
                    cmbCore.Items.Add(lstCore[i]);
            }
        }

        private void cmbDiameter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsDiameter> lstDiameter = clsDiameter.getList();
                cmbDiameter.Items.Clear();
                for (int i = 0; i < lstDiameter.Count; i++)
                    cmbDiameter.Items.Add(lstDiameter[i]);
            }
        }
    }
}