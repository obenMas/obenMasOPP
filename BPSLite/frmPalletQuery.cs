using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Lite
{
    public partial class frmPalletQuery : Form
    {
        private clsPallet pallet = new clsPallet();

        public frmPalletQuery(clsPallet pal)
        {
            InitializeComponent();
            pallet = pal;
            llenarDatos();
        }

        private void llenarDatos()
        {
            txtCodigoPallet.Text = pallet.code;
            txtBodega.Text = pallet.coilCellarName;
            txtPosicion.Text = pallet.position;
            txtProducto.Text = pallet.product.code;
            txtBobinas.Text = pallet.lstCoil.Count.ToString();
            clsSalesOrder so = new clsSalesOrder(pallet.fkSalesOrder);
            clsEntity ent = new clsEntity(so.fkEntity);
            if (ent.codsec!=0)
            {
                txtCliente.Text = ent.companyName;
            }
            else
            {
                txtCliente.Text = "STOCK";
            }
            txtPedido.Text = pallet.salesOrderNumber;
            txtEstado.Text = new clsStatus(pallet.fkStatus).name;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
