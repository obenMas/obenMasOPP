using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPS.Lite
{
    public partial class frmAltaSupplier : Form
    {
        public frmAltaSupplier()
        {
            InitializeComponent();
        }

        public frmAltaSupplier(string proveedor, string abreviacion, string origen, DataGridView Dgv)
        {
            txtProveedor.Text = proveedor;
            txtAbr.Text = abreviacion;

            if (origen == "IMPORTADO")
            {
                rbImp.Checked = true;
            }
            else
            {
                rbLocal.Checked = true;
            }

        }
    }
}
