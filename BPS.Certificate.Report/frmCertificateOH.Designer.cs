namespace BPS.Certificate.Report
{
    partial class frmCertificateOH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateOH));
            this.crvCertificateSC = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateOH1 = new BPS.Certificate.Report.Reports.rptCertificateOH();
            this.SuspendLayout();
            // 
            // crvCertificateSC
            // 
            this.crvCertificateSC.ActiveViewIndex = 0;
            this.crvCertificateSC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateSC.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateSC.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateSC.Name = "crvCertificateSC";
            this.crvCertificateSC.ReportSource = this.rptCertificateOH1;
            this.crvCertificateSC.ShowGroupTreeButton = false;
            this.crvCertificateSC.ShowParameterPanelButton = false;
            this.crvCertificateSC.ShowRefreshButton = false;
            this.crvCertificateSC.Size = new System.Drawing.Size(912, 529);
            this.crvCertificateSC.TabIndex = 0;
            this.crvCertificateSC.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCertificateOH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.crvCertificateSC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateOH";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateOH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateSC;
        private Reports.rptCertificateOH rptCertificateOH1;
    }
}