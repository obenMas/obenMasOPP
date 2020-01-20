namespace BPS
{
    partial class frmReceptionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceptionDetail));
            this.grpbReceptionInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPurchaseOrderNumberLabel = new System.Windows.Forms.Label();
            this.lblPurchaseOrderNumber = new System.Windows.Forms.Label();
            this.lblProviderLabel = new System.Windows.Forms.Label();
            this.lblProvider = new System.Windows.Forms.Label();
            this.lblReceptionDateLabel = new System.Windows.Forms.Label();
            this.lblReceptionDate = new System.Windows.Forms.Label();
            this.dgvReception = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceptionPackageCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigthPerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAvailablePackages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbReceptionInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbReceptionInfo
            // 
            this.grpbReceptionInfo.Controls.Add(this.lblProvider);
            this.grpbReceptionInfo.Controls.Add(this.lblReceptionDate);
            this.grpbReceptionInfo.Controls.Add(this.lblPurchaseOrderNumber);
            this.grpbReceptionInfo.Controls.Add(this.lblProviderLabel);
            this.grpbReceptionInfo.Controls.Add(this.lblReceptionDateLabel);
            this.grpbReceptionInfo.Controls.Add(this.lblPurchaseOrderNumberLabel);
            this.grpbReceptionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbReceptionInfo.Location = new System.Drawing.Point(0, 0);
            this.grpbReceptionInfo.Name = "grpbReceptionInfo";
            this.grpbReceptionInfo.Size = new System.Drawing.Size(923, 53);
            this.grpbReceptionInfo.TabIndex = 0;
            this.grpbReceptionInfo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReception);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 293);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblPurchaseOrderNumberLabel
            // 
            this.lblPurchaseOrderNumberLabel.AutoSize = true;
            this.lblPurchaseOrderNumberLabel.Location = new System.Drawing.Point(4, 24);
            this.lblPurchaseOrderNumberLabel.Name = "lblPurchaseOrderNumberLabel";
            this.lblPurchaseOrderNumberLabel.Size = new System.Drawing.Size(103, 15);
            this.lblPurchaseOrderNumberLabel.TabIndex = 0;
            this.lblPurchaseOrderNumberLabel.Text = "Orden de compra";
            // 
            // lblPurchaseOrderNumber
            // 
            this.lblPurchaseOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPurchaseOrderNumber.Location = new System.Drawing.Point(115, 21);
            this.lblPurchaseOrderNumber.Name = "lblPurchaseOrderNumber";
            this.lblPurchaseOrderNumber.Size = new System.Drawing.Size(100, 21);
            this.lblPurchaseOrderNumber.TabIndex = 1;
            this.lblPurchaseOrderNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProviderLabel
            // 
            this.lblProviderLabel.AutoSize = true;
            this.lblProviderLabel.Location = new System.Drawing.Point(223, 24);
            this.lblProviderLabel.Name = "lblProviderLabel";
            this.lblProviderLabel.Size = new System.Drawing.Size(103, 15);
            this.lblProviderLabel.TabIndex = 0;
            this.lblProviderLabel.Text = "Orden de compra";
            // 
            // lblProvider
            // 
            this.lblProvider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProvider.Location = new System.Drawing.Point(334, 21);
            this.lblProvider.Name = "lblProvider";
            this.lblProvider.Size = new System.Drawing.Size(283, 21);
            this.lblProvider.TabIndex = 1;
            this.lblProvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReceptionDateLabel
            // 
            this.lblReceptionDateLabel.AutoSize = true;
            this.lblReceptionDateLabel.Location = new System.Drawing.Point(625, 21);
            this.lblReceptionDateLabel.Name = "lblReceptionDateLabel";
            this.lblReceptionDateLabel.Size = new System.Drawing.Size(41, 15);
            this.lblReceptionDateLabel.TabIndex = 0;
            this.lblReceptionDateLabel.Text = "Fecha";
            // 
            // lblReceptionDate
            // 
            this.lblReceptionDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceptionDate.Location = new System.Drawing.Point(674, 18);
            this.lblReceptionDate.Name = "lblReceptionDate";
            this.lblReceptionDate.Size = new System.Drawing.Size(166, 21);
            this.lblReceptionDate.TabIndex = 1;
            this.lblReceptionDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReception
            // 
            this.dgvReception.AllowUserToAddRows = false;
            this.dgvReception.AllowUserToDeleteRows = false;
            this.dgvReception.AllowUserToOrderColumns = true;
            this.dgvReception.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReception.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmfkRawMaterial,
            this.clmReceptionPackageCode,
            this.clmRawMaterialType,
            this.clmRawMaterialName,
            this.clmRawMaterialCode,
            this.clmQuantity,
            this.clmUnits,
            this.clmWeigthPerUnit,
            this.clmAvailablePackages,
            this.clmPrint});
            this.dgvReception.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReception.Location = new System.Drawing.Point(3, 17);
            this.dgvReception.Name = "dgvReception";
            this.dgvReception.RowHeadersWidth = 10;
            this.dgvReception.Size = new System.Drawing.Size(917, 273);
            this.dgvReception.TabIndex = 1;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmfkRawMaterial
            // 
            this.clmfkRawMaterial.HeaderText = "fkRawMaterial";
            this.clmfkRawMaterial.Name = "clmfkRawMaterial";
            this.clmfkRawMaterial.Visible = false;
            // 
            // clmReceptionPackageCode
            // 
            this.clmReceptionPackageCode.HeaderText = "Código";
            this.clmReceptionPackageCode.Name = "clmReceptionPackageCode";
            // 
            // clmRawMaterialType
            // 
            this.clmRawMaterialType.HeaderText = "Tipo M.P.";
            this.clmRawMaterialType.Name = "clmRawMaterialType";
            this.clmRawMaterialType.ReadOnly = true;
            // 
            // clmRawMaterialName
            // 
            this.clmRawMaterialName.HeaderText = "Nombre";
            this.clmRawMaterialName.Name = "clmRawMaterialName";
            this.clmRawMaterialName.ReadOnly = true;
            this.clmRawMaterialName.Width = 150;
            // 
            // clmRawMaterialCode
            // 
            this.clmRawMaterialCode.HeaderText = "Código";
            this.clmRawMaterialCode.Name = "clmRawMaterialCode";
            this.clmRawMaterialCode.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmUnits
            // 
            this.clmUnits.HeaderText = "Unidades";
            this.clmUnits.Name = "clmUnits";
            // 
            // clmWeigthPerUnit
            // 
            this.clmWeigthPerUnit.HeaderText = "Peso / Unid.";
            this.clmWeigthPerUnit.Name = "clmWeigthPerUnit";
            // 
            // clmAvailablePackages
            // 
            this.clmAvailablePackages.HeaderText = "Disponibles";
            this.clmAvailablePackages.Name = "clmAvailablePackages";
            // 
            // clmPrint
            // 
            this.clmPrint.HeaderText = "";
            this.clmPrint.Name = "clmPrint";
            this.clmPrint.ReadOnly = true;
            this.clmPrint.Width = 30;
            // 
            // frmReceptionDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(923, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbReceptionInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReceptionDetail";
            this.Text = "Detalle de recepción";
            this.Load += new System.EventHandler(this.frmReceptionDetail_Load);
            this.grpbReceptionInfo.ResumeLayout(false);
            this.grpbReceptionInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReception)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbReceptionInfo;
        private System.Windows.Forms.Label lblProvider;
        private System.Windows.Forms.Label lblReceptionDate;
        private System.Windows.Forms.Label lblPurchaseOrderNumber;
        private System.Windows.Forms.Label lblProviderLabel;
        private System.Windows.Forms.Label lblReceptionDateLabel;
        private System.Windows.Forms.Label lblPurchaseOrderNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReception;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceptionPackageCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigthPerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAvailablePackages;
        private System.Windows.Forms.DataGridViewImageColumn clmPrint;
    }
}