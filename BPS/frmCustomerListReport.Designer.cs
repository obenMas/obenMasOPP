namespace BPS
{
    partial class frmCustomerListReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerListReport));
            this.gpbMainFilter = new System.Windows.Forms.GroupBox();
            this.chbAllEntity = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFilterAllEntity = new System.Windows.Forms.Button();
            this.gpbMainCustomer = new System.Windows.Forms.GroupBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.clmCodSecSalesOrderDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKilosEnter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKilosPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.ttpReportCustomerHistory = new System.Windows.Forms.ToolTip(this.components);
            this.gpbMainFilter.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbMainCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMainFilter
            // 
            this.gpbMainFilter.Controls.Add(this.chbAllEntity);
            this.gpbMainFilter.Controls.Add(this.groupBox2);
            this.gpbMainFilter.Controls.Add(this.groupBox3);
            this.gpbMainFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpbMainFilter.Location = new System.Drawing.Point(0, 0);
            this.gpbMainFilter.Name = "gpbMainFilter";
            this.gpbMainFilter.Size = new System.Drawing.Size(960, 68);
            this.gpbMainFilter.TabIndex = 0;
            this.gpbMainFilter.TabStop = false;
            // 
            // chbAllEntity
            // 
            this.chbAllEntity.AutoSize = true;
            this.chbAllEntity.Location = new System.Drawing.Point(627, 28);
            this.chbAllEntity.Name = "chbAllEntity";
            this.chbAllEntity.Size = new System.Drawing.Size(112, 17);
            this.chbAllEntity.TabIndex = 26;
            this.chbAllEntity.Text = "Todos los Clientes";
            this.ttpReportCustomerHistory.SetToolTip(this.chbAllEntity, "Seleccionar todos");
            this.chbAllEntity.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCustomer);
            this.groupBox2.Controls.Add(this.btnFilter);
            this.groupBox2.Controls.Add(this.lblCustomer);
            this.groupBox2.Location = new System.Drawing.Point(-1, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(122, 24);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(259, 23);
            this.cmbCustomer.TabIndex = 1;
            this.ttpReportCustomerHistory.SetToolTip(this.cmbCustomer, "Clientes");
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(409, 22);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 25;
            this.ttpReportCustomerHistory.SetToolTip(this.btnFilter, "Buscar");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(65, 26);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(54, 15);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Clientes:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFilterAllEntity);
            this.groupBox3.Location = new System.Drawing.Point(496, -1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 69);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // btnFilterAllEntity
            // 
            this.btnFilterAllEntity.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilterAllEntity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilterAllEntity.Location = new System.Drawing.Point(286, 25);
            this.btnFilterAllEntity.Name = "btnFilterAllEntity";
            this.btnFilterAllEntity.Size = new System.Drawing.Size(25, 25);
            this.btnFilterAllEntity.TabIndex = 27;
            this.ttpReportCustomerHistory.SetToolTip(this.btnFilterAllEntity, "Buscar");
            this.btnFilterAllEntity.UseVisualStyleBackColor = true;
            this.btnFilterAllEntity.Click += new System.EventHandler(this.btnFilterAllEntity_Click);
            // 
            // gpbMainCustomer
            // 
            this.gpbMainCustomer.Controls.Add(this.dgvCustomer);
            this.gpbMainCustomer.Location = new System.Drawing.Point(0, 74);
            this.gpbMainCustomer.Name = "gpbMainCustomer";
            this.gpbMainCustomer.Size = new System.Drawing.Size(960, 371);
            this.gpbMainCustomer.TabIndex = 1;
            this.gpbMainCustomer.TabStop = false;
            this.gpbMainCustomer.Text = "Histórico";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToOrderColumns = true;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodSecSalesOrderDetails,
            this.clmSalesOrder,
            this.clmProductName,
            this.clmQuantity,
            this.clmKilosEnter,
            this.clmKilosPending,
            this.clmPrice});
            this.dgvCustomer.Location = new System.Drawing.Point(6, 20);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(948, 345);
            this.dgvCustomer.TabIndex = 0;
            this.ttpReportCustomerHistory.SetToolTip(this.dgvCustomer, "Listado Historico");
            // 
            // clmCodSecSalesOrderDetails
            // 
            this.clmCodSecSalesOrderDetails.HeaderText = "codsec";
            this.clmCodSecSalesOrderDetails.Name = "clmCodSecSalesOrderDetails";
            this.clmCodSecSalesOrderDetails.ReadOnly = true;
            this.clmCodSecSalesOrderDetails.Visible = false;
            // 
            // clmSalesOrder
            // 
            this.clmSalesOrder.HeaderText = "N° Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            this.clmSalesOrder.Width = 90;
            // 
            // clmProductName
            // 
            this.clmProductName.HeaderText = "Producto";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.ReadOnly = true;
            this.clmProductName.Width = 360;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Kilos Pedidos";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 110;
            // 
            // clmKilosEnter
            // 
            this.clmKilosEnter.HeaderText = "Kilos Entregados";
            this.clmKilosEnter.Name = "clmKilosEnter";
            this.clmKilosEnter.ReadOnly = true;
            this.clmKilosEnter.Width = 130;
            // 
            // clmKilosPending
            // 
            this.clmKilosPending.HeaderText = "Kilos Pendientes";
            this.clmKilosPending.Name = "clmKilosPending";
            this.clmKilosPending.ReadOnly = true;
            this.clmKilosPending.Width = 130;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReport);
            this.groupBox1.Location = new System.Drawing.Point(926, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(34, 43);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::BPS.Properties.Resources.report;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReport.Location = new System.Drawing.Point(5, 13);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(25, 25);
            this.btnReport.TabIndex = 29;
            this.ttpReportCustomerHistory.SetToolTip(this.btnReport, "Reporte");
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmCustomerListReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(960, 488);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbMainCustomer);
            this.Controls.Add(this.gpbMainFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCustomerListReport";
            this.Text = "Listado de Clientes Historico";
            this.Load += new System.EventHandler(this.frmCustomerListReport_Load);
            this.gpbMainFilter.ResumeLayout(false);
            this.gpbMainFilter.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gpbMainCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbMainFilter;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox gpbMainCustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodSecSalesOrderDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKilosEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKilosPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.CheckBox chbAllEntity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFilterAllEntity;
        private System.Windows.Forms.ToolTip ttpReportCustomerHistory;
    }
}