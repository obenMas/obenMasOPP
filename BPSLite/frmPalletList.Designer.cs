namespace BPS.Lite
{
    partial class frmPalletList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletList));
            this.grpInfoDate = new System.Windows.Forms.GroupBox();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.grpPalletList = new System.Windows.Forms.GroupBox();
            this.dgvPalletList = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdiference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPltCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblnotok = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpercentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInfoDate.SuspendLayout();
            this.grpPalletList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.grpbEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoDate
            // 
            this.grpInfoDate.Controls.Add(this.dtpDateTo);
            this.grpInfoDate.Controls.Add(this.label4);
            this.grpInfoDate.Controls.Add(this.btnFilter);
            this.grpInfoDate.Controls.Add(this.dtpDateFrom);
            this.grpInfoDate.Controls.Add(this.lblDateFrom);
            this.grpInfoDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfoDate.Location = new System.Drawing.Point(0, 0);
            this.grpInfoDate.Name = "grpInfoDate";
            this.grpInfoDate.Size = new System.Drawing.Size(1060, 44);
            this.grpInfoDate.TabIndex = 1;
            this.grpInfoDate.TabStop = false;
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Checked = false;
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Location = new System.Drawing.Point(430, 16);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(253, 21);
            this.dtpDateTo.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasta:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Lite.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(846, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Checked = false;
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Location = new System.Drawing.Point(87, 16);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(253, 21);
            this.dtpDateFrom.TabIndex = 3;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(37, 19);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(46, 15);
            this.lblDateFrom.TabIndex = 2;
            this.lblDateFrom.Text = "Desde:";
            // 
            // grpPalletList
            // 
            this.grpPalletList.Controls.Add(this.dgvPalletList);
            this.grpPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPalletList.Location = new System.Drawing.Point(0, 44);
            this.grpPalletList.Name = "grpPalletList";
            this.grpPalletList.Size = new System.Drawing.Size(1060, 446);
            this.grpPalletList.TabIndex = 2;
            this.grpPalletList.TabStop = false;
            this.grpPalletList.Text = "Pallets completos";
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.AllowUserToAddRows = false;
            this.dgvPalletList.AllowUserToDeleteRows = false;
            this.dgvPalletList.AllowUserToOrderColumns = true;
            this.dgvPalletList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmdiference,
            this.clmNumber,
            this.clmProductCode,
            this.clmID,
            this.clmSalesOrderNumber,
            this.clmWidth,
            this.clmNetWeight,
            this.clmGrossWeight,
            this.clmCustomer,
            this.clmLot,
            this.clmPltCreatedDate});
            this.dgvPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletList.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.ReadOnly = true;
            this.dgvPalletList.RowHeadersWidth = 21;
            this.dgvPalletList.Size = new System.Drawing.Size(1054, 426);
            this.dgvPalletList.TabIndex = 0;
            this.dgvPalletList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletList_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmdiference
            // 
            this.clmdiference.HeaderText = "diference";
            this.clmdiference.Name = "clmdiference";
            this.clmdiference.ReadOnly = true;
            this.clmdiference.Visible = false;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Nro.";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 50;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Width = 120;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 80;
            // 
            // clmSalesOrderNumber
            // 
            this.clmSalesOrderNumber.HeaderText = "Orden";
            this.clmSalesOrderNumber.Name = "clmSalesOrderNumber";
            this.clmSalesOrderNumber.ReadOnly = true;
            this.clmSalesOrderNumber.Width = 80;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 80;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso Neto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 90;
            // 
            // clmGrossWeight
            // 
            this.clmGrossWeight.HeaderText = "Peso Bruto";
            this.clmGrossWeight.Name = "clmGrossWeight";
            this.clmGrossWeight.ReadOnly = true;
            this.clmGrossWeight.Width = 90;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 260;
            // 
            // clmLot
            // 
            this.clmLot.HeaderText = "Lote";
            this.clmLot.Name = "clmLot";
            this.clmLot.ReadOnly = true;
            this.clmLot.Width = 80;
            // 
            // clmPltCreatedDate
            // 
            this.clmPltCreatedDate.HeaderText = "Fecha de creación";
            this.clmPltCreatedDate.Name = "clmPltCreatedDate";
            this.clmPltCreatedDate.ReadOnly = true;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.btnExcel);
            this.grpbEmpty.Controls.Add(this.btnExit);
            this.grpbEmpty.Controls.Add(this.lblnotok);
            this.grpbEmpty.Controls.Add(this.btnReport);
            this.grpbEmpty.Controls.Add(this.label3);
            this.grpbEmpty.Controls.Add(this.lblok);
            this.grpbEmpty.Controls.Add(this.label2);
            this.grpbEmpty.Controls.Add(this.lblpercentaje);
            this.grpbEmpty.Controls.Add(this.label1);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(0, 490);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1060, 41);
            this.grpbEmpty.TabIndex = 8;
            this.grpbEmpty.TabStop = false;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcel.Location = new System.Drawing.Point(978, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExcel.TabIndex = 6;
            this.btnExcel.TabStop = false;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::BPS.Lite.Properties.Resources.door_in;
            this.btnExit.Location = new System.Drawing.Point(1032, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblnotok
            // 
            this.lblnotok.AutoSize = true;
            this.lblnotok.Location = new System.Drawing.Point(690, 17);
            this.lblnotok.Name = "lblnotok";
            this.lblnotok.Size = new System.Drawing.Size(35, 15);
            this.lblnotok.TabIndex = 5;
            this.lblnotok.Text = "1000";
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Lite.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(1005, 12);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 0;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pallet´s Novedades";
            // 
            // lblok
            // 
            this.lblok.AutoSize = true;
            this.lblok.Location = new System.Drawing.Point(520, 17);
            this.lblok.Name = "lblok";
            this.lblok.Size = new System.Drawing.Size(35, 15);
            this.lblok.TabIndex = 3;
            this.lblok.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pallet´s  OK";
            // 
            // lblpercentaje
            // 
            this.lblpercentaje.AutoSize = true;
            this.lblpercentaje.Location = new System.Drawing.Point(368, 17);
            this.lblpercentaje.Name = "lblpercentaje";
            this.lblpercentaje.Size = new System.Drawing.Size(42, 15);
            this.lblpercentaje.TabIndex = 1;
            this.lblpercentaje.Text = "100 %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eficiencia Peso ";
            // 
            // frmPalletList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1060, 531);
            this.Controls.Add(this.grpPalletList);
            this.Controls.Add(this.grpInfoDate);
            this.Controls.Add(this.grpbEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletList";
            this.Text = "Listado de pallets completos";
            this.Load += new System.EventHandler(this.frmPalletList_Load);
            this.grpInfoDate.ResumeLayout(false);
            this.grpInfoDate.PerformLayout();
            this.grpPalletList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.grpbEmpty.ResumeLayout(false);
            this.grpbEmpty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoDate;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpDateFrom;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.GroupBox grpPalletList;
        private System.Windows.Forms.DataGridView dgvPalletList;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblnotok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpercentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdiference;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPltCreatedDate;
        private System.Windows.Forms.Button btnExcel;
    }
}