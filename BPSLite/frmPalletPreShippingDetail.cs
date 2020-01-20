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
    public partial class frmPalletPreShippingDetail : Form
    {
        public int number = 0;

        public frmPalletPreShippingDetail()
        {
            InitializeComponent();
        }

        public frmPalletPreShippingDetail(int number)
        {
            InitializeComponent();
            this.number = number;
            this.Text = "Detalles de Pre - Despacho Nro. " + number.ToString();
        }

        private void frmPalletPreShippingDetail_Load(object sender, EventArgs e)
        {
            List<clsPalletPreShipping> lstPalletPreshipping = new List<clsPalletPreShipping>();
            lstPalletPreshipping = clsPalletPreShipping.getListByNumberCompiled(number.ToString());
            if (lstPalletPreshipping.Count > 0)
            {
                dgvPalletShipping.Rows.Clear();
                for (int i = 0; i < lstPalletPreshipping.Count; i++)
                {
                    dgvPalletShipping.Rows.Add();
                    dgvPalletShipping.Rows[i].Cells[clmcode.Index].Value = lstPalletPreshipping[i].code;
                    dgvPalletShipping.Rows[i].Cells[clmorder.Index].Value = lstPalletPreshipping[i].salesordernumber;
                    dgvPalletShipping.Rows[i].Cells[clmcustomer.Index].Value = lstPalletPreshipping[i].companyname;
                    dgvPalletShipping.Rows[i].Cells[clmproduct.Index].Value = lstPalletPreshipping[i].codeproduct;
                    dgvPalletShipping.Rows[i].Cells[clmnetweigth.Index].Value = Math.Round(lstPalletPreshipping[i].netweight, 2);
                    dgvPalletShipping.Rows[i].Cells[clmlotnumber.Index].Value = lstPalletPreshipping[i].lotnumber;
                    dgvPalletShipping.Rows[i].Cells[clmDelete.Index].Value = global::BPS.Lite.Properties.Resources.cross;
                }
            }
        }

        private void dgvPalletShipping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
