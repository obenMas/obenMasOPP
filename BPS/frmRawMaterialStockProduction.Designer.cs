namespace BPS
{
    partial class frmRawMaterialStockProduction
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
            this.grpbRawMaterialStock = new System.Windows.Forms.GroupBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.clmfkRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpRawMaterialStockProduction = new System.Windows.Forms.ToolTip(this.components);
            this.grpbRawMaterialStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbRawMaterialStock
            // 
            this.grpbRawMaterialStock.Controls.Add(this.dgvStock);
            this.grpbRawMaterialStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRawMaterialStock.Location = new System.Drawing.Point(0, 0);
            this.grpbRawMaterialStock.Name = "grpbRawMaterialStock";
            this.grpbRawMaterialStock.Size = new System.Drawing.Size(342, 229);
            this.grpbRawMaterialStock.TabIndex = 15;
            this.grpbRawMaterialStock.TabStop = false;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AllowUserToOrderColumns = true;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmfkRawMaterialType,
            this.clmName,
            this.clmStock});
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStock.Location = new System.Drawing.Point(3, 16);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.Size = new System.Drawing.Size(336, 204);
            this.dgvStock.TabIndex = 0;
            // 
            // clmfkRawMaterialType
            // 
            this.clmfkRawMaterialType.HeaderText = "fkRawMaterialType";
            this.clmfkRawMaterialType.Name = "clmfkRawMaterialType";
            this.clmfkRawMaterialType.ReadOnly = true;
            this.clmfkRawMaterialType.Visible = false;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Tipo Materia Prima";
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(2, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 40);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(296, 224);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(42, 40);
            this.grpbActions.TabIndex = 16;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(6, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 26);
            this.btnClose.TabIndex = 3;
            this.ttpRawMaterialStockProduction.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmRawMaterialStockProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 267);
            this.Controls.Add(this.grpbRawMaterialStock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbActions);
            this.Name = "frmRawMaterialStockProduction";
            this.Text = "frmRawMaterialStockProduction";
            this.grpbRawMaterialStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbRawMaterialStock;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.ToolTip ttpRawMaterialStockProduction;
    }
}