namespace BPS
{
    partial class frmPalletByCellar23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletByCellar23));
            this.crvCellar23 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletByCellar231 = new BPS.Reports.rptPalletByCellar23();
            this.SuspendLayout();
            // 
            // crvCellar23
            // 
            this.crvCellar23.ActiveViewIndex = 0;
            this.crvCellar23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCellar23.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCellar23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCellar23.Location = new System.Drawing.Point(0, 0);
            this.crvCellar23.Name = "crvCellar23";
            this.crvCellar23.ReportSource = this.rptPalletByCellar231;
            this.crvCellar23.ShowParameterPanelButton = false;
            this.crvCellar23.ShowRefreshButton = false;
            this.crvCellar23.Size = new System.Drawing.Size(958, 572);
            this.crvCellar23.TabIndex = 0;
            this.crvCellar23.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletByCellar23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.Controls.Add(this.crvCellar23);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletByCellar23";
            this.Text = "Bodega 23";
            this.Load += new System.EventHandler(this.frmPalletByCellar23_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCellar23;
        private Reports.rptPalletByCellar23 rptPalletByCellar231;
    }
}