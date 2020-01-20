namespace BPS
{
    partial class frmPalletRawMaterialStock
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBodegas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCodigoMaterial = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnLimpiarCmb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoMaterial = new System.Windows.Forms.ComboBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.dgvStockRaw = new System.Windows.Forms.DataGridView();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRaw)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbBodegas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbPlanta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbCodigoMaterial);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnLimpiarCmb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbTipoMaterial);
            this.groupBox1.Controls.Add(this.cmbCodigo);
            this.groupBox1.Location = new System.Drawing.Point(24, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bodega";
            // 
            // cmbBodegas
            // 
            this.cmbBodegas.FormattingEnabled = true;
            this.cmbBodegas.Location = new System.Drawing.Point(540, 14);
            this.cmbBodegas.Name = "cmbBodegas";
            this.cmbBodegas.Size = new System.Drawing.Size(174, 21);
            this.cmbBodegas.TabIndex = 12;
            this.cmbBodegas.SelectedIndexChanged += new System.EventHandler(this.cmbBodegas_SelectedIndexChanged);
            this.cmbBodegas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBodegas_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Planta";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(53, 50);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(150, 21);
            this.cmbPlanta.TabIndex = 10;
            this.cmbPlanta.SelectedIndexChanged += new System.EventHandler(this.cmbPlanta_SelectedIndexChanged);
            this.cmbPlanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPlanta_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Código Material";
            // 
            // cmbCodigoMaterial
            // 
            this.cmbCodigoMaterial.FormattingEnabled = true;
            this.cmbCodigoMaterial.Location = new System.Drawing.Point(297, 50);
            this.cmbCodigoMaterial.Name = "cmbCodigoMaterial";
            this.cmbCodigoMaterial.Size = new System.Drawing.Size(174, 21);
            this.cmbCodigoMaterial.TabIndex = 8;
            this.cmbCodigoMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoMaterial_SelectedIndexChanged);
            this.cmbCodigoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCodigoMaterial_KeyDown);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(834, 13);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(33, 30);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnLimpiarCmb
            // 
            this.btnLimpiarCmb.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnLimpiarCmb.Location = new System.Drawing.Point(795, 13);
            this.btnLimpiarCmb.Name = "btnLimpiarCmb";
            this.btnLimpiarCmb.Size = new System.Drawing.Size(33, 30);
            this.btnLimpiarCmb.TabIndex = 6;
            this.btnLimpiarCmb.UseVisualStyleBackColor = true;
            this.btnLimpiarCmb.Click += new System.EventHandler(this.btnLimpiarCmb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Material";
            // 
            // cmbTipoMaterial
            // 
            this.cmbTipoMaterial.FormattingEnabled = true;
            this.cmbTipoMaterial.Location = new System.Drawing.Point(297, 14);
            this.cmbTipoMaterial.Name = "cmbTipoMaterial";
            this.cmbTipoMaterial.Size = new System.Drawing.Size(174, 21);
            this.cmbTipoMaterial.TabIndex = 1;
            this.cmbTipoMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMaterial_SelectedIndexChanged);
            this.cmbTipoMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipoMaterial_KeyDown);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(53, 19);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(150, 21);
            this.cmbCodigo.TabIndex = 0;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            this.cmbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCodigo_KeyDown);
            // 
            // dgvStockRaw
            // 
            this.dgvStockRaw.AllowUserToAddRows = false;
            this.dgvStockRaw.AllowUserToDeleteRows = false;
            this.dgvStockRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockRaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodigo,
            this.clmCodigoM,
            this.clmTipoMat,
            this.clmPeso,
            this.clmPlanta,
            this.clmBodega,
            this.clmFecha});
            this.dgvStockRaw.Location = new System.Drawing.Point(24, 93);
            this.dgvStockRaw.Name = "dgvStockRaw";
            this.dgvStockRaw.ReadOnly = true;
            this.dgvStockRaw.Size = new System.Drawing.Size(886, 337);
            this.dgvStockRaw.TabIndex = 4;
            // 
            // txtPesos
            // 
            this.txtPesos.Enabled = false;
            this.txtPesos.Location = new System.Drawing.Point(90, 18);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(133, 20);
            this.txtPesos.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPesos);
            this.groupBox2.Location = new System.Drawing.Point(26, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 46);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pesos Totales";
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 150;
            // 
            // clmCodigoM
            // 
            this.clmCodigoM.HeaderText = "Codigo Material";
            this.clmCodigoM.Name = "clmCodigoM";
            this.clmCodigoM.ReadOnly = true;
            // 
            // clmTipoMat
            // 
            this.clmTipoMat.HeaderText = "Tipo Material";
            this.clmTipoMat.Name = "clmTipoMat";
            this.clmTipoMat.ReadOnly = true;
            this.clmTipoMat.Width = 200;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso Neto";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            // 
            // clmBodega
            // 
            this.clmBodega.HeaderText = "Bodega";
            this.clmBodega.Name = "clmBodega";
            this.clmBodega.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 140;
            // 
            // frmPalletRawMaterialStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 482);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvStockRaw);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPalletRawMaterialStock";
            this.ShowIcon = false;
            this.Text = "Pallets de Materia Prima";
            this.Load += new System.EventHandler(this.frmPalletRawMaterialStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockRaw)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoMaterial;
        private System.Windows.Forms.DataGridView dgvStockRaw;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnLimpiarCmb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBodegas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCodigoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
    }
}