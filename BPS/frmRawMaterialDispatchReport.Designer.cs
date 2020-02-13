namespace BPS
{
    partial class frmRawMaterialDispatchReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRawMaterialDispatchReport));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBoxFrom = new System.Windows.Forms.GroupBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTPFromSwap = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTPToSwap = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateSwapRp = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.dgvDispatch = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNomMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdayFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmonthFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmyearFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBodOrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            this.groupBoxFrom.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatch)).BeginInit();
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
            this.groupBox2.Controls.Add(this.dateTPFromSwap);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 44);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // dateTPFromSwap
            // 
            this.dateTPFromSwap.Location = new System.Drawing.Point(6, 15);
            this.dateTPFromSwap.Name = "dateTPFromSwap";
            this.dateTPFromSwap.Size = new System.Drawing.Size(200, 20);
            this.dateTPFromSwap.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTPToSwap);
            this.groupBox3.Location = new System.Drawing.Point(238, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 44);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // dateTPToSwap
            // 
            this.dateTPToSwap.Location = new System.Drawing.Point(6, 15);
            this.dateTPToSwap.Name = "dateTPToSwap";
            this.dateTPToSwap.Size = new System.Drawing.Size(200, 20);
            this.dateTPToSwap.TabIndex = 0;
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
            this.groupBox5.Controls.Add(this.cmbPlant);
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
            this.btnExport.Image = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(252, 62);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 12;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(30, 61);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(103, 21);
            this.cmbPlant.TabIndex = 10;
            // 
            // dgvDispatch
            // 
            this.dgvDispatch.AllowUserToAddRows = false;
            this.dgvDispatch.AllowUserToDeleteRows = false;
            this.dgvDispatch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDispatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNomMat,
            this.clmLote,
            this.clmNetWeigth,
            this.clmUser,
            this.clmDate,
            this.clmdayFecha,
            this.clmmonthFecha,
            this.clmyearFecha,
            this.clmBodOrg});
            this.dgvDispatch.Location = new System.Drawing.Point(3, 109);
            this.dgvDispatch.Name = "dgvDispatch";
            this.dgvDispatch.ReadOnly = true;
            this.dgvDispatch.Size = new System.Drawing.Size(764, 393);
            this.dgvDispatch.TabIndex = 19;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código Pallet";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            // 
            // clmNomMat
            // 
            this.clmNomMat.HeaderText = "Nombre Material";
            this.clmNomMat.Name = "clmNomMat";
            this.clmNomMat.ReadOnly = true;
            // 
            // clmLote
            // 
            this.clmLote.HeaderText = "Lote";
            this.clmLote.Name = "clmLote";
            this.clmLote.ReadOnly = true;
            // 
            // clmNetWeigth
            // 
            this.clmNetWeigth.HeaderText = "Peso Neto";
            this.clmNetWeigth.Name = "clmNetWeigth";
            this.clmNetWeigth.ReadOnly = true;
            // 
            // clmUser
            // 
            this.clmUser.HeaderText = "Usuario";
            this.clmUser.Name = "clmUser";
            this.clmUser.ReadOnly = true;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            // 
            // clmdayFecha
            // 
            this.clmdayFecha.HeaderText = "Dia";
            this.clmdayFecha.Name = "clmdayFecha";
            this.clmdayFecha.ReadOnly = true;
            this.clmdayFecha.Visible = false;
            // 
            // clmmonthFecha
            // 
            this.clmmonthFecha.HeaderText = "Mes";
            this.clmmonthFecha.Name = "clmmonthFecha";
            this.clmmonthFecha.ReadOnly = true;
            this.clmmonthFecha.Visible = false;
            // 
            // clmyearFecha
            // 
            this.clmyearFecha.HeaderText = "Año";
            this.clmyearFecha.Name = "clmyearFecha";
            this.clmyearFecha.ReadOnly = true;
            this.clmyearFecha.Visible = false;
            // 
            // clmBodOrg
            // 
            this.clmBodOrg.HeaderText = "Bodega Origen";
            this.clmBodOrg.Name = "clmBodOrg";
            this.clmBodOrg.ReadOnly = true;
            // 
            // frmRawMaterialDispatchReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 505);
            this.Controls.Add(this.dgvDispatch);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRawMaterialDispatchReport";
            this.Text = "Reporte de Despacho";
            this.groupBox6.ResumeLayout(false);
            this.groupBoxFrom.ResumeLayout(false);
            this.groupBoxFrom.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBoxFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTPFromSwap;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTPToSwap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateSwapRp;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbPlant;
        private System.Windows.Forms.DataGridView dgvDispatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNomMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdayFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmonthFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmyearFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBodOrg;
    }
}