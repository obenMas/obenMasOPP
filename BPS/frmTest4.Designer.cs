namespace BPS
{
    partial class frmTest4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpPallet = new System.Windows.Forms.TabPage();
            this.grpbCoils = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.grpbPalletInformation = new System.Windows.Forms.GroupBox();
            this.lblSystemWeigth = new System.Windows.Forms.Label();
            this.lblSystemCore = new System.Windows.Forms.Label();
            this.lblImportedWeigth = new System.Windows.Forms.Label();
            this.lblSystemDiameter = new System.Windows.Forms.Label();
            this.lblImportedCore = new System.Windows.Forms.Label();
            this.lblSystemThickness = new System.Windows.Forms.Label();
            this.lblSystemWidth = new System.Windows.Forms.Label();
            this.lblImportedLabel = new System.Windows.Forms.Label();
            this.lblWeigthLabel = new System.Windows.Forms.Label();
            this.lblImportedThickness = new System.Windows.Forms.Label();
            this.lblCoreLabel = new System.Windows.Forms.Label();
            this.lblImportedWidth = new System.Windows.Forms.Label();
            this.lblDiameterLabel = new System.Windows.Forms.Label();
            this.lblThicknessLabel = new System.Windows.Forms.Label();
            this.lblWidthLabel = new System.Windows.Forms.Label();
            this.cmbPalletDimention = new System.Windows.Forms.ComboBox();
            this.cmbPalletType = new System.Windows.Forms.ComboBox();
            this.cmbSystemProduct = new System.Windows.Forms.ComboBox();
            this.lblPalletTypeLabel = new System.Windows.Forms.Label();
            this.lblImportedProduct = new System.Windows.Forms.Label();
            this.lblSystemCode = new System.Windows.Forms.Label();
            this.lblImportedCode = new System.Windows.Forms.Label();
            this.lblProductLabel = new System.Windows.Forms.Label();
            this.lblCodeLabel = new System.Windows.Forms.Label();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbpPallet.SuspendLayout();
            this.grpbCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.grpbPalletInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPallet);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpPallet
            // 
            this.tbpPallet.Controls.Add(this.grpbCoils);
            this.tbpPallet.Controls.Add(this.grpbPalletInformation);
            this.tbpPallet.Location = new System.Drawing.Point(4, 24);
            this.tbpPallet.Name = "tbpPallet";
            this.tbpPallet.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPallet.Size = new System.Drawing.Size(777, 384);
            this.tbpPallet.TabIndex = 0;
            this.tbpPallet.Text = "CCOO250670-N6";
            this.tbpPallet.UseVisualStyleBackColor = true;
            // 
            // grpbCoils
            // 
            this.grpbCoils.Controls.Add(this.dgvCoils);
            this.grpbCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoils.Location = new System.Drawing.Point(3, 213);
            this.grpbCoils.Name = "grpbCoils";
            this.grpbCoils.Size = new System.Drawing.Size(771, 168);
            this.grpbCoils.TabIndex = 1;
            this.grpbCoils.TabStop = false;
            this.grpbCoils.Text = "Bobinas";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.AllowUserToDeleteRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCode,
            this.clmCreatedDate,
            this.clmLength,
            this.clmDiameter,
            this.clmDensity,
            this.clmGrossWeigth,
            this.clmNetWeigth});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(765, 148);
            this.dgvCoils.TabIndex = 0;
            // 
            // grpbPalletInformation
            // 
            this.grpbPalletInformation.Controls.Add(this.lblSystemWeigth);
            this.grpbPalletInformation.Controls.Add(this.lblSystemCore);
            this.grpbPalletInformation.Controls.Add(this.lblImportedWeigth);
            this.grpbPalletInformation.Controls.Add(this.lblSystemDiameter);
            this.grpbPalletInformation.Controls.Add(this.lblImportedCore);
            this.grpbPalletInformation.Controls.Add(this.lblSystemThickness);
            this.grpbPalletInformation.Controls.Add(this.lblSystemWidth);
            this.grpbPalletInformation.Controls.Add(this.lblImportedLabel);
            this.grpbPalletInformation.Controls.Add(this.lblWeigthLabel);
            this.grpbPalletInformation.Controls.Add(this.lblImportedThickness);
            this.grpbPalletInformation.Controls.Add(this.lblCoreLabel);
            this.grpbPalletInformation.Controls.Add(this.lblImportedWidth);
            this.grpbPalletInformation.Controls.Add(this.lblDiameterLabel);
            this.grpbPalletInformation.Controls.Add(this.lblThicknessLabel);
            this.grpbPalletInformation.Controls.Add(this.lblWidthLabel);
            this.grpbPalletInformation.Controls.Add(this.cmbPalletDimention);
            this.grpbPalletInformation.Controls.Add(this.cmbPalletType);
            this.grpbPalletInformation.Controls.Add(this.cmbSystemProduct);
            this.grpbPalletInformation.Controls.Add(this.lblPalletTypeLabel);
            this.grpbPalletInformation.Controls.Add(this.lblImportedProduct);
            this.grpbPalletInformation.Controls.Add(this.lblSystemCode);
            this.grpbPalletInformation.Controls.Add(this.lblImportedCode);
            this.grpbPalletInformation.Controls.Add(this.lblProductLabel);
            this.grpbPalletInformation.Controls.Add(this.lblCodeLabel);
            this.grpbPalletInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletInformation.Location = new System.Drawing.Point(3, 3);
            this.grpbPalletInformation.Name = "grpbPalletInformation";
            this.grpbPalletInformation.Size = new System.Drawing.Size(771, 210);
            this.grpbPalletInformation.TabIndex = 0;
            this.grpbPalletInformation.TabStop = false;
            this.grpbPalletInformation.Text = "Información de Pallet";
            // 
            // lblSystemWeigth
            // 
            this.lblSystemWeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemWeigth.Location = new System.Drawing.Point(534, 135);
            this.lblSystemWeigth.Name = "lblSystemWeigth";
            this.lblSystemWeigth.Size = new System.Drawing.Size(85, 21);
            this.lblSystemWeigth.TabIndex = 12;
            // 
            // lblSystemCore
            // 
            this.lblSystemCore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemCore.Location = new System.Drawing.Point(439, 135);
            this.lblSystemCore.Name = "lblSystemCore";
            this.lblSystemCore.Size = new System.Drawing.Size(85, 21);
            this.lblSystemCore.TabIndex = 11;
            // 
            // lblImportedWeigth
            // 
            this.lblImportedWeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedWeigth.Location = new System.Drawing.Point(534, 108);
            this.lblImportedWeigth.Name = "lblImportedWeigth";
            this.lblImportedWeigth.Size = new System.Drawing.Size(85, 21);
            this.lblImportedWeigth.TabIndex = 10;
            // 
            // lblSystemDiameter
            // 
            this.lblSystemDiameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemDiameter.Location = new System.Drawing.Point(344, 135);
            this.lblSystemDiameter.Name = "lblSystemDiameter";
            this.lblSystemDiameter.Size = new System.Drawing.Size(85, 21);
            this.lblSystemDiameter.TabIndex = 13;
            // 
            // lblImportedCore
            // 
            this.lblImportedCore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedCore.Location = new System.Drawing.Point(439, 108);
            this.lblImportedCore.Name = "lblImportedCore";
            this.lblImportedCore.Size = new System.Drawing.Size(85, 21);
            this.lblImportedCore.TabIndex = 16;
            // 
            // lblSystemThickness
            // 
            this.lblSystemThickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemThickness.Location = new System.Drawing.Point(249, 135);
            this.lblSystemThickness.Name = "lblSystemThickness";
            this.lblSystemThickness.Size = new System.Drawing.Size(85, 21);
            this.lblSystemThickness.TabIndex = 15;
            // 
            // lblSystemWidth
            // 
            this.lblSystemWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemWidth.Location = new System.Drawing.Point(154, 135);
            this.lblSystemWidth.Name = "lblSystemWidth";
            this.lblSystemWidth.Size = new System.Drawing.Size(85, 21);
            this.lblSystemWidth.TabIndex = 14;
            // 
            // lblImportedLabel
            // 
            this.lblImportedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedLabel.Location = new System.Drawing.Point(344, 108);
            this.lblImportedLabel.Name = "lblImportedLabel";
            this.lblImportedLabel.Size = new System.Drawing.Size(85, 21);
            this.lblImportedLabel.TabIndex = 9;
            // 
            // lblWeigthLabel
            // 
            this.lblWeigthLabel.AutoSize = true;
            this.lblWeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeigthLabel.Location = new System.Drawing.Point(531, 87);
            this.lblWeigthLabel.Name = "lblWeigthLabel";
            this.lblWeigthLabel.Size = new System.Drawing.Size(39, 15);
            this.lblWeigthLabel.TabIndex = 4;
            this.lblWeigthLabel.Text = "Peso";
            // 
            // lblImportedThickness
            // 
            this.lblImportedThickness.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedThickness.Location = new System.Drawing.Point(249, 108);
            this.lblImportedThickness.Name = "lblImportedThickness";
            this.lblImportedThickness.Size = new System.Drawing.Size(85, 21);
            this.lblImportedThickness.TabIndex = 3;
            // 
            // lblCoreLabel
            // 
            this.lblCoreLabel.AutoSize = true;
            this.lblCoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoreLabel.Location = new System.Drawing.Point(436, 87);
            this.lblCoreLabel.Name = "lblCoreLabel";
            this.lblCoreLabel.Size = new System.Drawing.Size(37, 15);
            this.lblCoreLabel.TabIndex = 2;
            this.lblCoreLabel.Text = "Core";
            // 
            // lblImportedWidth
            // 
            this.lblImportedWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedWidth.Location = new System.Drawing.Point(154, 108);
            this.lblImportedWidth.Name = "lblImportedWidth";
            this.lblImportedWidth.Size = new System.Drawing.Size(85, 21);
            this.lblImportedWidth.TabIndex = 5;
            // 
            // lblDiameterLabel
            // 
            this.lblDiameterLabel.AutoSize = true;
            this.lblDiameterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameterLabel.Location = new System.Drawing.Point(341, 87);
            this.lblDiameterLabel.Name = "lblDiameterLabel";
            this.lblDiameterLabel.Size = new System.Drawing.Size(66, 15);
            this.lblDiameterLabel.TabIndex = 8;
            this.lblDiameterLabel.Text = "Diametro";
            // 
            // lblThicknessLabel
            // 
            this.lblThicknessLabel.AutoSize = true;
            this.lblThicknessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThicknessLabel.Location = new System.Drawing.Point(246, 87);
            this.lblThicknessLabel.Name = "lblThicknessLabel";
            this.lblThicknessLabel.Size = new System.Drawing.Size(59, 15);
            this.lblThicknessLabel.TabIndex = 7;
            this.lblThicknessLabel.Text = "Espesor";
            // 
            // lblWidthLabel
            // 
            this.lblWidthLabel.AutoSize = true;
            this.lblWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthLabel.Location = new System.Drawing.Point(151, 87);
            this.lblWidthLabel.Name = "lblWidthLabel";
            this.lblWidthLabel.Size = new System.Drawing.Size(46, 15);
            this.lblWidthLabel.TabIndex = 6;
            this.lblWidthLabel.Text = "Ancho";
            // 
            // cmbPalletDimention
            // 
            this.cmbPalletDimention.FormattingEnabled = true;
            this.cmbPalletDimention.Location = new System.Drawing.Point(505, 180);
            this.cmbPalletDimention.Name = "cmbPalletDimention";
            this.cmbPalletDimention.Size = new System.Drawing.Size(115, 23);
            this.cmbPalletDimention.TabIndex = 1;
            // 
            // cmbPalletType
            // 
            this.cmbPalletType.FormattingEnabled = true;
            this.cmbPalletType.Location = new System.Drawing.Point(154, 180);
            this.cmbPalletType.Name = "cmbPalletType";
            this.cmbPalletType.Size = new System.Drawing.Size(345, 23);
            this.cmbPalletType.TabIndex = 1;
            // 
            // cmbSystemProduct
            // 
            this.cmbSystemProduct.FormattingEnabled = true;
            this.cmbSystemProduct.Location = new System.Drawing.Point(315, 61);
            this.cmbSystemProduct.Name = "cmbSystemProduct";
            this.cmbSystemProduct.Size = new System.Drawing.Size(305, 23);
            this.cmbSystemProduct.TabIndex = 1;
            // 
            // lblPalletTypeLabel
            // 
            this.lblPalletTypeLabel.AutoSize = true;
            this.lblPalletTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletTypeLabel.Location = new System.Drawing.Point(151, 159);
            this.lblPalletTypeLabel.Name = "lblPalletTypeLabel";
            this.lblPalletTypeLabel.Size = new System.Drawing.Size(95, 15);
            this.lblPalletTypeLabel.TabIndex = 0;
            this.lblPalletTypeLabel.Text = "Tipo de pallet";
            // 
            // lblImportedProduct
            // 
            this.lblImportedProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedProduct.Location = new System.Drawing.Point(315, 36);
            this.lblImportedProduct.Name = "lblImportedProduct";
            this.lblImportedProduct.Size = new System.Drawing.Size(305, 21);
            this.lblImportedProduct.TabIndex = 0;
            // 
            // lblSystemCode
            // 
            this.lblSystemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSystemCode.Location = new System.Drawing.Point(154, 63);
            this.lblSystemCode.Name = "lblSystemCode";
            this.lblSystemCode.Size = new System.Drawing.Size(150, 21);
            this.lblSystemCode.TabIndex = 0;
            // 
            // lblImportedCode
            // 
            this.lblImportedCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImportedCode.Location = new System.Drawing.Point(154, 36);
            this.lblImportedCode.Name = "lblImportedCode";
            this.lblImportedCode.Size = new System.Drawing.Size(150, 21);
            this.lblImportedCode.TabIndex = 0;
            // 
            // lblProductLabel
            // 
            this.lblProductLabel.AutoSize = true;
            this.lblProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductLabel.Location = new System.Drawing.Point(312, 18);
            this.lblProductLabel.Name = "lblProductLabel";
            this.lblProductLabel.Size = new System.Drawing.Size(64, 15);
            this.lblProductLabel.TabIndex = 0;
            this.lblProductLabel.Text = "Producto";
            // 
            // lblCodeLabel
            // 
            this.lblCodeLabel.AutoSize = true;
            this.lblCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeLabel.Location = new System.Drawing.Point(151, 18);
            this.lblCodeLabel.Name = "lblCodeLabel";
            this.lblCodeLabel.Size = new System.Drawing.Size(52, 15);
            this.lblCodeLabel.TabIndex = 0;
            this.lblCodeLabel.Text = "Código";
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.HeaderText = "Fabricado";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.ReadOnly = true;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diámetro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            // 
            // clmDensity
            // 
            this.clmDensity.HeaderText = "Densidad";
            this.clmDensity.Name = "clmDensity";
            this.clmDensity.ReadOnly = true;
            // 
            // clmGrossWeigth
            // 
            this.clmGrossWeigth.HeaderText = "Peso Bruto";
            this.clmGrossWeigth.Name = "clmGrossWeigth";
            this.clmGrossWeigth.ReadOnly = true;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.ReadOnly = true;
            // 
            // frmTest4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 412);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTest4";
            this.Text = "frmTest4";
            this.Load += new System.EventHandler(this.frmTest4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpPallet.ResumeLayout(false);
            this.grpbCoils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.grpbPalletInformation.ResumeLayout(false);
            this.grpbPalletInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpPallet;
        private System.Windows.Forms.GroupBox grpbCoils;
        private System.Windows.Forms.GroupBox grpbPalletInformation;
        private System.Windows.Forms.Label lblSystemCode;
        private System.Windows.Forms.Label lblImportedCode;
        private System.Windows.Forms.ComboBox cmbPalletType;
        private System.Windows.Forms.ComboBox cmbSystemProduct;
        private System.Windows.Forms.Label lblPalletTypeLabel;
        private System.Windows.Forms.Label lblImportedProduct;
        private System.Windows.Forms.Label lblProductLabel;
        private System.Windows.Forms.Label lblCodeLabel;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.Label lblSystemWeigth;
        private System.Windows.Forms.Label lblSystemCore;
        private System.Windows.Forms.Label lblImportedWeigth;
        private System.Windows.Forms.Label lblSystemDiameter;
        private System.Windows.Forms.Label lblImportedCore;
        private System.Windows.Forms.Label lblSystemThickness;
        private System.Windows.Forms.Label lblSystemWidth;
        private System.Windows.Forms.Label lblImportedLabel;
        private System.Windows.Forms.Label lblWeigthLabel;
        private System.Windows.Forms.Label lblImportedThickness;
        private System.Windows.Forms.Label lblCoreLabel;
        private System.Windows.Forms.Label lblImportedWidth;
        private System.Windows.Forms.Label lblDiameterLabel;
        private System.Windows.Forms.Label lblThicknessLabel;
        private System.Windows.Forms.Label lblWidthLabel;
        private System.Windows.Forms.ComboBox cmbPalletDimention;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
    }
}