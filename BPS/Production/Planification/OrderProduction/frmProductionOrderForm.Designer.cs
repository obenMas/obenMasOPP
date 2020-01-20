namespace BPS
{
    partial class frmProductionOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionOrderForm));
            this.tbcWizard = new System.Windows.Forms.TabControl();
            this.tbpFilm = new System.Windows.Forms.TabPage();
            this.grpbFilms = new System.Windows.Forms.GroupBox();
            this.dgvBopp = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBaseFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeightFilms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActionsF = new System.Windows.Forms.GroupBox();
            this.btnNextFilmTab = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoppCode = new System.Windows.Forms.TextBox();
            this.lblBoppCode = new System.Windows.Forms.Label();
            this.tbpSalesOrder = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightFullfilledDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightSlopeDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbTotalsSalesOrderTab = new System.Windows.Forms.GroupBox();
            this.btnNextSalesOrderTab = new System.Windows.Forms.Button();
            this.btnBackSalesOrderTab = new System.Windows.Forms.Button();
            this.lblSalesOrderTotalSO = new System.Windows.Forms.Label();
            this.lblTotalWeihtSalesOrder = new System.Windows.Forms.Label();
            this.grpbDetailOne = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsecSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelectSalesOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeigthSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlannifiedWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightFulfilledSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightSlopeSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsPlanned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelectAllSalesOrder = new System.Windows.Forms.CheckBox();
            this.grpbFilmNameSalesOrderTab = new System.Windows.Forms.GroupBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.tbpFinalOrder = new System.Windows.Forms.TabPage();
            this.grpbSalesOrders = new System.Windows.Forms.GroupBox();
            this.dgvSelectedSalesOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsecPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumberPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerNamePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeightPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightFullfilledPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightSlopePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbQuantities = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.lblTotalToExtrude = new System.Windows.Forms.Label();
            this.nudExtraPercentage = new System.Windows.Forms.NumericUpDown();
            this.lblEqual = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblPlus2 = new System.Windows.Forms.Label();
            this.lblPlus1 = new System.Windows.Forms.Label();
            this.txtInnerProduction = new System.Windows.Forms.TextBox();
            this.lblExtraPercentage = new System.Windows.Forms.Label();
            this.lblInnerProgramed = new System.Windows.Forms.Label();
            this.lblSalesOrderTotalValue = new System.Windows.Forms.Label();
            this.lblSalesOrderTotal = new System.Windows.Forms.Label();
            this.grpbFilm = new System.Windows.Forms.GroupBox();
            this.grpbSealsPOTab = new System.Windows.Forms.GroupBox();
            this.lblOuterSealName = new System.Windows.Forms.Label();
            this.lblInnerSealPO = new System.Windows.Forms.Label();
            this.lblInnerSealName = new System.Windows.Forms.Label();
            this.lblExternalSealPO = new System.Windows.Forms.Label();
            this.grpbAdditivationPOTab = new System.Windows.Forms.GroupBox();
            this.lblSurfaceAdditivationName = new System.Windows.Forms.Label();
            this.lblCentralAdditivationPO = new System.Windows.Forms.Label();
            this.lblCentralAdditivationName = new System.Windows.Forms.Label();
            this.lblSurfaceAdditivationPO = new System.Windows.Forms.Label();
            this.grpbFamiliesPOTab = new System.Windows.Forms.GroupBox();
            this.lblSubFamilyName = new System.Windows.Forms.Label();
            this.lblFamilyPO = new System.Windows.Forms.Label();
            this.lblFamilyName = new System.Windows.Forms.Label();
            this.lblSubFamiluPO = new System.Windows.Forms.Label();
            this.grpbThicknessPOTab = new System.Windows.Forms.GroupBox();
            this.lblTreatmentName = new System.Windows.Forms.Label();
            this.lblThicknessPO = new System.Windows.Forms.Label();
            this.lblTreatmentPO = new System.Windows.Forms.Label();
            this.lblThiknessName = new System.Windows.Forms.Label();
            this.lblFilmNamePO = new System.Windows.Forms.Label();
            this.grpbActionsPO = new System.Windows.Forms.GroupBox();
            this.btnBackProductionOrderTab = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpProductionOrdersBopp = new System.Windows.Forms.ToolTip(this.components);
            this.tbcWizard.SuspendLayout();
            this.tbpFilm.SuspendLayout();
            this.grpbFilms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBopp)).BeginInit();
            this.grpbActionsF.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpSalesOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbTotalsSalesOrderTab.SuspendLayout();
            this.grpbDetailOne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.grpbFilmNameSalesOrderTab.SuspendLayout();
            this.tbpFinalOrder.SuspendLayout();
            this.grpbSalesOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSalesOrder)).BeginInit();
            this.grpbQuantities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPercentage)).BeginInit();
            this.grpbFilm.SuspendLayout();
            this.grpbSealsPOTab.SuspendLayout();
            this.grpbAdditivationPOTab.SuspendLayout();
            this.grpbFamiliesPOTab.SuspendLayout();
            this.grpbThicknessPOTab.SuspendLayout();
            this.grpbActionsPO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcWizard
            // 
            this.tbcWizard.Controls.Add(this.tbpFilm);
            this.tbcWizard.Controls.Add(this.tbpSalesOrder);
            this.tbcWizard.Controls.Add(this.tbpFinalOrder);
            this.tbcWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcWizard.Location = new System.Drawing.Point(0, 0);
            this.tbcWizard.Name = "tbcWizard";
            this.tbcWizard.SelectedIndex = 0;
            this.tbcWizard.Size = new System.Drawing.Size(984, 582);
            this.tbcWizard.TabIndex = 0;
            // 
            // tbpFilm
            // 
            this.tbpFilm.BackColor = System.Drawing.SystemColors.Window;
            this.tbpFilm.Controls.Add(this.grpbFilms);
            this.tbpFilm.Controls.Add(this.grpbActionsF);
            this.tbpFilm.Controls.Add(this.groupBox1);
            this.tbpFilm.Location = new System.Drawing.Point(4, 24);
            this.tbpFilm.Name = "tbpFilm";
            this.tbpFilm.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFilm.Size = new System.Drawing.Size(976, 554);
            this.tbpFilm.TabIndex = 0;
            this.tbpFilm.Text = "Películas";
            // 
            // grpbFilms
            // 
            this.grpbFilms.Controls.Add(this.dgvBopp);
            this.grpbFilms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbFilms.Location = new System.Drawing.Point(3, 46);
            this.grpbFilms.Name = "grpbFilms";
            this.grpbFilms.Size = new System.Drawing.Size(970, 462);
            this.grpbFilms.TabIndex = 8;
            this.grpbFilms.TabStop = false;
            this.grpbFilms.Text = "Películas";
            // 
            // dgvBopp
            // 
            this.dgvBopp.AllowUserToAddRows = false;
            this.dgvBopp.AllowUserToDeleteRows = false;
            this.dgvBopp.AllowUserToOrderColumns = true;
            this.dgvBopp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBopp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmName,
            this.clmBaseFilm,
            this.clmTotalWeightFilms});
            this.dgvBopp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBopp.Location = new System.Drawing.Point(3, 17);
            this.dgvBopp.MultiSelect = false;
            this.dgvBopp.Name = "dgvBopp";
            this.dgvBopp.ReadOnly = true;
            this.dgvBopp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBopp.Size = new System.Drawing.Size(964, 442);
            this.dgvBopp.TabIndex = 0;
            this.dgvBopp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBopp_CellDoubleClick);
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
            this.clmCode.Width = 190;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 350;
            // 
            // clmBaseFilm
            // 
            this.clmBaseFilm.HeaderText = "Pelicula Base";
            this.clmBaseFilm.Name = "clmBaseFilm";
            this.clmBaseFilm.ReadOnly = true;
            this.clmBaseFilm.Width = 190;
            // 
            // clmTotalWeightFilms
            // 
            this.clmTotalWeightFilms.HeaderText = "Cantidad";
            this.clmTotalWeightFilms.Name = "clmTotalWeightFilms";
            this.clmTotalWeightFilms.ReadOnly = true;
            // 
            // grpbActionsF
            // 
            this.grpbActionsF.Controls.Add(this.btnNextFilmTab);
            this.grpbActionsF.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActionsF.Location = new System.Drawing.Point(3, 508);
            this.grpbActionsF.Name = "grpbActionsF";
            this.grpbActionsF.Size = new System.Drawing.Size(970, 43);
            this.grpbActionsF.TabIndex = 6;
            this.grpbActionsF.TabStop = false;
            // 
            // btnNextFilmTab
            // 
            this.btnNextFilmTab.BackgroundImage = global::BPS.Properties.Resources.arrow_right;
            this.btnNextFilmTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextFilmTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextFilmTab.Location = new System.Drawing.Point(942, 17);
            this.btnNextFilmTab.Name = "btnNextFilmTab";
            this.btnNextFilmTab.Size = new System.Drawing.Size(25, 23);
            this.btnNextFilmTab.TabIndex = 1;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnNextFilmTab, "Ordenes de Venta");
            this.btnNextFilmTab.UseVisualStyleBackColor = true;
            this.btnNextFilmTab.Click += new System.EventHandler(this.btnNextFilmTab_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoppCode);
            this.groupBox1.Controls.Add(this.lblBoppCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(970, 43);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // txtBoppCode
            // 
            this.txtBoppCode.Location = new System.Drawing.Point(378, 14);
            this.txtBoppCode.Name = "txtBoppCode";
            this.txtBoppCode.Size = new System.Drawing.Size(202, 21);
            this.txtBoppCode.TabIndex = 1;
            this.txtBoppCode.TextChanged += new System.EventHandler(this.txtBoppCode_TextChanged);
            // 
            // lblBoppCode
            // 
            this.lblBoppCode.AutoSize = true;
            this.lblBoppCode.Location = new System.Drawing.Point(324, 17);
            this.lblBoppCode.Name = "lblBoppCode";
            this.lblBoppCode.Size = new System.Drawing.Size(46, 15);
            this.lblBoppCode.TabIndex = 0;
            this.lblBoppCode.Text = "Código";
            // 
            // tbpSalesOrder
            // 
            this.tbpSalesOrder.BackColor = System.Drawing.SystemColors.Window;
            this.tbpSalesOrder.Controls.Add(this.groupBox2);
            this.tbpSalesOrder.Controls.Add(this.grpbTotalsSalesOrderTab);
            this.tbpSalesOrder.Controls.Add(this.grpbDetailOne);
            this.tbpSalesOrder.Controls.Add(this.chkSelectAllSalesOrder);
            this.tbpSalesOrder.Controls.Add(this.grpbFilmNameSalesOrderTab);
            this.tbpSalesOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpSalesOrder.Name = "tbpSalesOrder";
            this.tbpSalesOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalesOrder.Size = new System.Drawing.Size(976, 554);
            this.tbpSalesOrder.TabIndex = 1;
            this.tbpSalesOrder.Text = "Ordenes de Venta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 224);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.clmProductCode,
            this.clmProductName,
            this.clmQuantity,
            this.clmWeightFullfilledDetail,
            this.clmWeightSlopeDetail});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(964, 204);
            this.dgvDetail.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Código";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductCode.Width = 150;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductName.Width = 360;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clmWeightFullfilledDetail
            // 
            this.clmWeightFullfilledDetail.HeaderText = "Cumplido";
            this.clmWeightFullfilledDetail.Name = "clmWeightFullfilledDetail";
            this.clmWeightFullfilledDetail.ReadOnly = true;
            // 
            // clmWeightSlopeDetail
            // 
            this.clmWeightSlopeDetail.HeaderText = "Pendiente";
            this.clmWeightSlopeDetail.Name = "clmWeightSlopeDetail";
            this.clmWeightSlopeDetail.ReadOnly = true;
            // 
            // grpbTotalsSalesOrderTab
            // 
            this.grpbTotalsSalesOrderTab.Controls.Add(this.btnNextSalesOrderTab);
            this.grpbTotalsSalesOrderTab.Controls.Add(this.btnBackSalesOrderTab);
            this.grpbTotalsSalesOrderTab.Controls.Add(this.lblSalesOrderTotalSO);
            this.grpbTotalsSalesOrderTab.Controls.Add(this.lblTotalWeihtSalesOrder);
            this.grpbTotalsSalesOrderTab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbTotalsSalesOrderTab.Location = new System.Drawing.Point(3, 508);
            this.grpbTotalsSalesOrderTab.Name = "grpbTotalsSalesOrderTab";
            this.grpbTotalsSalesOrderTab.Size = new System.Drawing.Size(970, 43);
            this.grpbTotalsSalesOrderTab.TabIndex = 8;
            this.grpbTotalsSalesOrderTab.TabStop = false;
            // 
            // btnNextSalesOrderTab
            // 
            this.btnNextSalesOrderTab.BackgroundImage = global::BPS.Properties.Resources.arrow_right;
            this.btnNextSalesOrderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextSalesOrderTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextSalesOrderTab.Location = new System.Drawing.Point(942, 17);
            this.btnNextSalesOrderTab.Name = "btnNextSalesOrderTab";
            this.btnNextSalesOrderTab.Size = new System.Drawing.Size(25, 23);
            this.btnNextSalesOrderTab.TabIndex = 1;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnNextSalesOrderTab, "Order de Producción");
            this.btnNextSalesOrderTab.UseVisualStyleBackColor = true;
            this.btnNextSalesOrderTab.Click += new System.EventHandler(this.btnNextSalesOrderTab_Click);
            // 
            // btnBackSalesOrderTab
            // 
            this.btnBackSalesOrderTab.BackgroundImage = global::BPS.Properties.Resources.arrow_left;
            this.btnBackSalesOrderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackSalesOrderTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBackSalesOrderTab.Location = new System.Drawing.Point(3, 17);
            this.btnBackSalesOrderTab.Name = "btnBackSalesOrderTab";
            this.btnBackSalesOrderTab.Size = new System.Drawing.Size(25, 23);
            this.btnBackSalesOrderTab.TabIndex = 0;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnBackSalesOrderTab, "Películas");
            this.btnBackSalesOrderTab.UseVisualStyleBackColor = true;
            this.btnBackSalesOrderTab.Click += new System.EventHandler(this.btnBackSalesOrderTab_Click);
            // 
            // lblSalesOrderTotalSO
            // 
            this.lblSalesOrderTotalSO.BackColor = System.Drawing.SystemColors.Window;
            this.lblSalesOrderTotalSO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesOrderTotalSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderTotalSO.Location = new System.Drawing.Point(420, 14);
            this.lblSalesOrderTotalSO.Name = "lblSalesOrderTotalSO";
            this.lblSalesOrderTotalSO.Size = new System.Drawing.Size(112, 20);
            this.lblSalesOrderTotalSO.TabIndex = 1;
            this.lblSalesOrderTotalSO.Tag = "numericClearOnReload";
            this.lblSalesOrderTotalSO.Text = "0";
            this.lblSalesOrderTotalSO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalWeihtSalesOrder
            // 
            this.lblTotalWeihtSalesOrder.AutoSize = true;
            this.lblTotalWeihtSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeihtSalesOrder.Location = new System.Drawing.Point(314, 14);
            this.lblTotalWeihtSalesOrder.Name = "lblTotalWeihtSalesOrder";
            this.lblTotalWeihtSalesOrder.Size = new System.Drawing.Size(84, 20);
            this.lblTotalWeihtSalesOrder.TabIndex = 0;
            this.lblTotalWeihtSalesOrder.Text = "Peso Total";
            // 
            // grpbDetailOne
            // 
            this.grpbDetailOne.Controls.Add(this.dgvSalesOrder);
            this.grpbDetailOne.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetailOne.Location = new System.Drawing.Point(3, 65);
            this.grpbDetailOne.Name = "grpbDetailOne";
            this.grpbDetailOne.Size = new System.Drawing.Size(970, 219);
            this.grpbDetailOne.TabIndex = 14;
            this.grpbDetailOne.TabStop = false;
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.AllowUserToAddRows = false;
            this.dgvSalesOrder.AllowUserToDeleteRows = false;
            this.dgvSalesOrder.AllowUserToOrderColumns = true;
            this.dgvSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecSO,
            this.clmSelectSalesOrder,
            this.clmDate,
            this.clmNumber,
            this.clmCustomer,
            this.clmTotalWeigthSalesOrder,
            this.clmPlannifiedWeigth,
            this.clmWeightFulfilledSalesOrder,
            this.clmWeightSlopeSalesOrder,
            this.clmIsPlanned});
            this.dgvSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrder.Size = new System.Drawing.Size(964, 199);
            this.dgvSalesOrder.TabIndex = 1;
            this.dgvSalesOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellClick);
            this.dgvSalesOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellContentClick);
            this.dgvSalesOrder.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellValidated);
            this.dgvSalesOrder.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSalesOrder_CellValidating);
            // 
            // clmCodsecSO
            // 
            this.clmCodsecSO.HeaderText = "codsec";
            this.clmCodsecSO.Name = "clmCodsecSO";
            this.clmCodsecSO.Visible = false;
            // 
            // clmSelectSalesOrder
            // 
            this.clmSelectSalesOrder.HeaderText = "";
            this.clmSelectSalesOrder.Name = "clmSelectSalesOrder";
            this.clmSelectSalesOrder.Width = 25;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Número";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.Width = 80;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.Width = 300;
            // 
            // clmTotalWeigthSalesOrder
            // 
            this.clmTotalWeigthSalesOrder.HeaderText = "Peso Total";
            this.clmTotalWeigthSalesOrder.Name = "clmTotalWeigthSalesOrder";
            this.clmTotalWeigthSalesOrder.Width = 75;
            // 
            // clmPlannifiedWeigth
            // 
            this.clmPlannifiedWeigth.HeaderText = "Planificar";
            this.clmPlannifiedWeigth.Name = "clmPlannifiedWeigth";
            this.clmPlannifiedWeigth.Width = 75;
            // 
            // clmWeightFulfilledSalesOrder
            // 
            this.clmWeightFulfilledSalesOrder.HeaderText = "Cumplido";
            this.clmWeightFulfilledSalesOrder.Name = "clmWeightFulfilledSalesOrder";
            this.clmWeightFulfilledSalesOrder.Width = 75;
            // 
            // clmWeightSlopeSalesOrder
            // 
            this.clmWeightSlopeSalesOrder.HeaderText = "Pendiente";
            this.clmWeightSlopeSalesOrder.Name = "clmWeightSlopeSalesOrder";
            this.clmWeightSlopeSalesOrder.Width = 75;
            // 
            // clmIsPlanned
            // 
            this.clmIsPlanned.HeaderText = "Planificado";
            this.clmIsPlanned.Name = "clmIsPlanned";
            this.clmIsPlanned.Visible = false;
            // 
            // chkSelectAllSalesOrder
            // 
            this.chkSelectAllSalesOrder.AutoSize = true;
            this.chkSelectAllSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSelectAllSalesOrder.Location = new System.Drawing.Point(3, 46);
            this.chkSelectAllSalesOrder.Name = "chkSelectAllSalesOrder";
            this.chkSelectAllSalesOrder.Size = new System.Drawing.Size(970, 19);
            this.chkSelectAllSalesOrder.TabIndex = 12;
            this.chkSelectAllSalesOrder.Text = "Seleccionar Todas";
            this.chkSelectAllSalesOrder.UseVisualStyleBackColor = true;
            this.chkSelectAllSalesOrder.CheckedChanged += new System.EventHandler(this.chkSelectAllSalesOrder_CheckedChanged);
            // 
            // grpbFilmNameSalesOrderTab
            // 
            this.grpbFilmNameSalesOrderTab.Controls.Add(this.lblFilmName);
            this.grpbFilmNameSalesOrderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilmNameSalesOrderTab.Location = new System.Drawing.Point(3, 3);
            this.grpbFilmNameSalesOrderTab.Name = "grpbFilmNameSalesOrderTab";
            this.grpbFilmNameSalesOrderTab.Size = new System.Drawing.Size(970, 43);
            this.grpbFilmNameSalesOrderTab.TabIndex = 10;
            this.grpbFilmNameSalesOrderTab.TabStop = false;
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(3, 17);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(964, 23);
            this.lblFilmName.TabIndex = 2;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpFinalOrder
            // 
            this.tbpFinalOrder.BackColor = System.Drawing.SystemColors.Window;
            this.tbpFinalOrder.Controls.Add(this.grpbSalesOrders);
            this.tbpFinalOrder.Controls.Add(this.grpbQuantities);
            this.tbpFinalOrder.Controls.Add(this.grpbFilm);
            this.tbpFinalOrder.Controls.Add(this.grpbActionsPO);
            this.tbpFinalOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpFinalOrder.Name = "tbpFinalOrder";
            this.tbpFinalOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFinalOrder.Size = new System.Drawing.Size(976, 554);
            this.tbpFinalOrder.TabIndex = 2;
            this.tbpFinalOrder.Text = "Orden de Producción";
            // 
            // grpbSalesOrders
            // 
            this.grpbSalesOrders.Controls.Add(this.dgvSelectedSalesOrder);
            this.grpbSalesOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbSalesOrders.Location = new System.Drawing.Point(3, 140);
            this.grpbSalesOrders.Name = "grpbSalesOrders";
            this.grpbSalesOrders.Size = new System.Drawing.Size(970, 289);
            this.grpbSalesOrders.TabIndex = 13;
            this.grpbSalesOrders.TabStop = false;
            this.grpbSalesOrders.Text = "Ordenes de venta";
            // 
            // dgvSelectedSalesOrder
            // 
            this.dgvSelectedSalesOrder.AllowUserToAddRows = false;
            this.dgvSelectedSalesOrder.AllowUserToDeleteRows = false;
            this.dgvSelectedSalesOrder.AllowUserToOrderColumns = true;
            this.dgvSelectedSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecPO,
            this.clmDatePO,
            this.clmNumberPO,
            this.clmCustomerNamePO,
            this.clmTotalWeightPO,
            this.clmWeightFullfilledPO,
            this.clmWeightSlopePO});
            this.dgvSelectedSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedSalesOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedSalesOrder.Name = "dgvSelectedSalesOrder";
            this.dgvSelectedSalesOrder.ReadOnly = true;
            this.dgvSelectedSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedSalesOrder.Size = new System.Drawing.Size(964, 269);
            this.dgvSelectedSalesOrder.TabIndex = 2;
            // 
            // clmCodsecPO
            // 
            this.clmCodsecPO.HeaderText = "codsec";
            this.clmCodsecPO.Name = "clmCodsecPO";
            this.clmCodsecPO.ReadOnly = true;
            this.clmCodsecPO.Visible = false;
            // 
            // clmDatePO
            // 
            this.clmDatePO.HeaderText = "Fecha";
            this.clmDatePO.Name = "clmDatePO";
            this.clmDatePO.ReadOnly = true;
            // 
            // clmNumberPO
            // 
            this.clmNumberPO.HeaderText = "Número";
            this.clmNumberPO.Name = "clmNumberPO";
            this.clmNumberPO.ReadOnly = true;
            this.clmNumberPO.Width = 80;
            // 
            // clmCustomerNamePO
            // 
            this.clmCustomerNamePO.HeaderText = "Cliente";
            this.clmCustomerNamePO.Name = "clmCustomerNamePO";
            this.clmCustomerNamePO.ReadOnly = true;
            this.clmCustomerNamePO.Width = 300;
            // 
            // clmTotalWeightPO
            // 
            this.clmTotalWeightPO.HeaderText = "Peso a Extruir";
            this.clmTotalWeightPO.Name = "clmTotalWeightPO";
            this.clmTotalWeightPO.ReadOnly = true;
            this.clmTotalWeightPO.Width = 110;
            // 
            // clmWeightFullfilledPO
            // 
            this.clmWeightFullfilledPO.HeaderText = "Cumplido";
            this.clmWeightFullfilledPO.Name = "clmWeightFullfilledPO";
            this.clmWeightFullfilledPO.ReadOnly = true;
            this.clmWeightFullfilledPO.Width = 110;
            // 
            // clmWeightSlopePO
            // 
            this.clmWeightSlopePO.HeaderText = "Pendiente";
            this.clmWeightSlopePO.Name = "clmWeightSlopePO";
            this.clmWeightSlopePO.ReadOnly = true;
            this.clmWeightSlopePO.Width = 105;
            // 
            // grpbQuantities
            // 
            this.grpbQuantities.Controls.Add(this.lblTotal);
            this.grpbQuantities.Controls.Add(this.lblTotalToExtrude);
            this.grpbQuantities.Controls.Add(this.nudExtraPercentage);
            this.grpbQuantities.Controls.Add(this.lblEqual);
            this.grpbQuantities.Controls.Add(this.lblPercentage);
            this.grpbQuantities.Controls.Add(this.lblPlus2);
            this.grpbQuantities.Controls.Add(this.lblPlus1);
            this.grpbQuantities.Controls.Add(this.txtInnerProduction);
            this.grpbQuantities.Controls.Add(this.lblExtraPercentage);
            this.grpbQuantities.Controls.Add(this.lblInnerProgramed);
            this.grpbQuantities.Controls.Add(this.lblSalesOrderTotalValue);
            this.grpbQuantities.Controls.Add(this.lblSalesOrderTotal);
            this.grpbQuantities.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbQuantities.Location = new System.Drawing.Point(3, 429);
            this.grpbQuantities.Name = "grpbQuantities";
            this.grpbQuantities.Size = new System.Drawing.Size(970, 79);
            this.grpbQuantities.TabIndex = 14;
            this.grpbQuantities.TabStop = false;
            this.grpbQuantities.Text = "Cantidades";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(696, 41);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 26);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Tag = "numericClearOnReload";
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // lblTotalToExtrude
            // 
            this.lblTotalToExtrude.AutoSize = true;
            this.lblTotalToExtrude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalToExtrude.Location = new System.Drawing.Point(700, 17);
            this.lblTotalToExtrude.Name = "lblTotalToExtrude";
            this.lblTotalToExtrude.Size = new System.Drawing.Size(104, 20);
            this.lblTotalToExtrude.TabIndex = 8;
            this.lblTotalToExtrude.Text = "Total a extruir";
            // 
            // nudExtraPercentage
            // 
            this.nudExtraPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExtraPercentage.Location = new System.Drawing.Point(504, 41);
            this.nudExtraPercentage.Name = "nudExtraPercentage";
            this.nudExtraPercentage.Size = new System.Drawing.Size(112, 26);
            this.nudExtraPercentage.TabIndex = 7;
            this.nudExtraPercentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudExtraPercentage.ValueChanged += new System.EventHandler(this.nudExtraPercentage_ValueChanged);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqual.Location = new System.Drawing.Point(652, 41);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(24, 25);
            this.lblEqual.TabIndex = 6;
            this.lblEqual.Text = "=";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(613, 43);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(23, 20);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "%";
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus2.Location = new System.Drawing.Point(465, 39);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(24, 25);
            this.lblPlus2.TabIndex = 6;
            this.lblPlus2.Text = "+";
            // 
            // lblPlus1
            // 
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus1.Location = new System.Drawing.Point(299, 39);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.Size = new System.Drawing.Size(24, 25);
            this.lblPlus1.TabIndex = 6;
            this.lblPlus1.Text = "+";
            // 
            // txtInnerProduction
            // 
            this.txtInnerProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInnerProduction.Location = new System.Drawing.Point(338, 40);
            this.txtInnerProduction.Name = "txtInnerProduction";
            this.txtInnerProduction.Size = new System.Drawing.Size(112, 26);
            this.txtInnerProduction.TabIndex = 5;
            this.txtInnerProduction.Tag = "numericClearOnReload";
            this.txtInnerProduction.Text = "0";
            this.txtInnerProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInnerProduction.TextChanged += new System.EventHandler(this.txtInnerProduction_TextChanged);
            // 
            // lblExtraPercentage
            // 
            this.lblExtraPercentage.AutoSize = true;
            this.lblExtraPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraPercentage.Location = new System.Drawing.Point(497, 16);
            this.lblExtraPercentage.Name = "lblExtraPercentage";
            this.lblExtraPercentage.Size = new System.Drawing.Size(126, 20);
            this.lblExtraPercentage.TabIndex = 4;
            this.lblExtraPercentage.Text = "Porcentaje Extra";
            // 
            // lblInnerProgramed
            // 
            this.lblInnerProgramed.AutoSize = true;
            this.lblInnerProgramed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInnerProgramed.Location = new System.Drawing.Point(314, 16);
            this.lblInnerProgramed.Name = "lblInnerProgramed";
            this.lblInnerProgramed.Size = new System.Drawing.Size(160, 20);
            this.lblInnerProgramed.TabIndex = 4;
            this.lblInnerProgramed.Text = "Programación interna";
            // 
            // lblSalesOrderTotalValue
            // 
            this.lblSalesOrderTotalValue.BackColor = System.Drawing.SystemColors.Window;
            this.lblSalesOrderTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesOrderTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderTotalValue.Location = new System.Drawing.Point(172, 40);
            this.lblSalesOrderTotalValue.Name = "lblSalesOrderTotalValue";
            this.lblSalesOrderTotalValue.Size = new System.Drawing.Size(112, 26);
            this.lblSalesOrderTotalValue.TabIndex = 3;
            this.lblSalesOrderTotalValue.Tag = "numericClearOnReload";
            this.lblSalesOrderTotalValue.Text = "0";
            this.lblSalesOrderTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesOrderTotal
            // 
            this.lblSalesOrderTotal.AutoSize = true;
            this.lblSalesOrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderTotal.Location = new System.Drawing.Point(162, 16);
            this.lblSalesOrderTotal.Name = "lblSalesOrderTotal";
            this.lblSalesOrderTotal.Size = new System.Drawing.Size(133, 20);
            this.lblSalesOrderTotal.TabIndex = 2;
            this.lblSalesOrderTotal.Text = "Total O. de Venta";
            // 
            // grpbFilm
            // 
            this.grpbFilm.Controls.Add(this.grpbSealsPOTab);
            this.grpbFilm.Controls.Add(this.grpbAdditivationPOTab);
            this.grpbFilm.Controls.Add(this.grpbFamiliesPOTab);
            this.grpbFilm.Controls.Add(this.grpbThicknessPOTab);
            this.grpbFilm.Controls.Add(this.lblFilmNamePO);
            this.grpbFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilm.Location = new System.Drawing.Point(3, 3);
            this.grpbFilm.Name = "grpbFilm";
            this.grpbFilm.Size = new System.Drawing.Size(970, 137);
            this.grpbFilm.TabIndex = 12;
            this.grpbFilm.TabStop = false;
            this.grpbFilm.Text = "Película";
            // 
            // grpbSealsPOTab
            // 
            this.grpbSealsPOTab.Controls.Add(this.lblOuterSealName);
            this.grpbSealsPOTab.Controls.Add(this.lblInnerSealPO);
            this.grpbSealsPOTab.Controls.Add(this.lblInnerSealName);
            this.grpbSealsPOTab.Controls.Add(this.lblExternalSealPO);
            this.grpbSealsPOTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbSealsPOTab.Location = new System.Drawing.Point(244, 40);
            this.grpbSealsPOTab.Name = "grpbSealsPOTab";
            this.grpbSealsPOTab.Size = new System.Drawing.Size(241, 94);
            this.grpbSealsPOTab.TabIndex = 24;
            this.grpbSealsPOTab.TabStop = false;
            this.grpbSealsPOTab.Text = "Sello";
            // 
            // lblOuterSealName
            // 
            this.lblOuterSealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOuterSealName.Location = new System.Drawing.Point(54, 58);
            this.lblOuterSealName.Name = "lblOuterSealName";
            this.lblOuterSealName.Size = new System.Drawing.Size(141, 15);
            this.lblOuterSealName.TabIndex = 12;
            this.lblOuterSealName.Tag = "clearOnReload";
            // 
            // lblInnerSealPO
            // 
            this.lblInnerSealPO.AutoSize = true;
            this.lblInnerSealPO.Location = new System.Drawing.Point(6, 26);
            this.lblInnerSealPO.Name = "lblInnerSealPO";
            this.lblInnerSealPO.Size = new System.Drawing.Size(45, 15);
            this.lblInnerSealPO.TabIndex = 9;
            this.lblInnerSealPO.Text = "Interno";
            // 
            // lblInnerSealName
            // 
            this.lblInnerSealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInnerSealName.Location = new System.Drawing.Point(55, 26);
            this.lblInnerSealName.Name = "lblInnerSealName";
            this.lblInnerSealName.Size = new System.Drawing.Size(141, 15);
            this.lblInnerSealName.TabIndex = 11;
            this.lblInnerSealName.Tag = "clearOnReload";
            // 
            // lblExternalSealPO
            // 
            this.lblExternalSealPO.AutoSize = true;
            this.lblExternalSealPO.Location = new System.Drawing.Point(4, 58);
            this.lblExternalSealPO.Name = "lblExternalSealPO";
            this.lblExternalSealPO.Size = new System.Drawing.Size(49, 15);
            this.lblExternalSealPO.TabIndex = 10;
            this.lblExternalSealPO.Text = "Externo";
            // 
            // grpbAdditivationPOTab
            // 
            this.grpbAdditivationPOTab.Controls.Add(this.lblSurfaceAdditivationName);
            this.grpbAdditivationPOTab.Controls.Add(this.lblCentralAdditivationPO);
            this.grpbAdditivationPOTab.Controls.Add(this.lblCentralAdditivationName);
            this.grpbAdditivationPOTab.Controls.Add(this.lblSurfaceAdditivationPO);
            this.grpbAdditivationPOTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbAdditivationPOTab.Location = new System.Drawing.Point(485, 40);
            this.grpbAdditivationPOTab.Name = "grpbAdditivationPOTab";
            this.grpbAdditivationPOTab.Size = new System.Drawing.Size(241, 94);
            this.grpbAdditivationPOTab.TabIndex = 27;
            this.grpbAdditivationPOTab.TabStop = false;
            this.grpbAdditivationPOTab.Text = "Aditivación";
            // 
            // lblSurfaceAdditivationName
            // 
            this.lblSurfaceAdditivationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurfaceAdditivationName.Location = new System.Drawing.Point(67, 58);
            this.lblSurfaceAdditivationName.Name = "lblSurfaceAdditivationName";
            this.lblSurfaceAdditivationName.Size = new System.Drawing.Size(141, 15);
            this.lblSurfaceAdditivationName.TabIndex = 12;
            this.lblSurfaceAdditivationName.Tag = "clearOnReload";
            // 
            // lblCentralAdditivationPO
            // 
            this.lblCentralAdditivationPO.AutoSize = true;
            this.lblCentralAdditivationPO.Location = new System.Drawing.Point(6, 26);
            this.lblCentralAdditivationPO.Name = "lblCentralAdditivationPO";
            this.lblCentralAdditivationPO.Size = new System.Drawing.Size(46, 15);
            this.lblCentralAdditivationPO.TabIndex = 9;
            this.lblCentralAdditivationPO.Text = "Central";
            // 
            // lblCentralAdditivationName
            // 
            this.lblCentralAdditivationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentralAdditivationName.Location = new System.Drawing.Point(67, 25);
            this.lblCentralAdditivationName.Name = "lblCentralAdditivationName";
            this.lblCentralAdditivationName.Size = new System.Drawing.Size(141, 15);
            this.lblCentralAdditivationName.TabIndex = 11;
            this.lblCentralAdditivationName.Tag = "clearOnReload";
            // 
            // lblSurfaceAdditivationPO
            // 
            this.lblSurfaceAdditivationPO.AutoSize = true;
            this.lblSurfaceAdditivationPO.Location = new System.Drawing.Point(6, 58);
            this.lblSurfaceAdditivationPO.Name = "lblSurfaceAdditivationPO";
            this.lblSurfaceAdditivationPO.Size = new System.Drawing.Size(62, 15);
            this.lblSurfaceAdditivationPO.TabIndex = 10;
            this.lblSurfaceAdditivationPO.Text = "Superficie";
            // 
            // grpbFamiliesPOTab
            // 
            this.grpbFamiliesPOTab.Controls.Add(this.lblSubFamilyName);
            this.grpbFamiliesPOTab.Controls.Add(this.lblFamilyPO);
            this.grpbFamiliesPOTab.Controls.Add(this.lblFamilyName);
            this.grpbFamiliesPOTab.Controls.Add(this.lblSubFamiluPO);
            this.grpbFamiliesPOTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbFamiliesPOTab.Location = new System.Drawing.Point(3, 40);
            this.grpbFamiliesPOTab.Name = "grpbFamiliesPOTab";
            this.grpbFamiliesPOTab.Size = new System.Drawing.Size(241, 94);
            this.grpbFamiliesPOTab.TabIndex = 25;
            this.grpbFamiliesPOTab.TabStop = false;
            this.grpbFamiliesPOTab.Text = "Familias";
            // 
            // lblSubFamilyName
            // 
            this.lblSubFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubFamilyName.Location = new System.Drawing.Point(78, 58);
            this.lblSubFamilyName.Name = "lblSubFamilyName";
            this.lblSubFamilyName.Size = new System.Drawing.Size(146, 15);
            this.lblSubFamilyName.TabIndex = 12;
            this.lblSubFamilyName.Tag = "clearOnReload";
            // 
            // lblFamilyPO
            // 
            this.lblFamilyPO.AutoSize = true;
            this.lblFamilyPO.Location = new System.Drawing.Point(6, 26);
            this.lblFamilyPO.Name = "lblFamilyPO";
            this.lblFamilyPO.Size = new System.Drawing.Size(48, 15);
            this.lblFamilyPO.TabIndex = 9;
            this.lblFamilyPO.Text = "Familia";
            // 
            // lblFamilyName
            // 
            this.lblFamilyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilyName.Location = new System.Drawing.Point(78, 26);
            this.lblFamilyName.Name = "lblFamilyName";
            this.lblFamilyName.Size = new System.Drawing.Size(146, 15);
            this.lblFamilyName.TabIndex = 11;
            this.lblFamilyName.Tag = "clearOnReload";
            // 
            // lblSubFamiluPO
            // 
            this.lblSubFamiluPO.AutoSize = true;
            this.lblSubFamiluPO.Location = new System.Drawing.Point(6, 58);
            this.lblSubFamiluPO.Name = "lblSubFamiluPO";
            this.lblSubFamiluPO.Size = new System.Drawing.Size(73, 15);
            this.lblSubFamiluPO.TabIndex = 10;
            this.lblSubFamiluPO.Text = "Sub Familia";
            // 
            // grpbThicknessPOTab
            // 
            this.grpbThicknessPOTab.Controls.Add(this.lblTreatmentName);
            this.grpbThicknessPOTab.Controls.Add(this.lblThicknessPO);
            this.grpbThicknessPOTab.Controls.Add(this.lblTreatmentPO);
            this.grpbThicknessPOTab.Controls.Add(this.lblThiknessName);
            this.grpbThicknessPOTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbThicknessPOTab.Location = new System.Drawing.Point(726, 40);
            this.grpbThicknessPOTab.Name = "grpbThicknessPOTab";
            this.grpbThicknessPOTab.Size = new System.Drawing.Size(241, 94);
            this.grpbThicknessPOTab.TabIndex = 26;
            this.grpbThicknessPOTab.TabStop = false;
            this.grpbThicknessPOTab.Text = "Espesor && tratamiento";
            // 
            // lblTreatmentName
            // 
            this.lblTreatmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentName.Location = new System.Drawing.Point(73, 58);
            this.lblTreatmentName.Name = "lblTreatmentName";
            this.lblTreatmentName.Size = new System.Drawing.Size(147, 15);
            this.lblTreatmentName.TabIndex = 13;
            this.lblTreatmentName.Tag = "clearOnReload";
            // 
            // lblThicknessPO
            // 
            this.lblThicknessPO.AutoSize = true;
            this.lblThicknessPO.Location = new System.Drawing.Point(1, 26);
            this.lblThicknessPO.Name = "lblThicknessPO";
            this.lblThicknessPO.Size = new System.Drawing.Size(52, 15);
            this.lblThicknessPO.TabIndex = 10;
            this.lblThicknessPO.Text = "Espesor";
            // 
            // lblTreatmentPO
            // 
            this.lblTreatmentPO.AutoSize = true;
            this.lblTreatmentPO.Location = new System.Drawing.Point(1, 58);
            this.lblTreatmentPO.Name = "lblTreatmentPO";
            this.lblTreatmentPO.Size = new System.Drawing.Size(73, 15);
            this.lblTreatmentPO.TabIndex = 12;
            this.lblTreatmentPO.Text = "Tratamiento";
            // 
            // lblThiknessName
            // 
            this.lblThiknessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThiknessName.Location = new System.Drawing.Point(73, 26);
            this.lblThiknessName.Name = "lblThiknessName";
            this.lblThiknessName.Size = new System.Drawing.Size(147, 15);
            this.lblThiknessName.TabIndex = 11;
            this.lblThiknessName.Tag = "clearOnReload";
            // 
            // lblFilmNamePO
            // 
            this.lblFilmNamePO.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmNamePO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmNamePO.Location = new System.Drawing.Point(3, 17);
            this.lblFilmNamePO.Name = "lblFilmNamePO";
            this.lblFilmNamePO.Size = new System.Drawing.Size(964, 23);
            this.lblFilmNamePO.TabIndex = 3;
            this.lblFilmNamePO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbActionsPO
            // 
            this.grpbActionsPO.Controls.Add(this.btnBackProductionOrderTab);
            this.grpbActionsPO.Controls.Add(this.btnSave);
            this.grpbActionsPO.Controls.Add(this.btnCancel);
            this.grpbActionsPO.Controls.Add(this.btnClose);
            this.grpbActionsPO.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActionsPO.Location = new System.Drawing.Point(3, 508);
            this.grpbActionsPO.Name = "grpbActionsPO";
            this.grpbActionsPO.Size = new System.Drawing.Size(970, 43);
            this.grpbActionsPO.TabIndex = 11;
            this.grpbActionsPO.TabStop = false;
            // 
            // btnBackProductionOrderTab
            // 
            this.btnBackProductionOrderTab.BackgroundImage = global::BPS.Properties.Resources.arrow_left;
            this.btnBackProductionOrderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackProductionOrderTab.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBackProductionOrderTab.Location = new System.Drawing.Point(867, 17);
            this.btnBackProductionOrderTab.Name = "btnBackProductionOrderTab";
            this.btnBackProductionOrderTab.Size = new System.Drawing.Size(25, 23);
            this.btnBackProductionOrderTab.TabIndex = 0;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnBackProductionOrderTab, "Ordenes de Venta");
            this.btnBackProductionOrderTab.UseVisualStyleBackColor = true;
            this.btnBackProductionOrderTab.Click += new System.EventHandler(this.btnBackProductionOrderTab_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(892, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 23);
            this.btnSave.TabIndex = 1;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnSave, "Guardar Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(917, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 23);
            this.btnCancel.TabIndex = 2;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnCancel, "Cancelar ");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(942, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 3;
            this.ttpProductionOrdersBopp.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmProductionOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(984, 582);
            this.Controls.Add(this.tbcWizard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionOrderForm";
            this.Text = "Ordenes de Producción BOPP";
            this.Load += new System.EventHandler(this.frmProductionOrderForm_Load);
            this.tbcWizard.ResumeLayout(false);
            this.tbpFilm.ResumeLayout(false);
            this.grpbFilms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBopp)).EndInit();
            this.grpbActionsF.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpSalesOrder.ResumeLayout(false);
            this.tbpSalesOrder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbTotalsSalesOrderTab.ResumeLayout(false);
            this.grpbTotalsSalesOrderTab.PerformLayout();
            this.grpbDetailOne.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.grpbFilmNameSalesOrderTab.ResumeLayout(false);
            this.tbpFinalOrder.ResumeLayout(false);
            this.grpbSalesOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSalesOrder)).EndInit();
            this.grpbQuantities.ResumeLayout(false);
            this.grpbQuantities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPercentage)).EndInit();
            this.grpbFilm.ResumeLayout(false);
            this.grpbSealsPOTab.ResumeLayout(false);
            this.grpbSealsPOTab.PerformLayout();
            this.grpbAdditivationPOTab.ResumeLayout(false);
            this.grpbAdditivationPOTab.PerformLayout();
            this.grpbFamiliesPOTab.ResumeLayout(false);
            this.grpbFamiliesPOTab.PerformLayout();
            this.grpbThicknessPOTab.ResumeLayout(false);
            this.grpbThicknessPOTab.PerformLayout();
            this.grpbActionsPO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcWizard;
        private System.Windows.Forms.TabPage tbpFilm;
        private System.Windows.Forms.TabPage tbpSalesOrder;
        private System.Windows.Forms.DataGridView dgvBopp;
        private System.Windows.Forms.DataGridView dgvSalesOrder;
        public System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox grpbTotalsSalesOrderTab;
        private System.Windows.Forms.GroupBox grpbFilmNameSalesOrderTab;
        private System.Windows.Forms.TabPage tbpFinalOrder;
        private System.Windows.Forms.Label lblSalesOrderTotalSO;
        private System.Windows.Forms.Label lblTotalWeihtSalesOrder;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.GroupBox grpbActionsPO;
        private System.Windows.Forms.Button btnBackProductionOrderTab;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbQuantities;
        private System.Windows.Forms.GroupBox grpbSalesOrders;
        private System.Windows.Forms.GroupBox grpbFilm;
        private System.Windows.Forms.Label lblFilmNamePO;
        private System.Windows.Forms.GroupBox grpbThicknessPOTab;
        private System.Windows.Forms.GroupBox grpbAdditivationPOTab;
        private System.Windows.Forms.GroupBox grpbSealsPOTab;
        private System.Windows.Forms.GroupBox grpbFamiliesPOTab;
        private System.Windows.Forms.Label lblSubFamilyName;
        private System.Windows.Forms.Label lblFamilyPO;
        private System.Windows.Forms.Label lblFamilyName;
        private System.Windows.Forms.Label lblSubFamiluPO;
        private System.Windows.Forms.Label lblOuterSealName;
        private System.Windows.Forms.Label lblInnerSealPO;
        private System.Windows.Forms.Label lblInnerSealName;
        private System.Windows.Forms.Label lblExternalSealPO;
        private System.Windows.Forms.Label lblSurfaceAdditivationName;
        private System.Windows.Forms.Label lblCentralAdditivationPO;
        private System.Windows.Forms.Label lblCentralAdditivationName;
        private System.Windows.Forms.Label lblSurfaceAdditivationPO;
        private System.Windows.Forms.Label lblThiknessName;
        private System.Windows.Forms.Label lblThicknessPO;
        private System.Windows.Forms.Label lblTreatmentName;
        private System.Windows.Forms.Label lblTreatmentPO;
        private System.Windows.Forms.Label lblSalesOrderTotalValue;
        private System.Windows.Forms.Label lblSalesOrderTotal;
        private System.Windows.Forms.DataGridView dgvSelectedSalesOrder;
        private System.Windows.Forms.Label lblEqual;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblPlus2;
        private System.Windows.Forms.Label lblPlus1;
        private System.Windows.Forms.TextBox txtInnerProduction;
        private System.Windows.Forms.Label lblExtraPercentage;
        private System.Windows.Forms.Label lblInnerProgramed;
        private System.Windows.Forms.Label lblTotalToExtrude;
        private System.Windows.Forms.NumericUpDown nudExtraPercentage;
        private System.Windows.Forms.GroupBox grpbActionsF;
        private System.Windows.Forms.Button btnNextFilmTab;
        private System.Windows.Forms.Button btnNextSalesOrderTab;
        private System.Windows.Forms.Button btnBackSalesOrderTab;
        private System.Windows.Forms.CheckBox chkSelectAllSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightFullfilledDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightSlopeDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBaseFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeightFilms;
        private System.Windows.Forms.ToolTip ttpProductionOrdersBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecSO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeigthSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlannifiedWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightFulfilledSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightSlopeSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsPlanned;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumberPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerNamePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeightPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightFullfilledPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightSlopePO;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoppCode;
        private System.Windows.Forms.Label lblBoppCode;
        private System.Windows.Forms.GroupBox grpbFilms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox grpbDetailOne;

    }
}