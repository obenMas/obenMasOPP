namespace BPS
{
    partial class frmMainCoilRegister
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainCoilRegister));
            this.tbcMainCoil = new System.Windows.Forms.TabControl();
            this.tbpMainCoilInfo = new System.Windows.Forms.TabPage();
            this.grpbMainCoilExtruderOrder = new System.Windows.Forms.GroupBox();
            this.cmbCoilerNumber = new System.Windows.Forms.ComboBox();
            this.lblCoiler = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.grpbMainCoilGeneralInformation = new System.Windows.Forms.GroupBox();
            this.btnFixNumeration = new System.Windows.Forms.Button();
            this.lblVariation = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.lblFilmType = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblMainCoilVariation = new System.Windows.Forms.Label();
            this.lblMainCoilBatch = new System.Windows.Forms.Label();
            this.lblMainCoilCode = new System.Windows.Forms.Label();
            this.lblMainCoilProductType = new System.Windows.Forms.Label();
            this.lblMainCoilExtruderOrder = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtMainCoilCode = new System.Windows.Forms.TextBox();
            this.grpbMainCoilTime = new System.Windows.Forms.GroupBox();
            this.dtpEndDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDateTime = new System.Windows.Forms.DateTimePicker();
            this.lblHoursLabel = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMainCoilInitDate = new System.Windows.Forms.Label();
            this.lblMainCoilEndDate = new System.Windows.Forms.Label();
            this.grpbMainCoilTechnicalInfo = new System.Windows.Forms.GroupBox();
            this.lblUnit6 = new System.Windows.Forms.Label();
            this.lblUnit5 = new System.Windows.Forms.Label();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.bl = new System.Windows.Forms.Label();
            this.txtVelocity = new System.Windows.Forms.TextBox();
            this.lblMainCoilVelocity = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblMainCoilWidth = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblMainCoilGrossLength = new System.Windows.Forms.Label();
            this.txtKgPerHour = new System.Windows.Forms.TextBox();
            this.lblMainCoilKgPerHour = new System.Windows.Forms.Label();
            this.grpbMainCoilObservation = new System.Windows.Forms.GroupBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.grpbMainCoil = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilUser = new System.Windows.Forms.GroupBox();
            this.cmbCoiler = new System.Windows.Forms.ComboBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblMainCoilCoiler = new System.Windows.Forms.Label();
            this.lblMainCoilUser = new System.Windows.Forms.Label();
            this.grpbMainCoilType = new System.Windows.Forms.GroupBox();
            this.lblUnit9 = new System.Windows.Forms.Label();
            this.lblTotalDecrease = new System.Windows.Forms.Label();
            this.lblTotDec = new System.Windows.Forms.Label();
            this.cmbMainCoilType = new System.Windows.Forms.ComboBox();
            this.lblMainCoilType = new System.Windows.Forms.Label();
            this.dgvMainCoilDecrease = new System.Windows.Forms.DataGridView();
            this.clmDecreaseCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilDecreaseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnMainCoilSave = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.tbpLabel = new System.Windows.Forms.TabPage();
            this.rptMainCoilSimpleLabel1 = new BPS.Lite.Reports.rptMainCoilSimpleLabel();
            this.crvLabel = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ttpMainCoilRegister = new System.Windows.Forms.ToolTip(this.components);
            this.lblWeightLabel = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblUnit7 = new System.Windows.Forms.Label();
            this.tbcMainCoil.SuspendLayout();
            this.tbpMainCoilInfo.SuspendLayout();
            this.grpbMainCoilExtruderOrder.SuspendLayout();
            this.grpbMainCoilGeneralInformation.SuspendLayout();
            this.grpbMainCoilTime.SuspendLayout();
            this.grpbMainCoilTechnicalInfo.SuspendLayout();
            this.grpbMainCoilObservation.SuspendLayout();
            this.grpbMainCoil.SuspendLayout();
            this.grpbMainCoilUser.SuspendLayout();
            this.grpbMainCoilType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilDecrease)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMainCoil
            // 
            this.tbcMainCoil.Controls.Add(this.tbpMainCoilInfo);
            this.tbcMainCoil.Controls.Add(this.tbpLabel);
            this.tbcMainCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMainCoil.Location = new System.Drawing.Point(0, 0);
            this.tbcMainCoil.Name = "tbcMainCoil";
            this.tbcMainCoil.SelectedIndex = 0;
            this.tbcMainCoil.Size = new System.Drawing.Size(660, 584);
            this.tbcMainCoil.TabIndex = 0;
            // 
            // tbpMainCoilInfo
            // 
            this.tbpMainCoilInfo.Controls.Add(this.grpbMainCoilExtruderOrder);
            this.tbpMainCoilInfo.Controls.Add(this.grpbMainCoilGeneralInformation);
            this.tbpMainCoilInfo.Controls.Add(this.grpbMainCoilTime);
            this.tbpMainCoilInfo.Controls.Add(this.grpbMainCoilTechnicalInfo);
            this.tbpMainCoilInfo.Controls.Add(this.grpbMainCoil);
            this.tbpMainCoilInfo.Location = new System.Drawing.Point(4, 24);
            this.tbpMainCoilInfo.Name = "tbpMainCoilInfo";
            this.tbpMainCoilInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMainCoilInfo.Size = new System.Drawing.Size(652, 556);
            this.tbpMainCoilInfo.TabIndex = 0;
            this.tbpMainCoilInfo.Text = "Información de bobina";
            this.tbpMainCoilInfo.UseVisualStyleBackColor = true;
            // 
            // grpbMainCoilExtruderOrder
            // 
            this.grpbMainCoilExtruderOrder.Controls.Add(this.cmbCoilerNumber);
            this.grpbMainCoilExtruderOrder.Controls.Add(this.lblCoiler);
            this.grpbMainCoilExtruderOrder.Controls.Add(this.lblMachine);
            this.grpbMainCoilExtruderOrder.Location = new System.Drawing.Point(5, -2);
            this.grpbMainCoilExtruderOrder.Name = "grpbMainCoilExtruderOrder";
            this.grpbMainCoilExtruderOrder.Size = new System.Drawing.Size(643, 48);
            this.grpbMainCoilExtruderOrder.TabIndex = 0;
            this.grpbMainCoilExtruderOrder.TabStop = false;
            this.grpbMainCoilExtruderOrder.Text = "Extrusión";
            // 
            // cmbCoilerNumber
            // 
            this.cmbCoilerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoilerNumber.FormattingEnabled = true;
            this.cmbCoilerNumber.Location = new System.Drawing.Point(528, 16);
            this.cmbCoilerNumber.Name = "cmbCoilerNumber";
            this.cmbCoilerNumber.Size = new System.Drawing.Size(66, 28);
            this.cmbCoilerNumber.TabIndex = 2;
            this.cmbCoilerNumber.SelectedIndexChanged += new System.EventHandler(this.cmbCoilerNumber_SelectedIndexChanged);
            this.cmbCoilerNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCoilerNumber_KeyDown);
            // 
            // lblCoiler
            // 
            this.lblCoiler.AutoSize = true;
            this.lblCoiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoiler.Location = new System.Drawing.Point(428, 20);
            this.lblCoiler.Name = "lblCoiler";
            this.lblCoiler.Size = new System.Drawing.Size(91, 20);
            this.lblCoiler.TabIndex = 1;
            this.lblCoiler.Text = "Bobinadora";
            // 
            // lblMachine
            // 
            this.lblMachine.BackColor = System.Drawing.SystemColors.Window;
            this.lblMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachine.Location = new System.Drawing.Point(49, 15);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(350, 25);
            this.lblMachine.TabIndex = 0;
            this.lblMachine.Tag = "clearOnReload";
            this.lblMachine.Text = "DMT";
            this.lblMachine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbMainCoilGeneralInformation
            // 
            this.grpbMainCoilGeneralInformation.Controls.Add(this.btnFixNumeration);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblVariation);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblLot);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblFilmType);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblOrderNumber);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblMainCoilVariation);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblMainCoilBatch);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblMainCoilCode);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblMainCoilProductType);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblMainCoilExtruderOrder);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.lblCode);
            this.grpbMainCoilGeneralInformation.Controls.Add(this.txtMainCoilCode);
            this.grpbMainCoilGeneralInformation.Location = new System.Drawing.Point(5, 42);
            this.grpbMainCoilGeneralInformation.Name = "grpbMainCoilGeneralInformation";
            this.grpbMainCoilGeneralInformation.Size = new System.Drawing.Size(643, 98);
            this.grpbMainCoilGeneralInformation.TabIndex = 1;
            this.grpbMainCoilGeneralInformation.TabStop = false;
            this.grpbMainCoilGeneralInformation.Text = "Datos Generales";
            // 
            // btnFixNumeration
            // 
            this.btnFixNumeration.Image = global::BPS.Lite.Properties.Resources.arrow_refresh1;
            this.btnFixNumeration.Location = new System.Drawing.Point(600, 56);
            this.btnFixNumeration.Name = "btnFixNumeration";
            this.btnFixNumeration.Size = new System.Drawing.Size(25, 25);
            this.btnFixNumeration.TabIndex = 97;
            this.btnFixNumeration.UseVisualStyleBackColor = true;
            this.btnFixNumeration.Visible = false;
            this.btnFixNumeration.Click += new System.EventHandler(this.btnFixNumeration_Click);
            // 
            // lblVariation
            // 
            this.lblVariation.BackColor = System.Drawing.SystemColors.Window;
            this.lblVariation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariation.Location = new System.Drawing.Point(577, 20);
            this.lblVariation.Name = "lblVariation";
            this.lblVariation.Size = new System.Drawing.Size(52, 26);
            this.lblVariation.TabIndex = 7;
            this.lblVariation.Tag = "clearOnReload";
            this.lblVariation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.SystemColors.Window;
            this.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.Location = new System.Drawing.Point(385, 20);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(93, 26);
            this.lblLot.TabIndex = 5;
            this.lblLot.Tag = "clearOnReload";
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmType
            // 
            this.lblFilmType.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmType.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFilmType.Location = new System.Drawing.Point(230, 20);
            this.lblFilmType.Name = "lblFilmType";
            this.lblFilmType.Size = new System.Drawing.Size(90, 26);
            this.lblFilmType.TabIndex = 3;
            this.lblFilmType.Tag = "clearOnReload";
            this.lblFilmType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(78, 20);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(89, 26);
            this.lblOrderNumber.TabIndex = 1;
            this.lblOrderNumber.Tag = "clearOnReload";
            this.lblOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMainCoilVariation
            // 
            this.lblMainCoilVariation.AutoSize = true;
            this.lblMainCoilVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilVariation.Location = new System.Drawing.Point(490, 23);
            this.lblMainCoilVariation.Name = "lblMainCoilVariation";
            this.lblMainCoilVariation.Size = new System.Drawing.Size(75, 20);
            this.lblMainCoilVariation.TabIndex = 6;
            this.lblMainCoilVariation.Text = "Variación";
            // 
            // lblMainCoilBatch
            // 
            this.lblMainCoilBatch.AutoSize = true;
            this.lblMainCoilBatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilBatch.Location = new System.Drawing.Point(332, 23);
            this.lblMainCoilBatch.Name = "lblMainCoilBatch";
            this.lblMainCoilBatch.Size = new System.Drawing.Size(41, 20);
            this.lblMainCoilBatch.TabIndex = 4;
            this.lblMainCoilBatch.Text = "Lote";
            // 
            // lblMainCoilCode
            // 
            this.lblMainCoilCode.AutoSize = true;
            this.lblMainCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilCode.Location = new System.Drawing.Point(13, 59);
            this.lblMainCoilCode.Name = "lblMainCoilCode";
            this.lblMainCoilCode.Size = new System.Drawing.Size(163, 20);
            this.lblMainCoilCode.TabIndex = 8;
            this.lblMainCoilCode.Text = "Código de rollo madre";
            // 
            // lblMainCoilProductType
            // 
            this.lblMainCoilProductType.AutoSize = true;
            this.lblMainCoilProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilProductType.Location = new System.Drawing.Point(179, 23);
            this.lblMainCoilProductType.Name = "lblMainCoilProductType";
            this.lblMainCoilProductType.Size = new System.Drawing.Size(39, 20);
            this.lblMainCoilProductType.TabIndex = 2;
            this.lblMainCoilProductType.Text = "Tipo";
            // 
            // lblMainCoilExtruderOrder
            // 
            this.lblMainCoilExtruderOrder.AutoSize = true;
            this.lblMainCoilExtruderOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilExtruderOrder.Location = new System.Drawing.Point(13, 23);
            this.lblMainCoilExtruderOrder.Name = "lblMainCoilExtruderOrder";
            this.lblMainCoilExtruderOrder.Size = new System.Drawing.Size(53, 20);
            this.lblMainCoilExtruderOrder.TabIndex = 0;
            this.lblMainCoilExtruderOrder.Text = "Orden";
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(201, 56);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(393, 26);
            this.lblCode.TabIndex = 9;
            this.lblCode.Tag = "clearOnReload";
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMainCoilCode
            // 
            this.txtMainCoilCode.Enabled = false;
            this.txtMainCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainCoilCode.Location = new System.Drawing.Point(201, 55);
            this.txtMainCoilCode.Name = "txtMainCoilCode";
            this.txtMainCoilCode.Size = new System.Drawing.Size(393, 29);
            this.txtMainCoilCode.TabIndex = 9;
            this.txtMainCoilCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMainCoilCode.Visible = false;
            this.txtMainCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMainCoilCode_KeyDown);
            // 
            // grpbMainCoilTime
            // 
            this.grpbMainCoilTime.Controls.Add(this.dtpEndDateTime);
            this.grpbMainCoilTime.Controls.Add(this.dtpInitDateTime);
            this.grpbMainCoilTime.Controls.Add(this.lblHoursLabel);
            this.grpbMainCoilTime.Controls.Add(this.lblHours);
            this.grpbMainCoilTime.Controls.Add(this.lblMainCoilInitDate);
            this.grpbMainCoilTime.Controls.Add(this.lblMainCoilEndDate);
            this.grpbMainCoilTime.Location = new System.Drawing.Point(5, 138);
            this.grpbMainCoilTime.Name = "grpbMainCoilTime";
            this.grpbMainCoilTime.Size = new System.Drawing.Size(643, 51);
            this.grpbMainCoilTime.TabIndex = 2;
            this.grpbMainCoilTime.TabStop = false;
            this.grpbMainCoilTime.Text = "Tiempo Rollo Madre";
            // 
            // dtpEndDateTime
            // 
            this.dtpEndDateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEndDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDateTime.Location = new System.Drawing.Point(315, 16);
            this.dtpEndDateTime.Name = "dtpEndDateTime";
            this.dtpEndDateTime.Size = new System.Drawing.Size(194, 26);
            this.dtpEndDateTime.TabIndex = 3;
            this.dtpEndDateTime.ValueChanged += new System.EventHandler(this.dtpEndDateTime_ValueChanged);
            // 
            // dtpInitDateTime
            // 
            this.dtpInitDateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInitDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInitDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDateTime.Location = new System.Drawing.Point(66, 16);
            this.dtpInitDateTime.Name = "dtpInitDateTime";
            this.dtpInitDateTime.Size = new System.Drawing.Size(194, 26);
            this.dtpInitDateTime.TabIndex = 1;
            this.dtpInitDateTime.ValueChanged += new System.EventHandler(this.dtpInitDateTime_ValueChanged);
            // 
            // lblHoursLabel
            // 
            this.lblHoursLabel.AutoSize = true;
            this.lblHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursLabel.Location = new System.Drawing.Point(582, 19);
            this.lblHoursLabel.Name = "lblHoursLabel";
            this.lblHoursLabel.Size = new System.Drawing.Size(52, 20);
            this.lblHoursLabel.TabIndex = 5;
            this.lblHoursLabel.Text = "Horas";
            // 
            // lblHours
            // 
            this.lblHours.BackColor = System.Drawing.SystemColors.Window;
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(521, 19);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(49, 21);
            this.lblHours.TabIndex = 4;
            this.lblHours.Tag = "numericClearOnReload";
            this.lblHours.Text = "0";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMainCoilInitDate
            // 
            this.lblMainCoilInitDate.AutoSize = true;
            this.lblMainCoilInitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilInitDate.Location = new System.Drawing.Point(8, 19);
            this.lblMainCoilInitDate.Name = "lblMainCoilInitDate";
            this.lblMainCoilInitDate.Size = new System.Drawing.Size(46, 20);
            this.lblMainCoilInitDate.TabIndex = 0;
            this.lblMainCoilInitDate.Text = "Inicio";
            // 
            // lblMainCoilEndDate
            // 
            this.lblMainCoilEndDate.AutoSize = true;
            this.lblMainCoilEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilEndDate.Location = new System.Drawing.Point(272, 19);
            this.lblMainCoilEndDate.Name = "lblMainCoilEndDate";
            this.lblMainCoilEndDate.Size = new System.Drawing.Size(31, 20);
            this.lblMainCoilEndDate.TabIndex = 2;
            this.lblMainCoilEndDate.Text = "Fin";
            // 
            // grpbMainCoilTechnicalInfo
            // 
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblUnit6);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblUnit5);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblUnit7);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblUnit2);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.bl);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.txtVelocity);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblMainCoilVelocity);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.txtWidth);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblMainCoilWidth);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.txtWeight);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.txtLength);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblWeightLabel);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblMainCoilGrossLength);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.txtKgPerHour);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.lblMainCoilKgPerHour);
            this.grpbMainCoilTechnicalInfo.Controls.Add(this.grpbMainCoilObservation);
            this.grpbMainCoilTechnicalInfo.Location = new System.Drawing.Point(5, 186);
            this.grpbMainCoilTechnicalInfo.Name = "grpbMainCoilTechnicalInfo";
            this.grpbMainCoilTechnicalInfo.Size = new System.Drawing.Size(643, 199);
            this.grpbMainCoilTechnicalInfo.TabIndex = 3;
            this.grpbMainCoilTechnicalInfo.TabStop = false;
            this.grpbMainCoilTechnicalInfo.Text = "Datos Técnicos";
            // 
            // lblUnit6
            // 
            this.lblUnit6.AutoSize = true;
            this.lblUnit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit6.Location = new System.Drawing.Point(497, 59);
            this.lblUnit6.Name = "lblUnit6";
            this.lblUnit6.Size = new System.Drawing.Size(29, 15);
            this.lblUnit6.TabIndex = 11;
            this.lblUnit6.Text = "mm";
            // 
            // lblUnit5
            // 
            this.lblUnit5.AutoSize = true;
            this.lblUnit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit5.Location = new System.Drawing.Point(497, 27);
            this.lblUnit5.Name = "lblUnit5";
            this.lblUnit5.Size = new System.Drawing.Size(55, 15);
            this.lblUnit5.TabIndex = 5;
            this.lblUnit5.Text = "Mtrs/min";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit2.Location = new System.Drawing.Point(248, 59);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(34, 15);
            this.lblUnit2.TabIndex = 8;
            this.lblUnit2.Text = "Mtrs.";
            // 
            // bl
            // 
            this.bl.AutoSize = true;
            this.bl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bl.Location = new System.Drawing.Point(248, 27);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(38, 15);
            this.bl.TabIndex = 2;
            this.bl.Text = "Kg/Hr";
            // 
            // txtVelocity
            // 
            this.txtVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVelocity.Location = new System.Drawing.Point(407, 21);
            this.txtVelocity.Name = "txtVelocity";
            this.txtVelocity.Size = new System.Drawing.Size(84, 26);
            this.txtVelocity.TabIndex = 1;
            this.txtVelocity.Tag = "numericClearOnReload";
            this.txtVelocity.Text = "0";
            this.txtVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMainCoilVelocity
            // 
            this.lblMainCoilVelocity.AutoSize = true;
            this.lblMainCoilVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilVelocity.Location = new System.Drawing.Point(328, 24);
            this.lblMainCoilVelocity.Name = "lblMainCoilVelocity";
            this.lblMainCoilVelocity.Size = new System.Drawing.Size(79, 20);
            this.lblMainCoilVelocity.TabIndex = 3;
            this.lblMainCoilVelocity.Text = "Velocidad";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(407, 53);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(84, 26);
            this.txtWidth.TabIndex = 3;
            this.txtWidth.Tag = "numericClearOnReload";
            this.txtWidth.Text = "0";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblMainCoilWidth
            // 
            this.lblMainCoilWidth.AutoSize = true;
            this.lblMainCoilWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilWidth.Location = new System.Drawing.Point(328, 56);
            this.lblMainCoilWidth.Name = "lblMainCoilWidth";
            this.lblMainCoilWidth.Size = new System.Drawing.Size(55, 20);
            this.lblMainCoilWidth.TabIndex = 9;
            this.lblMainCoilWidth.Text = "Ancho";
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(158, 53);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(84, 26);
            this.txtLength.TabIndex = 2;
            this.txtLength.Tag = "numericClearOnReload";
            this.txtLength.Text = "0";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblMainCoilGrossLength
            // 
            this.lblMainCoilGrossLength.AutoSize = true;
            this.lblMainCoilGrossLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilGrossLength.Location = new System.Drawing.Point(91, 56);
            this.lblMainCoilGrossLength.Name = "lblMainCoilGrossLength";
            this.lblMainCoilGrossLength.Size = new System.Drawing.Size(62, 20);
            this.lblMainCoilGrossLength.TabIndex = 6;
            this.lblMainCoilGrossLength.Text = "Metraje";
            // 
            // txtKgPerHour
            // 
            this.txtKgPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKgPerHour.Location = new System.Drawing.Point(158, 21);
            this.txtKgPerHour.Name = "txtKgPerHour";
            this.txtKgPerHour.Size = new System.Drawing.Size(84, 26);
            this.txtKgPerHour.TabIndex = 0;
            this.txtKgPerHour.Tag = "numericClearOnReload";
            this.txtKgPerHour.Text = "0";
            this.txtKgPerHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKgPerHour.Enter += new System.EventHandler(this.txtKgPerHour_Enter);
            // 
            // lblMainCoilKgPerHour
            // 
            this.lblMainCoilKgPerHour.AutoSize = true;
            this.lblMainCoilKgPerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilKgPerHour.Location = new System.Drawing.Point(91, 24);
            this.lblMainCoilKgPerHour.Name = "lblMainCoilKgPerHour";
            this.lblMainCoilKgPerHour.Size = new System.Drawing.Size(49, 20);
            this.lblMainCoilKgPerHour.TabIndex = 0;
            this.lblMainCoilKgPerHour.Text = "Kg/Hr";
            // 
            // grpbMainCoilObservation
            // 
            this.grpbMainCoilObservation.Controls.Add(this.txtObservations);
            this.grpbMainCoilObservation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbMainCoilObservation.Location = new System.Drawing.Point(3, 112);
            this.grpbMainCoilObservation.Name = "grpbMainCoilObservation";
            this.grpbMainCoilObservation.Size = new System.Drawing.Size(637, 84);
            this.grpbMainCoilObservation.TabIndex = 5;
            this.grpbMainCoilObservation.TabStop = false;
            this.grpbMainCoilObservation.Text = "Observaciones";
            // 
            // txtObservations
            // 
            this.txtObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservations.Location = new System.Drawing.Point(3, 17);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(631, 64);
            this.txtObservations.TabIndex = 0;
            // 
            // grpbMainCoil
            // 
            this.grpbMainCoil.Controls.Add(this.grpbMainCoilUser);
            this.grpbMainCoil.Controls.Add(this.grpbMainCoilType);
            this.grpbMainCoil.Controls.Add(this.grpbMainCoilButtons);
            this.grpbMainCoil.Location = new System.Drawing.Point(5, 383);
            this.grpbMainCoil.Name = "grpbMainCoil";
            this.grpbMainCoil.Size = new System.Drawing.Size(643, 167);
            this.grpbMainCoil.TabIndex = 4;
            this.grpbMainCoil.TabStop = false;
            // 
            // grpbMainCoilUser
            // 
            this.grpbMainCoilUser.Controls.Add(this.cmbCoiler);
            this.grpbMainCoilUser.Controls.Add(this.cmbOperator);
            this.grpbMainCoilUser.Controls.Add(this.cmbSupervisor);
            this.grpbMainCoilUser.Controls.Add(this.lblSupervisor);
            this.grpbMainCoilUser.Controls.Add(this.lblMainCoilCoiler);
            this.grpbMainCoilUser.Controls.Add(this.lblMainCoilUser);
            this.grpbMainCoilUser.Location = new System.Drawing.Point(418, 11);
            this.grpbMainCoilUser.Name = "grpbMainCoilUser";
            this.grpbMainCoilUser.Size = new System.Drawing.Size(221, 100);
            this.grpbMainCoilUser.TabIndex = 1;
            this.grpbMainCoilUser.TabStop = false;
            this.grpbMainCoilUser.Text = "Usuario";
            // 
            // cmbCoiler
            // 
            this.cmbCoiler.FormattingEnabled = true;
            this.cmbCoiler.Location = new System.Drawing.Point(71, 65);
            this.cmbCoiler.Name = "cmbCoiler";
            this.cmbCoiler.Size = new System.Drawing.Size(144, 23);
            this.cmbCoiler.TabIndex = 5;
            this.cmbCoiler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCoiler_KeyDown);
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(71, 39);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(144, 23);
            this.cmbOperator.TabIndex = 3;
            this.cmbOperator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOperator_KeyDown);
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(71, 13);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(144, 23);
            this.cmbSupervisor.TabIndex = 1;
            this.cmbSupervisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbSupervisor_KeyDown);
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(5, 17);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(65, 15);
            this.lblSupervisor.TabIndex = 0;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // lblMainCoilCoiler
            // 
            this.lblMainCoilCoiler.AutoSize = true;
            this.lblMainCoilCoiler.Location = new System.Drawing.Point(5, 68);
            this.lblMainCoilCoiler.Name = "lblMainCoilCoiler";
            this.lblMainCoilCoiler.Size = new System.Drawing.Size(64, 15);
            this.lblMainCoilCoiler.TabIndex = 4;
            this.lblMainCoilCoiler.Text = "Bobinador";
            // 
            // lblMainCoilUser
            // 
            this.lblMainCoilUser.AutoSize = true;
            this.lblMainCoilUser.Location = new System.Drawing.Point(5, 42);
            this.lblMainCoilUser.Name = "lblMainCoilUser";
            this.lblMainCoilUser.Size = new System.Drawing.Size(59, 15);
            this.lblMainCoilUser.TabIndex = 2;
            this.lblMainCoilUser.Text = "Operador";
            // 
            // grpbMainCoilType
            // 
            this.grpbMainCoilType.Controls.Add(this.lblUnit9);
            this.grpbMainCoilType.Controls.Add(this.lblTotalDecrease);
            this.grpbMainCoilType.Controls.Add(this.lblTotDec);
            this.grpbMainCoilType.Controls.Add(this.cmbMainCoilType);
            this.grpbMainCoilType.Controls.Add(this.lblMainCoilType);
            this.grpbMainCoilType.Controls.Add(this.dgvMainCoilDecrease);
            this.grpbMainCoilType.Location = new System.Drawing.Point(6, 11);
            this.grpbMainCoilType.Name = "grpbMainCoilType";
            this.grpbMainCoilType.Size = new System.Drawing.Size(406, 152);
            this.grpbMainCoilType.TabIndex = 0;
            this.grpbMainCoilType.TabStop = false;
            this.grpbMainCoilType.Text = "Tipo Rollo Madre - Desperdicios ";
            // 
            // lblUnit9
            // 
            this.lblUnit9.AutoSize = true;
            this.lblUnit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit9.Location = new System.Drawing.Point(335, 97);
            this.lblUnit9.Name = "lblUnit9";
            this.lblUnit9.Size = new System.Drawing.Size(19, 12);
            this.lblUnit9.TabIndex = 3;
            this.lblUnit9.Text = "Kg.";
            // 
            // lblTotalDecrease
            // 
            this.lblTotalDecrease.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalDecrease.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDecrease.Location = new System.Drawing.Point(245, 93);
            this.lblTotalDecrease.Name = "lblTotalDecrease";
            this.lblTotalDecrease.Size = new System.Drawing.Size(84, 21);
            this.lblTotalDecrease.TabIndex = 2;
            this.lblTotalDecrease.Tag = "numericClearOnReload";
            this.lblTotalDecrease.Text = "0";
            this.lblTotalDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotDec
            // 
            this.lblTotDec.AutoSize = true;
            this.lblTotDec.Location = new System.Drawing.Point(137, 96);
            this.lblTotDec.Name = "lblTotDec";
            this.lblTotDec.Size = new System.Drawing.Size(102, 15);
            this.lblTotDec.TabIndex = 1;
            this.lblTotDec.Text = "Peso desperdicio";
            // 
            // cmbMainCoilType
            // 
            this.cmbMainCoilType.FormattingEnabled = true;
            this.cmbMainCoilType.Location = new System.Drawing.Point(131, 117);
            this.cmbMainCoilType.Name = "cmbMainCoilType";
            this.cmbMainCoilType.Size = new System.Drawing.Size(255, 23);
            this.cmbMainCoilType.TabIndex = 5;
            this.cmbMainCoilType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbMainCoilType_KeyDown);
            // 
            // lblMainCoilType
            // 
            this.lblMainCoilType.AutoSize = true;
            this.lblMainCoilType.Location = new System.Drawing.Point(21, 120);
            this.lblMainCoilType.Name = "lblMainCoilType";
            this.lblMainCoilType.Size = new System.Drawing.Size(102, 15);
            this.lblMainCoilType.TabIndex = 4;
            this.lblMainCoilType.Text = "Tipo Rollo Madre";
            // 
            // dgvMainCoilDecrease
            // 
            this.dgvMainCoilDecrease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilDecrease.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmDecreaseCodsec,
            this.clmMainCoilDecreaseType,
            this.clmMainCoilWeigth});
            this.dgvMainCoilDecrease.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMainCoilDecrease.Location = new System.Drawing.Point(3, 17);
            this.dgvMainCoilDecrease.Name = "dgvMainCoilDecrease";
            this.dgvMainCoilDecrease.Size = new System.Drawing.Size(400, 73);
            this.dgvMainCoilDecrease.TabIndex = 0;
            this.dgvMainCoilDecrease.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMainCoilDecrease_CellDoubleClick);
            // 
            // clmDecreaseCodsec
            // 
            this.clmDecreaseCodsec.HeaderText = "Codsec";
            this.clmDecreaseCodsec.Name = "clmDecreaseCodsec";
            this.clmDecreaseCodsec.ReadOnly = true;
            this.clmDecreaseCodsec.Visible = false;
            // 
            // clmMainCoilDecreaseType
            // 
            this.clmMainCoilDecreaseType.HeaderText = "Tipo de Desperdicio";
            this.clmMainCoilDecreaseType.Name = "clmMainCoilDecreaseType";
            this.clmMainCoilDecreaseType.Width = 200;
            // 
            // clmMainCoilWeigth
            // 
            this.clmMainCoilWeigth.HeaderText = "Kilos";
            this.clmMainCoilWeigth.Name = "clmMainCoilWeigth";
            this.clmMainCoilWeigth.Width = 145;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilSave);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(418, 110);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(220, 53);
            this.grpbMainCoilButtons.TabIndex = 2;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnMainCoilSave
            // 
            this.btnMainCoilSave.BackgroundImage = global::BPS.Lite.Properties.Resources.save_32_blue;
            this.btnMainCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilSave.Location = new System.Drawing.Point(115, 10);
            this.btnMainCoilSave.Name = "btnMainCoilSave";
            this.btnMainCoilSave.Size = new System.Drawing.Size(40, 40);
            this.btnMainCoilSave.TabIndex = 0;
            this.ttpMainCoilRegister.SetToolTip(this.btnMainCoilSave, "Guardar Rollo Madre");
            this.btnMainCoilSave.UseVisualStyleBackColor = true;
            this.btnMainCoilSave.Click += new System.EventHandler(this.btnMainCoilSave_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Lite.Properties.Resources.cancel1;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(66, 10);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(40, 40);
            this.btnMainCoilCancel.TabIndex = 1;
            this.ttpMainCoilRegister.SetToolTip(this.btnMainCoilCancel, "Cancelar Rollo Madre");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilCancel.Click += new System.EventHandler(this.btnMainCoilCancel_Click);
            // 
            // tbpLabel
            // 
            this.tbpLabel.Location = new System.Drawing.Point(4, 24);
            this.tbpLabel.Name = "tbpLabel";
            this.tbpLabel.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLabel.Size = new System.Drawing.Size(652, 535);
            this.tbpLabel.TabIndex = 1;
            this.tbpLabel.Text = "Etiqueta";
            this.tbpLabel.UseVisualStyleBackColor = true;
            // 
            // crvLabel
            // 
            this.crvLabel.ActiveViewIndex = -1;
            this.crvLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLabel.Location = new System.Drawing.Point(0, 0);
            this.crvLabel.Name = "crvLabel";
            this.crvLabel.Size = new System.Drawing.Size(150, 150);
            this.crvLabel.TabIndex = 0;
            // 
            // lblWeightLabel
            // 
            this.lblWeightLabel.AutoSize = true;
            this.lblWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightLabel.Location = new System.Drawing.Point(91, 88);
            this.lblWeightLabel.Name = "lblWeightLabel";
            this.lblWeightLabel.Size = new System.Drawing.Size(45, 20);
            this.lblWeightLabel.TabIndex = 6;
            this.lblWeightLabel.Text = "Peso";
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(158, 85);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(84, 26);
            this.txtWeight.TabIndex = 4;
            this.txtWeight.Tag = "numericClearOnReload";
            this.txtWeight.Text = "0";
            this.txtWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblUnit7
            // 
            this.lblUnit7.AutoSize = true;
            this.lblUnit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit7.Location = new System.Drawing.Point(248, 91);
            this.lblUnit7.Name = "lblUnit7";
            this.lblUnit7.Size = new System.Drawing.Size(34, 15);
            this.lblUnit7.TabIndex = 8;
            this.lblUnit7.Text = "Mtrs.";
            // 
            // frmMainCoilRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(660, 584);
            this.Controls.Add(this.tbcMainCoil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainCoilRegister";
            this.ShowInTaskbar = false;
            this.Text = "Rollo Madre";
            this.Load += new System.EventHandler(this.frmMainCoilRegister_Load);
            this.tbcMainCoil.ResumeLayout(false);
            this.tbpMainCoilInfo.ResumeLayout(false);
            this.grpbMainCoilExtruderOrder.ResumeLayout(false);
            this.grpbMainCoilExtruderOrder.PerformLayout();
            this.grpbMainCoilGeneralInformation.ResumeLayout(false);
            this.grpbMainCoilGeneralInformation.PerformLayout();
            this.grpbMainCoilTime.ResumeLayout(false);
            this.grpbMainCoilTime.PerformLayout();
            this.grpbMainCoilTechnicalInfo.ResumeLayout(false);
            this.grpbMainCoilTechnicalInfo.PerformLayout();
            this.grpbMainCoilObservation.ResumeLayout(false);
            this.grpbMainCoilObservation.PerformLayout();
            this.grpbMainCoil.ResumeLayout(false);
            this.grpbMainCoilUser.ResumeLayout(false);
            this.grpbMainCoilUser.PerformLayout();
            this.grpbMainCoilType.ResumeLayout(false);
            this.grpbMainCoilType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilDecrease)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMainCoil;
        private System.Windows.Forms.TabPage tbpMainCoilInfo;
        private System.Windows.Forms.GroupBox grpbMainCoilExtruderOrder;
        private System.Windows.Forms.ComboBox cmbCoilerNumber;
        private System.Windows.Forms.Label lblCoiler;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.GroupBox grpbMainCoilGeneralInformation;
        private System.Windows.Forms.Label lblVariation;
        private System.Windows.Forms.Label lblLot;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblFilmType;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblMainCoilVariation;
        private System.Windows.Forms.Label lblMainCoilBatch;
        private System.Windows.Forms.Label lblMainCoilCode;
        private System.Windows.Forms.Label lblMainCoilProductType;
        private System.Windows.Forms.Label lblMainCoilExtruderOrder;
        private System.Windows.Forms.GroupBox grpbMainCoilTime;
        private System.Windows.Forms.DateTimePicker dtpEndDateTime;
        private System.Windows.Forms.DateTimePicker dtpInitDateTime;
        private System.Windows.Forms.Label lblHoursLabel;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMainCoilInitDate;
        private System.Windows.Forms.Label lblMainCoilEndDate;
        private System.Windows.Forms.GroupBox grpbMainCoilTechnicalInfo;
        private System.Windows.Forms.Label lblUnit6;
        private System.Windows.Forms.Label lblUnit5;
        private System.Windows.Forms.Label lblUnit2;
        private System.Windows.Forms.Label bl;
        private System.Windows.Forms.TextBox txtVelocity;
        private System.Windows.Forms.Label lblMainCoilVelocity;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblMainCoilWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblMainCoilGrossLength;
        private System.Windows.Forms.TextBox txtKgPerHour;
        private System.Windows.Forms.Label lblMainCoilKgPerHour;
        private System.Windows.Forms.GroupBox grpbMainCoilObservation;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.GroupBox grpbMainCoil;
        private System.Windows.Forms.GroupBox grpbMainCoilType;
        private System.Windows.Forms.Label lblUnit9;
        private System.Windows.Forms.Label lblTotalDecrease;
        private System.Windows.Forms.Label lblTotDec;
        private System.Windows.Forms.ComboBox cmbMainCoilType;
        private System.Windows.Forms.Label lblMainCoilType;
        private System.Windows.Forms.DataGridView dgvMainCoilDecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDecreaseCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilDecreaseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilWeigth;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilSave;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.TabPage tbpLabel;
        private System.Windows.Forms.GroupBox grpbMainCoilUser;
        private System.Windows.Forms.ComboBox cmbCoiler;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblMainCoilCoiler;
        private System.Windows.Forms.Label lblMainCoilUser;
        private System.Windows.Forms.TextBox txtMainCoilCode;
        private System.Windows.Forms.ToolTip ttpMainCoilRegister;
        private System.Windows.Forms.Button btnFixNumeration;
        private System.Windows.Forms.Label lblUnit7;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeightLabel;

    }
}