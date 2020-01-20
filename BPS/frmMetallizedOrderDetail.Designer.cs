namespace BPS
{
    partial class frmMetallizedOrderDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetallizedOrderDetail));
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbTransferActionsPallet = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMachineLabel = new System.Windows.Forms.Label();
            this.grpbOrderInfo = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblquantityCoils = new System.Windows.Forms.Label();
            this.lblquantityCoilsMetalized = new System.Windows.Forms.Label();
            this.lblquantityCoilsLabel = new System.Windows.Forms.Label();
            this.lblProductTo = new System.Windows.Forms.Label();
            this.lblProductToLabel = new System.Windows.Forms.Label();
            this.lblProductFrom = new System.Windows.Forms.Label();
            this.lblProductFromLabel = new System.Windows.Forms.Label();
            this.lblOpticDensity = new System.Windows.Forms.Label();
            this.lblMachine = new System.Windows.Forms.Label();
            this.lblOpticDensityLabel = new System.Windows.Forms.Label();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.grpbSelectedCoils = new System.Windows.Forms.GroupBox();
            this.dgvToMetallize = new System.Windows.Forms.DataGridView();
            this.clmMetallizedCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizedCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizedProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizedWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizedWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizedLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizedCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpOrderMetalizedActive = new System.Windows.Forms.ToolTip(this.components);
            this.grpbTransferActionsPallet.SuspendLayout();
            this.grpbOrderInfo.SuspendLayout();
            this.grpbSelectedCoils.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToMetallize)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 393);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(690, 43);
            this.grpbEmpty.TabIndex = 8;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbTransferActionsPallet
            // 
            this.grpbTransferActionsPallet.Controls.Add(this.btnClose);
            this.grpbTransferActionsPallet.Controls.Add(this.btnExit);
            this.grpbTransferActionsPallet.Controls.Add(this.btnAdd);
            this.grpbTransferActionsPallet.Location = new System.Drawing.Point(692, 393);
            this.grpbTransferActionsPallet.Name = "grpbTransferActionsPallet";
            this.grpbTransferActionsPallet.Size = new System.Drawing.Size(82, 43);
            this.grpbTransferActionsPallet.TabIndex = 9;
            this.grpbTransferActionsPallet.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.lock1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(4, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.TabIndex = 1;
            this.ttpOrderMetalizedActive.SetToolTip(this.btnClose, "Cerrar Orden Metalizado");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 25);
            this.btnExit.TabIndex = 0;
            this.ttpOrderMetalizedActive.SetToolTip(this.btnExit, "Salir Orden Metalizado");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::BPS.Properties.Resources.add_coil;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(29, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 25);
            this.btnAdd.TabIndex = 0;
            this.ttpOrderMetalizedActive.SetToolTip(this.btnAdd, "Agregar Orden Metalizado");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Location = new System.Drawing.Point(70, 20);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(115, 21);
            this.lblNumber.TabIndex = 1;
            // 
            // lblMachineLabel
            // 
            this.lblMachineLabel.AutoSize = true;
            this.lblMachineLabel.Location = new System.Drawing.Point(6, 66);
            this.lblMachineLabel.Name = "lblMachineLabel";
            this.lblMachineLabel.Size = new System.Drawing.Size(79, 15);
            this.lblMachineLabel.TabIndex = 2;
            this.lblMachineLabel.Text = "Metalizadora";
            // 
            // grpbOrderInfo
            // 
            this.grpbOrderInfo.Controls.Add(this.label8);
            this.grpbOrderInfo.Controls.Add(this.lblquantityCoils);
            this.grpbOrderInfo.Controls.Add(this.lblquantityCoilsMetalized);
            this.grpbOrderInfo.Controls.Add(this.lblquantityCoilsLabel);
            this.grpbOrderInfo.Controls.Add(this.lblProductTo);
            this.grpbOrderInfo.Controls.Add(this.lblProductToLabel);
            this.grpbOrderInfo.Controls.Add(this.lblProductFrom);
            this.grpbOrderInfo.Controls.Add(this.lblProductFromLabel);
            this.grpbOrderInfo.Controls.Add(this.lblOpticDensity);
            this.grpbOrderInfo.Controls.Add(this.lblMachine);
            this.grpbOrderInfo.Controls.Add(this.lblNumber);
            this.grpbOrderInfo.Controls.Add(this.lblMachineLabel);
            this.grpbOrderInfo.Controls.Add(this.lblOpticDensityLabel);
            this.grpbOrderInfo.Controls.Add(this.lblNumberLabel);
            this.grpbOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbOrderInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbOrderInfo.Name = "grpbOrderInfo";
            this.grpbOrderInfo.Size = new System.Drawing.Size(779, 99);
            this.grpbOrderInfo.TabIndex = 5;
            this.grpbOrderInfo.TabStop = false;
            this.grpbOrderInfo.Text = "Orden de Metalizado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "De";
            // 
            // lblquantityCoils
            // 
            this.lblquantityCoils.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblquantityCoils.Location = new System.Drawing.Point(659, 61);
            this.lblquantityCoils.Name = "lblquantityCoils";
            this.lblquantityCoils.Size = new System.Drawing.Size(31, 21);
            this.lblquantityCoils.TabIndex = 11;
            // 
            // lblquantityCoilsMetalized
            // 
            this.lblquantityCoilsMetalized.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblquantityCoilsMetalized.Location = new System.Drawing.Point(585, 62);
            this.lblquantityCoilsMetalized.Name = "lblquantityCoilsMetalized";
            this.lblquantityCoilsMetalized.Size = new System.Drawing.Size(31, 21);
            this.lblquantityCoilsMetalized.TabIndex = 9;
            // 
            // lblquantityCoilsLabel
            // 
            this.lblquantityCoilsLabel.AutoSize = true;
            this.lblquantityCoilsLabel.Location = new System.Drawing.Point(473, 66);
            this.lblquantityCoilsLabel.Name = "lblquantityCoilsLabel";
            this.lblquantityCoilsLabel.Size = new System.Drawing.Size(104, 15);
            this.lblquantityCoilsLabel.TabIndex = 10;
            this.lblquantityCoilsLabel.Text = "Cantidad Bobinas";
            // 
            // lblProductTo
            // 
            this.lblProductTo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductTo.Location = new System.Drawing.Point(585, 19);
            this.lblProductTo.Name = "lblProductTo";
            this.lblProductTo.Size = new System.Drawing.Size(177, 21);
            this.lblProductTo.TabIndex = 7;
            // 
            // lblProductToLabel
            // 
            this.lblProductToLabel.AutoSize = true;
            this.lblProductToLabel.Location = new System.Drawing.Point(487, 21);
            this.lblProductToLabel.Name = "lblProductToLabel";
            this.lblProductToLabel.Size = new System.Drawing.Size(86, 15);
            this.lblProductToLabel.TabIndex = 8;
            this.lblProductToLabel.Text = "Producto Final";
            // 
            // lblProductFrom
            // 
            this.lblProductFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductFrom.Location = new System.Drawing.Point(298, 18);
            this.lblProductFrom.Name = "lblProductFrom";
            this.lblProductFrom.Size = new System.Drawing.Size(177, 21);
            this.lblProductFrom.TabIndex = 5;
            // 
            // lblProductFromLabel
            // 
            this.lblProductFromLabel.AutoSize = true;
            this.lblProductFromLabel.Location = new System.Drawing.Point(198, 21);
            this.lblProductFromLabel.Name = "lblProductFromLabel";
            this.lblProductFromLabel.Size = new System.Drawing.Size(91, 15);
            this.lblProductFromLabel.TabIndex = 6;
            this.lblProductFromLabel.Text = "Producto Inicial";
            // 
            // lblOpticDensity
            // 
            this.lblOpticDensity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpticDensity.Location = new System.Drawing.Point(351, 63);
            this.lblOpticDensity.Name = "lblOpticDensity";
            this.lblOpticDensity.Size = new System.Drawing.Size(98, 21);
            this.lblOpticDensity.TabIndex = 1;
            // 
            // lblMachine
            // 
            this.lblMachine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMachine.Location = new System.Drawing.Point(91, 63);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(141, 21);
            this.lblMachine.TabIndex = 1;
            // 
            // lblOpticDensityLabel
            // 
            this.lblOpticDensityLabel.AutoSize = true;
            this.lblOpticDensityLabel.Location = new System.Drawing.Point(247, 66);
            this.lblOpticDensityLabel.Name = "lblOpticDensityLabel";
            this.lblOpticDensityLabel.Size = new System.Drawing.Size(98, 15);
            this.lblOpticDensityLabel.TabIndex = 4;
            this.lblOpticDensityLabel.Text = "Densidad Optica";
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(6, 23);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(52, 15);
            this.lblNumberLabel.TabIndex = 0;
            this.lblNumberLabel.Text = "Número";
            // 
            // grpbSelectedCoils
            // 
            this.grpbSelectedCoils.Controls.Add(this.dgvToMetallize);
            this.grpbSelectedCoils.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbSelectedCoils.Location = new System.Drawing.Point(0, 99);
            this.grpbSelectedCoils.Name = "grpbSelectedCoils";
            this.grpbSelectedCoils.Size = new System.Drawing.Size(779, 299);
            this.grpbSelectedCoils.TabIndex = 7;
            this.grpbSelectedCoils.TabStop = false;
            this.grpbSelectedCoils.Text = "Bobinas metalizadas";
            // 
            // dgvToMetallize
            // 
            this.dgvToMetallize.AllowDrop = true;
            this.dgvToMetallize.AllowUserToAddRows = false;
            this.dgvToMetallize.AllowUserToDeleteRows = false;
            this.dgvToMetallize.AllowUserToOrderColumns = true;
            this.dgvToMetallize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToMetallize.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMetallizedCodsec,
            this.clmMetallizedCode,
            this.clmMetallizedProduct,
            this.clmMetallizedWidth,
            this.clmMetallizedWeigth,
            this.clmMetallizedLength,
            this.clmMetallizedCellar});
            this.dgvToMetallize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToMetallize.Location = new System.Drawing.Point(3, 17);
            this.dgvToMetallize.MultiSelect = false;
            this.dgvToMetallize.Name = "dgvToMetallize";
            this.dgvToMetallize.ReadOnly = true;
            this.dgvToMetallize.RowHeadersWidth = 20;
            this.dgvToMetallize.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToMetallize.Size = new System.Drawing.Size(773, 279);
            this.dgvToMetallize.TabIndex = 0;
            // 
            // clmMetallizedCodsec
            // 
            this.clmMetallizedCodsec.HeaderText = "clmCodsec";
            this.clmMetallizedCodsec.Name = "clmMetallizedCodsec";
            this.clmMetallizedCodsec.ReadOnly = true;
            this.clmMetallizedCodsec.Visible = false;
            // 
            // clmMetallizedCode
            // 
            this.clmMetallizedCode.HeaderText = "Código";
            this.clmMetallizedCode.Name = "clmMetallizedCode";
            this.clmMetallizedCode.ReadOnly = true;
            this.clmMetallizedCode.Width = 120;
            // 
            // clmMetallizedProduct
            // 
            this.clmMetallizedProduct.HeaderText = "Producto";
            this.clmMetallizedProduct.Name = "clmMetallizedProduct";
            this.clmMetallizedProduct.ReadOnly = true;
            this.clmMetallizedProduct.Width = 200;
            // 
            // clmMetallizedWidth
            // 
            this.clmMetallizedWidth.HeaderText = "Ancho";
            this.clmMetallizedWidth.Name = "clmMetallizedWidth";
            this.clmMetallizedWidth.ReadOnly = true;
            // 
            // clmMetallizedWeigth
            // 
            this.clmMetallizedWeigth.HeaderText = "Peso";
            this.clmMetallizedWeigth.Name = "clmMetallizedWeigth";
            this.clmMetallizedWeigth.ReadOnly = true;
            this.clmMetallizedWeigth.Width = 90;
            // 
            // clmMetallizedLength
            // 
            this.clmMetallizedLength.HeaderText = "Metraje";
            this.clmMetallizedLength.Name = "clmMetallizedLength";
            this.clmMetallizedLength.ReadOnly = true;
            // 
            // clmMetallizedCellar
            // 
            this.clmMetallizedCellar.HeaderText = "Bodega";
            this.clmMetallizedCellar.Name = "clmMetallizedCellar";
            this.clmMetallizedCellar.ReadOnly = true;
            this.clmMetallizedCellar.Width = 125;
            // 
            // frmMetallizedOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(779, 438);
            this.Controls.Add(this.grpbSelectedCoils);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbTransferActionsPallet);
            this.Controls.Add(this.grpbOrderInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMetallizedOrderDetail";
            this.Text = "Orden de metalizado";
            this.Load += new System.EventHandler(this.frmMetallizedOrderDetail_Load);
            this.grpbTransferActionsPallet.ResumeLayout(false);
            this.grpbOrderInfo.ResumeLayout(false);
            this.grpbOrderInfo.PerformLayout();
            this.grpbSelectedCoils.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToMetallize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbTransferActionsPallet;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMachineLabel;
        private System.Windows.Forms.GroupBox grpbOrderInfo;
        private System.Windows.Forms.Label lblOpticDensityLabel;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.GroupBox grpbSelectedCoils;
        private System.Windows.Forms.DataGridView dgvToMetallize;
        private System.Windows.Forms.Label lblOpticDensity;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.ToolTip ttpOrderMetalizedActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblquantityCoils;
        private System.Windows.Forms.Label lblquantityCoilsMetalized;
        private System.Windows.Forms.Label lblquantityCoilsLabel;
        private System.Windows.Forms.Label lblProductTo;
        private System.Windows.Forms.Label lblProductToLabel;
        private System.Windows.Forms.Label lblProductFrom;
        private System.Windows.Forms.Label lblProductFromLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizedCellar;
    }
}