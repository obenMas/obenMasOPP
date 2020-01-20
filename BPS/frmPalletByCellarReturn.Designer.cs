namespace BPS
{
    partial class frmPalletByCellarReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletByCellarReturn));
            this.crvCellarReturn = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptReturnCellar1 = new BPS.Reports.rptReturnCellar();
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
            this.crvCellarReturn.ReportSource = this.rptReturnCellar1;
            this.crvCellarReturn.ShowParameterPanelButton = false;
            this.crvCellarReturn.ShowRefreshButton = false;
            this.crvCellarReturn.Size = new System.Drawing.Size(958, 572);
            this.crvCellarReturn.TabIndex = 0;
            this.crvCellarReturn.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmPalletByCellarReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 572);
            this.Controls.Add(this.crvCellarReturn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletByCellarReturn";
            this.Text = "Bodega Devoluciones";
            this.Load += new System.EventHandler(this.frmPalletByCellarReturn_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCellarReturn;
        private Reports.rptReturnCellar rptReturnCellar1;
    }
}