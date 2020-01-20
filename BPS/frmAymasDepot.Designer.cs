namespace BPS
{
    partial class frmAymasDepot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAymasDepot));
            this.dgvAymasDepot = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustommer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcedence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCore = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDiameter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.cmbPalletCode = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAymasDepot)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAymasDepot
            // 
            this.dgvAymasDepot.AllowUserToAddRows = false;
            this.dgvAymasDepot.AllowUserToDeleteRows = false;
            this.dgvAymasDepot.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvAymasDepot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAymasDepot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPalletCode,
            this.clmFilm,
            this.clmWidth,
            this.clmWeight,
            this.clmDiameter,
            this.clmCore,
            this.clmSaleOrderDetail,
            this.clmSaleOrder,
            this.clmCustommer,
            this.clmQuality,
            this.clmState,
            this.clmDate,
            this.clmProcedence});
            this.dgvAymasDepot.Location = new System.Drawing.Point(6, 91);
            this.dgvAymasDepot.Name = "dgvAymasDepot";
            this.dgvAymasDepot.ReadOnly = true;
            this.dgvAymasDepot.Size = new System.Drawing.Size(1009, 379);
            this.dgvAymasDepot.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Cod. Pallet";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Película";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            this.clmFilm.Width = 70;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 70;
            // 
            // clmWeight
            // 
            this.clmWeight.HeaderText = "Peso";
            this.clmWeight.Name = "clmWeight";
            this.clmWeight.ReadOnly = true;
            this.clmWeight.Width = 70;
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diam.";
            this.clmDiameter.Name = "clmDiameter";
            this.clmDiameter.ReadOnly = true;
            this.clmDiameter.Width = 70;
            // 
            // clmCore
            // 
            this.clmCore.HeaderText = "Core";
            this.clmCore.Name = "clmCore";
            this.clmCore.ReadOnly = true;
            this.clmCore.Width = 70;
            // 
            // clmSaleOrderDetail
            // 
            this.clmSaleOrderDetail.HeaderText = "";
            this.clmSaleOrderDetail.Name = "clmSaleOrderDetail";
            this.clmSaleOrderDetail.ReadOnly = true;
            this.clmSaleOrderDetail.Visible = false;
            // 
            // clmSaleOrder
            // 
            this.clmSaleOrder.HeaderText = "Pedido";
            this.clmSaleOrder.Name = "clmSaleOrder";
            this.clmSaleOrder.ReadOnly = true;
            this.clmSaleOrder.Width = 70;
            // 
            // clmCustommer
            // 
            this.clmCustommer.HeaderText = "Cliente";
            this.clmCustommer.Name = "clmCustommer";
            this.clmCustommer.ReadOnly = true;
            this.clmCustommer.Width = 200;
            // 
            // clmQuality
            // 
            this.clmQuality.HeaderText = "Calidad";
            this.clmQuality.Name = "clmQuality";
            this.clmQuality.ReadOnly = true;
            // 
            // clmState
            // 
            this.clmState.HeaderText = "Estado";
            this.clmState.Name = "clmState";
            this.clmState.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmProcedence
            // 
            this.clmProcedence.HeaderText = "";
            this.clmProcedence.Name = "clmProcedence";
            this.clmProcedence.ReadOnly = true;
            this.clmProcedence.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod. Pallet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Película:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbCustomer);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCore);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbDiameter);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbFilm);
            this.groupBox1.Controls.Add(this.cmbPalletCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 85);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportExcel.Location = new System.Drawing.Point(912, 54);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExportExcel.TabIndex = 22;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(878, 24);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(831, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado:";
            // 
            // button2
            // 
            this.button2.Image = global::BPS.Properties.Resources.funnel_clear;
            this.button2.Location = new System.Drawing.Point(974, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BPS.Properties.Resources.funnel;
            this.button1.Location = new System.Drawing.Point(943, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(630, 25);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(196, 21);
            this.cmbCustomer.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cliente:";
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(516, 25);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(63, 21);
            this.cmbOrder.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pedido:";
            // 
            // cmbCore
            // 
            this.cmbCore.FormattingEnabled = true;
            this.cmbCore.Location = new System.Drawing.Point(433, 24);
            this.cmbCore.Name = "cmbCore";
            this.cmbCore.Size = new System.Drawing.Size(30, 21);
            this.cmbCore.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Core:";
            // 
            // cmbDiameter
            // 
            this.cmbDiameter.FormattingEnabled = true;
            this.cmbDiameter.Location = new System.Drawing.Point(357, 24);
            this.cmbDiameter.Name = "cmbDiameter";
            this.cmbDiameter.Size = new System.Drawing.Size(35, 21);
            this.cmbDiameter.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Diam.:";
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(234, 25);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(78, 21);
            this.cmbFilm.TabIndex = 6;
            // 
            // cmbPalletCode
            // 
            this.cmbPalletCode.FormattingEnabled = true;
            this.cmbPalletCode.Location = new System.Drawing.Point(80, 25);
            this.cmbPalletCode.Name = "cmbPalletCode";
            this.cmbPalletCode.Size = new System.Drawing.Size(96, 21);
            this.cmbPalletCode.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDate);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Location = new System.Drawing.Point(6, 466);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1009, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(843, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha:";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(889, 21);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(106, 20);
            this.txtDate.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(751, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmAymasDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAymasDepot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAymasDepot";
            this.Text = "Depósito Aymas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAymasDepot)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAymasDepot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDiameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.ComboBox cmbPalletCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustommer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmState;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcedence;
        private System.Windows.Forms.Button btnExportExcel;
    }
}