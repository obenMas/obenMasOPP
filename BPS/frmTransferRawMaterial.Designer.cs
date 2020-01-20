namespace BPS
{
    partial class frmTransferRawMaterial
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
            this.cmbRm = new System.Windows.Forms.ComboBox();
            this.lblRm = new System.Windows.Forms.Label();
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmfkTransfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransferNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpbRm = new System.Windows.Forms.GroupBox();
            this.chkRMTFilter = new System.Windows.Forms.CheckBox();
            this.grpbRmt = new System.Windows.Forms.GroupBox();
            this.cmbRmt = new System.Windows.Forms.ComboBox();
            this.lblRmt = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.grpbUser = new System.Windows.Forms.GroupBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkCellar = new System.Windows.Forms.CheckBox();
            this.grpbCellar = new System.Windows.Forms.GroupBox();
            this.cmbCellar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCustomerFilter = new System.Windows.Forms.CheckBox();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.grpbProviders = new System.Windows.Forms.GroupBox();
            this.txtProviderId = new System.Windows.Forms.TextBox();
            this.cmbProvider = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.grpbDates = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbRm.SuspendLayout();
            this.grpbRmt.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.grpbFilterActions.SuspendLayout();
            this.grpbFilters.SuspendLayout();
            this.grpbUser.SuspendLayout();
            this.grpbCellar.SuspendLayout();
            this.grpbProviders.SuspendLayout();
            this.grpbDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRm
            // 
            this.cmbRm.FormattingEnabled = true;
            this.cmbRm.Location = new System.Drawing.Point(62, 21);
            this.cmbRm.Name = "cmbRm";
            this.cmbRm.Size = new System.Drawing.Size(132, 23);
            this.cmbRm.TabIndex = 1;
            // 
            // lblRm
            // 
            this.lblRm.AutoSize = true;
            this.lblRm.Location = new System.Drawing.Point(8, 25);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(52, 15);
            this.lblRm.TabIndex = 0;
            this.lblRm.Text = "Nombre";
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvDetail);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(970, 300);
            this.grpbList.TabIndex = 15;
            this.grpbList.TabStop = false;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToOrderColumns = true;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmfkTransfer,
            this.clmTransferNumber,
            this.clmRawMaterialProvider,
            this.clmRawMaterialType,
            this.clmRawMaterialCode,
            this.clmRawMaterialName,
            this.clmQuantity,
            this.clmCellar,
            this.clmRawMaterialDate,
            this.clmUser});
            this.dgvDetail.Location = new System.Drawing.Point(8, 14);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(957, 279);
            this.dgvDetail.TabIndex = 0;
            // 
            // clmfkTransfer
            // 
            this.clmfkTransfer.HeaderText = "codsec";
            this.clmfkTransfer.Name = "clmfkTransfer";
            this.clmfkTransfer.ReadOnly = true;
            this.clmfkTransfer.Visible = false;
            this.clmfkTransfer.Width = 80;
            // 
            // clmTransferNumber
            // 
            this.clmTransferNumber.HeaderText = "Código Transferencia";
            this.clmTransferNumber.Name = "clmTransferNumber";
            this.clmTransferNumber.ReadOnly = true;
            this.clmTransferNumber.Width = 120;
            // 
            // clmRawMaterialProvider
            // 
            this.clmRawMaterialProvider.HeaderText = "Proveedor";
            this.clmRawMaterialProvider.Name = "clmRawMaterialProvider";
            this.clmRawMaterialProvider.ReadOnly = true;
            this.clmRawMaterialProvider.Width = 90;
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            this.clmRawMaterialType.Width = 110;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código M.P.";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            this.clmRawMaterialCode.Width = 80;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Nombre M.P.";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            this.clmRawMaterialName.Width = 90;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 80;
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Bodega";
            this.clmCellar.Name = "clmCellar";
            this.clmCellar.ReadOnly = true;
            // 
            // clmRawMaterialDate
            // 
            this.clmRawMaterialDate.HeaderText = "Fecha Transferencia";
            this.clmRawMaterialDate.Name = "clmRawMaterialDate";
            this.clmRawMaterialDate.ReadOnly = true;
            this.clmRawMaterialDate.Width = 150;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "Transferido Por";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            this.clmUser.Width = 90;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(514, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Materia Prima";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // grpbRm
            // 
            this.grpbRm.Controls.Add(this.cmbRm);
            this.grpbRm.Controls.Add(this.lblRm);
            this.grpbRm.Enabled = false;
            this.grpbRm.Location = new System.Drawing.Point(505, 77);
            this.grpbRm.Name = "grpbRm";
            this.grpbRm.Size = new System.Drawing.Size(203, 53);
            this.grpbRm.TabIndex = 6;
            this.grpbRm.TabStop = false;
            // 
            // chkRMTFilter
            // 
            this.chkRMTFilter.AutoSize = true;
            this.chkRMTFilter.Location = new System.Drawing.Point(515, 15);
            this.chkRMTFilter.Name = "chkRMTFilter";
            this.chkRMTFilter.Size = new System.Drawing.Size(114, 17);
            this.chkRMTFilter.TabIndex = 5;
            this.chkRMTFilter.Text = "Tipo Materia Prima";
            this.chkRMTFilter.UseVisualStyleBackColor = true;
            this.chkRMTFilter.CheckedChanged += new System.EventHandler(this.chkRMTFilter_CheckedChanged);
            // 
            // grpbRmt
            // 
            this.grpbRmt.Controls.Add(this.cmbRmt);
            this.grpbRmt.Controls.Add(this.lblRmt);
            this.grpbRmt.Enabled = false;
            this.grpbRmt.Location = new System.Drawing.Point(505, 19);
            this.grpbRmt.Name = "grpbRmt";
            this.grpbRmt.Size = new System.Drawing.Size(203, 53);
            this.grpbRmt.TabIndex = 4;
            this.grpbRmt.TabStop = false;
            // 
            // cmbRmt
            // 
            this.cmbRmt.FormattingEnabled = true;
            this.cmbRmt.Location = new System.Drawing.Point(62, 21);
            this.cmbRmt.Name = "cmbRmt";
            this.cmbRmt.Size = new System.Drawing.Size(132, 23);
            this.cmbRmt.TabIndex = 1;
            // 
            // lblRmt
            // 
            this.lblRmt.AutoSize = true;
            this.lblRmt.Location = new System.Drawing.Point(8, 25);
            this.lblRmt.Name = "lblRmt";
            this.lblRmt.Size = new System.Drawing.Size(52, 15);
            this.lblRmt.TabIndex = 0;
            this.lblRmt.Text = "Nombre";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(44, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(28, 28);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(8, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(28, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(41, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(593, 306);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 21);
            this.txtTotal.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total";
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnAdd);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(889, 467);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(76, 49);
            this.grpbActions.TabIndex = 19;
            this.grpbActions.TabStop = false;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(10, 15);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(28, 28);
            this.btnClearFilters.TabIndex = 0;
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // grpbSearch
            // 
            this.grpbSearch.Location = new System.Drawing.Point(5, 467);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(797, 49);
            this.grpbSearch.TabIndex = 17;
            this.grpbSearch.TabStop = false;
            // 
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Location = new System.Drawing.Point(808, 467);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(80, 49);
            this.grpbFilterActions.TabIndex = 18;
            this.grpbFilterActions.TabStop = false;
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.chkUser);
            this.grpbFilters.Controls.Add(this.grpbUser);
            this.grpbFilters.Controls.Add(this.chkCellar);
            this.grpbFilters.Controls.Add(this.grpbCellar);
            this.grpbFilters.Controls.Add(this.checkBox1);
            this.grpbFilters.Controls.Add(this.grpbRm);
            this.grpbFilters.Controls.Add(this.chkRMTFilter);
            this.grpbFilters.Controls.Add(this.grpbRmt);
            this.grpbFilters.Controls.Add(this.chkCustomerFilter);
            this.grpbFilters.Controls.Add(this.chkDateFilter);
            this.grpbFilters.Controls.Add(this.grpbProviders);
            this.grpbFilters.Controls.Add(this.grpbDates);
            this.grpbFilters.Location = new System.Drawing.Point(1, 327);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(964, 141);
            this.grpbFilters.TabIndex = 16;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Location = new System.Drawing.Point(748, 73);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(62, 17);
            this.chkUser.TabIndex = 14;
            this.chkUser.Text = "Usuario";
            this.chkUser.UseVisualStyleBackColor = true;
            this.chkUser.CheckedChanged += new System.EventHandler(this.chkUser_CheckedChanged);
            // 
            // grpbUser
            // 
            this.grpbUser.Controls.Add(this.cmbUser);
            this.grpbUser.Controls.Add(this.label1);
            this.grpbUser.Enabled = false;
            this.grpbUser.Location = new System.Drawing.Point(739, 75);
            this.grpbUser.Name = "grpbUser";
            this.grpbUser.Size = new System.Drawing.Size(203, 53);
            this.grpbUser.TabIndex = 13;
            this.grpbUser.TabStop = false;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(62, 21);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(132, 23);
            this.cmbUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // chkCellar
            // 
            this.chkCellar.AutoSize = true;
            this.chkCellar.Location = new System.Drawing.Point(749, 13);
            this.chkCellar.Name = "chkCellar";
            this.chkCellar.Size = new System.Drawing.Size(63, 17);
            this.chkCellar.TabIndex = 12;
            this.chkCellar.Text = "Bodega";
            this.chkCellar.UseVisualStyleBackColor = true;
            this.chkCellar.CheckedChanged += new System.EventHandler(this.chkCellar_CheckedChanged);
            // 
            // grpbCellar
            // 
            this.grpbCellar.Controls.Add(this.cmbCellar);
            this.grpbCellar.Controls.Add(this.label3);
            this.grpbCellar.Enabled = false;
            this.grpbCellar.Location = new System.Drawing.Point(739, 17);
            this.grpbCellar.Name = "grpbCellar";
            this.grpbCellar.Size = new System.Drawing.Size(203, 53);
            this.grpbCellar.TabIndex = 11;
            this.grpbCellar.TabStop = false;
            // 
            // cmbCellar
            // 
            this.cmbCellar.FormattingEnabled = true;
            this.cmbCellar.Location = new System.Drawing.Point(62, 21);
            this.cmbCellar.Name = "cmbCellar";
            this.cmbCellar.Size = new System.Drawing.Size(132, 23);
            this.cmbCellar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // chkCustomerFilter
            // 
            this.chkCustomerFilter.AutoSize = true;
            this.chkCustomerFilter.Location = new System.Drawing.Point(273, 17);
            this.chkCustomerFilter.Name = "chkCustomerFilter";
            this.chkCustomerFilter.Size = new System.Drawing.Size(86, 17);
            this.chkCustomerFilter.TabIndex = 2;
            this.chkCustomerFilter.Text = "Proveedores";
            this.chkCustomerFilter.UseVisualStyleBackColor = true;
            this.chkCustomerFilter.CheckedChanged += new System.EventHandler(this.chkCustomerFilter_CheckedChanged);
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(19, 18);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(61, 17);
            this.chkDateFilter.TabIndex = 0;
            this.chkDateFilter.Text = "Fechas";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.chkDateFilter_CheckedChanged);
            // 
            // grpbProviders
            // 
            this.grpbProviders.Controls.Add(this.txtProviderId);
            this.grpbProviders.Controls.Add(this.cmbProvider);
            this.grpbProviders.Controls.Add(this.lblName);
            this.grpbProviders.Controls.Add(this.lblId);
            this.grpbProviders.Enabled = false;
            this.grpbProviders.Location = new System.Drawing.Point(263, 20);
            this.grpbProviders.Name = "grpbProviders";
            this.grpbProviders.Size = new System.Drawing.Size(203, 111);
            this.grpbProviders.TabIndex = 2;
            this.grpbProviders.TabStop = false;
            // 
            // txtProviderId
            // 
            this.txtProviderId.Location = new System.Drawing.Point(62, 66);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(132, 21);
            this.txtProviderId.TabIndex = 3;
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(62, 25);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(132, 23);
            this.cmbProvider.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(17, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Id";
            // 
            // grpbDates
            // 
            this.grpbDates.Controls.Add(this.dtpTo);
            this.grpbDates.Controls.Add(this.lblFrom);
            this.grpbDates.Controls.Add(this.dtpFrom);
            this.grpbDates.Controls.Add(this.lblTo);
            this.grpbDates.Enabled = false;
            this.grpbDates.Location = new System.Drawing.Point(10, 21);
            this.grpbDates.Name = "grpbDates";
            this.grpbDates.Size = new System.Drawing.Size(226, 110);
            this.grpbDates.TabIndex = 0;
            this.grpbDates.TabStop = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(76, 70);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(133, 21);
            this.dtpTo.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(9, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Desde";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(76, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(133, 21);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(15, 75);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(39, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Hasta";
            // 
            // frmTransferRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 518);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbFilterActions);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTransferRawMaterial";
            this.Text = "Listado Transferencia Materia Prima";
            this.Load += new System.EventHandler(this.frmTransferRawMaterial_Load);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbRm.ResumeLayout(false);
            this.grpbRm.PerformLayout();
            this.grpbRmt.ResumeLayout(false);
            this.grpbRmt.PerformLayout();
            this.grpbActions.ResumeLayout(false);
            this.grpbFilterActions.ResumeLayout(false);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbUser.ResumeLayout(false);
            this.grpbUser.PerformLayout();
            this.grpbCellar.ResumeLayout(false);
            this.grpbCellar.PerformLayout();
            this.grpbProviders.ResumeLayout(false);
            this.grpbProviders.PerformLayout();
            this.grpbDates.ResumeLayout(false);
            this.grpbDates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRm;
        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grpbRm;
        private System.Windows.Forms.CheckBox chkRMTFilter;
        private System.Windows.Forms.GroupBox grpbRmt;
        private System.Windows.Forms.ComboBox cmbRmt;
        private System.Windows.Forms.Label lblRmt;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.CheckBox chkCustomerFilter;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.GroupBox grpbProviders;
        private System.Windows.Forms.TextBox txtProviderId;
        private System.Windows.Forms.ComboBox cmbProvider;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox grpbDates;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkTransfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransferNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.GroupBox grpbUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkCellar;
        private System.Windows.Forms.GroupBox grpbCellar;
        private System.Windows.Forms.ComboBox cmbCellar;
        private System.Windows.Forms.Label label3;
    }
}