namespace BPS
{
    partial class frmCustomerToSiigo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerToSiigo));
            this.opfImport = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbImportedList = new System.Windows.Forms.GroupBox();
            this.dgvImportedPallets = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmphone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmphone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblImportedCoils = new System.Windows.Forms.Label();
            this.lblImportedCoilsLabel = new System.Windows.Forms.Label();
            this.lblImportedPallets = new System.Windows.Forms.Label();
            this.lblImportedPalletsLabel = new System.Windows.Forms.Label();
            this.lblFile = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ttpRegisterCoilPalletsImported = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbImportedList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedPallets)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opfImport
            // 
            this.opfImport.FileName = "openFileDialog1";
            this.opfImport.Filter = "Archivos CSV|*.csv|Archivos de texto|*.txt";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1250, 581);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpbImportedList);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1242, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Importar archivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpbImportedList
            // 
            this.grpbImportedList.Controls.Add(this.dgvImportedPallets);
            this.grpbImportedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbImportedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbImportedList.Location = new System.Drawing.Point(3, 88);
            this.grpbImportedList.Name = "grpbImportedList";
            this.grpbImportedList.Size = new System.Drawing.Size(1236, 420);
            this.grpbImportedList.TabIndex = 3;
            this.grpbImportedList.TabStop = false;
            // 
            // dgvImportedPallets
            // 
            this.dgvImportedPallets.AllowUserToAddRows = false;
            this.dgvImportedPallets.AllowUserToDeleteRows = false;
            this.dgvImportedPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportedPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmid,
            this.clmname,
            this.clmcontact,
            this.clmaddress,
            this.clmcountry,
            this.clmcity,
            this.clmphone1,
            this.clmphone2,
            this.clmfax,
            this.clmemail});
            this.dgvImportedPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportedPallets.Location = new System.Drawing.Point(3, 14);
            this.dgvImportedPallets.Name = "dgvImportedPallets";
            this.dgvImportedPallets.ReadOnly = true;
            this.dgvImportedPallets.RowHeadersWidth = 10;
            this.dgvImportedPallets.Size = new System.Drawing.Size(1230, 403);
            this.dgvImportedPallets.TabIndex = 0;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Visible = false;
            // 
            // clmid
            // 
            this.clmid.HeaderText = "Id";
            this.clmid.Name = "clmid";
            this.clmid.ReadOnly = true;
            this.clmid.Width = 120;
            // 
            // clmname
            // 
            this.clmname.HeaderText = "Nombre";
            this.clmname.Name = "clmname";
            this.clmname.ReadOnly = true;
            this.clmname.Width = 150;
            // 
            // clmcontact
            // 
            this.clmcontact.HeaderText = "Contacto";
            this.clmcontact.Name = "clmcontact";
            this.clmcontact.ReadOnly = true;
            // 
            // clmaddress
            // 
            this.clmaddress.HeaderText = "Dirección";
            this.clmaddress.Name = "clmaddress";
            this.clmaddress.ReadOnly = true;
            this.clmaddress.Width = 150;
            // 
            // clmcountry
            // 
            this.clmcountry.HeaderText = "Pais";
            this.clmcountry.Name = "clmcountry";
            this.clmcountry.ReadOnly = true;
            this.clmcountry.Width = 70;
            // 
            // clmcity
            // 
            this.clmcity.HeaderText = "Ciudad";
            this.clmcity.Name = "clmcity";
            this.clmcity.ReadOnly = true;
            this.clmcity.Width = 70;
            // 
            // clmphone1
            // 
            this.clmphone1.HeaderText = "Teléfono 1";
            this.clmphone1.Name = "clmphone1";
            this.clmphone1.ReadOnly = true;
            this.clmphone1.Width = 70;
            // 
            // clmphone2
            // 
            this.clmphone2.HeaderText = "Telefono 2";
            this.clmphone2.Name = "clmphone2";
            this.clmphone2.ReadOnly = true;
            this.clmphone2.Width = 70;
            // 
            // clmfax
            // 
            this.clmfax.HeaderText = "Fax";
            this.clmfax.Name = "clmfax";
            this.clmfax.ReadOnly = true;
            this.clmfax.Width = 70;
            // 
            // clmemail
            // 
            this.clmemail.HeaderText = "Email";
            this.clmemail.Name = "clmemail";
            this.clmemail.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.btnValidate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1236, 42);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::BPS.Properties.Resources.gear_16;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(1197, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(25, 25);
            this.btnProcess.TabIndex = 5;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnProcess, "Ejecutar");
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackgroundImage = global::BPS.Properties.Resources.quality;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(1172, 12);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(25, 25);
            this.btnValidate.TabIndex = 4;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnValidate, "Abrir Archivo");
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExecute);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.lblImportedCoils);
            this.groupBox1.Controls.Add(this.lblImportedCoilsLabel);
            this.groupBox1.Controls.Add(this.lblImportedPallets);
            this.groupBox1.Controls.Add(this.lblImportedPalletsLabel);
            this.groupBox1.Controls.Add(this.lblFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar archivo";
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::BPS.Properties.Resources.page_lightning;
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExecute.Location = new System.Drawing.Point(818, 15);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(25, 25);
            this.btnExecute.TabIndex = 3;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnExecute, "Ejecutar");
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::BPS.Properties.Resources.folder;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.Location = new System.Drawing.Point(793, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(25, 25);
            this.btnOpenFile.TabIndex = 2;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnOpenFile, "Abrir Archivo");
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(246, 17);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(541, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // lblImportedCoils
            // 
            this.lblImportedCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImportedCoils.Location = new System.Drawing.Point(640, 50);
            this.lblImportedCoils.Name = "lblImportedCoils";
            this.lblImportedCoils.Size = new System.Drawing.Size(59, 21);
            this.lblImportedCoils.TabIndex = 7;
            // 
            // lblImportedCoilsLabel
            // 
            this.lblImportedCoilsLabel.AutoSize = true;
            this.lblImportedCoilsLabel.Location = new System.Drawing.Point(517, 51);
            this.lblImportedCoilsLabel.Name = "lblImportedCoilsLabel";
            this.lblImportedCoilsLabel.Size = new System.Drawing.Size(117, 15);
            this.lblImportedCoilsLabel.TabIndex = 6;
            this.lblImportedCoilsLabel.Text = "Bobinas Importados";
            // 
            // lblImportedPallets
            // 
            this.lblImportedPallets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImportedPallets.Location = new System.Drawing.Point(452, 50);
            this.lblImportedPallets.Name = "lblImportedPallets";
            this.lblImportedPallets.Size = new System.Drawing.Size(59, 21);
            this.lblImportedPallets.TabIndex = 5;
            // 
            // lblImportedPalletsLabel
            // 
            this.lblImportedPalletsLabel.AutoSize = true;
            this.lblImportedPalletsLabel.Location = new System.Drawing.Point(337, 51);
            this.lblImportedPalletsLabel.Name = "lblImportedPalletsLabel";
            this.lblImportedPalletsLabel.Size = new System.Drawing.Size(109, 15);
            this.lblImportedPalletsLabel.TabIndex = 4;
            this.lblImportedPalletsLabel.Text = "Pallets Importados";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(194, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(46, 15);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Archivo";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1006, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmCustomerToSiigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1250, 581);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerToSiigo";
            this.Text = "Registrro de pallets importados";
            this.Load += new System.EventHandler(this.frmRegisterCoilPalletsImported_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpbImportedList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportedPallets)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opfImport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label lblImportedCoils;
        private System.Windows.Forms.Label lblImportedCoilsLabel;
        private System.Windows.Forms.Label lblImportedPallets;
        private System.Windows.Forms.Label lblImportedPalletsLabel;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip ttpRegisterCoilPalletsImported;
        private System.Windows.Forms.GroupBox grpbImportedList;
        private System.Windows.Forms.DataGridView dgvImportedPallets;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmphone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmphone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmemail;
    }
}