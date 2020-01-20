namespace BPS
{
    partial class frmPalletPreShippingPL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletPreShippingPL));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnExitPL = new System.Windows.Forms.Button();
            this.btnAddPL = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTotalPalletKGPL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPalletPL = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumbersalesorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumberpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcoilnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImgToShipp = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPreShippingPL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.dtpProgrammedDatePL = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSalesOrderPL = new System.Windows.Forms.ComboBox();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblnumberpreshipping = new System.Windows.Forms.Label();
            this.clmImgToPalletsList = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmFKSalesOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodsecshipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodeshipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproductshipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsalesordershipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigthshipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeightShipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPositionShipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgdeleteshipping = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletPL)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreShippingPL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1115, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordenes de Venta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dgvPalletPL);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(2, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1117, 451);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listado de Pallets";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnExitPL);
            this.groupBox5.Controls.Add(this.btnAddPL);
            this.groupBox5.Location = new System.Drawing.Point(1052, 398);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(58, 39);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnExitPL
            // 
            this.btnExitPL.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnExitPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExitPL.Location = new System.Drawing.Point(31, 10);
            this.btnExitPL.Name = "btnExitPL";
            this.btnExitPL.Size = new System.Drawing.Size(25, 25);
            this.btnExitPL.TabIndex = 6;
            this.btnExitPL.UseVisualStyleBackColor = true;
            this.btnExitPL.Click += new System.EventHandler(this.btnExitPL_Click);
            // 
            // btnAddPL
            // 
            this.btnAddPL.BackgroundImage = global::BPS.Properties.Resources.rewind;
            this.btnAddPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPL.Location = new System.Drawing.Point(4, 10);
            this.btnAddPL.Name = "btnAddPL";
            this.btnAddPL.Size = new System.Drawing.Size(25, 25);
            this.btnAddPL.TabIndex = 5;
            this.btnAddPL.UseVisualStyleBackColor = true;
            this.btnAddPL.Click += new System.EventHandler(this.btnAddPL_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTotalPalletKGPL);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(657, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 39);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // txtTotalPalletKGPL
            // 
            this.txtTotalPalletKGPL.Location = new System.Drawing.Point(46, 13);
            this.txtTotalPalletKGPL.Name = "txtTotalPalletKGPL";
            this.txtTotalPalletKGPL.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPalletKGPL.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total:";
            // 
            // dgvPalletPL
            // 
            this.dgvPalletPL.AllowUserToAddRows = false;
            this.dgvPalletPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletPL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmcode,
            this.clmproduct,
            this.clmnumbersalesorder,
            this.clmnumberpallet,
            this.clmcoilnumber,
            this.clmnetweigth,
            this.clmGrossWeight,
            this.clmPosition,
            this.clmImgToShipp});
            this.dgvPalletPL.Location = new System.Drawing.Point(1, 17);
            this.dgvPalletPL.Name = "dgvPalletPL";
            this.dgvPalletPL.Size = new System.Drawing.Size(649, 428);
            this.dgvPalletPL.TabIndex = 2;
            this.dgvPalletPL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletPL_CellContentClick_1);
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.Visible = false;
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Pallet";
            this.clmcode.Name = "clmcode";
            // 
            // clmproduct
            // 
            this.clmproduct.HeaderText = "Producto";
            this.clmproduct.Name = "clmproduct";
            // 
            // clmnumbersalesorder
            // 
            this.clmnumbersalesorder.HeaderText = "Orden";
            this.clmnumbersalesorder.Name = "clmnumbersalesorder";
            // 
            // clmnumberpallet
            // 
            this.clmnumberpallet.HeaderText = "Nro. Pallet";
            this.clmnumberpallet.Name = "clmnumberpallet";
            this.clmnumberpallet.Visible = false;
            // 
            // clmcoilnumber
            // 
            this.clmcoilnumber.HeaderText = "Nro. Bobinas";
            this.clmcoilnumber.Name = "clmcoilnumber";
            this.clmcoilnumber.Visible = false;
            // 
            // clmnetweigth
            // 
            this.clmnetweigth.HeaderText = "P. Neto";
            this.clmnetweigth.Name = "clmnetweigth";
            // 
            // clmGrossWeight
            // 
            this.clmGrossWeight.HeaderText = "P. Bruto";
            this.clmGrossWeight.Name = "clmGrossWeight";
            this.clmGrossWeight.Visible = false;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Ubicación";
            this.clmPosition.Name = "clmPosition";
            // 
            // clmImgToShipp
            // 
            this.clmImgToShipp.HeaderText = "";
            this.clmImgToShipp.Name = "clmImgToShipp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPreShippingPL);
            this.groupBox3.Location = new System.Drawing.Point(657, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 391);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // dgvPreShippingPL
            // 
            this.dgvPreShippingPL.AllowUserToAddRows = false;
            this.dgvPreShippingPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreShippingPL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmImgToPalletsList,
            this.clmFKSalesOrderDetail,
            this.clmcodsecshipping,
            this.clmcodeshipping,
            this.clmproductshipping,
            this.clmsalesordershipping,
            this.clmnetweigthshipping,
            this.clmGrossWeightShipping,
            this.clmPositionShipping,
            this.imgdeleteshipping});
            this.dgvPreShippingPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPreShippingPL.Location = new System.Drawing.Point(3, 16);
            this.dgvPreShippingPL.Name = "dgvPreShippingPL";
            this.dgvPreShippingPL.Size = new System.Drawing.Size(447, 372);
            this.dgvPreShippingPL.TabIndex = 0;
            this.dgvPreShippingPL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreShippingPL_CellClick);
            this.dgvPreShippingPL.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPreShippingPL_CellContentClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.dtpProgrammedDatePL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSalesOrderPL);
            this.groupBox1.Controls.Add(this.lblSalesOrder);
            this.groupBox1.Controls.Add(this.lblnumberpreshipping);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1117, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden de venta";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(677, 20);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 13);
            this.lblNumber.TabIndex = 9;
            // 
            // dtpProgrammedDatePL
            // 
            this.dtpProgrammedDatePL.Location = new System.Drawing.Point(826, 39);
            this.dtpProgrammedDatePL.Name = "dtpProgrammedDatePL";
            this.dtpProgrammedDatePL.Size = new System.Drawing.Size(252, 20);
            this.dtpProgrammedDatePL.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(705, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Programada:";
            // 
            // cmbSalesOrderPL
            // 
            this.cmbSalesOrderPL.FormattingEnabled = true;
            this.cmbSalesOrderPL.Location = new System.Drawing.Point(106, 42);
            this.cmbSalesOrderPL.Name = "cmbSalesOrderPL";
            this.cmbSalesOrderPL.Size = new System.Drawing.Size(433, 21);
            this.cmbSalesOrderPL.TabIndex = 5;
            this.cmbSalesOrderPL.SelectedIndexChanged += new System.EventHandler(this.cmbSalesOrderPL_SelectedIndexChanged_1);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Location = new System.Drawing.Point(6, 45);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(94, 13);
            this.lblSalesOrder.TabIndex = 4;
            this.lblSalesOrder.Text = "Número de Order :";
            // 
            // lblnumberpreshipping
            // 
            this.lblnumberpreshipping.AutoSize = true;
            this.lblnumberpreshipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberpreshipping.Location = new System.Drawing.Point(435, 16);
            this.lblnumberpreshipping.Name = "lblnumberpreshipping";
            this.lblnumberpreshipping.Size = new System.Drawing.Size(235, 20);
            this.lblnumberpreshipping.TabIndex = 3;
            this.lblnumberpreshipping.Text = "Número de Pre - Despacho :";
            // 
            // clmImgToPalletsList
            // 
            this.clmImgToPalletsList.HeaderText = "";
            this.clmImgToPalletsList.Image = global::BPS.Properties.Resources.cross;
            this.clmImgToPalletsList.Name = "clmImgToPalletsList";
            this.clmImgToPalletsList.Width = 40;
            // 
            // clmFKSalesOrderDetail
            // 
            this.clmFKSalesOrderDetail.HeaderText = "";
            this.clmFKSalesOrderDetail.Name = "clmFKSalesOrderDetail";
            this.clmFKSalesOrderDetail.Visible = false;
            // 
            // clmcodsecshipping
            // 
            this.clmcodsecshipping.HeaderText = "codsec";
            this.clmcodsecshipping.Name = "clmcodsecshipping";
            this.clmcodsecshipping.Visible = false;
            // 
            // clmcodeshipping
            // 
            this.clmcodeshipping.HeaderText = "Pallet";
            this.clmcodeshipping.Name = "clmcodeshipping";
            this.clmcodeshipping.Width = 80;
            // 
            // clmproductshipping
            // 
            this.clmproductshipping.HeaderText = "Producto";
            this.clmproductshipping.Name = "clmproductshipping";
            this.clmproductshipping.Width = 60;
            // 
            // clmsalesordershipping
            // 
            this.clmsalesordershipping.HeaderText = "Orden";
            this.clmsalesordershipping.Name = "clmsalesordershipping";
            this.clmsalesordershipping.Width = 55;
            // 
            // clmnetweigthshipping
            // 
            this.clmnetweigthshipping.HeaderText = "P. Neto";
            this.clmnetweigthshipping.Name = "clmnetweigthshipping";
            this.clmnetweigthshipping.Width = 50;
            // 
            // clmGrossWeightShipping
            // 
            this.clmGrossWeightShipping.HeaderText = "P. Bruto";
            this.clmGrossWeightShipping.Name = "clmGrossWeightShipping";
            this.clmGrossWeightShipping.Visible = false;
            this.clmGrossWeightShipping.Width = 60;
            // 
            // clmPositionShipping
            // 
            this.clmPositionShipping.HeaderText = "Ubicación";
            this.clmPositionShipping.Name = "clmPositionShipping";
            this.clmPositionShipping.Width = 70;
            // 
            // imgdeleteshipping
            // 
            this.imgdeleteshipping.HeaderText = "";
            this.imgdeleteshipping.Image = global::BPS.Properties.Resources.action_delete_sharp_thin;
            this.imgdeleteshipping.Name = "imgdeleteshipping";
            this.imgdeleteshipping.Width = 40;
            // 
            // frmPalletPreShippingPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 558);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletPreShippingPL";
            this.Text = "Pallets Para Despacho Pilar";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletPL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreShippingPL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnumberpreshipping;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.ComboBox cmbSalesOrderPL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpProgrammedDatePL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvPreShippingPL;
        private System.Windows.Forms.DataGridView dgvPalletPL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalPalletKGPL;
        private System.Windows.Forms.Button btnExitPL;
        private System.Windows.Forms.Button btnAddPL;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumbersalesorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumberpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcoilnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewImageColumn clmImgToShipp;
        private System.Windows.Forms.DataGridViewImageColumn clmImgToPalletsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFKSalesOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsecshipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodeshipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproductshipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsalesordershipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigthshipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeightShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPositionShipping;
        private System.Windows.Forms.DataGridViewImageColumn imgdeleteshipping;
    }
}