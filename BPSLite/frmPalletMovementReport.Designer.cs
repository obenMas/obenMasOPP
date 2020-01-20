namespace BPS.Lite
{
    partial class frmPalletMovementReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletMovementReport));
            this.dgvPalletMovements = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipeMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletMovements)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPalletMovements
            // 
            this.dgvPalletMovements.AllowUserToAddRows = false;
            this.dgvPalletMovements.AllowUserToDeleteRows = false;
            this.dgvPalletMovements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletMovements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmCodigoMaterial,
            this.clmNomMaterial,
            this.clmTipeMov,
            this.clmLote,
            this.clmBodegaOrigen,
            this.clmBodegaDestino,
            this.clmUser,
            this.clmFecha,
            this.clmDia,
            this.clmMes,
            this.clmAño,
            this.clmHour});
            this.dgvPalletMovements.Location = new System.Drawing.Point(12, 90);
            this.dgvPalletMovements.Name = "dgvPalletMovements";
            this.dgvPalletMovements.ReadOnly = true;
            this.dgvPalletMovements.Size = new System.Drawing.Size(888, 333);
            this.dgvPalletMovements.TabIndex = 39;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(706, 33);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(121, 51);
            this.btnGenerar.TabIndex = 32;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbPlanta);
            this.groupBox6.Location = new System.Drawing.Point(549, 33);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 52);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(12, 19);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(108, 21);
            this.cmbPlanta.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(549, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(103, 31);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Planta:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpHasta);
            this.groupBox4.Location = new System.Drawing.Point(280, 32);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 52);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(6, 21);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(251, 20);
            this.dtpHasta.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(280, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 31);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hasta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Location = new System.Drawing.Point(11, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 52);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(6, 21);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(251, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 31);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desde:";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExportExcel.Location = new System.Drawing.Point(857, 50);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(43, 35);
            this.btnExportExcel.TabIndex = 33;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código Pallet";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 120;
            // 
            // clmCodigoMaterial
            // 
            this.clmCodigoMaterial.HeaderText = "Código Material";
            this.clmCodigoMaterial.Name = "clmCodigoMaterial";
            this.clmCodigoMaterial.ReadOnly = true;
            this.clmCodigoMaterial.Width = 140;
            // 
            // clmNomMaterial
            // 
            this.clmNomMaterial.HeaderText = "Nombre Material";
            this.clmNomMaterial.Name = "clmNomMaterial";
            this.clmNomMaterial.ReadOnly = true;
            this.clmNomMaterial.Width = 200;
            // 
            // clmTipeMov
            // 
            this.clmTipeMov.HeaderText = "Movimiento";
            this.clmTipeMov.Name = "clmTipeMov";
            this.clmTipeMov.ReadOnly = true;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 120;
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
            // clmUser
            // 
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            this.clmUser.Width = 120;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmDia
            // 
            this.clmDia.HeaderText = "Dia";
            this.clmDia.Name = "clmDia";
            this.clmDia.ReadOnly = true;
            this.clmDia.Visible = false;
            // 
            // clmMes
            // 
            this.clmMes.HeaderText = "Mes";
            this.clmMes.Name = "clmMes";
            this.clmMes.ReadOnly = true;
            this.clmMes.Visible = false;
            // 
            // clmAño
            // 
            this.clmAño.HeaderText = "Año";
            this.clmAño.Name = "clmAño";
            this.clmAño.ReadOnly = true;
            this.clmAño.Visible = false;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            this.clmHour.Visible = false;
            // 
            // frmPalletMovementReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 430);
            this.Controls.Add(this.dgvPalletMovements);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExportExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletMovementReport";
            this.Text = "Reporte de Movimiento de Pallets";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletMovements)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPalletMovements;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipeMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
    }
}