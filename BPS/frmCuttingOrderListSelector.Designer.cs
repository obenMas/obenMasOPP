namespace BPS
{
    partial class frmCuttingOrderListSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrderListSelector));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCuttingOrderDetail = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOC = new System.Windows.Forms.TextBox();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPosiciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRepeticiones = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaquina = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCorteSecundario = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCodPelicula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.clmCuttingOrderDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCuttingOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkSalesOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrderDetail)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaquina);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtOC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1215, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenes de corte";
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(727, 13);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(69, 31);
            this.btnUltimo.TabIndex = 5;
            this.btnUltimo.Text = "Ultimo";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = global::BPS.Properties.Resources.arrow_right;
            this.btnSiguiente.Location = new System.Drawing.Point(690, 13);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(31, 31);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.Location = new System.Drawing.Point(454, 13);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(75, 31);
            this.btnPrimero.TabIndex = 3;
            this.btnPrimero.Text = "Primero";
            this.btnPrimero.UseVisualStyleBackColor = true;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = global::BPS.Properties.Resources.arrow_left;
            this.btnAnterior.Location = new System.Drawing.Point(535, 13);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(31, 31);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(572, 19);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(112, 20);
            this.txtNum.TabIndex = 1;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
            this.txtNum.Validating += new System.ComponentModel.CancelEventHandler(this.txtNum_Validating);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCuttingOrderDetail);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1215, 260);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle de orden de corte";
            // 
            // dgvCuttingOrderDetail
            // 
            this.dgvCuttingOrderDetail.AllowUserToAddRows = false;
            this.dgvCuttingOrderDetail.AllowUserToDeleteRows = false;
            this.dgvCuttingOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuttingOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCuttingOrderDetailCodsec,
            this.clmfkCuttingOrder,
            this.clmfkSalesOrderDetail,
            this.clmfkSalesOrder,
            this.clmProducto,
            this.clmCodProducto,
            this.clmAncho,
            this.clmPosicion,
            this.clmCliente});
            this.dgvCuttingOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuttingOrderDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvCuttingOrderDetail.Name = "dgvCuttingOrderDetail";
            this.dgvCuttingOrderDetail.ReadOnly = true;
            this.dgvCuttingOrderDetail.Size = new System.Drawing.Size(1209, 241);
            this.dgvCuttingOrderDetail.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnSiguiente);
            this.groupBox3.Controls.Add(this.btnUltimo);
            this.groupBox3.Controls.Add(this.txtNum);
            this.groupBox3.Controls.Add(this.btnAnterior);
            this.groupBox3.Controls.Add(this.btnPrimero);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 535);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1215, 44);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Orden de corte";
            // 
            // txtOC
            // 
            this.txtOC.Location = new System.Drawing.Point(131, 36);
            this.txtOC.Name = "txtOC";
            this.txtOC.ReadOnly = true;
            this.txtOC.Size = new System.Drawing.Size(221, 20);
            this.txtOC.TabIndex = 8;
            this.txtOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(760, 19);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.ReadOnly = true;
            this.txtPelicula.Size = new System.Drawing.Size(160, 20);
            this.txtPelicula.TabIndex = 10;
            this.txtPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(651, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pelicula";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(122, 55);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(260, 20);
            this.txtProducto.TabIndex = 12;
            this.txtProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Producto";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(485, 18);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.ReadOnly = true;
            this.txtEstado.Size = new System.Drawing.Size(160, 20);
            this.txtEstado.TabIndex = 14;
            this.txtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(409, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estado";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.txtCodPelicula);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtNotas);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtFecha);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtRepeticiones);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtPosiciones);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtEstado);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtPelicula);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1209, 181);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // txtPosiciones
            // 
            this.txtPosiciones.Location = new System.Drawing.Point(485, 58);
            this.txtPosiciones.Name = "txtPosiciones";
            this.txtPosiciones.ReadOnly = true;
            this.txtPosiciones.Size = new System.Drawing.Size(160, 20);
            this.txtPosiciones.TabIndex = 16;
            this.txtPosiciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Posiciones";
            // 
            // txtRepeticiones
            // 
            this.txtRepeticiones.Location = new System.Drawing.Point(760, 59);
            this.txtRepeticiones.Name = "txtRepeticiones";
            this.txtRepeticiones.ReadOnly = true;
            this.txtRepeticiones.Size = new System.Drawing.Size(160, 20);
            this.txtRepeticiones.TabIndex = 18;
            this.txtRepeticiones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(651, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Repeticiones";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(1043, 59);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(160, 20);
            this.txtFecha.TabIndex = 20;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(926, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Fecha de creación";
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(480, 97);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ReadOnly = true;
            this.txtNotas.Size = new System.Drawing.Size(723, 78);
            this.txtNotas.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(415, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Notas";
            // 
            // txtMaquina
            // 
            this.txtMaquina.Location = new System.Drawing.Point(458, 35);
            this.txtMaquina.Name = "txtMaquina";
            this.txtMaquina.ReadOnly = true;
            this.txtMaquina.Size = new System.Drawing.Size(170, 20);
            this.txtMaquina.TabIndex = 17;
            this.txtMaquina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Máquina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Corte secundario";
            // 
            // cbCorteSecundario
            // 
            this.cbCorteSecundario.AutoCheck = false;
            this.cbCorteSecundario.AutoSize = true;
            this.cbCorteSecundario.Location = new System.Drawing.Point(154, 19);
            this.cbCorteSecundario.Name = "cbCorteSecundario";
            this.cbCorteSecundario.Size = new System.Drawing.Size(15, 14);
            this.cbCorteSecundario.TabIndex = 24;
            this.cbCorteSecundario.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.78754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.78754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.424908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1221, 582);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txtCodPelicula
            // 
            this.txtCodPelicula.Location = new System.Drawing.Point(1043, 21);
            this.txtCodPelicula.Name = "txtCodPelicula";
            this.txtCodPelicula.ReadOnly = true;
            this.txtCodPelicula.Size = new System.Drawing.Size(160, 20);
            this.txtCodPelicula.TabIndex = 24;
            this.txtCodPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(931, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Codigo Pelicula";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCodProducto);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.cbCorteSecundario);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtProducto);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(6, 10);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(388, 166);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(122, 98);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.ReadOnly = true;
            this.txtCodProducto.Size = new System.Drawing.Size(260, 20);
            this.txtCodProducto.TabIndex = 26;
            this.txtCodProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Codigo Producto";
            // 
            // clmCuttingOrderDetailCodsec
            // 
            this.clmCuttingOrderDetailCodsec.HeaderText = "CuttingOrderDetailCodsec";
            this.clmCuttingOrderDetailCodsec.Name = "clmCuttingOrderDetailCodsec";
            this.clmCuttingOrderDetailCodsec.ReadOnly = true;
            this.clmCuttingOrderDetailCodsec.Visible = false;
            // 
            // clmfkCuttingOrder
            // 
            this.clmfkCuttingOrder.HeaderText = "fkCuttingOrder";
            this.clmfkCuttingOrder.Name = "clmfkCuttingOrder";
            this.clmfkCuttingOrder.ReadOnly = true;
            this.clmfkCuttingOrder.Visible = false;
            // 
            // clmfkSalesOrderDetail
            // 
            this.clmfkSalesOrderDetail.HeaderText = "fkSalesOrderDetail";
            this.clmfkSalesOrderDetail.Name = "clmfkSalesOrderDetail";
            this.clmfkSalesOrderDetail.ReadOnly = true;
            this.clmfkSalesOrderDetail.Visible = false;
            // 
            // clmfkSalesOrder
            // 
            this.clmfkSalesOrder.HeaderText = "fkSalesOrder";
            this.clmfkSalesOrder.Name = "clmfkSalesOrder";
            this.clmfkSalesOrder.ReadOnly = true;
            this.clmfkSalesOrder.Visible = false;
            // 
            // clmProducto
            // 
            this.clmProducto.HeaderText = "Producto";
            this.clmProducto.Name = "clmProducto";
            this.clmProducto.ReadOnly = true;
            this.clmProducto.Width = 250;
            // 
            // clmCodProducto
            // 
            this.clmCodProducto.HeaderText = "Codigo Producto";
            this.clmCodProducto.Name = "clmCodProducto";
            this.clmCodProducto.ReadOnly = true;
            this.clmCodProducto.Width = 150;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            // 
            // clmPosicion
            // 
            this.clmPosicion.HeaderText = "Posicion";
            this.clmPosicion.Name = "clmPosicion";
            this.clmPosicion.ReadOnly = true;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            this.clmCliente.Width = 300;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Location = new System.Drawing.Point(1173, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(36, 31);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCuttingOrderListSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1221, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrderListSelector";
            this.Text = "Lista de orden de corte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuttingOrderDetail)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCuttingOrderDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRepeticiones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPosiciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaquina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbCorteSecundario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodPelicula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCuttingOrderDetailCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCuttingOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkSalesOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.Button btnEliminar;
    }
}