namespace BPS
{
    partial class frmSalesOrderQuantityByCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderQuantityByCustomer));
            this.crvSalesOrderByCustomer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvSalesOrderByCustomer
            // 
            this.crvSalesOrderByCustomer.ActiveViewIndex = -1;
            this.crvSalesOrderByCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderByCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderByCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderByCustomer.Location = new System.Drawing.Point(3, 17);
            this.crvSalesOrderByCustomer.Name = "crvSalesOrderByCustomer";
            this.crvSalesOrderByCustomer.ShowParameterPanelButton = false;
            this.crvSalesOrderByCustomer.ShowRefreshButton = false;
            this.crvSalesOrderByCustomer.Size = new System.Drawing.Size(988, 512);
            this.crvSalesOrderByCustomer.TabIndex = 0;
            this.crvSalesOrderByCustomer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.grpbFilter.TabIndex = 2;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
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
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(205, 13);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(243, 21);
            this.dtpInitDate.TabIndex = 7;
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
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(472, 17);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(61, 15);
            this.lblDateLabel.TabIndex = 3;
            this.lblDateLabel.Text = "Fecha Fin";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(539, 13);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(243, 21);
            this.dtpEndDate.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crvSalesOrderByCustomer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 532);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // frmSalesOrderQuantityByCustomer
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
            this.Name = "frmSalesOrderQuantityByCustomer";
            this.Text = "Estadísticas País, Cliente, Películas, Mes";
            this.Load += new System.EventHandler(this.frmSalesOrderQuantityByCustomer_Load);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderByCustomer;
        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}