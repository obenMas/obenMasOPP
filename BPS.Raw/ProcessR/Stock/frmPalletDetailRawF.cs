using System;
using System.Drawing;
using System.Windows.Forms;
using BPS.Bussiness;
using System.Threading;

namespace BPS.Raw.ProcessR.Stock
{
    public partial class frmPalletDetailRawF : Form
    {
        #region Init

        clsRawMaterialbyCoilCellar rawOBJ = new clsRawMaterialbyCoilCellar();
        bool enablePrintButon = false;
        int codsecRM = 0;
        string codeRM = String.Empty;

        public frmPalletDetailRawF()
        {
            InitializeComponent();
        }

        public frmPalletDetailRawF(int palletCodsec)
        {
            InitializeComponent();
            rawOBJ.LoadToDetailF(palletCodsec);

            if (rawOBJ.codsec != 0)
            {
                codsecRM = rawOBJ.codsec;
                txtPalletCode.Text = rawOBJ.code;
                codeRM = rawOBJ.code;
                lblTmP.Text = rawOBJ.productName.ToUpper();
                lblProduct.Text = rawOBJ.product.ToUpper();
                lblLot.Text = rawOBJ.lotnumber.ToUpper();
                lblNetWeigth.Text = Convert.ToString(Math.Round(rawOBJ.netweigth, 1));
                lblStatusColor.BackColor = Color.FromArgb(176, 247, 182);
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
            lblTmP.Text = "";
            lblProduct.Text = "";
            lblLot.Text = "";
            lblNetWeigth.Text = "0.0";
        }

        #endregion

        #region Actions

        private void btnPrintCoilsLabels_Click(object sender, EventArgs e)
        {
            if (codsecRM != 0)
            {
                Thread thrdPrint = new Thread(delegate() { clsPrintLabels.printReRawLabel(codsecRM.ToString()); });
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