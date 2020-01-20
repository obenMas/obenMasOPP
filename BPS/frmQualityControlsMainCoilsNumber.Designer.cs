namespace BPS
{
    partial class frmQualityControlsMainCoilsNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQualityControlsMainCoilsNumber));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtTotalMed = new System.Windows.Forms.TextBox();
            this.txtActualMedition = new System.Windows.Forms.TextBox();
            this.txtNameControl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilsControl = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilsControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtTotalMed);
            this.groupBox1.Controls.Add(this.txtActualMedition);
            this.groupBox1.Controls.Add(this.txtNameControl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(312, 74);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(52, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // txtTotalMed
            // 
            this.txtTotalMed.Location = new System.Drawing.Point(206, 28);
            this.txtTotalMed.Name = "txtTotalMed";
            this.txtTotalMed.Size = new System.Drawing.Size(61, 20);
            this.txtTotalMed.TabIndex = 7;
            // 
            // txtActualMedition
            // 
            this.txtActualMedition.Location = new System.Drawing.Point(74, 29);
            this.txtActualMedition.Name = "txtActualMedition";
            this.txtActualMedition.Size = new System.Drawing.Size(61, 20);
            this.txtActualMedition.TabIndex = 5;
            // 
            // txtNameControl
            // 
            this.txtNameControl.Location = new System.Drawing.Point(76, 74);
            this.txtNameControl.Name = "txtNameControl";
            this.txtNameControl.Size = new System.Drawing.Size(209, 20);
            this.txtNameControl.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Medición:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Control:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMainCoilsControl);
            this.groupBox2.Location = new System.Drawing.Point(3, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvMainCoilsControl
            // 
            this.dgvMainCoilsControl.AllowUserToAddRows = false;
            this.dgvMainCoilsControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilsControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmMed,
            this.clmValue});
            this.dgvMainCoilsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilsControl.Location = new System.Drawing.Point(3, 16);
            this.dgvMainCoilsControl.Name = "dgvMainCoilsControl";
            this.dgvMainCoilsControl.Size = new System.Drawing.Size(444, 282);
            this.dgvMainCoilsControl.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 300;
            // 
            // clmMed
            // 
            this.clmMed.HeaderText = "Med";
            this.clmMed.Name = "clmMed";
            // 
            // clmValue
            // 
            this.clmValue.HeaderText = "Valor";
            this.clmValue.Name = "clmValue";
            this.clmValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmValue.Width = 300;
            // 
            // frmQualityControlsMainCoilsNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQualityControlsMainCoilsNumber";
            this.Text = "Control Número";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilsControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTotalMed;
        private System.Windows.Forms.TextBox txtActualMedition;
        private System.Windows.Forms.TextBox txtNameControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMainCoilsControl;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmValue;
    }
}