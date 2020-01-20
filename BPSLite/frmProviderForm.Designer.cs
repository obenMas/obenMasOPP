namespace BPS.Lite
{
    partial class frmProviderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProviderForm));
            this.tctrlProviderAddress = new System.Windows.Forms.TabControl();
            this.tbpAddressForm = new System.Windows.Forms.TabPage();
            this.grpbAddressForm = new System.Windows.Forms.GroupBox();
            this.lblAddressName = new System.Windows.Forms.Label();
            this.lblPhones = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddressContact = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtAddressName = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtAddressContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveAddress = new System.Windows.Forms.Button();
            this.btnCancelAddress = new System.Windows.Forms.Button();
            this.tpbAddressList = new System.Windows.Forms.TabPage();
            this.grp_ProviderAddresInfo = new System.Windows.Forms.GroupBox();
            this.dgvProviderAddress = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.btnEditAddress = new System.Windows.Forms.Button();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.grpobCustomerInfo = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbProviderCountry = new System.Windows.Forms.ComboBox();
            this.lblProviderCountry = new System.Windows.Forms.Label();
            this.brnSave = new System.Windows.Forms.Button();
            this.brnCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.cmbIdType = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIdType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.ttpProviderManager = new System.Windows.Forms.ToolTip(this.components);
            this.tctrlProviderAddress.SuspendLayout();
            this.tbpAddressForm.SuspendLayout();
            this.grpbAddressForm.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tpbAddressList.SuspendLayout();
            this.grp_ProviderAddresInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderAddress)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpobCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctrlProviderAddress
            // 
            this.tctrlProviderAddress.Controls.Add(this.tbpAddressForm);
            this.tctrlProviderAddress.Controls.Add(this.tpbAddressList);
            this.tctrlProviderAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctrlProviderAddress.Location = new System.Drawing.Point(0, 151);
            this.tctrlProviderAddress.Name = "tctrlProviderAddress";
            this.tctrlProviderAddress.SelectedIndex = 0;
            this.tctrlProviderAddress.Size = new System.Drawing.Size(739, 323);
            this.tctrlProviderAddress.TabIndex = 0;
            // 
            // tbpAddressForm
            // 
            this.tbpAddressForm.BackColor = System.Drawing.SystemColors.Control;
            this.tbpAddressForm.Controls.Add(this.grpbAddressForm);
            this.tbpAddressForm.Controls.Add(this.groupBox3);
            this.tbpAddressForm.Location = new System.Drawing.Point(4, 24);
            this.tbpAddressForm.Name = "tbpAddressForm";
            this.tbpAddressForm.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAddressForm.Size = new System.Drawing.Size(731, 295);
            this.tbpAddressForm.TabIndex = 1;
            this.tbpAddressForm.Text = "Formulario";
            // 
            // grpbAddressForm
            // 
            this.grpbAddressForm.BackColor = System.Drawing.SystemColors.Window;
            this.grpbAddressForm.Controls.Add(this.lblAddressName);
            this.grpbAddressForm.Controls.Add(this.lblPhones);
            this.grpbAddressForm.Controls.Add(this.lblCity);
            this.grpbAddressForm.Controls.Add(this.lblAddressContact);
            this.grpbAddressForm.Controls.Add(this.lblState);
            this.grpbAddressForm.Controls.Add(this.lblEmail);
            this.grpbAddressForm.Controls.Add(this.cmbCity);
            this.grpbAddressForm.Controls.Add(this.lblZip);
            this.grpbAddressForm.Controls.Add(this.cmbCounty);
            this.grpbAddressForm.Controls.Add(this.lblAddress);
            this.grpbAddressForm.Controls.Add(this.cmbState);
            this.grpbAddressForm.Controls.Add(this.lblFax);
            this.grpbAddressForm.Controls.Add(this.lblCountry);
            this.grpbAddressForm.Controls.Add(this.txtAddressName);
            this.grpbAddressForm.Controls.Add(this.txtFax);
            this.grpbAddressForm.Controls.Add(this.txtAddressContact);
            this.grpbAddressForm.Controls.Add(this.txtEmail);
            this.grpbAddressForm.Controls.Add(this.txtAddress);
            this.grpbAddressForm.Controls.Add(this.txtZip);
            this.grpbAddressForm.Controls.Add(this.txtPhone1);
            this.grpbAddressForm.Controls.Add(this.txtPhone2);
            this.grpbAddressForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbAddressForm.Enabled = false;
            this.grpbAddressForm.Location = new System.Drawing.Point(3, 3);
            this.grpbAddressForm.Name = "grpbAddressForm";
            this.grpbAddressForm.Size = new System.Drawing.Size(725, 249);
            this.grpbAddressForm.TabIndex = 47;
            this.grpbAddressForm.TabStop = false;
            // 
            // lblAddressName
            // 
            this.lblAddressName.AutoSize = true;
            this.lblAddressName.Location = new System.Drawing.Point(5, 62);
            this.lblAddressName.Name = "lblAddressName";
            this.lblAddressName.Size = new System.Drawing.Size(52, 15);
            this.lblAddressName.TabIndex = 23;
            this.lblAddressName.Text = "Nombre";
            // 
            // lblPhones
            // 
            this.lblPhones.AutoSize = true;
            this.lblPhones.Location = new System.Drawing.Point(5, 144);
            this.lblPhones.Name = "lblPhones";
            this.lblPhones.Size = new System.Drawing.Size(61, 15);
            this.lblPhones.TabIndex = 24;
            this.lblPhones.Text = "Teléfonos";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(474, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(46, 15);
            this.lblCity.TabIndex = 43;
            this.lblCity.Text = "Ciudad";
            // 
            // lblAddressContact
            // 
            this.lblAddressContact.AutoSize = true;
            this.lblAddressContact.Location = new System.Drawing.Point(366, 62);
            this.lblAddressContact.Name = "lblAddressContact";
            this.lblAddressContact.Size = new System.Drawing.Size(55, 15);
            this.lblAddressContact.TabIndex = 25;
            this.lblAddressContact.Text = "Contacto";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(251, 89);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(45, 15);
            this.lblState.TabIndex = 42;
            this.lblState.Text = "Estado";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(5, 172);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // cmbCity
            // 
            this.cmbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(526, 86);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(193, 23);
            this.cmbCity.TabIndex = 5;
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(455, 172);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(24, 15);
            this.lblZip.TabIndex = 27;
            this.lblZip.Text = "Zip";
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Location = new System.Drawing.Point(68, 86);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(161, 23);
            this.cmbCounty.TabIndex = 3;
            this.cmbCounty.SelectedIndexChanged += new System.EventHandler(this.cmbCounty_SelectedIndexChanged);
            this.cmbCounty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCounty_KeyDown);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(5, 118);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 15);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "Dirección";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(302, 86);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(161, 23);
            this.cmbState.TabIndex = 4;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(454, 145);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(27, 15);
            this.lblFax.TabIndex = 29;
            this.lblFax.Text = "Fax";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(5, 89);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(31, 15);
            this.lblCountry.TabIndex = 38;
            this.lblCountry.Text = "País";
            // 
            // txtAddressName
            // 
            this.txtAddressName.Location = new System.Drawing.Point(68, 59);
            this.txtAddressName.Name = "txtAddressName";
            this.txtAddressName.Size = new System.Drawing.Size(258, 21);
            this.txtAddressName.TabIndex = 1;
            // 
            // txtFax
            // 
            this.txtFax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFax.Location = new System.Drawing.Point(485, 141);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(234, 21);
            this.txtFax.TabIndex = 9;
            // 
            // txtAddressContact
            // 
            this.txtAddressContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddressContact.Location = new System.Drawing.Point(427, 59);
            this.txtAddressContact.Name = "txtAddressContact";
            this.txtAddressContact.Size = new System.Drawing.Size(290, 21);
            this.txtAddressContact.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(68, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(381, 21);
            this.txtEmail.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(70, 115);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(649, 21);
            this.txtAddress.TabIndex = 6;
            // 
            // txtZip
            // 
            this.txtZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZip.Location = new System.Drawing.Point(485, 169);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(234, 21);
            this.txtZip.TabIndex = 11;
            // 
            // txtPhone1
            // 
            this.txtPhone1.Location = new System.Drawing.Point(68, 142);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(186, 21);
            this.txtPhone1.TabIndex = 7;
            // 
            // txtPhone2
            // 
            this.txtPhone2.Location = new System.Drawing.Point(262, 142);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(186, 21);
            this.txtPhone2.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.btnSaveAddress);
            this.groupBox3.Controls.Add(this.btnCancelAddress);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 40);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // btnSaveAddress
            // 
            this.btnSaveAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAddress.BackgroundImage")));
            this.btnSaveAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveAddress.Location = new System.Drawing.Point(673, 11);
            this.btnSaveAddress.Name = "btnSaveAddress";
            this.btnSaveAddress.Size = new System.Drawing.Size(25, 25);
            this.btnSaveAddress.TabIndex = 12;
            this.ttpProviderManager.SetToolTip(this.btnSaveAddress, "Guardar Dirección Proveedor");
            this.btnSaveAddress.UseVisualStyleBackColor = true;
            this.btnSaveAddress.Click += new System.EventHandler(this.btnSaveAddress_Click);
            // 
            // btnCancelAddress
            // 
            this.btnCancelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddress.BackgroundImage = global::BPS.Lite.Properties.Resources.cancel;
            this.btnCancelAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelAddress.Location = new System.Drawing.Point(698, 11);
            this.btnCancelAddress.Name = "btnCancelAddress";
            this.btnCancelAddress.Size = new System.Drawing.Size(25, 25);
            this.btnCancelAddress.TabIndex = 13;
            this.ttpProviderManager.SetToolTip(this.btnCancelAddress, "Cancelar Dirección Proveedor");
            this.btnCancelAddress.UseVisualStyleBackColor = true;
            this.btnCancelAddress.Click += new System.EventHandler(this.btnCancelAddress_Click);
            // 
            // tpbAddressList
            // 
            this.tpbAddressList.BackColor = System.Drawing.SystemColors.Window;
            this.tpbAddressList.Controls.Add(this.grp_ProviderAddresInfo);
            this.tpbAddressList.Controls.Add(this.groupBox2);
            this.tpbAddressList.Location = new System.Drawing.Point(4, 24);
            this.tpbAddressList.Name = "tpbAddressList";
            this.tpbAddressList.Padding = new System.Windows.Forms.Padding(3);
            this.tpbAddressList.Size = new System.Drawing.Size(731, 295);
            this.tpbAddressList.TabIndex = 0;
            this.tpbAddressList.Text = "Direcciones";
            // 
            // grp_ProviderAddresInfo
            // 
            this.grp_ProviderAddresInfo.Controls.Add(this.dgvProviderAddress);
            this.grp_ProviderAddresInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_ProviderAddresInfo.Location = new System.Drawing.Point(3, 3);
            this.grp_ProviderAddresInfo.Name = "grp_ProviderAddresInfo";
            this.grp_ProviderAddresInfo.Size = new System.Drawing.Size(725, 248);
            this.grp_ProviderAddresInfo.TabIndex = 4;
            this.grp_ProviderAddresInfo.TabStop = false;
            // 
            // dgvProviderAddress
            // 
            this.dgvProviderAddress.AllowUserToAddRows = false;
            this.dgvProviderAddress.AllowUserToDeleteRows = false;
            this.dgvProviderAddress.AllowUserToOrderColumns = true;
            this.dgvProviderAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProviderAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmName,
            this.clmCity,
            this.clmAddress,
            this.clmTelephone,
            this.clmEmail});
            this.dgvProviderAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProviderAddress.Location = new System.Drawing.Point(3, 17);
            this.dgvProviderAddress.Name = "dgvProviderAddress";
            this.dgvProviderAddress.ReadOnly = true;
            this.dgvProviderAddress.RowHeadersWidth = 21;
            this.dgvProviderAddress.Size = new System.Drawing.Size(719, 228);
            this.dgvProviderAddress.TabIndex = 0;
            this.dgvProviderAddress.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvProviderAddress_RowHeaderMouseDoubleClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Nombre";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            this.clmName.Width = 150;
            // 
            // clmCity
            // 
            this.clmCity.HeaderText = "Ciudad";
            this.clmCity.Name = "clmCity";
            this.clmCity.ReadOnly = true;
            this.clmCity.Width = 150;
            // 
            // clmAddress
            // 
            this.clmAddress.HeaderText = "Dirección";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.Width = 400;
            // 
            // clmTelephone
            // 
            this.clmTelephone.HeaderText = "Teléfono";
            this.clmTelephone.Name = "clmTelephone";
            this.clmTelephone.ReadOnly = true;
            // 
            // clmEmail
            // 
            this.clmEmail.HeaderText = "Email";
            this.clmEmail.Name = "clmEmail";
            this.clmEmail.ReadOnly = true;
            this.clmEmail.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteAddress);
            this.groupBox2.Controls.Add(this.btnEditAddress);
            this.groupBox2.Controls.Add(this.btnAddAddress);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(725, 41);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAddress.BackgroundImage = global::BPS.Lite.Properties.Resources.cross;
            this.btnDeleteAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteAddress.Location = new System.Drawing.Point(696, 12);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteAddress.TabIndex = 3;
            this.ttpProviderManager.SetToolTip(this.btnDeleteAddress, "Eliminar Dirección Proveedor");
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // btnEditAddress
            // 
            this.btnEditAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAddress.BackgroundImage = global::BPS.Lite.Properties.Resources.pencil;
            this.btnEditAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditAddress.Location = new System.Drawing.Point(671, 12);
            this.btnEditAddress.Name = "btnEditAddress";
            this.btnEditAddress.Size = new System.Drawing.Size(25, 25);
            this.btnEditAddress.TabIndex = 2;
            this.ttpProviderManager.SetToolTip(this.btnEditAddress, "Editar Dirección Proveedor");
            this.btnEditAddress.UseVisualStyleBackColor = true;
            this.btnEditAddress.Click += new System.EventHandler(this.btnEditAddress_Click);
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAddress.BackgroundImage = global::BPS.Lite.Properties.Resources.add1;
            this.btnAddAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddAddress.Location = new System.Drawing.Point(646, 12);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(25, 25);
            this.btnAddAddress.TabIndex = 1;
            this.ttpProviderManager.SetToolTip(this.btnAddAddress, "Agregar Dirección Proveedor");
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // grpobCustomerInfo
            // 
            this.grpobCustomerInfo.Controls.Add(this.btnClose);
            this.grpobCustomerInfo.Controls.Add(this.cmbProviderCountry);
            this.grpobCustomerInfo.Controls.Add(this.lblProviderCountry);
            this.grpobCustomerInfo.Controls.Add(this.brnSave);
            this.grpobCustomerInfo.Controls.Add(this.brnCancel);
            this.grpobCustomerInfo.Controls.Add(this.txtId);
            this.grpobCustomerInfo.Controls.Add(this.txtContactName);
            this.grpobCustomerInfo.Controls.Add(this.txtCompanyName);
            this.grpobCustomerInfo.Controls.Add(this.cmbIdType);
            this.grpobCustomerInfo.Controls.Add(this.cmbStatus);
            this.grpobCustomerInfo.Controls.Add(this.lblStatus);
            this.grpobCustomerInfo.Controls.Add(this.lblIdType);
            this.grpobCustomerInfo.Controls.Add(this.lblId);
            this.grpobCustomerInfo.Controls.Add(this.lblContactName);
            this.grpobCustomerInfo.Controls.Add(this.lblCompany);
            this.grpobCustomerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpobCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.grpobCustomerInfo.Name = "grpobCustomerInfo";
            this.grpobCustomerInfo.Size = new System.Drawing.Size(739, 151);
            this.grpobCustomerInfo.TabIndex = 10;
            this.grpobCustomerInfo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Image = global::BPS.Lite.Properties.Resources.door_in;
            this.btnClose.Location = new System.Drawing.Point(709, 122);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 9;
            this.ttpProviderManager.SetToolTip(this.btnClose, "Salir Proveedor");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbProviderCountry
            // 
            this.cmbProviderCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProviderCountry.FormattingEnabled = true;
            this.cmbProviderCountry.Location = new System.Drawing.Point(359, 95);
            this.cmbProviderCountry.Name = "cmbProviderCountry";
            this.cmbProviderCountry.Size = new System.Drawing.Size(371, 23);
            this.cmbProviderCountry.TabIndex = 6;
            this.cmbProviderCountry.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProviderCountry_KeyDown);
            // 
            // lblProviderCountry
            // 
            this.lblProviderCountry.AutoSize = true;
            this.lblProviderCountry.Location = new System.Drawing.Point(322, 98);
            this.lblProviderCountry.Name = "lblProviderCountry";
            this.lblProviderCountry.Size = new System.Drawing.Size(31, 15);
            this.lblProviderCountry.TabIndex = 28;
            this.lblProviderCountry.Text = "País";
            // 
            // brnSave
            // 
            this.brnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnSave.BackgroundImage")));
            this.brnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnSave.Location = new System.Drawing.Point(659, 122);
            this.brnSave.Name = "brnSave";
            this.brnSave.Size = new System.Drawing.Size(25, 25);
            this.brnSave.TabIndex = 7;
            this.ttpProviderManager.SetToolTip(this.brnSave, "Guardar Proveedor");
            this.brnSave.UseVisualStyleBackColor = true;
            this.brnSave.Click += new System.EventHandler(this.brnSave_Click);
            // 
            // brnCancel
            // 
            this.brnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.brnCancel.BackgroundImage = global::BPS.Lite.Properties.Resources.cancel;
            this.brnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnCancel.Location = new System.Drawing.Point(684, 122);
            this.brnCancel.Name = "brnCancel";
            this.brnCancel.Size = new System.Drawing.Size(25, 25);
            this.brnCancel.TabIndex = 8;
            this.ttpProviderManager.SetToolTip(this.brnCancel, "Cancelar Porveedor");
            this.brnCancel.UseVisualStyleBackColor = true;
            this.brnCancel.Click += new System.EventHandler(this.brnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(125, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(269, 21);
            this.txtId.TabIndex = 3;
            // 
            // txtContactName
            // 
            this.txtContactName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactName.Location = new System.Drawing.Point(125, 41);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(603, 21);
            this.txtContactName.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompanyName.Location = new System.Drawing.Point(125, 14);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(603, 21);
            this.txtCompanyName.TabIndex = 1;
            // 
            // cmbIdType
            // 
            this.cmbIdType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIdType.FormattingEnabled = true;
            this.cmbIdType.Location = new System.Drawing.Point(442, 68);
            this.cmbIdType.Name = "cmbIdType";
            this.cmbIdType.Size = new System.Drawing.Size(288, 23);
            this.cmbIdType.TabIndex = 4;
            this.cmbIdType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbIdType_KeyDown);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(125, 95);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(186, 23);
            this.cmbStatus.TabIndex = 5;
            this.cmbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStatus_KeyDown);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 98);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status";
            // 
            // lblIdType
            // 
            this.lblIdType.AutoSize = true;
            this.lblIdType.Location = new System.Drawing.Point(405, 71);
            this.lblIdType.Name = "lblIdType";
            this.lblIdType.Size = new System.Drawing.Size(31, 15);
            this.lblIdType.TabIndex = 3;
            this.lblIdType.Text = "Tipo";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(6, 71);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(79, 15);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Identificación";
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(6, 44);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(109, 15);
            this.lblContactName.TabIndex = 1;
            this.lblContactName.Text = "Nombre (contacto)";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(6, 17);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(118, 15);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Nombre (compañia)";
            // 
            // frmProviderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(739, 474);
            this.Controls.Add(this.tctrlProviderAddress);
            this.Controls.Add(this.grpobCustomerInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProviderForm";
            this.Text = "Administración de Proveedores";
            this.Load += new System.EventHandler(this.frmProviderForm_Load);
            this.tctrlProviderAddress.ResumeLayout(false);
            this.tbpAddressForm.ResumeLayout(false);
            this.grpbAddressForm.ResumeLayout(false);
            this.grpbAddressForm.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tpbAddressList.ResumeLayout(false);
            this.grp_ProviderAddresInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProviderAddress)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpobCustomerInfo.ResumeLayout(false);
            this.grpobCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tctrlProviderAddress;
        private System.Windows.Forms.TabPage tpbAddressList;
        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnEditAddress;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.DataGridView dgvProviderAddress;
        private System.Windows.Forms.TabPage tbpAddressForm;
        private System.Windows.Forms.Button brnSave;
        private System.Windows.Forms.Button brnCancel;
        private System.Windows.Forms.GroupBox grpobCustomerInfo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.ComboBox cmbIdType;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIdType;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbProviderCountry;
        private System.Windows.Forms.Label lblProviderCountry;
        private System.Windows.Forms.GroupBox grpbAddressForm;
        private System.Windows.Forms.Button btnSaveAddress;
        private System.Windows.Forms.Label lblAddressName;
        private System.Windows.Forms.Button btnCancelAddress;
        private System.Windows.Forms.Label lblPhones;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddressContact;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtAddressName;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtAddressContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEmail;
        private System.Windows.Forms.ToolTip ttpProviderManager;
        private System.Windows.Forms.GroupBox grp_ProviderAddresInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}