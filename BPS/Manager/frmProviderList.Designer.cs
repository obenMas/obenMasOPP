namespace BPS
{
    partial class frmProviderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviderList));
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvProviders = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProviderId = new System.Windows.Forms.TextBox();
            this.lblProviderId = new System.Windows.Forms.Label();
            this.txtProviderName = new System.Windows.Forms.TextBox();
            this.lblProviderName = new System.Windows.Forms.Label();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEditCompany = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.ttpListProvider = new System.Windows.Forms.ToolTip(this.components);
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).BeginInit();
            this.grpbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvProviders);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(738, 440);
            this.grpbList.TabIndex = 6;
            this.grpbList.TabStop = false;
            // 
            // dgvProviders
            // 
            this.dgvProviders.AllowUserToAddRows = false;
            this.dgvProviders.AllowUserToDeleteRows = false;
            this.dgvProviders.AllowUserToOrderColumns = true;
            this.dgvProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCompany,
            this.clmName,
            this.clmCountry,
            this.clmStatus});
            this.dgvProviders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProviders.Location = new System.Drawing.Point(3, 17);
            this.dgvProviders.Name = "dgvProviders";
            this.dgvProviders.ReadOnly = true;
            this.dgvProviders.RowHeadersWidth = 21;
            this.dgvProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProviders.Size = new System.Drawing.Size(732, 420);
            this.dgvProviders.TabIndex = 0;
            this.dgvProviders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProviders_CellDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCompany
            // 
            this.clmCompany.HeaderText = "Compañía";
            this.clmCompany.Name = "clmCompany";
            this.clmCompany.ReadOnly = true;
            this.clmCompany.Width = 200;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Contacto";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 200;
            // 
            // clmCountry
            // 
            this.clmCountry.HeaderText = "País";
            this.clmCountry.Name = "clmCountry";
            this.clmCountry.ReadOnly = true;
            this.clmCountry.Width = 150;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Status";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // txtProviderId
            // 
            this.txtProviderId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProviderId.Location = new System.Drawing.Point(111, 14);
            this.txtProviderId.Name = "txtProviderId";
            this.txtProviderId.Size = new System.Drawing.Size(187, 21);
            this.txtProviderId.TabIndex = 5;
            this.txtProviderId.TextChanged += new System.EventHandler(this.txtProviderId_TextChanged);
            // 
            // lblProviderId
            // 
            this.lblProviderId.AutoSize = true;
            this.lblProviderId.Location = new System.Drawing.Point(88, 17);
            this.lblProviderId.Name = "lblProviderId";
            this.lblProviderId.Size = new System.Drawing.Size(17, 15);
            this.lblProviderId.TabIndex = 4;
            this.lblProviderId.Text = "Id";
            // 
            // txtProviderName
            // 
            this.txtProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProviderName.Location = new System.Drawing.Point(359, 14);
            this.txtProviderName.Name = "txtProviderName";
            this.txtProviderName.Size = new System.Drawing.Size(253, 21);
            this.txtProviderName.TabIndex = 7;
            this.txtProviderName.TextChanged += new System.EventHandler(this.txtProviderName_TextChanged);
            // 
            // lblProviderName
            // 
            this.lblProviderName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProviderName.AutoSize = true;
            this.lblProviderName.Location = new System.Drawing.Point(307, 17);
            this.lblProviderName.Name = "lblProviderName";
            this.lblProviderName.Size = new System.Drawing.Size(52, 15);
            this.lblProviderName.TabIndex = 6;
            this.lblProviderName.Text = "Nombre";
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.btnClose);
            this.grpbFilters.Controls.Add(this.txtProviderName);
            this.grpbFilters.Controls.Add(this.btnAdd);
            this.grpbFilters.Controls.Add(this.lblProviderName);
            this.grpbFilters.Controls.Add(this.txtProviderId);
            this.grpbFilters.Controls.Add(this.lblProviderId);
            this.grpbFilters.Controls.Add(this.btnEditCompany);
            this.grpbFilters.Controls.Add(this.btnAccept);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 440);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(738, 43);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(708, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 23;
            this.ttpListProvider.SetToolTip(this.btnClose, "Salir Proveedores");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(658, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 24;
            this.ttpListProvider.SetToolTip(this.btnAdd, "Agregar Proveedores");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEditCompany
            // 
            this.btnEditCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditCompany.BackgroundImage = global::BPS.Properties.Resources.pencil;
            this.btnEditCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditCompany.Location = new System.Drawing.Point(683, 14);
            this.btnEditCompany.Name = "btnEditCompany";
            this.btnEditCompany.Size = new System.Drawing.Size(25, 25);
            this.btnEditCompany.TabIndex = 21;
            this.ttpListProvider.SetToolTip(this.btnEditCompany, "Editar Proveedores");
            this.btnEditCompany.UseVisualStyleBackColor = true;
            this.btnEditCompany.Click += new System.EventHandler(this.btnEditCompany_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.BackgroundImage = global::BPS.Properties.Resources.accept;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAccept.Location = new System.Drawing.Point(683, 14);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(25, 25);
            this.btnAccept.TabIndex = 27;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmProviderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(738, 483);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProviderList";
            this.Text = "Listado de Proveedores";
            this.Load += new System.EventHandler(this.frmProviderList_Load);
            this.grpbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviders)).EndInit();
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.DataGridView dgvProviders;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.Button btnEditCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProviderName;
        private System.Windows.Forms.Label lblProviderName;
        private System.Windows.Forms.TextBox txtProviderId;
        private System.Windows.Forms.Label lblProviderId;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ToolTip ttpListProvider;
    }
}