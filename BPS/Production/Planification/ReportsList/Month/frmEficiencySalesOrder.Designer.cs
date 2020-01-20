namespace BPS
{
    partial class frmEficiencySalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEficiencySalesOrder));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.cmborder = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.crvEffience = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.btnReport);
            this.grpbFilter.Controls.Add(this.cmborder);
            this.grpbFilter.Controls.Add(this.lblOrder);
            this.grpbFilter.Controls.Add(this.dtpEndDate);
            this.grpbFilter.Controls.Add(this.lblEndDate);
            this.grpbFilter.Controls.Add(this.dtpInitDate);
            this.grpbFilter.Controls.Add(this.lblInitDate);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(924, 42);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(893, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 31;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // cmborder
            // 
            this.cmborder.FormattingEnabled = true;
            this.cmborder.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.cmborder.Location = new System.Drawing.Point(709, 14);
            this.cmborder.Name = "cmborder";
            this.cmborder.Size = new System.Drawing.Size(144, 23);
            this.cmborder.TabIndex = 5;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(662, 17);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(41, 15);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Orden";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(424, 15);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(230, 21);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(357, 18);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(61, 15);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Fecha Fin";
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(114, 15);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(230, 21);
            this.dtpInitDate.TabIndex = 1;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(35, 18);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(73, 15);
            this.lblInitDate.TabIndex = 0;
            this.lblInitDate.Text = "Fecha Inicio";
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.crvEffience);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Location = new System.Drawing.Point(0, 42);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(924, 511);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            // 
            // crvEffience
            // 
            this.crvEffience.ActiveViewIndex = -1;
            this.crvEffience.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEffience.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEffience.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEffience.Location = new System.Drawing.Point(3, 17);
            this.crvEffience.Name = "crvEffience";
            this.crvEffience.ShowGroupTreeButton = false;
            this.crvEffience.ShowParameterPanelButton = false;
            this.crvEffience.ShowRefreshButton = false;
            this.crvEffience.Size = new System.Drawing.Size(918, 491);
            this.crvEffience.TabIndex = 0;
            this.crvEffience.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmEficiencySalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEficiencySalesOrder";
            this.Text = "Eficiencia de Pedidos";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.ComboBox cmborder;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.GroupBox grpbDetail;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEffience;
        private System.Windows.Forms.Button btnReport;
    }
}