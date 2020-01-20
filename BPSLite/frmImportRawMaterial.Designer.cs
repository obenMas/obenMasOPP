namespace BPS.Lite
{
    partial class frmImportRawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportRawMaterial));
            this.gpDatos = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBodegas = new System.Windows.Forms.ComboBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtPartidas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvImportRawMat = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPartidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantidadPallet = new System.Windows.Forms.TextBox();
            this.gpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportRawMat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDatos
            // 
            this.gpDatos.Controls.Add(this.label9);
            this.gpDatos.Controls.Add(this.cmbBodegas);
            this.gpDatos.Controls.Add(this.txtLote);
            this.gpDatos.Controls.Add(this.label8);
            this.gpDatos.Controls.Add(this.btnCargar);
            this.gpDatos.Controls.Add(this.txtPartidas);
            this.gpDatos.Controls.Add(this.label7);
            this.gpDatos.Controls.Add(this.txtProveedor);
            this.gpDatos.Controls.Add(this.label6);
            this.gpDatos.Controls.Add(this.txtNotas);
            this.gpDatos.Controls.Add(this.label5);
            this.gpDatos.Controls.Add(this.txtPallets);
            this.gpDatos.Controls.Add(this.label4);
            this.gpDatos.Controls.Add(this.txtCantidad);
            this.gpDatos.Controls.Add(this.label3);
            this.gpDatos.Controls.Add(this.txtEmpresa);
            this.gpDatos.Controls.Add(this.label2);
            this.gpDatos.Controls.Add(this.txtCodigo);
            this.gpDatos.Controls.Add(this.label1);
            this.gpDatos.Location = new System.Drawing.Point(7, 7);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(897, 123);
            this.gpDatos.TabIndex = 0;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos de Materia Prima";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Bodega";
            // 
            // cmbBodegas
            // 
            this.cmbBodegas.FormattingEnabled = true;
            this.cmbBodegas.Location = new System.Drawing.Point(78, 55);
            this.cmbBodegas.Name = "cmbBodegas";
            this.cmbBodegas.Size = new System.Drawing.Size(142, 21);
            this.cmbBodegas.TabIndex = 17;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(510, 58);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(142, 20);
            this.txtLote.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(451, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lote";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(789, 85);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(96, 31);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtPartidas
            // 
            this.txtPartidas.Enabled = false;
            this.txtPartidas.Location = new System.Drawing.Point(510, 19);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(142, 20);
            this.txtPartidas.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Partidas";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(295, 19);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(142, 20);
            this.txtProveedor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proveedor";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(704, 19);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(181, 55);
            this.txtNotas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(663, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notas";
            // 
            // txtPallets
            // 
            this.txtPallets.Location = new System.Drawing.Point(295, 55);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(142, 20);
            this.txtPallets.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pallets";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(78, 92);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(295, 92);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(142, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(78, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // dgvImportRawMat
            // 
            this.dgvImportRawMat.AllowUserToAddRows = false;
            this.dgvImportRawMat.AllowUserToDeleteRows = false;
            this.dgvImportRawMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmCodigoPallet,
            this.clmCantidad,
            this.clmLote,
            this.clmEmpresa,
            this.clmNotas,
            this.clmProveedor,
            this.clmBodega,
            this.clmPartidas});
            this.dgvImportRawMat.Location = new System.Drawing.Point(7, 136);
            this.dgvImportRawMat.Name = "dgvImportRawMat";
            this.dgvImportRawMat.ReadOnly = true;
            this.dgvImportRawMat.Size = new System.Drawing.Size(897, 336);
            this.dgvImportRawMat.TabIndex = 10;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmCodigoPallet
            // 
            this.clmCodigoPallet.HeaderText = "Código de Pallet";
            this.clmCodigoPallet.Name = "clmCodigoPallet";
            this.clmCodigoPallet.ReadOnly = true;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            // 
            // clmEmpresa
            // 
            this.clmEmpresa.HeaderText = "Empresa";
            this.clmEmpresa.Name = "clmEmpresa";
            this.clmEmpresa.ReadOnly = true;
            // 
            // clmNotas
            // 
            this.clmNotas.HeaderText = "Notas";
            this.clmNotas.Name = "clmNotas";
            this.clmNotas.ReadOnly = true;
            // 
            // clmProveedor
            // 
            this.clmProveedor.HeaderText = "Proveedor";
            this.clmProveedor.Name = "clmProveedor";
            this.clmProveedor.ReadOnly = true;
            // 
            // clmBodega
            // 
            this.clmBodega.HeaderText = "Bodega Destino";
            this.clmBodega.Name = "clmBodega";
            this.clmBodega.ReadOnly = true;
            // 
            // clmPartidas
            // 
            this.clmPartidas.HeaderText = "Partidas";
            this.clmPartidas.Name = "clmPartidas";
            this.clmPartidas.ReadOnly = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(801, 478);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 46);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Location = new System.Drawing.Point(7, 478);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 46);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Peso";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(65, 17);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(142, 20);
            this.txtPeso.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kg";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCantidadPallet);
            this.groupBox2.Location = new System.Drawing.Point(254, 478);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 46);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total Pallet";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Cantidad";
            // 
            // txtCantidadPallet
            // 
            this.txtCantidadPallet.Location = new System.Drawing.Point(76, 17);
            this.txtCantidadPallet.Name = "txtCantidadPallet";
            this.txtCantidadPallet.Size = new System.Drawing.Size(142, 20);
            this.txtCantidadPallet.TabIndex = 0;
            // 
            // frmImportRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 527);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvImportRawMat);
            this.Controls.Add(this.gpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportRawMaterial";
            this.Text = "Importar Materias Primas";
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportRawMat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPallets;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvImportRawMat;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPartidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBodegas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPartidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCantidadPallet;
    }
}