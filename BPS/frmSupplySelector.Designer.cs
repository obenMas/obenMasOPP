namespace BPS
{
    partial class frmSupplySelector
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSupply = new System.Windows.Forms.DataGridView();
            this.clmSupplyCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyfkEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSupplyUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.ttpSupplySelector = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSupply);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 222);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dgvSupply
            // 
            this.dgvSupply.AllowUserToAddRows = false;
            this.dgvSupply.AllowUserToDeleteRows = false;
            this.dgvSupply.AllowUserToOrderColumns = true;
            this.dgvSupply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupply.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSupplyCodsec,
            this.clmSupplyEntity,
            this.clmSupplyfkEntity,
            this.clmSupplyName,
            this.clmSupplyCode,
            this.clmSupplyUnit});
            this.dgvSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSupply.Location = new System.Drawing.Point(3, 17);
            this.dgvSupply.Name = "dgvSupply";
            this.dgvSupply.ReadOnly = true;
            this.dgvSupply.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupply.Size = new System.Drawing.Size(549, 202);
            this.dgvSupply.TabIndex = 1;
            this.dgvSupply.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSupply_RowHeaderMouseDoubleClick);
            // 
            // clmSupplyCodsec
            // 
            this.clmSupplyCodsec.HeaderText = "Codsec";
            this.clmSupplyCodsec.Name = "clmSupplyCodsec";
            this.clmSupplyCodsec.ReadOnly = true;
            this.clmSupplyCodsec.Visible = false;
            // 
            // clmSupplyEntity
            // 
            this.clmSupplyEntity.HeaderText = "Proveedor";
            this.clmSupplyEntity.Name = "clmSupplyEntity";
            this.clmSupplyEntity.ReadOnly = true;
            // 
            // clmSupplyfkEntity
            // 
            this.clmSupplyfkEntity.HeaderText = "codsecEntity";
            this.clmSupplyfkEntity.Name = "clmSupplyfkEntity";
            this.clmSupplyfkEntity.ReadOnly = true;
            this.clmSupplyfkEntity.Visible = false;
            // 
            // clmSupplyName
            // 
            this.clmSupplyName.HeaderText = "Nombre";
            this.clmSupplyName.Name = "clmSupplyName";
            this.clmSupplyName.ReadOnly = true;
            this.clmSupplyName.Width = 200;
            // 
            // clmSupplyCode
            // 
            this.clmSupplyCode.HeaderText = "Código";
            this.clmSupplyCode.Name = "clmSupplyCode";
            this.clmSupplyCode.ReadOnly = true;
            // 
            // clmSupplyUnit
            // 
            this.clmSupplyUnit.HeaderText = "Unidad";
            this.clmSupplyUnit.Name = "clmSupplyUnit";
            this.clmSupplyUnit.ReadOnly = true;
            // 
            // grpbFilters
            // 
            this.grpbFilters.Location = new System.Drawing.Point(2, 217);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(468, 45);
            this.grpbFilters.TabIndex = 12;
            this.grpbFilters.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnAccept);
            this.groupBox2.Location = new System.Drawing.Point(473, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(76, 45);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(37, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 29);
            this.btnClose.TabIndex = 23;
            this.ttpSupplySelector.SetToolTip(this.btnClose, "Salir");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImage = global::BPS.Properties.Resources.accept;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.Location = new System.Drawing.Point(3, 13);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(34, 29);
            this.btnAccept.TabIndex = 27;
            this.ttpSupplySelector.SetToolTip(this.btnAccept, "Aceptar");
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmSupplySelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 264);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilters);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSupplySelector";
            this.Text = "Seleccionar Suministro";
            this.Load += new System.EventHandler(this.frmSupplySelector_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupply)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSupply;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyfkEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSupplyUnit;
        private System.Windows.Forms.ToolTip ttpSupplySelector;
    }
}