namespace BPS
{
    partial class frmProductionReportByOrderViewBCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByOrderViewBCK));
            this.crvProductionByOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptProductionByOrder1 = new BPS.Reports.rptProductionByOrder();
            this.SuspendLayout();
            // 
            // crvProductionByOrder
            // 
            this.crvProductionByOrder.ActiveViewIndex = 0;
            this.crvProductionByOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvProductionByOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvProductionByOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvProductionByOrder.Location = new System.Drawing.Point(0, 0);
            this.crvProductionByOrder.Name = "crvProductionByOrder";
            this.crvProductionByOrder.ReportSource = this.rptProductionByOrder1;
            this.crvProductionByOrder.ShowCloseButton = false;
            this.crvProductionByOrder.ShowGotoPageButton = false;
            this.crvProductionByOrder.ShowGroupTreeButton = false;
            this.crvProductionByOrder.ShowPageNavigateButtons = false;
            this.crvProductionByOrder.ShowParameterPanelButton = false;
            this.crvProductionByOrder.ShowRefreshButton = false;
            this.crvProductionByOrder.ShowTextSearchButton = false;
            this.crvProductionByOrder.ShowZoomButton = false;
            this.crvProductionByOrder.Size = new System.Drawing.Size(998, 503);
            this.crvProductionByOrder.TabIndex = 0;
            this.crvProductionByOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvProductionByOrder.Load += new System.EventHandler(this.crvProductionByOrder_Load);
            // 
            // frmProductionReportByOrderViewBCK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(998, 503);
            this.Controls.Add(this.crvProductionByOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByOrderViewBCK";
            this.Text = "Reporte Producción Por Orden";
            this.Load += new System.EventHandler(this.frmProductionReportByOrderViewBCK_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductionByOrder;
        private Reports.rptProductionByOrder rptProductionByOrder1;
    }
}