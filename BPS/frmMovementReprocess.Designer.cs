namespace BPS
{
    partial class frmMovementReprocess
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovementReprocess));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.cmbMovementType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMovementLabel = new System.Windows.Forms.Label();
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.ttpMovementReport = new System.Windows.Forms.ToolTip(this.components);
            this.crvReProcess = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbFilter.SuspendLayout();
            this.grpbPallets.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.btnReport);
            this.grpbFilter.Controls.Add(this.lblDateLabel);
            this.grpbFilter.Controls.Add(this.cmbMovementType);
            this.grpbFilter.Controls.Add(this.dtpDate);
            this.grpbFilter.Controls.Add(this.lblMovementLabel);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(965, 40);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(825, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 6;
            this.ttpMovementReport.SetToolTip(this.btnReport, "Ver reporte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(516, 17);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDateLabel.TabIndex = 3;
            this.lblDateLabel.Text = "Fecha";
            // 
            // cmbMovementType
            // 
            this.cmbMovementType.FormattingEnabled = true;
            this.cmbMovementType.Items.AddRange(new object[] {
            "Ingreso de Planta",
            "Salida a Planta",
            "Devolución Líneas"});
            this.cmbMovementType.Location = new System.Drawing.Point(269, 12);
            this.cmbMovementType.Name = "cmbMovementType";
            this.cmbMovementType.Size = new System.Drawing.Size(223, 23);
            this.cmbMovementType.TabIndex = 2;
            this.ttpMovementReport.SetToolTip(this.cmbMovementType, "Tipo de movimiento");
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(563, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 21);
            this.dtpDate.TabIndex = 1;
            this.ttpMovementReport.SetToolTip(this.dtpDate, "Fecha del movimiento");
            // 
            // lblMovementLabel
            // 
            this.lblMovementLabel.AutoSize = true;
            this.lblMovementLabel.Location = new System.Drawing.Point(142, 15);
            this.lblMovementLabel.Name = "lblMovementLabel";
            this.lblMovementLabel.Size = new System.Drawing.Size(115, 15);
            this.lblMovementLabel.TabIndex = 0;
            this.lblMovementLabel.Text = "Tipo de Movimiento";
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.crvReProcess);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPallets.Location = new System.Drawing.Point(0, 40);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(965, 493);
            this.grpbPallets.TabIndex = 1;
            this.grpbPallets.TabStop = false;
            this.grpbPallets.Text = "Pallets";
            // 
            // crvReProcess
            // 
            this.crvReProcess.ActiveViewIndex = -1;
            this.crvReProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReProcess.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReProcess.Location = new System.Drawing.Point(3, 16);
            this.crvReProcess.Name = "crvReProcess";
            this.crvReProcess.ShowParameterPanelButton = false;
            this.crvReProcess.ShowRefreshButton = false;
            this.crvReProcess.Size = new System.Drawing.Size(959, 474);
            this.crvReProcess.TabIndex = 0;
            this.crvReProcess.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmMovementReprocess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(965, 533);
            this.Controls.Add(this.grpbPallets);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovementReprocess";
            this.Text = "Reporte de Movimientos Bodega";
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.grpbPallets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.ComboBox cmbMovementType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMovementLabel;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.GroupBox grpbPallets;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolTip ttpMovementReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReProcess;
    }
}