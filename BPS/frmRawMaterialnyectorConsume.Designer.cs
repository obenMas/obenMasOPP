namespace BPS
{
    partial class frmRawMaterialnyectorConsume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialnyectorConsume));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKilosCons = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodPallet = new System.Windows.Forms.TextBox();
            this.dgvConsIny = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.txtCantPallet = new System.Windows.Forms.TextBox();
            this.btnConsumir = new System.Windows.Forms.Button();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPesoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmConsWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsIny)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKilosCons);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodPallet);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Pallet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kilos a Consumir";
            // 
            // txtKilosCons
            // 
            this.txtKilosCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilosCons.Location = new System.Drawing.Point(454, 24);
            this.txtKilosCons.Name = "txtKilosCons";
            this.txtKilosCons.Size = new System.Drawing.Size(128, 22);
            this.txtKilosCons.TabIndex = 2;
            this.txtKilosCons.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKilosCons_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código Pallet";
            // 
            // txtCodPallet
            // 
            this.txtCodPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPallet.Location = new System.Drawing.Point(103, 24);
            this.txtCodPallet.Name = "txtCodPallet";
            this.txtCodPallet.Size = new System.Drawing.Size(167, 22);
            this.txtCodPallet.TabIndex = 0;
            this.txtCodPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodPallet_KeyDown);
            // 
            // dgvConsIny
            // 
            this.dgvConsIny.AllowUserToAddRows = false;
            this.dgvConsIny.AllowUserToDeleteRows = false;
            this.dgvConsIny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsIny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsIny.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodigo,
            this.clmLote,
            this.clmRawMaterial,
            this.clmPesoFinal,
            this.clmConsWeigth,
            this.clmEliminar});
            this.dgvConsIny.Location = new System.Drawing.Point(3, 75);
            this.dgvConsIny.Name = "dgvConsIny";
            this.dgvConsIny.ReadOnly = true;
            this.dgvConsIny.Size = new System.Drawing.Size(625, 244);
            this.dgvConsIny.TabIndex = 1;
            this.dgvConsIny.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsIny_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtKilos);
            this.groupBox2.Controls.Add(this.txtCantPallet);
            this.groupBox2.Location = new System.Drawing.Point(3, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Consumo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cant. Kilos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cant. Pallet";
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(276, 19);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 1;
            // 
            // txtCantPallet
            // 
            this.txtCantPallet.Location = new System.Drawing.Point(85, 19);
            this.txtCantPallet.Name = "txtCantPallet";
            this.txtCantPallet.Size = new System.Drawing.Size(100, 20);
            this.txtCantPallet.TabIndex = 0;
            // 
            // btnConsumir
            // 
            this.btnConsumir.Image = global::BPS.Properties.Resources.funnel;
            this.btnConsumir.Location = new System.Drawing.Point(520, 330);
            this.btnConsumir.Name = "btnConsumir";
            this.btnConsumir.Size = new System.Drawing.Size(108, 43);
            this.btnConsumir.TabIndex = 4;
            this.btnConsumir.Text = "Consumir";
            this.btnConsumir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsumir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumir.UseVisualStyleBackColor = true;
            this.btnConsumir.Click += new System.EventHandler(this.btnConsumir_Click);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 68;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código Pallet";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 94;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 53;
            // 
            // clmRawMaterial
            // 
            this.clmRawMaterial.HeaderText = "Materia Prima";
            this.clmRawMaterial.Name = "clmRawMaterial";
            this.clmRawMaterial.ReadOnly = true;
            this.clmRawMaterial.Width = 96;
            // 
            // clmPesoFinal
            // 
            this.clmPesoFinal.HeaderText = "Peso Final";
            this.clmPesoFinal.Name = "clmPesoFinal";
            this.clmPesoFinal.ReadOnly = true;
            this.clmPesoFinal.Width = 81;
            // 
            // clmConsWeigth
            // 
            this.clmConsWeigth.HeaderText = "Peso a Consumir";
            this.clmConsWeigth.Name = "clmConsWeigth";
            this.clmConsWeigth.ReadOnly = true;
            this.clmConsWeigth.Width = 102;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "Eliminar";
            this.clmEliminar.Image = global::BPS.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Width = 49;
            // 
            // frmRawMaterialnyectorConsume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 377);
            this.Controls.Add(this.btnConsumir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvConsIny);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialnyectorConsume";
            this.Text = "Consumo de Inyector";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsIny)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKilosCons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodPallet;
        private System.Windows.Forms.DataGridView dgvConsIny;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.TextBox txtCantPallet;
        private System.Windows.Forms.Button btnConsumir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPesoFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmConsWeigth;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
    }
}