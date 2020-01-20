namespace BPS.Raw
{
    partial class frmPalletDetailRawF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletDetailRawF));
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.lblStatusColor = new System.Windows.Forms.Label();
            this.grpbPalletsRegister = new System.Windows.Forms.GroupBox();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLot = new System.Windows.Forms.Label();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblTmP = new System.Windows.Forms.Label();
            this.lblNetWeigthLabel = new System.Windows.Forms.Label();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.btnPrintCoilsLabels = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.cmsPalletMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ttpPalletsRegistration = new System.Windows.Forms.ToolTip(this.components);
            this.grpbPallets.SuspendLayout();
            this.grpbPalletsRegister.SuspendLayout();
            this.grpbPaletInfo.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            this.cmsPalletMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.lblStatusColor);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbPallets.Location = new System.Drawing.Point(0, 0);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(10, 323);
            this.grpbPallets.TabIndex = 0;
            this.grpbPallets.TabStop = false;
            // 
            // lblStatusColor
            // 
            this.lblStatusColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStatusColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusColor.Location = new System.Drawing.Point(3, 17);
            this.lblStatusColor.Name = "lblStatusColor";
            this.lblStatusColor.Size = new System.Drawing.Size(4, 303);
            this.lblStatusColor.TabIndex = 3;
            // 
            // grpbPalletsRegister
            // 
            this.grpbPalletsRegister.Controls.Add(this.grpbPaletInfo);
            this.grpbPalletsRegister.Controls.Add(this.grpbCoils);
            this.grpbPalletsRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletsRegister.Location = new System.Drawing.Point(10, 0);
            this.grpbPalletsRegister.Name = "grpbPalletsRegister";
            this.grpbPalletsRegister.Size = new System.Drawing.Size(555, 323);
            this.grpbPalletsRegister.TabIndex = 0;
            this.grpbPalletsRegister.TabStop = false;
            this.grpbPalletsRegister.Text = "Pallets";
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.label2);
            this.grpbPaletInfo.Controls.Add(this.lblLot);
            this.grpbPaletInfo.Controls.Add(this.txtPalletCode);
            this.grpbPaletInfo.Controls.Add(this.lblTmP);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigthLabel);
            this.grpbPaletInfo.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblCodeLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProductLabel);
            this.grpbPaletInfo.Controls.Add(this.lblProduct);
            this.grpbPaletInfo.Controls.Add(this.lblNetWeigth);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(3, 17);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(549, 231);
            this.grpbPaletInfo.TabIndex = 0;
            this.grpbPaletInfo.TabStop = false;
            this.grpbPaletInfo.Text = "Información de pallet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lote";
            // 
            // lblLot
            // 
            this.lblLot.BackColor = System.Drawing.SystemColors.Window;
            this.lblLot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLot.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLot.Location = new System.Drawing.Point(81, 102);
            this.lblLot.Name = "lblLot";
            this.lblLot.Size = new System.Drawing.Size(455, 21);
            this.lblLot.TabIndex = 18;
            this.lblLot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Location = new System.Drawing.Point(81, 19);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(455, 26);
            this.txtPalletCode.TabIndex = 1;
            // 
            // lblTmP
            // 
            this.lblTmP.BackColor = System.Drawing.SystemColors.Window;
            this.lblTmP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTmP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTmP.Location = new System.Drawing.Point(81, 49);
            this.lblTmP.Name = "lblTmP";
            this.lblTmP.Size = new System.Drawing.Size(455, 21);
            this.lblTmP.TabIndex = 4;
            this.lblTmP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNetWeigthLabel
            // 
            this.lblNetWeigthLabel.AutoSize = true;
            this.lblNetWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigthLabel.Location = new System.Drawing.Point(215, 129);
            this.lblNetWeigthLabel.Name = "lblNetWeigthLabel";
            this.lblNetWeigthLabel.Size = new System.Drawing.Size(83, 20);
            this.lblNetWeigthLabel.TabIndex = 12;
            this.lblNetWeigthLabel.Text = "Peso Neto";
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(10, 49);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(66, 20);
            this.lblPalletTypeLabel.TabIndex = 3;
            this.lblPalletTypeLabel.Text = "Tipo MP";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(17, 22);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(59, 20);
            this.lblCodeLabel.TabIndex = 0;
            this.lblCodeLabel.Text = "Código";
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(3, 76);
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
            this.lblProduct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblProduct.Location = new System.Drawing.Point(81, 76);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(455, 21);
            this.lblProduct.TabIndex = 11;
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BackColor = System.Drawing.SystemColors.Window;
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.Location = new System.Drawing.Point(159, 154);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(231, 63);
            this.lblNetWeigth.TabIndex = 13;
            this.lblNetWeigth.Tag = "clearOnReload";
            this.lblNetWeigth.Text = "0.0";
            this.lblNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.btnPrintCoilsLabels);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbCoils.Location = new System.Drawing.Point(3, 248);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(549, 72);
            this.grpbCoils.TabIndex = 1;
            this.grpbCoils.TabStop = false;
            // 
            // btnPrintCoilsLabels
            // 
            this.btnPrintCoilsLabels.Image = global::BPS.Properties.Resources.printer;
            this.btnPrintCoilsLabels.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrintCoilsLabels.Location = new System.Drawing.Point(241, 15);
            this.btnPrintCoilsLabels.Name = "btnPrintCoilsLabels";
            this.btnPrintCoilsLabels.Size = new System.Drawing.Size(67, 51);
            this.btnPrintCoilsLabels.TabIndex = 5;
            this.btnPrintCoilsLabels.Text = "Imprimir MP\r\n";
            this.btnPrintCoilsLabels.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintCoilsLabels.UseVisualStyleBackColor = true;
            this.btnPrintCoilsLabels.Click += new System.EventHandler(this.btnPrintCoilsLabels_Click);
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
            // frmPalletDetailRawF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(565, 323);
            this.Controls.Add(this.grpbPalletsRegister);
            this.Controls.Add(this.grpbPallets);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletDetailRawF";
            this.Text = "Detalle Pallet Materia Prima";
            this.grpbPallets.ResumeLayout(false);
            this.grpbPalletsRegister.ResumeLayout(false);
            this.grpbPaletInfo.ResumeLayout(false);
            this.grpbPaletInfo.PerformLayout();
            this.grpbCoils.ResumeLayout(false);
            this.cmsPalletMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPallets;
        private System.Windows.Forms.GroupBox grpbPalletsRegister;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblTmP;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblNetWeigthLabel;
        private System.Windows.Forms.ContextMenuStrip cmsPalletMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.ToolTip ttpPalletsRegistration;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Button btnPrintCoilsLabels;
        private System.Windows.Forms.Label lblStatusColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLot;
    }
}