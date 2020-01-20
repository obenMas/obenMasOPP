namespace BPS
{
    partial class frmShippingCellar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingCellar));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbcShippingCellar = new System.Windows.Forms.TabControl();
            this.tbpSalesOrder = new System.Windows.Forms.TabPage();
            this.crvSalesOrderUnified = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpSalesOrderDetails = new System.Windows.Forms.TabPage();
            this.crvSalesOrderFull = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbcShippingCellar.SuspendLayout();
            this.tbpSalesOrder.SuspendLayout();
            this.tbpSalesOrderDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.dtpDate);
            this.grpbFilter.Controls.Add(this.lblDateLabel);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(1027, 47);
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 466);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tbcShippingCellar
            // 
            this.tbcShippingCellar.Controls.Add(this.tbpSalesOrder);
            this.tbcShippingCellar.Controls.Add(this.tbpSalesOrderDetails);
            this.tbcShippingCellar.Location = new System.Drawing.Point(6, 20);
            this.tbcShippingCellar.Name = "tbcShippingCellar";
            this.tbcShippingCellar.SelectedIndex = 0;
            this.tbcShippingCellar.Size = new System.Drawing.Size(1021, 446);
            this.tbcShippingCellar.TabIndex = 0;
            // 
            // tbpSalesOrder
            // 
            this.tbpSalesOrder.Controls.Add(this.crvSalesOrderUnified);
            this.tbpSalesOrder.Location = new System.Drawing.Point(4, 24);
            this.tbpSalesOrder.Name = "tbpSalesOrder";
            this.tbpSalesOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalesOrder.Size = new System.Drawing.Size(1013, 418);
            this.tbpSalesOrder.TabIndex = 0;
            this.tbpSalesOrder.Text = "Ordenes de venta despachadas (Unificadas)";
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
            this.crvSalesOrderUnified.Size = new System.Drawing.Size(1007, 412);
            this.crvSalesOrderUnified.TabIndex = 0;
            this.crvSalesOrderUnified.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpSalesOrderDetails
            // 
            this.tbpSalesOrderDetails.Controls.Add(this.crvSalesOrderFull);
            this.tbpSalesOrderDetails.Location = new System.Drawing.Point(4, 24);
            this.tbpSalesOrderDetails.Name = "tbpSalesOrderDetails";
            this.tbpSalesOrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSalesOrderDetails.Size = new System.Drawing.Size(1013, 418);
            this.tbpSalesOrderDetails.TabIndex = 1;
            this.tbpSalesOrderDetails.Text = "Ordenes de venta despachadas (Desglosada)";
            this.tbpSalesOrderDetails.UseVisualStyleBackColor = true;
            // 
            // crvSalesOrderFull
            // 
            this.crvSalesOrderFull.ActiveViewIndex = -1;
            this.crvSalesOrderFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderFull.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderFull.Location = new System.Drawing.Point(3, 3);
            this.crvSalesOrderFull.Name = "crvSalesOrderFull";
            this.crvSalesOrderFull.ShowCloseButton = false;
            this.crvSalesOrderFull.ShowGroupTreeButton = false;
            this.crvSalesOrderFull.ShowParameterPanelButton = false;
            this.crvSalesOrderFull.ShowRefreshButton = false;
            this.crvSalesOrderFull.Size = new System.Drawing.Size(1007, 412);
            this.crvSalesOrderFull.TabIndex = 0;
            this.crvSalesOrderFull.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmShippingCellar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingCellar";
            this.Text = "Despachos de Bodega";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tbcShippingCellar.ResumeLayout(false);
            this.tbpSalesOrder.ResumeLayout(false);
            this.tbpSalesOrderDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tbcShippingCellar;
        private System.Windows.Forms.TabPage tbpSalesOrder;
        private System.Windows.Forms.TabPage tbpSalesOrderDetails;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderUnified;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderFull;
    }
}