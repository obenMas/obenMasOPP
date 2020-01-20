namespace BPS.Lite
{
    partial class frmInterCellarMovement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInterCellarMovement));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSwapMP = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtKgaMover = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkMovParcial = new System.Windows.Forms.CheckBox();
            this.pnlKgaMover = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotPeso = new System.Windows.Forms.TextBox();
            this.txtTotPallet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapMP)).BeginInit();
            this.pnlKgaMover.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Pallet";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(133, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(151, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Pallet";
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(138, 39);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(146, 21);
            this.cmbDestino.TabIndex = 3;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            this.cmbDestino.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDestino_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bodega Destino";
            // 
            // dgvSwapMP
            // 
            this.dgvSwapMP.AllowUserToAddRows = false;
            this.dgvSwapMP.AllowUserToDeleteRows = false;
            this.dgvSwapMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwapMP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmTipo,
            this.clmPeso,
            this.clmLote,
            this.clmOrigen,
            this.clmDestino,
            this.clmFecha,
            this.clmEliminar});
            this.dgvSwapMP.Location = new System.Drawing.Point(12, 96);
            this.dgvSwapMP.Name = "dgvSwapMP";
            this.dgvSwapMP.ReadOnly = true;
            this.dgvSwapMP.Size = new System.Drawing.Size(1123, 271);
            this.dgvSwapMP.TabIndex = 6;
            this.dgvSwapMP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSwapMP_CellContentClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 130;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "Tipo Material";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            this.clmTipo.Width = 190;
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
            // clmOrigen
            // 
            this.clmOrigen.HeaderText = "Bodega Origen";
            this.clmOrigen.Name = "clmOrigen";
            this.clmOrigen.ReadOnly = true;
            this.clmOrigen.Width = 110;
            // 
            // clmDestino
            // 
            this.clmDestino.HeaderText = "Bodega Destino";
            this.clmDestino.Name = "clmDestino";
            this.clmDestino.ReadOnly = true;
            this.clmDestino.Width = 110;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 110;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar";
            this.clmEliminar.Image = global::BPS.Lite.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Width = 80;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(974, 385);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(161, 72);
            this.btnProcesar.TabIndex = 7;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtKgaMover
            // 
            this.txtKgaMover.Location = new System.Drawing.Point(92, 29);
            this.txtKgaMover.Name = "txtKgaMover";
            this.txtKgaMover.Size = new System.Drawing.Size(152, 20);
            this.txtKgaMover.TabIndex = 6;
            this.txtKgaMover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKgaMover_KeyPress);
            this.txtKgaMover.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKgaMover_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilos a mover";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Kg";
            // 
            // chkMovParcial
            // 
            this.chkMovParcial.AutoSize = true;
            this.chkMovParcial.Enabled = false;
            this.chkMovParcial.Location = new System.Drawing.Point(341, 4);
            this.chkMovParcial.Name = "chkMovParcial";
            this.chkMovParcial.Size = new System.Drawing.Size(115, 17);
            this.chkMovParcial.TabIndex = 8;
            this.chkMovParcial.Text = "Movimiento Parcial";
            this.chkMovParcial.UseVisualStyleBackColor = true;
            this.chkMovParcial.CheckedChanged += new System.EventHandler(this.chkMovParcial_CheckedChanged);
            // 
            // pnlKgaMover
            // 
            this.pnlKgaMover.Controls.Add(this.label4);
            this.pnlKgaMover.Controls.Add(this.label5);
            this.pnlKgaMover.Controls.Add(this.txtKgaMover);
            this.pnlKgaMover.Enabled = false;
            this.pnlKgaMover.Location = new System.Drawing.Point(341, 19);
            this.pnlKgaMover.Name = "pnlKgaMover";
            this.pnlKgaMover.Size = new System.Drawing.Size(277, 71);
            this.pnlKgaMover.TabIndex = 9;
            this.pnlKgaMover.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDestino);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 86);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bodega Destino";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtTotPeso);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(328, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 86);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Kilos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotPallet);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(579, 373);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 86);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total Pallet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Cantidad";
            // 
            // txtTotPeso
            // 
            this.txtTotPeso.Location = new System.Drawing.Point(72, 39);
            this.txtTotPeso.Name = "txtTotPeso";
            this.txtTotPeso.Size = new System.Drawing.Size(140, 20);
            this.txtTotPeso.TabIndex = 3;
            // 
            // txtTotPallet
            // 
            this.txtTotPallet.Location = new System.Drawing.Point(72, 39);
            this.txtTotPallet.Name = "txtTotPallet";
            this.txtTotPallet.Size = new System.Drawing.Size(140, 20);
            this.txtTotPallet.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Kg";
            // 
            // frmInterCellarMovement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1147, 466);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chkMovParcial);
            this.Controls.Add(this.pnlKgaMover);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.dgvSwapMP);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInterCellarMovement";
            this.Text = "Movimiento de Materias Primas entre bodegas";
            this.Load += new System.EventHandler(this.frmInterCellarMovement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapMP)).EndInit();
            this.pnlKgaMover.ResumeLayout(false);
            this.pnlKgaMover.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSwapMP;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtKgaMover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkMovParcial;
        private System.Windows.Forms.GroupBox pnlKgaMover;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTotPallet;
        private System.Windows.Forms.Label label6;
    }
}