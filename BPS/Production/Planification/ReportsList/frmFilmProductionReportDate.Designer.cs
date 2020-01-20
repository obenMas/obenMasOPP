namespace BPS
{
    partial class frmFilmProductionReportDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmProductionReportDate));
            this.crvFilmProductionReportDate = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPlanificationReportDate1 = new BPS.Reports.Programation.rptPlanificationReportDate();
            this.SuspendLayout();
            // 
            // crvFilmProductionReportDate
            // 
            this.crvFilmProductionReportDate.ActiveViewIndex = 0;
            this.crvFilmProductionReportDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFilmProductionReportDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFilmProductionReportDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFilmProductionReportDate.Location = new System.Drawing.Point(0, 0);
            this.crvFilmProductionReportDate.Name = "crvFilmProductionReportDate";
            this.crvFilmProductionReportDate.ReportSource = this.rptPlanificationReportDate1;
            this.crvFilmProductionReportDate.ShowGroupTreeButton = false;
            this.crvFilmProductionReportDate.ShowParameterPanelButton = false;
            this.crvFilmProductionReportDate.ShowRefreshButton = false;
            this.crvFilmProductionReportDate.Size = new System.Drawing.Size(1176, 563);
            this.crvFilmProductionReportDate.TabIndex = 0;
            this.crvFilmProductionReportDate.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmFilmProductionReportDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1176, 563);
            this.Controls.Add(this.crvFilmProductionReportDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilmProductionReportDate";
            this.Text = "Reporte de Planificación";
            this.Load += new System.EventHandler(this.frmFilmProductionReportDate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFilmProductionReportDate;
        private Reports.Programation.rptPlanificationReportDate rptPlanificationReportDate1;
    }
}