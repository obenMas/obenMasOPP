namespace BPS.Lite
{
    partial class frmRecordProductionMwView
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
            this.crvRecordProductionMw = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptRecordProductionMW1 = new BPS.Lite.Reports.rptRecordProductionMW();
            this.SuspendLayout();
            // 
            // crvRecordProductionMw
            // 
            this.crvRecordProductionMw.ActiveViewIndex = 0;
            this.crvRecordProductionMw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvRecordProductionMw.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvRecordProductionMw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvRecordProductionMw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crvRecordProductionMw.Location = new System.Drawing.Point(0, 0);
            this.crvRecordProductionMw.Name = "crvRecordProductionMw";
            this.crvRecordProductionMw.ReportSource = this.rptRecordProductionMW1;
            this.crvRecordProductionMw.ShowCloseButton = false;
            this.crvRecordProductionMw.ShowGotoPageButton = false;
            this.crvRecordProductionMw.ShowGroupTreeButton = false;
            this.crvRecordProductionMw.ShowPageNavigateButtons = false;
            this.crvRecordProductionMw.ShowParameterPanelButton = false;
            this.crvRecordProductionMw.ShowRefreshButton = false;
            this.crvRecordProductionMw.ShowTextSearchButton = false;
            this.crvRecordProductionMw.ShowZoomButton = false;
            this.crvRecordProductionMw.Size = new System.Drawing.Size(1005, 485);
            this.crvRecordProductionMw.TabIndex = 0;
            this.crvRecordProductionMw.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRecordProductionMwView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 485);
            this.Controls.Add(this.crvRecordProductionMw);
            this.Name = "frmRecordProductionMwView";
            this.Text = "Record de Producción";
            this.Load += new System.EventHandler(this.frmRecordProductionMwView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvRecordProductionMw;
        private BPS.Lite.Reports.rptRecordProductionMW rptRecordProductionMW1;
    }
}