namespace BPS
{
    partial class frmRegisterCoilPalletsImported
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterCoilPalletsImported));
            this.opfImport = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpbImportedList = new System.Windows.Forms.GroupBox();
            this.pnlProcess = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.dgvImportedPallets = new System.Windows.Forms.DataGridView();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeightCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLenght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMainCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtrusionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestinationOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ttpRegisterCoilPalletsImported = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewImport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpbImportedList.SuspendLayout();
            this.pnlProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
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
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1242, 581);
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
            this.tabPage1.Size = new System.Drawing.Size(1234, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Importar archivo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpbImportedList
            // 
            this.grpbImportedList.Controls.Add(this.pnlProcess);
            this.grpbImportedList.Controls.Add(this.dgvImportedPallets);
            this.grpbImportedList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbImportedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbImportedList.Location = new System.Drawing.Point(3, 88);
            this.grpbImportedList.Name = "grpbImportedList";
            this.grpbImportedList.Size = new System.Drawing.Size(1228, 420);
            this.grpbImportedList.TabIndex = 3;
            this.grpbImportedList.TabStop = false;
            // 
            // pnlProcess
            // 
            this.pnlProcess.BackColor = System.Drawing.Color.Lavender;
            this.pnlProcess.Controls.Add(this.lblLoading);
            this.pnlProcess.Controls.Add(this.pbxLoading);
            this.pnlProcess.Location = new System.Drawing.Point(3, 6);
            this.pnlProcess.Name = "pnlProcess";
            this.pnlProcess.Size = new System.Drawing.Size(1228, 414);
            this.pnlProcess.TabIndex = 1;
            this.pnlProcess.Visible = false;
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(508, 198);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(213, 34);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Se esta cargando la información de los pallets\r\nEsto puede tomar algunos micro-se" +
    "gundos";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLoading
            // 
            this.pbxLoading.ErrorImage = global::BPS.Lite.Properties.Resources.loading6;
            this.pbxLoading.Image = global::BPS.Lite.Properties.Resources.loading6;
            this.pbxLoading.InitialImage = global::BPS.Lite.Properties.Resources.loading6;
            this.pbxLoading.Location = new System.Drawing.Point(562, 179);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(105, 16);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLoading.TabIndex = 2;
            this.pbxLoading.TabStop = false;
            // 
            // dgvImportedPallets
            // 
            this.dgvImportedPallets.AllowUserToAddRows = false;
            this.dgvImportedPallets.AllowUserToDeleteRows = false;
            this.dgvImportedPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportedPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmType,
            this.clmPalletCode,
            this.clmProductCode,
            this.clmWidth,
            this.clmDiameterCore,
            this.clmPalletNetWeight,
            this.clmPalletGrossWeight,
            this.clmCoilCode,
            this.clmNetWeightCoil,
            this.clmLenght,
            this.clmDiameter,
            this.clmMainCoilCode,
            this.clmLotNumber,
            this.clmExtrusionDate,
            this.clmDestinationOrder});
            this.dgvImportedPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportedPallets.Location = new System.Drawing.Point(3, 14);
            this.dgvImportedPallets.Name = "dgvImportedPallets";
            this.dgvImportedPallets.ReadOnly = true;
            this.dgvImportedPallets.RowHeadersWidth = 10;
            this.dgvImportedPallets.Size = new System.Drawing.Size(1222, 403);
            this.dgvImportedPallets.TabIndex = 0;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            this.clmType.Visible = false;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Cod. Pallet";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            this.clmPalletCode.Width = 120;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Cod. Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 70;
            // 
            // clmDiameterCore
            // 
            this.clmDiameterCore.HeaderText = "Diam / Core";
            this.clmDiameterCore.Name = "clmDiameterCore";
            this.clmDiameterCore.ReadOnly = true;
            this.clmDiameterCore.Width = 70;
            // 
            // clmPalletNetWeight
            // 
            this.clmPalletNetWeight.HeaderText = "P. Neto Pallet";
            this.clmPalletNetWeight.Name = "clmPalletNetWeight";
            this.clmPalletNetWeight.ReadOnly = true;
            this.clmPalletNetWeight.Width = 70;
            // 
            // clmPalletGrossWeight
            // 
            this.clmPalletGrossWeight.HeaderText = "P. Bruto Pallet";
            this.clmPalletGrossWeight.Name = "clmPalletGrossWeight";
            this.clmPalletGrossWeight.ReadOnly = true;
            this.clmPalletGrossWeight.Width = 70;
            // 
            // clmCoilCode
            // 
            this.clmCoilCode.HeaderText = "Cód. Bobina";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 120;
            // 
            // clmNetWeightCoil
            // 
            this.clmNetWeightCoil.HeaderText = "P. Neto Bobina";
            this.clmNetWeightCoil.Name = "clmNetWeightCoil";
            this.clmNetWeightCoil.ReadOnly = true;
            this.clmNetWeightCoil.Width = 65;
            // 
            // clmLenght
            // 
            this.clmLenght.HeaderText = "Metraje";
            this.clmLenght.Name = "clmLenght";
            this.clmLenght.ReadOnly = true;
            this.clmLenght.Width = 65;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 65;
            // 
            // clmMainCoilCode
            // 
            this.clmMainCoilCode.HeaderText = "Rollo Madre";
            this.clmMainCoilCode.Name = "clmMainCoilCode";
            this.clmMainCoilCode.ReadOnly = true;
            // 
            // clmLotNumber
            // 
            this.clmLotNumber.HeaderText = "Lote";
            this.clmLotNumber.Name = "clmLotNumber";
            this.clmLotNumber.ReadOnly = true;
            // 
            // clmExtrusionDate
            // 
            this.clmExtrusionDate.HeaderText = "F. Extrusion";
            this.clmExtrusionDate.Name = "clmExtrusionDate";
            this.clmExtrusionDate.ReadOnly = true;
            // 
            // clmDestinationOrder
            // 
            this.clmDestinationOrder.HeaderText = "Orden destino";
            this.clmDestinationOrder.Name = "clmDestinationOrder";
            this.clmDestinationOrder.ReadOnly = true;
            this.clmDestinationOrder.Width = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProcess);
            this.groupBox2.Controls.Add(this.btnValidate);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1228, 42);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.BackgroundImage = global::BPS.Lite.Properties.Resources.gear_16;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProcess.Location = new System.Drawing.Point(31, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(25, 25);
            this.btnProcess.TabIndex = 5;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnProcess, "Ejecutar");
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackgroundImage = global::BPS.Lite.Properties.Resources.quality;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(6, 12);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(25, 25);
            this.btnValidate.TabIndex = 4;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnValidate, "Abrir Archivo");
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewImport);
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
            this.groupBox1.Size = new System.Drawing.Size(1228, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Importar archivo";
            // 
            // btnExecute
            // 
            this.btnExecute.BackgroundImage = global::BPS.Lite.Properties.Resources.page_lightning;
            this.btnExecute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExecute.Location = new System.Drawing.Point(914, 15);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(25, 25);
            this.btnExecute.TabIndex = 3;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnExecute, "Ejecutar");
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::BPS.Lite.Properties.Resources.folder;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenFile.Location = new System.Drawing.Point(889, 15);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(25, 25);
            this.btnOpenFile.TabIndex = 2;
            this.ttpRegisterCoilPalletsImported.SetToolTip(this.btnOpenFile, "Abrir Archivo");
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(342, 17);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(541, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // lblImportedCoils
            // 
            this.lblImportedCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImportedCoils.Location = new System.Drawing.Point(736, 50);
            this.lblImportedCoils.Name = "lblImportedCoils";
            this.lblImportedCoils.Size = new System.Drawing.Size(59, 21);
            this.lblImportedCoils.TabIndex = 7;
            // 
            // lblImportedCoilsLabel
            // 
            this.lblImportedCoilsLabel.AutoSize = true;
            this.lblImportedCoilsLabel.Location = new System.Drawing.Point(613, 51);
            this.lblImportedCoilsLabel.Name = "lblImportedCoilsLabel";
            this.lblImportedCoilsLabel.Size = new System.Drawing.Size(117, 15);
            this.lblImportedCoilsLabel.TabIndex = 6;
            this.lblImportedCoilsLabel.Text = "Bobinas Importados";
            // 
            // lblImportedPallets
            // 
            this.lblImportedPallets.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblImportedPallets.Location = new System.Drawing.Point(548, 50);
            this.lblImportedPallets.Name = "lblImportedPallets";
            this.lblImportedPallets.Size = new System.Drawing.Size(59, 21);
            this.lblImportedPallets.TabIndex = 5;
            // 
            // lblImportedPalletsLabel
            // 
            this.lblImportedPalletsLabel.AutoSize = true;
            this.lblImportedPalletsLabel.Location = new System.Drawing.Point(433, 51);
            this.lblImportedPalletsLabel.Name = "lblImportedPalletsLabel";
            this.lblImportedPalletsLabel.Size = new System.Drawing.Size(109, 15);
            this.lblImportedPalletsLabel.TabIndex = 4;
            this.lblImportedPalletsLabel.Text = "Pallets Importados";
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(290, 20);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(46, 15);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Archivo";
            // 
            // btnNewImport
            // 
            this.btnNewImport.Location = new System.Drawing.Point(945, 16);
            this.btnNewImport.Name = "btnNewImport";
            this.btnNewImport.Size = new System.Drawing.Size(160, 23);
            this.btnNewImport.TabIndex = 8;
            this.btnNewImport.Text = "Importar desde Excel";
            this.btnNewImport.UseVisualStyleBackColor = true;
            this.btnNewImport.Click += new System.EventHandler(this.btnNewImport_Click);
            // 
            // frmRegisterCoilPalletsImported
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1242, 581);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegisterCoilPalletsImported";
            this.Text = "Registrro de pallets importados";
            this.Load += new System.EventHandler(this.frmRegisterCoilPalletsImported_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpbImportedList.ResumeLayout(false);
            this.pnlProcess.ResumeLayout(false);
            this.pnlProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
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
        private System.Windows.Forms.ToolTip ttpRegisterCoilPalletsImported;
        private System.Windows.Forms.GroupBox grpbImportedList;
        private System.Windows.Forms.DataGridView dgvImportedPallets;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeightCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLenght;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMainCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtrusionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestinationOrder;
        private System.Windows.Forms.Panel pnlProcess;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Button btnNewImport;
    }
}