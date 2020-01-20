using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmMillOrder : Form
    {
        int codsec = 0;

        clsMillPallet objMillPallet = new clsMillPallet();

        public frmMillOrder()
        {
            InitializeComponent();
        }

        public frmMillOrder(int codsec)
        {
            InitializeComponent();
            PopulateMill();
            objMillPallet.load(codsec);
            PopulateHead(objMillPallet);
            txtSequiential.Text = objMillPallet.order.ToString();
            txtSequiential.Enabled = false;
            txtDensity.Text = Math.Round(objMillPallet.density, 4).ToString();
            txtObservations.Text = objMillPallet.notes;
            txtpallet.Text = Math.Round(objMillPallet.palletWeigth, 1).ToString();
            txtpallet.Enabled = false;
            txtgrossweigth.Text = Math.Round(objMillPallet.grossWeigth, 1).ToString();
            txtgrossweigth.Enabled = false;
            lblNetWeigth.Text = Math.Round(objMillPallet.netWeigth, 1).ToString();
            this.codsec = codsec;
            cmbMill.Enabled = false;
            cmbMilProduct.Enabled = false;
            txtCustomer.Enabled = false;
        }

        private void PopulateHead(clsMillPallet objMillPallet)
        {
            cmbMilProduct.SelectedItem = objMillPallet.Product;
            PopulateMill();
            for (int i = 0; i < cmbMill.Items.Count; i++)
            {
                if (((clsMill)cmbMill.Items[i]).codsec == objMillPallet.fkMill)
                {
                    cmbMill.SelectedIndex = i;
                    break;
                }
            }
        }

        private void PopulateMill()
        {
            List<clsMill> lstDeadTime = new List<clsMill>();
            lstDeadTime = clsMill.getListMill();
            cmbMill.Items.Clear();
            for (int i = 0; i < lstDeadTime.Count; i++)
                cmbMill.Items.Add(lstDeadTime[i]);
        }

        private double GetMinutesTime(DateTime dtpinit, DateTime dtpend)
        {
            var time = dtpinit.Subtract(dtpend).Minutes;
            return Math.Abs(time);
        }

        private void btnWeigth_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateProcess())
                {
                    objMillPallet.notes = txtObservations.Text;
                    objMillPallet.density = (txtDensity.Text.Length > 0) ? Convert.ToDouble(txtDensity.Text) : 0;
                    if (objMillPallet.saveDensity())
                    {
                        MessageBox.Show("Re-Proceso Guardado Correctamente?", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                        this.Close();
                    }
                    else
                        MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
                else
                    MessageBox.Show("La información no ha podido ser guardada por favor verifique la información en los campos\r\nRecuerde que debe llenar todos los campos que se encuentre de color rojo!", "Re-Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Peso - Metalizado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private bool ValidateProcess()
        {
            bool isValid = true;
            if (!clsValidation.validateField(ref txtDensity, ref label4, "notEmpty")) isValid = false;
            return isValid;
        }

        private void txtDensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsPunctuation(e.KeyChar))
                e.Handled = false;
            else if (Char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}