namespace BPS
{
    partial class frmSalesOrderSummary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesOrderSummary));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMainCoilClearFilters = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.lblFilmName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.clmCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalesOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExtruder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMissing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbFooter = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblTotalWeightLabel = new System.Windows.Forms.Label();
            this.lblTotalPallets = new System.Windows.Forms.Label();
            this.lblTotalPalletsLabel = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grpbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.grpbFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.btnPrint);
            this.grpbFilters.Controls.Add(this.btnExcel);
            this.grpbFilters.Controls.Add(this.cmbCustomer);
            this.grpbFilters.Controls.Add(this.lblCustomer);
            this.grpbFilters.Controls.Add(this.pictureBox7);
            this.grpbFilters.Controls.Add(this.pictureBox6);
            this.grpbFilters.Controls.Add(this.pictureBox5);
            this.grpbFilters.Controls.Add(this.pictureBox4);
            this.grpbFilters.Controls.Add(this.txtWidth);
            this.grpbFilters.Controls.Add(this.lblWidth);
            this.grpbFilters.Controls.Add(this.btnRefresh);
            this.grpbFilters.Controls.Add(this.btnMainCoilClearFilters);
            this.grpbFilters.Controls.Add(this.cmbOrder);
            this.grpbFilters.Controls.Add(this.cmbFilm);
            this.grpbFilters.Controls.Add(this.lblSalesOrder);
            this.grpbFilters.Controls.Add(this.lblFilmName);
            this.grpbFilters.Controls.Add(this.lblNote);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(0, 0);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(1087, 83);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            this.grpbFilters.Enter += new System.EventHandler(this.grpbFilters_Enter);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::BPS.Properties.Resources.printer;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrint.Location = new System.Drawing.Point(1036, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(25, 25);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Location = new System.Drawing.Point(1008, 30);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExcel.TabIndex = 30;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(146, 29);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(252, 23);
            this.cmbCustomer.TabIndex = 28;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged_1);
            this.cmbCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomer_KeyDown_1);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(143, 11);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(52, 15);
            this.lblCustomer.TabIndex = 27;
            this.lblCustomer.Text = "Cliente";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(793, 57);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(1, 11);
            this.pictureBox7.TabIndex = 26;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(148, 57);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1, 11);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(736, 68);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(58, 1);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(148, 68);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 1);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(702, 31);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWidthFrom_KeyDown);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(710, 11);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 15);
            this.lblWidth.TabIndex = 7;
            this.lblWidth.Text = "Ancho";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::BPS.Properties.Resources.arrow_refresh1;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Location = new System.Drawing.Point(981, 30);
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
            this.btnMainCoilClearFilters.Location = new System.Drawing.Point(953, 30);
            this.btnMainCoilClearFilters.Name = "btnMainCoilClearFilters";
            this.btnMainCoilClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClearFilters.TabIndex = 19;
            this.btnMainCoilClearFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilClearFilters.Click += new System.EventHandler(this.btnMainCoilClearFilters_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(404, 29);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(135, 23);
            this.cmbOrder.TabIndex = 5;
            this.cmbOrder.SelectedIndexChanged += new System.EventHandler(this.cmbOrder_SelectedIndexChanged);
            this.cmbOrder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // cmbFilm
            // 
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(548, 29);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(143, 23);
            this.cmbFilm.TabIndex = 1;
            this.cmbFilm.SelectedIndexChanged += new System.EventHandler(this.cmbFilm_SelectedIndexChanged);
            this.cmbFilm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbFilm_KeyDown);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(401, 11);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(46, 15);
            this.lblSalesOrder.TabIndex = 4;
            this.lblSalesOrder.Text = "Orden";
            // 
            // lblFilmName
            // 
            this.lblFilmName.AutoSize = true;
            this.lblFilmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilmName.Location = new System.Drawing.Point(545, 11);
            this.lblFilmName.Name = "lblFilmName";
            this.lblFilmName.Size = new System.Drawing.Size(59, 15);
            this.lblFilmName.TabIndex = 0;
            this.lblFilmName.Text = "Pelicula";
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(116, 58);
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
            this.grpbDetail.Location = new System.Drawing.Point(0, 83);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(1087, 438);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // lblLoading
            // 
            this.lblLoading.Location = new System.Drawing.Point(397, 197);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(213, 34);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Se esta cargando la información de los pedidos\r\nEsto puede tomar algunos segundos" +
    "";
            this.lblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxLoading
            // 
            this.pbxLoading.ErrorImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Image = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.InitialImage = global::BPS.Properties.Resources.loading6;
            this.pbxLoading.Location = new System.Drawing.Point(451, 178);
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
            this.clmCustomer,
            this.clmSalesOrder,
            this.clmFilm,
            this.clmWidth,
            this.clmQuantity,
            this.clmExtruder,
            this.clmMissing,
            this.clmcreateDate,
            this.clmDate});
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetails.Location = new System.Drawing.Point(3, 14);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 10;
            this.dgvDetails.Size = new System.Drawing.Size(1081, 421);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellClick);
            // 
            // clmCustomer
            // 
            this.clmCustomer.HeaderText = "Cliente";
            this.clmCustomer.Name = "clmCustomer";
            this.clmCustomer.ReadOnly = true;
            this.clmCustomer.Width = 170;
            // 
            // clmSalesOrder
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmSalesOrder.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmSalesOrder.HeaderText = "Orden";
            this.clmSalesOrder.Name = "clmSalesOrder";
            this.clmSalesOrder.ReadOnly = true;
            // 
            // clmFilm
            // 
            this.clmFilm.HeaderText = "Pelicula";
            this.clmFilm.Name = "clmFilm";
            this.clmFilm.ReadOnly = true;
            // 
            // clmWidth
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmWidth.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmWidth.HeaderText = "Ancho";
            this.clmWidth.Name = "clmWidth";
            this.clmWidth.ReadOnly = true;
            this.clmWidth.Width = 50;
            // 
            // clmQuantity
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmQuantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmQuantity.HeaderText = "Cantidad KG";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.ReadOnly = true;
            // 
            // clmExtruder
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmExtruder.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmExtruder.HeaderText = "Extruidos KG";
            this.clmExtruder.Name = "clmExtruder";
            this.clmExtruder.ReadOnly = true;
            // 
            // clmMissing
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmMissing.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmMissing.HeaderText = "Faltante KG";
            this.clmMissing.Name = "clmMissing";
            this.clmMissing.ReadOnly = true;
            // 
            // clmcreateDate
            // 
            this.clmcreateDate.HeaderText = "F. Pedido";
            this.clmcreateDate.Name = "clmcreateDate";
            this.clmcreateDate.ReadOnly = true;
            this.clmcreateDate.Width = 80;
            // 
            // clmDate
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmDate.HeaderText = "Fecha Corte";
            this.clmDate.Name = "clmDate";
            this.clmDate.ReadOnly = true;
            this.clmDate.Width = 250;
            // 
            // grpbFooter
            // 
            this.grpbFooter.Controls.Add(this.label5);
            this.grpbFooter.Controls.Add(this.label4);
            this.grpbFooter.Controls.Add(this.label3);
            this.grpbFooter.Controls.Add(this.label1);
            this.grpbFooter.Controls.Add(this.label2);
            this.grpbFooter.Controls.Add(this.lblTotalWeight);
            this.grpbFooter.Controls.Add(this.lblTotalWeightLabel);
            this.grpbFooter.Controls.Add(this.lblTotalPallets);
            this.grpbFooter.Controls.Add(this.lblTotalPalletsLabel);
            this.grpbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFooter.Location = new System.Drawing.Point(0, 521);
            this.grpbFooter.Name = "grpbFooter";
            this.grpbFooter.Size = new System.Drawing.Size(1087, 52);
            this.grpbFooter.TabIndex = 2;
            this.grpbFooter.TabStop = false;
            this.grpbFooter.Text = "Resumen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(876, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Kgs.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kgs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kgs.";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(779, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(666, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total Faltante";
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(504, 17);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(94, 20);
            this.lblTotalWeight.TabIndex = 3;
            this.lblTotalWeight.Text = "0";
            this.lblTotalWeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalWeightLabel
            // 
            this.lblTotalWeightLabel.AutoSize = true;
            this.lblTotalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightLabel.Location = new System.Drawing.Point(371, 17);
            this.lblTotalWeightLabel.Name = "lblTotalWeightLabel";
            this.lblTotalWeightLabel.Size = new System.Drawing.Size(127, 20);
            this.lblTotalWeightLabel.TabIndex = 2;
            this.lblTotalWeightLabel.Text = "Total Producción";
            // 
            // lblTotalPallets
            // 
            this.lblTotalPallets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalPallets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPallets.Location = new System.Drawing.Point(211, 17);
            this.lblTotalPallets.Name = "lblTotalPallets";
            this.lblTotalPallets.Size = new System.Drawing.Size(94, 20);
            this.lblTotalPallets.TabIndex = 1;
            this.lblTotalPallets.Text = "0";
            this.lblTotalPallets.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPalletsLabel
            // 
            this.lblTotalPalletsLabel.AutoSize = true;
            this.lblTotalPalletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPalletsLabel.Location = new System.Drawing.Point(100, 17);
            this.lblTotalPalletsLabel.Name = "lblTotalPalletsLabel";
            this.lblTotalPalletsLabel.Size = new System.Drawing.Size(105, 20);
            this.lblTotalPalletsLabel.TabIndex = 0;
            this.lblTotalPalletsLabel.Text = "Total Pedidos";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmSalesOrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1087, 573);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFooter);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSalesOrderSummary";
            this.Text = "Kilos Pedidos VS Kilos Producidos Pedidos Nacionales";
            this.Load += new System.EventHandler(this.frmBackLoad_Load);
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
            this.grpbFooter.ResumeLayout(false);
            this.grpbFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFilters;
        private System.Windows.Forms.GroupBox grpbDetail;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.GroupBox grpbFooter;
        private System.Windows.Forms.Label lblFilmName;
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMainCoilClearFilters;
        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lblTotalPallets;
        private System.Windows.Forms.Label lblTotalPalletsLabel;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblTotalWeightLabel;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalesOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExtruder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMissing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcreateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDate;
    }
}