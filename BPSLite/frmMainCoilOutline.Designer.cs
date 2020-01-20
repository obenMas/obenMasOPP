namespace BPS
{
    partial class frmMainCoilOutline
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilOutline));
            this.crvMainCoilOutline = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMainCoilOutline1 = new BPS.Lite.Reports.rptMainCoilOutline();
            this.SuspendLayout();
            // 
            // crvMainCoilOutline
            // 
            this.crvMainCoilOutline.ActiveViewIndex = -1;
            this.crvMainCoilOutline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMainCoilOutline.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMainCoilOutline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMainCoilOutline.Location = new System.Drawing.Point(0, 0);
            this.crvMainCoilOutline.Name = "crvMainCoilOutline";
            this.crvMainCoilOutline.ReportSource = this.rptMainCoilOutline1;
            this.crvMainCoilOutline.ReuseParameterValuesOnRefresh = true;
            this.crvMainCoilOutline.ShowCloseButton = false;
            this.crvMainCoilOutline.ShowGroupTreeButton = false;
            this.crvMainCoilOutline.ShowLogo = false;
            this.crvMainCoilOutline.ShowParameterPanelButton = false;
            this.crvMainCoilOutline.ShowRefreshButton = false;
            this.crvMainCoilOutline.Size = new System.Drawing.Size(948, 520);
            this.crvMainCoilOutline.TabIndex = 0;
            this.crvMainCoilOutline.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMainCoilOutline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 520);
            this.Controls.Add(this.crvMainCoilOutline);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilOutline";
            this.Text = "Perfil de bobina Madre";
            this.Load += new System.EventHandler(this.frmMainCoilOutline_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMainCoilOutline;
        private BPS.Lite.Reports.rptMainCoilOutline rptMainCoilOutline1;
    }
}