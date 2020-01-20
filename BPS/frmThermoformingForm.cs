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
    public partial class frmThermoformingForm : Form
    {
        clsThermoforming objThermoform = new clsThermoforming();
        
        public frmThermoformingForm()
        {
            InitializeComponent();
        }

        private void frmThermoformingForm_Load(object sender, EventArgs e)
        {
            List<clsColor> lstColor = new List<clsColor>();
            List<clsOunce> lstOunce = new List<clsOunce>();

            lstColor = clsColor.getList();
            lstOunce = clsOunce.getList();

            cmbColor.Items.Clear();

            for (int i = 0; i < lstColor.Count; i++)
            {
                cmbColor.Items.Add(lstColor[i]);
            }

            cmbOunce.Items.Clear();

            for (int i = 0; i < lstOunce.Count; i++)
            {
                cmbOunce.Items.Add(lstOunce[i]);
            }
        }

        private void clearForm()
        {
            objThermoform = new clsThermoforming();
            txtName.Text = "";
            txtCode.Text = "";
            cmbColor.SelectedIndex = -1;
            cmbOunce.SelectedIndex = -1;
            txtGrams.Text = "";
            chkIsSpecial.Checked = false;
            txtName.Focus();
        }

        public bool validateForm()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref txtName, ref lblName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCode, ref lblCode, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbColor, ref lblColor, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbOunce, ref lblOunce, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtGrams, ref lblGrams, "notEmpty")) isValid = false;

            return isValid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta realmente seguro que desea cancelar Termoformado", "Termoformado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clsGlobal.ClearForm(this);
                cmbColor.Focus();
            }
            else
                clearForm();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (validateForm())
            {
                if (objThermoform.codsec == 0)
                {
                    objThermoform = new clsThermoforming();

                    objThermoform.name = txtName.Text;
                    objThermoform.code = txtCode.Text;
                    objThermoform.fkColor = ((clsColor)cmbColor.SelectedItem).codsec;
                    objThermoform.fkOunce = ((clsOunce)cmbOunce.SelectedItem).codsec;
                    objThermoform.gramsperunit = Convert.ToDouble(txtGrams.Text);
                    objThermoform.isspecial = chkIsSpecial.Checked;

                    if (objThermoform.save())
                    {
                        MessageBox.Show("El tipo de termoformado se ha guardado con éxito.", "Tipo de termoformado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                        /**if (MessageBox.Show("Desea crear un nuevo tipo de termoformado?", "Termoformado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                        {
                            clearForm();
                        }
                        else
                            objThermoform.codsec = clsThermoforming.getLastSavedCodsec();**/
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Termoformado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                /**else
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
                    }
                    else
                        MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Productos de Películas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }**/
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsColor> lstColor = clsColor.getList();
                cmbColor.Items.Clear();
                for (int i = 0; i < lstColor.Count; i++)
                    cmbColor.Items.Add(lstColor[i]); 
            }
        }

        private void cmbOunce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsOunce> lstOunce = clsOunce.getList();
                cmbOunce.Items.Clear();
                for (int i = 0; i < lstOunce.Count; i++)
                    cmbOunce.Items.Add(lstOunce[i]); 
            }
        }
    }
}
