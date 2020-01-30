namespace BPS
{
    partial class frmDepositList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepositList));
            this.tbcDepositList = new System.Windows.Forms.TabControl();
            this.tbcCampana = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtTotalNetWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreshipping = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDepositList = new System.Windows.Forms.DataGridView();
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
            this.tbcDepositList.SuspendLayout();
            this.tbcCampana.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcDepositList
            // 
            this.tbcDepositList.Controls.Add(this.tbcCampana);
            this.tbcDepositList.Location = new System.Drawing.Point(2, 1);
            this.tbcDepositList.Name = "tbcDepositList";
            this.tbcDepositList.SelectedIndex = 0;
            this.tbcDepositList.Size = new System.Drawing.Size(1124, 516);
            this.tbcDepositList.TabIndex = 0;
            // 
            // tbcCampana
            // 
            this.tbcCampana.Controls.Add(this.label3);
            this.tbcCampana.Controls.Add(this.panel1);
            this.tbcCampana.Controls.Add(this.btnExport);
            this.tbcCampana.Controls.Add(this.txtTotalNetWeight);
            this.tbcCampana.Controls.Add(this.label2);
            this.tbcCampana.Controls.Add(this.chkSelectAll);
            this.tbcCampana.Controls.Add(this.label1);
            this.tbcCampana.Controls.Add(this.btnPreshipping);
            this.tbcCampana.Controls.Add(this.groupBox1);
            this.tbcCampana.Location = new System.Drawing.Point(4, 22);
            this.tbcCampana.Name = "tbcCampana";
            this.tbcCampana.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCampana.Size = new System.Drawing.Size(1116, 490);
            this.tbcCampana.TabIndex = 0;
            this.tbcCampana.Text = "Pallets";
            this.tbcCampana.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "= Pallet Pre-Despachado";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(47, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 23);
            this.panel1.TabIndex = 15;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(974, 456);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 14;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // txtTotalNetWeight
            // 
            this.txtTotalNetWeight.Location = new System.Drawing.Point(732, 460);
            this.txtTotalNetWeight.Name = "txtTotalNetWeight";
            this.txtTotalNetWeight.Size = new System.Drawing.Size(133, 20);
            this.txtTotalNetWeight.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(692, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.Location = new System.Drawing.Point(938, 463);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(15, 14);
            this.chkSelectAll.TabIndex = 11;
            this.chkSelectAll.UseVisualStyleBackColor = true;
            this.chkSelectAll.CheckedChanged += new System.EventHandler(this.chkSelectAll_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selección:";
            // 
            // btnPreshipping
            // 
            this.btnPreshipping.Location = new System.Drawing.Point(1013, 456);
            this.btnPreshipping.Name = "btnPreshipping";
            this.btnPreshipping.Size = new System.Drawing.Size(99, 23);
            this.btnPreshipping.TabIndex = 9;
            this.btnPreshipping.Text = "Predespacho";
            this.btnPreshipping.UseVisualStyleBackColor = true;
            this.btnPreshipping.Click += new System.EventHandler(this.btnPreshipping_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDepositList);
            this.groupBox1.Location = new System.Drawing.Point(1, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1114, 459);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // dgvDepositList
            // 
            this.dgvDepositList.AllowUserToAddRows = false;
            this.dgvDepositList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepositList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvDepositList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDepositList.Location = new System.Drawing.Point(3, 16);
            this.dgvDepositList.Name = "dgvDepositList";
            this.dgvDepositList.Size = new System.Drawing.Size(1108, 440);
            this.dgvDepositList.TabIndex = 0;
            this.dgvDepositList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositList_CellContentClick_1);
            this.dgvDepositList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepositList_CellValueChanged_1);
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
            this.clmPrice.HeaderText = "Precio USD";
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
            // frmDepositList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 518);
            this.Controls.Add(this.tbcDepositList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepositList";
            this.Text = "Listado de Depósito";
            this.tbcDepositList.ResumeLayout(false);
            this.tbcCampana.ResumeLayout(false);
            this.tbcCampana.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepositList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDepositList;
        private System.Windows.Forms.TabPage tbcCampana;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtTotalNetWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreshipping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDepositList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
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