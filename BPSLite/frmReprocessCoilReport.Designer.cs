namespace BPS.Lite
{
    partial class frmReprocessCoilReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReprocessCoilReport));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReprocessCoil = new System.Windows.Forms.DataGridView();
            this.clmCodBobina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAncho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetrOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetrCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPesoOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPesoCons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmParada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprocessCoil)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvReprocessCoil);
            this.groupBox7.Location = new System.Drawing.Point(1, 83);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(990, 417);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.btnExport);
            this.groupBox6.Controls.Add(this.btnGenerateReport);
            this.groupBox6.Location = new System.Drawing.Point(1, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(990, 90);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Location = new System.Drawing.Point(7, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 74);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrado Por Fecha";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 29);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desde:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(31, 49);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(217, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(290, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 27);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasta";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(290, 48);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(213, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(814, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(87, 48);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Image = global::BPS.Lite.Properties.Resources.magnifier;
            this.btnGenerateReport.Location = new System.Drawing.Point(662, 25);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(89, 48);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Generar";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReprocessCoil
            // 
            this.dgvReprocessCoil.AllowUserToAddRows = false;
            this.dgvReprocessCoil.AllowUserToDeleteRows = false;
            this.dgvReprocessCoil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReprocessCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReprocessCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodBobina,
            this.clmPelicula,
            this.clmAncho,
            this.clmDiametro,
            this.clmCore,
            this.clmMetrOrg,
            this.clmMetrCons,
            this.clmPesoOrg,
            this.clmPesoCons,
            this.clmOrden,
            this.clmParada,
            this.clmFecha,
            this.clmCodsec});
            this.dgvReprocessCoil.Location = new System.Drawing.Point(8, 16);
            this.dgvReprocessCoil.Name = "dgvReprocessCoil";
            this.dgvReprocessCoil.ReadOnly = true;
            this.dgvReprocessCoil.Size = new System.Drawing.Size(982, 401);
            this.dgvReprocessCoil.TabIndex = 0;
            // 
            // clmCodBobina
            // 
            this.clmCodBobina.HeaderText = "Bobina";
            this.clmCodBobina.Name = "clmCodBobina";
            this.clmCodBobina.ReadOnly = true;
            this.clmCodBobina.Width = 65;
            // 
            // clmPelicula
            // 
            this.clmPelicula.HeaderText = "Pelicula";
            this.clmPelicula.Name = "clmPelicula";
            this.clmPelicula.ReadOnly = true;
            this.clmPelicula.Width = 69;
            // 
            // clmAncho
            // 
            this.clmAncho.HeaderText = "Ancho";
            this.clmAncho.Name = "clmAncho";
            this.clmAncho.ReadOnly = true;
            this.clmAncho.Width = 63;
            // 
            // clmDiametro
            // 
            this.clmDiametro.HeaderText = "Diametro";
            this.clmDiametro.Name = "clmDiametro";
            this.clmDiametro.ReadOnly = true;
            this.clmDiametro.Width = 74;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 54;
            // 
            // clmMetrOrg
            // 
            this.clmMetrOrg.HeaderText = "Metraje Original";
            this.clmMetrOrg.Name = "clmMetrOrg";
            this.clmMetrOrg.ReadOnly = true;
            this.clmMetrOrg.Width = 96;
            // 
            // clmMetrCons
            // 
            this.clmMetrCons.HeaderText = "Metraje Consumido";
            this.clmMetrCons.Name = "clmMetrCons";
            this.clmMetrCons.ReadOnly = true;
            this.clmMetrCons.Width = 112;
            // 
            // clmPesoOrg
            // 
            this.clmPesoOrg.HeaderText = "Peso Original";
            this.clmPesoOrg.Name = "clmPesoOrg";
            this.clmPesoOrg.ReadOnly = true;
            this.clmPesoOrg.Width = 87;
            // 
            // clmPesoCons
            // 
            this.clmPesoCons.HeaderText = "Peso Consumido";
            this.clmPesoCons.Name = "clmPesoCons";
            this.clmPesoCons.ReadOnly = true;
            this.clmPesoCons.Width = 102;
            // 
            // clmOrden
            // 
            this.clmOrden.HeaderText = "Orden Corte";
            this.clmOrden.Name = "clmOrden";
            this.clmOrden.ReadOnly = true;
            this.clmOrden.Width = 82;
            // 
            // clmParada
            // 
            this.clmParada.HeaderText = "Parada";
            this.clmParada.Name = "clmParada";
            this.clmParada.ReadOnly = true;
            this.clmParada.Width = 66;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 62;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 67;
            // 
            // frmReprocessCoilReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 505);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReprocessCoilReport";
            this.Text = "Reporte de Bobinas Re-Procesadas";
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReprocessCoil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReprocessCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodBobina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAncho;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetrOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetrCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPesoOrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPesoCons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmParada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
    }
}