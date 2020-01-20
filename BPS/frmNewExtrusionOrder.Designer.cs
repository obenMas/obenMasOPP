namespace BPS
{
    partial class frmNewExtrusionOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewExtrusionOrder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtDispMaquina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEficiencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKgPorHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaquinas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvProductionOrder = new System.Windows.Forms.DataGridView();
            this.clmPOCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAgregarAPlan = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPOPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPOPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPOTiempoEstimado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPOObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCodsecPeliculaEstandar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsecOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTiempoRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTiempoMuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaFinalizacionEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEditarFormulacion = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCerrarOrden = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMoverASinPlanificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrder)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarCambios);
            this.groupBox1.Controls.Add(this.btnVisualizar);
            this.groupBox1.Controls.Add(this.txtDispMaquina);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEficiencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKgPorHora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbMaquinas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1351, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Máquina";
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(1083, 22);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(159, 30);
            this.btnGuardarCambios.TabIndex = 9;
            this.btnGuardarCambios.Text = "Guardar cambios al plan";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(969, 22);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(108, 30);
            this.btnVisualizar.TabIndex = 8;
            this.btnVisualizar.Text = "Visualizar cambios";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txtDispMaquina
            // 
            this.txtDispMaquina.Location = new System.Drawing.Point(833, 28);
            this.txtDispMaquina.Name = "txtDispMaquina";
            this.txtDispMaquina.Size = new System.Drawing.Size(74, 20);
            this.txtDispMaquina.TabIndex = 7;
            this.txtDispMaquina.Text = "90";
            this.txtDispMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "% Disp. Máquina";
            // 
            // txtEficiencia
            // 
            this.txtEficiencia.Location = new System.Drawing.Point(629, 28);
            this.txtEficiencia.Name = "txtEficiencia";
            this.txtEficiencia.Size = new System.Drawing.Size(74, 20);
            this.txtEficiencia.TabIndex = 5;
            this.txtEficiencia.Text = "97";
            this.txtEficiencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "% Eficiencia";
            // 
            // txtKgPorHora
            // 
            this.txtKgPorHora.Location = new System.Drawing.Point(450, 28);
            this.txtKgPorHora.Name = "txtKgPorHora";
            this.txtKgPorHora.Size = new System.Drawing.Size(67, 20);
            this.txtKgPorHora.TabIndex = 3;
            this.txtKgPorHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kg por Hora";
            // 
            // cmbMaquinas
            // 
            this.cmbMaquinas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaquinas.FormattingEnabled = true;
            this.cmbMaquinas.Location = new System.Drawing.Point(82, 28);
            this.cmbMaquinas.Name = "cmbMaquinas";
            this.cmbMaquinas.Size = new System.Drawing.Size(259, 21);
            this.cmbMaquinas.TabIndex = 1;
            this.cmbMaquinas.SelectedIndexChanged += new System.EventHandler(this.cmbMaquinas_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Máquina";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1351, 555);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExcel);
            this.groupBox5.Controls.Add(this.btnModificar);
            this.groupBox5.Controls.Add(this.dgv);
            this.groupBox5.Controls.Add(this.btnCalcular);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox5.Location = new System.Drawing.Point(3, 16);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(981, 536);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Plan";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(944, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(31, 35);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(202, 17);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(155, 24);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar fecha de inicio";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecPeliculaEstandar,
            this.clmCodsec,
            this.clmCodsecOrden,
            this.clmPelicula,
            this.clmPeso,
            this.clmProducido,
            this.clmTiempo,
            this.clmTiempoRestante,
            this.clmTiempoMuerto,
            this.clmFechaInicio,
            this.clmFechaFinal,
            this.clmFechaFinalizacionEstimada,
            this.clmEstado,
            this.clmNotas,
            this.clmEditarFormulacion,
            this.clmCerrarOrden,
            this.clmMoverASinPlanificar});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(3, 56);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 4;
            this.dgv.Size = new System.Drawing.Size(975, 477);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(28, 17);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(155, 24);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Estimar consumo de MP";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvProductionOrder);
            this.groupBox4.Controls.Add(this.btnNewOrder);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox4.Location = new System.Drawing.Point(987, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 536);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sin planificar";
            // 
            // dgvProductionOrder
            // 
            this.dgvProductionOrder.AllowUserToAddRows = false;
            this.dgvProductionOrder.AllowUserToDeleteRows = false;
            this.dgvProductionOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPOCodsec,
            this.clmAgregarAPlan,
            this.clmPOPelicula,
            this.clmPOPeso,
            this.clmPOTiempoEstimado,
            this.clmPOObs,
            this.clmEliminar});
            this.dgvProductionOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvProductionOrder.Location = new System.Drawing.Point(3, 56);
            this.dgvProductionOrder.Name = "dgvProductionOrder";
            this.dgvProductionOrder.ReadOnly = true;
            this.dgvProductionOrder.RowHeadersWidth = 4;
            this.dgvProductionOrder.Size = new System.Drawing.Size(355, 477);
            this.dgvProductionOrder.TabIndex = 6;
            this.dgvProductionOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionOrder_CellClick);
            // 
            // clmPOCodsec
            // 
            this.clmPOCodsec.HeaderText = "Production order codsec";
            this.clmPOCodsec.Name = "clmPOCodsec";
            this.clmPOCodsec.ReadOnly = true;
            this.clmPOCodsec.Visible = false;
            // 
            // clmAgregarAPlan
            // 
            this.clmAgregarAPlan.HeaderText = "Agregar al plan";
            this.clmAgregarAPlan.Image = global::BPS.Properties.Resources.arrow_left;
            this.clmAgregarAPlan.Name = "clmAgregarAPlan";
            this.clmAgregarAPlan.ReadOnly = true;
            this.clmAgregarAPlan.Width = 50;
            // 
            // clmPOPelicula
            // 
            this.clmPOPelicula.HeaderText = "Pelicula";
            this.clmPOPelicula.Name = "clmPOPelicula";
            this.clmPOPelicula.ReadOnly = true;
            this.clmPOPelicula.Width = 60;
            // 
            // clmPOPeso
            // 
            this.clmPOPeso.HeaderText = "Peso";
            this.clmPOPeso.Name = "clmPOPeso";
            this.clmPOPeso.ReadOnly = true;
            this.clmPOPeso.Width = 50;
            // 
            // clmPOTiempoEstimado
            // 
            this.clmPOTiempoEstimado.HeaderText = "Tiempo estimado (Hs)";
            this.clmPOTiempoEstimado.Name = "clmPOTiempoEstimado";
            this.clmPOTiempoEstimado.ReadOnly = true;
            // 
            // clmPOObs
            // 
            this.clmPOObs.HeaderText = "Observaciones";
            this.clmPOObs.Name = "clmPOObs";
            this.clmPOObs.ReadOnly = true;
            this.clmPOObs.Visible = false;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar orden";
            this.clmEliminar.Image = global::BPS.Properties.Resources.action_delete_sharp_thin;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEliminar.Width = 50;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewOrder.Image = global::BPS.Properties.Resources.add1;
            this.btnNewOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewOrder.Location = new System.Drawing.Point(6, 26);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(98, 24);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "Nueva orden";
            this.btnNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1357, 652);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar formulación estandar";
            this.dataGridViewImageColumn1.Image = global::BPS.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Mover a sin planificar";
            this.dataGridViewImageColumn2.Image = global::BPS.Properties.Resources.arrow_right;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Agregar al plan";
            this.dataGridViewImageColumn3.Image = global::BPS.Properties.Resources.arrow_left;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Eliminar orden";
            this.dataGridViewImageColumn4.Image = global::BPS.Properties.Resources.action_delete_sharp_thin;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // clmCodsecPeliculaEstandar
            // 
            this.clmCodsecPeliculaEstandar.HeaderText = "Codsec pelicula estandar";
            this.clmCodsecPeliculaEstandar.Name = "clmCodsecPeliculaEstandar";
            this.clmCodsecPeliculaEstandar.ReadOnly = true;
            this.clmCodsecPeliculaEstandar.Visible = false;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsecPlanDeCorte";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCodsecOrden
            // 
            this.clmCodsecOrden.HeaderText = "codsecOrden";
            this.clmCodsecOrden.Name = "clmCodsecOrden";
            this.clmCodsecOrden.ReadOnly = true;
            this.clmCodsecOrden.Visible = false;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 60;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Solicitado";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            this.clmPeso.Width = 65;
            // 
            // clmProducido
            // 
            this.clmProducido.HeaderText = "Producido";
            this.clmProducido.Name = "clmProducido";
            this.clmProducido.ReadOnly = true;
            this.clmProducido.Width = 65;
            // 
            // clmTiempo
            // 
            this.clmTiempo.HeaderText = "Tiempo Prod. (Hs)";
            this.clmTiempo.Name = "clmTiempo";
            this.clmTiempo.ReadOnly = true;
            this.clmTiempo.Width = 50;
            // 
            // clmTiempoRestante
            // 
            this.clmTiempoRestante.HeaderText = "Tiempo Restante (Hs)";
            this.clmTiempoRestante.Name = "clmTiempoRestante";
            this.clmTiempoRestante.ReadOnly = true;
            this.clmTiempoRestante.Width = 50;
            // 
            // clmTiempoMuerto
            // 
            this.clmTiempoMuerto.HeaderText = "Tiempo Muerto (Hs)";
            this.clmTiempoMuerto.Name = "clmTiempoMuerto";
            this.clmTiempoMuerto.ReadOnly = true;
            this.clmTiempoMuerto.Width = 50;
            // 
            // clmFechaInicio
            // 
            this.clmFechaInicio.HeaderText = "Fecha Inicio Programada";
            this.clmFechaInicio.Name = "clmFechaInicio";
            this.clmFechaInicio.ReadOnly = true;
            this.clmFechaInicio.Width = 125;
            // 
            // clmFechaFinal
            // 
            this.clmFechaFinal.HeaderText = "Fecha Finalización Programada";
            this.clmFechaFinal.Name = "clmFechaFinal";
            this.clmFechaFinal.ReadOnly = true;
            this.clmFechaFinal.Width = 125;
            // 
            // clmFechaFinalizacionEstimada
            // 
            this.clmFechaFinalizacionEstimada.HeaderText = "Fecha Finalización Estimada";
            this.clmFechaFinalizacionEstimada.Name = "clmFechaFinalizacionEstimada";
            this.clmFechaFinalizacionEstimada.ReadOnly = true;
            this.clmFechaFinalizacionEstimada.Width = 125;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            this.clmEstado.Visible = false;
            // 
            // clmNotas
            // 
            this.clmNotas.HeaderText = "Notas";
            this.clmNotas.Name = "clmNotas";
            this.clmNotas.ReadOnly = true;
            // 
            // clmEditarFormulacion
            // 
            this.clmEditarFormulacion.HeaderText = "Editar form. est.";
            this.clmEditarFormulacion.Image = global::BPS.Properties.Resources.pencil;
            this.clmEditarFormulacion.Name = "clmEditarFormulacion";
            this.clmEditarFormulacion.ReadOnly = true;
            this.clmEditarFormulacion.Width = 45;
            // 
            // clmCerrarOrden
            // 
            this.clmCerrarOrden.HeaderText = "Cerrar orden";
            this.clmCerrarOrden.Image = global::BPS.Properties.Resources.lock1;
            this.clmCerrarOrden.Name = "clmCerrarOrden";
            this.clmCerrarOrden.ReadOnly = true;
            this.clmCerrarOrden.Width = 45;
            // 
            // clmMoverASinPlanificar
            // 
            this.clmMoverASinPlanificar.HeaderText = "Mov. a sin planif.";
            this.clmMoverASinPlanificar.Image = global::BPS.Properties.Resources.arrow_right;
            this.clmMoverASinPlanificar.Name = "clmMoverASinPlanificar";
            this.clmMoverASinPlanificar.ReadOnly = true;
            this.clmMoverASinPlanificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmMoverASinPlanificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmMoverASinPlanificar.Width = 40;
            // 
            // frmNewExtrusionOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1357, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewExtrusionOrder";
            this.Text = "Plan de extrusión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNewExtrusionOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrder)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMaquinas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDispMaquina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEficiencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKgPorHora;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvProductionOrder;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOCodsec;
        private System.Windows.Forms.DataGridViewImageColumn clmAgregarAPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOTiempoEstimado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPOObs;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecPeliculaEstandar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiempoRestante;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTiempoMuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaFinalizacionEstimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotas;
        private System.Windows.Forms.DataGridViewImageColumn clmEditarFormulacion;
        private System.Windows.Forms.DataGridViewImageColumn clmCerrarOrden;
        private System.Windows.Forms.DataGridViewImageColumn clmMoverASinPlanificar;
    }
}