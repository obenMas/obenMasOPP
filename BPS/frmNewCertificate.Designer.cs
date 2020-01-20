namespace BPS
{
    partial class frmNewCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCertificate));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPreShipping = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLotNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCertificate = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNorm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAverage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificate)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPreShipping);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPreShipping
            // 
            this.txtPreShipping.Location = new System.Drawing.Point(91, 16);
            this.txtPreShipping.Name = "txtPreShipping";
            this.txtPreShipping.Size = new System.Drawing.Size(148, 20);
            this.txtPreShipping.TabIndex = 1;
            this.txtPreShipping.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPreShipping_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pre-Despacho:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLot);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbLotNumber);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(1, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(731, 61);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(311, 17);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(100, 20);
            this.txtLot.TabIndex = 3;
            this.txtLot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLot_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lote:";
            // 
            // cmbLotNumber
            // 
            this.cmbLotNumber.FormattingEnabled = true;
            this.cmbLotNumber.Location = new System.Drawing.Point(44, 17);
            this.cmbLotNumber.Name = "cmbLotNumber";
            this.cmbLotNumber.Size = new System.Drawing.Size(209, 21);
            this.cmbLotNumber.TabIndex = 1;
            this.cmbLotNumber.SelectedIndexChanged += new System.EventHandler(this.cmbLotNumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lote:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCertificate);
            this.groupBox3.Location = new System.Drawing.Point(1, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 335);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // dgvCertificate
            // 
            this.dgvCertificate.AllowUserToAddRows = false;
            this.dgvCertificate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmLot,
            this.clmName,
            this.clmNorm,
            this.clmUnit,
            this.clmAverage,
            this.clmMin,
            this.clmMax});
            this.dgvCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCertificate.Location = new System.Drawing.Point(3, 16);
            this.dgvCertificate.Name = "dgvCertificate";
            this.dgvCertificate.Size = new System.Drawing.Size(725, 316);
            this.dgvCertificate.TabIndex = 0;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(630, 467);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(75, 23);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generar CC";
            this.toolTip1.SetToolTip(this.btnReport, "Genera el Certificado de Calidad");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmLot
            // 
            this.clmLot.HeaderText = "Lote";
            this.clmLot.Name = "clmLot";
            this.clmLot.Visible = false;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.Width = 300;
            // 
            // clmNorm
            // 
            this.clmNorm.HeaderText = "Norma";
            this.clmNorm.Name = "clmNorm";
            this.clmNorm.Width = 150;
            // 
            // clmUnit
            // 
            this.clmUnit.HeaderText = "Unidad";
            this.clmUnit.Name = "clmUnit";
            this.clmUnit.Width = 80;
            // 
            // clmAverage
            // 
            this.clmAverage.HeaderText = "Promedio";
            this.clmAverage.Name = "clmAverage";
            this.clmAverage.Width = 80;
            // 
            // clmMin
            // 
            this.clmMin.HeaderText = "Mínimo";
            this.clmMin.Name = "clmMin";
            this.clmMin.Width = 80;
            // 
            // clmMax
            // 
            this.clmMax.HeaderText = "Máximo";
            this.clmMax.Name = "clmMax";
            this.clmMax.Width = 80;
            // 
            // frmNewCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 502);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNewCertificate";
            this.Text = "Certificado de Calidad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreShipping;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLotNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCertificate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNorm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAverage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMax;
    }
}