using System;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Raw
{
    public partial class frmPalletDetailRawMP : Form
    {
        #region Init

        clsRawMaterialbyCoilCellar rawOBJ = new clsRawMaterialbyCoilCellar();
        bool enablePrintButon = false;
        int codsecRM = 0;

        public frmPalletDetailRawMP()
        {
            InitializeComponent();
        }

        public frmPalletDetailRawMP(int palletCodsec)
        {
            InitializeComponent();
            rawOBJ.LoadToDetail(palletCodsec);

            if (rawOBJ.codsec != 0)
            {
                codsecRM = rawOBJ.codsec;
                txtPalletCode.Text = rawOBJ.code;
                lblNotes.Text = rawOBJ.notes;
                lblTmP.Text = rawOBJ.productName.ToUpper();
                lblProduct.Text = rawOBJ.product.ToUpper();
                lblLot.Text = rawOBJ.lotnumber.ToUpper();
                lblNP.Text = rawOBJ.order.ToString();
                lblBag.Text = rawOBJ.bag.ToString();
                lblPP.Text = Convert.ToString(Math.Round(rawOBJ.palletweigth, 1));
                lblNetWeigth.Text = Convert.ToString(Math.Round(rawOBJ.netweigth, 1));
                lblGrossWeigth2.Text = Convert.ToString(Math.Round(rawOBJ.grossweigth, 1));
                lblNotes.Text = rawOBJ.notes.ToUpper();

                lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                enablePrintButon = true;

            }
            else
            {
                MessageBox.Show("No existe un pallet registrado con ese código.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, false);
                clearForm();
            }
        }

        #endregion

        #region Helper

        private void clearForm()
        {
            txtPalletCode.Clear();
            lblNotes.Text = "";
            lblTmP.Text = "";
            lblProduct.Text = "";
            lblLot.Text = "";
            lblNP.Text = "0";
            lblBag.Text = "0";
            lblPP.Text = "0.0";
            lblNetWeigth.Text = "0.0";
            lblGrossWeigth.Text = "0.0";
            lblNotes.Text = "";
        }

        #endregion

        #region Actions

        private void txtPalletCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rawOBJ.getRawByCode(txtPalletCode.Text.Trim().ToUpper());

                if (rawOBJ.codsec != 0)
                {
                    codsecRM = rawOBJ.codsec;
                    txtPalletCode.Text = rawOBJ.code;
                    lblNotes.Text = rawOBJ.notes;
                    lblTmP.Text = rawOBJ.productName.ToUpper();
                    lblProduct.Text = rawOBJ.product.ToUpper();
                    lblLot.Text = rawOBJ.lotnumber.ToUpper();
                    lblNP.Text = rawOBJ.order.ToString();
                    lblBag.Text = rawOBJ.bag.ToString();
                    lblPP.Text = Convert.ToString(Math.Round(rawOBJ.palletweigth, 1));
                    lblNetWeigth.Text = Convert.ToString(Math.Round(rawOBJ.netweigth, 1));
                    lblGrossWeigth2.Text = Convert.ToString(Math.Round(rawOBJ.grossweigth, 1));
                    lblNotes.Text = rawOBJ.notes.ToUpper();

                    lblStatusColor.BackColor = Color.FromArgb(255, 192, 128);
                    enablePrintButon = true;

                }
                else
                {
                    MessageBox.Show("No existe un pallet registrado con ese código.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                    clearForm();
                }
            }
        }

        private void btnPrintCoilsLabels_Click(object sender, EventArgs e)
        {
            if (codsecRM != 0)
            {
                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printRawLabel(rawOBJ.codsec); });
                thrdPrint.Start();
                thrdPrint.Join();
            }
            else
            {
                MessageBox.Show("No existe un pallet para ser impreso.", "Detalle de pallets", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                clearForm();
            }
        }

        #endregion
    }
}