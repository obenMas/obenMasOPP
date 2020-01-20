namespace BPS.Lite
{
    partial class frmCutterSelector
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
            this.lblArms = new System.Windows.Forms.Label();
            this.lblUtilWidth = new System.Windows.Forms.Label();
            this.lblArmsLabel = new System.Windows.Forms.Label();
            this.lblUtilWidthLabel = new System.Windows.Forms.Label();
            this.lblCutter = new System.Windows.Forms.Label();
            this.cmbCutter = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArms
            // 
            this.lblArms.BackColor = System.Drawing.SystemColors.Window;
            this.lblArms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArms.Location = new System.Drawing.Point(482, 13);
            this.lblArms.Name = "lblArms";
            this.lblArms.Size = new System.Drawing.Size(39, 21);
            this.lblArms.TabIndex = 25;
            this.lblArms.Tag = "clearOnReload";
            this.lblArms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUtilWidth
            // 
            this.lblUtilWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUtilWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUtilWidth.Location = new System.Drawing.Point(313, 13);
            this.lblUtilWidth.Name = "lblUtilWidth";
            this.lblUtilWidth.Size = new System.Drawing.Size(83, 21);
            this.lblUtilWidth.TabIndex = 21;
            this.lblUtilWidth.Tag = "clearOnReload";
            this.lblUtilWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArmsLabel
            // 
            this.lblArmsLabel.AutoSize = true;
            this.lblArmsLabel.Location = new System.Drawing.Point(404, 16);
            this.lblArmsLabel.Name = "lblArmsLabel";
            this.lblArmsLabel.Size = new System.Drawing.Size(70, 15);
            this.lblArmsLabel.TabIndex = 24;
            this.lblArmsLabel.Text = "Nro. brazos";
            // 
            // lblUtilWidthLabel
            // 
            this.lblUtilWidthLabel.AutoSize = true;
            this.lblUtilWidthLabel.Location = new System.Drawing.Point(245, 16);
            this.lblUtilWidthLabel.Name = "lblUtilWidthLabel";
            this.lblUtilWidthLabel.Size = new System.Drawing.Size(60, 15);
            this.lblUtilWidthLabel.TabIndex = 22;
            this.lblUtilWidthLabel.Text = "Ancho útil";
            // 
            // lblCutter
            // 
            this.lblCutter.AutoSize = true;
            this.lblCutter.Location = new System.Drawing.Point(5, 16);
            this.lblCutter.Name = "lblCutter";
            this.lblCutter.Size = new System.Drawing.Size(61, 15);
            this.lblCutter.TabIndex = 19;
            this.lblCutter.Text = "Cortadora";
            // 
            // cmbCutter
            // 
            this.cmbCutter.FormattingEnabled = true;
            this.cmbCutter.Location = new System.Drawing.Point(74, 12);
            this.cmbCutter.Name = "cmbCutter";
            this.cmbCutter.Size = new System.Drawing.Size(163, 23);
            this.cmbCutter.TabIndex = 20;
            this.cmbCutter.SelectedIndexChanged += new System.EventHandler(this.cmbCutter_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImage = global::BPS.Lite.Properties.Resources.accept;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.Location = new System.Drawing.Point(529, 11);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(25, 25);
            this.btnAccept.TabIndex = 26;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmCutterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(558, 47);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblArms);
            this.Controls.Add(this.lblUtilWidth);
            this.Controls.Add(this.lblArmsLabel);
            this.Controls.Add(this.lblUtilWidthLabel);
            this.Controls.Add(this.lblCutter);
            this.Controls.Add(this.cmbCutter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCutterSelector";
            this.Text = "Selección de cortadora";
            this.Load += new System.EventHandler(this.frmCutterSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArms;
        private System.Windows.Forms.Label lblUtilWidth;
        private System.Windows.Forms.Label lblArmsLabel;
        private System.Windows.Forms.Label lblUtilWidthLabel;
        private System.Windows.Forms.Label lblCutter;
        private System.Windows.Forms.ComboBox cmbCutter;
        private System.Windows.Forms.Button btnAccept;
    }
}