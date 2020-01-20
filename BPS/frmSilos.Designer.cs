namespace BPS
{
    partial class frmSilos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSilos));
            this.dgvstocksilos = new System.Windows.Forms.DataGridView();
            this.clmSilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmChange = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaterialSelector = new System.Windows.Forms.ComboBox();
            this.lblMaterialSelector = new System.Windows.Forms.Label();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.txtSelectedSilo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstocksilos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstocksilos
            // 
            this.dgvstocksilos.AllowUserToAddRows = false;
            this.dgvstocksilos.AllowUserToDeleteRows = false;
            this.dgvstocksilos.AllowUserToOrderColumns = true;
            this.dgvstocksilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstocksilos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSilo,
            this.clmRawMaterial,
            this.clmQuantity,
            this.clmChange});
            this.dgvstocksilos.Location = new System.Drawing.Point(21, 60);
            this.dgvstocksilos.Name = "dgvstocksilos";
            this.dgvstocksilos.Size = new System.Drawing.Size(443, 318);
            this.dgvstocksilos.TabIndex = 0;
            this.dgvstocksilos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstocksilos_CellContentClick);
            // 
            // clmSilo
            // 
            this.clmSilo.HeaderText = "Silo";
            this.clmSilo.Name = "clmSilo";
            this.clmSilo.Width = 50;
            // 
            // clmRawMaterial
            // 
            this.clmRawMaterial.HeaderText = "Materia Prima";
            this.clmRawMaterial.Name = "clmRawMaterial";
            this.clmRawMaterial.Width = 200;
            // 
            // clmQuantity
            // 
            this.clmQuantity.HeaderText = "Cantidad";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmChange
            // 
            this.clmChange.HeaderText = "";
            this.clmChange.Name = "clmChange";
            this.clmChange.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmChange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmChange.Width = 30;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(385, 24);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(31, 27);
            this.btnExcel.TabIndex = 1;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock en silos:";
            // 
            // cmbMaterialSelector
            // 
            this.cmbMaterialSelector.FormattingEnabled = true;
            this.cmbMaterialSelector.Location = new System.Drawing.Point(91, 182);
            this.cmbMaterialSelector.Name = "cmbMaterialSelector";
            this.cmbMaterialSelector.Size = new System.Drawing.Size(295, 21);
            this.cmbMaterialSelector.TabIndex = 3;
            this.cmbMaterialSelector.Visible = false;
            // 
            // lblMaterialSelector
            // 
            this.lblMaterialSelector.AutoSize = true;
            this.lblMaterialSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialSelector.Location = new System.Drawing.Point(88, 162);
            this.lblMaterialSelector.Name = "lblMaterialSelector";
            this.lblMaterialSelector.Size = new System.Drawing.Size(150, 17);
            this.lblMaterialSelector.TabIndex = 4;
            this.lblMaterialSelector.Text = "Seleccione el material:";
            this.lblMaterialSelector.Visible = false;
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(167, 230);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(147, 30);
            this.btnSaveChange.TabIndex = 5;
            this.btnSaveChange.Text = "Guardar";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Visible = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // txtSelectedSilo
            // 
            this.txtSelectedSilo.Location = new System.Drawing.Point(91, 126);
            this.txtSelectedSilo.Name = "txtSelectedSilo";
            this.txtSelectedSilo.ReadOnly = true;
            this.txtSelectedSilo.Size = new System.Drawing.Size(295, 20);
            this.txtSelectedSilo.TabIndex = 6;
            this.txtSelectedSilo.Visible = false;
            // 
            // frmSilos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 427);
            this.Controls.Add(this.txtSelectedSilo);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.lblMaterialSelector);
            this.Controls.Add(this.cmbMaterialSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvstocksilos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSilos";
            this.Text = "Stock de Materia Prima en Silos";
            this.Load += new System.EventHandler(this.frmSilos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstocksilos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstocksilos;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewImageColumn clmChange;
        private System.Windows.Forms.ComboBox cmbMaterialSelector;
        private System.Windows.Forms.Label lblMaterialSelector;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.TextBox txtSelectedSilo;
    }
}