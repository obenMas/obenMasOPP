using System;
using System.Collections.Generic;
using System.Windows.Forms; 
using BPS.Bussiness;

namespace BPS
{
    public partial class frmCoilPalletsCellar : Form
    {
        clsCoilCellar objCoilCellar = new clsCoilCellar();
        List<clsPallet> lstPallets = new List<clsPallet>();
        List<clsCoil> lstCoil = new List<clsCoil>();

        public frmCoilPalletsCellar()
        {
            InitializeComponent();
        }
        public frmCoilPalletsCellar(int cellarCodsec)
        {
            objCoilCellar.load(cellarCodsec);
            InitializeComponent();
        }
        public bool validateFormTransferPallet()
        {
            bool isValid = true;

            if (!clsValidation.validateField(ref cmbCellarPallets, ref lblCellarPallets, "selected")) isValid = false;
            if (!clsValidation.validateField(ref dgvTransferListPallet, ref grpbTransferListPallets, "isValid")) isValid = false;

            return isValid;
        }
        private void loadPalletsGrid()
        {
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (cmbProduct.SelectedIndex >= 0)
            {
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "plt_fkProduct";
                lstFilter[lstFilter.Count - 1].operation = "equal";
                lstFilter[lstFilter.Count - 1].value = ((clsProduct)cmbProduct.SelectedItem).codsec.ToString();
                lstFilter[lstFilter.Count - 1].dataType = "int";
            }
            if (cmbCustomer.SelectedIndex >= 0)
            {
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "plt_fkEntity";
                lstFilter[lstFilter.Count - 1].operation = "equal";
                lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbCustomer.SelectedItem).codsec.ToString();
                lstFilter[lstFilter.Count - 1].dataType = "int";
            }
            if (cmbSalesOrder.SelectedIndex >= 0)
            {
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "plt_fkSalesOrder";
                lstFilter[lstFilter.Count - 1].operation = "equal";
                lstFilter[lstFilter.Count - 1].value = ((clsSalesOrder)cmbSalesOrder.SelectedItem).codsec.ToString();
                lstFilter[lstFilter.Count - 1].dataType = "int";
            }

            lstPallets = clsPallet.getListByCoilCellarAndFilters(objCoilCellar.codsec, lstFilter);
            
            dgvPallets.Rows.Clear();

            for (int i = 0; i < lstPallets.Count; i++)
            {
                dgvPallets.Rows.Add();
                if (lstPallets[i].statusName == "Activo")
                    dgvPallets.Rows[i].Cells[clmPalletStatusImage.Index].Value = global::BPS.Properties.Resources.accept;
                else
                    dgvPallets.Rows[i].Cells[clmPalletStatusImage.Index].Value = global::BPS.Properties.Resources.arrow_right_orange;
                
                dgvPallets.Rows[i].Cells[clmPalletCodsec.Index].Value = lstPallets[i].codsec;
                dgvPallets.Rows[i].Cells[clmPalletCode.Index].Value = lstPallets[i].code;
                dgvPallets.Rows[i].Cells[clmPalletCoilsNumber.Index].Value = lstPallets[i].palletNumber.ToString() + " - " + lstPallets[i].palletType.coilNumber.ToString();
                dgvPallets.Rows[i].Cells[clmPalletSalesOrderNumber.Index].Value = lstPallets[i].salesOrderNumber;
                dgvPallets.Rows[i].Cells[clmPalletWidth.Index].Value = lstPallets[i].product.width;
                dgvPallets.Rows[i].Cells[clmPalletWeigth.Index].Value = Math.Round(lstPallets[i].netWeight, 1);   
                dgvPallets.Rows[i].Cells[clmPalletCustomer.Index].Value = lstPallets[i].customerName;
                dgvPallets.Rows[i].Cells[clmPalletProduct.Index].Value = lstPallets[i].product.code;             
            }
        }
        private void loadCoilsGrid()
        {
            List<clsFilter> lstFilter = new List<clsFilter>();

            if (cmbProduct.SelectedIndex >= 0)
            {

                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "coil_fkProduct";
                lstFilter[lstFilter.Count - 1].operation = "equal";
                lstFilter[lstFilter.Count - 1].value = ((clsProduct)cmbProductCoil.SelectedItem).codsec.ToString();
                lstFilter[lstFilter.Count - 1].dataType = "int";
            }
            if (cmbCustomer.SelectedIndex >= 0)
            {
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "coil_fkEntity";
                lstFilter[lstFilter.Count - 1].operation = "equal";
                lstFilter[lstFilter.Count - 1].value = ((clsEntity)cmbCustomerCoil.SelectedItem).codsec.ToString();
                lstFilter[lstFilter.Count - 1].dataType = "int";
            }
            if (cmbSalesOrder.SelectedIndex >= 0)
            {
                lstFilter.Add(new clsFilter());
                lstFilter[lstFilter.Count - 1].field = "coil_fkSalesOrder";
                lstFilter[lstFilter.Count - 1].operation = "equal";
                lstFilter[lstFilter.Count - 1].value = ((clsSalesOrder)cmbSalesOrderCoil.SelectedItem).codsec.ToString();
                lstFilter[lstFilter.Count - 1].dataType = "int";
            }

            lstCoil = clsCoil.getCoilOutOfPalletsListByCoilCellarAndFilters(objCoilCellar.codsec, lstFilter);

            dgvCoils.Rows.Clear();

            for (int i = 0; i < lstCoil.Count; i++)
            {
                dgvCoils.Rows.Add();
                dgvCoils.Rows[i].Cells[clmCodsec.Index].Value = lstCoil[i].codsec;
                dgvCoils.Rows[i].Cells[clmCode.Index].Value = lstCoil[i].code;
                dgvCoils.Rows[i].Cells[clmCustomer.Index].Value = lstCoil[i].customerName;
                dgvCoils.Rows[i].Cells[clmCoilSalesOrder.Index].Value = lstCoil[i].salesOrderNumber;
                dgvCoils.Rows[i].Cells[clmProductName.Index].Value = lstCoil[i].ProductCode;
                dgvCoils.Rows[i].Cells[clmWidth.Index].Value = lstCoil[i].width;
                dgvCoils.Rows[i].Cells[clmWeigth.Index].Value = lstCoil[i].netWeight;
            }
        }
        private void loadIncomingTranfers()
        {
            List<clsPalletCoilTransfer> lstIncomingTransfer = clsPalletCoilTransfer.getIncomingTransferList(objCoilCellar.codsec, chkShowAllIncoming.Checked);

            dgvIncomingTransfer.Rows.Clear();

            for (int i = 0; i < lstIncomingTransfer.Count; i++)
            {
                dgvIncomingTransfer.Rows.Add();
                dgvIncomingTransfer.Rows[i].Cells[clmITcodsec.Index].Value = lstIncomingTransfer[i].codsec;
                dgvIncomingTransfer.Rows[i].Cells[clmITOriginCellar.Index].Value = lstIncomingTransfer[i].originCellarName;
                dgvIncomingTransfer.Rows[i].Cells[clmITTranferDate.Index].Value = lstIncomingTransfer[i].transferDate.ToString("dd/MM/yy HH:mm");
                dgvIncomingTransfer.Rows[i].Cells[clmITReceptionDate.Index].Value = lstIncomingTransfer[i].receptionDate.ToString("dd/MM/yy HH:mm");
                dgvIncomingTransfer.Rows[i].Cells[clmITStatus.Index].Value = lstIncomingTransfer[i].statusName;
                dgvIncomingTransfer.Rows[i].Cells[clmITActions.Index].Value = global::BPS.Properties.Resources.arrow_incoming;
            }
            dgvITDCoils.Rows.Clear();
            dgvITDPallets.Rows.Clear();
        }
        private void loadOutgoingTranfers()
        {
            List<clsPalletCoilTransfer> lstOutgoingTransfer = clsPalletCoilTransfer.getOutgoingTransferList(objCoilCellar.codsec, chkShowAllIncoming.Checked);

            dgvOutgoingTransfer.Rows.Clear();

            for (int i = 0; i < lstOutgoingTransfer.Count; i++)
            {
                dgvOutgoingTransfer.Rows.Add();
                dgvOutgoingTransfer.Rows[i].Cells[clmOTcodsec.Index].Value = lstOutgoingTransfer[i].codsec;
                dgvOutgoingTransfer.Rows[i].Cells[clmOTDestinationCellar.Index].Value = lstOutgoingTransfer[i].destinationCellarName;
                dgvOutgoingTransfer.Rows[i].Cells[clmOTTransferDate.Index].Value = lstOutgoingTransfer[i].transferDate.ToString("dd/MM/yy HH:mm");
                dgvOutgoingTransfer.Rows[i].Cells[clmOTReceptionDate.Index].Value = lstOutgoingTransfer[i].receptionDate.ToString("dd/MM/yy HH:mm");
                dgvOutgoingTransfer.Rows[i].Cells[clmOTStatus.Index].Value = lstOutgoingTransfer[i].statusName;
                dgvOutgoingTransfer.Rows[i].Cells[clmOTActions.Index].Value = global::BPS.Properties.Resources.cross;
            }
            dgvOTDCoils.Rows.Clear();
            dgvOTDPallets.Rows.Clear();
        }
        private void loadIncomingRequest()
        {
            List<clsPalletCoilTransfer> lstIncomingRequest = clsPalletCoilTransfer.getIncomingRequest(objCoilCellar.codsec, chkShowAllIncoming.Checked);

            dgvIncomingTransfer.Rows.Clear();

            for (int i = 0; i < lstIncomingRequest.Count; i++)
            {
                dgvIncomingRequest.Rows.Add();
                dgvIncomingRequest.Rows[i].Cells[clmITcodsec.Index].Value = lstIncomingRequest[i].codsec;
                dgvIncomingRequest.Rows[i].Cells[clmITOriginCellar.Index].Value = lstIncomingRequest[i].originCellarName;
                dgvIncomingRequest.Rows[i].Cells[clmITTranferDate.Index].Value = lstIncomingRequest[i].transferDate.ToString("dd/MM/yy HH:mm");
                dgvIncomingRequest.Rows[i].Cells[clmITReceptionDate.Index].Value = lstIncomingRequest[i].receptionDate.ToString("dd/MM/yy HH:mm");
                dgvIncomingRequest.Rows[i].Cells[clmITStatus.Index].Value = lstIncomingRequest[i].statusName;
                dgvIncomingRequest.Rows[i].Cells[clmITActions.Index].Value = global::BPS.Properties.Resources.arrow_incoming;
            }
            dgvITDCoils.Rows.Clear();
            dgvITDPallets.Rows.Clear();
        }

        private void loadOutgoingRequest()
        {
            List<clsPalletCoilTransfer> lstOutgoingRequest = clsPalletCoilTransfer.getOutgoingRequestList(objCoilCellar.codsec, chkShowAllIncoming.Checked);

            dgvOutgoingTransfer.Rows.Clear();

            for (int i = 0; i < lstOutgoingRequest.Count; i++)
            {
                dgvOutgoingRequest.Rows.Add();
                dgvOutgoingRequest.Rows[i].Cells[clmOTcodsec.Index].Value = lstOutgoingRequest[i].codsec;
                dgvOutgoingRequest.Rows[i].Cells[clmOTDestinationCellar.Index].Value = lstOutgoingRequest[i].destinationCellarName;
                dgvOutgoingRequest.Rows[i].Cells[clmOTTransferDate.Index].Value = lstOutgoingRequest[i].transferDate.ToString("dd/MM/yy HH:mm");
                dgvOutgoingRequest.Rows[i].Cells[clmOTReceptionDate.Index].Value = lstOutgoingRequest[i].receptionDate.ToString("dd/MM/yy HH:mm");
                dgvOutgoingRequest.Rows[i].Cells[clmOTStatus.Index].Value = lstOutgoingRequest[i].statusName;
                dgvOutgoingRequest.Rows[i].Cells[clmOTActions.Index].Value = global::BPS.Properties.Resources.cross;
            }
            dgvORDCoils.Rows.Clear();
            dgvORDPallets.Rows.Clear();
        }
        private void frmCoilPalletsCellar_Load(object sender, EventArgs e)
        {
            List<clsProduct> lstProduct = clsProduct.getBoppProductList();
            List<clsEntity> lstCustomer = clsEntity.getCustomerList();
            List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getList();
            List<clsCoilCellar> lstCellar = clsCoilCellar.getList();


            loadPalletsGrid();
            //loadIncomingTranfers();
            //loadOutgoingTranfers();
            //loadIncomingRequest();
            //loadOutgoingRequest();


            if (dgvIncomingTransfer.Rows.Count > 0)
            {
                MessageBox.Show("Existen " + dgvIncomingTransfer.Rows.Count.ToString() + " transferencia(s) entrantes para esta bodega.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                tbcLists.SelectedIndex = 2;
            }

            for (int i = 0; i < lstProduct.Count; i++)
            {
                cmbProduct.Items.Add(lstProduct[i]);
                cmbProductCoil.Items.Add(lstProduct[i]);
            }

            for (int i = 0; i < lstCustomer.Count; i++)
            {
                cmbCustomer.Items.Add(lstCustomer[i]);
                cmbCustomerCoil.Items.Add(lstCustomer[i]);
            }

            for (int i = 0; i < lstSalesOrder.Count; i++)
            {
                cmbSalesOrder.Items.Add(lstSalesOrder[i]);
                cmbSalesOrderCoil.Items.Add(lstSalesOrder[i]);
            }

            for (int i = 0; i < lstCellar.Count; i++)
            {
                cmbCellarCoil.Items.Add(lstCellar[i]);
                cmbCellarPallets.Items.Add(lstCellar[i]);
            }

            this.Text = "Bodega de " + objCoilCellar.name;
        }

        private void chkTransferPallet_CheckedChanged(object sender, EventArgs e)
        {
            grpbTransferListPallets.Enabled = chkTransferPallet.Checked;
            if (chkTransferPallet.Checked == false)
            {
                chkValidationRequiredPallet.Checked = false;
                dgvTransferListPallet.Rows.Clear();
                cmbCellarPallets.SelectedIndex = -1;
                txtPalletCode.Text = "";
            }
        }

        private void dgvPallets_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.dgvPallets.DoDragDrop(this.dgvPallets.CurrentRow, DragDropEffects.All);
            }
        }

        private void dgvTransferListPallet_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect == DragDropEffects.Move)
            {

                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow; 
                
                dgvTransferListPallet.Rows.Add();
                dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmPalletTransterCodsec.Index].Value = rowToMove.Cells[clmPalletCodsec.Index].Value;
                dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmPalletTransferCode.Index].Value = rowToMove.Cells[clmPalletCode.Index].Value;
                dgvTransferListPallet.Rows[dgvTransferListPallet.Rows.Count - 1].Cells[clmPalletTransferDelete.Index].Value = global::BPS.Properties.Resources.cross;

                dgvPallets.SelectedRows[0].Cells[clmPalletStatusImage.Index].Value = global::BPS.Properties.Resources.arrow_curve;
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
            cmbCellarPallets.SelectedIndex = -1;
            txtPalletCode.Text = "";
            dgvTransferListPallet.Rows.Clear();
        }

        private void btnFilters_Click(object sender, EventArgs e)
        {
            loadPalletsGrid();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbCustomer.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;
            cmbSalesOrder.SelectedIndex = -1;

            loadPalletsGrid();
        }

        private void btnTransferPallet_Click(object sender, EventArgs e)
        {
            if (validateFormTransferPallet())
            {
                if (chkValidationRequiredPallet.Checked == true)
                {
                    clsPalletCoilTransfer objTransfer = new clsPalletCoilTransfer();
                    objTransfer.fkOriginCellar = objCoilCellar.codsec;
                    objTransfer.fkDestinationCellar = ((clsCoilCellar)cmbCellarPallets.SelectedItem).codsec;
                    objTransfer.userSender = clsGlobal.LoggedUser.codsec;
                    objTransfer.transferDate = DateTime.Now;

                    for (int i = 0; i < dgvTransferListPallet.Rows.Count; i++)
                        objTransfer.lstPallets.Add(new clsPallet(Convert.ToInt32(dgvTransferListPallet.Rows[i].Cells[clmPalletTransterCodsec.Index].Value)));

                    if (objTransfer.save())
                    {
                        MessageBox.Show("La transferencia se ha guardado con éxito y se completará el momento en que se realice la recepción.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                        chkValidationRequiredPallet.Checked = false;
                        dgvTransferListPallet.Rows.Clear();
                        cmbCellarPallets.SelectedIndex = -1;
                        txtPalletCode.Text = "";
                    }
                    else
                        MessageBox.Show("La transferencia No se ha podido realizar por favor verifique los datos.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                }
                else
                {
                    for (int i = 0; i < dgvTransferListPallet.Rows.Count; i++)
                        clsPallet.transferTo(Convert.ToInt32(dgvTransferListPallet.Rows[i].Cells[clmPalletTransterCodsec.Index].Value), ((clsCoilCellar)cmbCellarPallets.SelectedItem).codsec);

                    MessageBox.Show("La transferencia se ha ejecutado con éxito.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);

                    chkValidationRequiredPallet.Checked = false;
                    dgvTransferListPallet.Rows.Clear();
                    cmbCellarPallets.SelectedIndex = -1;
                    txtPalletCode.Text = "";
                }

                loadPalletsGrid();
                loadIncomingTranfers();
                loadOutgoingTranfers();
                loadIncomingRequest();
                loadOutgoingRequest();
            }
            else
                MessageBox.Show("La información proporcionada para la transferencia esta incompleta, por favor verifique que los campos requeridos estan completos.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
        }

        private void dgvIncomingTransfer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsPalletCoilTransfer objPalletCoilTransfer = new clsPalletCoilTransfer(Convert.ToInt32(dgvIncomingTransfer.Rows[e.RowIndex].Cells[clmITcodsec.Index].Value));

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

            if (e.ColumnIndex == clmITActions.Index)
            {
                frmPalletCoilTransferForm winPalletCoilTransferForm = new frmPalletCoilTransferForm(Convert.ToInt32(dgvIncomingTransfer.Rows[e.RowIndex].Cells[clmITcodsec.Index].Value));
                winPalletCoilTransferForm.ShowInTaskbar = false;
                winPalletCoilTransferForm.ShowDialog(this);

                loadPalletsGrid();
                loadIncomingTranfers();
                loadOutgoingTranfers();
                loadIncomingRequest();
                loadOutgoingRequest();
            }
        }

        private void dgvOutgoingTransfer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsPalletCoilTransfer objPalletCoilTransfer = new clsPalletCoilTransfer(Convert.ToInt32(dgvOutgoingTransfer.Rows[e.RowIndex].Cells[clmOTcodsec.Index].Value));

            dgvOTDPallets.Rows.Clear();

            for (int i = 0; i < objPalletCoilTransfer.lstPallets.Count; i++)
            {
                dgvOTDPallets.Rows.Add();
                dgvOTDPallets.Rows[i].Cells[clmOTDPCodsec.Index].Value = objPalletCoilTransfer.lstPallets[i].codsec;
                dgvOTDPallets.Rows[i].Cells[clmOTDPCode.Index].Value = objPalletCoilTransfer.lstPallets[i].code;
                dgvOTDPallets.Rows[i].Cells[clmOTDPCustomer.Index].Value = objPalletCoilTransfer.lstPallets[i].customerName;
                dgvOTDPallets.Rows[i].Cells[clmOTDPSalesOrderNumber.Index].Value = objPalletCoilTransfer.lstPallets[i].salesOrderNumber;
                dgvOTDPallets.Rows[i].Cells[clmOTDPProduct.Index].Value = objPalletCoilTransfer.lstPallets[i].product.code;
                dgvOTDPallets.Rows[i].Cells[clmOTDPCoils.Index].Value = objPalletCoilTransfer.lstPallets[i].palletType.coilNumber;
            }

            dgvOTDCoils.Rows.Clear();

            for (int i = 0; i < objPalletCoilTransfer.lstCoils.Count; i++)
            {
                dgvOTDCoils.Rows.Add();
                dgvOTDCoils.Rows[i].Cells[clmOTDCCodsec.Index].Value = objPalletCoilTransfer.lstCoils[i].codsec;
                dgvOTDCoils.Rows[i].Cells[clmOTDCCode.Index].Value = objPalletCoilTransfer.lstCoils[i].code;
                dgvOTDCoils.Rows[i].Cells[clmOTDCCustomer.Index].Value = objPalletCoilTransfer.lstCoils[i].customerName;
                dgvOTDCoils.Rows[i].Cells[clmOTDCSalesOrderNumber.Index].Value = objPalletCoilTransfer.lstCoils[i].salesOrderNumber;
                dgvOTDCoils.Rows[i].Cells[clmOTDCProduct.Index].Value = objPalletCoilTransfer.lstPallets[i].product.code;
            }

            if (e.ColumnIndex == clmOTActions.Index)
            {
                if (MessageBox.Show("Esta seguro que desea cancelar la transferencia?", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objPalletCoilTransfer.cancelTransfer();

                    loadPalletsGrid();
                    loadIncomingTranfers();
                    loadOutgoingTranfers();
                    loadIncomingRequest();
                    loadOutgoingRequest();
                }
            }
        }

        private void btnIncomingRefresh_Click(object sender, EventArgs e)
        {
            loadIncomingTranfers();
            if (dgvIncomingTransfer.Rows.Count > 0)
                MessageBox.Show("Existen " + dgvIncomingTransfer.Rows.Count.ToString() + " transferencia(s) entrantes para esta bodega.", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
             
        }

        private void btnOutgoingRefresh_Click(object sender, EventArgs e)
        {
            loadOutgoingTranfers();
        }

        private void dgvTransferListPallet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == clmPalletTransferDelete.Index)
            {
                dgvTransferListPallet.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void dgvIncomingRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsPalletCoilTransfer objPalletCoilRequest = new clsPalletCoilTransfer(Convert.ToInt32(dgvIncomingRequest.Rows[e.RowIndex].Cells[clmITcodsec.Index].Value));

            dgvIRDPallets.Rows.Clear();

            for (int i = 0; i < objPalletCoilRequest.lstPallets.Count; i++)
            {
                dgvIRDPallets.Rows.Add();
                dgvIRDPallets.Rows[i].Cells[clmITDPCodsec.Index].Value = objPalletCoilRequest.lstPallets[i].codsec;
                dgvIRDPallets.Rows[i].Cells[clmITDPCode.Index].Value = objPalletCoilRequest.lstPallets[i].code;
                dgvIRDPallets.Rows[i].Cells[clmITDPCustomer.Index].Value = objPalletCoilRequest.lstPallets[i].customerName;
                dgvIRDPallets.Rows[i].Cells[clmITDPSalesOrderNumber.Index].Value = objPalletCoilRequest.lstPallets[i].salesOrderNumber;
                dgvIRDPallets.Rows[i].Cells[clmITDPProduct.Index].Value = objPalletCoilRequest.lstPallets[i].product.code;
                dgvIRDPallets.Rows[i].Cells[clmITDPCoils.Index].Value = objPalletCoilRequest.lstPallets[i].palletType.coilNumber;
            }

            dgvIRDCoils.Rows.Clear();

            for (int i = 0; i < objPalletCoilRequest.lstCoils.Count; i++)
            {
                dgvIRDCoils.Rows.Add();
                dgvIRDCoils.Rows[i].Cells[clmITDCCodsec.Index].Value = objPalletCoilRequest.lstCoils[i].codsec;
                dgvIRDCoils.Rows[i].Cells[clmITDCCode.Index].Value = objPalletCoilRequest.lstCoils[i].code;
                dgvIRDCoils.Rows[i].Cells[clmITDCCustomer.Index].Value = objPalletCoilRequest.lstCoils[i].customerName;
                dgvIRDCoils.Rows[i].Cells[clmITDCSalesOrderNumber.Index].Value = objPalletCoilRequest.lstCoils[i].salesOrderNumber;
                dgvIRDCoils.Rows[i].Cells[clmITDCProduct.Index].Value = objPalletCoilRequest.lstPallets[i].product.code;
            }

            if (e.ColumnIndex == clmITActions.Index)
            {
                frmPalletCoilTransferForm winPalletCoilTransferForm = new frmPalletCoilTransferForm(Convert.ToInt32(dgvIncomingRequest.Rows[e.RowIndex].Cells[clmITcodsec.Index].Value));
                winPalletCoilTransferForm.ShowInTaskbar = false;
                winPalletCoilTransferForm.ShowDialog(this);

                loadPalletsGrid();
                loadIncomingTranfers();
                loadOutgoingTranfers();
                loadIncomingRequest();
                loadOutgoingRequest();
            }
        }

        private void dgvOutgoingRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clsPalletCoilTransfer objPalletCoilTransfer = new clsPalletCoilTransfer(Convert.ToInt32(dgvOutgoingRequest.Rows[e.RowIndex].Cells[clmOTcodsec.Index].Value));

            dgvORDPallets.Rows.Clear();

            for (int i = 0; i < objPalletCoilTransfer.lstPallets.Count; i++)
            {
                dgvORDPallets.Rows.Add();
                dgvORDPallets.Rows[i].Cells[clmOTDPCodsec.Index].Value = objPalletCoilTransfer.lstPallets[i].codsec;
                dgvORDPallets.Rows[i].Cells[clmOTDPCode.Index].Value = objPalletCoilTransfer.lstPallets[i].code;
                dgvORDPallets.Rows[i].Cells[clmOTDPCustomer.Index].Value = objPalletCoilTransfer.lstPallets[i].customerName;
                dgvORDPallets.Rows[i].Cells[clmOTDPSalesOrderNumber.Index].Value = objPalletCoilTransfer.lstPallets[i].salesOrderNumber;
                dgvORDPallets.Rows[i].Cells[clmOTDPProduct.Index].Value = objPalletCoilTransfer.lstPallets[i].product.code;
                dgvORDPallets.Rows[i].Cells[clmOTDPCoils.Index].Value = objPalletCoilTransfer.lstPallets[i].palletType.coilNumber;
            }

            dgvORDCoils.Rows.Clear();

            for (int i = 0; i < objPalletCoilTransfer.lstCoils.Count; i++)
            {
                dgvORDCoils.Rows.Add();
                dgvORDCoils.Rows[i].Cells[clmOTDCCodsec.Index].Value = objPalletCoilTransfer.lstCoils[i].codsec;
                dgvOTDCoils.Rows[i].Cells[clmOTDCCode.Index].Value = objPalletCoilTransfer.lstCoils[i].code;
                dgvOTDCoils.Rows[i].Cells[clmOTDCCustomer.Index].Value = objPalletCoilTransfer.lstCoils[i].customerName;
                dgvOTDCoils.Rows[i].Cells[clmOTDCSalesOrderNumber.Index].Value = objPalletCoilTransfer.lstCoils[i].salesOrderNumber;
                dgvOTDCoils.Rows[i].Cells[clmOTDCProduct.Index].Value = objPalletCoilTransfer.lstPallets[i].product.code;
            }

            if (e.ColumnIndex == clmOTActions.Index)
            {
                if (MessageBox.Show("Esta seguro que desea cancelar la transferencia?", "Transferencia de Pallets entre Bodegas", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) == DialogResult.Yes)
                {
                    objPalletCoilTransfer.cancelTransfer();

                    loadPalletsGrid();
                    loadIncomingTranfers();
                    loadOutgoingTranfers();
                    loadIncomingRequest();
                    loadOutgoingRequest();
                }
            }
        }

        private void cmbProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsProduct> lstProduct = clsProduct.getBoppProductList();
                for (int i = 0; i < lstProduct.Count; i++)
                    cmbProduct.Items.Add(lstProduct[i]);
            }
        }

        private void cmbCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsEntity> lstCustomer = clsEntity.getCustomerList();
                for (int i = 0; i < lstCustomer.Count; i++)
                    cmbCustomer.Items.Add(lstCustomer[i]);
            }
        }

        private void cmbSalesOrder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getList();
                for (int i = 0; i < lstSalesOrder.Count; i++)
                    cmbSalesOrder.Items.Add(lstSalesOrder[i]);
            }
        }

        private void cmbCellarPallets_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsCoilCellar> lstCellar = clsCoilCellar.getList();
                for (int i = 0; i < lstCellar.Count; i++)
                    cmbCellarPallets.Items.Add(lstCellar[i]);
            }
        }

        private void cmbProductCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsProduct> lstProduct = clsProduct.getBoppProductList();
                for (int i = 0; i < lstProduct.Count; i++)
                    cmbProductCoil.Items.Add(lstProduct[i]);
            }
        }

        private void cmbCustomerCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsEntity> lstCustomer = clsEntity.getCustomerList();
                for (int i = 0; i < lstCustomer.Count; i++)
                    cmbCustomerCoil.Items.Add(lstCustomer[i]);
            }
        }

        private void cmbSalesOrderCoil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                List<clsSalesOrder> lstSalesOrder = clsSalesOrder.getList();
                for (int i = 0; i < lstSalesOrder.Count; i++)
                    cmbSalesOrderCoil.Items.Add(lstSalesOrder[i]);
            }
        }
    }
}