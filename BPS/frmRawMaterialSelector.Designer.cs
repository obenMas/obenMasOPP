namespace BPS
{
    partial class frmRawMaterialSelector
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialSelector));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.clmRawMaterialCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.txtTMP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.ttpRawMaterialSelector = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            this.grpbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRawMaterial);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias primas";
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.AllowUserToAddRows = false;
            this.dgvRawMaterial.AllowUserToDeleteRows = false;
            this.dgvRawMaterial.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRawMaterialCodsec,
            this.clmRawMaterialEntity,
            this.clmRawMaterialType,
            this.clmRawMaterialCode,
            this.clmRawMaterialUnit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMaterial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMaterial.Location = new System.Drawing.Point(3, 16);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            this.dgvRawMaterial.ReadOnly = true;
            this.dgvRawMaterial.RowHeadersWidth = 21;
            this.dgvRawMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRawMaterial.Size = new System.Drawing.Size(731, 380);
            this.dgvRawMaterial.TabIndex = 1;
            this.dgvRawMaterial.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRawMaterial_CellMouseDoubleClick);
            // 
            // clmRawMaterialCodsec
            // 
            this.clmRawMaterialCodsec.HeaderText = "Codsec";
            this.clmRawMaterialCodsec.Name = "clmRawMaterialCodsec";
            this.clmRawMaterialCodsec.ReadOnly = true;
            this.clmRawMaterialCodsec.Visible = false;
            this.clmRawMaterialCodsec.Width = 130;
            // 
            // clmRawMaterialEntity
            // 
            this.clmRawMaterialEntity.HeaderText = "Proveedor";
            this.clmRawMaterialEntity.Name = "clmRawMaterialEntity";
            this.clmRawMaterialEntity.ReadOnly = true;
            this.clmRawMaterialEntity.Width = 150;
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            this.clmRawMaterialType.Width = 140;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            this.clmRawMaterialCode.Width = 160;
            // 
            // clmRawMaterialUnit
            // 
            this.clmRawMaterialUnit.HeaderText = "Nombre";
            this.clmRawMaterialUnit.Name = "clmRawMaterialUnit";
            this.clmRawMaterialUnit.ReadOnly = true;
            this.clmRawMaterialUnit.Width = 180;
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.txtTMP);
            this.grpbFilters.Controls.Add(this.label1);
            this.grpbFilters.Controls.Add(this.btnAdd);
            this.grpbFilters.Controls.Add(this.btnAccept);
            this.grpbFilters.Controls.Add(this.txtProvider);
            this.grpbFilters.Controls.Add(this.lblCustomerName);
            this.grpbFilters.Controls.Add(this.txtCode);
            this.grpbFilters.Controls.Add(this.lblCode);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 399);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(737, 79);
            this.grpbFilters.TabIndex = 9;
            this.grpbFilters.TabStop = false;
            // 
            // txtTMP
            // 
            this.txtTMP.Enabled = false;
            this.txtTMP.Location = new System.Drawing.Point(84, 46);
            this.txtTMP.Name = "txtTMP";
            this.txtTMP.Size = new System.Drawing.Size(234, 21);
            this.txtTMP.TabIndex = 30;
            this.txtTMP.TextChanged += new System.EventHandler(this.txtTMP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "TMP";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(679, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 28;
            this.ttpRawMaterialSelector.SetToolTip(this.btnAdd, "Seleccionar Materia Prima");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackgroundImage = global::BPS.Properties.Resources.accept;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.Location = new System.Drawing.Point(706, 44);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(25, 25);
            this.btnAccept.TabIndex = 27;
            this.ttpRawMaterialSelector.SetToolTip(this.btnAccept, "Seleccionar Materia Prima");
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtProvider
            // 
            this.txtProvider.Enabled = false;
            this.txtProvider.Location = new System.Drawing.Point(84, 16);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.Size = new System.Drawing.Size(573, 21);
            this.txtProvider.TabIndex = 11;
            this.txtProvider.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Enabled = false;
            this.lblCustomerName.Location = new System.Drawing.Point(15, 19);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(63, 15);
            this.lblCustomerName.TabIndex = 10;
            this.lblCustomerName.Text = "Proveedor";
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(423, 46);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(234, 21);
            this.txtCode.TabIndex = 9;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCustomerId_TextChanged);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Enabled = false;
            this.lblCode.Location = new System.Drawing.Point(371, 49);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 15);
            this.lblCode.TabIndex = 8;
            this.lblCode.Text = "Código";
            // 
            // frmRawMaterialSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(737, 478);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialSelector";
            this.Text = "Listado Materia Prima";
            this.Load += new System.EventHandler(this.frmRawMaterialSelector_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.TextBox txtProvider;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ToolTip ttpRawMaterialSelector;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialUnit;
        private System.Windows.Forms.TextBox txtTMP;
        private System.Windows.Forms.Label label1;
    }
}