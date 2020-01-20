namespace BPS
{
    partial class frmProductionReportByOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionReportByOrder));
            this.gpbOrderList = new System.Windows.Forms.GroupBox();
            this.txtKilogramsPerHour = new System.Windows.Forms.TextBox();
            this.lblKilogramsPerHour = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.gpbMainLots = new System.Windows.Forms.GroupBox();
            this.dgvMainCoil = new System.Windows.Forms.DataGridView();
            this.gpbDecrease = new System.Windows.Forms.GroupBox();
            this.dgvDecrease = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDecreaseWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeacreseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpbDeadTime = new System.Windows.Forms.GroupBox();
            this.dgvDeadTime = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeAbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDeadTimeEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.ttpPoductionReport = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clmCodsecMainCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBoppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpbOrderList.SuspendLayout();
            this.gpbMainLots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoil)).BeginInit();
            this.gpbDecrease.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).BeginInit();
            this.gpbDeadTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOrderList
            // 
            this.gpbOrderList.Controls.Add(this.txtKilogramsPerHour);
            this.gpbOrderList.Controls.Add(this.lblKilogramsPerHour);
            this.gpbOrderList.Controls.Add(this.lblMachineName);
            this.gpbOrderList.Controls.Add(this.btnFilter);
            this.gpbOrderList.Controls.Add(this.lblLine);
            this.gpbOrderList.Controls.Add(this.lblOrder);
            this.gpbOrderList.Controls.Add(this.cmbOrder);
            this.gpbOrderList.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbOrderList.Location = new System.Drawing.Point(0, 0);
            this.gpbOrderList.Name = "gpbOrderList";
            this.gpbOrderList.Size = new System.Drawing.Size(1013, 52);
            this.gpbOrderList.TabIndex = 0;
            this.gpbOrderList.TabStop = false;
            // 
            // txtKilogramsPerHour
            // 
            this.txtKilogramsPerHour.Location = new System.Drawing.Point(715, 18);
            this.txtKilogramsPerHour.MaxLength = 10;
            this.txtKilogramsPerHour.Name = "txtKilogramsPerHour";
            this.txtKilogramsPerHour.Size = new System.Drawing.Size(100, 21);
            this.txtKilogramsPerHour.TabIndex = 5;
            // 
            // lblKilogramsPerHour
            // 
            this.lblKilogramsPerHour.AutoSize = true;
            this.lblKilogramsPerHour.Location = new System.Drawing.Point(601, 21);
            this.lblKilogramsPerHour.Name = "lblKilogramsPerHour";
            this.lblKilogramsPerHour.Size = new System.Drawing.Size(108, 15);
            this.lblKilogramsPerHour.TabIndex = 4;
            this.lblKilogramsPerHour.Text = "Producción (Kg/h):";
            // 
            // lblMachineName
            // 
            this.lblMachineName.BackColor = System.Drawing.SystemColors.Window;
            this.lblMachineName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(397, 18);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(185, 21);
            this.lblMachineName.TabIndex = 3;
            this.lblMachineName.Tag = "";
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(866, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 6;
            this.ttpPoductionReport.SetToolTip(this.btnFilter, "Filtar para obetener toda la corrida del lote");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(332, 19);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(59, 15);
            this.lblLine.TabIndex = 2;
            this.lblLine.Text = "Maquina:";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(99, 19);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(44, 15);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "Orden:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(149, 16);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(166, 23);
            this.cmbOrder.TabIndex = 1;
            // 
            // gpbMainLots
            // 
            this.gpbMainLots.Controls.Add(this.dgvMainCoil);
            this.gpbMainLots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbMainLots.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbMainLots.Location = new System.Drawing.Point(0, 52);
            this.gpbMainLots.Name = "gpbMainLots";
            this.gpbMainLots.Size = new System.Drawing.Size(577, 430);
            this.gpbMainLots.TabIndex = 1;
            this.gpbMainLots.TabStop = false;
            this.gpbMainLots.Text = "Detalle";
            this.gpbMainLots.Enter += new System.EventHandler(this.gpbMainLots_Enter);
            // 
            // dgvMainCoil
            // 
            this.dgvMainCoil.AllowUserToAddRows = false;
            this.dgvMainCoil.AllowUserToDeleteRows = false;
            this.dgvMainCoil.AllowUserToOrderColumns = true;
            this.dgvMainCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecMainCoil,
            this.clmLotNumber,
            this.clmBoppCode,
            this.clmTotalWeigth,
            this.clmInitDate,
            this.clmEndDate});
            this.dgvMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMainCoil.Location = new System.Drawing.Point(3, 16);
            this.dgvMainCoil.Name = "dgvMainCoil";
            this.dgvMainCoil.ReadOnly = true;
            this.dgvMainCoil.RowHeadersWidth = 21;
            this.dgvMainCoil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoil.Size = new System.Drawing.Size(571, 411);
            this.dgvMainCoil.TabIndex = 0;
            // 
            // gpbDecrease
            // 
            this.gpbDecrease.Controls.Add(this.dgvDecrease);
            this.gpbDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDecrease.Location = new System.Drawing.Point(3, 208);
            this.gpbDecrease.Name = "gpbDecrease";
            this.gpbDecrease.Size = new System.Drawing.Size(424, 199);
            this.gpbDecrease.TabIndex = 2;
            this.gpbDecrease.TabStop = false;
            this.gpbDecrease.Text = "Desperdicios";
            // 
            // dgvDecrease
            // 
            this.dgvDecrease.AllowUserToAddRows = false;
            this.dgvDecrease.AllowUserToDeleteRows = false;
            this.dgvDecrease.AllowUserToOrderColumns = true;
            this.dgvDecrease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDecrease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmDecreaseName,
            this.clmDecreaseWeigth,
            this.clmDeacreseDate});
            this.dgvDecrease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDecrease.Location = new System.Drawing.Point(3, 16);
            this.dgvDecrease.Name = "dgvDecrease";
            this.dgvDecrease.ReadOnly = true;
            this.dgvDecrease.RowHeadersWidth = 21;
            this.dgvDecrease.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDecrease.Size = new System.Drawing.Size(418, 180);
            this.dgvDecrease.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // clmDecreaseName
            // 
            this.clmDecreaseName.HeaderText = "Desperdicio";
            this.clmDecreaseName.Name = "clmDecreaseName";
            this.clmDecreaseName.ReadOnly = true;
            this.clmDecreaseName.Width = 110;
            // 
            // clmDecreaseWeigth
            // 
            this.clmDecreaseWeigth.HeaderText = "Peso (kg)";
            this.clmDecreaseWeigth.Name = "clmDecreaseWeigth";
            this.clmDecreaseWeigth.ReadOnly = true;
            // 
            // clmDeacreseDate
            // 
            this.clmDeacreseDate.HeaderText = "Fecha";
            this.clmDeacreseDate.Name = "clmDeacreseDate";
            this.clmDeacreseDate.ReadOnly = true;
            this.clmDeacreseDate.Width = 130;
            // 
            // gpbDeadTime
            // 
            this.gpbDeadTime.Controls.Add(this.dgvDeadTime);
            this.gpbDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpbDeadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDeadTime.Location = new System.Drawing.Point(3, 3);
            this.gpbDeadTime.Name = "gpbDeadTime";
            this.gpbDeadTime.Size = new System.Drawing.Size(424, 199);
            this.gpbDeadTime.TabIndex = 3;
            this.gpbDeadTime.TabStop = false;
            this.gpbDeadTime.Text = "Tiempo Muerto";
            // 
            // dgvDeadTime
            // 
            this.dgvDeadTime.AllowUserToAddRows = false;
            this.dgvDeadTime.AllowUserToDeleteRows = false;
            this.dgvDeadTime.AllowUserToOrderColumns = true;
            this.dgvDeadTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeadTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.clmDeadTimeAbreviation,
            this.clmDeadTimeName,
            this.clmDeadTimeInitDate,
            this.clmDeadTimeEndDate});
            this.dgvDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeadTime.Location = new System.Drawing.Point(3, 16);
            this.dgvDeadTime.Name = "dgvDeadTime";
            this.dgvDeadTime.ReadOnly = true;
            this.dgvDeadTime.RowHeadersWidth = 21;
            this.dgvDeadTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeadTime.Size = new System.Drawing.Size(418, 180);
            this.dgvDeadTime.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "codsec";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // clmDeadTimeAbreviation
            // 
            this.clmDeadTimeAbreviation.HeaderText = "Abreviacion";
            this.clmDeadTimeAbreviation.Name = "clmDeadTimeAbreviation";
            this.clmDeadTimeAbreviation.ReadOnly = true;
            this.clmDeadTimeAbreviation.Visible = false;
            // 
            // clmDeadTimeName
            // 
            this.clmDeadTimeName.HeaderText = "Tipo";
            this.clmDeadTimeName.Name = "clmDeadTimeName";
            this.clmDeadTimeName.ReadOnly = true;
            this.clmDeadTimeName.Width = 150;
            // 
            // clmDeadTimeInitDate
            // 
            this.clmDeadTimeInitDate.HeaderText = "Fecha Inicio";
            this.clmDeadTimeInitDate.Name = "clmDeadTimeInitDate";
            this.clmDeadTimeInitDate.ReadOnly = true;
            this.clmDeadTimeInitDate.Width = 110;
            // 
            // clmDeadTimeEndDate
            // 
            this.clmDeadTimeEndDate.HeaderText = "Fecha Fin";
            this.clmDeadTimeEndDate.Name = "clmDeadTimeEndDate";
            this.clmDeadTimeEndDate.ReadOnly = true;
            this.clmDeadTimeEndDate.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 482);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(960, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.ttpPoductionReport.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReport.Location = new System.Drawing.Point(985, 17);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.ttpPoductionReport.SetToolTip(this.btnReport, "Reporte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(577, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 430);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // clmCodsecMainCoil
            // 
            this.clmCodsecMainCoil.HeaderText = "codsec";
            this.clmCodsecMainCoil.Name = "clmCodsecMainCoil";
            this.clmCodsecMainCoil.ReadOnly = true;
            this.clmCodsecMainCoil.Visible = false;
            // 
            // clmLotNumber
            // 
            this.clmLotNumber.HeaderText = "N° Orden";
            this.clmLotNumber.Name = "clmLotNumber";
            this.clmLotNumber.ReadOnly = true;
            this.clmLotNumber.Width = 90;
            // 
            // clmBoppCode
            // 
            this.clmBoppCode.HeaderText = "Pelicula";
            this.clmBoppCode.Name = "clmBoppCode";
            this.clmBoppCode.ReadOnly = true;
            // 
            // clmTotalWeigth
            // 
            this.clmTotalWeigth.HeaderText = "Peso (kg)";
            this.clmTotalWeigth.Name = "clmTotalWeigth";
            this.clmTotalWeigth.ReadOnly = true;
            this.clmTotalWeigth.Width = 90;
            // 
            // clmInitDate
            // 
            this.clmInitDate.HeaderText = "Fecha Inicio";
            this.clmInitDate.Name = "clmInitDate";
            this.clmInitDate.ReadOnly = true;
            this.clmInitDate.Width = 120;
            // 
            // clmEndDate
            // 
            this.clmEndDate.HeaderText = "Fecha Fin";
            this.clmEndDate.Name = "clmEndDate";
            this.clmEndDate.ReadOnly = true;
            this.clmEndDate.Width = 120;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gpbDeadTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpbDecrease, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 410);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmProductionReportByOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1013, 527);
            this.Controls.Add(this.gpbMainLots);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbOrderList);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionReportByOrder";
            this.Text = "Reporte Por Ordenes de Producción";
            this.gpbOrderList.ResumeLayout(false);
            this.gpbOrderList.PerformLayout();
            this.gpbMainLots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoil)).EndInit();
            this.gpbDecrease.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDecrease)).EndInit();
            this.gpbDeadTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOrderList;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gpbMainLots;
        private System.Windows.Forms.DataGridView dgvMainCoil;
        private System.Windows.Forms.GroupBox gpbDecrease;
        private System.Windows.Forms.DataGridView dgvDecrease;
        private System.Windows.Forms.GroupBox gpbDeadTime;
        private System.Windows.Forms.DataGridView dgvDeadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeacreseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeAbreviation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDeadTimeEndDate;
        private System.Windows.Forms.TextBox txtKilogramsPerHour;
        private System.Windows.Forms.Label lblKilogramsPerHour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolTip ttpPoductionReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecMainCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBoppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEndDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}