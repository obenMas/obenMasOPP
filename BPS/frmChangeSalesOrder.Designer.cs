namespace BPS
{
    partial class frmChangeSalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeSalesOrder));
            this.tbcChangeSalesOrder = new System.Windows.Forms.TabControl();
            this.tbpFilmSelection = new System.Windows.Forms.TabPage();
            this.grpbFilms = new System.Windows.Forms.GroupBox();
            this.tbcFilmLists = new System.Windows.Forms.TabControl();
            this.tbpBopp = new System.Windows.Forms.TabPage();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.btnAddNewBopp = new System.Windows.Forms.Button();
            this.btnRefreshBopp = new System.Windows.Forms.Button();
            this.txtBoppName = new System.Windows.Forms.TextBox();
            this.lblBoppName = new System.Windows.Forms.Label();
            this.txtBoppCode = new System.Windows.Forms.TextBox();
            this.lblBoppCode = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCast = new System.Windows.Forms.TabPage();
            this.grpbFiltersCast = new System.Windows.Forms.GroupBox();
            this.brnAddNewCast = new System.Windows.Forms.Button();
            this.btnRefreshCast = new System.Windows.Forms.Button();
            this.txtCastName = new System.Windows.Forms.TextBox();
            this.lblCastName = new System.Windows.Forms.Label();
            this.txtCastCode = new System.Windows.Forms.TextBox();
            this.lblCastCode = new System.Windows.Forms.Label();
            this.dgvProductCast = new System.Windows.Forms.DataGridView();
            this.clmCastCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCastweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCuttingPlan = new System.Windows.Forms.TabPage();
            this.chkStockCoils = new System.Windows.Forms.CheckBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblCoils = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.nudCoilsToChange = new System.Windows.Forms.NumericUpDown();
            this.grpbDestinationSalesOrders = new System.Windows.Forms.GroupBox();
            this.chkDestinationStock = new System.Windows.Forms.CheckBox();
            this.dgvDestinationSalesOrderDetail = new System.Windows.Forms.DataGridView();
            this.clmDestinationSalesOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderTotalOrderCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderCoilsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationSalesOrderCoreDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.grpbSalesOrders = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrderDetail = new System.Windows.Forms.DataGridView();
            this.clmSalesOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderTotalOrderCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCoilsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCoreDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilmNameSalesOrderTab = new System.Windows.Forms.GroupBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.tbpResume = new System.Windows.Forms.TabPage();
            this.dgvChangeOrderSummary = new System.Windows.Forms.DataGridView();
            this.clmChangeOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeOrderStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmChangeOrderCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.ttpCuttingOrder = new System.Windows.Forms.ToolTip(this.components);
            this.tbcChangeSalesOrder.SuspendLayout();
            this.tbpFilmSelection.SuspendLayout();
            this.grpbFilms.SuspendLayout();
            this.tbcFilmLists.SuspendLayout();
            this.tbpBopp.SuspendLayout();
            this.grpbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tbpCast.SuspendLayout();
            this.grpbFiltersCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCast)).BeginInit();
            this.tbpCuttingPlan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoilsToChange)).BeginInit();
            this.grpbDestinationSalesOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinationSalesOrderDetail)).BeginInit();
            this.grpbNotes.SuspendLayout();
            this.grpbMainCoilButtons.SuspendLayout();
            this.grpbSalesOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderDetail)).BeginInit();
            this.grpbFilmNameSalesOrderTab.SuspendLayout();
            this.tbpResume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeOrderSummary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcChangeSalesOrder
            // 
            this.tbcChangeSalesOrder.Controls.Add(this.tbpFilmSelection);
            this.tbcChangeSalesOrder.Controls.Add(this.tbpCuttingPlan);
            this.tbcChangeSalesOrder.Controls.Add(this.tbpResume);
            this.tbcChangeSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcChangeSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.tbcChangeSalesOrder.Name = "tbcChangeSalesOrder";
            this.tbcChangeSalesOrder.SelectedIndex = 0;
            this.tbcChangeSalesOrder.Size = new System.Drawing.Size(961, 615);
            this.tbcChangeSalesOrder.TabIndex = 0;
            // 
            // tbpFilmSelection
            // 
            this.tbpFilmSelection.BackColor = System.Drawing.SystemColors.Window;
            this.tbpFilmSelection.Controls.Add(this.grpbFilms);
            this.tbpFilmSelection.Location = new System.Drawing.Point(4, 24);
            this.tbpFilmSelection.Name = "tbpFilmSelection";
            this.tbpFilmSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFilmSelection.Size = new System.Drawing.Size(953, 587);
            this.tbpFilmSelection.TabIndex = 0;
            this.tbpFilmSelection.Text = "Selección de película";
            // 
            // grpbFilms
            // 
            this.grpbFilms.Controls.Add(this.tbcFilmLists);
            this.grpbFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbFilms.Location = new System.Drawing.Point(3, 3);
            this.grpbFilms.Name = "grpbFilms";
            this.grpbFilms.Size = new System.Drawing.Size(947, 581);
            this.grpbFilms.TabIndex = 0;
            this.grpbFilms.TabStop = false;
            this.grpbFilms.Text = "Peliculas";
            // 
            // tbcFilmLists
            // 
            this.tbcFilmLists.Controls.Add(this.tbpBopp);
            this.tbcFilmLists.Controls.Add(this.tbpCast);
            this.tbcFilmLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcFilmLists.Location = new System.Drawing.Point(3, 17);
            this.tbcFilmLists.Name = "tbcFilmLists";
            this.tbcFilmLists.SelectedIndex = 0;
            this.tbcFilmLists.Size = new System.Drawing.Size(941, 561);
            this.tbcFilmLists.TabIndex = 1;
            // 
            // tbpBopp
            // 
            this.tbpBopp.Controls.Add(this.grpbFilters);
            this.tbpBopp.Controls.Add(this.dgvProducts);
            this.tbpBopp.Location = new System.Drawing.Point(4, 24);
            this.tbpBopp.Name = "tbpBopp";
            this.tbpBopp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBopp.Size = new System.Drawing.Size(933, 533);
            this.tbpBopp.TabIndex = 0;
            this.tbpBopp.Text = "Películas BOPP";
            this.tbpBopp.UseVisualStyleBackColor = true;
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.btnAddNewBopp);
            this.grpbFilters.Controls.Add(this.btnRefreshBopp);
            this.grpbFilters.Controls.Add(this.txtBoppName);
            this.grpbFilters.Controls.Add(this.lblBoppName);
            this.grpbFilters.Controls.Add(this.txtBoppCode);
            this.grpbFilters.Controls.Add(this.lblBoppCode);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(3, 3);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(927, 43);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            // 
            // btnAddNewBopp
            // 
            this.btnAddNewBopp.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddNewBopp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewBopp.Location = new System.Drawing.Point(730, 12);
            this.btnAddNewBopp.Name = "btnAddNewBopp";
            this.btnAddNewBopp.Size = new System.Drawing.Size(25, 25);
            this.btnAddNewBopp.TabIndex = 5;
            this.btnAddNewBopp.UseVisualStyleBackColor = true;
            this.btnAddNewBopp.Click += new System.EventHandler(this.btnAddNewBopp_Click);
            // 
            // btnRefreshBopp
            // 
            this.btnRefreshBopp.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefreshBopp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshBopp.Location = new System.Drawing.Point(704, 12);
            this.btnRefreshBopp.Name = "btnRefreshBopp";
            this.btnRefreshBopp.Size = new System.Drawing.Size(25, 25);
            this.btnRefreshBopp.TabIndex = 5;
            this.btnRefreshBopp.UseVisualStyleBackColor = true;
            this.btnRefreshBopp.Click += new System.EventHandler(this.btnRefreshBopp_Click);
            // 
            // txtBoppName
            // 
            this.txtBoppName.Location = new System.Drawing.Point(496, 14);
            this.txtBoppName.Name = "txtBoppName";
            this.txtBoppName.Size = new System.Drawing.Size(202, 21);
            this.txtBoppName.TabIndex = 3;
            this.txtBoppName.TextChanged += new System.EventHandler(this.txtBoppName_TextChanged);
            // 
            // lblBoppName
            // 
            this.lblBoppName.AutoSize = true;
            this.lblBoppName.Location = new System.Drawing.Point(436, 17);
            this.lblBoppName.Name = "lblBoppName";
            this.lblBoppName.Size = new System.Drawing.Size(52, 15);
            this.lblBoppName.TabIndex = 2;
            this.lblBoppName.Text = "Nombre";
            // 
            // txtBoppCode
            // 
            this.txtBoppCode.Location = new System.Drawing.Point(226, 14);
            this.txtBoppCode.Name = "txtBoppCode";
            this.txtBoppCode.Size = new System.Drawing.Size(202, 21);
            this.txtBoppCode.TabIndex = 1;
            this.txtBoppCode.TextChanged += new System.EventHandler(this.txtBoppCode_TextChanged);
            // 
            // lblBoppCode
            // 
            this.lblBoppCode.AutoSize = true;
            this.lblBoppCode.Location = new System.Drawing.Point(172, 17);
            this.lblBoppCode.Name = "lblBoppCode";
            this.lblBoppCode.Size = new System.Drawing.Size(46, 15);
            this.lblBoppCode.TabIndex = 0;
            this.lblBoppCode.Text = "Código";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmProduct,
            this.clmWidth,
            this.clmCore,
            this.clmDiameter,
            this.clmWeigth});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProducts.Location = new System.Drawing.Point(3, 54);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(927, 476);
            this.dgvProducts.TabIndex = 1;
            this.dgvProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBopp_CellMouseDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Codigo";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmProduct
            // 
            this.clmProduct.HeaderText = "Producto";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            this.clmProduct.Width = 300;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            // 
            // tbpCast
            // 
            this.tbpCast.Controls.Add(this.grpbFiltersCast);
            this.tbpCast.Controls.Add(this.dgvProductCast);
            this.tbpCast.Location = new System.Drawing.Point(4, 24);
            this.tbpCast.Name = "tbpCast";
            this.tbpCast.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCast.Size = new System.Drawing.Size(933, 533);
            this.tbpCast.TabIndex = 1;
            this.tbpCast.Text = "Películas Cast";
            this.tbpCast.UseVisualStyleBackColor = true;
            // 
            // grpbFiltersCast
            // 
            this.grpbFiltersCast.Controls.Add(this.brnAddNewCast);
            this.grpbFiltersCast.Controls.Add(this.btnRefreshCast);
            this.grpbFiltersCast.Controls.Add(this.txtCastName);
            this.grpbFiltersCast.Controls.Add(this.lblCastName);
            this.grpbFiltersCast.Controls.Add(this.txtCastCode);
            this.grpbFiltersCast.Controls.Add(this.lblCastCode);
            this.grpbFiltersCast.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFiltersCast.Location = new System.Drawing.Point(3, 3);
            this.grpbFiltersCast.Name = "grpbFiltersCast";
            this.grpbFiltersCast.Size = new System.Drawing.Size(927, 43);
            this.grpbFiltersCast.TabIndex = 0;
            this.grpbFiltersCast.TabStop = false;
            // 
            // brnAddNewCast
            // 
            this.brnAddNewCast.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.brnAddNewCast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnAddNewCast.Location = new System.Drawing.Point(730, 12);
            this.brnAddNewCast.Name = "brnAddNewCast";
            this.brnAddNewCast.Size = new System.Drawing.Size(25, 25);
            this.brnAddNewCast.TabIndex = 6;
            this.brnAddNewCast.UseVisualStyleBackColor = true;
            this.brnAddNewCast.Click += new System.EventHandler(this.brnAddNewCast_Click);
            // 
            // btnRefreshCast
            // 
            this.btnRefreshCast.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefreshCast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshCast.Location = new System.Drawing.Point(704, 12);
            this.btnRefreshCast.Name = "btnRefreshCast";
            this.btnRefreshCast.Size = new System.Drawing.Size(25, 25);
            this.btnRefreshCast.TabIndex = 5;
            this.btnRefreshCast.UseVisualStyleBackColor = true;
            this.btnRefreshCast.Click += new System.EventHandler(this.btnRefreshCast_Click);
            // 
            // txtCastName
            // 
            this.txtCastName.Location = new System.Drawing.Point(496, 14);
            this.txtCastName.Name = "txtCastName";
            this.txtCastName.Size = new System.Drawing.Size(202, 21);
            this.txtCastName.TabIndex = 3;
            this.txtCastName.TextChanged += new System.EventHandler(this.txtCastName_TextChanged);
            // 
            // lblCastName
            // 
            this.lblCastName.AutoSize = true;
            this.lblCastName.Location = new System.Drawing.Point(436, 17);
            this.lblCastName.Name = "lblCastName";
            this.lblCastName.Size = new System.Drawing.Size(52, 15);
            this.lblCastName.TabIndex = 2;
            this.lblCastName.Text = "Nombre";
            // 
            // txtCastCode
            // 
            this.txtCastCode.Location = new System.Drawing.Point(226, 14);
            this.txtCastCode.Name = "txtCastCode";
            this.txtCastCode.Size = new System.Drawing.Size(202, 21);
            this.txtCastCode.TabIndex = 1;
            this.txtCastCode.TextChanged += new System.EventHandler(this.txtCastCode_TextChanged);
            // 
            // lblCastCode
            // 
            this.lblCastCode.AutoSize = true;
            this.lblCastCode.Location = new System.Drawing.Point(172, 17);
            this.lblCastCode.Name = "lblCastCode";
            this.lblCastCode.Size = new System.Drawing.Size(46, 15);
            this.lblCastCode.TabIndex = 0;
            this.lblCastCode.Text = "Código";
            // 
            // dgvProductCast
            // 
            this.dgvProductCast.AllowUserToAddRows = false;
            this.dgvProductCast.AllowUserToDeleteRows = false;
            this.dgvProductCast.AllowUserToOrderColumns = true;
            this.dgvProductCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductCast.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCastCodsec,
            this.clmCastCode,
            this.clmCastName,
            this.clmCastWidth,
            this.clmCastCore,
            this.clmCastDiameter,
            this.clmCastweigth});
            this.dgvProductCast.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductCast.Location = new System.Drawing.Point(3, 54);
            this.dgvProductCast.MultiSelect = false;
            this.dgvProductCast.Name = "dgvProductCast";
            this.dgvProductCast.ReadOnly = true;
            this.dgvProductCast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductCast.Size = new System.Drawing.Size(927, 476);
            this.dgvProductCast.TabIndex = 1;
            this.dgvProductCast.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProductCast_CellMouseDoubleClick);
            // 
            // clmCastCodsec
            // 
            this.clmCastCodsec.HeaderText = "codsec";
            this.clmCastCodsec.Name = "clmCastCodsec";
            this.clmCastCodsec.ReadOnly = true;
            this.clmCastCodsec.Visible = false;
            // 
            // clmCastCode
            // 
            this.clmCastCode.HeaderText = "Codigo";
            this.clmCastCode.Name = "clmCastCode";
            this.clmCastCode.ReadOnly = true;
            // 
            // clmCastName
            // 
            this.clmCastName.HeaderText = "Producto";
            this.clmCastName.Name = "clmCastName";
            this.clmCastName.ReadOnly = true;
            this.clmCastName.Width = 300;
            // 
            // clmCastWidth
            // 
            this.clmCastWidth.HeaderText = "Ancho";
            this.clmCastWidth.Name = "clmCastWidth";
            this.clmCastWidth.ReadOnly = true;
            // 
            // clmCastCore
            // 
            this.clmCastCore.HeaderText = "Core";
            this.clmCastCore.Name = "clmCastCore";
            this.clmCastCore.ReadOnly = true;
            // 
            // clmCastDiameter
            // 
            this.clmCastDiameter.HeaderText = "Diametro";
            this.clmCastDiameter.Name = "clmCastDiameter";
            this.clmCastDiameter.ReadOnly = true;
            // 
            // clmCastweigth
            // 
            this.clmCastweigth.HeaderText = "Peso";
            this.clmCastweigth.Name = "clmCastweigth";
            this.clmCastweigth.ReadOnly = true;
            // 
            // tbpCuttingPlan
            // 
            this.tbpCuttingPlan.BackColor = System.Drawing.SystemColors.Window;
            this.tbpCuttingPlan.Controls.Add(this.chkDestinationStock);
            this.tbpCuttingPlan.Controls.Add(this.chkStockCoils);
            this.tbpCuttingPlan.Controls.Add(this.lblTo);
            this.tbpCuttingPlan.Controls.Add(this.lblFrom);
            this.tbpCuttingPlan.Controls.Add(this.lblFor);
            this.tbpCuttingPlan.Controls.Add(this.lblOf);
            this.tbpCuttingPlan.Controls.Add(this.lblCoils);
            this.tbpCuttingPlan.Controls.Add(this.lblChange);
            this.tbpCuttingPlan.Controls.Add(this.nudCoilsToChange);
            this.tbpCuttingPlan.Controls.Add(this.grpbDestinationSalesOrders);
            this.tbpCuttingPlan.Controls.Add(this.grpbNotes);
            this.tbpCuttingPlan.Controls.Add(this.grpbMainCoilButtons);
            this.tbpCuttingPlan.Controls.Add(this.grpbSalesOrders);
            this.tbpCuttingPlan.Controls.Add(this.grpbFilmNameSalesOrderTab);
            this.tbpCuttingPlan.Location = new System.Drawing.Point(4, 24);
            this.tbpCuttingPlan.Name = "tbpCuttingPlan";
            this.tbpCuttingPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCuttingPlan.Size = new System.Drawing.Size(953, 587);
            this.tbpCuttingPlan.TabIndex = 1;
            this.tbpCuttingPlan.Text = "Ordenes de venta";
            // 
            // chkStockCoils
            // 
            this.chkStockCoils.AutoSize = true;
            this.chkStockCoils.Location = new System.Drawing.Point(159, 45);
            this.chkStockCoils.Name = "chkStockCoils";
            this.chkStockCoils.Size = new System.Drawing.Size(147, 19);
            this.chkStockCoils.TabIndex = 1;
            this.chkStockCoils.Text = "Usar bobinas de stock";
            this.chkStockCoils.UseVisualStyleBackColor = true;
            this.chkStockCoils.CheckedChanged += new System.EventHandler(this.chkStockCoils_CheckedChanged);
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(616, 463);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(314, 28);
            this.lblTo.TabIndex = 9;
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(279, 463);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(314, 28);
            this.lblFrom.TabIndex = 7;
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFor.Location = new System.Drawing.Point(593, 463);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(23, 25);
            this.lblFor.TabIndex = 8;
            this.lblFor.Text = "a";
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOf.Location = new System.Drawing.Point(245, 463);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(34, 25);
            this.lblOf.TabIndex = 6;
            this.lblOf.Text = "de";
            // 
            // lblCoils
            // 
            this.lblCoils.AutoSize = true;
            this.lblCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoils.Location = new System.Drawing.Point(162, 463);
            this.lblCoils.Name = "lblCoils";
            this.lblCoils.Size = new System.Drawing.Size(83, 25);
            this.lblCoils.TabIndex = 5;
            this.lblCoils.Text = "Bobinas";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(23, 463);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(86, 25);
            this.lblChange.TabIndex = 3;
            this.lblChange.Text = "Cambiar";
            // 
            // nudCoilsToChange
            // 
            this.nudCoilsToChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCoilsToChange.Location = new System.Drawing.Point(109, 461);
            this.nudCoilsToChange.Name = "nudCoilsToChange";
            this.nudCoilsToChange.Size = new System.Drawing.Size(53, 30);
            this.nudCoilsToChange.TabIndex = 4;
            // 
            // grpbDestinationSalesOrders
            // 
            this.grpbDestinationSalesOrders.Controls.Add(this.dgvDestinationSalesOrderDetail);
            this.grpbDestinationSalesOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDestinationSalesOrders.Location = new System.Drawing.Point(3, 253);
            this.grpbDestinationSalesOrders.Name = "grpbDestinationSalesOrders";
            this.grpbDestinationSalesOrders.Size = new System.Drawing.Size(947, 207);
            this.grpbDestinationSalesOrders.TabIndex = 2;
            this.grpbDestinationSalesOrders.TabStop = false;
            this.grpbDestinationSalesOrders.Text = "Ordenes de venta destino";
            // 
            // chkDestinationStock
            // 
            this.chkDestinationStock.AutoSize = true;
            this.chkDestinationStock.Location = new System.Drawing.Point(159, 252);
            this.chkDestinationStock.Name = "chkDestinationStock";
            this.chkDestinationStock.Size = new System.Drawing.Size(147, 19);
            this.chkDestinationStock.TabIndex = 13;
            this.chkDestinationStock.Text = "Usar bobinas de stock";
            this.chkDestinationStock.UseVisualStyleBackColor = true;
            this.chkDestinationStock.CheckedChanged += new System.EventHandler(this.chkDestinationStock_CheckedChanged);
            // 
            // dgvDestinationSalesOrderDetail
            // 
            this.dgvDestinationSalesOrderDetail.AllowUserToAddRows = false;
            this.dgvDestinationSalesOrderDetail.AllowUserToDeleteRows = false;
            this.dgvDestinationSalesOrderDetail.AllowUserToOrderColumns = true;
            this.dgvDestinationSalesOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinationSalesOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDestinationSalesOrderCodsec,
            this.clmDestinationSalesOrderCustomer,
            this.clmDestinationSalesOrderNumber,
            this.clmDestinationSalesOrderProduct,
            this.clmDestinationSalesOrderWeigth,
            this.clmDestinationSalesOrderTotalOrderCoils,
            this.clmDestinationSalesOrderCoilsQuantity,
            this.clmDestinationSalesOrderWidth,
            this.clmDestinationSalesOrderCoreDiameter});
            this.dgvDestinationSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDestinationSalesOrderDetail.Location = new System.Drawing.Point(3, 24);
            this.dgvDestinationSalesOrderDetail.Name = "dgvDestinationSalesOrderDetail";
            this.dgvDestinationSalesOrderDetail.RowHeadersWidth = 25;
            this.dgvDestinationSalesOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinationSalesOrderDetail.Size = new System.Drawing.Size(941, 180);
            this.dgvDestinationSalesOrderDetail.TabIndex = 0;
            this.dgvDestinationSalesOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinationSalesOrderDetail_CellDoubleClick);
            // 
            // clmDestinationSalesOrderCodsec
            // 
            this.clmDestinationSalesOrderCodsec.HeaderText = "codsec";
            this.clmDestinationSalesOrderCodsec.Name = "clmDestinationSalesOrderCodsec";
            this.clmDestinationSalesOrderCodsec.ReadOnly = true;
            this.clmDestinationSalesOrderCodsec.Visible = false;
            // 
            // clmDestinationSalesOrderCustomer
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDestinationSalesOrderCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmDestinationSalesOrderCustomer.HeaderText = "Cliente";
            this.clmDestinationSalesOrderCustomer.Name = "clmDestinationSalesOrderCustomer";
            this.clmDestinationSalesOrderCustomer.ReadOnly = true;
            this.clmDestinationSalesOrderCustomer.Width = 150;
            // 
            // clmDestinationSalesOrderNumber
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDestinationSalesOrderNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDestinationSalesOrderNumber.HeaderText = "O. Venta";
            this.clmDestinationSalesOrderNumber.Name = "clmDestinationSalesOrderNumber";
            this.clmDestinationSalesOrderNumber.ReadOnly = true;
            this.clmDestinationSalesOrderNumber.Width = 80;
            // 
            // clmDestinationSalesOrderProduct
            // 
            this.clmDestinationSalesOrderProduct.HeaderText = "Producto";
            this.clmDestinationSalesOrderProduct.Name = "clmDestinationSalesOrderProduct";
            this.clmDestinationSalesOrderProduct.ReadOnly = true;
            this.clmDestinationSalesOrderProduct.Width = 200;
            // 
            // clmDestinationSalesOrderWeigth
            // 
            this.clmDestinationSalesOrderWeigth.HeaderText = "Peso";
            this.clmDestinationSalesOrderWeigth.Name = "clmDestinationSalesOrderWeigth";
            this.clmDestinationSalesOrderWeigth.ReadOnly = true;
            this.clmDestinationSalesOrderWeigth.Width = 90;
            // 
            // clmDestinationSalesOrderTotalOrderCoils
            // 
            this.clmDestinationSalesOrderTotalOrderCoils.HeaderText = "T. Bobinas";
            this.clmDestinationSalesOrderTotalOrderCoils.Name = "clmDestinationSalesOrderTotalOrderCoils";
            this.clmDestinationSalesOrderTotalOrderCoils.ReadOnly = true;
            this.clmDestinationSalesOrderTotalOrderCoils.Width = 90;
            // 
            // clmDestinationSalesOrderCoilsQuantity
            // 
            this.clmDestinationSalesOrderCoilsQuantity.HeaderText = "Faltantes";
            this.clmDestinationSalesOrderCoilsQuantity.Name = "clmDestinationSalesOrderCoilsQuantity";
            this.clmDestinationSalesOrderCoilsQuantity.ReadOnly = true;
            this.clmDestinationSalesOrderCoilsQuantity.Width = 90;
            // 
            // clmDestinationSalesOrderWidth
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDestinationSalesOrderWidth.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmDestinationSalesOrderWidth.HeaderText = "Ancho";
            this.clmDestinationSalesOrderWidth.Name = "clmDestinationSalesOrderWidth";
            this.clmDestinationSalesOrderWidth.ReadOnly = true;
            this.clmDestinationSalesOrderWidth.Width = 90;
            // 
            // clmDestinationSalesOrderCoreDiameter
            // 
            this.clmDestinationSalesOrderCoreDiameter.HeaderText = "Diam./ Core";
            this.clmDestinationSalesOrderCoreDiameter.Name = "clmDestinationSalesOrderCoreDiameter";
            this.clmDestinationSalesOrderCoreDiameter.ReadOnly = true;
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtNotes);
            this.grpbNotes.Location = new System.Drawing.Point(6, 491);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(944, 56);
            this.grpbNotes.TabIndex = 10;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Observaciones";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 17);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(938, 36);
            this.txtNotes.TabIndex = 0;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbMainCoilButtons.Controls.Add(this.btnNext);
            this.grpbMainCoilButtons.Controls.Add(this.btnAdd);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(866, 540);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(84, 44);
            this.grpbMainCoilButtons.TabIndex = 12;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::BPS.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(55, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(25, 25);
            this.btnNext.TabIndex = 2;
            this.ttpCuttingOrder.SetToolTip(this.btnNext, "Resumen");
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(5, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 0;
            this.ttpCuttingOrder.SetToolTip(this.btnAdd, "Agregar Programación Corte");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(30, 14);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 1;
            this.ttpCuttingOrder.SetToolTip(this.btnMainCoilCancel, "Cancelar Programación de Corte");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilCancel.Click += new System.EventHandler(this.btnMainCoilCancel_Click);
            // 
            // grpbSalesOrders
            // 
            this.grpbSalesOrders.Controls.Add(this.dgvSalesOrderDetail);
            this.grpbSalesOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrders.Location = new System.Drawing.Point(3, 46);
            this.grpbSalesOrders.Name = "grpbSalesOrders";
            this.grpbSalesOrders.Size = new System.Drawing.Size(947, 207);
            this.grpbSalesOrders.TabIndex = 0;
            this.grpbSalesOrders.TabStop = false;
            this.grpbSalesOrders.Text = "Ordenes de venta origen";
            // 
            // dgvSalesOrderDetail
            // 
            this.dgvSalesOrderDetail.AllowUserToAddRows = false;
            this.dgvSalesOrderDetail.AllowUserToDeleteRows = false;
            this.dgvSalesOrderDetail.AllowUserToOrderColumns = true;
            this.dgvSalesOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSalesOrderCodsec,
            this.clmSalesOrderCustomer,
            this.clmSalesOrderNumber,
            this.clmSalesOrderProduct,
            this.clmSalesOrderWeigth,
            this.clmSalesOrderTotalOrderCoils,
            this.clmSalesOrderCoilsQuantity,
            this.clmSalesOrderWidth,
            this.clmSalesOrderCoreDiameter});
            this.dgvSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSalesOrderDetail.Location = new System.Drawing.Point(3, 24);
            this.dgvSalesOrderDetail.Name = "dgvSalesOrderDetail";
            this.dgvSalesOrderDetail.RowHeadersWidth = 25;
            this.dgvSalesOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrderDetail.Size = new System.Drawing.Size(941, 180);
            this.dgvSalesOrderDetail.TabIndex = 0;
            this.dgvSalesOrderDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrderDetail_CellDoubleClick);
            // 
            // clmSalesOrderCodsec
            // 
            this.clmSalesOrderCodsec.HeaderText = "codsec";
            this.clmSalesOrderCodsec.Name = "clmSalesOrderCodsec";
            this.clmSalesOrderCodsec.ReadOnly = true;
            this.clmSalesOrderCodsec.Visible = false;
            // 
            // clmSalesOrderCustomer
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSalesOrderCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmSalesOrderCustomer.HeaderText = "Cliente";
            this.clmSalesOrderCustomer.Name = "clmSalesOrderCustomer";
            this.clmSalesOrderCustomer.ReadOnly = true;
            this.clmSalesOrderCustomer.Width = 150;
            // 
            // clmSalesOrderNumber
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSalesOrderNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmSalesOrderNumber.HeaderText = "O. Venta";
            this.clmSalesOrderNumber.Name = "clmSalesOrderNumber";
            this.clmSalesOrderNumber.ReadOnly = true;
            this.clmSalesOrderNumber.Width = 80;
            // 
            // clmSalesOrderProduct
            // 
            this.clmSalesOrderProduct.HeaderText = "Producto";
            this.clmSalesOrderProduct.Name = "clmSalesOrderProduct";
            this.clmSalesOrderProduct.ReadOnly = true;
            this.clmSalesOrderProduct.Width = 200;
            // 
            // clmSalesOrderWeigth
            // 
            this.clmSalesOrderWeigth.HeaderText = "Peso";
            this.clmSalesOrderWeigth.Name = "clmSalesOrderWeigth";
            this.clmSalesOrderWeigth.ReadOnly = true;
            this.clmSalesOrderWeigth.Width = 90;
            // 
            // clmSalesOrderTotalOrderCoils
            // 
            this.clmSalesOrderTotalOrderCoils.HeaderText = "T. Bobinas";
            this.clmSalesOrderTotalOrderCoils.Name = "clmSalesOrderTotalOrderCoils";
            this.clmSalesOrderTotalOrderCoils.ReadOnly = true;
            this.clmSalesOrderTotalOrderCoils.Width = 90;
            // 
            // clmSalesOrderCoilsQuantity
            // 
            this.clmSalesOrderCoilsQuantity.HeaderText = "Faltantes";
            this.clmSalesOrderCoilsQuantity.Name = "clmSalesOrderCoilsQuantity";
            this.clmSalesOrderCoilsQuantity.ReadOnly = true;
            this.clmSalesOrderCoilsQuantity.Width = 90;
            // 
            // clmSalesOrderWidth
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSalesOrderWidth.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmSalesOrderWidth.HeaderText = "Ancho";
            this.clmSalesOrderWidth.Name = "clmSalesOrderWidth";
            this.clmSalesOrderWidth.ReadOnly = true;
            this.clmSalesOrderWidth.Width = 90;
            // 
            // clmSalesOrderCoreDiameter
            // 
            this.clmSalesOrderCoreDiameter.HeaderText = "Diam./ Core";
            this.clmSalesOrderCoreDiameter.Name = "clmSalesOrderCoreDiameter";
            this.clmSalesOrderCoreDiameter.ReadOnly = true;
            // 
            // grpbFilmNameSalesOrderTab
            // 
            this.grpbFilmNameSalesOrderTab.Controls.Add(this.lblFilmName);
            this.grpbFilmNameSalesOrderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilmNameSalesOrderTab.Location = new System.Drawing.Point(3, 3);
            this.grpbFilmNameSalesOrderTab.Name = "grpbFilmNameSalesOrderTab";
            this.grpbFilmNameSalesOrderTab.Size = new System.Drawing.Size(947, 43);
            this.grpbFilmNameSalesOrderTab.TabIndex = 0;
            this.grpbFilmNameSalesOrderTab.TabStop = false;
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(3, 17);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(941, 23);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpResume
            // 
            this.tbpResume.AutoScroll = true;
            this.tbpResume.BackColor = System.Drawing.SystemColors.Window;
            this.tbpResume.Controls.Add(this.dgvChangeOrderSummary);
            this.tbpResume.Controls.Add(this.groupBox2);
            this.tbpResume.Controls.Add(this.groupBox1);
            this.tbpResume.Location = new System.Drawing.Point(4, 24);
            this.tbpResume.Name = "tbpResume";
            this.tbpResume.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResume.Size = new System.Drawing.Size(953, 587);
            this.tbpResume.TabIndex = 2;
            this.tbpResume.Text = "Resumen";
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
            this.clmChangeOrderStatus,
            this.clmChangeOrderCancel});
            this.dgvChangeOrderSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvChangeOrderSummary.Location = new System.Drawing.Point(3, 3);
            this.dgvChangeOrderSummary.Name = "dgvChangeOrderSummary";
            this.dgvChangeOrderSummary.ReadOnly = true;
            this.dgvChangeOrderSummary.Size = new System.Drawing.Size(947, 534);
            this.dgvChangeOrderSummary.TabIndex = 0;
            this.dgvChangeOrderSummary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChangeOrderSummary_CellClick);
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
            this.clmChangeOrderFrom.Width = 250;
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
            this.clmChangeOrderTo.Width = 250;
            // 
            // clmChangeOrderDate
            // 
            this.clmChangeOrderDate.HeaderText = "Fecha";
            this.clmChangeOrderDate.Name = "clmChangeOrderDate";
            this.clmChangeOrderDate.ReadOnly = true;
            this.clmChangeOrderDate.Width = 150;
            // 
            // clmChangeOrderStatus
            // 
            this.clmChangeOrderStatus.HeaderText = "";
            this.clmChangeOrderStatus.Name = "clmChangeOrderStatus";
            this.clmChangeOrderStatus.ReadOnly = true;
            this.clmChangeOrderStatus.Width = 30;
            // 
            // clmChangeOrderCancel
            // 
            this.clmChangeOrderCancel.HeaderText = "";
            this.clmChangeOrderCancel.Name = "clmChangeOrderCancel";
            this.clmChangeOrderCancel.ReadOnly = true;
            this.clmChangeOrderCancel.Width = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(3, 535);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(909, 44);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Location = new System.Drawing.Point(916, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(34, 44);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(5, 14);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.ttpCuttingOrder.SetToolTip(this.btnReport, "Agregar Programación Corte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmChangeSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(961, 615);
            this.Controls.Add(this.tbcChangeSalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeSalesOrder";
            this.Text = "Cambio de ordenes de venta";
            this.Load += new System.EventHandler(this.frmCuttingOrder_Load);
            this.tbcChangeSalesOrder.ResumeLayout(false);
            this.tbpFilmSelection.ResumeLayout(false);
            this.grpbFilms.ResumeLayout(false);
            this.tbcFilmLists.ResumeLayout(false);
            this.tbpBopp.ResumeLayout(false);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tbpCast.ResumeLayout(false);
            this.grpbFiltersCast.ResumeLayout(false);
            this.grpbFiltersCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductCast)).EndInit();
            this.tbpCuttingPlan.ResumeLayout(false);
            this.tbpCuttingPlan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoilsToChange)).EndInit();
            this.grpbDestinationSalesOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinationSalesOrderDetail)).EndInit();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.grpbSalesOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderDetail)).EndInit();
            this.grpbFilmNameSalesOrderTab.ResumeLayout(false);
            this.tbpResume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeOrderSummary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcChangeSalesOrder;
        private System.Windows.Forms.TabPage tbpFilmSelection;
        private System.Windows.Forms.TabPage tbpCuttingPlan;
        private System.Windows.Forms.TabPage tbpResume;
        private System.Windows.Forms.GroupBox grpbFilmNameSalesOrderTab;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.GroupBox grpbFilms;
        private System.Windows.Forms.GroupBox grpbSalesOrders;
        private System.Windows.Forms.DataGridView dgvSalesOrderDetail;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.ToolTip ttpCuttingOrder;
        private System.Windows.Forms.TabControl tbcFilmLists;
        private System.Windows.Forms.TabPage tbpBopp;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TabPage tbpCast;
        private System.Windows.Forms.DataGridView dgvProductCast;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.TextBox txtBoppName;
        private System.Windows.Forms.Label lblBoppName;
        private System.Windows.Forms.TextBox txtBoppCode;
        private System.Windows.Forms.Label lblBoppCode;
        private System.Windows.Forms.GroupBox grpbFiltersCast;
        private System.Windows.Forms.TextBox txtCastName;
        private System.Windows.Forms.Label lblCastName;
        private System.Windows.Forms.TextBox txtCastCode;
        private System.Windows.Forms.Label lblCastCode;
        private System.Windows.Forms.Button btnRefreshBopp;
        private System.Windows.Forms.Button btnRefreshCast;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnAddNewBopp;
        private System.Windows.Forms.Button brnAddNewCast;
        private System.Windows.Forms.GroupBox grpbDestinationSalesOrders;
        private System.Windows.Forms.DataGridView dgvDestinationSalesOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCastweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderTotalOrderCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderCoilsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationSalesOrderCoreDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderTotalOrderCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCoilsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCoreDiameter;
        private System.Windows.Forms.CheckBox chkStockCoils;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblCoils;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.NumericUpDown nudCoilsToChange;
        private System.Windows.Forms.DataGridView dgvChangeOrderSummary;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmChangeOrderDate;
        private System.Windows.Forms.DataGridViewImageColumn clmChangeOrderStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmChangeOrderCancel;
        private System.Windows.Forms.CheckBox chkDestinationStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}