namespace BPS
{
    partial class frmCubeReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCubeReport));
            this.crvCube = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptCubeReport1 = new BPS.Reports.rptCubeReport();
            this.SuspendLayout();
            // 
            // crvCube
            // 
            this.crvCube.ActiveViewIndex = 0;
            this.crvCube.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCube.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCube.Location = new System.Drawing.Point(0, 0);
            this.crvCube.Name = "crvCube";
            this.crvCube.ReportSource = this.rptCubeReport1;
            this.crvCube.ShowGroupTreeButton = false;
            this.crvCube.ShowParameterPanelButton = false;
            this.crvCube.ShowRefreshButton = false;
            this.crvCube.Size = new System.Drawing.Size(880, 494);
            this.crvCube.TabIndex = 0;
            this.crvCube.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCubeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(880, 494);
            this.Controls.Add(this.crvCube);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCubeReport";
            this.Text = "Reporte de Cubicaje";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCube;
        private Reports.rptCubeReport rptCubeReport1;
    }
}