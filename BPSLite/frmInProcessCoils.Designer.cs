namespace BPS.Lite
{
    partial class frmInProcessCoils
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInProcessCoils));
            this.dgvInProcessCoils = new System.Windows.Forms.DataGridView();
            this.clmInProcessCoilCodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessFilm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessWitdth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessObservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessRework = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessReworkDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessUsefulWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessFkuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmInProcessRevisiondate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtInProcessUsefulWidth = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInProcessReworkDetail = new System.Windows.Forms.TextBox();
            this.cmbInProcessRework = new System.Windows.Forms.ComboBox();
            this.cmbInProcessDestination = new System.Windows.Forms.ComboBox();
            this.txtInProcessObservations = new System.Windows.Forms.TextBox();
            this.txtInProcessWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInProcessWitdth = new System.Windows.Forms.TextBox();
            this.txtInProcessLength = new System.Windows.Forms.TextBox();
            this.txtInProcessCustomer = new System.Windows.Forms.TextBox();
            this.txtInProcessProduct = new System.Windows.Forms.TextBox();
            this.txtInProcessCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnInProcessCoilsExport = new System.Windows.Forms.Button();
            this.btnInProcessNoFilter = new System.Windows.Forms.Button();
            this.btnInProcessFilter = new System.Windows.Forms.Button();
            this.cmbInProcessCoilsFilm = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtInProcessCoilsCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProcessCoils)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInProcessCoils
            // 
            this.dgvInProcessCoils.AllowUserToAddRows = false;
            this.dgvInProcessCoils.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProcessCoils.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmInProcessCoilCodsec,
            this.clmInProcessFilm,
            this.clmInProcessCode,
            this.clmInProcessProduct,
            this.clmInProcessCustomer,
            this.clmInProcessLength,
            this.clmInProcessWitdth,
            this.clmInProcessWeight,
            this.clmInProcessObservations,
            this.clmInProcessDestination,
            this.clmInProcessRework,
            this.clmInProcessReworkDetail,
            this.clmInProcessUsefulWidth,
            this.clmInProcessFkuser,
            this.clmInProcessRevisiondate});
            this.dgvInProcessCoils.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInProcessCoils.Location = new System.Drawing.Point(3, 16);
            this.dgvInProcessCoils.Name = "dgvInProcessCoils";
            this.dgvInProcessCoils.ReadOnly = true;
            this.dgvInProcessCoils.Size = new System.Drawing.Size(1028, 210);
            this.dgvInProcessCoils.TabIndex = 0;
            this.dgvInProcessCoils.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInProcessCoils_CellClick);
            this.dgvInProcessCoils.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInProcessCoils_CellDoubleClick);
            // 
            // clmInProcessCoilCodsec
            // 
            this.clmInProcessCoilCodsec.HeaderText = "Codsec";
            this.clmInProcessCoilCodsec.Name = "clmInProcessCoilCodsec";
            this.clmInProcessCoilCodsec.ReadOnly = true;
            this.clmInProcessCoilCodsec.Visible = false;
            this.clmInProcessCoilCodsec.Width = 200;
            // 
            // clmInProcessFilm
            // 
            this.clmInProcessFilm.HeaderText = "Película";
            this.clmInProcessFilm.Name = "clmInProcessFilm";
            this.clmInProcessFilm.ReadOnly = true;
            this.clmInProcessFilm.Visible = false;
            // 
            // clmInProcessCode
            // 
            this.clmInProcessCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmInProcessCode.HeaderText = "Código";
            this.clmInProcessCode.Name = "clmInProcessCode";
            this.clmInProcessCode.ReadOnly = true;
            this.clmInProcessCode.Width = 65;
            // 
            // clmInProcessProduct
            // 
            this.clmInProcessProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmInProcessProduct.HeaderText = "Producto";
            this.clmInProcessProduct.Name = "clmInProcessProduct";
            this.clmInProcessProduct.ReadOnly = true;
            this.clmInProcessProduct.Width = 75;
            // 
            // clmInProcessCustomer
            // 
            this.clmInProcessCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmInProcessCustomer.HeaderText = "Cliente";
            this.clmInProcessCustomer.Name = "clmInProcessCustomer";
            this.clmInProcessCustomer.ReadOnly = true;
            this.clmInProcessCustomer.Width = 64;
            // 
            // clmInProcessLength
            // 
            this.clmInProcessLength.HeaderText = "Metraje";
            this.clmInProcessLength.Name = "clmInProcessLength";
            this.clmInProcessLength.ReadOnly = true;
            this.clmInProcessLength.Width = 60;
            // 
            // clmInProcessWitdth
            // 
            this.clmInProcessWitdth.HeaderText = "Ancho";
            this.clmInProcessWitdth.Name = "clmInProcessWitdth";
            this.clmInProcessWitdth.ReadOnly = true;
            this.clmInProcessWitdth.Width = 60;
            // 
            // clmInProcessWeight
            // 
            this.clmInProcessWeight.HeaderText = "Peso";
            this.clmInProcessWeight.Name = "clmInProcessWeight";
            this.clmInProcessWeight.ReadOnly = true;
            this.clmInProcessWeight.Width = 60;
            // 
            // clmInProcessObservations
            // 
            this.clmInProcessObservations.HeaderText = "Observaciones";
            this.clmInProcessObservations.Name = "clmInProcessObservations";
            this.clmInProcessObservations.ReadOnly = true;
            this.clmInProcessObservations.Width = 150;
            // 
            // clmInProcessDestination
            // 
            this.clmInProcessDestination.HeaderText = "Destino";
            this.clmInProcessDestination.Name = "clmInProcessDestination";
            this.clmInProcessDestination.ReadOnly = true;
            // 
            // clmInProcessRework
            // 
            this.clmInProcessRework.HeaderText = "Retrabajo";
            this.clmInProcessRework.Name = "clmInProcessRework";
            this.clmInProcessRework.ReadOnly = true;
            // 
            // clmInProcessReworkDetail
            // 
            this.clmInProcessReworkDetail.HeaderText = "Detalle Retrabajo";
            this.clmInProcessReworkDetail.Name = "clmInProcessReworkDetail";
            this.clmInProcessReworkDetail.ReadOnly = true;
            this.clmInProcessReworkDetail.Width = 150;
            // 
            // clmInProcessUsefulWidth
            // 
            this.clmInProcessUsefulWidth.HeaderText = "Ancho Util";
            this.clmInProcessUsefulWidth.Name = "clmInProcessUsefulWidth";
            this.clmInProcessUsefulWidth.ReadOnly = true;
            this.clmInProcessUsefulWidth.Width = 60;
            // 
            // clmInProcessFkuser
            // 
            this.clmInProcessFkuser.HeaderText = "Usuario";
            this.clmInProcessFkuser.Name = "clmInProcessFkuser";
            this.clmInProcessFkuser.ReadOnly = true;
            // 
            // clmInProcessRevisiondate
            // 
            this.clmInProcessRevisiondate.HeaderText = "Fecha de revisión";
            this.clmInProcessRevisiondate.Name = "clmInProcessRevisiondate";
            this.clmInProcessRevisiondate.ReadOnly = true;
            this.clmInProcessRevisiondate.Width = 140;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInProcessCoils);
            this.groupBox1.Location = new System.Drawing.Point(1, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1034, 229);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtInProcessUsefulWidth);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtInProcessReworkDetail);
            this.groupBox2.Controls.Add(this.cmbInProcessRework);
            this.groupBox2.Controls.Add(this.cmbInProcessDestination);
            this.groupBox2.Controls.Add(this.txtInProcessObservations);
            this.groupBox2.Controls.Add(this.txtInProcessWeight);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtInProcessWitdth);
            this.groupBox2.Controls.Add(this.txtInProcessLength);
            this.groupBox2.Controls.Add(this.txtInProcessCustomer);
            this.groupBox2.Controls.Add(this.txtInProcessProduct);
            this.groupBox2.Controls.Add(this.txtInProcessCode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(4, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1028, 190);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txtInProcessUsefulWidth
            // 
            this.txtInProcessUsefulWidth.Enabled = false;
            this.txtInProcessUsefulWidth.Location = new System.Drawing.Point(898, 10);
            this.txtInProcessUsefulWidth.Name = "txtInProcessUsefulWidth";
            this.txtInProcessUsefulWidth.Size = new System.Drawing.Size(71, 20);
            this.txtInProcessUsefulWidth.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(833, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Ancho Util:";
            // 
            // txtInProcessReworkDetail
            // 
            this.txtInProcessReworkDetail.Enabled = false;
            this.txtInProcessReworkDetail.Location = new System.Drawing.Point(607, 90);
            this.txtInProcessReworkDetail.Multiline = true;
            this.txtInProcessReworkDetail.Name = "txtInProcessReworkDetail";
            this.txtInProcessReworkDetail.Size = new System.Drawing.Size(327, 94);
            this.txtInProcessReworkDetail.TabIndex = 31;
            // 
            // cmbInProcessRework
            // 
            this.cmbInProcessRework.Enabled = false;
            this.cmbInProcessRework.FormattingEnabled = true;
            this.cmbInProcessRework.Items.AddRange(new object[] {
            "Ninguno",
            "Rebobinado",
            "Refilo",
            "Otro"});
            this.cmbInProcessRework.Location = new System.Drawing.Point(607, 49);
            this.cmbInProcessRework.Name = "cmbInProcessRework";
            this.cmbInProcessRework.Size = new System.Drawing.Size(208, 21);
            this.cmbInProcessRework.TabIndex = 30;
            // 
            // cmbInProcessDestination
            // 
            this.cmbInProcessDestination.Enabled = false;
            this.cmbInProcessDestination.FormattingEnabled = true;
            this.cmbInProcessDestination.Items.AddRange(new object[] {
            "Primera",
            "En Proceso",
            "Segunda"});
            this.cmbInProcessDestination.Location = new System.Drawing.Point(607, 13);
            this.cmbInProcessDestination.Name = "cmbInProcessDestination";
            this.cmbInProcessDestination.Size = new System.Drawing.Size(208, 21);
            this.cmbInProcessDestination.TabIndex = 29;
            this.cmbInProcessDestination.SelectedIndexChanged += new System.EventHandler(this.cmbInProcessDestination_SelectedIndexChanged);
            // 
            // txtInProcessObservations
            // 
            this.txtInProcessObservations.Enabled = false;
            this.txtInProcessObservations.Location = new System.Drawing.Point(137, 127);
            this.txtInProcessObservations.Multiline = true;
            this.txtInProcessObservations.Name = "txtInProcessObservations";
            this.txtInProcessObservations.Size = new System.Drawing.Size(342, 57);
            this.txtInProcessObservations.TabIndex = 28;
            // 
            // txtInProcessWeight
            // 
            this.txtInProcessWeight.Enabled = false;
            this.txtInProcessWeight.Location = new System.Drawing.Point(379, 90);
            this.txtInProcessWeight.Name = "txtInProcessWeight";
            this.txtInProcessWeight.Size = new System.Drawing.Size(100, 20);
            this.txtInProcessWeight.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Observaciones:";
            // 
            // txtInProcessWitdth
            // 
            this.txtInProcessWitdth.Enabled = false;
            this.txtInProcessWitdth.Location = new System.Drawing.Point(379, 50);
            this.txtInProcessWitdth.Name = "txtInProcessWitdth";
            this.txtInProcessWitdth.Size = new System.Drawing.Size(100, 20);
            this.txtInProcessWitdth.TabIndex = 26;
            // 
            // txtInProcessLength
            // 
            this.txtInProcessLength.Enabled = false;
            this.txtInProcessLength.Location = new System.Drawing.Point(379, 13);
            this.txtInProcessLength.Name = "txtInProcessLength";
            this.txtInProcessLength.Size = new System.Drawing.Size(100, 20);
            this.txtInProcessLength.TabIndex = 25;
            // 
            // txtInProcessCustomer
            // 
            this.txtInProcessCustomer.Enabled = false;
            this.txtInProcessCustomer.Location = new System.Drawing.Point(137, 90);
            this.txtInProcessCustomer.Name = "txtInProcessCustomer";
            this.txtInProcessCustomer.Size = new System.Drawing.Size(185, 20);
            this.txtInProcessCustomer.TabIndex = 24;
            // 
            // txtInProcessProduct
            // 
            this.txtInProcessProduct.Enabled = false;
            this.txtInProcessProduct.Location = new System.Drawing.Point(137, 54);
            this.txtInProcessProduct.Name = "txtInProcessProduct";
            this.txtInProcessProduct.Size = new System.Drawing.Size(134, 20);
            this.txtInProcessProduct.TabIndex = 23;
            // 
            // txtInProcessCode
            // 
            this.txtInProcessCode.Enabled = false;
            this.txtInProcessCode.Location = new System.Drawing.Point(137, 19);
            this.txtInProcessCode.Name = "txtInProcessCode";
            this.txtInProcessCode.Size = new System.Drawing.Size(134, 20);
            this.txtInProcessCode.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(509, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Detalle Retrabajo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Retrabajo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(509, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Peso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ancho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Metraje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnInProcessCoilsExport);
            this.groupBox3.Controls.Add(this.btnInProcessNoFilter);
            this.groupBox3.Controls.Add(this.btnInProcessFilter);
            this.groupBox3.Controls.Add(this.cmbInProcessCoilsFilm);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtInProcessCoilsCode);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(1, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1034, 51);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar";
            // 
            // btnInProcessCoilsExport
            // 
            this.btnInProcessCoilsExport.Image = global::BPS.Lite.Properties.Resources.doc_excel_table;
            this.btnInProcessCoilsExport.Location = new System.Drawing.Point(994, 17);
            this.btnInProcessCoilsExport.Name = "btnInProcessCoilsExport";
            this.btnInProcessCoilsExport.Size = new System.Drawing.Size(31, 26);
            this.btnInProcessCoilsExport.TabIndex = 6;
            this.btnInProcessCoilsExport.UseVisualStyleBackColor = true;
            this.btnInProcessCoilsExport.Click += new System.EventHandler(this.btnInProcessCoilsExport_Click);
            // 
            // btnInProcessNoFilter
            // 
            this.btnInProcessNoFilter.Image = global::BPS.Lite.Properties.Resources.funnel_clear;
            this.btnInProcessNoFilter.Location = new System.Drawing.Point(640, 20);
            this.btnInProcessNoFilter.Name = "btnInProcessNoFilter";
            this.btnInProcessNoFilter.Size = new System.Drawing.Size(75, 23);
            this.btnInProcessNoFilter.TabIndex = 5;
            this.btnInProcessNoFilter.UseVisualStyleBackColor = true;
            this.btnInProcessNoFilter.Click += new System.EventHandler(this.btnInProcessNoFilter_Click);
            // 
            // btnInProcessFilter
            // 
            this.btnInProcessFilter.Image = global::BPS.Lite.Properties.Resources.funnel;
            this.btnInProcessFilter.Location = new System.Drawing.Point(559, 20);
            this.btnInProcessFilter.Name = "btnInProcessFilter";
            this.btnInProcessFilter.Size = new System.Drawing.Size(75, 23);
            this.btnInProcessFilter.TabIndex = 4;
            this.btnInProcessFilter.UseVisualStyleBackColor = true;
            this.btnInProcessFilter.Click += new System.EventHandler(this.btnInProcessFilter_Click);
            // 
            // cmbInProcessCoilsFilm
            // 
            this.cmbInProcessCoilsFilm.FormattingEnabled = true;
            this.cmbInProcessCoilsFilm.Location = new System.Drawing.Point(371, 20);
            this.cmbInProcessCoilsFilm.Name = "cmbInProcessCoilsFilm";
            this.cmbInProcessCoilsFilm.Size = new System.Drawing.Size(182, 21);
            this.cmbInProcessCoilsFilm.TabIndex = 3;
            this.cmbInProcessCoilsFilm.SelectedIndexChanged += new System.EventHandler(this.cmbInProcessCoilsFilm_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(305, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Pelìcula:";
            // 
            // txtInProcessCoilsCode
            // 
            this.txtInProcessCoilsCode.Location = new System.Drawing.Point(70, 20);
            this.txtInProcessCoilsCode.Name = "txtInProcessCoilsCode";
            this.txtInProcessCoilsCode.Size = new System.Drawing.Size(216, 20);
            this.txtInProcessCoilsCode.TabIndex = 1;
            this.txtInProcessCoilsCode.Leave += new System.EventHandler(this.txtInProcessCoilsCode_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Código:";
            // 
            // frmInProcessCoils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 494);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInProcessCoils";
            this.Text = "Bobinas en Proceso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProcessCoils)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInProcessCoils;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInProcessReworkDetail;
        private System.Windows.Forms.ComboBox cmbInProcessRework;
        private System.Windows.Forms.ComboBox cmbInProcessDestination;
        private System.Windows.Forms.TextBox txtInProcessObservations;
        private System.Windows.Forms.TextBox txtInProcessWeight;
        private System.Windows.Forms.TextBox txtInProcessWitdth;
        private System.Windows.Forms.TextBox txtInProcessLength;
        private System.Windows.Forms.TextBox txtInProcessCustomer;
        private System.Windows.Forms.TextBox txtInProcessProduct;
        private System.Windows.Forms.TextBox txtInProcessCode;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInProcessUsefulWidth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbInProcessCoilsFilm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnInProcessNoFilter;
        private System.Windows.Forms.Button btnInProcessFilter;
        private System.Windows.Forms.TextBox txtInProcessCoilsCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessCoilCodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessFilm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessWitdth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessObservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessRework;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessReworkDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessUsefulWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessFkuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmInProcessRevisiondate;
        private System.Windows.Forms.Button btnInProcessCoilsExport;
    }
}