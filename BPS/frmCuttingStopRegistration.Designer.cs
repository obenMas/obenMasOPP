namespace BPS
{
    partial class frmCuttingStopRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuttingStopRegistration));
            this.grpbCuttingOrderData = new System.Windows.Forms.GroupBox();
            this.lblCuttingOrderNumber = new System.Windows.Forms.Label();
            this.lblCuttingOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblStops = new System.Windows.Forms.Label();
            this.lblCutterNameLabel = new System.Windows.Forms.Label();
            this.lblFulmNameLabel = new System.Windows.Forms.Label();
            this.lblCutterName = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.grpbCoilsInfo = new System.Windows.Forms.GroupBox();
            this.dgvCoilsDetail = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilSalesOrderDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCuttingOrderDetailCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCoreCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilQualityCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDefects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDefectsValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCellarCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbMainCoil = new System.Windows.Forms.GroupBox();
            this.dgvMainCoilList = new System.Windows.Forms.DataGridView();
            this.clmMainCoilListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilListBatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilUsedLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.btnCoilSave = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.ttpCuttingStopregistration = new System.Windows.Forms.ToolTip(this.components);
            this.grpbCuttingOrderData.SuspendLayout();
            this.grpbCoilsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsDetail)).BeginInit();
            this.grpbMainCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCuttingOrderData
            // 
            this.grpbCuttingOrderData.Controls.Add(this.lblCuttingOrderNumber);
            this.grpbCuttingOrderData.Controls.Add(this.lblCuttingOrderNumberLabel);
            this.grpbCuttingOrderData.Controls.Add(this.lblStop);
            this.grpbCuttingOrderData.Controls.Add(this.lblStops);
            this.grpbCuttingOrderData.Controls.Add(this.lblCutterNameLabel);
            this.grpbCuttingOrderData.Controls.Add(this.lblFulmNameLabel);
            this.grpbCuttingOrderData.Controls.Add(this.lblCutterName);
            this.grpbCuttingOrderData.Controls.Add(this.lblFilmName);
            this.grpbCuttingOrderData.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCuttingOrderData.Location = new System.Drawing.Point(0, 0);
            this.grpbCuttingOrderData.Name = "grpbCuttingOrderData";
            this.grpbCuttingOrderData.Size = new System.Drawing.Size(1244, 61);
            this.grpbCuttingOrderData.TabIndex = 0;
            this.grpbCuttingOrderData.TabStop = false;
            this.grpbCuttingOrderData.Text = "Orden de corte";
            // 
            // lblCuttingOrderNumber
            // 
            this.lblCuttingOrderNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblCuttingOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuttingOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuttingOrderNumber.Location = new System.Drawing.Point(246, 24);
            this.lblCuttingOrderNumber.Name = "lblCuttingOrderNumber";
            this.lblCuttingOrderNumber.Size = new System.Drawing.Size(64, 21);
            this.lblCuttingOrderNumber.TabIndex = 1;
            this.lblCuttingOrderNumber.Tag = "clearOnReload";
            this.lblCuttingOrderNumber.Text = "0";
            this.lblCuttingOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCuttingOrderNumberLabel
            // 
            this.lblCuttingOrderNumberLabel.AutoSize = true;
            this.lblCuttingOrderNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuttingOrderNumberLabel.Location = new System.Drawing.Point(110, 27);
            this.lblCuttingOrderNumberLabel.Name = "lblCuttingOrderNumberLabel";
            this.lblCuttingOrderNumberLabel.Size = new System.Drawing.Size(128, 16);
            this.lblCuttingOrderNumberLabel.TabIndex = 0;
            this.lblCuttingOrderNumberLabel.Text = "Número de orden";
            // 
            // lblStop
            // 
            this.lblStop.BackColor = System.Drawing.SystemColors.Window;
            this.lblStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(397, 24);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(64, 21);
            this.lblStop.TabIndex = 3;
            this.lblStop.Tag = "clearOnReload";
            this.lblStop.Text = "0";
            this.lblStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStops
            // 
            this.lblStops.AutoSize = true;
            this.lblStops.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStops.Location = new System.Drawing.Point(318, 27);
            this.lblStops.Name = "lblStops";
            this.lblStops.Size = new System.Drawing.Size(71, 16);
            this.lblStops.TabIndex = 2;
            this.lblStops.Text = "Parada #";
            // 
            // lblCutterNameLabel
            // 
            this.lblCutterNameLabel.AutoSize = true;
            this.lblCutterNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterNameLabel.Location = new System.Drawing.Point(831, 27);
            this.lblCutterNameLabel.Name = "lblCutterNameLabel";
            this.lblCutterNameLabel.Size = new System.Drawing.Size(77, 16);
            this.lblCutterNameLabel.TabIndex = 6;
            this.lblCutterNameLabel.Text = "Cortadora";
            // 
            // lblFulmNameLabel
            // 
            this.lblFulmNameLabel.AutoSize = true;
            this.lblFulmNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFulmNameLabel.Location = new System.Drawing.Point(469, 27);
            this.lblFulmNameLabel.Name = "lblFulmNameLabel";
            this.lblFulmNameLabel.Size = new System.Drawing.Size(70, 16);
            this.lblFulmNameLabel.TabIndex = 4;
            this.lblFulmNameLabel.Text = "Producto";
            // 
            // lblCutterName
            // 
            this.lblCutterName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCutterName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCutterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutterName.Location = new System.Drawing.Point(916, 24);
            this.lblCutterName.Name = "lblCutterName";
            this.lblCutterName.Size = new System.Drawing.Size(215, 21);
            this.lblCutterName.TabIndex = 7;
            this.lblCutterName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilmName
            // 
            this.lblFilmName.BackColor = System.Drawing.SystemColors.Window;
            this.lblFilmName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(547, 24);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(276, 21);
            this.lblFilmName.TabIndex = 5;
            this.lblFilmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbCoilsInfo
            // 
            this.grpbCoilsInfo.Controls.Add(this.dgvCoilsDetail);
            this.grpbCoilsInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilsInfo.Location = new System.Drawing.Point(0, 61);
            this.grpbCoilsInfo.Name = "grpbCoilsInfo";
            this.grpbCoilsInfo.Size = new System.Drawing.Size(1244, 256);
            this.grpbCoilsInfo.TabIndex = 1;
            this.grpbCoilsInfo.TabStop = false;
            this.grpbCoilsInfo.Text = "Bobinas";
            // 
            // dgvCoilsDetail
            // 
            this.dgvCoilsDetail.AllowUserToAddRows = false;
            this.dgvCoilsDetail.AllowUserToDeleteRows = false;
            this.dgvCoilsDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilsDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilPosition,
            this.clmCoilCustomer,
            this.clmCoilSalesOrder,
            this.clmCoilSalesOrderDetailCodsec,
            this.clmCoilProductCodsec,
            this.clmCoilCuttingOrderDetailCodsec,
            this.clmCoilCode,
            this.clmCoilWidth,
            this.clmCoilLength,
            this.clmCoilDiameter,
            this.clmCoilCoreCodsec,
            this.clmCoilCore,
            this.clmCoilGrossWeight,
            this.clmCoilNetWeight,
            this.clmCoilDensity,
            this.clmCoilQualityCodsec,
            this.clmCoilQuality,
            this.clmCoilDefects,
            this.clmCoilDefectsValues,
            this.clmCoilCellarCodsec});
            this.dgvCoilsDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoilsDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvCoilsDetail.Name = "dgvCoilsDetail";
            this.dgvCoilsDetail.RowHeadersWidth = 15;
            this.dgvCoilsDetail.Size = new System.Drawing.Size(1238, 236);
            this.dgvCoilsDetail.TabIndex = 0;
            this.dgvCoilsDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvCoilsDetail_CellValidating);
            this.dgvCoilsDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCoilsDetail_KeyDown);
            // 
            // clmCoilCodsec
            // 
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilPosition
            // 
            this.clmCoilPosition.HeaderText = "Nº";
            this.clmCoilPosition.Name = "clmCoilPosition";
            this.clmCoilPosition.ReadOnly = true;
            this.clmCoilPosition.Width = 30;
            // 
            // clmCoilCustomer
            // 
            this.clmCoilCustomer.HeaderText = "Cliente";
            this.clmCoilCustomer.Name = "clmCoilCustomer";
            this.clmCoilCustomer.ReadOnly = true;
            this.clmCoilCustomer.Width = 200;
            // 
            // clmCoilSalesOrder
            // 
            this.clmCoilSalesOrder.HeaderText = "O. Venta";
            this.clmCoilSalesOrder.Name = "clmCoilSalesOrder";
            this.clmCoilSalesOrder.ReadOnly = true;
            this.clmCoilSalesOrder.Width = 80;
            // 
            // clmCoilSalesOrderDetailCodsec
            // 
            this.clmCoilSalesOrderDetailCodsec.HeaderText = "salesOrderCodsec";
            this.clmCoilSalesOrderDetailCodsec.Name = "clmCoilSalesOrderDetailCodsec";
            this.clmCoilSalesOrderDetailCodsec.ReadOnly = true;
            this.clmCoilSalesOrderDetailCodsec.Visible = false;
            // 
            // clmCoilProductCodsec
            // 
            this.clmCoilProductCodsec.HeaderText = "productCodsec";
            this.clmCoilProductCodsec.Name = "clmCoilProductCodsec";
            this.clmCoilProductCodsec.ReadOnly = true;
            this.clmCoilProductCodsec.Visible = false;
            // 
            // clmCoilCuttingOrderDetailCodsec
            // 
            this.clmCoilCuttingOrderDetailCodsec.HeaderText = "orderDetailCodsec";
            this.clmCoilCuttingOrderDetailCodsec.Name = "clmCoilCuttingOrderDetailCodsec";
            this.clmCoilCuttingOrderDetailCodsec.ReadOnly = true;
            this.clmCoilCuttingOrderDetailCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 110;
            // 
            // clmCoilWidth
            // 
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 70;
            // 
            // clmCoilLength
            // 
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 70;
            // 
            // clmCoilDiameter
            // 
            this.clmCoilDiameter.HeaderText = "Diametro";
            this.clmCoilDiameter.Name = "clmCoilDiameter";
            this.clmCoilDiameter.Width = 70;
            // 
            // clmCoilCoreCodsec
            // 
            this.clmCoilCoreCodsec.HeaderText = "coreCodsec";
            this.clmCoilCoreCodsec.Name = "clmCoilCoreCodsec";
            this.clmCoilCoreCodsec.Visible = false;
            // 
            // clmCoilCore
            // 
            this.clmCoilCore.HeaderText = "Core";
            this.clmCoilCore.Name = "clmCoilCore";
            this.clmCoilCore.ReadOnly = true;
            this.clmCoilCore.Width = 70;
            // 
            // clmCoilGrossWeight
            // 
            this.clmCoilGrossWeight.HeaderText = "Peso Bruto";
            this.clmCoilGrossWeight.Name = "clmCoilGrossWeight";
            this.clmCoilGrossWeight.Width = 70;
            // 
            // clmCoilNetWeight
            // 
            this.clmCoilNetWeight.HeaderText = "Peso Neto";
            this.clmCoilNetWeight.Name = "clmCoilNetWeight";
            this.clmCoilNetWeight.ReadOnly = true;
            this.clmCoilNetWeight.Width = 70;
            // 
            // clmCoilDensity
            // 
            this.clmCoilDensity.HeaderText = "Densidad";
            this.clmCoilDensity.Name = "clmCoilDensity";
            this.clmCoilDensity.ReadOnly = true;
            this.clmCoilDensity.Width = 70;
            // 
            // clmCoilQualityCodsec
            // 
            this.clmCoilQualityCodsec.HeaderText = "codsecCalidad";
            this.clmCoilQualityCodsec.Name = "clmCoilQualityCodsec";
            this.clmCoilQualityCodsec.ReadOnly = true;
            this.clmCoilQualityCodsec.Visible = false;
            // 
            // clmCoilQuality
            // 
            this.clmCoilQuality.HeaderText = "Calidad";
            this.clmCoilQuality.Name = "clmCoilQuality";
            this.clmCoilQuality.ReadOnly = true;
            // 
            // clmCoilDefects
            // 
            this.clmCoilDefects.HeaderText = "Defectos";
            this.clmCoilDefects.Name = "clmCoilDefects";
            this.clmCoilDefects.ReadOnly = true;
            this.clmCoilDefects.Width = 170;
            // 
            // clmCoilDefectsValues
            // 
            this.clmCoilDefectsValues.HeaderText = "DefectsValues";
            this.clmCoilDefectsValues.Name = "clmCoilDefectsValues";
            this.clmCoilDefectsValues.ReadOnly = true;
            this.clmCoilDefectsValues.Visible = false;
            // 
            // clmCoilCellarCodsec
            // 
            this.clmCoilCellarCodsec.HeaderText = "cellarCodsec";
            this.clmCoilCellarCodsec.Name = "clmCoilCellarCodsec";
            this.clmCoilCellarCodsec.ReadOnly = true;
            this.clmCoilCellarCodsec.Visible = false;
            // 
            // grpbMainCoil
            // 
            this.grpbMainCoil.Controls.Add(this.dgvMainCoilList);
            this.grpbMainCoil.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbMainCoil.Location = new System.Drawing.Point(0, 317);
            this.grpbMainCoil.Name = "grpbMainCoil";
            this.grpbMainCoil.Size = new System.Drawing.Size(1244, 104);
            this.grpbMainCoil.TabIndex = 17;
            this.grpbMainCoil.TabStop = false;
            this.grpbMainCoil.Text = "Rollos madre";
            // 
            // dgvMainCoilList
            // 
            this.dgvMainCoilList.AllowUserToAddRows = false;
            this.dgvMainCoilList.AllowUserToDeleteRows = false;
            this.dgvMainCoilList.AllowUserToOrderColumns = true;
            this.dgvMainCoilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainCoilList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMainCoilListCodsec,
            this.clmMainCoilListFilm,
            this.clmMainCoilListCode,
            this.clmMainCoilListBatch,
            this.clmMainCoilUsedLenth});
            this.dgvMainCoilList.Location = new System.Drawing.Point(259, 10);
            this.dgvMainCoilList.Name = "dgvMainCoilList";
            this.dgvMainCoilList.ReadOnly = true;
            this.dgvMainCoilList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMainCoilList.Size = new System.Drawing.Size(722, 90);
            this.dgvMainCoilList.TabIndex = 14;
            // 
            // clmMainCoilListCodsec
            // 
            this.clmMainCoilListCodsec.HeaderText = "Codsec";
            this.clmMainCoilListCodsec.Name = "clmMainCoilListCodsec";
            this.clmMainCoilListCodsec.ReadOnly = true;
            this.clmMainCoilListCodsec.Visible = false;
            this.clmMainCoilListCodsec.Width = 200;
            // 
            // clmMainCoilListFilm
            // 
            this.clmMainCoilListFilm.HeaderText = "Película";
            this.clmMainCoilListFilm.Name = "clmMainCoilListFilm";
            this.clmMainCoilListFilm.ReadOnly = true;
            this.clmMainCoilListFilm.Width = 300;
            // 
            // clmMainCoilListCode
            // 
            this.clmMainCoilListCode.HeaderText = "Código";
            this.clmMainCoilListCode.Name = "clmMainCoilListCode";
            this.clmMainCoilListCode.ReadOnly = true;
            this.clmMainCoilListCode.Width = 150;
            // 
            // clmMainCoilListBatch
            // 
            this.clmMainCoilListBatch.HeaderText = "Lote";
            this.clmMainCoilListBatch.Name = "clmMainCoilListBatch";
            this.clmMainCoilListBatch.ReadOnly = true;
            // 
            // clmMainCoilUsedLenth
            // 
            this.clmMainCoilUsedLenth.HeaderText = "Metraje";
            this.clmMainCoilUsedLenth.Name = "clmMainCoilUsedLenth";
            this.clmMainCoilUsedLenth.ReadOnly = true;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 419);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1152, 44);
            this.grpbEmpty.TabIndex = 18;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilExit);
            this.grpbMainCoilButtons.Controls.Add(this.btnCoilSave);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(1156, 419);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(84, 44);
            this.grpbMainCoilButtons.TabIndex = 19;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(55, 14);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 2;
            this.ttpCuttingStopregistration.SetToolTip(this.btnMainCoilExit, "Salir Bobinas por Parada");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // btnCoilSave
            // 
            this.btnCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoilSave.BackgroundImage")));
            this.btnCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCoilSave.Location = new System.Drawing.Point(5, 14);
            this.btnCoilSave.Name = "btnCoilSave";
            this.btnCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnCoilSave.TabIndex = 0;
            this.ttpCuttingStopregistration.SetToolTip(this.btnCoilSave, "Guardar Bobinas por Parada");
            this.btnCoilSave.UseVisualStyleBackColor = true;
            this.btnCoilSave.Click += new System.EventHandler(this.btnCoilSave_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(30, 14);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 1;
            this.ttpCuttingStopregistration.SetToolTip(this.btnMainCoilCancel, "Cancelar Bobinas por Parada");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            // 
            // frmCuttingStopRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 465);
            this.Controls.Add(this.grpbMainCoil);
            this.Controls.Add(this.grpbCoilsInfo);
            this.Controls.Add(this.grpbCuttingOrderData);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCuttingStopRegistration";
            this.ShowInTaskbar = false;
            this.Text = "Registro de bobinas por parada";
            this.Load += new System.EventHandler(this.frmCuttingStopRegistration_Load);
            this.grpbCuttingOrderData.ResumeLayout(false);
            this.grpbCuttingOrderData.PerformLayout();
            this.grpbCoilsInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsDetail)).EndInit();
            this.grpbMainCoil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainCoilList)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCuttingOrderData;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblStops;
        private System.Windows.Forms.Label lblCutterNameLabel;
        private System.Windows.Forms.Label lblFulmNameLabel;
        private System.Windows.Forms.Label lblCutterName;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblCuttingOrderNumber;
        private System.Windows.Forms.Label lblCuttingOrderNumberLabel;
        private System.Windows.Forms.GroupBox grpbCoilsInfo;
        private System.Windows.Forms.DataGridView dgvCoilsDetail;
        private System.Windows.Forms.GroupBox grpbMainCoil;
        private System.Windows.Forms.DataGridView dgvMainCoilList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilListBatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilUsedLenth;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.Button btnCoilSave;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilSalesOrderDetailCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCuttingOrderDetailCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCoreCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilQualityCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDefects;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDefectsValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCellarCodsec;
        private System.Windows.Forms.ToolTip ttpCuttingStopregistration;
    }
}