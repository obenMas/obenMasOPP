namespace BPS
{
    partial class frmPalletCoilRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletCoilRequest));
            this.grpbPalletTransfer = new System.Windows.Forms.GroupBox();
            this.cmbDestinationCellar = new System.Windows.Forms.ComboBox();
            this.lblCellarPallets = new System.Windows.Forms.Label();
            this.dgvTransferListPallet = new System.Windows.Forms.DataGridView();
            this.clmRequestCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequestType = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmRequestTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequestCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRequestRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbTransferActionsPallet = new System.Windows.Forms.GroupBox();
            this.btnCancelTransferPallet = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.grpbCellar = new System.Windows.Forms.GroupBox();
            this.grpbCoilCellar = new System.Windows.Forms.GroupBox();
            this.cmbOriginCellar = new System.Windows.Forms.ComboBox();
            this.lblOriginCellar = new System.Windows.Forms.Label();
            this.tbcLists = new System.Windows.Forms.TabControl();
            this.tbpPallets = new System.Windows.Forms.TabPage();
            this.grpbPalletList = new System.Windows.Forms.GroupBox();
            this.dgvPallets = new System.Windows.Forms.DataGridView();
            this.clmPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpCoils = new System.Windows.Forms.TabPage();
            this.grpbCoilList = new System.Windows.Forms.GroupBox();
            this.dgvCoils = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttpPalletCoilRequest = new System.Windows.Forms.ToolTip(this.components);
            this.grpbPalletTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferListPallet)).BeginInit();
            this.grpbTransferActionsPallet.SuspendLayout();
            this.grpbCellar.SuspendLayout();
            this.grpbCoilCellar.SuspendLayout();
            this.tbcLists.SuspendLayout();
            this.tbpPallets.SuspendLayout();
            this.grpbPalletList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).BeginInit();
            this.tbpCoils.SuspendLayout();
            this.grpbCoilList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbPalletTransfer
            // 
            this.grpbPalletTransfer.Controls.Add(this.cmbDestinationCellar);
            this.grpbPalletTransfer.Controls.Add(this.lblCellarPallets);
            this.grpbPalletTransfer.Controls.Add(this.dgvTransferListPallet);
            this.grpbPalletTransfer.Controls.Add(this.grpbEmpty);
            this.grpbPalletTransfer.Controls.Add(this.grpbTransferActionsPallet);
            this.grpbPalletTransfer.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpbPalletTransfer.Location = new System.Drawing.Point(707, 0);
            this.grpbPalletTransfer.Name = "grpbPalletTransfer";
            this.grpbPalletTransfer.Size = new System.Drawing.Size(365, 497);
            this.grpbPalletTransfer.TabIndex = 3;
            this.grpbPalletTransfer.TabStop = false;
            this.grpbPalletTransfer.Text = "Pallets y bobinas  solicitadas";
            // 
            // cmbDestinationCellar
            // 
            this.cmbDestinationCellar.FormattingEnabled = true;
            this.cmbDestinationCellar.Location = new System.Drawing.Point(123, 25);
            this.cmbDestinationCellar.Name = "cmbDestinationCellar";
            this.cmbDestinationCellar.Size = new System.Drawing.Size(181, 23);
            this.cmbDestinationCellar.TabIndex = 21;
            this.cmbDestinationCellar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDestinationCellar_KeyDown);
            // 
            // lblCellarPallets
            // 
            this.lblCellarPallets.AutoSize = true;
            this.lblCellarPallets.Location = new System.Drawing.Point(61, 28);
            this.lblCellarPallets.Name = "lblCellarPallets";
            this.lblCellarPallets.Size = new System.Drawing.Size(50, 15);
            this.lblCellarPallets.TabIndex = 28;
            this.lblCellarPallets.Text = "Bodega";
            // 
            // dgvTransferListPallet
            // 
            this.dgvTransferListPallet.AllowDrop = true;
            this.dgvTransferListPallet.AllowUserToAddRows = false;
            this.dgvTransferListPallet.AllowUserToDeleteRows = false;
            this.dgvTransferListPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferListPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRequestCodsec,
            this.clmRequestType,
            this.clmRequestTypeName,
            this.clmRequestCode,
            this.clmRequestCellar,
            this.clmRequestRemove});
            this.dgvTransferListPallet.Location = new System.Drawing.Point(4, 55);
            this.dgvTransferListPallet.Name = "dgvTransferListPallet";
            this.dgvTransferListPallet.ReadOnly = true;
            this.dgvTransferListPallet.Size = new System.Drawing.Size(356, 397);
            this.dgvTransferListPallet.TabIndex = 23;
            this.dgvTransferListPallet.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvTransferListPallet_DragDrop);
            this.dgvTransferListPallet.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvTransferListPallet_DragEnter);
            this.dgvTransferListPallet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvTransferListPallet_MouseMove);
            // 
            // clmRequestCodsec
            // 
            this.clmRequestCodsec.HeaderText = "codsec";
            this.clmRequestCodsec.Name = "clmRequestCodsec";
            this.clmRequestCodsec.ReadOnly = true;
            this.clmRequestCodsec.Visible = false;
            // 
            // clmRequestType
            // 
            this.clmRequestType.HeaderText = "";
            this.clmRequestType.Name = "clmRequestType";
            this.clmRequestType.ReadOnly = true;
            this.clmRequestType.Width = 30;
            // 
            // clmRequestTypeName
            // 
            this.clmRequestTypeName.HeaderText = "Tipo";
            this.clmRequestTypeName.Name = "clmRequestTypeName";
            this.clmRequestTypeName.ReadOnly = true;
            this.clmRequestTypeName.Visible = false;
            // 
            // clmRequestCode
            // 
            this.clmRequestCode.HeaderText = "Código";
            this.clmRequestCode.Name = "clmRequestCode";
            this.clmRequestCode.ReadOnly = true;
            this.clmRequestCode.Width = 130;
            // 
            // clmRequestCellar
            // 
            this.clmRequestCellar.HeaderText = "Bodega";
            this.clmRequestCellar.Name = "clmRequestCellar";
            this.clmRequestCellar.ReadOnly = true;
            // 
            // clmRequestRemove
            // 
            this.clmRequestRemove.HeaderText = "";
            this.clmRequestRemove.Name = "clmRequestRemove";
            this.clmRequestRemove.ReadOnly = true;
            this.clmRequestRemove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmRequestRemove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmRequestRemove.Width = 30;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(4, 450);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(294, 43);
            this.grpbEmpty.TabIndex = 26;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbTransferActionsPallet
            // 
            this.grpbTransferActionsPallet.Controls.Add(this.btnCancelTransferPallet);
            this.grpbTransferActionsPallet.Controls.Add(this.btnRequest);
            this.grpbTransferActionsPallet.Location = new System.Drawing.Point(300, 450);
            this.grpbTransferActionsPallet.Name = "grpbTransferActionsPallet";
            this.grpbTransferActionsPallet.Size = new System.Drawing.Size(60, 43);
            this.grpbTransferActionsPallet.TabIndex = 25;
            this.grpbTransferActionsPallet.TabStop = false;
            // 
            // btnCancelTransferPallet
            // 
            this.btnCancelTransferPallet.BackgroundImage = global::BPS.Properties.Resources.cancel;
            this.btnCancelTransferPallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelTransferPallet.Location = new System.Drawing.Point(6, 13);
            this.btnCancelTransferPallet.Name = "btnCancelTransferPallet";
            this.btnCancelTransferPallet.Size = new System.Drawing.Size(24, 25);
            this.btnCancelTransferPallet.TabIndex = 1;
            this.ttpPalletCoilRequest.SetToolTip(this.btnCancelTransferPallet, "Cancelar");
            this.btnCancelTransferPallet.UseVisualStyleBackColor = true;
            this.btnCancelTransferPallet.Click += new System.EventHandler(this.btnCancelTransferPallet_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRequest.Location = new System.Drawing.Point(31, 13);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(24, 25);
            this.btnRequest.TabIndex = 0;
            this.ttpPalletCoilRequest.SetToolTip(this.btnRequest, "Guardar");
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // grpbCellar
            // 
            this.grpbCellar.Controls.Add(this.grpbCoilCellar);
            this.grpbCellar.Controls.Add(this.tbcLists);
            this.grpbCellar.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpbCellar.Location = new System.Drawing.Point(0, 0);
            this.grpbCellar.Name = "grpbCellar";
            this.grpbCellar.Size = new System.Drawing.Size(703, 497);
            this.grpbCellar.TabIndex = 4;
            this.grpbCellar.TabStop = false;
            this.grpbCellar.Text = "Pallet y bobinas por bodega";
            // 
            // grpbCoilCellar
            // 
            this.grpbCoilCellar.Controls.Add(this.cmbOriginCellar);
            this.grpbCoilCellar.Controls.Add(this.lblOriginCellar);
            this.grpbCoilCellar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilCellar.Location = new System.Drawing.Point(3, 17);
            this.grpbCoilCellar.Name = "grpbCoilCellar";
            this.grpbCoilCellar.Size = new System.Drawing.Size(697, 45);
            this.grpbCoilCellar.TabIndex = 3;
            this.grpbCoilCellar.TabStop = false;
            this.grpbCoilCellar.Text = "Bodega";
            // 
            // cmbOriginCellar
            // 
            this.cmbOriginCellar.FormattingEnabled = true;
            this.cmbOriginCellar.Location = new System.Drawing.Point(240, 14);
            this.cmbOriginCellar.Name = "cmbOriginCellar";
            this.cmbOriginCellar.Size = new System.Drawing.Size(234, 23);
            this.cmbOriginCellar.TabIndex = 29;
            this.cmbOriginCellar.SelectedIndexChanged += new System.EventHandler(this.cmbOriginCellar_SelectedIndexChanged);
            this.cmbOriginCellar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOriginCellar_KeyDown);
            // 
            // lblOriginCellar
            // 
            this.lblOriginCellar.AutoSize = true;
            this.lblOriginCellar.Location = new System.Drawing.Point(178, 17);
            this.lblOriginCellar.Name = "lblOriginCellar";
            this.lblOriginCellar.Size = new System.Drawing.Size(50, 15);
            this.lblOriginCellar.TabIndex = 30;
            this.lblOriginCellar.Text = "Bodega";
            // 
            // tbcLists
            // 
            this.tbcLists.Controls.Add(this.tbpPallets);
            this.tbcLists.Controls.Add(this.tbpCoils);
            this.tbcLists.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbcLists.Location = new System.Drawing.Point(3, 68);
            this.tbcLists.Name = "tbcLists";
            this.tbcLists.SelectedIndex = 0;
            this.tbcLists.Size = new System.Drawing.Size(697, 426);
            this.tbcLists.TabIndex = 2;
            // 
            // tbpPallets
            // 
            this.tbpPallets.Controls.Add(this.grpbPalletList);
            this.tbpPallets.Location = new System.Drawing.Point(4, 24);
            this.tbpPallets.Name = "tbpPallets";
            this.tbpPallets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPallets.Size = new System.Drawing.Size(689, 398);
            this.tbpPallets.TabIndex = 0;
            this.tbpPallets.Text = "Pallets";
            this.tbpPallets.UseVisualStyleBackColor = true;
            // 
            // grpbPalletList
            // 
            this.grpbPalletList.Controls.Add(this.dgvPallets);
            this.grpbPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletList.Location = new System.Drawing.Point(3, 3);
            this.grpbPalletList.Name = "grpbPalletList";
            this.grpbPalletList.Size = new System.Drawing.Size(683, 392);
            this.grpbPalletList.TabIndex = 0;
            this.grpbPalletList.TabStop = false;
            this.grpbPalletList.Text = "Listado de pallets";
            // 
            // dgvPallets
            // 
            this.dgvPallets.AllowUserToAddRows = false;
            this.dgvPallets.AllowUserToDeleteRows = false;
            this.dgvPallets.AllowUserToOrderColumns = true;
            this.dgvPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletCodsec,
            this.clmPalletCode,
            this.clmPalletCustomer,
            this.clmPalletProduct,
            this.clmPalletWeigth,
            this.clmPalletType});
            this.dgvPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPallets.Location = new System.Drawing.Point(3, 17);
            this.dgvPallets.MultiSelect = false;
            this.dgvPallets.Name = "dgvPallets";
            this.dgvPallets.ReadOnly = true;
            this.dgvPallets.RowHeadersWidth = 20;
            this.dgvPallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPallets.Size = new System.Drawing.Size(677, 372);
            this.dgvPallets.TabIndex = 1;
            this.dgvPallets.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvPallets_MouseMove);
            // 
            // clmPalletCodsec
            // 
            this.clmPalletCodsec.HeaderText = "clmPalletCodsec";
            this.clmPalletCodsec.Name = "clmPalletCodsec";
            this.clmPalletCodsec.ReadOnly = true;
            this.clmPalletCodsec.Visible = false;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Código";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            // 
            // clmPalletCustomer
            // 
            this.clmPalletCustomer.HeaderText = "Cliente";
            this.clmPalletCustomer.Name = "clmPalletCustomer";
            this.clmPalletCustomer.ReadOnly = true;
            this.clmPalletCustomer.Width = 220;
            // 
            // clmPalletProduct
            // 
            this.clmPalletProduct.HeaderText = "Producto";
            this.clmPalletProduct.Name = "clmPalletProduct";
            this.clmPalletProduct.ReadOnly = true;
            this.clmPalletProduct.Width = 200;
            // 
            // clmPalletWeigth
            // 
            this.clmPalletWeigth.HeaderText = "Peso";
            this.clmPalletWeigth.Name = "clmPalletWeigth";
            this.clmPalletWeigth.ReadOnly = true;
            this.clmPalletWeigth.Width = 90;
            // 
            // clmPalletType
            // 
            this.clmPalletType.HeaderText = "Tipo";
            this.clmPalletType.Name = "clmPalletType";
            this.clmPalletType.ReadOnly = true;
            // 
            // tbpCoils
            // 
            this.tbpCoils.Controls.Add(this.grpbCoilList);
            this.tbpCoils.Location = new System.Drawing.Point(4, 24);
            this.tbpCoils.Name = "tbpCoils";
            this.tbpCoils.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoils.Size = new System.Drawing.Size(689, 398);
            this.tbpCoils.TabIndex = 1;
            this.tbpCoils.Text = "Bobinas";
            this.tbpCoils.UseVisualStyleBackColor = true;
            // 
            // grpbCoilList
            // 
            this.grpbCoilList.Controls.Add(this.dgvCoils);
            this.grpbCoilList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbCoilList.Location = new System.Drawing.Point(3, 3);
            this.grpbCoilList.Name = "grpbCoilList";
            this.grpbCoilList.Size = new System.Drawing.Size(683, 392);
            this.grpbCoilList.TabIndex = 0;
            this.grpbCoilList.TabStop = false;
            this.grpbCoilList.Text = "Listado de Bobinas";
            // 
            // dgvCoils
            // 
            this.dgvCoils.AllowUserToAddRows = false;
            this.dgvCoils.AllowUserToDeleteRows = false;
            this.dgvCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmCustomer,
            this.clmProductName,
            this.clmWeigth,
            this.clmLength,
            this.clmWidth});
            this.dgvCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoils.Location = new System.Drawing.Point(3, 17);
            this.dgvCoils.MultiSelect = false;
            this.dgvCoils.Name = "dgvCoils";
            this.dgvCoils.ReadOnly = true;
            this.dgvCoils.RowHeadersWidth = 20;
            this.dgvCoils.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoils.Size = new System.Drawing.Size(677, 372);
            this.dgvCoils.TabIndex = 1;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 220;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Width = 200;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Peso";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            this.clmWeigth.Width = 90;
            // 
            // clmLength
            // 
            this.clmLength.HeaderText = "Metraje";
            this.clmLength.Name = "clmLength";
            this.clmLength.ReadOnly = true;
            this.clmLength.Width = 90;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 90;
            // 
            // frmPalletCoilRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1072, 497);
            this.Controls.Add(this.grpbCellar);
            this.Controls.Add(this.grpbPalletTransfer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletCoilRequest";
            this.Text = "Solicitud de pallets - bobinas";
            this.Load += new System.EventHandler(this.frmPalletCoilRequest_Load);
            this.grpbPalletTransfer.ResumeLayout(false);
            this.grpbPalletTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferListPallet)).EndInit();
            this.grpbTransferActionsPallet.ResumeLayout(false);
            this.grpbCellar.ResumeLayout(false);
            this.grpbCoilCellar.ResumeLayout(false);
            this.grpbCoilCellar.PerformLayout();
            this.tbcLists.ResumeLayout(false);
            this.tbpPallets.ResumeLayout(false);
            this.grpbPalletList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).EndInit();
            this.tbpCoils.ResumeLayout(false);
            this.grpbCoilList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoils)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbPalletTransfer;
        private System.Windows.Forms.ComboBox cmbDestinationCellar;
        private System.Windows.Forms.Label lblCellarPallets;
        private System.Windows.Forms.DataGridView dgvTransferListPallet;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbTransferActionsPallet;
        private System.Windows.Forms.Button btnCancelTransferPallet;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.GroupBox grpbCellar;
        private System.Windows.Forms.GroupBox grpbCoilCellar;
        private System.Windows.Forms.TabControl tbcLists;
        private System.Windows.Forms.TabPage tbpPallets;
        private System.Windows.Forms.GroupBox grpbPalletList;
        private System.Windows.Forms.DataGridView dgvPallets;
        private System.Windows.Forms.TabPage tbpCoils;
        private System.Windows.Forms.GroupBox grpbCoilList;
        private System.Windows.Forms.DataGridView dgvCoils;
        private System.Windows.Forms.ComboBox cmbOriginCellar;
        private System.Windows.Forms.Label lblOriginCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequestCodsec;
        private System.Windows.Forms.DataGridViewImageColumn clmRequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequestTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRequestCellar;
        private System.Windows.Forms.DataGridViewImageColumn clmRequestRemove;
        private System.Windows.Forms.ToolTip ttpPalletCoilRequest;

    }
}