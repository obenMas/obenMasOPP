namespace BPS
{
    partial class frmCuttingOrderReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrderReportView));
            this.crvCuttingOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCuttingOrders1 = new BPS.Reports.rptCuttingOrders();
            this.SuspendLayout();
            // 
            // crvCuttingOrder
            // 
            this.crvCuttingOrder.ActiveViewIndex = 0;
            this.crvCuttingOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCuttingOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCuttingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCuttingOrder.Location = new System.Drawing.Point(0, 0);
            this.crvCuttingOrder.Name = "crvCuttingOrder";
            this.crvCuttingOrder.ReportSource = this.rptCuttingOrders1;
            this.crvCuttingOrder.ShowCloseButton = false;
            this.crvCuttingOrder.ShowExportButton = false;
            this.crvCuttingOrder.ShowGotoPageButton = false;
            this.crvCuttingOrder.ShowGroupTreeButton = false;
            this.crvCuttingOrder.ShowPageNavigateButtons = false;
            this.crvCuttingOrder.ShowParameterPanelButton = false;
            this.crvCuttingOrder.ShowRefreshButton = false;
            this.crvCuttingOrder.ShowTextSearchButton = false;
            this.crvCuttingOrder.ShowZoomButton = false;
            this.crvCuttingOrder.Size = new System.Drawing.Size(960, 492);
            this.crvCuttingOrder.TabIndex = 0;
            this.crvCuttingOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCuttingOrderReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(960, 492);
            this.Controls.Add(this.crvCuttingOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrderReportView";
            this.Text = "Reporte Corte";
            this.Load += new System.EventHandler(this.frmCuttingOrderReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCuttingOrder;
        private Reports.rptCuttingOrders rptCuttingOrders1;
    }
}