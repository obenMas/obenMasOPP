namespace BPS.Lite
{
    partial class frmNewMetallizedCoils
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewMetallizedCoils));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProdOrders = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmActiveOrder = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantMBob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantMKilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdd = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmVer = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.btnMetalizar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCantBob = new System.Windows.Forms.Label();
            this.lblCantBobinas = new System.Windows.Forms.Label();
            this.lblMetalizado = new System.Windows.Forms.Label();
            this.lblMetalizadoKg = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lblCantKilos = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lblAncho = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblFDest = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFOrg = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdOrders)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdOrders);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Ordenes";
            // 
            // dgvProdOrders
            // 
            this.dgvProdOrders.AllowUserToAddRows = false;
            this.dgvProdOrders.AllowUserToDeleteRows = false;
            this.dgvProdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmActiveOrder,
            this.clmLote,
            this.clmMachine,
            this.clmMachineCodsec,
            this.clmFilmOrg,
            this.clmFilmDest,
            this.clmAncho,
            this.clmStatus,
            this.clmQuantity,
            this.clmCantMBob,
            this.clmCantMKilos,
            this.clmFechaCreacion,
            this.clmObservation,
            this.clmAdd,
            this.clmVer});
            this.dgvProdOrders.Location = new System.Drawing.Point(4, 16);
            this.dgvProdOrders.Name = "dgvProdOrders";
            this.dgvProdOrders.ReadOnly = true;
            this.dgvProdOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProdOrders.Size = new System.Drawing.Size(1000, 304);
            this.dgvProdOrders.TabIndex = 0;
            this.dgvProdOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdOrders_CellContentClick);
            this.dgvProdOrders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdOrders_CellContentDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 67;
            // 
            // clmActiveOrder
            // 
            this.clmActiveOrder.HeaderText = "";
            this.clmActiveOrder.Name = "clmActiveOrder";
            this.clmActiveOrder.ReadOnly = true;
            this.clmActiveOrder.Width = 5;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 53;
            // 
            // clmMachine
            // 
            this.clmMachine.HeaderText = "Maquina";
            this.clmMachine.Name = "clmMachine";
            this.clmMachine.ReadOnly = true;
            this.clmMachine.Width = 73;
            // 
            // clmMachineCodsec
            // 
            this.clmMachineCodsec.HeaderText = "MachineCodsec";
            this.clmMachineCodsec.Name = "clmMachineCodsec";
            this.clmMachineCodsec.ReadOnly = true;
            this.clmMachineCodsec.Visible = false;
            this.clmMachineCodsec.Width = 109;
            // 
            // clmFilmOrg
            // 
            this.clmFilmOrg.HeaderText = "Film Org.";
            this.clmFilmOrg.Name = "clmFilmOrg";
            this.clmFilmOrg.ReadOnly = true;
            this.clmFilmOrg.Width = 73;
            // 
            // clmFilmDest
            // 
            this.clmFilmDest.HeaderText = "Film Dest.";
            this.clmFilmDest.Name = "clmFilmDest";
            this.clmFilmDest.ReadOnly = true;
            this.clmFilmDest.Width = 78;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            this.clmAncho.Width = 63;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Width = 65;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad [Kg]";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 96;
            // 
            // clmCantMBob
            // 
            this.clmCantMBob.HeaderText = "Metalizado [Bob]";
            this.clmCantMBob.Name = "clmCantMBob";
            this.clmCantMBob.ReadOnly = true;
            this.clmCantMBob.Width = 111;
            // 
            // clmCantMKilos
            // 
            this.clmCantMKilos.HeaderText = "Metalizado [Kg]";
            this.clmCantMKilos.Name = "clmCantMKilos";
            this.clmCantMKilos.ReadOnly = true;
            this.clmCantMKilos.Width = 105;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.HeaderText = "Creación";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 74;
            // 
            // clmObservation
            // 
            this.clmObservation.HeaderText = "Obsevacion";
            this.clmObservation.Name = "clmObservation";
            this.clmObservation.ReadOnly = true;
            this.clmObservation.Visible = false;
            this.clmObservation.Width = 89;
            // 
            // clmAdd
            // 
            this.clmAdd.HeaderText = "";
            this.clmAdd.Image = global::BPS.Lite.Properties.Resources.add1;
            this.clmAdd.Name = "clmAdd";
            this.clmAdd.ReadOnly = true;
            this.clmAdd.Width = 5;
            // 
            // clmVer
            // 
            this.clmVer.HeaderText = "";
            this.clmVer.Image = global::BPS.Lite.Properties.Resources.eye;
            this.clmVer.Name = "clmVer";
            this.clmVer.ReadOnly = true;
            this.clmVer.Width = 5;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.btnMetalizar);
            this.grpDetail.Controls.Add(this.txtObservaciones);
            this.grpDetail.Controls.Add(this.label5);
            this.grpDetail.Controls.Add(this.lblCantBob);
            this.grpDetail.Controls.Add(this.lblCantBobinas);
            this.grpDetail.Controls.Add(this.lblMetalizado);
            this.grpDetail.Controls.Add(this.lblMetalizadoKg);
            this.grpDetail.Controls.Add(this.lbl11);
            this.grpDetail.Controls.Add(this.lblCantKilos);
            this.grpDetail.Controls.Add(this.lblEstado);
            this.grpDetail.Controls.Add(this.lbl10);
            this.grpDetail.Controls.Add(this.lblAncho);
            this.grpDetail.Controls.Add(this.lbl9);
            this.grpDetail.Controls.Add(this.lblFDest);
            this.grpDetail.Controls.Add(this.label7);
            this.grpDetail.Controls.Add(this.lblFOrg);
            this.grpDetail.Controls.Add(this.lbl5);
            this.grpDetail.Controls.Add(this.lblMaquina);
            this.grpDetail.Controls.Add(this.lbl3);
            this.grpDetail.Controls.Add(this.lblLote);
            this.grpDetail.Controls.Add(this.lbl1);
            this.grpDetail.Location = new System.Drawing.Point(4, 329);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(1004, 171);
            this.grpDetail.TabIndex = 1;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Detalle";
            // 
            // btnMetalizar
            // 
            this.btnMetalizar.Image = global::BPS.Lite.Properties.Resources.gear_32;
            this.btnMetalizar.Location = new System.Drawing.Point(880, 92);
            this.btnMetalizar.Name = "btnMetalizar";
            this.btnMetalizar.Size = new System.Drawing.Size(103, 63);
            this.btnMetalizar.TabIndex = 1;
            this.btnMetalizar.Text = "Ejecutar";
            this.btnMetalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMetalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMetalizar.UseVisualStyleBackColor = true;
            this.btnMetalizar.Click += new System.EventHandler(this.btnMetalizar_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(125, 105);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(622, 60);
            this.txtObservaciones.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Observaciones:";
            // 
            // lblCantBob
            // 
            this.lblCantBob.AutoSize = true;
            this.lblCantBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBob.Location = new System.Drawing.Point(370, 66);
            this.lblCantBob.Name = "lblCantBob";
            this.lblCantBob.Size = new System.Drawing.Size(101, 16);
            this.lblCantBob.TabIndex = 18;
            this.lblCantBob.Text = "Cantidad [Bob]:";
            // 
            // lblCantBobinas
            // 
            this.lblCantBobinas.AutoSize = true;
            this.lblCantBobinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantBobinas.Location = new System.Drawing.Point(474, 66);
            this.lblCantBobinas.Name = "lblCantBobinas";
            this.lblCantBobinas.Size = new System.Drawing.Size(45, 16);
            this.lblCantBobinas.TabIndex = 17;
            this.lblCantBobinas.Text = "label3";
            // 
            // lblMetalizado
            // 
            this.lblMetalizado.AutoSize = true;
            this.lblMetalizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalizado.Location = new System.Drawing.Point(559, 66);
            this.lblMetalizado.Name = "lblMetalizado";
            this.lblMetalizado.Size = new System.Drawing.Size(77, 16);
            this.lblMetalizado.TabIndex = 16;
            this.lblMetalizado.Text = "Metalizado:";
            // 
            // lblMetalizadoKg
            // 
            this.lblMetalizadoKg.AutoSize = true;
            this.lblMetalizadoKg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetalizadoKg.Location = new System.Drawing.Point(659, 66);
            this.lblMetalizadoKg.Name = "lblMetalizadoKg";
            this.lblMetalizadoKg.Size = new System.Drawing.Size(88, 16);
            this.lblMetalizadoKg.TabIndex = 15;
            this.lblMetalizadoKg.Text = "lblMetalizado";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.Location = new System.Drawing.Point(757, 26);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(92, 16);
            this.lbl11.TabIndex = 14;
            this.lbl11.Text = "Cantidad [Kg]:";
            // 
            // lblCantKilos
            // 
            this.lblCantKilos.AutoSize = true;
            this.lblCantKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantKilos.Location = new System.Drawing.Point(861, 26);
            this.lblCantKilos.Name = "lblCantKilos";
            this.lblCantKilos.Size = new System.Drawing.Size(76, 16);
            this.lblCantKilos.TabIndex = 13;
            this.lblCantKilos.Text = "lblCantidad";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(259, 66);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(65, 16);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "lblEstado";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.Location = new System.Drawing.Point(169, 66);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(54, 16);
            this.lbl10.TabIndex = 11;
            this.lbl10.Text = "Estado:";
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAncho.Location = new System.Drawing.Point(659, 26);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(60, 16);
            this.lblAncho.TabIndex = 10;
            this.lblAncho.Text = "lblAncho";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl9.Location = new System.Drawing.Point(559, 26);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(49, 16);
            this.lbl9.TabIndex = 9;
            this.lbl9.Text = "Ancho:";
            // 
            // lblFDest
            // 
            this.lblFDest.AutoSize = true;
            this.lblFDest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFDest.Location = new System.Drawing.Point(470, 26);
            this.lblFDest.Name = "lblFDest";
            this.lblFDest.Size = new System.Drawing.Size(45, 16);
            this.lblFDest.TabIndex = 8;
            this.lblFDest.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pelicula Dest:";
            // 
            // lblFOrg
            // 
            this.lblFOrg.AutoSize = true;
            this.lblFOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFOrg.Location = new System.Drawing.Point(259, 26);
            this.lblFOrg.Name = "lblFOrg";
            this.lblFOrg.Size = new System.Drawing.Size(45, 16);
            this.lblFOrg.TabIndex = 6;
            this.lblFOrg.Text = "label6";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(169, 26);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(84, 16);
            this.lbl5.TabIndex = 5;
            this.lbl5.Text = "Pelicula Org:";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaquina.Location = new System.Drawing.Point(82, 66);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(45, 16);
            this.lblMaquina.TabIndex = 4;
            this.lblMaquina.Text = "label4";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(16, 66);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(63, 16);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Maquina:";
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(76, 26);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(44, 16);
            this.lblLote.TabIndex = 2;
            this.lblLote.Text = "NLote";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(16, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(54, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Lote n°: ";
            // 
            // frmNewMetallizedCoils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 506);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewMetallizedCoils";
            this.Text = "Metalizado";
            this.Enter += new System.EventHandler(this.frmNewMetallizedCoils_Enter);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdOrders)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdOrders;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label lblCantBob;
        private System.Windows.Forms.Label lblCantBobinas;
        private System.Windows.Forms.Label lblMetalizado;
        private System.Windows.Forms.Label lblMetalizadoKg;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lblCantKilos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblFDest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFOrg;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnMetalizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewImageColumn clmActiveOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantMBob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantMKilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservation;
        private System.Windows.Forms.DataGridViewImageColumn clmAdd;
        private System.Windows.Forms.DataGridViewImageColumn clmVer;
    }
}