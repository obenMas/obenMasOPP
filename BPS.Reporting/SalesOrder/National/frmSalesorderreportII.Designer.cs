namespace BPS.Reporting.SalesOrder.National
{
    partial class frmSalesorderreportII
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
            this.crvSalesOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderReportShortSales1 = new BPS.Reporting.SalesOrder.National.rptSalesOrderReportShortSales();
            this.SuspendLayout();
            // 
            // crvSalesOrder
            // 
            this.crvSalesOrder.ActiveViewIndex = 0;
            this.crvSalesOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.crvSalesOrder.Name = "crvSalesOrder";
            this.crvSalesOrder.ReportSource = this.rptSalesOrderReportShortSales1;
            this.crvSalesOrder.ShowCloseButton = false;
            this.crvSalesOrder.ShowGotoPageButton = false;
            this.crvSalesOrder.ShowGroupTreeButton = false;
            this.crvSalesOrder.ShowPageNavigateButtons = false;
            this.crvSalesOrder.ShowParameterPanelButton = false;
            this.crvSalesOrder.ShowRefreshButton = false;
            this.crvSalesOrder.ShowTextSearchButton = false;
            this.crvSalesOrder.ShowZoomButton = false;
            this.crvSalesOrder.Size = new System.Drawing.Size(844, 489);
            this.crvSalesOrder.TabIndex = 0;
            this.crvSalesOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSalesorderreportII
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 489);
            this.Controls.Add(this.crvSalesOrder);
            this.Name = "frmSalesorderreportII";
            this.Text = "Reporte Ventas Nacional";
            this.Load += new System.EventHandler(this.frmSalesorderreportII_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrder;
        private BPS.Reporting.SalesOrder.National.rptSalesOrderReportShortSales rptSalesOrderReportShortSales1;
    }
}