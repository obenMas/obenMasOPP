namespace BPS
{
    partial class frmCuttingOrderPositionSummaryDateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrderPositionSummaryDateReport));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.grpbCuttingOrderButtons = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCutter = new System.Windows.Forms.ComboBox();
            this.lblCutter = new System.Windows.Forms.Label();
            this.grpbReportCuttingOrder = new System.Windows.Forms.GroupBox();
            this.crvCuttingOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter.SuspendLayout();
            this.grpbCuttingOrderButtons.SuspendLayout();
            this.grpbReportCuttingOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.grpbInfo);
            this.grpbFilter.Controls.Add(this.grpbCuttingOrderButtons);
            this.grpbFilter.Controls.Add(this.lblDateEnd);
            this.grpbFilter.Controls.Add(this.dtpEndDate);
            this.grpbFilter.Controls.Add(this.lblInitDate);
            this.grpbFilter.Controls.Add(this.dtpInitDate);
            this.grpbFilter.Controls.Add(this.cmbCutter);
            this.grpbFilter.Controls.Add(this.lblCutter);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(1125, 131);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros ";
            // 
            // grpbInfo
            // 
            this.grpbInfo.Location = new System.Drawing.Point(4, 83);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(1058, 44);
            this.grpbInfo.TabIndex = 17;
            this.grpbInfo.TabStop = false;
            // 
            // grpbCuttingOrderButtons
            // 
            this.grpbCuttingOrderButtons.Controls.Add(this.btnFilter);
            this.grpbCuttingOrderButtons.Controls.Add(this.btnClearFilter);
            this.grpbCuttingOrderButtons.Location = new System.Drawing.Point(1063, 83);
            this.grpbCuttingOrderButtons.Name = "grpbCuttingOrderButtons";
            this.grpbCuttingOrderButtons.Size = new System.Drawing.Size(59, 44);
            this.grpbCuttingOrderButtons.TabIndex = 16;
            this.grpbCuttingOrderButtons.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(5, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilter.Location = new System.Drawing.Point(30, 14);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.Location = new System.Drawing.Point(595, 62);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(67, 15);
            this.lblDateEnd.TabIndex = 5;
            this.lblDateEnd.Text = "Fecha Fin :";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(668, 60);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(232, 21);
            this.dtpEndDate.TabIndex = 4;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(583, 25);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(79, 15);
            this.lblInitDate.TabIndex = 3;
            this.lblInitDate.Text = "Fecha Inicio :";
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(668, 23);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(232, 21);
            this.dtpInitDate.TabIndex = 2;
            // 
            // cmbCutter
            // 
            this.cmbCutter.FormattingEnabled = true;
            this.cmbCutter.Location = new System.Drawing.Point(297, 25);
            this.cmbCutter.Name = "cmbCutter";
            this.cmbCutter.Size = new System.Drawing.Size(201, 23);
            this.cmbCutter.TabIndex = 1;
            // 
            // lblCutter
            // 
            this.lblCutter.AutoSize = true;
            this.lblCutter.Location = new System.Drawing.Point(224, 28);
            this.lblCutter.Name = "lblCutter";
            this.lblCutter.Size = new System.Drawing.Size(67, 15);
            this.lblCutter.TabIndex = 0;
            this.lblCutter.Text = "Cortadora :";
            // 
            // grpbReportCuttingOrder
            // 
            this.grpbReportCuttingOrder.Controls.Add(this.crvCuttingOrder);
            this.grpbReportCuttingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbReportCuttingOrder.Location = new System.Drawing.Point(0, 131);
            this.grpbReportCuttingOrder.Name = "grpbReportCuttingOrder";
            this.grpbReportCuttingOrder.Size = new System.Drawing.Size(1125, 542);
            this.grpbReportCuttingOrder.TabIndex = 1;
            this.grpbReportCuttingOrder.TabStop = false;
            // 
            // crvCuttingOrder
            // 
            this.crvCuttingOrder.ActiveViewIndex = -1;
            this.crvCuttingOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCuttingOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCuttingOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCuttingOrder.Location = new System.Drawing.Point(3, 17);
            this.crvCuttingOrder.Name = "crvCuttingOrder";
            this.crvCuttingOrder.ShowCloseButton = false;
            this.crvCuttingOrder.ShowGroupTreeButton = false;
            this.crvCuttingOrder.ShowParameterPanelButton = false;
            this.crvCuttingOrder.ShowRefreshButton = false;
            this.crvCuttingOrder.Size = new System.Drawing.Size(1119, 522);
            this.crvCuttingOrder.TabIndex = 0;
            this.crvCuttingOrder.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCuttingOrderPositionSummaryDateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1125, 673);
            this.Controls.Add(this.grpbReportCuttingOrder);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrderPositionSummaryDateReport";
            this.Text = "Reporte de Combinaciones";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.grpbCuttingOrderButtons.ResumeLayout(false);
            this.grpbReportCuttingOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.ComboBox cmbCutter;
        private System.Windows.Forms.Label lblCutter;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.GroupBox grpbCuttingOrderButtons;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.GroupBox grpbReportCuttingOrder;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCuttingOrder;
    }
}