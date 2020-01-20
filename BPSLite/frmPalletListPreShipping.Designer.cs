namespace BPS.Lite
{
    partial class frmPalletListPreShipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletListPreShipping));
            this.grpbInfo = new System.Windows.Forms.GroupBox();
            this.dgvPalletPreShipping = new System.Windows.Forms.DataGridView();
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblFilteredQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberPreShipping = new System.Windows.Forms.TextBox();
            this.lblNumerPreShipping = new System.Windows.Forms.Label();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmremito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmview = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmreport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmisinternational = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletPreShipping)).BeginInit();
            this.grpbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInfo
            // 
            this.grpbInfo.Controls.Add(this.dgvPalletPreShipping);
            this.grpbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbInfo.Name = "grpbInfo";
            this.grpbInfo.Size = new System.Drawing.Size(742, 455);
            this.grpbInfo.TabIndex = 0;
            this.grpbInfo.TabStop = false;
            // 
            // dgvPalletPreShipping
            // 
            this.dgvPalletPreShipping.AllowUserToAddRows = false;
            this.dgvPalletPreShipping.AllowUserToDeleteRows = false;
            this.dgvPalletPreShipping.AllowUserToOrderColumns = true;
            this.dgvPalletPreShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletPreShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnumber,
            this.clmCustomer,
            this.clmPlant,
            this.clmremito,
            this.clmparameter,
            this.clmview,
            this.clmreport,
            this.clmisinternational});
            this.dgvPalletPreShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletPreShipping.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletPreShipping.Name = "dgvPalletPreShipping";
            this.dgvPalletPreShipping.RowHeadersWidth = 21;
            this.dgvPalletPreShipping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalletPreShipping.Size = new System.Drawing.Size(736, 435);
            this.dgvPalletPreShipping.TabIndex = 0;
            this.dgvPalletPreShipping.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletPreShipping_CellContentClick);
            this.dgvPalletPreShipping.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletPreShipping_CellEndEdit);
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.label2);
            this.grpbFilter.Controls.Add(this.txtQuantity);
            this.grpbFilter.Controls.Add(this.lblFilteredQuantity);
            this.grpbFilter.Controls.Add(this.label1);
            this.grpbFilter.Controls.Add(this.txtNumberPreShipping);
            this.grpbFilter.Controls.Add(this.lblNumerPreShipping);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFilter.Location = new System.Drawing.Point(0, 455);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(742, 47);
            this.grpbFilter.TabIndex = 1;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(667, 17);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(54, 21);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Text = "500";
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            // 
            // lblFilteredQuantity
            // 
            this.lblFilteredQuantity.AutoSize = true;
            this.lblFilteredQuantity.Location = new System.Drawing.Point(629, 20);
            this.lblFilteredQuantity.Name = "lblFilteredQuantity";
            this.lblFilteredQuantity.Size = new System.Drawing.Size(17, 15);
            this.lblFilteredQuantity.TabIndex = 3;
            this.lblFilteredQuantity.Text = "0 ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registros:";
            // 
            // txtNumberPreShipping
            // 
            this.txtNumberPreShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumberPreShipping.Location = new System.Drawing.Point(191, 16);
            this.txtNumberPreShipping.Name = "txtNumberPreShipping";
            this.txtNumberPreShipping.Size = new System.Drawing.Size(171, 21);
            this.txtNumberPreShipping.TabIndex = 1;
            this.txtNumberPreShipping.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumberPreShipping_KeyDown);
            // 
            // lblNumerPreShipping
            // 
            this.lblNumerPreShipping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumerPreShipping.AutoSize = true;
            this.lblNumerPreShipping.Location = new System.Drawing.Point(19, 18);
            this.lblNumerPreShipping.Name = "lblNumerPreShipping";
            this.lblNumerPreShipping.Size = new System.Drawing.Size(160, 15);
            this.lblNumerPreShipping.TabIndex = 0;
            this.lblNumerPreShipping.Text = "Número de Pre -  Despacho";
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Pre-despacho";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.Width = 300;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            // 
            // clmremito
            // 
            this.clmremito.HeaderText = "Remito";
            this.clmremito.Name = "clmremito";
            // 
            // clmparameter
            // 
            this.clmparameter.HeaderText = "";
            this.clmparameter.Name = "clmparameter";
            this.clmparameter.ReadOnly = true;
            this.clmparameter.Visible = false;
            // 
            // clmview
            // 
            this.clmview.HeaderText = "";
            this.clmview.Name = "clmview";
            this.clmview.ReadOnly = true;
            this.clmview.Width = 30;
            // 
            // clmreport
            // 
            this.clmreport.HeaderText = "";
            this.clmreport.Name = "clmreport";
            this.clmreport.ReadOnly = true;
            this.clmreport.Width = 30;
            // 
            // clmisinternational
            // 
            this.clmisinternational.HeaderText = "";
            this.clmisinternational.Name = "clmisinternational";
            this.clmisinternational.ReadOnly = true;
            this.clmisinternational.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmisinternational.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmisinternational.Width = 30;
            // 
            // frmPalletListPreShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(742, 502);
            this.Controls.Add(this.grpbInfo);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletListPreShipping";
            this.Text = "Listado de Pre Despachos";
            this.Load += new System.EventHandler(this.frmPalletListPreShipping_Load);
            this.grpbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletPreShipping)).EndInit();
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInfo;
        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.TextBox txtNumberPreShipping;
        private System.Windows.Forms.Label lblNumerPreShipping;
        private System.Windows.Forms.DataGridView dgvPalletPreShipping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilteredQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmremito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmparameter;
        private System.Windows.Forms.DataGridViewImageColumn clmview;
        private System.Windows.Forms.DataGridViewImageColumn clmreport;
        private System.Windows.Forms.DataGridViewImageColumn clmisinternational;
    }
}