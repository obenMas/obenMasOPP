namespace BPS
{
    partial class frmReportGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportGenerator));
            this.dateTPFromCutting = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateCuttingRp = new System.Windows.Forms.Button();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToCutting = new System.Windows.Forms.DateTimePicker();
            this.dgvReportGenerator = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Familia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportGenerator)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTPFromCutting
            // 
            this.dateTPFromCutting.Location = new System.Drawing.Point(6, 6);
            this.dateTPFromCutting.Name = "dateTPFromCutting";
            this.dateTPFromCutting.Size = new System.Drawing.Size(200, 20);
            this.dateTPFromCutting.TabIndex = 0;
            // 
            // btnGenerateCuttingRp
            // 
            this.btnGenerateCuttingRp.Location = new System.Drawing.Point(463, 24);
            this.btnGenerateCuttingRp.Name = "btnGenerateCuttingRp";
            this.btnGenerateCuttingRp.Size = new System.Drawing.Size(141, 42);
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
            this.groupBox2.Size = new System.Drawing.Size(215, 34);
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
            this.groupBox3.Size = new System.Drawing.Size(215, 34);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToCutting
            // 
            this.dateTPToCutting.Location = new System.Drawing.Point(6, 6);
            this.dateTPToCutting.Name = "dateTPToCutting";
            this.dateTPToCutting.Size = new System.Drawing.Size(200, 20);
            this.dateTPToCutting.TabIndex = 0;
            // 
            // dgvReportGenerator
            // 
            this.dgvReportGenerator.AllowUserToAddRows = false;
            this.dgvReportGenerator.AllowUserToDeleteRows = false;
            this.dgvReportGenerator.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvReportGenerator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportGenerator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Cliente,
            this.Familia,
            this.UDN,
            this.Cantidad,
            this.clmDay,
            this.clmMonth,
            this.clmYear,
            this.clmHour});
            this.dgvReportGenerator.Location = new System.Drawing.Point(10, 72);
            this.dgvReportGenerator.Name = "dgvReportGenerator";
            this.dgvReportGenerator.ReadOnly = true;
            this.dgvReportGenerator.Size = new System.Drawing.Size(629, 414);
            this.dgvReportGenerator.TabIndex = 8;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(610, 35);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 9;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 200;
            // 
            // Familia
            // 
            this.Familia.HeaderText = "Familia";
            this.Familia.Name = "Familia";
            this.Familia.ReadOnly = true;
            this.Familia.Width = 150;
            // 
            // UDN
            // 
            this.UDN.HeaderText = "Un. de Negocio";
            this.UDN.Name = "UDN";
            this.UDN.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
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
            // frmReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 498);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvReportGenerator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGenerateCuttingRp);
            this.Controls.Add(this.groupBoxFrom);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportGenerator";
            this.Text = "Reporte de Ingreso de pedidos";
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportGenerator)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dgvReportGenerator;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Familia;
        private System.Windows.Forms.DataGridViewTextBoxColumn UDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
    }
}