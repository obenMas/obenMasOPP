namespace BPS
{
    partial class frmShippingExportToSiigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingExportToSiigo));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcShippingCellar = new System.Windows.Forms.TabControl();
            this.tbpSalesOrder = new System.Windows.Forms.TabPage();
            this.crvSalesOrderUnified = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcShippingCellar.SuspendLayout();
            this.tbpSalesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.dtpDate);
            this.grpbFilter.Controls.Add(this.lblDateLabel);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(1043, 47);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(418, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 21);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.CloseUp += new System.EventHandler(this.dtpDate_CloseUp);
            this.dtpDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDate_KeyDown);
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(365, 17);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(47, 15);
            this.lblDateLabel.TabIndex = 0;
            this.lblDateLabel.Text = "Fecha :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbcShippingCellar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 524);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tbcShippingCellar
            // 
            this.tbcShippingCellar.Controls.Add(this.tbpSalesOrder);
            this.tbcShippingCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcShippingCellar.Location = new System.Drawing.Point(3, 17);
            this.tbcShippingCellar.Name = "tbcShippingCellar";
            this.tbcShippingCellar.SelectedIndex = 0;
            this.tbcShippingCellar.Size = new System.Drawing.Size(1037, 504);
            this.tbcShippingCellar.TabIndex = 0;
            // 
            // tbpSalesOrder
            // 
            this.tbpSalesOrder.Controls.Add(this.crvSalesOrderUnified);
            this.tbpSalesOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpSalesOrder.Name = "tbpSalesOrder";
            this.tbpSalesOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalesOrder.Size = new System.Drawing.Size(1029, 476);
            this.tbpSalesOrder.TabIndex = 0;
            this.tbpSalesOrder.Text = "Despachos por Pesos";
            this.tbpSalesOrder.UseVisualStyleBackColor = true;
            // 
            // crvSalesOrderUnified
            // 
            this.crvSalesOrderUnified.ActiveViewIndex = -1;
            this.crvSalesOrderUnified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderUnified.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderUnified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderUnified.Location = new System.Drawing.Point(3, 3);
            this.crvSalesOrderUnified.Name = "crvSalesOrderUnified";
            this.crvSalesOrderUnified.ShowCloseButton = false;
            this.crvSalesOrderUnified.ShowGroupTreeButton = false;
            this.crvSalesOrderUnified.ShowParameterPanelButton = false;
            this.crvSalesOrderUnified.ShowRefreshButton = false;
            this.crvSalesOrderUnified.Size = new System.Drawing.Size(1023, 470);
            this.crvSalesOrderUnified.TabIndex = 0;
            this.crvSalesOrderUnified.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmShippingExportToSiigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1043, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingExportToSiigo";
            this.Text = "Despachos de Bodega";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tbcShippingCellar.ResumeLayout(false);
            this.tbpSalesOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbcShippingCellar;
        private System.Windows.Forms.TabPage tbpSalesOrder;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderUnified;
    }
}