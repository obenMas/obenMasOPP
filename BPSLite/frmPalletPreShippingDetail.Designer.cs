namespace BPS
{
    partial class frmPalletPreShippingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletPreShippingDetail));
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.dgvPalletShipping = new System.Windows.Forms.DataGridView();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlotnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.dgvPalletShipping);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(893, 491);
            this.grpbInfo.TabIndex = 0;
            this.grpbInfo.TabStop = false;
            // 
            // dgvPalletShipping
            // 
            this.dgvPalletShipping.AllowUserToAddRows = false;
            this.dgvPalletShipping.AllowUserToDeleteRows = false;
            this.dgvPalletShipping.AllowUserToOrderColumns = true;
            this.dgvPalletShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcode,
            this.clmcustomer,
            this.clmorder,
            this.clmproduct,
            this.clmnetweigth,
            this.clmlotnumber,
            this.clmDelete});
            this.dgvPalletShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletShipping.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletShipping.Name = "dgvPalletShipping";
            this.dgvPalletShipping.ReadOnly = true;
            this.dgvPalletShipping.Size = new System.Drawing.Size(887, 471);
            this.dgvPalletShipping.TabIndex = 0;
            this.dgvPalletShipping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletShipping_CellContentClick);
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Pallet";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            this.clmcode.Width = 120;
            // 
            // clmcustomer
            // 
            this.clmcustomer.HeaderText = "Cliente";
            this.clmcustomer.Name = "clmcustomer";
            this.clmcustomer.ReadOnly = true;
            this.clmcustomer.Width = 210;
            // 
            // clmorder
            // 
            this.clmorder.HeaderText = "Orden";
            this.clmorder.Name = "clmorder";
            this.clmorder.ReadOnly = true;
            this.clmorder.Width = 80;
            // 
            // clmproduct
            // 
            this.clmproduct.HeaderText = "Producto";
            this.clmproduct.Name = "clmproduct";
            this.clmproduct.ReadOnly = true;
            this.clmproduct.Width = 150;
            // 
            // clmnetweigth
            // 
            this.clmnetweigth.HeaderText = "P. Neto";
            this.clmnetweigth.Name = "clmnetweigth";
            this.clmnetweigth.ReadOnly = true;
            // 
            // clmlotnumber
            // 
            this.clmlotnumber.HeaderText = "Lote";
            this.clmlotnumber.Name = "clmlotnumber";
            this.clmlotnumber.ReadOnly = true;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmDelete.Width = 30;
            // 
            // frmPalletPreShippingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(893, 491);
            this.Controls.Add(this.grpbInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletPreShippingDetail";
            this.Load += new System.EventHandler(this.frmPalletPreShippingDetail_Load);
            this.grpbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.DataGridView dgvPalletShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlotnumber;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}