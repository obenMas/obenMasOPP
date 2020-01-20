namespace BPS
{
    partial class frmMainCoilLabel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilLabel));
            this.crvLabel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptMainCoilLabel1 = new BPS.Reports.Control.rptMainCoilLabel();
            this.SuspendLayout();
            // 
            // crvLabel
            // 
            this.crvLabel.ActiveViewIndex = 0;
            this.crvLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLabel.Location = new System.Drawing.Point(0, 0);
            this.crvLabel.Name = "crvLabel";
            this.crvLabel.ReportSource = this.rptMainCoilLabel1;
            this.crvLabel.ShowCloseButton = false;
            this.crvLabel.ShowGroupTreeButton = false;
            this.crvLabel.ShowLogo = false;
            this.crvLabel.ShowParameterPanelButton = false;
            this.crvLabel.ShowRefreshButton = false;
            this.crvLabel.Size = new System.Drawing.Size(866, 605);
            this.crvLabel.TabIndex = 0;
            this.crvLabel.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMainCoilLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 605);
            this.Controls.Add(this.crvLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilLabel";
            this.Text = "Etiqueta de bonina madre";
            this.Load += new System.EventHandler(this.frmMainCoilLabel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvLabel;
        private Reports.Control.rptMainCoilLabel rptMainCoilLabel1;
    }
}