namespace BPS
{
    partial class frmProductionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReport));
            this.grpInfoDate = new System.Windows.Forms.GroupBox();
            this.cmbInnig = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.grpMainCoilList = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.lblTotalWaste = new System.Windows.Forms.Label();
            this.lblProductionTotal = new System.Windows.Forms.Label();
            this.lblWasteTotalLabel = new System.Windows.Forms.Label();
            this.lblProductionTotalLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.ttpReportProduction = new System.Windows.Forms.ToolTip(this.components);
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbWaste = new System.Windows.Forms.GroupBox();
            this.dgvDecrease = new System.Windows.Forms.DataGridView();
            this.clmDecreaseOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseFilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseFormulation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseFormulationCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbDeadTime = new System.Windows.Forms.GroupBox();
            this.dgvDeadTime = new System.Windows.Forms.DataGridView();
            this.clmDeadTimeLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTOtherHrsLabel = new System.Windows.Forms.Label();
            this.lblTOtherLabel = new System.Windows.Forms.Label();
            this.lblTOther = new System.Windows.Forms.Label();
            this.lblTmmHrsLabel = new System.Windows.Forms.Label();
            this.lblTmmLabel = new System.Windows.Forms.Label();
            this.lblTmm = new System.Windows.Forms.Label();
            this.lblTmpHrsLabel = new System.Windows.Forms.Label();
            this.lblTmpLabel = new System.Windows.Forms.Label();
            this.lblTmp = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblConsumptionLabelKglabel = new System.Windows.Forms.Label();
            this.lblConsumptionLabel = new System.Windows.Forms.Label();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.lblPecentageLabel = new System.Windows.Forms.Label();
            this.lblEfficiencyLabel = new System.Windows.Forms.Label();
            this.lblEfficiency = new System.Windows.Forms.Label();
            this.lblProductionTotalKgLabel = new System.Windows.Forms.Label();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAccumulator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInfoDate.SuspendLayout();
            this.grpMainCoilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.grpbWaste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).BeginInit();
            this.grpbDeadTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoDate
            // 
            this.grpInfoDate.Controls.Add(this.cmbInnig);
            this.grpInfoDate.Controls.Add(this.label17);
            this.grpInfoDate.Controls.Add(this.btnFilter);
            this.grpInfoDate.Controls.Add(this.dtpDate);
            this.grpInfoDate.Controls.Add(this.lblEndDate);
            this.grpInfoDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfoDate.Location = new System.Drawing.Point(0, 0);
            this.grpInfoDate.Name = "grpInfoDate";
            this.grpInfoDate.Size = new System.Drawing.Size(1128, 44);
            this.grpInfoDate.TabIndex = 0;
            this.grpInfoDate.TabStop = false;
            // 
            // cmbInnig
            // 
            this.cmbInnig.FormattingEnabled = true;
            this.cmbInnig.Items.AddRange(new object[] {
            "Día",
            "Noche"});
            this.cmbInnig.Location = new System.Drawing.Point(247, 13);
            this.cmbInnig.Name = "cmbInnig";
            this.cmbInnig.Size = new System.Drawing.Size(211, 23);
            this.cmbInnig.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(199, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Turno:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(856, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 4;
            this.ttpReportProduction.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(562, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(253, 21);
            this.dtpDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(492, 17);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(64, 15);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Fecha Fin:";
            // 
            // grpMainCoilList
            // 
            this.grpMainCoilList.Controls.Add(this.dgvMainCoilList);
            this.grpMainCoilList.Location = new System.Drawing.Point(0, 43);
            this.grpMainCoilList.Name = "grpMainCoilList";
            this.grpMainCoilList.Size = new System.Drawing.Size(1124, 226);
            this.grpMainCoilList.TabIndex = 1;
            this.grpMainCoilList.TabStop = false;
            this.grpMainCoilList.Text = "Rollos Madre";
            // 
            // dgvMainCoilList
            // 
            this.dgvMainCoilList.AllowUserToAddRows = false;
            this.dgvMainCoilList.AllowUserToDeleteRows = false;
            this.dgvMainCoilList.AllowUserToOrderColumns = true;
            this.dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmInitDate,
            this.clmEndDate,
            this.clmHours,
            this.clmCode,
            this.clmTypeFilm,
            this.clmOrder,
            this.clmLength,
            this.clmKilos,
            this.clmWidth,
            this.clmAccumulator});
            this.dgvMainCoilList.Location = new System.Drawing.Point(4, 15);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.Size = new System.Drawing.Size(1116, 206);
            this.dgvMainCoilList.TabIndex = 0;
            // 
            // lblTotalWaste
            // 
            this.lblTotalWaste.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalWaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWaste.Location = new System.Drawing.Point(160, 11);
            this.lblTotalWaste.Name = "lblTotalWaste";
            this.lblTotalWaste.Size = new System.Drawing.Size(103, 21);
            this.lblTotalWaste.TabIndex = 7;
            this.lblTotalWaste.Tag = "";
            this.lblTotalWaste.Text = "0";
            this.lblTotalWaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductionTotal
            // 
            this.lblProductionTotal.BackColor = System.Drawing.SystemColors.Window;
            this.lblProductionTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionTotal.Location = new System.Drawing.Point(280, 11);
            this.lblProductionTotal.Name = "lblProductionTotal";
            this.lblProductionTotal.Size = new System.Drawing.Size(130, 21);
            this.lblProductionTotal.TabIndex = 1;
            this.lblProductionTotal.Tag = "";
            this.lblProductionTotal.Text = "0";
            this.lblProductionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteTotalLabel
            // 
            this.lblWasteTotalLabel.AutoSize = true;
            this.lblWasteTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWasteTotalLabel.Location = new System.Drawing.Point(42, 14);
            this.lblWasteTotalLabel.Name = "lblWasteTotalLabel";
            this.lblWasteTotalLabel.Size = new System.Drawing.Size(112, 15);
            this.lblWasteTotalLabel.TabIndex = 6;
            this.lblWasteTotalLabel.Text = "Total Desperdicios:";
            // 
            // lblProductionTotalLabel
            // 
            this.lblProductionTotalLabel.AutoSize = true;
            this.lblProductionTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionTotalLabel.Location = new System.Drawing.Point(172, 14);
            this.lblProductionTotalLabel.Name = "lblProductionTotalLabel";
            this.lblProductionTotalLabel.Size = new System.Drawing.Size(102, 15);
            this.lblProductionTotalLabel.TabIndex = 0;
            this.lblProductionTotalLabel.Text = "Producción Total:";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(37, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.ttpReportProduction.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(6, 9);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.ttpReportProduction.SetToolTip(this.btnReport, "Reporte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnExit);
            this.grpbActions.Controls.Add(this.btnReport);
            this.grpbActions.Location = new System.Drawing.Point(1064, 483);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(63, 37);
            this.grpbActions.TabIndex = 5;
            this.grpbActions.TabStop = false;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 484);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1062, 36);
            this.grpbEmpty.TabIndex = 6;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbWaste
            // 
            this.grpbWaste.Controls.Add(this.dgvDecrease);
            this.grpbWaste.Location = new System.Drawing.Point(0, 300);
            this.grpbWaste.Name = "grpbWaste";
            this.grpbWaste.Size = new System.Drawing.Size(431, 159);
            this.grpbWaste.TabIndex = 7;
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
            // grpbDeadTime
            // 
            this.grpbDeadTime.Controls.Add(this.dgvDeadTime);
            this.grpbDeadTime.Location = new System.Drawing.Point(435, 300);
            this.grpbDeadTime.Name = "grpbDeadTime";
            this.grpbDeadTime.Size = new System.Drawing.Size(690, 159);
            this.grpbDeadTime.TabIndex = 8;
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
            this.dgvDeadTime.Size = new System.Drawing.Size(684, 139);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblWasteTotalLabel);
            this.groupBox1.Controls.Add(this.lblTotalWaste);
            this.groupBox1.Location = new System.Drawing.Point(0, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 36);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTOtherHrsLabel);
            this.groupBox2.Controls.Add(this.lblTOtherLabel);
            this.groupBox2.Controls.Add(this.lblTOther);
            this.groupBox2.Controls.Add(this.lblTmmHrsLabel);
            this.groupBox2.Controls.Add(this.lblTmmLabel);
            this.groupBox2.Controls.Add(this.lblTmm);
            this.groupBox2.Controls.Add(this.lblTmpHrsLabel);
            this.groupBox2.Controls.Add(this.lblTmpLabel);
            this.groupBox2.Controls.Add(this.lblTmp);
            this.groupBox2.Location = new System.Drawing.Point(437, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 36);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // lblTOtherHrsLabel
            // 
            this.lblTOtherHrsLabel.AutoSize = true;
            this.lblTOtherHrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOtherHrsLabel.Location = new System.Drawing.Point(620, 15);
            this.lblTOtherHrsLabel.Name = "lblTOtherHrsLabel";
            this.lblTOtherHrsLabel.Size = new System.Drawing.Size(29, 15);
            this.lblTOtherHrsLabel.TabIndex = 16;
            this.lblTOtherHrsLabel.Text = "Hrs.";
            // 
            // lblTOtherLabel
            // 
            this.lblTOtherLabel.AutoSize = true;
            this.lblTOtherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOtherLabel.Location = new System.Drawing.Point(450, 15);
            this.lblTOtherLabel.Name = "lblTOtherLabel";
            this.lblTOtherLabel.Size = new System.Drawing.Size(57, 15);
            this.lblTOtherLabel.TabIndex = 14;
            this.lblTOtherLabel.Text = "TMOtros:";
            // 
            // lblTOther
            // 
            this.lblTOther.BackColor = System.Drawing.SystemColors.Window;
            this.lblTOther.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTOther.Location = new System.Drawing.Point(513, 12);
            this.lblTOther.Name = "lblTOther";
            this.lblTOther.Size = new System.Drawing.Size(103, 21);
            this.lblTOther.TabIndex = 15;
            this.lblTOther.Tag = "";
            this.lblTOther.Text = "0";
            this.lblTOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTmmHrsLabel
            // 
            this.lblTmmHrsLabel.AutoSize = true;
            this.lblTmmHrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmmHrsLabel.Location = new System.Drawing.Point(394, 14);
            this.lblTmmHrsLabel.Name = "lblTmmHrsLabel";
            this.lblTmmHrsLabel.Size = new System.Drawing.Size(29, 15);
            this.lblTmmHrsLabel.TabIndex = 13;
            this.lblTmmHrsLabel.Text = "Hrs.";
            // 
            // lblTmmLabel
            // 
            this.lblTmmLabel.AutoSize = true;
            this.lblTmmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmmLabel.Location = new System.Drawing.Point(242, 14);
            this.lblTmmLabel.Name = "lblTmmLabel";
            this.lblTmmLabel.Size = new System.Drawing.Size(39, 15);
            this.lblTmmLabel.TabIndex = 11;
            this.lblTmmLabel.Text = "TMM:";
            // 
            // lblTmm
            // 
            this.lblTmm.BackColor = System.Drawing.SystemColors.Window;
            this.lblTmm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmm.Location = new System.Drawing.Point(287, 11);
            this.lblTmm.Name = "lblTmm";
            this.lblTmm.Size = new System.Drawing.Size(103, 21);
            this.lblTmm.TabIndex = 12;
            this.lblTmm.Tag = "";
            this.lblTmm.Text = "0";
            this.lblTmm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTmpHrsLabel
            // 
            this.lblTmpHrsLabel.AutoSize = true;
            this.lblTmpHrsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmpHrsLabel.Location = new System.Drawing.Point(190, 14);
            this.lblTmpHrsLabel.Name = "lblTmpHrsLabel";
            this.lblTmpHrsLabel.Size = new System.Drawing.Size(29, 15);
            this.lblTmpHrsLabel.TabIndex = 10;
            this.lblTmpHrsLabel.Text = "Hrs.";
            // 
            // lblTmpLabel
            // 
            this.lblTmpLabel.AutoSize = true;
            this.lblTmpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmpLabel.Location = new System.Drawing.Point(41, 14);
            this.lblTmpLabel.Name = "lblTmpLabel";
            this.lblTmpLabel.Size = new System.Drawing.Size(36, 15);
            this.lblTmpLabel.TabIndex = 8;
            this.lblTmpLabel.Text = "TMP:";
            // 
            // lblTmp
            // 
            this.lblTmp.BackColor = System.Drawing.SystemColors.Window;
            this.lblTmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmp.Location = new System.Drawing.Point(83, 11);
            this.lblTmp.Name = "lblTmp";
            this.lblTmp.Size = new System.Drawing.Size(103, 21);
            this.lblTmp.TabIndex = 9;
            this.lblTmp.Tag = "";
            this.lblTmp.Text = "0";
            this.lblTmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblConsumptionLabelKglabel);
            this.groupBox3.Controls.Add(this.lblConsumptionLabel);
            this.groupBox3.Controls.Add(this.lblConsumption);
            this.groupBox3.Controls.Add(this.lblPecentageLabel);
            this.groupBox3.Controls.Add(this.lblEfficiencyLabel);
            this.groupBox3.Controls.Add(this.lblEfficiency);
            this.groupBox3.Controls.Add(this.lblProductionTotalKgLabel);
            this.groupBox3.Controls.Add(this.lblProductionTotalLabel);
            this.groupBox3.Controls.Add(this.lblProductionTotal);
            this.groupBox3.Location = new System.Drawing.Point(0, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1126, 36);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // lblConsumptionLabelKglabel
            // 
            this.lblConsumptionLabelKglabel.AutoSize = true;
            this.lblConsumptionLabelKglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumptionLabelKglabel.Location = new System.Drawing.Point(930, 14);
            this.lblConsumptionLabelKglabel.Name = "lblConsumptionLabelKglabel";
            this.lblConsumptionLabelKglabel.Size = new System.Drawing.Size(25, 15);
            this.lblConsumptionLabelKglabel.TabIndex = 24;
            this.lblConsumptionLabelKglabel.Text = "Kg.";
            // 
            // lblConsumptionLabel
            // 
            this.lblConsumptionLabel.AutoSize = true;
            this.lblConsumptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumptionLabel.Location = new System.Drawing.Point(726, 14);
            this.lblConsumptionLabel.Name = "lblConsumptionLabel";
            this.lblConsumptionLabel.Size = new System.Drawing.Size(63, 15);
            this.lblConsumptionLabel.TabIndex = 22;
            this.lblConsumptionLabel.Text = "Consumo:";
            // 
            // lblConsumption
            // 
            this.lblConsumption.BackColor = System.Drawing.SystemColors.Window;
            this.lblConsumption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsumption.Location = new System.Drawing.Point(795, 11);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(130, 21);
            this.lblConsumption.TabIndex = 23;
            this.lblConsumption.Tag = "";
            this.lblConsumption.Text = "0";
            this.lblConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPecentageLabel
            // 
            this.lblPecentageLabel.AutoSize = true;
            this.lblPecentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPecentageLabel.Location = new System.Drawing.Point(682, 14);
            this.lblPecentageLabel.Name = "lblPecentageLabel";
            this.lblPecentageLabel.Size = new System.Drawing.Size(18, 15);
            this.lblPecentageLabel.TabIndex = 21;
            this.lblPecentageLabel.Text = "%";
            // 
            // lblEfficiencyLabel
            // 
            this.lblEfficiencyLabel.AutoSize = true;
            this.lblEfficiencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfficiencyLabel.Location = new System.Drawing.Point(477, 14);
            this.lblEfficiencyLabel.Name = "lblEfficiencyLabel";
            this.lblEfficiencyLabel.Size = new System.Drawing.Size(63, 15);
            this.lblEfficiencyLabel.TabIndex = 19;
            this.lblEfficiencyLabel.Text = "Eficiencia:";
            // 
            // lblEfficiency
            // 
            this.lblEfficiency.BackColor = System.Drawing.SystemColors.Window;
            this.lblEfficiency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfficiency.Location = new System.Drawing.Point(546, 11);
            this.lblEfficiency.Name = "lblEfficiency";
            this.lblEfficiency.Size = new System.Drawing.Size(130, 21);
            this.lblEfficiency.TabIndex = 20;
            this.lblEfficiency.Tag = "";
            this.lblEfficiency.Text = "0";
            this.lblEfficiency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblProductionTotalKgLabel
            // 
            this.lblProductionTotalKgLabel.AutoSize = true;
            this.lblProductionTotalKgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionTotalKgLabel.Location = new System.Drawing.Point(416, 14);
            this.lblProductionTotalKgLabel.Name = "lblProductionTotalKgLabel";
            this.lblProductionTotalKgLabel.Size = new System.Drawing.Size(25, 15);
            this.lblProductionTotalKgLabel.TabIndex = 18;
            this.lblProductionTotalKgLabel.Text = "Kg.";
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.ReadOnly = true;
            this.clmcodsec.Visible = false;
            // 
            // clmInitDate
            // 
            this.clmInitDate.HeaderText = "F. Inicio";
            this.clmInitDate.Name = "clmInitDate";
            this.clmInitDate.ReadOnly = true;
            this.clmInitDate.Width = 150;
            // 
            // clmEndDate
            // 
            this.clmEndDate.HeaderText = "F. Fin";
            this.clmEndDate.Name = "clmEndDate";
            this.clmEndDate.ReadOnly = true;
            this.clmEndDate.Width = 150;
            // 
            // clmHours
            // 
            this.clmHours.HeaderText = "Horas";
            this.clmHours.Name = "clmHours";
            this.clmHours.ReadOnly = true;
            this.clmHours.Width = 70;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmTypeFilm
            // 
            this.clmTypeFilm.HeaderText = "Tipo";
            this.clmTypeFilm.Name = "clmTypeFilm";
            this.clmTypeFilm.ReadOnly = true;
            this.clmTypeFilm.Width = 70;
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Orden";
            this.clmOrder.Name = "clmOrder";
            this.clmOrder.ReadOnly = true;
            this.clmOrder.Width = 70;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            // 
            // clmKilos
            // 
            this.clmKilos.HeaderText = "Kilos";
            this.clmKilos.Name = "clmKilos";
            this.clmKilos.ReadOnly = true;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmAccumulator
            // 
            this.clmAccumulator.HeaderText = "Acumulado";
            this.clmAccumulator.Name = "clmAccumulator";
            this.clmAccumulator.ReadOnly = true;
            // 
            // frmProductionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1128, 523);
            this.Controls.Add(this.grpMainCoilList);
            this.Controls.Add(this.grpbWaste);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpInfoDate);
            this.Controls.Add(this.grpbDeadTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReport";
            this.Text = "Informe de Control de Producción en Proceso";
            this.grpInfoDate.ResumeLayout(false);
            this.grpInfoDate.PerformLayout();
            this.grpMainCoilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbWaste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).EndInit();
            this.grpbDeadTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox grpMainCoilList;
        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.Label lblWasteTotalLabel;
        private System.Windows.Forms.Label lblProductionTotalLabel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Label lblTotalWaste;
        private System.Windows.Forms.Label lblProductionTotal;
        private System.Windows.Forms.ToolTip ttpReportProduction;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbWaste;
        private System.Windows.Forms.DataGridView dgvDecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseFilmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseFormulation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseFormulationCodsec;
        private System.Windows.Forms.GroupBox grpbDeadTime;
        private System.Windows.Forms.DataGridView dgvDeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTmpLabel;
        private System.Windows.Forms.Label lblTmp;
        private System.Windows.Forms.Label lblTOtherHrsLabel;
        private System.Windows.Forms.Label lblTOtherLabel;
        private System.Windows.Forms.Label lblTOther;
        private System.Windows.Forms.Label lblTmmHrsLabel;
        private System.Windows.Forms.Label lblTmmLabel;
        private System.Windows.Forms.Label lblTmm;
        private System.Windows.Forms.Label lblTmpHrsLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblConsumptionLabelKglabel;
        private System.Windows.Forms.Label lblConsumptionLabel;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.Label lblPecentageLabel;
        private System.Windows.Forms.Label lblEfficiencyLabel;
        private System.Windows.Forms.Label lblEfficiency;
        private System.Windows.Forms.Label lblProductionTotalKgLabel;
        private System.Windows.Forms.ComboBox cmbInnig;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTypeFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAccumulator;
    }
}