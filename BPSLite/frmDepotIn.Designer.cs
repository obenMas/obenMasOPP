namespace BPS.Lite
{
    partial class frmDepotIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepotIn));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGrossWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkCoilCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCellar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPositionChange = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMovementType = new System.Windows.Forms.ComboBox();
            this.txtPallet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmCode,
            this.clmNetWeigth,
            this.clmGrossWeigth,
            this.clmPosition,
            this.clmfkCoilCellar,
            this.clmCellar,
            this.clmPositionChange,
            this.clmDelete});
            this.dataGridView1.Location = new System.Drawing.Point(4, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(572, 111);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmCode
            // 
            this.clmCode.HeaderText = "Pallet";
            this.clmCode.Name = "clmCode";
            this.clmCode.ReadOnly = true;
            this.clmCode.Width = 200;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.ReadOnly = true;
            this.clmNetWeigth.Width = 60;
            // 
            // clmGrossWeigth
            // 
            this.clmGrossWeigth.HeaderText = "Peso Bruto";
            this.clmGrossWeigth.Name = "clmGrossWeigth";
            this.clmGrossWeigth.ReadOnly = true;
            this.clmGrossWeigth.Width = 60;
            // 
            // clmPosition
            // 
            this.clmPosition.HeaderText = "Posición";
            this.clmPosition.Name = "clmPosition";
            this.clmPosition.ReadOnly = true;
            this.clmPosition.Width = 60;
            // 
            // clmfkCoilCellar
            // 
            this.clmfkCoilCellar.HeaderText = "";
            this.clmfkCoilCellar.Name = "clmfkCoilCellar";
            this.clmfkCoilCellar.ReadOnly = true;
            this.clmfkCoilCellar.Visible = false;
            // 
            // clmCellar
            // 
            this.clmCellar.HeaderText = "Ingresará a:";
            this.clmCellar.Name = "clmCellar";
            this.clmCellar.ReadOnly = true;
            this.clmCellar.Width = 140;
            // 
            // clmPositionChange
            // 
            this.clmPositionChange.HeaderText = "";
            this.clmPositionChange.Name = "clmPositionChange";
            this.clmPositionChange.ReadOnly = true;
            this.clmPositionChange.Visible = false;
            // 
            // clmDelete
            // 
            this.clmDelete.HeaderText = "";
            this.clmDelete.Image = global::BPS.Lite.Properties.Resources.action_delete_sharp_thin;
            this.clmDelete.Name = "clmDelete";
            this.clmDelete.ReadOnly = true;
            this.clmDelete.Width = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbMovementType);
            this.groupBox1.Controls.Add(this.txtPallet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPosition);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 54);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tipo de movimiento:";
            // 
            // cmbMovementType
            // 
            this.cmbMovementType.FormattingEnabled = true;
            this.cmbMovementType.Items.AddRange(new object[] {
            "Ingreso pallet",
            "Ingreso bobina colgante",
            "Cambio de posición"});
            this.cmbMovementType.Location = new System.Drawing.Point(376, 27);
            this.cmbMovementType.Name = "cmbMovementType";
            this.cmbMovementType.Size = new System.Drawing.Size(190, 21);
            this.cmbMovementType.TabIndex = 12;
            // 
            // txtPallet
            // 
            this.txtPallet.Location = new System.Drawing.Point(11, 27);
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Size = new System.Drawing.Size(215, 20);
            this.txtPallet.TabIndex = 7;
            this.txtPallet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPallet_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Posición";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(238, 27);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(124, 20);
            this.txtPosition.TabIndex = 8;
            this.txtPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPosition_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pallet";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::BPS.Lite.Properties.Resources.action_delete_sharp_thin;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 30;
            // 
            // frmDepotIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDepotIn";
            this.Text = "Ingreso al depósito";
            this.Shown += new System.EventHandler(this.frmDepotIn_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMovementType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGrossWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkCoilCellar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCellar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmPositionChange;
        private System.Windows.Forms.DataGridViewImageColumn clmDelete;
    }
}