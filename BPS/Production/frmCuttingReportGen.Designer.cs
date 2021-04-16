namespace BPS
{
    partial class frmCuttingReportGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingReportGen));
            this.dateTPFromCutting = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateCuttingRp = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToCutting = new System.Windows.Forms.DateTimePicker();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metraje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BobinaMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCorte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsefulwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTPFromCutting
            // 
            this.dateTPFromCutting.Location = new System.Drawing.Point(6, 12);
            this.dateTPFromCutting.Name = "dateTPFromCutting";
            this.dateTPFromCutting.Size = new System.Drawing.Size(200, 20);
            this.dateTPFromCutting.TabIndex = 0;
            // 
            // btnGenerateCuttingRp
            // 
            this.btnGenerateCuttingRp.Location = new System.Drawing.Point(662, 22);
            this.btnGenerateCuttingRp.Name = "btnGenerateCuttingRp";
            this.btnGenerateCuttingRp.Size = new System.Drawing.Size(128, 42);
            this.btnGenerateCuttingRp.TabIndex = 2;
            this.btnGenerateCuttingRp.Text = "Generar";
            this.btnGenerateCuttingRp.UseVisualStyleBackColor = true;
            this.btnGenerateCuttingRp.Click += new System.EventHandler(this.btnGenerateCuttingRp_Click);
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
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.lblFrom);
            this.groupBoxFrom.Location = new System.Drawing.Point(10, 6);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(215, 26);
            this.groupBoxFrom.TabIndex = 5;
            this.groupBoxFrom.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTPFromCutting);
            this.groupBox2.Location = new System.Drawing.Point(10, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 37);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Location = new System.Drawing.Point(242, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 26);
            this.groupBox1.TabIndex = 7;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTPToCutting);
            this.groupBox3.Location = new System.Drawing.Point(242, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 37);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToCutting
            // 
            this.dateTPToCutting.Location = new System.Drawing.Point(6, 11);
            this.dateTPToCutting.Name = "dateTPToCutting";
            this.dateTPToCutting.Size = new System.Drawing.Size(200, 20);
            this.dateTPToCutting.TabIndex = 0;
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(491, 42);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(103, 21);
            this.cmbPlant.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maquina,
            this.Bobina,
            this.Familia,
            this.Producto,
            this.PesoNeto,
            this.Calificacion,
            this.Tipo,
            this.Estado,
            this.Metraje,
            this.BobinaMadre,
            this.Lote,
            this.OrdenCorte,
            this.Parada,
            this.Cliente,
            this.OrdenVenta,
            this.FechaCorte,
            this.Observaciones,
            this.clmOrg,
            this.clmDestination,
            this.clmProcess,
            this.clmUsefulwidth,
            this.clmDetail,
            this.clmDay,
            this.clmMonth,
            this.clmYear,
            this.clmHour});
            this.dataGridView1.Location = new System.Drawing.Point(10, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1038, 406);
            this.dataGridView1.TabIndex = 10;
            // 
            // Maquina
            // 
            this.Maquina.HeaderText = "Máquina";
            this.Maquina.Name = "Maquina";
            this.Maquina.ReadOnly = true;
            this.Maquina.Width = 70;
            // 
            // Bobina
            // 
            this.Bobina.HeaderText = "Bobina";
            this.Bobina.Name = "Bobina";
            this.Bobina.ReadOnly = true;
            // 
            // Familia
            // 
            this.Familia.HeaderText = "Familia";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            this.Familia.Width = 70;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // PesoNeto
            // 
            this.PesoNeto.HeaderText = "Peso Neto";
            this.PesoNeto.Name = "PesoNeto";
            this.PesoNeto.ReadOnly = true;
            this.PesoNeto.Width = 60;
            // 
            // Calificacion
            // 
            this.Calificacion.HeaderText = "Calificación";
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.ReadOnly = true;
            this.Calificacion.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 70;
            // 
            // Metraje
            // 
            this.Metraje.HeaderText = "Metraje";
            this.Metraje.Name = "Metraje";
            this.Metraje.ReadOnly = true;
            this.Metraje.Width = 60;
            // 
            // BobinaMadre
            // 
            this.BobinaMadre.HeaderText = "Bobina Madre";
            this.BobinaMadre.Name = "BobinaMadre";
            this.BobinaMadre.ReadOnly = true;
            this.BobinaMadre.Width = 70;
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            this.Lote.Width = 70;
            // 
            // OrdenCorte
            // 
            this.OrdenCorte.HeaderText = "Orden de corte";
            this.OrdenCorte.Name = "OrdenCorte";
            this.OrdenCorte.ReadOnly = true;
            this.OrdenCorte.Width = 50;
            // 
            // Parada
            // 
            this.Parada.HeaderText = "Parada";
            this.Parada.Name = "Parada";
            this.Parada.ReadOnly = true;
            this.Parada.Width = 50;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // OrdenVenta
            // 
            this.OrdenVenta.HeaderText = "Orden de venta";
            this.OrdenVenta.Name = "OrdenVenta";
            this.OrdenVenta.ReadOnly = true;
            this.OrdenVenta.Width = 60;
            // 
            // FechaCorte
            // 
            this.FechaCorte.HeaderText = "Fecha de corte";
            this.FechaCorte.Name = "FechaCorte";
            this.FechaCorte.ReadOnly = true;
            this.FechaCorte.Width = 150;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // clmOrg
            // 
            this.clmOrg.HeaderText = "Origen";
            this.clmOrg.Name = "clmOrg";
            this.clmOrg.ReadOnly = true;
            // 
            // clmDestination
            // 
            this.clmDestination.HeaderText = "Destino";
            this.clmDestination.Name = "clmDestination";
            this.clmDestination.ReadOnly = true;
            // 
            // clmProcess
            // 
            this.clmProcess.HeaderText = "Reproceso";
            this.clmProcess.Name = "clmProcess";
            this.clmProcess.ReadOnly = true;
            // 
            // clmUsefulwidth
            // 
            this.clmUsefulwidth.HeaderText = "AnchoUtil";
            this.clmUsefulwidth.Name = "clmUsefulwidth";
            this.clmUsefulwidth.ReadOnly = true;
            // 
            // clmDetail
            // 
            this.clmDetail.HeaderText = "Detalle";
            this.clmDetail.Name = "clmDetail";
            this.clmDetail.ReadOnly = true;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "Dia";
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            this.clmDay.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "Mes";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            this.clmMonth.Visible = false;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Año";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Visible = false;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            this.clmHour.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Planta:";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(810, 39);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 11;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(842, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmCuttingReportGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbPlant);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateCuttingRp);
            this.Controls.Add(this.groupBoxFrom);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingReportGen";
            this.Text = "Reporte de Corte";
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTPFromCutting;
        private System.Windows.Forms.Button btnGenerateCuttingRp;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTPToCutting;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metraje;
        private System.Windows.Forms.DataGridViewTextBoxColumn BobinaMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCorte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsefulwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.Button button1;
    }
}