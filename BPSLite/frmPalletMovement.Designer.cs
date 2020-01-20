namespace BPS.Lite
{
    partial class frmPalletMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletMovement));
            this.txtPosicion = new System.Windows.Forms.TextBox();
            this.txtCodPallet = new System.Windows.Forms.TextBox();
            this.cmbBodegaD = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPallet = new System.Windows.Forms.DataGridView();
            this.clmCodigoPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantPallet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPosicion
            // 
            this.txtPosicion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPosicion.CausesValidation = false;
            this.txtPosicion.Location = new System.Drawing.Point(271, 42);
            this.txtPosicion.MaximumSize = new System.Drawing.Size(150, 20);
            this.txtPosicion.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtPosicion.Name = "txtPosicion";
            this.txtPosicion.Size = new System.Drawing.Size(150, 20);
            this.txtPosicion.TabIndex = 4;
            this.txtPosicion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosicion_KeyDown);
            // 
            // txtCodPallet
            // 
            this.txtCodPallet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodPallet.CausesValidation = false;
            this.txtCodPallet.Location = new System.Drawing.Point(451, 42);
            this.txtCodPallet.MaximumSize = new System.Drawing.Size(200, 20);
            this.txtCodPallet.MinimumSize = new System.Drawing.Size(100, 20);
            this.txtCodPallet.Name = "txtCodPallet";
            this.txtCodPallet.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodPallet.Size = new System.Drawing.Size(200, 20);
            this.txtCodPallet.TabIndex = 3;
            this.txtCodPallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPallet_KeyDown);
            // 
            // cmbBodegaD
            // 
            this.cmbBodegaD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBodegaD.CausesValidation = false;
            this.cmbBodegaD.FormattingEnabled = true;
            this.cmbBodegaD.Location = new System.Drawing.Point(32, 41);
            this.cmbBodegaD.MaximumSize = new System.Drawing.Size(200, 0);
            this.cmbBodegaD.MinimumSize = new System.Drawing.Size(100, 0);
            this.cmbBodegaD.Name = "cmbBodegaD";
            this.cmbBodegaD.Size = new System.Drawing.Size(200, 21);
            this.cmbBodegaD.TabIndex = 1;
            this.cmbBodegaD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBodegaD_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPosicion);
            this.groupBox1.Controls.Add(this.txtCodPallet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbBodegaD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de envío";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posición";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 21);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Pallet";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bodega de Destino";
            // 
            // dgvPallet
            // 
            this.dgvPallet.AllowUserToAddRows = false;
            this.dgvPallet.AllowUserToDeleteRows = false;
            this.dgvPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPallet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPallet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoPallet,
            this.clmProducto,
            this.clmNetWeigth,
            this.clmGrossWeigth,
            this.clmPosicion,
            this.clmBodOrg,
            this.clmBodDest,
            this.clmFechaCreacion,
            this.clmEliminar});
            this.dgvPallet.Location = new System.Drawing.Point(8, 87);
            this.dgvPallet.Name = "dgvPallet";
            this.dgvPallet.ReadOnly = true;
            this.dgvPallet.Size = new System.Drawing.Size(800, 192);
            this.dgvPallet.TabIndex = 1;
            this.dgvPallet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPallet_CellContentClick);
            // 
            // clmCodigoPallet
            // 
            this.clmCodigoPallet.HeaderText = "Código";
            this.clmCodigoPallet.Name = "clmCodigoPallet";
            this.clmCodigoPallet.ReadOnly = true;
            this.clmCodigoPallet.Width = 65;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            this.clmProducto.Width = 75;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.ReadOnly = true;
            this.clmNetWeigth.Width = 76;
            // 
            // clmGrossWeigth
            // 
            this.clmGrossWeigth.HeaderText = "Peso Bruto";
            this.clmGrossWeigth.Name = "clmGrossWeigth";
            this.clmGrossWeigth.ReadOnly = true;
            this.clmGrossWeigth.Width = 78;
            // 
            // clmPosicion
            // 
            this.clmPosicion.HeaderText = "Posición";
            this.clmPosicion.Name = "clmPosicion";
            this.clmPosicion.ReadOnly = true;
            this.clmPosicion.Width = 72;
            // 
            // clmBodOrg
            // 
            this.clmBodOrg.HeaderText = "Bodega Origen";
            this.clmBodOrg.Name = "clmBodOrg";
            this.clmBodOrg.ReadOnly = true;
            this.clmBodOrg.Width = 95;
            // 
            // clmBodDest
            // 
            this.clmBodDest.HeaderText = "Bodega Destino";
            this.clmBodDest.Name = "clmBodDest";
            this.clmBodDest.ReadOnly = true;
            this.clmBodDest.Width = 99;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.HeaderText = "Fecha";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 62;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar";
            this.clmEliminar.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmEliminar.Width = 68;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesar.AutoSize = true;
            this.btnProcesar.Location = new System.Drawing.Point(705, 293);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(103, 39);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPesos);
            this.groupBox2.Location = new System.Drawing.Point(205, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 56);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kilos a mover";
            // 
            // txtPesos
            // 
            this.txtPesos.Location = new System.Drawing.Point(55, 19);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(121, 20);
            this.txtPesos.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(182, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kg";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtCantPallet);
            this.groupBox3.Location = new System.Drawing.Point(8, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pallets a Mover";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cantidad";
            // 
            // txtCantPallet
            // 
            this.txtCantPallet.Location = new System.Drawing.Point(69, 19);
            this.txtCantPallet.Name = "txtCantPallet";
            this.txtCantPallet.Size = new System.Drawing.Size(107, 20);
            this.txtCantPallet.TabIndex = 0;
            // 
            // frmPalletMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(817, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.dgvPallet);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletMovement";
            this.Text = "Movimiento de Pallet entre Bodegas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
        private System.Windows.Forms.DataGridView dgvPallet;
        private System.Windows.Forms.TextBox txtCodPallet;
        private System.Windows.Forms.TextBox txtPosicion;
        private System.Windows.Forms.ComboBox cmbBodegaD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantPallet;
    }
}