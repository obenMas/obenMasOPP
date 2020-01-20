namespace BPS.Reporting.Manager.Managers
{
    partial class frmManagerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerReport));
            this.crvManagerReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvManagerReport
            // 
            this.crvManagerReport.ActiveViewIndex = -1;
            this.crvManagerReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvManagerReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvManagerReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvManagerReport.Location = new System.Drawing.Point(0, 0);
            this.crvManagerReport.Name = "crvManagerReport";
            this.crvManagerReport.ShowGroupTreeButton = false;
            this.crvManagerReport.ShowParameterPanelButton = false;
            this.crvManagerReport.ShowRefreshButton = false;
            this.crvManagerReport.Size = new System.Drawing.Size(909, 543);
            this.crvManagerReport.TabIndex = 0;
            this.crvManagerReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmManagerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(909, 543);
            this.Controls.Add(this.crvManagerReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagerReport";
            this.Text = "Reporte de Inventarios";
            this.Load += new System.EventHandler(this.frmManagerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvManagerReport;
    }
}