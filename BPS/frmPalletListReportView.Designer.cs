namespace BPS
{
    partial class frmPalletListReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletListReportView));
            this.crvPalletReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletListByDate1 = new BPS.Reports.rptPalletListByDate();
            this.SuspendLayout();
            // 
            // crvPalletReport
            // 
            this.crvPalletReport.ActiveViewIndex = 0;
            this.crvPalletReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPalletReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPalletReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPalletReport.Location = new System.Drawing.Point(0, 0);
            this.crvPalletReport.Name = "crvPalletReport";
            this.crvPalletReport.ReportSource = this.rptPalletListByDate1;
            this.crvPalletReport.ShowCloseButton = false;
            this.crvPalletReport.ShowGroupTreeButton = false;
            this.crvPalletReport.ShowParameterPanelButton = false;
            this.crvPalletReport.ShowRefreshButton = false;
            this.crvPalletReport.ShowTextSearchButton = false;
            this.crvPalletReport.ShowZoomButton = false;
            this.crvPalletReport.Size = new System.Drawing.Size(939, 487);
            this.crvPalletReport.TabIndex = 0;
            this.crvPalletReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletListReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.Controls.Add(this.crvPalletReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletListReportView";
            this.Text = "Reporte de Producción Por Maquinas";
            this.Load += new System.EventHandler(this.frmProductionReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPalletReport;
        private Reports.rptPalletListByDate rptPalletListByDate1;
    }
}