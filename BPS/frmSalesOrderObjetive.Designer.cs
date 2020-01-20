namespace BPS
{
    partial class frmSalesOrderObjetive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderObjetive));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEjecutiva = new System.Windows.Forms.ComboBox();
            this.dgvSaleOrderObj = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEjecutiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFkEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGuardar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleOrderObj)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbEjecutiva);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(445, 22);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(144, 21);
            this.cmbCliente.TabIndex = 2;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCliente_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ejecutiva";
            // 
            // cmbEjecutiva
            // 
            this.cmbEjecutiva.FormattingEnabled = true;
            this.cmbEjecutiva.Location = new System.Drawing.Point(143, 22);
            this.cmbEjecutiva.Name = "cmbEjecutiva";
            this.cmbEjecutiva.Size = new System.Drawing.Size(144, 21);
            this.cmbEjecutiva.TabIndex = 0;
            this.cmbEjecutiva.SelectedIndexChanged += new System.EventHandler(this.cmbEjecutiva_SelectedIndexChanged);
            this.cmbEjecutiva.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEjecutiva_KeyDown);
            // 
            // dgvSaleOrderObj
            // 
            this.dgvSaleOrderObj.AllowUserToAddRows = false;
            this.dgvSaleOrderObj.AllowUserToDeleteRows = false;
            this.dgvSaleOrderObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleOrderObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmEjecutiva,
            this.clmCliente,
            this.clmObjetivo,
            this.clmFkEntity,
            this.clmGuardar});
            this.dgvSaleOrderObj.Location = new System.Drawing.Point(12, 76);
            this.dgvSaleOrderObj.Name = "dgvSaleOrderObj";
            this.dgvSaleOrderObj.Size = new System.Drawing.Size(741, 286);
            this.dgvSaleOrderObj.TabIndex = 4;
            this.dgvSaleOrderObj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleOrderObj_CellContentClick);
            this.dgvSaleOrderObj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvSaleOrderObj_KeyPress);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmEjecutiva
            // 
            this.clmEjecutiva.HeaderText = "Ejecutiva";
            this.clmEjecutiva.Name = "clmEjecutiva";
            this.clmEjecutiva.Width = 150;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.Width = 250;
            // 
            // clmObjetivo
            // 
            this.clmObjetivo.HeaderText = "Objetivo";
            this.clmObjetivo.Name = "clmObjetivo";
            this.clmObjetivo.Width = 60;
            // 
            // clmFkEntity
            // 
            this.clmFkEntity.HeaderText = "fkEntity";
            this.clmFkEntity.Name = "clmFkEntity";
            this.clmFkEntity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmFkEntity.Visible = false;
            // 
            // clmGuardar
            // 
            this.clmGuardar.HeaderText = "Guardar";
            this.clmGuardar.Image = global::BPS.Properties.Resources.disk;
            this.clmGuardar.Name = "clmGuardar";
            // 
            // frmSalesOrderObjetive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 375);
            this.Controls.Add(this.dgvSaleOrderObj);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderObjetive";
            this.Text = "Objetivos de ordenes de compra";
            this.Load += new System.EventHandler(this.frmSalesOrderObjetive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleOrderObj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEjecutiva;
        private System.Windows.Forms.DataGridView dgvSaleOrderObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEjecutiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFkEntity;
        private System.Windows.Forms.DataGridViewImageColumn clmGuardar;
    }
}