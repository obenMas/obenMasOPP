namespace BPS
{
    partial class frmSalesOrderByProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderByProduction));
            this.tbcSalesOrderNational = new System.Windows.Forms.TabControl();
            this.tbpDetailSalesOrderNational = new System.Windows.Forms.TabPage();
            this.crvDetailSalesOrderNational = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpSummarySalesOrderNational = new System.Windows.Forms.TabPage();
            this.crvSummarySalesOrderNational = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderProduction1 = new BPS.Reports.SalesOrder.rptSalesOrderProduction();
            this.rptSalesOrderSummaryProduction1 = new BPS.Reports.SalesOrder.rptSalesOrderSummaryProduction();
            this.tbcSalesOrderNational.SuspendLayout();
            this.tbpDetailSalesOrderNational.SuspendLayout();
            this.tbpSummarySalesOrderNational.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSalesOrderNational
            // 
            this.tbcSalesOrderNational.Controls.Add(this.tbpDetailSalesOrderNational);
            this.tbcSalesOrderNational.Controls.Add(this.tbpSummarySalesOrderNational);
            this.tbcSalesOrderNational.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSalesOrderNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcSalesOrderNational.Location = new System.Drawing.Point(0, 0);
            this.tbcSalesOrderNational.Name = "tbcSalesOrderNational";
            this.tbcSalesOrderNational.SelectedIndex = 0;
            this.tbcSalesOrderNational.Size = new System.Drawing.Size(885, 565);
            this.tbcSalesOrderNational.TabIndex = 0;
            // 
            // tbpDetailSalesOrderNational
            // 
            this.tbpDetailSalesOrderNational.Controls.Add(this.crvDetailSalesOrderNational);
            this.tbpDetailSalesOrderNational.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpDetailSalesOrderNational.Location = new System.Drawing.Point(4, 24);
            this.tbpDetailSalesOrderNational.Name = "tbpDetailSalesOrderNational";
            this.tbpDetailSalesOrderNational.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetailSalesOrderNational.Size = new System.Drawing.Size(877, 537);
            this.tbpDetailSalesOrderNational.TabIndex = 0;
            this.tbpDetailSalesOrderNational.Text = "Pedidos VS Extruidos (Detallado)";
            this.tbpDetailSalesOrderNational.UseVisualStyleBackColor = true;
            // 
            // crvDetailSalesOrderNational
            // 
            this.crvDetailSalesOrderNational.ActiveViewIndex = 0;
            this.crvDetailSalesOrderNational.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDetailSalesOrderNational.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDetailSalesOrderNational.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDetailSalesOrderNational.Location = new System.Drawing.Point(3, 3);
            this.crvDetailSalesOrderNational.Name = "crvDetailSalesOrderNational";
            this.crvDetailSalesOrderNational.ReportSource = this.rptSalesOrderProduction1;
            this.crvDetailSalesOrderNational.ShowParameterPanelButton = false;
            this.crvDetailSalesOrderNational.ShowRefreshButton = false;
            this.crvDetailSalesOrderNational.Size = new System.Drawing.Size(871, 531);
            this.crvDetailSalesOrderNational.TabIndex = 0;
            this.crvDetailSalesOrderNational.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpSummarySalesOrderNational
            // 
            this.tbpSummarySalesOrderNational.Controls.Add(this.crvSummarySalesOrderNational);
            this.tbpSummarySalesOrderNational.Location = new System.Drawing.Point(4, 24);
            this.tbpSummarySalesOrderNational.Name = "tbpSummarySalesOrderNational";
            this.tbpSummarySalesOrderNational.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSummarySalesOrderNational.Size = new System.Drawing.Size(877, 537);
            this.tbpSummarySalesOrderNational.TabIndex = 1;
            this.tbpSummarySalesOrderNational.Text = "Pedidos Vs Extruidos (Resumen)";
            this.tbpSummarySalesOrderNational.UseVisualStyleBackColor = true;
            // 
            // crvSummarySalesOrderNational
            // 
            this.crvSummarySalesOrderNational.ActiveViewIndex = 0;
            this.crvSummarySalesOrderNational.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSummarySalesOrderNational.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSummarySalesOrderNational.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSummarySalesOrderNational.Location = new System.Drawing.Point(3, 3);
            this.crvSummarySalesOrderNational.Name = "crvSummarySalesOrderNational";
            this.crvSummarySalesOrderNational.ReportSource = this.rptSalesOrderSummaryProduction1;
            this.crvSummarySalesOrderNational.ShowParameterPanelButton = false;
            this.crvSummarySalesOrderNational.ShowRefreshButton = false;
            this.crvSummarySalesOrderNational.Size = new System.Drawing.Size(871, 531);
            this.crvSummarySalesOrderNational.TabIndex = 0;
            this.crvSummarySalesOrderNational.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSalesOrderByProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(885, 565);
            this.Controls.Add(this.tbcSalesOrderNational);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderByProduction";
            this.Text = "Kilos Pedidos VS Kilos Extruidos Pedidos General";
            this.Load += new System.EventHandler(this.frmSalesOrderFulfillmetNational_Load);
            this.tbcSalesOrderNational.ResumeLayout(false);
            this.tbpDetailSalesOrderNational.ResumeLayout(false);
            this.tbpSummarySalesOrderNational.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcSalesOrderNational;
        private System.Windows.Forms.TabPage tbpDetailSalesOrderNational;
        private System.Windows.Forms.TabPage tbpSummarySalesOrderNational;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDetailSalesOrderNational;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSummarySalesOrderNational;
        private Reports.SalesOrder.rptSalesOrderProduction rptSalesOrderProduction1;
        private Reports.SalesOrder.rptSalesOrderSummaryProduction rptSalesOrderSummaryProduction1;
    }
}