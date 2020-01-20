namespace BPS.Lite
{
    partial class frmCoilCellarReturnsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoilCellarReturnsReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGenerateReturnByDateRp = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.cmbPlants = new System.Windows.Forms.ComboBox();
            this.dateTPToReturn = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dateTPFromReturn = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCoilCellarReturns = new System.Windows.Forms.DataGridView();
            this.clmPallet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustommer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMovementType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilCellarReturns)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnGenerateReturnByDateRp);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.cmbPlants);
            this.groupBox1.Controls.Add(this.dateTPToReturn);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.dateTPFromReturn);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(614, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 27);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Planta";
            // 
            // btnGenerateReturnByDateRp
            // 
            this.btnGenerateReturnByDateRp.Location = new System.Drawing.Point(824, 12);
            this.btnGenerateReturnByDateRp.Name = "btnGenerateReturnByDateRp";
            this.btnGenerateReturnByDateRp.Size = new System.Drawing.Size(88, 24);
            this.btnGenerateReturnByDateRp.TabIndex = 14;
            this.btnGenerateReturnByDateRp.Text = "Generar";
            this.btnGenerateReturnByDateRp.UseVisualStyleBackColor = true;
            this.btnGenerateReturnByDateRp.Click += new System.EventHandler(this.btnGenerateReturnByDateRp_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnExport.Location = new System.Drawing.Point(887, 42);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(25, 25);
            this.btnExport.TabIndex = 15;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // cmbPlants
            // 
            this.cmbPlants.FormattingEnabled = true;
            this.cmbPlants.Location = new System.Drawing.Point(614, 42);
            this.cmbPlants.Name = "cmbPlants";
            this.cmbPlants.Size = new System.Drawing.Size(168, 21);
            this.cmbPlants.TabIndex = 16;
            // 
            // dateTPToReturn
            // 
            this.dateTPToReturn.Location = new System.Drawing.Point(299, 42);
            this.dateTPToReturn.Name = "dateTPToReturn";
            this.dateTPToReturn.Size = new System.Drawing.Size(213, 20);
            this.dateTPToReturn.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(299, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(213, 27);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hasta";
            // 
            // groupBox6
            // 
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(6, 9);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(213, 27);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Desde:";
            // 
            // dateTPFromReturn
            // 
            this.dateTPFromReturn.Location = new System.Drawing.Point(6, 42);
            this.dateTPFromReturn.Name = "dateTPFromReturn";
            this.dateTPFromReturn.Size = new System.Drawing.Size(213, 20);
            this.dateTPFromReturn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCoilCellarReturns);
            this.groupBox2.Location = new System.Drawing.Point(4, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 376);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvCoilCellarReturns
            // 
            this.dgvCoilCellarReturns.AllowUserToAddRows = false;
            this.dgvCoilCellarReturns.AllowUserToDeleteRows = false;
            this.dgvCoilCellarReturns.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCoilCellarReturns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoilCellarReturns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPallet,
            this.clmCoil,
            this.clmCustommer,
            this.clmSaleOrderDetail,
            this.clmPlant,
            this.clmProduct,
            this.clmWeight,
            this.clmMovementType,
            this.clmDate,
            this.clmHour,
            this.clmDay,
            this.clmMonth,
            this.clmYear});
            this.dgvCoilCellarReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCoilCellarReturns.Location = new System.Drawing.Point(3, 16);
            this.dgvCoilCellarReturns.Name = "dgvCoilCellarReturns";
            this.dgvCoilCellarReturns.ReadOnly = true;
            this.dgvCoilCellarReturns.Size = new System.Drawing.Size(917, 357);
            this.dgvCoilCellarReturns.TabIndex = 0;
            // 
            // clmPallet
            // 
            this.clmPallet.HeaderText = "Pallet";
            this.clmPallet.Name = "clmPallet";
            this.clmPallet.ReadOnly = true;
            // 
            // clmCoil
            // 
            this.clmCoil.HeaderText = "Bobina";
            this.clmCoil.Name = "clmCoil";
            this.clmCoil.ReadOnly = true;
            // 
            // clmCustommer
            // 
            this.clmCustommer.HeaderText = "Cliente";
            this.clmCustommer.Name = "clmCustommer";
            this.clmCustommer.ReadOnly = true;
            this.clmCustommer.Width = 150;
            // 
            // clmSaleOrderDetail
            // 
            this.clmSaleOrderDetail.HeaderText = "Pedido";
            this.clmSaleOrderDetail.Name = "clmSaleOrderDetail";
            this.clmSaleOrderDetail.ReadOnly = true;
            this.clmSaleOrderDetail.Width = 80;
            // 
            // clmPlant
            // 
            this.clmPlant.HeaderText = "Planta";
            this.clmPlant.Name = "clmPlant";
            this.clmPlant.ReadOnly = true;
            this.clmPlant.Width = 80;
            // 
            // clmProduct
            // 
            this.clmProduct.HeaderText = "Producto";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.ReadOnly = true;
            // 
            // clmWeight
            // 
            this.clmWeight.HeaderText = "Peso";
            this.clmWeight.Name = "clmWeight";
            this.clmWeight.ReadOnly = true;
            this.clmWeight.Width = 80;
            // 
            // clmMovementType
            // 
            this.clmMovementType.HeaderText = "TipodeMovimiento";
            this.clmMovementType.Name = "clmMovementType";
            this.clmMovementType.ReadOnly = true;
            this.clmMovementType.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.HeaderText = "Fecha";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 80;
            // 
            // clmHour
            // 
            this.clmHour.HeaderText = "Hora";
            this.clmHour.Name = "clmHour";
            this.clmHour.ReadOnly = true;
            this.clmHour.Width = 80;
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
            // frmCoilCellarReturnsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCoilCellarReturnsReport";
            this.Text = "Reporte de Devoluciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoilCellarReturns)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGenerateReturnByDateRp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTPToReturn;
        private System.Windows.Forms.DateTimePicker dateTPFromReturn;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ComboBox cmbPlants;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCoilCellarReturns;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPallet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustommer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlant;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMovementType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
    }
}