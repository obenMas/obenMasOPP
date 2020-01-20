namespace BPS
{
    partial class frmDeliverRawMaterialList
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliverRawMaterialList));
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialReceptionCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialProvider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkUser = new System.Windows.Forms.CheckBox();
            this.grpbUser = new System.Windows.Forms.GroupBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.chbxStatus = new System.Windows.Forms.CheckBox();
            this.grpbStatus = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpbRm = new System.Windows.Forms.GroupBox();
            this.cmbRm = new System.Windows.Forms.ComboBox();
            this.lblRm = new System.Windows.Forms.Label();
            this.chkRMTFilter = new System.Windows.Forms.CheckBox();
            this.grpbRmt = new System.Windows.Forms.GroupBox();
            this.cmbRmt = new System.Windows.Forms.ComboBox();
            this.lblRmt = new System.Windows.Forms.Label();
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
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.ttpDeliverRawMaterial = new System.Windows.Forms.ToolTip(this.components);
            this.grpbFilterActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.grpbFilters.SuspendLayout();
            this.grpbUser.SuspendLayout();
            this.grpbStatus.SuspendLayout();
            this.grpbRm.SuspendLayout();
            this.grpbRmt.SuspendLayout();
            this.grpbProviders.SuspendLayout();
            this.grpbDates.SuspendLayout();
            this.grpbList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbSearch
            // 
            this.grpbSearch.Location = new System.Drawing.Point(6, 470);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(788, 58);
            this.grpbSearch.TabIndex = 15;
            this.grpbSearch.TabStop = false;
            // 
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Location = new System.Drawing.Point(800, 469);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(83, 58);
            this.grpbFilterActions.TabIndex = 16;
            this.grpbFilterActions.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(44, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(34, 33);
            this.btnFilter.TabIndex = 1;
            this.ttpDeliverRawMaterial.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(10, 15);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(34, 33);
            this.btnClearFilters.TabIndex = 0;
            this.ttpDeliverRawMaterial.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToOrderColumns = true;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialReceptionCodsec,
            this.clmRawMaterialProvider,
            this.clmRawMaterialType,
            this.clmRawMaterialCode,
            this.clmRawMaterialName,
            this.clmBatch,
            this.clmQuantity,
            this.clmCellar,
            this.clmRawMaterialDate,
            this.clmUser});
            this.dgvDetail.Location = new System.Drawing.Point(8, 14);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(996, 279);
            this.dgvDetail.TabIndex = 0;
            // 
            // clmRawMaterialReceptionCodsec
            // 
            this.clmRawMaterialReceptionCodsec.HeaderText = "codsec";
            this.clmRawMaterialReceptionCodsec.Name = "clmRawMaterialReceptionCodsec";
            this.clmRawMaterialReceptionCodsec.ReadOnly = true;
            this.clmRawMaterialReceptionCodsec.Visible = false;
            this.clmRawMaterialReceptionCodsec.Width = 80;
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
            // clmBatch
            // 
            this.clmBatch.HeaderText = "Lote";
            this.clmBatch.Name = "clmBatch";
            this.clmBatch.ReadOnly = true;
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
            this.clmCellar.Width = 170;
            // 
            // clmRawMaterialDate
            // 
            this.clmRawMaterialDate.HeaderText = "Fecha Recepción";
            this.clmRawMaterialDate.Name = "clmRawMaterialDate";
            this.clmRawMaterialDate.ReadOnly = true;
            this.clmRawMaterialDate.Width = 150;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "Despachado Por";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            this.clmUser.Width = 90;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnAdd);
            this.grpbActions.Controls.Add(this.btnViewDetail);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(889, 469);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(116, 58);
            this.grpbActions.TabIndex = 17;
            this.grpbActions.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(8, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 33);
            this.btnAdd.TabIndex = 0;
            this.ttpDeliverRawMaterial.SetToolTip(this.btnAdd, "Agregar Despacho Materia Prima");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(42, 15);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(34, 33);
            this.btnViewDetail.TabIndex = 1;
            this.ttpDeliverRawMaterial.SetToolTip(this.btnViewDetail, "Ver Detalles Despacho Materia Prima");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(76, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 33);
            this.btnClose.TabIndex = 3;
            this.ttpDeliverRawMaterial.SetToolTip(this.btnClose, "Salir Despacho Materia Prima");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.checkBox1);
            this.grpbFilters.Controls.Add(this.chkUser);
            this.grpbFilters.Controls.Add(this.grpbUser);
            this.grpbFilters.Controls.Add(this.chbxStatus);
            this.grpbFilters.Controls.Add(this.grpbStatus);
            this.grpbFilters.Controls.Add(this.grpbRm);
            this.grpbFilters.Controls.Add(this.chkRMTFilter);
            this.grpbFilters.Controls.Add(this.grpbRmt);
            this.grpbFilters.Controls.Add(this.chkCustomerFilter);
            this.grpbFilters.Controls.Add(this.chkDateFilter);
            this.grpbFilters.Controls.Add(this.grpbProviders);
            this.grpbFilters.Controls.Add(this.grpbDates);
            this.grpbFilters.Location = new System.Drawing.Point(1, 330);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(1003, 141);
            this.grpbFilters.TabIndex = 14;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(477, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Materia Prima";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkUser
            // 
            this.chkUser.AutoSize = true;
            this.chkUser.Location = new System.Drawing.Point(700, 78);
            this.chkUser.Name = "chkUser";
            this.chkUser.Size = new System.Drawing.Size(106, 17);
            this.chkUser.TabIndex = 10;
            this.chkUser.Text = "Despachado Por";
            this.chkUser.UseVisualStyleBackColor = true;
            this.chkUser.CheckedChanged += new System.EventHandler(this.chkUser_CheckedChanged);
            // 
            // grpbUser
            // 
            this.grpbUser.Controls.Add(this.cmbUser);
            this.grpbUser.Controls.Add(this.lblUser);
            this.grpbUser.Enabled = false;
            this.grpbUser.Location = new System.Drawing.Point(690, 78);
            this.grpbUser.Name = "grpbUser";
            this.grpbUser.Size = new System.Drawing.Size(284, 53);
            this.grpbUser.TabIndex = 9;
            this.grpbUser.TabStop = false;
            // 
            // cmbUser
            // 
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(59, 22);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(201, 23);
            this.cmbUser.TabIndex = 1;
            this.cmbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbUser_KeyDown);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(5, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Usuario";
            // 
            // chbxStatus
            // 
            this.chbxStatus.AutoSize = true;
            this.chbxStatus.Location = new System.Drawing.Point(700, 18);
            this.chbxStatus.Name = "chbxStatus";
            this.chbxStatus.Size = new System.Drawing.Size(63, 17);
            this.chbxStatus.TabIndex = 8;
            this.chbxStatus.Text = "Bodega";
            this.chbxStatus.UseVisualStyleBackColor = true;
            this.chbxStatus.CheckedChanged += new System.EventHandler(this.chbxStatus_CheckedChanged);
            // 
            // grpbStatus
            // 
            this.grpbStatus.Controls.Add(this.cmbStatus);
            this.grpbStatus.Controls.Add(this.lblStatus);
            this.grpbStatus.Enabled = false;
            this.grpbStatus.Location = new System.Drawing.Point(690, 21);
            this.grpbStatus.Name = "grpbStatus";
            this.grpbStatus.Size = new System.Drawing.Size(284, 53);
            this.grpbStatus.TabIndex = 7;
            this.grpbStatus.TabStop = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(59, 20);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(201, 23);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Nombre";
            // 
            // grpbRm
            // 
            this.grpbRm.Controls.Add(this.cmbRm);
            this.grpbRm.Controls.Add(this.lblRm);
            this.grpbRm.Enabled = false;
            this.grpbRm.Location = new System.Drawing.Point(468, 79);
            this.grpbRm.Name = "grpbRm";
            this.grpbRm.Size = new System.Drawing.Size(203, 53);
            this.grpbRm.TabIndex = 6;
            this.grpbRm.TabStop = false;
            // 
            // cmbRm
            // 
            this.cmbRm.FormattingEnabled = true;
            this.cmbRm.Location = new System.Drawing.Point(59, 21);
            this.cmbRm.Name = "cmbRm";
            this.cmbRm.Size = new System.Drawing.Size(132, 23);
            this.cmbRm.TabIndex = 1;
            this.cmbRm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRm_KeyDown);
            // 
            // lblRm
            // 
            this.lblRm.AutoSize = true;
            this.lblRm.Location = new System.Drawing.Point(5, 25);
            this.lblRm.Name = "lblRm";
            this.lblRm.Size = new System.Drawing.Size(52, 15);
            this.lblRm.TabIndex = 0;
            this.lblRm.Text = "Nombre";
            // 
            // chkRMTFilter
            // 
            this.chkRMTFilter.AutoSize = true;
            this.chkRMTFilter.Location = new System.Drawing.Point(478, 17);
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
            this.grpbRmt.Location = new System.Drawing.Point(468, 21);
            this.grpbRmt.Name = "grpbRmt";
            this.grpbRmt.Size = new System.Drawing.Size(203, 53);
            this.grpbRmt.TabIndex = 4;
            this.grpbRmt.TabStop = false;
            // 
            // cmbRmt
            // 
            this.cmbRmt.FormattingEnabled = true;
            this.cmbRmt.Location = new System.Drawing.Point(59, 21);
            this.cmbRmt.Name = "cmbRmt";
            this.cmbRmt.Size = new System.Drawing.Size(132, 23);
            this.cmbRmt.TabIndex = 1;
            this.cmbRmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRmt_KeyDown);
            // 
            // lblRmt
            // 
            this.lblRmt.AutoSize = true;
            this.lblRmt.Location = new System.Drawing.Point(5, 25);
            this.lblRmt.Name = "lblRmt";
            this.lblRmt.Size = new System.Drawing.Size(52, 15);
            this.lblRmt.TabIndex = 0;
            this.lblRmt.Text = "Nombre";
            // 
            // chkCustomerFilter
            // 
            this.chkCustomerFilter.AutoSize = true;
            this.chkCustomerFilter.Location = new System.Drawing.Point(259, 18);
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
            this.chkDateFilter.Location = new System.Drawing.Point(16, 18);
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
            this.grpbProviders.Location = new System.Drawing.Point(249, 21);
            this.grpbProviders.Name = "grpbProviders";
            this.grpbProviders.Size = new System.Drawing.Size(203, 111);
            this.grpbProviders.TabIndex = 2;
            this.grpbProviders.TabStop = false;
            // 
            // txtProviderId
            // 
            this.txtProviderId.Location = new System.Drawing.Point(59, 66);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(132, 21);
            this.txtProviderId.TabIndex = 3;
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(59, 25);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(132, 23);
            this.cmbProvider.TabIndex = 1;
            this.cmbProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProvider_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 71);
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
            this.grpbDates.Location = new System.Drawing.Point(7, 21);
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
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvDetail);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(1012, 300);
            this.grpbList.TabIndex = 13;
            this.grpbList.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(505, 306);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(90, 21);
            this.txtTotal.TabIndex = 1;
            // 
            // frmDeliverRawMaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1012, 531);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbFilterActions);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeliverRawMaterialList";
            this.Text = "Lista Despachos Materia Prima";
            this.Load += new System.EventHandler(this.frmDeliverRawMaterialList_Load);
            this.grpbFilterActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbUser.ResumeLayout(false);
            this.grpbUser.PerformLayout();
            this.grpbStatus.ResumeLayout(false);
            this.grpbStatus.PerformLayout();
            this.grpbRm.ResumeLayout(false);
            this.grpbRm.PerformLayout();
            this.grpbRmt.ResumeLayout(false);
            this.grpbRmt.PerformLayout();
            this.grpbProviders.ResumeLayout(false);
            this.grpbProviders.PerformLayout();
            this.grpbDates.ResumeLayout(false);
            this.grpbDates.PerformLayout();
            this.grpbList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox chkUser;
        private System.Windows.Forms.GroupBox grpbUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.CheckBox chbxStatus;
        private System.Windows.Forms.GroupBox grpbStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpbRm;
        private System.Windows.Forms.ComboBox cmbRm;
        private System.Windows.Forms.Label lblRm;
        private System.Windows.Forms.CheckBox chkRMTFilter;
        private System.Windows.Forms.GroupBox grpbRmt;
        private System.Windows.Forms.ComboBox cmbRmt;
        private System.Windows.Forms.Label lblRmt;
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
        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialReceptionCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ToolTip ttpDeliverRawMaterial;
    }
}