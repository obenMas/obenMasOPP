namespace BPS
{
    partial class frmPalletByCellarMaquile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletByCellarMaquile));
            this.crvCellarReturn = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMaquileList1 = new BPS.Reports.rptMaquileList();
            this.SuspendLayout();
            // 
            // crvCellarReturn
            // 
            this.crvCellarReturn.ActiveViewIndex = 0;
            this.crvCellarReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCellarReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCellarReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCellarReturn.Location = new System.Drawing.Point(0, 0);
            this.crvCellarReturn.Name = "crvCellarReturn";
            this.crvCellarReturn.ReportSource = this.rptMaquileList1;
            this.crvCellarReturn.ShowParameterPanelButton = false;
            this.crvCellarReturn.ShowRefreshButton = false;
            this.crvCellarReturn.Size = new System.Drawing.Size(958, 572);
            this.crvCellarReturn.TabIndex = 0;
            this.crvCellarReturn.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletByCellarMaquile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.Controls.Add(this.crvCellarReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletByCellarMaquile";
            this.Text = "Bodega Maquilas";
            this.Load += new System.EventHandler(this.frmPalletByCellarMaquile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCellarReturn;
        private Reports.rptMaquileList rptMaquileList1;
    }
}