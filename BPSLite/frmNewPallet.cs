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
    public partial class frmNewPallet : Form
    {
        public frmNewPallet()
        {
            InitializeComponent();
        }

        private void frmNewPallet_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventarioPallets.vwInventarioCompletoPallets' Puede moverla o quitarla según sea necesario.
            this.vwInventarioCompletoPalletsTableAdapter.Fill(this.inventarioPallets.vwInventarioCompletoPallets);

        }
    }
}
