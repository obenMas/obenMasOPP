namespace BPS.Cellar.Inventory.RePro
{
    partial class frmSummaryInventoryVsBackload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryInventoryVsBackload));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkColorCoilCellar = new System.Windows.Forms.CheckBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMainCoilClearFilters = new System.Windows.Forms.Button();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilsNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbFooter = new System.Windows.Forms.GroupBox();
            this.grpbColorCode = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblTotalWeightLabel = new System.Windows.Forms.Label();
            this.lblTotalPallets = new System.Windows.Forms.Label();
            this.lblTotalPalletsLabel = new System.Windows.Forms.Label();
            this.grpbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.grpbFooter.SuspendLayout();
            this.grpbColorCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.cmbPosition);
            this.grpbFilters.Controls.Add(this.label9);
            this.grpbFilters.Controls.Add(this.chkColorCoilCellar);
            this.grpbFilters.Controls.Add(this.pictureBox7);
            this.grpbFilters.Controls.Add(this.pictureBox6);
            this.grpbFilters.Controls.Add(this.pictureBox5);
            this.grpbFilters.Controls.Add(this.pictureBox4);
            this.grpbFilters.Controls.Add(this.btnRefresh);
            this.grpbFilters.Controls.Add(this.btnMainCoilClearFilters);
            this.grpbFilters.Controls.Add(this.cmbFilm);
            this.grpbFilters.Controls.Add(this.lblFilmName);
            this.grpbFilters.Controls.Add(this.lblNote);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(0, 0);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(813, 74);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(390, 20);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(126, 23);
            this.cmbPosition.TabIndex = 29;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.cmbPosition_SelectedIndexChanged);
            this.cmbPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPosition_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Ubicación";
            // 
            // chkColorCoilCellar
            // 
            this.chkColorCoilCellar.AutoSize = true;
            this.chkColorCoilCellar.Checked = true;
            this.chkColorCoilCellar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkColorCoilCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkColorCoilCellar.Location = new System.Drawing.Point(538, 22);
            this.chkColorCoilCellar.Name = "chkColorCoilCellar";
            this.chkColorCoilCellar.Size = new System.Drawing.Size(131, 19);
            this.chkColorCoilCellar.TabIndex = 27;
            this.chkColorCoilCellar.Text = "Códigos de colores";
            this.chkColorCoilCellar.UseVisualStyleBackColor = true;
            this.chkColorCoilCellar.CheckedChanged += new System.EventHandler(this.chkColorCoilCellar_CheckedChanged);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(674, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1, 11);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(29, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1, 11);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(617, 59);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 1);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(29, 59);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 1);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(774, 20);
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
            this.btnMainCoilClearFilters.Location = new System.Drawing.Point(743, 20);
            this.btnMainCoilClearFilters.Name = "btnMainCoilClearFilters";
            this.btnMainCoilClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClearFilters.TabIndex = 19;
            this.btnMainCoilClearFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilClearFilters.Click += new System.EventHandler(this.btnMainCoilClearFilters_Click);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(124, 20);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(180, 23);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(25, 23);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(93, 15);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "ReProcesado";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(-3, 49);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(709, 18);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Seleccione una de las opciones o escriba en el campo el criterio de busqueda y pr" +
    "esione enter";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.pbxLoading);
            this.grpbDetail.Controls.Add(this.lblLoading);
            this.grpbDetail.Controls.Add(this.dgvDetails);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetail.Location = new System.Drawing.Point(0, 74);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(813, 467);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // pbxLoading
            // 
            this.pbxLoading.ErrorImage = global::BPS.Properties.Resources.loadingIII;
            this.pbxLoading.Image = global::BPS.Properties.Resources.loadingIII;
            this.pbxLoading.InitialImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Location = new System.Drawing.Point(356, 206);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(100, 12);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLoading.TabIndex = 1;
            this.pbxLoading.TabStop = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(300, 201);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(213, 65);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Se esta cargando la información de los pallets\r\nEsto puede tomar algunos segundos" +
    "";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clminventory,
            this.clmFilm,
            this.clmNetWeight,
            this.clmgrossWeight,
            this.clmCellar,
            this.clmPalletNumber,
            this.clmCoilsNumber,
            this.clmnave,
            this.clmpallet,
            this.clmDetail});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 14);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 10;
            this.dgvDetails.Size = new System.Drawing.Size(807, 450);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 5;
            // 
            // clminventory
            // 
            this.clminventory.HeaderText = "Ubicación";
            this.clminventory.Name = "clminventory";
            this.clminventory.ReadOnly = true;
            this.clminventory.Width = 80;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "ReProcesado";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            // 
            // clmNetWeight
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmNetWeight.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNetWeight.HeaderText = "Peso N.";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 70;
            // 
            // clmgrossWeight
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmgrossWeight.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmgrossWeight.HeaderText = "Peso B.";
            this.clmgrossWeight.Name = "clmgrossWeight";
            this.clmgrossWeight.ReadOnly = true;
            this.clmgrossWeight.Width = 70;
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Bodega";
            this.clmCellar.Name = "clmCellar";
            this.clmCellar.ReadOnly = true;
            this.clmCellar.Width = 70;
            // 
            // clmPalletNumber
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmPalletNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPalletNumber.HeaderText = "#Pallet";
            this.clmPalletNumber.Name = "clmPalletNumber";
            this.clmPalletNumber.ReadOnly = true;
            this.clmPalletNumber.Width = 65;
            // 
            // clmCoilsNumber
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCoilsNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCoilsNumber.HeaderText = "#Sacos";
            this.clmCoilsNumber.Name = "clmCoilsNumber";
            this.clmCoilsNumber.ReadOnly = true;
            this.clmCoilsNumber.Width = 65;
            // 
            // clmnave
            // 
            this.clmnave.HeaderText = "Nave";
            this.clmnave.Name = "clmnave";
            this.clmnave.ReadOnly = true;
            this.clmnave.Width = 40;
            // 
            // clmpallet
            // 
            this.clmpallet.HeaderText = "Code";
            this.clmpallet.Name = "clmpallet";
            this.clmpallet.ReadOnly = true;
            this.clmpallet.Width = 150;
            // 
            // clmDetail
            // 
            this.clmDetail.HeaderText = "";
            this.clmDetail.Name = "clmDetail";
            this.clmDetail.ReadOnly = true;
            this.clmDetail.Width = 30;
            // 
            // grpbFooter
            // 
            this.grpbFooter.Controls.Add(this.grpbColorCode);
            this.grpbFooter.Controls.Add(this.lblTotalWeight);
            this.grpbFooter.Controls.Add(this.lblTotalWeightLabel);
            this.grpbFooter.Controls.Add(this.lblTotalPallets);
            this.grpbFooter.Controls.Add(this.lblTotalPalletsLabel);
            this.grpbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFooter.Location = new System.Drawing.Point(0, 541);
            this.grpbFooter.Name = "grpbFooter";
            this.grpbFooter.Size = new System.Drawing.Size(813, 98);
            this.grpbFooter.TabIndex = 2;
            this.grpbFooter.TabStop = false;
            this.grpbFooter.Text = "Resumen";
            // 
            // grpbColorCode
            // 
            this.grpbColorCode.Controls.Add(this.label4);
            this.grpbColorCode.Controls.Add(this.label3);
            this.grpbColorCode.Controls.Add(this.label5);
            this.grpbColorCode.Controls.Add(this.label2);
            this.grpbColorCode.Controls.Add(this.label1);
            this.grpbColorCode.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbColorCode.Location = new System.Drawing.Point(503, 17);
            this.grpbColorCode.Name = "grpbColorCode";
            this.grpbColorCode.Size = new System.Drawing.Size(307, 78);
            this.grpbColorCode.TabIndex = 14;
            this.grpbColorCode.TabStop = false;
            this.grpbColorCode.Text = "Código de color bodegas";
            this.grpbColorCode.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(254)))));
            this.label4.Location = new System.Drawing.Point(165, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Despachado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(182)))));
            this.label3.Location = new System.Drawing.Point(28, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Backload";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(211)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(165, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Planta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "OK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(134, 53);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(94, 20);
            this.lblTotalWeight.TabIndex = 3;
            this.lblTotalWeight.Text = "0";
            this.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalWeight.Visible = false;
            // 
            // lblTotalWeightLabel
            // 
            this.lblTotalWeightLabel.AutoSize = true;
            this.lblTotalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightLabel.Location = new System.Drawing.Point(38, 53);
            this.lblTotalWeightLabel.Name = "lblTotalWeightLabel";
            this.lblTotalWeightLabel.Size = new System.Drawing.Size(83, 20);
            this.lblTotalWeightLabel.TabIndex = 2;
            this.lblTotalWeightLabel.Text = "Total peso";
            this.lblTotalWeightLabel.Visible = false;
            // 
            // lblTotalPallets
            // 
            this.lblTotalPallets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPallets.Location = new System.Drawing.Point(134, 26);
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
            this.lblTotalPalletsLabel.Location = new System.Drawing.Point(5, 26);
            this.lblTotalPalletsLabel.Name = "lblTotalPalletsLabel";
            this.lblTotalPalletsLabel.Size = new System.Drawing.Size(116, 20);
            this.lblTotalPalletsLabel.TabIndex = 0;
            this.lblTotalPalletsLabel.Text = "Total de pallets";
            // 
            // frmSummaryInventoryVsBackload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(813, 639);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFooter);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSummaryInventoryVsBackload";
            this.Text = "Inventario VS Backload Re-Procesado";
            this.Load += new System.EventHandler(this.frmBackLoad_Load);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.grpbFooter.ResumeLayout(false);
            this.grpbFooter.PerformLayout();
            this.grpbColorCode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.GroupBox grpbFooter;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lblTotalPallets;
        private System.Windows.Forms.Label lblTotalPalletsLabel;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblTotalWeightLabel;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkColorCoilCellar;
        private System.Windows.Forms.GroupBox grpbColorCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Button btnMainCoilClearFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmgrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilsNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnave;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpallet;
        private System.Windows.Forms.DataGridViewImageColumn clmDetail;
    }
}