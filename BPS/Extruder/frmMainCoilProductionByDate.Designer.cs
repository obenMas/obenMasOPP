namespace BPS
{
    partial class frmMainCoilProductionByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilProductionByDate));
            this.grpbInfoCutter = new System.Windows.Forms.GroupBox();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.grpbReport = new System.Windows.Forms.GroupBox();
            this.crvSummaryCutter = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbInfoCutter.SuspendLayout();
            this.grpbReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInfoCutter
            // 
            this.grpbInfoCutter.Controls.Add(this.cmbMachine);
            this.grpbInfoCutter.Controls.Add(this.lblMachine);
            this.grpbInfoCutter.Controls.Add(this.lblTo);
            this.grpbInfoCutter.Controls.Add(this.lblFrom);
            this.grpbInfoCutter.Controls.Add(this.btnShow);
            this.grpbInfoCutter.Controls.Add(this.dtpEndDate);
            this.grpbInfoCutter.Controls.Add(this.dtpInitDate);
            this.grpbInfoCutter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfoCutter.Location = new System.Drawing.Point(0, 0);
            this.grpbInfoCutter.Name = "grpbInfoCutter";
            this.grpbInfoCutter.Size = new System.Drawing.Size(989, 51);
            this.grpbInfoCutter.TabIndex = 0;
            this.grpbInfoCutter.TabStop = false;
            this.grpbInfoCutter.Text = "Máquina";
            // 
            // cmbMachine
            // 
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(81, 18);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(227, 23);
            this.cmbMachine.TabIndex = 34;
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(17, 22);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMachine.TabIndex = 33;
            this.lblMachine.Text = "Máquina";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(619, 22);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(50, 15);
            this.lblTo.TabIndex = 32;
            this.lblTo.Text = "hasta el";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(316, 22);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(26, 15);
            this.lblFrom.TabIndex = 32;
            this.lblFrom.Text = "Del";
            // 
            // btnShow
            // 
            this.btnShow.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShow.Location = new System.Drawing.Point(946, 17);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(25, 25);
            this.btnShow.TabIndex = 31;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(677, 19);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(261, 21);
            this.dtpEndDate.TabIndex = 0;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(350, 19);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(261, 21);
            this.dtpInitDate.TabIndex = 0;
            // 
            // grpbReport
            // 
            this.grpbReport.Controls.Add(this.crvSummaryCutter);
            this.grpbReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbReport.Location = new System.Drawing.Point(0, 51);
            this.grpbReport.Name = "grpbReport";
            this.grpbReport.Size = new System.Drawing.Size(989, 495);
            this.grpbReport.TabIndex = 1;
            this.grpbReport.TabStop = false;
            this.grpbReport.Text = "Reporte";
            // 
            // crvSummaryCutter
            // 
            this.crvSummaryCutter.ActiveViewIndex = -1;
            this.crvSummaryCutter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSummaryCutter.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSummaryCutter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSummaryCutter.Location = new System.Drawing.Point(3, 17);
            this.crvSummaryCutter.Name = "crvSummaryCutter";
            this.crvSummaryCutter.ShowCloseButton = false;
            this.crvSummaryCutter.ShowGroupTreeButton = false;
            this.crvSummaryCutter.ShowParameterPanelButton = false;
            this.crvSummaryCutter.ShowRefreshButton = false;
            this.crvSummaryCutter.Size = new System.Drawing.Size(983, 475);
            this.crvSummaryCutter.TabIndex = 0;
            this.crvSummaryCutter.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMainCoilProductionByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 546);
            this.Controls.Add(this.grpbReport);
            this.Controls.Add(this.grpbInfoCutter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilProductionByDate";
            this.Text = "Producción Diaria";
            this.Load += new System.EventHandler(this.frmSummaryCutter_Load);
            this.grpbInfoCutter.ResumeLayout(false);
            this.grpbInfoCutter.PerformLayout();
            this.grpbReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfoCutter;
        private System.Windows.Forms.GroupBox grpbReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSummaryCutter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label lblMachine;
    }
}