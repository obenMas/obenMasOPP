namespace BPS
{
    partial class frmPalletListPreShippingPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletListPreShippingPL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPalletPreShippingPL = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumberPreShippingPL = new System.Windows.Forms.TextBox();
            this.lblNumerPreShipping = new System.Windows.Forms.Label();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmremito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmparameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmview = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmreport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmisinternational = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletPreShippingPL)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPalletPreShippingPL);
            this.groupBox1.Location = new System.Drawing.Point(2, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 455);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvPalletPreShippingPL
            // 
            this.dgvPalletPreShippingPL.AllowUserToAddRows = false;
            this.dgvPalletPreShippingPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletPreShippingPL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnumber,
            this.clmCustomer,
            this.clmremito,
            this.clmparameter,
            this.clmview,
            this.clmreport,
            this.clmisinternational});
            this.dgvPalletPreShippingPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletPreShippingPL.Location = new System.Drawing.Point(3, 16);
            this.dgvPalletPreShippingPL.Name = "dgvPalletPreShippingPL";
            this.dgvPalletPreShippingPL.Size = new System.Drawing.Size(658, 436);
            this.dgvPalletPreShippingPL.TabIndex = 0;
            this.dgvPalletPreShippingPL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletPreShippingPL_CellContentClick_1);
            this.dgvPalletPreShippingPL.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletPreShippingPL_CellEndEdit);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNumberPreShippingPL);
            this.groupBox2.Controls.Add(this.lblNumerPreShipping);
            this.groupBox2.Location = new System.Drawing.Point(5, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // txtNumberPreShippingPL
            // 
            this.txtNumberPreShippingPL.Location = new System.Drawing.Point(458, 19);
            this.txtNumberPreShippingPL.Name = "txtNumberPreShippingPL";
            this.txtNumberPreShippingPL.Size = new System.Drawing.Size(178, 20);
            this.txtNumberPreShippingPL.TabIndex = 2;
            this.txtNumberPreShippingPL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumberPreShippingPL_KeyDown);
            // 
            // lblNumerPreShipping
            // 
            this.lblNumerPreShipping.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumerPreShipping.AutoSize = true;
            this.lblNumerPreShipping.Location = new System.Drawing.Point(40, 22);
            this.lblNumerPreShipping.Name = "lblNumerPreShipping";
            this.lblNumerPreShipping.Size = new System.Drawing.Size(139, 13);
            this.lblNumerPreShipping.TabIndex = 1;
            this.lblNumerPreShipping.Text = "Número de Pre -  Despacho";
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Pre-despacho";
            this.clmnumber.Name = "clmnumber";
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.Width = 300;
            // 
            // clmremito
            // 
            this.clmremito.HeaderText = "Remito";
            this.clmremito.Name = "clmremito";
            this.clmremito.Width = 120;
            // 
            // clmparameter
            // 
            this.clmparameter.HeaderText = "";
            this.clmparameter.Name = "clmparameter";
            this.clmparameter.Visible = false;
            // 
            // clmview
            // 
            this.clmview.HeaderText = "";
            this.clmview.Name = "clmview";
            this.clmview.Width = 30;
            // 
            // clmreport
            // 
            this.clmreport.HeaderText = "";
            this.clmreport.Name = "clmreport";
            this.clmreport.Visible = false;
            this.clmreport.Width = 30;
            // 
            // clmisinternational
            // 
            this.clmisinternational.HeaderText = "";
            this.clmisinternational.Name = "clmisinternational";
            this.clmisinternational.Visible = false;
            this.clmisinternational.Width = 30;
            // 
            // frmPalletListPreShippingPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletListPreShippingPL";
            this.Text = "Listado de Pre Despachos Pilar";
            this.Load += new System.EventHandler(this.frmPalletListPreShippingPL_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletPreShippingPL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPalletPreShippingPL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumerPreShipping;
        private System.Windows.Forms.TextBox txtNumberPreShippingPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmremito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmparameter;
        private System.Windows.Forms.DataGridViewImageColumn clmview;
        private System.Windows.Forms.DataGridViewImageColumn clmreport;
        private System.Windows.Forms.DataGridViewImageColumn clmisinternational;
    }
}