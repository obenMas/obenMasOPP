namespace BPS
{
    partial class frmScrapPalletStockReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTurno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMaquina = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbMaquina = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.gpboxFiltros = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpboxFiltros.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCodigo,
            this.clmTipo,
            this.clmMaquina,
            this.clmTurno,
            this.clmPeso,
            this.clmFecha,
            this.clmStatus});
            this.dataGridView1.Location = new System.Drawing.Point(29, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(743, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 130;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "Tipo";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.ReadOnly = true;
            this.clmTipo.Width = 110;
            // 
            // clmMaquina
            // 
            this.clmMaquina.HeaderText = "Máquina";
            this.clmMaquina.Name = "clmMaquina";
            this.clmMaquina.ReadOnly = true;
            this.clmMaquina.Width = 120;
            // 
            // clmTurno
            // 
            this.clmTurno.HeaderText = "Turno";
            this.clmTurno.Name = "clmTurno";
            this.clmTurno.ReadOnly = true;
            this.clmTurno.Width = 80;
            // 
            // clmPeso
            // 
            this.clmPeso.HeaderText = "Peso";
            this.clmPeso.Name = "clmPeso";
            this.clmPeso.ReadOnly = true;
            this.clmPeso.Width = 110;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 130;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 22);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(186, 22);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo";
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(332, 22);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(48, 13);
            this.lblMaquina.TabIndex = 3;
            this.lblMaquina.Text = "Máquina";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(503, 21);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(52, 19);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(117, 21);
            this.cmbCodigo.TabIndex = 5;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            this.cmbCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCodigo_KeyDown);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(220, 19);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(98, 21);
            this.cmbTipo.TabIndex = 6;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            this.cmbTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTipo_KeyDown);
            // 
            // cmbMaquina
            // 
            this.cmbMaquina.FormattingEnabled = true;
            this.cmbMaquina.Location = new System.Drawing.Point(386, 19);
            this.cmbMaquina.Name = "cmbMaquina";
            this.cmbMaquina.Size = new System.Drawing.Size(98, 21);
            this.cmbMaquina.TabIndex = 7;
            this.cmbMaquina.SelectedIndexChanged += new System.EventHandler(this.cmbMaquina_SelectedIndexChanged);
            this.cmbMaquina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMaquina_KeyDown);
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(544, 18);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(98, 21);
            this.cmbTurno.TabIndex = 8;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            this.cmbTurno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTurno_KeyDown);
            // 
            // gpboxFiltros
            // 
            this.gpboxFiltros.Controls.Add(this.btnExcel);
            this.gpboxFiltros.Controls.Add(this.button1);
            this.gpboxFiltros.Controls.Add(this.cmbTurno);
            this.gpboxFiltros.Controls.Add(this.cmbMaquina);
            this.gpboxFiltros.Controls.Add(this.cmbTipo);
            this.gpboxFiltros.Controls.Add(this.cmbCodigo);
            this.gpboxFiltros.Controls.Add(this.lblTurno);
            this.gpboxFiltros.Controls.Add(this.lblMaquina);
            this.gpboxFiltros.Controls.Add(this.lblTipo);
            this.gpboxFiltros.Controls.Add(this.lblCodigo);
            this.gpboxFiltros.Location = new System.Drawing.Point(26, 5);
            this.gpboxFiltros.Name = "gpboxFiltros";
            this.gpboxFiltros.Size = new System.Drawing.Size(746, 55);
            this.gpboxFiltros.TabIndex = 9;
            this.gpboxFiltros.TabStop = false;
            this.gpboxFiltros.Text = "Filtros";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(697, 15);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(29, 29);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BPS.Properties.Resources.funnel_clear;
            this.button1.Location = new System.Drawing.Point(661, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 29);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnlimpiarFiltros_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPesos);
            this.groupBox1.Location = new System.Drawing.Point(31, 401);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesos Totales";
            // 
            // txtPesos
            // 
            this.txtPesos.Enabled = false;
            this.txtPesos.Location = new System.Drawing.Point(86, 16);
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(100, 20);
            this.txtPesos.TabIndex = 0;
            // 
            // frmScrapPalletStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpboxFiltros);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmScrapPalletStock";
            this.ShowIcon = false;
            this.Text = "Stock de pallets de mermas";
            this.Load += new System.EventHandler(this.frmScrapPalletStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpboxFiltros.ResumeLayout(false);
            this.gpboxFiltros.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.GroupBox gpboxFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
    }
}