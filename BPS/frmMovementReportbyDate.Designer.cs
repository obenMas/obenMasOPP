namespace BPS
{
    partial class frmMovementReportbyDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovementReportbyDate));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.cmbMovementType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblMovementLabel = new System.Windows.Forms.Label();
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.dgvPallets = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodepallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmordernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdateproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpMovementReport = new System.Windows.Forms.ToolTip(this.components);
            this.grpbFilter.SuspendLayout();
            this.grpbPallets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).BeginInit();
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
            this.grpbFilter.Size = new System.Drawing.Size(965, 59);
            this.grpbFilter.TabIndex = 0;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(899, 18);
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
            this.lblDateLabel.Location = new System.Drawing.Point(510, 25);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(47, 15);
            this.lblDateLabel.TabIndex = 3;
            this.lblDateLabel.Text = "Fecha :";
            // 
            // cmbMovementType
            // 
            this.cmbMovementType.FormattingEnabled = true;
            this.cmbMovementType.Location = new System.Drawing.Point(269, 20);
            this.cmbMovementType.Name = "cmbMovementType";
            this.cmbMovementType.Size = new System.Drawing.Size(223, 23);
            this.cmbMovementType.TabIndex = 2;
            this.ttpMovementReport.SetToolTip(this.cmbMovementType, "Tipo de movimiento");
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(563, 22);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(243, 21);
            this.dtpDate.TabIndex = 1;
            this.ttpMovementReport.SetToolTip(this.dtpDate, "Fecha del movimiento");
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblMovementLabel
            // 
            this.lblMovementLabel.AutoSize = true;
            this.lblMovementLabel.Location = new System.Drawing.Point(142, 23);
            this.lblMovementLabel.Name = "lblMovementLabel";
            this.lblMovementLabel.Size = new System.Drawing.Size(121, 15);
            this.lblMovementLabel.TabIndex = 0;
            this.lblMovementLabel.Text = "Tipo de Movimiento :";
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.dgvPallets);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPallets.Location = new System.Drawing.Point(0, 59);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(965, 439);
            this.grpbPallets.TabIndex = 1;
            this.grpbPallets.TabStop = false;
            this.grpbPallets.Text = "Pallets";
            // 
            // dgvPallets
            // 
            this.dgvPallets.AllowUserToAddRows = false;
            this.dgvPallets.AllowUserToDeleteRows = false;
            this.dgvPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmnumber,
            this.clmcodepallet,
            this.clmproduct,
            this.clmNetWeight,
            this.clmordernumber,
            this.clmcustomer,
            this.clmdateproduction});
            this.dgvPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvPallets.Name = "dgvPallets";
            this.dgvPallets.ReadOnly = true;
            this.dgvPallets.RowHeadersWidth = 21;
            this.dgvPallets.Size = new System.Drawing.Size(959, 419);
            this.dgvPallets.TabIndex = 0;
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "Codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.ReadOnly = true;
            this.clmcodsec.Visible = false;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            this.clmnumber.Width = 50;
            // 
            // clmcodepallet
            // 
            this.clmcodepallet.HeaderText = "Pallet";
            this.clmcodepallet.Name = "clmcodepallet";
            this.clmcodepallet.ReadOnly = true;
            this.clmcodepallet.Width = 150;
            // 
            // clmproduct
            // 
            this.clmproduct.HeaderText = "Producto";
            this.clmproduct.Name = "clmproduct";
            this.clmproduct.ReadOnly = true;
            this.clmproduct.Width = 150;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "P. Neto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 80;
            // 
            // clmordernumber
            // 
            this.clmordernumber.HeaderText = "Orden";
            this.clmordernumber.Name = "clmordernumber";
            this.clmordernumber.ReadOnly = true;
            this.clmordernumber.Width = 80;
            // 
            // clmcustomer
            // 
            this.clmcustomer.HeaderText = "Cliente";
            this.clmcustomer.Name = "clmcustomer";
            this.clmcustomer.ReadOnly = true;
            this.clmcustomer.Width = 200;
            // 
            // clmdateproduction
            // 
            this.clmdateproduction.HeaderText = "Fecha de Producción";
            this.clmdateproduction.Name = "clmdateproduction";
            this.clmdateproduction.ReadOnly = true;
            this.clmdateproduction.Width = 180;
            // 
            // frmMovementReportbyDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(965, 498);
            this.Controls.Add(this.grpbPallets);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovementReportbyDate";
            this.Text = "Reporte de Movimientos Bodega";
            this.Load += new System.EventHandler(this.frmMovementReportbyDate_Load);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.grpbPallets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.ComboBox cmbMovementType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMovementLabel;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.GroupBox grpbPallets;
        private System.Windows.Forms.DataGridView dgvPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodepallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmordernumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdateproduction;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolTip ttpMovementReport;
    }
}