namespace BPS
{
    partial class frmFilmProductionPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFilmProductionPlan));
            this.grpbProductionOrder = new System.Windows.Forms.GroupBox();
            this.dgvProductionOrders = new System.Windows.Forms.DataGridView();
            this.clmProductionOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmProductionOrderCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbMachine = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.txtMainCoilWidth2 = new System.Windows.Forms.TextBox();
            this.txtMainCoilWidth1 = new System.Windows.Forms.TextBox();
            this.txtKPH = new System.Windows.Forms.TextBox();
            this.lblMaximumWidth = new System.Windows.Forms.Label();
            this.lblMinimumWidth = new System.Windows.Forms.Label();
            this.lblKPH = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.gprbCalendar = new System.Windows.Forms.GroupBox();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.clmMachineCalendarCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarPOCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarPONumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarWidths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarKilogramsPerHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarIdleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarProductionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarInitDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarEndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarCustomers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMachineCalendarPlanification = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMachineCalendarEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMachineCalendarCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbProductionOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrders)).BeginInit();
            this.grpbMachine.SuspendLayout();
            this.gprbCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbProductionOrder
            // 
            this.grpbProductionOrder.Controls.Add(this.dgvProductionOrders);
            this.grpbProductionOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbProductionOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbProductionOrder.Name = "grpbProductionOrder";
            this.grpbProductionOrder.Size = new System.Drawing.Size(1248, 197);
            this.grpbProductionOrder.TabIndex = 0;
            this.grpbProductionOrder.TabStop = false;
            this.grpbProductionOrder.Text = "Ordenes de Producción por planificar";
            this.grpbProductionOrder.Enter += new System.EventHandler(this.grpbProductionOrder_Enter);
            // 
            // dgvProductionOrders
            // 
            this.dgvProductionOrders.AllowUserToAddRows = false;
            this.dgvProductionOrders.AllowUserToDeleteRows = false;
            this.dgvProductionOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductionOrderCodsec,
            this.clmProductionOrderNumber,
            this.clmProductionOrderFilm,
            this.clmProductionOrderWeight,
            this.clmProductionOrderCustomers,
            this.clmProductionOrderEdit,
            this.clmProductionOrderCancel});
            this.dgvProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductionOrders.Location = new System.Drawing.Point(3, 17);
            this.dgvProductionOrders.Name = "dgvProductionOrders";
            this.dgvProductionOrders.ReadOnly = true;
            this.dgvProductionOrders.Size = new System.Drawing.Size(1242, 177);
            this.dgvProductionOrders.TabIndex = 0;
            this.dgvProductionOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionOrders_CellClick);
            this.dgvProductionOrders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvProductionOrders_MouseDown);
            this.dgvProductionOrders.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvProductionOrders_MouseMove);
            // 
            // clmProductionOrderCodsec
            // 
            this.clmProductionOrderCodsec.HeaderText = "codsec";
            this.clmProductionOrderCodsec.Name = "clmProductionOrderCodsec";
            this.clmProductionOrderCodsec.ReadOnly = true;
            this.clmProductionOrderCodsec.Visible = false;
            // 
            // clmProductionOrderNumber
            // 
            this.clmProductionOrderNumber.HeaderText = "Número";
            this.clmProductionOrderNumber.Name = "clmProductionOrderNumber";
            this.clmProductionOrderNumber.ReadOnly = true;
            this.clmProductionOrderNumber.Width = 80;
            // 
            // clmProductionOrderFilm
            // 
            this.clmProductionOrderFilm.HeaderText = "Película";
            this.clmProductionOrderFilm.Name = "clmProductionOrderFilm";
            this.clmProductionOrderFilm.ReadOnly = true;
            this.clmProductionOrderFilm.Width = 350;
            // 
            // clmProductionOrderWeight
            // 
            this.clmProductionOrderWeight.HeaderText = "Peso";
            this.clmProductionOrderWeight.Name = "clmProductionOrderWeight";
            this.clmProductionOrderWeight.ReadOnly = true;
            this.clmProductionOrderWeight.Width = 120;
            // 
            // clmProductionOrderCustomers
            // 
            this.clmProductionOrderCustomers.HeaderText = "Clientes";
            this.clmProductionOrderCustomers.Name = "clmProductionOrderCustomers";
            this.clmProductionOrderCustomers.ReadOnly = true;
            this.clmProductionOrderCustomers.Width = 570;
            // 
            // clmProductionOrderEdit
            // 
            this.clmProductionOrderEdit.HeaderText = "";
            this.clmProductionOrderEdit.Name = "clmProductionOrderEdit";
            this.clmProductionOrderEdit.ReadOnly = true;
            this.clmProductionOrderEdit.Width = 30;
            // 
            // clmProductionOrderCancel
            // 
            this.clmProductionOrderCancel.HeaderText = "";
            this.clmProductionOrderCancel.Name = "clmProductionOrderCancel";
            this.clmProductionOrderCancel.ReadOnly = true;
            this.clmProductionOrderCancel.Width = 30;
            // 
            // grpbMachine
            // 
            this.grpbMachine.Controls.Add(this.txtNotes);
            this.grpbMachine.Controls.Add(this.lblNotes);
            this.grpbMachine.Controls.Add(this.txtLength);
            this.grpbMachine.Controls.Add(this.lblLength);
            this.grpbMachine.Controls.Add(this.lblInitDate);
            this.grpbMachine.Controls.Add(this.dtpInitDate);
            this.grpbMachine.Controls.Add(this.txtMainCoilWidth2);
            this.grpbMachine.Controls.Add(this.txtMainCoilWidth1);
            this.grpbMachine.Controls.Add(this.txtKPH);
            this.grpbMachine.Controls.Add(this.lblMaximumWidth);
            this.grpbMachine.Controls.Add(this.lblMinimumWidth);
            this.grpbMachine.Controls.Add(this.lblKPH);
            this.grpbMachine.Controls.Add(this.cmbMachine);
            this.grpbMachine.Controls.Add(this.lblMachine);
            this.grpbMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbMachine.Location = new System.Drawing.Point(0, 197);
            this.grpbMachine.Name = "grpbMachine";
            this.grpbMachine.Size = new System.Drawing.Size(1248, 109);
            this.grpbMachine.TabIndex = 1;
            this.grpbMachine.TabStop = false;
            this.grpbMachine.Text = "Máquina";
            this.grpbMachine.Enter += new System.EventHandler(this.grpbMachine_Enter);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(400, 82);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(466, 21);
            this.txtNotes.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(304, 85);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(88, 15);
            this.lblNotes.TabIndex = 14;
            this.lblNotes.Text = "Observaciones";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(766, 51);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 21);
            this.txtLength.TabIndex = 13;
            this.txtLength.Text = "0";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(714, 54);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(49, 15);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "Metraje";
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(963, 41);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(126, 15);
            this.lblInitDate.TabIndex = 11;
            this.lblInitDate.Text = "Fecha y hora de inicio";
            this.lblInitDate.Visible = false;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(920, 59);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(213, 21);
            this.dtpInitDate.TabIndex = 10;
            this.dtpInitDate.Visible = false;
            // 
            // txtMainCoilWidth2
            // 
            this.txtMainCoilWidth2.Location = new System.Drawing.Point(617, 51);
            this.txtMainCoilWidth2.Name = "txtMainCoilWidth2";
            this.txtMainCoilWidth2.Size = new System.Drawing.Size(87, 21);
            this.txtMainCoilWidth2.TabIndex = 3;
            this.txtMainCoilWidth2.Text = "0";
            this.txtMainCoilWidth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMainCoilWidth1
            // 
            this.txtMainCoilWidth1.Location = new System.Drawing.Point(400, 51);
            this.txtMainCoilWidth1.Name = "txtMainCoilWidth1";
            this.txtMainCoilWidth1.Size = new System.Drawing.Size(87, 21);
            this.txtMainCoilWidth1.TabIndex = 3;
            this.txtMainCoilWidth1.Text = "0";
            this.txtMainCoilWidth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKPH
            // 
            this.txtKPH.Location = new System.Drawing.Point(766, 19);
            this.txtKPH.Name = "txtKPH";
            this.txtKPH.Size = new System.Drawing.Size(100, 21);
            this.txtKPH.TabIndex = 3;
            this.txtKPH.Text = "0";
            this.txtKPH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMaximumWidth
            // 
            this.lblMaximumWidth.AutoSize = true;
            this.lblMaximumWidth.Location = new System.Drawing.Point(519, 54);
            this.lblMaximumWidth.Name = "lblMaximumWidth";
            this.lblMaximumWidth.Size = new System.Drawing.Size(92, 15);
            this.lblMaximumWidth.TabIndex = 2;
            this.lblMaximumWidth.Text = "Ancho bobina 2";
            // 
            // lblMinimumWidth
            // 
            this.lblMinimumWidth.AutoSize = true;
            this.lblMinimumWidth.Location = new System.Drawing.Point(300, 54);
            this.lblMinimumWidth.Name = "lblMinimumWidth";
            this.lblMinimumWidth.Size = new System.Drawing.Size(92, 15);
            this.lblMinimumWidth.TabIndex = 2;
            this.lblMinimumWidth.Text = "Ancho bobina 1";
            // 
            // lblKPH
            // 
            this.lblKPH.AutoSize = true;
            this.lblKPH.Location = new System.Drawing.Point(714, 22);
            this.lblKPH.Name = "lblKPH";
            this.lblKPH.Size = new System.Drawing.Size(44, 15);
            this.lblKPH.TabIndex = 2;
            this.lblKPH.Text = "Kg./Hr.";
            // 
            // cmbMachine
            // 
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(400, 18);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(308, 23);
            this.cmbMachine.TabIndex = 1;
            this.cmbMachine.SelectedIndexChanged += new System.EventHandler(this.cmbMachine_SelectedIndexChanged);
            this.cmbMachine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMachine_KeyDown);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Location = new System.Drawing.Point(336, 22);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(56, 15);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Text = "Máquina";
            // 
            // gprbCalendar
            // 
            this.gprbCalendar.Controls.Add(this.dgvCalendar);
            this.gprbCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gprbCalendar.Location = new System.Drawing.Point(0, 306);
            this.gprbCalendar.Name = "gprbCalendar";
            this.gprbCalendar.Size = new System.Drawing.Size(1248, 273);
            this.gprbCalendar.TabIndex = 1;
            this.gprbCalendar.TabStop = false;
            this.gprbCalendar.Text = "Calendario";
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.AllowDrop = true;
            this.dgvCalendar.AllowUserToAddRows = false;
            this.dgvCalendar.AllowUserToDeleteRows = false;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMachineCalendarCodsec,
            this.clmMachineCalendarPOCodsec,
            this.clmMachineCalendarPONumber,
            this.clmMachineCalendarFilm,
            this.clmMachineCalendarWeight,
            this.clmMachineCalendarWidths,
            this.clmMachineCalendarLength,
            this.clmMachineCalendarKilogramsPerHour,
            this.clmMachineCalendarIdleTime,
            this.clmMachineCalendarProductionTime,
            this.clmMachineCalendarInitDateTime,
            this.clmMachineCalendarEndDateTime,
            this.clmMachineCalendarCustomers,
            this.clmMachineCalendarPlanification,
            this.clmMachineCalendarEdit,
            this.clmMachineCalendarCancel});
            this.dgvCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendar.Location = new System.Drawing.Point(3, 17);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.ReadOnly = true;
            this.dgvCalendar.Size = new System.Drawing.Size(1242, 253);
            this.dgvCalendar.TabIndex = 1;
            this.dgvCalendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendar_CellClick);
            this.dgvCalendar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCalendar_CellContentClick);
            this.dgvCalendar.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvCalendar_DragDrop);
            this.dgvCalendar.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvCalendar_DragEnter);
            this.dgvCalendar.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvCalendar_DragOver);
            this.dgvCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCalendar_MouseDown);
            this.dgvCalendar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCalendar_MouseMove);
            // 
            // clmMachineCalendarCodsec
            // 
            this.clmMachineCalendarCodsec.HeaderText = "codsec";
            this.clmMachineCalendarCodsec.Name = "clmMachineCalendarCodsec";
            this.clmMachineCalendarCodsec.ReadOnly = true;
            this.clmMachineCalendarCodsec.Visible = false;
            // 
            // clmMachineCalendarPOCodsec
            // 
            this.clmMachineCalendarPOCodsec.HeaderText = "POCodsec";
            this.clmMachineCalendarPOCodsec.Name = "clmMachineCalendarPOCodsec";
            this.clmMachineCalendarPOCodsec.ReadOnly = true;
            this.clmMachineCalendarPOCodsec.Visible = false;
            // 
            // clmMachineCalendarPONumber
            // 
            this.clmMachineCalendarPONumber.HeaderText = "Ord. Prod. Nro.";
            this.clmMachineCalendarPONumber.Name = "clmMachineCalendarPONumber";
            this.clmMachineCalendarPONumber.ReadOnly = true;
            // 
            // clmMachineCalendarFilm
            // 
            this.clmMachineCalendarFilm.HeaderText = "Película";
            this.clmMachineCalendarFilm.Name = "clmMachineCalendarFilm";
            this.clmMachineCalendarFilm.ReadOnly = true;
            this.clmMachineCalendarFilm.Width = 90;
            // 
            // clmMachineCalendarWeight
            // 
            this.clmMachineCalendarWeight.HeaderText = "Peso";
            this.clmMachineCalendarWeight.Name = "clmMachineCalendarWeight";
            this.clmMachineCalendarWeight.ReadOnly = true;
            this.clmMachineCalendarWeight.Width = 90;
            // 
            // clmMachineCalendarWidths
            // 
            this.clmMachineCalendarWidths.HeaderText = "Anchos";
            this.clmMachineCalendarWidths.Name = "clmMachineCalendarWidths";
            this.clmMachineCalendarWidths.ReadOnly = true;
            this.clmMachineCalendarWidths.Width = 80;
            // 
            // clmMachineCalendarLength
            // 
            this.clmMachineCalendarLength.HeaderText = "Metraje";
            this.clmMachineCalendarLength.Name = "clmMachineCalendarLength";
            this.clmMachineCalendarLength.ReadOnly = true;
            this.clmMachineCalendarLength.Width = 80;
            // 
            // clmMachineCalendarKilogramsPerHour
            // 
            this.clmMachineCalendarKilogramsPerHour.HeaderText = "Kg./Hr.";
            this.clmMachineCalendarKilogramsPerHour.Name = "clmMachineCalendarKilogramsPerHour";
            this.clmMachineCalendarKilogramsPerHour.ReadOnly = true;
            this.clmMachineCalendarKilogramsPerHour.Width = 55;
            // 
            // clmMachineCalendarIdleTime
            // 
            this.clmMachineCalendarIdleTime.HeaderText = "Tiempo muerto";
            this.clmMachineCalendarIdleTime.Name = "clmMachineCalendarIdleTime";
            this.clmMachineCalendarIdleTime.ReadOnly = true;
            this.clmMachineCalendarIdleTime.Width = 80;
            // 
            // clmMachineCalendarProductionTime
            // 
            this.clmMachineCalendarProductionTime.HeaderText = "Tiempo Prod.";
            this.clmMachineCalendarProductionTime.Name = "clmMachineCalendarProductionTime";
            this.clmMachineCalendarProductionTime.ReadOnly = true;
            this.clmMachineCalendarProductionTime.Width = 80;
            // 
            // clmMachineCalendarInitDateTime
            // 
            this.clmMachineCalendarInitDateTime.HeaderText = "Fecha Inicio";
            this.clmMachineCalendarInitDateTime.Name = "clmMachineCalendarInitDateTime";
            this.clmMachineCalendarInitDateTime.ReadOnly = true;
            // 
            // clmMachineCalendarEndDateTime
            // 
            this.clmMachineCalendarEndDateTime.HeaderText = "Fecha Finalización";
            this.clmMachineCalendarEndDateTime.Name = "clmMachineCalendarEndDateTime";
            this.clmMachineCalendarEndDateTime.ReadOnly = true;
            // 
            // clmMachineCalendarCustomers
            // 
            this.clmMachineCalendarCustomers.HeaderText = "Clientes";
            this.clmMachineCalendarCustomers.Name = "clmMachineCalendarCustomers";
            this.clmMachineCalendarCustomers.ReadOnly = true;
            this.clmMachineCalendarCustomers.Width = 230;
            // 
            // clmMachineCalendarPlanification
            // 
            this.clmMachineCalendarPlanification.HeaderText = "";
            this.clmMachineCalendarPlanification.Name = "clmMachineCalendarPlanification";
            this.clmMachineCalendarPlanification.ReadOnly = true;
            this.clmMachineCalendarPlanification.Width = 30;
            // 
            // clmMachineCalendarEdit
            // 
            this.clmMachineCalendarEdit.HeaderText = "";
            this.clmMachineCalendarEdit.Name = "clmMachineCalendarEdit";
            this.clmMachineCalendarEdit.ReadOnly = true;
            this.clmMachineCalendarEdit.Width = 30;
            // 
            // clmMachineCalendarCancel
            // 
            this.clmMachineCalendarCancel.HeaderText = "";
            this.clmMachineCalendarCancel.Name = "clmMachineCalendarCancel";
            this.clmMachineCalendarCancel.ReadOnly = true;
            this.clmMachineCalendarCancel.Width = 30;
            // 
            // frmFilmProductionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1248, 579);
            this.Controls.Add(this.grpbMachine);
            this.Controls.Add(this.grpbProductionOrder);
            this.Controls.Add(this.gprbCalendar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFilmProductionPlan";
            this.Text = "Programación de extrusión (Bopp)";
            this.Load += new System.EventHandler(this.frmMachineCalendar_Load);
            this.grpbProductionOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrders)).EndInit();
            this.grpbMachine.ResumeLayout(false);
            this.grpbMachine.PerformLayout();
            this.gprbCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbProductionOrder;
        private System.Windows.Forms.DataGridView dgvProductionOrders;
        private System.Windows.Forms.GroupBox grpbMachine;
        private System.Windows.Forms.GroupBox gprbCalendar;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.TextBox txtKPH;
        private System.Windows.Forms.Label lblKPH;
        private System.Windows.Forms.ComboBox cmbMachine;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.Label lblMinimumWidth;
        private System.Windows.Forms.Label lblMaximumWidth;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.TextBox txtMainCoilWidth2;
        private System.Windows.Forms.TextBox txtMainCoilWidth1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarPOCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarPONumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarWidths;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarKilogramsPerHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarIdleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarProductionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarInitDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarEndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMachineCalendarCustomers;
        private System.Windows.Forms.DataGridViewImageColumn clmMachineCalendarPlanification;
        private System.Windows.Forms.DataGridViewImageColumn clmMachineCalendarEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmMachineCalendarCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderCustomers;
        private System.Windows.Forms.DataGridViewImageColumn clmProductionOrderEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmProductionOrderCancel;
    }
}