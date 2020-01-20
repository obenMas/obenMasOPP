using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS.Lite
{
    public partial class frmRawMaterialRePrintLabel : Form
    {
        public frmRawMaterialRePrintLabel()
        {
            InitializeComponent();
            txtCode.Text = string.Empty;
        }

        private void btnRePrint_Click(object sender, EventArgs e)
        {
            txtCode.Text.Trim();
            clsRawMaterialPallet palletRaw = new clsRawMaterialPallet(txtCode.Text);

            if (clsGlobal.LoggedUser.fkRole == 2029 || clsGlobal.LoggedUser.fkRole == 2030 || clsGlobal.LoggedUser.fkRole == 2032)
            {
                clsPrintLabels.printRawLabelPL(palletRaw.codsec);
            }
            else
            {
                clsPrintLabels.printRawLabel(palletRaw.codsec);
            }

            MessageBox.Show("Imprimiendo etiqueta, aguarde un momento por favor", "Imprimiendo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
