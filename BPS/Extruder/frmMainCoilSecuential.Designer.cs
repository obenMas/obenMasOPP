namespace BPS
{
    partial class frmMainCoilSecuential
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilSecuential));
            this.lblDMT = new System.Windows.Forms.Label();
            this.lblMarshall = new System.Windows.Forms.Label();
            this.nudDMT = new System.Windows.Forms.NumericUpDown();
            this.nudMW = new System.Windows.Forms.NumericUpDown();
            this.btnMW = new System.Windows.Forms.Button();
            this.btnDMT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDMT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMW)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDMT
            // 
            this.lblDMT.AutoSize = true;
            this.lblDMT.Location = new System.Drawing.Point(22, 13);
            this.lblDMT.Name = "lblDMT";
            this.lblDMT.Size = new System.Drawing.Size(34, 15);
            this.lblDMT.TabIndex = 0;
            this.lblDMT.Text = "DMT";
            // 
            // lblMarshall
            // 
            this.lblMarshall.AutoSize = true;
            this.lblMarshall.Location = new System.Drawing.Point(22, 39);
            this.lblMarshall.Name = "lblMarshall";
            this.lblMarshall.Size = new System.Drawing.Size(116, 15);
            this.lblMarshall.TabIndex = 0;
            this.lblMarshall.Text = "Marshall && Williams";
            // 
            // nudDMT
            // 
            this.nudDMT.Location = new System.Drawing.Point(160, 10);
            this.nudDMT.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDMT.Name = "nudDMT";
            this.nudDMT.Size = new System.Drawing.Size(96, 21);
            this.nudDMT.TabIndex = 1;
            // 
            // nudMW
            // 
            this.nudMW.Location = new System.Drawing.Point(160, 36);
            this.nudMW.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMW.Name = "nudMW";
            this.nudMW.Size = new System.Drawing.Size(96, 21);
            this.nudMW.TabIndex = 2;
            // 
            // btnMW
            // 
            this.btnMW.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMW.BackgroundImage")));
            this.btnMW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMW.Location = new System.Drawing.Point(278, 34);
            this.btnMW.Name = "btnMW";
            this.btnMW.Size = new System.Drawing.Size(25, 25);
            this.btnMW.TabIndex = 4;
            this.btnMW.UseVisualStyleBackColor = true;
            this.btnMW.Click += new System.EventHandler(this.btnMW_Click);
            // 
            // btnDMT
            // 
            this.btnDMT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDMT.BackgroundImage")));
            this.btnDMT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDMT.Location = new System.Drawing.Point(278, 8);
            this.btnDMT.Name = "btnDMT";
            this.btnDMT.Size = new System.Drawing.Size(25, 25);
            this.btnDMT.TabIndex = 3;
            this.btnDMT.UseVisualStyleBackColor = true;
            this.btnDMT.Click += new System.EventHandler(this.btnDMT_Click);
            // 
            // frmMainCoilSecuential
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(324, 70);
            this.Controls.Add(this.btnMW);
            this.Controls.Add(this.btnDMT);
            this.Controls.Add(this.nudMW);
            this.Controls.Add(this.nudDMT);
            this.Controls.Add(this.lblMarshall);
            this.Controls.Add(this.lblDMT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilSecuential";
            this.Text = "Secuencial de bobina madre";
            this.Load += new System.EventHandler(this.frmMainCoilSecuential_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDMT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDMT;
        private System.Windows.Forms.Label lblMarshall;
        private System.Windows.Forms.NumericUpDown nudDMT;
        private System.Windows.Forms.NumericUpDown nudMW;
        private System.Windows.Forms.Button btnDMT;
        private System.Windows.Forms.Button btnMW;
    }
}