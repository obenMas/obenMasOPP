namespace BPS
{
    partial class frmCuttingOrderBCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrder));
            this.tbcCuttingOrder = new System.Windows.Forms.TabControl();
            this.tbpFilmSelection = new System.Windows.Forms.TabPage();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.grpbThicknessFilmTab = new System.Windows.Forms.GroupBox();
            this.lblThickness = new System.Windows.Forms.Label();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.cmbTreatment = new System.Windows.Forms.ComboBox();
            this.cmbThikness = new System.Windows.Forms.ComboBox();
            this.grpbAdditivationsFilmTab = new System.Windows.Forms.GroupBox();
            this.lblCentralAdditivation = new System.Windows.Forms.Label();
            this.cmbCentralAdditivation = new System.Windows.Forms.ComboBox();
            this.lblSurfaceAdditivation = new System.Windows.Forms.Label();
            this.cmbSurfaceAdditivation = new System.Windows.Forms.ComboBox();
            this.grpbSealsFilmTab = new System.Windows.Forms.GroupBox();
            this.cmbOuterSeal = new System.Windows.Forms.ComboBox();
            this.lblInnerSeal = new System.Windows.Forms.Label();
            this.cmbInnerSeal = new System.Windows.Forms.ComboBox();
            this.lblOuterSeal = new System.Windows.Forms.Label();
            this.grpbFamiliesFilmTab = new System.Windows.Forms.GroupBox();
            this.lblSubFamily = new System.Windows.Forms.Label();
            this.lblFamily = new System.Windows.Forms.Label();
            this.cmbFamily = new System.Windows.Forms.ComboBox();
            this.cmbSubFamily = new System.Windows.Forms.ComboBox();
            this.grpbFilms = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddNewBopp = new System.Windows.Forms.Button();
            this.btnRefreshBopp = new System.Windows.Forms.Button();
            this.txtBoppName = new System.Windows.Forms.TextBox();
            this.lblBoppName = new System.Windows.Forms.Label();
            this.txtBoppCode = new System.Windows.Forms.TextBox();
            this.lblBoppCode = new System.Windows.Forms.Label();
            this.dgvBopp = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeightFilms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCuttingPlan = new System.Windows.Forms.TabPage();
            this.chkAllowEquivalentFilm = new System.Windows.Forms.CheckBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblPercentage2 = new System.Windows.Forms.Label();
            this.lblPercentage1 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.nudWasteAllowed = new System.Windows.Forms.NumericUpDown();
            this.nudStops = new System.Windows.Forms.NumericUpDown();
            this.lblViableCombination = new System.Windows.Forms.Label();
            this.lblUnusedWidth = new System.Windows.Forms.Label();
            this.lblUsedArms = new System.Windows.Forms.Label();
            this.lblWaste = new System.Windows.Forms.Label();
            this.lblUsedWidth = new System.Windows.Forms.Label();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.lblViableCombinationLabel = new System.Windows.Forms.Label();
            this.lblUnusedWidthLabel = new System.Windows.Forms.Label();
            this.lblWasteAllowed = new System.Windows.Forms.Label();
            this.lblUsedArmsLabel = new System.Windows.Forms.Label();
            this.lblWasteLabel = new System.Windows.Forms.Label();
            this.lblStops = new System.Windows.Forms.Label();
            this.lblUsedWidthLabel = new System.Windows.Forms.Label();
            this.grpbStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.clmStockProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockCoilQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockDiameterCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockCoilsToCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockTotalCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockProgrammedWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockSlopeWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockBoppCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockDiameterCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStockCoreCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSalesOrders = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrderDetail = new System.Windows.Forms.DataGridView();
            this.clmSalesOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderChangeProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmSalesOrderWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderTotalOrderCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCoilsQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCoreDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderCoilsToCut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderTotalCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderProgrammedWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderSlopeWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderOriginalProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderTotalSlope = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderIsEquivalentFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderDetailIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbCutterMachine = new System.Windows.Forms.GroupBox();
            this.chkLoadEquivalentFilm = new System.Windows.Forms.CheckBox();
            this.txtUtilWidth = new System.Windows.Forms.TextBox();
            this.btnFilterSalesOrder = new System.Windows.Forms.Button();
            this.btnClearFilterSalesOrder = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.lblCore = new System.Windows.Forms.Label();
            this.cmbCutter = new System.Windows.Forms.ComboBox();
            this.lblArms = new System.Windows.Forms.Label();
            this.lblUtilWidth = new System.Windows.Forms.Label();
            this.lblArmsLabel = new System.Windows.Forms.Label();
            this.lblUtilWidthLabel = new System.Windows.Forms.Label();
            this.lblCutter = new System.Windows.Forms.Label();
            this.grpbFilmNameSalesOrderTab = new System.Windows.Forms.GroupBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.tbpResume = new System.Windows.Forms.TabPage();
            this.grpbCuttingOrderDetail = new System.Windows.Forms.GroupBox();
            this.btnChangeCutter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSeparatorInDetail = new System.Windows.Forms.Label();
            this.lblStatusImage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblStopsNumber = new System.Windows.Forms.Label();
            this.lblWasteInDetail = new System.Windows.Forms.Label();
            this.lblWasteInDetailLabel = new System.Windows.Forms.Label();
            this.lblStopNumberInDetailLabel = new System.Windows.Forms.Label();
            this.lblCoilNumber = new System.Windows.Forms.Label();
            this.lblUsedWidthInDetail = new System.Windows.Forms.Label();
            this.lblCoilNumberLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUsedWidthInDetailLabel = new System.Windows.Forms.Label();
            this.lblCutterNameLabel = new System.Windows.Forms.Label();
            this.lblNotesLabel = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblFilmNameLabel = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.lblFilmNameInDetail = new System.Windows.Forms.Label();
            this.grpbCombination = new System.Windows.Forms.GroupBox();
            this.lblWaste1 = new System.Windows.Forms.Label();
            this.lblWaste2 = new System.Windows.Forms.Label();
            this.nudStopsNumber = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvCuttingOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPositions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRepetitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProgrammedWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpCuttingOrder = new System.Windows.Forms.ToolTip(this.components);
            this.tbcCuttingOrder.SuspendLayout();
            this.tbpFilmSelection.SuspendLayout();
            this.grpbFilters.SuspendLayout();
            this.grpbFilterActions.SuspendLayout();
            this.grpbThicknessFilmTab.SuspendLayout();
            this.grpbAdditivationsFilmTab.SuspendLayout();
            this.grpbSealsFilmTab.SuspendLayout();
            this.grpbFamiliesFilmTab.SuspendLayout();
            this.grpbFilms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBopp)).BeginInit();
            this.tbpCuttingPlan.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWasteAllowed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStops)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.grpbStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.grpbSalesOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderDetail)).BeginInit();
            this.grpbCutterMachine.SuspendLayout();
            this.grpbFilmNameSalesOrderTab.SuspendLayout();
            this.tbpResume.SuspendLayout();
            this.grpbCuttingOrderDetail.SuspendLayout();
            this.grpbCombination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopsNumber)).BeginInit();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCuttingOrder
            // 
            this.tbcCuttingOrder.Controls.Add(this.tbpFilmSelection);
            this.tbcCuttingOrder.Controls.Add(this.tbpCuttingPlan);
            this.tbcCuttingOrder.Controls.Add(this.tbpResume);
            this.tbcCuttingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCuttingOrder.Location = new System.Drawing.Point(0, 0);
            this.tbcCuttingOrder.Name = "tbcCuttingOrder";
            this.tbcCuttingOrder.SelectedIndex = 0;
            this.tbcCuttingOrder.Size = new System.Drawing.Size(1084, 630);
            this.tbcCuttingOrder.TabIndex = 0;
            // 
            // tbpFilmSelection
            // 
            this.tbpFilmSelection.BackColor = System.Drawing.SystemColors.Window;
            this.tbpFilmSelection.Controls.Add(this.grpbFilters);
            this.tbpFilmSelection.Controls.Add(this.grpbFilms);
            this.tbpFilmSelection.Location = new System.Drawing.Point(4, 24);
            this.tbpFilmSelection.Name = "tbpFilmSelection";
            this.tbpFilmSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFilmSelection.Size = new System.Drawing.Size(1076, 602);
            this.tbpFilmSelection.TabIndex = 0;
            this.tbpFilmSelection.Text = "Selección de película";
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.grpbFilterActions);
            this.grpbFilters.Controls.Add(this.grpbThicknessFilmTab);
            this.grpbFilters.Controls.Add(this.grpbAdditivationsFilmTab);
            this.grpbFilters.Controls.Add(this.grpbSealsFilmTab);
            this.grpbFilters.Controls.Add(this.grpbFamiliesFilmTab);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(3, 482);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(1070, 98);
            this.grpbFilters.TabIndex = 1;
            this.grpbFilters.TabStop = false;
            // 
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Location = new System.Drawing.Point(1023, 13);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(41, 82);
            this.grpbFilterActions.TabIndex = 4;
            this.grpbFilterActions.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(8, 46);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 0;
            this.ttpCuttingOrder.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(8, 22);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 1;
            this.ttpCuttingOrder.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // grpbThicknessFilmTab
            // 
            this.grpbThicknessFilmTab.Controls.Add(this.lblThickness);
            this.grpbThicknessFilmTab.Controls.Add(this.lblTreatment);
            this.grpbThicknessFilmTab.Controls.Add(this.cmbTreatment);
            this.grpbThicknessFilmTab.Controls.Add(this.cmbThikness);
            this.grpbThicknessFilmTab.Location = new System.Drawing.Point(760, 13);
            this.grpbThicknessFilmTab.Name = "grpbThicknessFilmTab";
            this.grpbThicknessFilmTab.Size = new System.Drawing.Size(263, 82);
            this.grpbThicknessFilmTab.TabIndex = 3;
            this.grpbThicknessFilmTab.TabStop = false;
            this.grpbThicknessFilmTab.Text = "Espesor && tratamiento";
            // 
            // lblThickness
            // 
            this.lblThickness.AutoSize = true;
            this.lblThickness.Location = new System.Drawing.Point(11, 24);
            this.lblThickness.Name = "lblThickness";
            this.lblThickness.Size = new System.Drawing.Size(65, 15);
            this.lblThickness.TabIndex = 22;
            this.lblThickness.Text = "Espesores";
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(11, 52);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(73, 15);
            this.lblTreatment.TabIndex = 20;
            this.lblTreatment.Text = "Tratamiento";
            // 
            // cmbTreatment
            // 
            this.cmbTreatment.FormattingEnabled = true;
            this.cmbTreatment.Location = new System.Drawing.Point(87, 49);
            this.cmbTreatment.Name = "cmbTreatment";
            this.cmbTreatment.Size = new System.Drawing.Size(170, 23);
            this.cmbTreatment.TabIndex = 1;
            // 
            // cmbThikness
            // 
            this.cmbThikness.FormattingEnabled = true;
            this.cmbThikness.Location = new System.Drawing.Point(87, 21);
            this.cmbThikness.Name = "cmbThikness";
            this.cmbThikness.Size = new System.Drawing.Size(170, 23);
            this.cmbThikness.TabIndex = 0;
            // 
            // grpbAdditivationsFilmTab
            // 
            this.grpbAdditivationsFilmTab.Controls.Add(this.lblCentralAdditivation);
            this.grpbAdditivationsFilmTab.Controls.Add(this.cmbCentralAdditivation);
            this.grpbAdditivationsFilmTab.Controls.Add(this.lblSurfaceAdditivation);
            this.grpbAdditivationsFilmTab.Controls.Add(this.cmbSurfaceAdditivation);
            this.grpbAdditivationsFilmTab.Location = new System.Drawing.Point(509, 13);
            this.grpbAdditivationsFilmTab.Name = "grpbAdditivationsFilmTab";
            this.grpbAdditivationsFilmTab.Size = new System.Drawing.Size(251, 82);
            this.grpbAdditivationsFilmTab.TabIndex = 2;
            this.grpbAdditivationsFilmTab.TabStop = false;
            this.grpbAdditivationsFilmTab.Text = "Aditivación";
            // 
            // lblCentralAdditivation
            // 
            this.lblCentralAdditivation.AutoSize = true;
            this.lblCentralAdditivation.Location = new System.Drawing.Point(8, 24);
            this.lblCentralAdditivation.Name = "lblCentralAdditivation";
            this.lblCentralAdditivation.Size = new System.Drawing.Size(46, 15);
            this.lblCentralAdditivation.TabIndex = 16;
            this.lblCentralAdditivation.Text = "Central";
            // 
            // cmbCentralAdditivation
            // 
            this.cmbCentralAdditivation.FormattingEnabled = true;
            this.cmbCentralAdditivation.Location = new System.Drawing.Point(74, 21);
            this.cmbCentralAdditivation.Name = "cmbCentralAdditivation";
            this.cmbCentralAdditivation.Size = new System.Drawing.Size(169, 23);
            this.cmbCentralAdditivation.TabIndex = 0;
            // 
            // lblSurfaceAdditivation
            // 
            this.lblSurfaceAdditivation.AutoSize = true;
            this.lblSurfaceAdditivation.Location = new System.Drawing.Point(8, 52);
            this.lblSurfaceAdditivation.Name = "lblSurfaceAdditivation";
            this.lblSurfaceAdditivation.Size = new System.Drawing.Size(62, 15);
            this.lblSurfaceAdditivation.TabIndex = 18;
            this.lblSurfaceAdditivation.Text = "Superficie";
            // 
            // cmbSurfaceAdditivation
            // 
            this.cmbSurfaceAdditivation.FormattingEnabled = true;
            this.cmbSurfaceAdditivation.Location = new System.Drawing.Point(74, 49);
            this.cmbSurfaceAdditivation.Name = "cmbSurfaceAdditivation";
            this.cmbSurfaceAdditivation.Size = new System.Drawing.Size(170, 23);
            this.cmbSurfaceAdditivation.TabIndex = 1;
            // 
            // grpbSealsFilmTab
            // 
            this.grpbSealsFilmTab.Controls.Add(this.cmbOuterSeal);
            this.grpbSealsFilmTab.Controls.Add(this.lblInnerSeal);
            this.grpbSealsFilmTab.Controls.Add(this.cmbInnerSeal);
            this.grpbSealsFilmTab.Controls.Add(this.lblOuterSeal);
            this.grpbSealsFilmTab.Location = new System.Drawing.Point(272, 13);
            this.grpbSealsFilmTab.Name = "grpbSealsFilmTab";
            this.grpbSealsFilmTab.Size = new System.Drawing.Size(237, 82);
            this.grpbSealsFilmTab.TabIndex = 1;
            this.grpbSealsFilmTab.TabStop = false;
            this.grpbSealsFilmTab.Text = "Sello";
            // 
            // cmbOuterSeal
            // 
            this.cmbOuterSeal.FormattingEnabled = true;
            this.cmbOuterSeal.Location = new System.Drawing.Point(60, 49);
            this.cmbOuterSeal.Name = "cmbOuterSeal";
            this.cmbOuterSeal.Size = new System.Drawing.Size(170, 23);
            this.cmbOuterSeal.TabIndex = 1;
            // 
            // lblInnerSeal
            // 
            this.lblInnerSeal.AutoSize = true;
            this.lblInnerSeal.Location = new System.Drawing.Point(5, 24);
            this.lblInnerSeal.Name = "lblInnerSeal";
            this.lblInnerSeal.Size = new System.Drawing.Size(45, 15);
            this.lblInnerSeal.TabIndex = 12;
            this.lblInnerSeal.Text = "Interno";
            // 
            // cmbInnerSeal
            // 
            this.cmbInnerSeal.FormattingEnabled = true;
            this.cmbInnerSeal.Location = new System.Drawing.Point(60, 21);
            this.cmbInnerSeal.Name = "cmbInnerSeal";
            this.cmbInnerSeal.Size = new System.Drawing.Size(170, 23);
            this.cmbInnerSeal.TabIndex = 0;
            // 
            // lblOuterSeal
            // 
            this.lblOuterSeal.AutoSize = true;
            this.lblOuterSeal.Location = new System.Drawing.Point(5, 52);
            this.lblOuterSeal.Name = "lblOuterSeal";
            this.lblOuterSeal.Size = new System.Drawing.Size(49, 15);
            this.lblOuterSeal.TabIndex = 14;
            this.lblOuterSeal.Text = "Externo";
            // 
            // grpbFamiliesFilmTab
            // 
            this.grpbFamiliesFilmTab.Controls.Add(this.lblSubFamily);
            this.grpbFamiliesFilmTab.Controls.Add(this.lblFamily);
            this.grpbFamiliesFilmTab.Controls.Add(this.cmbFamily);
            this.grpbFamiliesFilmTab.Controls.Add(this.cmbSubFamily);
            this.grpbFamiliesFilmTab.Location = new System.Drawing.Point(6, 13);
            this.grpbFamiliesFilmTab.Name = "grpbFamiliesFilmTab";
            this.grpbFamiliesFilmTab.Size = new System.Drawing.Size(266, 82);
            this.grpbFamiliesFilmTab.TabIndex = 0;
            this.grpbFamiliesFilmTab.TabStop = false;
            this.grpbFamiliesFilmTab.Text = "Familias";
            // 
            // lblSubFamily
            // 
            this.lblSubFamily.AutoSize = true;
            this.lblSubFamily.Location = new System.Drawing.Point(8, 52);
            this.lblSubFamily.Name = "lblSubFamily";
            this.lblSubFamily.Size = new System.Drawing.Size(73, 15);
            this.lblSubFamily.TabIndex = 10;
            this.lblSubFamily.Text = "Sub Familia";
            // 
            // lblFamily
            // 
            this.lblFamily.AutoSize = true;
            this.lblFamily.Location = new System.Drawing.Point(8, 24);
            this.lblFamily.Name = "lblFamily";
            this.lblFamily.Size = new System.Drawing.Size(48, 15);
            this.lblFamily.TabIndex = 8;
            this.lblFamily.Text = "Familia";
            // 
            // cmbFamily
            // 
            this.cmbFamily.FormattingEnabled = true;
            this.cmbFamily.Location = new System.Drawing.Point(88, 21);
            this.cmbFamily.Name = "cmbFamily";
            this.cmbFamily.Size = new System.Drawing.Size(170, 23);
            this.cmbFamily.TabIndex = 0;
            // 
            // cmbSubFamily
            // 
            this.cmbSubFamily.FormattingEnabled = true;
            this.cmbSubFamily.Location = new System.Drawing.Point(88, 49);
            this.cmbSubFamily.Name = "cmbSubFamily";
            this.cmbSubFamily.Size = new System.Drawing.Size(170, 23);
            this.cmbSubFamily.TabIndex = 1;
            // 
            // grpbFilms
            // 
            this.grpbFilms.Controls.Add(this.groupBox1);
            this.grpbFilms.Controls.Add(this.dgvBopp);
            this.grpbFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilms.Location = new System.Drawing.Point(3, 3);
            this.grpbFilms.Name = "grpbFilms";
            this.grpbFilms.Size = new System.Drawing.Size(1070, 479);
            this.grpbFilms.TabIndex = 0;
            this.grpbFilms.TabStop = false;
            this.grpbFilms.Text = "Peliculas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddNewBopp);
            this.groupBox1.Controls.Add(this.btnRefreshBopp);
            this.groupBox1.Controls.Add(this.txtBoppName);
            this.groupBox1.Controls.Add(this.lblBoppName);
            this.groupBox1.Controls.Add(this.txtBoppCode);
            this.groupBox1.Controls.Add(this.lblBoppCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1064, 43);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnAddNewBopp
            // 
            this.btnAddNewBopp.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAddNewBopp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddNewBopp.Location = new System.Drawing.Point(820, 12);
            this.btnAddNewBopp.Name = "btnAddNewBopp";
            this.btnAddNewBopp.Size = new System.Drawing.Size(25, 25);
            this.btnAddNewBopp.TabIndex = 5;
            this.btnAddNewBopp.UseVisualStyleBackColor = true;
            // 
            // btnRefreshBopp
            // 
            this.btnRefreshBopp.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefreshBopp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefreshBopp.Location = new System.Drawing.Point(794, 12);
            this.btnRefreshBopp.Name = "btnRefreshBopp";
            this.btnRefreshBopp.Size = new System.Drawing.Size(25, 25);
            this.btnRefreshBopp.TabIndex = 5;
            this.btnRefreshBopp.UseVisualStyleBackColor = true;
            // 
            // txtBoppName
            // 
            this.txtBoppName.Location = new System.Drawing.Point(586, 14);
            this.txtBoppName.Name = "txtBoppName";
            this.txtBoppName.Size = new System.Drawing.Size(202, 21);
            this.txtBoppName.TabIndex = 3;
            // 
            // lblBoppName
            // 
            this.lblBoppName.AutoSize = true;
            this.lblBoppName.Location = new System.Drawing.Point(526, 17);
            this.lblBoppName.Name = "lblBoppName";
            this.lblBoppName.Size = new System.Drawing.Size(52, 15);
            this.lblBoppName.TabIndex = 2;
            this.lblBoppName.Text = "Nombre";
            // 
            // txtBoppCode
            // 
            this.txtBoppCode.Location = new System.Drawing.Point(316, 14);
            this.txtBoppCode.Name = "txtBoppCode";
            this.txtBoppCode.Size = new System.Drawing.Size(202, 21);
            this.txtBoppCode.TabIndex = 1;
            this.txtBoppCode.TextChanged += new System.EventHandler(this.txtBoppCode_TextChanged);
            // 
            // lblBoppCode
            // 
            this.lblBoppCode.AutoSize = true;
            this.lblBoppCode.Location = new System.Drawing.Point(262, 17);
            this.lblBoppCode.Name = "lblBoppCode";
            this.lblBoppCode.Size = new System.Drawing.Size(46, 15);
            this.lblBoppCode.TabIndex = 0;
            this.lblBoppCode.Text = "Código";
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
            this.clmTotalWeightFilms,
            this.clmMainCoilQuantity});
            this.dgvBopp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBopp.Location = new System.Drawing.Point(3, 66);
            this.dgvBopp.MultiSelect = false;
            this.dgvBopp.Name = "dgvBopp";
            this.dgvBopp.ReadOnly = true;
            this.dgvBopp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBopp.Size = new System.Drawing.Size(1064, 410);
            this.dgvBopp.TabIndex = 0;
            this.dgvBopp.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBopp_CellMouseDoubleClick);
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
            this.clmCode.Width = 120;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 400;
            // 
            // clmTotalWeightFilms
            // 
            this.clmTotalWeightFilms.HeaderText = "Ordenes de Venta";
            this.clmTotalWeightFilms.Name = "clmTotalWeightFilms";
            this.clmTotalWeightFilms.ReadOnly = true;
            this.clmTotalWeightFilms.Width = 150;
            // 
            // clmMainCoilQuantity
            // 
            this.clmMainCoilQuantity.HeaderText = "Rollos Madre";
            this.clmMainCoilQuantity.Name = "clmMainCoilQuantity";
            this.clmMainCoilQuantity.ReadOnly = true;
            this.clmMainCoilQuantity.Width = 150;
            // 
            // tbpCuttingPlan
            // 
            this.tbpCuttingPlan.BackColor = System.Drawing.SystemColors.Window;
            this.tbpCuttingPlan.Controls.Add(this.chkAllowEquivalentFilm);
            this.tbpCuttingPlan.Controls.Add(this.grpbNotes);
            this.tbpCuttingPlan.Controls.Add(this.lblPercentage2);
            this.tbpCuttingPlan.Controls.Add(this.lblPercentage1);
            this.tbpCuttingPlan.Controls.Add(this.lblMessage);
            this.tbpCuttingPlan.Controls.Add(this.nudWasteAllowed);
            this.tbpCuttingPlan.Controls.Add(this.nudStops);
            this.tbpCuttingPlan.Controls.Add(this.lblViableCombination);
            this.tbpCuttingPlan.Controls.Add(this.lblUnusedWidth);
            this.tbpCuttingPlan.Controls.Add(this.lblUsedArms);
            this.tbpCuttingPlan.Controls.Add(this.lblWaste);
            this.tbpCuttingPlan.Controls.Add(this.lblUsedWidth);
            this.tbpCuttingPlan.Controls.Add(this.grpbMainCoilButtons);
            this.tbpCuttingPlan.Controls.Add(this.lblViableCombinationLabel);
            this.tbpCuttingPlan.Controls.Add(this.lblUnusedWidthLabel);
            this.tbpCuttingPlan.Controls.Add(this.lblWasteAllowed);
            this.tbpCuttingPlan.Controls.Add(this.lblUsedArmsLabel);
            this.tbpCuttingPlan.Controls.Add(this.lblWasteLabel);
            this.tbpCuttingPlan.Controls.Add(this.lblStops);
            this.tbpCuttingPlan.Controls.Add(this.lblUsedWidthLabel);
            this.tbpCuttingPlan.Controls.Add(this.grpbStock);
            this.tbpCuttingPlan.Controls.Add(this.grpbSalesOrders);
            this.tbpCuttingPlan.Controls.Add(this.grpbCutterMachine);
            this.tbpCuttingPlan.Controls.Add(this.grpbFilmNameSalesOrderTab);
            this.tbpCuttingPlan.Location = new System.Drawing.Point(4, 24);
            this.tbpCuttingPlan.Name = "tbpCuttingPlan";
            this.tbpCuttingPlan.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCuttingPlan.Size = new System.Drawing.Size(1076, 602);
            this.tbpCuttingPlan.TabIndex = 1;
            this.tbpCuttingPlan.Text = "Programación de corte";
            // 
            // chkAllowEquivalentFilm
            // 
            this.chkAllowEquivalentFilm.AutoSize = true;
            this.chkAllowEquivalentFilm.Location = new System.Drawing.Point(682, 541);
            this.chkAllowEquivalentFilm.Name = "chkAllowEquivalentFilm";
            this.chkAllowEquivalentFilm.Size = new System.Drawing.Size(188, 19);
            this.chkAllowEquivalentFilm.TabIndex = 11;
            this.chkAllowEquivalentFilm.Text = "Utilizar películas equivalentes";
            this.chkAllowEquivalentFilm.UseVisualStyleBackColor = true;
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtNotes);
            this.grpbNotes.Location = new System.Drawing.Point(10, 475);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(660, 56);
            this.grpbNotes.TabIndex = 22;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Observaciones";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 16);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(654, 37);
            this.txtNotes.TabIndex = 0;
            // 
            // lblPercentage2
            // 
            this.lblPercentage2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage2.Location = new System.Drawing.Point(819, 520);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage2.TabIndex = 15;
            this.lblPercentage2.Text = "%";
            // 
            // lblPercentage1
            // 
            this.lblPercentage1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage1.AutoSize = true;
            this.lblPercentage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage1.Location = new System.Drawing.Point(819, 498);
            this.lblPercentage1.Name = "lblPercentage1";
            this.lblPercentage1.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage1.TabIndex = 16;
            this.lblPercentage1.Text = "%";
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(7, 534);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(585, 60);
            this.lblMessage.TabIndex = 4;
            // 
            // nudWasteAllowed
            // 
            this.nudWasteAllowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudWasteAllowed.Location = new System.Drawing.Point(777, 496);
            this.nudWasteAllowed.Name = "nudWasteAllowed";
            this.nudWasteAllowed.Size = new System.Drawing.Size(41, 21);
            this.nudWasteAllowed.TabIndex = 9;
            this.nudWasteAllowed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWasteAllowed.ValueChanged += new System.EventHandler(this.nudWasteAllowed_ValueChanged);
            // 
            // nudStops
            // 
            this.nudStops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudStops.Location = new System.Drawing.Point(777, 473);
            this.nudStops.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudStops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStops.Name = "nudStops";
            this.nudStops.Size = new System.Drawing.Size(41, 21);
            this.nudStops.TabIndex = 8;
            this.nudStops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStops.ValueChanged += new System.EventHandler(this.nudStops_ValueChanged);
            // 
            // lblViableCombination
            // 
            this.lblViableCombination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViableCombination.BackColor = System.Drawing.SystemColors.Window;
            this.lblViableCombination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblViableCombination.Location = new System.Drawing.Point(996, 535);
            this.lblViableCombination.Name = "lblViableCombination";
            this.lblViableCombination.Size = new System.Drawing.Size(70, 21);
            this.lblViableCombination.TabIndex = 20;
            this.lblViableCombination.Tag = "clearOnReload";
            this.lblViableCombination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnusedWidth
            // 
            this.lblUnusedWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnusedWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUnusedWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnusedWidth.Location = new System.Drawing.Point(996, 514);
            this.lblUnusedWidth.Name = "lblUnusedWidth";
            this.lblUnusedWidth.Size = new System.Drawing.Size(70, 21);
            this.lblUnusedWidth.TabIndex = 19;
            this.lblUnusedWidth.Tag = "clearOnReload";
            this.lblUnusedWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsedArms
            // 
            this.lblUsedArms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedArms.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedArms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedArms.Location = new System.Drawing.Point(996, 493);
            this.lblUsedArms.Name = "lblUsedArms";
            this.lblUsedArms.Size = new System.Drawing.Size(70, 21);
            this.lblUsedArms.TabIndex = 18;
            this.lblUsedArms.Tag = "clearOnReload";
            this.lblUsedArms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaste
            // 
            this.lblWaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaste.BackColor = System.Drawing.SystemColors.Window;
            this.lblWaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWaste.Location = new System.Drawing.Point(777, 517);
            this.lblWaste.Name = "lblWaste";
            this.lblWaste.Size = new System.Drawing.Size(41, 21);
            this.lblWaste.TabIndex = 10;
            this.lblWaste.Tag = "clearOnReload";
            this.lblWaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsedWidth
            // 
            this.lblUsedWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedWidth.Location = new System.Drawing.Point(996, 472);
            this.lblUsedWidth.Name = "lblUsedWidth";
            this.lblUsedWidth.Size = new System.Drawing.Size(70, 21);
            this.lblUsedWidth.TabIndex = 17;
            this.lblUsedWidth.Tag = "clearOnReload";
            this.lblUsedWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbMainCoilButtons.Controls.Add(this.btnNext);
            this.grpbMainCoilButtons.Controls.Add(this.btnAdd);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(984, 555);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(84, 44);
            this.grpbMainCoilButtons.TabIndex = 21;
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
            // lblViableCombinationLabel
            // 
            this.lblViableCombinationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViableCombinationLabel.AutoSize = true;
            this.lblViableCombinationLabel.Location = new System.Drawing.Point(877, 538);
            this.lblViableCombinationLabel.Name = "lblViableCombinationLabel";
            this.lblViableCombinationLabel.Size = new System.Drawing.Size(115, 15);
            this.lblViableCombinationLabel.TabIndex = 14;
            this.lblViableCombinationLabel.Text = "Combinación viable";
            // 
            // lblUnusedWidthLabel
            // 
            this.lblUnusedWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnusedWidthLabel.AutoSize = true;
            this.lblUnusedWidthLabel.Location = new System.Drawing.Point(914, 517);
            this.lblUnusedWidthLabel.Name = "lblUnusedWidthLabel";
            this.lblUnusedWidthLabel.Size = new System.Drawing.Size(72, 15);
            this.lblUnusedWidthLabel.TabIndex = 13;
            this.lblUnusedWidthLabel.Text = "Ancho Libre";
            // 
            // lblWasteAllowed
            // 
            this.lblWasteAllowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWasteAllowed.AutoSize = true;
            this.lblWasteAllowed.Location = new System.Drawing.Point(679, 498);
            this.lblWasteAllowed.Name = "lblWasteAllowed";
            this.lblWasteAllowed.Size = new System.Drawing.Size(95, 15);
            this.lblWasteAllowed.TabIndex = 6;
            this.lblWasteAllowed.Text = "Desp. Permitido";
            // 
            // lblUsedArmsLabel
            // 
            this.lblUsedArmsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedArmsLabel.AutoSize = true;
            this.lblUsedArmsLabel.Location = new System.Drawing.Point(877, 496);
            this.lblUsedArmsLabel.Name = "lblUsedArmsLabel";
            this.lblUsedArmsLabel.Size = new System.Drawing.Size(109, 15);
            this.lblUsedArmsLabel.TabIndex = 12;
            this.lblUsedArmsLabel.Text = "Número de brazos";
            // 
            // lblWasteLabel
            // 
            this.lblWasteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWasteLabel.AutoSize = true;
            this.lblWasteLabel.Location = new System.Drawing.Point(679, 520);
            this.lblWasteLabel.Name = "lblWasteLabel";
            this.lblWasteLabel.Size = new System.Drawing.Size(73, 15);
            this.lblWasteLabel.TabIndex = 7;
            this.lblWasteLabel.Text = "Desperdicio";
            // 
            // lblStops
            // 
            this.lblStops.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStops.AutoSize = true;
            this.lblStops.Location = new System.Drawing.Point(679, 475);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(95, 15);
            this.lblStops.TabIndex = 5;
            this.lblStops.Text = "Nro. de paradas";
            // 
            // lblUsedWidthLabel
            // 
            this.lblUsedWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsedWidthLabel.AutoSize = true;
            this.lblUsedWidthLabel.Location = new System.Drawing.Point(894, 475);
            this.lblUsedWidthLabel.Name = "lblUsedWidthLabel";
            this.lblUsedWidthLabel.Size = new System.Drawing.Size(92, 15);
            this.lblUsedWidthLabel.TabIndex = 11;
            this.lblUsedWidthLabel.Text = "Ancho Utilizado";
            // 
            // grpbStock
            // 
            this.grpbStock.Controls.Add(this.dgvStock);
            this.grpbStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbStock.Location = new System.Drawing.Point(3, 349);
            this.grpbStock.Name = "grpbStock";
            this.grpbStock.Size = new System.Drawing.Size(1070, 123);
            this.grpbStock.TabIndex = 3;
            this.grpbStock.TabStop = false;
            this.grpbStock.Text = "Stock";
            // 
            // dgvStock
            // 
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmStockProductCodsec,
            this.clmStockProductName,
            this.clmStockWeigth,
            this.clmStockCoilQuantity,
            this.clmStockWidth,
            this.clmStockDiameterCore,
            this.clmStockCoilsToCut,
            this.clmStockTotalCoils,
            this.clmStockProgrammedWeigth,
            this.clmStockSlopeWeigth,
            this.clmStockBoppCodsec,
            this.clmStockDiameterCodsec,
            this.clmStockCoreCodsec});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(3, 17);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.RowHeadersWidth = 25;
            this.dgvStock.Size = new System.Drawing.Size(1064, 103);
            this.dgvStock.TabIndex = 0;
            this.dgvStock.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStock_CellMouseDoubleClick);
            this.dgvStock.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStock_CellValidated);
            this.dgvStock.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvStock_CellValidating);
            // 
            // clmStockProductCodsec
            // 
            this.clmStockProductCodsec.HeaderText = "codsec";
            this.clmStockProductCodsec.Name = "clmStockProductCodsec";
            this.clmStockProductCodsec.ReadOnly = true;
            this.clmStockProductCodsec.Visible = false;
            // 
            // clmStockProductName
            // 
            this.clmStockProductName.HeaderText = "Producto";
            this.clmStockProductName.Name = "clmStockProductName";
            this.clmStockProductName.ReadOnly = true;
            this.clmStockProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockProductName.Width = 410;
            // 
            // clmStockWeigth
            // 
            this.clmStockWeigth.HeaderText = "Peso";
            this.clmStockWeigth.Name = "clmStockWeigth";
            this.clmStockWeigth.ReadOnly = true;
            this.clmStockWeigth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockWeigth.Width = 85;
            // 
            // clmStockCoilQuantity
            // 
            this.clmStockCoilQuantity.HeaderText = "Bobinas";
            this.clmStockCoilQuantity.Name = "clmStockCoilQuantity";
            this.clmStockCoilQuantity.ReadOnly = true;
            this.clmStockCoilQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockCoilQuantity.Width = 70;
            // 
            // clmStockWidth
            // 
            this.clmStockWidth.HeaderText = "Ancho";
            this.clmStockWidth.Name = "clmStockWidth";
            this.clmStockWidth.ReadOnly = true;
            this.clmStockWidth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockWidth.Width = 70;
            // 
            // clmStockDiameterCore
            // 
            this.clmStockDiameterCore.HeaderText = "Diam./ Core";
            this.clmStockDiameterCore.Name = "clmStockDiameterCore";
            this.clmStockDiameterCore.ReadOnly = true;
            this.clmStockDiameterCore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockDiameterCore.Width = 70;
            // 
            // clmStockCoilsToCut
            // 
            this.clmStockCoilsToCut.HeaderText = "Bob. x Parada";
            this.clmStockCoilsToCut.Name = "clmStockCoilsToCut";
            this.clmStockCoilsToCut.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockCoilsToCut.Width = 70;
            // 
            // clmStockTotalCoils
            // 
            this.clmStockTotalCoils.HeaderText = "Bob. Total";
            this.clmStockTotalCoils.Name = "clmStockTotalCoils";
            this.clmStockTotalCoils.ReadOnly = true;
            this.clmStockTotalCoils.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockTotalCoils.Width = 70;
            // 
            // clmStockProgrammedWeigth
            // 
            this.clmStockProgrammedWeigth.HeaderText = "Programado";
            this.clmStockProgrammedWeigth.Name = "clmStockProgrammedWeigth";
            this.clmStockProgrammedWeigth.ReadOnly = true;
            this.clmStockProgrammedWeigth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockProgrammedWeigth.Width = 85;
            // 
            // clmStockSlopeWeigth
            // 
            this.clmStockSlopeWeigth.HeaderText = "Pendiente";
            this.clmStockSlopeWeigth.Name = "clmStockSlopeWeigth";
            this.clmStockSlopeWeigth.ReadOnly = true;
            this.clmStockSlopeWeigth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmStockSlopeWeigth.Width = 85;
            // 
            // clmStockBoppCodsec
            // 
            this.clmStockBoppCodsec.HeaderText = "boppCodsec";
            this.clmStockBoppCodsec.Name = "clmStockBoppCodsec";
            this.clmStockBoppCodsec.ReadOnly = true;
            this.clmStockBoppCodsec.Visible = false;
            // 
            // clmStockDiameterCodsec
            // 
            this.clmStockDiameterCodsec.HeaderText = "diameterCodsec";
            this.clmStockDiameterCodsec.Name = "clmStockDiameterCodsec";
            this.clmStockDiameterCodsec.ReadOnly = true;
            this.clmStockDiameterCodsec.Visible = false;
            // 
            // clmStockCoreCodsec
            // 
            this.clmStockCoreCodsec.HeaderText = "coreCodsec";
            this.clmStockCoreCodsec.Name = "clmStockCoreCodsec";
            this.clmStockCoreCodsec.ReadOnly = true;
            this.clmStockCoreCodsec.Visible = false;
            // 
            // grpbSalesOrders
            // 
            this.grpbSalesOrders.Controls.Add(this.dgvSalesOrderDetail);
            this.grpbSalesOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrders.Location = new System.Drawing.Point(3, 98);
            this.grpbSalesOrders.Name = "grpbSalesOrders";
            this.grpbSalesOrders.Size = new System.Drawing.Size(1070, 251);
            this.grpbSalesOrders.TabIndex = 2;
            this.grpbSalesOrders.TabStop = false;
            this.grpbSalesOrders.Text = "Ordenes de venta";
            this.grpbSalesOrders.Enter += new System.EventHandler(this.grpbSalesOrders_Enter);
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
            this.clmSalesOrderChangeProduct,
            this.clmSalesOrderWeigth,
            this.clmSalesOrderTotalOrderCoils,
            this.clmSalesOrderCoilsQuantity,
            this.clmSalesOrderWidth,
            this.clmSalesOrderCoreDiameter,
            this.clmSalesOrderCoilsToCut,
            this.clmSalesOrderTotalCoils,
            this.clmSalesOrderProgrammedWeigth,
            this.clmSalesOrderSlopeWeigth,
            this.clmSalesOrderProductCodsec,
            this.clmSalesOrderOriginalProductCodsec,
            this.clmSalesOrderTotalSlope,
            this.clmSalesOrderIsEquivalentFilm,
            this.clmSalesOrderDetailIndex});
            this.dgvSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrderDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvSalesOrderDetail.Name = "dgvSalesOrderDetail";
            this.dgvSalesOrderDetail.RowHeadersWidth = 25;
            this.dgvSalesOrderDetail.Size = new System.Drawing.Size(1064, 231);
            this.dgvSalesOrderDetail.TabIndex = 0;
            this.dgvSalesOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrderDetail_CellClick);
            this.dgvSalesOrderDetail.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrderDetail_CellValidated);
            this.dgvSalesOrderDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSalesOrderDetail_CellValidating);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSalesOrderCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmSalesOrderCustomer.HeaderText = "Cliente";
            this.clmSalesOrderCustomer.Name = "clmSalesOrderCustomer";
            this.clmSalesOrderCustomer.ReadOnly = true;
            this.clmSalesOrderCustomer.Width = 150;
            // 
            // clmSalesOrderNumber
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSalesOrderNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmSalesOrderNumber.HeaderText = "O. Venta";
            this.clmSalesOrderNumber.Name = "clmSalesOrderNumber";
            this.clmSalesOrderNumber.ReadOnly = true;
            this.clmSalesOrderNumber.Width = 60;
            // 
            // clmSalesOrderProduct
            // 
            this.clmSalesOrderProduct.HeaderText = "Producto";
            this.clmSalesOrderProduct.Name = "clmSalesOrderProduct";
            this.clmSalesOrderProduct.ReadOnly = true;
            this.clmSalesOrderProduct.Width = 170;
            // 
            // clmSalesOrderChangeProduct
            // 
            this.clmSalesOrderChangeProduct.HeaderText = "";
            this.clmSalesOrderChangeProduct.Name = "clmSalesOrderChangeProduct";
            this.clmSalesOrderChangeProduct.ReadOnly = true;
            this.clmSalesOrderChangeProduct.Width = 30;
            // 
            // clmSalesOrderWeigth
            // 
            this.clmSalesOrderWeigth.HeaderText = "Peso";
            this.clmSalesOrderWeigth.Name = "clmSalesOrderWeigth";
            this.clmSalesOrderWeigth.ReadOnly = true;
            this.clmSalesOrderWeigth.Width = 75;
            // 
            // clmSalesOrderTotalOrderCoils
            // 
            this.clmSalesOrderTotalOrderCoils.HeaderText = "Total Bobinas";
            this.clmSalesOrderTotalOrderCoils.Name = "clmSalesOrderTotalOrderCoils";
            this.clmSalesOrderTotalOrderCoils.ReadOnly = true;
            this.clmSalesOrderTotalOrderCoils.Width = 60;
            // 
            // clmSalesOrderCoilsQuantity
            // 
            this.clmSalesOrderCoilsQuantity.HeaderText = "Bobinas Faltantes";
            this.clmSalesOrderCoilsQuantity.Name = "clmSalesOrderCoilsQuantity";
            this.clmSalesOrderCoilsQuantity.ReadOnly = true;
            this.clmSalesOrderCoilsQuantity.Width = 60;
            // 
            // clmSalesOrderWidth
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSalesOrderWidth.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmSalesOrderWidth.HeaderText = "Ancho";
            this.clmSalesOrderWidth.Name = "clmSalesOrderWidth";
            this.clmSalesOrderWidth.ReadOnly = true;
            this.clmSalesOrderWidth.Width = 60;
            // 
            // clmSalesOrderCoreDiameter
            // 
            this.clmSalesOrderCoreDiameter.HeaderText = "Diam./ Core";
            this.clmSalesOrderCoreDiameter.Name = "clmSalesOrderCoreDiameter";
            this.clmSalesOrderCoreDiameter.ReadOnly = true;
            this.clmSalesOrderCoreDiameter.Width = 60;
            // 
            // clmSalesOrderCoilsToCut
            // 
            this.clmSalesOrderCoilsToCut.HeaderText = "Bob. x Parada";
            this.clmSalesOrderCoilsToCut.Name = "clmSalesOrderCoilsToCut";
            this.clmSalesOrderCoilsToCut.Width = 60;
            // 
            // clmSalesOrderTotalCoils
            // 
            this.clmSalesOrderTotalCoils.HeaderText = "Bob. Total";
            this.clmSalesOrderTotalCoils.Name = "clmSalesOrderTotalCoils";
            this.clmSalesOrderTotalCoils.ReadOnly = true;
            this.clmSalesOrderTotalCoils.Width = 60;
            // 
            // clmSalesOrderProgrammedWeigth
            // 
            this.clmSalesOrderProgrammedWeigth.HeaderText = "Programado";
            this.clmSalesOrderProgrammedWeigth.Name = "clmSalesOrderProgrammedWeigth";
            this.clmSalesOrderProgrammedWeigth.ReadOnly = true;
            this.clmSalesOrderProgrammedWeigth.Width = 85;
            // 
            // clmSalesOrderSlopeWeigth
            // 
            this.clmSalesOrderSlopeWeigth.HeaderText = "Pendiente";
            this.clmSalesOrderSlopeWeigth.Name = "clmSalesOrderSlopeWeigth";
            this.clmSalesOrderSlopeWeigth.ReadOnly = true;
            this.clmSalesOrderSlopeWeigth.Width = 85;
            // 
            // clmSalesOrderProductCodsec
            // 
            this.clmSalesOrderProductCodsec.HeaderText = "productCodsec";
            this.clmSalesOrderProductCodsec.Name = "clmSalesOrderProductCodsec";
            this.clmSalesOrderProductCodsec.ReadOnly = true;
            this.clmSalesOrderProductCodsec.Visible = false;
            // 
            // clmSalesOrderOriginalProductCodsec
            // 
            this.clmSalesOrderOriginalProductCodsec.HeaderText = "originalProduct";
            this.clmSalesOrderOriginalProductCodsec.Name = "clmSalesOrderOriginalProductCodsec";
            this.clmSalesOrderOriginalProductCodsec.ReadOnly = true;
            this.clmSalesOrderOriginalProductCodsec.Visible = false;
            // 
            // clmSalesOrderTotalSlope
            // 
            this.clmSalesOrderTotalSlope.HeaderText = "Pendiente total";
            this.clmSalesOrderTotalSlope.Name = "clmSalesOrderTotalSlope";
            this.clmSalesOrderTotalSlope.Visible = false;
            // 
            // clmSalesOrderIsEquivalentFilm
            // 
            this.clmSalesOrderIsEquivalentFilm.HeaderText = "";
            this.clmSalesOrderIsEquivalentFilm.Name = "clmSalesOrderIsEquivalentFilm";
            this.clmSalesOrderIsEquivalentFilm.ReadOnly = true;
            this.clmSalesOrderIsEquivalentFilm.Visible = false;
            // 
            // clmSalesOrderDetailIndex
            // 
            this.clmSalesOrderDetailIndex.HeaderText = "index";
            this.clmSalesOrderDetailIndex.Name = "clmSalesOrderDetailIndex";
            this.clmSalesOrderDetailIndex.ReadOnly = true;
            this.clmSalesOrderDetailIndex.Visible = false;
            // 
            // grpbCutterMachine
            // 
            this.grpbCutterMachine.Controls.Add(this.chkLoadEquivalentFilm);
            this.grpbCutterMachine.Controls.Add(this.txtUtilWidth);
            this.grpbCutterMachine.Controls.Add(this.btnFilterSalesOrder);
            this.grpbCutterMachine.Controls.Add(this.btnClearFilterSalesOrder);
            this.grpbCutterMachine.Controls.Add(this.lblSeparator);
            this.grpbCutterMachine.Controls.Add(this.cmbDiameter);
            this.grpbCutterMachine.Controls.Add(this.lblDiameter);
            this.grpbCutterMachine.Controls.Add(this.cmbCore);
            this.grpbCutterMachine.Controls.Add(this.lblCore);
            this.grpbCutterMachine.Controls.Add(this.cmbCutter);
            this.grpbCutterMachine.Controls.Add(this.lblArms);
            this.grpbCutterMachine.Controls.Add(this.lblUtilWidth);
            this.grpbCutterMachine.Controls.Add(this.lblArmsLabel);
            this.grpbCutterMachine.Controls.Add(this.lblUtilWidthLabel);
            this.grpbCutterMachine.Controls.Add(this.lblCutter);
            this.grpbCutterMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCutterMachine.Location = new System.Drawing.Point(3, 46);
            this.grpbCutterMachine.Name = "grpbCutterMachine";
            this.grpbCutterMachine.Size = new System.Drawing.Size(1070, 52);
            this.grpbCutterMachine.TabIndex = 1;
            this.grpbCutterMachine.TabStop = false;
            this.grpbCutterMachine.Text = "Cortadora";
            // 
            // chkLoadEquivalentFilm
            // 
            this.chkLoadEquivalentFilm.Location = new System.Drawing.Point(847, 13);
            this.chkLoadEquivalentFilm.Name = "chkLoadEquivalentFilm";
            this.chkLoadEquivalentFilm.Size = new System.Drawing.Size(147, 34);
            this.chkLoadEquivalentFilm.TabIndex = 13;
            this.chkLoadEquivalentFilm.Text = "Cargar películas equivalentes";
            this.chkLoadEquivalentFilm.UseVisualStyleBackColor = true;
            // 
            // txtUtilWidth
            // 
            this.txtUtilWidth.Location = new System.Drawing.Point(298, 20);
            this.txtUtilWidth.Name = "txtUtilWidth";
            this.txtUtilWidth.Size = new System.Drawing.Size(83, 21);
            this.txtUtilWidth.TabIndex = 3;
            this.txtUtilWidth.TextChanged += new System.EventHandler(this.txtUtilWidth_TextChanged);
            // 
            // btnFilterSalesOrder
            // 
            this.btnFilterSalesOrder.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilterSalesOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterSalesOrder.Location = new System.Drawing.Point(1036, 18);
            this.btnFilterSalesOrder.Name = "btnFilterSalesOrder";
            this.btnFilterSalesOrder.Size = new System.Drawing.Size(25, 25);
            this.btnFilterSalesOrder.TabIndex = 11;
            this.ttpCuttingOrder.SetToolTip(this.btnFilterSalesOrder, "Filtro");
            this.btnFilterSalesOrder.UseVisualStyleBackColor = true;
            this.btnFilterSalesOrder.Click += new System.EventHandler(this.btnFilterSalesOrder_Click);
            // 
            // btnClearFilterSalesOrder
            // 
            this.btnClearFilterSalesOrder.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilterSalesOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilterSalesOrder.Location = new System.Drawing.Point(1011, 18);
            this.btnClearFilterSalesOrder.Name = "btnClearFilterSalesOrder";
            this.btnClearFilterSalesOrder.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilterSalesOrder.TabIndex = 10;
            this.ttpCuttingOrder.SetToolTip(this.btnClearFilterSalesOrder, "Limpiar Filtro");
            this.btnClearFilterSalesOrder.UseVisualStyleBackColor = true;
            this.btnClearFilterSalesOrder.Click += new System.EventHandler(this.btnClearFilterSalesOrder_Click);
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(506, 13);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(2, 35);
            this.lblSeparator.TabIndex = 12;
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(734, 19);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(107, 23);
            this.cmbDiameter.TabIndex = 9;
            this.cmbDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDiameter_KeyDown);
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Location = new System.Drawing.Point(670, 23);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(58, 15);
            this.lblDiameter.TabIndex = 8;
            this.lblDiameter.Text = "Diametro";
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(553, 19);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(107, 23);
            this.cmbCore.TabIndex = 7;
            this.cmbCore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCore_KeyDown);
            // 
            // lblCore
            // 
            this.lblCore.AutoSize = true;
            this.lblCore.Location = new System.Drawing.Point(514, 23);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(33, 15);
            this.lblCore.TabIndex = 6;
            this.lblCore.Text = "Core";
            // 
            // cmbCutter
            // 
            this.cmbCutter.FormattingEnabled = true;
            this.cmbCutter.Location = new System.Drawing.Point(77, 19);
            this.cmbCutter.Name = "cmbCutter";
            this.cmbCutter.Size = new System.Drawing.Size(149, 23);
            this.cmbCutter.TabIndex = 1;
            this.cmbCutter.SelectedIndexChanged += new System.EventHandler(this.cmbCutter_SelectedIndexChanged);
            this.cmbCutter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCutter_KeyDown);
            // 
            // lblArms
            // 
            this.lblArms.BackColor = System.Drawing.SystemColors.Window;
            this.lblArms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArms.Location = new System.Drawing.Point(461, 20);
            this.lblArms.Name = "lblArms";
            this.lblArms.Size = new System.Drawing.Size(39, 21);
            this.lblArms.TabIndex = 5;
            this.lblArms.Tag = "clearOnReload";
            this.lblArms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUtilWidth
            // 
            this.lblUtilWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUtilWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUtilWidth.Location = new System.Drawing.Point(298, 20);
            this.lblUtilWidth.Name = "lblUtilWidth";
            this.lblUtilWidth.Size = new System.Drawing.Size(83, 21);
            this.lblUtilWidth.TabIndex = 1;
            this.lblUtilWidth.Tag = "clearOnReload";
            this.lblUtilWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArmsLabel
            // 
            this.lblArmsLabel.AutoSize = true;
            this.lblArmsLabel.Location = new System.Drawing.Point(385, 23);
            this.lblArmsLabel.Name = "lblArmsLabel";
            this.lblArmsLabel.Size = new System.Drawing.Size(70, 15);
            this.lblArmsLabel.TabIndex = 4;
            this.lblArmsLabel.Text = "Nro. brazos";
            // 
            // lblUtilWidthLabel
            // 
            this.lblUtilWidthLabel.AutoSize = true;
            this.lblUtilWidthLabel.Location = new System.Drawing.Point(232, 23);
            this.lblUtilWidthLabel.Name = "lblUtilWidthLabel";
            this.lblUtilWidthLabel.Size = new System.Drawing.Size(60, 15);
            this.lblUtilWidthLabel.TabIndex = 2;
            this.lblUtilWidthLabel.Text = "Ancho útil";
            // 
            // lblCutter
            // 
            this.lblCutter.AutoSize = true;
            this.lblCutter.Location = new System.Drawing.Point(10, 23);
            this.lblCutter.Name = "lblCutter";
            this.lblCutter.Size = new System.Drawing.Size(61, 15);
            this.lblCutter.TabIndex = 0;
            this.lblCutter.Text = "Cortadora";
            // 
            // grpbFilmNameSalesOrderTab
            // 
            this.grpbFilmNameSalesOrderTab.Controls.Add(this.lblFilmName);
            this.grpbFilmNameSalesOrderTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilmNameSalesOrderTab.Location = new System.Drawing.Point(3, 3);
            this.grpbFilmNameSalesOrderTab.Name = "grpbFilmNameSalesOrderTab";
            this.grpbFilmNameSalesOrderTab.Size = new System.Drawing.Size(1070, 43);
            this.grpbFilmNameSalesOrderTab.TabIndex = 0;
            this.grpbFilmNameSalesOrderTab.TabStop = false;
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(3, 17);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(1064, 23);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpResume
            // 
            this.tbpResume.AutoScroll = true;
            this.tbpResume.BackColor = System.Drawing.SystemColors.Window;
            this.tbpResume.Controls.Add(this.grpbCuttingOrderDetail);
            this.tbpResume.Controls.Add(this.grpbList);
            this.tbpResume.Location = new System.Drawing.Point(4, 24);
            this.tbpResume.Name = "tbpResume";
            this.tbpResume.Padding = new System.Windows.Forms.Padding(3);
            this.tbpResume.Size = new System.Drawing.Size(1076, 602);
            this.tbpResume.TabIndex = 2;
            this.tbpResume.Text = "Resumen";
            // 
            // grpbCuttingOrderDetail
            // 
            this.grpbCuttingOrderDetail.Controls.Add(this.btnChangeCutter);
            this.grpbCuttingOrderDetail.Controls.Add(this.btnRefresh);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblSeparatorInDetail);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblStatusImage);
            this.grpbCuttingOrderDetail.Controls.Add(this.btnSave);
            this.grpbCuttingOrderDetail.Controls.Add(this.btnCancel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblPercentage);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblStopsNumber);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblWasteInDetail);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblWasteInDetailLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblStopNumberInDetailLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblCoilNumber);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblUsedWidthInDetail);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblCoilNumberLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblStatus);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblUsedWidthInDetailLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblCutterNameLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblNotesLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblNotes);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblFilmNameLabel);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblCutterName);
            this.grpbCuttingOrderDetail.Controls.Add(this.lblFilmNameInDetail);
            this.grpbCuttingOrderDetail.Controls.Add(this.grpbCombination);
            this.grpbCuttingOrderDetail.Controls.Add(this.nudStopsNumber);
            this.grpbCuttingOrderDetail.Controls.Add(this.comboBox1);
            this.grpbCuttingOrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCuttingOrderDetail.Location = new System.Drawing.Point(3, 337);
            this.grpbCuttingOrderDetail.Name = "grpbCuttingOrderDetail";
            this.grpbCuttingOrderDetail.Size = new System.Drawing.Size(1070, 223);
            this.grpbCuttingOrderDetail.TabIndex = 3;
            this.grpbCuttingOrderDetail.TabStop = false;
            this.grpbCuttingOrderDetail.Text = "Detalle";
            // 
            // btnChangeCutter
            // 
            this.btnChangeCutter.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh;
            this.btnChangeCutter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeCutter.Location = new System.Drawing.Point(823, 16);
            this.btnChangeCutter.Name = "btnChangeCutter";
            this.btnChangeCutter.Size = new System.Drawing.Size(22, 22);
            this.btnChangeCutter.TabIndex = 41;
            this.btnChangeCutter.UseVisualStyleBackColor = true;
            this.btnChangeCutter.Visible = false;
            this.btnChangeCutter.Click += new System.EventHandler(this.btnChangeCutter_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(282, 170);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 40;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.changeStops);
            // 
            // lblSeparatorInDetail
            // 
            this.lblSeparatorInDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparatorInDetail.Location = new System.Drawing.Point(136, 171);
            this.lblSeparatorInDetail.Name = "lblSeparatorInDetail";
            this.lblSeparatorInDetail.Size = new System.Drawing.Size(2, 49);
            this.lblSeparatorInDetail.TabIndex = 38;
            // 
            // lblStatusImage
            // 
            this.lblStatusImage.Image = global::BPS.Properties.Resources.calendar;
            this.lblStatusImage.Location = new System.Drawing.Point(52, 174);
            this.lblStatusImage.Name = "lblStatusImage";
            this.lblStatusImage.Size = new System.Drawing.Size(25, 25);
            this.lblStatusImage.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(977, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 35;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.save);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(977, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.delete);
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(284, 200);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage.TabIndex = 33;
            this.lblPercentage.Text = "%";
            // 
            // lblStopsNumber
            // 
            this.lblStopsNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblStopsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStopsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopsNumber.Location = new System.Drawing.Point(242, 171);
            this.lblStopsNumber.Name = "lblStopsNumber";
            this.lblStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.lblStopsNumber.TabIndex = 32;
            this.lblStopsNumber.Tag = "clearOnReload";
            this.lblStopsNumber.Text = "0";
            this.lblStopsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteInDetail
            // 
            this.lblWasteInDetail.BackColor = System.Drawing.SystemColors.Window;
            this.lblWasteInDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWasteInDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWasteInDetail.Location = new System.Drawing.Point(242, 198);
            this.lblWasteInDetail.Name = "lblWasteInDetail";
            this.lblWasteInDetail.Size = new System.Drawing.Size(41, 21);
            this.lblWasteInDetail.TabIndex = 32;
            this.lblWasteInDetail.Tag = "clearOnReload";
            this.lblWasteInDetail.Text = "0";
            this.lblWasteInDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteInDetailLabel
            // 
            this.lblWasteInDetailLabel.AutoSize = true;
            this.lblWasteInDetailLabel.Location = new System.Drawing.Point(144, 200);
            this.lblWasteInDetailLabel.Name = "lblWasteInDetailLabel";
            this.lblWasteInDetailLabel.Size = new System.Drawing.Size(73, 15);
            this.lblWasteInDetailLabel.TabIndex = 30;
            this.lblWasteInDetailLabel.Text = "Desperdicio";
            // 
            // lblStopNumberInDetailLabel
            // 
            this.lblStopNumberInDetailLabel.AutoSize = true;
            this.lblStopNumberInDetailLabel.Location = new System.Drawing.Point(144, 174);
            this.lblStopNumberInDetailLabel.Name = "lblStopNumberInDetailLabel";
            this.lblStopNumberInDetailLabel.Size = new System.Drawing.Size(95, 15);
            this.lblStopNumberInDetailLabel.TabIndex = 31;
            this.lblStopNumberInDetailLabel.Text = "Nro. de paradas";
            // 
            // lblCoilNumber
            // 
            this.lblCoilNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblCoilNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoilNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilNumber.Location = new System.Drawing.Point(429, 197);
            this.lblCoilNumber.Name = "lblCoilNumber";
            this.lblCoilNumber.Size = new System.Drawing.Size(70, 21);
            this.lblCoilNumber.TabIndex = 25;
            this.lblCoilNumber.Tag = "clearOnReload";
            this.lblCoilNumber.Text = "0";
            this.lblCoilNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedWidthInDetail
            // 
            this.lblUsedWidthInDetail.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedWidthInDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedWidthInDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedWidthInDetail.Location = new System.Drawing.Point(429, 171);
            this.lblUsedWidthInDetail.Name = "lblUsedWidthInDetail";
            this.lblUsedWidthInDetail.Size = new System.Drawing.Size(70, 21);
            this.lblUsedWidthInDetail.TabIndex = 26;
            this.lblUsedWidthInDetail.Tag = "clearOnReload";
            this.lblUsedWidthInDetail.Text = "0";
            this.lblUsedWidthInDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCoilNumberLabel
            // 
            this.lblCoilNumberLabel.AutoSize = true;
            this.lblCoilNumberLabel.Location = new System.Drawing.Point(310, 200);
            this.lblCoilNumberLabel.Name = "lblCoilNumberLabel";
            this.lblCoilNumberLabel.Size = new System.Drawing.Size(116, 15);
            this.lblCoilNumberLabel.TabIndex = 21;
            this.lblCoilNumberLabel.Text = "Número de bobinas";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(34, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Cortadora";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsedWidthInDetailLabel
            // 
            this.lblUsedWidthInDetailLabel.AutoSize = true;
            this.lblUsedWidthInDetailLabel.Location = new System.Drawing.Point(310, 174);
            this.lblUsedWidthInDetailLabel.Name = "lblUsedWidthInDetailLabel";
            this.lblUsedWidthInDetailLabel.Size = new System.Drawing.Size(92, 15);
            this.lblUsedWidthInDetailLabel.TabIndex = 22;
            this.lblUsedWidthInDetailLabel.Text = "Ancho Utilizado";
            // 
            // lblCutterNameLabel
            // 
            this.lblCutterNameLabel.AutoSize = true;
            this.lblCutterNameLabel.Location = new System.Drawing.Point(549, 20);
            this.lblCutterNameLabel.Name = "lblCutterNameLabel";
            this.lblCutterNameLabel.Size = new System.Drawing.Size(61, 15);
            this.lblCutterNameLabel.TabIndex = 12;
            this.lblCutterNameLabel.Text = "Cortadora";
            // 
            // lblNotesLabel
            // 
            this.lblNotesLabel.AutoSize = true;
            this.lblNotesLabel.Location = new System.Drawing.Point(517, 173);
            this.lblNotesLabel.Name = "lblNotesLabel";
            this.lblNotesLabel.Size = new System.Drawing.Size(39, 15);
            this.lblNotesLabel.TabIndex = 12;
            this.lblNotesLabel.Text = "Notas";
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(562, 170);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(399, 48);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmNameLabel
            // 
            this.lblFilmNameLabel.AutoSize = true;
            this.lblFilmNameLabel.Location = new System.Drawing.Point(268, 20);
            this.lblFilmNameLabel.Name = "lblFilmNameLabel";
            this.lblFilmNameLabel.Size = new System.Drawing.Size(51, 15);
            this.lblFilmNameLabel.TabIndex = 12;
            this.lblFilmNameLabel.Text = "Película";
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(616, 17);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(200, 21);
            this.lblCutterName.TabIndex = 3;
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmNameInDetail
            // 
            this.lblFilmNameInDetail.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmNameInDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmNameInDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmNameInDetail.Location = new System.Drawing.Point(335, 17);
            this.lblFilmNameInDetail.Name = "lblFilmNameInDetail";
            this.lblFilmNameInDetail.Size = new System.Drawing.Size(200, 21);
            this.lblFilmNameInDetail.TabIndex = 3;
            this.lblFilmNameInDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbCombination
            // 
            this.grpbCombination.Controls.Add(this.lblWaste1);
            this.grpbCombination.Controls.Add(this.lblWaste2);
            this.grpbCombination.Location = new System.Drawing.Point(3, 50);
            this.grpbCombination.Name = "grpbCombination";
            this.grpbCombination.Size = new System.Drawing.Size(1070, 115);
            this.grpbCombination.TabIndex = 0;
            this.grpbCombination.TabStop = false;
            this.grpbCombination.Text = "Combinación";
            // 
            // lblWaste1
            // 
            this.lblWaste1.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste1.Location = new System.Drawing.Point(16, 21);
            this.lblWaste1.Name = "lblWaste1";
            this.lblWaste1.Size = new System.Drawing.Size(20, 66);
            this.lblWaste1.TabIndex = 1;
            this.lblWaste1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaste2
            // 
            this.lblWaste2.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste2.Location = new System.Drawing.Point(942, 21);
            this.lblWaste2.Name = "lblWaste2";
            this.lblWaste2.Size = new System.Drawing.Size(20, 66);
            this.lblWaste2.TabIndex = 2;
            this.lblWaste2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudStopsNumber
            // 
            this.nudStopsNumber.Location = new System.Drawing.Point(242, 171);
            this.nudStopsNumber.Name = "nudStopsNumber";
            this.nudStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.nudStopsNumber.TabIndex = 11;
            this.nudStopsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(616, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 42;
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvCuttingOrder);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(3, 3);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(1070, 334);
            this.grpbList.TabIndex = 2;
            this.grpbList.TabStop = false;
            this.grpbList.Text = "Listado de ordenes";
            // 
            // dgvCuttingOrder
            // 
            this.dgvCuttingOrder.AllowUserToAddRows = false;
            this.dgvCuttingOrder.AllowUserToDeleteRows = false;
            this.dgvCuttingOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.clmStatus,
            this.clmOrderNumber,
            this.clmMachineName,
            this.clmFilmName,
            this.clmPositions,
            this.clmRepetitions,
            this.clmProgrammedWeigth,
            this.clmCreatedDate});
            this.dgvCuttingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuttingOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvCuttingOrder.Name = "dgvCuttingOrder";
            this.dgvCuttingOrder.ReadOnly = true;
            this.dgvCuttingOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuttingOrder.Size = new System.Drawing.Size(1064, 314);
            this.dgvCuttingOrder.TabIndex = 0;
            this.dgvCuttingOrder.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCuttingOrder_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 50;
            // 
            // clmOrderNumber
            // 
            this.clmOrderNumber.HeaderText = "Número";
            this.clmOrderNumber.Name = "clmOrderNumber";
            this.clmOrderNumber.ReadOnly = true;
            this.clmOrderNumber.Width = 60;
            // 
            // clmMachineName
            // 
            this.clmMachineName.HeaderText = "Máquina";
            this.clmMachineName.Name = "clmMachineName";
            this.clmMachineName.ReadOnly = true;
            this.clmMachineName.Width = 150;
            // 
            // clmFilmName
            // 
            this.clmFilmName.HeaderText = "Película";
            this.clmFilmName.Name = "clmFilmName";
            this.clmFilmName.ReadOnly = true;
            this.clmFilmName.Width = 150;
            // 
            // clmPositions
            // 
            this.clmPositions.HeaderText = "Posiciones";
            this.clmPositions.Name = "clmPositions";
            this.clmPositions.ReadOnly = true;
            this.clmPositions.Width = 270;
            // 
            // clmRepetitions
            // 
            this.clmRepetitions.HeaderText = "Repeticiones";
            this.clmRepetitions.Name = "clmRepetitions";
            this.clmRepetitions.ReadOnly = true;
            // 
            // clmProgrammedWeigth
            // 
            this.clmProgrammedWeigth.HeaderText = "Peso";
            this.clmProgrammedWeigth.Name = "clmProgrammedWeigth";
            this.clmProgrammedWeigth.ReadOnly = true;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.HeaderText = "Creado";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.ReadOnly = true;
            this.clmCreatedDate.Width = 140;
            // 
            // frmCuttingOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1084, 630);
            this.Controls.Add(this.tbcCuttingOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrder";
            this.Text = "Ordenes de corte";
            this.Load += new System.EventHandler(this.frmCuttingOrder_Load);
            this.tbcCuttingOrder.ResumeLayout(false);
            this.tbpFilmSelection.ResumeLayout(false);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilterActions.ResumeLayout(false);
            this.grpbThicknessFilmTab.ResumeLayout(false);
            this.grpbThicknessFilmTab.PerformLayout();
            this.grpbAdditivationsFilmTab.ResumeLayout(false);
            this.grpbAdditivationsFilmTab.PerformLayout();
            this.grpbSealsFilmTab.ResumeLayout(false);
            this.grpbSealsFilmTab.PerformLayout();
            this.grpbFamiliesFilmTab.ResumeLayout(false);
            this.grpbFamiliesFilmTab.PerformLayout();
            this.grpbFilms.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBopp)).EndInit();
            this.tbpCuttingPlan.ResumeLayout(false);
            this.tbpCuttingPlan.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWasteAllowed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStops)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.grpbStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.grpbSalesOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderDetail)).EndInit();
            this.grpbCutterMachine.ResumeLayout(false);
            this.grpbCutterMachine.PerformLayout();
            this.grpbFilmNameSalesOrderTab.ResumeLayout(false);
            this.tbpResume.ResumeLayout(false);
            this.grpbCuttingOrderDetail.ResumeLayout(false);
            this.grpbCuttingOrderDetail.PerformLayout();
            this.grpbCombination.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudStopsNumber)).EndInit();
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCuttingOrder;
        private System.Windows.Forms.TabPage tbpFilmSelection;
        private System.Windows.Forms.TabPage tbpCuttingPlan;
        private System.Windows.Forms.TabPage tbpResume;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbThicknessFilmTab;
        private System.Windows.Forms.Label lblThickness;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.ComboBox cmbTreatment;
        private System.Windows.Forms.ComboBox cmbThikness;
        private System.Windows.Forms.GroupBox grpbAdditivationsFilmTab;
        private System.Windows.Forms.Label lblCentralAdditivation;
        private System.Windows.Forms.ComboBox cmbCentralAdditivation;
        private System.Windows.Forms.Label lblSurfaceAdditivation;
        private System.Windows.Forms.ComboBox cmbSurfaceAdditivation;
        private System.Windows.Forms.GroupBox grpbSealsFilmTab;
        private System.Windows.Forms.ComboBox cmbOuterSeal;
        private System.Windows.Forms.Label lblInnerSeal;
        private System.Windows.Forms.ComboBox cmbInnerSeal;
        private System.Windows.Forms.Label lblOuterSeal;
        private System.Windows.Forms.GroupBox grpbFamiliesFilmTab;
        private System.Windows.Forms.Label lblSubFamily;
        private System.Windows.Forms.Label lblFamily;
        private System.Windows.Forms.ComboBox cmbFamily;
        private System.Windows.Forms.ComboBox cmbSubFamily;
        private System.Windows.Forms.GroupBox grpbFilmNameSalesOrderTab;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.GroupBox grpbFilms;
        private System.Windows.Forms.DataGridView dgvBopp;
        private System.Windows.Forms.GroupBox grpbCutterMachine;
        private System.Windows.Forms.Label lblArms;
        private System.Windows.Forms.Label lblUtilWidth;
        private System.Windows.Forms.Label lblArmsLabel;
        private System.Windows.Forms.Label lblUtilWidthLabel;
        private System.Windows.Forms.Label lblCutter;
        private System.Windows.Forms.ComboBox cmbCutter;
        private System.Windows.Forms.GroupBox grpbStock;
        private System.Windows.Forms.GroupBox grpbSalesOrders;
        private System.Windows.Forms.DataGridView dgvSalesOrderDetail;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.Label lblUnusedWidthLabel;
        private System.Windows.Forms.Label lblUsedArmsLabel;
        private System.Windows.Forms.Label lblUsedWidthLabel;
        private System.Windows.Forms.Label lblViableCombinationLabel;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label lblUsedWidth;
        private System.Windows.Forms.Label lblViableCombination;
        private System.Windows.Forms.Label lblUnusedWidth;
        private System.Windows.Forms.Label lblUsedArms;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.NumericUpDown nudStops;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NumericUpDown nudWasteAllowed;
        private System.Windows.Forms.Label lblWaste;
        private System.Windows.Forms.Label lblWasteAllowed;
        private System.Windows.Forms.Label lblWasteLabel;
        private System.Windows.Forms.Label lblPercentage2;
        private System.Windows.Forms.Label lblPercentage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeightFilms;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockCoilQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockDiameterCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockCoilsToCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockTotalCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockProgrammedWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockSlopeWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockBoppCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockDiameterCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStockCoreCodsec;
        private System.Windows.Forms.Button btnFilterSalesOrder;
        private System.Windows.Forms.Button btnClearFilterSalesOrder;
        private System.Windows.Forms.TextBox txtUtilWidth;
        private System.Windows.Forms.ToolTip ttpCuttingOrder;
        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvCuttingOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewImageColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRepetitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProgrammedWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.CheckBox chkAllowEquivalentFilm;
        private System.Windows.Forms.CheckBox chkLoadEquivalentFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderProduct;
        private System.Windows.Forms.DataGridViewImageColumn clmSalesOrderChangeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderTotalOrderCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCoilsQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCoreDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderCoilsToCut;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderTotalCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderProgrammedWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderSlopeWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderOriginalProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderTotalSlope;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderIsEquivalentFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderDetailIndex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddNewBopp;
        private System.Windows.Forms.Button btnRefreshBopp;
        private System.Windows.Forms.TextBox txtBoppName;
        private System.Windows.Forms.Label lblBoppName;
        private System.Windows.Forms.TextBox txtBoppCode;
        private System.Windows.Forms.Label lblBoppCode;
        public System.Windows.Forms.GroupBox grpbCuttingOrderDetail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnChangeCutter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSeparatorInDetail;
        private System.Windows.Forms.Label lblStatusImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblStopsNumber;
        private System.Windows.Forms.Label lblWasteInDetail;
        private System.Windows.Forms.Label lblWasteInDetailLabel;
        private System.Windows.Forms.Label lblStopNumberInDetailLabel;
        private System.Windows.Forms.Label lblCoilNumber;
        private System.Windows.Forms.Label lblUsedWidthInDetail;
        private System.Windows.Forms.Label lblCoilNumberLabel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUsedWidthInDetailLabel;
        private System.Windows.Forms.Label lblCutterNameLabel;
        private System.Windows.Forms.Label lblNotesLabel;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblFilmNameLabel;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.Label lblFilmNameInDetail;
        private System.Windows.Forms.GroupBox grpbCombination;
        private System.Windows.Forms.Label lblWaste1;
        private System.Windows.Forms.Label lblWaste2;
        private System.Windows.Forms.NumericUpDown nudStopsNumber;
    }
}