namespace BPS
{
    partial class frmSalesOrderReportByNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderReportByNumber));
            this.crvSalesOrderReportByNumber = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSalesOrderReportByNumber1 = new BPS.Reports.rptSalesOrderReportByNumber();
            this.SuspendLayout();
            // 
            // crvSalesOrderReportByNumber
            // 
            this.crvSalesOrderReportByNumber.ActiveViewIndex = 0;
            this.crvSalesOrderReportByNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderReportByNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderReportByNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderReportByNumber.Location = new System.Drawing.Point(0, 0);
            this.crvSalesOrderReportByNumber.Name = "crvSalesOrderReportByNumber";
            this.crvSalesOrderReportByNumber.ReportSource = this.rptSalesOrderReportByNumber1;
            this.crvSalesOrderReportByNumber.ShowGroupTreeButton = false;
            this.crvSalesOrderReportByNumber.ShowParameterPanelButton = false;
            this.crvSalesOrderReportByNumber.ShowRefreshButton = false;
            this.crvSalesOrderReportByNumber.Size = new System.Drawing.Size(1086, 601);
            this.crvSalesOrderReportByNumber.TabIndex = 0;
            this.crvSalesOrderReportByNumber.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSalesOrderReportByNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1086, 601);
            this.Controls.Add(this.crvSalesOrderReportByNumber);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderReportByNumber";
            this.Text = "Reporte de Kilos pendientes por Nro. de Orden";
            this.Load += new System.EventHandler(this.frmSalesOrderReportByNumber_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderReportByNumber;
        private Reports.rptSalesOrderReportByNumber rptSalesOrderReportByNumber1;
    }
}