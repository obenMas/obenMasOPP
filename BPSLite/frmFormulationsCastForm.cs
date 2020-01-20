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
    public partial class frmFormulationsCastForm : Form
    {
        clsFormulation objFormulation = new clsFormulation();
        clsRawMaterialByFormulation objRawmaterialByFormulation = new clsRawMaterialByFormulation();
        public int selectedRawMaterial = 0;

        public frmFormulationsCastForm()
        {
            InitializeComponent();
        }

        public bool validateForm()
        {
            bool isValid = true;
                        
            if (!clsValidation.validateField(ref txtName, ref lblFormulationCastName, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref cmbCastFilm, ref lblFormulationCastFilm, "selected")) isValid = false;
            if (!clsValidation.validateField(ref txtThickness, ref lblFormulationCastThickness, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtC1Thickness, ref lblC1Percentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtCentralLayerThickness, ref lblCentralLayerPercentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref txtC2Thickness, ref lblC2Percentage, "notEmpty")) isValid = false;
            if (!clsValidation.validateField(ref dgvC1, ref grpbC1, "isValid")) isValid = false;
            if (!clsValidation.validateField(ref dgvC1, ref grpbCentralLayer, "isValid")) isValid = false;
            if (!clsValidation.validateField(ref dgvC1, ref grpbC2, "isValid")) isValid = false;

            if (txtC1Percentage.Text != "100")
            {
                txtC1Percentage.BackColor = Color.FromArgb(253, 230, 231);
                lblC1Percentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtC1Percentage.BackColor = SystemColors.Window;
                lblC1Percentage.ForeColor = SystemColors.WindowText;
            }

            if (txtCentralLayerPercentage.Text != "100")
            {
                txtCentralLayerPercentage.BackColor = Color.FromArgb(253, 230, 231);
                lblCentralLayerPercentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtCentralLayerPercentage.BackColor = SystemColors.Window;
                lblCentralLayerPercentage.ForeColor = SystemColors.WindowText;
            }

            if (txtC2Percentage.Text != "100")
            {
                txtC2Percentage.BackColor = Color.FromArgb(253, 230, 231);
                lblC2Percentage.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                txtC2Percentage.BackColor = SystemColors.Window;
                lblC2Percentage.ForeColor = SystemColors.WindowText;
            }

            if (Math.Round((Convert.ToDouble(txtC1Thickness.Text) + Convert.ToDouble(txtCentralLayerThickness.Text) + Convert.ToDouble(txtC2Thickness.Text)),2) != Convert.ToDouble(txtThickness.Text))
            {
                txtThickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationCastThickness.ForeColor = Color.Red;

                txtC1Thickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationCastC1Thickness.ForeColor = Color.Red;

                txtCentralLayerThickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationCastCentralLayerThickness.ForeColor = Color.Red;

                txtC2Thickness.BackColor = Color.FromArgb(253, 230, 231);
                lblFormulationCastC2Thickness.ForeColor = Color.Red;

                isValid = false;
            }
            else
            {
                txtThickness.BackColor = SystemColors.Window;
                lblFormulationCastThickness.ForeColor = SystemColors.WindowText;

                txtC1Thickness.BackColor = SystemColors.Window;
                lblFormulationCastC1Thickness.ForeColor = SystemColors.WindowText;

                txtCentralLayerThickness.BackColor = SystemColors.Window;
                lblFormulationCastCentralLayerThickness.ForeColor = SystemColors.WindowText;

                txtC2Thickness.BackColor = SystemColors.Window;
                lblFormulationCastC2Thickness.ForeColor = SystemColors.WindowText;
            }

            return isValid;
        }
        private void frmFormulationsCastForm_Load(object sender, EventArgs e)
        {
            List<clsCast> lstCast = clsCast.getSimplifiedList();
            cmbCastFilm.Items.Clear();
            for (int i = 0; i < lstCast.Count; i++)
                cmbCastFilm.Items.Add(lstCast[i]);
        }

        private void btnFormulationCastSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                objFormulation.name = txtName.Text;
                objFormulation.description = txtDescription.Text;
                objFormulation.thick = Convert.ToDouble(txtThickness.Text);
                objFormulation.thickLayerC1 = Convert.ToDouble(txtC1Thickness.Text);
                objFormulation.thickLayerC2 = Convert.ToDouble(txtC2Thickness.Text);
                objFormulation.thickCentralLayer = Convert.ToDouble(txtCentralLayerThickness.Text);
                objFormulation.fkCast = ((clsCast)cmbCastFilm.SelectedItem).codsec;

                for (int i = 0; i < dgvC1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1RawMaterialCodsec.Index].Value) != 0)
                    {
                        objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC1.Rows[i].Cells[clmC1RawMaterialCodsec.Index].Value);
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC1 = true;
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
                    }
                }

                for (int i = 0; i < dgvC2.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2RawMaterialCodsec.Index].Value) != 0)
                    {
                        objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvC2.Rows[i].Cells[clmC2RawMaterialCodsec.Index].Value);
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].layerC2 = true;
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
                    }
                }

                for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerRawMaterialCodsec.Index].Value) != 0)
                    {
                        objFormulation.lstRawMaterialByFormulation.Add(new clsRawMaterialByFormulation());
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].fkRawMaterial = Convert.ToInt32(dgvCentralLayer.Rows[i].Cells[clmCentralLayerRawMaterialCodsec.Index].Value);
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].CentralLayer = true;
                        objFormulation.lstRawMaterialByFormulation[objFormulation.lstRawMaterialByFormulation.Count - 1].percentage = Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
                    }
                }

                if (objFormulation.save())
                {
                    MessageBox.Show("La formulación se ha guardado con éxito", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    this.Close();
                }
                else
                    MessageBox.Show("Ha sucedido un error y la información no ha podido ser guardada.", "Formulaciones", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
        }

        private void dgvFormulationCastC1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);
                if (objRawMaterial.codsec > 0)
                {
                    dgvC1.CurrentRow.Cells[clmC1RawMaterial.Index].Value = objRawMaterial.code;
                    dgvC1.CurrentRow.Cells[clmC1RawMaterialCodsec.Index].Value = objRawMaterial.codsec;
                }                
            }
        }

        private void dgvFormulationCastCentalLayer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvCentralLayer.CurrentRow.Cells[clmCentralLayerRawMaterial.Index].Value = objRawMaterial.code;
                    dgvCentralLayer.CurrentRow.Cells[clmCentralLayerRawMaterialCodsec.Index].Value = objRawMaterial.codsec;
                }
            }
        }

        private void dgvFormulationCastC2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRawMaterial objRawMaterial = new clsRawMaterial();
            if (e.ColumnIndex == 1)
            {
                frmRawMaterialSelector winRawMaterialSelector = new frmRawMaterialSelector(this);
                winRawMaterialSelector.ShowDialog(this);
                objRawMaterial.load(selectedRawMaterial);

                if (objRawMaterial.codsec > 0)
                {
                    dgvC2.CurrentRow.Cells[clmC2RawMaterial.Index].Value = objRawMaterial.code;
                    dgvC2.CurrentRow.Cells[clmC1RawMaterialCodsec.Index].Value = objRawMaterial.codsec;
                }
            }
        }

        private void dgvC1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
       {
            switch (e.ColumnIndex)
            {
                case 3:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numerico");
                        dgvC1.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvC1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            switch (e.ColumnIndex)
            {
                case 3:
                    for (int i = 0; i < dgvC1.Rows.Count; i++)
                        {
                            if (dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value != null && dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value.ToString() != "")
                                totalPercentage += Convert.ToDouble(dgvC1.Rows[i].Cells[clmC1Percentage.Index].Value);
                        }
                        txtC1Percentage.Text = totalPercentage.ToString();
                    break;
            }
        }

        private void dgvCentalLayer_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numerico");
                        dgvCentralLayer.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvCentalLayer_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            switch (e.ColumnIndex)
            {
                case 3:
                    for (int i = 0; i < dgvCentralLayer.Rows.Count; i++)
                    {
                        if (dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value != null && dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvCentralLayer.Rows[i].Cells[clmCentralLayerPercentage.Index].Value);
                    }
                    txtCentralLayerPercentage.Text = totalPercentage.ToString();
                    break;
            }
        }

        private void dgvC2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 3:
                    if (clsGlobal.isNumeric(e.FormattedValue.ToString()) == false && e.FormattedValue.ToString() != "")
                    {
                        MessageBox.Show("El valor debe ser Numerico");
                        dgvC2.CancelEdit();
                    }
                    break;
            }
        }

        private void dgvC2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double totalPercentage = 0;
            switch (e.ColumnIndex)
            {
                case 3:
                    for (int i = 0; i < dgvC2.Rows.Count; i++)
                    {
                        if (dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value != null && dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value.ToString() != "")
                            totalPercentage += Convert.ToDouble(dgvC2.Rows[i].Cells[clmC2Percentage.Index].Value);
                    }
                    txtC2Percentage.Text = totalPercentage.ToString();
                    break;
            }
        }

        private void dgvC1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmC1Codsec.Index].Value = "0";
        }

        private void dgvCentralLayer_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmCentralLayerCodsec.Index].Value = "0";
        }

        private void dgvC2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[clmC2Codsec.Index].Value = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realemente esta seguro de cancelar formulación Cast?..", "Formulaciones Cast", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmbCastFilm.SelectedIndex = -1;
                txtName.Text = "";
                txtThickness.Text = "0";
                txtDescription.Text = "";
                txtC1Thickness.Text = "0";
                txtC1Percentage.Text = "";
                txtC2Thickness.Text = "0";
                txtC2Percentage.Text = "";
                txtCentralLayerPercentage.Text = "";
                txtCentralLayerThickness.Text = "0";
            }
        }

        private void cmbCastFilm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCast> lstCast = clsCast.getSimplifiedList();
                cmbCastFilm.Items.Clear();
                for (int i = 0; i < lstCast.Count; i++)
                    cmbCastFilm.Items.Add(lstCast[i]); 
            }
        }
    }
}