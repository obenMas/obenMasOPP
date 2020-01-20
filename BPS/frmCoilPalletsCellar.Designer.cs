namespace BPS
{
    partial class frmCoilPalletsCellar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilPalletsCellar));
            this.tbcLists = new System.Windows.Forms.TabControl();
            this.tbpPallets = new System.Windows.Forms.TabPage();
            this.grpbPalletTransfer = new System.Windows.Forms.GroupBox();
            this.grpbTransferListPallets = new System.Windows.Forms.GroupBox();
            this.chkValidationRequiredPallet = new System.Windows.Forms.CheckBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.cmbCellarPallets = new System.Windows.Forms.ComboBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.lblCellarPallets = new System.Windows.Forms.Label();
            this.dgvTransferListPallet = new System.Windows.Forms.DataGridView();
            this.clmPalletTransterCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTransferCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTransferDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbTransferActionsPallet = new System.Windows.Forms.GroupBox();
            this.btnCancelTransferPallet = new System.Windows.Forms.Button();
            this.btnTransferPallet = new System.Windows.Forms.Button();
            this.chkTransferPallet = new System.Windows.Forms.CheckBox();
            this.grpbPalletList = new System.Windows.Forms.GroupBox();
            this.dgvPallets = new System.Windows.Forms.DataGridView();
            this.grpbPalletListFilters = new System.Windows.Forms.GroupBox();
            this.cmbSalesOrder = new System.Windows.Forms.ComboBox();
            this.lblSalesOrderPallet = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.grpbPalletFiltersBar = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnFilters = new System.Windows.Forms.Button();
            this.tbpCoils = new System.Windows.Forms.TabPage();
            this.grpbCoilTransfer = new System.Windows.Forms.GroupBox();
            this.grpbTransferListCoil = new System.Windows.Forms.GroupBox();
            this.chkValidationRequiredCoils = new System.Windows.Forms.CheckBox();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.cmbCellarCoil = new System.Windows.Forms.ComboBox();
            this.lblCoilCode = new System.Windows.Forms.Label();
            this.lblCellarCoil = new System.Windows.Forms.Label();
            this.dgvTransferListCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilTransterCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilTransterCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilTransterDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbEmptyCoils = new System.Windows.Forms.GroupBox();
            this.grpbTransferActionsCoils = new System.Windows.Forms.GroupBox();
            this.btnCancelTransferCoils = new System.Windows.Forms.Button();
            this.btnTransferCoils = new System.Windows.Forms.Button();
            this.chkTransferCoil = new System.Windows.Forms.CheckBox();
            this.grpbCoilList = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilterCoils = new System.Windows.Forms.GroupBox();
            this.cmbSalesOrderCoil = new System.Windows.Forms.ComboBox();
            this.lblSalesOrderCoil = new System.Windows.Forms.Label();
            this.cmbCustomerCoil = new System.Windows.Forms.ComboBox();
            this.lblCustomerCoil = new System.Windows.Forms.Label();
            this.cmbProductCoil = new System.Windows.Forms.ComboBox();
            this.lblProductCoil = new System.Windows.Forms.Label();
            this.grpbFilterActionsCoil = new System.Windows.Forms.GroupBox();
            this.btnClearFilterCoil = new System.Windows.Forms.Button();
            this.btnFilterCoil = new System.Windows.Forms.Button();
            this.tbpTransfers = new System.Windows.Forms.TabPage();
            this.grpbIncomingTransfers = new System.Windows.Forms.GroupBox();
            this.btnOutgoingRefresh = new System.Windows.Forms.Button();
            this.grpbOutgoingDetail = new System.Windows.Forms.GroupBox();
            this.grpbOTCoilsDetail = new System.Windows.Forms.GroupBox();
            this.dgvOTDCoils = new System.Windows.Forms.DataGridView();
            this.clmOTDCCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDCCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDCSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDCProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbOTPalletsDetail = new System.Windows.Forms.GroupBox();
            this.dgvOTDPallets = new System.Windows.Forms.DataGridView();
            this.clmOTDPCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDPCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDPSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDPProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDPCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picbOutgoing = new System.Windows.Forms.PictureBox();
            this.chkShowAllOutgoing = new System.Windows.Forms.CheckBox();
            this.dgvOutgoingTransfer = new System.Windows.Forms.DataGridView();
            this.clmOTcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTDestinationCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTTransferDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTReceptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOTActions = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbOutgoingTransfers = new System.Windows.Forms.GroupBox();
            this.btnIncomingRefresh = new System.Windows.Forms.Button();
            this.grpbIncomingDetail = new System.Windows.Forms.GroupBox();
            this.grpbITCoilsDetail = new System.Windows.Forms.GroupBox();
            this.dgvITDCoils = new System.Windows.Forms.DataGridView();
            this.clmITDCCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbITPalletsDetail = new System.Windows.Forms.GroupBox();
            this.dgvITDPallets = new System.Windows.Forms.DataGridView();
            this.clmITDPCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkShowAllIncoming = new System.Windows.Forms.CheckBox();
            this.dgvIncomingTransfer = new System.Windows.Forms.DataGridView();
            this.clmITcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITOriginCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITTranferDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITReceptionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITActions = new System.Windows.Forms.DataGridViewImageColumn();
            this.picbIncoming = new System.Windows.Forms.PictureBox();
            this.tbpRequest = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOutgoingRequestRefresh = new System.Windows.Forms.Button();
            this.grpboutgoingRequestDetail = new System.Windows.Forms.GroupBox();
            this.grpbORCoilsDetail = new System.Windows.Forms.GroupBox();
            this.dgvORDCoils = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbORPalletsDetail = new System.Windows.Forms.GroupBox();
            this.dgvORDPallets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picbOutgoingRequest = new System.Windows.Forms.PictureBox();
            this.chkShowAllRequestOutgoing = new System.Windows.Forms.CheckBox();
            this.dgvOutgoingRequest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnIncomingRequestRefresh = new System.Windows.Forms.Button();
            this.grpbIncomingRequestDetail = new System.Windows.Forms.GroupBox();
            this.grpbIRCoilsDetail = new System.Windows.Forms.GroupBox();
            this.dgvIRDCoils = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbIRPalletsDetail = new System.Windows.Forms.GroupBox();
            this.dgvIRDPallets = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkShowAllRequestIncoming = new System.Windows.Forms.CheckBox();
            this.dgvIncomingRequest = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.picbIncomingRequest = new System.Windows.Forms.PictureBox();
            this.ttpCoilPalletsCellar = new System.Windows.Forms.ToolTip(this.components);
            this.clmPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletStatusImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPalletProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCoilsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcLists.SuspendLayout();
            this.tbpPallets.SuspendLayout();
            this.grpbPalletTransfer.SuspendLayout();
            this.grpbTransferListPallets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferListPallet)).BeginInit();
            this.grpbTransferActionsPallet.SuspendLayout();
            this.grpbPalletList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).BeginInit();
            this.grpbPalletListFilters.SuspendLayout();
            this.grpbPalletFiltersBar.SuspendLayout();
            this.tbpCoils.SuspendLayout();
            this.grpbCoilTransfer.SuspendLayout();
            this.grpbTransferListCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferListCoils)).BeginInit();
            this.grpbTransferActionsCoils.SuspendLayout();
            this.grpbCoilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbFilterCoils.SuspendLayout();
            this.grpbFilterActionsCoil.SuspendLayout();
            this.tbpTransfers.SuspendLayout();
            this.grpbIncomingTransfers.SuspendLayout();
            this.grpbOutgoingDetail.SuspendLayout();
            this.grpbOTCoilsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOTDCoils)).BeginInit();
            this.grpbOTPalletsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOTDPallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbOutgoing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutgoingTransfer)).BeginInit();
            this.grpbOutgoingTransfers.SuspendLayout();
            this.grpbIncomingDetail.SuspendLayout();
            this.grpbITCoilsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDCoils)).BeginInit();
            this.grpbITPalletsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDPallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbIncoming)).BeginInit();
            this.tbpRequest.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpboutgoingRequestDetail.SuspendLayout();
            this.grpbORCoilsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDCoils)).BeginInit();
            this.grpbORPalletsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDPallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbOutgoingRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutgoingRequest)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grpbIncomingRequestDetail.SuspendLayout();
            this.grpbIRCoilsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIRDCoils)).BeginInit();
            this.grpbIRPalletsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIRDPallets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbIncomingRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcLists
            // 
            this.tbcLists.Controls.Add(this.tbpPallets);
            this.tbcLists.Controls.Add(this.tbpCoils);
            this.tbcLists.Controls.Add(this.tbpTransfers);
            this.tbcLists.Controls.Add(this.tbpRequest);
            this.tbcLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcLists.Location = new System.Drawing.Point(0, 0);
            this.tbcLists.Name = "tbcLists";
            this.tbcLists.SelectedIndex = 0;
            this.tbcLists.Size = new System.Drawing.Size(1250, 490);
            this.tbcLists.TabIndex = 0;
            // 
            // tbpPallets
            // 
            this.tbpPallets.Controls.Add(this.grpbPalletTransfer);
            this.tbpPallets.Controls.Add(this.grpbPalletList);
            this.tbpPallets.Location = new System.Drawing.Point(4, 24);
            this.tbpPallets.Name = "tbpPallets";
            this.tbpPallets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPallets.Size = new System.Drawing.Size(1242, 462);
            this.tbpPallets.TabIndex = 0;
            this.tbpPallets.Text = "Pallets";
            this.tbpPallets.UseVisualStyleBackColor = true;
            // 
            // grpbPalletTransfer
            // 
            this.grpbPalletTransfer.Controls.Add(this.grpbTransferListPallets);
            this.grpbPalletTransfer.Controls.Add(this.chkTransferPallet);
            this.grpbPalletTransfer.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbPalletTransfer.Location = new System.Drawing.Point(999, 3);
            this.grpbPalletTransfer.Name = "grpbPalletTransfer";
            this.grpbPalletTransfer.Size = new System.Drawing.Size(240, 456);
            this.grpbPalletTransfer.TabIndex = 2;
            this.grpbPalletTransfer.TabStop = false;
            // 
            // grpbTransferListPallets
            // 
            this.grpbTransferListPallets.Controls.Add(this.chkValidationRequiredPallet);
            this.grpbTransferListPallets.Controls.Add(this.txtPalletCode);
            this.grpbTransferListPallets.Controls.Add(this.cmbCellarPallets);
            this.grpbTransferListPallets.Controls.Add(this.lblPalletCode);
            this.grpbTransferListPallets.Controls.Add(this.lblCellarPallets);
            this.grpbTransferListPallets.Controls.Add(this.dgvTransferListPallet);
            this.grpbTransferListPallets.Controls.Add(this.grpbEmpty);
            this.grpbTransferListPallets.Controls.Add(this.grpbTransferActionsPallet);
            this.grpbTransferListPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbTransferListPallets.Enabled = false;
            this.grpbTransferListPallets.Location = new System.Drawing.Point(3, 33);
            this.grpbTransferListPallets.Name = "grpbTransferListPallets";
            this.grpbTransferListPallets.Size = new System.Drawing.Size(234, 420);
            this.grpbTransferListPallets.TabIndex = 1;
            this.grpbTransferListPallets.TabStop = false;
            this.grpbTransferListPallets.Text = "Transferencias";
            // 
            // chkValidationRequiredPallet
            // 
            this.chkValidationRequiredPallet.AutoSize = true;
            this.chkValidationRequiredPallet.Location = new System.Drawing.Point(3, 364);
            this.chkValidationRequiredPallet.Name = "chkValidationRequiredPallet";
            this.chkValidationRequiredPallet.Size = new System.Drawing.Size(133, 17);
            this.chkValidationRequiredPallet.TabIndex = 3;
            this.chkValidationRequiredPallet.Text = "Verificación Requerida";
            this.chkValidationRequiredPallet.UseVisualStyleBackColor = true;
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Location = new System.Drawing.Point(49, 43);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(181, 21);
            this.txtPalletCode.TabIndex = 1;
            // 
            // cmbCellarPallets
            // 
            this.cmbCellarPallets.FormattingEnabled = true;
            this.cmbCellarPallets.Location = new System.Drawing.Point(49, 16);
            this.cmbCellarPallets.Name = "cmbCellarPallets";
            this.cmbCellarPallets.Size = new System.Drawing.Size(181, 23);
            this.cmbCellarPallets.TabIndex = 0;
            this.cmbCellarPallets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCellarPallets_KeyDown);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Location = new System.Drawing.Point(4, 46);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(46, 15);
            this.lblPalletCode.TabIndex = 20;
            this.lblPalletCode.Text = "Código";
            // 
            // lblCellarPallets
            // 
            this.lblCellarPallets.AutoSize = true;
            this.lblCellarPallets.Location = new System.Drawing.Point(4, 19);
            this.lblCellarPallets.Name = "lblCellarPallets";
            this.lblCellarPallets.Size = new System.Drawing.Size(50, 15);
            this.lblCellarPallets.TabIndex = 20;
            this.lblCellarPallets.Text = "Bodega";
            // 
            // dgvTransferListPallet
            // 
            this.dgvTransferListPallet.AllowDrop = true;
            this.dgvTransferListPallet.AllowUserToAddRows = false;
            this.dgvTransferListPallet.AllowUserToDeleteRows = false;
            this.dgvTransferListPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferListPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletTransterCodsec,
            this.clmPalletTransferCode,
            this.clmPalletTransferDelete});
            this.dgvTransferListPallet.Location = new System.Drawing.Point(3, 69);
            this.dgvTransferListPallet.Name = "dgvTransferListPallet";
            this.dgvTransferListPallet.ReadOnly = true;
            this.dgvTransferListPallet.Size = new System.Drawing.Size(228, 292);
            this.dgvTransferListPallet.TabIndex = 2;
            this.dgvTransferListPallet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransferListPallet_CellClick);
            this.dgvTransferListPallet.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvTransferListPallet_DragDrop);
            this.dgvTransferListPallet.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvTransferListPallet_DragEnter);
            // 
            // clmPalletTransterCodsec
            // 
            this.clmPalletTransterCodsec.HeaderText = "codsec";
            this.clmPalletTransterCodsec.Name = "clmPalletTransterCodsec";
            this.clmPalletTransterCodsec.ReadOnly = true;
            this.clmPalletTransterCodsec.Visible = false;
            // 
            // clmPalletTransferCode
            // 
            this.clmPalletTransferCode.HeaderText = "Código";
            this.clmPalletTransferCode.Name = "clmPalletTransferCode";
            this.clmPalletTransferCode.ReadOnly = true;
            this.clmPalletTransferCode.Width = 130;
            // 
            // clmPalletTransferDelete
            // 
            this.clmPalletTransferDelete.HeaderText = "";
            this.clmPalletTransferDelete.Name = "clmPalletTransferDelete";
            this.clmPalletTransferDelete.ReadOnly = true;
            this.clmPalletTransferDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPalletTransferDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmPalletTransferDelete.Width = 30;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(3, 376);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(166, 43);
            this.grpbEmpty.TabIndex = 17;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbTransferActionsPallet
            // 
            this.grpbTransferActionsPallet.Controls.Add(this.btnCancelTransferPallet);
            this.grpbTransferActionsPallet.Controls.Add(this.btnTransferPallet);
            this.grpbTransferActionsPallet.Location = new System.Drawing.Point(171, 376);
            this.grpbTransferActionsPallet.Name = "grpbTransferActionsPallet";
            this.grpbTransferActionsPallet.Size = new System.Drawing.Size(60, 43);
            this.grpbTransferActionsPallet.TabIndex = 4;
            this.grpbTransferActionsPallet.TabStop = false;
            // 
            // btnCancelTransferPallet
            // 
            this.btnCancelTransferPallet.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelTransferPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelTransferPallet.Location = new System.Drawing.Point(6, 13);
            this.btnCancelTransferPallet.Name = "btnCancelTransferPallet";
            this.btnCancelTransferPallet.Size = new System.Drawing.Size(24, 25);
            this.btnCancelTransferPallet.TabIndex = 1;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnCancelTransferPallet, "Cancelar");
            this.btnCancelTransferPallet.UseVisualStyleBackColor = true;
            this.btnCancelTransferPallet.Click += new System.EventHandler(this.btnCancelTransferPallet_Click);
            // 
            // btnTransferPallet
            // 
            this.btnTransferPallet.BackgroundImage = global::BPS.Properties.Resources.arrow_curve;
            this.btnTransferPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransferPallet.Location = new System.Drawing.Point(31, 13);
            this.btnTransferPallet.Name = "btnTransferPallet";
            this.btnTransferPallet.Size = new System.Drawing.Size(24, 25);
            this.btnTransferPallet.TabIndex = 0;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnTransferPallet, "Transferir Pallets");
            this.btnTransferPallet.UseVisualStyleBackColor = true;
            this.btnTransferPallet.Click += new System.EventHandler(this.btnTransferPallet_Click);
            // 
            // chkTransferPallet
            // 
            this.chkTransferPallet.AutoSize = true;
            this.chkTransferPallet.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTransferPallet.Location = new System.Drawing.Point(3, 16);
            this.chkTransferPallet.Name = "chkTransferPallet";
            this.chkTransferPallet.Size = new System.Drawing.Size(234, 17);
            this.chkTransferPallet.TabIndex = 0;
            this.chkTransferPallet.Text = "Habilitar Transferencias";
            this.chkTransferPallet.UseVisualStyleBackColor = true;
            this.chkTransferPallet.CheckedChanged += new System.EventHandler(this.chkTransferPallet_CheckedChanged);
            // 
            // grpbPalletList
            // 
            this.grpbPalletList.Controls.Add(this.dgvPallets);
            this.grpbPalletList.Controls.Add(this.grpbPalletListFilters);
            this.grpbPalletList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbPalletList.Location = new System.Drawing.Point(3, 3);
            this.grpbPalletList.Name = "grpbPalletList";
            this.grpbPalletList.Size = new System.Drawing.Size(990, 456);
            this.grpbPalletList.TabIndex = 0;
            this.grpbPalletList.TabStop = false;
            this.grpbPalletList.Text = "Listado de pallets";
            // 
            // dgvPallets
            // 
            this.dgvPallets.AllowUserToAddRows = false;
            this.dgvPallets.AllowUserToDeleteRows = false;
            this.dgvPallets.AllowUserToOrderColumns = true;
            this.dgvPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletCodsec,
            this.clmPalletStatusImage,
            this.clmPalletProduct,
            this.clmPalletCoilsNumber,
            this.clmPalletSalesOrderNumber,
            this.clmPalletWidth,
            this.clmPalletWeigth,
            this.clmPalletCustomer,
            this.clmPalletCode});
            this.dgvPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPallets.Location = new System.Drawing.Point(3, 82);
            this.dgvPallets.MultiSelect = false;
            this.dgvPallets.Name = "dgvPallets";
            this.dgvPallets.ReadOnly = true;
            this.dgvPallets.RowHeadersWidth = 10;
            this.dgvPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPallets.Size = new System.Drawing.Size(984, 371);
            this.dgvPallets.TabIndex = 1;
            this.dgvPallets.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPallets_MouseMove);
            // 
            // grpbPalletListFilters
            // 
            this.grpbPalletListFilters.Controls.Add(this.cmbSalesOrder);
            this.grpbPalletListFilters.Controls.Add(this.lblSalesOrderPallet);
            this.grpbPalletListFilters.Controls.Add(this.cmbCustomer);
            this.grpbPalletListFilters.Controls.Add(this.lblCustomer);
            this.grpbPalletListFilters.Controls.Add(this.cmbProduct);
            this.grpbPalletListFilters.Controls.Add(this.lblProduct);
            this.grpbPalletListFilters.Controls.Add(this.grpbPalletFiltersBar);
            this.grpbPalletListFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletListFilters.Location = new System.Drawing.Point(3, 17);
            this.grpbPalletListFilters.Name = "grpbPalletListFilters";
            this.grpbPalletListFilters.Size = new System.Drawing.Size(984, 65);
            this.grpbPalletListFilters.TabIndex = 0;
            this.grpbPalletListFilters.TabStop = false;
            this.grpbPalletListFilters.Text = "Filtros";
            // 
            // cmbSalesOrder
            // 
            this.cmbSalesOrder.FormattingEnabled = true;
            this.cmbSalesOrder.Location = new System.Drawing.Point(628, 26);
            this.cmbSalesOrder.Name = "cmbSalesOrder";
            this.cmbSalesOrder.Size = new System.Drawing.Size(285, 23);
            this.cmbSalesOrder.TabIndex = 2;
            this.cmbSalesOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesOrder_KeyDown);
            // 
            // lblSalesOrderPallet
            // 
            this.lblSalesOrderPallet.AutoSize = true;
            this.lblSalesOrderPallet.Location = new System.Drawing.Point(564, 29);
            this.lblSalesOrderPallet.Name = "lblSalesOrderPallet";
            this.lblSalesOrderPallet.Size = new System.Drawing.Size(64, 15);
            this.lblSalesOrderPallet.TabIndex = 7;
            this.lblSalesOrderPallet.Text = "Ord. Venta";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(331, 26);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(218, 23);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(286, 29);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(45, 15);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Cliente";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(62, 26);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(218, 23);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(6, 29);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(56, 15);
            this.lblProduct.TabIndex = 6;
            this.lblProduct.Text = "Producto";
            // 
            // grpbPalletFiltersBar
            // 
            this.grpbPalletFiltersBar.Controls.Add(this.btnClearFilters);
            this.grpbPalletFiltersBar.Controls.Add(this.btnFilters);
            this.grpbPalletFiltersBar.Location = new System.Drawing.Point(919, 10);
            this.grpbPalletFiltersBar.Name = "grpbPalletFiltersBar";
            this.grpbPalletFiltersBar.Size = new System.Drawing.Size(59, 44);
            this.grpbPalletFiltersBar.TabIndex = 3;
            this.grpbPalletFiltersBar.TabStop = false;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(4, 13);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 1;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnFilters
            // 
            this.btnFilters.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilters.Location = new System.Drawing.Point(29, 13);
            this.btnFilters.Name = "btnFilters";
            this.btnFilters.Size = new System.Drawing.Size(25, 25);
            this.btnFilters.TabIndex = 0;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnFilters, "Filtrar");
            this.btnFilters.UseVisualStyleBackColor = true;
            this.btnFilters.Click += new System.EventHandler(this.btnFilters_Click);
            // 
            // tbpCoils
            // 
            this.tbpCoils.Controls.Add(this.grpbCoilTransfer);
            this.tbpCoils.Controls.Add(this.grpbCoilList);
            this.tbpCoils.Location = new System.Drawing.Point(4, 24);
            this.tbpCoils.Name = "tbpCoils";
            this.tbpCoils.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoils.Size = new System.Drawing.Size(1242, 462);
            this.tbpCoils.TabIndex = 1;
            this.tbpCoils.Text = "Bobinas";
            this.tbpCoils.UseVisualStyleBackColor = true;
            // 
            // grpbCoilTransfer
            // 
            this.grpbCoilTransfer.Controls.Add(this.grpbTransferListCoil);
            this.grpbCoilTransfer.Controls.Add(this.chkTransferCoil);
            this.grpbCoilTransfer.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbCoilTransfer.Location = new System.Drawing.Point(999, 3);
            this.grpbCoilTransfer.Name = "grpbCoilTransfer";
            this.grpbCoilTransfer.Size = new System.Drawing.Size(240, 456);
            this.grpbCoilTransfer.TabIndex = 4;
            this.grpbCoilTransfer.TabStop = false;
            // 
            // grpbTransferListCoil
            // 
            this.grpbTransferListCoil.Controls.Add(this.chkValidationRequiredCoils);
            this.grpbTransferListCoil.Controls.Add(this.txtCoilCode);
            this.grpbTransferListCoil.Controls.Add(this.cmbCellarCoil);
            this.grpbTransferListCoil.Controls.Add(this.lblCoilCode);
            this.grpbTransferListCoil.Controls.Add(this.lblCellarCoil);
            this.grpbTransferListCoil.Controls.Add(this.dgvTransferListCoils);
            this.grpbTransferListCoil.Controls.Add(this.grpbEmptyCoils);
            this.grpbTransferListCoil.Controls.Add(this.grpbTransferActionsCoils);
            this.grpbTransferListCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbTransferListCoil.Enabled = false;
            this.grpbTransferListCoil.Location = new System.Drawing.Point(3, 33);
            this.grpbTransferListCoil.Name = "grpbTransferListCoil";
            this.grpbTransferListCoil.Size = new System.Drawing.Size(234, 420);
            this.grpbTransferListCoil.TabIndex = 1;
            this.grpbTransferListCoil.TabStop = false;
            this.grpbTransferListCoil.Text = "Transferencias";
            // 
            // chkValidationRequiredCoils
            // 
            this.chkValidationRequiredCoils.AutoSize = true;
            this.chkValidationRequiredCoils.Location = new System.Drawing.Point(3, 364);
            this.chkValidationRequiredCoils.Name = "chkValidationRequiredCoils";
            this.chkValidationRequiredCoils.Size = new System.Drawing.Size(133, 17);
            this.chkValidationRequiredCoils.TabIndex = 1;
            this.chkValidationRequiredCoils.Text = "Verificación Requerida";
            this.chkValidationRequiredCoils.UseVisualStyleBackColor = true;
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Location = new System.Drawing.Point(49, 43);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(181, 21);
            this.txtCoilCode.TabIndex = 1;
            // 
            // cmbCellarCoil
            // 
            this.cmbCellarCoil.FormattingEnabled = true;
            this.cmbCellarCoil.Location = new System.Drawing.Point(49, 16);
            this.cmbCellarCoil.Name = "cmbCellarCoil";
            this.cmbCellarCoil.Size = new System.Drawing.Size(181, 23);
            this.cmbCellarCoil.TabIndex = 0;
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Location = new System.Drawing.Point(4, 46);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(46, 15);
            this.lblCoilCode.TabIndex = 20;
            this.lblCoilCode.Text = "Código";
            // 
            // lblCellarCoil
            // 
            this.lblCellarCoil.AutoSize = true;
            this.lblCellarCoil.Location = new System.Drawing.Point(4, 19);
            this.lblCellarCoil.Name = "lblCellarCoil";
            this.lblCellarCoil.Size = new System.Drawing.Size(50, 15);
            this.lblCellarCoil.TabIndex = 20;
            this.lblCellarCoil.Text = "Bodega";
            // 
            // dgvTransferListCoils
            // 
            this.dgvTransferListCoils.AllowDrop = true;
            this.dgvTransferListCoils.AllowUserToAddRows = false;
            this.dgvTransferListCoils.AllowUserToDeleteRows = false;
            this.dgvTransferListCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferListCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilTransterCodsec,
            this.clmCoilTransterCode,
            this.clmCoilTransterDelete});
            this.dgvTransferListCoils.Location = new System.Drawing.Point(3, 69);
            this.dgvTransferListCoils.Name = "dgvTransferListCoils";
            this.dgvTransferListCoils.ReadOnly = true;
            this.dgvTransferListCoils.Size = new System.Drawing.Size(228, 292);
            this.dgvTransferListCoils.TabIndex = 2;
            // 
            // clmCoilTransterCodsec
            // 
            this.clmCoilTransterCodsec.HeaderText = "codsec";
            this.clmCoilTransterCodsec.Name = "clmCoilTransterCodsec";
            this.clmCoilTransterCodsec.ReadOnly = true;
            this.clmCoilTransterCodsec.Visible = false;
            // 
            // clmCoilTransterCode
            // 
            this.clmCoilTransterCode.HeaderText = "Código";
            this.clmCoilTransterCode.Name = "clmCoilTransterCode";
            this.clmCoilTransterCode.ReadOnly = true;
            this.clmCoilTransterCode.Width = 130;
            // 
            // clmCoilTransterDelete
            // 
            this.clmCoilTransterDelete.HeaderText = "";
            this.clmCoilTransterDelete.Name = "clmCoilTransterDelete";
            this.clmCoilTransterDelete.ReadOnly = true;
            this.clmCoilTransterDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCoilTransterDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmCoilTransterDelete.Width = 30;
            // 
            // grpbEmptyCoils
            // 
            this.grpbEmptyCoils.Location = new System.Drawing.Point(3, 376);
            this.grpbEmptyCoils.Name = "grpbEmptyCoils";
            this.grpbEmptyCoils.Size = new System.Drawing.Size(166, 43);
            this.grpbEmptyCoils.TabIndex = 17;
            this.grpbEmptyCoils.TabStop = false;
            // 
            // grpbTransferActionsCoils
            // 
            this.grpbTransferActionsCoils.Controls.Add(this.btnCancelTransferCoils);
            this.grpbTransferActionsCoils.Controls.Add(this.btnTransferCoils);
            this.grpbTransferActionsCoils.Location = new System.Drawing.Point(171, 376);
            this.grpbTransferActionsCoils.Name = "grpbTransferActionsCoils";
            this.grpbTransferActionsCoils.Size = new System.Drawing.Size(60, 43);
            this.grpbTransferActionsCoils.TabIndex = 3;
            this.grpbTransferActionsCoils.TabStop = false;
            // 
            // btnCancelTransferCoils
            // 
            this.btnCancelTransferCoils.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelTransferCoils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelTransferCoils.Location = new System.Drawing.Point(6, 13);
            this.btnCancelTransferCoils.Name = "btnCancelTransferCoils";
            this.btnCancelTransferCoils.Size = new System.Drawing.Size(24, 25);
            this.btnCancelTransferCoils.TabIndex = 1;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnCancelTransferCoils, "Cancelar");
            this.btnCancelTransferCoils.UseVisualStyleBackColor = true;
            // 
            // btnTransferCoils
            // 
            this.btnTransferCoils.BackgroundImage = global::BPS.Properties.Resources.arrow_curve;
            this.btnTransferCoils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransferCoils.Location = new System.Drawing.Point(31, 13);
            this.btnTransferCoils.Name = "btnTransferCoils";
            this.btnTransferCoils.Size = new System.Drawing.Size(24, 25);
            this.btnTransferCoils.TabIndex = 0;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnTransferCoils, "Transferir Bobinas");
            this.btnTransferCoils.UseVisualStyleBackColor = true;
            // 
            // chkTransferCoil
            // 
            this.chkTransferCoil.AutoSize = true;
            this.chkTransferCoil.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkTransferCoil.Location = new System.Drawing.Point(3, 16);
            this.chkTransferCoil.Name = "chkTransferCoil";
            this.chkTransferCoil.Size = new System.Drawing.Size(234, 17);
            this.chkTransferCoil.TabIndex = 0;
            this.chkTransferCoil.Text = "Habilitar Transferencias";
            this.chkTransferCoil.UseVisualStyleBackColor = true;
            // 
            // grpbCoilList
            // 
            this.grpbCoilList.Controls.Add(this.dgvCoils);
            this.grpbCoilList.Controls.Add(this.grpbFilterCoils);
            this.grpbCoilList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbCoilList.Location = new System.Drawing.Point(3, 3);
            this.grpbCoilList.Name = "grpbCoilList";
            this.grpbCoilList.Size = new System.Drawing.Size(990, 456);
            this.grpbCoilList.TabIndex = 0;
            this.grpbCoilList.TabStop = false;
            this.grpbCoilList.Text = "Listado de pallets";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.AllowUserToDeleteRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmCustomer,
            this.clmCoilSalesOrder,
            this.clmProductName,
            this.clmLength,
            this.clmWidth,
            this.clmWeigth,
            this.clmQuality});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 82);
            this.dgvCoils.MultiSelect = false;
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoils.Size = new System.Drawing.Size(984, 371);
            this.dgvCoils.TabIndex = 1;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 110;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 220;
            // 
            // clmCoilSalesOrder
            // 
            this.clmCoilSalesOrder.HeaderText = "Ord. de venta";
            this.clmCoilSalesOrder.Name = "clmCoilSalesOrder";
            this.clmCoilSalesOrder.ReadOnly = true;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Width = 220;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            this.clmLength.Width = 90;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 90;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            this.clmWeigth.Width = 90;
            // 
            // clmQuality
            // 
            this.clmQuality.HeaderText = "Calidad";
            this.clmQuality.Name = "clmQuality";
            this.clmQuality.ReadOnly = true;
            // 
            // grpbFilterCoils
            // 
            this.grpbFilterCoils.Controls.Add(this.cmbSalesOrderCoil);
            this.grpbFilterCoils.Controls.Add(this.lblSalesOrderCoil);
            this.grpbFilterCoils.Controls.Add(this.cmbCustomerCoil);
            this.grpbFilterCoils.Controls.Add(this.lblCustomerCoil);
            this.grpbFilterCoils.Controls.Add(this.cmbProductCoil);
            this.grpbFilterCoils.Controls.Add(this.lblProductCoil);
            this.grpbFilterCoils.Controls.Add(this.grpbFilterActionsCoil);
            this.grpbFilterCoils.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilterCoils.Location = new System.Drawing.Point(3, 17);
            this.grpbFilterCoils.Name = "grpbFilterCoils";
            this.grpbFilterCoils.Size = new System.Drawing.Size(984, 65);
            this.grpbFilterCoils.TabIndex = 0;
            this.grpbFilterCoils.TabStop = false;
            this.grpbFilterCoils.Text = "Filtros";
            // 
            // cmbSalesOrderCoil
            // 
            this.cmbSalesOrderCoil.FormattingEnabled = true;
            this.cmbSalesOrderCoil.Location = new System.Drawing.Point(628, 26);
            this.cmbSalesOrderCoil.Name = "cmbSalesOrderCoil";
            this.cmbSalesOrderCoil.Size = new System.Drawing.Size(285, 23);
            this.cmbSalesOrderCoil.TabIndex = 2;
            this.cmbSalesOrderCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSalesOrderCoil_KeyDown);
            // 
            // lblSalesOrderCoil
            // 
            this.lblSalesOrderCoil.AutoSize = true;
            this.lblSalesOrderCoil.Location = new System.Drawing.Point(564, 29);
            this.lblSalesOrderCoil.Name = "lblSalesOrderCoil";
            this.lblSalesOrderCoil.Size = new System.Drawing.Size(64, 15);
            this.lblSalesOrderCoil.TabIndex = 14;
            this.lblSalesOrderCoil.Text = "Ord. Venta";
            // 
            // cmbCustomerCoil
            // 
            this.cmbCustomerCoil.FormattingEnabled = true;
            this.cmbCustomerCoil.Location = new System.Drawing.Point(331, 26);
            this.cmbCustomerCoil.Name = "cmbCustomerCoil";
            this.cmbCustomerCoil.Size = new System.Drawing.Size(218, 23);
            this.cmbCustomerCoil.TabIndex = 1;
            this.cmbCustomerCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerCoil_KeyDown);
            // 
            // lblCustomerCoil
            // 
            this.lblCustomerCoil.AutoSize = true;
            this.lblCustomerCoil.Location = new System.Drawing.Point(286, 29);
            this.lblCustomerCoil.Name = "lblCustomerCoil";
            this.lblCustomerCoil.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerCoil.TabIndex = 13;
            this.lblCustomerCoil.Text = "Cliente";
            // 
            // cmbProductCoil
            // 
            this.cmbProductCoil.FormattingEnabled = true;
            this.cmbProductCoil.Location = new System.Drawing.Point(62, 26);
            this.cmbProductCoil.Name = "cmbProductCoil";
            this.cmbProductCoil.Size = new System.Drawing.Size(218, 23);
            this.cmbProductCoil.TabIndex = 0;
            this.cmbProductCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProductCoil_KeyDown);
            // 
            // lblProductCoil
            // 
            this.lblProductCoil.AutoSize = true;
            this.lblProductCoil.Location = new System.Drawing.Point(6, 29);
            this.lblProductCoil.Name = "lblProductCoil";
            this.lblProductCoil.Size = new System.Drawing.Size(56, 15);
            this.lblProductCoil.TabIndex = 12;
            this.lblProductCoil.Text = "Producto";
            // 
            // grpbFilterActionsCoil
            // 
            this.grpbFilterActionsCoil.Controls.Add(this.btnClearFilterCoil);
            this.grpbFilterActionsCoil.Controls.Add(this.btnFilterCoil);
            this.grpbFilterActionsCoil.Location = new System.Drawing.Point(919, 10);
            this.grpbFilterActionsCoil.Name = "grpbFilterActionsCoil";
            this.grpbFilterActionsCoil.Size = new System.Drawing.Size(59, 44);
            this.grpbFilterActionsCoil.TabIndex = 3;
            this.grpbFilterActionsCoil.TabStop = false;
            // 
            // btnClearFilterCoil
            // 
            this.btnClearFilterCoil.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilterCoil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilterCoil.Location = new System.Drawing.Point(4, 13);
            this.btnClearFilterCoil.Name = "btnClearFilterCoil";
            this.btnClearFilterCoil.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilterCoil.TabIndex = 1;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnClearFilterCoil, "Limpiar Filtro");
            this.btnClearFilterCoil.UseVisualStyleBackColor = true;
            // 
            // btnFilterCoil
            // 
            this.btnFilterCoil.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilterCoil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterCoil.Location = new System.Drawing.Point(29, 13);
            this.btnFilterCoil.Name = "btnFilterCoil";
            this.btnFilterCoil.Size = new System.Drawing.Size(25, 25);
            this.btnFilterCoil.TabIndex = 0;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnFilterCoil, "Filtrar");
            this.btnFilterCoil.UseVisualStyleBackColor = true;
            // 
            // tbpTransfers
            // 
            this.tbpTransfers.Controls.Add(this.grpbIncomingTransfers);
            this.tbpTransfers.Controls.Add(this.grpbOutgoingTransfers);
            this.tbpTransfers.Location = new System.Drawing.Point(4, 24);
            this.tbpTransfers.Name = "tbpTransfers";
            this.tbpTransfers.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTransfers.Size = new System.Drawing.Size(1242, 462);
            this.tbpTransfers.TabIndex = 3;
            this.tbpTransfers.Text = "Transferencias";
            this.tbpTransfers.UseVisualStyleBackColor = true;
            // 
            // grpbIncomingTransfers
            // 
            this.grpbIncomingTransfers.Controls.Add(this.btnOutgoingRefresh);
            this.grpbIncomingTransfers.Controls.Add(this.grpbOutgoingDetail);
            this.grpbIncomingTransfers.Controls.Add(this.picbOutgoing);
            this.grpbIncomingTransfers.Controls.Add(this.chkShowAllOutgoing);
            this.grpbIncomingTransfers.Controls.Add(this.dgvOutgoingTransfer);
            this.grpbIncomingTransfers.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbIncomingTransfers.Location = new System.Drawing.Point(715, 3);
            this.grpbIncomingTransfers.Name = "grpbIncomingTransfers";
            this.grpbIncomingTransfers.Size = new System.Drawing.Size(524, 456);
            this.grpbIncomingTransfers.TabIndex = 1;
            this.grpbIncomingTransfers.TabStop = false;
            this.grpbIncomingTransfers.Text = "      Transferencias de salida";
            // 
            // btnOutgoingRefresh
            // 
            this.btnOutgoingRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOutgoingRefresh.BackgroundImage")));
            this.btnOutgoingRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOutgoingRefresh.Location = new System.Drawing.Point(497, 150);
            this.btnOutgoingRefresh.Name = "btnOutgoingRefresh";
            this.btnOutgoingRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnOutgoingRefresh.TabIndex = 2;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnOutgoingRefresh, "Actualizar Transferencias de Salida");
            this.btnOutgoingRefresh.UseVisualStyleBackColor = true;
            this.btnOutgoingRefresh.Click += new System.EventHandler(this.btnOutgoingRefresh_Click);
            // 
            // grpbOutgoingDetail
            // 
            this.grpbOutgoingDetail.Controls.Add(this.grpbOTCoilsDetail);
            this.grpbOutgoingDetail.Controls.Add(this.grpbOTPalletsDetail);
            this.grpbOutgoingDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbOutgoingDetail.Location = new System.Drawing.Point(3, 166);
            this.grpbOutgoingDetail.Name = "grpbOutgoingDetail";
            this.grpbOutgoingDetail.Size = new System.Drawing.Size(518, 287);
            this.grpbOutgoingDetail.TabIndex = 3;
            this.grpbOutgoingDetail.TabStop = false;
            this.grpbOutgoingDetail.Text = "Detalle de Transferencia";
            // 
            // grpbOTCoilsDetail
            // 
            this.grpbOTCoilsDetail.Controls.Add(this.dgvOTDCoils);
            this.grpbOTCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbOTCoilsDetail.Location = new System.Drawing.Point(3, 150);
            this.grpbOTCoilsDetail.Name = "grpbOTCoilsDetail";
            this.grpbOTCoilsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbOTCoilsDetail.TabIndex = 1;
            this.grpbOTCoilsDetail.TabStop = false;
            this.grpbOTCoilsDetail.Text = "Bobinas";
            // 
            // dgvOTDCoils
            // 
            this.dgvOTDCoils.AllowUserToAddRows = false;
            this.dgvOTDCoils.AllowUserToDeleteRows = false;
            this.dgvOTDCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOTDCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOTDCCodsec,
            this.clmOTDCCode,
            this.clmOTDCCustomer,
            this.clmOTDCSalesOrderNumber,
            this.clmOTDCProduct});
            this.dgvOTDCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOTDCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvOTDCoils.MultiSelect = false;
            this.dgvOTDCoils.Name = "dgvOTDCoils";
            this.dgvOTDCoils.ReadOnly = true;
            this.dgvOTDCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOTDCoils.Size = new System.Drawing.Size(506, 114);
            this.dgvOTDCoils.TabIndex = 0;
            // 
            // clmOTDCCodsec
            // 
            this.clmOTDCCodsec.HeaderText = "codsec";
            this.clmOTDCCodsec.Name = "clmOTDCCodsec";
            this.clmOTDCCodsec.ReadOnly = true;
            this.clmOTDCCodsec.Visible = false;
            // 
            // clmOTDCCode
            // 
            this.clmOTDCCode.HeaderText = "Código";
            this.clmOTDCCode.Name = "clmOTDCCode";
            this.clmOTDCCode.ReadOnly = true;
            this.clmOTDCCode.Width = 110;
            // 
            // clmOTDCCustomer
            // 
            this.clmOTDCCustomer.HeaderText = "Cliente";
            this.clmOTDCCustomer.Name = "clmOTDCCustomer";
            this.clmOTDCCustomer.ReadOnly = true;
            this.clmOTDCCustomer.Width = 220;
            // 
            // clmOTDCSalesOrderNumber
            // 
            this.clmOTDCSalesOrderNumber.HeaderText = "Ord. num";
            this.clmOTDCSalesOrderNumber.Name = "clmOTDCSalesOrderNumber";
            this.clmOTDCSalesOrderNumber.ReadOnly = true;
            // 
            // clmOTDCProduct
            // 
            this.clmOTDCProduct.HeaderText = "Producto";
            this.clmOTDCProduct.Name = "clmOTDCProduct";
            this.clmOTDCProduct.ReadOnly = true;
            this.clmOTDCProduct.Width = 220;
            // 
            // grpbOTPalletsDetail
            // 
            this.grpbOTPalletsDetail.Controls.Add(this.dgvOTDPallets);
            this.grpbOTPalletsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbOTPalletsDetail.Location = new System.Drawing.Point(3, 16);
            this.grpbOTPalletsDetail.Name = "grpbOTPalletsDetail";
            this.grpbOTPalletsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbOTPalletsDetail.TabIndex = 0;
            this.grpbOTPalletsDetail.TabStop = false;
            this.grpbOTPalletsDetail.Text = "Pallets";
            // 
            // dgvOTDPallets
            // 
            this.dgvOTDPallets.AllowUserToAddRows = false;
            this.dgvOTDPallets.AllowUserToDeleteRows = false;
            this.dgvOTDPallets.AllowUserToOrderColumns = true;
            this.dgvOTDPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOTDPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOTDPCodsec,
            this.clmOTDPCode,
            this.clmOTDPCustomer,
            this.clmOTDPSalesOrderNumber,
            this.clmOTDPProduct,
            this.clmOTDPCoils});
            this.dgvOTDPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOTDPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvOTDPallets.MultiSelect = false;
            this.dgvOTDPallets.Name = "dgvOTDPallets";
            this.dgvOTDPallets.ReadOnly = true;
            this.dgvOTDPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOTDPallets.Size = new System.Drawing.Size(506, 114);
            this.dgvOTDPallets.TabIndex = 0;
            // 
            // clmOTDPCodsec
            // 
            this.clmOTDPCodsec.HeaderText = "clmPalletCodsec";
            this.clmOTDPCodsec.Name = "clmOTDPCodsec";
            this.clmOTDPCodsec.ReadOnly = true;
            this.clmOTDPCodsec.Visible = false;
            // 
            // clmOTDPCode
            // 
            this.clmOTDPCode.HeaderText = "Código";
            this.clmOTDPCode.Name = "clmOTDPCode";
            this.clmOTDPCode.ReadOnly = true;
            this.clmOTDPCode.Width = 110;
            // 
            // clmOTDPCustomer
            // 
            this.clmOTDPCustomer.HeaderText = "Cliente";
            this.clmOTDPCustomer.Name = "clmOTDPCustomer";
            this.clmOTDPCustomer.ReadOnly = true;
            this.clmOTDPCustomer.Width = 220;
            // 
            // clmOTDPSalesOrderNumber
            // 
            this.clmOTDPSalesOrderNumber.HeaderText = "Ord. num.";
            this.clmOTDPSalesOrderNumber.Name = "clmOTDPSalesOrderNumber";
            this.clmOTDPSalesOrderNumber.ReadOnly = true;
            // 
            // clmOTDPProduct
            // 
            this.clmOTDPProduct.HeaderText = "Producto";
            this.clmOTDPProduct.Name = "clmOTDPProduct";
            this.clmOTDPProduct.ReadOnly = true;
            this.clmOTDPProduct.Width = 220;
            // 
            // clmOTDPCoils
            // 
            this.clmOTDPCoils.HeaderText = "Bobinas";
            this.clmOTDPCoils.Name = "clmOTDPCoils";
            this.clmOTDPCoils.ReadOnly = true;
            // 
            // picbOutgoing
            // 
            this.picbOutgoing.Image = global::BPS.Properties.Resources.arrow_outgoing;
            this.picbOutgoing.Location = new System.Drawing.Point(8, 0);
            this.picbOutgoing.Name = "picbOutgoing";
            this.picbOutgoing.Size = new System.Drawing.Size(16, 16);
            this.picbOutgoing.TabIndex = 1;
            this.picbOutgoing.TabStop = false;
            // 
            // chkShowAllOutgoing
            // 
            this.chkShowAllOutgoing.AutoSize = true;
            this.chkShowAllOutgoing.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShowAllOutgoing.Location = new System.Drawing.Point(3, 149);
            this.chkShowAllOutgoing.Name = "chkShowAllOutgoing";
            this.chkShowAllOutgoing.Size = new System.Drawing.Size(518, 17);
            this.chkShowAllOutgoing.TabIndex = 1;
            this.chkShowAllOutgoing.Text = "Mostrar todo (Pendientes/Aprovadas)";
            this.chkShowAllOutgoing.UseVisualStyleBackColor = true;
            // 
            // dgvOutgoingTransfer
            // 
            this.dgvOutgoingTransfer.AllowUserToAddRows = false;
            this.dgvOutgoingTransfer.AllowUserToDeleteRows = false;
            this.dgvOutgoingTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutgoingTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOTcodsec,
            this.clmOTStatus,
            this.clmOTDestinationCellar,
            this.clmOTTransferDate,
            this.clmOTReceptionDate,
            this.clmOTActions});
            this.dgvOutgoingTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOutgoingTransfer.Location = new System.Drawing.Point(3, 16);
            this.dgvOutgoingTransfer.Name = "dgvOutgoingTransfer";
            this.dgvOutgoingTransfer.ReadOnly = true;
            this.dgvOutgoingTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutgoingTransfer.Size = new System.Drawing.Size(518, 133);
            this.dgvOutgoingTransfer.TabIndex = 0;
            this.dgvOutgoingTransfer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutgoingTransfer_CellClick);
            // 
            // clmOTcodsec
            // 
            this.clmOTcodsec.HeaderText = "codsec";
            this.clmOTcodsec.Name = "clmOTcodsec";
            this.clmOTcodsec.ReadOnly = true;
            this.clmOTcodsec.Visible = false;
            // 
            // clmOTStatus
            // 
            this.clmOTStatus.HeaderText = "Estado";
            this.clmOTStatus.Name = "clmOTStatus";
            this.clmOTStatus.ReadOnly = true;
            // 
            // clmOTDestinationCellar
            // 
            this.clmOTDestinationCellar.HeaderText = "Destino";
            this.clmOTDestinationCellar.Name = "clmOTDestinationCellar";
            this.clmOTDestinationCellar.ReadOnly = true;
            // 
            // clmOTTransferDate
            // 
            this.clmOTTransferDate.HeaderText = "Enviado";
            this.clmOTTransferDate.Name = "clmOTTransferDate";
            this.clmOTTransferDate.ReadOnly = true;
            this.clmOTTransferDate.Width = 110;
            // 
            // clmOTReceptionDate
            // 
            this.clmOTReceptionDate.HeaderText = "Recibido";
            this.clmOTReceptionDate.Name = "clmOTReceptionDate";
            this.clmOTReceptionDate.ReadOnly = true;
            this.clmOTReceptionDate.Width = 110;
            // 
            // clmOTActions
            // 
            this.clmOTActions.HeaderText = "";
            this.clmOTActions.Name = "clmOTActions";
            this.clmOTActions.ReadOnly = true;
            this.clmOTActions.Width = 30;
            // 
            // grpbOutgoingTransfers
            // 
            this.grpbOutgoingTransfers.Controls.Add(this.btnIncomingRefresh);
            this.grpbOutgoingTransfers.Controls.Add(this.grpbIncomingDetail);
            this.grpbOutgoingTransfers.Controls.Add(this.chkShowAllIncoming);
            this.grpbOutgoingTransfers.Controls.Add(this.dgvIncomingTransfer);
            this.grpbOutgoingTransfers.Controls.Add(this.picbIncoming);
            this.grpbOutgoingTransfers.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbOutgoingTransfers.Location = new System.Drawing.Point(3, 3);
            this.grpbOutgoingTransfers.Name = "grpbOutgoingTransfers";
            this.grpbOutgoingTransfers.Size = new System.Drawing.Size(524, 456);
            this.grpbOutgoingTransfers.TabIndex = 0;
            this.grpbOutgoingTransfers.TabStop = false;
            this.grpbOutgoingTransfers.Text = "      Transferencias de entrada";
            // 
            // btnIncomingRefresh
            // 
            this.btnIncomingRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncomingRefresh.BackgroundImage")));
            this.btnIncomingRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncomingRefresh.Location = new System.Drawing.Point(497, 150);
            this.btnIncomingRefresh.Name = "btnIncomingRefresh";
            this.btnIncomingRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnIncomingRefresh.TabIndex = 2;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnIncomingRefresh, "Actualizar Transferencias de Entrada");
            this.btnIncomingRefresh.UseVisualStyleBackColor = true;
            this.btnIncomingRefresh.Click += new System.EventHandler(this.btnIncomingRefresh_Click);
            // 
            // grpbIncomingDetail
            // 
            this.grpbIncomingDetail.Controls.Add(this.grpbITCoilsDetail);
            this.grpbIncomingDetail.Controls.Add(this.grpbITPalletsDetail);
            this.grpbIncomingDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbIncomingDetail.Location = new System.Drawing.Point(3, 166);
            this.grpbIncomingDetail.Name = "grpbIncomingDetail";
            this.grpbIncomingDetail.Size = new System.Drawing.Size(518, 287);
            this.grpbIncomingDetail.TabIndex = 3;
            this.grpbIncomingDetail.TabStop = false;
            this.grpbIncomingDetail.Text = "Detalle de Transferencia";
            // 
            // grpbITCoilsDetail
            // 
            this.grpbITCoilsDetail.Controls.Add(this.dgvITDCoils);
            this.grpbITCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbITCoilsDetail.Location = new System.Drawing.Point(3, 150);
            this.grpbITCoilsDetail.Name = "grpbITCoilsDetail";
            this.grpbITCoilsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbITCoilsDetail.TabIndex = 1;
            this.grpbITCoilsDetail.TabStop = false;
            this.grpbITCoilsDetail.Text = "Bobinas";
            // 
            // dgvITDCoils
            // 
            this.dgvITDCoils.AllowUserToAddRows = false;
            this.dgvITDCoils.AllowUserToDeleteRows = false;
            this.dgvITDCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvITDCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmITDCCodsec,
            this.clmITDCCode,
            this.clmITDCCustomer,
            this.clmITDCSalesOrderNumber,
            this.clmITDCProduct});
            this.dgvITDCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvITDCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvITDCoils.MultiSelect = false;
            this.dgvITDCoils.Name = "dgvITDCoils";
            this.dgvITDCoils.ReadOnly = true;
            this.dgvITDCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvITDCoils.Size = new System.Drawing.Size(506, 114);
            this.dgvITDCoils.TabIndex = 0;
            // 
            // clmITDCCodsec
            // 
            this.clmITDCCodsec.HeaderText = "codsec";
            this.clmITDCCodsec.Name = "clmITDCCodsec";
            this.clmITDCCodsec.ReadOnly = true;
            this.clmITDCCodsec.Visible = false;
            // 
            // clmITDCCode
            // 
            this.clmITDCCode.HeaderText = "Código";
            this.clmITDCCode.Name = "clmITDCCode";
            this.clmITDCCode.ReadOnly = true;
            this.clmITDCCode.Width = 110;
            // 
            // clmITDCCustomer
            // 
            this.clmITDCCustomer.HeaderText = "Cliente";
            this.clmITDCCustomer.Name = "clmITDCCustomer";
            this.clmITDCCustomer.ReadOnly = true;
            this.clmITDCCustomer.Width = 220;
            // 
            // clmITDCSalesOrderNumber
            // 
            this.clmITDCSalesOrderNumber.HeaderText = "Ord. num";
            this.clmITDCSalesOrderNumber.Name = "clmITDCSalesOrderNumber";
            this.clmITDCSalesOrderNumber.ReadOnly = true;
            // 
            // clmITDCProduct
            // 
            this.clmITDCProduct.HeaderText = "Producto";
            this.clmITDCProduct.Name = "clmITDCProduct";
            this.clmITDCProduct.ReadOnly = true;
            this.clmITDCProduct.Width = 220;
            // 
            // grpbITPalletsDetail
            // 
            this.grpbITPalletsDetail.Controls.Add(this.dgvITDPallets);
            this.grpbITPalletsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbITPalletsDetail.Location = new System.Drawing.Point(3, 16);
            this.grpbITPalletsDetail.Name = "grpbITPalletsDetail";
            this.grpbITPalletsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbITPalletsDetail.TabIndex = 0;
            this.grpbITPalletsDetail.TabStop = false;
            this.grpbITPalletsDetail.Text = "Pallets";
            // 
            // dgvITDPallets
            // 
            this.dgvITDPallets.AllowUserToAddRows = false;
            this.dgvITDPallets.AllowUserToDeleteRows = false;
            this.dgvITDPallets.AllowUserToOrderColumns = true;
            this.dgvITDPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvITDPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmITDPCodsec,
            this.clmITDPCode,
            this.clmITDPCustomer,
            this.clmITDPSalesOrderNumber,
            this.clmITDPProduct,
            this.clmITDPCoils});
            this.dgvITDPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvITDPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvITDPallets.MultiSelect = false;
            this.dgvITDPallets.Name = "dgvITDPallets";
            this.dgvITDPallets.ReadOnly = true;
            this.dgvITDPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvITDPallets.Size = new System.Drawing.Size(506, 114);
            this.dgvITDPallets.TabIndex = 0;
            // 
            // clmITDPCodsec
            // 
            this.clmITDPCodsec.HeaderText = "clmPalletCodsec";
            this.clmITDPCodsec.Name = "clmITDPCodsec";
            this.clmITDPCodsec.ReadOnly = true;
            this.clmITDPCodsec.Visible = false;
            // 
            // clmITDPCode
            // 
            this.clmITDPCode.HeaderText = "Código";
            this.clmITDPCode.Name = "clmITDPCode";
            this.clmITDPCode.ReadOnly = true;
            this.clmITDPCode.Width = 110;
            // 
            // clmITDPCustomer
            // 
            this.clmITDPCustomer.HeaderText = "Cliente";
            this.clmITDPCustomer.Name = "clmITDPCustomer";
            this.clmITDPCustomer.ReadOnly = true;
            this.clmITDPCustomer.Width = 220;
            // 
            // clmITDPSalesOrderNumber
            // 
            this.clmITDPSalesOrderNumber.HeaderText = "Ord. num.";
            this.clmITDPSalesOrderNumber.Name = "clmITDPSalesOrderNumber";
            this.clmITDPSalesOrderNumber.ReadOnly = true;
            // 
            // clmITDPProduct
            // 
            this.clmITDPProduct.HeaderText = "Producto";
            this.clmITDPProduct.Name = "clmITDPProduct";
            this.clmITDPProduct.ReadOnly = true;
            this.clmITDPProduct.Width = 220;
            // 
            // clmITDPCoils
            // 
            this.clmITDPCoils.HeaderText = "Bobinas";
            this.clmITDPCoils.Name = "clmITDPCoils";
            this.clmITDPCoils.ReadOnly = true;
            // 
            // chkShowAllIncoming
            // 
            this.chkShowAllIncoming.AutoSize = true;
            this.chkShowAllIncoming.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShowAllIncoming.Location = new System.Drawing.Point(3, 149);
            this.chkShowAllIncoming.Name = "chkShowAllIncoming";
            this.chkShowAllIncoming.Size = new System.Drawing.Size(518, 17);
            this.chkShowAllIncoming.TabIndex = 1;
            this.chkShowAllIncoming.Text = "Mostrar todo (Por recibir/Recibidas)";
            this.chkShowAllIncoming.UseVisualStyleBackColor = true;
            // 
            // dgvIncomingTransfer
            // 
            this.dgvIncomingTransfer.AllowUserToAddRows = false;
            this.dgvIncomingTransfer.AllowUserToDeleteRows = false;
            this.dgvIncomingTransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomingTransfer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmITcodsec,
            this.clmITStatus,
            this.clmITOriginCellar,
            this.clmITTranferDate,
            this.clmITReceptionDate,
            this.clmITActions});
            this.dgvIncomingTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvIncomingTransfer.Location = new System.Drawing.Point(3, 16);
            this.dgvIncomingTransfer.Name = "dgvIncomingTransfer";
            this.dgvIncomingTransfer.ReadOnly = true;
            this.dgvIncomingTransfer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingTransfer.Size = new System.Drawing.Size(518, 133);
            this.dgvIncomingTransfer.TabIndex = 0;
            this.dgvIncomingTransfer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncomingTransfer_CellClick);
            // 
            // clmITcodsec
            // 
            this.clmITcodsec.HeaderText = "codsec";
            this.clmITcodsec.Name = "clmITcodsec";
            this.clmITcodsec.ReadOnly = true;
            this.clmITcodsec.Visible = false;
            // 
            // clmITStatus
            // 
            this.clmITStatus.HeaderText = "Estado";
            this.clmITStatus.Name = "clmITStatus";
            this.clmITStatus.ReadOnly = true;
            // 
            // clmITOriginCellar
            // 
            this.clmITOriginCellar.HeaderText = "Origen";
            this.clmITOriginCellar.Name = "clmITOriginCellar";
            this.clmITOriginCellar.ReadOnly = true;
            // 
            // clmITTranferDate
            // 
            this.clmITTranferDate.HeaderText = "Enviado";
            this.clmITTranferDate.Name = "clmITTranferDate";
            this.clmITTranferDate.ReadOnly = true;
            this.clmITTranferDate.Width = 110;
            // 
            // clmITReceptionDate
            // 
            this.clmITReceptionDate.HeaderText = "Recibido";
            this.clmITReceptionDate.Name = "clmITReceptionDate";
            this.clmITReceptionDate.ReadOnly = true;
            this.clmITReceptionDate.Width = 110;
            // 
            // clmITActions
            // 
            this.clmITActions.HeaderText = "";
            this.clmITActions.Name = "clmITActions";
            this.clmITActions.ReadOnly = true;
            this.clmITActions.Width = 30;
            // 
            // picbIncoming
            // 
            this.picbIncoming.Image = global::BPS.Properties.Resources.arrow_incoming;
            this.picbIncoming.Location = new System.Drawing.Point(9, 0);
            this.picbIncoming.Name = "picbIncoming";
            this.picbIncoming.Size = new System.Drawing.Size(16, 16);
            this.picbIncoming.TabIndex = 0;
            this.picbIncoming.TabStop = false;
            // 
            // tbpRequest
            // 
            this.tbpRequest.Controls.Add(this.groupBox1);
            this.tbpRequest.Controls.Add(this.groupBox5);
            this.tbpRequest.Location = new System.Drawing.Point(4, 24);
            this.tbpRequest.Name = "tbpRequest";
            this.tbpRequest.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRequest.Size = new System.Drawing.Size(1242, 462);
            this.tbpRequest.TabIndex = 4;
            this.tbpRequest.Text = "Requisiciones";
            this.tbpRequest.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOutgoingRequestRefresh);
            this.groupBox1.Controls.Add(this.grpboutgoingRequestDetail);
            this.groupBox1.Controls.Add(this.picbOutgoingRequest);
            this.groupBox1.Controls.Add(this.chkShowAllRequestOutgoing);
            this.groupBox1.Controls.Add(this.dgvOutgoingRequest);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(715, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 456);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "      Requisiciones salientes";
            // 
            // btnOutgoingRequestRefresh
            // 
            this.btnOutgoingRequestRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOutgoingRequestRefresh.BackgroundImage")));
            this.btnOutgoingRequestRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOutgoingRequestRefresh.Location = new System.Drawing.Point(497, 150);
            this.btnOutgoingRequestRefresh.Name = "btnOutgoingRequestRefresh";
            this.btnOutgoingRequestRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnOutgoingRequestRefresh.TabIndex = 2;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnOutgoingRequestRefresh, "Actualizar Requesiciones Salientes");
            this.btnOutgoingRequestRefresh.UseVisualStyleBackColor = true;
            // 
            // grpboutgoingRequestDetail
            // 
            this.grpboutgoingRequestDetail.Controls.Add(this.grpbORCoilsDetail);
            this.grpboutgoingRequestDetail.Controls.Add(this.grpbORPalletsDetail);
            this.grpboutgoingRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpboutgoingRequestDetail.Location = new System.Drawing.Point(3, 166);
            this.grpboutgoingRequestDetail.Name = "grpboutgoingRequestDetail";
            this.grpboutgoingRequestDetail.Size = new System.Drawing.Size(518, 287);
            this.grpboutgoingRequestDetail.TabIndex = 3;
            this.grpboutgoingRequestDetail.TabStop = false;
            this.grpboutgoingRequestDetail.Text = "Detalle de Requisición";
            // 
            // grpbORCoilsDetail
            // 
            this.grpbORCoilsDetail.Controls.Add(this.dgvORDCoils);
            this.grpbORCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbORCoilsDetail.Location = new System.Drawing.Point(3, 150);
            this.grpbORCoilsDetail.Name = "grpbORCoilsDetail";
            this.grpbORCoilsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbORCoilsDetail.TabIndex = 1;
            this.grpbORCoilsDetail.TabStop = false;
            this.grpbORCoilsDetail.Text = "Bobinas";
            // 
            // dgvORDCoils
            // 
            this.dgvORDCoils.AllowUserToAddRows = false;
            this.dgvORDCoils.AllowUserToDeleteRows = false;
            this.dgvORDCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvORDCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvORDCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvORDCoils.MultiSelect = false;
            this.dgvORDCoils.Name = "dgvORDCoils";
            this.dgvORDCoils.ReadOnly = true;
            this.dgvORDCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvORDCoils.Size = new System.Drawing.Size(506, 114);
            this.dgvORDCoils.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Código";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Ord. num";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // grpbORPalletsDetail
            // 
            this.grpbORPalletsDetail.Controls.Add(this.dgvORDPallets);
            this.grpbORPalletsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbORPalletsDetail.Location = new System.Drawing.Point(3, 16);
            this.grpbORPalletsDetail.Name = "grpbORPalletsDetail";
            this.grpbORPalletsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbORPalletsDetail.TabIndex = 0;
            this.grpbORPalletsDetail.TabStop = false;
            this.grpbORPalletsDetail.Text = "Pallets";
            // 
            // dgvORDPallets
            // 
            this.dgvORDPallets.AllowUserToAddRows = false;
            this.dgvORDPallets.AllowUserToDeleteRows = false;
            this.dgvORDPallets.AllowUserToOrderColumns = true;
            this.dgvORDPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgvORDPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvORDPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvORDPallets.MultiSelect = false;
            this.dgvORDPallets.Name = "dgvORDPallets";
            this.dgvORDPallets.ReadOnly = true;
            this.dgvORDPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvORDPallets.Size = new System.Drawing.Size(506, 114);
            this.dgvORDPallets.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "clmPalletCodsec";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Código";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 220;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Ord. num.";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 220;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Bobinas";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // picbOutgoingRequest
            // 
            this.picbOutgoingRequest.Image = global::BPS.Properties.Resources.arrow_outgoing;
            this.picbOutgoingRequest.Location = new System.Drawing.Point(8, 0);
            this.picbOutgoingRequest.Name = "picbOutgoingRequest";
            this.picbOutgoingRequest.Size = new System.Drawing.Size(16, 16);
            this.picbOutgoingRequest.TabIndex = 1;
            this.picbOutgoingRequest.TabStop = false;
            // 
            // chkShowAllRequestOutgoing
            // 
            this.chkShowAllRequestOutgoing.AutoSize = true;
            this.chkShowAllRequestOutgoing.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShowAllRequestOutgoing.Location = new System.Drawing.Point(3, 149);
            this.chkShowAllRequestOutgoing.Name = "chkShowAllRequestOutgoing";
            this.chkShowAllRequestOutgoing.Size = new System.Drawing.Size(518, 17);
            this.chkShowAllRequestOutgoing.TabIndex = 1;
            this.chkShowAllRequestOutgoing.Text = "Mostrar todo (Pendientes/Aprovadas)";
            this.chkShowAllRequestOutgoing.UseVisualStyleBackColor = true;
            // 
            // dgvOutgoingRequest
            // 
            this.dgvOutgoingRequest.AllowUserToAddRows = false;
            this.dgvOutgoingRequest.AllowUserToDeleteRows = false;
            this.dgvOutgoingRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutgoingRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewImageColumn1});
            this.dgvOutgoingRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOutgoingRequest.Location = new System.Drawing.Point(3, 16);
            this.dgvOutgoingRequest.Name = "dgvOutgoingRequest";
            this.dgvOutgoingRequest.ReadOnly = true;
            this.dgvOutgoingRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOutgoingRequest.Size = new System.Drawing.Size(518, 133);
            this.dgvOutgoingRequest.TabIndex = 0;
            this.dgvOutgoingRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutgoingRequest_CellClick);
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Enviado";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 110;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Recibido";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 110;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnIncomingRequestRefresh);
            this.groupBox5.Controls.Add(this.grpbIncomingRequestDetail);
            this.groupBox5.Controls.Add(this.chkShowAllRequestIncoming);
            this.groupBox5.Controls.Add(this.dgvIncomingRequest);
            this.groupBox5.Controls.Add(this.picbIncomingRequest);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(524, 456);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "      Requisiciones entrantes";
            // 
            // btnIncomingRequestRefresh
            // 
            this.btnIncomingRequestRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIncomingRequestRefresh.BackgroundImage")));
            this.btnIncomingRequestRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnIncomingRequestRefresh.Location = new System.Drawing.Point(497, 150);
            this.btnIncomingRequestRefresh.Name = "btnIncomingRequestRefresh";
            this.btnIncomingRequestRefresh.Size = new System.Drawing.Size(24, 25);
            this.btnIncomingRequestRefresh.TabIndex = 2;
            this.ttpCoilPalletsCellar.SetToolTip(this.btnIncomingRequestRefresh, "Actulizar Requisiciones Entrantes");
            this.btnIncomingRequestRefresh.UseVisualStyleBackColor = true;
            // 
            // grpbIncomingRequestDetail
            // 
            this.grpbIncomingRequestDetail.Controls.Add(this.grpbIRCoilsDetail);
            this.grpbIncomingRequestDetail.Controls.Add(this.grpbIRPalletsDetail);
            this.grpbIncomingRequestDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbIncomingRequestDetail.Location = new System.Drawing.Point(3, 166);
            this.grpbIncomingRequestDetail.Name = "grpbIncomingRequestDetail";
            this.grpbIncomingRequestDetail.Size = new System.Drawing.Size(518, 287);
            this.grpbIncomingRequestDetail.TabIndex = 3;
            this.grpbIncomingRequestDetail.TabStop = false;
            this.grpbIncomingRequestDetail.Text = "Detalle de Requisición";
            // 
            // grpbIRCoilsDetail
            // 
            this.grpbIRCoilsDetail.Controls.Add(this.dgvIRDCoils);
            this.grpbIRCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbIRCoilsDetail.Location = new System.Drawing.Point(3, 150);
            this.grpbIRCoilsDetail.Name = "grpbIRCoilsDetail";
            this.grpbIRCoilsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbIRCoilsDetail.TabIndex = 1;
            this.grpbIRCoilsDetail.TabStop = false;
            this.grpbIRCoilsDetail.Text = "Bobinas";
            // 
            // dgvIRDCoils
            // 
            this.dgvIRDCoils.AllowUserToAddRows = false;
            this.dgvIRDCoils.AllowUserToDeleteRows = false;
            this.dgvIRDCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIRDCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21});
            this.dgvIRDCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIRDCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvIRDCoils.MultiSelect = false;
            this.dgvIRDCoils.Name = "dgvIRDCoils";
            this.dgvIRDCoils.ReadOnly = true;
            this.dgvIRDCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIRDCoils.Size = new System.Drawing.Size(506, 114);
            this.dgvIRDCoils.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Código";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 110;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 220;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Ord. num";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 220;
            // 
            // grpbIRPalletsDetail
            // 
            this.grpbIRPalletsDetail.Controls.Add(this.dgvIRDPallets);
            this.grpbIRPalletsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbIRPalletsDetail.Location = new System.Drawing.Point(3, 16);
            this.grpbIRPalletsDetail.Name = "grpbIRPalletsDetail";
            this.grpbIRPalletsDetail.Size = new System.Drawing.Size(512, 134);
            this.grpbIRPalletsDetail.TabIndex = 0;
            this.grpbIRPalletsDetail.TabStop = false;
            this.grpbIRPalletsDetail.Text = "Pallets";
            // 
            // dgvIRDPallets
            // 
            this.dgvIRDPallets.AllowUserToAddRows = false;
            this.dgvIRDPallets.AllowUserToDeleteRows = false;
            this.dgvIRDPallets.AllowUserToOrderColumns = true;
            this.dgvIRDPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIRDPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.dgvIRDPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIRDPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvIRDPallets.MultiSelect = false;
            this.dgvIRDPallets.Name = "dgvIRDPallets";
            this.dgvIRDPallets.ReadOnly = true;
            this.dgvIRDPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIRDPallets.Size = new System.Drawing.Size(506, 114);
            this.dgvIRDPallets.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "clmPalletCodsec";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "Código";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 110;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 220;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "Ord. num.";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 220;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "Bobinas";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            // 
            // chkShowAllRequestIncoming
            // 
            this.chkShowAllRequestIncoming.AutoSize = true;
            this.chkShowAllRequestIncoming.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkShowAllRequestIncoming.Location = new System.Drawing.Point(3, 149);
            this.chkShowAllRequestIncoming.Name = "chkShowAllRequestIncoming";
            this.chkShowAllRequestIncoming.Size = new System.Drawing.Size(518, 17);
            this.chkShowAllRequestIncoming.TabIndex = 1;
            this.chkShowAllRequestIncoming.Text = "Mostrar todo (Por recibir/Recibidas)";
            this.chkShowAllRequestIncoming.UseVisualStyleBackColor = true;
            // 
            // dgvIncomingRequest
            // 
            this.dgvIncomingRequest.AllowUserToAddRows = false;
            this.dgvIncomingRequest.AllowUserToDeleteRows = false;
            this.dgvIncomingRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomingRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewImageColumn2});
            this.dgvIncomingRequest.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvIncomingRequest.Location = new System.Drawing.Point(3, 16);
            this.dgvIncomingRequest.Name = "dgvIncomingRequest";
            this.dgvIncomingRequest.ReadOnly = true;
            this.dgvIncomingRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingRequest.Size = new System.Drawing.Size(518, 133);
            this.dgvIncomingRequest.TabIndex = 0;
            this.dgvIncomingRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncomingRequest_CellClick);
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Visible = false;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.HeaderText = "Origen";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.HeaderText = "Enviado";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 110;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.HeaderText = "Recibido";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 110;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // picbIncomingRequest
            // 
            this.picbIncomingRequest.Image = global::BPS.Properties.Resources.arrow_incoming;
            this.picbIncomingRequest.Location = new System.Drawing.Point(9, 0);
            this.picbIncomingRequest.Name = "picbIncomingRequest";
            this.picbIncomingRequest.Size = new System.Drawing.Size(16, 16);
            this.picbIncomingRequest.TabIndex = 0;
            this.picbIncomingRequest.TabStop = false;
            // 
            // clmPalletCodsec
            // 
            this.clmPalletCodsec.HeaderText = "clmPalletCodsec";
            this.clmPalletCodsec.Name = "clmPalletCodsec";
            this.clmPalletCodsec.ReadOnly = true;
            this.clmPalletCodsec.Visible = false;
            // 
            // clmPalletStatusImage
            // 
            this.clmPalletStatusImage.HeaderText = "";
            this.clmPalletStatusImage.Name = "clmPalletStatusImage";
            this.clmPalletStatusImage.ReadOnly = true;
            this.clmPalletStatusImage.Width = 30;
            // 
            // clmPalletProduct
            // 
            this.clmPalletProduct.HeaderText = "Producto";
            this.clmPalletProduct.Name = "clmPalletProduct";
            this.clmPalletProduct.ReadOnly = true;
            this.clmPalletProduct.Width = 150;
            // 
            // clmPalletCoilsNumber
            // 
            this.clmPalletCoilsNumber.HeaderText = "ID";
            this.clmPalletCoilsNumber.Name = "clmPalletCoilsNumber";
            this.clmPalletCoilsNumber.ReadOnly = true;
            this.clmPalletCoilsNumber.Width = 60;
            // 
            // clmPalletSalesOrderNumber
            // 
            this.clmPalletSalesOrderNumber.HeaderText = "Orden";
            this.clmPalletSalesOrderNumber.Name = "clmPalletSalesOrderNumber";
            this.clmPalletSalesOrderNumber.ReadOnly = true;
            this.clmPalletSalesOrderNumber.Width = 80;
            // 
            // clmPalletWidth
            // 
            this.clmPalletWidth.HeaderText = "Ancho";
            this.clmPalletWidth.Name = "clmPalletWidth";
            this.clmPalletWidth.ReadOnly = true;
            this.clmPalletWidth.Width = 80;
            // 
            // clmPalletWeigth
            // 
            this.clmPalletWeigth.HeaderText = "Peso";
            this.clmPalletWeigth.Name = "clmPalletWeigth";
            this.clmPalletWeigth.ReadOnly = true;
            this.clmPalletWeigth.Width = 80;
            // 
            // clmPalletCustomer
            // 
            this.clmPalletCustomer.HeaderText = "Cliente";
            this.clmPalletCustomer.Name = "clmPalletCustomer";
            this.clmPalletCustomer.ReadOnly = true;
            this.clmPalletCustomer.Width = 220;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Código";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            this.clmPalletCode.Width = 110;
            // 
            // frmCoilPalletsCellar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1250, 490);
            this.Controls.Add(this.tbcLists);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilPalletsCellar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = resources.GetString("$this.Text");
            this.Load += new System.EventHandler(this.frmCoilPalletsCellar_Load);
            this.tbcLists.ResumeLayout(false);
            this.tbpPallets.ResumeLayout(false);
            this.grpbPalletTransfer.ResumeLayout(false);
            this.grpbPalletTransfer.PerformLayout();
            this.grpbTransferListPallets.ResumeLayout(false);
            this.grpbTransferListPallets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferListPallet)).EndInit();
            this.grpbTransferActionsPallet.ResumeLayout(false);
            this.grpbPalletList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).EndInit();
            this.grpbPalletListFilters.ResumeLayout(false);
            this.grpbPalletListFilters.PerformLayout();
            this.grpbPalletFiltersBar.ResumeLayout(false);
            this.tbpCoils.ResumeLayout(false);
            this.grpbCoilTransfer.ResumeLayout(false);
            this.grpbCoilTransfer.PerformLayout();
            this.grpbTransferListCoil.ResumeLayout(false);
            this.grpbTransferListCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferListCoils)).EndInit();
            this.grpbTransferActionsCoils.ResumeLayout(false);
            this.grpbCoilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbFilterCoils.ResumeLayout(false);
            this.grpbFilterCoils.PerformLayout();
            this.grpbFilterActionsCoil.ResumeLayout(false);
            this.tbpTransfers.ResumeLayout(false);
            this.grpbIncomingTransfers.ResumeLayout(false);
            this.grpbIncomingTransfers.PerformLayout();
            this.grpbOutgoingDetail.ResumeLayout(false);
            this.grpbOTCoilsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOTDCoils)).EndInit();
            this.grpbOTPalletsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOTDPallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbOutgoing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutgoingTransfer)).EndInit();
            this.grpbOutgoingTransfers.ResumeLayout(false);
            this.grpbOutgoingTransfers.PerformLayout();
            this.grpbIncomingDetail.ResumeLayout(false);
            this.grpbITCoilsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDCoils)).EndInit();
            this.grpbITPalletsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDPallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbIncoming)).EndInit();
            this.tbpRequest.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpboutgoingRequestDetail.ResumeLayout(false);
            this.grpbORCoilsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDCoils)).EndInit();
            this.grpbORPalletsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDPallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbOutgoingRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutgoingRequest)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpbIncomingRequestDetail.ResumeLayout(false);
            this.grpbIRCoilsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIRDCoils)).EndInit();
            this.grpbIRPalletsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIRDPallets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbIncomingRequest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcLists;
        private System.Windows.Forms.TabPage tbpPallets;
        private System.Windows.Forms.TabPage tbpCoils;        
        private System.Windows.Forms.GroupBox grpbPalletTransfer;
        private System.Windows.Forms.GroupBox grpbTransferListPallets;
        private System.Windows.Forms.DataGridView dgvTransferListPallet;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbTransferActionsPallet;
        private System.Windows.Forms.Button btnCancelTransferPallet;
        private System.Windows.Forms.Button btnTransferPallet;
        private System.Windows.Forms.CheckBox chkValidationRequiredPallet;
        private System.Windows.Forms.CheckBox chkTransferPallet;
        private System.Windows.Forms.GroupBox grpbPalletList;
        private System.Windows.Forms.DataGridView dgvPallets;
        private System.Windows.Forms.GroupBox grpbPalletListFilters;
        private System.Windows.Forms.ComboBox cmbSalesOrder;
        private System.Windows.Forms.Label lblSalesOrderPallet;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox grpbPalletFiltersBar;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnFilters;
        private System.Windows.Forms.GroupBox grpbCoilTransfer;
        private System.Windows.Forms.CheckBox chkTransferCoil;
        private System.Windows.Forms.GroupBox grpbCoilList;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuality;
        private System.Windows.Forms.GroupBox grpbFilterCoils;
        private System.Windows.Forms.ComboBox cmbSalesOrderCoil;
        private System.Windows.Forms.Label lblSalesOrderCoil;
        private System.Windows.Forms.ComboBox cmbCustomerCoil;
        private System.Windows.Forms.Label lblCustomerCoil;
        private System.Windows.Forms.ComboBox cmbProductCoil;
        private System.Windows.Forms.Label lblProductCoil;
        private System.Windows.Forms.GroupBox grpbFilterActionsCoil;
        private System.Windows.Forms.Button btnClearFilterCoil;
        private System.Windows.Forms.Button btnFilterCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTransterCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTransferCode;
        private System.Windows.Forms.DataGridViewImageColumn clmPalletTransferDelete;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.ComboBox cmbCellarPallets;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.Label lblCellarPallets;
        private System.Windows.Forms.GroupBox grpbTransferListCoil;
        private System.Windows.Forms.CheckBox chkValidationRequiredCoils;
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.ComboBox cmbCellarCoil;
        private System.Windows.Forms.Label lblCoilCode;
        private System.Windows.Forms.Label lblCellarCoil;
        private System.Windows.Forms.DataGridView dgvTransferListCoils;
        private System.Windows.Forms.GroupBox grpbEmptyCoils;
        private System.Windows.Forms.GroupBox grpbTransferActionsCoils;
        private System.Windows.Forms.Button btnCancelTransferCoils;
        private System.Windows.Forms.Button btnTransferCoils;
        private System.Windows.Forms.TabPage tbpTransfers;
        private System.Windows.Forms.GroupBox grpbIncomingTransfers;
        private System.Windows.Forms.GroupBox grpbOutgoingTransfers;
        private System.Windows.Forms.PictureBox picbIncoming;
        private System.Windows.Forms.PictureBox picbOutgoing;
        private System.Windows.Forms.GroupBox grpbOutgoingDetail;
        private System.Windows.Forms.GroupBox grpbOTCoilsDetail;
        private System.Windows.Forms.DataGridView dgvOTDCoils;
        private System.Windows.Forms.GroupBox grpbOTPalletsDetail;
        private System.Windows.Forms.DataGridView dgvOTDPallets;
        private System.Windows.Forms.CheckBox chkShowAllOutgoing;
        private System.Windows.Forms.DataGridView dgvOutgoingTransfer;
        private System.Windows.Forms.GroupBox grpbIncomingDetail;
        private System.Windows.Forms.GroupBox grpbITCoilsDetail;
        private System.Windows.Forms.DataGridView dgvITDCoils;
        private System.Windows.Forms.GroupBox grpbITPalletsDetail;
        private System.Windows.Forms.DataGridView dgvITDPallets;
        private System.Windows.Forms.CheckBox chkShowAllIncoming;
        private System.Windows.Forms.DataGridView dgvIncomingTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITOriginCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITTranferDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITReceptionDate;
        private System.Windows.Forms.DataGridViewImageColumn clmITActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDestinationCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTTransferDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTReceptionDate;
        private System.Windows.Forms.DataGridViewImageColumn clmOTActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilTransterCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilTransterCode;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilTransterDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDCCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDCCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDCSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDCProduct;
        private System.Windows.Forms.Button btnOutgoingRefresh;
        private System.Windows.Forms.Button btnIncomingRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDPCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDPCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDPSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDPProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOTDPCoils;
        private System.Windows.Forms.TabPage tbpRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOutgoingRequestRefresh;
        private System.Windows.Forms.GroupBox grpboutgoingRequestDetail;
        private System.Windows.Forms.GroupBox grpbORCoilsDetail;
        private System.Windows.Forms.DataGridView dgvORDCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox grpbORPalletsDetail;
        private System.Windows.Forms.DataGridView dgvORDPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.PictureBox picbOutgoingRequest;
        private System.Windows.Forms.CheckBox chkShowAllRequestOutgoing;
        private System.Windows.Forms.DataGridView dgvOutgoingRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnIncomingRequestRefresh;
        private System.Windows.Forms.GroupBox grpbIncomingRequestDetail;
        private System.Windows.Forms.GroupBox grpbIRCoilsDetail;
        private System.Windows.Forms.DataGridView dgvIRDCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.GroupBox grpbIRPalletsDetail;
        private System.Windows.Forms.DataGridView dgvIRDPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.CheckBox chkShowAllRequestIncoming;
        private System.Windows.Forms.DataGridView dgvIncomingRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox picbIncomingRequest;
        private System.Windows.Forms.ToolTip ttpCoilPalletsCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodsec;
        private System.Windows.Forms.DataGridViewImageColumn clmPalletStatusImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCoilsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
    }
}