namespace BPS
{
    partial class frmCoilEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilEditor));
            this.tbcCoil = new System.Windows.Forms.TabControl();
            this.tbpCoilInfo = new System.Windows.Forms.TabPage();
            this.rdoQ = new System.Windows.Forms.RadioButton();
            this.rdbTT = new System.Windows.Forms.RadioButton();
            this.txtGrossWeigth = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblTreatmentSide = new System.Windows.Forms.Label();
            this.rdoTreatmentWithout = new System.Windows.Forms.RadioButton();
            this.rdoTreatmentDouble = new System.Windows.Forms.RadioButton();
            this.rdoTreatmentInner = new System.Windows.Forms.RadioButton();
            this.rdoTreatmentExternal = new System.Windows.Forms.RadioButton();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPositionLabel = new System.Windows.Forms.Label();
            this.lblFulmNameLabel = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblStops = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblWidthLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblQualityLabel = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.grpbDefects = new System.Windows.Forms.GroupBox();
            this.chkDefect1 = new System.Windows.Forms.CheckBox();
            this.chkDefect2 = new System.Windows.Forms.CheckBox();
            this.chkDefect3 = new System.Windows.Forms.CheckBox();
            this.chkDefect4 = new System.Windows.Forms.CheckBox();
            this.chkDefect5 = new System.Windows.Forms.CheckBox();
            this.chkDefect6 = new System.Windows.Forms.CheckBox();
            this.chkDefect7 = new System.Windows.Forms.CheckBox();
            this.chkDefect8 = new System.Windows.Forms.CheckBox();
            this.chkDefect9 = new System.Windows.Forms.CheckBox();
            this.chkDefect10 = new System.Windows.Forms.CheckBox();
            this.chkDefect11 = new System.Windows.Forms.CheckBox();
            this.chkDefect12 = new System.Windows.Forms.CheckBox();
            this.chkDefect13 = new System.Windows.Forms.CheckBox();
            this.chkDefect14 = new System.Windows.Forms.CheckBox();
            this.chkDefect15 = new System.Windows.Forms.CheckBox();
            this.chkDefect16 = new System.Windows.Forms.CheckBox();
            this.grpbDestiny = new System.Windows.Forms.GroupBox();
            this.lblCoilCellarLabel = new System.Windows.Forms.Label();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblCoilCellar = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblCustomerLabel = new System.Windows.Forms.Label();
            this.lblSalesOrderNumber = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLengthLabel = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblGrossWeigthLabel = new System.Windows.Forms.Label();
            this.lblDensityLabel = new System.Windows.Forms.Label();
            this.lblBalanceLabel = new System.Windows.Forms.Label();
            this.lblDiameterLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInProcessReworkDetail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInProcessUsefulWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbInProcessRework = new System.Windows.Forms.ComboBox();
            this.cmbInProcessDestination = new System.Windows.Forms.ComboBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.grpb = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilUsedLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnCoilSave = new System.Windows.Forms.Button();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.ttpCoilDetail = new System.Windows.Forms.ToolTip(this.components);
            this.tbcCoil.SuspendLayout();
            this.tbpCoilInfo.SuspendLayout();
            this.grpbDefects.SuspendLayout();
            this.grpbDestiny.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            this.grpb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcCoil
            // 
            this.tbcCoil.Controls.Add(this.tbpCoilInfo);
            this.tbcCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCoil.Location = new System.Drawing.Point(0, 0);
            this.tbcCoil.Name = "tbcCoil";
            this.tbcCoil.SelectedIndex = 0;
            this.tbcCoil.Size = new System.Drawing.Size(748, 568);
            this.tbcCoil.TabIndex = 0;
            // 
            // tbpCoilInfo
            // 
            this.tbpCoilInfo.BackColor = System.Drawing.SystemColors.Window;
            this.tbpCoilInfo.Controls.Add(this.rdoQ);
            this.tbpCoilInfo.Controls.Add(this.rdbTT);
            this.tbpCoilInfo.Controls.Add(this.txtGrossWeigth);
            this.tbpCoilInfo.Controls.Add(this.lblNetWeigth);
            this.tbpCoilInfo.Controls.Add(this.cmbQuality);
            this.tbpCoilInfo.Controls.Add(this.txtLength);
            this.tbpCoilInfo.Controls.Add(this.txtDiameter);
            this.tbpCoilInfo.Controls.Add(this.lblCode);
            this.tbpCoilInfo.Controls.Add(this.lblTreatmentSide);
            this.tbpCoilInfo.Controls.Add(this.rdoTreatmentWithout);
            this.tbpCoilInfo.Controls.Add(this.rdoTreatmentDouble);
            this.tbpCoilInfo.Controls.Add(this.rdoTreatmentInner);
            this.tbpCoilInfo.Controls.Add(this.rdoTreatmentExternal);
            this.tbpCoilInfo.Controls.Add(this.lblStop);
            this.tbpCoilInfo.Controls.Add(this.lblPosition);
            this.tbpCoilInfo.Controls.Add(this.lblPositionLabel);
            this.tbpCoilInfo.Controls.Add(this.lblFulmNameLabel);
            this.tbpCoilInfo.Controls.Add(this.lblFilmName);
            this.tbpCoilInfo.Controls.Add(this.lblStops);
            this.tbpCoilInfo.Controls.Add(this.lblWidth);
            this.tbpCoilInfo.Controls.Add(this.lblWidthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblCodeLabel);
            this.tbpCoilInfo.Controls.Add(this.lblQualityLabel);
            this.tbpCoilInfo.Controls.Add(this.lblDensity);
            this.tbpCoilInfo.Controls.Add(this.grpbDefects);
            this.tbpCoilInfo.Controls.Add(this.grpbDestiny);
            this.tbpCoilInfo.Controls.Add(this.lblBalance);
            this.tbpCoilInfo.Controls.Add(this.lblLengthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblNetWeigthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblGrossWeigthLabel);
            this.tbpCoilInfo.Controls.Add(this.lblDensityLabel);
            this.tbpCoilInfo.Controls.Add(this.lblBalanceLabel);
            this.tbpCoilInfo.Controls.Add(this.lblDiameterLabel);
            this.tbpCoilInfo.Controls.Add(this.groupBox1);
            this.tbpCoilInfo.Controls.Add(this.grpbNotes);
            this.tbpCoilInfo.Controls.Add(this.grpb);
            this.tbpCoilInfo.Controls.Add(this.grpbEmpty);
            this.tbpCoilInfo.Controls.Add(this.grpbMainCoilButtons);
            this.tbpCoilInfo.Location = new System.Drawing.Point(4, 24);
            this.tbpCoilInfo.Name = "tbpCoilInfo";
            this.tbpCoilInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoilInfo.Size = new System.Drawing.Size(740, 540);
            this.tbpCoilInfo.TabIndex = 1;
            this.tbpCoilInfo.Text = "Información de bobina";
            // 
            // rdoQ
            // 
            this.rdoQ.AutoSize = true;
            this.rdoQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQ.Location = new System.Drawing.Point(432, 161);
            this.rdoQ.Name = "rdoQ";
            this.rdoQ.Size = new System.Drawing.Size(34, 19);
            this.rdoQ.TabIndex = 83;
            this.rdoQ.Text = "Q";
            this.rdoQ.UseVisualStyleBackColor = true;
            // 
            // rdbTT
            // 
            this.rdbTT.AutoSize = true;
            this.rdbTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTT.Location = new System.Drawing.Point(389, 161);
            this.rdbTT.Name = "rdbTT";
            this.rdbTT.Size = new System.Drawing.Size(39, 19);
            this.rdbTT.TabIndex = 82;
            this.rdbTT.Text = "TT";
            this.rdbTT.UseVisualStyleBackColor = true;
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(329, 90);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(123, 21);
            this.txtGrossWeigth.TabIndex = 81;
            this.txtGrossWeigth.Tag = "clearOnReload";
            this.txtGrossWeigth.Text = "0";
            this.txtGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(103, 90);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(123, 21);
            this.lblNetWeigth.TabIndex = 80;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbQuality
            // 
            this.cmbQuality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbQuality.Enabled = false;
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(329, 134);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(123, 23);
            this.cmbQuality.TabIndex = 72;
            // 
            // txtLength
            // 
            this.txtLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(103, 114);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(123, 21);
            this.txtLength.TabIndex = 66;
            this.txtLength.Text = "0";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiameter
            // 
            this.txtDiameter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiameter.Location = new System.Drawing.Point(103, 64);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(123, 21);
            this.txtDiameter.TabIndex = 60;
            this.txtDiameter.Text = "0";
            this.txtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCode
            // 
            this.lblCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Enabled = false;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(103, 10);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(349, 21);
            this.lblCode.TabIndex = 52;
            this.lblCode.Tag = "clearOnReload";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTreatmentSide
            // 
            this.lblTreatmentSide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTreatmentSide.AutoSize = true;
            this.lblTreatmentSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentSide.Location = new System.Drawing.Point(8, 163);
            this.lblTreatmentSide.Name = "lblTreatmentSide";
            this.lblTreatmentSide.Size = new System.Drawing.Size(73, 15);
            this.lblTreatmentSide.TabIndex = 74;
            this.lblTreatmentSide.Text = "Tratamiento";
            // 
            // rdoTreatmentWithout
            // 
            this.rdoTreatmentWithout.AutoSize = true;
            this.rdoTreatmentWithout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentWithout.Location = new System.Drawing.Point(280, 161);
            this.rdoTreatmentWithout.Name = "rdoTreatmentWithout";
            this.rdoTreatmentWithout.Size = new System.Drawing.Size(108, 19);
            this.rdoTreatmentWithout.TabIndex = 78;
            this.rdoTreatmentWithout.Text = "Sin tratamiento";
            this.rdoTreatmentWithout.UseVisualStyleBackColor = true;
            // 
            // rdoTreatmentDouble
            // 
            this.rdoTreatmentDouble.AutoSize = true;
            this.rdoTreatmentDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentDouble.Location = new System.Drawing.Point(221, 161);
            this.rdoTreatmentDouble.Name = "rdoTreatmentDouble";
            this.rdoTreatmentDouble.Size = new System.Drawing.Size(58, 19);
            this.rdoTreatmentDouble.TabIndex = 77;
            this.rdoTreatmentDouble.Text = "Doble";
            this.rdoTreatmentDouble.UseVisualStyleBackColor = true;
            // 
            // rdoTreatmentInner
            // 
            this.rdoTreatmentInner.AutoSize = true;
            this.rdoTreatmentInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentInner.Location = new System.Drawing.Point(153, 161);
            this.rdoTreatmentInner.Name = "rdoTreatmentInner";
            this.rdoTreatmentInner.Size = new System.Drawing.Size(63, 19);
            this.rdoTreatmentInner.TabIndex = 76;
            this.rdoTreatmentInner.Text = "Interno";
            this.rdoTreatmentInner.UseVisualStyleBackColor = true;
            // 
            // rdoTreatmentExternal
            // 
            this.rdoTreatmentExternal.AutoSize = true;
            this.rdoTreatmentExternal.Checked = true;
            this.rdoTreatmentExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentExternal.Location = new System.Drawing.Point(83, 161);
            this.rdoTreatmentExternal.Name = "rdoTreatmentExternal";
            this.rdoTreatmentExternal.Size = new System.Drawing.Size(67, 19);
            this.rdoTreatmentExternal.TabIndex = 75;
            this.rdoTreatmentExternal.TabStop = true;
            this.rdoTreatmentExternal.Text = "Externo";
            this.rdoTreatmentExternal.UseVisualStyleBackColor = true;
            // 
            // lblStop
            // 
            this.lblStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStop.BackColor = System.Drawing.SystemColors.Window;
            this.lblStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(214, 36);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(45, 21);
            this.lblStop.TabIndex = 56;
            this.lblStop.Tag = "clearOnReload";
            this.lblStop.Text = "0";
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPosition.BackColor = System.Drawing.SystemColors.Window;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(103, 36);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(45, 21);
            this.lblPosition.TabIndex = 54;
            this.lblPosition.Tag = "clearOnReload";
            this.lblPosition.Text = "0";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPositionLabel
            // 
            this.lblPositionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPositionLabel.AutoSize = true;
            this.lblPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionLabel.Location = new System.Drawing.Point(10, 39);
            this.lblPositionLabel.Name = "lblPositionLabel";
            this.lblPositionLabel.Size = new System.Drawing.Size(54, 15);
            this.lblPositionLabel.TabIndex = 53;
            this.lblPositionLabel.Text = "Posición";
            // 
            // lblFulmNameLabel
            // 
            this.lblFulmNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFulmNameLabel.AutoSize = true;
            this.lblFulmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulmNameLabel.Location = new System.Drawing.Point(265, 39);
            this.lblFulmNameLabel.Name = "lblFulmNameLabel";
            this.lblFulmNameLabel.Size = new System.Drawing.Size(56, 15);
            this.lblFulmNameLabel.TabIndex = 57;
            this.lblFulmNameLabel.Text = "Producto";
            // 
            // lblFilmName
            // 
            this.lblFilmName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(329, 36);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(123, 21);
            this.lblFilmName.TabIndex = 58;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStops
            // 
            this.lblStops.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStops.AutoSize = true;
            this.lblStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStops.Location = new System.Drawing.Point(151, 39);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(57, 15);
            this.lblStops.TabIndex = 55;
            this.lblStops.Text = "Parada #";
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(103, 137);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(123, 21);
            this.lblWidth.TabIndex = 70;
            this.lblWidth.Tag = "clearOnReload";
            this.lblWidth.Text = "0";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWidthLabel
            // 
            this.lblWidthLabel.AutoSize = true;
            this.lblWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthLabel.Location = new System.Drawing.Point(10, 137);
            this.lblWidthLabel.Name = "lblWidthLabel";
            this.lblWidthLabel.Size = new System.Drawing.Size(41, 15);
            this.lblWidthLabel.TabIndex = 69;
            this.lblWidthLabel.Text = "Ancho";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(8, 13);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(46, 15);
            this.lblCodeLabel.TabIndex = 51;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblQualityLabel
            // 
            this.lblQualityLabel.AutoSize = true;
            this.lblQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualityLabel.Location = new System.Drawing.Point(256, 137);
            this.lblQualityLabel.Name = "lblQualityLabel";
            this.lblQualityLabel.Size = new System.Drawing.Size(49, 15);
            this.lblQualityLabel.TabIndex = 71;
            this.lblQualityLabel.Text = "Calidad";
            // 
            // lblDensity
            // 
            this.lblDensity.BackColor = System.Drawing.SystemColors.Window;
            this.lblDensity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensity.Location = new System.Drawing.Point(329, 64);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(123, 21);
            this.lblDensity.TabIndex = 62;
            this.lblDensity.Tag = "clearOnReload";
            this.lblDensity.Text = "0";
            this.lblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbDefects
            // 
            this.grpbDefects.Controls.Add(this.chkDefect1);
            this.grpbDefects.Controls.Add(this.chkDefect2);
            this.grpbDefects.Controls.Add(this.chkDefect3);
            this.grpbDefects.Controls.Add(this.chkDefect4);
            this.grpbDefects.Controls.Add(this.chkDefect5);
            this.grpbDefects.Controls.Add(this.chkDefect6);
            this.grpbDefects.Controls.Add(this.chkDefect7);
            this.grpbDefects.Controls.Add(this.chkDefect8);
            this.grpbDefects.Controls.Add(this.chkDefect9);
            this.grpbDefects.Controls.Add(this.chkDefect10);
            this.grpbDefects.Controls.Add(this.chkDefect11);
            this.grpbDefects.Controls.Add(this.chkDefect12);
            this.grpbDefects.Controls.Add(this.chkDefect13);
            this.grpbDefects.Controls.Add(this.chkDefect14);
            this.grpbDefects.Controls.Add(this.chkDefect15);
            this.grpbDefects.Controls.Add(this.chkDefect16);
            this.grpbDefects.Location = new System.Drawing.Point(477, -1);
            this.grpbDefects.Name = "grpbDefects";
            this.grpbDefects.Size = new System.Drawing.Size(258, 187);
            this.grpbDefects.TabIndex = 73;
            this.grpbDefects.TabStop = false;
            this.grpbDefects.Text = "Defectos";
            // 
            // chkDefect1
            // 
            this.chkDefect1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefect1.Location = new System.Drawing.Point(7, 18);
            this.chkDefect1.Name = "chkDefect1";
            this.chkDefect1.Size = new System.Drawing.Size(109, 17);
            this.chkDefect1.TabIndex = 0;
            this.chkDefect1.Tag = "1";
            this.chkDefect1.Text = "Acampanado";
            this.chkDefect1.UseVisualStyleBackColor = true;
            // 
            // chkDefect2
            // 
            this.chkDefect2.Location = new System.Drawing.Point(7, 39);
            this.chkDefect2.Name = "chkDefect2";
            this.chkDefect2.Size = new System.Drawing.Size(109, 17);
            this.chkDefect2.TabIndex = 1;
            this.chkDefect2.Tag = "2";
            this.chkDefect2.Text = "Acanalado";
            this.chkDefect2.UseVisualStyleBackColor = true;
            // 
            // chkDefect3
            // 
            this.chkDefect3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefect3.Location = new System.Drawing.Point(7, 60);
            this.chkDefect3.Name = "chkDefect3";
            this.chkDefect3.Size = new System.Drawing.Size(109, 17);
            this.chkDefect3.TabIndex = 2;
            this.chkDefect3.Tag = "3";
            this.chkDefect3.Text = "Arrugas";
            this.chkDefect3.UseVisualStyleBackColor = true;
            // 
            // chkDefect4
            // 
            this.chkDefect4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefect4.Location = new System.Drawing.Point(7, 81);
            this.chkDefect4.Name = "chkDefect4";
            this.chkDefect4.Size = new System.Drawing.Size(109, 17);
            this.chkDefect4.TabIndex = 3;
            this.chkDefect4.Tag = "4";
            this.chkDefect4.Text = "Bobina Floja";
            this.chkDefect4.UseVisualStyleBackColor = true;
            // 
            // chkDefect5
            // 
            this.chkDefect5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefect5.Location = new System.Drawing.Point(7, 102);
            this.chkDefect5.Name = "chkDefect5";
            this.chkDefect5.Size = new System.Drawing.Size(109, 17);
            this.chkDefect5.TabIndex = 4;
            this.chkDefect5.Tag = "5";
            this.chkDefect5.Text = "Bloqueo";
            this.chkDefect5.UseVisualStyleBackColor = true;
            // 
            // chkDefect6
            // 
            this.chkDefect6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefect6.Location = new System.Drawing.Point(7, 123);
            this.chkDefect6.Name = "chkDefect6";
            this.chkDefect6.Size = new System.Drawing.Size(109, 17);
            this.chkDefect6.TabIndex = 5;
            this.chkDefect6.Tag = "6";
            this.chkDefect6.Text = "Borde Flojo";
            this.chkDefect6.UseVisualStyleBackColor = true;
            // 
            // chkDefect7
            // 
            this.chkDefect7.Location = new System.Drawing.Point(7, 144);
            this.chkDefect7.Name = "chkDefect7";
            this.chkDefect7.Size = new System.Drawing.Size(109, 17);
            this.chkDefect7.TabIndex = 6;
            this.chkDefect7.Tag = "7";
            this.chkDefect7.Text = "Punto Duro";
            this.chkDefect7.UseVisualStyleBackColor = true;
            // 
            // chkDefect8
            // 
            this.chkDefect8.Location = new System.Drawing.Point(7, 165);
            this.chkDefect8.Name = "chkDefect8";
            this.chkDefect8.Size = new System.Drawing.Size(109, 17);
            this.chkDefect8.TabIndex = 7;
            this.chkDefect8.Tag = "8";
            this.chkDefect8.Text = "Contaminación";
            this.chkDefect8.UseVisualStyleBackColor = true;
            // 
            // chkDefect9
            // 
            this.chkDefect9.Location = new System.Drawing.Point(120, 18);
            this.chkDefect9.Name = "chkDefect9";
            this.chkDefect9.Size = new System.Drawing.Size(109, 17);
            this.chkDefect9.TabIndex = 8;
            this.chkDefect9.Tag = "9";
            this.chkDefect9.Text = "Curvatura";
            this.chkDefect9.UseVisualStyleBackColor = true;
            // 
            // chkDefect10
            // 
            this.chkDefect10.Location = new System.Drawing.Point(120, 39);
            this.chkDefect10.Name = "chkDefect10";
            this.chkDefect10.Size = new System.Drawing.Size(109, 17);
            this.chkDefect10.TabIndex = 9;
            this.chkDefect10.Tag = "10";
            this.chkDefect10.Text = "Tensionado";
            this.chkDefect10.UseVisualStyleBackColor = true;
            // 
            // chkDefect11
            // 
            this.chkDefect11.Location = new System.Drawing.Point(120, 60);
            this.chkDefect11.Name = "chkDefect11";
            this.chkDefect11.Size = new System.Drawing.Size(109, 17);
            this.chkDefect11.TabIndex = 10;
            this.chkDefect11.Tag = "11";
            this.chkDefect11.Text = "Estrias";
            this.chkDefect11.UseVisualStyleBackColor = true;
            // 
            // chkDefect12
            // 
            this.chkDefect12.Location = new System.Drawing.Point(120, 81);
            this.chkDefect12.Name = "chkDefect12";
            this.chkDefect12.Size = new System.Drawing.Size(109, 17);
            this.chkDefect12.TabIndex = 11;
            this.chkDefect12.Tag = "12";
            this.chkDefect12.Text = "Mal corte C.";
            this.chkDefect12.UseVisualStyleBackColor = true;
            // 
            // chkDefect13
            // 
            this.chkDefect13.Location = new System.Drawing.Point(120, 102);
            this.chkDefect13.Name = "chkDefect13";
            this.chkDefect13.Size = new System.Drawing.Size(109, 17);
            this.chkDefect13.TabIndex = 12;
            this.chkDefect13.Tag = "13";
            this.chkDefect13.Text = "Orilla Caida";
            this.chkDefect13.UseVisualStyleBackColor = true;
            // 
            // chkDefect14
            // 
            this.chkDefect14.Location = new System.Drawing.Point(120, 123);
            this.chkDefect14.Name = "chkDefect14";
            this.chkDefect14.Size = new System.Drawing.Size(109, 17);
            this.chkDefect14.TabIndex = 13;
            this.chkDefect14.Tag = "14";
            this.chkDefect14.Text = "Trenzas";
            this.chkDefect14.UseVisualStyleBackColor = true;
            // 
            // chkDefect15
            // 
            this.chkDefect15.Location = new System.Drawing.Point(120, 144);
            this.chkDefect15.Name = "chkDefect15";
            this.chkDefect15.Size = new System.Drawing.Size(109, 17);
            this.chkDefect15.TabIndex = 14;
            this.chkDefect15.Tag = "15";
            this.chkDefect15.Text = "Salientes";
            this.chkDefect15.UseVisualStyleBackColor = true;
            // 
            // chkDefect16
            // 
            this.chkDefect16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDefect16.Location = new System.Drawing.Point(120, 165);
            this.chkDefect16.Name = "chkDefect16";
            this.chkDefect16.Size = new System.Drawing.Size(109, 17);
            this.chkDefect16.TabIndex = 15;
            this.chkDefect16.Tag = "16";
            this.chkDefect16.Text = "Telescopeado";
            this.chkDefect16.UseVisualStyleBackColor = true;
            // 
            // grpbDestiny
            // 
            this.grpbDestiny.Controls.Add(this.lblCoilCellarLabel);
            this.grpbDestiny.Controls.Add(this.lblSalesOrder);
            this.grpbDestiny.Controls.Add(this.lblCoilCellar);
            this.grpbDestiny.Controls.Add(this.lblCustomer);
            this.grpbDestiny.Controls.Add(this.lblCustomerLabel);
            this.grpbDestiny.Controls.Add(this.lblSalesOrderNumber);
            this.grpbDestiny.Location = new System.Drawing.Point(5, 188);
            this.grpbDestiny.Name = "grpbDestiny";
            this.grpbDestiny.Size = new System.Drawing.Size(731, 49);
            this.grpbDestiny.TabIndex = 79;
            this.grpbDestiny.TabStop = false;
            this.grpbDestiny.Text = "Destino";
            // 
            // lblCoilCellarLabel
            // 
            this.lblCoilCellarLabel.AutoSize = true;
            this.lblCoilCellarLabel.Location = new System.Drawing.Point(462, 21);
            this.lblCoilCellarLabel.Name = "lblCoilCellarLabel";
            this.lblCoilCellarLabel.Size = new System.Drawing.Size(50, 15);
            this.lblCoilCellarLabel.TabIndex = 4;
            this.lblCoilCellarLabel.Text = "Bodega";
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Location = new System.Drawing.Point(271, 21);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(92, 15);
            this.lblSalesOrder.TabIndex = 2;
            this.lblSalesOrder.Text = "Orden de Venta";
            // 
            // lblCoilCellar
            // 
            this.lblCoilCellar.BackColor = System.Drawing.SystemColors.Window;
            this.lblCoilCellar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoilCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCellar.Location = new System.Drawing.Point(513, 18);
            this.lblCoilCellar.Name = "lblCoilCellar";
            this.lblCoilCellar.Size = new System.Drawing.Size(212, 21);
            this.lblCoilCellar.TabIndex = 1;
            this.lblCoilCellar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(60, 18);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(194, 21);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomerLabel
            // 
            this.lblCustomerLabel.AutoSize = true;
            this.lblCustomerLabel.Location = new System.Drawing.Point(9, 21);
            this.lblCustomerLabel.Name = "lblCustomerLabel";
            this.lblCustomerLabel.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerLabel.TabIndex = 0;
            this.lblCustomerLabel.Text = "Cliente";
            // 
            // lblSalesOrderNumber
            // 
            this.lblSalesOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblSalesOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderNumber.Location = new System.Drawing.Point(369, 19);
            this.lblSalesOrderNumber.Name = "lblSalesOrderNumber";
            this.lblSalesOrderNumber.Size = new System.Drawing.Size(75, 21);
            this.lblSalesOrderNumber.TabIndex = 3;
            this.lblSalesOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBalance
            // 
            this.lblBalance.BackColor = System.Drawing.SystemColors.Window;
            this.lblBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(329, 114);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(123, 21);
            this.lblBalance.TabIndex = 67;
            this.lblBalance.Tag = "clearOnReload";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLengthLabel
            // 
            this.lblLengthLabel.AutoSize = true;
            this.lblLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthLabel.Location = new System.Drawing.Point(10, 114);
            this.lblLengthLabel.Name = "lblLengthLabel";
            this.lblLengthLabel.Size = new System.Drawing.Size(49, 15);
            this.lblLengthLabel.TabIndex = 65;
            this.lblLengthLabel.Text = "Metraje";
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(9, 88);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(64, 15);
            this.lblNetWeigthLabel.TabIndex = 63;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblGrossWeigthLabel
            // 
            this.lblGrossWeigthLabel.AutoSize = true;
            this.lblGrossWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigthLabel.Location = new System.Drawing.Point(256, 91);
            this.lblGrossWeigthLabel.Name = "lblGrossWeigthLabel";
            this.lblGrossWeigthLabel.Size = new System.Drawing.Size(67, 15);
            this.lblGrossWeigthLabel.TabIndex = 64;
            this.lblGrossWeigthLabel.Text = "Peso Bruto";
            // 
            // lblDensityLabel
            // 
            this.lblDensityLabel.AutoSize = true;
            this.lblDensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensityLabel.Location = new System.Drawing.Point(256, 65);
            this.lblDensityLabel.Name = "lblDensityLabel";
            this.lblDensityLabel.Size = new System.Drawing.Size(60, 15);
            this.lblDensityLabel.TabIndex = 61;
            this.lblDensityLabel.Text = "Densidad";
            // 
            // lblBalanceLabel
            // 
            this.lblBalanceLabel.AutoSize = true;
            this.lblBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceLabel.Location = new System.Drawing.Point(256, 114);
            this.lblBalanceLabel.Name = "lblBalanceLabel";
            this.lblBalanceLabel.Size = new System.Drawing.Size(52, 15);
            this.lblBalanceLabel.TabIndex = 68;
            this.lblBalanceLabel.Text = "Balanza";
            // 
            // lblDiameterLabel
            // 
            this.lblDiameterLabel.AutoSize = true;
            this.lblDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameterLabel.Location = new System.Drawing.Point(9, 62);
            this.lblDiameterLabel.Name = "lblDiameterLabel";
            this.lblDiameterLabel.Size = new System.Drawing.Size(58, 15);
            this.lblDiameterLabel.TabIndex = 59;
            this.lblDiameterLabel.Text = "Diámetro";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInProcessReworkDetail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtInProcessUsefulWidth);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbInProcessRework);
            this.groupBox1.Controls.Add(this.cmbInProcessDestination);
            this.groupBox1.Location = new System.Drawing.Point(5, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 93);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Revisión de bobina en observación";
            // 
            // txtInProcessReworkDetail
            // 
            this.txtInProcessReworkDetail.Location = new System.Drawing.Point(153, 54);
            this.txtInProcessReworkDetail.Multiline = true;
            this.txtInProcessReworkDetail.Name = "txtInProcessReworkDetail";
            this.txtInProcessReworkDetail.Size = new System.Drawing.Size(552, 27);
            this.txtInProcessReworkDetail.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 15);
            this.label10.TabIndex = 57;
            this.label10.Text = "Detalle/Observación:";
            // 
            // txtInProcessUsefulWidth
            // 
            this.txtInProcessUsefulWidth.Location = new System.Drawing.Point(634, 26);
            this.txtInProcessUsefulWidth.Name = "txtInProcessUsefulWidth";
            this.txtInProcessUsefulWidth.Size = new System.Drawing.Size(71, 21);
            this.txtInProcessUsefulWidth.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 51;
            this.label8.Text = "Destino:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(569, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Ancho Util:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 52;
            this.label9.Text = "Calificación PP";
            // 
            // cmbInProcessRework
            // 
            this.cmbInProcessRework.FormattingEnabled = true;
            this.cmbInProcessRework.Items.AddRange(new object[] {
            "Cualquier Destino",
            "Destino NKA",
            "Rebobinado",
            "Refilo"});
            this.cmbInProcessRework.Location = new System.Drawing.Point(350, 25);
            this.cmbInProcessRework.Name = "cmbInProcessRework";
            this.cmbInProcessRework.Size = new System.Drawing.Size(201, 23);
            this.cmbInProcessRework.TabIndex = 54;
            this.cmbInProcessRework.SelectedIndexChanged += new System.EventHandler(this.cmbInProcessRework_SelectedIndexChanged);
            // 
            // cmbInProcessDestination
            // 
            this.cmbInProcessDestination.FormattingEnabled = true;
            this.cmbInProcessDestination.Items.AddRange(new object[] {
            "Primera",
            "Producto en proceso",
            "PNC"});
            this.cmbInProcessDestination.Location = new System.Drawing.Point(85, 25);
            this.cmbInProcessDestination.Name = "cmbInProcessDestination";
            this.cmbInProcessDestination.Size = new System.Drawing.Size(153, 23);
            this.cmbInProcessDestination.TabIndex = 53;
            this.cmbInProcessDestination.SelectedIndexChanged += new System.EventHandler(this.cmbInProcessDestination_SelectedIndexChanged);
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtNotes);
            this.grpbNotes.Location = new System.Drawing.Point(5, 243);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(731, 69);
            this.grpbNotes.TabIndex = 30;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Notas";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 17);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(725, 49);
            this.txtNotes.TabIndex = 0;
            // 
            // grpb
            // 
            this.grpb.Controls.Add(this.dgvMainCoilList);
            this.grpb.Location = new System.Drawing.Point(5, 315);
            this.grpb.Name = "grpb";
            this.grpb.Size = new System.Drawing.Size(731, 89);
            this.grpb.TabIndex = 31;
            this.grpb.TabStop = false;
            this.grpb.Text = "Rollos madre";
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
            this.clmMainCoilUsedLenth});
            this.dgvMainCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilList.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilList.Size = new System.Drawing.Size(725, 69);
            this.dgvMainCoilList.TabIndex = 0;
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
            this.clmMainCoilListFilm.Width = 300;
            // 
            // clmMainCoilListCode
            // 
            this.clmMainCoilListCode.HeaderText = "Código";
            this.clmMainCoilListCode.Name = "clmMainCoilListCode";
            this.clmMainCoilListCode.ReadOnly = true;
            this.clmMainCoilListCode.Width = 150;
            // 
            // clmMainCoilListBatch
            // 
            this.clmMainCoilListBatch.HeaderText = "Lote";
            this.clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            this.clmMainCoilListBatch.ReadOnly = true;
            // 
            // clmMainCoilUsedLenth
            // 
            this.clmMainCoilUsedLenth.HeaderText = "Metraje";
            this.clmMainCoilUsedLenth.Name = "clmMainCoilUsedLenth";
            this.clmMainCoilUsedLenth.ReadOnly = true;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(5, 492);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(665, 44);
            this.grpbEmpty.TabIndex = 32;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnCoilSave);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilExit);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(676, 492);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(59, 44);
            this.grpbMainCoilButtons.TabIndex = 33;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnCoilSave
            // 
            this.btnCoilSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoilSave.BackgroundImage")));
            this.btnCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoilSave.Location = new System.Drawing.Point(4, 14);
            this.btnCoilSave.Name = "btnCoilSave";
            this.btnCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoilSave.TabIndex = 0;
            this.btnCoilSave.UseVisualStyleBackColor = true;
            this.btnCoilSave.Click += new System.EventHandler(this.btnCoilSave_Click);
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(29, 14);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 1;
            this.ttpCoilDetail.SetToolTip(this.btnMainCoilExit, "Salir Bobinas");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // frmCoilEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(748, 568);
            this.Controls.Add(this.tbcCoil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilEditor";
            this.Text = "Edición de Bobina";
            this.Load += new System.EventHandler(this.frmCoilEditor_Load);
            this.tbcCoil.ResumeLayout(false);
            this.tbpCoilInfo.ResumeLayout(false);
            this.tbpCoilInfo.PerformLayout();
            this.grpbDefects.ResumeLayout(false);
            this.grpbDestiny.ResumeLayout(false);
            this.grpbDestiny.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.grpb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCoil;
        private System.Windows.Forms.TabPage tbpCoilInfo;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.GroupBox grpb;
        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilUsedLenth;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.ToolTip ttpCoilDetail;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCoilSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtInProcessUsefulWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbInProcessRework;
        private System.Windows.Forms.ComboBox cmbInProcessDestination;
        private System.Windows.Forms.TextBox txtInProcessReworkDetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdoQ;
        private System.Windows.Forms.RadioButton rdbTT;
        private System.Windows.Forms.Label txtGrossWeigth;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblTreatmentSide;
        private System.Windows.Forms.RadioButton rdoTreatmentWithout;
        private System.Windows.Forms.RadioButton rdoTreatmentDouble;
        private System.Windows.Forms.RadioButton rdoTreatmentInner;
        private System.Windows.Forms.RadioButton rdoTreatmentExternal;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPositionLabel;
        private System.Windows.Forms.Label lblFulmNameLabel;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblWidthLabel;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblQualityLabel;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.GroupBox grpbDefects;
        private System.Windows.Forms.CheckBox chkDefect1;
        private System.Windows.Forms.CheckBox chkDefect2;
        private System.Windows.Forms.CheckBox chkDefect3;
        private System.Windows.Forms.CheckBox chkDefect4;
        private System.Windows.Forms.CheckBox chkDefect5;
        private System.Windows.Forms.CheckBox chkDefect6;
        private System.Windows.Forms.CheckBox chkDefect7;
        private System.Windows.Forms.CheckBox chkDefect8;
        private System.Windows.Forms.CheckBox chkDefect9;
        private System.Windows.Forms.CheckBox chkDefect10;
        private System.Windows.Forms.CheckBox chkDefect11;
        private System.Windows.Forms.CheckBox chkDefect12;
        private System.Windows.Forms.CheckBox chkDefect13;
        private System.Windows.Forms.CheckBox chkDefect14;
        private System.Windows.Forms.CheckBox chkDefect15;
        private System.Windows.Forms.CheckBox chkDefect16;
        private System.Windows.Forms.GroupBox grpbDestiny;
        private System.Windows.Forms.Label lblCoilCellarLabel;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.Label lblCoilCellar;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblCustomerLabel;
        private System.Windows.Forms.Label lblSalesOrderNumber;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLengthLabel;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblGrossWeigthLabel;
        private System.Windows.Forms.Label lblDensityLabel;
        private System.Windows.Forms.Label lblBalanceLabel;
        private System.Windows.Forms.Label lblDiameterLabel;

    }
}