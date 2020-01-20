namespace BPS
{
    partial class frmCalculationMaterialCost
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.clmCodsecMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombreMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsecMaterial,
            this.clmNombreMaterial,
            this.clmTipo,
            this.clmCantidad,
            this.clmStock});
            this.dgv.Location = new System.Drawing.Point(9, 9);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv.Size = new System.Drawing.Size(811, 356);
            this.dgv.TabIndex = 2;
            // 
            // clmCodsecMaterial
            // 
            this.clmCodsecMaterial.HeaderText = "codsecmaterial";
            this.clmCodsecMaterial.Name = "clmCodsecMaterial";
            this.clmCodsecMaterial.Visible = false;
            // 
            // clmNombreMaterial
            // 
            this.clmNombreMaterial.HeaderText = "Nombre del material";
            this.clmNombreMaterial.Name = "clmNombreMaterial";
            this.clmNombreMaterial.Width = 250;
            // 
            // clmTipo
            // 
            this.clmTipo.HeaderText = "Tipo de material";
            this.clmTipo.Name = "clmTipo";
            this.clmTipo.Width = 200;
            // 
            // clmCantidad
            // 
            this.clmCantidad.HeaderText = "Cantidad a utilizar";
            this.clmCantidad.Name = "clmCantidad";
            // 
            // clmStock
            // 
            this.clmStock.HeaderText = "Cantidad en stock";
            this.clmStock.Name = "clmStock";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(782, 371);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(38, 32);
            this.btnExcel.TabIndex = 3;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmCalculationMaterialCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 412);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgv);
            this.Name = "frmCalculationMaterialCost";
            this.ShowIcon = false;
            this.Text = "Consumo estimado de materia prima";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsecMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombreMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.Button btnExcel;
    }
}