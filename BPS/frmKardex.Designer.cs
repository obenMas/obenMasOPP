namespace BPS
{
    partial class frmKardex
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
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEntityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantityIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantityOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.chkRMNameFilter = new System.Windows.Forms.CheckBox();
            this.chkRMCodeFilter = new System.Windows.Forms.CheckBox();
            this.grpbRmC = new System.Windows.Forms.GroupBox();
            this.cmbRMCode = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.chkRMCellarFilter = new System.Windows.Forms.CheckBox();
            this.grpbCellar = new System.Windows.Forms.GroupBox();
            this.cmbRMCellar = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpbRmN = new System.Windows.Forms.GroupBox();
            this.cmbRMName = new System.Windows.Forms.ComboBox();
            this.lblRmn = new System.Windows.Forms.Label();
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
            this.ttpKardex = new System.Windows.Forms.ToolTip(this.components);
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbFilterActions.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.grpbFilters.SuspendLayout();
            this.grpbRmC.SuspendLayout();
            this.grpbCellar.SuspendLayout();
            this.grpbRmN.SuspendLayout();
            this.grpbRmt.SuspendLayout();
            this.grpbProviders.SuspendLayout();
            this.grpbDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetail.Location = new System.Drawing.Point(0, 0);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(990, 247);
            this.grpbDetail.TabIndex = 0;
            this.grpbDetail.TabStop = false;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.AllowUserToOrderColumns = true;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmEntityName,
            this.clmRawMaterialType,
            this.clmRawMaterialName,
            this.clmRawMaterialCode,
            this.clmCellarName,
            this.clmQuantityIn,
            this.clmQuantityOut,
            this.clmBalance,
            this.clmCost,
            this.clmQuote,
            this.clmDescription,
            this.clmDate});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(984, 219);
            this.dgvDetail.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 40;
            // 
            // clmEntityName
            // 
            this.clmEntityName.HeaderText = "Proveedor";
            this.clmEntityName.Name = "clmEntityName";
            this.clmEntityName.ReadOnly = true;
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Nombre M.P.";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código M.P.";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            // 
            // clmCellarName
            // 
            this.clmCellarName.HeaderText = "Bodega";
            this.clmCellarName.Name = "clmCellarName";
            this.clmCellarName.ReadOnly = true;
            // 
            // clmQuantityIn
            // 
            this.clmQuantityIn.HeaderText = "Cantidad Ingreso";
            this.clmQuantityIn.Name = "clmQuantityIn";
            this.clmQuantityIn.ReadOnly = true;
            // 
            // clmQuantityOut
            // 
            this.clmQuantityOut.HeaderText = "Cantidad Salida";
            this.clmQuantityOut.Name = "clmQuantityOut";
            this.clmQuantityOut.ReadOnly = true;
            // 
            // clmBalance
            // 
            this.clmBalance.HeaderText = "Balance";
            this.clmBalance.Name = "clmBalance";
            this.clmBalance.ReadOnly = true;
            this.clmBalance.Width = 80;
            // 
            // clmCost
            // 
            this.clmCost.HeaderText = "Costo";
            this.clmCost.Name = "clmCost";
            this.clmCost.ReadOnly = true;
            this.clmCost.Width = 80;
            // 
            // clmQuote
            // 
            this.clmQuote.HeaderText = "Cotización";
            this.clmQuote.Name = "clmQuote";
            this.clmQuote.ReadOnly = true;
            this.clmQuote.Width = 80;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Observación";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 150;
            // 
            // grpbSearch
            // 
            this.grpbSearch.Location = new System.Drawing.Point(4, 385);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(876, 43);
            this.grpbSearch.TabIndex = 19;
            this.grpbSearch.TabStop = false;
            // 
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Location = new System.Drawing.Point(882, 385);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(65, 43);
            this.grpbFilterActions.TabIndex = 20;
            this.grpbFilterActions.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(33, 10);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(28, 28);
            this.btnFilter.TabIndex = 1;
            this.ttpKardex.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(4, 10);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(28, 28);
            this.btnClearFilters.TabIndex = 0;
            this.ttpKardex.SetToolTip(this.btnClearFilters, "Limpiar Filtros");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(949, 385);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(38, 43);
            this.grpbActions.TabIndex = 21;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(5, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 3;
            this.ttpKardex.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.chkRMNameFilter);
            this.grpbFilters.Controls.Add(this.chkRMCodeFilter);
            this.grpbFilters.Controls.Add(this.grpbRmC);
            this.grpbFilters.Controls.Add(this.chkRMCellarFilter);
            this.grpbFilters.Controls.Add(this.grpbCellar);
            this.grpbFilters.Controls.Add(this.grpbRmN);
            this.grpbFilters.Controls.Add(this.chkRMTFilter);
            this.grpbFilters.Controls.Add(this.grpbRmt);
            this.grpbFilters.Controls.Add(this.chkCustomerFilter);
            this.grpbFilters.Controls.Add(this.chkDateFilter);
            this.grpbFilters.Controls.Add(this.grpbProviders);
            this.grpbFilters.Controls.Add(this.grpbDates);
            this.grpbFilters.Location = new System.Drawing.Point(3, 249);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(984, 137);
            this.grpbFilters.TabIndex = 18;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // chkRMNameFilter
            // 
            this.chkRMNameFilter.AutoSize = true;
            this.chkRMNameFilter.Location = new System.Drawing.Point(497, 77);
            this.chkRMNameFilter.Name = "chkRMNameFilter";
            this.chkRMNameFilter.Size = new System.Drawing.Size(130, 17);
            this.chkRMNameFilter.TabIndex = 10;
            this.chkRMNameFilter.Text = "Nombre Materia Prima";
            this.chkRMNameFilter.UseVisualStyleBackColor = true;
            this.chkRMNameFilter.CheckedChanged += new System.EventHandler(this.chkRMNameFilter_CheckedChanged);
            // 
            // chkRMCodeFilter
            // 
            this.chkRMCodeFilter.AutoSize = true;
            this.chkRMCodeFilter.Location = new System.Drawing.Point(747, 20);
            this.chkRMCodeFilter.Name = "chkRMCodeFilter";
            this.chkRMCodeFilter.Size = new System.Drawing.Size(126, 17);
            this.chkRMCodeFilter.TabIndex = 10;
            this.chkRMCodeFilter.Text = "Código Materia Prima";
            this.chkRMCodeFilter.UseVisualStyleBackColor = true;
            this.chkRMCodeFilter.CheckedChanged += new System.EventHandler(this.chkRMCodeFilter_CheckedChanged);
            // 
            // grpbRmC
            // 
            this.grpbRmC.Controls.Add(this.cmbRMCode);
            this.grpbRmC.Controls.Add(this.lblUser);
            this.grpbRmC.Enabled = false;
            this.grpbRmC.Location = new System.Drawing.Point(732, 21);
            this.grpbRmC.Name = "grpbRmC";
            this.grpbRmC.Size = new System.Drawing.Size(243, 53);
            this.grpbRmC.TabIndex = 9;
            this.grpbRmC.TabStop = false;
            // 
            // cmbRMCode
            // 
            this.cmbRMCode.FormattingEnabled = true;
            this.cmbRMCode.Location = new System.Drawing.Point(59, 22);
            this.cmbRMCode.Name = "cmbRMCode";
            this.cmbRMCode.Size = new System.Drawing.Size(176, 21);
            this.cmbRMCode.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(5, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(40, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Código";
            // 
            // chkRMCellarFilter
            // 
            this.chkRMCellarFilter.AutoSize = true;
            this.chkRMCellarFilter.Location = new System.Drawing.Point(741, 79);
            this.chkRMCellarFilter.Name = "chkRMCellarFilter";
            this.chkRMCellarFilter.Size = new System.Drawing.Size(63, 17);
            this.chkRMCellarFilter.TabIndex = 8;
            this.chkRMCellarFilter.Text = "Bodega";
            this.chkRMCellarFilter.UseVisualStyleBackColor = true;
            this.chkRMCellarFilter.CheckedChanged += new System.EventHandler(this.chkRMCellarFilter_CheckedChanged);
            // 
            // grpbCellar
            // 
            this.grpbCellar.Controls.Add(this.cmbRMCellar);
            this.grpbCellar.Controls.Add(this.lblStatus);
            this.grpbCellar.Enabled = false;
            this.grpbCellar.Location = new System.Drawing.Point(730, 79);
            this.grpbCellar.Name = "grpbCellar";
            this.grpbCellar.Size = new System.Drawing.Size(245, 53);
            this.grpbCellar.TabIndex = 7;
            this.grpbCellar.TabStop = false;
            // 
            // cmbRMCellar
            // 
            this.cmbRMCellar.FormattingEnabled = true;
            this.cmbRMCellar.Location = new System.Drawing.Point(59, 20);
            this.cmbRMCellar.Name = "cmbRMCellar";
            this.cmbRMCellar.Size = new System.Drawing.Size(178, 21);
            this.cmbRMCellar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Nombre";
            // 
            // grpbRmN
            // 
            this.grpbRmN.Controls.Add(this.cmbRMName);
            this.grpbRmN.Controls.Add(this.lblRmn);
            this.grpbRmN.Enabled = false;
            this.grpbRmN.Location = new System.Drawing.Point(487, 79);
            this.grpbRmN.Name = "grpbRmN";
            this.grpbRmN.Size = new System.Drawing.Size(238, 53);
            this.grpbRmN.TabIndex = 6;
            this.grpbRmN.TabStop = false;
            // 
            // cmbRMName
            // 
            this.cmbRMName.FormattingEnabled = true;
            this.cmbRMName.Location = new System.Drawing.Point(59, 21);
            this.cmbRMName.Name = "cmbRMName";
            this.cmbRMName.Size = new System.Drawing.Size(173, 21);
            this.cmbRMName.TabIndex = 1;
            // 
            // lblRmn
            // 
            this.lblRmn.AutoSize = true;
            this.lblRmn.Location = new System.Drawing.Point(5, 25);
            this.lblRmn.Name = "lblRmn";
            this.lblRmn.Size = new System.Drawing.Size(44, 13);
            this.lblRmn.TabIndex = 0;
            this.lblRmn.Text = "Nombre";
            // 
            // chkRMTFilter
            // 
            this.chkRMTFilter.AutoSize = true;
            this.chkRMTFilter.Location = new System.Drawing.Point(498, 17);
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
            this.grpbRmt.Location = new System.Drawing.Point(487, 21);
            this.grpbRmt.Name = "grpbRmt";
            this.grpbRmt.Size = new System.Drawing.Size(238, 53);
            this.grpbRmt.TabIndex = 4;
            this.grpbRmt.TabStop = false;
            // 
            // cmbRmt
            // 
            this.cmbRmt.FormattingEnabled = true;
            this.cmbRmt.Location = new System.Drawing.Point(59, 21);
            this.cmbRmt.Name = "cmbRmt";
            this.cmbRmt.Size = new System.Drawing.Size(173, 21);
            this.cmbRmt.TabIndex = 1;
            // 
            // lblRmt
            // 
            this.lblRmt.AutoSize = true;
            this.lblRmt.Location = new System.Drawing.Point(5, 25);
            this.lblRmt.Name = "lblRmt";
            this.lblRmt.Size = new System.Drawing.Size(44, 13);
            this.lblRmt.TabIndex = 0;
            this.lblRmt.Text = "Nombre";
            // 
            // chkCustomerFilter
            // 
            this.chkCustomerFilter.AutoSize = true;
            this.chkCustomerFilter.Location = new System.Drawing.Point(263, 18);
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
            // 
            // grpbProviders
            // 
            this.grpbProviders.Controls.Add(this.txtProviderId);
            this.grpbProviders.Controls.Add(this.cmbProvider);
            this.grpbProviders.Controls.Add(this.lblName);
            this.grpbProviders.Controls.Add(this.lblId);
            this.grpbProviders.Enabled = false;
            this.grpbProviders.Location = new System.Drawing.Point(250, 21);
            this.grpbProviders.Name = "grpbProviders";
            this.grpbProviders.Size = new System.Drawing.Size(232, 111);
            this.grpbProviders.TabIndex = 2;
            this.grpbProviders.TabStop = false;
            // 
            // txtProviderId
            // 
            this.txtProviderId.Location = new System.Drawing.Point(59, 66);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(167, 20);
            this.txtProviderId.TabIndex = 3;
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(59, 25);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(167, 21);
            this.cmbProvider.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(5, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
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
            this.grpbDates.Size = new System.Drawing.Size(236, 110);
            this.grpbDates.TabIndex = 0;
            this.grpbDates.TabStop = false;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(76, 70);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(154, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(13, 30);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Desde";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(76, 26);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(154, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(15, 75);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 13);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Hasta";
            // 
            // frmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 430);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbFilterActions);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbDetail);
            this.Name = "frmKardex";
            this.Text = "Kardex Materia Prima";
            this.Load += new System.EventHandler(this.frmKardex_Load);
            this.grpbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbFilterActions.ResumeLayout(false);
            this.grpbActions.ResumeLayout(false);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbRmC.ResumeLayout(false);
            this.grpbRmC.PerformLayout();
            this.grpbCellar.ResumeLayout(false);
            this.grpbCellar.PerformLayout();
            this.grpbRmN.ResumeLayout(false);
            this.grpbRmN.PerformLayout();
            this.grpbRmt.ResumeLayout(false);
            this.grpbRmt.PerformLayout();
            this.grpbProviders.ResumeLayout(false);
            this.grpbProviders.PerformLayout();
            this.grpbDates.ResumeLayout(false);
            this.grpbDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEntityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantityIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantityOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.CheckBox chkRMNameFilter;
        private System.Windows.Forms.CheckBox chkRMCodeFilter;
        private System.Windows.Forms.CheckBox chkRMCellarFilter;
        private System.Windows.Forms.GroupBox grpbCellar;
        private System.Windows.Forms.ComboBox cmbRMCellar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpbRmN;
        private System.Windows.Forms.ComboBox cmbRMName;
        private System.Windows.Forms.Label lblRmn;
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
        private System.Windows.Forms.GroupBox grpbRmC;
        private System.Windows.Forms.ComboBox cmbRMCode;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolTip ttpKardex;
    }
}