namespace BPS
{
    partial class frmPalletCoilTransferForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletCoilTransferForm));
            this.grpbTransferInfo = new System.Windows.Forms.GroupBox();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblSenderLabel = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblDestinationCellarLabel = new System.Windows.Forms.Label();
            this.lblOriginCellarLabel = new System.Windows.Forms.Label();
            this.lblDestinationCellar = new System.Windows.Forms.Label();
            this.lblOriginCellar = new System.Windows.Forms.Label();
            this.grpbIncomingDetail = new System.Windows.Forms.GroupBox();
            this.grpbITCoilsDetail = new System.Windows.Forms.GroupBox();
            this.dgvITDCoils = new System.Windows.Forms.DataGridView();
            this.clmITDCCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDCProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbITPalletsDetail = new System.Windows.Forms.GroupBox();
            this.dgvITDPallets = new System.Windows.Forms.DataGridView();
            this.clmITDPCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmITDPCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmptyCoils = new System.Windows.Forms.GroupBox();
            this.grpbTransferActionsCoils = new System.Windows.Forms.GroupBox();
            this.btnCancelTransferCoils = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransferCoils = new System.Windows.Forms.Button();
            this.ttpPalletCoilTransfer = new System.Windows.Forms.ToolTip(this.components);
            this.grpbTransferInfo.SuspendLayout();
            this.grpbIncomingDetail.SuspendLayout();
            this.grpbITCoilsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDCoils)).BeginInit();
            this.grpbITPalletsDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDPallets)).BeginInit();
            this.grpbTransferActionsCoils.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbTransferInfo
            // 
            this.grpbTransferInfo.Controls.Add(this.lblDateLabel);
            this.grpbTransferInfo.Controls.Add(this.lblSenderLabel);
            this.grpbTransferInfo.Controls.Add(this.lblDate);
            this.grpbTransferInfo.Controls.Add(this.lblSender);
            this.grpbTransferInfo.Controls.Add(this.lblDestinationCellarLabel);
            this.grpbTransferInfo.Controls.Add(this.lblOriginCellarLabel);
            this.grpbTransferInfo.Controls.Add(this.lblDestinationCellar);
            this.grpbTransferInfo.Controls.Add(this.lblOriginCellar);
            this.grpbTransferInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTransferInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbTransferInfo.Name = "grpbTransferInfo";
            this.grpbTransferInfo.Size = new System.Drawing.Size(723, 81);
            this.grpbTransferInfo.TabIndex = 0;
            this.grpbTransferInfo.TabStop = false;
            this.grpbTransferInfo.Text = "Información de transferencia";
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(352, 52);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDateLabel.TabIndex = 64;
            this.lblDateLabel.Text = "Fecha";
            // 
            // lblSenderLabel
            // 
            this.lblSenderLabel.AutoSize = true;
            this.lblSenderLabel.Location = new System.Drawing.Point(352, 23);
            this.lblSenderLabel.Name = "lblSenderLabel";
            this.lblSenderLabel.Size = new System.Drawing.Size(72, 15);
            this.lblSenderLabel.TabIndex = 65;
            this.lblSenderLabel.Text = "Enviado por";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.Window;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(431, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(237, 21);
            this.lblDate.TabIndex = 3;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSender
            // 
            this.lblSender.BackColor = System.Drawing.SystemColors.Window;
            this.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(431, 20);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(237, 21);
            this.lblSender.TabIndex = 1;
            this.lblSender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDestinationCellarLabel
            // 
            this.lblDestinationCellarLabel.AutoSize = true;
            this.lblDestinationCellarLabel.Location = new System.Drawing.Point(54, 52);
            this.lblDestinationCellarLabel.Name = "lblDestinationCellarLabel";
            this.lblDestinationCellarLabel.Size = new System.Drawing.Size(49, 15);
            this.lblDestinationCellarLabel.TabIndex = 60;
            this.lblDestinationCellarLabel.Text = "Destino";
            // 
            // lblOriginCellarLabel
            // 
            this.lblOriginCellarLabel.AutoSize = true;
            this.lblOriginCellarLabel.Location = new System.Drawing.Point(54, 23);
            this.lblOriginCellarLabel.Name = "lblOriginCellarLabel";
            this.lblOriginCellarLabel.Size = new System.Drawing.Size(44, 15);
            this.lblOriginCellarLabel.TabIndex = 61;
            this.lblOriginCellarLabel.Text = "Origen";
            // 
            // lblDestinationCellar
            // 
            this.lblDestinationCellar.BackColor = System.Drawing.SystemColors.Window;
            this.lblDestinationCellar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDestinationCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCellar.Location = new System.Drawing.Point(109, 49);
            this.lblDestinationCellar.Name = "lblDestinationCellar";
            this.lblDestinationCellar.Size = new System.Drawing.Size(237, 21);
            this.lblDestinationCellar.TabIndex = 2;
            this.lblDestinationCellar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOriginCellar
            // 
            this.lblOriginCellar.BackColor = System.Drawing.SystemColors.Window;
            this.lblOriginCellar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOriginCellar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginCellar.Location = new System.Drawing.Point(109, 20);
            this.lblOriginCellar.Name = "lblOriginCellar";
            this.lblOriginCellar.Size = new System.Drawing.Size(237, 21);
            this.lblOriginCellar.TabIndex = 0;
            this.lblOriginCellar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbIncomingDetail
            // 
            this.grpbIncomingDetail.Controls.Add(this.grpbITCoilsDetail);
            this.grpbIncomingDetail.Controls.Add(this.grpbITPalletsDetail);
            this.grpbIncomingDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbIncomingDetail.Location = new System.Drawing.Point(0, 81);
            this.grpbIncomingDetail.Name = "grpbIncomingDetail";
            this.grpbIncomingDetail.Size = new System.Drawing.Size(723, 372);
            this.grpbIncomingDetail.TabIndex = 1;
            this.grpbIncomingDetail.TabStop = false;
            this.grpbIncomingDetail.Text = "Detalle de Transferencia";
            // 
            // grpbITCoilsDetail
            // 
            this.grpbITCoilsDetail.Controls.Add(this.dgvITDCoils);
            this.grpbITCoilsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbITCoilsDetail.Location = new System.Drawing.Point(3, 193);
            this.grpbITCoilsDetail.Name = "grpbITCoilsDetail";
            this.grpbITCoilsDetail.Size = new System.Drawing.Size(717, 176);
            this.grpbITCoilsDetail.TabIndex = 1;
            this.grpbITCoilsDetail.TabStop = false;
            this.grpbITCoilsDetail.Text = "Bobinas";
            // 
            // dgvITDCoils
            // 
            this.dgvITDCoils.AllowUserToAddRows = false;
            this.dgvITDCoils.AllowUserToDeleteRows = false;
            this.dgvITDCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvITDCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmITDCCodsec,
            this.clmITDCCode,
            this.clmITDCCustomer,
            this.clmITDCSalesOrderNumber,
            this.clmITDCProduct});
            this.dgvITDCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvITDCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvITDCoils.MultiSelect = false;
            this.dgvITDCoils.Name = "dgvITDCoils";
            this.dgvITDCoils.ReadOnly = true;
            this.dgvITDCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvITDCoils.Size = new System.Drawing.Size(711, 156);
            this.dgvITDCoils.TabIndex = 0;
            // 
            // clmITDCCodsec
            // 
            this.clmITDCCodsec.HeaderText = "codsec";
            this.clmITDCCodsec.Name = "clmITDCCodsec";
            this.clmITDCCodsec.ReadOnly = true;
            this.clmITDCCodsec.Visible = false;
            // 
            // clmITDCCode
            // 
            this.clmITDCCode.HeaderText = "Código";
            this.clmITDCCode.Name = "clmITDCCode";
            this.clmITDCCode.ReadOnly = true;
            this.clmITDCCode.Width = 110;
            // 
            // clmITDCCustomer
            // 
            this.clmITDCCustomer.HeaderText = "Cliente";
            this.clmITDCCustomer.Name = "clmITDCCustomer";
            this.clmITDCCustomer.ReadOnly = true;
            this.clmITDCCustomer.Width = 220;
            // 
            // clmITDCSalesOrderNumber
            // 
            this.clmITDCSalesOrderNumber.HeaderText = "Ord. num";
            this.clmITDCSalesOrderNumber.Name = "clmITDCSalesOrderNumber";
            this.clmITDCSalesOrderNumber.ReadOnly = true;
            // 
            // clmITDCProduct
            // 
            this.clmITDCProduct.HeaderText = "Producto";
            this.clmITDCProduct.Name = "clmITDCProduct";
            this.clmITDCProduct.ReadOnly = true;
            this.clmITDCProduct.Width = 220;
            // 
            // grpbITPalletsDetail
            // 
            this.grpbITPalletsDetail.Controls.Add(this.dgvITDPallets);
            this.grpbITPalletsDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbITPalletsDetail.Location = new System.Drawing.Point(3, 17);
            this.grpbITPalletsDetail.Name = "grpbITPalletsDetail";
            this.grpbITPalletsDetail.Size = new System.Drawing.Size(717, 176);
            this.grpbITPalletsDetail.TabIndex = 0;
            this.grpbITPalletsDetail.TabStop = false;
            this.grpbITPalletsDetail.Text = "Pallets";
            // 
            // dgvITDPallets
            // 
            this.dgvITDPallets.AllowUserToAddRows = false;
            this.dgvITDPallets.AllowUserToDeleteRows = false;
            this.dgvITDPallets.AllowUserToOrderColumns = true;
            this.dgvITDPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvITDPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmITDPCodsec,
            this.clmITDPCode,
            this.clmITDPCustomer,
            this.clmITDPSalesOrderNumber,
            this.clmITDPProduct,
            this.clmITDPCoils});
            this.dgvITDPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvITDPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvITDPallets.MultiSelect = false;
            this.dgvITDPallets.Name = "dgvITDPallets";
            this.dgvITDPallets.ReadOnly = true;
            this.dgvITDPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvITDPallets.Size = new System.Drawing.Size(711, 156);
            this.dgvITDPallets.TabIndex = 0;
            // 
            // clmITDPCodsec
            // 
            this.clmITDPCodsec.HeaderText = "clmPalletCodsec";
            this.clmITDPCodsec.Name = "clmITDPCodsec";
            this.clmITDPCodsec.ReadOnly = true;
            this.clmITDPCodsec.Visible = false;
            // 
            // clmITDPCode
            // 
            this.clmITDPCode.HeaderText = "Código";
            this.clmITDPCode.Name = "clmITDPCode";
            this.clmITDPCode.ReadOnly = true;
            this.clmITDPCode.Width = 110;
            // 
            // clmITDPCustomer
            // 
            this.clmITDPCustomer.HeaderText = "Cliente";
            this.clmITDPCustomer.Name = "clmITDPCustomer";
            this.clmITDPCustomer.ReadOnly = true;
            this.clmITDPCustomer.Width = 220;
            // 
            // clmITDPSalesOrderNumber
            // 
            this.clmITDPSalesOrderNumber.HeaderText = "Ord. num.";
            this.clmITDPSalesOrderNumber.Name = "clmITDPSalesOrderNumber";
            this.clmITDPSalesOrderNumber.ReadOnly = true;
            // 
            // clmITDPProduct
            // 
            this.clmITDPProduct.HeaderText = "Producto";
            this.clmITDPProduct.Name = "clmITDPProduct";
            this.clmITDPProduct.ReadOnly = true;
            this.clmITDPProduct.Width = 220;
            // 
            // clmITDPCoils
            // 
            this.clmITDPCoils.HeaderText = "Bobinas";
            this.clmITDPCoils.Name = "clmITDPCoils";
            this.clmITDPCoils.ReadOnly = true;
            // 
            // grpbEmptyCoils
            // 
            this.grpbEmptyCoils.Location = new System.Drawing.Point(0, 448);
            this.grpbEmptyCoils.Name = "grpbEmptyCoils";
            this.grpbEmptyCoils.Size = new System.Drawing.Size(637, 43);
            this.grpbEmptyCoils.TabIndex = 2;
            this.grpbEmptyCoils.TabStop = false;
            // 
            // grpbTransferActionsCoils
            // 
            this.grpbTransferActionsCoils.Controls.Add(this.btnCancelTransferCoils);
            this.grpbTransferActionsCoils.Controls.Add(this.btnExit);
            this.grpbTransferActionsCoils.Controls.Add(this.btnTransferCoils);
            this.grpbTransferActionsCoils.Location = new System.Drawing.Point(639, 448);
            this.grpbTransferActionsCoils.Name = "grpbTransferActionsCoils";
            this.grpbTransferActionsCoils.Size = new System.Drawing.Size(84, 43);
            this.grpbTransferActionsCoils.TabIndex = 3;
            this.grpbTransferActionsCoils.TabStop = false;
            // 
            // btnCancelTransferCoils
            // 
            this.btnCancelTransferCoils.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelTransferCoils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelTransferCoils.Location = new System.Drawing.Point(5, 13);
            this.btnCancelTransferCoils.Name = "btnCancelTransferCoils";
            this.btnCancelTransferCoils.Size = new System.Drawing.Size(24, 25);
            this.btnCancelTransferCoils.TabIndex = 0;
            this.ttpPalletCoilTransfer.SetToolTip(this.btnCancelTransferCoils, "Cancelar");
            this.btnCancelTransferCoils.UseVisualStyleBackColor = true;
            this.btnCancelTransferCoils.Click += new System.EventHandler(this.btnCancelTransferCoils_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(55, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 25);
            this.btnExit.TabIndex = 2;
            this.ttpPalletCoilTransfer.SetToolTip(this.btnExit, "Salir");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTransferCoils
            // 
            this.btnTransferCoils.BackgroundImage = global::BPS.Properties.Resources.arrow_incoming;
            this.btnTransferCoils.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransferCoils.Location = new System.Drawing.Point(30, 13);
            this.btnTransferCoils.Name = "btnTransferCoils";
            this.btnTransferCoils.Size = new System.Drawing.Size(24, 25);
            this.btnTransferCoils.TabIndex = 1;
            this.ttpPalletCoilTransfer.SetToolTip(this.btnTransferCoils, "Transferir");
            this.btnTransferCoils.UseVisualStyleBackColor = true;
            this.btnTransferCoils.Click += new System.EventHandler(this.btnTransferCoils_Click);
            // 
            // frmPalletCoilTransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(723, 493);
            this.Controls.Add(this.grpbIncomingDetail);
            this.Controls.Add(this.grpbTransferInfo);
            this.Controls.Add(this.grpbTransferActionsCoils);
            this.Controls.Add(this.grpbEmptyCoils);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletCoilTransferForm";
            this.Text = "Transferencia entre bodegas";
            this.Load += new System.EventHandler(this.frmPalletCoilTransferForm_Load);
            this.grpbTransferInfo.ResumeLayout(false);
            this.grpbTransferInfo.PerformLayout();
            this.grpbIncomingDetail.ResumeLayout(false);
            this.grpbITCoilsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDCoils)).EndInit();
            this.grpbITPalletsDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvITDPallets)).EndInit();
            this.grpbTransferActionsCoils.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbTransferInfo;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblSenderLabel;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblDestinationCellarLabel;
        private System.Windows.Forms.Label lblOriginCellarLabel;
        private System.Windows.Forms.Label lblDestinationCellar;
        private System.Windows.Forms.Label lblOriginCellar;
        private System.Windows.Forms.GroupBox grpbIncomingDetail;
        private System.Windows.Forms.GroupBox grpbITCoilsDetail;
        private System.Windows.Forms.DataGridView dgvITDCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDCProduct;
        private System.Windows.Forms.GroupBox grpbITPalletsDetail;
        private System.Windows.Forms.DataGridView dgvITDPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmITDPCoils;
        private System.Windows.Forms.GroupBox grpbEmptyCoils;
        private System.Windows.Forms.GroupBox grpbTransferActionsCoils;
        private System.Windows.Forms.Button btnCancelTransferCoils;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTransferCoils;
        private System.Windows.Forms.ToolTip ttpPalletCoilTransfer;
    }
}