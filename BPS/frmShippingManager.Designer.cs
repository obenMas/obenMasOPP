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
            this.tbcShippingPalletFull = new System.Windows.Forms.TabControl();
            this.tbpPalletShippingDelivery = new System.Windows.Forms.TabPage();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.grpbPalletsList = new System.Windows.Forms.GroupBox();
            this.dgvPalletList = new System.Windows.Forms.DataGridView();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmimage = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpPalletList = new System.Windows.Forms.GroupBox();
            this.lblShipping = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tbpFullShipping = new System.Windows.Forms.TabPage();
            this.dgvPalletShipping = new System.Windows.Forms.DataGridView();
            this.clmstatuspallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumberpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmproductpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcodepallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcustomerpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmorderpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigthpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmgrossweigthpallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatusdrawingpallet = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblShippingPallet = new System.Windows.Forms.Label();
            this.tbcShippingPalletFull.SuspendLayout();
            this.tbpPalletShippingDelivery.SuspendLayout();
            this.grpbPalletsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.grpPalletList.SuspendLayout();
            this.tbpFullShipping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcShippingPalletFull
            // 
            this.tbcShippingPalletFull.Controls.Add(this.tbpPalletShippingDelivery);
            this.tbcShippingPalletFull.Controls.Add(this.tbpFullShipping);
            this.tbcShippingPalletFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcShippingPalletFull.Location = new System.Drawing.Point(0, 0);
            this.tbcShippingPalletFull.Name = "tbcShippingPalletFull";
            this.tbcShippingPalletFull.SelectedIndex = 0;
            this.tbcShippingPalletFull.Size = new System.Drawing.Size(881, 509);
            this.tbcShippingPalletFull.TabIndex = 0;
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
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::BPS.Properties.Resources.page;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.Location = new System.Drawing.Point(836, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(25, 25);
            this.btnNew.TabIndex = 31;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 250;
            // 
            // clmStatus
            // 
            this.clmStatus.HeaderText = "Estado";
            this.clmStatus.Name = "clmStatus";
            this.clmStatus.ReadOnly = true;
            // 
            // clmimage
            // 
            this.clmimage.HeaderText = "";
            this.clmimage.Name = "clmimage";
            this.clmimage.ReadOnly = true;
            this.clmimage.Width = 30;
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
            // btnProcess
            // 
            this.btnProcess.Image = global::BPS.Properties.Resources.send;
            this.btnProcess.Location = new System.Drawing.Point(818, 13);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(40, 40);
            this.btnProcess.TabIndex = 21;
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
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
            // clmstatuspallet
            // 
            this.clmstatuspallet.HeaderText = "";
            this.clmstatuspallet.Name = "clmstatuspallet";
            this.clmstatuspallet.ReadOnly = true;
            this.clmstatuspallet.Visible = false;
            // 
            // clmnumberpallet
            // 
            this.clmnumberpallet.HeaderText = "Nro.";
            this.clmnumberpallet.Name = "clmnumberpallet";
            this.clmnumberpallet.ReadOnly = true;
            this.clmnumberpallet.Width = 50;
            // 
            // clmproductpallet
            // 
            this.clmproductpallet.HeaderText = "Producto";
            this.clmproductpallet.Name = "clmproductpallet";
            this.clmproductpallet.ReadOnly = true;
            this.clmproductpallet.Width = 160;
            // 
            // clmcodepallet
            // 
            this.clmcodepallet.HeaderText = "Pallet";
            this.clmcodepallet.Name = "clmcodepallet";
            this.clmcodepallet.ReadOnly = true;
            this.clmcodepallet.Width = 160;
            // 
            // clmcustomerpallet
            // 
            this.clmcustomerpallet.HeaderText = "Cliente";
            this.clmcustomerpallet.Name = "clmcustomerpallet";
            this.clmcustomerpallet.ReadOnly = true;
            this.clmcustomerpallet.Width = 160;
            // 
            // clmorderpallet
            // 
            this.clmorderpallet.HeaderText = "Orden";
            this.clmorderpallet.Name = "clmorderpallet";
            this.clmorderpallet.ReadOnly = true;
            // 
            // clmnetweigthpallet
            // 
            this.clmnetweigthpallet.HeaderText = "P. Neto";
            this.clmnetweigthpallet.Name = "clmnetweigthpallet";
            this.clmnetweigthpallet.ReadOnly = true;
            this.clmnetweigthpallet.Width = 80;
            // 
            // clmgrossweigthpallet
            // 
            this.clmgrossweigthpallet.HeaderText = "P. Bruto";
            this.clmgrossweigthpallet.Name = "clmgrossweigthpallet";
            this.clmgrossweigthpallet.ReadOnly = true;
            this.clmgrossweigthpallet.Width = 80;
            // 
            // clmstatusdrawingpallet
            // 
            this.clmstatusdrawingpallet.HeaderText = "";
            this.clmstatusdrawingpallet.Name = "clmstatusdrawingpallet";
            this.clmstatusdrawingpallet.ReadOnly = true;
            this.clmstatusdrawingpallet.Width = 30;
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
            this.tbcShippingPalletFull.ResumeLayout(false);
            this.tbpPalletShippingDelivery.ResumeLayout(false);
            this.tbpPalletShippingDelivery.PerformLayout();
            this.grpbPalletsList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.grpPalletList.ResumeLayout(false);
            this.grpPalletList.PerformLayout();
            this.tbpFullShipping.ResumeLayout(false);
            this.tbpFullShipping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletShipping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcShippingPalletFull;
        private System.Windows.Forms.TabPage tbpPalletShippingDelivery;
        private System.Windows.Forms.TabPage tbpFullShipping;
        private System.Windows.Forms.GroupBox grpPalletList;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.GroupBox grpbPalletsList;
        private System.Windows.Forms.DataGridView dgvPalletList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStatus;
        private System.Windows.Forms.DataGridViewImageColumn clmimage;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblShippingPallet;
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
        private System.Windows.Forms.Button btnNew;

    }
}