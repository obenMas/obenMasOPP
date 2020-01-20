namespace BPS.Certificate.Report
{
    partial class frmCertificateSD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateSD));
            this.crvCertificateSD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateSD1 = new BPS.Certificate.Report.Reports.rptCertificateSD();
            this.SuspendLayout();
            // 
            // crvCertificateSD
            // 
            this.crvCertificateSD.ActiveViewIndex = 0;
            this.crvCertificateSD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateSD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateSD.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateSD.Name = "crvCertificateSD";
            this.crvCertificateSD.ReportSource = this.rptCertificateSD1;
            this.crvCertificateSD.ShowGroupTreeButton = false;
            this.crvCertificateSD.ShowParameterPanelButton = false;
            this.crvCertificateSD.ShowRefreshButton = false;
            this.crvCertificateSD.Size = new System.Drawing.Size(912, 529);
            this.crvCertificateSD.TabIndex = 0;
            this.crvCertificateSD.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCertificateSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.crvCertificateSD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateSD";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateSD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateSD;
        private Reports.rptCertificateSD rptCertificateSD1;
    }
}