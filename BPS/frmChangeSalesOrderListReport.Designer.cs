namespace BPS
{
    partial class frmChangeSalesOrderListReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangeSalesOrderListReport));
            this.crvCuttingOrderViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptChangeSalesOrder1 = new BPS.Reports.rptChangeSalesOrder();

            this.SuspendLayout();
            // 
            // crvCuttingOrderViewer
            // 
            this.crvCuttingOrderViewer.ActiveViewIndex = 0;
            this.crvCuttingOrderViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCuttingOrderViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCuttingOrderViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCuttingOrderViewer.Location = new System.Drawing.Point(0, 0);
            this.crvCuttingOrderViewer.Name = "crvCuttingOrderViewer";
            this.crvCuttingOrderViewer.ReportSource = this.rptChangeSalesOrder1;
            this.crvCuttingOrderViewer.ReuseParameterValuesOnRefresh = true;
            this.crvCuttingOrderViewer.ShowCloseButton = false;
            this.crvCuttingOrderViewer.ShowGroupTreeButton = false;
            this.crvCuttingOrderViewer.ShowParameterPanelButton = false;
            this.crvCuttingOrderViewer.ShowRefreshButton = false;
            this.crvCuttingOrderViewer.Size = new System.Drawing.Size(987, 492);
            this.crvCuttingOrderViewer.TabIndex = 0;
            this.crvCuttingOrderViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmChangeSalesOrderListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(987, 492);
            this.Controls.Add(this.crvCuttingOrderViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangeSalesOrderListReport";
            this.Tag = "";
            this.Text = "Reporte de ordenes de corte";
            this.Load += new System.EventHandler(this.frmCuttingListReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCuttingOrderViewer;
        private Reports.rptChangeSalesOrder rptChangeSalesOrder1;
    }
}