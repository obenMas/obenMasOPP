namespace BPS
{
    partial class frmPalletPreShippingDetailPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletPreShippingDetailPL));
            this.dgvPalletShippingPL = new System.Windows.Forms.DataGridView();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlotnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShippingPL)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPalletShippingPL
            // 
            this.dgvPalletShippingPL.AllowUserToAddRows = false;
            this.dgvPalletShippingPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletShippingPL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcode,
            this.clmcustomer,
            this.clmorder,
            this.clmproduct,
            this.clmnetweigth,
            this.clmlotnumber,
            this.clmDelete});
            this.dgvPalletShippingPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletShippingPL.Location = new System.Drawing.Point(0, 0);
            this.dgvPalletShippingPL.Name = "dgvPalletShippingPL";
            this.dgvPalletShippingPL.Size = new System.Drawing.Size(893, 491);
            this.dgvPalletShippingPL.TabIndex = 0;
            this.dgvPalletShippingPL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletShippingPL_CellContentClick);
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Pallet";
            this.clmcode.Name = "clmcode";
            this.clmcode.Width = 120;
            // 
            // clmcustomer
            // 
            this.clmcustomer.HeaderText = "Cliente";
            this.clmcustomer.Name = "clmcustomer";
            this.clmcustomer.Width = 210;
            // 
            // clmorder
            // 
            this.clmorder.HeaderText = "Orden";
            this.clmorder.Name = "clmorder";
            this.clmorder.Width = 80;
            // 
            // clmproduct
            // 
            this.clmproduct.HeaderText = "Producto";
            this.clmproduct.Name = "clmproduct";
            this.clmproduct.Width = 150;
            // 
            // clmnetweigth
            // 
            this.clmnetweigth.HeaderText = "P. Neto";
            this.clmnetweigth.Name = "clmnetweigth";
            // 
            // clmlotnumber
            // 
            this.clmlotnumber.HeaderText = "Lote";
            this.clmlotnumber.Name = "clmlotnumber";
            this.clmlotnumber.Visible = false;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Width = 30;
            // 
            // frmPalletPreShippingDetailPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 491);
            this.Controls.Add(this.dgvPalletShippingPL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletPreShippingDetailPL";
            this.Text = "Detalle Pilar";
            this.Load += new System.EventHandler(this.frmPalletPreShippingDetailPL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShippingPL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPalletShippingPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlotnumber;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}