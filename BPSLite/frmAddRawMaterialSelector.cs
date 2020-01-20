using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmAddRawMaterialSelector : Form
    {

        #region Init

        int codsec = 0;

        public frmAddRawMaterialSelector()
        {
            InitializeComponent();
        }

        public frmAddRawMaterialSelector(int codsec)
        {
            InitializeComponent();
            this.codsec = codsec;
        }

        private void frmAddRawMaterialSelector_Load(object sender, EventArgs e)
        {
            PopulateCustomer();
            PopulateTypeRawMaterial();
            PopulatePacking();
            PopulateUnit();
            ClearForm();
        }

        #endregion

        #region Helper

        private void PopulateCustomer()
        {
            List<clsEntity> lstEntity = new List<clsEntity>();
            lstEntity = clsEntity.getProviderList();
            cmbCustomer.Items.Clear();
            for (int i = 0; i < lstEntity.Count; i++)
                cmbCustomer.Items.Add(lstEntity[i]);
        }

        private void PopulateTypeRawMaterial()
        {
            List<clsRawMaterialtype> lstRawMaterialtype = new List<clsRawMaterialtype>();
            lstRawMaterialtype = clsRawMaterialtype.getList();
            cmbRawMaterial.Items.Clear();
            for (int i = 0; i < lstRawMaterialtype.Count; i++)
                cmbRawMaterial.Items.Add(lstRawMaterialtype[i]);
        }

        private void PopulatePacking()
        {
            List<clsPackagingType> lstPackagingType = new List<clsPackagingType>();
            lstPackagingType = clsPackagingType.getList();
            cmbPackagingType.Items.Clear();
            for (int i = 0; i < lstPackagingType.Count; i++)
                cmbPackagingType.Items.Add(lstPackagingType[i]);
        }

        private void PopulateUnit()
        {
            List<clsUnit> lstUnit = new List<clsUnit>();
            lstUnit = clsUnit.getList();
            cmbUnit.Items.Clear();
            for (int i = 0; i < lstUnit.Count; i++)
                cmbUnit.Items.Add(lstUnit[i]);
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtNote.Clear();
            txtNote.Clear();
            cmbCustomer.SelectedIndex = -1;
            cmbCustomer.SelectedItem = -1;
            cmbCustomer.Text = string.Empty;
            cmbPackagingType.SelectedIndex = -1;
            cmbPackagingType.SelectedItem = -1;
            cmbPackagingType.Text = string.Empty;
            cmbRawMaterial.SelectedIndex = -1;
            cmbRawMaterial.SelectedItem = -1;
            cmbRawMaterial.Text = string.Empty;
            cmbUnit.SelectedIndex = -1;
            cmbUnit.SelectedItem = -1;
            cmbUnit.Text = string.Empty;
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref cmbCustomer, ref lblCustomer, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbPackagingType, ref lblpack, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbRawMaterial, ref lblRawMaterial, "selected")) isValid = false;
            if (!clsValidation.validateField(ref cmbUnit, ref lblUnit, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtName, ref lblWidth, "notEmpty")) isValid = false;

            return isValid;
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (clsRawMaterial.isUniqueCode(txtName.Text))
                {
                    clsRawMaterial ObjRawMaterial = new clsRawMaterial();
                    ObjRawMaterial.fkRawMaterialtype = (((clsRawMaterialtype)cmbRawMaterial.SelectedItem).codsec);
                    ObjRawMaterial.fkPackagingType = ((clsPackagingType)cmbPackagingType.SelectedItem).codsec;
                    ObjRawMaterial.fkUnit = ((clsUnit)cmbUnit.SelectedItem).codsec;
                    ObjRawMaterial.fkEntity = ((clsEntity)cmbCustomer.SelectedItem).codsec;
                    ObjRawMaterial.name = txtName.Text + " - " + (((clsRawMaterialtype)cmbRawMaterial.SelectedItem).name);
                    ObjRawMaterial.code = txtName.Text.Trim().ToUpper();
                    ObjRawMaterial.note = txtNote.Text;

                    if (ObjRawMaterial.save())
                    {
                        MessageBox.Show("Se ha ingresado correctamente la materia prima", "Materia Prima", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (MessageBox.Show("Desea ingresar una nueva materia prima", "Materia Prima", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            PopulateCustomer();
                            PopulateTypeRawMaterial();
                            PopulatePacking();
                            PopulateUnit();
                            ClearForm();
                            cmbCustomer.Focus();
                        }
                        else
                            this.Close();
                    }
                    else
                        MessageBox.Show("No se ha podido procesar los datos correctamente..", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Código de Materia Prima ya ingresado por favor verifique el nombre ingresado y vuelva a generar");
                    txtName.Focus();
                }
            }
            else
                MessageBox.Show("Debe ingresar todos los datos requeridos para poder continuar", "Etiquetas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
