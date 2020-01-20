namespace BPS
{
    partial class frmProductionOrdenList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductionOrdenList));
            this.btnProductionOrderClose = new System.Windows.Forms.Button();
            this.grpbProductionOrderlList = new System.Windows.Forms.GroupBox();
            this.dgvProductionOrderList = new System.Windows.Forms.DataGridView();
            this.btnProductionOrderAccept = new System.Windows.Forms.Button();
            this.grpbProductionOrderFilters = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBopp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.ttpProductionOrderList = new System.Windows.Forms.ToolTip(this.components);
            this.clmProductionOrderListCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderListFilmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderWidths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderFulfilledQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderPendingQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductionOrderVariation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbProductionOrderlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionOrderList)).BeginInit();
            this.grpbProductionOrderFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProductionOrderClose
            // 
            this.btnProductionOrderClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnProductionOrderClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionOrderClose.Location = new System.Drawing.Point(1008, 12);
            this.btnProductionOrderClose.Name = "btnProductionOrderClose";
            this.btnProductionOrderClose.Size = new System.Drawing.Size(25, 25);
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
            this.grpbProductionOrderlList.Size = new System.Drawing.Size(1047, 467);
            this.grpbProductionOrderlList.TabIndex = 17;
            this.grpbProductionOrderlList.TabStop = false;
            this.grpbProductionOrderlList.Text = "Ordenes Extrusión";
            // 
            // dgvProductionOrderList
            // 
            this.dgvProductionOrderList.AllowUserToAddRows = false;
            this.dgvProductionOrderList.AllowUserToDeleteRows = false;
            this.dgvProductionOrderList.AllowUserToOrderColumns = true;
            this.dgvProductionOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductionOrderListCodsec,
            this.clmProductionOrderListFilmType,
            this.clmProductionOrderNumber,
            this.clmProductionOrderFilm,
            this.clmProductionOrderWidths,
            this.clmProductionOrderLength,
            this.clmProductionOrderQuantity,
            this.clmProductionOrderFulfilledQuantity,
            this.clmProductionOrderPendingQuantity,
            this.clmProductionOrderStatus,
            this.clmProductionOrderVariation});
            this.dgvProductionOrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductionOrderList.Location = new System.Drawing.Point(3, 17);
            this.dgvProductionOrderList.Name = "dgvProductionOrderList";
            this.dgvProductionOrderList.ReadOnly = true;
            this.dgvProductionOrderList.RowHeadersWidth = 31;
            this.dgvProductionOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductionOrderList.Size = new System.Drawing.Size(1041, 447);
            this.dgvProductionOrderList.TabIndex = 1;
            this.dgvProductionOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductionOrderList_CellDoubleClick);
            // 
            // btnProductionOrderAccept
            // 
            this.btnProductionOrderAccept.BackgroundImage = global::BPS.Properties.Resources.accept;
            this.btnProductionOrderAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionOrderAccept.Location = new System.Drawing.Point(983, 12);
            this.btnProductionOrderAccept.Name = "btnProductionOrderAccept";
            this.btnProductionOrderAccept.Size = new System.Drawing.Size(25, 25);
            this.btnProductionOrderAccept.TabIndex = 27;
            this.ttpProductionOrderList.SetToolTip(this.btnProductionOrderAccept, "Seleccionar Ordenes de Producción");
            this.btnProductionOrderAccept.UseVisualStyleBackColor = true;
            this.btnProductionOrderAccept.Click += new System.EventHandler(this.btnProductionOrderAccept_Click);
            // 
            // grpbProductionOrderFilters
            // 
            this.grpbProductionOrderFilters.Controls.Add(this.label2);
            this.grpbProductionOrderFilters.Controls.Add(this.cmbBopp);
            this.grpbProductionOrderFilters.Controls.Add(this.label1);
            this.grpbProductionOrderFilters.Controls.Add(this.txtLot);
            this.grpbProductionOrderFilters.Controls.Add(this.btnProductionOrderClose);
            this.grpbProductionOrderFilters.Controls.Add(this.btnProductionOrderAccept);
            this.grpbProductionOrderFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbProductionOrderFilters.Location = new System.Drawing.Point(0, 467);
            this.grpbProductionOrderFilters.Name = "grpbProductionOrderFilters";
            this.grpbProductionOrderFilters.Size = new System.Drawing.Size(1047, 43);
            this.grpbProductionOrderFilters.TabIndex = 18;
            this.grpbProductionOrderFilters.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Película";
            // 
            // cmbBopp
            // 
            this.cmbBopp.FormattingEnabled = true;
            this.cmbBopp.Location = new System.Drawing.Point(445, 14);
            this.cmbBopp.Name = "cmbBopp";
            this.cmbBopp.Size = new System.Drawing.Size(317, 23);
            this.cmbBopp.TabIndex = 31;
            this.cmbBopp.SelectedIndexChanged += new System.EventHandler(this.cmbBopp_SelectedIndexChanged);
            this.cmbBopp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbBopp_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lote";
            // 
            // txtLot
            // 
            this.txtLot.Location = new System.Drawing.Point(187, 14);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(151, 21);
            this.txtLot.TabIndex = 29;
            this.txtLot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLot_KeyDown);
            // 
            // clmProductionOrderListCodsec
            // 
            this.clmProductionOrderListCodsec.HeaderText = "Codsec";
            this.clmProductionOrderListCodsec.Name = "clmProductionOrderListCodsec";
            this.clmProductionOrderListCodsec.ReadOnly = true;
            this.clmProductionOrderListCodsec.Visible = false;
            this.clmProductionOrderListCodsec.Width = 200;
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
            // clmProductionOrderFilm
            // 
            this.clmProductionOrderFilm.HeaderText = "Película";
            this.clmProductionOrderFilm.Name = "clmProductionOrderFilm";
            this.clmProductionOrderFilm.ReadOnly = true;
            // 
            // clmProductionOrderWidths
            // 
            this.clmProductionOrderWidths.HeaderText = "Anchos";
            this.clmProductionOrderWidths.Name = "clmProductionOrderWidths";
            this.clmProductionOrderWidths.ReadOnly = true;
            // 
            // clmProductionOrderLength
            // 
            this.clmProductionOrderLength.HeaderText = "Metraje";
            this.clmProductionOrderLength.Name = "clmProductionOrderLength";
            this.clmProductionOrderLength.ReadOnly = true;
            // 
            // clmProductionOrderQuantity
            // 
            this.clmProductionOrderQuantity.HeaderText = "Kilos Pedidos";
            this.clmProductionOrderQuantity.Name = "clmProductionOrderQuantity";
            this.clmProductionOrderQuantity.ReadOnly = true;
            this.clmProductionOrderQuantity.Width = 125;
            // 
            // clmProductionOrderFulfilledQuantity
            // 
            this.clmProductionOrderFulfilledQuantity.HeaderText = "Kilos Cumplidos";
            this.clmProductionOrderFulfilledQuantity.Name = "clmProductionOrderFulfilledQuantity";
            this.clmProductionOrderFulfilledQuantity.ReadOnly = true;
            this.clmProductionOrderFulfilledQuantity.Width = 125;
            // 
            // clmProductionOrderPendingQuantity
            // 
            this.clmProductionOrderPendingQuantity.HeaderText = "Kilos Pendientes";
            this.clmProductionOrderPendingQuantity.Name = "clmProductionOrderPendingQuantity";
            this.clmProductionOrderPendingQuantity.ReadOnly = true;
            this.clmProductionOrderPendingQuantity.Width = 125;
            // 
            // clmProductionOrderStatus
            // 
            this.clmProductionOrderStatus.HeaderText = "Estado";
            this.clmProductionOrderStatus.Name = "clmProductionOrderStatus";
            this.clmProductionOrderStatus.ReadOnly = true;
            this.clmProductionOrderStatus.Width = 120;
            // 
            // clmProductionOrderVariation
            // 
            this.clmProductionOrderVariation.HeaderText = "Variación";
            this.clmProductionOrderVariation.Name = "clmProductionOrderVariation";
            this.clmProductionOrderVariation.ReadOnly = true;
            this.clmProductionOrderVariation.Width = 60;
            // 
            // frmProductionOrdenList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1047, 510);
            this.Controls.Add(this.grpbProductionOrderlList);
            this.Controls.Add(this.grpbProductionOrderFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductionOrdenList";
            this.Text = "Listado Ordenes de Producción";
            this.Load += new System.EventHandler(this.frmProductionOrdenList_Load);
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
        private System.Windows.Forms.Button btnProductionOrderAccept;
        private System.Windows.Forms.GroupBox grpbProductionOrderFilters;
        private System.Windows.Forms.ToolTip ttpProductionOrderList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBopp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderListCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderListFilmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderWidths;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderFulfilledQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderPendingQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductionOrderVariation;
    }
}