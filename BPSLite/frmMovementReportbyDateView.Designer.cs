namespace BPS.Lite
{
    partial class frmMovementReportbyDateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovementReportbyDateView));
            this.grpbMovementReport = new System.Windows.Forms.GroupBox();
            this.crvMovement = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletMovementByDate2 = new BPS.Lite.Reports.rptPalletMovementByDate();
            this.grpbMovementReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbMovementReport
            // 
            this.grpbMovementReport.Controls.Add(this.crvMovement);
            this.grpbMovementReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbMovementReport.Location = new System.Drawing.Point(0, 0);
            this.grpbMovementReport.Name = "grpbMovementReport";
            this.grpbMovementReport.Size = new System.Drawing.Size(1037, 537);
            this.grpbMovementReport.TabIndex = 0;
            this.grpbMovementReport.TabStop = false;
            // 
            // crvMovement
            // 
            this.crvMovement.ActiveViewIndex = 0;
            this.crvMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMovement.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMovement.Location = new System.Drawing.Point(3, 17);
            this.crvMovement.Name = "crvMovement";
            this.crvMovement.ReportSource = this.rptPalletMovementByDate2;
            this.crvMovement.ShowCloseButton = false;
            this.crvMovement.ShowGroupTreeButton = false;
            this.crvMovement.ShowParameterPanelButton = false;
            this.crvMovement.ShowRefreshButton = false;
            this.crvMovement.Size = new System.Drawing.Size(1031, 517);
            this.crvMovement.TabIndex = 0;
            this.crvMovement.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMovementReportbyDateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1037, 537);
            this.Controls.Add(this.grpbMovementReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovementReportbyDateView";
            this.Text = "Reporte de movimientos bodega";
            this.Load += new System.EventHandler(this.frmMovementReportbyDateView_Load);
            this.grpbMovementReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbMovementReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMovement;
        private Reports.rptPalletMovementByDate rptPalletMovementByDate2;
    }
}