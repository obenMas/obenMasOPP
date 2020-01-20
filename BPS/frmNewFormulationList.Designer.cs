namespace BPS
{
    partial class frmNewFormulationList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewFormulationList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.cmbEstandar = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEspesor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNombre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPelicula = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEspesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstandar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmEditar = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmVer = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmBorrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbMaquina);
            this.groupBox1.Controls.Add(this.cmbEstandar);
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbEspesor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbPelicula);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Maquina";
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(8, 43);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(94, 21);
            this.cmbMaquina.TabIndex = 41;
            this.cmbMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbMaquina_SelectedIndexChanged);
            // 
            // cmbEstandar
            // 
            this.cmbEstandar.FormattingEnabled = true;
            this.cmbEstandar.Location = new System.Drawing.Point(410, 43);
            this.cmbEstandar.Name = "cmbEstandar";
            this.cmbEstandar.Size = new System.Drawing.Size(94, 21);
            this.cmbEstandar.TabIndex = 39;
            this.cmbEstandar.SelectedIndexChanged += new System.EventHandler(this.cmbEstandar_SelectedIndexChanged);
            this.cmbEstandar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEstandar_KeyDown);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(546, 43);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(31, 23);
            this.btnExcel.TabIndex = 38;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Properties.Resources.cross;
            this.btnCancel.Location = new System.Drawing.Point(510, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 23);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estandar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Espesor";
            // 
            // cmbEspesor
            // 
            this.cmbEspesor.FormattingEnabled = true;
            this.cmbEspesor.Location = new System.Drawing.Point(308, 43);
            this.cmbEspesor.Name = "cmbEspesor";
            this.cmbEspesor.Size = new System.Drawing.Size(94, 21);
            this.cmbEspesor.TabIndex = 4;
            this.cmbEspesor.SelectedIndexChanged += new System.EventHandler(this.cmbEspesor_SelectedIndexChanged);
            this.cmbEspesor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbEspesor_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // cmbNombre
            // 
            this.cmbNombre.FormattingEnabled = true;
            this.cmbNombre.Location = new System.Drawing.Point(208, 43);
            this.cmbNombre.Name = "cmbNombre";
            this.cmbNombre.Size = new System.Drawing.Size(94, 21);
            this.cmbNombre.TabIndex = 2;
            this.cmbNombre.SelectedIndexChanged += new System.EventHandler(this.cmbNombre_SelectedIndexChanged);
            this.cmbNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbNombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pelicula";
            // 
            // cmbPelicula
            // 
            this.cmbPelicula.FormattingEnabled = true;
            this.cmbPelicula.Location = new System.Drawing.Point(108, 43);
            this.cmbPelicula.Name = "cmbPelicula";
            this.cmbPelicula.Size = new System.Drawing.Size(94, 21);
            this.cmbPelicula.TabIndex = 0;
            this.cmbPelicula.SelectedIndexChanged += new System.EventHandler(this.cmbPelicula_SelectedIndexChanged);
            this.cmbPelicula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPelicula_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1067, 477);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeight = 47;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmMaquina,
            this.clmPelicula,
            this.clmNombre,
            this.clmDescripcion,
            this.clmEspesor,
            this.clmEstandar,
            this.clmEditar,
            this.clmVer,
            this.clmBorrar});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(1061, 458);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.32737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.67263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1073, 557);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmMaquina
            // 
            this.clmMaquina.HeaderText = "Maquina";
            this.clmMaquina.Name = "clmMaquina";
            this.clmMaquina.ReadOnly = true;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 200;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 150;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.HeaderText = "Descripcion";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.ReadOnly = true;
            this.clmDescripcion.Width = 200;
            // 
            // clmEspesor
            // 
            this.clmEspesor.HeaderText = "Espesor";
            this.clmEspesor.Name = "clmEspesor";
            this.clmEspesor.ReadOnly = true;
            // 
            // clmEstandar
            // 
            this.clmEstandar.HeaderText = "Estandar";
            this.clmEstandar.Name = "clmEstandar";
            this.clmEstandar.ReadOnly = true;
            // 
            // clmEditar
            // 
            this.clmEditar.HeaderText = "Editar";
            this.clmEditar.Image = global::BPS.Properties.Resources.pencil;
            this.clmEditar.Name = "clmEditar";
            this.clmEditar.ReadOnly = true;
            this.clmEditar.Width = 50;
            // 
            // clmVer
            // 
            this.clmVer.HeaderText = "Ver";
            this.clmVer.Image = global::BPS.Properties.Resources.eye;
            this.clmVer.Name = "clmVer";
            this.clmVer.ReadOnly = true;
            this.clmVer.Width = 50;
            // 
            // clmBorrar
            // 
            this.clmBorrar.HeaderText = "Borrar";
            this.clmBorrar.Image = global::BPS.Properties.Resources.cross;
            this.clmBorrar.Name = "clmBorrar";
            this.clmBorrar.ReadOnly = true;
            this.clmBorrar.Width = 50;
            // 
            // frmNewFormulationList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1073, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewFormulationList";
            this.Text = "Listado de formulaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmNewFormulationList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cmbPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEspesor;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cmbEstandar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEspesor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmEstandar;
        private System.Windows.Forms.DataGridViewImageColumn clmEditar;
        private System.Windows.Forms.DataGridViewImageColumn clmVer;
        private System.Windows.Forms.DataGridViewImageColumn clmBorrar;
    }
}