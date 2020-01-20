namespace BPS
{
    partial class frmProductionReportByOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByOrderView));
            this.crvProductionByOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptProductionByLotnumber1 = new BPS.Reports.rptProductionByLotnumber();
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
            this.crvProductionByOrder.ReportSource = this.rptProductionByLotnumber1;
            this.crvProductionByOrder.ShowGroupTreeButton = false;
            this.crvProductionByOrder.ShowParameterPanelButton = false;
            this.crvProductionByOrder.ShowRefreshButton = false;
            this.crvProductionByOrder.Size = new System.Drawing.Size(871, 578);
            this.crvProductionByOrder.TabIndex = 0;
            this.crvProductionByOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmProductionReportByOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(871, 578);
            this.Controls.Add(this.crvProductionByOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByOrderView";
            this.Text = "Reporte Corrida Completa";
            this.Load += new System.EventHandler(this.frmProductionReportByOrderView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvProductionByOrder;
        private Reports.rptProductionByLotnumber rptProductionByLotnumber1;
    }
}