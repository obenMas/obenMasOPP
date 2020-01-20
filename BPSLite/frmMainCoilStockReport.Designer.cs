namespace BPS.Lite
{
    partial class frmMainCoilStockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilStockReport));
            this.crvMainCoilStock = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMainCoilStock1 = new BPS.Lite.Reports.rptMainCoilStock();
            this.SuspendLayout();
            // 
            // crvMainCoilStock
            // 
            this.crvMainCoilStock.ActiveViewIndex = 0;
            this.crvMainCoilStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMainCoilStock.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMainCoilStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMainCoilStock.Location = new System.Drawing.Point(0, 0);
            this.crvMainCoilStock.Name = "crvMainCoilStock";
            this.crvMainCoilStock.ReportSource = this.rptMainCoilStock1;
            this.crvMainCoilStock.ShowCloseButton = false;
            this.crvMainCoilStock.ShowGotoPageButton = false;
            this.crvMainCoilStock.ShowGroupTreeButton = false;
            this.crvMainCoilStock.ShowParameterPanelButton = false;
            this.crvMainCoilStock.ShowRefreshButton = false;
            this.crvMainCoilStock.ShowTextSearchButton = false;
            this.crvMainCoilStock.ShowZoomButton = false;
            this.crvMainCoilStock.Size = new System.Drawing.Size(1189, 520);
            this.crvMainCoilStock.TabIndex = 1;
            this.crvMainCoilStock.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMainCoilStockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1189, 520);
            this.Controls.Add(this.crvMainCoilStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilStockReport";
            this.Text = "Reporte de stock de rollos madre";
            this.Load += new System.EventHandler(this.frmMainCoilStockReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMainCoilStock;
        private Reports.rptMainCoilStock rptMainCoilStock1;
    }
}