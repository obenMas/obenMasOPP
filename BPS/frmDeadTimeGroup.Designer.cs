namespace BPS
{
    partial class frmDeadTimeGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeadTimeGroup));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDeadTime = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpDeadTime = new System.Windows.Forms.TabPage();
            this.btnAddDT = new System.Windows.Forms.Button();
            this.tbpDeadTimePlus = new System.Windows.Forms.TabPage();
            this.chkisEnable = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numhour = new System.Windows.Forms.NumericUpDown();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numminutes = new System.Windows.Forms.NumericUpDown();
            this.txtnotes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numday = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tbpDeadTime.SuspendLayout();
            this.tbpDeadTimePlus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numminutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numday)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Causa";
            // 
            // cmbDeadTime
            // 
            this.cmbDeadTime.FormattingEnabled = true;
            this.cmbDeadTime.Location = new System.Drawing.Point(136, 28);
            this.cmbDeadTime.Name = "cmbDeadTime";
            this.cmbDeadTime.Size = new System.Drawing.Size(258, 23);
            this.cmbDeadTime.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(136, 57);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(258, 96);
            this.txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiempo Muerto";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpDeadTime);
            this.tabControl1.Controls.Add(this.tbpDeadTimePlus);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 262);
            this.tabControl1.TabIndex = 4;
            // 
            // tbpDeadTime
            // 
            this.tbpDeadTime.Controls.Add(this.btnAddDT);
            this.tbpDeadTime.Controls.Add(this.label1);
            this.tbpDeadTime.Controls.Add(this.label2);
            this.tbpDeadTime.Controls.Add(this.txtDescription);
            this.tbpDeadTime.Controls.Add(this.cmbDeadTime);
            this.tbpDeadTime.Location = new System.Drawing.Point(4, 24);
            this.tbpDeadTime.Name = "tbpDeadTime";
            this.tbpDeadTime.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeadTime.Size = new System.Drawing.Size(432, 234);
            this.tbpDeadTime.TabIndex = 0;
            this.tbpDeadTime.Text = "Tiempos Muertos";
            this.tbpDeadTime.UseVisualStyleBackColor = true;
            // 
            // btnAddDT
            // 
            this.btnAddDT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDT.Image = global::BPS.Properties.Resources.disk;
            this.btnAddDT.Location = new System.Drawing.Point(369, 173);
            this.btnAddDT.Name = "btnAddDT";
            this.btnAddDT.Size = new System.Drawing.Size(25, 25);
            this.btnAddDT.TabIndex = 7;
            this.btnAddDT.UseVisualStyleBackColor = true;
            this.btnAddDT.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbpDeadTimePlus
            // 
            this.tbpDeadTimePlus.Controls.Add(this.chkisEnable);
            this.tbpDeadTimePlus.Controls.Add(this.label3);
            this.tbpDeadTimePlus.Controls.Add(this.numhour);
            this.tbpDeadTimePlus.Controls.Add(this.btnAddNew);
            this.tbpDeadTimePlus.Controls.Add(this.label8);
            this.tbpDeadTimePlus.Controls.Add(this.label7);
            this.tbpDeadTimePlus.Controls.Add(this.label6);
            this.tbpDeadTimePlus.Controls.Add(this.numminutes);
            this.tbpDeadTimePlus.Controls.Add(this.txtnotes);
            this.tbpDeadTimePlus.Controls.Add(this.label5);
            this.tbpDeadTimePlus.Controls.Add(this.numday);
            this.tbpDeadTimePlus.Controls.Add(this.label4);
            this.tbpDeadTimePlus.Controls.Add(this.txtname);
            this.tbpDeadTimePlus.Controls.Add(this.lbltype);
            this.tbpDeadTimePlus.Controls.Add(this.cmbtype);
            this.tbpDeadTimePlus.Location = new System.Drawing.Point(4, 24);
            this.tbpDeadTimePlus.Name = "tbpDeadTimePlus";
            this.tbpDeadTimePlus.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDeadTimePlus.Size = new System.Drawing.Size(432, 234);
            this.tbpDeadTimePlus.TabIndex = 1;
            this.tbpDeadTimePlus.Text = "Tiempos Muertos";
            this.tbpDeadTimePlus.UseVisualStyleBackColor = true;
            // 
            // chkisEnable
            // 
            this.chkisEnable.AutoSize = true;
            this.chkisEnable.Checked = true;
            this.chkisEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkisEnable.Location = new System.Drawing.Point(114, 159);
            this.chkisEnable.Name = "chkisEnable";
            this.chkisEnable.Size = new System.Drawing.Size(111, 19);
            this.chkisEnable.TabIndex = 21;
            this.chkisEnable.Text = "Aplica Estándar";
            this.chkisEnable.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Días";
            // 
            // numhour
            // 
            this.numhour.Location = new System.Drawing.Point(186, 182);
            this.numhour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numhour.Name = "numhour";
            this.numhour.Size = new System.Drawing.Size(53, 21);
            this.numhour.TabIndex = 17;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.Image = global::BPS.Properties.Resources.disk;
            this.btnAddNew.Location = new System.Drawing.Point(391, 185);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(25, 25);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Minutos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Horas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Estándar";
            // 
            // numminutes
            // 
            this.numminutes.Location = new System.Drawing.Point(259, 182);
            this.numminutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numminutes.Name = "numminutes";
            this.numminutes.Size = new System.Drawing.Size(53, 21);
            this.numminutes.TabIndex = 11;
            // 
            // txtnotes
            // 
            this.txtnotes.Location = new System.Drawing.Point(114, 97);
            this.txtnotes.Multiline = true;
            this.txtnotes.Name = "txtnotes";
            this.txtnotes.Size = new System.Drawing.Size(302, 56);
            this.txtnotes.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripción";
            // 
            // numday
            // 
            this.numday.Location = new System.Drawing.Point(114, 182);
            this.numday.Name = "numday";
            this.numday.Size = new System.Drawing.Size(53, 21);
            this.numday.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(114, 35);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(302, 56);
            this.txtname.TabIndex = 5;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(17, 9);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(91, 15);
            this.lbltype.TabIndex = 3;
            this.lbltype.Text = "Tiempo Muerto";
            // 
            // cmbtype
            // 
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(114, 6);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(302, 23);
            this.cmbtype.TabIndex = 4;
            // 
            // frmDeadTimeGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(440, 262);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeadTimeGroup";
            this.Text = "Tiempos Muertos";
            this.Load += new System.EventHandler(this.frmDeadTimeGroup_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpDeadTime.ResumeLayout(false);
            this.tbpDeadTime.PerformLayout();
            this.tbpDeadTimePlus.ResumeLayout(false);
            this.tbpDeadTimePlus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numminutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDeadTime;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpDeadTime;
        private System.Windows.Forms.TabPage tbpDeadTimePlus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numminutes;
        private System.Windows.Forms.TextBox txtnotes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Button btnAddDT;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numhour;
        private System.Windows.Forms.CheckBox chkisEnable;
    }
}