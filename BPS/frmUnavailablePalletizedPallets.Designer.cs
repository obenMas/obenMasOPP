namespace BPS
{
    partial class frmUnavailablePalletizedPallets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUnavailablePalletizedPallets));
            this.tbcCampana = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalNetWeightC = new System.Windows.Forms.TextBox();
            this.btnExportC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCampana = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPilar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNetWeightP = new System.Windows.Forms.TextBox();
            this.btnExportP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPilar = new System.Windows.Forms.DataGridView();
            this.clmCodsecPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCodePL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigthPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidthPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameterPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellarPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDatePL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCampana.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampana)).BeginInit();
            this.tbcPilar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCampana
            // 
            this.tbcCampana.Controls.Add(this.tabPage1);
            this.tbcCampana.Controls.Add(this.tbcPilar);
            this.tbcCampana.Location = new System.Drawing.Point(2, 0);
            this.tbcCampana.Name = "tbcCampana";
            this.tbcCampana.SelectedIndex = 0;
            this.tbcCampana.Size = new System.Drawing.Size(806, 409);
            this.tbcCampana.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgvCampana);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Campana";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalNetWeightC);
            this.groupBox2.Controls.Add(this.btnExportC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(789, 53);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // txtTotalNetWeightC
            // 
            this.txtTotalNetWeightC.Location = new System.Drawing.Point(662, 19);
            this.txtTotalNetWeightC.Name = "txtTotalNetWeightC";
            this.txtTotalNetWeightC.Size = new System.Drawing.Size(91, 20);
            this.txtTotalNetWeightC.TabIndex = 15;
            // 
            // btnExportC
            // 
            this.btnExportC.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportC.Location = new System.Drawing.Point(759, 14);
            this.btnExportC.Name = "btnExportC";
            this.btnExportC.Size = new System.Drawing.Size(25, 25);
            this.btnExportC.TabIndex = 19;
            this.btnExportC.UseVisualStyleBackColor = true;
            this.btnExportC.Click += new System.EventHandler(this.btnExportC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total:";
            // 
            // dgvCampana
            // 
            this.dgvCampana.AllowUserToAddRows = false;
            this.dgvCampana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPalletCode,
            this.clmNetWeigth,
            this.clmWidth,
            this.clmDiameter,
            this.clmCellar,
            this.clmCreatedDate});
            this.dgvCampana.Location = new System.Drawing.Point(3, 3);
            this.dgvCampana.Name = "dgvCampana";
            this.dgvCampana.Size = new System.Drawing.Size(791, 317);
            this.dgvCampana.TabIndex = 0;
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Pedido";
            this.clmCodsec.Name = "clmCodsec";
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Pallet";
            this.clmPalletCode.Name = "clmPalletCode";
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            // 
            // clmDiameter
            // 
            this.clmDiameter.HeaderText = "Diametro";
            this.clmDiameter.Name = "clmDiameter";
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Bodega";
            this.clmCellar.Name = "clmCellar";
            // 
            // clmCreatedDate
            // 
            this.clmCreatedDate.HeaderText = "Fecha Creacion Pallet";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.Width = 140;
            // 
            // tbcPilar
            // 
            this.tbcPilar.Controls.Add(this.groupBox1);
            this.tbcPilar.Controls.Add(this.dgvPilar);
            this.tbcPilar.Location = new System.Drawing.Point(4, 22);
            this.tbcPilar.Name = "tbcPilar";
            this.tbcPilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbcPilar.Size = new System.Drawing.Size(798, 383);
            this.tbcPilar.TabIndex = 1;
            this.tbcPilar.Text = "Pilar";
            this.tbcPilar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNetWeightP);
            this.groupBox1.Controls.Add(this.btnExportP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 53);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // txtNetWeightP
            // 
            this.txtNetWeightP.Location = new System.Drawing.Point(663, 19);
            this.txtNetWeightP.Name = "txtNetWeightP";
            this.txtNetWeightP.Size = new System.Drawing.Size(91, 20);
            this.txtNetWeightP.TabIndex = 17;
            // 
            // btnExportP
            // 
            this.btnExportP.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportP.Location = new System.Drawing.Point(760, 14);
            this.btnExportP.Name = "btnExportP";
            this.btnExportP.Size = new System.Drawing.Size(25, 25);
            this.btnExportP.TabIndex = 18;
            this.btnExportP.UseVisualStyleBackColor = true;
            this.btnExportP.Click += new System.EventHandler(this.btnExportP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total:";
            // 
            // dgvPilar
            // 
            this.dgvPilar.AllowUserToAddRows = false;
            this.dgvPilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPilar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecPL,
            this.clmPalletCodePL,
            this.clmNetWeigthPL,
            this.clmWidthPL,
            this.clmDiameterPL,
            this.clmCellarPL,
            this.clmCreatedDatePL});
            this.dgvPilar.Location = new System.Drawing.Point(3, 3);
            this.dgvPilar.Name = "dgvPilar";
            this.dgvPilar.Size = new System.Drawing.Size(791, 317);
            this.dgvPilar.TabIndex = 0;
            // 
            // clmCodsecPL
            // 
            this.clmCodsecPL.HeaderText = "Pedido";
            this.clmCodsecPL.Name = "clmCodsecPL";
            // 
            // clmPalletCodePL
            // 
            this.clmPalletCodePL.HeaderText = "Pallet";
            this.clmPalletCodePL.Name = "clmPalletCodePL";
            // 
            // clmNetWeigthPL
            // 
            this.clmNetWeigthPL.HeaderText = "Peso Neto";
            this.clmNetWeigthPL.Name = "clmNetWeigthPL";
            // 
            // clmWidthPL
            // 
            this.clmWidthPL.HeaderText = "Ancho";
            this.clmWidthPL.Name = "clmWidthPL";
            // 
            // clmDiameterPL
            // 
            this.clmDiameterPL.HeaderText = "Diametro";
            this.clmDiameterPL.Name = "clmDiameterPL";
            // 
            // clmCellarPL
            // 
            this.clmCellarPL.HeaderText = "Bodega";
            this.clmCellarPL.Name = "clmCellarPL";
            // 
            // clmCreatedDatePL
            // 
            this.clmCreatedDatePL.HeaderText = "Fecha Creacion Pallet";
            this.clmCreatedDatePL.Name = "clmCreatedDatePL";
            this.clmCreatedDatePL.Width = 140;
            // 
            // frmUnavailablePalletizedPallets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 408);
            this.Controls.Add(this.tbcCampana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUnavailablePalletizedPallets";
            this.Text = "Paletizado no disponible";
            this.tbcCampana.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampana)).EndInit();
            this.tbcPilar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCampana;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbcPilar;
        private System.Windows.Forms.DataGridView dgvCampana;
        private System.Windows.Forms.DataGridView dgvPilar;
        private System.Windows.Forms.TextBox txtTotalNetWeightC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNetWeightP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportC;
        private System.Windows.Forms.Button btnExportP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCodePL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigthPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidthPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameterPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellarPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDatePL;
    }
}