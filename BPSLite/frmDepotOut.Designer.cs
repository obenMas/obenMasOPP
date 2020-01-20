namespace BPS.Lite
{
    partial class frmDepotOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepotOut));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepotOut = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCoilCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepotOut)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPallet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 39);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPallet
            // 
            this.txtPallet.Location = new System.Drawing.Point(63, 12);
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Size = new System.Drawing.Size(370, 20);
            this.txtPallet.TabIndex = 1;
            this.txtPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPallet_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pallet:";
            // 
            // dgvDepotOut
            // 
            this.dgvDepotOut.AllowUserToAddRows = false;
            this.dgvDepotOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepotOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmNetWeigth,
            this.clmGrossWeigth,
            this.clmfkCoilCellar,
            this.clmCellar,
            this.clmDelete});
            this.dgvDepotOut.Location = new System.Drawing.Point(4, 44);
            this.dgvDepotOut.Name = "dgvDepotOut";
            this.dgvDepotOut.Size = new System.Drawing.Size(560, 98);
            this.dgvDepotOut.TabIndex = 1;
            this.dgvDepotOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepotOut_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.Width = 200;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.Width = 60;
            // 
            // clmGrossWeigth
            // 
            this.clmGrossWeigth.HeaderText = "Peso Bruto";
            this.clmGrossWeigth.Name = "clmGrossWeigth";
            this.clmGrossWeigth.Width = 60;
            // 
            // clmfkCoilCellar
            // 
            this.clmfkCoilCellar.HeaderText = "";
            this.clmfkCoilCellar.Name = "clmfkCoilCellar";
            this.clmfkCoilCellar.Visible = false;
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Egresará a:";
            this.clmCellar.Name = "clmCellar";
            this.clmCellar.Width = 140;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::BPS.Lite.Properties.Resources.action_delete_sharp_thin;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.Width = 50;
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(249, 148);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Egresar";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmDepotOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 178);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.dgvDepotOut);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepotOut";
            this.Text = "Egreso del depósito";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepotOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDepotOut;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.TextBox txtPallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCoilCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}