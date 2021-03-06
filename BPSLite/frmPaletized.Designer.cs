namespace BPS.Lite
{
    partial class frmPaletized
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaletized));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbFiltroPosicion = new System.Windows.Forms.ComboBox();
            this.cmbFiltroPedido = new System.Windows.Forms.ComboBox();
            this.cmbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.cmbFiltroCore = new System.Windows.Forms.ComboBox();
            this.cmbFiltroDiametro = new System.Windows.Forms.ComboBox();
            this.cmbFiltroAncho = new System.Windows.Forms.ComboBox();
            this.cmbFiltroPelicula = new System.Windows.Forms.ComboBox();
            this.cmbFiltroPallet = new System.Windows.Forms.ComboBox();
            this.cmbFiltroOrigen = new System.Windows.Forms.ComboBox();
            this.cmbFiltroBodega = new System.Windows.Forms.ComboBox();
            this.cmbFiltroPlanta = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ancho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Core = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bobinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPesoTot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPalletCant = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCoilTot = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.cmbFiltroPosicion);
            this.groupBox1.Controls.Add(this.cmbFiltroPedido);
            this.groupBox1.Controls.Add(this.cmbFiltroCliente);
            this.groupBox1.Controls.Add(this.cmbFiltroCore);
            this.groupBox1.Controls.Add(this.cmbFiltroDiametro);
            this.groupBox1.Controls.Add(this.cmbFiltroAncho);
            this.groupBox1.Controls.Add(this.cmbFiltroPelicula);
            this.groupBox1.Controls.Add(this.cmbFiltroPallet);
            this.groupBox1.Controls.Add(this.cmbFiltroOrigen);
            this.groupBox1.Controls.Add(this.cmbFiltroBodega);
            this.groupBox1.Controls.Add(this.cmbFiltroPlanta);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1228, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(1177, 39);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(31, 23);
            this.btnExcel.TabIndex = 37;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Lite.Properties.Resources.cross;
            this.btnCancel.Location = new System.Drawing.Point(1141, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbFiltroPosicion
            // 
            this.cmbFiltroPosicion.FormattingEnabled = true;
            this.cmbFiltroPosicion.Location = new System.Drawing.Point(1077, 41);
            this.cmbFiltroPosicion.Name = "cmbFiltroPosicion";
            this.cmbFiltroPosicion.Size = new System.Drawing.Size(58, 21);
            this.cmbFiltroPosicion.TabIndex = 35;
            this.cmbFiltroPosicion.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPosicion_SelectedIndexChanged);
            this.cmbFiltroPosicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroPosicion_KeyDown);
            // 
            // cmbFiltroPedido
            // 
            this.cmbFiltroPedido.FormattingEnabled = true;
            this.cmbFiltroPedido.Location = new System.Drawing.Point(1009, 41);
            this.cmbFiltroPedido.Name = "cmbFiltroPedido";
            this.cmbFiltroPedido.Size = new System.Drawing.Size(61, 21);
            this.cmbFiltroPedido.TabIndex = 34;
            this.cmbFiltroPedido.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPedido_SelectedIndexChanged);
            this.cmbFiltroPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroPedido_KeyDown);
            // 
            // cmbFiltroCliente
            // 
            this.cmbFiltroCliente.FormattingEnabled = true;
            this.cmbFiltroCliente.Location = new System.Drawing.Point(686, 41);
            this.cmbFiltroCliente.Name = "cmbFiltroCliente";
            this.cmbFiltroCliente.Size = new System.Drawing.Size(316, 21);
            this.cmbFiltroCliente.TabIndex = 33;
            this.cmbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCliente_SelectedIndexChanged);
            this.cmbFiltroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroCliente_KeyDown);
            // 
            // cmbFiltroCore
            // 
            this.cmbFiltroCore.FormattingEnabled = true;
            this.cmbFiltroCore.Location = new System.Drawing.Point(631, 41);
            this.cmbFiltroCore.Name = "cmbFiltroCore";
            this.cmbFiltroCore.Size = new System.Drawing.Size(49, 21);
            this.cmbFiltroCore.TabIndex = 32;
            this.cmbFiltroCore.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCore_SelectedIndexChanged);
            this.cmbFiltroCore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroCore_KeyDown);
            // 
            // cmbFiltroDiametro
            // 
            this.cmbFiltroDiametro.FormattingEnabled = true;
            this.cmbFiltroDiametro.Location = new System.Drawing.Point(574, 41);
            this.cmbFiltroDiametro.Name = "cmbFiltroDiametro";
            this.cmbFiltroDiametro.Size = new System.Drawing.Size(50, 21);
            this.cmbFiltroDiametro.TabIndex = 31;
            this.cmbFiltroDiametro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroDiametro_SelectedIndexChanged);
            this.cmbFiltroDiametro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroDiametro_KeyDown);
            // 
            // cmbFiltroAncho
            // 
            this.cmbFiltroAncho.FormattingEnabled = true;
            this.cmbFiltroAncho.Location = new System.Drawing.Point(509, 41);
            this.cmbFiltroAncho.Name = "cmbFiltroAncho";
            this.cmbFiltroAncho.Size = new System.Drawing.Size(58, 21);
            this.cmbFiltroAncho.TabIndex = 30;
            this.cmbFiltroAncho.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroAncho_SelectedIndexChanged);
            this.cmbFiltroAncho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroAncho_KeyDown);
            // 
            // cmbFiltroPelicula
            // 
            this.cmbFiltroPelicula.FormattingEnabled = true;
            this.cmbFiltroPelicula.Location = new System.Drawing.Point(423, 41);
            this.cmbFiltroPelicula.Name = "cmbFiltroPelicula";
            this.cmbFiltroPelicula.Size = new System.Drawing.Size(79, 21);
            this.cmbFiltroPelicula.TabIndex = 29;
            this.cmbFiltroPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPelicula_SelectedIndexChanged);
            this.cmbFiltroPelicula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroPelicula_KeyDown);
            // 
            // cmbFiltroPallet
            // 
            this.cmbFiltroPallet.FormattingEnabled = true;
            this.cmbFiltroPallet.Location = new System.Drawing.Point(318, 41);
            this.cmbFiltroPallet.Name = "cmbFiltroPallet";
            this.cmbFiltroPallet.Size = new System.Drawing.Size(98, 21);
            this.cmbFiltroPallet.TabIndex = 28;
            this.cmbFiltroPallet.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPallet_SelectedIndexChanged);
            this.cmbFiltroPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroPallet_KeyDown);
            // 
            // cmbFiltroOrigen
            // 
            this.cmbFiltroOrigen.FormattingEnabled = true;
            this.cmbFiltroOrigen.Location = new System.Drawing.Point(229, 41);
            this.cmbFiltroOrigen.Name = "cmbFiltroOrigen";
            this.cmbFiltroOrigen.Size = new System.Drawing.Size(82, 21);
            this.cmbFiltroOrigen.TabIndex = 27;
            this.cmbFiltroOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroOrigen_SelectedIndexChanged);
            this.cmbFiltroOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroOrigen_KeyDown);
            // 
            // cmbFiltroBodega
            // 
            this.cmbFiltroBodega.FormattingEnabled = true;
            this.cmbFiltroBodega.Location = new System.Drawing.Point(109, 41);
            this.cmbFiltroBodega.Name = "cmbFiltroBodega";
            this.cmbFiltroBodega.Size = new System.Drawing.Size(114, 21);
            this.cmbFiltroBodega.TabIndex = 25;
            this.cmbFiltroBodega.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroBodega_SelectedIndexChanged);
            this.cmbFiltroBodega.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroBodega_KeyDown);
            // 
            // cmbFiltroPlanta
            // 
            this.cmbFiltroPlanta.FormattingEnabled = true;
            this.cmbFiltroPlanta.Location = new System.Drawing.Point(19, 41);
            this.cmbFiltroPlanta.Name = "cmbFiltroPlanta";
            this.cmbFiltroPlanta.Size = new System.Drawing.Size(83, 21);
            this.cmbFiltroPlanta.TabIndex = 24;
            this.cmbFiltroPlanta.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPlanta_SelectedIndexChanged);
            this.cmbFiltroPlanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroPlanta_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1076, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Posición";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1008, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Pedido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(689, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(630, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Core";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(573, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Diametro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ancho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Pelicula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Pallet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bodega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Planta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Location = new System.Drawing.Point(12, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1228, 474);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Planta,
            this.Bodega,
            this.Clasificacion,
            this.Origen,
            this.Pallet,
            this.Pelicula,
            this.Ancho,
            this.Diametro,
            this.Core,
            this.Cliente,
            this.Pedido,
            this.PesoNeto,
            this.PesoBruto,
            this.Calificacion,
            this.Bobinas,
            this.Posicion});
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1216, 397);
            this.dgv.TabIndex = 0;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 70;
            // 
            // Planta
            // 
            this.Planta.HeaderText = "Planta";
            this.Planta.Name = "Planta";
            this.Planta.ReadOnly = true;
            this.Planta.Width = 70;
            // 
            // Bodega
            // 
            this.Bodega.HeaderText = "Bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.ReadOnly = true;
            this.Bodega.Width = 110;
            // 
            // Clasificacion
            // 
            this.Clasificacion.HeaderText = "Clasificación";
            this.Clasificacion.Name = "Clasificacion";
            this.Clasificacion.ReadOnly = true;
            this.Clasificacion.Visible = false;
            // 
            // Origen
            // 
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            this.Origen.Width = 80;
            // 
            // Pallet
            // 
            this.Pallet.HeaderText = "Pallet";
            this.Pallet.Name = "Pallet";
            this.Pallet.ReadOnly = true;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            this.Pelicula.ReadOnly = true;
            this.Pelicula.Width = 75;
            // 
            // Ancho
            // 
            this.Ancho.HeaderText = "Ancho";
            this.Ancho.Name = "Ancho";
            this.Ancho.ReadOnly = true;
            this.Ancho.Width = 40;
            // 
            // Diametro
            // 
            this.Diametro.HeaderText = "Diam.";
            this.Diametro.Name = "Diametro";
            this.Diametro.ReadOnly = true;
            this.Diametro.Width = 40;
            // 
            // Core
            // 
            this.Core.HeaderText = "Core";
            this.Core.Name = "Core";
            this.Core.ReadOnly = true;
            this.Core.Width = 40;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 170;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Width = 50;
            // 
            // PesoNeto
            // 
            this.PesoNeto.HeaderText = "Peso Neto [Kg]";
            this.PesoNeto.Name = "PesoNeto";
            this.PesoNeto.ReadOnly = true;
            this.PesoNeto.Width = 60;
            // 
            // PesoBruto
            // 
            this.PesoBruto.HeaderText = "Peso Bruto [Kg]";
            this.PesoBruto.Name = "PesoBruto";
            this.PesoBruto.ReadOnly = true;
            this.PesoBruto.Width = 60;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            this.Calificacion.Width = 80;
            // 
            // Bobinas
            // 
            this.Bobinas.HeaderText = "Cant. Bob.";
            this.Bobinas.Name = "Bobinas";
            this.Bobinas.ReadOnly = true;
            this.Bobinas.Width = 40;
            // 
            // Posicion
            // 
            this.Posicion.HeaderText = "Posición";
            this.Posicion.Name = "Posicion";
            this.Posicion.ReadOnly = true;
            this.Posicion.Width = 60;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtPesoTot);
            this.groupBox3.Location = new System.Drawing.Point(6, 418);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 52);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kilos Totales";
            // 
            // txtPesoTot
            // 
            this.txtPesoTot.Location = new System.Drawing.Point(68, 19);
            this.txtPesoTot.Name = "txtPesoTot";
            this.txtPesoTot.Size = new System.Drawing.Size(149, 20);
            this.txtPesoTot.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Kg";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtPalletCant);
            this.groupBox4.Location = new System.Drawing.Point(259, 418);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pallets Totales";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Cantidad";
            // 
            // txtPalletCant
            // 
            this.txtPalletCant.Location = new System.Drawing.Point(68, 19);
            this.txtPalletCant.Name = "txtPalletCant";
            this.txtPalletCant.Size = new System.Drawing.Size(162, 20);
            this.txtPalletCant.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtCoilTot);
            this.groupBox5.Location = new System.Drawing.Point(512, 418);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(247, 52);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Bobinas Totales";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Cantidad";
            // 
            // txtCoilTot
            // 
            this.txtCoilTot.Location = new System.Drawing.Point(68, 19);
            this.txtCoilTot.Name = "txtCoilTot";
            this.txtCoilTot.Size = new System.Drawing.Size(165, 20);
            this.txtCoilTot.TabIndex = 0;
            // 
            // frmPaletized
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1252, 572);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPaletized";
            this.Text = "Pallets terminados en corte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbFiltroPosicion;
        private System.Windows.Forms.ComboBox cmbFiltroPedido;
        private System.Windows.Forms.ComboBox cmbFiltroCliente;
        private System.Windows.Forms.ComboBox cmbFiltroCore;
        private System.Windows.Forms.ComboBox cmbFiltroDiametro;
        private System.Windows.Forms.ComboBox cmbFiltroAncho;
        private System.Windows.Forms.ComboBox cmbFiltroPelicula;
        private System.Windows.Forms.ComboBox cmbFiltroPallet;
        private System.Windows.Forms.ComboBox cmbFiltroOrigen;
        private System.Windows.Forms.ComboBox cmbFiltroBodega;
        private System.Windows.Forms.ComboBox cmbFiltroPlanta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ancho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Core;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bobinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCoilTot;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPalletCant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPesoTot;
    }
}