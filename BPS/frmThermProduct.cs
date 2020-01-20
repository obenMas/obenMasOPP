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
    public partial class frmThermProduct : Form
    {

        clsProduct objProduct = new clsProduct();
        clsThermoforming objThermoforming = new clsThermoforming();


        public frmThermProduct()
        {
            InitializeComponent();
        }


        public frmThermProduct(int codsec)
        {
            InitializeComponent();
            objProduct.load(codsec);
        }

        public void generateCode()
        {
            string code = "";
            code += (cmbTherm.SelectedIndex >= 0) ? ((((clsThermoforming)cmbTherm.SelectedItem).code != "") ? ((clsThermoforming)cmbTherm.SelectedItem).code : "-") : "-";
            txtCode.Text = code;
            txtSystemCode.Text = code;
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbUnits, ref lblUnits, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbStatus, ref lblStatus, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbTherm, ref lblTherm, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtUnitsPerPackage, ref lblUnitsPerPackage, "selected")) isValid = false;
            
            return isValid;
        }

        private void clearForm()
        {
            objProduct = new clsProduct();
            txtName.Text = "";
            txtCode.Text = "";
            txtSystemCode.Text = "";
            cmbTherm.SelectedIndex = -1;
            txtUnitsPerPackage.Text = "";
            txtName.Focus();   
        }


        private void frmThermProduct_Load(object sender, EventArgs e)
        {
            List<clsStatus> lstStatus = new List<clsStatus>();
            List<clsUnit> lstUnits = new List<clsUnit>();
            List<clsThermoforming> lstThermoforming = new List<clsThermoforming>();

            lstStatus = clsStatus.getListByStatusGroupName("Productos");
            lstUnits = clsUnit.getList();
            lstThermoforming = clsThermoforming.getList();

            cmbStatus.Items.Clear();

            for (int i = 0; i < lstStatus.Count; i++)
                cmbStatus.Items.Add(lstStatus[i]);

            cmbUnits.Items.Clear();

            for (int i = 0; i < lstUnits.Count; i++)
                cmbUnits.Items.Add(lstUnits[i]);

            cmbTherm.Items.Clear();

            for (int i = 0; i < lstThermoforming.Count; i++)
                cmbTherm.Items.Add(lstThermoforming[i]);

            txtName.Text = objProduct.name;
            txtCode.Text = objProduct.code;
            txtSystemCode.Text = objProduct.systemCode;
            txtDescription.Text = objProduct.description;
            txtUnitsPerPackage.Text = objProduct.value.ToString();
        }

        private void cmbTherm_SelectedIndexChanged(object sender, EventArgs e)
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
                    objProduct = new clsProduct();

                    objProduct.name = txtName.Text;
                    objProduct.code = txtCode.Text;
                    objProduct.systemCode = txtSystemCode.Text;
                    objProduct.description = txtDescription.Text;
                    objProduct.value = Convert.ToInt32(txtUnitsPerPackage.Text);
                    objProduct.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                    objProduct.fkUnit = ((clsUnit)cmbUnits.SelectedItem).codsec;                  
                    objProduct.fkThermoformed = ((clsThermoforming)cmbTherm.SelectedItem).codsec;
                    productType = "Termoformado";
                   
                    if (objProduct.save(productType))
                    {
                        MessageBox.Show("El producto se ha guardado con éxito.", "Productos de Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        if (MessageBox.Show("Desea crear un nuevo producto?", "Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            clearForm();
                        else
                            objProduct.codsec = clsProduct.getLastSavedCodsec();
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    objProduct.name = txtName.Text;
                    objProduct.code = txtCode.Text;
                    objProduct.systemCode = txtSystemCode.Text;
                    objProduct.description = txtDescription.Text;
                    objProduct.value = Convert.ToInt32(txtUnitsPerPackage.Text);
                    objProduct.fkStatus = ((clsStatus)cmbStatus.SelectedItem).codsec;
                    objProduct.fkUnit = ((clsUnit)cmbUnits.SelectedItem).codsec;
                    objProduct.fkThermoformed = ((clsThermoforming)cmbTherm.SelectedItem).codsec;
                    productType = "Termoformado";

                    if (objProduct.save(productType))
                    {
                        MessageBox.Show("El producto se ha guardado con éxito.", "Productos de Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        if (MessageBox.Show("Desea crear un nuevo producto?", "Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                            clearForm();
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
            if (MessageBox.Show("Esta realmente seguro que desea cancelar producto termoformado...?","Producto Termoformado",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsGlobal.ClearForm(this);
                txtName.Focus();
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

        private void cmbTherm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsThermoforming> lstThermoforming = clsThermoforming.getList();
                cmbTherm.Items.Clear();
                for (int i = 0; i < lstThermoforming.Count; i++)
                    cmbTherm.Items.Add(lstThermoforming[i]);
            }
        }
    }
}

