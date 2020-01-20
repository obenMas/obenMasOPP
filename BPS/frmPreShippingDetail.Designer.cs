namespace BPS
{
    partial class frmPreShippingDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreShippingDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPDInput = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dgvPDetail = new System.Windows.Forms.DataGridView();
            this.clmPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRemito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPDInput);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pre-Despacho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Pre-Despacho";
            // 
            // txtPDInput
            // 
            this.txtPDInput.Location = new System.Drawing.Point(266, 29);
            this.txtPDInput.Name = "txtPDInput";
            this.txtPDInput.Size = new System.Drawing.Size(147, 20);
            this.txtPDInput.TabIndex = 0;
            this.txtPDInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPDInput_KeyDown);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(515, 19);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(75, 36);
            this.btnExcel.TabIndex = 2;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dgvPDetail
            // 
            this.dgvPDetail.AllowUserToAddRows = false;
            this.dgvPDetail.AllowUserToDeleteRows = false;
            this.dgvPDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPallet,
            this.clmCoil,
            this.clmProduct,
            this.clmRemito,
            this.clmLote,
            this.clmPlanta});
            this.dgvPDetail.Location = new System.Drawing.Point(4, 80);
            this.dgvPDetail.Name = "dgvPDetail";
            this.dgvPDetail.ReadOnly = true;
            this.dgvPDetail.Size = new System.Drawing.Size(642, 441);
            this.dgvPDetail.TabIndex = 2;
            // 
            // clmPallet
            // 
            this.clmPallet.HeaderText = "Pallet";
            this.clmPallet.Name = "clmPallet";
            this.clmPallet.ReadOnly = true;
            this.clmPallet.Width = 58;
            // 
            // clmCoil
            // 
            this.clmCoil.HeaderText = "Bobina";
            this.clmCoil.Name = "clmCoil";
            this.clmCoil.ReadOnly = true;
            this.clmCoil.Width = 65;
            // 
            // clmProduct
            // 
            this.clmProduct.HeaderText = "Producto";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            this.clmProduct.Width = 75;
            // 
            // clmRemito
            // 
            this.clmRemito.HeaderText = "Remito";
            this.clmRemito.Name = "clmRemito";
            this.clmRemito.ReadOnly = true;
            this.clmRemito.Width = 65;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 53;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            this.clmPlanta.Width = 62;
            // 
            // frmPreShippingDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 523);
            this.Controls.Add(this.dgvPDetail);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPreShippingDetail";
            this.Text = "Detalle de Pre-Despacho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPDInput;
        private System.Windows.Forms.DataGridView dgvPDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRemito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.Button btnExcel;
    }
}