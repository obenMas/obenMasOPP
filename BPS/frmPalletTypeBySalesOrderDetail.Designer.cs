namespace BPS
{
    partial class frmPalletTypeBySalesOrderDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletTypeBySalesOrderDetail));
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerIdLabel = new System.Windows.Forms.Label();
            this.grpbSalesOrder = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNumberCodsec = new System.Windows.Forms.Label();
            this.grpbPalletType = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.btnNewDimension = new System.Windows.Forms.Button();
            this.btnNewPallet = new System.Windows.Forms.Button();
            this.chkSingleFace = new System.Windows.Forms.CheckBox();
            this.btnAddPallet = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbDimentions = new System.Windows.Forms.ComboBox();
            this.cmbPalletType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDimention = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.dgvPalletType = new System.Windows.Forms.DataGridView();
            this.clmPalletTypeCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypePTCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeDimentionCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeTransportCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeTransport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeCoilsByPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeDimention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeTotalCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ttpPalletBySalesOrderDetail = new System.Windows.Forms.ToolTip(this.components);
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.grpbSalesOrder.SuspendLayout();
            this.grpbPalletType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletType)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Location = new System.Drawing.Point(0, 61);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(928, 176);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmProductCodsec,
            this.clmProductCode,
            this.clmProductWidth,
            this.clmProductDiameter,
            this.clmProductCore,
            this.clmQuantity,
            this.clmStock,
            this.clmCoils,
            this.clmInPallet});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(922, 156);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // clmCodsec
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.clmCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmProductCodsec
            // 
            this.clmProductCodsec.HeaderText = "productCodsec";
            this.clmProductCodsec.Name = "clmProductCodsec";
            this.clmProductCodsec.ReadOnly = true;
            this.clmProductCodsec.Visible = false;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Código";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductCode.Width = 120;
            // 
            // clmProductWidth
            // 
            this.clmProductWidth.HeaderText = "Ancho";
            this.clmProductWidth.Name = "clmProductWidth";
            this.clmProductWidth.ReadOnly = true;
            this.clmProductWidth.Width = 105;
            // 
            // clmProductDiameter
            // 
            this.clmProductDiameter.HeaderText = "Diametro";
            this.clmProductDiameter.Name = "clmProductDiameter";
            this.clmProductDiameter.ReadOnly = true;
            this.clmProductDiameter.Width = 105;
            // 
            // clmProductCore
            // 
            this.clmProductCore.HeaderText = "Core";
            this.clmProductCore.Name = "clmProductCore";
            this.clmProductCore.ReadOnly = true;
            this.clmProductCore.Width = 105;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQuantity.Width = 105;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 105;
            // 
            // clmCoils
            // 
            this.clmCoils.HeaderText = "Bobinas";
            this.clmCoils.Name = "clmCoils";
            this.clmCoils.ReadOnly = true;
            this.clmCoils.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmCoils.Width = 105;
            // 
            // clmInPallet
            // 
            this.clmInPallet.HeaderText = "Reg. para Pallet";
            this.clmInPallet.Name = "clmInPallet";
            this.clmInPallet.ReadOnly = true;
            this.clmInPallet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmInPallet.Width = 105;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(890, 469);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(38, 43);
            this.grpbActions.TabIndex = 4;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(6, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 2;
            this.ttpPalletBySalesOrderDetail.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(3, 469);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(884, 43);
            this.grpbFilters.TabIndex = 3;
            this.grpbFilters.TabStop = false;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(351, 28);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(52, 15);
            this.lblCustomerNameLabel.TabIndex = 3;
            this.lblCustomerNameLabel.Text = "Nombre";
            // 
            // lblCustomerIdLabel
            // 
            this.lblCustomerIdLabel.AutoSize = true;
            this.lblCustomerIdLabel.Location = new System.Drawing.Point(187, 28);
            this.lblCustomerIdLabel.Name = "lblCustomerIdLabel";
            this.lblCustomerIdLabel.Size = new System.Drawing.Size(46, 15);
            this.lblCustomerIdLabel.TabIndex = 0;
            this.lblCustomerIdLabel.Text = "Código";
            // 
            // grpbSalesOrder
            // 
            this.grpbSalesOrder.Controls.Add(this.lblCustomerName);
            this.grpbSalesOrder.Controls.Add(this.lblCustomerId);
            this.grpbSalesOrder.Controls.Add(this.lblNumber);
            this.grpbSalesOrder.Controls.Add(this.lblNumberCodsec);
            this.grpbSalesOrder.Controls.Add(this.lblCustomerIdLabel);
            this.grpbSalesOrder.Controls.Add(this.lblCustomerNameLabel);
            this.grpbSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbSalesOrder.Name = "grpbSalesOrder";
            this.grpbSalesOrder.Size = new System.Drawing.Size(928, 61);
            this.grpbSalesOrder.TabIndex = 0;
            this.grpbSalesOrder.TabStop = false;
            this.grpbSalesOrder.Text = "Orden de Venta";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Location = new System.Drawing.Point(409, 25);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(377, 21);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Tag = "clearOnReload";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerId.Location = new System.Drawing.Point(239, 25);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(100, 21);
            this.lblCustomerId.TabIndex = 1;
            this.lblCustomerId.Tag = "clearOnReload";
            this.lblCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Location = new System.Drawing.Point(81, 25);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 21);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Tag = "clearOnReload";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumberCodsec
            // 
            this.lblNumberCodsec.AutoSize = true;
            this.lblNumberCodsec.Location = new System.Drawing.Point(23, 28);
            this.lblNumberCodsec.Name = "lblNumberCodsec";
            this.lblNumberCodsec.Size = new System.Drawing.Size(52, 15);
            this.lblNumberCodsec.TabIndex = 0;
            this.lblNumberCodsec.Text = "Número";
            // 
            // grpbPalletType
            // 
            this.grpbPalletType.Controls.Add(this.txtCode);
            this.grpbPalletType.Controls.Add(this.cmbTransport);
            this.grpbPalletType.Controls.Add(this.lblTransport);
            this.grpbPalletType.Controls.Add(this.btnNewDimension);
            this.grpbPalletType.Controls.Add(this.btnNewPallet);
            this.grpbPalletType.Controls.Add(this.chkSingleFace);
            this.grpbPalletType.Controls.Add(this.btnAddPallet);
            this.grpbPalletType.Controls.Add(this.txtQuantity);
            this.grpbPalletType.Controls.Add(this.cmbDimentions);
            this.grpbPalletType.Controls.Add(this.cmbPalletType);
            this.grpbPalletType.Controls.Add(this.lblQuantity);
            this.grpbPalletType.Controls.Add(this.lblDimention);
            this.grpbPalletType.Controls.Add(this.lblPalletType);
            this.grpbPalletType.Controls.Add(this.dgvPalletType);
            this.grpbPalletType.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletType.Location = new System.Drawing.Point(0, 237);
            this.grpbPalletType.Name = "grpbPalletType";
            this.grpbPalletType.Size = new System.Drawing.Size(928, 236);
            this.grpbPalletType.TabIndex = 3;
            this.grpbPalletType.TabStop = false;
            this.grpbPalletType.Text = "Tipo de paletas";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(111, 24);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(73, 21);
            this.txtCode.TabIndex = 0;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // cmbTransport
            // 
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(178, 51);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(617, 23);
            this.cmbTransport.TabIndex = 10;
            this.cmbTransport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTransport_KeyDown);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(103, 55);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(66, 15);
            this.lblTransport.TabIndex = 9;
            this.lblTransport.Text = "Transporte";
            // 
            // btnNewDimension
            // 
            this.btnNewDimension.BackgroundImage = global::BPS.Properties.Resources.storage2;
            this.btnNewDimension.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewDimension.Location = new System.Drawing.Point(645, 22);
            this.btnNewDimension.Name = "btnNewDimension";
            this.btnNewDimension.Size = new System.Drawing.Size(25, 25);
            this.btnNewDimension.TabIndex = 5;
            this.ttpPalletBySalesOrderDetail.SetToolTip(this.btnNewDimension, "Agregar Dimensión");
            this.btnNewDimension.UseVisualStyleBackColor = true;
            this.btnNewDimension.Click += new System.EventHandler(this.btnNewDimension_Click);
            // 
            // btnNewPallet
            // 
            this.btnNewPallet.BackgroundImage = global::BPS.Properties.Resources.pallet;
            this.btnNewPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewPallet.Location = new System.Drawing.Point(402, 22);
            this.btnNewPallet.Name = "btnNewPallet";
            this.btnNewPallet.Size = new System.Drawing.Size(25, 25);
            this.btnNewPallet.TabIndex = 2;
            this.ttpPalletBySalesOrderDetail.SetToolTip(this.btnNewPallet, "Agregar Pallet");
            this.btnNewPallet.UseVisualStyleBackColor = true;
            this.btnNewPallet.Click += new System.EventHandler(this.btnNewPallet_Click);
            // 
            // chkSingleFace
            // 
            this.chkSingleFace.AutoSize = true;
            this.chkSingleFace.Location = new System.Drawing.Point(816, 25);
            this.chkSingleFace.Name = "chkSingleFace";
            this.chkSingleFace.Size = new System.Drawing.Size(82, 17);
            this.chkSingleFace.TabIndex = 8;
            this.chkSingleFace.Text = "Single Face";
            this.chkSingleFace.UseVisualStyleBackColor = true;
            // 
            // btnAddPallet
            // 
            this.btnAddPallet.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPallet.Location = new System.Drawing.Point(801, 50);
            this.btnAddPallet.Name = "btnAddPallet";
            this.btnAddPallet.Size = new System.Drawing.Size(25, 25);
            this.btnAddPallet.TabIndex = 11;
            this.ttpPalletBySalesOrderDetail.SetToolTip(this.btnAddPallet, "Agregar");
            this.btnAddPallet.UseVisualStyleBackColor = true;
            this.btnAddPallet.Click += new System.EventHandler(this.btnAddPallet_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(734, 24);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(73, 21);
            this.txtQuantity.TabIndex = 7;
            // 
            // cmbDimentions
            // 
            this.cmbDimentions.FormattingEnabled = true;
            this.cmbDimentions.Location = new System.Drawing.Point(521, 23);
            this.cmbDimentions.Name = "cmbDimentions";
            this.cmbDimentions.Size = new System.Drawing.Size(122, 23);
            this.cmbDimentions.TabIndex = 4;
            this.cmbDimentions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDimentions_KeyDown);
            // 
            // cmbPalletType
            // 
            this.cmbPalletType.FormattingEnabled = true;
            this.cmbPalletType.Location = new System.Drawing.Point(190, 23);
            this.cmbPalletType.Name = "cmbPalletType";
            this.cmbPalletType.Size = new System.Drawing.Size(210, 23);
            this.cmbPalletType.TabIndex = 1;
            this.cmbPalletType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPalletType_KeyDown);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(675, 27);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 15);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Cantidad";
            // 
            // lblDimention
            // 
            this.lblDimention.AutoSize = true;
            this.lblDimention.Location = new System.Drawing.Point(438, 27);
            this.lblDimention.Name = "lblDimention";
            this.lblDimention.Size = new System.Drawing.Size(80, 15);
            this.lblDimention.TabIndex = 3;
            this.lblDimention.Text = "Dimensiones";
            // 
            // lblPalletType
            // 
            this.lblPalletType.AutoSize = true;
            this.lblPalletType.Location = new System.Drawing.Point(23, 27);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(81, 15);
            this.lblPalletType.TabIndex = 1;
            this.lblPalletType.Text = "Tipo de pallet";
            // 
            // dgvPalletType
            // 
            this.dgvPalletType.AllowUserToAddRows = false;
            this.dgvPalletType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletTypeCodsec,
            this.clmPalletTypePTCodsec,
            this.clmPalletTypeDimentionCodsec,
            this.clmPalletTypeTransportCodsec,
            this.clmPalletTypeTransport,
            this.clmPalletTypeName,
            this.clmPalletTypeCoilsByPallet,
            this.clmPalletTypeDimention,
            this.clmPalletTypeQuantity,
            this.clmPalletTypeTotalCoils,
            this.clmPalletTypeDelete});
            this.dgvPalletType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPalletType.Location = new System.Drawing.Point(3, 83);
            this.dgvPalletType.Name = "dgvPalletType";
            this.dgvPalletType.ReadOnly = true;
            this.dgvPalletType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalletType.Size = new System.Drawing.Size(922, 150);
            this.dgvPalletType.TabIndex = 12;
            this.dgvPalletType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletType_CellClick);
            // 
            // clmPalletTypeCodsec
            // 
            this.clmPalletTypeCodsec.HeaderText = "codsec";
            this.clmPalletTypeCodsec.Name = "clmPalletTypeCodsec";
            this.clmPalletTypeCodsec.ReadOnly = true;
            this.clmPalletTypeCodsec.Visible = false;
            // 
            // clmPalletTypePTCodsec
            // 
            this.clmPalletTypePTCodsec.HeaderText = "palletTypeCodsec";
            this.clmPalletTypePTCodsec.Name = "clmPalletTypePTCodsec";
            this.clmPalletTypePTCodsec.ReadOnly = true;
            this.clmPalletTypePTCodsec.Visible = false;
            // 
            // clmPalletTypeDimentionCodsec
            // 
            this.clmPalletTypeDimentionCodsec.HeaderText = "DimentionCodsec";
            this.clmPalletTypeDimentionCodsec.Name = "clmPalletTypeDimentionCodsec";
            this.clmPalletTypeDimentionCodsec.ReadOnly = true;
            this.clmPalletTypeDimentionCodsec.Visible = false;
            // 
            // clmPalletTypeTransportCodsec
            // 
            this.clmPalletTypeTransportCodsec.HeaderText = "transportCodsec";
            this.clmPalletTypeTransportCodsec.Name = "clmPalletTypeTransportCodsec";
            this.clmPalletTypeTransportCodsec.ReadOnly = true;
            this.clmPalletTypeTransportCodsec.Visible = false;
            // 
            // clmPalletTypeTransport
            // 
            this.clmPalletTypeTransport.HeaderText = "Contenedor";
            this.clmPalletTypeTransport.Name = "clmPalletTypeTransport";
            this.clmPalletTypeTransport.ReadOnly = true;
            this.clmPalletTypeTransport.Width = 150;
            // 
            // clmPalletTypeName
            // 
            this.clmPalletTypeName.HeaderText = "Pallet";
            this.clmPalletTypeName.Name = "clmPalletTypeName";
            this.clmPalletTypeName.ReadOnly = true;
            this.clmPalletTypeName.Width = 275;
            // 
            // clmPalletTypeCoilsByPallet
            // 
            this.clmPalletTypeCoilsByPallet.HeaderText = "Bob. x pallet";
            this.clmPalletTypeCoilsByPallet.Name = "clmPalletTypeCoilsByPallet";
            this.clmPalletTypeCoilsByPallet.ReadOnly = true;
            // 
            // clmPalletTypeDimention
            // 
            this.clmPalletTypeDimention.HeaderText = "Dimensiones";
            this.clmPalletTypeDimention.Name = "clmPalletTypeDimention";
            this.clmPalletTypeDimention.ReadOnly = true;
            // 
            // clmPalletTypeQuantity
            // 
            this.clmPalletTypeQuantity.HeaderText = "Cantidad";
            this.clmPalletTypeQuantity.Name = "clmPalletTypeQuantity";
            this.clmPalletTypeQuantity.ReadOnly = true;
            // 
            // clmPalletTypeTotalCoils
            // 
            this.clmPalletTypeTotalCoils.HeaderText = "Total bobinas";
            this.clmPalletTypeTotalCoils.Name = "clmPalletTypeTotalCoils";
            this.clmPalletTypeTotalCoils.ReadOnly = true;
            // 
            // clmPalletTypeDelete
            // 
            this.clmPalletTypeDelete.HeaderText = "";
            this.clmPalletTypeDelete.Name = "clmPalletTypeDelete";
            this.clmPalletTypeDelete.ReadOnly = true;
            this.clmPalletTypeDelete.Width = 30;
            // 
            // frmPalletTypeBySalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(928, 512);
            this.Controls.Add(this.grpbPalletType);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbSalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletTypeBySalesOrderDetail";
            this.Text = "Definición de pallets";
            this.Load += new System.EventHandler(this.frmPalletTypeBySalesOrderDetail_Load);
            this.grpbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbSalesOrder.ResumeLayout(false);
            this.grpbSalesOrder.PerformLayout();
            this.grpbPalletType.ResumeLayout(false);
            this.grpbPalletType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDetail;
        public System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblCustomerIdLabel;
        private System.Windows.Forms.GroupBox grpbSalesOrder;
        private System.Windows.Forms.Label lblNumberCodsec;
        private System.Windows.Forms.GroupBox grpbPalletType;
        private System.Windows.Forms.DataGridView dgvPalletType;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.ComboBox cmbPalletType;
        private System.Windows.Forms.Label lblPalletType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbDimentions;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDimention;
        private System.Windows.Forms.Button btnAddPallet;
        private System.Windows.Forms.CheckBox chkSingleFace;
        private System.Windows.Forms.Button btnNewDimension;
        private System.Windows.Forms.Button btnNewPallet;
        private System.Windows.Forms.ToolTip ttpPalletBySalesOrderDetail;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypePTCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeDimentionCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeTransportCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeTransport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeCoilsByPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeDimention;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeTotalCoils;
        private System.Windows.Forms.DataGridViewImageColumn clmPalletTypeDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInPallet;
        private System.Windows.Forms.TextBox txtCode;
    }
}