namespace BPS
{
    partial class frmOTIFReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOTIFReport));
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvOTIFReport = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToCutting = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTPFromCutting = new System.Windows.Forms.DateTimePicker();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadFabricada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidadDespachada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaOTIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaDespacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOTIFReport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(750, 49);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 21;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvOTIFReport
            // 
            this.dgvOTIFReport.AllowUserToAddRows = false;
            this.dgvOTIFReport.AllowUserToDeleteRows = false;
            this.dgvOTIFReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvOTIFReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOTIFReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmSoD,
            this.clmPlanta,
            this.clmCliente,
            this.clmPelicula,
            this.clmAncho,
            this.clmCantidad,
            this.clmCantidadFabricada,
            this.clmCantidadDespachada,
            this.clmFechaCreacion,
            this.clmFechaOTIF,
            this.clmCompDate,
            this.clmFechaDespacho});
            this.dgvOTIFReport.Location = new System.Drawing.Point(12, 80);
            this.dgvOTIFReport.Name = "dgvOTIFReport";
            this.dgvOTIFReport.ReadOnly = true;
            this.dgvOTIFReport.Size = new System.Drawing.Size(1179, 405);
            this.dgvOTIFReport.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTPToCutting);
            this.groupBox3.Location = new System.Drawing.Point(236, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 44);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToCutting
            // 
            this.dateTPToCutting.Location = new System.Drawing.Point(6, 15);
            this.dateTPToCutting.Name = "dateTPToCutting";
            this.dateTPToCutting.Size = new System.Drawing.Size(200, 20);
            this.dateTPToCutting.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Location = new System.Drawing.Point(236, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 26);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(3, 7);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(53, 16);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Hasta:";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(604, 32);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(128, 42);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Generar";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.lblFrom);
            this.groupBoxFrom.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(215, 26);
            this.groupBoxFrom.TabIndex = 14;
            this.groupBoxFrom.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 16);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Desde:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTPFromCutting);
            this.groupBox2.Location = new System.Drawing.Point(4, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 44);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // dateTPFromCutting
            // 
            this.dateTPFromCutting.Location = new System.Drawing.Point(6, 15);
            this.dateTPFromCutting.Name = "dateTPFromCutting";
            this.dateTPFromCutting.Size = new System.Drawing.Size(200, 20);
            this.dateTPFromCutting.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 67;
            // 
            // clmSoD
            // 
            this.clmSoD.HeaderText = "Pedido";
            this.clmSoD.Name = "clmSoD";
            this.clmSoD.ReadOnly = true;
            this.clmSoD.Width = 65;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            this.clmPlanta.Width = 65;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            this.clmCliente.Width = 150;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 70;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            this.clmAncho.Width = 65;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad Solicitada";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.ReadOnly = true;
            // 
            // clmCantidadFabricada
            // 
            this.clmCantidadFabricada.HeaderText = "Cantidad Fabricada";
            this.clmCantidadFabricada.Name = "clmCantidadFabricada";
            this.clmCantidadFabricada.ReadOnly = true;
            // 
            // clmCantidadDespachada
            // 
            this.clmCantidadDespachada.HeaderText = "Cantidad Despachada";
            this.clmCantidadDespachada.Name = "clmCantidadDespachada";
            this.clmCantidadDespachada.ReadOnly = true;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.HeaderText = "Fecha de Creacion";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            // 
            // clmFechaOTIF
            // 
            this.clmFechaOTIF.HeaderText = "Fecha Requerida";
            this.clmFechaOTIF.Name = "clmFechaOTIF";
            this.clmFechaOTIF.ReadOnly = true;
            // 
            // clmCompDate
            // 
            this.clmCompDate.HeaderText = "Fecha Fabricación";
            this.clmCompDate.Name = "clmCompDate";
            this.clmCompDate.ReadOnly = true;
            // 
            // clmFechaDespacho
            // 
            this.clmFechaDespacho.HeaderText = "Fecha Despacho";
            this.clmFechaDespacho.Name = "clmFechaDespacho";
            this.clmFechaDespacho.ReadOnly = true;
            // 
            // frmOTIFReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1202, 489);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvOTIFReport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.groupBoxFrom);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOTIFReport";
            this.Text = "Reporte OTIF";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOTIFReport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvOTIFReport;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTPToCutting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTPFromCutting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadFabricada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidadDespachada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaOTIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaDespacho;
    }
}