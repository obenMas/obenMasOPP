namespace BPS.Lite
{
    partial class frmCoilsWhitoutPallets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilsWhitoutPallets));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCoilsWithoutPallets = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCellar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbCustommer = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmbCode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustommer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsefulwidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsWithoutPallets)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCoilsWithoutPallets);
            this.groupBox1.Location = new System.Drawing.Point(2, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvCoilsWithoutPallets
            // 
            this.dgvCoilsWithoutPallets.AllowUserToAddRows = false;
            this.dgvCoilsWithoutPallets.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCoilsWithoutPallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilsWithoutPallets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmProduct,
            this.clmCustommer,
            this.clmOrder,
            this.clmNetWeight,
            this.clmQuality,
            this.clmCutDate,
            this.clmCellar,
            this.clmPlant,
            this.clmDestination,
            this.clmProcess,
            this.clmUsefulwidth,
            this.clmDetail});
            this.dgvCoilsWithoutPallets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoilsWithoutPallets.Location = new System.Drawing.Point(3, 16);
            this.dgvCoilsWithoutPallets.Name = "dgvCoilsWithoutPallets";
            this.dgvCoilsWithoutPallets.Size = new System.Drawing.Size(996, 405);
            this.dgvCoilsWithoutPallets.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbPlant);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbCellar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Controls.Add(this.btnClearFilter);
            this.groupBox2.Controls.Add(this.cmbQuality);
            this.groupBox2.Controls.Add(this.cmbOrder);
            this.groupBox2.Controls.Add(this.cmbCustommer);
            this.groupBox2.Controls.Add(this.cmbProduct);
            this.groupBox2.Controls.Add(this.cmbCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 79);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(628, 52);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(307, 21);
            this.cmbPlant.TabIndex = 19;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged);
            this.cmbPlant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPlant_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(579, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Planta:";
            // 
            // cmbCellar
            // 
            this.cmbCellar.FormattingEnabled = true;
            this.cmbCellar.Location = new System.Drawing.Point(249, 53);
            this.cmbCellar.Name = "cmbCellar";
            this.cmbCellar.Size = new System.Drawing.Size(299, 21);
            this.cmbCellar.TabIndex = 17;
            this.cmbCellar.SelectedIndexChanged += new System.EventHandler(this.cmbCellar_SelectedIndexChanged);
            this.cmbCellar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCellar_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Bodega:";
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(963, 48);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 13;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Image = global::BPS.Lite.Properties.Resources.funnel_clear;
            this.btnClearFilter.Location = new System.Drawing.Point(963, 14);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(25, 25);
            this.btnClearFilter.TabIndex = 12;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // cmbQuality
            // 
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(61, 51);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(121, 21);
            this.cmbQuality.TabIndex = 11;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            this.cmbQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbQuality_KeyDown);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(850, 17);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(85, 21);
            this.cmbOrder.TabIndex = 9;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // cmbCustommer
            // 
            this.cmbCustommer.FormattingEnabled = true;
            this.cmbCustommer.Location = new System.Drawing.Point(498, 17);
            this.cmbCustommer.Name = "cmbCustommer";
            this.cmbCustommer.Size = new System.Drawing.Size(259, 21);
            this.cmbCustommer.TabIndex = 8;
            this.cmbCustommer.SelectedIndexChanged += new System.EventHandler(this.cmbCustommer_SelectedIndexChanged);
            this.cmbCustommer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustommer_KeyDown);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(301, 17);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 21);
            this.cmbProduct.TabIndex = 7;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            this.cmbProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbProduct_KeyDown);
            // 
            // cmbCode
            // 
            this.cmbCode.FormattingEnabled = true;
            this.cmbCode.Location = new System.Drawing.Point(59, 17);
            this.cmbCode.Name = "cmbCode";
            this.cmbCode.Size = new System.Drawing.Size(167, 21);
            this.cmbCode.TabIndex = 6;
            this.cmbCode.SelectedIndexChanged += new System.EventHandler(this.cmbCode_SelectedIndexChanged);
            this.cmbCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCode_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Calidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pedido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Codigo";
            this.clmCode.Name = "clmCode";
            this.clmCode.Width = 180;
            // 
            // clmProduct
            // 
            this.clmProduct.HeaderText = "Producto";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.Width = 120;
            // 
            // clmCustommer
            // 
            this.clmCustommer.HeaderText = "Cliente";
            this.clmCustommer.Name = "clmCustommer";
            this.clmCustommer.Width = 130;
            // 
            // clmOrder
            // 
            this.clmOrder.HeaderText = "Pedido";
            this.clmOrder.Name = "clmOrder";
            this.clmOrder.Width = 60;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "PesoNeto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.Width = 60;
            // 
            // clmQuality
            // 
            this.clmQuality.HeaderText = "Calidad";
            this.clmQuality.Name = "clmQuality";
            this.clmQuality.Width = 70;
            // 
            // clmCutDate
            // 
            this.clmCutDate.HeaderText = "FechaCorte";
            this.clmCutDate.Name = "clmCutDate";
            this.clmCutDate.Width = 80;
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Bodega";
            this.clmCellar.Name = "clmCellar";
            this.clmCellar.Visible = false;
            this.clmCellar.Width = 185;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.Visible = false;
            this.clmPlant.Width = 60;
            // 
            // clmDestination
            // 
            this.clmDestination.HeaderText = "Destino";
            this.clmDestination.Name = "clmDestination";
            this.clmDestination.Width = 80;
            // 
            // clmProcess
            // 
            this.clmProcess.HeaderText = "Reproceso";
            this.clmProcess.Name = "clmProcess";
            this.clmProcess.Width = 80;
            // 
            // clmUsefulwidth
            // 
            this.clmUsefulwidth.HeaderText = "AnchoUtil";
            this.clmUsefulwidth.Name = "clmUsefulwidth";
            this.clmUsefulwidth.Width = 70;
            // 
            // clmDetail
            // 
            this.clmDetail.HeaderText = "Observación";
            this.clmDetail.Name = "clmDetail";
            this.clmDetail.Width = 80;
            // 
            // frmCoilsWhitoutPallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilsWhitoutPallets";
            this.Text = "Inventario de bobinas sueltas";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilsWithoutPallets)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCoilsWithoutPallets;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbCustommer;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmbCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.ComboBox cmbCellar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustommer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsefulwidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDetail;
    }
}