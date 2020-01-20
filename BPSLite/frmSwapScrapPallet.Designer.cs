namespace BPS.Lite
{
    partial class frmSwapScrapPallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSwapScrapPallet));
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvPalletSwap = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvIngresoScrapSwap = new System.Windows.Forms.DataGridView();
            this.clmIngCodPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngCodScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngNomScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngPesoScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngBdOrgScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBdDestinoScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIngFechaScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAceptScrap = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDenyScrap = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotKgOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPalletTotOut = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotPalletIn = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotKgIn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletSwap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoScrapSwap)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(733, 355);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(117, 42);
            this.btnProcesar.TabIndex = 1;
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
            this.clmCodigo,
            this.clmTipo,
            this.clmMachine,
            this.clmPeso,
            this.clmTurno,
            this.clmBodegaOrigen,
            this.clmBodegaDestino,
            this.clmFecha,
            this.clmEliminar});
            this.dgvPalletSwap.Location = new System.Drawing.Point(3, 77);
            this.dgvPalletSwap.Name = "dgvPalletSwap";
            this.dgvPalletSwap.ReadOnly = true;
            this.dgvPalletSwap.Size = new System.Drawing.Size(847, 262);
            this.dgvPalletSwap.TabIndex = 0;
            this.dgvPalletSwap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletSwap_CellContentClick);
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
            this.clmTipo.HeaderText = "Tipo Scrap";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            // 
            // clmMachine
            // 
            this.clmMachine.HeaderText = "Máquina";
            this.clmMachine.Name = "clmMachine";
            this.clmMachine.ReadOnly = true;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmTurno
            // 
            this.clmTurno.HeaderText = "Turno";
            this.clmTurno.Name = "clmTurno";
            this.clmTurno.ReadOnly = true;
            // 
            // clmBodegaOrigen
            // 
            this.clmBodegaOrigen.HeaderText = "Bodega Origen";
            this.clmBodegaOrigen.Name = "clmBodegaOrigen";
            this.clmBodegaOrigen.ReadOnly = true;
            // 
            // clmBodegaDestino
            // 
            this.clmBodegaDestino.HeaderText = "Bodega Destino";
            this.clmBodegaDestino.Name = "clmBodegaDestino";
            this.clmBodegaDestino.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar";
            this.clmEliminar.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.cmbOrigen);
            this.groupBox1.Controls.Add(this.cmbDestino);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de envío";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(672, 29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(108, 29);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(149, 21);
            this.cmbOrigen.TabIndex = 4;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            this.cmbOrigen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrigen_KeyDown);
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(386, 29);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(146, 21);
            this.cmbDestino.TabIndex = 3;
            this.cmbDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDestino_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bodega Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bodega Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Pallet";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 427);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvPalletSwap);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnProcesar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(860, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Swap";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.dgvIngresoScrapSwap);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(860, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ingreso Swap";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvIngresoScrapSwap
            // 
            this.dgvIngresoScrapSwap.AllowUserToAddRows = false;
            this.dgvIngresoScrapSwap.AllowUserToDeleteRows = false;
            this.dgvIngresoScrapSwap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngresoScrapSwap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIngCodPallet,
            this.clmIngCodScrap,
            this.clmIngNomScrap,
            this.clmIngPesoScrap,
            this.clmIngBdOrgScrap,
            this.clmBdDestinoScrap,
            this.clmIngFechaScrap,
            this.clmAceptScrap,
            this.clmDenyScrap});
            this.dgvIngresoScrapSwap.Location = new System.Drawing.Point(6, 6);
            this.dgvIngresoScrapSwap.Name = "dgvIngresoScrapSwap";
            this.dgvIngresoScrapSwap.ReadOnly = true;
            this.dgvIngresoScrapSwap.Size = new System.Drawing.Size(851, 329);
            this.dgvIngresoScrapSwap.TabIndex = 0;
            this.dgvIngresoScrapSwap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngresoScrapSwap_CellContentClick);
            // 
            // clmIngCodPallet
            // 
            this.clmIngCodPallet.HeaderText = "Código de Pallet";
            this.clmIngCodPallet.Name = "clmIngCodPallet";
            this.clmIngCodPallet.ReadOnly = true;
            this.clmIngCodPallet.Width = 120;
            // 
            // clmIngCodScrap
            // 
            this.clmIngCodScrap.HeaderText = "Código de Scrap";
            this.clmIngCodScrap.Name = "clmIngCodScrap";
            this.clmIngCodScrap.ReadOnly = true;
            this.clmIngCodScrap.Width = 120;
            // 
            // clmIngNomScrap
            // 
            this.clmIngNomScrap.HeaderText = "Nombre de Scrap";
            this.clmIngNomScrap.Name = "clmIngNomScrap";
            this.clmIngNomScrap.ReadOnly = true;
            this.clmIngNomScrap.Width = 180;
            // 
            // clmIngPesoScrap
            // 
            this.clmIngPesoScrap.HeaderText = "Peso Scrap";
            this.clmIngPesoScrap.Name = "clmIngPesoScrap";
            this.clmIngPesoScrap.ReadOnly = true;
            this.clmIngPesoScrap.Width = 70;
            // 
            // clmIngBdOrgScrap
            // 
            this.clmIngBdOrgScrap.HeaderText = "Bodega Origen";
            this.clmIngBdOrgScrap.Name = "clmIngBdOrgScrap";
            this.clmIngBdOrgScrap.ReadOnly = true;
            this.clmIngBdOrgScrap.Width = 140;
            // 
            // clmBdDestinoScrap
            // 
            this.clmBdDestinoScrap.HeaderText = "Bodega Destino";
            this.clmBdDestinoScrap.Name = "clmBdDestinoScrap";
            this.clmBdDestinoScrap.ReadOnly = true;
            this.clmBdDestinoScrap.Width = 140;
            // 
            // clmIngFechaScrap
            // 
            this.clmIngFechaScrap.HeaderText = "Fecha";
            this.clmIngFechaScrap.Name = "clmIngFechaScrap";
            this.clmIngFechaScrap.ReadOnly = true;
            this.clmIngFechaScrap.Width = 130;
            // 
            // clmAceptScrap
            // 
            this.clmAceptScrap.HeaderText = "Aceptar";
            this.clmAceptScrap.Image = global::BPS.Lite.Properties.Resources.accept;
            this.clmAceptScrap.Name = "clmAceptScrap";
            this.clmAceptScrap.ReadOnly = true;
            this.clmAceptScrap.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clmDenyScrap
            // 
            this.clmDenyScrap.HeaderText = "Rechazar";
            this.clmDenyScrap.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmDenyScrap.Name = "clmDenyScrap";
            this.clmDenyScrap.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTotKgOut);
            this.groupBox2.Location = new System.Drawing.Point(3, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total de Kilos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPalletTotOut);
            this.groupBox3.Location = new System.Drawing.Point(232, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 57);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total de Pallet";
            // 
            // txtTotKgOut
            // 
            this.txtTotKgOut.Location = new System.Drawing.Point(70, 23);
            this.txtTotKgOut.Name = "txtTotKgOut";
            this.txtTotKgOut.Size = new System.Drawing.Size(124, 20);
            this.txtTotKgOut.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad";
            // 
            // txtPalletTotOut
            // 
            this.txtPalletTotOut.Location = new System.Drawing.Point(71, 23);
            this.txtPalletTotOut.Name = "txtPalletTotOut";
            this.txtPalletTotOut.Size = new System.Drawing.Size(124, 20);
            this.txtPalletTotOut.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTotPalletIn);
            this.groupBox4.Location = new System.Drawing.Point(235, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(223, 57);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total de Pallet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cantidad";
            // 
            // txtTotPalletIn
            // 
            this.txtTotPalletIn.Location = new System.Drawing.Point(71, 23);
            this.txtTotPalletIn.Name = "txtTotPalletIn";
            this.txtTotPalletIn.Size = new System.Drawing.Size(124, 20);
            this.txtTotPalletIn.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtTotKgIn);
            this.groupBox5.Location = new System.Drawing.Point(6, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(223, 57);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total de Kilos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cantidad";
            // 
            // txtTotKgIn
            // 
            this.txtTotKgIn.Location = new System.Drawing.Point(70, 23);
            this.txtTotKgIn.Name = "txtTotKgIn";
            this.txtTotKgIn.Size = new System.Drawing.Size(124, 20);
            this.txtTotKgIn.TabIndex = 0;
            // 
            // frmSwapScrapPallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 425);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSwapScrapPallet";
            this.Text = "Envio de scrap entre Plantas";
            this.Load += new System.EventHandler(this.frmScrapSwap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletSwap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresoScrapSwap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dgvPalletSwap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvIngresoScrapSwap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngCodPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngCodScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngNomScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngPesoScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngBdOrgScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBdDestinoScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIngFechaScrap;
        private System.Windows.Forms.DataGridViewImageColumn clmAceptScrap;
        private System.Windows.Forms.DataGridViewImageColumn clmDenyScrap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotKgOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPalletTotOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotPalletIn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotKgIn;

    }
}