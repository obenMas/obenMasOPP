namespace BPS
{
    partial class frmTransportBySalesOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransportBySalesOrder));
            this.grpbCustomer = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblCountryLabel = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerIdLabel = new System.Windows.Forms.Label();
            this.grpbSalesOrder = new System.Windows.Forms.GroupBox();
            this.lblCommercialCondition = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblCommercialConditionLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.grpbTransport = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.pbxDepth = new System.Windows.Forms.PictureBox();
            this.pbxHeigth = new System.Windows.Forms.PictureBox();
            this.pbxWidth = new System.Windows.Forms.PictureBox();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.grpbTransportList = new System.Windows.Forms.GroupBox();
            this.dgvTransportBySalesOrder = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTransportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDepth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletInfo = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpTransportBySalesOrder = new System.Windows.Forms.ToolTip(this.components);
            this.grpbCustomer.SuspendLayout();
            this.grpbSalesOrder.SuspendLayout();
            this.grpbTransport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWidth)).BeginInit();
            this.grpbTransportList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportBySalesOrder)).BeginInit();
            this.grpbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbCustomer
            // 
            this.grpbCustomer.Controls.Add(this.lblAddress);
            this.grpbCustomer.Controls.Add(this.lblCustomerName);
            this.grpbCustomer.Controls.Add(this.lblCountry);
            this.grpbCustomer.Controls.Add(this.lblCustomerId);
            this.grpbCustomer.Controls.Add(this.lblAddressLabel);
            this.grpbCustomer.Controls.Add(this.lblCountryLabel);
            this.grpbCustomer.Controls.Add(this.lblCustomerNameLabel);
            this.grpbCustomer.Controls.Add(this.lblCustomerIdLabel);
            this.grpbCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCustomer.Location = new System.Drawing.Point(0, 61);
            this.grpbCustomer.Name = "grpbCustomer";
            this.grpbCustomer.Size = new System.Drawing.Size(799, 75);
            this.grpbCustomer.TabIndex = 3;
            this.grpbCustomer.TabStop = false;
            this.grpbCustomer.Text = "Cliente";
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(321, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(443, 21);
            this.lblAddress.TabIndex = 7;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(321, 16);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(443, 21);
            this.lblCustomerName.TabIndex = 7;
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(126, 44);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(131, 21);
            this.lblCountry.TabIndex = 7;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(126, 16);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(131, 21);
            this.lblCustomerId.TabIndex = 7;
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.AutoSize = true;
            this.lblAddressLabel.Location = new System.Drawing.Point(263, 45);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(59, 15);
            this.lblAddressLabel.TabIndex = 27;
            this.lblAddressLabel.Text = "Dirección";
            // 
            // lblCountryLabel
            // 
            this.lblCountryLabel.AutoSize = true;
            this.lblCountryLabel.Location = new System.Drawing.Point(34, 45);
            this.lblCountryLabel.Name = "lblCountryLabel";
            this.lblCountryLabel.Size = new System.Drawing.Size(86, 15);
            this.lblCountryLabel.TabIndex = 25;
            this.lblCountryLabel.Text = "País de origen";
            // 
            // lblCustomerNameLabel
            // 
            this.lblCustomerNameLabel.AutoSize = true;
            this.lblCustomerNameLabel.Location = new System.Drawing.Point(263, 17);
            this.lblCustomerNameLabel.Name = "lblCustomerNameLabel";
            this.lblCustomerNameLabel.Size = new System.Drawing.Size(52, 15);
            this.lblCustomerNameLabel.TabIndex = 3;
            this.lblCustomerNameLabel.Text = "Nombre";
            // 
            // lblCustomerIdLabel
            // 
            this.lblCustomerIdLabel.AutoSize = true;
            this.lblCustomerIdLabel.Location = new System.Drawing.Point(34, 17);
            this.lblCustomerIdLabel.Name = "lblCustomerIdLabel";
            this.lblCustomerIdLabel.Size = new System.Drawing.Size(79, 15);
            this.lblCustomerIdLabel.TabIndex = 0;
            this.lblCustomerIdLabel.Text = "Identificación";
            // 
            // grpbSalesOrder
            // 
            this.grpbSalesOrder.Controls.Add(this.lblCommercialCondition);
            this.grpbSalesOrder.Controls.Add(this.lblStatus);
            this.grpbSalesOrder.Controls.Add(this.lblDate);
            this.grpbSalesOrder.Controls.Add(this.lblNumber);
            this.grpbSalesOrder.Controls.Add(this.lblDateLabel);
            this.grpbSalesOrder.Controls.Add(this.lblStatusLabel);
            this.grpbSalesOrder.Controls.Add(this.lblCommercialConditionLabel);
            this.grpbSalesOrder.Controls.Add(this.lblNumberLabel);
            this.grpbSalesOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSalesOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbSalesOrder.Name = "grpbSalesOrder";
            this.grpbSalesOrder.Size = new System.Drawing.Size(799, 61);
            this.grpbSalesOrder.TabIndex = 2;
            this.grpbSalesOrder.TabStop = false;
            this.grpbSalesOrder.Text = "Orden de Venta";
            // 
            // lblCommercialCondition
            // 
            this.lblCommercialCondition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCommercialCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommercialCondition.Location = new System.Drawing.Point(666, 25);
            this.lblCommercialCondition.Name = "lblCommercialCondition";
            this.lblCommercialCondition.Size = new System.Drawing.Size(121, 21);
            this.lblCommercialCondition.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(435, 25);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 21);
            this.lblStatus.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(223, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(155, 21);
            this.lblDate.TabIndex = 7;
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(70, 23);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(100, 24);
            this.lblNumber.TabIndex = 7;
            // 
            // lblDateLabel
            // 
            this.lblDateLabel.AutoSize = true;
            this.lblDateLabel.Location = new System.Drawing.Point(176, 28);
            this.lblDateLabel.Name = "lblDateLabel";
            this.lblDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblDateLabel.TabIndex = 6;
            this.lblDateLabel.Text = "Fecha";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(384, 28);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(45, 15);
            this.lblStatusLabel.TabIndex = 2;
            this.lblStatusLabel.Text = "Estado";
            // 
            // lblCommercialConditionLabel
            // 
            this.lblCommercialConditionLabel.AutoSize = true;
            this.lblCommercialConditionLabel.Location = new System.Drawing.Point(562, 28);
            this.lblCommercialConditionLabel.Name = "lblCommercialConditionLabel";
            this.lblCommercialConditionLabel.Size = new System.Drawing.Size(98, 15);
            this.lblCommercialConditionLabel.TabIndex = 2;
            this.lblCommercialConditionLabel.Text = "Cond. Comercial";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(12, 28);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.lblNumberLabel.TabIndex = 0;
            this.lblNumberLabel.Text = "Número";
            // 
            // grpbTransport
            // 
            this.grpbTransport.Controls.Add(this.btnAdd);
            this.grpbTransport.Controls.Add(this.lblDepth);
            this.grpbTransport.Controls.Add(this.lblHeight);
            this.grpbTransport.Controls.Add(this.lblWidth);
            this.grpbTransport.Controls.Add(this.pbxDepth);
            this.grpbTransport.Controls.Add(this.pbxHeigth);
            this.grpbTransport.Controls.Add(this.pbxWidth);
            this.grpbTransport.Controls.Add(this.cmbTransport);
            this.grpbTransport.Controls.Add(this.lblTransport);
            this.grpbTransport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbTransport.Location = new System.Drawing.Point(0, 136);
            this.grpbTransport.Name = "grpbTransport";
            this.grpbTransport.Size = new System.Drawing.Size(799, 53);
            this.grpbTransport.TabIndex = 4;
            this.grpbTransport.TabStop = false;
            this.grpbTransport.Text = "Transportes";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(757, 18);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 11;
            this.ttpTransportBySalesOrder.SetToolTip(this.btnAdd, "Agregar Transporte");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDepth
            // 
            this.lblDepth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(683, 20);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(66, 21);
            this.lblDepth.TabIndex = 10;
            // 
            // lblHeight
            // 
            this.lblHeight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(581, 20);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 21);
            this.lblHeight.TabIndex = 9;
            // 
            // lblWidth
            // 
            this.lblWidth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(479, 20);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(66, 21);
            this.lblWidth.TabIndex = 8;
            // 
            // pbxDepth
            // 
            this.pbxDepth.Image = global::BPS.Properties.Resources.length;
            this.pbxDepth.Location = new System.Drawing.Point(655, 20);
            this.pbxDepth.Name = "pbxDepth";
            this.pbxDepth.Padding = new System.Windows.Forms.Padding(2);
            this.pbxDepth.Size = new System.Drawing.Size(20, 20);
            this.pbxDepth.TabIndex = 4;
            this.pbxDepth.TabStop = false;
            // 
            // pbxHeigth
            // 
            this.pbxHeigth.Image = global::BPS.Properties.Resources.heigth;
            this.pbxHeigth.Location = new System.Drawing.Point(553, 20);
            this.pbxHeigth.Name = "pbxHeigth";
            this.pbxHeigth.Padding = new System.Windows.Forms.Padding(2);
            this.pbxHeigth.Size = new System.Drawing.Size(20, 20);
            this.pbxHeigth.TabIndex = 3;
            this.pbxHeigth.TabStop = false;
            // 
            // pbxWidth
            // 
            this.pbxWidth.Image = global::BPS.Properties.Resources.width;
            this.pbxWidth.Location = new System.Drawing.Point(451, 20);
            this.pbxWidth.Name = "pbxWidth";
            this.pbxWidth.Padding = new System.Windows.Forms.Padding(2);
            this.pbxWidth.Size = new System.Drawing.Size(20, 20);
            this.pbxWidth.TabIndex = 2;
            this.pbxWidth.TabStop = false;
            // 
            // cmbTransport
            // 
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(130, 19);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(313, 23);
            this.cmbTransport.TabIndex = 1;
            this.cmbTransport.SelectedIndexChanged += new System.EventHandler(this.cmbTransport_SelectedIndexChanged);
            this.cmbTransport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTransport_KeyDown);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(16, 23);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(106, 15);
            this.lblTransport.TabIndex = 0;
            this.lblTransport.Text = "Tipo de transporte";
            // 
            // grpbTransportList
            // 
            this.grpbTransportList.Controls.Add(this.dgvTransportBySalesOrder);
            this.grpbTransportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbTransportList.Location = new System.Drawing.Point(0, 189);
            this.grpbTransportList.Name = "grpbTransportList";
            this.grpbTransportList.Size = new System.Drawing.Size(799, 234);
            this.grpbTransportList.TabIndex = 5;
            this.grpbTransportList.TabStop = false;
            this.grpbTransportList.Text = "Transportes de la orden";
            // 
            // dgvTransportBySalesOrder
            // 
            this.dgvTransportBySalesOrder.AllowUserToAddRows = false;
            this.dgvTransportBySalesOrder.AllowUserToDeleteRows = false;
            this.dgvTransportBySalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransportBySalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmNumber,
            this.clmTransportName,
            this.clmWidth,
            this.clmHeight,
            this.clmDepth,
            this.clmPalletInfo,
            this.clmDelete});
            this.dgvTransportBySalesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTransportBySalesOrder.Location = new System.Drawing.Point(3, 17);
            this.dgvTransportBySalesOrder.Name = "dgvTransportBySalesOrder";
            this.dgvTransportBySalesOrder.ReadOnly = true;
            this.dgvTransportBySalesOrder.Size = new System.Drawing.Size(793, 214);
            this.dgvTransportBySalesOrder.TabIndex = 0;
            this.dgvTransportBySalesOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransportBySalesOrder_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Nro.";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 50;
            // 
            // clmTransportName
            // 
            this.clmTransportName.HeaderText = "Transporte";
            this.clmTransportName.Name = "clmTransportName";
            this.clmTransportName.ReadOnly = true;
            this.clmTransportName.Width = 300;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            // 
            // clmHeight
            // 
            this.clmHeight.HeaderText = "Alto";
            this.clmHeight.Name = "clmHeight";
            this.clmHeight.ReadOnly = true;
            // 
            // clmDepth
            // 
            this.clmDepth.HeaderText = "Largo";
            this.clmDepth.Name = "clmDepth";
            this.clmDepth.ReadOnly = true;
            // 
            // clmPalletInfo
            // 
            this.clmPalletInfo.HeaderText = "";
            this.clmPalletInfo.Name = "clmPalletInfo";
            this.clmPalletInfo.ReadOnly = true;
            this.clmPalletInfo.Width = 30;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 30;
            // 
            // grpbSearch
            // 
            this.grpbSearch.BackColor = System.Drawing.SystemColors.Window;
            this.grpbSearch.Controls.Add(this.btnClose);
            this.grpbSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbSearch.Location = new System.Drawing.Point(0, 423);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(799, 43);
            this.grpbSearch.TabIndex = 6;
            this.grpbSearch.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(768, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpTransportBySalesOrder.SetToolTip(this.btnClose, "Salir Transportes Orden de Venta");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTransportBySalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 466);
            this.Controls.Add(this.grpbTransportList);
            this.Controls.Add(this.grpbTransport);
            this.Controls.Add(this.grpbCustomer);
            this.Controls.Add(this.grpbSalesOrder);
            this.Controls.Add(this.grpbSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransportBySalesOrder";
            this.Text = "Transportes por ordenes de venta";
            this.Load += new System.EventHandler(this.frmTransportBySalesOrder_Load);
            this.grpbCustomer.ResumeLayout(false);
            this.grpbCustomer.PerformLayout();
            this.grpbSalesOrder.ResumeLayout(false);
            this.grpbSalesOrder.PerformLayout();
            this.grpbTransport.ResumeLayout(false);
            this.grpbTransport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWidth)).EndInit();
            this.grpbTransportList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransportBySalesOrder)).EndInit();
            this.grpbSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbCustomer;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblCountryLabel;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblCustomerIdLabel;
        private System.Windows.Forms.GroupBox grpbSalesOrder;
        private System.Windows.Forms.Label lblCommercialCondition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblCommercialConditionLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.GroupBox grpbTransport;
        private System.Windows.Forms.PictureBox pbxWidth;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.PictureBox pbxDepth;
        private System.Windows.Forms.PictureBox pbxHeigth;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpbTransportList;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTransportBySalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTransportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDepth;
        private System.Windows.Forms.DataGridViewImageColumn clmPalletInfo;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
        private System.Windows.Forms.ToolTip ttpTransportBySalesOrder;
    }
}