namespace BPS.Lite
{
    partial class frmRawMaterialSwapReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialSwapReport));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateSwapRp = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbPlanta = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSwapInterplantMatPrima = new System.Windows.Forms.DataGridView();
            this.clmCodigoPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCodigoMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomMateriaPrima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTipoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPesoNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtrusionLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodegaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPalletNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapInterplantMatPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBoxFrom);
            this.groupBox6.Controls.Add(this.groupBox2);
            this.groupBox6.Controls.Add(this.groupBox3);
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(462, 100);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtrar por Fecha";
            // 
            // groupBoxFrom
            // 
            this.groupBoxFrom.Controls.Add(this.lblFrom);
            this.groupBoxFrom.Location = new System.Drawing.Point(6, 19);
            this.groupBoxFrom.Name = "groupBoxFrom";
            this.groupBoxFrom.Size = new System.Drawing.Size(215, 26);
            this.groupBoxFrom.TabIndex = 5;
            this.groupBoxFrom.TabStop = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(3, 7);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(58, 16);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "Desde:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(6, 15);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpHasta);
            this.groupBox3.Location = new System.Drawing.Point(238, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(6, 15);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTo);
            this.groupBox1.Location = new System.Drawing.Point(238, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 26);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(3, 7);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(53, 16);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Hasta:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnGenerateSwapRp);
            this.groupBox5.Controls.Add(this.btnExport);
            this.groupBox5.Controls.Add(this.cmbPlanta);
            this.groupBox5.Location = new System.Drawing.Point(471, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(296, 100);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtrar por Planta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Planta:";
            // 
            // btnGenerateSwapRp
            // 
            this.btnGenerateSwapRp.Location = new System.Drawing.Point(149, 45);
            this.btnGenerateSwapRp.Name = "btnGenerateSwapRp";
            this.btnGenerateSwapRp.Size = new System.Drawing.Size(90, 42);
            this.btnGenerateSwapRp.TabIndex = 2;
            this.btnGenerateSwapRp.Text = "Generar";
            this.btnGenerateSwapRp.UseVisualStyleBackColor = true;
            this.btnGenerateSwapRp.Click += new System.EventHandler(this.btnGenerateSwapRp_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(252, 62);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 12;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbPlanta
            // 
            this.cmbPlanta.FormattingEnabled = true;
            this.cmbPlanta.Location = new System.Drawing.Point(30, 61);
            this.cmbPlanta.Name = "cmbPlanta";
            this.cmbPlanta.Size = new System.Drawing.Size(103, 21);
            this.cmbPlanta.TabIndex = 10;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSwapInterplantMatPrima);
            this.groupBox4.Location = new System.Drawing.Point(3, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(764, 404);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // dgvSwapInterplantMatPrima
            // 
            this.dgvSwapInterplantMatPrima.AllowUserToAddRows = false;
            this.dgvSwapInterplantMatPrima.AllowUserToDeleteRows = false;
            this.dgvSwapInterplantMatPrima.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvSwapInterplantMatPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwapInterplantMatPrima.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigoPallet,
            this.clmCodigoMP,
            this.clmNomMateriaPrima,
            this.clmTipoMov,
            this.clmPesoNeto,
            this.clmLote,
            this.clmExtrusionLote,
            this.clmBodegaOrigen,
            this.clmBodegaDestino,
            this.clmPalletNotes,
            this.clmUser,
            this.clmFecha,
            this.clmDay,
            this.clmMonth,
            this.clmYear,
            this.clmHour});
            this.dgvSwapInterplantMatPrima.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSwapInterplantMatPrima.Location = new System.Drawing.Point(3, 16);
            this.dgvSwapInterplantMatPrima.Name = "dgvSwapInterplantMatPrima";
            this.dgvSwapInterplantMatPrima.ReadOnly = true;
            this.dgvSwapInterplantMatPrima.Size = new System.Drawing.Size(758, 385);
            this.dgvSwapInterplantMatPrima.TabIndex = 11;
            // 
            // clmCodigoPallet
            // 
            this.clmCodigoPallet.HeaderText = "Código Pallet";
            this.clmCodigoPallet.Name = "clmCodigoPallet";
            this.clmCodigoPallet.ReadOnly = true;
            this.clmCodigoPallet.Width = 120;
            // 
            // clmCodigoMP
            // 
            this.clmCodigoMP.HeaderText = "Código Materia Prima";
            this.clmCodigoMP.Name = "clmCodigoMP";
            this.clmCodigoMP.ReadOnly = true;
            this.clmCodigoMP.Width = 130;
            // 
            // clmNomMateriaPrima
            // 
            this.clmNomMateriaPrima.HeaderText = "Nombre Materia Prima";
            this.clmNomMateriaPrima.Name = "clmNomMateriaPrima";
            this.clmNomMateriaPrima.ReadOnly = true;
            this.clmNomMateriaPrima.Width = 180;
            // 
            // clmTipoMov
            // 
            this.clmTipoMov.HeaderText = "Tipo Movimiento";
            this.clmTipoMov.Name = "clmTipoMov";
            this.clmTipoMov.ReadOnly = true;
            this.clmTipoMov.Width = 200;
            // 
            // clmPesoNeto
            // 
            this.clmPesoNeto.HeaderText = "Peso Neto";
            this.clmPesoNeto.Name = "clmPesoNeto";
            this.clmPesoNeto.ReadOnly = true;
            this.clmPesoNeto.Width = 70;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            this.clmLote.Width = 80;
            // 
            // clmExtrusionLote
            // 
            this.clmExtrusionLote.HeaderText = "Lote Extrusión";
            this.clmExtrusionLote.Name = "clmExtrusionLote";
            this.clmExtrusionLote.ReadOnly = true;
            this.clmExtrusionLote.Width = 80;
            // 
            // clmBodegaOrigen
            // 
            this.clmBodegaOrigen.HeaderText = "Bodega Origen";
            this.clmBodegaOrigen.Name = "clmBodegaOrigen";
            this.clmBodegaOrigen.ReadOnly = true;
            this.clmBodegaOrigen.Width = 120;
            // 
            // clmBodegaDestino
            // 
            this.clmBodegaDestino.HeaderText = "Bodega Destino";
            this.clmBodegaDestino.Name = "clmBodegaDestino";
            this.clmBodegaDestino.ReadOnly = true;
            this.clmBodegaDestino.Width = 120;
            // 
            // clmPalletNotes
            // 
            this.clmPalletNotes.HeaderText = "Notas Pallet";
            this.clmPalletNotes.Name = "clmPalletNotes";
            this.clmPalletNotes.ReadOnly = true;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            this.clmFecha.Width = 130;
            // 
            // clmDay
            // 
            this.clmDay.HeaderText = "Dia";
            this.clmDay.Name = "clmDay";
            this.clmDay.ReadOnly = true;
            this.clmDay.Visible = false;
            // 
            // clmMonth
            // 
            this.clmMonth.HeaderText = "Mes";
            this.clmMonth.Name = "clmMonth";
            this.clmMonth.ReadOnly = true;
            this.clmMonth.Visible = false;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Año";
            this.clmYear.Name = "clmYear";
            this.clmYear.ReadOnly = true;
            this.clmYear.Visible = false;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            // 
            // frmRawMaterialSwapReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 508);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialSwapReport";
            this.Text = "Reporte de Swap de materia prima";
            this.groupBox6.ResumeLayout(false);
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwapInterplantMatPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateSwapRp;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbPlanta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSwapInterplantMatPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigoMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomMateriaPrima;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTipoMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPesoNeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtrusionLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodegaDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPalletNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
    }
}