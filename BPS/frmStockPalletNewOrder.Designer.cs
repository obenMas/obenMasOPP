namespace BPS
{
    partial class frmStockPalletNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStockPalletNewOrder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStockPallet = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTotalCheked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPallet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStockPallet);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvStockPallet
            // 
            this.dgvStockPallet.AllowUserToAddRows = false;
            this.dgvStockPallet.AllowUserToDeleteRows = false;
            this.dgvStockPallet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockPallet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmPalletCode,
            this.clmPalletNetWeight,
            this.clmPalletCreateDate,
            this.clmPalletCheck});
            this.dgvStockPallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockPallet.Location = new System.Drawing.Point(3, 16);
            this.dgvStockPallet.Name = "dgvStockPallet";
            this.dgvStockPallet.Size = new System.Drawing.Size(642, 211);
            this.dgvStockPallet.TabIndex = 0;
            this.dgvStockPallet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStockPallet_CellContentClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "Codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmPalletCode
            // 
            this.clmPalletCode.HeaderText = "Código";
            this.clmPalletCode.Name = "clmPalletCode";
            this.clmPalletCode.ReadOnly = true;
            // 
            // clmPalletNetWeight
            // 
            this.clmPalletNetWeight.HeaderText = "Peso Neto";
            this.clmPalletNetWeight.Name = "clmPalletNetWeight";
            this.clmPalletNetWeight.ReadOnly = true;
            // 
            // clmPalletCreateDate
            // 
            this.clmPalletCreateDate.HeaderText = "Fecha de Creación";
            this.clmPalletCreateDate.Name = "clmPalletCreateDate";
            this.clmPalletCreateDate.ReadOnly = true;
            this.clmPalletCreateDate.Width = 200;
            // 
            // clmPalletCheck
            // 
            this.clmPalletCheck.HeaderText = "";
            this.clmPalletCheck.Name = "clmPalletCheck";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.txtTotalCheked);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(5, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::BPS.Properties.Resources.disk;
            this.btnSave.Location = new System.Drawing.Point(562, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTotalCheked
            // 
            this.txtTotalCheked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCheked.Location = new System.Drawing.Point(67, 23);
            this.txtTotalCheked.Name = "txtTotalCheked";
            this.txtTotalCheked.ReadOnly = true;
            this.txtTotalCheked.Size = new System.Drawing.Size(157, 26);
            this.txtTotalCheked.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // frmStockPalletNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStockPalletNewOrder";
            this.Text = "Stock de Pallets";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockPallet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStockPallet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtTotalCheked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletCreateDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmPalletCheck;
    }
}