namespace BPS.Reporting.ProductionReports.DeadTime
{
    partial class frmProductionReportByDeadTimeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByDeadTimeReport));
            this.crvProductionReportByDeadTime = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.crvDeadTimeDetail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptProductionDeadTimeByDate1 = new BPS.Reporting.ProductionReports.DeadTime.rptProductionDeadTimeByDate();
            this.rptProductionDeadTimeByDateDetails1 = new BPS.Reporting.ProductionReports.DeadTime.rptProductionDeadTimeByDateDetails();
            this.tbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvProductionReportByDeadTime
            // 
            this.crvProductionReportByDeadTime.ActiveViewIndex = 0;
            this.crvProductionReportByDeadTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductionReportByDeadTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductionReportByDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductionReportByDeadTime.Location = new System.Drawing.Point(3, 3);
            this.crvProductionReportByDeadTime.Name = "crvProductionReportByDeadTime";
            this.crvProductionReportByDeadTime.ReportSource = this.rptProductionDeadTimeByDate1;
            this.crvProductionReportByDeadTime.ShowCloseButton = false;
            this.crvProductionReportByDeadTime.ShowParameterPanelButton = false;
            this.crvProductionReportByDeadTime.ShowRefreshButton = false;
            this.crvProductionReportByDeadTime.Size = new System.Drawing.Size(884, 543);
            this.crvProductionReportByDeadTime.TabIndex = 0;
            this.crvProductionReportByDeadTime.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(898, 577);
            this.tbcMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crvProductionReportByDeadTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 549);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tiempos Muertos Unificado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.crvDeadTimeDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiempos Muertos Detallados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // crvDeadTimeDetail
            // 
            this.crvDeadTimeDetail.ActiveViewIndex = 0;
            this.crvDeadTimeDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDeadTimeDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDeadTimeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDeadTimeDetail.Location = new System.Drawing.Point(3, 3);
            this.crvDeadTimeDetail.Name = "crvDeadTimeDetail";
            this.crvDeadTimeDetail.ReportSource = this.rptProductionDeadTimeByDateDetails1;
            this.crvDeadTimeDetail.ShowCloseButton = false;
            this.crvDeadTimeDetail.ShowParameterPanelButton = false;
            this.crvDeadTimeDetail.ShowRefreshButton = false;
            this.crvDeadTimeDetail.Size = new System.Drawing.Size(884, 543);
            this.crvDeadTimeDetail.TabIndex = 1;
            this.crvDeadTimeDetail.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmProductionReportByDeadTimeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(898, 577);
            this.Controls.Add(this.tbcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByDeadTimeReport";
            this.Text = "Reporte de Tiempos Muertos - Unificado - Detallado";
            this.Load += new System.EventHandler(this.frmProductionReportByDeadTimeReport_Load);
            this.tbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductionReportByDeadTime;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDeadTimeDetail;
        private rptProductionDeadTimeByDate rptProductionDeadTimeByDate1;
        private rptProductionDeadTimeByDateDetails rptProductionDeadTimeByDateDetails1;
    }
}