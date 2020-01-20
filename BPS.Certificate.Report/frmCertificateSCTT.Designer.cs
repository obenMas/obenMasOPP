namespace BPS.Certificate.Report
{
    partial class frmCertificateSCTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateSCTT));
            this.crvCertificateSCTT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateSCTT1 = new BPS.Certificate.Report.Reports.rptCertificateSCTT();
            this.SuspendLayout();
            // 
            // crvCertificateSCTT
            // 
            this.crvCertificateSCTT.ActiveViewIndex = 0;
            this.crvCertificateSCTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateSCTT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateSCTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateSCTT.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateSCTT.Name = "crvCertificateSCTT";
            this.crvCertificateSCTT.ReportSource = this.rptCertificateSCTT1;
            this.crvCertificateSCTT.Size = new System.Drawing.Size(912, 529);
            this.crvCertificateSCTT.TabIndex = 0;
            this.crvCertificateSCTT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCertificateSCTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.crvCertificateSCTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateSCTT";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateSCTT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateSCTT;
        private Reports.rptCertificateSCTT rptCertificateSCTT1;
    }
}