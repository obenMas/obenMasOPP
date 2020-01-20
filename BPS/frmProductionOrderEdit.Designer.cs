namespace BPS
{
    partial class frmProductionOrderEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionOrderEdit));
            this.tbcWizard = new System.Windows.Forms.TabControl();
            this.tbpSalesOrder = new System.Windows.Forms.TabPage();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsecSOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightFullfilledDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightSlopeDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbTotalsSalesOrderTab = new System.Windows.Forms.GroupBox();
            this.lblSalesOrderTotalSO = new System.Windows.Forms.Label();
            this.lblTotalWeihtSalesOrder = new System.Windows.Forms.Label();
            this.dgvSalesOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsecSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSelectSalesOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeigthSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPlanifiedWeigthSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightFulfilledSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightSlopeSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsPlanned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActionsSO = new System.Windows.Forms.GroupBox();
            this.btnNextSalesOrderTab = new System.Windows.Forms.Button();
            this.btnBackSalesOrderTab = new System.Windows.Forms.Button();
            this.chkSelectAllSalesOrder = new System.Windows.Forms.CheckBox();
            this.grpbFilmNameSalesOrderTab = new System.Windows.Forms.GroupBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.tbpFinalOrder = new System.Windows.Forms.TabPage();
            this.grpbQuantities = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
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
            this.grpbSalesOrders = new System.Windows.Forms.GroupBox();
            this.dgvSelectedSalesOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsecPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDatePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumberPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerNamePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeightPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPlanifiedWeightPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightFullfilledPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeightSlopePO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilm = new System.Windows.Forms.GroupBox();
            this.lblFilmNamePO = new System.Windows.Forms.Label();
            this.grpbActionsPO = new System.Windows.Forms.GroupBox();
            this.btnBackProductionOrderTab = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbSearch2 = new System.Windows.Forms.GroupBox();
            this.ttpProductionOrderEdit = new System.Windows.Forms.ToolTip(this.components);
            this.tbcWizard.SuspendLayout();
            this.tbpSalesOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbTotalsSalesOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.grpbActionsSO.SuspendLayout();
            this.grpbFilmNameSalesOrderTab.SuspendLayout();
            this.tbpFinalOrder.SuspendLayout();
            this.grpbQuantities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPercentage)).BeginInit();
            this.grpbSalesOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSalesOrder)).BeginInit();
            this.grpbFilm.SuspendLayout();
            this.grpbActionsPO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcWizard
            // 
            this.tbcWizard.Controls.Add(this.tbpSalesOrder);
            this.tbcWizard.Controls.Add(this.tbpFinalOrder);
            this.tbcWizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcWizard.Location = new System.Drawing.Point(0, 0);
            this.tbcWizard.Name = "tbcWizard";
            this.tbcWizard.SelectedIndex = 0;
            this.tbcWizard.Size = new System.Drawing.Size(902, 464);
            this.tbcWizard.TabIndex = 0;
            // 
            // tbpSalesOrder
            // 
            this.tbpSalesOrder.BackColor = System.Drawing.SystemColors.Window;
            this.tbpSalesOrder.Controls.Add(this.dgvDetail);
            this.tbpSalesOrder.Controls.Add(this.grpbTotalsSalesOrderTab);
            this.tbpSalesOrder.Controls.Add(this.dgvSalesOrder);
            this.tbpSalesOrder.Controls.Add(this.grpbActionsSO);
            this.tbpSalesOrder.Controls.Add(this.chkSelectAllSalesOrder);
            this.tbpSalesOrder.Controls.Add(this.grpbFilmNameSalesOrderTab);
            this.tbpSalesOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpSalesOrder.Name = "tbpSalesOrder";
            this.tbpSalesOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalesOrder.Size = new System.Drawing.Size(894, 436);
            this.tbpSalesOrder.TabIndex = 1;
            this.tbpSalesOrder.Text = "Ordenes de Venta";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecSOD,
            this.clmProductCode,
            this.clmProductName,
            this.clmQuantity,
            this.clmWeightFullfilledDetail,
            this.clmWeightSlopeDetail});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetail.Location = new System.Drawing.Point(3, 238);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(888, 155);
            this.dgvDetail.TabIndex = 2;
            // 
            // clmCodsecSOD
            // 
            dataGridViewCellStyle2.NullValue = "0";
            this.clmCodsecSOD.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCodsecSOD.HeaderText = "codsec";
            this.clmCodsecSOD.Name = "clmCodsecSOD";
            this.clmCodsecSOD.ReadOnly = true;
            this.clmCodsecSOD.Visible = false;
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
            this.clmProductName.Width = 320;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQuantity.Width = 110;
            // 
            // clmWeightFullfilledDetail
            // 
            this.clmWeightFullfilledDetail.HeaderText = "Cumplido";
            this.clmWeightFullfilledDetail.Name = "clmWeightFullfilledDetail";
            this.clmWeightFullfilledDetail.ReadOnly = true;
            this.clmWeightFullfilledDetail.Width = 110;
            // 
            // clmWeightSlopeDetail
            // 
            this.clmWeightSlopeDetail.HeaderText = "Pendiente";
            this.clmWeightSlopeDetail.Name = "clmWeightSlopeDetail";
            this.clmWeightSlopeDetail.ReadOnly = true;
            this.clmWeightSlopeDetail.Width = 110;
            // 
            // grpbTotalsSalesOrderTab
            // 
            this.grpbTotalsSalesOrderTab.Controls.Add(this.lblSalesOrderTotalSO);
            this.grpbTotalsSalesOrderTab.Controls.Add(this.lblTotalWeihtSalesOrder);
            this.grpbTotalsSalesOrderTab.Location = new System.Drawing.Point(1, 390);
            this.grpbTotalsSalesOrderTab.Name = "grpbTotalsSalesOrderTab";
            this.grpbTotalsSalesOrderTab.Size = new System.Drawing.Size(834, 43);
            this.grpbTotalsSalesOrderTab.TabIndex = 8;
            this.grpbTotalsSalesOrderTab.TabStop = false;
            // 
            // lblSalesOrderTotalSO
            // 
            this.lblSalesOrderTotalSO.BackColor = System.Drawing.SystemColors.Window;
            this.lblSalesOrderTotalSO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesOrderTotalSO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderTotalSO.Location = new System.Drawing.Point(414, 14);
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
            this.lblTotalWeihtSalesOrder.Location = new System.Drawing.Point(308, 14);
            this.lblTotalWeihtSalesOrder.Name = "lblTotalWeihtSalesOrder";
            this.lblTotalWeihtSalesOrder.Size = new System.Drawing.Size(84, 20);
            this.lblTotalWeihtSalesOrder.TabIndex = 0;
            this.lblTotalWeihtSalesOrder.Text = "Peso Total";
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
            this.clmTotalPlanifiedWeigthSalesOrder,
            this.clmWeightFulfilledSalesOrder,
            this.clmWeightSlopeSalesOrder,
            this.clmIsPlanned});
            this.dgvSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvSalesOrder.Location = new System.Drawing.Point(3, 65);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrder.Size = new System.Drawing.Size(888, 173);
            this.dgvSalesOrder.TabIndex = 1;
            this.dgvSalesOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrder_CellClick);
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
            this.clmCustomer.Width = 220;
            // 
            // clmTotalWeigthSalesOrder
            // 
            this.clmTotalWeigthSalesOrder.HeaderText = "Peso Total";
            this.clmTotalWeigthSalesOrder.Name = "clmTotalWeigthSalesOrder";
            // 
            // clmTotalPlanifiedWeigthSalesOrder
            // 
            this.clmTotalPlanifiedWeigthSalesOrder.HeaderText = "Planificar";
            this.clmTotalPlanifiedWeigthSalesOrder.Name = "clmTotalPlanifiedWeigthSalesOrder";
            // 
            // clmWeightFulfilledSalesOrder
            // 
            this.clmWeightFulfilledSalesOrder.HeaderText = "Cumplido";
            this.clmWeightFulfilledSalesOrder.Name = "clmWeightFulfilledSalesOrder";
            // 
            // clmWeightSlopeSalesOrder
            // 
            this.clmWeightSlopeSalesOrder.HeaderText = "Pendiente";
            this.clmWeightSlopeSalesOrder.Name = "clmWeightSlopeSalesOrder";
            // 
            // clmIsPlanned
            // 
            this.clmIsPlanned.HeaderText = "Planificado";
            this.clmIsPlanned.Name = "clmIsPlanned";
            this.clmIsPlanned.Visible = false;
            // 
            // grpbActionsSO
            // 
            this.grpbActionsSO.Controls.Add(this.btnNextSalesOrderTab);
            this.grpbActionsSO.Controls.Add(this.btnBackSalesOrderTab);
            this.grpbActionsSO.Location = new System.Drawing.Point(837, 390);
            this.grpbActionsSO.Name = "grpbActionsSO";
            this.grpbActionsSO.Size = new System.Drawing.Size(61, 43);
            this.grpbActionsSO.TabIndex = 11;
            this.grpbActionsSO.TabStop = false;
            // 
            // btnNextSalesOrderTab
            // 
            this.btnNextSalesOrderTab.BackgroundImage = global::BPS.Properties.Resources.arrow_right;
            this.btnNextSalesOrderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextSalesOrderTab.Location = new System.Drawing.Point(31, 13);
            this.btnNextSalesOrderTab.Name = "btnNextSalesOrderTab";
            this.btnNextSalesOrderTab.Size = new System.Drawing.Size(25, 25);
            this.btnNextSalesOrderTab.TabIndex = 1;
            this.ttpProductionOrderEdit.SetToolTip(this.btnNextSalesOrderTab, "Orden de Producción");
            this.btnNextSalesOrderTab.UseVisualStyleBackColor = true;
            this.btnNextSalesOrderTab.Click += new System.EventHandler(this.btnNextSalesOrderTab_Click);
            // 
            // btnBackSalesOrderTab
            // 
            this.btnBackSalesOrderTab.BackgroundImage = global::BPS.Properties.Resources.arrow_left;
            this.btnBackSalesOrderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackSalesOrderTab.Location = new System.Drawing.Point(6, 13);
            this.btnBackSalesOrderTab.Name = "btnBackSalesOrderTab";
            this.btnBackSalesOrderTab.Size = new System.Drawing.Size(25, 25);
            this.btnBackSalesOrderTab.TabIndex = 0;
            this.ttpProductionOrderEdit.SetToolTip(this.btnBackSalesOrderTab, "Atras");
            this.btnBackSalesOrderTab.UseVisualStyleBackColor = true;
            this.btnBackSalesOrderTab.Click += new System.EventHandler(this.btnBackSalesOrderTab_Click);
            // 
            // chkSelectAllSalesOrder
            // 
            this.chkSelectAllSalesOrder.AutoSize = true;
            this.chkSelectAllSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkSelectAllSalesOrder.Location = new System.Drawing.Point(3, 46);
            this.chkSelectAllSalesOrder.Name = "chkSelectAllSalesOrder";
            this.chkSelectAllSalesOrder.Size = new System.Drawing.Size(888, 19);
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
            this.grpbFilmNameSalesOrderTab.Size = new System.Drawing.Size(888, 43);
            this.grpbFilmNameSalesOrderTab.TabIndex = 10;
            this.grpbFilmNameSalesOrderTab.TabStop = false;
            // 
            // lblFilmName
            // 
            this.lblFilmName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(3, 17);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(882, 23);
            this.lblFilmName.TabIndex = 2;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbpFinalOrder
            // 
            this.tbpFinalOrder.BackColor = System.Drawing.SystemColors.Window;
            this.tbpFinalOrder.Controls.Add(this.grpbQuantities);
            this.tbpFinalOrder.Controls.Add(this.grpbSalesOrders);
            this.tbpFinalOrder.Controls.Add(this.grpbFilm);
            this.tbpFinalOrder.Controls.Add(this.grpbActionsPO);
            this.tbpFinalOrder.Controls.Add(this.grpbSearch2);
            this.tbpFinalOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpFinalOrder.Name = "tbpFinalOrder";
            this.tbpFinalOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFinalOrder.Size = new System.Drawing.Size(894, 436);
            this.tbpFinalOrder.TabIndex = 2;
            this.tbpFinalOrder.Text = "Orden de Producción";
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
            this.grpbQuantities.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbQuantities.Location = new System.Drawing.Point(3, 294);
            this.grpbQuantities.Name = "grpbQuantities";
            this.grpbQuantities.Size = new System.Drawing.Size(888, 100);
            this.grpbQuantities.TabIndex = 14;
            this.grpbQuantities.TabStop = false;
            this.grpbQuantities.Text = "Cantidades";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(655, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 26);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Tag = "numericClearOnReload";
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalToExtrude
            // 
            this.lblTotalToExtrude.AutoSize = true;
            this.lblTotalToExtrude.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalToExtrude.Location = new System.Drawing.Point(659, 33);
            this.lblTotalToExtrude.Name = "lblTotalToExtrude";
            this.lblTotalToExtrude.Size = new System.Drawing.Size(104, 20);
            this.lblTotalToExtrude.TabIndex = 8;
            this.lblTotalToExtrude.Text = "Total a extruir";
            // 
            // nudExtraPercentage
            // 
            this.nudExtraPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExtraPercentage.Location = new System.Drawing.Point(463, 57);
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
            this.lblEqual.Location = new System.Drawing.Point(611, 57);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(24, 25);
            this.lblEqual.TabIndex = 6;
            this.lblEqual.Text = "=";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(572, 59);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(23, 20);
            this.lblPercentage.TabIndex = 6;
            this.lblPercentage.Text = "%";
            // 
            // lblPlus2
            // 
            this.lblPlus2.AutoSize = true;
            this.lblPlus2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus2.Location = new System.Drawing.Point(424, 55);
            this.lblPlus2.Name = "lblPlus2";
            this.lblPlus2.Size = new System.Drawing.Size(24, 25);
            this.lblPlus2.TabIndex = 6;
            this.lblPlus2.Text = "+";
            // 
            // lblPlus1
            // 
            this.lblPlus1.AutoSize = true;
            this.lblPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus1.Location = new System.Drawing.Point(258, 55);
            this.lblPlus1.Name = "lblPlus1";
            this.lblPlus1.Size = new System.Drawing.Size(24, 25);
            this.lblPlus1.TabIndex = 6;
            this.lblPlus1.Text = "+";
            // 
            // txtInnerProduction
            // 
            this.txtInnerProduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInnerProduction.Location = new System.Drawing.Point(297, 56);
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
            this.lblExtraPercentage.Location = new System.Drawing.Point(456, 32);
            this.lblExtraPercentage.Name = "lblExtraPercentage";
            this.lblExtraPercentage.Size = new System.Drawing.Size(126, 20);
            this.lblExtraPercentage.TabIndex = 4;
            this.lblExtraPercentage.Text = "Porcentaje Extra";
            // 
            // lblInnerProgramed
            // 
            this.lblInnerProgramed.AutoSize = true;
            this.lblInnerProgramed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInnerProgramed.Location = new System.Drawing.Point(273, 32);
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
            this.lblSalesOrderTotalValue.Location = new System.Drawing.Point(131, 56);
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
            this.lblSalesOrderTotal.Location = new System.Drawing.Point(121, 32);
            this.lblSalesOrderTotal.Name = "lblSalesOrderTotal";
            this.lblSalesOrderTotal.Size = new System.Drawing.Size(133, 20);
            this.lblSalesOrderTotal.TabIndex = 2;
            this.lblSalesOrderTotal.Text = "Total O. de Venta";
            // 
            // grpbSalesOrders
            // 
            this.grpbSalesOrders.Controls.Add(this.dgvSelectedSalesOrder);
            this.grpbSalesOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrders.Location = new System.Drawing.Point(3, 54);
            this.grpbSalesOrders.Name = "grpbSalesOrders";
            this.grpbSalesOrders.Size = new System.Drawing.Size(888, 240);
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
            this.clmTotalPlanifiedWeightPO,
            this.clmWeightFullfilledPO,
            this.clmWeightSlopePO});
            this.dgvSelectedSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelectedSalesOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvSelectedSalesOrder.Name = "dgvSelectedSalesOrder";
            this.dgvSelectedSalesOrder.ReadOnly = true;
            this.dgvSelectedSalesOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedSalesOrder.Size = new System.Drawing.Size(882, 220);
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
            this.clmCustomerNamePO.Width = 245;
            // 
            // clmTotalWeightPO
            // 
            this.clmTotalWeightPO.HeaderText = "Peso Total";
            this.clmTotalWeightPO.Name = "clmTotalWeightPO";
            this.clmTotalWeightPO.ReadOnly = true;
            // 
            // clmTotalPlanifiedWeightPO
            // 
            this.clmTotalPlanifiedWeightPO.HeaderText = "Planificado";
            this.clmTotalPlanifiedWeightPO.Name = "clmTotalPlanifiedWeightPO";
            this.clmTotalPlanifiedWeightPO.ReadOnly = true;
            // 
            // clmWeightFullfilledPO
            // 
            this.clmWeightFullfilledPO.HeaderText = "Cumplido";
            this.clmWeightFullfilledPO.Name = "clmWeightFullfilledPO";
            this.clmWeightFullfilledPO.ReadOnly = true;
            // 
            // clmWeightSlopePO
            // 
            this.clmWeightSlopePO.HeaderText = "Pendiente";
            this.clmWeightSlopePO.Name = "clmWeightSlopePO";
            this.clmWeightSlopePO.ReadOnly = true;
            // 
            // grpbFilm
            // 
            this.grpbFilm.Controls.Add(this.lblFilmNamePO);
            this.grpbFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilm.Location = new System.Drawing.Point(3, 3);
            this.grpbFilm.Name = "grpbFilm";
            this.grpbFilm.Size = new System.Drawing.Size(888, 51);
            this.grpbFilm.TabIndex = 12;
            this.grpbFilm.TabStop = false;
            this.grpbFilm.Text = "Película";
            // 
            // lblFilmNamePO
            // 
            this.lblFilmNamePO.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFilmNamePO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmNamePO.Location = new System.Drawing.Point(3, 17);
            this.lblFilmNamePO.Name = "lblFilmNamePO";
            this.lblFilmNamePO.Size = new System.Drawing.Size(882, 23);
            this.lblFilmNamePO.TabIndex = 3;
            this.lblFilmNamePO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbActionsPO
            // 
            this.grpbActionsPO.Controls.Add(this.btnBackProductionOrderTab);
            this.grpbActionsPO.Controls.Add(this.btnSave);
            this.grpbActionsPO.Controls.Add(this.btnCancel);
            this.grpbActionsPO.Controls.Add(this.btnClose);
            this.grpbActionsPO.Location = new System.Drawing.Point(783, 390);
            this.grpbActionsPO.Name = "grpbActionsPO";
            this.grpbActionsPO.Size = new System.Drawing.Size(115, 43);
            this.grpbActionsPO.TabIndex = 11;
            this.grpbActionsPO.TabStop = false;
            // 
            // btnBackProductionOrderTab
            // 
            this.btnBackProductionOrderTab.BackgroundImage = global::BPS.Properties.Resources.arrow_left;
            this.btnBackProductionOrderTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackProductionOrderTab.Location = new System.Drawing.Point(7, 13);
            this.btnBackProductionOrderTab.Name = "btnBackProductionOrderTab";
            this.btnBackProductionOrderTab.Size = new System.Drawing.Size(25, 25);
            this.btnBackProductionOrderTab.TabIndex = 0;
            this.ttpProductionOrderEdit.SetToolTip(this.btnBackProductionOrderTab, "Ordenes de Venta");
            this.btnBackProductionOrderTab.UseVisualStyleBackColor = true;
            this.btnBackProductionOrderTab.Click += new System.EventHandler(this.btnBackProductionOrderTab_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(32, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 1;
            this.ttpProductionOrderEdit.SetToolTip(this.btnSave, "Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(57, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 2;
            this.ttpProductionOrderEdit.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(82, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpProductionOrderEdit.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbSearch2
            // 
            this.grpbSearch2.Location = new System.Drawing.Point(1, 390);
            this.grpbSearch2.Name = "grpbSearch2";
            this.grpbSearch2.Size = new System.Drawing.Size(776, 43);
            this.grpbSearch2.TabIndex = 10;
            this.grpbSearch2.TabStop = false;
            // 
            // frmProductionOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(902, 464);
            this.Controls.Add(this.tbcWizard);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionOrderEdit";
            this.Text = "Ordenes de Producción BOPP";
            this.Load += new System.EventHandler(this.frmProductionOrderEdit_Load);
            this.tbcWizard.ResumeLayout(false);
            this.tbpSalesOrder.ResumeLayout(false);
            this.tbpSalesOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbTotalsSalesOrderTab.ResumeLayout(false);
            this.grpbTotalsSalesOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.grpbActionsSO.ResumeLayout(false);
            this.grpbFilmNameSalesOrderTab.ResumeLayout(false);
            this.tbpFinalOrder.ResumeLayout(false);
            this.grpbQuantities.ResumeLayout(false);
            this.grpbQuantities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExtraPercentage)).EndInit();
            this.grpbSalesOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedSalesOrder)).EndInit();
            this.grpbFilm.ResumeLayout(false);
            this.grpbActionsPO.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcWizard;
        private System.Windows.Forms.TabPage tbpSalesOrder;
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
        private System.Windows.Forms.GroupBox grpbSearch2;
        private System.Windows.Forms.GroupBox grpbQuantities;
        private System.Windows.Forms.GroupBox grpbSalesOrders;
        private System.Windows.Forms.GroupBox grpbFilm;
        private System.Windows.Forms.Label lblFilmNamePO;
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalToExtrude;
        private System.Windows.Forms.NumericUpDown nudExtraPercentage;
        private System.Windows.Forms.GroupBox grpbActionsSO;
        private System.Windows.Forms.Button btnNextSalesOrderTab;
        private System.Windows.Forms.CheckBox chkSelectAllSalesOrder;
        private System.Windows.Forms.ToolTip ttpProductionOrderEdit;
        private System.Windows.Forms.Button btnBackSalesOrderTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecSOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightFullfilledDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightSlopeDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDatePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumberPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerNamePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeightPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPlanifiedWeightPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightFullfilledPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightSlopePO;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecSO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmSelectSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeigthSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPlanifiedWeigthSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightFulfilledSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeightSlopeSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIsPlanned;

    }
}