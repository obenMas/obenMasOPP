namespace BPS.Certificate.Report
{
    partial class frmCertificateMCTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateMCTT));
            this.crvCertificateMCTT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateMCTT1 = new BPS.Certificate.Report.Reports.rptCertificateMCTT1();
            this.SuspendLayout();
            // 
            // crvCertificateMCTT
            // 
            this.crvCertificateMCTT.ActiveViewIndex = 0;
            this.crvCertificateMCTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateMCTT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateMCTT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateMCTT.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateMCTT.Name = "crvCertificateMCTT";
            this.crvCertificateMCTT.ReportSource = this.rptCertificateMCTT1;
            this.crvCertificateMCTT.Size = new System.Drawing.Size(896, 490);
            this.crvCertificateMCTT.TabIndex = 0;
            this.crvCertificateMCTT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCertificateMCTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 490);
            this.Controls.Add(this.crvCertificateMCTT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateMCTT";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateMCTT_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateMCTT;
        private Reports.rptCertificateMCTT1 rptCertificateMCTT1;
    }
}