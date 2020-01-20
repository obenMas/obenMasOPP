namespace BPS
{
    partial class frmDeliveredQuantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeliveredQuantity));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbcCampana = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalNetWeightC = new System.Windows.Forms.TextBox();
            this.btnExportC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDeliveredQuantityC = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDiameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmModifiedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcPilar = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNetWeightP = new System.Windows.Forms.TextBox();
            this.btnExportP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeliveredQuantityPL = new System.Windows.Forms.DataGridView();
            this.clmCodsecPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemitPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilmPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigthPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDatePL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tbcCampana.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveredQuantityC)).BeginInit();
            this.tbcPilar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveredQuantityPL)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbcCampana);
            this.tabControl1.Controls.Add(this.tbcPilar);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tbcCampana
            // 
            this.tbcCampana.Controls.Add(this.groupBox2);
            this.tbcCampana.Controls.Add(this.dgvDeliveredQuantityC);
            this.tbcCampana.Location = new System.Drawing.Point(4, 22);
            this.tbcCampana.Name = "tbcCampana";
            this.tbcCampana.Padding = new System.Windows.Forms.Padding(3);
            this.tbcCampana.Size = new System.Drawing.Size(578, 383);
            this.tbcCampana.TabIndex = 0;
            this.tbcCampana.Text = "Campana";
            this.tbcCampana.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalNetWeightC);
            this.groupBox2.Controls.Add(this.btnExportC);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 53);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // txtTotalNetWeightC
            // 
            this.txtTotalNetWeightC.Location = new System.Drawing.Point(417, 19);
            this.txtTotalNetWeightC.Name = "txtTotalNetWeightC";
            this.txtTotalNetWeightC.Size = new System.Drawing.Size(91, 20);
            this.txtTotalNetWeightC.TabIndex = 15;
            // 
            // btnExportC
            // 
            this.btnExportC.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportC.Location = new System.Drawing.Point(514, 14);
            this.btnExportC.Name = "btnExportC";
            this.btnExportC.Size = new System.Drawing.Size(25, 25);
            this.btnExportC.TabIndex = 19;
            this.btnExportC.UseVisualStyleBackColor = true;
            this.btnExportC.Click += new System.EventHandler(this.btnExportC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total:";
            // 
            // dgvDeliveredQuantityC
            // 
            this.dgvDeliveredQuantityC.AllowUserToAddRows = false;
            this.dgvDeliveredQuantityC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveredQuantityC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPalletCode,
            this.clmNetWeigth,
            this.clmWidth,
            this.clmDiameter,
            this.clmModifiedDate});
            this.dgvDeliveredQuantityC.Location = new System.Drawing.Point(4, 0);
            this.dgvDeliveredQuantityC.Name = "dgvDeliveredQuantityC";
            this.dgvDeliveredQuantityC.Size = new System.Drawing.Size(571, 317);
            this.dgvDeliveredQuantityC.TabIndex = 0;
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
            // clmModifiedDate
            // 
            this.clmModifiedDate.HeaderText = "Fecha Despacho";
            this.clmModifiedDate.Name = "clmModifiedDate";
            // 
            // tbcPilar
            // 
            this.tbcPilar.Controls.Add(this.groupBox1);
            this.tbcPilar.Controls.Add(this.dgvDeliveredQuantityPL);
            this.tbcPilar.Location = new System.Drawing.Point(4, 22);
            this.tbcPilar.Name = "tbcPilar";
            this.tbcPilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbcPilar.Size = new System.Drawing.Size(578, 383);
            this.tbcPilar.TabIndex = 1;
            this.tbcPilar.Text = "Pilar";
            this.tbcPilar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNetWeightP);
            this.groupBox1.Controls.Add(this.btnExportP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 317);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // txtNetWeightP
            // 
            this.txtNetWeightP.Location = new System.Drawing.Point(416, 19);
            this.txtNetWeightP.Name = "txtNetWeightP";
            this.txtNetWeightP.Size = new System.Drawing.Size(91, 20);
            this.txtNetWeightP.TabIndex = 17;
            // 
            // btnExportP
            // 
            this.btnExportP.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExportP.Location = new System.Drawing.Point(513, 14);
            this.btnExportP.Name = "btnExportP";
            this.btnExportP.Size = new System.Drawing.Size(25, 25);
            this.btnExportP.TabIndex = 18;
            this.btnExportP.UseVisualStyleBackColor = true;
            this.btnExportP.Click += new System.EventHandler(this.btnExportP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total:";
            // 
            // dgvDeliveredQuantityPL
            // 
            this.dgvDeliveredQuantityPL.AllowUserToAddRows = false;
            this.dgvDeliveredQuantityPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveredQuantityPL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecPL,
            this.clmRemitPL,
            this.clmFilmPL,
            this.clmNetWeigthPL,
            this.clmCreatedDatePL});
            this.dgvDeliveredQuantityPL.Location = new System.Drawing.Point(4, 0);
            this.dgvDeliveredQuantityPL.Name = "dgvDeliveredQuantityPL";
            this.dgvDeliveredQuantityPL.Size = new System.Drawing.Size(571, 317);
            this.dgvDeliveredQuantityPL.TabIndex = 0;
            // 
            // clmCodsecPL
            // 
            this.clmCodsecPL.HeaderText = "Pedido";
            this.clmCodsecPL.Name = "clmCodsecPL";
            // 
            // clmRemitPL
            // 
            this.clmRemitPL.HeaderText = "Remito";
            this.clmRemitPL.Name = "clmRemitPL";
            // 
            // clmFilmPL
            // 
            this.clmFilmPL.HeaderText = "Pelicula";
            this.clmFilmPL.Name = "clmFilmPL";
            this.clmFilmPL.Width = 150;
            // 
            // clmNetWeigthPL
            // 
            this.clmNetWeigthPL.HeaderText = "Cantidad Entregada";
            this.clmNetWeigthPL.Name = "clmNetWeigthPL";
            // 
            // clmCreatedDatePL
            // 
            this.clmCreatedDatePL.HeaderText = "Fecha";
            this.clmCreatedDatePL.Name = "clmCreatedDatePL";
            // 
            // frmDeliveredQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 408);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDeliveredQuantity";
            this.Text = "Cantidad Entregada";
            this.tabControl1.ResumeLayout(false);
            this.tbcCampana.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveredQuantityC)).EndInit();
            this.tbcPilar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveredQuantityPL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbcCampana;
        private System.Windows.Forms.TabPage tbcPilar;
        private System.Windows.Forms.DataGridView dgvDeliveredQuantityC;
        private System.Windows.Forms.DataGridView dgvDeliveredQuantityPL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTotalNetWeightC;
        private System.Windows.Forms.Button btnExportC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNetWeightP;
        private System.Windows.Forms.Button btnExportP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDiameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmModifiedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemitPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilmPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigthPL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDatePL;
    }
}