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
    public partial class frmPalletListPreShippingPL : Form
    {
        public frmPalletListPreShippingPL()
        {
            InitializeComponent();
        }

        private void frmPalletListPreShippingPL_Load_1(object sender, EventArgs e)
        {
            FillDataPreShippingPL();

        }

        private void FillDataPreShippingPL()
        {
            List<clsPalletPreShippingPL> lstPalletPreShipping = new List<clsPalletPreShippingPL>();
            lstPalletPreShipping = clsPalletPreShippingPL.getListPreShipping();
            dgvPalletPreShippingPL.Rows.Clear();
            for (int i = 0; i < lstPalletPreShipping.Count; i++)
            {
                dgvPalletPreShippingPL.Rows.Add();
                dgvPalletPreShippingPL.Rows[i].Cells[clmparameter.Index].Value = lstPalletPreShipping[i].number;
                dgvPalletPreShippingPL.Rows[i].Cells[clmnumber.Index].Value = lstPalletPreShipping[i].number;
                dgvPalletPreShippingPL.Rows[i].Cells[clmremito.Index].Value = lstPalletPreShipping[i].remito;
                dgvPalletPreShippingPL.Rows[i].Cells[clmview.Index].Value = global::BPS.Properties.Resources.eye;
                dgvPalletPreShippingPL.Rows[i].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.report;
                dgvPalletPreShippingPL.Rows[i].Cells[clmisinternational.Index].Value = global::BPS.Properties.Resources.delivery;
                dgvPalletPreShippingPL.Rows[i].Cells[clmCustomer.Index].Value = lstPalletPreShipping[i].companyname;
            }
        }


        private void dgvPalletPreShippingPL_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmview.Index)
            {
                frmPalletPreShippingDetailPL winpallet = new frmPalletPreShippingDetailPL(Convert.ToInt32(dgvPalletPreShippingPL.Rows[e.RowIndex].Cells[clmparameter.Index].Value));
                winpallet.StartPosition = FormStartPosition.CenterScreen;
                winpallet.MdiParent = this.MdiParent;
                winpallet.Show();
            }
            /*else if (e.ColumnIndex == clmreport.Index)
            {
                frmPalletPreShippingReport winPallet = new frmPalletPreShippingReport(dgvPalletPreShippingPL.Rows[e.RowIndex].Cells[clmparameter.Index].Value.ToString());
                winPallet.StartPosition = FormStartPosition.CenterScreen;
                winPallet.MdiParent = this.MdiParent;
                winPallet.Show();
            }
            else if (e.ColumnIndex == clmisinternational.Index)
            {
                frmPackingListReport winPallet = new frmPackingListReport(dgvPalletPreShippingPL.Rows[e.RowIndex].Cells[clmnumber.Index].Value.ToString());
                winPallet.StartPosition = FormStartPosition.CenterScreen;
                winPallet.MdiParent = this.MdiParent;
                winPallet.Show();
            }*/
        }

        private void txtNumberPreShippingPL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillDataPreShippingByFilter(txtNumberPreShippingPL.Text);
        }

        private void FillDataPreShippingByFilter(string number)
        {
            List<clsPalletPreShippingPL> lstPalletPreShipping = new List<clsPalletPreShippingPL>();
            
            if(number != string.Empty)
            { 
                lstPalletPreShipping = clsPalletPreShippingPL.getListByNumber(number); 
            }
            else
            {
                lstPalletPreShipping = clsPalletPreShippingPL.getListPreShipping();
            }
            
            if (lstPalletPreShipping.Count > 0)
            {
                dgvPalletPreShippingPL.Rows.Clear();
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    dgvPalletPreShippingPL.Rows.Add();
                    dgvPalletPreShippingPL.Rows[i].Cells[clmparameter.Index].Value = lstPalletPreShipping[i].number;
                    dgvPalletPreShippingPL.Rows[i].Cells[clmnumber.Index].Value = lstPalletPreShipping[i].number;
                    dgvPalletPreShippingPL.Rows[i].Cells[clmremito.Index].Value = lstPalletPreShipping[i].remito;
                    dgvPalletPreShippingPL.Rows[i].Cells[clmview.Index].Value = global::BPS.Properties.Resources.eye;
                    dgvPalletPreShippingPL.Rows[i].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.report;
                    dgvPalletPreShippingPL.Rows[i].Cells[clmisinternational.Index].Value = global::BPS.Properties.Resources.delivery;
                    dgvPalletPreShippingPL.Rows[i].Cells[clmCustomer.Index].Value = lstPalletPreShipping[i].companyname;
                }
            }
            else
            {
                MessageBox.Show("No existen Pre - Despachos con el número ingresado", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataPreShippingPL();
                txtNumberPreShippingPL.Clear();
            }
        }

        private void dgvPalletPreShippingPL_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string queryString = "UPDATE bps_prod_palletpreshippingPL";
            queryString += " SET ";
            queryString += "palshippl_remito = " + dgvPalletPreShippingPL.Rows[e.RowIndex].Cells[clmremito.Index].Value.ToString();
            queryString += " WHERE palshippl_number = " + dgvPalletPreShippingPL.Rows[e.RowIndex].Cells[clmnumber.Index].Value.ToString();

            bool done = clsConnection.executeQuery(queryString);
        }

    }
}
