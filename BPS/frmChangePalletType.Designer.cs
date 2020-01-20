namespace BPS
{
    partial class frmChangePalletType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePalletType));
            this.cmbPalletType = new System.Windows.Forms.ComboBox();
            this.lblPalletType = new System.Windows.Forms.Label();
            this.btnChangePalletType = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.grpbPalletInfo = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCuttingOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.ttpStockPallet = new System.Windows.Forms.ToolTip(this.components);
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.lblCoilCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clmCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoilAction = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbFilters.SuspendLayout();
            this.grpbPalletInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPalletType
            // 
            this.cmbPalletType.FormattingEnabled = true;
            this.cmbPalletType.Location = new System.Drawing.Point(92, 49);
            this.cmbPalletType.Name = "cmbPalletType";
            this.cmbPalletType.Size = new System.Drawing.Size(519, 23);
            this.cmbPalletType.TabIndex = 6;
            this.cmbPalletType.SelectedIndexChanged += new System.EventHandler(this.cmbPalletType_SelectedIndexChanged);
            this.cmbPalletType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPalletType_KeyDown);
            // 
            // lblPalletType
            // 
            this.lblPalletType.AutoSize = true;
            this.lblPalletType.Location = new System.Drawing.Point(5, 52);
            this.lblPalletType.Name = "lblPalletType";
            this.lblPalletType.Size = new System.Drawing.Size(81, 15);
            this.lblPalletType.TabIndex = 4;
            this.lblPalletType.Text = "Tipo de pallet";
            // 
            // btnChangePalletType
            // 
            this.btnChangePalletType.BackgroundImage = global::BPS.Properties.Resources.arrow_circle_double;
            this.btnChangePalletType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChangePalletType.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChangePalletType.Location = new System.Drawing.Point(586, 17);
            this.btnChangePalletType.Name = "btnChangePalletType";
            this.btnChangePalletType.Size = new System.Drawing.Size(25, 23);
            this.btnChangePalletType.TabIndex = 0;
            this.ttpStockPallet.SetToolTip(this.btnChangePalletType, "Agregar Pallet");
            this.btnChangePalletType.UseVisualStyleBackColor = true;
            this.btnChangePalletType.Click += new System.EventHandler(this.btnChangePalletType_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(561, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 1;
            this.ttpStockPallet.SetToolTip(this.btnClose, "Cancelar Pallet");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.btnClose);
            this.grpbFilters.Controls.Add(this.btnChangePalletType);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilters.Location = new System.Drawing.Point(0, 311);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(614, 43);
            this.grpbFilters.TabIndex = 1;
            this.grpbFilters.TabStop = false;
            // 
            // grpbPalletInfo
            // 
            this.grpbPalletInfo.Controls.Add(this.lblProductName);
            this.grpbPalletInfo.Controls.Add(this.lblNumber);
            this.grpbPalletInfo.Controls.Add(this.lblCuttingOrderNumberLabel);
            this.grpbPalletInfo.Controls.Add(this.lblPalletType);
            this.grpbPalletInfo.Controls.Add(this.lblProduct);
            this.grpbPalletInfo.Controls.Add(this.cmbPalletType);
            this.grpbPalletInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbPalletInfo.Name = "grpbPalletInfo";
            this.grpbPalletInfo.Size = new System.Drawing.Size(614, 77);
            this.grpbPalletInfo.TabIndex = 0;
            this.grpbPalletInfo.TabStop = false;
            // 
            // lblProductName
            // 
            this.lblProductName.BackColor = System.Drawing.SystemColors.Window;
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductName.Location = new System.Drawing.Point(302, 17);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(309, 21);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Tag = "clearOnReload";
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(92, 17);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(142, 21);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Tag = "clearOnReload";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCuttingOrderNumberLabel
            // 
            this.lblCuttingOrderNumberLabel.AutoSize = true;
            this.lblCuttingOrderNumberLabel.Location = new System.Drawing.Point(11, 20);
            this.lblCuttingOrderNumberLabel.Name = "lblCuttingOrderNumberLabel";
            this.lblCuttingOrderNumberLabel.Size = new System.Drawing.Size(75, 15);
            this.lblCuttingOrderNumberLabel.TabIndex = 0;
            this.lblCuttingOrderNumberLabel.Text = "Orden Venta";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(240, 20);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(56, 15);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Producto";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCoilCodsec,
            this.clmCoilCode,
            this.clmCoilLength,
            this.clmCoilWidth,
            this.clmCoilWeigth,
            this.clmCoilAction});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.Size = new System.Drawing.Size(608, 170);
            this.dgvCoils.TabIndex = 5;
            this.dgvCoils.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoils_CellClick);
            // 
            // lblCoilCount
            // 
            this.lblCoilCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCoilCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoilCount.Location = new System.Drawing.Point(3, 17);
            this.lblCoilCount.Name = "lblCoilCount";
            this.lblCoilCount.Size = new System.Drawing.Size(608, 18);
            this.lblCoilCount.TabIndex = 6;
            this.lblCoilCount.Text = "Bobinas : -- / --";
            this.lblCoilCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCoils);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 190);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCoilCount);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 44);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // clmCoilCodsec
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCodsec.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCoilCodsec.HeaderText = "codsec";
            this.clmCoilCodsec.Name = "clmCoilCodsec";
            this.clmCoilCodsec.ReadOnly = true;
            this.clmCoilCodsec.Visible = false;
            // 
            // clmCoilCode
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCoilCode.HeaderText = "Código";
            this.clmCoilCode.Name = "clmCoilCode";
            this.clmCoilCode.ReadOnly = true;
            this.clmCoilCode.Width = 200;
            // 
            // clmCoilLength
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmCoilLength.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCoilLength.HeaderText = "Metraje";
            this.clmCoilLength.Name = "clmCoilLength";
            this.clmCoilLength.ReadOnly = true;
            this.clmCoilLength.Width = 90;
            // 
            // clmCoilWidth
            // 
            this.clmCoilWidth.HeaderText = "Ancho";
            this.clmCoilWidth.Name = "clmCoilWidth";
            this.clmCoilWidth.ReadOnly = true;
            this.clmCoilWidth.Width = 90;
            // 
            // clmCoilWeigth
            // 
            this.clmCoilWeigth.HeaderText = "Peso";
            this.clmCoilWeigth.Name = "clmCoilWeigth";
            this.clmCoilWeigth.ReadOnly = true;
            this.clmCoilWeigth.Width = 90;
            // 
            // clmCoilAction
            // 
            this.clmCoilAction.HeaderText = "";
            this.clmCoilAction.Name = "clmCoilAction";
            this.clmCoilAction.ReadOnly = true;
            this.clmCoilAction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmCoilAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmCoilAction.Width = 30;
            // 
            // frmChangePalletType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(614, 354);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbPalletInfo);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChangePalletType";
            this.ShowInTaskbar = false;
            this.Text = "Agregar tipo de pallet";
            this.Load += new System.EventHandler(this.frmAddNewStockPallet_Load);
            this.grpbFilters.ResumeLayout(false);
            this.grpbPalletInfo.ResumeLayout(false);
            this.grpbPalletInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPalletType;
        private System.Windows.Forms.Label lblPalletType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbPalletInfo;
        private System.Windows.Forms.Button btnChangePalletType;
        private System.Windows.Forms.Label lblCuttingOrderNumberLabel;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.ToolTip ttpStockPallet;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.Label lblCoilCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoilWeigth;
        private System.Windows.Forms.DataGridViewImageColumn clmCoilAction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}