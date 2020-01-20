namespace BPS
{
    partial class frmFilmProductionReportNow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmProductionReportNow));
            this.crvFilmProductionSaleOrdersNow = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPlanificationReportNow1 = new BPS.Reports.rptPlanificationReportNow();
            this.SuspendLayout();
            // 
            // crvFilmProductionSaleOrdersNow
            // 
            this.crvFilmProductionSaleOrdersNow.ActiveViewIndex = 0;
            this.crvFilmProductionSaleOrdersNow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFilmProductionSaleOrdersNow.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFilmProductionSaleOrdersNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFilmProductionSaleOrdersNow.Location = new System.Drawing.Point(0, 0);
            this.crvFilmProductionSaleOrdersNow.Name = "crvFilmProductionSaleOrdersNow";
            this.crvFilmProductionSaleOrdersNow.ReportSource = this.rptPlanificationReportNow1;
            this.crvFilmProductionSaleOrdersNow.ShowCloseButton = false;
            this.crvFilmProductionSaleOrdersNow.ShowGroupTreeButton = false;
            this.crvFilmProductionSaleOrdersNow.ShowParameterPanelButton = false;
            this.crvFilmProductionSaleOrdersNow.ShowRefreshButton = false;
            this.crvFilmProductionSaleOrdersNow.ShowTextSearchButton = false;
            this.crvFilmProductionSaleOrdersNow.ShowZoomButton = false;
            this.crvFilmProductionSaleOrdersNow.Size = new System.Drawing.Size(828, 500);
            this.crvFilmProductionSaleOrdersNow.TabIndex = 0;
            this.crvFilmProductionSaleOrdersNow.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmFilmProductionReportNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 500);
            this.Controls.Add(this.crvFilmProductionSaleOrdersNow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilmProductionReportNow";
            this.Text = "Reporte de Planificación de hoy en adelante";
            this.Load += new System.EventHandler(this.frmFilmProductionReportNow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFilmProductionSaleOrdersNow;
        private Reports.rptPlanificationReportNow rptPlanificationReportNow1;
    }
}