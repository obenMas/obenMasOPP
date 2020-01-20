namespace BPS
{
    partial class frmCertificateList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificateList));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.cmbLotNumber = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMainCoilClearFilters = new System.Windows.Forms.Button();
            this.chkExtrusionDate = new System.Windows.Forms.CheckBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.clmCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmfkBopp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLotNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReport = new System.Windows.Forms.DataGridViewImageColumn();
            this.clmdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.cmbLotNumber);
            this.grpbFilters.Controls.Add(this.pictureBox7);
            this.grpbFilters.Controls.Add(this.pictureBox6);
            this.grpbFilters.Controls.Add(this.pictureBox5);
            this.grpbFilters.Controls.Add(this.pictureBox4);
            this.grpbFilters.Controls.Add(this.lblLotNumber);
            this.grpbFilters.Controls.Add(this.btnRefresh);
            this.grpbFilters.Controls.Add(this.btnMainCoilClearFilters);
            this.grpbFilters.Controls.Add(this.chkExtrusionDate);
            this.grpbFilters.Controls.Add(this.dtpEndDate);
            this.grpbFilters.Controls.Add(this.dtpInitDate);
            this.grpbFilters.Controls.Add(this.cmbOrder);
            this.grpbFilters.Controls.Add(this.cmbCustomer);
            this.grpbFilters.Controls.Add(this.cmbFilm);
            this.grpbFilters.Controls.Add(this.lblSalesOrder);
            this.grpbFilters.Controls.Add(this.lblCustomer);
            this.grpbFilters.Controls.Add(this.lblFilmName);
            this.grpbFilters.Controls.Add(this.lblNote);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(0, 0);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(927, 92);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            this.grpbFilters.Enter += new System.EventHandler(this.grpbFilters_Enter);
            // 
            // cmbLotNumber
            // 
            this.cmbLotNumber.FormattingEnabled = true;
            this.cmbLotNumber.Location = new System.Drawing.Point(525, 35);
            this.cmbLotNumber.Name = "cmbLotNumber";
            this.cmbLotNumber.Size = new System.Drawing.Size(126, 23);
            this.cmbLotNumber.TabIndex = 28;
            this.cmbLotNumber.SelectedIndexChanged += new System.EventHandler(this.cmbLotNumber_SelectedIndexChanged);
            this.cmbLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbLotNumber_KeyDown);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(655, 64);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1, 11);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(10, 64);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1, 11);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(598, 75);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 1);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(10, 75);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 1);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.AutoSize = true;
            this.lblLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Location = new System.Drawing.Point(525, 17);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(35, 15);
            this.lblLotNumber.TabIndex = 7;
            this.lblLotNumber.Text = "Lote";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(892, 57);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 25);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnMainCoilClearFilters
            // 
            this.btnMainCoilClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnMainCoilClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilClearFilters.Location = new System.Drawing.Point(892, 31);
            this.btnMainCoilClearFilters.Name = "btnMainCoilClearFilters";
            this.btnMainCoilClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClearFilters.TabIndex = 19;
            this.btnMainCoilClearFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilClearFilters.Click += new System.EventHandler(this.btnMainCoilClearFilters_Click);
            // 
            // chkExtrusionDate
            // 
            this.chkExtrusionDate.AutoSize = true;
            this.chkExtrusionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtrusionDate.Location = new System.Drawing.Point(668, 16);
            this.chkExtrusionDate.Name = "chkExtrusionDate";
            this.chkExtrusionDate.Size = new System.Drawing.Size(148, 19);
            this.chkExtrusionDate.TabIndex = 10;
            this.chkExtrusionDate.Text = "Fecha de extrusión";
            this.chkExtrusionDate.UseVisualStyleBackColor = true;
            this.chkExtrusionDate.CheckedChanged += new System.EventHandler(this.chkExtrusionDate_CheckedChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(668, 63);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(218, 21);
            this.dtpEndDate.TabIndex = 12;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.Location = new System.Drawing.Point(668, 35);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(218, 21);
            this.dtpInitDate.TabIndex = 11;
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(393, 34);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(126, 23);
            this.cmbOrder.TabIndex = 5;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(131, 34);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(252, 23);
            this.cmbCustomer.TabIndex = 3;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(10, 34);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(111, 23);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(390, 16);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(46, 15);
            this.lblSalesOrder.TabIndex = 4;
            this.lblSalesOrder.Text = "Orden";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(128, 16);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(52, 15);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Cliente";
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(7, 16);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(59, 15);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Pelicula";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(-22, 65);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(709, 18);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Seleccione una de las opciones o escriba en el campo el criterio de busqueda y pr" +
    "esione enter";
            this.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.lblLoading);
            this.grpbDetail.Controls.Add(this.pbxLoading);
            this.grpbDetail.Controls.Add(this.dgvDetails);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetail.Location = new System.Drawing.Point(0, 92);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(927, 434);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(357, 210);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(213, 34);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Se esta cargando la información de los pallets\r\nEsto puede tomar algunos segundos" +
    "";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLoading
            // 
            this.pbxLoading.ErrorImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Image = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.InitialImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Location = new System.Drawing.Point(411, 191);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(105, 16);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLoading.TabIndex = 1;
            this.pbxLoading.TabStop = false;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodsec,
            this.clmfkBopp,
            this.clmFilm,
            this.clmLotNumber,
            this.clmCustomer,
            this.clmSalesOrder,
            this.clmCreatedDate,
            this.clmReport,
            this.clmdelete});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 14);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 10;
            this.dgvDetails.Size = new System.Drawing.Size(921, 417);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // clmCodsec
            // 
            this.clmCodsec.HeaderText = "codsec";
            this.clmCodsec.Name = "clmCodsec";
            this.clmCodsec.ReadOnly = true;
            this.clmCodsec.Visible = false;
            // 
            // clmfkBopp
            // 
            this.clmfkBopp.HeaderText = "fkBopp";
            this.clmfkBopp.Name = "clmfkBopp";
            this.clmfkBopp.ReadOnly = true;
            this.clmfkBopp.Visible = false;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pelicula";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            // 
            // clmLotNumber
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmLotNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmLotNumber.HeaderText = "Lote";
            this.clmLotNumber.Name = "clmLotNumber";
            this.clmLotNumber.ReadOnly = true;
            this.clmLotNumber.Width = 150;
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 250;
            // 
            // clmSalesOrder
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSalesOrder.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmSalesOrder.HeaderText = "Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            // 
            // clmCreatedDate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmCreatedDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmCreatedDate.HeaderText = "F. Elaboración";
            this.clmCreatedDate.Name = "clmCreatedDate";
            this.clmCreatedDate.ReadOnly = true;
            this.clmCreatedDate.Width = 150;
            // 
            // clmReport
            // 
            this.clmReport.HeaderText = "";
            this.clmReport.Name = "clmReport";
            this.clmReport.ReadOnly = true;
            this.clmReport.Width = 30;
            // 
            // clmdelete
            // 
            this.clmdelete.HeaderText = "";
            this.clmdelete.Name = "clmdelete";
            this.clmdelete.ReadOnly = true;
            this.clmdelete.Width = 30;
            // 
            // frmCertificateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(927, 526);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCertificateList";
            this.Text = "Listado Certificados de Calidad";
            this.Load += new System.EventHandler(this.frmCertificateList_Load);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grpbDetail.ResumeLayout(false);
            this.grpbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.CheckBox chkExtrusionDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMainCoilClearFilters;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox cmbLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmfkBopp;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLotNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCreatedDate;
        private System.Windows.Forms.DataGridViewImageColumn clmReport;
        private System.Windows.Forms.DataGridViewImageColumn clmdelete;
    }
}