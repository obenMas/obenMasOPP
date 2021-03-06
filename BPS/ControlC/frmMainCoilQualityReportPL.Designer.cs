namespace BPS
{
    partial class frmMainCoilQualityReportPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilQualityReport));
            this.crvQualityReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMainCoilQuality4 = new BPS.Reports.Control.rptMainCoilQuality_PL();
            this.SuspendLayout();
            // 
            // crvQualityReport
            // 
            this.crvQualityReport.ActiveViewIndex = 0;
            this.crvQualityReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvQualityReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvQualityReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvQualityReport.Location = new System.Drawing.Point(0, 0);
            this.crvQualityReport.Name = "crvQualityReport";
            this.crvQualityReport.ReportSource = this.rptMainCoilQuality4;
            this.crvQualityReport.ShowCloseButton = false;
            this.crvQualityReport.ShowGotoPageButton = false;
            this.crvQualityReport.ShowGroupTreeButton = false;
            this.crvQualityReport.ShowPageNavigateButtons = false;
            this.crvQualityReport.ShowParameterPanelButton = false;
            this.crvQualityReport.ShowRefreshButton = false;
            this.crvQualityReport.ShowTextSearchButton = false;
            this.crvQualityReport.Size = new System.Drawing.Size(851, 599);
            this.crvQualityReport.TabIndex = 0;
            this.crvQualityReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMainCoilQualityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 599);
            this.Controls.Add(this.crvQualityReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilQualityReport";
            this.Text = "Reporte de propiedades primarias de rollo madre";
            this.Load += new System.EventHandler(this.frmMainCoilQualityReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvQualityReport;
        private Reports.Control.rptMainCoilQuality_PL rptMainCoilQuality4;
    }
}