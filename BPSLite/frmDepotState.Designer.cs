using BPS.Lite;
namespace BPS
{
    partial class frmDepotState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepotState));
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLotNumber = new System.Windows.Forms.ComboBox();
            this.cmbCellar = new System.Windows.Forms.ComboBox();
            this.cmbOrigin = new System.Windows.Forms.ComboBox();
            this.cmbCustommer = new System.Windows.Forms.ComboBox();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbPalletCode = new System.Windows.Forms.ComboBox();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDepotState = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkExportNotes = new System.Windows.Forms.CheckBox();
            this.btnCoilsDetail = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPalletQuantity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clmPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCuttingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDayCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFilters.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepotState)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.cmbQuality);
            this.gbFilters.Controls.Add(this.label12);
            this.gbFilters.Controls.Add(this.btnExport);
            this.gbFilters.Controls.Add(this.btnApplyFilter);
            this.gbFilters.Controls.Add(this.label11);
            this.gbFilters.Controls.Add(this.label10);
            this.gbFilters.Controls.Add(this.label9);
            this.gbFilters.Controls.Add(this.label8);
            this.gbFilters.Controls.Add(this.label7);
            this.gbFilters.Controls.Add(this.label6);
            this.gbFilters.Controls.Add(this.label5);
            this.gbFilters.Controls.Add(this.label4);
            this.gbFilters.Controls.Add(this.label3);
            this.gbFilters.Controls.Add(this.label2);
            this.gbFilters.Controls.Add(this.label1);
            this.gbFilters.Controls.Add(this.cmbLotNumber);
            this.gbFilters.Controls.Add(this.cmbCellar);
            this.gbFilters.Controls.Add(this.cmbOrigin);
            this.gbFilters.Controls.Add(this.cmbCustommer);
            this.gbFilters.Controls.Add(this.cmbOrder);
            this.gbFilters.Controls.Add(this.cmbCore);
            this.gbFilters.Controls.Add(this.cmbDiameter);
            this.gbFilters.Controls.Add(this.cmbWidth);
            this.gbFilters.Controls.Add(this.cmbFilm);
            this.gbFilters.Controls.Add(this.cmbPalletCode);
            this.gbFilters.Controls.Add(this.cmbPlant);
            this.gbFilters.Location = new System.Drawing.Point(2, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(1095, 83);
            this.gbFilters.TabIndex = 0;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filtros:";
            // 
            // cmbQuality
            // 
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(907, 18);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(138, 21);
            this.cmbQuality.TabIndex = 25;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            this.cmbQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbQuality_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(855, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Calidad:";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(1063, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 23;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Image = global::BPS.Lite.Properties.Resources.funnel_clear;
            this.btnApplyFilter.Location = new System.Drawing.Point(1063, 17);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(25, 25);
            this.btnApplyFilter.TabIndex = 22;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(871, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Lote:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Orden:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(686, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Bodega:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Core:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Diam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Ancho:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pallet:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Planta:";
            // 
            // cmbLotNumber
            // 
            this.cmbLotNumber.FormattingEnabled = true;
            this.cmbLotNumber.Location = new System.Drawing.Point(908, 57);
            this.cmbLotNumber.Name = "cmbLotNumber";
            this.cmbLotNumber.Size = new System.Drawing.Size(137, 21);
            this.cmbLotNumber.TabIndex = 10;
            this.cmbLotNumber.SelectedIndexChanged += new System.EventHandler(this.cmbLotNumber_SelectedIndexChanged);
            this.cmbLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLotNumber_KeyDown);
            // 
            // cmbCellar
            // 
            this.cmbCellar.FormattingEnabled = true;
            this.cmbCellar.Location = new System.Drawing.Point(739, 56);
            this.cmbCellar.Name = "cmbCellar";
            this.cmbCellar.Size = new System.Drawing.Size(121, 21);
            this.cmbCellar.TabIndex = 9;
            this.cmbCellar.SelectedIndexChanged += new System.EventHandler(this.cmbCellar_SelectedIndexChanged);
            this.cmbCellar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCellar_KeyDown);
            // 
            // cmbOrigin
            // 
            this.cmbOrigin.FormattingEnabled = true;
            this.cmbOrigin.Location = new System.Drawing.Point(56, 57);
            this.cmbOrigin.Name = "cmbOrigin";
            this.cmbOrigin.Size = new System.Drawing.Size(121, 21);
            this.cmbOrigin.TabIndex = 8;
            this.cmbOrigin.SelectedIndexChanged += new System.EventHandler(this.cmbOrigin_SelectedIndexChanged);
            this.cmbOrigin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrigin_KeyDown);
            // 
            // cmbCustommer
            // 
            this.cmbCustommer.FormattingEnabled = true;
            this.cmbCustommer.Location = new System.Drawing.Point(411, 57);
            this.cmbCustommer.Name = "cmbCustommer";
            this.cmbCustommer.Size = new System.Drawing.Size(263, 21);
            this.cmbCustommer.TabIndex = 7;
            this.cmbCustommer.SelectedIndexChanged += new System.EventHandler(this.cmbCustommer_SelectedIndexChanged);
            this.cmbCustommer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustommer_KeyDown);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(225, 55);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 6;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(791, 20);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(58, 21);
            this.cmbCore.TabIndex = 5;
            this.cmbCore.SelectedIndexChanged += new System.EventHandler(this.cmbCore_SelectedIndexChanged);
            this.cmbCore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCore_KeyDown);
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(689, 20);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(58, 21);
            this.cmbDiameter.TabIndex = 4;
            this.cmbDiameter.SelectedIndexChanged += new System.EventHandler(this.cmbDiameter_SelectedIndexChanged);
            this.cmbDiameter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDiameter_KeyDown);
            // 
            // cmbWidth
            // 
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Location = new System.Drawing.Point(585, 21);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(58, 21);
            this.cmbWidth.TabIndex = 3;
            this.cmbWidth.SelectedIndexChanged += new System.EventHandler(this.cmbWidth_SelectedIndexChanged);
            this.cmbWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbWidth_KeyDown);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(410, 20);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(121, 21);
            this.cmbFilm.TabIndex = 2;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // cmbPalletCode
            // 
            this.cmbPalletCode.FormattingEnabled = true;
            this.cmbPalletCode.Location = new System.Drawing.Point(225, 20);
            this.cmbPalletCode.Name = "cmbPalletCode";
            this.cmbPalletCode.Size = new System.Drawing.Size(121, 21);
            this.cmbPalletCode.TabIndex = 1;
            this.cmbPalletCode.SelectedIndexChanged += new System.EventHandler(this.cmbPalletCode_SelectedIndexChanged);
            this.cmbPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPalletCode_KeyDown);
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(56, 20);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(121, 21);
            this.cmbPlant.TabIndex = 0;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged);
            this.cmbPlant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPlant_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDepotState);
            this.groupBox2.Location = new System.Drawing.Point(2, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1095, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvDepotState
            // 
            this.dgvDepotState.AllowUserToAddRows = false;
            this.dgvDepotState.AllowUserToDeleteRows = false;
            this.dgvDepotState.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDepotState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepotState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletCodsec,
            this.clmPlant,
            this.clmCode,
            this.clmFilm,
            this.clmWidth,
            this.clmDiameter,
            this.clmCore,
            this.clmNetWeight,
            this.clmGrossWeight,
            this.clmOrigin,
            this.clmSalesOrder,
            this.clmCustomer,
            this.clmLotNumber,
            this.clmQuality,
            this.clmCellar,
            this.clmCoilsNumber,
            this.clmCuttingDate,
            this.clmDayCorte,
            this.clmMonth,
            this.clmYear,
            this.clmHour,
            this.clmPosition});
            this.dgvDepotState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepotState.Location = new System.Drawing.Point(3, 16);
            this.dgvDepotState.Name = "dgvDepotState";
            this.dgvDepotState.ReadOnly = true;
            this.dgvDepotState.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDepotState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDepotState.Size = new System.Drawing.Size(1089, 369);
            this.dgvDepotState.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkExportNotes);
            this.groupBox1.Controls.Add(this.btnCoilsDetail);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPalletQuantity);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(2, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1095, 58);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // chkExportNotes
            // 
            this.chkExportNotes.AutoSize = true;
            this.chkExportNotes.Location = new System.Drawing.Point(544, 22);
            this.chkExportNotes.Name = "chkExportNotes";
            this.chkExportNotes.Size = new System.Drawing.Size(117, 17);
            this.chkExportNotes.TabIndex = 32;
            this.chkExportNotes.Text = "Exportar con Notas";
            this.chkExportNotes.UseVisualStyleBackColor = true;
            // 
            // btnCoilsDetail
            // 
            this.btnCoilsDetail.Location = new System.Drawing.Point(396, 13);
            this.btnCoilsDetail.Name = "btnCoilsDetail";
            this.btnCoilsDetail.Size = new System.Drawing.Size(135, 32);
            this.btnCoilsDetail.TabIndex = 30;
            this.btnCoilsDetail.Text = "Detalle por Bobinas";
            this.btnCoilsDetail.UseVisualStyleBackColor = true;
            this.btnCoilsDetail.Click += new System.EventHandler(this.btnCoilsDetail_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(263, 24);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total Peso:";
            // 
            // txtPalletQuantity
            // 
            this.txtPalletQuantity.Location = new System.Drawing.Point(81, 24);
            this.txtPalletQuantity.Name = "txtPalletQuantity";
            this.txtPalletQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtPalletQuantity.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Cant. Pallet:";
            // 
            // clmPalletCodsec
            // 
            this.clmPalletCodsec.HeaderText = "codsec";
            this.clmPalletCodsec.Name = "clmPalletCodsec";
            this.clmPalletCodsec.ReadOnly = true;
            this.clmPalletCodsec.Visible = false;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.ReadOnly = true;
            this.clmPlant.Width = 80;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 80;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Producto";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            this.clmFilm.Width = 120;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 50;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diam";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 45;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 45;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 55;
            // 
            // clmGrossWeight
            // 
            this.clmGrossWeight.HeaderText = "Peso Bruto";
            this.clmGrossWeight.Name = "clmGrossWeight";
            this.clmGrossWeight.ReadOnly = true;
            this.clmGrossWeight.Visible = false;
            // 
            // clmOrigin
            // 
            this.clmOrigin.HeaderText = "Origen";
            this.clmOrigin.Name = "clmOrigin";
            this.clmOrigin.ReadOnly = true;
            this.clmOrigin.Width = 90;
            // 
            // clmSalesOrder
            // 
            this.clmSalesOrder.HeaderText = "Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            this.clmSalesOrder.Width = 60;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 120;
            // 
            // clmLotNumber
            // 
            this.clmLotNumber.HeaderText = "Lote";
            this.clmLotNumber.Name = "clmLotNumber";
            this.clmLotNumber.ReadOnly = true;
            this.clmLotNumber.Visible = false;
            this.clmLotNumber.Width = 120;
            // 
            // clmQuality
            // 
            this.clmQuality.HeaderText = "Calidad";
            this.clmQuality.Name = "clmQuality";
            this.clmQuality.ReadOnly = true;
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Bodega";
            this.clmCellar.Name = "clmCellar";
            this.clmCellar.ReadOnly = true;
            this.clmCellar.Width = 120;
            // 
            // clmCoilsNumber
            // 
            this.clmCoilsNumber.HeaderText = "#Bobinas";
            this.clmCoilsNumber.Name = "clmCoilsNumber";
            this.clmCoilsNumber.ReadOnly = true;
            this.clmCoilsNumber.Width = 60;
            // 
            // clmCuttingDate
            // 
            this.clmCuttingDate.HeaderText = "F. Corte";
            this.clmCuttingDate.Name = "clmCuttingDate";
            this.clmCuttingDate.ReadOnly = true;
            this.clmCuttingDate.Width = 80;
            // 
            // clmDayCorte
            // 
            this.clmDayCorte.HeaderText = "Dia";
            this.clmDayCorte.Name = "clmDayCorte";
            this.clmDayCorte.ReadOnly = true;
            this.clmDayCorte.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "Mes";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            this.clmMonth.Visible = false;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Año";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Visible = false;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            this.clmHour.Visible = false;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posición";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 70;
            // 
            // frmDepotState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbFilters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepotState";
            this.Text = "Estado de Depósito";
            this.gbFilters.ResumeLayout(false);
            this.gbFilters.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepotState)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLotNumber;
        private System.Windows.Forms.ComboBox cmbCellar;
        private System.Windows.Forms.ComboBox cmbOrigin;
        private System.Windows.Forms.ComboBox cmbCustommer;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbPalletCode;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDepotState;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCoilsDetail;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPalletQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkExportNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDayCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
    }
}