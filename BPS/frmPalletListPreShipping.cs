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
    public partial class frmPalletListPreShipping : Form
    {
        

        public frmPalletListPreShipping()
        {
            InitializeComponent();
        }

        private void frmPalletListPreShipping_Load(object sender, EventArgs e)
        {
            FillDataPreShipping();
        }

        private void FillDataPreShipping()
        {
            int quantityFiltered = 0;
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            lstPalletPreShipping = clsPalletPreShipping.getListPreShippingBySelTOP(Convert.ToInt32(txtQuantity.Text));
            dgvPalletPreShipping.Rows.Clear();
            for (int i = 0; i < lstPalletPreShipping.Count; i++)
            {
                dgvPalletPreShipping.Rows.Add();
                dgvPalletPreShipping.Rows[i].Cells[clmparameter.Index].Value = lstPalletPreShipping[i].number;
                dgvPalletPreShipping.Rows[i].Cells[clmnumber.Index].Value = lstPalletPreShipping[i].number;
                dgvPalletPreShipping.Rows[i].Cells[clmPlant.Index].Value = lstPalletPreShipping[i].plant;
                dgvPalletPreShipping.Rows[i].Cells[clmremito.Index].Value = lstPalletPreShipping[i].remito;
                dgvPalletPreShipping.Rows[i].Cells[clmview.Index].Value = global::BPS.Properties.Resources.eye;
                dgvPalletPreShipping.Rows[i].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.report;
                dgvPalletPreShipping.Rows[i].Cells[clmisinternational.Index].Value = global::BPS.Properties.Resources.delivery;
                dgvPalletPreShipping.Rows[i].Cells[clmCustomer.Index].Value = lstPalletPreShipping[i].companyname;
                quantityFiltered += 1;
            }
            lblFilteredQuantity.Text = quantityFiltered.ToString();   
        }

        private void dgvPalletPreShipping_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmview.Index)
            {
                frmPalletPreShippingDetail winpallet = new frmPalletPreShippingDetail(Convert.ToInt32(dgvPalletPreShipping.Rows[e.RowIndex].Cells[clmparameter.Index].Value));
                winpallet.StartPosition = FormStartPosition.CenterScreen;
                winpallet.MdiParent = this.MdiParent;
                winpallet.Show();
            }
            else if (e.ColumnIndex == clmreport.Index)
            {
                frmPalletPreShippingReport winPallet = new frmPalletPreShippingReport(dgvPalletPreShipping.Rows[e.RowIndex].Cells[clmparameter.Index].Value.ToString());
                winPallet.StartPosition = FormStartPosition.CenterScreen;
                winPallet.MdiParent = this.MdiParent;
                winPallet.Show();
            }
            else if (e.ColumnIndex == clmisinternational.Index)
            {
                frmPackingListReport winPallet = new frmPackingListReport(dgvPalletPreShipping.Rows[e.RowIndex].Cells[clmnumber.Index].Value.ToString());
                winPallet.StartPosition = FormStartPosition.CenterScreen;
                winPallet.MdiParent = this.MdiParent;
                winPallet.Show();
            }
        }

        private void txtNumberPreShipping_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FillDataPreShippingByFilter(txtNumberPreShipping.Text);
        }

        private void FillDataPreShippingByFilter(string number)
        {
            int quantityFiltered = 0;
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();

            if (number != string.Empty)
            {
                lstPalletPreShipping = clsPalletPreShipping.getListByNumber(number);
            }
            else
            {
                lstPalletPreShipping = clsPalletPreShipping.getListPreShippingBySelTOP(Convert.ToInt32(txtQuantity.Text));
            }
           
            if (lstPalletPreShipping.Count > 0)
            {
                dgvPalletPreShipping.Rows.Clear();
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    dgvPalletPreShipping.Rows.Add();
                    dgvPalletPreShipping.Rows[i].Cells[clmparameter.Index].Value = lstPalletPreShipping[i].number;
                    dgvPalletPreShipping.Rows[i].Cells[clmnumber.Index].Value = lstPalletPreShipping[i].number;
                    dgvPalletPreShipping.Rows[i].Cells[clmremito.Index].Value = lstPalletPreShipping[i].remito;
                    dgvPalletPreShipping.Rows[i].Cells[clmPlant.Index].Value = lstPalletPreShipping[i].plant;
                    dgvPalletPreShipping.Rows[i].Cells[clmview.Index].Value = global::BPS.Properties.Resources.eye;
                    dgvPalletPreShipping.Rows[i].Cells[clmreport.Index].Value = global::BPS.Properties.Resources.report;
                    dgvPalletPreShipping.Rows[i].Cells[clmisinternational.Index].Value = global::BPS.Properties.Resources.delivery;
                    dgvPalletPreShipping.Rows[i].Cells[clmCustomer.Index].Value = lstPalletPreShipping[i].companyname;
                    quantityFiltered += 1;
                }
                lblFilteredQuantity.Text = quantityFiltered.ToString();
            }
            else
            {
                MessageBox.Show("No existen Pre - Despachos con el número ingresado", "Pre - Despacho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataPreShipping();
                txtNumberPreShipping.Clear();
            }
        }

        private void dgvPalletPreShipping_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string queryString = "UPDATE bps_prod_palletpreshipping";
            queryString += " SET ";
            queryString += "palship_remito = "+dgvPalletPreShipping.Rows[e.RowIndex].Cells[clmremito.Index].Value.ToString();
            queryString += " WHERE palship_number = " + dgvPalletPreShipping.Rows[e.RowIndex].Cells[clmnumber.Index].Value.ToString();

            bool done=clsConnection.executeQuery(queryString);
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
               if(e.KeyCode==Keys.Enter)
               {
                   FillDataPreShipping();
               }
        }
    }
}