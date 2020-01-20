namespace BPS.Lite
{
    partial class frmPalletsRegistrationD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletsRegistration));
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.grpbSalesOrderDetail = new System.Windows.Forms.GroupBox();
            this.trvDestinations = new System.Windows.Forms.TreeView();
            this.cmsPalletMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.ttpPalletsRegistration = new System.Windows.Forms.ToolTip(this.components);
            this.btnChangeWeight = new System.Windows.Forms.Button();
            this.grpbPallets.SuspendLayout();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbPaletInfo.SuspendLayout();
            this.grpbSalesOrderDetail.SuspendLayout();
            this.cmsPalletMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.grpbPalletsRegister);
            this.grpbPallets.Controls.Add(this.grpbSalesOrderDetail);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPallets.Location = new System.Drawing.Point(0, 0);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(977, 462);
            this.grpbPallets.TabIndex = 5;
            this.grpbPallets.TabStop = false;
            // 
            // grpbPalletsRegister
            // 
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Controls.Add(this.btnClose);
            this.grpbPalletsRegister.Controls.Add(this.lblStatusColor);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(367, 17);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(607, 442);
            this.grpbPalletsRegister.TabIndex = 1;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.txtCoilCode);
            this.grpbCoils.Controls.Add(this.lblCoilCode);
            this.grpbCoils.Controls.Add(this.btnAddCoil);
            this.grpbCoils.Controls.Add(this.lblCoilCount);
            this.grpbCoils.Controls.Add(this.dgvCoils);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoils.Location = new System.Drawing.Point(8, 177);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(596, 210);
            this.grpbCoils.TabIndex = 111;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(214, 15);
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
            this.lblCoilCode.Location = new System.Drawing.Point(75, 18);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 47;
            this.lblCoilCode.Text = "Código de bobina";
            // 
            // btnAddCoil
            // 
            this.btnAddCoil.Image = global::BPS.Lite.Properties.Resources.add_coil;
            this.btnAddCoil.Location = new System.Drawing.Point(482, 16);
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
            this.lblCoilCount.Location = new System.Drawing.Point(36, 46);
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
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCoils.Location = new System.Drawing.Point(3, 70);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(590, 137);
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
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.btnChangeWeight);
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
            this.grpbPaletInfo.Size = new System.Drawing.Size(596, 160);
            this.grpbPaletInfo.TabIndex = 110;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Información de pallet";
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(140, 16);
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
            this.lblPalletType.Location = new System.Drawing.Point(140, 45);
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
            this.LblDimentions.Location = new System.Drawing.Point(140, 74);
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
            this.lblNetWeigth.Location = new System.Drawing.Point(140, 132);
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
            this.lblCode.Location = new System.Drawing.Point(349, 72);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(181, 21);
            this.lblCode.TabIndex = 45;
            this.lblCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(53, 135);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(64, 15);
            this.lblNetWeigthLabel.TabIndex = 105;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(53, 48);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(81, 15);
            this.lblPalletTypeLabel.TabIndex = 46;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationLabel.Location = new System.Drawing.Point(53, 19);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(49, 15);
            this.lblDestinationLabel.TabIndex = 46;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblDimentionsLabel
            // 
            this.lblDimentionsLabel.AutoSize = true;
            this.lblDimentionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimentionsLabel.Location = new System.Drawing.Point(53, 77);
            this.lblDimentionsLabel.Name = "lblDimentionsLabel";
            this.lblDimentionsLabel.Size = new System.Drawing.Size(80, 15);
            this.lblDimentionsLabel.TabIndex = 46;
            this.lblDimentionsLabel.Text = "Dimensiones";
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(349, 132);
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
            this.lblCodeLabel.Location = new System.Drawing.Point(284, 78);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(46, 15);
            this.lblCodeLabel.TabIndex = 46;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(53, 106);
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
            this.lblProduct.Location = new System.Drawing.Point(140, 103);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(390, 21);
            this.lblProduct.TabIndex = 47;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(284, 135);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(67, 15);
            this.lblGrossWeigth.TabIndex = 103;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(266, 393);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 45);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpPalletsRegistration.SetToolTip(this.btnClose, "Cerrar Palets");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 17);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(5, 422);
            this.lblStatusColor.TabIndex = 109;
            // 
            // grpbSalesOrderDetail
            // 
            this.grpbSalesOrderDetail.Controls.Add(this.trvDestinations);
            this.grpbSalesOrderDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbSalesOrderDetail.Location = new System.Drawing.Point(3, 17);
            this.grpbSalesOrderDetail.Name = "grpbSalesOrderDetail";
            this.grpbSalesOrderDetail.Size = new System.Drawing.Size(364, 442);
            this.grpbSalesOrderDetail.TabIndex = 0;
            this.grpbSalesOrderDetail.TabStop = false;
            this.grpbSalesOrderDetail.Text = "Destinatarios";
            // 
            // trvDestinations
            // 
            this.trvDestinations.ContextMenuStrip = this.cmsPalletMenu;
            this.trvDestinations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDestinations.ImageIndex = 0;
            this.trvDestinations.ImageList = this.imgLstIcons;
            this.trvDestinations.Location = new System.Drawing.Point(3, 17);
            this.trvDestinations.Name = "trvDestinations";
            this.trvDestinations.SelectedImageIndex = 0;
            this.trvDestinations.Size = new System.Drawing.Size(358, 422);
            this.trvDestinations.TabIndex = 0;
            this.trvDestinations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvDestinations_AfterSelect);
            // 
            // cmsPalletMenu
            // 
            this.cmsPalletMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmDelete});
            this.cmsPalletMenu.Name = "cmsPalletMenu";
            this.cmsPalletMenu.Size = new System.Drawing.Size(153, 70);
            this.cmsPalletMenu.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPalletMenu_Opening);
            this.cmsPalletMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsPalletMenu_ItemClicked);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Image = global::BPS.Lite.Properties.Resources.add1;
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(152, 22);
            this.tsmAdd.Text = "Agregar";
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::BPS.Lite.Properties.Resources.cross;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmDelete.Text = "Eliminar";
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
            // btnChangeWeight
            // 
            this.btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.disk;
            this.btnChangeWeight.Location = new System.Drawing.Point(536, 130);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(25, 25);
            this.btnChangeWeight.TabIndex = 108;
            this.ttpPalletsRegistration.SetToolTip(this.btnChangeWeight, "Agregar Bobina");
            this.btnChangeWeight.UseVisualStyleBackColor = true;
            this.btnChangeWeight.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPalletsRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(977, 515);
            this.Controls.Add(this.grpbPallets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletsRegistration";
            this.Text = "Registro de pallets";
            this.Load += new System.EventHandler(this.frmPalletsByCuttingOrder_Load);
            this.grpbPallets.ResumeLayout(false);
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbCoils.ResumeLayout(false);
            this.grpbCoils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.grpbSalesOrderDetail.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtGrossWeigth;
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
        private System.Windows.Forms.Button btnChangeWeight;
    }
}