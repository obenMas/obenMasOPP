namespace BPS
{
    partial class frmMBProductionDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMBProductionDetail));
            this.label88 = new System.Windows.Forms.Label();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.clmPlanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRawMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmScrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(72, 26);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(40, 13);
            this.label88.TabIndex = 13;
            this.label88.Text = "Planta:";
            // 
            // cmbPlant
            // 
            this.cmbPlant.Enabled = false;
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(121, 21);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(214, 21);
            this.cmbPlant.TabIndex = 12;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(77, 97);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(38, 13);
            this.label87.TabIndex = 11;
            this.label87.Text = "Hasta:";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(74, 62);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(41, 13);
            this.label83.TabIndex = 10;
            this.label83.Text = "Desde:";
            // 
            // dtpTo
            // 
            this.dtpTo.Enabled = false;
            this.dtpTo.Location = new System.Drawing.Point(121, 95);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(279, 20);
            this.dtpTo.TabIndex = 9;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Enabled = false;
            this.dtpFrom.Location = new System.Drawing.Point(121, 60);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(279, 20);
            this.dtpFrom.TabIndex = 8;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPlanta,
            this.clmExtruder,
            this.clmFilm,
            this.clmRawMaterial,
            this.clmScrap,
            this.clmWeigth});
            this.dgv.Location = new System.Drawing.Point(12, 132);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(467, 349);
            this.dgv.TabIndex = 14;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.Location = new System.Drawing.Point(358, 18);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(42, 33);
            this.btnExcel.TabIndex = 15;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Total [T]:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(379, 497);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clmPlanta
            // 
            this.clmPlanta.HeaderText = "Planta";
            this.clmPlanta.Name = "clmPlanta";
            this.clmPlanta.ReadOnly = true;
            this.clmPlanta.Width = 62;
            // 
            // clmExtruder
            // 
            this.clmExtruder.HeaderText = "Extrusora";
            this.clmExtruder.Name = "clmExtruder";
            this.clmExtruder.ReadOnly = true;
            this.clmExtruder.Width = 76;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pelicula";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            this.clmFilm.Width = 69;
            // 
            // clmRawMaterial
            // 
            this.clmRawMaterial.HeaderText = "Materia Prima";
            this.clmRawMaterial.Name = "clmRawMaterial";
            this.clmRawMaterial.ReadOnly = true;
            this.clmRawMaterial.Width = 96;
            // 
            // clmScrap
            // 
            this.clmScrap.HeaderText = "Scrap";
            this.clmScrap.Name = "clmScrap";
            this.clmScrap.ReadOnly = true;
            this.clmScrap.Visible = false;
            this.clmScrap.Width = 60;
            // 
            // clmWeigth
            // 
            this.clmWeigth.HeaderText = "Subtotal [T]";
            this.clmWeigth.Name = "clmWeigth";
            this.clmWeigth.ReadOnly = true;
            this.clmWeigth.Width = 87;
            // 
            // frmMBProductionDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(494, 528);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label88);
            this.Controls.Add(this.cmbPlant);
            this.Controls.Add(this.label87);
            this.Controls.Add(this.label83);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMBProductionDetail";
            this.Text = "Detalle de producción entre fechas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRawMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmScrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeigth;
    }
}