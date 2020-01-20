namespace BPS
{
    partial class frmEfficiencyCutExtruder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEfficiencyCutExtruder));
            this.grpbFilters = new System.Windows.Forms.GroupBox();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblLotNumber = new System.Windows.Forms.Label();
            this.btnMainCoilClearFilters = new System.Windows.Forms.Button();
            this.cmbLotNumber = new System.Windows.Forms.ComboBox();
            this.lblSalesOrder = new System.Windows.Forms.Label();
            this.grpbDetail = new System.Windows.Forms.GroupBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.grpbFooter = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEfficiency = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMainCoilWeigth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDecrease = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMainCoilQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalConsuptionObs = new System.Windows.Forms.Label();
            this.lblTotalWeightLabel = new System.Windows.Forms.Label();
            this.lblTotalConsuptionP = new System.Windows.Forms.Label();
            this.lblTotalPalletsLabel = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.clmcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmlotnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmaincoil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmconsuption = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmconsuptionobs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdecrease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrefile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmendroller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmwaste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmissplice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmefficiency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmview = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpbFilters.SuspendLayout();
            this.grpbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.grpbFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbFilters
            // 
            this.grpbFilters.Controls.Add(this.lblFilm);
            this.grpbFilters.Controls.Add(this.btnExcel);
            this.grpbFilters.Controls.Add(this.txtWidth);
            this.grpbFilters.Controls.Add(this.lblLotNumber);
            this.grpbFilters.Controls.Add(this.btnMainCoilClearFilters);
            this.grpbFilters.Controls.Add(this.cmbLotNumber);
            this.grpbFilters.Controls.Add(this.lblSalesOrder);
            this.grpbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbFilters.Location = new System.Drawing.Point(0, 0);
            this.grpbFilters.Name = "grpbFilters";
            this.grpbFilters.Size = new System.Drawing.Size(1154, 57);
            this.grpbFilters.TabIndex = 0;
            this.grpbFilters.TabStop = false;
            this.grpbFilters.Text = "Filtros";
            // 
            // lblFilm
            // 
            this.lblFilm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilm.Location = new System.Drawing.Point(540, 13);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(515, 39);
            this.lblFilm.TabIndex = 31;
            this.lblFilm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.BackgroundImage = global::BPS.Properties.Resources.doc_excel_table;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcel.Location = new System.Drawing.Point(1119, 20);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(25, 25);
            this.btnExcel.TabIndex = 30;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(422, 31);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 21);
            this.txtWidth.TabIndex = 8;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // lblLotNumber
            // 
            this.lblLotNumber.AutoSize = true;
            this.lblLotNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLotNumber.Location = new System.Drawing.Point(426, 11);
            this.lblLotNumber.Name = "lblLotNumber";
            this.lblLotNumber.Size = new System.Drawing.Size(35, 15);
            this.lblLotNumber.TabIndex = 7;
            this.lblLotNumber.Text = "Lote";
            // 
            // btnMainCoilClearFilters
            // 
            this.btnMainCoilClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainCoilClearFilters.BackgroundImage = global::BPS.Properties.Resources.funnel_clear;
            this.btnMainCoilClearFilters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMainCoilClearFilters.Location = new System.Drawing.Point(1089, 20);
            this.btnMainCoilClearFilters.Name = "btnMainCoilClearFilters";
            this.btnMainCoilClearFilters.Size = new System.Drawing.Size(25, 25);
            this.btnMainCoilClearFilters.TabIndex = 19;
            this.btnMainCoilClearFilters.UseVisualStyleBackColor = true;
            this.btnMainCoilClearFilters.Click += new System.EventHandler(this.btnMainCoilClearFilters_Click);
            // 
            // cmbLotNumber
            // 
            this.cmbLotNumber.FormattingEnabled = true;
            this.cmbLotNumber.Location = new System.Drawing.Point(272, 29);
            this.cmbLotNumber.Name = "cmbLotNumber";
            this.cmbLotNumber.Size = new System.Drawing.Size(135, 23);
            this.cmbLotNumber.TabIndex = 5;
            this.cmbLotNumber.SelectedIndexChanged += new System.EventHandler(this.cmbLotNumber_SelectedIndexChanged);
            this.cmbLotNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbOrder_KeyDown);
            // 
            // lblSalesOrder
            // 
            this.lblSalesOrder.AutoSize = true;
            this.lblSalesOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrder.Location = new System.Drawing.Point(269, 11);
            this.lblSalesOrder.Name = "lblSalesOrder";
            this.lblSalesOrder.Size = new System.Drawing.Size(35, 15);
            this.lblSalesOrder.TabIndex = 4;
            this.lblSalesOrder.Text = "Lote";
            // 
            // grpbDetail
            // 
            this.grpbDetail.Controls.Add(this.dgvDetails);
            this.grpbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDetail.Location = new System.Drawing.Point(0, 57);
            this.grpbDetail.Name = "grpbDetail";
            this.grpbDetail.Size = new System.Drawing.Size(1154, 470);
            this.grpbDetail.TabIndex = 1;
            this.grpbDetail.TabStop = false;
            this.grpbDetail.Text = "Detalle";
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToOrderColumns = true;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmcodsec,
            this.clmlotnumber,
            this.clmmaincoil,
            this.clmnetweigth,
            this.clmconsuption,
            this.clmconsuptionobs,
            this.clmdecrease,
            this.clmrefile,
            this.clmendroller,
            this.clmwaste,
            this.clmissplice,
            this.clmefficiency,
            this.clmview});
            this.dgvDetails.Location = new System.Drawing.Point(3, 14);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersWidth = 10;
            this.dgvDetails.Size = new System.Drawing.Size(1148, 453);
            this.dgvDetails.TabIndex = 0;
            this.dgvDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetails_CellContentClick);
            // 
            // grpbFooter
            // 
            this.grpbFooter.Controls.Add(this.label6);
            this.grpbFooter.Controls.Add(this.lblEfficiency);
            this.grpbFooter.Controls.Add(this.label10);
            this.grpbFooter.Controls.Add(this.label1);
            this.grpbFooter.Controls.Add(this.lblMainCoilWeigth);
            this.grpbFooter.Controls.Add(this.label7);
            this.grpbFooter.Controls.Add(this.label9);
            this.grpbFooter.Controls.Add(this.lblDecrease);
            this.grpbFooter.Controls.Add(this.label11);
            this.grpbFooter.Controls.Add(this.label5);
            this.grpbFooter.Controls.Add(this.label4);
            this.grpbFooter.Controls.Add(this.label3);
            this.grpbFooter.Controls.Add(this.lblMainCoilQuantity);
            this.grpbFooter.Controls.Add(this.label2);
            this.grpbFooter.Controls.Add(this.lblTotalConsuptionObs);
            this.grpbFooter.Controls.Add(this.lblTotalWeightLabel);
            this.grpbFooter.Controls.Add(this.lblTotalConsuptionP);
            this.grpbFooter.Controls.Add(this.lblTotalPalletsLabel);
            this.grpbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFooter.Location = new System.Drawing.Point(0, 527);
            this.grpbFooter.Name = "grpbFooter";
            this.grpbFooter.Size = new System.Drawing.Size(1154, 46);
            this.grpbFooter.TabIndex = 2;
            this.grpbFooter.TabStop = false;
            this.grpbFooter.Text = "Resumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "%.";
            // 
            // lblEfficiency
            // 
            this.lblEfficiency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfficiency.Location = new System.Drawing.Point(421, 17);
            this.lblEfficiency.Name = "lblEfficiency";
            this.lblEfficiency.Size = new System.Drawing.Size(58, 20);
            this.lblEfficiency.TabIndex = 23;
            this.lblEfficiency.Text = "100";
            this.lblEfficiency.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(342, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Eficiencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kgs.";
            // 
            // lblMainCoilWeigth
            // 
            this.lblMainCoilWeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainCoilWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilWeigth.Location = new System.Drawing.Point(211, 16);
            this.lblMainCoilWeigth.Name = "lblMainCoilWeigth";
            this.lblMainCoilWeigth.Size = new System.Drawing.Size(94, 20);
            this.lblMainCoilWeigth.TabIndex = 20;
            this.lblMainCoilWeigth.Text = "0";
            this.lblMainCoilWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(153, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Bob P";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1108, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kgs.";
            // 
            // lblDecrease
            // 
            this.lblDecrease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrease.Location = new System.Drawing.Point(1011, 16);
            this.lblDecrease.Name = "lblDecrease";
            this.lblDecrease.Size = new System.Drawing.Size(94, 20);
            this.lblDecrease.TabIndex = 17;
            this.lblDecrease.Text = "0";
            this.lblDecrease.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(962, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Desp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uni.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(933, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kgs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kgs.";
            // 
            // lblMainCoilQuantity
            // 
            this.lblMainCoilQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMainCoilQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainCoilQuantity.Location = new System.Drawing.Point(73, 16);
            this.lblMainCoilQuantity.Name = "lblMainCoilQuantity";
            this.lblMainCoilQuantity.Size = new System.Drawing.Size(51, 20);
            this.lblMainCoilQuantity.TabIndex = 9;
            this.lblMainCoilQuantity.Text = "0";
            this.lblMainCoilQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "# Bob M";
            // 
            // lblTotalConsuptionObs
            // 
            this.lblTotalConsuptionObs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalConsuptionObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConsuptionObs.Location = new System.Drawing.Point(837, 16);
            this.lblTotalConsuptionObs.Name = "lblTotalConsuptionObs";
            this.lblTotalConsuptionObs.Size = new System.Drawing.Size(94, 20);
            this.lblTotalConsuptionObs.TabIndex = 3;
            this.lblTotalConsuptionObs.Text = "0";
            this.lblTotalConsuptionObs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalWeightLabel
            // 
            this.lblTotalWeightLabel.AutoSize = true;
            this.lblTotalWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeightLabel.Location = new System.Drawing.Point(721, 16);
            this.lblTotalWeightLabel.Name = "lblTotalWeightLabel";
            this.lblTotalWeightLabel.Size = new System.Drawing.Size(114, 20);
            this.lblTotalWeightLabel.TabIndex = 2;
            this.lblTotalWeightLabel.Text = "Consumo Obs.";
            // 
            // lblTotalConsuptionP
            // 
            this.lblTotalConsuptionP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalConsuptionP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalConsuptionP.Location = new System.Drawing.Point(595, 16);
            this.lblTotalConsuptionP.Name = "lblTotalConsuptionP";
            this.lblTotalConsuptionP.Size = new System.Drawing.Size(94, 20);
            this.lblTotalConsuptionP.TabIndex = 1;
            this.lblTotalConsuptionP.Text = "0";
            this.lblTotalConsuptionP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPalletsLabel
            // 
            this.lblTotalPalletsLabel.AutoSize = true;
            this.lblTotalPalletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPalletsLabel.Location = new System.Drawing.Point(502, 16);
            this.lblTotalPalletsLabel.Name = "lblTotalPalletsLabel";
            this.lblTotalPalletsLabel.Size = new System.Drawing.Size(91, 20);
            this.lblTotalPalletsLabel.TabIndex = 0;
            this.lblTotalPalletsLabel.Text = "Consumo P";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // clmcodsec
            // 
            this.clmcodsec.HeaderText = "codsec";
            this.clmcodsec.Name = "clmcodsec";
            this.clmcodsec.ReadOnly = true;
            this.clmcodsec.Visible = false;
            // 
            // clmlotnumber
            // 
            this.clmlotnumber.HeaderText = "Lote";
            this.clmlotnumber.Name = "clmlotnumber";
            this.clmlotnumber.ReadOnly = true;
            this.clmlotnumber.Width = 80;
            // 
            // clmmaincoil
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmmaincoil.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmmaincoil.HeaderText = "B Madre";
            this.clmmaincoil.Name = "clmmaincoil";
            this.clmmaincoil.ReadOnly = true;
            this.clmmaincoil.Width = 200;
            // 
            // clmnetweigth
            // 
            this.clmnetweigth.HeaderText = "Peso";
            this.clmnetweigth.Name = "clmnetweigth";
            this.clmnetweigth.ReadOnly = true;
            this.clmnetweigth.Width = 80;
            // 
            // clmconsuption
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmconsuption.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmconsuption.HeaderText = "Consumo P";
            this.clmconsuption.Name = "clmconsuption";
            this.clmconsuption.ReadOnly = true;
            this.clmconsuption.Width = 80;
            // 
            // clmconsuptionobs
            // 
            this.clmconsuptionobs.HeaderText = "Consumo Obs.";
            this.clmconsuptionobs.Name = "clmconsuptionobs";
            this.clmconsuptionobs.ReadOnly = true;
            this.clmconsuptionobs.Width = 90;
            // 
            // clmdecrease
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmdecrease.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmdecrease.HeaderText = "Desperdicio";
            this.clmdecrease.Name = "clmdecrease";
            this.clmdecrease.ReadOnly = true;
            this.clmdecrease.Width = 80;
            // 
            // clmrefile
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmrefile.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmrefile.HeaderText = "Refilo";
            this.clmrefile.Name = "clmrefile";
            this.clmrefile.ReadOnly = true;
            this.clmrefile.Width = 70;
            // 
            // clmendroller
            // 
            this.clmendroller.HeaderText = "Fin Rollo";
            this.clmendroller.Name = "clmendroller";
            this.clmendroller.ReadOnly = true;
            this.clmendroller.Width = 80;
            // 
            // clmwaste
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmwaste.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmwaste.HeaderText = "Sobrante";
            this.clmwaste.Name = "clmwaste";
            this.clmwaste.ReadOnly = true;
            this.clmwaste.Width = 70;
            // 
            // clmissplice
            // 
            this.clmissplice.HeaderText = "Empalme";
            this.clmissplice.Name = "clmissplice";
            this.clmissplice.ReadOnly = true;
            this.clmissplice.Width = 60;
            // 
            // clmefficiency
            // 
            this.clmefficiency.HeaderText = "Eficiencia";
            this.clmefficiency.Name = "clmefficiency";
            this.clmefficiency.ReadOnly = true;
            this.clmefficiency.Width = 60;
            // 
            // clmview
            // 
            this.clmview.HeaderText = "";
            this.clmview.Name = "clmview";
            this.clmview.ReadOnly = true;
            this.clmview.Width = 30;
            // 
            // frmEfficiencyCutExtruder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1154, 573);
            this.Controls.Add(this.grpbDetail);
            this.Controls.Add(this.grpbFooter);
            this.Controls.Add(this.grpbFilters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEfficiencyCutExtruder";
            this.Text = "Eficiencia por Lote";
            this.Load += new System.EventHandler(this.frmEfficiencyCut_Load);
            this.grpbFilters.ResumeLayout(false);
            this.grpbFilters.PerformLayout();
            this.grpbDetail.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblSalesOrder;
        private System.Windows.Forms.ComboBox cmbLotNumber;
        private System.Windows.Forms.Button btnMainCoilClearFilters;
        private System.Windows.Forms.Label lblTotalConsuptionP;
        private System.Windows.Forms.Label lblTotalPalletsLabel;
        private System.Windows.Forms.Label lblTotalConsuptionObs;
        private System.Windows.Forms.Label lblTotalWeightLabel;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblLotNumber;
        private System.Windows.Forms.Label lblMainCoilQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDecrease;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEfficiency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMainCoilWeigth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmlotnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmaincoil;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmconsuption;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmconsuptionobs;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdecrease;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrefile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmendroller;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmwaste;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmissplice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmefficiency;
        private System.Windows.Forms.DataGridViewImageColumn clmview;
    }
}