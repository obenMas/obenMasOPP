namespace BPS
{
    partial class frmCoilReportBySalesOrderShort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilReportBySalesOrderShort));
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.tbpCoilList = new System.Windows.Forms.TabPage();
            this.grpbSalesOrderDetail = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCoilEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCoilQuality = new System.Windows.Forms.DataGridViewImageColumn();
            this.trvSalesOrderDetail = new System.Windows.Forms.TreeView();
            this.grpbSalesOrder = new System.Windows.Forms.GroupBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblSalesOrderStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.tbcCoilListBySalesOrder = new System.Windows.Forms.TabControl();
            this.lblCuttedCoilsLabel = new System.Windows.Forms.Label();
            this.lblTotalCoilsLabel = new System.Windows.Forms.Label();
            this.lblCoils = new System.Windows.Forms.Label();
            this.lblCuttedWeightLabel = new System.Windows.Forms.Label();
            this.lblTotalWeightLabel = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblTotalCoils = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblMissingCoilsLabel = new System.Windows.Forms.Label();
            this.lblObservationCoilsLabel = new System.Windows.Forms.Label();
            this.lblUncuttedWeightLabel = new System.Windows.Forms.Label();
            this.lblObservationWeightLabel = new System.Windows.Forms.Label();
            this.lblCuttedCoils = new System.Windows.Forms.Label();
            this.lblCuttedWeight = new System.Windows.Forms.Label();
            this.lblMissingCoils = new System.Windows.Forms.Label();
            this.lblObservationCoils = new System.Windows.Forms.Label();
            this.lblUncuttedWeight = new System.Windows.Forms.Label();
            this.lblObservationWeight = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPalletsLabel = new System.Windows.Forms.Label();
            this.lblPallets = new System.Windows.Forms.Label();
            this.grpbView = new System.Windows.Forms.GroupBox();
            this.rdoOnlyFirst = new System.Windows.Forms.RadioButton();
            this.rdoOnlyObservation = new System.Windows.Forms.RadioButton();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgross = new System.Windows.Forms.Label();
            this.grpbSalesOrderDetailInfo = new System.Windows.Forms.GroupBox();
            this.tbpCoilList.SuspendLayout();
            this.grpbSalesOrderDetail.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbSalesOrder.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbcCoilListBySalesOrder.SuspendLayout();
            this.grpbView.SuspendLayout();
            this.grpbSalesOrderDetailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "world.png");
            this.imgLstIcons.Images.SetKeyName(1, "blog.png");
            this.imgLstIcons.Images.SetKeyName(2, "application_view_detail.png");
            this.imgLstIcons.Images.SetKeyName(3, "package.png");
            // 
            // tbpCoilList
            // 
            this.tbpCoilList.Controls.Add(this.grpbSalesOrderDetail);
            this.tbpCoilList.Controls.Add(this.grpbSalesOrder);
            this.tbpCoilList.Controls.Add(this.groupBox1);
            this.tbpCoilList.Controls.Add(this.groupBox2);
            this.tbpCoilList.Location = new System.Drawing.Point(4, 24);
            this.tbpCoilList.Name = "tbpCoilList";
            this.tbpCoilList.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoilList.Size = new System.Drawing.Size(1208, 536);
            this.tbpCoilList.TabIndex = 2;
            this.tbpCoilList.Text = "Listado de bobinas";
            this.tbpCoilList.UseVisualStyleBackColor = true;
            // 
            // grpbSalesOrderDetail
            // 
            this.grpbSalesOrderDetail.Controls.Add(this.groupBox3);
            this.grpbSalesOrderDetail.Controls.Add(this.trvSalesOrderDetail);
            this.grpbSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrderDetail.Location = new System.Drawing.Point(3, 64);
            this.grpbSalesOrderDetail.Name = "grpbSalesOrderDetail";
            this.grpbSalesOrderDetail.Size = new System.Drawing.Size(1202, 433);
            this.grpbSalesOrderDetail.TabIndex = 3;
            this.grpbSalesOrderDetail.TabStop = false;
            this.grpbSalesOrderDetail.Text = "Detalle de orden";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCoils);
            this.groupBox3.Controls.Add(this.grpbSalesOrderDetailInfo);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(239, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(960, 413);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.AllowUserToDeleteRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmCoilProduct,
            this.clmCoilLength,
            this.clmCoilwidth,
            this.clmCoilDiameter,
            this.clmCoilNetWeight,
            this.clmCoilGrossWeight,
            this.clmCoilCellar,
            this.clmCoilPrint,
            this.clmCoilEdit,
            this.clmCoilQuality});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 131);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(954, 279);
            this.dgvCoils.TabIndex = 0;
            this.dgvCoils.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoils_CellClick);
            // 
            // clmCoilCodsec
            // 
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 140;
            // 
            // clmCoilProduct
            // 
            this.clmCoilProduct.HeaderText = "Producto";
            this.clmCoilProduct.Name = "clmCoilProduct";
            this.clmCoilProduct.ReadOnly = true;
            this.clmCoilProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilProduct.Width = 140;
            // 
            // clmCoilLength
            // 
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilLength.Width = 85;
            // 
            // clmCoilwidth
            // 
            this.clmCoilwidth.HeaderText = "Ancho";
            this.clmCoilwidth.Name = "clmCoilwidth";
            this.clmCoilwidth.ReadOnly = true;
            this.clmCoilwidth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilwidth.Width = 85;
            // 
            // clmCoilDiameter
            // 
            this.clmCoilDiameter.HeaderText = "Diametro";
            this.clmCoilDiameter.Name = "clmCoilDiameter";
            this.clmCoilDiameter.ReadOnly = true;
            this.clmCoilDiameter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilDiameter.Width = 85;
            // 
            // clmCoilNetWeight
            // 
            this.clmCoilNetWeight.HeaderText = "P. Neto";
            this.clmCoilNetWeight.Name = "clmCoilNetWeight";
            this.clmCoilNetWeight.ReadOnly = true;
            this.clmCoilNetWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilNetWeight.Width = 85;
            // 
            // clmCoilGrossWeight
            // 
            this.clmCoilGrossWeight.HeaderText = "P. Bruto";
            this.clmCoilGrossWeight.Name = "clmCoilGrossWeight";
            this.clmCoilGrossWeight.ReadOnly = true;
            this.clmCoilGrossWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilGrossWeight.Width = 85;
            // 
            // clmCoilCellar
            // 
            this.clmCoilCellar.HeaderText = "Bodega";
            this.clmCoilCellar.Name = "clmCoilCellar";
            this.clmCoilCellar.ReadOnly = true;
            this.clmCoilCellar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmCoilCellar.Width = 85;
            // 
            // clmCoilPrint
            // 
            this.clmCoilPrint.HeaderText = "";
            this.clmCoilPrint.Name = "clmCoilPrint";
            this.clmCoilPrint.ReadOnly = true;
            this.clmCoilPrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCoilPrint.Width = 30;
            // 
            // clmCoilEdit
            // 
            this.clmCoilEdit.HeaderText = "";
            this.clmCoilEdit.Name = "clmCoilEdit";
            this.clmCoilEdit.ReadOnly = true;
            this.clmCoilEdit.Width = 30;
            // 
            // clmCoilQuality
            // 
            this.clmCoilQuality.HeaderText = "";
            this.clmCoilQuality.Name = "clmCoilQuality";
            this.clmCoilQuality.ReadOnly = true;
            this.clmCoilQuality.Width = 30;
            // 
            // trvSalesOrderDetail
            // 
            this.trvSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvSalesOrderDetail.ImageIndex = 0;
            this.trvSalesOrderDetail.ImageList = this.imgLstIcons;
            this.trvSalesOrderDetail.Location = new System.Drawing.Point(3, 17);
            this.trvSalesOrderDetail.Name = "trvSalesOrderDetail";
            this.trvSalesOrderDetail.SelectedImageIndex = 0;
            this.trvSalesOrderDetail.Size = new System.Drawing.Size(236, 413);
            this.trvSalesOrderDetail.TabIndex = 0;
            this.trvSalesOrderDetail.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvSalesOrderDetail_AfterSelect);
            // 
            // grpbSalesOrder
            // 
            this.grpbSalesOrder.Controls.Add(this.btnComplete);
            this.grpbSalesOrder.Controls.Add(this.txtNumber);
            this.grpbSalesOrder.Controls.Add(this.lblCustomerName);
            this.grpbSalesOrder.Controls.Add(this.lblCustomerNameLabel);
            this.grpbSalesOrder.Controls.Add(this.lblSalesOrderStatus);
            this.grpbSalesOrder.Controls.Add(this.lblDate);
            this.grpbSalesOrder.Controls.Add(this.lblDateLabel);
            this.grpbSalesOrder.Controls.Add(this.lblStatusLabel);
            this.grpbSalesOrder.Controls.Add(this.lblNumberLabel);
            this.grpbSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrder.Location = new System.Drawing.Point(3, 3);
            this.grpbSalesOrder.Name = "grpbSalesOrder";
            this.grpbSalesOrder.Size = new System.Drawing.Size(1202, 61);
            this.grpbSalesOrder.TabIndex = 2;
            this.grpbSalesOrder.TabStop = false;
            this.grpbSalesOrder.Text = "Orden de Venta";
            // 
            // btnComplete
            // 
            this.btnComplete.Image = global::BPS.Properties.Resources.task_completed;
            this.btnComplete.Location = new System.Drawing.Point(1131, 14);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(40, 40);
            this.btnComplete.TabIndex = 9;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(129, 24);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(146, 21);
            this.txtNumber.TabIndex = 8;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(341, 24);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(355, 21);
            this.lblCustomerName.TabIndex = 7;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(281, 27);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerNameLabel.TabIndex = 3;
            this.lblCustomerNameLabel.Text = "Cliente";
            // 
            // lblSalesOrderStatus
            // 
            this.lblSalesOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesOrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderStatus.Location = new System.Drawing.Point(969, 24);
            this.lblSalesOrderStatus.Name = "lblSalesOrderStatus";
            this.lblSalesOrderStatus.Size = new System.Drawing.Size(121, 21);
            this.lblSalesOrderStatus.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(753, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(155, 21);
            this.lblDate.TabIndex = 7;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(704, 27);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDateLabel.TabIndex = 6;
            this.lblDateLabel.Text = "Fecha";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(916, 27);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(45, 15);
            this.lblStatusLabel.TabIndex = 2;
            this.lblStatusLabel.Text = "Estado";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(71, 27);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.lblNumberLabel.TabIndex = 0;
            this.lblNumberLabel.Text = "Número";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(2, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Location = new System.Drawing.Point(1144, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(61, 43);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(31, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(6, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // tbcCoilListBySalesOrder
            // 
            this.tbcCoilListBySalesOrder.Controls.Add(this.tbpCoilList);
            this.tbcCoilListBySalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcCoilListBySalesOrder.Location = new System.Drawing.Point(0, 0);
            this.tbcCoilListBySalesOrder.Name = "tbcCoilListBySalesOrder";
            this.tbcCoilListBySalesOrder.SelectedIndex = 0;
            this.tbcCoilListBySalesOrder.Size = new System.Drawing.Size(1216, 564);
            this.tbcCoilListBySalesOrder.TabIndex = 0;
            // 
            // lblCuttedCoilsLabel
            // 
            this.lblCuttedCoilsLabel.AutoSize = true;
            this.lblCuttedCoilsLabel.Location = new System.Drawing.Point(203, 51);
            this.lblCuttedCoilsLabel.Name = "lblCuttedCoilsLabel";
            this.lblCuttedCoilsLabel.Size = new System.Drawing.Size(51, 15);
            this.lblCuttedCoilsLabel.TabIndex = 10;
            this.lblCuttedCoilsLabel.Text = "Primera";
            // 
            // lblTotalCoilsLabel
            // 
            this.lblTotalCoilsLabel.AutoSize = true;
            this.lblTotalCoilsLabel.Location = new System.Drawing.Point(76, 51);
            this.lblTotalCoilsLabel.Name = "lblTotalCoilsLabel";
            this.lblTotalCoilsLabel.Size = new System.Drawing.Size(34, 15);
            this.lblTotalCoilsLabel.TabIndex = 10;
            this.lblTotalCoilsLabel.Text = "Total";
            // 
            // lblCoils
            // 
            this.lblCoils.AutoSize = true;
            this.lblCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoils.Location = new System.Drawing.Point(6, 50);
            this.lblCoils.Name = "lblCoils";
            this.lblCoils.Size = new System.Drawing.Size(66, 17);
            this.lblCoils.TabIndex = 10;
            this.lblCoils.Text = "Bobinas";
            // 
            // lblCuttedWeightLabel
            // 
            this.lblCuttedWeightLabel.AutoSize = true;
            this.lblCuttedWeightLabel.Location = new System.Drawing.Point(203, 84);
            this.lblCuttedWeightLabel.Name = "lblCuttedWeightLabel";
            this.lblCuttedWeightLabel.Size = new System.Drawing.Size(51, 15);
            this.lblCuttedWeightLabel.TabIndex = 10;
            this.lblCuttedWeightLabel.Text = "Primera";
            // 
            // lblTotalWeightLabel
            // 
            this.lblTotalWeightLabel.AutoSize = true;
            this.lblTotalWeightLabel.Location = new System.Drawing.Point(76, 84);
            this.lblTotalWeightLabel.Name = "lblTotalWeightLabel";
            this.lblTotalWeightLabel.Size = new System.Drawing.Size(34, 15);
            this.lblTotalWeightLabel.TabIndex = 10;
            this.lblTotalWeightLabel.Text = "Total";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(6, 83);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(44, 17);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "Peso";
            // 
            // lblTotalCoils
            // 
            this.lblTotalCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCoils.Location = new System.Drawing.Point(116, 46);
            this.lblTotalCoils.Name = "lblTotalCoils";
            this.lblTotalCoils.Size = new System.Drawing.Size(81, 24);
            this.lblTotalCoils.TabIndex = 11;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(116, 79);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(81, 24);
            this.lblTotalWeight.TabIndex = 11;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(89, 20);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(56, 15);
            this.lblProductName.TabIndex = 8;
            this.lblProductName.Text = "Producto";
            // 
            // lblMissingCoilsLabel
            // 
            this.lblMissingCoilsLabel.AutoSize = true;
            this.lblMissingCoilsLabel.Location = new System.Drawing.Point(514, 51);
            this.lblMissingCoilsLabel.Name = "lblMissingCoilsLabel";
            this.lblMissingCoilsLabel.Size = new System.Drawing.Size(51, 15);
            this.lblMissingCoilsLabel.TabIndex = 10;
            this.lblMissingCoilsLabel.Text = "Faltante";
            // 
            // lblObservationCoilsLabel
            // 
            this.lblObservationCoilsLabel.AutoSize = true;
            this.lblObservationCoilsLabel.Location = new System.Drawing.Point(346, 51);
            this.lblObservationCoilsLabel.Name = "lblObservationCoilsLabel";
            this.lblObservationCoilsLabel.Size = new System.Drawing.Size(75, 15);
            this.lblObservationCoilsLabel.TabIndex = 10;
            this.lblObservationCoilsLabel.Text = "Observación";
            // 
            // lblUncuttedWeightLabel
            // 
            this.lblUncuttedWeightLabel.AutoSize = true;
            this.lblUncuttedWeightLabel.Location = new System.Drawing.Point(514, 84);
            this.lblUncuttedWeightLabel.Name = "lblUncuttedWeightLabel";
            this.lblUncuttedWeightLabel.Size = new System.Drawing.Size(51, 15);
            this.lblUncuttedWeightLabel.TabIndex = 10;
            this.lblUncuttedWeightLabel.Text = "Faltante";
            // 
            // lblObservationWeightLabel
            // 
            this.lblObservationWeightLabel.AutoSize = true;
            this.lblObservationWeightLabel.Location = new System.Drawing.Point(346, 84);
            this.lblObservationWeightLabel.Name = "lblObservationWeightLabel";
            this.lblObservationWeightLabel.Size = new System.Drawing.Size(75, 15);
            this.lblObservationWeightLabel.TabIndex = 10;
            this.lblObservationWeightLabel.Text = "Observación";
            // 
            // lblCuttedCoils
            // 
            this.lblCuttedCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuttedCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuttedCoils.Location = new System.Drawing.Point(259, 46);
            this.lblCuttedCoils.Name = "lblCuttedCoils";
            this.lblCuttedCoils.Size = new System.Drawing.Size(81, 24);
            this.lblCuttedCoils.TabIndex = 11;
            // 
            // lblCuttedWeight
            // 
            this.lblCuttedWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCuttedWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuttedWeight.Location = new System.Drawing.Point(259, 79);
            this.lblCuttedWeight.Name = "lblCuttedWeight";
            this.lblCuttedWeight.Size = new System.Drawing.Size(81, 24);
            this.lblCuttedWeight.TabIndex = 11;
            // 
            // lblMissingCoils
            // 
            this.lblMissingCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMissingCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingCoils.Location = new System.Drawing.Point(577, 46);
            this.lblMissingCoils.Name = "lblMissingCoils";
            this.lblMissingCoils.Size = new System.Drawing.Size(81, 24);
            this.lblMissingCoils.TabIndex = 11;
            // 
            // lblObservationCoils
            // 
            this.lblObservationCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblObservationCoils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservationCoils.Location = new System.Drawing.Point(427, 46);
            this.lblObservationCoils.Name = "lblObservationCoils";
            this.lblObservationCoils.Size = new System.Drawing.Size(81, 24);
            this.lblObservationCoils.TabIndex = 11;
            // 
            // lblUncuttedWeight
            // 
            this.lblUncuttedWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUncuttedWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUncuttedWeight.Location = new System.Drawing.Point(577, 79);
            this.lblUncuttedWeight.Name = "lblUncuttedWeight";
            this.lblUncuttedWeight.Size = new System.Drawing.Size(81, 24);
            this.lblUncuttedWeight.TabIndex = 11;
            // 
            // lblObservationWeight
            // 
            this.lblObservationWeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblObservationWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservationWeight.Location = new System.Drawing.Point(427, 79);
            this.lblObservationWeight.Name = "lblObservationWeight";
            this.lblObservationWeight.Size = new System.Drawing.Size(81, 24);
            this.lblObservationWeight.TabIndex = 11;
            // 
            // lblProduct
            // 
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(197, 17);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(440, 21);
            this.lblProduct.TabIndex = 9;
            // 
            // lblPalletsLabel
            // 
            this.lblPalletsLabel.AutoSize = true;
            this.lblPalletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletsLabel.Location = new System.Drawing.Point(664, 51);
            this.lblPalletsLabel.Name = "lblPalletsLabel";
            this.lblPalletsLabel.Size = new System.Drawing.Size(51, 15);
            this.lblPalletsLabel.TabIndex = 12;
            this.lblPalletsLabel.Text = "Pallets";
            // 
            // lblPallets
            // 
            this.lblPallets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallets.Location = new System.Drawing.Point(727, 46);
            this.lblPallets.Name = "lblPallets";
            this.lblPallets.Size = new System.Drawing.Size(81, 24);
            this.lblPallets.TabIndex = 13;
            // 
            // grpbView
            // 
            this.grpbView.Controls.Add(this.rdoAll);
            this.grpbView.Controls.Add(this.rdoOnlyObservation);
            this.grpbView.Controls.Add(this.rdoOnlyFirst);
            this.grpbView.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbView.Location = new System.Drawing.Point(814, 17);
            this.grpbView.Name = "grpbView";
            this.grpbView.Size = new System.Drawing.Size(137, 94);
            this.grpbView.TabIndex = 14;
            this.grpbView.TabStop = false;
            this.grpbView.Text = "Vistas";
            // 
            // rdoOnlyFirst
            // 
            this.rdoOnlyFirst.AutoSize = true;
            this.rdoOnlyFirst.Checked = true;
            this.rdoOnlyFirst.Location = new System.Drawing.Point(6, 20);
            this.rdoOnlyFirst.Name = "rdoOnlyFirst";
            this.rdoOnlyFirst.Size = new System.Drawing.Size(96, 19);
            this.rdoOnlyFirst.TabIndex = 15;
            this.rdoOnlyFirst.TabStop = true;
            this.rdoOnlyFirst.Text = "Solo primera";
            this.rdoOnlyFirst.UseVisualStyleBackColor = true;
            this.rdoOnlyFirst.CheckedChanged += new System.EventHandler(this.rdoOnlyFirst_CheckedChanged);
            // 
            // rdoOnlyObservation
            // 
            this.rdoOnlyObservation.AutoSize = true;
            this.rdoOnlyObservation.Location = new System.Drawing.Point(6, 42);
            this.rdoOnlyObservation.Name = "rdoOnlyObservation";
            this.rdoOnlyObservation.Size = new System.Drawing.Size(121, 19);
            this.rdoOnlyObservation.TabIndex = 15;
            this.rdoOnlyObservation.Text = "Solo Observación";
            this.rdoOnlyObservation.UseVisualStyleBackColor = true;
            this.rdoOnlyObservation.CheckedChanged += new System.EventHandler(this.rdoOnlyObservation_CheckedChanged);
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(6, 64);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(76, 19);
            this.rdoAll.TabIndex = 15;
            this.rdoAll.Text = "Ver todas";
            this.rdoAll.UseVisualStyleBackColor = true;
            this.rdoAll.CheckedChanged += new System.EventHandler(this.rdoAll_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(664, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "P. Bruto";
            // 
            // lblgross
            // 
            this.lblgross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgross.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgross.Location = new System.Drawing.Point(727, 78);
            this.lblgross.Name = "lblgross";
            this.lblgross.Size = new System.Drawing.Size(81, 24);
            this.lblgross.TabIndex = 16;
            // 
            // grpbSalesOrderDetailInfo
            // 
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblgross);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.label2);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.grpbView);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblPallets);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblPalletsLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblProduct);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblObservationWeight);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblUncuttedWeight);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblObservationCoils);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblMissingCoils);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblCuttedWeight);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblCuttedCoils);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblObservationWeightLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblUncuttedWeightLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblObservationCoilsLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblMissingCoilsLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblProductName);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblTotalWeight);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblTotalCoils);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblWeight);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblTotalWeightLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblCuttedWeightLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblCoils);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblTotalCoilsLabel);
            this.grpbSalesOrderDetailInfo.Controls.Add(this.lblCuttedCoilsLabel);
            this.grpbSalesOrderDetailInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrderDetailInfo.Location = new System.Drawing.Point(3, 17);
            this.grpbSalesOrderDetailInfo.Name = "grpbSalesOrderDetailInfo";
            this.grpbSalesOrderDetailInfo.Size = new System.Drawing.Size(954, 114);
            this.grpbSalesOrderDetailInfo.TabIndex = 12;
            this.grpbSalesOrderDetailInfo.TabStop = false;
            this.grpbSalesOrderDetailInfo.Enter += new System.EventHandler(this.grpbSalesOrderDetailInfo_Enter);
            // 
            // frmCoilReportBySalesOrderShort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1216, 564);
            this.Controls.Add(this.tbcCoilListBySalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilReportBySalesOrderShort";
            this.Tag = "";
            this.Text = "Bobinas terminadas por orden de venta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCoilReportBySalesOrder_FormClosed);
            this.Load += new System.EventHandler(this.frmCoilReportBySalesOrder_Load);
            this.tbpCoilList.ResumeLayout(false);
            this.grpbSalesOrderDetail.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbSalesOrder.ResumeLayout(false);
            this.grpbSalesOrder.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tbcCoilListBySalesOrder.ResumeLayout(false);
            this.grpbView.ResumeLayout(false);
            this.grpbView.PerformLayout();
            this.grpbSalesOrderDetailInfo.ResumeLayout(false);
            this.grpbSalesOrderDetailInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.TabPage tbpCoilList;
        private System.Windows.Forms.GroupBox grpbSalesOrderDetail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCellar;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilPrint;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilEdit;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilQuality;
        private System.Windows.Forms.TreeView trvSalesOrderDetail;
        private System.Windows.Forms.GroupBox grpbSalesOrder;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblSalesOrderStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.TabControl tbcCoilListBySalesOrder;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.GroupBox grpbSalesOrderDetailInfo;
        private System.Windows.Forms.Label lblgross;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbView;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoOnlyObservation;
        private System.Windows.Forms.RadioButton rdoOnlyFirst;
        private System.Windows.Forms.Label lblPallets;
        private System.Windows.Forms.Label lblPalletsLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblObservationWeight;
        private System.Windows.Forms.Label lblUncuttedWeight;
        private System.Windows.Forms.Label lblObservationCoils;
        private System.Windows.Forms.Label lblMissingCoils;
        private System.Windows.Forms.Label lblCuttedWeight;
        private System.Windows.Forms.Label lblCuttedCoils;
        private System.Windows.Forms.Label lblObservationWeightLabel;
        private System.Windows.Forms.Label lblUncuttedWeightLabel;
        private System.Windows.Forms.Label lblObservationCoilsLabel;
        private System.Windows.Forms.Label lblMissingCoilsLabel;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblTotalCoils;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblTotalWeightLabel;
        private System.Windows.Forms.Label lblCuttedWeightLabel;
        private System.Windows.Forms.Label lblCoils;
        private System.Windows.Forms.Label lblTotalCoilsLabel;
        private System.Windows.Forms.Label lblCuttedCoilsLabel;
    }
}