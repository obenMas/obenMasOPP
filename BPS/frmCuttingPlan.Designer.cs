namespace BPS
{
    partial class frmCuttingPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingPlan));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.cmbModo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCortadora = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPlan = new System.Windows.Forms.DataGridView();
            this.clmNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrdenPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRepeticionPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnchoUtilPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeliculaPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPendientes = new System.Windows.Forms.DataGridView();
            this.clmAgregar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRepeticiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAnchoUtil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1095, 525);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCortadora);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1089, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbPosicion);
            this.groupBox4.Controls.Add(this.cmbModo);
            this.groupBox4.Location = new System.Drawing.Point(688, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(365, 56);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Modo de agregado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar:";
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Items.AddRange(new object[] {
            "Al final",
            "En posicion intercalada"});
            this.cmbPosicion.Location = new System.Drawing.Point(186, 19);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(164, 21);
            this.cmbPosicion.TabIndex = 3;
            // 
            // cmbModo
            // 
            this.cmbModo.FormattingEnabled = true;
            this.cmbModo.Items.AddRange(new object[] {
            "Combinación",
            "Repetición",
            "Personalizado"});
            this.cmbModo.Location = new System.Drawing.Point(59, 19);
            this.cmbModo.Name = "cmbModo";
            this.cmbModo.Size = new System.Drawing.Size(121, 21);
            this.cmbModo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cortadora:";
            // 
            // cmbCortadora
            // 
            this.cmbCortadora.FormattingEnabled = true;
            this.cmbCortadora.Location = new System.Drawing.Point(80, 33);
            this.cmbCortadora.Name = "cmbCortadora";
            this.cmbCortadora.Size = new System.Drawing.Size(121, 21);
            this.cmbCortadora.TabIndex = 0;
            this.cmbCortadora.SelectedIndexChanged += new System.EventHandler(this.cmbCortadora_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1089, 419);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvPlan);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 413);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plan de corte";
            // 
            // dgvPlan
            // 
            this.dgvPlan.AllowUserToAddRows = false;
            this.dgvPlan.AllowUserToDeleteRows = false;
            this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumero,
            this.clmOrdenPlan,
            this.clmRepeticionPlan,
            this.clmAnchoUtilPlan,
            this.clmPeliculaPlan,
            this.clmFechaInicio,
            this.clmFechaFin});
            this.dgvPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlan.Location = new System.Drawing.Point(3, 16);
            this.dgvPlan.Name = "dgvPlan";
            this.dgvPlan.ReadOnly = true;
            this.dgvPlan.Size = new System.Drawing.Size(532, 394);
            this.dgvPlan.TabIndex = 0;
            // 
            // clmNumero
            // 
            this.clmNumero.HeaderText = "N°";
            this.clmNumero.Name = "clmNumero";
            this.clmNumero.ReadOnly = true;
            this.clmNumero.Width = 40;
            // 
            // clmOrdenPlan
            // 
            this.clmOrdenPlan.HeaderText = "Orden de corte";
            this.clmOrdenPlan.Name = "clmOrdenPlan";
            this.clmOrdenPlan.ReadOnly = true;
            // 
            // clmRepeticionPlan
            // 
            this.clmRepeticionPlan.HeaderText = "Repetición";
            this.clmRepeticionPlan.Name = "clmRepeticionPlan";
            this.clmRepeticionPlan.ReadOnly = true;
            // 
            // clmAnchoUtilPlan
            // 
            this.clmAnchoUtilPlan.HeaderText = "Ancho Util";
            this.clmAnchoUtilPlan.Name = "clmAnchoUtilPlan";
            this.clmAnchoUtilPlan.ReadOnly = true;
            // 
            // clmPeliculaPlan
            // 
            this.clmPeliculaPlan.HeaderText = "Pelicula";
            this.clmPeliculaPlan.Name = "clmPeliculaPlan";
            this.clmPeliculaPlan.ReadOnly = true;
            // 
            // clmFechaInicio
            // 
            this.clmFechaInicio.HeaderText = "Inicio";
            this.clmFechaInicio.Name = "clmFechaInicio";
            this.clmFechaInicio.ReadOnly = true;
            // 
            // clmFechaFin
            // 
            this.clmFechaFin.HeaderText = "Fin";
            this.clmFechaFin.Name = "clmFechaFin";
            this.clmFechaFin.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPendientes);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(547, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(539, 413);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ordenes de corte pendientes";
            // 
            // dgvPendientes
            // 
            this.dgvPendientes.AllowUserToAddRows = false;
            this.dgvPendientes.AllowUserToDeleteRows = false;
            this.dgvPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmAgregar,
            this.clmOrden,
            this.clmRepeticiones,
            this.clmPelicula,
            this.clmAnchoUtil,
            this.clmFecha});
            this.dgvPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPendientes.Location = new System.Drawing.Point(3, 16);
            this.dgvPendientes.Name = "dgvPendientes";
            this.dgvPendientes.ReadOnly = true;
            this.dgvPendientes.Size = new System.Drawing.Size(533, 394);
            this.dgvPendientes.TabIndex = 0;
            this.dgvPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPendientes_CellClick);
            // 
            // clmAgregar
            // 
            this.clmAgregar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmAgregar.HeaderText = "Agregar";
            this.clmAgregar.Image = global::BPS.Properties.Resources.arrow_left;
            this.clmAgregar.Name = "clmAgregar";
            this.clmAgregar.ReadOnly = true;
            this.clmAgregar.Width = 50;
            // 
            // clmOrden
            // 
            this.clmOrden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmOrden.HeaderText = "Orden de corte";
            this.clmOrden.Name = "clmOrden";
            this.clmOrden.ReadOnly = true;
            this.clmOrden.Width = 73;
            // 
            // clmRepeticiones
            // 
            this.clmRepeticiones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmRepeticiones.HeaderText = "Rep. Pend.";
            this.clmRepeticiones.Name = "clmRepeticiones";
            this.clmRepeticiones.ReadOnly = true;
            this.clmRepeticiones.Width = 79;
            // 
            // clmPelicula
            // 
            this.clmPelicula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 69;
            // 
            // clmAnchoUtil
            // 
            this.clmAnchoUtil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmAnchoUtil.HeaderText = "AnchoUtil";
            this.clmAnchoUtil.Name = "clmAnchoUtil";
            this.clmAnchoUtil.ReadOnly = true;
            this.clmAnchoUtil.Width = 78;
            // 
            // clmFecha
            // 
            this.clmFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 62;
            // 
            // frmCuttingPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 525);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingPlan";
            this.ShowIcon = false;
            this.Text = "Plan de Corte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCortadora;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPendientes;
        private System.Windows.Forms.DataGridView dgvPlan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.ComboBox cmbModo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrdenPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRepeticionPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnchoUtilPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeliculaPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaFin;
        private System.Windows.Forms.DataGridViewImageColumn clmAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRepeticiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAnchoUtil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;

    }
}