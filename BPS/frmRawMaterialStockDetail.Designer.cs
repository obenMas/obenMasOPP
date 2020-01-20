namespace BPS
{
    partial class frmRawMaterialStockDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialStockDetail));
            this.dgvStockDetail = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbRawMaterialStock = new System.Windows.Forms.GroupBox();
            this.ttpRawMaterialStockDetail = new System.Windows.Forms.ToolTip(this.components);
            this.clmRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetail)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.grpbRawMaterialStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStockDetail
            // 
            this.dgvStockDetail.AllowUserToAddRows = false;
            this.dgvStockDetail.AllowUserToDeleteRows = false;
            this.dgvStockDetail.AllowUserToOrderColumns = true;
            this.dgvStockDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialCodsec,
            this.clmName,
            this.clmCode,
            this.clmStock});
            this.dgvStockDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStockDetail.Location = new System.Drawing.Point(3, 17);
            this.dgvStockDetail.Name = "dgvStockDetail";
            this.dgvStockDetail.ReadOnly = true;
            this.dgvStockDetail.Size = new System.Drawing.Size(474, 235);
            this.dgvStockDetail.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 263);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 46);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(431, 263);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(46, 46);
            this.grpbActions.TabIndex = 16;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(6, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 30);
            this.btnClose.TabIndex = 3;
            this.ttpRawMaterialStockDetail.SetToolTip(this.btnClose, "Salir Stock Materia Prima");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbRawMaterialStock
            // 
            this.grpbRawMaterialStock.Controls.Add(this.dgvStockDetail);
            this.grpbRawMaterialStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbRawMaterialStock.Location = new System.Drawing.Point(0, 0);
            this.grpbRawMaterialStock.Name = "grpbRawMaterialStock";
            this.grpbRawMaterialStock.Size = new System.Drawing.Size(480, 264);
            this.grpbRawMaterialStock.TabIndex = 15;
            this.grpbRawMaterialStock.TabStop = false;
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
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 140;
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            this.clmStock.ReadOnly = true;
            this.clmStock.Width = 150;
            // 
            // frmRawMaterialStockDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(480, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbActions);
            this.Controls.Add(this.grpbRawMaterialStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialStockDetail";
            this.Text = "Detalle Stock Materia Prima";
            this.Load += new System.EventHandler(this.frmRawMaterialStockDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockDetail)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.grpbRawMaterialStock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbRawMaterialStock;
        private System.Windows.Forms.ToolTip ttpRawMaterialStockDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
    }
}