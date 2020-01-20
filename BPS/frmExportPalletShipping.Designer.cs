namespace BPS
{
    partial class frmExportPalletShipping
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportPalletShipping));
            this.grpbFilter = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblInitDate = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.grpbPalletCellar = new System.Windows.Forms.GroupBox();
            this.grpbSearch = new System.Windows.Forms.GroupBox();
            this.grpbActions = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.fbdFilePath = new System.Windows.Forms.FolderBrowserDialog();
            this.dgvPalletCellar = new System.Windows.Forms.DataGridView();
            this.clmMovementCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementValidated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementPalletCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementcellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementcodepallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementpalletcomposition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementcustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementorder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementwith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmovementweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementIsExported = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMovementToExport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmMovementFlgToExport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementLocalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementExternalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFilter.SuspendLayout();
            this.grpbPalletCellar.SuspendLayout();
            this.grpbActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbFilter
            // 
            this.grpbFilter.Controls.Add(this.lblEndDate);
            this.grpbFilter.Controls.Add(this.lblInitDate);
            this.grpbFilter.Controls.Add(this.btnLoadData);
            this.grpbFilter.Controls.Add(this.dtpEndDate);
            this.grpbFilter.Controls.Add(this.dtpInitDate);
            this.grpbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilter.Location = new System.Drawing.Point(0, 0);
            this.grpbFilter.Name = "grpbFilter";
            this.grpbFilter.Size = new System.Drawing.Size(1039, 59);
            this.grpbFilter.TabIndex = 1;
            this.grpbFilter.TabStop = false;
            this.grpbFilter.Text = "Filtros";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(509, 26);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(39, 15);
            this.lblEndDate.TabIndex = 3;
            this.lblEndDate.Text = "Hasta";
            // 
            // lblInitDate
            // 
            this.lblInitDate.AutoSize = true;
            this.lblInitDate.Location = new System.Drawing.Point(206, 26);
            this.lblInitDate.Name = "lblInitDate";
            this.lblInitDate.Size = new System.Drawing.Size(43, 15);
            this.lblInitDate.TabIndex = 2;
            this.lblInitDate.Text = "Desde";
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLoadData.Location = new System.Drawing.Point(808, 21);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(24, 25);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(554, 23);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(248, 21);
            this.dtpEndDate.TabIndex = 0;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(255, 23);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(248, 21);
            this.dtpInitDate.TabIndex = 0;
            // 
            // grpbPalletCellar
            // 
            this.grpbPalletCellar.Controls.Add(this.dgvPalletCellar);
            this.grpbPalletCellar.Controls.Add(this.grpbSearch);
            this.grpbPalletCellar.Controls.Add(this.grpbActions);
            this.grpbPalletCellar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbPalletCellar.Location = new System.Drawing.Point(0, 59);
            this.grpbPalletCellar.Name = "grpbPalletCellar";
            this.grpbPalletCellar.Size = new System.Drawing.Size(1039, 517);
            this.grpbPalletCellar.TabIndex = 2;
            this.grpbPalletCellar.TabStop = false;
            this.grpbPalletCellar.Text = "Movimientos de pallets en bodega";
            // 
            // grpbSearch
            // 
            this.grpbSearch.Location = new System.Drawing.Point(0, 473);
            this.grpbSearch.Name = "grpbSearch";
            this.grpbSearch.Size = new System.Drawing.Size(922, 43);
            this.grpbSearch.TabIndex = 5;
            this.grpbSearch.TabStop = false;
            // 
            // grpbActions
            // 
            this.grpbActions.Controls.Add(this.btnOrder);
            this.grpbActions.Controls.Add(this.btnValidate);
            this.grpbActions.Controls.Add(this.btnExport);
            this.grpbActions.Controls.Add(this.btnClose);
            this.grpbActions.Location = new System.Drawing.Point(926, 473);
            this.grpbActions.Name = "grpbActions";
            this.grpbActions.Size = new System.Drawing.Size(113, 43);
            this.grpbActions.TabIndex = 6;
            this.grpbActions.TabStop = false;
            // 
            // btnOrder
            // 
            this.btnOrder.BackgroundImage = global::BPS.Properties.Resources.Xiao_90;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOrder.Location = new System.Drawing.Point(7, 13);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(25, 25);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.BackgroundImage = global::BPS.Properties.Resources.quality;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(32, 13);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(25, 25);
            this.btnValidate.TabIndex = 3;
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackgroundImage = global::BPS.Properties.Resources.iconExportTo;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExport.Location = new System.Drawing.Point(57, 13);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 0;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(82, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvPalletCellar
            // 
            this.dgvPalletCellar.AllowUserToAddRows = false;
            this.dgvPalletCellar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPalletCellar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPalletCellar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletCellar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalletCellar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletCellar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMovementCodsec,
            this.clmMovementValidated,
            this.clmMovementPalletCodsec,
            this.clmmovementcellar,
            this.clmmovementdate,
            this.clmmovementcodepallet,
            this.clmmovementproduct,
            this.clmmovementpalletcomposition,
            this.clmmovementcustomer,
            this.clmmovementorder,
            this.clmmovementwith,
            this.clmmovementweigth,
            this.clmMovementIsExported,
            this.clmMovementToExport,
            this.clmMovementFlgToExport,
            this.clmMovementLocalWeight,
            this.clmMovementExternalWeight});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPalletCellar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPalletCellar.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPalletCellar.Location = new System.Drawing.Point(3, 17);
            this.dgvPalletCellar.Name = "dgvPalletCellar";
            this.dgvPalletCellar.ReadOnly = true;
            this.dgvPalletCellar.RowHeadersWidth = 20;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPalletCellar.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPalletCellar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPalletCellar.Size = new System.Drawing.Size(1033, 458);
            this.dgvPalletCellar.TabIndex = 7;
            this.dgvPalletCellar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletCellar_CellClick);
            this.dgvPalletCellar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalletCellar_CellDoubleClick);
            // 
            // clmMovementCodsec
            // 
            this.clmMovementCodsec.HeaderText = "movementCodsec";
            this.clmMovementCodsec.Name = "clmMovementCodsec";
            this.clmMovementCodsec.ReadOnly = true;
            this.clmMovementCodsec.Visible = false;
            // 
            // clmMovementValidated
            // 
            this.clmMovementValidated.HeaderText = "";
            this.clmMovementValidated.Name = "clmMovementValidated";
            this.clmMovementValidated.ReadOnly = true;
            this.clmMovementValidated.Visible = false;
            // 
            // clmMovementPalletCodsec
            // 
            this.clmMovementPalletCodsec.HeaderText = "codsec";
            this.clmMovementPalletCodsec.Name = "clmMovementPalletCodsec";
            this.clmMovementPalletCodsec.ReadOnly = true;
            this.clmMovementPalletCodsec.Visible = false;
            // 
            // clmmovementcellar
            // 
            this.clmmovementcellar.HeaderText = "Movimiento en Bodega";
            this.clmmovementcellar.Name = "clmmovementcellar";
            this.clmmovementcellar.ReadOnly = true;
            this.clmmovementcellar.Width = 160;
            // 
            // clmmovementdate
            // 
            this.clmmovementdate.HeaderText = "Fecha";
            this.clmmovementdate.Name = "clmmovementdate";
            this.clmmovementdate.ReadOnly = true;
            this.clmmovementdate.Width = 120;
            // 
            // clmmovementcodepallet
            // 
            this.clmmovementcodepallet.HeaderText = "Pallet";
            this.clmmovementcodepallet.Name = "clmmovementcodepallet";
            this.clmmovementcodepallet.ReadOnly = true;
            this.clmmovementcodepallet.Width = 110;
            // 
            // clmmovementproduct
            // 
            this.clmmovementproduct.HeaderText = "Producto";
            this.clmmovementproduct.Name = "clmmovementproduct";
            this.clmmovementproduct.ReadOnly = true;
            // 
            // clmmovementpalletcomposition
            // 
            this.clmmovementpalletcomposition.HeaderText = "P - B";
            this.clmmovementpalletcomposition.Name = "clmmovementpalletcomposition";
            this.clmmovementpalletcomposition.ReadOnly = true;
            this.clmmovementpalletcomposition.Width = 58;
            // 
            // clmmovementcustomer
            // 
            this.clmmovementcustomer.HeaderText = "Cliente";
            this.clmmovementcustomer.Name = "clmmovementcustomer";
            this.clmmovementcustomer.ReadOnly = true;
            this.clmmovementcustomer.Width = 170;
            // 
            // clmmovementorder
            // 
            this.clmmovementorder.HeaderText = "Orden";
            this.clmmovementorder.Name = "clmmovementorder";
            this.clmmovementorder.ReadOnly = true;
            this.clmmovementorder.Width = 70;
            // 
            // clmmovementwith
            // 
            this.clmmovementwith.HeaderText = "Ancho";
            this.clmmovementwith.Name = "clmmovementwith";
            this.clmmovementwith.ReadOnly = true;
            this.clmmovementwith.Width = 70;
            // 
            // clmmovementweigth
            // 
            this.clmmovementweigth.HeaderText = "Peso";
            this.clmmovementweigth.Name = "clmmovementweigth";
            this.clmmovementweigth.ReadOnly = true;
            this.clmmovementweigth.Width = 70;
            // 
            // clmMovementIsExported
            // 
            this.clmMovementIsExported.HeaderText = "";
            this.clmMovementIsExported.Name = "clmMovementIsExported";
            this.clmMovementIsExported.ReadOnly = true;
            this.clmMovementIsExported.Width = 30;
            // 
            // clmMovementToExport
            // 
            this.clmMovementToExport.HeaderText = "";
            this.clmMovementToExport.Name = "clmMovementToExport";
            this.clmMovementToExport.ReadOnly = true;
            this.clmMovementToExport.Width = 30;
            // 
            // clmMovementFlgToExport
            // 
            this.clmMovementFlgToExport.HeaderText = "toExport";
            this.clmMovementFlgToExport.Name = "clmMovementFlgToExport";
            this.clmMovementFlgToExport.ReadOnly = true;
            this.clmMovementFlgToExport.Visible = false;
            // 
            // clmMovementLocalWeight
            // 
            this.clmMovementLocalWeight.HeaderText = "local";
            this.clmMovementLocalWeight.Name = "clmMovementLocalWeight";
            this.clmMovementLocalWeight.ReadOnly = true;
            this.clmMovementLocalWeight.Visible = false;
            // 
            // clmMovementExternalWeight
            // 
            this.clmMovementExternalWeight.HeaderText = "external";
            this.clmMovementExternalWeight.Name = "clmMovementExternalWeight";
            this.clmMovementExternalWeight.ReadOnly = true;
            this.clmMovementExternalWeight.Visible = false;
            // 
            // frmExportPalletShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1039, 576);
            this.Controls.Add(this.grpbPalletCellar);
            this.Controls.Add(this.grpbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExportPalletShipping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trazabilidad de Pallets";
            this.Load += new System.EventHandler(this.frmPalletMovement_Load);
            this.grpbFilter.ResumeLayout(false);
            this.grpbFilter.PerformLayout();
            this.grpbPalletCellar.ResumeLayout(false);
            this.grpbActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletCellar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilter;
        private System.Windows.Forms.GroupBox grpbPalletCellar;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblInitDate;
        private System.Windows.Forms.GroupBox grpbSearch;
        private System.Windows.Forms.GroupBox grpbActions;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FolderBrowserDialog fbdFilePath;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.DataGridView dgvPalletCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementValidated;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementPalletCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementcellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementcodepallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementpalletcomposition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementorder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementwith;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmovementweigth;
        private System.Windows.Forms.DataGridViewImageColumn clmMovementIsExported;
        private System.Windows.Forms.DataGridViewImageColumn clmMovementToExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementFlgToExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementLocalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementExternalWeight;
    }
}