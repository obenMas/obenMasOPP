namespace BPS
{
    partial class frmMetallizedOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMetallizedOrderList));
            this.grpbList = new System.Windows.Forms.GroupBox();
            this.dgvMetallizedOrders = new System.Windows.Forms.DataGridView();
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.grpbTransferActionsPallet = new System.Windows.Forms.GroupBox();
            this.brnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttpOrderMetalized = new System.Windows.Forms.ToolTip(this.components);
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMetallizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductoFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductoTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmquantityCoils = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOpticDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetallizedOrders)).BeginInit();
            this.grpbTransferActionsPallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbList
            // 
            this.grpbList.Controls.Add(this.dgvMetallizedOrders);
            this.grpbList.Controls.Add(this.chkShowAll);
            this.grpbList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbList.Location = new System.Drawing.Point(0, 0);
            this.grpbList.Name = "grpbList";
            this.grpbList.Size = new System.Drawing.Size(951, 353);
            this.grpbList.TabIndex = 0;
            this.grpbList.TabStop = false;
            this.grpbList.Text = "Lista de ordenes de metalizado";
            // 
            // dgvMetallizedOrders
            // 
            this.dgvMetallizedOrders.AllowUserToAddRows = false;
            this.dgvMetallizedOrders.AllowUserToDeleteRows = false;
            this.dgvMetallizedOrders.AllowUserToOrderColumns = true;
            this.dgvMetallizedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetallizedOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmNumber,
            this.clmMetallizer,
            this.clmProductoFrom,
            this.clmProductoTo,
            this.clmquantityCoils,
            this.clmOpticDensity,
            this.clmCreatedDate,
            this.clmStatus,
            this.clmDetail,
            this.clmCancel});
            this.dgvMetallizedOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMetallizedOrders.Location = new System.Drawing.Point(3, 17);
            this.dgvMetallizedOrders.Name = "dgvMetallizedOrders";
            this.dgvMetallizedOrders.ReadOnly = true;
            this.dgvMetallizedOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetallizedOrders.Size = new System.Drawing.Size(945, 314);
            this.dgvMetallizedOrders.TabIndex = 0;
            this.dgvMetallizedOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMetallizedOrders_CellClick);
            // 
            // chkShowAll
            // 
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chkShowAll.Location = new System.Drawing.Point(3, 331);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(945, 19);
            this.chkShowAll.TabIndex = 1;
            this.chkShowAll.Text = "Mostrar ordenes cerradas";
            this.chkShowAll.UseVisualStyleBackColor = true;
            this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowAll_CheckedChanged);
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Location = new System.Drawing.Point(0, 349);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(889, 43);
            this.grpbEmpty.TabIndex = 5;
            this.grpbEmpty.TabStop = false;
            // 
            // grpbTransferActionsPallet
            // 
            this.grpbTransferActionsPallet.Controls.Add(this.brnAdd);
            this.grpbTransferActionsPallet.Controls.Add(this.btnClose);
            this.grpbTransferActionsPallet.Location = new System.Drawing.Point(890, 349);
            this.grpbTransferActionsPallet.Name = "grpbTransferActionsPallet";
            this.grpbTransferActionsPallet.Size = new System.Drawing.Size(60, 43);
            this.grpbTransferActionsPallet.TabIndex = 6;
            this.grpbTransferActionsPallet.TabStop = false;
            // 
            // brnAdd
            // 
            this.brnAdd.BackgroundImage = global::BPS.Properties.Resources.add1;
            this.brnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.brnAdd.Location = new System.Drawing.Point(5, 13);
            this.brnAdd.Name = "brnAdd";
            this.brnAdd.Size = new System.Drawing.Size(24, 25);
            this.brnAdd.TabIndex = 1;
            this.ttpOrderMetalized.SetToolTip(this.brnAdd, "Agregar Ordenes Metalizado");
            this.brnAdd.UseVisualStyleBackColor = true;
            this.brnAdd.Click += new System.EventHandler(this.brnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(30, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 25);
            this.btnClose.TabIndex = 0;
            this.ttpOrderMetalized.SetToolTip(this.btnClose, "Salir Ordenes Metalizado");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Número";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmMetallizer
            // 
            this.clmMetallizer.HeaderText = "Metalizadora";
            this.clmMetallizer.Name = "clmMetallizer";
            this.clmMetallizer.ReadOnly = true;
            // 
            // clmProductoFrom
            // 
            this.clmProductoFrom.HeaderText = "Producto Inicial";
            this.clmProductoFrom.Name = "clmProductoFrom";
            this.clmProductoFrom.ReadOnly = true;
            this.clmProductoFrom.Width = 130;
            // 
            // clmProductoTo
            // 
            this.clmProductoTo.HeaderText = "Producto Final";
            this.clmProductoTo.Name = "clmProductoTo";
            this.clmProductoTo.ReadOnly = true;
            this.clmProductoTo.Width = 130;
            // 
            // clmquantityCoils
            // 
            this.clmquantityCoils.HeaderText = "Cantidad";
            this.clmquantityCoils.Name = "clmquantityCoils";
            this.clmquantityCoils.ReadOnly = true;
            this.clmquantityCoils.Width = 70;
            // 
            // clmOpticDensity
            // 
            this.clmOpticDensity.HeaderText = "Dens. Óptica";
            this.clmOpticDensity.Name = "clmOpticDensity";
            this.clmOpticDensity.ReadOnly = true;
            this.clmOpticDensity.Width = 70;
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.HeaderText = "Fecha";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.ReadOnly = true;
            this.clmCreatedDate.Width = 120;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmDetail
            // 
            this.clmDetail.HeaderText = "Ver";
            this.clmDetail.Name = "clmDetail";
            this.clmDetail.ReadOnly = true;
            this.clmDetail.Width = 30;
            // 
            // clmCancel
            // 
            this.clmCancel.HeaderText = "Anular";
            this.clmCancel.Name = "clmCancel";
            this.clmCancel.ReadOnly = true;
            this.clmCancel.Width = 50;
            // 
            // frmMetallizedOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(951, 393);
            this.Controls.Add(this.grpbList);
            this.Controls.Add(this.grpbEmpty);
            this.Controls.Add(this.grpbTransferActionsPallet);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMetallizedOrderList";
            this.Text = "Lista de ordenes de metalizado";
            this.Load += new System.EventHandler(this.frmMetallizedOrderList_Load);
            this.grpbList.ResumeLayout(false);
            this.grpbList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetallizedOrders)).EndInit();
            this.grpbTransferActionsPallet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbList;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.DataGridView dgvMetallizedOrders;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.GroupBox grpbTransferActionsPallet;
        private System.Windows.Forms.Button brnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip ttpOrderMetalized;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMetallizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductoFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductoTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmquantityCoils;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOpticDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmDetail;
        private System.Windows.Forms.DataGridViewImageColumn clmCancel;
    }
}