namespace BPS
{
    partial class frmExportPalletShippingPlus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportPalletShippingPlus));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dgvPalletCellar = new System.Windows.Forms.DataGridView();
            this.clmobennumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobencodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementvalidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenvalidatevalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenvalidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigocellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigomovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigocode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsiigoreference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenorigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenbopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenmovement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobencustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobenpb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmobendate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfilter = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblinfo = new System.Windows.Forms.Label();
            this.lblTCellar23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTCellar18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTCellar3 = new System.Windows.Forms.Label();
            this.lblCellar3 = new System.Windows.Forms.Label();
            this.btnFilterPallet = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.cmbCellar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMovement = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.ttpExport = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEndDate);
            this.groupBox1.Controls.Add(this.lblInitDate);
            this.groupBox1.Controls.Add(this.btnLoadData);
            this.groupBox1.Controls.Add(this.dtpEndDate);
            this.groupBox1.Controls.Add(this.dtpInitDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fecha de Movimientos";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(591, 17);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(39, 15);
            this.lblEndDate.TabIndex = 11;
            this.lblEndDate.Text = "Hasta";
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(365, 17);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(43, 15);
            this.lblInitDate.TabIndex = 10;
            this.lblInitDate.Text = "Desde";
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadData.Location = new System.Drawing.Point(1027, 10);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(24, 25);
            this.btnLoadData.TabIndex = 9;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(636, 14);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(157, 21);
            this.dtpEndDate.TabIndex = 7;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(414, 14);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(156, 21);
            this.dtpInitDate.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pbxLoading);
            this.groupBox2.Controls.Add(this.lblLoading);
            this.groupBox2.Controls.Add(this.dgvPalletCellar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1159, 454);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pallet";
            this.groupBox2.Visible = false;
            // 
            // pbxLoading
            // 
            this.pbxLoading.ErrorImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Image = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.InitialImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Location = new System.Drawing.Point(527, 196);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(105, 16);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLoading.TabIndex = 2;
            this.pbxLoading.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(456, 225);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(246, 34);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Se esta cargando la información de los pallets\r\nEsto puede tomar algunos segundos" +
    "";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvPalletCellar
            // 
            this.dgvPalletCellar.AllowUserToAddRows = false;
            this.dgvPalletCellar.AllowUserToDeleteRows = false;
            this.dgvPalletCellar.AllowUserToOrderColumns = true;
            this.dgvPalletCellar.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletCellar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPalletCellar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletCellar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmobennumber,
            this.clmobencodsec,
            this.clmmovementvalidate,
            this.clmobenvalidatevalue,
            this.clmobenvalidate,
            this.clmsiigocellar,
            this.clmsiigomovement,
            this.clmsiigocode,
            this.clmsiigoreference,
            this.clmobenorigin,
            this.clmobenbopp,
            this.clmobenopp,
            this.clmobenweigth,
            this.clmobenproduct,
            this.clmobenmovement,
            this.clmobencustomer,
            this.clmobenorder,
            this.clmobenwidth,
            this.clmobenpb,
            this.clmobendate,
            this.clmfilter});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPalletCellar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalletCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletCellar.Location = new System.Drawing.Point(3, 16);
            this.dgvPalletCellar.Name = "dgvPalletCellar";
            this.dgvPalletCellar.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletCellar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPalletCellar.RowHeadersWidth = 21;
            this.dgvPalletCellar.Size = new System.Drawing.Size(1153, 435);
            this.dgvPalletCellar.TabIndex = 0;
            this.dgvPalletCellar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletCellar_CellClick);
            this.dgvPalletCellar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletCellar_CellDoubleClick);
            // 
            // clmobennumber
            // 
            this.clmobennumber.HeaderText = "Nro.";
            this.clmobennumber.Name = "clmobennumber";
            this.clmobennumber.ReadOnly = true;
            this.clmobennumber.Width = 30;
            // 
            // clmobencodsec
            // 
            this.clmobencodsec.HeaderText = "";
            this.clmobencodsec.Name = "clmobencodsec";
            this.clmobencodsec.ReadOnly = true;
            this.clmobencodsec.Visible = false;
            // 
            // clmmovementvalidate
            // 
            this.clmmovementvalidate.HeaderText = "";
            this.clmmovementvalidate.Name = "clmmovementvalidate";
            this.clmmovementvalidate.ReadOnly = true;
            this.clmmovementvalidate.Visible = false;
            // 
            // clmobenvalidatevalue
            // 
            this.clmobenvalidatevalue.HeaderText = "";
            this.clmobenvalidatevalue.Name = "clmobenvalidatevalue";
            this.clmobenvalidatevalue.ReadOnly = true;
            this.clmobenvalidatevalue.Visible = false;
            // 
            // clmobenvalidate
            // 
            this.clmobenvalidate.HeaderText = "";
            this.clmobenvalidate.Name = "clmobenvalidate";
            this.clmobenvalidate.ReadOnly = true;
            this.clmobenvalidate.Visible = false;
            // 
            // clmsiigocellar
            // 
            this.clmsiigocellar.HeaderText = "S. Bod";
            this.clmsiigocellar.Name = "clmsiigocellar";
            this.clmsiigocellar.ReadOnly = true;
            this.clmsiigocellar.Width = 64;
            // 
            // clmsiigomovement
            // 
            this.clmsiigomovement.HeaderText = "S. Mov";
            this.clmsiigomovement.Name = "clmsiigomovement";
            this.clmsiigomovement.ReadOnly = true;
            this.clmsiigomovement.Width = 64;
            // 
            // clmsiigocode
            // 
            this.clmsiigocode.HeaderText = "S. Code";
            this.clmsiigocode.Name = "clmsiigocode";
            this.clmsiigocode.ReadOnly = true;
            this.clmsiigocode.Width = 95;
            // 
            // clmsiigoreference
            // 
            this.clmsiigoreference.HeaderText = "S. Ref";
            this.clmsiigoreference.Name = "clmsiigoreference";
            this.clmsiigoreference.ReadOnly = true;
            this.clmsiigoreference.Width = 95;
            // 
            // clmobenorigin
            // 
            this.clmobenorigin.HeaderText = "Origen";
            this.clmobenorigin.Name = "clmobenorigin";
            this.clmobenorigin.ReadOnly = true;
            this.clmobenorigin.Width = 50;
            // 
            // clmobenbopp
            // 
            this.clmobenbopp.HeaderText = "Bopp";
            this.clmobenbopp.Name = "clmobenbopp";
            this.clmobenbopp.ReadOnly = true;
            this.clmobenbopp.Width = 45;
            // 
            // clmobenopp
            // 
            this.clmobenopp.HeaderText = "Opp";
            this.clmobenopp.Name = "clmobenopp";
            this.clmobenopp.ReadOnly = true;
            this.clmobenopp.Width = 45;
            // 
            // clmobenweigth
            // 
            this.clmobenweigth.HeaderText = "Peso";
            this.clmobenweigth.Name = "clmobenweigth";
            this.clmobenweigth.ReadOnly = true;
            this.clmobenweigth.Width = 50;
            // 
            // clmobenproduct
            // 
            this.clmobenproduct.HeaderText = "Producto";
            this.clmobenproduct.Name = "clmobenproduct";
            this.clmobenproduct.ReadOnly = true;
            // 
            // clmobenmovement
            // 
            this.clmobenmovement.HeaderText = "Mov. Bodega";
            this.clmobenmovement.Name = "clmobenmovement";
            this.clmobenmovement.ReadOnly = true;
            // 
            // clmobencustomer
            // 
            this.clmobencustomer.HeaderText = "Cliente";
            this.clmobencustomer.Name = "clmobencustomer";
            this.clmobencustomer.ReadOnly = true;
            // 
            // clmobenorder
            // 
            this.clmobenorder.HeaderText = "Orden";
            this.clmobenorder.Name = "clmobenorder";
            this.clmobenorder.ReadOnly = true;
            this.clmobenorder.Width = 60;
            // 
            // clmobenwidth
            // 
            this.clmobenwidth.HeaderText = "Ancho";
            this.clmobenwidth.Name = "clmobenwidth";
            this.clmobenwidth.ReadOnly = true;
            this.clmobenwidth.Width = 45;
            // 
            // clmobenpb
            // 
            this.clmobenpb.HeaderText = "P-B";
            this.clmobenpb.Name = "clmobenpb";
            this.clmobenpb.ReadOnly = true;
            this.clmobenpb.Width = 40;
            // 
            // clmobendate
            // 
            this.clmobendate.HeaderText = "Fecha";
            this.clmobendate.Name = "clmobendate";
            this.clmobendate.ReadOnly = true;
            this.clmobendate.Width = 80;
            // 
            // clmfilter
            // 
            this.clmfilter.HeaderText = "";
            this.clmfilter.Name = "clmfilter";
            this.clmfilter.ReadOnly = true;
            this.clmfilter.Width = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReport);
            this.groupBox3.Controls.Add(this.btnCalendar);
            this.groupBox3.Controls.Add(this.lblnumber);
            this.groupBox3.Controls.Add(this.lblinfo);
            this.groupBox3.Controls.Add(this.lblTCellar23);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblTCellar18);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblTCellar3);
            this.groupBox3.Controls.Add(this.lblCellar3);
            this.groupBox3.Controls.Add(this.btnFilterPallet);
            this.groupBox3.Controls.Add(this.btnValidate);
            this.groupBox3.Controls.Add(this.btnExport);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 535);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1159, 41);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen";
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(1004, 11);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 19;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalendar.BackgroundImage = global::BPS.Properties.Resources.calendar_2;
            this.btnCalendar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCalendar.Location = new System.Drawing.Point(1030, 11);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(25, 25);
            this.btnCalendar.TabIndex = 18;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumber.Location = new System.Drawing.Point(875, 16);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(15, 15);
            this.lblnumber.TabIndex = 17;
            this.lblnumber.Text = "0";
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(711, 16);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(162, 15);
            this.lblinfo.TabIndex = 16;
            this.lblinfo.Text = "Total de Pallets a exportar # ";
            // 
            // lblTCellar23
            // 
            this.lblTCellar23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCellar23.Location = new System.Drawing.Point(553, 12);
            this.lblTCellar23.Name = "lblTCellar23";
            this.lblTCellar23.Size = new System.Drawing.Size(107, 23);
            this.lblTCellar23.TabIndex = 15;
            this.lblTCellar23.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bodega 23 ";
            // 
            // lblTCellar18
            // 
            this.lblTCellar18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCellar18.Location = new System.Drawing.Point(341, 12);
            this.lblTCellar18.Name = "lblTCellar18";
            this.lblTCellar18.Size = new System.Drawing.Size(107, 23);
            this.lblTCellar18.TabIndex = 13;
            this.lblTCellar18.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bodega 18 ";
            // 
            // lblTCellar3
            // 
            this.lblTCellar3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTCellar3.Location = new System.Drawing.Point(143, 12);
            this.lblTCellar3.Name = "lblTCellar3";
            this.lblTCellar3.Size = new System.Drawing.Size(107, 23);
            this.lblTCellar3.TabIndex = 11;
            this.lblTCellar3.Text = "0";
            // 
            // lblCellar3
            // 
            this.lblCellar3.AutoSize = true;
            this.lblCellar3.Location = new System.Drawing.Point(74, 15);
            this.lblCellar3.Name = "lblCellar3";
            this.lblCellar3.Size = new System.Drawing.Size(63, 15);
            this.lblCellar3.TabIndex = 10;
            this.lblCellar3.Text = "Bodega 3 ";
            // 
            // btnFilterPallet
            // 
            this.btnFilterPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterPallet.BackgroundImage = global::BPS.Properties.Resources.Xiao_90;
            this.btnFilterPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterPallet.Location = new System.Drawing.Point(1056, 11);
            this.btnFilterPallet.Name = "btnFilterPallet";
            this.btnFilterPallet.Size = new System.Drawing.Size(25, 25);
            this.btnFilterPallet.TabIndex = 5;
            this.btnFilterPallet.UseVisualStyleBackColor = true;
            this.btnFilterPallet.Click += new System.EventHandler(this.btnFilterPallet_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidate.BackgroundImage = global::BPS.Properties.Resources.quality;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(1081, 11);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(25, 25);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackgroundImage = global::BPS.Properties.Resources.iconExportTo;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExport.Location = new System.Drawing.Point(1106, 11);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 4;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(1131, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkSelectAll);
            this.groupBox4.Controls.Add(this.btnRefresh);
            this.groupBox4.Controls.Add(this.btnClearFilters);
            this.groupBox4.Controls.Add(this.cmbCellar);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbMovement);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbOrder);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.cmbCustomer);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbProduct);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1159, 41);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtros";
            this.groupBox4.Visible = false;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(1044, 14);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(60, 19);
            this.chkSelectAll.TabIndex = 23;
            this.chkSelectAll.Text = "Todos";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(1130, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(1105, 10);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 21;
            this.btnClearFilters.UseVisualStyleBackColor = true;
            // 
            // cmbCellar
            // 
            this.cmbCellar.FormattingEnabled = true;
            this.cmbCellar.Location = new System.Drawing.Point(966, 12);
            this.cmbCellar.Name = "cmbCellar";
            this.cmbCellar.Size = new System.Drawing.Size(72, 23);
            this.cmbCellar.TabIndex = 9;
            this.cmbCellar.SelectedIndexChanged += new System.EventHandler(this.cmbCellar_SelectedIndexChanged);
            this.cmbCellar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCellar_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(910, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Bodega";
            // 
            // cmbMovement
            // 
            this.cmbMovement.FormattingEnabled = true;
            this.cmbMovement.Location = new System.Drawing.Point(833, 12);
            this.cmbMovement.Name = "cmbMovement";
            this.cmbMovement.Size = new System.Drawing.Size(71, 23);
            this.cmbMovement.TabIndex = 7;
            this.cmbMovement.SelectedIndexChanged += new System.EventHandler(this.cmbMovement_SelectedIndexChanged);
            this.cmbMovement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMovement_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Movimiento Siigo";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(625, 12);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(94, 23);
            this.cmbOrder.TabIndex = 5;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Orden";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(305, 12);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(266, 23);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(64, 12);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(184, 23);
            this.cmbProduct.TabIndex = 1;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // frmExportPalletShippingPlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1159, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportPalletShippingPlus";
            this.Text = "Exportación de Movimientos al SIIGO";
            this.Load += new System.EventHandler(this.frmExportPalletMovementPlus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFilterPallet;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.FolderBrowserDialog fbdFilePath;
        private System.Windows.Forms.ToolTip ttpExport;
        private System.Windows.Forms.Label lblTCellar23;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTCellar18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTCellar3;
        private System.Windows.Forms.Label lblCellar3;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.ComboBox cmbCellar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMovement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.DataGridView dgvPalletCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobennumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobencodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementvalidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenvalidatevalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenvalidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigocellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigomovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigocode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsiigoreference;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenorigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenbopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenmovement;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobencustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobenpb;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmobendate;
        private System.Windows.Forms.DataGridViewImageColumn clmfilter;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnReport;
    }
}