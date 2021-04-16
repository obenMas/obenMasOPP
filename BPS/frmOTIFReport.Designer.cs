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
            this.button1 = new System.Windows.Forms.Button();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEjecutiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantSol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantFab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantDesp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInFullDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFechaDespacho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEsReventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.clmEstado,
            this.clmEjecutiva,
            this.clmPlanta,
            this.clmCliente,
            this.clmOC,
            this.clmPelicula,
            this.clmAncho,
            this.clmDiameter,
            this.clmCore,
            this.clmPrice,
            this.clmCantSol,
            this.clmCantFab,
            this.clmCantDesp,
            this.clmFechaCreacion,
            this.clmFechaSolicitada,
            this.clmPlanningDate,
            this.clmFechaEntrega,
            this.clmInFullDate,
            this.clmFechaDespacho,
            this.clmEsReventa});
            this.dgvOTIFReport.Location = new System.Drawing.Point(12, 80);
            this.dgvOTIFReport.Name = "dgvOTIFReport";
            this.dgvOTIFReport.ReadOnly = true;
            this.dgvOTIFReport.Size = new System.Drawing.Size(1255, 405);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.clmSoD.Width = 55;
            // 
            // clmEstado
            // 
            this.clmEstado.HeaderText = "Estado";
            this.clmEstado.Name = "clmEstado";
            this.clmEstado.ReadOnly = true;
            this.clmEstado.Width = 70;
            // 
            // clmEjecutiva
            // 
            this.clmEjecutiva.HeaderText = "Ejecutiva";
            this.clmEjecutiva.Name = "clmEjecutiva";
            this.clmEjecutiva.ReadOnly = true;
            this.clmEjecutiva.Width = 60;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            this.clmPlanta.Visible = false;
            this.clmPlanta.Width = 65;
            // 
            // clmCliente
            // 
            this.clmCliente.HeaderText = "Cliente";
            this.clmCliente.Name = "clmCliente";
            this.clmCliente.ReadOnly = true;
            // 
            // clmOC
            // 
            this.clmOC.HeaderText = "OC";
            this.clmOC.Name = "clmOC";
            this.clmOC.ReadOnly = true;
            this.clmOC.Width = 40;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 65;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            this.clmAncho.Width = 40;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 50;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 40;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 40;
            // 
            // clmCantSol
            // 
            this.clmCantSol.HeaderText = "Cantidad Solicitada";
            this.clmCantSol.Name = "clmCantSol";
            this.clmCantSol.ReadOnly = true;
            this.clmCantSol.Width = 70;
            // 
            // clmCantFab
            // 
            this.clmCantFab.HeaderText = "Cantidad Fabricada";
            this.clmCantFab.Name = "clmCantFab";
            this.clmCantFab.ReadOnly = true;
            this.clmCantFab.Width = 70;
            // 
            // clmCantDesp
            // 
            this.clmCantDesp.HeaderText = "Cantidad Despachada";
            this.clmCantDesp.Name = "clmCantDesp";
            this.clmCantDesp.ReadOnly = true;
            this.clmCantDesp.Width = 70;
            // 
            // clmFechaCreacion
            // 
            this.clmFechaCreacion.HeaderText = "Fecha de Creacion";
            this.clmFechaCreacion.Name = "clmFechaCreacion";
            this.clmFechaCreacion.ReadOnly = true;
            this.clmFechaCreacion.Width = 70;
            // 
            // clmFechaSolicitada
            // 
            this.clmFechaSolicitada.HeaderText = "Fecha Solicitada";
            this.clmFechaSolicitada.Name = "clmFechaSolicitada";
            this.clmFechaSolicitada.ReadOnly = true;
            this.clmFechaSolicitada.Width = 70;
            // 
            // clmPlanningDate
            // 
            this.clmPlanningDate.HeaderText = "Fecha Planning";
            this.clmPlanningDate.Name = "clmPlanningDate";
            this.clmPlanningDate.ReadOnly = true;
            this.clmPlanningDate.Width = 70;
            // 
            // clmFechaEntrega
            // 
            this.clmFechaEntrega.HeaderText = "Fecha Entrega";
            this.clmFechaEntrega.Name = "clmFechaEntrega";
            this.clmFechaEntrega.ReadOnly = true;
            this.clmFechaEntrega.Width = 70;
            // 
            // clmInFullDate
            // 
            this.clmInFullDate.HeaderText = "Fecha InFull";
            this.clmInFullDate.Name = "clmInFullDate";
            this.clmInFullDate.ReadOnly = true;
            this.clmInFullDate.Width = 70;
            // 
            // clmFechaDespacho
            // 
            this.clmFechaDespacho.HeaderText = "Fecha Despacho";
            this.clmFechaDespacho.Name = "clmFechaDespacho";
            this.clmFechaDespacho.ReadOnly = true;
            this.clmFechaDespacho.Width = 70;
            // 
            // clmEsReventa
            // 
            this.clmEsReventa.HeaderText = "Reventa";
            this.clmEsReventa.Name = "clmEsReventa";
            this.clmEsReventa.ReadOnly = true;
            // 
            // frmOTIFReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1279, 489);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEjecutiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantSol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantFab;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantDesp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanningDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInFullDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFechaDespacho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEsReventa;
    }
}