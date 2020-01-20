namespace BPS
{
    partial class frmQualityControlsMainCoilsBoolean
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQualityControlsMainCoilsBoolean));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalMed = new System.Windows.Forms.TextBox();
            this.txtActualMedition = new System.Windows.Forms.TextBox();
            this.txtNameControl = new System.Windows.Forms.TextBox();
            this.chkValue = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilsControl = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilsControl)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtTotalMed);
            this.groupBox1.Controls.Add(this.txtActualMedition);
            this.groupBox1.Controls.Add(this.txtNameControl);
            this.groupBox1.Controls.Add(this.chkValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(381, 62);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 24);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalMed
            // 
            this.txtTotalMed.Location = new System.Drawing.Point(223, 25);
            this.txtTotalMed.Name = "txtTotalMed";
            this.txtTotalMed.Size = new System.Drawing.Size(61, 20);
            this.txtTotalMed.TabIndex = 7;
            // 
            // txtActualMedition
            // 
            this.txtActualMedition.Location = new System.Drawing.Point(74, 25);
            this.txtActualMedition.Name = "txtActualMedition";
            this.txtActualMedition.Size = new System.Drawing.Size(61, 20);
            this.txtActualMedition.TabIndex = 6;
            // 
            // txtNameControl
            // 
            this.txtNameControl.Location = new System.Drawing.Point(74, 65);
            this.txtNameControl.Name = "txtNameControl";
            this.txtNameControl.Size = new System.Drawing.Size(244, 20);
            this.txtNameControl.TabIndex = 5;
            // 
            // chkValue
            // 
            this.chkValue.AutoSize = true;
            this.chkValue.Location = new System.Drawing.Point(335, 67);
            this.chkValue.Name = "chkValue";
            this.chkValue.Size = new System.Drawing.Size(35, 17);
            this.chkValue.TabIndex = 4;
            this.chkValue.Text = "Si";
            this.chkValue.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medición:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvMainCoilsControl);
            this.groupBox2.Location = new System.Drawing.Point(3, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 229);
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
            this.clmCheck});
            this.dgvMainCoilsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoilsControl.Location = new System.Drawing.Point(3, 16);
            this.dgvMainCoilsControl.Name = "dgvMainCoilsControl";
            this.dgvMainCoilsControl.Size = new System.Drawing.Size(440, 210);
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
            this.clmMed.Width = 250;
            // 
            // clmCheck
            // 
            this.clmCheck.HeaderText = "Valor";
            this.clmCheck.Name = "clmCheck";
            // 
            // frmQualityControlsMainCoilsBoolean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 339);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQualityControlsMainCoilsBoolean";
            this.Text = "Control Si/No";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilsControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalMed;
        private System.Windows.Forms.TextBox txtActualMedition;
        private System.Windows.Forms.TextBox txtNameControl;
        private System.Windows.Forms.CheckBox chkValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMainCoilsControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMed;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCheck;
    }
}