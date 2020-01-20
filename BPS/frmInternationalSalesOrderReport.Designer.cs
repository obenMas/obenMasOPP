namespace BPS
{
    partial class frmInternationalSalesOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalSalesOrderReport));
            this.crvInternationalSalesOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderExport1 = new BPS.Reports.rptSalesOrderExport();
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
            this.crvInternationalSalesOrder.ReportSource = this.rptSalesOrderExport1;
            this.crvInternationalSalesOrder.ShowCloseButton = false;
            this.crvInternationalSalesOrder.ShowGotoPageButton = false;
            this.crvInternationalSalesOrder.ShowGroupTreeButton = false;
            this.crvInternationalSalesOrder.ShowParameterPanelButton = false;
            this.crvInternationalSalesOrder.ShowRefreshButton = false;
            this.crvInternationalSalesOrder.ShowTextSearchButton = false;
            this.crvInternationalSalesOrder.ShowZoomButton = false;
            this.crvInternationalSalesOrder.Size = new System.Drawing.Size(1105, 453);
            this.crvInternationalSalesOrder.TabIndex = 0;
            this.crvInternationalSalesOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmInternationalSalesOrderReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1105, 453);
            this.Controls.Add(this.crvInternationalSalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInternationalSalesOrderReport";
            this.Text = "Reporte de Orden de Venta Internacionales";
            this.Load += new System.EventHandler(this.frmInternationalSalesOrderReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInternationalSalesOrder;
        private Reports.rptSalesOrderExport rptSalesOrderExport1;
    }
}