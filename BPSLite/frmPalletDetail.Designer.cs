namespace BPS.Lite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletDetail));
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
            this.chkReOpen = new System.Windows.Forms.CheckBox();
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
            this.lblBodega = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.chkSearchByCoil = new System.Windows.Forms.CheckBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.btnChangeWeight = new System.Windows.Forms.Button();
            this.LblDimentions = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblDestinationLabel = new System.Windows.Forms.Label();
            this.lblDimentionsLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.txtGrossWeigth = new System.Windows.Forms.Label();
            this.txtNewGrossWeight = new System.Windows.Forms.TextBox();
            this.grpbSearchByCoil = new System.Windows.Forms.GroupBox();
            this.txtCoilCodeToSearch = new System.Windows.Forms.TextBox();
            this.lblCoilCodeToSearch = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.cmsPalletMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpPalletsRegistration = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpbPallets.SuspendLayout();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbPaletInfo.SuspendLayout();
            this.grpbSearchByCoil.SuspendLayout();
            this.cmsPalletMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.grpbPalletsRegister);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPallets.Location = new System.Drawing.Point(0, 0);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(616, 630);
            this.grpbPallets.TabIndex = 0;
            this.grpbPallets.TabStop = false;
            // 
            // grpbPalletsRegister
            // 
            this.grpbPalletsRegister.Controls.Add(this.chkReOpen);
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Controls.Add(this.btnClose);
            this.grpbPalletsRegister.Controls.Add(this.lblStatusColor);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(3, 17);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(610, 610);
            this.grpbPalletsRegister.TabIndex = 0;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // chkReOpen
            // 
            this.chkReOpen.AutoSize = true;
            this.chkReOpen.Location = new System.Drawing.Point(14, 572);
            this.chkReOpen.Name = "chkReOpen";
            this.chkReOpen.Size = new System.Drawing.Size(113, 19);
            this.chkReOpen.TabIndex = 3;
            this.chkReOpen.Text = "Reabrir el pallet";
            this.chkReOpen.UseVisualStyleBackColor = true;
            this.chkReOpen.CheckedChanged += new System.EventHandler(this.chkReOpen_CheckedChanged);
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.txtCoilCode);
            this.grpbCoils.Controls.Add(this.lblCoilCode);
            this.grpbCoils.Controls.Add(this.btnAddCoil);
            this.grpbCoils.Controls.Add(this.lblCoilCount);
            this.grpbCoils.Controls.Add(this.dgvCoils);
            this.grpbCoils.Location = new System.Drawing.Point(9, 341);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(596, 210);
            this.grpbCoils.TabIndex = 1;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas";
            // 
            // txtCoilCode
            // 
            this.txtCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoilCode.Location = new System.Drawing.Point(214, 15);
            this.txtCoilCode.Name = "txtCoilCode";
            this.txtCoilCode.Size = new System.Drawing.Size(262, 26);
            this.txtCoilCode.TabIndex = 1;
            this.txtCoilCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCode_KeyDown);
            // 
            // lblCoilCode
            // 
            this.lblCoilCode.AutoSize = true;
            this.lblCoilCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCode.Location = new System.Drawing.Point(75, 18);
            this.lblCoilCode.Name = "lblCoilCode";
            this.lblCoilCode.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCode.TabIndex = 0;
            this.lblCoilCode.Text = "Código de bobina";
            // 
            // btnAddCoil
            // 
            this.btnAddCoil.Image = global::BPS.Lite.Properties.Resources.add_coil;
            this.btnAddCoil.Location = new System.Drawing.Point(482, 16);
            this.btnAddCoil.Name = "btnAddCoil";
            this.btnAddCoil.Size = new System.Drawing.Size(25, 25);
            this.btnAddCoil.TabIndex = 2;
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
            this.lblCoilCount.TabIndex = 3;
            this.lblCoilCount.Text = "Bobinas : --";
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
            this.dgvCoils.TabIndex = 4;
            this.dgvCoils.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoils_CellClick);
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 150;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.grpbPaletInfo.Controls.Add(this.lblBodega);
            this.grpbPaletInfo.Controls.Add(this.label6);
            this.grpbPaletInfo.Controls.Add(this.lblPosicion);
            this.grpbPaletInfo.Controls.Add(this.label4);
            this.grpbPaletInfo.Controls.Add(this.lblEstado);
            this.grpbPaletInfo.Controls.Add(this.label2);
            this.grpbPaletInfo.Controls.Add(this.chkManual);
            this.grpbPaletInfo.Controls.Add(this.chkSearchByCoil);
            this.grpbPaletInfo.Controls.Add(this.txtPalletCode);
            this.grpbPaletInfo.Controls.Add(this.lblDestination);
            this.grpbPaletInfo.Controls.Add(this.lblPalletType);
            this.grpbPaletInfo.Controls.Add(this.btnChangeWeight);
            this.grpbPaletInfo.Controls.Add(this.LblDimentions);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDestinationLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDimentionsLabel);
            this.grpbPaletInfo.Controls.Add(this.lblCodeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.txtGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.txtNewGrossWeight);
            this.grpbPaletInfo.Controls.Add(this.grpbSearchByCoil);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(8, 17);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(599, 334);
            this.grpbPaletInfo.TabIndex = 0;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Información de pallet";
            // 
            // lblBodega
            // 
            this.lblBodega.BackColor = System.Drawing.SystemColors.Window;
            this.lblBodega.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblBodega.Location = new System.Drawing.Point(362, 206);
            this.lblBodega.Name = "lblBodega";
            this.lblBodega.Size = new System.Drawing.Size(203, 21);
            this.lblBodega.TabIndex = 116;
            this.lblBodega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label6.Location = new System.Drawing.Point(284, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 115;
            this.label6.Text = "Bodega";
            // 
            // lblPosicion
            // 
            this.lblPosicion.BackColor = System.Drawing.SystemColors.Window;
            this.lblPosicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblPosicion.Location = new System.Drawing.Point(362, 171);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(203, 21);
            this.lblPosicion.TabIndex = 114;
            this.lblPosicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label4.Location = new System.Drawing.Point(284, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 113;
            this.label4.Text = "Posición";
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.SystemColors.Window;
            this.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblEstado.Location = new System.Drawing.Point(140, 172);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(133, 21);
            this.lblEstado.TabIndex = 112;
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.label2.Location = new System.Drawing.Point(31, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 111;
            this.label2.Text = "Estado";
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(545, 258);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(15, 14);
            this.chkManual.TabIndex = 110;
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.CheckedChanged += new System.EventHandler(this.chkManual_CheckedChanged);
            // 
            // chkSearchByCoil
            // 
            this.chkSearchByCoil.AutoSize = true;
            this.chkSearchByCoil.Location = new System.Drawing.Point(42, 45);
            this.chkSearchByCoil.Name = "chkSearchByCoil";
            this.chkSearchByCoil.Size = new System.Drawing.Size(272, 24);
            this.chkSearchByCoil.TabIndex = 17;
            this.chkSearchByCoil.Text = "Buscar pallet por código de bobina";
            this.chkSearchByCoil.UseVisualStyleBackColor = true;
            this.chkSearchByCoil.CheckedChanged += new System.EventHandler(this.chkSearchByCoil_CheckedChanged);
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Location = new System.Drawing.Point(140, 19);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(425, 26);
            this.txtPalletCode.TabIndex = 1;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblDestination.Location = new System.Drawing.Point(362, 135);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(203, 21);
            this.lblDestination.TabIndex = 9;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalletType
            // 
            this.lblPalletType.BackColor = System.Drawing.SystemColors.Window;
            this.lblPalletType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPalletType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblPalletType.Location = new System.Drawing.Point(140, 104);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(425, 21);
            this.lblPalletType.TabIndex = 4;
            this.lblPalletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnChangeWeight
            // 
            this.btnChangeWeight.Image = global::BPS.Lite.Properties.Resources.arrow_circle_double;
            this.btnChangeWeight.Location = new System.Drawing.Point(540, 294);
            this.btnChangeWeight.Name = "btnChangeWeight";
            this.btnChangeWeight.Size = new System.Drawing.Size(25, 25);
            this.btnChangeWeight.TabIndex = 16;
            this.btnChangeWeight.UseVisualStyleBackColor = true;
            this.btnChangeWeight.Click += new System.EventHandler(this.btnChangeWeight_Click_1);
            // 
            // LblDimentions
            // 
            this.LblDimentions.BackColor = System.Drawing.SystemColors.Window;
            this.LblDimentions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDimentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.LblDimentions.Location = new System.Drawing.Point(140, 135);
            this.LblDimentions.Name = "LblDimentions";
            this.LblDimentions.Size = new System.Drawing.Size(133, 21);
            this.LblDimentions.TabIndex = 7;
            this.LblDimentions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(101, 258);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(191, 63);
            this.lblNetWeigth.TabIndex = 13;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0.0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(155, 239);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 12;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(31, 104);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(103, 20);
            this.lblPalletTypeLabel.TabIndex = 3;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblDestinationLabel.Location = new System.Drawing.Point(285, 134);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(64, 20);
            this.lblDestinationLabel.TabIndex = 8;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblDimentionsLabel
            // 
            this.lblDimentionsLabel.AutoSize = true;
            this.lblDimentionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblDimentionsLabel.Location = new System.Drawing.Point(31, 135);
            this.lblDimentionsLabel.Name = "lblDimentionsLabel";
            this.lblDimentionsLabel.Size = new System.Drawing.Size(101, 20);
            this.lblDimentionsLabel.TabIndex = 6;
            this.lblDimentionsLabel.Text = "Dimensiones";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(31, 22);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 0;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblProductLabel.Location = new System.Drawing.Point(31, 207);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(73, 20);
            this.lblProductLabel.TabIndex = 10;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.lblProduct.Location = new System.Drawing.Point(140, 212);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(133, 21);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(389, 235);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(88, 20);
            this.lblGrossWeigth.TabIndex = 14;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(338, 258);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(191, 63);
            this.txtGrossWeigth.TabIndex = 15;
            this.txtGrossWeigth.Tag = "clearOnReload";
            this.txtGrossWeigth.Text = "0.0";
            this.txtGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNewGrossWeight
            // 
            this.txtNewGrossWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewGrossWeight.Location = new System.Drawing.Point(338, 258);
            this.txtNewGrossWeight.Name = "txtNewGrossWeight";
            this.txtNewGrossWeight.Size = new System.Drawing.Size(191, 67);
            this.txtNewGrossWeight.TabIndex = 13;
            this.txtNewGrossWeight.Text = "0.0";
            this.txtNewGrossWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNewGrossWeight.Visible = false;
            // 
            // grpbSearchByCoil
            // 
            this.grpbSearchByCoil.Controls.Add(this.txtCoilCodeToSearch);
            this.grpbSearchByCoil.Controls.Add(this.lblCoilCodeToSearch);
            this.grpbSearchByCoil.Enabled = false;
            this.grpbSearchByCoil.Location = new System.Drawing.Point(35, 47);
            this.grpbSearchByCoil.Name = "grpbSearchByCoil";
            this.grpbSearchByCoil.Size = new System.Drawing.Size(530, 55);
            this.grpbSearchByCoil.TabIndex = 109;
            this.grpbSearchByCoil.TabStop = false;
            // 
            // txtCoilCodeToSearch
            // 
            this.txtCoilCodeToSearch.Location = new System.Drawing.Point(164, 22);
            this.txtCoilCodeToSearch.Name = "txtCoilCodeToSearch";
            this.txtCoilCodeToSearch.Size = new System.Drawing.Size(341, 26);
            this.txtCoilCodeToSearch.TabIndex = 1;
            this.txtCoilCodeToSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCoilCodeToSearch_KeyDown);
            // 
            // lblCoilCodeToSearch
            // 
            this.lblCoilCodeToSearch.AutoSize = true;
            this.lblCoilCodeToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCodeToSearch.Location = new System.Drawing.Point(25, 25);
            this.lblCoilCodeToSearch.Name = "lblCoilCodeToSearch";
            this.lblCoilCodeToSearch.Size = new System.Drawing.Size(133, 20);
            this.lblCoilCodeToSearch.TabIndex = 0;
            this.lblCoilCodeToSearch.Text = "Código de bobina";
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Lite.Properties.Resources._lock;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(275, 554);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(67, 51);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ttpPalletsRegistration.SetToolTip(this.btnClose, "Cerrar Palets");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 17);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(5, 590);
            this.lblStatusColor.TabIndex = 2;
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
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPalletDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(616, 628);
            this.Controls.Add(this.grpbPallets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletDetail";
            this.Text = "Registro de pallets";
            this.grpbPallets.ResumeLayout(false);
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbPalletsRegister.PerformLayout();
            this.grpbCoils.ResumeLayout(false);
            this.grpbCoils.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.grpbSearchByCoil.ResumeLayout(false);
            this.grpbSearchByCoil.PerformLayout();
            this.cmsPalletMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnChangeWeight;
        private System.Windows.Forms.TextBox txtNewGrossWeight;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.CheckBox chkReOpen;
        private System.Windows.Forms.CheckBox chkSearchByCoil;
        private System.Windows.Forms.GroupBox grpbSearchByCoil;
        private System.Windows.Forms.TextBox txtCoilCodeToSearch;
        private System.Windows.Forms.Label lblCoilCodeToSearch;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox chkManual;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBodega;
        private System.Windows.Forms.Label label6;
    }
}