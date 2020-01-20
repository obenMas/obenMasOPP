namespace BPS
{
    partial class frmRawMaterialProductionCellar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialProductionCellar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnProductionCellarClose = new System.Windows.Forms.Button();
            this.dgvProduccionStock = new System.Windows.Forms.DataGridView();
            this.ttpStockProdcution = new System.Windows.Forms.ToolTip(this.components);
            this.clmfkRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionStock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnProductionCellarClose);
            this.grpbActions.Location = new System.Drawing.Point(659, 214);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(49, 46);
            this.grpbActions.TabIndex = 16;
            this.grpbActions.TabStop = false;
            // 
            // btnProductionCellarClose
            // 
            this.btnProductionCellarClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnProductionCellarClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProductionCellarClose.Location = new System.Drawing.Point(7, 12);
            this.btnProductionCellarClose.Name = "btnProductionCellarClose";
            this.btnProductionCellarClose.Size = new System.Drawing.Size(34, 30);
            this.btnProductionCellarClose.TabIndex = 3;
            this.ttpStockProdcution.SetToolTip(this.btnProductionCellarClose, "Salir Stock Bodega Producción");
            this.btnProductionCellarClose.UseVisualStyleBackColor = true;
            this.btnProductionCellarClose.Click += new System.EventHandler(this.btnProductionCellarClose_Click);
            // 
            // dgvProduccionStock
            // 
            this.dgvProduccionStock.AllowUserToAddRows = false;
            this.dgvProduccionStock.AllowUserToDeleteRows = false;
            this.dgvProduccionStock.AllowUserToOrderColumns = true;
            this.dgvProduccionStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduccionStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmfkRawMaterialType,
            this.clmRawMaterialTypeName,
            this.clmfkRawMaterial,
            this.clmRawMaterialCode,
            this.clmRawMaterialName,
            this.clmStock});
            this.dgvProduccionStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProduccionStock.Location = new System.Drawing.Point(0, 0);
            this.dgvProduccionStock.Name = "dgvProduccionStock";
            this.dgvProduccionStock.ReadOnly = true;
            this.dgvProduccionStock.Size = new System.Drawing.Size(713, 214);
            this.dgvProduccionStock.TabIndex = 15;
            this.dgvProduccionStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduccionStock_CellContentClick);
            // 
            // clmfkRawMaterialType
            // 
            this.clmfkRawMaterialType.HeaderText = "fkRawMaterialType";
            this.clmfkRawMaterialType.Name = "clmfkRawMaterialType";
            this.clmfkRawMaterialType.ReadOnly = true;
            this.clmfkRawMaterialType.Visible = false;
            // 
            // clmRawMaterialTypeName
            // 
            this.clmRawMaterialTypeName.HeaderText = "Tipo Materia Prima";
            this.clmRawMaterialTypeName.Name = "clmRawMaterialTypeName";
            this.clmRawMaterialTypeName.ReadOnly = true;
            this.clmRawMaterialTypeName.Width = 180;
            // 
            // clmfkRawMaterial
            // 
            this.clmfkRawMaterial.HeaderText = "fkRawMaterial";
            this.clmfkRawMaterial.Name = "clmfkRawMaterial";
            this.clmfkRawMaterial.ReadOnly = true;
            this.clmfkRawMaterial.Visible = false;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código M.P.";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Nombre M.P.";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            this.clmRawMaterialName.Width = 240;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 150;
            // 
            // frmRawMaterialProductionCellar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(713, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.dgvProduccionStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialProductionCellar";
            this.Text = "Stock Bodega Producción";
            this.Load += new System.EventHandler(this.frmRawMaterialProductionCellar_Load);
            this.grpbActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduccionStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnProductionCellarClose;
        private System.Windows.Forms.DataGridView dgvProduccionStock;
        private System.Windows.Forms.ToolTip ttpStockProdcution;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
    }
}