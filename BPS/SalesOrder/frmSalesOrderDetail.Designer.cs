namespace BPS
{
    partial class frmSalesOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderDetail));
            this.grpbSalesOrder = new System.Windows.Forms.GroupBox();
            this.lblCommercialCondition = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDateLabel = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblCommercialConditionLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.grpbCustomer = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblAddressLabel = new System.Windows.Forms.Label();
            this.lblCountryLabel = new System.Windows.Forms.Label();
            this.lblCustomerNameLabel = new System.Windows.Forms.Label();
            this.lblCustomerIdLabel = new System.Windows.Forms.Label();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTotalWeith = new System.Windows.Forms.Label();
            this.lblTotalWeithLabel = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpSalesOrderDetails = new System.Windows.Forms.ToolTip(this.components);
            this.grpbSalesOrder.SuspendLayout();
            this.grpbCustomer.SuspendLayout();
            this.grpbActions.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
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
            this.grpbSalesOrder.TabIndex = 0;
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
            this.grpbCustomer.TabIndex = 1;
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
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(769, 382);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(30, 43);
            this.grpbActions.TabIndex = 5;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(3, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.ttpSalesOrderDetails.SetToolTip(this.btnClose, "Salir Orden de Venta");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(0, 382);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(766, 43);
            this.grpbFilters.TabIndex = 9;
            this.grpbFilters.TabStop = false;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.grpbNotes);
            this.grpbDetail.Controls.Add(this.lblTotalWeith);
            this.grpbDetail.Controls.Add(this.lblTotalWeithLabel);
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Location = new System.Drawing.Point(0, 136);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(799, 250);
            this.grpbDetail.TabIndex = 2;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.lblNotes);
            this.grpbNotes.Location = new System.Drawing.Point(3, 173);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(406, 73);
            this.grpbNotes.TabIndex = 3;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Notas";
            // 
            // lblNotes
            // 
            this.lblNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(8, 17);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(391, 48);
            this.lblNotes.TabIndex = 7;
            // 
            // lblTotalWeith
            // 
            this.lblTotalWeith.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalWeith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeith.Location = new System.Drawing.Point(696, 175);
            this.lblTotalWeith.Name = "lblTotalWeith";
            this.lblTotalWeith.Size = new System.Drawing.Size(100, 21);
            this.lblTotalWeith.TabIndex = 7;
            // 
            // lblTotalWeithLabel
            // 
            this.lblTotalWeithLabel.AutoSize = true;
            this.lblTotalWeithLabel.Location = new System.Drawing.Point(634, 176);
            this.lblTotalWeithLabel.Name = "lblTotalWeithLabel";
            this.lblTotalWeithLabel.Size = new System.Drawing.Size(60, 15);
            this.lblTotalWeithLabel.TabIndex = 2;
            this.lblTotalWeithLabel.Text = "Total (Kg)";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmProductCodsec,
            this.clmQuantity,
            this.clmProductCode,
            this.clmProductName,
            this.clmStock,
            this.clmStatus});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetail.Location = new System.Drawing.Point(3, 16);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.Size = new System.Drawing.Size(793, 150);
            this.dgvDetail.TabIndex = 0;
            // 
            // clmCodsec
            // 
            dataGridViewCellStyle1.NullValue = "0";
            this.clmCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmProductCodsec
            // 
            this.clmProductCodsec.HeaderText = "productCodsec";
            this.clmProductCodsec.Name = "clmProductCodsec";
            this.clmProductCodsec.ReadOnly = true;
            this.clmProductCodsec.Visible = false;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQuantity.Width = 105;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Código";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductCode.Width = 130;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmProductName.Width = 400;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 105;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            this.clmStatus.Visible = false;
            // 
            // frmSalesOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 426);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbCustomer);
            this.Controls.Add(this.grpbSalesOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderDetail";
            this.Text = "Orden de Venta Nacionales";
            this.Load += new System.EventHandler(this.frmSalesOrderDetail_Load);
            this.grpbSalesOrder.ResumeLayout(false);
            this.grpbSalesOrder.PerformLayout();
            this.grpbCustomer.ResumeLayout(false);
            this.grpbCustomer.PerformLayout();
            this.grpbActions.ResumeLayout(false);
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbSalesOrder;
        private System.Windows.Forms.GroupBox grpbCustomer;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.Label lblDateLabel;
        private System.Windows.Forms.Label lblCustomerIdLabel;
        private System.Windows.Forms.Label lblCustomerNameLabel;
        private System.Windows.Forms.Label lblCountryLabel;
        private System.Windows.Forms.Label lblAddressLabel;
        private System.Windows.Forms.Label lblTotalWeithLabel;
        private System.Windows.Forms.GroupBox grpbNotes;
        public System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label lblCommercialConditionLabel;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblCommercialCondition;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTotalWeith;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.ToolTip ttpSalesOrderDetails;
    }
}