namespace BPS.Lite
{
    partial class frmRawMaterialInputManual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialInputManual));
            this.Pallets = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGuardarPallet = new System.Windows.Forms.Button();
            this.dgvRawMatPallet = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTipoMatPallet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCodPallet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBodegaPallets = new System.Windows.Forms.ComboBox();
            this.txtLotePallet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCargarPallet = new System.Windows.Forms.Button();
            this.txtNomMatPallet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotasPallet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadPallet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresaPallet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGuardarSilo = new System.Windows.Forms.Button();
            this.dgvSilo = new System.Windows.Forms.DataGridView();
            this.clmCodSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoteSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpresaSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSiloDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotaSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNomSilo = new System.Windows.Forms.TextBox();
            this.cmbCodSilo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbDestinoSilo = new System.Windows.Forms.ComboBox();
            this.txtLoteSilo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCargarSilo = new System.Windows.Forms.Button();
            this.txtNotasSilo = new System.Windows.Forms.TextBox();
            this.txtCantidadSilo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtEmpresaSilo = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPesoTot = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCantPallet = new System.Windows.Forms.TextBox();
            this.Pallets.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMatPallet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pallets
            // 
            this.Pallets.Controls.Add(this.tabPage1);
            this.Pallets.Controls.Add(this.tabPage2);
            this.Pallets.Location = new System.Drawing.Point(0, 0);
            this.Pallets.Name = "Pallets";
            this.Pallets.SelectedIndex = 0;
            this.Pallets.Size = new System.Drawing.Size(1076, 556);
            this.Pallets.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btnGuardarPallet);
            this.tabPage1.Controls.Add(this.dgvRawMatPallet);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pallets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPallet
            // 
            this.btnGuardarPallet.Location = new System.Drawing.Point(954, 469);
            this.btnGuardarPallet.Name = "btnGuardarPallet";
            this.btnGuardarPallet.Size = new System.Drawing.Size(111, 52);
            this.btnGuardarPallet.TabIndex = 0;
            this.btnGuardarPallet.Text = "Guardar";
            this.btnGuardarPallet.UseVisualStyleBackColor = true;
            this.btnGuardarPallet.Click += new System.EventHandler(this.btnGuardarPallet_Click);
            // 
            // dgvRawMatPallet
            // 
            this.dgvRawMatPallet.AllowUserToAddRows = false;
            this.dgvRawMatPallet.AllowUserToDeleteRows = false;
            this.dgvRawMatPallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawMatPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMatPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmCodPallet,
            this.clmCantidad,
            this.clmLote,
            this.clmEmpresa,
            this.clmBodDestino,
            this.clmNotas,
            this.clmFechaPallet});
            this.dgvRawMatPallet.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvRawMatPallet.Location = new System.Drawing.Point(6, 148);
            this.dgvRawMatPallet.Name = "dgvRawMatPallet";
            this.dgvRawMatPallet.ReadOnly = true;
            this.dgvRawMatPallet.Size = new System.Drawing.Size(1057, 315);
            this.dgvRawMatPallet.TabIndex = 1;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 65;
            // 
            // clmCodPallet
            // 
            this.clmCodPallet.HeaderText = "Código Pallet";
            this.clmCodPallet.Name = "clmCodPallet";
            this.clmCodPallet.ReadOnly = true;
            this.clmCodPallet.Width = 87;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            this.clmCantidad.Width = 74;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 53;
            // 
            // clmEmpresa
            // 
            this.clmEmpresa.HeaderText = "Empresa";
            this.clmEmpresa.Name = "clmEmpresa";
            this.clmEmpresa.ReadOnly = true;
            this.clmEmpresa.Width = 73;
            // 
            // clmBodDestino
            // 
            this.clmBodDestino.HeaderText = "Bodega Destino";
            this.clmBodDestino.Name = "clmBodDestino";
            this.clmBodDestino.ReadOnly = true;
            this.clmBodDestino.Width = 99;
            // 
            // clmNotas
            // 
            this.clmNotas.HeaderText = "Nota";
            this.clmNotas.Name = "clmNotas";
            this.clmNotas.ReadOnly = true;
            this.clmNotas.Width = 55;
            // 
            // clmFechaPallet
            // 
            this.clmFechaPallet.HeaderText = "Fecha";
            this.clmFechaPallet.Name = "clmFechaPallet";
            this.clmFechaPallet.ReadOnly = true;
            this.clmFechaPallet.Width = 62;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoMatPallet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbCodPallet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbBodegaPallets);
            this.groupBox1.Controls.Add(this.txtLotePallet);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCargarPallet);
            this.groupBox1.Controls.Add(this.txtNomMatPallet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNotasPallet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPallets);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCantidadPallet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmpresaPallet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1057, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pallet";
            // 
            // txtTipoMatPallet
            // 
            this.txtTipoMatPallet.Enabled = false;
            this.txtTipoMatPallet.Location = new System.Drawing.Point(70, 104);
            this.txtTipoMatPallet.Name = "txtTipoMatPallet";
            this.txtTipoMatPallet.Size = new System.Drawing.Size(167, 20);
            this.txtTipoMatPallet.TabIndex = 7;
            this.txtTipoMatPallet.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tipo";
            // 
            // cmbCodPallet
            // 
            this.cmbCodPallet.FormattingEnabled = true;
            this.cmbCodPallet.Location = new System.Drawing.Point(70, 25);
            this.cmbCodPallet.Name = "cmbCodPallet";
            this.cmbCodPallet.Size = new System.Drawing.Size(167, 21);
            this.cmbCodPallet.TabIndex = 0;
            this.cmbCodPallet.SelectedIndexChanged += new System.EventHandler(this.cmbCodPallet_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Bodega";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cantidad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Código";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-50, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Bodega";
            // 
            // cmbBodegaPallets
            // 
            this.cmbBodegaPallets.FormattingEnabled = true;
            this.cmbBodegaPallets.Location = new System.Drawing.Point(70, 65);
            this.cmbBodegaPallets.Name = "cmbBodegaPallets";
            this.cmbBodegaPallets.Size = new System.Drawing.Size(167, 21);
            this.cmbBodegaPallets.TabIndex = 2;
            this.cmbBodegaPallets.SelectedIndexChanged += new System.EventHandler(this.cmbBodegaPallets_SelectedIndexChanged);
            // 
            // txtLotePallet
            // 
            this.txtLotePallet.Location = new System.Drawing.Point(616, 22);
            this.txtLotePallet.Name = "txtLotePallet";
            this.txtLotePallet.Size = new System.Drawing.Size(121, 20);
            this.txtLotePallet.TabIndex = 1;
            this.txtLotePallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotePallet_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Lote";
            // 
            // btnCargarPallet
            // 
            this.btnCargarPallet.Location = new System.Drawing.Point(896, 90);
            this.btnCargarPallet.Name = "btnCargarPallet";
            this.btnCargarPallet.Size = new System.Drawing.Size(96, 31);
            this.btnCargarPallet.TabIndex = 6;
            this.btnCargarPallet.Text = "Cargar";
            this.btnCargarPallet.UseVisualStyleBackColor = true;
            this.btnCargarPallet.Click += new System.EventHandler(this.btnCargarPallet_Click);
            // 
            // txtNomMatPallet
            // 
            this.txtNomMatPallet.Enabled = false;
            this.txtNomMatPallet.Location = new System.Drawing.Point(339, 25);
            this.txtNomMatPallet.Name = "txtNomMatPallet";
            this.txtNomMatPallet.Size = new System.Drawing.Size(180, 20);
            this.txtNomMatPallet.TabIndex = 30;
            this.txtNomMatPallet.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre";
            // 
            // txtNotasPallet
            // 
            this.txtNotasPallet.Location = new System.Drawing.Point(829, 19);
            this.txtNotasPallet.Multiline = true;
            this.txtNotasPallet.Name = "txtNotasPallet";
            this.txtNotasPallet.Size = new System.Drawing.Size(210, 57);
            this.txtNotasPallet.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(776, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Notas";
            // 
            // txtPallets
            // 
            this.txtPallets.Location = new System.Drawing.Point(616, 66);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(121, 20);
            this.txtPallets.TabIndex = 26;
            this.txtPallets.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPallets_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cant. Pallets";
            // 
            // txtCantidadPallet
            // 
            this.txtCantidadPallet.Location = new System.Drawing.Point(339, 65);
            this.txtCantidadPallet.Name = "txtCantidadPallet";
            this.txtCantidadPallet.Size = new System.Drawing.Size(180, 20);
            this.txtCantidadPallet.TabIndex = 3;
            this.txtCantidadPallet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPallet_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-50, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cantidad";
            // 
            // txtEmpresaPallet
            // 
            this.txtEmpresaPallet.Enabled = false;
            this.txtEmpresaPallet.Location = new System.Drawing.Point(339, 101);
            this.txtEmpresaPallet.Name = "txtEmpresaPallet";
            this.txtEmpresaPallet.Size = new System.Drawing.Size(180, 20);
            this.txtEmpresaPallet.TabIndex = 8;
            this.txtEmpresaPallet.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Código";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGuardarSilo);
            this.tabPage2.Controls.Add(this.dgvSilo);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Granel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGuardarSilo
            // 
            this.btnGuardarSilo.Location = new System.Drawing.Point(965, 486);
            this.btnGuardarSilo.Name = "btnGuardarSilo";
            this.btnGuardarSilo.Size = new System.Drawing.Size(97, 38);
            this.btnGuardarSilo.TabIndex = 3;
            this.btnGuardarSilo.Text = "Guardar";
            this.btnGuardarSilo.UseVisualStyleBackColor = true;
            this.btnGuardarSilo.Click += new System.EventHandler(this.btnGuardarSilo_Click);
            // 
            // dgvSilo
            // 
            this.dgvSilo.AllowUserToAddRows = false;
            this.dgvSilo.AllowUserToDeleteRows = false;
            this.dgvSilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSilo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodSilo,
            this.clmCantidadSilo,
            this.clmLoteSilo,
            this.clmEmpresaSilo,
            this.clmSiloDestino,
            this.clmNotaSilo,
            this.clmFechaSilo});
            this.dgvSilo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgvSilo.Location = new System.Drawing.Point(5, 149);
            this.dgvSilo.Name = "dgvSilo";
            this.dgvSilo.ReadOnly = true;
            this.dgvSilo.Size = new System.Drawing.Size(1057, 331);
            this.dgvSilo.TabIndex = 4;
            // 
            // clmCodSilo
            // 
            this.clmCodSilo.HeaderText = "Código";
            this.clmCodSilo.Name = "clmCodSilo";
            this.clmCodSilo.ReadOnly = true;
            this.clmCodSilo.Width = 150;
            // 
            // clmCantidadSilo
            // 
            this.clmCantidadSilo.HeaderText = "Cantidad";
            this.clmCantidadSilo.Name = "clmCantidadSilo";
            this.clmCantidadSilo.ReadOnly = true;
            this.clmCantidadSilo.Width = 80;
            // 
            // clmLoteSilo
            // 
            this.clmLoteSilo.HeaderText = "Lote";
            this.clmLoteSilo.Name = "clmLoteSilo";
            this.clmLoteSilo.ReadOnly = true;
            // 
            // clmEmpresaSilo
            // 
            this.clmEmpresaSilo.HeaderText = "Empresa";
            this.clmEmpresaSilo.Name = "clmEmpresaSilo";
            this.clmEmpresaSilo.ReadOnly = true;
            this.clmEmpresaSilo.Width = 120;
            // 
            // clmSiloDestino
            // 
            this.clmSiloDestino.HeaderText = "Silo Destino";
            this.clmSiloDestino.Name = "clmSiloDestino";
            this.clmSiloDestino.ReadOnly = true;
            this.clmSiloDestino.Width = 140;
            // 
            // clmNotaSilo
            // 
            this.clmNotaSilo.HeaderText = "Notas";
            this.clmNotaSilo.Name = "clmNotaSilo";
            this.clmNotaSilo.ReadOnly = true;
            this.clmNotaSilo.Width = 150;
            // 
            // clmFechaSilo
            // 
            this.clmFechaSilo.HeaderText = "Fecha";
            this.clmFechaSilo.Name = "clmFechaSilo";
            this.clmFechaSilo.ReadOnly = true;
            this.clmFechaSilo.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtNomSilo);
            this.groupBox2.Controls.Add(this.cmbCodSilo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cmbDestinoSilo);
            this.groupBox2.Controls.Add(this.txtLoteSilo);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnCargarSilo);
            this.groupBox2.Controls.Add(this.txtNotasSilo);
            this.groupBox2.Controls.Add(this.txtCantidadSilo);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtEmpresaSilo);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1057, 139);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Pallet";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(829, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Notas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(264, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Nombre";
            // 
            // txtNomSilo
            // 
            this.txtNomSilo.Enabled = false;
            this.txtNomSilo.Location = new System.Drawing.Point(338, 28);
            this.txtNomSilo.Name = "txtNomSilo";
            this.txtNomSilo.Size = new System.Drawing.Size(167, 20);
            this.txtNomSilo.TabIndex = 42;
            // 
            // cmbCodSilo
            // 
            this.cmbCodSilo.FormattingEnabled = true;
            this.cmbCodSilo.Location = new System.Drawing.Point(70, 25);
            this.cmbCodSilo.Name = "cmbCodSilo";
            this.cmbCodSilo.Size = new System.Drawing.Size(167, 21);
            this.cmbCodSilo.TabIndex = 41;
            this.cmbCodSilo.SelectedIndexChanged += new System.EventHandler(this.cmbCodSilo_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Silo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(264, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Cantidad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 38;
            this.label15.Text = "Código";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-50, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Bodega";
            // 
            // cmbDestinoSilo
            // 
            this.cmbDestinoSilo.FormattingEnabled = true;
            this.cmbDestinoSilo.Location = new System.Drawing.Point(70, 67);
            this.cmbDestinoSilo.Name = "cmbDestinoSilo";
            this.cmbDestinoSilo.Size = new System.Drawing.Size(167, 21);
            this.cmbDestinoSilo.TabIndex = 36;
            this.cmbDestinoSilo.SelectedIndexChanged += new System.EventHandler(this.cmbDestinoSilo_SelectedIndexChanged);
            // 
            // txtLoteSilo
            // 
            this.txtLoteSilo.Location = new System.Drawing.Point(601, 28);
            this.txtLoteSilo.Name = "txtLoteSilo";
            this.txtLoteSilo.Size = new System.Drawing.Size(167, 20);
            this.txtLoteSilo.TabIndex = 35;
            this.txtLoteSilo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoteSilo_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(527, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(28, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Lote";
            // 
            // btnCargarSilo
            // 
            this.btnCargarSilo.Location = new System.Drawing.Point(955, 96);
            this.btnCargarSilo.Name = "btnCargarSilo";
            this.btnCargarSilo.Size = new System.Drawing.Size(96, 31);
            this.btnCargarSilo.TabIndex = 33;
            this.btnCargarSilo.Text = "Cargar";
            this.btnCargarSilo.UseVisualStyleBackColor = true;
            this.btnCargarSilo.Click += new System.EventHandler(this.btnCargarSilo_Click);
            // 
            // txtNotasSilo
            // 
            this.txtNotasSilo.Location = new System.Drawing.Point(870, 25);
            this.txtNotasSilo.Multiline = true;
            this.txtNotasSilo.Name = "txtNotasSilo";
            this.txtNotasSilo.Size = new System.Drawing.Size(181, 55);
            this.txtNotasSilo.TabIndex = 28;
            // 
            // txtCantidadSilo
            // 
            this.txtCantidadSilo.Location = new System.Drawing.Point(338, 67);
            this.txtCantidadSilo.Name = "txtCantidadSilo";
            this.txtCantidadSilo.Size = new System.Drawing.Size(167, 20);
            this.txtCantidadSilo.TabIndex = 24;
            this.txtCantidadSilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadSilo_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(-50, 97);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 13);
            this.label22.TabIndex = 23;
            this.label22.Text = "Cantidad";
            // 
            // txtEmpresaSilo
            // 
            this.txtEmpresaSilo.Enabled = false;
            this.txtEmpresaSilo.Location = new System.Drawing.Point(601, 67);
            this.txtEmpresaSilo.Name = "txtEmpresaSilo";
            this.txtEmpresaSilo.Size = new System.Drawing.Size(167, 20);
            this.txtEmpresaSilo.TabIndex = 22;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(527, 70);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "Empresa";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(-50, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Código";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.txtPesoTot);
            this.groupBox3.Location = new System.Drawing.Point(6, 469);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 52);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Kilos";
            // 
            // txtPesoTot
            // 
            this.txtPesoTot.Location = new System.Drawing.Point(70, 21);
            this.txtPesoTot.Name = "txtPesoTot";
            this.txtPesoTot.Size = new System.Drawing.Size(131, 20);
            this.txtPesoTot.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Cantidad";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(207, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Kg";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.txtCantPallet);
            this.groupBox4.Location = new System.Drawing.Point(249, 469);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(237, 52);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total de Pallet";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(21, 25);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Cantidad";
            // 
            // txtCantPallet
            // 
            this.txtCantPallet.Location = new System.Drawing.Point(76, 21);
            this.txtCantPallet.Name = "txtCantPallet";
            this.txtCantPallet.Size = new System.Drawing.Size(146, 20);
            this.txtCantPallet.TabIndex = 0;
            // 
            // frmRawMaterialInputManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1078, 555);
            this.Controls.Add(this.Pallets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialInputManual";
            this.Text = "Ingreso de materias primas manual";
            this.Pallets.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMatPallet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pallets;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvRawMatPallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuardarPallet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBodegaPallets;
        private System.Windows.Forms.TextBox txtLotePallet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCargarPallet;
        private System.Windows.Forms.TextBox txtNomMatPallet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotasPallet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPallets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadPallet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresaPallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCodPallet;
        private System.Windows.Forms.Button btnGuardarSilo;
        private System.Windows.Forms.DataGridView dgvSilo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCodSilo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbDestinoSilo;
        private System.Windows.Forms.TextBox txtLoteSilo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCargarSilo;
        private System.Windows.Forms.TextBox txtNotasSilo;
        private System.Windows.Forms.TextBox txtCantidadSilo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtEmpresaSilo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNomSilo;
        private System.Windows.Forms.TextBox txtTipoMatPallet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoteSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpresaSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSiloDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotaSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaSilo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCantPallet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPesoTot;

    }
}