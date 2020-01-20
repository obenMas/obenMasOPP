namespace BPS.Lite
{
    partial class frmAddNewPalletType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewPalletType));
            this.chkSingleFace = new System.Windows.Forms.CheckBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbDimentions = new System.Windows.Forms.ComboBox();
            this.cmbPalletType = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDimention = new System.Windows.Forms.Label();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnAddPallet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.grpbPalletInfo = new System.Windows.Forms.GroupBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCuttingOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.ttpStockPallet = new System.Windows.Forms.ToolTip(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.grpbActions.SuspendLayout();
            this.grpbPalletInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkSingleFace
            // 
            this.chkSingleFace.AutoSize = true;
            this.chkSingleFace.Location = new System.Drawing.Point(786, 50);
            this.chkSingleFace.Name = "chkSingleFace";
            this.chkSingleFace.Size = new System.Drawing.Size(91, 19);
            this.chkSingleFace.TabIndex = 11;
            this.chkSingleFace.Text = "Single Face";
            this.chkSingleFace.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(681, 49);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 21);
            this.txtQuantity.TabIndex = 10;
            // 
            // cmbDimentions
            // 
            this.cmbDimentions.FormattingEnabled = true;
            this.cmbDimentions.Location = new System.Drawing.Point(485, 48);
            this.cmbDimentions.Name = "cmbDimentions";
            this.cmbDimentions.Size = new System.Drawing.Size(128, 23);
            this.cmbDimentions.TabIndex = 8;
            this.cmbDimentions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDimentions_KeyDown);
            // 
            // cmbPalletType
            // 
            this.cmbPalletType.FormattingEnabled = true;
            this.cmbPalletType.Location = new System.Drawing.Point(166, 48);
            this.cmbPalletType.Name = "cmbPalletType";
            this.cmbPalletType.Size = new System.Drawing.Size(226, 23);
            this.cmbPalletType.TabIndex = 6;
            this.cmbPalletType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPalletType_KeyDown);
            this.cmbPalletType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPalletType_KeyPress);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(619, 52);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(56, 15);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Cantidad";
            // 
            // lblDimention
            // 
            this.lblDimention.AutoSize = true;
            this.lblDimention.Location = new System.Drawing.Point(398, 52);
            this.lblDimention.Name = "lblDimention";
            this.lblDimention.Size = new System.Drawing.Size(80, 15);
            this.lblDimention.TabIndex = 7;
            this.lblDimention.Text = "Dimensiones";
            // 
            // lblPalletType
            // 
            this.lblPalletType.AutoSize = true;
            this.lblPalletType.Location = new System.Drawing.Point(12, 52);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(81, 15);
            this.lblPalletType.TabIndex = 4;
            this.lblPalletType.Text = "Tipo de pallet";
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnAddPallet);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(830, 107);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(59, 43);
            this.grpbActions.TabIndex = 2;
            this.grpbActions.TabStop = false;
            // 
            // btnAddPallet
            // 
            this.btnAddPallet.BackgroundImage = global::BPS.Lite.Properties.Resources.add1;
            this.btnAddPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPallet.Location = new System.Drawing.Point(4, 13);
            this.btnAddPallet.Name = "btnAddPallet";
            this.btnAddPallet.Size = new System.Drawing.Size(25, 25);
            this.btnAddPallet.TabIndex = 0;
            this.ttpStockPallet.SetToolTip(this.btnAddPallet, "Agregar Pallet");
            this.btnAddPallet.UseVisualStyleBackColor = true;
            this.btnAddPallet.Click += new System.EventHandler(this.btnAddPallet_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Lite.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(29, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 1;
            this.ttpStockPallet.SetToolTip(this.btnClose, "Cancelar Pallet");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(0, 107);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(826, 43);
            this.grpbFilters.TabIndex = 1;
            this.grpbFilters.TabStop = false;
            // 
            // grpbPalletInfo
            // 
            this.grpbPalletInfo.Controls.Add(this.txtCode);
            this.grpbPalletInfo.Controls.Add(this.cmbTransport);
            this.grpbPalletInfo.Controls.Add(this.lblTransport);
            this.grpbPalletInfo.Controls.Add(this.lblProductName);
            this.grpbPalletInfo.Controls.Add(this.lblNumber);
            this.grpbPalletInfo.Controls.Add(this.lblCuttingOrderNumberLabel);
            this.grpbPalletInfo.Controls.Add(this.lblPalletType);
            this.grpbPalletInfo.Controls.Add(this.lblProduct);
            this.grpbPalletInfo.Controls.Add(this.lblDimention);
            this.grpbPalletInfo.Controls.Add(this.lblQuantity);
            this.grpbPalletInfo.Controls.Add(this.chkSingleFace);
            this.grpbPalletInfo.Controls.Add(this.cmbPalletType);
            this.grpbPalletInfo.Controls.Add(this.txtQuantity);
            this.grpbPalletInfo.Controls.Add(this.cmbDimentions);
            this.grpbPalletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbPalletInfo.Name = "grpbPalletInfo";
            this.grpbPalletInfo.Size = new System.Drawing.Size(889, 110);
            this.grpbPalletInfo.TabIndex = 0;
            this.grpbPalletInfo.TabStop = false;
            // 
            // cmbTransport
            // 
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(99, 79);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(778, 23);
            this.cmbTransport.TabIndex = 13;
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(12, 82);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(66, 15);
            this.lblTransport.TabIndex = 12;
            this.lblTransport.Text = "Transporte";
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.Window;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductName.Location = new System.Drawing.Point(334, 17);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(543, 21);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Tag = "clearOnReload";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(154, 17);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 21);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Tag = "clearOnReload";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuttingOrderNumberLabel
            // 
            this.lblCuttingOrderNumberLabel.AutoSize = true;
            this.lblCuttingOrderNumberLabel.Location = new System.Drawing.Point(12, 20);
            this.lblCuttingOrderNumberLabel.Name = "lblCuttingOrderNumberLabel";
            this.lblCuttingOrderNumberLabel.Size = new System.Drawing.Size(136, 15);
            this.lblCuttingOrderNumberLabel.TabIndex = 0;
            this.lblCuttingOrderNumberLabel.Text = "Orden de venta número";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(272, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(56, 15);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Producto";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(99, 49);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(61, 21);
            this.txtCode.TabIndex = 5;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // frmAddNewPalletType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(889, 153);
            this.Controls.Add(this.grpbPalletInfo);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddNewPalletType";
            this.ShowInTaskbar = false;
            this.Text = "Agregar tipo de pallet";
            this.Load += new System.EventHandler(this.frmAddNewStockPallet_Load);
            this.grpbActions.ResumeLayout(false);
            this.grpbPalletInfo.ResumeLayout(false);
            this.grpbPalletInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSingleFace;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbDimentions;
        private System.Windows.Forms.ComboBox cmbPalletType;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDimention;
        private System.Windows.Forms.Label lblPalletType;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbPalletInfo;
        private System.Windows.Forms.Button btnAddPallet;
        private System.Windows.Forms.Label lblCuttingOrderNumberLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ToolTip ttpStockPallet;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.TextBox txtCode;
    }
}