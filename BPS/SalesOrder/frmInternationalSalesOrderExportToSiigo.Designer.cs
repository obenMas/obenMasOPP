namespace BPS
{
    partial class frmInternationalSalesOrderExportToSiigo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInternationalSalesOrderExportToSiigo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvImportedPallets = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblImportedCoils = new System.Windows.Forms.Label();
            this.lblImportedCoilsLabel = new System.Windows.Forms.Label();
            this.lblImportedPallets = new System.Windows.Forms.Label();
            this.lblImportedPalletsLabel = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.ofdSiigo = new System.Windows.Forms.OpenFileDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.grpbDetails = new System.Windows.Forms.GroupBox();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMicrons = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIdentify = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescriptionII = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmComercialCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedPallets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpbDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.btnValidate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 513);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1106, 42);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // dgvImportedPallets
            // 
            this.dgvImportedPallets.AllowUserToAddRows = false;
            this.dgvImportedPallets.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportedPallets.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportedPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportedPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmNumber,
            this.clmProductDescription,
            this.clmDescription,
            this.clmName,
            this.clmQuantity,
            this.clmPrice,
            this.clmSubTotal,
            this.clmDate,
            this.clmfkEntity,
            this.clmMicrons,
            this.clmIdentify,
            this.clmReference,
            this.clmProductCode,
            this.clmDescriptionII,
            this.clmfkProduct,
            this.clmComercialCondition});
            this.dgvImportedPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportedPallets.Location = new System.Drawing.Point(3, 14);
            this.dgvImportedPallets.Name = "dgvImportedPallets";
            this.dgvImportedPallets.ReadOnly = true;
            this.dgvImportedPallets.RowHeadersWidth = 10;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportedPallets.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvImportedPallets.Size = new System.Drawing.Size(1100, 411);
            this.dgvImportedPallets.TabIndex = 3;
            this.dgvImportedPallets.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImportedPallets_CellDoubleClick);
            this.dgvImportedPallets.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvImportedPallets_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.lblImportedCoils);
            this.groupBox1.Controls.Add(this.lblImportedCoilsLabel);
            this.groupBox1.Controls.Add(this.lblImportedPallets);
            this.groupBox1.Controls.Add(this.lblImportedPalletsLabel);
            this.groupBox1.Controls.Add(this.lblFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo del Excel SIIGO";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(281, 17);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(541, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // lblImportedCoils
            // 
            this.lblImportedCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImportedCoils.Location = new System.Drawing.Point(535, 50);
            this.lblImportedCoils.Name = "lblImportedCoils";
            this.lblImportedCoils.Size = new System.Drawing.Size(59, 21);
            this.lblImportedCoils.TabIndex = 7;
            // 
            // lblImportedCoilsLabel
            // 
            this.lblImportedCoilsLabel.AutoSize = true;
            this.lblImportedCoilsLabel.Location = new System.Drawing.Point(412, 51);
            this.lblImportedCoilsLabel.Name = "lblImportedCoilsLabel";
            this.lblImportedCoilsLabel.Size = new System.Drawing.Size(117, 15);
            this.lblImportedCoilsLabel.TabIndex = 6;
            this.lblImportedCoilsLabel.Text = "Bobinas Importados";
            // 
            // lblImportedPallets
            // 
            this.lblImportedPallets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImportedPallets.Location = new System.Drawing.Point(347, 50);
            this.lblImportedPallets.Name = "lblImportedPallets";
            this.lblImportedPallets.Size = new System.Drawing.Size(59, 21);
            this.lblImportedPallets.TabIndex = 5;
            // 
            // lblImportedPalletsLabel
            // 
            this.lblImportedPalletsLabel.AutoSize = true;
            this.lblImportedPalletsLabel.Location = new System.Drawing.Point(232, 51);
            this.lblImportedPalletsLabel.Name = "lblImportedPalletsLabel";
            this.lblImportedPalletsLabel.Size = new System.Drawing.Size(109, 15);
            this.lblImportedPalletsLabel.TabIndex = 4;
            this.lblImportedPalletsLabel.Text = "Pallets Importados";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(229, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(46, 15);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Archivo";
            // 
            // ofdSiigo
            // 
            this.ofdSiigo.FileName = "openFileDialog1";
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::BPS.Properties.Resources.gear_16;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(714, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(24, 25);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // btnValidate
            // 
            this.btnValidate.BackgroundImage = global::BPS.Properties.Resources.quality;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(689, 12);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(24, 25);
            this.btnValidate.TabIndex = 4;
            this.btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::BPS.Properties.Resources.page_lightning;
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExecute.Location = new System.Drawing.Point(853, 15);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(25, 25);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::BPS.Properties.Resources.folder;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.Location = new System.Drawing.Point(828, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(25, 25);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // grpbDetails
            // 
            this.grpbDetails.Controls.Add(this.dgvImportedPallets);
            this.grpbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetails.Location = new System.Drawing.Point(0, 85);
            this.grpbDetails.Name = "grpbDetails";
            this.grpbDetails.Size = new System.Drawing.Size(1106, 428);
            this.grpbDetails.TabIndex = 6;
            this.grpbDetails.TabStop = false;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Visible = false;
            // 
            // clmNumber
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmNumber.HeaderText = "Orden";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 70;
            // 
            // clmProductDescription
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmProductDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmProductDescription.HeaderText = "Producto";
            this.clmProductDescription.Name = "clmProductDescription";
            this.clmProductDescription.ReadOnly = true;
            // 
            // clmDescription
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDescription.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmDescription.HeaderText = "Descripción";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 150;
            // 
            // clmName
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmName.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmName.HeaderText = "Cliente";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmQuantity
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmQuantity.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 65;
            // 
            // clmPrice
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmPrice.HeaderText = "V. Unitario";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 65;
            // 
            // clmSubTotal
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmSubTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmSubTotal.HeaderText = "Sub Total";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            this.clmSubTotal.Width = 55;
            // 
            // clmDate
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDate.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmDate.HeaderText = "F. Pedido";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 70;
            // 
            // clmfkEntity
            // 
            this.clmfkEntity.HeaderText = "fkEntity";
            this.clmfkEntity.Name = "clmfkEntity";
            this.clmfkEntity.ReadOnly = true;
            this.clmfkEntity.Visible = false;
            // 
            // clmMicrons
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmMicrons.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmMicrons.HeaderText = "Micras";
            this.clmMicrons.Name = "clmMicrons";
            this.clmMicrons.ReadOnly = true;
            this.clmMicrons.Visible = false;
            // 
            // clmIdentify
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmIdentify.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmIdentify.HeaderText = "Identificador";
            this.clmIdentify.Name = "clmIdentify";
            this.clmIdentify.ReadOnly = true;
            this.clmIdentify.Visible = false;
            this.clmIdentify.Width = 70;
            // 
            // clmReference
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmReference.DefaultCellStyle = dataGridViewCellStyle12;
            this.clmReference.HeaderText = "Referencia";
            this.clmReference.Name = "clmReference";
            this.clmReference.ReadOnly = true;
            this.clmReference.Visible = false;
            this.clmReference.Width = 120;
            // 
            // clmProductCode
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmProductCode.DefaultCellStyle = dataGridViewCellStyle13;
            this.clmProductCode.HeaderText = "Producto Code";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Visible = false;
            // 
            // clmDescriptionII
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmDescriptionII.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmDescriptionII.HeaderText = "DescripcionII";
            this.clmDescriptionII.Name = "clmDescriptionII";
            this.clmDescriptionII.ReadOnly = true;
            this.clmDescriptionII.Visible = false;
            // 
            // clmfkProduct
            // 
            this.clmfkProduct.HeaderText = "fkProduct";
            this.clmfkProduct.Name = "clmfkProduct";
            this.clmfkProduct.ReadOnly = true;
            this.clmfkProduct.Visible = false;
            // 
            // clmComercialCondition
            // 
            this.clmComercialCondition.HeaderText = "Condicion Comercial";
            this.clmComercialCondition.Name = "clmComercialCondition";
            this.clmComercialCondition.ReadOnly = true;
            this.clmComercialCondition.Width = 80;
            // 
            // frmInternationalSalesOrderExportToSiigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1106, 555);
            this.Controls.Add(this.grpbDetails);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInternationalSalesOrderExportToSiigo";
            this.Text = "Importación de Ordenes de Pedido desde el SIIGO";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedPallets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataGridView dgvImportedPallets;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblImportedCoils;
        private System.Windows.Forms.Label lblImportedCoilsLabel;
        private System.Windows.Forms.Label lblImportedPallets;
        private System.Windows.Forms.Label lblImportedPalletsLabel;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.OpenFileDialog ofdSiigo;
        private System.Windows.Forms.GroupBox grpbDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMicrons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdentify;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReference;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescriptionII;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmComercialCondition;
    }
}