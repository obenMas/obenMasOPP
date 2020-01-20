namespace BPS
{
    partial class frmPurchaseOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrderList));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.chkNumberFilter = new System.Windows.Forms.CheckBox();
            this.chkStatusFilter = new System.Windows.Forms.CheckBox();
            this.chkCustomerFilter = new System.Windows.Forms.CheckBox();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.grpbNumber = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberTo = new System.Windows.Forms.TextBox();
            this.lblNumberFrom = new System.Windows.Forms.Label();
            this.txtNumberFrom = new System.Windows.Forms.TextBox();
            this.grpbStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
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
            this.dgvPurchaseOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProviderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.ttpPurcharse = new System.Windows.Forms.ToolTip(this.components);
            this.grpbFilters.SuspendLayout();
            this.grpbNumber.SuspendLayout();
            this.grpbStatus.SuspendLayout();
            this.grpbProviders.SuspendLayout();
            this.grpbDates.SuspendLayout();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.grpbFilterActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.chkNumberFilter);
            this.grpbFilters.Controls.Add(this.chkStatusFilter);
            this.grpbFilters.Controls.Add(this.chkCustomerFilter);
            this.grpbFilters.Controls.Add(this.chkDateFilter);
            this.grpbFilters.Controls.Add(this.grpbNumber);
            this.grpbFilters.Controls.Add(this.grpbStatus);
            this.grpbFilters.Controls.Add(this.grpbProviders);
            this.grpbFilters.Controls.Add(this.grpbDates);
            this.grpbFilters.Location = new System.Drawing.Point(0, 247);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(805, 106);
            this.grpbFilters.TabIndex = 6;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // chkNumberFilter
            // 
            this.chkNumberFilter.AutoSize = true;
            this.chkNumberFilter.Location = new System.Drawing.Point(180, 23);
            this.chkNumberFilter.Name = "chkNumberFilter";
            this.chkNumberFilter.Size = new System.Drawing.Size(83, 17);
            this.chkNumberFilter.TabIndex = 1;
            this.chkNumberFilter.Text = "Numeración";
            this.chkNumberFilter.UseVisualStyleBackColor = true;
            this.chkNumberFilter.CheckedChanged += new System.EventHandler(this.chkNumberFilter_CheckedChanged);
            // 
            // chkStatusFilter
            // 
            this.chkStatusFilter.AutoSize = true;
            this.chkStatusFilter.Location = new System.Drawing.Point(643, 23);
            this.chkStatusFilter.Name = "chkStatusFilter";
            this.chkStatusFilter.Size = new System.Drawing.Size(59, 17);
            this.chkStatusFilter.TabIndex = 3;
            this.chkStatusFilter.Text = "Estado";
            this.chkStatusFilter.UseVisualStyleBackColor = true;
            this.chkStatusFilter.CheckedChanged += new System.EventHandler(this.chkStatusFilter_CheckedChanged);
            // 
            // chkCustomerFilter
            // 
            this.chkCustomerFilter.AutoSize = true;
            this.chkCustomerFilter.Location = new System.Drawing.Point(381, 23);
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
            this.chkDateFilter.Location = new System.Drawing.Point(12, 23);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(61, 17);
            this.chkDateFilter.TabIndex = 0;
            this.chkDateFilter.Text = "Fechas";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.chkDateFilter_CheckedChanged);
            // 
            // grpbNumber
            // 
            this.grpbNumber.Controls.Add(this.label1);
            this.grpbNumber.Controls.Add(this.txtNumberTo);
            this.grpbNumber.Controls.Add(this.lblNumberFrom);
            this.grpbNumber.Controls.Add(this.txtNumberFrom);
            this.grpbNumber.Enabled = false;
            this.grpbNumber.Location = new System.Drawing.Point(173, 26);
            this.grpbNumber.Name = "grpbNumber";
            this.grpbNumber.Size = new System.Drawing.Size(200, 72);
            this.grpbNumber.TabIndex = 1;
            this.grpbNumber.TabStop = false;
            this.grpbNumber.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta";
            // 
            // txtNumberTo
            // 
            this.txtNumberTo.Location = new System.Drawing.Point(79, 46);
            this.txtNumberTo.Name = "txtNumberTo";
            this.txtNumberTo.Size = new System.Drawing.Size(108, 21);
            this.txtNumberTo.TabIndex = 3;
            // 
            // lblNumberFrom
            // 
            this.lblNumberFrom.AutoSize = true;
            this.lblNumberFrom.Location = new System.Drawing.Point(21, 22);
            this.lblNumberFrom.Name = "lblNumberFrom";
            this.lblNumberFrom.Size = new System.Drawing.Size(43, 15);
            this.lblNumberFrom.TabIndex = 0;
            this.lblNumberFrom.Text = "Desde";
            // 
            // txtNumberFrom
            // 
            this.txtNumberFrom.Location = new System.Drawing.Point(79, 19);
            this.txtNumberFrom.Name = "txtNumberFrom";
            this.txtNumberFrom.Size = new System.Drawing.Size(108, 21);
            this.txtNumberFrom.TabIndex = 1;
            // 
            // grpbStatus
            // 
            this.grpbStatus.Controls.Add(this.lblStatus);
            this.grpbStatus.Controls.Add(this.cmbStatus);
            this.grpbStatus.Enabled = false;
            this.grpbStatus.Location = new System.Drawing.Point(636, 26);
            this.grpbStatus.Name = "grpbStatus";
            this.grpbStatus.Size = new System.Drawing.Size(165, 72);
            this.grpbStatus.TabIndex = 3;
            this.grpbStatus.TabStop = false;
            this.grpbStatus.Text = "Estado";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(5, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Estado";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(53, 29);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(108, 23);
            this.cmbStatus.TabIndex = 1;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // grpbProviders
            // 
            this.grpbProviders.Controls.Add(this.txtProviderId);
            this.grpbProviders.Controls.Add(this.cmbProvider);
            this.grpbProviders.Controls.Add(this.lblName);
            this.grpbProviders.Controls.Add(this.lblId);
            this.grpbProviders.Enabled = false;
            this.grpbProviders.Location = new System.Drawing.Point(374, 26);
            this.grpbProviders.Name = "grpbProviders";
            this.grpbProviders.Size = new System.Drawing.Size(260, 72);
            this.grpbProviders.TabIndex = 2;
            this.grpbProviders.TabStop = false;
            this.grpbProviders.Text = "Cliente";
            // 
            // txtProviderId
            // 
            this.txtProviderId.Location = new System.Drawing.Point(61, 46);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(191, 21);
            this.txtProviderId.TabIndex = 3;
            // 
            // cmbProvider
            // 
            this.cmbProvider.FormattingEnabled = true;
            this.cmbProvider.Location = new System.Drawing.Point(61, 19);
            this.cmbProvider.Name = "cmbProvider";
            this.cmbProvider.Size = new System.Drawing.Size(191, 23);
            this.cmbProvider.TabIndex = 1;
            this.cmbProvider.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProvider_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(10, 49);
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
            this.grpbDates.Location = new System.Drawing.Point(5, 26);
            this.grpbDates.Name = "grpbDates";
            this.grpbDates.Size = new System.Drawing.Size(166, 72);
            this.grpbDates.TabIndex = 0;
            this.grpbDates.TabStop = false;
            this.grpbDates.Text = "Fechas";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(61, 46);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(99, 21);
            this.dtpTo.TabIndex = 3;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 15);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Desde";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(61, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(99, 21);
            this.dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(16, 49);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(39, 15);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "Hasta";
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvPurchaseOrder);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(805, 248);
            this.grpbList.TabIndex = 5;
            this.grpbList.TabStop = false;
            // 
            // dgvPurchaseOrder
            // 
            this.dgvPurchaseOrder.AllowUserToAddRows = false;
            this.dgvPurchaseOrder.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrder.AllowUserToOrderColumns = true;
            this.dgvPurchaseOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmDate,
            this.clmNumber,
            this.clmProviderId,
            this.clmProveedor,
            this.clmStatus});
            this.dgvPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvPurchaseOrder.Name = "dgvPurchaseOrder";
            this.dgvPurchaseOrder.ReadOnly = true;
            this.dgvPurchaseOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrder.Size = new System.Drawing.Size(799, 228);
            this.dgvPurchaseOrder.TabIndex = 0;
            this.dgvPurchaseOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrder_CellDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Número";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmProviderId
            // 
            this.clmProviderId.HeaderText = "Id Proveedor";
            this.clmProviderId.Name = "clmProviderId";
            this.clmProviderId.ReadOnly = true;
            // 
            // clmProveedor
            // 
            this.clmProveedor.HeaderText = "Proveedor";
            this.clmProveedor.Name = "clmProveedor";
            this.clmProveedor.ReadOnly = true;
            this.clmProveedor.Width = 350;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // grpbSearch
            // 
            this.grpbSearch.Location = new System.Drawing.Point(0, 349);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(623, 43);
            this.grpbSearch.TabIndex = 7;
            this.grpbSearch.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnAdd);
            this.grpbActions.Controls.Add(this.btnViewDetail);
            this.grpbActions.Controls.Add(this.btnEditCompany);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(690, 349);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(115, 43);
            this.grpbActions.TabIndex = 9;
            this.grpbActions.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(7, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 0;
            this.ttpPurcharse.SetToolTip(this.btnAdd, "Agregar Ordenes de Compras");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(32, 13);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 1;
            this.ttpPurcharse.SetToolTip(this.btnViewDetail, "Ver Detalles Ordenes de Compras");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(57, 13);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 2;
            this.ttpPurcharse.SetToolTip(this.btnEditCompany, "Editar Ordenes de Compras");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(82, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpPurcharse.SetToolTip(this.btnClose, "Salir Ordenes de Compras");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Location = new System.Drawing.Point(626, 349);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(61, 43);
            this.grpbFilterActions.TabIndex = 8;
            this.grpbFilterActions.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(31, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 1;
            this.ttpPurcharse.SetToolTip(this.btnFilter, "Filtrar Ordenes de Compras");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(6, 13);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 0;
            this.ttpPurcharse.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // frmPurchaseOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(805, 393);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.grpbSearch);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilterActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPurchaseOrderList";
            this.Text = "Listado de Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmPurchaseOrderList_Load);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbNumber.ResumeLayout(false);
            this.grpbNumber.PerformLayout();
            this.grpbStatus.ResumeLayout(false);
            this.grpbStatus.PerformLayout();
            this.grpbProviders.ResumeLayout(false);
            this.grpbProviders.PerformLayout();
            this.grpbDates.ResumeLayout(false);
            this.grpbDates.PerformLayout();
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrder)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbFilterActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.CheckBox chkNumberFilter;
        private System.Windows.Forms.CheckBox chkStatusFilter;
        private System.Windows.Forms.CheckBox chkCustomerFilter;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.GroupBox grpbNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberTo;
        private System.Windows.Forms.Label lblNumberFrom;
        private System.Windows.Forms.TextBox txtNumberFrom;
        private System.Windows.Forms.GroupBox grpbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
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
        private System.Windows.Forms.DataGridView dgvPurchaseOrder;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProviderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.ToolTip ttpPurcharse;
    }
}