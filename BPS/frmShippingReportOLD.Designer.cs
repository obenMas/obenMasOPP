namespace BPS
{
    partial class frmShippingReportOLD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingReportOLD));
            this.crvShipping = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptShipping1 = new BPS.Reports.rptShipping();
            this.SuspendLayout();
            // 
            // crvShipping
            // 
            this.crvShipping.ActiveViewIndex = 0;
            this.crvShipping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvShipping.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvShipping.Location = new System.Drawing.Point(0, 0);
            this.crvShipping.Name = "crvShipping";
            this.crvShipping.ReportSource = this.rptShipping1;
            this.crvShipping.ShowCloseButton = false;
            this.crvShipping.ShowGroupTreeButton = false;
            this.crvShipping.ShowParameterPanelButton = false;
            this.crvShipping.ShowRefreshButton = false;
            this.crvShipping.ShowTextSearchButton = false;
            this.crvShipping.ShowZoomButton = false;
            this.crvShipping.Size = new System.Drawing.Size(979, 485);
            this.crvShipping.TabIndex = 0;
            this.crvShipping.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmShippingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 485);
            this.Controls.Add(this.crvShipping);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingReport";
            this.Text = "Listado de Ordenes Internacionales Activas";
            this.Load += new System.EventHandler(this.frmShippingReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvShipping;
        private Reports.rptShipping rptShipping1;
    }
}