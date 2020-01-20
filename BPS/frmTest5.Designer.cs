namespace BPS
{
    partial class frmTest5
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
            this.pnlShortcuts = new System.Windows.Forms.Panel();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.btnMainCoilRegistration = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlShortcuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlShortcuts
            // 
            this.pnlShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShortcuts.Controls.Add(this.label2);
            this.pnlShortcuts.Controls.Add(this.label1);
            this.pnlShortcuts.Controls.Add(this.label3);
            this.pnlShortcuts.Controls.Add(this.lblMachineName);
            this.pnlShortcuts.Controls.Add(this.button1);
            this.pnlShortcuts.Controls.Add(this.btnMainCoilRegistration);
            this.pnlShortcuts.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShortcuts.Location = new System.Drawing.Point(0, 0);
            this.pnlShortcuts.Name = "pnlShortcuts";
            this.pnlShortcuts.Size = new System.Drawing.Size(95, 458);
            this.pnlShortcuts.TabIndex = 0;
            this.pnlShortcuts.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShortcuts_Paint);
            // 
            // lblMachineName
            // 
            this.lblMachineName.Location = new System.Drawing.Point(12, 77);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(70, 17);
            this.lblMachineName.TabIndex = 1;
            this.lblMachineName.Text = "DMT";
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainCoilRegistration
            // 
            this.btnMainCoilRegistration.Image = global::BPS.Properties.Resources.add_coil24;
            this.btnMainCoilRegistration.Location = new System.Drawing.Point(27, 34);
            this.btnMainCoilRegistration.Name = "btnMainCoilRegistration";
            this.btnMainCoilRegistration.Size = new System.Drawing.Size(40, 40);
            this.btnMainCoilRegistration.TabIndex = 0;
            this.btnMainCoilRegistration.UseVisualStyleBackColor = true;
            this.btnMainCoilRegistration.Click += new System.EventHandler(this.btnMainCoilRegistration_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BPS.Properties.Resources.add_coil24;
            this.button1.Location = new System.Drawing.Point(27, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnMainCoilRegistration_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DMT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 4);
            this.label2.TabIndex = 2;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cortadora 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTest5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(677, 458);
            this.Controls.Add(this.pnlShortcuts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTest5";
            this.Text = "frmTest5";
            this.pnlShortcuts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShortcuts;
        private System.Windows.Forms.Button btnMainCoilRegistration;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}