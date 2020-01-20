using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPalletPreShippingDetailPL : Form
    {
        public int number = 0;

        public frmPalletPreShippingDetailPL()
        {
            InitializeComponent();
        }

        public frmPalletPreShippingDetailPL(int number)
        {
            InitializeComponent();
            this.number = number;
            this.Text = "Detalles de Pre - Despacho Nro. " + number.ToString();
        }

        private void frmPalletPreShippingDetailPL_Load(object sender, EventArgs e)
        {
            List<clsAymasDepot> lstPalletPreshipping = new List<clsAymasDepot>();
            lstPalletPreshipping = clsAymasDepot.getPalletListByPreShipingNumber(number.ToString());
            if (lstPalletPreshipping.Count > 0)
            {
                dgvPalletShippingPL.Rows.Clear();
                for (int i = 0; i < lstPalletPreshipping.Count; i++)
                {
                    dgvPalletShippingPL.Rows.Add();
                    dgvPalletShippingPL.Rows[i].Cells[clmcode.Index].Value = lstPalletPreshipping[i].palletCode;
                    dgvPalletShippingPL.Rows[i].Cells[clmcustomer.Index].Value = lstPalletPreshipping[i].customer;
                    dgvPalletShippingPL.Rows[i].Cells[clmorder.Index].Value = lstPalletPreshipping[i].saleOrder;
                    dgvPalletShippingPL.Rows[i].Cells[clmproduct.Index].Value = lstPalletPreshipping[i].film;
                    dgvPalletShippingPL.Rows[i].Cells[clmnetweigth.Index].Value = Math.Round(lstPalletPreshipping[i].weigth, 2);
                    dgvPalletShippingPL.Rows[i].Cells[clmDelete.Index].Value = global::BPS.Properties.Resources.cross;
                }
            }
        }

        private void dgvPalletShippingPL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmDelete.Index)
            {
                if (clsPalletPreShippingPL.delete(number, dgvPalletShippingPL.Rows[e.RowIndex].Cells[clmcode.Index].Value.ToString()))
                {
                    dgvPalletShippingPL.Rows.RemoveAt(e.RowIndex);
                }

            }
        }
    }
}
