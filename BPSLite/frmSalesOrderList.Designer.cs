namespace BPS.Lite
{
    partial class frmSalesOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderList));
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrder = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.chkNumberFilter = new System.Windows.Forms.CheckBox();
            this.chkStatusFilter = new System.Windows.Forms.CheckBox();
            this.chkCustomerFilter = new System.Windows.Forms.CheckBox();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.grpbNumber = new System.Windows.Forms.GroupBox();
            this.lblNumberFrom = new System.Windows.Forms.Label();
            this.txtNumberFrom = new System.Windows.Forms.TextBox();
            this.grpbStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.grpbCustomer = new System.Windows.Forms.GroupBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.grpbDates = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.ttpSalesOrderList = new System.Windows.Forms.ToolTip(this.components);
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEditSalesOrder = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmReport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmReportPrice = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmreportmedium = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.grpbFilters.SuspendLayout();
            this.grpbNumber.SuspendLayout();
            this.grpbStatus.SuspendLayout();
            this.grpbCustomer.SuspendLayout();
            this.grpbDates.SuspendLayout();
            this.grpbFilterActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvSalesOrder);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(996, 425);
            this.grpbList.TabIndex = 0;
            this.grpbList.TabStop = false;
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.AllowUserToAddRows = false;
            this.dgvSalesOrder.AllowUserToDeleteRows = false;
            this.dgvSalesOrder.AllowUserToOrderColumns = true;
            this.dgvSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmDate,
            this.clmNumber,
            this.clmCustomerId,
            this.clmCustomer,
            this.clmStatus,
            this.clmEditSalesOrder,
            this.clmReport,
            this.clmReportPrice,
            this.clmreportmedium});
            this.dgvSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.ReadOnly = true;
            this.dgvSalesOrder.RowHeadersWidth = 21;
            this.dgvSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrder.Size = new System.Drawing.Size(990, 405);
            this.dgvSalesOrder.TabIndex = 0;
            this.dgvSalesOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Lite.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(884, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 0;
            this.ttpSalesOrderList.SetToolTip(this.btnAdd, "Agregar Ordenes de Venta Nacionales");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Lite.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(909, 12);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 1;
            this.ttpSalesOrderList.SetToolTip(this.btnViewDetail, "Ver Detalles Ordenes de Venta Nacionales");
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.BackgroundImage = global::BPS.Lite.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(934, 12);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 2;
            this.ttpSalesOrderList.SetToolTip(this.btnEditCompany, "Editar Ordenes de Venta Nacionales");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Lite.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(959, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpSalesOrderList.SetToolTip(this.btnClose, "Salir Ordenes de Venta Nacionales");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.chkNumberFilter);
            this.grpbFilters.Controls.Add(this.chkStatusFilter);
            this.grpbFilters.Controls.Add(this.chkCustomerFilter);
            this.grpbFilters.Controls.Add(this.chkDateFilter);
            this.grpbFilters.Controls.Add(this.grpbNumber);
            this.grpbFilters.Controls.Add(this.grpbStatus);
            this.grpbFilters.Controls.Add(this.grpbCustomer);
            this.grpbFilters.Controls.Add(this.grpbDates);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 425);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(996, 106);
            this.grpbFilters.TabIndex = 1;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // chkNumberFilter
            // 
            this.chkNumberFilter.AutoSize = true;
            this.chkNumberFilter.Location = new System.Drawing.Point(240, 23);
            this.chkNumberFilter.Name = "chkNumberFilter";
            this.chkNumberFilter.Size = new System.Drawing.Size(94, 19);
            this.chkNumberFilter.TabIndex = 1;
            this.chkNumberFilter.Text = "Numeraci?n";
            this.chkNumberFilter.UseVisualStyleBackColor = true;
            this.chkNumberFilter.CheckedChanged += new System.EventHandler(this.chkNumberFilter_CheckedChanged);
            // 
            // chkStatusFilter
            // 
            this.chkStatusFilter.AutoSize = true;
            this.chkStatusFilter.Location = new System.Drawing.Point(808, 23);
            this.chkStatusFilter.Name = "chkStatusFilter";
            this.chkStatusFilter.Size = new System.Drawing.Size(64, 19);
            this.chkStatusFilter.TabIndex = 3;
            this.chkStatusFilter.Text = "Estado";
            this.chkStatusFilter.UseVisualStyleBackColor = true;
            this.chkStatusFilter.CheckedChanged += new System.EventHandler(this.chkStatusFilter_CheckedChanged);
            // 
            // chkCustomerFilter
            // 
            this.chkCustomerFilter.AutoSize = true;
            this.chkCustomerFilter.Location = new System.Drawing.Point(451, 23);
            this.chkCustomerFilter.Name = "chkCustomerFilter";
            this.chkCustomerFilter.Size = new System.Drawing.Size(70, 19);
            this.chkCustomerFilter.TabIndex = 2;
            this.chkCustomerFilter.Text = "Clientes";
            this.chkCustomerFilter.UseVisualStyleBackColor = true;
            this.chkCustomerFilter.CheckedChanged += new System.EventHandler(this.chkCustomerFilter_CheckedChanged);
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(38, 23);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(66, 19);
            this.chkDateFilter.TabIndex = 0;
            this.chkDateFilter.Text = "Fechas";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.chkDateFilter_CheckedChanged);
            // 
            // grpbNumber
            // 
            this.grpbNumber.Controls.Add(this.lblNumberFrom);
            this.grpbNumber.Controls.Add(this.txtNumberFrom);
            this.grpbNumber.Enabled = false;
            this.grpbNumber.Location = new System.Drawing.Point(233, 26);
            this.grpbNumber.Name = "grpbNumber";
            this.grpbNumber.Size = new System.Drawing.Size(205, 72);
            this.grpbNumber.TabIndex = 1;
            this.grpbNumber.TabStop = false;
            this.grpbNumber.Text = "N?mero";
            // 
            // lblNumberFrom
            // 
            this.lblNumberFrom.AutoSize = true;
            this.lblNumberFrom.Location = new System.Drawing.Point(6, 29);
            this.lblNumberFrom.Name = "lblNumberFrom";
            this.lblNumberFrom.Size = new System.Drawing.Size(41, 15);
            this.lblNumberFrom.TabIndex = 0;
            this.lblNumberFrom.Text = "Orden";
            // 
            // txtNumberFrom
            // 
            this.txtNumberFrom.Location = new System.Drawing.Point(53, 26);
            this.txtNumberFrom.Name = "txtNumberFrom";
            this.txtNumberFrom.Size = new System.Drawing.Size(146, 21);
            this.txtNumberFrom.TabIndex = 1;
            this.txtNumberFrom.TextChanged += new System.EventHandler(this.txtNumberFrom_TextChanged);
            // 
            // grpbStatus
            // 
            this.grpbStatus.Controls.Add(this.lblStatus);
            this.grpbStatus.Controls.Add(this.cmbStatus);
            this.grpbStatus.Enabled = false;
            this.grpbStatus.Location = new System.Drawing.Point(801, 26);
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
            // grpbCustomer
            // 
            this.grpbCustomer.Controls.Add(this.txtCustomerId);
            this.grpbCustomer.Controls.Add(this.cmbCustomer);
            this.grpbCustomer.Controls.Add(this.lblName);
            this.grpbCustomer.Controls.Add(this.lblId);
            this.grpbCustomer.Enabled = false;
            this.grpbCustomer.Location = new System.Drawing.Point(444, 26);
            this.grpbCustomer.Name = "grpbCustomer";
            this.grpbCustomer.Size = new System.Drawing.Size(350, 72);
            this.grpbCustomer.TabIndex = 2;
            this.grpbCustomer.TabStop = false;
            this.grpbCustomer.Text = "Cliente";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(64, 46);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(272, 21);
            this.txtCustomerId.TabIndex = 3;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(64, 19);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(272, 23);
            this.cmbCustomer.TabIndex = 1;
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(13, 49);
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
            this.grpbDates.Location = new System.Drawing.Point(31, 26);
            this.grpbDates.Name = "grpbDates";
            this.grpbDates.Size = new System.Drawing.Size(196, 72);
            this.grpbDates.TabIndex = 0;
            this.grpbDates.TabStop = false;
            this.grpbDates.Text = "Fechas";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(61, 46);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(122, 21);
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
            this.dtpFrom.Size = new System.Drawing.Size(122, 21);
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
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnAdd);
            this.grpbFilterActions.Controls.Add(this.btnViewDetail);
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnEditCompany);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Controls.Add(this.btnClose);
            this.grpbFilterActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilterActions.Location = new System.Drawing.Point(0, 531);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(996, 43);
            this.grpbFilterActions.TabIndex = 3;
            this.grpbFilterActions.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Lite.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(843, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 1;
            this.ttpSalesOrderList.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Lite.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(818, 12);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 0;
            this.ttpSalesOrderList.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
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
            this.clmNumber.HeaderText = "N?mero";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmCustomerId
            // 
            this.clmCustomerId.HeaderText = "Id Cliente";
            this.clmCustomerId.Name = "clmCustomerId";
            this.clmCustomerId.ReadOnly = true;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 380;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmEditSalesOrder
            // 
            this.clmEditSalesOrder.HeaderText = "";
            this.clmEditSalesOrder.Name = "clmEditSalesOrder";
            this.clmEditSalesOrder.ReadOnly = true;
            this.clmEditSalesOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEditSalesOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEditSalesOrder.Width = 30;
            // 
            // clmReport
            // 
            this.clmReport.HeaderText = "";
            this.clmReport.Name = "clmReport";
            this.clmReport.ReadOnly = true;
            this.clmReport.Width = 30;
            // 
            // clmReportPrice
            // 
            this.clmReportPrice.HeaderText = "";
            this.clmReportPrice.Name = "clmReportPrice";
            this.clmReportPrice.ReadOnly = true;
            this.clmReportPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmReportPrice.Visible = false;
            this.clmReportPrice.Width = 30;
            // 
            // clmreportmedium
            // 
            this.clmreportmedium.HeaderText = "";
            this.clmreportmedium.Name = "clmreportmedium";
            this.clmreportmedium.ReadOnly = true;
            this.clmreportmedium.Width = 30;
            // 
            // frmSalesOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(996, 574);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbFilterActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderList";
            this.Text = "Listado de Ordenes de Venta Nacionales";
            this.Load += new System.EventHandler(this.frmSalesOrderList_Load);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbNumber.ResumeLayout(false);
            this.grpbNumber.PerformLayout();
            this.grpbStatus.ResumeLayout(false);
            this.grpbStatus.PerformLayout();
            this.grpbCustomer.ResumeLayout(false);
            this.grpbCustomer.PerformLayout();
            this.grpbDates.ResumeLayout(false);
            this.grpbDates.PerformLayout();
            this.grpbFilterActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvSalesOrder;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.GroupBox grpbDates;
        private System.Windows.Forms.GroupBox grpbCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.GroupBox grpbStatus;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtNumberFrom;
        private System.Windows.Forms.Label lblNumberFrom;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.GroupBox grpbNumber;
        private System.Windows.Forms.CheckBox chkNumberFilter;
        private System.Windows.Forms.CheckBox chkStatusFilter;
        private System.Windows.Forms.CheckBox chkCustomerFilter;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.ToolTip ttpSalesOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmEditSalesOrder;
        private System.Windows.Forms.DataGridViewImageColumn clmReport;
        private System.Windows.Forms.DataGridViewImageColumn clmReportPrice;
        private System.Windows.Forms.DataGridViewImageColumn clmreportmedium;

    }
}