namespace BPS
{
    partial class frmExecuteChangeSalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecuteChangeSalesOrder));
            this.tbcChangeSalesOrder = new System.Windows.Forms.TabControl();
            this.tbpResume = new System.Windows.Forms.TabPage();
            this.dgvChangeOrderSummary = new System.Windows.Forms.DataGridView();
            this.clmChangeOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmChangeOrderClose = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbpCoils = new System.Windows.Forms.TabPage();
            this.grpbDestinationSalesOrder = new System.Windows.Forms.GroupBox();
            this.lblDestinationCustomerName = new System.Windows.Forms.Label();
            this.lblDestinationCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblDestinationDate = new System.Windows.Forms.Label();
            this.lblDestinationNumber = new System.Windows.Forms.Label();
            this.lblDestinationDateLabel = new System.Windows.Forms.Label();
            this.lblDestinationNumberLabel = new System.Windows.Forms.Label();
            this.grpbOriginSalesOrder = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.grpbCoilsPalletCode = new System.Windows.Forms.GroupBox();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.lblCoilCode = new System.Windows.Forms.Label();
            this.btnAddCoil = new System.Windows.Forms.Button();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeSalesOrderDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbcChangeSalesOrder.SuspendLayout();
            this.tbpResume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeOrderSummary)).BeginInit();
            this.tbpCoils.SuspendLayout();
            this.grpbDestinationSalesOrder.SuspendLayout();
            this.grpbOriginSalesOrder.SuspendLayout();
            this.grpbCoilsPalletCode.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcChangeSalesOrder
            // 
            this.tbcChangeSalesOrder.Controls.Add(this.tbpResume);
            this.tbcChangeSalesOrder.Controls.Add(this.tbpCoils);
            this.tbcChangeSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcChangeSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.tbcChangeSalesOrder.Name = "tbcChangeSalesOrder";
            this.tbcChangeSalesOrder.SelectedIndex = 0;
            this.tbcChangeSalesOrder.Size = new System.Drawing.Size(973, 479);
            this.tbcChangeSalesOrder.TabIndex = 0;
            // 
            // tbpResume
            // 
            this.tbpResume.AutoScroll = true;
            this.tbpResume.BackColor = System.Drawing.SystemColors.Window;
            this.tbpResume.Controls.Add(this.dgvChangeOrderSummary);
            this.tbpResume.Location = new System.Drawing.Point(4, 24);
            this.tbpResume.Name = "tbpResume";
            this.tbpResume.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResume.Size = new System.Drawing.Size(965, 451);
            this.tbpResume.TabIndex = 2;
            this.tbpResume.Text = "Ordenes de cambio";
            // 
            // dgvChangeOrderSummary
            // 
            this.dgvChangeOrderSummary.AllowUserToAddRows = false;
            this.dgvChangeOrderSummary.AllowUserToDeleteRows = false;
            this.dgvChangeOrderSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeOrderSummary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmChangeOrderCodsec,
            this.clmChangeOrderProduct,
            this.clmChangeOrderFrom,
            this.clmChangeOrderCoils,
            this.clmChangeOrderTo,
            this.clmChangeOrderDate,
            this.clmnotes,
            this.clmChangeOrderStatus,
            this.clmChangeOrderClose});
            this.dgvChangeOrderSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChangeOrderSummary.Location = new System.Drawing.Point(3, 3);
            this.dgvChangeOrderSummary.Name = "dgvChangeOrderSummary";
            this.dgvChangeOrderSummary.ReadOnly = true;
            this.dgvChangeOrderSummary.Size = new System.Drawing.Size(959, 445);
            this.dgvChangeOrderSummary.TabIndex = 0;
            this.dgvChangeOrderSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChangeOrderSummary_CellClick);
            this.dgvChangeOrderSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChangeOrderSummary_CellContentClick);
            // 
            // clmChangeOrderCodsec
            // 
            this.clmChangeOrderCodsec.HeaderText = "codsec";
            this.clmChangeOrderCodsec.Name = "clmChangeOrderCodsec";
            this.clmChangeOrderCodsec.ReadOnly = true;
            this.clmChangeOrderCodsec.Visible = false;
            // 
            // clmChangeOrderProduct
            // 
            this.clmChangeOrderProduct.HeaderText = "Producto";
            this.clmChangeOrderProduct.Name = "clmChangeOrderProduct";
            this.clmChangeOrderProduct.ReadOnly = true;
            // 
            // clmChangeOrderFrom
            // 
            this.clmChangeOrderFrom.HeaderText = "Orden Origen";
            this.clmChangeOrderFrom.Name = "clmChangeOrderFrom";
            this.clmChangeOrderFrom.ReadOnly = true;
            this.clmChangeOrderFrom.Width = 220;
            // 
            // clmChangeOrderCoils
            // 
            this.clmChangeOrderCoils.HeaderText = "Bobinas";
            this.clmChangeOrderCoils.Name = "clmChangeOrderCoils";
            this.clmChangeOrderCoils.ReadOnly = true;
            this.clmChangeOrderCoils.Width = 80;
            // 
            // clmChangeOrderTo
            // 
            this.clmChangeOrderTo.HeaderText = "Orden Destino";
            this.clmChangeOrderTo.Name = "clmChangeOrderTo";
            this.clmChangeOrderTo.ReadOnly = true;
            this.clmChangeOrderTo.Width = 220;
            // 
            // clmChangeOrderDate
            // 
            this.clmChangeOrderDate.HeaderText = "Fecha";
            this.clmChangeOrderDate.Name = "clmChangeOrderDate";
            this.clmChangeOrderDate.ReadOnly = true;
            this.clmChangeOrderDate.Width = 120;
            // 
            // clmnotes
            // 
            this.clmnotes.HeaderText = "Notas";
            this.clmnotes.Name = "clmnotes";
            this.clmnotes.ReadOnly = true;
            // 
            // clmChangeOrderStatus
            // 
            this.clmChangeOrderStatus.HeaderText = "";
            this.clmChangeOrderStatus.Name = "clmChangeOrderStatus";
            this.clmChangeOrderStatus.ReadOnly = true;
            this.clmChangeOrderStatus.Width = 30;
            // 
            // clmChangeOrderClose
            // 
            this.clmChangeOrderClose.HeaderText = "";
            this.clmChangeOrderClose.Name = "clmChangeOrderClose";
            this.clmChangeOrderClose.ReadOnly = true;
            this.clmChangeOrderClose.Width = 30;
            // 
            // tbpCoils
            // 
            this.tbpCoils.Controls.Add(this.grpbDestinationSalesOrder);
            this.tbpCoils.Controls.Add(this.grpbOriginSalesOrder);
            this.tbpCoils.Controls.Add(this.grpbCoilsPalletCode);
            this.tbpCoils.Controls.Add(this.grpbCoils);
            this.tbpCoils.Location = new System.Drawing.Point(4, 24);
            this.tbpCoils.Name = "tbpCoils";
            this.tbpCoils.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoils.Size = new System.Drawing.Size(965, 451);
            this.tbpCoils.TabIndex = 3;
            this.tbpCoils.Text = "Cambio de bobinas";
            this.tbpCoils.UseVisualStyleBackColor = true;
            // 
            // grpbDestinationSalesOrder
            // 
            this.grpbDestinationSalesOrder.Controls.Add(this.lblDestinationCustomerName);
            this.grpbDestinationSalesOrder.Controls.Add(this.lblDestinationCustomerNameLabel);
            this.grpbDestinationSalesOrder.Controls.Add(this.lblDestinationDate);
            this.grpbDestinationSalesOrder.Controls.Add(this.lblDestinationNumber);
            this.grpbDestinationSalesOrder.Controls.Add(this.lblDestinationDateLabel);
            this.grpbDestinationSalesOrder.Controls.Add(this.lblDestinationNumberLabel);
            this.grpbDestinationSalesOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbDestinationSalesOrder.Location = new System.Drawing.Point(485, 77);
            this.grpbDestinationSalesOrder.Name = "grpbDestinationSalesOrder";
            this.grpbDestinationSalesOrder.Size = new System.Drawing.Size(477, 90);
            this.grpbDestinationSalesOrder.TabIndex = 2;
            this.grpbDestinationSalesOrder.TabStop = false;
            this.grpbDestinationSalesOrder.Text = "Orden de venta (Destino)";
            // 
            // lblDestinationCustomerName
            // 
            this.lblDestinationCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestinationCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCustomerName.Location = new System.Drawing.Point(92, 53);
            this.lblDestinationCustomerName.Name = "lblDestinationCustomerName";
            this.lblDestinationCustomerName.Size = new System.Drawing.Size(351, 21);
            this.lblDestinationCustomerName.TabIndex = 5;
            // 
            // lblDestinationCustomerNameLabel
            // 
            this.lblDestinationCustomerNameLabel.AutoSize = true;
            this.lblDestinationCustomerNameLabel.Location = new System.Drawing.Point(34, 56);
            this.lblDestinationCustomerNameLabel.Name = "lblDestinationCustomerNameLabel";
            this.lblDestinationCustomerNameLabel.Size = new System.Drawing.Size(45, 15);
            this.lblDestinationCustomerNameLabel.TabIndex = 4;
            this.lblDestinationCustomerNameLabel.Text = "Cliente";
            // 
            // lblDestinationDate
            // 
            this.lblDestinationDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestinationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationDate.Location = new System.Drawing.Point(288, 21);
            this.lblDestinationDate.Name = "lblDestinationDate";
            this.lblDestinationDate.Size = new System.Drawing.Size(155, 21);
            this.lblDestinationDate.TabIndex = 3;
            // 
            // lblDestinationNumber
            // 
            this.lblDestinationNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestinationNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationNumber.Location = new System.Drawing.Point(92, 19);
            this.lblDestinationNumber.Name = "lblDestinationNumber";
            this.lblDestinationNumber.Size = new System.Drawing.Size(143, 24);
            this.lblDestinationNumber.TabIndex = 1;
            // 
            // lblDestinationDateLabel
            // 
            this.lblDestinationDateLabel.AutoSize = true;
            this.lblDestinationDateLabel.Location = new System.Drawing.Point(241, 24);
            this.lblDestinationDateLabel.Name = "lblDestinationDateLabel";
            this.lblDestinationDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDestinationDateLabel.TabIndex = 2;
            this.lblDestinationDateLabel.Text = "Fecha";
            // 
            // lblDestinationNumberLabel
            // 
            this.lblDestinationNumberLabel.AutoSize = true;
            this.lblDestinationNumberLabel.Location = new System.Drawing.Point(34, 24);
            this.lblDestinationNumberLabel.Name = "lblDestinationNumberLabel";
            this.lblDestinationNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.lblDestinationNumberLabel.TabIndex = 0;
            this.lblDestinationNumberLabel.Text = "Número";
            // 
            // grpbOriginSalesOrder
            // 
            this.grpbOriginSalesOrder.Controls.Add(this.lblCustomerName);
            this.grpbOriginSalesOrder.Controls.Add(this.lblCustomerNameLabel);
            this.grpbOriginSalesOrder.Controls.Add(this.lblDate);
            this.grpbOriginSalesOrder.Controls.Add(this.lblNumber);
            this.grpbOriginSalesOrder.Controls.Add(this.lblDateLabel);
            this.grpbOriginSalesOrder.Controls.Add(this.lblNumberLabel);
            this.grpbOriginSalesOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbOriginSalesOrder.Location = new System.Drawing.Point(3, 77);
            this.grpbOriginSalesOrder.Name = "grpbOriginSalesOrder";
            this.grpbOriginSalesOrder.Size = new System.Drawing.Size(476, 90);
            this.grpbOriginSalesOrder.TabIndex = 1;
            this.grpbOriginSalesOrder.TabStop = false;
            this.grpbOriginSalesOrder.Text = "Orden de venta (Origen)";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(92, 56);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(351, 21);
            this.lblCustomerName.TabIndex = 5;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(34, 59);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerNameLabel.TabIndex = 4;
            this.lblCustomerNameLabel.Text = "Cliente";
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(288, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(155, 21);
            this.lblDate.TabIndex = 3;
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(92, 22);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(143, 24);
            this.lblNumber.TabIndex = 1;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(241, 27);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDateLabel.TabIndex = 2;
            this.lblDateLabel.Text = "Fecha";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(34, 27);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.lblNumberLabel.TabIndex = 0;
            this.lblNumberLabel.Text = "Número";
            // 
            // grpbCoilsPalletCode
            // 
            this.grpbCoilsPalletCode.Controls.Add(this.txtCoilCode);
            this.grpbCoilsPalletCode.Controls.Add(this.lblCoilCount);
            this.grpbCoilsPalletCode.Controls.Add(this.lblCoilCode);
            this.grpbCoilsPalletCode.Controls.Add(this.btnAddCoil);
            this.grpbCoilsPalletCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilsPalletCode.Location = new System.Drawing.Point(3, 3);
            this.grpbCoilsPalletCode.Name = "grpbCoilsPalletCode";
            this.grpbCoilsPalletCode.Size = new System.Drawing.Size(959, 74);
            this.grpbCoilsPalletCode.TabIndex = 0;
            this.grpbCoilsPalletCode.TabStop = false;
            this.grpbCoilsPalletCode.Text = "Bobinas / Pallet";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(402, 17);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(262, 26);
            this.txtCoilCode.TabIndex = 1;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(224, 48);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(511, 18);
            this.lblCoilCount.TabIndex = 3;
            this.lblCoilCount.Text = "Bobinas : -- / --";
            this.lblCoilCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCode.Location = new System.Drawing.Point(263, 20);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 0;
            this.lblCoilCode.Text = "Código de bobina";
            // 
            // btnAddCoil
            // 
            this.btnAddCoil.Enabled = false;
            this.btnAddCoil.Image = global::BPS.Properties.Resources.add_coil;
            this.btnAddCoil.Location = new System.Drawing.Point(670, 18);
            this.btnAddCoil.Name = "btnAddCoil";
            this.btnAddCoil.Size = new System.Drawing.Size(25, 25);
            this.btnAddCoil.TabIndex = 2;
            this.btnAddCoil.UseVisualStyleBackColor = true;
            this.btnAddCoil.Click += new System.EventHandler(this.btnAddCoil_Click);
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.btnClose);
            this.grpbCoils.Controls.Add(this.dgvCoils);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbCoils.Location = new System.Drawing.Point(3, 167);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(959, 281);
            this.grpbCoils.TabIndex = 3;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas cambiadas";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Properties.Resources.lock1;
            this.btnClose.Location = new System.Drawing.Point(928, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmChangeSalesOrderDetailCodsec,
            this.clmCoilCode,
            this.clmCoilLength,
            this.clmCoilWidth,
            this.clmCoilWeigth,
            this.clmCoilAction});
            this.dgvCoils.Location = new System.Drawing.Point(221, 13);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(517, 262);
            this.dgvCoils.TabIndex = 0;
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmChangeSalesOrderDetailCodsec
            // 
            this.clmChangeSalesOrderDetailCodsec.HeaderText = "Change codsec";
            this.clmChangeSalesOrderDetailCodsec.Name = "clmChangeSalesOrderDetailCodsec";
            this.clmChangeSalesOrderDetailCodsec.ReadOnly = true;
            this.clmChangeSalesOrderDetailCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 150;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 90;
            // 
            // clmCoilWidth
            // 
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 90;
            // 
            // clmCoilWeigth
            // 
            this.clmCoilWeigth.HeaderText = "Peso";
            this.clmCoilWeigth.Name = "clmCoilWeigth";
            this.clmCoilWeigth.ReadOnly = true;
            this.clmCoilWeigth.Width = 90;
            // 
            // clmCoilAction
            // 
            this.clmCoilAction.HeaderText = "";
            this.clmCoilAction.Name = "clmCoilAction";
            this.clmCoilAction.ReadOnly = true;
            this.clmCoilAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCoilAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmCoilAction.Width = 30;
            // 
            // frmExecuteChangeSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(973, 479);
            this.Controls.Add(this.tbcChangeSalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExecuteChangeSalesOrder";
            this.Text = "Cambio de orden de venta";
            this.Load += new System.EventHandler(this.frmExecuteChangeSalesOrder_Load);
            this.tbcChangeSalesOrder.ResumeLayout(false);
            this.tbpResume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeOrderSummary)).EndInit();
            this.tbpCoils.ResumeLayout(false);
            this.grpbDestinationSalesOrder.ResumeLayout(false);
            this.grpbDestinationSalesOrder.PerformLayout();
            this.grpbOriginSalesOrder.ResumeLayout(false);
            this.grpbOriginSalesOrder.PerformLayout();
            this.grpbCoilsPalletCode.ResumeLayout(false);
            this.grpbCoilsPalletCode.PerformLayout();
            this.grpbCoils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcChangeSalesOrder;
        private System.Windows.Forms.TabPage tbpResume;
        private System.Windows.Forms.DataGridView dgvChangeOrderSummary;
        private System.Windows.Forms.TabPage tbpCoils;
        private System.Windows.Forms.GroupBox grpbDestinationSalesOrder;
        private System.Windows.Forms.GroupBox grpbOriginSalesOrder;
        private System.Windows.Forms.GroupBox grpbCoilsPalletCode;
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.Label lblCoilCount;
        private System.Windows.Forms.Label lblCoilCode;
        private System.Windows.Forms.Button btnAddCoil;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.Label lblDestinationCustomerName;
        private System.Windows.Forms.Label lblDestinationCustomerNameLabel;
        private System.Windows.Forms.Label lblDestinationDate;
        private System.Windows.Forms.Label lblDestinationNumber;
        private System.Windows.Forms.Label lblDestinationDateLabel;
        private System.Windows.Forms.Label lblDestinationNumberLabel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeSalesOrderDetailCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilAction;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnotes;
        private System.Windows.Forms.DataGridViewImageColumn clmChangeOrderStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmChangeOrderClose;
    }
}