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
    public partial class frmABMSupplier : Form
    {
        public frmABMSupplier()
        {
            InitializeComponent();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaSupplier alta = new frmAltaSupplier();
            alta.ShowDialog();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count != 0) // Si la coleccion es mayor que cero es que seleccionó una fila.
            {
                string nombre = dgvProveedores.CurrentRow.Cells[clmNombre.Index].Value.ToString();
                string abr = dgvProveedores.CurrentRow.Cells[clmAbr.Index].Value.ToString();
                string origen = dgvProveedores.CurrentRow.Cells[clmOrigen.Index].ToString();

                frmAltaSupplier modif = new frmAltaSupplier(nombre,abr,origen,dgvProveedores);
                modif.ShowDialog();
            }
        }
    }
}
