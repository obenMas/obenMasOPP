namespace BPS
{
    partial class frmProductionPlanReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionPlanReport));
            this.gprbCalendar = new System.Windows.Forms.GroupBox();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.clmMachineCalendarCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmordenation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlotnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmwith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmkghr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmtimeproduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clminitdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmenddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbMachine = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.grpbFilterActions = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReportPlanification = new System.Windows.Forms.Button();
            this.grpbFormulationsFilters = new System.Windows.Forms.GroupBox();
            this.ttpPlanificationProduction = new System.Windows.Forms.ToolTip(this.components);
            this.gprbCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.grpbMachine.SuspendLayout();
            this.grpbFilterActions.SuspendLayout();
            this.grpbFormulationsFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gprbCalendar
            // 
            this.gprbCalendar.Controls.Add(this.dgvCalendar);
            this.gprbCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gprbCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gprbCalendar.Location = new System.Drawing.Point(0, 60);
            this.gprbCalendar.Name = "gprbCalendar";
            this.gprbCalendar.Size = new System.Drawing.Size(1163, 454);
            this.gprbCalendar.TabIndex = 1;
            this.gprbCalendar.TabStop = false;
            this.gprbCalendar.Text = "Programación";
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.AllowDrop = true;
            this.dgvCalendar.AllowUserToAddRows = false;
            this.dgvCalendar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMachineCalendarCodsec,
            this.clmordenation,
            this.clmlotnumber,
            this.clmfilm,
            this.clmweigth,
            this.clmwith,
            this.clmkghr,
            this.clmtimeproduction,
            this.clminitdate,
            this.clmenddate,
            this.clmcustomer});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCalendar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendar.Location = new System.Drawing.Point(3, 16);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.RowHeadersWidth = 21;
            this.dgvCalendar.Size = new System.Drawing.Size(1157, 435);
            this.dgvCalendar.TabIndex = 1;
            this.dgvCalendar.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCalendar_CellValidating);
            // 
            // clmMachineCalendarCodsec
            // 
            this.clmMachineCalendarCodsec.HeaderText = "codsec";
            this.clmMachineCalendarCodsec.Name = "clmMachineCalendarCodsec";
            this.clmMachineCalendarCodsec.Visible = false;
            // 
            // clmordenation
            // 
            this.clmordenation.HeaderText = "Pos";
            this.clmordenation.Name = "clmordenation";
            this.clmordenation.Width = 30;
            // 
            // clmlotnumber
            // 
            this.clmlotnumber.HeaderText = "Lote";
            this.clmlotnumber.Name = "clmlotnumber";
            this.clmlotnumber.Width = 90;
            // 
            // clmfilm
            // 
            this.clmfilm.HeaderText = "Película";
            this.clmfilm.Name = "clmfilm";
            // 
            // clmweigth
            // 
            this.clmweigth.HeaderText = "Peso";
            this.clmweigth.Name = "clmweigth";
            this.clmweigth.Width = 90;
            // 
            // clmwith
            // 
            this.clmwith.HeaderText = "Ancho";
            this.clmwith.Name = "clmwith";
            this.clmwith.Width = 70;
            // 
            // clmkghr
            // 
            this.clmkghr.HeaderText = "Kg/Hr";
            this.clmkghr.Name = "clmkghr";
            this.clmkghr.Width = 70;
            // 
            // clmtimeproduction
            // 
            this.clmtimeproduction.HeaderText = "T. Producción";
            this.clmtimeproduction.Name = "clmtimeproduction";
            // 
            // clminitdate
            // 
            this.clminitdate.HeaderText = "F. Inicio";
            this.clminitdate.Name = "clminitdate";
            this.clminitdate.Width = 145;
            // 
            // clmenddate
            // 
            this.clmenddate.HeaderText = "F. Fin";
            this.clmenddate.Name = "clmenddate";
            this.clmenddate.Width = 145;
            // 
            // clmcustomer
            // 
            this.clmcustomer.HeaderText = "Clientes";
            this.clmcustomer.Name = "clmcustomer";
            this.clmcustomer.Width = 280;
            // 
            // grpbMachine
            // 
            this.grpbMachine.Controls.Add(this.label1);
            this.grpbMachine.Controls.Add(this.dtpFrom);
            this.grpbMachine.Controls.Add(this.cmbMachine);
            this.grpbMachine.Controls.Add(this.lblMachine);
            this.grpbMachine.Controls.Add(this.grpbFilterActions);
            this.grpbMachine.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMachine.Location = new System.Drawing.Point(0, 0);
            this.grpbMachine.Name = "grpbMachine";
            this.grpbMachine.Size = new System.Drawing.Size(1163, 60);
            this.grpbMachine.TabIndex = 0;
            this.grpbMachine.TabStop = false;
            this.grpbMachine.Text = "Máquina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(570, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(252, 21);
            this.dtpFrom.TabIndex = 3;
            // 
            // cmbMachine
            // 
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Items.AddRange(new object[] {
            "Metalizadora"});
            this.cmbMachine.Location = new System.Drawing.Point(277, 18);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(226, 23);
            this.cmbMachine.TabIndex = 1;
            this.cmbMachine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMachine_KeyDown);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(215, 20);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "Máquina";
            // 
            // grpbFilterActions
            // 
            this.grpbFilterActions.Controls.Add(this.btnFilter);
            this.grpbFilterActions.Controls.Add(this.btnClearFilters);
            this.grpbFilterActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbFilterActions.Location = new System.Drawing.Point(1092, 17);
            this.grpbFilterActions.Name = "grpbFilterActions";
            this.grpbFilterActions.Size = new System.Drawing.Size(68, 40);
            this.grpbFilterActions.TabIndex = 2;
            this.grpbFilterActions.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(6, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 1;
            this.ttpPlanificationProduction.SetToolTip(this.btnFilter, "Filtrar Planificación de Producción");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilters.Location = new System.Drawing.Point(37, 12);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilters.TabIndex = 0;
            this.ttpPlanificationProduction.SetToolTip(this.btnClearFilters, "Limpiar Filtro");
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(1110, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 28;
            this.ttpPlanificationProduction.SetToolTip(this.btnClose, "Salir Planificación de Producción");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReportPlanification
            // 
            this.btnReportPlanification.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReportPlanification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReportPlanification.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReportPlanification.Location = new System.Drawing.Point(1135, 17);
            this.btnReportPlanification.Name = "btnReportPlanification";
            this.btnReportPlanification.Size = new System.Drawing.Size(25, 23);
            this.btnReportPlanification.TabIndex = 1;
            this.ttpPlanificationProduction.SetToolTip(this.btnReportPlanification, "Reporte");
            this.btnReportPlanification.UseVisualStyleBackColor = true;
            this.btnReportPlanification.Click += new System.EventHandler(this.btnReportPlanification_Click);
            // 
            // grpbFormulationsFilters
            // 
            this.grpbFormulationsFilters.Controls.Add(this.btnClose);
            this.grpbFormulationsFilters.Controls.Add(this.btnReportPlanification);
            this.grpbFormulationsFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFormulationsFilters.Location = new System.Drawing.Point(0, 514);
            this.grpbFormulationsFilters.Name = "grpbFormulationsFilters";
            this.grpbFormulationsFilters.Size = new System.Drawing.Size(1163, 43);
            this.grpbFormulationsFilters.TabIndex = 11;
            this.grpbFormulationsFilters.TabStop = false;
            // 
            // frmProductionPlanReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1163, 557);
            this.Controls.Add(this.gprbCalendar);
            this.Controls.Add(this.grpbMachine);
            this.Controls.Add(this.grpbFormulationsFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionPlanReport";
            this.Text = "Reporte de planificación de Producción";
            this.Load += new System.EventHandler(this.frmProductionPlanReport_Load);
            this.gprbCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.grpbMachine.ResumeLayout(false);
            this.grpbMachine.PerformLayout();
            this.grpbFilterActions.ResumeLayout(false);
            this.grpbFormulationsFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gprbCalendar;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.GroupBox grpbMachine;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Button btnReportPlanification;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFormulationsFilters;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.GroupBox grpbFilterActions;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.ToolTip ttpPlanificationProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmordenation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlotnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmwith;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmkghr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmtimeproduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clminitdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmenddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomer;
    }
}