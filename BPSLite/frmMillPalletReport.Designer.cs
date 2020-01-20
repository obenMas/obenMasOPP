namespace BPS.Lite
{
    partial class frmMillPalletReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillPalletReport));
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.crvEffience = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblInning = new System.Windows.Forms.Label();
            this.cmbInning = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpbDetail.SuspendLayout();
            this.grpbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.crvEffience);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Location = new System.Drawing.Point(0, 42);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(918, 511);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            // 
            // crvEffience
            // 
            this.crvEffience.ActiveViewIndex = -1;
            this.crvEffience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEffience.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEffience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEffience.Location = new System.Drawing.Point(3, 17);
            this.crvEffience.Name = "crvEffience";
            this.crvEffience.ShowGroupTreeButton = false;
            this.crvEffience.ShowParameterPanelButton = false;
            this.crvEffience.ShowRefreshButton = false;
            this.crvEffience.Size = new System.Drawing.Size(912, 491);
            this.crvEffience.TabIndex = 0;
            this.crvEffience.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblInning
            // 
            this.lblInning.AutoSize = true;
            this.lblInning.Location = new System.Drawing.Point(205, 17);
            this.lblInning.Name = "lblInning";
            this.lblInning.Size = new System.Drawing.Size(39, 15);
            this.lblInning.TabIndex = 4;
            this.lblInning.Text = "Turno";
            // 
            // cmbInning
            // 
            this.cmbInning.FormattingEnabled = true;
            this.cmbInning.Items.AddRange(new object[] {
            "Día",
            "Noche"});
            this.cmbInning.Location = new System.Drawing.Point(250, 14);
            this.cmbInning.Name = "cmbInning";
            this.cmbInning.Size = new System.Drawing.Size(93, 23);
            this.cmbInning.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Lite.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(822, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 31;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.dtpDate);
            this.grpbFilter.Controls.Add(this.lblDate);
            this.grpbFilter.Controls.Add(this.btnReport);
            this.grpbFilter.Controls.Add(this.cmbInning);
            this.grpbFilter.Controls.Add(this.lblInning);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(918, 42);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(412, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(236, 21);
            this.dtpDate.TabIndex = 33;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(365, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 32;
            this.lblDate.Text = "Fecha";
            // 
            // frmMillPalletReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(918, 553);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMillPalletReport";
            this.Text = "Reporte de Pallet Diarios Re-Procesado";
            this.grpbDetail.ResumeLayout(false);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDetail;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEffience;
        private System.Windows.Forms.Label lblInning;
        private System.Windows.Forms.ComboBox cmbInning;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
    }
}