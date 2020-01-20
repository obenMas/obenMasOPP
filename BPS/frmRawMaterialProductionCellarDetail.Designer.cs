namespace BPS
{
    partial class frmRawMaterialProductionCellarDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialProductionCellarDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbRawMaterialStock = new System.Windows.Forms.GroupBox();
            this.dgvStockProductionDetail = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpStock = new System.Windows.Forms.ToolTip(this.components);
            this.grpbRawMaterialStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductionDetail)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(5, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // grpbRawMaterialStock
            // 
            this.grpbRawMaterialStock.Controls.Add(this.dgvStockProductionDetail);
            this.grpbRawMaterialStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRawMaterialStock.Location = new System.Drawing.Point(0, 0);
            this.grpbRawMaterialStock.Name = "grpbRawMaterialStock";
            this.grpbRawMaterialStock.Size = new System.Drawing.Size(399, 305);
            this.grpbRawMaterialStock.TabIndex = 18;
            this.grpbRawMaterialStock.TabStop = false;
            // 
            // dgvStockProductionDetail
            // 
            this.dgvStockProductionDetail.AllowUserToAddRows = false;
            this.dgvStockProductionDetail.AllowUserToDeleteRows = false;
            this.dgvStockProductionDetail.AllowUserToOrderColumns = true;
            this.dgvStockProductionDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockProductionDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialCodsec,
            this.clmName,
            this.clmStock});
            this.dgvStockProductionDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStockProductionDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvStockProductionDetail.Name = "dgvStockProductionDetail";
            this.dgvStockProductionDetail.ReadOnly = true;
            this.dgvStockProductionDetail.Size = new System.Drawing.Size(393, 271);
            this.dgvStockProductionDetail.TabIndex = 0;
            // 
            // clmRawMaterialCodsec
            // 
            this.clmRawMaterialCodsec.HeaderText = "fkRawMaterial";
            this.clmRawMaterialCodsec.Name = "clmRawMaterialCodsec";
            this.clmRawMaterialCodsec.ReadOnly = true;
            this.clmRawMaterialCodsec.Visible = false;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Materia Prima";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 140;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 150;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(341, 306);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(54, 53);
            this.grpbActions.TabIndex = 19;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(7, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 35);
            this.btnClose.TabIndex = 3;
            this.ttpStock.SetToolTip(this.btnClose, "Salir Detalle Stock Materia Prima Bodega de Producción");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRawMaterialProductionCellarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(399, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbRawMaterialStock);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialProductionCellarDetail";
            this.Text = "Detalle Stock  M.P. Bodega de Producción";
            this.Load += new System.EventHandler(this.frmRawMaterialProductionCellarDetail_Load);
            this.grpbRawMaterialStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductionDetail)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbRawMaterialStock;
        private System.Windows.Forms.DataGridView dgvStockProductionDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip ttpStock;
    }
}