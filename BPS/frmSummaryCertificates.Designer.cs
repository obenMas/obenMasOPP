namespace BPS
{
    partial class frmSummaryCertificates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSummaryCertificates));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.crvSalesOrderUnified = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.txtLotNumber);
            this.grpbFilter.Controls.Add(this.lblDateLabel);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(1098, 47);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Location = new System.Drawing.Point(500, 14);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(136, 21);
            this.txtLotNumber.TabIndex = 1;
            this.txtLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDown);
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(463, 17);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(31, 15);
            this.lblDateLabel.TabIndex = 0;
            this.lblDateLabel.Text = "Lote";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.crvSalesOrderUnified);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 510);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // crvSalesOrderUnified
            // 
            this.crvSalesOrderUnified.ActiveViewIndex = -1;
            this.crvSalesOrderUnified.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSalesOrderUnified.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSalesOrderUnified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSalesOrderUnified.Location = new System.Drawing.Point(3, 17);
            this.crvSalesOrderUnified.Name = "crvSalesOrderUnified";
            this.crvSalesOrderUnified.ShowCloseButton = false;
            this.crvSalesOrderUnified.ShowGroupTreeButton = false;
            this.crvSalesOrderUnified.ShowParameterPanelButton = false;
            this.crvSalesOrderUnified.ShowRefreshButton = false;
            this.crvSalesOrderUnified.Size = new System.Drawing.Size(1092, 490);
            this.crvSalesOrderUnified.TabIndex = 1;
            this.crvSalesOrderUnified.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmSummaryCertificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1098, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSummaryCertificates";
            this.Text = "Registro de Propiedades para Certificados de Calidad";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLotNumber;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSalesOrderUnified;
    }
}