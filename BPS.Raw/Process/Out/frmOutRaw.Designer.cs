namespace BPS.Raw.Process.Out
{
    partial class frmOutRaw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutRaw));
            this.tbcMovements = new System.Windows.Forms.TabControl();
            this.tbpPallets = new System.Windows.Forms.TabPage();
            this.grpbPaletInfo = new System.Windows.Forms.GroupBox();
            this.dgvPallets = new System.Windows.Forms.DataGridView();
            this.grpbPalletCode = new System.Windows.Forms.GroupBox();
            this.txtPalletCode = new System.Windows.Forms.TextBox();
            this.lblPalletCode = new System.Windows.Forms.Label();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.clmPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletTypeProductMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletMPCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.tbcMovements.SuspendLayout();
            this.tbpPallets.SuspendLayout();
            this.grpbPaletInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).BeginInit();
            this.grpbPalletCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMovements
            // 
            this.tbcMovements.Controls.Add(this.tbpPallets);
            this.tbcMovements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMovements.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcMovements.ImageList = this.imgLstIcons;
            this.tbcMovements.Location = new System.Drawing.Point(0, 0);
            this.tbcMovements.Name = "tbcMovements";
            this.tbcMovements.SelectedIndex = 0;
            this.tbcMovements.Size = new System.Drawing.Size(1171, 558);
            this.tbcMovements.TabIndex = 0;
            // 
            // tbpPallets
            // 
            this.tbpPallets.Controls.Add(this.grpbPaletInfo);
            this.tbpPallets.Controls.Add(this.grpbPalletCode);
            this.tbpPallets.Location = new System.Drawing.Point(4, 34);
            this.tbpPallets.Name = "tbpPallets";
            this.tbpPallets.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPallets.Size = new System.Drawing.Size(1163, 520);
            this.tbpPallets.TabIndex = 1;
            this.tbpPallets.Text = "Pallets";
            this.tbpPallets.UseVisualStyleBackColor = true;
            // 
            // grpbPaletInfo
            // 
            this.grpbPaletInfo.Controls.Add(this.dgvPallets);
            this.grpbPaletInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPaletInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPaletInfo.Location = new System.Drawing.Point(3, 77);
            this.grpbPaletInfo.Name = "grpbPaletInfo";
            this.grpbPaletInfo.Size = new System.Drawing.Size(1157, 440);
            this.grpbPaletInfo.TabIndex = 2;
            this.grpbPaletInfo.TabStop = false;
            // 
            // dgvPallets
            // 
            this.dgvPallets.AllowUserToAddRows = false;
            this.dgvPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPalletCodsec,
            this.clmnumber,
            this.clmPalletCode,
            this.clmPalletTypeProductMP,
            this.clmPalletMPCode,
            this.clmPalletLotNumber,
            this.clmPalletNetWeight,
            this.clmPalletGrossWeight,
            this.clmPalletStatus});
            this.dgvPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPallets.Location = new System.Drawing.Point(3, 26);
            this.dgvPallets.Name = "dgvPallets";
            this.dgvPallets.ReadOnly = true;
            this.dgvPallets.Size = new System.Drawing.Size(1151, 411);
            this.dgvPallets.TabIndex = 11;
            this.dgvPallets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPallets_CellClick);
            // 
            // grpbPalletCode
            // 
            this.grpbPalletCode.Controls.Add(this.txtPalletCode);
            this.grpbPalletCode.Controls.Add(this.lblPalletCode);
            this.grpbPalletCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbPalletCode.Location = new System.Drawing.Point(3, 3);
            this.grpbPalletCode.Name = "grpbPalletCode";
            this.grpbPalletCode.Size = new System.Drawing.Size(1157, 74);
            this.grpbPalletCode.TabIndex = 0;
            this.grpbPalletCode.TabStop = false;
            // 
            // txtPalletCode
            // 
            this.txtPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalletCode.Location = new System.Drawing.Point(340, 19);
            this.txtPalletCode.Name = "txtPalletCode";
            this.txtPalletCode.Size = new System.Drawing.Size(750, 45);
            this.txtPalletCode.TabIndex = 1;
            this.txtPalletCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPalletCode_KeyDown);
            // 
            // lblPalletCode
            // 
            this.lblPalletCode.AutoSize = true;
            this.lblPalletCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalletCode.Location = new System.Drawing.Point(66, 22);
            this.lblPalletCode.Name = "lblPalletCode";
            this.lblPalletCode.Size = new System.Drawing.Size(268, 39);
            this.lblPalletCode.TabIndex = 0;
            this.lblPalletCode.Text = "Código de Pallet";
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "incomming arrow.png");
            this.imgLstIcons.Images.SetKeyName(1, "outgoing arrow.png");
            this.imgLstIcons.Images.SetKeyName(2, "arrow-incoming.png");
            this.imgLstIcons.Images.SetKeyName(3, "arrow_redo.png");
            this.imgLstIcons.Images.SetKeyName(4, "metallized2.png");
            this.imgLstIcons.Images.SetKeyName(5, "building.png");
            // 
            // clmPalletCodsec
            // 
            this.clmPalletCodsec.HeaderText = "";
            this.clmPalletCodsec.Name = "clmPalletCodsec";
            this.clmPalletCodsec.ReadOnly = true;
            this.clmPalletCodsec.Visible = false;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Nro.";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            this.clmnumber.Width = 60;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Código";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            this.clmPalletCode.Width = 180;
            // 
            // clmPalletTypeProductMP
            // 
            this.clmPalletTypeProductMP.HeaderText = "Tipo MP";
            this.clmPalletTypeProductMP.Name = "clmPalletTypeProductMP";
            this.clmPalletTypeProductMP.ReadOnly = true;
            this.clmPalletTypeProductMP.Width = 200;
            // 
            // clmPalletMPCode
            // 
            this.clmPalletMPCode.HeaderText = "MP";
            this.clmPalletMPCode.Name = "clmPalletMPCode";
            this.clmPalletMPCode.ReadOnly = true;
            this.clmPalletMPCode.Width = 180;
            // 
            // clmPalletLotNumber
            // 
            this.clmPalletLotNumber.HeaderText = "Lote";
            this.clmPalletLotNumber.Name = "clmPalletLotNumber";
            this.clmPalletLotNumber.ReadOnly = true;
            this.clmPalletLotNumber.Width = 150;
            // 
            // clmPalletNetWeight
            // 
            this.clmPalletNetWeight.HeaderText = "P. neto";
            this.clmPalletNetWeight.Name = "clmPalletNetWeight";
            this.clmPalletNetWeight.ReadOnly = true;
            this.clmPalletNetWeight.Width = 150;
            // 
            // clmPalletGrossWeight
            // 
            this.clmPalletGrossWeight.HeaderText = "P. bruto";
            this.clmPalletGrossWeight.Name = "clmPalletGrossWeight";
            this.clmPalletGrossWeight.ReadOnly = true;
            this.clmPalletGrossWeight.Width = 150;
            // 
            // clmPalletStatus
            // 
            this.clmPalletStatus.HeaderText = "";
            this.clmPalletStatus.Name = "clmPalletStatus";
            this.clmPalletStatus.ReadOnly = true;
            this.clmPalletStatus.Width = 30;
            // 
            // frmOutRaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1171, 558);
            this.Controls.Add(this.tbcMovements);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOutRaw";
            this.ShowInTaskbar = false;
            this.Text = "Movimientos de bodega";
            this.tbcMovements.ResumeLayout(false);
            this.tbpPallets.ResumeLayout(false);
            this.grpbPaletInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPallets)).EndInit();
            this.grpbPalletCode.ResumeLayout(false);
            this.grpbPalletCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMovements;
        private System.Windows.Forms.TabPage tbpPallets;
        private System.Windows.Forms.GroupBox grpbPaletInfo;
        private System.Windows.Forms.GroupBox grpbPalletCode;
        private System.Windows.Forms.TextBox txtPalletCode;
        private System.Windows.Forms.Label lblPalletCode;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.DataGridView dgvPallets;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletTypeProductMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletMPCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletGrossWeight;
        private System.Windows.Forms.DataGridViewImageColumn clmPalletStatus;


    }
}