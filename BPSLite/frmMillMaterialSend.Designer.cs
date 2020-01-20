namespace BPS.Lite
{
    partial class frmMillMaterialSend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillMaterialSend));
            this.tbBobinaMadre = new System.Windows.Forms.TabControl();
            this.tbPallet = new System.Windows.Forms.TabPage();
            this.btnGuardarScrap = new System.Windows.Forms.Button();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPalletScrap = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmElimPallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.btnCoilProcesi = new System.Windows.Forms.Button();
            this.dgvScrapCoil = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCoilCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmElimBobina = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTMerma = new System.Windows.Forms.ComboBox();
            this.btnMCProcesar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBobinaMadre = new System.Windows.Forms.TextBox();
            this.dgvBobinaMadre = new System.Windows.Forms.DataGridView();
            this.clmMCCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMCCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMCProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMCNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMCFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMCCoilCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmElimBobMad = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbBobinaMadre.SuspendLayout();
            this.tbPallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletScrap)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrapCoil)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBobinaMadre)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBobinaMadre
            // 
            this.tbBobinaMadre.Controls.Add(this.tbPallet);
            this.tbBobinaMadre.Controls.Add(this.tabPage2);
            this.tbBobinaMadre.Controls.Add(this.tabPage1);
            this.tbBobinaMadre.Location = new System.Drawing.Point(3, 3);
            this.tbBobinaMadre.Name = "tbBobinaMadre";
            this.tbBobinaMadre.SelectedIndex = 0;
            this.tbBobinaMadre.Size = new System.Drawing.Size(801, 442);
            this.tbBobinaMadre.TabIndex = 1;
            // 
            // tbPallet
            // 
            this.tbPallet.Controls.Add(this.btnGuardarScrap);
            this.tbPallet.Controls.Add(this.txtPalletCode);
            this.tbPallet.Controls.Add(this.label1);
            this.tbPallet.Controls.Add(this.dgvPalletScrap);
            this.tbPallet.Location = new System.Drawing.Point(4, 22);
            this.tbPallet.Name = "tbPallet";
            this.tbPallet.Padding = new System.Windows.Forms.Padding(3);
            this.tbPallet.Size = new System.Drawing.Size(793, 416);
            this.tbPallet.TabIndex = 0;
            this.tbPallet.Text = "Pallet Scrap";
            this.tbPallet.UseVisualStyleBackColor = true;
            // 
            // btnGuardarScrap
            // 
            this.btnGuardarScrap.Location = new System.Drawing.Point(646, 371);
            this.btnGuardarScrap.Name = "btnGuardarScrap";
            this.btnGuardarScrap.Size = new System.Drawing.Size(141, 36);
            this.btnGuardarScrap.TabIndex = 5;
            this.btnGuardarScrap.Text = "Procesar";
            this.btnGuardarScrap.UseVisualStyleBackColor = true;
            this.btnGuardarScrap.Click += new System.EventHandler(this.btnGuardarScrap_Click);
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Location = new System.Drawing.Point(110, 16);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(177, 20);
            this.txtPalletCode.TabIndex = 4;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo de Pallet";
            // 
            // dgvPalletScrap
            // 
            this.dgvPalletScrap.AllowUserToAddRows = false;
            this.dgvPalletScrap.AllowUserToDeleteRows = false;
            this.dgvPalletScrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletScrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodigo,
            this.clmTipo,
            this.clmMaquina,
            this.clmTurno,
            this.clmPeso,
            this.clmFecha,
            this.clmElimPallet});
            this.dgvPalletScrap.Location = new System.Drawing.Point(-3, 52);
            this.dgvPalletScrap.Name = "dgvPalletScrap";
            this.dgvPalletScrap.ReadOnly = true;
            this.dgvPalletScrap.Size = new System.Drawing.Size(793, 313);
            this.dgvPalletScrap.TabIndex = 0;
            this.dgvPalletScrap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletScrap_CellContentClick);
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
            this.clmTipo.HeaderText = "Tipo";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            // 
            // clmMaquina
            // 
            this.clmMaquina.HeaderText = "Máquina";
            this.clmMaquina.Name = "clmMaquina";
            this.clmMaquina.ReadOnly = true;
            // 
            // clmTurno
            // 
            this.clmTurno.HeaderText = "Turno";
            this.clmTurno.Name = "clmTurno";
            this.clmTurno.ReadOnly = true;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmElimPallet
            // 
            this.clmElimPallet.HeaderText = "Eliminar";
            this.clmElimPallet.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmElimPallet.Name = "clmElimPallet";
            this.clmElimPallet.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbTProducto);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtCoilCode);
            this.tabPage2.Controls.Add(this.btnCoilProcesi);
            this.tabPage2.Controls.Add(this.dgvScrapCoil);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bobinas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo Merma";
            // 
            // cmbTProducto
            // 
            this.cmbTProducto.FormattingEnabled = true;
            this.cmbTProducto.Location = new System.Drawing.Point(110, 15);
            this.cmbTProducto.Name = "cmbTProducto";
            this.cmbTProducto.Size = new System.Drawing.Size(151, 21);
            this.cmbTProducto.TabIndex = 6;
            this.cmbTProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbTProducto_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código de Bobina";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Location = new System.Drawing.Point(387, 15);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(177, 20);
            this.txtCoilCode.TabIndex = 4;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // btnCoilProcesi
            // 
            this.btnCoilProcesi.Location = new System.Drawing.Point(647, 377);
            this.btnCoilProcesi.Name = "btnCoilProcesi";
            this.btnCoilProcesi.Size = new System.Drawing.Size(141, 36);
            this.btnCoilProcesi.TabIndex = 3;
            this.btnCoilProcesi.Text = "Procesar";
            this.btnCoilProcesi.UseVisualStyleBackColor = true;
            this.btnCoilProcesi.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvScrapCoil
            // 
            this.dgvScrapCoil.AllowUserToAddRows = false;
            this.dgvScrapCoil.AllowUserToDeleteRows = false;
            this.dgvScrapCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScrapCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmProducto,
            this.clmNetWeigth,
            this.clmfkCoilCellar,
            this.clmCoilDate,
            this.clmElimBobina});
            this.dgvScrapCoil.Location = new System.Drawing.Point(-4, 53);
            this.dgvScrapCoil.Name = "dgvScrapCoil";
            this.dgvScrapCoil.ReadOnly = true;
            this.dgvScrapCoil.Size = new System.Drawing.Size(801, 318);
            this.dgvScrapCoil.TabIndex = 0;
            this.dgvScrapCoil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScrapCoil_CellContentClick);
            // 
            // clmCoilCodsec
            // 
            this.clmCoilCodsec.HeaderText = "Codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.ReadOnly = true;
            // 
            // clmfkCoilCellar
            // 
            this.clmfkCoilCellar.HeaderText = "coilCellar";
            this.clmfkCoilCellar.Name = "clmfkCoilCellar";
            this.clmfkCoilCellar.ReadOnly = true;
            this.clmfkCoilCellar.Visible = false;
            // 
            // clmCoilDate
            // 
            this.clmCoilDate.HeaderText = "Fecha";
            this.clmCoilDate.Name = "clmCoilDate";
            this.clmCoilDate.ReadOnly = true;
            // 
            // clmElimBobina
            // 
            this.clmElimBobina.HeaderText = "Eliminar";
            this.clmElimBobina.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmElimBobina.Name = "clmElimBobina";
            this.clmElimBobina.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmbTMerma);
            this.tabPage1.Controls.Add(this.btnMCProcesar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtBobinaMadre);
            this.tabPage1.Controls.Add(this.dgvBobinaMadre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 416);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Bobinas Madres";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo Merma";
            // 
            // cmbTMerma
            // 
            this.cmbTMerma.FormattingEnabled = true;
            this.cmbTMerma.Location = new System.Drawing.Point(110, 15);
            this.cmbTMerma.Name = "cmbTMerma";
            this.cmbTMerma.Size = new System.Drawing.Size(151, 21);
            this.cmbTMerma.TabIndex = 5;
            this.cmbTMerma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTMerma_KeyDown);
            // 
            // btnMCProcesar
            // 
            this.btnMCProcesar.Location = new System.Drawing.Point(642, 374);
            this.btnMCProcesar.Name = "btnMCProcesar";
            this.btnMCProcesar.Size = new System.Drawing.Size(141, 36);
            this.btnMCProcesar.TabIndex = 4;
            this.btnMCProcesar.Text = "Procesar";
            this.btnMCProcesar.UseVisualStyleBackColor = true;
            this.btnMCProcesar.Click += new System.EventHandler(this.btnBobinaMadre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código de Bobina";
            // 
            // txtBobinaMadre
            // 
            this.txtBobinaMadre.Location = new System.Drawing.Point(387, 15);
            this.txtBobinaMadre.Name = "txtBobinaMadre";
            this.txtBobinaMadre.Size = new System.Drawing.Size(177, 20);
            this.txtBobinaMadre.TabIndex = 2;
            this.txtBobinaMadre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBobinaMadre_KeyDown);
            // 
            // dgvBobinaMadre
            // 
            this.dgvBobinaMadre.AllowUserToAddRows = false;
            this.dgvBobinaMadre.AllowUserToDeleteRows = false;
            this.dgvBobinaMadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBobinaMadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMCCodsec,
            this.clmMCCodigo,
            this.clmMCProducto,
            this.clmMCNetWeigth,
            this.clmMCFecha,
            this.clmMCCoilCellar,
            this.clmElimBobMad});
            this.dgvBobinaMadre.Location = new System.Drawing.Point(-4, 53);
            this.dgvBobinaMadre.Name = "dgvBobinaMadre";
            this.dgvBobinaMadre.ReadOnly = true;
            this.dgvBobinaMadre.Size = new System.Drawing.Size(801, 315);
            this.dgvBobinaMadre.TabIndex = 1;
            this.dgvBobinaMadre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBobinaMadre_CellContentClick);
            // 
            // clmMCCodsec
            // 
            this.clmMCCodsec.HeaderText = "Codsec";
            this.clmMCCodsec.Name = "clmMCCodsec";
            this.clmMCCodsec.ReadOnly = true;
            this.clmMCCodsec.Visible = false;
            // 
            // clmMCCodigo
            // 
            this.clmMCCodigo.HeaderText = "Código";
            this.clmMCCodigo.Name = "clmMCCodigo";
            this.clmMCCodigo.ReadOnly = true;
            // 
            // clmMCProducto
            // 
            this.clmMCProducto.HeaderText = "Producto";
            this.clmMCProducto.Name = "clmMCProducto";
            this.clmMCProducto.ReadOnly = true;
            // 
            // clmMCNetWeigth
            // 
            this.clmMCNetWeigth.HeaderText = "Peso Neto";
            this.clmMCNetWeigth.Name = "clmMCNetWeigth";
            this.clmMCNetWeigth.ReadOnly = true;
            // 
            // clmMCFecha
            // 
            this.clmMCFecha.HeaderText = "Fecha";
            this.clmMCFecha.Name = "clmMCFecha";
            this.clmMCFecha.ReadOnly = true;
            // 
            // clmMCCoilCellar
            // 
            this.clmMCCoilCellar.HeaderText = "CoilCellar";
            this.clmMCCoilCellar.Name = "clmMCCoilCellar";
            this.clmMCCoilCellar.ReadOnly = true;
            this.clmMCCoilCellar.Visible = false;
            // 
            // clmElimBobMad
            // 
            this.clmElimBobMad.HeaderText = "Eliminar";
            this.clmElimBobMad.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmElimBobMad.Name = "clmElimBobMad";
            this.clmElimBobMad.ReadOnly = true;
            // 
            // frmMillMaterialSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 444);
            this.Controls.Add(this.tbBobinaMadre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMillMaterialSend";
            this.Text = "Envio de material al molino";
            this.Load += new System.EventHandler(this.frmMillMaterialSend_Load);
            this.tbBobinaMadre.ResumeLayout(false);
            this.tbPallet.ResumeLayout(false);
            this.tbPallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletScrap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScrapCoil)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBobinaMadre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbBobinaMadre;
        private System.Windows.Forms.TabPage tbPallet;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPalletScrap;
        private System.Windows.Forms.DataGridView dgvScrapCoil;
        private System.Windows.Forms.Button btnCoilProcesi;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarScrap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.ComboBox cmbTProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBobinaMadre;
        private System.Windows.Forms.DataGridView dgvBobinaMadre;
        private System.Windows.Forms.Button btnMCProcesar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTMerma;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewImageColumn clmElimPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCoilCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDate;
        private System.Windows.Forms.DataGridViewImageColumn clmElimBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMCCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMCCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMCProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMCNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMCFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMCCoilCellar;
        private System.Windows.Forms.DataGridViewImageColumn clmElimBobMad;
    }
}