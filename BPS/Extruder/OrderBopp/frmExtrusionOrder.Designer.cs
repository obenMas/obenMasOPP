namespace BPS
{
    partial class frmExtrusionOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtrusionOrder));
            this.gprbCalendar = new System.Windows.Forms.GroupBox();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.grpbMachine = new System.Windows.Forms.GroupBox();
            this.txtKPH = new System.Windows.Forms.TextBox();
            this.lblMaximumWidthValue = new System.Windows.Forms.Label();
            this.lblMaximumWidth = new System.Windows.Forms.Label();
            this.lblMinimumWidthValue = new System.Windows.Forms.Label();
            this.lblMinimumWidth = new System.Windows.Forms.Label();
            this.lblKPH = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.grpbLotInformation = new System.Windows.Forms.GroupBox();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.cmbFormulation = new System.Windows.Forms.ComboBox();
            this.lblFormulation = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtWidths = new System.Windows.Forms.TextBox();
            this.lblWidths = new System.Windows.Forms.Label();
            this.txtProductionTime = new System.Windows.Forms.TextBox();
            this.lblProductionTime = new System.Windows.Forms.Label();
            this.txtKgPerHour = new System.Windows.Forms.TextBox();
            this.lblKgPerHour = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.TextBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ttpOrderExtruction = new System.Windows.Forms.ToolTip(this.components);
            this.clmMachineCalendarCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarPOCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarPONumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarKilogramsPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarProductionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarInitDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarEndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarWidths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gprbCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.grpbMachine.SuspendLayout();
            this.grpbLotInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gprbCalendar
            // 
            this.gprbCalendar.Controls.Add(this.dgvCalendar);
            this.gprbCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gprbCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gprbCalendar.Location = new System.Drawing.Point(0, 39);
            this.gprbCalendar.Name = "gprbCalendar";
            this.gprbCalendar.Size = new System.Drawing.Size(1041, 369);
            this.gprbCalendar.TabIndex = 1;
            this.gprbCalendar.TabStop = false;
            this.gprbCalendar.Text = "Calendario";
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.AllowDrop = true;
            this.dgvCalendar.AllowUserToAddRows = false;
            this.dgvCalendar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMachineCalendarCodsec,
            this.clmMachineCalendarPOCodsec,
            this.clmMachineCalendarPONumber,
            this.clmMachineCalendarFilm,
            this.clmMachineCalendarWeight,
            this.clmMachineCalendarKilogramsPerHour,
            this.clmMachineCalendarProductionTime,
            this.clmMachineCalendarInitDateTime,
            this.clmMachineCalendarEndDateTime,
            this.clmMachineCalendarWidths,
            this.clmMachineCalendarLength,
            this.clmMachineCalendarCustomers,
            this.clmMachineCalendarNotes,
            this.clmActions});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalendar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendar.Location = new System.Drawing.Point(3, 16);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.ReadOnly = true;
            this.dgvCalendar.RowHeadersWidth = 20;
            this.dgvCalendar.Size = new System.Drawing.Size(1035, 350);
            this.dgvCalendar.TabIndex = 0;
            this.dgvCalendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendar_CellClick);
            // 
            // grpbMachine
            // 
            this.grpbMachine.Controls.Add(this.txtKPH);
            this.grpbMachine.Controls.Add(this.lblMaximumWidthValue);
            this.grpbMachine.Controls.Add(this.lblMaximumWidth);
            this.grpbMachine.Controls.Add(this.lblMinimumWidthValue);
            this.grpbMachine.Controls.Add(this.lblMinimumWidth);
            this.grpbMachine.Controls.Add(this.lblKPH);
            this.grpbMachine.Controls.Add(this.cmbMachine);
            this.grpbMachine.Controls.Add(this.lblMachine);
            this.grpbMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMachine.Location = new System.Drawing.Point(0, 0);
            this.grpbMachine.Name = "grpbMachine";
            this.grpbMachine.Size = new System.Drawing.Size(1041, 39);
            this.grpbMachine.TabIndex = 0;
            this.grpbMachine.TabStop = false;
            this.grpbMachine.Text = "Máquina";
            // 
            // txtKPH
            // 
            this.txtKPH.Location = new System.Drawing.Point(470, 11);
            this.txtKPH.Name = "txtKPH";
            this.txtKPH.Size = new System.Drawing.Size(100, 21);
            this.txtKPH.TabIndex = 3;
            // 
            // lblMaximumWidthValue
            // 
            this.lblMaximumWidthValue.BackColor = System.Drawing.SystemColors.Window;
            this.lblMaximumWidthValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaximumWidthValue.Location = new System.Drawing.Point(829, 11);
            this.lblMaximumWidthValue.Name = "lblMaximumWidthValue";
            this.lblMaximumWidthValue.Size = new System.Drawing.Size(60, 21);
            this.lblMaximumWidthValue.TabIndex = 7;
            this.lblMaximumWidthValue.Text = "0";
            this.lblMaximumWidthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaximumWidth
            // 
            this.lblMaximumWidth.AutoSize = true;
            this.lblMaximumWidth.Location = new System.Drawing.Point(734, 14);
            this.lblMaximumWidth.Name = "lblMaximumWidth";
            this.lblMaximumWidth.Size = new System.Drawing.Size(89, 15);
            this.lblMaximumWidth.TabIndex = 6;
            this.lblMaximumWidth.Text = "Ancho máximo";
            // 
            // lblMinimumWidthValue
            // 
            this.lblMinimumWidthValue.BackColor = System.Drawing.SystemColors.Window;
            this.lblMinimumWidthValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMinimumWidthValue.Location = new System.Drawing.Point(668, 11);
            this.lblMinimumWidthValue.Name = "lblMinimumWidthValue";
            this.lblMinimumWidthValue.Size = new System.Drawing.Size(60, 21);
            this.lblMinimumWidthValue.TabIndex = 5;
            this.lblMinimumWidthValue.Text = "0";
            this.lblMinimumWidthValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinimumWidth
            // 
            this.lblMinimumWidth.AutoSize = true;
            this.lblMinimumWidth.Location = new System.Drawing.Point(576, 14);
            this.lblMinimumWidth.Name = "lblMinimumWidth";
            this.lblMinimumWidth.Size = new System.Drawing.Size(86, 15);
            this.lblMinimumWidth.TabIndex = 4;
            this.lblMinimumWidth.Text = "Ancho mínimo";
            // 
            // lblKPH
            // 
            this.lblKPH.AutoSize = true;
            this.lblKPH.Location = new System.Drawing.Point(420, 14);
            this.lblKPH.Name = "lblKPH";
            this.lblKPH.Size = new System.Drawing.Size(44, 15);
            this.lblKPH.TabIndex = 2;
            this.lblKPH.Text = "Kg./Hr.";
            // 
            // cmbMachine
            // 
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(188, 10);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(226, 23);
            this.cmbMachine.TabIndex = 1;
            this.cmbMachine.SelectedIndexChanged += new System.EventHandler(this.cmbMachine_SelectedIndexChanged);
            this.cmbMachine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMachine_KeyDown);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(126, 14);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "Máquina";
            // 
            // grpbLotInformation
            // 
            this.grpbLotInformation.Controls.Add(this.btnViewDetail);
            this.grpbLotInformation.Controls.Add(this.txtWeight);
            this.grpbLotInformation.Controls.Add(this.lblWeight);
            this.grpbLotInformation.Controls.Add(this.btnProcess);
            this.grpbLotInformation.Controls.Add(this.dtpInitDate);
            this.grpbLotInformation.Controls.Add(this.lblInitDate);
            this.grpbLotInformation.Controls.Add(this.cmbFormulation);
            this.grpbLotInformation.Controls.Add(this.lblFormulation);
            this.grpbLotInformation.Controls.Add(this.txtNotes);
            this.grpbLotInformation.Controls.Add(this.lblNotes);
            this.grpbLotInformation.Controls.Add(this.txtLength);
            this.grpbLotInformation.Controls.Add(this.lblLength);
            this.grpbLotInformation.Controls.Add(this.txtWidths);
            this.grpbLotInformation.Controls.Add(this.lblWidths);
            this.grpbLotInformation.Controls.Add(this.txtProductionTime);
            this.grpbLotInformation.Controls.Add(this.lblProductionTime);
            this.grpbLotInformation.Controls.Add(this.txtKgPerHour);
            this.grpbLotInformation.Controls.Add(this.lblKgPerHour);
            this.grpbLotInformation.Controls.Add(this.txtFilm);
            this.grpbLotInformation.Controls.Add(this.lblFilm);
            this.grpbLotInformation.Controls.Add(this.txtNumber);
            this.grpbLotInformation.Controls.Add(this.lblNumber);
            this.grpbLotInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbLotInformation.Enabled = false;
            this.grpbLotInformation.Location = new System.Drawing.Point(0, 408);
            this.grpbLotInformation.Name = "grpbLotInformation";
            this.grpbLotInformation.Size = new System.Drawing.Size(1041, 107);
            this.grpbLotInformation.TabIndex = 2;
            this.grpbLotInformation.TabStop = false;
            this.grpbLotInformation.Text = "Información del Lote";
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackgroundImage = global::BPS.Properties.Resources.eye;
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewDetail.Location = new System.Drawing.Point(5, 77);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(25, 25);
            this.btnViewDetail.TabIndex = 27;
            this.btnViewDetail.UseVisualStyleBackColor = true;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Enabled = false;
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(263, 16);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 24);
            this.txtWeight.TabIndex = 3;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(220, 21);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(35, 15);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "Peso";
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Properties.Resources.gear_32;
            this.btnProcess.Location = new System.Drawing.Point(893, 21);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(61, 66);
            this.btnProcess.TabIndex = 16;
            this.btnProcess.Text = "Extruir";
            this.btnProcess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpOrderExtruction.SetToolTip(this.btnProcess, "Extruir");
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "dddd, dd MMMM yyyy     HH:mm";
            this.dtpInitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(555, 77);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(332, 24);
            this.dtpInitDate.TabIndex = 15;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(457, 82);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(90, 15);
            this.lblInitDate.TabIndex = 14;
            this.lblInitDate.Text = "Fecha de Inicio";
            // 
            // cmbFormulation
            // 
            this.cmbFormulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormulation.FormattingEnabled = true;
            this.cmbFormulation.Location = new System.Drawing.Point(115, 76);
            this.cmbFormulation.Name = "cmbFormulation";
            this.cmbFormulation.Size = new System.Drawing.Size(336, 26);
            this.cmbFormulation.TabIndex = 13;
            // 
            // lblFormulation
            // 
            this.lblFormulation.AutoSize = true;
            this.lblFormulation.Location = new System.Drawing.Point(36, 82);
            this.lblFormulation.Name = "lblFormulation";
            this.lblFormulation.Size = new System.Drawing.Size(76, 15);
            this.lblFormulation.TabIndex = 12;
            this.lblFormulation.Text = "Formulación";
            // 
            // txtNotes
            // 
            this.txtNotes.Enabled = false;
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(469, 47);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(418, 24);
            this.txtNotes.TabIndex = 11;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(375, 52);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(88, 15);
            this.lblNotes.TabIndex = 10;
            this.lblNotes.Text = "Observaciones";
            // 
            // txtLength
            // 
            this.txtLength.Enabled = false;
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(263, 47);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 24);
            this.txtLength.TabIndex = 11;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(208, 52);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(49, 15);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Metraje";
            // 
            // txtWidths
            // 
            this.txtWidths.Enabled = false;
            this.txtWidths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidths.Location = new System.Drawing.Point(91, 47);
            this.txtWidths.Name = "txtWidths";
            this.txtWidths.Size = new System.Drawing.Size(100, 24);
            this.txtWidths.TabIndex = 11;
            // 
            // lblWidths
            // 
            this.lblWidths.AutoSize = true;
            this.lblWidths.Location = new System.Drawing.Point(36, 52);
            this.lblWidths.Name = "lblWidths";
            this.lblWidths.Size = new System.Drawing.Size(47, 15);
            this.lblWidths.TabIndex = 10;
            this.lblWidths.Text = "Anchos";
            // 
            // txtProductionTime
            // 
            this.txtProductionTime.Enabled = false;
            this.txtProductionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductionTime.Location = new System.Drawing.Point(787, 16);
            this.txtProductionTime.Name = "txtProductionTime";
            this.txtProductionTime.Size = new System.Drawing.Size(100, 24);
            this.txtProductionTime.TabIndex = 9;
            // 
            // lblProductionTime
            // 
            this.lblProductionTime.AutoSize = true;
            this.lblProductionTime.Location = new System.Drawing.Point(698, 21);
            this.lblProductionTime.Name = "lblProductionTime";
            this.lblProductionTime.Size = new System.Drawing.Size(81, 15);
            this.lblProductionTime.TabIndex = 8;
            this.lblProductionTime.Text = "Tiempo Prod.";
            // 
            // txtKgPerHour
            // 
            this.txtKgPerHour.Enabled = false;
            this.txtKgPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKgPerHour.Location = new System.Drawing.Point(590, 16);
            this.txtKgPerHour.Name = "txtKgPerHour";
            this.txtKgPerHour.Size = new System.Drawing.Size(100, 24);
            this.txtKgPerHour.TabIndex = 7;
            this.txtKgPerHour.TextChanged += new System.EventHandler(this.txtKgPerHour_TextChanged);
            // 
            // lblKgPerHour
            // 
            this.lblKgPerHour.AutoSize = true;
            this.lblKgPerHour.Location = new System.Drawing.Point(538, 21);
            this.lblKgPerHour.Name = "lblKgPerHour";
            this.lblKgPerHour.Size = new System.Drawing.Size(44, 15);
            this.lblKgPerHour.TabIndex = 6;
            this.lblKgPerHour.Text = "Kg./Hr.";
            // 
            // txtFilm
            // 
            this.txtFilm.Enabled = false;
            this.txtFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilm.Location = new System.Drawing.Point(430, 16);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(100, 24);
            this.txtFilm.TabIndex = 5;
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.Location = new System.Drawing.Point(371, 21);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(51, 15);
            this.lblFilm.TabIndex = 4;
            this.lblFilm.Text = "Película";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(91, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 24);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(36, 21);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(52, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Número";
            // 
            // clmMachineCalendarCodsec
            // 
            this.clmMachineCalendarCodsec.HeaderText = "codsec";
            this.clmMachineCalendarCodsec.Name = "clmMachineCalendarCodsec";
            this.clmMachineCalendarCodsec.ReadOnly = true;
            this.clmMachineCalendarCodsec.Visible = false;
            // 
            // clmMachineCalendarPOCodsec
            // 
            this.clmMachineCalendarPOCodsec.HeaderText = "POCodsec";
            this.clmMachineCalendarPOCodsec.Name = "clmMachineCalendarPOCodsec";
            this.clmMachineCalendarPOCodsec.ReadOnly = true;
            this.clmMachineCalendarPOCodsec.Visible = false;
            // 
            // clmMachineCalendarPONumber
            // 
            this.clmMachineCalendarPONumber.HeaderText = "Ord. Prod. Nro.";
            this.clmMachineCalendarPONumber.Name = "clmMachineCalendarPONumber";
            this.clmMachineCalendarPONumber.ReadOnly = true;
            // 
            // clmMachineCalendarFilm
            // 
            this.clmMachineCalendarFilm.HeaderText = "Película";
            this.clmMachineCalendarFilm.Name = "clmMachineCalendarFilm";
            this.clmMachineCalendarFilm.ReadOnly = true;
            this.clmMachineCalendarFilm.Width = 70;
            // 
            // clmMachineCalendarWeight
            // 
            this.clmMachineCalendarWeight.HeaderText = "Peso";
            this.clmMachineCalendarWeight.Name = "clmMachineCalendarWeight";
            this.clmMachineCalendarWeight.ReadOnly = true;
            this.clmMachineCalendarWeight.Width = 65;
            // 
            // clmMachineCalendarKilogramsPerHour
            // 
            this.clmMachineCalendarKilogramsPerHour.HeaderText = "Kg./Hr.";
            this.clmMachineCalendarKilogramsPerHour.Name = "clmMachineCalendarKilogramsPerHour";
            this.clmMachineCalendarKilogramsPerHour.ReadOnly = true;
            this.clmMachineCalendarKilogramsPerHour.Width = 65;
            // 
            // clmMachineCalendarProductionTime
            // 
            this.clmMachineCalendarProductionTime.HeaderText = "Tiempo Prod.";
            this.clmMachineCalendarProductionTime.Name = "clmMachineCalendarProductionTime";
            this.clmMachineCalendarProductionTime.ReadOnly = true;
            this.clmMachineCalendarProductionTime.Width = 80;
            // 
            // clmMachineCalendarInitDateTime
            // 
            this.clmMachineCalendarInitDateTime.HeaderText = "Fecha Inicio";
            this.clmMachineCalendarInitDateTime.Name = "clmMachineCalendarInitDateTime";
            this.clmMachineCalendarInitDateTime.ReadOnly = true;
            this.clmMachineCalendarInitDateTime.Width = 115;
            // 
            // clmMachineCalendarEndDateTime
            // 
            this.clmMachineCalendarEndDateTime.HeaderText = "Fecha Finalización";
            this.clmMachineCalendarEndDateTime.Name = "clmMachineCalendarEndDateTime";
            this.clmMachineCalendarEndDateTime.ReadOnly = true;
            this.clmMachineCalendarEndDateTime.Width = 115;
            // 
            // clmMachineCalendarWidths
            // 
            this.clmMachineCalendarWidths.HeaderText = "Anchos";
            this.clmMachineCalendarWidths.Name = "clmMachineCalendarWidths";
            this.clmMachineCalendarWidths.ReadOnly = true;
            this.clmMachineCalendarWidths.Width = 80;
            // 
            // clmMachineCalendarLength
            // 
            this.clmMachineCalendarLength.HeaderText = "Metraje";
            this.clmMachineCalendarLength.Name = "clmMachineCalendarLength";
            this.clmMachineCalendarLength.ReadOnly = true;
            this.clmMachineCalendarLength.Width = 70;
            // 
            // clmMachineCalendarCustomers
            // 
            this.clmMachineCalendarCustomers.HeaderText = "Clientes";
            this.clmMachineCalendarCustomers.Name = "clmMachineCalendarCustomers";
            this.clmMachineCalendarCustomers.ReadOnly = true;
            // 
            // clmMachineCalendarNotes
            // 
            this.clmMachineCalendarNotes.HeaderText = "Notas";
            this.clmMachineCalendarNotes.Name = "clmMachineCalendarNotes";
            this.clmMachineCalendarNotes.ReadOnly = true;
            this.clmMachineCalendarNotes.Width = 150;
            // 
            // clmActions
            // 
            this.clmActions.HeaderText = "Acciones";
            this.clmActions.Name = "clmActions";
            this.clmActions.ReadOnly = true;
            this.clmActions.Visible = false;
            this.clmActions.Width = 60;
            // 
            // frmExtrusionOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1041, 515);
            this.Controls.Add(this.gprbCalendar);
            this.Controls.Add(this.grpbLotInformation);
            this.Controls.Add(this.grpbMachine);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExtrusionOrder";
            this.Text = "Ordenes de Extrusion";
            this.Load += new System.EventHandler(this.frmExtrusionOrder_Load);
            this.gprbCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.grpbMachine.ResumeLayout(false);
            this.grpbMachine.PerformLayout();
            this.grpbLotInformation.ResumeLayout(false);
            this.grpbLotInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gprbCalendar;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.GroupBox grpbMachine;
        private System.Windows.Forms.TextBox txtKPH;
        private System.Windows.Forms.Label lblMaximumWidthValue;
        private System.Windows.Forms.Label lblMaximumWidth;
        private System.Windows.Forms.Label lblMinimumWidthValue;
        private System.Windows.Forms.Label lblMinimumWidth;
        private System.Windows.Forms.Label lblKPH;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.GroupBox grpbLotInformation;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtProductionTime;
        private System.Windows.Forms.Label lblProductionTime;
        private System.Windows.Forms.TextBox txtKgPerHour;
        private System.Windows.Forms.Label lblKgPerHour;
        private System.Windows.Forms.TextBox txtFilm;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.ComboBox cmbFormulation;
        private System.Windows.Forms.Label lblFormulation;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWidths;
        private System.Windows.Forms.Label lblWidths;
        private System.Windows.Forms.ToolTip ttpOrderExtruction;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarPOCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarPONumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarKilogramsPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarProductionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarInitDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarEndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarWidths;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarNotes;
        private System.Windows.Forms.DataGridViewButtonColumn clmActions;
    }
}