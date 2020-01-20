namespace BPS
{
    partial class frmCuttingOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingOrderDetail));
            this.grpbCombination = new System.Windows.Forms.GroupBox();
            this.lblWaste1 = new System.Windows.Forms.Label();
            this.lblWaste2 = new System.Windows.Forms.Label();
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblSeparator = new System.Windows.Forms.Label();
            this.lblStatusImage = new System.Windows.Forms.Label();
            this.lblPercentage2 = new System.Windows.Forms.Label();
            this.lblStopsNumber = new System.Windows.Forms.Label();
            this.lblWaste = new System.Windows.Forms.Label();
            this.lblWasteLabel = new System.Windows.Forms.Label();
            this.lblStops = new System.Windows.Forms.Label();
            this.lblTotalCoils = new System.Windows.Forms.Label();
            this.lblUsedArms = new System.Windows.Forms.Label();
            this.lblUtilWidth = new System.Windows.Forms.Label();
            this.lblUsedWidth = new System.Windows.Forms.Label();
            this.lblTotalCoilsLabel = new System.Windows.Forms.Label();
            this.lblUsedArmsLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUtilWidthLabel = new System.Windows.Forms.Label();
            this.lblUsedWidthLabel = new System.Windows.Forms.Label();
            this.lblCutterNameLabel = new System.Windows.Forms.Label();
            this.lblFulmNameLabel = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.grpbCoilDetail = new System.Windows.Forms.GroupBox();
            this.dgvCoilsDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReportCutinngOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.ttpCuttingOrderDetails = new System.Windows.Forms.ToolTip(this.components);
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChangeProduct = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbCombination.SuspendLayout();
            this.grpbInfo.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            this.grpbCoilDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCombination
            // 
            this.grpbCombination.Controls.Add(this.lblWaste1);
            this.grpbCombination.Controls.Add(this.lblWaste2);
            this.grpbCombination.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCombination.Location = new System.Drawing.Point(0, 139);
            this.grpbCombination.Name = "grpbCombination";
            this.grpbCombination.Size = new System.Drawing.Size(978, 102);
            this.grpbCombination.TabIndex = 1;
            this.grpbCombination.TabStop = false;
            this.grpbCombination.Text = "Combinación";
            // 
            // lblWaste1
            // 
            this.lblWaste1.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste1.Location = new System.Drawing.Point(14, 21);
            this.lblWaste1.Name = "lblWaste1";
            this.lblWaste1.Size = new System.Drawing.Size(20, 70);
            this.lblWaste1.TabIndex = 1;
            this.lblWaste1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWaste2
            // 
            this.lblWaste2.BackColor = System.Drawing.Color.DimGray;
            this.lblWaste2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWaste2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste2.Location = new System.Drawing.Point(944, 21);
            this.lblWaste2.Name = "lblWaste2";
            this.lblWaste2.Size = new System.Drawing.Size(20, 70);
            this.lblWaste2.TabIndex = 2;
            this.lblWaste2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.grpbNotes);
            this.grpbInfo.Controls.Add(this.lblSeparator);
            this.grpbInfo.Controls.Add(this.lblStatusImage);
            this.grpbInfo.Controls.Add(this.lblPercentage2);
            this.grpbInfo.Controls.Add(this.lblStopsNumber);
            this.grpbInfo.Controls.Add(this.lblWaste);
            this.grpbInfo.Controls.Add(this.lblWasteLabel);
            this.grpbInfo.Controls.Add(this.lblStops);
            this.grpbInfo.Controls.Add(this.lblTotalCoils);
            this.grpbInfo.Controls.Add(this.lblUsedArms);
            this.grpbInfo.Controls.Add(this.lblUtilWidth);
            this.grpbInfo.Controls.Add(this.lblUsedWidth);
            this.grpbInfo.Controls.Add(this.lblTotalCoilsLabel);
            this.grpbInfo.Controls.Add(this.lblUsedArmsLabel);
            this.grpbInfo.Controls.Add(this.lblStatus);
            this.grpbInfo.Controls.Add(this.lblUtilWidthLabel);
            this.grpbInfo.Controls.Add(this.lblUsedWidthLabel);
            this.grpbInfo.Controls.Add(this.lblCutterNameLabel);
            this.grpbInfo.Controls.Add(this.lblFulmNameLabel);
            this.grpbInfo.Controls.Add(this.lblCutterName);
            this.grpbInfo.Controls.Add(this.lblFilmName);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(978, 139);
            this.grpbInfo.TabIndex = 2;
            this.grpbInfo.TabStop = false;
            this.grpbInfo.Text = "Orden de corte # 1234";
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.lblNotes);
            this.grpbNotes.Location = new System.Drawing.Point(85, 72);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(881, 56);
            this.grpbNotes.TabIndex = 58;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Observaciones";
            // 
            // lblNotes
            // 
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNotes.Location = new System.Drawing.Point(3, 17);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(875, 36);
            this.lblNotes.TabIndex = 0;
            // 
            // lblSeparator
            // 
            this.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparator.Location = new System.Drawing.Point(77, 17);
            this.lblSeparator.Name = "lblSeparator";
            this.lblSeparator.Size = new System.Drawing.Size(2, 111);
            this.lblSeparator.TabIndex = 57;
            // 
            // lblStatusImage
            // 
            this.lblStatusImage.Image = global::BPS.Properties.Resources.calendar;
            this.lblStatusImage.Location = new System.Drawing.Point(33, 47);
            this.lblStatusImage.Name = "lblStatusImage";
            this.lblStatusImage.Size = new System.Drawing.Size(25, 25);
            this.lblStatusImage.TabIndex = 56;
            // 
            // lblPercentage2
            // 
            this.lblPercentage2.AutoSize = true;
            this.lblPercentage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage2.Location = new System.Drawing.Point(622, 50);
            this.lblPercentage2.Name = "lblPercentage2";
            this.lblPercentage2.Size = new System.Drawing.Size(20, 17);
            this.lblPercentage2.TabIndex = 53;
            this.lblPercentage2.Text = "%";
            // 
            // lblStopsNumber
            // 
            this.lblStopsNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblStopsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStopsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopsNumber.Location = new System.Drawing.Point(580, 23);
            this.lblStopsNumber.Name = "lblStopsNumber";
            this.lblStopsNumber.Size = new System.Drawing.Size(41, 21);
            this.lblStopsNumber.TabIndex = 51;
            this.lblStopsNumber.Tag = "clearOnReload";
            this.lblStopsNumber.Text = "0";
            this.lblStopsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWaste
            // 
            this.lblWaste.BackColor = System.Drawing.SystemColors.Window;
            this.lblWaste.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaste.Location = new System.Drawing.Point(580, 48);
            this.lblWaste.Name = "lblWaste";
            this.lblWaste.Size = new System.Drawing.Size(41, 21);
            this.lblWaste.TabIndex = 52;
            this.lblWaste.Tag = "clearOnReload";
            this.lblWaste.Text = "0";
            this.lblWaste.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblWasteLabel
            // 
            this.lblWasteLabel.AutoSize = true;
            this.lblWasteLabel.Location = new System.Drawing.Point(482, 51);
            this.lblWasteLabel.Name = "lblWasteLabel";
            this.lblWasteLabel.Size = new System.Drawing.Size(73, 15);
            this.lblWasteLabel.TabIndex = 49;
            this.lblWasteLabel.Text = "Desperdicio";
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.lblStops.Location = new System.Drawing.Point(482, 26);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(95, 15);
            this.lblStops.TabIndex = 50;
            this.lblStops.Text = "Nro. de paradas";
            // 
            // lblTotalCoils
            // 
            this.lblTotalCoils.BackColor = System.Drawing.SystemColors.Window;
            this.lblTotalCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCoils.Location = new System.Drawing.Point(896, 48);
            this.lblTotalCoils.Name = "lblTotalCoils";
            this.lblTotalCoils.Size = new System.Drawing.Size(70, 21);
            this.lblTotalCoils.TabIndex = 47;
            this.lblTotalCoils.Tag = "clearOnReload";
            this.lblTotalCoils.Text = "0";
            this.lblTotalCoils.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedArms
            // 
            this.lblUsedArms.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedArms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedArms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedArms.Location = new System.Drawing.Point(727, 48);
            this.lblUsedArms.Name = "lblUsedArms";
            this.lblUsedArms.Size = new System.Drawing.Size(70, 21);
            this.lblUsedArms.TabIndex = 47;
            this.lblUsedArms.Tag = "clearOnReload";
            this.lblUsedArms.Text = "0";
            this.lblUsedArms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUtilWidth
            // 
            this.lblUtilWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUtilWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUtilWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilWidth.Location = new System.Drawing.Point(727, 23);
            this.lblUtilWidth.Name = "lblUtilWidth";
            this.lblUtilWidth.Size = new System.Drawing.Size(70, 21);
            this.lblUtilWidth.TabIndex = 48;
            this.lblUtilWidth.Tag = "clearOnReload";
            this.lblUtilWidth.Text = "0";
            this.lblUtilWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsedWidth
            // 
            this.lblUsedWidth.BackColor = System.Drawing.SystemColors.Window;
            this.lblUsedWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsedWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedWidth.Location = new System.Drawing.Point(896, 23);
            this.lblUsedWidth.Name = "lblUsedWidth";
            this.lblUsedWidth.Size = new System.Drawing.Size(70, 21);
            this.lblUsedWidth.TabIndex = 48;
            this.lblUsedWidth.Tag = "clearOnReload";
            this.lblUsedWidth.Text = "0";
            this.lblUsedWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCoilsLabel
            // 
            this.lblTotalCoilsLabel.AutoSize = true;
            this.lblTotalCoilsLabel.Location = new System.Drawing.Point(803, 51);
            this.lblTotalCoilsLabel.Name = "lblTotalCoilsLabel";
            this.lblTotalCoilsLabel.Size = new System.Drawing.Size(82, 15);
            this.lblTotalCoilsLabel.TabIndex = 45;
            this.lblTotalCoilsLabel.Text = "Total Bobinas";
            // 
            // lblUsedArmsLabel
            // 
            this.lblUsedArmsLabel.AutoSize = true;
            this.lblUsedArmsLabel.Location = new System.Drawing.Point(648, 51);
            this.lblUsedArmsLabel.Name = "lblUsedArmsLabel";
            this.lblUsedArmsLabel.Size = new System.Drawing.Size(77, 15);
            this.lblUsedArmsLabel.TabIndex = 45;
            this.lblUsedArmsLabel.Text = "Num. brazos";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 77);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 15);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Programada";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUtilWidthLabel
            // 
            this.lblUtilWidthLabel.AutoSize = true;
            this.lblUtilWidthLabel.Location = new System.Drawing.Point(648, 26);
            this.lblUtilWidthLabel.Name = "lblUtilWidthLabel";
            this.lblUtilWidthLabel.Size = new System.Drawing.Size(62, 15);
            this.lblUtilWidthLabel.TabIndex = 46;
            this.lblUtilWidthLabel.Text = "Ancho Util";
            // 
            // lblUsedWidthLabel
            // 
            this.lblUsedWidthLabel.AutoSize = true;
            this.lblUsedWidthLabel.Location = new System.Drawing.Point(803, 26);
            this.lblUsedWidthLabel.Name = "lblUsedWidthLabel";
            this.lblUsedWidthLabel.Size = new System.Drawing.Size(92, 15);
            this.lblUsedWidthLabel.TabIndex = 46;
            this.lblUsedWidthLabel.Text = "Ancho Utilizado";
            // 
            // lblCutterNameLabel
            // 
            this.lblCutterNameLabel.AutoSize = true;
            this.lblCutterNameLabel.Location = new System.Drawing.Point(82, 51);
            this.lblCutterNameLabel.Name = "lblCutterNameLabel";
            this.lblCutterNameLabel.Size = new System.Drawing.Size(61, 15);
            this.lblCutterNameLabel.TabIndex = 43;
            this.lblCutterNameLabel.Text = "Cortadora";
            // 
            // lblFulmNameLabel
            // 
            this.lblFulmNameLabel.AutoSize = true;
            this.lblFulmNameLabel.Location = new System.Drawing.Point(82, 26);
            this.lblFulmNameLabel.Name = "lblFulmNameLabel";
            this.lblFulmNameLabel.Size = new System.Drawing.Size(51, 15);
            this.lblFulmNameLabel.TabIndex = 44;
            this.lblFulmNameLabel.Text = "Película";
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(149, 48);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(318, 21);
            this.lblCutterName.TabIndex = 40;
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(149, 23);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(318, 21);
            this.lblFilmName.TabIndex = 41;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbCoilDetail
            // 
            this.grpbCoilDetail.Controls.Add(this.dgvCoilsDetail);
            this.grpbCoilDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilDetail.Location = new System.Drawing.Point(0, 241);
            this.grpbCoilDetail.Name = "grpbCoilDetail";
            this.grpbCoilDetail.Size = new System.Drawing.Size(978, 275);
            this.grpbCoilDetail.TabIndex = 3;
            this.grpbCoilDetail.TabStop = false;
            this.grpbCoilDetail.Text = "Detalle de corte";
            // 
            // dgvCoilsDetail
            // 
            this.dgvCoilsDetail.AllowDrop = true;
            this.dgvCoilsDetail.AllowUserToAddRows = false;
            this.dgvCoilsDetail.AllowUserToDeleteRows = false;
            this.dgvCoilsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPosition,
            this.clmCustomer,
            this.clmSalesOrder,
            this.clmProductCode,
            this.clmChangeProduct,
            this.clmProductCodsec,
            this.clmWidth,
            this.clmLength,
            this.clmWeigth});
            this.dgvCoilsDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoilsDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvCoilsDetail.Name = "dgvCoilsDetail";
            this.dgvCoilsDetail.ReadOnly = true;
            this.dgvCoilsDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoilsDetail.Size = new System.Drawing.Size(972, 255);
            this.dgvCoilsDetail.TabIndex = 0;
            this.dgvCoilsDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoilsDetail_CellClick);
            this.dgvCoilsDetail.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvCoilsDetail_DragDrop);
            this.dgvCoilsDetail.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvCoilsDetail_DragEnter);
            this.dgvCoilsDetail.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvCoilsDetail_DragOver);
            this.dgvCoilsDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCoilsDetail_MouseDown);
            this.dgvCoilsDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvCoilsDetail_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReportCutinngOrder);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnProcess);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Location = new System.Drawing.Point(867, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 43);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnReportCutinngOrder
            // 
            this.btnReportCutinngOrder.Image = global::BPS.Properties.Resources.report;
            this.btnReportCutinngOrder.Location = new System.Drawing.Point(30, 13);
            this.btnReportCutinngOrder.Name = "btnReportCutinngOrder";
            this.btnReportCutinngOrder.Size = new System.Drawing.Size(25, 25);
            this.btnReportCutinngOrder.TabIndex = 6;
            this.ttpCuttingOrderDetails.SetToolTip(this.btnReportCutinngOrder, "Reporte");
            this.btnReportCutinngOrder.UseVisualStyleBackColor = true;
            this.btnReportCutinngOrder.Click += new System.EventHandler(this.btnReportCutinngOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(80, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 5;
            this.ttpCuttingOrderDetails.SetToolTip(this.btnExit, "Salir Orden de Corte");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::BPS.Properties.Resources.gear_16;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(5, 13);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(25, 25);
            this.btnProcess.TabIndex = 3;
            this.ttpCuttingOrderDetails.SetToolTip(this.btnProcess, "Procesar Orden de Corte");
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(55, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 4;
            this.ttpCuttingOrderDetails.SetToolTip(this.btnCancel, "Cancelar Orden de Corte");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(6, 511);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(860, 43);
            this.grpbFilters.TabIndex = 12;
            this.grpbFilters.TabStop = false;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posición";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 80;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 220;
            // 
            // clmSalesOrder
            // 
            this.clmSalesOrder.HeaderText = "Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            this.clmSalesOrder.Width = 80;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Cód. Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Width = 200;
            // 
            // clmChangeProduct
            // 
            this.clmChangeProduct.HeaderText = "";
            this.clmChangeProduct.Name = "clmChangeProduct";
            this.clmChangeProduct.ReadOnly = true;
            this.clmChangeProduct.Width = 30;
            // 
            // clmProductCodsec
            // 
            this.clmProductCodsec.HeaderText = "prodCodsec";
            this.clmProductCodsec.Name = "clmProductCodsec";
            this.clmProductCodsec.ReadOnly = true;
            this.clmProductCodsec.Visible = false;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Long. Aprox.";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso Aprox";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            // 
            // frmCuttingOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(978, 556);
            this.Controls.Add(this.grpbCoilDetail);
            this.Controls.Add(this.grpbCombination);
            this.Controls.Add(this.grpbInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingOrderDetail";
            this.Text = "Detalle de orden de corte";
            this.Load += new System.EventHandler(this.frmCuttingOrderDetail_Load);
            this.grpbCombination.ResumeLayout(false);
            this.grpbInfo.ResumeLayout(false);
            this.grpbInfo.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbCoilDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCombination;
        private System.Windows.Forms.Label lblWaste1;
        private System.Windows.Forms.Label lblWaste2;
        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.Label lblSeparator;
        private System.Windows.Forms.Label lblStatusImage;
        private System.Windows.Forms.Label lblPercentage2;
        private System.Windows.Forms.Label lblStopsNumber;
        private System.Windows.Forms.Label lblWaste;
        private System.Windows.Forms.Label lblWasteLabel;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.Label lblUsedArms;
        private System.Windows.Forms.Label lblUsedWidth;
        private System.Windows.Forms.Label lblUsedArmsLabel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUsedWidthLabel;
        private System.Windows.Forms.Label lblCutterNameLabel;
        private System.Windows.Forms.Label lblFulmNameLabel;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.GroupBox grpbCoilDetail;
        private System.Windows.Forms.Label lblTotalCoils;
        private System.Windows.Forms.Label lblUtilWidth;
        private System.Windows.Forms.Label lblTotalCoilsLabel;
        private System.Windows.Forms.Label lblUtilWidthLabel;
        private System.Windows.Forms.DataGridView dgvCoilsDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.Button btnReportCutinngOrder;
        private System.Windows.Forms.ToolTip ttpCuttingOrderDetails;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewImageColumn clmChangeProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
    }
}