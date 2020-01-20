namespace BPS
{
    partial class frmProductionReportByDecreaseReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByDecreaseReport));
            this.crvProductionDecreaseReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptProductionDecreaseByDate1 = new BPS.Reports.rptProductionDecreaseByDate();
            this.SuspendLayout();
            // 
            // crvProductionDecreaseReport
            // 
            this.crvProductionDecreaseReport.ActiveViewIndex = 0;
            this.crvProductionDecreaseReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductionDecreaseReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductionDecreaseReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductionDecreaseReport.Location = new System.Drawing.Point(0, 0);
            this.crvProductionDecreaseReport.Name = "crvProductionDecreaseReport";
            this.crvProductionDecreaseReport.ReportSource = this.rptProductionDecreaseByDate1;
            this.crvProductionDecreaseReport.ShowCloseButton = false;
            this.crvProductionDecreaseReport.ShowParameterPanelButton = false;
            this.crvProductionDecreaseReport.ShowRefreshButton = false;
            this.crvProductionDecreaseReport.Size = new System.Drawing.Size(875, 562);
            this.crvProductionDecreaseReport.TabIndex = 0;
            this.crvProductionDecreaseReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmProductionReportByDecreaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(875, 562);
            this.Controls.Add(this.crvProductionDecreaseReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByDecreaseReport";
            this.Text = "Desperdicios Mensuales";
            this.Load += new System.EventHandler(this.frmProductionReportByDecreaseReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductionDecreaseReport;
        private Reports.rptProductionDecreaseByDate rptProductionDecreaseByDate1;
        //private Reports.rptProductionDecrease crtProductionReportDecrease1;
        //private Reports.rptProductionReportDecrease rptProductionReportDecrease1;
    }
}