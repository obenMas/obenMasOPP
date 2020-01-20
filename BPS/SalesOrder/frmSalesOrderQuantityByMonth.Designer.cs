namespace BPS
{
    partial class frmSalesOrderQuantityByMonth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderQuantityByMonth));
            this.crvSalesOrderQuantityByMonth = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvSalesOrderQuantityByMonth
            // 
            this.crvSalesOrderQuantityByMonth.ActiveViewIndex = -1;
            this.crvSalesOrderQuantityByMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderQuantityByMonth.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderQuantityByMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderQuantityByMonth.Location = new System.Drawing.Point(3, 17);
            this.crvSalesOrderQuantityByMonth.Name = "crvSalesOrderQuantityByMonth";
            this.crvSalesOrderQuantityByMonth.ShowParameterPanelButton = false;
            this.crvSalesOrderQuantityByMonth.ShowRefreshButton = false;
            this.crvSalesOrderQuantityByMonth.Size = new System.Drawing.Size(988, 512);
            this.crvSalesOrderQuantityByMonth.TabIndex = 0;
            this.crvSalesOrderQuantityByMonth.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crvSalesOrderQuantityByMonth);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 532);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(539, 13);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(243, 21);
            this.dtpEndDate.TabIndex = 1;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(472, 17);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(61, 15);
            this.lblDateLabel.TabIndex = 3;
            this.lblDateLabel.Text = "Fecha Fin";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(844, 10);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 6;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(205, 13);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(243, 21);
            this.dtpInitDate.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha Inicio";
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.label1);
            this.grpbFilter.Controls.Add(this.dtpInitDate);
            this.grpbFilter.Controls.Add(this.btnReport);
            this.grpbFilter.Controls.Add(this.lblDateLabel);
            this.grpbFilter.Controls.Add(this.dtpEndDate);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(994, 40);
            this.grpbFilter.TabIndex = 1;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // frmSalesOrderQuantityByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(994, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderQuantityByMonth";
            this.Text = "Estadísticas Películas, Kilos";
            this.Load += new System.EventHandler(this.frmSalesOrderQuantityByMonth_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderQuantityByMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbFilter;
    }
}