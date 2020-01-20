namespace BPS
{
    partial class frmDepositListPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositListPL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDepositListPL = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalNetWeightPL = new System.Windows.Forms.TextBox();
            this.chkSelectAllPL = new System.Windows.Forms.CheckBox();
            this.btnPreshippingPL = new System.Windows.Forms.Button();
            this.btnExportPL = new System.Windows.Forms.Button();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchaseOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositListPL)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDepositListPL);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvDepositListPL
            // 
            this.dgvDepositListPL.AllowUserToAddRows = false;
            this.dgvDepositListPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositListPL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmOrder,
            this.clmPurchaseOrder,
            this.clmPrice,
            this.clmPlant,
            this.clmCode,
            this.clmFilm,
            this.clmWidth,
            this.clmDiameter,
            this.clmCore,
            this.clmNetWeight,
            this.clmCustomer,
            this.clmSaleOrder,
            this.clmOrigin,
            this.clmQualification,
            this.clmLocation,
            this.clmDate,
            this.clmCheck});
            this.dgvDepositListPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepositListPL.Location = new System.Drawing.Point(3, 16);
            this.dgvDepositListPL.Name = "dgvDepositListPL";
            this.dgvDepositListPL.Size = new System.Drawing.Size(1108, 437);
            this.dgvDepositListPL.TabIndex = 0;
            this.dgvDepositListPL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositListPL_CellContentClick);
            this.dgvDepositListPL.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositListPL_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(869, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selección:";
            // 
            // txtTotalNetWeightPL
            // 
            this.txtTotalNetWeightPL.Location = new System.Drawing.Point(763, 473);
            this.txtTotalNetWeightPL.Name = "txtTotalNetWeightPL";
            this.txtTotalNetWeightPL.Size = new System.Drawing.Size(100, 20);
            this.txtTotalNetWeightPL.TabIndex = 3;
            // 
            // chkSelectAllPL
            // 
            this.chkSelectAllPL.AutoSize = true;
            this.chkSelectAllPL.Location = new System.Drawing.Point(932, 474);
            this.chkSelectAllPL.Name = "chkSelectAllPL";
            this.chkSelectAllPL.Size = new System.Drawing.Size(15, 14);
            this.chkSelectAllPL.TabIndex = 4;
            this.chkSelectAllPL.UseVisualStyleBackColor = true;
            this.chkSelectAllPL.CheckedChanged += new System.EventHandler(this.chkSelectAllPL_CheckedChanged);
            // 
            // btnPreshippingPL
            // 
            this.btnPreshippingPL.Location = new System.Drawing.Point(1015, 469);
            this.btnPreshippingPL.Name = "btnPreshippingPL";
            this.btnPreshippingPL.Size = new System.Drawing.Size(99, 23);
            this.btnPreshippingPL.TabIndex = 5;
            this.btnPreshippingPL.Text = "Predespacho";
            this.btnPreshippingPL.UseVisualStyleBackColor = true;
            this.btnPreshippingPL.Click += new System.EventHandler(this.btnPreshippingPL_Click);
            // 
            // btnExportPL
            // 
            this.btnExportPL.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportPL.Location = new System.Drawing.Point(970, 466);
            this.btnExportPL.Name = "btnExportPL";
            this.btnExportPL.Size = new System.Drawing.Size(25, 25);
            this.btnExportPL.TabIndex = 6;
            this.btnExportPL.UseVisualStyleBackColor = true;
            this.btnExportPL.Click += new System.EventHandler(this.btnExportPL_Click);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            this.clmCodsec.Width = 80;
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Pedido";
            this.clmOrder.Name = "clmOrder";
            this.clmOrder.Width = 70;
            // 
            // clmPurchaseOrder
            // 
            this.clmPurchaseOrder.HeaderText = "OC Cliente";
            this.clmPurchaseOrder.Name = "clmPurchaseOrder";
            this.clmPurchaseOrder.Width = 60;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio AR$";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 80;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.Width = 70;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Código";
            this.clmCode.Name = "clmCode";
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Película";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.Width = 70;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.Width = 45;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.Width = 50;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.Width = 45;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso Neto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.Width = 60;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.Width = 150;
            // 
            // clmSaleOrder
            // 
            this.clmSaleOrder.HeaderText = "Orden de Venta";
            this.clmSaleOrder.Name = "clmSaleOrder";
            this.clmSaleOrder.Width = 60;
            // 
            // clmOrigin
            // 
            this.clmOrigin.HeaderText = "Procedencia";
            this.clmOrigin.Name = "clmOrigin";
            this.clmOrigin.Visible = false;
            // 
            // clmQualification
            // 
            this.clmQualification.HeaderText = "Calificación";
            this.clmQualification.Name = "clmQualification";
            this.clmQualification.Visible = false;
            this.clmQualification.Width = 80;
            // 
            // clmLocation
            // 
            this.clmLocation.HeaderText = "Ubicación";
            this.clmLocation.Name = "clmLocation";
            this.clmLocation.Width = 70;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.Width = 70;
            // 
            // clmCheck
            // 
            this.clmCheck.HeaderText = "";
            this.clmCheck.Name = "clmCheck";
            this.clmCheck.Width = 60;
            // 
            // frmDepositListPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 500);
            this.Controls.Add(this.btnExportPL);
            this.Controls.Add(this.btnPreshippingPL);
            this.Controls.Add(this.chkSelectAllPL);
            this.Controls.Add(this.txtTotalNetWeightPL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepositListPL";
            this.Text = "Listado de Depósito Pilar";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositListPL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalNetWeightPL;
        private System.Windows.Forms.CheckBox chkSelectAllPL;
        private System.Windows.Forms.Button btnPreshippingPL;
        private System.Windows.Forms.Button btnExportPL;
        private System.Windows.Forms.DataGridView dgvDepositListPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchaseOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmCheck;
    }
}