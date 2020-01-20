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
    public partial class frmShippingMultiple : Form
    {
        public bool isAutoricet = false;

        List<string> lstPalletCode = new List<string>();

        public frmShippingMultiple()
        {
            //frmCellarLogin winLogin = new frmCellarLogin(this);
            //winLogin.ShowDialog(this);

            //if (isAutoricet)
            //{
                InitializeComponent();
                this.Show();
            //}
            //else
            //    this.Close();
        }

        private void txtOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtOrder.Text != "")
                    FillInternationalPallets(txtOrder.Text);
                else
                    MessageBox.Show("Debe ingresar una orden para poder consultar sus pallets", "Despacho Masivo", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void FillInternationalPallets(string internationalsalesnumber)
        {
            int totalcoil = 0;
            double totalweigth = 0;
            List<clsPalletPreShipping> lstPalletPreShipping = new List<clsPalletPreShipping>();
            lstPalletPreShipping = clsPalletPreShipping.getInternationalPalletListBySalesOrderNumber(internationalsalesnumber);
            dgvInternationalFrom.Rows.Clear();
            if (lstPalletPreShipping.Count > 0)
            {
                totalcoil = 0;
                totalweigth = 0;
                for (int i = 0; i < lstPalletPreShipping.Count; i++)
                {
                    dgvInternationalFrom.Rows.Add();
                    dgvInternationalFrom.Rows[i].Cells[clminternationalcustomerfrom.Index].Value = lstPalletPreShipping[i].companyname;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalcodsec.Index].Value = lstPalletPreShipping[i].fkpallet;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalcode.Index].Value = lstPalletPreShipping[i].code;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalproduct.Index].Value = lstPalletPreShipping[i].codeproduct;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalorder.Index].Value = lstPalletPreShipping[i].salesordernumber;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalnumberpallet.Index].Value = lstPalletPreShipping[i].palletnumber;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalnumbercoil.Index].Value = lstPalletPreShipping[i].coilnumber;
                    dgvInternationalFrom.Rows[i].Cells[clminternationalnetweitgh.Index].Value = Math.Round(lstPalletPreShipping[i].netweight, 2);
                    totalcoil += lstPalletPreShipping[i].coilnumber;
                    totalweigth += Math.Round(lstPalletPreShipping[i].netweight, 2);
                }
                lblTotalPallet.Text = dgvInternationalFrom.Rows.Count.ToString();
                lblTotalCoil.Text = totalcoil.ToString();
                lblTotalWeigth.Text = totalweigth.ToString();
            }
            else
            {
                dgvInternationalFrom.Rows.Clear();
                MessageBox.Show("No existen pallets asociados a esa orden", "Despacho Masivo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta realmente seguro que desea despachar la orden # " + txtOrder.Text, "Despacho Masivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false) == DialogResult.Yes)
                {
                    if (dgvInternationalFrom.Rows.Count > 0)
                    {
                        lstPalletCode.Clear();

                        for (int i = 0; i < dgvInternationalFrom.Rows.Count; i++)
                            lstPalletCode.Add(dgvInternationalFrom.Rows[i].Cells[clminternationalcode.Index].Value.ToString());

                        clsPallet.setUpdateStatusWhenDeliveryPallet(lstPalletCode);
                        MessageBox.Show("Pallets Despachados Correctamente", "Despacho Masivo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                    }
                    else
                        MessageBox.Show("No existen pallets asociados a esa orden", "Despacho Masivo", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Despacho Masivo", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
            }
        }
    }
}
