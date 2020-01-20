namespace BPS.Lite
{
    partial class frmRawMaterialStockByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialStockByDate));
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMpStock = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.clmMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMpStock)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "*El rack mostrado corresponde a las 00 hs del día selecionado";
            // 
            // dgvMpStock
            // 
            this.dgvMpStock.AllowUserToAddRows = false;
            this.dgvMpStock.AllowUserToDeleteRows = false;
            this.dgvMpStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMpStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMP,
            this.ActualWeight,
            this.clmBodega,
            this.clmPlanta,
            this.clmFecha,
            this.Day,
            this.Month,
            this.Year});
            this.dgvMpStock.Location = new System.Drawing.Point(12, 53);
            this.dgvMpStock.Name = "dgvMpStock";
            this.dgvMpStock.ReadOnly = true;
            this.dgvMpStock.Size = new System.Drawing.Size(618, 391);
            this.dgvMpStock.TabIndex = 14;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(590, 5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(40, 24);
            this.btnExport.TabIndex = 13;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(494, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Planta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fecha*:";
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(331, 7);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanta.TabIndex = 9;
            this.cmbPlanta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbPlanta_KeyUp);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(55, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // clmMP
            // 
            this.clmMP.HeaderText = "Materia Prima";
            this.clmMP.Name = "clmMP";
            this.clmMP.ReadOnly = true;
            // 
            // ActualWeight
            // 
            this.ActualWeight.HeaderText = "Peso";
            this.ActualWeight.Name = "ActualWeight";
            this.ActualWeight.ReadOnly = true;
            // 
            // clmBodega
            // 
            this.clmBodega.HeaderText = "Bodega";
            this.clmBodega.Name = "clmBodega";
            this.clmBodega.ReadOnly = true;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // Day
            // 
            this.Day.HeaderText = "Dia";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Visible = false;
            // 
            // Month
            // 
            this.Month.HeaderText = "Mes";
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Visible = false;
            // 
            // Year
            // 
            this.Year.HeaderText = "Año";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Visible = false;
            // 
            // frmRawMaterialStockByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMpStock);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlanta);
            this.Controls.Add(this.dtpDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialStockByDate";
            this.Text = "Stock de Materias Primas por Fecha.";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMpStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMpStock;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActualWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
    }
}