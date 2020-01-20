namespace BPS
{
    partial class frmCustomerListReportView
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
            this.crvSalesOrderByDetailReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderBySalesOrderDetailsReport1 = new BPS.Reports.rptSalesOrderBySalesOrderDetailsReport();
            this.SuspendLayout();
            // 
            // crvSalesOrderByDetailReport
            // 
            this.crvSalesOrderByDetailReport.ActiveViewIndex = 0;
            this.crvSalesOrderByDetailReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderByDetailReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderByDetailReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderByDetailReport.Location = new System.Drawing.Point(0, 0);
            this.crvSalesOrderByDetailReport.Name = "crvSalesOrderByDetailReport";
            this.crvSalesOrderByDetailReport.ReportSource = this.rptSalesOrderBySalesOrderDetailsReport1;
            this.crvSalesOrderByDetailReport.ShowCloseButton = false;
            this.crvSalesOrderByDetailReport.ShowGotoPageButton = false;
            this.crvSalesOrderByDetailReport.ShowGroupTreeButton = false;
            this.crvSalesOrderByDetailReport.ShowPageNavigateButtons = false;
            this.crvSalesOrderByDetailReport.ShowParameterPanelButton = false;
            this.crvSalesOrderByDetailReport.ShowRefreshButton = false;
            this.crvSalesOrderByDetailReport.ShowTextSearchButton = false;
            this.crvSalesOrderByDetailReport.ShowZoomButton = false;
            this.crvSalesOrderByDetailReport.Size = new System.Drawing.Size(1045, 504);
            this.crvSalesOrderByDetailReport.TabIndex = 0;
            this.crvSalesOrderByDetailReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCustomerListReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 504);
            this.Controls.Add(this.crvSalesOrderByDetailReport);
            this.Name = "frmCustomerListReportView";
            this.Text = "frmCustomerListReportView";
            this.Load += new System.EventHandler(this.frmCustomerListReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderByDetailReport;
        private Reports.rptSalesOrderBySalesOrderDetailsReport rptSalesOrderBySalesOrderDetailsReport1;
    }
}