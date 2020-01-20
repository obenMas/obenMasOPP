namespace BPS
{
    partial class frmMetallizedProductionOrdenList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetallizedProductionOrdenList));
            this.btnProductionOrderClose = new System.Windows.Forms.Button();
            this.grpbProductionOrderlList = new System.Windows.Forms.GroupBox();
            this.dgvProductionOrderList = new System.Windows.Forms.DataGridView();
            this.clmProductionOrderListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderListFkFilmProductionOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderListFilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderMetal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderWidths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbProductionOrderFilters = new System.Windows.Forms.GroupBox();
            this.txtLotNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ttpProductionOrderList = new System.Windows.Forms.ToolTip(this.components);
            this.grpbProductionOrderlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrderList)).BeginInit();
            this.grpbProductionOrderFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductionOrderClose
            // 
            this.btnProductionOrderClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnProductionOrderClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionOrderClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProductionOrderClose.Location = new System.Drawing.Point(868, 17);
            this.btnProductionOrderClose.Name = "btnProductionOrderClose";
            this.btnProductionOrderClose.Size = new System.Drawing.Size(25, 23);
            this.btnProductionOrderClose.TabIndex = 23;
            this.ttpProductionOrderList.SetToolTip(this.btnProductionOrderClose, "Salir Ordenes de Producción");
            this.btnProductionOrderClose.UseVisualStyleBackColor = true;
            this.btnProductionOrderClose.Click += new System.EventHandler(this.btnProductionOrderClose_Click);
            // 
            // grpbProductionOrderlList
            // 
            this.grpbProductionOrderlList.Controls.Add(this.dgvProductionOrderList);
            this.grpbProductionOrderlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbProductionOrderlList.Location = new System.Drawing.Point(0, 0);
            this.grpbProductionOrderlList.Name = "grpbProductionOrderlList";
            this.grpbProductionOrderlList.Size = new System.Drawing.Size(896, 467);
            this.grpbProductionOrderlList.TabIndex = 17;
            this.grpbProductionOrderlList.TabStop = false;
            this.grpbProductionOrderlList.Text = "Ordenes Metalizado";
            // 
            // dgvProductionOrderList
            // 
            this.dgvProductionOrderList.AllowUserToAddRows = false;
            this.dgvProductionOrderList.AllowUserToDeleteRows = false;
            this.dgvProductionOrderList.AllowUserToOrderColumns = true;
            this.dgvProductionOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductionOrderListCodsec,
            this.clmProductionOrderListFkFilmProductionOrder,
            this.clmProductionOrderListFilmType,
            this.clmProductionOrderNumber,
            this.clmProductionOrderBase,
            this.clmProductionOrderMetal,
            this.clmProductionOrderWidths,
            this.clmProductionOrderCoil,
            this.clmProductionOrderQuantity,
            this.clmProductionOrderStatus});
            this.dgvProductionOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductionOrderList.Location = new System.Drawing.Point(3, 17);
            this.dgvProductionOrderList.Name = "dgvProductionOrderList";
            this.dgvProductionOrderList.ReadOnly = true;
            this.dgvProductionOrderList.RowHeadersWidth = 31;
            this.dgvProductionOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductionOrderList.Size = new System.Drawing.Size(890, 447);
            this.dgvProductionOrderList.TabIndex = 1;
            this.dgvProductionOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionOrderList_CellDoubleClick);
            // 
            // clmProductionOrderListCodsec
            // 
            this.clmProductionOrderListCodsec.HeaderText = "Codsec";
            this.clmProductionOrderListCodsec.Name = "clmProductionOrderListCodsec";
            this.clmProductionOrderListCodsec.ReadOnly = true;
            this.clmProductionOrderListCodsec.Visible = false;
            this.clmProductionOrderListCodsec.Width = 200;
            // 
            // clmProductionOrderListFkFilmProductionOrder
            // 
            this.clmProductionOrderListFkFilmProductionOrder.HeaderText = "FilmProductionOrder";
            this.clmProductionOrderListFkFilmProductionOrder.Name = "clmProductionOrderListFkFilmProductionOrder";
            this.clmProductionOrderListFkFilmProductionOrder.ReadOnly = true;
            this.clmProductionOrderListFkFilmProductionOrder.Visible = false;
            // 
            // clmProductionOrderListFilmType
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmProductionOrderListFilmType.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmProductionOrderListFilmType.HeaderText = "Tipo";
            this.clmProductionOrderListFilmType.Name = "clmProductionOrderListFilmType";
            this.clmProductionOrderListFilmType.ReadOnly = true;
            this.clmProductionOrderListFilmType.Width = 50;
            // 
            // clmProductionOrderNumber
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmProductionOrderNumber.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmProductionOrderNumber.HeaderText = "Lote";
            this.clmProductionOrderNumber.Name = "clmProductionOrderNumber";
            this.clmProductionOrderNumber.ReadOnly = true;
            // 
            // clmProductionOrderBase
            // 
            this.clmProductionOrderBase.HeaderText = "Base";
            this.clmProductionOrderBase.Name = "clmProductionOrderBase";
            this.clmProductionOrderBase.ReadOnly = true;
            // 
            // clmProductionOrderMetal
            // 
            this.clmProductionOrderMetal.HeaderText = "Metal";
            this.clmProductionOrderMetal.Name = "clmProductionOrderMetal";
            this.clmProductionOrderMetal.ReadOnly = true;
            // 
            // clmProductionOrderWidths
            // 
            this.clmProductionOrderWidths.HeaderText = "Anchos";
            this.clmProductionOrderWidths.Name = "clmProductionOrderWidths";
            this.clmProductionOrderWidths.ReadOnly = true;
            // 
            // clmProductionOrderCoil
            // 
            this.clmProductionOrderCoil.HeaderText = "Bobinas";
            this.clmProductionOrderCoil.Name = "clmProductionOrderCoil";
            this.clmProductionOrderCoil.ReadOnly = true;
            this.clmProductionOrderCoil.Width = 125;
            // 
            // clmProductionOrderQuantity
            // 
            this.clmProductionOrderQuantity.HeaderText = "Kilos Solicitados";
            this.clmProductionOrderQuantity.Name = "clmProductionOrderQuantity";
            this.clmProductionOrderQuantity.ReadOnly = true;
            this.clmProductionOrderQuantity.Width = 125;
            // 
            // clmProductionOrderStatus
            // 
            this.clmProductionOrderStatus.HeaderText = "Estado";
            this.clmProductionOrderStatus.Name = "clmProductionOrderStatus";
            this.clmProductionOrderStatus.ReadOnly = true;
            this.clmProductionOrderStatus.Width = 120;
            // 
            // grpbProductionOrderFilters
            // 
            this.grpbProductionOrderFilters.Controls.Add(this.txtLotNumber);
            this.grpbProductionOrderFilters.Controls.Add(this.label1);
            this.grpbProductionOrderFilters.Controls.Add(this.btnProductionOrderClose);
            this.grpbProductionOrderFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbProductionOrderFilters.Location = new System.Drawing.Point(0, 467);
            this.grpbProductionOrderFilters.Name = "grpbProductionOrderFilters";
            this.grpbProductionOrderFilters.Size = new System.Drawing.Size(896, 43);
            this.grpbProductionOrderFilters.TabIndex = 18;
            this.grpbProductionOrderFilters.TabStop = false;
            // 
            // txtLotNumber
            // 
            this.txtLotNumber.Location = new System.Drawing.Point(363, 15);
            this.txtLotNumber.Name = "txtLotNumber";
            this.txtLotNumber.Size = new System.Drawing.Size(147, 21);
            this.txtLotNumber.TabIndex = 29;
            this.txtLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotNumber_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lote";
            // 
            // frmMetallizedProductionOrdenList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(896, 510);
            this.Controls.Add(this.grpbProductionOrderlList);
            this.Controls.Add(this.grpbProductionOrderFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMetallizedProductionOrdenList";
            this.Text = "Listado Ordenes de Producción Metalizado";
            this.grpbProductionOrderlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrderList)).EndInit();
            this.grpbProductionOrderFilters.ResumeLayout(false);
            this.grpbProductionOrderFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProductionOrderClose;
        private System.Windows.Forms.GroupBox grpbProductionOrderlList;
        private System.Windows.Forms.DataGridView dgvProductionOrderList;
        private System.Windows.Forms.GroupBox grpbProductionOrderFilters;
        private System.Windows.Forms.ToolTip ttpProductionOrderList;
        private System.Windows.Forms.TextBox txtLotNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderListFkFilmProductionOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderListFilmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderMetal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderWidths;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderStatus;
    }
}