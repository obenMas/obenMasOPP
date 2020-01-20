using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Raw.Helper
{
    public partial class frmTraza : Form
    {
        public frmTraza()
        {
            InitializeComponent();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCode.Text))
                    fillRaw(txtCode.Text);
                else
                    MessageBox.Show("Debe al menos ingresar un valor");
            }
        }

        private void fillRaw(string code)
        {
            try
            {
                var rawOBJ = clsRawMaterialExtruder.getRawByCodeExtruderTraza(code);

                if (rawOBJ.codsec > 0)
                {
                    lblFor.Text = rawOBJ.message;
                    lblTmP.Text = rawOBJ.MaterialCode;
                    lblProduct.Text = rawOBJ.MaterialName;
                    lblLot.Text = rawOBJ.lotNumber;
                    txtNWeight.Text = rawOBJ.netWeigth.ToString();
                    lblIn.Text = rawOBJ.date.ToString("dd/MM/yyyy HH:mm:ss");
                    lblPro.Text = rawOBJ.datePro.ToString("dd/MM/yyyy HH:mm:ss");
                }
                else
                    MessageBox.Show("Pallet no encontrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
