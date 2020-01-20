namespace BPS
{
    partial class frmPalletByCellar3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletByCellar3));
            this.crvCellar3 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletByCellar31 = new BPS.Reports.rptPalletByCellar3();
            this.SuspendLayout();
            // 
            // crvCellar3
            // 
            this.crvCellar3.ActiveViewIndex = 0;
            this.crvCellar3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCellar3.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCellar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCellar3.Location = new System.Drawing.Point(0, 0);
            this.crvCellar3.Name = "crvCellar3";
            this.crvCellar3.ReportSource = this.rptPalletByCellar31;
            this.crvCellar3.ShowParameterPanelButton = false;
            this.crvCellar3.ShowRefreshButton = false;
            this.crvCellar3.Size = new System.Drawing.Size(958, 572);
            this.crvCellar3.TabIndex = 0;
            this.crvCellar3.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletByCellar3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.Controls.Add(this.crvCellar3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletByCellar3";
            this.Text = "Bodega 3";
            this.Load += new System.EventHandler(this.frmPalletByCellar3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCellar3;
        private Reports.rptPalletByCellar3 rptPalletByCellar31;
    }
}