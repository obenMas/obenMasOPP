namespace BPS
{
    partial class frmExportMailCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportMailCoil));
            this.grpbCoilMain = new System.Windows.Forms.GroupBox();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.cmbTurn = new System.Windows.Forms.ComboBox();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.grpbMotherCoils = new System.Windows.Forms.GroupBox();
            this.dgvMainCoils = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGramaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFormulationCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbWaste = new System.Windows.Forms.GroupBox();
            this.dgvDecrease = new System.Windows.Forms.DataGridView();
            this.clmDecreaseOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseFilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseFormulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseFormulationCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpbDeadTime = new System.Windows.Forms.GroupBox();
            this.dgvDeadTime = new System.Windows.Forms.DataGridView();
            this.clmDeadTimeLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpExportMainCoil = new System.Windows.Forms.ToolTip(this.components);
            this.grpbCoilMain.SuspendLayout();
            this.grpbMotherCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoils)).BeginInit();
            this.grpbWaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.grpbDeadTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbCoilMain
            // 
            this.grpbCoilMain.Controls.Add(this.cmbMachine);
            this.grpbCoilMain.Controls.Add(this.lblMachine);
            this.grpbCoilMain.Controls.Add(this.btnGetData);
            this.grpbCoilMain.Controls.Add(this.dtpEndDate);
            this.grpbCoilMain.Controls.Add(this.lblDateEnd);
            this.grpbCoilMain.Controls.Add(this.dtpInitDate);
            this.grpbCoilMain.Controls.Add(this.cmbTurn);
            this.grpbCoilMain.Controls.Add(this.lblDateStart);
            this.grpbCoilMain.Controls.Add(this.lblTurn);
            this.grpbCoilMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilMain.Location = new System.Drawing.Point(0, 0);
            this.grpbCoilMain.Name = "grpbCoilMain";
            this.grpbCoilMain.Size = new System.Drawing.Size(1128, 80);
            this.grpbCoilMain.TabIndex = 0;
            this.grpbCoilMain.TabStop = false;
            // 
            // cmbMachine
            // 
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(599, 16);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(245, 23);
            this.cmbMachine.TabIndex = 8;
            this.cmbMachine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMachine_KeyDown);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(532, 20);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMachine.TabIndex = 7;
            this.lblMachine.Text = "Máquina";
            // 
            // btnGetData
            // 
            this.btnGetData.Image = global::BPS.Properties.Resources.funnel;
            this.btnGetData.Location = new System.Drawing.Point(850, 49);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(25, 25);
            this.btnGetData.TabIndex = 6;
            this.ttpExportMainCoil.SetToolTip(this.btnGetData, "Filtrar");
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy     HH:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(601, 51);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(243, 21);
            this.dtpEndDate.TabIndex = 5;
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateEnd.Location = new System.Drawing.Point(532, 54);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(61, 15);
            this.lblDateEnd.TabIndex = 4;
            this.lblDateEnd.Text = "Fecha Fin";
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "dd/MM/yyyy     HH:mm";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(261, 51);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(243, 21);
            this.dtpInitDate.TabIndex = 3;
            // 
            // cmbTurn
            // 
            this.cmbTurn.FormattingEnabled = true;
            this.cmbTurn.Items.AddRange(new object[] {
            "Turno No. 01 Día",
            "Turno No. 01 Noche",
            "Turno No. 02 Día",
            "Turno No. 02 Noche",
            "Turno No. 03 Día",
            "Turno No. 03 Noche"});
            this.cmbTurn.Location = new System.Drawing.Point(261, 16);
            this.cmbTurn.Name = "cmbTurn";
            this.cmbTurn.Size = new System.Drawing.Size(243, 23);
            this.cmbTurn.TabIndex = 1;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDateStart.Location = new System.Drawing.Point(175, 54);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(73, 15);
            this.lblDateStart.TabIndex = 2;
            this.lblDateStart.Text = "Fecha Inicio";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(175, 20);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(39, 15);
            this.lblTurn.TabIndex = 0;
            this.lblTurn.Text = "Turno";
            // 
            // grpbMotherCoils
            // 
            this.grpbMotherCoils.Controls.Add(this.dgvMainCoils);
            this.grpbMotherCoils.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMotherCoils.Location = new System.Drawing.Point(0, 80);
            this.grpbMotherCoils.Name = "grpbMotherCoils";
            this.grpbMotherCoils.Size = new System.Drawing.Size(1128, 246);
            this.grpbMotherCoils.TabIndex = 1;
            this.grpbMotherCoils.TabStop = false;
            this.grpbMotherCoils.Text = "Rollos madre";
            // 
            // dgvMainCoils
            // 
            this.dgvMainCoils.AllowUserToAddRows = false;
            this.dgvMainCoils.AllowUserToDeleteRows = false;
            this.dgvMainCoils.AllowUserToOrderColumns = true;
            this.dgvMainCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmFilmName,
            this.clmInitDate,
            this.clmEndDate,
            this.clmWidth,
            this.clmLength,
            this.clmWeigth,
            this.clmSupervisor,
            this.clmGramaje,
            this.clmFormulation,
            this.clmFormulationCodsec});
            this.dgvMainCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoils.Name = "dgvMainCoils";
            this.dgvMainCoils.ReadOnly = true;
            this.dgvMainCoils.Size = new System.Drawing.Size(1122, 226);
            this.dgvMainCoils.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 70;
            // 
            // clmFilmName
            // 
            this.clmFilmName.HeaderText = "Pelicula";
            this.clmFilmName.Name = "clmFilmName";
            this.clmFilmName.ReadOnly = true;
            this.clmFilmName.Width = 220;
            // 
            // clmInitDate
            // 
            this.clmInitDate.HeaderText = "Fecha Inicio";
            this.clmInitDate.Name = "clmInitDate";
            this.clmInitDate.ReadOnly = true;
            this.clmInitDate.Width = 120;
            // 
            // clmEndDate
            // 
            this.clmEndDate.HeaderText = "Fecha Fin";
            this.clmEndDate.Name = "clmEndDate";
            this.clmEndDate.ReadOnly = true;
            this.clmEndDate.Width = 120;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 70;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            this.clmLength.Width = 70;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            this.clmWeigth.Width = 70;
            // 
            // clmSupervisor
            // 
            this.clmSupervisor.HeaderText = "Supervisor";
            this.clmSupervisor.Name = "clmSupervisor";
            this.clmSupervisor.ReadOnly = true;
            this.clmSupervisor.Width = 103;
            // 
            // clmGramaje
            // 
            this.clmGramaje.HeaderText = "Gramaje";
            this.clmGramaje.Name = "clmGramaje";
            this.clmGramaje.ReadOnly = true;
            // 
            // clmFormulation
            // 
            this.clmFormulation.HeaderText = "Formulación";
            this.clmFormulation.Name = "clmFormulation";
            this.clmFormulation.ReadOnly = true;
            // 
            // clmFormulationCodsec
            // 
            this.clmFormulationCodsec.HeaderText = "codsecFormulación";
            this.clmFormulationCodsec.Name = "clmFormulationCodsec";
            this.clmFormulationCodsec.ReadOnly = true;
            this.clmFormulationCodsec.Visible = false;
            // 
            // grpbWaste
            // 
            this.grpbWaste.Controls.Add(this.dgvDecrease);
            this.grpbWaste.Location = new System.Drawing.Point(3, 324);
            this.grpbWaste.Name = "grpbWaste";
            this.grpbWaste.Size = new System.Drawing.Size(431, 159);
            this.grpbWaste.TabIndex = 2;
            this.grpbWaste.TabStop = false;
            this.grpbWaste.Text = "Despedicio";
            // 
            // dgvDecrease
            // 
            this.dgvDecrease.AllowUserToAddRows = false;
            this.dgvDecrease.AllowUserToDeleteRows = false;
            this.dgvDecrease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecrease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDecreaseOrderNumber,
            this.clmDecreaseFilmType,
            this.clmDecreaseQuantity,
            this.clmDecreaseFormulation,
            this.clmDecreaseFormulationCodsec});
            this.dgvDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDecrease.Location = new System.Drawing.Point(3, 17);
            this.dgvDecrease.Name = "dgvDecrease";
            this.dgvDecrease.Size = new System.Drawing.Size(425, 139);
            this.dgvDecrease.TabIndex = 0;
            // 
            // clmDecreaseOrderNumber
            // 
            this.clmDecreaseOrderNumber.HeaderText = "Orden";
            this.clmDecreaseOrderNumber.Name = "clmDecreaseOrderNumber";
            this.clmDecreaseOrderNumber.ReadOnly = true;
            this.clmDecreaseOrderNumber.Width = 60;
            // 
            // clmDecreaseFilmType
            // 
            this.clmDecreaseFilmType.HeaderText = "Película";
            this.clmDecreaseFilmType.Name = "clmDecreaseFilmType";
            this.clmDecreaseFilmType.ReadOnly = true;
            // 
            // clmDecreaseQuantity
            // 
            this.clmDecreaseQuantity.HeaderText = "Cantidad";
            this.clmDecreaseQuantity.Name = "clmDecreaseQuantity";
            this.clmDecreaseQuantity.ReadOnly = true;
            // 
            // clmDecreaseFormulation
            // 
            this.clmDecreaseFormulation.HeaderText = "Formulación";
            this.clmDecreaseFormulation.Name = "clmDecreaseFormulation";
            this.clmDecreaseFormulation.ReadOnly = true;
            // 
            // clmDecreaseFormulationCodsec
            // 
            this.clmDecreaseFormulationCodsec.HeaderText = "formulationCodsec";
            this.clmDecreaseFormulationCodsec.Name = "clmDecreaseFormulationCodsec";
            this.clmDecreaseFormulationCodsec.Visible = false;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 479);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1043, 44);
            this.grpbEmpty.TabIndex = 4;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnExport);
            this.grpbMainCoilButtons.Controls.Add(this.btnCancel);
            this.grpbMainCoilButtons.Controls.Add(this.btnExit);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(1047, 479);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(81, 44);
            this.grpbMainCoilButtons.TabIndex = 5;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.arrow_curve;
            this.btnExport.Location = new System.Drawing.Point(3, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 0;
            this.ttpExportMainCoil.SetToolTip(this.btnExport, "Exportar a EXPRO");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(28, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 1;
            this.ttpExportMainCoil.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(53, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 2;
            this.ttpExportMainCoil.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpbDeadTime
            // 
            this.grpbDeadTime.Controls.Add(this.dgvDeadTime);
            this.grpbDeadTime.Location = new System.Drawing.Point(440, 324);
            this.grpbDeadTime.Name = "grpbDeadTime";
            this.grpbDeadTime.Size = new System.Drawing.Size(685, 159);
            this.grpbDeadTime.TabIndex = 3;
            this.grpbDeadTime.TabStop = false;
            this.grpbDeadTime.Text = "Tiempo Muerto";
            // 
            // dgvDeadTime
            // 
            this.dgvDeadTime.AllowUserToAddRows = false;
            this.dgvDeadTime.AllowUserToDeleteRows = false;
            this.dgvDeadTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeadTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDeadTimeLotNumber,
            this.clmDeadTimeInitDate,
            this.clmDeadTimeEndDate,
            this.clmDeadTimeTime,
            this.clmDeadTimeReason,
            this.clmDeadTimeGroup});
            this.dgvDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeadTime.Location = new System.Drawing.Point(3, 17);
            this.dgvDeadTime.Name = "dgvDeadTime";
            this.dgvDeadTime.ReadOnly = true;
            this.dgvDeadTime.Size = new System.Drawing.Size(679, 139);
            this.dgvDeadTime.TabIndex = 0;
            // 
            // clmDeadTimeLotNumber
            // 
            this.clmDeadTimeLotNumber.HeaderText = "Lote";
            this.clmDeadTimeLotNumber.Name = "clmDeadTimeLotNumber";
            this.clmDeadTimeLotNumber.ReadOnly = true;
            this.clmDeadTimeLotNumber.Width = 80;
            // 
            // clmDeadTimeInitDate
            // 
            this.clmDeadTimeInitDate.HeaderText = "Fecha Inicio";
            this.clmDeadTimeInitDate.Name = "clmDeadTimeInitDate";
            this.clmDeadTimeInitDate.ReadOnly = true;
            // 
            // clmDeadTimeEndDate
            // 
            this.clmDeadTimeEndDate.HeaderText = "Fecha Fin";
            this.clmDeadTimeEndDate.Name = "clmDeadTimeEndDate";
            this.clmDeadTimeEndDate.ReadOnly = true;
            // 
            // clmDeadTimeTime
            // 
            this.clmDeadTimeTime.HeaderText = "Tiempo";
            this.clmDeadTimeTime.Name = "clmDeadTimeTime";
            this.clmDeadTimeTime.ReadOnly = true;
            this.clmDeadTimeTime.Width = 60;
            // 
            // clmDeadTimeReason
            // 
            this.clmDeadTimeReason.HeaderText = "Motivo";
            this.clmDeadTimeReason.Name = "clmDeadTimeReason";
            this.clmDeadTimeReason.ReadOnly = true;
            this.clmDeadTimeReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDeadTimeReason.Width = 200;
            // 
            // clmDeadTimeGroup
            // 
            this.clmDeadTimeGroup.HeaderText = "Grupo";
            this.clmDeadTimeGroup.Name = "clmDeadTimeGroup";
            this.clmDeadTimeGroup.ReadOnly = true;
            this.clmDeadTimeGroup.Width = 60;
            // 
            // frmExportMailCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1128, 523);
            this.Controls.Add(this.grpbMotherCoils);
            this.Controls.Add(this.grpbCoilMain);
            this.Controls.Add(this.grpbWaste);
            this.Controls.Add(this.grpbDeadTime);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportMailCoil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Rollos Madres";
            this.Load += new System.EventHandler(this.frmExportMailCoil_Load);
            this.grpbCoilMain.ResumeLayout(false);
            this.grpbCoilMain.PerformLayout();
            this.grpbMotherCoils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoils)).EndInit();
            this.grpbWaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.grpbDeadTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCoilMain;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.ComboBox cmbTurn;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.GroupBox grpbMotherCoils;
        private System.Windows.Forms.DataGridView dgvMainCoils;
        private System.Windows.Forms.GroupBox grpbWaste;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpbDeadTime;
        private System.Windows.Forms.DataGridView dgvDecrease;
        private System.Windows.Forms.DataGridView dgvDeadTime;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGramaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFormulationCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseFilmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseFormulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseFormulationCodsec;
        private System.Windows.Forms.ToolTip ttpExportMainCoil;
    }
}