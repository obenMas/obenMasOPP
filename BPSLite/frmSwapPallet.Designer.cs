namespace BPS.Lite
{
    partial class frmSwapPallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwapPallet));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPesoTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPalletTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvPalletSwap = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrosWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOriginCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinyCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeleteRow = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPesoIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPalletIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvIngresoSwap = new System.Windows.Forms.DataGridView();
            this.clmCodPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaPend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAceptar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDeny = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletSwap)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoSwap)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnProcesar);
            this.tabPage1.Controls.Add(this.dgvPalletSwap);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(857, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Swap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPesoTo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(255, 349);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 54);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Peso Pallets";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kg";
            // 
            // txtPesoTo
            // 
            this.txtPesoTo.Location = new System.Drawing.Point(78, 20);
            this.txtPesoTo.Name = "txtPesoTo";
            this.txtPesoTo.Size = new System.Drawing.Size(136, 20);
            this.txtPesoTo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPalletTo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(4, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 54);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pallets a Swap";
            // 
            // txtPalletTo
            // 
            this.txtPalletTo.Location = new System.Drawing.Point(78, 20);
            this.txtPalletTo.Name = "txtPalletTo";
            this.txtPalletTo.Size = new System.Drawing.Size(136, 20);
            this.txtPalletTo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPalletCode);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de envío";
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Location = new System.Drawing.Point(677, 32);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(151, 20);
            this.txtPalletCode.TabIndex = 5;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(116, 30);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(149, 21);
            this.cmbOrigen.TabIndex = 4;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(400, 30);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(146, 21);
            this.cmbDestino.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bodega Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bodega Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Pallet";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(732, 357);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(117, 42);
            this.btnProcesar.TabIndex = 4;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // dgvPalletSwap
            // 
            this.dgvPalletSwap.AllowUserToAddRows = false;
            this.dgvPalletSwap.AllowUserToDeleteRows = false;
            this.dgvPalletSwap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletSwap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPalletCode,
            this.clmStatus,
            this.clmNetWeight,
            this.clmGrosWeight,
            this.clmPosition,
            this.clmOriginCellar,
            this.clmDestinyCellar,
            this.clmFecha,
            this.clmDeleteRow});
            this.dgvPalletSwap.Location = new System.Drawing.Point(4, 81);
            this.dgvPalletSwap.Name = "dgvPalletSwap";
            this.dgvPalletSwap.ReadOnly = true;
            this.dgvPalletSwap.Size = new System.Drawing.Size(847, 262);
            this.dgvPalletSwap.TabIndex = 3;
            this.dgvPalletSwap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletSwap_CellContentClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Código Pallet";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso Neto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 60;
            // 
            // clmGrosWeight
            // 
            this.clmGrosWeight.HeaderText = "Peso Bruto";
            this.clmGrosWeight.Name = "clmGrosWeight";
            this.clmGrosWeight.ReadOnly = true;
            this.clmGrosWeight.Width = 60;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posicion";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 110;
            // 
            // clmOriginCellar
            // 
            this.clmOriginCellar.HeaderText = "Bodega Origen";
            this.clmOriginCellar.Name = "clmOriginCellar";
            this.clmOriginCellar.ReadOnly = true;
            this.clmOriginCellar.Width = 150;
            // 
            // clmDestinyCellar
            // 
            this.clmDestinyCellar.HeaderText = "Bodega Destino";
            this.clmDestinyCellar.Name = "clmDestinyCellar";
            this.clmDestinyCellar.ReadOnly = true;
            this.clmDestinyCellar.Width = 150;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmDeleteRow
            // 
            this.clmDeleteRow.HeaderText = "Eliminar";
            this.clmDeleteRow.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmDeleteRow.Name = "clmDeleteRow";
            this.clmDeleteRow.ReadOnly = true;
            this.clmDeleteRow.Width = 60;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.dgvIngresoSwap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(857, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso Swap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtPesoIn);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(257, 349);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(245, 54);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Peso Pallets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kg";
            // 
            // txtPesoIn
            // 
            this.txtPesoIn.Location = new System.Drawing.Point(78, 20);
            this.txtPesoIn.Name = "txtPesoIn";
            this.txtPesoIn.Size = new System.Drawing.Size(136, 20);
            this.txtPesoIn.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cantidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPalletIn);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(6, 349);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 54);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pallets a Swap";
            // 
            // txtPalletIn
            // 
            this.txtPalletIn.Location = new System.Drawing.Point(78, 20);
            this.txtPalletIn.Name = "txtPalletIn";
            this.txtPalletIn.Size = new System.Drawing.Size(136, 20);
            this.txtPalletIn.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cantidad";
            // 
            // dgvIngresoSwap
            // 
            this.dgvIngresoSwap.AllowUserToAddRows = false;
            this.dgvIngresoSwap.AllowUserToDeleteRows = false;
            this.dgvIngresoSwap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoSwap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodPallet,
            this.clmCodMaterial,
            this.clmNomMaterial,
            this.clmPeso,
            this.clmBdOrigen,
            this.clmDestino,
            this.clmFechaPend,
            this.clmAceptar,
            this.clmDeny});
            this.dgvIngresoSwap.Location = new System.Drawing.Point(6, 36);
            this.dgvIngresoSwap.Name = "dgvIngresoSwap";
            this.dgvIngresoSwap.ReadOnly = true;
            this.dgvIngresoSwap.Size = new System.Drawing.Size(845, 307);
            this.dgvIngresoSwap.TabIndex = 0;
            this.dgvIngresoSwap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresoSwap_CellContentClick);
            // 
            // clmCodPallet
            // 
            this.clmCodPallet.HeaderText = "Código Pallet";
            this.clmCodPallet.Name = "clmCodPallet";
            this.clmCodPallet.ReadOnly = true;
            this.clmCodPallet.Width = 130;
            // 
            // clmCodMaterial
            // 
            this.clmCodMaterial.HeaderText = "Código de Material";
            this.clmCodMaterial.Name = "clmCodMaterial";
            this.clmCodMaterial.ReadOnly = true;
            this.clmCodMaterial.Width = 130;
            // 
            // clmNomMaterial
            // 
            this.clmNomMaterial.HeaderText = "Nombre Material";
            this.clmNomMaterial.Name = "clmNomMaterial";
            this.clmNomMaterial.ReadOnly = true;
            this.clmNomMaterial.Width = 180;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            this.clmPeso.Width = 80;
            // 
            // clmBdOrigen
            // 
            this.clmBdOrigen.HeaderText = "Origen";
            this.clmBdOrigen.Name = "clmBdOrigen";
            this.clmBdOrigen.ReadOnly = true;
            this.clmBdOrigen.Width = 120;
            // 
            // clmDestino
            // 
            this.clmDestino.HeaderText = "Destino";
            this.clmDestino.Name = "clmDestino";
            this.clmDestino.ReadOnly = true;
            this.clmDestino.Width = 120;
            // 
            // clmFechaPend
            // 
            this.clmFechaPend.HeaderText = "Fecha";
            this.clmFechaPend.Name = "clmFechaPend";
            this.clmFechaPend.ReadOnly = true;
            this.clmFechaPend.Width = 120;
            // 
            // clmAceptar
            // 
            this.clmAceptar.HeaderText = "Aceptar";
            this.clmAceptar.Image = global::BPS.Lite.Properties.Resources.accept;
            this.clmAceptar.Name = "clmAceptar";
            this.clmAceptar.ReadOnly = true;
            // 
            // clmDeny
            // 
            this.clmDeny.HeaderText = "Cancelar";
            this.clmDeny.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmDeny.Name = "clmDeny";
            this.clmDeny.ReadOnly = true;
            // 
            // frmSwapPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 433);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSwapPallet";
            this.Text = "Swap Pallets";
            this.Load += new System.EventHandler(this.frmSwapPallet_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletSwap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoSwap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dgvPalletSwap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrosWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOriginCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinyCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewImageColumn clmDeleteRow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvIngresoSwap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaPend;
        private System.Windows.Forms.DataGridViewImageColumn clmAceptar;
        private System.Windows.Forms.DataGridViewImageColumn clmDeny;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPesoTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPalletTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPesoIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPalletIn;
        private System.Windows.Forms.Label label7;


    }
}