namespace BPS
{
    partial class frmRawMaterialReception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialReception));
            this.lblPurchaseOrder = new System.Windows.Forms.Label();
            this.cmbPurchaseOrder = new System.Windows.Forms.ComboBox();
            this.lblReceptionDate = new System.Windows.Forms.Label();
            this.dtpReceptionDate = new System.Windows.Forms.DateTimePicker();
            this.grpbReception = new System.Windows.Forms.GroupBox();
            this.dgvReception = new System.Windows.Forms.DataGridView();
            this.clmfkPurchaseOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantityOrdered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantityDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmountToBeDelivered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchaseOrderCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbMainCoilButtons = new System.Windows.Forms.GroupBox();
            this.btnMainCoilExit = new System.Windows.Forms.Button();
            this.btnMainCoilSave = new System.Windows.Forms.Button();
            this.btnMainCoilCancel = new System.Windows.Forms.Button();
            this.ttprawMaterialReception = new System.Windows.Forms.ToolTip(this.components);
            this.grpbReception.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).BeginInit();
            this.grpbMainCoilButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPurchaseOrder
            // 
            this.lblPurchaseOrder.AutoSize = true;
            this.lblPurchaseOrder.Location = new System.Drawing.Point(2, 20);
            this.lblPurchaseOrder.Name = "lblPurchaseOrder";
            this.lblPurchaseOrder.Size = new System.Drawing.Size(114, 15);
            this.lblPurchaseOrder.TabIndex = 0;
            this.lblPurchaseOrder.Text = "Orden Compra Nro.";
            // 
            // cmbPurchaseOrder
            // 
            this.cmbPurchaseOrder.FormattingEnabled = true;
            this.cmbPurchaseOrder.Location = new System.Drawing.Point(122, 17);
            this.cmbPurchaseOrder.Name = "cmbPurchaseOrder";
            this.cmbPurchaseOrder.Size = new System.Drawing.Size(121, 23);
            this.cmbPurchaseOrder.TabIndex = 1;
            this.cmbPurchaseOrder.SelectedIndexChanged += new System.EventHandler(this.cmbPurchaseOrder_SelectedIndexChanged);
            this.cmbPurchaseOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPurchaseOrder_KeyDown);
            // 
            // lblReceptionDate
            // 
            this.lblReceptionDate.AutoSize = true;
            this.lblReceptionDate.Location = new System.Drawing.Point(800, 20);
            this.lblReceptionDate.Name = "lblReceptionDate";
            this.lblReceptionDate.Size = new System.Drawing.Size(41, 15);
            this.lblReceptionDate.TabIndex = 2;
            this.lblReceptionDate.Text = "Fecha";
            // 
            // dtpReceptionDate
            // 
            this.dtpReceptionDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpReceptionDate.Location = new System.Drawing.Point(847, 18);
            this.dtpReceptionDate.Name = "dtpReceptionDate";
            this.dtpReceptionDate.Size = new System.Drawing.Size(243, 21);
            this.dtpReceptionDate.TabIndex = 3;
            // 
            // grpbReception
            // 
            this.grpbReception.Controls.Add(this.dgvReception);
            this.grpbReception.Location = new System.Drawing.Point(5, 61);
            this.grpbReception.Name = "grpbReception";
            this.grpbReception.Size = new System.Drawing.Size(1088, 182);
            this.grpbReception.TabIndex = 4;
            this.grpbReception.TabStop = false;
            this.grpbReception.Text = "Detalle";
            // 
            // dgvReception
            // 
            this.dgvReception.AllowUserToAddRows = false;
            this.dgvReception.AllowUserToDeleteRows = false;
            this.dgvReception.AllowUserToOrderColumns = true;
            this.dgvReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReception.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmfkPurchaseOrderDetail,
            this.clmPrice,
            this.clmfkRawMaterial,
            this.clmDocument,
            this.clmRawMaterialType,
            this.clmRawMaterialName,
            this.clmRawMaterialCode,
            this.clmQuantityOrdered,
            this.clmQuantityDelivered,
            this.clmAmountToBeDelivered,
            this.clmQuantity,
            this.clmDetail,
            this.clmPurchaseOrderCodsec});
            this.dgvReception.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReception.Location = new System.Drawing.Point(3, 17);
            this.dgvReception.Name = "dgvReception";
            this.dgvReception.Size = new System.Drawing.Size(1082, 150);
            this.dgvReception.TabIndex = 0;
            // 
            // clmfkPurchaseOrderDetail
            // 
            this.clmfkPurchaseOrderDetail.HeaderText = "codsec";
            this.clmfkPurchaseOrderDetail.Name = "clmfkPurchaseOrderDetail";
            this.clmfkPurchaseOrderDetail.Visible = false;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Visible = false;
            // 
            // clmfkRawMaterial
            // 
            this.clmfkRawMaterial.HeaderText = "fkRawMaterial";
            this.clmfkRawMaterial.Name = "clmfkRawMaterial";
            this.clmfkRawMaterial.Visible = false;
            // 
            // clmDocument
            // 
            this.clmDocument.HeaderText = "Documento";
            this.clmDocument.Name = "clmDocument";
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Nombre";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            // 
            // clmQuantityOrdered
            // 
            this.clmQuantityOrdered.HeaderText = "Cant. Pedida";
            this.clmQuantityOrdered.Name = "clmQuantityOrdered";
            this.clmQuantityOrdered.ReadOnly = true;
            // 
            // clmQuantityDelivered
            // 
            this.clmQuantityDelivered.HeaderText = "Cant. Entregada";
            this.clmQuantityDelivered.Name = "clmQuantityDelivered";
            this.clmQuantityDelivered.ReadOnly = true;
            // 
            // clmAmountToBeDelivered
            // 
            this.clmAmountToBeDelivered.HeaderText = "Cant. Por Entregar";
            this.clmAmountToBeDelivered.Name = "clmAmountToBeDelivered";
            this.clmAmountToBeDelivered.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cant. Recibida";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmDetail
            // 
            this.clmDetail.HeaderText = "Nota";
            this.clmDetail.Name = "clmDetail";
            this.clmDetail.Width = 230;
            // 
            // clmPurchaseOrderCodsec
            // 
            this.clmPurchaseOrderCodsec.HeaderText = "purchaseOrderCodsec";
            this.clmPurchaseOrderCodsec.Name = "clmPurchaseOrderCodsec";
            this.clmPurchaseOrderCodsec.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(998, 43);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // grpbMainCoilButtons
            // 
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilExit);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilSave);
            this.grpbMainCoilButtons.Controls.Add(this.btnMainCoilCancel);
            this.grpbMainCoilButtons.Location = new System.Drawing.Point(1009, 242);
            this.grpbMainCoilButtons.Name = "grpbMainCoilButtons";
            this.grpbMainCoilButtons.Size = new System.Drawing.Size(84, 44);
            this.grpbMainCoilButtons.TabIndex = 6;
            this.grpbMainCoilButtons.TabStop = false;
            // 
            // btnMainCoilExit
            // 
            this.btnMainCoilExit.Image = global::BPS.Properties.Resources.door_in;
            this.btnMainCoilExit.Location = new System.Drawing.Point(55, 14);
            this.btnMainCoilExit.Name = "btnMainCoilExit";
            this.btnMainCoilExit.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilExit.TabIndex = 35;
            this.ttprawMaterialReception.SetToolTip(this.btnMainCoilExit, "Salir Materia Prima");
            this.btnMainCoilExit.UseVisualStyleBackColor = true;
            this.btnMainCoilExit.Click += new System.EventHandler(this.btnMainCoilExit_Click);
            // 
            // btnMainCoilSave
            // 
            this.btnMainCoilSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMainCoilSave.BackgroundImage")));
            this.btnMainCoilSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilSave.Location = new System.Drawing.Point(5, 14);
            this.btnMainCoilSave.Name = "btnMainCoilSave";
            this.btnMainCoilSave.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilSave.TabIndex = 33;
            this.ttprawMaterialReception.SetToolTip(this.btnMainCoilSave, "Guardar Materia Prima");
            this.btnMainCoilSave.UseVisualStyleBackColor = true;
            this.btnMainCoilSave.Click += new System.EventHandler(this.btnMainCoilSave_Click);
            // 
            // btnMainCoilCancel
            // 
            this.btnMainCoilCancel.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnMainCoilCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilCancel.Location = new System.Drawing.Point(30, 14);
            this.btnMainCoilCancel.Name = "btnMainCoilCancel";
            this.btnMainCoilCancel.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilCancel.TabIndex = 34;
            this.ttprawMaterialReception.SetToolTip(this.btnMainCoilCancel, "Cancelar Materia Prima");
            this.btnMainCoilCancel.UseVisualStyleBackColor = true;
            this.btnMainCoilCancel.Click += new System.EventHandler(this.btnMainCoilCancel_Click);
            // 
            // frmRawMaterialReception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1098, 292);
            this.Controls.Add(this.grpbMainCoilButtons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbReception);
            this.Controls.Add(this.dtpReceptionDate);
            this.Controls.Add(this.lblReceptionDate);
            this.Controls.Add(this.cmbPurchaseOrder);
            this.Controls.Add(this.lblPurchaseOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialReception";
            this.Text = "Recepción Materia Prima";
            this.Load += new System.EventHandler(this.frmRawMaterialReception_Load);
            this.grpbReception.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).EndInit();
            this.grpbMainCoilButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchaseOrder;
        private System.Windows.Forms.ComboBox cmbPurchaseOrder;
        private System.Windows.Forms.Label lblReceptionDate;
        private System.Windows.Forms.DateTimePicker dtpReceptionDate;
        private System.Windows.Forms.GroupBox grpbReception;
        private System.Windows.Forms.DataGridView dgvReception;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbMainCoilButtons;
        private System.Windows.Forms.Button btnMainCoilExit;
        private System.Windows.Forms.Button btnMainCoilSave;
        private System.Windows.Forms.Button btnMainCoilCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkPurchaseOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDocument;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantityOrdered;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantityDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmountToBeDelivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchaseOrderCodsec;
        private System.Windows.Forms.ToolTip ttprawMaterialReception;
    }
}