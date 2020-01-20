namespace BPS.Manager.User
{
    partial class frmManagerUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagerUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbDetails = new System.Windows.Forms.GroupBox();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tbpAdd = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddUserSave = new System.Windows.Forms.Button();
            this.btnAddUserExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtManager = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepartament = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.tbpUpdate = new System.Windows.Forms.TabPage();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.tbpDelete = new System.Windows.Forms.TabPage();
            this.tbpReActive = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtReactivationNotes = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnReactivationSave = new System.Windows.Forms.Button();
            this.btnReactivationExit = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbReactivationPriority = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbReactivationUser = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtUpdateNotes = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.btnUpdateExit = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbUpdatePriority = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbUpdateUser = new System.Windows.Forms.ComboBox();
            this.cmbUpdateRol = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtDeleteNotes = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSave = new System.Windows.Forms.Button();
            this.btnDeleteExit = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cmbDeletePritority = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbDeleteUser = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grpbDetails.SuspendLayout();
            this.tbcMain.SuspendLayout();
            this.tbpAdd.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpUpdate.SuspendLayout();
            this.tbpDelete.SuspendLayout();
            this.tbpReActive.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 41);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(203, 12);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(269, 23);
            this.cmbType.TabIndex = 3;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Solicitud";
            // 
            // grpbDetails
            // 
            this.grpbDetails.Controls.Add(this.tbcMain);
            this.grpbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDetails.Location = new System.Drawing.Point(0, 41);
            this.grpbDetails.Name = "grpbDetails";
            this.grpbDetails.Size = new System.Drawing.Size(572, 328);
            this.grpbDetails.TabIndex = 7;
            this.grpbDetails.TabStop = false;
            this.grpbDetails.Text = "Detalles";
            this.grpbDetails.Visible = false;
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tbpAdd);
            this.tbcMain.Controls.Add(this.tbpReActive);
            this.tbcMain.Controls.Add(this.tbpUpdate);
            this.tbcMain.Controls.Add(this.tbpDelete);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(3, 17);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(566, 308);
            this.tbcMain.TabIndex = 6;
            // 
            // tbpAdd
            // 
            this.tbpAdd.Controls.Add(this.groupBox3);
            this.tbpAdd.Controls.Add(this.groupBox4);
            this.tbpAdd.Controls.Add(this.groupBox2);
            this.tbpAdd.Location = new System.Drawing.Point(4, 24);
            this.tbpAdd.Name = "tbpAdd";
            this.tbpAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdd.Size = new System.Drawing.Size(558, 280);
            this.tbpAdd.TabIndex = 0;
            this.tbpAdd.Text = "Creación";
            this.tbpAdd.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNotes);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtLastName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtFirstName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 107);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles de Usuario a Crear";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(159, 55);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(387, 46);
            this.txtNotes.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Descripción de Trabajo";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(344, 28);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 21);
            this.txtLastName.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Apellido";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(77, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(207, 21);
            this.txtFirstName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nombre";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddUserSave);
            this.groupBox4.Controls.Add(this.btnAddUserExit);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(552, 37);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            // 
            // btnAddUserSave
            // 
            this.btnAddUserSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUserSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnAddUserSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUserSave.Location = new System.Drawing.Point(497, 10);
            this.btnAddUserSave.Name = "btnAddUserSave";
            this.btnAddUserSave.Size = new System.Drawing.Size(25, 25);
            this.btnAddUserSave.TabIndex = 28;
            this.btnAddUserSave.UseVisualStyleBackColor = true;
            this.btnAddUserSave.Click += new System.EventHandler(this.btnAddUserSave_Click);
            // 
            // btnAddUserExit
            // 
            this.btnAddUserExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUserExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnAddUserExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddUserExit.Location = new System.Drawing.Point(524, 10);
            this.btnAddUserExit.Name = "btnAddUserExit";
            this.btnAddUserExit.Size = new System.Drawing.Size(25, 25);
            this.btnAddUserExit.TabIndex = 27;
            this.btnAddUserExit.UseVisualStyleBackColor = true;
            this.btnAddUserExit.Click += new System.EventHandler(this.btnAddUserExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtManager);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDepartament);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbPriority);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbRol);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txtManager
            // 
            this.txtManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManager.Location = new System.Drawing.Point(168, 101);
            this.txtManager.Name = "txtManager";
            this.txtManager.Size = new System.Drawing.Size(377, 21);
            this.txtManager.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jefe Inmediato";
            // 
            // txtDepartament
            // 
            this.txtDepartament.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDepartament.Location = new System.Drawing.Point(168, 74);
            this.txtDepartament.Name = "txtDepartament";
            this.txtDepartament.Size = new System.Drawing.Size(377, 21);
            this.txtDepartament.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departamento";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Location = new System.Drawing.Point(168, 16);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(172, 23);
            this.cmbPriority.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prioridad";
            // 
            // cmbRol
            // 
            this.cmbRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(168, 45);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(294, 23);
            this.cmbRol.TabIndex = 13;
            // 
            // tbpUpdate
            // 
            this.tbpUpdate.Controls.Add(this.groupBox8);
            this.tbpUpdate.Controls.Add(this.groupBox9);
            this.tbpUpdate.Controls.Add(this.groupBox10);
            this.tbpUpdate.Location = new System.Drawing.Point(4, 24);
            this.tbpUpdate.Name = "tbpUpdate";
            this.tbpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUpdate.Size = new System.Drawing.Size(558, 280);
            this.tbpUpdate.TabIndex = 1;
            this.tbpUpdate.Text = "Reactivación";
            this.tbpUpdate.UseVisualStyleBackColor = true;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "ruby_add.png");
            this.imgList.Images.SetKeyName(1, "ruby_delete.png");
            this.imgList.Images.SetKeyName(2, "ruby_gear.png");
            // 
            // tbpDelete
            // 
            this.tbpDelete.Controls.Add(this.groupBox11);
            this.tbpDelete.Controls.Add(this.groupBox12);
            this.tbpDelete.Controls.Add(this.groupBox13);
            this.tbpDelete.Location = new System.Drawing.Point(4, 24);
            this.tbpDelete.Name = "tbpDelete";
            this.tbpDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDelete.Size = new System.Drawing.Size(558, 280);
            this.tbpDelete.TabIndex = 2;
            this.tbpDelete.Text = "Eliminar";
            this.tbpDelete.UseVisualStyleBackColor = true;
            // 
            // tbpReActive
            // 
            this.tbpReActive.Controls.Add(this.groupBox5);
            this.tbpReActive.Controls.Add(this.groupBox6);
            this.tbpReActive.Controls.Add(this.groupBox7);
            this.tbpReActive.Location = new System.Drawing.Point(4, 24);
            this.tbpReActive.Name = "tbpReActive";
            this.tbpReActive.Padding = new System.Windows.Forms.Padding(3);
            this.tbpReActive.Size = new System.Drawing.Size(558, 280);
            this.tbpReActive.TabIndex = 3;
            this.tbpReActive.Text = "Reactive";
            this.tbpReActive.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtReactivationNotes);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(552, 161);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Detalles de Usuario a Reactivar";
            // 
            // txtReactivationNotes
            // 
            this.txtReactivationNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReactivationNotes.Location = new System.Drawing.Point(3, 17);
            this.txtReactivationNotes.Multiline = true;
            this.txtReactivationNotes.Name = "txtReactivationNotes";
            this.txtReactivationNotes.Size = new System.Drawing.Size(546, 141);
            this.txtReactivationNotes.TabIndex = 23;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnReactivationSave);
            this.groupBox6.Controls.Add(this.btnReactivationExit);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 240);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(552, 37);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            // 
            // btnReactivationSave
            // 
            this.btnReactivationSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReactivationSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnReactivationSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReactivationSave.Location = new System.Drawing.Point(495, 10);
            this.btnReactivationSave.Name = "btnReactivationSave";
            this.btnReactivationSave.Size = new System.Drawing.Size(25, 25);
            this.btnReactivationSave.TabIndex = 28;
            this.btnReactivationSave.UseVisualStyleBackColor = true;
            this.btnReactivationSave.Click += new System.EventHandler(this.btnReactivationSave_Click);
            // 
            // btnReactivationExit
            // 
            this.btnReactivationExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReactivationExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnReactivationExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReactivationExit.Location = new System.Drawing.Point(522, 10);
            this.btnReactivationExit.Name = "btnReactivationExit";
            this.btnReactivationExit.Size = new System.Drawing.Size(25, 25);
            this.btnReactivationExit.TabIndex = 27;
            this.btnReactivationExit.UseVisualStyleBackColor = true;
            this.btnReactivationExit.Click += new System.EventHandler(this.btnReactivationExit_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbReactivationUser);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.cmbReactivationPriority);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(552, 76);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(112, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "Usuario";
            // 
            // cmbReactivationPriority
            // 
            this.cmbReactivationPriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReactivationPriority.FormattingEnabled = true;
            this.cmbReactivationPriority.Location = new System.Drawing.Point(168, 16);
            this.cmbReactivationPriority.Name = "cmbReactivationPriority";
            this.cmbReactivationPriority.Size = new System.Drawing.Size(172, 23);
            this.cmbReactivationPriority.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(105, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 15);
            this.label16.TabIndex = 10;
            this.label16.Text = "Prioridad";
            // 
            // cmbReactivationUser
            // 
            this.cmbReactivationUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReactivationUser.FormattingEnabled = true;
            this.cmbReactivationUser.Location = new System.Drawing.Point(168, 45);
            this.cmbReactivationUser.Name = "cmbReactivationUser";
            this.cmbReactivationUser.Size = new System.Drawing.Size(294, 23);
            this.cmbReactivationUser.TabIndex = 18;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtUpdateNotes);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Location = new System.Drawing.Point(3, 108);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(552, 132);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Detalles de Usuario a Modificar (Cambio de Puesto)";
            // 
            // txtUpdateNotes
            // 
            this.txtUpdateNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdateNotes.Location = new System.Drawing.Point(3, 17);
            this.txtUpdateNotes.Multiline = true;
            this.txtUpdateNotes.Name = "txtUpdateNotes";
            this.txtUpdateNotes.Size = new System.Drawing.Size(546, 112);
            this.txtUpdateNotes.TabIndex = 23;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnUpdateSave);
            this.groupBox9.Controls.Add(this.btnUpdateExit);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox9.Location = new System.Drawing.Point(3, 240);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(552, 37);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnUpdateSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateSave.Location = new System.Drawing.Point(497, 10);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(25, 25);
            this.btnUpdateSave.TabIndex = 28;
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // btnUpdateExit
            // 
            this.btnUpdateExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnUpdateExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateExit.Location = new System.Drawing.Point(524, 10);
            this.btnUpdateExit.Name = "btnUpdateExit";
            this.btnUpdateExit.Size = new System.Drawing.Size(25, 25);
            this.btnUpdateExit.TabIndex = 27;
            this.btnUpdateExit.UseVisualStyleBackColor = true;
            this.btnUpdateExit.Click += new System.EventHandler(this.btnUpdateExit_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cmbUpdateRol);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.cmbUpdatePriority);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.cmbUpdateUser);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(552, 105);
            this.groupBox10.TabIndex = 12;
            this.groupBox10.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Rol";
            // 
            // cmbUpdatePriority
            // 
            this.cmbUpdatePriority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUpdatePriority.FormattingEnabled = true;
            this.cmbUpdatePriority.Location = new System.Drawing.Point(168, 16);
            this.cmbUpdatePriority.Name = "cmbUpdatePriority";
            this.cmbUpdatePriority.Size = new System.Drawing.Size(172, 23);
            this.cmbUpdatePriority.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(112, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Usuario";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(105, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 15);
            this.label17.TabIndex = 10;
            this.label17.Text = "Prioridad";
            // 
            // cmbUpdateUser
            // 
            this.cmbUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUpdateUser.FormattingEnabled = true;
            this.cmbUpdateUser.Location = new System.Drawing.Point(168, 45);
            this.cmbUpdateUser.Name = "cmbUpdateUser";
            this.cmbUpdateUser.Size = new System.Drawing.Size(294, 23);
            this.cmbUpdateUser.TabIndex = 13;
            // 
            // cmbUpdateRol
            // 
            this.cmbUpdateRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUpdateRol.FormattingEnabled = true;
            this.cmbUpdateRol.Location = new System.Drawing.Point(168, 74);
            this.cmbUpdateRol.Name = "cmbUpdateRol";
            this.cmbUpdateRol.Size = new System.Drawing.Size(294, 23);
            this.cmbUpdateRol.TabIndex = 15;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtDeleteNotes);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox11.Location = new System.Drawing.Point(3, 77);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(552, 163);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Detalles de Usuario a Eliminar";
            // 
            // txtDeleteNotes
            // 
            this.txtDeleteNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDeleteNotes.Location = new System.Drawing.Point(3, 17);
            this.txtDeleteNotes.Multiline = true;
            this.txtDeleteNotes.Name = "txtDeleteNotes";
            this.txtDeleteNotes.Size = new System.Drawing.Size(546, 143);
            this.txtDeleteNotes.TabIndex = 23;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnDeleteSave);
            this.groupBox12.Controls.Add(this.btnDeleteExit);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox12.Location = new System.Drawing.Point(3, 240);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(552, 37);
            this.groupBox12.TabIndex = 17;
            this.groupBox12.TabStop = false;
            // 
            // btnDeleteSave
            // 
            this.btnDeleteSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnDeleteSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteSave.Location = new System.Drawing.Point(497, 10);
            this.btnDeleteSave.Name = "btnDeleteSave";
            this.btnDeleteSave.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteSave.TabIndex = 28;
            this.btnDeleteSave.UseVisualStyleBackColor = true;
            this.btnDeleteSave.Click += new System.EventHandler(this.btnDeleteSave_Click);
            // 
            // btnDeleteExit
            // 
            this.btnDeleteExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteExit.BackgroundImage = global::BPS.Properties.Resources.door_in;
            this.btnDeleteExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteExit.Location = new System.Drawing.Point(524, 10);
            this.btnDeleteExit.Name = "btnDeleteExit";
            this.btnDeleteExit.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteExit.TabIndex = 27;
            this.btnDeleteExit.UseVisualStyleBackColor = true;
            this.btnDeleteExit.Click += new System.EventHandler(this.btnDeleteExit_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cmbDeletePritority);
            this.groupBox13.Controls.Add(this.label10);
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.cmbDeleteUser);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(552, 74);
            this.groupBox13.TabIndex = 15;
            this.groupBox13.TabStop = false;
            // 
            // cmbDeletePritority
            // 
            this.cmbDeletePritority.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeletePritority.FormattingEnabled = true;
            this.cmbDeletePritority.Location = new System.Drawing.Point(168, 16);
            this.cmbDeletePritority.Name = "cmbDeletePritority";
            this.cmbDeletePritority.Size = new System.Drawing.Size(172, 23);
            this.cmbDeletePritority.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(105, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Prioridad";
            // 
            // cmbDeleteUser
            // 
            this.cmbDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDeleteUser.FormattingEnabled = true;
            this.cmbDeleteUser.Location = new System.Drawing.Point(168, 45);
            this.cmbDeleteUser.Name = "cmbDeleteUser";
            this.cmbDeleteUser.Size = new System.Drawing.Size(294, 23);
            this.cmbDeleteUser.TabIndex = 13;
            // 
            // frmManagerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(572, 369);
            this.Controls.Add(this.grpbDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagerUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbDetails.ResumeLayout(false);
            this.tbcMain.ResumeLayout(false);
            this.tbpAdd.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpUpdate.ResumeLayout(false);
            this.tbpDelete.ResumeLayout(false);
            this.tbpReActive.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbDetails;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tbpAdd;
        private System.Windows.Forms.TabPage tbpUpdate;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtManager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartament;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddUserSave;
        private System.Windows.Forms.Button btnAddUserExit;
        private System.Windows.Forms.TabPage tbpDelete;
        private System.Windows.Forms.TabPage tbpReActive;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtReactivationNotes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReactivationSave;
        private System.Windows.Forms.Button btnReactivationExit;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbReactivationPriority;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbReactivationUser;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtUpdateNotes;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Button btnUpdateExit;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbUpdatePriority;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbUpdateUser;
        private System.Windows.Forms.ComboBox cmbUpdateRol;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox txtDeleteNotes;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnDeleteSave;
        private System.Windows.Forms.Button btnDeleteExit;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cmbDeletePritority;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDeleteUser;

    }
}