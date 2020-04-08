namespace BPS
{
    partial class frmNewPreShippingList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmbFiltroCreacion = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbFiltroPlanta = new System.Windows.Forms.ComboBox();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltroDespacho = new System.Windows.Forms.ComboBox();
            this.cmbFiltroEstado = new System.Windows.Forms.ComboBox();
            this.cmbFiltroUsuario = new System.Windows.Forms.ComboBox();
            this.cmbFiltroCliente = new System.Windows.Forms.ComboBox();
            this.cmbFiltroNumero = new System.Windows.Forms.ComboBox();
            this.codsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preparar = new System.Windows.Forms.DataGridViewImageColumn();
            this.listaemp = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmAproved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codsec,
            this.creado,
            this.numero,
            this.cliente,
            this.usuario,
            this.unidades,
            this.kilos,
            this.clmValor,
            this.planta,
            this.estado,
            this.programado,
            this.remito,
            this.preparar,
            this.listaemp,
            this.clmAproved});
            this.dgv.Location = new System.Drawing.Point(12, 81);
            this.dgv.Name = "dgv";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.Size = new System.Drawing.Size(1113, 416);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEndEdit);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BPS.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // cmbFiltroCreacion
            // 
            this.cmbFiltroCreacion.FormattingEnabled = true;
            this.cmbFiltroCreacion.Location = new System.Drawing.Point(16, 36);
            this.cmbFiltroCreacion.Name = "cmbFiltroCreacion";
            this.cmbFiltroCreacion.Size = new System.Drawing.Size(103, 21);
            this.cmbFiltroCreacion.TabIndex = 1;
            this.cmbFiltroCreacion.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCreacion_SelectedIndexChanged);
            this.cmbFiltroCreacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroCreacion_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbFiltroPlanta);
            this.groupBox1.Controls.Add(this.txtTot);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtObj);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFiltroDespacho);
            this.groupBox1.Controls.Add(this.cmbFiltroEstado);
            this.groupBox1.Controls.Add(this.cmbFiltroUsuario);
            this.groupBox1.Controls.Add(this.cmbFiltroCliente);
            this.groupBox1.Controls.Add(this.cmbFiltroNumero);
            this.groupBox1.Controls.Add(this.cmbFiltroCreacion);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1113, 71);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Planta";
            // 
            // cmbFiltroPlanta
            // 
            this.cmbFiltroPlanta.FormattingEnabled = true;
            this.cmbFiltroPlanta.Location = new System.Drawing.Point(550, 36);
            this.cmbFiltroPlanta.Name = "cmbFiltroPlanta";
            this.cmbFiltroPlanta.Size = new System.Drawing.Size(129, 21);
            this.cmbFiltroPlanta.TabIndex = 17;
            this.cmbFiltroPlanta.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroPlanta_SelectedIndexChanged);
            this.cmbFiltroPlanta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroPlanta_KeyDown);
            // 
            // txtTot
            // 
            this.txtTot.Enabled = false;
            this.txtTot.Location = new System.Drawing.Point(1002, 36);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(38, 20);
            this.txtTot.TabIndex = 16;
            this.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(983, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "de";
            // 
            // txtObj
            // 
            this.txtObj.Location = new System.Drawing.Point(945, 36);
            this.txtObj.Name = "txtObj";
            this.txtObj.Size = new System.Drawing.Size(38, 20);
            this.txtObj.TabIndex = 14;
            this.txtObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtObj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtObj_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(966, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mostrando:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(809, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha despacho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha creación";
            // 
            // cmbFiltroDespacho
            // 
            this.cmbFiltroDespacho.FormattingEnabled = true;
            this.cmbFiltroDespacho.Location = new System.Drawing.Point(812, 36);
            this.cmbFiltroDespacho.Name = "cmbFiltroDespacho";
            this.cmbFiltroDespacho.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroDespacho.TabIndex = 6;
            this.cmbFiltroDespacho.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroDespacho_SelectedIndexChanged);
            this.cmbFiltroDespacho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroDespacho_KeyDown);
            // 
            // cmbFiltroEstado
            // 
            this.cmbFiltroEstado.FormattingEnabled = true;
            this.cmbFiltroEstado.Location = new System.Drawing.Point(685, 36);
            this.cmbFiltroEstado.Name = "cmbFiltroEstado";
            this.cmbFiltroEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroEstado.TabIndex = 5;
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);
            this.cmbFiltroEstado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroEstado_KeyDown);
            // 
            // cmbFiltroUsuario
            // 
            this.cmbFiltroUsuario.FormattingEnabled = true;
            this.cmbFiltroUsuario.Location = new System.Drawing.Point(423, 36);
            this.cmbFiltroUsuario.Name = "cmbFiltroUsuario";
            this.cmbFiltroUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltroUsuario.TabIndex = 4;
            this.cmbFiltroUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroUsuario_SelectedIndexChanged);
            this.cmbFiltroUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroUsuario_KeyDown);
            // 
            // cmbFiltroCliente
            // 
            this.cmbFiltroCliente.FormattingEnabled = true;
            this.cmbFiltroCliente.Location = new System.Drawing.Point(218, 36);
            this.cmbFiltroCliente.Name = "cmbFiltroCliente";
            this.cmbFiltroCliente.Size = new System.Drawing.Size(198, 21);
            this.cmbFiltroCliente.TabIndex = 3;
            this.cmbFiltroCliente.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCliente_SelectedIndexChanged);
            this.cmbFiltroCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroCliente_KeyDown);
            // 
            // cmbFiltroNumero
            // 
            this.cmbFiltroNumero.FormattingEnabled = true;
            this.cmbFiltroNumero.Location = new System.Drawing.Point(125, 36);
            this.cmbFiltroNumero.Name = "cmbFiltroNumero";
            this.cmbFiltroNumero.Size = new System.Drawing.Size(87, 21);
            this.cmbFiltroNumero.TabIndex = 2;
            this.cmbFiltroNumero.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroNumero_SelectedIndexChanged);
            this.cmbFiltroNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFiltroNumero_KeyDown);
            // 
            // codsec
            // 
            this.codsec.HeaderText = "codsec";
            this.codsec.Name = "codsec";
            this.codsec.ReadOnly = true;
            this.codsec.Visible = false;
            // 
            // creado
            // 
            this.creado.HeaderText = "Fecha creación";
            this.creado.Name = "creado";
            this.creado.ReadOnly = true;
            this.creado.Width = 80;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 80;
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 200;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 80;
            // 
            // unidades
            // 
            this.unidades.HeaderText = "Cantidad [Un]";
            this.unidades.Name = "unidades";
            this.unidades.ReadOnly = true;
            this.unidades.Width = 70;
            // 
            // kilos
            // 
            this.kilos.HeaderText = "Cantidad [Kg]";
            this.kilos.Name = "kilos";
            this.kilos.ReadOnly = true;
            this.kilos.Width = 70;
            // 
            // clmValor
            // 
            this.clmValor.HeaderText = "Valor Total [USD]";
            this.clmValor.Name = "clmValor";
            this.clmValor.ReadOnly = true;
            this.clmValor.Visible = false;
            // 
            // planta
            // 
            this.planta.HeaderText = "Planta";
            this.planta.Name = "planta";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // programado
            // 
            this.programado.HeaderText = "Fecha despacho";
            this.programado.Name = "programado";
            this.programado.ReadOnly = true;
            this.programado.Width = 80;
            // 
            // remito
            // 
            this.remito.HeaderText = "Remito";
            this.remito.Name = "remito";
            this.remito.ReadOnly = true;
            this.remito.Width = 70;
            // 
            // preparar
            // 
            this.preparar.HeaderText = "";
            this.preparar.Image = global::BPS.Properties.Resources.printer;
            this.preparar.Name = "preparar";
            this.preparar.ReadOnly = true;
            this.preparar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.preparar.ToolTipText = "Imprimir pre-despacho";
            this.preparar.Width = 30;
            // 
            // listaemp
            // 
            this.listaemp.HeaderText = "";
            this.listaemp.Image = global::BPS.Properties.Resources.clipboard_text;
            this.listaemp.Name = "listaemp";
            this.listaemp.ToolTipText = "Imprimir lista de empaque";
            this.listaemp.Width = 30;
            // 
            // clmAproved
            // 
            this.clmAproved.HeaderText = "Aprobado";
            this.clmAproved.Name = "clmAproved";
            this.clmAproved.ReadOnly = true;
            this.clmAproved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmAproved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmAproved.Width = 60;
            // 
            // frmNewPreShippingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv);
            this.Name = "frmNewPreShippingList";
            this.ShowIcon = false;
            this.Text = "Listado de pre-despachos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox cmbFiltroCreacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltroDespacho;
        private System.Windows.Forms.ComboBox cmbFiltroEstado;
        private System.Windows.Forms.ComboBox cmbFiltroUsuario;
        private System.Windows.Forms.ComboBox cmbFiltroCliente;
        private System.Windows.Forms.ComboBox cmbFiltroNumero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbFiltroPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn creado;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn planta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn programado;
        private System.Windows.Forms.DataGridViewTextBoxColumn remito;
        private System.Windows.Forms.DataGridViewImageColumn preparar;
        private System.Windows.Forms.DataGridViewImageColumn listaemp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmAproved;
    }
}