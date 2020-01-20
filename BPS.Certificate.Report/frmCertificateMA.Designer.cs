namespace BPS.Certificate.Report
{
    partial class frmCertificateMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateMA));
            this.crvCertificateMC = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateMA1 = new BPS.Certificate.Report.Reports.rptCertificateMA();
            this.SuspendLayout();
            // 
            // crvCertificateMC
            // 
            this.crvCertificateMC.ActiveViewIndex = 0;
            this.crvCertificateMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateMC.CachedPageNumberPerDoc = 10;
            this.crvCertificateMC.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateMC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateMC.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateMC.Name = "crvCertificateMC";
            this.crvCertificateMC.ReportSource = this.rptCertificateMA1;
            this.crvCertificateMC.ShowGroupTreeButton = false;
            this.crvCertificateMC.ShowParameterPanelButton = false;
            this.crvCertificateMC.ShowRefreshButton = false;
            this.crvCertificateMC.Size = new System.Drawing.Size(912, 529);
            this.crvCertificateMC.TabIndex = 0;
            this.crvCertificateMC.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCertificateMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.crvCertificateMC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateMA";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateMA_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateMC;
        private Reports.rptCertificateMA rptCertificateMA1;
    }
}