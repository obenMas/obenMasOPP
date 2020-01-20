namespace BPS
{
    partial class frmRecordProductionReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecordProductionReportView));
            this.crpRecordProductionDMT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptRecordProductionDMT1 = new BPS.Reports.rptRecordProductionDMT();
            this.SuspendLayout();
            // 
            // crpRecordProductionDMT
            // 
            this.crpRecordProductionDMT.ActiveViewIndex = 0;
            this.crpRecordProductionDMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpRecordProductionDMT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpRecordProductionDMT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpRecordProductionDMT.Location = new System.Drawing.Point(0, 0);
            this.crpRecordProductionDMT.Name = "crpRecordProductionDMT";
            this.crpRecordProductionDMT.ReportSource = this.rptRecordProductionDMT1;
            this.crpRecordProductionDMT.ShowCloseButton = false;
            this.crpRecordProductionDMT.ShowGotoPageButton = false;
            this.crpRecordProductionDMT.ShowGroupTreeButton = false;
            this.crpRecordProductionDMT.ShowPageNavigateButtons = false;
            this.crpRecordProductionDMT.ShowParameterPanelButton = false;
            this.crpRecordProductionDMT.ShowRefreshButton = false;
            this.crpRecordProductionDMT.ShowTextSearchButton = false;
            this.crpRecordProductionDMT.ShowZoomButton = false;
            this.crpRecordProductionDMT.Size = new System.Drawing.Size(1095, 465);
            this.crpRecordProductionDMT.TabIndex = 0;
            this.crpRecordProductionDMT.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRecordProductionReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1095, 465);
            this.Controls.Add(this.crpRecordProductionDMT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRecordProductionReportView";
            this.Text = "Record de Producción";
            this.Load += new System.EventHandler(this.frmRecordProductionReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpRecordProductionDMT;
        private Reports.rptRecordProductionDMT rptRecordProductionDMT1;
    }
}