namespace BPS
{
    partial class frmMainCoilList
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilList));
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.grpbMainCoilList = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMainCoilClearFilters = new System.Windows.Forms.Button();
            this.btnMainCoilFilters = new System.Windows.Forms.Button();
            this.btnMainCoilClose = new System.Windows.Forms.Button();
            this.grpbMainCoilFilm = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cmbMainCoilListFilm = new System.Windows.Forms.ComboBox();
            this.lblMainCoilListFilm = new System.Windows.Forms.Label();
            this.chkFilm = new System.Windows.Forms.CheckBox();
            this.grpbMainCoilBatch = new System.Windows.Forms.GroupBox();
            this.cmbMainCoilListBatch = new System.Windows.Forms.ComboBox();
            this.lblMainCoilListBatch = new System.Windows.Forms.Label();
            this.chkLotNumber = new System.Windows.Forms.CheckBox();
            this.grpbMainCoilDate = new System.Windows.Forms.GroupBox();
            this.dtpMainCoilFinishedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpMainCoilInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblMainCoilInitDate = new System.Windows.Forms.Label();
            this.lblMainCoilFinishedDate = new System.Windows.Forms.Label();
            this.chkDateRange = new System.Windows.Forms.CheckBox();
            this.grpbMainCoilFilter = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMainCoilCode = new System.Windows.Forms.TextBox();
            this.lblMainCoilCode = new System.Windows.Forms.Label();
            this.ttpMainCoilList = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListLabRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListwi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListwe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListmet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListGra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListcoftf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListcofntf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListThikness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsurfacetensiontf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsurfacetensionntf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListQuality = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilListQualityReport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilListLabel = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilListDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilSecundaryProperties = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMainCoilLabel = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.grpbMainCoilList.SuspendLayout();
            this.grpbMainCoilFilm.SuspendLayout();
            this.grpbMainCoilBatch.SuspendLayout();
            this.grpbMainCoilDate.SuspendLayout();
            this.grpbMainCoilFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMainCoilList
            // 
            this.dgvMainCoilList.AllowUserToAddRows = false;
            this.dgvMainCoilList.AllowUserToDeleteRows = false;
            this.dgvMainCoilList.AllowUserToOrderColumns = true;
            this.dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCoilListCodsec,
            this.clmMainCoilListFilm,
            this.clmMainCoilListCode,
            this.clmMainCoilListBatch,
            this.clmMainCoilListLabRating,
            this.clmMainCoilListInitDate,
            this.clmMainCoilListEndDate,
            this.clmMainCoilListwi,
            this.clmMainCoilListwe,
            this.clmMainCoilListmet,
            this.clmMainCoilListrep,
            this.clmMainCoilListGra,
            this.clmMainCoilListcoftf,
            this.clmMainCoilListcofntf,
            this.clmMainCoilListThikness,
            this.clmsurfacetensiontf,
            this.clmsurfacetensionntf,
            this.clmMainCoilListQuality,
            this.clmMainCoilListQualityReport,
            this.clmMainCoilListLabel,
            this.clmMainCoilListDelete,
            this.clmMainCoilSecundaryProperties,
            this.clmMainCoilLabel});
            this.dgvMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilList.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.RowHeadersWidth = 31;
            this.dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilList.Size = new System.Drawing.Size(1163, 275);
            this.dgvMainCoilList.TabIndex = 1;
            this.dgvMainCoilList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainCoilList_CellClick);
            // 
            // grpbMainCoilList
            // 
            this.grpbMainCoilList.Controls.Add(this.dgvMainCoilList);
            this.grpbMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbMainCoilList.Location = new System.Drawing.Point(0, 0);
            this.grpbMainCoilList.Name = "grpbMainCoilList";
            this.grpbMainCoilList.Size = new System.Drawing.Size(1169, 295);
            this.grpbMainCoilList.TabIndex = 14;
            this.grpbMainCoilList.TabStop = false;
            this.grpbMainCoilList.Text = "Rollos Madres";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(1056, 13);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMainCoilClearFilters
            // 
            this.btnMainCoilClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnMainCoilClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilClearFilters.Location = new System.Drawing.Point(1083, 13);
            this.btnMainCoilClearFilters.Name = "btnMainCoilClearFilters";
            this.btnMainCoilClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClearFilters.TabIndex = 2;
            this.ttpMainCoilList.SetToolTip(this.btnMainCoilClearFilters, "Limpiar Filtro");
            this.btnMainCoilClearFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilClearFilters.Click += new System.EventHandler(this.btnMainCoilClearFilters_Click);
            // 
            // btnMainCoilFilters
            // 
            this.btnMainCoilFilters.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnMainCoilFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilFilters.Location = new System.Drawing.Point(1111, 13);
            this.btnMainCoilFilters.Name = "btnMainCoilFilters";
            this.btnMainCoilFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilFilters.TabIndex = 3;
            this.ttpMainCoilList.SetToolTip(this.btnMainCoilFilters, "Filtrar Rollos Madre");
            this.btnMainCoilFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilFilters.Click += new System.EventHandler(this.btnMainCoilFilters_Click);
            // 
            // btnMainCoilClose
            // 
            this.btnMainCoilClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilClose.Location = new System.Drawing.Point(1138, 13);
            this.btnMainCoilClose.Name = "btnMainCoilClose";
            this.btnMainCoilClose.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClose.TabIndex = 23;
            this.ttpMainCoilList.SetToolTip(this.btnMainCoilClose, "Salir");
            this.btnMainCoilClose.UseVisualStyleBackColor = true;
            this.btnMainCoilClose.Click += new System.EventHandler(this.btnMainCoilClose_Click);
            // 
            // grpbMainCoilFilm
            // 
            this.grpbMainCoilFilm.Controls.Add(this.checkBox3);
            this.grpbMainCoilFilm.Controls.Add(this.cmbMainCoilListFilm);
            this.grpbMainCoilFilm.Controls.Add(this.lblMainCoilListFilm);
            this.grpbMainCoilFilm.Enabled = false;
            this.grpbMainCoilFilm.Location = new System.Drawing.Point(62, 20);
            this.grpbMainCoilFilm.Name = "grpbMainCoilFilm";
            this.grpbMainCoilFilm.Size = new System.Drawing.Size(484, 86);
            this.grpbMainCoilFilm.TabIndex = 17;
            this.grpbMainCoilFilm.TabStop = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(496, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(86, 19);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "checkBox1";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cmbMainCoilListFilm
            // 
            this.cmbMainCoilListFilm.FormattingEnabled = true;
            this.cmbMainCoilListFilm.Location = new System.Drawing.Point(54, 36);
            this.cmbMainCoilListFilm.Name = "cmbMainCoilListFilm";
            this.cmbMainCoilListFilm.Size = new System.Drawing.Size(424, 23);
            this.cmbMainCoilListFilm.TabIndex = 5;
            this.cmbMainCoilListFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMainCoilListFilm_KeyDown);
            // 
            // lblMainCoilListFilm
            // 
            this.lblMainCoilListFilm.AutoSize = true;
            this.lblMainCoilListFilm.Location = new System.Drawing.Point(1, 38);
            this.lblMainCoilListFilm.Name = "lblMainCoilListFilm";
            this.lblMainCoilListFilm.Size = new System.Drawing.Size(51, 15);
            this.lblMainCoilListFilm.TabIndex = 4;
            this.lblMainCoilListFilm.Text = "Película";
            // 
            // chkFilm
            // 
            this.chkFilm.Location = new System.Drawing.Point(71, 20);
            this.chkFilm.Name = "chkFilm";
            this.chkFilm.Size = new System.Drawing.Size(71, 19);
            this.chkFilm.TabIndex = 6;
            this.chkFilm.Text = "Película";
            this.chkFilm.UseVisualStyleBackColor = true;
            this.chkFilm.CheckedChanged += new System.EventHandler(this.chkFilm_CheckedChanged);
            // 
            // grpbMainCoilBatch
            // 
            this.grpbMainCoilBatch.Controls.Add(this.cmbMainCoilListBatch);
            this.grpbMainCoilBatch.Controls.Add(this.lblMainCoilListBatch);
            this.grpbMainCoilBatch.Enabled = false;
            this.grpbMainCoilBatch.Location = new System.Drawing.Point(549, 20);
            this.grpbMainCoilBatch.Name = "grpbMainCoilBatch";
            this.grpbMainCoilBatch.Size = new System.Drawing.Size(204, 86);
            this.grpbMainCoilBatch.TabIndex = 18;
            this.grpbMainCoilBatch.TabStop = false;
            // 
            // cmbMainCoilListBatch
            // 
            this.cmbMainCoilListBatch.FormattingEnabled = true;
            this.cmbMainCoilListBatch.Location = new System.Drawing.Point(43, 36);
            this.cmbMainCoilListBatch.Name = "cmbMainCoilListBatch";
            this.cmbMainCoilListBatch.Size = new System.Drawing.Size(155, 23);
            this.cmbMainCoilListBatch.TabIndex = 1;
            this.cmbMainCoilListBatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMainCoilListBatch_KeyDown);
            // 
            // lblMainCoilListBatch
            // 
            this.lblMainCoilListBatch.AutoSize = true;
            this.lblMainCoilListBatch.Location = new System.Drawing.Point(6, 38);
            this.lblMainCoilListBatch.Name = "lblMainCoilListBatch";
            this.lblMainCoilListBatch.Size = new System.Drawing.Size(31, 15);
            this.lblMainCoilListBatch.TabIndex = 0;
            this.lblMainCoilListBatch.Text = "Lote";
            // 
            // chkLotNumber
            // 
            this.chkLotNumber.Location = new System.Drawing.Point(558, 20);
            this.chkLotNumber.Name = "chkLotNumber";
            this.chkLotNumber.Size = new System.Drawing.Size(51, 19);
            this.chkLotNumber.TabIndex = 6;
            this.chkLotNumber.Text = "Lote";
            this.chkLotNumber.UseVisualStyleBackColor = true;
            this.chkLotNumber.CheckedChanged += new System.EventHandler(this.chkLotNumber_CheckedChanged);
            // 
            // grpbMainCoilDate
            // 
            this.grpbMainCoilDate.Controls.Add(this.dtpMainCoilFinishedDate);
            this.grpbMainCoilDate.Controls.Add(this.dtpMainCoilInitDate);
            this.grpbMainCoilDate.Controls.Add(this.lblMainCoilInitDate);
            this.grpbMainCoilDate.Controls.Add(this.lblMainCoilFinishedDate);
            this.grpbMainCoilDate.Enabled = false;
            this.grpbMainCoilDate.Location = new System.Drawing.Point(756, 20);
            this.grpbMainCoilDate.Name = "grpbMainCoilDate";
            this.grpbMainCoilDate.Size = new System.Drawing.Size(323, 86);
            this.grpbMainCoilDate.TabIndex = 19;
            this.grpbMainCoilDate.TabStop = false;
            // 
            // dtpMainCoilFinishedDate
            // 
            this.dtpMainCoilFinishedDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.dtpMainCoilFinishedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMainCoilFinishedDate.Location = new System.Drawing.Point(50, 51);
            this.dtpMainCoilFinishedDate.Name = "dtpMainCoilFinishedDate";
            this.dtpMainCoilFinishedDate.Size = new System.Drawing.Size(262, 21);
            this.dtpMainCoilFinishedDate.TabIndex = 9;
            // 
            // dtpMainCoilInitDate
            // 
            this.dtpMainCoilInitDate.CustomFormat = "dddd, dd MMMM yyyy HH:mm";
            this.dtpMainCoilInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMainCoilInitDate.Location = new System.Drawing.Point(50, 24);
            this.dtpMainCoilInitDate.Name = "dtpMainCoilInitDate";
            this.dtpMainCoilInitDate.Size = new System.Drawing.Size(262, 21);
            this.dtpMainCoilInitDate.TabIndex = 7;
            // 
            // lblMainCoilInitDate
            // 
            this.lblMainCoilInitDate.AutoSize = true;
            this.lblMainCoilInitDate.Location = new System.Drawing.Point(11, 27);
            this.lblMainCoilInitDate.Name = "lblMainCoilInitDate";
            this.lblMainCoilInitDate.Size = new System.Drawing.Size(36, 15);
            this.lblMainCoilInitDate.TabIndex = 6;
            this.lblMainCoilInitDate.Text = "Inicio";
            // 
            // lblMainCoilFinishedDate
            // 
            this.lblMainCoilFinishedDate.AutoSize = true;
            this.lblMainCoilFinishedDate.Location = new System.Drawing.Point(23, 54);
            this.lblMainCoilFinishedDate.Name = "lblMainCoilFinishedDate";
            this.lblMainCoilFinishedDate.Size = new System.Drawing.Size(24, 15);
            this.lblMainCoilFinishedDate.TabIndex = 8;
            this.lblMainCoilFinishedDate.Text = "Fin";
            // 
            // chkDateRange
            // 
            this.chkDateRange.Location = new System.Drawing.Point(769, 20);
            this.chkDateRange.Name = "chkDateRange";
            this.chkDateRange.Size = new System.Drawing.Size(130, 19);
            this.chkDateRange.TabIndex = 6;
            this.chkDateRange.Text = "Fecha de extrusión";
            this.chkDateRange.UseVisualStyleBackColor = true;
            this.chkDateRange.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
            // 
            // grpbMainCoilFilter
            // 
            this.grpbMainCoilFilter.Controls.Add(this.btnRefresh);
            this.grpbMainCoilFilter.Controls.Add(this.btnMainCoilClose);
            this.grpbMainCoilFilter.Controls.Add(this.btnMainCoilFilters);
            this.grpbMainCoilFilter.Controls.Add(this.btnMainCoilClearFilters);
            this.grpbMainCoilFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbMainCoilFilter.Location = new System.Drawing.Point(0, 460);
            this.grpbMainCoilFilter.Name = "grpbMainCoilFilter";
            this.grpbMainCoilFilter.Size = new System.Drawing.Size(1169, 44);
            this.grpbMainCoilFilter.TabIndex = 20;
            this.grpbMainCoilFilter.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMainCoilCode);
            this.groupBox1.Controls.Add(this.lblMainCoilCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1169, 49);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // txtMainCoilCode
            // 
            this.txtMainCoilCode.Location = new System.Drawing.Point(451, 18);
            this.txtMainCoilCode.Name = "txtMainCoilCode";
            this.txtMainCoilCode.Size = new System.Drawing.Size(287, 21);
            this.txtMainCoilCode.TabIndex = 1;
            this.txtMainCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCoilCode_KeyDown);
            // 
            // lblMainCoilCode
            // 
            this.lblMainCoilCode.AutoSize = true;
            this.lblMainCoilCode.Location = new System.Drawing.Point(302, 21);
            this.lblMainCoilCode.Name = "lblMainCoilCode";
            this.lblMainCoilCode.Size = new System.Drawing.Size(129, 15);
            this.lblMainCoilCode.TabIndex = 0;
            this.lblMainCoilCode.Text = "Código de rollo madre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkLotNumber);
            this.groupBox2.Controls.Add(this.chkDateRange);
            this.groupBox2.Controls.Add(this.grpbMainCoilBatch);
            this.groupBox2.Controls.Add(this.chkFilm);
            this.groupBox2.Controls.Add(this.grpbMainCoilDate);
            this.groupBox2.Controls.Add(this.grpbMainCoilFilm);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 344);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1169, 116);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // clmMainCoilListCodsec
            // 
            this.clmMainCoilListCodsec.HeaderText = "Codsec";
            this.clmMainCoilListCodsec.Name = "clmMainCoilListCodsec";
            this.clmMainCoilListCodsec.ReadOnly = true;
            this.clmMainCoilListCodsec.Visible = false;
            this.clmMainCoilListCodsec.Width = 200;
            // 
            // clmMainCoilListFilm
            // 
            this.clmMainCoilListFilm.HeaderText = "Película";
            this.clmMainCoilListFilm.Name = "clmMainCoilListFilm";
            this.clmMainCoilListFilm.ReadOnly = true;
            this.clmMainCoilListFilm.Width = 60;
            // 
            // clmMainCoilListCode
            // 
            this.clmMainCoilListCode.HeaderText = "Código";
            this.clmMainCoilListCode.Name = "clmMainCoilListCode";
            this.clmMainCoilListCode.ReadOnly = true;
            this.clmMainCoilListCode.Width = 50;
            // 
            // clmMainCoilListBatch
            // 
            this.clmMainCoilListBatch.HeaderText = "Lote";
            this.clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            this.clmMainCoilListBatch.ReadOnly = true;
            this.clmMainCoilListBatch.Width = 50;
            // 
            // clmMainCoilListLabRating
            // 
            this.clmMainCoilListLabRating.HeaderText = "Calif. Lab.";
            this.clmMainCoilListLabRating.Name = "clmMainCoilListLabRating";
            this.clmMainCoilListLabRating.ReadOnly = true;
            this.clmMainCoilListLabRating.Width = 40;
            // 
            // clmMainCoilListInitDate
            // 
            this.clmMainCoilListInitDate.HeaderText = "Fecha Inicio";
            this.clmMainCoilListInitDate.Name = "clmMainCoilListInitDate";
            this.clmMainCoilListInitDate.ReadOnly = true;
            this.clmMainCoilListInitDate.Width = 150;
            // 
            // clmMainCoilListEndDate
            // 
            this.clmMainCoilListEndDate.HeaderText = "Fecha Fin";
            this.clmMainCoilListEndDate.Name = "clmMainCoilListEndDate";
            this.clmMainCoilListEndDate.ReadOnly = true;
            this.clmMainCoilListEndDate.Width = 150;
            // 
            // clmMainCoilListwi
            // 
            this.clmMainCoilListwi.HeaderText = "Ancho";
            this.clmMainCoilListwi.Name = "clmMainCoilListwi";
            this.clmMainCoilListwi.ReadOnly = true;
            this.clmMainCoilListwi.Width = 50;
            // 
            // clmMainCoilListwe
            // 
            this.clmMainCoilListwe.HeaderText = "Peso";
            this.clmMainCoilListwe.Name = "clmMainCoilListwe";
            this.clmMainCoilListwe.ReadOnly = true;
            this.clmMainCoilListwe.Width = 60;
            // 
            // clmMainCoilListmet
            // 
            this.clmMainCoilListmet.HeaderText = "Metraje";
            this.clmMainCoilListmet.Name = "clmMainCoilListmet";
            this.clmMainCoilListmet.ReadOnly = true;
            this.clmMainCoilListmet.Width = 60;
            // 
            // clmMainCoilListrep
            // 
            this.clmMainCoilListrep.HeaderText = "Reposo";
            this.clmMainCoilListrep.Name = "clmMainCoilListrep";
            this.clmMainCoilListrep.ReadOnly = true;
            this.clmMainCoilListrep.Visible = false;
            this.clmMainCoilListrep.Width = 60;
            // 
            // clmMainCoilListGra
            // 
            this.clmMainCoilListGra.HeaderText = "Gramaje";
            this.clmMainCoilListGra.Name = "clmMainCoilListGra";
            this.clmMainCoilListGra.ReadOnly = true;
            this.clmMainCoilListGra.Width = 60;
            // 
            // clmMainCoilListcoftf
            // 
            this.clmMainCoilListcoftf.HeaderText = "Cof CT";
            this.clmMainCoilListcoftf.Name = "clmMainCoilListcoftf";
            this.clmMainCoilListcoftf.ReadOnly = true;
            this.clmMainCoilListcoftf.Width = 50;
            // 
            // clmMainCoilListcofntf
            // 
            this.clmMainCoilListcofntf.HeaderText = "Cof CNT";
            this.clmMainCoilListcofntf.Name = "clmMainCoilListcofntf";
            this.clmMainCoilListcofntf.ReadOnly = true;
            this.clmMainCoilListcofntf.Width = 50;
            // 
            // clmMainCoilListThikness
            // 
            this.clmMainCoilListThikness.HeaderText = "Espesor";
            this.clmMainCoilListThikness.Name = "clmMainCoilListThikness";
            this.clmMainCoilListThikness.ReadOnly = true;
            this.clmMainCoilListThikness.Width = 60;
            // 
            // clmsurfacetensiontf
            // 
            this.clmsurfacetensiontf.HeaderText = "Trat. int.";
            this.clmsurfacetensiontf.Name = "clmsurfacetensiontf";
            this.clmsurfacetensiontf.ReadOnly = true;
            this.clmsurfacetensiontf.Width = 50;
            // 
            // clmsurfacetensionntf
            // 
            this.clmsurfacetensionntf.HeaderText = "Trat. ext.";
            this.clmsurfacetensionntf.Name = "clmsurfacetensionntf";
            this.clmsurfacetensionntf.ReadOnly = true;
            this.clmsurfacetensionntf.Width = 50;
            // 
            // clmMainCoilListQuality
            // 
            this.clmMainCoilListQuality.HeaderText = "";
            this.clmMainCoilListQuality.Name = "clmMainCoilListQuality";
            this.clmMainCoilListQuality.ReadOnly = true;
            this.clmMainCoilListQuality.Width = 25;
            // 
            // clmMainCoilListQualityReport
            // 
            this.clmMainCoilListQualityReport.HeaderText = "";
            this.clmMainCoilListQualityReport.Name = "clmMainCoilListQualityReport";
            this.clmMainCoilListQualityReport.ReadOnly = true;
            this.clmMainCoilListQualityReport.Width = 25;
            // 
            // clmMainCoilListLabel
            // 
            this.clmMainCoilListLabel.HeaderText = "";
            this.clmMainCoilListLabel.Name = "clmMainCoilListLabel";
            this.clmMainCoilListLabel.ReadOnly = true;
            this.clmMainCoilListLabel.Width = 25;
            // 
            // clmMainCoilListDelete
            // 
            this.clmMainCoilListDelete.HeaderText = "";
            this.clmMainCoilListDelete.Name = "clmMainCoilListDelete";
            this.clmMainCoilListDelete.ReadOnly = true;
            this.clmMainCoilListDelete.Visible = false;
            this.clmMainCoilListDelete.Width = 25;
            // 
            // clmMainCoilSecundaryProperties
            // 
            this.clmMainCoilSecundaryProperties.HeaderText = "";
            this.clmMainCoilSecundaryProperties.Name = "clmMainCoilSecundaryProperties";
            this.clmMainCoilSecundaryProperties.ReadOnly = true;
            this.clmMainCoilSecundaryProperties.Visible = false;
            this.clmMainCoilSecundaryProperties.Width = 30;
            // 
            // clmMainCoilLabel
            // 
            this.clmMainCoilLabel.HeaderText = "";
            this.clmMainCoilLabel.Name = "clmMainCoilLabel";
            this.clmMainCoilLabel.ReadOnly = true;
            this.clmMainCoilLabel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMainCoilLabel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmMainCoilLabel.Width = 25;
            // 
            // frmMainCoilList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1169, 504);
            this.Controls.Add(this.grpbMainCoilList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbMainCoilFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilList";
            this.Text = "Lista Rollos Madres";
            this.Load += new System.EventHandler(this.frmMainCoilList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.grpbMainCoilList.ResumeLayout(false);
            this.grpbMainCoilFilm.ResumeLayout(false);
            this.grpbMainCoilFilm.PerformLayout();
            this.grpbMainCoilBatch.ResumeLayout(false);
            this.grpbMainCoilBatch.PerformLayout();
            this.grpbMainCoilDate.ResumeLayout(false);
            this.grpbMainCoilDate.PerformLayout();
            this.grpbMainCoilFilter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.GroupBox grpbMainCoilList;
        private System.Windows.Forms.Button btnMainCoilClose;
        private System.Windows.Forms.GroupBox grpbMainCoilFilm;
        private System.Windows.Forms.Button btnMainCoilFilters;
        private System.Windows.Forms.Button btnMainCoilClearFilters;
        private System.Windows.Forms.ComboBox cmbMainCoilListFilm;
        private System.Windows.Forms.Label lblMainCoilListFilm;
        private System.Windows.Forms.GroupBox grpbMainCoilBatch;
        private System.Windows.Forms.ComboBox cmbMainCoilListBatch;
        private System.Windows.Forms.Label lblMainCoilListBatch;
        private System.Windows.Forms.GroupBox grpbMainCoilDate;
        private System.Windows.Forms.DateTimePicker dtpMainCoilFinishedDate;
        private System.Windows.Forms.DateTimePicker dtpMainCoilInitDate;
        private System.Windows.Forms.Label lblMainCoilInitDate;
        private System.Windows.Forms.Label lblMainCoilFinishedDate;
        private System.Windows.Forms.GroupBox grpbMainCoilFilter;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox chkFilm;
        private System.Windows.Forms.CheckBox chkLotNumber;
        private System.Windows.Forms.CheckBox chkDateRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMainCoilCode;
        private System.Windows.Forms.Label lblMainCoilCode;
        private System.Windows.Forms.ToolTip ttpMainCoilList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListLabRating;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListwi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListwe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListmet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListGra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListcoftf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListcofntf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListThikness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsurfacetensiontf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsurfacetensionntf;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListQuality;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListQualityReport;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListLabel;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilListDelete;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilSecundaryProperties;
        private System.Windows.Forms.DataGridViewImageColumn clmMainCoilLabel;
    }
}