namespace BPS.Lite
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ttpLogin = new System.Windows.Forms.ToolTip(this.components);
            this.pbxSettings = new System.Windows.Forms.PictureBox();
            this.pbxLogin = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.pbxInfo = new System.Windows.Forms.PictureBox();
            this.pbxError = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxError)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(231, 32);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 17);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Usuario";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(231, 65);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(302, 29);
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
            this.txtPassword.Location = new System.Drawing.Point(302, 62);
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
            this.lblMessage.Location = new System.Drawing.Point(243, 125);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(216, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2, 131);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // pbxSettings
            // 
            this.pbxSettings.Image = global::BPS.Lite.Properties.Resources.gear_16;
            this.pbxSettings.Location = new System.Drawing.Point(0, 0);
            this.pbxSettings.Name = "pbxSettings";
            this.pbxSettings.Size = new System.Drawing.Size(20, 20);
            this.pbxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSettings.TabIndex = 13;
            this.pbxSettings.TabStop = false;
            this.pbxSettings.Visible = false;
            this.pbxSettings.Click += new System.EventHandler(this.pbxSettings_Click);
            // 
            // pbxLogin
            // 
            this.pbxLogin.Image = global::BPS.Lite.Properties.Resources.login3;
            this.pbxLogin.Location = new System.Drawing.Point(9, 21);
            this.pbxLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pbxLogin.Name = "pbxLogin";
            this.pbxLogin.Size = new System.Drawing.Size(196, 100);
            this.pbxLogin.TabIndex = 14;
            this.pbxLogin.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::BPS.Lite.Properties.Resources.accept;
            this.btnOK.Location = new System.Drawing.Point(407, 95);
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
            this.pbxInfo.Image = global::BPS.Lite.Properties.Resources.clear;
            this.pbxInfo.Location = new System.Drawing.Point(219, 123);
            this.pbxInfo.Name = "pbxInfo";
            this.pbxInfo.Size = new System.Drawing.Size(20, 20);
            this.pbxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxInfo.TabIndex = 7;
            this.pbxInfo.TabStop = false;
            // 
            // pbxError
            // 
            this.pbxError.Image = global::BPS.Lite.Properties.Resources.stop_16;
            this.pbxError.Location = new System.Drawing.Point(219, 123);
            this.pbxError.Name = "pbxError";
            this.pbxError.Size = new System.Drawing.Size(20, 20);
            this.pbxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxError.TabIndex = 8;
            this.pbxError.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::BPS.Lite.Properties.Resources.cross;
            this.btnCancel.Location = new System.Drawing.Point(432, 95);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 5;
            this.ttpLogin.SetToolTip(this.btnCancel, "Cancelar");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(466, 143);
            this.Controls.Add(this.pbxSettings);
            this.Controls.Add(this.pbxLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pbxInfo);
            this.Controls.Add(this.pbxError);
            this.Controls.Add(this.btnCancel);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxError)).EndInit();
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
        private System.Windows.Forms.PictureBox pbxInfo;
        private System.Windows.Forms.PictureBox pbxError;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxSettings;
        private System.Windows.Forms.ToolTip ttpLogin;
        private System.Windows.Forms.PictureBox pbxLogin;


    }
}