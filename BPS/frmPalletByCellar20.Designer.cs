namespace BPS
{
    partial class frmPalletByCellar20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletByCellar20));
            this.crvCellar18 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletByCellar201 = new BPS.Reports.rptPalletByCellar20();
            this.SuspendLayout();
            // 
            // crvCellar18
            // 
            this.crvCellar18.ActiveViewIndex = 0;
            this.crvCellar18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCellar18.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCellar18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCellar18.Location = new System.Drawing.Point(0, 0);
            this.crvCellar18.Name = "crvCellar18";
            this.crvCellar18.ReportSource = this.rptPalletByCellar201;
            this.crvCellar18.ShowParameterPanelButton = false;
            this.crvCellar18.ShowRefreshButton = false;
            this.crvCellar18.Size = new System.Drawing.Size(958, 572);
            this.crvCellar18.TabIndex = 0;
            this.crvCellar18.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletByCellar20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.Controls.Add(this.crvCellar18);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletByCellar20";
            this.Text = "Bodega 18";
            this.Load += new System.EventHandler(this.frmPalletByCellar20_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCellar18;
        private Reports.rptPalletByCellar20 rptPalletByCellar201;
    }
}