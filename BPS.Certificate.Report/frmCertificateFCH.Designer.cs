namespace BPS.Certificate.Report
{
    partial class frmCertificateFCH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateFCH));
            this.crvCertificateFCH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCertificateFCH1 = new BPS.Certificate.Report.Reports.rptCertificateFCH();
            this.SuspendLayout();
            // 
            // crvCertificateFCH
            // 
            this.crvCertificateFCH.ActiveViewIndex = 0;
            this.crvCertificateFCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCertificateFCH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCertificateFCH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCertificateFCH.Location = new System.Drawing.Point(0, 0);
            this.crvCertificateFCH.Name = "crvCertificateFCH";
            this.crvCertificateFCH.ReportSource = this.rptCertificateFCH1;
            this.crvCertificateFCH.ShowGroupTreeButton = false;
            this.crvCertificateFCH.ShowParameterPanelButton = false;
            this.crvCertificateFCH.ShowRefreshButton = false;
            this.crvCertificateFCH.Size = new System.Drawing.Size(912, 529);
            this.crvCertificateFCH.TabIndex = 0;
            this.crvCertificateFCH.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvCertificateFCH.Load += new System.EventHandler(this.frmCertificateFCH_Load);
            // 
            // frmCertificateFCH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.crvCertificateFCH);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateFCH";
            this.Text = "Certificado de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateFCH_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCertificateFCH;
        private Reports.rptCertificateFCH rptCertificateFCH1;
    }
}