namespace BPS
{
    partial class frmSalesOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpbSalesOrder = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPurchaseOrder = new System.Windows.Forms.TextBox();
            this.dtpCompromiseDate = new System.Windows.Forms.DateTimePicker();
            this.lblCompromiseDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.grpbCustomer = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.txtTotalPesos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalWeigth = new System.Windows.Forms.TextBox();
            this.lblTotalWeith = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExchangeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubtotalPesos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDuplicate = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.ttpSalesOrderForm = new System.Windows.Forms.ToolTip(this.components);
            this.grpbSalesOrder.SuspendLayout();
            this.grpbCustomer.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.grpbFilters.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbSalesOrder
            // 
            this.grpbSalesOrder.Controls.Add(this.label1);
            this.grpbSalesOrder.Controls.Add(this.txtPurchaseOrder);
            this.grpbSalesOrder.Controls.Add(this.dtpCompromiseDate);
            this.grpbSalesOrder.Controls.Add(this.lblCompromiseDate);
            this.grpbSalesOrder.Controls.Add(this.dtpDate);
            this.grpbSalesOrder.Controls.Add(this.lblDate);
            this.grpbSalesOrder.Controls.Add(this.cmbStatus);
            this.grpbSalesOrder.Controls.Add(this.lblStatus);
            this.grpbSalesOrder.Controls.Add(this.txtNumber);
            this.grpbSalesOrder.Controls.Add(this.lblNumber);
            this.grpbSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbSalesOrder.Name = "grpbSalesOrder";
            this.grpbSalesOrder.Size = new System.Drawing.Size(990, 46);
            this.grpbSalesOrder.TabIndex = 0;
            this.grpbSalesOrder.TabStop = false;
            this.grpbSalesOrder.Text = "Orden de Venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orden de Compra";
            // 
            // txtPurchaseOrder
            // 
            this.txtPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseOrder.Location = new System.Drawing.Point(670, 15);
            this.txtPurchaseOrder.Name = "txtPurchaseOrder";
            this.txtPurchaseOrder.Size = new System.Drawing.Size(100, 24);
            this.txtPurchaseOrder.TabIndex = 7;
            // 
            // dtpCompromiseDate
            // 
            this.dtpCompromiseDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCompromiseDate.Location = new System.Drawing.Point(861, 15);
            this.dtpCompromiseDate.Name = "dtpCompromiseDate";
            this.dtpCompromiseDate.Size = new System.Drawing.Size(109, 21);
            this.dtpCompromiseDate.TabIndex = 9;
            // 
            // lblCompromiseDate
            // 
            this.lblCompromiseDate.AutoSize = true;
            this.lblCompromiseDate.Location = new System.Drawing.Point(791, 18);
            this.lblCompromiseDate.Name = "lblCompromiseDate";
            this.lblCompromiseDate.Size = new System.Drawing.Size(60, 15);
            this.lblCompromiseDate.TabIndex = 8;
            this.lblCompromiseDate.Text = "F.Entrega";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(232, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(118, 21);
            this.dtpDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(185, 18);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(407, 15);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(356, 18);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Estado";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(79, 15);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 24);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(21, 18);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Número";
            // 
            // grpbCustomer
            // 
            this.grpbCustomer.Controls.Add(this.button1);
            this.grpbCustomer.Controls.Add(this.txtCustomerAddress);
            this.grpbCustomer.Controls.Add(this.lblAddress);
            this.grpbCustomer.Controls.Add(this.txtCustomerCountry);
            this.grpbCustomer.Controls.Add(this.lblCountry);
            this.grpbCustomer.Controls.Add(this.btnSearchCustomer);
            this.grpbCustomer.Controls.Add(this.txtCustomerName);
            this.grpbCustomer.Controls.Add(this.lblCustomerName);
            this.grpbCustomer.Controls.Add(this.txtCustomerId);
            this.grpbCustomer.Controls.Add(this.lblCustomerId);
            this.grpbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCustomer.Location = new System.Drawing.Point(0, 46);
            this.grpbCustomer.Name = "grpbCustomer";
            this.grpbCustomer.Size = new System.Drawing.Size(990, 75);
            this.grpbCustomer.TabIndex = 1;
            this.grpbCustomer.TabStop = false;
            this.grpbCustomer.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(884, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Agregar Producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Enabled = false;
            this.txtCustomerAddress.Location = new System.Drawing.Point(420, 42);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(443, 21);
            this.txtCustomerAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(362, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 15);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Dirección";
            // 
            // txtCustomerCountry
            // 
            this.txtCustomerCountry.Enabled = false;
            this.txtCustomerCountry.Location = new System.Drawing.Point(225, 42);
            this.txtCustomerCountry.Name = "txtCustomerCountry";
            this.txtCustomerCountry.Size = new System.Drawing.Size(131, 21);
            this.txtCustomerCountry.TabIndex = 6;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(133, 45);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(86, 15);
            this.lblCountry.TabIndex = 25;
            this.lblCountry.Text = "País de origen";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackgroundImage = global::BPS.Properties.Resources.magnifier;
            this.btnSearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchCustomer.Location = new System.Drawing.Point(331, 12);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(25, 25);
            this.btnSearchCustomer.TabIndex = 24;
            this.ttpSalesOrderForm.SetToolTip(this.btnSearchCustomer, "Buscar Cliente");
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Enabled = false;
            this.txtCustomerName.Location = new System.Drawing.Point(420, 14);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(443, 21);
            this.txtCustomerName.TabIndex = 5;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(362, 17);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 15);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Nombre";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(225, 14);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 21);
            this.txtCustomerId.TabIndex = 4;
            this.txtCustomerId.Leave += new System.EventHandler(this.txtCustomerCode_Leave);
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(133, 17);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(79, 15);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "Identificación";
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActions.Location = new System.Drawing.Point(0, 527);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(990, 43);
            this.grpbActions.TabIndex = 5;
            this.grpbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(909, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 10;
            this.ttpSalesOrderForm.SetToolTip(this.btnSave, "Guardar Orden de Venta");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(934, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 2;
            this.ttpSalesOrderForm.SetToolTip(this.btnCancel, "Cancelar Orden de Venta");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(959, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpSalesOrderForm.SetToolTip(this.btnClose, "Salir Orden de Venta");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.txtTotalPesos);
            this.grpbFilters.Controls.Add(this.label2);
            this.grpbFilters.Controls.Add(this.txtNotes);
            this.grpbFilters.Controls.Add(this.txtTotal);
            this.grpbFilters.Controls.Add(this.txtTotalWeigth);
            this.grpbFilters.Controls.Add(this.lblTotalWeith);
            this.grpbFilters.Controls.Add(this.lblTotal);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 453);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(990, 74);
            this.grpbFilters.TabIndex = 9;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Notas";
            // 
            // txtTotalPesos
            // 
            this.txtTotalPesos.Location = new System.Drawing.Point(861, 17);
            this.txtTotalPesos.Name = "txtTotalPesos";
            this.txtTotalPesos.Size = new System.Drawing.Size(100, 21);
            this.txtTotalPesos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(797, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total $AR";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(12, 17);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(541, 48);
            this.txtNotes.TabIndex = 9;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(861, 44);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 5;
            // 
            // txtTotalWeigth
            // 
            this.txtTotalWeigth.Enabled = false;
            this.txtTotalWeigth.Location = new System.Drawing.Point(666, 44);
            this.txtTotalWeigth.Name = "txtTotalWeigth";
            this.txtTotalWeigth.Size = new System.Drawing.Size(100, 21);
            this.txtTotalWeigth.TabIndex = 3;
            // 
            // lblTotalWeith
            // 
            this.lblTotalWeith.AutoSize = true;
            this.lblTotalWeith.Location = new System.Drawing.Point(604, 47);
            this.lblTotalWeith.Name = "lblTotalWeith";
            this.lblTotalWeith.Size = new System.Drawing.Size(60, 15);
            this.lblTotalWeith.TabIndex = 2;
            this.lblTotalWeith.Text = "Total (Kg)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(797, 47);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(63, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total USD";
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Location = new System.Drawing.Point(0, 121);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(990, 332);
            this.grpbDetail.TabIndex = 2;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmProductCodsec,
            this.clmProductCode,
            this.clmProductName,
            this.clmQuantity,
            this.clmPrice,
            this.clmExchangeRate,
            this.clmStock,
            this.clmSubTotal,
            this.clmSubtotalPesos,
            this.clmStatus,
            this.clmDuplicate,
            this.clmDelete});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(984, 312);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            this.dgvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellDoubleClick);
            this.dgvDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDetail_CellValidating);
            this.dgvDetail.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellValueChanged);
            this.dgvDetail.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetail_DefaultValuesNeeded);
            this.dgvDetail.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetail_UserAddedRow);
            this.dgvDetail.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDetail_UserDeletingRow);
            this.dgvDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetail_KeyDown);
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
            this.clmProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductCode.Width = 110;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductName.Width = 250;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQuantity.Width = 80;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPrice.Width = 50;
            // 
            // clmExchangeRate
            // 
            this.clmExchangeRate.HeaderText = "Tipo de cambio";
            this.clmExchangeRate.Name = "clmExchangeRate";
            this.clmExchangeRate.Width = 70;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            // 
            // clmSubTotal
            // 
            this.clmSubTotal.HeaderText = "Subtotal USD";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            this.clmSubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSubTotal.Width = 80;
            // 
            // clmSubtotalPesos
            // 
            this.clmSubtotalPesos.HeaderText = "Subtotal $AR";
            this.clmSubtotalPesos.Name = "clmSubtotalPesos";
            this.clmSubtotalPesos.Width = 80;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Visible = false;
            // 
            // clmDuplicate
            // 
            this.clmDuplicate.HeaderText = "Duplicar";
            this.clmDuplicate.Name = "clmDuplicate";
            this.clmDuplicate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDuplicate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmDuplicate.Width = 60;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "Eliminar";
            this.clmDelete.Image = global::BPS.Properties.Resources.cross;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Width = 60;
            // 
            // frmSalesOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(990, 570);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbCustomer);
            this.Controls.Add(this.grpbSalesOrder);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderForm";
            this.Text = "Orden de Venta Nacionales";
            this.Load += new System.EventHandler(this.frmSalesOrderForm_Load);
            this.grpbSalesOrder.ResumeLayout(false);
            this.grpbSalesOrder.PerformLayout();
            this.grpbCustomer.ResumeLayout(false);
            this.grpbCustomer.PerformLayout();
            this.grpbActions.ResumeLayout(false);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbSalesOrder;
        private System.Windows.Forms.GroupBox grpbCustomer;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalWeigth;
        private System.Windows.Forms.Label lblTotalWeith;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolTip ttpSalesOrderForm;
        private System.Windows.Forms.DateTimePicker dtpCompromiseDate;
        private System.Windows.Forms.Label lblCompromiseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPurchaseOrder;
        private System.Windows.Forms.TextBox txtTotalPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExchangeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubtotalPesos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmDuplicate;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}