namespace BPS
{
    partial class frmSalesOrderByReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderByReport));
            this.gpbSalesOrderNational = new System.Windows.Forms.GroupBox();
            this.dgvSalesOrder = new System.Windows.Forms.DataGridView();
            this.clmYearCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonthCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThickness = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRelation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.btnExportToExcelI = new System.Windows.Forms.Button();
            this.gpbExportData = new System.Windows.Forms.GroupBox();
            this.gpbSalesOrderNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).BeginInit();
            this.gpbExportData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbSalesOrderNational
            // 
            this.gpbSalesOrderNational.Controls.Add(this.dgvSalesOrder);
            this.gpbSalesOrderNational.Location = new System.Drawing.Point(0, 2);
            this.gpbSalesOrderNational.Name = "gpbSalesOrderNational";
            this.gpbSalesOrderNational.Size = new System.Drawing.Size(1160, 501);
            this.gpbSalesOrderNational.TabIndex = 0;
            this.gpbSalesOrderNational.TabStop = false;
            this.gpbSalesOrderNational.Text = "Ventas Nacionales";
            // 
            // dgvSalesOrder
            // 
            this.dgvSalesOrder.AllowUserToAddRows = false;
            this.dgvSalesOrder.AllowUserToDeleteRows = false;
            this.dgvSalesOrder.AllowUserToOrderColumns = true;
            this.dgvSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmYearCreatedDate,
            this.clmMonthCreateDate,
            this.clmCreateDate,
            this.clmCompanyName,
            this.clmProductName,
            this.clmQuantity,
            this.clmPrice,
            this.clmWeigth,
            this.clmType,
            this.clmThickness,
            this.clmFamily,
            this.clmRelation,
            this.clmPais});
            this.dgvSalesOrder.Location = new System.Drawing.Point(3, 24);
            this.dgvSalesOrder.Name = "dgvSalesOrder";
            this.dgvSalesOrder.ReadOnly = true;
            this.dgvSalesOrder.Size = new System.Drawing.Size(1151, 473);
            this.dgvSalesOrder.TabIndex = 0;
            // 
            // clmYearCreatedDate
            // 
            this.clmYearCreatedDate.HeaderText = "Año";
            this.clmYearCreatedDate.Name = "clmYearCreatedDate";
            this.clmYearCreatedDate.ReadOnly = true;
            // 
            // clmMonthCreateDate
            // 
            this.clmMonthCreateDate.HeaderText = "Mes";
            this.clmMonthCreateDate.Name = "clmMonthCreateDate";
            this.clmMonthCreateDate.ReadOnly = true;
            // 
            // clmCreateDate
            // 
            this.clmCreateDate.HeaderText = "Fecha";
            this.clmCreateDate.Name = "clmCreateDate";
            this.clmCreateDate.ReadOnly = true;
            // 
            // clmCompanyName
            // 
            this.clmCompanyName.HeaderText = "Cliente";
            this.clmCompanyName.Name = "clmCompanyName";
            this.clmCompanyName.ReadOnly = true;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Descripción";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Ancho";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            // 
            // clmType
            // 
            this.clmType.HeaderText = "Tipo";
            this.clmType.Name = "clmType";
            this.clmType.ReadOnly = true;
            // 
            // clmThickness
            // 
            this.clmThickness.HeaderText = "Micras";
            this.clmThickness.Name = "clmThickness";
            this.clmThickness.ReadOnly = true;
            // 
            // clmFamily
            // 
            this.clmFamily.HeaderText = "Familia";
            this.clmFamily.Name = "clmFamily";
            this.clmFamily.ReadOnly = true;
            // 
            // clmRelation
            // 
            this.clmRelation.HeaderText = "Relación";
            this.clmRelation.Name = "clmRelation";
            this.clmRelation.ReadOnly = true;
            // 
            // clmPais
            // 
            this.clmPais.HeaderText = "País";
            this.clmPais.Name = "clmPais";
            this.clmPais.ReadOnly = true;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.BackgroundImage = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportToExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportToExcel.Location = new System.Drawing.Point(1097, 11);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExportToExcel.TabIndex = 106;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Visible = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // btnExportToExcelI
            // 
            this.btnExportToExcelI.BackgroundImage = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportToExcelI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExportToExcelI.Location = new System.Drawing.Point(1128, 11);
            this.btnExportToExcelI.Name = "btnExportToExcelI";
            this.btnExportToExcelI.Size = new System.Drawing.Size(25, 25);
            this.btnExportToExcelI.TabIndex = 107;
            this.btnExportToExcelI.UseVisualStyleBackColor = true;
            this.btnExportToExcelI.Click += new System.EventHandler(this.btnExportToExcelI_Click);
            // 
            // gpbExportData
            // 
            this.gpbExportData.Controls.Add(this.btnExportToExcelI);
            this.gpbExportData.Controls.Add(this.btnExportToExcel);
            this.gpbExportData.Location = new System.Drawing.Point(1, 498);
            this.gpbExportData.Name = "gpbExportData";
            this.gpbExportData.Size = new System.Drawing.Size(1159, 38);
            this.gpbExportData.TabIndex = 1;
            this.gpbExportData.TabStop = false;
            // 
            // frmSalesOrderByReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1162, 539);
            this.Controls.Add(this.gpbSalesOrderNational);
            this.Controls.Add(this.gpbExportData);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderByReport";
            this.Text = "Ventas Nacionales";
            this.Load += new System.EventHandler(this.frmSalesOrderByReport_Load);
            this.gpbSalesOrderNational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrder)).EndInit();
            this.gpbExportData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbSalesOrderNational;
        private System.Windows.Forms.DataGridView dgvSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYearCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonthCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThickness;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRelation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPais;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Button btnExportToExcelI;
        private System.Windows.Forms.GroupBox gpbExportData;
    }
}