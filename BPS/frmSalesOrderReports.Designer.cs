namespace BPS
{
    partial class frmSalesOrderReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderReports));
            this.crvSalesOrderReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderReports1 = new BPS.Reports.rptSalesOrderReports();
            this.SuspendLayout();
            // 
            // crvSalesOrderReport
            // 
            this.crvSalesOrderReport.ActiveViewIndex = 0;
            this.crvSalesOrderReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderReport.Location = new System.Drawing.Point(0, 0);
            this.crvSalesOrderReport.Name = "crvSalesOrderReport";
            this.crvSalesOrderReport.ReportSource = this.rptSalesOrderReports1;
            this.crvSalesOrderReport.ShowCloseButton = false;
            this.crvSalesOrderReport.ShowGotoPageButton = false;
            this.crvSalesOrderReport.ShowGroupTreeButton = false;
            this.crvSalesOrderReport.ShowParameterPanelButton = false;
            this.crvSalesOrderReport.ShowRefreshButton = false;
            this.crvSalesOrderReport.ShowTextSearchButton = false;
            this.crvSalesOrderReport.ShowZoomButton = false;
            this.crvSalesOrderReport.Size = new System.Drawing.Size(840, 522);
            this.crvSalesOrderReport.TabIndex = 0;
            this.crvSalesOrderReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSalesOrderReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(840, 522);
            this.Controls.Add(this.crvSalesOrderReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderReports";
            this.Text = "Ventas Nacionales";
            this.Load += new System.EventHandler(this.frmSalesOrderReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderReport;
        private Reports.rptSalesOrderReports rptSalesOrderReports1;
    }
}