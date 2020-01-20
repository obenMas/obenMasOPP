namespace BPS
{
    partial class frmShipping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShipping));
            this.grpbInternationalList = new System.Windows.Forms.GroupBox();
            this.dgvInternatinalSales = new System.Windows.Forms.DataGridView();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmvalidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmentity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmestimatedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdateshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdatecustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcontinernumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcontainer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdatevapor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdatethermal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmshippingbuilding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmenable = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmvalidateshipping = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmenablevalidation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmshippingvaporcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbActionsF = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSaveShipping = new System.Windows.Forms.Button();
            this.grpbFormulationsFilters = new System.Windows.Forms.GroupBox();
            this.grpbInternationalList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternatinalSales)).BeginInit();
            this.grpbActionsF.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbInternationalList
            // 
            this.grpbInternationalList.Controls.Add(this.dgvInternatinalSales);
            this.grpbInternationalList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbInternationalList.Location = new System.Drawing.Point(0, 0);
            this.grpbInternationalList.Name = "grpbInternationalList";
            this.grpbInternationalList.Size = new System.Drawing.Size(1285, 492);
            this.grpbInternationalList.TabIndex = 0;
            this.grpbInternationalList.TabStop = false;
            this.grpbInternationalList.Text = "Listado";
            // 
            // dgvInternatinalSales
            // 
            this.dgvInternatinalSales.AllowUserToAddRows = false;
            this.dgvInternatinalSales.AllowUserToDeleteRows = false;
            this.dgvInternatinalSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInternatinalSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmvalidate,
            this.clmentity,
            this.clmnumber,
            this.clmestimatedate,
            this.clmdateshop,
            this.clmdatecustomer,
            this.clmcontinernumber,
            this.clmcontainer,
            this.clmdatevapor,
            this.clmdatethermal,
            this.clmshippingbuilding,
            this.clmenable,
            this.clmvalidateshipping,
            this.clmenablevalidation,
            this.clmshippingvaporcodsec});
            this.dgvInternatinalSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInternatinalSales.Location = new System.Drawing.Point(3, 17);
            this.dgvInternatinalSales.Name = "dgvInternatinalSales";
            this.dgvInternatinalSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternatinalSales.Size = new System.Drawing.Size(1279, 472);
            this.dgvInternatinalSales.TabIndex = 0;
            this.dgvInternatinalSales.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInternatinalSales_CellDoubleClick);
            this.dgvInternatinalSales.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInternatinalSales_RowLeave);
            this.dgvInternatinalSales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvInternatinalSales_KeyDown);
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.Visible = false;
            // 
            // clmvalidate
            // 
            this.clmvalidate.HeaderText = "valdiate";
            this.clmvalidate.Name = "clmvalidate";
            this.clmvalidate.Visible = false;
            // 
            // clmentity
            // 
            this.clmentity.HeaderText = "Cliente";
            this.clmentity.Name = "clmentity";
            this.clmentity.ReadOnly = true;
            this.clmentity.Width = 200;
            // 
            // clmnumber
            // 
            this.clmnumber.HeaderText = "Orden";
            this.clmnumber.Name = "clmnumber";
            this.clmnumber.ReadOnly = true;
            this.clmnumber.Width = 70;
            // 
            // clmestimatedate
            // 
            this.clmestimatedate.HeaderText = "F. Estimada Facturar";
            this.clmestimatedate.Name = "clmestimatedate";
            this.clmestimatedate.ReadOnly = true;
            // 
            // clmdateshop
            // 
            this.clmdateshop.HeaderText = "F. Despacho";
            this.clmdateshop.Name = "clmdateshop";
            this.clmdateshop.ReadOnly = true;
            // 
            // clmdatecustomer
            // 
            this.clmdatecustomer.HeaderText = "F. Compromiso";
            this.clmdatecustomer.Name = "clmdatecustomer";
            this.clmdatecustomer.ReadOnly = true;
            // 
            // clmcontinernumber
            // 
            this.clmcontinernumber.HeaderText = "Cant. Container";
            this.clmcontinernumber.Name = "clmcontinernumber";
            this.clmcontinernumber.ReadOnly = true;
            this.clmcontinernumber.Width = 70;
            // 
            // clmcontainer
            // 
            this.clmcontainer.HeaderText = "Contenedor";
            this.clmcontainer.Name = "clmcontainer";
            this.clmcontainer.ReadOnly = true;
            this.clmcontainer.Width = 170;
            // 
            // clmdatevapor
            // 
            this.clmdatevapor.HeaderText = "F. Vapor";
            this.clmdatevapor.Name = "clmdatevapor";
            this.clmdatevapor.ReadOnly = true;
            // 
            // clmdatethermal
            // 
            this.clmdatethermal.HeaderText = "Tra. Termico";
            this.clmdatethermal.Name = "clmdatethermal";
            this.clmdatethermal.ReadOnly = true;
            // 
            // clmshippingbuilding
            // 
            this.clmshippingbuilding.HeaderText = "Naviera";
            this.clmshippingbuilding.Name = "clmshippingbuilding";
            this.clmshippingbuilding.ReadOnly = true;
            this.clmshippingbuilding.Width = 170;
            // 
            // clmenable
            // 
            this.clmenable.HeaderText = "";
            this.clmenable.Name = "clmenable";
            this.clmenable.ReadOnly = true;
            this.clmenable.Width = 30;
            // 
            // clmvalidateshipping
            // 
            this.clmvalidateshipping.HeaderText = "shippingcodsec";
            this.clmvalidateshipping.Name = "clmvalidateshipping";
            this.clmvalidateshipping.ReadOnly = true;
            this.clmvalidateshipping.Visible = false;
            // 
            // clmenablevalidation
            // 
            this.clmenablevalidation.HeaderText = "enablevalidation";
            this.clmenablevalidation.Name = "clmenablevalidation";
            this.clmenablevalidation.ReadOnly = true;
            this.clmenablevalidation.Visible = false;
            // 
            // clmshippingvaporcodsec
            // 
            this.clmshippingvaporcodsec.HeaderText = "vaporcodsec";
            this.clmshippingvaporcodsec.Name = "clmshippingvaporcodsec";
            this.clmshippingvaporcodsec.ReadOnly = true;
            this.clmshippingvaporcodsec.Visible = false;
            // 
            // grpbActionsF
            // 
            this.grpbActionsF.Controls.Add(this.btnClose);
            this.grpbActionsF.Controls.Add(this.btnReport);
            this.grpbActionsF.Controls.Add(this.btnSaveShipping);
            this.grpbActionsF.Location = new System.Drawing.Point(1196, 487);
            this.grpbActionsF.Name = "grpbActionsF";
            this.grpbActionsF.Size = new System.Drawing.Size(86, 43);
            this.grpbActionsF.TabIndex = 12;
            this.grpbActionsF.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(57, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 30;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(31, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 29;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnSaveShipping
            // 
            this.btnSaveShipping.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSaveShipping.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSaveShipping.Location = new System.Drawing.Point(5, 13);
            this.btnSaveShipping.Name = "btnSaveShipping";
            this.btnSaveShipping.Size = new System.Drawing.Size(25, 25);
            this.btnSaveShipping.TabIndex = 1;
            this.btnSaveShipping.UseVisualStyleBackColor = true;
            this.btnSaveShipping.Click += new System.EventHandler(this.btnSaveShipping_Click);
            // 
            // grpbFormulationsFilters
            // 
            this.grpbFormulationsFilters.Location = new System.Drawing.Point(3, 487);
            this.grpbFormulationsFilters.Name = "grpbFormulationsFilters";
            this.grpbFormulationsFilters.Size = new System.Drawing.Size(1189, 43);
            this.grpbFormulationsFilters.TabIndex = 13;
            this.grpbFormulationsFilters.TabStop = false;
            // 
            // frmShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1285, 532);
            this.Controls.Add(this.grpbInternationalList);
            this.Controls.Add(this.grpbFormulationsFilters);
            this.Controls.Add(this.grpbActionsF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmShipping";
            this.Text = "Navieras";
            this.Load += new System.EventHandler(this.frmShipping_Load);
            this.grpbInternationalList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternatinalSales)).EndInit();
            this.grpbActionsF.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbInternationalList;
        private System.Windows.Forms.DataGridView dgvInternatinalSales;
        private System.Windows.Forms.GroupBox grpbActionsF;
        private System.Windows.Forms.Button btnSaveShipping;
        private System.Windows.Forms.GroupBox grpbFormulationsFilters;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvalidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmentity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmestimatedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdateshop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdatecustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcontinernumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcontainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdatevapor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdatethermal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmshippingbuilding;
        private System.Windows.Forms.DataGridViewImageColumn clmenable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmvalidateshipping;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmenablevalidation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmshippingvaporcodsec;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReport;
    }
}