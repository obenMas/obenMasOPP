namespace BPS
{
    partial class frmMetalizedOrderReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetalizedOrderReport));
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.crvEffience = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblOrder = new System.Windows.Forms.Label();
            this.cmborder = new System.Windows.Forms.ComboBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.grpbDetail.SuspendLayout();
            this.grpbFilter.SuspendLayout();
            this.SuspendLayout();
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
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(342, 17);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(56, 15);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Maquina";
            // 
            // cmborder
            // 
            this.cmborder.FormattingEnabled = true;
            this.cmborder.Items.AddRange(new object[] {
            "Metalizadora"});
            this.cmborder.Location = new System.Drawing.Point(404, 14);
            this.cmborder.Name = "cmborder";
            this.cmborder.Size = new System.Drawing.Size(178, 23);
            this.cmborder.TabIndex = 5;
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
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.btnReport);
            this.grpbFilter.Controls.Add(this.cmborder);
            this.grpbFilter.Controls.Add(this.lblOrder);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(924, 42);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // frmMetalizedOrderReport
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
            this.Name = "frmMetalizedOrderReport";
            this.Text = "Ordenes Metalizado";
            this.grpbDetail.ResumeLayout(false);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDetail;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEffience;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cmborder;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpbFilter;
    }
}