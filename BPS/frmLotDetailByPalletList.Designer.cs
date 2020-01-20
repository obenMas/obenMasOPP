namespace BPS
{
    partial class frmLotDetailByPalletList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLotDetailByPalletList));
            this.grpbPalletList = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.btnAddPallet = new System.Windows.Forms.Button();
            this.grpbPallets = new System.Windows.Forms.GroupBox();
            this.dgvPallets = new System.Windows.Forms.DataGridView();
            this.grpbLots = new System.Windows.Forms.GroupBox();
            this.dgvLots = new System.Windows.Forms.DataGridView();
            this.clmLotProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.chkSelectNone = new System.Windows.Forms.CheckBox();
            this.clmPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletVisibility = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmPalletVisibilityValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbPalletList.SuspendLayout();
            this.grpbPallets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).BeginInit();
            this.grpbLots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLots)).BeginInit();
            this.grpbActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbPalletList
            // 
            this.grpbPalletList.Controls.Add(this.chkSelectNone);
            this.grpbPalletList.Controls.Add(this.chkSelectAll);
            this.grpbPalletList.Controls.Add(this.btnRefresh);
            this.grpbPalletList.Controls.Add(this.txtPalletCode);
            this.grpbPalletList.Controls.Add(this.lblPalletCode);
            this.grpbPalletList.Controls.Add(this.btnAddPallet);
            this.grpbPalletList.Controls.Add(this.grpbPallets);
            this.grpbPalletList.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbPalletList.Location = new System.Drawing.Point(0, 0);
            this.grpbPalletList.Name = "grpbPalletList";
            this.grpbPalletList.Size = new System.Drawing.Size(534, 393);
            this.grpbPalletList.TabIndex = 0;
            this.grpbPalletList.TabStop = false;
            this.grpbPalletList.Text = "Pallets";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::BPS.Properties.Resources.arrow_refresh;
            this.btnRefresh.Location = new System.Drawing.Point(503, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 112;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalletCode.Location = new System.Drawing.Point(193, 23);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(153, 26);
            this.txtPalletCode.TabIndex = 109;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(134, 26);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(53, 20);
            this.lblPalletCode.TabIndex = 108;
            this.lblPalletCode.Text = "Orden";
            // 
            // btnAddPallet
            // 
            this.btnAddPallet.Image = global::BPS.Properties.Resources.pallet;
            this.btnAddPallet.Location = new System.Drawing.Point(352, 24);
            this.btnAddPallet.Name = "btnAddPallet";
            this.btnAddPallet.Size = new System.Drawing.Size(25, 25);
            this.btnAddPallet.TabIndex = 110;
            this.btnAddPallet.UseVisualStyleBackColor = true;
            this.btnAddPallet.Click += new System.EventHandler(this.btnAddPallet_Click);
            // 
            // grpbPallets
            // 
            this.grpbPallets.Controls.Add(this.dgvPallets);
            this.grpbPallets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbPallets.Location = new System.Drawing.Point(3, 86);
            this.grpbPallets.Name = "grpbPallets";
            this.grpbPallets.Size = new System.Drawing.Size(528, 304);
            this.grpbPallets.TabIndex = 111;
            this.grpbPallets.TabStop = false;
            this.grpbPallets.Text = "Pallets";
            // 
            // dgvPallets
            // 
            this.dgvPallets.AllowUserToAddRows = false;
            this.dgvPallets.AllowUserToDeleteRows = false;
            this.dgvPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletCodsec,
            this.clmPalletCode,
            this.clmPalletCustomer,
            this.clmPalletOrderNumber,
            this.clmPalletVisibility,
            this.clmPalletVisibilityValue});
            this.dgvPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvPallets.Name = "dgvPallets";
            this.dgvPallets.ReadOnly = true;
            this.dgvPallets.RowHeadersWidth = 15;
            this.dgvPallets.Size = new System.Drawing.Size(522, 284);
            this.dgvPallets.TabIndex = 0;
            this.dgvPallets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPallets_CellClick);
            // 
            // grpbLots
            // 
            this.grpbLots.Controls.Add(this.dgvLots);
            this.grpbLots.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbLots.Location = new System.Drawing.Point(540, 0);
            this.grpbLots.Name = "grpbLots";
            this.grpbLots.Size = new System.Drawing.Size(427, 393);
            this.grpbLots.TabIndex = 1;
            this.grpbLots.TabStop = false;
            this.grpbLots.Text = "Lotes";
            // 
            // dgvLots
            // 
            this.dgvLots.AllowUserToAddRows = false;
            this.dgvLots.AllowUserToDeleteRows = false;
            this.dgvLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmLotProduct,
            this.clmLotNumber});
            this.dgvLots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLots.Location = new System.Drawing.Point(3, 17);
            this.dgvLots.Name = "dgvLots";
            this.dgvLots.ReadOnly = true;
            this.dgvLots.Size = new System.Drawing.Size(421, 373);
            this.dgvLots.TabIndex = 1;
            // 
            // clmLotProduct
            // 
            this.clmLotProduct.HeaderText = "Tipo";
            this.clmLotProduct.Name = "clmLotProduct";
            this.clmLotProduct.ReadOnly = true;
            this.clmLotProduct.Width = 200;
            // 
            // clmLotNumber
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clmLotNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmLotNumber.HeaderText = "Lote";
            this.clmLotNumber.Name = "clmLotNumber";
            this.clmLotNumber.ReadOnly = true;
            this.clmLotNumber.Width = 150;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbActions.Location = new System.Drawing.Point(0, 393);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(967, 43);
            this.grpbActions.TabIndex = 2;
            this.grpbActions.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::BPS.Properties.Resources.door_in;
            this.btnClose.Location = new System.Drawing.Point(936, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 108;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSelectAll.Location = new System.Drawing.Point(400, 47);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(128, 19);
            this.chkSelectAll.TabIndex = 113;
            this.chkSelectAll.Text = "Seleccionar Todos";
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged);
            // 
            // chkSelectNone
            // 
            this.chkSelectNone.AutoSize = true;
            this.chkSelectNone.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSelectNone.Location = new System.Drawing.Point(387, 72);
            this.chkSelectNone.Name = "chkSelectNone";
            this.chkSelectNone.Size = new System.Drawing.Size(141, 19);
            this.chkSelectNone.TabIndex = 114;
            this.chkSelectNone.Text = "Seleccionar Ninguno";
            this.chkSelectNone.UseVisualStyleBackColor = true;
            this.chkSelectNone.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clmPalletCodsec
            // 
            this.clmPalletCodsec.HeaderText = "codsec";
            this.clmPalletCodsec.Name = "clmPalletCodsec";
            this.clmPalletCodsec.ReadOnly = true;
            this.clmPalletCodsec.Visible = false;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Código";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            this.clmPalletCode.Width = 150;
            // 
            // clmPalletCustomer
            // 
            this.clmPalletCustomer.HeaderText = "Producto";
            this.clmPalletCustomer.Name = "clmPalletCustomer";
            this.clmPalletCustomer.ReadOnly = true;
            this.clmPalletCustomer.Width = 200;
            // 
            // clmPalletOrderNumber
            // 
            this.clmPalletOrderNumber.HeaderText = "Número";
            this.clmPalletOrderNumber.Name = "clmPalletOrderNumber";
            this.clmPalletOrderNumber.ReadOnly = true;
            // 
            // clmPalletVisibility
            // 
            this.clmPalletVisibility.HeaderText = "";
            this.clmPalletVisibility.Name = "clmPalletVisibility";
            this.clmPalletVisibility.ReadOnly = true;
            this.clmPalletVisibility.Width = 30;
            // 
            // clmPalletVisibilityValue
            // 
            this.clmPalletVisibilityValue.HeaderText = "";
            this.clmPalletVisibilityValue.Name = "clmPalletVisibilityValue";
            this.clmPalletVisibilityValue.ReadOnly = true;
            this.clmPalletVisibilityValue.Visible = false;
            // 
            // frmLotDetailByPalletList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(967, 436);
            this.Controls.Add(this.grpbLots);
            this.Controls.Add(this.grpbPalletList);
            this.Controls.Add(this.grpbActions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLotDetailByPalletList";
            this.Text = "Detalle de lotes por pallets";
            this.Load += new System.EventHandler(this.frmLotDetailByPalletList_Load);
            this.grpbPalletList.ResumeLayout(false);
            this.grpbPalletList.PerformLayout();
            this.grpbPallets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).EndInit();
            this.grpbLots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLots)).EndInit();
            this.grpbActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPalletList;
        private System.Windows.Forms.DataGridView dgvPallets;
        private System.Windows.Forms.GroupBox grpbLots;
        private System.Windows.Forms.DataGridView dgvLots;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotNumber;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.Button btnAddPallet;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpbPallets;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox chkSelectNone;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletOrderNumber;
        private System.Windows.Forms.DataGridViewImageColumn clmPalletVisibility;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletVisibilityValue;
    }
}