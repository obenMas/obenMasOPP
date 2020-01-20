namespace BPS
{
    partial class frmSalesOrderHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderHistory));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnDeleteFilter = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbNotes = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCustommer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbExecutive = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrderHistory = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompromiseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHourEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShippingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdayShipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmonthShipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmyearShipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchaseOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeliveredQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTdC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPendingMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExecutive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYearIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHourIng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.btnDeleteFilter);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.cmbNotes);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cmbCore);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbDiameter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbCustommer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbPlant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbExecutive);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(951, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "0 /";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(884, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Registros:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(988, 66);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(56, 20);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.Text = "100";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // btnDeleteFilter
            // 
            this.btnDeleteFilter.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnDeleteFilter.Location = new System.Drawing.Point(1064, 62);
            this.btnDeleteFilter.Name = "btnDeleteFilter";
            this.btnDeleteFilter.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteFilter.TabIndex = 25;
            this.btnDeleteFilter.UseVisualStyleBackColor = true;
            this.btnDeleteFilter.Click += new System.EventHandler(this.btnDeleteFilter_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(1064, 26);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 24;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbNotes
            // 
            this.cmbNotes.FormattingEnabled = true;
            this.cmbNotes.Location = new System.Drawing.Point(95, 66);
            this.cmbNotes.Name = "cmbNotes";
            this.cmbNotes.Size = new System.Drawing.Size(783, 21);
            this.cmbNotes.TabIndex = 23;
            this.cmbNotes.SelectedIndexChanged += new System.EventHandler(this.cmbNotes_SelectedIndexChanged);
            this.cmbNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNotes_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Observaciones:";
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(998, 29);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(46, 21);
            this.cmbCore.TabIndex = 16;
            this.cmbCore.SelectedIndexChanged += new System.EventHandler(this.cmbCore_SelectedIndexChanged);
            this.cmbCore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCore_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(966, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Core:";
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(916, 29);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(46, 21);
            this.cmbDiameter.TabIndex = 13;
            this.cmbDiameter.SelectedIndexChanged += new System.EventHandler(this.cmbDiameter_SelectedIndexChanged);
            this.cmbDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDiameter_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(882, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diam:";
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(829, 29);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(49, 21);
            this.cmbWidth.TabIndex = 11;
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_SelectedIndexChanged);
            this.cmbWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbWidth_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(788, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ancho:";
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(641, 28);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(146, 21);
            this.cmbFilm.TabIndex = 9;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pel.:";
            // 
            // cmbCustommer
            // 
            this.cmbCustommer.FormattingEnabled = true;
            this.cmbCustommer.Location = new System.Drawing.Point(393, 28);
            this.cmbCustommer.Name = "cmbCustommer";
            this.cmbCustommer.Size = new System.Drawing.Size(208, 21);
            this.cmbCustommer.TabIndex = 7;
            this.cmbCustommer.SelectedIndexChanged += new System.EventHandler(this.cmbCustommer_SelectedIndexChanged);
            this.cmbCustommer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustommer_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(290, 28);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(56, 21);
            this.cmbPlant.TabIndex = 5;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged);
            this.cmbPlant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPlant_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Planta:";
            // 
            // cmbExecutive
            // 
            this.cmbExecutive.FormattingEnabled = true;
            this.cmbExecutive.Location = new System.Drawing.Point(67, 28);
            this.cmbExecutive.Name = "cmbExecutive";
            this.cmbExecutive.Size = new System.Drawing.Size(74, 21);
            this.cmbExecutive.TabIndex = 3;
            this.cmbExecutive.SelectedIndexChanged += new System.EventHandler(this.cmbExecutive_SelectedIndexChanged);
            this.cmbExecutive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbExecutive_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ejecutiva:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(189, 28);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(55, 21);
            this.cmbOrder.TabIndex = 1;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSalesOrderHistory);
            this.groupBox2.Location = new System.Drawing.Point(4, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1113, 380);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvSalesOrderHistory
            // 
            this.dgvSalesOrderHistory.AllowUserToAddRows = false;
            this.dgvSalesOrderHistory.AllowUserToDeleteRows = false;
            this.dgvSalesOrderHistory.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvSalesOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPlant,
            this.clmCompromiseDate,
            this.clmDayEnt,
            this.clmMonthEnt,
            this.clmYearEnt,
            this.clmHourEnt,
            this.clmShippingDate,
            this.clmdayShipping,
            this.clmmonthShipping,
            this.clmyearShipping,
            this.clmCustomer,
            this.clmPurchaseOrder,
            this.clmFilm,
            this.clmWidth,
            this.clmDiameter,
            this.clmCore,
            this.clmQuantity,
            this.clmDeliveredQuantity,
            this.clmPrice,
            this.clmTdC,
            this.clmPendingMoney,
            this.clmObservations,
            this.clmStatus,
            this.clmExecutive,
            this.clmCreatedDate,
            this.clmDayIng,
            this.clmMonthIng,
            this.clmYearIng,
            this.clmHourIng});
            this.dgvSalesOrderHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrderHistory.Location = new System.Drawing.Point(3, 16);
            this.dgvSalesOrderHistory.Name = "dgvSalesOrderHistory";
            this.dgvSalesOrderHistory.ReadOnly = true;
            this.dgvSalesOrderHistory.Size = new System.Drawing.Size(1107, 361);
            this.dgvSalesOrderHistory.TabIndex = 0;
            this.dgvSalesOrderHistory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrderHistory_CellContentDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Pedido";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Width = 53;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.ReadOnly = true;
            this.clmPlant.Width = 70;
            // 
            // clmCompromiseDate
            // 
            this.clmCompromiseDate.HeaderText = "Fecha de Entrega";
            this.clmCompromiseDate.Name = "clmCompromiseDate";
            this.clmCompromiseDate.ReadOnly = true;
            this.clmCompromiseDate.Width = 70;
            // 
            // clmDayEnt
            // 
            this.clmDayEnt.HeaderText = "Dia de Entrega";
            this.clmDayEnt.Name = "clmDayEnt";
            this.clmDayEnt.ReadOnly = true;
            this.clmDayEnt.Visible = false;
            // 
            // clmMonthEnt
            // 
            this.clmMonthEnt.HeaderText = "Mes de Entrega";
            this.clmMonthEnt.Name = "clmMonthEnt";
            this.clmMonthEnt.ReadOnly = true;
            this.clmMonthEnt.Visible = false;
            // 
            // clmYearEnt
            // 
            this.clmYearEnt.HeaderText = "Año de Entrega";
            this.clmYearEnt.Name = "clmYearEnt";
            this.clmYearEnt.ReadOnly = true;
            this.clmYearEnt.Visible = false;
            // 
            // clmHourEnt
            // 
            this.clmHourEnt.HeaderText = "Hora de Entrega";
            this.clmHourEnt.Name = "clmHourEnt";
            this.clmHourEnt.ReadOnly = true;
            this.clmHourEnt.Visible = false;
            // 
            // clmShippingDate
            // 
            this.clmShippingDate.HeaderText = "Fecha de Despacho";
            this.clmShippingDate.Name = "clmShippingDate";
            this.clmShippingDate.ReadOnly = true;
            this.clmShippingDate.Width = 120;
            // 
            // clmdayShipping
            // 
            this.clmdayShipping.HeaderText = "Dia Despacho";
            this.clmdayShipping.Name = "clmdayShipping";
            this.clmdayShipping.ReadOnly = true;
            this.clmdayShipping.Visible = false;
            // 
            // clmmonthShipping
            // 
            this.clmmonthShipping.HeaderText = "Mes Despacho";
            this.clmmonthShipping.Name = "clmmonthShipping";
            this.clmmonthShipping.ReadOnly = true;
            this.clmmonthShipping.Visible = false;
            // 
            // clmyearShipping
            // 
            this.clmyearShipping.HeaderText = "Año Despacho";
            this.clmyearShipping.Name = "clmyearShipping";
            this.clmyearShipping.ReadOnly = true;
            this.clmyearShipping.Visible = false;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 140;
            // 
            // clmPurchaseOrder
            // 
            this.clmPurchaseOrder.HeaderText = "OC Cliente";
            this.clmPurchaseOrder.Name = "clmPurchaseOrder";
            this.clmPurchaseOrder.ReadOnly = true;
            this.clmPurchaseOrder.Width = 110;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pel.";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            this.clmFilm.Width = 80;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 47;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diam.";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 40;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 40;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Solicit. [Kg]";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 70;
            // 
            // clmDeliveredQuantity
            // 
            this.clmDeliveredQuantity.HeaderText = "Entregado [Kg]";
            this.clmDeliveredQuantity.Name = "clmDeliveredQuantity";
            this.clmDeliveredQuantity.ReadOnly = true;
            this.clmDeliveredQuantity.Width = 70;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio [USD]";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 50;
            // 
            // clmTdC
            // 
            this.clmTdC.HeaderText = "TdC";
            this.clmTdC.Name = "clmTdC";
            this.clmTdC.ReadOnly = true;
            this.clmTdC.Width = 40;
            // 
            // clmPendingMoney
            // 
            this.clmPendingMoney.HeaderText = "Total [$]";
            this.clmPendingMoney.Name = "clmPendingMoney";
            this.clmPendingMoney.ReadOnly = true;
            // 
            // clmObservations
            // 
            this.clmObservations.HeaderText = "Observaciones";
            this.clmObservations.Name = "clmObservations";
            this.clmObservations.ReadOnly = true;
            this.clmObservations.Width = 110;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 80;
            // 
            // clmExecutive
            // 
            this.clmExecutive.HeaderText = "Ejecutiva";
            this.clmExecutive.Name = "clmExecutive";
            this.clmExecutive.ReadOnly = true;
            this.clmExecutive.Visible = false;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.HeaderText = "Fecha de Ingreso";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.ReadOnly = true;
            this.clmCreatedDate.Visible = false;
            // 
            // clmDayIng
            // 
            this.clmDayIng.HeaderText = "Dia de Ingreso";
            this.clmDayIng.Name = "clmDayIng";
            this.clmDayIng.ReadOnly = true;
            this.clmDayIng.Visible = false;
            // 
            // clmMonthIng
            // 
            this.clmMonthIng.HeaderText = "Mes de Ingreso";
            this.clmMonthIng.Name = "clmMonthIng";
            this.clmMonthIng.ReadOnly = true;
            this.clmMonthIng.Visible = false;
            // 
            // clmYearIng
            // 
            this.clmYearIng.HeaderText = "Año de Ingreso";
            this.clmYearIng.Name = "clmYearIng";
            this.clmYearIng.ReadOnly = true;
            this.clmYearIng.Visible = false;
            // 
            // clmHourIng
            // 
            this.clmHourIng.HeaderText = "Hora de ingreso";
            this.clmHourIng.Name = "clmHourIng";
            this.clmHourIng.ReadOnly = true;
            this.clmHourIng.Visible = false;
            // 
            // frmSalesOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderHistory";
            this.Text = "Historial de Pedidos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSalesOrderHistory;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCustommer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbExecutive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbNotes;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDeleteFilter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompromiseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHourEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShippingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdayShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmonthShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmyearShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchaseOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeliveredQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTdC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPendingMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExecutive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearIng;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHourIng;
    }
}