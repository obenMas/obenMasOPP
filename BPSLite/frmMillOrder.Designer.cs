namespace BPS.Lite
{
    partial class frmMillOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMillOrder));
            this.tbcMetalized = new System.Windows.Forms.TabControl();
            this.tbpCoil = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpbProcess = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDeadTime = new System.Windows.Forms.DataGridView();
            this.clmdeadcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadfkOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadinitdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadenddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeadtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdeaddetele = new System.Windows.Forms.DataGridViewImageColumn();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.cmbDeadTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddDeadTime = new System.Windows.Forms.Button();
            this.grpbCoilWeigth = new System.Windows.Forms.GroupBox();
            this.txtMyDensity = new System.Windows.Forms.TextBox();
            this.cmbEntity = new System.Windows.Forms.ComboBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.cmbOper = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ptbMill = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMillDrow = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDensity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpbNotes = new System.Windows.Forms.GroupBox();
            this.txtObservations = new System.Windows.Forms.TextBox();
            this.lblIdenty = new System.Windows.Forms.Label();
            this.pnlMetalized = new System.Windows.Forms.Panel();
            this.chkManualWeight = new System.Windows.Forms.CheckBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtgrossweigth = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWeigth = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNetWeigth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMetalizedNetWeigth = new System.Windows.Forms.Label();
            this.txtpallet = new System.Windows.Forms.TextBox();
            this.txtSequiential = new System.Windows.Forms.TextBox();
            this.cmbMill = new System.Windows.Forms.ComboBox();
            this.cmbMilProduct = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbFooter = new System.Windows.Forms.GroupBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnCloseMetalizedOrder = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tbcMetalized.SuspendLayout();
            this.tbpCoil.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpbProcess.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).BeginInit();
            this.grpbCoilWeigth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpbNotes.SuspendLayout();
            this.pnlMetalized.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.grpbFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcMetalized
            // 
            this.tbcMetalized.Controls.Add(this.tbpCoil);
            this.tbcMetalized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMetalized.Location = new System.Drawing.Point(0, 0);
            this.tbcMetalized.Name = "tbcMetalized";
            this.tbcMetalized.SelectedIndex = 0;
            this.tbcMetalized.Size = new System.Drawing.Size(890, 601);
            this.tbcMetalized.TabIndex = 0;
            // 
            // tbpCoil
            // 
            this.tbpCoil.Controls.Add(this.groupBox1);
            this.tbpCoil.Controls.Add(this.grpbCoilWeigth);
            this.tbpCoil.Location = new System.Drawing.Point(4, 24);
            this.tbpCoil.Name = "tbpCoil";
            this.tbpCoil.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCoil.Size = new System.Drawing.Size(882, 573);
            this.tbpCoil.TabIndex = 0;
            this.tbpCoil.Text = "Material Reproceso";
            this.tbpCoil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpbProcess);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // grpbProcess
            // 
            this.grpbProcess.Controls.Add(this.groupBox2);
            this.grpbProcess.Controls.Add(this.dtpEndDate);
            this.grpbProcess.Controls.Add(this.dtpInitDate);
            this.grpbProcess.Controls.Add(this.cmbDeadTime);
            this.grpbProcess.Controls.Add(this.label5);
            this.grpbProcess.Controls.Add(this.label7);
            this.grpbProcess.Controls.Add(this.label9);
            this.grpbProcess.Controls.Add(this.btnAddDeadTime);
            this.grpbProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbProcess.Location = new System.Drawing.Point(3, 17);
            this.grpbProcess.Name = "grpbProcess";
            this.grpbProcess.Size = new System.Drawing.Size(870, 271);
            this.grpbProcess.TabIndex = 1;
            this.grpbProcess.TabStop = false;
            this.grpbProcess.Text = "Tiempos Muertos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDeadTime);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(864, 218);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // dgvDeadTime
            // 
            this.dgvDeadTime.AllowUserToAddRows = false;
            this.dgvDeadTime.AllowUserToDeleteRows = false;
            this.dgvDeadTime.AllowUserToOrderColumns = true;
            this.dgvDeadTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeadTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmdeadcodsec,
            this.clmdeadcode,
            this.clmdeadfkOrder,
            this.clmdeadgroup,
            this.clmdeadname,
            this.clmdeadinitdate,
            this.clmdeadenddate,
            this.clmdeadtotal,
            this.clmdeaddetele});
            this.dgvDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeadTime.Location = new System.Drawing.Point(3, 14);
            this.dgvDeadTime.Name = "dgvDeadTime";
            this.dgvDeadTime.ReadOnly = true;
            this.dgvDeadTime.RowHeadersWidth = 21;
            this.dgvDeadTime.Size = new System.Drawing.Size(858, 201);
            this.dgvDeadTime.TabIndex = 0;
            this.dgvDeadTime.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeadTime_CellContentClick);
            // 
            // clmdeadcodsec
            // 
            this.clmdeadcodsec.HeaderText = "codsec";
            this.clmdeadcodsec.Name = "clmdeadcodsec";
            this.clmdeadcodsec.ReadOnly = true;
            this.clmdeadcodsec.Visible = false;
            // 
            // clmdeadcode
            // 
            this.clmdeadcode.HeaderText = "Código";
            this.clmdeadcode.Name = "clmdeadcode";
            this.clmdeadcode.ReadOnly = true;
            // 
            // clmdeadfkOrder
            // 
            this.clmdeadfkOrder.HeaderText = "fkOrder";
            this.clmdeadfkOrder.Name = "clmdeadfkOrder";
            this.clmdeadfkOrder.ReadOnly = true;
            this.clmdeadfkOrder.Visible = false;
            // 
            // clmdeadgroup
            // 
            this.clmdeadgroup.HeaderText = "Tipo Tiempo Muerto";
            this.clmdeadgroup.Name = "clmdeadgroup";
            this.clmdeadgroup.ReadOnly = true;
            this.clmdeadgroup.Width = 130;
            // 
            // clmdeadname
            // 
            this.clmdeadname.HeaderText = "Razon Tiempo Muerto";
            this.clmdeadname.Name = "clmdeadname";
            this.clmdeadname.ReadOnly = true;
            this.clmdeadname.Width = 180;
            // 
            // clmdeadinitdate
            // 
            this.clmdeadinitdate.HeaderText = "F. Inicio";
            this.clmdeadinitdate.Name = "clmdeadinitdate";
            this.clmdeadinitdate.ReadOnly = true;
            this.clmdeadinitdate.Width = 130;
            // 
            // clmdeadenddate
            // 
            this.clmdeadenddate.HeaderText = "F. Fin";
            this.clmdeadenddate.Name = "clmdeadenddate";
            this.clmdeadenddate.ReadOnly = true;
            this.clmdeadenddate.Width = 130;
            // 
            // clmdeadtotal
            // 
            this.clmdeadtotal.HeaderText = "T M total";
            this.clmdeadtotal.Name = "clmdeadtotal";
            this.clmdeadtotal.ReadOnly = true;
            this.clmdeadtotal.Width = 80;
            // 
            // clmdeaddetele
            // 
            this.clmdeaddetele.HeaderText = "";
            this.clmdeaddetele.Name = "clmdeaddetele";
            this.clmdeaddetele.ReadOnly = true;
            this.clmdeaddetele.Width = 30;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(678, 20);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(134, 21);
            this.dtpEndDate.TabIndex = 48;
            // 
            // dtpInitDate
            // 
            this.dtpInitDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(514, 20);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(133, 21);
            this.dtpInitDate.TabIndex = 47;
            // 
            // cmbDeadTime
            // 
            this.cmbDeadTime.FormattingEnabled = true;
            this.cmbDeadTime.Location = new System.Drawing.Point(59, 20);
            this.cmbDeadTime.Name = "cmbDeadTime";
            this.cmbDeadTime.Size = new System.Drawing.Size(410, 23);
            this.cmbDeadTime.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Razón";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(651, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Inicio";
            // 
            // btnAddDeadTime
            // 
            this.btnAddDeadTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddDeadTime.BackgroundImage = global::BPS.Lite.Properties.Resources.add1;
            this.btnAddDeadTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddDeadTime.Location = new System.Drawing.Point(825, 18);
            this.btnAddDeadTime.Name = "btnAddDeadTime";
            this.btnAddDeadTime.Size = new System.Drawing.Size(25, 25);
            this.btnAddDeadTime.TabIndex = 42;
            this.btnAddDeadTime.UseVisualStyleBackColor = true;
            this.btnAddDeadTime.Click += new System.EventHandler(this.btnAddDeadTime_Click);
            // 
            // grpbCoilWeigth
            // 
            this.grpbCoilWeigth.Controls.Add(this.txtMyDensity);
            this.grpbCoilWeigth.Controls.Add(this.cmbEntity);
            this.grpbCoilWeigth.Controls.Add(this.lblCode);
            this.grpbCoilWeigth.Controls.Add(this.cmbOper);
            this.grpbCoilWeigth.Controls.Add(this.label11);
            this.grpbCoilWeigth.Controls.Add(this.ptbMill);
            this.grpbCoilWeigth.Controls.Add(this.pictureBox3);
            this.grpbCoilWeigth.Controls.Add(this.pictureBox2);
            this.grpbCoilWeigth.Controls.Add(this.pictureBox1);
            this.grpbCoilWeigth.Controls.Add(this.lblMillDrow);
            this.grpbCoilWeigth.Controls.Add(this.label10);
            this.grpbCoilWeigth.Controls.Add(this.txtBag);
            this.grpbCoilWeigth.Controls.Add(this.label8);
            this.grpbCoilWeigth.Controls.Add(this.lblDensity);
            this.grpbCoilWeigth.Controls.Add(this.label4);
            this.grpbCoilWeigth.Controls.Add(this.grpbNotes);
            this.grpbCoilWeigth.Controls.Add(this.lblIdenty);
            this.grpbCoilWeigth.Controls.Add(this.pnlMetalized);
            this.grpbCoilWeigth.Controls.Add(this.cmbMill);
            this.grpbCoilWeigth.Controls.Add(this.cmbMilProduct);
            this.grpbCoilWeigth.Controls.Add(this.label3);
            this.grpbCoilWeigth.Controls.Add(this.label2);
            this.grpbCoilWeigth.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbCoilWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCoilWeigth.Location = new System.Drawing.Point(3, 3);
            this.grpbCoilWeigth.Name = "grpbCoilWeigth";
            this.grpbCoilWeigth.Size = new System.Drawing.Size(876, 276);
            this.grpbCoilWeigth.TabIndex = 1;
            this.grpbCoilWeigth.TabStop = false;
            this.grpbCoilWeigth.Text = "Reprocesado";
            // 
            // txtMyDensity
            // 
            this.txtMyDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMyDensity.ForeColor = System.Drawing.Color.Blue;
            this.txtMyDensity.Location = new System.Drawing.Point(608, 11);
            this.txtMyDensity.Name = "txtMyDensity";
            this.txtMyDensity.Size = new System.Drawing.Size(182, 38);
            this.txtMyDensity.TabIndex = 111;
            this.txtMyDensity.Text = "0";
            this.txtMyDensity.Visible = false;
            // 
            // cmbEntity
            // 
            this.cmbEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEntity.FormattingEnabled = true;
            this.cmbEntity.Items.AddRange(new object[] {
            "Transparente",
            "Transparente Recuperado",
            "Perlado",
            "Perlado Recuperado",
            "Metalizado",
            "Transiciones",
            "Pigmento Azul",
            "Master Batch",
            "Plástico Grueso"});
            this.cmbEntity.Location = new System.Drawing.Point(84, 13);
            this.cmbEntity.Name = "cmbEntity";
            this.cmbEntity.Size = new System.Drawing.Size(246, 28);
            this.cmbEntity.TabIndex = 59;
            // 
            // lblCode
            // 
            this.lblCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(742, 51);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(102, 26);
            this.lblCode.TabIndex = 58;
            // 
            // cmbOper
            // 
            this.cmbOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOper.FormattingEnabled = true;
            this.cmbOper.Items.AddRange(new object[] {
            "Eduardo Espinoza",
            "Raúl Ortíz",
            "Edison Quispe",
            "Paulo Baquerizo",
            "Luis Congo",
            "Santiago Cupuepan",
            "Edgar Quingaluiza"});
            this.cmbOper.Location = new System.Drawing.Point(188, 106);
            this.cmbOper.Name = "cmbOper";
            this.cmbOper.Size = new System.Drawing.Size(307, 24);
            this.cmbOper.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 57;
            this.label11.Text = "Montacargas";
            // 
            // ptbMill
            // 
            this.ptbMill.Location = new System.Drawing.Point(502, 80);
            this.ptbMill.Name = "ptbMill";
            this.ptbMill.Size = new System.Drawing.Size(52, 25);
            this.ptbMill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbMill.TabIndex = 55;
            this.ptbMill.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::BPS.Lite.Properties.Resources.cart_add;
            this.pictureBox3.Image = global::BPS.Lite.Properties.Resources.chart_line;
            this.pictureBox3.InitialImage = global::BPS.Lite.Properties.Resources.cart_add;
            this.pictureBox3.Location = new System.Drawing.Point(796, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::BPS.Lite.Properties.Resources.layout_content;
            this.pictureBox2.Image = global::BPS.Lite.Properties.Resources.layout_content;
            this.pictureBox2.InitialImage = global::BPS.Lite.Properties.Resources.layout_content;
            this.pictureBox2.Location = new System.Drawing.Point(478, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::BPS.Lite.Properties.Resources.cart_add;
            this.pictureBox1.Image = global::BPS.Lite.Properties.Resources.cart_add;
            this.pictureBox1.InitialImage = global::BPS.Lite.Properties.Resources.cart_add;
            this.pictureBox1.Location = new System.Drawing.Point(336, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // lblMillDrow
            // 
            this.lblMillDrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMillDrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMillDrow.Location = new System.Drawing.Point(559, 79);
            this.lblMillDrow.Name = "lblMillDrow";
            this.lblMillDrow.Size = new System.Drawing.Size(181, 26);
            this.lblMillDrow.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(378, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Sacos";
            // 
            // txtBag
            // 
            this.txtBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBag.Location = new System.Drawing.Point(423, 11);
            this.txtBag.Name = "txtBag";
            this.txtBag.Size = new System.Drawing.Size(49, 29);
            this.txtBag.TabIndex = 1;
            this.txtBag.Text = "40";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Cliente";
            // 
            // lblDensity
            // 
            this.lblDensity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDensity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDensity.Location = new System.Drawing.Point(608, 11);
            this.lblDensity.Name = "lblDensity";
            this.lblDensity.Size = new System.Drawing.Size(182, 29);
            this.lblDensity.TabIndex = 21;
            this.lblDensity.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Densidad";
            // 
            // grpbNotes
            // 
            this.grpbNotes.Controls.Add(this.txtObservations);
            this.grpbNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbNotes.Location = new System.Drawing.Point(3, 132);
            this.grpbNotes.Name = "grpbNotes";
            this.grpbNotes.Size = new System.Drawing.Size(870, 85);
            this.grpbNotes.TabIndex = 32;
            this.grpbNotes.TabStop = false;
            this.grpbNotes.Text = "Observaciones";
            // 
            // txtObservations
            // 
            this.txtObservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservations.Location = new System.Drawing.Point(3, 16);
            this.txtObservations.Multiline = true;
            this.txtObservations.Name = "txtObservations";
            this.txtObservations.Size = new System.Drawing.Size(864, 66);
            this.txtObservations.TabIndex = 0;
            // 
            // lblIdenty
            // 
            this.lblIdenty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdenty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdenty.Location = new System.Drawing.Point(501, 51);
            this.lblIdenty.Name = "lblIdenty";
            this.lblIdenty.Size = new System.Drawing.Size(239, 26);
            this.lblIdenty.TabIndex = 31;
            // 
            // pnlMetalized
            // 
            this.pnlMetalized.Controls.Add(this.chkManualWeight);
            this.pnlMetalized.Controls.Add(this.pictureBox4);
            this.pnlMetalized.Controls.Add(this.txtgrossweigth);
            this.pnlMetalized.Controls.Add(this.pictureBox5);
            this.pnlMetalized.Controls.Add(this.pictureBox6);
            this.pnlMetalized.Controls.Add(this.label6);
            this.pnlMetalized.Controls.Add(this.btnWeigth);
            this.pnlMetalized.Controls.Add(this.label12);
            this.pnlMetalized.Controls.Add(this.lblNetWeigth);
            this.pnlMetalized.Controls.Add(this.label1);
            this.pnlMetalized.Controls.Add(this.lblMetalizedNetWeigth);
            this.pnlMetalized.Controls.Add(this.txtpallet);
            this.pnlMetalized.Controls.Add(this.txtSequiential);
            this.pnlMetalized.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMetalized.Location = new System.Drawing.Point(3, 217);
            this.pnlMetalized.Name = "pnlMetalized";
            this.pnlMetalized.Size = new System.Drawing.Size(870, 56);
            this.pnlMetalized.TabIndex = 44;
            // 
            // chkManualWeight
            // 
            this.chkManualWeight.Location = new System.Drawing.Point(722, 9);
            this.chkManualWeight.Name = "chkManualWeight";
            this.chkManualWeight.Size = new System.Drawing.Size(67, 37);
            this.chkManualWeight.TabIndex = 110;
            this.chkManualWeight.Text = "Toma Manual";
            this.chkManualWeight.UseVisualStyleBackColor = true;
            this.chkManualWeight.CheckedChanged += new System.EventHandler(this.chkManualWeight_CheckedChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = global::BPS.Lite.Properties.Resources.shape_square_go;
            this.pictureBox4.Image = global::BPS.Lite.Properties.Resources.shape_square_go;
            this.pictureBox4.InitialImage = global::BPS.Lite.Properties.Resources.shape_square_go;
            this.pictureBox4.Location = new System.Drawing.Point(686, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // txtgrossweigth
            // 
            this.txtgrossweigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrossweigth.Location = new System.Drawing.Point(377, 12);
            this.txtgrossweigth.Name = "txtgrossweigth";
            this.txtgrossweigth.Size = new System.Drawing.Size(107, 29);
            this.txtgrossweigth.TabIndex = 1;
            this.txtgrossweigth.TextChanged += new System.EventHandler(this.txtgrossweigth_TextChanged);
            this.txtgrossweigth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgrossweigth_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.ErrorImage = global::BPS.Lite.Properties.Resources.shape_square_error;
            this.pictureBox5.Image = global::BPS.Lite.Properties.Resources.shape_square_error;
            this.pictureBox5.InitialImage = global::BPS.Lite.Properties.Resources.shape_square_error;
            this.pictureBox5.Location = new System.Drawing.Point(490, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 56;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ErrorImage = global::BPS.Lite.Properties.Resources.pallet;
            this.pictureBox6.Image = global::BPS.Lite.Properties.Resources.pallet;
            this.pictureBox6.InitialImage = global::BPS.Lite.Properties.Resources.pallet;
            this.pictureBox6.Location = new System.Drawing.Point(281, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 32);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 55;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Peso Pallet";
            // 
            // btnWeigth
            // 
            this.btnWeigth.Image = global::BPS.Lite.Properties.Resources.add_coil24;
            this.btnWeigth.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWeigth.Location = new System.Drawing.Point(790, 3);
            this.btnWeigth.Name = "btnWeigth";
            this.btnWeigth.Size = new System.Drawing.Size(75, 50);
            this.btnWeigth.TabIndex = 2;
            this.btnWeigth.Text = "Re-Proceso";
            this.btnWeigth.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWeigth.UseVisualStyleBackColor = true;
            this.btnWeigth.Click += new System.EventHandler(this.btnWeigth_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(315, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Peso Bruto";
            // 
            // lblNetWeigth
            // 
            this.lblNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetWeigth.ForeColor = System.Drawing.Color.Orange;
            this.lblNetWeigth.Location = new System.Drawing.Point(578, 12);
            this.lblNetWeigth.Name = "lblNetWeigth";
            this.lblNetWeigth.Size = new System.Drawing.Size(105, 34);
            this.lblNetWeigth.TabIndex = 16;
            this.lblNetWeigth.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Orden";
            // 
            // lblMetalizedNetWeigth
            // 
            this.lblMetalizedNetWeigth.AutoSize = true;
            this.lblMetalizedNetWeigth.Location = new System.Drawing.Point(519, 19);
            this.lblMetalizedNetWeigth.Name = "lblMetalizedNetWeigth";
            this.lblMetalizedNetWeigth.Size = new System.Drawing.Size(57, 13);
            this.lblMetalizedNetWeigth.TabIndex = 15;
            this.lblMetalizedNetWeigth.Text = "Peso Neto";
            // 
            // txtpallet
            // 
            this.txtpallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpallet.Location = new System.Drawing.Point(171, 12);
            this.txtpallet.Name = "txtpallet";
            this.txtpallet.Size = new System.Drawing.Size(107, 29);
            this.txtpallet.TabIndex = 0;
            this.txtpallet.TextChanged += new System.EventHandler(this.txtpallet_TextChanged);
            this.txtpallet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpallet_KeyPress);
            // 
            // txtSequiential
            // 
            this.txtSequiential.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSequiential.ForeColor = System.Drawing.Color.Gold;
            this.txtSequiential.Location = new System.Drawing.Point(39, 12);
            this.txtSequiential.Name = "txtSequiential";
            this.txtSequiential.Size = new System.Drawing.Size(68, 31);
            this.txtSequiential.TabIndex = 32;
            this.txtSequiential.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSequiential_KeyDown);
            // 
            // cmbMill
            // 
            this.cmbMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMill.FormattingEnabled = true;
            this.cmbMill.Items.AddRange(new object[] {
            "Transparente",
            "Perlado",
            "Metalizado",
            "Master Batch / MAS 15",
            "Mz"});
            this.cmbMill.Location = new System.Drawing.Point(188, 79);
            this.cmbMill.Name = "cmbMill";
            this.cmbMill.Size = new System.Drawing.Size(307, 24);
            this.cmbMill.TabIndex = 3;
            this.cmbMill.SelectedIndexChanged += new System.EventHandler(this.cmbMill_SelectedIndexChanged);
            // 
            // cmbMilProduct
            // 
            this.cmbMilProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMilProduct.FormattingEnabled = true;
            this.cmbMilProduct.Location = new System.Drawing.Point(188, 52);
            this.cmbMilProduct.Name = "cmbMilProduct";
            this.cmbMilProduct.Size = new System.Drawing.Size(307, 24);
            this.cmbMilProduct.TabIndex = 2;
            this.cmbMilProduct.SelectedIndexChanged += new System.EventHandler(this.cmbMilProduct_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tipo Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Molino";
            // 
            // grpbFooter
            // 
            this.grpbFooter.Controls.Add(this.btnprint);
            this.grpbFooter.Controls.Add(this.btnCloseMetalizedOrder);
            this.grpbFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpbFooter.Location = new System.Drawing.Point(0, 601);
            this.grpbFooter.Name = "grpbFooter";
            this.grpbFooter.Size = new System.Drawing.Size(890, 41);
            this.grpbFooter.TabIndex = 1;
            this.grpbFooter.TabStop = false;
            // 
            // btnprint
            // 
            this.btnprint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnprint.BackgroundImage = global::BPS.Lite.Properties.Resources.printer;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnprint.Location = new System.Drawing.Point(835, 10);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(25, 25);
            this.btnprint.TabIndex = 34;
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnCloseMetalizedOrder
            // 
            this.btnCloseMetalizedOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCloseMetalizedOrder.BackgroundImage = global::BPS.Lite.Properties.Resources.lock1;
            this.btnCloseMetalizedOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseMetalizedOrder.Location = new System.Drawing.Point(862, 10);
            this.btnCloseMetalizedOrder.Name = "btnCloseMetalizedOrder";
            this.btnCloseMetalizedOrder.Size = new System.Drawing.Size(25, 25);
            this.btnCloseMetalizedOrder.TabIndex = 33;
            this.btnCloseMetalizedOrder.UseVisualStyleBackColor = true;
            this.btnCloseMetalizedOrder.Click += new System.EventHandler(this.btnCloseMetalizedOrder_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "page_white_gear.png");
            this.imgList.Images.SetKeyName(1, "page_white_lightning.png");
            this.imgList.Images.SetKeyName(2, "page_white_ruby.png");
            this.imgList.Images.SetKeyName(3, "page_white_code_red.png");
            this.imgList.Images.SetKeyName(4, "page_white_freehand.png");
            this.imgList.Images.SetKeyName(5, "page_white_cd.png");
            // 
            // frmMillOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(890, 642);
            this.Controls.Add(this.tbcMetalized);
            this.Controls.Add(this.grpbFooter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMillOrder";
            this.Text = "Orden De Molinos - Detalles";
            this.Load += new System.EventHandler(this.frmMillOrder_Load);
            this.tbcMetalized.ResumeLayout(false);
            this.tbpCoil.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.grpbProcess.ResumeLayout(false);
            this.grpbProcess.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeadTime)).EndInit();
            this.grpbCoilWeigth.ResumeLayout(false);
            this.grpbCoilWeigth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpbNotes.ResumeLayout(false);
            this.grpbNotes.PerformLayout();
            this.pnlMetalized.ResumeLayout(false);
            this.pnlMetalized.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.grpbFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMetalized;
        private System.Windows.Forms.TabPage tbpCoil;
        private System.Windows.Forms.GroupBox grpbFooter;
        private System.Windows.Forms.Button btnCloseMetalizedOrder;
        private System.Windows.Forms.GroupBox grpbProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpallet;
        private System.Windows.Forms.GroupBox grpbNotes;
        private System.Windows.Forms.TextBox txtObservations;
        private System.Windows.Forms.GroupBox grpbCoilWeigth;
        private System.Windows.Forms.Label lblIdenty;
        private System.Windows.Forms.Panel pnlMetalized;
        private System.Windows.Forms.Button btnWeigth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNetWeigth;
        private System.Windows.Forms.Label lblMetalizedNetWeigth;
        private System.Windows.Forms.ComboBox cmbMill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDeadTime;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpInitDate;
        private System.Windows.Forms.ComboBox cmbDeadTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddDeadTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSequiential;
        private System.Windows.Forms.TextBox txtgrossweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadfkOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadgroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadinitdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadenddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdeadtotal;
        private System.Windows.Forms.DataGridViewImageColumn clmdeaddetele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDensity;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMillDrow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox ptbMill;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.ComboBox cmbOper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkManualWeight;
        private System.Windows.Forms.ComboBox cmbEntity;
        private System.Windows.Forms.ComboBox cmbMilProduct;
        private System.Windows.Forms.TextBox txtMyDensity;
    }
}