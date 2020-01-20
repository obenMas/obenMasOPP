namespace BPS
{
    partial class frmCellarShipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCellarShipping));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.btnReportProduct = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbcReports = new System.Windows.Forms.TabControl();
            this.tbpUnified = new System.Windows.Forms.TabPage();
            this.crvUnified = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpFull = new System.Windows.Forms.TabPage();
            this.crvFull = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpProduct = new System.Windows.Forms.TabPage();
            this.tbpMaquile = new System.Windows.Forms.TabPage();
            this.tbcSubMainMaquile = new System.Windows.Forms.TabControl();
            this.tbpMaquileShipping = new System.Windows.Forms.TabPage();
            this.crvMaquile = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMaquile = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpMill = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crvMill = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMill = new System.Windows.Forms.Button();
            this.dtpTimeMill = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbFilter.SuspendLayout();
            this.tbcReports.SuspendLayout();
            this.tbpUnified.SuspendLayout();
            this.tbpFull.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpProduct.SuspendLayout();
            this.tbpMaquile.SuspendLayout();
            this.tbcSubMainMaquile.SuspendLayout();
            this.tbpMaquileShipping.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpMill.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.btnReportProduct);
            this.grpbFilter.Controls.Add(this.dtpDate);
            this.grpbFilter.Controls.Add(this.lblDate);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(3, 3);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(988, 39);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            // 
            // btnReportProduct
            // 
            this.btnReportProduct.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReportProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportProduct.Location = new System.Drawing.Point(644, 10);
            this.btnReportProduct.Name = "btnReportProduct";
            this.btnReportProduct.Size = new System.Drawing.Size(25, 25);
            this.btnReportProduct.TabIndex = 35;
            this.btnReportProduct.UseVisualStyleBackColor = true;
            this.btnReportProduct.Click += new System.EventHandler(this.btnReportProduct_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(391, 13);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(247, 21);
            this.dtpDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(344, 14);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Fecha";
            // 
            // tbcReports
            // 
            this.tbcReports.Controls.Add(this.tbpUnified);
            this.tbcReports.Controls.Add(this.tbpFull);
            this.tbcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcReports.Location = new System.Drawing.Point(3, 42);
            this.tbcReports.Name = "tbcReports";
            this.tbcReports.SelectedIndex = 0;
            this.tbcReports.Size = new System.Drawing.Size(988, 527);
            this.tbcReports.TabIndex = 1;
            // 
            // tbpUnified
            // 
            this.tbpUnified.Controls.Add(this.crvUnified);
            this.tbpUnified.Location = new System.Drawing.Point(4, 24);
            this.tbpUnified.Name = "tbpUnified";
            this.tbpUnified.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnified.Size = new System.Drawing.Size(980, 499);
            this.tbpUnified.TabIndex = 0;
            this.tbpUnified.Text = "Despacho Unificado";
            this.tbpUnified.UseVisualStyleBackColor = true;
            // 
            // crvUnified
            // 
            this.crvUnified.ActiveViewIndex = -1;
            this.crvUnified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUnified.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvUnified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUnified.Location = new System.Drawing.Point(3, 3);
            this.crvUnified.Name = "crvUnified";
            this.crvUnified.ShowGroupTreeButton = false;
            this.crvUnified.ShowParameterPanelButton = false;
            this.crvUnified.ShowRefreshButton = false;
            this.crvUnified.ShowZoomButton = false;
            this.crvUnified.Size = new System.Drawing.Size(974, 493);
            this.crvUnified.TabIndex = 0;
            this.crvUnified.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpFull
            // 
            this.tbpFull.Controls.Add(this.crvFull);
            this.tbpFull.Location = new System.Drawing.Point(4, 24);
            this.tbpFull.Name = "tbpFull";
            this.tbpFull.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFull.Size = new System.Drawing.Size(980, 499);
            this.tbpFull.TabIndex = 1;
            this.tbpFull.Text = "Despacho Desglosado";
            this.tbpFull.UseVisualStyleBackColor = true;
            // 
            // crvFull
            // 
            this.crvFull.ActiveViewIndex = -1;
            this.crvFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvFull.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvFull.Location = new System.Drawing.Point(3, 3);
            this.crvFull.Name = "crvFull";
            this.crvFull.ShowGroupTreeButton = false;
            this.crvFull.ShowParameterPanelButton = false;
            this.crvFull.ShowRefreshButton = false;
            this.crvFull.ShowZoomButton = false;
            this.crvFull.Size = new System.Drawing.Size(974, 493);
            this.crvFull.TabIndex = 0;
            this.crvFull.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpProduct);
            this.tbcMain.Controls.Add(this.tbpMaquile);
            this.tbcMain.Controls.Add(this.tbpMill);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1002, 600);
            this.tbcMain.TabIndex = 2;
            // 
            // tbpProduct
            // 
            this.tbpProduct.Controls.Add(this.tbcReports);
            this.tbpProduct.Controls.Add(this.grpbFilter);
            this.tbpProduct.Location = new System.Drawing.Point(4, 24);
            this.tbpProduct.Name = "tbpProduct";
            this.tbpProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProduct.Size = new System.Drawing.Size(994, 572);
            this.tbpProduct.TabIndex = 0;
            this.tbpProduct.Text = "Despacho Producto Terminado";
            this.tbpProduct.UseVisualStyleBackColor = true;
            // 
            // tbpMaquile
            // 
            this.tbpMaquile.Controls.Add(this.tbcSubMainMaquile);
            this.tbpMaquile.Controls.Add(this.groupBox1);
            this.tbpMaquile.Location = new System.Drawing.Point(4, 24);
            this.tbpMaquile.Name = "tbpMaquile";
            this.tbpMaquile.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMaquile.Size = new System.Drawing.Size(994, 572);
            this.tbpMaquile.TabIndex = 1;
            this.tbpMaquile.Text = "Despacho Maquilas Metalizadas";
            this.tbpMaquile.UseVisualStyleBackColor = true;
            // 
            // tbcSubMainMaquile
            // 
            this.tbcSubMainMaquile.Controls.Add(this.tbpMaquileShipping);
            this.tbcSubMainMaquile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcSubMainMaquile.Location = new System.Drawing.Point(3, 42);
            this.tbcSubMainMaquile.Name = "tbcSubMainMaquile";
            this.tbcSubMainMaquile.SelectedIndex = 0;
            this.tbcSubMainMaquile.Size = new System.Drawing.Size(988, 527);
            this.tbcSubMainMaquile.TabIndex = 3;
            // 
            // tbpMaquileShipping
            // 
            this.tbpMaquileShipping.Controls.Add(this.crvMaquile);
            this.tbpMaquileShipping.Location = new System.Drawing.Point(4, 24);
            this.tbpMaquileShipping.Name = "tbpMaquileShipping";
            this.tbpMaquileShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMaquileShipping.Size = new System.Drawing.Size(980, 499);
            this.tbpMaquileShipping.TabIndex = 0;
            this.tbpMaquileShipping.Text = "Despacho";
            this.tbpMaquileShipping.UseVisualStyleBackColor = true;
            // 
            // crvMaquile
            // 
            this.crvMaquile.ActiveViewIndex = -1;
            this.crvMaquile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMaquile.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMaquile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMaquile.Location = new System.Drawing.Point(3, 3);
            this.crvMaquile.Name = "crvMaquile";
            this.crvMaquile.ShowParameterPanelButton = false;
            this.crvMaquile.ShowRefreshButton = false;
            this.crvMaquile.Size = new System.Drawing.Size(974, 493);
            this.crvMaquile.TabIndex = 0;
            this.crvMaquile.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMaquile);
            this.groupBox1.Controls.Add(this.dtpTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(988, 39);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnMaquile
            // 
            this.btnMaquile.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnMaquile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaquile.Location = new System.Drawing.Point(644, 10);
            this.btnMaquile.Name = "btnMaquile";
            this.btnMaquile.Size = new System.Drawing.Size(25, 25);
            this.btnMaquile.TabIndex = 35;
            this.btnMaquile.UseVisualStyleBackColor = true;
            this.btnMaquile.Click += new System.EventHandler(this.btnMaquile_Click);
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(391, 13);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(247, 21);
            this.dtpTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // tbpMill
            // 
            this.tbpMill.Controls.Add(this.tabControl1);
            this.tbpMill.Controls.Add(this.groupBox2);
            this.tbpMill.Location = new System.Drawing.Point(4, 24);
            this.tbpMill.Name = "tbpMill";
            this.tbpMill.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMill.Size = new System.Drawing.Size(994, 572);
            this.tbpMill.TabIndex = 2;
            this.tbpMill.Text = "Despacho Re-Procesado";
            this.tbpMill.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(988, 527);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crvMill);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(980, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Despacho";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crvMill
            // 
            this.crvMill.ActiveViewIndex = -1;
            this.crvMill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMill.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMill.Location = new System.Drawing.Point(3, 3);
            this.crvMill.Name = "crvMill";
            this.crvMill.ShowParameterPanelButton = false;
            this.crvMill.ShowRefreshButton = false;
            this.crvMill.Size = new System.Drawing.Size(974, 493);
            this.crvMill.TabIndex = 0;
            this.crvMill.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMill);
            this.groupBox2.Controls.Add(this.dtpTimeMill);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 39);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnMill
            // 
            this.btnMill.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnMill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMill.Location = new System.Drawing.Point(644, 10);
            this.btnMill.Name = "btnMill";
            this.btnMill.Size = new System.Drawing.Size(25, 25);
            this.btnMill.TabIndex = 35;
            this.btnMill.UseVisualStyleBackColor = true;
            this.btnMill.Click += new System.EventHandler(this.btnMill_Click);
            // 
            // dtpTimeMill
            // 
            this.dtpTimeMill.Location = new System.Drawing.Point(391, 13);
            this.dtpTimeMill.Name = "dtpTimeMill";
            this.dtpTimeMill.Size = new System.Drawing.Size(247, 21);
            this.dtpTimeMill.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha";
            // 
            // frmCellarShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1002, 600);
            this.Controls.Add(this.tbcMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCellarShipping";
            this.Text = "Reporte de Despachos";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.tbcReports.ResumeLayout(false);
            this.tbpUnified.ResumeLayout(false);
            this.tbpFull.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tbpProduct.ResumeLayout(false);
            this.tbpMaquile.ResumeLayout(false);
            this.tbcSubMainMaquile.ResumeLayout(false);
            this.tbpMaquileShipping.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpMill.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TabControl tbcReports;
        private System.Windows.Forms.TabPage tbpUnified;
        private System.Windows.Forms.TabPage tbpFull;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUnified;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvFull;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpProduct;
        private System.Windows.Forms.TabPage tbpMaquile;
        private System.Windows.Forms.Button btnReportProduct;
        private System.Windows.Forms.TabControl tbcSubMainMaquile;
        private System.Windows.Forms.TabPage tbpMaquileShipping;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMaquile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMaquile;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpMill;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMill;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMill;
        private System.Windows.Forms.DateTimePicker dtpTimeMill;
        private System.Windows.Forms.Label label2;
    }
}