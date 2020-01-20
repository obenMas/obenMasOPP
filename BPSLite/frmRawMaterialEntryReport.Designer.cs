namespace BPS.Lite
{
    partial class frmRawMaterialEntryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialEntryReport));
            this.btnExport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvEntryReport = new System.Windows.Forms.DataGridView();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToEntry = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnGenerateEntryReport = new System.Windows.Forms.Button();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTPFromEntry = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.clmCodigoMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPesoMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryReport)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(809, 36);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 20;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(488, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Planta:";
            // 
            // dgvEntryReport
            // 
            this.dgvEntryReport.AllowUserToAddRows = false;
            this.dgvEntryReport.AllowUserToDeleteRows = false;
            this.dgvEntryReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntryReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvEntryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoMP,
            this.clmNomMP,
            this.clmPesoMP,
            this.clmUsuario,
            this.clmFecha,
            this.clmDay,
            this.clmMonth,
            this.clmYear,
            this.clmHour,
            this.clmLote,
            this.clmPlanta});
            this.dgvEntryReport.Location = new System.Drawing.Point(12, 97);
            this.dgvEntryReport.Name = "dgvEntryReport";
            this.dgvEntryReport.ReadOnly = true;
            this.dgvEntryReport.Size = new System.Drawing.Size(1038, 406);
            this.dgvEntryReport.TabIndex = 19;
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(491, 47);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(103, 21);
            this.cmbPlant.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTPToEntry);
            this.groupBox3.Location = new System.Drawing.Point(242, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 37);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToEntry
            // 
            this.dateTPToEntry.Location = new System.Drawing.Point(6, 11);
            this.dateTPToEntry.Name = "dateTPToEntry";
            this.dateTPToEntry.Size = new System.Drawing.Size(200, 20);
            this.dateTPToEntry.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Location = new System.Drawing.Point(242, 11);
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
            // btnGenerateEntryReport
            // 
            this.btnGenerateEntryReport.Location = new System.Drawing.Point(662, 27);
            this.btnGenerateEntryReport.Name = "btnGenerateEntryReport";
            this.btnGenerateEntryReport.Size = new System.Drawing.Size(128, 42);
            this.btnGenerateEntryReport.TabIndex = 12;
            this.btnGenerateEntryReport.Text = "Generar";
            this.btnGenerateEntryReport.UseVisualStyleBackColor = true;
            this.btnGenerateEntryReport.Click += new System.EventHandler(this.btnGenerateEntryReport_Click);
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.lblFrom);
            this.groupBoxFrom.Location = new System.Drawing.Point(10, 11);
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
            this.groupBox2.Controls.Add(this.dateTPFromEntry);
            this.groupBox2.Location = new System.Drawing.Point(10, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 37);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // dateTPFromEntry
            // 
            this.dateTPFromEntry.Location = new System.Drawing.Point(6, 12);
            this.dateTPFromEntry.Name = "dateTPFromEntry";
            this.dateTPFromEntry.Size = new System.Drawing.Size(200, 20);
            this.dateTPFromEntry.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnExport);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.cmbPlant);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnGenerateEntryReport);
            this.groupBox4.Controls.Add(this.groupBoxFrom);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(12, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1037, 81);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // clmCodigoMP
            // 
            this.clmCodigoMP.HeaderText = "Código";
            this.clmCodigoMP.Name = "clmCodigoMP";
            this.clmCodigoMP.ReadOnly = true;
            this.clmCodigoMP.Width = 65;
            // 
            // clmNomMP
            // 
            this.clmNomMP.HeaderText = "Nombre Materia Prima";
            this.clmNomMP.Name = "clmNomMP";
            this.clmNomMP.ReadOnly = true;
            this.clmNomMP.Width = 101;
            // 
            // clmPesoMP
            // 
            this.clmPesoMP.HeaderText = "Peso Neto";
            this.clmPesoMP.Name = "clmPesoMP";
            this.clmPesoMP.ReadOnly = true;
            this.clmPesoMP.Width = 76;
            // 
            // clmUsuario
            // 
            this.clmUsuario.HeaderText = "Usuario";
            this.clmUsuario.Name = "clmUsuario";
            this.clmUsuario.ReadOnly = true;
            this.clmUsuario.Width = 68;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 62;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "Dia";
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            this.clmDay.Visible = false;
            this.clmDay.Width = 48;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "Mes";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            this.clmMonth.Visible = false;
            this.clmMonth.Width = 52;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Año";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Visible = false;
            this.clmYear.Width = 51;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            this.clmHour.Visible = false;
            this.clmHour.Width = 55;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 53;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            this.clmPlanta.Width = 62;
            // 
            // frmRawMaterialEntryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 508);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgvEntryReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialEntryReport";
            this.Text = "Reporte de Ingresos Totalizados por Materia Prima";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryReport)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvEntryReport;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTPToEntry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnGenerateEntryReport;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTPFromEntry;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPesoMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
    }
}