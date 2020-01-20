namespace BPS
{
    partial class frmPalletByCoilCellarReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletByCoilCellarReport));
            this.crvPalletCoilCellar = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptPalletByCoilCellarReport1 = new BPS.Reports.rptPalletByCoilCellarReport();
            this.SuspendLayout();
            // 
            // crvPalletCoilCellar
            // 
            this.crvPalletCoilCellar.ActiveViewIndex = 0;
            this.crvPalletCoilCellar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPalletCoilCellar.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPalletCoilCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPalletCoilCellar.Location = new System.Drawing.Point(0, 0);
            this.crvPalletCoilCellar.Name = "crvPalletCoilCellar";
            this.crvPalletCoilCellar.ReportSource = this.rptPalletByCoilCellarReport1;
            this.crvPalletCoilCellar.ShowGroupTreeButton = false;
            this.crvPalletCoilCellar.ShowParameterPanelButton = false;
            this.crvPalletCoilCellar.ShowRefreshButton = false;
            this.crvPalletCoilCellar.Size = new System.Drawing.Size(877, 546);
            this.crvPalletCoilCellar.TabIndex = 0;
            this.crvPalletCoilCellar.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletByCoilCellarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(877, 546);
            this.Controls.Add(this.crvPalletCoilCellar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletByCoilCellarReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Movimientos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPalletCoilCellar;
        private Reports.rptPalletByCoilCellarReport rptPalletByCoilCellarReport1;
    }
}