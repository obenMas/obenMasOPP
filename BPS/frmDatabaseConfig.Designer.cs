namespace BPS
{
    partial class frmDatabaseConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabaseConfig));
            this.grpbDataBase = new System.Windows.Forms.GroupBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbSeparator = new System.Windows.Forms.GroupBox();
            this.ttpDatabaseConfig = new System.Windows.Forms.ToolTip(this.components);
            this.lblDatabaseEngine = new System.Windows.Forms.Label();
            this.cmbDatabaseEngine = new System.Windows.Forms.ComboBox();
            this.grpbDataBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbDataBase
            // 
            this.grpbDataBase.Controls.Add(this.cmbDatabaseEngine);
            this.grpbDataBase.Controls.Add(this.txtDataBase);
            this.grpbDataBase.Controls.Add(this.txtDBPassword);
            this.grpbDataBase.Controls.Add(this.txtUser);
            this.grpbDataBase.Controls.Add(this.txtServer);
            this.grpbDataBase.Controls.Add(this.lblDatabaseEngine);
            this.grpbDataBase.Controls.Add(this.lblDatabase);
            this.grpbDataBase.Controls.Add(this.lblPassword);
            this.grpbDataBase.Controls.Add(this.lblUser);
            this.grpbDataBase.Controls.Add(this.lbl);
            this.grpbDataBase.Controls.Add(this.btnValidate);
            this.grpbDataBase.Controls.Add(this.btnSave);
            this.grpbDataBase.Controls.Add(this.grpbSeparator);
            this.grpbDataBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbDataBase.Location = new System.Drawing.Point(0, 0);
            this.grpbDataBase.Name = "grpbDataBase";
            this.grpbDataBase.Size = new System.Drawing.Size(281, 198);
            this.grpbDataBase.TabIndex = 1;
            this.grpbDataBase.TabStop = false;
            this.grpbDataBase.Text = "Base de datos";
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(109, 106);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(162, 21);
            this.txtDataBase.TabIndex = 3;
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(109, 80);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.Size = new System.Drawing.Size(162, 21);
            this.txtDBPassword.TabIndex = 2;
            this.txtDBPassword.TextChanged += new System.EventHandler(this.txtDBPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(109, 54);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(162, 21);
            this.txtUser.TabIndex = 1;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(109, 28);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(162, 21);
            this.txtServer.TabIndex = 0;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(10, 109);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(85, 15);
            this.lblDatabase.TabIndex = 37;
            this.lblDatabase.Text = "Base de datos";
            this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(34, 83);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 37;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(45, 57);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 15);
            this.lblUser.TabIndex = 36;
            this.lblUser.Text = "Usuario";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(43, 31);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(52, 15);
            this.lbl.TabIndex = 35;
            this.lbl.Text = "Servidor";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnValidate
            // 
            this.btnValidate.BackgroundImage = global::BPS.Properties.Resources.accept;
            this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnValidate.Location = new System.Drawing.Point(221, 164);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(25, 25);
            this.btnValidate.TabIndex = 4;
            this.ttpDatabaseConfig.SetToolTip(this.btnValidate, "Validar Conexión");
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::BPS.Properties.Resources.disk;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(246, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(25, 25);
            this.btnSave.TabIndex = 5;
            this.ttpDatabaseConfig.SetToolTip(this.btnSave, "Guardar Conexión");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpbSeparator
            // 
            this.grpbSeparator.Location = new System.Drawing.Point(101, 17);
            this.grpbSeparator.Name = "grpbSeparator";
            this.grpbSeparator.Size = new System.Drawing.Size(2, 147);
            this.grpbSeparator.TabIndex = 0;
            this.grpbSeparator.TabStop = false;
            // 
            // lblDatabaseEngine
            // 
            this.lblDatabaseEngine.AutoSize = true;
            this.lblDatabaseEngine.Location = new System.Drawing.Point(36, 136);
            this.lblDatabaseEngine.Name = "lblDatabaseEngine";
            this.lblDatabaseEngine.Size = new System.Drawing.Size(59, 15);
            this.lblDatabaseEngine.TabIndex = 37;
            this.lblDatabaseEngine.Text = "Motor DB";
            this.lblDatabaseEngine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDatabaseEngine
            // 
            this.cmbDatabaseEngine.FormattingEnabled = true;
            this.cmbDatabaseEngine.Items.AddRange(new object[] {
            "MySql",
            "Sql Server"});
            this.cmbDatabaseEngine.Location = new System.Drawing.Point(109, 132);
            this.cmbDatabaseEngine.Name = "cmbDatabaseEngine";
            this.cmbDatabaseEngine.Size = new System.Drawing.Size(162, 23);
            this.cmbDatabaseEngine.TabIndex = 38;
            // 
            // frmDatabaseConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(281, 198);
            this.Controls.Add(this.grpbDataBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatabaseConfig";
            this.ShowInTaskbar = false;
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.frmDatabaseConfig_Load);
            this.grpbDataBase.ResumeLayout(false);
            this.grpbDataBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbDataBase;
        private System.Windows.Forms.GroupBox grpbSeparator;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolTip ttpDatabaseConfig;
        private System.Windows.Forms.ComboBox cmbDatabaseEngine;
        private System.Windows.Forms.Label lblDatabaseEngine;
    }
}