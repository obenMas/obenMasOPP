namespace BPS
{
    partial class frmBoppWeigthParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoppWeigthParameter));
            this.ttpWeitghFilmBopp = new System.Windows.Forms.ToolTip(this.components);
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.btnMainCoilSave = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.btnExitParameters = new System.Windows.Forms.Button();
            this.btnSaveParameters = new System.Windows.Forms.Button();
            this.btnCancelParameters = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpWeigthParameter = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvParametersByFilm = new System.Windows.Forms.DataGridView();
            this.grpbAction = new System.Windows.Forms.GroupBox();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.txtPCM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbFilm = new System.Windows.Forms.GroupBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.tbpWeigthBackup = new System.Windows.Forms.TabPage();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvParameters = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBoppCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoreCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigthFactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWeigthFactor = new System.Windows.Forms.TextBox();
            this.lblCore = new System.Windows.Forms.Label();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWeifthFactor = new System.Windows.Forms.Label();
            this.lblCoreLabel = new System.Windows.Forms.Label();
            this.lblDiameterLabel = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblFilmNameLabel = new System.Windows.Forms.Label();
            this.clmcodsecparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkdiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkcore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdiameterparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdiameternameparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcoreparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmweigthparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbpWeigthParameter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametersByFilm)).BeginInit();
            this.grpbAction.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            this.grpbFilm.SuspendLayout();
            this.tbpWeigthBackup.SuspendLayout();
            this.grpbMainCoilButtons.SuspendLayout();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).BeginInit();
            this.grpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(55, 14);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 35;
            this.ttpWeitghFilmBopp.SetToolTip(this.btnMainCoilExit, "Salir Peso Películas Bopp");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            // 
            // btnMainCoilSave
            // 
            this.btnMainCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilSave.BackgroundImage")));
            this.btnMainCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilSave.Location = new System.Drawing.Point(5, 14);
            this.btnMainCoilSave.Name = "btnMainCoilSave";
            this.btnMainCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilSave.TabIndex = 33;
            this.ttpWeitghFilmBopp.SetToolTip(this.btnMainCoilSave, "Guardar Peso Películas Bopp");
            this.btnMainCoilSave.UseVisualStyleBackColor = true;
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(30, 14);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 34;
            this.ttpWeitghFilmBopp.SetToolTip(this.btnMainCoilCancel, "Cancelar Peso Pelíclas Bopp");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            // 
            // btnExitParameters
            // 
            this.btnExitParameters.Image = global::BPS.Properties.Resources.door_in;
            this.btnExitParameters.Location = new System.Drawing.Point(809, 12);
            this.btnExitParameters.Name = "btnExitParameters";
            this.btnExitParameters.Size = new System.Drawing.Size(25, 25);
            this.btnExitParameters.TabIndex = 38;
            this.ttpWeitghFilmBopp.SetToolTip(this.btnExitParameters, "Salir Peso Películas Bopp");
            this.btnExitParameters.UseVisualStyleBackColor = true;
            this.btnExitParameters.Click += new System.EventHandler(this.btnExitParameters_Click);
            // 
            // btnSaveParameters
            // 
            this.btnSaveParameters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveParameters.BackgroundImage")));
            this.btnSaveParameters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveParameters.Location = new System.Drawing.Point(759, 12);
            this.btnSaveParameters.Name = "btnSaveParameters";
            this.btnSaveParameters.Size = new System.Drawing.Size(25, 25);
            this.btnSaveParameters.TabIndex = 36;
            this.ttpWeitghFilmBopp.SetToolTip(this.btnSaveParameters, "Guardar Peso Películas Bopp");
            this.btnSaveParameters.UseVisualStyleBackColor = true;
            this.btnSaveParameters.Click += new System.EventHandler(this.btnSaveParameters_Click);
            // 
            // btnCancelParameters
            // 
            this.btnCancelParameters.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelParameters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelParameters.Location = new System.Drawing.Point(784, 12);
            this.btnCancelParameters.Name = "btnCancelParameters";
            this.btnCancelParameters.Size = new System.Drawing.Size(25, 25);
            this.btnCancelParameters.TabIndex = 37;
            this.ttpWeitghFilmBopp.SetToolTip(this.btnCancelParameters, "Cancelar Peso Pelíclas Bopp");
            this.btnCancelParameters.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpWeigthParameter);
            this.tabControl1.Controls.Add(this.tbpWeigthBackup);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(854, 524);
            this.tabControl1.TabIndex = 1;
            // 
            // tbpWeigthParameter
            // 
            this.tbpWeigthParameter.Controls.Add(this.groupBox1);
            this.tbpWeigthParameter.Controls.Add(this.grpbAction);
            this.tbpWeigthParameter.Controls.Add(this.grpbDetail);
            this.tbpWeigthParameter.Controls.Add(this.grpbFilm);
            this.tbpWeigthParameter.Location = new System.Drawing.Point(4, 24);
            this.tbpWeigthParameter.Name = "tbpWeigthParameter";
            this.tbpWeigthParameter.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWeigthParameter.Size = new System.Drawing.Size(846, 496);
            this.tbpWeigthParameter.TabIndex = 0;
            this.tbpWeigthParameter.Text = "Pesos x Centímetros";
            this.tbpWeigthParameter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvParametersByFilm);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 356);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // dgvParametersByFilm
            // 
            this.dgvParametersByFilm.AllowUserToAddRows = false;
            this.dgvParametersByFilm.AllowUserToDeleteRows = false;
            this.dgvParametersByFilm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametersByFilm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsecparameter,
            this.clmfkdiameter,
            this.clmfkcore,
            this.clmFilmparameter,
            this.clmdiameterparameter,
            this.clmdiameternameparameter,
            this.clmcoreparameter,
            this.clmweigthparameter});
            this.dgvParametersByFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParametersByFilm.Location = new System.Drawing.Point(3, 17);
            this.dgvParametersByFilm.Name = "dgvParametersByFilm";
            this.dgvParametersByFilm.ReadOnly = true;
            this.dgvParametersByFilm.Size = new System.Drawing.Size(834, 336);
            this.dgvParametersByFilm.TabIndex = 0;
            // 
            // grpbAction
            // 
            this.grpbAction.Controls.Add(this.btnExitParameters);
            this.grpbAction.Controls.Add(this.btnSaveParameters);
            this.grpbAction.Controls.Add(this.btnCancelParameters);
            this.grpbAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbAction.Location = new System.Drawing.Point(3, 452);
            this.grpbAction.Name = "grpbAction";
            this.grpbAction.Size = new System.Drawing.Size(840, 41);
            this.grpbAction.TabIndex = 2;
            this.grpbAction.TabStop = false;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.txtPCM);
            this.grpbDetail.Controls.Add(this.label1);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Location = new System.Drawing.Point(3, 47);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(840, 49);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            // 
            // txtPCM
            // 
            this.txtPCM.Location = new System.Drawing.Point(427, 18);
            this.txtPCM.Name = "txtPCM";
            this.txtPCM.Size = new System.Drawing.Size(100, 21);
            this.txtPCM.TabIndex = 1;
            this.txtPCM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPCM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso x Centímetro";
            // 
            // grpbFilm
            // 
            this.grpbFilm.Controls.Add(this.cmbFilm);
            this.grpbFilm.Controls.Add(this.lblFilm);
            this.grpbFilm.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilm.Location = new System.Drawing.Point(3, 3);
            this.grpbFilm.Name = "grpbFilm";
            this.grpbFilm.Size = new System.Drawing.Size(840, 44);
            this.grpbFilm.TabIndex = 0;
            this.grpbFilm.TabStop = false;
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(324, 14);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(252, 23);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(264, 17);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(54, 15);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Película ";
            // 
            // tbpWeigthBackup
            // 
            this.tbpWeigthBackup.Controls.Add(this.grpbEmpty);
            this.tbpWeigthBackup.Controls.Add(this.grpbMainCoilButtons);
            this.tbpWeigthBackup.Controls.Add(this.grpbList);
            this.tbpWeigthBackup.Controls.Add(this.grpbInfo);
            this.tbpWeigthBackup.Location = new System.Drawing.Point(4, 24);
            this.tbpWeigthBackup.Name = "tbpWeigthBackup";
            this.tbpWeigthBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tbpWeigthBackup.Size = new System.Drawing.Size(846, 496);
            this.tbpWeigthBackup.TabIndex = 1;
            this.tbpWeigthBackup.Text = "Peso x Centimetro";
            this.tbpWeigthBackup.UseVisualStyleBackColor = true;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(65, 393);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(633, 44);
            this.grpbEmpty.TabIndex = 11;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilExit);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilSave);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(704, 393);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(84, 44);
            this.grpbMainCoilButtons.TabIndex = 10;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvParameters);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(3, 89);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(840, 251);
            this.grpbList.TabIndex = 8;
            this.grpbList.TabStop = false;
            this.grpbList.Text = "Listado de peliculas";
            // 
            // dgvParameters
            // 
            this.dgvParameters.AllowUserToAddRows = false;
            this.dgvParameters.AllowUserToDeleteRows = false;
            this.dgvParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmBoppCodsec,
            this.clmDiameterCodsec,
            this.clmCoreCodsec,
            this.clmFilmName,
            this.clmDiameter,
            this.clmCore,
            this.clmWeigthFactor,
            this.clmLength});
            this.dgvParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParameters.Location = new System.Drawing.Point(3, 17);
            this.dgvParameters.Name = "dgvParameters";
            this.dgvParameters.ReadOnly = true;
            this.dgvParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParameters.Size = new System.Drawing.Size(834, 231);
            this.dgvParameters.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmBoppCodsec
            // 
            this.clmBoppCodsec.HeaderText = "BoppCodsec";
            this.clmBoppCodsec.Name = "clmBoppCodsec";
            this.clmBoppCodsec.ReadOnly = true;
            this.clmBoppCodsec.Visible = false;
            // 
            // clmDiameterCodsec
            // 
            this.clmDiameterCodsec.HeaderText = "DiameterCodsec";
            this.clmDiameterCodsec.Name = "clmDiameterCodsec";
            this.clmDiameterCodsec.ReadOnly = true;
            this.clmDiameterCodsec.Visible = false;
            // 
            // clmCoreCodsec
            // 
            this.clmCoreCodsec.HeaderText = "CoreCodsec";
            this.clmCoreCodsec.Name = "clmCoreCodsec";
            this.clmCoreCodsec.ReadOnly = true;
            this.clmCoreCodsec.Visible = false;
            // 
            // clmFilmName
            // 
            this.clmFilmName.HeaderText = "Película";
            this.clmFilmName.Name = "clmFilmName";
            this.clmFilmName.ReadOnly = true;
            this.clmFilmName.Width = 250;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            // 
            // clmWeigthFactor
            // 
            this.clmWeigthFactor.HeaderText = "Peso x cm";
            this.clmWeigthFactor.Name = "clmWeigthFactor";
            this.clmWeigthFactor.ReadOnly = true;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Longitud";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.txtCode);
            this.grpbInfo.Controls.Add(this.lblCode);
            this.grpbInfo.Controls.Add(this.txtLength);
            this.grpbInfo.Controls.Add(this.txtWeigthFactor);
            this.grpbInfo.Controls.Add(this.lblCore);
            this.grpbInfo.Controls.Add(this.lblDiameter);
            this.grpbInfo.Controls.Add(this.lblLength);
            this.grpbInfo.Controls.Add(this.lblWeifthFactor);
            this.grpbInfo.Controls.Add(this.lblCoreLabel);
            this.grpbInfo.Controls.Add(this.lblDiameterLabel);
            this.grpbInfo.Controls.Add(this.lblFilmName);
            this.grpbInfo.Controls.Add(this.lblFilmNameLabel);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfo.Location = new System.Drawing.Point(3, 3);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(840, 86);
            this.grpbInfo.TabIndex = 9;
            this.grpbInfo.TabStop = false;
            this.grpbInfo.Text = "Información";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(595, 23);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 21);
            this.txtCode.TabIndex = 18;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(534, 26);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 17;
            this.lblCode.Text = "Código";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(595, 52);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 21);
            this.txtLength.TabIndex = 16;
            // 
            // txtWeigthFactor
            // 
            this.txtWeigthFactor.Location = new System.Drawing.Point(428, 52);
            this.txtWeigthFactor.Name = "txtWeigthFactor";
            this.txtWeigthFactor.Size = new System.Drawing.Size(100, 21);
            this.txtWeigthFactor.TabIndex = 16;
            // 
            // lblCore
            // 
            this.lblCore.BackColor = System.Drawing.SystemColors.Window;
            this.lblCore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCore.Location = new System.Drawing.Point(244, 52);
            this.lblCore.Name = "lblCore";
            this.lblCore.Size = new System.Drawing.Size(108, 21);
            this.lblCore.TabIndex = 14;
            this.lblCore.Tag = "clearOnReload";
            this.lblCore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiameter
            // 
            this.lblDiameter.BackColor = System.Drawing.SystemColors.Window;
            this.lblDiameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiameter.Location = new System.Drawing.Point(91, 52);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(108, 21);
            this.lblDiameter.TabIndex = 15;
            this.lblDiameter.Tag = "clearOnReload";
            this.lblDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(534, 55);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(55, 15);
            this.lblLength.TabIndex = 13;
            this.lblLength.Text = "Longitud";
            // 
            // lblWeifthFactor
            // 
            this.lblWeifthFactor.AutoSize = true;
            this.lblWeifthFactor.Location = new System.Drawing.Point(358, 55);
            this.lblWeifthFactor.Name = "lblWeifthFactor";
            this.lblWeifthFactor.Size = new System.Drawing.Size(64, 15);
            this.lblWeifthFactor.TabIndex = 13;
            this.lblWeifthFactor.Text = "Peso x cm";
            // 
            // lblCoreLabel
            // 
            this.lblCoreLabel.AutoSize = true;
            this.lblCoreLabel.Location = new System.Drawing.Point(205, 55);
            this.lblCoreLabel.Name = "lblCoreLabel";
            this.lblCoreLabel.Size = new System.Drawing.Size(33, 15);
            this.lblCoreLabel.TabIndex = 13;
            this.lblCoreLabel.Text = "Core";
            // 
            // lblDiameterLabel
            // 
            this.lblDiameterLabel.AutoSize = true;
            this.lblDiameterLabel.Location = new System.Drawing.Point(24, 55);
            this.lblDiameterLabel.Name = "lblDiameterLabel";
            this.lblDiameterLabel.Size = new System.Drawing.Size(58, 15);
            this.lblDiameterLabel.TabIndex = 12;
            this.lblDiameterLabel.Text = "Diametro";
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Location = new System.Drawing.Point(91, 23);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(437, 21);
            this.lblFilmName.TabIndex = 11;
            this.lblFilmName.Tag = "clearOnReload";
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilmNameLabel
            // 
            this.lblFilmNameLabel.AutoSize = true;
            this.lblFilmNameLabel.Location = new System.Drawing.Point(24, 26);
            this.lblFilmNameLabel.Name = "lblFilmNameLabel";
            this.lblFilmNameLabel.Size = new System.Drawing.Size(51, 15);
            this.lblFilmNameLabel.TabIndex = 10;
            this.lblFilmNameLabel.Text = "Película";
            // 
            // clmcodsecparameter
            // 
            this.clmcodsecparameter.HeaderText = "";
            this.clmcodsecparameter.Name = "clmcodsecparameter";
            this.clmcodsecparameter.ReadOnly = true;
            this.clmcodsecparameter.Visible = false;
            // 
            // clmfkdiameter
            // 
            this.clmfkdiameter.HeaderText = "";
            this.clmfkdiameter.Name = "clmfkdiameter";
            this.clmfkdiameter.ReadOnly = true;
            this.clmfkdiameter.Visible = false;
            // 
            // clmfkcore
            // 
            this.clmfkcore.HeaderText = "";
            this.clmfkcore.Name = "clmfkcore";
            this.clmfkcore.ReadOnly = true;
            this.clmfkcore.Visible = false;
            // 
            // clmFilmparameter
            // 
            this.clmFilmparameter.HeaderText = "Película";
            this.clmFilmparameter.Name = "clmFilmparameter";
            this.clmFilmparameter.ReadOnly = true;
            // 
            // clmdiameterparameter
            // 
            this.clmdiameterparameter.HeaderText = "Long. Diametro";
            this.clmdiameterparameter.Name = "clmdiameterparameter";
            this.clmdiameterparameter.ReadOnly = true;
            this.clmdiameterparameter.Width = 120;
            // 
            // clmdiameternameparameter
            // 
            this.clmdiameternameparameter.HeaderText = "Nom. Diametro";
            this.clmdiameternameparameter.Name = "clmdiameternameparameter";
            this.clmdiameternameparameter.ReadOnly = true;
            this.clmdiameternameparameter.Width = 120;
            // 
            // clmcoreparameter
            // 
            this.clmcoreparameter.HeaderText = "Core";
            this.clmcoreparameter.Name = "clmcoreparameter";
            this.clmcoreparameter.ReadOnly = true;
            // 
            // clmweigthparameter
            // 
            this.clmweigthparameter.HeaderText = "Peso x cm";
            this.clmweigthparameter.Name = "clmweigthparameter";
            this.clmweigthparameter.ReadOnly = true;
            // 
            // frmBoppWeigthParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(854, 524);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBoppWeigthParameter";
            this.Text = "Parámetros de peso para películas Bopp";
            this.Load += new System.EventHandler(this.frmBoppWeigthParameter_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpWeigthParameter.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametersByFilm)).EndInit();
            this.grpbAction.ResumeLayout(false);
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            this.grpbFilm.ResumeLayout(false);
            this.grpbFilm.PerformLayout();
            this.tbpWeigthBackup.ResumeLayout(false);
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParameters)).EndInit();
            this.grpbInfo.ResumeLayout(false);
            this.grpbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttpWeitghFilmBopp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpWeigthParameter;
        private System.Windows.Forms.TabPage tbpWeigthBackup;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.Button btnMainCoilSave;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBoppCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoreCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigthFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWeigthFactor;
        private System.Windows.Forms.Label lblCore;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWeifthFactor;
        private System.Windows.Forms.Label lblCoreLabel;
        private System.Windows.Forms.Label lblDiameterLabel;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblFilmNameLabel;
        private System.Windows.Forms.GroupBox grpbFilm;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbAction;
        private System.Windows.Forms.Button btnExitParameters;
        private System.Windows.Forms.Button btnSaveParameters;
        private System.Windows.Forms.Button btnCancelParameters;
        private System.Windows.Forms.DataGridView dgvParametersByFilm;
        private System.Windows.Forms.TextBox txtPCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsecparameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkdiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkcore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmparameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdiameterparameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdiameternameparameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcoreparameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmweigthparameter;
    }
}