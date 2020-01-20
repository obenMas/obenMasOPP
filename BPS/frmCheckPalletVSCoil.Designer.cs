namespace BPS
{
    partial class frmCheckPalletVSCoil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckPalletVSCoil));
            this.grpbReceptionInfo = new System.Windows.Forms.GroupBox();
            this.lblPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.lblPalletCodeLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCoil = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceptionPackageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcoilnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPalletnet = new System.Windows.Forms.Label();
            this.lblPalletnetLabel = new System.Windows.Forms.Label();
            this.lblCoil = new System.Windows.Forms.Label();
            this.lblcoilLabel = new System.Windows.Forms.Label();
            this.grpbReceptionInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoil)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbReceptionInfo
            // 
            this.grpbReceptionInfo.Controls.Add(this.lblPurchaseOrderNumber);
            this.grpbReceptionInfo.Controls.Add(this.lblPalletCodeLabel);
            this.grpbReceptionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbReceptionInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbReceptionInfo.Name = "grpbReceptionInfo";
            this.grpbReceptionInfo.Size = new System.Drawing.Size(323, 47);
            this.grpbReceptionInfo.TabIndex = 0;
            this.grpbReceptionInfo.TabStop = false;
            // 
            // lblPurchaseOrderNumber
            // 
            this.lblPurchaseOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurchaseOrderNumber.Location = new System.Drawing.Point(48, 13);
            this.lblPurchaseOrderNumber.Name = "lblPurchaseOrderNumber";
            this.lblPurchaseOrderNumber.Size = new System.Drawing.Size(263, 21);
            this.lblPurchaseOrderNumber.TabIndex = 1;
            this.lblPurchaseOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPalletCodeLabel
            // 
            this.lblPalletCodeLabel.AutoSize = true;
            this.lblPalletCodeLabel.Location = new System.Drawing.Point(4, 16);
            this.lblPalletCodeLabel.Name = "lblPalletCodeLabel";
            this.lblPalletCodeLabel.Size = new System.Drawing.Size(38, 15);
            this.lblPalletCodeLabel.TabIndex = 0;
            this.lblPalletCodeLabel.Text = "Pallet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCoil);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dgvCoil
            // 
            this.dgvCoil.AllowUserToAddRows = false;
            this.dgvCoil.AllowUserToDeleteRows = false;
            this.dgvCoil.AllowUserToOrderColumns = true;
            this.dgvCoil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmReceptionPackageCode,
            this.clmcoilnet});
            this.dgvCoil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoil.Location = new System.Drawing.Point(3, 17);
            this.dgvCoil.Name = "dgvCoil";
            this.dgvCoil.RowHeadersWidth = 10;
            this.dgvCoil.Size = new System.Drawing.Size(317, 286);
            this.dgvCoil.TabIndex = 1;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmReceptionPackageCode
            // 
            this.clmReceptionPackageCode.HeaderText = "Código";
            this.clmReceptionPackageCode.Name = "clmReceptionPackageCode";
            // 
            // clmcoilnet
            // 
            this.clmcoilnet.HeaderText = "Peso";
            this.clmcoilnet.Name = "clmcoilnet";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCoil);
            this.groupBox2.Controls.Add(this.lblcoilLabel);
            this.groupBox2.Controls.Add(this.lblPalletnet);
            this.groupBox2.Controls.Add(this.lblPalletnetLabel);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblPalletnet
            // 
            this.lblPalletnet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPalletnet.Location = new System.Drawing.Point(48, 16);
            this.lblPalletnet.Name = "lblPalletnet";
            this.lblPalletnet.Size = new System.Drawing.Size(104, 21);
            this.lblPalletnet.TabIndex = 3;
            this.lblPalletnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPalletnetLabel
            // 
            this.lblPalletnetLabel.AutoSize = true;
            this.lblPalletnetLabel.Location = new System.Drawing.Point(4, 19);
            this.lblPalletnetLabel.Name = "lblPalletnetLabel";
            this.lblPalletnetLabel.Size = new System.Drawing.Size(38, 15);
            this.lblPalletnetLabel.TabIndex = 2;
            this.lblPalletnetLabel.Text = "Pallet";
            // 
            // lblCoil
            // 
            this.lblCoil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCoil.Location = new System.Drawing.Point(207, 16);
            this.lblCoil.Name = "lblCoil";
            this.lblCoil.Size = new System.Drawing.Size(104, 21);
            this.lblCoil.TabIndex = 5;
            this.lblCoil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcoilLabel
            // 
            this.lblcoilLabel.AutoSize = true;
            this.lblcoilLabel.Location = new System.Drawing.Point(158, 19);
            this.lblcoilLabel.Name = "lblcoilLabel";
            this.lblcoilLabel.Size = new System.Drawing.Size(46, 15);
            this.lblcoilLabel.TabIndex = 4;
            this.lblcoilLabel.Text = "Bobina";
            // 
            // frmCheckPalletVSCoil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(323, 399);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbReceptionInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCheckPalletVSCoil";
            this.Text = "Pallet VS Bobinas";
            this.Load += new System.EventHandler(this.frmCheckPalletVSCoil_Load_1);
            this.grpbReceptionInfo.ResumeLayout(false);
            this.grpbReceptionInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoil)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbReceptionInfo;
        private System.Windows.Forms.Label lblPurchaseOrderNumber;
        private System.Windows.Forms.Label lblPalletCodeLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceptionPackageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcoilnet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCoil;
        private System.Windows.Forms.Label lblcoilLabel;
        private System.Windows.Forms.Label lblPalletnet;
        private System.Windows.Forms.Label lblPalletnetLabel;
    }
}