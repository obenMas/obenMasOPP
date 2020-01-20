namespace BPS.Reporting.ProductionReports.Formulation
{
    partial class frmFormulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFormulation));
            this.crvFormulation = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptFormulationH1 = new BPS.Reporting.ProductionReports.Formulation.rptFormulationH();
            this.SuspendLayout();
            // 
            // crvFormulation
            // 
            this.crvFormulation.ActiveViewIndex = 0;
            this.crvFormulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFormulation.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFormulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFormulation.Location = new System.Drawing.Point(0, 0);
            this.crvFormulation.Name = "crvFormulation";
            this.crvFormulation.ReportSource = this.rptFormulationH1;
            this.crvFormulation.ShowGroupTreeButton = false;
            this.crvFormulation.ShowParameterPanelButton = false;
            this.crvFormulation.ShowRefreshButton = false;
            this.crvFormulation.Size = new System.Drawing.Size(892, 562);
            this.crvFormulation.TabIndex = 0;
            this.crvFormulation.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmFormulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(892, 562);
            this.Controls.Add(this.crvFormulation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFormulation";
            this.Text = "Hoja de Formulación";
            this.Load += new System.EventHandler(this.frmFormulation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFormulation;
        private rptFormulationH rptFormulationH1;
    }
}