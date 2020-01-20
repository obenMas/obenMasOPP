namespace BPS
{
    partial class frmTest8
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
            this.grpbOrder = new System.Windows.Forms.GroupBox();
            this.cmbCutter = new System.Windows.Forms.ComboBox();
            this.btnChangeCutter = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblStatusImage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPercentage2 = new System.Windows.Forms.Label();
            this.lblStopsNumber = new System.Windows.Forms.Label();
            this.lblWaste = new System.Windows.Forms.Label();
            this.lblWasteLabel = new System.Windows.Forms.Label();
            this.lblStops = new System.Windows.Forms.Label();
            this.lblUsedArms = new System.Windows.Forms.Label();
            this.lblUsedWidth = new System.Windows.Forms.Label();
            this.lblUsedArmsLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUsedWidthLabel = new System.Windows.Forms.Label();
            this.lblCutterNameLabel = new System.Windows.Forms.Label();
            this.lblNotesLabel = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblUtilWidthLabel = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.grpbCombination = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblWaste1 = new System.Windows.Forms.Label();
            this.lblWaste2 = new System.Windows.Forms.Label();
            this.lblCoil6 = new System.Windows.Forms.Label();
            this.lblCoil5 = new System.Windows.Forms.Label();
            this.lblCoil4 = new System.Windows.Forms.Label();
            this.lblCoil3 = new System.Windows.Forms.Label();
            this.lblColil2 = new System.Windows.Forms.Label();
            this.lblCoil1 = new System.Windows.Forms.Label();
            this.nudStopsNumber = new System.Windows.Forms.NumericUpDown();
            this.ttpCombination = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCoilDistribution = new System.Windows.Forms.DataGridView();
            this.grpbOrder.SuspendLayout();
            this.grpbCombination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopsNumber)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbOrder
            // 
            this.grpbOrder.Controls.Add(this.cmbCutter);
            this.grpbOrder.Controls.Add(this.btnChangeCutter);
            this.grpbOrder.Controls.Add(this.btnRefresh);
            this.grpbOrder.Controls.Add(this.btnProcess);
            this.grpbOrder.Controls.Add(this.lblSeparator);
            this.grpbOrder.Controls.Add(this.lblStatusImage);
            this.grpbOrder.Controls.Add(this.btnSave);
            this.grpbOrder.Controls.Add(this.btnCancel);
            this.grpbOrder.Controls.Add(this.lblPercentage2);
            this.grpbOrder.Controls.Add(this.lblStopsNumber);
            this.grpbOrder.Controls.Add(this.lblWaste);
            this.grpbOrder.Controls.Add(this.lblWasteLabel);
            this.grpbOrder.Controls.Add(this.lblStops);
            this.grpbOrder.Controls.Add(this.lblUsedArms);
            this.grpbOrder.Controls.Add(this.lblUsedWidth);
            this.grpbOrder.Controls.Add(this.lblUsedArmsLabel);
            this.grpbOrder.Controls.Add(this.lblStatus);
            this.grpbOrder.Controls.Add(this.lblUsedWidthLabel);
            this.grpbOrder.Controls.Add(this.lblCutterNameLabel);
            this.grpbOrder.Controls.Add(this.lblNotesLabel);
            this.grpbOrder.Controls.Add(this.lblNotes);
            this.grpbOrder.Controls.Add(this.lblUtilWidthLabel);
            this.grpbOrder.Controls.Add(this.lblCutterName);
            this.grpbOrder.Controls.Add(this.lblFilmName);
            this.grpbOrder.Controls.Add(this.grpbCombination);
            this.grpbOrder.Controls.Add(this.nudStopsNumber);
            this.grpbOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbOrder.Name = "grpbOrder";
            this.grpbOrder.Size = new System.Drawing.Size(1074, 223);
            this.grpbOrder.TabIndex = 0;
            this.grpbOrder.TabStop = false;
            this.grpbOrder.Text = "1";
            this.grpbOrder.Enter += new System.EventHandler(this.grpbOrder_Enter);
            // 
            // cmbCutter
            // 
            this.cmbCutter.FormattingEnabled = true;
            this.cmbCutter.Location = new System.Drawing.Point(616, 17);
            this.cmbCutter.Name = "cmbCutter";
            this.cmbCutter.Size = new System.Drawing.Size(200, 23);
            this.cmbCutter.TabIndex = 42;
            // 
            // btnChangeCutter
            // 
            this.btnChangeCutter.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh;
            this.btnChangeCutter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangeCutter.Location = new System.Drawing.Point(823, 16);
            this.btnChangeCutter.Name = "btnChangeCutter";
            this.btnChangeCutter.Size = new System.Drawing.Size(22, 22);
            this.btnChangeCutter.TabIndex = 41;
            this.ttpCombination.SetToolTip(this.btnChangeCutter, "Agregar");
            this.btnChangeCutter.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(225, 170);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(22, 22);
            this.btnRefresh.TabIndex = 40;
            this.ttpCombination.SetToolTip(this.btnRefresh, "Agregar");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Properties.Resources.pencil_32;
            this.btnProcess.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProcess.Location = new System.Drawing.Point(951, 171);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(40, 40);
            this.btnProcess.TabIndex = 39;
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpCombination.SetToolTip(this.btnProcess, "Editar");
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(79, 171);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(2, 49);
            this.lblSeparator.TabIndex = 38;
            // 
            // lblStatusImage
            // 
            this.lblStatusImage.Image = global::BPS.Properties.Resources.calendar;
            this.lblStatusImage.Location = new System.Drawing.Point(29, 174);
            this.lblStatusImage.Name = "lblStatusImage";
            this.lblStatusImage.Size = new System.Drawing.Size(25, 25);
            this.lblStatusImage.TabIndex = 37;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(920, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 35;
            this.ttpCombination.SetToolTip(this.btnSave, "Agregar");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(920, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 36;
            this.ttpCombination.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblPercentage2
            // 
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage2.Location = new System.Drawing.Point(227, 200);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage2.TabIndex = 33;
            this.lblPercentage2.Text = "%";
            // 
            // lblStopsNumber
            // 
            this.lblStopsNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblStopsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStopsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopsNumber.Location = new System.Drawing.Point(185, 171);
            this.lblStopsNumber.Name = "lblStopsNumber";
            this.lblStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.lblStopsNumber.TabIndex = 32;
            this.lblStopsNumber.Tag = "clearOnReload";
            this.lblStopsNumber.Text = "0";
            this.lblStopsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWaste
            // 
            this.lblWaste.BackColor = System.Drawing.SystemColors.Window;
            this.lblWaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste.Location = new System.Drawing.Point(185, 198);
            this.lblWaste.Name = "lblWaste";
            this.lblWaste.Size = new System.Drawing.Size(41, 21);
            this.lblWaste.TabIndex = 32;
            this.lblWaste.Tag = "clearOnReload";
            this.lblWaste.Text = "0";
            this.lblWaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteLabel
            // 
            this.lblWasteLabel.AutoSize = true;
            this.lblWasteLabel.Location = new System.Drawing.Point(87, 200);
            this.lblWasteLabel.Name = "lblWasteLabel";
            this.lblWasteLabel.Size = new System.Drawing.Size(73, 15);
            this.lblWasteLabel.TabIndex = 30;
            this.lblWasteLabel.Text = "Desperdicio";
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.lblStops.Location = new System.Drawing.Point(87, 174);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(95, 15);
            this.lblStops.TabIndex = 31;
            this.lblStops.Text = "Nro. de paradas";
            // 
            // lblUsedArms
            // 
            this.lblUsedArms.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedArms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedArms.Location = new System.Drawing.Point(372, 197);
            this.lblUsedArms.Name = "lblUsedArms";
            this.lblUsedArms.Size = new System.Drawing.Size(70, 21);
            this.lblUsedArms.TabIndex = 25;
            this.lblUsedArms.Tag = "clearOnReload";
            this.lblUsedArms.Text = "0";
            this.lblUsedArms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedWidth
            // 
            this.lblUsedWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedWidth.Location = new System.Drawing.Point(372, 171);
            this.lblUsedWidth.Name = "lblUsedWidth";
            this.lblUsedWidth.Size = new System.Drawing.Size(70, 21);
            this.lblUsedWidth.TabIndex = 26;
            this.lblUsedWidth.Tag = "clearOnReload";
            this.lblUsedWidth.Text = "0";
            this.lblUsedWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedArmsLabel
            // 
            this.lblUsedArmsLabel.AutoSize = true;
            this.lblUsedArmsLabel.Location = new System.Drawing.Point(253, 200);
            this.lblUsedArmsLabel.Name = "lblUsedArmsLabel";
            this.lblUsedArmsLabel.Size = new System.Drawing.Size(116, 15);
            this.lblUsedArmsLabel.TabIndex = 21;
            this.lblUsedArmsLabel.Text = "Número de bobinas";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(11, 203);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 15);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Cortadora";
            // 
            // lblUsedWidthLabel
            // 
            this.lblUsedWidthLabel.AutoSize = true;
            this.lblUsedWidthLabel.Location = new System.Drawing.Point(253, 174);
            this.lblUsedWidthLabel.Name = "lblUsedWidthLabel";
            this.lblUsedWidthLabel.Size = new System.Drawing.Size(92, 15);
            this.lblUsedWidthLabel.TabIndex = 22;
            this.lblUsedWidthLabel.Text = "Ancho Utilizado";
            // 
            // lblCutterNameLabel
            // 
            this.lblCutterNameLabel.AutoSize = true;
            this.lblCutterNameLabel.Location = new System.Drawing.Point(549, 20);
            this.lblCutterNameLabel.Name = "lblCutterNameLabel";
            this.lblCutterNameLabel.Size = new System.Drawing.Size(61, 15);
            this.lblCutterNameLabel.TabIndex = 12;
            this.lblCutterNameLabel.Text = "Cortadora";
            // 
            // lblNotesLabel
            // 
            this.lblNotesLabel.AutoSize = true;
            this.lblNotesLabel.Location = new System.Drawing.Point(460, 173);
            this.lblNotesLabel.Name = "lblNotesLabel";
            this.lblNotesLabel.Size = new System.Drawing.Size(39, 15);
            this.lblNotesLabel.TabIndex = 12;
            this.lblNotesLabel.Text = "Notas";
            // 
            // lblNotes
            // 
            this.lblNotes.BackColor = System.Drawing.SystemColors.Window;
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(505, 170);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(399, 48);
            this.lblNotes.TabIndex = 3;
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUtilWidthLabel
            // 
            this.lblUtilWidthLabel.AutoSize = true;
            this.lblUtilWidthLabel.Location = new System.Drawing.Point(268, 20);
            this.lblUtilWidthLabel.Name = "lblUtilWidthLabel";
            this.lblUtilWidthLabel.Size = new System.Drawing.Size(51, 15);
            this.lblUtilWidthLabel.TabIndex = 12;
            this.lblUtilWidthLabel.Text = "Película";
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(616, 17);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(200, 21);
            this.lblCutterName.TabIndex = 3;
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(335, 17);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(200, 21);
            this.lblFilmName.TabIndex = 3;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbCombination
            // 
            this.grpbCombination.Controls.Add(this.checkBox6);
            this.grpbCombination.Controls.Add(this.checkBox5);
            this.grpbCombination.Controls.Add(this.checkBox4);
            this.grpbCombination.Controls.Add(this.checkBox3);
            this.grpbCombination.Controls.Add(this.checkBox2);
            this.grpbCombination.Controls.Add(this.checkBox1);
            this.grpbCombination.Controls.Add(this.lblWaste1);
            this.grpbCombination.Controls.Add(this.lblWaste2);
            this.grpbCombination.Controls.Add(this.lblCoil6);
            this.grpbCombination.Controls.Add(this.lblCoil5);
            this.grpbCombination.Controls.Add(this.lblCoil4);
            this.grpbCombination.Controls.Add(this.lblCoil3);
            this.grpbCombination.Controls.Add(this.lblColil2);
            this.grpbCombination.Controls.Add(this.lblCoil1);
            this.grpbCombination.Location = new System.Drawing.Point(3, 50);
            this.grpbCombination.Name = "grpbCombination";
            this.grpbCombination.Size = new System.Drawing.Size(1070, 115);
            this.grpbCombination.TabIndex = 0;
            this.grpbCombination.TabStop = false;
            this.grpbCombination.Text = "Combinación";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(820, 92);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(81, 17);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Single Face";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(643, 92);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(81, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Single Face";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(466, 92);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(81, 17);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Single Face";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(329, 92);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Single Face";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(173, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Single Face";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(37, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Single Face";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblWaste1
            // 
            this.lblWaste1.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste1.Location = new System.Drawing.Point(16, 21);
            this.lblWaste1.Name = "lblWaste1";
            this.lblWaste1.Size = new System.Drawing.Size(20, 66);
            this.lblWaste1.TabIndex = 1;
            this.lblWaste1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaste2
            // 
            this.lblWaste2.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste2.Location = new System.Drawing.Point(942, 21);
            this.lblWaste2.Name = "lblWaste2";
            this.lblWaste2.Size = new System.Drawing.Size(20, 66);
            this.lblWaste2.TabIndex = 2;
            this.lblWaste2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCoil6
            // 
            this.lblCoil6.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lblCoil6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoil6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoil6.Location = new System.Drawing.Point(820, 21);
            this.lblCoil6.Name = "lblCoil6";
            this.lblCoil6.Size = new System.Drawing.Size(122, 66);
            this.lblCoil6.TabIndex = 0;
            this.lblCoil6.Text = "Orden  : 7854 \r\nCliente : Flexoplast\r\nAncho  : 400mm\r\nCore     : 3\"";
            this.lblCoil6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCoil5
            // 
            this.lblCoil5.BackColor = System.Drawing.Color.Turquoise;
            this.lblCoil5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoil5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoil5.Location = new System.Drawing.Point(643, 21);
            this.lblCoil5.Name = "lblCoil5";
            this.lblCoil5.Size = new System.Drawing.Size(177, 66);
            this.lblCoil5.TabIndex = 0;
            this.lblCoil5.Text = "Orden  : 7854 \r\nCliente : Flexoplast\r\nAncho  : 400mm\r\nCore     : 3\"";
            this.lblCoil5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCoil4
            // 
            this.lblCoil4.BackColor = System.Drawing.Color.Orchid;
            this.lblCoil4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoil4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoil4.Location = new System.Drawing.Point(466, 21);
            this.lblCoil4.Name = "lblCoil4";
            this.lblCoil4.Size = new System.Drawing.Size(177, 66);
            this.lblCoil4.TabIndex = 0;
            this.lblCoil4.Text = "Orden  : 7854 \r\nCliente : Flexoplast\r\nAncho  : 400mm\r\nCore     : 3\"";
            this.lblCoil4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCoil3
            // 
            this.lblCoil3.BackColor = System.Drawing.Color.Tomato;
            this.lblCoil3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoil3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoil3.Location = new System.Drawing.Point(329, 21);
            this.lblCoil3.Name = "lblCoil3";
            this.lblCoil3.Size = new System.Drawing.Size(137, 66);
            this.lblCoil3.TabIndex = 0;
            this.lblCoil3.Text = "Orden  : 7854 \r\nCliente : Flexoplast\r\nAncho  : 400mm\r\nCore     : 3\"";
            this.lblCoil3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblColil2
            // 
            this.lblColil2.BackColor = System.Drawing.Color.Orange;
            this.lblColil2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblColil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColil2.Location = new System.Drawing.Point(173, 21);
            this.lblColil2.Name = "lblColil2";
            this.lblColil2.Size = new System.Drawing.Size(156, 66);
            this.lblColil2.TabIndex = 0;
            this.lblColil2.Text = "Orden  : 7854 \r\nCliente : Flexoplast\r\nAncho  : 400mm\r\nCore     : 3\"";
            this.lblColil2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCoil1
            // 
            this.lblCoil1.BackColor = System.Drawing.Color.Yellow;
            this.lblCoil1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoil1.Location = new System.Drawing.Point(36, 21);
            this.lblCoil1.Name = "lblCoil1";
            this.lblCoil1.Size = new System.Drawing.Size(137, 66);
            this.lblCoil1.TabIndex = 0;
            this.lblCoil1.Text = "Orden  : 7854 \r\nCliente : Flexoplast\r\nAncho  : 400mm\r\nCore     : 3\"";
            this.lblCoil1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudStopsNumber
            // 
            this.nudStopsNumber.Location = new System.Drawing.Point(185, 171);
            this.nudStopsNumber.Name = "nudStopsNumber";
            this.nudStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.nudStopsNumber.TabIndex = 11;
            this.nudStopsNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCoilDistribution);
            this.groupBox1.Location = new System.Drawing.Point(3, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvCoilDistribution
            // 
            this.dgvCoilDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilDistribution.ColumnHeadersVisible = false;
            this.dgvCoilDistribution.Location = new System.Drawing.Point(16, 20);
            this.dgvCoilDistribution.Name = "dgvCoilDistribution";
            this.dgvCoilDistribution.RowHeadersVisible = false;
            this.dgvCoilDistribution.RowHeadersWidth = 4;
            this.dgvCoilDistribution.RowTemplate.DividerHeight = 5;
            this.dgvCoilDistribution.RowTemplate.Height = 66;
            this.dgvCoilDistribution.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvCoilDistribution.Size = new System.Drawing.Size(946, 64);
            this.dgvCoilDistribution.TabIndex = 0;
            // 
            // frmTest8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTest8";
            this.Text = "frmTest";
            this.Load += new System.EventHandler(this.frmTest_Load);
            this.grpbOrder.ResumeLayout(false);
            this.grpbOrder.PerformLayout();
            this.grpbCombination.ResumeLayout(false);
            this.grpbCombination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopsNumber)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilDistribution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbOrder;
        private System.Windows.Forms.GroupBox grpbCombination;
        private System.Windows.Forms.Label lblCoil6;
        private System.Windows.Forms.Label lblCoil5;
        private System.Windows.Forms.Label lblCoil4;
        private System.Windows.Forms.Label lblCoil3;
        private System.Windows.Forms.Label lblColil2;
        private System.Windows.Forms.Label lblCoil1;
        private System.Windows.Forms.Label lblWaste1;
        private System.Windows.Forms.Label lblWaste2;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblUtilWidthLabel;
        private System.Windows.Forms.Label lblCutterNameLabel;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.Label lblUsedArms;
        private System.Windows.Forms.Label lblUsedWidth;
        private System.Windows.Forms.Label lblUsedArmsLabel;
        private System.Windows.Forms.Label lblUsedWidthLabel;
        private System.Windows.Forms.Label lblPercentage2;
        private System.Windows.Forms.Label lblWaste;
        private System.Windows.Forms.Label lblWasteLabel;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.Label lblStopsNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusImage;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolTip ttpCombination;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown nudStopsNumber;
        private System.Windows.Forms.Label lblNotesLabel;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ComboBox cmbCutter;
        private System.Windows.Forms.Button btnChangeCutter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCoilDistribution;
    }
}