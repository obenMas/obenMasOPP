namespace BPS
{
    partial class frmCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendar));
            this.dtpCalendar = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.ttpCalendar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dtpCalendar
            // 
            this.dtpCalendar.CustomFormat = "dd/MM/yyyy    HH:mm";
            this.dtpCalendar.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCalendar.Location = new System.Drawing.Point(4, 6);
            this.dtpCalendar.Name = "dtpCalendar";
            this.dtpCalendar.Size = new System.Drawing.Size(143, 21);
            this.dtpCalendar.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::BPS.Properties.Resources.accept;
            this.btnOK.Location = new System.Drawing.Point(153, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(25, 25);
            this.btnOK.TabIndex = 7;
            this.ttpCalendar.SetToolTip(this.btnOK, "OK");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(185, 34);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpCalendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalendar";
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.frmCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCalendar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip ttpCalendar;
    }
}