namespace BPS
{
    partial class frmRawMaterialConsumeByPalletOrSilo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialConsumeByPalletOrSilo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRawPallet = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLotePallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoRM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoteEstrusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantConsumP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbLotePallets = new System.Windows.Forms.ComboBox();
            this.lblPeliculaPallet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantConsum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaletCode = new System.Windows.Forms.TextBox();
            this.btnProcesarPallet = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSilo = new System.Windows.Forms.DataGridView();
            this.clmLoteGranel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoRawG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLoteSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeliculaSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantConsumSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminarSilo = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSiloFilm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLoteSilo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantConsumSilo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSilo = new System.Windows.Forms.ComboBox();
            this.btnProcesarGranel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawPallet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 20);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnProcesarPallet);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(918, 460);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pallets";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRawPallet);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(0, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 326);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pallet materia prima";
            // 
            // dgvRawPallet
            // 
            this.dgvRawPallet.AllowUserToAddRows = false;
            this.dgvRawPallet.AllowUserToDeleteRows = false;
            this.dgvRawPallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRawPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmLotePallet,
            this.clmTipoRM,
            this.clmLoteEstrusion,
            this.clmPelicula,
            this.clmPeso,
            this.clmCantConsumP,
            this.clmUsuario,
            this.clmNotas,
            this.clmFecha,
            this.clmEliminar});
            this.dgvRawPallet.Location = new System.Drawing.Point(3, 19);
            this.dgvRawPallet.Name = "dgvRawPallet";
            this.dgvRawPallet.ReadOnly = true;
            this.dgvRawPallet.Size = new System.Drawing.Size(915, 307);
            this.dgvRawPallet.TabIndex = 0;
            this.dgvRawPallet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRawPallet_CellContentClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 65;
            // 
            // clmLotePallet
            // 
            this.clmLotePallet.HeaderText = "Lote";
            this.clmLotePallet.Name = "clmLotePallet";
            this.clmLotePallet.ReadOnly = true;
            this.clmLotePallet.Width = 53;
            // 
            // clmTipoRM
            // 
            this.clmTipoRM.HeaderText = "Tipo Materia Prima";
            this.clmTipoRM.Name = "clmTipoRM";
            this.clmTipoRM.ReadOnly = true;
            this.clmTipoRM.Width = 110;
            // 
            // clmLoteEstrusion
            // 
            this.clmLoteEstrusion.HeaderText = "Lote de Estrusión";
            this.clmLoteEstrusion.Name = "clmLoteEstrusion";
            this.clmLoteEstrusion.ReadOnly = true;
            this.clmLoteEstrusion.Width = 105;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 69;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Cantidad restante";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            this.clmPeso.Width = 105;
            // 
            // clmCantConsumP
            // 
            this.clmCantConsumP.HeaderText = "Cantidad a consumir";
            this.clmCantConsumP.Name = "clmCantConsumP";
            this.clmCantConsumP.ReadOnly = true;
            this.clmCantConsumP.Width = 117;
            // 
            // clmUsuario
            // 
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            this.clmUsuario.Width = 68;
            // 
            // clmNotas
            // 
            this.clmNotas.HeaderText = "Notas";
            this.clmNotas.Name = "clmNotas";
            this.clmNotas.ReadOnly = true;
            this.clmNotas.Width = 60;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 62;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar";
            this.clmEliminar.Image = global::BPS.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Width = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cmbLotePallets);
            this.groupBox1.Controls.Add(this.lblPeliculaPallet);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantConsum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPaletCode);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Pallet";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(582, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Lote";
            // 
            // cmbLotePallets
            // 
            this.cmbLotePallets.FormattingEnabled = true;
            this.cmbLotePallets.Location = new System.Drawing.Point(629, 30);
            this.cmbLotePallets.Name = "cmbLotePallets";
            this.cmbLotePallets.Size = new System.Drawing.Size(141, 21);
            this.cmbLotePallets.TabIndex = 7;
            this.cmbLotePallets.SelectedIndexChanged += new System.EventHandler(this.cmbLotePallets_SelectedIndexChanged);
            // 
            // lblPeliculaPallet
            // 
            this.lblPeliculaPallet.AutoSize = true;
            this.lblPeliculaPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeliculaPallet.ForeColor = System.Drawing.Color.DimGray;
            this.lblPeliculaPallet.Location = new System.Drawing.Point(836, 32);
            this.lblPeliculaPallet.Name = "lblPeliculaPallet";
            this.lblPeliculaPallet.Size = new System.Drawing.Size(34, 16);
            this.lblPeliculaPallet.TabIndex = 6;
            this.lblPeliculaPallet.Text = "asd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(789, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Pelicula:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(533, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad a consumir";
            // 
            // txtCantConsum
            // 
            this.txtCantConsum.Location = new System.Drawing.Point(398, 31);
            this.txtCantConsum.Name = "txtCantConsum";
            this.txtCantConsum.Size = new System.Drawing.Size(129, 20);
            this.txtCantConsum.TabIndex = 2;
            this.txtCantConsum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantConsum_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Pallet";
            // 
            // txtPaletCode
            // 
            this.txtPaletCode.Location = new System.Drawing.Point(124, 30);
            this.txtPaletCode.Name = "txtPaletCode";
            this.txtPaletCode.Size = new System.Drawing.Size(141, 20);
            this.txtPaletCode.TabIndex = 0;
            this.txtPaletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaletCode_KeyDown);
            // 
            // btnProcesarPallet
            // 
            this.btnProcesarPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnProcesarPallet.Location = new System.Drawing.Point(779, 415);
            this.btnProcesarPallet.Name = "btnProcesarPallet";
            this.btnProcesarPallet.Size = new System.Drawing.Size(129, 39);
            this.btnProcesarPallet.TabIndex = 1;
            this.btnProcesarPallet.Text = "Procesar";
            this.btnProcesarPallet.UseVisualStyleBackColor = true;
            this.btnProcesarPallet.Click += new System.EventHandler(this.btnProcesarPallet_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnProcesarGranel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(918, 460);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Granel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSilo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox4.Location = new System.Drawing.Point(0, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(915, 335);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos de Silo";
            // 
            // dgvSilo
            // 
            this.dgvSilo.AllowUserToAddRows = false;
            this.dgvSilo.AllowUserToDeleteRows = false;
            this.dgvSilo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSilo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLoteGranel,
            this.clmNombreSilo,
            this.clmTipoRawG,
            this.clmLoteSilo,
            this.clmPeliculaSilo,
            this.clmCantSilo,
            this.clmCantConsumSilo,
            this.clmfkSilo,
            this.clmEliminarSilo});
            this.dgvSilo.Location = new System.Drawing.Point(3, 19);
            this.dgvSilo.Name = "dgvSilo";
            this.dgvSilo.ReadOnly = true;
            this.dgvSilo.Size = new System.Drawing.Size(912, 316);
            this.dgvSilo.TabIndex = 0;
            this.dgvSilo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSilo_CellContentClick);
            // 
            // clmLoteGranel
            // 
            this.clmLoteGranel.HeaderText = "Lote";
            this.clmLoteGranel.Name = "clmLoteGranel";
            this.clmLoteGranel.ReadOnly = true;
            this.clmLoteGranel.Width = 53;
            // 
            // clmNombreSilo
            // 
            this.clmNombreSilo.HeaderText = "Silo";
            this.clmNombreSilo.Name = "clmNombreSilo";
            this.clmNombreSilo.ReadOnly = true;
            this.clmNombreSilo.Width = 49;
            // 
            // clmTipoRawG
            // 
            this.clmTipoRawG.HeaderText = "Tipo materia prima";
            this.clmTipoRawG.Name = "clmTipoRawG";
            this.clmTipoRawG.ReadOnly = true;
            this.clmTipoRawG.Width = 108;
            // 
            // clmLoteSilo
            // 
            this.clmLoteSilo.HeaderText = "Lote Estrusión";
            this.clmLoteSilo.Name = "clmLoteSilo";
            this.clmLoteSilo.ReadOnly = true;
            this.clmLoteSilo.Width = 91;
            // 
            // clmPeliculaSilo
            // 
            this.clmPeliculaSilo.HeaderText = "Pelicula";
            this.clmPeliculaSilo.Name = "clmPeliculaSilo";
            this.clmPeliculaSilo.ReadOnly = true;
            this.clmPeliculaSilo.Width = 69;
            // 
            // clmCantSilo
            // 
            this.clmCantSilo.HeaderText = "Cantidad";
            this.clmCantSilo.Name = "clmCantSilo";
            this.clmCantSilo.ReadOnly = true;
            this.clmCantSilo.Width = 74;
            // 
            // clmCantConsumSilo
            // 
            this.clmCantConsumSilo.HeaderText = "Cantidad a consumir";
            this.clmCantConsumSilo.Name = "clmCantConsumSilo";
            this.clmCantConsumSilo.ReadOnly = true;
            this.clmCantConsumSilo.Width = 117;
            // 
            // clmfkSilo
            // 
            this.clmfkSilo.HeaderText = "fkSilo";
            this.clmfkSilo.Name = "clmfkSilo";
            this.clmfkSilo.ReadOnly = true;
            this.clmfkSilo.Visible = false;
            // 
            // clmEliminarSilo
            // 
            this.clmEliminarSilo.HeaderText = "Eliminar";
            this.clmEliminarSilo.Image = global::BPS.Properties.Resources.cross;
            this.clmEliminarSilo.Name = "clmEliminarSilo";
            this.clmEliminarSilo.ReadOnly = true;
            this.clmEliminarSilo.Width = 49;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSiloFilm);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbLoteSilo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCantConsumSilo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbSilo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox3.Location = new System.Drawing.Point(3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(912, 67);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de Silo";
            // 
            // lblSiloFilm
            // 
            this.lblSiloFilm.AutoSize = true;
            this.lblSiloFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiloFilm.ForeColor = System.Drawing.Color.DimGray;
            this.lblSiloFilm.Location = new System.Drawing.Point(825, 35);
            this.lblSiloFilm.Name = "lblSiloFilm";
            this.lblSiloFilm.Size = new System.Drawing.Size(59, 16);
            this.lblSiloFilm.TabIndex = 8;
            this.lblSiloFilm.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pelicula: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lote";
            // 
            // cmbLoteSilo
            // 
            this.cmbLoteSilo.FormattingEnabled = true;
            this.cmbLoteSilo.Location = new System.Drawing.Point(590, 28);
            this.cmbLoteSilo.Name = "cmbLoteSilo";
            this.cmbLoteSilo.Size = new System.Drawing.Size(148, 21);
            this.cmbLoteSilo.TabIndex = 5;
            this.cmbLoteSilo.SelectedIndexChanged += new System.EventHandler(this.cmbLoteSilo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad a consumir";
            // 
            // txtCantConsumSilo
            // 
            this.txtCantConsumSilo.Location = new System.Drawing.Point(358, 28);
            this.txtCantConsumSilo.Name = "txtCantConsumSilo";
            this.txtCantConsumSilo.Size = new System.Drawing.Size(138, 20);
            this.txtCantConsumSilo.TabIndex = 2;
            this.txtCantConsumSilo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantConsumSilo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Silo";
            // 
            // cmbSilo
            // 
            this.cmbSilo.FormattingEnabled = true;
            this.cmbSilo.Location = new System.Drawing.Point(57, 28);
            this.cmbSilo.Name = "cmbSilo";
            this.cmbSilo.Size = new System.Drawing.Size(165, 21);
            this.cmbSilo.TabIndex = 0;
            // 
            // btnProcesarGranel
            // 
            this.btnProcesarGranel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnProcesarGranel.Location = new System.Drawing.Point(784, 413);
            this.btnProcesarGranel.Name = "btnProcesarGranel";
            this.btnProcesarGranel.Size = new System.Drawing.Size(124, 41);
            this.btnProcesarGranel.TabIndex = 1;
            this.btnProcesarGranel.Text = "Procesar";
            this.btnProcesarGranel.UseVisualStyleBackColor = true;
            this.btnProcesarGranel.Click += new System.EventHandler(this.btnProcesarGranel_Click);
            // 
            // frmRawMaterialConsumeByPalletOrSilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 492);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialConsumeByPalletOrSilo";
            this.Text = "Consumición de materia primas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawPallet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnProcesarGranel;
        private System.Windows.Forms.Button btnProcesarPallet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPaletCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvRawPallet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSilo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSilo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantConsumSilo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantConsum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoteGranel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoRawG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoteSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeliculaSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantConsumSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkSilo;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminarSilo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoteSilo;
        private System.Windows.Forms.Label lblPeliculaPallet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSiloFilm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbLotePallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotePallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLoteEstrusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantConsumP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
    }
}