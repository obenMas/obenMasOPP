namespace BPS.Reporting.ProductionReports.SummaryExtruder
{
    partial class frmSummaryExtruder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryExtruder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpUnit = new System.Windows.Forms.TabPage();
            this.crvSummaryExtruderUnit = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpDetail = new System.Windows.Forms.TabPage();
            this.crvSummaryExtruderDetails = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpUnit.SuspendLayout();
            this.tbpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "MMMM";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(449, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(100, 21);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.CloseUp += new System.EventHandler(this.dtpDate_CloseUp);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(415, 16);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(31, 15);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Mes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbcMain);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(979, 553);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpUnit);
            this.tbcMain.Controls.Add(this.tbpDetail);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(3, 17);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(973, 533);
            this.tbcMain.TabIndex = 0;
            // 
            // tbpUnit
            // 
            this.tbpUnit.Controls.Add(this.crvSummaryExtruderUnit);
            this.tbpUnit.Location = new System.Drawing.Point(4, 24);
            this.tbpUnit.Name = "tbpUnit";
            this.tbpUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnit.Size = new System.Drawing.Size(965, 505);
            this.tbpUnit.TabIndex = 0;
            this.tbpUnit.UseVisualStyleBackColor = true;
            // 
            // crvSummaryExtruderUnit
            // 
            this.crvSummaryExtruderUnit.ActiveViewIndex = -1;
            this.crvSummaryExtruderUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSummaryExtruderUnit.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSummaryExtruderUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSummaryExtruderUnit.Location = new System.Drawing.Point(3, 3);
            this.crvSummaryExtruderUnit.Name = "crvSummaryExtruderUnit";
            this.crvSummaryExtruderUnit.ShowGroupTreeButton = false;
            this.crvSummaryExtruderUnit.ShowParameterPanelButton = false;
            this.crvSummaryExtruderUnit.ShowRefreshButton = false;
            this.crvSummaryExtruderUnit.Size = new System.Drawing.Size(959, 499);
            this.crvSummaryExtruderUnit.TabIndex = 1;
            this.crvSummaryExtruderUnit.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpDetail
            // 
            this.tbpDetail.Controls.Add(this.crvSummaryExtruderDetails);
            this.tbpDetail.Location = new System.Drawing.Point(4, 24);
            this.tbpDetail.Name = "tbpDetail";
            this.tbpDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetail.Size = new System.Drawing.Size(950, 462);
            this.tbpDetail.TabIndex = 1;
            this.tbpDetail.UseVisualStyleBackColor = true;
            // 
            // crvSummaryExtruderDetails
            // 
            this.crvSummaryExtruderDetails.ActiveViewIndex = -1;
            this.crvSummaryExtruderDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSummaryExtruderDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSummaryExtruderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSummaryExtruderDetails.Location = new System.Drawing.Point(3, 3);
            this.crvSummaryExtruderDetails.Name = "crvSummaryExtruderDetails";
            this.crvSummaryExtruderDetails.ShowGroupTreeButton = false;
            this.crvSummaryExtruderDetails.ShowParameterPanelButton = false;
            this.crvSummaryExtruderDetails.ShowRefreshButton = false;
            this.crvSummaryExtruderDetails.Size = new System.Drawing.Size(944, 456);
            this.crvSummaryExtruderDetails.TabIndex = 1;
            this.crvSummaryExtruderDetails.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSummaryExtruder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(979, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSummaryExtruder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tbpUnit.ResumeLayout(false);
            this.tbpDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpUnit;
        private System.Windows.Forms.TabPage tbpDetail;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbldate;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSummaryExtruderUnit;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSummaryExtruderDetails;
    }
}