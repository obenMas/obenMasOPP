namespace BPS.Cellar.Film
{
    partial class frmPalletList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPalletList));
            this.grpInfoDate = new System.Windows.Forms.GroupBox();
            this.cmbInnig = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpPalletList = new System.Windows.Forms.GroupBox();
            this.dgvPalletList = new System.Windows.Forms.DataGridView();
            this.grpbEmpty = new System.Windows.Forms.GroupBox();
            this.lblnotok = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpercentaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmprodate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmindate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmbopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpInfoDate.SuspendLayout();
            this.grpPalletList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).BeginInit();
            this.grpbEmpty.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoDate
            // 
            this.grpInfoDate.Controls.Add(this.cmbInnig);
            this.grpInfoDate.Controls.Add(this.label17);
            this.grpInfoDate.Controls.Add(this.btnFilter);
            this.grpInfoDate.Controls.Add(this.dtpDate);
            this.grpInfoDate.Controls.Add(this.lblDate);
            this.grpInfoDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInfoDate.Location = new System.Drawing.Point(0, 0);
            this.grpInfoDate.Name = "grpInfoDate";
            this.grpInfoDate.Size = new System.Drawing.Size(1060, 44);
            this.grpInfoDate.TabIndex = 1;
            this.grpInfoDate.TabStop = false;
            // 
            // cmbInnig
            // 
            this.cmbInnig.FormattingEnabled = true;
            this.cmbInnig.Items.AddRange(new object[] {
            "Día",
            "Noche"});
            this.cmbInnig.Location = new System.Drawing.Point(237, 13);
            this.cmbInnig.Name = "cmbInnig";
            this.cmbInnig.Size = new System.Drawing.Size(211, 23);
            this.cmbInnig.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(189, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "Turno:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundImage = global::BPS.Properties.Resources.funnel;
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFilter.Location = new System.Drawing.Point(846, 12);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(25, 25);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(532, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(253, 21);
            this.dtpDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(482, 17);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Fecha:";
            // 
            // grpPalletList
            // 
            this.grpPalletList.Controls.Add(this.dgvPalletList);
            this.grpPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPalletList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPalletList.Location = new System.Drawing.Point(0, 44);
            this.grpPalletList.Name = "grpPalletList";
            this.grpPalletList.Size = new System.Drawing.Size(1060, 446);
            this.grpPalletList.TabIndex = 2;
            this.grpPalletList.TabStop = false;
            // 
            // dgvPalletList
            // 
            this.dgvPalletList.AllowUserToAddRows = false;
            this.dgvPalletList.AllowUserToDeleteRows = false;
            this.dgvPalletList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPalletList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPalletList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalletList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmNumber,
            this.clmProductCode,
            this.clmcode,
            this.clmprodate,
            this.clmindate,
            this.clmCustomer,
            this.clmNetWeight,
            this.clmbopp,
            this.clmopp,
            this.clmSalesOrderNumber,
            this.clmWidth,
            this.clmLot,
            this.clmID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPalletList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPalletList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPalletList.Location = new System.Drawing.Point(3, 16);
            this.dgvPalletList.Name = "dgvPalletList";
            this.dgvPalletList.ReadOnly = true;
            this.dgvPalletList.RowHeadersWidth = 21;
            this.dgvPalletList.Size = new System.Drawing.Size(1054, 427);
            this.dgvPalletList.TabIndex = 0;
            // 
            // grpbEmpty
            // 
            this.grpbEmpty.Controls.Add(this.lblnotok);
            this.grpbEmpty.Controls.Add(this.label3);
            this.grpbEmpty.Controls.Add(this.lblok);
            this.grpbEmpty.Controls.Add(this.label2);
            this.grpbEmpty.Controls.Add(this.lblpercentaje);
            this.grpbEmpty.Controls.Add(this.label1);
            this.grpbEmpty.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbEmpty.Location = new System.Drawing.Point(0, 490);
            this.grpbEmpty.Name = "grpbEmpty";
            this.grpbEmpty.Size = new System.Drawing.Size(1060, 41);
            this.grpbEmpty.TabIndex = 8;
            this.grpbEmpty.TabStop = false;
            // 
            // lblnotok
            // 
            this.lblnotok.AutoSize = true;
            this.lblnotok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotok.ForeColor = System.Drawing.Color.Red;
            this.lblnotok.Location = new System.Drawing.Point(762, 16);
            this.lblnotok.Name = "lblnotok";
            this.lblnotok.Size = new System.Drawing.Size(40, 16);
            this.lblnotok.TabIndex = 5;
            this.lblnotok.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(610, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pallet´s Novedades";
            // 
            // lblok
            // 
            this.lblok.AutoSize = true;
            this.lblok.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblok.Location = new System.Drawing.Point(559, 16);
            this.lblok.Name = "lblok";
            this.lblok.Size = new System.Drawing.Size(35, 15);
            this.lblok.TabIndex = 3;
            this.lblok.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(483, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pallet´s  OK";
            // 
            // lblpercentaje
            // 
            this.lblpercentaje.AutoSize = true;
            this.lblpercentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpercentaje.Location = new System.Drawing.Point(407, 16);
            this.lblpercentaje.Name = "lblpercentaje";
            this.lblpercentaje.Size = new System.Drawing.Size(63, 15);
            this.lblpercentaje.TabIndex = 1;
            this.lblpercentaje.Text = "1000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "# Pallet´s Producidos";
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Nro.";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 50;
            // 
            // clmProductCode
            // 
            this.clmProductCode.HeaderText = "Producto";
            this.clmProductCode.Name = "clmProductCode";
            this.clmProductCode.ReadOnly = true;
            this.clmProductCode.Width = 120;
            // 
            // clmcode
            // 
            this.clmcode.HeaderText = "Pallet";
            this.clmcode.Name = "clmcode";
            this.clmcode.ReadOnly = true;
            // 
            // clmprodate
            // 
            this.clmprodate.HeaderText = "Producción";
            this.clmprodate.Name = "clmprodate";
            this.clmprodate.ReadOnly = true;
            // 
            // clmindate
            // 
            this.clmindate.HeaderText = "Ingreso";
            this.clmindate.Name = "clmindate";
            this.clmindate.ReadOnly = true;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 150;
            // 
            // clmNetWeight
            // 
            this.clmNetWeight.HeaderText = "Peso Neto";
            this.clmNetWeight.Name = "clmNetWeight";
            this.clmNetWeight.ReadOnly = true;
            this.clmNetWeight.Width = 90;
            // 
            // clmbopp
            // 
            this.clmbopp.HeaderText = "Bopp";
            this.clmbopp.Name = "clmbopp";
            this.clmbopp.ReadOnly = true;
            this.clmbopp.Width = 90;
            // 
            // clmopp
            // 
            this.clmopp.HeaderText = "Opp";
            this.clmopp.Name = "clmopp";
            this.clmopp.ReadOnly = true;
            this.clmopp.Width = 90;
            // 
            // clmSalesOrderNumber
            // 
            this.clmSalesOrderNumber.HeaderText = "Orden";
            this.clmSalesOrderNumber.Name = "clmSalesOrderNumber";
            this.clmSalesOrderNumber.ReadOnly = true;
            this.clmSalesOrderNumber.Width = 70;
            // 
            // clmWidth
            // 
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 70;
            // 
            // clmLot
            // 
            this.clmLot.HeaderText = "Lote";
            this.clmLot.Name = "clmLot";
            this.clmLot.ReadOnly = true;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.ReadOnly = true;
            this.clmID.Width = 70;
            // 
            // frmPalletList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1060, 531);
            this.Controls.Add(this.grpPalletList);
            this.Controls.Add(this.grpInfoDate);
            this.Controls.Add(this.grpbEmpty);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPalletList";
            this.Text = "Cruce de pallet Planta - Bodega";
            this.Load += new System.EventHandler(this.frmPalletList_Load);
            this.grpInfoDate.ResumeLayout(false);
            this.grpInfoDate.PerformLayout();
            this.grpPalletList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalletList)).EndInit();
            this.grpbEmpty.ResumeLayout(false);
            this.grpbEmpty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoDate;
        private System.Windows.Forms.ComboBox cmbInnig;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpPalletList;
        private System.Windows.Forms.DataGridView dgvPalletList;
        private System.Windows.Forms.GroupBox grpbEmpty;
        private System.Windows.Forms.Label lblnotok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpercentaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmprodate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmindate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNetWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmbopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
    }
}