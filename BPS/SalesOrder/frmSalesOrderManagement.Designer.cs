namespace BPS
{
    partial class frmSalesOrderManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderManagement));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.chkCompromiseDate = new System.Windows.Forms.CheckBox();
            this.dtpInitEndCompromise = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDateCompromise = new System.Windows.Forms.DateTimePicker();
            this.chkExtrusionDate = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMoreThanZero = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMainCoilClearFilters = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMissing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdateCompromise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFooter = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblTotalWeightLabel = new System.Windows.Forms.Label();
            this.lblTotalPallets = new System.Windows.Forms.Label();
            this.lblTotalPalletsLabel = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.rdbIqualToZero = new System.Windows.Forms.RadioButton();
            this.grpbFilters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.grpbFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.chkCompromiseDate);
            this.grpbFilters.Controls.Add(this.dtpInitEndCompromise);
            this.grpbFilters.Controls.Add(this.dtpInitDateCompromise);
            this.grpbFilters.Controls.Add(this.chkExtrusionDate);
            this.grpbFilters.Controls.Add(this.dtpEndDate);
            this.grpbFilters.Controls.Add(this.dtpInitDate);
            this.grpbFilters.Controls.Add(this.groupBox1);
            this.grpbFilters.Controls.Add(this.btnExcel);
            this.grpbFilters.Controls.Add(this.cmbCustomer);
            this.grpbFilters.Controls.Add(this.lblCustomer);
            this.grpbFilters.Controls.Add(this.pictureBox7);
            this.grpbFilters.Controls.Add(this.pictureBox6);
            this.grpbFilters.Controls.Add(this.txtWidth);
            this.grpbFilters.Controls.Add(this.lblWidth);
            this.grpbFilters.Controls.Add(this.btnRefresh);
            this.grpbFilters.Controls.Add(this.btnMainCoilClearFilters);
            this.grpbFilters.Controls.Add(this.cmbOrder);
            this.grpbFilters.Controls.Add(this.cmbFilm);
            this.grpbFilters.Controls.Add(this.lblSalesOrder);
            this.grpbFilters.Controls.Add(this.lblFilmName);
            this.grpbFilters.Controls.Add(this.lblNote);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(0, 0);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(1214, 91);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            this.grpbFilters.Enter += new System.EventHandler(this.grpbFilters_Enter);
            // 
            // chkCompromiseDate
            // 
            this.chkCompromiseDate.AutoSize = true;
            this.chkCompromiseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompromiseDate.Location = new System.Drawing.Point(912, 11);
            this.chkCompromiseDate.Name = "chkCompromiseDate";
            this.chkCompromiseDate.Size = new System.Drawing.Size(150, 19);
            this.chkCompromiseDate.TabIndex = 35;
            this.chkCompromiseDate.Text = "Fecha Compromiso";
            this.chkCompromiseDate.UseVisualStyleBackColor = true;
            this.chkCompromiseDate.CheckedChanged += new System.EventHandler(this.chkCompromiseDate_CheckedChanged);
            // 
            // dtpInitEndCompromise
            // 
            this.dtpInitEndCompromise.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInitEndCompromise.Location = new System.Drawing.Point(912, 58);
            this.dtpInitEndCompromise.Name = "dtpInitEndCompromise";
            this.dtpInitEndCompromise.Size = new System.Drawing.Size(133, 21);
            this.dtpInitEndCompromise.TabIndex = 37;
            // 
            // dtpInitDateCompromise
            // 
            this.dtpInitDateCompromise.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInitDateCompromise.Location = new System.Drawing.Point(912, 30);
            this.dtpInitDateCompromise.Name = "dtpInitDateCompromise";
            this.dtpInitDateCompromise.Size = new System.Drawing.Size(133, 21);
            this.dtpInitDateCompromise.TabIndex = 36;
            // 
            // chkExtrusionDate
            // 
            this.chkExtrusionDate.AutoSize = true;
            this.chkExtrusionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtrusionDate.Location = new System.Drawing.Point(761, 12);
            this.chkExtrusionDate.Name = "chkExtrusionDate";
            this.chkExtrusionDate.Size = new System.Drawing.Size(133, 19);
            this.chkExtrusionDate.TabIndex = 32;
            this.chkExtrusionDate.Text = "Fecha de pedido";
            this.chkExtrusionDate.UseVisualStyleBackColor = true;
            this.chkExtrusionDate.CheckedChanged += new System.EventHandler(this.chkExtrusionDate_CheckedChanged_1);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(761, 59);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(133, 21);
            this.dtpEndDate.TabIndex = 34;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInitDate.Location = new System.Drawing.Point(761, 31);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(133, 21);
            this.dtpInitDate.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIqualToZero);
            this.groupBox1.Controls.Add(this.rdbMoreThanZero);
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Location = new System.Drawing.Point(604, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 77);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Material Faltante";
            // 
            // rdbMoreThanZero
            // 
            this.rdbMoreThanZero.AutoSize = true;
            this.rdbMoreThanZero.Location = new System.Drawing.Point(14, 16);
            this.rdbMoreThanZero.Name = "rdbMoreThanZero";
            this.rdbMoreThanZero.Size = new System.Drawing.Size(93, 19);
            this.rdbMoreThanZero.TabIndex = 1;
            this.rdbMoreThanZero.TabStop = true;
            this.rdbMoreThanZero.Text = "Mayor que 0";
            this.rdbMoreThanZero.UseVisualStyleBackColor = true;
            this.rdbMoreThanZero.CheckedChanged += new System.EventHandler(this.rdbMoreThanZero_CheckedChanged);
            this.rdbMoreThanZero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbMoreThanZero_KeyDown);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(14, 35);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(95, 19);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Menor que 0";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            this.rdbAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbAll_KeyDown);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Location = new System.Drawing.Point(1167, 31);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExcel.TabIndex = 30;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(21, 33);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(227, 23);
            this.cmbCustomer.TabIndex = 28;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged_1);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown_1);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(20, 15);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(52, 15);
            this.lblCustomer.TabIndex = 27;
            this.lblCustomer.Text = "Cliente";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(672, 59);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(0, 11);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(15, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(0, 11);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(507, 34);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(79, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWidthFrom_KeyDown);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(505, 15);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 15);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Ancho";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(1136, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMainCoilClearFilters
            // 
            this.btnMainCoilClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnMainCoilClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilClearFilters.Location = new System.Drawing.Point(1105, 31);
            this.btnMainCoilClearFilters.Name = "btnMainCoilClearFilters";
            this.btnMainCoilClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClearFilters.TabIndex = 19;
            this.btnMainCoilClearFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilClearFilters.Click += new System.EventHandler(this.btnMainCoilClearFilters_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(255, 33);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(114, 23);
            this.cmbOrder.TabIndex = 5;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(377, 33);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(122, 23);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(254, 15);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(46, 15);
            this.lblSalesOrder.TabIndex = 4;
            this.lblSalesOrder.Text = "Orden";
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(374, 15);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(59, 15);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Pelicula";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(33, 62);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(553, 18);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Seleccione una de las opciones o escriba en el campo el criterio de busqueda y pr" +
    "esione enter";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.lblLoading);
            this.grpbDetail.Controls.Add(this.pbxLoading);
            this.grpbDetail.Controls.Add(this.dgvDetails);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetail.Location = new System.Drawing.Point(0, 91);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(1214, 430);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(501, 212);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(213, 34);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Se esta cargando la información de los pedidos\r\nEsto puede tomar algunos segundos" +
    "";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLoading
            // 
            this.pbxLoading.ErrorImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Image = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.InitialImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Location = new System.Drawing.Point(555, 193);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(105, 16);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLoading.TabIndex = 1;
            this.pbxLoading.TabStop = false;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCustomer,
            this.clmSalesOrder,
            this.clmFilm,
            this.clmstatus,
            this.clmWidth,
            this.clmQuantity,
            this.clmExtruder,
            this.clmMissing,
            this.clmcreateDate,
            this.clmdateCompromise,
            this.clmDate});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 14);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 10;
            this.dgvDetails.Size = new System.Drawing.Size(1208, 413);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 170;
            // 
            // clmSalesOrder
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSalesOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmSalesOrder.HeaderText = "Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            this.clmSalesOrder.Width = 70;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pelicula";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            // 
            // clmstatus
            // 
            this.clmstatus.HeaderText = "Estado";
            this.clmstatus.Name = "clmstatus";
            this.clmstatus.ReadOnly = true;
            this.clmstatus.Width = 70;
            // 
            // clmWidth
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmWidth.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 50;
            // 
            // clmQuantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmQuantity.HeaderText = "Cantidad KG";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            // 
            // clmExtruder
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmExtruder.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmExtruder.HeaderText = "Extruidos KG";
            this.clmExtruder.Name = "clmExtruder";
            this.clmExtruder.ReadOnly = true;
            // 
            // clmMissing
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmMissing.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmMissing.HeaderText = "Faltante KG";
            this.clmMissing.Name = "clmMissing";
            this.clmMissing.ReadOnly = true;
            // 
            // clmcreateDate
            // 
            this.clmcreateDate.HeaderText = "F. Pedido";
            this.clmcreateDate.Name = "clmcreateDate";
            this.clmcreateDate.ReadOnly = true;
            this.clmcreateDate.Width = 80;
            // 
            // clmdateCompromise
            // 
            this.clmdateCompromise.HeaderText = "F. Compromiso";
            this.clmdateCompromise.Name = "clmdateCompromise";
            this.clmdateCompromise.ReadOnly = true;
            // 
            // clmDate
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmDate.HeaderText = "Fecha Corte";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 250;
            // 
            // grpbFooter
            // 
            this.grpbFooter.Controls.Add(this.label5);
            this.grpbFooter.Controls.Add(this.label4);
            this.grpbFooter.Controls.Add(this.label3);
            this.grpbFooter.Controls.Add(this.label1);
            this.grpbFooter.Controls.Add(this.label2);
            this.grpbFooter.Controls.Add(this.lblTotalWeight);
            this.grpbFooter.Controls.Add(this.lblTotalWeightLabel);
            this.grpbFooter.Controls.Add(this.lblTotalPallets);
            this.grpbFooter.Controls.Add(this.lblTotalPalletsLabel);
            this.grpbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFooter.Location = new System.Drawing.Point(0, 521);
            this.grpbFooter.Name = "grpbFooter";
            this.grpbFooter.Size = new System.Drawing.Size(1214, 52);
            this.grpbFooter.TabIndex = 2;
            this.grpbFooter.TabStop = false;
            this.grpbFooter.Text = "Resumen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(980, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kgs.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(705, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kgs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kgs.";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(883, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(770, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Faltante";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(608, 17);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(94, 20);
            this.lblTotalWeight.TabIndex = 3;
            this.lblTotalWeight.Text = "0";
            this.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalWeightLabel
            // 
            this.lblTotalWeightLabel.AutoSize = true;
            this.lblTotalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightLabel.Location = new System.Drawing.Point(475, 17);
            this.lblTotalWeightLabel.Name = "lblTotalWeightLabel";
            this.lblTotalWeightLabel.Size = new System.Drawing.Size(127, 20);
            this.lblTotalWeightLabel.TabIndex = 2;
            this.lblTotalWeightLabel.Text = "Total Producción";
            // 
            // lblTotalPallets
            // 
            this.lblTotalPallets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPallets.Location = new System.Drawing.Point(315, 17);
            this.lblTotalPallets.Name = "lblTotalPallets";
            this.lblTotalPallets.Size = new System.Drawing.Size(94, 20);
            this.lblTotalPallets.TabIndex = 1;
            this.lblTotalPallets.Text = "0";
            this.lblTotalPallets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPalletsLabel
            // 
            this.lblTotalPalletsLabel.AutoSize = true;
            this.lblTotalPalletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPalletsLabel.Location = new System.Drawing.Point(204, 17);
            this.lblTotalPalletsLabel.Name = "lblTotalPalletsLabel";
            this.lblTotalPalletsLabel.Size = new System.Drawing.Size(105, 20);
            this.lblTotalPalletsLabel.TabIndex = 0;
            this.lblTotalPalletsLabel.Text = "Total Pedidos";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // rdbIqualToZero
            // 
            this.rdbIqualToZero.AutoSize = true;
            this.rdbIqualToZero.Location = new System.Drawing.Point(14, 54);
            this.rdbIqualToZero.Name = "rdbIqualToZero";
            this.rdbIqualToZero.Size = new System.Drawing.Size(72, 19);
            this.rdbIqualToZero.TabIndex = 2;
            this.rdbIqualToZero.TabStop = true;
            this.rdbIqualToZero.Text = "Igual a 0";
            this.rdbIqualToZero.UseVisualStyleBackColor = true;
            this.rdbIqualToZero.CheckedChanged += new System.EventHandler(this.rdbIqualToZero_CheckedChanged);
            this.rdbIqualToZero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbIqualToZero_KeyDown);
            // 
            // frmSalesOrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1214, 573);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFooter);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderManagement";
            this.Text = "Pedidos Comprobación";
            this.Load += new System.EventHandler(this.frmSalesOrderManagement_Load);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.grpbFooter.ResumeLayout(false);
            this.grpbFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.GroupBox grpbFooter;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMainCoilClearFilters;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lblTotalPallets;
        private System.Windows.Forms.Label lblTotalPalletsLabel;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblTotalWeightLabel;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMissing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdateCompromise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkCompromiseDate;
        private System.Windows.Forms.DateTimePicker dtpInitEndCompromise;
        private System.Windows.Forms.DateTimePicker dtpInitDateCompromise;
        private System.Windows.Forms.CheckBox chkExtrusionDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.RadioButton rdbMoreThanZero;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbIqualToZero;
    }
}