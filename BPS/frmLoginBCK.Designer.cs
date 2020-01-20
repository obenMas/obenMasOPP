namespace BPS
{
    partial class frmLoginBCK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginBCK));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.pbxInfo = new System.Windows.Forms.PictureBox();
            this.pbxError = new System.Windows.Forms.PictureBox();
            this.lblOben = new System.Windows.Forms.Label();
            this.lblPlus = new System.Windows.Forms.Label();
            this.pbxSettings = new System.Windows.Forms.PictureBox();
            this.ttpLogin = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(20, 145);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(15, 176);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(96, 142);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 23);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyUp);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(96, 173);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(26, 103);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(273, 17);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Por favor ingrese su usuario y contraseña";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(87, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 84);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pbxLogin
            // 
            this.pbxLogin.Image = global::BPS.Properties.Resources.login;
            this.pbxLogin.Location = new System.Drawing.Point(0, 0);
            this.pbxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(300, 100);
            this.pbxLogin.TabIndex = 6;
            this.pbxLogin.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Properties.Resources.cross;
            this.btnCancel.Location = new System.Drawing.Point(259, 171);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 5;
            this.ttpLogin.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Image = global::BPS.Properties.Resources.accept;
            this.btnOK.Location = new System.Drawing.Point(259, 142);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(25, 25);
            this.btnOK.TabIndex = 4;
            this.ttpLogin.SetToolTip(this.btnOK, "Login");
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // pbxInfo
            // 
            this.pbxInfo.Image = global::BPS.Properties.Resources.info_16;
            this.pbxInfo.Location = new System.Drawing.Point(0, 101);
            this.pbxInfo.Name = "pbxInfo";
            this.pbxInfo.Size = new System.Drawing.Size(20, 20);
            this.pbxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxInfo.TabIndex = 7;
            this.pbxInfo.TabStop = false;
            // 
            // pbxError
            // 
            this.pbxError.Image = global::BPS.Properties.Resources.stop_16;
            this.pbxError.Location = new System.Drawing.Point(0, 101);
            this.pbxError.Name = "pbxError";
            this.pbxError.Size = new System.Drawing.Size(20, 20);
            this.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxError.TabIndex = 8;
            this.pbxError.TabStop = false;
            // 
            // lblOben
            // 
            this.lblOben.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblOben.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOben.ForeColor = System.Drawing.Color.Silver;
            this.lblOben.Location = new System.Drawing.Point(-1, 225);
            this.lblOben.Margin = new System.Windows.Forms.Padding(0);
            this.lblOben.Name = "lblOben";
            this.lblOben.Size = new System.Drawing.Size(207, 49);
            this.lblOben.TabIndex = 11;
            this.lblOben.Text = "oben";
            this.lblOben.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPlus
            // 
            this.lblPlus.BackColor = System.Drawing.Color.Silver;
            this.lblPlus.Font = new System.Drawing.Font("Calibri", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPlus.Location = new System.Drawing.Point(206, 225);
            this.lblPlus.Name = "lblPlus";
            this.lblPlus.Size = new System.Drawing.Size(93, 49);
            this.lblPlus.TabIndex = 12;
            this.lblPlus.Text = "mas";
            this.lblPlus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxSettings
            // 
            this.pbxSettings.Image = global::BPS.Properties.Resources.gear_16;
            this.pbxSettings.Location = new System.Drawing.Point(0, 254);
            this.pbxSettings.Name = "pbxSettings";
            this.pbxSettings.Size = new System.Drawing.Size(20, 20);
            this.pbxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSettings.TabIndex = 13;
            this.pbxSettings.TabStop = false;
            this.pbxSettings.Visible = false;
            this.pbxSettings.Click += new System.EventHandler(this.pbxSettings_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(299, 272);
            this.Controls.Add(this.pbxSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pbxInfo);
            this.Controls.Add(this.pbxError);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblOben);
            this.Controls.Add(this.lblPlus);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbxLogin;
        private System.Windows.Forms.PictureBox pbxInfo;
        private System.Windows.Forms.PictureBox pbxError;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOben;
        private System.Windows.Forms.Label lblPlus;
        private System.Windows.Forms.PictureBox pbxSettings;
        private System.Windows.Forms.ToolTip ttpLogin;


    }
}