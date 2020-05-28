namespace BPS
{
    partial class frmNewExtrusionPlan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPlanificado = new System.Windows.Forms.DataGridView();
            this.clmSecuencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrdenExtrusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTiempoMuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvSinPlanificar = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PlanNumber = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpInitTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.numVelocity = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numEfficiency = new System.Windows.Forms.NumericUpDown();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numAvailability = new System.Windows.Forms.NumericUpDown();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmOrdenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeliculaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificado)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinPlanificar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVelocity)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEfficiency)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailability)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1229, 559);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 78);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1223, 398);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPlanificado);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planificado";
            // 
            // dgvPlanificado
            // 
            this.dgvPlanificado.AllowUserToAddRows = false;
            this.dgvPlanificado.AllowUserToDeleteRows = false;
            this.dgvPlanificado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanificado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSecuencia,
            this.clmOrdenExtrusion,
            this.clmTiempoMuerto,
            this.clmPelicula,
            this.clmCantidad,
            this.clmExtruido,
            this.clmTiempo,
            this.clmInicio,
            this.clmFin,
            this.clmObservaciones,
            this.clmQuitar});
            this.dgvPlanificado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanificado.Location = new System.Drawing.Point(3, 16);
            this.dgvPlanificado.Name = "dgvPlanificado";
            this.dgvPlanificado.ReadOnly = true;
            this.dgvPlanificado.Size = new System.Drawing.Size(844, 373);
            this.dgvPlanificado.TabIndex = 0;
            // 
            // clmSecuencia
            // 
            this.clmSecuencia.HeaderText = "N° Secuencia";
            this.clmSecuencia.Name = "clmSecuencia";
            this.clmSecuencia.ReadOnly = true;
            this.clmSecuencia.Width = 65;
            // 
            // clmOrdenExtrusion
            // 
            this.clmOrdenExtrusion.HeaderText = "Orden de extrusión";
            this.clmOrdenExtrusion.Name = "clmOrdenExtrusion";
            this.clmOrdenExtrusion.ReadOnly = true;
            this.clmOrdenExtrusion.Width = 60;
            // 
            // clmTiempoMuerto
            // 
            this.clmTiempoMuerto.HeaderText = "Tiempo muerto";
            this.clmTiempoMuerto.Name = "clmTiempoMuerto";
            this.clmTiempoMuerto.ReadOnly = true;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 50;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad solicitada";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Width = 65;
            // 
            // clmExtruido
            // 
            this.clmExtruido.HeaderText = "Cantidad extruida";
            this.clmExtruido.Name = "clmExtruido";
            this.clmExtruido.ReadOnly = true;
            this.clmExtruido.Width = 65;
            // 
            // clmTiempo
            // 
            this.clmTiempo.HeaderText = "Tiempo";
            this.clmTiempo.Name = "clmTiempo";
            this.clmTiempo.ReadOnly = true;
            this.clmTiempo.Width = 45;
            // 
            // clmInicio
            // 
            this.clmInicio.HeaderText = "Fecha inicio";
            this.clmInicio.Name = "clmInicio";
            this.clmInicio.ReadOnly = true;
            this.clmInicio.Width = 80;
            // 
            // clmFin
            // 
            this.clmFin.HeaderText = "Fecha fin";
            this.clmFin.Name = "clmFin";
            this.clmFin.ReadOnly = true;
            this.clmFin.Width = 80;
            // 
            // clmObservaciones
            // 
            this.clmObservaciones.HeaderText = "Observaciones";
            this.clmObservaciones.Name = "clmObservaciones";
            this.clmObservaciones.ReadOnly = true;
            this.clmObservaciones.Width = 150;
            // 
            // clmQuitar
            // 
            this.clmQuitar.HeaderText = "";
            this.clmQuitar.Image = global::BPS.Properties.Resources.arrow_right;
            this.clmQuitar.Name = "clmQuitar";
            this.clmQuitar.ReadOnly = true;
            this.clmQuitar.Width = 30;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvSinPlanificar);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(859, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(361, 392);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Sin planificar";
            // 
            // dgvSinPlanificar
            // 
            this.dgvSinPlanificar.AllowUserToAddRows = false;
            this.dgvSinPlanificar.AllowUserToDeleteRows = false;
            this.dgvSinPlanificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinPlanificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAgregar,
            this.clmOrdenSP,
            this.clmPeliculaSP,
            this.clmCantidadSP});
            this.dgvSinPlanificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSinPlanificar.Location = new System.Drawing.Point(3, 16);
            this.dgvSinPlanificar.Name = "dgvSinPlanificar";
            this.dgvSinPlanificar.ReadOnly = true;
            this.dgvSinPlanificar.Size = new System.Drawing.Size(355, 373);
            this.dgvSinPlanificar.TabIndex = 0;
            this.dgvSinPlanificar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinPlanificar_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel2);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1223, 69);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PlanNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrevious, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNext, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNew, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExcel, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox7, 8, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1217, 50);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plan de extrusión N°";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlanNumber
            // 
            this.PlanNumber.AutoSize = true;
            this.PlanNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanNumber.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanNumber.Location = new System.Drawing.Point(263, 0);
            this.PlanNumber.Name = "PlanNumber";
            this.PlanNumber.Size = new System.Drawing.Size(74, 50);
            this.PlanNumber.TabIndex = 2;
            this.PlanNumber.Text = "100";
            this.PlanNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Image = global::BPS.Properties.Resources.arrow_left;
            this.btnPrevious.Location = new System.Drawing.Point(343, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(24, 44);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Image = global::BPS.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(373, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 44);
            this.btnNext.TabIndex = 4;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.Location = new System.Drawing.Point(403, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 44);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "Crear nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(1190, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(24, 44);
            this.btnExcel.TabIndex = 8;
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMachine);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(483, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 44);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Máquina";
            // 
            // cmbMachine
            // 
            this.cmbMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMachine.Enabled = false;
            this.cmbMachine.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(3, 16);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(138, 22);
            this.cmbMachine.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpInitTime);
            this.groupBox3.Location = new System.Drawing.Point(703, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 44);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha de inicio";
            // 
            // dtpInitTime
            // 
            this.dtpInitTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInitTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpInitTime.Enabled = false;
            this.dtpInitTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitTime.Location = new System.Drawing.Point(3, 16);
            this.dtpInitTime.Name = "dtpInitTime";
            this.dtpInitTime.Size = new System.Drawing.Size(168, 23);
            this.dtpInitTime.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkActive);
            this.groupBox4.Location = new System.Drawing.Point(633, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(64, 44);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Activo";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkActive.Location = new System.Drawing.Point(3, 16);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(58, 25);
            this.chkActive.TabIndex = 6;
            this.chkActive.Text = "Si/No";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtObservations);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(883, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(301, 44);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Observaciones";
            // 
            // txtObservations
            // 
            this.txtObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservations.Location = new System.Drawing.Point(3, 16);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(295, 25);
            this.txtObservations.TabIndex = 0;
            this.txtObservations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 482);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1223, 74);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox8, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(859, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(361, 68);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnNewOrder);
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(114, 62);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Orden de extrusión";
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewOrder.Location = new System.Drawing.Point(3, 16);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(108, 43);
            this.btnNewOrder.TabIndex = 0;
            this.btnNewOrder.Text = "Nueva orden";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox9, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox13, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(850, 68);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel7);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(3, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(474, 62);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Parametros del plan";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel7.Controls.Add(this.groupBox10, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox11, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.groupBox12, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnApply, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(468, 43);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.numVelocity);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(111, 37);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Velocidad [Kg/h]";
            // 
            // numVelocity
            // 
            this.numVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numVelocity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numVelocity.Location = new System.Drawing.Point(3, 16);
            this.numVelocity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numVelocity.Name = "numVelocity";
            this.numVelocity.Size = new System.Drawing.Size(105, 20);
            this.numVelocity.TabIndex = 0;
            this.numVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numEfficiency);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(120, 3);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(111, 37);
            this.groupBox11.TabIndex = 1;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Eficiencia [%]";
            // 
            // numEfficiency
            // 
            this.numEfficiency.DecimalPlaces = 2;
            this.numEfficiency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numEfficiency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numEfficiency.Location = new System.Drawing.Point(3, 16);
            this.numEfficiency.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEfficiency.Name = "numEfficiency";
            this.numEfficiency.Size = new System.Drawing.Size(105, 20);
            this.numEfficiency.TabIndex = 0;
            this.numEfficiency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numAvailability);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox12.Location = new System.Drawing.Point(237, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(111, 37);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Disp. de Máq. [%]";
            // 
            // numAvailability
            // 
            this.numAvailability.DecimalPlaces = 2;
            this.numAvailability.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numAvailability.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAvailability.Location = new System.Drawing.Point(3, 16);
            this.numAvailability.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAvailability.Name = "numAvailability";
            this.numAvailability.Size = new System.Drawing.Size(105, 20);
            this.numAvailability.TabIndex = 0;
            this.numAvailability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnApply.Location = new System.Drawing.Point(354, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(111, 37);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Aplicar cambios";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnEstimate);
            this.groupBox13.Location = new System.Drawing.Point(483, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(114, 62);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Consumo de MP";
            // 
            // btnEstimate
            // 
            this.btnEstimate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstimate.Location = new System.Drawing.Point(3, 16);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(108, 43);
            this.btnEstimate.TabIndex = 0;
            this.btnEstimate.Text = "Estimar consumo";
            this.btnEstimate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BPS.Properties.Resources.arrow_right;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Agregar";
            this.dataGridViewImageColumn2.Image = global::BPS.Properties.Resources.arrow_left;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // clmAgregar
            // 
            this.clmAgregar.HeaderText = "Agregar";
            this.clmAgregar.Image = global::BPS.Properties.Resources.arrow_left;
            this.clmAgregar.Name = "clmAgregar";
            this.clmAgregar.ReadOnly = true;
            this.clmAgregar.Width = 60;
            // 
            // clmOrdenSP
            // 
            this.clmOrdenSP.HeaderText = "Orden";
            this.clmOrdenSP.Name = "clmOrdenSP";
            this.clmOrdenSP.ReadOnly = true;
            this.clmOrdenSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmOrdenSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmOrdenSP.Width = 60;
            // 
            // clmPeliculaSP
            // 
            this.clmPeliculaSP.HeaderText = "Pelicula";
            this.clmPeliculaSP.Name = "clmPeliculaSP";
            this.clmPeliculaSP.ReadOnly = true;
            this.clmPeliculaSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmPeliculaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clmCantidadSP
            // 
            this.clmCantidadSP.HeaderText = "Cantidad";
            this.clmCantidadSP.Name = "clmCantidadSP";
            this.clmCantidadSP.ReadOnly = true;
            this.clmCantidadSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCantidadSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCantidadSP.Width = 80;
            // 
            // frmNewExtrusionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 559);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmNewExtrusionPlan";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanificado)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinPlanificar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVelocity)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEfficiency)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAvailability)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PlanNumber;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvPlanificado;
        private System.Windows.Forms.DateTimePicker dtpInitTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSecuencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrdenExtrusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiempoMuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservaciones;
        private System.Windows.Forms.DataGridViewImageColumn clmQuitar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvSinPlanificar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.NumericUpDown numVelocity;
        private System.Windows.Forms.NumericUpDown numEfficiency;
        private System.Windows.Forms.NumericUpDown numAvailability;
        private System.Windows.Forms.DataGridViewImageColumn clmAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrdenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeliculaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadSP;
    }
}