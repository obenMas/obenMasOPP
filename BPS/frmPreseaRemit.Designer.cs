namespace BPS
{
    partial class frmPreseaRemit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreseaRemit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbNotes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cmbSalesOrder = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.cmbCodes = new System.Windows.Forms.ComboBox();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelFilter = new System.Windows.Forms.Button();
            this.btnAddFilter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtUpdatedDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdatePS = new System.Windows.Forms.Button();
            this.dgvPreseaRemit = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrigin2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmObservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreseaRemit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbNotes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(this.cmbSalesOrder);
            this.groupBox1.Controls.Add(this.cmbUsers);
            this.groupBox1.Controls.Add(this.cmbCodes);
            this.groupBox1.Controls.Add(this.cmbCustomers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelFilter);
            this.groupBox1.Controls.Add(this.btnAddFilter);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cmbNotes
            // 
            this.cmbNotes.FormattingEnabled = true;
            this.cmbNotes.Location = new System.Drawing.Point(97, 57);
            this.cmbNotes.Name = "cmbNotes";
            this.cmbNotes.Size = new System.Drawing.Size(738, 21);
            this.cmbNotes.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Observaciones:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(910, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "0 /";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(843, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Registros:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(947, 25);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(56, 20);
            this.txtQuantity.TabIndex = 29;
            this.txtQuantity.Text = "100";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportExcel.Location = new System.Drawing.Point(851, 57);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(46, 23);
            this.btnExportExcel.TabIndex = 27;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cmbSalesOrder
            // 
            this.cmbSalesOrder.FormattingEnabled = true;
            this.cmbSalesOrder.Location = new System.Drawing.Point(714, 25);
            this.cmbSalesOrder.Name = "cmbSalesOrder";
            this.cmbSalesOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbSalesOrder.TabIndex = 26;
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(520, 21);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(146, 21);
            this.cmbUsers.TabIndex = 25;
            // 
            // cmbCodes
            // 
            this.cmbCodes.FormattingEnabled = true;
            this.cmbCodes.Location = new System.Drawing.Point(327, 20);
            this.cmbCodes.Name = "cmbCodes";
            this.cmbCodes.Size = new System.Drawing.Size(121, 21);
            this.cmbCodes.TabIndex = 24;
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(45, 20);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(220, 21);
            this.cmbCustomers.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "OV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cod.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cte.:";
            // 
            // btnDelFilter
            // 
            this.btnDelFilter.Image = global::BPS.Properties.Resources.funnel_clear;
            this.btnDelFilter.Location = new System.Drawing.Point(955, 57);
            this.btnDelFilter.Name = "btnDelFilter";
            this.btnDelFilter.Size = new System.Drawing.Size(46, 23);
            this.btnDelFilter.TabIndex = 18;
            this.btnDelFilter.UseVisualStyleBackColor = true;
            this.btnDelFilter.Click += new System.EventHandler(this.btnDelFilter_Click);
            // 
            // btnAddFilter
            // 
            this.btnAddFilter.Image = global::BPS.Properties.Resources.funnel;
            this.btnAddFilter.Location = new System.Drawing.Point(903, 57);
            this.btnAddFilter.Name = "btnAddFilter";
            this.btnAddFilter.Size = new System.Drawing.Size(46, 23);
            this.btnAddFilter.TabIndex = 17;
            this.btnAddFilter.UseVisualStyleBackColor = true;
            this.btnAddFilter.Click += new System.EventHandler(this.btnAddFilter_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtUpdatedDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnUpdatePS);
            this.groupBox2.Location = new System.Drawing.Point(3, 468);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 61);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtUpdatedDate
            // 
            this.txtUpdatedDate.Location = new System.Drawing.Point(826, 20);
            this.txtUpdatedDate.Name = "txtUpdatedDate";
            this.txtUpdatedDate.Size = new System.Drawing.Size(162, 20);
            this.txtUpdatedDate.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fecha Actualización:";
            // 
            // btnUpdatePS
            // 
            this.btnUpdatePS.Location = new System.Drawing.Point(634, 19);
            this.btnUpdatePS.Name = "btnUpdatePS";
            this.btnUpdatePS.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePS.TabIndex = 22;
            this.btnUpdatePS.Text = "Actualizar";
            this.btnUpdatePS.UseVisualStyleBackColor = true;
            this.btnUpdatePS.Click += new System.EventHandler(this.btnUpdatePS_Click);
            // 
            // dgvPreseaRemit
            // 
            this.dgvPreseaRemit.AllowUserToAddRows = false;
            this.dgvPreseaRemit.AllowUserToDeleteRows = false;
            this.dgvPreseaRemit.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvPreseaRemit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreseaRemit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmNumber,
            this.clmCustomerName,
            this.clmDate,
            this.clmCode,
            this.clmPrice,
            this.clmQuantity,
            this.clmIva,
            this.clmDetail,
            this.clmUser,
            this.clmOrigin,
            this.clmOrigin2,
            this.clmSaleOrder,
            this.clmObservation});
            this.dgvPreseaRemit.Location = new System.Drawing.Point(3, 97);
            this.dgvPreseaRemit.Name = "dgvPreseaRemit";
            this.dgvPreseaRemit.ReadOnly = true;
            this.dgvPreseaRemit.Size = new System.Drawing.Size(1009, 374);
            this.dgvPreseaRemit.TabIndex = 2;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Nº";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 80;
            // 
            // clmCustomerName
            // 
            this.clmCustomerName.HeaderText = "Cte.";
            this.clmCustomerName.Name = "clmCustomerName";
            this.clmCustomerName.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 80;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Cod.";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Precio";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            this.clmPrice.Width = 60;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cant.";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            this.clmQuantity.Width = 60;
            // 
            // clmIva
            // 
            this.clmIva.HeaderText = "Iva";
            this.clmIva.Name = "clmIva";
            this.clmIva.ReadOnly = true;
            this.clmIva.Width = 70;
            // 
            // clmDetail
            // 
            this.clmDetail.HeaderText = "Detalle";
            this.clmDetail.Name = "clmDetail";
            this.clmDetail.ReadOnly = true;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            // 
            // clmOrigin
            // 
            this.clmOrigin.HeaderText = "Origen 1";
            this.clmOrigin.Name = "clmOrigin";
            this.clmOrigin.ReadOnly = true;
            this.clmOrigin.Width = 60;
            // 
            // clmOrigin2
            // 
            this.clmOrigin2.HeaderText = "Origen 2";
            this.clmOrigin2.Name = "clmOrigin2";
            this.clmOrigin2.ReadOnly = true;
            this.clmOrigin2.Width = 80;
            // 
            // clmSaleOrder
            // 
            this.clmSaleOrder.HeaderText = "OV";
            this.clmSaleOrder.Name = "clmSaleOrder";
            this.clmSaleOrder.ReadOnly = true;
            this.clmSaleOrder.Width = 60;
            // 
            // clmObservation
            // 
            this.clmObservation.HeaderText = "Observaciones";
            this.clmObservation.Name = "clmObservation";
            this.clmObservation.ReadOnly = true;
            this.clmObservation.Width = 140;
            // 
            // frmPreseaRemit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 534);
            this.Controls.Add(this.dgvPreseaRemit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreseaRemit";
            this.Text = "Remitos Presea";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreseaRemit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddFilter;
        private System.Windows.Forms.Button btnDelFilter;
        private System.Windows.Forms.DataGridView dgvPreseaRemit;
        private System.Windows.Forms.ComboBox cmbSalesOrder;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.ComboBox cmbCodes;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdatedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdatePS;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigin2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmObservation;
    }
}