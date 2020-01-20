namespace BPS.Raw.In
{
    partial class frmInRaw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInRaw));
            this.tbcRawMaterial = new System.Windows.Forms.TabControl();
            this.tbpRawMaterial = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.clmrawmaterialcodsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialprovider = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialmaterialtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialmycode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialgrossweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialnetweigth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialbag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmateriallotnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrawmaterialdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPro = new System.Windows.Forms.Button();
            this.cmbRawMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbltmp = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txttotalwe = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbsilo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpalletbag = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnetweigthbag = new System.Windows.Forms.TextBox();
            this.txtLotnumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupdnumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblgrossweigth = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalNetWeigth = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbcRawMaterial.SuspendLayout();
            this.tbpRawMaterial.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdnumber)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcRawMaterial
            // 
            this.tbcRawMaterial.Controls.Add(this.tbpRawMaterial);
            this.tbcRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcRawMaterial.Location = new System.Drawing.Point(0, 0);
            this.tbcRawMaterial.Name = "tbcRawMaterial";
            this.tbcRawMaterial.SelectedIndex = 0;
            this.tbcRawMaterial.Size = new System.Drawing.Size(1112, 526);
            this.tbcRawMaterial.TabIndex = 0;
            // 
            // tbpRawMaterial
            // 
            this.tbpRawMaterial.Controls.Add(this.groupBox2);
            this.tbpRawMaterial.Controls.Add(this.groupBox1);
            this.tbpRawMaterial.Controls.Add(this.groupBox3);
            this.tbpRawMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpRawMaterial.Location = new System.Drawing.Point(4, 24);
            this.tbpRawMaterial.Name = "tbpRawMaterial";
            this.tbpRawMaterial.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRawMaterial.Size = new System.Drawing.Size(1104, 498);
            this.tbpRawMaterial.TabIndex = 0;
            this.tbpRawMaterial.Text = "Materia Prima ";
            this.tbpRawMaterial.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvRawMaterial);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1098, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.AllowUserToAddRows = false;
            this.dgvRawMaterial.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMaterial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmrawmaterialcodsec,
            this.clmrawmaterialnumber,
            this.clmrawmaterialprovider,
            this.clmrawmaterialmaterialtype,
            this.clmrawmaterialname,
            this.clmrawmaterialmycode,
            this.clmrawmaterialgrossweigth,
            this.clmrawmaterialnetweigth,
            this.clmrawmaterialbag,
            this.clmrawmateriallotnumber,
            this.clmrawmaterialcode,
            this.clmrawmaterialdelete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRawMaterial.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRawMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRawMaterial.Location = new System.Drawing.Point(3, 16);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRawMaterial.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRawMaterial.RowHeadersWidth = 21;
            this.dgvRawMaterial.Size = new System.Drawing.Size(1092, 310);
            this.dgvRawMaterial.TabIndex = 0;
            this.dgvRawMaterial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRawMaterial_CellContentClick);
            this.dgvRawMaterial.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvRawMaterial_CellValidating);
            this.dgvRawMaterial.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRawMaterial_DefaultValuesNeeded);
            // 
            // clmrawmaterialcodsec
            // 
            this.clmrawmaterialcodsec.HeaderText = "codsec";
            this.clmrawmaterialcodsec.Name = "clmrawmaterialcodsec";
            this.clmrawmaterialcodsec.ReadOnly = true;
            this.clmrawmaterialcodsec.Visible = false;
            this.clmrawmaterialcodsec.Width = 50;
            // 
            // clmrawmaterialnumber
            // 
            this.clmrawmaterialnumber.HeaderText = "Nro.";
            this.clmrawmaterialnumber.Name = "clmrawmaterialnumber";
            this.clmrawmaterialnumber.ReadOnly = true;
            this.clmrawmaterialnumber.Width = 40;
            // 
            // clmrawmaterialprovider
            // 
            this.clmrawmaterialprovider.HeaderText = "Proveeedor";
            this.clmrawmaterialprovider.Name = "clmrawmaterialprovider";
            this.clmrawmaterialprovider.ReadOnly = true;
            this.clmrawmaterialprovider.Width = 110;
            // 
            // clmrawmaterialmaterialtype
            // 
            this.clmrawmaterialmaterialtype.HeaderText = "Tipo Materia";
            this.clmrawmaterialmaterialtype.Name = "clmrawmaterialmaterialtype";
            this.clmrawmaterialmaterialtype.ReadOnly = true;
            this.clmrawmaterialmaterialtype.Width = 120;
            // 
            // clmrawmaterialname
            // 
            this.clmrawmaterialname.HeaderText = "Nombre";
            this.clmrawmaterialname.Name = "clmrawmaterialname";
            this.clmrawmaterialname.ReadOnly = true;
            this.clmrawmaterialname.Width = 120;
            // 
            // clmrawmaterialmycode
            // 
            this.clmrawmaterialmycode.HeaderText = "ID";
            this.clmrawmaterialmycode.Name = "clmrawmaterialmycode";
            this.clmrawmaterialmycode.ReadOnly = true;
            this.clmrawmaterialmycode.Width = 80;
            // 
            // clmrawmaterialgrossweigth
            // 
            this.clmrawmaterialgrossweigth.HeaderText = "P. Bruto";
            this.clmrawmaterialgrossweigth.Name = "clmrawmaterialgrossweigth";
            this.clmrawmaterialgrossweigth.Width = 80;
            // 
            // clmrawmaterialnetweigth
            // 
            this.clmrawmaterialnetweigth.HeaderText = "P. Neto";
            this.clmrawmaterialnetweigth.Name = "clmrawmaterialnetweigth";
            this.clmrawmaterialnetweigth.Width = 80;
            // 
            // clmrawmaterialbag
            // 
            this.clmrawmaterialbag.HeaderText = "Sacos";
            this.clmrawmaterialbag.Name = "clmrawmaterialbag";
            this.clmrawmaterialbag.Width = 70;
            // 
            // clmrawmateriallotnumber
            // 
            this.clmrawmateriallotnumber.HeaderText = "Lote";
            this.clmrawmateriallotnumber.Name = "clmrawmateriallotnumber";
            this.clmrawmateriallotnumber.ReadOnly = true;
            this.clmrawmateriallotnumber.Width = 80;
            // 
            // clmrawmaterialcode
            // 
            this.clmrawmaterialcode.HeaderText = "Código";
            this.clmrawmaterialcode.Name = "clmrawmaterialcode";
            this.clmrawmaterialcode.ReadOnly = true;
            this.clmrawmaterialcode.Width = 180;
            // 
            // clmrawmaterialdelete
            // 
            this.clmrawmaterialdelete.HeaderText = "";
            this.clmrawmaterialdelete.Name = "clmrawmaterialdelete";
            this.clmrawmaterialdelete.ReadOnly = true;
            this.clmrawmaterialdelete.Width = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1098, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Materia Prima";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPro);
            this.panel1.Controls.Add(this.cmbRawMaterial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 61);
            this.panel1.TabIndex = 47;
            // 
            // btnPro
            // 
            this.btnPro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPro.BackgroundImage = global::BPS.Raw.Properties.Resources.box1;
            this.btnPro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPro.Location = new System.Drawing.Point(643, 14);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(25, 25);
            this.btnPro.TabIndex = 47;
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // cmbRawMaterial
            // 
            this.cmbRawMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRawMaterial.FormattingEnabled = true;
            this.cmbRawMaterial.Location = new System.Drawing.Point(42, 16);
            this.cmbRawMaterial.Name = "cmbRawMaterial";
            this.cmbRawMaterial.Size = new System.Drawing.Size(596, 23);
            this.cmbRawMaterial.TabIndex = 0;
            this.cmbRawMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbRawMaterial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "MP";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblPro);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lbltmp);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(676, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 61);
            this.panel2.TabIndex = 48;
            // 
            // lblPro
            // 
            this.lblPro.AutoSize = true;
            this.lblPro.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPro.Location = new System.Drawing.Point(83, 35);
            this.lblPro.Name = "lblPro";
            this.lblPro.Size = new System.Drawing.Size(0, 15);
            this.lblPro.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 15);
            this.label11.TabIndex = 49;
            this.label11.Text = "Proveedor";
            // 
            // lbltmp
            // 
            this.lbltmp.AutoSize = true;
            this.lbltmp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltmp.Location = new System.Drawing.Point(83, 10);
            this.lbltmp.Name = "lbltmp";
            this.lbltmp.Size = new System.Drawing.Size(0, 15);
            this.lbltmp.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "TMP";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txttotalwe);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.cbsilo);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtpalletbag);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtNotes);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtnetweigthbag);
            this.panel4.Controls.Add(this.txtLotnumber);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.nupdnumber);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 36);
            this.panel4.TabIndex = 48;
            // 
            // txttotalwe
            // 
            this.txttotalwe.Location = new System.Drawing.Point(229, 6);
            this.txttotalwe.Name = "txttotalwe";
            this.txttotalwe.Size = new System.Drawing.Size(106, 21);
            this.txttotalwe.TabIndex = 49;
            this.txttotalwe.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(160, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "Peso Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Silo";
            // 
            // cbsilo
            // 
            this.cbsilo.FormattingEnabled = true;
            this.cbsilo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbsilo.Location = new System.Drawing.Point(94, 4);
            this.cbsilo.Name = "cbsilo";
            this.cbsilo.Size = new System.Drawing.Size(57, 23);
            this.cbsilo.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(685, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 46;
            this.label7.Text = "Notas";
            // 
            // txtpalletbag
            // 
            this.txtpalletbag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpalletbag.Location = new System.Drawing.Point(97, 6);
            this.txtpalletbag.Name = "txtpalletbag";
            this.txtpalletbag.Size = new System.Drawing.Size(57, 21);
            this.txtpalletbag.TabIndex = 1;
            this.txtpalletbag.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackgroundImage = global::BPS.Raw.Properties.Resources.gear_16;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(1059, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(724, 6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(329, 25);
            this.txtNotes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sacos x Pallet";
            // 
            // txtnetweigthbag
            // 
            this.txtnetweigthbag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnetweigthbag.Location = new System.Drawing.Point(229, 6);
            this.txtnetweigthbag.Name = "txtnetweigthbag";
            this.txtnetweigthbag.Size = new System.Drawing.Size(57, 21);
            this.txtnetweigthbag.TabIndex = 2;
            this.txtnetweigthbag.Text = "0";
            // 
            // txtLotnumber
            // 
            this.txtLotnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLotnumber.Location = new System.Drawing.Point(491, 7);
            this.txtLotnumber.Name = "txtLotnumber";
            this.txtLotnumber.Size = new System.Drawing.Size(188, 21);
            this.txtLotnumber.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Lote";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad Pallets";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peso Saco";
            // 
            // nupdnumber
            // 
            this.nupdnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nupdnumber.Location = new System.Drawing.Point(391, 6);
            this.nupdnumber.Name = "nupdnumber";
            this.nupdnumber.Size = new System.Drawing.Size(57, 21);
            this.nupdnumber.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblgrossweigth);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lblTotalNetWeigth);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 449);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1098, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lblgrossweigth
            // 
            this.lblgrossweigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgrossweigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblgrossweigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrossweigth.Location = new System.Drawing.Point(367, 12);
            this.lblgrossweigth.Name = "lblgrossweigth";
            this.lblgrossweigth.Size = new System.Drawing.Size(178, 25);
            this.lblgrossweigth.TabIndex = 48;
            this.lblgrossweigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Peso Bruto";
            // 
            // lblTotalNetWeigth
            // 
            this.lblTotalNetWeigth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalNetWeigth.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNetWeigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNetWeigth.Location = new System.Drawing.Point(621, 11);
            this.lblTotalNetWeigth.Name = "lblTotalNetWeigth";
            this.lblTotalNetWeigth.Size = new System.Drawing.Size(178, 25);
            this.lblTotalNetWeigth.TabIndex = 46;
            this.lblTotalNetWeigth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 45;
            this.label5.Text = "Peso Neto";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackgroundImage = global::BPS.Raw.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(1067, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmInRaw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1112, 526);
            this.Controls.Add(this.tbcRawMaterial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInRaw";
            this.Text = "Ingreso Materia Prima";
            this.tbcRawMaterial.ResumeLayout(false);
            this.tbpRawMaterial.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupdnumber)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcRawMaterial;
        private System.Windows.Forms.TabPage tbpRawMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.TextBox txtnetweigthbag;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpalletbag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRawMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupdnumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalNetWeigth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLotnumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgrossweigth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialcodsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialprovider;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialmaterialtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialmycode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialgrossweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialnetweigth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialbag;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmateriallotnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrawmaterialcode;
        private System.Windows.Forms.DataGridViewImageColumn clmrawmaterialdelete;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbltmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.ComboBox cbsilo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotalwe;
        private System.Windows.Forms.Label label12;
    }
}