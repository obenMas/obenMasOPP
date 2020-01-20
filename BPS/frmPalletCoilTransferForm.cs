using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmPalletCoilTransferForm : Form
    {
        clsPalletCoilTransfer objPalletCoilTransfer = new clsPalletCoilTransfer();
        
        public frmPalletCoilTransferForm()
        {
            InitializeComponent();
        }
        public frmPalletCoilTransferForm(int transferCodsec)
        {
            InitializeComponent();
            objPalletCoilTransfer = new clsPalletCoilTransfer(transferCodsec);
        }

        private void frmPalletCoilTransferForm_Load(object sender, EventArgs e)
        {
            lblOriginCellar.Text = objPalletCoilTransfer.originCellarName;
            lblDestinationCellar.Text = objPalletCoilTransfer.destinationCellarName;
            lblSender.Text = objPalletCoilTransfer.sender;
            lblDate.Text = objPalletCoilTransfer.transferDate.ToString("dd/MM/yyyy HH:mm");

            dgvITDPallets.Rows.Clear();

            for (int i = 0; i < objPalletCoilTransfer.lstPallets.Count; i++)
            {
                dgvITDPallets.Rows.Add();
                dgvITDPallets.Rows[i].Cells[clmITDPCodsec.Index].Value = objPalletCoilTransfer.lstPallets[i].codsec;
                dgvITDPallets.Rows[i].Cells[clmITDPCode.Index].Value = objPalletCoilTransfer.lstPallets[i].code;
                dgvITDPallets.Rows[i].Cells[clmITDPCustomer.Index].Value = objPalletCoilTransfer.lstPallets[i].customerName;
                dgvITDPallets.Rows[i].Cells[clmITDPSalesOrderNumber.Index].Value = objPalletCoilTransfer.lstPallets[i].salesOrderNumber;
                dgvITDPallets.Rows[i].Cells[clmITDPProduct.Index].Value = objPalletCoilTransfer.lstPallets[i].product.code;
                dgvITDPallets.Rows[i].Cells[clmITDPCoils.Index].Value = objPalletCoilTransfer.lstPallets[i].palletType.coilNumber;
            }

            dgvITDCoils.Rows.Clear();

            for (int i = 0; i < objPalletCoilTransfer.lstCoils.Count; i++)
            {
                dgvITDPallets.Rows.Add();
                dgvITDPallets.Rows[i].Cells[clmITDCCodsec.Index].Value = objPalletCoilTransfer.lstCoils[i].codsec;
                dgvITDPallets.Rows[i].Cells[clmITDCCode.Index].Value = objPalletCoilTransfer.lstCoils[i].code;
                dgvITDPallets.Rows[i].Cells[clmITDCCustomer.Index].Value = objPalletCoilTransfer.lstCoils[i].customerName;
                dgvITDPallets.Rows[i].Cells[clmITDCSalesOrderNumber.Index].Value = objPalletCoilTransfer.lstCoils[i].salesOrderNumber;
                dgvITDPallets.Rows[i].Cells[clmITDCProduct.Index].Value = objPalletCoilTransfer.lstPallets[i].product.code;
            }
        }
        private void btnTransferCoils_Click(object sender, EventArgs e)
        {
            objPalletCoilTransfer.executeTransfer();
            MessageBox.Show("Se ha aprobado el ingreso de los pallets y bobinas a esta bodega.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            this.Close();
        }
        private void btnCancelTransferCoils_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar la transferencia?", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
            {
                objPalletCoilTransfer.cancelTransfer();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
