namespace BPS
{
    partial class frmProgrammingReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgrammingReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProgrammingReport = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSuprFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clmCombination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProgrammedWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnchoBobinaMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalidadBobinaMadre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProgrammedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrammingReport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProgrammingReport);
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvProgrammingReport
            // 
            this.dgvProgrammingReport.AllowUserToAddRows = false;
            this.dgvProgrammingReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvProgrammingReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgrammingReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCombination,
            this.clmCutter,
            this.clmProgrammedWeight,
            this.Pelicula,
            this.AnchoBobinaMadre,
            this.clmReps,
            this.clmKg,
            this.CalidadBobinaMadre,
            this.clmStatus,
            this.clmProgrammedDate,
            this.clmDay,
            this.clmMonth,
            this.clmYear,
            this.clmHour,
            this.clmDiameter});
            this.dgvProgrammingReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgrammingReport.Location = new System.Drawing.Point(3, 16);
            this.dgvProgrammingReport.Name = "dgvProgrammingReport";
            this.dgvProgrammingReport.Size = new System.Drawing.Size(703, 320);
            this.dgvProgrammingReport.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSuprFilter);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpTo);
            this.groupBox2.Controls.Add(this.dtpFrom);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Location = new System.Drawing.Point(4, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSuprFilter
            // 
            this.btnSuprFilter.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnSuprFilter.Location = new System.Drawing.Point(636, 21);
            this.btnSuprFilter.Name = "btnSuprFilter";
            this.btnSuprFilter.Size = new System.Drawing.Size(25, 25);
            this.btnSuprFilter.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSuprFilter, "Quitar Filtro");
            this.btnSuprFilter.UseVisualStyleBackColor = true;
            this.btnSuprFilter.Click += new System.EventHandler(this.btnSuprFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(531, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desde:";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(315, 22);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(55, 22);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(673, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnExport, "Exportar a Excel");
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // clmCombination
            // 
            this.clmCombination.HeaderText = "Combinacion";
            this.clmCombination.Name = "clmCombination";
            // 
            // clmCutter
            // 
            this.clmCutter.HeaderText = "Cortadora";
            this.clmCutter.Name = "clmCutter";
            // 
            // clmProgrammedWeight
            // 
            this.clmProgrammedWeight.HeaderText = "AnchoProgramado";
            this.clmProgrammedWeight.Name = "clmProgrammedWeight";
            this.clmProgrammedWeight.Width = 110;
            // 
            // Pelicula
            // 
            this.Pelicula.HeaderText = "Pelicula";
            this.Pelicula.Name = "Pelicula";
            // 
            // AnchoBobinaMadre
            // 
            this.AnchoBobinaMadre.HeaderText = "Ancho BM";
            this.AnchoBobinaMadre.Name = "AnchoBobinaMadre";
            // 
            // clmReps
            // 
            this.clmReps.HeaderText = "Repeticiones";
            this.clmReps.Name = "clmReps";
            // 
            // clmKg
            // 
            this.clmKg.HeaderText = "KilosProgramados";
            this.clmKg.Name = "clmKg";
            this.clmKg.Width = 110;
            // 
            // CalidadBobinaMadre
            // 
            this.CalidadBobinaMadre.HeaderText = "Calidad Bobina Madre";
            this.CalidadBobinaMadre.Name = "CalidadBobinaMadre";
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            // 
            // clmProgrammedDate
            // 
            this.clmProgrammedDate.HeaderText = "FechaProgramación";
            this.clmProgrammedDate.Name = "clmProgrammedDate";
            this.clmProgrammedDate.Width = 120;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "Dia";
            this.clmDay.Name = "clmDay";
            this.clmDay.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "Mes";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.Visible = false;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Año";
            this.clmYear.Name = "clmYear";
            this.clmYear.Visible = false;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.Visible = false;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.Visible = false;
            // 
            // frmProgrammingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgrammingReport";
            this.Text = "Reporte de Programación";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgrammingReport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProgrammingReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSuprFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCombination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProgrammedWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnchoBobinaMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReps;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKg;
        private System.Windows.Forms.DataGridViewTextBoxColumn CalidadBobinaMadre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProgrammedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
    }
}