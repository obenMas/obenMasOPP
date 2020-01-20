namespace BPS
{
    partial class frmSummaryCutter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryCutter));
            this.grpbInfoCutter = new System.Windows.Forms.GroupBox();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.cmbCutter = new System.Windows.Forms.ComboBox();
            this.grpbReport = new System.Windows.Forms.GroupBox();
            this.crvSummaryCutter = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbInfoCutter.SuspendLayout();
            this.grpbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInfoCutter
            // 
            this.grpbInfoCutter.Controls.Add(this.cmbCutter);
            this.grpbInfoCutter.Controls.Add(this.lblCutterName);
            this.grpbInfoCutter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfoCutter.Location = new System.Drawing.Point(0, 0);
            this.grpbInfoCutter.Name = "grpbInfoCutter";
            this.grpbInfoCutter.Size = new System.Drawing.Size(989, 44);
            this.grpbInfoCutter.TabIndex = 0;
            this.grpbInfoCutter.TabStop = false;
            this.grpbInfoCutter.Text = "Cortadoras";
            // 
            // lblCutterName
            // 
            this.lblCutterName.AutoSize = true;
            this.lblCutterName.Location = new System.Drawing.Point(247, 17);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(67, 15);
            this.lblCutterName.TabIndex = 0;
            this.lblCutterName.Text = "Cortadora :";
            // 
            // cmbCutter
            // 
            this.cmbCutter.FormattingEnabled = true;
            this.cmbCutter.Location = new System.Drawing.Point(320, 14);
            this.cmbCutter.Name = "cmbCutter";
            this.cmbCutter.Size = new System.Drawing.Size(421, 23);
            this.cmbCutter.TabIndex = 1;
            this.cmbCutter.SelectedIndexChanged += new System.EventHandler(this.cmbCutter_SelectedIndexChanged);
            // 
            // grpbReport
            // 
            this.grpbReport.Controls.Add(this.crvSummaryCutter);
            this.grpbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbReport.Location = new System.Drawing.Point(0, 44);
            this.grpbReport.Name = "grpbReport";
            this.grpbReport.Size = new System.Drawing.Size(989, 474);
            this.grpbReport.TabIndex = 1;
            this.grpbReport.TabStop = false;
            this.grpbReport.Text = "Reporte";
            // 
            // crvSummaryCutter
            // 
            this.crvSummaryCutter.ActiveViewIndex = -1;
            this.crvSummaryCutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSummaryCutter.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSummaryCutter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSummaryCutter.Location = new System.Drawing.Point(3, 17);
            this.crvSummaryCutter.Name = "crvSummaryCutter";
            this.crvSummaryCutter.ShowCloseButton = false;
            this.crvSummaryCutter.ShowGroupTreeButton = false;
            this.crvSummaryCutter.ShowParameterPanelButton = false;
            this.crvSummaryCutter.ShowRefreshButton = false;
            this.crvSummaryCutter.Size = new System.Drawing.Size(983, 454);
            this.crvSummaryCutter.TabIndex = 0;
            this.crvSummaryCutter.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSummaryCutter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 518);
            this.Controls.Add(this.grpbReport);
            this.Controls.Add(this.grpbInfoCutter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSummaryCutter";
            this.Text = "Reporte Grupal por Cortadoras";
            this.Load += new System.EventHandler(this.frmSummaryCutter_Load);
            this.grpbInfoCutter.ResumeLayout(false);
            this.grpbInfoCutter.PerformLayout();
            this.grpbReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfoCutter;
        private System.Windows.Forms.ComboBox cmbCutter;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.GroupBox grpbReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSummaryCutter;
    }
}