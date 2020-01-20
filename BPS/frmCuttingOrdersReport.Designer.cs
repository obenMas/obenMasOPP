namespace BPS
{
    partial class frmCuttingOrdersReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrdersReport));
            this.crvCuttingIOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCuttingOrderByMainCoil1 = new BPS.Reports.rptCuttingOrderByMainCoil();
            this.SuspendLayout();
            // 
            // crvCuttingIOrder
            // 
            this.crvCuttingIOrder.ActiveViewIndex = 0;
            this.crvCuttingIOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCuttingIOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCuttingIOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCuttingIOrder.Location = new System.Drawing.Point(0, 0);
            this.crvCuttingIOrder.Name = "crvCuttingIOrder";
            this.crvCuttingIOrder.ReportSource = this.rptCuttingOrderByMainCoil1;
            this.crvCuttingIOrder.ShowCloseButton = false;
            this.crvCuttingIOrder.ShowGroupTreeButton = false;
            this.crvCuttingIOrder.ShowParameterPanelButton = false;
            this.crvCuttingIOrder.ShowRefreshButton = false;
            this.crvCuttingIOrder.ShowTextSearchButton = false;
            this.crvCuttingIOrder.ShowZoomButton = false;
            this.crvCuttingIOrder.Size = new System.Drawing.Size(939, 482);
            this.crvCuttingIOrder.TabIndex = 0;
            this.crvCuttingIOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCuttingOrdersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(939, 482);
            this.Controls.Add(this.crvCuttingIOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrdersReport";
            this.Text = "Ordenes de Corte";
            this.Load += new System.EventHandler(this.frmCuttingOrdersReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCuttingIOrder;
        private Reports.rptCuttingOrderByMainCoil rptCuttingOrderByMainCoil1;
    }
}