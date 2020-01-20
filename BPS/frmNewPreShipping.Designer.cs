namespace BPS
{
    partial class frmNewPreShipping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewPreShipping));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkDespacho = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.dtpProgramado = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCreacion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.txtPallets = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAgregados = new System.Windows.Forms.DataGridView();
            this.codsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbPedido = new System.Windows.Forms.ComboBox();
            this.dgvParaAgregar = new System.Windows.Forms.DataGridView();
            this.Agregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.codsecpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkPalletpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Palletpa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productopa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesopa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedidopa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkDespacho);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dtpCreacion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-Despacho";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(407, 65);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(126, 20);
            this.txtEstado.TabIndex = 10;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estado:";
            // 
            // chkDespacho
            // 
            this.chkDespacho.AutoSize = true;
            this.chkDespacho.Location = new System.Drawing.Point(576, 70);
            this.chkDespacho.Name = "chkDespacho";
            this.chkDespacho.Size = new System.Drawing.Size(124, 17);
            this.chkDespacho.TabIndex = 0;
            this.chkDespacho.Text = "Programar despacho";
            this.chkDespacho.UseVisualStyleBackColor = true;
            this.chkDespacho.CheckedChanged += new System.EventHandler(this.chkDespacho_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnProgramar);
            this.groupBox4.Controls.Add(this.dtpProgramado);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(706, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 45);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // btnProgramar
            // 
            this.btnProgramar.Enabled = false;
            this.btnProgramar.Image = global::BPS.Properties.Resources.disk;
            this.btnProgramar.Location = new System.Drawing.Point(326, 14);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(39, 25);
            this.btnProgramar.TabIndex = 2;
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // dtpProgramado
            // 
            this.dtpProgramado.Enabled = false;
            this.dtpProgramado.Location = new System.Drawing.Point(105, 16);
            this.dtpProgramado.Name = "dtpProgramado";
            this.dtpProgramado.Size = new System.Drawing.Size(212, 20);
            this.dtpProgramado.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(9, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fecha despacho:";
            // 
            // dtpCreacion
            // 
            this.dtpCreacion.Enabled = false;
            this.dtpCreacion.Location = new System.Drawing.Point(124, 65);
            this.dtpCreacion.Name = "dtpCreacion";
            this.dtpCreacion.Size = new System.Drawing.Size(200, 20);
            this.dtpCreacion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha de creación:";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(910, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(158, 20);
            this.txtUser.TabIndex = 5;
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(842, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Creado por:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(260, 25);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(530, 20);
            this.txtCliente.TabIndex = 3;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(69, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtKilos);
            this.groupBox2.Controls.Add(this.txtPallets);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dgvAgregados);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pallets agregados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Pallets";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kg";
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(333, 26);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(100, 20);
            this.txtKilos.TabIndex = 3;
            this.txtKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPallets
            // 
            this.txtPallets.Location = new System.Drawing.Point(151, 26);
            this.txtPallets.Name = "txtPallets";
            this.txtPallets.Size = new System.Drawing.Size(91, 20);
            this.txtPallets.TabIndex = 2;
            this.txtPallets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Totales:";
            // 
            // dgvAgregados
            // 
            this.dgvAgregados.AllowUserToAddRows = false;
            this.dgvAgregados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAgregados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAgregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codsec,
            this.fkPallet,
            this.Pallet,
            this.Producto,
            this.Peso,
            this.Pedido,
            this.Quitar});
            this.dgvAgregados.Location = new System.Drawing.Point(6, 63);
            this.dgvAgregados.Name = "dgvAgregados";
            this.dgvAgregados.ReadOnly = true;
            this.dgvAgregados.Size = new System.Drawing.Size(523, 345);
            this.dgvAgregados.TabIndex = 0;
            this.dgvAgregados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgregados_CellClick);
            // 
            // codsec
            // 
            this.codsec.HeaderText = "";
            this.codsec.Name = "codsec";
            this.codsec.ReadOnly = true;
            this.codsec.Visible = false;
            // 
            // fkPallet
            // 
            this.fkPallet.HeaderText = "";
            this.fkPallet.Name = "fkPallet";
            this.fkPallet.ReadOnly = true;
            this.fkPallet.Visible = false;
            // 
            // Pallet
            // 
            this.Pallet.HeaderText = "Pallet";
            this.Pallet.Name = "Pallet";
            this.Pallet.ReadOnly = true;
            this.Pallet.Width = 140;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 130;
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso Neto [Kg]";
            this.Peso.Name = "Peso";
            this.Peso.ReadOnly = true;
            this.Peso.Width = 80;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            this.Pedido.Width = 70;
            // 
            // Quitar
            // 
            this.Quitar.HeaderText = "";
            this.Quitar.Image = global::BPS.Properties.Resources.arrow_right;
            this.Quitar.Name = "Quitar";
            this.Quitar.ReadOnly = true;
            this.Quitar.Width = 30;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cmbPedido);
            this.groupBox3.Controls.Add(this.dgvParaAgregar);
            this.groupBox3.Location = new System.Drawing.Point(565, 121);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 414);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pallets para agregar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Pedido:";
            // 
            // cmbPedido
            // 
            this.cmbPedido.FormattingEnabled = true;
            this.cmbPedido.Location = new System.Drawing.Point(69, 26);
            this.cmbPedido.Name = "cmbPedido";
            this.cmbPedido.Size = new System.Drawing.Size(120, 21);
            this.cmbPedido.TabIndex = 2;
            this.cmbPedido.SelectedIndexChanged += new System.EventHandler(this.cmbPedido_SelectedIndexChanged);
            // 
            // dgvParaAgregar
            // 
            this.dgvParaAgregar.AllowUserToAddRows = false;
            this.dgvParaAgregar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvParaAgregar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvParaAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParaAgregar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Agregar,
            this.codsecpa,
            this.fkPalletpa,
            this.Palletpa,
            this.Productopa,
            this.Pesopa,
            this.Pedidopa});
            this.dgvParaAgregar.Location = new System.Drawing.Point(6, 63);
            this.dgvParaAgregar.Name = "dgvParaAgregar";
            this.dgvParaAgregar.ReadOnly = true;
            this.dgvParaAgregar.Size = new System.Drawing.Size(523, 345);
            this.dgvParaAgregar.TabIndex = 1;
            this.dgvParaAgregar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParaAgregar_CellClick);
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "";
            this.Agregar.Image = global::BPS.Properties.Resources.arrow_left;
            this.Agregar.Name = "Agregar";
            this.Agregar.ReadOnly = true;
            this.Agregar.Width = 30;
            // 
            // codsecpa
            // 
            this.codsecpa.HeaderText = "";
            this.codsecpa.Name = "codsecpa";
            this.codsecpa.ReadOnly = true;
            this.codsecpa.Visible = false;
            // 
            // fkPalletpa
            // 
            this.fkPalletpa.HeaderText = "";
            this.fkPalletpa.Name = "fkPalletpa";
            this.fkPalletpa.ReadOnly = true;
            this.fkPalletpa.Visible = false;
            // 
            // Palletpa
            // 
            this.Palletpa.HeaderText = "Pallet";
            this.Palletpa.Name = "Palletpa";
            this.Palletpa.ReadOnly = true;
            this.Palletpa.Width = 140;
            // 
            // Productopa
            // 
            this.Productopa.HeaderText = "Producto";
            this.Productopa.Name = "Productopa";
            this.Productopa.ReadOnly = true;
            this.Productopa.Width = 130;
            // 
            // Pesopa
            // 
            this.Pesopa.HeaderText = "Peso Neto [Kg]";
            this.Pesopa.Name = "Pesopa";
            this.Pesopa.ReadOnly = true;
            this.Pesopa.Width = 80;
            // 
            // Pedidopa
            // 
            this.Pedidopa.HeaderText = "Pedido";
            this.Pedidopa.Name = "Pedidopa";
            this.Pedidopa.ReadOnly = true;
            this.Pedidopa.Width = 70;
            // 
            // frmNewPreShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewPreShipping";
            this.Text = "Pre-despacho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParaAgregar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDespacho;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpCreacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAgregados;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpProgramado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.TextBox txtPallets;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewImageColumn Quitar;
        private System.Windows.Forms.DataGridView dgvParaAgregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbPedido;
        private System.Windows.Forms.DataGridViewImageColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsecpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkPalletpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palletpa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productopa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesopa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedidopa;
    }
}