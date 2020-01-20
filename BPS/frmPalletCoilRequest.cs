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
    public partial class frmPalletCoilRequest : Form
    {
        List<clsCoilCellar> lstOriginCellar = clsCoilCellar.getStockCellarList();
        List<clsCoilCellar> lstDestinationCellar = new List<clsCoilCellar>();
        List<clsPallet> lstPallets = new List<clsPallet>();
        List<clsCoil> lstCoil = new List<clsCoil>();
        string dataGridSender = "";

        public frmPalletCoilRequest()
        {
            InitializeComponent();
        }
        public frmPalletCoilRequest(string process)
        {
            InitializeComponent();
            switch (process)
            {
                case "metallizign":
                    lstDestinationCellar = clsCoilCellar.getMetallizedBaseCellarList();
                    break;
                case "secundaryCut":
                    lstDestinationCellar = clsCoilCellar.getSecundaryCutCellarList();
                    break;
                default:
                    break;
            }
        }
        private void loadPalletsAndCoilGrid()
        {
            cmbDestinationCellar.SelectedIndex = -1;
            dgvTransferListPallet.Rows.Clear();

            lstPallets = clsPallet.getListByCoilCellar(((clsCoilCellar)cmbOriginCellar.SelectedItem).codsec);

            dgvPallets.Rows.Clear();

            for (int i = 0; i < lstPallets.Count; i++)
            {
                dgvPallets.Rows.Add();

                dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value = lstPallets[i].codsec;
                dgvPallets.Rows[i].Cells[clmPalletCode.Index].Value = lstPallets[i].code;
                dgvPallets.Rows[i].Cells[clmPalletCustomer.Index].Value = lstPallets[i].customerName + " [" + lstPallets[i].salesOrderNumber + "]";
                dgvPallets.Rows[i].Cells[clmPalletProduct.Index].Value = lstPallets[i].product.code;
                dgvPallets.Rows[i].Cells[clmPalletType.Index].Value = lstPallets[i].palletType.name;
                dgvPallets.Rows[i].Cells[clmPalletWeigth.Index].Value = Convert.ToString(Math.Round(lstPallets[i].netWeight, 2));
            }


            lstCoil = clsCoil.getCoilOutOfPalletsListByCoilCellar(((clsCoilCellar)cmbOriginCellar.SelectedItem).codsec);

            dgvCoils.Rows.Clear();

            for (int i = 0; i < lstCoil.Count; i++)
            {
                dgvCoils.Rows.Add();
                dgvCoils.Rows[i].Cells[clmCodsec.Index].Value = lstCoil[i].codsec;
                dgvCoils.Rows[i].Cells[clmCode.Index].Value = lstCoil[i].code;
                dgvCoils.Rows[i].Cells[clmCustomer.Index].Value = lstCoil[i].customerName + " [" + lstCoil[i].salesOrderNumber + "]";
                dgvCoils.Rows[i].Cells[clmProductName.Index].Value = lstCoil[i].ProductCode;
                dgvCoils.Rows[i].Cells[clmWidth.Index].Value = lstCoil[i].width;
                dgvCoils.Rows[i].Cells[clmWeigth.Index].Value = lstCoil[i].netWeight;
            }
            
        }
        public bool validateFormRequest()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbDestinationCellar, ref lblCellarPallets, "selected")) isValid = false;
            if (!clsValidation.validateField(ref dgvTransferListPallet, ref grpbPalletTransfer, "isValid")) isValid = false;
            
            return isValid;
        }
        private void frmPalletCoilRequest_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < lstOriginCellar.Count; i++)
                cmbOriginCellar.Items.Add(lstOriginCellar[i]);

            for (int i = 0; i < lstDestinationCellar.Count; i++)
                cmbDestinationCellar.Items.Add(lstDestinationCellar[i]);


        }

        private void cmbOriginCellar_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPalletsAndCoilGrid();
        }

        private void dgvPallets_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataGridSender = "pallet";
                this.dgvPallets.DoDragDrop(this.dgvPallets.CurrentRow, DragDropEffects.All);                
            }
        }
        private void dgvTransferListPallet_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dataGridSender = "coil";
                this.dgvCoils.DoDragDrop(this.dgvCoils.CurrentRow, DragDropEffects.All);
            }
        }
        private void dgvTransferListPallet_DragDrop(object sender, DragEventArgs e)
        {
            if (dataGridSender == "pallet")
            {
                if (e.Effect == DragDropEffects.Move)
                {

                    DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;

                    dgvTransferListPallet.Rows.Add();
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestCodsec.Index].Value = rowToMove.Cells[clmPalletCodsec.Index].Value;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestType.Index].Value = (dataGridSender == "pallet") ? global::BPS.Properties.Resources.pallet : global::BPS.Properties.Resources.coils;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestTypeName.Index].Value = dataGridSender;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestCode.Index].Value = rowToMove.Cells[clmPalletCode.Index].Value;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestCellar.Index].Value = cmbOriginCellar.Text;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestRemove.Index].Value = global::BPS.Properties.Resources.cross;

                }
            }
            else
            {
                if (e.Effect == DragDropEffects.Move)
                {

                    DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;

                    dgvTransferListPallet.Rows.Add();
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestCodsec.Index].Value = rowToMove.Cells[clmCodsec.Index].Value;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestType.Index].Value = (dataGridSender == "pallet") ? global::BPS.Properties.Resources.pallet : global::BPS.Properties.Resources.coils;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestTypeName.Index].Value = dataGridSender;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestCode.Index].Value = rowToMove.Cells[clmCode.Index].Value;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestCellar.Index].Value = cmbOriginCellar.Text;
                    dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmRequestRemove.Index].Value = global::BPS.Properties.Resources.cross;

                }
            }
                
        }

        private void dgvTransferListPallet_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void btnCancelTransferPallet_Click(object sender, EventArgs e)
        {
            cmbDestinationCellar.SelectedIndex = -1;
            dgvTransferListPallet.Rows.Clear();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (validateFormRequest())
            {
                clsPalletCoilTransfer objTransfer = new clsPalletCoilTransfer();
                objTransfer.fkOriginCellar = ((clsCoilCellar)cmbOriginCellar.SelectedItem).codsec;
                objTransfer.fkDestinationCellar = ((clsCoilCellar)cmbDestinationCellar.SelectedItem).codsec;
                objTransfer.userSender = clsGlobal.LoggedUser.codsec;
                objTransfer.transferDate = DateTime.Now;
                objTransfer.isRequest = true;

                for (int i = 0; i < dgvTransferListPallet.Rows.Count; i++)
                {
                    if (dgvTransferListPallet.Rows[i].Cells[clmRequestTypeName.Index].Value.ToString() == "pallet")
                    {
                        objTransfer.lstPallets.Add(new clsPallet(Convert.ToInt32(dgvTransferListPallet.Rows[i].Cells[clmRequestCodsec.Index].Value)));
                    }
                    else
                    {
                        objTransfer.lstCoils.Add(new clsCoil(Convert.ToInt32(dgvTransferListPallet.Rows[i].Cells[clmRequestCodsec.Index].Value)));
                    }
                }

                if (objTransfer.save())
                {
                    MessageBox.Show("La requisición se ha guardado con éxito y se completará el momento en que se realice el despacho de la misma.", "Solicitud de pallets - bobinas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    dgvTransferListPallet.Rows.Clear();
                    cmbDestinationCellar.SelectedIndex = -1;
                }
                else
                    MessageBox.Show("La requisición No se ha podido realizar por favor verifique los datos.", "Solicitud de pallets - bobinas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

        }

        private void cmbOriginCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCoilCellar> lstOriginCellar = clsCoilCellar.getStockCellarList();
                cmbOriginCellar.Items.Clear();
                for (int i = 0; i < lstOriginCellar.Count; i++)
                    cmbOriginCellar.Items.Add(lstOriginCellar[i]); 
            }
        }

        private void cmbDestinationCellar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                lstDestinationCellar = clsCoilCellar.getMetallizedBaseCellarList();
                cmbDestinationCellar.Items.Clear();
                for (int i = 0; i < lstDestinationCellar.Count; i++)
                    cmbDestinationCellar.Items.Add(lstDestinationCellar[i]); 
            }
        }
    }
}
