namespace BPS
{
    partial class frmShippingManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingManager));
            this.tabShippingByDate = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTPFromShipping = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToShipping = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGenerateShippingByDateRp = new System.Windows.Forms.Button();
            this.tbpFullShipping = new System.Windows.Forms.TabPage();
            this.lblShippingPallet = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvPalletShipping = new System.Windows.Forms.DataGridView();
            this.clmstatusdrawingpallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmgrossweigthpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigthpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmorderpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomerpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodepallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproductpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumberpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatuspallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpPalletShippingDelivery = new System.Windows.Forms.TabPage();
            this.grpPalletList = new System.Windows.Forms.GroupBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblShipping = new System.Windows.Forms.Label();
            this.grpbPalletsList = new System.Windows.Forms.GroupBox();
            this.dgvPalletList = new System.Windows.Forms.DataGridView();
            this.clmimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.tbcShippingPalletFull = new System.Windows.Forms.TabControl();
            this.tabShippingByDate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tbpFullShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).BeginInit();
            this.tbpPalletShippingDelivery.SuspendLayout();
            this.grpPalletList.SuspendLayout();
            this.grpbPalletsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.tbcShippingPalletFull.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShippingByDate
            // 
            this.tabShippingByDate.Controls.Add(this.btnGenerateShippingByDateRp);
            this.tabShippingByDate.Controls.Add(this.groupBox4);
            this.tabShippingByDate.Controls.Add(this.groupBox3);
            this.tabShippingByDate.Controls.Add(this.groupBox2);
            this.tabShippingByDate.Controls.Add(this.groupBox1);
            this.tabShippingByDate.Location = new System.Drawing.Point(4, 24);
            this.tabShippingByDate.Name = "tabShippingByDate";
            this.tabShippingByDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabShippingByDate.Size = new System.Drawing.Size(873, 481);
            this.tabShippingByDate.TabIndex = 2;
            this.tabShippingByDate.Text = "Reporte de despachos";
            this.tabShippingByDate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 27);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desde:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dateTPFromShipping);
            this.groupBox2.Location = new System.Drawing.Point(20, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 252);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dateTPFromShipping
            // 
            this.dateTPFromShipping.Location = new System.Drawing.Point(6, 10);
            this.dateTPFromShipping.Name = "dateTPFromShipping";
            this.dateTPFromShipping.Size = new System.Drawing.Size(308, 21);
            this.dateTPFromShipping.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTPToShipping);
            this.groupBox3.Location = new System.Drawing.Point(392, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 252);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToShipping
            // 
            this.dateTPToShipping.Location = new System.Drawing.Point(0, 9);
            this.dateTPToShipping.Name = "dateTPToShipping";
            this.dateTPToShipping.Size = new System.Drawing.Size(314, 21);
            this.dateTPToShipping.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(392, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(314, 27);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasta";
            // 
            // btnGenerateShippingByDateRp
            // 
            this.btnGenerateShippingByDateRp.Location = new System.Drawing.Point(259, 339);
            this.btnGenerateShippingByDateRp.Name = "btnGenerateShippingByDateRp";
            this.btnGenerateShippingByDateRp.Size = new System.Drawing.Size(203, 63);
            this.btnGenerateShippingByDateRp.TabIndex = 4;
            this.btnGenerateShippingByDateRp.Text = "Generar";
            this.btnGenerateShippingByDateRp.UseVisualStyleBackColor = true;
            this.btnGenerateShippingByDateRp.Click += new System.EventHandler(this.btnGenerateShippingByDateRp_Click);
            // 
            // tbpFullShipping
            // 
            this.tbpFullShipping.Controls.Add(this.dgvPalletShipping);
            this.tbpFullShipping.Controls.Add(this.lblDate);
            this.tbpFullShipping.Controls.Add(this.lblShippingPallet);
            this.tbpFullShipping.Location = new System.Drawing.Point(4, 24);
            this.tbpFullShipping.Name = "tbpFullShipping";
            this.tbpFullShipping.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFullShipping.Size = new System.Drawing.Size(873, 481);
            this.tbpFullShipping.TabIndex = 1;
            this.tbpFullShipping.Text = "Pallet despachados";
            this.tbpFullShipping.UseVisualStyleBackColor = true;
            // 
            // lblShippingPallet
            // 
            this.lblShippingPallet.AutoSize = true;
            this.lblShippingPallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingPallet.Location = new System.Drawing.Point(265, 13);
            this.lblShippingPallet.Name = "lblShippingPallet";
            this.lblShippingPallet.Size = new System.Drawing.Size(217, 29);
            this.lblShippingPallet.TabIndex = 0;
            this.lblShippingPallet.Text = "Despacho Pallets";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(488, 13);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 29);
            this.lblDate.TabIndex = 1;
            // 
            // dgvPalletShipping
            // 
            this.dgvPalletShipping.AllowUserToAddRows = false;
            this.dgvPalletShipping.AllowUserToDeleteRows = false;
            this.dgvPalletShipping.AllowUserToOrderColumns = true;
            this.dgvPalletShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletShipping.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmstatuspallet,
            this.clmnumberpallet,
            this.clmproductpallet,
            this.clmcodepallet,
            this.clmcustomerpallet,
            this.clmorderpallet,
            this.clmnetweigthpallet,
            this.clmgrossweigthpallet,
            this.clmstatusdrawingpallet});
            this.dgvPalletShipping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletShipping.Location = new System.Drawing.Point(3, 3);
            this.dgvPalletShipping.Name = "dgvPalletShipping";
            this.dgvPalletShipping.ReadOnly = true;
            this.dgvPalletShipping.Size = new System.Drawing.Size(867, 475);
            this.dgvPalletShipping.TabIndex = 2;
            // 
            // clmstatusdrawingpallet
            // 
            this.clmstatusdrawingpallet.HeaderText = "";
            this.clmstatusdrawingpallet.Name = "clmstatusdrawingpallet";
            this.clmstatusdrawingpallet.ReadOnly = true;
            this.clmstatusdrawingpallet.Width = 30;
            // 
            // clmgrossweigthpallet
            // 
            this.clmgrossweigthpallet.HeaderText = "P. Bruto";
            this.clmgrossweigthpallet.Name = "clmgrossweigthpallet";
            this.clmgrossweigthpallet.ReadOnly = true;
            this.clmgrossweigthpallet.Width = 80;
            // 
            // clmnetweigthpallet
            // 
            this.clmnetweigthpallet.HeaderText = "P. Neto";
            this.clmnetweigthpallet.Name = "clmnetweigthpallet";
            this.clmnetweigthpallet.ReadOnly = true;
            this.clmnetweigthpallet.Width = 80;
            // 
            // clmorderpallet
            // 
            this.clmorderpallet.HeaderText = "Orden";
            this.clmorderpallet.Name = "clmorderpallet";
            this.clmorderpallet.ReadOnly = true;
            // 
            // clmcustomerpallet
            // 
            this.clmcustomerpallet.HeaderText = "Cliente";
            this.clmcustomerpallet.Name = "clmcustomerpallet";
            this.clmcustomerpallet.ReadOnly = true;
            this.clmcustomerpallet.Width = 160;
            // 
            // clmcodepallet
            // 
            this.clmcodepallet.HeaderText = "Pallet";
            this.clmcodepallet.Name = "clmcodepallet";
            this.clmcodepallet.ReadOnly = true;
            this.clmcodepallet.Width = 160;
            // 
            // clmproductpallet
            // 
            this.clmproductpallet.HeaderText = "Producto";
            this.clmproductpallet.Name = "clmproductpallet";
            this.clmproductpallet.ReadOnly = true;
            this.clmproductpallet.Width = 160;
            // 
            // clmnumberpallet
            // 
            this.clmnumberpallet.HeaderText = "Nro.";
            this.clmnumberpallet.Name = "clmnumberpallet";
            this.clmnumberpallet.ReadOnly = true;
            this.clmnumberpallet.Width = 50;
            // 
            // clmstatuspallet
            // 
            this.clmstatuspallet.HeaderText = "";
            this.clmstatuspallet.Name = "clmstatuspallet";
            this.clmstatuspallet.ReadOnly = true;
            this.clmstatuspallet.Visible = false;
            // 
            // tbpPalletShippingDelivery
            // 
            this.tbpPalletShippingDelivery.Controls.Add(this.btnNew);
            this.tbpPalletShippingDelivery.Controls.Add(this.txtPalletCode);
            this.tbpPalletShippingDelivery.Controls.Add(this.lblPalletCode);
            this.tbpPalletShippingDelivery.Controls.Add(this.grpbPalletsList);
            this.tbpPalletShippingDelivery.Controls.Add(this.grpPalletList);
            this.tbpPalletShippingDelivery.Location = new System.Drawing.Point(4, 24);
            this.tbpPalletShippingDelivery.Name = "tbpPalletShippingDelivery";
            this.tbpPalletShippingDelivery.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPalletShippingDelivery.Size = new System.Drawing.Size(873, 481);
            this.tbpPalletShippingDelivery.TabIndex = 0;
            this.tbpPalletShippingDelivery.Text = "Pallets para despachos";
            this.tbpPalletShippingDelivery.UseVisualStyleBackColor = true;
            // 
            // grpPalletList
            // 
            this.grpPalletList.Controls.Add(this.lblShipping);
            this.grpPalletList.Controls.Add(this.btnProcess);
            this.grpPalletList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpPalletList.Location = new System.Drawing.Point(3, 415);
            this.grpPalletList.Name = "grpPalletList";
            this.grpPalletList.Size = new System.Drawing.Size(867, 63);
            this.grpPalletList.TabIndex = 3;
            this.grpPalletList.TabStop = false;
            // 
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Lite.Properties.Resources.send;
            this.btnProcess.Location = new System.Drawing.Point(818, 13);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(40, 40);
            this.btnProcess.TabIndex = 21;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.Location = new System.Drawing.Point(687, 19);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(125, 25);
            this.lblShipping.TabIndex = 22;
            this.lblShipping.Text = "Despachar";
            // 
            // grpbPalletsList
            // 
            this.grpbPalletsList.Controls.Add(this.dgvPalletList);
            this.grpbPalletsList.Location = new System.Drawing.Point(3, 53);
            this.grpbPalletsList.Name = "grpbPalletsList";
            this.grpbPalletsList.Size = new System.Drawing.Size(867, 365);
            this.grpbPalletsList.TabIndex = 23;
            this.grpbPalletsList.TabStop = false;
            this.grpbPalletsList.Text = "Listado Pallets";
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.AllowUserToAddRows = false;
            this.dgvPalletList.AllowUserToDeleteRows = false;
            this.dgvPalletList.AllowUserToOrderColumns = true;
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnumber,
            this.clmCode,
            this.clmStatus,
            this.clmimage});
            this.dgvPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletList.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.ReadOnly = true;
            this.dgvPalletList.Size = new System.Drawing.Size(861, 345);
            this.dgvPalletList.TabIndex = 0;
            this.dgvPalletList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletList_CellClick);
            // 
            // clmimage
            // 
            this.clmimage.HeaderText = "";
            this.clmimage.Name = "clmimage";
            this.clmimage.ReadOnly = true;
            this.clmimage.Width = 30;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 250;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(219, 20);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(67, 25);
            this.lblPalletCode.TabIndex = 21;
            this.lblPalletCode.Text = "Orden";
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalletCode.Location = new System.Drawing.Point(292, 17);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(450, 30);
            this.txtPalletCode.TabIndex = 22;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::BPS.Lite.Properties.Resources.page;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.Location = new System.Drawing.Point(836, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(25, 25);
            this.btnNew.TabIndex = 31;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // tbcShippingPalletFull
            // 
            this.tbcShippingPalletFull.Controls.Add(this.tbpPalletShippingDelivery);
            this.tbcShippingPalletFull.Controls.Add(this.tbpFullShipping);
            this.tbcShippingPalletFull.Controls.Add(this.tabShippingByDate);
            this.tbcShippingPalletFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcShippingPalletFull.Location = new System.Drawing.Point(0, 0);
            this.tbcShippingPalletFull.Name = "tbcShippingPalletFull";
            this.tbcShippingPalletFull.SelectedIndex = 0;
            this.tbcShippingPalletFull.Size = new System.Drawing.Size(881, 509);
            this.tbcShippingPalletFull.TabIndex = 0;
            // 
            // frmShippingManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(881, 509);
            this.Controls.Add(this.tbcShippingPalletFull);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShippingManager";
            this.Text = "Despacho pallet Nacional";
            this.Load += new System.EventHandler(this.frmShippingManager_Load);
            this.tabShippingByDate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tbpFullShipping.ResumeLayout(false);
            this.tbpFullShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).EndInit();
            this.tbpPalletShippingDelivery.ResumeLayout(false);
            this.tbpPalletShippingDelivery.PerformLayout();
            this.grpPalletList.ResumeLayout(false);
            this.grpPalletList.PerformLayout();
            this.grpbPalletsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.tbcShippingPalletFull.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabShippingByDate;
        private System.Windows.Forms.Button btnGenerateShippingByDateRp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTPToShipping;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTPFromShipping;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tbpFullShipping;
        private System.Windows.Forms.DataGridView dgvPalletShipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatuspallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumberpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmproductpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodepallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcustomerpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmorderpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigthpallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmgrossweigthpallet;
        private System.Windows.Forms.DataGridViewImageColumn clmstatusdrawingpallet;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShippingPallet;
        private System.Windows.Forms.TabPage tbpPalletShippingDelivery;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.GroupBox grpbPalletsList;
        private System.Windows.Forms.DataGridView dgvPalletList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmimage;
        private System.Windows.Forms.GroupBox grpPalletList;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TabControl tbcShippingPalletFull;


    }
}