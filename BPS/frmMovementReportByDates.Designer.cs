namespace BPS
{
    partial class frmMovementReportByDates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovementReportByDates));
            this.crvMovement = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletMovementByDate1 = new BPS.Reports.rptPalletMovementByDate();
            this.SuspendLayout();
            // 
            // crvMovement
            // 
            this.crvMovement.ActiveViewIndex = 0;
            this.crvMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMovement.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMovement.Location = new System.Drawing.Point(0, 0);
            this.crvMovement.Name = "crvMovement";
            this.crvMovement.ReportSource = this.rptPalletMovementByDate1;
            this.crvMovement.ShowCloseButton = false;
            this.crvMovement.ShowGroupTreeButton = false;
            this.crvMovement.ShowParameterPanelButton = false;
            this.crvMovement.ShowRefreshButton = false;
            this.crvMovement.ShowZoomButton = false;
            this.crvMovement.Size = new System.Drawing.Size(895, 527);
            this.crvMovement.TabIndex = 0;
            this.crvMovement.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMovementReportByDates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(895, 527);
            this.Controls.Add(this.crvMovement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovementReportByDates";
            this.Text = "Reporte de Movimientos de Pallets Bodega";
            this.Load += new System.EventHandler(this.frmMovementReportByDates_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMovement;
        private Reports.rptPalletMovementByDate rptPalletMovementByDate1;
    }
}