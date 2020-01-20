namespace BPS.Lite
{
    partial class frmImportRawMaterialGranel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportRawMaterialGranel));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvImportRawMat = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPartidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportRawMat)).BeginInit();
            this.gpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(863, 464);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 36);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvImportRawMat
            // 
            this.dgvImportRawMat.AllowUserToAddRows = false;
            this.dgvImportRawMat.AllowUserToDeleteRows = false;
            this.dgvImportRawMat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmCantidad,
            this.clmLote,
            this.clmEmpresa,
            this.clmNotas,
            this.clmProveedor,
            this.clmSilo,
            this.clmPartidas,
            this.clmFecha});
            this.dgvImportRawMat.Location = new System.Drawing.Point(12, 134);
            this.dgvImportRawMat.Name = "dgvImportRawMat";
            this.dgvImportRawMat.ReadOnly = true;
            this.dgvImportRawMat.Size = new System.Drawing.Size(952, 324);
            this.dgvImportRawMat.TabIndex = 13;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
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
            // clmSilo
            // 
            this.clmSilo.HeaderText = "Silo Destino";
            this.clmSilo.Name = "clmSilo";
            this.clmSilo.ReadOnly = true;
            // 
            // clmPartidas
            // 
            this.clmPartidas.HeaderText = "Partidas";
            this.clmPartidas.Name = "clmPartidas";
            this.clmPartidas.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
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
            this.gpDatos.Controls.Add(this.txtCantidad);
            this.gpDatos.Controls.Add(this.label3);
            this.gpDatos.Controls.Add(this.txtEmpresa);
            this.gpDatos.Controls.Add(this.label2);
            this.gpDatos.Controls.Add(this.txtCodigo);
            this.gpDatos.Controls.Add(this.label1);
            this.gpDatos.Location = new System.Drawing.Point(12, 5);
            this.gpDatos.Name = "gpDatos";
            this.gpDatos.Size = new System.Drawing.Size(952, 123);
            this.gpDatos.TabIndex = 12;
            this.gpDatos.TabStop = false;
            this.gpDatos.Text = "Datos de Materia Prima";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Silo";
            // 
            // cmbBodegas
            // 
            this.cmbBodegas.FormattingEnabled = true;
            this.cmbBodegas.Location = new System.Drawing.Point(104, 55);
            this.cmbBodegas.Name = "cmbBodegas";
            this.cmbBodegas.Size = new System.Drawing.Size(142, 21);
            this.cmbBodegas.TabIndex = 17;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(326, 56);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(142, 20);
            this.txtLote.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Lote";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(830, 87);
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
            this.txtPartidas.Location = new System.Drawing.Point(549, 20);
            this.txtPartidas.Name = "txtPartidas";
            this.txtPartidas.Size = new System.Drawing.Size(142, 20);
            this.txtPartidas.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Partidas";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(326, 19);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(142, 20);
            this.txtProveedor.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proveedor";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(745, 21);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(181, 55);
            this.txtNotas.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notas";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(549, 56);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(142, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(490, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(104, 91);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(142, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(104, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // frmImportRawMaterialGranel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 512);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvImportRawMat);
            this.Controls.Add(this.gpDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImportRawMaterialGranel";
            this.Text = "Ingreso de materia prima a granel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportRawMat)).EndInit();
            this.gpDatos.ResumeLayout(false);
            this.gpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvImportRawMat;
        private System.Windows.Forms.GroupBox gpDatos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBodegas;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtPartidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
    }
}