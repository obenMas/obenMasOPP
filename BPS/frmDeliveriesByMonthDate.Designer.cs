namespace BPS
{
    partial class frmDeliveriesByMonthDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveriesByMonthDate));
            this.btnGenerateRpt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDBMD = new System.Windows.Forms.DateTimePicker();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateRpt
            // 
            this.btnGenerateRpt.Location = new System.Drawing.Point(82, 215);
            this.btnGenerateRpt.Name = "btnGenerateRpt";
            this.btnGenerateRpt.Size = new System.Drawing.Size(128, 42);
            this.btnGenerateRpt.TabIndex = 12;
            this.btnGenerateRpt.Text = "Generar";
            this.btnGenerateRpt.UseVisualStyleBackColor = true;
            this.btnGenerateRpt.Click += new System.EventHandler(this.btnGenerateRpt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDBMD);
            this.groupBox2.Location = new System.Drawing.Point(4, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 172);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // dtpDBMD
            // 
            this.dtpDBMD.Location = new System.Drawing.Point(6, 6);
            this.dtpDBMD.Name = "dtpDBMD";
            this.dtpDBMD.Size = new System.Drawing.Size(200, 20);
            this.dtpDBMD.TabIndex = 0;
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.lblFrom);
            this.groupBoxFrom.Location = new System.Drawing.Point(4, 4);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(276, 26);
            this.groupBoxFrom.TabIndex = 13;
            this.groupBoxFrom.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(55, 16);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Fecha:";
            // 
            // frmDeliveriesByMonthDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGenerateRpt);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeliveriesByMonthDate";
            this.Text = "Reporte de Despachos";
            this.groupBox2.ResumeLayout(false);
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateRpt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDBMD;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.Label lblFrom;
    }
}