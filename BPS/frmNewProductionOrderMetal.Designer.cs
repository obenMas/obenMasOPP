namespace BPS
{
    partial class frmNewProductionOrderMetal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewProductionOrderMetal));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
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
            this.clmEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmEliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservation = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.cmbOrg = new System.Windows.Forms.ComboBox();
            this.cmbDest = new System.Windows.Forms.ComboBox();
            this.dtpInicioEst = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMachine = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.grpAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAlta);
            this.groupBox3.Controls.Add(this.grpAlta);
            this.groupBox3.Location = new System.Drawing.Point(0, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 254);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.chkAlta.Location = new System.Drawing.Point(6, 11);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.Size = new System.Drawing.Size(162, 17);
            this.chkAlta.TabIndex = 12;
            this.chkAlta.Text = "Agregar orden de Metalizado";
            this.chkAlta.UseVisualStyleBackColor = true;
            this.chkAlta.CheckedChanged += new System.EventHandler(this.chkAlta_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProdOrders);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 326);
            this.groupBox1.TabIndex = 0;
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
            this.clmEditar,
            this.clmEliminar});
            this.dgvProdOrders.Location = new System.Drawing.Point(4, 16);
            this.dgvProdOrders.Name = "dgvProdOrders";
            this.dgvProdOrders.ReadOnly = true;
            this.dgvProdOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvProdOrders.Size = new System.Drawing.Size(871, 304);
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
            this.clmActiveOrder.Image = global::BPS.Properties.Resources.pause_sharp;
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
            this.clmFilmOrg.HeaderText = "Pelicula Origen";
            this.clmFilmOrg.Name = "clmFilmOrg";
            this.clmFilmOrg.ReadOnly = true;
            this.clmFilmOrg.Width = 103;
            // 
            // clmFilmDest
            // 
            this.clmFilmDest.HeaderText = "Pelicula Destino";
            this.clmFilmDest.Name = "clmFilmDest";
            this.clmFilmDest.ReadOnly = true;
            this.clmFilmDest.Width = 108;
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
            this.clmCantMBob.HeaderText = "Metalizado [Bobinas]";
            this.clmCantMBob.Name = "clmCantMBob";
            this.clmCantMBob.ReadOnly = true;
            this.clmCantMBob.Width = 130;
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
            this.clmFechaCreacion.HeaderText = "Fecha de Creación";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 122;
            // 
            // clmObservation
            // 
            this.clmObservation.HeaderText = "Obsevacion";
            this.clmObservation.Name = "clmObservation";
            this.clmObservation.ReadOnly = true;
            this.clmObservation.Visible = false;
            this.clmObservation.Width = 89;
            // 
            // clmEditar
            // 
            this.clmEditar.HeaderText = "";
            this.clmEditar.Image = global::BPS.Properties.Resources.pencil;
            this.clmEditar.Name = "clmEditar";
            this.clmEditar.ReadOnly = true;
            this.clmEditar.Width = 5;
            // 
            // clmEliminar
            // 
            this.clmEliminar.HeaderText = "";
            this.clmEliminar.Image = global::BPS.Properties.Resources.cross;
            this.clmEliminar.Name = "clmEliminar";
            this.clmEliminar.ReadOnly = true;
            this.clmEliminar.Width = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Observación";
            // 
            // txtObservation
            // 
            this.txtObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservation.Location = new System.Drawing.Point(95, 121);
            this.txtObservation.Multiline = true;
            this.txtObservation.Name = "txtObservation";
            this.txtObservation.Size = new System.Drawing.Size(639, 88);
            this.txtObservation.TabIndex = 1;
            // 
            // lblLote
            // 
            this.lblLote.AutoSize = true;
            this.lblLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLote.Location = new System.Drawing.Point(6, 16);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(37, 16);
            this.lblLote.TabIndex = 1;
            this.lblLote.Text = "Lote:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pelicula Origen:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(420, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pelicula Destino:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(304, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inicio Estimado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(670, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(670, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Ancho:";
            // 
            // txtLote
            // 
            this.txtLote.Enabled = false;
            this.txtLote.Location = new System.Drawing.Point(49, 35);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(115, 20);
            this.txtLote.TabIndex = 13;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(741, 34);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(99, 20);
            this.txtAncho.TabIndex = 14;
            // 
            // cmbOrg
            // 
            this.cmbOrg.FormattingEnabled = true;
            this.cmbOrg.Location = new System.Drawing.Point(285, 34);
            this.cmbOrg.Name = "cmbOrg";
            this.cmbOrg.Size = new System.Drawing.Size(121, 21);
            this.cmbOrg.TabIndex = 15;
            this.cmbOrg.SelectedIndexChanged += new System.EventHandler(this.cmbOrg_SelectedIndexChanged);
            // 
            // cmbDest
            // 
            this.cmbDest.Enabled = false;
            this.cmbDest.FormattingEnabled = true;
            this.cmbDest.Location = new System.Drawing.Point(534, 34);
            this.cmbDest.Name = "cmbDest";
            this.cmbDest.Size = new System.Drawing.Size(121, 21);
            this.cmbDest.TabIndex = 16;
            this.cmbDest.SelectedIndexChanged += new System.EventHandler(this.cmbDest_SelectedIndexChanged);
            // 
            // dtpInicioEst
            // 
            this.dtpInicioEst.Location = new System.Drawing.Point(415, 87);
            this.dtpInicioEst.Name = "dtpInicioEst";
            this.dtpInicioEst.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioEst.TabIndex = 17;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::BPS.Properties.Resources.cross;
            this.btnCancelar.Location = new System.Drawing.Point(756, 173);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::BPS.Properties.Resources.disk;
            this.btnGuardar.Location = new System.Drawing.Point(756, 121);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 36);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(7, 68);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(63, 16);
            this.lblMachine.TabIndex = 20;
            this.lblMachine.Text = "Maquina:";
            // 
            // cmbMachine
            // 
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(76, 85);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(203, 21);
            this.cmbMachine.TabIndex = 21;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudCantidad.Location = new System.Drawing.Point(741, 91);
            this.nudCantidad.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(99, 20);
            this.nudCantidad.TabIndex = 24;
            // 
            // grpAlta
            // 
            this.grpAlta.Controls.Add(this.nudCantidad);
            this.grpAlta.Controls.Add(this.cmbMachine);
            this.grpAlta.Controls.Add(this.lblMachine);
            this.grpAlta.Controls.Add(this.btnGuardar);
            this.grpAlta.Controls.Add(this.btnCancelar);
            this.grpAlta.Controls.Add(this.dtpInicioEst);
            this.grpAlta.Controls.Add(this.cmbDest);
            this.grpAlta.Controls.Add(this.cmbOrg);
            this.grpAlta.Controls.Add(this.txtAncho);
            this.grpAlta.Controls.Add(this.txtLote);
            this.grpAlta.Controls.Add(this.label11);
            this.grpAlta.Controls.Add(this.label10);
            this.grpAlta.Controls.Add(this.label8);
            this.grpAlta.Controls.Add(this.label6);
            this.grpAlta.Controls.Add(this.label4);
            this.grpAlta.Controls.Add(this.lblLote);
            this.grpAlta.Controls.Add(this.txtObservation);
            this.grpAlta.Controls.Add(this.label1);
            this.grpAlta.Location = new System.Drawing.Point(5, 32);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Size = new System.Drawing.Size(871, 215);
            this.grpAlta.TabIndex = 1;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Datos de la Orden";
            // 
            // frmNewProductionOrderMetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 584);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewProductionOrderMetal";
            this.Text = "ABM de Ordenes de Metalizado";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProdOrders;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAlta;
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
        private System.Windows.Forms.DataGridViewImageColumn clmEditar;
        private System.Windows.Forms.DataGridViewImageColumn clmEliminar;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpInicioEst;
        private System.Windows.Forms.ComboBox cmbDest;
        private System.Windows.Forms.ComboBox cmbOrg;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtObservation;
        private System.Windows.Forms.Label label1;
    }
}