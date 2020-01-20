namespace BPS.Lite
{
    partial class frmCoilCellarMovementsBCK
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilCellarMovementsBCK));
            this.tbcMovements = new System.Windows.Forms.TabControl();
            this.tbpMovementType = new System.Windows.Forms.TabPage();
            this.txtMovement = new System.Windows.Forms.TextBox();
            this.lblMovement = new System.Windows.Forms.Label();
            this.tbpPallets = new System.Windows.Forms.TabPage();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.txtGrossWeigth = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblDestinationLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblGrossWeigth = new System.Windows.Forms.Label();
            this.grpbDestination = new System.Windows.Forms.GroupBox();
            this.lblDestinationCellar = new System.Windows.Forms.Label();
            this.grpbPalletCode = new System.Windows.Forms.GroupBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbcMovements.SuspendLayout();
            this.tbpMovementType.SuspendLayout();
            this.tbpPallets.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbPaletInfo.SuspendLayout();
            this.grpbDestination.SuspendLayout();
            this.grpbPalletCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMovements
            // 
            this.tbcMovements.Controls.Add(this.tbpMovementType);
            this.tbcMovements.Controls.Add(this.tbpPallets);
            this.tbcMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMovements.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcMovements.ImageList = this.imgLstIcons;
            this.tbcMovements.Location = new System.Drawing.Point(0, 0);
            this.tbcMovements.Name = "tbcMovements";
            this.tbcMovements.SelectedIndex = 0;
            this.tbcMovements.Size = new System.Drawing.Size(776, 640);
            this.tbcMovements.TabIndex = 0;
            // 
            // tbpMovementType
            // 
            this.tbpMovementType.Controls.Add(this.txtMovement);
            this.tbpMovementType.Controls.Add(this.lblMovement);
            this.tbpMovementType.Location = new System.Drawing.Point(4, 34);
            this.tbpMovementType.Name = "tbpMovementType";
            this.tbpMovementType.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMovementType.Size = new System.Drawing.Size(768, 602);
            this.tbpMovementType.TabIndex = 0;
            this.tbpMovementType.Text = "Tipo de movimiento";
            this.tbpMovementType.UseVisualStyleBackColor = true;
            // 
            // txtMovement
            // 
            this.txtMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovement.Location = new System.Drawing.Point(159, 306);
            this.txtMovement.Name = "txtMovement";
            this.txtMovement.Size = new System.Drawing.Size(450, 45);
            this.txtMovement.TabIndex = 0;
            this.txtMovement.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMovement_KeyDown);
            // 
            // lblMovement
            // 
            this.lblMovement.AutoSize = true;
            this.lblMovement.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovement.Location = new System.Drawing.Point(227, 251);
            this.lblMovement.Name = "lblMovement";
            this.lblMovement.Size = new System.Drawing.Size(314, 39);
            this.lblMovement.TabIndex = 0;
            this.lblMovement.Text = "Tipo de movimiento";
            // 
            // tbpPallets
            // 
            this.tbpPallets.Controls.Add(this.grpbCoils);
            this.tbpPallets.Controls.Add(this.grpbPaletInfo);
            this.tbpPallets.Controls.Add(this.grpbDestination);
            this.tbpPallets.Controls.Add(this.grpbPalletCode);
            this.tbpPallets.Location = new System.Drawing.Point(4, 34);
            this.tbpPallets.Name = "tbpPallets";
            this.tbpPallets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPallets.Size = new System.Drawing.Size(768, 602);
            this.tbpPallets.TabIndex = 1;
            this.tbpPallets.Text = "Pallets";
            this.tbpPallets.UseVisualStyleBackColor = true;
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.lblCoilCount);
            this.grpbCoils.Controls.Add(this.dgvCoils);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoils.Location = new System.Drawing.Point(3, 384);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(762, 217);
            this.grpbCoils.TabIndex = 3;
            this.grpbCoils.TabStop = false;
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(126, 13);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(511, 26);
            this.lblCoilCount.TabIndex = 1;
            this.lblCoilCount.Text = "Bobinas : -- / --";
            this.lblCoilCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCoils.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmCoilLength,
            this.clmCoilWidth,
            this.clmCoilWeigth});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCoils.Location = new System.Drawing.Point(3, 49);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCoils.Size = new System.Drawing.Size(756, 165);
            this.dgvCoils.TabIndex = 0;
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 260;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 140;
            // 
            // clmCoilWidth
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilWidth.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 140;
            // 
            // clmCoilWeigth
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilWeigth.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmCoilWeigth.HeaderText = "Peso";
            this.clmCoilWeigth.Name = "clmCoilWeigth";
            this.clmCoilWeigth.ReadOnly = true;
            this.clmCoilWeigth.Width = 140;
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.btnReturn);
            this.grpbPaletInfo.Controls.Add(this.lblDestination);
            this.grpbPaletInfo.Controls.Add(this.lblPalletType);
            this.grpbPaletInfo.Controls.Add(this.txtGrossWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblDestinationLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblGrossWeigth);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(3, 155);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(762, 229);
            this.grpbPaletInfo.TabIndex = 2;
            this.grpbPaletInfo.TabStop = false;
            // 
            // lblDestination
            // 
            this.lblDestination.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(206, 19);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(493, 29);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalletType
            // 
            this.lblPalletType.BackColor = System.Drawing.SystemColors.Window;
            this.lblPalletType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPalletType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletType.Location = new System.Drawing.Point(206, 55);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(493, 29);
            this.lblPalletType.TabIndex = 3;
            this.lblPalletType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGrossWeigth
            // 
            this.txtGrossWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.txtGrossWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossWeigth.Location = new System.Drawing.Point(411, 154);
            this.txtGrossWeigth.Name = "txtGrossWeigth";
            this.txtGrossWeigth.Size = new System.Drawing.Size(191, 63);
            this.txtGrossWeigth.TabIndex = 9;
            this.txtGrossWeigth.Tag = "clearOnReload";
            this.txtGrossWeigth.Text = "0.0";
            this.txtGrossWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(161, 154);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(191, 63);
            this.lblNetWeigth.TabIndex = 7;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0.0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(205, 126);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(103, 25);
            this.lblNetWeigthLabel.TabIndex = 6;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(63, 57);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(129, 25);
            this.lblPalletTypeLabel.TabIndex = 2;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblDestinationLabel
            // 
            this.lblDestinationLabel.AutoSize = true;
            this.lblDestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationLabel.Location = new System.Drawing.Point(63, 23);
            this.lblDestinationLabel.Name = "lblDestinationLabel";
            this.lblDestinationLabel.Size = new System.Drawing.Size(78, 25);
            this.lblDestinationLabel.TabIndex = 0;
            this.lblDestinationLabel.Text = "Destino";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(63, 93);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(90, 25);
            this.lblProductLabel.TabIndex = 4;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.SystemColors.Window;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(206, 91);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(493, 29);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrossWeigth
            // 
            this.lblGrossWeigth.AutoSize = true;
            this.lblGrossWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossWeigth.Location = new System.Drawing.Point(452, 126);
            this.lblGrossWeigth.Name = "lblGrossWeigth";
            this.lblGrossWeigth.Size = new System.Drawing.Size(108, 25);
            this.lblGrossWeigth.TabIndex = 8;
            this.lblGrossWeigth.Text = "Peso Bruto";
            // 
            // grpbDestination
            // 
            this.grpbDestination.Controls.Add(this.lblDestinationCellar);
            this.grpbDestination.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDestination.Location = new System.Drawing.Point(3, 77);
            this.grpbDestination.Name = "grpbDestination";
            this.grpbDestination.Size = new System.Drawing.Size(762, 78);
            this.grpbDestination.TabIndex = 1;
            this.grpbDestination.TabStop = false;
            // 
            // lblDestinationCellar
            // 
            this.lblDestinationCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDestinationCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCellar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDestinationCellar.Location = new System.Drawing.Point(3, 26);
            this.lblDestinationCellar.Name = "lblDestinationCellar";
            this.lblDestinationCellar.Size = new System.Drawing.Size(756, 49);
            this.lblDestinationCellar.TabIndex = 0;
            this.lblDestinationCellar.Text = "Bodega de producto terminado";
            this.lblDestinationCellar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbPalletCode
            // 
            this.grpbPalletCode.Controls.Add(this.txtPalletCode);
            this.grpbPalletCode.Controls.Add(this.lblPalletCode);
            this.grpbPalletCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletCode.Location = new System.Drawing.Point(3, 3);
            this.grpbPalletCode.Name = "grpbPalletCode";
            this.grpbPalletCode.Size = new System.Drawing.Size(762, 74);
            this.grpbPalletCode.TabIndex = 0;
            this.grpbPalletCode.TabStop = false;
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalletCode.Location = new System.Drawing.Point(293, 19);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(450, 45);
            this.txtPalletCode.TabIndex = 1;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(19, 22);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(268, 39);
            this.lblPalletCode.TabIndex = 0;
            this.lblPalletCode.Text = "Código de Pallet";
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "incomming arrow.png");
            this.imgLstIcons.Images.SetKeyName(1, "outgoing arrow.png");
            // 
            // btnReturn
            // 
            this.btnReturn.Image = global::BPS.Lite.Properties.Resources.back;
            this.btnReturn.Location = new System.Drawing.Point(705, 176);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(40, 40);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmCoilCellarMovements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(776, 640);
            this.Controls.Add(this.tbcMovements);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilCellarMovements";
            this.ShowInTaskbar = false;
            this.Text = "Movimientos de bodega";
            this.Load += new System.EventHandler(this.frmCoilCellarMovements_Load);
            this.tbcMovements.ResumeLayout(false);
            this.tbpMovementType.ResumeLayout(false);
            this.tbpMovementType.PerformLayout();
            this.tbpPallets.ResumeLayout(false);
            this.grpbCoils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.grpbDestination.ResumeLayout(false);
            this.grpbPalletCode.ResumeLayout(false);
            this.grpbPalletCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMovements;
        private System.Windows.Forms.TabPage tbpMovementType;
        private System.Windows.Forms.TextBox txtMovement;
        private System.Windows.Forms.Label lblMovement;
        private System.Windows.Forms.TabPage tbpPallets;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.Label lblCoilCount;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblPalletType;
        private System.Windows.Forms.Label txtGrossWeigth;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblDestinationLabel;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblGrossWeigth;
        private System.Windows.Forms.GroupBox grpbDestination;
        private System.Windows.Forms.Label lblDestinationCellar;
        private System.Windows.Forms.GroupBox grpbPalletCode;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.Button btnReturn;


    }
}