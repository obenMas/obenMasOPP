namespace BPS
{
    partial class frmProductionReportByDeadTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByDeadTime));
            this.grpInfoDate = new System.Windows.Forms.GroupBox();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblKgs = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblTotalTimeDead = new System.Windows.Forms.Label();
            this.lblDeadTimeTotal = new System.Windows.Forms.Label();
            this.groDeadTime = new System.Windows.Forms.GroupBox();
            this.dgvDeadTime = new System.Windows.Forms.DataGridView();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.ttpProductionReportDeadTime = new System.Windows.Forms.ToolTip(this.components);
            this.clm_NameDeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_DeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInfoDate.SuspendLayout();
            this.grpbEmpty.SuspendLayout();
            this.groDeadTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).BeginInit();
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
            this.grpInfoDate.Size = new System.Drawing.Size(828, 44);
            this.grpInfoDate.TabIndex = 2;
            this.grpInfoDate.TabStop = false;
            // 
            // lblMachineName
            // 
            this.lblMachineName.BackColor = System.Drawing.SystemColors.Window;
            this.lblMachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(340, 15);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(250, 21);
            this.lblMachineName.TabIndex = 5;
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(596, 13);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 4;
            this.ttpProductionReportDeadTime.SetToolTip(this.btnFilter, "Filtrar Tiempos Muertos");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "MMMM";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(248, 15);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(86, 21);
            this.dtpInitDate.TabIndex = 1;
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(208, 18);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(34, 15);
            this.lblInitDate.TabIndex = 0;
            this.lblInitDate.Text = "Mes:";
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.label7);
            this.grpbEmpty.Controls.Add(this.label8);
            this.grpbEmpty.Controls.Add(this.label9);
            this.grpbEmpty.Controls.Add(this.label4);
            this.grpbEmpty.Controls.Add(this.label5);
            this.grpbEmpty.Controls.Add(this.label6);
            this.grpbEmpty.Controls.Add(this.label1);
            this.grpbEmpty.Controls.Add(this.label2);
            this.grpbEmpty.Controls.Add(this.label3);
            this.grpbEmpty.Controls.Add(this.btnExit);
            this.grpbEmpty.Controls.Add(this.lblKgs);
            this.grpbEmpty.Controls.Add(this.btnReport);
            this.grpbEmpty.Controls.Add(this.lblTotalTimeDead);
            this.grpbEmpty.Controls.Add(this.lblDeadTimeTotal);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(0, 457);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(828, 48);
            this.grpbEmpty.TabIndex = 9;
            this.grpbEmpty.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(528, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Hrs.";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(377, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 23;
            this.label9.Text = "TMO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hrs.";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "TMP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hrs.";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "TMM";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(796, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.ttpProductionReportDeadTime.SetToolTip(this.btnExit, "Salir Tiempos Muertos");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblKgs
            // 
            this.lblKgs.AutoSize = true;
            this.lblKgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgs.Location = new System.Drawing.Point(711, 20);
            this.lblKgs.Name = "lblKgs";
            this.lblKgs.Size = new System.Drawing.Size(29, 15);
            this.lblKgs.TabIndex = 14;
            this.lblKgs.Text = "Hrs.";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.helpProvider1.SetHelpString(this.btnReport, "Visualizar el Reporte");
            this.btnReport.Location = new System.Drawing.Point(768, 14);
            this.btnReport.Name = "btnReport";
            this.helpProvider1.SetShowHelp(this.btnReport, true);
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.ttpProductionReportDeadTime.SetToolTip(this.btnReport, "Reporte Tiempos Muertos");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblTotalTimeDead
            // 
            this.lblTotalTimeDead.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalTimeDead.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalTimeDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTimeDead.Location = new System.Drawing.Point(600, 18);
            this.lblTotalTimeDead.Name = "lblTotalTimeDead";
            this.lblTotalTimeDead.Size = new System.Drawing.Size(107, 21);
            this.lblTotalTimeDead.TabIndex = 7;
            this.lblTotalTimeDead.Text = "0";
            this.lblTotalTimeDead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDeadTimeTotal
            // 
            this.lblDeadTimeTotal.AutoSize = true;
            this.lblDeadTimeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadTimeTotal.Location = new System.Drawing.Point(561, 20);
            this.lblDeadTimeTotal.Name = "lblDeadTimeTotal";
            this.lblDeadTimeTotal.Size = new System.Drawing.Size(34, 15);
            this.lblDeadTimeTotal.TabIndex = 6;
            this.lblDeadTimeTotal.Text = "Total";
            // 
            // groDeadTime
            // 
            this.groDeadTime.Controls.Add(this.dgvDeadTime);
            this.groDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groDeadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groDeadTime.Location = new System.Drawing.Point(0, 44);
            this.groDeadTime.Name = "groDeadTime";
            this.groDeadTime.Size = new System.Drawing.Size(828, 413);
            this.groDeadTime.TabIndex = 7;
            this.groDeadTime.TabStop = false;
            this.groDeadTime.Text = "Tiempos Muertos";
            // 
            // dgvDeadTime
            // 
            this.dgvDeadTime.AllowUserToAddRows = false;
            this.dgvDeadTime.AllowUserToDeleteRows = false;
            this.dgvDeadTime.AllowUserToOrderColumns = true;
            this.dgvDeadTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeadTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_NameDeadTime,
            this.clmDe,
            this.clm_DeadTime});
            this.dgvDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeadTime.Location = new System.Drawing.Point(3, 16);
            this.dgvDeadTime.Name = "dgvDeadTime";
            this.dgvDeadTime.ReadOnly = true;
            this.dgvDeadTime.RowHeadersWidth = 21;
            this.dgvDeadTime.Size = new System.Drawing.Size(822, 394);
            this.dgvDeadTime.TabIndex = 0;
            // 
            // clm_NameDeadTime
            // 
            this.clm_NameDeadTime.HeaderText = "Tipo";
            this.clm_NameDeadTime.Name = "clm_NameDeadTime";
            this.clm_NameDeadTime.ReadOnly = true;
            this.clm_NameDeadTime.Width = 70;
            // 
            // clmDe
            // 
            this.clmDe.HeaderText = "Causas";
            this.clmDe.Name = "clmDe";
            this.clmDe.ReadOnly = true;
            this.clmDe.Width = 500;
            // 
            // clm_DeadTime
            // 
            this.clm_DeadTime.HeaderText = "Tiempo / Horas";
            this.clm_DeadTime.Name = "clm_DeadTime";
            this.clm_DeadTime.ReadOnly = true;
            this.clm_DeadTime.Width = 150;
            // 
            // frmProductionReportByDeadTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(828, 505);
            this.Controls.Add(this.groDeadTime);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpInfoDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByDeadTime";
            this.Text = "Reporte Por Maquinas Tiempos Muertos";
            this.Load += new System.EventHandler(this.frmProductionReportByDeadTime_Load);
            this.grpInfoDate.ResumeLayout(false);
            this.grpInfoDate.PerformLayout();
            this.grpbEmpty.ResumeLayout(false);
            this.grpbEmpty.PerformLayout();
            this.groDeadTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoDate;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblKgs;
        private System.Windows.Forms.Label lblTotalTimeDead;
        private System.Windows.Forms.Label lblDeadTimeTotal;
        private System.Windows.Forms.GroupBox groDeadTime;
        private System.Windows.Forms.DataGridView dgvDeadTime;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip ttpProductionReportDeadTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_NameDeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_DeadTime;
    }
}