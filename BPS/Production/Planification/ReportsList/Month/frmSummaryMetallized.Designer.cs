namespace BPS
{
    partial class frmSummaryMetallized
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryMetallized));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpLocal = new System.Windows.Forms.TabPage();
            this.crvSummaryExtruder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpOpp = new System.Windows.Forms.TabPage();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbpLocal.SuspendLayout();
            this.tbpOpp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 38);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(361, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(219, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.CloseUp += new System.EventHandler(this.dtpDate_CloseUp);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(318, 15);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 13);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Fecha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(898, 475);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpLocal);
            this.tabControl1.Controls.Add(this.tbpOpp);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(892, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpLocal
            // 
            this.tbpLocal.Controls.Add(this.crvSummaryExtruder);
            this.tbpLocal.Location = new System.Drawing.Point(4, 22);
            this.tbpLocal.Name = "tbpLocal";
            this.tbpLocal.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLocal.Size = new System.Drawing.Size(884, 430);
            this.tbpLocal.TabIndex = 0;
            this.tbpLocal.Text = "Metalizadora Mensual Local";
            this.tbpLocal.UseVisualStyleBackColor = true;
            // 
            // crvSummaryExtruder
            // 
            this.crvSummaryExtruder.ActiveViewIndex = -1;
            this.crvSummaryExtruder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSummaryExtruder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSummaryExtruder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSummaryExtruder.Location = new System.Drawing.Point(3, 3);
            this.crvSummaryExtruder.Name = "crvSummaryExtruder";
            this.crvSummaryExtruder.ShowGroupTreeButton = false;
            this.crvSummaryExtruder.ShowParameterPanelButton = false;
            this.crvSummaryExtruder.ShowRefreshButton = false;
            this.crvSummaryExtruder.Size = new System.Drawing.Size(878, 424);
            this.crvSummaryExtruder.TabIndex = 0;
            this.crvSummaryExtruder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpOpp
            // 
            this.tbpOpp.Controls.Add(this.crystalReportViewer1);
            this.tbpOpp.Location = new System.Drawing.Point(4, 22);
            this.tbpOpp.Name = "tbpOpp";
            this.tbpOpp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOpp.Size = new System.Drawing.Size(884, 430);
            this.tbpOpp.TabIndex = 1;
            this.tbpOpp.Text = "Metalizadora Mensual Opp";
            this.tbpOpp.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowRefreshButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(878, 424);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSummaryMetallized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(898, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSummaryMetallized";
            this.Text = "Reporte Mensual de Metalizadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbpLocal.ResumeLayout(false);
            this.tbpOpp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.GroupBox groupBox2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSummaryExtruder;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpLocal;
        private System.Windows.Forms.TabPage tbpOpp;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}