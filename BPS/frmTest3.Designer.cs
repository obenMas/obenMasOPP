namespace BPS
{
    partial class frmTest3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest3));
            this.tbcStops = new System.Windows.Forms.TabControl();
            this.tbpStop = new System.Windows.Forms.TabPage();
            this.tbcCoilsInfo = new System.Windows.Forms.TabControl();
            this.tbpCoils = new System.Windows.Forms.TabPage();
            this.btnRegisterCoils = new System.Windows.Forms.Button();
            this.btnCloseStop = new System.Windows.Forms.Button();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.cmbDigitizer = new System.Windows.Forms.ComboBox();
            this.lblDigitizer = new System.Windows.Forms.Label();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblUnit9 = new System.Windows.Forms.Label();
            this.lblCoilsWeigth = new System.Windows.Forms.Label();
            this.lblCoilsWeigthLabel = new System.Windows.Forms.Label();
            this.dgvCoilsDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpMainCoils = new System.Windows.Forms.TabPage();
            this.grpbUsedMainCoil = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListLabRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilUsedLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.lblGramaje = new System.Windows.Forms.Label();
            this.lblWidht = new System.Windows.Forms.Label();
            this.lblVelocity = new System.Windows.Forms.Label();
            this.lblKgPerHour = new System.Windows.Forms.Label();
            this.lblUnit8 = new System.Windows.Forms.Label();
            this.lblUnit10 = new System.Windows.Forms.Label();
            this.lblUnit4 = new System.Windows.Forms.Label();
            this.lblUnit6 = new System.Windows.Forms.Label();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblNetLength = new System.Windows.Forms.Label();
            this.lblMainCoilNetWeigth = new System.Windows.Forms.Label();
            this.lblMainCoilNetLength = new System.Windows.Forms.Label();
            this.lblMainCoilVelocity = new System.Windows.Forms.Label();
            this.lblMainCoilGramaje = new System.Windows.Forms.Label();
            this.lblMainCoilWidth = new System.Windows.Forms.Label();
            this.lblMainCoilKgPerHour = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblMainCoilMachine = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblMainCoilBatch = new System.Windows.Forms.Label();
            this.txtUsedLength = new System.Windows.Forms.TextBox();
            this.lblUsedLength = new System.Windows.Forms.Label();
            this.txtMainCoilCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ttpStops = new System.Windows.Forms.ToolTip(this.components);
            this.tbcStops.SuspendLayout();
            this.tbpStop.SuspendLayout();
            this.tbcCoilsInfo.SuspendLayout();
            this.tbpCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsDetail)).BeginInit();
            this.tbpMainCoils.SuspendLayout();
            this.grpbUsedMainCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcStops
            // 
            this.tbcStops.Controls.Add(this.tbpStop);
            this.tbcStops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcStops.ImageList = this.imageList1;
            this.tbcStops.Location = new System.Drawing.Point(0, 0);
            this.tbcStops.Name = "tbcStops";
            this.tbcStops.SelectedIndex = 0;
            this.tbcStops.Size = new System.Drawing.Size(1001, 383);
            this.tbcStops.TabIndex = 0;
            // 
            // tbpStop
            // 
            this.tbpStop.BackColor = System.Drawing.SystemColors.Control;
            this.tbpStop.Controls.Add(this.tbcCoilsInfo);
            this.tbpStop.ImageIndex = 1;
            this.tbpStop.Location = new System.Drawing.Point(4, 24);
            this.tbpStop.Name = "tbpStop";
            this.tbpStop.Padding = new System.Windows.Forms.Padding(3);
            this.tbpStop.Size = new System.Drawing.Size(993, 355);
            this.tbpStop.TabIndex = 0;
            this.tbpStop.Text = "Parada 1";
            // 
            // tbcCoilsInfo
            // 
            this.tbcCoilsInfo.Controls.Add(this.tbpCoils);
            this.tbcCoilsInfo.Controls.Add(this.tbpMainCoils);
            this.tbcCoilsInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCoilsInfo.Location = new System.Drawing.Point(3, 3);
            this.tbcCoilsInfo.Name = "tbcCoilsInfo";
            this.tbcCoilsInfo.SelectedIndex = 0;
            this.tbcCoilsInfo.Size = new System.Drawing.Size(987, 349);
            this.tbcCoilsInfo.TabIndex = 0;
            // 
            // tbpCoils
            // 
            this.tbpCoils.BackColor = System.Drawing.SystemColors.Control;
            this.tbpCoils.Controls.Add(this.btnRegisterCoils);
            this.tbpCoils.Controls.Add(this.btnCloseStop);
            this.tbpCoils.Controls.Add(this.cmbOperator);
            this.tbpCoils.Controls.Add(this.lblOperator);
            this.tbpCoils.Controls.Add(this.cmbDigitizer);
            this.tbpCoils.Controls.Add(this.lblDigitizer);
            this.tbpCoils.Controls.Add(this.cmbSupervisor);
            this.tbpCoils.Controls.Add(this.lblSupervisor);
            this.tbpCoils.Controls.Add(this.lblUnit9);
            this.tbpCoils.Controls.Add(this.lblCoilsWeigth);
            this.tbpCoils.Controls.Add(this.lblCoilsWeigthLabel);
            this.tbpCoils.Controls.Add(this.dgvCoilsDetail);
            this.tbpCoils.Location = new System.Drawing.Point(4, 24);
            this.tbpCoils.Name = "tbpCoils";
            this.tbpCoils.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoils.Size = new System.Drawing.Size(979, 321);
            this.tbpCoils.TabIndex = 0;
            this.tbpCoils.Text = "Bobinas";
            // 
            // btnRegisterCoils
            // 
            this.btnRegisterCoils.BackgroundImage = global::BPS.Properties.Resources.coils;
            this.btnRegisterCoils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRegisterCoils.Location = new System.Drawing.Point(906, 285);
            this.btnRegisterCoils.Name = "btnRegisterCoils";
            this.btnRegisterCoils.Size = new System.Drawing.Size(25, 25);
            this.btnRegisterCoils.TabIndex = 76;
            this.ttpStops.SetToolTip(this.btnRegisterCoils, "Registara Bobinas");
            this.btnRegisterCoils.UseVisualStyleBackColor = true;
            // 
            // btnCloseStop
            // 
            this.btnCloseStop.BackgroundImage = global::BPS.Properties.Resources.lock1;
            this.btnCloseStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseStop.Location = new System.Drawing.Point(931, 285);
            this.btnCloseStop.Name = "btnCloseStop";
            this.btnCloseStop.Size = new System.Drawing.Size(25, 25);
            this.btnCloseStop.TabIndex = 75;
            this.ttpStops.SetToolTip(this.btnCloseStop, "Cerrar");
            this.btnCloseStop.UseVisualStyleBackColor = true;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(550, 286);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(153, 23);
            this.cmbOperator.TabIndex = 72;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(483, 290);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(59, 15);
            this.lblOperator.TabIndex = 70;
            this.lblOperator.Text = "Operador";
            // 
            // cmbDigitizer
            // 
            this.cmbDigitizer.FormattingEnabled = true;
            this.cmbDigitizer.Location = new System.Drawing.Point(322, 286);
            this.cmbDigitizer.Name = "cmbDigitizer";
            this.cmbDigitizer.Size = new System.Drawing.Size(153, 23);
            this.cmbDigitizer.TabIndex = 74;
            // 
            // lblDigitizer
            // 
            this.lblDigitizer.AutoSize = true;
            this.lblDigitizer.Location = new System.Drawing.Point(257, 290);
            this.lblDigitizer.Name = "lblDigitizer";
            this.lblDigitizer.Size = new System.Drawing.Size(57, 15);
            this.lblDigitizer.TabIndex = 69;
            this.lblDigitizer.Text = "Digitador";
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(96, 286);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(153, 23);
            this.cmbSupervisor.TabIndex = 73;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(23, 290);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(65, 15);
            this.lblSupervisor.TabIndex = 71;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // lblUnit9
            // 
            this.lblUnit9.AutoSize = true;
            this.lblUnit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit9.Location = new System.Drawing.Point(870, 291);
            this.lblUnit9.Name = "lblUnit9";
            this.lblUnit9.Size = new System.Drawing.Size(19, 12);
            this.lblUnit9.TabIndex = 0;
            this.lblUnit9.Text = "Kg.";
            // 
            // lblCoilsWeigth
            // 
            this.lblCoilsWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblCoilsWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoilsWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilsWeigth.Location = new System.Drawing.Point(783, 287);
            this.lblCoilsWeigth.Name = "lblCoilsWeigth";
            this.lblCoilsWeigth.Size = new System.Drawing.Size(84, 21);
            this.lblCoilsWeigth.TabIndex = 1;
            this.lblCoilsWeigth.Tag = "numericClearOnReload";
            this.lblCoilsWeigth.Text = "0";
            this.lblCoilsWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCoilsWeigthLabel
            // 
            this.lblCoilsWeigthLabel.AutoSize = true;
            this.lblCoilsWeigthLabel.Location = new System.Drawing.Point(711, 290);
            this.lblCoilsWeigthLabel.Name = "lblCoilsWeigthLabel";
            this.lblCoilsWeigthLabel.Size = new System.Drawing.Size(64, 15);
            this.lblCoilsWeigthLabel.TabIndex = 2;
            this.lblCoilsWeigthLabel.Text = "Peso Neto";
            // 
            // dgvCoilsDetail
            // 
            this.dgvCoilsDetail.AllowUserToAddRows = false;
            this.dgvCoilsDetail.AllowUserToDeleteRows = false;
            this.dgvCoilsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPosition,
            this.clmCustomer,
            this.clmSalesOrder,
            this.clmProductCode,
            this.clmWidth,
            this.clmLength,
            this.clmWeigth});
            this.dgvCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoilsDetail.Location = new System.Drawing.Point(3, 3);
            this.dgvCoilsDetail.Name = "dgvCoilsDetail";
            this.dgvCoilsDetail.ReadOnly = true;
            this.dgvCoilsDetail.Size = new System.Drawing.Size(973, 272);
            this.dgvCoilsDetail.TabIndex = 0;
            this.dgvCoilsDetail.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCoilsDetail_CellMouseDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posición";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 80;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 250;
            // 
            // clmSalesOrder
            // 
            this.clmSalesOrder.HeaderText = "Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            this.clmSalesOrder.Width = 80;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Cód. Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Width = 200;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            // 
            // tbpMainCoils
            // 
            this.tbpMainCoils.BackColor = System.Drawing.SystemColors.Control;
            this.tbpMainCoils.Controls.Add(this.grpbUsedMainCoil);
            this.tbpMainCoils.Location = new System.Drawing.Point(4, 24);
            this.tbpMainCoils.Name = "tbpMainCoils";
            this.tbpMainCoils.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMainCoils.Size = new System.Drawing.Size(979, 321);
            this.tbpMainCoils.TabIndex = 1;
            this.tbpMainCoils.Text = "Rollos madre";
            // 
            // grpbUsedMainCoil
            // 
            this.grpbUsedMainCoil.BackColor = System.Drawing.SystemColors.Control;
            this.grpbUsedMainCoil.Controls.Add(this.dgvMainCoilList);
            this.grpbUsedMainCoil.Controls.Add(this.btnAdd);
            this.grpbUsedMainCoil.Controls.Add(this.btnMainCoilCancel);
            this.grpbUsedMainCoil.Controls.Add(this.lblGramaje);
            this.grpbUsedMainCoil.Controls.Add(this.lblWidht);
            this.grpbUsedMainCoil.Controls.Add(this.lblVelocity);
            this.grpbUsedMainCoil.Controls.Add(this.lblKgPerHour);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit8);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit10);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit4);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit6);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit3);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit5);
            this.grpbUsedMainCoil.Controls.Add(this.lblUnit1);
            this.grpbUsedMainCoil.Controls.Add(this.lblNetWeigth);
            this.grpbUsedMainCoil.Controls.Add(this.lblNetLength);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilNetWeigth);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilNetLength);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilVelocity);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilGramaje);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilWidth);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilKgPerHour);
            this.grpbUsedMainCoil.Controls.Add(this.lblMachine);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilMachine);
            this.grpbUsedMainCoil.Controls.Add(this.lblLot);
            this.grpbUsedMainCoil.Controls.Add(this.lblMainCoilBatch);
            this.grpbUsedMainCoil.Controls.Add(this.txtUsedLength);
            this.grpbUsedMainCoil.Controls.Add(this.lblUsedLength);
            this.grpbUsedMainCoil.Controls.Add(this.txtMainCoilCode);
            this.grpbUsedMainCoil.Controls.Add(this.lblCode);
            this.grpbUsedMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbUsedMainCoil.Location = new System.Drawing.Point(3, 3);
            this.grpbUsedMainCoil.Name = "grpbUsedMainCoil";
            this.grpbUsedMainCoil.Size = new System.Drawing.Size(973, 315);
            this.grpbUsedMainCoil.TabIndex = 0;
            this.grpbUsedMainCoil.TabStop = false;
            this.grpbUsedMainCoil.Text = "Bobina usada";
            // 
            // dgvMainCoilList
            // 
            this.dgvMainCoilList.AllowUserToAddRows = false;
            this.dgvMainCoilList.AllowUserToDeleteRows = false;
            this.dgvMainCoilList.AllowUserToOrderColumns = true;
            this.dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCoilListCodsec,
            this.clmMainCoilListFilm,
            this.clmMainCoilListCode,
            this.clmMainCoilListBatch,
            this.clmMainCoilListLabRating,
            this.clmMainCoilListInitDate,
            this.clmMainCoilUsedLenth});
            this.dgvMainCoilList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMainCoilList.Location = new System.Drawing.Point(3, 129);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilList.Size = new System.Drawing.Size(967, 183);
            this.dgvMainCoilList.TabIndex = 13;
            this.dgvMainCoilList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMainCoilList_CellMouseDoubleClick);
            // 
            // clmMainCoilListCodsec
            // 
            this.clmMainCoilListCodsec.HeaderText = "Codsec";
            this.clmMainCoilListCodsec.Name = "clmMainCoilListCodsec";
            this.clmMainCoilListCodsec.ReadOnly = true;
            this.clmMainCoilListCodsec.Visible = false;
            this.clmMainCoilListCodsec.Width = 200;
            // 
            // clmMainCoilListFilm
            // 
            this.clmMainCoilListFilm.HeaderText = "Película";
            this.clmMainCoilListFilm.Name = "clmMainCoilListFilm";
            this.clmMainCoilListFilm.ReadOnly = true;
            this.clmMainCoilListFilm.Width = 200;
            // 
            // clmMainCoilListCode
            // 
            this.clmMainCoilListCode.HeaderText = "Código";
            this.clmMainCoilListCode.Name = "clmMainCoilListCode";
            this.clmMainCoilListCode.ReadOnly = true;
            this.clmMainCoilListCode.Width = 150;
            // 
            // clmMainCoilListBatch
            // 
            this.clmMainCoilListBatch.HeaderText = "Lote";
            this.clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            this.clmMainCoilListBatch.ReadOnly = true;
            // 
            // clmMainCoilListLabRating
            // 
            this.clmMainCoilListLabRating.HeaderText = "Calificación";
            this.clmMainCoilListLabRating.Name = "clmMainCoilListLabRating";
            this.clmMainCoilListLabRating.ReadOnly = true;
            this.clmMainCoilListLabRating.Width = 120;
            // 
            // clmMainCoilListInitDate
            // 
            this.clmMainCoilListInitDate.HeaderText = "Fecha Inicio";
            this.clmMainCoilListInitDate.Name = "clmMainCoilListInitDate";
            this.clmMainCoilListInitDate.ReadOnly = true;
            this.clmMainCoilListInitDate.Width = 150;
            // 
            // clmMainCoilUsedLenth
            // 
            this.clmMainCoilUsedLenth.HeaderText = "Metraje Usado";
            this.clmMainCoilUsedLenth.Name = "clmMainCoilUsedLenth";
            this.clmMainCoilUsedLenth.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(778, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(778, 99);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 12;
            this.btnMainCoilCancel.Text = "Cancelar";
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilCancel.Click += new System.EventHandler(this.btnMainCoilCancel_Click);
            // 
            // lblGramaje
            // 
            this.lblGramaje.BackColor = System.Drawing.SystemColors.Window;
            this.lblGramaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGramaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramaje.Location = new System.Drawing.Point(429, 101);
            this.lblGramaje.Name = "lblGramaje";
            this.lblGramaje.Size = new System.Drawing.Size(84, 21);
            this.lblGramaje.TabIndex = 9;
            this.lblGramaje.Tag = "numericClearOnReload";
            this.lblGramaje.Text = "0";
            this.lblGramaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWidht
            // 
            this.lblWidht.BackColor = System.Drawing.SystemColors.Window;
            this.lblWidht.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidht.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidht.Location = new System.Drawing.Point(232, 101);
            this.lblWidht.Name = "lblWidht";
            this.lblWidht.Size = new System.Drawing.Size(84, 21);
            this.lblWidht.TabIndex = 8;
            this.lblWidht.Tag = "numericClearOnReload";
            this.lblWidht.Text = "0";
            this.lblWidht.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVelocity
            // 
            this.lblVelocity.BackColor = System.Drawing.SystemColors.Window;
            this.lblVelocity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocity.Location = new System.Drawing.Point(429, 74);
            this.lblVelocity.Name = "lblVelocity";
            this.lblVelocity.Size = new System.Drawing.Size(84, 21);
            this.lblVelocity.TabIndex = 6;
            this.lblVelocity.Tag = "numericClearOnReload";
            this.lblVelocity.Text = "0";
            this.lblVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKgPerHour
            // 
            this.lblKgPerHour.BackColor = System.Drawing.SystemColors.Window;
            this.lblKgPerHour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKgPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgPerHour.Location = new System.Drawing.Point(232, 74);
            this.lblKgPerHour.Name = "lblKgPerHour";
            this.lblKgPerHour.Size = new System.Drawing.Size(84, 21);
            this.lblKgPerHour.TabIndex = 5;
            this.lblKgPerHour.Tag = "numericClearOnReload";
            this.lblKgPerHour.Text = "0";
            this.lblKgPerHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnit8
            // 
            this.lblUnit8.AutoSize = true;
            this.lblUnit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit8.Location = new System.Drawing.Point(738, 105);
            this.lblUnit8.Name = "lblUnit8";
            this.lblUnit8.Size = new System.Drawing.Size(19, 12);
            this.lblUnit8.TabIndex = 38;
            this.lblUnit8.Text = "Kg.";
            // 
            // lblUnit10
            // 
            this.lblUnit10.AutoSize = true;
            this.lblUnit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit10.Location = new System.Drawing.Point(738, 26);
            this.lblUnit10.Name = "lblUnit10";
            this.lblUnit10.Size = new System.Drawing.Size(28, 12);
            this.lblUnit10.TabIndex = 37;
            this.lblUnit10.Text = "Mtrs.";
            // 
            // lblUnit4
            // 
            this.lblUnit4.AutoSize = true;
            this.lblUnit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit4.Location = new System.Drawing.Point(738, 78);
            this.lblUnit4.Name = "lblUnit4";
            this.lblUnit4.Size = new System.Drawing.Size(28, 12);
            this.lblUnit4.TabIndex = 37;
            this.lblUnit4.Text = "Mtrs.";
            // 
            // lblUnit6
            // 
            this.lblUnit6.AutoSize = true;
            this.lblUnit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit6.Location = new System.Drawing.Point(328, 105);
            this.lblUnit6.Name = "lblUnit6";
            this.lblUnit6.Size = new System.Drawing.Size(21, 12);
            this.lblUnit6.TabIndex = 40;
            this.lblUnit6.Text = "mm";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit3.Location = new System.Drawing.Point(519, 105);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(24, 12);
            this.lblUnit3.TabIndex = 35;
            this.lblUnit3.Text = "g/m²";
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit5.Location = new System.Drawing.Point(520, 78);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(43, 12);
            this.lblUnit5.TabIndex = 36;
            this.lblUnit5.Text = "Mtrs/min";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit1.Location = new System.Drawing.Point(328, 78);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(29, 12);
            this.lblUnit1.TabIndex = 34;
            this.lblUnit1.Text = "Kg/Hr";
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(648, 101);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(84, 21);
            this.lblNetWeigth.TabIndex = 10;
            this.lblNetWeigth.Tag = "numericClearOnReload";
            this.lblNetWeigth.Text = "0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetLength
            // 
            this.lblNetLength.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetLength.Location = new System.Drawing.Point(648, 74);
            this.lblNetLength.Name = "lblNetLength";
            this.lblNetLength.Size = new System.Drawing.Size(84, 21);
            this.lblNetLength.TabIndex = 7;
            this.lblNetLength.Tag = "numericClearOnReload";
            this.lblNetLength.Text = "0";
            this.lblNetLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainCoilNetWeigth
            // 
            this.lblMainCoilNetWeigth.AutoSize = true;
            this.lblMainCoilNetWeigth.Location = new System.Drawing.Point(569, 104);
            this.lblMainCoilNetWeigth.Name = "lblMainCoilNetWeigth";
            this.lblMainCoilNetWeigth.Size = new System.Drawing.Size(64, 15);
            this.lblMainCoilNetWeigth.TabIndex = 32;
            this.lblMainCoilNetWeigth.Text = "Peso Neto";
            // 
            // lblMainCoilNetLength
            // 
            this.lblMainCoilNetLength.AutoSize = true;
            this.lblMainCoilNetLength.Location = new System.Drawing.Point(569, 77);
            this.lblMainCoilNetLength.Name = "lblMainCoilNetLength";
            this.lblMainCoilNetLength.Size = new System.Drawing.Size(78, 15);
            this.lblMainCoilNetLength.TabIndex = 31;
            this.lblMainCoilNetLength.Text = "Metraje Neto";
            // 
            // lblMainCoilVelocity
            // 
            this.lblMainCoilVelocity.AutoSize = true;
            this.lblMainCoilVelocity.Location = new System.Drawing.Point(362, 77);
            this.lblMainCoilVelocity.Name = "lblMainCoilVelocity";
            this.lblMainCoilVelocity.Size = new System.Drawing.Size(61, 15);
            this.lblMainCoilVelocity.TabIndex = 29;
            this.lblMainCoilVelocity.Text = "Velocidad";
            // 
            // lblMainCoilGramaje
            // 
            this.lblMainCoilGramaje.AutoSize = true;
            this.lblMainCoilGramaje.Location = new System.Drawing.Point(362, 104);
            this.lblMainCoilGramaje.Name = "lblMainCoilGramaje";
            this.lblMainCoilGramaje.Size = new System.Drawing.Size(55, 15);
            this.lblMainCoilGramaje.TabIndex = 25;
            this.lblMainCoilGramaje.Text = "Gramaje";
            // 
            // lblMainCoilWidth
            // 
            this.lblMainCoilWidth.AutoSize = true;
            this.lblMainCoilWidth.Location = new System.Drawing.Point(170, 104);
            this.lblMainCoilWidth.Name = "lblMainCoilWidth";
            this.lblMainCoilWidth.Size = new System.Drawing.Size(41, 15);
            this.lblMainCoilWidth.TabIndex = 24;
            this.lblMainCoilWidth.Text = "Ancho";
            // 
            // lblMainCoilKgPerHour
            // 
            this.lblMainCoilKgPerHour.AutoSize = true;
            this.lblMainCoilKgPerHour.Location = new System.Drawing.Point(170, 77);
            this.lblMainCoilKgPerHour.Name = "lblMainCoilKgPerHour";
            this.lblMainCoilKgPerHour.Size = new System.Drawing.Size(38, 15);
            this.lblMainCoilKgPerHour.TabIndex = 22;
            this.lblMainCoilKgPerHour.Text = "Kg/Hr";
            // 
            // lblMachine
            // 
            this.lblMachine.BackColor = System.Drawing.SystemColors.Window;
            this.lblMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachine.Location = new System.Drawing.Point(232, 47);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(318, 21);
            this.lblMachine.TabIndex = 3;
            this.lblMachine.Tag = "clearOnReload";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainCoilMachine
            // 
            this.lblMainCoilMachine.AutoSize = true;
            this.lblMainCoilMachine.Location = new System.Drawing.Point(170, 50);
            this.lblMainCoilMachine.Name = "lblMainCoilMachine";
            this.lblMainCoilMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMainCoilMachine.TabIndex = 14;
            this.lblMainCoilMachine.Text = "Máquina";
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.SystemColors.Window;
            this.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLot.Location = new System.Drawing.Point(606, 47);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(126, 21);
            this.lblLot.TabIndex = 4;
            this.lblLot.Tag = "clearOnReload";
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMainCoilBatch
            // 
            this.lblMainCoilBatch.AutoSize = true;
            this.lblMainCoilBatch.Location = new System.Drawing.Point(569, 50);
            this.lblMainCoilBatch.Name = "lblMainCoilBatch";
            this.lblMainCoilBatch.Size = new System.Drawing.Size(31, 15);
            this.lblMainCoilBatch.TabIndex = 10;
            this.lblMainCoilBatch.Text = "Lote";
            // 
            // txtUsedLength
            // 
            this.txtUsedLength.Location = new System.Drawing.Point(577, 20);
            this.txtUsedLength.Name = "txtUsedLength";
            this.txtUsedLength.Size = new System.Drawing.Size(155, 21);
            this.txtUsedLength.TabIndex = 2;
            // 
            // lblUsedLength
            // 
            this.lblUsedLength.AutoSize = true;
            this.lblUsedLength.Location = new System.Drawing.Point(473, 23);
            this.lblUsedLength.Name = "lblUsedLength";
            this.lblUsedLength.Size = new System.Drawing.Size(98, 15);
            this.lblUsedLength.TabIndex = 3;
            this.lblUsedLength.Text = "Metraje utilizado";
            // 
            // txtMainCoilCode
            // 
            this.txtMainCoilCode.Location = new System.Drawing.Point(232, 20);
            this.txtMainCoilCode.Name = "txtMainCoilCode";
            this.txtMainCoilCode.Size = new System.Drawing.Size(231, 21);
            this.txtMainCoilCode.TabIndex = 1;
            this.txtMainCoilCode.TextChanged += new System.EventHandler(this.txtMainCoilCode_TextChanged);
            this.txtMainCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCoilCode_KeyDown);
            this.txtMainCoilCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMainCoilCode_KeyPress);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(170, 23);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Código";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "lock_unlock.png");
            this.imageList1.Images.SetKeyName(1, "lock.png");
            // 
            // frmTest3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 383);
            this.Controls.Add(this.tbcStops);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTest3";
            this.Text = "frmTest3";
            this.Load += new System.EventHandler(this.frmTest3_Load);
            this.tbcStops.ResumeLayout(false);
            this.tbpStop.ResumeLayout(false);
            this.tbcCoilsInfo.ResumeLayout(false);
            this.tbpCoils.ResumeLayout(false);
            this.tbpCoils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsDetail)).EndInit();
            this.tbpMainCoils.ResumeLayout(false);
            this.grpbUsedMainCoil.ResumeLayout(false);
            this.grpbUsedMainCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcStops;
        private System.Windows.Forms.TabPage tbpStop;
        private System.Windows.Forms.TabControl tbcCoilsInfo;
        private System.Windows.Forms.TabPage tbpCoils;
        private System.Windows.Forms.TabPage tbpMainCoils;
        private System.Windows.Forms.GroupBox grpbUsedMainCoil;
        private System.Windows.Forms.Label lblGramaje;
        private System.Windows.Forms.Label lblWidht;
        private System.Windows.Forms.Label lblVelocity;
        private System.Windows.Forms.Label lblKgPerHour;
        private System.Windows.Forms.Label lblUnit8;
        private System.Windows.Forms.Label lblUnit4;
        private System.Windows.Forms.Label lblUnit6;
        private System.Windows.Forms.Label lblUnit3;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblNetLength;
        private System.Windows.Forms.Label lblMainCoilNetWeigth;
        private System.Windows.Forms.Label lblMainCoilNetLength;
        private System.Windows.Forms.Label lblMainCoilVelocity;
        private System.Windows.Forms.Label lblMainCoilGramaje;
        private System.Windows.Forms.Label lblMainCoilWidth;
        private System.Windows.Forms.Label lblMainCoilKgPerHour;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblMainCoilMachine;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblMainCoilBatch;
        private System.Windows.Forms.TextBox txtMainCoilCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.DataGridView dgvCoilsDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.Label lblUnit9;
        private System.Windows.Forms.Label lblCoilsWeigth;
        private System.Windows.Forms.Label lblCoilsWeigthLabel;
        private System.Windows.Forms.Label lblUnit10;
        private System.Windows.Forms.TextBox txtUsedLength;
        private System.Windows.Forms.Label lblUsedLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListLabRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilUsedLenth;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCloseStop;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.ComboBox cmbDigitizer;
        private System.Windows.Forms.Label lblDigitizer;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Button btnRegisterCoils;
        private System.Windows.Forms.ToolTip ttpStops;
    }
}