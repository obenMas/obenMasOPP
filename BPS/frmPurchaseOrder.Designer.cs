namespace BPS
{
    partial class frmPurchaseOrder
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseOrder));
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalWeigth = new System.Windows.Forms.TextBox();
            this.lblTotalWeith = new System.Windows.Forms.Label();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.grpbEntity = new System.Windows.Forms.GroupBox();
            this.txtProviderAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtProviderCountry = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.btnSearchProvider = new System.Windows.Forms.Button();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.txtProviderId = new System.Windows.Forms.TextBox();
            this.lblProviderId = new System.Windows.Forms.Label();
            this.grpbPurchaseOrder = new System.Windows.Forms.GroupBox();
            this.txtNumberPurchaseOrder = new System.Windows.Forms.Label();
            this.lblNumberPurchaseOrder = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbCommercialCondition = new System.Windows.Forms.ComboBox();
            this.lblCommercialCondition = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.ttpPurcharseOrder = new System.Windows.Forms.ToolTip(this.components);
            this.grpbDetail.SuspendLayout();
            this.grpbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.grpbEntity.SuspendLayout();
            this.grpbPurchaseOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.grpbNotes);
            this.grpbDetail.Controls.Add(this.txtTotal);
            this.grpbDetail.Controls.Add(this.lblTotal);
            this.grpbDetail.Controls.Add(this.txtTotalWeigth);
            this.grpbDetail.Controls.Add(this.lblTotalWeith);
            this.grpbDetail.Controls.Add(this.dgvDetail);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbDetail.Location = new System.Drawing.Point(0, 170);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(799, 252);
            this.grpbDetail.TabIndex = 12;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtNotes);
            this.grpbNotes.Location = new System.Drawing.Point(3, 171);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(406, 73);
            this.grpbNotes.TabIndex = 3;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Notas";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(9, 18);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(391, 48);
            this.txtNotes.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(685, 208);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(623, 212);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            // 
            // txtTotalWeigth
            // 
            this.txtTotalWeigth.Enabled = false;
            this.txtTotalWeigth.Location = new System.Drawing.Point(685, 178);
            this.txtTotalWeigth.Name = "txtTotalWeigth";
            this.txtTotalWeigth.Size = new System.Drawing.Size(100, 21);
            this.txtTotalWeigth.TabIndex = 3;
            // 
            // lblTotalWeith
            // 
            this.lblTotalWeith.AutoSize = true;
            this.lblTotalWeith.Location = new System.Drawing.Point(623, 181);
            this.lblTotalWeith.Name = "lblTotalWeith";
            this.lblTotalWeith.Size = new System.Drawing.Size(60, 15);
            this.lblTotalWeith.TabIndex = 2;
            this.lblTotalWeith.Text = "Total (Kg)";
            // 
            // dgvDetail
            // 
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmRawMaterialCodsec,
            this.clmQuantity,
            this.clmRawMaterialType,
            this.clmRawMaterialCode,
            this.clmRawMaterialName,
            this.clmPrice,
            this.clmSubTotal});
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(793, 150);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellDoubleClick);
            this.dgvDetail.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvDetail_CellValidating);
            this.dgvDetail.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDetail_UserAddedRow);
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
            // clmRawMaterialCodsec
            // 
            this.clmRawMaterialCodsec.HeaderText = "rawMaterialCodsec";
            this.clmRawMaterialCodsec.Name = "clmRawMaterialCodsec";
            this.clmRawMaterialCodsec.ReadOnly = true;
            this.clmRawMaterialCodsec.Visible = false;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmQuantity.Width = 85;
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.Width = 170;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            this.clmRawMaterialCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmRawMaterialCode.Width = 120;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Materia Prima";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            this.clmRawMaterialName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmRawMaterialName.Width = 200;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio Unit.";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmPrice.Width = 85;
            // 
            // clmSubTotal
            // 
            this.clmSubTotal.HeaderText = "Subtotal";
            this.clmSubTotal.Name = "clmSubTotal";
            this.clmSubTotal.ReadOnly = true;
            this.clmSubTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clmSubTotal.Width = 85;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnSave);
            this.grpbActions.Controls.Add(this.btnCancel);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(713, 418);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(86, 43);
            this.grpbActions.TabIndex = 13;
            this.grpbActions.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(6, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(24, 25);
            this.btnSave.TabIndex = 1;
            this.ttpPurcharseOrder.SetToolTip(this.btnSave, "Guardar Ordenes de Compra");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.Location = new System.Drawing.Point(31, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(24, 25);
            this.btnCancel.TabIndex = 2;
            this.ttpPurcharseOrder.SetToolTip(this.btnCancel, "Cancelar Ordenes de Compra");
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(56, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.TabIndex = 3;
            this.ttpPurcharseOrder.SetToolTip(this.btnClose, "Salir Ordenes de Compra");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(0, 418);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(709, 43);
            this.grpbFilters.TabIndex = 14;
            this.grpbFilters.TabStop = false;
            // 
            // grpbEntity
            // 
            this.grpbEntity.Controls.Add(this.txtProviderAddress);
            this.grpbEntity.Controls.Add(this.lblAddress);
            this.grpbEntity.Controls.Add(this.txtProviderCountry);
            this.grpbEntity.Controls.Add(this.lblCountry);
            this.grpbEntity.Controls.Add(this.btnSearchProvider);
            this.grpbEntity.Controls.Add(this.txtProviderName);
            this.grpbEntity.Controls.Add(this.lblProviderName);
            this.grpbEntity.Controls.Add(this.txtProviderId);
            this.grpbEntity.Controls.Add(this.lblProviderId);
            this.grpbEntity.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbEntity.Location = new System.Drawing.Point(0, 95);
            this.grpbEntity.Name = "grpbEntity";
            this.grpbEntity.Size = new System.Drawing.Size(799, 75);
            this.grpbEntity.TabIndex = 11;
            this.grpbEntity.TabStop = false;
            this.grpbEntity.Text = "Proveedor";
            // 
            // txtProviderAddress
            // 
            this.txtProviderAddress.Enabled = false;
            this.txtProviderAddress.Location = new System.Drawing.Point(316, 42);
            this.txtProviderAddress.Name = "txtProviderAddress";
            this.txtProviderAddress.Size = new System.Drawing.Size(443, 21);
            this.txtProviderAddress.TabIndex = 28;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(258, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 15);
            this.lblAddress.TabIndex = 27;
            this.lblAddress.Text = "Dirección";
            // 
            // txtProviderCountry
            // 
            this.txtProviderCountry.Enabled = false;
            this.txtProviderCountry.Location = new System.Drawing.Point(121, 42);
            this.txtProviderCountry.Name = "txtProviderCountry";
            this.txtProviderCountry.Size = new System.Drawing.Size(131, 21);
            this.txtProviderCountry.TabIndex = 26;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(63, 45);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(19, 15);
            this.lblCountry.TabIndex = 25;
            this.lblCountry.Text = "ID";
            // 
            // btnSearchProvider
            // 
            this.btnSearchProvider.BackgroundImage = global::BPS.Properties.Resources.magnifier;
            this.btnSearchProvider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearchProvider.Location = new System.Drawing.Point(227, 12);
            this.btnSearchProvider.Name = "btnSearchProvider";
            this.btnSearchProvider.Size = new System.Drawing.Size(24, 25);
            this.btnSearchProvider.TabIndex = 24;
            this.ttpPurcharseOrder.SetToolTip(this.btnSearchProvider, "Buscar Proveedores");
            this.btnSearchProvider.UseVisualStyleBackColor = true;
            this.btnSearchProvider.Click += new System.EventHandler(this.btnSearchProvider_Click);
            // 
            // txtProviderName
            // 
            this.txtProviderName.Enabled = false;
            this.txtProviderName.Location = new System.Drawing.Point(316, 14);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(443, 21);
            this.txtProviderName.TabIndex = 4;
            // 
            // lblProviderName
            // 
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(258, 17);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(52, 15);
            this.lblProviderName.TabIndex = 3;
            this.lblProviderName.Text = "Nombre";
            // 
            // txtProviderId
            // 
            this.txtProviderId.Location = new System.Drawing.Point(121, 14);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(100, 21);
            this.txtProviderId.TabIndex = 2;
            // 
            // lblProviderId
            // 
            this.lblProviderId.AutoSize = true;
            this.lblProviderId.Location = new System.Drawing.Point(63, 17);
            this.lblProviderId.Name = "lblProviderId";
            this.lblProviderId.Size = new System.Drawing.Size(46, 15);
            this.lblProviderId.TabIndex = 0;
            this.lblProviderId.Text = "Código";
            // 
            // grpbPurchaseOrder
            // 
            this.grpbPurchaseOrder.Controls.Add(this.txtNumberPurchaseOrder);
            this.grpbPurchaseOrder.Controls.Add(this.lblNumberPurchaseOrder);
            this.grpbPurchaseOrder.Controls.Add(this.dtpDate);
            this.grpbPurchaseOrder.Controls.Add(this.lblDate);
            this.grpbPurchaseOrder.Controls.Add(this.cmbStatus);
            this.grpbPurchaseOrder.Controls.Add(this.lblStatus);
            this.grpbPurchaseOrder.Controls.Add(this.cmbCommercialCondition);
            this.grpbPurchaseOrder.Controls.Add(this.lblCommercialCondition);
            this.grpbPurchaseOrder.Controls.Add(this.txtNumber);
            this.grpbPurchaseOrder.Controls.Add(this.lblNumber);
            this.grpbPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPurchaseOrder.Location = new System.Drawing.Point(0, 0);
            this.grpbPurchaseOrder.Name = "grpbPurchaseOrder";
            this.grpbPurchaseOrder.Size = new System.Drawing.Size(799, 95);
            this.grpbPurchaseOrder.TabIndex = 10;
            this.grpbPurchaseOrder.TabStop = false;
            this.grpbPurchaseOrder.Text = "Orden de Compra";
            // 
            // txtNumberPurchaseOrder
            // 
            this.txtNumberPurchaseOrder.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumberPurchaseOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtNumberPurchaseOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPurchaseOrder.Location = new System.Drawing.Point(660, 20);
            this.txtNumberPurchaseOrder.Name = "txtNumberPurchaseOrder";
            this.txtNumberPurchaseOrder.Size = new System.Drawing.Size(121, 23);
            this.txtNumberPurchaseOrder.TabIndex = 8;
            // 
            // lblNumberPurchaseOrder
            // 
            this.lblNumberPurchaseOrder.AutoSize = true;
            this.lblNumberPurchaseOrder.Location = new System.Drawing.Point(597, 24);
            this.lblNumberPurchaseOrder.Name = "lblNumberPurchaseOrder";
            this.lblNumberPurchaseOrder.Size = new System.Drawing.Size(52, 15);
            this.lblNumberPurchaseOrder.TabIndex = 7;
            this.lblNumberPurchaseOrder.Text = "Número";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(374, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(135, 21);
            this.dtpDate.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(328, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Fecha";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(660, 51);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 23);
            this.cmbStatus.TabIndex = 3;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(597, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 15);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Estado";
            // 
            // cmbCommercialCondition
            // 
            this.cmbCommercialCondition.FormattingEnabled = true;
            this.cmbCommercialCondition.Location = new System.Drawing.Point(121, 51);
            this.cmbCommercialCondition.Name = "cmbCommercialCondition";
            this.cmbCommercialCondition.Size = new System.Drawing.Size(121, 23);
            this.cmbCommercialCondition.TabIndex = 3;
            this.cmbCommercialCondition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCommercialCondition_KeyDown);
            // 
            // lblCommercialCondition
            // 
            this.lblCommercialCondition.AutoSize = true;
            this.lblCommercialCondition.Location = new System.Drawing.Point(12, 55);
            this.lblCommercialCondition.Name = "lblCommercialCondition";
            this.lblCommercialCondition.Size = new System.Drawing.Size(98, 15);
            this.lblCommercialCondition.TabIndex = 2;
            this.lblCommercialCondition.Text = "Cond. Comercial";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(121, 21);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(121, 21);
            this.txtNumber.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 24);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(105, 15);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Orden de Compra";
            // 
            // frmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(799, 463);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.grpbEntity);
            this.Controls.Add(this.grpbPurchaseOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPurchaseOrder";
            this.Text = "Ordenes de Compra";
            this.Load += new System.EventHandler(this.frmPurchaseOrder_Load);
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbEntity.ResumeLayout(false);
            this.grpbEntity.PerformLayout();
            this.grpbPurchaseOrder.ResumeLayout(false);
            this.grpbPurchaseOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalWeigth;
        private System.Windows.Forms.Label lblTotalWeith;
        public System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbEntity;
        private System.Windows.Forms.TextBox txtProviderAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtProviderCountry;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Button btnSearchProvider;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.TextBox txtProviderId;
        private System.Windows.Forms.Label lblProviderId;
        private System.Windows.Forms.GroupBox grpbPurchaseOrder;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbCommercialCondition;
        private System.Windows.Forms.Label lblCommercialCondition;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumberPurchaseOrder;
        private System.Windows.Forms.Label txtNumberPurchaseOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSubTotal;
        private System.Windows.Forms.ToolTip ttpPurcharseOrder;

    }
}