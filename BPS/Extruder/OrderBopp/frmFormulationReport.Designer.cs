namespace BPS
{
    partial class frmFormulationReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulationReport));
            this.crvFormulationReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptFormulationReport1 = new BPS.Reports.rptFormulationReport();
            this.SuspendLayout();
            // 
            // crvFormulationReport
            // 
            this.crvFormulationReport.ActiveViewIndex = 0;
            this.crvFormulationReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFormulationReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFormulationReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFormulationReport.Location = new System.Drawing.Point(0, 0);
            this.crvFormulationReport.Name = "crvFormulationReport";
            this.crvFormulationReport.ReportSource = this.rptFormulationReport1;
            this.crvFormulationReport.ShowGroupTreeButton = false;
            this.crvFormulationReport.ShowParameterPanelButton = false;
            this.crvFormulationReport.ShowRefreshButton = false;
            this.crvFormulationReport.Size = new System.Drawing.Size(903, 621);
            this.crvFormulationReport.TabIndex = 0;
            this.crvFormulationReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmFormulationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 621);
            this.Controls.Add(this.crvFormulationReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormulationReport";
            this.Text = "Reporte de Formulación";
            this.Load += new System.EventHandler(this.frmFormulationReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFormulationReport;
        private Reports.rptFormulationReport rptFormulationReport1;
    }
}