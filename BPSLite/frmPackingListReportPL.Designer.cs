namespace BPS.Lite
{
    partial class frmPackingListReportPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingListReportPL));
            this.crvPalletPreShipping = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletPreShipping1 = new BPS.Lite.Reports.Pilar.rptPackingListPL();
            this.SuspendLayout();
            // 
            // crvPalletPreShipping
            // 
            this.crvPalletPreShipping.ActiveViewIndex = 0;
            this.crvPalletPreShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPalletPreShipping.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPalletPreShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPalletPreShipping.Location = new System.Drawing.Point(0, 0);
            this.crvPalletPreShipping.Name = "crvPalletPreShipping";
            this.crvPalletPreShipping.ReportSource = this.rptPalletPreShipping1;
            this.crvPalletPreShipping.ShowCloseButton = false;
            this.crvPalletPreShipping.ShowGroupTreeButton = false;
            this.crvPalletPreShipping.ShowParameterPanelButton = false;
            this.crvPalletPreShipping.ShowRefreshButton = false;
            this.crvPalletPreShipping.ShowZoomButton = false;
            this.crvPalletPreShipping.Size = new System.Drawing.Size(872, 607);
            this.crvPalletPreShipping.TabIndex = 0;
            this.crvPalletPreShipping.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPackingListReportPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(872, 607);
            this.Controls.Add(this.crvPalletPreShipping);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackingListReportPL";
            this.Text = "Pre - Despacho";
            this.Load += new System.EventHandler(this.frmPalletPreShippingReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPalletPreShipping;
        private BPS.Lite.Reports.Pilar.rptPackingListPL rptPalletPreShipping1;
    }
}