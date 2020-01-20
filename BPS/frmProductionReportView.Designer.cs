namespace BPS
{
    partial class frmProductionReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportView));
            this.crvProductionReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptProductionReportSem1 = new BPS.Reports.rptProductionReportSem();
            this.SuspendLayout();
            // 
            // crvProductionReport
            // 
            this.crvProductionReport.ActiveViewIndex = 0;
            this.crvProductionReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductionReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductionReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductionReport.Location = new System.Drawing.Point(0, 0);
            this.crvProductionReport.Name = "crvProductionReport";
            this.crvProductionReport.ReportSource = this.rptProductionReportSem1;
            this.crvProductionReport.ShowCloseButton = false;
            this.crvProductionReport.ShowGroupTreeButton = false;
            this.crvProductionReport.ShowParameterPanelButton = false;
            this.crvProductionReport.ShowRefreshButton = false;
            this.crvProductionReport.ShowTextSearchButton = false;
            this.crvProductionReport.ShowZoomButton = false;
            this.crvProductionReport.Size = new System.Drawing.Size(980, 541);
            this.crvProductionReport.TabIndex = 0;
            this.crvProductionReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmProductionReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 541);
            this.Controls.Add(this.crvProductionReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportView";
            this.Text = "Reporte de Producción Por Maquinas";
            this.Load += new System.EventHandler(this.frmProductionReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductionReport;
        private Reports.rptProductionReportSem rptProductionReportSem1;
    }
}