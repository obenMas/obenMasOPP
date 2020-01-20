using System;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Raw
{
    public partial class frmPalletDetailRaw : Form
    {
        #region Init

        clsRawMaterialbyCoilCellar rawOBJ = new clsRawMaterialbyCoilCellar();

        int codsecRM = 0;

        public frmPalletDetailRaw()
        {
            InitializeComponent();
        }

        public frmPalletDetailRaw(int palletCodsec)
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

                if (rawOBJ.siigoCellar == "Bodega de Consumo")
                {
                    lblStatusColor.BackColor = Color.FromArgb(232, 202, 244);

                }
                else
                {
                    lblStatusColor.BackColor = Color.FromArgb(176, 247, 182);

                }
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

                    if (rawOBJ.siigoCellar == "Bodega de Consumo")
                    {
                        lblStatusColor.BackColor = Color.FromArgb(232, 202, 244);

                    }
                    else
                    {
                        lblStatusColor.BackColor = Color.FromArgb(176, 247, 182);

                    }
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