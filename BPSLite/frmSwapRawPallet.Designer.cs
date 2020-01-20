namespace BPS
{
    partial class frmSwapRawPallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwapRawPallet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbBodegaDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSwapRawMat = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotPalletOut = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotKilosOut = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPalletIn = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotKilosIn = new System.Windows.Forms.TextBox();
            this.dgvIngresoSwap = new System.Windows.Forms.DataGridView();
            this.clmRPCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRMCodM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRMTipoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRMPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRMLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigenRMPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRPDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRMFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRMNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConfirm = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDeny = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapRawMat)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoSwap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cmbBodegaDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1118, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de envío";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(531, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(159, 20);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // cmbBodegaDestino
            // 
            this.cmbBodegaDestino.FormattingEnabled = true;
            this.cmbBodegaDestino.Location = new System.Drawing.Point(178, 28);
            this.cmbBodegaDestino.Name = "cmbBodegaDestino";
            this.cmbBodegaDestino.Size = new System.Drawing.Size(158, 21);
            this.cmbBodegaDestino.TabIndex = 5;
            this.cmbBodegaDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBodegaDestino_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bodega Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código Pallet";
            // 
            // dgvSwapRawMat
            // 
            this.dgvSwapRawMat.AllowUserToAddRows = false;
            this.dgvSwapRawMat.AllowUserToDeleteRows = false;
            this.dgvSwapRawMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwapRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodigo,
            this.clmTipo,
            this.clmPeso,
            this.clmLote,
            this.clmDate,
            this.clmBodegaOrigen,
            this.clmBodegaDestino,
            this.clmEliminar});
            this.dgvSwapRawMat.Location = new System.Drawing.Point(3, 81);
            this.dgvSwapRawMat.Name = "dgvSwapRawMat";
            this.dgvSwapRawMat.ReadOnly = true;
            this.dgvSwapRawMat.Size = new System.Drawing.Size(1118, 276);
            this.dgvSwapRawMat.TabIndex = 1;
            this.dgvSwapRawMat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSwapRawMat_CellContentClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "Tipo Material";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmBodegaOrigen
            // 
            this.clmBodegaOrigen.HeaderText = "Bodega Origen";
            this.clmBodegaOrigen.Name = "clmBodegaOrigen";
            this.clmBodegaOrigen.ReadOnly = true;
            this.clmBodegaOrigen.Width = 150;
            // 
            // clmBodegaDestino
            // 
            this.clmBodegaDestino.HeaderText = "Bodega Destino";
            this.clmBodegaDestino.Name = "clmBodegaDestino";
            this.clmBodegaDestino.ReadOnly = true;
            this.clmBodegaDestino.Width = 150;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar";
            this.clmEliminar.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(1011, 363);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(110, 43);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 442);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvSwapRawMat);
            this.tabPage1.Controls.Add(this.btnProcesar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Swap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTotPalletOut);
            this.groupBox3.Location = new System.Drawing.Point(221, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(209, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Pallets";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad";
            // 
            // txtTotPalletOut
            // 
            this.txtTotPalletOut.Location = new System.Drawing.Point(73, 23);
            this.txtTotPalletOut.Name = "txtTotPalletOut";
            this.txtTotPalletOut.Size = new System.Drawing.Size(119, 20);
            this.txtTotPalletOut.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotKilosOut);
            this.groupBox2.Location = new System.Drawing.Point(6, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Kilos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad";
            // 
            // txtTotKilosOut
            // 
            this.txtTotKilosOut.Location = new System.Drawing.Point(73, 23);
            this.txtTotKilosOut.Name = "txtTotKilosOut";
            this.txtTotKilosOut.Size = new System.Drawing.Size(110, 20);
            this.txtTotKilosOut.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.dgvIngresoSwap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso Swap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPalletIn);
            this.groupBox4.Location = new System.Drawing.Point(221, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(209, 56);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Pallets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cantidad";
            // 
            // txtPalletIn
            // 
            this.txtPalletIn.Location = new System.Drawing.Point(73, 23);
            this.txtPalletIn.Name = "txtPalletIn";
            this.txtPalletIn.Size = new System.Drawing.Size(119, 20);
            this.txtPalletIn.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTotKilosIn);
            this.groupBox5.Location = new System.Drawing.Point(6, 355);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 56);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total Kilos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cantidad";
            // 
            // txtTotKilosIn
            // 
            this.txtTotKilosIn.Location = new System.Drawing.Point(73, 23);
            this.txtTotKilosIn.Name = "txtTotKilosIn";
            this.txtTotKilosIn.Size = new System.Drawing.Size(110, 20);
            this.txtTotKilosIn.TabIndex = 0;
            // 
            // dgvIngresoSwap
            // 
            this.dgvIngresoSwap.AllowUserToAddRows = false;
            this.dgvIngresoSwap.AllowUserToDeleteRows = false;
            this.dgvIngresoSwap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIngresoSwap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoSwap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRPCod,
            this.clmRMCodM,
            this.clmRMTipoMat,
            this.clmRMPeso,
            this.clmRMLote,
            this.clmOrigenRMPallet,
            this.clmRPDestino,
            this.clmRMFecha,
            this.clmRMNotas,
            this.clmConfirm,
            this.clmDeny});
            this.dgvIngresoSwap.Location = new System.Drawing.Point(6, 17);
            this.dgvIngresoSwap.Name = "dgvIngresoSwap";
            this.dgvIngresoSwap.ReadOnly = true;
            this.dgvIngresoSwap.Size = new System.Drawing.Size(1119, 336);
            this.dgvIngresoSwap.TabIndex = 0;
            this.dgvIngresoSwap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresoSwap_CellContentClick);
            // 
            // clmRPCod
            // 
            this.clmRPCod.HeaderText = "Código Pallet";
            this.clmRPCod.Name = "clmRPCod";
            this.clmRPCod.ReadOnly = true;
            this.clmRPCod.Width = 87;
            // 
            // clmRMCodM
            // 
            this.clmRMCodM.HeaderText = "Código Materia Prima";
            this.clmRMCodM.Name = "clmRMCodM";
            this.clmRMCodM.ReadOnly = true;
            this.clmRMCodM.Width = 97;
            // 
            // clmRMTipoMat
            // 
            this.clmRMTipoMat.HeaderText = "Nombre Materia Prima";
            this.clmRMTipoMat.Name = "clmRMTipoMat";
            this.clmRMTipoMat.ReadOnly = true;
            this.clmRMTipoMat.Width = 101;
            // 
            // clmRMPeso
            // 
            this.clmRMPeso.HeaderText = "Peso Neto";
            this.clmRMPeso.Name = "clmRMPeso";
            this.clmRMPeso.ReadOnly = true;
            this.clmRMPeso.Width = 76;
            // 
            // clmRMLote
            // 
            this.clmRMLote.HeaderText = "Lote";
            this.clmRMLote.Name = "clmRMLote";
            this.clmRMLote.ReadOnly = true;
            this.clmRMLote.Width = 53;
            // 
            // clmOrigenRMPallet
            // 
            this.clmOrigenRMPallet.HeaderText = "Origen";
            this.clmOrigenRMPallet.Name = "clmOrigenRMPallet";
            this.clmOrigenRMPallet.ReadOnly = true;
            this.clmOrigenRMPallet.Width = 63;
            // 
            // clmRPDestino
            // 
            this.clmRPDestino.HeaderText = "Destino";
            this.clmRPDestino.Name = "clmRPDestino";
            this.clmRPDestino.ReadOnly = true;
            this.clmRPDestino.Width = 68;
            // 
            // clmRMFecha
            // 
            this.clmRMFecha.HeaderText = "Fecha";
            this.clmRMFecha.Name = "clmRMFecha";
            this.clmRMFecha.ReadOnly = true;
            this.clmRMFecha.Width = 62;
            // 
            // clmRMNotas
            // 
            this.clmRMNotas.HeaderText = "Notas";
            this.clmRMNotas.Name = "clmRMNotas";
            this.clmRMNotas.ReadOnly = true;
            this.clmRMNotas.Width = 60;
            // 
            // clmConfirm
            // 
            this.clmConfirm.HeaderText = "Confirmar";
            this.clmConfirm.Image = global::BPS.Lite.Properties.Resources.accept;
            this.clmConfirm.Name = "clmConfirm";
            this.clmConfirm.ReadOnly = true;
            this.clmConfirm.Width = 57;
            // 
            // clmDeny
            // 
            this.clmDeny.HeaderText = "Cancelar";
            this.clmDeny.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmDeny.Name = "clmDeny";
            this.clmDeny.ReadOnly = true;
            this.clmDeny.Width = 55;
            // 
            // frmSwapRawPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 447);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSwapRawPallet";
            this.Text = "Swap de pallets de Materia Prima";
            this.Load += new System.EventHandler(this.frmSwapRawPallet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapRawMat)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoSwap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBodegaDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSwapRawMat;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaDestino;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvIngresoSwap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRPCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRMCodM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRMTipoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRMPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRMLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigenRMPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRPDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRMFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRMNotas;
        private System.Windows.Forms.DataGridViewImageColumn clmConfirm;
        private System.Windows.Forms.DataGridViewImageColumn clmDeny;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotPalletOut;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotKilosOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPalletIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotKilosIn;
    }
}