namespace BPS
{
    partial class frmShippingReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingReport));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvShippingReport = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPlants = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.clmPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustommerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSordNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippingReport)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvShippingReport);
            this.groupBox7.Location = new System.Drawing.Point(5, 78);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(840, 381);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // dgvShippingReport
            // 
            this.dgvShippingReport.AllowUserToAddRows = false;
            this.dgvShippingReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvShippingReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShippingReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPallet,
            this.clmCustommerName,
            this.clmSordNumber,
            this.clmProductCode,
            this.clmWeight,
            this.clmDate,
            this.clmHour,
            this.clmPlant,
            this.clmRemito,
            this.clmDay,
            this.clmMonth,
            this.clmYear});
            this.dgvShippingReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShippingReport.Location = new System.Drawing.Point(3, 16);
            this.dgvShippingReport.Name = "dgvShippingReport";
            this.dgvShippingReport.Size = new System.Drawing.Size(834, 362);
            this.dgvShippingReport.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox4);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.cmbPlants);
            this.groupBox6.Controls.Add(this.btnExport);
            this.groupBox6.Controls.Add(this.btnGenerateReport);
            this.groupBox6.Controls.Add(this.dtpTo);
            this.groupBox6.Controls.Add(this.dtpFrom);
            this.groupBox6.Location = new System.Drawing.Point(5, -2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(840, 80);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(535, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 27);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Planta";
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(277, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 27);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasta";
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 27);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desde:";
            // 
            // cmbPlants
            // 
            this.cmbPlants.FormattingEnabled = true;
            this.cmbPlants.Location = new System.Drawing.Point(535, 46);
            this.cmbPlants.Name = "cmbPlants";
            this.cmbPlants.Size = new System.Drawing.Size(168, 21);
            this.cmbPlants.TabIndex = 12;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(806, 49);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 11;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(743, 19);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(88, 24);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Generar";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(277, 47);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(213, 20);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(16, 47);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(217, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // clmPallet
            // 
            this.clmPallet.HeaderText = "Pallet";
            this.clmPallet.Name = "clmPallet";
            // 
            // clmCustommerName
            // 
            this.clmCustommerName.HeaderText = "Cliente";
            this.clmCustommerName.Name = "clmCustommerName";
            this.clmCustommerName.Width = 200;
            // 
            // clmSordNumber
            // 
            this.clmSordNumber.HeaderText = "Pedido";
            this.clmSordNumber.Name = "clmSordNumber";
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.Width = 120;
            // 
            // clmWeight
            // 
            this.clmWeight.HeaderText = "Peso";
            this.clmWeight.Name = "clmWeight";
            this.clmWeight.Width = 70;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 80;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.Width = 60;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.Width = 80;
            // 
            // clmRemito
            // 
            this.clmRemito.HeaderText = "Remito";
            this.clmRemito.Name = "clmRemito";
            this.clmRemito.Width = 70;
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
            // frmShippingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 464);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingReport";
            this.Text = "Reporte de Despachos";
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShippingReport)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvShippingReport;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbPlants;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustommerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSordNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
    }
}