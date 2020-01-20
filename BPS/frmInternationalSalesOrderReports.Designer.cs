namespace BPS
{
    partial class frmInternationalSalesOrderReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalSalesOrderReports));
            this.crvInternationalSalesOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderExportShort1 = new BPS.Reports.rptSalesOrderExportShort();
            this.SuspendLayout();
            // 
            // crvInternationalSalesOrder
            // 
            this.crvInternationalSalesOrder.ActiveViewIndex = 0;
            this.crvInternationalSalesOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInternationalSalesOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInternationalSalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInternationalSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.crvInternationalSalesOrder.Name = "crvInternationalSalesOrder";
            this.crvInternationalSalesOrder.ReportSource = this.rptSalesOrderExportShort1;
            this.crvInternationalSalesOrder.ShowCloseButton = false;
            this.crvInternationalSalesOrder.ShowGotoPageButton = false;
            this.crvInternationalSalesOrder.ShowGroupTreeButton = false;
            this.crvInternationalSalesOrder.ShowParameterPanelButton = false;
            this.crvInternationalSalesOrder.ShowRefreshButton = false;
            this.crvInternationalSalesOrder.ShowTextSearchButton = false;
            this.crvInternationalSalesOrder.ShowZoomButton = false;
            this.crvInternationalSalesOrder.Size = new System.Drawing.Size(950, 478);
            this.crvInternationalSalesOrder.TabIndex = 0;
            this.crvInternationalSalesOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmInternationalSalesOrderReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(950, 478);
            this.Controls.Add(this.crvInternationalSalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInternationalSalesOrderReports";
            this.Text = "Ventas Internacionales";
            this.Load += new System.EventHandler(this.frmInternationalSalesOrderReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInternationalSalesOrder;
        private Reports.rptSalesOrderExportShort rptSalesOrderExportShort1;
    }
}