namespace BPS.Lite
{
    partial class frmPalletRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletRegistration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.grpbSalesOrderDetail = new System.Windows.Forms.GroupBox();
            this.txtSalesOrderNumber = new System.Windows.Forms.TextBox();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeLabel = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.trvDestinations = new System.Windows.Forms.TreeView();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
            this.chkPrintIncomplePallet = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.chkManualWeight = new System.Windows.Forms.CheckBox();
            this.txtManualGrossWeigth = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.LblDimentions = new System.Windows.Forms.Label();
            this.txtGrossWeigth = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblDestinationLabel = new System.Windows.Forms.Label();
            this.lblDimentionsLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.lblCoilCode = new System.Windows.Forms.Label();
            this.btnAddCoil = new System.Windows.Forms.Button();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmsPalletMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpPalletsRegistration = new System.Windows.Forms.ToolTip(this.components);
            this.grpbPallets.SuspendLayout();
            this.grpbSalesOrderDetail.SuspendLayout();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbPaletInfo.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.cmsPalletMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.grpbSalesOrderDetail);
            this.grpbPallets.Controls.Add(this.grpbPalletsRegister);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPallets.Location = new System.Drawing.Point(0, 0);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(1126, 630);
            this.grpbPallets.TabIndex = 0;
            this.grpbPallets.TabStop = false;
            // 
            // grpbSalesOrderDetail
            // 
            this.grpbSalesOrderDetail.Controls.Add(this.txtSalesOrderNumber);
            this.grpbSalesOrderDetail.Controls.Add(this.lblOrderNumber);
            this.grpbSalesOrderDetail.Controls.Add(this.lblType);
            this.grpbSalesOrderDetail.Controls.Add(this.lblTypeLabel);
            this.grpbSalesOrderDetail.Controls.Add(this.lblCustomerName);
            this.grpbSalesOrderDetail.Controls.Add(this.lblCustomerNameLabel);
            this.grpbSalesOrderDetail.Controls.Add(this.trvDestinations);
            this.grpbSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbSalesOrderDetail.Location = new System.Drawing.Point(3, 17);
            this.grpbSalesOrderDetail.Name = "grpbSalesOrderDetail";
            this.grpbSalesOrderDetail.Size = new System.Drawing.Size(525, 610);
            this.grpbSalesOrderDetail.TabIndex = 0;
            this.grpbSalesOrderDetail.TabStop = false;
            this.grpbSalesOrderDetail.Text = "Destinatarios";
            // 
            // txtSalesOrderNumber
            // 
            this.txtSalesOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesOrderNumber.Location = new System.Drawing.Point(125, 15);
            this.txtSalesOrderNumber.Name = "txtSalesOrderNumber";
            this.txtSalesOrderNumber.Size = new System.Drawing.Size(263, 45);
            this.txtSalesOrderNumber.TabIndex = 1;
            this.txtSalesOrderNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalesOrderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalesOrderNumber_KeyDown);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.Location = new System.Drawing.Point(9, 27);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(110, 20);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Número orden";
            // 
            // lblType
            // 
            this.lblType.BackColor = System.Drawing.SystemColors.Window;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(125, 93);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(261, 21);
            this.lblType.TabIndex = 5;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeLabel
            // 
            this.lblTypeLabel.AutoSize = true;
            this.lblTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeLabel.Location = new System.Drawing.Point(9, 93);
            this.lblTypeLabel.Name = "lblTypeLabel";
            this.lblTypeLabel.Size = new System.Drawing.Size(39, 20);
            this.lblTypeLabel.TabIndex = 4;
            this.lblTypeLabel.Text = "Tipo";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(125, 66);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(261, 21);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(9, 66);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(58, 20);
            this.lblCustomerNameLabel.TabIndex = 2;
            this.lblCustomerNameLabel.Text = "Cliente";
            // 
            // trvDestinations
            // 
            this.trvDestinations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trvDestinations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvDestinations.ImageIndex = 0;
            this.trvDestinations.ImageList = this.imgLstIcons;
            this.trvDestinations.Location = new System.Drawing.Point(3, 126);
            this.trvDestinations.Name = "trvDestinations";
            this.trvDestinations.SelectedImageIndex = 0;
            this.trvDestinations.Size = new System.Drawing.Size(519, 481);
            this.trvDestinations.TabIndex = 6;
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
            this.grpbPalletsRegister.Controls.Add(this.chkPrintIncomplePallet);
            this.grpbPalletsRegister.Controls.Add(this.btnClose);
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Controls.Add(this.lblStatusColor);
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(528, 17);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(595, 610);
            this.grpbPalletsRegister.TabIndex = 1;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // chkPrintIncomplePallet
            // 
            this.chkPrintIncomplePallet.AutoSize = true;
            this.chkPrintIncomplePallet.Location = new System.Drawing.Point(14, 556);
            this.chkPrintIncomplePallet.Name = "chkPrintIncomplePallet";
            this.chkPrintIncomplePallet.Size = new System.Drawing.Size(233, 19);
            this.chkPrintIncomplePallet.TabIndex = 112;
            this.chkPrintIncomplePallet.Text = "Imprimir etiqueta de pallet incompleto";
            this.chkPrintIncomplePallet.UseVisualStyleBackColor = true;
            this.chkPrintIncomplePallet.CheckedChanged += new System.EventHandler(this.chkPrintIncomplePallet_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(270, 558);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 45);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpPalletsRegistration.SetToolTip(this.btnClose, "Cerrar Palets");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.chkManualWeight);
            this.grpbPaletInfo.Controls.Add(this.txtManualGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblDestination);
            this.grpbPaletInfo.Controls.Add(this.lblPalletType);
            this.grpbPaletInfo.Controls.Add(this.LblDimentions);
            this.grpbPaletInfo.Controls.Add(this.txtGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblCode);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDestinationLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDimentionsLabel);
            this.grpbPaletInfo.Controls.Add(this.lblCodeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(8, 17);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(584, 226);
            this.grpbPaletInfo.TabIndex = 110;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Información de pallet";
            // 
            // chkManualWeight
            // 
            this.chkManualWeight.Location = new System.Drawing.Point(476, 162);
            this.chkManualWeight.Name = "chkManualWeight";
            this.chkManualWeight.Size = new System.Drawing.Size(80, 48);
            this.chkManualWeight.TabIndex = 109;
            this.chkManualWeight.Text = "Toma Manual";
            this.chkManualWeight.UseVisualStyleBackColor = true;
            this.chkManualWeight.CheckedChanged += new System.EventHandler(this.chkManualWeight_CheckedChanged);
            // 
            // txtManualGrossWeigth
            // 
            this.txtManualGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManualGrossWeigth.Location = new System.Drawing.Point(279, 155);
            this.txtManualGrossWeigth.Name = "txtManualGrossWeigth";
            this.txtManualGrossWeigth.Size = new System.Drawing.Size(191, 68);
            this.txtManualGrossWeigth.TabIndex = 108;
            this.txtManualGrossWeigth.Text = "0.0";
            this.txtManualGrossWeigth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtManualGrossWeigth.Visible = false;
            this.txtManualGrossWeigth.TextChanged += new System.EventHandler(this.txtManualGrossWeigth_TextChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(134, 22);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(425, 21);
            this.lblDestination.TabIndex = 45;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalletType
            // 
            this.lblPalletType.BackColor = System.Drawing.SystemColors.Window;
            this.lblPalletType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPalletType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletType.Location = new System.Drawing.Point(134, 48);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(425, 21);
            this.lblPalletType.TabIndex = 45;
            this.lblPalletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDimentions
            // 
            this.LblDimentions.BackColor = System.Drawing.SystemColors.Window;
            this.LblDimentions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDimentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDimentions.Location = new System.Drawing.Point(134, 77);
            this.LblDimentions.Name = "LblDimentions";
            this.LblDimentions.Size = new System.Drawing.Size(133, 21);
            this.LblDimentions.TabIndex = 45;
            this.LblDimentions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(279, 155);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(191, 63);
            this.txtGrossWeigth.TabIndex = 107;
            this.txtGrossWeigth.Tag = "clearOnReload";
            this.txtGrossWeigth.Text = "0.0";
            this.txtGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCode
            // 
            this.lblCode.BackColor = System.Drawing.SystemColors.Window;
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(343, 75);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(216, 21);
            this.lblCode.TabIndex = 45;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(83, 132);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 105;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(25, 51);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(103, 20);
            this.lblPalletTypeLabel.TabIndex = 46;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationLabel.Location = new System.Drawing.Point(25, 25);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(64, 20);
            this.lblDestinationLabel.TabIndex = 46;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblDimentionsLabel
            // 
            this.lblDimentionsLabel.AutoSize = true;
            this.lblDimentionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimentionsLabel.Location = new System.Drawing.Point(25, 80);
            this.lblDimentionsLabel.Name = "lblDimentionsLabel";
            this.lblDimentionsLabel.Size = new System.Drawing.Size(101, 20);
            this.lblDimentionsLabel.TabIndex = 46;
            this.lblDimentionsLabel.Text = "Dimensiones";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(278, 81);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 46;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(25, 109);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(73, 20);
            this.lblProductLabel.TabIndex = 48;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(134, 106);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(425, 21);
            this.lblProduct.TabIndex = 47;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(330, 132);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigth.TabIndex = 103;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(29, 155);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(191, 63);
            this.lblNetWeigth.TabIndex = 107;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0.0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 17);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(5, 590);
            this.lblStatusColor.TabIndex = 109;
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.txtCoilCode);
            this.grpbCoils.Controls.Add(this.lblCoilCode);
            this.grpbCoils.Controls.Add(this.btnAddCoil);
            this.grpbCoils.Controls.Add(this.lblCoilCount);
            this.grpbCoils.Controls.Add(this.dgvCoils);
            this.grpbCoils.Location = new System.Drawing.Point(8, 246);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(584, 306);
            this.grpbCoils.TabIndex = 111;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(215, 15);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(262, 26);
            this.txtCoilCode.TabIndex = 48;
            this.txtCoilCode.TextChanged += new System.EventHandler(this.txtCoilCode_TextChanged);
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCode.Location = new System.Drawing.Point(76, 18);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 47;
            this.lblCoilCode.Text = "Código de bobina";
            // 
            // btnAddCoil
            // 
            this.btnAddCoil.Image = global::BPS.Lite.Properties.Resources.add_coil;
            this.btnAddCoil.Location = new System.Drawing.Point(483, 16);
            this.btnAddCoil.Name = "btnAddCoil";
            this.btnAddCoil.Size = new System.Drawing.Size(25, 25);
            this.btnAddCoil.TabIndex = 107;
            this.ttpPalletsRegistration.SetToolTip(this.btnAddCoil, "Agregar Bobina");
            this.btnAddCoil.UseVisualStyleBackColor = true;
            this.btnAddCoil.Click += new System.EventHandler(this.btnAddCoil_Click);
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(48, 45);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(511, 18);
            this.lblCoilCount.TabIndex = 108;
            this.lblCoilCount.Text = "Bobinas : -- / --";
            this.lblCoilCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.clmCoilWeigth,
            this.clmCoilAction});
            this.dgvCoils.Location = new System.Drawing.Point(0, 66);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(581, 234);
            this.dgvCoils.TabIndex = 0;
            this.dgvCoils.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoils_CellClick);
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 150;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 90;
            // 
            // clmCoilWidth
            // 
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 90;
            // 
            // clmCoilWeigth
            // 
            this.clmCoilWeigth.HeaderText = "Peso";
            this.clmCoilWeigth.Name = "clmCoilWeigth";
            this.clmCoilWeigth.ReadOnly = true;
            this.clmCoilWeigth.Width = 90;
            // 
            // clmCoilAction
            // 
            this.clmCoilAction.HeaderText = "";
            this.clmCoilAction.Name = "clmCoilAction";
            this.clmCoilAction.ReadOnly = true;
            this.clmCoilAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCoilAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmCoilAction.Width = 30;
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
            this.tsmAdd.Image = global::BPS.Lite.Properties.Resources.add1;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(117, 22);
            this.tsmAdd.Text = "Agregar";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::BPS.Lite.Properties.Resources.cross;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(117, 22);
            this.tsmDelete.Text = "Eliminar";
            // 
            // frmPalletRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1126, 630);
            this.Controls.Add(this.grpbPallets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletRegistration";
            this.Text = "Registro de pallets";
            this.Load += new System.EventHandler(this.frmPalletsByCuttingOrder_Load);
            this.grpbPallets.ResumeLayout(false);
            this.grpbSalesOrderDetail.ResumeLayout(false);
            this.grpbSalesOrderDetail.PerformLayout();
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbPalletsRegister.PerformLayout();
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.grpbCoils.ResumeLayout(false);
            this.grpbCoils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.cmsPalletMenu.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtCoilCode;
        private System.Windows.Forms.Label lblCoilCode;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.Button btnAddCoil;
        private System.Windows.Forms.Label lblDestinationLabel;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblCoilCount;
        private System.Windows.Forms.ContextMenuStrip cmsPalletMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStatusColor;
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.ToolTip ttpPalletsRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilAction;
        private System.Windows.Forms.Label txtGrossWeigth;
        private System.Windows.Forms.CheckBox chkPrintIncomplePallet;
        private System.Windows.Forms.TextBox txtSalesOrderNumber;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeLabel;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.TextBox txtManualGrossWeigth;
        private System.Windows.Forms.CheckBox chkManualWeight;
    }
}