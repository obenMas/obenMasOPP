namespace BPS.Certificate.Report
{
    partial class frmCertificateFH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateFH));
            this.crvCertificateFH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateFH1 = new BPS.Certificate.Report.Reports.rptCertificateFH();
            this.SuspendLayout();
            // 
            // crvCertificateFH
            // 
            this.crvCertificateFH.ActiveViewIndex = 0;
            this.crvCertificateFH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateFH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateFH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateFH.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateFH.Name = "crvCertificateFH";
            this.crvCertificateFH.ReportSource = this.rptCertificateFH1;
            this.crvCertificateFH.ShowGroupTreeButton = false;
            this.crvCertificateFH.ShowParameterPanelButton = false;
            this.crvCertificateFH.ShowRefreshButton = false;
            this.crvCertificateFH.ShowZoomButton = false;
            this.crvCertificateFH.Size = new System.Drawing.Size(912, 529);
            this.crvCertificateFH.TabIndex = 0;
            this.crvCertificateFH.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCertificateFH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.crvCertificateFH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateFH";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateFH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateFH;
        private Reports.rptCertificateFH rptCertificateFH1;
    }
}