namespace BPS
{
    partial class frmPackingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackingList));
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.grpbSalesOrderDetail = new System.Windows.Forms.GroupBox();
            this.trvDestinations = new System.Windows.Forms.TreeView();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.LblDimentions = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblDestinationLabel = new System.Windows.Forms.Label();
            this.lblDimentionsLabel = new System.Windows.Forms.Label();
            this.txtGrossWeigth = new System.Windows.Forms.TextBox();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.cmsPalletMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpPalletsRegistration = new System.Windows.Forms.ToolTip(this.components);
            this.tbcPackingList = new System.Windows.Forms.TabControl();
            this.tbpDetails = new System.Windows.Forms.TabPage();
            this.tbpList = new System.Windows.Forms.TabPage();
            this.grpbPackingList = new System.Windows.Forms.GroupBox();
            this.tbcReports = new System.Windows.Forms.TabControl();
            this.tbpUnifiedPackingList = new System.Windows.Forms.TabPage();
            this.crvUnifiedPackingList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tbpDetailedPackingList = new System.Windows.Forms.TabPage();
            this.crvDetailedPackingList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.grpbTransport = new System.Windows.Forms.GroupBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.tbpHead = new System.Windows.Forms.TabPage();
            this.grpbDetails = new System.Windows.Forms.GroupBox();
            this.txtverify = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCubicMeters = new System.Windows.Forms.TextBox();
            this.lblCubicMeters = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTransportData = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grpbPallets.SuspendLayout();
            this.grpbSalesOrderDetail.SuspendLayout();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpbPaletInfo.SuspendLayout();
            this.cmsPalletMenu.SuspendLayout();
            this.tbcPackingList.SuspendLayout();
            this.tbpDetails.SuspendLayout();
            this.tbpList.SuspendLayout();
            this.grpbPackingList.SuspendLayout();
            this.tbcReports.SuspendLayout();
            this.tbpUnifiedPackingList.SuspendLayout();
            this.tbpDetailedPackingList.SuspendLayout();
            this.grpbTransport.SuspendLayout();
            this.tbpHead.SuspendLayout();
            this.grpbDetails.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.grpbSalesOrderDetail);
            this.grpbPallets.Controls.Add(this.grpbPalletsRegister);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPallets.Location = new System.Drawing.Point(3, 3);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(1083, 597);
            this.grpbPallets.TabIndex = 5;
            this.grpbPallets.TabStop = false;
            // 
            // grpbSalesOrderDetail
            // 
            this.grpbSalesOrderDetail.Controls.Add(this.trvDestinations);
            this.grpbSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbSalesOrderDetail.Location = new System.Drawing.Point(3, 17);
            this.grpbSalesOrderDetail.Name = "grpbSalesOrderDetail";
            this.grpbSalesOrderDetail.Size = new System.Drawing.Size(492, 577);
            this.grpbSalesOrderDetail.TabIndex = 0;
            this.grpbSalesOrderDetail.TabStop = false;
            this.grpbSalesOrderDetail.Text = "Destinatarios";
            // 
            // trvDestinations
            // 
            this.trvDestinations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDestinations.ImageIndex = 0;
            this.trvDestinations.ImageList = this.imgLstIcons;
            this.trvDestinations.Location = new System.Drawing.Point(3, 17);
            this.trvDestinations.Name = "trvDestinations";
            this.trvDestinations.SelectedImageIndex = 0;
            this.trvDestinations.Size = new System.Drawing.Size(486, 557);
            this.trvDestinations.TabIndex = 0;
            this.trvDestinations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDestinations_AfterSelect);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "cut.png");
            this.imgLstIcons.Images.SetKeyName(1, "blog.png");
            this.imgLstIcons.Images.SetKeyName(2, "world.png");
            this.imgLstIcons.Images.SetKeyName(3, "application_view_detail.png");
            this.imgLstIcons.Images.SetKeyName(4, "pallet.png");
            this.imgLstIcons.Images.SetKeyName(5, "arrow_right_orange.png");
            this.imgLstIcons.Images.SetKeyName(6, "accept.png");
            this.imgLstIcons.Images.SetKeyName(7, "block.png");
            this.imgLstIcons.Images.SetKeyName(8, "arrow_right_gray.png");
            this.imgLstIcons.Images.SetKeyName(9, "book_open.png");
            this.imgLstIcons.Images.SetKeyName(10, "pallet_add.png");
            this.imgLstIcons.Images.SetKeyName(11, "delivery.png");
            // 
            // grpbPalletsRegister
            // 
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Controls.Add(this.lblStatusColor);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(495, 17);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(585, 577);
            this.grpbPalletsRegister.TabIndex = 1;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.groupBox1);
            this.grpbCoils.Controls.Add(this.groupBox2);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoils.Location = new System.Drawing.Point(8, 177);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(574, 397);
            this.grpbCoils.TabIndex = 111;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCoils);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 340);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmCoilLength,
            this.clmCoilWidth,
            this.clmCoilWeigth});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowHeadersWidth = 21;
            this.dgvCoils.Size = new System.Drawing.Size(562, 320);
            this.dgvCoils.TabIndex = 0;
            // 
            // clmCoilCodsec
            // 
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 200;
            // 
            // clmCoilLength
            // 
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            // 
            // clmCoilWidth
            // 
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            // 
            // clmCoilWeigth
            // 
            this.clmCoilWeigth.HeaderText = "Peso";
            this.clmCoilWeigth.Name = "clmCoilWeigth";
            this.clmCoilWeigth.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCoilCount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 37);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(3, 12);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(562, 18);
            this.lblCoilCount.TabIndex = 108;
            this.lblCoilCount.Text = "Bobinas : -- / --";
            this.lblCoilCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.lblDestination);
            this.grpbPaletInfo.Controls.Add(this.lblPalletType);
            this.grpbPaletInfo.Controls.Add(this.LblDimentions);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblCode);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDestinationLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDimentionsLabel);
            this.grpbPaletInfo.Controls.Add(this.txtGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblCodeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPaletInfo.Location = new System.Drawing.Point(8, 17);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(574, 160);
            this.grpbPaletInfo.TabIndex = 110;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Información de pallet";
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(136, 16);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(390, 21);
            this.lblDestination.TabIndex = 45;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalletType
            // 
            this.lblPalletType.BackColor = System.Drawing.SystemColors.Window;
            this.lblPalletType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPalletType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletType.Location = new System.Drawing.Point(136, 45);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(390, 21);
            this.lblPalletType.TabIndex = 45;
            this.lblPalletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDimentions
            // 
            this.LblDimentions.BackColor = System.Drawing.SystemColors.Window;
            this.LblDimentions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDimentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDimentions.Location = new System.Drawing.Point(136, 74);
            this.LblDimentions.Name = "LblDimentions";
            this.LblDimentions.Size = new System.Drawing.Size(133, 21);
            this.LblDimentions.TabIndex = 45;
            this.LblDimentions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(136, 132);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(133, 21);
            this.lblNetWeigth.TabIndex = 107;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(345, 72);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(181, 21);
            this.lblCode.TabIndex = 45;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(49, 135);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(64, 15);
            this.lblNetWeigthLabel.TabIndex = 105;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(49, 48);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(81, 15);
            this.lblPalletTypeLabel.TabIndex = 46;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationLabel.Location = new System.Drawing.Point(49, 19);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(49, 15);
            this.lblDestinationLabel.TabIndex = 46;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblDimentionsLabel
            // 
            this.lblDimentionsLabel.AutoSize = true;
            this.lblDimentionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimentionsLabel.Location = new System.Drawing.Point(49, 77);
            this.lblDimentionsLabel.Name = "lblDimentionsLabel";
            this.lblDimentionsLabel.Size = new System.Drawing.Size(80, 15);
            this.lblDimentionsLabel.TabIndex = 46;
            this.lblDimentionsLabel.Text = "Dimensiones";
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(345, 132);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(181, 21);
            this.txtGrossWeigth.TabIndex = 104;
            this.txtGrossWeigth.Text = "0";
            this.txtGrossWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(280, 78);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(46, 15);
            this.lblCodeLabel.TabIndex = 46;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(49, 106);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(56, 15);
            this.lblProductLabel.TabIndex = 48;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(136, 103);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(390, 21);
            this.lblProduct.TabIndex = 47;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(280, 134);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(67, 15);
            this.lblGrossWeigth.TabIndex = 103;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 17);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(5, 557);
            this.lblStatusColor.TabIndex = 109;
            // 
            // cmsPalletMenu
            // 
            this.cmsPalletMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmDelete});
            this.cmsPalletMenu.Name = "cmsPalletMenu";
            this.cmsPalletMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::BPS.Properties.Resources.add1;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(117, 22);
            this.tsmAdd.Text = "Agregar";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::BPS.Properties.Resources.cross;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(117, 22);
            this.tsmDelete.Text = "Eliminar";
            // 
            // tbcPackingList
            // 
            this.tbcPackingList.Controls.Add(this.tbpDetails);
            this.tbcPackingList.Controls.Add(this.tbpList);
            this.tbcPackingList.Controls.Add(this.tbpHead);
            this.tbcPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPackingList.Location = new System.Drawing.Point(0, 0);
            this.tbcPackingList.Name = "tbcPackingList";
            this.tbcPackingList.SelectedIndex = 0;
            this.tbcPackingList.Size = new System.Drawing.Size(1097, 631);
            this.tbcPackingList.TabIndex = 6;
            // 
            // tbpDetails
            // 
            this.tbpDetails.Controls.Add(this.grpbPallets);
            this.tbpDetails.Location = new System.Drawing.Point(4, 24);
            this.tbpDetails.Name = "tbpDetails";
            this.tbpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetails.Size = new System.Drawing.Size(1089, 603);
            this.tbpDetails.TabIndex = 0;
            this.tbpDetails.Text = "Detalle";
            this.tbpDetails.UseVisualStyleBackColor = true;
            // 
            // tbpList
            // 
            this.tbpList.Controls.Add(this.grpbPackingList);
            this.tbpList.Controls.Add(this.grpbTransport);
            this.tbpList.Location = new System.Drawing.Point(4, 24);
            this.tbpList.Name = "tbpList";
            this.tbpList.Padding = new System.Windows.Forms.Padding(3);
            this.tbpList.Size = new System.Drawing.Size(1089, 603);
            this.tbpList.TabIndex = 1;
            this.tbpList.Text = "Listado";
            this.tbpList.UseVisualStyleBackColor = true;
            // 
            // grpbPackingList
            // 
            this.grpbPackingList.Controls.Add(this.tbcReports);
            this.grpbPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPackingList.Location = new System.Drawing.Point(3, 50);
            this.grpbPackingList.Name = "grpbPackingList";
            this.grpbPackingList.Size = new System.Drawing.Size(1083, 550);
            this.grpbPackingList.TabIndex = 1;
            this.grpbPackingList.TabStop = false;
            this.grpbPackingList.Text = "Packing list";
            // 
            // tbcReports
            // 
            this.tbcReports.Controls.Add(this.tbpUnifiedPackingList);
            this.tbcReports.Controls.Add(this.tbpDetailedPackingList);
            this.tbcReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcReports.Location = new System.Drawing.Point(3, 17);
            this.tbcReports.Name = "tbcReports";
            this.tbcReports.SelectedIndex = 0;
            this.tbcReports.Size = new System.Drawing.Size(1077, 530);
            this.tbcReports.TabIndex = 0;
            // 
            // tbpUnifiedPackingList
            // 
            this.tbpUnifiedPackingList.Controls.Add(this.crvUnifiedPackingList);
            this.tbpUnifiedPackingList.Location = new System.Drawing.Point(4, 24);
            this.tbpUnifiedPackingList.Name = "tbpUnifiedPackingList";
            this.tbpUnifiedPackingList.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUnifiedPackingList.Size = new System.Drawing.Size(1069, 502);
            this.tbpUnifiedPackingList.TabIndex = 0;
            this.tbpUnifiedPackingList.Text = "Lista de empaque unificada";
            this.tbpUnifiedPackingList.UseVisualStyleBackColor = true;
            // 
            // crvUnifiedPackingList
            // 
            this.crvUnifiedPackingList.ActiveViewIndex = -1;
            this.crvUnifiedPackingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvUnifiedPackingList.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvUnifiedPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvUnifiedPackingList.Location = new System.Drawing.Point(3, 3);
            this.crvUnifiedPackingList.Name = "crvUnifiedPackingList";
            this.crvUnifiedPackingList.ReuseParameterValuesOnRefresh = true;
            this.crvUnifiedPackingList.ShowGroupTreeButton = false;
            this.crvUnifiedPackingList.ShowParameterPanelButton = false;
            this.crvUnifiedPackingList.ShowRefreshButton = false;
            this.crvUnifiedPackingList.Size = new System.Drawing.Size(1063, 496);
            this.crvUnifiedPackingList.TabIndex = 0;
            this.crvUnifiedPackingList.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // tbpDetailedPackingList
            // 
            this.tbpDetailedPackingList.Controls.Add(this.crvDetailedPackingList);
            this.tbpDetailedPackingList.Location = new System.Drawing.Point(4, 24);
            this.tbpDetailedPackingList.Name = "tbpDetailedPackingList";
            this.tbpDetailedPackingList.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetailedPackingList.Size = new System.Drawing.Size(1069, 502);
            this.tbpDetailedPackingList.TabIndex = 1;
            this.tbpDetailedPackingList.Text = "Lista de empaque detallada";
            this.tbpDetailedPackingList.UseVisualStyleBackColor = true;
            // 
            // crvDetailedPackingList
            // 
            this.crvDetailedPackingList.ActiveViewIndex = -1;
            this.crvDetailedPackingList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDetailedPackingList.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDetailedPackingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDetailedPackingList.Location = new System.Drawing.Point(3, 3);
            this.crvDetailedPackingList.Name = "crvDetailedPackingList";
            this.crvDetailedPackingList.ReuseParameterValuesOnRefresh = true;
            this.crvDetailedPackingList.ShowGroupTreeButton = false;
            this.crvDetailedPackingList.ShowParameterPanelButton = false;
            this.crvDetailedPackingList.ShowRefreshButton = false;
            this.crvDetailedPackingList.Size = new System.Drawing.Size(1063, 496);
            this.crvDetailedPackingList.TabIndex = 0;
            this.crvDetailedPackingList.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // grpbTransport
            // 
            this.grpbTransport.Controls.Add(this.cmbTransport);
            this.grpbTransport.Controls.Add(this.lblTransport);
            this.grpbTransport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTransport.Location = new System.Drawing.Point(3, 3);
            this.grpbTransport.Name = "grpbTransport";
            this.grpbTransport.Size = new System.Drawing.Size(1083, 47);
            this.grpbTransport.TabIndex = 0;
            this.grpbTransport.TabStop = false;
            this.grpbTransport.Text = "Lista de transportes";
            // 
            // cmbTransport
            // 
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(257, 16);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(617, 23);
            this.cmbTransport.TabIndex = 9;
            this.cmbTransport.SelectedIndexChanged += new System.EventHandler(this.cmbTransport_SelectedIndexChanged);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(170, 19);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(66, 15);
            this.lblTransport.TabIndex = 10;
            this.lblTransport.Text = "Transporte";
            // 
            // tbpHead
            // 
            this.tbpHead.Controls.Add(this.grpbDetails);
            this.tbpHead.Controls.Add(this.groupBox3);
            this.tbpHead.Location = new System.Drawing.Point(4, 24);
            this.tbpHead.Name = "tbpHead";
            this.tbpHead.Padding = new System.Windows.Forms.Padding(3);
            this.tbpHead.Size = new System.Drawing.Size(1089, 603);
            this.tbpHead.TabIndex = 2;
            this.tbpHead.Text = "Encabezado";
            this.tbpHead.UseVisualStyleBackColor = true;
            // 
            // grpbDetails
            // 
            this.grpbDetails.Controls.Add(this.txtverify);
            this.grpbDetails.Controls.Add(this.label4);
            this.grpbDetails.Controls.Add(this.txtdescription);
            this.grpbDetails.Controls.Add(this.label3);
            this.grpbDetails.Controls.Add(this.txttitle);
            this.grpbDetails.Controls.Add(this.label2);
            this.grpbDetails.Controls.Add(this.btnSave);
            this.grpbDetails.Controls.Add(this.dtpDate);
            this.grpbDetails.Controls.Add(this.txtSales);
            this.grpbDetails.Controls.Add(this.lblSales);
            this.grpbDetails.Controls.Add(this.lblDate);
            this.grpbDetails.Controls.Add(this.txtCubicMeters);
            this.grpbDetails.Controls.Add(this.lblCubicMeters);
            this.grpbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetails.Location = new System.Drawing.Point(3, 50);
            this.grpbDetails.Name = "grpbDetails";
            this.grpbDetails.Size = new System.Drawing.Size(1083, 550);
            this.grpbDetails.TabIndex = 2;
            this.grpbDetails.TabStop = false;
            this.grpbDetails.Text = "Detalles";
            // 
            // txtverify
            // 
            this.txtverify.Location = new System.Drawing.Point(464, 223);
            this.txtverify.Name = "txtverify";
            this.txtverify.Size = new System.Drawing.Size(249, 21);
            this.txtverify.TabIndex = 13;
            this.txtverify.Text = "Revisado por Bodega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Revisión";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(464, 186);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(249, 21);
            this.txtdescription.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descripción";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(464, 149);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(249, 21);
            this.txttitle.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Título";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(689, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(464, 73);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(249, 21);
            this.dtpDate.TabIndex = 6;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(464, 111);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(249, 21);
            this.txtSales.TabIndex = 5;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(413, 114);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(48, 15);
            this.lblSales.TabIndex = 4;
            this.lblSales.Text = "Factura";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(420, 78);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha";
            // 
            // txtCubicMeters
            // 
            this.txtCubicMeters.Location = new System.Drawing.Point(464, 39);
            this.txtCubicMeters.Name = "txtCubicMeters";
            this.txtCubicMeters.Size = new System.Drawing.Size(155, 21);
            this.txtCubicMeters.TabIndex = 1;
            this.txtCubicMeters.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCubicMeters_KeyPress);
            // 
            // lblCubicMeters
            // 
            this.lblCubicMeters.AutoSize = true;
            this.lblCubicMeters.Location = new System.Drawing.Point(369, 42);
            this.lblCubicMeters.Name = "lblCubicMeters";
            this.lblCubicMeters.Size = new System.Drawing.Size(92, 15);
            this.lblCubicMeters.TabIndex = 0;
            this.lblCubicMeters.Text = "Metros Cúbicos";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTransportData);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1083, 47);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de transportes";
            // 
            // cmbTransportData
            // 
            this.cmbTransportData.FormattingEnabled = true;
            this.cmbTransportData.Location = new System.Drawing.Point(257, 16);
            this.cmbTransportData.Name = "cmbTransportData";
            this.cmbTransportData.Size = new System.Drawing.Size(617, 23);
            this.cmbTransportData.TabIndex = 9;
            this.cmbTransportData.SelectedIndexChanged += new System.EventHandler(this.cmbTransportData_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Transporte";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(464, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(464, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "Revisado por Bodega";
            // 
            // frmPackingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1097, 631);
            this.Controls.Add(this.tbcPackingList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPackingList";
            this.Text = "Packing List";
            this.Load += new System.EventHandler(this.frmPalletsByCuttingOrder_Load);
            this.grpbPallets.ResumeLayout(false);
            this.grpbSalesOrderDetail.ResumeLayout(false);
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbCoils.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.cmsPalletMenu.ResumeLayout(false);
            this.tbcPackingList.ResumeLayout(false);
            this.tbpDetails.ResumeLayout(false);
            this.tbpList.ResumeLayout(false);
            this.grpbPackingList.ResumeLayout(false);
            this.tbcReports.ResumeLayout(false);
            this.tbpUnifiedPackingList.ResumeLayout(false);
            this.tbpDetailedPackingList.ResumeLayout(false);
            this.grpbTransport.ResumeLayout(false);
            this.grpbTransport.PerformLayout();
            this.tbpHead.ResumeLayout(false);
            this.grpbDetails.ResumeLayout(false);
            this.grpbDetails.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPallets;
        private System.Windows.Forms.GroupBox grpbSalesOrderDetail;
        private System.Windows.Forms.GroupBox grpbPalletsRegister;
        private System.Windows.Forms.TreeView trvDestinations;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblPalletType;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblDimentionsLabel;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label LblDimentions;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblGrossWeigth;
        private System.Windows.Forms.TextBox txtGrossWeigth;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.Label lblDestinationLabel;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblCoilCount;
        private System.Windows.Forms.ContextMenuStrip cmsPalletMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Label lblStatusColor;
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.ToolTip ttpPalletsRegistration;
        private System.Windows.Forms.TabControl tbcPackingList;
        private System.Windows.Forms.TabPage tbpDetails;
        private System.Windows.Forms.TabPage tbpList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.GroupBox grpbPackingList;
        private System.Windows.Forms.GroupBox grpbTransport;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TabControl tbcReports;
        private System.Windows.Forms.TabPage tbpUnifiedPackingList;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvUnifiedPackingList;
        private System.Windows.Forms.TabPage tbpDetailedPackingList;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDetailedPackingList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tbpHead;
        private System.Windows.Forms.GroupBox grpbDetails;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTransportData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtCubicMeters;
        private System.Windows.Forms.Label lblCubicMeters;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtverify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}