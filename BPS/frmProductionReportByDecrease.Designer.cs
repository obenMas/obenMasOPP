namespace BPS
{
    partial class frmProductionReportByDecrease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByDecrease));
            this.grpInfoDate = new System.Windows.Forms.GroupBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.groDecrease = new System.Windows.Forms.GroupBox();
            this.dgvDecrease = new System.Windows.Forms.DataGridView();
            this.lblKgs = new System.Windows.Forms.Label();
            this.lblTotalWaste = new System.Windows.Forms.Label();
            this.lblWasteTotal = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ttpProductionByDecrease = new System.Windows.Forms.ToolTip(this.components);
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_NameDecrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_Decrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInfoDate.SuspendLayout();
            this.groDecrease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).BeginInit();
            this.grpbEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoDate
            // 
            this.grpInfoDate.Controls.Add(this.lblMachineName);
            this.grpInfoDate.Controls.Add(this.btnFilter);
            this.grpInfoDate.Controls.Add(this.dtpInitDate);
            this.grpInfoDate.Controls.Add(this.lblInitDate);
            this.grpInfoDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfoDate.Location = new System.Drawing.Point(0, 0);
            this.grpInfoDate.Name = "grpInfoDate";
            this.grpInfoDate.Size = new System.Drawing.Size(610, 44);
            this.grpInfoDate.TabIndex = 1;
            this.grpInfoDate.TabStop = false;
            // 
            // lblMachineName
            // 
            this.lblMachineName.BackColor = System.Drawing.SystemColors.Window;
            this.lblMachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(263, 15);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(185, 21);
            this.lblMachineName.TabIndex = 5;
            this.lblMachineName.Tag = "";
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(454, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 4;
            this.ttpProductionByDecrease.SetToolTip(this.btnFilter, "Filtrar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "MMMM";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(171, 15);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(86, 21);
            this.dtpInitDate.TabIndex = 1;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(131, 18);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(34, 15);
            this.lblInitDate.TabIndex = 0;
            this.lblInitDate.Text = "Mes:";
            // 
            // groDecrease
            // 
            this.groDecrease.Controls.Add(this.dgvDecrease);
            this.groDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groDecrease.Location = new System.Drawing.Point(0, 44);
            this.groDecrease.Name = "groDecrease";
            this.groDecrease.Size = new System.Drawing.Size(610, 399);
            this.groDecrease.TabIndex = 2;
            this.groDecrease.TabStop = false;
            this.groDecrease.Text = "Desperdicios";
            // 
            // dgvDecrease
            // 
            this.dgvDecrease.AllowUserToAddRows = false;
            this.dgvDecrease.AllowUserToDeleteRows = false;
            this.dgvDecrease.AllowUserToOrderColumns = true;
            this.dgvDecrease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecrease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDate,
            this.clm_NameDecrease,
            this.clm_Decrease});
            this.dgvDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDecrease.Location = new System.Drawing.Point(3, 17);
            this.dgvDecrease.Name = "dgvDecrease";
            this.dgvDecrease.ReadOnly = true;
            this.dgvDecrease.RowHeadersWidth = 21;
            this.dgvDecrease.Size = new System.Drawing.Size(604, 379);
            this.dgvDecrease.TabIndex = 0;
            // 
            // lblKgs
            // 
            this.lblKgs.AutoSize = true;
            this.lblKgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgs.Location = new System.Drawing.Point(399, 17);
            this.lblKgs.Name = "lblKgs";
            this.lblKgs.Size = new System.Drawing.Size(31, 15);
            this.lblKgs.TabIndex = 14;
            this.lblKgs.Text = "Kgs.";
            // 
            // lblTotalWaste
            // 
            this.lblTotalWaste.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalWaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWaste.Location = new System.Drawing.Point(295, 14);
            this.lblTotalWaste.Name = "lblTotalWaste";
            this.lblTotalWaste.Size = new System.Drawing.Size(103, 21);
            this.lblTotalWaste.TabIndex = 7;
            this.lblTotalWaste.Tag = "";
            this.lblTotalWaste.Text = "0";
            this.lblTotalWaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteTotal
            // 
            this.lblWasteTotal.AutoSize = true;
            this.lblWasteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWasteTotal.Location = new System.Drawing.Point(180, 17);
            this.lblWasteTotal.Name = "lblWasteTotal";
            this.lblWasteTotal.Size = new System.Drawing.Size(109, 15);
            this.lblWasteTotal.TabIndex = 6;
            this.lblWasteTotal.Text = "Total Desperdicios";
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(557, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 23);
            this.btnExit.TabIndex = 1;
            this.ttpProductionByDecrease.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReport.Location = new System.Drawing.Point(582, 17);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 23);
            this.btnReport.TabIndex = 0;
            this.ttpProductionByDecrease.SetToolTip(this.btnReport, "Reporte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.btnExit);
            this.grpbEmpty.Controls.Add(this.lblKgs);
            this.grpbEmpty.Controls.Add(this.btnReport);
            this.grpbEmpty.Controls.Add(this.lblTotalWaste);
            this.grpbEmpty.Controls.Add(this.progressBar1);
            this.grpbEmpty.Controls.Add(this.lblWasteTotal);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(0, 443);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(610, 43);
            this.grpbEmpty.TabIndex = 5;
            this.grpbEmpty.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(644, 16);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(195, 16);
            this.progressBar1.TabIndex = 16;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 110;
            // 
            // clm_NameDecrease
            // 
            this.clm_NameDecrease.HeaderText = "Causas";
            this.clm_NameDecrease.Name = "clm_NameDecrease";
            this.clm_NameDecrease.ReadOnly = true;
            this.clm_NameDecrease.Width = 280;
            // 
            // clm_Decrease
            // 
            this.clm_Decrease.HeaderText = "Deperdicio Kg.";
            this.clm_Decrease.Name = "clm_Decrease";
            this.clm_Decrease.ReadOnly = true;
            this.clm_Decrease.Width = 130;
            // 
            // frmProductionReportByDecrease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(610, 486);
            this.Controls.Add(this.groDecrease);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpInfoDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByDecrease";
            this.Text = "Reporte de Producción Por Desperdicios";
            this.grpInfoDate.ResumeLayout(false);
            this.grpInfoDate.PerformLayout();
            this.groDecrease.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).EndInit();
            this.grpbEmpty.ResumeLayout(false);
            this.grpbEmpty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.GroupBox groDecrease;
        private System.Windows.Forms.DataGridView dgvDecrease;
        private System.Windows.Forms.Label lblKgs;
        private System.Windows.Forms.Label lblTotalWaste;
        private System.Windows.Forms.Label lblWasteTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip ttpProductionByDecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NameDecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_Decrease;


    }
}