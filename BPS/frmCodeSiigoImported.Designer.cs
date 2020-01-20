namespace BPS
{
    partial class frmCodeSiigoImported
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodeSiigoImported));
            this.opfImport = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbImportedList = new System.Windows.Forms.GroupBox();
            this.dgvImportedPallets = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ttpRegisterCoilPalletsImported = new System.Windows.Forms.ToolTip(this.components);
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReference = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.Size = new System.Drawing.Size(671, 581);
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
            this.tabPage1.Size = new System.Drawing.Size(663, 553);
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
            this.grpbImportedList.Size = new System.Drawing.Size(657, 420);
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
            this.clmCode,
            this.clmBopp,
            this.clmOpp,
            this.clmDescription,
            this.clmReference});
            this.dgvImportedPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportedPallets.Location = new System.Drawing.Point(3, 14);
            this.dgvImportedPallets.Name = "dgvImportedPallets";
            this.dgvImportedPallets.ReadOnly = true;
            this.dgvImportedPallets.RowHeadersWidth = 10;
            this.dgvImportedPallets.Size = new System.Drawing.Size(651, 403);
            this.dgvImportedPallets.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.btnValidate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 42);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::BPS.Properties.Resources.gear_16;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(627, 12);
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
            this.btnValidate.Location = new System.Drawing.Point(602, 12);
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
            this.groupBox1.Controls.Add(this.lblFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar archivo";
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::BPS.Properties.Resources.page_lightning;
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExecute.Location = new System.Drawing.Point(627, 18);
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
            this.btnOpenFile.Location = new System.Drawing.Point(602, 18);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(25, 25);
            this.btnOpenFile.TabIndex = 2;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnOpenFile, "Abrir Archivo");
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(55, 20);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(541, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(3, 23);
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
            this.tabPage2.Size = new System.Drawing.Size(1234, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Code";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 150;
            // 
            // clmBopp
            // 
            this.clmBopp.HeaderText = "Bopp";
            this.clmBopp.Name = "clmBopp";
            this.clmBopp.ReadOnly = true;
            this.clmBopp.Width = 70;
            // 
            // clmOpp
            // 
            this.clmOpp.HeaderText = "Opp";
            this.clmOpp.Name = "clmOpp";
            this.clmOpp.ReadOnly = true;
            this.clmOpp.Width = 70;
            // 
            // clmDescription
            // 
            this.clmDescription.HeaderText = "Descripcion";
            this.clmDescription.Name = "clmDescription";
            this.clmDescription.ReadOnly = true;
            this.clmDescription.Width = 150;
            // 
            // clmReference
            // 
            this.clmReference.HeaderText = "Referencia";
            this.clmReference.Name = "clmReference";
            this.clmReference.ReadOnly = true;
            this.clmReference.Width = 150;
            // 
            // frmCodeSiigoImported
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(671, 581);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCodeSiigoImported";
            this.Text = "Registrro de pallets importados";
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
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip ttpRegisterCoilPalletsImported;
        private System.Windows.Forms.GroupBox grpbImportedList;
        private System.Windows.Forms.DataGridView dgvImportedPallets;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReference;
    }
}