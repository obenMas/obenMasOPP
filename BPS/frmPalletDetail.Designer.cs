namespace BPS
{
    partial class frmPalletDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletDetail));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
            this.chkReOpen = new System.Windows.Forms.CheckBox();
            this.chkPrintIncomplePallet = new System.Windows.Forms.CheckBox();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.txtCoilCode = new System.Windows.Forms.TextBox();
            this.lblCoilCode = new System.Windows.Forms.Label();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.cmbDimentions = new System.Windows.Forms.ComboBox();
            this.chkSearchByCoil = new System.Windows.Forms.CheckBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.LblDimentions = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.lblDestinationLabel = new System.Windows.Forms.Label();
            this.lblDimentionsLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.grpbSearchByCoil = new System.Windows.Forms.GroupBox();
            this.txtCoilCodeToSearch = new System.Windows.Forms.TextBox();
            this.lblCoilCodeToSearch = new System.Windows.Forms.Label();
            this.txtGrossWeigth = new System.Windows.Forms.Label();
            this.nudPalletNumber = new System.Windows.Forms.NumericUpDown();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtNewGrossWeight = new System.Windows.Forms.TextBox();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.cmsPalletMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttpPalletsRegistration = new System.Windows.Forms.ToolTip(this.components);
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrintCoilsLabels = new System.Windows.Forms.Button();
            this.btnAddCoil = new System.Windows.Forms.Button();
            this.btnChangeNumber = new System.Windows.Forms.Button();
            this.btnChangeDimention = new System.Windows.Forms.Button();
            this.btnChangeNetWeight = new System.Windows.Forms.Button();
            this.btnChangePalletType = new System.Windows.Forms.Button();
            this.btnChangeWeight = new System.Windows.Forms.Button();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbPallets.SuspendLayout();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbPaletInfo.SuspendLayout();
            this.grpbSearchByCoil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalletNumber)).BeginInit();
            this.cmsPalletMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.lblStatusColor);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbPallets.Location = new System.Drawing.Point(0, 0);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(10, 612);
            this.grpbPallets.TabIndex = 0;
            this.grpbPallets.TabStop = false;
            // 
            // grpbPalletsRegister
            // 
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(10, 0);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(555, 612);
            this.grpbPalletsRegister.TabIndex = 0;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // chkReOpen
            // 
            this.chkReOpen.AutoSize = true;
            this.chkReOpen.Location = new System.Drawing.Point(9, 44);
            this.chkReOpen.Name = "chkReOpen";
            this.chkReOpen.Size = new System.Drawing.Size(113, 19);
            this.chkReOpen.TabIndex = 3;
            this.chkReOpen.Text = "Reabrir el pallet";
            this.chkReOpen.UseVisualStyleBackColor = true;
            this.chkReOpen.CheckedChanged += new System.EventHandler(this.chkReOpen_CheckedChanged);
            // 
            // chkPrintIncomplePallet
            // 
            this.chkPrintIncomplePallet.AutoSize = true;
            this.chkPrintIncomplePallet.Location = new System.Drawing.Point(9, 20);
            this.chkPrintIncomplePallet.Name = "chkPrintIncomplePallet";
            this.chkPrintIncomplePallet.Size = new System.Drawing.Size(233, 19);
            this.chkPrintIncomplePallet.TabIndex = 2;
            this.chkPrintIncomplePallet.Text = "Imprimir etiqueta de pallet incompleto";
            this.chkPrintIncomplePallet.UseVisualStyleBackColor = true;
            this.chkPrintIncomplePallet.CheckedChanged += new System.EventHandler(this.chkPrintIncomplePallet_CheckedChanged);
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.groupBox2);
            this.grpbCoils.Controls.Add(this.groupBox3);
            this.grpbCoils.Controls.Add(this.groupBox1);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoils.Location = new System.Drawing.Point(3, 334);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(549, 275);
            this.grpbCoils.TabIndex = 1;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(185, 12);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(262, 26);
            this.txtCoilCode.TabIndex = 1;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCode.Location = new System.Drawing.Point(46, 15);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 0;
            this.lblCoilCode.Text = "C?digo de bobina";
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(3, 43);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(537, 18);
            this.lblCoilCount.TabIndex = 3;
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
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowHeadersWidth = 15;
            this.dgvCoils.Size = new System.Drawing.Size(537, 104);
            this.dgvCoils.TabIndex = 4;
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.cmbDimentions);
            this.grpbPaletInfo.Controls.Add(this.btnChangeNumber);
            this.grpbPaletInfo.Controls.Add(this.btnChangeDimention);
            this.grpbPaletInfo.Controls.Add(this.btnChangeNetWeight);
            this.grpbPaletInfo.Controls.Add(this.chkSearchByCoil);
            this.grpbPaletInfo.Controls.Add(this.btnChangePalletType);
            this.grpbPaletInfo.Controls.Add(this.txtPalletCode);
            this.grpbPaletInfo.Controls.Add(this.lblDestination);
            this.grpbPaletInfo.Controls.Add(this.lblPalletType);
            this.grpbPaletInfo.Controls.Add(this.btnChangeWeight);
            this.grpbPaletInfo.Controls.Add(this.LblDimentions);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblNumberLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDestinationLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDimentionsLabel);
            this.grpbPaletInfo.Controls.Add(this.lblCodeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.grpbSearchByCoil);
            this.grpbPaletInfo.Controls.Add(this.txtGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.nudPalletNumber);
            this.grpbPaletInfo.Controls.Add(this.lblNumber);
            this.grpbPaletInfo.Controls.Add(this.txtNewGrossWeight);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(3, 17);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(549, 317);
            this.grpbPaletInfo.TabIndex = 0;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Informaci?n de pallet";
            // 
            // cmbDimentions
            // 
            this.cmbDimentions.FormattingEnabled = true;
            this.cmbDimentions.Location = new System.Drawing.Point(114, 136);
            this.cmbDimentions.Name = "cmbDimentions";
            this.cmbDimentions.Size = new System.Drawing.Size(114, 28);
            this.cmbDimentions.TabIndex = 111;
            this.cmbDimentions.Visible = false;
            // 
            // chkSearchByCoil
            // 
            this.chkSearchByCoil.AutoSize = true;
            this.chkSearchByCoil.Location = new System.Drawing.Point(12, 48);
            this.chkSearchByCoil.Name = "chkSearchByCoil";
            this.chkSearchByCoil.Size = new System.Drawing.Size(272, 24);
            this.chkSearchByCoil.TabIndex = 17;
            this.chkSearchByCoil.Text = "Buscar pallet por c?digo de bobina";
            this.chkSearchByCoil.UseVisualStyleBackColor = true;
            this.chkSearchByCoil.CheckedChanged += new System.EventHandler(this.chkSearchByCoil_CheckedChanged);
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Location = new System.Drawing.Point(71, 19);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(463, 26);
            this.txtPalletCode.TabIndex = 1;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(114, 169);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(425, 21);
            this.lblDestination.TabIndex = 9;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalletType
            // 
            this.lblPalletType.BackColor = System.Drawing.SystemColors.Window;
            this.lblPalletType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPalletType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletType.Location = new System.Drawing.Point(114, 110);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(394, 21);
            this.lblPalletType.TabIndex = 4;
            this.lblPalletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblDimentions
            // 
            this.LblDimentions.BackColor = System.Drawing.SystemColors.Window;
            this.LblDimentions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDimentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDimentions.Location = new System.Drawing.Point(114, 140);
            this.LblDimentions.Name = "LblDimentions";
            this.LblDimentions.Size = new System.Drawing.Size(114, 21);
            this.LblDimentions.TabIndex = 7;
            this.LblDimentions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(62, 224);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 12;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(6, 110);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(103, 20);
            this.lblPalletTypeLabel.TabIndex = 3;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberLabel.Location = new System.Drawing.Point(308, 140);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(80, 20);
            this.lblNumberLabel.TabIndex = 6;
            this.lblNumberLabel.Text = "Nro. pallet";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationLabel.Location = new System.Drawing.Point(45, 169);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(64, 20);
            this.lblDestinationLabel.TabIndex = 8;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblDimentionsLabel
            // 
            this.lblDimentionsLabel.AutoSize = true;
            this.lblDimentionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDimentionsLabel.Location = new System.Drawing.Point(8, 140);
            this.lblDimentionsLabel.Name = "lblDimentionsLabel";
            this.lblDimentionsLabel.Size = new System.Drawing.Size(101, 20);
            this.lblDimentionsLabel.TabIndex = 6;
            this.lblDimentionsLabel.Text = "Dimensiones";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(6, 22);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 0;
            this.lblCodeLabel.Text = "C?digo";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(36, 199);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(73, 20);
            this.lblProductLabel.TabIndex = 10;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(114, 199);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(425, 21);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(351, 224);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigth.TabIndex = 14;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // grpbSearchByCoil
            // 
            this.grpbSearchByCoil.Controls.Add(this.txtCoilCodeToSearch);
            this.grpbSearchByCoil.Controls.Add(this.lblCoilCodeToSearch);
            this.grpbSearchByCoil.Enabled = false;
            this.grpbSearchByCoil.Location = new System.Drawing.Point(6, 50);
            this.grpbSearchByCoil.Name = "grpbSearchByCoil";
            this.grpbSearchByCoil.Size = new System.Drawing.Size(530, 54);
            this.grpbSearchByCoil.TabIndex = 109;
            this.grpbSearchByCoil.TabStop = false;
            // 
            // txtCoilCodeToSearch
            // 
            this.txtCoilCodeToSearch.Location = new System.Drawing.Point(164, 24);
            this.txtCoilCodeToSearch.Name = "txtCoilCodeToSearch";
            this.txtCoilCodeToSearch.Size = new System.Drawing.Size(341, 26);
            this.txtCoilCodeToSearch.TabIndex = 1;
            this.txtCoilCodeToSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCodeToSearch_KeyDown);
            // 
            // lblCoilCodeToSearch
            // 
            this.lblCoilCodeToSearch.AutoSize = true;
            this.lblCoilCodeToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCodeToSearch.Location = new System.Drawing.Point(25, 27);
            this.lblCoilCodeToSearch.Name = "lblCoilCodeToSearch";
            this.lblCoilCodeToSearch.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCodeToSearch.TabIndex = 0;
            this.lblCoilCodeToSearch.Text = "C?digo de bobina";
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(280, 249);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(231, 63);
            this.txtGrossWeigth.TabIndex = 15;
            this.txtGrossWeigth.Tag = "clearOnReload";
            this.txtGrossWeigth.Text = "0.0";
            this.txtGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudPalletNumber
            // 
            this.nudPalletNumber.Location = new System.Drawing.Point(394, 137);
            this.nudPalletNumber.Name = "nudPalletNumber";
            this.nudPalletNumber.Size = new System.Drawing.Size(120, 26);
            this.nudPalletNumber.TabIndex = 113;
            this.nudPalletNumber.Visible = false;
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(394, 140);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(114, 21);
            this.lblNumber.TabIndex = 7;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewGrossWeight
            // 
            this.txtNewGrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGrossWeight.Location = new System.Drawing.Point(280, 247);
            this.txtNewGrossWeight.Name = "txtNewGrossWeight";
            this.txtNewGrossWeight.Size = new System.Drawing.Size(231, 67);
            this.txtNewGrossWeight.TabIndex = 13;
            this.txtNewGrossWeight.Text = "0.0";
            this.txtNewGrossWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNewGrossWeight.Visible = false;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(6, 249);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(231, 63);
            this.lblNetWeigth.TabIndex = 13;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0.0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // cmsPalletMenu
            // 
            this.cmsPalletMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmDelete});
            this.cmsPalletMenu.Name = "cmsPalletMenu";
            this.cmsPalletMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 17);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(4, 592);
            this.lblStatusColor.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPrintIncomplePallet);
            this.groupBox1.Controls.Add(this.chkReOpen);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnPrintCoilsLabels);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Properties.Resources._lock;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(283, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 51);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpPalletsRegistration.SetToolTip(this.btnClose, "Cerrar Palets");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrintCoilsLabels
            // 
            this.btnPrintCoilsLabels.Image = global::BPS.Properties.Resources.printer;
            this.btnPrintCoilsLabels.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintCoilsLabels.Location = new System.Drawing.Point(356, 13);
            this.btnPrintCoilsLabels.Name = "btnPrintCoilsLabels";
            this.btnPrintCoilsLabels.Size = new System.Drawing.Size(67, 51);
            this.btnPrintCoilsLabels.TabIndex = 5;
            this.btnPrintCoilsLabels.Text = "Imprimir Bobinas";
            this.btnPrintCoilsLabels.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintCoilsLabels.UseVisualStyleBackColor = true;
            this.btnPrintCoilsLabels.Click += new System.EventHandler(this.btnPrintCoilsLabels_Click);
            // 
            // btnAddCoil
            // 
            this.btnAddCoil.Image = global::BPS.Properties.Resources.add_coil;
            this.btnAddCoil.Location = new System.Drawing.Point(453, 13);
            this.btnAddCoil.Name = "btnAddCoil";
            this.btnAddCoil.Size = new System.Drawing.Size(25, 25);
            this.btnAddCoil.TabIndex = 2;
            this.ttpPalletsRegistration.SetToolTip(this.btnAddCoil, "Agregar Bobina");
            this.btnAddCoil.UseVisualStyleBackColor = true;
            this.btnAddCoil.Click += new System.EventHandler(this.btnAddCoil_Click);
            // 
            // btnChangeNumber
            // 
            this.btnChangeNumber.Image = global::BPS.Properties.Resources.arrow_circle_double;
            this.btnChangeNumber.Location = new System.Drawing.Point(514, 137);
            this.btnChangeNumber.Name = "btnChangeNumber";
            this.btnChangeNumber.Size = new System.Drawing.Size(25, 25);
            this.btnChangeNumber.TabIndex = 112;
            this.btnChangeNumber.UseVisualStyleBackColor = true;
            this.btnChangeNumber.Click += new System.EventHandler(this.btnChangeNumber_Click);
            // 
            // btnChangeDimention
            // 
            this.btnChangeDimention.Image = global::BPS.Properties.Resources.arrow_circle_double;
            this.btnChangeDimention.Location = new System.Drawing.Point(234, 138);
            this.btnChangeDimention.Name = "btnChangeDimention";
            this.btnChangeDimention.Size = new System.Drawing.Size(25, 25);
            this.btnChangeDimention.TabIndex = 112;
            this.btnChangeDimention.UseVisualStyleBackColor = true;
            this.btnChangeDimention.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnChangeNetWeight
            // 
            this.btnChangeNetWeight.Image = global::BPS.Properties.Resources.arrow_circle_double;
            this.btnChangeNetWeight.Location = new System.Drawing.Point(243, 281);
            this.btnChangeNetWeight.Name = "btnChangeNetWeight";
            this.btnChangeNetWeight.Size = new System.Drawing.Size(25, 25);
            this.btnChangeNetWeight.TabIndex = 110;
            this.btnChangeNetWeight.UseVisualStyleBackColor = true;
            this.btnChangeNetWeight.Click += new System.EventHandler(this.btnUpdateLotNumber_Click);
            // 
            // btnChangePalletType
            // 
            this.btnChangePalletType.Image = global::BPS.Properties.Resources.arrow_circle_double;
            this.btnChangePalletType.Location = new System.Drawing.Point(514, 108);
            this.btnChangePalletType.Name = "btnChangePalletType";
            this.btnChangePalletType.Size = new System.Drawing.Size(25, 25);
            this.btnChangePalletType.TabIndex = 5;
            this.btnChangePalletType.UseVisualStyleBackColor = true;
            this.btnChangePalletType.Click += new System.EventHandler(this.btnChangePalletType_Click);
            // 
            // btnChangeWeight
            // 
            this.btnChangeWeight.Image = global::BPS.Properties.Resources.arrow_circle_double;
            this.btnChangeWeight.Location = new System.Drawing.Point(518, 281);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(25, 25);
            this.btnChangeWeight.TabIndex = 16;
            this.btnChangeWeight.UseVisualStyleBackColor = true;
            this.btnChangeWeight.Click += new System.EventHandler(this.btnChangeWeight_Click_1);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCoils);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCoilCode);
            this.groupBox3.Controls.Add(this.lblCoilCount);
            this.groupBox3.Controls.Add(this.btnAddCoil);
            this.groupBox3.Controls.Add(this.txtCoilCode);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(543, 64);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle16;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            this.clmCoilCodsec.Width = 10;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle17;
            this.clmCoilCode.HeaderText = "C?digo";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 150;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle18;
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
            // frmPalletDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 612);
            this.Controls.Add(this.grpbPalletsRegister);
            this.Controls.Add(this.grpbPallets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletDetail";
            this.Text = "Registro de pallets";
            this.Load += new System.EventHandler(this.frmPalletDetail_Load);
            this.grpbPallets.ResumeLayout(false);
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbCoils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.grpbSearchByCoil.ResumeLayout(false);
            this.grpbSearchByCoil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPalletNumber)).EndInit();
            this.cmsPalletMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPallets;
        private System.Windows.Forms.GroupBox grpbPalletsRegister;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblPalletType;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblDimentionsLabel;
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
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.ToolTip ttpPalletsRegistration;
        private System.Windows.Forms.Label txtGrossWeigth;
        private System.Windows.Forms.CheckBox chkPrintIncomplePallet;
        private System.Windows.Forms.Button btnChangeWeight;
        private System.Windows.Forms.TextBox txtNewGrossWeight;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Button btnChangePalletType;
        private System.Windows.Forms.Button btnPrintCoilsLabels;
        private System.Windows.Forms.CheckBox chkReOpen;
        private System.Windows.Forms.CheckBox chkSearchByCoil;
        private System.Windows.Forms.GroupBox grpbSearchByCoil;
        private System.Windows.Forms.TextBox txtCoilCodeToSearch;
        private System.Windows.Forms.Label lblCoilCodeToSearch;
        private System.Windows.Forms.Button btnChangeNetWeight;
        private System.Windows.Forms.Button btnChangeDimention;
        private System.Windows.Forms.ComboBox cmbDimentions;
        private System.Windows.Forms.Button btnChangeNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.NumericUpDown nudPalletNumber;
        private System.Windows.Forms.Label lblStatusColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilAction;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}