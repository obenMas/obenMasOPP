namespace BPS
{
    partial class frmRewindCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRewindCoil));
            this.tbcRewind = new System.Windows.Forms.TabControl();
            this.tbpCoilData = new System.Windows.Forms.TabPage();
            this.lblOriginalLength = new System.Windows.Forms.Label();
            this.lblOriginalQuality = new System.Windows.Forms.Label();
            this.lblOriginalCellar = new System.Windows.Forms.Label();
            this.lblOriginalGrossWeigth = new System.Windows.Forms.Label();
            this.lblOriginalDiameter = new System.Windows.Forms.Label();
            this.lblOriginalNetWeigth = new System.Windows.Forms.Label();
            this.lblOriginalCoilCellar = new System.Windows.Forms.Label();
            this.grpbOriginalNotes = new System.Windows.Forms.GroupBox();
            this.txtOriginalNotes = new System.Windows.Forms.TextBox();
            this.lblOriginalTreatmentSide = new System.Windows.Forms.Label();
            this.rdoOriginalTreatmentWithout = new System.Windows.Forms.RadioButton();
            this.rdoOriginalTreatmentDouble = new System.Windows.Forms.RadioButton();
            this.rdoOriginalTreatmentInner = new System.Windows.Forms.RadioButton();
            this.rdoOriginalTreatmentExternal = new System.Windows.Forms.RadioButton();
            this.lblOriginalDensity = new System.Windows.Forms.Label();
            this.lblOriginalFulmNameLabel = new System.Windows.Forms.Label();
            this.lblOriginalFilmName = new System.Windows.Forms.Label();
            this.lblOriginalWidth = new System.Windows.Forms.Label();
            this.lblOriginalLengthLabel = new System.Windows.Forms.Label();
            this.lblOriginalNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblOriginalWidthLabel = new System.Windows.Forms.Label();
            this.lblOriginalGrossWeigthLabel = new System.Windows.Forms.Label();
            this.lblOriginalCodeLabel = new System.Windows.Forms.Label();
            this.lblOriginalDensityLabel = new System.Windows.Forms.Label();
            this.lblOriginalQualityLabel = new System.Windows.Forms.Label();
            this.txtOriginalCode = new System.Windows.Forms.TextBox();
            this.lblOriginalDiameterLabel = new System.Windows.Forms.Label();
            this.grpbActionsRewind = new System.Windows.Forms.GroupBox();
            this.btnRewind = new System.Windows.Forms.Button();
            this.tbpRewinedCoil = new System.Windows.Forms.TabPage();
            this.grpbNewCoilAction = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblTreatmentSide = new System.Windows.Forms.Label();
            this.rdoTreatmentWithout = new System.Windows.Forms.RadioButton();
            this.rdoTreatmentDouble = new System.Windows.Forms.RadioButton();
            this.rdoTreatmentInner = new System.Windows.Forms.RadioButton();
            this.rdoTreatmentExternal = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.lblFulmNameLabel = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.lblLengthLabel = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblWidthLabel = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblDensityLabel = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblDiameter = new System.Windows.Forms.Label();
            this.txtGrossWeigth = new System.Windows.Forms.TextBox();
            this.rptCoilLabel1 = new BPS.Reports.rptCoilLabel();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.ttpRewindCoil = new System.Windows.Forms.ToolTip(this.components);
            this.tbcRewind.SuspendLayout();
            this.tbpCoilData.SuspendLayout();
            this.grpbOriginalNotes.SuspendLayout();
            this.grpbActionsRewind.SuspendLayout();
            this.tbpRewinedCoil.SuspendLayout();
            this.grpbNewCoilAction.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRewind
            // 
            this.tbcRewind.Controls.Add(this.tbpCoilData);
            this.tbcRewind.Controls.Add(this.tbpRewinedCoil);
            this.tbcRewind.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcRewind.Location = new System.Drawing.Point(0, 0);
            this.tbcRewind.Name = "tbcRewind";
            this.tbcRewind.SelectedIndex = 0;
            this.tbcRewind.Size = new System.Drawing.Size(585, 404);
            this.tbcRewind.TabIndex = 0;
            // 
            // tbpCoilData
            // 
            this.tbpCoilData.Controls.Add(this.lblOriginalLength);
            this.tbpCoilData.Controls.Add(this.lblOriginalQuality);
            this.tbpCoilData.Controls.Add(this.lblOriginalCellar);
            this.tbpCoilData.Controls.Add(this.lblOriginalGrossWeigth);
            this.tbpCoilData.Controls.Add(this.lblOriginalDiameter);
            this.tbpCoilData.Controls.Add(this.lblOriginalNetWeigth);
            this.tbpCoilData.Controls.Add(this.lblOriginalCoilCellar);
            this.tbpCoilData.Controls.Add(this.grpbOriginalNotes);
            this.tbpCoilData.Controls.Add(this.lblOriginalTreatmentSide);
            this.tbpCoilData.Controls.Add(this.rdoOriginalTreatmentWithout);
            this.tbpCoilData.Controls.Add(this.rdoOriginalTreatmentDouble);
            this.tbpCoilData.Controls.Add(this.rdoOriginalTreatmentInner);
            this.tbpCoilData.Controls.Add(this.rdoOriginalTreatmentExternal);
            this.tbpCoilData.Controls.Add(this.lblOriginalDensity);
            this.tbpCoilData.Controls.Add(this.lblOriginalFulmNameLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalFilmName);
            this.tbpCoilData.Controls.Add(this.lblOriginalWidth);
            this.tbpCoilData.Controls.Add(this.lblOriginalLengthLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalNetWeigthLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalWidthLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalGrossWeigthLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalCodeLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalDensityLabel);
            this.tbpCoilData.Controls.Add(this.lblOriginalQualityLabel);
            this.tbpCoilData.Controls.Add(this.txtOriginalCode);
            this.tbpCoilData.Controls.Add(this.lblOriginalDiameterLabel);
            this.tbpCoilData.Controls.Add(this.grpbActionsRewind);
            this.tbpCoilData.Location = new System.Drawing.Point(4, 24);
            this.tbpCoilData.Name = "tbpCoilData";
            this.tbpCoilData.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoilData.Size = new System.Drawing.Size(577, 376);
            this.tbpCoilData.TabIndex = 0;
            this.tbpCoilData.Text = "Bobina Original";
            this.tbpCoilData.UseVisualStyleBackColor = true;
            // 
            // lblOriginalLength
            // 
            this.lblOriginalLength.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalLength.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalLength.Location = new System.Drawing.Point(125, 167);
            this.lblOriginalLength.Name = "lblOriginalLength";
            this.lblOriginalLength.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalLength.TabIndex = 13;
            this.lblOriginalLength.Tag = "clearOnReload";
            this.lblOriginalLength.Text = "0";
            this.lblOriginalLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginalQuality
            // 
            this.lblOriginalQuality.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalQuality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalQuality.Location = new System.Drawing.Point(386, 206);
            this.lblOriginalQuality.Name = "lblOriginalQuality";
            this.lblOriginalQuality.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalQuality.TabIndex = 19;
            this.lblOriginalQuality.Tag = "clearOnReload";
            this.lblOriginalQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOriginalCellar
            // 
            this.lblOriginalCellar.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalCellar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalCellar.Location = new System.Drawing.Point(386, 167);
            this.lblOriginalCellar.Name = "lblOriginalCellar";
            this.lblOriginalCellar.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalCellar.TabIndex = 15;
            this.lblOriginalCellar.Tag = "clearOnReload";
            this.lblOriginalCellar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOriginalGrossWeigth
            // 
            this.lblOriginalGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalGrossWeigth.Location = new System.Drawing.Point(387, 128);
            this.lblOriginalGrossWeigth.Name = "lblOriginalGrossWeigth";
            this.lblOriginalGrossWeigth.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalGrossWeigth.TabIndex = 11;
            this.lblOriginalGrossWeigth.Tag = "clearOnReload";
            this.lblOriginalGrossWeigth.Text = "0";
            this.lblOriginalGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginalDiameter
            // 
            this.lblOriginalDiameter.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalDiameter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalDiameter.Location = new System.Drawing.Point(125, 89);
            this.lblOriginalDiameter.Name = "lblOriginalDiameter";
            this.lblOriginalDiameter.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalDiameter.TabIndex = 5;
            this.lblOriginalDiameter.Tag = "clearOnReload";
            this.lblOriginalDiameter.Text = "0";
            this.lblOriginalDiameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginalNetWeigth
            // 
            this.lblOriginalNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalNetWeigth.Location = new System.Drawing.Point(125, 128);
            this.lblOriginalNetWeigth.Name = "lblOriginalNetWeigth";
            this.lblOriginalNetWeigth.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalNetWeigth.TabIndex = 9;
            this.lblOriginalNetWeigth.Tag = "clearOnReload";
            this.lblOriginalNetWeigth.Text = "0";
            this.lblOriginalNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginalCoilCellar
            // 
            this.lblOriginalCoilCellar.AutoSize = true;
            this.lblOriginalCoilCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalCoilCellar.Location = new System.Drawing.Point(298, 170);
            this.lblOriginalCoilCellar.Name = "lblOriginalCoilCellar";
            this.lblOriginalCoilCellar.Size = new System.Drawing.Size(65, 20);
            this.lblOriginalCoilCellar.TabIndex = 14;
            this.lblOriginalCoilCellar.Text = "Bodega";
            // 
            // grpbOriginalNotes
            // 
            this.grpbOriginalNotes.Controls.Add(this.txtOriginalNotes);
            this.grpbOriginalNotes.Location = new System.Drawing.Point(2, 281);
            this.grpbOriginalNotes.Name = "grpbOriginalNotes";
            this.grpbOriginalNotes.Size = new System.Drawing.Size(528, 89);
            this.grpbOriginalNotes.TabIndex = 27;
            this.grpbOriginalNotes.TabStop = false;
            this.grpbOriginalNotes.Text = "Notas";
            // 
            // txtOriginalNotes
            // 
            this.txtOriginalNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOriginalNotes.Location = new System.Drawing.Point(3, 17);
            this.txtOriginalNotes.Multiline = true;
            this.txtOriginalNotes.Name = "txtOriginalNotes";
            this.txtOriginalNotes.Size = new System.Drawing.Size(522, 69);
            this.txtOriginalNotes.TabIndex = 0;
            // 
            // lblOriginalTreatmentSide
            // 
            this.lblOriginalTreatmentSide.AutoSize = true;
            this.lblOriginalTreatmentSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalTreatmentSide.Location = new System.Drawing.Point(41, 248);
            this.lblOriginalTreatmentSide.Name = "lblOriginalTreatmentSide";
            this.lblOriginalTreatmentSide.Size = new System.Drawing.Size(94, 20);
            this.lblOriginalTreatmentSide.TabIndex = 20;
            this.lblOriginalTreatmentSide.Text = "Tratamiento";
            // 
            // rdoOriginalTreatmentWithout
            // 
            this.rdoOriginalTreatmentWithout.AutoSize = true;
            this.rdoOriginalTreatmentWithout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOriginalTreatmentWithout.Location = new System.Drawing.Point(400, 246);
            this.rdoOriginalTreatmentWithout.Name = "rdoOriginalTreatmentWithout";
            this.rdoOriginalTreatmentWithout.Size = new System.Drawing.Size(135, 24);
            this.rdoOriginalTreatmentWithout.TabIndex = 24;
            this.rdoOriginalTreatmentWithout.Text = "Sin tratamiento";
            this.rdoOriginalTreatmentWithout.UseVisualStyleBackColor = true;
            // 
            // rdoOriginalTreatmentDouble
            // 
            this.rdoOriginalTreatmentDouble.AutoSize = true;
            this.rdoOriginalTreatmentDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOriginalTreatmentDouble.Location = new System.Drawing.Point(316, 246);
            this.rdoOriginalTreatmentDouble.Name = "rdoOriginalTreatmentDouble";
            this.rdoOriginalTreatmentDouble.Size = new System.Drawing.Size(69, 24);
            this.rdoOriginalTreatmentDouble.TabIndex = 23;
            this.rdoOriginalTreatmentDouble.Text = "Doble";
            this.rdoOriginalTreatmentDouble.UseVisualStyleBackColor = true;
            // 
            // rdoOriginalTreatmentInner
            // 
            this.rdoOriginalTreatmentInner.AutoSize = true;
            this.rdoOriginalTreatmentInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOriginalTreatmentInner.Location = new System.Drawing.Point(227, 246);
            this.rdoOriginalTreatmentInner.Name = "rdoOriginalTreatmentInner";
            this.rdoOriginalTreatmentInner.Size = new System.Drawing.Size(78, 24);
            this.rdoOriginalTreatmentInner.TabIndex = 22;
            this.rdoOriginalTreatmentInner.Text = "Interno";
            this.rdoOriginalTreatmentInner.UseVisualStyleBackColor = true;
            // 
            // rdoOriginalTreatmentExternal
            // 
            this.rdoOriginalTreatmentExternal.AutoSize = true;
            this.rdoOriginalTreatmentExternal.Checked = true;
            this.rdoOriginalTreatmentExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOriginalTreatmentExternal.Location = new System.Drawing.Point(139, 246);
            this.rdoOriginalTreatmentExternal.Name = "rdoOriginalTreatmentExternal";
            this.rdoOriginalTreatmentExternal.Size = new System.Drawing.Size(82, 24);
            this.rdoOriginalTreatmentExternal.TabIndex = 21;
            this.rdoOriginalTreatmentExternal.TabStop = true;
            this.rdoOriginalTreatmentExternal.Text = "Externo";
            this.rdoOriginalTreatmentExternal.UseVisualStyleBackColor = true;
            // 
            // lblOriginalDensity
            // 
            this.lblOriginalDensity.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalDensity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalDensity.Location = new System.Drawing.Point(387, 89);
            this.lblOriginalDensity.Name = "lblOriginalDensity";
            this.lblOriginalDensity.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalDensity.TabIndex = 7;
            this.lblOriginalDensity.Tag = "clearOnReload";
            this.lblOriginalDensity.Text = "0";
            this.lblOriginalDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOriginalFulmNameLabel
            // 
            this.lblOriginalFulmNameLabel.AutoSize = true;
            this.lblOriginalFulmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalFulmNameLabel.Location = new System.Drawing.Point(27, 14);
            this.lblOriginalFulmNameLabel.Name = "lblOriginalFulmNameLabel";
            this.lblOriginalFulmNameLabel.Size = new System.Drawing.Size(73, 20);
            this.lblOriginalFulmNameLabel.TabIndex = 0;
            this.lblOriginalFulmNameLabel.Text = "Producto";
            // 
            // lblOriginalFilmName
            // 
            this.lblOriginalFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalFilmName.Location = new System.Drawing.Point(125, 14);
            this.lblOriginalFilmName.Name = "lblOriginalFilmName";
            this.lblOriginalFilmName.Size = new System.Drawing.Size(424, 21);
            this.lblOriginalFilmName.TabIndex = 1;
            this.lblOriginalFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOriginalWidth
            // 
            this.lblOriginalWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginalWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginalWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalWidth.Location = new System.Drawing.Point(125, 206);
            this.lblOriginalWidth.Name = "lblOriginalWidth";
            this.lblOriginalWidth.Size = new System.Drawing.Size(162, 26);
            this.lblOriginalWidth.TabIndex = 17;
            this.lblOriginalWidth.Tag = "clearOnReload";
            this.lblOriginalWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOriginalLengthLabel
            // 
            this.lblOriginalLengthLabel.AutoSize = true;
            this.lblOriginalLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalLengthLabel.Location = new System.Drawing.Point(27, 170);
            this.lblOriginalLengthLabel.Name = "lblOriginalLengthLabel";
            this.lblOriginalLengthLabel.Size = new System.Drawing.Size(62, 20);
            this.lblOriginalLengthLabel.TabIndex = 12;
            this.lblOriginalLengthLabel.Text = "Metraje";
            // 
            // lblOriginalNetWeigthLabel
            // 
            this.lblOriginalNetWeigthLabel.AutoSize = true;
            this.lblOriginalNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalNetWeigthLabel.Location = new System.Drawing.Point(27, 131);
            this.lblOriginalNetWeigthLabel.Name = "lblOriginalNetWeigthLabel";
            this.lblOriginalNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblOriginalNetWeigthLabel.TabIndex = 8;
            this.lblOriginalNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblOriginalWidthLabel
            // 
            this.lblOriginalWidthLabel.AutoSize = true;
            this.lblOriginalWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalWidthLabel.Location = new System.Drawing.Point(27, 209);
            this.lblOriginalWidthLabel.Name = "lblOriginalWidthLabel";
            this.lblOriginalWidthLabel.Size = new System.Drawing.Size(55, 20);
            this.lblOriginalWidthLabel.TabIndex = 16;
            this.lblOriginalWidthLabel.Text = "Ancho";
            // 
            // lblOriginalGrossWeigthLabel
            // 
            this.lblOriginalGrossWeigthLabel.AutoSize = true;
            this.lblOriginalGrossWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalGrossWeigthLabel.Location = new System.Drawing.Point(298, 131);
            this.lblOriginalGrossWeigthLabel.Name = "lblOriginalGrossWeigthLabel";
            this.lblOriginalGrossWeigthLabel.Size = new System.Drawing.Size(88, 20);
            this.lblOriginalGrossWeigthLabel.TabIndex = 10;
            this.lblOriginalGrossWeigthLabel.Text = "Peso Bruto";
            // 
            // lblOriginalCodeLabel
            // 
            this.lblOriginalCodeLabel.AutoSize = true;
            this.lblOriginalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalCodeLabel.Location = new System.Drawing.Point(27, 53);
            this.lblOriginalCodeLabel.Name = "lblOriginalCodeLabel";
            this.lblOriginalCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblOriginalCodeLabel.TabIndex = 2;
            this.lblOriginalCodeLabel.Text = "Código";
            // 
            // lblOriginalDensityLabel
            // 
            this.lblOriginalDensityLabel.AutoSize = true;
            this.lblOriginalDensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalDensityLabel.Location = new System.Drawing.Point(298, 92);
            this.lblOriginalDensityLabel.Name = "lblOriginalDensityLabel";
            this.lblOriginalDensityLabel.Size = new System.Drawing.Size(77, 20);
            this.lblOriginalDensityLabel.TabIndex = 6;
            this.lblOriginalDensityLabel.Text = "Densidad";
            // 
            // lblOriginalQualityLabel
            // 
            this.lblOriginalQualityLabel.AutoSize = true;
            this.lblOriginalQualityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalQualityLabel.Location = new System.Drawing.Point(298, 209);
            this.lblOriginalQualityLabel.Name = "lblOriginalQualityLabel";
            this.lblOriginalQualityLabel.Size = new System.Drawing.Size(62, 20);
            this.lblOriginalQualityLabel.TabIndex = 18;
            this.lblOriginalQualityLabel.Text = "Calidad";
            // 
            // txtOriginalCode
            // 
            this.txtOriginalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalCode.Location = new System.Drawing.Point(125, 50);
            this.txtOriginalCode.Name = "txtOriginalCode";
            this.txtOriginalCode.Size = new System.Drawing.Size(423, 26);
            this.txtOriginalCode.TabIndex = 3;
            this.txtOriginalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOriginalCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOriginalCode_KeyDown);
            // 
            // lblOriginalDiameterLabel
            // 
            this.lblOriginalDiameterLabel.AutoSize = true;
            this.lblOriginalDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalDiameterLabel.Location = new System.Drawing.Point(27, 92);
            this.lblOriginalDiameterLabel.Name = "lblOriginalDiameterLabel";
            this.lblOriginalDiameterLabel.Size = new System.Drawing.Size(74, 20);
            this.lblOriginalDiameterLabel.TabIndex = 4;
            this.lblOriginalDiameterLabel.Text = "Diámetro";
            // 
            // grpbActionsRewind
            // 
            this.grpbActionsRewind.Controls.Add(this.btnRewind);
            this.grpbActionsRewind.Location = new System.Drawing.Point(536, 281);
            this.grpbActionsRewind.Name = "grpbActionsRewind";
            this.grpbActionsRewind.Size = new System.Drawing.Size(35, 89);
            this.grpbActionsRewind.TabIndex = 0;
            this.grpbActionsRewind.TabStop = false;
            // 
            // btnRewind
            // 
            this.btnRewind.Image = global::BPS.Properties.Resources.rewind;
            this.btnRewind.Location = new System.Drawing.Point(5, 32);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(25, 25);
            this.btnRewind.TabIndex = 0;
            this.ttpRewindCoil.SetToolTip(this.btnRewind, "Reproceso");
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // tbpRewinedCoil
            // 
            this.tbpRewinedCoil.Controls.Add(this.grpbNewCoilAction);
            this.tbpRewinedCoil.Controls.Add(this.grpbNotes);
            this.tbpRewinedCoil.Controls.Add(this.lblTreatmentSide);
            this.tbpRewinedCoil.Controls.Add(this.rdoTreatmentWithout);
            this.tbpRewinedCoil.Controls.Add(this.rdoTreatmentDouble);
            this.tbpRewinedCoil.Controls.Add(this.rdoTreatmentInner);
            this.tbpRewinedCoil.Controls.Add(this.rdoTreatmentExternal);
            this.tbpRewinedCoil.Controls.Add(this.txtLength);
            this.tbpRewinedCoil.Controls.Add(this.lblNetWeigth);
            this.tbpRewinedCoil.Controls.Add(this.lblDensity);
            this.tbpRewinedCoil.Controls.Add(this.lblFulmNameLabel);
            this.tbpRewinedCoil.Controls.Add(this.lblCode);
            this.tbpRewinedCoil.Controls.Add(this.lblFilmName);
            this.tbpRewinedCoil.Controls.Add(this.lblWidth);
            this.tbpRewinedCoil.Controls.Add(this.cmbQuality);
            this.tbpRewinedCoil.Controls.Add(this.lblLengthLabel);
            this.tbpRewinedCoil.Controls.Add(this.lblNetWeigthLabel);
            this.tbpRewinedCoil.Controls.Add(this.lblWidthLabel);
            this.tbpRewinedCoil.Controls.Add(this.lblGrossWeigth);
            this.tbpRewinedCoil.Controls.Add(this.lblCodeLabel);
            this.tbpRewinedCoil.Controls.Add(this.lblDensityLabel);
            this.tbpRewinedCoil.Controls.Add(this.lblQuality);
            this.tbpRewinedCoil.Controls.Add(this.txtDiameter);
            this.tbpRewinedCoil.Controls.Add(this.lblDiameter);
            this.tbpRewinedCoil.Controls.Add(this.txtGrossWeigth);
            this.tbpRewinedCoil.Location = new System.Drawing.Point(4, 24);
            this.tbpRewinedCoil.Name = "tbpRewinedCoil";
            this.tbpRewinedCoil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRewinedCoil.Size = new System.Drawing.Size(577, 376);
            this.tbpRewinedCoil.TabIndex = 1;
            this.tbpRewinedCoil.Text = "Bobina resultante";
            this.tbpRewinedCoil.UseVisualStyleBackColor = true;
            // 
            // grpbNewCoilAction
            // 
            this.grpbNewCoilAction.Controls.Add(this.btnSave);
            this.grpbNewCoilAction.Location = new System.Drawing.Point(536, 281);
            this.grpbNewCoilAction.Name = "grpbNewCoilAction";
            this.grpbNewCoilAction.Size = new System.Drawing.Size(35, 89);
            this.grpbNewCoilAction.TabIndex = 25;
            this.grpbNewCoilAction.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BPS.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(5, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 0;
            this.ttpRewindCoil.SetToolTip(this.btnSave, "Guardar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtNotes);
            this.grpbNotes.Location = new System.Drawing.Point(2, 281);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(528, 89);
            this.grpbNotes.TabIndex = 24;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Notas";
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(3, 17);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(522, 69);
            this.txtNotes.TabIndex = 0;
            // 
            // lblTreatmentSide
            // 
            this.lblTreatmentSide.AutoSize = true;
            this.lblTreatmentSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreatmentSide.Location = new System.Drawing.Point(41, 248);
            this.lblTreatmentSide.Name = "lblTreatmentSide";
            this.lblTreatmentSide.Size = new System.Drawing.Size(94, 20);
            this.lblTreatmentSide.TabIndex = 19;
            this.lblTreatmentSide.Text = "Tratamiento";
            // 
            // rdoTreatmentWithout
            // 
            this.rdoTreatmentWithout.AutoSize = true;
            this.rdoTreatmentWithout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentWithout.Location = new System.Drawing.Point(400, 246);
            this.rdoTreatmentWithout.Name = "rdoTreatmentWithout";
            this.rdoTreatmentWithout.Size = new System.Drawing.Size(135, 24);
            this.rdoTreatmentWithout.TabIndex = 23;
            this.rdoTreatmentWithout.Text = "Sin tratamiento";
            this.rdoTreatmentWithout.UseVisualStyleBackColor = true;
            // 
            // rdoTreatmentDouble
            // 
            this.rdoTreatmentDouble.AutoSize = true;
            this.rdoTreatmentDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentDouble.Location = new System.Drawing.Point(316, 246);
            this.rdoTreatmentDouble.Name = "rdoTreatmentDouble";
            this.rdoTreatmentDouble.Size = new System.Drawing.Size(69, 24);
            this.rdoTreatmentDouble.TabIndex = 22;
            this.rdoTreatmentDouble.Text = "Doble";
            this.rdoTreatmentDouble.UseVisualStyleBackColor = true;
            // 
            // rdoTreatmentInner
            // 
            this.rdoTreatmentInner.AutoSize = true;
            this.rdoTreatmentInner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentInner.Location = new System.Drawing.Point(227, 246);
            this.rdoTreatmentInner.Name = "rdoTreatmentInner";
            this.rdoTreatmentInner.Size = new System.Drawing.Size(78, 24);
            this.rdoTreatmentInner.TabIndex = 21;
            this.rdoTreatmentInner.Text = "Interno";
            this.rdoTreatmentInner.UseVisualStyleBackColor = true;
            // 
            // rdoTreatmentExternal
            // 
            this.rdoTreatmentExternal.AutoSize = true;
            this.rdoTreatmentExternal.Checked = true;
            this.rdoTreatmentExternal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTreatmentExternal.Location = new System.Drawing.Point(139, 246);
            this.rdoTreatmentExternal.Name = "rdoTreatmentExternal";
            this.rdoTreatmentExternal.Size = new System.Drawing.Size(82, 24);
            this.rdoTreatmentExternal.TabIndex = 20;
            this.rdoTreatmentExternal.TabStop = true;
            this.rdoTreatmentExternal.Text = "Externo";
            this.rdoTreatmentExternal.UseVisualStyleBackColor = true;
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(125, 167);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(162, 26);
            this.txtLength.TabIndex = 13;
            this.txtLength.Text = "0";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(125, 128);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(162, 26);
            this.lblNetWeigth.TabIndex = 9;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDensity
            // 
            this.lblDensity.BackColor = System.Drawing.SystemColors.Window;
            this.lblDensity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensity.Location = new System.Drawing.Point(387, 89);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(162, 26);
            this.lblDensity.TabIndex = 7;
            this.lblDensity.Tag = "clearOnReload";
            this.lblDensity.Text = "0";
            this.lblDensity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFulmNameLabel
            // 
            this.lblFulmNameLabel.AutoSize = true;
            this.lblFulmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulmNameLabel.Location = new System.Drawing.Point(27, 14);
            this.lblFulmNameLabel.Name = "lblFulmNameLabel";
            this.lblFulmNameLabel.Size = new System.Drawing.Size(73, 20);
            this.lblFulmNameLabel.TabIndex = 0;
            this.lblFulmNameLabel.Text = "Producto";
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(125, 52);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(423, 21);
            this.lblCode.TabIndex = 3;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(125, 14);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(423, 21);
            this.lblFilmName.TabIndex = 1;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWidth
            // 
            this.lblWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(125, 206);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(162, 26);
            this.lblWidth.TabIndex = 18;
            this.lblWidth.Tag = "clearOnReload";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbQuality
            // 
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(387, 167);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(162, 23);
            this.cmbQuality.TabIndex = 15;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // lblLengthLabel
            // 
            this.lblLengthLabel.AutoSize = true;
            this.lblLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLengthLabel.Location = new System.Drawing.Point(27, 170);
            this.lblLengthLabel.Name = "lblLengthLabel";
            this.lblLengthLabel.Size = new System.Drawing.Size(62, 20);
            this.lblLengthLabel.TabIndex = 12;
            this.lblLengthLabel.Text = "Metraje";
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(27, 131);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 8;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblWidthLabel
            // 
            this.lblWidthLabel.AutoSize = true;
            this.lblWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthLabel.Location = new System.Drawing.Point(27, 209);
            this.lblWidthLabel.Name = "lblWidthLabel";
            this.lblWidthLabel.Size = new System.Drawing.Size(55, 20);
            this.lblWidthLabel.TabIndex = 17;
            this.lblWidthLabel.Text = "Ancho";
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(298, 131);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigth.TabIndex = 10;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(27, 53);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 2;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblDensityLabel
            // 
            this.lblDensityLabel.AutoSize = true;
            this.lblDensityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensityLabel.Location = new System.Drawing.Point(298, 92);
            this.lblDensityLabel.Name = "lblDensityLabel";
            this.lblDensityLabel.Size = new System.Drawing.Size(77, 20);
            this.lblDensityLabel.TabIndex = 6;
            this.lblDensityLabel.Text = "Densidad";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(298, 168);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(62, 20);
            this.lblQuality.TabIndex = 14;
            this.lblQuality.Text = "Calidad";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiameter.Location = new System.Drawing.Point(125, 89);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(162, 26);
            this.txtDiameter.TabIndex = 5;
            this.txtDiameter.Text = "0";
            this.txtDiameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(27, 92);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(74, 20);
            this.lblDiameter.TabIndex = 4;
            this.lblDiameter.Text = "Diámetro";
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(387, 128);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(162, 26);
            this.txtGrossWeigth.TabIndex = 11;
            this.txtGrossWeigth.Text = "0";
            this.txtGrossWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGrossWeigth.TextChanged += new System.EventHandler(this.txtGrossWeigth_TextChanged);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 401);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(545, 44);
            this.grpbEmpty.TabIndex = 1;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilExit);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(548, 401);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(35, 44);
            this.grpbMainCoilButtons.TabIndex = 2;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(5, 14);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 0;
            this.ttpRewindCoil.SetToolTip(this.btnMainCoilExit, "Salir Rebobinar Bobina");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // frmRewindCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(585, 446);
            this.Controls.Add(this.tbcRewind);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRewindCoil";
            this.Text = "Rebobinar Bobina";
            this.Load += new System.EventHandler(this.frmRewindCoil_Load);
            this.tbcRewind.ResumeLayout(false);
            this.tbpCoilData.ResumeLayout(false);
            this.tbpCoilData.PerformLayout();
            this.grpbOriginalNotes.ResumeLayout(false);
            this.grpbOriginalNotes.PerformLayout();
            this.grpbActionsRewind.ResumeLayout(false);
            this.tbpRewinedCoil.ResumeLayout(false);
            this.tbpRewinedCoil.PerformLayout();
            this.grpbNewCoilAction.ResumeLayout(false);
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRewind;
        private System.Windows.Forms.TabPage tbpCoilData;
        private System.Windows.Forms.GroupBox grpbNewCoilAction;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpbActionsRewind;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilExit;
        private Reports.rptCoilLabel rptCoilLabel1;
        private System.Windows.Forms.ToolTip ttpRewindCoil;
        private System.Windows.Forms.TabPage tbpRewinedCoil;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblTreatmentSide;
        private System.Windows.Forms.RadioButton rdoTreatmentWithout;
        private System.Windows.Forms.RadioButton rdoTreatmentDouble;
        private System.Windows.Forms.RadioButton rdoTreatmentInner;
        private System.Windows.Forms.RadioButton rdoTreatmentExternal;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Label lblFulmNameLabel;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.Label lblLengthLabel;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblWidthLabel;
        private System.Windows.Forms.Label lblGrossWeigth;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblDensityLabel;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.TextBox txtGrossWeigth;
        private System.Windows.Forms.Label lblOriginalCoilCellar;
        private System.Windows.Forms.GroupBox grpbOriginalNotes;
        private System.Windows.Forms.TextBox txtOriginalNotes;
        private System.Windows.Forms.Label lblOriginalTreatmentSide;
        private System.Windows.Forms.RadioButton rdoOriginalTreatmentWithout;
        private System.Windows.Forms.RadioButton rdoOriginalTreatmentDouble;
        private System.Windows.Forms.RadioButton rdoOriginalTreatmentInner;
        private System.Windows.Forms.RadioButton rdoOriginalTreatmentExternal;
        private System.Windows.Forms.Label lblOriginalDensity;
        private System.Windows.Forms.Label lblOriginalFulmNameLabel;
        private System.Windows.Forms.Label lblOriginalFilmName;
        private System.Windows.Forms.Label lblOriginalWidth;
        private System.Windows.Forms.Label lblOriginalLengthLabel;
        private System.Windows.Forms.Label lblOriginalNetWeigthLabel;
        private System.Windows.Forms.Label lblOriginalWidthLabel;
        private System.Windows.Forms.Label lblOriginalGrossWeigthLabel;
        private System.Windows.Forms.Label lblOriginalCodeLabel;
        private System.Windows.Forms.Label lblOriginalDensityLabel;
        private System.Windows.Forms.Label lblOriginalQualityLabel;
        private System.Windows.Forms.TextBox txtOriginalCode;
        private System.Windows.Forms.Label lblOriginalDiameterLabel;
        private System.Windows.Forms.Label lblOriginalNetWeigth;
        private System.Windows.Forms.Label lblOriginalDiameter;
        private System.Windows.Forms.Label lblOriginalGrossWeigth;
        private System.Windows.Forms.Label lblOriginalLength;
        private System.Windows.Forms.Label lblOriginalQuality;
        private System.Windows.Forms.Label lblOriginalCellar;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNetWeigth;

    }
}