namespace BPS
{
    partial class frmExportPalletMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportPalletMovement));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.lblMovements = new System.Windows.Forms.Label();
            this.cmbMovements = new System.Windows.Forms.ComboBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.grpbPalletCellar = new System.Windows.Forms.GroupBox();
            this.dgvPalletCellar = new System.Windows.Forms.DataGridView();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementValidated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementcellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigocellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigomovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmorigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementLocalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementExternalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementcodepallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementwith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementpalletcomposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementIsExported = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMovementToExport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMovementFlgToExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.lblTCellar23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTCellar18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTCellar3 = new System.Windows.Forms.Label();
            this.lblCellar3 = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.fbdFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.grpbFilter.SuspendLayout();
            this.grpbPalletCellar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).BeginInit();
            this.grpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.lblMovements);
            this.grpbFilter.Controls.Add(this.cmbMovements);
            this.grpbFilter.Controls.Add(this.chkSelectAll);
            this.grpbFilter.Controls.Add(this.lblEndDate);
            this.grpbFilter.Controls.Add(this.lblInitDate);
            this.grpbFilter.Controls.Add(this.btnLoadData);
            this.grpbFilter.Controls.Add(this.dtpEndDate);
            this.grpbFilter.Controls.Add(this.dtpInitDate);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(1159, 59);
            this.grpbFilter.TabIndex = 1;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // lblMovements
            // 
            this.lblMovements.AutoSize = true;
            this.lblMovements.Location = new System.Drawing.Point(456, 22);
            this.lblMovements.Name = "lblMovements";
            this.lblMovements.Size = new System.Drawing.Size(77, 15);
            this.lblMovements.TabIndex = 6;
            this.lblMovements.Text = "Movimientos";
            // 
            // cmbMovements
            // 
            this.cmbMovements.FormattingEnabled = true;
            this.cmbMovements.Items.AddRange(new object[] {
            "Ingreso Producto Terminado",
            "Ingreso Stock local",
            "Salida Proceso"});
            this.cmbMovements.Location = new System.Drawing.Point(539, 19);
            this.cmbMovements.Name = "cmbMovements";
            this.cmbMovements.Size = new System.Drawing.Size(315, 23);
            this.cmbMovements.TabIndex = 5;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(1021, 34);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(60, 19);
            this.chkSelectAll.TabIndex = 4;
            this.chkSelectAll.Text = "Todos";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(234, 24);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(39, 15);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "Hasta";
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(8, 24);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(43, 15);
            this.lblInitDate.TabIndex = 2;
            this.lblInitDate.Text = "Desde";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(279, 21);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 21);
            this.dtpEndDate.TabIndex = 0;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(57, 21);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(156, 21);
            this.dtpInitDate.TabIndex = 0;
            // 
            // grpbPalletCellar
            // 
            this.grpbPalletCellar.Controls.Add(this.dgvPalletCellar);
            this.grpbPalletCellar.Controls.Add(this.grpbSearch);
            this.grpbPalletCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletCellar.Location = new System.Drawing.Point(0, 59);
            this.grpbPalletCellar.Name = "grpbPalletCellar";
            this.grpbPalletCellar.Size = new System.Drawing.Size(1159, 517);
            this.grpbPalletCellar.TabIndex = 2;
            this.grpbPalletCellar.TabStop = false;
            this.grpbPalletCellar.Text = "Movimientos de pallets en bodega";
            // 
            // dgvPalletCellar
            // 
            this.dgvPalletCellar.AllowUserToAddRows = false;
            this.dgvPalletCellar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPalletCellar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPalletCellar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletCellar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalletCellar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletCellar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnumber,
            this.clmMovementCodsec,
            this.clmMovementValidated,
            this.clmMovementPalletCodsec,
            this.clmmovementcellar,
            this.clmsiigocellar,
            this.clmsiigomovement,
            this.clmsiigocode,
            this.clmref,
            this.clmorigin,
            this.clmMovementLocalWeight,
            this.clmMovementExternalWeight,
            this.clmmovementweigth,
            this.clmmovementcodepallet,
            this.clmmovementproduct,
            this.clmmovementcustomer,
            this.clmmovementorder,
            this.clmmovementwith,
            this.clmmovementpalletcomposition,
            this.clmmovementdate,
            this.clmMovementIsExported,
            this.clmMovementToExport,
            this.clmMovementFlgToExport});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPalletCellar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPalletCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletCellar.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletCellar.Name = "dgvPalletCellar";
            this.dgvPalletCellar.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPalletCellar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPalletCellar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalletCellar.Size = new System.Drawing.Size(1153, 454);
            this.dgvPalletCellar.TabIndex = 0;
            this.dgvPalletCellar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletCellar_CellClick);
            this.dgvPalletCellar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletCellar_CellDoubleClick);
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.Width = 30;
            // 
            // clmMovementCodsec
            // 
            this.clmMovementCodsec.HeaderText = "movementCodsec";
            this.clmMovementCodsec.Name = "clmMovementCodsec";
            this.clmMovementCodsec.Visible = false;
            // 
            // clmMovementValidated
            // 
            this.clmMovementValidated.HeaderText = "";
            this.clmMovementValidated.Name = "clmMovementValidated";
            this.clmMovementValidated.Visible = false;
            // 
            // clmMovementPalletCodsec
            // 
            this.clmMovementPalletCodsec.HeaderText = "codsec";
            this.clmMovementPalletCodsec.Name = "clmMovementPalletCodsec";
            this.clmMovementPalletCodsec.Visible = false;
            // 
            // clmmovementcellar
            // 
            this.clmmovementcellar.HeaderText = "Movimiento en Bodega";
            this.clmmovementcellar.Name = "clmmovementcellar";
            this.clmmovementcellar.Width = 160;
            // 
            // clmsiigocellar
            // 
            this.clmsiigocellar.HeaderText = "S.Bod";
            this.clmsiigocellar.Name = "clmsiigocellar";
            this.clmsiigocellar.Width = 45;
            // 
            // clmsiigomovement
            // 
            this.clmsiigomovement.HeaderText = "S.Mov";
            this.clmsiigomovement.Name = "clmsiigomovement";
            this.clmsiigomovement.Width = 55;
            // 
            // clmsiigocode
            // 
            this.clmsiigocode.HeaderText = "S.Code";
            this.clmsiigocode.Name = "clmsiigocode";
            this.clmsiigocode.Width = 90;
            // 
            // clmref
            // 
            this.clmref.HeaderText = "S.Ref";
            this.clmref.Name = "clmref";
            // 
            // clmorigin
            // 
            this.clmorigin.HeaderText = "Origen";
            this.clmorigin.Name = "clmorigin";
            this.clmorigin.ReadOnly = true;
            this.clmorigin.Width = 70;
            // 
            // clmMovementLocalWeight
            // 
            this.clmMovementLocalWeight.HeaderText = "Bopp";
            this.clmMovementLocalWeight.Name = "clmMovementLocalWeight";
            this.clmMovementLocalWeight.Width = 50;
            // 
            // clmMovementExternalWeight
            // 
            this.clmMovementExternalWeight.HeaderText = "Opp";
            this.clmMovementExternalWeight.Name = "clmMovementExternalWeight";
            this.clmMovementExternalWeight.Width = 50;
            // 
            // clmmovementweigth
            // 
            this.clmmovementweigth.HeaderText = "Peso";
            this.clmmovementweigth.Name = "clmmovementweigth";
            this.clmmovementweigth.Width = 70;
            // 
            // clmmovementcodepallet
            // 
            this.clmmovementcodepallet.HeaderText = "Pallet";
            this.clmmovementcodepallet.Name = "clmmovementcodepallet";
            this.clmmovementcodepallet.Width = 110;
            // 
            // clmmovementproduct
            // 
            this.clmmovementproduct.HeaderText = "Producto";
            this.clmmovementproduct.Name = "clmmovementproduct";
            // 
            // clmmovementcustomer
            // 
            this.clmmovementcustomer.HeaderText = "Cliente";
            this.clmmovementcustomer.Name = "clmmovementcustomer";
            this.clmmovementcustomer.Width = 170;
            // 
            // clmmovementorder
            // 
            this.clmmovementorder.HeaderText = "Orden";
            this.clmmovementorder.Name = "clmmovementorder";
            this.clmmovementorder.Width = 70;
            // 
            // clmmovementwith
            // 
            this.clmmovementwith.HeaderText = "Ancho";
            this.clmmovementwith.Name = "clmmovementwith";
            this.clmmovementwith.Width = 70;
            // 
            // clmmovementpalletcomposition
            // 
            this.clmmovementpalletcomposition.HeaderText = "P - B";
            this.clmmovementpalletcomposition.Name = "clmmovementpalletcomposition";
            this.clmmovementpalletcomposition.Width = 58;
            // 
            // clmmovementdate
            // 
            this.clmmovementdate.HeaderText = "Fecha";
            this.clmmovementdate.Name = "clmmovementdate";
            this.clmmovementdate.Width = 120;
            // 
            // clmMovementIsExported
            // 
            this.clmMovementIsExported.HeaderText = "clmMovementIsExported";
            this.clmMovementIsExported.Name = "clmMovementIsExported";
            this.clmMovementIsExported.Width = 30;
            // 
            // clmMovementToExport
            // 
            this.clmMovementToExport.HeaderText = "clmMovementToExport";
            this.clmMovementToExport.Name = "clmMovementToExport";
            this.clmMovementToExport.Width = 30;
            // 
            // clmMovementFlgToExport
            // 
            this.clmMovementFlgToExport.HeaderText = "toExport";
            this.clmMovementFlgToExport.Name = "clmMovementFlgToExport";
            this.clmMovementFlgToExport.Visible = false;
            // 
            // grpbSearch
            // 
            this.grpbSearch.Controls.Add(this.lblTCellar23);
            this.grpbSearch.Controls.Add(this.label5);
            this.grpbSearch.Controls.Add(this.lblTCellar18);
            this.grpbSearch.Controls.Add(this.label3);
            this.grpbSearch.Controls.Add(this.lblTCellar3);
            this.grpbSearch.Controls.Add(this.lblCellar3);
            this.grpbSearch.Controls.Add(this.btnOrder);
            this.grpbSearch.Controls.Add(this.lblnumber);
            this.grpbSearch.Controls.Add(this.btnValidate);
            this.grpbSearch.Controls.Add(this.lblinfo);
            this.grpbSearch.Controls.Add(this.btnExport);
            this.grpbSearch.Controls.Add(this.btnClose);
            this.grpbSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbSearch.Location = new System.Drawing.Point(3, 471);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(1153, 43);
            this.grpbSearch.TabIndex = 5;
            this.grpbSearch.TabStop = false;
            // 
            // lblTCellar23
            // 
            this.lblTCellar23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCellar23.Location = new System.Drawing.Point(595, 14);
            this.lblTCellar23.Name = "lblTCellar23";
            this.lblTCellar23.Size = new System.Drawing.Size(107, 23);
            this.lblTCellar23.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bodega 23 ";
            // 
            // lblTCellar18
            // 
            this.lblTCellar18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCellar18.Location = new System.Drawing.Point(383, 14);
            this.lblTCellar18.Name = "lblTCellar18";
            this.lblTCellar18.Size = new System.Drawing.Size(107, 23);
            this.lblTCellar18.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bodega 18 ";
            // 
            // lblTCellar3
            // 
            this.lblTCellar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCellar3.Location = new System.Drawing.Point(185, 14);
            this.lblTCellar3.Name = "lblTCellar3";
            this.lblTCellar3.Size = new System.Drawing.Size(107, 23);
            this.lblTCellar3.TabIndex = 5;
            // 
            // lblCellar3
            // 
            this.lblCellar3.AutoSize = true;
            this.lblCellar3.Location = new System.Drawing.Point(116, 17);
            this.lblCellar3.Name = "lblCellar3";
            this.lblCellar3.Size = new System.Drawing.Size(63, 15);
            this.lblCellar3.TabIndex = 4;
            this.lblCellar3.Text = "Bodega 3 ";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(1011, 17);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(0, 15);
            this.lblnumber.TabIndex = 1;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(845, 17);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(162, 15);
            this.lblinfo.TabIndex = 0;
            this.lblinfo.Text = "Total de Pallets a exportar # ";
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::BPS.Properties.Resources.Xiao_90;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrder.Location = new System.Drawing.Point(1047, 12);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(25, 25);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackgroundImage = global::BPS.Properties.Resources.quality;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(1072, 12);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(25, 25);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::BPS.Properties.Resources.iconExportTo;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExport.Location = new System.Drawing.Point(1097, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 0;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(1122, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadData.Location = new System.Drawing.Point(928, 17);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(24, 25);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // frmExportPalletMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1159, 576);
            this.Controls.Add(this.grpbPalletCellar);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportPalletMovement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportación de Pallets al SIIGO";
            this.Load += new System.EventHandler(this.frmPalletMovement_Load);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.grpbPalletCellar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).EndInit();
            this.grpbSearch.ResumeLayout(false);
            this.grpbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.GroupBox grpbPalletCellar;
        private System.Windows.Forms.DataGridView dgvPalletCellar;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog fbdFilePath;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label lblMovements;
        private System.Windows.Forms.ComboBox cmbMovements;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementValidated;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementPalletCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementcellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigocellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigomovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmref;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementLocalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementExternalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementcodepallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementwith;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementpalletcomposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementdate;
        private System.Windows.Forms.DataGridViewImageColumn clmMovementIsExported;
        private System.Windows.Forms.DataGridViewImageColumn clmMovementToExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementFlgToExport;
        private System.Windows.Forms.Label lblTCellar23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTCellar18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTCellar3;
        private System.Windows.Forms.Label lblCellar3;
    }
}