namespace BPS
{
    partial class frmMainCoilsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilsControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNetWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMainCoil = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.txtIniDate = new System.Windows.Forms.TextBox();
            this.txtBopp = new System.Windows.Forms.TextBox();
            this.cmbMainCoils = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilsControl = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmControlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTypeControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBopCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMedNec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNew = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmReport = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilsControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNetWeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLotNumber);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMainCoil);
            this.groupBox1.Controls.Add(this.txtEndDate);
            this.groupBox1.Controls.Add(this.txtIniDate);
            this.groupBox1.Controls.Add(this.txtBopp);
            this.groupBox1.Controls.Add(this.cmbMainCoils);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtNetWeight
            // 
            this.txtNetWeight.Location = new System.Drawing.Point(513, 60);
            this.txtNetWeight.Name = "txtNetWeight";
            this.txtNetWeight.Size = new System.Drawing.Size(113, 20);
            this.txtNetWeight.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Peso Neto:";
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Location = new System.Drawing.Point(258, 60);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(167, 20);
            this.txtLotNumber.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lote:";
            // 
            // txtMainCoil
            // 
            this.txtMainCoil.Location = new System.Drawing.Point(60, 60);
            this.txtMainCoil.Name = "txtMainCoil";
            this.txtMainCoil.Size = new System.Drawing.Size(119, 20);
            this.txtMainCoil.TabIndex = 9;
            this.txtMainCoil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCoil_KeyDown);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(513, 21);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(113, 20);
            this.txtEndDate.TabIndex = 8;
            // 
            // txtIniDate
            // 
            this.txtIniDate.Location = new System.Drawing.Point(375, 20);
            this.txtIniDate.Name = "txtIniDate";
            this.txtIniDate.Size = new System.Drawing.Size(102, 20);
            this.txtIniDate.TabIndex = 7;
            // 
            // txtBopp
            // 
            this.txtBopp.Location = new System.Drawing.Point(258, 20);
            this.txtBopp.Name = "txtBopp";
            this.txtBopp.Size = new System.Drawing.Size(75, 20);
            this.txtBopp.TabIndex = 6;
            // 
            // cmbMainCoils
            // 
            this.cmbMainCoils.FormattingEnabled = true;
            this.cmbMainCoils.Location = new System.Drawing.Point(59, 20);
            this.cmbMainCoils.Name = "cmbMainCoils";
            this.cmbMainCoils.Size = new System.Drawing.Size(120, 21);
            this.cmbMainCoils.TabIndex = 5;
            this.cmbMainCoils.SelectedIndexChanged += new System.EventHandler(this.cmbCoils_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bobina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelicula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bobina:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMainCoilsControl);
            this.groupBox2.Location = new System.Drawing.Point(4, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvMainCoilsControl
            // 
            this.dgvMainCoilsControl.AllowUserToAddRows = false;
            this.dgvMainCoilsControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilsControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmControlName,
            this.clmTypeControl,
            this.clmfkBopp,
            this.clmBopCode,
            this.clmCantMed,
            this.clmMedNec,
            this.clmMin,
            this.clmMax,
            this.clmNew,
            this.clmReport});
            this.dgvMainCoilsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilsControl.Location = new System.Drawing.Point(3, 16);
            this.dgvMainCoilsControl.Name = "dgvMainCoilsControl";
            this.dgvMainCoilsControl.Size = new System.Drawing.Size(669, 375);
            this.dgvMainCoilsControl.TabIndex = 0;
            this.dgvMainCoilsControl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainCoilsControl_CellContentClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmControlName
            // 
            this.clmControlName.HeaderText = "Nombre Control";
            this.clmControlName.Name = "clmControlName";
            this.clmControlName.Width = 250;
            // 
            // clmTypeControl
            // 
            this.clmTypeControl.HeaderText = "Tipo Control";
            this.clmTypeControl.Name = "clmTypeControl";
            this.clmTypeControl.Visible = false;
            // 
            // clmfkBopp
            // 
            this.clmfkBopp.HeaderText = "fkBopp";
            this.clmfkBopp.Name = "clmfkBopp";
            this.clmfkBopp.Visible = false;
            // 
            // clmBopCode
            // 
            this.clmBopCode.HeaderText = "BopCode";
            this.clmBopCode.Name = "clmBopCode";
            this.clmBopCode.Visible = false;
            // 
            // clmCantMed
            // 
            this.clmCantMed.HeaderText = "Cant Mediciones";
            this.clmCantMed.Name = "clmCantMed";
            // 
            // clmMedNec
            // 
            this.clmMedNec.HeaderText = "Med Necesarias";
            this.clmMedNec.Name = "clmMedNec";
            // 
            // clmMin
            // 
            this.clmMin.HeaderText = "Val Min";
            this.clmMin.Name = "clmMin";
            this.clmMin.Width = 80;
            // 
            // clmMax
            // 
            this.clmMax.HeaderText = "Val Max";
            this.clmMax.Name = "clmMax";
            this.clmMax.Width = 80;
            // 
            // clmNew
            // 
            this.clmNew.HeaderText = "";
            this.clmNew.Image = global::BPS.Properties.Resources.quality;
            this.clmNew.Name = "clmNew";
            this.clmNew.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmNew.Width = 90;
            // 
            // clmReport
            // 
            this.clmReport.HeaderText = "Reporte";
            this.clmReport.Image = global::BPS.Properties.Resources.report;
            this.clmReport.Name = "clmReport";
            // 
            // frmMainCoilsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilsControl";
            this.Text = "Control de Bobinas Madre";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilsControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMainCoilsControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNetWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMainCoil;
        private System.Windows.Forms.TextBox txtEndDate;
        private System.Windows.Forms.TextBox txtIniDate;
        private System.Windows.Forms.TextBox txtBopp;
        private System.Windows.Forms.ComboBox cmbMainCoils;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmControlName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTypeControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBopCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMedNec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMax;
        private System.Windows.Forms.DataGridViewImageColumn clmNew;
        private System.Windows.Forms.DataGridViewImageColumn clmReport;
    }
}